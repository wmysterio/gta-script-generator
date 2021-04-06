using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalRases {

        private sealed class CPRACE : MissionCustom {

            Int tmp_Races_Current_Best_Time = global( Races_Current_Best_Time.startIndex ),
                tmp_X_Race_Tournament_Point = global( X_Race_Tournament_Point.startIndex ),
                tmp_Y_Race_Tournament_Point = global( Y_Race_Tournament_Point.startIndex ),
                tmp_Z_Race_Tournament_Point = global( Z_Race_Tournament_Point.startIndex ),
                tmp_Races_New_Best_Time = global( Races_New_Best_Time.startIndex ),
                tmp_Races_Best_Result = global( Races_Best_Result.startIndex ),
                tmp_Races_Won = global( Races_Won.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @CPRACE_112 
if 
wasted_or_busted 
else_jump @CPRACE_43 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @CPRACE_103 

:CPRACE_43
if or
  53@ == 0 
  53@ == 3 
else_jump @CPRACE_103 
fade 0 2000 
set_wb_check_to 0 

:CPRACE_79
if 
fading 
else_jump @CPRACE_103 
wait 0 
jump @CPRACE_79 

:CPRACE_103
gosub @CPRACE_51219 
end_thread 

:CPRACE_112
" + OnMission + @" = 1 
" + CARMOD_Disabled_Flag + @" = 1 
wait 0 
08E7: disable_entrance_markers 1 
054C: use_GXT_table 'RACETOR' 
if 
  " + Custom_Tournament_Flag + @" == 1 
else_jump @CPRACE_372 
04AF: 49@ = 1 
53@ = 0 
if 
  " + Current_Tournament + @" == 0 
else_jump @CPRACE_220 
50@ = 0 
51@ = 8 

:CPRACE_220
if 
  " + Current_Tournament + @" == 1 
else_jump @CPRACE_252 
50@ = 9 
51@ = 14 

:CPRACE_252
if 
  " + Current_Tournament + @" == 2 
else_jump @CPRACE_284 
50@ = 15 
51@ = 18 

:CPRACE_284
if 
  " + Current_Tournament + @" == 3 
else_jump @CPRACE_316 
50@ = 19 
51@ = 24 

:CPRACE_316
if or
001F:   50@ > " + Race_Index + @" 
001E:   " + Race_Index + @" > 51@ 
else_jump @CPRACE_351 
008A: " + Race_Index + @" = 50@ 

:CPRACE_351
52@ = 0 
gosub @CPRACE_46974 
jump @CPRACE_425 

:CPRACE_372
04AF: 49@ = 2 
if or
  " + Race_Index + @" == 25 
  " + Race_Index + @" == 26 
else_jump @CPRACE_418 
53@ = 3 
jump @CPRACE_425 

:CPRACE_418
53@ = 2 

:CPRACE_425
if 
04A4:   49@ == 10 
else_jump @CPRACE_1239 
018A: 54@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06D5: 449@ = create_racing_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" type 205@ radius 6.0 

:CPRACE_488
363@(253@,16f) += 3.0 
02CE: 363@(253@,16f) = ground_z_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) 
if 
  0.0 > 363@(253@,16f) 
else_jump @CPRACE_591 
if 
081E:   model 716@(253@,16i) boat 
else_jump @CPRACE_591 
363@(253@,16f) = 0.0 

:CPRACE_591
379@(253@,16i) = Car.Create(716@(253@,16i), 331@(253@,16f), 347@(253@,16f), 363@(253@,16f))
Car.Angle(379@(253@,16i)) = " + tempvar_Angle + @"
0840: link_car 379@(253@,16i) to_interior 221@ 
Car.DoorStatus(379@(253@,16i)) = 3
if 
  " + Race_Index + @" == 25 
else_jump @CPRACE_693 
Car.Health(379@(253@,16i)) = 2200

:CPRACE_693
if 
  " + Race_Index + @" == 26 
else_jump @CPRACE_742 
Car.Health(379@(253@,16i)) = 10000
Car.SetImmunities(379@(253@,16i), 0, 0, 0, 1, 0)

:CPRACE_742
if 
  221@ == 0 
else_jump @CPRACE_933 
Car.SetImmunities(379@(253@,16i), 0, 1, 0, 0, 0)
03AB: set_car 379@(253@,16i) strong 1 
Car.ImmuneToNonPlayer(379@(253@,16i)) = True
if 
04A4:   49@ == 6 
else_jump @CPRACE_915 

:CPRACE_819
if 
04F1:   is_car_waiting_for_world_collision 379@(253@,16i) 
else_jump @CPRACE_915 
wait 0 
if 
   Car.Wrecked(379@(253@,16i))
else_jump @CPRACE_908 
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_906 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_906 
" + _1846 + @" = 1 

:CPRACE_906
return 

:CPRACE_908
jump @CPRACE_819 

:CPRACE_915
0587: enable_car 379@(253@,16i) validate_position 0 
jump @CPRACE_944 

:CPRACE_933
0587: enable_car 379@(253@,16i) validate_position 1 

:CPRACE_944
if 
   not 209@ == -1 
else_jump @CPRACE_985 
0229: set_car 379@(253@,16i) primary_color_to 209@(253@,6i) secondary_color_to 215@(253@,6i) 

:CPRACE_985
if 
081E:   model 716@(253@,16i) boat 
else_jump @CPRACE_1037 
04E0: car 379@(253@,16i) abandon_path_radius 40 
02DB: set_boat 379@(253@,16i) speed_to 50.0 
jump @CPRACE_1237 

:CPRACE_1037
if 
0820:   model 716@(253@,16i) heli 
else_jump @CPRACE_1089 
Car.LockInCurrentPosition(379@(253@,16i)) = True
Car.SetSpeedInstantly(379@(253@,16i), 10.0)
jump @CPRACE_1237 

:CPRACE_1089
if 
081F:   model 716@(253@,16i) plane 
else_jump @CPRACE_1141 
Car.LockInCurrentPosition(379@(253@,16i)) = True
Car.SetSpeedInstantly(379@(253@,16i), 10.0)
jump @CPRACE_1237 

:CPRACE_1141
039C: set_car 379@(253@,16i) watertight 1 
053F: set_car 379@(253@,16i) tires_vulnerability 0 
if 
  221@ == 0 
else_jump @CPRACE_1192 
03ED: set_car 379@(253@,16i) disable_flipped_explosion_when_empty 1 

:CPRACE_1192
04E0: car 379@(253@,16i) abandon_path_radius 5 
00AE: set_car 379@(253@,16i) traffic_behaviour_to 2 
Car.SetMaxSpeed(379@(253@,16i), 50.0)
Car.SetToNormalDriver(379@(253@,16i))

:CPRACE_1237
return 

:CPRACE_1239
" + _6903 + @" = 70.3919 
" + _6917 + @" = 154.6278 
" + _6931 + @" = 0.6617 
" + _6945 + @" = 2.5845 
" + _6918 + @" = 203.8119 
" + _6932 + @" = 0.7208 
" + _6946 + @" = 2.5114 
" + _6919 + @" = 228.9919 
" + _6933 + @" = 0.7377 
" + _6947 + @" = 2.2364 
" + _6920 + @" = 279.6367 
" + _6922 + @" = 333.4643 
" + _6923 + @" = 358.6443 
" + _6924 + @" = 25.18 
55@ = 2357.239 
56@ = 1321.193 
57@ = 3300.968 
58@ = 3646.799 
59@ = 3880.677 
60@ = 4216.273 
61@ = 8410.458 
62@ = 4817.636 
63@ = 4817.636 
64@ = 3203.229 
65@ = 3265.028 
66@ = 1901.285 
67@ = 2644.297 
68@ = 8372.679 
69@ = 10760.5 
70@ = 7806.103 
71@ = 4307.65 
72@ = 4696.661 
73@ = 5960.28 
74@ = 6826.647 
75@ = 12299.14 
76@ = 17384.62 
77@ = 4922.472 
78@ = 4398.5 
79@ = 4970.742 
80@ = 0.0 
81@ = 0.0 
82@ = 0.0 
83@ = 0.0 
84@ = 0.0 
05AA: 85@s = 'RACE00' 
05AA: 87@s = 'RACE01' 
05AA: 89@s = 'RACE02' 
05AA: 91@s = 'RACE03' 
05AA: 93@s = 'RACE04' 
05AA: 95@s = 'RACE05' 
05AA: 97@s = 'RACE06' 
05AA: 99@s = 'RACE07' 
05AA: 101@s = 'RACE08' 
05AA: 103@s = 'RACE09' 
05AA: 105@s = 'RACE10' 
05AA: 107@s = 'RACE11' 
05AA: 109@s = 'RACE12' 
05AA: 111@s = 'RACE13' 
05AA: 113@s = 'RACE14' 
05AA: 115@s = 'RACE15' 
05AA: 117@s = 'RACE16' 
05AA: 119@s = 'RACE17' 
05AA: 121@s = 'RACE18' 
05AA: 123@s = 'RACE19' 
05AA: 125@s = 'RACE20' 
05AA: 127@s = 'RACE21' 
05AA: 129@s = 'RACE22' 
05AA: 131@s = 'RACE23' 
05AA: 133@s = 'RACE24' 
04AF: 145@ = 259 
04AF: 146@ = 261 
04AF: 147@ = 263 
04AF: 148@ = 265 
04AF: 149@ = 267 
04AF: 150@ = 269 
04AF: 151@ = 271 
04AF: 152@ = 273 
04AF: 153@ = 275 
04AF: 154@ = 277 
04AF: 155@ = 279 
04AF: 156@ = 281 
04AF: 157@ = 283 
04AF: 158@ = 285 
04AF: 159@ = 287 
04AF: 160@ = 289 
04AF: 161@ = 291 
04AF: 162@ = 293 
04AF: 163@ = 295 
04AF: 164@ = 296 
04AF: 165@ = 297 
04AF: 166@ = 298 
04AF: 167@ = 299 
04AF: 168@ = 300 
04AF: 169@ = 301 
04AF: 170@ = 48 
04AF: 171@ = 220 
04AF: 175@ = 258 
04AF: 176@ = 260 
04AF: 177@ = 262 
04AF: 178@ = 264 
04AF: 179@ = 266 
04AF: 180@ = 268 
04AF: 181@ = 270 
04AF: 182@ = 272 
04AF: 183@ = 274 
04AF: 184@ = 276 
04AF: 185@ = 278 
04AF: 186@ = 280 
04AF: 187@ = 282 
04AF: 188@ = 284 
04AF: 189@ = 286 
04AF: 190@ = 288 
04AF: 191@ = 290 
04AF: 192@ = 292 
04AF: 193@ = 294 
04AF: 200@ = 172 
04AF: 201@ = 221 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
09FF: set_restart_closest_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
04AF: 205@ = 0 
03F0: enable_text_draw 1 
0912: set_text_priority 1 leftmargin 355 maxwidth 370 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
0581: enable_radar 0 
206@ = 0 
207@ = 0 
208@ = 25 
209@ = -1 
221@ = 0 
222@ = 0 
223@ = 0 
224@ = 1 
225@ = 0 
226@ = 0 
227@ = 0 
if 
0735:   is_keyboard_key_pressed 82 
else_jump @CPRACE_2627 
" + _164 + @" = 0 
" + CPRACE_Debug_Checkpoint_Index + @" = 0 
065D: NOP " + CPRACE_Debug_Checkpoint_Index + @" ""COORDS"" 
Player.CanMove(" + PlayerChar + @") = True
04AF: 49@ = 0 
228@ = 1 
jump @CPRACE_2634 

:CPRACE_2627
" + _164 + @" = -1 

:CPRACE_2634
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
  13 > 49@ 
else_jump @CPRACE_2668 
229@ = 0 

:CPRACE_2668
253@ = 0 
0871: init_jump_table 49@ total_jumps 15 default_jump 0 @CPRACE_20805 jumps 0 @CPRACE_2803 1 @CPRACE_5836 2 @CPRACE_7391 3 @CPRACE_7577 4 @CPRACE_7924 5 @CPRACE_8660 6 @CPRACE_8772 
0872: jump_table_jumps 7 @CPRACE_11220 8 @CPRACE_11297 9 @CPRACE_11382 10 @CPRACE_11467 11 @CPRACE_12351 12 @CPRACE_12351 13 @CPRACE_19581 14 @CPRACE_20088 -1 @CPRACE_20805 

:CPRACE_2803
if 
  " + _164 + @" > -1 
else_jump @CPRACE_4452 
if 
0735:   is_keyboard_key_pressed 82 
else_jump @CPRACE_4445 
if 
  228@ == 0 
else_jump @CPRACE_4438 
if 
  " + _164 + @" == 0 
else_jump @CPRACE_2909 
" + CPRACE_Debug_Checkpoint_Index + @" += 1 
00BC: show_text_highpriority GXT 'CHEATON' time 800 flag 1  
" + _164 + @" = 1 
jump @CPRACE_4431 

:CPRACE_2909
if 
0735:   is_keyboard_key_pressed 151 
else_jump @CPRACE_4401 
224@ = 1 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 76 
256@ = 6 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 77 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
03A9: save_newline_to_debug_file 
252@ = 0 

:CPRACE_3258
if 
001D:   256@ > 252@ 
else_jump @CPRACE_3558 
03A9: save_newline_to_debug_file 
05B6: 78 
03A7: save_int_to_debug_file 252@ 
05B6: 79 
252@ += 1 
jump @CPRACE_3258 

:CPRACE_3558
0085: 716@ = 230@ 
0085: 717@ = 230@ 
0085: 718@ = 230@ 
0085: 719@ = 230@ 
0085: 720@ = 230@ 
0085: 721@ = 230@ 
03A9: save_newline_to_debug_file 
252@ = 0 

:CPRACE_3615
if 
001D:   256@ > 252@ 
else_jump @CPRACE_3920 
03A9: save_newline_to_debug_file 
05B6: 80 
03A7: save_int_to_debug_file 252@ 
05B6: 81 
03A7: save_int_to_debug_file 230@ 
252@ += 1 
jump @CPRACE_3615 

:CPRACE_3920
0088: " + tempvar_Float_1 + @" = 454@ 
0088: " + tempvar_Float_2 + @" = 536@ 
0088: " + tempvar_Float_3 + @" = 618@ 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 82 
03A8: save_float_to_debug_file " + tempvar_Float_1 + @" 
03A9: save_newline_to_debug_file 
05B6: 83 
03A8: save_float_to_debug_file " + tempvar_Float_2 + @" 
03A9: save_newline_to_debug_file 
05B6: 84 
03A8: save_float_to_debug_file " + tempvar_Float_3 + @" 
00BC: show_text_highpriority GXT 'LABEL' time 1000 flag 1 
49@ = 3 
" + CPRACE_Debug_Checkpoint_Index + @" = 0 
" + _164 + @" = 0 
jump @CPRACE_4431 

:CPRACE_4401
" + CPRACE_Debug_Checkpoint_Index + @" = 0 
00BC: show_text_highpriority GXT 'CHEATOF' time 800 flag 1  
" + _164 + @" = 0 

:CPRACE_4431
228@ = 1 

:CPRACE_4438
jump @CPRACE_4452 

:CPRACE_4445
228@ = 0 

:CPRACE_4452
if 
  " + _164 + @" == 1 
else_jump @CPRACE_5829 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @CPRACE_5829 
if 
  " + CPRACE_Debug_Checkpoint_Index + @" == 0 
else_jump @CPRACE_4567 
if 
00E1:   player 0 pressed_key 17 
else_jump @CPRACE_4560 
if 
  235@ == 0 
else_jump @CPRACE_4553 
" + CPRACE_Debug_Checkpoint_Index + @" += 1 
235@ = 1 

:CPRACE_4553
jump @CPRACE_4567 

:CPRACE_4560
235@ = 0 

:CPRACE_4567
if 
  " + CPRACE_Debug_Checkpoint_Index + @" > 0 
else_jump @CPRACE_5829 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @CPRACE_5829 
443@ = Actor.CurrentCar(" + PlayerActor + @")
230@ = Car.Model(443@)
if or
081F:   model 230@ plane 
0820:   model 230@ heli 
else_jump @CPRACE_4656 
0454: store_debug_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
jump @CPRACE_4670 

:CPRACE_4656
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:CPRACE_4670
050A: " + Distance_Between_Points + @" = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ 231@ 232@ 233@ 
008E: 234@ = float " + Distance_Between_Points + @" to_integer 
gosub @CPRACE_47594 
060D: draw_text_shadow 2 rgba 0 0 0 255 
033F: set_text_draw_letter_size 0.8 2.0 
045A: draw_text_1number 30.0 145.0 GXT 'RACES00' number 234@  
if or
  " + Distance_Between_Points + @" > 200.0 
00E1:   player 0 pressed_key 17 
else_jump @CPRACE_5822 
if 
  235@ == 0 
else_jump @CPRACE_5815 
00BC: show_text_highpriority GXT 'TEXXYZ4' time 800 flag 1  
" + CPRACE_Debug_Checkpoint_Index + @" -= 1 
03A9: save_newline_to_debug_file 
05B6: 85 
03A7: save_int_to_debug_file " + CPRACE_Debug_Checkpoint_Index + @" 
05B6: 86 
03A8: save_float_to_debug_file " + tempvar_Float_1 + @" 
03A9: save_newline_to_debug_file 
05B6: 87 
03A7: save_int_to_debug_file " + CPRACE_Debug_Checkpoint_Index + @" 
05B6: 88 
03A8: save_float_to_debug_file " + tempvar_Float_2 + @" 
03A9: save_newline_to_debug_file 
05B6: 89 
03A7: save_int_to_debug_file " + CPRACE_Debug_Checkpoint_Index + @" 
05B6: 90 
if 
081E:   model 230@ boat 
else_jump @CPRACE_5659 
jump @CPRACE_5719 

:CPRACE_5659
if 
0820:   model 230@ heli 
else_jump @CPRACE_5682 
jump @CPRACE_5719 

:CPRACE_5682
if 
081F:   model 230@ plane 
else_jump @CPRACE_5705 
jump @CPRACE_5719 

:CPRACE_5705
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 

:CPRACE_5719
03A8: save_float_to_debug_file " + tempvar_Float_3 + @" 
03A9: save_newline_to_debug_file 
0089: 454@(" + CPRACE_Debug_Checkpoint_Index + @",82f) = " + tempvar_Float_1 + @" 
0089: 536@(" + CPRACE_Debug_Checkpoint_Index + @",82f) = " + tempvar_Float_2 + @" 
0089: 618@(" + CPRACE_Debug_Checkpoint_Index + @",82f) = " + tempvar_Float_3 + @" 
0089: 231@ = " + tempvar_Float_1 + @" 
0089: 232@ = " + tempvar_Float_2 + @" 
0089: 233@ = " + tempvar_Float_3 + @" 
" + CPRACE_Debug_Checkpoint_Index + @" += 1 
008B: 250@ = " + CPRACE_Debug_Checkpoint_Index + @" 
" + CPRACE_Debug_Checkpoint_Index + @" += 1 
235@ = 1 

:CPRACE_5815
jump @CPRACE_5829 

:CPRACE_5822
235@ = 0 

:CPRACE_5829
jump @CPRACE_20805 

:CPRACE_5836
0826: enable_hud 0 
0581: enable_radar 0 
09FB: " + Current_Language + @" = current_language 
if 
84A3:   not  " + Current_Language + @" == 0 
else_jump @CPRACE_5879 
0989: set_text_boxes_width 250 
jump @CPRACE_5884 

:CPRACE_5879
0989: set_text_boxes_width 200 

:CPRACE_5884
0512: show_permanent_text_box 'RACES33'  
0494: get_joystick 0 direction_offset_to 236@ 237@ 238@ 239@ 
if or
  -100 > 237@ 
  236@ > 100 
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
else_jump @CPRACE_6028 
if 
  240@ == 0 
else_jump @CPRACE_6021 
if 
001F:   51@ > " + Race_Index + @" 
else_jump @CPRACE_5999 
" + Race_Index + @" += 1 
jump @CPRACE_6007 

:CPRACE_5999
008A: " + Race_Index + @" = 50@ 

:CPRACE_6007
gosub @CPRACE_46974 
240@ = 1 

:CPRACE_6021
jump @CPRACE_6035 

:CPRACE_6028
240@ = 0 

:CPRACE_6035
if or
  237@ > 100 
  -100 > 236@ 
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
else_jump @CPRACE_6152 
if 
  241@ == 0 
else_jump @CPRACE_6145 
if 
001E:   " + Race_Index + @" > 50@ 
else_jump @CPRACE_6123 
" + Race_Index + @" -= 1 
jump @CPRACE_6131 

:CPRACE_6123
008A: " + Race_Index + @" = 51@ 

:CPRACE_6131
gosub @CPRACE_46974 
241@ = 1 

:CPRACE_6145
jump @CPRACE_6159 

:CPRACE_6152
241@ = 0 

:CPRACE_6159
if 
00E1:   player 0 pressed_key 15 
else_jump @CPRACE_6229 
if 
  242@ == 0 
else_jump @CPRACE_6222 
0391: release_textures 
0826: enable_hud 1 
0581: enable_radar 1 
03E6: remove_text_box 
53@ = 1 
return 
242@ = 1 

:CPRACE_6222
jump @CPRACE_6236 

:CPRACE_6229
242@ = 0 

:CPRACE_6236
if 
00E1:   player 0 pressed_key 16 
else_jump @CPRACE_6317 
if 
  243@ == 0 
else_jump @CPRACE_6310 
if 
  " + Race_Index + @" > -1 
else_jump @CPRACE_6303 
fade 0 500 
49@ = 2 

:CPRACE_6303
243@ = 1 

:CPRACE_6310
jump @CPRACE_6324 

:CPRACE_6317
243@ = 0 

:CPRACE_6324
0937: text_draw_box_cornerA 53.0 130.0 cornerB 597.0 410.0 GXT_reference 'RACES_0' style 3  
gosub @CPRACE_47594 
0343: set_text_draw_linewidth 320.0 
033F: set_text_draw_letter_size " + _6931 + @" " + _6945 + @" 
033E: set_draw_text_position " + _6903 + @" " + _6917 + @" GXT 85@(" + Race_Index + @",30s) 
gosub @CPRACE_47594 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
033E: set_draw_text_position " + _6903 + @" " + _6918 + @" GXT 'RACES36'  
gosub @CPRACE_47594 
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size " + _6933 + @" " + _6947 + @" 
0086: " + _6919 + @" = " + _6918 + @" 
0059: " + _6919 + @" += " + _6924 + @" 
if 
0424:   is_system_metric 
else_jump @CPRACE_6624 
0087: 244@ = 55@(" + Race_Index + @",30f) 
244@ /= 1000.0 
0092: 246@ = float 244@ to_integer 
0093: 47@ = integer 246@ to_float 
0087: 245@ = 244@ 
0063: 245@ -= 47@ 
0092: 247@ = float 245@ to_integer 
if 
  10 > 247@ 
else_jump @CPRACE_6594 
045B: draw_text_2numbers " + _6903 + @" " + _6919 + @" GXT 'RACES35' numbers 246@ 247@  
jump @CPRACE_6617 

:CPRACE_6594
045B: draw_text_2numbers " + _6903 + @" " + _6919 + @" GXT 'RACES34' numbers 246@ 247@  

:CPRACE_6617
jump @CPRACE_6767 

:CPRACE_6624
0087: 248@ = 55@(" + Race_Index + @",30f) 
248@ /= 1609.0 
0092: 246@ = float 248@ to_integer 
0093: 47@ = integer 246@ to_float 
0087: 245@ = 248@ 
0063: 245@ -= 47@ 
245@ *= 100.0 
0092: 247@ = float 245@ to_integer 
if 
  10 > 247@ 
else_jump @CPRACE_6744 
045B: draw_text_2numbers " + _6903 + @" " + _6919 + @" GXT 'RACES47' numbers 246@ 247@  
jump @CPRACE_6767 

:CPRACE_6744
045B: draw_text_2numbers " + _6903 + @" " + _6919 + @" GXT 'RACES46' numbers 246@ 247@  

:CPRACE_6767
gosub @CPRACE_47594 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
033E: set_draw_text_position " + _6903 + @" " + _6920 + @" GXT 'RACES38'  
gosub @CPRACE_47594 
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size " + _6933 + @" " + _6947 + @" 
0086: " + _6921 + @" = " + _6920 + @" 
0059: " + _6921 + @" += " + _6924 + @" 
if 
  " + tmp_Races_Current_Best_Time + @"(" + Race_Index + @",30i) == 999999999 
else_jump @CPRACE_6893 
033E: set_draw_text_position " + _6903 + @" " + _6921 + @" GXT 'RACES45'  
jump @CPRACE_7018 

:CPRACE_6893
008B: 452@ = " + tmp_Races_Current_Best_Time + @"(" + Race_Index + @",30i) 
452@ /= 60 
0085: 36@ = 452@ 
36@ *= 60 
008B: 453@ = " + tmp_Races_Current_Best_Time + @"(" + Race_Index + @",30i) 
0062: 453@ -= 36@ 
if 
  10 > 453@ 
else_jump @CPRACE_6995 
045B: draw_text_2numbers " + _6903 + @" " + _6921 + @" GXT 'RACES40' numbers 452@ 453@  
jump @CPRACE_7018 

:CPRACE_6995
045B: draw_text_2numbers " + _6903 + @" " + _6921 + @" GXT 'RACES39' numbers 452@ 453@  

:CPRACE_7018
if 
   not " + Current_Tournament + @" == 3 
else_jump @CPRACE_7332 
gosub @CPRACE_47594 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
033E: set_draw_text_position " + _6903 + @" " + _6922 + @" GXT 'RACES37'  
gosub @CPRACE_47594 
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size " + _6933 + @" " + _6947 + @" 
0086: " + _6923 + @" = " + _6922 + @" 
0059: " + _6923 + @" += " + _6924 + @" 
if 
  " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) == 1 
else_jump @CPRACE_7159 
033E: set_draw_text_position " + _6903 + @" " + _6923 + @" GXT 'RACES41'  
jump @CPRACE_7332 

:CPRACE_7159
if 
  " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) == 2 
else_jump @CPRACE_7205 
033E: set_draw_text_position " + _6903 + @" " + _6923 + @" GXT 'RACES42'  
jump @CPRACE_7332 

:CPRACE_7205
if 
  " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) == 3 
else_jump @CPRACE_7251 
033E: set_draw_text_position " + _6903 + @" " + _6923 + @" GXT 'RACES43'  
jump @CPRACE_7332 

:CPRACE_7251
if and
  " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) > 3 
  100 > " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) 
else_jump @CPRACE_7315 
045A: draw_text_1number " + _6903 + @" " + _6923 + @" GXT 'RACES44' number " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i)  
jump @CPRACE_7332 

:CPRACE_7315
033E: set_draw_text_position " + _6903 + @" " + _6923 + @" GXT 'RACES45'  

:CPRACE_7332
008B: 36@ = " + Race_Index + @" 
36@ += 1 
038D: draw_texture 36@ position 454.98 268.18 size 256.0 256.0 RGBA 180 180 180 255 
jump @CPRACE_20805 

:CPRACE_7391
if 
   not fading 
else_jump @CPRACE_7570 
0989: set_text_boxes_width 200 
0391: release_textures 
03E6: remove_text_box 
gosub @CPRACE_20812 
09B9: show_entered_car_name 0 
0826: enable_hud 1 
if 
  221@ == 0 
else_jump @CPRACE_7457 
0581: enable_radar 1 
jump @CPRACE_7475 

:CPRACE_7457
057E: set_radar_grey 1 
09BA: show_entered_zone_name 0 
09AC: disable_map_icons 1 
04F9: set_sky_color 2 fade 0 

:CPRACE_7475
" + _10493 + @" = 1 
if 
  " + tmp_Races_Won + @"(" + Race_Index + @",30i) == 0 
else_jump @CPRACE_7538 
if and
  " + Race_Index + @" == 0 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_7536 
jump @CPRACE_7538 

:CPRACE_7536
increment_mission_attempts 

:CPRACE_7538
if 
  " + Race_Index + @" == 23 
else_jump @CPRACE_7563 


:CPRACE_7563
49@ = 3 

:CPRACE_7570
jump @CPRACE_20805 

:CPRACE_7577
0085: 249@ = 250@ 
249@ -= 1 
0085: 251@ = 224@ 
251@ -= 1 
252@ = 0 
253@ = 0 
254@ = 0 
255@ = 0 

:CPRACE_7635
if 
001D:   256@ > 253@ 
else_jump @CPRACE_7712 
257@(253@,16i) = 0 
273@(253@,16i) = 0 
289@(253@,16i) = 0 
305@(253@,16i) = 0 
253@ += 1 
jump @CPRACE_7635 

:CPRACE_7712
253@ = 0 
321@ = -1 
49@ = 4 
if 
04A4:   205@ == 3 
else_jump @CPRACE_7877 
if or
  " + Race_Index + @" == 22 
  " + Race_Index + @" == 23 
  " + Race_Index + @" == 24 
else_jump @CPRACE_7830 
322@ = 12.0 
323@ = 12.0 
324@ = 12.0 
325@ = 6.0 
jump @CPRACE_7870 

:CPRACE_7830
322@ = 25.0 
323@ = 25.0 
324@ = 25.0 
325@ = 12.0 

:CPRACE_7870
jump @CPRACE_7917 

:CPRACE_7877
322@ = 12.0 
323@ = 12.0 
324@ = 7.0 
325@ = 6.0 

:CPRACE_7917
jump @CPRACE_20805 

:CPRACE_7924
252@ = 0 

:CPRACE_7931
if 
001D:   256@ > 252@ 
else_jump @CPRACE_8154 
if 
04A4:   700@(252@,16i) == 290 
else_jump @CPRACE_8099 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_8017 
023C: load_special_actor 'CESAR' as 1 
023C: load_special_actor 'KENDL' as 2 

:CPRACE_8017
if 
  " + Race_Index + @" == 7 
else_jump @CPRACE_8048 
023C: load_special_actor 'WUZIMU' as 1 

:CPRACE_8048
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_8092 
023C: load_special_actor 'WUZIMU' as 1 
023C: load_special_actor 'CAT' as 2 

:CPRACE_8092
jump @CPRACE_8108 

:CPRACE_8099
Model.Load(700@(252@,16i))

:CPRACE_8108
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_8131 
06E9: load_car_component #WHEEL_OR1 

:CPRACE_8131
Model.Load(716@(252@,16i))
252@ += 1 
jump @CPRACE_7931 

:CPRACE_8154
04ED: load_animation ""CAR"" 
04ED: load_animation ""RIOT"" 
038B: load_requested_models 
326@ = 0 

:CPRACE_8178
if 
  326@ == 0 
else_jump @CPRACE_8646 
wait 0 
326@ = 1 
252@ = 0 

:CPRACE_8214
if 
001D:   256@ > 252@ 
else_jump @CPRACE_8639 
if 
04A4:   700@(252@,16i) == 290 
else_jump @CPRACE_8498 
if 
823D:   not special_actor 1 loaded 
else_jump @CPRACE_8385 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_8309 
023C: load_special_actor 'CESAR' as 1 
326@ = 0 

:CPRACE_8309
if 
  " + Race_Index + @" == 7 
else_jump @CPRACE_8347 
023C: load_special_actor 'WUZIMU' as 1 
326@ = 0 

:CPRACE_8347
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_8385 
023C: load_special_actor 'WUZIMU' as 1 
326@ = 0 

:CPRACE_8385
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_8438 
if 
823D:   not special_actor 2 loaded 
else_jump @CPRACE_8438 
023C: load_special_actor 'KENDL' as 2 
326@ = 0 

:CPRACE_8438
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_8491 
if 
823D:   not special_actor 2 loaded 
else_jump @CPRACE_8491 
023C: load_special_actor 'CAT' as 2 
326@ = 0 

:CPRACE_8491
jump @CPRACE_8534 

:CPRACE_8498
if 
   not Model.Available(700@(252@,16i))
else_jump @CPRACE_8534 
Model.Load(700@(252@,16i))
326@ = 0 

:CPRACE_8534
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_8580 
if 
86EA:   not car_component #WHEEL_OR1 available 
else_jump @CPRACE_8580 
06E9: load_car_component #WHEEL_OR1 
326@ = 0 

:CPRACE_8580
if 
   not Model.Available(716@(252@,16i))
else_jump @CPRACE_8625 
Model.Load(700@(252@,16i))
Model.Load(716@(252@,16i))
326@ = 0 

:CPRACE_8625
252@ += 1 
jump @CPRACE_8214 

:CPRACE_8639
jump @CPRACE_8178 

:CPRACE_8646
49@ = 5 
jump @CPRACE_20805 

:CPRACE_8660
01EB: set_traffic_density_multiplier_to 0.0 
0395: clear_area 0 at 454@ 536@ 618@ radius 30.0 
if 
  " + Custom_Tournament_Flag + @" == 1 
else_jump @CPRACE_8708 
0792: disembark_instantly_actor " + PlayerActor + @" 

:CPRACE_8708
Actor.PutAt(" + PlayerActor + @", 454@, 536@, 618@)
0860: link_actor " + PlayerActor + @" to_interior 221@ 
select_interior 221@ 
04E4: refresh_game_renderer_at 454@ 536@ 
Camera.Restore_WithJumpCut
Camera.SetAtPos(454@, 536@, 618@)
0915: sync_weather_with_time_and_location_instantly 
49@ = 6 
jump @CPRACE_20805 

:CPRACE_8772
if and
04EE:   animation ""CAR"" loaded 
04EE:   animation ""RIOT"" loaded 
else_jump @CPRACE_11198 
443@ = Car.Create(716@, 454@, 536@, 618@)
039F: set_car 443@ race_to 455@ 537@ 
0085: 36@ = 256@ 
36@ -= 1 
253@ = 0 

:CPRACE_8848
if 
001D:   256@ > 253@ 
else_jump @CPRACE_11173 
if 
  256@ > 1 
else_jump @CPRACE_9265 
07E4: get_model 716@ dimensions_cornerA_to 329@ 330@ " + tempvar_Float_3 + @" dimensions_cornerB_to 327@ 328@ " + tempvar_Float_3 + @" 
329@ *= -1.0 
005B: 327@ += 329@ 
if 
  2.0 > 327@ 
else_jump @CPRACE_8957 
327@ = 2.0 

:CPRACE_8957
0087: 329@ = 327@ 
329@ *= -1.0 
330@ *= -1.0 
005B: 328@ += 330@ 
0085: 254@ = 253@ 
254@ /= 2 
254@ *= 2 
if 
003B:   254@ == 253@ 
else_jump @CPRACE_9083 
0088: " + tempvar_Float_1 + @" = 327@ 
0093: 47@ = integer 253@ to_float 
006B: 47@ *= 328@ 
47@ *= -1.0 
0088: " + tempvar_Float_2 + @" = 47@ 
jump @CPRACE_9140 

:CPRACE_9083
0088: " + tempvar_Float_1 + @" = 329@ 
0085: 255@ = 253@ 
255@ -= 1 
0093: 47@ = integer 255@ to_float 
006B: 47@ *= 328@ 
47@ *= -1.0 
0088: " + tempvar_Float_2 + @" = 47@ 

:CPRACE_9140
if 
   Car.Wrecked(443@)
else_jump @CPRACE_9201 
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_9199 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_9199 
" + _1846 + @" = 1 

:CPRACE_9199
return 

:CPRACE_9201
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 0.0 
" + tempvar_Angle + @" = Car.Angle(443@)
0089: 331@(253@,16f) = " + tempvar_Float_1 + @" 
0089: 347@(253@,16f) = " + tempvar_Float_2 + @" 
jump @CPRACE_9329 

:CPRACE_9265
" + tempvar_Angle + @" = Car.Angle(443@)
0088: " + tempvar_Float_1 + @" = 331@(253@,16f) 
0088: " + tempvar_Float_2 + @" = 347@(253@,16f) 
0087: 331@(253@,16f) = 454@ 
0087: 347@(253@,16f) = 536@ 
0088: " + tempvar_Float_3 + @" = 618@ 

:CPRACE_9329
if 
881E:   not model 716@(253@,16i) boat 
else_jump @CPRACE_9403 
if 
881F:   not model 716@(253@,16i) plane 
else_jump @CPRACE_9403 
if 
8820:   not model 716@(253@,16i) heli 
else_jump @CPRACE_9403 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 

:CPRACE_9403
0089: 363@(253@,16f) = " + tempvar_Float_3 + @" 
if 
001D:   36@ > 253@ 
else_jump @CPRACE_9756 
gosub @CPRACE_488 
395@(253@,16i) = Actor.CreateAsDriver(CivMale, 700@(253@,16i), 379@(253@,16i))
if 
04A4:   700@(253@,16i) == 290 
else_jump @CPRACE_9552 
if or
  " + Race_Index + @" == 0 
  " + Race_Index + @" == 8 
else_jump @CPRACE_9533 
411@ = Actor.CreateAsPassenger(CivFemale, #SPECIAL02, 379@(253@,16i), 0)

:CPRACE_9533
Car.SetImmunities(379@(253@,16i), 1, 1, 1, 0, 1)

:CPRACE_9552
if 
  221@ > 0 
else_jump @CPRACE_9614 
if 
  321@ == -1 
else_jump @CPRACE_9602 
07E5: copy_decision_maker -1 to 321@ 
0708: reset_decision_maker 321@ event 79 

:CPRACE_9602
060B: set_actor 395@(253@,16i) decision_maker_to 321@ 

:CPRACE_9614
0860: link_actor 395@(253@,16i) to_interior 221@ 
054A: set_actor 395@(253@,16i) can_be_shot_in_a_car 0 
0446: set_actor 395@(253@,16i) dismemberment_possible 0 
0568: set_actor 395@(253@,16i) untargetable 1 
02A9: set_actor 395@(253@,16i) immune_to_nonplayer 1 
039E: set_actor 395@(253@,16i) locked 0 while_in_car 
04D8: set_actor 395@(253@,16i) drowns_in_water 0 
Actor.Health(395@(253@,16i)) = 500
if 
  221@ == 0 
else_jump @CPRACE_9738 
412@(253@,16i) = Marker.CreateAboveActor(395@(253@,16i))

:CPRACE_9738
018B: set_marker 412@(253@,16i) radar_mode 1 
jump @CPRACE_11159 

:CPRACE_9756
if 
881E:   not model 716@(253@,16i) boat 
else_jump @CPRACE_10754 
if 
881F:   not model 716@(253@,16i) plane 
else_jump @CPRACE_10754 
if 
8820:   not model 716@(253@,16i) heli 
else_jump @CPRACE_10754 
if 
  221@ == 0 
else_jump @CPRACE_10754 
060A: create_decision_maker_type 0 store_to 428@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset -4.0435 6.5755 -0.8 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 429@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0961: set_actor 429@ keep_tasks_after_cleanup 1 
060B: set_actor 429@ decision_maker_to 428@ 
06BA: AS_actor 429@ turn_to_and_look_at 454@ 536@ 618@ 
430@ = Object.Init(#KMB_GOFLAG, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
070A: AS_actor 429@ attach_to_object 430@ offset 0.062 0.027 -0.15 on_bone 5 16 perform_animation ""FLAG_DROP"" IFP_file ""CAR"" time 0 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset -5.6392 2.9435 -0.8 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 431@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset -6.0071 -2.0778 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 432@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset -7.6039 -5.0807 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 433@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset -7.0724 -6.4057 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 434@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset -5.9988 -13.553 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 435@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset 6.073 -15.2059 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 436@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset 7.2639 -12.9933 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 437@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset 5.8429 -7.7069 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 438@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset 8.4135 -3.7971 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 439@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset 6.2507 0.3634 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 440@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 443@ with_offset 8.6397 2.419 2.5 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0376: 441@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
252@ = 0 

:CPRACE_10623
if 
  11 > 252@ 
else_jump @CPRACE_10754 
060B: set_actor 431@(252@,11i) decision_maker_to 428@ 
0961: set_actor 431@(252@,11i) keep_tasks_after_cleanup 1 
0615: define_AS_pack_begin 38@ 
gosub @CPRACE_50540 
0643: set_AS_pack 38@ loop 1 
0616: define_AS_pack_end 38@ 
0615: define_AS_pack_begin 37@ 
06BA: AS_actor -1 turn_to_and_look_at 454@ 536@ 618@ 
0618: assign_actor -1 to_AS_pack 38@ 
0616: define_AS_pack_end 37@ 
0618: assign_actor 431@(252@,11i) to_AS_pack 37@ 
061B: remove_references_to_AS_pack 38@ 
061B: remove_references_to_AS_pack 37@ 
252@ += 1 
jump @CPRACE_10623 

:CPRACE_10754
Car.Destroy(443@)
008B: 395@(253@,16i) = " + PlayerActor + @" 
0085: 442@ = 253@ 
363@(442@,16f) += 3.0 
02CE: 363@(442@,16f) = ground_z_at 331@(442@,16f) 347@(442@,16f) 363@(442@,16f) 
if 
  0.0 > 363@(442@,16f) 
else_jump @CPRACE_10882 
if 
081E:   model 716@(442@,16i) boat 
else_jump @CPRACE_10882 
363@(442@,16f) = 0.0 

:CPRACE_10882
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @CPRACE_10947 
0811: 379@(442@,16i) = actor " + PlayerActor + @" used_car 
Car.PutAt(379@(442@,16i), 331@(442@,16f), 347@(442@,16f), 363@(442@,16f))
jump @CPRACE_11070 

:CPRACE_10947
379@(442@,16i) = Car.Create(716@(442@,16i), 331@(442@,16f), 347@(442@,16f), 363@(442@,16f))
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_11017 
06E7: 36@ = add_car_component #WHEEL_OR1 to_car 379@(442@,16i) 

:CPRACE_11017
if 
   not 209@ == -1 
else_jump @CPRACE_11058 
0229: set_car 379@(442@,16i) primary_color_to 209@(442@,6i) secondary_color_to 215@(442@,6i) 

:CPRACE_11058
036A: put_actor " + PlayerActor + @" in_car 379@(442@,16i) 

:CPRACE_11070
0840: link_car 379@(442@,16i) to_interior 221@ 
Car.Angle(379@(442@,16i)) = " + tempvar_Angle + @"
if or
081F:   model 716@(442@,16i) plane 
0820:   model 716@(442@,16i) heli 
else_jump @CPRACE_11148 
Car.LockInCurrentPosition(379@(442@,16i)) = True
Car.SetSpeedInstantly(379@(442@,16i), 10.0)

:CPRACE_11148
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
fade 1 500 

:CPRACE_11159
253@ += 1 
jump @CPRACE_8848 

:CPRACE_11173
Player.CanMove(" + PlayerChar + @") = False
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
49@ = 7 
jump @CPRACE_11213 

:CPRACE_11198
04ED: load_animation ""CAR"" 
04ED: load_animation ""RIOT"" 

:CPRACE_11213
jump @CPRACE_20805 

:CPRACE_11220
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
00BA: show_text_styled GXT 'RACES_4' time 1100 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1056 
0084: " + _6960 + @" = " + Current_Time_in_ms2 + @" 
" + _6960 + @" += 999 
49@ = 8 
jump @CPRACE_20805 

:CPRACE_11297
if 
001C:   " + Current_Time_in_ms2 + @" > " + _6960 + @" 
else_jump @CPRACE_11375 
00BA: show_text_styled GXT 'RACES_5' time 1100 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1056 
0084: " + _6960 + @" = " + Current_Time_in_ms2 + @" 
" + _6960 + @" += 999 
49@ = 9 

:CPRACE_11375
jump @CPRACE_20805 

:CPRACE_11382
if 
001C:   " + Current_Time_in_ms2 + @" > " + _6960 + @" 
else_jump @CPRACE_11460 
00BA: show_text_styled GXT 'RACES_6' time 1100 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1056 
0084: " + _6960 + @" = " + Current_Time_in_ms2 + @" 
" + _6960 + @" += 999 
49@ = 10 

:CPRACE_11460
jump @CPRACE_20805 

:CPRACE_11467
if 
001C:   " + Current_Time_in_ms2 + @" > " + _6960 + @" 
else_jump @CPRACE_12344 
00BA: show_text_styled GXT 'RACES_7' time 800 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1057 
Player.CanMove(" + PlayerChar + @") = True
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
03F4: set_all_cars_apply_damage_rules 1 
253@ = 0 

:CPRACE_11547
if 
  11 > 253@ 
else_jump @CPRACE_11588 
Actor.RemoveReferences(431@(253@,11i))
253@ += 1 
jump @CPRACE_11547 

:CPRACE_11588
Actor.RemoveReferences(429@)
04EF: release_animation ""CAR"" 
253@ = 0 

:CPRACE_11607
if 
001D:   256@ > 253@ 
else_jump @CPRACE_11829 
if 
   not Car.Wrecked(379@(253@,16i))
else_jump @CPRACE_11815 
Car.ImmuneToNonPlayer(379@(253@,16i)) = False
if 
881E:   not model 716@(253@,16i) boat 
else_jump @CPRACE_11815 
if 
881F:   not model 716@(253@,16i) plane 
else_jump @CPRACE_11804 
if 
8820:   not model 716@(253@,16i) heli 
else_jump @CPRACE_11786 
if 
803B:   not  253@ == 442@ 
else_jump @CPRACE_11779 
if 
  221@ == 0 
else_jump @CPRACE_11779 
072F: enable_car 379@(253@,16i) stuck_check_distance 3.0 time 4000 and_restore_if stuck 1 flipped 1 unk_place_on_road_properly 1 to_path -1 

:CPRACE_11779
jump @CPRACE_11797 

:CPRACE_11786
Car.LockInCurrentPosition(379@(253@,16i)) = False

:CPRACE_11797
jump @CPRACE_11815 

:CPRACE_11804
Car.LockInCurrentPosition(379@(253@,16i)) = False

:CPRACE_11815
253@ += 1 
jump @CPRACE_11607 

:CPRACE_11829
01EB: set_traffic_density_multiplier_to 1.0 
" + _6903 + @" = 582.7242 
" + _6917 + @" = 356.2812 
" + _6931 + @" = 52.2072 
" + _6945 + @" = 52.2072 
" + _6904 + @" = 584.0833 
" + _6918 + @" = 329.3647 
" + _6932 + @" = 0.4943 
" + _6946 + @" = 2.097 
" + _6905 + @" = 570.6411 
" + _6919 + @" = 323.5937 
" + _6933 + @" = 0.9127 
" + _6947 + @" = 4.8106 
" + _6906 + @" = 585.941 
" + _6920 + @" = 345.6341 
" + _6934 + @" = 0.4197 
" + _6948 + @" = 1.8511 
" + _6907 + @" = 582.7242 
" + _6921 + @" = 359.0323 
" + _6935 + @" = 0.4993 
" + _6949 + @" = 2.637 
" + _6908 + @" = 582.7242 
" + _6922 + @" = 356.2812 
" + _6936 + @" = 56.2072 
" + _6950 + @" = 56.2072 
" + _6909 + @" = 582.7242 
" + _6923 + @" = 356.2812 
" + _6937 + @" = 58.2072 
" + _6951 + @" = 58.2072 
" + _6910 + @" = 582.7242 
" + _6924 + @" = 400.7518 
" + _6938 + @" = 58.2072 
" + _6952 + @" = 32.7789 
" + _6911 + @" = 582.7242 
" + _6925 + @" = 400.2518 
" + _6939 + @" = 56.2072 
" + _6953 + @" = 31.7789 
" + _6912 + @" = 582.7242 
" + _6926 + @" = 399.2518 
" + _6940 + @" = 52.2072 
" + _6954 + @" = 29.7789 
" + _6913 + @" = 560.4862 
" + _6927 + @" = 384.5027 
" + _6941 + @" = 0.5 
" + _6955 + @" = 1.5393 
0084: " + _6960 + @" = " + Current_Time_in_ms2 + @" 
008B: 206@ = " + Current_Time_in_ms2 + @" 
if 
  256@ == 1 
else_jump @CPRACE_12333 
" + _6960 + @" = 0 
03C3: set_timer_to " + _6960 + @" type 0 GXT 'TIMER' 

:CPRACE_12333
0A0E: disable_text_with_style 2 
49@ = 11 

:CPRACE_12344
jump @CPRACE_20805 

:CPRACE_12351
if 
001D:   256@ > 253@ 
else_jump @CPRACE_18590 
if 
   not Actor.Dead(395@(253@,16i))
else_jump @CPRACE_18123 
if 
  13 > 49@ 
else_jump @CPRACE_12732 
if 
803C:   not  " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_12732 
if 
001D:   273@(253@,16i) > 273@(442@,16i) 
else_jump @CPRACE_12472 
229@ += 1 
jump @CPRACE_12732 

:CPRACE_12472
if 
003B:   273@(442@,16i) == 273@(253@,16i) 
else_jump @CPRACE_12732 
if 
001D:   257@(253@,16i) > 257@(442@,16i) 
else_jump @CPRACE_12540 
229@ += 1 
jump @CPRACE_12732 

:CPRACE_12540
if 
001D:   257@(253@,16i) > 249@ 
else_jump @CPRACE_12577 
229@ += 1 
jump @CPRACE_12732 

:CPRACE_12577
if 
003B:   257@(442@,16i) == 257@(253@,16i) 
else_jump @CPRACE_12732 
Actor.StorePos(395@(253@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
050A: 444@ = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
050A: 445@ = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) 
if 
0025:   445@ > 444@ 
else_jump @CPRACE_12732 
229@ += 1 

:CPRACE_12732
if 
  49@ == 12 
else_jump @CPRACE_15498 
if 
003C:   " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_14121 
if 
   not Car.Wrecked(379@(442@,16i))
else_jump @CPRACE_13748 
if 
   Actor.InCar(" + PlayerActor + @", 379@(442@,16i))
else_jump @CPRACE_13359 
if 
  207@ == 1 
else_jump @CPRACE_13352 
03D5: remove_text 'RACES21'  
Marker.Disable(54@)
363@(253@,16f) -= 1000.0 
if 
  221@ == 0 
else_jump @CPRACE_13345 
254@ = 0 
0085: 36@ = 256@ 
36@ -= 1 

:CPRACE_12904
if 
001D:   36@ > 254@ 
else_jump @CPRACE_12984 
if 
   not Actor.Dead(395@(254@,16i))
else_jump @CPRACE_12970 
412@(254@,16i) = Marker.CreateAboveActor(395@(254@,16i))
018B: set_marker 412@(254@,16i) radar_mode 1 

:CPRACE_12970
254@ += 1 
jump @CPRACE_12904 

:CPRACE_12984
018A: 54@ = create_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) 
Marker.SetColor(54@, 0)
018B: set_marker 54@ radar_mode 2 
Marker.SetIconSize(54@, 3)
if and
003B:   257@(253@,16i) == 249@ 
003B:   273@(253@,16i) == 251@ 
else_jump @CPRACE_13243 
if 
04A4:   205@ == 3 
else_jump @CPRACE_13188 
0085: 36@ = 257@(253@,16i) 
36@ -= 1 
if 
  0 > 36@ 
else_jump @CPRACE_13128 
36@ = 0 

:CPRACE_13128
06D5: 449@ = create_racing_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) point_to 454@(36@,82f) 536@(36@,82f) 618@(36@,82f) type 205@ radius 325@ 
jump @CPRACE_13236 

:CPRACE_13188
06D5: 449@ = create_racing_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) point_to 0.0 0.0 0.0 type 1 radius 6.0 

:CPRACE_13236
jump @CPRACE_13345 

:CPRACE_13243
0085: 36@ = 257@(253@,16i) 
36@ += 1 
if 
003B:   257@(253@,16i) == 249@ 
else_jump @CPRACE_13292 
36@ = 1 

:CPRACE_13292
06D5: 449@ = create_racing_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) point_to 454@(36@,82f) 536@(36@,82f) 618@(36@,82f) type 205@ radius 325@ 

:CPRACE_13345
207@ = 0 

:CPRACE_13352
jump @CPRACE_13741 

:CPRACE_13359
if 
  207@ == 0 
else_jump @CPRACE_13507 
06D6: disable_racing_checkpoint 449@ 
Marker.Disable(54@)
254@ = 0 
0085: 36@ = 256@ 
36@ -= 1 

:CPRACE_13409
if 
001D:   36@ > 254@ 
else_jump @CPRACE_13451 
Marker.Disable(412@(254@,16i))
254@ += 1 
jump @CPRACE_13409 

:CPRACE_13451
54@ = Marker.CreateAboveCar(379@(442@,16i))
07E0: set_marker 54@ type_to 1 
363@(253@,16f) += 1000.0 
008B: 446@ = " + Current_Time_in_ms2 + @" 
446@ += 25400 
207@ = 1 

:CPRACE_13507
0085: 453@ = 446@ 
0064: 453@ -= " + Current_Time_in_ms2 + @" 
453@ /= 1000 
if 
  1 > 453@ 
else_jump @CPRACE_13556 
453@ = 0 

:CPRACE_13556
if 
001E:   " + Current_Time_in_ms2 + @" > 446@ 
else_jump @CPRACE_13670 
00BC: show_text_highpriority GXT 'RACES20' time 5000 flag 1  
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_13625 
00BA: show_text_styled GXT 'M_FAIL' time 3000 style 1  

:CPRACE_13625
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_13668 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_13668 
" + _1846 + @" = 1 

:CPRACE_13668
return 

:CPRACE_13670
if 
  453@ == 1 
else_jump @CPRACE_13718 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'RACE_21' number 453@ time 200 flag 1  
jump @CPRACE_13741 

:CPRACE_13718
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'RACES21' number 453@ time 200 flag 1  

:CPRACE_13741
jump @CPRACE_14114 

:CPRACE_13748
if 
02BF:   car 379@(442@,16i) sunk 
else_jump @CPRACE_14019 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @CPRACE_13917 
443@ = Actor.CurrentCar(" + PlayerActor + @")
if 
803B:   not  443@ == 379@(442@,16i) 
else_jump @CPRACE_13910 
00BC: show_text_highpriority GXT 'RACES24' time 5000 flag 1  
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_13865 
00BA: show_text_styled GXT 'M_FAIL' time 3000 style 1  

:CPRACE_13865
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_13908 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_13908 
" + _1846 + @" = 1 

:CPRACE_13908
return 

:CPRACE_13910
jump @CPRACE_14012 

:CPRACE_13917
00BC: show_text_highpriority GXT 'RACES24' time 5000 flag 1  
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_13967 
00BA: show_text_styled GXT 'M_FAIL' time 3000 style 1  

:CPRACE_13967
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_14010 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_14010 
" + _1846 + @" = 1 

:CPRACE_14010
return 

:CPRACE_14012
jump @CPRACE_14114 

:CPRACE_14019
00BC: show_text_highpriority GXT 'RACES24' time 5000 flag 1  
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_14069 
00BA: show_text_styled GXT 'M_FAIL' time 3000 style 1  

:CPRACE_14069
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_14112 
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_14112 
" + _1846 + @" = 1 

:CPRACE_14112
return 

:CPRACE_14114
jump @CPRACE_15498 

:CPRACE_14121
if 
001D:   250@ > 257@(253@,16i) 
else_jump @CPRACE_15498 
if 
   Actor.Driving(395@(253@,16i))
else_jump @CPRACE_14412 
if 
  221@ == 0 
else_jump @CPRACE_14405 
0085: 36@ = 257@(442@,16i) 
36@ += 4 
443@ = Actor.CurrentCar(395@(253@,16i))
if 
001D:   257@(253@,16i) > 36@ 
else_jump @CPRACE_14253 
Car.SetMaxSpeed(443@, 25.0)
jump @CPRACE_14312 

:CPRACE_14253
if or
  " + Race_Index + @" == 7 
  " + Race_Index + @" == 8 
  " + Race_Index + @" == 0 
else_jump @CPRACE_14302 
Car.SetMaxSpeed(443@, 35.0)
jump @CPRACE_14312 

:CPRACE_14302
Car.SetMaxSpeed(443@, 50.0)

:CPRACE_14312
if 
  " + Race_Index + @" == 8 
else_jump @CPRACE_14405 
if or
01AD:   car 443@ sphere 0 near_point -882.9833 -47.9468 radius 24.61 25.64 
01AD:   car 443@ sphere 0 near_point -843.0954 -141.9169 radius 24.59 -29.24 
else_jump @CPRACE_14405 
Car.SetMaxSpeed(443@, 30.0)

:CPRACE_14405
jump @CPRACE_14933 

:CPRACE_14412
if 
  " + Race_Index + @" == 25 
else_jump @CPRACE_14444 
jump @CPRACE_18141 
jump @CPRACE_14933 

:CPRACE_14444
if 
  305@(253@,16i) == 0 
else_jump @CPRACE_14490 
008B: 305@(253@,16i) = " + Current_Time_in_ms2 + @" 
305@(253@,16i) += 8000 

:CPRACE_14490
if 
001E:   " + Current_Time_in_ms2 + @" > 305@(253@,16i) 
else_jump @CPRACE_14933 
if 
803B:   not  257@(253@,16i) == 257@(442@,16i) 
else_jump @CPRACE_14933 
if 
80F2:   not actor " + PlayerActor + @" near_actor 395@(253@,16i) radius 30.0 30.0 0 
else_jump @CPRACE_14922 
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point 331@(253@,16f) 347@(253@,16f) radius 30.0 30.0 
else_jump @CPRACE_14904 
if 
838A:   not any_car_in_cube_cornerA 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) cornerB 4.0 4.0 3.0 
else_jump @CPRACE_14886 
if 
82CB:   not actor 395@(253@,16i) bounding_sphere_visible 
else_jump @CPRACE_14868 
if 
80C2:   not sphere_onscreen 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) radius 4.0 
else_jump @CPRACE_14850 
Car.RemoveReferences(379@(253@,16i))
gosub @CPRACE_488 
036A: put_actor 395@(253@,16i) in_car 379@(253@,16i) 
0085: 36@ = 257@(253@,16i) 
36@ += 1 
if 
001D:   250@ > 36@ 
else_jump @CPRACE_14832 
039F: set_car 379@(253@,16i) race_to 454@(36@,82f) 536@(36@,82f) 
Car.SetSpeedInstantly(379@(253@,16i), 20.0)

