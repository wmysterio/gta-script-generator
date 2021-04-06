using GTA.Core;

namespace GTA.Plugins.Common {

    public sealed class RaceCheckpoint : BaseRace<RaceCheckpoint, SetupCheckpoint, PointTypeCheckpoint> {

        private Array<Int> TimeLimit;

        private Int CurrentStage = Script.local(),
                    NextPointIndex = Script.local();

        // ---------------------------------------------------------------------------------------------------------------------------

        public RaceCheckpoint() : base() {
            minDriversCount = 1;
            maxDriversCount = 1;
            timerType = TimerType.DOWN;
            useTimer = true;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected override void OnDefineVariables() {
            TimeLimit = Script.local_array( POOL_POINTS_COUNT );
        }

        protected override void OnInitVariables() {
            CurrentStage.value = 0;
        }

        protected override void OnPointSetup( ushort index ) {
            TimeLimit[ index ].value = raceSetup.points.pointT[ index ];
        }

        protected override void OnCarSetup( ushort index ) { }

        protected override void OnStart() {
            timer.value = TimeLimit[ 0 ];
            if( POOL_POINTS_COUNT == 1 ) {
                Checkpoint.create( X[ 0 ], Y[ 0 ], Z[ 0 ], X[ 0 ], Y[ 0 ], Z[ 0 ], true, 6.0 );
            } else {
                Checkpoint.create( X[ 0 ], Y[ 0 ], Z[ 0 ], X[ 1 ], Y[ 1 ], Z[ 1 ], false, 6.0 );
            }
            TargetPositionCheckpoint.create( X[ 0 ], Y[ 0 ], Z[ 0 ] );
        }

        protected override void OnUpdate() {
            Script.and( timer == 0, delegate {
                jump_failed( "BB_17" );
            } );
            if( POOL_POINTS_COUNT == 1 ) {
                Script.and( PlayerCar.is_near_point_3d( false, X[ 0 ], Y[ 0 ], Z[ 0 ], 12.0, 12.0, 12.0 ), delegate {
                    Mission.jump_passed();
                } );
            } else {
                Script.and( PlayerCar.is_near_point_3d( false, X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], 12.0, 12.0, 12.0 ), delegate {
                    Checkpoint.disable();
                    TargetPositionCheckpoint.disable();
                    CurrentStage += 1;
                    Script.and( CurrentStage > MAX_POINTS, delegate {
                        Mission.jump_passed();
                    } );
                    timer += TimeLimit[ CurrentStage ];
                    Script.play_audio_event_at_position( 0.0, 0.0, 0.0, 1058 );
                    NextPointIndex.add( CurrentStage, 1 );
                    Script.and( MAX_POINTS > NextPointIndex, delegate {
                        Checkpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], X[ NextPointIndex ], Y[ NextPointIndex ], Z[ NextPointIndex ], false, 6.0 );
                    }, delegate {
                        Checkpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], X[ NextPointIndex ], Y[ NextPointIndex ], Z[ NextPointIndex ], true, 6.0 );
                    } );
                    TargetPositionCheckpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ] );
                } );
            }
        }

        protected override void OnDraw() { }

    }

}