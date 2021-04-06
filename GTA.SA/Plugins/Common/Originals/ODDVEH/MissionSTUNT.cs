using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class STUNT : MissionCustom {

            Int tmp_STUNT_Missions_BestTime = global( STUNT_Missions_BestTime.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @STUNT_36 
if 
wasted_or_busted 
else_jump @STUNT_27 
gosub @STUNT_1602 

:STUNT_27
gosub @STUNT_2020 
end_thread 

:STUNT_36
" + OnMission + @" = 1 
if 
  " + Mission_BMX_Stunt_Passed + @" == 0 
else_jump @STUNT_63 
increment_mission_attempts 

:STUNT_63
wait 0 
054C: use_GXT_table 'STUNT' 

:STUNT_89
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @STUNT_116 
wait 0 
jump @STUNT_89 

:STUNT_116
34@ = Actor.MissionCar(" + PlayerActor + @")
Car.Health(34@) = 3000
gosub @STUNT_2121 
35@ = 1 
56@ = 0 

:STUNT_153
if 
001D:   187@ > 56@ 
else_jump @STUNT_197 
36@(56@,20i) = 0 
56@ += 1 
jump @STUNT_153 

:STUNT_197
if 
  " + OnMission + @" == 0 
else_jump @STUNT_229 
018A: 57@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 

:STUNT_229
58@ = 0 
59@ = 0 
Player.CanMove(" + PlayerChar + @") = False
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 1 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
02A3: enable_widescreen 1 
03F4: set_all_cars_apply_damage_rules 0 
Camera.SetPosition(188@, 189@, 190@, 0.0, 0.0, 0.0)
Camera.PointAt(191@, 192@, 193@, 2)
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
0084: " + _8267 + @" = " + Current_Time_in_ms2 + @" 
" + _8267 + @" += 5000 
00BC: show_text_highpriority GXT 'STUNT_6' time 5000 flag 1  
80@ = 0 

:STUNT_355
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
  58@ == 0 
else_jump @STUNT_510 
if 
00E1:   player 0 pressed_key 16 
else_jump @STUNT_503 
if 
  80@ == 1 
else_jump @STUNT_496 
Player.CanMove(" + PlayerChar + @") = True
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 0 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
02A3: enable_widescreen 0 
03F4: set_all_cars_apply_damage_rules 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
" + _8267 + @" = 11000 
03C3: set_timer_to " + _8267 + @" type 1 GXT 'STUNT_2' 
008B: 81@ = " + Current_Time_in_ms2 + @" 
58@ = 1 
80@ = 0 

:STUNT_496
jump @STUNT_510 

:STUNT_503
80@ = 1 

:STUNT_510
if 
  58@ == 0 
else_jump @STUNT_619 
if 
001C:   " + Current_Time_in_ms2 + @" > " + _8267 + @" 
else_jump @STUNT_619 
Player.CanMove(" + PlayerChar + @") = True
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 0 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
02A3: enable_widescreen 0 
03F4: set_all_cars_apply_damage_rules 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
" + _8267 + @" = 11000 
03C3: set_timer_to " + _8267 + @" type 1 GXT 'STUNT_2' 
008B: 81@ = " + Current_Time_in_ms2 + @" 
58@ = 1 

:STUNT_619
if 
   not Car.Wrecked(34@)
else_jump @STUNT_1505 
if 
   Actor.InCar(" + PlayerActor + @", 34@)
else_jump @STUNT_1180 
if 
  35@ == 1 
else_jump @STUNT_856 
03D5: remove_text 'STUNT_1'  
Marker.Disable(57@)
56@ = 0 

:STUNT_695
if 
001D:   187@ > 56@ 
else_jump @STUNT_849 
if 
  36@(56@,20i) == 0 
else_jump @STUNT_835 
018A: 82@(56@,20i) = create_checkpoint_at 127@(56@,20f) 147@(56@,20f) 167@(56@,20f) 
Marker.SetColor(82@(56@,20i), 0)
06D5: 102@(56@,20i) = create_racing_checkpoint_at 127@(56@,20f) 147@(56@,20f) 167@(56@,20f) point_to 127@(56@,20f) 147@(56@,20f) 167@(56@,20f) type 3 radius 0.8 

:STUNT_835
56@ += 1 
jump @STUNT_695 

:STUNT_849
35@ = 0 

:STUNT_856
56@ = 0 

:STUNT_863
if 
001D:   187@ > 56@ 
else_jump @STUNT_1173 
if 
  36@(56@,20i) == 0 
else_jump @STUNT_1159 
0996: set_racing_checkpoint 102@(56@,20i) Z_angle_to 60@(56@,20f) 
016F: create_particle 2 rotation_factor 0.0 size 1.0 intensity 150 flags 0 0 0 at 127@(56@,20f) 147@(56@,20f) 167@(56@,20f) 
60@(56@,20f) += 10.0 
if 
  60@(56@,20f) > 360.0 
else_jump @STUNT_1017 
60@(56@,20f) -= 360.0 

:STUNT_1017
if 
0100:   actor " + PlayerActor + @" in_sphere 127@(56@,20f) 147@(56@,20f) 167@(56@,20f) radius 2.5 2.5 2.5 sphere 0 in_car 
else_jump @STUNT_1159 
Marker.Disable(82@(56@,20i))
06D6: disable_racing_checkpoint 102@(56@,20i) 
097A: play_audio_at 127@(56@,20f) 147@(56@,20f) 167@(56@,20f) event 1058 
" + _8267 + @" += 10000 
01E5: show_text_1number_highpriority GXT 'STUNT_3' number 10 time 1500 flag 1  
59@ += 1 
36@(56@,20i) += 1 

:STUNT_1159
56@ += 1 
jump @STUNT_863 

:STUNT_1173
jump @STUNT_1498 

:STUNT_1180
if 
  35@ == 0 
else_jump @STUNT_1336 
56@ = 0 

:STUNT_1205
if 
001D:   187@ > 56@ 
else_jump @STUNT_1256 
Marker.Disable(82@(56@,20i))
06D6: disable_racing_checkpoint 102@(56@,20i) 
56@ += 1 
jump @STUNT_1205 

:STUNT_1256
57@ = Marker.CreateAboveCar(34@)
07E0: set_marker 57@ type_to 1 
if 
  " + _8267 + @" > 25400 
else_jump @STUNT_1313 
008B: 122@ = " + Current_Time_in_ms2 + @" 
122@ += 25400 
jump @STUNT_1329 

:STUNT_1313
008B: 122@ = " + Current_Time_in_ms2 + @" 
005C: 122@ += " + _8267 + @" 

:STUNT_1329
35@ = 1 

:STUNT_1336
0085: 123@ = 122@ 
0064: 123@ -= " + Current_Time_in_ms2 + @" 
123@ /= 1000 
if 
  1 > 123@ 
else_jump @STUNT_1385 
123@ = 0 

:STUNT_1385
if 
001E:   " + Current_Time_in_ms2 + @" > 122@ 
else_jump @STUNT_1427 
00BC: show_text_highpriority GXT 'STUNT_4' time 5000 flag 1  
jump @STUNT_1602 

:STUNT_1427
if 
  123@ == 1 
else_jump @STUNT_1475 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'STUNT_8' number 123@ time 200 flag 1  
jump @STUNT_1498 

:STUNT_1475
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'STUNT_1' number 123@ time 200 flag 1  

:STUNT_1498
jump @STUNT_1528 

:STUNT_1505
00BC: show_text_highpriority GXT 'STUNT_5' time 5000 flag 1  
jump @STUNT_1602 

:STUNT_1528
if 
003B:   59@ == 187@ 
else_jump @STUNT_1554 
jump @STUNT_1620 

:STUNT_1554
if 
  " + _8267 + @" == 0 
else_jump @STUNT_1595 
00BC: show_text_highpriority GXT 'STUNT_7' time 5000 flag 1  
jump @STUNT_1602 

:STUNT_1595
jump @STUNT_355 

:STUNT_1602
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
return 

:STUNT_1620
Player.Money(" + PlayerChar + @") += 1000
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 1 
008B: 124@ = " + Current_Time_in_ms2 + @" 
0062: 124@ -= 81@ 
124@ /= 1000 
if 
  " + STUNT_Mission_Type + @" == 0 
else_jump @STUNT_1726 
if 
  " + Mission_BMX_Stunt_Passed + @" == 0 
else_jump @STUNT_1719 
0318: set_latest_mission_passed 'BMX'  
0394: play_music 2 
" + Mission_BMX_Stunt_Passed + @" = 1 

:STUNT_1719
042E: downdate_integer_stat 49 to 124@ 

:STUNT_1726
if 
  " + STUNT_Mission_Type + @" == 1 
else_jump @STUNT_1792 
if 
  " + Mission_NRG500_Stunt_Passed + @" == 0 
else_jump @STUNT_1784 
0318: set_latest_mission_passed 'NRG500'  
0394: play_music 2 
" + Mission_NRG500_Stunt_Passed + @" = 1 

:STUNT_1784
042E: downdate_integer_stat 222 to 124@ 

:STUNT_1792
0085: 125@ = 124@ 
125@ /= 60 
0085: 126@ = 125@ 
126@ *= 60 
0085: 123@ = 124@ 
0062: 123@ -= 126@ 
if 
001E:   " + tmp_STUNT_Missions_BestTime + @"(" + STUNT_Mission_Type + @",2i) > 124@ 
else_jump @STUNT_1949 
if 
  10 > 123@ 
else_jump @STUNT_1908 
036D: show_text_2numbers_styled GXT 'STUNTN0' numbers 125@ 123@ time 5000 style 1  
jump @STUNT_1930 

:STUNT_1908
036D: show_text_2numbers_styled GXT 'STUNTPN' numbers 125@ 123@ time 5000 style 1  

:STUNT_1930
008A: " + tmp_STUNT_Missions_BestTime + @"(" + STUNT_Mission_Type + @",2i) = 124@ 
jump @STUNT_2018 

:STUNT_1949
if 
  10 > 123@ 
else_jump @STUNT_1996 
036D: show_text_2numbers_styled GXT 'STUNTT0' numbers 125@ 123@ time 5000 style 1  
jump @STUNT_2018 

:STUNT_1996
036D: show_text_2numbers_styled GXT 'STUNTPT' numbers 125@ 123@ time 5000 style 1  

:STUNT_2018
return 

:STUNT_2020
03D5: remove_text 'STUNT_1'  
03D5: remove_text 'STUNT_3'  
56@ = 0 

:STUNT_2049
if 
001D:   187@ > 56@ 
else_jump @STUNT_2100 
Marker.Disable(82@(56@,20i))
06D6: disable_racing_checkpoint 102@(56@,20i) 
56@ += 1 
jump @STUNT_2049 

:STUNT_2100
Marker.Disable(57@)
014F: stop_timer " + _8267 + @" 
" + OnMission + @" = 0 
mission_cleanup 
return 

:STUNT_2121
0871: init_jump_table " + STUNT_Mission_Type + @" total_jumps 2 default_jump 0 @STUNT_3442 jumps 0 @STUNT_2184 1 @STUNT_2828 -1 @STUNT_3442 -1 @STUNT_3442 -1 @STUNT_3442 -1 @STUNT_3442 -1 @STUNT_3442 

:STUNT_2184
127@ = 1955.012 
147@ = -1367.72 
167@ = 24.7354 
128@ = 1954.609 
148@ = -1376.964 
168@ = 24.2187 
129@ = 1887.392 
149@ = -1362.954 
169@ = 19.4329 
130@ = 1914.137 
150@ = -1427.099 
170@ = 15.5805 
131@ = 1908.552 
151@ = -1388.389 
171@ = 10.3294 
132@ = 1882.362 
152@ = -1427.686 
172@ = 10.3294 
133@ = 1953.349 
153@ = -1426.586 
173@ = 10.3294 
134@ = 1878.189 
154@ = -1388.81 
174@ = 15.2464 
135@ = 1878.184 
155@ = -1388.839 
175@ = 18.1461 
136@ = 1872.327 
156@ = -1451.051 
176@ = 15.7645 
137@ = 1905.178 
157@ = -1413.675 
177@ = 13.5322 
138@ = 1949.503 
158@ = -1411.546 
178@ = 15.1837 
139@ = 1867.153 
159@ = -1410.007 
179@ = 13.5322 
140@ = 1909.341 
160@ = -1369.846 
180@ = 16.7966 
141@ = 1939.243 
161@ = -1388.132 
181@ = 19.2615 
142@ = 1904.888 
162@ = -1360.622 
182@ = 13.5322 
143@ = 1930.234 
163@ = -1398.62 
183@ = 16.8554 
144@ = 1888.765 
164@ = -1399.326 
184@ = 17.2408 
145@ = 1900.948 
165@ = -1397.83 
185@ = 15.6868 
187@ = 19 
188@ = 1964.753 
189@ = -1368.362 
190@ = 29.6217 
191@ = 1963.934 
192@ = -1368.818 
193@ = 29.2725 
jump @STUNT_3442 

:STUNT_2828
127@ = -1632.058 
147@ = 143.152 
167@ = 3.4111 
128@ = -1632.021 
148@ = 83.0413 
168@ = 7.5331 
129@ = -1689.148 
149@ = 53.3936 
169@ = 11.7703 
130@ = -1606.423 
150@ = 133.4396 
170@ = -10.9911 
131@ = -1680.386 
151@ = 87.0915 
171@ = 8.2325 
132@ = -1666.295 
152@ = 102.0489 
172@ = -1.5025 
133@ = -1654.692 
153@ = 60.7782 
173@ = 7.6501 
134@ = -1684.867 
154@ = 74.6374 
174@ = -7.0328 
135@ = -1583.797 
155@ = 126.1577 
175@ = 4.157 
136@ = -1667.705 
156@ = 49.5191 
176@ = 6.5634 
137@ = -1611.585 
157@ = 106.3131 
177@ = -3.6465 
138@ = -1590.556 
158@ = 148.9676 
178@ = 4.113 
139@ = -1671.959 
159@ = 98.6 
179@ = 8.9263 
140@ = -1693.32 
160@ = 65.1187 
180@ = 8.7997 
141@ = -1660.951 
161@ = 107.6739 
181@ = -2.1545 
142@ = -1654.071 
162@ = 77.2629 
182@ = -10.2893 
143@ = -1645.494 
163@ = 107.2477 
183@ = -10.6617 
144@ = -1673.735 
164@ = 56.9287 
184@ = -10.674 
187@ = 18 
188@ = -1681.464 
189@ = 27.2091 
190@ = 9.6606 
191@ = -1681.252 
192@ = 28.183 
193@ = 9.5773 
jump @STUNT_3442 

:STUNT_3442
return" );
            }

        }

    }

}