:CPRACE_14832
305@(253@,16i) = 0 
jump @CPRACE_14861 

:CPRACE_14850
305@(253@,16i) = 0 

:CPRACE_14861
jump @CPRACE_14879 

:CPRACE_14868
305@(253@,16i) = 0 

:CPRACE_14879
jump @CPRACE_14897 

:CPRACE_14886
305@(253@,16i) = 0 

:CPRACE_14897
jump @CPRACE_14915 

:CPRACE_14904
305@(253@,16i) = 0 

:CPRACE_14915
jump @CPRACE_14933 

:CPRACE_14922
305@(253@,16i) = 0 

:CPRACE_14933
if 
  221@ == 0 
else_jump @CPRACE_15498 
252@ = 0 
255@ = 0 

:CPRACE_14965
if 
001D:   256@ > 252@ 
else_jump @CPRACE_15047 
0085: 447@ = 257@(252@,16i) 
447@ -= 4 
if 
001D:   447@ > 257@(253@,16i) 
else_jump @CPRACE_15033 
255@ += 1 

:CPRACE_15033
252@ += 1 
jump @CPRACE_14965 

:CPRACE_15047
if 
  255@ > 0 
else_jump @CPRACE_15498 
if 
80F2:   not actor " + PlayerActor + @" near_actor 395@(253@,16i) radius 150.0 150.0 0 
else_jump @CPRACE_15498 
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point 331@(253@,16f) 347@(253@,16f) radius 150.0 150.0 
else_jump @CPRACE_15498 
if 
80EC:   not actor 395@(253@,16i) sphere 0 near_point 331@(253@,16f) 347@(253@,16f) radius 40.0 40.0 
else_jump @CPRACE_15498 
if 
838A:   not any_car_in_cube_cornerA 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) cornerB 4.0 4.0 3.0 
else_jump @CPRACE_15498 
if 
82CB:   not actor 395@(253@,16i) bounding_sphere_visible 
else_jump @CPRACE_15498 
if 
80C2:   not sphere_onscreen 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) radius 4.0 
else_jump @CPRACE_15498 
if 
0449:   actor 395@(253@,16i) in_a_car 
else_jump @CPRACE_15391 
Actor.PutAt(395@(253@,16i), 331@(253@,16f), 347@(253@,16f), 363@(253@,16f))
0085: 36@ = 257@(253@,16i) 
36@ += 1 
039F: set_car 443@ race_to 454@(36@,82f) 536@(36@,82f) 
jump @CPRACE_15498 

