using GTA.Core;

namespace GTA.Plugins.Common {

    internal partial class OriginalMinigame : Original {

        internal OriginalMinigame() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            _425.value = 1505.7;
            _426.value = -1631.9;
            _427.value = 14.0;
            _431.value = 1512.7;
            _432.value = -1631.9;
            _433.value = 14.0;
            X_Pershing_Square_LS = 1498.7;
            Y_Pershing_Square_LS = -1631.9;
            Z_Pershing_Square_LS = 14.0;
            Interior_Decision_Maker_A.copy_from( 65543 );
            Interior_Decision_Maker_B.copy_from( 65543 );
            Script.init_external_script_trigger_with_object_model<OTB_MSC>( 2754, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 2872, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 2779, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 2778, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 2681, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 2028, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 1718, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<ARCADE>( 1719, 100, 4.0, -1 );
            Script.init_external_script_trigger_with_object_model<POOL>( 2964, 100, 70.0, -1 );
        }
        internal override void Update() {
            Script.and(
                Script.OnMission == 0,
                Mission_Cesar_Vialpando_Passed == 1
            , delegate {
                Script.and( LOWR_CONT_Script_Launched == 0, delegate {
                    Script.get_external_script_status<LOWRCON>( Original.ScriptStatus );
                    Script.and( Original.ScriptStatus == 0, delegate {
                        Script.and( Script.PlayerChar.is_defined(), delegate {
                            Script.and( Script.PlayerActor.is_near_point_2d( 0, 1812.369, -1929.922, 80.0, 80.0 ), delegate {
                                Script.load_external_script<LOWRCON>();
                                Script.and( Script.is_external_script_loaded<LOWRCON>(), delegate {
                                    Script.start_new_external_script<LOWRCON>();
                                    LOWR_CONT_Script_Launched.value = 1;
                                } );
                            } );
                        } );
                    } );
                }, delegate {
                    Script.and( Script.PlayerChar.is_defined(), delegate {
                        Script.and( !Script.PlayerActor.is_near_point_2d( 0, 1812.369, -1929.922, 500.0, 500.0 ), delegate {
                            LOWR_CONT_Script_Launched.value = 0;
                        } );
                    } );
                } );
            } );
            Script.jump_table( Video_Game, table => {
                table.Auto += VideoGameTheyCrawledFromUranus;   // 0
                table.Auto += VideoGameDualuty;                 // 1
                table.Auto += VideoGameGoGoSpaceMonkey;         // 2
                table.Auto += VideoGameLetsGetReadyToBumble;    // 3
                table.Auto += VideoGameInsideTrackBetting;      // 4
                table.Auto += VideoGamePool;                    // 5
                table.Auto += VideoGameLowrider;                // 6
                table.Auto += VideoGameBeefyBaron;              // 7

                void VideoGameTheyCrawledFromUranus( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<NONE>();
                    Script.jump( table.EndLabel );
                }
                void VideoGameDualuty( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<DUAL>();
                    Script.jump( table.EndLabel );
                }
                void VideoGameGoGoSpaceMonkey( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<SHTR>();
                    Script.jump( table.EndLabel );
                }
                void VideoGameLetsGetReadyToBumble( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<GRAV>();
                    Script.jump( table.EndLabel );
                }
                void VideoGameInsideTrackBetting( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<OTB>();
                    Script.jump( table.EndLabel );
                }
                void VideoGamePool( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<POOL2>();
                    Script.jump( table.EndLabel );
                }
                void VideoGameLowrider( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.start_mission<LOWR>();
                    Script.jump( table.EndLabel );
                }
                void VideoGameBeefyBaron( LabelCase label ) {
                    Script.OnMission.value = 1;
                    Script.show_text_styled( "BEEFY", 1000, 2 ); // –¬c®oќ RC-Baron
                    print_gosub_LITCAS_268();
                    Script.start_mission<ZERO5>();
                    Script.jump( table.EndLabel );
                }
            } );
            Video_Game.value = -1;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private class CLEANAU : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"32@ = 0 
" + _1035 + @" = 1 

:CLEANAU_25
if 
   not " + Audio_Line_Is_Active + @" == 0 
else_jump @CLEANAU_80 
wait 0 
if 
  32@ > 2000 
else_jump @CLEANAU_73 
" + Audio_Line_Is_Active + @" = 0 

:CLEANAU_73
jump @CLEANAU_25 

:CLEANAU_80" );
                end_thread_named<AUDIOL>();
                AppendLine( @"" + _1035 + @" = 0 
end_thread" );
            }

        }

    }

}