﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalRases {

        private sealed class KICKSTA : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @KICKSTA_54 
if 
wasted_or_busted 
else_jump @KICKSTA_38 
gosub @KICKSTA_7448 

:KICKSTA_38
gosub @KICKSTA_7586 
end_thread 
49@ = 0 

:KICKSTA_54
0A0E: disable_text_with_style 1 
" + OnMission + @" = 1 
48@ = 0 
249@ = 1.5 
253@ = 0 
254@ = 0 
" + _8262 + @" = 0 
257@ = 0 
if 
  " + Mission_Kickstart_Passed + @" == 0 
else_jump @KICKSTA_130 
increment_mission_attempts 

:KICKSTA_130
" + _8250 + @" = 0 
" + _8256 + @" = 240000 
" + _8254 + @" = 30000 
50@ = -1376.437 
83@ = 1562.29 
116@ = 1059.0 
182@ = 0 
215@ = 0 
51@ = -1354.842 
84@ = 1585.201 
117@ = 1057.885 
183@ = 0 
216@ = 0 
52@ = -1408.025 
85@ = 1568.736 
118@ = 1055.838 
184@ = 0 
217@ = 0 
53@ = -1451.728 
86@ = 1571.065 
119@ = 1059.0 
185@ = 0 
218@ = 1 
54@ = -1487.554 
87@ = 1564.278 
120@ = 1056.457 
186@ = 0 
219@ = 1 
55@ = -1466.286 
88@ = 1595.355 
121@ = 1057.325 
187@ = 0 
220@ = 2 
56@ = -1387.597 
89@ = 1572.125 
122@ = 1053.929 
188@ = 0 
221@ = 0 
57@ = -1362.579 
90@ = 1614.624 
123@ = 1055.33 
189@ = 0 
222@ = 1 
58@ = -1359.51 
91@ = 1638.219 
124@ = 1056.035 
190@ = 0 
223@ = 2 
59@ = -1371.351 
92@ = 1623.274 
125@ = 1054.659 
191@ = 0 
224@ = 1 
60@ = -1369.52 
93@ = 1634.025 
126@ = 1055.772 
192@ = 0 
225@ = 2 
61@ = -1384.616 
94@ = 1603.547 
127@ = 1053.595 
193@ = 0 
226@ = 0 
62@ = -1398.996 
95@ = 1603.275 
128@ = 1055.156 
194@ = 0 
227@ = 0 
63@ = -1403.911 
96@ = 1645.158 
129@ = 1071.462 
195@ = 0 
228@ = 1 
64@ = -1443.392 
97@ = 1648.548 
130@ = 1054.287 
196@ = 0 
229@ = 0 
65@ = -1457.003 
98@ = 1648.714 
131@ = 1054.937 
197@ = 0 
230@ = 0 
66@ = -1486.931 
99@ = 1630.226 
132@ = 1056.626 
198@ = 0 
231@ = 0 
67@ = -1482.813 
100@ = 1642.205 
133@ = 1060.704 
199@ = 0 
232@ = 2 
68@ = -1484.813 
101@ = 1597.116 
134@ = 1061.382 
200@ = 0 
233@ = 1 
69@ = -1431.399 
102@ = 1598.063 
135@ = 1054.752 
201@ = 0 
234@ = 0 
70@ = -1420.682 
103@ = 1598.275 
136@ = 1054.956 
202@ = 0 
235@ = 0 
71@ = -1408.107 
104@ = 1585.364 
137@ = 1055.691 
203@ = 0 
236@ = 0 
72@ = -1408.217 
105@ = 1593.302 
138@ = 1055.617 
204@ = 0 
237@ = 0 
73@ = -1462.244 
106@ = 1622.424 
139@ = 1054.313 
205@ = 0 
238@ = 1 
74@ = -1461.74 
107@ = 1635.753 
140@ = 1054.007 
206@ = 0 
239@ = 1 
75@ = -1453.893 
108@ = 1636.028 
141@ = 1056.18 
207@ = 0 
240@ = 1 
76@ = -1454.055 
109@ = 1628.601 
142@ = 1054.298 
208@ = 0 
241@ = 2 
77@ = -1454.067 
110@ = 1617.637 
143@ = 1055.999 
209@ = 0 
242@ = 2 
78@ = -1450.026 
111@ = 1620.467 
144@ = 1056.421 
210@ = 0 
243@ = 2 
79@ = -1407.732 
112@ = 1617.416 
145@ = 1054.797 
211@ = 0 
244@ = 1 
80@ = -1414.159 
113@ = 1607.16 
146@ = 1054.843 
212@ = 0 
245@ = 1 
81@ = -1388.309 
114@ = 1620.99 
147@ = 1054.951 
213@ = 0 
246@ = 2 
82@ = -1431.09 
115@ = 1580.832 
148@ = 1055.759 
214@ = 0 
247@ = 1 
" + _8257 + @" = 0 
" + _8259 + @" = 0 
" + _8258 + @" = 0 
35@ = 0 
" + _8260 + @" = 0 
" + _8261 + @" = 33 
37@ = 0.0 
38@ = 0.0 
39@ = 0.0 
40@ = 0.0 
41@ = 0.0 
42@ = 0.0 
43@ = 0 
45@ = 0 
46@ = 0 
47@ = 0 
255@ = 0 
wait 0 
054C: use_GXT_table 'KICKSTT' 
Player.CanMove(" + PlayerChar + @") = False
0169: set_fade_color_RGB 0 0 0 
fade 0 2000 

:KICKSTA_1781
if 
fading 
else_jump @KICKSTA_1805 
wait 0 
jump @KICKSTA_1781 

:KICKSTA_1805
09FF: set_restart_closest_to 1579.57 1769.011 9.828 
057E: set_radar_grey 1 
select_interior 14 
04E4: refresh_game_renderer_at -1473.187 1565.173 
Actor.PutAt(" + PlayerActor + @", -1473.187, 1565.173, 1051.589)
0860: link_actor " + PlayerActor + @" to_interior 14 
0581: enable_radar 1 
Actor.Angle(" + PlayerActor + @") = 266.488
Camera.SetAtPos(-1473.187, 1565.173, 1051.789)
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
04F9: set_sky_color 2 fade 0 
Model.Load(#SANCHEZ)

:KICKSTA_1915
if 
   not Model.Available(#SANCHEZ)
else_jump @KICKSTA_1942 
wait 0 
jump @KICKSTA_1915 

:KICKSTA_1942
34@ = Car.Create(#SANCHEZ, -1472.38, 1563.576, 1051.417)
0840: link_car 34@ to_interior 14 
Car.Angle(34@) = 266.488
Car.SetImmunities(34@, 1, 1, 1, 1, 1)
36@ = Marker.CreateAboveCar(34@)
07E0: set_marker 36@ type_to 1 
03AB: set_car 34@ strong 1 
03BC: 44@ = create_sphere_at -1464.32 1556.69 1051.75 radius 3.0 
256@ = 0 

:KICKSTA_2051
if 
  33 > 256@ 
else_jump @KICKSTA_2300 
if 
  215@(256@,33i) == 0 
else_jump @KICKSTA_2113 
250@ = 0 
251@ = 255 
252@ = 0 

:KICKSTA_2113
if 
  215@(256@,33i) == 1 
else_jump @KICKSTA_2158 
250@ = 255 
251@ = 150 
252@ = 0 

:KICKSTA_2158
if 
  215@(256@,33i) == 2 
else_jump @KICKSTA_2202 
250@ = 255 
251@ = 0 
252@ = 0 

:KICKSTA_2202
024F: create_corona_with_radius 249@ type 0 lensflares 0 with_color 250@ 251@ 252@ at 50@(256@,33f) 50@(256@,33f) 50@(256@,33f) 
0167: 149@(256@,33i) = create_marker_at 50@(256@,33f) 50@(256@,33f) 50@(256@,33f) color 0 flag 2 
Marker.SetIconSize(149@(256@,33i), 1)
256@ += 1 
jump @KICKSTA_2051 

:KICKSTA_2300
wait 1000 
02A3: enable_widescreen 1 
01F7: set_player " + PlayerChar + @" ignored_by_cops 1 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
Player.CanMove(" + PlayerChar + @") = False
040D: unload_wav 1 
03CF: load_wav 36205 as 1 

:KICKSTA_2343
if 
83D0:   not wav 1 loaded 
else_jump @KICKSTA_2369 
wait 0 
jump @KICKSTA_2343 

:KICKSTA_2369
0169: set_fade_color_RGB 0 0 0 
fade 1 1500 
Camera.SetPosition(-1461.084, 1558.448, 1054.46, 0.0, 0.0, 0.0)
Camera.PointAt(-1460.135, 1558.761, 1054.429, 2)
0925: restore_camera_to_user_defined 
092F: lock_camera_target_point 1 
0930: lock_camera_position 1 
0936: set_camera -1461.084 1558.448 1054.46 position_to -1474.255 1561.567 1052.553 time 6000 smooth_transition 1 
0920: point_camera -1460.135 1558.761 1054.429 transverse_to -1473.741 1562.424 1052.533 time 6000 smooth_transition 1 
03D1: play_wav 1 

:KICKSTA_2523
if 
fading 
else_jump @KICKSTA_2766 
wait 0 
if 
   Car.Wrecked(34@)
else_jump @KICKSTA_2744 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK1_7' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_2594
if 
fading 
else_jump @KICKSTA_2618 
wait 0 
jump @KICKSTA_2594 

:KICKSTA_2618
select_interior 0 
Camera.SetAtPos(1105.21, 1604.649, 12.51)
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_2662 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_2662
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_2705 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_2725 

:KICKSTA_2705
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_2725
wait 1500 
jump @KICKSTA_7448 
jump @KICKSTA_2752 

:KICKSTA_2744
Car.Health(34@) = 1000

:KICKSTA_2752
gosub @KICKSTA_7900 
jump @KICKSTA_2523 

:KICKSTA_2766
00BC: show_text_highpriority GXT 'KICK_10' time 10000 flag 1  
32@ = 0 
0707: start_scene_skip_to @KICKSTA_3415 

:KICKSTA_2796
if 
  7000 > 32@ 
else_jump @KICKSTA_3045 
wait 0 
if 
   Car.Wrecked(34@)
else_jump @KICKSTA_3023 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK1_7' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_2873
if 
fading 
else_jump @KICKSTA_2897 
wait 0 
jump @KICKSTA_2873 

:KICKSTA_2897
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_2941 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_2941
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_2984 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_3004 

:KICKSTA_2984
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_3004
wait 1500 
jump @KICKSTA_7448 
jump @KICKSTA_3031 

:KICKSTA_3023
Car.Health(34@) = 1000

:KICKSTA_3031
gosub @KICKSTA_7900 
jump @KICKSTA_2796 

:KICKSTA_3045
03D5: remove_text 'KICK_10'  
0925: restore_camera_to_user_defined 
Camera.SetPosition(-1474.91, 1564.625, 1052.952, 0.0, 0.0, 0.0)
Camera.PointAt(-1473.948, 1564.367, 1053.041, 2)
00BC: show_text_highpriority GXT 'KICK_11' time 10000 flag 1  
06A9: AS_actor " + PlayerActor + @" look_at_point -1464.32 1556.69 1051.75 6000 ms 
32@ = 0 

:KICKSTA_3155
if 
  7000 > 32@ 
else_jump @KICKSTA_3404 
wait 0 
if 
   Car.Wrecked(34@)
else_jump @KICKSTA_3382 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK1_7' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_3232
if 
fading 
else_jump @KICKSTA_3256 
wait 0 
jump @KICKSTA_3232 

:KICKSTA_3256
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_3300 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_3300
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_3343 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_3363 

:KICKSTA_3343
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_3363
wait 1500 
jump @KICKSTA_7448 
jump @KICKSTA_3390 

:KICKSTA_3382
Car.Health(34@) = 1000

:KICKSTA_3390
gosub @KICKSTA_7900 
jump @KICKSTA_3155 

:KICKSTA_3404
03D5: remove_text 'KICK_11'  

:KICKSTA_3415
0701: end_scene_skip 
if 
   Car.Wrecked(34@)
else_jump @KICKSTA_3621 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK1_7' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_3471
if 
fading 
else_jump @KICKSTA_3495 
wait 0 
jump @KICKSTA_3471 

:KICKSTA_3495
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_3539 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_3539
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_3582 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_3602 

:KICKSTA_3582
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_3602
wait 1500 
jump @KICKSTA_7448 
jump @KICKSTA_3629 

:KICKSTA_3621
Car.Health(34@) = 1000

:KICKSTA_3629
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
041E: set_radio_station 11 
01F7: set_player " + PlayerChar + @" ignored_by_cops 0 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
0925: restore_camera_to_user_defined 
0581: enable_radar 0 
00BC: show_text_highpriority GXT 'KICK1_8' time 5000 flag 1  

:KICKSTA_3688
if 
   not Actor.InCar(" + PlayerActor + @", 34@)
else_jump @KICKSTA_4392 
wait 0 
if 
   Car.Wrecked(34@)
else_jump @KICKSTA_3915 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK1_7' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_3765
if 
fading 
else_jump @KICKSTA_3789 
wait 0 
jump @KICKSTA_3765 

:KICKSTA_3789
select_interior 0 
Camera.SetAtPos(1105.21, 1604.649, 12.51)
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_3833 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_3833
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_3876 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_3896 

:KICKSTA_3876
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_3896
wait 1500 
jump @KICKSTA_7448 
jump @KICKSTA_3923 

:KICKSTA_3915
Car.Health(34@) = 1000

:KICKSTA_3923
if or
  " + _8256 + @" >= 3600000 
  " + _8260 + @" == 1 
else_jump @KICKSTA_4137 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK_13' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
wait 1500 
fade 0 1000 

:KICKSTA_3994
if 
fading 
else_jump @KICKSTA_4018 
wait 0 
jump @KICKSTA_3994 

:KICKSTA_4018
select_interior 0 
Camera.SetAtPos(1105.21, 1604.649, 12.51)
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_4062 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_4062
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_4105 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_4125 

:KICKSTA_4105
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_4125
wait 1500 
jump @KICKSTA_7448 

:KICKSTA_4137
if or
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere -1464.32 1556.69 1051.75 radius 3.0 3.0 3.0 on_foot 
  43@ == 1 
else_jump @KICKSTA_4378 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK_12' time 5000 flag 1  
03BD: destroy_sphere 44@ 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_4235
if 
fading 
else_jump @KICKSTA_4259 
wait 0 
jump @KICKSTA_4235 

:KICKSTA_4259
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_4303 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_4303
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_4346 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_4366 

:KICKSTA_4346
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_4366
wait 1500 
jump @KICKSTA_7448 

:KICKSTA_4378
gosub @KICKSTA_7900 
jump @KICKSTA_3688 

:KICKSTA_4392
02A3: enable_widescreen 1 
Player.CanMove(" + PlayerChar + @") = False
Camera.SetBehindPlayer
03D5: remove_text 'KICK1_8'  
257@ = 0 
32@ = 0 
33@ = 0 

:KICKSTA_4437
if 
   not 257@ == 10 
else_jump @KICKSTA_4886 
wait 0 
if 
  257@ == 0 
else_jump @KICKSTA_4581 
if 
  33@ > 900 
else_jump @KICKSTA_4581 
00BA: show_text_styled GXT 'KICK_17' time 1000 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
03CF: load_wav 1827 as 4 

:KICKSTA_4541
if 
83D0:   not wav 4 loaded 
else_jump @KICKSTA_4567 
wait 0 
jump @KICKSTA_4541 

:KICKSTA_4567
257@ += 1 
33@ = 0 

:KICKSTA_4581
if 
  257@ == 1 
else_jump @KICKSTA_4670 
if 
  33@ > 900 
else_jump @KICKSTA_4670 
00BA: show_text_styled GXT 'KICK_18' time 1000 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
257@ += 1 
33@ = 0 

:KICKSTA_4670
if 
  257@ == 2 
else_jump @KICKSTA_4759 
if 
  33@ > 900 
else_jump @KICKSTA_4759 
00BA: show_text_styled GXT 'KICK_19' time 1000 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
257@ += 1 
33@ = 0 

:KICKSTA_4759
if 
  257@ == 3 
else_jump @KICKSTA_4846 
if 
  33@ > 900 
else_jump @KICKSTA_4846 
00BA: show_text_styled GXT 'KICK_20' time 800 style 4  
097A: play_audio_at -1462.0 1558.69 1055.02 event 1164 
257@ = 10 
33@ = 0 

:KICKSTA_4846
if 
  32@ > 4000 
else_jump @KICKSTA_4872 
257@ = 10 

:KICKSTA_4872
gosub @KICKSTA_7900 
jump @KICKSTA_4437 

:KICKSTA_4886
02A3: enable_widescreen 0 
Marker.Disable(36@)
Player.CanMove(" + PlayerChar + @") = True
00BC: show_text_highpriority GXT 'KICK_26' time 5000 flag 1  
03C4: set_status_text " + _8262 + @" type 0 GXT 'KICK1_9' 
03C3: set_timer_to " + _8256 + @" type 1 GXT 'KICK1_T' 
32@ = 0 
33@ = 0 

:KICKSTA_4964
if 
   not " + _8250 + @" == 33 
else_jump @KICKSTA_6929 
wait 0 
gosub @KICKSTA_7900 
if 
  48@ == 1 
else_jump @KICKSTA_5033 
if 
03D0:   wav 1 loaded 
else_jump @KICKSTA_5033 
48@ = 2 

:KICKSTA_5033
if 
  48@ == 2 
else_jump @KICKSTA_5062 
03D1: play_wav 1 
48@ = 3 

:KICKSTA_5062
if 
  48@ == 3 
else_jump @KICKSTA_5106 
if 
03D2:   wav 1 ended 
else_jump @KICKSTA_5106 
040D: unload_wav 1 
48@ = 0 

:KICKSTA_5106
if or
  0 >= " + _8256 + @" 
  " + _8260 + @" == 1 
else_jump @KICKSTA_5673 
Player.CanMove(" + PlayerChar + @") = False
014F: stop_timer " + _8256 + @" 
0151: remove_status_text " + _8262 + @" 
if 
001C:   " + _8262 + @" > " + _1804 + @" 
else_jump @KICKSTA_5417 
0084: " + _1804 + @" = " + _8262 + @" 
01E3: show_text_1number_styled GXT 'KICK_22' number " + _1804 + @" time 5000 style 1  
00BC: show_text_highpriority GXT 'KICK_23' time 5000 flag 1  
0627: update_integer_stat 211 to " + _1804 + @" 
0394: play_music 2 
if 
  " + Mission_Kickstart_Passed + @" == 0 
else_jump @KICKSTA_5247" );
CAR_PARK.set_chance_to_generate( carPark_5275, 101 );
AppendLine( @"
:KICKSTA_5247
wait 5000 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_5267
if 
fading 
else_jump @KICKSTA_5291 
wait 0 
jump @KICKSTA_5267 

:KICKSTA_5291
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_5335 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_5335
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_5378 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_5398 

:KICKSTA_5378
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_5398
wait 1500 
jump @KICKSTA_7510 
jump @KICKSTA_5673 

:KICKSTA_5417
01E3: show_text_1number_styled GXT 'KICK1_9' number " + _8262 + @" time 5000 style 1  
01E3: show_text_1number_styled GXT 'KICK_21' number " + _1804 + @" time 5000 style 6  
00BC: show_text_highpriority GXT 'KICK_24' time 5000 flag 1  
0652: 248@ = integer_stat 211 
if 
001E:   " + _8262 + @" > 248@ 
else_jump @KICKSTA_5506 
0627: update_integer_stat 211 to " + _8262 + @" 

:KICKSTA_5506
0394: play_music 1 
wait 5000 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_5530
if 
fading 
else_jump @KICKSTA_5554 
wait 0 
jump @KICKSTA_5530 

:KICKSTA_5554
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_5598 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_5598
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_5641 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_5661 

:KICKSTA_5641
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_5661
wait 1500 
jump @KICKSTA_7448 

:KICKSTA_5673
if or
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere -1464.32 1556.69 1051.75 radius 3.0 3.0 3.0 on_foot 
  43@ == 1 
else_jump @KICKSTA_5914 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK_12' time 5000 flag 1  
03BD: destroy_sphere 44@ 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_5771
if 
fading 
else_jump @KICKSTA_5795 
wait 0 
jump @KICKSTA_5771 

:KICKSTA_5795
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_5839 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_5839
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_5882 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_5902 

:KICKSTA_5882
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_5902
wait 1500 
jump @KICKSTA_7448 

:KICKSTA_5914
Actor.StorePos(" + PlayerActor + @", 37@, 38@, 39@)
if 
  1050.0 > 39@ 
else_jump @KICKSTA_5979 
Actor.PutAt(" + PlayerActor + @", -1473.187, 1565.173, 1051.789)
Actor.Angle(" + PlayerActor + @") = 266.488

:KICKSTA_5979
if 
   Car.Wrecked(34@)
else_jump @KICKSTA_6183 
Player.CanMove(" + PlayerChar + @") = False
00BC: show_text_highpriority GXT 'KICK1_7' time 5000 flag 1  
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_6033
if 
fading 
else_jump @KICKSTA_6057 
wait 0 
jump @KICKSTA_6033 

:KICKSTA_6057
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_6101 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_6101
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_6144 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_6164 

:KICKSTA_6144
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_6164
wait 1500 
jump @KICKSTA_7448 
jump @KICKSTA_6922 

:KICKSTA_6183
Car.Health(34@) = 1000
Car.StorePos(34@, 40@, 41@, 42@)
if 
  1050.0 > 42@ 
else_jump @KICKSTA_6259 
34@ = Car.Create(#SANCHEZ, -1472.38, 1563.576, 1051.417)
Car.Angle(34@) = 266.488

:KICKSTA_6259
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #SANCHEZ)
else_jump @KICKSTA_6874 
if 
  254@ == 0 
else_jump @KICKSTA_6450 
if 
  35@ == 0 
else_jump @KICKSTA_6361 
36@ = Marker.CreateAboveCar(34@)
07E0: set_marker 36@ type_to 1 
if 
  47@ == 2 
else_jump @KICKSTA_6354 
47@ = 3 

:KICKSTA_6354
35@ = 1 

:KICKSTA_6361
01BD: " + _8253 + @" = current_time_in_ms 
" + _8254 + @" = 30000 
if 
  " + _8256 + @" >= 30000 
else_jump @KICKSTA_6408 
" + _8254 + @" = 30000 
jump @KICKSTA_6416 

:KICKSTA_6408
0084: " + _8254 + @" = " + _8256 + @" 

:KICKSTA_6416
254@ = 1 
040D: unload_wav 1 
03CF: load_wav 36200 as 1 
48@ = 1 
jump @KICKSTA_6867 

:KICKSTA_6450
if 
  " + _8254 + @" > 0 
else_jump @KICKSTA_6643 
01BD: " + _8251 + @" = current_time_in_ms 
0084: " + _8252 + @" = " + _8251 + @" 
0060: " + _8252 + @" -= " + _8253 + @" 
0084: " + _8253 + @" = " + _8251 + @" 
0060: " + _8254 + @" -= " + _8252 + @" 
0084: " + _8255 + @" = " + _8254 + @" 
" + _8255 + @" /= 1000 
09C1: add_next_text_to_brief_history 0 
if 
   not " + _8255 + @" == 1 
else_jump @KICKSTA_6569 
01E5: show_text_1number_highpriority GXT 'KICK_27' number " + _8255 + @" time 1000 flag 1  
jump @KICKSTA_6588 

:KICKSTA_6569
01E5: show_text_1number_highpriority GXT 'KICK_28' number " + _8255 + @" time 1000 flag 1  

:KICKSTA_6588
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #SANCHEZ)
else_jump @KICKSTA_6636 
03D5: remove_text 'GETBIKE' 
03D5: remove_text 'GETBIK2' 
" + _8254 + @" = 1 

:KICKSTA_6636
jump @KICKSTA_6867 

:KICKSTA_6643
if 
  0 >= " + _8254 + @" 
else_jump @KICKSTA_6867 
00BC: show_text_highpriority GXT 'KICK1_2' time 5000 flag 1  
Player.CanMove(" + PlayerChar + @") = False
040D: unload_wav 1 
03CF: load_wav 36200 as 1 
48@ = 1 
wait 1500 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_6724
if 
fading 
else_jump @KICKSTA_6748 
wait 0 
jump @KICKSTA_6724 

:KICKSTA_6748
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_6792 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_6792
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_6835 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_6855 

:KICKSTA_6835
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_6855
wait 1500 
jump @KICKSTA_7448 

:KICKSTA_6867
jump @KICKSTA_6922 

:KICKSTA_6874
03D5: remove_text 'KICK_27'  
if 
  35@ == 1 
else_jump @KICKSTA_6915 
Marker.Disable(36@)
35@ = 0 

:KICKSTA_6915
254@ = 0 

:KICKSTA_6922
jump @KICKSTA_4964 

:KICKSTA_6929
014F: stop_timer " + _8256 + @" 
0151: remove_status_text " + _8262 + @" 
if 
001C:   " + _8262 + @" > " + _1804 + @" 
else_jump @KICKSTA_7208 
0084: " + _1804 + @" = " + _8262 + @" 
01E3: show_text_1number_styled GXT 'KICK_22' number " + _1804 + @" time 5000 style 1  
00BC: show_text_highpriority GXT 'KICK_23' time 5000 flag 1  
0627: update_integer_stat 211 to " + _1804 + @" 
if 
  " + Mission_Kickstart_Passed + @" == 0 
else_jump @KICKSTA_7034" );
CAR_PARK.set_chance_to_generate( carPark_5275, 101 );
AppendLine( @"
:KICKSTA_7034
0394: play_music 2 
wait 5000 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_7058
if 
fading 
else_jump @KICKSTA_7082 
wait 0 
jump @KICKSTA_7058 

:KICKSTA_7082
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_7126 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_7126
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_7169 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_7189 

:KICKSTA_7169
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_7189
wait 1500 
jump @KICKSTA_7510 
jump @KICKSTA_7448 

:KICKSTA_7208
0394: play_music 1 
0652: 248@ = integer_stat 211 
if 
001E:   " + _8262 + @" > 248@ 
else_jump @KICKSTA_7247 
0627: update_integer_stat 211 to " + _8262 + @" 

:KICKSTA_7247
01E3: show_text_1number_styled GXT 'KICK1_9' number " + _8262 + @" time 5000 style 1  
01E3: show_text_1number_styled GXT 'KICK_21' number " + _1804 + @" time 5000 style 6  
wait 5000 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:KICKSTA_7305
if 
fading 
else_jump @KICKSTA_7329 
wait 0 
jump @KICKSTA_7305 

:KICKSTA_7329
Camera.SetAtPos(1105.21, 1604.649, 12.51)
select_interior 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_7373 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_7373
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @KICKSTA_7416 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1105.21 1604.649 12.0546 
jump @KICKSTA_7436 

:KICKSTA_7416
Actor.PutAt(" + PlayerActor + @", 1105.21, 1604.649, 12.0546)

:KICKSTA_7436
wait 1500 
jump @KICKSTA_7448 

:KICKSTA_7448
01E3: show_text_1number_styled GXT 'KICK1_9' number 15 time " + _8262 + @" style 1  
01E5: show_text_1number_highpriority GXT 'KICK_21' number " + _1804 + @" time 5000 flag 1  
008B: 258@ = " + _8262 + @" 
258@ *= 100 
Player.Money(" + PlayerChar + @") += 258@
return 

:KICKSTA_7510
if 
  " + Mission_Kickstart_Passed + @" == 0 
else_jump @KICKSTA_7537 
0595: mission_complete 
" + Mission_Kickstart_Passed + @" = 1 

:KICKSTA_7537
Player.ClearWantedLevel(" + PlayerChar + @")
01E3: show_text_1number_styled GXT 'KICK_22' number " + _1804 + @" time 5000 style 1  
008B: 258@ = " + _8262 + @" 
258@ *= 100 
Player.Money(" + PlayerChar + @") += 258@
return 

:KICKSTA_7586
0581: enable_radar 1 
04FA: reset_sky_colors_with_fade 0 
" + OnMission + @" = 0 
00BE: text_clear_all 
04FA: reset_sky_colors_with_fade 0 
03BD: destroy_sphere 44@ 
0925: restore_camera_to_user_defined 
Marker.Disable(149@)
Marker.Disable(150@)
Marker.Disable(151@)
Marker.Disable(152@)
Marker.Disable(153@)
Marker.Disable(154@)
Marker.Disable(155@)
Marker.Disable(156@)
Marker.Disable(157@)
Marker.Disable(158@)
Marker.Disable(159@)
Marker.Disable(160@)
Marker.Disable(161@)
Marker.Disable(162@)
Marker.Disable(163@)
Marker.Disable(164@)
Marker.Disable(165@)
Marker.Disable(166@)
Marker.Disable(167@)
Marker.Disable(168@)
Marker.Disable(169@)
Marker.Disable(170@)
Marker.Disable(171@)
Marker.Disable(172@)
Marker.Disable(173@)
Marker.Disable(174@)
Marker.Disable(175@)
Marker.Disable(176@)
Marker.Disable(177@)
Marker.Disable(178@)
Marker.Disable(179@)
Marker.Disable(180@)
Marker.Disable(181@)
Marker.Disable(36@)
Model.Destroy(#SANCHEZ)
014F: stop_timer " + _8256 + @" 
0151: remove_status_text " + _8262 + @" 
if or
   not wasted_or_busted 
  " + _176 + @" == 1 
else_jump @KICKSTA_7855 
Actor.Angle(" + PlayerActor + @") = 1.0
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
0169: set_fade_color_RGB 0 0 0 
fade 1 3000 
Player.CanMove(" + PlayerChar + @") = True

:KICKSTA_7855
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKSTA_7878 
0860: link_actor " + PlayerActor + @" to_interior 0 

:KICKSTA_7878
0581: enable_radar 1 
Car.RemoveReferences(34@)
057E: set_radar_grey 0 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
mission_cleanup 
return 

:KICKSTA_7900
253@ = 0 

:KICKSTA_7907
if 
  33 > 253@ 
else_jump @KICKSTA_8435 
if 
  182@(253@,33i) == 0 
else_jump @KICKSTA_8421 
if 
  215@(253@,33i) == 0 
else_jump @KICKSTA_7991 
250@ = 0 
251@ = 255 
252@ = 0 

:KICKSTA_7991
if 
  215@(253@,33i) == 1 
else_jump @KICKSTA_8036 
250@ = 255 
251@ = 150 
252@ = 0 

:KICKSTA_8036
if 
  215@(253@,33i) == 2 
else_jump @KICKSTA_8080 
250@ = 255 
251@ = 0 
252@ = 0 

:KICKSTA_8080
024F: create_corona_with_radius 249@ type 0 lensflares 0 with_color 250@ 251@ 252@ at 50@(253@,33f) 83@(253@,33f) 116@(253@,33f) 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 50@(253@,33f) 83@(253@,33f) 116@(253@,33f) radius 1.5 1.5 1.5 
else_jump @KICKSTA_8421 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #SANCHEZ)
else_jump @KICKSTA_8421 
if 
  215@(253@,33i) == 0 
else_jump @KICKSTA_8257 
" + _8262 + @" += 1 
00BC: show_text_highpriority GXT 'KICK_14' time 1000 flag 1  
040D: unload_wav 1 
03CF: load_wav 36202 as 1 
48@ = 1 

:KICKSTA_8257
if 
  215@(253@,33i) == 1 
else_jump @KICKSTA_8322 
" + _8262 + @" += 2 
00BC: show_text_highpriority GXT 'KICK_15' time 1000 flag 1  
040D: unload_wav 1 
03CF: load_wav 36202 as 1 
48@ = 1 

:KICKSTA_8322
if 
  215@(253@,33i) == 2 
else_jump @KICKSTA_8387 
" + _8262 + @" += 3 
00BC: show_text_highpriority GXT 'KICK_16' time 1000 flag 1  
040D: unload_wav 1 
03CF: load_wav 36205 as 1 
48@ = 1 

:KICKSTA_8387
Marker.Disable(149@(253@,33i))
" + _8250 + @" += 1 
" + _8261 + @" -= 1 
182@(253@,33i) = 1 

:KICKSTA_8421
253@ += 1 
jump @KICKSTA_7907 

:KICKSTA_8435
return" );
            }

        }

    }

}