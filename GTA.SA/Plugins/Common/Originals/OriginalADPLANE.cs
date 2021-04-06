using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalADPLANE : Original {

        internal OriginalADPLANE() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.create_thread<ADPLANE>();
        }

        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class ADPLANE : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":ADPLANE_11
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @ADPLANE_964 
if 
  " + OnMission + @" == 0 
else_jump @ADPLANE_964 
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @ADPLANE_324 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @ADPLANE_287" );
get_external_script_status<PLANES>( ScriptStatus );
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @ADPLANE_280 
if 
  " + _792 + @" == 0 
else_jump @ADPLANE_157 
0A40: " + _795 + @" = create_entrance_marker_at 1685.7 -2238.9 14.0 color 14 
" + _792 + @" = 1 

:ADPLANE_157
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @ADPLANE_280 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 1685.7 -2238.9 12.5 radius 1.2 1.2 1.2 on_foot 
else_jump @ADPLANE_246 
Player.CanMove(" + PlayerChar + @") = False" );
print_gosub_LITCAS_268(); 
load_external_script<PLANES>();
AppendLine( @"" + _1802 + @" = 1 

:ADPLANE_246
if and" );
is_external_script_loaded<PLANES>().write(); 
AppendLine( @"  " + _1802 + @" == 1 
else_jump @ADPLANE_280" );
start_new_external_script<PLANES>();  
AppendLine( @"" + _1802 + @" = 0 

:ADPLANE_280
jump @ADPLANE_317 

:ADPLANE_287
if 
  " + _792 + @" == 1 
else_jump @ADPLANE_317 
0A41: destroy_entrance_marker " + _795 + @" 
" + _792 + @" = 0 

:ADPLANE_317
jump @ADPLANE_354 

:ADPLANE_324
if 
  " + _792 + @" == 1 
else_jump @ADPLANE_354 
0A41: destroy_entrance_marker " + _795 + @" 
" + _792 + @" = 0 

:ADPLANE_354
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @ADPLANE_629 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @ADPLANE_592" );
get_external_script_status<PLANES>( ScriptStatus );
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @ADPLANE_585 
if 
  " + _793 + @" == 0 
else_jump @ADPLANE_462 
0A40: " + _796 + @" = create_entrance_marker_at -1421.5 -287.2 14.6 color 14 
" + _793 + @" = 1 

:ADPLANE_462
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @ADPLANE_585 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere -1421.5 -287.2 14.6 radius 1.2 1.2 1.2 on_foot 
else_jump @ADPLANE_551 
Player.CanMove(" + PlayerChar + @") = False" );
print_gosub_LITCAS_268(); 
load_external_script<PLANES>();
AppendLine( @"" + _1802 + @" = 1 

:ADPLANE_551
if and" );
is_external_script_loaded<PLANES>().write(); 
AppendLine( @"  " + _1802 + @" == 1 
else_jump @ADPLANE_585" );
start_new_external_script<PLANES>();  
AppendLine( @"" + _1802 + @" = 0 

:ADPLANE_585
jump @ADPLANE_622 

:ADPLANE_592
if 
  " + _793 + @" == 1 
else_jump @ADPLANE_622 
0A41: destroy_entrance_marker " + _796 + @" 
" + _793 + @" = 0 

:ADPLANE_622
jump @ADPLANE_659 

:ADPLANE_629
if 
  " + _793 + @" == 1 
else_jump @ADPLANE_659 
0A41: destroy_entrance_marker " + _796 + @" 
" + _793 + @" = 0 

:ADPLANE_659
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @ADPLANE_934 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @ADPLANE_897" );
get_external_script_status<PLANES>( ScriptStatus ); 
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @ADPLANE_890 
if 
  " + _794 + @" == 0 
else_jump @ADPLANE_767 
0A40: " + _797 + @" = create_entrance_marker_at 1663.0 1423.6 11.2 color 14 
" + _794 + @" = 1 

:ADPLANE_767
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @ADPLANE_890 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 1663.0 1423.6 11.2 radius 1.2 1.2 1.2 on_foot 
else_jump @ADPLANE_856 
Player.CanMove(" + PlayerChar + @") = False" );
print_gosub_LITCAS_268();
load_external_script<PLANES>();
AppendLine( @"" + _1802 + @" = 1 

:ADPLANE_856
if and" );
is_external_script_loaded<PLANES>().write(); 
AppendLine( @"  " + _1802 + @" == 1 
else_jump @ADPLANE_890" );
start_new_external_script<PLANES>();  
AppendLine( @"" + _1802 + @" = 0 

:ADPLANE_890
jump @ADPLANE_927 

:ADPLANE_897
if 
  " + _794 + @" == 1 
else_jump @ADPLANE_927 
0A41: destroy_entrance_marker " + _797 + @" 
" + _794 + @" = 0 

:ADPLANE_927
jump @ADPLANE_964 

:ADPLANE_934
if 
  " + _794 + @" == 1 
else_jump @ADPLANE_964 
0A41: destroy_entrance_marker " + _797 + @" 
" + _794 + @" = 0 

:ADPLANE_964
jump @ADPLANE_11" );
            }

        }

        private sealed class PLANES : External {

            Int tmp_PLANES_DayNames = global( PLANES_DayNames.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"05A9: s" + tmp_PLANES_DayNames + @"[1] = 'PLA_9' 
05A9: s" + tmp_PLANES_DayNames + @"[2] = 'PLA_3' 
05A9: s" + tmp_PLANES_DayNames + @"[3] = 'PLA_4' 
05A9: s" + tmp_PLANES_DayNames + @"[4] = 'PLA_5' 
05A9: s" + tmp_PLANES_DayNames + @"[5] = 'PLA_6' 
05A9: s" + tmp_PLANES_DayNames + @"[6] = 'PLA_7' 
05A9: s" + tmp_PLANES_DayNames + @"[7] = 'PLA_8' 
" + PLANES_Weekday + @" = 0 
" + PLANES_Conversation_YES + @" = 0 
" + _9499 + @" = 0 
" + _9500 + @" = 500 
" + _9501 + @" = 0 
" + _9502 + @" = 0 
" + _9503 + @" = 0 
" + _9504 + @" = 0 
" + _9505 + @" = 0 
" + _9506 + @" = 0 
" + PLAINS_Plane_Flyway + @" = 0 
" + _9508 + @" = 0 
" + _9509 + @" = 0 
" + _9510 + @" = 0 
" + _9511 + @" = 0 
" + _9521 + @" = 0.0 
" + _9513 + @" = 0.0 
" + _9514 + @" = 0.0 
" + _9515 + @" = 0.0 
" + _9516 + @" = 0.0 
" + _9517 + @" = 0.0 
" + _9518 + @" = 0.0 
" + _9519 + @" = 0.0 
" + _9520 + @" = 0.0 
" + _9512 + @" = 0 
" + _9522 + @" = 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_342 
jump @PLANES_3712 

:PLANES_342
Player.CanMove(" + PlayerChar + @") = False
set_wb_check_to 0 
0253: save_current_time 
07D0: " + PLANES_Weekday + @" = weekday 
if 
  " + PLANES_Weekday + @" == 7 
else_jump @PLANES_392 
" + PLANES_Weekday + @" = 1 
jump @PLANES_399 

:PLANES_392
" + PLANES_Weekday + @" += 1 

:PLANES_399
0652: " + PLANES_STAT_Unlocked_Cities_Number + @" = integer_stat 181 
gosub @PLANES_3818 
02A3: enable_widescreen 0 
0169: set_fade_color_RGB 0 0 0 
00BE: text_clear_all 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_455 
jump @PLANES_3712 

:PLANES_455
fade 0 500 

:PLANES_462
if 
fading 
else_jump @PLANES_509 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_502 
jump @PLANES_3712 

:PLANES_502
jump @PLANES_462 

:PLANES_509
0390: load_txd_dictionary 'LD_PLAN' 
038F: load_texture ""AIRLOGO"" as 1 
038F: load_texture ""TVCORN"" as 2 
038F: load_texture ""TVBASE"" as 3 
038F: load_texture ""BLKDOT"" as 4 
038B: load_requested_models 
03E6: remove_text_box 
00BE: text_clear_all 
03F0: enable_text_draw 1 
0826: enable_hud 0 
0581: enable_radar 0 
08F8: display_stat_update_box 0 
fade 1 500 
gosub @PLANES_4363 

:PLANES_605
if 
fading 
else_jump @PLANES_659 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_645 
jump @PLANES_3712 

:PLANES_645
gosub @PLANES_4363 
jump @PLANES_605 

:PLANES_659
gosub @PLANES_4363 

:PLANES_666
wait 0 
gosub @PLANES_4363 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_700 
jump @PLANES_3712 

:PLANES_700
0254: restore_current_time 
if 
  " + PLANES_STAT_Unlocked_Cities_Number + @" > 1 
else_jump @PLANES_805 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @PLANES_767 
" + PLANES_Conversation_YES + @" = 0 

:PLANES_767
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @PLANES_798 
" + PLANES_Conversation_YES + @" = 1 

:PLANES_798
jump @PLANES_812 

:PLANES_805
" + PLANES_Conversation_YES + @" = 0 

:PLANES_812
if 
  " + PLANES_STAT_Unlocked_Cities_Number + @" > 0 
else_jump @PLANES_1281 
if 
  " + _9503 + @" == 0 
else_jump @PLANES_879 
if 
00E1:   player 0 pressed_key 16 
else_jump @PLANES_879 
" + _9502 + @" = 0 
" + _9503 + @" = 1 

:PLANES_879
if 
  " + _9503 + @" == 1 
else_jump @PLANES_921 
if 
80E1:   not player 0 pressed_key 16 
else_jump @PLANES_921 
" + _9503 + @" = 2 

:PLANES_921
if 
  " + _9503 + @" == 2 
else_jump @PLANES_1134 
" + _9501 + @" = Player.Money(" + PlayerChar + @")
if 
002C:   " + _9501 + @" >= " + _9500 + @" 
else_jump @PLANES_1069 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1083 
gosub @PLANES_4363 
fade 0 500 

:PLANES_994
if 
fading 
else_jump @PLANES_1055 
gosub @PLANES_4363 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_1041 
jump @PLANES_3712 

:PLANES_1041
gosub @PLANES_4363 
jump @PLANES_994 

:PLANES_1055
jump @PLANES_1437 
jump @PLANES_1134 

:PLANES_1069
if 
  " + _9502 + @" == 0 
else_jump @PLANES_1134 
01BD: " + _9504 + @" = current_time_in_ms 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1085 
" + _9502 + @" = 1 
" + _9503 + @" = 0 

:PLANES_1134
01BD: " + _9505 + @" = current_time_in_ms 
0084: " + _9506 + @" = " + _9505 + @" 
0060: " + _9506 + @" -= " + _9504 + @" 
if 
  5000 > " + _9506 + @" 
else_jump @PLANES_1281 
gosub @PLANES_7954 
033F: set_text_draw_letter_size 0.41 1.84 
0340: set_text_draw_RGBA 255 255 255 255 
if or
04A3:   " + Current_Language + @" == 3 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_1260 
033E: set_draw_text_position 40.0 337.0 GXT 'SHOPNO'  
jump @PLANES_1281 

:PLANES_1260
033E: set_draw_text_position 93.0 337.0 GXT 'SHOPNO'  

:PLANES_1281
if 
00E1:   player 0 pressed_key 15 
else_jump @PLANES_1430 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1085 
gosub @PLANES_4363 
fade 0 500 

:PLANES_1326
if 
fading 
else_jump @PLANES_1387 
gosub @PLANES_4363 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_1373 
jump @PLANES_3712 

:PLANES_1373
gosub @PLANES_4363 
jump @PLANES_1326 

:PLANES_1387
gosub @PLANES_3818 
Actor.PutAt(" + PlayerActor + @", " + _9513 + @", " + _9514 + @", " + _9515 + @")
Actor.Angle(" + PlayerActor + @") = " + _9516 + @"
fade 1 500 
jump @PLANES_3712 

:PLANES_1430
jump @PLANES_666 

:PLANES_1437
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_1460 
jump @PLANES_3712 

:PLANES_1460
088E: set_next_day 
Player.Money(" + PlayerChar + @") += -500
0391: release_textures 
Model.Load(#AT400)
Model.Load(#GUN_PARA)
038B: load_requested_models 
0A48: enable_menu_access_in_widescreen_mode 1 
gosub @PLANES_3818 
04E4: refresh_game_renderer_at " + _9517 + @" " + _9518 + @" 
0395: clear_area 1 at " + _9517 + @" " + _9518 + @" " + _9519 + @" radius 100.0 
" + _9479 + @" = Car.Create(#AT400, " + _9517 + @", " + _9518 + @", " + _9519 + @")
Car.Angle(" + _9479 + @") = " + _9520 + @"
036A: put_actor " + PlayerActor + @" in_car " + _9479 + @" 
Camera.SetAtPos(" + _9517 + @", " + _9518 + @", " + _9519 + @")
02A3: enable_widescreen 1 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @PLANES_1709 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_1650 
00C0: set_current_time_hours_to 10 minutes_to 30 
" + _9521 + @" = 9500.0 
" + _9510 + @" = 20000 
" + _9511 + @" = 150000 
" + PLAINS_Plane_Flyway + @" = 42 

:PLANES_1650
if 
  " + PLANES_Conversation_YES + @" == 1 
else_jump @PLANES_1709 
00C0: set_current_time_hours_to 17 minutes_to 50 
" + _9521 + @" = 5000.0 
" + _9510 + @" = 30000 
" + _9511 + @" = 110000 
" + PLAINS_Plane_Flyway + @" = 46 

:PLANES_1709
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @PLANES_1845 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_1786 
00C0: set_current_time_hours_to 11 minutes_to 20 
" + _9521 + @" = 6000.0 
" + _9510 + @" = 20000 
" + _9511 + @" = 120000 
" + PLAINS_Plane_Flyway + @" = 49 

:PLANES_1786
if 
  " + PLANES_Conversation_YES + @" == 1 
else_jump @PLANES_1845 
00C0: set_current_time_hours_to 14 minutes_to 40 
" + _9521 + @" = 8000.0 
" + _9510 + @" = 20000 
" + _9511 + @" = 160000 
" + PLAINS_Plane_Flyway + @" = 44 

:PLANES_1845
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @PLANES_1981 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_1922 
00C0: set_current_time_hours_to 19 minutes_to 10 
" + _9521 + @" = 6600.0 
" + _9510 + @" = 20000 
" + _9511 + @" = 120000 
" + PLAINS_Plane_Flyway + @" = 48 

:PLANES_1922
if 
  " + PLANES_Conversation_YES + @" == 1 
else_jump @PLANES_1981 
00C0: set_current_time_hours_to 14 minutes_to 30 
" + _9521 + @" = 3800.0 
" + _9510 + @" = 20000 
" + _9511 + @" = 70000 
" + PLAINS_Plane_Flyway + @" = 43 

:PLANES_1981
07C0: load_path " + PLAINS_Plane_Flyway + @" 

:PLANES_1986
if 
87C1:   not path " + PLAINS_Plane_Flyway + @" available 
else_jump @PLANES_2036 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_2029 
jump @PLANES_3712 

:PLANES_2029
jump @PLANES_1986 

:PLANES_2036
01BD: " + _9504 + @" = current_time_in_ms 
" + _9503 + @" = 0 
fade 1 500 

:PLANES_2055
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_2082 
jump @PLANES_3712 

:PLANES_2082
if 
   Player.Defined(" + PlayerChar + @")
else_jump @PLANES_2103 
Player.ClearWantedLevel(" + PlayerChar + @")

:PLANES_2103
01BD: " + _9505 + @" = current_time_in_ms 
0084: " + _9506 + @" = " + _9505 + @" 
0060: " + _9506 + @" -= " + _9504 + @" 
if 
   not Car.Wrecked(" + _9479 + @")
else_jump @PLANES_3705 
if 
  " + _9503 + @" == 0 
else_jump @PLANES_2196 
if 
  " + _9506 + @" > 2000 
else_jump @PLANES_2196 
05EB: assign_car " + _9479 + @" to_path " + PLAINS_Plane_Flyway + @" 
093D: lock_camera_on_cinematic_view 1 
" + _9503 + @" = 1 

:PLANES_2196
if 
  " + _9503 + @" > 0 
else_jump @PLANES_2343 
if 
  " + _9508 + @" == 0 
else_jump @PLANES_2343 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if 
  " + tempvar_Z_coord + @" > 150.0 
else_jump @PLANES_2343 
03D5: remove_text 'PLA_11'  
if 
  " + _9512 + @" == 0 
else_jump @PLANES_2319 
00BC: show_text_highpriority GXT 'PLA_12' time 20000 flag 1  
" + _9512 + @" = 1 

:PLANES_2319
if 
00E1:   player 0 pressed_key 15 
else_jump @PLANES_2343 
" + _9503 + @" = 2 

:PLANES_2343
if 
  " + _9503 + @" > 0 
else_jump @PLANES_2467 
if 
  " + _9522 + @" == 0 
else_jump @PLANES_2421 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if 
  " + tempvar_Z_coord + @" > 150.0 
else_jump @PLANES_2421 
" + _9522 + @" = 1 

:PLANES_2421
if 
  " + _9522 + @" == 1 
else_jump @PLANES_2467 
if 
  150.0 > " + tempvar_Z_coord + @" 
else_jump @PLANES_2467 
" + _9522 + @" = 2 

:PLANES_2467
if 
  " + _9503 + @" == 1 
else_jump @PLANES_3342 
if 
  " + _9508 + @" == 0 
else_jump @PLANES_3112 
if 
  150.0 >= " + tempvar_Z_coord + @" 
else_jump @PLANES_2569 
03D5: remove_text 'PLA_12'  
if 
  " + _9512 + @" == 0 
else_jump @PLANES_2569 
00BC: show_text_highpriority GXT 'PLA_11' time 5000 flag 1  

:PLANES_2569
if 
  2 > " + _9522 + @" 
else_jump @PLANES_3112 
if 
00E1:   player 0 pressed_key 16 
else_jump @PLANES_3112 
fade 0 500 

:PLANES_2611
if 
fading 
else_jump @PLANES_2658 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_2651 
jump @PLANES_3712 

:PLANES_2651
jump @PLANES_2611 

:PLANES_2658
if 
   not Car.Wrecked(" + _9479 + @")
else_jump @PLANES_3056 
if 
060E:   car " + _9479 + @" assigned_to_path 
else_jump @PLANES_3056 
if 
  " + _9509 + @" == 1 
else_jump @PLANES_2715 
08E6: set_plane " + _9479 + @" landing_gear 0 

:PLANES_2715
0706: advance_car " + _9479 + @" further_along_path -1E07 
0706: advance_car " + _9479 + @" further_along_path " + _9521 + @" 
093D: lock_camera_on_cinematic_view 0 
if or
  " + PLAINS_Plane_Flyway + @" == 48 
  " + PLAINS_Plane_Flyway + @" == 49 
else_jump @PLANES_2841 
Camera.SetPosition(1774.9, -2529.3, 30.9, 0.0, 0.0, 0.0)
if 
   not Car.Wrecked(" + _9479 + @")
else_jump @PLANES_2819 
Camera.OnVehicle(" + _9479 + @", 15, 2)

:PLANES_2819
0A0B: set_rendering_origin_at_3D_coord 1774.9 -2529.3 13.9 angle 48.0 

:PLANES_2841
if or
  " + PLAINS_Plane_Flyway + @" == 42 
  " + PLAINS_Plane_Flyway + @" == 43 
else_jump @PLANES_2945 
Camera.SetPosition(-1268.5, 106.9, 37.1, 0.0, 0.0, 0.0)
if 
   not Car.Wrecked(" + _9479 + @")
else_jump @PLANES_2923 
Camera.OnVehicle(" + _9479 + @", 15, 2)

:PLANES_2923
0A0B: set_rendering_origin_at_3D_coord -1268.5 106.9 13.0 angle 350.0 

:PLANES_2945
if or
  " + PLAINS_Plane_Flyway + @" == 46 
  " + PLAINS_Plane_Flyway + @" == 44 
else_jump @PLANES_3049 
Camera.SetPosition(1396.1, 1382.3, 25.4, 0.0, 0.0, 0.0)
if 
   not Car.Wrecked(" + _9479 + @")
else_jump @PLANES_3027 
Camera.OnVehicle(" + _9479 + @", 15, 2)

:PLANES_3027
0A0B: set_rendering_origin_at_3D_coord 1396.1 1382.3 10.0 angle 264.0 

:PLANES_3049
" + _9508 + @" = 1 

:PLANES_3056
00BE: text_clear_all 
fade 1 2500 

:PLANES_3065
if 
fading 
else_jump @PLANES_3112 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3105 
jump @PLANES_3712 

:PLANES_3105
jump @PLANES_3065 

:PLANES_3112
if 
   not Car.Wrecked(" + _9479 + @")
else_jump @PLANES_3342 
if 
860E:   not car " + _9479 + @" assigned_to_path 
else_jump @PLANES_3342 
fade 0 2000 

:PLANES_3151
if 
fading 
else_jump @PLANES_3198 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3191 
jump @PLANES_3712 

:PLANES_3191
jump @PLANES_3151 

:PLANES_3198
gosub @PLANES_3818 
093D: lock_camera_on_cinematic_view 0 
04E4: refresh_game_renderer_at " + _9513 + @" " + _9514 + @" 
0395: clear_area 1 at " + _9513 + @" " + _9514 + @" " + _9515 + @" radius 100.0 
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.PutAt(" + PlayerActor + @", " + _9513 + @", " + _9514 + @", " + _9515 + @")
Actor.Angle(" + PlayerActor + @") = " + _9516 + @"
Camera.SetAtPos(" + _9513 + @", " + _9514 + @", " + _9515 + @")
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
fade 1 500 

:PLANES_3288
if 
fading 
else_jump @PLANES_3335 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3328 
jump @PLANES_3712 

:PLANES_3328
jump @PLANES_3288 

:PLANES_3335
jump @PLANES_3712 

:PLANES_3342
if 
  " + _9503 + @" == 2 
else_jump @PLANES_3585 
fade 0 500 

:PLANES_3367
if 
fading 
else_jump @PLANES_3414 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3407 
jump @PLANES_3712 

:PLANES_3407
jump @PLANES_3367 

:PLANES_3414
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", Parachute, 1)
01B9: set_actor " + PlayerActor + @" armed_weapon_to 46 
093D: lock_camera_on_cinematic_view 0 
0633: AS_actor " + PlayerActor + @" exit_car 
03D5: remove_text 'PLA_11'  
03D5: remove_text 'PLA_12'  

:PLANES_3461
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @PLANES_3511 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3504 
jump @PLANES_3712 

:PLANES_3504
jump @PLANES_3461 

:PLANES_3511
Car.Destroy(" + _9479 + @")
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
fade 1 500 

:PLANES_3531
if 
fading 
else_jump @PLANES_3578 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3571 
jump @PLANES_3712 

:PLANES_3571
jump @PLANES_3531 

:PLANES_3578
jump @PLANES_3712 

:PLANES_3585
if 
  " + _9508 + @" == 0 
else_jump @PLANES_3705 
if 
  " + _9509 + @" == 0 
else_jump @PLANES_3654 
if 
001C:   " + _9506 + @" > " + _9510 + @" 
else_jump @PLANES_3654 
08E6: set_plane " + _9479 + @" landing_gear 1 
" + _9509 + @" = 1 

:PLANES_3654
if 
  " + _9509 + @" == 1 
else_jump @PLANES_3705 
if 
001C:   " + _9506 + @" > " + _9511 + @" 
else_jump @PLANES_3705 
08E6: set_plane " + _9479 + @" landing_gear 0 
" + _9509 + @" = 2 

:PLANES_3705
jump @PLANES_2055 

:PLANES_3712
03D5: remove_text 'PLA_11'  
03D5: remove_text 'PLA_12'  
if 
0844:   string " + Current_Shop_GXT_Name + @" empty 
else_jump @PLANES_3752 
Camera.Restore_WithJumpCut

:PLANES_3752
if 
   Player.Defined(" + PlayerChar + @")
else_jump @PLANES_3775 
Player.CanMove(" + PlayerChar + @") = True

:PLANES_3775
093D: lock_camera_on_cinematic_view 0 
0A48: enable_menu_access_in_widescreen_mode 0 
03F0: enable_text_draw 0 
Car.RemoveReferences(" + _9479 + @")
Model.Destroy(#AT400)
Model.Destroy(#GUN_PARA)
0391: release_textures 
0826: enable_hud 1 
0581: enable_radar 1 
08F8: display_stat_update_box 1 
end_thread 

:PLANES_3818
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @PLANES_3999 
" + _9513 + @" = 1682.7 
" + _9514 + @" = -2244.9 
" + _9515 + @" = 12.5 
" + _9516 + @" = 178.9 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_3934 
" + _9517 + @" = 2052.0 
" + _9518 + @" = -2497.5 
" + _9519 + @" = 12.4 
" + _9520 + @" = 89.9 

:PLANES_3934
if 
  " + PLANES_Conversation_YES + @" == 1 
else_jump @PLANES_3992 
" + _9517 + @" = 1580.0 
" + _9518 + @" = -2493.5 
" + _9519 + @" = 12.4 
" + _9520 + @" = 270.0 

:PLANES_3992
" + _9499 + @" = 18 

:PLANES_3999
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @PLANES_4180 
" + _9513 + @" = -1431.6 
" + _9514 + @" = -283.9 
" + _9515 + @" = 13.1 
" + _9516 + @" = 149.9 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_4115 
" + _9517 + @" = -1626.0 
" + _9518 + @" = -137.3 
" + _9519 + @" = 13.0 
" + _9520 + @" = 315.6 

:PLANES_4115
if 
  " + PLANES_Conversation_YES + @" == 1 
else_jump @PLANES_4173 
" + _9517 + @" = -1590.9 
" + _9518 + @" = -103.5 
" + _9519 + @" = 13.0 
" + _9520 + @" = 315.3 

:PLANES_4173
" + _9499 + @" = 19 

:PLANES_4180
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @PLANES_4361 
" + _9513 + @" = 1669.8 
" + _9514 + @" = 1422.1 
" + _9515 + @" = 9.7 
" + _9516 + @" = 263.9 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_4296 
" + _9517 + @" = 1479.7 
" + _9518 + @" = 1716.1 
" + _9519 + @" = 9.7 
" + _9520 + @" = 180.0 

:PLANES_4296
if 
  " + PLANES_Conversation_YES + @" == 1 
else_jump @PLANES_4354 
" + _9517 + @" = 1475.7 
" + _9518 + @" = 1636.0 
" + _9519 + @" = 9.7 
" + _9520 + @" = 180.0 

:PLANES_4354
" + _9499 + @" = 20 

:PLANES_4361
return 

:PLANES_4363
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 320.0 225.0 size 612.0 438.0 RGBA 0 0 0 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 320.0 430.0 size 640.0 250.0 RGBA 0 0 0 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 1 position 321.0 246.0 size 356.0 246.0 RGBA 160 160 160 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 326.0 84.0 size 602.0 58.0 RGBA 73 73 73 255 
gosub @PLANES_7879 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_4574 
033E: set_draw_text_position 269.0 65.0 GXT 'PLA_1'  

:PLANES_4574
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_4625 
033F: set_text_draw_letter_size 0.9 3.4 
033E: set_draw_text_position 327.0 65.0 GXT 'PLA_1'  

:PLANES_4625
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_4664 
033E: set_draw_text_position 269.0 65.0 GXT 'PLA_1'  

:PLANES_4664
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_4715 
033F: set_text_draw_letter_size 0.91 3.43 
033E: set_draw_text_position 322.0 65.0 GXT 'PLA_1'  

:PLANES_4715
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_4766 
033F: set_text_draw_letter_size 0.9 3.4 
033E: set_draw_text_position 322.0 65.0 GXT 'PLA_1'  

:PLANES_4766
if 
  " + PLANES_STAT_Unlocked_Cities_Number + @" == 0 
else_jump @PLANES_4987 
gosub @PLANES_7879 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_4863 
033F: set_text_draw_letter_size 1.21 6.23 
033E: set_draw_text_position 320.0 204.0 GXT 'PLA_25'  
jump @PLANES_4896 

:PLANES_4863
033F: set_text_draw_letter_size 1.41 6.23 
033E: set_draw_text_position 316.0 204.0 GXT 'PLA_25'  

:PLANES_4896
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 210.0 368.0 GXT 'PLA_23'  
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 298.0 368.0 GXT 'PLA_21'  
jump @PLANES_7637 

:PLANES_4987
gosub @PLANES_7954 
0340: set_text_draw_RGBA 138 138 138 255 
033E: set_draw_text_position 92.0 144.0 GXT 'PLA_2'  
gosub @PLANES_7954 
0340: set_text_draw_RGBA 138 138 138 255 
033E: set_draw_text_position 92.0 207.0 GXT 'PLA_13'  
gosub @PLANES_7954 
0340: set_text_draw_RGBA 138 138 138 255 
033E: set_draw_text_position 92.0 267.0 GXT 'PLA_17'  
if 
  " + PLANES_STAT_Unlocked_Cities_Number + @" > 1 
else_jump @PLANES_6446 
gosub @PLANES_8029 
033F: set_text_draw_letter_size 0.62 1.54 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_5203 
033E: set_draw_text_position 92.0 372.0 GXT 'PLA_22'  

:PLANES_5203
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_5242 
033E: set_draw_text_position 52.0 372.0 GXT 'PLA_22'  

:PLANES_5242
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_5281 
033E: set_draw_text_position 52.0 372.0 GXT 'PLA_22'  

:PLANES_5281
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_5320 
033E: set_draw_text_position 52.0 372.0 GXT 'PLA_22'  

:PLANES_5320
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_5359 
033E: set_draw_text_position 52.0 372.0 GXT 'PLA_22'  

:PLANES_5359
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_5419 
033E: set_draw_text_position 124.0 368.0 GXT 'PLA_19'  

:PLANES_5419
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_5458 
033E: set_draw_text_position 84.0 368.0 GXT 'PLA_19'  

:PLANES_5458
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_5497 
033E: set_draw_text_position 84.0 368.0 GXT 'PLA_19'  

:PLANES_5497
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_5536 
033E: set_draw_text_position 84.0 368.0 GXT 'PLA_19'  

:PLANES_5536
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_5575 
033E: set_draw_text_position 84.0 368.0 GXT 'PLA_19'  

:PLANES_5575
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_5635 
033E: set_draw_text_position 252.0 368.0 GXT 'PLA_24'  

:PLANES_5635
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_5674 
033E: set_draw_text_position 294.0 354.0 GXT 'PLA_24'  

:PLANES_5674
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_5713 
033E: set_draw_text_position 294.0 354.0 GXT 'PLA_24'  

:PLANES_5713
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_5752 
033E: set_draw_text_position 255.0 354.0 GXT 'PLA_24'  

:PLANES_5752
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_5791 
033E: set_draw_text_position 294.0 354.0 GXT 'PLA_24'  

:PLANES_5791
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_5851 
033E: set_draw_text_position 337.0 368.0 GXT 'PLA_20'  

:PLANES_5851
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_5890 
033E: set_draw_text_position 294.0 373.0 GXT 'PLA_20'  

:PLANES_5890
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_5929 
033E: set_draw_text_position 294.0 373.0 GXT 'PLA_20'  

:PLANES_5929
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_5968 
033E: set_draw_text_position 255.0 373.0 GXT 'PLA_20'  

:PLANES_5968
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_6007 
033E: set_draw_text_position 294.0 373.0 GXT 'PLA_20'  

:PLANES_6007
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_6067 
033E: set_draw_text_position 423.0 368.0 GXT 'PLA_23'  

:PLANES_6067
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_6106 
033E: set_draw_text_position 457.0 354.0 GXT 'PLA_23'  

:PLANES_6106
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_6145 
033E: set_draw_text_position 457.0 354.0 GXT 'PLA_23'  

:PLANES_6145
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_6184 
033E: set_draw_text_position 457.0 354.0 GXT 'PLA_23'  

:PLANES_6184
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_6223 
033E: set_draw_text_position 457.0 354.0 GXT 'PLA_23'  

:PLANES_6223
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_6283 
033E: set_draw_text_position 507.0 368.0 GXT 'PLA_21'  

:PLANES_6283
if 
04A3:   " + Current_Language + @" == 1 
else_jump @PLANES_6322 
033E: set_draw_text_position 457.0 373.0 GXT 'PLA_21'  

:PLANES_6322
if 
04A3:   " + Current_Language + @" == 2 
else_jump @PLANES_6361 
033E: set_draw_text_position 457.0 373.0 GXT 'PLA_21'  

:PLANES_6361
if 
04A3:   " + Current_Language + @" == 3 
else_jump @PLANES_6400 
033E: set_draw_text_position 457.0 373.0 GXT 'PLA_21'  

:PLANES_6400
if 
04A3:   " + Current_Language + @" == 4 
else_jump @PLANES_6439 
033E: set_draw_text_position 457.0 373.0 GXT 'PLA_21'  

:PLANES_6439
jump @PLANES_6706 

:PLANES_6446
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_6513 
033E: set_draw_text_position 155.0 368.0 GXT 'PLA_24'  
jump @PLANES_6534 

:PLANES_6513
033E: set_draw_text_position 105.0 368.0 GXT 'PLA_24'  

:PLANES_6534
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @PLANES_6601 
033E: set_draw_text_position 241.0 368.0 GXT 'PLA_20'  
jump @PLANES_6622 

:PLANES_6601
033E: set_draw_text_position 191.0 368.0 GXT 'PLA_20'  

:PLANES_6622
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 328.0 368.0 GXT 'PLA_23'  
gosub @PLANES_8029 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 412.0 368.0 GXT 'PLA_21'  

:PLANES_6706
gosub @PLANES_7954 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 92.0 167.0 GXT " + tmp_PLANES_DayNames + @"(" + PLANES_Weekday + @",8s) 
gosub @PLANES_7954 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 92.0 290.0 GXT 'PLA_18' number " + _9500 + @"  
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @PLANES_7079 
gosub @PLANES_7954 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_6855 
0340: set_text_draw_RGBA 255 255 255 255 
jump @PLANES_6866 

:PLANES_6855
0340: set_text_draw_RGBA 40 40 40 255 

:PLANES_6866
033E: set_draw_text_position 92.0 230.0 GXT 'PLA_15'  
if 
  " + PLANES_STAT_Unlocked_Cities_Number + @" > 1 
else_jump @PLANES_6983 
gosub @PLANES_7954 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_6948 
0340: set_text_draw_RGBA 40 40 40 255 
jump @PLANES_6962 

:PLANES_6948
0340: set_text_draw_RGBA 255 255 255 255 

:PLANES_6962
033E: set_draw_text_position 282.0 230.0 GXT 'PLA_14'  

:PLANES_6983
gosub @PLANES_7954 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7054 
045B: draw_text_2numbers 281.0 167.0 GXT 'PLA_10' numbers 10 30  
jump @PLANES_7079 

:PLANES_7054
045B: draw_text_2numbers 281.0 167.0 GXT 'PLA_10' numbers 17 50  

:PLANES_7079
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @PLANES_7367 
gosub @PLANES_7954 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7143 
0340: set_text_draw_RGBA 255 255 255 255 
jump @PLANES_7154 

:PLANES_7143
0340: set_text_draw_RGBA 40 40 40 255 

:PLANES_7154
033E: set_draw_text_position 92.0 230.0 GXT 'PLA_16'  
if 
  " + PLANES_STAT_Unlocked_Cities_Number + @" > 1 
else_jump @PLANES_7271 
gosub @PLANES_7954 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7236 
0340: set_text_draw_RGBA 40 40 40 255 
jump @PLANES_7250 

:PLANES_7236
0340: set_text_draw_RGBA 255 255 255 255 

:PLANES_7250
033E: set_draw_text_position 282.0 230.0 GXT 'PLA_14'  

:PLANES_7271
gosub @PLANES_7954 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7342 
045B: draw_text_2numbers 281.0 167.0 GXT 'PLA_10' numbers 11 20  
jump @PLANES_7367 

:PLANES_7342
045B: draw_text_2numbers 281.0 167.0 GXT 'PLA_10' numbers 14 40  

:PLANES_7367
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @PLANES_7637 
gosub @PLANES_7954 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7431 
0340: set_text_draw_RGBA 255 255 255 255 
jump @PLANES_7442 

:PLANES_7431
0340: set_text_draw_RGBA 40 40 40 255 

:PLANES_7442
033E: set_draw_text_position 92.0 230.0 GXT 'PLA_16'  
gosub @PLANES_7954 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7506 
0340: set_text_draw_RGBA 40 40 40 255 
jump @PLANES_7520 

:PLANES_7506
0340: set_text_draw_RGBA 255 255 255 255 

:PLANES_7520
033E: set_draw_text_position 282.0 230.0 GXT 'PLA_15'  
gosub @PLANES_7954 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  " + PLANES_Conversation_YES + @" == 0 
else_jump @PLANES_7612 
045B: draw_text_2numbers 281.0 167.0 GXT 'PLA_10' numbers 19 10  
jump @PLANES_7637 

:PLANES_7612
045B: draw_text_2numbers 281.0 167.0 GXT 'PLA_10' numbers 14 30  

:PLANES_7637
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 2 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 2 position 160.0 317.0 size 320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 2 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 2 position 480.0 317.0 size -320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 3 position 160.0 435.0 size 320.0 17.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 3 position 480.0 435.0 size -320.0 17.0 RGBA 150 150 150 255 
return 

:PLANES_7879
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.0 3.4 
060D: draw_text_shadow 3 rgba 0 0 0 255 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 2 
return 

:PLANES_7954
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.62 2.34 
060D: draw_text_shadow 2 rgba 0 0 0 255 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 2 
return 

:PLANES_8029
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.42 2.24 
060D: draw_text_shadow 2 rgba 0 0 0 255 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 2 
return 
end_thread" );
            }

        }

    }

}