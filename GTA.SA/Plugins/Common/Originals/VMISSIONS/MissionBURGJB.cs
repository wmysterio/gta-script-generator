using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class BURGJB : MissionCustom {

            Int tmp_Burglary_Garages = global( Burglary_Garages.startIndex );

            Int _local111 = local( 111 );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @BURGJB_65 
if 
wasted_or_busted 
else_jump @BURGJB_38 
gosub @BURGJB_8332 

:BURGJB_38
gosub @BURGJB_8444 
end_thread 
if 
  " + Mission_Burglary_Passed + @" == 0 
else_jump @BURGJB_65 

:BURGJB_65
" + OnMission + @" = 1 
increment_mission_attempts 
wait 0 
0169: set_fade_color_RGB 0 0 0 
054C: use_GXT_table 'BURGLAR' 
09E6: set_burglary_houses_accessible 1 
92@ = 0 
93@ = 0 
94@ = 0 
95@ = 0 
96@ = 0 
97@ = 0 
101@ = 0 
98@ = 0 
99@ = 0 
100@ = 0 
103@ = 0 
102@ = 0 
107@ = 0 
108@ = 0 
109@ = 0 
110@ = 0 
112@ = 0 
47@ = 0 
" + BUGRLARY_Cash + @" = 0 
90@ = 0 
89@ = 0 
106@ = 0 
" + BURGLARY_Escape_Time_Sec + @" = 10 
" + BURGLARY_Time_left + @" = 300000 
91@ = 0 
105@ = 0 
41@ = 0.0 
" + BURGLARY_Noise_f + @" = 0.0 
42@ = 9999999.0 
43@ = 9999999.0 
54@ = 2741.0 
57@ = -2006.807 
60@ = 14.0 
05A9: s" + tmp_Burglary_Garages + @"[0] = 'BURG_LK' 
76@ = 2741.241 
79@ = -2011.274 
82@ = 13.5869 
55@ = -2102.54 
58@ = -15.5931 
61@ = 34.3203 
05A9: s" + tmp_Burglary_Garages + @"[1] = 'BRGSFSE' 
77@ = -2109.32 
80@ = -15.7967 
83@ = 34.3203 
56@ = 2609.248 
59@ = 1439.347 
62@ = 9.8203 
05A9: s" + tmp_Burglary_Garages + @"[2] = 'VGELOCK' 
78@ = 2609.012 
81@ = 1445.936 
84@ = 9.8203 
34@ = 0 
48@ = 0 
" + BURGLARY_Detected_Flag + @" = 0 
111@ = 0 
" + BURGLARY_Noise_i + @" = 0 
" + CARMOD_Disabled_Flag + @" = 1 
38@ = Player.Money(" + PlayerChar + @")
39@ = Player.Money(" + PlayerChar + @")
if 
  48@ == 99 
else_jump @BURGJB_687 
49@ = Object.Create(#BRIEFCASE, 0.0, 0.0, 0.0)
018A: 51@ = create_checkpoint_at 0.0 0.0 0.0 
018A: 53@ = create_checkpoint_at 0.0 0.0 0.0 

:BURGJB_687
if 
8500:   not player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_820 
0A2D: hide_styled_text_while_fading 0 
fade 0 1000 

:BURGJB_727
if 
fading 
else_jump @BURGJB_751 
wait 0 
jump @BURGJB_727 

:BURGJB_751
Player.SetClothes(" + PlayerChar + @", ""BALACLAVA"", ""BALACLAVA"", Special)
Player.Build(" + PlayerChar + @")
fade 1 1000 

:BURGJB_792
if 
fading 
else_jump @BURGJB_816 
wait 0 
jump @BURGJB_792 

:BURGJB_816
0A2D: hide_styled_text_while_fading 1 

:BURGJB_820
00BF: " + Time_Hours + @" = current_time_hours, " + Time_Mins + @" = current_time_minutes 
if 
  " + Time_Hours + @" >= 20 
else_jump @BURGJB_909 
008B: 88@ = " + Time_Hours + @" 
88@ *= 60 
005C: 88@ += " + Time_Mins + @" 
36@ = 1440 
0062: 36@ -= 88@ 
36@ += 360 
36@ *= 1000 
008A: " + BURGLARY_Daylight + @" = 36@ 

:BURGJB_909
if 
  6 > " + Time_Hours + @" 
else_jump @BURGJB_982 
008B: 88@ = " + Time_Hours + @" 
88@ *= 60 
005C: 88@ += " + Time_Mins + @" 
36@ = 360 
0062: 36@ -= 88@ 
36@ *= 1000 
008A: " + BURGLARY_Daylight + @" = 36@ 

:BURGJB_982
03C3: set_timer_to " + BURGLARY_Daylight + @" type 1 GXT 'BURG52' 
04F7: status_text " + BUGRLARY_Cash + @" type 0 line 1 GXT 'BURG51' 
wait 0 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @BURGJB_1044 
50@ = Actor.MissionCar(" + PlayerActor + @")

:BURGJB_1044
wait 0 
if 
0735:   is_keyboard_key_pressed 32 
else_jump @BURGJB_1073 
" + BURGLARY_Daylight + @" = 10000000 

:BURGJB_1073
if 
0735:   is_keyboard_key_pressed 49 
else_jump @BURGJB_1118 
Actor.PutAt(" + PlayerActor + @", 2741.928, -1993.231, 12.3669)
Actor.Angle(" + PlayerActor + @") = 173.5173

:BURGJB_1118
if 
0735:   is_keyboard_key_pressed 50 
else_jump @BURGJB_1153 
Actor.PutAt(" + PlayerActor + @", 2639.0, 2039.911, 9.8052)

:BURGJB_1153
if 
0735:   is_keyboard_key_pressed 99 
else_jump @BURGJB_1176 
" + BURGLARY_Daylight + @" = 5000 

:BURGJB_1176
if 
0735:   is_keyboard_key_pressed 48 
else_jump @BURGJB_1199 
" + BURGLARY_Time_left + @" = 5000 

:BURGJB_1199
if 
0735:   is_keyboard_key_pressed 53 
else_jump @BURGJB_1222 
" + _1790 + @" = 11000 

:BURGJB_1222
if 
0735:   is_keyboard_key_pressed 54 
else_jump @BURGJB_1244 
48@ = 3 

:BURGJB_1244
if 
  110@ == 0 
else_jump @BURGJB_2153 
if 
  " + BURGLARY_Daylight + @" == 0 
else_jump @BURGJB_1970 
00BE: text_clear_all 
09E6: set_burglary_houses_accessible 0 
if 
  92@ == 1 
else_jump @BURGJB_1570 
Player.CanMove(" + PlayerChar + @") = False
fade 0 1000 

:BURGJB_1318
if 
fading 
else_jump @BURGJB_1342 
wait 0 
jump @BURGJB_1318 

:BURGJB_1342
03E6: remove_text_box 
select_interior 0 
04E4: refresh_game_renderer_at 69@ 70@ 
Camera.SetAtPos(69@, 70@, 71@)
0972: put_actor " + PlayerActor + @" at 69@ 70@ 71@ no_offset 
0489: set_actor " + PlayerActor + @" muted 0 
72@ += 180.0 
Actor.Angle(" + PlayerActor + @") = 72@
08AD: link_actor " + PlayerActor + @" to_enex_marker_at 73@ 74@ radius 5.0 
Camera.SetAtPos(69@, 70@, 71@)
if 
  48@ == 0 
else_jump @BURGJB_1496 
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_1496 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")

:BURGJB_1496
92@ = 0 
93@ = 0 
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @BURGJB_1525 
Camera.Restore_WithJumpCut

:BURGJB_1525
fade 1 1000 

:BURGJB_1532
if 
fading 
else_jump @BURGJB_1556 
wait 0 
jump @BURGJB_1532 

:BURGJB_1556
Player.CanMove(" + PlayerChar + @") = True
jump @BURGJB_1733 

:BURGJB_1570
if 
  48@ == 0 
else_jump @BURGJB_1733 
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_1733 
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @BURGJB_1640 
Player.CanMove(" + PlayerChar + @") = False

:BURGJB_1640
fade 0 1000 

:BURGJB_1647
if 
fading 
else_jump @BURGJB_1671 
wait 0 
jump @BURGJB_1647 

:BURGJB_1671
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @BURGJB_1702 
Camera.Restore_WithJumpCut

:BURGJB_1702
fade 1 1000 

:BURGJB_1709
if 
fading 
else_jump @BURGJB_1733 
wait 0 
jump @BURGJB_1709 

:BURGJB_1733
014F: stop_timer " + BURGLARY_Daylight + @" 
if 
  48@ > 0 
else_jump @BURGJB_1916 
03C3: set_timer_to " + BURGLARY_Time_left + @" type 1 GXT 'BURG3' 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG2' time 5000 flag 1  
if 
  93@ == 1 
else_jump @BURGJB_1838 
00BB: show_text_lowpriority GXT 'BURG26' time 5000 flag 1  
102@ = 2 
jump @BURGJB_1909 

:BURGJB_1838
if 
  94@ == 1 
else_jump @BURGJB_1886 
00BB: show_text_lowpriority GXT 'BURG27' time 5000 flag 1  
102@ = 1 
jump @BURGJB_1909 

:BURGJB_1886
00BB: show_text_lowpriority GXT 'BURG1' time 5000 flag 1  
102@ = 3 

:BURGJB_1909
jump @BURGJB_1956 

:BURGJB_1916
" + BURGLARY_Time_left + @" = 0 
Object.Destroy(49@)
Object.RemoveReferences(49@)
00BB: show_text_lowpriority GXT 'BURG53' time 5000 flag 1  
jump @BURGJB_8332 

:BURGJB_1956
110@ = 1 
jump @BURGJB_2146 

:BURGJB_1970
00BF: " + Time_Hours + @" = current_time_hours, " + Time_Mins + @" = current_time_minutes 
if 
  " + Time_Hours + @" >= 20 
else_jump @BURGJB_2066 
008B: 88@ = " + Time_Hours + @" 
88@ *= 60 
005C: 88@ += " + Time_Mins + @" 
36@ = 1440 
0062: 36@ -= 88@ 
36@ += 360 
36@ += 1 
36@ *= 1000 
008A: " + BURGLARY_Daylight + @" = 36@ 

:BURGJB_2066
if 
  6 > " + Time_Hours + @" 
else_jump @BURGJB_2146 
008B: 88@ = " + Time_Hours + @" 
88@ *= 60 
005C: 88@ += " + Time_Mins + @" 
36@ = 360 
0062: 36@ -= 88@ 
36@ += 1 
36@ *= 1000 
008A: " + BURGLARY_Daylight + @" = 36@ 

:BURGJB_2146
jump @BURGJB_2351 

:BURGJB_2153
if 
  " + BURGLARY_Time_left + @" == 0 
else_jump @BURGJB_2351 
00BE: text_clear_all 
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @BURGJB_2196 
Player.CanMove(" + PlayerChar + @") = False

:BURGJB_2196
fade 0 1000 

:BURGJB_2203
if 
fading 
else_jump @BURGJB_2227 
wait 0 
jump @BURGJB_2203 

:BURGJB_2227
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_2272 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")

:BURGJB_2272
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @BURGJB_2287 
Camera.Restore_WithJumpCut

:BURGJB_2287
fade 1 1000 

:BURGJB_2294
if 
fading 
else_jump @BURGJB_2318 
wait 0 
jump @BURGJB_2294 

:BURGJB_2318
00BB: show_text_lowpriority GXT 'BURG53' time 5000 flag 1  
Object.Destroy(49@)
Object.RemoveReferences(49@)
jump @BURGJB_8332 

:BURGJB_2351
if 
  95@ == 0 
else_jump @BURGJB_7832 
gosub @BURGJB_7953 
077E: get_active_interior_to 37@ 
if 
  37@ == 0 
else_jump @BURGJB_2451 
if 
8500:   not player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_2451 
00BB: show_text_lowpriority GXT 'BURG62' time 5000 flag 1  
jump @BURGJB_8332 

:BURGJB_2451
if 
  93@ == 1 
else_jump @BURGJB_2694 
if and
   Player.WantedLevel(" + PlayerChar + @") > 0
  48@ > 0 
else_jump @BURGJB_2544 
if 
   not 102@ == 5 
else_jump @BURGJB_2537 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG50' time 5000 flag 1  
102@ = 5 

:BURGJB_2537
jump @BURGJB_2687 

:BURGJB_2544
if 
   not 102@ == 2 
else_jump @BURGJB_2687 
00BE: text_clear_all 
if 
  48@ > 0 
else_jump @BURGJB_2646 
if 
  110@ == 0 
else_jump @BURGJB_2623 
00BB: show_text_lowpriority GXT 'BURG4' time 5000 flag 1  
jump @BURGJB_2639 

:BURGJB_2623
00BB: show_text_lowpriority GXT 'BURG26' time 5000 flag 1  

:BURGJB_2639
jump @BURGJB_2680 

:BURGJB_2646
if 
  110@ == 0 
else_jump @BURGJB_2680 
00BB: show_text_lowpriority GXT 'BURG29' time 5000 flag 1  

:BURGJB_2680
102@ = 2 

:BURGJB_2687
jump @BURGJB_3084 

:BURGJB_2694
if 
  110@ == 0 
else_jump @BURGJB_2957 
if 
  94@ == 1 
else_jump @BURGJB_2798 
if 
   not 102@ == 1 
else_jump @BURGJB_2791 
if 
  92@ == 0 
else_jump @BURGJB_2791 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG27' time 5000 flag 1  
102@ = 1 

:BURGJB_2791
jump @BURGJB_2950 

:BURGJB_2798
if 
  92@ == 1 
else_jump @BURGJB_2866 
if 
   not 102@ == 4 
else_jump @BURGJB_2859 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG30' time 5000 flag 1  
102@ = 4 

:BURGJB_2859
jump @BURGJB_2950 

:BURGJB_2866
if 
   not 102@ == 3 
else_jump @BURGJB_2950 
00BE: text_clear_all 
if 
  48@ == 0 
else_jump @BURGJB_2927 
00BB: show_text_lowpriority GXT 'BURG29' time 5000 flag 1  
jump @BURGJB_2943 

:BURGJB_2927
00BB: show_text_lowpriority GXT 'BURG31' time 5000 flag 1  

:BURGJB_2943
102@ = 3 

:BURGJB_2950
jump @BURGJB_3084 

:BURGJB_2957
if 
  94@ == 1 
else_jump @BURGJB_3043 
if 
   not 102@ == 1 
else_jump @BURGJB_3036 
if 
  92@ == 0 
else_jump @BURGJB_3036 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG27' time 5000 flag 1  
102@ = 1 

:BURGJB_3036
jump @BURGJB_3084 

:BURGJB_3043
if 
   not 102@ == 3 
else_jump @BURGJB_3084 
00BB: show_text_lowpriority GXT 'BURG1' time 5000 flag 1  
102@ = 3 

:BURGJB_3084
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_7681 
if 
  92@ == 0 
else_jump @BURGJB_3396 
if 
   not Actor.InCar(" + PlayerActor + @", 50@)
else_jump @BURGJB_3228 
93@ = 0 
if 
  99@ == 1 
else_jump @BURGJB_3174 
Marker.Disable(51@)
99@ = 0 

:BURGJB_3174
if 
  97@ == 0 
else_jump @BURGJB_3221 
52@ = Marker.CreateAboveCar(50@)
018B: set_marker 52@ radar_mode 2 
07E0: set_marker 52@ type_to 1 
97@ = 1 

:BURGJB_3221
jump @BURGJB_3396 

:BURGJB_3228
93@ = 1 
if 
  97@ == 1 
else_jump @BURGJB_3272 
108@ = 0 
Marker.Disable(52@)
97@ = 0 

:BURGJB_3272
if 
  48@ > 0 
else_jump @BURGJB_3396 
if 
   Player.WantedLevel(" + PlayerChar + @") > 0
else_jump @BURGJB_3345 
if 
  99@ == 1 
else_jump @BURGJB_3338 
Marker.Disable(51@)
99@ = 0 

:BURGJB_3338
jump @BURGJB_3396 

:BURGJB_3345
if 
  99@ == 0 
else_jump @BURGJB_3396 
018A: 51@ = create_checkpoint_at 54@(35@,3f) 57@(35@,3f) 60@(35@,3f) 
99@ = 1 

:BURGJB_3396
if 
  108@ == 0 
else_jump @BURGJB_3848 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  " + STAT_Unlocked_Cities_Number + @" == 0 
else_jump @BURGJB_3454 
35@ = 0 
jump @BURGJB_3830 

:BURGJB_3454
if 
  " + STAT_Unlocked_Cities_Number + @" == 1 
else_jump @BURGJB_3626 
Actor.StorePos(" + PlayerActor + @", 63@, 64@, 65@)
07EF: get_town_number_from_point 63@ 64@ 65@ store_to 35@ 
if 
  35@ > 0 
else_jump @BURGJB_3532 
35@ -= 1 
jump @BURGJB_3619 

:BURGJB_3532
050A: 42@ = distance_between_XYZ 63@ 64@ 65@ and_XYZ 54@ 57@ 60@ 
35@ = 0 
0087: 43@ = 42@ 
050A: 42@ = distance_between_XYZ 63@ 64@ 65@ and_XYZ 55@ 58@ 61@ 
if 
0025:   43@ > 42@ 
else_jump @BURGJB_3619 
35@ = 1 

:BURGJB_3619
jump @BURGJB_3830 

:BURGJB_3626
Actor.StorePos(" + PlayerActor + @", 63@, 64@, 65@)
07EF: get_town_number_from_point 63@ 64@ 65@ store_to 35@ 
if 
  35@ > 0 
else_jump @BURGJB_3686 
35@ -= 1 
jump @BURGJB_3830 

:BURGJB_3686
050A: 42@ = distance_between_XYZ 63@ 64@ 65@ and_XYZ 54@ 57@ 60@ 
35@ = 0 
0087: 43@ = 42@ 
050A: 42@ = distance_between_XYZ 63@ 64@ 65@ and_XYZ 55@ 58@ 61@ 
if 
0025:   43@ > 42@ 
else_jump @BURGJB_3781 
35@ = 1 
0087: 43@ = 42@ 

:BURGJB_3781
050A: 42@ = distance_between_XYZ 63@ 64@ 65@ and_XYZ 56@ 59@ 62@ 
if 
0025:   43@ > 42@ 
else_jump @BURGJB_3830 
35@ = 2 

:BURGJB_3830
Garage.ChangeType(" + tmp_Burglary_Garages + @"(35@,3s), 19)
108@ = 1 

:BURGJB_3848
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_5295 
if or
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 54@(35@,3f) 57@(35@,3f) 60@(35@,3f) radius 20.0 20.0 4.0 
01AF:   car 50@ sphere 0 in_sphere 54@(35@,3f) 57@(35@,3f) 60@(35@,3f) radius 20.0 20.0 4.0 
else_jump @BURGJB_5266 
if 
   not Garage.IsOpen(" + tmp_Burglary_Garages + @"(35@,3s))
else_jump @BURGJB_3990 
Garage.Open(" + tmp_Burglary_Garages + @"(35@,3s))

:BURGJB_3990
if 
  108@ == 1 
else_jump @BURGJB_5259 
if 
  93@ == 1 
else_jump @BURGJB_5259 
if 
  48@ > 0 
else_jump @BURGJB_5259 
if 
   Player.WantedLevel(" + PlayerChar + @") > 0
else_jump @BURGJB_4117 
if 
  99@ == 1 
else_jump @BURGJB_4110 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG50' time 5000 flag 1  
Marker.Disable(51@)
99@ = 0 

:BURGJB_4110
jump @BURGJB_5259 

:BURGJB_4117
if 
  99@ == 0 
else_jump @BURGJB_4193 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG26' time 5000 flag 1  
018A: 51@ = create_checkpoint_at 54@(35@,3f) 57@(35@,3f) 60@(35@,3f) 
99@ = 1 
jump @BURGJB_5259 

:BURGJB_4193
00BB: show_text_lowpriority GXT 'BURG40' time 1000 flag 1  
if 
0100:   actor " + PlayerActor + @" in_sphere 76@(35@,3f) 79@(35@,3f) 82@(35@,3f) radius 2.9 3.2 5.0 sphere 1 in_car 
else_jump @BURGJB_5259 
Player.CanMove(" + PlayerChar + @") = False
01F7: set_player " + PlayerChar + @" ignored_by_cops 1 
00BE: text_clear_all 
0395: clear_area 1 at 76@(35@,3f) 79@(35@,3f) 82@(35@,3f) radius 10.0 
if 
  110@ == 1 
else_jump @BURGJB_4342 
014F: stop_timer " + BURGLARY_Time_left + @" 
" + BURGLARY_Time_left + @" = 999999 

:BURGJB_4342
if 
   not Garage.IsClosed(" + tmp_Burglary_Garages + @"(35@,3s))
else_jump @BURGJB_4371 
Garage.Close(" + tmp_Burglary_Garages + @"(35@,3s))

:BURGJB_4371
104@ = 0 

:BURGJB_4378
if 
  104@ == 0 
else_jump @BURGJB_4434 
wait 0 
if 
   Garage.IsClosed(" + tmp_Burglary_Garages + @"(35@,3s))
else_jump @BURGJB_4427 
104@ = 1 

:BURGJB_4427
jump @BURGJB_4378 

:BURGJB_4434
Marker.Disable(51@)
0085: 34@ = 48@ 
34@ *= 20 
006A: 34@ *= 48@ 
005E: " + _1791 + @" += 48@ 
005E: " + _1790 + @" += 34@ 
008F: 45@ = integer " + _1790 + @" to_float 
0093: 46@ = integer 34@ to_float 
005A: 47@ += 48@ 
005E: " + BUGRLARY_Cash + @" += 34@ 
0628: update_float_stat_to 46@ stat_id 40 
0624: add 46@ to_float_stat 41 
0623: add 48@ to_integer_stat 194 
if 
  110@ == 1 
else_jump @BURGJB_4700 
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @BURGJB_4573 
Player.CanMove(" + PlayerChar + @") = False

:BURGJB_4573
fade 0 1000 

:BURGJB_4580
if 
fading 
else_jump @BURGJB_4604 
wait 0 
jump @BURGJB_4580 

:BURGJB_4604
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_4649 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")

:BURGJB_4649
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @BURGJB_4662 

:BURGJB_4662
fade 1 1000 

:BURGJB_4669
if 
fading 
else_jump @BURGJB_4693 
wait 0 
jump @BURGJB_4669 

:BURGJB_4693
jump @BURGJB_4869 

:BURGJB_4700
if and
  " + _1790 + @" >= 10000
  " + Mission_Burglary_Passed + @" == 0 
else_jump @BURGJB_4869 
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @BURGJB_4749 
Player.CanMove(" + PlayerChar + @") = False

:BURGJB_4749
fade 0 1000 

:BURGJB_4756
if 
fading 
else_jump @BURGJB_4780 
wait 0 
jump @BURGJB_4756 

:BURGJB_4780
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_4825 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")

:BURGJB_4825
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @BURGJB_4838 

:BURGJB_4838
fade 1 1000 

:BURGJB_4845
if 
fading 
else_jump @BURGJB_4869 
wait 0 
jump @BURGJB_4845 

:BURGJB_4869
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
if 
  2 > 48@ 
else_jump @BURGJB_4936 
036D: show_text_2numbers_styled GXT 'BURG39' numbers 48@ 34@ time 5000 style 6  
jump @BURGJB_4958 

:BURGJB_4936
036D: show_text_2numbers_styled GXT 'BURG36' numbers 48@ 34@ time 5000 style 6  

:BURGJB_4958
Player.Money(" + PlayerChar + @") += 34@
32@ = 0 

:BURGJB_4973
if or
076F:   text_priority_displayed 
  4000 > 32@ 
else_jump @BURGJB_5005 
wait 0 
jump @BURGJB_4973 

:BURGJB_5005
if 
   not Garage.IsOpen(" + tmp_Burglary_Garages + @"(35@,3s))
else_jump @BURGJB_5034 
Garage.Open(" + tmp_Burglary_Garages + @"(35@,3s))

:BURGJB_5034
104@ = 0 

:BURGJB_5041
if 
  104@ == 0 
else_jump @BURGJB_5097 
wait 0 
if 
   Garage.IsOpen(" + tmp_Burglary_Garages + @"(35@,3s))
else_jump @BURGJB_5090 
104@ = 1 

:BURGJB_5090
jump @BURGJB_5041 

:BURGJB_5097
if and
  " + _1790 + @" >= 10000
  " + Mission_Burglary_Passed + @" == 0 
else_jump @BURGJB_5151 
Player.CanMove(" + PlayerChar + @") = True
01F7: set_player " + PlayerChar + @" ignored_by_cops 0 
jump @BURGJB_8372 
jump @BURGJB_5213 

:BURGJB_5151
if 
  110@ == 0 
else_jump @BURGJB_5185 
00BB: show_text_lowpriority GXT 'BURG29' time 5000 flag 1  

:BURGJB_5185
99@ = 0 
34@ = 0 
48@ = 0 
105@ = 0 

:BURGJB_5213
Player.CanMove(" + PlayerChar + @") = True
01F7: set_player " + PlayerChar + @" ignored_by_cops 0 
if 
  110@ == 1 
else_jump @BURGJB_5259 
jump @BURGJB_8332 
" + BURGLARY_Time_left + @" = 0 

:BURGJB_5259
jump @BURGJB_5295 

:BURGJB_5266
if 
   not Garage.IsClosed(" + tmp_Burglary_Garages + @"(35@,3s))
else_jump @BURGJB_5295 
Garage.Close(" + tmp_Burglary_Garages + @"(35@,3s))

:BURGJB_5295
if 
  93@ == 0 
else_jump @BURGJB_5730 
if 
0867:   unknown_in_burglary_interior 0 
else_jump @BURGJB_5470 
if 
  107@ == 0 
else_jump @BURGJB_5456 
094C: get_actor " + PlayerActor + @" currently_used_EnEx_3D_coord_to 69@ 70@ 71@ number_to 72@ 
Actor.StorePos(" + PlayerActor + @", 73@, 74@, 75@)
if 
03CA:   object 49@ exists 
else_jump @BURGJB_5425 
if 
0737:   actor " + PlayerActor + @" lifting_object 49@ 
else_jump @BURGJB_5425 
077E: get_active_interior_to 37@ 
0566: link_object 49@ to_interior 37@ 

:BURGJB_5425
Marker.Disable(52@)
0489: set_actor " + PlayerActor + @" muted 1 
075B: zoom_radar 90 
39@ = Player.Money(" + PlayerChar + @")
107@ = 1 

:BURGJB_5456
92@ = 1 
jump @BURGJB_5730 

:BURGJB_5470
if 
  107@ == 1 
else_jump @BURGJB_5723 
0489: set_actor " + PlayerActor + @" muted 0 
if 
03CA:   object 49@ exists 
else_jump @BURGJB_5543 
if 
0737:   actor " + PlayerActor + @" lifting_object 49@ 
else_jump @BURGJB_5543 
077E: get_active_interior_to 37@ 
0566: link_object 49@ to_interior 37@ 

:BURGJB_5543
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_5574 
52@ = Marker.CreateAboveCar(50@)
07E0: set_marker 52@ type_to 1 

:BURGJB_5574
075B: zoom_radar 0 
107@ = 0 
if 
  94@ == 1 
else_jump @BURGJB_5723 
112@ = 1 
if 
0045:   85@ == 69@ 
else_jump @BURGJB_5674 
if 
0045:   86@ == 70@ 
else_jump @BURGJB_5674 
if 
0045:   87@ == 71@ 
else_jump @BURGJB_5674 
112@ = 0 

:BURGJB_5674
if 
  112@ == 1 
else_jump @BURGJB_5723 
0087: 85@ = 69@ 
0087: 86@ = 70@ 
0087: 87@ = 71@ 
0623: add 1 to_integer_stat 191 

:BURGJB_5723
92@ = 0 

:BURGJB_5730
if 
  93@ == 0 
else_jump @BURGJB_6506 
if 
  92@ == 0 
else_jump @BURGJB_6506 
if 
  94@ == 0 
else_jump @BURGJB_6008 
Actor.StorePos(" + PlayerActor + @", 63@, 64@, 65@)
0866: get_object_in_sphere 63@ 64@ 65@ radius 5.0 handle_as 49@ 
if 
   not 49@ == -1 
else_jump @BURGJB_6001 
if 
0737:   actor " + PlayerActor + @" lifting_object 49@ 
else_jump @BURGJB_5895 
if 
  100@ == 1 
else_jump @BURGJB_5881 
03E6: remove_text_box 
100@ = 0 

:BURGJB_5881
94@ = 1 
jump @BURGJB_6001 

:BURGJB_5895
if 
0475:   actor " + PlayerActor + @" near_object_in_cube 49@ radius 1.7 1.7 2.0 sphere 0 on_foot 
else_jump @BURGJB_5974 
if 
  100@ == 0 
else_jump @BURGJB_5967 
0512: show_permanent_text_box 'BURG23'  
100@ = 1 

:BURGJB_5967
jump @BURGJB_6001 

:BURGJB_5974
if 
  100@ == 1 
else_jump @BURGJB_6001 
03E6: remove_text_box 
100@ = 0 

:BURGJB_6001
jump @BURGJB_6064 

:BURGJB_6008
if 
03CA:   object 49@ exists 
else_jump @BURGJB_6057 
if 
8737:   not actor " + PlayerActor + @" lifting_object 49@ 
else_jump @BURGJB_6050 
94@ = 0 

:BURGJB_6050
jump @BURGJB_6064 

:BURGJB_6057
94@ = 0 

:BURGJB_6064
if or
  " + BURGLARY_Detected_Flag + @" == 1 
  98@ == 1 
else_jump @BURGJB_6122 
" + BURGLARY_Detected_Flag + @" = 0 
98@ = 0 
0151: remove_status_text " + BURGLARY_Escape_Time_Sec + @" 
" + BURGLARY_Escape_Time_Sec + @" = 10 
109@ = 0 

:BURGJB_6122
if 
  101@ == 1 
else_jump @BURGJB_6179 
0151: remove_status_text " + BURGLARY_Noise_i + @" 
" + BURGLARY_Noise_f + @" = 0.0 
41@ = 0.0 
" + BURGLARY_Noise_i + @" = 0 
101@ = 0 

:BURGJB_6179
if 
  94@ == 1 
else_jump @BURGJB_6506 
0407: store_coords_to 66@ 67@ 68@ from_car 50@ with_offset 0.0 -6.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 66@ 67@ 68@ radius 3.5 3.5 2.0 on_foot 
else_jump @BURGJB_6479 
if 
  100@ == 0 
else_jump @BURGJB_6304 
0512: show_permanent_text_box 'BURG24'  
100@ = 1 

:BURGJB_6304
if 
00E1:   player 0 pressed_key 15 
else_jump @BURGJB_6472 
03E6: remove_text_box 
48@ += 1 
33@ = 0 
104@ = 0 
if 
03CA:   object 49@ exists 
else_jump @BURGJB_6465 

:BURGJB_6360
if 
  104@ == 0 
else_jump @BURGJB_6428 
if or
8737:   not actor " + PlayerActor + @" lifting_object 49@ 
   Actor.Dead(" + PlayerActor + @")
  33@ > 5000 
else_jump @BURGJB_6417 
104@ = 1 

:BURGJB_6417
wait 0 
jump @BURGJB_6360 

:BURGJB_6428
Object.Destroy(49@)
Object.RemoveReferences(49@)
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
94@ = 0 

:BURGJB_6465
100@ = 0 

:BURGJB_6472
jump @BURGJB_6506 

:BURGJB_6479
if 
  100@ == 1 
else_jump @BURGJB_6506 
03E6: remove_text_box 
100@ = 0 

:BURGJB_6506
if 
  92@ == 1 
else_jump @BURGJB_7674 
if and
  98@ == 0 
  " + BURGLARY_Detected_Flag + @" == 0 
else_jump @BURGJB_6979 
if 
  101@ == 0 
else_jump @BURGJB_6631" );
get_external_script_status<HOUSE>( _local111 );
AppendLine( @"if 
  111@ > 0 
else_jump @BURGJB_6624 
04F7: status_text " + BURGLARY_Noise_i + @" type 1 line 2 GXT 'BURG25' 
0489: set_actor " + PlayerActor + @" muted 1 
101@ = 1 

:BURGJB_6624
jump @BURGJB_6972 

:BURGJB_6631" );
get_external_script_status<HOUSE>( _local111 );
AppendLine( @"if 
   not 111@ == 0 
else_jump @BURGJB_6926 
Actor.StorePos(" + PlayerActor + @", 63@, 64@, 65@)
0855: get_actor -1 noise_level_at 63@ 64@ 65@ store_to " + BURGLARY_Noise_f + @" 
" + BURGLARY_Noise_f + @" *= 1.6 
if 
  " + BURGLARY_Noise_f + @" > 20.0 
else_jump @BURGJB_6735 
" + BURGLARY_Noise_f + @" -= 20.0 
005D: 41@ += " + BURGLARY_Noise_f + @" 

:BURGJB_6735
41@ *= 0.99 
0090: " + BURGLARY_Noise_i + @" = float 41@ to_integer 
if 
  " + BURGLARY_Noise_i + @" >= 100 
else_jump @BURGJB_6815 
" + BURGLARY_Noise_i + @" = 100 
if 
  106@ == 0 
else_jump @BURGJB_6808 
01BD: 89@ = current_time_in_ms 
106@ = 1 

:BURGJB_6808
jump @BURGJB_6847 

:BURGJB_6815
if 
  0 > " + BURGLARY_Noise_i + @" 
else_jump @BURGJB_6840 
" + BURGLARY_Noise_i + @" = 0 

:BURGJB_6840
106@ = 0 

:BURGJB_6847
if 
  106@ == 1 
else_jump @BURGJB_6919 
01BD: 90@ = current_time_in_ms 
0085: 91@ = 90@ 
0062: 91@ -= 89@ 
if 
  91@ > 200 
else_jump @BURGJB_6919 
98@ = 1 
105@ += 1 

:BURGJB_6919
jump @BURGJB_6972 

:BURGJB_6926
0151: remove_status_text " + BURGLARY_Noise_i + @" 
" + BURGLARY_Noise_f + @" = 0.0 
41@ = 0.0 
" + BURGLARY_Noise_i + @" = 0 
101@ = 0 
0489: set_actor " + PlayerActor + @" muted 0 

:BURGJB_6972
jump @BURGJB_7336 

:BURGJB_6979
if 
  101@ == 1 
else_jump @BURGJB_7091 
0151: remove_status_text " + BURGLARY_Noise_i + @" 
" + BURGLARY_Escape_Time_Sec + @" = 10 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG55' time 5000 flag 1  
04F7: status_text " + BURGLARY_Escape_Time_Sec + @" type 0 line 2 GXT 'BURG61' 
01BD: 89@ = current_time_in_ms 
" + BURGLARY_Noise_f + @" = 0.0 
41@ = 0.0 
" + BURGLARY_Noise_i + @" = 0 
101@ = 0 
jump @BURGJB_7336 

:BURGJB_7091
if 
  109@ == 0 
else_jump @BURGJB_7336 
01BD: 90@ = current_time_in_ms 
0085: 91@ = 90@ 
0062: 91@ -= 89@ 
91@ /= 1000 
" + BURGLARY_Escape_Time_Sec + @" = 10 
0066: " + BURGLARY_Escape_Time_Sec + @" -= 91@ 
if or
  0 > " + BURGLARY_Escape_Time_Sec + @" 
  " + BURGLARY_Escape_Time_Sec + @" == 0 
else_jump @BURGJB_7247 
" + BURGLARY_Escape_Time_Sec + @" = 0 
if 
   not Player.WantedLevel(" + PlayerChar + @") > 4
else_jump @BURGJB_7210 
Player.SetMinWantedLevel(" + PlayerChar + @", 3)

:BURGJB_7210
109@ = 1 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG60' time 5000 flag 1  
0151: remove_status_text " + BURGLARY_Escape_Time_Sec + @" 
jump @BURGJB_7336 

:BURGJB_7247
03D5: remove_text 'BURG58'  
03D5: remove_text 'BURG59'  
09C1: add_next_text_to_brief_history 0 
if 
  " + BURGLARY_Escape_Time_Sec + @" > 1 
else_jump @BURGJB_7317 
01E4: show_text_1number_lowpriority GXT 'BURG58' number " + BURGLARY_Escape_Time_Sec + @" time 1000 flag 1  
jump @BURGJB_7336 

:BURGJB_7317
01E4: show_text_1number_lowpriority GXT 'BURG59' number " + BURGLARY_Escape_Time_Sec + @" time 1000 flag 1  

:BURGJB_7336
if 
  94@ == 0 
else_jump @BURGJB_7596 
Actor.StorePos(" + PlayerActor + @", 63@, 64@, 65@)
0866: get_object_in_sphere 63@ 64@ 65@ radius 5.0 handle_as 49@ 
if 
   not 49@ == -1 
else_jump @BURGJB_7589 
if 
0737:   actor " + PlayerActor + @" lifting_object 49@ 
else_jump @BURGJB_7483 
if 
  100@ == 1 
else_jump @BURGJB_7469 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG57' time 5000 flag 1  
03E6: remove_text_box 
100@ = 0 

:BURGJB_7469
94@ = 1 
jump @BURGJB_7589 

:BURGJB_7483
if 
0475:   actor " + PlayerActor + @" near_object_in_cube 49@ radius 1.7 1.7 2.0 sphere 0 on_foot 
else_jump @BURGJB_7562 
if 
  100@ == 0 
else_jump @BURGJB_7555 
0512: show_permanent_text_box 'BURG23'  
100@ = 1 

:BURGJB_7555
jump @BURGJB_7589 

:BURGJB_7562
if 
  100@ == 1 
else_jump @BURGJB_7589 
03E6: remove_text_box 
100@ = 0 

:BURGJB_7589
jump @BURGJB_7674 

:BURGJB_7596
if 
03CA:   object 49@ exists 
else_jump @BURGJB_7674 
if 
8737:   not actor " + PlayerActor + @" lifting_object 49@ 
else_jump @BURGJB_7674 
if 
  94@ == 1 
else_jump @BURGJB_7667 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'BURG30' time 5000 flag 1  

:BURGJB_7667
94@ = 0 

:BURGJB_7674
jump @BURGJB_7825 

:BURGJB_7681
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_7811 
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @BURGJB_7733 
Player.CanMove(" + PlayerChar + @") = False

:BURGJB_7733
fade 0 1000 

:BURGJB_7740
if 
fading 
else_jump @BURGJB_7764 
wait 0 
jump @BURGJB_7740 

:BURGJB_7764
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")
fade 1 1000 

:BURGJB_7787
if 
fading 
else_jump @BURGJB_7811 
wait 0 
jump @BURGJB_7787 

:BURGJB_7811
jump @BURGJB_8332 
95@ = 1 

:BURGJB_7825
jump @BURGJB_7946 

:BURGJB_7832
if 
0500:   player " + PlayerChar + @" skin == ""BALACLAVA"" on_bodypart 17 
else_jump @BURGJB_7939 
fade 0 1000 

:BURGJB_7868
if 
fading 
else_jump @BURGJB_7892 
wait 0 
jump @BURGJB_7868 

:BURGJB_7892
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
Player.Build(" + PlayerChar + @")
fade 1 1000 

:BURGJB_7915
if 
fading 
else_jump @BURGJB_7939 
wait 0 
jump @BURGJB_7915 

:BURGJB_7939
jump @BURGJB_8332 

:BURGJB_7946
jump @BURGJB_1044 

:BURGJB_7953
0293: " + _13 + @" = get_controller_mode 
if 
   not " + _13 + @" == 3 
else_jump @BURGJB_8042 
if 
00E1:   player 0 pressed_key 19 
else_jump @BURGJB_8035 
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_8035 
if 
   Actor.InCar(" + PlayerActor + @", 50@)
else_jump @BURGJB_8035 
96@ = 1 

:BURGJB_8035
jump @BURGJB_8101 

:BURGJB_8042
if 
00E1:   player 0 pressed_key 14 
else_jump @BURGJB_8101 
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_8101 
if 
   Actor.InCar(" + PlayerActor + @", 50@)
else_jump @BURGJB_8101 
96@ = 1 

:BURGJB_8101
if 
  96@ == 1 
else_jump @BURGJB_8330 
if 
   not " + _13 + @" == 3 
else_jump @BURGJB_8237 
if 
80E1:   not player 0 pressed_key 19 
else_jump @BURGJB_8230 
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_8230 
if 
   Actor.InCar(" + PlayerActor + @", 50@)
else_jump @BURGJB_8221 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BURG41' time 5000 flag 1  
95@ = 1 
jump @BURGJB_8228 

:BURGJB_8221
96@ = 0 

:BURGJB_8228
return 

:BURGJB_8230
jump @BURGJB_8330 

:BURGJB_8237
if 
80E1:   not player 0 pressed_key 14 
else_jump @BURGJB_8330 
if 
   not Car.Wrecked(50@)
else_jump @BURGJB_8330 
if 
   Actor.InCar(" + PlayerActor + @", 50@)
else_jump @BURGJB_8321 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BURG41' time 5000 flag 1  
95@ = 1 
jump @BURGJB_8328 

:BURGJB_8321
96@ = 0 

:BURGJB_8328
return 

:BURGJB_8330
return 

:BURGJB_8332
00BA: show_text_styled GXT 'B_FAIL1' time 5000 style 5  
036D: show_text_2numbers_styled GXT 'BURG37' numbers 47@ " + BUGRLARY_Cash + @" time 5000 style 1  
return 

:BURGJB_8372
if 
  " + Mission_Burglary_Passed + @" == 0 
else_jump @BURGJB_8440 
Player.InfiniteRun(" + PlayerChar + @") = True
01E3: show_text_1number_styled GXT 'BURG54' number 3000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 3000
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 2 
" + Mission_Burglary_Passed + @" = 1 

:BURGJB_8440
return 
return 

:BURGJB_8444
" + CARMOD_Disabled_Flag + @" = 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @BURGJB_8474 
0489: set_actor " + PlayerActor + @" muted 0 

:BURGJB_8474
0A2D: hide_styled_text_while_fading 1 
09E6: set_burglary_houses_accessible 0 
Garage.ChangeType(s" + tmp_Burglary_Garages + @"[0], 43)
Garage.ChangeType(s" + tmp_Burglary_Garages + @"[1], 43)
Garage.ChangeType(s" + tmp_Burglary_Garages + @"[2], 43)
Car.RemoveReferences(50@)
Marker.Disable(52@)
Marker.Disable(51@)
0151: remove_status_text " + BURGLARY_Noise_i + @" 
014F: stop_timer " + BURGLARY_Daylight + @" 
014F: stop_timer " + BURGLARY_Time_left + @" 
0151: remove_status_text " + BUGRLARY_Cash + @" 
0151: remove_status_text " + BURGLARY_Escape_Time_Sec + @" 
" + ONMISSION_Burglary + @" = 0 
" + OnMission + @" = 0 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
mission_cleanup 
return" );
            }

        }

    }

}