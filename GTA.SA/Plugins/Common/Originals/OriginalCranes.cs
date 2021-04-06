using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalCranes : Original {

        internal OriginalCranes() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            
            Script.AppendLine( @"" + _2722 + @" = Object.Init(#TWRCRANE_M_04, -2080.441, 256.015, 66.869)
Object.RemoveFromMissionCleanupList(" + _2722 + @")
" + _2723 + @" = Object.Init(#TWRCRANE_M_01, -2080.441, 256.007, 99.408)
Object.RemoveFromMissionCleanupList(" + _2723 + @")
" + _2724 + @" = Object.Init(#TWRCRANE_M_02, -2080.441, 296.46, 102.861)
Object.RemoveFromMissionCleanupList(" + _2724 + @")
Object.StorePos(" + _2722 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2722 + @")
" + _2725 + @" = Object.Init(#LODCRANE_M_04, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2725 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2725 + @")
Object.StorePos(" + _2723 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2723 + @")
" + _2726 + @" = Object.Init(#LODCRANE_M_01, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2726 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2726 + @")
0827: assign_object " + _2722 + @" to_lod_object " + _2725 + @" 
0827: assign_object " + _2723 + @" to_lod_object " + _2726 + @" 
" + _2727 + @" = Object.Init(#MAGNOCRANE_01, -1547.978, 123.9883, 26.9332)
Object.Angle(" + _2727 + @") = 45.0
Object.RemoveFromMissionCleanupList(" + _2727 + @")
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2727 + @" with_offset 0.0 0.0 0.0 
" + _2728 + @" = Object.Init(#MAGNOCRANE_02, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.RemoveFromMissionCleanupList(" + _2728 + @")
Object.Angle(" + _2728 + @") = 140.0
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2728 + @" with_offset 0.0 -2.185 8.51 
" + tempvar_Angle + @" = Object.Angle(" + _2728 + @")
" + Crane_Magnet + @" = Object.Init(#MAGNOCRANE_03, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0453: set_object " + Crane_Magnet + @" XYZ_rotation 15.0 0.0 " + tempvar_Angle + @" 
Object.RemoveFromMissionCleanupList(" + Crane_Magnet + @")
Object.StorePos(" + _2727 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2727 + @")
" + _2730 + @" = Object.Init(#LODNOCRANE_01, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2730 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2730 + @")
Object.StorePos(" + _2728 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2728 + @")
" + _2731 + @" = Object.Init(#LODNOCRANE_02, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2731 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2731 + @")
Object.StorePos(" + Crane_Magnet + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + Crane_Magnet + @")
" + _2732 + @" = Object.Init(#LODNOCRANE_03, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2732 + @") = " + tempvar_Angle + @"
0453: set_object " + _2732 + @" XYZ_rotation 15.0 0.0 " + tempvar_Angle + @" 
Object.RemoveFromMissionCleanupList(" + _2732 + @")
0827: assign_object " + _2727 + @" to_lod_object " + _2730 + @" 
0827: assign_object " + _2728 + @" to_lod_object " + _2731 + @" 
0827: assign_object " + Crane_Magnet + @" to_lod_object " + _2732 + @" 
" + _2740 + @" = Object.Init(#QUARRY_CRANEBASE, 709.45, 915.93, -19.66)
Object.Angle(" + _2740 + @") = 135.0
Object.RemoveFromMissionCleanupList(" + _2740 + @")
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2740 + @" with_offset 0.0 0.0 4.0689 
" + tempvar_Angle + @" = Object.Angle(" + _2740 + @")
" + _2741 + @" = Object.Init(#QUARRY_CRANE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2741 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2741 + @")
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2741 + @" with_offset 0.0 0.0 1.0206 
" + tempvar_Angle + @" = Object.Angle(" + _2741 + @")
" + _2742 + @" = Object.Init(#QUARRY_CRANEARM, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2742 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2742 + @")
" + _2739 + @" = 45.0 
0453: set_object " + _2742 + @" XYZ_rotation 0.0 " + _2739 + @" " + tempvar_Angle + @" 
" + _2743 + @" = Object.Init(#TWRCRANE_M_04, 2399.202, 1879.139, 37.55)
Object.Angle(" + _2743 + @") = 0.0
Object.RemoveFromMissionCleanupList(" + _2743 + @")
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2743 + @" with_offset 0.0 0.0 32.521 
" + tempvar_Angle + @" = Object.Angle(" + _2743 + @")
" + _2744 + @" = Object.Init(#TWRCRANE_M_01, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2744 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2744 + @")
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2744 + @" with_offset 0.0 20.0 3.789 
" + tempvar_Angle + @" = Object.Angle(" + _2744 + @")
" + _2745 + @" = Object.Init(#TWRCRANE_M_02, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2745 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2745 + @")
Object.StorePos(" + _2743 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2743 + @")
" + _2746 + @" = Object.Init(#LODCRANE_M_04, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2746 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2746 + @")
Object.StorePos(" + _2744 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2744 + @")
" + _2747 + @" = Object.Init(#LODCRANE_M_01, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2747 + @") = " + tempvar_Angle + @"
Object.RemoveFromMissionCleanupList(" + _2747 + @")
0827: assign_object " + _2743 + @" to_lod_object " + _2746 + @" 
0827: assign_object " + _2744 + @" to_lod_object " + _2747 + @"" );

            Script.create_thread<CRANES>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class CRANES : Thread {

            Int _local0 = local( 0 ); // 0@

            public override void START( LabelJump label ) {
                AppendLine( @"
:CRANES_40
wait 100 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANES_507 
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point -2080.441 256.015 radius 10.0 10.0 
jf @CRANES_168" );
                get_external_script_status<CRANE1>( _local0 );
AppendLine( @"if 
  0@ == 0 
jf @CRANES_164" );
                load_external_script<CRANE1>();
AppendLine( @"if " );
                is_external_script_loaded<CRANE1>().write();
AppendLine( @"jf @CRANES_157" );
                start_new_external_script<CRANE1>( _2722 );
AppendLine( @"0@ += 1 

:CRANES_157
jump @CRANES_168 

:CRANES_164" );
                remove_references_external_script<CRANE1>();
AppendLine( @"
:CRANES_168
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 2399.202 1879.139 radius 10.0 10.0 
jf @CRANES_276 " );
                get_external_script_status<CRANE1>( _local0 );
AppendLine( @"if 
  0@ == 0 
jf @CRANES_272 " );
                load_external_script<CRANE1>();
AppendLine( @"if " );
                is_external_script_loaded<CRANE1>().write();
AppendLine( @"jf @CRANES_265" );
                start_new_external_script<CRANE1>( _2743 );
AppendLine( @"0@ += 1

:CRANES_265
jump @CRANES_276 

:CRANES_272" );
                remove_references_external_script<CRANE1>();
AppendLine( @"
:CRANES_276
if 
03CA:   object " + _2727 + @" exists 
jf @CRANES_393 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle " + _2727 + @" radius 50.0 50.0 sphere 0 
jf @CRANES_393 " );
                get_external_script_status<CRANE2>( _local0 );
AppendLine( @"if 
  0@ == 0 
jf @CRANES_389" );
                load_external_script<CRANE2>();
AppendLine( @"if" );
                is_external_script_loaded<CRANE2>().write();
AppendLine( @"jf @CRANES_382 " );
                start_new_external_script<CRANE2>( _2727 );
AppendLine( @"0@ += 1 

:CRANES_382
jump @CRANES_393 

:CRANES_389" );
                remove_references_external_script<CRANE2>();
AppendLine( @"
:CRANES_393
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 709.45 915.93 radius 10.0 10.0 
jf @CRANES_507" );
                get_external_script_status<CRANE3>( _local0 );
AppendLine( @"if 
  0@ == 0 
jf @CRANES_503" );
                load_external_script<CRANE3>();
AppendLine( @"if" );
                is_external_script_loaded<CRANE3>().write();
AppendLine( @"jf @CRANES_496 " );
                start_new_external_script<CRANE3>( _2740, _2741, _2742 );
AppendLine( @"0@ += 1 

:CRANES_496
jump @CRANES_507 

:CRANES_503" );
                remove_references_external_script<CRANE3>();
AppendLine( @"
:CRANES_507
jump @CRANES_40" );
            }

        }

        private sealed class CRANE1 : External {

            public override void START( LabelJump label ) {
                AppendLine( @"5@ = 0 
if 
  5@ == 1 
jf @CRANE1_102 
0@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
1@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
2@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)

:CRANE1_102
if 
03CA:   object 0@ exists 
jf @CRANE1_258 
if 
04E5:   object 0@ near_point -2080.441 256.015 radius 10.0 10.0 sphere 0 
jf @CRANE1_188 
008B: 1@ = " + _2723 + @" 
008B: 2@ = " + _2724 + @" 
008B: 3@ = " + _2726 + @" 
008B: 4@ = " + _2725 + @" 

:CRANE1_188
if 
04E5:   object 0@ near_point 2399.202 1879.139 radius 10.0 10.0 sphere 0 
jf @CRANE1_258 
008B: 1@ = " + _2744 + @" 
008B: 2@ = " + _2745 + @" 
008B: 3@ = " + _2747 + @" 
008B: 4@ = " + _2746 + @" 

:CRANE1_258
" + _10490 + @" = 0 
21@ = 0 

:CRANE1_272
wait 0 
if 
03CA:   object 0@ exists 
jf @CRANE1_2496 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_2489 
if 
  " + _10493 + @" == 0 
jf @CRANE1_2489 
if 
  " + _1911 + @" == 1 
jf @CRANE1_351 
gosub @CRANE1_2512 

:CRANE1_351
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 100.0 100.0 sphere 0 
jf @CRANE1_2487 
if 
  " + flag_Player_In_Crane + @" == 1 
jf @CRANE1_407 
gosub @CRANE1_2512 

:CRANE1_407
if 
  5@ == 0 
jf @CRANE1_461 
0400: store_coords_to 9@ 10@ 11@ from_object 0@ with_offset 0.0 -7.2092 -31.7581 
5@ += 1 

:CRANE1_461
if 
  5@ == 1 
jf @CRANE1_646 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 9@ 10@ 11@ radius 1.2 1.2 1.5 on_foot 
jf @CRANE1_619 
if 
044B:   actor " + PlayerActor + @" on_foot 
jf @CRANE1_612 
if 
  " + _10490 + @" == 0 
jf @CRANE1_573 
0512: show_permanent_text_box 'CR_2'  
" + _10490 + @" = 1 

:CRANE1_573
if 
00E1:   player 0 pressed_key 15 
jf @CRANE1_612 
5@ += 1 
TIMERA = 6000 
" + _10490 + @" = 0 

:CRANE1_612
jump @CRANE1_646 

:CRANE1_619
if 
   not " + _10490 + @" == 0 
jf @CRANE1_646 
03E6: remove_text_box 
" + _10490 + @" = 0 

:CRANE1_646
if 
  5@ == 2 
jf @CRANE1_1068 
if 
03CA:   object 1@ exists 
jf @CRANE1_688 
097B: play_audio_at_object 1@ event 1019 

:CRANE1_688
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
fade 0 500 

:CRANE1_706
if 
fading 
jf @CRANE1_730 
wait 0 
jump @CRANE1_706 

:CRANE1_730
if 
07D6:   1@ == " + _2723 + @" 
jf @CRANE1_758 
079E: unknown_set_game_controller_to_steer_object_TWRCRANE_M_02 
jump @CRANE1_760 

:CRANE1_758
07FA: set_game_controller_to_steer_object_TWRCRANE_M_02 

:CRANE1_760
0A44: override_text_block 1 
7@ = Object.Angle(1@)
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.StorePos(2@, 12@, 13@, 14@)
0509: 8@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 12@ 13@ 
if 
  8@ > 47.5 
jf @CRANE1_848 
8@ = 47.5 

:CRANE1_848
if 
  10.0 > 8@ 
jf @CRANE1_879 
8@ = 10.0 

:CRANE1_879
if 
03CA:   object 1@ exists 
jf @CRANE1_943 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_943 
04F4: put_actor " + PlayerActor + @" into_turret_on_object 0@ offset_from_object_origin 0.0 0.0 34.5 orientation 0 both_side_angle_limit 360.0 lock_weapon 0 

:CRANE1_943
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_1016 
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
0337: set_actor " + PlayerActor + @" visibility 0 
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Actor.SetImmunities(" + PlayerActor + @", 1, 1, 1, 1, 1)
" + flag_Player_In_Crane + @" = 1 
22@ = 0 

:CRANE1_1016
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
gosub @CRANE1_2512 
fade 1 500 

:CRANE1_1037
if 
fading 
jf @CRANE1_1061 
wait 0 
jump @CRANE1_1037 

:CRANE1_1061
5@ += 1 

:CRANE1_1068
if 
  5@ == 3 
jf @CRANE1_2277 
if 
  TIMERA > 6000 
jf @CRANE1_1468 
" + _10490 + @" += 1 
if 
  7 > " + _10490 + @" 
jf @CRANE1_1461 
0871: init_jump_table " + _10490 + @" total_jumps 6 default_jump 0 @CRANE1_1461 jumps 1 @CRANE1_1193 2 @CRANE1_1250 3 @CRANE1_1307 4 @CRANE1_1364 5 @CRANE1_1421 6 @CRANE1_1441 -1 @CRANE1_1461 

:CRANE1_1193
03E6: remove_text_box 
if 
07D6:   1@ == " + _2723 + @" 
jf @CRANE1_1232 
0512: show_permanent_text_box 'CONS_1'  
jump @CRANE1_1243 

:CRANE1_1232
0512: show_permanent_text_box 'CONS_1B'  

:CRANE1_1243
jump @CRANE1_1461 

:CRANE1_1250
03E6: remove_text_box 
if 
07D6:   1@ == " + _2723 + @" 
jf @CRANE1_1289 
0512: show_permanent_text_box 'CONS_2'  
jump @CRANE1_1300 

:CRANE1_1289
0512: show_permanent_text_box 'CONS_2B'  

:CRANE1_1300
jump @CRANE1_1461 

:CRANE1_1307
03E6: remove_text_box 
if 
07D6:   1@ == " + _2723 + @" 
jf @CRANE1_1346 
0512: show_permanent_text_box 'CONS_3'  
jump @CRANE1_1357 

:CRANE1_1346
0512: show_permanent_text_box 'CONS_3B'  

:CRANE1_1357
jump @CRANE1_1461 

:CRANE1_1364
03E6: remove_text_box 
if 
07D6:   1@ == " + _2723 + @" 
jf @CRANE1_1403 
0512: show_permanent_text_box 'CONS_4'  
jump @CRANE1_1414 

:CRANE1_1403
0512: show_permanent_text_box 'CONS_4B'  

:CRANE1_1414
jump @CRANE1_1461 

:CRANE1_1421
03E6: remove_text_box 
0512: show_permanent_text_box 'CONS_5'  
jump @CRANE1_1461 

:CRANE1_1441
03E6: remove_text_box 
03E5: show_text_box 'CR_3'  
jump @CRANE1_1461 

:CRANE1_1461
TIMERA = 0 

:CRANE1_1468
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_2277 
if 
0735:   is_keyboard_key_pressed 81 
jf @CRANE1_1509 
" + _10487 + @" += 0.1 

:CRANE1_1509
if 
0735:   is_keyboard_key_pressed 65 
jf @CRANE1_1534 
" + _10487 + @" += -0.1 

:CRANE1_1534
if 
0735:   is_keyboard_key_pressed 87 
jf @CRANE1_1559 
" + _10488 + @" += 0.1 

:CRANE1_1559
if 
0735:   is_keyboard_key_pressed 83 
jf @CRANE1_1584 
" + _10488 + @" += -0.1 

:CRANE1_1584
if 
0735:   is_keyboard_key_pressed 69 
jf @CRANE1_1609 
" + _10489 + @" += 0.1 

:CRANE1_1609
if 
0735:   is_keyboard_key_pressed 68 
jf @CRANE1_1634 
" + _10489 + @" += -0.1 

:CRANE1_1634
if 
00E1:   player 0 pressed_key 0 
jf @CRANE1_1749 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 6@ = integer " + Move_Axis_X + @" to_float 
6@ /= 500.0 
0081: 7@ -= frame_delta_time * 6@ 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_1742 
if 
   not 22@ == 1 
jf @CRANE1_1742 
097B: play_audio_at_object 1@ event 1020 
22@ = 1 

:CRANE1_1742
jump @CRANE1_1798 

:CRANE1_1749
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_1798 
if 
   not 22@ == 0 
jf @CRANE1_1798 
097B: play_audio_at_object 1@ event 1021 
22@ = 0 

:CRANE1_1798
if 
00E1:   player 0 pressed_key 1 
jf @CRANE1_2000 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 6@ = integer " + Move_Axis_Y + @" to_float 
6@ /= 128.0 
if or
  6@ > 0.6 
  -0.6 > 6@ 
jf @CRANE1_1993 
6@ *= 0.15 
0081: 8@ -= frame_delta_time * 6@ 
if 
  8@ > 47.5 
jf @CRANE1_1929 
8@ = 47.5 

:CRANE1_1929
if 
  10.0 > 8@ 
jf @CRANE1_1960 
8@ = 10.0 

:CRANE1_1960
if 
   not 23@ == 1 
jf @CRANE1_1993 
097B: play_audio_at_object 2@ event 1020 
23@ = 1 

:CRANE1_1993
jump @CRANE1_2033 

:CRANE1_2000
if 
   not 23@ == 0 
jf @CRANE1_2033 
097B: play_audio_at_object 2@ event 1021 
23@ = 0 

:CRANE1_2033
if 
03CA:   object 2@ exists 
jf @CRANE1_2071 
if 
00E1:   player 0 pressed_key 16 
jf @CRANE1_2071 
0799: set_crane_magnet 2@ release_stuff_from_magnet 

:CRANE1_2071
if 
03CA:   object 1@ exists 
jf @CRANE1_2172 
if 
03CA:   object 0@ exists 
jf @CRANE1_2172 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 32.521 
Object.Angle(1@) = 7@
if 
03CA:   object 3@ exists 
jf @CRANE1_2164 
Object.Angle(3@) = 7@

:CRANE1_2164
Actor.Angle(" + PlayerActor + @") = 7@

:CRANE1_2172
if 
03CA:   object 1@ exists 
jf @CRANE1_2253 
if 
03CA:   object 2@ exists 
jf @CRANE1_2253 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 1@ with_offset 0.0 8@ 3.453 
0815: put_object 2@ at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_keep_rotation 
Object.Angle(2@) = 7@

:CRANE1_2253
if 
00E1:   player 0 pressed_key 15 
jf @CRANE1_2277 
5@ += 1 

:CRANE1_2277
if 
  5@ == 4 
jf @CRANE1_2480 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE1_2480 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
03CA:   object 1@ exists 
jf @CRANE1_2349 
097B: play_audio_at_object 1@ event 1022 

:CRANE1_2349
03E6: remove_text_box 
079F: unknown_set_game_controller_to_steer_no_crane_objects 
09BD: allow_other_threads_to_display_text_boxes 0 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 2.0 -7.0 0.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0465: remove_actor " + PlayerActor + @" from_turret_mode 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
0337: set_actor " + PlayerActor + @" visibility 1 
0619: enable_actor " + PlayerActor + @" collision_detection 1 
Actor.SetImmunities(" + PlayerActor + @", 0, 0, 0, 0, 0)
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
" + flag_Player_In_Crane + @" = 0 
5@ = 0 
end_thread 

:CRANE1_2480
jump @CRANE1_2489 

:CRANE1_2487
end_thread 

:CRANE1_2489
jump @CRANE1_2505 

:CRANE1_2496
5@ = 0 
end_thread 

:CRANE1_2505
jump @CRANE1_272 

:CRANE1_2512
if 
  " + _10494 + @" == 0 
jf @CRANE1_3074 
if 
00E1:   player 0 pressed_key 13 
jf @CRANE1_2619 
if 
  24@ == 0 
jf @CRANE1_2612 
21@ += 1 
if 
  21@ > 2 
jf @CRANE1_2597 
21@ = 0 

:CRANE1_2597
008A: " + _10495 + @" = 21@ 
24@ += 1 

:CRANE1_2612
jump @CRANE1_2644 

:CRANE1_2619
if 
   not 24@ == 0 
jf @CRANE1_2644 
24@ = 0 

:CRANE1_2644
if 
  " + flag_Player_In_Crane + @" == 1 
jf @CRANE1_2695 
if 
  " + _1911 + @" == 1 
jf @CRANE1_2695 
0084: " + _10495 + @" = " + _10495 + @" 
" + _1911 + @" = 0 

:CRANE1_2695
if 
  21@ == 0 
jf @CRANE1_2758 
if 
03CA:   object 1@ exists 
jf @CRANE1_2758 
0400: store_coords_to 15@ 16@ 17@ from_object 1@ with_offset -7.18 -6.42 15.79 

:CRANE1_2758
if 
  21@ == 1 
jf @CRANE1_2920 
if 
03CA:   object 1@ exists 
jf @CRANE1_2920 
0400: store_coords_to 15@ 16@ 17@ from_object 2@ with_offset 0.0 -4.5 20.1999 
if 
03CA:   object 2@ exists 
jf @CRANE1_2920 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 20.1999 
0796: get_crane_magnet 2@ magnet_lane_length_to 6@ 
6@ += -1.0 
6@ *= -1.0 
6@ *= 72.0 
0067: " + tempvar_Float_3 + @" -= 6@ 
0089: 17@ = " + tempvar_Float_3 + @" 

:CRANE1_2920
if 
03CA:   object 2@ exists 
jf @CRANE1_3035 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 2.0 
0796: get_crane_magnet 2@ magnet_lane_length_to 6@ 
6@ += -1.0 
6@ *= -1.0 
6@ *= 72.0 
0067: " + tempvar_Float_3 + @" -= 6@ 
0089: 18@ = " + tempvar_Float_1 + @" 
0089: 19@ = " + tempvar_Float_2 + @" 
0089: 20@ = " + tempvar_Float_3 + @" 

:CRANE1_3035
Camera.SetPosition(15@, 16@, 17@, 0.0, 0.0, 0.0)
Camera.PointAt(18@, 19@, 20@, 2)

:CRANE1_3074
return 
end_thread" );
            }

        }

        private sealed class CRANE2 : External {

            public override void START( LabelJump label ) {
                AppendLine( @"0@ = 0 
if 
  0@ == 1 
jf @CRANE2_102 
" + _2727 + @" = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
" + _2728 + @" = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
" + Crane_Magnet + @" = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)

:CRANE2_102
" + _10491 + @" = 0 
" + _10509 + @" = 33.7 
" + _2738 + @" = 15.0 
28@ = 0 
27@ = 1 
" + _1919 + @" = 0 

:CRANE2_150
wait 0 
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_4700 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE2_4693 
if 
  " + _10493 + @" == 0 
jf @CRANE2_4693 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle " + _2727 + @" radius 100.0 100.0 sphere 0 
jf @CRANE2_4691 
if 
  " + _1911 + @" == 1 
jf @CRANE2_260 
gosub @CRANE2_4716 

:CRANE2_260
if and
   Player.Defined(" + PlayerChar + @")
  " + _1912 + @" == 0 
jf @CRANE2_4684 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle " + _2727 + @" radius 100.0 100.0 sphere 0 
jf @CRANE2_4659 
if 
  " + flag_Player_In_Crane + @" == 2 
jf @CRANE2_339 
gosub @CRANE2_4716 

:CRANE2_339
if 
  0@ == 0 
jf @CRANE2_393 
0400: store_coords_to 1@ 2@ 3@ from_object " + _2727 + @" with_offset -1.7837 2.4699 -24.1519 
0@ += 1 

:CRANE2_393
if 
  0@ == 1 
jf @CRANE2_691 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 1@ 2@ 3@ radius 1.2 1.2 1.5 on_foot 
jf @CRANE2_538 
if 
044B:   actor " + PlayerActor + @" on_foot 
jf @CRANE2_531 
if 
  " + _10491 + @" == 0 
jf @CRANE2_505 
0512: show_permanent_text_box 'CR_2'  // ~k~~VEHICLE_ENTER_EXIT~ - џaћeџ¦© ®a kpa®.
" + _10491 + @" = 1 

:CRANE2_505
if 
00E1:   player 0 pressed_key 15 
jf @CRANE2_531 
03E6: remove_text_box 
0@ += 1 

:CRANE2_531
jump @CRANE2_565 

:CRANE2_538
if 
   not " + _10491 + @" == 0 
jf @CRANE2_565 
03E6: remove_text_box 
" + _10491 + @" = 0 

:CRANE2_565
if 
  15.0 > " + _2738 + @" 
jf @CRANE2_628 
" + _2738 + @" = 15.0 
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_628 
0453: set_object " + Crane_Magnet + @" XYZ_rotation " + _2738 + @" 0.0 " + _2737 + @" 

:CRANE2_628
if 
  " + _2738 + @" > 30.0 
jf @CRANE2_691 
" + _2738 + @" = 30.0 
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_691 
0453: set_object " + Crane_Magnet + @" XYZ_rotation " + _2738 + @" 0.0 " + _2737 + @" 

:CRANE2_691
if 
  0@ == 2 
jf @CRANE2_1309 
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_733 
097B: play_audio_at_object " + _2728 + @" event 1019 

:CRANE2_733
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
" + flag_Player_In_Crane + @" = 2 
fade 0 500 

:CRANE2_758
if 
fading 
jf @CRANE2_782 
wait 0 
jump @CRANE2_758 

:CRANE2_782
079D: unknown_set_game_controller_to_steer_object_MagnoCrane_03 // originally SF docks magnocrane 
0A44: override_text_block 1 
" + _2736 + @" = Object.Angle(" + _2728 + @")
" + _2737 + @" = Object.Angle(" + Crane_Magnet + @")
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_882 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE2_882 
Object.StorePos(" + _2727 + @", " + _2733 + @", " + _2734 + @", " + _2735 + @")
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _2727 + @" offset_from_object_origin 0.0 0.0 2.0 orientation 0 both_side_angle_limit 360.0 lock_weapon 0 

:CRANE2_882
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE2_948 
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
0337: set_actor " + PlayerActor + @" visibility 0 
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Actor.SetImmunities(" + PlayerActor + @", 1, 1, 1, 1, 1)
" + _10515 + @" = 0 

:CRANE2_948
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_978 
Object.StorePos(" + _2727 + @", 21@, 22@, " + tempvar_Float_3 + @")

:CRANE2_978
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_1002 
25@ = Object.Angle(" + Crane_Magnet + @")

:CRANE2_1002
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_1204 
0400: store_coords_to " + _10503 + @" " + _10504 + @" " + _10505 + @" from_object " + Crane_Magnet + @" with_offset 0.0 " + _10509 + @" -3.0 
0796: get_crane_magnet " + Crane_Magnet + @" magnet_lane_length_to 4@ // float 
4@ += -1.0 
4@ *= -1.0 
4@ *= 50.0 
0067: " + _10505 + @" -= 4@ // (float) 
0086: " + tempvar_Float_1 + @" = " + _10503 + @" // (float) 
0061: " + tempvar_Float_1 + @" -= " + _2733 + @" // (float) 
0086: " + tempvar_Float_2 + @" = " + _10504 + @" // (float) 
0061: " + tempvar_Float_2 + @" -= " + _2734 + @" // (float) 
0509: 4@ = distance_between_XY " + _10503 + @" " + _10504 + @" and_XY " + _2733 + @" " + _2734 + @" 
0075: " + tempvar_Float_1 + @" /= 4@ // (float) 
0075: " + tempvar_Float_2 + @" /= 4@ // (float) 
0069: " + tempvar_Float_1 + @" *= " + _10509 + @" // (float) 
0069: " + tempvar_Float_2 + @" *= " + _10509 + @" // (float) 
0086: " + _10503 + @" = " + _2733 + @" // (float) 
0059: " + _10503 + @" += " + tempvar_Float_1 + @" // (float) 
0086: " + _10504 + @" = " + _2734 + @" // (float) 
0059: " + _10504 + @" += " + tempvar_Float_2 + @" // (float) 

:CRANE2_1204
0089: 10@ = " + _10503 + @" // (float) 
0089: 11@ = " + _10504 + @" // (float) 
" + _10510 + @" = 0.0 
" + _10511 + @" = 0.0 
" + _10512 + @" = 0.3 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
gosub @CRANE2_4716 
fade 1 500 

:CRANE2_1271
if 
fading 
jf @CRANE2_1302 
wait 0 
gosub @CRANE2_4716 
jump @CRANE2_1271 

:CRANE2_1302
0@ += 1 

:CRANE2_1309
if 
  0@ == 3 
jf @CRANE2_4430 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE2_4430 
if 
0735:   is_keyboard_key_pressed 131 
jf @CRANE2_1369 
" + _10509 + @" += 0.1 

:CRANE2_1369
if 
0735:   is_keyboard_key_pressed 130 
jf @CRANE2_1395 
" + _10509 + @" += -0.1 

:CRANE2_1395
if 
  " + flag_Player_In_Crane + @" == 2 
jf @CRANE2_3930 
if or
00E1:   player 0 pressed_key 0 
00E1:   player 0 pressed_key 1 
jf @CRANE2_2947 
if 
   not " + _10515 + @" == 1 
jf @CRANE2_1485 
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_1478 
097B: play_audio_at_object " + _2728 + @" event 1020 

:CRANE2_1478
" + _10515 + @" = 1 

:CRANE2_1485
if 
  " + _1918 + @" == 0 
jf @CRANE2_2940 
28@ = 1 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 6@ = integer " + Move_Axis_X + @" to_float 
008F: 7@ = integer " + Move_Axis_Y + @" to_float 
6@ /= 128.0 
7@ /= 128.0 
6@ *= 0.15 
7@ *= 0.15 
0089: 12@ = " + _10506 + @" // (float) 
0089: 13@ = " + _10507 + @" // (float) 
0087: 15@ = 13@ // (float) 
0087: 16@ = 12@ // (float) 
16@ *= -1.0 
006B: 12@ *= 7@ // (float) 
006B: 13@ *= 7@ // (float) 
12@ *= -1.0 
13@ *= -1.0 
007B: 10@ += frame_delta_time * 12@ // (float) 
007B: 11@ += frame_delta_time * 13@ // (float) 
006B: 15@ *= 6@ // (float) 
006B: 16@ *= 6@ // (float) 
007B: 10@ += frame_delta_time * 15@ // (float) 
007B: 11@ += frame_delta_time * 16@ // (float) 
0509: 4@ = distance_between_XY 10@ 11@ and_XY " + _10500 + @" " + _10501 + @" 
if 
  4@ > 0.3 
jf @CRANE2_1846 
0088: " + tempvar_Float_1 + @" = 10@ // (float) 
0061: " + tempvar_Float_1 + @" -= " + _10500 + @" // (float) 
0088: " + tempvar_Float_2 + @" = 11@ // (float) 
0061: " + tempvar_Float_2 + @" -= " + _10501 + @" // (float) 
0075: " + tempvar_Float_1 + @" /= 4@ // (float) 
0075: " + tempvar_Float_2 + @" /= 4@ // (float) 
" + tempvar_Float_1 + @" *= 0.3 
" + tempvar_Float_2 + @" *= 0.3 
0089: 10@ = " + _10500 + @" // (float) 
005D: 10@ += " + tempvar_Float_1 + @" // (float) 
0089: 11@ = " + _10501 + @" // (float) 
005D: 11@ += " + tempvar_Float_2 + @" // (float) 

:CRANE2_1846
" + tempvar_Float_3 + @" = 0.0 
0088: " + tempvar_Float_2 + @" = 11@ // (float) 
0086: " + tempvar_Float_1 + @" = " + tempvar_Float_2 + @" // (float) 
" + tempvar_Float_1 + @" -= 1671.5 
0087: 8@ = 10@ // (float) 
0087: 9@ = 8@ // (float) 
9@ += 1671.5 
005F: " + tempvar_Float_1 + @" += 8@ // (float) 
005F: " + tempvar_Float_2 + @" += 9@ // (float) 
" + tempvar_Float_1 + @" /= 2.0 
" + tempvar_Float_2 + @" /= 2.0 
if 
  -1648.057 > " + tempvar_Float_1 + @" 
jf @CRANE2_2116 
0509: 4@ = distance_between_XY -1648.057 23.852 and_XY 10@ 11@ 
if 
0027:   4@ > " + _10509 + @" // (float) 
jf @CRANE2_2109 
0087: 12@ = 10@ // (float) 
12@ += 1648.057 
0087: 13@ = 11@ // (float) 
13@ -= 23.852 
0073: 12@ /= 4@ // (float) 
0073: 13@ /= 4@ // (float) 
006F: 12@ *= " + _10509 + @" // (float) 
006F: 13@ *= " + _10509 + @" // (float) 
10@ = -1648.057 
005B: 10@ += 12@ // (float) 
11@ = 23.852 
005B: 11@ += 13@ // (float) 

:CRANE2_2109
jump @CRANE2_2420 

:CRANE2_2116
if 
  " + tempvar_Float_1 + @" > -1532.742 
jf @CRANE2_2288 
0509: 4@ = distance_between_XY -1532.742 138.719 and_XY 10@ 11@ 
if 
0027:   4@ > " + _10509 + @" // (float) 
jf @CRANE2_2281 
0087: 12@ = 10@ // (float) 
12@ += 1532.742 
0087: 13@ = 11@ // (float) 
13@ -= 138.719 
0073: 12@ /= 4@ // (float) 
0073: 13@ /= 4@ // (float) 
006F: 12@ *= " + _10509 + @" // (float) 
006F: 13@ *= " + _10509 + @" // (float) 
10@ = -1532.742 
005B: 10@ += 12@ // (float) 
11@ = 138.719 
005B: 11@ += 13@ // (float) 

:CRANE2_2281
jump @CRANE2_2420 

:CRANE2_2288
0509: 4@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 10@ 11@ 
if 
0027:   4@ > " + _10509 + @" // (float) 
jf @CRANE2_2420 
0087: 12@ = 10@ // (float) 
0065: 12@ -= " + tempvar_Float_1 + @" // (float) 
0087: 13@ = 11@ // (float) 
0065: 13@ -= " + tempvar_Float_2 + @" // (float) 
0073: 12@ /= 4@ // (float) 
0073: 13@ /= 4@ // (float) 
006F: 12@ *= " + _10509 + @" // (float) 
006F: 13@ *= " + _10509 + @" // (float) 
0089: 10@ = " + tempvar_Float_1 + @" // (float) 
005B: 10@ += 12@ // (float) 
0089: 11@ = " + tempvar_Float_2 + @" // (float) 
005B: 11@ += 13@ // (float) 

:CRANE2_2420
0509: 18@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 10@ 11@ 
0089: 4@ = " + _10509 + @" // (float) 
006F: 4@ *= " + _10509 + @" // (float) 
0087: 5@ = 18@ // (float) 
006B: 5@ *= 18@ // (float) 
0087: 19@ = 4@ // (float) 
0063: 19@ -= 5@ // (float) 
0087: 20@ = 19@ // (float) 
20@ /= 2.0 
01FB: 20@ = square_root 20@ 
0089: 21@ = " + tempvar_Float_1 + @" // (float) 
0063: 21@ -= 20@ // (float) 
0089: 22@ = " + tempvar_Float_2 + @" // (float) 
0063: 22@ -= 20@ // (float) 
0089: 23@ = " + tempvar_Float_1 + @" // (float) 
005B: 23@ += 20@ // (float) 
0089: 24@ = " + tempvar_Float_2 + @" // (float) 
005B: 24@ += 20@ // (float) 
26@ = 0 
if and
  -1532.742 > 21@ 
  21@ > -1648.057 
jf @CRANE2_2620 
26@ += 1 

:CRANE2_2620
if and
  -1532.742 > 23@ 
  23@ > -1648.057 
jf @CRANE2_2658 
26@ += 2 

:CRANE2_2658
if 
   not 26@ == 0 
jf @CRANE2_2881 
if 
  26@ == 1 
jf @CRANE2_2694 

:CRANE2_2694
if 
  26@ == 2 
jf @CRANE2_2728 
0087: 21@ = 23@ // (float) 
0087: 22@ = 24@ // (float) 

:CRANE2_2728
if 
  26@ == 3 
jf @CRANE2_2831 
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_2831 
0509: 4@ = distance_between_XY " + _2733 + @" " + _2734 + @" and_XY 21@ 22@ 
0509: 5@ = distance_between_XY " + _2733 + @" " + _2734 + @" and_XY 23@ 24@ 
if 
0025:   4@ > 5@ // (float) 
jf @CRANE2_2831 
0087: 21@ = 23@ // (float) 
0087: 22@ = 24@ // (float) 

:CRANE2_2831
0087: 12@ = 10@ // (float) 
0063: 12@ -= 21@ // (float) 
0087: 13@ = 11@ // (float) 
0063: 13@ -= 22@ // (float) 
0604: get_Z_angle_for_point 12@ 13@ store_to 25@ 
jump @CRANE2_2940 

:CRANE2_2881
0089: 21@ = " + _2733 + @" // (float) 
0089: 22@ = " + _2734 + @" // (float) 
0087: 12@ = 10@ // (float) 
0065: 12@ -= " + _2733 + @" // (float) 
0087: 13@ = 11@ // (float) 
0065: 13@ -= " + _2734 + @" // (float) 
0604: get_Z_angle_for_point 12@ 13@ store_to 25@ 

:CRANE2_2940
jump @CRANE2_3246 

:CRANE2_2947
if 
   not " + _10515 + @" == 0 
jf @CRANE2_2996 
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_2989 
097B: play_audio_at_object " + _2728 + @" event 1021 

:CRANE2_2989
" + _10515 + @" = 0 

:CRANE2_2996
if 
   not 28@ == 0 
jf @CRANE2_3246 
if 
  28@ == 1 
jf @CRANE2_3107 
0086: " + tempvar_Float_1 + @" = " + _10503 + @" // (float) 
0086: " + tempvar_Float_2 + @" = " + _10504 + @" // (float) 
0089: 12@ = " + tempvar_Float_1 + @" // (float) 
0065: 12@ -= " + _2733 + @" // (float) 
0089: 13@ = " + tempvar_Float_2 + @" // (float) 
0065: 13@ -= " + _2734 + @" // (float) 
0604: get_Z_angle_for_point 12@ 13@ store_to 25@ 
0089: 12@ = " + _10513 + @" // (float) 
0089: 13@ = " + _10514 + @" // (float) 

:CRANE2_3107
if 
  " + _10510 + @" > 0.0 
jf @CRANE2_3246 
" + _10511 + @" = -0.007 
007A: " + _10510 + @" += frame_delta_time * " + _10511 + @" // (float) 
if 
  0.0 > " + _10510 + @" 
jf @CRANE2_3191 
" + _10510 + @" = 0.0 
28@ = 0 
jump @CRANE2_3198 

:CRANE2_3191
28@ = 2 

:CRANE2_3198
0086: " + tempvar_Float_1 + @" = " + _10510 + @" // (float) 
006D: " + tempvar_Float_1 + @" *= 12@ // (float) 
0086: " + tempvar_Float_2 + @" = " + _10510 + @" // (float) 
006D: " + tempvar_Float_2 + @" *= 13@ // (float) 
0059: " + _2733 + @" += " + tempvar_Float_1 + @" // (float) 
0059: " + _2734 + @" += " + tempvar_Float_2 + @" // (float) 

:CRANE2_3246
if 
  28@ == 1 
jf @CRANE2_3530 
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_3530 
0509: 4@ = distance_between_XY " + _2733 + @" " + _2734 + @" and_XY 21@ 22@ 
if 
  4@ > 0.01 
jf @CRANE2_3366 
0088: " + _10513 + @" = 21@ // (float) 
0061: " + _10513 + @" -= " + _2733 + @" // (float) 
0088: " + _10514 + @" = 22@ // (float) 
0061: " + _10514 + @" -= " + _2734 + @" // (float) 
0075: " + _10513 + @" /= 4@ // (float) 
0075: " + _10514 + @" /= 4@ // (float) 

:CRANE2_3366
if 
  4@ > 0.01 
jf @CRANE2_3530 
" + _10511 + @" = 0.003 
007A: " + _10510 + @" += frame_delta_time * " + _10511 + @" // (float) 
if 
0024:   " + _10510 + @" > " + _10512 + @" // (float) 
jf @CRANE2_3432 
0086: " + _10510 + @" = " + _10512 + @" // (float) 

:CRANE2_3432
0089: 12@ = " + _10513 + @" // (float) 
0089: 13@ = " + _10514 + @" // (float) 
if 
0027:   4@ > " + _10510 + @" // (float) 
jf @CRANE2_3490 
006F: 12@ *= " + _10510 + @" // (float) 
006F: 13@ *= " + _10510 + @" // (float) 
jump @CRANE2_3514 

:CRANE2_3490
006B: 12@ *= 4@ // (float) 
006B: 13@ *= 4@ // (float) 
0088: " + _10510 + @" = 4@ // (float) 

:CRANE2_3514
005F: " + _2733 + @" += 12@ // (float) 
005F: " + _2734 + @" += 13@ // (float) 

:CRANE2_3530
if 
  28@ == 1 
jf @CRANE2_3888 
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_3888 
if 
  25@ > 180.0 
jf @CRANE2_3595 
25@ += -360.0 

:CRANE2_3595
if 
  -180.0 > 25@ 
jf @CRANE2_3626 
25@ += 360.0 

:CRANE2_3626
0086: " + tempvar_Angle + @" = " + _2737 + @" // (float) 
if 
  " + tempvar_Angle + @" > 180.0 
jf @CRANE2_3665 
" + tempvar_Angle + @" += -360.0 

:CRANE2_3665
if 
  -180.0 > " + tempvar_Angle + @" 
jf @CRANE2_3696 
" + tempvar_Angle + @" += 360.0 

:CRANE2_3696
0087: 4@ = 25@ // (float) 
0065: 4@ -= " + tempvar_Angle + @" // (float) 
if 
  4@ > 180.0 
jf @CRANE2_3743 
4@ += -360.0 

:CRANE2_3743
if 
  -180.0 > 4@ 
jf @CRANE2_3774 
4@ += 360.0 

:CRANE2_3774
if 
  4@ >= 0.0 
jf @CRANE2_3833 
if 
  4@ > 0.2 
jf @CRANE2_3826 
4@ = 0.2 

:CRANE2_3826
jump @CRANE2_3864 

:CRANE2_3833
if 
  -0.2 > 4@ 
jf @CRANE2_3864 
4@ = -0.2 

:CRANE2_3864
007D: " + tempvar_Angle + @" += frame_delta_time * 4@ // (float) 
0086: " + _2736 + @" = " + tempvar_Angle + @" // (float) 
0086: " + _2737 + @" = " + tempvar_Angle + @" // (float) 

:CRANE2_3888
if 
  " + _1913 + @" == 0 
jf @CRANE2_3930 
if 
00E1:   player 0 pressed_key 15 
jf @CRANE2_3930 
0@ += 1 

:CRANE2_3930
if and
  -1532.742 > " + _2733 + @" 
  " + _2733 + @" > -1648.057 
jf @CRANE2_3998 
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_3991 
0815: put_object " + _2727 + @" at " + _2733 + @" " + _2734 + @" " + _2735 + @" and_keep_rotation 

:CRANE2_3991
jump @CRANE2_4028 

:CRANE2_3998
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_4028 
Object.StorePos(" + _2727 + @", " + _2733 + @", " + _2734 + @", " + _2735 + @")

:CRANE2_4028
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_4104 
if 
03CA:   object " + _2730 + @" exists 
jf @CRANE2_4104 
Object.StorePos(" + _2727 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2727 + @")
Object.PutAt(" + _2730 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2730 + @") = " + tempvar_Angle + @"

:CRANE2_4104
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_4255 
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_4195 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2727 + @" with_offset 0.0 0.0 0.0 
Object.Angle(" + _2728 + @") = " + _2736 + @"
0815: put_object " + _2728 + @" at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_keep_rotation 
Actor.Angle(" + PlayerActor + @") = " + _2736 + @"

:CRANE2_4195
if 
03CA:   object " + _2731 + @" exists 
jf @CRANE2_4255 
Object.StorePos(" + _2728 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + _2728 + @")
Object.PutAt(" + _2731 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2731 + @") = " + tempvar_Angle + @"

:CRANE2_4255
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_4430 
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_4354 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2728 + @" with_offset 0.0 -2.185 8.51 
" + _2737 + @" = Object.Angle(" + _2728 + @")
0815: put_object " + Crane_Magnet + @" at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_keep_rotation 
0453: set_object " + Crane_Magnet + @" XYZ_rotation " + _2738 + @" 0.0 " + _2737 + @" 

:CRANE2_4354
if 
03CA:   object " + _2732 + @" exists 
jf @CRANE2_4430 
Object.StorePos(" + Crane_Magnet + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(" + Crane_Magnet + @")
Object.PutAt(" + _2732 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _2732 + @") = " + tempvar_Angle + @"
0453: set_object " + _2732 + @" XYZ_rotation " + _2738 + @" 0.0 " + _2737 + @" 

:CRANE2_4430
if or
  0@ == 4 
  " + _1915 + @" == 1 
jf @CRANE2_4652 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE2_4652 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_4509 
097B: play_audio_at_object " + _2728 + @" event 1022 

:CRANE2_4509
03E6: remove_text_box 
079F: unknown_set_game_controller_to_steer_no_crane_objects 
09BD: allow_other_threads_to_display_text_boxes 0 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + _2727 + @" with_offset 2.0 -4.0 0.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0465: remove_actor " + PlayerActor + @" from_turret_mode 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
0337: set_actor " + PlayerActor + @" visibility 1 
0619: enable_actor " + PlayerActor + @" collision_detection 1 
Actor.SetImmunities(" + PlayerActor + @", 0, 0, 0, 0, 0)
Player.CanMove(" + PlayerChar + @") = True
0792: disembark_instantly_actor " + PlayerActor + @" 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
" + flag_Player_In_Crane + @" = 0 
" + _1915 + @" = 0 
0@ = 0 

:CRANE2_4652
jump @CRANE2_4684 

:CRANE2_4659
if 
   not 0@ == 0 
jf @CRANE2_4684 
0@ = 0 

:CRANE2_4684
jump @CRANE2_4693 

:CRANE2_4691
end_thread 

:CRANE2_4693
jump @CRANE2_4709 

:CRANE2_4700
0@ = 0 
end_thread 

:CRANE2_4709
jump @CRANE2_150 

:CRANE2_4716
if 
00E1:   player 0 pressed_key 13 
jf @CRANE2_4805 
if 
  29@ == 0 
jf @CRANE2_4798 
27@ += 1 
if 
  27@ > 2 
jf @CRANE2_4783 
27@ = 0 

:CRANE2_4783
008A: " + _1919 + @" = 27@ // (int) 
29@ += 1 

:CRANE2_4798
jump @CRANE2_4830 

:CRANE2_4805
if 
   not 29@ == 0 
jf @CRANE2_4830 
29@ = 0 

:CRANE2_4830
if 
  " + flag_Player_In_Crane + @" == 2 
jf @CRANE2_4881 
if 
  " + _1911 + @" == 1 
jf @CRANE2_4881 
008B: 27@ = " + _1919 + @" // (int) 
" + _1911 + @" = 0 

:CRANE2_4881
if 
803C:   not  " + _1919 + @" == 27@ // (int) 
jf @CRANE2_4908 
008A: " + _1919 + @" = 27@ // (int) 

:CRANE2_4908
if 
  27@ == 0 
jf @CRANE2_4978 
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_4971 
0400: store_coords_to " + _10497 + @" " + _10498 + @" " + _10499 + @" from_object " + _2728 + @" with_offset 6.1 15.0 5.1 

:CRANE2_4971
jump @CRANE2_5093 

:CRANE2_4978
if 
  27@ == 1 
jf @CRANE2_5048 
if 
03CA:   object " + _2727 + @" exists 
jf @CRANE2_5041 
0400: store_coords_to " + _10497 + @" " + _10498 + @" " + _10499 + @" from_object " + _2727 + @" with_offset -4.0 17.3 35.0 

:CRANE2_5041
jump @CRANE2_5093 

:CRANE2_5048
if 
03CA:   object " + _2728 + @" exists 
jf @CRANE2_5093 
0400: store_coords_to " + _10497 + @" " + _10498 + @" " + _10499 + @" from_object " + _2728 + @" with_offset 3.0 45.0 0.0 

:CRANE2_5093
if 
03CA:   object " + Crane_Magnet + @" exists 
jf @CRANE2_5730 
0400: store_coords_to " + _10500 + @" " + _10501 + @" " + _10502 + @" from_object " + Crane_Magnet + @" with_offset 0.0 " + _10509 + @" -3.0 
0796: get_crane_magnet " + Crane_Magnet + @" magnet_lane_length_to 4@ // float 
4@ += -1.0 
4@ *= -1.0 
4@ *= 50.0 
0067: " + _10502 + @" -= 4@ // (float) 
0086: " + tempvar_Float_1 + @" = " + _10500 + @" // (float) 
0061: " + tempvar_Float_1 + @" -= " + _2733 + @" // (float) 
0086: " + tempvar_Float_2 + @" = " + _10501 + @" // (float) 
0061: " + tempvar_Float_2 + @" -= " + _2734 + @" // (float) 
0509: 4@ = distance_between_XY " + _10500 + @" " + _10501 + @" and_XY " + _2733 + @" " + _2734 + @" 
0075: " + tempvar_Float_1 + @" /= 4@ // (float) 
0075: " + tempvar_Float_2 + @" /= 4@ // (float) 
0069: " + tempvar_Float_1 + @" *= " + _10509 + @" // (float) 
0069: " + tempvar_Float_2 + @" *= " + _10509 + @" // (float) 
0086: " + _10500 + @" = " + _2733 + @" // (float) 
0059: " + _10500 + @" += " + tempvar_Float_1 + @" // (float) 
0086: " + _10501 + @" = " + _2734 + @" // (float) 
0059: " + _10501 + @" += " + tempvar_Float_2 + @" // (float) 
050A: 4@ = distance_between_XYZ " + _10500 + @" " + _10501 + @" " + _10502 + @" and_XYZ " + _10503 + @" " + _10504 + @" " + _10505 + @" 
if 
  4@ > 0.3 
jf @CRANE2_5441 
0086: " + _10506 + @" = " + _10500 + @" // (float) 
0061: " + _10506 + @" -= " + _10503 + @" // (float) 
0086: " + _10507 + @" = " + _10501 + @" // (float) 
0061: " + _10507 + @" -= " + _10504 + @" // (float) 
0086: " + _10508 + @" = " + _10502 + @" // (float) 
0061: " + _10508 + @" -= " + _10505 + @" // (float) 
" + _10506 + @" *= 0.05 
" + _10507 + @" *= 0.05 
" + _10508 + @" *= 0.05 
0059: " + _10503 + @" += " + _10506 + @" // (float) 
0059: " + _10504 + @" += " + _10507 + @" // (float) 
0059: " + _10505 + @" += " + _10508 + @" // (float) 

:CRANE2_5441
068D: get_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
  " + _1912 + @" == 0 
jf @CRANE2_5596 
0089: 12@ = " + _10497 + @" // (float) 
0065: 12@ -= " + tempvar_Float_1 + @" // (float) 
0089: 13@ = " + _10498 + @" // (float) 
0065: 13@ -= " + tempvar_Float_2 + @" // (float) 
0089: 14@ = " + _10499 + @" // (float) 
0065: 14@ -= " + tempvar_Float_3 + @" // (float) 
12@ *= 0.2 
13@ *= 0.2 
14@ *= 0.2 
0086: " + _10497 + @" = " + tempvar_Float_1 + @" // (float) 
005F: " + _10497 + @" += 12@ // (float) 
0086: " + _10498 + @" = " + tempvar_Float_2 + @" // (float) 
005F: " + _10498 + @" += 13@ // (float) 
0086: " + _10499 + @" = " + tempvar_Float_3 + @" // (float) 
005F: " + _10499 + @" += 14@ // (float) 

:CRANE2_5596
Camera.SetPosition(" + _10497 + @", " + _10498 + @", " + _10499 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _10503 + @", " + _10504 + @", " + _10505 + @", 2)
0086: " + _10506 + @" = " + _10503 + @" // (float) 
0061: " + _10506 + @" -= " + _10497 + @" // (float) 
0086: " + _10507 + @" = " + _10504 + @" // (float) 
0061: " + _10507 + @" -= " + _10498 + @" // (float) 
0086: " + _10508 + @" = " + _10505 + @" // (float) 
0061: " + _10508 + @" -= " + _10499 + @" // (float) 
050A: 4@ = distance_between_XYZ " + _10497 + @" " + _10498 + @" " + _10499 + @" and_XYZ " + _10503 + @" " + _10504 + @" " + _10505 + @" 
0075: " + _10506 + @" /= 4@ // (float) 
0075: " + _10507 + @" /= 4@ // (float) 
0075: " + _10508 + @" /= 4@ // (float) 

:CRANE2_5730
return 
end_thread" );
            }

        }

        private sealed class CRANE3 : External {

            public override void START( LabelJump label ) {
                AppendLine( @"3@ = 0 
if 
  3@ == 1 
jf @CRANE3_124 
0@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
1@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
2@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)
3@ = Object.Init(#WOODENBOX, 0.0, 0.0, 0.0)

:CRANE3_124
" + _10492 + @" = 0 

:CRANE3_131
wait 0 
if 
03CA:   object 0@ exists 
jf @CRANE3_1554 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE3_1547 
if 
  " + _10493 + @" == 0 
jf @CRANE3_1547 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 100.0 100.0 sphere 0 
jf @CRANE3_1538 
if 
  3@ == 0 
jf @CRANE3_270 
0400: store_coords_to 5@ 6@ 7@ from_object 0@ with_offset 3.0899 2.9792 0.0081 
3@ += 1 

:CRANE3_270
if 
  3@ == 1 
jf @CRANE3_440 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 5@ 6@ 7@ radius 1.2 1.2 1.5 on_foot 
jf @CRANE3_413 
if 
044B:   actor " + PlayerActor + @" on_foot 
jf @CRANE3_406 
if 
  " + _10492 + @" == 0 
jf @CRANE3_382 
0512: show_permanent_text_box 'CR_2'  
" + _10492 + @" = 1 

:CRANE3_382
if 
00E1:   player 0 pressed_key 15 
jf @CRANE3_406 
3@ += 1 

:CRANE3_406
jump @CRANE3_440 

:CRANE3_413
if 
   not " + _10492 + @" == 0 
jf @CRANE3_440 
03E6: remove_text_box 
" + _10492 + @" = 0 

:CRANE3_440
if 
  3@ == 2 
jf @CRANE3_719 
if 
03CA:   object 0@ exists 
jf @CRANE3_482 
097B: play_audio_at_object 0@ event 1019 

:CRANE3_482
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
fade 0 500 

:CRANE3_500
if 
fading 
jf @CRANE3_524 
wait 0 
jump @CRANE3_500 

:CRANE3_524
07F9: set_game_controller_to_steer_object_QUARRY_CRANEARM 
0A44: override_text_block 1 
4@ = Object.Angle(1@)
if 
03CA:   object 0@ exists 
jf @CRANE3_570 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE3_570 

:CRANE3_570
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE3_656 
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
Actor.PutAt(" + PlayerActor + @", 713.5652, 906.2935, -18.0674)
0337: set_actor " + PlayerActor + @" visibility 0 
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Actor.SetImmunities(" + PlayerActor + @", 1, 1, 1, 1, 1)
15@ = 0 

:CRANE3_656
0512: show_permanent_text_box 'QUAR_1'  
gosub @CRANE3_1570 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
fade 1 500 

:CRANE3_688
if 
fading 
jf @CRANE3_712 
wait 0 
jump @CRANE3_688 

:CRANE3_712
3@ += 1 

:CRANE3_719
if 
  3@ == 3 
jf @CRANE3_1383 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE3_1383 
gosub @CRANE3_1570 
if 
00E1:   player 0 pressed_key 0 
jf @CRANE3_875 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 8@ = integer " + Move_Axis_X + @" to_float 
8@ /= 500.0 
0081: 4@ -= frame_delta_time * 8@ 
if 
   not 15@ == 1 
jf @CRANE3_868 
if 
03CA:   object 0@ exists 
jf @CRANE3_868 
097B: play_audio_at_object 0@ event 1020 
15@ = 1 

:CRANE3_868
jump @CRANE3_924 

:CRANE3_875
if 
   not 15@ == 0 
jf @CRANE3_924 
if 
03CA:   object 0@ exists 
jf @CRANE3_924 
097B: play_audio_at_object 0@ event 1021 
15@ = 0 

:CRANE3_924
if 
00E1:   player 0 pressed_key 1 
jf @CRANE3_1187 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 8@ = integer " + Move_Axis_Y + @" to_float 
8@ /= 1000.0 
8@ *= 1.5 
0083: " + _2739 + @" -= frame_delta_time * 8@ 

:CRANE3_993
if 
  0.0 > " + _2739 + @" 
jf @CRANE3_1031 
" + _2739 + @" += 360.0 
jump @CRANE3_993 

:CRANE3_1031
if 
  " + _2739 + @" > 360.0 
jf @CRANE3_1069 
" + _2739 + @" += -360.0 
jump @CRANE3_1031 

:CRANE3_1069
if 
  " + _2739 + @" > 70.0 
jf @CRANE3_1100 
" + _2739 + @" = 70.0 

:CRANE3_1100
if 
  10.0 > " + _2739 + @" 
jf @CRANE3_1131 
" + _2739 + @" = 10.0 

:CRANE3_1131
if 
   not 16@ == 1 
jf @CRANE3_1180 
if 
03CA:   object 0@ exists 
jf @CRANE3_1180 
097B: play_audio_at_object 2@ event 1020 
16@ = 1 

:CRANE3_1180
jump @CRANE3_1236 

:CRANE3_1187
if 
   not 16@ == 0 
jf @CRANE3_1236 
if 
03CA:   object 0@ exists 
jf @CRANE3_1236 
097B: play_audio_at_object 2@ event 1021 
16@ = 0 

:CRANE3_1236
if 
03CA:   object 1@ exists 
jf @CRANE3_1268 
Object.Angle(1@) = 4@
Actor.Angle(" + PlayerActor + @") = 4@

:CRANE3_1268
if 
03CA:   object 2@ exists 
jf @CRANE3_1359 
if 
03CA:   object 1@ exists 
jf @CRANE3_1359 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 1@ with_offset 0.0 0.0 1.0206 
0815: put_object 2@ at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_keep_rotation 
0453: set_object 2@ XYZ_rotation 0.0 " + _2739 + @" 4@ 

:CRANE3_1359
if 
00E1:   player 0 pressed_key 15 
jf @CRANE3_1383 
3@ += 1 

:CRANE3_1383
if 
  3@ == 4 
jf @CRANE3_1531 
if 
   Player.Defined(" + PlayerChar + @")
jf @CRANE3_1531 
03E6: remove_text_box 
if 
03CA:   object 0@ exists 
jf @CRANE3_1443 
097B: play_audio_at_object 0@ event 1022 

:CRANE3_1443
079F: unknown_set_game_controller_to_steer_no_crane_objects 
09BD: allow_other_threads_to_display_text_boxes 0 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
0337: set_actor " + PlayerActor + @" visibility 1 
0619: enable_actor " + PlayerActor + @" collision_detection 1 
Actor.SetImmunities(" + PlayerActor + @", 0, 0, 0, 0, 0)
Player.CanMove(" + PlayerChar + @") = True
Actor.PutAt(" + PlayerActor + @", 706.2595, 918.6275, -19.6407)
Actor.Angle(" + PlayerActor + @") = 127.184
Camera.Restore_WithJumpCut
3@ = 0 

:CRANE3_1531
jump @CRANE3_1547 

:CRANE3_1538
3@ = 0 
end_thread 

:CRANE3_1547
jump @CRANE3_1563 

:CRANE3_1554
3@ = 0 
end_thread 

:CRANE3_1563
jump @CRANE3_131 

:CRANE3_1570
if 
03CA:   object 1@ exists 
jf @CRANE3_1615 
0400: store_coords_to 9@ 10@ 11@ from_object 1@ with_offset -9.0 -6.8 6.0 

:CRANE3_1615
if 
03CA:   object 2@ exists 
jf @CRANE3_1730 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 59.0 
0796: get_crane_magnet 2@ magnet_lane_length_to 8@ 
8@ += -1.0 
8@ *= -1.0 
8@ *= 72.0 
0067: " + tempvar_Float_3 + @" -= 8@ 
0089: 12@ = " + tempvar_Float_1 + @" 
0089: 13@ = " + tempvar_Float_2 + @" 
0089: 14@ = " + tempvar_Float_3 + @" 

:CRANE3_1730
Camera.SetPosition(9@, 10@, 11@, 0.0, 0.0, 0.0)
Camera.PointAt(12@, 13@, 14@, 2)
return 
end_thread" );
            }

        }

    }

}