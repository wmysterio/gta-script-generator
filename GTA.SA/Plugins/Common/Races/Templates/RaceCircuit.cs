using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA.Plugins.Common {

    public sealed class RaceCircuit : BaseRace<RaceCircuit, SetupCircuit, PointTypeCircuit> {

        private Array<Float> Speed;
        private Array<Int> Stages, Laps;

        private Int Position = Script.local(),
                    NextPointIndex = Script.local(),
                    CurrentStage = Script.local(),
                    CurrentLap = Script.local(),
                    PlayerLap = Script.local();

        private Float TempCarPositionX = Script.local(),
                      TempCarPositionY = Script.local(),
                      TempCarPositionZ = Script.local(),
                      TempDistance1 = Script.local(),
                      TempDistance2 = Script.local();

        // ---------------------------------------------------------------------------------------------------------------------------

        public RaceCircuit() : base() {
            minDriversCount = 1;
            maxDriversCount = 99;
            timerType = TimerType.UP;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected override void CheckSetup() {
            base.CheckSetup();
            if( 2 > raceSetup.TOTAL_LAPS || raceSetup.TOTAL_LAPS > 99 )
                throw new Exception( Localization.PluginLapsCountFrom2To99( nameof( RaceMission ) ) );
            if( 2 > raceSetup.points.PoolCount )
                throw new Exception( Localization.PluginNeedPointsFrom2To99( nameof( RaceMission ) ) );
        }

        protected override void OnDefineVariables() {
            Speed = Script.local_array( POOL_POINTS_COUNT );
            Stages = Script.local_array( POOL_CARS_COUNT );
            Laps = Script.local_array( POOL_CARS_COUNT );
        }

        protected override void OnInitVariables() { }

        protected override void OnPointSetup( ushort index ) {
            Speed[ index ].value = raceSetup.points.pointS[ index ];
        }

        protected override void OnCarSetup( ushort index ) {
            Stages[ index ].value = 0;
            Laps[ index ].value = 1;
        }
        
        protected override void OnStart() {
            PlayerLap = Laps[ PLAYER_CAR_ARRAY_INDEX ];
            Checkpoint.create( X[ 0 ], Y[ 0 ], Z[ 0 ], X[ 1 ], Y[ 1 ], Z[ 1 ], false, 6.0 );
            TargetPositionCheckpoint.create( X[ 0 ], Y[ 0 ], Z[ 0 ] );
            Script.to( Index, 0, MAX_CARS, h => {
                Script.and( Index != PLAYER_CAR_ARRAY_INDEX, delegate {
                    Drivers[ Index ].task.drive_car_to_point( Cars[ Index ], X[ 0 ], Y[ 0 ], Z[ 0 ], Speed[ 0 ], 0, 0, TrafficBehavior.IGNORE_TRAFFIC_LIGHTS_AND_DRIVES_AROUND_OBSTACLES );
                } );
            } );
        }

        protected override void OnUpdate() {
            Script.to( Index, 0, MAX_CARS, h => {
                CurrentStage.value = Stages[ Index ];
                CurrentLap.value = Laps[ Index ];
                Script.and( Cars[ Index ].is_near_point_3d( 0, X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], 12.0, 12.0, 12.0 ), delegate {
                    CurrentStage += 1;
                    Script.and( CurrentStage > MAX_POINTS, delegate {
                        CurrentStage.value = 0;
                        CurrentLap += 1;
                    } );
                    Stages[ Index ].value = CurrentStage;
                    Laps[ Index ].value = CurrentLap;
                    Script.and( Index != PLAYER_CAR_ARRAY_INDEX, delegate {
                        Script.and( CurrentLap > raceSetup.TOTAL_LAPS, delegate {
                            Mission.jump_failed();
                        } );
                        Drivers[ Index ].task.drive_car_to_point( Cars[ Index ], X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], Speed[ CurrentStage ], 0, 0, TrafficBehavior.IGNORE_TRAFFIC_LIGHTS_AND_DRIVES_AROUND_OBSTACLES );
                        h.@continue();
                    } );
                    Checkpoint.disable();
                    TargetPositionCheckpoint.disable();
                    Script.and( CurrentLap > raceSetup.TOTAL_LAPS, delegate {
                        Mission.jump_passed();
                    } );
                    Script.play_audio_event_at_position( 0.0, 0.0, 0.0, 1058 );
                    Script.and( CurrentStage == 0, delegate {
                        Checkpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], X[ 1 ], Y[ 1 ], Z[ 1 ], false, 6.0 );
                    }, delegate {
                        NextPointIndex.add( CurrentStage, 1 );
                        Script.and( MAX_POINTS > NextPointIndex, delegate {
                            Checkpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], X[ NextPointIndex ], Y[ NextPointIndex ], Z[ NextPointIndex ], false, 6.0 );
                        }, delegate {
                            Script.and( CurrentLap == raceSetup.TOTAL_LAPS, delegate {
                                Checkpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], X[ NextPointIndex ], Y[ NextPointIndex ], Z[ NextPointIndex ], true, 6.0 );
                            }, delegate {
                                Checkpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], X[ NextPointIndex ], Y[ NextPointIndex ], Z[ NextPointIndex ], false, 6.0 );
                            } );
                        } );
                    } );
                    TargetPositionCheckpoint.create( X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ] );
                } );
            } );
            Script.gosub( CHECK_POSITION );
        }

        protected override void OnDraw() {
            Script.DRAW.set_color( 134, 155, 184, 255 )
                           .set_font( 3 )
                           .set_letter_scale( 1.0, 3.6 )
                           .set_align_right( true )
                           .set_linewidth( Script.DRAW.WIDTH )
                           .set_text_shadow( 2, 0, 0, 0, 180 )
                           .display_rectangle( 560.0, 356.2812, 98.2072, 74.2072, 0, 0, 0, 255 )
                           .display_rectangle( 560.0, 356.2812, 96.2072, 72.2072, 134, 155, 184, 255 )
                           .display_rectangle( 560.0, 356.2812, 92.2072, 70.2072, 0, 0, 0, 255 )
                           .display_text_with_1number( 600.0, 357.0, "RACES44", Position )
                           .set_letter_scale( 0.7, 2.0 )
                           .set_color( 134, 155, 184, 255 )
                           .display_text_with_2numbers( 518.0, 320.0, "RACES32", PlayerLap, raceSetup.TOTAL_LAPS );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void CHECK_POSITION( LabelGosub label ) {
            Position.value = 1;
            CurrentStage.value = Stages[ PLAYER_CAR_ARRAY_INDEX ];
            PlayerCar.get_position( TempCarPositionX, TempCarPositionY, TempCarPositionZ );
            Script.get_distance_3d( TempCarPositionX, TempCarPositionY, TempCarPositionZ, X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], TempDistance1 );
            Script.to( Index, 0, MAX_CARS, h => {
                Script.and( Index == PLAYER_CAR_ARRAY_INDEX, delegate {
                    h.@continue();
                } );
                Script.and( Laps[ Index ] > Laps[ PLAYER_CAR_ARRAY_INDEX ], delegate {
                    Position += 1;
                    h.@continue();
                } );
                Script.and( Laps[ PLAYER_CAR_ARRAY_INDEX ] > Laps[ Index ], delegate {
                    h.@continue();
                } );
                Script.and( Stages[ Index ] > Stages[ PLAYER_CAR_ARRAY_INDEX ], delegate {
                    Position += 1;
                    h.@continue();
                } );
                Script.and( Stages[ Index ] == Stages[ PLAYER_CAR_ARRAY_INDEX ], delegate {
                    CurrentStage.value = Stages[ Index ];
                    Cars[ Index ].get_position( TempCarPositionX, TempCarPositionY, TempCarPositionZ );
                    Script.get_distance_3d( TempCarPositionX, TempCarPositionY, TempCarPositionZ, X[ CurrentStage ], Y[ CurrentStage ], Z[ CurrentStage ], TempDistance2 );
                    Script.and( TempDistance1 > TempDistance2, delegate {
                        Position += 1;
                    } );
                } );
            } );
        }

    }

}