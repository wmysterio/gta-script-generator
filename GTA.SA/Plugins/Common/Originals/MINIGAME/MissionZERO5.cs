using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class ZERO5 : MissionCustom {

            Int isAssetPickupCreated = global();
            AssetMoneyPickup zeroCash = global();

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @ZERO5_36 
if 
wasted_or_busted 
else_jump @ZERO5_27 
gosub @ZERO5_1896 

:ZERO5_27
gosub @ZERO5_1993 
end_thread 

:ZERO5_36
66@ = 0 
" + OnMission + @" = 1 
0A0E: disable_text_with_style 1 
increment_mission_attempts 
Player.CanMove(" + PlayerChar + @") = False
wait 0 
48@ = 1 
49@ = 0 
50@ = 0 
51@ = 0 
57@ = 0 
55@ = 0 
56@ = 0 
63@ = 0 
64@ = 0 
52@ = 0 
53@ = 0 
" + BeefyBaron_Score + @" = 0 
" + BeefyBaron_Time + @" = 180000 
40@ = -2205.44 
41@ = 128.99 
42@ = 57.33 
43@ = 90.0 
44@ = -2227.0 
45@ = 113.0 
46@ = 35.5 
0297: reset_player " + PlayerChar + @" destroyed_model_counters 
32@ = 0 
69@ = 0 
Model.Load(#RCBARON)
Model.Load(#TOPFUN)

:ZERO5_271
if or
   not Model.Available(#RCBARON)
   not Model.Available(#TOPFUN)
else_jump @ZERO5_303 
wait 0 
jump @ZERO5_271 

:ZERO5_303
09B9: show_entered_car_name 0 
054C: use_GXT_table 'ZERO2' 
08E7: disable_entrance_markers 1 

:ZERO5_322
wait 0 
if 
  48@ == 1 
else_jump @ZERO5_351 
gosub @ZERO5_408 

:ZERO5_351
if 
  52@ == 1 
else_jump @ZERO5_376 
jump @ZERO5_1859 

:ZERO5_376
if 
  53@ == 1 
else_jump @ZERO5_401 
jump @ZERO5_1896 

:ZERO5_401
jump @ZERO5_322 

:ZERO5_408
33@ = 0 
0395: clear_area 1 at 44@ 45@ 46@ radius 1000.0 
35@ = Car.Create(#TOPFUN, -2250.9, 124.6, 28.48)
0587: enable_car 35@ validate_position 0 
0657: car 35@ open_door 4 
0657: car 35@ open_door 5 
036A: put_actor " + PlayerActor + @" in_car 35@ 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
01F7: set_player " + PlayerChar + @" ignored_by_cops 1 
0169: set_fade_color_RGB 0 0 0 
if 
   not Car.Wrecked(35@)
else_jump @ZERO5_557 
Car.PutAt(35@, -2233.9, 122.6, 746.48)
Car.Angle(35@) = 90.0
Car.LockInCurrentPosition(35@) = True

:ZERO5_557
wait 1000 
if 
   not Car.Wrecked(35@)
else_jump @ZERO5_583 
0508: car 35@ close_all_doors 

:ZERO5_583
select_interior 0 
08AD: link_actor " + PlayerActor + @" to_enex_marker_at -2240.854 129.3346 radius 1.5 
Camera.SetAtPos(40@, 41@, 42@)
046E: put_player " + PlayerChar + @" in_RC_mode_at 40@ 41@ 42@ angle 40.09 RC_model #RCBARON 
34@ = Player.RC_car(" + PlayerChar + @")
Car.Angle(34@) = 90.0
04D6: enable_RC_car_detonation 0 
048A: set_RC_car_detonation 0 
Car.Health(34@) = 1000
Car.SetImmunities(34@, 0, 1, 1, 0, 0)
02A3: enable_widescreen 0 
if 
   not Car.Wrecked(34@)
else_jump @ZERO5_733 
Camera.OnVehicle(34@, 18, 2)
Car.LockInCurrentPosition(34@) = False
wait 0 
032A: set_behind_camera_mode_to 1 

:ZERO5_733
0169: set_fade_color_RGB 0 0 0 
fade 1 1000 

:ZERO5_748
if 
fading 
else_jump @ZERO5_772 
wait 0 
jump @ZERO5_748 

:ZERO5_772
Player.CanMove(" + PlayerChar + @") = True
03C3: set_timer_to " + BeefyBaron_Time + @" type 1 GXT 'ZER2_5' 
03C4: set_status_text " + BeefyBaron_Score + @" type 0 GXT 'ZER2_43' 
00BC: show_text_highpriority GXT 'ZER2_45' time 5000 flag 1  
09BF: set_random_traffic_spawn_to_model #TOPFUN 

:ZERO5_832
if 
   not 57@ == 1 
else_jump @ZERO5_1857 
wait 0 
if 
0735:   is_keyboard_key_pressed 83 
else_jump @ZERO5_913 
48@ = 0 
49@ = 0 
50@ = 0 
51@ = 0 
52@ = 1 
53@ = 0 
return 

:ZERO5_913
if 
  0 >= " + BeefyBaron_Time + @" 
else_jump @ZERO5_1156 
if 
   not Car.Wrecked(34@)
else_jump @ZERO5_961 
0918: set_car 34@ engine_operation 0 
01EC: make_car 34@ very_heavy 1 

:ZERO5_961
04DB: exit_RC_mode 
32@ = 0 
48@ = 0 
49@ = 0 
50@ = 0 
51@ = 0 
52@ = 1 
53@ = 0 
01E3: show_text_1number_styled GXT 'ZER2_43' number " + BeefyBaron_Score + @" time 5000 style 1  
0394: play_music 1" );
and( isAssetPickupCreated == false, BeefyBaron_Score >= 20, delegate {
    zeroCash.create( -2243.007, 136.9601, 34.8203, 5000, 5000 );
    isAssetPickupCreated.value = true;
} );
AppendLine( @"wait 2000
08AD: link_actor " + PlayerActor + @" to_enex_marker_at -2241.854 128.3346 radius 1.5 
Camera.SetAtPos(-2241.854, 128.3346, 1034.641)
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @ZERO5_1120 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at -2220.146 135.956 1034.641 
jump @ZERO5_1140 

:ZERO5_1120
Actor.PutAt(" + PlayerActor + @", -2220.146, 135.956, 1034.641)

:ZERO5_1140
Actor.Angle(" + PlayerActor + @") = 183.6951
select_interior 6 
return 

:ZERO5_1156
if 
   not Car.Wrecked(34@)
else_jump @ZERO5_1681 
if 
   Player.InRemoteMode(" + PlayerChar + @")
else_jump @ZERO5_1674 
01BD: 70@ = current_time_in_ms 
if 
81AF:   not car 34@ sphere 0 in_sphere 72@ 73@ 74@ radius 1.5 1.5 1.5 
else_jump @ZERO5_1272 
Car.StorePos(34@, 72@, 73@, 74@)
0085: 71@ = 70@ 
71@ += 4000 
64@ = 0 

:ZERO5_1272
if 
01AF:   car 34@ sphere 0 in_sphere 72@ 73@ 74@ radius 1.5 1.5 1.5 
else_jump @ZERO5_1612 
if 
001D:   70@ > 71@ 
else_jump @ZERO5_1612 
if 
  64@ == 0 
else_jump @ZERO5_1369 
03E5: show_text_box 'ZER2_4'  
64@ = 1 

:ZERO5_1369
if 
00E1:   player 0 pressed_key 17 
else_jump @ZERO5_1612 
53@ = 1 
48@ = 0 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'ZER2_8' time 5000 flag 1  
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
Car.Health(34@) = 1
020C: create_explosion_with_radius 0 at 72@ 73@ 74@ 
04DB: exit_RC_mode 
53@ = 1 
48@ = 0 
00BC: show_text_highpriority GXT 'ZER2_8' time 5000 flag 1  
wait 2000 
08AD: link_actor " + PlayerActor + @" to_enex_marker_at -2241.854 128.3346 radius 1.5 
Camera.SetAtPos(-2241.854, 128.3346, 1034.641)
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @ZERO5_1576 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at -2220.146 135.956 1034.641 
jump @ZERO5_1596 

:ZERO5_1576
Actor.PutAt(" + PlayerActor + @", -2220.146, 135.956, 1034.641)

:ZERO5_1596
Actor.Angle(" + PlayerActor + @") = 183.6951
select_interior 6 
return 

:ZERO5_1612
Car.StorePos(34@, 37@, 38@, 39@)
073E: get_car_in_sphere 37@ 38@ 39@ radius 30.0 model #TOPFUN handle_as 36@ 
if 
   not Car.Wrecked(36@)
else_jump @ZERO5_1674 
Car.SetMaxSpeed(36@, 10.0)

:ZERO5_1674
jump @ZERO5_1839 

:ZERO5_1681
53@ = 1 
48@ = 0 
00BC: show_text_highpriority GXT 'ZER2_8' time 5000 flag 1  
Player.CanMove(" + PlayerChar + @") = False
wait 2000 
08AD: link_actor " + PlayerActor + @" to_enex_marker_at -2241.854 128.3346 radius 1.5 
Camera.SetAtPos(-2241.854, 128.3346, 1034.641)
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @ZERO5_1803 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at -2220.146 135.956 1034.641 
jump @ZERO5_1823 

:ZERO5_1803
Actor.PutAt(" + PlayerActor + @", -2220.146, 135.956, 1034.641)

:ZERO5_1823
Actor.Angle(" + PlayerActor + @") = 183.6951
select_interior 6 
return 

:ZERO5_1839
0298: get_player " + PlayerChar + @" destroyed_model #TOPFUN quantity_to " + BeefyBaron_Score + @" 
jump @ZERO5_832 

:ZERO5_1857
return 

:ZERO5_1859
Player.CanMove(" + PlayerChar + @") = True
Player.ClearWantedLevel(" + PlayerChar + @")
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @ZERO5_1894 
Player.CanMove(" + PlayerChar + @") = True

:ZERO5_1894
return 

:ZERO5_1896
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @ZERO5_1919 
Player.CanMove(" + PlayerChar + @") = True

:ZERO5_1919
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  

:ZERO5_1935
if 
  3000 > 32@ 
else_jump @ZERO5_1991 
wait 0 
if 
   not Car.Wrecked(34@)
else_jump @ZERO5_1984 
Car.SetSpeedInstantly(34@, 0.0)

:ZERO5_1984
jump @ZERO5_1935 

:ZERO5_1991
return 

:ZERO5_1993
0925: restore_camera_to_user_defined 
" + OnMission + @" = 0 
01F7: set_player " + PlayerChar + @" ignored_by_cops 0 
Car.RemoveReferences(35@)
if 
   Player.Defined(" + PlayerChar + @")
else_jump @ZERO5_2076 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @ZERO5_2076 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at -2244.444 136.8633 34.3203 
Actor.Angle(" + PlayerActor + @") = 90.0

:ZERO5_2076
01B7: release_weather 
Player.CanMove(" + PlayerChar + @") = True
08E7: disable_entrance_markers 0 
04DB: exit_RC_mode 
Model.Destroy(#TOPFUN)
Model.Destroy(#RCBARON)
014F: stop_timer " + BeefyBaron_Time + @" 
0151: remove_status_text " + BeefyBaron_Score + @" 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
09B9: show_entered_car_name 1 
mission_cleanup 
return" );
            }

        }

    }

}