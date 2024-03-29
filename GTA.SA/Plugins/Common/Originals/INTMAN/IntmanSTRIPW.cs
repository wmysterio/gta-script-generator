﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class STRIPW : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @STRIPW_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:STRIPW_60
04ED: load_animation ""STRIP"" 

:STRIPW_69
if 
84EE:   not animation ""STRIP"" loaded 
jf @STRIPW_109 
wait 0 
04ED: load_animation ""STRIP"" 
jump @STRIPW_69 

:STRIPW_109
3@ = 1 
4@ = 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @STRIPW_198 
094B: " + _5311 + @" = get_active_interior_name_from_actor " + PlayerActor + @" 
if 
08F9:   " + _5311 + @" == ""STRIP2"" 
jf @STRIPW_188 
10@ = 3.0 
jump @STRIPW_198 

:STRIPW_188
10@ = 4.0 

:STRIPW_198
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @STRIPW_382 
if 
09C5:   unknown_actor 0@ 
jf @STRIPW_332 
if 
  " + _9473 + @" == 0 
jf @STRIPW_318 
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @STRIPW_304 
" + _9473 + @" = 1 
jump @STRIPW_3515 
jump @STRIPW_311 

:STRIPW_304
gosub @STRIPW_396 

:STRIPW_311
jump @STRIPW_325 

:STRIPW_318
jump @STRIPW_3515 

:STRIPW_325
jump @STRIPW_375 

:STRIPW_332
" + _9471 + @" = 1 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @STRIPW_375 
05C5: AS_actor 0@ cower -1 ms 

:STRIPW_375
jump @STRIPW_389 

:STRIPW_382
gosub @STRIPW_3497 

:STRIPW_389
jump @STRIPW_198 

:STRIPW_396
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @STRIPW_473 jumps 1 @STRIPW_459 -1 @STRIPW_473 -1 @STRIPW_473 -1 @STRIPW_473 -1 @STRIPW_473 -1 @STRIPW_473 -1 @STRIPW_473 

:STRIPW_459
gosub @STRIPW_475 
jump @STRIPW_473 

:STRIPW_473
return 

:STRIPW_475
0871: init_jump_table 4@ total_jumps 9 default_jump 0 @STRIPW_3266 jumps 0 @STRIPW_603 1 @STRIPW_772 2 @STRIPW_1133 3 @STRIPW_1470 4 @STRIPW_1835 5 @STRIPW_2056 6 @STRIPW_2642 
0872: jump_table_jumps 7 @STRIPW_2850 8 @STRIPW_3058 -1 @STRIPW_3266 -1 @STRIPW_3266 -1 @STRIPW_3266 -1 @STRIPW_3266 -1 @STRIPW_3266 -1 @STRIPW_3266 -1 @STRIPW_3266 

:STRIPW_603
if 
   Actor.Animation(0@) == ""STR_B2A""
jf @STRIPW_719 
0613: 9@ = actor 0@ animation ""STR_B2A"" time 
if 
  9@ >= 1.0 
jf @STRIPW_712 
0605: actor 0@ perform_animation ""STR_LOOP_A"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_712
jump @STRIPW_765 

:STRIPW_719
0605: actor 0@ perform_animation ""STR_LOOP_A"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_765
jump @STRIPW_3266 

:STRIPW_772
gosub @STRIPW_3268 
if 
   Actor.Animation(0@) == ""STR_LOOP_A""
jf @STRIPW_1087 
0613: 9@ = actor 0@ animation ""STR_LOOP_A"" time 
if 
  9@ >= 1.0 
jf @STRIPW_1080 
if and
03CA:   object " + _9478 + @" exists 
003C:   " + _9477 + @" == 0@ 
jf @STRIPW_922 
0605: actor 0@ perform_animation ""STR_A2B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 
jump @STRIPW_1080 

:STRIPW_922
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
if 
09DA:   cash_pickup_at 6@ 7@ 8@ 
jf @STRIPW_1041 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0605: actor 0@ perform_animation ""STR_A2B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 
jump @STRIPW_1080 

:STRIPW_1041
0605: actor 0@ perform_animation ""STR_LOOP_A"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_1080
jump @STRIPW_1126 

:STRIPW_1087
0605: actor 0@ perform_animation ""STR_LOOP_A"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_1126
jump @STRIPW_3266 

