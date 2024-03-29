﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class OTBSLP : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @OTBSLP_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:OTBSLP_60
04ED: load_animation ""OTB"" 

:OTBSLP_67
if 
84EE:   not animation ""OTB"" loaded 
jf @OTBSLP_96 
wait 0 
jump @OTBSLP_67 

:OTBSLP_96
3@ = 1 
4@ = 0 

:OTBSLP_110
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBSLP_221 
if 
09C5:   unknown_actor 0@ 
jf @OTBSLP_207 
if 
  " + _2881 + @" == 0 
jf @OTBSLP_185 
gosub @OTBSLP_235 
jump @OTBSLP_200 

:OTBSLP_185
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @OTBSLP_902 

:OTBSLP_200
jump @OTBSLP_214 

:OTBSLP_207
gosub @OTBSLP_891 

:OTBSLP_214
jump @OTBSLP_228 

:OTBSLP_221
gosub @OTBSLP_891 

:OTBSLP_228
jump @OTBSLP_110 

:OTBSLP_235
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @OTBSLP_312 jumps 1 @OTBSLP_298 -1 @OTBSLP_312 -1 @OTBSLP_312 -1 @OTBSLP_312 -1 @OTBSLP_312 -1 @OTBSLP_312 -1 @OTBSLP_312 

:OTBSLP_298
gosub @OTBSLP_314 
jump @OTBSLP_312 

:OTBSLP_312
return 

:OTBSLP_314
0871: init_jump_table 4@ total_jumps 6 default_jump 0 @OTBSLP_889 jumps 0 @OTBSLP_377 1 @OTBSLP_427 2 @OTBSLP_520 3 @OTBSLP_673 4 @OTBSLP_766 5 @OTBSLP_846 -1 @OTBSLP_889 

:OTBSLP_377
0605: actor 0@ perform_animation ""BETSLP_IN"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @OTBSLP_889 

:OTBSLP_427
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBSLP_513 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""BETSLP_LOOP"" IFP ""OTB"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:OTBSLP_513
jump @OTBSLP_889 

:OTBSLP_520
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBSLP_666 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @OTBSLP_622 
0605: actor 0@ perform_animation ""BETSLP_LKABT"" IFP ""OTB"" framedelta 16.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @OTBSLP_659 

:OTBSLP_622
0605: actor 0@ perform_animation ""BETSLP_TNK"" IFP ""OTB"" framedelta 16.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:OTBSLP_659
4@ += 1 

:OTBSLP_666
jump @OTBSLP_889 

:OTBSLP_673
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBSLP_759 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""BETSLP_LOOP"" IFP ""OTB"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:OTBSLP_759
jump @OTBSLP_889 

:OTBSLP_766
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBSLP_839 
0605: actor 0@ perform_animation ""BETSLP_OUT"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:OTBSLP_839
jump @OTBSLP_889 

:OTBSLP_846
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBSLP_882 
gosub @OTBSLP_891 

:OTBSLP_882
jump @OTBSLP_889 

:OTBSLP_889
return 

:OTBSLP_891
04EF: release_animation ""OTB"" 
end_thread 
return 

:OTBSLP_902
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBSLP_972 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @OTBSLP_965 
05C5: AS_actor 0@ cower -2 ms 

:OTBSLP_965
jump @OTBSLP_979 

:OTBSLP_972
gosub @OTBSLP_891 

:OTBSLP_979
jump @OTBSLP_902 
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