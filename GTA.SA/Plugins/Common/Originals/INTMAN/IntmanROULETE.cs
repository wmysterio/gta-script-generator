using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class ROULETE : External {

            Int tmp_ROULETE_Chips = global( ROULETE_Chips.startIndex ),
                tmp_3820 = global( _3820.startIndex ),
                tmp_3879 = global( _3879.startIndex ),
                tmp_3867 = global( _3867.startIndex ),
                tmp_3926 = global( _3926.startIndex ),
                tmp_3507 = global( _3507.startIndex ),
                tmp_3658 = global( _3658.startIndex ),
                tmp_8398 = global( _8398.startIndex ),
                tmp_3817 = global( _3817.startIndex ),
                tmp_3876 = global( _3876.startIndex ),
                tmp_3828 = global( _3828.startIndex ),
                tmp_3887 = global( _3887.startIndex ),
                tmp_3811 = global( _3811.startIndex ),
                tmp_3870 = global( _3870.startIndex ),
                tmp_3826 = global( _3826.startIndex ),
                tmp_3885 = global( _3885.startIndex ),
                tmp_3830 = global( _3830.startIndex ),
                tmp_3889 = global( _3889.startIndex ),
                tmp_3814 = global( _3814.startIndex ),
                tmp_3873 = global( _3873.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == 1 
jf @ROULETE_90 
0@ = Object.Init(#ROULETTE_TBL, 0.0, 0.0, 0.0)
" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i) = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0662: printstring ""AAAAAAA"" 

:ROULETE_90
4@ = 0 
5@ = 0 
8@ = 0 
9@ = 0 
7@ = 0 
10@ = 500 
11@ = 500 
12@ = 0 
13@ = 0 
14@ = 0 
15@ = 0 
0653: 16@ = float_stat 81 
0209: 18@ = random_int_in_ranges 0 19 
" + _1523 + @" += 1 
if 
  1.0 > 16@ 
jf @ROULETE_252 
if or
  " + _1523 + @" == 1 
  " + _1523 + @" == 5 
jf @ROULETE_245 
18@ = 0 

:ROULETE_245
jump @ROULETE_464 

:ROULETE_252
if 
  10.0 > 16@ 
jf @ROULETE_312 
if or
  " + _1523 + @" == 1 
  " + _1523 + @" == 5 
jf @ROULETE_305 
18@ = 5 

:ROULETE_305
jump @ROULETE_464 

:ROULETE_312
if 
  100.0 > 16@ 
jf @ROULETE_372 
if or
  " + _1523 + @" == 1 
  " + _1523 + @" == 5 
jf @ROULETE_365 
18@ = 10 

:ROULETE_365
jump @ROULETE_464 

:ROULETE_372
if 
  1000.0 > 16@ 
jf @ROULETE_432 
if or
  " + _1523 + @" == 1 
  " + _1523 + @" == 5 
jf @ROULETE_425 
18@ = 14 

:ROULETE_425
jump @ROULETE_464 

:ROULETE_432
if or
  " + _1523 + @" == 1 
  " + _1523 + @" == 5 
jf @ROULETE_464 
18@ = 17 

:ROULETE_464
if or
  18@ == 0 
  18@ == 1 
  18@ == 2 
  18@ == 3 
  18@ == 4 
jf @ROULETE_525 
17@ = 2 
19@ = -340 

:ROULETE_525
if or
  18@ == 5 
  18@ == 6 
  18@ == 7 
  18@ == 8 
  18@ == 9 
jf @ROULETE_586 
17@ = 20 
19@ = -341 

:ROULETE_586
if or
  18@ == 10 
  18@ == 11 
  18@ == 12 
  18@ == 13 
jf @ROULETE_641 
17@ = 200 
19@ = -342 

:ROULETE_641
if or
  18@ == 14 
  18@ == 15 
  18@ == 16 
jf @ROULETE_689 
17@ = 2000 
19@ = -343 

:ROULETE_689
if or
  18@ == 17 
  18@ == 18 
jf @ROULETE_730 
17@ = 20000 
19@ = -344 

:ROULETE_730
18@ = 0 
20@ = 0 
0085: 21@ = 17@ 
21@ *= 50 
22@ = 0 
0209: " + _3396 + @" = random_int_in_ranges 0 2 
if 
  " + _3396 + @" == 0 
jf @ROULETE_807 
04AF: 23@ = 11 
jump @ROULETE_815 

:ROULETE_807
04AF: 23@ = 172 

:ROULETE_815
" + _8549 + @" = 0 

:ROULETE_822
if 
  151 > " + _8549 + @" 
jf @ROULETE_866 
" + tmp_8398 + @"(" + _8549 + @",151i) = 0 
" + _8549 + @" += 1 
jump @ROULETE_822 

:ROULETE_866
" + ROULETE_Cash_Won + @" = 0 
" + _8551 + @" = 0 
if 
  22@ == 1 
jf @ROULETE_907 
22@ = 0 
return 

:ROULETE_907
24@ = 0.0 
25@ = 0.0 

:ROULETE_927
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
03CA:   object 0@ exists 
jf @ROULETE_7879 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @ROULETE_7735 
if 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @ROULETE_7591 
if 
   Player.Defined(" + PlayerChar + @")
jf @ROULETE_7456 
if 
  1@ == 0 
jf @ROULETE_1032 
Model.Load(23@)
1@ += 1 

:ROULETE_1032
if 
  1@ == 1 
jf @ROULETE_1167 
Model.Load(23@)
if 
   Model.Available(23@)
jf @ROULETE_1167 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 1.208 0.571 -1.144 
26@ = Actor.Create(CivFemale, 23@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(0@)
" + tempvar_Angle + @" += 90.0 
Actor.Angle(26@) = " + tempvar_Angle + @"
060B: set_actor 26@ decision_maker_to " + Interior_Decision_Maker_A + @" 
0A0A: unknown_object 0@ flag 1 
1@ += 1 

:ROULETE_1167
if 
  1@ == 2 
jf @ROULETE_1269 
if 
0472:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 5.0 5.0 sphere 0 on_foot 
jf @ROULETE_1269 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.215 1.34 -0.086 
27@ = Object.Init(#WHEEL_WEE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
1@ += 1 

:ROULETE_1269
if 
  1@ == 3 
jf @ROULETE_1592 
if 
0472:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 5.0 5.0 sphere 0 on_foot 
jf @ROULETE_1592 
if 
  " + _9470 + @" == 0 
jf @ROULETE_1592 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -1.839 -2.4444 -0.6 
0400: store_coords_to " + _3404 + @" " + _3405 + @" " + _3406 + @" from_object 0@ with_offset 0.761 0.9556 0.6 
if 
01A6:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" cornerB " + _3404 + @" " + _3405 + @" " + _3406 + @" on_foot 
jf @ROULETE_1592 
if 
  17@ == 2 
jf @ROULETE_1459 
0512: show_permanent_text_box 'SLOT_06'  

:ROULETE_1459
if 
  17@ == 20 
jf @ROULETE_1488 
0512: show_permanent_text_box 'SLOT_07'  

:ROULETE_1488
if 
  17@ == 200 
jf @ROULETE_1518 
0512: show_permanent_text_box 'SLOT_08'  

:ROULETE_1518
if 
  17@ == 2000 
jf @ROULETE_1548 
0512: show_permanent_text_box 'SLOT_09'  

:ROULETE_1548
if 
  17@ == 20000 
jf @ROULETE_1578 
0512: show_permanent_text_box 'SLOT_10'  

:ROULETE_1578
03CF: load_wav 1813 as 4 
1@ += 1 

:ROULETE_1592
if 
  1@ == 4 
jf @ROULETE_2950 
if 
  " + _3489 + @" == 0 
jf @ROULETE_2950 
if 
0472:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 5.0 5.0 sphere 0 on_foot 
jf @ROULETE_2950 
if 
  " + _9470 + @" == 0 
jf @ROULETE_2941 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -1.839 -2.4444 -0.6 
0400: store_coords_to " + _3404 + @" " + _3405 + @" " + _3406 + @" from_object 0@ with_offset 0.761 0.9556 0.6 
if 
01A6:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" cornerB " + _3404 + @" " + _3405 + @" " + _3406 + @" on_foot 
jf @ROULETE_2925 
if 
   Player.Controllable(" + PlayerChar + @")
jf @ROULETE_2918 
if 
00E1:   player 0 pressed_key 15 
jf @ROULETE_2911 
if 
  9@ == 0 
jf @ROULETE_2904 
0652: " + STAT_Gambling_Skill + @" = integer_stat 81 
if 
  17@ == 20 
jf @ROULETE_1974 
if 
   not " + STAT_Gambling_Skill + @" >= 1 
jf @ROULETE_1974 
00BC: show_text_highpriority GXT 'GAMBSTA' time 4000 flag 1  
if 
   not Actor.Dead(26@)
jf @ROULETE_1967 
0209: " + _3400 + @" = random_int_in_ranges 0 2 
if 
04A4:   23@ == 11 
jf @ROULETE_1949 
09D6: unknown_set_actor 26@ sound " + tmp_3817 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_1967 

:ROULETE_1949
09D6: unknown_set_actor 26@ sound " + tmp_3876 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_1967
jump @ROULETE_927 

:ROULETE_1974
if 
  17@ == 200 
jf @ROULETE_2120 
if 
   not " + STAT_Gambling_Skill + @" >= 10 
jf @ROULETE_2120 
00BC: show_text_highpriority GXT 'GAMBSTA' time 4000 flag 1  
if 
   not Actor.Dead(26@)
jf @ROULETE_2113 
0209: " + _3400 + @" = random_int_in_ranges 0 2 
if 
04A4:   23@ == 11 
jf @ROULETE_2095 
09D6: unknown_set_actor 26@ sound " + tmp_3817 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_2113 

:ROULETE_2095
09D6: unknown_set_actor 26@ sound " + tmp_3876 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_2113
jump @ROULETE_927 

:ROULETE_2120
if 
  17@ == 2000 
jf @ROULETE_2266 
if 
   not " + STAT_Gambling_Skill + @" >= 100 
jf @ROULETE_2266 
00BC: show_text_highpriority GXT 'GAMBSTA' time 4000 flag 1  
if 
   not Actor.Dead(26@)
jf @ROULETE_2259 
0209: " + _3400 + @" = random_int_in_ranges 0 2 
if 
04A4:   23@ == 11 
jf @ROULETE_2241 
09D6: unknown_set_actor 26@ sound " + tmp_3817 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_2259 

:ROULETE_2241
09D6: unknown_set_actor 26@ sound " + tmp_3876 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_2259
jump @ROULETE_927 

:ROULETE_2266
if 
  17@ == 20000 
jf @ROULETE_2413 
if 
   not " + STAT_Gambling_Skill + @" > 999 
jf @ROULETE_2413 
00BC: show_text_highpriority GXT 'GAMBSTA' time 4000 flag 1  
if 
   not Actor.Dead(26@)
jf @ROULETE_2406 
0209: " + _3400 + @" = random_int_in_ranges 0 2 
if 
04A4:   23@ == 11 
jf @ROULETE_2388 
09D6: unknown_set_actor 26@ sound " + tmp_3817 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_2406 

:ROULETE_2388
09D6: unknown_set_actor 26@ sound " + tmp_3876 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_2406
jump @ROULETE_927 

:ROULETE_2413
03E6: remove_text_box 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
Object.StorePos(0@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
06BA: AS_actor " + PlayerActor + @" turn_to_and_look_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
0A2B:   widescreen_option_enabled 
jf @ROULETE_2578 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.632 -1.9669 1.9144 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.5003 -1.3914 1.1073 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 1)
jump @ROULETE_2675 

:ROULETE_2578
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.5689 -1.5476 1.8759 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.4106 -1.0626 1.0159 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 1)

:ROULETE_2675
041D: set_camera_near_clip 0.1 
03F0: enable_text_draw 1 
0390: load_txd_dictionary 'LD_ROUL' 
if 
   not Actor.Dead(26@)
jf @ROULETE_2783 
0209: " + _3400 + @" = random_int_in_ranges 0 2 
if 
04A4:   23@ == 11 
jf @ROULETE_2765 
09D6: unknown_set_actor 26@ sound " + tmp_3828 + @"(" + _3400 + @",2i) flags 1 1 0 
jump @ROULETE_2783 

:ROULETE_2765
09D6: unknown_set_actor 26@ sound " + tmp_3887 + @"(" + _3400 + @",2i) flags 1 1 0 

:ROULETE_2783
038F: load_texture ""ROULBLA"" as 1 
038F: load_texture ""ROULRED"" as 2 
038F: load_texture ""ROULGRE"" as 3 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + _3496 + @" " + _3497 + @" " + _3498 + @" 
" + tempvar_Float_3 + @" += 0.01 
" + _8552 + @" = Object.Init(#ROULETTE_MARKER, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
09BD: allow_other_threads_to_display_text_boxes 1 
" + _3489 + @" = 1 
28@ = 0 
1@ += 1 
9@ = 1 

:ROULETE_2904
jump @ROULETE_2918 

:ROULETE_2911
9@ = 0 

:ROULETE_2918
jump @ROULETE_2934 

:ROULETE_2925
03E6: remove_text_box 
1@ = 3 

:ROULETE_2934
jump @ROULETE_2950 

:ROULETE_2941
03E6: remove_text_box 
1@ = 3 

:ROULETE_2950
if 
  1@ == 5 
jf @ROULETE_7449 
0581: enable_radar 0 
if 
  " + _3505 + @" > 0 
jf @ROULETE_3503 
" + _3809 + @" += 2.0 
" + _3810 + @" += 2.0 
038D: draw_texture 1 position " + _3809 + @" " + _3810 + @" size 64.0 64.0 RGBA 0 0 0 255 
" + _3809 + @" -= 2.0 
" + _3810 + @" -= 2.0 
if 
  18@ == 0 
jf @ROULETE_3116 
038D: draw_texture 3 position " + _3809 + @" " + _3810 + @" size 64.0 64.0 RGBA 180 180 180 255 
jump @ROULETE_3424 

:ROULETE_3116
if or
  18@ == 1 
  18@ == 3 
  18@ == 5 
  18@ == 7 
  18@ == 9 
  18@ == 12 
jf @ROULETE_3208 
038D: draw_texture 2 position " + _3809 + @" " + _3810 + @" size 64.0 64.0 RGBA 180 180 180 255 
jump @ROULETE_3424 

:ROULETE_3208
if or
  18@ == 14 
  18@ == 16 
  18@ == 18 
  18@ == 19 
  18@ == 21 
  18@ == 23 
jf @ROULETE_3300 
038D: draw_texture 2 position " + _3809 + @" " + _3810 + @" size 64.0 64.0 RGBA 180 180 180 255 
jump @ROULETE_3424 

:ROULETE_3300
if or
  18@ == 25 
  18@ == 27 
  18@ == 30 
  18@ == 32 
  18@ == 34 
  18@ == 36 
jf @ROULETE_3392 
038D: draw_texture 2 position " + _3809 + @" " + _3810 + @" size 64.0 64.0 RGBA 180 180 180 255 
jump @ROULETE_3424 

:ROULETE_3392
038D: draw_texture 1 position " + _3809 + @" " + _3810 + @" size 64.0 64.0 RGBA 180 180 180 255 

:ROULETE_3424
0086: " + _8553 + @" = " + _3809 + @" 
" + _8553 + @" += -1.6679 
0086: " + _8554 + @" = " + _3810 + @" 
" + _8554 + @" += -30.0255 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size 0.9423 4.2306 
0342: set_text_draw_centered 1 
045A: draw_text_1number " + _8553 + @" " + _8554 + @" GXT 'NUMBER' number 18@  

:ROULETE_3503
0937: text_draw_box_cornerA " + _3479 + @" " + _3483 + @" cornerB " + _3480 + @" " + _3484 + @" GXT_reference 'ROUWAGE' style 2  
gosub @ROULETE_18193 
0340: set_text_draw_RGBA 134 155 184 255 
if 
04A3:   " + Current_Language + @" == 3 
jf @ROULETE_3579 
033F: set_text_draw_letter_size 0.42 2.5077 

:ROULETE_3579
033E: set_draw_text_position " + _3477 + @" " + _3481 + @" GXT 'ROU_MAX'  
0086: " + _8554 + @" = " + _3481 + @" 
0059: " + _8554 + @" += " + _3482 + @" 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size " + _3486 + @" " + _3488 + @" 
045A: draw_text_1number " + _3477 + @" " + _8554 + @" GXT 'DOLLAR' number 21@  
0059: " + _8554 + @" += " + _3478 + @" 
gosub @ROULETE_18193 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + _3477 + @" " + _8554 + @" GXT 'ROUYOUR'  
0059: " + _8554 + @" += " + _3482 + @" 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size " + _3486 + @" " + _3488 + @" 
045A: draw_text_1number " + _3477 + @" " + _8554 + @" GXT 'DOLLAR' number " + _8551 + @"  
0059: " + _8554 + @" += " + _3478 + @" 
gosub @ROULETE_18193 
if 
  " + _3505 + @" > 0 
jf @ROULETE_3850 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + _3477 + @" " + _8554 + @" GXT 'ROU_WON'  
0059: " + _8554 + @" += " + _3482 + @" 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size " + _3486 + @" " + _3488 + @" 
045A: draw_text_1number " + _3477 + @" " + _8554 + @" GXT 'DOLLAR' number " + ROULETE_Cash_Won + @"  
jump @ROULETE_3924 

:ROULETE_3850
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + _3477 + @" " + _8554 + @" GXT 'ROUTHIS'  
0059: " + _8554 + @" += " + _3482 + @" 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size " + _3486 + @" " + _3488 + @" 
045A: draw_text_1number " + _3477 + @" " + _8554 + @" GXT 'DOLLAR' number 20@  

:ROULETE_3924
if 
  " + _3505 + @" == 0 
jf @ROULETE_4536 
0512: show_permanent_text_box 'ROUHELP'  
0750: set_object " + _8552 + @" visibility 1 
if 
00E1:   player 0 pressed_key 16 
jf @ROULETE_4238 
if 
  7@ == 0 
jf @ROULETE_4231 
if 
  " + _8551 + @" > 0 
jf @ROULETE_4189 
03CF: load_wav 1813 as 4 
if 
   not Actor.Dead(26@)
jf @ROULETE_4106 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if 
04A4:   23@ == 11 
jf @ROULETE_4088 
09D6: unknown_set_actor 26@ sound " + tmp_3811 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_4106 

:ROULETE_4088
09D6: unknown_set_actor 26@ sound " + tmp_3870 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_4106
if 
03D0:   wav 4 loaded 
jf @ROULETE_4141 
097A: play_audio_at 0.0 0.0 0.0 event 1086 

:ROULETE_4141
0623: add " + _8551 + @" to_integer_stat 35 
008D: " + _3401 + @" = integer " + _8551 + @" to_float 
" + _3401 + @" *= 0.001 
03E6: remove_text_box 
0624: add " + _3401 + @" to_float_stat 81 
" + _3505 + @" += 1 
jump @ROULETE_4224 

:ROULETE_4189
if 
03D0:   wav 4 loaded 
jf @ROULETE_4224 
097A: play_audio_at 0.0 0.0 0.0 event 1085 

:ROULETE_4224
7@ += 1 

:ROULETE_4231
jump @ROULETE_4245 

:ROULETE_4238
7@ = 0 

:ROULETE_4245
if 
00E1:   player 0 pressed_key 15 
jf @ROULETE_4522 
if 
  9@ == 0 
jf @ROULETE_4515 
9@ += 1 
" + _3505 + @" = 0 
1@ = 3 
if 
   not Actor.Dead(26@)
jf @ROULETE_4387 
0209: " + _3400 + @" = random_int_in_ranges 0 2 
if 
04A4:   23@ == 11 
jf @ROULETE_4369 
09D6: unknown_set_actor 26@ sound " + tmp_3826 + @"(" + _3400 + @",2i) flags 1 1 0 
jump @ROULETE_4387 

:ROULETE_4369
09D6: unknown_set_actor 26@ sound " + tmp_3885 + @"(" + _3400 + @",2i) flags 1 1 0 

:ROULETE_4387
0581: enable_radar 1 
Player.CanMove(" + PlayerChar + @") = True
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
03F4: set_all_cars_apply_damage_rules 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
03F0: enable_text_draw 0 
0391: release_textures 
03E6: remove_text_box 
Object.Destroy(" + _8552 + @")
Player.Money(" + PlayerChar + @") += " + _8551 + @"
22@ = 1 
gosub @ROULETE_815 
" + _8549 + @" = 0 

:ROULETE_4455
if 
  151 > " + _8549 + @" 
jf @ROULETE_4497 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + _8549 + @" += 1 
jump @ROULETE_4455 

:ROULETE_4497
09BD: allow_other_threads_to_display_text_boxes 0 
" + _3489 + @" = 0 
jump @ROULETE_927 

:ROULETE_4515
jump @ROULETE_4529 

:ROULETE_4522
9@ = 0 

:ROULETE_4529
gosub @ROULETE_8023 

:ROULETE_4536
if 
  " + _3505 + @" == 1 
jf @ROULETE_4625 
0750: set_object " + _8552 + @" visibility 0 
0079: 24@ += frame_delta_time * 0.5 
if or
  24@ > 20.0 
  24@ == 20.0 
jf @ROULETE_4625 
0084: " + _3506 + @" = " + Current_Time_in_ms2 + @" 
" + _3506 + @" += 1500 
" + _3505 + @" += 1 

:ROULETE_4625
if 
  " + _3505 + @" == 2 
jf @ROULETE_4803 
if 
001C:   " + Current_Time_in_ms2 + @" > " + _3506 + @" 
jf @ROULETE_4803 
007F: 24@ -= frame_delta_time * 0.08 
if or
  0.0 > 24@ 
  24@ == 0.0 
jf @ROULETE_4803 
0209: 18@ = random_int_in_ranges 0 37 
if 
   not Actor.Dead(26@)
jf @ROULETE_4789 
if 
04A4:   23@ == 11 
jf @ROULETE_4771 
09D6: unknown_set_actor 26@ sound " + tmp_3830 + @"(18@,37i) flags 1 1 0 
jump @ROULETE_4789 

:ROULETE_4771
09D6: unknown_set_actor 26@ sound " + tmp_3889 + @"(18@,37i) flags 1 1 0 

:ROULETE_4789
gosub @ROULETE_9703 
" + _3505 + @" += 1 

:ROULETE_4803
if 
  " + _3505 + @" == 3 
jf @ROULETE_5553 
0512: show_permanent_text_box 'X_CONT'  
0084: " + _3396 + @" = " + ROULETE_Cash_Won + @" 
0060: " + _3396 + @" -= " + _8551 + @" 
if 
  " + _3396 + @" == 0 
jf @ROULETE_4934 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size 1.3 3.36 
0342: set_text_draw_centered 1 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 3 
033E: set_draw_text_position 320.0 180.333 GXT 'NOWIN'  
jump @ROULETE_5138 

:ROULETE_4934
if 
  " + _3396 + @" > 0 
jf @ROULETE_5060 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size 1.3 3.36 
0342: set_text_draw_centered 1 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 3 
0904: get_interface 6 color_RGBA_to " + Color_Red + @" " + Color_Green + @" " + Gambles_CashWin + @" " + _3400 + @" 
0340: set_text_draw_RGBA " + Color_Red + @" " + Color_Green + @" " + Gambles_CashWin + @" 255 
045A: draw_text_1number 320.0 155.333 GXT 'WINNER' number " + _3396 + @"  
0627: update_integer_stat 38 to " + _3396 + @" 
jump @ROULETE_5138 

:ROULETE_5060
" + _3396 + @" *= -1 
gosub @ROULETE_18193 
033F: set_text_draw_letter_size 1.3 3.36 
0342: set_text_draw_centered 1 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 3 
045A: draw_text_1number 320.0 155.333 GXT 'LOSER' number " + _3396 + @"  
0627: update_integer_stat 39 to " + _3396 + @" 

:ROULETE_5138
if 
00E1:   player 0 pressed_key 16 
jf @ROULETE_5546 
if 
  7@ == 0 
jf @ROULETE_5539 
008B: 7@ = " + Current_Time_in_ms2 + @" 
7@ += 999999 
Player.Money(" + PlayerChar + @") += " + ROULETE_Cash_Won + @"
0623: add " + ROULETE_Cash_Won + @" to_integer_stat 37 
0084: " + _3396 + @" = " + ROULETE_Cash_Won + @" 
0060: " + _3396 + @" -= " + _8551 + @" 
" + _9325 + @" += 1 
if 
  " + _3396 + @" > 0 
jf @ROULETE_5425 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if or
  " + _3400 + @" == 0 
  " + _3400 + @" == 1 
jf @ROULETE_5408 
if 
  " + _9325 + @" > 1 
jf @ROULETE_5315 
0209: " + _3400 + @" = random_int_in_ranges 3 6 
jump @ROULETE_5324 

:ROULETE_5315
0209: " + _3400 + @" = random_int_in_ranges 0 3 

:ROULETE_5324
if 
   not Actor.Dead(26@)
jf @ROULETE_5401 
if 
04A4:   23@ == 11 
jf @ROULETE_5383 
09D6: unknown_set_actor 26@ sound " + tmp_3820 + @"(" + _3400 + @",6i) flags 1 1 0 
jump @ROULETE_5401 

:ROULETE_5383
09D6: unknown_set_actor 26@ sound " + tmp_3879 + @"(" + _3400 + @",6i) flags 1 1 0 

:ROULETE_5401
jump @ROULETE_5418 

:ROULETE_5408
0947: actor " + PlayerActor + @" speak_from_audio_table 100 store_spoken_phrase_id_to " + Gambles_CashWin + @" 

:ROULETE_5418
jump @ROULETE_5469 

:ROULETE_5425
0209: " + Color_Red + @" = random_int_in_ranges 0 2 
if 
  " + Color_Red + @" == 0 
jf @ROULETE_5462 
0947: actor " + PlayerActor + @" speak_from_audio_table 101 store_spoken_phrase_id_to " + Gambles_CashWin + @" 

:ROULETE_5462
" + _9325 + @" = 0 

:ROULETE_5469
22@ = 1 
gosub @ROULETE_815 
" + _8549 + @" = 0 

:ROULETE_5490
if 
  151 > " + _8549 + @" 
jf @ROULETE_5532 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + _8549 + @" += 1 
jump @ROULETE_5490 

:ROULETE_5532
" + _3505 + @" = 0 

:ROULETE_5539
jump @ROULETE_5553 

:ROULETE_5546
7@ = 0 

:ROULETE_5553
if and
  " + _3505 + @" > 0 
  3 > " + _3505 + @" 
jf @ROULETE_5613 
007B: 25@ += frame_delta_time * 24@ 
0453: set_object 27@ XYZ_rotation 0.0 0.0 25@ 
0209: 18@ = random_int_in_ranges 0 37 

:ROULETE_5613
0494: get_joystick 0 direction_offset_to " + _8555 + @" " + _8556 + @" " + _8557 + @" " + _8558 + @" 
if or
00E1:   player 0 pressed_key 10 
  -80 > " + _8555 + @" 
jf @ROULETE_6087 
if 
  2@ == 0 
jf @ROULETE_6054 
008B: 12@ = " + Current_Time_in_ms2 + @" 
12@ += 80 
if 
  0.0 > " + _3499 + @" 
jf @ROULETE_5804 
if 
   not " + _3500 + @" == 2.0 
jf @ROULETE_5797 
if 
   not " + _3499 + @" == 0.0 
jf @ROULETE_5797 
if 
  " + _3500 + @" == -24.0 
jf @ROULETE_5787 
" + _3499 + @" += 2.0 
jump @ROULETE_5797 

:ROULETE_5787
" + _3499 + @" += 1.0 

:ROULETE_5797
jump @ROULETE_6040 

:ROULETE_5804
if 
  " + _3499 + @" == 0.0 
jf @ROULETE_5999 
if and
  2.0 > " + _3500 + @" 
  " + _3500 + @" > -7.0 
jf @ROULETE_5883 
" + _3499 + @" += 2.0 
" + _3500 + @" = -3.0 
jump @ROULETE_5992 

:ROULETE_5883
if and
  -6.0 > " + _3500 + @" 
  " + _3500 + @" > -15.0 
jf @ROULETE_5941 
" + _3499 + @" += 2.0 
" + _3500 + @" = -11.0 
jump @ROULETE_5992 

:ROULETE_5941
if and
  -14.0 > " + _3500 + @" 
  " + _3500 + @" > -24.0 
jf @ROULETE_5992 
" + _3499 + @" += 2.0 
" + _3500 + @" = -19.0 

:ROULETE_5992
jump @ROULETE_6040 

:ROULETE_5999
if 
  " + _3499 + @" == 2.0 
jf @ROULETE_6040 
" + _3499 + @" += 2.0 
" + _3500 + @" += 2.0 

:ROULETE_6040
2@ += 1 
jump @ROULETE_6080 

:ROULETE_6054
if 
001E:   " + Current_Time_in_ms2 + @" > 12@ 
jf @ROULETE_6080 
2@ = 0 

:ROULETE_6080
jump @ROULETE_6094 

:ROULETE_6087
2@ = 0 

:ROULETE_6094
if or
00E1:   player 0 pressed_key 11 
  " + _8555 + @" > 80 
jf @ROULETE_6521 
if 
  3@ == 0 
jf @ROULETE_6488 
008B: 13@ = " + Current_Time_in_ms2 + @" 
13@ += 80 
if 
  " + _3499 + @" > -4.0 
jf @ROULETE_6412 
if 
   not " + _3500 + @" == 2.0 
jf @ROULETE_6405 
if 
   not " + _3499 + @" == -4.0 
jf @ROULETE_6405 
if or
  " + _3500 + @" == -24.0 
  " + _3499 + @" == 2.0 
  " + _3499 + @" == 4.0 
jf @ROULETE_6395 
if or
  " + _3500 + @" == -1.0 
  " + _3500 + @" == -5.0 
jf @ROULETE_6296 
" + _3500 + @" = -3.0 

:ROULETE_6296
if or
  " + _3500 + @" == -9.0 
  " + _3500 + @" == -13.0 
jf @ROULETE_6337 
" + _3500 + @" = -11.0 

:ROULETE_6337
if or
  " + _3500 + @" == -17.0 
  " + _3500 + @" == -21.0 
jf @ROULETE_6378 
" + _3500 + @" = -19.0 

:ROULETE_6378
" + _3499 + @" += -2.0 
jump @ROULETE_6405 

:ROULETE_6395
" + _3499 + @" += -1.0 

:ROULETE_6405
jump @ROULETE_6474 

:ROULETE_6412
if 
  " + _3499 + @" == -4.0 
jf @ROULETE_6474 
if and
  " + _3500 + @" > -23.0 
  1.0 > " + _3500 + @" 
jf @ROULETE_6474 
" + _3499 + @" += -1.0 

:ROULETE_6474
3@ += 1 
jump @ROULETE_6514 

:ROULETE_6488
if 
001E:   " + Current_Time_in_ms2 + @" > 13@ 
jf @ROULETE_6514 
3@ = 0 

:ROULETE_6514
jump @ROULETE_6528 

:ROULETE_6521
3@ = 0 

:ROULETE_6528
if or
00E1:   player 0 pressed_key 8 
  -80 > " + _8556 + @" 
jf @ROULETE_6867 
if 
  4@ == 0 
jf @ROULETE_6834 
008B: 14@ = " + Current_Time_in_ms2 + @" 
14@ += 80 
if 
  0.0 > " + _3500 + @" 
jf @ROULETE_6779 
if 
  " + _3500 + @" == -24.0 
jf @ROULETE_6644 
" + _3500 + @" += 2.0 
jump @ROULETE_6772 

:ROULETE_6644
if 
  " + _3499 + @" == 2.0 
jf @ROULETE_6703 
if 
   not " + _3500 + @" == -3.0 
jf @ROULETE_6696 
" + _3500 + @" += 8.0 

:ROULETE_6696
jump @ROULETE_6772 

:ROULETE_6703
if 
  " + _3499 + @" == 4.0 
jf @ROULETE_6762 
if 
   not " + _3500 + @" == -1.0 
jf @ROULETE_6755 
" + _3500 + @" += 4.0 

:ROULETE_6755
jump @ROULETE_6772 

:ROULETE_6762
" + _3500 + @" += 1.0 

:ROULETE_6772
jump @ROULETE_6820 

:ROULETE_6779
if 
  " + _3500 + @" == 0.0 
jf @ROULETE_6820 
" + _3500 + @" += 2.0 
" + _3499 + @" = -2.0 

:ROULETE_6820
4@ += 1 
jump @ROULETE_6860 

:ROULETE_6834
if 
001E:   " + Current_Time_in_ms2 + @" > 14@ 
jf @ROULETE_6860 
4@ = 0 

:ROULETE_6860
jump @ROULETE_6874 

:ROULETE_6867
4@ = 0 

:ROULETE_6874
if or
00E1:   player 0 pressed_key 9 
  " + _8556 + @" > 80 
jf @ROULETE_7331 
if 
  5@ == 0 
jf @ROULETE_7298 
008B: 15@ = " + Current_Time_in_ms2 + @" 
15@ += 80 
if 
  " + _3500 + @" > -22.0 
jf @ROULETE_7125 
if 
  " + _3500 + @" == 2.0 
jf @ROULETE_6990 
" + _3500 + @" += -2.0 
jump @ROULETE_7118 

:ROULETE_6990
if 
  " + _3499 + @" == 2.0 
jf @ROULETE_7049 
if 
   not " + _3500 + @" == -19.0 
jf @ROULETE_7042 
" + _3500 + @" += -8.0 

:ROULETE_7042
jump @ROULETE_7118 

:ROULETE_7049
if 
  " + _3499 + @" == 4.0 
jf @ROULETE_7108 
if 
   not " + _3500 + @" == -21.0 
jf @ROULETE_7101 
" + _3500 + @" += -4.0 

:ROULETE_7101
jump @ROULETE_7118 

:ROULETE_7108
" + _3500 + @" += -1.0 

:ROULETE_7118
jump @ROULETE_7284 

:ROULETE_7125
if 
  " + _3499 + @" == -4.0 
jf @ROULETE_7184 
if 
   not " + _3500 + @" == -24.0 
jf @ROULETE_7177 
" + _3500 + @" += -2.0 

:ROULETE_7177
jump @ROULETE_7284 

:ROULETE_7184
if 
  " + _3499 + @" == 0.0 
jf @ROULETE_7243 
if 
   not " + _3500 + @" == -24.0 
jf @ROULETE_7236 
" + _3500 + @" += -2.0 

:ROULETE_7236
jump @ROULETE_7284 

:ROULETE_7243
if 
   not " + _3500 + @" == -24.0 
jf @ROULETE_7284 
" + _3499 + @" = -2.0 
" + _3500 + @" += -2.0 

:ROULETE_7284
5@ += 1 
jump @ROULETE_7324 

:ROULETE_7298
if 
001E:   " + Current_Time_in_ms2 + @" > 15@ 
jf @ROULETE_7324 
5@ = 0 

:ROULETE_7324
jump @ROULETE_7338 

:ROULETE_7331
5@ = 0 

:ROULETE_7338
0086: " + _3503 + @" = " + _3499 + @" 
0069: " + _3503 + @" *= " + _3494 + @" 
0086: " + _3504 + @" = " + _3500 + @" 
0069: " + _3504 + @" *= " + _3495 + @" 
0086: " + _3501 + @" = " + _3496 + @" 
0059: " + _3501 + @" += " + _3503 + @" 
0086: " + _3502 + @" = " + _3497 + @" 
0059: " + _3502 + @" += " + _3504 + @" 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + _3501 + @" " + _3502 + @" " + _3498 + @" 
" + tempvar_Float_3 + @" += 0.01 
Object.PutAt(" + _8552 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:ROULETE_7449
jump @ROULETE_7584 

:ROULETE_7456
if 
  1@ > 0 
jf @ROULETE_7584 
if 
  1@ > 3 
jf @ROULETE_7494 
03E6: remove_text_box 

:ROULETE_7494
Actor.DestroyInstantly(26@)
Model.Destroy(23@)
22@ = 1 
gosub @ROULETE_815 
" + _8549 + @" = 0 

:ROULETE_7525
if 
  151 > " + _8549 + @" 
jf @ROULETE_7567 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + _8549 + @" += 1 
jump @ROULETE_7525 

:ROULETE_7567
Object.Destroy(" + _8552 + @")
Object.Destroy(27@)
1@ = 0 

:ROULETE_7584
jump @ROULETE_7728 

:ROULETE_7591
if 
  1@ > 0 
jf @ROULETE_7719 
if 
  1@ > 3 
jf @ROULETE_7629 
03E6: remove_text_box 

:ROULETE_7629
Actor.DestroyInstantly(26@)
Model.Destroy(23@)
22@ = 1 
gosub @ROULETE_815 
" + _8549 + @" = 0 

:ROULETE_7660
if 
  151 > " + _8549 + @" 
jf @ROULETE_7702 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + _8549 + @" += 1 
jump @ROULETE_7660 

:ROULETE_7702
Object.Destroy(" + _8552 + @")
Object.Destroy(27@)
1@ = 0 

:ROULETE_7719
" + _1523 + @" -= 1 
end_thread 

:ROULETE_7728
jump @ROULETE_7872 

:ROULETE_7735
if 
  1@ > 0 
jf @ROULETE_7863 
if 
  1@ > 3 
jf @ROULETE_7773 
03E6: remove_text_box 

:ROULETE_7773
Actor.DestroyInstantly(26@)
Model.Destroy(23@)
22@ = 1 
gosub @ROULETE_815 
" + _8549 + @" = 0 

:ROULETE_7804
if 
  151 > " + _8549 + @" 
jf @ROULETE_7846 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + _8549 + @" += 1 
jump @ROULETE_7804 

:ROULETE_7846
Object.Destroy(" + _8552 + @")
Object.Destroy(27@)
1@ = 0 

:ROULETE_7863
" + _1523 + @" -= 1 
end_thread 

:ROULETE_7872
jump @ROULETE_8016 

:ROULETE_7879
if 
  1@ > 0 
jf @ROULETE_8007 
if 
  1@ > 3 
jf @ROULETE_7917 
03E6: remove_text_box 

:ROULETE_7917
Actor.DestroyInstantly(26@)
Model.Destroy(23@)
22@ = 1 
gosub @ROULETE_815 
" + _8549 + @" = 0 

:ROULETE_7948
if 
  151 > " + _8549 + @" 
jf @ROULETE_7990 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + _8549 + @" += 1 
jump @ROULETE_7948 

:ROULETE_7990
Object.Destroy(" + _8552 + @")
Object.Destroy(27@)
1@ = 0 

:ROULETE_8007
" + _1523 + @" -= 1 
end_thread 

:ROULETE_8016
jump @ROULETE_927 

:ROULETE_8023
" + _8549 + @" = 0 

:ROULETE_8030
if 
  151 > " + _8549 + @" 
jf @ROULETE_9701 
if 
0044:   " + _3499 + @" == " + tmp_3507 + @"(" + _8549 + @",151f) 
jf @ROULETE_9687 
if 
0044:   " + _3500 + @" == " + tmp_3658 + @"(" + _8549 + @",151f) 
jf @ROULETE_9687 
008B: 20@ = " + tmp_8398 + @"(" + _8549 + @",151i) 
if 
00E1:   player 0 pressed_key 14 
jf @ROULETE_9317 
if 
001E:   " + Current_Time_in_ms2 + @" > 8@ 
jf @ROULETE_9310 
" + ROULETE_Player_Cash + @" = Player.Money(" + PlayerChar + @")
" + ROULETE_Player_Cash + @" += 1 
0652: " + STAT_Gambling_Skill + @" = integer_stat 81 
if 
  " + STAT_Gambling_Skill + @" > 999 
jf @ROULETE_8338 
008A: " + Gambles_CashWin + @" = 17@ 
" + Gambles_CashWin + @" -= 1000000 
if 
  1 > " + ROULETE_Player_Cash + @" 
jf @ROULETE_8331 
if 
  28@ == 0 
jf @ROULETE_8331 
if 
   not Actor.Dead(26@)
jf @ROULETE_8324 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if 
04A4:   23@ == 11 
jf @ROULETE_8306 
09D6: unknown_set_actor 26@ sound " + tmp_3867 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_8324 

:ROULETE_8306
09D6: unknown_set_actor 26@ sound " + tmp_3926 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_8324
28@ = 1 

:ROULETE_8331
jump @ROULETE_8858 

:ROULETE_8338
if 
  " + STAT_Gambling_Skill + @" > 100 
jf @ROULETE_8510 
008A: " + Gambles_CashWin + @" = 17@ 
" + Gambles_CashWin + @" -= 100000 
if 
  1 > " + ROULETE_Player_Cash + @" 
jf @ROULETE_8503 
if 
  28@ == 0 
jf @ROULETE_8503 
if 
   not Actor.Dead(26@)
jf @ROULETE_8496 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if 
04A4:   23@ == 11 
jf @ROULETE_8478 
09D6: unknown_set_actor 26@ sound " + tmp_3867 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_8496 

:ROULETE_8478
09D6: unknown_set_actor 26@ sound " + tmp_3926 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_8496
28@ = 1 

:ROULETE_8503
jump @ROULETE_8858 

:ROULETE_8510
if 
  " + STAT_Gambling_Skill + @" > 10 
jf @ROULETE_8680 
008A: " + Gambles_CashWin + @" = 17@ 
" + Gambles_CashWin + @" -= 10000 
if 
  1 > " + ROULETE_Player_Cash + @" 
jf @ROULETE_8673 
if 
  28@ == 0 
jf @ROULETE_8673 
if 
   not Actor.Dead(26@)
jf @ROULETE_8666 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if 
04A4:   23@ == 11 
jf @ROULETE_8648 
09D6: unknown_set_actor 26@ sound " + tmp_3867 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_8666 

:ROULETE_8648
09D6: unknown_set_actor 26@ sound " + tmp_3926 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_8666
28@ = 1 

:ROULETE_8673
jump @ROULETE_8858 

:ROULETE_8680
if 
  " + STAT_Gambling_Skill + @" > 1 
jf @ROULETE_8850 
008A: " + Gambles_CashWin + @" = 17@ 
" + Gambles_CashWin + @" -= 1000 
if 
  1 > " + ROULETE_Player_Cash + @" 
jf @ROULETE_8843 
if 
  28@ == 0 
jf @ROULETE_8843 
if 
   not Actor.Dead(26@)
jf @ROULETE_8836 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if 
04A4:   23@ == 11 
jf @ROULETE_8818 
09D6: unknown_set_actor 26@ sound " + tmp_3867 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_8836 

:ROULETE_8818
09D6: unknown_set_actor 26@ sound " + tmp_3926 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_8836
28@ = 1 

:ROULETE_8843
jump @ROULETE_8858 

:ROULETE_8850
008A: " + Gambles_CashWin + @" = 17@ 

:ROULETE_8858
if and
001F:   21@ > " + _8551 + @" 
001C:   " + ROULETE_Player_Cash + @" > " + Gambles_CashWin + @" 
jf @ROULETE_9145 
03CF: load_wav 1813 as 4 
if 
03D0:   wav 4 loaded 
jf @ROULETE_8927 
097A: play_audio_at 0.0 0.0 0.0 event 1083 

:ROULETE_8927
005A: 20@ += 17@ 
008A: " + ROULETE_Player_Cash + @" = 17@ 
" + ROULETE_Player_Cash + @" *= -1 
Player.Money(" + PlayerChar + @") += " + ROULETE_Player_Cash + @"
005E: " + _8551 + @" += 17@ 
008A: " + ROULETE_Player_Cash + @" = 17@ 
" + ROULETE_Player_Cash + @" *= 26 
if 
001E:   " + ROULETE_Player_Cash + @" > 20@ 
jf @ROULETE_9096 
Object.StorePos(" + _8552 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Float_3 + @" += -0.14 
008A: " + ROULETE_Player_Cash + @" = 20@ 
0074: " + ROULETE_Player_Cash + @" /= 17@ 
008D: " + _3401 + @" = integer " + ROULETE_Player_Cash + @" to_float 
" + _3401 + @" *= 0.005 
0059: " + tempvar_Float_3 + @" += " + _3401 + @" 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i) = Object.Init(19@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:ROULETE_9096
008B: 8@ = " + Current_Time_in_ms2 + @" 
005A: 8@ += 10@ 
if 
  10@ == 500 
jf @ROULETE_9138 
10@ = 80 

:ROULETE_9138
jump @ROULETE_9310 

:ROULETE_9145
if 
002C:   " + Gambles_CashWin + @" >= " + ROULETE_Player_Cash + @" 
jf @ROULETE_9250 
if 
   not Actor.Dead(26@)
jf @ROULETE_9250 
0209: " + _3400 + @" = random_int_in_ranges 0 3 
if 
04A4:   23@ == 11 
jf @ROULETE_9232 
09D6: unknown_set_actor 26@ sound " + tmp_3814 + @"(" + _3400 + @",3i) flags 1 1 0 
jump @ROULETE_9250 

:ROULETE_9232
09D6: unknown_set_actor 26@ sound " + tmp_3873 + @"(" + _3400 + @",3i) flags 1 1 0 

:ROULETE_9250
03CF: load_wav 1813 as 4 
if 
03D0:   wav 4 loaded 
jf @ROULETE_9292 
097A: play_audio_at 0.0 0.0 0.0 event 1085 

:ROULETE_9292
008B: 8@ = " + Current_Time_in_ms2 + @" 
8@ += 6000000 

:ROULETE_9310
jump @ROULETE_9675 

:ROULETE_9317
008B: 8@ = " + Current_Time_in_ms2 + @" 
10@ = 500 
if 
00E1:   player 0 pressed_key 17 
jf @ROULETE_9659 
if 
001E:   " + Current_Time_in_ms2 + @" > 6@ 
jf @ROULETE_9652 
if or
001D:   20@ > 17@ 
003B:   20@ == 17@ 
jf @ROULETE_9610 
03CF: load_wav 1813 as 4 
if 
03D0:   wav 4 loaded 
jf @ROULETE_9438 
097A: play_audio_at 0.0 0.0 0.0 event 1084 

:ROULETE_9438
0062: 20@ -= 17@ 
0066: " + _8551 + @" -= 17@ 
Player.Money(" + PlayerChar + @") += 17@
008A: " + ROULETE_Player_Cash + @" = 17@ 
" + ROULETE_Player_Cash + @" *= 26 
if 
001E:   " + ROULETE_Player_Cash + @" > 20@ 
jf @ROULETE_9610 
Object.StorePos(" + _8552 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Float_3 + @" += -0.14 
008A: " + ROULETE_Player_Cash + @" = 20@ 
0074: " + ROULETE_Player_Cash + @" /= 17@ 
008D: " + _3401 + @" = integer " + ROULETE_Player_Cash + @" to_float 
" + _3401 + @" *= 0.005 
0059: " + tempvar_Float_3 + @" += " + _3401 + @" 
Object.Destroy(" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i))
if 
  20@ > 0 
jf @ROULETE_9610 
" + tmp_ROULETE_Chips + @"(" + _8549 + @",151i) = Object.Init(19@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:ROULETE_9610
008B: 6@ = " + Current_Time_in_ms2 + @" 
005A: 6@ += 11@ 
if 
  11@ == 500 
jf @ROULETE_9652 
11@ = 80 

:ROULETE_9652
jump @ROULETE_9675 

:ROULETE_9659
008B: 6@ = " + Current_Time_in_ms2 + @" 
11@ = 500 

:ROULETE_9675
008A: " + tmp_8398 + @"(" + _8549 + @",151i) = 20@ 

:ROULETE_9687
" + _8549 + @" += 1 
jump @ROULETE_8030 

:ROULETE_9701
return 

:ROULETE_9703
if 
  18@ == 0 
jf @ROULETE_9743 
" + tmp_8398 + @"[0] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[0] 
" + tmp_8398 + @"[0] = 0 

:ROULETE_9743
if 
  18@ == 1 
jf @ROULETE_9926 
" + tmp_8398 + @"[1] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[1] 
" + tmp_8398 + @"[37] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[37] 
" + tmp_8398 + @"[61] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[61] 
" + tmp_8398 + @"[94] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[94] 
" + tmp_8398 + @"[106] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[106] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[140] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[140] 

:ROULETE_9926
if 
  18@ == 2 
jf @ROULETE_10139 
" + tmp_8398 + @"[2] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[2] 
" + tmp_8398 + @"[37] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[37] 
" + tmp_8398 + @"[38] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[38] 
" + tmp_8398 + @"[62] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[62] 
" + tmp_8398 + @"[94] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[94] 
" + tmp_8398 + @"[106] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[106] 
" + tmp_8398 + @"[107] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[106] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[140] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[140] 

:ROULETE_10139
if 
  18@ == 3 
jf @ROULETE_10322 
" + tmp_8398 + @"[3] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[3] 
" + tmp_8398 + @"[38] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[38] 
" + tmp_8398 + @"[63] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[63] 
" + tmp_8398 + @"[94] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[94] 
" + tmp_8398 + @"[107] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[106] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[140] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[140] 

:ROULETE_10322
if 
  18@ == 4 
jf @ROULETE_10550 
" + tmp_8398 + @"[4] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[4] 
" + tmp_8398 + @"[61] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[61] 
" + tmp_8398 + @"[39] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[39] 
" + tmp_8398 + @"[64] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[64] 
" + tmp_8398 + @"[95] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[95] 
" + tmp_8398 + @"[106] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[106] 
" + tmp_8398 + @"[108] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[108] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[140] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[140] 
" + tmp_8398 + @"[141] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[141] 

:ROULETE_10550
if 
  18@ == 5 
jf @ROULETE_10823 
" + tmp_8398 + @"[5] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[5] 
" + tmp_8398 + @"[62] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[62] 
" + tmp_8398 + @"[39] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[39] 
" + tmp_8398 + @"[40] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[40] 
" + tmp_8398 + @"[65] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[65] 
" + tmp_8398 + @"[95] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[95] 
" + tmp_8398 + @"[106] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[106] 
" + tmp_8398 + @"[107] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[107] 
" + tmp_8398 + @"[108] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[108] 
" + tmp_8398 + @"[109] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[109] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[140] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[140] 
" + tmp_8398 + @"[141] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[141] 

:ROULETE_10823
if 
  18@ == 6 
jf @ROULETE_11051 
" + tmp_8398 + @"[6] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[6] 
" + tmp_8398 + @"[63] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[63] 
" + tmp_8398 + @"[40] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[40] 
" + tmp_8398 + @"[66] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[66] 
" + tmp_8398 + @"[95] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[95] 
" + tmp_8398 + @"[107] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[107] 
" + tmp_8398 + @"[109] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[109] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[140] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[140] 
" + tmp_8398 + @"[141] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[141] 

:ROULETE_11051
if 
  18@ == 7 
jf @ROULETE_11279 
" + tmp_8398 + @"[7] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[7] 
" + tmp_8398 + @"[64] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[64] 
" + tmp_8398 + @"[41] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[41] 
" + tmp_8398 + @"[67] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[67] 
" + tmp_8398 + @"[96] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[96] 
" + tmp_8398 + @"[108] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[108] 
" + tmp_8398 + @"[110] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[110] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[141] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[141] 
" + tmp_8398 + @"[142] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[142] 

:ROULETE_11279
if 
  18@ == 8 
jf @ROULETE_11552 
" + tmp_8398 + @"[8] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[8] 
" + tmp_8398 + @"[65] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[65] 
" + tmp_8398 + @"[41] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[41] 
" + tmp_8398 + @"[42] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[42] 
" + tmp_8398 + @"[68] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[68] 
" + tmp_8398 + @"[96] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[96] 
" + tmp_8398 + @"[108] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[108] 
" + tmp_8398 + @"[109] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[109] 
" + tmp_8398 + @"[110] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[110] 
" + tmp_8398 + @"[111] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[111] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[141] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[141] 
" + tmp_8398 + @"[142] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[142] 

:ROULETE_11552
if 
  18@ == 9 
jf @ROULETE_11780 
" + tmp_8398 + @"[9] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[9] 
" + tmp_8398 + @"[66] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[66] 
" + tmp_8398 + @"[42] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[42] 
" + tmp_8398 + @"[69] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[69] 
" + tmp_8398 + @"[96] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[96] 
" + tmp_8398 + @"[109] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[109] 
" + tmp_8398 + @"[111] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[111] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[141] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[141] 
" + tmp_8398 + @"[142] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[142] 

:ROULETE_11780
if 
  18@ == 10 
jf @ROULETE_12008 
" + tmp_8398 + @"[10] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[10] 
" + tmp_8398 + @"[67] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[67] 
" + tmp_8398 + @"[43] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[43] 
" + tmp_8398 + @"[70] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[70] 
" + tmp_8398 + @"[97] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[97] 
" + tmp_8398 + @"[110] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[110] 
" + tmp_8398 + @"[112] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[112] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[142] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[142] 
" + tmp_8398 + @"[143] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[143] 

:ROULETE_12008
if 
  18@ == 11 
jf @ROULETE_12281 
" + tmp_8398 + @"[11] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[11] 
" + tmp_8398 + @"[68] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[68] 
" + tmp_8398 + @"[43] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[43] 
" + tmp_8398 + @"[44] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[44] 
" + tmp_8398 + @"[71] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[71] 
" + tmp_8398 + @"[97] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[97] 
" + tmp_8398 + @"[110] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[110] 
" + tmp_8398 + @"[111] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[111] 
" + tmp_8398 + @"[112] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[112] 
" + tmp_8398 + @"[113] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[113] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[142] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[142] 
" + tmp_8398 + @"[143] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[143] 

:ROULETE_12281
if 
  18@ == 12 
jf @ROULETE_12509 
" + tmp_8398 + @"[12] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[12] 
" + tmp_8398 + @"[69] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[69] 
" + tmp_8398 + @"[44] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[44] 
" + tmp_8398 + @"[72] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[72] 
" + tmp_8398 + @"[97] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[97] 
" + tmp_8398 + @"[111] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[111] 
" + tmp_8398 + @"[113] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[113] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[131] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[131] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[142] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[142] 
" + tmp_8398 + @"[143] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[143] 

:ROULETE_12509
if 
  18@ == 13 
jf @ROULETE_12737 
" + tmp_8398 + @"[13] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[13] 
" + tmp_8398 + @"[70] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[70] 
" + tmp_8398 + @"[45] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[45] 
" + tmp_8398 + @"[73] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[73] 
" + tmp_8398 + @"[98] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[98] 
" + tmp_8398 + @"[112] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[112] 
" + tmp_8398 + @"[114] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[114] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[143] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[143] 
" + tmp_8398 + @"[144] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[144] 

:ROULETE_12737
if 
  18@ == 14 
jf @ROULETE_13010 
" + tmp_8398 + @"[14] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[14] 
" + tmp_8398 + @"[71] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[71] 
" + tmp_8398 + @"[45] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[45] 
" + tmp_8398 + @"[46] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[46] 
" + tmp_8398 + @"[74] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[74] 
" + tmp_8398 + @"[98] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[98] 
" + tmp_8398 + @"[112] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[112] 
" + tmp_8398 + @"[113] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[113] 
" + tmp_8398 + @"[114] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[114] 
" + tmp_8398 + @"[115] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[115] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[143] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[143] 
" + tmp_8398 + @"[144] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[144] 

:ROULETE_13010
if 
  18@ == 15 
jf @ROULETE_13238 
" + tmp_8398 + @"[15] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[15] 
" + tmp_8398 + @"[72] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[72] 
" + tmp_8398 + @"[46] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[46] 
" + tmp_8398 + @"[75] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[75] 
" + tmp_8398 + @"[98] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[98] 
" + tmp_8398 + @"[113] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[113] 
" + tmp_8398 + @"[115] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[115] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[143] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[143] 
" + tmp_8398 + @"[144] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[144] 

:ROULETE_13238
if 
  18@ == 16 
jf @ROULETE_13466 
" + tmp_8398 + @"[16] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[16] 
" + tmp_8398 + @"[73] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[73] 
" + tmp_8398 + @"[47] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[47] 
" + tmp_8398 + @"[76] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[76] 
" + tmp_8398 + @"[99] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[99] 
" + tmp_8398 + @"[114] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[114] 
" + tmp_8398 + @"[116] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[116] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[144] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[144] 
" + tmp_8398 + @"[145] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[145] 

:ROULETE_13466
if 
  18@ == 17 
jf @ROULETE_13739 
" + tmp_8398 + @"[17] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[17] 
" + tmp_8398 + @"[74] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[74] 
" + tmp_8398 + @"[47] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[47] 
" + tmp_8398 + @"[48] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[48] 
" + tmp_8398 + @"[77] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[77] 
" + tmp_8398 + @"[99] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[99] 
" + tmp_8398 + @"[114] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[114] 
" + tmp_8398 + @"[115] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[115] 
" + tmp_8398 + @"[116] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[116] 
" + tmp_8398 + @"[117] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[117] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[144] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[144] 
" + tmp_8398 + @"[145] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[145] 

:ROULETE_13739
if 
  18@ == 18 
jf @ROULETE_13967 
" + tmp_8398 + @"[18] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[18] 
" + tmp_8398 + @"[75] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[75] 
" + tmp_8398 + @"[48] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[48] 
" + tmp_8398 + @"[78] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[78] 
" + tmp_8398 + @"[99] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[99] 
" + tmp_8398 + @"[115] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[115] 
" + tmp_8398 + @"[117] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[117] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[134] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[134] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[144] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[144] 
" + tmp_8398 + @"[145] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[145] 

:ROULETE_13967
if 
  18@ == 19 
jf @ROULETE_14195 
" + tmp_8398 + @"[19] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[19] 
" + tmp_8398 + @"[76] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[76] 
" + tmp_8398 + @"[49] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[49] 
" + tmp_8398 + @"[79] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[79] 
" + tmp_8398 + @"[100] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[100] 
" + tmp_8398 + @"[116] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[116] 
" + tmp_8398 + @"[118] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[118] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[145] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[145] 
" + tmp_8398 + @"[146] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[146] 

:ROULETE_14195
if 
  18@ == 20 
jf @ROULETE_14468 
" + tmp_8398 + @"[20] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[20] 
" + tmp_8398 + @"[77] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[77] 
" + tmp_8398 + @"[49] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[49] 
" + tmp_8398 + @"[50] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[50] 
" + tmp_8398 + @"[80] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[80] 
" + tmp_8398 + @"[100] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[100] 
" + tmp_8398 + @"[116] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[116] 
" + tmp_8398 + @"[117] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[117] 
" + tmp_8398 + @"[118] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[118] 
" + tmp_8398 + @"[119] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[119] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[145] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[145] 
" + tmp_8398 + @"[146] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[146] 

:ROULETE_14468
if 
  18@ == 21 
jf @ROULETE_14696 
" + tmp_8398 + @"[21] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[21] 
" + tmp_8398 + @"[78] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[78] 
" + tmp_8398 + @"[50] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[50] 
" + tmp_8398 + @"[81] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[81] 
" + tmp_8398 + @"[100] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[100] 
" + tmp_8398 + @"[117] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[117] 
" + tmp_8398 + @"[119] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[119] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[145] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[145] 
" + tmp_8398 + @"[146] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[146] 

:ROULETE_14696
if 
  18@ == 22 
jf @ROULETE_14924 
" + tmp_8398 + @"[22] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[22] 
" + tmp_8398 + @"[79] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[79] 
" + tmp_8398 + @"[51] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[51] 
" + tmp_8398 + @"[82] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[82] 
" + tmp_8398 + @"[101] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[101] 
" + tmp_8398 + @"[118] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[118] 
" + tmp_8398 + @"[120] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[120] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[146] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[146] 
" + tmp_8398 + @"[147] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[147] 

:ROULETE_14924
if 
  18@ == 23 
jf @ROULETE_15197 
" + tmp_8398 + @"[23] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[23] 
" + tmp_8398 + @"[80] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[80] 
" + tmp_8398 + @"[51] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[51] 
" + tmp_8398 + @"[52] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[52] 
" + tmp_8398 + @"[83] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[83] 
" + tmp_8398 + @"[101] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[101] 
" + tmp_8398 + @"[118] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[118] 
" + tmp_8398 + @"[119] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[119] 
" + tmp_8398 + @"[120] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[120] 
" + tmp_8398 + @"[121] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[121] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[146] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[146] 
" + tmp_8398 + @"[147] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[147] 

:ROULETE_15197
if 
  18@ == 24 
jf @ROULETE_15425 
" + tmp_8398 + @"[24] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[24] 
" + tmp_8398 + @"[81] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[81] 
" + tmp_8398 + @"[52] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[52] 
" + tmp_8398 + @"[84] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[84] 
" + tmp_8398 + @"[101] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[101] 
" + tmp_8398 + @"[119] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[119] 
" + tmp_8398 + @"[121] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[121] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[132] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[132] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[146] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[146] 
" + tmp_8398 + @"[147] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[147] 

:ROULETE_15425
if 
  18@ == 25 
jf @ROULETE_15653 
" + tmp_8398 + @"[25] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[25] 
" + tmp_8398 + @"[82] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[82] 
" + tmp_8398 + @"[53] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[53] 
" + tmp_8398 + @"[85] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[85] 
" + tmp_8398 + @"[102] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[102] 
" + tmp_8398 + @"[120] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[120] 
" + tmp_8398 + @"[122] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[122] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[147] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[147] 
" + tmp_8398 + @"[148] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[148] 

:ROULETE_15653
if 
  18@ == 26 
jf @ROULETE_15926 
" + tmp_8398 + @"[26] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[26] 
" + tmp_8398 + @"[83] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[83] 
" + tmp_8398 + @"[53] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[53] 
" + tmp_8398 + @"[54] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[54] 
" + tmp_8398 + @"[86] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[86] 
" + tmp_8398 + @"[102] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[102] 
" + tmp_8398 + @"[120] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[120] 
" + tmp_8398 + @"[121] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[121] 
" + tmp_8398 + @"[122] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[122] 
" + tmp_8398 + @"[123] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[123] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[147] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[147] 
" + tmp_8398 + @"[148] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[148] 

:ROULETE_15926
if 
  18@ == 27 
jf @ROULETE_16154 
" + tmp_8398 + @"[27] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[27] 
" + tmp_8398 + @"[84] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[84] 
" + tmp_8398 + @"[54] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[54] 
" + tmp_8398 + @"[87] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[87] 
" + tmp_8398 + @"[102] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[102] 
" + tmp_8398 + @"[121] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[121] 
" + tmp_8398 + @"[123] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[123] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[147] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[147] 
" + tmp_8398 + @"[148] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[148] 

:ROULETE_16154
if 
  18@ == 28 
jf @ROULETE_16382 
" + tmp_8398 + @"[28] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[28] 
" + tmp_8398 + @"[85] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[85] 
" + tmp_8398 + @"[55] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[55] 
" + tmp_8398 + @"[88] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[88] 
" + tmp_8398 + @"[103] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[103] 
" + tmp_8398 + @"[122] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[122] 
" + tmp_8398 + @"[124] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[124] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[148] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[148] 
" + tmp_8398 + @"[149] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[149] 

:ROULETE_16382
if 
  18@ == 29 
jf @ROULETE_16655 
" + tmp_8398 + @"[29] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[29] 
" + tmp_8398 + @"[86] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[86] 
" + tmp_8398 + @"[55] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[55] 
" + tmp_8398 + @"[56] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[56] 
" + tmp_8398 + @"[89] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[89] 
" + tmp_8398 + @"[103] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[103] 
" + tmp_8398 + @"[122] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[122] 
" + tmp_8398 + @"[123] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[123] 
" + tmp_8398 + @"[124] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[124] 
" + tmp_8398 + @"[125] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[125] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[148] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[148] 
" + tmp_8398 + @"[149] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[149] 

:ROULETE_16655
if 
  18@ == 30 
jf @ROULETE_16883 
" + tmp_8398 + @"[30] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[30] 
" + tmp_8398 + @"[87] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[87] 
" + tmp_8398 + @"[56] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[56] 
" + tmp_8398 + @"[90] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[90] 
" + tmp_8398 + @"[103] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[103] 
" + tmp_8398 + @"[123] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[123] 
" + tmp_8398 + @"[125] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[125] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[148] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[148] 
" + tmp_8398 + @"[149] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[149] 

:ROULETE_16883
if 
  18@ == 31 
jf @ROULETE_17111 
" + tmp_8398 + @"[31] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[31] 
" + tmp_8398 + @"[88] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[88] 
" + tmp_8398 + @"[57] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[57] 
" + tmp_8398 + @"[91] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[91] 
" + tmp_8398 + @"[104] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[104] 
" + tmp_8398 + @"[124] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[124] 
" + tmp_8398 + @"[126] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[126] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[149] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[149] 
" + tmp_8398 + @"[150] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[150] 

:ROULETE_17111
if 
  18@ == 32 
jf @ROULETE_17384 
" + tmp_8398 + @"[32] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[32] 
" + tmp_8398 + @"[89] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[89] 
" + tmp_8398 + @"[57] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[57] 
" + tmp_8398 + @"[58] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[58] 
" + tmp_8398 + @"[92] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[92] 
" + tmp_8398 + @"[104] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[104] 
" + tmp_8398 + @"[124] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[124] 
" + tmp_8398 + @"[125] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[125] 
" + tmp_8398 + @"[126] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[126] 
" + tmp_8398 + @"[127] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[127] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[149] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[149] 
" + tmp_8398 + @"[150] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[150] 

:ROULETE_17384
if 
  18@ == 33 
jf @ROULETE_17612 
" + tmp_8398 + @"[33] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[33] 
" + tmp_8398 + @"[90] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[90] 
" + tmp_8398 + @"[58] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[58] 
" + tmp_8398 + @"[93] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[93] 
" + tmp_8398 + @"[104] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[104] 
" + tmp_8398 + @"[125] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[125] 
" + tmp_8398 + @"[127] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[127] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[149] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[149] 
" + tmp_8398 + @"[150] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[150] 

:ROULETE_17612
if 
  18@ == 34 
jf @ROULETE_17795 
" + tmp_8398 + @"[34] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[34] 
" + tmp_8398 + @"[91] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[91] 
" + tmp_8398 + @"[59] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[59] 
" + tmp_8398 + @"[105] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[105] 
" + tmp_8398 + @"[126] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[126] 
" + tmp_8398 + @"[128] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[128] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[150] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[150] 

:ROULETE_17795
if 
  18@ == 35 
jf @ROULETE_18008 
" + tmp_8398 + @"[35] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[35] 
" + tmp_8398 + @"[92] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[92] 
" + tmp_8398 + @"[59] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[59] 
" + tmp_8398 + @"[60] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[60] 
" + tmp_8398 + @"[105] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[105] 
" + tmp_8398 + @"[126] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[126] 
" + tmp_8398 + @"[127] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[127] 
" + tmp_8398 + @"[129] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[129] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[137] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[137] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[139] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[139] 
" + tmp_8398 + @"[150] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[150] 

:ROULETE_18008
if 
  18@ == 36 
jf @ROULETE_18191 
" + tmp_8398 + @"[36] *= 36 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[36] 
" + tmp_8398 + @"[93] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[93] 
" + tmp_8398 + @"[60] *= 18 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[60] 
" + tmp_8398 + @"[105] *= 12 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[105] 
" + tmp_8398 + @"[127] *= 9 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[127] 
" + tmp_8398 + @"[130] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[130] 
" + tmp_8398 + @"[133] *= 3 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[133] 
" + tmp_8398 + @"[136] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[136] 
" + tmp_8398 + @"[135] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[135] 
" + tmp_8398 + @"[138] *= 2 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[138] 
" + tmp_8398 + @"[150] *= 6 
0058: " + ROULETE_Cash_Won + @" += " + tmp_8398 + @"[150] 

:ROULETE_18191
return 

:ROULETE_18193
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size " + _3485 + @" " + _3487 + @" 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 
end_thread" );
            }

        }

    }

}