:CPRACE_15391
Car.RemoveReferences(379@(253@,16i))
gosub @CPRACE_488 
036A: put_actor 395@(253@,16i) in_car 379@(253@,16i) 
0085: 36@ = 257@(253@,16i) 
36@ += 1 
if 
001D:   250@ > 36@ 
else_jump @CPRACE_15498 
039F: set_car 379@(253@,16i) race_to 454@(36@,82f) 536@(36@,82f) 
Car.SetSpeedInstantly(379@(253@,16i), 20.0)

:CPRACE_15498
36@ = 0 
if 
0100:   actor 395@(253@,16i) in_sphere 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) radius 322@ 323@ 324@ sphere 0 in_car 
else_jump @CPRACE_15571 
36@ = 1 
jump @CPRACE_15700 

:CPRACE_15571
if 
07D6:   395@(253@,16i) == " + PlayerActor + @" 
else_jump @CPRACE_15700 
if 
0735:   is_keyboard_key_pressed 83 
else_jump @CPRACE_15700 
04E4: refresh_game_renderer_at 331@(253@,16f) 347@(253@,16f) 
Camera.SetAtPos(331@(253@,16f), 347@(253@,16f), 363@(253@,16f))
0088: " + tempvar_Float_1 + @" = 363@(253@,16f) 
" + tempvar_Float_1 + @" += 1.0 
Actor.PutAt(395@(253@,16i), 331@(253@,16f), 347@(253@,16f), 363@(253@,16f))

:CPRACE_15700
if 
  36@ == 1 
else_jump @CPRACE_18116 
if 
  49@ == 11 
else_jump @CPRACE_15743 
49@ = 12 

:CPRACE_15743
if 
003C:   " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_15809 
if 
  221@ == 0 
else_jump @CPRACE_15809 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
Marker.Disable(54@)

:CPRACE_15809
257@(253@,16i) += 1 
if 
001D:   250@ > 257@(253@,16i) 
else_jump @CPRACE_15910 
0085: 36@ = 257@(253@,16i) 
0087: 331@(253@,16f) = 454@(36@,82f) 
0087: 347@(253@,16f) = 536@(36@,82f) 
0087: 363@(253@,16f) = 618@(36@,82f) 
jump @CPRACE_16948 

:CPRACE_15910
if 
001D:   224@ > 273@(253@,16i) 
else_jump @CPRACE_15944 
273@(253@,16i) += 1 

:CPRACE_15944
if 
003B:   273@(253@,16i) == 224@ 
else_jump @CPRACE_16620 
if 
07D6:   395@(253@,16i) == " + PlayerActor + @" 
else_jump @CPRACE_16209 
if 
  224@ > 1 
else_jump @CPRACE_16119 
008B: 448@ = " + Current_Time_in_ms2 + @" 
0062: 448@ -= 206@ 
448@ /= 1000 
if 
001E:   " + tmp_Races_New_Best_Time + @"(" + Race_Index + @",30i) > 448@ 
else_jump @CPRACE_16119 
008A: " + tmp_Races_New_Best_Time + @"(" + Race_Index + @",30i) = 448@ 
if 
  " + Race_Index + @" == 25 
else_jump @CPRACE_16093 
042E: downdate_integer_stat 212 to 448@ 

:CPRACE_16093
if 
  " + Race_Index + @" == 26 
else_jump @CPRACE_16119 
042E: downdate_integer_stat 219 to 448@ 

:CPRACE_16119
06D6: disable_racing_checkpoint 449@ 
Marker.Disable(54@)
49@ = 13 
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_16188 
if 
  229@ > 0 
else_jump @CPRACE_16188 
00BA: show_text_styled GXT 'M_FAIL' time 3000 style 1  

:CPRACE_16188
363@(253@,16f) = 99999.0 
jump @CPRACE_16613 

:CPRACE_16209
if 
   not Car.Wrecked(379@(253@,16i))
else_jump @CPRACE_16238 
03CD: disable_car 379@(253@,16i) stuck_check 

:CPRACE_16238
if 
  221@ == 0 
else_jump @CPRACE_16548 
062E: get_actor 395@(253@,16i) task 1560 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @CPRACE_16541 
0615: define_AS_pack_begin 37@ 
06AC: 47@ = actor 395@(253@,16i) movement_speed 
0092: 36@ = float 47@ to_integer 
36@ *= -100 
36@ += 4000 
if 
  10 > 36@ 
else_jump @CPRACE_16354 
36@ = 10 

:CPRACE_16354
06C7: AS_actor -1 driver_of_car -1 perform_action 9 timelimit 36@ 
0209: 36@ = random_int_in_ranges 0 5 
if or
  36@ == 0 
  36@ == 1 
else_jump @CPRACE_16430 
06C7: AS_actor -1 driver_of_car -1 perform_action 7 timelimit 200 
06C7: AS_actor -1 driver_of_car -1 perform_action 4 timelimit 250000 
jump @CPRACE_16454 

:CPRACE_16430
06C7: AS_actor -1 driver_of_car -1 perform_action 8 timelimit 200 
06C7: AS_actor -1 driver_of_car -1 perform_action 5 timelimit 250000 

:CPRACE_16454
06C7: AS_actor -1 driver_of_car -1 perform_action 6 timelimit 250000 
06C7: AS_actor -1 driver_of_car -1 perform_action 6 timelimit 250000 
06C7: AS_actor -1 driver_of_car -1 perform_action 6 timelimit 250000 
06C7: AS_actor -1 driver_of_car -1 perform_action 6 timelimit 250000 
05D2: AS_actor -1 run_to_and_hijack_car -1 max_search_radius 100.0 traffic_behavior 2 
0616: define_AS_pack_end 37@ 
0618: assign_actor 395@(253@,16i) to_AS_pack 37@ 
061B: remove_references_to_AS_pack 37@ 

:CPRACE_16541
jump @CPRACE_16599 

:CPRACE_16548
062E: get_actor 395@(253@,16i) task 1490 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @CPRACE_16599 
05D2: AS_actor 395@(253@,16i) run_to_and_hijack_car -1 max_search_radius 100.0 traffic_behavior 2 

:CPRACE_16599
363@(253@,16f) = 99999.0 

:CPRACE_16613
jump @CPRACE_16948 

:CPRACE_16620
if 
003C:   " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_16877 
008B: 448@ = " + Current_Time_in_ms2 + @" 
0062: 448@ -= 206@ 
448@ /= 1000 
if 
001E:   " + tmp_Races_New_Best_Time + @"(" + Race_Index + @",30i) > 448@ 
else_jump @CPRACE_16869 
008A: " + tmp_Races_New_Best_Time + @"(" + Race_Index + @",30i) = 448@ 
if 
  " + Race_Index + @" == 25 
else_jump @CPRACE_16728 
042E: downdate_integer_stat 212 to 448@ 

:CPRACE_16728
if 
  " + Race_Index + @" == 26 
else_jump @CPRACE_16754 
042E: downdate_integer_stat 219 to 448@ 

:CPRACE_16754
0085: 452@ = 448@ 
452@ /= 60 
0085: 36@ = 452@ 
36@ *= 60 
0085: 453@ = 448@ 
0062: 453@ -= 36@ 
if 
  10 > 453@ 
else_jump @CPRACE_16847 
02FD: show_text_2numbers_lowpriority GXT 'LAPTIM0' numbers 452@ 453@ time 5000 flag 1  
jump @CPRACE_16869 

:CPRACE_16847
02FD: show_text_2numbers_lowpriority GXT 'LAPTIME' numbers 452@ 453@ time 5000 flag 1  

:CPRACE_16869
008B: 206@ = " + Current_Time_in_ms2 + @" 

:CPRACE_16877
257@(253@,16i) = 0 
0085: 36@ = 257@(253@,16i) 
0087: 331@(253@,16f) = 454@(36@,82f) 
0087: 347@(253@,16f) = 536@(36@,82f) 
0087: 363@(253@,16f) = 618@(36@,82f) 

:CPRACE_16948
if 
003C:   " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_17405 
if 
   not 363@(253@,16f) == 99999.0 
else_jump @CPRACE_17398 
if 
  221@ == 0 
else_jump @CPRACE_17066 
018A: 54@ = create_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) 
Marker.SetColor(54@, 0)
018B: set_marker 54@ radar_mode 2 
Marker.SetIconSize(54@, 3)
06D6: disable_racing_checkpoint 449@ 

:CPRACE_17066
if and
003B:   257@(253@,16i) == 249@ 
003B:   273@(253@,16i) == 251@ 
else_jump @CPRACE_17278 
if 
04A4:   205@ == 3 
else_jump @CPRACE_17223 
0085: 36@ = 257@(253@,16i) 
36@ -= 1 
if 
  0 > 36@ 
