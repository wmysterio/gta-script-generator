﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class TICKET : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @TICKET_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:TICKET_60
04ED: load_animation ""CASINO"" 

:TICKET_70
if 
84EE:   not animation ""CASINO"" loaded 
jf @TICKET_102 
wait 0 
jump @TICKET_70 

:TICKET_102
3@ = 1 
4@ = 0 

:TICKET_116
wait 0 
if 
   not Actor.Dead(0@)
jf @TICKET_180 
if 
09C5:   unknown_actor 0@ 
jf @TICKET_166 
gosub @TICKET_194 
jump @TICKET_173 

:TICKET_166
gosub @TICKET_875 

:TICKET_173
jump @TICKET_187 

:TICKET_180
gosub @TICKET_875 

:TICKET_187
jump @TICKET_116 

:TICKET_194
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @TICKET_271 jumps 1 @TICKET_257 -1 @TICKET_271 -1 @TICKET_271 -1 @TICKET_271 -1 @TICKET_271 -1 @TICKET_271 -1 @TICKET_271 

:TICKET_257
gosub @TICKET_273 
jump @TICKET_271 

:TICKET_271
return 

:TICKET_273
0871: init_jump_table 4@ total_jumps 7 default_jump 0 @TICKET_873 jumps 0 @TICKET_336 1 @TICKET_387 2 @TICKET_472 3 @TICKET_566 4 @TICKET_650 5 @TICKET_736 6 @TICKET_830 

:TICKET_336
0605: actor 0@ perform_animation ""SLOT_IN"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @TICKET_873 

:TICKET_387
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @TICKET_465 
0605: actor 0@ perform_animation ""SLOT_BET_01"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time 2@ 
4@ += 1 

:TICKET_465
jump @TICKET_873 

:TICKET_472
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @TICKET_559 
0209: 2@ = random_int_in_ranges 5000 10000 
0605: actor 0@ perform_animation ""SLOT_WAIT"" IFP ""CASINO"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:TICKET_559
jump @TICKET_873 

:TICKET_566
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @TICKET_643 
0605: actor 0@ perform_animation ""SLOT_BET_02"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:TICKET_643
jump @TICKET_873 

:TICKET_650
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @TICKET_729 
0605: actor 0@ perform_animation ""SLOT_LOSE_OUT"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:TICKET_729
jump @TICKET_873 

:TICKET_736
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @TICKET_823 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""SLOT_WAIT"" IFP ""CASINO"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:TICKET_823
jump @TICKET_873 

:TICKET_830
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @TICKET_866 
gosub @TICKET_875 

:TICKET_866
jump @TICKET_873 

:TICKET_873
return 

:TICKET_875
04EF: release_animation ""CASINO"" 
end_thread 
return 
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