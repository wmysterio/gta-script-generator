﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class SHOPPER : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @SHOPPER_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:SHOPPER_60
04ED: load_animation ""INT_SHOP"" 

:SHOPPER_72
if 
84EE:   not animation ""INT_SHOP"" loaded 
jf @SHOPPER_106 
wait 0 
jump @SHOPPER_72 

:SHOPPER_106
3@ = 1 
4@ = 0 

:SHOPPER_120
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @SHOPPER_289 
if 
09C5:   unknown_actor 0@ 
jf @SHOPPER_275 
if or
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
02E0:   actor " + PlayerActor + @" firing_weapon 
jf @SHOPPER_221 
" + _1258 + @" = 1 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @SHOPPER_1073 
jump @SHOPPER_268 

:SHOPPER_221
if 
  " + _1258 + @" == 1 
jf @SHOPPER_261 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @SHOPPER_1073 
jump @SHOPPER_268 

:SHOPPER_261
gosub @SHOPPER_303 

:SHOPPER_268
jump @SHOPPER_282 

:SHOPPER_275
gosub @SHOPPER_1057 

:SHOPPER_282
jump @SHOPPER_296 

:SHOPPER_289
gosub @SHOPPER_1057 

:SHOPPER_296
jump @SHOPPER_120 

:SHOPPER_303
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @SHOPPER_380 jumps 1 @SHOPPER_366 -1 @SHOPPER_380 -1 @SHOPPER_380 -1 @SHOPPER_380 -1 @SHOPPER_380 -1 @SHOPPER_380 -1 @SHOPPER_380 

:SHOPPER_366
gosub @SHOPPER_382 
jump @SHOPPER_380 

:SHOPPER_380
return 

:SHOPPER_382
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @SHOPPER_1055 jumps 0 @SHOPPER_445 1 @SHOPPER_527 2 @SHOPPER_674 3 @SHOPPER_835 4 @SHOPPER_1012 -1 @SHOPPER_1055 -1 @SHOPPER_1055 

:SHOPPER_445
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @SHOPPER_520 
0605: actor 0@ perform_animation ""SHOP_IN"" IFP ""INT_SHOP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:SHOPPER_520
jump @SHOPPER_1055 

:SHOPPER_527
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @SHOPPER_667 
0085: 2@ = 0@ 
if 
  2@ > 10000 
jf @SHOPPER_591 
2@ /= 10000 

:SHOPPER_591
if 
  1000 > 2@ 
jf @SHOPPER_618 
2@ += 2000 

:SHOPPER_618
0605: actor 0@ perform_animation ""SHOP_LOOP"" IFP ""INT_SHOP"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:SHOPPER_667
jump @SHOPPER_1055 

:SHOPPER_674
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @SHOPPER_828 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @SHOPPER_779 
0605: actor 0@ perform_animation ""SHOP_LOOKA"" IFP ""INT_SHOP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @SHOPPER_821 

:SHOPPER_779
0605: actor 0@ perform_animation ""SHOP_LOOKB"" IFP ""INT_SHOP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:SHOPPER_821
4@ += 1 

:SHOPPER_828
jump @SHOPPER_1055 

:SHOPPER_835
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @SHOPPER_1005 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @SHOPPER_945 
0605: actor 0@ perform_animation ""SHOP_OUT"" IFP ""INT_SHOP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @SHOPPER_1005 

:SHOPPER_945
0209: 2@ = random_int_in_ranges 3000 6000 
0605: actor 0@ perform_animation ""SHOP_LOOP"" IFP ""INT_SHOP"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ = 1 

:SHOPPER_1005
jump @SHOPPER_1055 

:SHOPPER_1012
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @SHOPPER_1048 
gosub @SHOPPER_1057 

:SHOPPER_1048
jump @SHOPPER_1055 

:SHOPPER_1055
return 

:SHOPPER_1057
04EF: release_animation ""INT_SHOP"" 
end_thread 
return 

:SHOPPER_1073
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @SHOPPER_1143 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @SHOPPER_1136 
05C5: AS_actor 0@ cower -2 ms 

:SHOPPER_1136
jump @SHOPPER_1150 

:SHOPPER_1143
gosub @SHOPPER_1057 

:SHOPPER_1150
jump @SHOPPER_1073 
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