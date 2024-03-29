﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BAR : External {

            Int _local0 = local( 0 ),
                _local1 = local( 1 ),
                _local3 = local( 3 ),
                _local6 = local( 6 ),
                _local7 = local( 7 ),
                _local8 = local( 8 ),
                _local9 = local( 9 ),
                _local10 = local( 10 );

            public override void START( LabelJump label ) {
                AppendLine( @"if and
  " + OnMission + @" == 0 
88B4:   not test " + _390 + @" bit 1 
jf @BAR_50 
" + _9472 + @" = 0 
" + _5297 + @" = 0 

:BAR_50
0@ = 0 
if 
  0@ > 0 
jf @BAR_99 
" + _1231 + @" = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:BAR_99
1@ = 1 
2@ = 0 
0652: 0@ = integer_stat 156 
if 
  0@ >= 7500 
jf @BAR_154 
15@ = 3 
jump @BAR_161 

:BAR_154
15@ = 0 

:BAR_161
gosub @BAR_2146 
0615: define_AS_pack_begin 4@ 
0605: actor -1 perform_animation ""BARSERVE_IN"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation ""BARSERVE_LOOP"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 10000 
0616: define_AS_pack_end 4@ 
0615: define_AS_pack_begin 5@ 
0605: actor -1 perform_animation ""BARSERVE_BOTTLE"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 5@ 
if 
   Player.Defined(" + PlayerChar + @")
jf @BAR_944 
094B: " + Active_Interior_Name + @" = get_active_interior_name_from_actor " + PlayerActor + @" 
if 
08F9:   " + Active_Interior_Name + @" == ""BAR1"" 
jf @BAR_534 
061D: create_AS_origin_at 502.2242 -19.8799 999.6797 Z_angle 107.0 unknown_angle -107.0 AS_pack 4@ handle_as 6@ 
061D: create_AS_origin_at 502.0665 -24.1488 999.6797 Z_angle 94.0 unknown_angle -94.0 AS_pack 4@ handle_as 7@ 
061D: create_AS_origin_at 502.0757 -17.2798 999.6719 Z_angle 85.0 unknown_angle -85.0 AS_pack 4@ handle_as 8@ 
061D: create_AS_origin_at 502.3116 -19.8236 999.6797 Z_angle 278.6 unknown_angle -278.6 AS_pack 5@ handle_as 9@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 6@ task 1466 handle_as 10@" );
start_new_external_script<BARSTAF>( _local10, _local6, _local7, _local8, _local9, 2.5, ( double ) 20.0 );
load_external_script<BARSTAF>();
AppendLine( @"
:BAR_534
if 
08F9:   " + Active_Interior_Name + @" == ""BAR2"" 
jf @BAR_738 
061D: create_AS_origin_at 497.9362 -78.0533 997.7651 Z_angle 1.0 unknown_angle -1.0 AS_pack 4@ handle_as 6@ 
061D: create_AS_origin_at 493.9349 -77.9233 997.7651 Z_angle 100.5 unknown_angle -100.5 AS_pack 4@ handle_as 7@ 
061D: create_AS_origin_at 501.2002 -77.739 997.7651 Z_angle 19.0 unknown_angle -19.0 AS_pack 4@ handle_as 8@ 
061D: create_AS_origin_at 496.5553 -78.7725 997.7651 Z_angle 194.5 unknown_angle -194.5 AS_pack 5@ handle_as 9@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 6@ task 1466 handle_as 10@" );
start_new_external_script<BARSTAF>( _local10, _local6, _local7, _local8, _local9, 2.5, ( double ) 20.0 );
load_external_script<BARSTAF>();
AppendLine( @"
:BAR_738
if 
08F9:   " + Active_Interior_Name + @" == ""UFOBAR"" 
jf @BAR_944 
061D: create_AS_origin_at -223.2594 1405.634 26.7656 Z_angle 86.9 unknown_angle 262.0 AS_pack 4@ handle_as 6@ 
061D: create_AS_origin_at -223.26 1402.984 26.7656 Z_angle 145.4 unknown_angle 327.0 AS_pack 4@ handle_as 7@ 
061D: create_AS_origin_at -223.2956 1407.486 26.7656 Z_angle 26.0 unknown_angle 184.0 AS_pack 4@ handle_as 8@ 
061D: create_AS_origin_at -222.6826 1405.787 26.7656 Z_angle 275.7 unknown_angle 97.0 AS_pack 5@ handle_as 9@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 6@ task 1466 handle_as 10@ " );
start_new_external_script<BARSTAF>( _local10, _local6, _local7, _local8, _local9, 2.5, ( double ) 20.0 );
load_external_script<BARSTAF>();
AppendLine( @"
:BAR_944
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @BAR_2139 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @BAR_1004 
jump @BAR_2225 

:BAR_1004
if and
  " + _5297 + @" == 0 
  " + OnMission + @" == 0 
  2@ == 0 
jf @BAR_1462 
if 
08F9:   " + Active_Interior_Name + @" == ""BAR1"" 
jf @BAR_1455 
if 
0102:   actor " + PlayerActor + @" in_sphere 488.0048 -14.0754 999.6797 radius 1.5 1.5 1.5 sphere 1 stopped_on_foot 
jf @BAR_1455 
03E6: remove_text_box 
00BE: text_clear_all 
if 
08B4:   test " + _390 + @" bit 1 
jf @BAR_1286 
0652: 0@ = integer_stat 156 
if 
  0@ >= 3500 
jf @BAR_1169 
3@ = 3 
jump @BAR_1244 

:BAR_1169
if 
  0@ >= 6000 
jf @BAR_1202 
3@ = 4 
jump @BAR_1244 

:BAR_1202
if 
  0@ >= 7500 
jf @BAR_1237 
0209: 3@ = random_int_in_ranges 1 5 
jump @BAR_1244 

:BAR_1237
3@ = 2 

:BAR_1244" );
start_new_external_script<DANCE>( 488.0048, -14.0754, 999.6797, ( double ) 180.0, _local3, _1231 ); 
load_external_script<DANCE>();
AppendLine( @"jump @BAR_1441 

:BAR_1286
0871: init_jump_table 15@ total_jumps 4 default_jump 0 @BAR_1407 jumps 0 @BAR_1349 1 @BAR_1363 2 @BAR_1377 3 @BAR_1391 -1 @BAR_1407 -1 @BAR_1407 -1 @BAR_1407 

:BAR_1349
3@ = 2 
jump @BAR_1407 

:BAR_1363
3@ = 3 
jump @BAR_1407 

:BAR_1377
3@ = 4 
jump @BAR_1407 

:BAR_1391
0209: 3@ = random_int_in_ranges 1 5 
jump @BAR_1407 

:BAR_1407" );
start_new_external_script<DANCE>( 488.0048, -14.0754, 999.6797, ( double ) 180.0, _local3, 0 );
load_external_script<DANCE>();
AppendLine( @"
:BAR_1441
2@ = 1 
16@ = 0 

:BAR_1455
jump @BAR_1884 

:BAR_1462
if and
  " + _5297 + @" == 0 
  " + OnMission + @" == 0 
  2@ == 1 
jf @BAR_1884 
if 
08F9:   " + Active_Interior_Name + @" == ""BAR1"" 
jf @BAR_1884 
if 
80FF:   not actor " + PlayerActor + @" sphere 0 in_sphere 488.0048 -14.0754 999.6797 radius 2.5 2.5 2.5 on_foot 
jf @BAR_1578 
2@ = 0 
jump @BAR_1884 

:BAR_1578
if and
89BE:   not are_text_boxes_locked_to_any_thread 
88B4:   not test " + _390 + @" bit 1 
  16@ == 0 
jf @BAR_1884 
0871: init_jump_table 15@ total_jumps 3 default_jump 0 @BAR_1884 jumps 0 @BAR_1668 1 @BAR_1740 2 @BAR_1812 -1 @BAR_1884 -1 @BAR_1884 -1 @BAR_1884 -1 @BAR_1884 

:BAR_1668
if 
  " + DANCE_SCORE + @" >= 3500 
jf @BAR_1733 
00BA: show_text_styled GXT 'DNC_P1' time 5000 style 4  
00BC: show_text_highpriority GXT 'DNC_P2' time 10000 flag 1  
16@ = 1 
15@ += 1 

:BAR_1733
jump @BAR_1884 

:BAR_1740
if 
  " + DANCE_SCORE + @" >= 6000 
jf @BAR_1805 
00BA: show_text_styled GXT 'DNC_P1' time 5000 style 4  
00BC: show_text_highpriority GXT 'DNC_P2' time 10000 flag 1  
16@ = 1 
15@ += 1 

:BAR_1805
jump @BAR_1884 

:BAR_1812
if 
  " + DANCE_SCORE + @" >= 7500 
jf @BAR_1877 
00BA: show_text_styled GXT 'DNC_P1' time 5000 style 4  
00BC: show_text_highpriority GXT 'DNC_P3' time 10000 flag 1  
16@ = 1 
15@ += 1 

:BAR_1877
jump @BAR_1884 

:BAR_1884
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
jf @BAR_1907 
" + _9472 + @" = 1 

:BAR_1907
if 
   Player.WantedLevel(" + PlayerChar + @") > " + Player_Wanted_Level + @"
jf @BAR_1933 
" + _9472 + @" = 1 

:BAR_1933
0@ = 0 

:BAR_1940
if 
   not Actor.Dead(10@(0@,2i))
jf @BAR_2034 
if and
0457:   player " + PlayerChar + @" aiming_at_actor 10@(0@,2i) 
82D8:   not actor " + PlayerActor + @" current_weapon == 56 
jf @BAR_2004 
" + _9472 + @" = 1 
jump @BAR_2034 

:BAR_2004
if 
051A:   actor 10@(0@,2i) damaged_by_actor " + PlayerActor + @" 
jf @BAR_2034 
" + _9472 + @" = 1 

:BAR_2034
0@ += 1 
  0@ >= 2 
jf @BAR_1940 
if 
  " + _9472 + @" == 1 
jf @BAR_2139 
" + _5297 + @" = 1 
08E5: get_actor_in_sphere 12@ 13@ 14@ radius 50.0 handle_as 0@ 
if 
  0@ > -1 
jf @BAR_2139 
1@ += 1" );
start_new_external_script<FFPNC>( _local0, _local1 );
load_external_script<FFPNC>();
AppendLine( @"
:BAR_2139
jump @BAR_944 

:BAR_2146
Model.Load(#VWFYCRP)
04ED: load_animation ""BAR"" 
04ED: load_animation ""DANCING"" 
if and
   Model.Available(#VWFYCRP)
04EE:   animation ""BAR"" loaded 
04EE:   animation ""DANCING"" loaded 
jf @BAR_2212 
return 
jump @BAR_2223 

:BAR_2212
wait 0 
jump @BAR_2146 

:BAR_2223
return 

:BAR_2225
0@ = 0 

:BAR_2232
Actor.RemoveReferences(10@(0@,2i))
Actor.DestroyInstantly(10@(0@,2i))
0@ += 1 
  0@ >= 2 
jf @BAR_2232 
0@ = 0 

:BAR_2278
if 
   not 6@(0@,4i) == -1 
jf @BAR_2309 
061E: remove_references_to_AS_origin 6@(0@,4i) 

:BAR_2309
0@ += 1 
  0@ >= 4 
jf @BAR_2278 
Model.Destroy(#VWFYCRP)
061B: remove_references_to_AS_pack 4@ 
061B: remove_references_to_AS_pack 5@ 
04EF: release_animation ""BAR"" 
04EF: release_animation ""DANCING"" 
end_thread 
end_thread" );
            }

        }

    }

}