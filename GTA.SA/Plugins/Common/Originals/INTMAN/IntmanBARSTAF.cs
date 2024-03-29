﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BARSTAF : External {

            Actor _local8 = local( 8 );

            Float _local14 = local( 14 ),
                  _local15 = local( 15 ),
                  _local16 = local( 16 ),
                  _local6 = local( 6 );

            public override void START( LabelJump label ) {
                AppendLine( @"8@ = 0 
if 
  8@ == 1 
jf @BARSTAF_212 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)
8@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)
061D: create_AS_origin_at 0.0 0.0 0.0 Z_angle 0.0 unknown_angle 0.0 AS_pack -1 handle_as 1@ 
061D: create_AS_origin_at 0.0 0.0 0.0 Z_angle 0.0 unknown_angle 0.0 AS_pack -1 handle_as 2@ 
061D: create_AS_origin_at 0.0 0.0 0.0 Z_angle 0.0 unknown_angle 0.0 AS_pack -1 handle_as 3@ 
061D: create_AS_origin_at 0.0 0.0 0.0 Z_angle 0.0 unknown_angle 0.0 AS_pack -1 handle_as 4@ 

:BARSTAF_212
if 
   not Actor.Dead(0@)
jf @BARSTAF_236 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_B + @" 

:BARSTAF_236
04ED: load_animation ""BAR"" 

:BARSTAF_243
if 
84EE:   not animation ""BAR"" loaded 
jf @BARSTAF_279 
04ED: load_animation ""BAR"" 
wait 0 
jump @BARSTAF_243 

:BARSTAF_279
9@ = 1 
10@ = 0 
12@ = 0 
if 
  0.0 >= 6@ 
jf @BARSTAF_331 
6@ = 6.0 

:BARSTAF_331
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BARSTAF_540 
if 
  9@ == 2 
jf @BARSTAF_480 
if 
   not Actor.Dead(8@)
jf @BARSTAF_452 
if or
  " + _9470 + @" == 1 
  " + _9472 + @" == 1 
  " + _9473 + @" == 1 
jf @BARSTAF_438 
jump @BARSTAF_2200 
jump @BARSTAF_445 

:BARSTAF_438
gosub @BARSTAF_554 

:BARSTAF_445
jump @BARSTAF_473 

:BARSTAF_452
9@ = 1 
10@ = 0 
gosub @BARSTAF_554 

:BARSTAF_473
jump @BARSTAF_533 

:BARSTAF_480
if or
  " + _9470 + @" == 1 
  " + _9472 + @" == 1 
  " + _9473 + @" == 1 
jf @BARSTAF_526 
jump @BARSTAF_2200 
jump @BARSTAF_533 

:BARSTAF_526
gosub @BARSTAF_554 

:BARSTAF_533
jump @BARSTAF_547 

:BARSTAF_540
gosub @BARSTAF_2287 

:BARSTAF_547
jump @BARSTAF_331 

:BARSTAF_554
0871: init_jump_table 9@ total_jumps 3 default_jump 0 @BARSTAF_659 jumps 1 @BARSTAF_617 2 @BARSTAF_631 3 @BARSTAF_645 -1 @BARSTAF_659 -1 @BARSTAF_659 -1 @BARSTAF_659 -1 @BARSTAF_659 

:BARSTAF_617
gosub @BARSTAF_661 
jump @BARSTAF_659 

:BARSTAF_631
gosub @BARSTAF_1390 
jump @BARSTAF_659 

:BARSTAF_645
gosub @BARSTAF_2085 
jump @BARSTAF_659 

:BARSTAF_659
return 

:BARSTAF_661
0871: init_jump_table 10@ total_jumps 4 default_jump 0 @BARSTAF_1388 jumps 0 @BARSTAF_724 1 @BARSTAF_767 2 @BARSTAF_974 3 @BARSTAF_1181 -1 @BARSTAF_1388 -1 @BARSTAF_1388 -1 @BARSTAF_1388 

:BARSTAF_724
062E: get_actor 0@ task 1868 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_760 
10@ += 1 

:BARSTAF_760
jump @BARSTAF_1388 

:BARSTAF_767
Actor.StorePos(0@, 14@, 15@, 16@)" );
                _local8.get_of_closest_map_attractor<BARGUY>( _local14, _local15, _local16, _local6, NULL );
AppendLine( @"if 
  8@ > -1 
jf @BARSTAF_923 
13@ = Actor.Health(8@)
if 
  13@ == 99 
jf @BARSTAF_866 
8@ = -1 
jump @BARSTAF_923 

:BARSTAF_866
062E: get_actor 8@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_916 
9@ += 1 
10@ = 0 
jump @BARSTAF_923 

:BARSTAF_916
8@ = -1 

:BARSTAF_923
062E: get_actor 0@ task 1868 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_967 
074C: AS_actor 0@ goto_AS_origin 2@ 
10@ += 1 

:BARSTAF_967
jump @BARSTAF_1388 

:BARSTAF_974
Actor.StorePos(0@, 14@, 15@, 16@)" );
                _local8.get_of_closest_map_attractor<BARGUY>( _local14, _local15, _local16, _local6, NULL );
AppendLine( @"if 
  8@ > -1 
jf @BARSTAF_1130 
13@ = Actor.Health(8@)
if 
  13@ == 99 
jf @BARSTAF_1073 
8@ = -1 
jump @BARSTAF_1130 

:BARSTAF_1073
062E: get_actor 8@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1123 
9@ += 1 
10@ = 0 
jump @BARSTAF_1130 

:BARSTAF_1123
8@ = -1 

:BARSTAF_1130
062E: get_actor 0@ task 1868 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1174 
074C: AS_actor 0@ goto_AS_origin 3@ 
10@ += 1 

:BARSTAF_1174
jump @BARSTAF_1388 

:BARSTAF_1181
Actor.StorePos(0@, 14@, 15@, 16@)" );
                _local8.get_of_closest_map_attractor<BARGUY>( _local14, _local15, _local16, _local6, NULL );
AppendLine( @"if 
  8@ > -1 
jf @BARSTAF_1337 
13@ = Actor.Health(8@)
if 
  13@ == 99 
jf @BARSTAF_1280 
8@ = -1 
jump @BARSTAF_1337 

:BARSTAF_1280
062E: get_actor 8@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1330 
9@ += 1 
10@ = 0 
jump @BARSTAF_1337 

:BARSTAF_1330
8@ = -1 

:BARSTAF_1337
062E: get_actor 0@ task 1868 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1381 
074C: AS_actor 0@ goto_AS_origin 1@ 
10@ = 0 

:BARSTAF_1381
jump @BARSTAF_1388 

:BARSTAF_1388
return 

:BARSTAF_1390
0871: init_jump_table 10@ total_jumps 8 default_jump 0 @BARSTAF_2083 jumps 0 @BARSTAF_1518 1 @BARSTAF_1577 2 @BARSTAF_1628 3 @BARSTAF_1720 4 @BARSTAF_1771 5 @BARSTAF_1873 6 @BARSTAF_1934 
0872: jump_table_jumps 7 @BARSTAF_1985 -1 @BARSTAF_2083 -1 @BARSTAF_2083 -1 @BARSTAF_2083 -1 @BARSTAF_2083 -1 @BARSTAF_2083 -1 @BARSTAF_2083 -1 @BARSTAF_2083 -1 @BARSTAF_2083 

:BARSTAF_1518
04C4: store_coords_to 14@ 15@ 16@ from_actor 8@ with_offset 0.0 5@ 0.0 
05D3: AS_actor 0@ goto_point 14@ 15@ 16@ mode 4 time -2 ms 
10@ += 1 
jump @BARSTAF_2083 

:BARSTAF_1577
062E: get_actor 0@ task 1491 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1621 
0639: AS_actor 0@ rotate_to_actor 8@ 
10@ += 1 

:BARSTAF_1621
jump @BARSTAF_2083 

:BARSTAF_1628
062E: get_actor 0@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1713 
Actor.Health(8@) = 99
0605: actor 0@ perform_animation ""BARSERVE_ORDER"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 3000 
10@ += 1 

:BARSTAF_1713
jump @BARSTAF_2083 

:BARSTAF_1720
062E: get_actor 0@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1764 
074C: AS_actor 0@ goto_AS_origin 4@ 
10@ += 1 

:BARSTAF_1764
jump @BARSTAF_2083 

:BARSTAF_1771
062E: get_actor 0@ task 1868 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1866 
if 
  7@ == 0 
jf @BARSTAF_1859 
0605: actor 0@ perform_animation ""BARSERVE_GLASS"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 

:BARSTAF_1859
10@ += 1 

:BARSTAF_1866
jump @BARSTAF_2083 

:BARSTAF_1873
062E: get_actor 0@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1927 
05D3: AS_actor 0@ goto_point 14@ 15@ 16@ mode 4 time -2 ms 
10@ += 1 

:BARSTAF_1927
jump @BARSTAF_2083 

:BARSTAF_1934
062E: get_actor 0@ task 1491 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_1978 
0639: AS_actor 0@ rotate_to_actor 8@ 
10@ += 1 

:BARSTAF_1978
jump @BARSTAF_2083 

:BARSTAF_1985
062E: get_actor 0@ task 1593 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_2076 
Actor.Health(8@) = 99
0605: actor 0@ perform_animation ""BARSERVE_GIVE"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 3000 
9@ += 1 
10@ = 0 

:BARSTAF_2076
jump @BARSTAF_2083 

:BARSTAF_2083
return 

:BARSTAF_2085
0871: init_jump_table 10@ total_jumps 1 default_jump 0 @BARSTAF_2198 jumps 0 @BARSTAF_2148 -1 @BARSTAF_2198 -1 @BARSTAF_2198 -1 @BARSTAF_2198 -1 @BARSTAF_2198 -1 @BARSTAF_2198 -1 @BARSTAF_2198 

:BARSTAF_2148
062E: get_actor 0@ task 1541 status_store_to 13@ 
if 
04A4:   13@ == 7 
jf @BARSTAF_2191 
9@ = 1 
10@ = 0 

:BARSTAF_2191
jump @BARSTAF_2198 

:BARSTAF_2198
return 

:BARSTAF_2200
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BARSTAF_2273 
062E: get_actor 0@ task 1476 status_store_to 12@ 
if 
04A4:   12@ == 7 
jf @BARSTAF_2266 
05C4: AS_actor 0@ hands_up 60000 ms 

:BARSTAF_2266
jump @BARSTAF_2280 

:BARSTAF_2273
gosub @BARSTAF_2287 

:BARSTAF_2280
jump @BARSTAF_2200 

:BARSTAF_2287
04EF: release_animation ""BAR"" 
Actor.RemoveReferences(0@)
end_thread 
return 
0663: printint ""PEDSTATE"" 9@ 
0663: printint ""SUBSTATESTATUS"" 10@ 
0663: printint ""LOOP_TIMER"" TIMERB 
0663: printint ""SCRIPT_TIMER"" TIMERA 
return 
end_thread" );
            }

        }

    }

}