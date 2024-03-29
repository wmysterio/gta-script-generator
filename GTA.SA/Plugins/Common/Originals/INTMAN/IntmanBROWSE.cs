﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BROWSE : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @BROWSE_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:BROWSE_60
04ED: load_animation ""COP_AMBIENT"" 

:BROWSE_75
if 
84EE:   not animation ""COP_AMBIENT"" loaded 
jf @BROWSE_112 
wait 0 
jump @BROWSE_75 

:BROWSE_112
3@ = 1 
4@ = 0 

:BROWSE_126
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BROWSE_235 
if 
09C5:   unknown_actor 0@ 
jf @BROWSE_221 
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @BROWSE_207 
jump @BROWSE_1166 
jump @BROWSE_214 

:BROWSE_207
gosub @BROWSE_249 

:BROWSE_214
jump @BROWSE_228 

:BROWSE_221
gosub @BROWSE_1147 

:BROWSE_228
jump @BROWSE_242 

:BROWSE_235
gosub @BROWSE_1147 

:BROWSE_242
jump @BROWSE_126 

:BROWSE_249
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @BROWSE_326 jumps 1 @BROWSE_312 -1 @BROWSE_326 -1 @BROWSE_326 -1 @BROWSE_326 -1 @BROWSE_326 -1 @BROWSE_326 -1 @BROWSE_326 

:BROWSE_312
gosub @BROWSE_328 
jump @BROWSE_326 

:BROWSE_326
return 

:BROWSE_328
0871: init_jump_table 4@ total_jumps 7 default_jump 0 @BROWSE_1145 jumps 0 @BROWSE_391 1 @BROWSE_452 2 @BROWSE_556 3 @BROWSE_732 4 @BROWSE_836 5 @BROWSE_1011 6 @BROWSE_1102 

:BROWSE_391
0605: actor 0@ perform_animation ""COPBROWSE_IN"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @BROWSE_1145 

:BROWSE_452
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BROWSE_549 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""COPBROWSE_LOOP"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:BROWSE_549
jump @BROWSE_1145 

:BROWSE_556
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BROWSE_725 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @BROWSE_667 
0605: actor 0@ perform_animation ""COPBROWSE_NOD"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @BROWSE_718 

:BROWSE_667
0605: actor 0@ perform_animation ""COPBROWSE_SHAKE"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 1000 

:BROWSE_718
4@ += 1 

:BROWSE_725
jump @BROWSE_1145 

:BROWSE_732
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BROWSE_829 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""COPBROWSE_LOOP"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:BROWSE_829
jump @BROWSE_1145 

:BROWSE_836
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BROWSE_1004 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @BROWSE_947 
0605: actor 0@ perform_animation ""COPBROWSE_NOD"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @BROWSE_997 

:BROWSE_947
0605: actor 0@ perform_animation ""COPBROWSE_SHAKE"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:BROWSE_997
4@ += 1 

:BROWSE_1004
jump @BROWSE_1145 

:BROWSE_1011
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BROWSE_1095 
0605: actor 0@ perform_animation ""COPBROWSE_OUT"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:BROWSE_1095
jump @BROWSE_1145 

:BROWSE_1102
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BROWSE_1138 
gosub @BROWSE_1147 

:BROWSE_1138
jump @BROWSE_1145 

:BROWSE_1145
return 

:BROWSE_1147
04EF: release_animation ""COP_AMBIENT"" 
end_thread 
return 

:BROWSE_1166
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BROWSE_1237 
062E: get_actor 0@ task 1506 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @BROWSE_1230 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:BROWSE_1230
jump @BROWSE_1244 

:BROWSE_1237
gosub @BROWSE_1147 

:BROWSE_1244
jump @BROWSE_1166 
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