else_jump @CPRACE_17163 
36@ = 0 

:CPRACE_17163
06D5: 449@ = create_racing_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) point_to 454@(36@,82f) 536@(36@,82f) 618@(36@,82f) type 205@ radius 325@ 
jump @CPRACE_17271 

:CPRACE_17223
06D5: 449@ = create_racing_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) point_to 0.0 0.0 0.0 type 1 radius 6.0 

:CPRACE_17271
jump @CPRACE_17398 

:CPRACE_17278
if 
  221@ == 0 
else_jump @CPRACE_17398 
0085: 36@ = 257@(253@,16i) 
36@ += 1 
if 
003B:   257@(253@,16i) == 249@ 
else_jump @CPRACE_17345 
36@ = 1 

:CPRACE_17345
06D5: 449@ = create_racing_checkpoint_at 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) point_to 454@(36@,82f) 536@(36@,82f) 618@(36@,82f) type 205@ radius 325@ 

:CPRACE_17398
jump @CPRACE_18116 

:CPRACE_17405
if 
   not 363@(253@,16f) == 99999.0 
else_jump @CPRACE_18116 
if 
04A9:   actor 395@(253@,16i) driving_heli 
else_jump @CPRACE_17660 
if 
   not Car.Wrecked(379@(253@,16i))
else_jump @CPRACE_17603 
if 
   Actor.InCar(395@(253@,16i), 379@(253@,16i))
else_jump @CPRACE_17546 
04A2: set_heli 379@(253@,16i) fly_to 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) altitude_between 0.0 and 363@(253@,16f) 
jump @CPRACE_17596 

:CPRACE_17546
443@ = Actor.CurrentCar(395@(253@,16i))
04A2: set_heli 443@ fly_to 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) altitude_between 0.0 and 363@(253@,16f) 

:CPRACE_17596
jump @CPRACE_17653 

:CPRACE_17603
443@ = Actor.CurrentCar(395@(253@,16i))
04A2: set_heli 443@ fly_to 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) altitude_between 0.0 and 363@(253@,16f) 

:CPRACE_17653
jump @CPRACE_18116 

:CPRACE_17660
if 
   Actor.DrivingPlane(395@(253@,16i))
else_jump @CPRACE_17890 
if 
   not Car.Wrecked(379@(253@,16i))
else_jump @CPRACE_17833 
if 
   Actor.InCar(395@(253@,16i), 379@(253@,16i))
else_jump @CPRACE_17776 
04D2: set_plane 379@(253@,16i) fly_autopilot_around_point 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) altitude_between 0.0 and 363@(253@,16f) 
jump @CPRACE_17826 

:CPRACE_17776
443@ = Actor.CurrentCar(395@(253@,16i))
04D2: set_plane 443@ fly_autopilot_around_point 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) altitude_between 0.0 and 363@(253@,16f) 

:CPRACE_17826
jump @CPRACE_17883 

:CPRACE_17833
443@ = Actor.CurrentCar(395@(253@,16i))
04D2: set_plane 443@ fly_autopilot_around_point 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) altitude_between 0.0 and 363@(253@,16f) 

:CPRACE_17883
jump @CPRACE_18116 

:CPRACE_17890
062E: get_actor 395@(253@,16i) task 1560 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @CPRACE_18116 
062E: get_actor 395@(253@,16i) task 1490 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @CPRACE_18116 
if 
   not Car.Wrecked(379@(253@,16i))
else_jump @CPRACE_18068 
05D1: AS_actor 395@(253@,16i) drive_car 379@(253@,16i) to 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) speed 50.0 3 model 716@(253@,16i) 2 
if 
001D:   257@(253@,16i) > 250@ 
else_jump @CPRACE_18061 
03CD: disable_car 379@(253@,16i) stuck_check 

:CPRACE_18061
jump @CPRACE_18116 

:CPRACE_18068
05D1: AS_actor 395@(253@,16i) drive_car -1 to 331@(253@,16f) 347@(253@,16f) 363@(253@,16f) speed 50.0 3 model 716@(253@,16i) 2 

:CPRACE_18116
jump @CPRACE_18576 

:CPRACE_18123
if 
  221@ > 0 
else_jump @CPRACE_18426 

:CPRACE_18141
if 
803C:   not  " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_18419 
if 
838A:   not any_car_in_cube_cornerA 732@ 733@ 734@ cornerB 2.5 2.5 2.5 
else_jump @CPRACE_18419 
257@(253@,16i) = 1 
Marker.Disable(412@(253@,16i))
Car.RemoveReferences(379@(253@,16i))
Actor.RemoveReferences(395@(253@,16i))
0087: 331@(253@,16f) = 732@ 
0087: 347@(253@,16f) = 733@ 
0087: 363@(253@,16f) = 734@ 
0088: " + tempvar_Angle + @" = 735@ 
gosub @CPRACE_488 
395@(253@,16i) = Actor.CreateAsDriver(CivMale, 700@(253@,16i), 379@(253@,16i))
0860: link_actor 395@(253@,16i) to_interior 221@ 
054A: set_actor 395@(253@,16i) can_be_shot_in_a_car 0 
0446: set_actor 395@(253@,16i) dismemberment_possible 0 
0568: set_actor 395@(253@,16i) untargetable 1 
02A9: set_actor 395@(253@,16i) immune_to_nonplayer 1 
039E: set_actor 395@(253@,16i) locked 0 while_in_car 
04D8: set_actor 395@(253@,16i) drowns_in_water 0 
Actor.Health(395@(253@,16i)) = 500
Car.SetSpeedInstantly(379@(253@,16i), 25.0)

:CPRACE_18419
jump @CPRACE_18576 

:CPRACE_18426
if 
803C:   not  " + PlayerActor + @" == 395@(253@,16i) 
else_jump @CPRACE_18576 
if 
  13 > 49@ 
else_jump @CPRACE_18529 
if or
003B:   257@(442@,16i) == 257@(253@,16i) 
001D:   257@(253@,16i) > 257@(442@,16i) 
001D:   257@(253@,16i) > 249@ 
else_jump @CPRACE_18529 
229@ += 1 

:CPRACE_18529
if 
84AD:   not actor 395@(253@,16i) in_water 
else_jump @CPRACE_18576 
Marker.Disable(412@(253@,16i))
Actor.RemoveReferences(395@(253@,16i))
Car.RemoveReferences(379@(253@,16i))

:CPRACE_18576
253@ += 1 
jump @CPRACE_12351 

:CPRACE_18590
if 
  256@ > 1 
else_jump @CPRACE_19517 
038E: draw_box_position " + _6909 + @" " + _6923 + @" size " + _6937 + @" " + _6951 + @" RGBA 0 0 0 255 
038E: draw_box_position " + _6908 + @" " + _6922 + @" size " + _6936 + @" " + _6950 + @" RGBA 134 155 184 255 
038E: draw_box_position " + _6903 + @" " + _6917 + @" size " + _6931 + @" " + _6945 + @" RGBA 0 0 0 255 
if 
  224@ > 1 
else_jump @CPRACE_18950 
038E: draw_box_position " + _6910 + @" " + _6924 + @" size " + _6938 + @" " + _6952 + @" RGBA 0 0 0 255 
038E: draw_box_position " + _6911 + @" " + _6925 + @" size " + _6939 + @" " + _6953 + @" RGBA 134 155 184 255 
038E: draw_box_position " + _6912 + @" " + _6926 + @" size " + _6940 + @" " + _6954 + @" RGBA 0 0 0 255 
0085: 36@ = 273@(442@,16i) 
36@ += 1 
if 
001D:   36@ > 224@ 
else_jump @CPRACE_18816 
0085: 36@ = 224@ 

:CPRACE_18816
gosub @CPRACE_47594 
09FB: " + Current_Language + @" = current_language 
if 
04A3:   " + Current_Language + @" == 2 
else_jump @CPRACE_18863 
" + _6941 + @" = 0.4235 
jump @CPRACE_18908 

:CPRACE_18863
if 
04A3:   " + Current_Language + @" == 4 
else_jump @CPRACE_18898 
" + _6941 + @" = 0.3786 
jump @CPRACE_18908 

:CPRACE_18898
" + _6941 + @" = 0.5 

:CPRACE_18908
033F: set_text_draw_letter_size " + _6941 + @" " + _6955 + @" 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 600.0 
045B: draw_text_2numbers " + _6913 + @" " + _6927 + @" GXT 'RACES32' numbers 36@ 224@  

:CPRACE_18950
0085: 450@ = 229@ 
450@ += 1 
gosub @CPRACE_47594 
if 
  223@ == 1 
else_jump @CPRACE_19002 
0340: set_text_draw_RGBA 180 25 29 255 

:CPRACE_19002
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
if 
  450@ == 1 
else_jump @CPRACE_19045 
033E: set_draw_text_position " + _6904 + @" " + _6918 + @" GXT 'ST'  

:CPRACE_19045
if 
  450@ == 2 
else_jump @CPRACE_19080 
033E: set_draw_text_position " + _6904 + @" " + _6918 + @" GXT 'ND'  

:CPRACE_19080
if 
  450@ == 3 
else_jump @CPRACE_19115 
033E: set_draw_text_position " + _6904 + @" " + _6918 + @" GXT 'RD'  

:CPRACE_19115
if 
  450@ > 3 
else_jump @CPRACE_19150 
033E: set_draw_text_position " + _6904 + @" " + _6918 + @" GXT 'TH'  

:CPRACE_19150
gosub @CPRACE_47594 
if 
  223@ == 1 
else_jump @CPRACE_19187 
0340: set_text_draw_RGBA 180 25 29 255 

:CPRACE_19187
033F: set_text_draw_letter_size " + _6933 + @" " + _6947 + @" 
0342: set_text_draw_centered 1 
045A: draw_text_1number " + _6905 + @" " + _6919 + @" GXT 'NUMBER' number 450@  
gosub @CPRACE_47594 
if 
  223@ == 1 
else_jump @CPRACE_19256 
0340: set_text_draw_RGBA 180 25 29 255 

:CPRACE_19256
033F: set_text_draw_letter_size " + _6934 + @" " + _6948 + @" 
045A: draw_text_1number " + _6906 + @" " + _6920 + @" GXT 'OUT_OF' number 256@  
if 
  13 > 49@ 
else_jump @CPRACE_19326 
008B: 451@ = " + Current_Time_in_ms2 + @" 
0064: 451@ -= " + _6960 + @" 
451@ /= 1000 

:CPRACE_19326
0085: 452@ = 451@ 
452@ /= 60 
if 
  452@ > 99 
else_jump @CPRACE_19366 
452@ = 99 

:CPRACE_19366
0085: 36@ = 452@ 
36@ *= 60 
0085: 453@ = 451@ 
0062: 453@ -= 36@ 
gosub @CPRACE_47594 
if 
  222@ == 1 
else_jump @CPRACE_19434 
0340: set_text_draw_RGBA 180 25 29 255 

:CPRACE_19434
0342: set_text_draw_centered 1 
033F: set_text_draw_letter_size " + _6935 + @" " + _6949 + @" 
if 
  453@ > 9 
else_jump @CPRACE_19494 
045B: draw_text_2numbers " + _6907 + @" " + _6921 + @" GXT 'TIME' numbers 452@ 453@  
jump @CPRACE_19517 

:CPRACE_19494
045B: draw_text_2numbers " + _6907 + @" " + _6921 + @" GXT 'TIME_0' numbers 452@ 453@  

:CPRACE_19517
if 
  " + Race_Index + @" == 7 
else_jump @CPRACE_19542 
gosub @CPRACE_46264 

:CPRACE_19542
if or
  " + Race_Index + @" == 25 
  " + Race_Index + @" == 26 
else_jump @CPRACE_19574 
gosub @CPRACE_50872 

:CPRACE_19574
jump @CPRACE_20805 

:CPRACE_19581
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_19766 
if 
  450@ == 1 
else_jump @CPRACE_19718 
if or
  " + Race_Index + @" == 7 
  " + Race_Index + @" == 8 
else_jump @CPRACE_19649 

:CPRACE_19649
if 
  " + Race_Index + @" == 0 
else_jump @CPRACE_19706 
01E3: show_text_1number_styled GXT 'M_PASS' number 1000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 1000

:CPRACE_19706
Player.ClearWantedLevel(" + PlayerChar + @")
jump @CPRACE_19766 

:CPRACE_19718
if or
  " + Race_Index + @" == 0 
  " + Race_Index + @" == 7 
  " + Race_Index + @" == 8 
else_jump @CPRACE_19766 
00BA: show_text_styled GXT 'M_FAIL' time 3000 style 1  

:CPRACE_19766
014F: stop_timer " + _6960 + @" 
if 
001E:   " + tmp_Races_Current_Best_Time + @"(" + Race_Index + @",30i) > 451@ 
else_jump @CPRACE_19859 
if 
  256@ == 1 
else_jump @CPRACE_19828 
008B: 451@ = " + _6960 + @" 
451@ /= 1000 

:CPRACE_19828
008A: " + tmp_Races_Current_Best_Time + @"(" + Race_Index + @",30i) = 451@ 
042E: downdate_integer_stat 145@(" + Race_Index + @",30i) to 451@ 
222@ = 1 

:CPRACE_19859
if 
  256@ > 1 
else_jump @CPRACE_19931 
if 
001E:   " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) > 450@ 
else_jump @CPRACE_19931 
008A: " + tmp_Races_Best_Result + @"(" + Race_Index + @",30i) = 450@ 
0582: downdate_integer_stat 175@(" + Race_Index + @",30i) to 450@ 
223@ = 1 

:CPRACE_19931
" + _6903 + @" = 208.0665 
" + _6917 + @" = 297.9241 
" + _6931 + @" = 474.2788 
" + _6945 + @" = 383.4714 
" + _6904 + @" = 229.648 
" + _6918 + @" = 313.8785 
" + _6932 + @" = 0.5858 
" + _6946 + @" = 2.5296 
" + _6905 + @" = 455.3051 
" + _6933 + @" = 0.4116 
" + _6920 + @" = 339.1096 
" + _6934 + @" = 0.5858 
gosub @CPRACE_48585 
0084: " + _6960 + @" = " + Current_Time_in_ms2 + @" 
" + _6960 + @" += 8000 
49@ = 14 
jump @CPRACE_20805 

:CPRACE_20088
09FB: " + Current_Language + @" = current_language 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @CPRACE_20126 
0086: " + _6932 + @" = " + _6934 + @" 
jump @CPRACE_20134 

:CPRACE_20126
0086: " + _6932 + @" = " + _6933 + @" 

:CPRACE_20134
if 
  256@ == 1 
else_jump @CPRACE_20202 
0086: " + tempvar_Float_2 + @" = " + _6917 + @" 
" + tempvar_Float_2 + @" += 25.0 
0937: text_draw_box_cornerA " + _6903 + @" " + tempvar_Float_2 + @" cornerB " + _6931 + @" " + _6945 + @" GXT_reference 'DUMMY' style 3 
jump @CPRACE_20277 

:CPRACE_20202
if 
  450@ == 1 
else_jump @CPRACE_20252 
0937: text_draw_box_cornerA " + _6903 + @" " + _6917 + @" cornerB " + _6931 + @" " + _6945 + @" GXT_reference 'RACES18' style 3  
jump @CPRACE_20277 

:CPRACE_20252
0937: text_draw_box_cornerA " + _6903 + @" " + _6917 + @" cornerB " + _6931 + @" " + _6945 + @" GXT_reference 'RACES_8' style 3  

:CPRACE_20277
if 
  256@ > 1 
else_jump @CPRACE_20549 
gosub @CPRACE_47594 
0341: set_text_draw_align_justify 1 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
if 
  223@ == 1 
else_jump @CPRACE_20356 
033E: set_draw_text_position " + _6904 + @" " + _6918 + @" GXT 'TOP_POS'  
jump @CPRACE_20373 

:CPRACE_20356
033E: set_draw_text_position " + _6904 + @" " + _6918 + @" GXT 'RACES30'  

:CPRACE_20373
gosub @CPRACE_47594 
03E4: set_text_draw_align_right 1 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
0340: set_text_draw_RGBA 180 180 180 255 
if 
  450@ == 1 
else_jump @CPRACE_20441 
033E: set_draw_text_position " + _6905 + @" " + _6918 + @" GXT 'RACES26'  

:CPRACE_20441
if 
  450@ == 2 
else_jump @CPRACE_20476 
033E: set_draw_text_position " + _6905 + @" " + _6918 + @" GXT 'RACES27'  

:CPRACE_20476
if 
  450@ == 3 
else_jump @CPRACE_20511 
033E: set_draw_text_position " + _6905 + @" " + _6918 + @" GXT 'RACES28'  

:CPRACE_20511
if 
  450@ > 3 
else_jump @CPRACE_20549 
045A: draw_text_1number " + _6905 + @" " + _6918 + @" GXT 'RACES29' number 450@  

:CPRACE_20549
gosub @CPRACE_47594 
0341: set_text_draw_align_justify 1 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
if 
  222@ == 1 
else_jump @CPRACE_20610 
033E: set_draw_text_position " + _6904 + @" " + _6920 + @" GXT 'TOPTIME'  
jump @CPRACE_20627 

:CPRACE_20610
033E: set_draw_text_position " + _6904 + @" " + _6920 + @" GXT 'RACES31'  

:CPRACE_20627
0085: 452@ = 451@ 
452@ /= 60 
0085: 36@ = 452@ 
36@ *= 60 
0085: 453@ = 451@ 
0062: 453@ -= 36@ 
gosub @CPRACE_47594 
03E4: set_text_draw_align_right 1 
033F: set_text_draw_letter_size " + _6932 + @" " + _6946 + @" 
0340: set_text_draw_RGBA 180 180 180 255 
if 
  453@ > 9 
else_jump @CPRACE_20754 
045B: draw_text_2numbers " + _6905 + @" " + _6920 + @" GXT 'TIME' numbers 452@ 453@  
jump @CPRACE_20777 

:CPRACE_20754
045B: draw_text_2numbers " + _6905 + @" " + _6920 + @" GXT 'TIME_0' numbers 452@ 453@  

:CPRACE_20777
if 
001C:   " + Current_Time_in_ms2 + @" > " + _6960 + @" 
else_jump @CPRACE_20798 
return 

:CPRACE_20798
jump @CPRACE_20805 

:CPRACE_20805
jump @CPRACE_2634 

:CPRACE_20812
0871: init_jump_table " + Race_Index + @" total_jumps 27 default_jump 0 @CPRACE_46262 jumps 0 @CPRACE_21070 1 @CPRACE_21616 2 @CPRACE_22058 3 @CPRACE_22740 4 @CPRACE_23422 5 @CPRACE_24164 6 @CPRACE_25116 
0872: jump_table_jumps 7 @CPRACE_26038 8 @CPRACE_27092 9 @CPRACE_28206 10 @CPRACE_28894 11 @CPRACE_29612 12 @CPRACE_30204 13 @CPRACE_30802 14 @CPRACE_32150 15 @CPRACE_33528 
0872: jump_table_jumps 16 @CPRACE_34456 17 @CPRACE_35318 18 @CPRACE_36240 19 @CPRACE_36982 20 @CPRACE_38120 21 @CPRACE_40068 22 @CPRACE_42256 23 @CPRACE_43154 24 @CPRACE_44052 
0872: jump_table_jumps 25 @CPRACE_44980 26 @CPRACE_45529 -1 @CPRACE_46262 -1 @CPRACE_46262 -1 @CPRACE_46262 -1 @CPRACE_46262 -1 @CPRACE_46262 -1 @CPRACE_46262 -1 @CPRACE_46262 

:CPRACE_21070
454@ = 1492.407 
536@ = -1872.365 
618@ = 15.8 
455@ = 1384.263 
537@ = -1872.015 
619@ = 12.3828 
456@ = 1075.442 
538@ = -1851.978 
620@ = 12.391 
457@ = 647.3663 
539@ = -1734.185 
621@ = 12.4844 
458@ = 627.2474 
540@ = -1228.55 
622@ = 16.9893 
459@ = 497.0043 
541@ = -1282.818 
623@ = 14.6513 
460@ = 500.412 
542@ = -1326.649 
624@ = 14.8178 
461@ = 401.0033 
543@ = -1404.457 
625@ = 32.8973 
462@ = 420.3067 
544@ = -1450.714 
626@ = 29.5842 
463@ = 329.1244 
545@ = -1631.112 
627@ = 32.1247 
464@ = 366.4376 
546@ = -1647.349 
628@ = 31.7176 
465@ = 369.98 
547@ = -2030.34 
629@ = 5.55 
250@ = 12 
256@ = 6 
04AF: 700@ = 133 
04AF: 701@ = 217 
04AF: 702@ = 157 
04AF: 703@ = 248 
04AF: 704@ = 290 
04AF: 705@ = 7 
04AF: 716@ = 517 
04AF: 717@ = 534 
04AF: 718@ = 517 
04AF: 719@ = 536 
04AF: 720@ = 567 
04AF: 721@ = 536 
209@ = 6 
215@ = 0 
210@ = 8 
216@ = 0 
211@ = 2 
217@ = 1 
212@ = 0 
218@ = 0 
213@ = 3 
219@ = 3 
jump @CPRACE_46262 

