using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class COPSIT : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @COPSIT_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:COPSIT_60
04ED: load_animation ""INT_OFFICE"" 

:COPSIT_74
if 
84EE:   not animation ""INT_OFFICE"" loaded 
jf @COPSIT_110 
wait 0 
jump @COPSIT_74 

:COPSIT_110
9@ = 0.0 
3@ = 0 
if 
  1@ == 0 
jf @COPSIT_166 
5@ = 0 
4@ = 1 
jump @COPSIT_180 

:COPSIT_166
5@ = -2 
4@ = 2 

:COPSIT_180
7@ = 0 
if 
   not Actor.Dead(0@)
jf @COPSIT_236 
0446: set_actor 0@ dismemberment_possible 0 
0978: copy_decision_maker 65537 to " + _9539 + @" 
060B: set_actor 0@ decision_maker_to " + _9539 + @" 
6@ = 15000 

:COPSIT_236
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @COPSIT_345 
if 
09C5:   unknown_actor 0@ 
jf @COPSIT_331 
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @COPSIT_317 
jump @COPSIT_2292 
jump @COPSIT_324 

:COPSIT_317
gosub @COPSIT_359 

:COPSIT_324
jump @COPSIT_338 

:COPSIT_331
gosub @COPSIT_2239 

:COPSIT_338
jump @COPSIT_352 

:COPSIT_345
gosub @COPSIT_2239 

:COPSIT_352
jump @COPSIT_236 

:COPSIT_359
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @COPSIT_492 jumps 1 @COPSIT_422 2 @COPSIT_436 3 @COPSIT_450 4 @COPSIT_464 5 @COPSIT_478 -1 @COPSIT_492 -1 @COPSIT_492 

:COPSIT_422
gosub @COPSIT_494 
jump @COPSIT_492 

:COPSIT_436
gosub @COPSIT_724 
jump @COPSIT_492 

:COPSIT_450
gosub @COPSIT_1843 
jump @COPSIT_492 

:COPSIT_464
gosub @COPSIT_2239 
jump @COPSIT_492 

:COPSIT_478
gosub @COPSIT_2146 
jump @COPSIT_492 

:COPSIT_492
return 

:COPSIT_494
0871: init_jump_table 5@ total_jumps 2 default_jump 0 @COPSIT_722 jumps 0 @COPSIT_557 1 @COPSIT_622 -1 @COPSIT_722 -1 @COPSIT_722 -1 @COPSIT_722 -1 @COPSIT_722 -1 @COPSIT_722 

:COPSIT_557
0812: AS_actor 0@ perform_animation ""OFF_SIT_IN"" IFP ""INT_OFFICE"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
3@ = 1 
5@ += 1 
jump @COPSIT_722 

:COPSIT_622
9@ = 0.0 
if 
   Actor.Animation(0@) == ""OFF_SIT_IN""
jf @COPSIT_680 
0613: 9@ = actor 0@ animation ""OFF_SIT_IN"" time 

:COPSIT_680
if 
  9@ == 1.0 
jf @COPSIT_715 
5@ = 0 
4@ += 1 

:COPSIT_715
jump @COPSIT_722 

:COPSIT_722
return 

:COPSIT_724
0871: init_jump_table 5@ total_jumps 5 default_jump 0 @COPSIT_1841 jumps -2 @COPSIT_787 0 @COPSIT_1023 1 @COPSIT_1259 2 @COPSIT_1520 3 @COPSIT_1598 -1 @COPSIT_1841 -1 @COPSIT_1841 

:COPSIT_787
0209: 8@ = random_int_in_ranges 0 100 
if 
  8@ > 66 
jf @COPSIT_955 
if 
  8@ > 33 
jf @COPSIT_893 
0812: AS_actor 0@ perform_animation ""OFF_SIT_TYPE_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @COPSIT_948 

:COPSIT_893
0812: AS_actor 0@ perform_animation ""OFF_SIT_BORED_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:COPSIT_948
jump @COPSIT_1009 

:COPSIT_955
0812: AS_actor 0@ perform_animation ""OFF_SIT_IDLE_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:COPSIT_1009
5@ = 1 
jump @COPSIT_1841 

:COPSIT_1023
0209: 8@ = random_int_in_ranges 0 100 
if 
  8@ > 66 
jf @COPSIT_1191 
if 
  8@ > 33 
jf @COPSIT_1129 
0812: AS_actor 0@ perform_animation ""OFF_SIT_TYPE_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @COPSIT_1184 

:COPSIT_1129
0812: AS_actor 0@ perform_animation ""OFF_SIT_BORED_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:COPSIT_1184
jump @COPSIT_1245 

:COPSIT_1191
0812: AS_actor 0@ perform_animation ""OFF_SIT_IDLE_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:COPSIT_1245
5@ += 1 
jump @COPSIT_1841 

:COPSIT_1259
Actor.StorePos(0@, 13@, 14@, 15@)
15@ -= 1.04 
04C4: store_coords_to 16@ 17@ 18@ from_actor 0@ with_offset 0.5 -0.5 0.0 
04C4: store_coords_to 19@ 20@ 21@ from_actor 0@ with_offset -0.5 -1.0 0.0 
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 1.0 -1.0 
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -365 solid 0 for_actor 0@ 
if or
   Actor.Animation(0@) == ""OFF_SIT_TYPE_LOOP""
   Actor.Animation(0@) == ""OFF_SIT_BORED_LOOP""
   Actor.Animation(0@) == ""OFF_SIT_IDLE_LOOP""
