﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class OTBWTCH : External {

            Actor _local0 = local( 0 );

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @OTBWTCH_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:OTBWTCH_60
04ED: load_animation ""OTB"" 

:OTBWTCH_67
if 
84EE:   not animation ""OTB"" loaded 
jf @OTBWTCH_96 
wait 0 
jump @OTBWTCH_67 

:OTBWTCH_96
3@ = 1 
4@ = 0 

:OTBWTCH_110
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBWTCH_221 
if 
09C5:   unknown_actor 0@ 
jf @OTBWTCH_207 
if 
  " + _2881 + @" == 0 
jf @OTBWTCH_185 
gosub @OTBWTCH_235 
jump @OTBWTCH_200 

:OTBWTCH_185
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @OTBWTCH_1122 

:OTBWTCH_200
jump @OTBWTCH_214 

:OTBWTCH_207
gosub @OTBWTCH_1060 

:OTBWTCH_214
jump @OTBWTCH_228 

:OTBWTCH_221
gosub @OTBWTCH_1060 

:OTBWTCH_228
jump @OTBWTCH_110 

:OTBWTCH_235
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @OTBWTCH_312 jumps 1 @OTBWTCH_298 -1 @OTBWTCH_312 -1 @OTBWTCH_312 -1 @OTBWTCH_312 -1 @OTBWTCH_312 -1 @OTBWTCH_312 -1 @OTBWTCH_312 

:OTBWTCH_298
gosub @OTBWTCH_314 
jump @OTBWTCH_312 

:OTBWTCH_312
return 

:OTBWTCH_314
0871: init_jump_table 4@ total_jumps 7 default_jump 0 @OTBWTCH_1058 jumps 0 @OTBWTCH_377 1 @OTBWTCH_429 2 @OTBWTCH_524 3 @OTBWTCH_682 4 @OTBWTCH_777 5 @OTBWTCH_933 6 @OTBWTCH_1015 

:OTBWTCH_377
0605: actor 0@ perform_animation ""WTCHRACE_IN"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @OTBWTCH_1058 

:OTBWTCH_429
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBWTCH_517 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""WTCHRACE_LOOP"" IFP ""OTB"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:OTBWTCH_517
jump @OTBWTCH_1058 

:OTBWTCH_524
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBWTCH_675 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @OTBWTCH_627 
0605: actor 0@ perform_animation ""WTCHRACE_CMON"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @OTBWTCH_668 

:OTBWTCH_627
0605: actor 0@ perform_animation ""WTCHRACE_LOOP"" IFP ""OTB"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 1000 

:OTBWTCH_668
4@ += 1 

:OTBWTCH_675
jump @OTBWTCH_1058 

:OTBWTCH_682
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBWTCH_770 
0209: 2@ = random_int_in_ranges 4000 8000 
0605: actor 0@ perform_animation ""WTCHRACE_LOOP"" IFP ""OTB"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 2@ 
4@ += 1 

:OTBWTCH_770
jump @OTBWTCH_1058 

:OTBWTCH_777
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBWTCH_926 
0209: 2@ = random_int_in_ranges 0 100 
if 
  2@ > 50 
jf @OTBWTCH_879 
0605: actor 0@ perform_animation ""WTCHRACE_WIN"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @OTBWTCH_919 

:OTBWTCH_879
0605: actor 0@ perform_animation ""WTCHRACE_LOSE"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:OTBWTCH_919
4@ += 1 

:OTBWTCH_926
jump @OTBWTCH_1058 

:OTBWTCH_933
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBWTCH_1008 
0605: actor 0@ perform_animation ""WTCHRACE_OUT"" IFP ""OTB"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:OTBWTCH_1008
jump @OTBWTCH_1058 

:OTBWTCH_1015
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @OTBWTCH_1051 
gosub @OTBWTCH_1060 

:OTBWTCH_1051
jump @OTBWTCH_1058 

:OTBWTCH_1058
return 

:OTBWTCH_1060
04EF: release_animation ""OTB"" 
if 
   not Actor.Dead(0@)
jf @OTBWTCH_1118" );
                _local0.task.use_closest_map_attractor<OTBSLP>( ( double ) 100.0, NULL, ( double ) 0.0, ( double ) 0.0, ( double ) 0.0 );
AppendLine( @"
:OTBWTCH_1118
end_thread 
return 

:OTBWTCH_1122
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBWTCH_1192 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @OTBWTCH_1185 
05C5: AS_actor 0@ cower -2 ms 

:OTBWTCH_1185
jump @OTBWTCH_1199 

:OTBWTCH_1192
gosub @OTBWTCH_1060 

:OTBWTCH_1199
jump @OTBWTCH_1122 
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