:CPRACE_21616
454@ = 2875.192 
536@ = -1458.85 
618@ = 10.5892 
455@ = 2875.362 
537@ = -1404.768 
619@ = 10.7143 
456@ = 2797.037 
538@ = -1291.152 
620@ = 41.389 
457@ = 2609.984 
539@ = -1256.458 
621@ = 47.9322 
458@ = 2371.282 
540@ = -1280.477 
622@ = 23.6341 
459@ = 2450.557 
541@ = -1444.24 
623@ = 23.6318 
460@ = 2618.436 
542@ = -1444.826 
624@ = 31.6234 
461@ = 2657.3 
543@ = -1404.327 
625@ = 30.0795 
462@ = 2680.506 
544@ = -1489.556 
626@ = 30.2098 
463@ = 2755.952 
545@ = -1488.515 
627@ = 29.3812 
0087: 464@ = 454@ 
0087: 546@ = 536@ 
0087: 628@ = 618@ 
250@ = 11 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 461 
04AF: 717@ = 521 
04AF: 718@ = 522 
04AF: 719@ = 461 
04AF: 720@ = 521 
04AF: 721@ = 522 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_22058
454@ = 261.7816 
536@ = -1243.111 
618@ = 71.8851 
455@ = 312.9973 
537@ = -1206.853 
619@ = 74.9057 
456@ = 440.3485 
538@ = -1186.672 
620@ = 67.2076 
457@ = 623.8817 
539@ = -1109.967 
621@ = 45.6186 
458@ = 745.0934 
540@ = -951.0351 
622@ = 53.766 
459@ = 873.6384 
541@ = -860.0975 
623@ = 76.5242 
460@ = 1053.818 
542@ = -777.5837 
624@ = 104.7803 
461@ = 1248.368 
543@ = -731.3474 
625@ = 93.7346 
462@ = 1372.402 
544@ = -675.6946 
626@ = 92.6217 
463@ = 1328.011 
545@ = -583.8703 
627@ = 93.4113 
464@ = 1167.315 
546@ = -633.0795 
628@ = 102.7501 
465@ = 968.4116 
547@ = -646.252 
629@ = 120.7201 
466@ = 791.077 
548@ = -800.4396 
630@ = 65.0537 
467@ = 620.9355 
549@ = -905.8031 
631@ = 62.1261 
468@ = 454.9853 
550@ = -1013.546 
632@ = 92.0091 
469@ = 276.8912 
551@ = -1104.159 
633@ = 80.0612 
470@ = 141.6012 
552@ = -1247.267 
634@ = 43.792 
471@ = 192.4688 
553@ = -1380.597 
635@ = 47.6608 
0087: 472@ = 454@ 
0087: 554@ = 536@ 
0087: 636@ = 618@ 
250@ = 19 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 461 
04AF: 717@ = 521 
04AF: 718@ = 522 
04AF: 719@ = 461 
04AF: 720@ = 521 
04AF: 721@ = 521 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_22740
454@ = 1927.48 
536@ = -1515.516 
618@ = 2.2978 
455@ = 2018.401 
537@ = -1515.405 
619@ = 2.4054 
456@ = 2179.006 
538@ = -1559.661 
620@ = 1.1797 
457@ = 2370.138 
539@ = -1619.553 
621@ = 7.3323 
458@ = 2570.841 
540@ = -1619.056 
622@ = 17.6841 
459@ = 2756.846 
541@ = -1657.173 
623@ = 11.5191 
460@ = 2915.178 
542@ = -1534.362 
624@ = 9.875 
461@ = 2916.228 
543@ = -1333.491 
625@ = 9.875 
462@ = 2819.331 
544@ = -1142.638 
626@ = 15.7018 
463@ = 2622.646 
545@ = -1152.872 
627@ = 50.4181 
464@ = 2423.186 
546@ = -1154.169 
628@ = 30.5642 
465@ = 2167.046 
547@ = -1101.915 
629@ = 24.3864 
466@ = 2006.077 
548@ = -1027.839 
630@ = 34.3152 
467@ = 1835.824 
549@ = -991.5906 
631@ = 35.8824 
468@ = 1636.313 
550@ = -1005.15 
632@ = 49.8831 
469@ = 1617.024 
551@ = -1215.833 
633@ = 51.0566 
470@ = 1577.972 
552@ = -1417.831 
634@ = 27.6154 
471@ = 1722.823 
553@ = -1525.932 
635@ = 18.3927 
0087: 472@ = 454@ 
0087: 554@ = 536@ 
0087: 636@ = 618@ 
250@ = 19 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 461 
04AF: 717@ = 521 
04AF: 718@ = 522 
04AF: 719@ = 461 
04AF: 720@ = 521 
04AF: 721@ = 521 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_23422
454@ = 1357.656 
536@ = -1361.671 
618@ = 12.3828 
455@ = 1357.689 
537@ = -1186.404 
619@ = 20.2744 
456@ = 1369.741 
538@ = -1000.526 
620@ = 27.02 
457@ = 1505.818 
539@ = -868.7814 
621@ = 61.0462 
458@ = 1452.794 
540@ = -711.5325 
622@ = 89.8766 
459@ = 1253.572 
541@ = -729.2587 
623@ = 93.4292 
460@ = 1059.306 
542@ = -775.9847 
624@ = 105.3241 
461@ = 878.665 
543@ = -858.1913 
625@ = 76.8826 
462@ = 721.7916 
544@ = -980.4561 
626@ = 51.9555 
463@ = 571.0251 
545@ = -1045.203 
627@ = 72.2876 
464@ = 373.2952 
546@ = -1075.644 
628@ = 72.8049 
465@ = 288.4963 
547@ = -1249.747 
629@ = 72.721 
466@ = 481.2224 
548@ = -1240.976 
630@ = 19.3512 
467@ = 518.334 
549@ = -1377.603 
631@ = 14.9457 
468@ = 448.0064 
550@ = -1540.832 
632@ = 27.8796 
469@ = 487.4595 
551@ = -1661.575 
633@ = 20.74 
470@ = 687.2253 
552@ = -1673.48 
634@ = 10.7959 
471@ = 866.4786 
553@ = -1584.698 
635@ = 12.3828 
472@ = 1066.729 
554@ = -1572.305 
636@ = 12.375 
473@ = 1261.214 
555@ = -1572.243 
637@ = 12.3906 
0087: 474@ = 454@ 
0087: 556@ = 536@ 
0087: 638@ = 618@ 
250@ = 21 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 558 
04AF: 717@ = 555 
04AF: 718@ = 496 
04AF: 719@ = 555 
04AF: 720@ = 405 
04AF: 721@ = 550 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_24164
454@ = 852.0544 
536@ = -1405.622 
618@ = 12.217 
455@ = 1102.789 
537@ = -1405.766 
619@ = 12.428 
456@ = 1353.038 
538@ = -1405.544 
620@ = 12.3251 
457@ = 1600.965 
539@ = -1440.852 
621@ = 12.3828 
458@ = 1850.622 
540@ = -1461.777 
622@ = 12.3984 
454@ = 831.7679 
536@ = -1405.588 
618@ = 12.3849 
455@ = 1031.822 
537@ = -1405.615 
619@ = 12.0966 
456@ = 1232.144 
538@ = -1405.732 
620@ = 12.0633 
457@ = 1429.508 
539@ = -1439.091 
621@ = 12.3828 
458@ = 1630.18 
540@ = -1440.858 
622@ = 12.3828 
459@ = 1829.527 
541@ = -1460.804 
623@ = 12.3448 
460@ = 2029.979 
542@ = -1463.381 
624@ = 14.4553 
461@ = 2175.823 
543@ = -1384.403 
625@ = 22.8281 
462@ = 2342.427 
544@ = -1442.324 
626@ = 22.8281 
463@ = 2191.875 
545@ = -1545.934 
627@ = 1.1724 
464@ = 1997.078 
546@ = -1499.951 
628@ = 2.3804 
465@ = 1797.065 
547@ = -1500.874 
629@ = 6.8307 
466@ = 1641.002 
548@ = -1439.345 
630@ = 27.0747 
467@ = 1627.555 
549@ = -1280.703 
631@ = 41.885 
468@ = 1683.507 
550@ = -1089.012 
632@ = 55.7917 
469@ = 1566.054 
551@ = -927.5945 
633@ = 42.7541 
470@ = 1366.105 
552@ = -933.6759 
634@ = 33.1953 
471@ = 1166.087 
553@ = -941.9011 
635@ = 41.8697 
472@ = 966.715 
554@ = -962.2038 
636@ = 38.1905 
473@ = 784.2582 
555@ = -1043.979 
637@ = 23.6177 
474@ = 677.2552 
556@ = -1164.128 
638@ = 14.164 
475@ = 627.7037 
557@ = -1337.904 
639@ = 12.4227 
0087: 476@ = 454@ 
0087: 558@ = 536@ 
0087: 640@ = 618@ 
250@ = 23 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 429 
04AF: 717@ = 541 
04AF: 718@ = 402 
04AF: 719@ = 429 
04AF: 720@ = 541 
04AF: 721@ = 506 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_25116
454@ = 1331.926 
536@ = -2280.51 
618@ = 13.1732 
455@ = 1331.775 
537@ = -2541.682 
619@ = 13.1765 
456@ = 1544.309 
538@ = -2684.983 
620@ = 7.5074 
457@ = 1945.947 
539@ = -2685.131 
621@ = 6.5549 
458@ = 2175.141 
540@ = -2557.994 
622@ = 13.173 
459@ = 2352.719 
541@ = -2222.223 
623@ = 13.1737 
460@ = 2740.522 
542@ = -2168.782 
624@ = 10.7349 
461@ = 2844.832 
543@ = -1812.965 
625@ = 10.6737 
462@ = 2926.094 
544@ = -1421.263 
626@ = 10.657 
463@ = 2888.946 
545@ = -1022.685 
627@ = 10.6607 
464@ = 2896.483 
546@ = -621.0989 
628@ = 10.63 
465@ = 2718.623 
547@ = -273.2495 
629@ = 27.6705 
466@ = 2774.299 
548@ = 119.9424 
630@ = 22.8712 
467@ = 2612.82 
549@ = 327.3945 
631@ = 25.6764 
468@ = 2213.983 
550@ = 324.9601 
632@ = 32.5307 
469@ = 1817.184 
551@ = 278.3323 
633@ = 21.5314 
470@ = 1621.185 
552@ = 312.8743 
634@ = 20.8534 
471@ = 1608.029 
553@ = 372.27 
635@ = 26.4284 
472@ = 1658.672 
554@ = 317.3336 
636@ = 30.0474 
473@ = 1651.536 
555@ = -68.8376 
637@ = 35.9156 
474@ = 1668.653 
556@ = -369.1116 
638@ = 34.3923 
475@ = 1699.785 
557@ = -665.8258 
639@ = 43.3311 
476@ = 1640.03 
558@ = -1062.329 
640@ = 60.8035 
477@ = 1594.408 
559@ = -1457.834 
641@ = 28.3679 
478@ = 1622.355 
560@ = -1856.505 
642@ = 25.4707 
479@ = 1452.159 
561@ = -2117.271 
643@ = 13.1726 
0087: 480@ = 454@ 
0087: 562@ = 536@ 
0087: 644@ = 618@ 
250@ = 27 
256@ = 4 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 451 
04AF: 717@ = 429 
04AF: 718@ = 415 
04AF: 719@ = 541 
04AF: 720@ = 451 
04AF: 721@ = 411 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_26038
454@ = 1559.983 
536@ = 17.468 
618@ = 26.1563 
455@ = 1556.426 
537@ = -94.0345 
619@ = 19.4957 
456@ = 1434.738 
538@ = -214.9645 
620@ = 7.3527 
457@ = 1321.254 
539@ = -195.8984 
621@ = 15.7447 
458@ = 1211.007 
540@ = -102.6927 
622@ = 39.3603 
459@ = 892.2923 
541@ = -88.1123 
623@ = 22.4405 
460@ = 789.9247 
542@ = -124.3171 
624@ = 21.3365 
461@ = 659.6545 
543@ = -196.7497 
625@ = 11.7663 
462@ = 419.4744 
544@ = -302.5507 
626@ = 6.446 
463@ = 289.8085 
545@ = -380.3828 
627@ = 7.8753 
464@ = 207.4451 
546@ = -298.923 
628@ = 0.4375 
465@ = 182.497 
547@ = -217.8004 
629@ = 0.4216 
466@ = 22.0727 
548@ = -207.7681 
630@ = 0.5827 
467@ = -114.231 
549@ = -132.3417 
631@ = 2.1236 
468@ = -38.4818 
550@ = 140.8613 
632@ = 2.1234 
469@ = -141.4718 
551@ = 187.6611 
633@ = 6.2406 
470@ = -329.7878 
552@ = 173.921 
634@ = 5.403 
471@ = -507.6872 
553@ = 221.0444 
635@ = 8.7633 
472@ = -661.1096 
554@ = 226.3879 
636@ = 16.7064 
473@ = -618.4406 
555@ = -67.8995 
637@ = 62.3489 
474@ = -507.8417 
556@ = -45.9077 
638@ = 59.2556 
475@ = -520.6511 
557@ = 79.6011 
639@ = 32.2117 
476@ = -715.4454 
558@ = 225.1288 
640@ = 0.2899 
477@ = -770.0811 
559@ = 130.1324 
641@ = 9.4651 
478@ = -738.1151 
560@ = 25.555 
642@ = 32.2336 
479@ = -885.785 
561@ = -41.3927 
643@ = 33.2347 
480@ = -716.4521 
562@ = 5.1206 
644@ = 59.1055 
481@ = -759.2693 
563@ = -92.0455 
645@ = 64.8686 
482@ = -826.881 
564@ = -167.7603 
646@ = 64.99 
483@ = -728.9467 
565@ = -173.5218 
647@ = 65.1248 
484@ = -544.8638 
566@ = -189.4458 
648@ = 77.8383 
250@ = 31 
256@ = 4 
04AF: 700@ = 101 
04AF: 701@ = 23 
04AF: 702@ = 290 
04AF: 703@ = 7 
04AF: 716@ = 439 
04AF: 717@ = 475 
04AF: 718@ = 526 
04AF: 719@ = 475 
209@ = 4 
215@ = 80 
210@ = 3 
216@ = 80 
211@ = 5 
217@ = 80 
jump @CPRACE_46262 

:CPRACE_27092
454@ = -544.8638 
536@ = -189.4458 
618@ = 81.8383 
455@ = -728.9467 
537@ = -173.5218 
619@ = 65.1248 
456@ = -826.881 
538@ = -167.7603 
620@ = 64.99 
457@ = -759.2693 
539@ = -92.0455 
621@ = 64.8686 
458@ = -716.4521 
540@ = 5.1206 
622@ = 59.1055 
459@ = -885.785 
541@ = -41.3927 
623@ = 33.2347 
460@ = -738.1151 
542@ = 25.555 
624@ = 32.2336 
461@ = -770.0811 
543@ = 130.1324 
625@ = 9.4651 
462@ = -715.4454 
544@ = 225.1288 
626@ = 0.2899 
463@ = -624.6024 
545@ = 187.2405 
627@ = 15.4381 
464@ = -520.6511 
546@ = 79.6011 
628@ = 32.2117 
465@ = -507.8417 
547@ = -45.9077 
629@ = 59.2556 
466@ = -618.4406 
548@ = -67.8995 
630@ = 62.3489 
467@ = -658.3503 
549@ = 146.4855 
631@ = 28.2693 
468@ = -507.6872 
550@ = 221.0444 
632@ = 8.7633 
469@ = -329.7878 
551@ = 173.921 
633@ = 5.5 
470@ = -149.4881 
552@ = 189.6471 
634@ = 7.2644 
471@ = -38.4818 
553@ = 140.8613 
635@ = 2.1234 
472@ = -114.231 
554@ = -132.3417 
636@ = 2.1236 
473@ = 22.0727 
555@ = -207.7681 
637@ = 0.5827 
474@ = 182.497 
556@ = -217.8004 
638@ = 0.4216 
475@ = 207.4451 
557@ = -298.923 
639@ = 0.4375 
476@ = 279.6441 
558@ = -378.3416 
640@ = 7.9003 
477@ = 419.4744 
559@ = -302.5507 
641@ = 6.446 
478@ = 573.52 
560@ = -202.8494 
642@ = 13.7118 
479@ = 748.4567 
561@ = -150.8298 
643@ = 18.3722 
480@ = 820.4231 
562@ = -111.5991 
644@ = 23.2476 
481@ = 1000.325 
563@ = -80.3516 
645@ = 21.0326 
482@ = 1187.393 
564@ = -83.879 
646@ = 35.2576 
483@ = 1265.847 
565@ = -153.0857 
647@ = 36.8097 
484@ = 1434.738 
566@ = -214.9645 
648@ = 7.3527 
485@ = 1548.963 
567@ = -146.2702 
649@ = 16.4932 
486@ = 1559.983 
568@ = 17.468 
650@ = 23.1563 
250@ = 33 
256@ = 4 
04AF: 700@ = 101 
04AF: 701@ = 23 
04AF: 702@ = 290 
04AF: 703@ = 7 
04AF: 716@ = 477 
04AF: 717@ = 560 
04AF: 718@ = 562 
04AF: 719@ = 477 
209@ = 4 
215@ = 80 
210@ = 3 
216@ = 80 
211@ = 5 
217@ = 80 
jump @CPRACE_46262 

