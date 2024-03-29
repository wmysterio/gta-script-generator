﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PEDCARD : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @PEDCARD_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:PEDCARD_60
04ED: load_animation ""CASINO"" 

:PEDCARD_70
if 
84EE:   not animation ""CASINO"" loaded 
jf @PEDCARD_102 
wait 0 
jump @PEDCARD_70 

:PEDCARD_102
3@ = 1 
4@ = 0 

:PEDCARD_116
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PEDCARD_227 
if 
09C5:   unknown_actor 0@ 
jf @PEDCARD_213 
if 
  " + _9470 + @" == 0 
jf @PEDCARD_191 
gosub @PEDCARD_241 
jump @PEDCARD_206 

:PEDCARD_191
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @PEDCARD_1335 

:PEDCARD_206
jump @PEDCARD_220 

:PEDCARD_213
gosub @PEDCARD_1321 

:PEDCARD_220
jump @PEDCARD_234 

:PEDCARD_227
gosub @PEDCARD_1321 

:PEDCARD_234
jump @PEDCARD_116 

:PEDCARD_241
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @PEDCARD_318 jumps 1 @PEDCARD_304 -1 @PEDCARD_318 -1 @PEDCARD_318 -1 @PEDCARD_318 -1 @PEDCARD_318 -1 @PEDCARD_318 -1 @PEDCARD_318 

:PEDCARD_304
gosub @PEDCARD_320 
jump @PEDCARD_318 

:PEDCARD_318
return 

:PEDCARD_320
0871: init_jump_table 4@ total_jumps 8 default_jump 0 @PEDCARD_1319 jumps 0 @PEDCARD_448 1 @PEDCARD_510 2 @PEDCARD_596 3 @PEDCARD_691 4 @PEDCARD_872 5 @PEDCARD_977 6 @PEDCARD_1153 
0872: jump_table_jumps 7 @PEDCARD_1276 -1 @PEDCARD_1319 -1 @PEDCARD_1319 -1 @PEDCARD_1319 -1 @PEDCARD_1319 -1 @PEDCARD_1319 -1 @PEDCARD_1319 -1 @PEDCARD_1319 -1 @PEDCARD_1319 

:PEDCARD_448
0605: actor 0@ perform_animation ""CARDS_IN"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 93 store_spoken_phrase_id_to 2@ 
4@ += 1 
jump @PEDCARD_1319 

:PEDCARD_510
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_589 
0605: actor 0@ perform_animation ""CARDS_PICK_01"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:PEDCARD_589
jump @PEDCARD_1319 

:PEDCARD_596
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_684 
0209: 2@ = random_int_in_ranges 8000 15000 
0605: actor 0@ perform_animation ""CARDS_LOOP"" IFP ""CASINO"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:PEDCARD_684
jump @PEDCARD_1319 

:PEDCARD_691
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_865 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDCARD_805 
0605: actor 0@ perform_animation ""CARDS_RAISE"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 98 store_spoken_phrase_id_to 2@ 
jump @PEDCARD_858 

:PEDCARD_805
0605: actor 0@ perform_animation ""CARDS_PICK_02"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 93 store_spoken_phrase_id_to 2@ 

:PEDCARD_858
4@ += 1 

:PEDCARD_865
jump @PEDCARD_1319 

:PEDCARD_872
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_970 
0209: 2@ = random_int_in_ranges 1500 5000 
0605: actor 0@ perform_animation ""CARDS_LOOP"" IFP ""CASINO"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
0947: actor 0@ speak_from_audio_table 95 store_spoken_phrase_id_to 2@ 
4@ += 1 

:PEDCARD_970
jump @PEDCARD_1319 

:PEDCARD_977
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_1146 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDCARD_1089 
0605: actor 0@ perform_animation ""CARDS_WIN"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 96 store_spoken_phrase_id_to 2@ 
jump @PEDCARD_1139 

:PEDCARD_1089
0605: actor 0@ perform_animation ""CARDS_LOSE"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 94 store_spoken_phrase_id_to 2@ 

:PEDCARD_1139
4@ += 1 

:PEDCARD_1146
jump @PEDCARD_1319 

:PEDCARD_1153
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_1269 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDCARD_1223 
4@ = 1 
jump @PEDCARD_1269 

:PEDCARD_1223
0605: actor 0@ perform_animation ""CARDS_OUT"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:PEDCARD_1269
jump @PEDCARD_1319 

:PEDCARD_1276
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDCARD_1312 
gosub @PEDCARD_1321 

:PEDCARD_1312
jump @PEDCARD_1319 

:PEDCARD_1319
return 

:PEDCARD_1321
04EF: release_animation ""CASINO"" 
end_thread 
return 

:PEDCARD_1335
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PEDCARD_1405 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @PEDCARD_1398 
05C5: AS_actor 0@ cower -2 ms 

:PEDCARD_1398
jump @PEDCARD_1412 

:PEDCARD_1405
gosub @PEDCARD_1321 

:PEDCARD_1412
jump @PEDCARD_1335 
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