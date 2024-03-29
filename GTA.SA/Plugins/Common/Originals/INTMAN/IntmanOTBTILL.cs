﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class OTBTILL : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @OTBTILL_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:OTBTILL_60
04ED: load_animation ""INT_SHOP"" 

:OTBTILL_72
if 
84EE:   not animation ""INT_SHOP"" loaded 
jf @OTBTILL_106 
wait 0 
jump @OTBTILL_72 

:OTBTILL_106
3@ = 1 
4@ = 0 
5@ = 0 
11@ = 0 

:OTBTILL_134
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBTILL_245 
if 
09C5:   unknown_actor 0@ 
jf @OTBTILL_231 
if 
  " + _2881 + @" == 0 
jf @OTBTILL_209 
gosub @OTBTILL_259 
jump @OTBTILL_224 

:OTBTILL_209
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @OTBTILL_655 

:OTBTILL_224
jump @OTBTILL_238 

:OTBTILL_231
gosub @OTBTILL_587 

:OTBTILL_238
jump @OTBTILL_252 

:OTBTILL_245
gosub @OTBTILL_587 

:OTBTILL_252
jump @OTBTILL_134 

:OTBTILL_259
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @OTBTILL_336 jumps 1 @OTBTILL_322 -1 @OTBTILL_336 -1 @OTBTILL_336 -1 @OTBTILL_336 -1 @OTBTILL_336 -1 @OTBTILL_336 -1 @OTBTILL_336 

:OTBTILL_322
gosub @OTBTILL_338 
jump @OTBTILL_336 

:OTBTILL_336
return 

:OTBTILL_338
0871: init_jump_table 4@ total_jumps 3 default_jump 0 @OTBTILL_585 jumps 0 @OTBTILL_401 1 @OTBTILL_459 2 @OTBTILL_542 -1 @OTBTILL_585 -1 @OTBTILL_585 -1 @OTBTILL_585 -1 @OTBTILL_585 

:OTBTILL_401
5@ = 1 
0605: actor 0@ perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5000 
4@ += 1 
jump @OTBTILL_585 

:OTBTILL_459
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @OTBTILL_535 
0605: actor 0@ perform_animation ""SHOP_PAY"" IFP ""INT_SHOP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 
4@ += 1 

:OTBTILL_535
jump @OTBTILL_585 

:OTBTILL_542
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @OTBTILL_578 
gosub @OTBTILL_587 

:OTBTILL_578
jump @OTBTILL_585 

:OTBTILL_585
return 

:OTBTILL_587
04EF: release_animation ""INT_SHOP"" 
if 
   not Actor.Dead(0@)
jf @OTBTILL_651 
08A0: actor 0@ in_radius 50.0 near_model #NULL with_offset 0.0 0.0 0.0 end_script_named ""OTBWTCH"" 

:OTBTILL_651
end_thread 
return 

:OTBTILL_655
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBTILL_725 
062E: get_actor 0@ task 1477 status_store_to 11@ 
if 
04A4:   11@ == 7 
jf @OTBTILL_718 
05C5: AS_actor 0@ cower -2 ms 

:OTBTILL_718
jump @OTBTILL_732 

:OTBTILL_725
gosub @OTBTILL_587 

:OTBTILL_732
jump @OTBTILL_655 
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