:CPRACE_28206
454@ = -796.8273 
536@ = -2468.529 
618@ = 83.6549 
455@ = -938.5198 
537@ = -2364.511 
619@ = 57.0608 
456@ = -1065.656 
538@ = -2379.436 
620@ = 46.5486 
457@ = -1247.823 
539@ = -2313.528 
621@ = 19.8007 
458@ = -1356.137 
540@ = -2180.365 
622@ = 21.3467 
459@ = -1541.303 
541@ = -2154.782 
623@ = 5.8607 
460@ = -1674.876 
542@ = -2235.132 
624@ = 33.8691 
461@ = -1839.937 
543@ = -2349.368 
625@ = 31.9587 
462@ = -1841.037 
544@ = -2454.4 
626@ = 27.4044 
463@ = -1702.044 
545@ = -2587.976 
627@ = 26.1706 
464@ = -1508.332 
546@ = -2634.733 
628@ = 46.8766 
465@ = -1310.905 
547@ = -2637.832 
629@ = 12.808 
466@ = -1122.617 
548@ = -2652.592 
630@ = 15.4117 
467@ = -934.2363 
549@ = -2668.473 
631@ = 80.3479 
468@ = -753.5882 
550@ = -2672.785 
632@ = 84.0788 
469@ = -668.018 
551@ = -2496.988 
633@ = 37.5787 
470@ = -550.4019 
552@ = -2334.539 
634@ = 26.8502 
471@ = -366.3848 
553@ = -2257.25 
635@ = 41.7144 
472@ = -276.1146 
554@ = -2189.364 
636@ = 27.7264 
250@ = 19 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 468 
04AF: 717@ = 468 
04AF: 718@ = 468 
04AF: 719@ = 468 
04AF: 720@ = 468 
04AF: 721@ = 468 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_28894
454@ = -1936.791 
536@ = -2452.235 
618@ = 29.6377 
455@ = -1862.54 
537@ = -2379.437 
619@ = 30.1425 
456@ = -1690.144 
538@ = -2303.846 
620@ = 43.3626 
457@ = -1676.317 
539@ = -2132.699 
621@ = 35.2082 
458@ = -1855.421 
540@ = -2087.117 
622@ = 58.3697 
459@ = -1919.802 
541@ = -1937.457 
623@ = 78.5313 
460@ = -1749.334 
542@ = -1899.519 
624@ = 95.8199 
461@ = -1571.292 
543@ = -1904.166 
625@ = 84.3076 
462@ = -1483.784 
544@ = -1783.286 
626@ = 49.8768 
463@ = -1429.878 
545@ = -1915.641 
627@ = 25.1751 
464@ = -1301.801 
546@ = -2084.054 
628@ = 22.9116 
465@ = -1269.913 
547@ = -2248.736 
629@ = 21.3152 
466@ = -1146.514 
548@ = -2371.508 
630@ = 27.0467 
467@ = -959.5773 
549@ = -2306.27 
631@ = 56.1859 
468@ = -867.9595 
550@ = -2180.891 
632@ = 25.6567 
469@ = -843.4177 
551@ = -2018.734 
633@ = 20.9828 
470@ = -767.7295 
552@ = -1865.533 
634@ = 11.4149 
471@ = -666.3682 
553@ = -1996.276 
635@ = 23.9143 
472@ = -486.6196 
554@ = -2025.765 
636@ = 48.245 
473@ = -323.4612 
555@ = -1914.206 
637@ = 11.1951 
250@ = 20 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 568 
04AF: 717@ = 568 
04AF: 718@ = 568 
04AF: 719@ = 568 
04AF: 720@ = 568 
04AF: 721@ = 568 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_29612
454@ = -2728.309 
536@ = -310.8731 
618@ = 6.0391 
455@ = -2668.671 
537@ = -251.6207 
619@ = 5.4984 
456@ = -2655.978 
538@ = -104.6751 
620@ = 2.9982 
457@ = -2460.835 
539@ = -69.9766 
621@ = 31.2 
458@ = -2421.263 
540@ = 55.6089 
622@ = 34.0156 
459@ = -2545.26 
541@ = 137.9111 
623@ = 15.2177 
460@ = -2604.136 
542@ = 136.8579 
624@ = 3.1797 
461@ = -2558.661 
543@ = 245.625 
625@ = 10.7931 
462@ = -2578.504 
544@ = 345.8331 
626@ = 7.2168 
463@ = -2706.282 
545@ = 317.6024 
627@ = 3.1797 
464@ = -2809.244 
546@ = 232.3965 
628@ = 6.0313 
465@ = -2757.749 
547@ = 138.2248 
629@ = 5.9033 
466@ = -2758.39 
548@ = -43.991 
630@ = 6.1263 
467@ = -2756.892 
549@ = -184.0135 
631@ = 5.8843 
468@ = -2812.464 
550@ = -299.5974 
632@ = 6.039 
0087: 469@ = 454@ 
0087: 551@ = 536@ 
0087: 633@ = 618@ 
250@ = 16 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 571 
04AF: 717@ = 571 
04AF: 718@ = 571 
04AF: 719@ = 571 
04AF: 720@ = 571 
04AF: 721@ = 571 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_30204
454@ = -2657.164 
536@ = 1153.872 
618@ = 34.7396 
455@ = -2593.221 
537@ = 1217.854 
619@ = 34.7402 
456@ = -2312.288 
538@ = 1176.387 
620@ = 49.608 
457@ = -2157.193 
539@ = 1268.197 
621@ = 26.0127 
458@ = -1959.526 
540@ = 1287.205 
622@ = 6.7514 
459@ = -1741.076 
541@ = 1325.298 
623@ = 6.083 
460@ = -1759.865 
542@ = 1269.147 
624@ = 8.8598 
461@ = -1884.242 
543@ = 1160.691 
625@ = 45.0107 
462@ = -1897.101 
544@ = 960.1686 
626@ = 34.7366 
463@ = -1998.178 
545@ = 841.1865 
627@ = 45.0219 
464@ = -2189.259 
546@ = 808.5273 
628@ = 56.0602 
465@ = -2389.186 
547@ = 808.6409 
629@ = 34.7495 
466@ = -2589.692 
548@ = 808.5219 
630@ = 49.5411 
467@ = -2711.488 
549@ = 812.8809 
631@ = 48.9309 
468@ = -2750.894 
550@ = 890.6993 
632@ = 65.8952 
469@ = -2653.912 
551@ = 1157.345 
633@ = 34.7386 
250@ = 16 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 559 
04AF: 717@ = 589 
04AF: 718@ = 559 
04AF: 719@ = 565 
04AF: 720@ = 558 
04AF: 721@ = 602 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_30802
454@ = -1584.141 
536@ = 1053.439 
618@ = 6.8392 
455@ = -1584.128 
537@ = 1150.261 
619@ = 6.8387 
456@ = -1699.077 
538@ = 1312.02 
620@ = 6.8293 
457@ = -1875.891 
539@ = 1352.059 
621@ = 6.8322 
458@ = -2060.741 
540@ = 1274.452 
622@ = 8.0659 
459@ = -2258.306 
541@ = 1257.682 
623@ = 42.6038 
460@ = -2143.281 
542@ = 1075.652 
624@ = 79.1249 
461@ = -2143.141 
543@ = 896.6196 
625@ = 79.6432 
462@ = -2143.084 
544@ = 696.6971 
626@ = 67.6451 
463@ = -2146.737 
545@ = 532.8465 
627@ = 34.8181 
464@ = -2055.564 
546@ = 504.0781 
628@ = 34.8168 
465@ = -1968.175 
547@ = 605.5881 
629@ = 34.8199 
466@ = -1820.393 
548@ = 475.0548 
630@ = 23.4295 
467@ = -1876.903 
549@ = 288.4981 
631@ = 32.6699 
468@ = -1897.585 
550@ = 87.7896 
632@ = 37.9384 
469@ = -1911.151 
551@ = -214.2394 
633@ = 38.032 
470@ = -1910.974 
552@ = -515.5727 
634@ = 38.0323 
471@ = -1910.675 
553@ = -816.3037 
635@ = 44.7432 
472@ = -1910.658 
554@ = -1117.409 
636@ = 38.0214 
473@ = -1907.276 
555@ = -1317.626 
637@ = 39.3164 
474@ = -1996.896 
556@ = -1289.264 
638@ = 37.3518 
475@ = -2153.53 
557@ = -1031.597 
639@ = 32.3638 
476@ = -2205.567 
558@ = -859.1885 
640@ = 54.6872 
477@ = -2202.666 
559@ = -759.2505 
641@ = 62.3413 
478@ = -2352.255 
560@ = -775.5399 
642@ = 95.1597 
479@ = -2421.544 
561@ = -610.6656 
643@ = 132.3493 
480@ = -2627.138 
562@ = -496.4363 
644@ = 70.09 
481@ = -2351.247 
563@ = -460.0875 
645@ = 79.9485 
482@ = -2599.996 
564@ = -372.7368 
646@ = 43.7794 
483@ = -2702.314 
565@ = -530.1367 
647@ = 12.4366 
484@ = -2699.197 
566@ = -401.205 
648@ = 7.7008 
485@ = -2210.255 
567@ = -348.0724 
649@ = 36.8384 
486@ = -1897.734 
568@ = -314.4976 
650@ = 48.9384 
487@ = -1890.36 
569@ = -45.4288 
651@ = 38.0312 
488@ = -1886.557 
570@ = 55.293 
652@ = 38.0326 
489@ = -1848.039 
571@ = 242.5393 
653@ = 30.825 
490@ = -1736.635 
572@ = 316.5836 
654@ = 6.039 
491@ = -1682.981 
573@ = 367.1342 
655@ = 6.028 
492@ = -1559.293 
574@ = 528.332 
656@ = 6.8409 
493@ = -1535.552 
575@ = 827.4427 
657@ = 6.8401 
494@ = -1584.129 
576@ = 1115.601 
658@ = 6.8376 
250@ = 41 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 402 
04AF: 717@ = 560 
04AF: 718@ = 506 
04AF: 719@ = 506 
04AF: 720@ = 477 
04AF: 721@ = 603 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_32150
454@ = -1761.655 
536@ = -606.3881 
618@ = 15.8961 
455@ = -1760.54 
537@ = -686.4133 
619@ = 24.2389 
456@ = -1502.876 
538@ = -820.2545 
620@ = 61.3357 
457@ = -1219.332 
539@ = -759.4814 
621@ = 62.0285 
458@ = -1096.152 
540@ = -489.1358 
622@ = 32.7156 
459@ = -911.5416 
541@ = -455.9558 
623@ = 26.7166 
460@ = -621.3364 
542@ = -393.158 
624@ = 22.1878 
461@ = -395.5605 
543@ = -533.522 
625@ = 17.6561 
462@ = -372.2669 
544@ = -819.4839 
626@ = 28.1926 
463@ = -584.5377 
545@ = -1160.572 
627@ = 21.8153 
464@ = -659.3533 
546@ = -1548.814 
628@ = 22.1495 
465@ = -717.1517 
547@ = -1697.205 
629@ = 48.2586 
466@ = -714.6181 
548@ = -1395.094 
630@ = 60.5799 
467@ = -764.046 
549@ = -1385.027 
631@ = 82.2146 
468@ = -762.7014 
550@ = -1685.041 
632@ = 96.9103 
469@ = -945.4141 
551@ = -1903.227 
633@ = 81.3436 
470@ = -1104.541 
552@ = -2155.325 
634@ = 34.6761 
471@ = -1186.201 
553@ = -2444.541 
635@ = 54.4532 
472@ = -982.3237 
554@ = -2611.624 
636@ = 86.253 
473@ = -713.2529 
555@ = -2336.617 
637@ = 36.4201 
474@ = -512.3461 
556@ = -2166.417 
638@ = 53.5212 
475@ = -258.5978 
557@ = -2074.872 
639@ = 36.648 
476@ = -260.1367 
558@ = -1777.191 
640@ = 7.5735 
477@ = -57.3444 
559@ = -1601.375 
641@ = 1.3776 
478@ = -124.296 
560@ = -1466.575 
642@ = 2.4045 
479@ = -143.4815 
561@ = -1270.317 
643@ = 2.404 
480@ = -113.7683 
562@ = -998.821 
644@ = 23.9178 
481@ = -377.3843 
563@ = -838.2166 
645@ = 47.1444 
482@ = -626.0056 
564@ = -989.012 
646@ = 66.0268 
483@ = -877.4561 
565@ = -1097.426 
647@ = 96.1699 
484@ = -925.9376 
566@ = -1391.353 
648@ = 126.2905 
485@ = -1219.141 
567@ = -1347.249 
649@ = 122.5235 
486@ = -1407.723 
568@ = -1414.45 
650@ = 104.9232 
487@ = -1577.013 
569@ = -1168.802 
651@ = 102.3586 
488@ = -1626.067 
570@ = -882.9627 
652@ = 97.5243 
489@ = -1744.303 
571@ = -853.2858 
653@ = 77.1834 
490@ = -1684.612 
572@ = -1143.291 
654@ = 72.4364 
491@ = -1549.538 
573@ = -1286.347 
655@ = 57.1135 
492@ = -1525.757 
574@ = -1383.531 
656@ = 45.1796 
493@ = -1626.142 
575@ = -1375.587 
657@ = 45.2062 
494@ = -1800.174 
576@ = -1016.79 
658@ = 51.6322 
495@ = -1817.478 
577@ = -617.6195 
659@ = 15.9507 
250@ = 42 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 451 
04AF: 717@ = 415 
04AF: 718@ = 411 
04AF: 719@ = 451 
04AF: 720@ = 429 
04AF: 721@ = 541 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_33528
454@ = -2001.856 
536@ = 1076.302 
618@ = 54.5637 
455@ = -2302.386 
537@ = 1076.754 
619@ = 54.5859 
456@ = -2596.785 
538@ = 1136.728 
620@ = 54.4297 
457@ = -2673.767 
539@ = 1427.293 
621@ = 54.4271 
458@ = -2673.775 
540@ = 1728.239 
622@ = 66.8937 
459@ = -2673.807 
541@ = 2028.896 
623@ = 57.2377 
460@ = -2731.742 
542@ = 2323.183 
624@ = 67.5411 
461@ = -2622.094 
543@ = 2602.597 
625@ = 68.7 
462@ = -2322.772 
544@ = 2637.1 
626@ = 53.2135 
463@ = -2027.122 
545@ = 2585.865 
627@ = 53.9804 
464@ = -1885.621 
546@ = 2321.522 
628@ = 38.5395 
465@ = -1675.296 
547@ = 2107.697 
629@ = 17.3995 
466@ = -1629.976 
548@ = 1810.828 
630@ = 11.059 
467@ = -1347.988 
549@ = 1705.67 
631@ = 4.8179 
468@ = -1125.87 
550@ = 1504.095 
632@ = 22.1877 
469@ = -1010.766 
551@ = 1227.044 
633@ = 31.1773 
470@ = -908.7908 
552@ = 944.9431 
634@ = 17.337 
471@ = -744.0402 
553@ = 694.0286 
635@ = 16.9982 
472@ = -469.1425 
554@ = 573.061 
636@ = 16.0649 
473@ = -168.3162 
555@ = 562.0268 
637@ = 14.9046 
474@ = 110.1296 
556@ = 673.4105 
638@ = 4.6336 
475@ = 400.681 
557@ = 749.8367 
639@ = 5.0607 
476@ = 686.3097 
558@ = 656.6995 
640@ = 7.8963 
477@ = 975.3585 
559@ = 738.1249 
641@ = 9.6719 
478@ = 1242.045 
560@ = 876.267 
642@ = 13.1519 
479@ = 1226.81 
561@ = 1169.877 
643@ = 5.8125 
480@ = 1226.664 
562@ = 1469.936 
644@ = 5.742 
250@ = 27 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 451 
04AF: 717@ = 415 
04AF: 718@ = 411 
04AF: 719@ = 451 
04AF: 720@ = 429 
04AF: 721@ = 429 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_34456
454@ = -878.0113 
536@ = 1947.484 
618@ = 59.1845 
455@ = -857.6418 
537@ = 1873.25 
619@ = 59.183 
456@ = -1030.689 
538@ = 1853.546 
620@ = 58.8558 
457@ = -1093.182 
539@ = 1748.023 
621@ = 31.6318 
458@ = -902.488 
540@ = 1687.666 
622@ = 26.267 
459@ = -847.1951 
541@ = 1495.581 
623@ = 17.5443 
460@ = -782.4052 
542@ = 1305.811 
624@ = 12.6016 
461@ = -616.3677 
543@ = 1193.645 
625@ = 9.2126 
462@ = -474.1805 
544@ = 1052.086 
626@ = 10.0313 
463@ = -319.1918 
545@ = 925.6066 
627@ = 10.3099 
464@ = -267.4492 
546@ = 825.0159 
628@ = 13.2739 
465@ = -188.4539 
547@ = 1007.19 
629@ = 18.5885 
466@ = -164.8873 
548@ = 1198.263 
630@ = 18.5938 
467@ = -142.1028 
549@ = 1250.022 
631@ = 18.5869 
468@ = -341.5205 
550@ = 1265.695 
632@ = 22.1515 
469@ = -440.031 
551@ = 1439.669 
633@ = 32.334 
470@ = -438.1716 
552@ = 1639.673 
634@ = 34.6319 
471@ = -381.6811 
553@ = 1831.026 
635@ = 49.8567 
472@ = -433.4627 
554@ = 1883.992 
636@ = 59.8611 
473@ = -465.4392 
555@ = 1768.532 
637@ = 71.9576 
474@ = -464.5399 
556@ = 1968.423 
638@ = 81.2536 
475@ = -411.0666 
557@ = 2074.596 
639@ = 60.6433 
476@ = -610.1716 
558@ = 2050.887 
640@ = 59.1798 
477@ = -790.69 
559@ = 2053.91 
641@ = 59.1798 
0087: 478@ = 454@ 
0087: 560@ = 536@ 
0087: 642@ = 618@ 
250@ = 25 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 461 
04AF: 717@ = 521 
04AF: 718@ = 522 
04AF: 719@ = 461 
04AF: 720@ = 521 
04AF: 721@ = 522 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_35318
454@ = -375.6397 
536@ = 2204.217 
618@ = 41.0938 
455@ = -388.8497 
537@ = 2258.056 
619@ = 40.9952 
456@ = -410.6823 
538@ = 2455.747 
620@ = 42.9124 
457@ = -608.4162 
539@ = 2447.19 
621@ = 71.7551 
458@ = -715.864 
540@ = 2536.594 
622@ = 72.7592 
459@ = -713.7043 
541@ = 2697.466 
623@ = 53.2852 
460@ = -912.5499 
542@ = 2721.987 
624@ = 44.8627 
461@ = -1112.755 
543@ = 2698.651 
625@ = 44.875 
462@ = -1238.171 
544@ = 2679.861 
626@ = 45.9321 
463@ = -1359.55 
545@ = 2659.557 
627@ = 50.4683 
464@ = -1545.773 
546@ = 2732.354 
628@ = 61.3062 
465@ = -1746.036 
547@ = 2727.448 
629@ = 59.0648 
466@ = -1860.247 
548@ = 2563.043 
630@ = 48.8929 
467@ = -2002.133 
549@ = 2422.603 
631@ = 32.9752 
468@ = -1961.463 
550@ = 2227.891 
632@ = 10.7077 
469@ = -1807.124 
551@ = 2100.1 
633@ = 7.4268 
470@ = -1782.09 
552@ = 1901.775 
634@ = 14.7248 
471@ = -1591.908 
553@ = 1837.29 
635@ = 24.8515 
472@ = -1392.057 
554@ = 1852.968 
636@ = 35.4945 
473@ = -1199.365 
555@ = 1799.638 
637@ = 40.4346 
474@ = -1008.306 
556@ = 1855.604 
638@ = 61.6784 
475@ = -857.7028 
557@ = 1874.014 
639@ = 59.1758 
476@ = -758.5721 
558@ = 2048.232 
640@ = 59.1866 
477@ = -563.1158 
559@ = 2005.574 
641@ = 59.2474 
478@ = -468.9791 
560@ = 2056.811 
642@ = 59.875 
479@ = -392.3245 
561@ = 2154.448 
643@ = 42.1847 
0087: 480@ = 454@ 
0087: 562@ = 536@ 
0087: 644@ = 618@ 
250@ = 27 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 461 
04AF: 717@ = 521 
04AF: 718@ = 522 
04AF: 719@ = 461 
04AF: 720@ = 521 
04AF: 721@ = 521 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_36240
454@ = 1446.426 
536@ = 834.0658 
618@ = 5.8125 
455@ = 1747.259 
537@ = 834.025 
619@ = 8.6815 
456@ = 2047.335 
538@ = 834.1916 
620@ = 5.7422 
457@ = 2348.722 
539@ = 834.1481 
621@ = 5.7422 
458@ = 2637.92 
540@ = 915.6277 
622@ = 5.7498 
459@ = 2726.824 
541@ = 1202.266 
623@ = 5.7422 
460@ = 2726.698 
542@ = 1502.967 
624@ = 5.7422 
461@ = 2726.958 
543@ = 1804.343 
625@ = 5.7393 
462@ = 2726.579 
544@ = 2125.796 
626@ = 5.7269 
463@ = 2705.172 
545@ = 2405.567 
627@ = 5.7277 
464@ = 2489.267 
546@ = 2614.273 
628@ = 4.1679 
465@ = 2188.479 
547@ = 2609.629 
629@ = 5.8164 
466@ = 1898.309 
548@ = 2529.155 
630@ = 5.8125 
467@ = 1603.524 
549@ = 2473.083 
631@ = 5.8516 
468@ = 1305.181 
550@ = 2439.19 
632@ = 5.7422 
469@ = 1208.232 
551@ = 2154.514 
633@ = 5.7422 
470@ = 1208.38 
552@ = 1853.837 
634@ = 5.7422 
471@ = 1208.322 
553@ = 1553.025 
635@ = 5.7422 
472@ = 1208.126 
554@ = 1252.557 
636@ = 5.7498 
473@ = 1229.187 
555@ = 952.9079 
637@ = 5.8125 
0087: 474@ = 454@ 
0087: 556@ = 536@ 
0087: 638@ = 618@ 
250@ = 21 
256@ = 6 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 716@ = 451 
04AF: 717@ = 562 
04AF: 718@ = 415 
04AF: 719@ = 411 
04AF: 720@ = 562 
04AF: 721@ = 451 
gosub @CPRACE_47662 
jump @CPRACE_46262 

:CPRACE_36982
454@ = 1796.901 
536@ = -2593.329 
618@ = 12.5982 
455@ = 1596.915 
537@ = -2592.123 
619@ = 25.9969 
456@ = 1425.429 
538@ = -2549.107 
620@ = 37.8234 
457@ = 1280.556 
539@ = -2394.586 
621@ = 52.2127 
458@ = 1296.165 
540@ = -2194.131 
622@ = 72.3519 
459@ = 1317.012 
541@ = -1995.026 
623@ = 77.657 
460@ = 1385.216 
542@ = -1807.25 
624@ = 64.6153 
461@ = 1501.202 
543@ = -1642.892 
625@ = 78.2774 
462@ = 1597.783 
544@ = -1466.853 
626@ = 87.9007 
463@ = 1621.693 
545@ = -1267.59 
627@ = 84.5704 
464@ = 1592.626 
546@ = -1069.313 
628@ = 87.8825 
465@ = 1477.096 
547@ = -905.3071 
629@ = 103.4455 
466@ = 1388.884 
548@ = -725.4239 
630@ = 125.9394 
467@ = 1320.715 
549@ = -536.3066 
631@ = 127.73 
468@ = 1233.948 
550@ = -356.5205 
632@ = 103.7008 
469@ = 1235.221 
551@ = -155.8231 
633@ = 83.5 
470@ = 1362.454 
552@ = -2.0532 
634@ = 70.1118 
471@ = 1562.073 
553@ = -27.0897 
635@ = 64.6716 
472@ = 1670.313 
554@ = -196.5335 
636@ = 77.4671 
473@ = 1698.697 
555@ = -394.7666 
637@ = 84.513 
474@ = 1841.239 
556@ = -535.4985 
638@ = 105.1396 
475@ = 1999.777 
557@ = -658.853 
639@ = 125.3019 
476@ = 2117.771 
558@ = -819.4944 
640@ = 144.8639 
477@ = 2200.181 
559@ = -1001.27 
641@ = 129.4889 
478@ = 2265.805 
560@ = -1184.584 
642@ = 83.0669 
479@ = 2296.145 
561@ = -1383.394 
643@ = 62.1655 
480@ = 2321.608 
562@ = -1582.03 
644@ = 63.1144 
481@ = 2400.442 
563@ = -1766.227 
645@ = 56.7954 
482@ = 2525.256 
564@ = -1922.68 
646@ = 52.2529 
483@ = 2593.726 
565@ = -2111.734 
647@ = 53.1139 
484@ = 2575.049 
566@ = -2313.631 
648@ = 53.9683 
485@ = 2455.397 
567@ = -2476.633 
649@ = 54.8922 
486@ = 2264.071 
568@ = -2548.592 
650@ = 55.7578 
487@ = 2065.285 
569@ = -2571.635 
651@ = 56.5966 
488@ = 1862.502 
570@ = -2582.099 
652@ = 54.6357 
250@ = 35 
256@ = 1 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 716@ = 476 
04AF: 717@ = 476 
04AF: 718@ = 476 
04AF: 719@ = 476 
04AF: 205@ = 3 
jump @CPRACE_46262 

:CPRACE_38120
454@ = -1582.67 
536@ = -89.9953 
618@ = 13.1683 
455@ = -1439.187 
537@ = 53.2109 
619@ = 30.0 
456@ = -1286.686 
538@ = 185.0573 
620@ = 32.9885 
457@ = -1091.876 
539@ = 137.3885 
621@ = 46.7629 
458@ = -1042.169 
540@ = -59.4087 
622@ = 43.603 
459@ = -1047.567 
541@ = -259.0437 
623@ = 23.8409 
460@ = -1126.559 
542@ = -445.5607 
624@ = 28.0502 
461@ = -1261.24 
543@ = -598.8228 
625@ = 37.4576 
462@ = -1444.803 
544@ = -690.5997 
626@ = 52.7263 
463@ = -1649.008 
545@ = -681.264 
627@ = 60.8852 
464@ = -1845.585 
546@ = -636.4395 
628@ = 61.1217 
465@ = -2044.818 
547@ = -658.4432 
629@ = 71.2804 
466@ = -2206.165 
548@ = -778.5996 
630@ = 85.9739 
467@ = -2240.928 
549@ = -976.7443 
631@ = 75.2422 
468@ = -2139.48 
550@ = -1148.617 
632@ = 61.3795 
469@ = -2028.634 
551@ = -1315.712 
633@ = 40.653 
470@ = -1884.623 
552@ = -1459.337 
634@ = 37.0927 
471@ = -1725.283 
553@ = -1581.193 
635@ = 51.3609 
472@ = -1548.501 
554@ = -1676.223 
636@ = 63.2502 
473@ = -1368.613 
555@ = -1769.197 
637@ = 52.099 
474@ = -1327.042 
556@ = -1980.883 
638@ = 35.4768 
475@ = -1462.659 
557@ = -2110.34 
639@ = 22.6174 
476@ = -1551.068 
558@ = -2287.276 
640@ = 56.7071 
477@ = -1624.645 
559@ = -2464.302 
641@ = 115.5442 
478@ = -1735.012 
560@ = -2633.092 
642@ = 101.7228 
479@ = -1673.618 
561@ = -2817.32 
643@ = 50.492 
480@ = -1529.398 
562@ = -2958.864 
644@ = 35.2493 
481@ = -1331.87 
563@ = -3016.815 
645@ = 36.5563 
482@ = -1140.517 
564@ = -2957.838 
646@ = 35.4633 
483@ = -1133.483 
565@ = -2757.115 
647@ = 30.2641 
484@ = -1219.593 
566@ = -2575.6 
648@ = 35.8018 
485@ = -1227.193 
567@ = -2375.099 
649@ = 31.7209 
486@ = -1172.746 
568@ = -2182.804 
650@ = 45.2393 
487@ = -1144.312 
569@ = -1988.018 
651@ = 83.1497 
488@ = -1021.386 
570@ = -1832.821 
652@ = 115.2484 
489@ = -943.5054 
571@ = -1647.992 
653@ = 133.3276 
490@ = -900.7032 
572@ = -1450.585 
654@ = 142.0757 
491@ = -884.4996 
573@ = -1249.642 
655@ = 148.1781 
492@ = -880.2889 
574@ = -1048.99 
656@ = 158.8745 
493@ = -936.6008 
575@ = -855.3414 
657@ = 160.157 
494@ = -972.9082 
576@ = -660.9503 
658@ = 116.3043 
495@ = -980.3859 
577@ = -464.2646 
659@ = 79.1644 
496@ = -818.388 
578@ = -348.3954 
660@ = 51.4388 
497@ = -617.8265 
579@ = -330.2328 
661@ = 37.1987 
498@ = -415.4925 
580@ = -339.8519 
662@ = 28.2761 
499@ = -248.3391 
581@ = -451.8987 
663@ = 18.5819 
500@ = -192.9961 
582@ = -643.989 
664@ = 8.889 
501@ = -128.7125 
583@ = -835.6478 
665@ = 24.9195 
502@ = 63.3296 
584@ = -892.0873 
666@ = 40.4431 
503@ = 236.1952 
585@ = -791.0125 
667@ = 46.7307 
504@ = 298.5167 
586@ = -600.2706 
668@ = 53.5437 
505@ = 326.4258 
587@ = -400.9587 
669@ = 50.4641 
506@ = 308.5928 
588@ = -201.9229 
670@ = 40.3219 
507@ = 244.4628 
589@ = -8.211 
671@ = 31.0744 
508@ = 129.2121 
590@ = 155.3022 
672@ = 27.6231 
509@ = -37.7018 
591@ = 268.3331 
673@ = 26.3544 
510@ = -224.3873 
592@ = 341.0904 
674@ = 28.1078 
511@ = -420.1607 
593@ = 382.1896 
675@ = 29.8681 
512@ = -622.4773 
594@ = 381.915 
676@ = 31.6354 
513@ = -822.824 
595@ = 370.0051 
677@ = 33.4142 
514@ = -1012.349 
596@ = 300.3856 
678@ = 35.7468 
515@ = -1193.1 
597@ = 214.7394 
679@ = 38.0629 
250@ = 62 
256@ = 1 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 716@ = 513 
04AF: 717@ = 513 
04AF: 718@ = 513 
04AF: 719@ = 513 
04AF: 205@ = 3 
jump @CPRACE_46262 