jf @COPSIT_1513 
Actor.PutAt(0@, 10@, 11@, 12@)
Actor.LockInCurrentPosition(0@) = True
TIMERB = 0 
5@ += 1 

:COPSIT_1513
jump @COPSIT_1841 

:COPSIT_1520
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @COPSIT_1565 
054E: clear_actor 0@ damage 
4@ = 5 
5@ = 0 
jump @COPSIT_1841 

:COPSIT_1565
if 
001D:   TIMERB > 6@ 
jf @COPSIT_1591 
5@ += 1 

:COPSIT_1591
jump @COPSIT_1841 

:COPSIT_1598
0209: 8@ = random_int_in_ranges 0 100 
if 
  8@ > 66 
jf @COPSIT_1766 
if 
  8@ > 33 
jf @COPSIT_1704 
0812: AS_actor 0@ perform_animation ""OFF_SIT_TYPE_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @COPSIT_1759 

:COPSIT_1704
0812: AS_actor 0@ perform_animation ""OFF_SIT_BORED_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:COPSIT_1759
jump @COPSIT_1820 

:COPSIT_1766
0812: AS_actor 0@ perform_animation ""OFF_SIT_IDLE_LOOP"" IFP ""INT_OFFICE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:COPSIT_1820
TIMERB = 0 
5@ -= 1 
jump @COPSIT_1841 

:COPSIT_1841
return 

:COPSIT_1843
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @COPSIT_2144 jumps 0 @COPSIT_1906 1 @COPSIT_1971 2 @COPSIT_2006 -1 @COPSIT_2144 -1 @COPSIT_2144 -1 @COPSIT_2144 -1 @COPSIT_2144 

:COPSIT_1906
0812: AS_actor 0@ perform_animation ""OFF_SIT_2IDLE_180"" IFP ""INT_OFFICE"" framedelta 99.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
5@ += 1 
jump @COPSIT_2144 

:COPSIT_1971
Actor.PutAt(0@, 13@, 14@, 15@)
Actor.LockInCurrentPosition(0@) = False
5@ += 1 
jump @COPSIT_2144 

:COPSIT_2006
9@ = 0.0 
if 
   Actor.Animation(0@) == ""OFF_SIT_2IDLE_180""
jf @COPSIT_2137 
0613: 9@ = actor 0@ animation ""OFF_SIT_2IDLE_180"" time 
if 
  9@ == 1.0 
jf @COPSIT_2137 
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -365 solid 1 for_actor 0@ 
5@ = 0 
4@ += 1 

:COPSIT_2137
jump @COPSIT_2144 

:COPSIT_2144
return 

:COPSIT_2146
0871: init_jump_table 5@ total_jumps 1 default_jump 0 @COPSIT_2237 jumps 0 @COPSIT_2209 -1 @COPSIT_2237 -1 @COPSIT_2237 -1 @COPSIT_2237 -1 @COPSIT_2237 -1 @COPSIT_2237 -1 @COPSIT_2237 

:COPSIT_2209
4@ = 3 
5@ = 0 
gosub @COPSIT_2292 
jump @COPSIT_2237 

:COPSIT_2237
return 

:COPSIT_2239
04EF: release_animation ""INT_OFFICE"" 
065C: release_decision_maker " + _9539 + @" 
if 
   not Actor.Dead(0@)
jf @COPSIT_2288 
Actor.LockInCurrentPosition(0@) = False
0446: set_actor 0@ dismemberment_possible 1 

:COPSIT_2288
end_thread 
return 

:COPSIT_2292
wait 0 
if and
8844:   not string " + Current_Shop_GXT_Name + @" empty 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @COPSIT_2635 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
jf @COPSIT_2628 
0871: init_jump_table 4@ total_jumps 5 default_jump 1 @COPSIT_2614 jumps 1 @COPSIT_2403 2 @COPSIT_2486 3 @COPSIT_2535 4 @COPSIT_2549 5 @COPSIT_2600 -1 @COPSIT_2628 -1 @COPSIT_2628 

:COPSIT_2403
if 
  5@ > 1 
jf @COPSIT_2435 
gosub @COPSIT_359 
jump @COPSIT_2479 

:COPSIT_2435
062E: get_actor 0@ task 1506 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @COPSIT_2479 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 
gosub @COPSIT_2239 

:COPSIT_2479
jump @COPSIT_2628 

:COPSIT_2486
if 
  5@ == 2 
jf @COPSIT_2521 
0209: 6@ = random_int_in_ranges 0 5 
6@ *= 500 

:COPSIT_2521
gosub @COPSIT_359 
jump @COPSIT_2628 

:COPSIT_2535
gosub @COPSIT_359 
jump @COPSIT_2628 

:COPSIT_2549
062E: get_actor 0@ task 1506 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @COPSIT_2593 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 
gosub @COPSIT_2239 

:COPSIT_2593
jump @COPSIT_2628 

:COPSIT_2600
gosub @COPSIT_359 
jump @COPSIT_2628 

:COPSIT_2614
gosub @COPSIT_2239 
jump @COPSIT_2628 

:COPSIT_2628
jump @COPSIT_2642 

:COPSIT_2635
gosub @COPSIT_2239 

:COPSIT_2642
jump @COPSIT_2292 
0663: printint ""PEDSTATE"" 4@ 
0663: printint ""SUBSTATESTATUS"" 5@ 
0663: printint ""TIMERB"" TIMERB 
0663: printint ""TIMERA"" TIMERA 
return 
end_thread" );
            }

        }

    }

}