:STRIPW_1133
if 
   Actor.Animation(0@) == ""STR_A2B""
jf @STRIPW_1301 
Object.Destroy(" + _9478 + @")
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0613: 9@ = actor 0@ animation ""STR_A2B"" time 
if 
  9@ >= 1.0 
jf @STRIPW_1294 
0605: actor 0@ perform_animation ""STR_LOOP_B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_1294
jump @STRIPW_1463 

:STRIPW_1301
if 
   Actor.Animation(0@) == ""STR_C2B""
jf @STRIPW_1417 
0613: 9@ = actor 0@ animation ""STR_C2B"" time 
if 
  9@ >= 1.0 
jf @STRIPW_1410 
0605: actor 0@ perform_animation ""STR_LOOP_B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_1410
jump @STRIPW_1463 

:STRIPW_1417
0605: actor 0@ perform_animation ""STR_LOOP_B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_1463
jump @STRIPW_3266 

:STRIPW_1470
gosub @STRIPW_3268 
if 
   Actor.Animation(0@) == ""STR_LOOP_B""
jf @STRIPW_1789 
0613: 9@ = actor 0@ animation ""STR_LOOP_B"" time 
if 
  9@ >= 1.0 
jf @STRIPW_1782 
if and
03CA:   object " + _9478 + @" exists 
003C:   " + _9477 + @" == 0@ 
jf @STRIPW_1620 
0605: actor 0@ perform_animation ""STR_B2C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 
jump @STRIPW_1782 

:STRIPW_1620
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
if 
09DA:   cash_pickup_at 6@ 7@ 8@ 
jf @STRIPW_1739 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0605: actor 0@ perform_animation ""STR_B2C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 
jump @STRIPW_1782 

:STRIPW_1739
0605: actor 0@ perform_animation ""STR_B2A"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ = 0 

:STRIPW_1782
jump @STRIPW_1828 

:STRIPW_1789
0605: actor 0@ perform_animation ""STR_LOOP_B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_1828
jump @STRIPW_3266 

:STRIPW_1835
if 
   Actor.Animation(0@) == ""STR_B2C""
jf @STRIPW_2003 
Object.Destroy(" + _9478 + @")
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0613: 9@ = actor 0@ animation ""STR_B2C"" time 
if 
  9@ >= 1.0 
jf @STRIPW_1996 
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_1996
jump @STRIPW_2049 

:STRIPW_2003
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ += 1 

:STRIPW_2049
jump @STRIPW_3266 

:STRIPW_2056
gosub @STRIPW_3268 
if 
   Actor.Animation(0@) == ""STR_LOOP_C""
jf @STRIPW_2596 
0613: 9@ = actor 0@ animation ""STR_LOOP_C"" time 
if 
  9@ >= 1.0 
jf @STRIPW_2589 
if and
03CA:   object " + _9478 + @" exists 
003C:   " + _9477 + @" == 0@ 
jf @STRIPW_2431 
Actor.StorePos(0@, 6@, 7@, 8@)
9@ = Actor.Angle(" + PlayerActor + @")
9@ += 180.0 
0209: 2@ = random_int_in_ranges 35 100 
if 
  33 > 2@ 
jf @STRIPW_2281 
0804: AS_actor 0@ walk_to 6@ 7@ 8@ angle 9@ radius -1.0 animation ""STR_C3"" IFP_file ""STRIP"" 1000.0 LA 0 LX 0 LY 0 LF 1 LT -1 
4@ = 6 
jump @STRIPW_2424 

:STRIPW_2281
if 
  2@ > 66 
jf @STRIPW_2365 
0804: AS_actor 0@ walk_to 6@ 7@ 8@ angle 9@ radius -1.0 animation ""STR_C2"" IFP_file ""STRIP"" 1000.0 LA 0 LX 0 LY 0 LF 1 LT -1 
4@ = 7 
jump @STRIPW_2424 

:STRIPW_2365
0804: AS_actor 0@ walk_to 6@ 7@ 8@ angle 9@ radius -1.0 animation ""STR_C1"" IFP_file ""STRIP"" 1000.0 LA 0 LX 0 LY 0 LF 1 LT -1 
4@ = 8 

:STRIPW_2424
jump @STRIPW_2589 

