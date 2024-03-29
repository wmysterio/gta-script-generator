﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PEDSLOT : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @PEDSLOT_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:PEDSLOT_60
04ED: load_animation ""CASINO"" 

:PEDSLOT_70
if 
84EE:   not animation ""CASINO"" loaded 
jf @PEDSLOT_102 
wait 0 
jump @PEDSLOT_70 

:PEDSLOT_102
3@ = 1 
4@ = 0 

:PEDSLOT_116
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PEDSLOT_227 
if 
09C5:   unknown_actor 0@ 
jf @PEDSLOT_213 
if 
  " + _9470 + @" == 0 
jf @PEDSLOT_191 
gosub @PEDSLOT_241 
jump @PEDSLOT_206 

:PEDSLOT_191
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @PEDSLOT_1042 

:PEDSLOT_206
jump @PEDSLOT_220 

:PEDSLOT_213
gosub @PEDSLOT_1028 

:PEDSLOT_220
jump @PEDSLOT_234 

:PEDSLOT_227
gosub @PEDSLOT_1028 

:PEDSLOT_234
jump @PEDSLOT_116 

:PEDSLOT_241
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @PEDSLOT_318 jumps 1 @PEDSLOT_304 -1 @PEDSLOT_318 -1 @PEDSLOT_318 -1 @PEDSLOT_318 -1 @PEDSLOT_318 -1 @PEDSLOT_318 -1 @PEDSLOT_318 

:PEDSLOT_304
gosub @PEDSLOT_320 
jump @PEDSLOT_318 

:PEDSLOT_318
return 

:PEDSLOT_320
0871: init_jump_table 4@ total_jumps 6 default_jump 0 @PEDSLOT_1026 jumps 0 @PEDSLOT_383 1 @PEDSLOT_434 2 @PEDSLOT_519 3 @PEDSLOT_613 4 @PEDSLOT_770 5 @PEDSLOT_942 -1 @PEDSLOT_1026 

:PEDSLOT_383
0605: actor 0@ perform_animation ""SLOT_IN"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @PEDSLOT_1026 

:PEDSLOT_434
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDSLOT_512 
0605: actor 0@ perform_animation ""SLOT_BET_01"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time 2@ 
4@ += 1 

:PEDSLOT_512
jump @PEDSLOT_1026 

:PEDSLOT_519
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDSLOT_606 
0209: 2@ = random_int_in_ranges 1500 5000 
0605: actor 0@ perform_animation ""SLOT_WAIT"" IFP ""CASINO"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:PEDSLOT_606
jump @PEDSLOT_1026 

:PEDSLOT_613
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDSLOT_763 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDSLOT_717 
0605: actor 0@ perform_animation ""SLOT_BET_02"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @PEDSLOT_756 

:PEDSLOT_717
0605: actor 0@ perform_animation ""SLOT_WAIT"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:PEDSLOT_756
4@ += 1 

:PEDSLOT_763
jump @PEDSLOT_1026 

:PEDSLOT_770
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDSLOT_935 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDSLOT_885 
0605: actor 0@ perform_animation ""SLOT_WIN_OUT"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor 0@ speak_from_audio_table 104 store_spoken_phrase_id_to 2@ 
jump @PEDSLOT_928 

:PEDSLOT_885
0605: actor 0@ perform_animation ""SLOT_LOSE_OUT"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:PEDSLOT_928
4@ += 1 

:PEDSLOT_935
jump @PEDSLOT_1026 

:PEDSLOT_942
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @PEDSLOT_1019 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @PEDSLOT_1012 
4@ = 0 
jump @PEDSLOT_1019 

:PEDSLOT_1012
gosub @PEDSLOT_1028 

:PEDSLOT_1019
jump @PEDSLOT_1026 

:PEDSLOT_1026
return 

:PEDSLOT_1028
04EF: release_animation ""CASINO"" 
end_thread 
return 

:PEDSLOT_1042
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PEDSLOT_1112 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @PEDSLOT_1105 
05C5: AS_actor 0@ cower -2 ms 

:PEDSLOT_1105
jump @PEDSLOT_1119 

:PEDSLOT_1112
gosub @PEDSLOT_1028 

:PEDSLOT_1119
jump @PEDSLOT_1042 
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