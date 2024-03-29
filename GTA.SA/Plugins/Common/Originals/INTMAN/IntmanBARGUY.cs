﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BARGUY : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @BARGUY_60 
0@ = Actor.Create(CivMale, #NULL, 0.0, 0.0, 0.0)

:BARGUY_60
04ED: load_animation ""BAR"" 

:BARGUY_67
if 
84EE:   not animation ""BAR"" loaded 
jf @BARGUY_96 
wait 0 
jump @BARGUY_67 

:BARGUY_96
3@ = 1 
4@ = 0 
5@ = 0 
11@ = 0 

:BARGUY_124
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BARGUY_272 
if 
09C5:   unknown_actor 0@ 
jf @BARGUY_258 
if 
  " + _9470 + @" == 0 
jf @BARGUY_244 
if 
851A:   not actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @BARGUY_223 
gosub @BARGUY_286 
jump @BARGUY_237 

:BARGUY_223
" + _9470 + @" = 1 
jump @BARGUY_1067 

:BARGUY_237
jump @BARGUY_251 

:BARGUY_244
jump @BARGUY_1067 

:BARGUY_251
jump @BARGUY_265 

:BARGUY_258
gosub @BARGUY_1035 

:BARGUY_265
jump @BARGUY_279 

:BARGUY_272
gosub @BARGUY_1035 

:BARGUY_279
jump @BARGUY_124 

:BARGUY_286
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @BARGUY_363 jumps 1 @BARGUY_349 -1 @BARGUY_363 -1 @BARGUY_363 -1 @BARGUY_363 -1 @BARGUY_363 -1 @BARGUY_363 -1 @BARGUY_363 

:BARGUY_349
gosub @BARGUY_365 
jump @BARGUY_363 

:BARGUY_363
return 

:BARGUY_365
0871: init_jump_table 4@ total_jumps 7 default_jump 0 @BARGUY_1033 jumps 0 @BARGUY_428 1 @BARGUY_488 2 @BARGUY_577 3 @BARGUY_674 4 @BARGUY_754 5 @BARGUY_826 6 @BARGUY_947 

:BARGUY_428
062E: get_actor 0@ task 1481 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BARGUY_481 
05C9: AS_actor 0@ on_guard -2 ms 
0947: actor 0@ speak_from_audio_table 21 store_spoken_phrase_id_to 10@ 
4@ += 1 

:BARGUY_481
jump @BARGUY_1033 

:BARGUY_488
10@ = Actor.Health(0@)
if 
  10@ == 99 
jf @BARGUY_570 
Actor.Health(0@) = 100
0605: actor 0@ perform_animation ""BARCUSTOM_ORDER"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 
4@ += 1 

:BARGUY_570
jump @BARGUY_1033 

:BARGUY_577
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BARGUY_667 
0605: actor 0@ perform_animation ""BARCUSTOM_LOOP"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 600000 
0947: actor 0@ speak_from_audio_table 21 store_spoken_phrase_id_to 10@ 
4@ += 1 

:BARGUY_667
jump @BARGUY_1033 

:BARGUY_674
10@ = Actor.Health(0@)
if 
  10@ == 99 
jf @BARGUY_747 
0605: actor 0@ perform_animation ""BARCUSTOM_GET"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 
4@ += 1 

:BARGUY_747
jump @BARGUY_1033 

:BARGUY_754
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BARGUY_819 
04C4: store_coords_to 7@ 8@ 9@ from_actor 0@ with_offset 0.0 0.1 1.0 
4@ += 1 

:BARGUY_819
jump @BARGUY_1033 

:BARGUY_826
if 
03A3:   actor 0@ male 
jf @BARGUY_891 
0605: actor 0@ perform_animation ""DNK_STNDM_LOOP"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 15000 
jump @BARGUY_933 

:BARGUY_891
0605: actor 0@ perform_animation ""DNK_STNDF_LOOP"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 15000 

:BARGUY_933
4@ += 1 
jump @BARGUY_1033 

:BARGUY_947
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BARGUY_1026 
Actor.Health(0@) = 100
if 
08F9:   " + Active_Interior_Name + @" == ""BAR1"" 
jf @BARGUY_1019 
4@ = 0 
jump @BARGUY_1026 

:BARGUY_1019
gosub @BARGUY_1035 

:BARGUY_1026
jump @BARGUY_1033 

:BARGUY_1033
return 

:BARGUY_1035
04EF: release_animation ""BAR"" 
if 
   not Actor.Dead(0@)
jf @BARGUY_1063 
0792: disembark_instantly_actor 0@ 

:BARGUY_1063
end_thread 
return 

:BARGUY_1067
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BARGUY_1137 
062E: get_actor 0@ task 1477 status_store_to 11@ 
if 
04A4:   11@ == 7 
jf @BARGUY_1130 
05C5: AS_actor 0@ cower -2 ms 

:BARGUY_1130
jump @BARGUY_1144 

:BARGUY_1137
gosub @BARGUY_1035 

:BARGUY_1144
jump @BARGUY_1067 
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