:STRIPW_2431
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
if 
09DA:   cash_pickup_at 6@ 7@ 8@ 
jf @STRIPW_2546 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
jump @STRIPW_2589 

:STRIPW_2546
0605: actor 0@ perform_animation ""STR_C2B"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ = 2 

:STRIPW_2589
jump @STRIPW_2635 

:STRIPW_2596
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_2635
jump @STRIPW_3266 

:STRIPW_2642
if 
   Actor.Animation(0@) == ""STR_C3""
jf @STRIPW_2808 
Object.Destroy(" + _9478 + @")
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0613: 9@ = actor 0@ animation ""STR_C3"" time 
if 
  9@ >= 1.0 
jf @STRIPW_2801 
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ = 5 

:STRIPW_2801
jump @STRIPW_2843 

:STRIPW_2808
0605: actor 0@ perform_animation ""STR_C3"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_2843
jump @STRIPW_3266 

:STRIPW_2850
if 
   Actor.Animation(0@) == ""STR_C2""
jf @STRIPW_3016 
Object.Destroy(" + _9478 + @")
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0613: 9@ = actor 0@ animation ""STR_C2"" time 
if 
  9@ >= 1.0 
jf @STRIPW_3009 
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ = 5 

:STRIPW_3009
jump @STRIPW_3051 

:STRIPW_3016
0605: actor 0@ perform_animation ""STR_C2"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_3051
jump @STRIPW_3266 

:STRIPW_3058
if 
   Actor.Animation(0@) == ""STR_C1""
jf @STRIPW_3224 
Object.Destroy(" + _9478 + @")
04C4: store_coords_to 6@ 7@ 8@ from_actor 0@ with_offset 0.3 0.5 -0.5 
0395: clear_area 0 at 6@ 7@ 8@ radius 0.3 
0613: 9@ = actor 0@ animation ""STR_C1"" time 
if 
  9@ >= 1.0 
jf @STRIPW_3217 
0605: actor 0@ perform_animation ""STR_LOOP_C"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
4@ = 5 

:STRIPW_3217
jump @STRIPW_3259 

:STRIPW_3224
0605: actor 0@ perform_animation ""STR_C1"" IFP ""STRIP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:STRIPW_3259
jump @STRIPW_3266 

:STRIPW_3266
return 

:STRIPW_3268
if and
   Actor.Stopped(" + PlayerActor + @")
   Player.Money(" + PlayerChar + @") > 19
jf @STRIPW_3463 
if 
83CA:   not object " + _9478 + @" exists 
jf @STRIPW_3456 
if and
0105:   actor " + PlayerActor + @" near_actor 0@ radius 10@ 10@ 1.0 sphere 0 on_foot 
  " + _9475 + @" == 0 
jf @STRIPW_3424 
if 
  11@ == 0 
jf @STRIPW_3378 
" + _9474 + @" += 1 
11@ = 1 

:STRIPW_3378
if and
00E1:   player 0 pressed_key 15 
  " + _9475 + @" == 0 
jf @STRIPW_3417 
008A: " + _9477 + @" = 0@ 
" + _9475 + @" = 1 

:STRIPW_3417
jump @STRIPW_3456 

:STRIPW_3424
if 
  11@ == 1 
jf @STRIPW_3456 
" + _9474 + @" -= 1 
11@ = 0 

:STRIPW_3456
jump @STRIPW_3495 

:STRIPW_3463
if 
  11@ == 1 
jf @STRIPW_3495 
" + _9474 + @" -= 1 
11@ = 0 

:STRIPW_3495
return 

:STRIPW_3497
04EF: release_animation ""STRIP"" 
Object.Destroy(" + _9478 + @")
end_thread 
return 

:STRIPW_3515
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @STRIPW_3585 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @STRIPW_3578 
05C5: AS_actor 0@ cower -2 ms 

:STRIPW_3578
jump @STRIPW_3592 

:STRIPW_3585
gosub @STRIPW_3497 

:STRIPW_3592
jump @STRIPW_3515 
0663: printint ""PEDSTATE"" 3@ 
0663: printint ""SUBSTATESTATUS"" 4@ 
0663: printint ""LOOP_TIMER"" TIMERB 
0663: printint ""SCRIPT_TIMER"" TIMERA 
return 
end_thread" );
            }

        }

    }

}