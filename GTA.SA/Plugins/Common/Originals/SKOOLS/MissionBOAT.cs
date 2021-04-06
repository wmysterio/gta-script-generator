using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalSkools {

        private sealed class BOAT : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @BOAT_416 
if 
wasted_or_busted 
else_jump @BOAT_38 
gosub @BOAT_37691 

:BOAT_38
gosub @BOAT_37805 
end_thread 
if 
  " + OnMission + @" == 0 
else_jump @BOAT_416 
if 
  36@ == 13 
else_jump @BOAT_416 
37@ = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
46@ = Car.Create(#CHEETAH, 5.0, 5.0, 10.0)
47@ = Actor.Create(Mission1, #OMOBOAT, 20.0, 20.0, 20.0)
39@ = Actor.Create(Mission1, #OMOBOAT, 30.0, 30.0, 20.0)
42@ = Actor.Create(Mission1, #OMOBOAT, 30.0, 30.0, 20.0)
43@ = Actor.Create(Mission1, #OMOBOAT, 30.0, 30.0, 20.0)
40@ = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
41@ = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
45@ = Actor.Create(Mission1, #OMOBOAT, 30.0, 30.0, 20.0)
44@ = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
156@ = 0 

:BOAT_330
if 
  13 > 156@ 
else_jump @BOAT_416 
56@(156@,50i) = Object.Init(#BOUY, 0.0, 0.0, 100.0)
106@(156@,50i) = Object.Init(#WATERJUMP1, 0.0, 0.0, 150.0)
156@ += 1 
jump @BOAT_330 

:BOAT_416
" + OnMission + @" = 1 
if 
  " + Mission_Boat_School_Passed + @" == 0 
else_jump @BOAT_443 
increment_mission_attempts 

:BOAT_443
054C: use_GXT_table 'BOAT' 
08F8: display_stat_update_box 0 
09B9: show_entered_car_name 0 
09BA: show_entered_zone_name 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @BOAT_489 
0501: set_player " + PlayerChar + @" driveby_mode 0 

:BOAT_489
wait 0 
249@ = 0 
251@ = 0 
34@ = 0 
35@ = 0 
248@ = 0 
36@ = 0 
" + _8189 + @" = 1 
182@ = -2215.58 
183@ = 2391.7 
184@ = 3.965 
174@ = -2185.335 
175@ = 2410.409 
176@ = 3.9752 
177@ = 122.2585 
178@ = -2216.327 
179@ = 2393.209 
180@ = 3.9 
181@ = 238.0 
55@ = 0 
158@ = 0 
159@ = 0 
160@ = 0 
161@ = 0 
162@ = 0 
" + _8195 + @" = 0 
" + _8196 + @" = 0 
169@ = 0 
232@ = 0 
192@ = 0.0 
193@ = 0.0 
194@ = 0.0 
212@ = 12000 
213@ = 12000 
214@ = 10500 
215@ = 9700 
216@ = 40000 
217@ = 40000 
218@ = 37000 
219@ = 33000 
220@ = 120000 
221@ = 120000 
222@ = 85000 
223@ = 80000 
224@ = 55 
225@ = 55 
226@ = 63 
227@ = 67 
228@ = 180000 
229@ = 180000 
230@ = 150000 
231@ = 130000 
0169: set_fade_color_RGB 0 0 0 
wait 0 
Model.Load(#OMOBOAT)
Model.Load(#DINGHY)
Model.Load(#POLMAV)
Model.Load(#COASTG)
Model.Load(#MARQUIS)
Model.Load(#TROPIC)
Model.Load(#VORTEX)
038B: load_requested_models 

:BOAT_981
if or
   not Model.Available(#OMOBOAT)
   not Model.Available(#DINGHY)
   not Model.Available(#POLMAV)
   not Model.Available(#COASTG)
else_jump @BOAT_1023 
wait 0 
jump @BOAT_981 

:BOAT_1023
if or
   not Model.Available(#MARQUIS)
   not Model.Available(#TROPIC)
   not Model.Available(#VORTEX)
else_jump @BOAT_1060 
wait 0 
jump @BOAT_1023 

:BOAT_1060
0390: load_txd_dictionary 'LD_DRV' 
038F: load_texture ""BRONZE"" as 1 
038F: load_texture ""SILVER"" as 2 
038F: load_texture ""GOLD"" as 3 
038F: load_texture ""RIBB"" as 4 
038F: load_texture ""TVCORN"" as 5 
038F: load_texture ""NAWARD"" as 6 
038F: load_texture ""RIBBW"" as 7 
038F: load_texture ""BLKDOT"" as 8 
038F: load_texture ""TVBASE"" as 9 
Actor.PutAt(" + PlayerActor + @", 174@, 175@, 176@)
Actor.Angle(" + PlayerActor + @") = 177@
04D8: set_actor " + PlayerActor + @" drowns_in_water 0 
38@ = Actor.Create(Mission1, #OMOBOAT, 178@, 179@, 180@)
Actor.Angle(38@) = 181@
0568: set_actor 38@ untargetable 1 
if 
  " + _8190 + @" == 0 
else_jump @BOAT_1262 
" + _8190 + @" = 50 

:BOAT_1262
wait 0 
if 
  " + _8190 + @" == 50 
else_jump @BOAT_1316 
jump @BOAT_1323 
if 
   Actor.Dead(38@)
else_jump @BOAT_1316 
03E6: remove_text_box 
jump @BOAT_37691 

:BOAT_1316
jump @BOAT_1262 

:BOAT_1323
0826: enable_hud 0 
0581: enable_radar 0 
Player.CanMove(" + PlayerChar + @") = False
03E6: remove_text_box 
00BE: text_clear_all 
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
gosub @BOAT_19792 
" + _8191 + @" = 0 
" + _8192 + @" = 0 
03F0: enable_text_draw 1 
" + _8194 + @" = 255 
" + _8193 + @" = 2 
if 
  6 > " + _1962 + @" 
else_jump @BOAT_1422 
0084: " + _8189 + @" = " + _1962 + @" 

:BOAT_1422
gosub @BOAT_25116 
0826: enable_hud 0 
0581: enable_radar 0 
select_interior 0 
fade 1 500 

:BOAT_1448
wait 0 
gosub @BOAT_25116 
if 
  34@ == 0 
else_jump @BOAT_1491 
03CF: load_wav 3800 as 3 
34@ = 1 

:BOAT_1491
if 
  34@ == 1 
else_jump @BOAT_1531 
if 
03D0:   wav 3 loaded 
else_jump @BOAT_1531 
34@ = 2 

:BOAT_1531
if 
  34@ == 2 
else_jump @BOAT_1560 
03D1: play_wav 3 
34@ = 3 

:BOAT_1560
set_weather 13 
00C0: set_current_time_hours_to 12 minutes_to 50 
097A: play_audio_at 0.0 0.0 0.0 event 1000 
if 
  " + _8192 + @" == 0 
else_jump @BOAT_2122 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @BOAT_1698 
if 
  " + _1962 + @" > 1 
else_jump @BOAT_1698 
" + _8189 + @" -= 1 
if 
  4 > " + _8191 + @" 
else_jump @BOAT_1698 
" + _8191 + @" = 3 

:BOAT_1698
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @BOAT_1772 
if 
  " + _1962 + @" > 1 
else_jump @BOAT_1772 
" + _8189 + @" += 1 
if 
  4 > " + _8191 + @" 
else_jump @BOAT_1772 
" + _8191 + @" = 3 

:BOAT_1772
if 
  1 > " + _8189 + @" 
else_jump @BOAT_1798 
0084: " + _8189 + @" = " + _1962 + @" 

:BOAT_1798
if 
001C:   " + _8189 + @" > " + _1962 + @" 
else_jump @BOAT_1824 
" + _8189 + @" = 1 

:BOAT_1824
if 
  " + _1962 + @" > 1 
else_jump @BOAT_2016 

:BOAT_1842
if 
  -100 > " + Move_Axis_X + @" 
else_jump @BOAT_1894 
wait 0 
gosub @BOAT_25116 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @BOAT_1842 

:BOAT_1894
if 
  " + Move_Axis_X + @" > 100 
else_jump @BOAT_1946 
wait 0 
gosub @BOAT_25116 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @BOAT_1894 

:BOAT_1946
if 
00E1:   player 0 pressed_key 10 
else_jump @BOAT_1981 
wait 0 
gosub @BOAT_25116 
jump @BOAT_1946 

:BOAT_1981
if 
00E1:   player 0 pressed_key 11 
else_jump @BOAT_2016 
wait 0 
gosub @BOAT_25116 
jump @BOAT_1981 

:BOAT_2016
if 
00E1:   player 0 pressed_key 16 
else_jump @BOAT_2076 
if 
  4 > " + _8191 + @" 
else_jump @BOAT_2058 
" + _8191 + @" = 3 

:BOAT_2058
040D: unload_wav 3 
34@ = 0 
jump @BOAT_2136 

:BOAT_2076
if 
0735:   is_keyboard_key_pressed 81 
else_jump @BOAT_2098 
" + _1962 + @" = 5 

:BOAT_2098
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_2122 
jump @BOAT_37691 

:BOAT_2122
gosub @BOAT_32194 
jump @BOAT_1448 

:BOAT_2136
fade 0 500 

:BOAT_2143
if 
fading 
else_jump @BOAT_2174 
wait 0 
gosub @BOAT_25116 
jump @BOAT_2143 

:BOAT_2174
if 
   not Car.Wrecked(37@)
else_jump @BOAT_2195 
05EC: release_car 37@ from_path 

:BOAT_2195
Camera.Restore_WithJumpCut
Car.Destroy(37@)
Car.Destroy(46@)
Actor.DestroyInstantly(47@)
Actor.DestroyInstantly(39@)
gosub @BOAT_37625 
" + _8191 + @" = 5 
0826: enable_hud 1 
0581: enable_radar 1 
if 
  " + _8189 + @" == 1 
else_jump @BOAT_3803 

:BOAT_2257
gosub @BOAT_34020 

:BOAT_2264
Player.CanMove(" + PlayerChar + @") = True
gosub @BOAT_19792 
46@ = Car.Create(#POLMAV, -3303.627, 2105.29, 200.0)
Actor.DestroyInstantly(47@)
47@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 46@)
248@ = 0 
0687: clear_actor 47@ task 
0825: set_helicopter 46@ instant_rotor_start 
Car.SetMaxSpeed(46@, 250.0)
04A2: set_heli 46@ fly_to -2303.627 2105.29 200.0 altitude_between 200.0 and 200.0 
37@ = Car.Create(#COASTG, -2323.627, 2105.29, 0.0)
0229: set_car 37@ primary_color_to 1 secondary_color_to 114 
Car.Angle(37@) = 90.0
39@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 37@)
gosub @BOAT_34197 
if 
  " + _8191 + @" == 0 
else_jump @BOAT_2488 
067A: put_camera_on_car 46@ with_offset 10.0 10.0 0.0 point_to_car 37@ tilt 0.0 switchstyle 2 
return 

:BOAT_2488
gosub @BOAT_33612 
03E5: show_text_box 'BOAT_H2'  
Player.CanMove(" + PlayerChar + @") = True
52@ = Marker.CreateAboveObject(56@)
51@ = Marker.CreateAboveObject(57@)
53@ = Marker.CreateAboveObject(62@)
54@ = Marker.CreateAboveObject(63@)
Marker.SetColor(52@, 4)
Marker.SetColor(51@, 4)
Marker.SetColor(53@, 4)
Marker.SetColor(54@, 4)
if 
   not Car.Wrecked(37@)
else_jump @BOAT_2637 
Car.StorePos(37@, 185@, 186@, 187@)
0087: 192@ = 185@ 
192@ -= 195.0 
0087: 193@ = 186@ 
0087: 194@ = 187@ 

:BOAT_2637
wait 0 
if 
   not Car.Wrecked(46@)
else_jump @BOAT_2731 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_2731 
Car.StorePos(37@, 185@, 186@, 187@)
185@ -= 150.0 
186@ -= 150.0 
04A2: set_heli 46@ fly_to 185@ 186@ 187@ altitude_between 120.0 and 120.0 

:BOAT_2731
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_2762 
164@ = 2 
jump @BOAT_3743 

:BOAT_2762
gosub @BOAT_20340 
if 
  164@ == 1 
else_jump @BOAT_2794 
jump @BOAT_37691 

:BOAT_2794
if 
  158@ == 0 
else_jump @BOAT_2971 
00BC: show_text_highpriority GXT 'BOAT_A4' time 5000 flag 1  
if 
   not Car.Wrecked(37@)
else_jump @BOAT_2852 
250@ = Car.Health(37@)

:BOAT_2852
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @BOAT_2971 
0971: sync_water 
0085: 211@ = 215@ 
0085: 210@ = 214@ 
0085: 209@ = 213@ 
158@ = 1 
" + _8197 + @" = 0 
014F: stop_timer " + _8197 + @" 
03C3: set_timer_to " + _8197 + @" type 0 GXT 'BOAT_T1' 
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
32@ = 0 

:BOAT_2971
if 
  158@ == 1 
else_jump @BOAT_3267 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_3221 
02E3: 49@ = car 37@ speed 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle -30.0 sphere 0 in_car 
else_jump @BOAT_3110 
00BC: show_text_highpriority GXT 'BOAT_32' time 4000 flag 1  
if 
  7.0 > 49@ 
else_jump @BOAT_3110 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BOAT_33' time 4000 flag 1  
158@ = 99 

:BOAT_3110
if 
  32@ > 4500 
else_jump @BOAT_3166 
if 
85F8:   not actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle -30.0 sphere 0 in_car 
else_jump @BOAT_3166 
00BE: text_clear_all 

:BOAT_3166
if 
  248@ == 0 
else_jump @BOAT_3221 
if 
  32@ > 4500 
else_jump @BOAT_3221 
248@ = 1 
03E5: show_text_box 'BOAT_A5'  

:BOAT_3221
if 
  " + _8197 + @" > 60000 
else_jump @BOAT_3267 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BOAT_34' time 4000 flag 1  
158@ = 99 

:BOAT_3267
if 
  158@ == 99 
else_jump @BOAT_3796 
gosub @BOAT_20088 
gosub @BOAT_20416 
if 
001E:   " + _1963 + @" > 168@ 
else_jump @BOAT_3505 
008B: 169@ = " + _1963 + @" 
008A: " + _1963 + @" = 168@ 
167@ = 1 
gosub @BOAT_21188 
if 
  " + _8195 + @" == 4 
else_jump @BOAT_3405 
if 
  " + _1972 + @" == 0 
else_jump @BOAT_3405 
" + _1972 + @" = 1 
" + _1971 + @" = 1 
" + _1970 + @" = 1 

:BOAT_3405
if 
  " + _8195 + @" == 3 
else_jump @BOAT_3455 
if 
  " + _1971 + @" == 0 
else_jump @BOAT_3455 
" + _1971 + @" = 1 
" + _1970 + @" = 1 

:BOAT_3455
if 
  " + _8195 + @" == 2 
else_jump @BOAT_3498 
if 
  " + _1970 + @" == 0 
else_jump @BOAT_3498 
" + _1970 + @" = 1 

:BOAT_3498
jump @BOAT_3512 

:BOAT_3505
" + _8195 + @" = 0 

:BOAT_3512
if 
  " + _1962 + @" == 1 
else_jump @BOAT_3590 
if 
001D:   212@ > 168@ 
else_jump @BOAT_3590 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1097 
167@ = 2 
" + _1962 + @" = 2 
164@ = 2 

:BOAT_3590
32@ = 0 

:BOAT_3597
if 
  32@ > -1 
else_jump @BOAT_3743 
wait 0 
gosub @BOAT_20759 
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_3677 
164@ = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_3743 

:BOAT_3677
gosub @BOAT_21719 
gosub @BOAT_20005 
if 
  165@ == 1 
else_jump @BOAT_3736 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_3743 

:BOAT_3736
jump @BOAT_3597 

:BOAT_3743
gosub @BOAT_24852 
gosub @BOAT_37625 
if 
  164@ == 2 
else_jump @BOAT_3789 
jump @BOAT_1323 
jump @BOAT_3796 

:BOAT_3789
jump @BOAT_2257 

:BOAT_3796
jump @BOAT_2637 

:BOAT_3803
if 
  " + _8189 + @" == 2 
else_jump @BOAT_6502 

:BOAT_3821
gosub @BOAT_34020 

:BOAT_3828
Player.CanMove(" + PlayerChar + @") = True
gosub @BOAT_19792 
46@ = Car.Create(#POLMAV, -2303.627, 2105.29, 200.0)
Actor.DestroyInstantly(47@)
47@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 46@)
0687: clear_actor 47@ task 
0825: set_helicopter 46@ instant_rotor_start 
Car.SetMaxSpeed(46@, 250.0)
04A2: set_heli 46@ fly_to -2303.627 2105.29 200.0 altitude_between 200.0 and 200.0 
37@ = Car.Create(#COASTG, -2578.671, 2050.845, 0.0)
0229: set_car 37@ primary_color_to 1 secondary_color_to 114 
Car.Angle(37@) = 0.0
39@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 37@)
gosub @BOAT_34197 
if 
  " + _8191 + @" == 0 
else_jump @BOAT_4045 
067A: put_camera_on_car 46@ with_offset 10.0 10.0 0.0 point_to_car 37@ tilt 0.0 switchstyle 2 
return 

:BOAT_4045
gosub @BOAT_33612 
03E5: show_text_box 'BOAT_H2'  
Player.CanMove(" + PlayerChar + @") = True
if 
   not Car.Wrecked(37@)
else_jump @BOAT_4181 
Car.StorePos(37@, 185@, 186@, 187@)
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(56@)
Marker.SetColor(52@, 4)
51@ = Marker.CreateAboveObject(57@)
Marker.SetColor(51@, 4)
53@ = Marker.CreateAboveObject(58@)
54@ = Marker.CreateAboveObject(59@)
gosub @BOAT_34153 

:BOAT_4181
wait 0 
if 
   not Car.Wrecked(46@)
else_jump @BOAT_4275 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_4275 
Car.StorePos(37@, 185@, 186@, 187@)
185@ -= 150.0 
186@ -= 150.0 
04A2: set_heli 46@ fly_to 185@ 186@ 187@ altitude_between 200.0 and 200.0 

:BOAT_4275
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_4306 
164@ = 2 
jump @BOAT_6442 

:BOAT_4306
gosub @BOAT_20340 
if 
  164@ == 1 
else_jump @BOAT_4338 
jump @BOAT_37691 

:BOAT_4338
if 
  159@ == 0 
else_jump @BOAT_4456 
00BC: show_text_highpriority GXT 'BOAT_B4' time 4000 flag 1  
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @BOAT_4456 
0971: sync_water 
0085: 211@ = 219@ 
0085: 210@ = 218@ 
0085: 209@ = 217@ 
159@ = 5 
" + _8197 + @" = 0 
014F: stop_timer " + _8197 + @" 
03C3: set_timer_to " + _8197 + @" type 0 GXT 'BOAT_T1' 

:BOAT_4456
if 
  159@ > 0 
else_jump @BOAT_4502 
if 
  " + _8197 + @" > 600000 
else_jump @BOAT_4502 
159@ = 99 

:BOAT_4502
if 
  159@ == 5 
else_jump @BOAT_4708 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_4708 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_4708 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
03E6: remove_text_box 
03E5: show_text_box 'BOAT_B5'  
159@ = 10 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(58@, 198@, 199@, 200@)
Object.StorePos(59@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(58@)
51@ = Marker.CreateAboveObject(59@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(60@)
54@ = Marker.CreateAboveObject(61@)
gosub @BOAT_34153 

:BOAT_4708
if 
  159@ == 10 
else_jump @BOAT_4901 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_4901 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_4901 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
159@ = 15 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(60@, 198@, 199@, 200@)
Object.StorePos(61@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(60@)
51@ = Marker.CreateAboveObject(61@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(62@)
54@ = Marker.CreateAboveObject(63@)
gosub @BOAT_34153 

:BOAT_4901
if 
  159@ == 15 
else_jump @BOAT_5094 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_5094 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_5094 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
159@ = 20 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(62@, 198@, 199@, 200@)
Object.StorePos(63@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(62@)
51@ = Marker.CreateAboveObject(63@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(64@)
54@ = Marker.CreateAboveObject(65@)
gosub @BOAT_34153 

:BOAT_5094
if 
  159@ == 20 
else_jump @BOAT_5287 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_5287 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_5287 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
159@ = 25 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(64@, 198@, 199@, 200@)
Object.StorePos(65@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(64@)
51@ = Marker.CreateAboveObject(65@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(66@)
54@ = Marker.CreateAboveObject(67@)
gosub @BOAT_34153 

:BOAT_5287
if 
  159@ == 25 
else_jump @BOAT_5480 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_5480 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_5480 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
159@ = 30 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(66@, 198@, 199@, 200@)
Object.StorePos(67@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(66@)
51@ = Marker.CreateAboveObject(67@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(68@)
54@ = Marker.CreateAboveObject(69@)
gosub @BOAT_34153 

:BOAT_5480
if 
  159@ == 30 
else_jump @BOAT_5673 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_5673 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_5673 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
159@ = 35 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(68@, 198@, 199@, 200@)
Object.StorePos(69@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(68@)
51@ = Marker.CreateAboveObject(69@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(70@)
54@ = Marker.CreateAboveObject(71@)
gosub @BOAT_34153 

:BOAT_5673
if 
  159@ == 35 
else_jump @BOAT_5850 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_5850 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_5850 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
159@ = 40 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(70@, 198@, 199@, 200@)
Object.StorePos(71@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(70@)
51@ = Marker.CreateAboveObject(71@)
Marker.Disable(53@)
Marker.Disable(54@)
gosub @BOAT_34153 

:BOAT_5850
if 
  159@ == 40 
else_jump @BOAT_5966 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_5966 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_5966 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_33' time 1000 flag 1  
159@ = 99 
Marker.Disable(52@)
Marker.Disable(51@)

:BOAT_5966
if 
  159@ == 99 
else_jump @BOAT_6495 
gosub @BOAT_20088 
gosub @BOAT_20416 
if 
001E:   " + _1964 + @" > 168@ 
else_jump @BOAT_6204 
008B: 169@ = " + _1964 + @" 
008A: " + _1964 + @" = 168@ 
167@ = 1 
gosub @BOAT_21188 
if 
  " + _8195 + @" == 4 
else_jump @BOAT_6104 
if 
  " + _1975 + @" == 0 
else_jump @BOAT_6104 
" + _1975 + @" = 1 
" + _1974 + @" = 1 
" + _1973 + @" = 1 

:BOAT_6104
if 
  " + _8195 + @" == 3 
else_jump @BOAT_6154 
if 
  " + _1974 + @" == 0 
else_jump @BOAT_6154 
" + _1974 + @" = 1 
" + _1973 + @" = 1 

:BOAT_6154
if 
  " + _8195 + @" == 2 
else_jump @BOAT_6197 
if 
  " + _1973 + @" == 0 
else_jump @BOAT_6197 
" + _1973 + @" = 1 

:BOAT_6197
jump @BOAT_6211 

:BOAT_6204
" + _8195 + @" = 0 

:BOAT_6211
if 
  " + _1962 + @" == 2 
else_jump @BOAT_6289 
if 
001D:   216@ > 168@ 
else_jump @BOAT_6289 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1097 
167@ = 2 
" + _1962 + @" = 3 
164@ = 2 

:BOAT_6289
32@ = 0 

:BOAT_6296
if 
  32@ > -1 
else_jump @BOAT_6442 
wait 0 
gosub @BOAT_20759 
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_6376 
164@ = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_6442 

:BOAT_6376
gosub @BOAT_21719 
gosub @BOAT_20005 
if 
  165@ == 1 
else_jump @BOAT_6435 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_6442 

:BOAT_6435
jump @BOAT_6296 

:BOAT_6442
gosub @BOAT_24852 
gosub @BOAT_37625 
if 
  164@ == 2 
else_jump @BOAT_6488 
jump @BOAT_1323 
jump @BOAT_6495 

:BOAT_6488
jump @BOAT_3821 

:BOAT_6495
jump @BOAT_4181 

:BOAT_6502
if 
  " + _8189 + @" == 3 
else_jump @BOAT_10905 

:BOAT_6520
gosub @BOAT_34020 

:BOAT_6527
Player.CanMove(" + PlayerChar + @") = True
gosub @BOAT_19792 
46@ = Car.Create(#POLMAV, -2303.627, 2105.29, 200.0)
Actor.DestroyInstantly(47@)
47@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 46@)
0687: clear_actor 47@ task 
0825: set_helicopter 46@ instant_rotor_start 
Car.SetMaxSpeed(46@, 250.0)
04A2: set_heli 46@ fly_to -2303.627 2105.29 200.0 altitude_between 200.0 and 200.0 
37@ = Car.Create(#DINGHY, -2124.125, 2438.352, 0.0)
0229: set_car 37@ primary_color_to 114 secondary_color_to 1 
Car.Angle(37@) = 180.0
39@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 37@)
gosub @BOAT_34197 
if 
  " + _8191 + @" == 0 
else_jump @BOAT_6744 
067A: put_camera_on_car 46@ with_offset 10.0 10.0 0.0 point_to_car 37@ tilt 0.0 switchstyle 2 
return 

:BOAT_6744
gosub @BOAT_33612 
03E5: show_text_box 'BOAT_H2'  
Player.CanMove(" + PlayerChar + @") = True
if 
   not Car.Wrecked(37@)
else_jump @BOAT_6880 
Car.StorePos(37@, 185@, 186@, 187@)
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(56@)
51@ = Marker.CreateAboveObject(57@)
Marker.SetColor(52@, 4)
Marker.SetColor(51@, 4)
53@ = Marker.CreateAboveObject(58@)
54@ = Marker.CreateAboveObject(59@)
gosub @BOAT_34153 

:BOAT_6880
35@ = 0 

:BOAT_6887
wait 0 
if 
  35@ == 0 
else_jump @BOAT_6923 
03CF: load_wav 6200 as 3 
35@ = 1 

:BOAT_6923
if 
  35@ == 1 
else_jump @BOAT_6963 
if 
03D0:   wav 3 loaded 
else_jump @BOAT_6963 
35@ = 2 

:BOAT_6963
if 
   not Car.Wrecked(46@)
else_jump @BOAT_7053 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_7053 
Car.StorePos(37@, 185@, 186@, 187@)
185@ -= 150.0 
186@ -= 150.0 
04A2: set_heli 46@ fly_to 185@ 186@ 187@ altitude_between 200.0 and 200.0 

:BOAT_7053
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_7084 
164@ = 2 
jump @BOAT_10845 

:BOAT_7084
gosub @BOAT_20340 
if 
  164@ == 1 
else_jump @BOAT_7116 
jump @BOAT_37691 

:BOAT_7116
if 
  160@ == 0 
else_jump @BOAT_7250 
00BC: show_text_highpriority GXT 'BOAT_C1' time 4000 flag 1  
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @BOAT_7250 
0971: sync_water 
0085: 211@ = 223@ 
0085: 210@ = 222@ 
0085: 209@ = 221@ 
097A: play_audio_at 198@ 199@ 200@ event 65535 
160@ = 5 
" + _8197 + @" = 0 
014F: stop_timer " + _8197 + @" 
03C3: set_timer_to " + _8197 + @" type 0 GXT 'BOAT_T1' 

:BOAT_7250
if 
  160@ > 0 
else_jump @BOAT_7296 
if 
  " + _8197 + @" > 600000 
else_jump @BOAT_7296 
160@ = 99 

:BOAT_7296
if 
  160@ == 5 
else_jump @BOAT_7489 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_7489 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_7489 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 10 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(58@, 198@, 199@, 200@)
Object.StorePos(59@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(58@)
51@ = Marker.CreateAboveObject(59@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(60@)
54@ = Marker.CreateAboveObject(61@)
gosub @BOAT_34153 

:BOAT_7489
if 
  160@ == 10 
else_jump @BOAT_7682 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_7682 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_7682 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 15 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(60@, 198@, 199@, 200@)
Object.StorePos(61@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(60@)
51@ = Marker.CreateAboveObject(61@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(62@)
54@ = Marker.CreateAboveObject(63@)
gosub @BOAT_34153 

:BOAT_7682
if 
  160@ == 15 
else_jump @BOAT_7963 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_7963 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_7963 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 20 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(62@, 198@, 199@, 200@)
Object.StorePos(63@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(62@)
51@ = Marker.CreateAboveObject(63@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(64@)
54@ = Marker.CreateAboveObject(65@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(44@)
else_jump @BOAT_7963 
if 
   not Actor.Dead(45@)
else_jump @BOAT_7963 
if 
  35@ == 2 
else_jump @BOAT_7929 
03D1: play_wav 3 

:BOAT_7929
05D1: AS_actor 45@ drive_car 44@ to -2013.476 1748.499 0.0 speed 18.0 2 model #NULL 3 

:BOAT_7963
if 
  160@ == 20 
else_jump @BOAT_8156 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_8156 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_8156 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 25 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(64@, 198@, 199@, 200@)
Object.StorePos(65@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(64@)
51@ = Marker.CreateAboveObject(65@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(66@)
54@ = Marker.CreateAboveObject(67@)
gosub @BOAT_34153 

:BOAT_8156
if 
  160@ == 25 
else_jump @BOAT_8349 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_8349 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_8349 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 30 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(66@, 198@, 199@, 200@)
Object.StorePos(67@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(66@)
51@ = Marker.CreateAboveObject(67@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(68@)
54@ = Marker.CreateAboveObject(69@)
gosub @BOAT_34153 

:BOAT_8349
if 
  160@ == 30 
else_jump @BOAT_8542 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_8542 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_8542 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 35 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(68@, 198@, 199@, 200@)
Object.StorePos(69@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(68@)
51@ = Marker.CreateAboveObject(69@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(70@)
54@ = Marker.CreateAboveObject(71@)
gosub @BOAT_34153 

:BOAT_8542
if 
  160@ == 35 
else_jump @BOAT_8735 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_8735 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_8735 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 40 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(70@, 198@, 199@, 200@)
Object.StorePos(71@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(70@)
51@ = Marker.CreateAboveObject(71@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(72@)
54@ = Marker.CreateAboveObject(73@)
gosub @BOAT_34153 

:BOAT_8735
if 
  160@ == 40 
else_jump @BOAT_8928 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_8928 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_8928 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 45 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(72@, 198@, 199@, 200@)
Object.StorePos(73@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(72@)
51@ = Marker.CreateAboveObject(73@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(74@)
54@ = Marker.CreateAboveObject(75@)
gosub @BOAT_34153 

:BOAT_8928
if 
  160@ == 45 
else_jump @BOAT_9121 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_9121 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_9121 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 50 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(74@, 198@, 199@, 200@)
Object.StorePos(75@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(74@)
51@ = Marker.CreateAboveObject(75@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(76@)
54@ = Marker.CreateAboveObject(77@)
gosub @BOAT_34153 

:BOAT_9121
if 
  160@ == 50 
else_jump @BOAT_9314 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_9314 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_9314 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 55 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(76@, 198@, 199@, 200@)
Object.StorePos(77@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(76@)
51@ = Marker.CreateAboveObject(77@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(78@)
54@ = Marker.CreateAboveObject(79@)
gosub @BOAT_34153 

:BOAT_9314
if 
  160@ == 55 
else_jump @BOAT_9507 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_9507 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_9507 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 60 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(78@, 198@, 199@, 200@)
Object.StorePos(79@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(78@)
51@ = Marker.CreateAboveObject(79@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(80@)
54@ = Marker.CreateAboveObject(81@)
gosub @BOAT_34153 

:BOAT_9507
if 
  160@ == 60 
else_jump @BOAT_9788 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_9788 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_9788 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 65 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(80@, 198@, 199@, 200@)
Object.StorePos(81@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(80@)
51@ = Marker.CreateAboveObject(81@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(82@)
54@ = Marker.CreateAboveObject(83@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(41@)
else_jump @BOAT_9788 
if 
   not Actor.Dead(43@)
else_jump @BOAT_9788 
if 
  35@ == 2 
else_jump @BOAT_9754 
03D1: play_wav 3 

:BOAT_9754
05D1: AS_actor 43@ drive_car 41@ to -2763.105 1954.129 0.0 speed 10.0 2 model #NULL 3 

:BOAT_9788
if 
  160@ == 65 
else_jump @BOAT_10069 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_10069 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_10069 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 70 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(82@, 198@, 199@, 200@)
Object.StorePos(83@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(82@)
51@ = Marker.CreateAboveObject(83@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(56@)
54@ = Marker.CreateAboveObject(57@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_10069 
if 
   not Actor.Dead(42@)
else_jump @BOAT_10069 
if 
  35@ == 2 
else_jump @BOAT_10035 
03D1: play_wav 3 

:BOAT_10035
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_10069
if 
  160@ == 70 
else_jump @BOAT_10253 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_10253 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_10253 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
160@ = 80 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(56@)
51@ = Marker.CreateAboveObject(57@)
Marker.SetColor(52@, 4)
Marker.SetColor(51@, 4)
Marker.Disable(53@)
Marker.Disable(54@)

:BOAT_10253
if 
  160@ == 80 
else_jump @BOAT_10369 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_10369 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_10369 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_33' time 1000 flag 1  
160@ = 99 
Marker.Disable(52@)
Marker.Disable(51@)

:BOAT_10369
if 
  160@ == 99 
else_jump @BOAT_10898 
gosub @BOAT_20088 
gosub @BOAT_20416 
if 
001E:   " + _1965 + @" > 168@ 
else_jump @BOAT_10607 
008B: 169@ = " + _1965 + @" 
008A: " + _1965 + @" = 168@ 
167@ = 1 
gosub @BOAT_21188 
if 
  " + _8195 + @" == 4 
else_jump @BOAT_10507 
if 
  " + _1978 + @" == 0 
else_jump @BOAT_10507 
" + _1978 + @" = 1 
" + _1977 + @" = 1 
" + _1976 + @" = 1 

:BOAT_10507
if 
  " + _8195 + @" == 3 
else_jump @BOAT_10557 
if 
  " + _1977 + @" == 0 
else_jump @BOAT_10557 
" + _1977 + @" = 1 
" + _1976 + @" = 1 

:BOAT_10557
if 
  " + _8195 + @" == 2 
else_jump @BOAT_10600 
if 
  " + _1976 + @" == 0 
else_jump @BOAT_10600 
" + _1976 + @" = 1 

:BOAT_10600
jump @BOAT_10614 

:BOAT_10607
" + _8195 + @" = 0 

:BOAT_10614
if 
  " + _1962 + @" == 3 
else_jump @BOAT_10692 
if 
001D:   220@ > 168@ 
else_jump @BOAT_10692 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1097 
167@ = 2 
" + _1962 + @" = 4 
164@ = 2 

:BOAT_10692
32@ = 0 

:BOAT_10699
if 
  32@ > -1 
else_jump @BOAT_10845 
wait 0 
gosub @BOAT_20759 
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_10779 
164@ = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_10845 

:BOAT_10779
gosub @BOAT_21719 
gosub @BOAT_20005 
if 
  165@ == 1 
else_jump @BOAT_10838 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_10845 

:BOAT_10838
jump @BOAT_10699 

:BOAT_10845
gosub @BOAT_24852 
gosub @BOAT_37625 
if 
  164@ == 2 
else_jump @BOAT_10891 
jump @BOAT_1323 
jump @BOAT_10898 

:BOAT_10891
jump @BOAT_6520 

:BOAT_10898
jump @BOAT_6887 

:BOAT_10905
if 
  " + _8189 + @" == 4 
else_jump @BOAT_12785 

:BOAT_10923
gosub @BOAT_34020 

:BOAT_10930
Player.CanMove(" + PlayerChar + @") = True
gosub @BOAT_19792 
46@ = Car.Create(#POLMAV, -3303.627, 2105.29, 200.0)
Actor.DestroyInstantly(47@)
47@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 46@)
0687: clear_actor 47@ task 
0825: set_helicopter 46@ instant_rotor_start 
Car.SetMaxSpeed(46@, 250.0)
04A2: set_heli 46@ fly_to -2303.627 2105.29 200.0 altitude_between 200.0 and 200.0 
37@ = Car.Create(#VORTEX, -2584.316, 2213.475, 0.0)
0229: set_car 37@ primary_color_to 78 secondary_color_to 14 
Car.Angle(37@) = 250.0
39@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 37@)
gosub @BOAT_34197 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_11143 
Car.PutAt(37@, -2318.049, 2312.302, 10.0)
Car.Angle(37@) = 174.6078

:BOAT_11143
if 
  " + _8191 + @" == 0 
else_jump @BOAT_11193 
067A: put_camera_on_car 46@ with_offset 10.0 10.0 0.0 point_to_car 37@ tilt 0.0 switchstyle 2 
return 

:BOAT_11193
gosub @BOAT_33612 
03E5: show_text_box 'BOAT_H2'  
Player.CanMove(" + PlayerChar + @") = True
if 
   not Car.Wrecked(37@)
else_jump @BOAT_11294 
192@ = 0.0 
193@ = 0.0 
194@ = 0.0 
201@ = 0.0 
202@ = 0.0 
203@ = 0.0 

:BOAT_11294
wait 0 
if 
   not Car.Wrecked(46@)
else_jump @BOAT_11388 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_11388 
Car.StorePos(37@, 185@, 186@, 187@)
185@ -= 150.0 
186@ -= 150.0 
04A2: set_heli 46@ fly_to 185@ 186@ 187@ altitude_between 120.0 and 120.0 

:BOAT_11388
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_11419 
164@ = 2 
jump @BOAT_12725 

:BOAT_11419
gosub @BOAT_20340 
if 
  164@ == 1 
else_jump @BOAT_11451 
jump @BOAT_37691 

:BOAT_11451
if 
  161@ == 0 
else_jump @BOAT_11656 
00BC: show_text_highpriority GXT 'BOAT_D1' time 4000 flag 1  
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @BOAT_11656 
0971: sync_water 
0085: 211@ = 227@ 
0085: 210@ = 226@ 
0085: 209@ = 225@ 
014F: stop_timer " + _8197 + @" 
" + _8197 + @" = 46000 
161@ = 1 
03C3: set_timer_to " + _8197 + @" type 1 GXT 'BOAT_T1' 
Marker.Disable(52@)
Marker.Disable(51@)
52@ = Marker.CreateAboveObject(56@)
51@ = Marker.CreateAboveObject(57@)
Marker.SetColor(52@, 4)
Marker.SetColor(51@, 4)
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
097A: play_audio_at 198@ 199@ 200@ event 65535 

:BOAT_11656
if 
  161@ == 1 
else_jump @BOAT_11809 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_11809 
if 
05FE:   actor " + PlayerActor + @" in_cube_fll_corner_at 198@ 199@ 1.0 fur_corner_at 195@ 196@ 3.0 depth 10.0 flag 0 in_car 
else_jump @BOAT_11809 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
Marker.Disable(52@)
Marker.Disable(51@)
02E3: 49@ = car 37@ speed 
161@ = 2 
Object.StorePos(58@, 198@, 199@, 200@)
Object.StorePos(59@, 195@, 196@, 197@)
33@ = 0 

:BOAT_11809
if 
  161@ == 2 
else_jump @BOAT_12009 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_12009 
if 
  33@ > 1000 
else_jump @BOAT_12009 
Car.StorePos(37@, 192@, 193@, 194@)
if 
  1.0 > 194@ 
else_jump @BOAT_12009 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 600.0 sphere 0 in_car 
else_jump @BOAT_11960 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
161@ = 3 
33@ = 0 

:BOAT_11960
if 
85F8:   not actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 600.0 sphere 0 in_car 
else_jump @BOAT_12009 
161@ = 4 
33@ = 0 

:BOAT_12009
if 
  161@ == 3 
else_jump @BOAT_12095 
Object.StorePos(106@, 201@, 202@, 203@)
0509: 246@ = distance_between_XY 201@ 202@ and_XY 192@ 193@ 

:BOAT_12058
if 
  1000 > 33@ 
else_jump @BOAT_12088 
wait 0 
jump @BOAT_12058 

:BOAT_12088
161@ = 99 

:BOAT_12095
if 
  161@ == 4 
else_jump @BOAT_12160 

:BOAT_12113
if 
  1000 > 33@ 
else_jump @BOAT_12143 
wait 0 
jump @BOAT_12113 

:BOAT_12143
246@ = 0.0 
161@ = 99 

:BOAT_12160
if 
  161@ > 0 
else_jump @BOAT_12233 
if 
  1 > " + _8197 + @" 
else_jump @BOAT_12233 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BOAT_34' time 4000 flag 1  
161@ = 99 
wait 3000 
jump @BOAT_12725 

:BOAT_12233
if 
  161@ == 99 
else_jump @BOAT_12778 
gosub @BOAT_20088 
gosub @BOAT_20416 
if or
001F:   168@ > " + _1966 + @" 
001F:   168@ > " + _1966 + @" 
else_jump @BOAT_12479 
008B: 169@ = " + _1966 + @" 
008A: " + _1966 + @" = 168@ 
167@ = 1 
gosub @BOAT_21188 
if 
  " + _8195 + @" == 4 
else_jump @BOAT_12379 
if 
  " + _1981 + @" == 0 
else_jump @BOAT_12379 
" + _1981 + @" = 1 
" + _1980 + @" = 1 
" + _1979 + @" = 1 

:BOAT_12379
if 
  " + _8195 + @" == 3 
else_jump @BOAT_12429 
if 
  " + _1980 + @" == 0 
else_jump @BOAT_12429 
" + _1980 + @" = 1 
" + _1979 + @" = 1 

:BOAT_12429
if 
  " + _8195 + @" == 2 
else_jump @BOAT_12472 
if 
  " + _1979 + @" == 0 
else_jump @BOAT_12472 
" + _1979 + @" = 1 

:BOAT_12472
jump @BOAT_12486 

:BOAT_12479
" + _8195 + @" = 0 

:BOAT_12486
if 
  " + _1962 + @" == 4 
else_jump @BOAT_12572 
if or
001D:   168@ > 224@ 
003B:   168@ == 224@ 
else_jump @BOAT_12572 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1097 
167@ = 2 
" + _1962 + @" = 5 
164@ = 2 

:BOAT_12572
32@ = 0 

:BOAT_12579
if 
  32@ > -1 
else_jump @BOAT_12725 
wait 0 
gosub @BOAT_20759 
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_12659 
164@ = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_12725 

:BOAT_12659
gosub @BOAT_21719 
gosub @BOAT_20005 
if 
  165@ == 1 
else_jump @BOAT_12718 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_12725 

:BOAT_12718
jump @BOAT_12579 

:BOAT_12725
gosub @BOAT_24852 
gosub @BOAT_37625 
if 
  164@ == 2 
else_jump @BOAT_12771 
jump @BOAT_1323 
jump @BOAT_12778 

:BOAT_12771
jump @BOAT_10923 

:BOAT_12778
jump @BOAT_11294 

:BOAT_12785
if 
  " + _8189 + @" == 5 
else_jump @BOAT_19792 

:BOAT_12803
gosub @BOAT_34020 

:BOAT_12810
Player.CanMove(" + PlayerChar + @") = True
gosub @BOAT_19792 
46@ = Car.Create(#POLMAV, -2303.627, 2105.29, 200.0)
Actor.DestroyInstantly(47@)
47@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 46@)
0687: clear_actor 47@ task 
0825: set_helicopter 46@ instant_rotor_start 
Car.SetMaxSpeed(46@, 250.0)
04A2: set_heli 46@ fly_to -2303.627 2105.29 200.0 altitude_between 200.0 and 200.0 
37@ = Car.Create(#VORTEX, -2014.267, 2365.429, 6.0509)
0229: set_car 37@ primary_color_to 6 secondary_color_to 2 
Car.Angle(37@) = 111.0
39@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 37@)
gosub @BOAT_34197 
if 
  " + _8191 + @" == 0 
else_jump @BOAT_13027 
067A: put_camera_on_car 46@ with_offset 10.0 10.0 0.0 point_to_car 37@ tilt 0.0 switchstyle 2 
return 

:BOAT_13027
gosub @BOAT_33612 
03E5: show_text_box 'BOAT_H2'  
Player.CanMove(" + PlayerChar + @") = True
if 
   not Car.Wrecked(37@)
else_jump @BOAT_13156 
Car.StorePos(37@, 185@, 186@, 187@)
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(56@)
51@ = Marker.CreateAboveObject(57@)
53@ = Marker.CreateAboveObject(58@)
54@ = Marker.CreateAboveObject(59@)
gosub @BOAT_34153 
Car.LockInCurrentPosition(37@) = True

:BOAT_13156
35@ = 0 

:BOAT_13163
wait 0 
if 
  35@ == 0 
else_jump @BOAT_13199 
03CF: load_wav 6200 as 3 
35@ = 1 

:BOAT_13199
if 
  35@ == 1 
else_jump @BOAT_13239 
if 
03D0:   wav 3 loaded 
else_jump @BOAT_13239 
35@ = 2 

:BOAT_13239
if 
0735:   is_keyboard_key_pressed 87 
else_jump @BOAT_13261 
162@ = 99 

:BOAT_13261
if 
   not Car.Wrecked(46@)
else_jump @BOAT_13351 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_13351 
Car.StorePos(37@, 185@, 186@, 187@)
185@ -= 150.0 
186@ -= 150.0 
04A2: set_heli 46@ fly_to 185@ 186@ 187@ altitude_between 200.0 and 200.0 

:BOAT_13351
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_13382 
164@ = 2 
jump @BOAT_19598 

:BOAT_13382
gosub @BOAT_20340 
if 
  164@ == 1 
else_jump @BOAT_13414 
jump @BOAT_37691 

:BOAT_13414
if 
  162@ == 0 
else_jump @BOAT_13555 
00BC: show_text_highpriority GXT 'BOAT_C1' time 4000 flag 1  
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @BOAT_13555 
0971: sync_water 
0085: 211@ = 231@ 
0085: 210@ = 230@ 
0085: 209@ = 229@ 
097A: play_audio_at 198@ 199@ 200@ event 65535 
162@ = 5 
" + _8197 + @" = 0 
014F: stop_timer " + _8197 + @" 
03C3: set_timer_to " + _8197 + @" type 0 GXT 'BOAT_T1' 
Car.LockInCurrentPosition(37@) = False

:BOAT_13555
if 
  162@ > 0 
else_jump @BOAT_13601 
if 
  " + _8197 + @" > 600000 
else_jump @BOAT_13601 
162@ = 99 

:BOAT_13601
if 
  162@ == 5 
else_jump @BOAT_13794 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_13794 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_13794 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 10 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(58@, 198@, 199@, 200@)
Object.StorePos(59@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(58@)
51@ = Marker.CreateAboveObject(59@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(60@)
54@ = Marker.CreateAboveObject(61@)
gosub @BOAT_34153 

:BOAT_13794
if 
  162@ == 10 
else_jump @BOAT_13987 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_13987 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_13987 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 15 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(60@, 198@, 199@, 200@)
Object.StorePos(61@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(60@)
51@ = Marker.CreateAboveObject(61@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(62@)
54@ = Marker.CreateAboveObject(63@)
gosub @BOAT_34153 

:BOAT_13987
if 
  162@ == 15 
else_jump @BOAT_14180 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_14180 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_14180 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 20 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(62@, 198@, 199@, 200@)
Object.StorePos(63@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(62@)
51@ = Marker.CreateAboveObject(63@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(64@)
54@ = Marker.CreateAboveObject(65@)
gosub @BOAT_34153 

:BOAT_14180
if 
  162@ == 20 
else_jump @BOAT_14373 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_14373 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_14373 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 25 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(64@, 198@, 199@, 200@)
Object.StorePos(65@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(64@)
51@ = Marker.CreateAboveObject(65@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(66@)
54@ = Marker.CreateAboveObject(67@)
gosub @BOAT_34153 

:BOAT_14373
if 
  162@ == 25 
else_jump @BOAT_14566 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_14566 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_14566 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 30 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(66@, 198@, 199@, 200@)
Object.StorePos(67@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(66@)
51@ = Marker.CreateAboveObject(67@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(68@)
54@ = Marker.CreateAboveObject(69@)
gosub @BOAT_34153 

:BOAT_14566
if 
  162@ == 30 
else_jump @BOAT_14759 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_14759 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_14759 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 35 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(68@, 198@, 199@, 200@)
Object.StorePos(69@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(68@)
51@ = Marker.CreateAboveObject(69@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(70@)
54@ = Marker.CreateAboveObject(71@)
gosub @BOAT_34153 

:BOAT_14759
if 
  162@ == 35 
else_jump @BOAT_14952 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_14952 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_14952 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 40 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(70@, 198@, 199@, 200@)
Object.StorePos(71@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(70@)
51@ = Marker.CreateAboveObject(71@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(72@)
54@ = Marker.CreateAboveObject(73@)
gosub @BOAT_34153 

:BOAT_14952
if 
  162@ == 40 
else_jump @BOAT_15145 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_15145 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_15145 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 45 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(72@, 198@, 199@, 200@)
Object.StorePos(73@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(72@)
51@ = Marker.CreateAboveObject(73@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(74@)
54@ = Marker.CreateAboveObject(75@)
gosub @BOAT_34153 

:BOAT_15145
if 
  162@ == 45 
else_jump @BOAT_15338 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_15338 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_15338 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 50 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(74@, 198@, 199@, 200@)
Object.StorePos(75@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(74@)
51@ = Marker.CreateAboveObject(75@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(76@)
54@ = Marker.CreateAboveObject(77@)
gosub @BOAT_34153 

:BOAT_15338
if 
  162@ == 50 
else_jump @BOAT_15531 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_15531 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_15531 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 55 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(76@, 198@, 199@, 200@)
Object.StorePos(77@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(76@)
51@ = Marker.CreateAboveObject(77@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(78@)
54@ = Marker.CreateAboveObject(79@)
gosub @BOAT_34153 

:BOAT_15531
if 
  162@ == 55 
else_jump @BOAT_15724 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_15724 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_15724 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 60 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(78@, 198@, 199@, 200@)
Object.StorePos(79@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(78@)
51@ = Marker.CreateAboveObject(79@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(80@)
54@ = Marker.CreateAboveObject(81@)
gosub @BOAT_34153 

:BOAT_15724
if 
  162@ == 60 
else_jump @BOAT_16005 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_16005 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_16005 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 65 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(80@, 198@, 199@, 200@)
Object.StorePos(81@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(80@)
51@ = Marker.CreateAboveObject(81@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(82@)
54@ = Marker.CreateAboveObject(83@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(41@)
else_jump @BOAT_16005 
if 
   not Actor.Dead(43@)
else_jump @BOAT_16005 
if 
  35@ == 2 
else_jump @BOAT_15971 
03D1: play_wav 3 

:BOAT_15971
05D1: AS_actor 43@ drive_car 41@ to -2763.105 1954.129 0.0 speed 10.0 2 model #NULL 3 

:BOAT_16005
if 
  162@ == 65 
else_jump @BOAT_16286 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_16286 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_16286 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 70 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(82@, 198@, 199@, 200@)
Object.StorePos(83@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(82@)
51@ = Marker.CreateAboveObject(83@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(84@)
54@ = Marker.CreateAboveObject(85@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_16286 
if 
   not Actor.Dead(42@)
else_jump @BOAT_16286 
if 
  35@ == 2 
else_jump @BOAT_16252 
03D1: play_wav 3 

:BOAT_16252
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_16286
if 
  162@ == 70 
else_jump @BOAT_16545 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_16545 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_16545 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 75 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(84@, 198@, 199@, 200@)
Object.StorePos(85@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(84@)
51@ = Marker.CreateAboveObject(85@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(86@)
54@ = Marker.CreateAboveObject(87@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_16545 
if 
   not Actor.Dead(42@)
else_jump @BOAT_16545 
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_16545
if 
  162@ == 75 
else_jump @BOAT_16826 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_16826 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_16826 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 80 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(86@, 198@, 199@, 200@)
Object.StorePos(87@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(86@)
51@ = Marker.CreateAboveObject(87@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(88@)
54@ = Marker.CreateAboveObject(89@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_16826 
if 
   not Actor.Dead(42@)
else_jump @BOAT_16826 
if 
  35@ == 2 
else_jump @BOAT_16792 
03D1: play_wav 3 

:BOAT_16792
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_16826
if 
  162@ == 80 
else_jump @BOAT_17085 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_17085 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_17085 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 82 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(88@, 198@, 199@, 200@)
Object.StorePos(89@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(88@)
51@ = Marker.CreateAboveObject(89@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(90@)
54@ = Marker.CreateAboveObject(91@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_17085 
if 
   not Actor.Dead(42@)
else_jump @BOAT_17085 
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_17085
if 
  162@ == 82 
else_jump @BOAT_17366 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_17366 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_17366 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 84 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(90@, 198@, 199@, 200@)
Object.StorePos(91@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(90@)
51@ = Marker.CreateAboveObject(91@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(92@)
54@ = Marker.CreateAboveObject(93@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_17366 
if 
   not Actor.Dead(42@)
else_jump @BOAT_17366 
if 
  35@ == 2 
else_jump @BOAT_17332 
03D1: play_wav 3 

:BOAT_17332
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_17366
if 
  162@ == 84 
else_jump @BOAT_17625 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_17625 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_17625 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 86 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(92@, 198@, 199@, 200@)
Object.StorePos(93@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(92@)
51@ = Marker.CreateAboveObject(93@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(94@)
54@ = Marker.CreateAboveObject(95@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_17625 
if 
   not Actor.Dead(42@)
else_jump @BOAT_17625 
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_17625
if 
  162@ == 86 
else_jump @BOAT_17884 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_17884 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_17884 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 88 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(94@, 198@, 199@, 200@)
Object.StorePos(95@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(94@)
51@ = Marker.CreateAboveObject(95@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(96@)
54@ = Marker.CreateAboveObject(97@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_17884 
if 
   not Actor.Dead(42@)
else_jump @BOAT_17884 
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_17884
if 
  162@ == 88 
else_jump @BOAT_18143 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_18143 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_18143 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 90 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(96@, 198@, 199@, 200@)
Object.StorePos(97@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(96@)
51@ = Marker.CreateAboveObject(97@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(98@)
54@ = Marker.CreateAboveObject(99@)
gosub @BOAT_34153 
if 
   not Car.Wrecked(40@)
else_jump @BOAT_18143 
if 
   not Actor.Dead(42@)
else_jump @BOAT_18143 
05D1: AS_actor 42@ drive_car 40@ to -2763.105 1954.129 0.0 speed 15.0 2 model #NULL 3 

:BOAT_18143
if 
  162@ == 90 
else_jump @BOAT_18320 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_18320 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_18320 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 91 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(98@, 198@, 199@, 200@)
Object.StorePos(99@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(98@)
51@ = Marker.CreateAboveObject(99@)
Marker.Disable(53@)
Marker.Disable(54@)
gosub @BOAT_34153 

:BOAT_18320
if 
  162@ == 91 
else_jump @BOAT_18436 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_18436 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_18436 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_33' time 1000 flag 1  
162@ = 99 
Marker.Disable(52@)
Marker.Disable(51@)

:BOAT_18436
if 
  162@ == 92 
else_jump @BOAT_18629 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_18629 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_18629 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 93 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(102@, 198@, 199@, 200@)
Object.StorePos(103@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(102@)
51@ = Marker.CreateAboveObject(103@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(104@)
54@ = Marker.CreateAboveObject(105@)
gosub @BOAT_34153 

:BOAT_18629
if 
  162@ == 93 
else_jump @BOAT_18822 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_18822 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_18822 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 94 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(104@, 198@, 199@, 200@)
Object.StorePos(105@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(104@)
51@ = Marker.CreateAboveObject(105@)
Marker.Disable(53@)
Marker.Disable(54@)
53@ = Marker.CreateAboveObject(56@)
54@ = Marker.CreateAboveObject(57@)
gosub @BOAT_34153 

:BOAT_18822
if 
  162@ == 94 
else_jump @BOAT_18999 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_18999 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_18999 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_31' time 1000 flag 1  
162@ = 97 
Marker.Disable(52@)
Marker.Disable(51@)
Object.StorePos(56@, 198@, 199@, 200@)
Object.StorePos(57@, 195@, 196@, 197@)
52@ = Marker.CreateAboveObject(56@)
51@ = Marker.CreateAboveObject(57@)
Marker.Disable(53@)
Marker.Disable(54@)
gosub @BOAT_34153 

:BOAT_18999
if 
  162@ == 97 
else_jump @BOAT_19115 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_19115 
if 
05F8:   actor " + PlayerActor + @" in_rectangle_ll_corner_at 198@ 199@ lr_corner_at 195@ 196@ angle 3.0 sphere 0 in_car 
else_jump @BOAT_19115 
097A: play_audio_at 198@ 199@ 200@ event 249@ 
00BC: show_text_highpriority GXT 'BOAT_33' time 1000 flag 1  
162@ = 99 
Marker.Disable(52@)
Marker.Disable(51@)

:BOAT_19115
if 
  162@ == 99 
else_jump @BOAT_19785 
Marker.Disable(52@)
Marker.Disable(51@)
Marker.Disable(53@)
Marker.Disable(54@)
gosub @BOAT_20088 
gosub @BOAT_20416 
if 
001E:   " + _1967 + @" > 168@ 
else_jump @BOAT_19373 
008B: 169@ = " + _1967 + @" 
008A: " + _1967 + @" = 168@ 
167@ = 1 
gosub @BOAT_21188 
if 
  " + _8195 + @" == 4 
else_jump @BOAT_19273 
if 
  " + _1984 + @" == 0 
else_jump @BOAT_19273 
" + _1984 + @" = 1 
" + _1983 + @" = 1 
" + _1982 + @" = 1 

:BOAT_19273
if 
  " + _8195 + @" == 3 
else_jump @BOAT_19323 
if 
  " + _1983 + @" == 0 
else_jump @BOAT_19323 
" + _1983 + @" = 1 
" + _1982 + @" = 1 

:BOAT_19323
if 
  " + _8195 + @" == 2 
else_jump @BOAT_19366 
if 
  " + _1982 + @" == 0 
else_jump @BOAT_19366 
" + _1982 + @" = 1 

:BOAT_19366
jump @BOAT_19380 

:BOAT_19373
" + _8195 + @" = 0 

:BOAT_19380
if 
  " + _1962 + @" == 5 
else_jump @BOAT_19445 
if 
001D:   228@ > 168@ 
else_jump @BOAT_19445 
167@ = 2 
" + _1962 + @" = 5 
251@ = 1 
164@ = 2 

:BOAT_19445
32@ = 0 

:BOAT_19452
if 
  32@ > -1 
else_jump @BOAT_19598 
wait 0 
gosub @BOAT_20759 
if 
00E1:   player 0 pressed_key 15 
else_jump @BOAT_19532 
164@ = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_19598 

:BOAT_19532
gosub @BOAT_21719 
gosub @BOAT_20005 
if 
  165@ == 1 
else_jump @BOAT_19591 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
jump @BOAT_19598 

:BOAT_19591
jump @BOAT_19452 

:BOAT_19598
gosub @BOAT_24852 
gosub @BOAT_37625 
if 
  164@ == 2 
else_jump @BOAT_19778 
if 
  251@ == 1 
else_jump @BOAT_19764 
if 
  " + Mission_Boat_School_Passed + @" == 0 
else_jump @BOAT_19764 
fade 0 1000 

:BOAT_19673
if 
fading 
else_jump @BOAT_19697 
wait 0 
jump @BOAT_19673 

:BOAT_19697
Actor.Angle(" + PlayerActor + @") = 177@
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
Camera.SetAtPos(-2185.335, 2410.409, 3.9752)
fade 1 2000 

:BOAT_19733
if 
fading 
else_jump @BOAT_19757 
wait 0 
jump @BOAT_19733 

:BOAT_19757
jump @BOAT_37731 

:BOAT_19764
jump @BOAT_1323 
jump @BOAT_19785 

:BOAT_19778
jump @BOAT_12803 

:BOAT_19785
jump @BOAT_13163 

:BOAT_19792
158@ = 0 
159@ = 0 
160@ = 0 
161@ = 0 
162@ = 0 
" + _8197 + @" = 0 
163@ = 0 
164@ = 0 
165@ = 0 
166@ = 0 
167@ = 0 
168@ = 0 
48@ = 1000 
188@ = 0.0 
189@ = 0.0 
190@ = 0.0 
191@ = 0 
207@ = 0 
208@ = 0 
49@ = 0.0 
211@ = 0 
210@ = 0 
209@ = 0 
233@ = 0 
192@ = 0.0 
193@ = 0.0 
194@ = 0.0 
return 

:BOAT_20005
if 
00E1:   player 0 pressed_key 16 
else_jump @BOAT_20061 
if 
  166@ == 1 
else_jump @BOAT_20054 
166@ = 0 
165@ = 1 

:BOAT_20054
jump @BOAT_20086 

:BOAT_20061
if 
  166@ == 0 
else_jump @BOAT_20086 
166@ = 1 

:BOAT_20086
return 

:BOAT_20088
03E6: remove_text_box 
Player.CanMove(" + PlayerChar + @") = False
if 
  " + _8189 + @" == 1 
else_jump @BOAT_20155 
0396: pause_timer 1 
02D4: car 37@ turn_off_engine 
Car.SetSpeedInstantly(37@, 0.0)
Car.LockInCurrentPosition(37@) = False
0323: enable_boat 37@ anchor 1 
Car.LockInCurrentPosition(37@) = False

:BOAT_20155
if 
  " + _8189 + @" > 1 
else_jump @BOAT_20338 
0396: pause_timer 1 
33@ = 0 

:BOAT_20184
if 
  1000 > 33@ 
else_jump @BOAT_20214 
wait 0 
jump @BOAT_20184 

:BOAT_20214
if 
   not Car.Wrecked(37@)
else_jump @BOAT_20338 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_20271 
if 
   not " + _8189 + @" == 5 
else_jump @BOAT_20271 
02D4: car 37@ turn_off_engine 

:BOAT_20271
Car.SetSpeedInstantly(37@, 0.0)
Car.LockInCurrentPosition(37@) = False
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_20331 
if 
   not " + _8189 + @" == 5 
else_jump @BOAT_20331 
0323: enable_boat 37@ anchor 1 

:BOAT_20331
Car.LockInCurrentPosition(37@) = False

:BOAT_20338
return 

:BOAT_20340
if 
   not Car.Wrecked(37@)
else_jump @BOAT_20407 
if 
  163@ == 1 
else_jump @BOAT_20400 
if 
   not Actor.InCar(" + PlayerActor + @", 37@)
else_jump @BOAT_20400 
164@ = 1 

:BOAT_20400
jump @BOAT_20414 

:BOAT_20407
164@ = 1 

:BOAT_20414
return 

:BOAT_20416
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_20603 
008B: 208@ = " + _8197 + @" 
233@ = 0 
48@ = 1000 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_20481 
250@ = Car.Health(37@)

:BOAT_20481
if 
  " + _8189 + @" == 5 
else_jump @BOAT_20506 
250@ += 120 

:BOAT_20506
if 
  1000 > 250@ 
else_jump @BOAT_20533 
233@ = 5000 

:BOAT_20533
if 
  995 > 250@ 
else_jump @BOAT_20560 
233@ = 7000 

:BOAT_20560
if 
  990 > 250@ 
else_jump @BOAT_20587 
233@ = 10000 

:BOAT_20587
0085: 168@ = 208@ 
005A: 168@ += 233@ 

:BOAT_20603
if 
  " + _8189 + @" == 4 
else_jump @BOAT_20757 
008B: 208@ = " + _8197 + @" 
233@ = 0 
48@ = 1000 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_20668 
250@ = Car.Health(37@)

:BOAT_20668
if 
  995 > 250@ 
else_jump @BOAT_20695 
233@ = 5000 

:BOAT_20695
if 
  990 > 250@ 
else_jump @BOAT_20722 
233@ = 10000 

:BOAT_20722
if 
  985 > 250@ 
else_jump @BOAT_20749 
233@ = 15000 

:BOAT_20749
0092: 168@ = float 246@ to_integer 

:BOAT_20757
return 

:BOAT_20759
if 
   not Car.Wrecked(37@)
else_jump @BOAT_21186 
if 
  191@ == 0 
else_jump @BOAT_20898 
Car.StorePos(37@, 188@, 189@, 190@)
190@ += 5.0 
0407: store_coords_to 188@ 189@ 190@ from_car 37@ with_offset 10.0 0.0 5.0 
Camera.SetPosition(188@, 189@, 190@, 0.0, 0.0, 0.0)
Camera.OnVehicle(37@, 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
191@ = 1 

:BOAT_20898
if 
  32@ > 3000 
else_jump @BOAT_21035 
if 
  6000 > 32@ 
else_jump @BOAT_21035 
if 
  191@ == 1 
else_jump @BOAT_21035 
0407: store_coords_to 188@ 189@ 190@ from_car 37@ with_offset 0.0 10.0 5.0 
Camera.SetPosition(188@, 189@, 190@, 0.0, 0.0, 0.0)
Camera.OnVehicle(37@, 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
191@ = 2 

:BOAT_21035
if 
  32@ > 6000 
else_jump @BOAT_21153 
if 
  191@ == 2 
else_jump @BOAT_21153 
0407: store_coords_to 188@ 189@ 190@ from_car 37@ with_offset -10.0 0.0 5.0 
Camera.SetPosition(188@, 189@, 190@, 0.0, 0.0, 0.0)
Camera.OnVehicle(37@, 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
191@ = 3 

:BOAT_21153
if 
  32@ > 9000 
else_jump @BOAT_21186 
191@ = 1 
32@ = 0 

:BOAT_21186
return 

:BOAT_21188
" + _8195 + @" = 0 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_21444 
if 
001D:   209@ > 168@ 
else_jump @BOAT_21299 
if 
001D:   168@ > 210@ 
else_jump @BOAT_21299 
if and
001D:   209@ > 169@ 
001D:   169@ > 210@ 
else_jump @BOAT_21292 
" + _8195 + @" = 0 
jump @BOAT_21299 

:BOAT_21292
" + _8195 + @" = 2 

:BOAT_21299
if 
001D:   210@ > 168@ 
else_jump @BOAT_21385 
if 
001D:   168@ > 211@ 
else_jump @BOAT_21385 
if and
001D:   210@ > 169@ 
001D:   169@ > 211@ 
else_jump @BOAT_21378 
" + _8195 + @" = 0 
jump @BOAT_21385 

:BOAT_21378
" + _8195 + @" = 3 

:BOAT_21385
if 
001D:   211@ > 168@ 
else_jump @BOAT_21444 
if 
001D:   211@ > 169@ 
else_jump @BOAT_21437 
" + _8195 + @" = 0 
jump @BOAT_21444 

:BOAT_21437
" + _8195 + @" = 4 

:BOAT_21444
if 
  " + _8189 + @" == 4 
else_jump @BOAT_21717 
if or
001D:   168@ > 209@ 
003B:   168@ == 209@ 
else_jump @BOAT_21556 
if 
001D:   210@ > 168@ 
else_jump @BOAT_21556 
if and
001D:   169@ > 209@ 
001D:   210@ > 169@ 
else_jump @BOAT_21549 
" + _8195 + @" = 0 
jump @BOAT_21556 

:BOAT_21549
" + _8195 + @" = 2 

:BOAT_21556
if or
001D:   168@ > 210@ 
003B:   168@ == 210@ 
else_jump @BOAT_21650 
if 
001D:   211@ > 168@ 
else_jump @BOAT_21650 
if and
001D:   169@ > 210@ 
001D:   211@ > 169@ 
else_jump @BOAT_21643 
" + _8195 + @" = 0 
jump @BOAT_21650 

:BOAT_21643
" + _8195 + @" = 3 

:BOAT_21650
if or
001D:   168@ > 211@ 
003B:   168@ == 211@ 
else_jump @BOAT_21717 
if 
001D:   169@ > 211@ 
else_jump @BOAT_21710 
" + _8195 + @" = 0 
jump @BOAT_21717 

:BOAT_21710
" + _8195 + @" = 4 

:BOAT_21717
return 

:BOAT_21719
0826: enable_hud 0 
0581: enable_radar 0 
if 
  2 > " + _8195 + @" 
else_jump @BOAT_21850 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_21810 
0937: text_draw_box_cornerA 122.0 240.0 cornerB 520.0 400.0 GXT_reference 'BOAT_75' style 3  
jump @BOAT_21843 

:BOAT_21810
0937: text_draw_box_cornerA 152.0 240.0 cornerB 490.0 400.0 GXT_reference 'BOAT_75' style 3  

:BOAT_21843
jump @BOAT_21948 

:BOAT_21850
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_21915 
0937: text_draw_box_cornerA 122.0 220.0 cornerB 520.0 400.0 GXT_reference 'DUMMY' style 3 
jump @BOAT_21948 

:BOAT_21915
0937: text_draw_box_cornerA 152.0 220.0 cornerB 490.0 400.0 GXT_reference 'DUMMY' style 3 

:BOAT_21948
gosub @BOAT_33376 
gosub @BOAT_33376 
if 
  48@ > 0 
else_jump @BOAT_24257 
00BE: text_clear_all 
gosub @BOAT_33376 
0345: enable_text_draw_background 0 
0904: get_interface 3 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
241@ = 0.0 
0093: 241@ = integer 208@ to_float 
241@ /= 1000.0 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_22153 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_22127 
07FC: text_draw_box_position_XY 145.0 275.0 GXT_reference 'BOAT_7' value 241@ flag 2  
jump @BOAT_22153 

:BOAT_22127
07FC: text_draw_box_position_XY 180.0 275.0 GXT_reference 'BOAT_7' value 241@ flag 2  

:BOAT_22153
gosub @BOAT_33376 
0904: get_interface 3 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
240@ = 0.0 
0093: 240@ = integer 233@ to_float 
240@ /= 1000.0 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_22320 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_22294 
07FC: text_draw_box_position_XY 145.0 295.0 GXT_reference 'BOAT_9' value 240@ flag 2  
jump @BOAT_22320 

:BOAT_22294
07FC: text_draw_box_position_XY 180.0 295.0 GXT_reference 'BOAT_9' value 240@ flag 2  

:BOAT_22320
gosub @BOAT_33376 
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_22389 
0904: get_interface 3 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
jump @BOAT_22419 

:BOAT_22389
0904: get_interface 3 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 

:BOAT_22419
242@ = 0.0 
0093: 242@ = integer 168@ to_float 
242@ /= 1000.0 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_22549 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_22523 
07FC: text_draw_box_position_XY 145.0 315.0 GXT_reference 'BOAT_10' value 242@ flag 2  
jump @BOAT_22549 

:BOAT_22523
07FC: text_draw_box_position_XY 180.0 315.0 GXT_reference 'BOAT_10' value 242@ flag 2  

:BOAT_22549
if 
  " + _8189 + @" == 4 
else_jump @BOAT_22833 
if 
  246@ > 0.0 
else_jump @BOAT_22759 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_22646 
07FC: text_draw_box_position_XY 145.0 315.0 GXT_reference 'BOAT_11' value 246@ flag 2  
jump @BOAT_22752 

:BOAT_22646
if 
  252@ == 3 
else_jump @BOAT_22690 
07FC: text_draw_box_position_XY 175.0 315.0 GXT_reference 'BOAT_11' value 246@ flag 2  

:BOAT_22690
if 
   not 252@ == 3 
else_jump @BOAT_22752 
if 
   not 252@ == 4 
else_jump @BOAT_22752 
07FC: text_draw_box_position_XY 180.0 315.0 GXT_reference 'BOAT_11' value 246@ flag 2  

:BOAT_22752
jump @BOAT_22833 

:BOAT_22759
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_22812 
033E: set_draw_text_position 145.0 315.0 GXT 'BOAT_12'  
jump @BOAT_22833 

:BOAT_22812
033E: set_draw_text_position 180.0 315.0 GXT 'BOAT_12'  

:BOAT_22833
gosub @BOAT_33376 
0340: set_text_draw_RGBA 255 255 255 255 
241@ = 0.0 
0093: 241@ = integer 208@ to_float 
241@ /= 1000.0 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_22984 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_22958 
07FC: text_draw_box_position_XY 425.0 275.0 GXT_reference 'BOAT_77' value 241@ flag 2  
jump @BOAT_22984 

:BOAT_22958
07FC: text_draw_box_position_XY 390.0 275.0 GXT_reference 'BOAT_77' value 241@ flag 2  

:BOAT_22984
gosub @BOAT_33376 
0904: get_interface 0 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
240@ = 0.0 
0093: 240@ = integer 233@ to_float 
240@ /= 1000.0 
if 
  240@ > 0.0 
else_jump @BOAT_23107 
0904: get_interface 0 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
jump @BOAT_23137 

:BOAT_23107
0904: get_interface 8 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 

:BOAT_23137
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_23239 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_23213 
07FC: text_draw_box_position_XY 425.0 295.0 GXT_reference 'BOAT_77' value 240@ flag 2  
jump @BOAT_23239 

:BOAT_23213
07FC: text_draw_box_position_XY 390.0 295.0 GXT_reference 'BOAT_77' value 240@ flag 2  

:BOAT_23239
gosub @BOAT_33376 
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_23292 
0340: set_text_draw_RGBA 255 255 255 255 
jump @BOAT_23306 

:BOAT_23292
0340: set_text_draw_RGBA 255 255 255 255 

:BOAT_23306
242@ = 0.0 
0093: 242@ = integer 168@ to_float 
242@ /= 1000.0 
if 
   not " + _8189 + @" == 4 
else_jump @BOAT_23436 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_23410 
07FC: text_draw_box_position_XY 425.0 315.0 GXT_reference 'BOAT_77' value 242@ flag 2  
jump @BOAT_23436 

:BOAT_23410
07FC: text_draw_box_position_XY 390.0 315.0 GXT_reference 'BOAT_77' value 242@ flag 2  

:BOAT_23436
if 
  " + _8189 + @" == 4 
else_jump @BOAT_23566 
if 
  246@ > 0.0 
else_jump @BOAT_23566 
gosub @BOAT_37684 
if 
  252@ == 4 
else_jump @BOAT_23533 
07FC: text_draw_box_position_XY 425.0 315.0 GXT_reference 'BOAT_80' value 246@ flag 2  
jump @BOAT_23559 

:BOAT_23533
07FC: text_draw_box_position_XY 390.0 315.0 GXT_reference 'BOAT_80' value 246@ flag 2  

:BOAT_23559
jump @BOAT_23566 

:BOAT_23566
0904: get_interface 4 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
033E: set_draw_text_position 340.0 345.0 GXT 'SCH_PRS'  
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
033E: set_draw_text_position 340.0 365.0 GXT 'BOAT_73'  
gosub @BOAT_33376 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033E: set_draw_text_position 180.0 345.0 GXT 'BOAT_76'  
gosub @BOAT_33376 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033E: set_draw_text_position 180.0 365.0 GXT 'BOAT_53'  
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_23903 
gosub @BOAT_33492 
033F: set_text_draw_letter_size 1.0 3.4 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 323.0 110.0 GXT 'BOAT_46'  

:BOAT_23903
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_24250 
if 
  " + _8195 + @" > 0 
else_jump @BOAT_24250 
038D: draw_texture 4 position 250.0 219.0 size -60.0 60.0 RGBA 180 180 180 255 
038D: draw_texture 4 position 392.0 219.0 size 60.0 60.0 RGBA 180 180 180 255 
if 
  " + _8195 + @" == 2 
else_jump @BOAT_24072 
038D: draw_texture 1 position 320.0 220.0 size 110.0 95.0 RGBA 160 160 160 255 

:BOAT_24072
if 
  " + _8195 + @" == 3 
else_jump @BOAT_24126 
038D: draw_texture 2 position 320.0 220.0 size 110.0 95.0 RGBA 160 160 160 255 

:BOAT_24126
if 
  " + _8195 + @" == 4 
else_jump @BOAT_24180 
038D: draw_texture 3 position 320.0 220.0 size 110.0 95.0 RGBA 160 160 160 255 

:BOAT_24180
gosub @BOAT_33492 
033F: set_text_draw_letter_size 1.0 3.4 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033E: set_draw_text_position 323.0 65.0 GXT 'BOAT_47'  

:BOAT_24250
jump @BOAT_24845 

:BOAT_24257
gosub @BOAT_33376 
0340: set_text_draw_RGBA 134 155 184 255 
241@ = 0.0 
0093: 241@ = integer 208@ to_float 
241@ /= 1000.0 
07FC: text_draw_box_position_XY 30.0 55.0 GXT_reference 'BOAT_7' value 241@ flag 2  
gosub @BOAT_33376 
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_24383 
0340: set_text_draw_RGBA 107 148 49 255 
jump @BOAT_24397 

:BOAT_24383
0340: set_text_draw_RGBA 134 155 184 255 

:BOAT_24397
242@ = 0.0 
0093: 242@ = integer 168@ to_float 
242@ /= 1000.0 
07FC: text_draw_box_position_XY 30.0 65.0 GXT_reference 'BOAT_10' value 242@ flag 2  
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_24516 
gosub @BOAT_33376 
0340: set_text_draw_RGBA 107 148 49 255 
033E: set_draw_text_position 260.0 65.0 GXT 'BOAT_46'  

:BOAT_24516
if or
  167@ == 1 
  167@ == 2 
else_jump @BOAT_24845 
if 
  " + _8195 + @" > 0 
else_jump @BOAT_24845 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 68.0 145.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 210.0 145.0 size 60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
if 
  " + _8195 + @" == 2 
else_jump @BOAT_24697 
038D: draw_texture 1 position 138.0 145.0 size 110.0 95.0 RGBA 160 160 160 255 

:BOAT_24697
if 
  " + _8195 + @" == 3 
else_jump @BOAT_24751 
038D: draw_texture 2 position 138.0 145.0 size 110.0 95.0 RGBA 160 160 160 255 

:BOAT_24751
if 
  " + _8195 + @" == 4 
else_jump @BOAT_24805 
038D: draw_texture 3 position 138.0 145.0 size 110.0 95.0 RGBA 160 160 160 255 

:BOAT_24805
gosub @BOAT_33376 
0340: set_text_draw_RGBA 107 148 49 255 
033E: set_draw_text_position 260.0 172.0 GXT 'BOAT_47'  

:BOAT_24845
014F: stop_timer " + _8197 + @" 
return 

:BOAT_24852
fade 0 500 

:BOAT_24859
if 
fading 
else_jump @BOAT_24883 
wait 0 
jump @BOAT_24859 

:BOAT_24883
0826: enable_hud 1 
0581: enable_radar 1 
00BE: text_clear_all 
03E6: remove_text_box 
03D6: remove_styled_text 'BOAT_46'  
03D6: remove_styled_text 'BOAT_47'  
0221: set_player " + PlayerChar + @" apply_brakes_to_car 0 
0792: disembark_instantly_actor " + PlayerActor + @" 
if 
  164@ == 2 
else_jump @BOAT_25007 
00BE: text_clear_all 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @BOAT_24986 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 174@ 175@ 176@ 
jump @BOAT_25000 

:BOAT_24986
Actor.PutAt(" + PlayerActor + @", 174@, 175@, 176@)

:BOAT_25000
jump @BOAT_25058 

:BOAT_25007
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @BOAT_25044 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 174@ 175@ 176@ 
jump @BOAT_25058 

:BOAT_25044
Actor.PutAt(" + PlayerActor + @", 174@, 175@, 176@)

:BOAT_25058
wait 0 
Car.Destroy(37@)
Car.Destroy(46@)
Actor.DestroyInstantly(39@)
Marker.Disable(52@)
Marker.Disable(51@)
Marker.Disable(53@)
Marker.Disable(54@)
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
wait 0 
014F: stop_timer " + _8197 + @" 
0396: pause_timer 0 
return 

:BOAT_25116
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 225.0 size 612.0 438.0 RGBA 0 0 0 " + _8194 + @" 
if 
  " + _8193 + @" == 1 
else_jump @BOAT_25238 
if 
  255 > " + _8194 + @" 
else_jump @BOAT_25231 
" + _8194 + @" += 20 
if 
  " + _8194 + @" > 255 
else_jump @BOAT_25224 
" + _8194 + @" = 255 

:BOAT_25224
jump @BOAT_25238 

:BOAT_25231
" + _8193 + @" = 2 

:BOAT_25238
if 
  " + _8193 + @" == 3 
else_jump @BOAT_25320 
if 
  " + _8194 + @" > 0 
else_jump @BOAT_25313 
" + _8194 + @" -= 5 
if 
  0 > " + _8194 + @" 
else_jump @BOAT_25306 
" + _8194 + @" = 0 

:BOAT_25306
jump @BOAT_25320 

:BOAT_25313
" + _8193 + @" = 0 

:BOAT_25320
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 0.0 size 640.0 197.0 RGBA 0 0 0 255 
gosub @BOAT_33492 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  " + _8189 + @" == 1 
else_jump @BOAT_25432 
033E: set_draw_text_position 322.0 31.0 GXT 'BOAT_A'  
0084: " + _8196 + @" = " + _1963 + @" 
gosub @BOAT_27098 

:BOAT_25432
if 
  " + _8189 + @" == 2 
else_jump @BOAT_25486 
033E: set_draw_text_position 322.0 31.0 GXT 'BOAT_B'  
0084: " + _8196 + @" = " + _1964 + @" 
gosub @BOAT_27098 

:BOAT_25486
if 
  " + _8189 + @" == 3 
else_jump @BOAT_25540 
033E: set_draw_text_position 322.0 31.0 GXT 'BOAT_C'  
0084: " + _8196 + @" = " + _1965 + @" 
gosub @BOAT_27098 

:BOAT_25540
if 
  " + _8189 + @" == 4 
else_jump @BOAT_25594 
033E: set_draw_text_position 322.0 31.0 GXT 'BOAT_D'  
0084: " + _8196 + @" = " + _1966 + @" 
gosub @BOAT_27098 

:BOAT_25594
if 
  " + _8189 + @" == 5 
else_jump @BOAT_25648 
033E: set_draw_text_position 322.0 31.0 GXT 'BOAT_E'  
0084: " + _8196 + @" = " + _1967 + @" 
gosub @BOAT_27098 

:BOAT_25648
gosub @BOAT_33314 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
gosub @BOAT_37684 
if 
  252@ == 1 
else_jump @BOAT_25750 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'BOAT_53'  
jump @BOAT_25783 

:BOAT_25750
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'BOAT_53'  

:BOAT_25783
if 
   not " + _8192 + @" == 1 
else_jump @BOAT_26249 
gosub @BOAT_33314 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
gosub @BOAT_37684 
if 
  252@ == 1 
else_jump @BOAT_25903 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'BOAT_54'  
jump @BOAT_25936 

:BOAT_25903
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'BOAT_54'  

:BOAT_25936
if 
   not " + _1962 + @" == 1 
else_jump @BOAT_26089 
gosub @BOAT_33314 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
gosub @BOAT_37684 
if 
  252@ == 1 
else_jump @BOAT_26056 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BOAT_52'  
jump @BOAT_26089 

:BOAT_26056
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BOAT_52'  

:BOAT_26089
if 
  " + _1962 + @" == 1 
else_jump @BOAT_26242 
gosub @BOAT_33314 
0904: get_interface 8 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
gosub @BOAT_37684 
if 
  252@ == 1 
else_jump @BOAT_26209 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BOAT_52'  
jump @BOAT_26242 

:BOAT_26209
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BOAT_52'  

:BOAT_26242
jump @BOAT_26384 

:BOAT_26249
gosub @BOAT_33314 
0904: get_interface 6 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
gosub @BOAT_37684 
if 
  252@ == 1 
else_jump @BOAT_26351 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BOAT_52'  
jump @BOAT_26384 

:BOAT_26351
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BOAT_52'  

:BOAT_26384
gosub @BOAT_33314 
0340: set_text_draw_RGBA 248 211 7 255 
0904: get_interface 4 color_RGBA_to 170@ 171@ 172@ 173@ 
033F: set_text_draw_letter_size 0.32 1.25 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033E: set_draw_text_position 150.0 360.0 GXT 'BOAT_73'  
if 
   not " + _8192 + @" == 1 
else_jump @BOAT_26762 
gosub @BOAT_33314 
0904: get_interface 4 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 150.0 340.0 GXT 'SCH_PRS'  
if 
   not " + _1962 + @" == 1 
else_jump @BOAT_26655 
gosub @BOAT_33314 
0904: get_interface 4 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033F: set_text_draw_letter_size 1.45 2.0 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'BOAT_72'  

:BOAT_26655
if 
  " + _1962 + @" == 1 
else_jump @BOAT_26755 
gosub @BOAT_33314 
0904: get_interface 4 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033F: set_text_draw_letter_size 1.45 2.0 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'BOAT_72'  

:BOAT_26755
jump @BOAT_26844 

:BOAT_26762
gosub @BOAT_33314 
0904: get_interface 4 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
033F: set_text_draw_letter_size 1.45 2.0 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'BOAT_72'  

:BOAT_26844
033F: set_text_draw_letter_size 0.52 1.45 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 160.0 317.0 size 320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 480.0 317.0 size -320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 9 position 160.0 435.0 size 320.0 17.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 9 position 480.0 435.0 size -320.0 17.0 RGBA 150 150 150 255 
return 

:BOAT_27098
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 430.0 size 640.0 250.0 RGBA 0 0 0 255 
gosub @BOAT_33314 
03E4: set_text_draw_align_right 0 
0904: get_interface 3 color_RGBA_to 170@ 171@ 172@ 173@ 
0340: set_text_draw_RGBA 170@ 171@ 172@ 173@ 
if 
  " + _8189 + @" == 1 
else_jump @BOAT_27919 
if 
001F:   212@ > " + _1963 + @" 
else_jump @BOAT_27483 
239@ = 0.0 
008F: 239@ = integer " + _8196 + @" to_float 
239@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_27476 jumps 0 @BOAT_27311 1 @BOAT_27344 2 @BOAT_27377 3 @BOAT_27410 4 @BOAT_27443 -1 @BOAT_27476 -1 @BOAT_27476 

:BOAT_27311
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_27476 

:BOAT_27344
07FC: text_draw_box_position_XY 200.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_27476 

:BOAT_27377
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_27476 

:BOAT_27410
07FC: text_draw_box_position_XY 187.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_27476 

:BOAT_27443
07FC: text_draw_box_position_XY 193.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_27476 

:BOAT_27476
jump @BOAT_27777 

:BOAT_27483
247@ = 0 
234@ = 0.0 
0093: 234@ = integer 212@ to_float 
234@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_27777 jumps 0 @BOAT_27588 1 @BOAT_27621 2 @BOAT_27654 3 @BOAT_27687 4 @BOAT_27720 -1 @BOAT_27777 -1 @BOAT_27777 

:BOAT_27588
07FC: text_draw_box_position_XY 137.0 75.0 GXT_reference 'BOAT_62' value 234@ flag 1  
jump @BOAT_27777 

:BOAT_27621
07FC: text_draw_box_position_XY 77.0 75.0 GXT_reference 'BOAT_62' value 234@ flag 1  
jump @BOAT_27777 

:BOAT_27654
07FC: text_draw_box_position_XY 77.0 75.0 GXT_reference 'BOAT_62' value 234@ flag 1  
jump @BOAT_27777 

:BOAT_27687
07FC: text_draw_box_position_XY 97.0 75.0 GXT_reference 'BOAT_62' value 234@ flag 1  
jump @BOAT_27777 

:BOAT_27720
033F: set_text_draw_letter_size 0.45 1.35 
07FC: text_draw_box_position_XY 93.0 75.0 GXT_reference 'BOAT_62' value 234@ flag 1  
033F: set_text_draw_letter_size 0.52 1.45 
jump @BOAT_27777 

:BOAT_27777
if 
001E:   " + _8196 + @" > 213@ 
else_jump @BOAT_27803 
" + _8195 + @" = 1 

:BOAT_27803
if 
001F:   213@ > " + _8196 + @" 
else_jump @BOAT_27848 
if 
001E:   " + _8196 + @" > 214@ 
else_jump @BOAT_27848 
" + _8195 + @" = 2 

:BOAT_27848
if 
001F:   214@ > " + _8196 + @" 
else_jump @BOAT_27893 
if 
001E:   " + _8196 + @" > 215@ 
else_jump @BOAT_27893 
" + _8195 + @" = 3 

:BOAT_27893
if 
001F:   215@ > " + _8196 + @" 
else_jump @BOAT_27919 
" + _8195 + @" = 4 

:BOAT_27919
if 
  " + _8189 + @" == 2 
else_jump @BOAT_28655 
if 
001F:   216@ > " + _1964 + @" 
else_jump @BOAT_28226 
239@ = 0.0 
008F: 239@ = integer " + _8196 + @" to_float 
239@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_28219 jumps 0 @BOAT_28054 1 @BOAT_28087 2 @BOAT_28120 3 @BOAT_28153 4 @BOAT_28186 -1 @BOAT_28219 -1 @BOAT_28219 

:BOAT_28054
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28219 

:BOAT_28087
07FC: text_draw_box_position_XY 200.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28219 

:BOAT_28120
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28219 

:BOAT_28153
07FC: text_draw_box_position_XY 187.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28219 

:BOAT_28186
07FC: text_draw_box_position_XY 190.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28219 

:BOAT_28219
jump @BOAT_28513 

:BOAT_28226
235@ = 0.0 
0093: 235@ = integer 216@ to_float 
235@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_28513 jumps 0 @BOAT_28324 1 @BOAT_28357 2 @BOAT_28390 3 @BOAT_28423 4 @BOAT_28456 -1 @BOAT_28513 -1 @BOAT_28513 

:BOAT_28324
07FC: text_draw_box_position_XY 137.0 75.0 GXT_reference 'BOAT_62' value 235@ flag 1  
jump @BOAT_28513 

:BOAT_28357
07FC: text_draw_box_position_XY 77.0 75.0 GXT_reference 'BOAT_62' value 235@ flag 1  
jump @BOAT_28513 

:BOAT_28390
07FC: text_draw_box_position_XY 77.0 75.0 GXT_reference 'BOAT_62' value 235@ flag 1  
jump @BOAT_28513 

:BOAT_28423
07FC: text_draw_box_position_XY 97.0 75.0 GXT_reference 'BOAT_62' value 235@ flag 1  
jump @BOAT_28513 

:BOAT_28456
033F: set_text_draw_letter_size 0.45 1.35 
07FC: text_draw_box_position_XY 88.0 75.0 GXT_reference 'BOAT_62' value 235@ flag 1  
033F: set_text_draw_letter_size 0.52 1.45 
jump @BOAT_28513 

:BOAT_28513
if 
001E:   " + _8196 + @" > 217@ 
else_jump @BOAT_28539 
" + _8195 + @" = 1 

:BOAT_28539
if 
001F:   217@ > " + _8196 + @" 
else_jump @BOAT_28584 
if 
001E:   " + _8196 + @" > 218@ 
else_jump @BOAT_28584 
" + _8195 + @" = 2 

:BOAT_28584
if 
001F:   218@ > " + _8196 + @" 
else_jump @BOAT_28629 
if 
001E:   " + _8196 + @" > 219@ 
else_jump @BOAT_28629 
" + _8195 + @" = 3 

:BOAT_28629
if 
001F:   219@ > " + _8196 + @" 
else_jump @BOAT_28655 
" + _8195 + @" = 4 

:BOAT_28655
if 
  " + _8189 + @" == 3 
else_jump @BOAT_29401 
if 
001F:   220@ > " + _1965 + @" 
else_jump @BOAT_28962 
239@ = 0.0 
008F: 239@ = integer " + _8196 + @" to_float 
239@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_28955 jumps 0 @BOAT_28790 1 @BOAT_28823 2 @BOAT_28856 3 @BOAT_28889 4 @BOAT_28922 -1 @BOAT_28955 -1 @BOAT_28955 

:BOAT_28790
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28955 

:BOAT_28823
07FC: text_draw_box_position_XY 200.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28955 

:BOAT_28856
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28955 

:BOAT_28889
07FC: text_draw_box_position_XY 187.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28955 

:BOAT_28922
07FC: text_draw_box_position_XY 190.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_28955 

:BOAT_28955
jump @BOAT_29259 

:BOAT_28962
236@ = 0.0 
0093: 236@ = integer 220@ to_float 
236@ /= 1000.0 
236@ /= 60.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_29259 jumps 0 @BOAT_29070 1 @BOAT_29103 2 @BOAT_29136 3 @BOAT_29169 4 @BOAT_29202 -1 @BOAT_29259 -1 @BOAT_29259 

:BOAT_29070
07FC: text_draw_box_position_XY 142.0 75.0 GXT_reference 'BOAT_63' value 236@ flag 1  
jump @BOAT_29259 

:BOAT_29103
07FC: text_draw_box_position_XY 87.0 75.0 GXT_reference 'BOAT_63' value 236@ flag 1  
jump @BOAT_29259 

:BOAT_29136
07FC: text_draw_box_position_XY 83.0 75.0 GXT_reference 'BOAT_63' value 236@ flag 1  
jump @BOAT_29259 

:BOAT_29169
07FC: text_draw_box_position_XY 112.0 75.0 GXT_reference 'BOAT_63' value 236@ flag 1  
jump @BOAT_29259 

:BOAT_29202
033F: set_text_draw_letter_size 0.45 1.35 
07FC: text_draw_box_position_XY 103.0 75.0 GXT_reference 'BOAT_63' value 236@ flag 1  
033F: set_text_draw_letter_size 0.52 1.45 
jump @BOAT_29259 

:BOAT_29259
if 
001E:   " + _8196 + @" > 221@ 
else_jump @BOAT_29285 
" + _8195 + @" = 1 

:BOAT_29285
if 
001F:   221@ > " + _8196 + @" 
else_jump @BOAT_29330 
if 
001E:   " + _8196 + @" > 222@ 
else_jump @BOAT_29330 
" + _8195 + @" = 2 

:BOAT_29330
if 
001F:   222@ > " + _8196 + @" 
else_jump @BOAT_29375 
if 
001E:   " + _8196 + @" > 223@ 
else_jump @BOAT_29375 
" + _8195 + @" = 3 

:BOAT_29375
if 
001F:   223@ > " + _8196 + @" 
else_jump @BOAT_29401 
" + _8195 + @" = 4 

:BOAT_29401
if 
  " + _8189 + @" == 4 
else_jump @BOAT_30117 
if 
001E:   " + _1966 + @" > 224@ 
else_jump @BOAT_29698 
239@ = 0.0 
008F: 239@ = integer " + _8196 + @" to_float 
239@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_29691 jumps 0 @BOAT_29536 1 @BOAT_29567 2 @BOAT_29598 3 @BOAT_29629 4 @BOAT_29660 -1 @BOAT_29691 -1 @BOAT_29691 

:BOAT_29536
045A: draw_text_1number 185.0 75.0 GXT 'BOAT_60' number " + _1966 + @"  
jump @BOAT_29691 

:BOAT_29567
045A: draw_text_1number 167.0 75.0 GXT 'BOAT_60' number " + _1966 + @"  
jump @BOAT_29691 

:BOAT_29598
045A: draw_text_1number 167.0 75.0 GXT 'BOAT_60' number " + _1966 + @"  
jump @BOAT_29691 

:BOAT_29629
045A: draw_text_1number 177.0 75.0 GXT 'BOAT_60' number " + _1966 + @"  
jump @BOAT_29691 

:BOAT_29660
045A: draw_text_1number 160.0 75.0 GXT 'BOAT_60' number " + _1966 + @"  
jump @BOAT_29691 

:BOAT_29691
jump @BOAT_29951 

:BOAT_29698
237@ = 0.0 
0093: 237@ = integer 224@ to_float 
237@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_29951 jumps 0 @BOAT_29796 1 @BOAT_29827 2 @BOAT_29858 3 @BOAT_29889 4 @BOAT_29920 -1 @BOAT_29951 -1 @BOAT_29951 

:BOAT_29796
045A: draw_text_1number 153.0 75.0 GXT 'BOAT_61' number 224@  
jump @BOAT_29951 

:BOAT_29827
045A: draw_text_1number 103.0 75.0 GXT 'BOAT_61' number 224@  
jump @BOAT_29951 

:BOAT_29858
045A: draw_text_1number 93.0 75.0 GXT 'BOAT_61' number 224@  
jump @BOAT_29951 

:BOAT_29889
045A: draw_text_1number 123.0 75.0 GXT 'BOAT_61' number 224@  
jump @BOAT_29951 

:BOAT_29920
045A: draw_text_1number 103.0 75.0 GXT 'BOAT_61' number 224@  
jump @BOAT_29951 

:BOAT_29951
if 
001F:   225@ > " + _8196 + @" 
else_jump @BOAT_29977 
" + _8195 + @" = 1 

:BOAT_29977
if or
001E:   " + _8196 + @" > 225@ 
003C:   " + _8196 + @" == 225@ 
else_jump @BOAT_30030 
if 
001F:   226@ > " + _8196 + @" 
else_jump @BOAT_30030 
" + _8195 + @" = 2 

:BOAT_30030
if or
001E:   " + _8196 + @" > 226@ 
003C:   " + _8196 + @" == 226@ 
else_jump @BOAT_30083 
if 
001F:   227@ > " + _8196 + @" 
else_jump @BOAT_30083 
" + _8195 + @" = 3 

:BOAT_30083
if or
001E:   " + _8196 + @" > 227@ 
003C:   " + _8196 + @" == 227@ 
else_jump @BOAT_30117 
" + _8195 + @" = 4 

:BOAT_30117
if 
  " + _8189 + @" == 5 
else_jump @BOAT_30863 
if 
001F:   228@ > " + _1967 + @" 
else_jump @BOAT_30424 
239@ = 0.0 
008F: 239@ = integer " + _8196 + @" to_float 
239@ /= 1000.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_30417 jumps 0 @BOAT_30252 1 @BOAT_30285 2 @BOAT_30318 3 @BOAT_30351 4 @BOAT_30384 -1 @BOAT_30417 -1 @BOAT_30417 

:BOAT_30252
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_30417 

:BOAT_30285
07FC: text_draw_box_position_XY 200.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_30417 

:BOAT_30318
07FC: text_draw_box_position_XY 217.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_30417 

:BOAT_30351
07FC: text_draw_box_position_XY 187.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_30417 

:BOAT_30384
07FC: text_draw_box_position_XY 190.0 75.0 GXT_reference 'BOAT_58' value 239@ flag 2  
jump @BOAT_30417 

:BOAT_30417
jump @BOAT_30721 

:BOAT_30424
238@ = 0.0 
0093: 238@ = integer 228@ to_float 
238@ /= 1000.0 
238@ /= 60.0 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_30721 jumps 0 @BOAT_30532 1 @BOAT_30565 2 @BOAT_30598 3 @BOAT_30631 4 @BOAT_30664 -1 @BOAT_30721 -1 @BOAT_30721 

:BOAT_30532
07FC: text_draw_box_position_XY 144.0 75.0 GXT_reference 'BOAT_63' value 238@ flag 1  
jump @BOAT_30721 

:BOAT_30565
07FC: text_draw_box_position_XY 87.0 75.0 GXT_reference 'BOAT_63' value 238@ flag 1  
jump @BOAT_30721 

:BOAT_30598
07FC: text_draw_box_position_XY 88.0 75.0 GXT_reference 'BOAT_63' value 238@ flag 1  
jump @BOAT_30721 

:BOAT_30631
07FC: text_draw_box_position_XY 117.0 75.0 GXT_reference 'BOAT_63' value 238@ flag 1  
jump @BOAT_30721 

:BOAT_30664
033F: set_text_draw_letter_size 0.45 1.35 
07FC: text_draw_box_position_XY 103.0 75.0 GXT_reference 'BOAT_63' value 238@ flag 1  
033F: set_text_draw_letter_size 0.52 1.45 
jump @BOAT_30721 

:BOAT_30721
if 
001E:   " + _8196 + @" > 229@ 
else_jump @BOAT_30747 
" + _8195 + @" = 1 

:BOAT_30747
if 
001F:   229@ > " + _8196 + @" 
else_jump @BOAT_30792 
if 
001E:   " + _8196 + @" > 230@ 
else_jump @BOAT_30792 
" + _8195 + @" = 2 

:BOAT_30792
if 
001F:   230@ > " + _8196 + @" 
else_jump @BOAT_30837 
if 
001E:   " + _8196 + @" > 231@ 
else_jump @BOAT_30837 
" + _8195 + @" = 3 

:BOAT_30837
if 
001F:   231@ > " + _8196 + @" 
else_jump @BOAT_30863 
" + _8195 + @" = 4 

:BOAT_30863
if 
  " + _8195 + @" > 1 
else_jump @BOAT_30968 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 
jump @BOAT_31048 

:BOAT_30968
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 

:BOAT_31048
03E3: set_texture_to_be_drawn_antialiased 1 
if 
  " + _8195 + @" == 1 
else_jump @BOAT_31337 
038D: draw_texture 6 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BOAT_33314 
0340: set_text_draw_RGBA 166 202 240 255 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_31337 jumps 0 @BOAT_31197 1 @BOAT_31225 2 @BOAT_31253 3 @BOAT_31281 4 @BOAT_31309 -1 @BOAT_31337 -1 @BOAT_31337 

:BOAT_31197
033E: set_draw_text_position 266.0 375.0 GXT 'BOAT_64'  
jump @BOAT_31337 

:BOAT_31225
033E: set_draw_text_position 216.0 375.0 GXT 'BOAT_64'  
jump @BOAT_31337 

:BOAT_31253
033E: set_draw_text_position 233.0 375.0 GXT 'BOAT_64'  
jump @BOAT_31337 

:BOAT_31281
033E: set_draw_text_position 216.0 375.0 GXT 'BOAT_64'  
jump @BOAT_31337 

:BOAT_31309
033E: set_draw_text_position 216.0 375.0 GXT 'BOAT_64'  
jump @BOAT_31337 

:BOAT_31337
if 
  " + _8195 + @" == 2 
else_jump @BOAT_31622 
038D: draw_texture 1 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BOAT_33314 
0340: set_text_draw_RGBA 166 202 240 255 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_31622 jumps 0 @BOAT_31482 1 @BOAT_31510 2 @BOAT_31538 3 @BOAT_31566 4 @BOAT_31594 -1 @BOAT_31622 -1 @BOAT_31622 

:BOAT_31482
033E: set_draw_text_position 280.0 375.0 GXT 'BOAT_57'  
jump @BOAT_31622 

:BOAT_31510
033E: set_draw_text_position 280.0 375.0 GXT 'BOAT_57'  
jump @BOAT_31622 

:BOAT_31538
033E: set_draw_text_position 280.0 375.0 GXT 'BOAT_57'  
jump @BOAT_31622 

:BOAT_31566
033E: set_draw_text_position 280.0 375.0 GXT 'BOAT_57'  
jump @BOAT_31622 

:BOAT_31594
033E: set_draw_text_position 280.0 375.0 GXT 'BOAT_57'  
jump @BOAT_31622 

:BOAT_31622
if 
  " + _8195 + @" == 3 
else_jump @BOAT_31907 
038D: draw_texture 2 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BOAT_33314 
0340: set_text_draw_RGBA 166 202 240 255 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_31907 jumps 0 @BOAT_31767 1 @BOAT_31795 2 @BOAT_31823 3 @BOAT_31851 4 @BOAT_31879 -1 @BOAT_31907 -1 @BOAT_31907 

:BOAT_31767
033E: set_draw_text_position 283.0 375.0 GXT 'BOAT_56'  
jump @BOAT_31907 

:BOAT_31795
033E: set_draw_text_position 278.0 375.0 GXT 'BOAT_56'  
jump @BOAT_31907 

:BOAT_31823
033E: set_draw_text_position 283.0 375.0 GXT 'BOAT_56'  
jump @BOAT_31907 

:BOAT_31851
033E: set_draw_text_position 273.0 375.0 GXT 'BOAT_56'  
jump @BOAT_31907 

:BOAT_31879
033E: set_draw_text_position 286.0 375.0 GXT 'BOAT_56'  
jump @BOAT_31907 

:BOAT_31907
if 
  " + _8195 + @" == 4 
else_jump @BOAT_32192 
038D: draw_texture 3 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BOAT_33314 
0340: set_text_draw_RGBA 166 202 240 255 
gosub @BOAT_37684 
0871: init_jump_table 252@ total_jumps 5 default_jump 0 @BOAT_32192 jumps 0 @BOAT_32052 1 @BOAT_32080 2 @BOAT_32108 3 @BOAT_32136 4 @BOAT_32164 -1 @BOAT_32192 -1 @BOAT_32192 

:BOAT_32052
033E: set_draw_text_position 294.0 375.0 GXT 'BOAT_55'  
jump @BOAT_32192 

:BOAT_32080
033E: set_draw_text_position 307.0 375.0 GXT 'BOAT_55'  
jump @BOAT_32192 

:BOAT_32108
033E: set_draw_text_position 294.0 375.0 GXT 'BOAT_55'  
jump @BOAT_32192 

:BOAT_32136
033E: set_draw_text_position 300.0 375.0 GXT 'BOAT_55'  
jump @BOAT_32192 

:BOAT_32164
033E: set_draw_text_position 300.0 375.0 GXT 'BOAT_55'  
jump @BOAT_32192 

:BOAT_32192
return 

:BOAT_32194
if 
  " + _8191 + @" == 0 
else_jump @BOAT_32344 
if 
  " + _8189 + @" == 1 
else_jump @BOAT_32237 
gosub @BOAT_2264 

:BOAT_32237
if 
  " + _8189 + @" == 2 
else_jump @BOAT_32262 
gosub @BOAT_3828 

:BOAT_32262
if 
  " + _8189 + @" == 3 
else_jump @BOAT_32287 
gosub @BOAT_6527 

:BOAT_32287
if 
  " + _8189 + @" == 4 
else_jump @BOAT_32312 
gosub @BOAT_10930 

:BOAT_32312
if 
  " + _8189 + @" == 5 
else_jump @BOAT_32337 
gosub @BOAT_12810 

:BOAT_32337
" + _8191 + @" = 1 

:BOAT_32344
if 
  " + _8191 + @" == 1 
else_jump @BOAT_32824 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_32824 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_32426 
Car.StorePos(37@, 204@, 205@, 206@)
0395: clear_area 1 at 204@ 205@ 206@ radius 1000.0 

:BOAT_32426
if 
  " + _8189 + @" == 1 
else_jump @BOAT_32496 
if 
87C1:   not path 752 available 
else_jump @BOAT_32472 
07C0: load_path 752 
jump @BOAT_32496 

:BOAT_32472
0971: sync_water 
05EB: assign_car 37@ to_path 752 
" + _8193 + @" = 3 
" + _8191 + @" = 2 

:BOAT_32496
if 
  " + _8189 + @" == 2 
else_jump @BOAT_32566 
if 
87C1:   not path 755 available 
else_jump @BOAT_32542 
07C0: load_path 755 
jump @BOAT_32566 

:BOAT_32542
0971: sync_water 
05EB: assign_car 37@ to_path 755 
" + _8193 + @" = 3 
" + _8191 + @" = 2 

:BOAT_32566
if 
  " + _8189 + @" == 3 
else_jump @BOAT_32636 
if 
87C1:   not path 757 available 
else_jump @BOAT_32612 
07C0: load_path 757 
jump @BOAT_32636 

:BOAT_32612
0971: sync_water 
05EB: assign_car 37@ to_path 757 
" + _8193 + @" = 3 
" + _8191 + @" = 2 

:BOAT_32636
if 
  " + _8189 + @" == 4 
else_jump @BOAT_32754 
if 
87C1:   not path 759 available 
else_jump @BOAT_32682 
07C0: load_path 759 
jump @BOAT_32754 

:BOAT_32682
if 
   not Car.Wrecked(37@)
else_jump @BOAT_32730 
Car.StorePos(37@, 204@, 205@, 206@)
0395: clear_area 1 at 204@ 205@ 206@ radius 1000.0 

:BOAT_32730
0971: sync_water 
05EB: assign_car 37@ to_path 759 
" + _8193 + @" = 3 
" + _8191 + @" = 2 

:BOAT_32754
if 
  " + _8189 + @" == 5 
else_jump @BOAT_32824 
if 
87C1:   not path 760 available 
else_jump @BOAT_32800 
07C0: load_path 760 
jump @BOAT_32824 

:BOAT_32800
0971: sync_water 
05EB: assign_car 37@ to_path 760 
" + _8193 + @" = 3 
" + _8191 + @" = 2 

:BOAT_32824
if 
  " + _8191 + @" == 2 
else_jump @BOAT_33145 
if 
   not Car.Wrecked(37@)
else_jump @BOAT_33131 
if 
   not Car.Wrecked(46@)
else_jump @BOAT_33094 
Car.StorePos(37@, 185@, 186@, 187@)
if 
  " + _8189 + @" == 1 
else_jump @BOAT_32926 
185@ -= 35.0 
186@ -= 30.0 

:BOAT_32926
if 
  " + _8189 + @" == 2 
else_jump @BOAT_32964 
185@ -= 15.0 
186@ -= 30.0 

:BOAT_32964
if 
  " + _8189 + @" == 3 
else_jump @BOAT_33002 
185@ -= 13.0 
186@ -= 13.0 

:BOAT_33002
if 
  " + _8189 + @" == 4 
else_jump @BOAT_33040 
185@ -= 10.0 
186@ -= 20.0 

:BOAT_33040
if 
  " + _8189 + @" == 5 
else_jump @BOAT_33078 
185@ -= 10.0 
186@ -= 20.0 

:BOAT_33078
Car.PutAt(46@, 185@, 186@, 10.0)

:BOAT_33094
if 
860E:   not car 37@ assigned_to_path 
else_jump @BOAT_33124 
" + _8193 + @" = 1 
" + _8191 + @" = 4 

:BOAT_33124
jump @BOAT_33145 

:BOAT_33131
" + _8193 + @" = 1 
" + _8191 + @" = 4 

:BOAT_33145
if 
  " + _8191 + @" == 3 
else_jump @BOAT_33177 
" + _8193 + @" = 1 
" + _8191 + @" = 4 

:BOAT_33177
if 
  " + _8191 + @" == 4 
else_jump @BOAT_33312 
if 
  " + _8193 + @" == 2 
else_jump @BOAT_33312 
05EC: release_car 37@ from_path 
Camera.Restore_WithJumpCut
014F: stop_timer " + _8197 + @" 
0396: pause_timer 0 
Car.Destroy(46@)
Car.Destroy(37@)
gosub @BOAT_37625 
" + _8191 + @" = 0 
014F: stop_timer " + _8197 + @" 
0396: pause_timer 0 
Car.Destroy(37@)
Car.Destroy(46@)
Actor.DestroyInstantly(47@)
Actor.DestroyInstantly(39@)
Car.Destroy(40@)
Car.Destroy(41@)
Car.Destroy(44@)
Actor.DestroyInstantly(42@)
Actor.DestroyInstantly(43@)
Actor.DestroyInstantly(45@)

:BOAT_33312
return 

:BOAT_33314
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 

:BOAT_33376
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.8 2.6 
060D: draw_text_shadow 2 rgba 0 0 0 255 
return 

:BOAT_33492
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.2 4.0 
060D: draw_text_shadow 3 rgba 0 0 0 255 
0349: set_text_draw_font 3 
return 
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.0 3.8 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 

:BOAT_33612
Player.CanMove(" + PlayerChar + @") = False
Actor.DestroyInstantly(39@)
Actor.DestroyInstantly(42@)
Actor.DestroyInstantly(43@)
Car.Destroy(40@)
Car.Destroy(41@)
Car.Destroy(44@)
Actor.DestroyInstantly(45@)
014F: stop_timer " + _8197 + @" 
40@ = Car.Create(#TROPIC, -2100.836, 2247.862, 0.0)
Car.Angle(40@) = 122.0
42@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 40@)
41@ = Car.Create(#MARQUIS, -1996.127, 2125.169, 0.0)
Car.Angle(41@) = 160.0
43@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 41@)
44@ = Car.Create(#TROPIC, -2251.171, 2129.291, 0.0)
Car.Angle(44@) = 182.0
45@ = Actor.CreateAsDriver(Mission2, #OMOBOAT, 44@)
036A: put_actor " + PlayerActor + @" in_car 37@ 
Car.DoorStatus(37@) = 4
wait 1000 
fade 0 2000 

:BOAT_33824
if 
fading 
else_jump @BOAT_33848 
wait 0 
jump @BOAT_33824 

:BOAT_33848
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
if 
  " + _8189 + @" == 4 
else_jump @BOAT_33891 
Camera.SetAtPos(-2318.049, 2312.302, 10.0)
wait 0 

:BOAT_33891
if 
   not Car.Wrecked(37@)
else_jump @BOAT_33939 
Car.StorePos(37@, 204@, 205@, 206@)
0395: clear_area 1 at 204@ 205@ 206@ radius 1000.0 

:BOAT_33939
fade 1 2000 

:BOAT_33946
if 
fading 
else_jump @BOAT_33970 
wait 0 
jump @BOAT_33946 

:BOAT_33970
if 
   not Car.Wrecked(37@)
else_jump @BOAT_34018 
Car.StorePos(37@, 204@, 205@, 206@)
0395: clear_area 1 at 204@ 205@ 206@ radius 1000.0 

:BOAT_34018
return 

:BOAT_34020
fade 0 500 

:BOAT_34027
if 
fading 
else_jump @BOAT_34051 
wait 0 
jump @BOAT_34027 

:BOAT_34051
if 
  " + _8189 + @" == 16 
else_jump @BOAT_34090 
01EB: set_traffic_density_multiplier_to 1.0 
03DE: set_pedestrians_density_multiplier_to 1.0 
jump @BOAT_34104 

:BOAT_34090
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 

:BOAT_34104
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
set_weather 13 
select_interior 0 
Actor.DestroyInstantly(39@)
Actor.DestroyInstantly(42@)
Actor.DestroyInstantly(43@)
Car.Destroy(40@)
Car.Destroy(41@)
Car.Destroy(44@)
Actor.DestroyInstantly(45@)
return 

:BOAT_34153
Marker.SetIconSize(53@, 1)
Marker.SetIconSize(54@, 1)
Marker.SetColor(52@, 4)
Marker.SetColor(51@, 4)
Marker.SetColor(53@, 4)
Marker.SetColor(54@, 4)
return 

:BOAT_34197
if 
  " + _8189 + @" == 1 
else_jump @BOAT_34503 
156@ = 0 

:BOAT_34222
if 
  8 > 156@ 
else_jump @BOAT_34303 
56@(156@,50i) = Object.Init(#BOUY, 0.0, 0.0, 100.0)
Object.CollisionDetection(56@(156@,50i)) = True
Object.ToggleInMovingList(56@(156@,50i)) = True
156@ += 1 
jump @BOAT_34222 

:BOAT_34303
if 
   not Car.Wrecked(37@)
else_jump @BOAT_34503 
035C: place_object 56@ relative_to_car 37@ with_offset 20.0 180.0 0.0 
035C: place_object 57@ relative_to_car 37@ with_offset -20.0 180.0 0.0 
035C: place_object 58@ relative_to_car 37@ with_offset 20.0 190.0 0.0 
035C: place_object 59@ relative_to_car 37@ with_offset -20.0 190.0 0.0 
035C: place_object 60@ relative_to_car 37@ with_offset 20.0 200.0 0.0 
035C: place_object 61@ relative_to_car 37@ with_offset -20.0 200.0 0.0 
035C: place_object 62@ relative_to_car 37@ with_offset 20.0 210.0 0.0 
035C: place_object 63@ relative_to_car 37@ with_offset -20.0 210.0 0.0 

:BOAT_34503
if 
  " + _8189 + @" == 2 
else_jump @BOAT_34993 
156@ = 0 

:BOAT_34528
if 
  16 > 156@ 
else_jump @BOAT_34609 
56@(156@,50i) = Object.Init(#BOUY, 0.0, 0.0, 100.0)
Object.CollisionDetection(56@(156@,50i)) = True
Object.ToggleInMovingList(56@(156@,50i)) = True
156@ += 1 
jump @BOAT_34528 

:BOAT_34609
if 
   not Car.Wrecked(37@)
else_jump @BOAT_34993 
035C: place_object 56@ relative_to_car 37@ with_offset 0.0 80.0 0.0 
035C: place_object 57@ relative_to_car 37@ with_offset 15.0 70.0 0.0 
035C: place_object 58@ relative_to_car 37@ with_offset 55.0 145.0 0.0 
035C: place_object 59@ relative_to_car 37@ with_offset 70.0 130.0 0.0 
035C: place_object 60@ relative_to_car 37@ with_offset 150.0 110.0 0.0 
035C: place_object 61@ relative_to_car 37@ with_offset 160.0 130.0 0.0 
035C: place_object 62@ relative_to_car 37@ with_offset 250.0 80.0 0.0 
035C: place_object 63@ relative_to_car 37@ with_offset 240.0 60.0 0.0 
035C: place_object 64@ relative_to_car 37@ with_offset 300.0 0.0 0.0 
035C: place_object 65@ relative_to_car 37@ with_offset 290.0 -20.0 0.0 
035C: place_object 66@ relative_to_car 37@ with_offset 380.0 -150.0 0.0 
035C: place_object 67@ relative_to_car 37@ with_offset 360.0 -150.0 0.0 
035C: place_object 68@ relative_to_car 37@ with_offset 320.0 -300.0 0.0 
035C: place_object 69@ relative_to_car 37@ with_offset 340.0 -325.0 0.0 
035C: place_object 70@ relative_to_car 37@ with_offset 230.0 -280.0 0.0 
035C: place_object 71@ relative_to_car 37@ with_offset 210.0 -300.0 0.0 

:BOAT_34993
if 
  " + _8189 + @" == 3 
else_jump @BOAT_35759 
156@ = 0 

:BOAT_35018
if 
  28 > 156@ 
else_jump @BOAT_35099 
56@(156@,50i) = Object.Init(#BOUY, 0.0, 0.0, 100.0)
Object.CollisionDetection(56@(156@,50i)) = True
Object.ToggleInMovingList(56@(156@,50i)) = True
156@ += 1 
jump @BOAT_35018 

:BOAT_35099
if 
   not Car.Wrecked(37@)
else_jump @BOAT_35759 
035C: place_object 56@ relative_to_car 37@ with_offset 0.0 100.0 0.0 
035C: place_object 57@ relative_to_car 37@ with_offset 15.0 100.0 0.0 
035C: place_object 58@ relative_to_car 37@ with_offset 40.0 200.0 0.0 
035C: place_object 59@ relative_to_car 37@ with_offset 55.0 190.0 0.0 
035C: place_object 60@ relative_to_car 37@ with_offset 0.0 300.0 0.0 
035C: place_object 61@ relative_to_car 37@ with_offset -15.0 290.0 0.0 
035C: place_object 62@ relative_to_car 37@ with_offset 140.0 320.0 0.0 
035C: place_object 63@ relative_to_car 37@ with_offset 140.0 335.0 0.0 
035C: place_object 64@ relative_to_car 37@ with_offset 220.0 370.0 0.0 
035C: place_object 65@ relative_to_car 37@ with_offset 210.0 385.0 0.0 
035C: place_object 66@ relative_to_car 37@ with_offset 210.0 470.0 0.0 
035C: place_object 67@ relative_to_car 37@ with_offset 195.0 460.0 0.0 
035C: place_object 68@ relative_to_car 37@ with_offset 195.0 570.0 0.0 
035C: place_object 69@ relative_to_car 37@ with_offset 180.0 570.0 0.0 
035C: place_object 70@ relative_to_car 37@ with_offset 95.0 570.0 0.0 
035C: place_object 71@ relative_to_car 37@ with_offset 95.0 585.0 0.0 
035C: place_object 72@ relative_to_car 37@ with_offset 15.0 500.0 0.0 
035C: place_object 73@ relative_to_car 37@ with_offset 0.0 515.0 0.0 
035C: place_object 74@ relative_to_car 37@ with_offset -90.0 585.0 0.0 
035C: place_object 75@ relative_to_car 37@ with_offset -90.0 570.0 0.0 
035C: place_object 76@ relative_to_car 37@ with_offset -160.0 500.0 0.0 
035C: place_object 77@ relative_to_car 37@ with_offset -150.0 485.0 0.0 
035C: place_object 78@ relative_to_car 37@ with_offset -240.0 430.0 0.0 
035C: place_object 79@ relative_to_car 37@ with_offset -230.0 415.0 0.0 
035C: place_object 80@ relative_to_car 37@ with_offset -140.0 330.0 0.0 
035C: place_object 81@ relative_to_car 37@ with_offset -140.0 315.0 0.0 
035C: place_object 82@ relative_to_car 37@ with_offset -30.0 220.0 0.0 
035C: place_object 83@ relative_to_car 37@ with_offset -40.0 205.0 0.0 

:BOAT_35759
if 
  " + _8189 + @" == 4 
else_jump @BOAT_36430 
156@ = 0 

:BOAT_35784
if 
  20 > 156@ 
else_jump @BOAT_35865 
56@(156@,50i) = Object.Init(#BOUY, 0.0, 0.0, 100.0)
Object.CollisionDetection(56@(156@,50i)) = True
Object.ToggleInMovingList(56@(156@,50i)) = True
156@ += 1 
jump @BOAT_35784 

:BOAT_35865
157@ = 0 

:BOAT_35872
if 
  1 > 157@ 
else_jump @BOAT_35931 
106@(157@,50i) = Object.Init(#WATERJUMPX2, 20.0, 20.0, 150.0)
157@ += 1 
jump @BOAT_35872 

:BOAT_35931
if 
   not Car.Wrecked(37@)
else_jump @BOAT_36430 
035C: place_object 56@ relative_to_car 37@ with_offset 91.0 480.0 0.0 
035C: place_object 57@ relative_to_car 37@ with_offset 109.0 480.0 0.0 
035C: place_object 106@ relative_to_car 37@ with_offset 100.0 480.0 0.0 
035C: place_object 58@ relative_to_car 37@ with_offset 75.0 500.0 0.0 
035C: place_object 59@ relative_to_car 37@ with_offset 125.0 500.0 0.0 
035C: place_object 60@ relative_to_car 37@ with_offset 75.0 510.0 0.0 
035C: place_object 61@ relative_to_car 37@ with_offset 125.0 510.0 0.0 
035C: place_object 62@ relative_to_car 37@ with_offset 75.0 520.0 0.0 
035C: place_object 63@ relative_to_car 37@ with_offset 125.0 520.0 0.0 
035C: place_object 64@ relative_to_car 37@ with_offset 75.0 530.0 0.0 
035C: place_object 65@ relative_to_car 37@ with_offset 125.0 530.0 0.0 
035C: place_object 66@ relative_to_car 37@ with_offset 75.0 540.0 0.0 
035C: place_object 67@ relative_to_car 37@ with_offset 125.0 540.0 0.0 
035C: place_object 68@ relative_to_car 37@ with_offset 75.0 550.0 0.0 
035C: place_object 69@ relative_to_car 37@ with_offset 125.0 550.0 0.0 
035C: place_object 70@ relative_to_car 37@ with_offset 75.0 560.0 0.0 
035C: place_object 71@ relative_to_car 37@ with_offset 125.0 560.0 0.0 
035C: place_object 72@ relative_to_car 37@ with_offset 75.0 570.0 0.0 
035C: place_object 73@ relative_to_car 37@ with_offset 125.0 570.0 0.0 
035C: place_object 74@ relative_to_car 37@ with_offset 75.0 580.0 0.0 
035C: place_object 75@ relative_to_car 37@ with_offset 125.0 580.0 0.0 

:BOAT_36430
if 
  " + _8189 + @" == 5 
else_jump @BOAT_37623 
156@ = 0 

:BOAT_36455
if 
  44 > 156@ 
else_jump @BOAT_36536 
56@(156@,50i) = Object.Init(#BOUY, 0.0, 0.0, 100.0)
Object.CollisionDetection(56@(156@,50i)) = True
Object.ToggleInMovingList(56@(156@,50i)) = True
156@ += 1 
jump @BOAT_36455 

:BOAT_36536
157@ = 0 

:BOAT_36543
if 
  3 > 157@ 
else_jump @BOAT_36602 
106@(157@,50i) = Object.Init(#WATERJUMPX2, 20.0, 20.0, 150.0)
157@ += 1 
jump @BOAT_36543 

:BOAT_36602
if 
   not Car.Wrecked(37@)
else_jump @BOAT_37623 
035C: place_object 56@ relative_to_car 37@ with_offset 25.0 100.0 0.0 
035C: place_object 57@ relative_to_car 37@ with_offset 10.0 100.0 0.0 
035C: place_object 58@ relative_to_car 37@ with_offset -30.0 170.0 0.0 
035C: place_object 59@ relative_to_car 37@ with_offset -50.0 160.0 0.0 
035C: place_object 60@ relative_to_car 37@ with_offset -100.0 190.0 0.0 
035C: place_object 61@ relative_to_car 37@ with_offset -120.0 170.0 0.0 
035C: place_object 62@ relative_to_car 37@ with_offset -170.0 260.0 0.0 
035C: place_object 63@ relative_to_car 37@ with_offset -188.0 260.0 0.0 
035C: place_object 106@ relative_to_car 37@ with_offset -179.0 360.0 -6.509 
035C: place_object 64@ relative_to_car 37@ with_offset -170.0 360.0 0.0 
035C: place_object 65@ relative_to_car 37@ with_offset -188.0 360.0 0.0 
035C: place_object 66@ relative_to_car 37@ with_offset -180.0 500.0 0.0 
035C: place_object 67@ relative_to_car 37@ with_offset -195.0 500.0 0.0 
035C: place_object 68@ relative_to_car 37@ with_offset -50.0 600.0 0.0 
035C: place_object 69@ relative_to_car 37@ with_offset -30.0 600.0 0.0 
Object.PutAt(107@, -2682.159, 1946.412, 0.9)
Object.Angle(107@) = 180.0
Object.PutAt(70@, -2689.573, 1944.864, 0.0)
Object.PutAt(71@, -2674.354, 1944.607, 0.0)
Object.PutAt(108@, -2681.746, 1608.794, 0.9)
Object.Angle(108@) = 180.0
Object.PutAt(72@, -2689.573, 1607.794, 0.0)
Object.PutAt(73@, -2674.354, 1607.794, 0.0)
Object.PutAt(74@, -2689.27, 1533.282, 0.0)
Object.PutAt(75@, -2674.64, 1530.12, 0.0)
Object.PutAt(76@, -2553.7, 1494.392, 0.0)
Object.PutAt(77@, -2550.742, 1481.417, 0.0)
Object.PutAt(78@, -2453.7, 1494.392, 0.0)
Object.PutAt(79@, -2450.742, 1481.417, 0.0)
Object.PutAt(80@, -2353.7, 1474.392, 0.0)
Object.PutAt(81@, -2350.742, 1461.417, 0.0)
Object.PutAt(82@, -2284.242, 1547.581, 0.0)
Object.PutAt(83@, -2270.893, 1550.765, 0.0)
Object.PutAt(84@, -2334.242, 1647.581, 0.0)
Object.PutAt(85@, -2320.893, 1650.765, 0.0)
Object.PutAt(86@, -2284.242, 1747.581, 0.0)
Object.PutAt(87@, -2270.893, 1750.765, 0.0)
Object.PutAt(88@, -2139.394, 1821.263, 0.0)
Object.PutAt(89@, -2134.581, 1808.785, 0.0)
Object.PutAt(90@, -2039.394, 1761.263, 0.0)
Object.PutAt(91@, -2034.581, 1748.785, 0.0)
Object.PutAt(92@, -1939.394, 1841.263, 0.0)
Object.PutAt(93@, -1934.581, 1828.785, 0.0)
Object.PutAt(94@, -1809.394, 1801.263, 0.0)
Object.PutAt(95@, -1804.581, 1788.785, 0.0)
Object.PutAt(96@, -1831.853, 1909.105, 0.0)
Object.PutAt(97@, -1847.253, 1906.112, 0.0)
Object.PutAt(98@, -1879.002, 2073.601, 0.0)
Object.PutAt(99@, -1893.786, 2068.166, 0.0)

:BOAT_37623
return 

:BOAT_37625
156@ = 0 

:BOAT_37632
if 
  50 > 156@ 
else_jump @BOAT_37682 
Object.Destroy(56@(156@,50i))
Object.Destroy(106@(156@,50i))
156@ += 1 
jump @BOAT_37632 

:BOAT_37682
return 

:BOAT_37684
09FB: 252@ = current_language 
return 

:BOAT_37691
0A0B: set_rendering_origin_at_3D_coord -2185.335 2410.409 3.9752 angle 122.2585 
03E6: remove_text_box 
00BE: text_clear_all 
Actor.Angle(" + PlayerActor + @") = 177@
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
return 

:BOAT_37731
if 
  " + Mission_Boat_School_Passed + @" == 0 
else_jump @BOAT_37803 
040D: unload_wav 3 
00BA: show_text_styled GXT 'BOAT_P2' time 5000 style 1  
00BB: show_text_lowpriority GXT 'BOAT_P1' time 5000 flag 1  
0394: play_music 2 
Player.ClearWantedLevel(" + PlayerChar + @")
0595: mission_complete 
" + Mission_Boat_School_Passed + @" = 1 

:BOAT_37803
return 

:BOAT_37805
097A: play_audio_at 0.0 0.0 0.0 event 1001 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1098 
0501: set_player " + PlayerChar + @" driveby_mode 1 
04D8: set_actor " + PlayerActor + @" drowns_in_water 1 
040D: unload_wav 3 
0826: enable_hud 1 
0581: enable_radar 1 
09B9: show_entered_car_name 1 
09BA: show_entered_zone_name 1 
014F: stop_timer " + _8197 + @" 
Marker.Disable(52@)
Marker.Disable(51@)
Marker.Disable(53@)
Marker.Disable(54@)
Model.Destroy(#OMOBOAT)
Actor.RemoveReferences(39@)
Actor.RemoveReferences(38@)
Car.Destroy(37@)
Car.Destroy(46@)
Actor.DestroyInstantly(42@)
Actor.DestroyInstantly(43@)
Car.Destroy(40@)
Car.Destroy(41@)
Car.Destroy(44@)
Actor.DestroyInstantly(45@)
Model.Destroy(#DINGHY)
Model.Destroy(#POLMAV)
Model.Destroy(#COASTG)
Model.Destroy(#MARQUIS)
Model.Destroy(#TROPIC)
Model.Destroy(#VORTEX)
01B7: release_weather 
Player.CanMove(" + PlayerChar + @") = True
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
if 
  " + parked_Jetmax_Exists + @" == 0 
else_jump @BOAT_38132 
if 
  " + _1972 + @" == 1 
else_jump @BOAT_38132 
if 
  " + _1975 + @" == 1 
else_jump @BOAT_38132 
if 
  " + _1978 + @" == 1 
else_jump @BOAT_38132 
if 
  " + _1981 + @" == 1 
else_jump @BOAT_38132 
if 
  " + _1984 + @" == 1 
else_jump @BOAT_38132 
" + parked_Jetmax_Exists + @" = 1 
" + parked_Squalo_Exists + @" = 99 
" + parked_Marquis_Exists + @" = 99 

:BOAT_38132
if 
  " + parked_Squalo_Exists + @" == 0 
else_jump @BOAT_38254 
if 
  " + _1971 + @" == 1 
else_jump @BOAT_38254 
if 
  " + _1974 + @" == 1 
else_jump @BOAT_38254 
if 
  " + _1977 + @" == 1 
else_jump @BOAT_38254 
if 
  " + _1980 + @" == 1 
else_jump @BOAT_38254 
if 
  " + _1983 + @" == 1 
else_jump @BOAT_38254 
" + parked_Squalo_Exists + @" = 1 
" + parked_Marquis_Exists + @" = 99 

:BOAT_38254
if 
  " + parked_Marquis_Exists + @" == 0 
else_jump @BOAT_38369 
if 
  " + _1970 + @" == 1 
else_jump @BOAT_38369 
if 
  " + _1973 + @" == 1 
else_jump @BOAT_38369 
if 
  " + _1976 + @" == 1 
else_jump @BOAT_38369 
if 
  " + _1979 + @" == 1 
else_jump @BOAT_38369 
if 
  " + _1982 + @" == 1 
else_jump @BOAT_38369 
" + parked_Marquis_Exists + @" = 1 

:BOAT_38369
if 
  " + parked_Jetmax_Exists + @" == 1 
else_jump @BOAT_38436" );
CAR_PARK.set_chance_to_generate( parked_Jetmax, 101 );
CAR_PARK.set_chance_to_generate( parked_Squalo, 101 );
CAR_PARK.set_chance_to_generate( parked_Marquis, 101 );
AppendLine( @"" + parked_Jetmax_Exists + @" = 2 

:BOAT_38436
if 
  " + parked_Squalo_Exists + @" == 1 
else_jump @BOAT_38489" );
CAR_PARK.set_chance_to_generate( parked_Squalo, 101 );
CAR_PARK.set_chance_to_generate( parked_Marquis, 101 );
AppendLine( @"" + parked_Squalo_Exists + @" = 2 

:BOAT_38489
if 
  " + parked_Marquis_Exists + @" == 1 
else_jump @BOAT_38528" );
CAR_PARK.set_chance_to_generate( parked_Marquis, 101 );
AppendLine( @"" + parked_Marquis_Exists + @" = 2 

:BOAT_38528
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}