:CPRACE_40068
454@ = 366.982 
536@ = 2502.595 
618@ = 15.5571 
455@ = 116.652 
537@ = 2502.902 
619@ = 47.5682 
456@ = -133.6242 
538@ = 2524.392 
620@ = 55.1281 
457@ = -377.8474 
539@ = 2588.068 
621@ = 67.6866 
458@ = -604.1302 
540@ = 2694.639 
622@ = 84.7931 
459@ = -838.685 
541@ = 2779.901 
623@ = 69.2036 
460@ = -1045.629 
542@ = 2639.279 
624@ = 69.0984 
461@ = -984.3267 
543@ = 2395.508 
625@ = 64.5187 
462@ = -873.4733 
544@ = 2171.186 
626@ = 64.5549 
463@ = -770.134 
545@ = 1943.248 
627@ = 70.927 
464@ = -653.4092 
546@ = 1720.47 
628@ = 47.6015 
465@ = -578.5898 
547@ = 1481.972 
629@ = 21.5084 
466@ = -521.8337 
548@ = 1238.437 
630@ = 11.6736 
467@ = -469.9443 
549@ = 995.721 
631@ = 51.4066 
468@ = -525.42 
550@ = 750.7462 
632@ = 44.2215 
469@ = -664.0441 
551@ = 541.0659 
633@ = 15.9243 
470@ = -914.7918 
552@ = 536.2426 
634@ = 11.804 
471@ = -1131.918 
553@ = 661.8135 
635@ = 13.6564 
472@ = -1309.833 
554@ = 839.316 
636@ = 10.7039 
473@ = -1449.372 
555@ = 1045.777 
637@ = 31.9947 
474@ = -1603.122 
556@ = 1243.21 
638@ = 38.6648 
475@ = -1813.101 
557@ = 1379.44 
639@ = 28.4044 
476@ = -2061.489 
558@ = 1418.549 
640@ = 22.0099 
477@ = -2312.469 
559@ = 1430.699 
641@ = 42.3744 
478@ = -2522.745 
560@ = 1564.194 
642@ = 75.9034 
479@ = -2689.238 
561@ = 1753.745 
643@ = 99.5865 
480@ = -2759.371 
562@ = 1994.265 
644@ = 110.8744 
481@ = -2682.772 
563@ = 2233.097 
645@ = 113.4608 
482@ = -2493.907 
564@ = 2397.506 
646@ = 102.0156 
483@ = -2245.109 
565@ = 2418.773 
647@ = 83.5877 
484@ = -1994.605 
566@ = 2407.942 
648@ = 87.4376 
485@ = -1751.471 
567@ = 2349.74 
649@ = 90.2881 
486@ = -1535.099 
568@ = 2217.656 
650@ = 75.7349 
487@ = -1305.302 
569@ = 2118.716 
651@ = 74.7752 
488@ = -1064.807 
570@ = 2187.768 
652@ = 66.2415 
489@ = -814.3556 
571@ = 2195.872 
653@ = 56.1521 
490@ = -563.2742 
572@ = 2203.33 
654@ = 60.9129 
491@ = -313.3741 
573@ = 2229.26 
655@ = 73.2015 
492@ = -66.3647 
574@ = 2178.082 
656@ = 71.9294 
493@ = 186.4198 
575@ = 2211.213 
657@ = 71.6732 
494@ = 390.8383 
576@ = 2356.514 
658@ = 65.1402 
495@ = 639.1594 
577@ = 2385.26 
659@ = 47.4816 
496@ = 857.994 
578@ = 2510.157 
660@ = 50.2583 
497@ = 929.9869 
579@ = 2748.352 
661@ = 77.8011 
498@ = 760.5828 
580@ = 2935.73 
662@ = 91.5673 
499@ = 512.0109 
581@ = 2901.74 
663@ = 93.8596 
500@ = 309.843 
582@ = 2752.892 
664@ = 93.5908 
501@ = 153.0242 
583@ = 2560.321 
665@ = 64.3547 
502@ = 18.2657 
584@ = 2347.904 
666@ = 66.4087 
503@ = -99.4455 
585@ = 2126.343 
667@ = 75.4819 
504@ = -257.6325 
586@ = 1931.184 
668@ = 75.4922 
505@ = -392.7389 
587@ = 1720.594 
669@ = 94.1061 
506@ = -499.7809 
588@ = 1492.545 
670@ = 58.172 
507@ = -687.7847 
589@ = 1327.026 
671@ = 45.0028 
508@ = -881.8704 
590@ = 1169.769 
672@ = 68.6343 
509@ = -1075.92 
591@ = 1008.155 
673@ = 61.9286 
510@ = -1272.957 
592@ = 852.6403 
674@ = 61.1137 
511@ = -1457.539 
593@ = 680.1183 
675@ = 69.2464 
512@ = -1634.648 
594@ = 496.5454 
676@ = 79.7593 
513@ = -1839.814 
595@ = 342.0907 
677@ = 77.0974 
514@ = -2063.729 
596@ = 218.3637 
678@ = 74.2748 
515@ = -2305.257 
597@ = 145.857 
679@ = 72.5908 
516@ = -2554.304 
598@ = 126.6046 
680@ = 96.9355 
517@ = -2745.509 
599@ = -33.5993 
681@ = 80.174 
518@ = -2863.942 
600@ = -255.546 
682@ = 62.7643 
519@ = -2912.281 
601@ = -500.7706 
683@ = 51.8291 
520@ = -2947.388 
602@ = -759.2774 
684@ = 44.0041 
521@ = -2962.423 
603@ = -1011.333 
685@ = 42.2517 
522@ = -2955.506 
604@ = -1276.023 
686@ = 45.302 
523@ = -3000.904 
605@ = -1528.563 
687@ = 51.004 
250@ = 70 
256@ = 1 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 716@ = 520 
04AF: 717@ = 520 
04AF: 718@ = 520 
04AF: 719@ = 520 
04AF: 205@ = 3 
jump @CPRACE_46262 

:CPRACE_42256
454@ = 381.9952 
536@ = 2542.088 
618@ = 15.6876 
455@ = 304.6997 
537@ = 2547.057 
619@ = 37.975 
456@ = -97.4654 
538@ = 2554.841 
620@ = 32.4746 
457@ = -102.6455 
539@ = 2699.236 
621@ = 63.5945 
458@ = -221.948 
540@ = 2718.08 
622@ = 82.385 
459@ = -418.3279 
541@ = 2691.081 
623@ = 78.5077 
460@ = -392.2611 
542@ = 2492.193 
624@ = 84.257 
461@ = -360.1944 
543@ = 2294.638 
625@ = 79.344 
462@ = -238.1485 
544@ = 2230.007 
626@ = 81.9684 
463@ = -287.1143 
545@ = 2091.03 
627@ = 70.2663 
464@ = -481.0875 
546@ = 2051.74 
628@ = 76.2466 
465@ = -665.1192 
547@ = 2131.252 
629@ = 77.2696 
466@ = -845.4529 
548@ = 2218.861 
630@ = 80.0327 
467@ = -1044.866 
549@ = 2207.615 
631@ = 67.0078 
468@ = -1234.234 
550@ = 2142.393 
632@ = 66.1648 
469@ = -1424.931 
551@ = 2205.699 
633@ = 70.8862 
470@ = -1571.237 
552@ = 2247.766 
634@ = 65.1073 
471@ = -1745.637 
553@ = 2292.511 
635@ = 49.3695 
472@ = -1945.602 
554@ = 2285.913 
636@ = 44.2433 
473@ = -1953.881 
555@ = 2484.877 
637@ = 63.2602 
474@ = -1895.095 
556@ = 2633.034 
638@ = 74.4549 
475@ = -1706.873 
557@ = 2703.232 
639@ = 72.8798 
476@ = -1505.724 
558@ = 2721.034 
640@ = 69.9706 
477@ = -1305.595 
559@ = 2708.321 
641@ = 66.4619 
478@ = -1105.89 
560@ = 2731.611 
642@ = 62.9933 
479@ = -905.1519 
561@ = 2728.83 
643@ = 64.0124 
480@ = -704.1036 
562@ = 2733.898 
644@ = 66.2347 
250@ = 27 
256@ = 1 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 716@ = 487 
04AF: 717@ = 487 
04AF: 718@ = 487 
04AF: 719@ = 487 
04AF: 205@ = 3 
jump @CPRACE_46262 

:CPRACE_43154
454@ = -1962.871 
536@ = 628.0812 
618@ = 150.2844 
455@ = -1848.341 
537@ = 531.9294 
619@ = 86.1743 
456@ = -1827.913 
538@ = 399.3668 
620@ = 29.91 
457@ = -1751.361 
539@ = 326.9781 
621@ = 25.4958 
458@ = -1647.958 
540@ = 412.8291 
622@ = 26.6578 
459@ = -1560.513 
541@ = 532.7433 
623@ = 18.6913 
460@ = -1572.197 
542@ = 638.3369 
624@ = 25.3806 
461@ = -1700.555 
543@ = 706.7762 
625@ = 53.3757 
462@ = -1715.507 
544@ = 777.6501 
626@ = 45.9312 
463@ = -1715.978 
545@ = 978.3165 
627@ = 51.989 
464@ = -1714.958 
546@ = 1178.562 
628@ = 54.9734 
465@ = -1912.922 
547@ = 1146.255 
629@ = 56.3473 
466@ = -2003.248 
548@ = 982.3228 
630@ = 58.819 
467@ = -2006.168 
549@ = 810.2207 
631@ = 54.1756 
468@ = -1959.234 
550@ = 713.3063 
632@ = 75.2571 
469@ = -1793.007 
551@ = 730.7606 
633@ = 44.6388 
470@ = -1593.731 
552@ = 732.4928 
634@ = 20.5721 
471@ = -1533.424 
553@ = 923.6081 
635@ = 29.4493 
472@ = -1489.172 
554@ = 1118.737 
636@ = 17.2211 
473@ = -1605.045 
555@ = 1284.044 
637@ = 27.5543 
474@ = -1787.921 
556@ = 1365.81 
638@ = 32.2595 
475@ = -1986.429 
557@ = 1319.338 
639@ = 23.0384 
476@ = -2185.997 
558@ = 1345.112 
640@ = 19.4206 
477@ = -2384.599 
559@ = 1380.588 
641@ = 17.9485 
478@ = -2537.759 
560@ = 1369.641 
642@ = 23.8562 
479@ = -2719.315 
561@ = 1345.675 
643@ = 32.2039 
480@ = -2875.142 
562@ = 1245.782 
644@ = 20.7763 
250@ = 27 
256@ = 1 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 716@ = 488 
04AF: 717@ = 488 
04AF: 718@ = 488 
04AF: 719@ = 488 
04AF: 205@ = 3 
jump @CPRACE_46262 

:CPRACE_44052
454@ = 1765.609 
536@ = -2285.911 
618@ = 25.9621 
455@ = 1764.294 
537@ = -2084.371 
619@ = 26.0431 
456@ = 1649.402 
538@ = -1920.231 
620@ = 40.6173 
457@ = 1552.024 
539@ = -1745.273 
621@ = 30.0462 
458@ = 1419.031 
540@ = -1595.618 
622@ = 25.4285 
459@ = 1402.089 
541@ = -1441.622 
623@ = 18.2271 
460@ = 1545.335 
542@ = -1431.194 
624@ = 36.437 
461@ = 1653.446 
543@ = -1305.841 
625@ = 49.6078 
462@ = 1786.094 
544@ = -1276.766 
626@ = 22.6321 
463@ = 1901.04 
545@ = -1221.949 
627@ = 34.699 
464@ = 1848.224 
546@ = -1097.652 
628@ = 46.0898 
465@ = 1649.377 
547@ = -1085.296 
629@ = 36.7768 
466@ = 1487.205 
548@ = -970.0334 
630@ = 60.1281 
467@ = 1304.22 
549@ = -1038.929 
631@ = 39.8547 
468@ = 1215.798 
550@ = -1218.862 
632@ = 27.923 
469@ = 1302.613 
551@ = -1399.127 
633@ = 26.3812 
470@ = 1437.015 
552@ = -1321.431 
634@ = 45.396 
471@ = 1609.09 
553@ = -1299.497 
635@ = 25.0714 
472@ = 1791.421 
554@ = -1381.364 
636@ = 35.17 
473@ = 1827.021 
555@ = -1567.279 
637@ = 22.9243 
474@ = 1628.196 
556@ = -1600.6 
638@ = 38.8226 
475@ = 1450.909 
557@ = -1694.839 
639@ = 25.2192 
476@ = 1389.812 
558@ = -1852.984 
640@ = 24.997 
477@ = 1206.609 
559@ = -1933.723 
641@ = 57.1028 
478@ = 1053.461 
560@ = -2063.933 
642@ = 70.7254 
479@ = 1048.698 
561@ = -2265.503 
643@ = 47.2394 
480@ = 1224.402 
562@ = -2359.494 
644@ = 28.5888 
481@ = 1425.61 
563@ = -2360.047 
645@ = 28.3338 
250@ = 28 
256@ = 1 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 716@ = 425 
04AF: 717@ = 425 
04AF: 718@ = 425 
04AF: 719@ = 425 
04AF: 205@ = 3 
jump @CPRACE_46262 

:CPRACE_44980
454@ = -1398.355 
536@ = -197.2079 
618@ = 1043.119 
455@ = -1398.988 
537@ = -188.7892 
619@ = 1043.202 
456@ = -1465.939 
538@ = -134.0836 
620@ = 1046.011 
457@ = -1530.138 
539@ = -193.3988 
621@ = 1050.756 
458@ = -1415.686 
540@ = -274.1765 
622@ = 1051.149 
459@ = -1305.178 
541@ = -143.5283 
623@ = 1050.125 
460@ = -1302.774 
542@ = -268.6358 
624@ = 1048.487 
0087: 461@ = 454@ 
0087: 543@ = 536@ 
0087: 625@ = 618@ 
732@ = -1406.327 
733@ = -265.7914 
734@ = 1042.656 
735@ = 346.3297 
250@ = 8 
221@ = 7 
224@ = 12 
256@ = 12 
04AF: 700@ = 7 
04AF: 701@ = 7 
04AF: 702@ = 7 
04AF: 703@ = 7 
04AF: 704@ = 7 
04AF: 705@ = 7 
04AF: 706@ = 7 
04AF: 707@ = 7 
04AF: 708@ = 7 
04AF: 709@ = 7 
04AF: 710@ = 7 
04AF: 711@ = 7 
04AF: 712@ = 7 
04AF: 713@ = 7 
04AF: 714@ = 7 
04AF: 715@ = 7 
04AF: 716@ = 503 
04AF: 717@ = 502 
04AF: 718@ = 494 
04AF: 719@ = 503 
04AF: 720@ = 502 
04AF: 721@ = 494 
04AF: 722@ = 502 
04AF: 723@ = 494 
04AF: 724@ = 503 
04AF: 725@ = 494 
04AF: 726@ = 503 
04AF: 727@ = 503 
04AF: 728@ = 494 
04AF: 729@ = 502 
04AF: 730@ = 494 
04AF: 731@ = 502 
jump @CPRACE_46262 

:CPRACE_45529
454@ = -1354.358 
536@ = -590.5628 
618@ = 1055.453 
455@ = -1431.177 
537@ = -588.3124 
619@ = 1054.512 
456@ = -1516.874 
538@ = -635.0942 
620@ = 1050.275 
457@ = -1500.678 
539@ = -719.0175 
621@ = 1051.643 
458@ = -1387.502 
540@ = -743.1501 
622@ = 1051.016 
459@ = -1295.54 
541@ = -705.3506 
623@ = 1055.255 
460@ = -1365.312 
542@ = -666.0998 
624@ = 1055.058 
461@ = -1486.5 
543@ = -636.4586 
625@ = 1052.225 
462@ = -1447.86 
544@ = -690.3426 
626@ = 1052.834 
463@ = -1389.908 
545@ = -720.9943 
627@ = 1055.119 
464@ = -1370.685 
546@ = -687.8977 
628@ = 1053.783 
465@ = -1399.136 
547@ = -635.8359 
629@ = 1051.043 
466@ = -1308.639 
548@ = -649.4201 
630@ = 1054.972 
0087: 467@ = 454@ 
0087: 549@ = 536@ 
0087: 631@ = 618@ 
732@ = -1344.163 
733@ = -598.8836 
734@ = 1051.829 
735@ = 103.3822 
250@ = 14 
221@ = 4 
224@ = 6 
256@ = 12 
04AF: 700@ = 100 
04AF: 701@ = 133 
04AF: 702@ = 7 
04AF: 703@ = 181 
04AF: 704@ = 60 
04AF: 705@ = 34 
04AF: 706@ = 198 
04AF: 707@ = 250 
04AF: 708@ = 7 
04AF: 709@ = 100 
04AF: 710@ = 34 
04AF: 711@ = 7 
04AF: 712@ = 7 
04AF: 713@ = 7 
04AF: 714@ = 7 
04AF: 715@ = 7 
04AF: 716@ = 468 
04AF: 717@ = 468 
04AF: 718@ = 468 
04AF: 719@ = 468 
04AF: 720@ = 468 
04AF: 721@ = 468 
04AF: 722@ = 468 
04AF: 723@ = 468 
04AF: 724@ = 468 
04AF: 725@ = 468 
04AF: 726@ = 468 
04AF: 727@ = 468 
04AF: 728@ = 468 
04AF: 729@ = 468 
04AF: 730@ = 468 
04AF: 731@ = 468 
jump @CPRACE_46262 

:CPRACE_46262
return 

:CPRACE_46264
if 
  736@ == 0 
else_jump @CPRACE_46337 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere -148.2144 87.3396 2.1234 radius 280.0 280.0 30.0 
else_jump @CPRACE_46337 
736@ = 1 

:CPRACE_46337
if 
  736@ == 1 
