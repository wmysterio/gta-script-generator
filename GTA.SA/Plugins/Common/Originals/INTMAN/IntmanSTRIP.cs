using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class STRIP : External {

            Int _local0 = local( 0 ),
                _local1 = local( 1 ),
                _local10 = local( 10 ),
                _local11 = local( 11 ),
                _local12 = local( 12 ),
                _local13 = local( 13 ),
                _local16 = local( 16 ),
                _local17 = local( 17 ),
                _local18 = local( 18 );

            public override void START( LabelJump label ) {
                AppendLine( @"if 
  " + OnMission + @" == 0 
jf @STRIP_43 
" + _9473 + @" = 0 
" + _9471 + @" = 0 

:STRIP_43
0@ = 0 
if 
  0@ == 1 
jf @STRIP_114 
" + _9477 + @" = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)
" + _9478 + @" = Object.Create(#NULL, 0.0, 0.0, 0.0)

:STRIP_114
1@ = 1 
" + _9475 + @" = 0 
" + _9474 + @" = 0 
gosub @STRIP_2509 
0615: define_AS_pack_begin 7@ 
0605: actor -1 perform_animation ""BARSERVE_IN"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation ""BARSERVE_LOOP"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 10000 
0616: define_AS_pack_end 7@ 
0615: define_AS_pack_begin 8@ 
0605: actor -1 perform_animation ""BARSERVE_BOTTLE"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 8@ 
0615: define_AS_pack_begin 9@ 
05DE: AS_actor -1 walk_around_ped_path 
0616: define_AS_pack_end 9@ 
if 
   Player.Defined(" + PlayerChar + @")
jf @STRIP_881 
0297: reset_player " + PlayerChar + @" destroyed_model_counters 
094B: " + _5311 + @" = get_active_interior_name_from_actor " + PlayerActor + @"
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_650 
061D: create_AS_origin_at 1214.859 -15.4637 999.9219 Z_angle 0.0 unknown_angle 180.0 AS_pack 7@ handle_as 10@ 
061D: create_AS_origin_at 1217.084 -15.4657 999.9219 Z_angle 0.0 unknown_angle 180.0 AS_pack 7@ handle_as 11@ 
061D: create_AS_origin_at 1213.234 -15.4087 999.9219 Z_angle 0.0 unknown_angle 180.0 AS_pack 7@ handle_as 12@ 
061D: create_AS_origin_at 1214.085 -15.4395 999.9219 Z_angle 0.0 unknown_angle 180.0 AS_pack 8@ handle_as 13@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 10@ task 1466 handle_as 16@" );
                start_new_external_script<BARSTAF>( _local16, _local10, _local11, _local12, _local13, 2.5, ( double ) 15.0, 1 );
                load_external_script<BARSTAF>();
AppendLine( @"061D: create_AS_origin_at 1220.042 -15.3365 999.9219 Z_angle 341.7 unknown_angle -341.7 AS_pack 9@ handle_as 14@ 
061D: create_AS_origin_at 1222.008 4.4324 999.9219 Z_angle 93.3 unknown_angle -93.3 AS_pack 9@ handle_as 15@ 
0621: create_actor_pedtype 4 model #BMYBOUN at_AS_origin 14@ task 1502 handle_as 17@ 
0621: create_actor_pedtype 4 model #WMYBOUN at_AS_origin 15@ task 1502 handle_as 18@" );
                start_new_external_script<BOUNCER>( _local17 );
                start_new_external_script<BOUNCER>( _local18 );
                load_external_script<BOUNCER>();
AppendLine( @"
:STRIP_650
if 
08F9:   " + _5311 + @" == ""STRIP2"" 
jf @STRIP_881 
10@ = -1 
061D: create_AS_origin_at 1206.2 -30.6012 999.9531 Z_angle 180.0 unknown_angle 0.0 AS_pack 7@ handle_as 11@ 
12@ = -1 
061D: create_AS_origin_at 1206.2 -29.1414 999.9531 Z_angle 270.0 unknown_angle 0.0 AS_pack 8@ handle_as 13@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 11@ task 1466 handle_as 16@ " );
                start_new_external_script<BARSTAF>( _local16, _local11, _local11, _local11, _local13, 1.5, ( double ) 15.0, 1 );
                load_external_script<BARSTAF>();
AppendLine( @"061D: create_AS_origin_at 1216.871 -24.1246 999.9531 Z_angle 146.8 unknown_angle -146.8 AS_pack 9@ handle_as 14@ 
15@ = -1 
0621: create_actor_pedtype 4 model #BMYBOUN at_AS_origin 14@ task 1502 handle_as 17@ 
18@ = -1" );
                start_new_external_script<BOUNCER>( _local17 );
                load_external_script<BOUNCER>();
AppendLine( @"
:STRIP_881
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @STRIP_2502 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @STRIP_941 
jump @STRIP_2586 

:STRIP_941
if 
  4@ > 0 
jf @STRIP_973 
gosub @STRIP_2766 
jump @STRIP_881 

:STRIP_973
if 
   not " + _9475 + @" == 0 
jf @STRIP_1042 
if 
   not Actor.Dead(" + _9477 + @")
jf @STRIP_1021 
gosub @STRIP_5426 
jump @STRIP_1042 

:STRIP_1021
Player.CanMove(" + PlayerChar + @") = True
" + _9475 + @" = 0 
" + _9477 + @" = -1 

:STRIP_1042
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_1326 
if and
  " + _9473 + @" == 0 
  " + _9471 + @" == 0 
jf @STRIP_1326 
if 
0102:   actor " + PlayerActor + @" in_sphere 1204.85 11.8 999.9219 radius 1.0 1.0 1.0 sphere 1 stopped_on_foot 
jf @STRIP_1312 
if 
   Player.Money(" + PlayerChar + @") > 99
jf @STRIP_1298 
if 
  2@ == 0 
jf @STRIP_1291 
3@ = 1 
if 
00E1:   player 0 pressed_key 15 
jf @STRIP_1291 
Player.Money(" + PlayerChar + @") += -100
0624: add 100.0 to_float_stat 54 
2@ = 1 
3@ = 0 
19@ = 1204.326 
20@ = 17.709 
21@ = 998.925 
22@ = 0.0 
fade 0 500 
4@ = 1 
gosub @STRIP_2766 

:STRIP_1291
jump @STRIP_1305 

:STRIP_1298
3@ = 2 

:STRIP_1305
jump @STRIP_1326 

:STRIP_1312
3@ = 0 
2@ = 0 

:STRIP_1326
if 
08F9:   " + _5311 + @" == ""STRIP2"" 
jf @STRIP_1624 
if and
  " + _9473 + @" == 0 
  " + _9471 + @" == 0 
jf @STRIP_1624 
if 
0102:   actor " + PlayerActor + @" in_sphere 1207.59 -40.646 999.9531 radius 1.0 1.0 1.0 sphere 1 stopped_on_foot 
jf @STRIP_1610 
if 
   Player.Money(" + PlayerChar + @") > 99
jf @STRIP_1596 
if 
  2@ == 0 
jf @STRIP_1589 
3@ = 1 
if 
00E1:   player 0 pressed_key 15 
jf @STRIP_1589 
Player.Money(" + PlayerChar + @") += -100
0653: 22@ = float_stat 54 
22@ += 100.0 
0653: 22@ = float_stat 54 
2@ = 1 
3@ = 0 
19@ = 1207.366 
20@ = -43.595 
21@ = 998.925 
22@ = 0.0 
fade 0 500 
4@ = 1 
gosub @STRIP_2766 

:STRIP_1589
jump @STRIP_1603 

:STRIP_1596
3@ = 2 

:STRIP_1603
jump @STRIP_1624 

:STRIP_1610
3@ = 0 
2@ = 0 

:STRIP_1624
if and
  " + _9473 + @" == 0 
  " + _9471 + @" == 0 
jf @STRIP_1784 
if 
  3@ == 1 
jf @STRIP_1685 
0512: show_permanent_text_box 'STR_01'
jump @STRIP_1777 

:STRIP_1685
if 
  3@ == 2 
jf @STRIP_1721 
0512: show_permanent_text_box 'STR_03'
jump @STRIP_1777 

:STRIP_1721
if 
  " + _9474 + @" > 0 
jf @STRIP_1757 
0512: show_permanent_text_box 'STR_00'
jump @STRIP_1777 

:STRIP_1757
if 
  4@ == 0 
jf @STRIP_1777 
03E6: remove_text_box 

:STRIP_1777
jump @STRIP_1786 

:STRIP_1784
03E6: remove_text_box 

:STRIP_1786
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
jf @STRIP_1816 
" + _9473 + @" = 1 
" + _9471 + @" = 1 

:STRIP_1816
if 
   Player.WantedLevel(" + PlayerChar + @") > " + Player_Wanted_Level + @"
jf @STRIP_1849 
" + _9473 + @" = 1 
" + _9471 + @" = 1 

:STRIP_1849
0806: get_player " + PlayerChar + @" kills_from_last_checkpoint 0@ 
if 
  0@ > 0 
jf @STRIP_1882 
" + _9471 + @" = 1 

:STRIP_1882
0@ = 0 

:STRIP_1889
if 
   not Actor.Dead(16@(0@,3i))
jf @STRIP_1997 
if and
0457:   player " + PlayerChar + @" aiming_at_actor 16@(0@,3i) 
82D8:   not actor " + PlayerActor + @" current_weapon == 56 
jf @STRIP_1960 
" + _9473 + @" = 1 
" + _9471 + @" = 1 
jump @STRIP_1997 

:STRIP_1960
if 
051A:   actor 16@(0@,3i) damaged_by_actor " + PlayerActor + @" 
jf @STRIP_1997 
" + _9473 + @" = 1 
" + _9471 + @" = 1 

:STRIP_1997
0@ += 1 
  0@ >= 3 
jf @STRIP_1889 
if 
  " + _9473 + @" == 1 
jf @STRIP_2102 
" + _9471 + @" = 1 
08E5: get_actor_in_sphere 19@ 20@ 21@ radius 50.0 handle_as 0@ 
if 
  0@ > -1 
jf @STRIP_2102 
1@ += 1" );
                start_new_external_script<FFPNC>( _local0, _local1 );
                load_external_script<FFPNC>();
AppendLine( @"
:STRIP_2102
if 
  " + _9471 + @" == 1 
jf @STRIP_2502 
if and
   Actor.Dead(17@)
   not 14@ == -1 
jf @STRIP_2338 
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_2198 
19@ = 1220.042 
20@ = -15.3365 
21@ = 999.9219 

:STRIP_2198
if 
08F9:   " + _5311 + @" == ""STRIP2"" 
jf @STRIP_2252 
19@ = 1216.871 
20@ = -24.1246 
21@ = 999.9531 

:STRIP_2252
if and
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 19@ 20@ 21@ radius 8.0 8.0 8.0 
80C2:   not sphere_onscreen 19@ 20@ 21@ radius 3.0 
jf @STRIP_2338 
0621: create_actor_pedtype 4 model #BMYBOUN at_AS_origin 14@ task 1502 handle_as 17@" );
                start_new_external_script<BOUNCER>( _local17 );
                load_external_script<BOUNCER>();
AppendLine( @"
:STRIP_2338
if and
   Actor.Dead(18@)
   not 15@ == -1 
jf @STRIP_2502 
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_2416 
19@ = 1222.008 
20@ = 4.4324 
21@ = 999.9219 

:STRIP_2416
if and
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 19@ 20@ 21@ radius 8.0 8.0 8.0 
80C2:   not sphere_onscreen 19@ 20@ 21@ radius 3.0 
jf @STRIP_2502 
0621: create_actor_pedtype 4 model #WMYBOUN at_AS_origin 15@ task 1502 handle_as 18@" );
                start_new_external_script<BOUNCER>( _local18 );
                load_external_script<BOUNCER>();
AppendLine( @"
:STRIP_2502
jump @STRIP_881 

:STRIP_2509
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
Model.Load(#VWFYCRP)
04ED: load_animation ""BAR"" 
if and
   Model.Available(#BMYBOUN)
   Model.Available(#WMYBOUN)
   Model.Available(#VWFYCRP)
04EE:   animation ""BAR"" loaded 
jf @STRIP_2573 
return 
jump @STRIP_2584 

:STRIP_2573
wait 0 
jump @STRIP_2509 

:STRIP_2584
return 

:STRIP_2586
0@ = 0 

:STRIP_2593
Actor.RemoveReferences(16@(0@,3i))
Actor.DestroyInstantly(16@(0@,3i))
0@ += 1 
  0@ >= 3 
jf @STRIP_2593 
0@ = 0 

:STRIP_2639
if 
   not 10@(0@,6i) == -1 
jf @STRIP_2670 
061E: remove_references_to_AS_origin 10@(0@,6i) 

:STRIP_2670
0@ += 1 
  0@ >= 6 
jf @STRIP_2639 
Model.Destroy(#VWFYCRP)
Model.Destroy(#BMYBOUN)
Model.Destroy(#WMYBOUN)
061B: remove_references_to_AS_pack 7@ 
061B: remove_references_to_AS_pack 8@ 
04EF: release_animation ""STRIP"" 
04EF: release_animation ""BAR"" 
" + _9471 + @" = 0 
03E6: remove_text_box 
if 
   Player.Defined(" + PlayerChar + @")
jf @STRIP_2764 
Player.CanMove(" + PlayerChar + @") = True

:STRIP_2764
end_thread 

:STRIP_2766
0871: init_jump_table 4@ total_jumps 6 default_jump 0 @STRIP_3923 jumps 1 @STRIP_2829 2 @STRIP_3053 3 @STRIP_3194 4 @STRIP_3320 5 @STRIP_3653 6 @STRIP_3887 -1 @STRIP_3923 

:STRIP_2829
if 
   not fading 
jf @STRIP_3046 
03E6: remove_text_box 
Player.CanMove(" + PlayerChar + @") = False
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 1 
0826: enable_hud 0 
0581: enable_radar 0 
0792: disembark_instantly_actor " + PlayerActor + @" 
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Actor.PutAt(" + PlayerActor + @", 19@, 20@, 21@)
Actor.Angle(" + PlayerActor + @") = 22@
03C8: set_camera_directly_before_player 
if 
  " + _9476 + @" == 0 
jf @STRIP_2956 
04AF: 5@ = 256
06D2: 28@v = ""LAPDAN1""
" + _9476 + @" += 1 
jump @STRIP_3039 

:STRIP_2956
if 
  " + _9476 + @" == 1 
jf @STRIP_3010 
04AF: 5@ = 257
06D2: 28@v = ""LAPDAN2""
" + _9476 + @" += 1 
jump @STRIP_3039 

:STRIP_3010
04AF: 5@ = 246
06D2: 28@v = ""LAPDAN3""
" + _9476 + @" = 0 

:STRIP_3039
4@ += 1 

:STRIP_3046
jump @STRIP_3923 

:STRIP_3053
if 
84EE:   not animation 28@v loaded 
jf @STRIP_3081 
04ED: load_animation 28@v 
jump @STRIP_3187 

:STRIP_3081
if 
   not Model.Available(5@)
jf @STRIP_3109 
Model.Load(5@)
jump @STRIP_3187 

:STRIP_3109
04C4: store_coords_to 19@ 20@ 21@ from_actor " + PlayerActor + @" with_offset 0.0 -1.0 -1.0 
22@ = Actor.Angle(" + PlayerActor + @")
5@ = Actor.Create(CivFemale, 5@, 19@, 20@, 21@)
0619: enable_actor 5@ collision_detection 0 
Actor.Angle(5@) = 22@
4@ += 1 

:STRIP_3187
jump @STRIP_3923 

:STRIP_3194
0812: AS_actor " + PlayerActor + @" perform_animation ""LAPDAN_P"" IFP 28@v framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1
if 
   not Actor.Dead(5@)
jf @STRIP_3290 
0812: AS_actor 5@ perform_animation ""LAPDAN_D"" IFP 28@v framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1
6@ = -1 
gosub @STRIP_3925 

:STRIP_3290
fade 1 1500 
TIMERB = 0 
03E6: remove_text_box 
4@ += 1 
jump @STRIP_3923 

:STRIP_3320
if 
   not fading 
jf @STRIP_3646 
if 
   not Actor.Dead(5@)
jf @STRIP_3639 
if 
   Actor.Animation(" + PlayerActor + @") == ""LAPDAN_P""
jf @STRIP_3432 
061A: get_actor " + PlayerActor + @" animation ""LAPDAN_P"" total_time_to 23@ 
0092: 25@ = float 23@ to_integer 
25@ -= 800 
0085: 26@ = 25@
26@ -= 2200 
jump @STRIP_3439 

:STRIP_3432
25@ = 0 

:STRIP_3439
if and
  TIMERB > 2500 
  2600 > TIMERB 
jf @STRIP_3499 
if 
8A2A:   not text_box 'STR_02' displayed
jf @STRIP_3499 
03E5: show_text_box 'STR_02'

:STRIP_3499
if 
002D:   TIMERB >= 25@
jf @STRIP_3539 
fade 0 500 
4@ += 1 
jump @STRIP_3923 

:STRIP_3539
if and
00E1:   player 0 pressed_key 17 
  TIMERA >= 500 
  TIMERB > 2500 
001D:   26@ > TIMERB
jf @STRIP_3594 
gosub @STRIP_3925 
TIMERA = 0 

:STRIP_3594
if 
00E1:   player 0 pressed_key 15 
jf @STRIP_3632 
fade 0 500 
4@ += 1 
jump @STRIP_3923 

:STRIP_3632
jump @STRIP_3646 

:STRIP_3639
4@ += 1 

:STRIP_3646
jump @STRIP_3923 

:STRIP_3653
if 
   not fading 
jf @STRIP_3880 
if 
   not Actor.Dead(5@)
jf @STRIP_3873 
03E6: remove_text_box 
0665: get_actor 5@ model_to 0@ 
Model.Destroy(0@)
04EF: release_animation 28@v 
Actor.DestroyInstantly(5@)
0792: disembark_instantly_actor " + PlayerActor + @" 
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 1 
0826: enable_hud 1 
0581: enable_radar 1 
0792: disembark_instantly_actor " + PlayerActor + @" 
0619: enable_actor " + PlayerActor + @" collision_detection 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_3798 
Actor.PutAt(" + PlayerActor + @", 1204.991, 12.6603, 999.9219)
Actor.Angle(" + PlayerActor + @") = 180.0

:STRIP_3798
if 
08F9:   " + _5311 + @" == ""STRIP2"" 
jf @STRIP_3852 
Actor.PutAt(" + PlayerActor + @", 1207.59, -40.646, 999.9531)
Actor.Angle(" + PlayerActor + @") = 360.0

:STRIP_3852
fade 1 500 
4@ += 1 
jump @STRIP_3880 

:STRIP_3873
4@ += 1 

:STRIP_3880
jump @STRIP_3923 

:STRIP_3887
if 
   not fading 
jf @STRIP_3916 
Player.CanMove(" + PlayerChar + @") = True
4@ = 0 
return 

:STRIP_3916
jump @STRIP_3923 

:STRIP_3923
return 

:STRIP_3925
0871: init_jump_table 6@ total_jumps 5 default_jump 1 @STRIP_5173 jumps -1 @STRIP_3988 0 @STRIP_4225 1 @STRIP_4462 2 @STRIP_4699 3 @STRIP_4936 -1 @STRIP_5417 -1 @STRIP_5417 

:STRIP_3988
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_4119 
19@ = 1204.562 
20@ = 15.6486 
21@ = 1001.333 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1204.437 
20@ = 16.5805 
21@ = 1000.992 
Camera.PointAt(19@, 20@, 21@, 2)
jump @STRIP_4218 

:STRIP_4119
19@ = 1208.32 
20@ = -45.8672 
21@ = 1001.066 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1207.847 
20@ = -44.9985 
21@ = 1000.919 
Camera.PointAt(19@, 20@, 21@, 2)

:STRIP_4218
jump @STRIP_5417 

:STRIP_4225
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_4356 
19@ = 1202.654 
20@ = 16.7123 
21@ = 1001.302 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1203.589 
20@ = 16.9879 
21@ = 1001.08 
Camera.PointAt(19@, 20@, 21@, 1)
jump @STRIP_4455 

:STRIP_4356
19@ = 1205.649 
20@ = -44.5486 
21@ = 1001.344 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1206.541 
20@ = -44.2188 
21@ = 1001.035 
Camera.PointAt(19@, 20@, 21@, 1)

:STRIP_4455
jump @STRIP_5417 

:STRIP_4462
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_4593 
19@ = 1203.529 
20@ = 18.3118 
21@ = 1001.391 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1204.11 
20@ = 17.5609 
21@ = 1001.078 
Camera.PointAt(19@, 20@, 21@, 1)
jump @STRIP_4692 

:STRIP_4593
19@ = 1206.434 
20@ = -43.1812 
21@ = 1001.705 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1207.044 
20@ = -43.796 
21@ = 1001.204 
Camera.PointAt(19@, 20@, 21@, 1)

:STRIP_4692
jump @STRIP_5417 

:STRIP_4699
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_4830 
19@ = 1204.712 
20@ = 18.3221 
21@ = 1000.941 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1204.409 
20@ = 17.369 
21@ = 1000.95 
Camera.PointAt(19@, 20@, 21@, 1)
jump @STRIP_4929 

:STRIP_4830
19@ = 1207.472 
20@ = -43.1042 
21@ = 1001.054 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1207.325 
20@ = -44.0841 
21@ = 1000.919 
Camera.PointAt(19@, 20@, 21@, 1)

:STRIP_4929
jump @STRIP_5417 

:STRIP_4936
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_5067 
19@ = 1205.856 
20@ = 17.3141 
21@ = 1002.26 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1205.096 
20@ = 17.1228 
21@ = 1001.64 
Camera.PointAt(19@, 20@, 21@, 1)
jump @STRIP_5166 

:STRIP_5067
19@ = 1207.846 
20@ = -43.4954 
21@ = 1001.964 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1207.427 
20@ = -43.9585 
21@ = 1001.184 
Camera.PointAt(19@, 20@, 21@, 1)

:STRIP_5166
jump @STRIP_5417 

:STRIP_5173
6@ = -1 
if 
08F9:   " + _5311 + @" == ""LASTRIP"" 
jf @STRIP_5311 
19@ = 1204.562 
20@ = 15.6486 
21@ = 1001.333 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1204.437 
20@ = 16.5805 
21@ = 1000.992 
Camera.PointAt(19@, 20@, 21@, 1)
jump @STRIP_5410 

:STRIP_5311
19@ = 1207.978 
20@ = -46.1248 
21@ = 1001.215 
Camera.SetPosition(19@, 20@, 21@, 0.0, 0.0, 0.0)
19@ = 1207.757 
20@ = -45.1702 
21@ = 1001.016 
Camera.PointAt(19@, 20@, 21@, 1)

:STRIP_5410
jump @STRIP_5417 

:STRIP_5417
6@ += 1 
return 

:STRIP_5426
0871: init_jump_table " + _9475 + @" total_jumps 4 default_jump 0 @STRIP_5877 jumps 1 @STRIP_5489 2 @STRIP_5518 3 @STRIP_5598 4 @STRIP_5770 -1 @STRIP_5877 -1 @STRIP_5877 -1 @STRIP_5877 

:STRIP_5489
Player.CanMove(" + PlayerChar + @") = False
0639: AS_actor " + PlayerActor + @" rotate_to_actor " + _9477 + @" 
" + _9475 + @" = 2 
jump @STRIP_5877 

:STRIP_5518
062E: get_actor " + PlayerActor + @" task 1593 status_store_to 27@
if 
04A4:   27@ == 7
jf @STRIP_5591 
0812: AS_actor " + PlayerActor + @" perform_animation ""PLY_CASH"" IFP ""STRIP"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 0
" + _9475 + @" = 3 

:STRIP_5591
jump @STRIP_5877 

:STRIP_5598
if 
   Actor.Animation(" + PlayerActor + @") == ""PLY_CASH""
jf @STRIP_5756 
0613: 24@ = actor " + PlayerActor + @" animation ""PLY_CASH"" time 
if and
  24@ >= 0.35 
  1.0 > 24@ 
jf @STRIP_5749 
04C4: store_coords_to 19@ 20@ 21@ from_actor " + _9477 + @" with_offset 0.0 0.5 -0.5 
" + _9478 + @" = Object.Init(#MONEY, 19@, 20@, 21@)
Object.CollisionDetection(" + _9478 + @") = False
Player.Money(" + PlayerChar + @") += -20
0624: add 20.0 to_float_stat 54 
" + _9475 + @" = 4 

:STRIP_5749
jump @STRIP_5763 

:STRIP_5756
" + _9475 + @" = 4 

:STRIP_5763
jump @STRIP_5877 

:STRIP_5770
if 
   Actor.Animation(" + PlayerActor + @") == ""PLY_CASH""
jf @STRIP_5856 
0613: 24@ = actor " + PlayerActor + @" animation ""PLY_CASH"" time 
if 
  24@ >= 1.0 
jf @STRIP_5849 
Player.CanMove(" + PlayerChar + @") = True
" + _9475 + @" = 0 

:STRIP_5849
jump @STRIP_5870 

:STRIP_5856
Player.CanMove(" + PlayerChar + @") = True
" + _9475 + @" = 0 

:STRIP_5870
jump @STRIP_5877 

:STRIP_5877
return 
end_thread" );
            }

        }

    }

}