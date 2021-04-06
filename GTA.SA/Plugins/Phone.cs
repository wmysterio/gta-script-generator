using System;
using System.Linq;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public delegate void HandlerDialogSetup( DialogSetup setup );
    public delegate void HandlerDialogData( DialogData setup );
    public delegate void HandlerPhoneSetup( PhoneSetup setup );

    public sealed class Phone {

        internal const int REPLICAS_LIMIT = 24;

        // ---------------------------------------------------------------------------------------------------------------------------

        private const int WAV_NUMBER = 1;
        private const int PHONE_MODEL = Script.CELLPHONE;

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Phone instance = null;

        // ---------------------------------------------------------------------------------------------------------------------------

        private PhoneSetup phoneSetup = new PhoneSetup();

        // ---------------------------------------------------------------------------------------------------------------------------

        private Player p = Script.PlayerChar;
        private Actor a = Script.PlayerActor;
        private Int lt1 = Script.Current.LocalTimer1;
        private Int lt2 = Script.Current.LocalTimer2;

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Int currentCallId = Script.global();
        private static Array<sString> arrayReplicas = Script.global_array( REPLICAS_LIMIT );
        private static Array<Int> arrayTimes = Script.global_array( REPLICAS_LIMIT );

        // ---------------------------------------------------------------------------------------------------------------------------

        private Array<Int> arrayPlayerSpeekFlags = Script.local_array( REPLICAS_LIMIT ); // 0-23@
        private Int index = Script.local(),                                              // 24@
                    lastIndex = Script.local(),                                          // 25@
                    timeToEndReplica = Script.local(),                                   // 26@
                    availableAccept = Script.local(),                                    // 27@
                    stage = Script.local(),                                              // 28@
                    maxArrayIndex = Script.local(),                                      // 29@
                    activeInterior = Script.local(),                                     // 30@
                    activeActorInterior = Script.local();                                // 31@

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_wait_ring { get => currentCallId != -1; }

        // ---------------------------------------------------------------------------------------------------------------------------

        private Phone() { }
        public Phone( HandlerPhoneSetup setup ) {
            if( instance != null )
                throw new Exception( Localization.PluginMustBeOnce( nameof( Phone ) ) );
            instance = this;
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( Phone ) ) );
            if( Script.Current.ScriptName == "MAIN" )
                throw new Exception( Localization.PluginCreatedInMainTrhead( nameof( Phone ) ) );
            if( setup == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( Phone ), nameof( HandlerPhoneSetup ) ) );

            setup.Invoke( phoneSetup );

            if( 1 > phoneSetup.Dialogs.Count )
                throw new Exception( Localization.PluginPhoneNotHaveDialog( nameof( Phone ) ) );

            currentCallId.value = -1;
            Script.set_wasted_busted_check( false );
            Script.Jump += MAIN_LOOP;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public void call( ushort id ) {
            if( !phoneSetup.Dialogs.ContainsKey( id ) )
                throw new Exception( Localization.PluginNotHaveRingID( nameof( Phone ), id ) );
            currentCallId.value = id;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void MAIN_LOOP( LabelJump label ) {
            Script.wait( Script.DefaultWaitTime );
            Script.and( MAIN_LOOP, currentCallId != -1 );
            lt1.value = 0;
            stage.value = PhoneStage.CHECK_CONDITION;
            Script.Jump += UPDATE_STAGE;
        }
        private void UPDATE_STAGE( LabelJump l ) {
            Script.wait( 0 );
            Script.Gosub += IS_PLAYER_AVAILABLE_TO_ACCEPT_CALL;
            Script.jump_table( stage, table => {

                table.Auto += CHECK_CONDITIONS; // 0
                table.Auto += LOAD_RESOURSES;   // 1
                table.Auto += UNLOAD_RESOURSES; // 2
                table.Auto += PLAY_RING;        // 3
                table.Auto += WAIT_HOLD;        // 4
                table.Auto += DO_DIALOG;        // 5
                table.Auto += CANCEL_DIALOG;    // 6

                // ---------------------------------------------------------------------------------------------------------------------------

                void CHECK_CONDITIONS( LabelCase label ) { // 0
                    Script.and( availableAccept == true, delegate {
                        Script.and(
                            Script.OnMission == false,
                            p.is_controllable(),
                            !a.is_in_air(),
                            lt1 > phoneSetup.MaxCallDelay,
                            !Script.is_minigame_in_progress(),
                            !Script.is_gang_war_fighting_going_on()
                        , delegate {
                            Script.OnMission.value = true;
                            stage.value = PhoneStage.LOAD_RESOURSES;
                        } );
                    } );
                    Script.jump( table.EndLabel );
                }

                void LOAD_RESOURSES( LabelCase label ) { // 1
                    Script.and( availableAccept == false, delegate {
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and(
                        Script.is_wav_loaded( WAV_NUMBER ),
                        Script.is_model_available( PHONE_MODEL )
                    , delegate {
                        stage.value = PhoneStage.PLAY_RING;
                        lt1.value = 0;
                    }, delegate {
                        Script.load_wav( phoneSetup.RingtoneID, WAV_NUMBER );
                        Script.load_model( PHONE_MODEL );
                    } );
                    Script.jump( table.EndLabel );
                }

                void UNLOAD_RESOURSES( LabelCase label ) { // 2

                    Script.and( Script.is_wav_loaded( WAV_NUMBER ), delegate {
                        Script.unload_wav( WAV_NUMBER );
                    } );

                    Script.and( Script.is_model_available( PHONE_MODEL ), delegate {
                        Script.destroy_model( PHONE_MODEL );
                    } );

                    p.ignored_by_everyone( false )
                     .enable_weapons_scrollable_key( true )
                     .enable_crouch_key( true )
                     .enable_fire_key( true )
                     .enable_jump_key( true )
                     .enable_enter_vehicle_key( true )
                     .enable_stats_key( true );

                    Script.and( a.is_defined(), delegate {
                        a.stop_facial_talk();
                        Script.or( a.is_in_air(), delegate { // a.is_in_water(), 
                            a.clear_tasks_immediately();
                        } );
                    } );

                    if( phoneSetup.OnUnloadData != null )
                        phoneSetup.OnUnloadData.Invoke();

                    Script.OnMission.value = false;

                    __clear_timers_and_text();
                    stage.value = PhoneStage.CHECK_CONDITION;

                    Script.and( currentCallId == -1, delegate {
                        Script.jump( MAIN_LOOP );
                    } );

                    Script.jump( table.EndLabel );
                }

                void PLAY_RING( LabelCase label ) { // 3
                    Script.or( availableAccept == false, lt1 > phoneSetup.TimeToResponse, delegate {
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and( Script.is_wav_ended( WAV_NUMBER ), delegate {
                        Script.play_wav( WAV_NUMBER );
                    } );
                    Script.and( !Script.is_text_box_displayed( "ANSWER" ), delegate {
                        Script.set_text_boxes_width( 200 );
                        Script.show_permanent_text_box( "ANSWER" ); // ~k~~PED_ANSWER_PHONE~ - o¦¢e¦œ¦© ®a Ÿ¢o®ok.
                    } );
                    Script.and( Script.is_game_key_pressed( Keys.VEHICLE_ENTER_EXIT ), delegate {
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and(
                        !a.is_in_air(),
                        Script.is_game_key_pressed( Keys.PED_ANSWER_PHONE_FIREWEAPON_ALT )
                    , delegate {
                        p.ignored_by_everyone( true )
                         .enable_weapons_scrollable_key( false )
                         .enable_crouch_key( false )
                         .enable_fire_key( false )
                         .enable_jump_key( false )
                         .enable_enter_vehicle_key( false )
                         .enable_stats_key( false );
                        a.set_armed_weapon( WeaponNumber.UNARMED ).set_muted( true ).task.hold_cellphone( true );
                        __clear_timers_and_text();
                        stage.value = PhoneStage.WAIT_HOLD;
                    } );
                    Script.jump( table.EndLabel );
                }

                void WAIT_HOLD( LabelCase label ) { // 4
                    Script.and( availableAccept == false, delegate {
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and( a.is_in_air(), delegate {
                        a.clear_tasks_immediately();
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and( lt2 > 2000, delegate {
                        Script.Gosub += LOAD_DATA;
                        index.value = 0;
                        lastIndex.value = -1;
                        Script.unload_wav( WAV_NUMBER );
                        Script.remove_text_box();
                        stage.value = PhoneStage.DO_DIALOG;
                    } );
                    Script.jump( table.EndLabel );
                }

                void DO_DIALOG( LabelCase label ) { // 5
                    Script.and( availableAccept == false, delegate {
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and( a.is_in_air(), delegate {
                        a.clear_tasks_immediately();
                        stage.value = PhoneStage.UNLOAD_RESOURSE;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and( Script.is_game_key_pressed( Keys.VEHICLE_ENTER_EXIT ), delegate {
                        index.add( maxArrayIndex, 1 );
                    } );
                    Script.and( index > maxArrayIndex, delegate {
                        a.task.hold_cellphone( false );
                        stage.value = PhoneStage.CANCEL;
                        Script.jump( table.EndLabel );
                    } );
                    Script.and( lastIndex != index, delegate {
                        lastIndex.value = index;
                        Script.and( arrayPlayerSpeekFlags[ index ] == true, delegate {
                            a.start_facial_talk( arrayTimes[ index ] );
                        }, delegate { a.stop_facial_talk(); } );
                        __clear_timers_and_text( false );
                        if( phoneSetup.OnReplicaChanged != null )
                            phoneSetup.OnReplicaChanged.Invoke();
                    } );
                    Script.and( !Script.is_text_box_displayed( "CELSKIP" ), delegate {
                        Script.set_text_boxes_width( 200 );
                        Script.show_permanent_text_box( "CELSKIP" ); // ~k~~VEHICLE_ENTER_EXIT~ - £po£yc¦œ¦© paŸ™o¢op œ £o¢ecœ¦© ¦py—ky.
                    } );
                    Script.and( !Script.is_text_priority_displayed(), delegate {
                        timeToEndReplica.value = arrayTimes[ index ];
                        timeToEndReplica -= lt2;
                        Script.show_text_highpriority( arrayReplicas[ index ], timeToEndReplica, true );
                    } );
                    Script.and( lt1 > arrayTimes[ index ], delegate { index += 1; } );
                    Script.jump( table.EndLabel );
                }

                void CANCEL_DIALOG( LabelCase label ) { // 6
                    Script.Gosub += AFTER_CALL;
                    stage.value = PhoneStage.UNLOAD_RESOURSE;
                    currentCallId.value = -1;
                    Script.jump( table.EndLabel );
                }

            } );
            Script.Jump += UPDATE_STAGE;
        }
        private void IS_PLAYER_AVAILABLE_TO_ACCEPT_CALL( LabelGosub label ) {
            availableAccept.value = false;
            Script.and( p.is_defined(), !Script.is_fading(), delegate {
                Script.get_active_interior( activeInterior );
                a.get_active_interior( activeActorInterior );
                Script.and(
                    !p.is_on_jetpack(),
                    !a.is_in_water(),
                    activeInterior == 0,
                    activeActorInterior == 0,
                    a.is_on_foot()
                , delegate {
                    availableAccept.value = true;
                } );
            } );
        }
        private void LOAD_DATA( LabelGosub label ) {
            foreach( var dialog in phoneSetup.Dialogs ) {
                Script.and( currentCallId == dialog.Key, delegate {
                    if( phoneSetup.OnLoadData != null ) {
                        DialogData.instance.DialogID = dialog.Key;
                        DialogData.instance.TotalReplicas = dialog.Value.Replicas.Count;
                        phoneSetup.OnLoadData.Invoke( DialogData.instance );
                    }
                    for( ushort i = 0; i < dialog.Value.Replicas.Count; i++ ) {
                        var elem = dialog.Value.Replicas.ElementAt( i );
                        arrayReplicas[ i ].value = elem.gxt;
                        arrayTimes[ i ].value = elem.time;
                        arrayPlayerSpeekFlags[ i ].value = elem.isPlayer;
                    }
                    maxArrayIndex.value = ( dialog.Value.Replicas.Count - 1 );
                } );
            }
        }
        private void AFTER_CALL( LabelGosub label ) {
            foreach( var dialog in phoneSetup.Dialogs ) {
                if( dialog.Value.OnComplete != null ) {
                    Script.and( currentCallId == dialog.Key, delegate {
                        dialog.Value.OnComplete.Invoke();
                    } );
                }
            }
        }
        private void __clear_timers_and_text( bool removeTextbox = true ) {
            if( removeTextbox )
                Script.remove_text_box();
            Script.text_clear_all();
            lt1.value = 0;
            lt2.value = 0;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}