else_jump @CPRACE_46371 
736@ = 2 
Model.Load(#COMBINE)
Model.Load(#VHMYELV)

:CPRACE_46371
if 
  736@ == 2 
else_jump @CPRACE_46525 
if and
   Model.Available(#COMBINE)
   Model.Available(#VHMYELV)
else_jump @CPRACE_46525 
736@ = 3 
738@ = Car.Create(#COMBINE, -128.2144, 80.3396, 2.1234)
Car.Angle(738@) = 250.5799
740@ = Actor.CreateAsDriver(CivMale, #VHMYELV, 738@)
Model.Destroy(#COMBINE)
Model.Destroy(#VHMYELV)
05D6: clear_scmpath 
05D7: add_point_to_scmpath -95.8304 68.27 3.4764 
05D7: add_point_to_scmpath -77.3806 70.3096 3.5478 
07E7: AS_assign_scmpath_to_actor 740@ in_car 738@ speed 7.5 flags 2 0 3 

:CPRACE_46525
if 
  736@ == 3 
else_jump @CPRACE_46621 
if 
   not Actor.Dead(740@)
else_jump @CPRACE_46621 
062E: get_actor 740@ task 2023 status_store_to 742@ 
if 
04A4:   742@ == 7 
else_jump @CPRACE_46621 
736@ = 4 
if 
   not Car.Wrecked(738@)
else_jump @CPRACE_46616 
Car.RemoveReferences(738@)

:CPRACE_46616
Actor.RemoveReferences(740@)

:CPRACE_46621
if 
  737@ == 0 
else_jump @CPRACE_46694 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere -542.1076 230.7356 11.6475 radius 320.0 320.0 30.0 
else_jump @CPRACE_46694 
737@ = 1 

:CPRACE_46694
if 
  737@ == 1 
else_jump @CPRACE_46728 
737@ = 2 
Model.Load(#WALTON)
Model.Load(#VHMYELV)

:CPRACE_46728
if 
  737@ == 2 
else_jump @CPRACE_46861 
if and
   Model.Available(#WALTON)
   Model.Available(#VHMYELV)
else_jump @CPRACE_46861 
737@ = 3 
739@ = Car.Create(#WALTON, -542.1076, 230.7356, 11.6475)
Car.Angle(739@) = 262.8685
741@ = Actor.CreateAsDriver(CivMale, #VHMYELV, 739@)
Model.Destroy(#WALTON)
Model.Destroy(#VHMYELV)
05D1: AS_actor 741@ drive_car 739@ to -270.5629 199.0073 6.99 speed 11.5 0 model #NULL 2 

:CPRACE_46861
if 
  737@ == 3 
else_jump @CPRACE_46972 
if 
   not Actor.Dead(741@)
else_jump @CPRACE_46972 
062E: get_actor 741@ task 1489 status_store_to 742@ 
if 
04A4:   742@ == 7 
else_jump @CPRACE_46972 
737@ = 4 
if 
   not Car.Wrecked(739@)
else_jump @CPRACE_46967 
05D2: AS_actor 741@ run_to_and_hijack_car 739@ max_search_radius 11.5 traffic_behavior 2 
Car.RemoveReferences(739@)

:CPRACE_46967
Actor.RemoveReferences(741@)

:CPRACE_46972
return 

:CPRACE_46974
if 
  6 > " + Race_Index + @" 
else_jump @CPRACE_47104 
if 
   not 52@ == 1 
else_jump @CPRACE_47104 
0391: release_textures 
0390: load_txd_dictionary 'LD_RCE1' 
038F: load_texture ""RACE00"" as 1 
038F: load_texture ""RACE01"" as 2 
038F: load_texture ""RACE02"" as 3 
038F: load_texture ""RACE03"" as 4 
038F: load_texture ""RACE04"" as 5 
038F: load_texture ""RACE05"" as 6 
52@ = 1 
return 

:CPRACE_47104
if and
  " + Race_Index + @" > 5 
  12 > " + Race_Index + @" 
else_jump @CPRACE_47241 
if 
   not 52@ == 2 
else_jump @CPRACE_47241 
0391: release_textures 
0390: load_txd_dictionary 'LD_RCE2' 
038F: load_texture ""RACE06"" as 7 
038F: load_texture ""RACE07"" as 8 
038F: load_texture ""RACE08"" as 9 
038F: load_texture ""RACE09"" as 10 
038F: load_texture ""RACE10"" as 11 
038F: load_texture ""RACE11"" as 12 
52@ = 2 
return 

:CPRACE_47241
if and
  " + Race_Index + @" > 11 
  18 > " + Race_Index + @" 
else_jump @CPRACE_47378 
if 
   not 52@ == 3 
else_jump @CPRACE_47378 
0391: release_textures 
0390: load_txd_dictionary 'LD_RCE3' 
038F: load_texture ""RACE12"" as 13 
038F: load_texture ""RACE13"" as 14 
038F: load_texture ""RACE14"" as 15 
038F: load_texture ""RACE15"" as 16 
038F: load_texture ""RACE16"" as 17 
038F: load_texture ""RACE17"" as 18 
52@ = 3 
return 

:CPRACE_47378
if and
  " + Race_Index + @" > 17 
  24 > " + Race_Index + @" 
else_jump @CPRACE_47515 
if 
   not 52@ == 4 
else_jump @CPRACE_47515 
0391: release_textures 
0390: load_txd_dictionary 'LD_RCE4' 
038F: load_texture ""RACE18"" as 19 
038F: load_texture ""RACE19"" as 20 
038F: load_texture ""RACE20"" as 21 
038F: load_texture ""RACE21"" as 22 
038F: load_texture ""RACE22"" as 23 
038F: load_texture ""RACE23"" as 24 
52@ = 4 
return 

:CPRACE_47515
if and
  " + Race_Index + @" > 23 
  30 > " + Race_Index + @" 
else_jump @CPRACE_47592 
if 
   not 52@ == 5 
else_jump @CPRACE_47592 
0391: release_textures 
0390: load_txd_dictionary 'LD_RCE5' 
038F: load_texture ""RACE24"" as 25 
52@ = 5 
return 

:CPRACE_47592
return 

:CPRACE_47594
0340: set_text_draw_RGBA 134 155 184 255 
033F: set_text_draw_letter_size 0.6146 2.4961 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
060D: draw_text_shadow 2 rgba 0 0 0 255 
return 

:CPRACE_47662
254@ = 0 
0085: 255@ = 256@ 
255@ -= 1 

:CPRACE_47684
if 
001D:   255@ > 254@ 
else_jump @CPRACE_48583 
0209: 253@ = random_int_in_ranges 0 32 
0871: init_jump_table 253@ total_jumps 32 default_jump 0 @CPRACE_48569 jumps 0 @CPRACE_47970 1 @CPRACE_47988 2 @CPRACE_48006 3 @CPRACE_48024 4 @CPRACE_48042 5 @CPRACE_48060 6 @CPRACE_48078 
0872: jump_table_jumps 7 @CPRACE_48096 8 @CPRACE_48114 9 @CPRACE_48132 10 @CPRACE_48151 11 @CPRACE_48170 12 @CPRACE_48189 13 @CPRACE_48208 14 @CPRACE_48227 15 @CPRACE_48246 
0872: jump_table_jumps 16 @CPRACE_48265 17 @CPRACE_48284 18 @CPRACE_48303 19 @CPRACE_48322 20 @CPRACE_48341 21 @CPRACE_48360 22 @CPRACE_48379 23 @CPRACE_48398 24 @CPRACE_48417 
0872: jump_table_jumps 25 @CPRACE_48436 26 @CPRACE_48455 27 @CPRACE_48474 28 @CPRACE_48493 29 @CPRACE_48512 30 @CPRACE_48531 31 @CPRACE_48550 -1 @CPRACE_48569 -1 @CPRACE_48569 

:CPRACE_47970
04AF: 700@(254@,16i) = 34 
jump @CPRACE_48569 

:CPRACE_47988
04AF: 700@(254@,16i) = 60 
jump @CPRACE_48569 

:CPRACE_48006
04AF: 700@(254@,16i) = 69 
jump @CPRACE_48569 

:CPRACE_48024
04AF: 700@(254@,16i) = 96 
jump @CPRACE_48569 

:CPRACE_48042
04AF: 700@(254@,16i) = 100 
jump @CPRACE_48569 

:CPRACE_48060
04AF: 700@(254@,16i) = 101 
jump @CPRACE_48569 

:CPRACE_48078
04AF: 700@(254@,16i) = 112 
jump @CPRACE_48569 

:CPRACE_48096
04AF: 700@(254@,16i) = 122 
jump @CPRACE_48569 

:CPRACE_48114
04AF: 700@(254@,16i) = 125 
jump @CPRACE_48569 

:CPRACE_48132
04AF: 700@(254@,16i) = 128 
jump @CPRACE_48569 

:CPRACE_48151
04AF: 700@(254@,16i) = 131 
jump @CPRACE_48569 

:CPRACE_48170
04AF: 700@(254@,16i) = 133 
jump @CPRACE_48569 

:CPRACE_48189
04AF: 700@(254@,16i) = 140 
jump @CPRACE_48569 

:CPRACE_48208
04AF: 700@(254@,16i) = 142 
jump @CPRACE_48569 

:CPRACE_48227
04AF: 700@(254@,16i) = 151 
jump @CPRACE_48569 

:CPRACE_48246
04AF: 700@(254@,16i) = 157 
jump @CPRACE_48569 

:CPRACE_48265
04AF: 700@(254@,16i) = 170 
jump @CPRACE_48569 

:CPRACE_48284
04AF: 700@(254@,16i) = 181 
jump @CPRACE_48569 

:CPRACE_48303
04AF: 700@(254@,16i) = 183 
jump @CPRACE_48569 

:CPRACE_48322
04AF: 700@(254@,16i) = 186 
jump @CPRACE_48569 

:CPRACE_48341
04AF: 700@(254@,16i) = 192 
jump @CPRACE_48569 

:CPRACE_48360
04AF: 700@(254@,16i) = 198 
jump @CPRACE_48569 

:CPRACE_48379
04AF: 700@(254@,16i) = 201 
jump @CPRACE_48569 

:CPRACE_48398
04AF: 700@(254@,16i) = 206 
jump @CPRACE_48569 

:CPRACE_48417
04AF: 700@(254@,16i) = 211 
jump @CPRACE_48569 

:CPRACE_48436
04AF: 700@(254@,16i) = 217 
jump @CPRACE_48569 

:CPRACE_48455
04AF: 700@(254@,16i) = 220 
jump @CPRACE_48569 

:CPRACE_48474
04AF: 700@(254@,16i) = 223 
jump @CPRACE_48569 

:CPRACE_48493
04AF: 700@(254@,16i) = 233 
jump @CPRACE_48569 

:CPRACE_48512
04AF: 700@(254@,16i) = 246 
jump @CPRACE_48569 

:CPRACE_48531
04AF: 700@(254@,16i) = 248 
jump @CPRACE_48569 

:CPRACE_48550
04AF: 700@(254@,16i) = 250 
jump @CPRACE_48569 

:CPRACE_48569
254@ += 1 
jump @CPRACE_47684 

:CPRACE_48583
return 

:CPRACE_48585
if or
  450@ == 1 
  256@ == 1 
else_jump @CPRACE_50435 
0394: play_music 1 
0871: init_jump_table " + Race_Index + @" total_jumps 27 default_jump 0 @CPRACE_50435 jumps 0 @CPRACE_48872 1 @CPRACE_48956 2 @CPRACE_49011 3 @CPRACE_49066 4 @CPRACE_49121 5 @CPRACE_49176 6 @CPRACE_49231 
0872: jump_table_jumps 7 @CPRACE_49286 8 @CPRACE_49356 9 @CPRACE_49404 10 @CPRACE_49459 11 @CPRACE_49514 12 @CPRACE_49569 13 @CPRACE_49624 14 @CPRACE_49679 15 @CPRACE_49734 
0872: jump_table_jumps 16 @CPRACE_49789 17 @CPRACE_49844 18 @CPRACE_49899 19 @CPRACE_49954 20 @CPRACE_50009 21 @CPRACE_50064 22 @CPRACE_50119 23 @CPRACE_50174 24 @CPRACE_50229 
0872: jump_table_jumps 25 @CPRACE_50284 26 @CPRACE_50363 -1 @CPRACE_50435 -1 @CPRACE_50435 -1 @CPRACE_50435 -1 @CPRACE_50435 -1 @CPRACE_50435 -1 @CPRACE_50435 -1 @CPRACE_50435 

:CPRACE_48872
if 
  " + tmp_Races_Won + @"[0] == 0 
else_jump @CPRACE_48949 
" + Races_Won_Number + @" += 1 
if 
  " + Custom_Tournament_Flag + @" == 0 
else_jump @CPRACE_48933 
0318: set_latest_mission_passed 'CESAR_1'  
jump @CPRACE_48942 

:CPRACE_48933
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 

:CPRACE_48942
" + tmp_Races_Won + @"[0] = 1 

:CPRACE_48949
jump @CPRACE_50435 

:CPRACE_48956
if 
  " + tmp_Races_Won + @"[1] == 0 
else_jump @CPRACE_49004 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[1] = 1 

:CPRACE_49004
jump @CPRACE_50435 

:CPRACE_49011
if 
  " + tmp_Races_Won + @"[2] == 0 
else_jump @CPRACE_49059 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[2] = 1 

:CPRACE_49059
jump @CPRACE_50435 

:CPRACE_49066
if 
  " + tmp_Races_Won + @"[3] == 0 
else_jump @CPRACE_49114 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[3] = 1 

:CPRACE_49114
jump @CPRACE_50435 

:CPRACE_49121
if 
  " + tmp_Races_Won + @"[4] == 0 
else_jump @CPRACE_49169 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[4] = 1 

:CPRACE_49169
jump @CPRACE_50435 

:CPRACE_49176
if 
  " + tmp_Races_Won + @"[5] == 0 
else_jump @CPRACE_49224 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[5] = 1 

:CPRACE_49224
jump @CPRACE_50435 

:CPRACE_49231
if 
  " + tmp_Races_Won + @"[6] == 0 
else_jump @CPRACE_49279 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[6] = 1 

:CPRACE_49279
jump @CPRACE_50435 

:CPRACE_49286
if 
  " + tmp_Races_Won + @"[7] == 0 
else_jump @CPRACE_49349" );
                create_thread<CASHWIN>( 5000, 5000 );
                AppendLine( @"Player.Money(" + PlayerChar + @") += 5000
" + Races_Won_Number + @" += 1 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[7] = 1 

:CPRACE_49349
jump @CPRACE_50435 

:CPRACE_49356
if 
  " + tmp_Races_Won + @"[8] == 0 
else_jump @CPRACE_49397 
" + Races_Won_Number + @" += 1 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[8] = 1 

:CPRACE_49397
jump @CPRACE_50435 

:CPRACE_49404
if 
  " + tmp_Races_Won + @"[9] == 0 
else_jump @CPRACE_49452 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[9] = 1 

:CPRACE_49452
jump @CPRACE_50435 

:CPRACE_49459
if 
  " + tmp_Races_Won + @"[10] == 0 
else_jump @CPRACE_49507 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[10] = 1 

:CPRACE_49507
jump @CPRACE_50435 

:CPRACE_49514
if 
  " + tmp_Races_Won + @"[11] == 0 
else_jump @CPRACE_49562 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[11] = 1 

:CPRACE_49562
jump @CPRACE_50435 

:CPRACE_49569
if 
  " + tmp_Races_Won + @"[12] == 0 
else_jump @CPRACE_49617 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[12] = 1 

:CPRACE_49617
jump @CPRACE_50435 

:CPRACE_49624
if 
  " + tmp_Races_Won + @"[13] == 0 
else_jump @CPRACE_49672 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[13] = 1 

:CPRACE_49672
jump @CPRACE_50435 

:CPRACE_49679
if 
  " + tmp_Races_Won + @"[14] == 0 
else_jump @CPRACE_49727 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[14] = 1 

:CPRACE_49727
jump @CPRACE_50435 

:CPRACE_49734
if 
  " + tmp_Races_Won + @"[15] == 0 
else_jump @CPRACE_49782 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[15] = 1 

:CPRACE_49782
jump @CPRACE_50435 

:CPRACE_49789
if 
  " + tmp_Races_Won + @"[16] == 0 
else_jump @CPRACE_49837 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[16] = 1 

:CPRACE_49837
jump @CPRACE_50435 

:CPRACE_49844
if 
  " + tmp_Races_Won + @"[17] == 0 
else_jump @CPRACE_49892 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[17] = 1 

:CPRACE_49892
jump @CPRACE_50435 

:CPRACE_49899
if 
  " + tmp_Races_Won + @"[18] == 0 
else_jump @CPRACE_49947 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[18] = 1 

:CPRACE_49947
jump @CPRACE_50435 

:CPRACE_49954
if 
  " + tmp_Races_Won + @"[19] == 0 
else_jump @CPRACE_50002 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[19] = 1 

:CPRACE_50002
jump @CPRACE_50435 

:CPRACE_50009
if 
  " + tmp_Races_Won + @"[20] == 0 
else_jump @CPRACE_50057 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[20] = 1 

:CPRACE_50057
jump @CPRACE_50435 

:CPRACE_50064
if 
  " + tmp_Races_Won + @"[21] == 0 
else_jump @CPRACE_50112 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[21] = 1 

:CPRACE_50112
jump @CPRACE_50435 

:CPRACE_50119
if 
  " + tmp_Races_Won + @"[22] == 0 
else_jump @CPRACE_50167 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[22] = 1 

:CPRACE_50167
jump @CPRACE_50435 

:CPRACE_50174
if 
  " + tmp_Races_Won + @"[23] == 0 
else_jump @CPRACE_50222 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[23] = 1 

:CPRACE_50222
jump @CPRACE_50435 

:CPRACE_50229
if 
  " + tmp_Races_Won + @"[24] == 0 
else_jump @CPRACE_50277 
" + Races_Won_Number + @" += 1 
gosub @CPRACE_50437 
0318: set_latest_mission_passed 85@(" + Race_Index + @",30s) 
" + tmp_Races_Won + @"[24] = 1 

:CPRACE_50277
jump @CPRACE_50435 

:CPRACE_50284
if 
  " + tmp_Races_Won + @"[25] == 0 
else_jump @CPRACE_50356" );
                create_thread<CASHWIN>( 10000, 5000 );
                AppendLine( @"Player.Money(" + PlayerChar + @") += 10000
0318: set_latest_mission_passed 'STAD_03'" );
                CAR_PARK.set_chance_to_generate( carPark_2786, 101 );
                CAR_PARK.set_chance_to_generate( carPark_2787, 101 );
                AppendLine( @"" + tmp_Races_Won + @"[ 25] = 1 

:CPRACE_50356
jump @CPRACE_50435 

:CPRACE_50363
if 
  " + tmp_Races_Won + @"[26] == 0 
else_jump @CPRACE_50428" );
                create_thread<CASHWIN>( 25000, 5000 );
                AppendLine( @"Player.Money(" + PlayerChar + @") += 25000
0318: set_latest_mission_passed 'STAD_01'" );
                CAR_PARK.set_chance_to_generate( carPark_2788, 101 );
                AppendLine( @"" + tmp_Races_Won + @"[ 26] = 1 

:CPRACE_50428
jump @CPRACE_50435 

:CPRACE_50435
return 

:CPRACE_50437
if 
003C:   " + Races_Won_Number + @" == 208@ 
else_jump @CPRACE_50516 
if 
  " + All_Races_Won_Prize_Flag + @" == 0 
else_jump @CPRACE_50509 
// NEW BONUSES:
" + Racing_Suit_Available + @" = 1
//" );
Car girlCar = global();
CAR_PARK.init_with_number_plate( girlCar, -1778.178, 1207.074, 25.1194, 91.9357, 557, "__NOS___", forceSpawn_bool: true );
CAR_PARK.set_to_player_owned( girlCar, true ).set_chance_to_generate( girlCar, 101 );
Garage.change_type( "MICHDR", 5 );
Garage.set_respray_free( "MICHDR", true );
create_thread<CASHWIN>( 1000000, 5000, 45 );
AppendLine( @"Player.Money(" + PlayerChar + @") += 1000000
" + All_Races_Won_Prize_Flag + @" = 1 

:CPRACE_50509
jump @CPRACE_50538 

:CPRACE_50516" );
                create_thread<CASHWIN>( 10000, 5000 );
                AppendLine( @"Player.Money(" + PlayerChar + @") += 10000

:CPRACE_50538
return 

:CPRACE_50540
254@ = 0 

:CPRACE_50547
0209: 255@ = random_int_in_ranges 0 5 
0871: init_jump_table 255@ total_jumps 5 default_jump 0 @CPRACE_50849 jumps 0 @CPRACE_50619 1 @CPRACE_50664 2 @CPRACE_50713 3 @CPRACE_50758 4 @CPRACE_50802 -1 @CPRACE_50849 -1 @CPRACE_50849 

:CPRACE_50619
0605: actor -1 perform_animation ""RIOT_CHANT"" IFP ""RIOT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2700 
jump @CPRACE_50849 

:CPRACE_50664
0605: actor -1 perform_animation ""RIOT_CHALLENGE"" IFP ""RIOT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2000 
jump @CPRACE_50849 

:CPRACE_50713
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2000 
jump @CPRACE_50849 

:CPRACE_50758
0605: actor -1 perform_animation ""RIOT_FUKU"" IFP ""RIOT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 3000 
jump @CPRACE_50849 

:CPRACE_50802
0605: actor -1 perform_animation ""RIOT_PUNCHES"" IFP ""RIOT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 2200 
jump @CPRACE_50849 

:CPRACE_50849
254@ += 1 
  254@ >= 7 
else_jump @CPRACE_50547 
return 

:CPRACE_50872
if 
  225@ == 0 
else_jump @CPRACE_51069 
if 
03D2:   wav 4 ended 
else_jump @CPRACE_51069 
if 
001E:   " + Current_Time_in_ms2 + @" > 226@ 
else_jump @CPRACE_51069 
040D: unload_wav 4 
0209: 227@ = random_int_in_ranges 0 4 
0871: init_jump_table 227@ total_jumps 4 default_jump 0 @CPRACE_51062 jumps 0 @CPRACE_51000 1 @CPRACE_51016 2 @CPRACE_51032 3 @CPRACE_51048 -1 @CPRACE_51062 -1 @CPRACE_51062 -1 @CPRACE_51062 

:CPRACE_51000
03CF: load_wav 36200 as 4 
jump @CPRACE_51062 

:CPRACE_51016
03CF: load_wav 36202 as 4 
jump @CPRACE_51062 

:CPRACE_51032
03CF: load_wav 36205 as 4 
jump @CPRACE_51062 

:CPRACE_51048
03CF: load_wav 1827 as 4 
jump @CPRACE_51062 

:CPRACE_51062
225@ += 1 

:CPRACE_51069
if 
  225@ == 1 
else_jump @CPRACE_51177 
if 
03D0:   wav 4 loaded 
else_jump @CPRACE_51177 
if 
  227@ == 3 
else_jump @CPRACE_51147 
097A: play_audio_at 0.0 0.0 0.0 event 1164 
jump @CPRACE_51151 

:CPRACE_51147
03D1: play_wav 4 

:CPRACE_51151
0209: 226@ = random_int_in_ranges 2000 10000 
005C: 226@ += " + Current_Time_in_ms2 + @" 
225@ = 0 

:CPRACE_51177
return 
return 
return 
47@ = 0.0 
47@ = 0.0 
47@ = 0.0 
return 
return 
return 

:CPRACE_51219
if or
  53@ == 0 
  53@ == 1 
  53@ == 3 
else_jump @CPRACE_51743 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @CPRACE_51743 
if 
  53@ == 3 
else_jump @CPRACE_51408 
if 
  " + Race_Index + @" == 25 
else_jump @CPRACE_51343 
" + tempvar_Float_1 + @" = 2693.184 
" + tempvar_Float_2 + @" = -1699.655 
" + tempvar_Float_3 + @" = 9.3891 
" + tempvar_Angle + @" = 34.2987 

:CPRACE_51343
if 
  " + Race_Index + @" == 26 
else_jump @CPRACE_51401 
" + tempvar_Float_1 + @" = 1101.781 
" + tempvar_Float_2 + @" = 1604.578 
" + tempvar_Float_3 + @" = 11.5506 
" + tempvar_Angle + @" = 353.1771 

:CPRACE_51401
jump @CPRACE_51655 

:CPRACE_51408
if 
  " + Current_Tournament + @" == 0 
else_jump @CPRACE_51470 
0086: " + tempvar_Float_1 + @" = " + tmp_X_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
0086: " + tempvar_Float_2 + @" = " + tmp_Y_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
" + tempvar_Float_2 + @" += 4.0 
" + tempvar_Angle + @" = 180.0 

:CPRACE_51470
if 
  " + Current_Tournament + @" == 1 
else_jump @CPRACE_51532 
0086: " + tempvar_Float_1 + @" = " + tmp_X_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
" + tempvar_Float_1 + @" += 4.0 
0086: " + tempvar_Float_2 + @" = " + tmp_Y_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
" + tempvar_Angle + @" = 90.0 

:CPRACE_51532
if or
  " + Current_Tournament + @" == 2 
  " + Current_Tournament + @" == 3 
else_jump @CPRACE_51601 
0086: " + tempvar_Float_1 + @" = " + tmp_X_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
" + tempvar_Float_1 + @" += 4.0 
0086: " + tempvar_Float_2 + @" = " + tmp_Y_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
" + tempvar_Angle + @" = 90.0 

:CPRACE_51601
if 
   not 53@ == 1 
else_jump @CPRACE_51643 
0086: " + tempvar_Float_1 + @" = " + tmp_X_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 
0086: " + tempvar_Float_2 + @" = " + tmp_Y_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 

:CPRACE_51643
0086: " + tempvar_Float_3 + @" = " + tmp_Z_Race_Tournament_Point + @"(" + Current_Tournament + @",4f) 

:CPRACE_51655
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.Angle(" + PlayerActor + @") = " + tempvar_Angle + @"
0395: clear_area 0 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.5 
04E4: refresh_game_renderer_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
Camera.SetAtPos(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0915: sync_weather_with_time_and_location_instantly 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
fade 1 2000 
select_interior 0 
0860: link_actor " + PlayerActor + @" to_interior 0 

:CPRACE_51743
253@ = 0 

:CPRACE_51750
if 
001D:   256@ > 253@ 
else_jump @CPRACE_51870 
if 
803B:   not  253@ == 442@ 
else_jump @CPRACE_51829 
if 
87D6:   not  395@(253@,16i) == " + PlayerActor + @" 
else_jump @CPRACE_51829 
Car.RemoveReferences(379@(253@,16i))
Actor.RemoveReferences(395@(253@,16i))

:CPRACE_51829
Model.Destroy(700@(253@,16i))
Model.Destroy(716@(253@,16i))
Marker.Disable(412@(253@,16i))
253@ += 1 
jump @CPRACE_51750 

:CPRACE_51870
Actor.DestroyWithFade(411@)
0296: unload_special_actor 1 
0296: unload_special_actor 2 
if 
  " + FreeFall_Stage + @" > 0 
else_jump @CPRACE_51908 
" + FreeFall_Stage + @" = 6 

:CPRACE_51908
Actor.RemoveReferences(411@)
Actor.RemoveReferences(429@)
253@ = 0 

:CPRACE_51925
if 
  11 > 253@ 
else_jump @CPRACE_51962 
Actor.RemoveReferences(441@)
253@ += 1 
jump @CPRACE_51925 

:CPRACE_51962
if 
  " + Race_Index + @" == 23 
else_jump @CPRACE_52005 
if 
  " + Pilot_License_Obtained + @" == 1 
else_jump @CPRACE_52005 

:CPRACE_52005
Marker.Disable(54@)
06D6: disable_racing_checkpoint 449@ 
Object.Destroy(430@)
014F: stop_timer " + _6960 + @" 
04EF: release_animation ""RIOT"" 
04EF: release_animation ""CAR"" 
03F0: enable_text_draw 0 
0912: set_text_priority 0 leftmargin 380 maxwidth 464 
01EB: set_traffic_density_multiplier_to 1.0 
08E7: disable_entrance_markers 0 
0581: enable_radar 1 
09B9: show_entered_car_name 1 
09BA: show_entered_zone_name 1 
09AC: disable_map_icons 0 
057E: set_radar_grey 0 
0826: enable_hud 1 
04FA: reset_sky_colors_with_fade 0 
0989: set_text_boxes_width 200 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @CPRACE_52121 
0860: link_actor " + PlayerActor + @" to_interior 0 

:CPRACE_52121
" + _10493 + @" = 0 
" + CARMOD_Disabled_Flag + @" = 0 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}