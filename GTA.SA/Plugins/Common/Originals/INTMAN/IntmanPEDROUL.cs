using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PEDROUL : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @PEDROUL_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:PEDROUL_60
04ED: load_animation ""CASINO"" 

:PEDROUL_70
if 
84EE:   not animation ""CASINO"" loaded 
jf @PEDROUL_102 
wait 0 
jump @PEDROUL_70 

:PEDROUL_102
3@ = 1 
4@ = 0 

:PEDROUL_116
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PEDROUL_227 
if 
09C5:   unknown_actor 0@ 
jf @PEDROUL_213 
if 
  " + _9470 + @" == 0 
jf @PEDROUL_191 
gosub @PEDROUL_241 
jump @PEDROUL_206 

:PEDROUL_191
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @PEDROUL_998 

:PEDROUL_206
jump @PEDROUL_220 

:PEDROUL_213
gosub @PEDROUL_984 

:PEDROUL_220
jump @PEDROUL_234 

:PEDROUL_227
gosub @PEDROUL_984 

:PEDROUL_234
jump @PEDROUL_116 

:PEDROUL_241
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @PEDROUL_318 jumps 1 @PEDROUL_304 -1 @PEDROUL_318 -1 @PEDROUL_318 -1 @PEDROUL_318 -1 @PEDROUL_318 -1 @PEDROUL_318 -1 @PEDROUL_318 

:PEDROUL_304
gosub @PEDROUL_320 
jump @PEDROUL_318 

:PEDROUL_318
return 

:PEDROUL_320
0871: init_jump_table 4@ total_jumps 6 default_jump 0 @PEDROUL_982 jumps 0 @PEDROUL_383 1 @PEDROUL_438 2 @PEDROUL_533 3 @PEDROUL_631 4 @PEDROUL_813 5 @PEDROUL_939 -1 @PEDROUL_982 

:PEDROUL_383
0605: actor 0@ perform_animation ""ROULETTE_IN"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @PEDROUL_982 

:PEDROUL_438
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDROUL_526 
0605: actor 0@ perform_animation ""ROULETTE_BET"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 103 store_spoken_phrase_id_to 2@ 
4@ += 1 

:PEDROUL_526
jump @PEDROUL_982 

:PEDROUL_533
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDROUL_624 
0209: 2@ = random_int_in_ranges 8000 15000 
0605: actor 0@ perform_animation ""ROULETTE_LOOP"" IFP ""CASINO"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:PEDROUL_624
jump @PEDROUL_982 

:PEDROUL_631
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDROUL_806 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDROUL_746 
0605: actor 0@ perform_animation ""ROULETTE_WIN"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 100 store_spoken_phrase_id_to 2@ 
jump @PEDROUL_799 

:PEDROUL_746
0605: actor 0@ perform_animation ""ROULETTE_LOSE"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 101 store_spoken_phrase_id_to 2@ 

:PEDROUL_799
4@ += 1 

:PEDROUL_806
jump @PEDROUL_982 

:PEDROUL_813
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDROUL_932 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDROUL_883 
4@ = 1 
jump @PEDROUL_932 

:PEDROUL_883
0605: actor 0@ perform_animation ""ROULETTE_OUT"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:PEDROUL_932
jump @PEDROUL_982 

:PEDROUL_939
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDROUL_975 
gosub @PEDROUL_984 

:PEDROUL_975
jump @PEDROUL_982 

:PEDROUL_982
return 

:PEDROUL_984
04EF: release_animation ""CASINO"" 
end_thread 
return 

:PEDROUL_998
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PEDROUL_1068 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @PEDROUL_1061 
05C5: AS_actor 0@ cower -2 ms 

:PEDROUL_1061
jump @PEDROUL_1075 

:PEDROUL_1068
gosub @PEDROUL_984 

:PEDROUL_1075
jump @PEDROUL_998 
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