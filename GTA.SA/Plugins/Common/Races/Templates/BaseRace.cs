using System;
using System.Linq;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA.Plugins.Common {

    public abstract class BaseRace<T, K, M> where T : BaseRace<T, K, M>, new() where K : SetupBase<K, M>, new() where M : BasePointType<M>, new() {

        public delegate void RaceSetupHandler( K raceSetupHandler );

        // ---------------------------------------------------------------------------------------------------------------------------

        protected static Timer timer = null;

        // ---------------------------------------------------------------------------------------------------------------------------

        protected readonly K raceSetup;
        protected readonly Player PlayerChar;
        protected readonly Actor PlayerActor;

        // ---------------------------------------------------------------------------------------------------------------------------

        protected bool useTimer;
        protected int minDriversCount, maxDriversCount;
        protected TimerType timerType;
        protected ushort PLAYER_CAR_ARRAY_INDEX { get; private set; }
        protected ushort MAX_CARS { get; private set; }
        protected ushort MAX_POINTS { get; private set; }
        protected ushort POOL_CARS_COUNT { get; private set; }
        protected ushort POOL_POINTS_COUNT { get; private set; }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected Car PlayerCar { get; private set; }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected Array<Float> X, Y, Z;
        protected Array<Car> Cars;
        protected Array<Actor> Drivers;
        protected Array<Marker> Markers;

        protected sString FailedMessage = Script.local();
        protected Int Index = Script.local();
        protected GTA.RaceCheckpoint Checkpoint = Script.local();
        protected Checkpoint TargetPositionCheckpoint = Script.local();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal BaseRace() {
            if( Script.Current.ScriptType != TypeOfScript.MISSION )
                throw new Exception( Localization.PluginCreatedInNonMission( nameof( RaceMission ) ) );
            if( ( ( MissionCustom ) Script.Current ).IsCustom )
                throw new Exception( Localization.PluginCreatedInCustomMission( nameof( RaceMission ) ) );
            PlayerChar = Script.PlayerChar;
            PlayerActor = Script.PlayerActor;
            useTimer = false;
            raceSetup = new K();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected void jump_failed( string GXT ) { FailedMessage.value = GXT; Mission.jump_failed(); }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected abstract void OnDefineVariables();
        protected abstract void OnInitVariables();
        protected abstract void OnPointSetup( ushort index );
        protected abstract void OnCarSetup( ushort index );
        protected abstract void OnStart();
        protected abstract void OnUpdate();
        protected abstract void OnDraw();

        // ---------------------------------------------------------------------------------------------------------------------------

        protected virtual void CheckSetup() {
            if( raceSetup.cars.PoolCount > maxDriversCount )
                throw new Exception( Localization.PluginOverflowCarsCount( nameof( RaceMission ), maxDriversCount ) );
            if( minDriversCount > raceSetup.cars.PoolCount )
                throw new Exception( Localization.PluginNeedMinCarCount( nameof( RaceMission ), maxDriversCount ) );
            if( raceSetup.cars.PlayerIndexInPool == -1 )
                throw new Exception( Localization.PluginNeedPlayerCar( nameof( RaceMission ) ) );
            if( 1 > raceSetup.points.PoolCount || raceSetup.points.PoolCount > 99 )
                throw new Exception( Localization.PluginNeedPointsFrom1To99( nameof( RaceMission ) ) );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public void Create( RaceSetupHandler setup ) {
            if( setup == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( RaceMission ), nameof( RaceSetupHandler ) ) );
            Int[] _____getAllUniqueModels() {
                Int[] _____create_int_array( int[] from ) {
                    Int[] array = new Int[ from.Length ];
                    for( int i = 0; i < from.Length; i++ )
                        array[ i ] = from[ i ];
                    return array;
                }
                var carModels = raceSetup.cars.CarModels.Values.Distinct().ToArray();
                var driverModelsList = raceSetup.cars.DriverModels.Values.Distinct().ToList();
                driverModelsList.Remove( -1 );
                driverModelsList.AddRange( carModels );
                return _____create_int_array( driverModelsList.ToArray() );
            }

            setup.Invoke( raceSetup );
            CheckSetup();

            PLAYER_CAR_ARRAY_INDEX = ( ushort ) raceSetup.cars.PlayerIndexInPool;

            POOL_CARS_COUNT = ( ushort ) raceSetup.cars.PoolCount;
            POOL_POINTS_COUNT = ( ushort ) raceSetup.points.PoolCount;

            MAX_CARS = ( ushort ) ( raceSetup.cars.PoolCount - 1 );
            MAX_POINTS = ( ushort ) ( raceSetup.points.PoolCount - 1 );

            Script.set_ped_traffic_density_multiplier( 0.0 );
            Script.set_vehicle_traffic_density_multiplier( 0.0 );
            Script.PlayerGroup.release();
            Script.text_clear_all();
            Script.remove_text_box();
            Script.use_gxt_table( "RACETOR" );
            PlayerChar.enable_group_recruitment( false )
                      .clear_wanted_level()
                      .ignored_by_cops( true )
                      .ignored_by_everyone( true );
            if( raceSetup.isOverrideLockPlayer ) {
                PlayerChar.can_move( false );
                PlayerActor.set_immunities( true );
            }
            if( raceSetup.isOverrideFadeMode ) {
                Script.set_fade_color_rgb( 0, 0, 0 );
                Script.fade( FadeType.OUT, raceSetup.overridedFadeTime );
                Script.wait( Script.is_fading() );
            } else {
                Script.wait( !Script.is_fading() );
            }
            if( raceSetup.isOverrideStartTime )
                Script.set_current_time( raceSetup.overridedStartTimeHours, raceSetup.overridedStartTimeMinutes );
            if( raceSetup.isOverrideWeather )
                Script.set_weather( raceSetup.overridedWeatherID );

            #region DEFINE            
            X = Script.local_array( POOL_POINTS_COUNT );
            Y = Script.local_array( POOL_POINTS_COUNT );
            Z = Script.local_array( POOL_POINTS_COUNT );
            Markers = Script.local_array( POOL_CARS_COUNT );
            Cars = Script.local_array( POOL_CARS_COUNT );
            Drivers = Script.local_array( POOL_CARS_COUNT );
            PlayerCar = Cars[ PLAYER_CAR_ARRAY_INDEX ];
            OnDefineVariables();
            #endregion

            #region INIT
            FailedMessage.value = sString.DUMMY;
            OnInitVariables();
            #endregion

            Script.and( PlayerActor.is_in_any_car(), delegate {
                PlayerActor.remove_from_vehicle_and_place_at( raceSetup.cars.X[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Y[ PLAYER_CAR_ARRAY_INDEX ], -100.0 );
            }, delegate {
                PlayerActor.set_position( raceSetup.cars.X[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Y[ PLAYER_CAR_ARRAY_INDEX ], -100.0 );
            } );
            PlayerActor.lock_position( true );
            if( raceSetup.BeforeCreate != null )
                raceSetup.BeforeCreate.Invoke();
            var _____uniqueModels = _____getAllUniqueModels();
            Script.load_model( _____uniqueModels );
            Script.load_requested_models();
            for( ushort i = 0; i < POOL_POINTS_COUNT; i++ ) {
                X[ i ].value = raceSetup.points.pointX[ i ];
                Y[ i ].value = raceSetup.points.pointY[ i ];
                Z[ i ].value = raceSetup.points.pointZ[ i ];
                OnPointSetup( i );
            }
            if( POOL_CARS_COUNT == 1 ) {
                PlayerCar.create( raceSetup.cars.CarModels[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.X[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Y[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Z[ PLAYER_CAR_ARRAY_INDEX ] )
                         .set_z_angle( raceSetup.cars.Angles[ PLAYER_CAR_ARRAY_INDEX ] )
                         .set_door_status( DoorStatus.LOCKED_2 )
                         .set_immunities( true )
                         .set_tires_vulnerable( true );
                if( raceSetup.cars.carSetups[ 0 ] != null )
                    raceSetup.cars.carSetups[ 0 ].Invoke( Cars[ 0 ] );
                OnCarSetup( 0 );
                PlayerActor.lock_position( false )
                           .put_into_vehicle_as_driver( PlayerCar );
            } else {
                for( ushort i = 0; i < POOL_CARS_COUNT; i++ ) {
                    Cars[ i ].create( raceSetup.cars.CarModels[ i ], raceSetup.cars.X[ i ], raceSetup.cars.Y[ i ], raceSetup.cars.Z[ i ] )
                             .set_z_angle( raceSetup.cars.Angles[ i ] )
                             .set_door_status( DoorStatus.LOCKED_2 )
                             .set_immunities( true )
                             .set_tires_vulnerable( true );
                    if( raceSetup.cars.carSetups[ i ] != null )
                        raceSetup.cars.carSetups[ i ].Invoke( Cars[ i ] );
                    OnCarSetup( i );
                    if( i == PLAYER_CAR_ARRAY_INDEX ) {
                        PlayerActor.lock_position( false )
                                   .put_into_vehicle_as_driver( PlayerCar );
                        continue;
                    }
                    if( raceSetup.cars.DriverModels[ i ] == -1 ) {
                        Drivers[ i ].create_random_in_vehicle_as_driver( Cars[ i ] );
                    } else {
                        Drivers[ i ].create_in_vehicle_driverseat( ActorType.MISSION1, raceSetup.cars.DriverModels[ i ], Cars[ i ] );
                    }
                    Drivers[ i ].set_acquaintance( AcquaintanceType.RESPECT, ActorType.PLAYER );
                    Markers[ i ].create_above_vehicle( Cars[ i ] ).set_size( 1 ).set_type( true ).set_color( MarkerColor.RED );
                }
            }
            Script.set_radio_station( RadioStation.OFF );
            Script.destroy_model( _____uniqueModels );
            Script.set_all_vehicles_can_be_damaged( false );
            if( raceSetup.AfterCreate != null )
                raceSetup.AfterCreate.Invoke();
            Script.refresh_game_renderer( raceSetup.cars.X[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Y[ PLAYER_CAR_ARRAY_INDEX ] );
            Script.CAMERA.refresh( raceSetup.cars.X[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Y[ PLAYER_CAR_ARRAY_INDEX ], raceSetup.cars.Z[ PLAYER_CAR_ARRAY_INDEX ] ).restore_with_jumpcut();
            Script.wait( 2500 );
            Script.fade( FadeType.IN, 1000 );
            Script.wait( !Script.is_fading() );
            Script.show_text_styled( "RACES_4", 1100, 4 ); // 3
            Script.play_audio_event_at_position( 0.0, 0.0, 0.0, 1056 );
            Script.wait( 1100 );
            Script.show_text_styled( "RACES_5", 1100, 4 ); // 2
            Script.play_audio_event_at_position( 0.0, 0.0, 0.0, 1056 );
            Script.wait( 1100 );
            Script.show_text_styled( "RACES_6", 1100, 4 ); // 1
            Script.play_audio_event_at_position( 0.0, 0.0, 0.0, 1056 );
            Script.wait( 1100 );
            Script.show_text_styled( "RACES_7", 1100, 4 ); // GO!
            Script.play_audio_event_at_position( 0.0, 0.0, 0.0, 1057 );
            Script.set_all_vehicles_can_be_damaged( true );
            PlayerChar.can_move( true );
            PlayerActor.set_immunities( false );
            Script.DRAW.enable( true );
            OnStart();
            if( useTimer ) {
                if( ReferenceEquals( timer, null ) )
                    timer = Script.global();
                timer.start( timerType, "TIMER" );
            }

            Script.Cycle += RACE_LOOP;
            var mission = ( Mission ) Script.Current;

            mission.OnPassed = delegate {
                if( raceSetup.BeforePassed != null )
                    raceSetup.BeforePassed.Invoke();
                Script.play_music( MusicID.MISSION_PASSED );
                if( raceSetup.isOverrideRewardMoney )
                    Script.PlayerChar.add_money( raceSetup.overridedRewardMoney );
                if( raceSetup.isOverrideRewardRespect )
                    Script.add_respect( raceSetup.overridedRewardRespect );
                if( raceSetup.isOverrideRewardMoney && raceSetup.isOverrideRewardRespect ) {
                    Script.show_text_1number_styled( sString.M_PASSS, raceSetup.overridedRewardMoney, 4000, 1 );
                } else if( raceSetup.isOverrideRewardMoney ) {
                    Script.show_text_1number_styled( sString.M_PASS, raceSetup.overridedRewardMoney, 4000, 1 );
                } else if( raceSetup.isOverrideRewardRespect ) {
                    Script.show_text_styled( sString.M_PASSR, 4000, 1 );
                } else {
                    Script.show_text_styled( "RACES18", 4000, 1 ); // Winner!
                }
                if( raceSetup.AfterPassed != null )
                    raceSetup.AfterPassed.Invoke();
            };

            mission.OnFailed = delegate {
                if( raceSetup.BeforeFailed != null )
                    raceSetup.BeforeFailed.Invoke();
                Script.show_text_styled( "RACES_8", 4000, 1 ); // You failed!
                Script.and( FailedMessage != sString.DUMMY, delegate {
                    Script.show_text_lowpriority( FailedMessage, 6000, 1 );
                } );
                if( raceSetup.AfterFailed != null )
                    raceSetup.AfterFailed.Invoke();
            };

            mission.OnClear = delegate {
                Script.DRAW.enable( false );
                if( useTimer )
                    timer.stop();
                Checkpoint.disable();
                TargetPositionCheckpoint.disable();
                Script.set_ped_traffic_density_multiplier( 1.0 );
                Script.set_vehicle_traffic_density_multiplier( 1.0 );
                PlayerActor.lock_position( false );
                PlayerChar.enable_group_recruitment( true )
                          .ignored_by_cops( false )
                          .ignored_by_everyone( false );
                if( POOL_CARS_COUNT > 1 ) {
                    Script.to( Index, 0, MAX_CARS, h => {
                        Markers[ Index ].disable();
                        Script.and( Drivers[ Index ].is_defined(), delegate {
                            Drivers[ Index ].remove_references()
                                            .destroy();
                        } );
                        Script.and( Cars[ Index ].is_defined(), delegate {
                            Cars[ Index ].remove_references();
                            Script.and( Index == PLAYER_CAR_ARRAY_INDEX, delegate {
                                Script.and( PlayerActor.is_in_vehicle( PlayerCar ), delegate {
                                    PlayerCar.set_immunities( false )
                                             .set_door_status( DoorStatus.UNLOCKED )
                                             .set_tires_vulnerable( false );
                                }, delegate { PlayerCar.destroy(); } );
                            }, delegate {
                                Cars[ Index ].destroy();
                            } );
                        } );
                    } );
                } else {
                    Script.and( PlayerCar.is_defined(), delegate {
                        Script.and( PlayerActor.is_in_vehicle( PlayerCar ), delegate {
                            PlayerCar.remove_references()
                                     .set_immunities( false )
                                     .set_door_status( DoorStatus.UNLOCKED )
                                     .set_tires_vulnerable( false );
                        }, delegate { PlayerCar.remove_references().destroy(); } );
                    } );
                }
            };

        }

        private void RACE_LOOP() {
            Script.wait( 0 );
            Script.or( PlayerCar.is_wrecked(), PlayerCar.is_in_water(), delegate {
                jump_failed( "RACES25" );
            } );
            Script.and( !PlayerActor.is_in_vehicle( PlayerCar ), delegate {
                jump_failed( "RACES20" );
            } );
            OnUpdate();
            Script.gosub( DRAW );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void DRAW( LabelGosub label ) {
            OnDraw();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [System.Obsolete()]
        public override string ToString() { return base.ToString(); }
        [System.Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [System.Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [System.Obsolete()]
        public new System.Type GetType() { return base.GetType(); }

    }

}