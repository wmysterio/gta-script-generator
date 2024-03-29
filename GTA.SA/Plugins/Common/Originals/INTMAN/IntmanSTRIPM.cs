﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class STRIPM : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @STRIPM_60 
0@ = Actor.Create(CivMale, #NULL, 0.0, 0.0, 0.0)

:STRIPM_60
04ED: load_animation ""STRIP"" 

:STRIPM_69
if 
84EE:   not animation ""STRIP"" loaded 
jf @STRIPM_100 
wait 0 
jump @STRIPM_69 

:STRIPM_100
3@ = 1 
4@ = 0 

:STRIPM_114
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @STRIPM_298 
if 
09C5:   unknown_actor 0@ 
jf @STRIPM_284 
if 
  " + _9473 + @" == 0 
jf @STRIPM_262 
Actor.StorePos(0@, 7@, 8@, 9@)
091C: get_actor_in_sphere 7@ 8@ 9@ radius 15.0 model #NULL external_script_named ""STRIPW"" handle_as 10@ 
if 
   not Actor.Dead(10@)
jf @STRIPM_248 
gosub @STRIPM_312 
jump @STRIPM_255 

:STRIPM_248
gosub @STRIPM_1075 

:STRIPM_255
jump @STRIPM_277 

:STRIPM_262
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @STRIPM_1088 

:STRIPM_277
jump @STRIPM_291 

:STRIPM_284
gosub @STRIPM_1075 

:STRIPM_291
jump @STRIPM_305 

:STRIPM_298
gosub @STRIPM_1075 

:STRIPM_305
jump @STRIPM_114 

:STRIPM_312
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @STRIPM_389 jumps 1 @STRIPM_375 -1 @STRIPM_389 -1 @STRIPM_389 -1 @STRIPM_389 -1 @STRIPM_389 -1 @STRIPM_389 -1 @STRIPM_389 

:STRIPM_375
gosub @STRIPM_391 
jump @STRIPM_389 

:STRIPM_389
return 

:STRIPM_391
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @STRIPM_1073 jumps 0 @STRIPM_454 1 @STRIPM_597 2 @STRIPM_679 3 @STRIPM_771 4 @STRIPM_1030 -1 @STRIPM_1073 -1 @STRIPM_1073 

:STRIPM_454
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @STRIPM_590 
0085: 2@ = 0@ 
if 
  2@ > 10000 
jf @STRIPM_518 
2@ /= 10000 

:STRIPM_518
if 
  1000 > 2@ 
jf @STRIPM_545 
2@ += 2000 

:STRIPM_545
0605: actor 0@ perform_animation ""PUN_LOOP"" IFP ""STRIP"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:STRIPM_590
jump @STRIPM_1073 

:STRIPM_597
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @STRIPM_672 
0605: actor 0@ perform_animation ""PUN_HOLLER"" IFP ""STRIP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:STRIPM_672
jump @STRIPM_1073 

:STRIPM_679
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @STRIPM_764 
0209: 2@ = random_int_in_ranges 2000 5000 
0605: actor 0@ perform_animation ""PUN_LOOP"" IFP ""STRIP"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:STRIPM_764
jump @STRIPM_1073 

:STRIPM_771
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @STRIPM_1023 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ >= 50 
jf @STRIPM_977 
0605: actor 0@ perform_animation ""PUN_CASH"" IFP ""STRIP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
Actor.StorePos(0@, 7@, 8@, 9@)
091C: get_actor_in_sphere 7@ 8@ 9@ radius 15.0 model #NULL external_script_named ""STRIPW"" handle_as 10@ 
if 
   not Actor.Dead(10@)
jf @STRIPM_970 
04C4: store_coords_to 7@ 8@ 9@ from_actor 10@ with_offset 0.3 0.5 -0.5 
02E1: 11@ = create_cash_pickup 100 at 7@ 8@ 9@ permanence_flag 0 

:STRIPM_970
jump @STRIPM_1016 

:STRIPM_977
0605: actor 0@ perform_animation ""PUN_HOLLER"" IFP ""STRIP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:STRIPM_1016
4@ += 1 

:STRIPM_1023
jump @STRIPM_1073 

:STRIPM_1030
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @STRIPM_1066 
4@ = 0 

:STRIPM_1066
jump @STRIPM_1073 

:STRIPM_1073
return 

:STRIPM_1075
04EF: release_animation ""STRIP"" 
end_thread 
return 

:STRIPM_1088
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @STRIPM_1158 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @STRIPM_1151 
05C5: AS_actor 0@ cower -2 ms 

:STRIPM_1151
jump @STRIPM_1165 

:STRIPM_1158
gosub @STRIPM_1075 

:STRIPM_1165
jump @STRIPM_1088 
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