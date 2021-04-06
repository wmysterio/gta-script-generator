using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalSkools {

        private sealed class DESERT5 : MissionCustom {

            Int tmp_Flight_School_Records = global( Flight_School_Records.startIndex );
            Int _local70 = local( 70 );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @DESERT5_47 
if 
wasted_or_busted 
else_jump @DESERT5_38 
gosub @DESERT5_29947 

:DESERT5_38
gosub @DESERT5_30094 
end_thread 

:DESERT5_47
03D5: remove_text 'M_FAIL'  
" + OnMission + @" = 1 
if 
   not " + Mission_Learning_to_Fly_Passed + @" == 1 
else_jump @DESERT5_85 
increment_mission_attempts 

:DESERT5_85
054C: use_GXT_table 'DSERT5' 
0169: set_fade_color_RGB 0 0 0 
wait 0 
fade 0 500 

:DESERT5_115
if 
fading 
else_jump @DESERT5_139 
wait 0 
jump @DESERT5_115 

:DESERT5_139
" + _327 + @" = 415.55 
" + _328 + @" = 2533.57 
" + _329 + @" = 19.18 
230@ = 0 
226@ = 0 
227@ = 0 
229@ = 0 
228@ = 0 
231@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
237@ = 0 
238@ = 0 
44@ = -81.36 
45@ = 2476.0 
46@ = 435.92 
47@ = 2528.62 
0087: 48@ = 44@ 
005B: 48@ += 46@ 
48@ /= 2.0 
0087: 49@ = 45@ 
005B: 49@ += 47@ 
49@ /= 2.0 
50@ = 321.52 
0087: 51@ = 49@ 
52@ = 17.16 
73@ = -383.79 
0087: 76@ = 49@ 
79@ = 147.09 
0087: 74@ = 73@ 
74@ -= 300.0 
0087: 77@ = 76@ 
0087: 80@ = 79@ 
80@ -= 20.0 
0087: 75@ = 73@ 
75@ -= 650.0 
0087: 78@ = 76@ 
0087: 81@ = 79@ 
81@ += 10.0 
53@ = -383.79 
0087: 54@ = 49@ 
55@ = 85.09 
0087: 82@ = 44@ 
0087: 83@ = 49@ 
84@ = 33.3 
0087: 109@ = 50@ 
109@ -= 500.0 
0087: 110@ = 51@ 
0087: 111@ = 52@ 
111@ += 120.0 
56@ = 308.0 
0087: 57@ = 49@ 
58@ = 17.07 
63@ = 3 
66@ = 2 
0087: 112@ = 48@ 
0087: 113@ = 49@ 
114@ = 80.0 
0087: 115@ = 112@ 
115@ += 200.0 
129@ = 15.0 
0087: 136@ = 48@ 
0087: 137@ = 49@ 
138@ = 15.53 
0087: 139@ = 136@ 
139@ += 350.0 
0087: 140@ = 137@ 
141@ = 900.0 
" + _7523 + @" = 0 
" + _7524 + @" = 0 
" + _7525 + @" = 0 
159@ = 0 
160@ = 0 
177@ = 0 
178@ = 0 
215@ = 0 
216@ = 0 
218@ = 0 
219@ = 0 
if 
  219@ == 1 
else_jump @DESERT5_954 
35@ = Car.Create(#RUSTLER, 0.0, 0.0, -100.0)
70@ = Actor.Create(Mission1, #NULL, 0.0, 0.0, -100.0)
156@ = 0 

:DESERT5_894
if 
001D:   63@ > 156@ 
else_jump @DESERT5_954 
60@(156@,3i) = Car.Create(#PETRO, 0.0, 0.0, -100.0)
156@ += 1 
jump @DESERT5_894 

:DESERT5_954
0A0E: disable_text_with_style 1 
03BA: clear_cars_from_cube_cornerA 44@ 45@ 0.0 cornerB 46@ 47@ 50.0 
08F8: display_stat_update_box 0 
07A8: enable_area69_sam 0 
096A: enable_flying_helis 0 
050F: get_max_wanted_level_to 239@ 
01F0: set_max_wanted_level_to 0 
Model.Load(#RUSTLER)
Model.Load(#HUNTER)
Model.Load(#PETRO)
Model.Load(#LANDSTAL)
Model.Load(#STUNT)" );
load_external_script<PARACH>();
AppendLine( @"038B: load_requested_models 

:DESERT5_1034
if or
   not Model.Available(#RUSTLER)
   not Model.Available(#HUNTER)
   not Model.Available(#PETRO)
   not Model.Available(#LANDSTAL)
   not Model.Available(#STUNT)
else_jump @DESERT5_1081 
wait 0 
jump @DESERT5_1034 

:DESERT5_1081
if" );
( !is_external_script_loaded<PARACH>() ).write();
AppendLine( @"else_jump @DESERT5_1107 
wait 0 
jump @DESERT5_1081 

:DESERT5_1107
0390: load_txd_dictionary 'LD_DRV' 
038F: load_texture ""BRFLY"" as 1 
038F: load_texture ""SILFLY"" as 2 
038F: load_texture ""GOLFLY"" as 3 
038F: load_texture ""RIBB"" as 4 
038F: load_texture ""TVCORN"" as 5 
038F: load_texture ""NAWARD"" as 6 
038F: load_texture ""RIBBW"" as 7 
038F: load_texture ""BLKDOT"" as 8 
038F: load_texture ""TVBASE"" as 9 
038F: load_texture ""NAWTXT"" as 10 
08A8: set_markers_to_long_distance 1 
if 
  " + Flight_School_Brief_Played + @" == 0 
else_jump @DESERT5_2570 
0395: clear_area 0 at " + _327 + @" " + _328 + @" " + _329 + @" radius 50.0 
Actor.PutAt(" + PlayerActor + @", 414.8, 2534.2, 18.18)
Actor.Angle(" + PlayerActor + @") = 200.0
05AA: 179@s = 'MTOR04A' 
05AA: 181@s = 'MTOR04B' 
05AA: 183@s = 'MTOR04C' 
05AA: 185@s = 'MTOR04D' 
05AA: 187@s = 'MTOR04E' 
05AA: 189@s = 'MTOR04F' 
05AA: 191@s = 'MTOR04G' 
05AA: 193@s = 'MTOR04H' 
05AA: 195@s = 'MTOR04J' 
05AA: 197@s = 'MTOR04K' 
05AA: 199@s = 'MTOR04L' 
05AA: 201@s = 'MTOR04M' 
04AF: 203@ = 29618 
04AF: 204@ = 29619 
04AF: 205@ = 29620 
04AF: 206@ = 29621 
04AF: 207@ = 29622 
04AF: 208@ = 29623 
04AF: 209@ = 29624 
04AF: 210@ = 29625 
04AF: 211@ = 29626 
04AF: 212@ = 29627 
04AF: 213@ = 29628 
04AF: 214@ = 29629 
217@ = 12 
215@ = 0 
218@ = 0 
Player.CanMove(" + PlayerChar + @") = False
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 1 
Model.Load(#CELLPHONE)
03CF: load_wav 23000 as 3 

:DESERT5_1616
if or
   not Model.Available(#CELLPHONE)
83D0:   not wav 3 loaded 
else_jump @DESERT5_1647 
wait 0 
jump @DESERT5_1616 

:DESERT5_1647
0729: AS_actor " + PlayerActor + @" hold_cellphone 1 
03D1: play_wav 3 
Camera.SetPosition(415.83, 2532.94, 19.5, 0.0, 0.0, 0.0)
Camera.PointAt(415.28, 2533.65, 19.5, 2)
fade 1 1000 

:DESERT5_1716
if 
fading 
else_jump @DESERT5_1740 
wait 0 
jump @DESERT5_1716 

:DESERT5_1740
240@ = 1 
0707: start_scene_skip_to @DESERT5_2377 
wait 600 
040D: unload_wav 3 
wait 1000 
216@ = 0 

:DESERT5_1775
if 
  1 > 216@ 
else_jump @DESERT5_1811 
wait 0 
gosub @DESERT5_29716 
jump @DESERT5_1775 

:DESERT5_1811
if 
  2 > 216@ 
else_jump @DESERT5_1887 
wait 0 
gosub @DESERT5_29716 
if and
  215@ == 2 
   not 218@ == 1 
else_jump @DESERT5_1880 
0967: actor " + PlayerActor + @" move_mouth 10000 ms 
218@ = 1 

:DESERT5_1880
jump @DESERT5_1811 

:DESERT5_1887
0968: actor " + PlayerActor + @" stop_mouth 

:DESERT5_1892
if 
  3 > 216@ 
else_jump @DESERT5_1968 
wait 0 
gosub @DESERT5_29716 
if and
  215@ == 2 
   not 218@ == 1 
else_jump @DESERT5_1961 
0967: actor " + PlayerActor + @" move_mouth 10000 ms 
218@ = 1 

:DESERT5_1961
jump @DESERT5_1892 

:DESERT5_1968
0968: actor " + PlayerActor + @" stop_mouth 

:DESERT5_1973
if 
  5 > 216@ 
else_jump @DESERT5_2009 
wait 0 
gosub @DESERT5_29716 
jump @DESERT5_1973 

:DESERT5_2009
if 
  6 > 216@ 
else_jump @DESERT5_2085 
wait 0 
gosub @DESERT5_29716 
if and
  215@ == 2 
   not 218@ == 1 
else_jump @DESERT5_2078 
0967: actor " + PlayerActor + @" move_mouth 10000 ms 
218@ = 1 

:DESERT5_2078
jump @DESERT5_2009 

:DESERT5_2085
0968: actor " + PlayerActor + @" stop_mouth 

:DESERT5_2090
if 
  8 > 216@ 
else_jump @DESERT5_2216 
wait 0 
gosub @DESERT5_29716 
if and
  215@ == 2 
  216@ == 7 
   not 218@ == 1 
else_jump @DESERT5_2209 
Camera.SetPosition(414.83, 2532.13, 19.43, 0.0, 0.0, 0.0)
Camera.PointAt(415.01, 2533.11, 19.42, 2)
218@ = 1 

:DESERT5_2209
jump @DESERT5_2090 

:DESERT5_2216
if 
  10 > 216@ 
else_jump @DESERT5_2252 
wait 0 
gosub @DESERT5_29716 
jump @DESERT5_2216 

:DESERT5_2252
if 
  11 > 216@ 
else_jump @DESERT5_2328 
wait 0 
gosub @DESERT5_29716 
if and
  215@ == 2 
   not 218@ == 1 
else_jump @DESERT5_2321 
0967: actor " + PlayerActor + @" move_mouth 10000 ms 
218@ = 1 

:DESERT5_2321
jump @DESERT5_2252 

:DESERT5_2328
0968: actor " + PlayerActor + @" stop_mouth 

:DESERT5_2333
if 
001D:   217@ > 216@ 
else_jump @DESERT5_2370 
wait 0 
gosub @DESERT5_29716 
jump @DESERT5_2333 

:DESERT5_2370
240@ = 0 

:DESERT5_2377
0701: end_scene_skip 
if 
   not 240@ == 1 
else_jump @DESERT5_2404 
0729: AS_actor " + PlayerActor + @" hold_cellphone 0 

:DESERT5_2404
fade 0 1000 

:DESERT5_2411
if 
fading 
else_jump @DESERT5_2435 
wait 0 
jump @DESERT5_2411 

:DESERT5_2435
if 
  240@ == 1 
else_jump @DESERT5_2460 
0729: AS_actor " + PlayerActor + @" hold_cellphone 0 

:DESERT5_2460
0968: actor " + PlayerActor + @" stop_mouth 
040D: unload_wav 3 
040D: unload_wav 1 
00BE: text_clear_all 
Actor.PutAt(" + PlayerActor + @", 413.94, " + _328 + @", 18.18)
Actor.Angle(" + PlayerActor + @") = 270.0
178@ = 1 
" + Flight_School_Brief_Played + @" = 1 
02A3: enable_widescreen 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
fade 1 1000 

:DESERT5_2539
if 
fading 
else_jump @DESERT5_2563 
wait 0 
jump @DESERT5_2539 

:DESERT5_2563
jump @DESERT5_29947 

:DESERT5_2570
Actor.PutAt(" + PlayerActor + @", 412.38, 2533.65, 18.18)
Actor.Angle(" + PlayerActor + @") = 90.0

:DESERT5_2600
Player.CanMove(" + PlayerChar + @") = False
03E6: remove_text_box 
00BE: text_clear_all 
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
238@ = 0 
231@ = 0 
230@ = 0 
03F0: enable_text_draw 1 
227@ = 255 
226@ = 2 
008B: 34@ = " + Flight_School_Current_Contest + @" 
if 
  34@ == 3 
else_jump @DESERT5_2726 
34@ = 4 

:DESERT5_2726
if 
  34@ == 5 
else_jump @DESERT5_2751 
34@ = 6 

:DESERT5_2751
0826: enable_hud 0 
0581: enable_radar 0 
03CF: load_wav 3800 as 3 

:DESERT5_2766
if 
83D0:   not wav 3 loaded 
else_jump @DESERT5_2792 
wait 0 
jump @DESERT5_2766 

:DESERT5_2792
fade 1 1000 
gosub @DESERT5_20476 

:DESERT5_2806
if 
fading 
else_jump @DESERT5_2837 
wait 0 
gosub @DESERT5_20476 
jump @DESERT5_2806 

:DESERT5_2837
wait 0 
if 
0735:   is_keyboard_key_pressed 83 
else_jump @DESERT5_2863 
jump @DESERT5_29990 

:DESERT5_2863
gosub @DESERT5_20476 
if 
  230@ == 0 
else_jump @DESERT5_3392 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @DESERT5_3035 
34@ -= 1 
" + Flight_School_Current_Contest + @" -= 1 
if 
  34@ == 3 
else_jump @DESERT5_2967 
34@ = 2 

:DESERT5_2967
if 
  34@ == 5 
else_jump @DESERT5_2992 
34@ = 4 

:DESERT5_2992
if 
  " + Flight_School_Contests_Passed + @" > 1 
else_jump @DESERT5_3035 
if 
  4 > 231@ 
else_jump @DESERT5_3035 
231@ = 3 

:DESERT5_3035
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @DESERT5_3166 
34@ += 1 
" + Flight_School_Current_Contest + @" += 1 
if 
  34@ == 3 
else_jump @DESERT5_3098 
34@ = 4 

:DESERT5_3098
if 
  34@ == 5 
else_jump @DESERT5_3123 
34@ = 6 

:DESERT5_3123
if 
  " + Flight_School_Contests_Passed + @" > 1 
else_jump @DESERT5_3166 
if 
  4 > 231@ 
else_jump @DESERT5_3166 
231@ = 3 

:DESERT5_3166
if 
  1 > 34@ 
else_jump @DESERT5_3200 
008B: 34@ = " + Flight_School_Contests_Passed + @" 
0084: " + Flight_School_Current_Contest + @" = " + Flight_School_Contests_Passed + @" 

:DESERT5_3200
if 
001F:   34@ > " + Flight_School_Contests_Passed + @" 
else_jump @DESERT5_3233 
34@ = 1 
" + Flight_School_Current_Contest + @" = 1 

:DESERT5_3233
if or
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 10 
00E1:   player 0 pressed_key 11 
else_jump @DESERT5_3304 
wait 0 
gosub @DESERT5_20476 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @DESERT5_3233 

:DESERT5_3304
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_3392 
if or
  34@ == 4 
  34@ == 6 
else_jump @DESERT5_3360 
230@ = 1 
jump @DESERT5_3392 

:DESERT5_3360
if 
  4 > 231@ 
else_jump @DESERT5_3385 
231@ = 3 

:DESERT5_3385
jump @DESERT5_3793 

:DESERT5_3392
if 
  230@ == 1 
else_jump @DESERT5_3722 
if 
  4 > 231@ 
else_jump @DESERT5_3435 
231@ = 3 

:DESERT5_3435
if 
  231@ == 0 
else_jump @DESERT5_3460 
231@ = 5 

:DESERT5_3460
gosub @DESERT5_24729 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 320.0 140.0 GXT 'DES5_FH'  
gosub @DESERT5_24729 
0342: set_text_draw_centered 0 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 182.0 185.0 GXT 'DES5_FI'  
gosub @DESERT5_24729 
0342: set_text_draw_centered 0 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 182.0 211.0 GXT 'DES5_FJ'  
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @DESERT5_3641 
jump @DESERT5_3793 

:DESERT5_3641
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @DESERT5_3722 
if 
  34@ == 4 
else_jump @DESERT5_3690 
34@ = 3 

:DESERT5_3690
if 
  34@ == 6 
else_jump @DESERT5_3715 
34@ = 5 

:DESERT5_3715
jump @DESERT5_3793 

:DESERT5_3722
if 
0735:   is_keyboard_key_pressed 81 
else_jump @DESERT5_3751 
" + Flight_School_Contests_Passed + @" = 12 
" + Mission_Learning_to_Fly_Passed + @" = 1 

:DESERT5_3751
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_3775 
jump @DESERT5_29947 

:DESERT5_3775
set_weather 17 
gosub @DESERT5_23134 
jump @DESERT5_2837 

:DESERT5_3793
fade 0 500 

:DESERT5_3800
if 
fading 
else_jump @DESERT5_3831 
wait 0 
gosub @DESERT5_20476 
jump @DESERT5_3800 

:DESERT5_3831
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_3852 
05EC: release_car 35@ from_path 

:DESERT5_3852
Car.Destroy(35@)
Camera.Restore_WithJumpCut
Actor.DestroyInstantly(70@)
156@ = 0 

:DESERT5_3871
if 
001D:   63@ > 156@ 
else_jump @DESERT5_3913 
Car.Destroy(60@(156@,3i))
156@ += 1 
jump @DESERT5_3871 

:DESERT5_3913
040D: unload_wav 3 
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 500.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
231@ = 5 
0826: enable_hud 1 
0581: enable_radar 1 
if 
  34@ == 1 
else_jump @DESERT5_5468 

:DESERT5_3977
gosub @DESERT5_24907 

:DESERT5_3984
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
" + _7523 + @" = 0 
" + _7524 + @" = 0 
157@ = 0 
35@ = Car.Create(#RUSTLER, 50@, 51@, 52@)
Car.Angle(35@) = 90.0
if 
  231@ == 0 
else_jump @DESERT5_4135 
Camera.SetPosition(172.6, 2466.14, 17.05, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_4135
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_1A' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_4165
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_4204 
232@ = 2 
jump @DESERT5_5415 

:DESERT5_4204
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_4273 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_4266 
232@ = 2 
jump @DESERT5_5415 
jump @DESERT5_4273 

:DESERT5_4266
jump @DESERT5_29947 

:DESERT5_4273
if 
  233@ == 0 
else_jump @DESERT5_4355 
00BC: show_text_highpriority GXT 'DES5_1A' time 5000 flag 4  
gosub @DESERT5_25173 
if 
  233@ == 1 
else_jump @DESERT5_4348 
00BC: show_text_highpriority GXT 'DES5_1B' time 10000 flag 4  

:DESERT5_4348
jump @DESERT5_5461 

:DESERT5_4355
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_5461 
if 
   not " + _7524 + @" == 1 
else_jump @DESERT5_4561 
if 
   not " + _7523 + @" == 1 
else_jump @DESERT5_4459 
077D: " + _7513 + @" = car 35@ x_angle 
if 
  5.0 >= " + _7513 + @" 
else_jump @DESERT5_4459 
" + _7523 + @" = 1 
00BC: show_text_highpriority GXT 'DES5_1C' time 10000 flag 4  

:DESERT5_4459
Car.StorePos(35@, 37@, 38@, 39@)
if 
  39@ >= 25.0 
else_jump @DESERT5_4524 
" + _7524 + @" = 1 
00BC: show_text_highpriority GXT 'DES5_1I' time 10000 flag 4  
jump @DESERT5_4561 

:DESERT5_4524
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ 
else_jump @DESERT5_4561 
236@ = 1 

:DESERT5_4561
if 
  " + _7524 + @" == 1 
else_jump @DESERT5_4986 
if 
   not 157@ == 1 
else_jump @DESERT5_4725 
091F: get_plane 35@ landing_gear_status_to 151@ 
if 
  151@ > 0.0 
else_jump @DESERT5_4718 
157@ = 1 
018A: 220@ = create_checkpoint_at 73@ 76@ 79@ 
06D5: 118@ = create_racing_checkpoint_at 73@ 76@ 79@ point_to 0.0 76@ 79@ type 3 radius 129@ 
116@ = 0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_1F' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_1J' time 10000 flag 4  

:DESERT5_4718
jump @DESERT5_4986 

:DESERT5_4725
if 
0100:   actor " + PlayerActor + @" in_sphere 73@(116@,3f) 76@(116@,3f) 79@(116@,3f) radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_4986 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 118@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
116@ += 1 
if 
  3 > 116@ 
else_jump @DESERT5_4979 
018A: 220@ = create_checkpoint_at 73@(116@,3f) 76@(116@,3f) 79@(116@,3f) 
06D5: 118@ = create_racing_checkpoint_at 73@(116@,3f) 76@(116@,3f) 79@(116@,3f) point_to 0.0 76@(116@,3f) 79@(116@,3f) type 3 radius 129@ 
if 
  116@ == 1 
else_jump @DESERT5_4938 
00BC: show_text_highpriority GXT 'DES5_1G' time 10000 flag 4  

:DESERT5_4938
if 
  116@ == 2 
else_jump @DESERT5_4972 
00BC: show_text_highpriority GXT 'DES5_1H' time 10000 flag 4  

:DESERT5_4972
jump @DESERT5_4986 

:DESERT5_4979
235@ = 1 

:DESERT5_4986
if 
  " + _7524 + @" == 1 
else_jump @DESERT5_5027 
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_5027 
236@ = 1 

:DESERT5_5027
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_5070 
236@ = 1 

:DESERT5_5070
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_5461 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_5169 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 30 
148@ = 45 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_5197 

:DESERT5_5169
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_5197
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[0] 
else_jump @DESERT5_5246 
008B: 237@ = " + tmp_Flight_School_Records + @"[0] 
0084: " + tmp_Flight_School_Records + @"[0] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_5246
if 
  " + Flight_School_Contests_Passed + @" == 1 
else_jump @DESERT5_5317 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_5317 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 2 
" + Flight_School_Current_Contest + @" = 2 
232@ = 2 

:DESERT5_5317
gosub @DESERT5_27620 

:DESERT5_5324
if 
  219@ == 0 
else_jump @DESERT5_5415 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_5384 
232@ = 2 
jump @DESERT5_5415 

:DESERT5_5384
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_5408 
jump @DESERT5_5415 

:DESERT5_5408
jump @DESERT5_5324 

:DESERT5_5415
gosub @DESERT5_27200 
if 
  232@ == 2 
else_jump @DESERT5_5454 
jump @DESERT5_2600 
jump @DESERT5_5461 

:DESERT5_5454
jump @DESERT5_3977 

:DESERT5_5461
jump @DESERT5_4165 

:DESERT5_5468
if 
  34@ == 2 
else_jump @DESERT5_6924 

:DESERT5_5486
gosub @DESERT5_24907 

:DESERT5_5493
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
159@ = 0 
160@ = 0 
158@ = 0 
35@ = Car.Create(#RUSTLER, 53@, 54@, 55@)
Car.Angle(35@) = 270.0
if 
  231@ == 0 
else_jump @DESERT5_5644 
Camera.SetPosition(27.29, 2466.31, 16.76, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_5644
08E6: set_plane 35@ landing_gear 1 
Car.LockInCurrentPosition(35@) = True
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_2J' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_5688
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_5727 
232@ = 2 
jump @DESERT5_6871 

:DESERT5_5727
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_5796 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_5789 
232@ = 2 
jump @DESERT5_6871 
jump @DESERT5_5796 

:DESERT5_5789
jump @DESERT5_29947 

:DESERT5_5796
if 
  233@ == 0 
else_jump @DESERT5_5937 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_5930 
Car.LockInCurrentPosition(35@) = False
Car.SetSpeedInstantly(35@, 30.0)
018A: 220@ = create_checkpoint_at 82@ 83@ 84@ 
06D5: 118@ = create_racing_checkpoint_at 82@ 83@ 84@ point_to -200.0 83@ 84@ type 3 radius 129@ 
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
00BC: show_text_highpriority GXT 'DES5_2J' time 5000 flag 4  
233@ = 1 

:DESERT5_5930
jump @DESERT5_6917 

:DESERT5_5937
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_6917 
if 
  159@ == 0 
else_jump @DESERT5_6171 
if 
   not 158@ == 1 
else_jump @DESERT5_6041 
091F: get_plane 35@ landing_gear_status_to 151@ 
if 
  1.0 > 151@ 
else_jump @DESERT5_6041 
158@ = 1 
00BC: show_text_highpriority GXT 'DES5_2C' time 5000 flag 4  

:DESERT5_6041
if 
0100:   actor " + PlayerActor + @" in_sphere 82@ 83@ 84@ radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_6164 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 118@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
159@ = 1 
018A: 220@ = create_checkpoint_at 308.0 49@ 52@ 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_2I' time 5000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_2D' time 7000 flag 4  

:DESERT5_6164
jump @DESERT5_6368 

:DESERT5_6171
01AC:   car 35@ sphere 1 in_cube_cornerA 288.0 45@ 16.0 cornerB 328.0 47@ 18.0 stopped 
if 
   not 160@ == 1 
else_jump @DESERT5_6321 
Car.StorePos(35@, 37@, 38@, 39@)
if 
  17.66 >= 39@ 
else_jump @DESERT5_6314 
160@ = 1 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_2E' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_2F' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_2G' time 7000 flag 4  

:DESERT5_6314
jump @DESERT5_6368 

:DESERT5_6321
if and
01AB:   car 35@ sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ stopped 
81F3:   not car 35@ in_air 
81F4:   not car 35@ flipped 
else_jump @DESERT5_6368 
235@ = 1 

:DESERT5_6368
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_6483 
if 
   not 159@ == 1 
else_jump @DESERT5_6416 
236@ = 1 
jump @DESERT5_6483 

:DESERT5_6416
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ 
else_jump @DESERT5_6460 
236@ = 1 
jump @DESERT5_6483 

:DESERT5_6460
if 
01F4:   car 35@ flipped 
else_jump @DESERT5_6483 
236@ = 1 

:DESERT5_6483
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_6526 
236@ = 1 

:DESERT5_6526
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_6917 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_6625 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 25 
148@ = 40 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_6653 

:DESERT5_6625
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_6653
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[1] 
else_jump @DESERT5_6702 
008B: 237@ = " + tmp_Flight_School_Records + @"[1] 
0084: " + tmp_Flight_School_Records + @"[1] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_6702
if 
  " + Flight_School_Contests_Passed + @" == 2 
else_jump @DESERT5_6773 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_6773 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 4 
" + Flight_School_Current_Contest + @" = 4 
232@ = 2 

:DESERT5_6773
gosub @DESERT5_27620 

:DESERT5_6780
if 
  219@ == 0 
else_jump @DESERT5_6871 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_6840 
232@ = 2 
jump @DESERT5_6871 

:DESERT5_6840
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_6864 
jump @DESERT5_6871 

:DESERT5_6864
jump @DESERT5_6780 

:DESERT5_6871
gosub @DESERT5_27200 
if 
  232@ == 2 
else_jump @DESERT5_6910 
jump @DESERT5_2600 
jump @DESERT5_6917 

:DESERT5_6910
jump @DESERT5_5486 

:DESERT5_6917
jump @DESERT5_5688 

:DESERT5_6924
if or
  34@ == 3 
  34@ == 4 
else_jump @DESERT5_8503 

:DESERT5_6949
gosub @DESERT5_24907 

:DESERT5_6956
gosub @DESERT5_19958 
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
" + _7524 + @" = 0 
116@ = 0 
35@ = Car.Create(#RUSTLER, 50@, 51@, 52@)
Car.Angle(35@) = 90.0
if 
  231@ == 0 
else_jump @DESERT5_7114 
08E6: set_plane 35@ landing_gear 1 
Camera.SetPosition(-1251.02, 2301.32, 140.44, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_7114
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_1A' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_7144
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_7183 
232@ = 2 
jump @DESERT5_8402 

:DESERT5_7183
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_7252 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_7245 
232@ = 2 
jump @DESERT5_8402 
jump @DESERT5_7252 

:DESERT5_7245
jump @DESERT5_29947 

:DESERT5_7252
if 
  233@ == 0 
else_jump @DESERT5_7445 
00BC: show_text_highpriority GXT 'DES5_1A' time 5000 flag 4  
gosub @DESERT5_25173 
if 
  233@ == 1 
else_jump @DESERT5_7438 
116@ = 0 
018A: 220@ = create_checkpoint_at 85@ 93@ 101@ 
06D5: 119@ = create_racing_checkpoint_at 85@ 93@ 101@ point_to 0.0 93@ 101@ type 3 radius 129@ 
06D5: 120@ = create_racing_checkpoint_at 86@ 94@ 102@ point_to 85@ 93@ 101@ type 3 radius 129@ 
00BC: show_text_highpriority GXT 'DES5_3B' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_3C' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_3D' time 10000 flag 4  

:DESERT5_7438
jump @DESERT5_8496 

:DESERT5_7445
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_8496 
if 
   not " + _7524 + @" == 1 
else_jump @DESERT5_7521 
Car.StorePos(35@, 37@, 38@, 39@)
if 
  39@ >= 25.0 
else_jump @DESERT5_7521 
" + _7524 + @" = 1 

:DESERT5_7521
if 
0100:   actor " + PlayerActor + @" in_sphere 85@(116@,8f) 93@(116@,8f) 101@(116@,8f) radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_7973 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 119@(116@,8i) 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
116@ += 1 
if 
  8 > 116@ 
else_jump @DESERT5_7966 
018A: 220@ = create_checkpoint_at 85@(116@,8f) 93@(116@,8f) 101@(116@,8f) 
0085: 117@ = 116@ 
117@ += 1 
if 
  8 > 117@ 
else_jump @DESERT5_7743 
06D5: 119@(117@,8i) = create_racing_checkpoint_at 85@(117@,8f) 93@(117@,8f) 101@(117@,8f) point_to 85@(116@,8f) 93@(116@,8f) 101@(116@,8f) type 3 radius 129@ 

:DESERT5_7743
if 
  116@ == 1 
else_jump @DESERT5_7818 
if 
  34@ == 4 
else_jump @DESERT5_7802 
00BC: show_text_highpriority GXT 'DES5_3F' time 10000 flag 4  
jump @DESERT5_7818 

:DESERT5_7802
00BC: show_text_highpriority GXT 'DES5_3E' time 10000 flag 4  

:DESERT5_7818
if 
  116@ == 2 
else_jump @DESERT5_7893 
if 
  34@ == 4 
else_jump @DESERT5_7877 
00BC: show_text_highpriority GXT 'DES5_3G' time 10000 flag 4  
jump @DESERT5_7893 

:DESERT5_7877
00BC: show_text_highpriority GXT 'DES5_3H' time 10000 flag 4  

:DESERT5_7893
if 
  116@ == 3 
else_jump @DESERT5_7959 
00BC: show_text_highpriority GXT 'DES5_3K' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_3L' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_3M' time 10000 flag 4  

:DESERT5_7959
jump @DESERT5_7973 

:DESERT5_7966
235@ = 1 

:DESERT5_7973
if 
  " + _7524 + @" == 1 
else_jump @DESERT5_8014 
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_8014 
236@ = 1 

:DESERT5_8014
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_8057 
236@ = 1 

:DESERT5_8057
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_8496 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_8156 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 60 
148@ = 75 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_8184 

:DESERT5_8156
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_8184
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[2] 
else_jump @DESERT5_8233 
008B: 237@ = " + tmp_Flight_School_Records + @"[2] 
0084: " + tmp_Flight_School_Records + @"[2] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_8233
if 
  " + Flight_School_Contests_Passed + @" == 4 
else_jump @DESERT5_8304 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_8304 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 6 
" + Flight_School_Current_Contest + @" = 6 
232@ = 2 

:DESERT5_8304
gosub @DESERT5_27620 

:DESERT5_8311
if 
  219@ == 0 
else_jump @DESERT5_8402 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_8371 
232@ = 2 
jump @DESERT5_8402 

:DESERT5_8371
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_8395 
jump @DESERT5_8402 

:DESERT5_8395
jump @DESERT5_8311 

:DESERT5_8402
gosub @DESERT5_27200 
156@ = 0 

:DESERT5_8416
if 
  8 > 156@ 
else_jump @DESERT5_8457 
06D6: disable_racing_checkpoint 119@(156@,8i) 
156@ += 1 
jump @DESERT5_8416 

:DESERT5_8457
if 
  232@ == 2 
else_jump @DESERT5_8489 
jump @DESERT5_2600 
jump @DESERT5_8496 

:DESERT5_8489
jump @DESERT5_6949 

:DESERT5_8496
jump @DESERT5_7144 

:DESERT5_8503
if or
  34@ == 5 
  34@ == 6 
else_jump @DESERT5_10300 

:DESERT5_8528
gosub @DESERT5_24907 

:DESERT5_8535
gosub @DESERT5_19958 
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
" + _7524 + @" = 0 
116@ = 0 
161@ = 0 
35@ = Car.Create(#RUSTLER, 50@, 51@, 52@)
Car.Angle(35@) = 90.0
if 
  231@ == 0 
else_jump @DESERT5_8700 
08E6: set_plane 35@ landing_gear 1 
Camera.SetPosition(-394.09, 2601.47, 134.89, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_8700
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_1A' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_8730
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_8769 
232@ = 2 
jump @DESERT5_10199 

:DESERT5_8769
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_8838 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_8831 
232@ = 2 
jump @DESERT5_10199 
jump @DESERT5_8838 

:DESERT5_8831
jump @DESERT5_29947 

:DESERT5_8838
if 
  233@ == 0 
else_jump @DESERT5_8999 
00BC: show_text_highpriority GXT 'DES5_1A' time 5000 flag 4  
gosub @DESERT5_25173 
if 
  233@ == 1 
else_jump @DESERT5_8992 
116@ = 0 
018A: 220@ = create_checkpoint_at 85@ 93@ 101@ 
06D5: 119@ = create_racing_checkpoint_at 85@ 93@ 101@ point_to 0.0 93@ 101@ type 3 radius 129@ 
06D5: 120@ = create_racing_checkpoint_at 86@ 94@ 102@ point_to 85@ 93@ 101@ type 3 radius 129@ 
00BC: show_text_highpriority GXT 'DES5_3B' time 10000 flag 4  

:DESERT5_8992
jump @DESERT5_10293 

:DESERT5_8999
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_10293 
if 
   not " + _7524 + @" == 1 
else_jump @DESERT5_9075 
Car.StorePos(35@, 37@, 38@, 39@)
if 
  39@ >= 25.0 
else_jump @DESERT5_9075 
" + _7524 + @" = 1 

:DESERT5_9075
if 
   not 161@ == 1 
else_jump @DESERT5_9609 
if 
0100:   actor " + PlayerActor + @" in_sphere 85@(116@,8f) 93@(116@,8f) 101@(116@,8f) radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_9602 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 119@(116@,8i) 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
116@ += 1 
if 
  8 > 116@ 
else_jump @DESERT5_9506 
018A: 220@ = create_checkpoint_at 85@(116@,8f) 93@(116@,8f) 101@(116@,8f) 
0085: 117@ = 116@ 
117@ += 1 
if 
  8 > 117@ 
else_jump @DESERT5_9315 
06D5: 119@(117@,8i) = create_racing_checkpoint_at 85@(117@,8f) 93@(117@,8f) 101@(117@,8f) point_to 85@(116@,8f) 93@(116@,8f) 101@(116@,8f) type 3 radius 129@ 

:DESERT5_9315
if 
  116@ == 1 
else_jump @DESERT5_9390 
if 
  34@ == 6 
else_jump @DESERT5_9374 
00BC: show_text_highpriority GXT 'DES5_3H' time 10000 flag 4  
jump @DESERT5_9390 

:DESERT5_9374
00BC: show_text_highpriority GXT 'DES5_3G' time 10000 flag 4  

:DESERT5_9390
if 
  116@ == 2 
else_jump @DESERT5_9465 
if 
  34@ == 6 
else_jump @DESERT5_9449 
00BC: show_text_highpriority GXT 'DES5_3G' time 10000 flag 4  
jump @DESERT5_9465 

:DESERT5_9449
00BC: show_text_highpriority GXT 'DES5_3H' time 10000 flag 4  

:DESERT5_9465
if 
  116@ == 3 
else_jump @DESERT5_9499 
00BC: show_text_highpriority GXT 'DES5_3K' time 10000 flag 4  

:DESERT5_9499
jump @DESERT5_9602 

:DESERT5_9506
161@ = 1 
018A: 220@ = create_checkpoint_at 308.0 45@ 52@ 
if 
  34@ == 6 
else_jump @DESERT5_9570 
00BC: show_text_highpriority GXT 'DES5_5I' time 10000 flag 4  
jump @DESERT5_9586 

:DESERT5_9570
00BC: show_text_highpriority GXT 'DES5_5H' time 10000 flag 4  

:DESERT5_9586
00BB: show_text_lowpriority GXT 'DES5_5J' time 10000 flag 4  

:DESERT5_9602
jump @DESERT5_9689 

:DESERT5_9609
01AC:   car 35@ sphere 1 in_cube_cornerA 288.0 45@ 16.0 cornerB 328.0 47@ 18.0 stopped 
if and
01AB:   car 35@ sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ stopped 
81F3:   not car 35@ in_air 
81F4:   not car 35@ flipped 
else_jump @DESERT5_9689 
235@ = 1 

:DESERT5_9689
if and
  " + _7524 + @" == 1 
81F3:   not car 35@ in_air 
else_jump @DESERT5_9811 
if 
   not 161@ == 1 
else_jump @DESERT5_9744 
236@ = 1 
jump @DESERT5_9811 

:DESERT5_9744
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ 
else_jump @DESERT5_9788 
236@ = 1 
jump @DESERT5_9811 

:DESERT5_9788
if 
01F4:   car 35@ flipped 
else_jump @DESERT5_9811 
236@ = 1 

:DESERT5_9811
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_9854 
236@ = 1 

:DESERT5_9854
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_10293 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_9953 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 80 
148@ = 95 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_9981 

:DESERT5_9953
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_9981
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[3] 
else_jump @DESERT5_10030 
008B: 237@ = " + tmp_Flight_School_Records + @"[3] 
0084: " + tmp_Flight_School_Records + @"[3] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_10030
if 
  " + Flight_School_Contests_Passed + @" == 6 
else_jump @DESERT5_10101 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_10101 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 7 
" + Flight_School_Current_Contest + @" = 7 
232@ = 2 

:DESERT5_10101
gosub @DESERT5_27620 

:DESERT5_10108
if 
  219@ == 0 
else_jump @DESERT5_10199 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_10168 
232@ = 2 
jump @DESERT5_10199 

:DESERT5_10168
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_10192 
jump @DESERT5_10199 

:DESERT5_10192
jump @DESERT5_10108 

:DESERT5_10199
gosub @DESERT5_27200 
156@ = 0 

:DESERT5_10213
if 
  8 > 156@ 
else_jump @DESERT5_10254 
06D6: disable_racing_checkpoint 119@(156@,8i) 
156@ += 1 
jump @DESERT5_10213 

:DESERT5_10254
if 
  232@ == 2 
else_jump @DESERT5_10286 
jump @DESERT5_2600 
jump @DESERT5_10293 

:DESERT5_10286
jump @DESERT5_8528 

:DESERT5_10293
jump @DESERT5_8730 

:DESERT5_10300
if 
  34@ == 7 
else_jump @DESERT5_11736 

:DESERT5_10318
gosub @DESERT5_24907 

:DESERT5_10325
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
" + _7524 + @" = 0 
" + _7525 + @" = 0 
0087: 132@ = 111@ 
234@ = 0 
35@ = Car.Create(#HUNTER, 50@, 51@, 15.07)
Car.Angle(35@) = 270.0
Car.SetToNormalDriver(35@)
if 
  231@ == 0 
else_jump @DESERT5_10491 
Camera.SetPosition(323.02, 2446.81, 117.65, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_10491
241@ = 1 

:DESERT5_10498
if 
  241@ == 1 
else_jump @DESERT5_10566 
wait 0 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_10559 
if 
01C1:   car 35@ stopped 
else_jump @DESERT5_10559 
241@ = 0 

:DESERT5_10559
jump @DESERT5_10498 

:DESERT5_10566
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_7A' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_10596
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_10635 
232@ = 2 
jump @DESERT5_11683 

:DESERT5_10635
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_10704 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_10697 
232@ = 2 
jump @DESERT5_11683 
jump @DESERT5_10704 

:DESERT5_10697
jump @DESERT5_29947 

:DESERT5_10704
if 
  233@ == 0 
else_jump @DESERT5_10816 
00BC: show_text_highpriority GXT 'DES5_7A' time 10000 flag 4  
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_10809 
if 
01F3:   car 35@ in_air 
else_jump @DESERT5_10809 
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
00BC: show_text_highpriority GXT 'DES5_7B' time 10000 flag 4  
233@ = 1 

:DESERT5_10809
jump @DESERT5_11729 

:DESERT5_10816
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_11729 
if 
   not " + _7525 + @" == 1 
else_jump @DESERT5_10922 
Car.StorePos(35@, 37@, 38@, 39@)
if 
0035:   39@ >= 132@ 
else_jump @DESERT5_10922 
" + _7525 + @" = 1 
00BC: show_text_highpriority GXT 'DES5_7C' time 5000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_7D' time 10000 flag 4  

:DESERT5_10922
if 
  " + _7525 + @" == 1 
else_jump @DESERT5_11194 
if 
   not 234@ == 1 
else_jump @DESERT5_11121 
40@ = Car.Angle(35@)
if and
  40@ >= 80.0 
  100.0 >= 40@ 
else_jump @DESERT5_11114 
234@ = 1 
018A: 220@ = create_checkpoint_at 109@ 110@ 111@ 
06D5: 118@ = create_racing_checkpoint_at 109@ 110@ 111@ point_to 0.0 110@ 111@ type 3 radius 129@ 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_7F' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_7G' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_7H' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_7I' time 10000 flag 4  

:DESERT5_11114
jump @DESERT5_11194 

:DESERT5_11121
if 
0100:   actor " + PlayerActor + @" in_sphere 109@ 110@ 111@ radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_11194 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 118@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
235@ = 1 

:DESERT5_11194
if 
   not " + _7524 + @" == 1 
else_jump @DESERT5_11254 
Car.StorePos(35@, 37@, 38@, 39@)
if 
  39@ >= 25.0 
else_jump @DESERT5_11254 
" + _7524 + @" = 1 

:DESERT5_11254
if 
  " + _7524 + @" == 1 
else_jump @DESERT5_11295 
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_11295 
236@ = 1 

:DESERT5_11295
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_11338 
236@ = 1 

:DESERT5_11338
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_11729 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_11437 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 45 
148@ = 60 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_11465 

:DESERT5_11437
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_11465
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[4] 
else_jump @DESERT5_11514 
008B: 237@ = " + tmp_Flight_School_Records + @"[4] 
0084: " + tmp_Flight_School_Records + @"[4] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_11514
if 
  " + Flight_School_Contests_Passed + @" == 7 
else_jump @DESERT5_11585 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_11585 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 8 
" + Flight_School_Current_Contest + @" = 8 
232@ = 2 

:DESERT5_11585
gosub @DESERT5_27620 

:DESERT5_11592
if 
  219@ == 0 
else_jump @DESERT5_11683 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_11652 
232@ = 2 
jump @DESERT5_11683 

:DESERT5_11652
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_11676 
jump @DESERT5_11683 

:DESERT5_11676
jump @DESERT5_11592 

:DESERT5_11683
gosub @DESERT5_27200 
if 
  232@ == 2 
else_jump @DESERT5_11722 
jump @DESERT5_2600 
jump @DESERT5_11729 

:DESERT5_11722
jump @DESERT5_10318 

:DESERT5_11729
jump @DESERT5_10596 

:DESERT5_11736
if 
  34@ == 8 
else_jump @DESERT5_12955 

:DESERT5_11754
gosub @DESERT5_24907 

:DESERT5_11761
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
162@ = 0 
35@ = Car.Create(#HUNTER, 53@, 54@, 55@)
Car.Angle(35@) = 270.0
0825: set_helicopter 35@ instant_rotor_start 
if 
  231@ == 0 
else_jump @DESERT5_11903 
Camera.SetPosition(301.56, 2455.21, 55.82, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_11903
Car.LockInCurrentPosition(35@) = True
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_8A' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_11940
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_11979 
232@ = 2 
jump @DESERT5_12902 

:DESERT5_11979
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_12048 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_12041 
232@ = 2 
jump @DESERT5_12902 
jump @DESERT5_12048 

:DESERT5_12041
jump @DESERT5_29947 

:DESERT5_12048
if 
  233@ == 0 
else_jump @DESERT5_12175 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_12168 
Car.LockInCurrentPosition(35@) = False
Car.SetSpeedInstantly(35@, 15.0)
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
00BC: show_text_highpriority GXT 'DES5_8A' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_8B' time 10000 flag 4  
018A: 220@ = create_checkpoint_at 56@ 57@ 58@ 
233@ = 1 

:DESERT5_12168
jump @DESERT5_12948 

:DESERT5_12175
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_12948 
if 
   not 162@ == 1 
else_jump @DESERT5_12321 
if 
00EE:   actor " + PlayerActor + @" sphere 0 near_point 56@ 57@ radius 300.0 300.0 in_car 
else_jump @DESERT5_12314 
162@ = 1 
00BC: show_text_highpriority GXT 'DES5_8G' time 4000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_8C' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_8D' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_8E' time 10000 flag 4  

:DESERT5_12314
jump @DESERT5_12399 

:DESERT5_12321
01B0:   car 35@ sphere 1 in_sphere 56@ 57@ 58@ radius 26.31 26.31 26.31 stopped 
if and
01AB:   car 35@ sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ stopped 
81F3:   not car 35@ in_air 
81F4:   not car 35@ flipped 
else_jump @DESERT5_12399 
235@ = 1 

:DESERT5_12399
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_12514 
if 
   not 162@ == 1 
else_jump @DESERT5_12447 
236@ = 1 
jump @DESERT5_12514 

:DESERT5_12447
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ 
else_jump @DESERT5_12491 
236@ = 1 
jump @DESERT5_12514 

:DESERT5_12491
if 
01F4:   car 35@ flipped 
else_jump @DESERT5_12514 
236@ = 1 

:DESERT5_12514
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_12557 
236@ = 1 

:DESERT5_12557
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_12948 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_12656 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 30 
148@ = 45 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_12684 

:DESERT5_12656
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_12684
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[5] 
else_jump @DESERT5_12733 
008B: 237@ = " + tmp_Flight_School_Records + @"[5] 
0084: " + tmp_Flight_School_Records + @"[5] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_12733
if 
  " + Flight_School_Contests_Passed + @" == 8 
else_jump @DESERT5_12804 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_12804 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 9 
" + Flight_School_Current_Contest + @" = 9 
232@ = 2 

:DESERT5_12804
gosub @DESERT5_27620 

:DESERT5_12811
if 
  219@ == 0 
else_jump @DESERT5_12902 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_12871 
232@ = 2 
jump @DESERT5_12902 

:DESERT5_12871
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_12895 
jump @DESERT5_12902 

:DESERT5_12895
jump @DESERT5_12811 

:DESERT5_12902
gosub @DESERT5_27200 
if 
  232@ == 2 
else_jump @DESERT5_12941 
jump @DESERT5_2600 
jump @DESERT5_12948 

:DESERT5_12941
jump @DESERT5_11754 

:DESERT5_12948
jump @DESERT5_11940 

:DESERT5_12955
if 
  34@ == 9 
else_jump @DESERT5_15284 

:DESERT5_12973
gosub @DESERT5_24907 

:DESERT5_12980
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
169@ = 0 
35@ = Car.Create(#HUNTER, 53@, 54@, 55@)
Car.Angle(35@) = 270.0
0825: set_helicopter 35@ instant_rotor_start 
if 
  231@ == 0 
else_jump @DESERT5_13233 
Camera.SetPosition(365.5, 2339.25, 63.23, 0.0, 0.0, 0.0)
Camera.PointAt(363.09, 2473.76, 33.46, 2)
69@ = 418.5 
156@ = 0 

:DESERT5_13147
if 
001D:   63@ > 156@ 
else_jump @DESERT5_13224 
60@(156@,3i) = Car.Create(#PETRO, 69@, 49@, 17.1)
69@ -= 40.0 
170@(156@,3i) = 0 
156@ += 1 
jump @DESERT5_13147 

:DESERT5_13224
33@ = 0 
return 

:DESERT5_13233
Car.LockInCurrentPosition(35@) = True
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_9A' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_13270
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_13305 
232@ = 2 
jump @DESERT5_15096 

:DESERT5_13305
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_13374 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_13367 
232@ = 2 
jump @DESERT5_15096 
jump @DESERT5_13374 

:DESERT5_13367
jump @DESERT5_29947 

:DESERT5_13374
if 
  233@ == 0 
else_jump @DESERT5_13604 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_13597 
Car.LockInCurrentPosition(35@) = False
Car.SetSpeedInstantly(35@, 15.0)
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
00BC: show_text_highpriority GXT 'DES5_9A' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_9B' time 10000 flag 4  
69@ = 418.5 
156@ = 0 

:DESERT5_13490
if 
001D:   63@ > 156@ 
else_jump @DESERT5_13583 
60@(156@,3i) = Car.Create(#PETRO, 69@, 49@, 17.1)
221@(156@,3i) = Marker.CreateAboveCar(60@(156@,3i))
163@(156@,3i) = 1 
69@ -= 40.0 
156@ += 1 
jump @DESERT5_13490 

:DESERT5_13583
59@ = 0 
233@ = 1 

:DESERT5_13597
jump @DESERT5_15277 

:DESERT5_13604
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_15277 
if 
   not 169@ == 1 
else_jump @DESERT5_14515 
168@ = 1 
0871: init_jump_table 59@ total_jumps 2 default_jump 1 @DESERT5_14494 jumps 0 @DESERT5_13708 1 @DESERT5_14293 -1 @DESERT5_14508 -1 @DESERT5_14508 -1 @DESERT5_14508 -1 @DESERT5_14508 -1 @DESERT5_14508 

:DESERT5_13708
156@ = 0 

:DESERT5_13715
if 
001D:   63@ > 156@ 
else_jump @DESERT5_13824 
if 
   Car.Wrecked(60@(156@,3i))
else_jump @DESERT5_13803 
if 
  163@(156@,3i) == 1 
else_jump @DESERT5_13796 
Marker.Disable(221@(156@,3i))
163@(156@,3i) = 0 

:DESERT5_13796
jump @DESERT5_13810 

:DESERT5_13803
168@ = 0 

:DESERT5_13810
156@ += 1 
jump @DESERT5_13715 

:DESERT5_13824
if 
  168@ == 1 
else_jump @DESERT5_14286 
59@ = 1 
64@ = Car.Create(#LANDSTAL, 22.61, 2322.06, 22.35)
65@ = Car.Create(#LANDSTAL, 74.58, 2375.99, 16.52)
67@ = Actor.CreateAsDriver(Mission2, #MALE01, 64@)
68@ = Actor.CreateAsDriver(Mission2, #MALE01, 65@)
05D6: clear_scmpath 
05D7: add_point_to_scmpath 76.44 2327.46 20.63 
05D7: add_point_to_scmpath 74.58 2375.99 16.52 
05D7: add_point_to_scmpath 19.12 2370.77 18.97 
05D7: add_point_to_scmpath 22.61 2322.06 22.35 
0615: define_AS_pack_begin 71@ 
06BB: set_actor -1 drive_car 64@ speed 10.0 along_SCM_path 
0643: set_AS_pack 71@ loop 1 
0616: define_AS_pack_end 71@ 
0618: assign_actor 67@ to_AS_pack 71@ 
061B: remove_references_to_AS_pack 71@ 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 19.12 2370.77 18.97 
05D7: add_point_to_scmpath 22.61 2322.06 22.35 
05D7: add_point_to_scmpath 76.44 2327.46 20.63 
05D7: add_point_to_scmpath 74.58 2375.99 16.52 
0615: define_AS_pack_begin 72@ 
06BB: set_actor -1 drive_car 65@ speed 10.0 along_SCM_path 
0643: set_AS_pack 72@ loop 1 
0616: define_AS_pack_end 72@ 
0618: assign_actor 68@ to_AS_pack 72@ 
061B: remove_references_to_AS_pack 72@ 
156@ = 0 

:DESERT5_14150
if 
001D:   66@ > 156@ 
else_jump @DESERT5_14221 
Car.DoorStatus(64@(156@,2i)) = 2
224@(156@,2i) = Marker.CreateAboveCar(64@(156@,2i))
166@(156@,2i) = 1 
156@ += 1 
jump @DESERT5_14150 

:DESERT5_14221
00BC: show_text_highpriority GXT 'DES5_9D' time 10000 flag 4  
156@ = 0 

:DESERT5_14244
if 
001D:   63@ > 156@ 
else_jump @DESERT5_14286 
Car.RemoveReferences(60@(156@,3i))
156@ += 1 
jump @DESERT5_14244 

:DESERT5_14286
jump @DESERT5_14508 

:DESERT5_14293
156@ = 0 

:DESERT5_14300
if 
001D:   66@ > 156@ 
else_jump @DESERT5_14409 
if 
   Car.Wrecked(64@(156@,2i))
else_jump @DESERT5_14388 
if 
  166@(156@,2i) == 1 
else_jump @DESERT5_14381 
Marker.Disable(224@(156@,2i))
166@(156@,2i) = 0 

:DESERT5_14381
jump @DESERT5_14395 

:DESERT5_14388
168@ = 0 

:DESERT5_14395
156@ += 1 
jump @DESERT5_14300 

:DESERT5_14409
if 
  168@ == 1 
else_jump @DESERT5_14487 
59@ = -1 
018A: 220@ = create_checkpoint_at 56@ 57@ 58@ 
00BC: show_text_highpriority GXT 'DES5_9E' time 10000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_5J' time 10000 flag 4  
169@ = 1 

:DESERT5_14487
jump @DESERT5_14508 

:DESERT5_14494
169@ = 1 
jump @DESERT5_14508 

:DESERT5_14508
jump @DESERT5_14593 

:DESERT5_14515
01B0:   car 35@ sphere 1 in_sphere 56@ 57@ 58@ radius 26.31 26.31 26.31 stopped 
if and
01AB:   car 35@ sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ stopped 
81F3:   not car 35@ in_air 
81F4:   not car 35@ flipped 
else_jump @DESERT5_14593 
235@ = 1 

:DESERT5_14593
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_14708 
if 
   not 169@ == 1 
else_jump @DESERT5_14641 
236@ = 1 
jump @DESERT5_14708 

:DESERT5_14641
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 44@ 45@ cornerB 46@ 47@ 
else_jump @DESERT5_14685 
236@ = 1 
jump @DESERT5_14708 

:DESERT5_14685
if 
01F4:   car 35@ flipped 
else_jump @DESERT5_14708 
236@ = 1 

:DESERT5_14708
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_14751 
236@ = 1 

:DESERT5_14751
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_15277 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_14850 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 80 
148@ = 105 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_14878 

:DESERT5_14850
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_14878
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[6] 
else_jump @DESERT5_14927 
008B: 237@ = " + tmp_Flight_School_Records + @"[6] 
0084: " + tmp_Flight_School_Records + @"[6] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_14927
if 
  " + Flight_School_Contests_Passed + @" == 9 
else_jump @DESERT5_14998 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_14998 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 10 
" + Flight_School_Current_Contest + @" = 10 
232@ = 2 

:DESERT5_14998
gosub @DESERT5_27620 

:DESERT5_15005
if 
  219@ == 0 
else_jump @DESERT5_15096 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_15065 
232@ = 2 
jump @DESERT5_15096 

:DESERT5_15065
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_15089 
jump @DESERT5_15096 

:DESERT5_15089
jump @DESERT5_15005 

:DESERT5_15096
gosub @DESERT5_27200 
061B: remove_references_to_AS_pack 71@ 
061B: remove_references_to_AS_pack 72@ 
156@ = 0 

:DESERT5_15120
if 
001D:   63@ > 156@ 
else_jump @DESERT5_15171 
Car.Destroy(60@(156@,3i))
Marker.Disable(221@(156@,3i))
156@ += 1 
jump @DESERT5_15120 

:DESERT5_15171
156@ = 0 

:DESERT5_15178
if 
001D:   66@ > 156@ 
else_jump @DESERT5_15238 
Actor.DestroyInstantly(67@(156@,2i))
Car.Destroy(64@(156@,2i))
Marker.Disable(224@(156@,2i))
156@ += 1 
jump @DESERT5_15178 

:DESERT5_15238
if 
  232@ == 2 
else_jump @DESERT5_15270 
jump @DESERT5_2600 
jump @DESERT5_15277 

:DESERT5_15270
jump @DESERT5_12973 

:DESERT5_15277
jump @DESERT5_13270 

:DESERT5_15284
if 
  34@ == 10 
else_jump @DESERT5_16962 

:DESERT5_15302
gosub @DESERT5_24907 

:DESERT5_15309
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
173@ = 0 
174@ = 0 
35@ = Car.Create(#STUNT, 53@, 113@, 114@)
Car.Angle(35@) = 270.0
if 
  231@ == 0 
else_jump @DESERT5_15453 
Camera.SetPosition(269.53, 2445.3, 88.46, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_15453
Car.LockInCurrentPosition(35@) = True
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_AA' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_15490
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_15529 
232@ = 2 
jump @DESERT5_16899 

:DESERT5_15529
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_15598 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_15591 
232@ = 2 
jump @DESERT5_16899 
jump @DESERT5_15598 

:DESERT5_15591
jump @DESERT5_29947 

:DESERT5_15598
if 
  233@ == 0 
else_jump @DESERT5_15785 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_15778 
Car.LockInCurrentPosition(35@) = False
Car.SetSpeedInstantly(35@, 20.0)
233@ = 1 
018A: 220@ = create_checkpoint_at 112@ 113@ 114@ 
06D5: 127@ = create_racing_checkpoint_at 112@ 113@ 114@ point_to 0.0 113@ 114@ type 3 radius 129@ 
06D5: 128@ = create_racing_checkpoint_at 115@ 113@ 114@ point_to 0.0 113@ 114@ type 3 radius 129@ 
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
00BC: show_text_highpriority GXT 'DES5_AA' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_AB' time 10000 flag 4  

:DESERT5_15778
jump @DESERT5_16955 

:DESERT5_15785
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_16955 
if 
   not 173@ == 1 
else_jump @DESERT5_15943 
if 
0100:   actor " + PlayerActor + @" in_sphere 112@ 113@ 114@ radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_15936 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 127@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
173@ = 1 
00BC: show_text_highpriority GXT 'DES5_AC' time 5000 flag 4  
077D: " + _7514 + @" = car 35@ x_angle 
" + _7516 + @" = 0.0 
" + _7521 + @" = 0.0 

:DESERT5_15936
jump @DESERT5_16488 

:DESERT5_15943
if 
   not 174@ == 1 
else_jump @DESERT5_16415 
06BE: " + _7517 + @" = car 35@ y_angle 
if 
  0.0 > " + _7517 + @" 
else_jump @DESERT5_16000 
" + _7517 + @" += 360.0 

:DESERT5_16000
083F: get_car 35@ vertical_deviation_to " + _7522 + @" 
if 
  " + _7522 + @" >= 0.0 
else_jump @DESERT5_16074 
if and
  " + _7517 + @" >= 20.0 
  340.0 >= " + _7517 + @" 
else_jump @DESERT5_16067 
236@ = 1 

:DESERT5_16067
jump @DESERT5_16112 

:DESERT5_16074
if or
  160.0 >= " + _7517 + @" 
  " + _7517 + @" >= 200.0 
else_jump @DESERT5_16112 
236@ = 1 

:DESERT5_16112
077D: " + _7513 + @" = car 35@ x_angle 
0086: " + _7515 + @" = " + _7513 + @" 
0061: " + _7515 + @" -= " + _7514 + @" 
0086: " + _7514 + @" = " + _7513 + @" 
if 
  " + _7515 + @" > 180.0 
else_jump @DESERT5_16175 
" + _7515 + @" -= 360.0 

:DESERT5_16175
if 
  -180.0 > " + _7515 + @" 
else_jump @DESERT5_16206 
" + _7515 + @" += 360.0 

:DESERT5_16206
if 
  0.0 > " + _7515 + @" 
else_jump @DESERT5_16242 
0059: " + _7521 + @" += " + _7515 + @" 
jump @DESERT5_16304 

:DESERT5_16242
if 
  0.0 > " + _7521 + @" 
else_jump @DESERT5_16278 
0059: " + _7521 + @" += " + _7515 + @" 
jump @DESERT5_16304 

:DESERT5_16278
0059: " + _7516 + @" += " + _7521 + @" 
" + _7521 + @" = 0.0 
0059: " + _7516 + @" += " + _7515 + @" 

:DESERT5_16304
if 
  -20.0 > " + _7521 + @" 
else_jump @DESERT5_16332 
236@ = 1 

:DESERT5_16332
if 
   not 236@ == 1 
else_jump @DESERT5_16408 
if 
  " + _7516 + @" >= 360.0 
else_jump @DESERT5_16408 
174@ = 1 
018A: 220@ = create_checkpoint_at 115@ 113@ 114@ 
00BC: show_text_highpriority GXT 'DES5_AD' time 10000 flag 4  

:DESERT5_16408
jump @DESERT5_16488 

:DESERT5_16415
if 
0100:   actor " + PlayerActor + @" in_sphere 115@ 113@ 114@ radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_16488 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 128@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
235@ = 1 

:DESERT5_16488
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_16511 
236@ = 1 

:DESERT5_16511
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_16554 
236@ = 1 

:DESERT5_16554
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_16955 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_16653 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 21 
148@ = 27 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_16681 

:DESERT5_16653
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_16681
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[7] 
else_jump @DESERT5_16730 
008B: 237@ = " + tmp_Flight_School_Records + @"[7] 
0084: " + tmp_Flight_School_Records + @"[7] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_16730
if 
  " + Flight_School_Contests_Passed + @" == 10 
else_jump @DESERT5_16801 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_16801 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 11 
" + Flight_School_Current_Contest + @" = 11 
232@ = 2 

:DESERT5_16801
gosub @DESERT5_27620 

:DESERT5_16808
if 
  219@ == 0 
else_jump @DESERT5_16899 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_16868 
232@ = 2 
jump @DESERT5_16899 

:DESERT5_16868
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_16892 
jump @DESERT5_16899 

:DESERT5_16892
jump @DESERT5_16808 

:DESERT5_16899
gosub @DESERT5_27200 
06D6: disable_racing_checkpoint 127@ 
06D6: disable_racing_checkpoint 128@ 
if 
  232@ == 2 
else_jump @DESERT5_16948 
jump @DESERT5_2600 
jump @DESERT5_16955 

:DESERT5_16948
jump @DESERT5_15302 

:DESERT5_16955
jump @DESERT5_15490 

:DESERT5_16962
if 
  34@ == 11 
else_jump @DESERT5_18542 

:DESERT5_16980
gosub @DESERT5_24907 

:DESERT5_16987
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
173@ = 0 
174@ = 0 
35@ = Car.Create(#STUNT, 53@, 113@, 114@)
Car.Angle(35@) = 270.0
if 
  231@ == 0 
else_jump @DESERT5_17131 
Camera.SetPosition(292.95, 2445.3, 93.46, 0.0, 0.0, 0.0)
Camera.OnVehicle(35@, 15, 2)
return 

:DESERT5_17131
Car.LockInCurrentPosition(35@) = True
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_AA' time 5000 flag 4  
gosub @DESERT5_24944 

:DESERT5_17168
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_17207 
232@ = 2 
jump @DESERT5_18479 

:DESERT5_17207
gosub @DESERT5_25097 
if 
  232@ == 1 
else_jump @DESERT5_17276 
if 
02BF:   car 35@ sunk 
else_jump @DESERT5_17269 
232@ = 2 
jump @DESERT5_18479 
jump @DESERT5_17276 

:DESERT5_17269
jump @DESERT5_29947 

:DESERT5_17276
if 
  233@ == 0 
else_jump @DESERT5_17463 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_17456 
Car.LockInCurrentPosition(35@) = False
Car.SetSpeedInstantly(35@, 20.0)
233@ = 1 
018A: 220@ = create_checkpoint_at 112@ 113@ 114@ 
06D5: 127@ = create_racing_checkpoint_at 112@ 113@ 114@ point_to 0.0 113@ 114@ type 3 radius 129@ 
06D5: 128@ = create_racing_checkpoint_at 115@ 113@ 114@ point_to 0.0 113@ 114@ type 3 radius 129@ 
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
00BC: show_text_highpriority GXT 'DES5_AA' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_BB' time 10000 flag 4  

:DESERT5_17456
jump @DESERT5_18535 

:DESERT5_17463
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_18535 
if 
   not 173@ == 1 
else_jump @DESERT5_17654 
if 
0100:   actor " + PlayerActor + @" in_sphere 112@ 113@ 114@ radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_17647 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 127@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
173@ = 1 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_BC' time 5000 flag 4  
06BE: " + _7518 + @" = car 35@ y_angle 
if 
  0.0 > " + _7518 + @" 
else_jump @DESERT5_17627 
" + _7518 + @" += 360.0 

:DESERT5_17627
" + _7520 + @" = 0.0 
" + _7521 + @" = 0.0 

:DESERT5_17647
jump @DESERT5_18068 

:DESERT5_17654
if 
   not 174@ == 1 
else_jump @DESERT5_17995 
06BE: " + _7517 + @" = car 35@ y_angle 
if 
  0.0 > " + _7517 + @" 
else_jump @DESERT5_17711 
" + _7517 + @" += 360.0 

:DESERT5_17711
0086: " + _7519 + @" = " + _7517 + @" 
0061: " + _7519 + @" -= " + _7518 + @" 
0086: " + _7518 + @" = " + _7517 + @" 
if 
  " + _7519 + @" > 180.0 
else_jump @DESERT5_17766 
" + _7519 + @" -= 360.0 

:DESERT5_17766
if 
  -180.0 > " + _7519 + @" 
else_jump @DESERT5_17797 
" + _7519 + @" += 360.0 

:DESERT5_17797
if 
  0.0 > " + _7519 + @" 
else_jump @DESERT5_17833 
0059: " + _7521 + @" += " + _7519 + @" 
jump @DESERT5_17895 

:DESERT5_17833
if 
  0.0 > " + _7521 + @" 
else_jump @DESERT5_17869 
0059: " + _7521 + @" += " + _7519 + @" 
jump @DESERT5_17895 

:DESERT5_17869
0059: " + _7520 + @" += " + _7521 + @" 
" + _7521 + @" = 0.0 
0059: " + _7520 + @" += " + _7519 + @" 

:DESERT5_17895
if 
  -20.0 > " + _7521 + @" 
else_jump @DESERT5_17930 
236@ = 1 
jump @DESERT5_17988 

:DESERT5_17930
if 
  " + _7520 + @" >= 360.0 
else_jump @DESERT5_17988 
174@ = 1 
018A: 220@ = create_checkpoint_at 115@ 113@ 114@ 
00BC: show_text_highpriority GXT 'DES5_AD' time 10000 flag 4  

:DESERT5_17988
jump @DESERT5_18068 

:DESERT5_17995
if 
0100:   actor " + PlayerActor + @" in_sphere 115@ 113@ 114@ radius 129@ 129@ 129@ sphere 0 in_car 
else_jump @DESERT5_18068 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 128@ 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
235@ = 1 

:DESERT5_18068
if 
81F3:   not car 35@ in_air 
else_jump @DESERT5_18091 
236@ = 1 

:DESERT5_18091
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_18134 
236@ = 1 

:DESERT5_18134
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_18535 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_18233 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 18 
148@ = 23 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_18261 

:DESERT5_18233
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_18261
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[8] 
else_jump @DESERT5_18310 
008B: 237@ = " + tmp_Flight_School_Records + @"[8] 
0084: " + tmp_Flight_School_Records + @"[8] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_18310
if 
  " + Flight_School_Contests_Passed + @" == 11 
else_jump @DESERT5_18381 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_18381 
0623: add 60 to_integer_stat 223 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 12 
" + Flight_School_Current_Contest + @" = 12 
232@ = 2 

:DESERT5_18381
gosub @DESERT5_27620 

:DESERT5_18388
if 
  219@ == 0 
else_jump @DESERT5_18479 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_18448 
232@ = 2 
jump @DESERT5_18479 

:DESERT5_18448
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_18472 
jump @DESERT5_18479 

:DESERT5_18472
jump @DESERT5_18388 

:DESERT5_18479
gosub @DESERT5_27200 
06D6: disable_racing_checkpoint 127@ 
06D6: disable_racing_checkpoint 128@ 
if 
  232@ == 2 
else_jump @DESERT5_18528 
jump @DESERT5_2600 
jump @DESERT5_18535 

:DESERT5_18528
jump @DESERT5_16980 

:DESERT5_18535
jump @DESERT5_17168 

:DESERT5_18542
if 
  34@ == 12 
else_jump @DESERT5_19958 

:DESERT5_18560
gosub @DESERT5_24907 

:DESERT5_18567
" + _253 + @" = 0 
238@ = 0 
232@ = 0 
233@ = 0 
235@ = 0 
236@ = 0 
175@ = 0 
176@ = 0 
if 
  231@ == 0 
else_jump @DESERT5_18780 
70@ = Actor.Create(Mission1, #NULL, 46@, 49@, 250.0)
Actor.Angle(70@) = 90.0
Actor.LockInCurrentPosition(70@) = True
0088: " + _8271 + @" = 136@ 
0088: " + _8272 + @" = 137@ 
0088: " + _8273 + @" = 138@" );
start_new_external_script<PARACH>( -1, ( double ) -10.0, ( double ) 10.0, ( double ) -5.0, ( double ) -2.0, ( double ) 10.0, ( double ) 12.0, 1, _local70 );
load_external_script<PARACH>();
                AppendLine( @"067E: put_camera_on_actor 70@ offset 0.0 -5.0 4.0 target_actor 70@ tilt 0.0 switchstyle 2 
return 

:DESERT5_18780
Actor.PutAt(" + PlayerActor + @", 139@, 140@, 141@)
Actor.Angle(" + PlayerActor + @") = 90.0
Model.Load(#GUN_PARA)

:DESERT5_18809
if 
   not Model.Available(#GUN_PARA)
else_jump @DESERT5_18836 
wait 0 
jump @DESERT5_18809 

:DESERT5_18836
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", Parachute, 1)
" + _1500 + @" = 5.0 
" + _1501 + @" = -5.0 
" + _1502 + @" = 8.5 
" + _1503 + @" = -1.5 
" + _1504 + @" = -30.0 
" + _1505 + @" = 15.0 
" + _1510 + @" = 0 

:DESERT5_18912
if 
  2 > " + Parachute_Creation_Stage + @" 
else_jump @DESERT5_18941 
wait 0 
jump @DESERT5_18912 

:DESERT5_18941
135@ = Object.Create(#BASEJUMP_TARGET, 136@, 137@, 138@)
Object.Angle(135@) = 90.0
06D5: 143@ = create_racing_checkpoint_at 136@ 137@ 138@ point_to 136@ 137@ 900.0 type 3 radius 6.5 
wait 500 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_CA' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_CI' time 10000 flag 4  
gosub @DESERT5_24944 

:DESERT5_19046
wait 0 
set_weather 17 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_19085 
232@ = 2 
jump @DESERT5_19842 

:DESERT5_19085
if 
  233@ == 0 
else_jump @DESERT5_19147 
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 
018A: 220@ = create_checkpoint_at 136@ 137@ 138@ 
233@ = 1 
jump @DESERT5_19951 

:DESERT5_19147
if 
   not 176@ == 1 
else_jump @DESERT5_19331 
if 
   not 175@ == 1 
else_jump @DESERT5_19241 
Actor.StorePos(" + PlayerActor + @", 41@, 42@, 43@)
if 
  300.0 >= 43@ 
else_jump @DESERT5_19241 
175@ = 1 
00BC: show_text_highpriority GXT 'DES5_CC' time 10000 flag 4  

:DESERT5_19241
if 
00E1:   player 0 pressed_key 17 
else_jump @DESERT5_19331 
176@ = 1 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'DES5_CD' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_CF' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_CH' time 7000 flag 4  
00BB: show_text_lowpriority GXT 'DES5_CE' time 7000 flag 4  

:DESERT5_19331
if 
  176@ == 1 
else_jump @DESERT5_19440 
if 
  " + _1498 + @" == 1 
else_jump @DESERT5_19440 
Actor.StorePos(" + PlayerActor + @", 41@, 42@, 43@)
0509: 142@ = distance_between_XY 41@ 42@ and_XY 136@ 137@ 
if 
  10.0 >= 142@ 
else_jump @DESERT5_19433 
235@ = 1 
jump @DESERT5_19440 

:DESERT5_19433
236@ = 1 

:DESERT5_19440
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point -450.0 49@ radius 1250.0 1250.0 
else_jump @DESERT5_19483 
236@ = 1 

:DESERT5_19483
if or
  235@ == 1 
  236@ == 1 
else_jump @DESERT5_19951 
gosub @DESERT5_25367 
if 
  235@ == 1 
else_jump @DESERT5_19582 
gosub @DESERT5_25988 
gosub @DESERT5_26721 
147@ = 55 
148@ = 70 
gosub @DESERT5_26882 
gosub @DESERT5_27044 
jump @DESERT5_19610 

:DESERT5_19582
" + _301 + @" = 0 
" + _267 + @" = 0 
145@ = 0 
" + Current_Flight_Record + @" = 0 

:DESERT5_19610
if 
001C:   " + Current_Flight_Record + @" > " + tmp_Flight_School_Records + @"[9] 
else_jump @DESERT5_19659 
008B: 237@ = " + tmp_Flight_School_Records + @"[9] 
0084: " + tmp_Flight_School_Records + @"[9] = " + Current_Flight_Record + @" 
238@ = 1 
gosub @DESERT5_25412 

:DESERT5_19659
if 
   not " + Mission_Learning_to_Fly_Passed + @" == 1 
else_jump @DESERT5_19744 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_19744 
238@ = 2 
" + Flight_School_Contests_Passed + @" = 12 
" + Flight_School_Current_Contest + @" = 12 
232@ = 2 
0623: add 60 to_integer_stat 223 
" + Mission_Learning_to_Fly_Passed + @" = 1 
177@ = 1 

:DESERT5_19744
gosub @DESERT5_27620 

:DESERT5_19751
if 
  219@ == 0 
else_jump @DESERT5_19842 
wait 0 
gosub @DESERT5_29325 
if 
00E1:   player 0 pressed_key 15 
else_jump @DESERT5_19811 
232@ = 2 
jump @DESERT5_19842 

:DESERT5_19811
if 
00E1:   player 0 pressed_key 16 
else_jump @DESERT5_19835 
jump @DESERT5_19842 

:DESERT5_19835
jump @DESERT5_19751 

:DESERT5_19842
gosub @DESERT5_27200 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
if 
  177@ == 1 
else_jump @DESERT5_19912 
fade 1 500 

:DESERT5_19881
if 
fading 
else_jump @DESERT5_19905 
wait 0 
jump @DESERT5_19881 

:DESERT5_19905
jump @DESERT5_29990 

:DESERT5_19912
if 
  232@ == 2 
else_jump @DESERT5_19944 
jump @DESERT5_2600 
jump @DESERT5_19951 

:DESERT5_19944
jump @DESERT5_18560 

:DESERT5_19951
jump @DESERT5_19046 

:DESERT5_19958
85@ = -383.79 
0087: 93@ = 49@ 
101@ = 147.09 
0087: 86@ = 85@ 
86@ -= 300.0 
0087: 91@ = 85@ 
91@ -= 300.0 
if or
  34@ == 3 
  34@ == 5 
else_jump @DESERT5_20090 
0087: 94@ = 93@ 
94@ -= 300.0 
0087: 99@ = 93@ 
99@ += 300.0 
jump @DESERT5_20126 

:DESERT5_20090
0087: 94@ = 93@ 
94@ += 300.0 
0087: 99@ = 93@ 
99@ -= 300.0 

:DESERT5_20126
0087: 102@ = 101@ 
0087: 107@ = 101@ 
130@ = 350.0 
if or
  34@ == 3 
  34@ == 5 
else_jump @DESERT5_20194 
131@ = 270.0 
jump @DESERT5_20204 

:DESERT5_20194
131@ = 90.0 

:DESERT5_20204
0087: 133@ = 85@ 
133@ -= 600.0 
0087: 134@ = 93@ 
156@ = 2 

:DESERT5_20237
if 
  5 >= 156@ 
else_jump @DESERT5_20405 
02F7: 85@(156@,8f) = cosine 131@ 
02F6: 93@(156@,8f) = sine 131@ 
006B: 85@(156@,8f) *= 130@ 
006B: 93@(156@,8f) *= 130@ 
005B: 85@(156@,8f) += 133@ 
005B: 93@(156@,8f) += 134@ 
0087: 101@(156@,8f) = 101@ 
if or
  34@ == 3 
  34@ == 5 
else_jump @DESERT5_20381 
131@ -= 60.0 
jump @DESERT5_20391 

:DESERT5_20381
131@ += 60.0 

:DESERT5_20391
156@ += 1 
jump @DESERT5_20237 

:DESERT5_20405
0087: 92@ = 85@ 
0087: 100@ = 93@ 
0087: 108@ = 101@ 
if or
  34@ == 5 
  34@ == 6 
else_jump @DESERT5_20474 
92@ += 20.0 
108@ -= 30.0 

:DESERT5_20474
return 

:DESERT5_20476
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 225.0 size 612.0 438.0 RGBA 0 0 0 227@ 
if 
  226@ == 1 
else_jump @DESERT5_20598 
if 
  255 > 227@ 
else_jump @DESERT5_20591 
227@ += 5 
if 
  227@ > 255 
else_jump @DESERT5_20584 
227@ = 255 

:DESERT5_20584
jump @DESERT5_20598 

:DESERT5_20591
226@ = 2 

:DESERT5_20598
if 
  226@ == 3 
else_jump @DESERT5_20680 
if 
  227@ > 0 
else_jump @DESERT5_20673 
227@ -= 5 
if 
  0 > 227@ 
else_jump @DESERT5_20666 
227@ = 0 

:DESERT5_20666
jump @DESERT5_20680 

:DESERT5_20673
226@ = 0 

:DESERT5_20680
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 0.0 size 640.0 197.0 RGBA 0 0 0 255 
gosub @DESERT5_24787 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  34@ == 1 
else_jump @DESERT5_20792 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MA'  
008B: 228@ = " + tmp_Flight_School_Records + @"[0] 
gosub @DESERT5_22125 

:DESERT5_20792
if 
  34@ == 2 
else_jump @DESERT5_20846 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MB'  
008B: 228@ = " + tmp_Flight_School_Records + @"[1] 
gosub @DESERT5_22125 

:DESERT5_20846
if 
  34@ == 3 
else_jump @DESERT5_20900 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MC'  
008B: 228@ = " + tmp_Flight_School_Records + @"[2] 
gosub @DESERT5_22125 

:DESERT5_20900
if 
  34@ == 4 
else_jump @DESERT5_20954 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MC'  
008B: 228@ = " + tmp_Flight_School_Records + @"[2] 
gosub @DESERT5_22125 

:DESERT5_20954
if 
  34@ == 5 
else_jump @DESERT5_21008 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MD'  
008B: 228@ = " + tmp_Flight_School_Records + @"[3] 
gosub @DESERT5_22125 

:DESERT5_21008
if 
  34@ == 6 
else_jump @DESERT5_21062 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MD'  
008B: 228@ = " + tmp_Flight_School_Records + @"[3] 
gosub @DESERT5_22125 

:DESERT5_21062
if 
  34@ == 7 
else_jump @DESERT5_21116 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_ME'  
008B: 228@ = " + tmp_Flight_School_Records + @"[4] 
gosub @DESERT5_22125 

:DESERT5_21116
if 
  34@ == 8 
else_jump @DESERT5_21170 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MF'  
008B: 228@ = " + tmp_Flight_School_Records + @"[5] 
gosub @DESERT5_22125 

:DESERT5_21170
if 
  34@ == 9 
else_jump @DESERT5_21224 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MG'  
008B: 228@ = " + tmp_Flight_School_Records + @"[6] 
gosub @DESERT5_22125 

:DESERT5_21224
if 
  34@ == 10 
else_jump @DESERT5_21278 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MH'  
008B: 228@ = " + tmp_Flight_School_Records + @"[7] 
gosub @DESERT5_22125 

:DESERT5_21278
if 
  34@ == 11 
else_jump @DESERT5_21332 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MI'  
008B: 228@ = " + tmp_Flight_School_Records + @"[8] 
gosub @DESERT5_22125 

:DESERT5_21332
if 
  34@ == 12 
else_jump @DESERT5_21386 
033E: set_draw_text_position 322.0 31.0 GXT 'DES5_MJ'  
008B: 228@ = " + tmp_Flight_School_Records + @"[9] 
gosub @DESERT5_22125 

:DESERT5_21386
gosub @DESERT5_24667 
0904: get_interface 6 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'DES5_FO'  
if 
   not 230@ == 1 
else_jump @DESERT5_21655 
gosub @DESERT5_24667 
0904: get_interface 6 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'DES5_FP'  
gosub @DESERT5_24667 
if 
   not " + Flight_School_Contests_Passed + @" == 1 
else_jump @DESERT5_21592 
0904: get_interface 6 color_RGBA_to 152@ 153@ 154@ 155@ 
jump @DESERT5_21608 

:DESERT5_21592
0904: get_interface 8 color_RGBA_to 152@ 153@ 154@ 155@ 

:DESERT5_21608
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'DES5_FN'  

:DESERT5_21655
gosub @DESERT5_24667 
0904: get_interface 4 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 150.0 360.0 GXT 'DES5_FL'  
if 
   not 230@ == 1 
else_jump @DESERT5_21883 
gosub @DESERT5_24667 
0904: get_interface 4 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 150.0 340.0 GXT 'SCH_PRS'  
gosub @DESERT5_24667 
0904: get_interface 4 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'DES5_FK'  

:DESERT5_21883
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 160.0 317.0 size 320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 480.0 317.0 size -320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 9 position 160.0 435.0 size 320.0 17.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 9 position 480.0 435.0 size -320.0 17.0 RGBA 150 150 150 255 
return 

:DESERT5_22125
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 430.0 size 640.0 250.0 RGBA 0 0 0 255 
if 
  70 > 228@ 
else_jump @DESERT5_22187 
229@ = 1 

:DESERT5_22187
if 
  228@ > 69 
else_jump @DESERT5_22230 
if 
  85 > 228@ 
else_jump @DESERT5_22230 
229@ = 2 

:DESERT5_22230
if 
  228@ > 84 
else_jump @DESERT5_22273 
if 
  100 > 228@ 
else_jump @DESERT5_22273 
229@ = 3 

:DESERT5_22273
if 
  228@ == 100 
else_jump @DESERT5_22298 
229@ = 4 

:DESERT5_22298
gosub @DESERT5_24667 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0904: get_interface 3 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
if 
  229@ > 1 
else_jump @DESERT5_22392 
045A: draw_text_1number 320.0 75.0 GXT 'DES5_FQ' number 228@  
jump @DESERT5_22413 

:DESERT5_22392
033E: set_draw_text_position 320.0 75.0 GXT 'DES5_FR'  

:DESERT5_22413
if 
  229@ > 1 
else_jump @DESERT5_22518 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 
jump @DESERT5_22598 

:DESERT5_22518
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 

:DESERT5_22598
03E3: set_texture_to_be_drawn_antialiased 1 
if 
  229@ == 1 
else_jump @DESERT5_22784 
09FB: 242@ = current_language 
if 
04A4:   242@ == 0 
else_jump @DESERT5_22686 
038D: draw_texture 6 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
jump @DESERT5_22722 

:DESERT5_22686
038D: draw_texture 10 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 

:DESERT5_22722
gosub @DESERT5_24667 
0342: set_text_draw_centered 1 
0904: get_interface 3 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033E: set_draw_text_position 320.0 375.0 GXT 'DES5_FS'  

:DESERT5_22784
if 
  229@ == 2 
else_jump @DESERT5_22900 
038D: draw_texture 1 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @DESERT5_24667 
0342: set_text_draw_centered 1 
0904: get_interface 3 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033E: set_draw_text_position 320.0 375.0 GXT 'DES5_FF'  

:DESERT5_22900
if 
  229@ == 3 
else_jump @DESERT5_23016 
038D: draw_texture 2 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @DESERT5_24667 
0342: set_text_draw_centered 1 
0904: get_interface 3 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033E: set_draw_text_position 320.0 375.0 GXT 'DES5_FE'  

:DESERT5_23016
if 
  229@ == 4 
else_jump @DESERT5_23132 
038D: draw_texture 3 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @DESERT5_24667 
0342: set_text_draw_centered 1 
0904: get_interface 3 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033E: set_draw_text_position 320.0 375.0 GXT 'DES5_FD'  

:DESERT5_23132
return 

:DESERT5_23134
if 
  231@ == 0 
else_jump @DESERT5_23413 
if 
  34@ == 1 
else_jump @DESERT5_23177 
gosub @DESERT5_3984 

:DESERT5_23177
if 
  34@ == 2 
else_jump @DESERT5_23202 
gosub @DESERT5_5493 

:DESERT5_23202
if 
  34@ == 4 
else_jump @DESERT5_23227 
gosub @DESERT5_6956 

:DESERT5_23227
if 
  34@ == 6 
else_jump @DESERT5_23252 
gosub @DESERT5_8535 

:DESERT5_23252
if 
  34@ == 7 
else_jump @DESERT5_23277 
gosub @DESERT5_10325 

:DESERT5_23277
if 
  34@ == 8 
else_jump @DESERT5_23302 
gosub @DESERT5_11761 

:DESERT5_23302
if 
  34@ == 9 
else_jump @DESERT5_23327 
gosub @DESERT5_12980 

:DESERT5_23327
if 
  34@ == 10 
else_jump @DESERT5_23352 
gosub @DESERT5_15309 

:DESERT5_23352
if 
  34@ == 11 
else_jump @DESERT5_23377 
gosub @DESERT5_16987 

:DESERT5_23377
if 
  34@ == 12 
else_jump @DESERT5_23402 
gosub @DESERT5_18567 

:DESERT5_23402
03D1: play_wav 3 
231@ = 1 

:DESERT5_23413
if 
  231@ == 1 
else_jump @DESERT5_23711 
if 
   not 34@ == 12 
else_jump @DESERT5_23616 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_23595 
150@ = 589 
005A: 150@ += 34@ 
if 
  34@ == 4 
else_jump @DESERT5_23506 
150@ -= 1 

:DESERT5_23506
if 
  34@ >= 6 
else_jump @DESERT5_23531 
150@ -= 2 

:DESERT5_23531
if 
87C1:   not path 150@ available 
else_jump @DESERT5_23559 
07C0: load_path 150@ 
jump @DESERT5_23588 

:DESERT5_23559
05EB: assign_car 35@ to_path 150@ 
gosub @DESERT5_24311 
226@ = 3 
231@ = 2 

:DESERT5_23588
jump @DESERT5_23609 

:DESERT5_23595
226@ = 3 
231@ = 2 

:DESERT5_23609
jump @DESERT5_23711 

:DESERT5_23616
if 
   not Actor.Dead(70@)
else_jump @DESERT5_23697 
if 
   Actor.Animation(70@) == ""FALL_SKYDIVE""
else_jump @DESERT5_23690 
Actor.LockInCurrentPosition(70@) = False
33@ = 0 
226@ = 3 
231@ = 2 

:DESERT5_23690
jump @DESERT5_23711 

:DESERT5_23697
226@ = 3 
231@ = 2 

:DESERT5_23711
if 
  231@ == 2 
else_jump @DESERT5_24069 
if 
   not 34@ == 12 
else_jump @DESERT5_23992 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_23971 
if 
860E:   not car 35@ assigned_to_path 
else_jump @DESERT5_23807 
Car.LockInCurrentPosition(35@) = True
226@ = 1 
231@ = 4 
jump @DESERT5_23964 

:DESERT5_23807
0825: set_helicopter 35@ instant_rotor_start 
if 
  34@ == 9 
else_jump @DESERT5_23964 
0541: car 35@ enable_guns_sound 
if and
   not 172@ == 1 
   not Car.Wrecked(62@)
  33@ > 3000 
else_jump @DESERT5_23878 
070C: explode_car_without_radius_damage 62@ 
172@ = 1 

:DESERT5_23878
if and
   not 171@ == 1 
   not Car.Wrecked(61@)
  33@ > 4500 
else_jump @DESERT5_23921 
070C: explode_car_without_radius_damage 61@ 
171@ = 1 

:DESERT5_23921
if and
   not 170@ == 1 
   not Car.Wrecked(60@)
  33@ > 6000 
else_jump @DESERT5_23964 
070C: explode_car_without_radius_damage 60@ 
170@ = 1 

:DESERT5_23964
jump @DESERT5_23985 

:DESERT5_23971
226@ = 1 
231@ = 4 

:DESERT5_23985
jump @DESERT5_24069 

:DESERT5_23992
if 
   not Actor.Dead(70@)
else_jump @DESERT5_24055 
if 
  33@ > 15000 
else_jump @DESERT5_24048 
Actor.LockInCurrentPosition(70@) = True
226@ = 1 
231@ = 4 

:DESERT5_24048
jump @DESERT5_24069 

:DESERT5_24055
226@ = 1 
231@ = 4 

:DESERT5_24069
if 
  231@ == 3 
else_jump @DESERT5_24124 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_24110 
Car.LockInCurrentPosition(35@) = True

:DESERT5_24110
226@ = 1 
231@ = 4 

:DESERT5_24124
if 
  231@ == 4 
else_jump @DESERT5_24309 
if 
  226@ == 2 
else_jump @DESERT5_24309 
05EC: release_car 35@ from_path 
Camera.Restore_WithJumpCut
Actor.DestroyInstantly(70@)
Car.Destroy(35@)
156@ = 0 

:DESERT5_24184
if 
001D:   63@ > 156@ 
else_jump @DESERT5_24226 
Car.Destroy(60@(156@,3i))
156@ += 1 
jump @DESERT5_24184 

:DESERT5_24226
0873: release_path 590 
0873: release_path 591 
0873: release_path 592 
0873: release_path 593 
0873: release_path 594 
0873: release_path 595 
0873: release_path 596 
0873: release_path 597 
0873: release_path 598 
040D: unload_wav 3 
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
231@ = 0 

:DESERT5_24309
return 

:DESERT5_24311
0871: init_jump_table 34@ total_jumps 10 default_jump 1 @DESERT5_24636 jumps 1 @DESERT5_24439 2 @DESERT5_24463 3 @DESERT5_24487 4 @DESERT5_24487 5 @DESERT5_24516 6 @DESERT5_24516 7 @DESERT5_24540 
0872: jump_table_jumps 9 @DESERT5_24564 10 @DESERT5_24588 11 @DESERT5_24612 -1 @DESERT5_24643 -1 @DESERT5_24643 -1 @DESERT5_24643 -1 @DESERT5_24643 -1 @DESERT5_24643 -1 @DESERT5_24643 

:DESERT5_24439
Camera.SetAtPos(172.6, 2466.14, 17.05)
jump @DESERT5_24643 

:DESERT5_24463
Camera.SetAtPos(27.29, 2466.31, 16.76)
jump @DESERT5_24643 

:DESERT5_24487
0A0B: set_rendering_origin_at_3D_coord -1251.02 2301.32 120.44 angle 60.0 
jump @DESERT5_24643 

:DESERT5_24516
Camera.SetAtPos(-394.09, 2601.47, 134.89)
jump @DESERT5_24643 

:DESERT5_24540
Camera.SetAtPos(323.02, 2446.81, 117.65)
jump @DESERT5_24643 

:DESERT5_24564
Camera.SetAtPos(365.5, 2339.25, 63.23)
jump @DESERT5_24643 

:DESERT5_24588
Camera.SetAtPos(269.53, 2445.3, 88.46)
jump @DESERT5_24643 

:DESERT5_24612
Camera.SetAtPos(292.95, 2445.3, 93.46)
jump @DESERT5_24643 

:DESERT5_24636
jump @DESERT5_24643 

:DESERT5_24643
0A0B: set_rendering_origin_at_3D_coord 412.38 2533.65 18.18 angle 90.0 
return 

:DESERT5_24667
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 

:DESERT5_24729
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.8 2.6 
060D: draw_text_shadow 2 rgba 0 0 0 255 
return 

:DESERT5_24787
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.2 4.0 
060D: draw_text_shadow 3 rgba 0 0 0 255 
0349: set_text_draw_font 3 
return 

:DESERT5_24849
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.0 3.4 
060D: draw_text_shadow 3 rgba 0 0 0 255 
0349: set_text_draw_font 3 
return 

:DESERT5_24907
fade 0 500 

:DESERT5_24914
if 
fading 
else_jump @DESERT5_24938 
wait 0 
jump @DESERT5_24914 

:DESERT5_24938
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
return 

:DESERT5_24944
if 
   not 34@ == 12 
else_jump @DESERT5_24986 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_24986 
036A: put_actor " + PlayerActor + @" in_car 35@ 

:DESERT5_24986
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
04E4: refresh_game_renderer_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" 
Camera.SetAtPos(" + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
wait 0 
if 
   not 34@ == 9 
else_jump @DESERT5_25045 
set_weather 17 

:DESERT5_25045
0826: enable_hud 1 
0581: enable_radar 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
fade 1 500 

:DESERT5_25064
if 
fading 
else_jump @DESERT5_25088 
wait 0 
jump @DESERT5_25064 

:DESERT5_25088
Player.CanMove(" + PlayerChar + @") = True
return 

:DESERT5_25097
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_25164 
if 
  233@ == 1 
else_jump @DESERT5_25157 
if 
   not Actor.InCar(" + PlayerActor + @", 35@)
else_jump @DESERT5_25157 
232@ = 1 

:DESERT5_25157
jump @DESERT5_25171 

:DESERT5_25164
232@ = 1 

:DESERT5_25171
return 

:DESERT5_25173
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_25216 
if 
   Actor.InCar(" + PlayerActor + @", 35@)
else_jump @DESERT5_25216 
02E3: " + _7526 + @" = car 35@ speed 

:DESERT5_25216
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @DESERT5_25331 
if 
  " + _7526 + @" > 0.1 
else_jump @DESERT5_25331 
00BE: text_clear_all 
if or
  34@ == 1 
  34@ == 3 
  34@ == 4 
  34@ == 5 
  34@ == 6 
else_jump @DESERT5_25324 
03C3: set_timer_to " + _253 + @" type 0 GXT 'DES5_T4' 

:DESERT5_25324
233@ = 1 

:DESERT5_25331
return 
if 
  " + _253 + @" == 0 
else_jump @DESERT5_25365 
Player.CanMove(" + PlayerChar + @") = False
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 

:DESERT5_25365
return 

:DESERT5_25367
Player.CanMove(" + PlayerChar + @") = False
if 
   not 34@ == 12 
else_jump @DESERT5_25399 
jump @DESERT5_25406 

:DESERT5_25399
Actor.LockInCurrentPosition(" + PlayerActor + @") = True

:DESERT5_25406
0396: pause_timer 1 
return 

:DESERT5_25412
229@ = 0 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DESERT5_25501 
if 
  85 > " + Current_Flight_Record + @" 
else_jump @DESERT5_25501 
if and
  237@ > 69 
  85 > 237@ 
else_jump @DESERT5_25494 
229@ = 0 
jump @DESERT5_25501 

:DESERT5_25494
229@ = 2 

:DESERT5_25501
if 
  " + Current_Flight_Record + @" > 84 
else_jump @DESERT5_25583 
if 
  100 > " + Current_Flight_Record + @" 
else_jump @DESERT5_25583 
if and
  237@ > 84 
  100 > 237@ 
else_jump @DESERT5_25576 
229@ = 0 
jump @DESERT5_25583 

:DESERT5_25576
229@ = 3 

:DESERT5_25583
if 
  " + Current_Flight_Record + @" == 100 
else_jump @DESERT5_25640 
if 
  237@ == 100 
else_jump @DESERT5_25633 
229@ = 0 
jump @DESERT5_25640 

:DESERT5_25633
229@ = 4 

:DESERT5_25640
243@ = 1 
244@ = 1 
245@ = 1 
156@ = 0 

:DESERT5_25668
if 
  10 > 156@ 
else_jump @DESERT5_25862 
if 
   not " + parked_Rustler_Exists + @" == 1 
else_jump @DESERT5_25740 
if and
  70 > " + tmp_Flight_School_Records + @"(156@,10i) 
  243@ == 1 
else_jump @DESERT5_25740 
243@ = 0 

:DESERT5_25740
if 
   not " + parked_Stunt_Exists + @" == 1 
else_jump @DESERT5_25794 
if and
  85 > " + tmp_Flight_School_Records + @"(156@,10i) 
  244@ == 1 
else_jump @DESERT5_25794 
244@ = 0 

:DESERT5_25794
if 
   not " + parked_Hunter_Exists + @" == 1 
else_jump @DESERT5_25848 
if and
  100 > " + tmp_Flight_School_Records + @"(156@,10i) 
  245@ == 1 
else_jump @DESERT5_25848 
245@ = 0 

:DESERT5_25848
156@ += 1 
jump @DESERT5_25668 

:DESERT5_25862
if and
   not " + parked_Rustler_Exists + @" == 1 
  243@ == 1 
else_jump @DESERT5_25901" );
CAR_PARK.set_chance_to_generate( parked_Rustler, 101 );
AppendLine( @"" + parked_Rustler_Exists + @" = 1 

:DESERT5_25901
if and
   not " + parked_Stunt_Exists + @" == 1 
  244@ == 1 
else_jump @DESERT5_25940" );
CAR_PARK.set_chance_to_generate( parked_Stunt, 101 );
AppendLine( @"" + parked_Stunt_Exists + @" = 1 

:DESERT5_25940
if and
   not " + parked_Hunter_Exists + @" == 1 
  245@ == 1 
else_jump @DESERT5_25986" );
CAR_PARK.set_chance_to_generate( parked_Hunter, 101 );
AppendLine( @"" + parked_Hunter_Exists + @" = 1 

:DESERT5_25986
return 

:DESERT5_25988
if or
  34@ == 1 
  34@ == 3 
  34@ == 4 
  34@ == 7 
  34@ == 10 
  34@ == 11 
else_jump @DESERT5_26055 
" + _267 + @" = 100 
jump @DESERT5_26669 

:DESERT5_26055
if 
   not 34@ == 12 
else_jump @DESERT5_26487 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_26473 
" + _267 + @" = 100 
if 
  34@ == 2 
else_jump @DESERT5_26165 
if 
81AC:   not car 35@ sphere 0 in_cube_cornerA 288.0 45@ 16.0 cornerB 328.0 47@ 18.0 stopped 
else_jump @DESERT5_26165 
" + _267 + @" -= 50 

:DESERT5_26165
if or
  34@ == 5 
  34@ == 6 
else_jump @DESERT5_26241 
if 
81AC:   not car 35@ sphere 1 in_cube_cornerA 288.0 45@ 16.0 cornerB 328.0 47@ 18.0 stopped 
else_jump @DESERT5_26241 
" + _267 + @" -= 50 

:DESERT5_26241
if 
  34@ == 8 
else_jump @DESERT5_26308 
if 
81B0:   not car 35@ sphere 1 in_sphere 56@ 57@ 58@ radius 26.31 26.31 26.31 stopped 
else_jump @DESERT5_26308 
" + _267 + @" -= 50 

:DESERT5_26308
if 
  34@ == 9 
else_jump @DESERT5_26375 
if 
81B0:   not car 35@ sphere 1 in_sphere 56@ 57@ 58@ radius 26.31 26.31 26.31 stopped 
else_jump @DESERT5_26375 
" + _267 + @" -= 50 

:DESERT5_26375
40@ = Car.Angle(35@)
if or
   not 40@ >= 260.0 
   not 280.0 >= 40@ 
else_jump @DESERT5_26466 
if and
  40@ >= 181.0 
  359.0 >= 40@ 
else_jump @DESERT5_26459 
" + _267 + @" -= 10 
jump @DESERT5_26466 

:DESERT5_26459
" + _267 + @" -= 25 

:DESERT5_26466
jump @DESERT5_26480 

:DESERT5_26473
" + _267 + @" = 0 

:DESERT5_26480
jump @DESERT5_26669 

:DESERT5_26487
if 
  0.8 >= 142@ 
else_jump @DESERT5_26522 
" + _267 + @" = 100 
jump @DESERT5_26669 

:DESERT5_26522
if 
  2.1 >= 142@ 
else_jump @DESERT5_26557 
" + _267 + @" = 85 
jump @DESERT5_26669 

:DESERT5_26557
if 
  4.0 >= 142@ 
else_jump @DESERT5_26592 
" + _267 + @" = 75 
jump @DESERT5_26669 

:DESERT5_26592
if 
  6.0 >= 142@ 
else_jump @DESERT5_26627 
" + _267 + @" = 70 
jump @DESERT5_26669 

:DESERT5_26627
if 
  10.0 >= 142@ 
else_jump @DESERT5_26662 
" + _267 + @" = 35 
jump @DESERT5_26669 

:DESERT5_26662
" + _267 + @" = 0 

:DESERT5_26669
if 
  0 > " + _267 + @" 
else_jump @DESERT5_26694 
" + _267 + @" = 0 

:DESERT5_26694
if 
  " + _267 + @" > 100 
else_jump @DESERT5_26719 
" + _267 + @" = 100 

:DESERT5_26719
return 

:DESERT5_26721
if 
   not 34@ == 12 
else_jump @DESERT5_26873 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_26859 
36@ = Car.Health(35@)
" + _268 + @" = 1000 
0060: " + _268 + @" -= " + _260 + @" 
145@ = 1000 
0062: 145@ -= 36@ 
145@ /= 10 
if 
  0 > 145@ 
else_jump @DESERT5_26827 
145@ = 0 

:DESERT5_26827
if 
  145@ > 100 
else_jump @DESERT5_26852 
145@ = 100 

:DESERT5_26852
jump @DESERT5_26866 

:DESERT5_26859
145@ = 100 

:DESERT5_26866
jump @DESERT5_26880 

:DESERT5_26873
145@ = 0 

:DESERT5_26880
return 

:DESERT5_26882
0084: " + _301 + @" = " + _253 + @" 
" + _301 + @" /= 1000 
if 
002F:   147@ >= " + _301 + @" 
else_jump @DESERT5_26931 
146@ = 100 
jump @DESERT5_27042 

:DESERT5_26931
008B: 146@ = " + _301 + @" 
0062: 146@ -= 147@ 
146@ *= 30 
0085: 149@ = 148@ 
0062: 149@ -= 147@ 
0072: 146@ /= 149@ 
146@ *= -1 
146@ += 100 
if 
  0 > 146@ 
else_jump @DESERT5_27017 
146@ = 0 

:DESERT5_27017
if 
  146@ > 100 
else_jump @DESERT5_27042 
146@ = 100 

:DESERT5_27042
return 

:DESERT5_27044
008A: " + Current_Flight_Record + @" = 146@ 
if or
  34@ == 2 
  34@ == 5 
  34@ == 6 
  34@ == 8 
  34@ == 9 
  34@ == 12 
else_jump @DESERT5_27120 
0058: " + Current_Flight_Record + @" += " + _267 + @" 
" + Current_Flight_Record + @" /= 2 

:DESERT5_27120
if 
   not 34@ == 12 
else_jump @DESERT5_27146 
0066: " + Current_Flight_Record + @" -= 145@ 

:DESERT5_27146
if 
  0 > " + Current_Flight_Record + @" 
else_jump @DESERT5_27171 
" + Current_Flight_Record + @" = 0 

:DESERT5_27171
if 
  " + Current_Flight_Record + @" > 100 
else_jump @DESERT5_27196 
" + Current_Flight_Record + @" = 100 

:DESERT5_27196
00BE: text_clear_all 
return 

:DESERT5_27200
Player.CanMove(" + PlayerChar + @") = False
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1188 
fade 0 500 

:DESERT5_27234
if 
fading 
else_jump @DESERT5_27265 
wait 0 
gosub @DESERT5_29325 
jump @DESERT5_27234 

:DESERT5_27265
08DA: remove_panel 144@ 
03E6: remove_text_box 
00BE: text_clear_all 
03D6: remove_styled_text 'DES5_SA'  
03D6: remove_styled_text 'DES5_SB'  
033F: set_text_draw_letter_size 1.0 1.0 
0221: set_player " + PlayerChar + @" apply_brakes_to_car 0 
if 
  34@ == 12 
else_jump @DESERT5_27350 
Object.Destroy(135@)
0555: remove_weapon 46 from_actor " + PlayerActor + @" 
Model.Destroy(#GUN_PARA)

:DESERT5_27350
Camera.Restore_WithJumpCut
Actor.DestroyInstantly(70@)
0792: disembark_instantly_actor " + PlayerActor + @" 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 118@ 
06D6: disable_racing_checkpoint 143@ 
if 
  232@ == 2 
else_jump @DESERT5_27397 
00BE: text_clear_all 

:DESERT5_27397
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_27439 
if 
   Actor.InCar(" + PlayerActor + @", 35@)
else_jump @DESERT5_27439 
Car.LockInCurrentPosition(35@) = True

:DESERT5_27439
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
wait 0 
04E4: refresh_game_renderer_at 412.38 2533.65 
Camera.SetAtPos(412.38, 2533.65, 18.18)
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_27520 
Car.LockInCurrentPosition(35@) = False

:DESERT5_27520
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @DESERT5_27570 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 412.38 2533.65 18.18 
jump @DESERT5_27590 

:DESERT5_27570
Actor.PutAt(" + PlayerActor + @", 412.38, 2533.65, 18.18)

:DESERT5_27590
Actor.Angle(" + PlayerActor + @") = 90.0
Car.Destroy(35@)
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
return 

:DESERT5_27620
Player.CanMove(" + PlayerChar + @") = False
fade 0 200 

:DESERT5_27634
if 
fading 
else_jump @DESERT5_27658 
wait 0 
jump @DESERT5_27634 

:DESERT5_27658
03E6: remove_text_box 
00BE: text_clear_all 
014F: stop_timer " + _253 + @" 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 118@ 
if or
  34@ == 3 
  34@ == 4 
  34@ == 5 
  34@ == 6 
else_jump @DESERT5_27764 
156@ = 0 

:DESERT5_27723
if 
  8 > 156@ 
else_jump @DESERT5_27764 
06D6: disable_racing_checkpoint 119@(156@,8i) 
156@ += 1 
jump @DESERT5_27723 

:DESERT5_27764
if 
  34@ == 9 
else_jump @DESERT5_27880 
156@ = 0 

:DESERT5_27789
if 
001D:   63@ > 156@ 
else_jump @DESERT5_27831 
Marker.Disable(221@(156@,3i))
156@ += 1 
jump @DESERT5_27789 

:DESERT5_27831
156@ = 0 

:DESERT5_27838
if 
001D:   66@ > 156@ 
else_jump @DESERT5_27880 
Marker.Disable(224@(156@,2i))
156@ += 1 
jump @DESERT5_27838 

:DESERT5_27880
if or
  34@ == 10 
  34@ == 11 
else_jump @DESERT5_27915 
06D6: disable_racing_checkpoint 127@ 
06D6: disable_racing_checkpoint 128@ 

:DESERT5_27915
if 
  34@ == 12 
else_jump @DESERT5_27960 
Object.Destroy(135@)
06D6: disable_racing_checkpoint 143@ 
0555: remove_weapon 46 from_actor " + PlayerActor + @" 
Model.Destroy(#GUN_PARA)
0792: disembark_instantly_actor " + PlayerActor + @" 

:DESERT5_27960
Camera.Restore_WithJumpCut
Actor.DestroyInstantly(70@)
if 
  232@ == 2 
else_jump @DESERT5_27987 
00BE: text_clear_all 

:DESERT5_27987
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_28029 
if 
   Actor.InCar(" + PlayerActor + @", 35@)
else_jump @DESERT5_28029 
Car.LockInCurrentPosition(35@) = True

:DESERT5_28029
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
wait 0 
04E4: refresh_game_renderer_at 412.38 2533.65 
Camera.SetAtPos(300.0, 2501.94, 19.65)
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_28110 
Car.LockInCurrentPosition(35@) = False

:DESERT5_28110
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @DESERT5_28160 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 412.38 2533.65 18.18 
jump @DESERT5_28180 

:DESERT5_28160
Actor.PutAt(" + PlayerActor + @", 412.38, 2533.65, 18.18)

:DESERT5_28180
Actor.Angle(" + PlayerActor + @") = 90.0
Car.Destroy(35@)
0826: enable_hud 0 
0581: enable_radar 0 
Camera.SetPosition(370.0, 2501.94, 19.65, 0.0, 0.0, 0.0)
Camera.PointAt(320.0, 2501.94, 19.65, 2)
08D4: 144@ = create_panel_with_title 'DUMMY' position 184.0 200.0 width 128.0 columns 2 interactive 0 background 1 alignment 0 
08DB: set_panel 144@ column 1 header 'DUMMY' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 
08D6: set_panel 144@ column 0 alignment 1 
08D6: set_panel 144@ column 1 alignment 0 
09DB: set_panel 144@ column 0 width 192 
09DB: set_panel 144@ column 1 width 64 
270@ = 0 
if and
  238@ > 0 
  229@ > 0 
else_jump @DESERT5_28509 
05AA: 246@(270@,12s) = 'DUMMY' 
270@ += 1 

:DESERT5_28509
05AA: 246@(270@,12s) = 'DES5_S3' 
08EE: set_panel 144@ column 1 row 270@ text_1number GXT 'DES5_SC' number " + _301 + @"  
270@ += 1 
if or
  34@ == 2 
  34@ == 5 
  34@ == 6 
  34@ == 8 
  34@ == 9 
  34@ == 12 
else_jump @DESERT5_28656 
05AA: 246@(270@,12s) = 'DES5_S5' 
08EE: set_panel 144@ column 1 row 270@ text_1number GXT 'DES5_SD' number " + _267 + @"  
270@ += 1 

:DESERT5_28656
if 
   not 34@ == 12 
else_jump @DESERT5_28721 
05AA: 246@(270@,12s) = 'DES5_S6' 
08EE: set_panel 144@ column 1 row 270@ text_1number GXT 'DES5_SD' number 145@  
270@ += 1 

:DESERT5_28721
05AA: 246@(270@,12s) = 'DES5_S7' 
08EE: set_panel 144@ column 1 row 270@ text_1number GXT 'DES5_SD' number " + Current_Flight_Record + @"  
270@ += 1 
if 
  238@ == 2 
else_jump @DESERT5_29045 
05AA: 246@(270@,12s) = 'DUMMY' 
270@ += 1 
05AA: 246@(270@,12s) = 'DES5_SF' 
270@ += 1 
if 
   not " + Pilot_License_Obtained + @" == 1 
else_jump @DESERT5_29045 
0652: 271@ = integer_stat 223 
if 
  271@ >= 180 
else_jump @DESERT5_29045 
" + Pilot_License_Obtained + @" = 1 
156@ = 0 

:DESERT5_28895
if 
  24 >= 156@ 
else_jump @DESERT5_28963 
if and
   not 156@ == 8 
   not 156@ == 9 
else_jump @DESERT5_28949 

:DESERT5_28949
156@ += 1 
jump @DESERT5_28895 

:DESERT5_28963
156@ = 0 

:DESERT5_28977
if 
  11 >= 156@ 
else_jump @DESERT5_29020 
156@ += 1 
jump @DESERT5_28977 

:DESERT5_29020
05AA: 246@(270@,12s) = 'DES5_SG' 
270@ += 1 

:DESERT5_29045
05AA: 246@(270@,12s) = 'DUMMY' 
270@ += 1 
if 
  238@ == 2 
else_jump @DESERT5_29113 
05AA: 246@(270@,12s) = 'DES5_S8' 
jump @DESERT5_29131 

:DESERT5_29113
05AA: 246@(270@,12s) = 'DES5_SE' 

:DESERT5_29131
270@ += 1 
05AA: 246@(270@,12s) = 'DES5_S9' 
270@ += 1 

:DESERT5_29163
if 
  12 > 270@ 
else_jump @DESERT5_29213 
05AA: 246@(270@,12s) = 'DUMMY' 
270@ += 1 
jump @DESERT5_29163 

:DESERT5_29213
08DB: set_panel 144@ column 0 header 'DUMMY' data 246@s 248@s 250@s 252@s 254@s 256@s 258@s 260@s 262@s 264@s 266@s 268@s 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1187 
fade 1 500 

:DESERT5_29292
if 
fading 
else_jump @DESERT5_29323 
wait 0 
gosub @DESERT5_29325 
jump @DESERT5_29292 

:DESERT5_29323
return 

:DESERT5_29325
if or
  238@ == 1 
  238@ == 2 
else_jump @DESERT5_29714 
gosub @DESERT5_24849 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 320.0 120.0 GXT 'DES5_SB'  
if 
  229@ > 0 
else_jump @DESERT5_29714 
gosub @DESERT5_24849 
0904: get_interface 6 color_RGBA_to 152@ 153@ 154@ 155@ 
0340: set_text_draw_RGBA 152@ 153@ 154@ 155@ 
033E: set_draw_text_position 320.0 85.0 GXT 'DES5_SA'  
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 261.7 200.0 size -50.0 50.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 378.3 200.0 size 50.0 50.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
if 
  229@ == 2 
else_jump @DESERT5_29606 
038D: draw_texture 1 position 320.0 200.0 size 91.7 79.2 RGBA 160 160 160 255 

:DESERT5_29606
if 
  229@ == 3 
else_jump @DESERT5_29660 
038D: draw_texture 2 position 320.0 200.0 size 91.7 79.2 RGBA 160 160 160 255 

:DESERT5_29660
if 
  229@ == 4 
else_jump @DESERT5_29714 
038D: draw_texture 3 position 320.0 200.0 size 91.7 79.2 RGBA 160 160 160 255 

:DESERT5_29714
return 

:DESERT5_29716
if or
  215@ == 0 
  215@ == 1 
else_jump @DESERT5_29786 
if 
001D:   217@ > 216@ 
else_jump @DESERT5_29786 
if 
  33@ > 200 
else_jump @DESERT5_29786 
gosub @DESERT5_29851 

:DESERT5_29786
if 
  215@ == 2 
else_jump @DESERT5_29849 
if 
03D2:   wav 1 ended 
else_jump @DESERT5_29849 
215@ = 0 
216@ += 1 
218@ = 0 
00BE: text_clear_all 
33@ = 0 

:DESERT5_29849
return 

:DESERT5_29851
if 
  215@ == 0 
else_jump @DESERT5_29887 
03CF: load_wav 203@(216@,12i) as 1 
215@ = 1 

:DESERT5_29887
if 
  215@ == 1 
else_jump @DESERT5_29945 
if 
03D0:   wav 1 loaded 
else_jump @DESERT5_29945 
00BC: show_text_highpriority GXT 179@(216@,12s) time 10000 flag 1 
03D1: play_wav 1 
215@ = 2 

:DESERT5_29945
return 

:DESERT5_29947
00BE: text_clear_all 
if or
  232@ == 1 
   not Player.Defined(" + PlayerChar + @")
else_jump @DESERT5_29988 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  

:DESERT5_29988
return 

:DESERT5_29990
if 
   not " + Mission_Learning_to_Fly_Passed + @" == 1 
else_jump @DESERT5_30015 
" + Mission_Learning_to_Fly_Passed + @" = 1 

:DESERT5_30015
if 
  " + Mission_Learning_to_Fly_Passed + @" == 1 
else_jump @DESERT5_30092 
0318: set_latest_mission_passed 'DESERT5'  
00BA: show_text_styled GXT 'M_PASSD' time 5000 style 1  
0629: change_integer_stat 331 to 1 
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 1 

:DESERT5_30092
return 

:DESERT5_30094
Model.Destroy(#RUSTLER)
Model.Destroy(#HUNTER)
Model.Destroy(#PETRO)
Model.Destroy(#LANDSTAL)
Model.Destroy(#STUNT)
Model.Destroy(#GUN_PARA)
Model.Destroy(#CELLPHONE)" );
remove_references_external_script<PARACH>();
AppendLine( @"0391: release_textures 
Marker.Disable(220@)
06D6: disable_racing_checkpoint 118@ 
156@ = 0 

:DESERT5_30152
if 
  8 > 156@ 
else_jump @DESERT5_30193 
06D6: disable_racing_checkpoint 119@(156@,8i) 
156@ += 1 
jump @DESERT5_30152 

:DESERT5_30193
06D6: disable_racing_checkpoint 127@ 
06D6: disable_racing_checkpoint 128@ 
06D6: disable_racing_checkpoint 143@ 
156@ = 0 

:DESERT5_30215
if 
001D:   63@ > 156@ 
else_jump @DESERT5_30257 
Marker.Disable(221@(156@,3i))
156@ += 1 
jump @DESERT5_30215 

:DESERT5_30257
156@ = 0 

:DESERT5_30264
if 
001D:   66@ > 156@ 
else_jump @DESERT5_30306 
Marker.Disable(224@(156@,2i))
156@ += 1 
jump @DESERT5_30264 

:DESERT5_30306
03E6: remove_text_box 
03D6: remove_styled_text 'DES5_SA'  
03D6: remove_styled_text 'DES5_SB'  
061B: remove_references_to_AS_pack 71@ 
061B: remove_references_to_AS_pack 72@ 
08A8: set_markers_to_long_distance 0 
01EB: set_traffic_density_multiplier_to 1.0 
03DE: set_pedestrians_density_multiplier_to 1.0 
03F0: enable_text_draw 0 
08DA: remove_panel 144@ 
Object.Destroy(135@)
" + _1510 + @" = 1 
if 
   not Car.Wrecked(35@)
else_jump @DESERT5_30400 
05EC: release_car 35@ from_path 

:DESERT5_30400
Car.Destroy(35@)
156@ = 0 

:DESERT5_30412
if 
001D:   63@ > 156@ 
else_jump @DESERT5_30454 
Car.Destroy(60@(156@,3i))
156@ += 1 
jump @DESERT5_30412 

:DESERT5_30454
0873: release_path 590 
0873: release_path 591 
0873: release_path 592 
0873: release_path 593 
0873: release_path 594 
0873: release_path 595 
0873: release_path 596 
0873: release_path 597 
0873: release_path 598 
040D: unload_wav 3 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1188 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
01B7: release_weather 
0581: enable_radar 1 
08F8: display_stat_update_box 1 
07A8: enable_area69_sam 1 
096A: enable_flying_helis 1 
01F0: set_max_wanted_level_to 239@ 
if 
0844:   string " + Current_Shop_GXT_Name + @" empty 
else_jump @DESERT5_30573 
Camera.Restore_WithJumpCut

:DESERT5_30573
Actor.DestroyInstantly(70@)
Camera.SetBehindPlayer
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}