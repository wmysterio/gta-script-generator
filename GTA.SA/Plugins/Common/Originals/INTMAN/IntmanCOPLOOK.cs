﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class COPLOOK : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @COPLOOK_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:COPLOOK_60
04ED: load_animation ""COP_AMBIENT"" 

:COPLOOK_75
if 
84EE:   not animation ""COP_AMBIENT"" loaded 
jf @COPLOOK_112 
wait 0 
jump @COPLOOK_75 

:COPLOOK_112
3@ = 1 
4@ = 0 

:COPLOOK_126
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @COPLOOK_235 
if 
09C5:   unknown_actor 0@ 
jf @COPLOOK_221 
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @COPLOOK_207 
jump @COPLOOK_1319 
jump @COPLOOK_214 

:COPLOOK_207
gosub @COPLOOK_249 

:COPLOOK_214
jump @COPLOOK_228 

:COPLOOK_221
gosub @COPLOOK_1300 

:COPLOOK_228
jump @COPLOOK_242 

:COPLOOK_235
gosub @COPLOOK_1300 

:COPLOOK_242
jump @COPLOOK_126 

:COPLOOK_249
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @COPLOOK_326 jumps 1 @COPLOOK_312 -1 @COPLOOK_326 -1 @COPLOOK_326 -1 @COPLOOK_326 -1 @COPLOOK_326 -1 @COPLOOK_326 -1 @COPLOOK_326 

:COPLOOK_312
gosub @COPLOOK_328 
jump @COPLOOK_326 

:COPLOOK_326
return 

:COPLOOK_328
0871: init_jump_table 4@ total_jumps 8 default_jump 0 @COPLOOK_1298 jumps 0 @COPLOOK_456 1 @COPLOOK_515 2 @COPLOOK_617 3 @COPLOOK_789 4 @COPLOOK_891 5 @COPLOOK_1064 6 @COPLOOK_1166 
0872: jump_table_jumps 7 @COPLOOK_1255 -1 @COPLOOK_1298 -1 @COPLOOK_1298 -1 @COPLOOK_1298 -1 @COPLOOK_1298 -1 @COPLOOK_1298 -1 @COPLOOK_1298 -1 @COPLOOK_1298 -1 @COPLOOK_1298 

:COPLOOK_456
0605: actor 0@ perform_animation ""COPLOOK_IN"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @COPLOOK_1298 

:COPLOOK_515
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_610 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""COPLOOK_LOOP"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:COPLOOK_610
jump @COPLOOK_1298 

:COPLOOK_617
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_782 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @COPLOOK_726 
0605: actor 0@ perform_animation ""COPLOOK_NOD"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @COPLOOK_775 

:COPLOOK_726
0605: actor 0@ perform_animation ""COPLOOK_SHAKE"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 1000 

:COPLOOK_775
4@ += 1 

:COPLOOK_782
jump @COPLOOK_1298 

:COPLOOK_789
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_884 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""COPLOOK_LOOP"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:COPLOOK_884
jump @COPLOOK_1298 

:COPLOOK_891
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_1057 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @COPLOOK_1002 
0605: actor 0@ perform_animation ""COPLOOK_THINK"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @COPLOOK_1050 

:COPLOOK_1002
0605: actor 0@ perform_animation ""COPLOOK_WATCH"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:COPLOOK_1050
4@ += 1 

:COPLOOK_1057
jump @COPLOOK_1298 

:COPLOOK_1064
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_1159 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""COPLOOK_LOOP"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:COPLOOK_1159
jump @COPLOOK_1298 

:COPLOOK_1166
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_1248 
0605: actor 0@ perform_animation ""COPLOOK_OUT"" IFP ""COP_AMBIENT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:COPLOOK_1248
jump @COPLOOK_1298 

:COPLOOK_1255
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @COPLOOK_1291 
gosub @COPLOOK_1300 

:COPLOOK_1291
jump @COPLOOK_1298 

:COPLOOK_1298
return 

:COPLOOK_1300
04EF: release_animation ""COP_AMBIENT"" 
end_thread 
return 

:COPLOOK_1319
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @COPLOOK_1390 
062E: get_actor 0@ task 1506 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @COPLOOK_1383 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:COPLOOK_1383
jump @COPLOOK_1397 

:COPLOOK_1390
gosub @COPLOOK_1300 

:COPLOOK_1397
jump @COPLOOK_1319 
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