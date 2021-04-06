using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class DANCER : External {

            Actor _local0 = local( 0 );

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @DANCER_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:DANCER_60
04ED: load_animation ""DANCING"" 

:DANCER_71
if 
84EE:   not animation ""DANCING"" loaded 
jf @DANCER_104 
wait 0 
jump @DANCER_71 

:DANCER_104
if 
   not Actor.Dead(0@)
jf @DANCER_317 
0665: get_actor 0@ model_to 2@ 
if 
  10 > 2@ 
jf @DANCER_169 
0085: 7@ = 2@ 
7@ *= 1500 
jump @DANCER_225 

:DANCER_169
if 
  100 > 2@ 
jf @DANCER_210 
0085: 7@ = 2@ 
7@ *= 150 
jump @DANCER_225 

:DANCER_210
0085: 7@ = 2@ 
7@ *= 15 

:DANCER_225
0085: 3@ = 2@ 
3@ /= 2 
3@ *= 2 
if 
003B:   2@ == 3@ 
jf @DANCER_310 
if 
03A3:   actor 0@ male 
jf @DANCER_296 
8@ = 1 
jump @DANCER_303 

:DANCER_296
8@ = 2 

:DANCER_303
jump @DANCER_317 

:DANCER_310
8@ = 3 

:DANCER_317
3@ = 1 
4@ = 0 

:DANCER_331
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @DANCER_442 
if 
09C5:   unknown_actor 0@ 
jf @DANCER_428 
if 
  " + _9472 + @" == 0 
jf @DANCER_406 
gosub @DANCER_456 
jump @DANCER_421 

:DANCER_406
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @DANCER_1424 

:DANCER_421
jump @DANCER_435 

:DANCER_428
gosub @DANCER_1358 

:DANCER_435
jump @DANCER_449 

:DANCER_442
gosub @DANCER_1358 

:DANCER_449
jump @DANCER_331 

:DANCER_456
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @DANCER_540 jumps 1 @DANCER_519 -1 @DANCER_540 -1 @DANCER_540 -1 @DANCER_540 -1 @DANCER_540 -1 @DANCER_540 -1 @DANCER_540 

:DANCER_519
gosub @DANCER_1246 
gosub @DANCER_542 
jump @DANCER_540 

:DANCER_540
return 

:DANCER_542
0871: init_jump_table 4@ total_jumps 3 default_jump 0 @DANCER_1244 jumps 0 @DANCER_605 1 @DANCER_818 2 @DANCER_1031 -1 @DANCER_1244 -1 @DANCER_1244 -1 @DANCER_1244 -1 @DANCER_1244 

:DANCER_605
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @DANCER_811 
if 
  8@ == 1 
jf @DANCER_699 
0605: actor 0@ perform_animation ""DNCE_M_C"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 
jump @DANCER_804 

:DANCER_699
if 
  8@ == 2 
jf @DANCER_764 
0605: actor 0@ perform_animation ""DNCE_M_B"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 
jump @DANCER_804 

:DANCER_764
0605: actor 0@ perform_animation ""DNCE_M_A"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 

:DANCER_804
4@ += 1 

:DANCER_811
jump @DANCER_1244 

:DANCER_818
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @DANCER_1024 
if 
  8@ == 1 
jf @DANCER_912 
0605: actor 0@ perform_animation ""DNCE_M_D"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 
jump @DANCER_1017 

:DANCER_912
if 
  8@ == 2 
jf @DANCER_977 
0605: actor 0@ perform_animation ""DNCE_M_C"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 
jump @DANCER_1017 

:DANCER_977
0605: actor 0@ perform_animation ""DNCE_M_B"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 

:DANCER_1017
4@ += 1 

:DANCER_1024
jump @DANCER_1244 

:DANCER_1031
062E: get_actor 0@ task 1541 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @DANCER_1237 
if 
  8@ == 1 
jf @DANCER_1125 
0605: actor 0@ perform_animation ""DNCE_M_A"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 
jump @DANCER_1230 

:DANCER_1125
if 
  8@ == 2 
jf @DANCER_1190 
0605: actor 0@ perform_animation ""DNCE_M_D"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 
jump @DANCER_1230 

:DANCER_1190
0605: actor 0@ perform_animation ""DNCE_M_C"" IFP ""DANCING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time 7@ 

:DANCER_1230
4@ = 0 

:DANCER_1237
jump @DANCER_1244 

:DANCER_1244
return 

:DANCER_1246
if 
08B4:   test " + _5295 + @" bit 31 
jf @DANCER_1278 
9@ = 1 
jump @DANCER_1356 

:DANCER_1278
if 
  9@ == 1 
jf @DANCER_1356 
if 
  " + DANCE_SCORE + @" > 3000 
jf @DANCER_1339 
0947: actor 0@ speak_from_audio_table 70 store_spoken_phrase_id_to 2@ 
9@ = 0 
jump @DANCER_1356 

:DANCER_1339
0947: actor 0@ speak_from_audio_table 73 store_spoken_phrase_id_to 2@ 
9@ = 0 

:DANCER_1356
return 

:DANCER_1358
04EF: release_animation ""DANCING"" 
if 
   not Actor.Dead(0@)
jf @DANCER_1420 " );
                _local0.task.use_closest_map_attractor<DANCER>( ( double ) 100.0, NULL, ( double ) 0.0, ( double ) 0.0, ( double ) 0.0 );
                AppendLine( @"
:DANCER_1420
end_thread 
return 

:DANCER_1424
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @DANCER_1494 
062E: get_actor 0@ task 1477 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @DANCER_1487 
05C5: AS_actor 0@ cower -2 ms 

:DANCER_1487
jump @DANCER_1501 

:DANCER_1494
gosub @DANCER_1358 

:DANCER_1501
jump @DANCER_1424 
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