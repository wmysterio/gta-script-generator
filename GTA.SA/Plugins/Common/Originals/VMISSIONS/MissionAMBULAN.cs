using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class AMBULAN : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @AMBULAN_16 
gosub @AMBULAN_13155 
end_thread 

:AMBULAN_16
" + OnMission + @" = 1 
" + ONMISSION_Paramedic + @" = 1 
if 
  " + _1487 + @" == 0 
else_jump @AMBULAN_61 
increment_mission_attempts 

:AMBULAN_61
wait 0 
08F4: set_max_group_members 0 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @AMBULAN_221 
213@ = Actor.MissionCar(" + PlayerActor + @")
if 
8431:   not car 213@ passenger_seat_free 0 
else_jump @AMBULAN_134 
0432: 81@ = get_actor_handle_from_car 213@ passenger_seat 0 
0622: AS_actor 81@ bail_car 213@ 
Actor.RemoveReferences(81@)

:AMBULAN_134
if 
8431:   not car 213@ passenger_seat_free 1 
else_jump @AMBULAN_175 
0432: 81@ = get_actor_handle_from_car 213@ passenger_seat 1 
0622: AS_actor 81@ bail_car 213@ 
Actor.RemoveReferences(81@)

:AMBULAN_175
if 
8431:   not car 213@ passenger_seat_free 2 
else_jump @AMBULAN_216 
0432: 81@ = get_actor_handle_from_car 213@ passenger_seat 2 
0622: AS_actor 81@ bail_car 213@ 
Actor.RemoveReferences(81@)

:AMBULAN_216
Car.RemoveReferences(213@)

:AMBULAN_221
060A: create_decision_maker_type 0 store_to 235@ 
054C: use_GXT_table 'AMBULAE' 
08F8: display_stat_update_box 0 
" + _8210 + @" = 20000 
34@ = 0 
39@ = 0 
40@ = 0 
41@ = 0 
42@ = 0 
43@ = 0 
37@ = 1 
36@ = 0 
83@ = 0 
86@ = 0 
89@ = 0 
92@ = 0 
95@ = 0 
58@ = 0 
61@ = 0 
64@ = 0 
67@ = 0 
70@ = 0 
73@ = 0 
76@ = 0 
46@ = 0 
189@ = 10.0 
" + Paramedic_Mission_Level + @" = 1
48@ = 0 
49@ = 0 
44@ = 0 
45@ = 0 
51@ = 0 
52@ = 0 
53@ = 0 
50@ = 0 
55@ = 0 
79@ = 0 
176@ = 0.0 
177@ = 0.0 
178@ = 0.0 
99@ = 0 

:AMBULAN_522
if 
  13 > 99@ 
else_jump @AMBULAN_658 
100@(99@,13i) = 0 
113@(99@,13f) = 0.0 
126@(99@,13f) = 0.0 
139@(99@,13f) = 0.0 
152@(99@,13i) = 0 
if 
  10 > 99@ 
else_jump @AMBULAN_644 
214@(99@,10i) = 0 
224@(99@,10i) = 0 

:AMBULAN_644
99@ += 1 
jump @AMBULAN_522 

:AMBULAN_658
99@ = 0 
96@ = 0 
97@ = 0 
234@ = 0 
" + _8212 + @" = 0 
238@ = 0.0 

:AMBULAN_703
if 
  10 > 99@ 
else_jump @AMBULAN_836 
if 
07E8:   acquaintance 4 of_actors_type 99@ to_actors_type 0 set 
else_jump @AMBULAN_775 
224@(99@,10i) = 1 
234@ += 1 
0747: clear_acquaintance 4 of_actors_pedtype 99@ to_actors_pedtype 0 
jump @AMBULAN_822 

:AMBULAN_775
if 
07E8:   acquaintance 3 of_actors_type 99@ to_actors_type 0 set 
else_jump @AMBULAN_822 
214@(99@,10i) = 1 
234@ += 1 
0747: clear_acquaintance 3 of_actors_pedtype 99@ to_actors_pedtype 0 

:AMBULAN_822
99@ += 1 
jump @AMBULAN_703 

:AMBULAN_836
99@ = 0 
00BC: show_text_highpriority GXT 'ATUTOR2' time 3000 flag 1  
03C7: set_sensitivity_to_crime 0.5 
Actor.StorePos(" + PlayerActor + @", 201@, 202@, 203@)
212@ = 9999999.0 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  2 > " + STAT_Unlocked_Cities_Number + @" 
else_jump @AMBULAN_1470 
if 
  " + STAT_Unlocked_Cities_Number + @" == 0 
else_jump @AMBULAN_1130 
050A: 204@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 2004.96 -1442.96 12.56 
if 
0025:   212@ > 204@ 
else_jump @AMBULAN_997 
0087: 212@ = 204@ 
213@ = 1 

:AMBULAN_997
050A: 205@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1180.85 -1325.57 12.58 
if 
0025:   212@ > 205@ 
else_jump @AMBULAN_1060 
0087: 212@ = 205@ 
213@ = 2 

:AMBULAN_1060
050A: 208@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1244.437 331.2261 18.5547 
if 
0025:   212@ > 208@ 
else_jump @AMBULAN_1123 
0087: 212@ = 208@ 
213@ = 5 

:AMBULAN_1123
jump @AMBULAN_1463 

:AMBULAN_1130
if 
  " + STAT_Unlocked_Cities_Number + @" == 1 
else_jump @AMBULAN_1463 
050A: 204@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 2004.96 -1442.96 12.56 
if 
0025:   212@ > 204@ 
else_jump @AMBULAN_1211 
0087: 212@ = 204@ 
213@ = 1 

:AMBULAN_1211
050A: 205@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1180.85 -1325.57 12.58 
if 
0025:   212@ > 205@ 
else_jump @AMBULAN_1274 
0087: 212@ = 205@ 
213@ = 2 

:AMBULAN_1274
050A: 208@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1244.437 331.2261 18.5547 
if 
0025:   212@ > 208@ 
else_jump @AMBULAN_1337 
0087: 212@ = 208@ 
213@ = 5 

:AMBULAN_1337
050A: 209@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ -2198.693 -2290.105 29.625 
if 
0025:   212@ > 209@ 
else_jump @AMBULAN_1400 
0087: 212@ = 209@ 
213@ = 6 

:AMBULAN_1400
050A: 210@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ -2670.285 616.4364 13.4531 
if 
0025:   212@ > 210@ 
else_jump @AMBULAN_1463 
0087: 212@ = 210@ 
213@ = 7 

:AMBULAN_1463
jump @AMBULAN_1974 

:AMBULAN_1470
050A: 204@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 2004.96 -1442.96 12.56 
if 
0025:   212@ > 204@ 
else_jump @AMBULAN_1533 
0087: 212@ = 204@ 
213@ = 1 

:AMBULAN_1533
050A: 205@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1180.85 -1325.57 12.58 
if 
0025:   212@ > 205@ 
else_jump @AMBULAN_1596 
0087: 212@ = 205@ 
213@ = 2 

:AMBULAN_1596
050A: 206@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ -316.3832 1056.045 18.7344 
if 
0025:   212@ > 206@ 
else_jump @AMBULAN_1659 
0087: 212@ = 206@ 
213@ = 3 

:AMBULAN_1659
050A: 207@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ -1514.823 2527.119 54.7443 
if 
0025:   212@ > 207@ 
else_jump @AMBULAN_1722 
0087: 212@ = 207@ 
213@ = 4 

:AMBULAN_1722
050A: 208@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1244.437 331.2261 18.5547 
if 
0025:   212@ > 208@ 
else_jump @AMBULAN_1785 
0087: 212@ = 208@ 
213@ = 5 

:AMBULAN_1785
050A: 209@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ -2198.693 -2290.105 29.625 
if 
0025:   212@ > 209@ 
else_jump @AMBULAN_1848 
0087: 212@ = 209@ 
213@ = 6 

:AMBULAN_1848
050A: 210@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ -2670.285 616.4364 13.4531 
if 
0025:   212@ > 210@ 
else_jump @AMBULAN_1911 
0087: 212@ = 210@ 
213@ = 7 

:AMBULAN_1911
050A: 211@ = distance_between_XYZ 201@ 202@ 203@ and_XYZ 1578.446 1770.682 9.8358 
if 
0025:   212@ > 211@ 
else_jump @AMBULAN_1974 
0087: 212@ = 211@ 
213@ = 8 

:AMBULAN_1974
0871: init_jump_table 213@ total_jumps 8 default_jump 1 @AMBULAN_2958 jumps 1 @AMBULAN_2102 2 @AMBULAN_2209 3 @AMBULAN_2316 4 @AMBULAN_2423 5 @AMBULAN_2530 6 @AMBULAN_2637 7 @AMBULAN_2744 
0872: jump_table_jumps 8 @AMBULAN_2851 -1 @AMBULAN_3065 -1 @AMBULAN_3065 -1 @AMBULAN_3065 -1 @AMBULAN_3065 -1 @AMBULAN_3065 -1 @AMBULAN_3065 -1 @AMBULAN_3065 -1 @AMBULAN_3065 

:AMBULAN_2102
167@ = 2004.96 
168@ = -1442.96 
169@ = 12.56 
173@ = 2026.0 
174@ = -1423.0 
175@ = 17.0 
197@ = 1200.0 
198@ = 2930.0 
199@ = -2213.0 
200@ = -1012.0 
jump @AMBULAN_3065 

:AMBULAN_2209
167@ = 1180.85 
168@ = -1325.57 
169@ = 12.58 
173@ = 1172.0 
174@ = -1324.0 
175@ = 15.0 
197@ = 450.0 
198@ = 1800.0 
199@ = -1900.0 
200@ = -870.0 
jump @AMBULAN_3065 

:AMBULAN_2316
167@ = -316.3832 
168@ = 1056.045 
169@ = 18.7344 
173@ = -316.0 
174@ = 1050.0 
175@ = 20.0 
197@ = -860.0 
198@ = 185.0 
199@ = 749.0 
200@ = 1616.0 
jump @AMBULAN_3065 

:AMBULAN_2423
167@ = -1514.006 
168@ = 2532.013 
169@ = 54.7443 
173@ = -1515.0 
174@ = 2520.0 
175@ = 56.0 
197@ = -1684.0 
198@ = -702.0 
199@ = 1465.0 
200@ = 2749.9 
jump @AMBULAN_3065 

:AMBULAN_2530
167@ = 1225.0 
168@ = 302.0 
169@ = 20.0 
173@ = 1227.0 
174@ = 289.5 
175@ = 22.64 
197@ = 100.0 
198@ = 2604.0 
199@ = -720.0 
200@ = 465.0 
jump @AMBULAN_3065 

:AMBULAN_2637
167@ = -2198.693 
168@ = -2290.105 
169@ = 29.625 
173@ = -2204.728 
174@ = -2296.302 
175@ = 29.6181 
197@ = -2598.0 
198@ = -1500.0 
199@ = -2700.0 
200@ = -1700.0 
jump @AMBULAN_3065 

:AMBULAN_2744
167@ = -2670.285 
168@ = 616.4364 
169@ = 13.4531 
173@ = -2677.0 
174@ = 632.0 
175@ = 14.0 
197@ = -2820.0 
198@ = -1784.0 
199@ = 29.0 
200@ = 1180.0 
jump @AMBULAN_3065 

:AMBULAN_2851
167@ = 1578.446 
168@ = 1770.682 
169@ = 9.8358 
173@ = 1582.0 
174@ = 1765.0 
175@ = 11.0 
197@ = 1000.0 
198@ = 2600.0 
199@ = 772.0 
200@ = 2400.0 
jump @AMBULAN_3065 

:AMBULAN_2958
167@ = 2004.96 
168@ = -1442.96 
169@ = 12.56 
173@ = 2026.0 
174@ = -1423.0 
175@ = 17.0 
197@ = 1200.0 
198@ = 2930.0 
199@ = -2213.0 
200@ = -1012.0 
jump @AMBULAN_3065 

:AMBULAN_3065
03C3: set_timer_to " + _8210 + @" type 1 GXT 'AMBTIME' 
04F7: status_text " + _8212 + @" type 0 line 2 GXT 'AMBSEAT' 
04F7: status_text " + Paramedic_Mission_Level + @" type 0 line 1 GXT 'ALEV' 
if 
  " + OnMission + @" == 0 
else_jump @AMBULAN_3149 
018A: 47@ = create_checkpoint_at 167@ 168@ 169@ 

:AMBULAN_3149
014F: stop_timer " + _8210 + @" 

:AMBULAN_3154
if 
001D:   37@ > 36@ 
else_jump @AMBULAN_3355 
gosub @AMBULAN_7829 
0087: 113@(36@,13f) = 176@ 
0087: 126@(36@,13f) = 177@ 
0087: 139@(36@,13f) = 178@ 
if 
  79@ == 1 
else_jump @AMBULAN_3241 
jump @AMBULAN_13155 

:AMBULAN_3241
gosub @AMBULAN_10937 
0085: 152@(36@,13i) = 35@ 
if 
  152@(36@,13i) > 45000 
else_jump @AMBULAN_3306 
152@(36@,13i) = 45000 
jump @AMBULAN_3341 

:AMBULAN_3306
if 
  15000 > 152@(36@,13i) 
else_jump @AMBULAN_3341 
152@(36@,13i) = 15000 

:AMBULAN_3341
36@ += 1 
jump @AMBULAN_3154 

:AMBULAN_3355
gosub @AMBULAN_3747 
if 
  37@ > 3 
else_jump @AMBULAN_3394 
45@ = 1 
jump @AMBULAN_3401 

:AMBULAN_3394
45@ = 0 

:AMBULAN_3401
51@ = 0 
if 
  2 > 37@ 
else_jump @AMBULAN_3537 
0085: 48@ = 35@ 
0072: 48@ /= 37@ 
48@ /= 2 
0085: 38@ = 37@ 
38@ += 1 
006A: 48@ *= 38@ 
005E: " + _8210 + @" += 48@ 
0074: " + _8210 + @" /= 37@ 
0085: 48@ = 35@ 
48@ /= 3 
if 
  48@ > 15000 
else_jump @AMBULAN_3530 
48@ = 15000 

:AMBULAN_3530
jump @AMBULAN_3614 

:AMBULAN_3537
008B: 48@ = " + _8210 + @" 
0072: 48@ /= 37@ 
48@ /= 2 
0085: 38@ = 37@ 
38@ += 1 
006A: 48@ *= 38@ 
005E: " + _8210 + @" += 48@ 
0074: " + _8210 + @" /= 37@ 
008B: 48@ = " + _8210 + @" 
48@ /= 3 

:AMBULAN_3614
if 
  60000 > " + _8210 + @" 
else_jump @AMBULAN_3645 
" + _8210 + @" = 60000 

:AMBULAN_3645
if 
  25000 > 48@ 
else_jump @AMBULAN_3679 
48@ = 25000 
jump @AMBULAN_3710 

:AMBULAN_3679
if 
  48@ > 60000 
else_jump @AMBULAN_3710 
48@ = 60000 

:AMBULAN_3710
03C3: set_timer_to " + _8210 + @" type 1 GXT 'AMBTIME' 
239@ = 0 
240@ = 0 
jump @AMBULAN_11090 

:AMBULAN_3747
if 
  37@ > 0 
else_jump @AMBULAN_3874 
0376: 81@ = create_random_actor_at 113@ 126@ 139@ 
0575: set_actor 81@ keep_position 1 
0588: disable_actor 81@ validate_position 0 
83@ = 1 
060B: set_actor 81@ decision_maker_to 235@ 
0332: set_actor 81@ bleeding 1 
02A9: set_actor 81@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(81@) = 188@
82@ = Marker.CreateAboveActor(81@)
07E0: set_marker 82@ type_to 1 
Marker.SetIconSize(82@, 2)
100@ = 1 

:AMBULAN_3874
if 
  37@ > 1 
else_jump @AMBULAN_4001 
0376: 84@ = create_random_actor_at 114@ 127@ 140@ 
86@ = 1 
060B: set_actor 84@ decision_maker_to 235@ 
0332: set_actor 84@ bleeding 1 
02A9: set_actor 84@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(84@) = 188@
85@ = Marker.CreateAboveActor(84@)
07E0: set_marker 85@ type_to 1 
Marker.SetIconSize(85@, 2)
0575: set_actor 84@ keep_position 1 
0588: disable_actor 84@ validate_position 0 
101@ = 1 

:AMBULAN_4001
if 
  37@ > 2 
else_jump @AMBULAN_4128 
0376: 87@ = create_random_actor_at 115@ 128@ 141@ 
89@ = 1 
060B: set_actor 87@ decision_maker_to 235@ 
0332: set_actor 87@ bleeding 1 
02A9: set_actor 87@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(87@) = 188@
88@ = Marker.CreateAboveActor(87@)
07E0: set_marker 88@ type_to 1 
Marker.SetIconSize(88@, 2)
0575: set_actor 87@ keep_position 1 
0588: disable_actor 87@ validate_position 0 
102@ = 1 

:AMBULAN_4128
if 
  37@ > 3 
else_jump @AMBULAN_4255 
0376: 90@ = create_random_actor_at 116@ 129@ 142@ 
92@ = 1 
060B: set_actor 90@ decision_maker_to 235@ 
0332: set_actor 90@ bleeding 1 
02A9: set_actor 90@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(90@) = 188@
91@ = Marker.CreateAboveActor(90@)
07E0: set_marker 91@ type_to 1 
Marker.SetIconSize(91@, 2)
0575: set_actor 90@ keep_position 1 
0588: disable_actor 90@ validate_position 0 
103@ = 1 

:AMBULAN_4255
if 
  37@ > 4 
else_jump @AMBULAN_4382 
0376: 93@ = create_random_actor_at 117@ 130@ 143@ 
95@ = 1 
060B: set_actor 93@ decision_maker_to 235@ 
0332: set_actor 93@ bleeding 1 
02A9: set_actor 93@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(93@) = 188@
94@ = Marker.CreateAboveActor(93@)
07E0: set_marker 94@ type_to 1 
Marker.SetIconSize(94@, 2)
0575: set_actor 93@ keep_position 1 
0588: disable_actor 93@ validate_position 0 
104@ = 1 

:AMBULAN_4382
if 
  37@ > 5 
else_jump @AMBULAN_4509 
0376: 56@ = create_random_actor_at 118@ 131@ 144@ 
58@ = 1 
060B: set_actor 56@ decision_maker_to 235@ 
0332: set_actor 56@ bleeding 1 
02A9: set_actor 56@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(56@) = 188@
57@ = Marker.CreateAboveActor(56@)
07E0: set_marker 57@ type_to 1 
Marker.SetIconSize(57@, 2)
0575: set_actor 56@ keep_position 1 
0588: disable_actor 56@ validate_position 0 
105@ = 1 

:AMBULAN_4509
if 
  37@ > 6 
else_jump @AMBULAN_4636 
0376: 59@ = create_random_actor_at 119@ 132@ 145@ 
61@ = 1 
060B: set_actor 59@ decision_maker_to 235@ 
0332: set_actor 59@ bleeding 1 
02A9: set_actor 59@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(59@) = 188@
60@ = Marker.CreateAboveActor(59@)
07E0: set_marker 60@ type_to 1 
Marker.SetIconSize(60@, 2)
0575: set_actor 59@ keep_position 1 
0588: disable_actor 59@ validate_position 0 
106@ = 1 

:AMBULAN_4636
if 
  37@ > 7 
else_jump @AMBULAN_4763 
0376: 62@ = create_random_actor_at 120@ 133@ 146@ 
64@ = 1 
060B: set_actor 62@ decision_maker_to 235@ 
0332: set_actor 62@ bleeding 1 
02A9: set_actor 62@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(62@) = 188@
63@ = Marker.CreateAboveActor(62@)
07E0: set_marker 63@ type_to 1 
Marker.SetIconSize(63@, 2)
0575: set_actor 62@ keep_position 1 
0588: disable_actor 62@ validate_position 0 
107@ = 1 

:AMBULAN_4763
if 
  37@ > 8 
else_jump @AMBULAN_4890 
0376: 65@ = create_random_actor_at 121@ 134@ 147@ 
67@ = 1 
060B: set_actor 65@ decision_maker_to 235@ 
0332: set_actor 65@ bleeding 1 
02A9: set_actor 65@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(65@) = 188@
66@ = Marker.CreateAboveActor(65@)
07E0: set_marker 66@ type_to 1 
Marker.SetIconSize(66@, 2)
0575: set_actor 65@ keep_position 1 
0588: disable_actor 65@ validate_position 0 
108@ = 1 

:AMBULAN_4890
if 
  37@ > 9 
else_jump @AMBULAN_5017 
0376: 68@ = create_random_actor_at 122@ 135@ 148@ 
70@ = 1 
060B: set_actor 68@ decision_maker_to 235@ 
0332: set_actor 68@ bleeding 1 
02A9: set_actor 68@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(68@) = 188@
69@ = Marker.CreateAboveActor(68@)
07E0: set_marker 69@ type_to 1 
Marker.SetIconSize(69@, 2)
0575: set_actor 68@ keep_position 1 
0588: disable_actor 68@ validate_position 0 
109@ = 1 

:AMBULAN_5017
if 
  37@ > 10 
else_jump @AMBULAN_5144 
0376: 71@ = create_random_actor_at 123@ 136@ 149@ 
73@ = 1 
060B: set_actor 71@ decision_maker_to 235@ 
0332: set_actor 71@ bleeding 1 
02A9: set_actor 71@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(71@) = 188@
72@ = Marker.CreateAboveActor(71@)
07E0: set_marker 72@ type_to 1 
Marker.SetIconSize(72@, 2)
0575: set_actor 71@ keep_position 1 
0588: disable_actor 71@ validate_position 0 
110@ = 1 

:AMBULAN_5144
if 
  37@ > 11 
else_jump @AMBULAN_5271 
0376: 74@ = create_random_actor_at 124@ 137@ 150@ 
76@ = 1 
060B: set_actor 74@ decision_maker_to 235@ 
0332: set_actor 74@ bleeding 1 
02A9: set_actor 74@ immune_to_nonplayer 1 
0208: 188@ = random_float_in_ranges 0.0 359.9 
Actor.Angle(74@) = 188@
75@ = Marker.CreateAboveActor(74@)
07E0: set_marker 75@ type_to 1 
Marker.SetIconSize(75@, 2)
0575: set_actor 74@ keep_position 1 
0588: disable_actor 74@ validate_position 0 
111@ = 1 

:AMBULAN_5271
return 

:AMBULAN_5273
0871: init_jump_table 239@ total_jumps 12 default_jump 1 @AMBULAN_7813 jumps 0 @AMBULAN_5401 1 @AMBULAN_5602 2 @AMBULAN_5803 3 @AMBULAN_6004 4 @AMBULAN_6205 5 @AMBULAN_6406 6 @AMBULAN_6607 
0872: jump_table_jumps 7 @AMBULAN_6808 8 @AMBULAN_7009 9 @AMBULAN_7210 10 @AMBULAN_7411 11 @AMBULAN_7612 -1 @AMBULAN_7827 -1 @AMBULAN_7827 -1 @AMBULAN_7827 -1 @AMBULAN_7827 

:AMBULAN_5401
if 
  37@ > 0 
else_jump @AMBULAN_5588 
if 
  3 > 83@ 
else_jump @AMBULAN_5588 
if 
   not Actor.Dead(81@)
else_jump @AMBULAN_5588 
if 
0106:   actor " + PlayerActor + @" near_actor 81@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_5549 
if 
  100@ == 1 
else_jump @AMBULAN_5542 
0575: set_actor 81@ keep_position 0 
0588: disable_actor 81@ validate_position 1 
Actor.PutAt(81@, 113@, 126@, 139@)
100@ = 0 

:AMBULAN_5542
jump @AMBULAN_5588 

:AMBULAN_5549
if 
  100@ == 0 
else_jump @AMBULAN_5588 
0575: set_actor 81@ keep_position 1 
0588: disable_actor 81@ validate_position 0 
100@ = 1 

:AMBULAN_5588
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_5602
if 
  37@ > 1 
else_jump @AMBULAN_5789 
if 
  3 > 86@ 
else_jump @AMBULAN_5789 
if 
   not Actor.Dead(84@)
else_jump @AMBULAN_5789 
if 
0106:   actor " + PlayerActor + @" near_actor 84@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_5750 
if 
  101@ == 1 
else_jump @AMBULAN_5743 
0575: set_actor 84@ keep_position 0 
0588: disable_actor 84@ validate_position 1 
Actor.PutAt(84@, 114@, 127@, 140@)
101@ = 0 

:AMBULAN_5743
jump @AMBULAN_5789 

:AMBULAN_5750
if 
  101@ == 0 
else_jump @AMBULAN_5789 
0575: set_actor 84@ keep_position 1 
0588: disable_actor 84@ validate_position 0 
101@ = 1 

:AMBULAN_5789
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_5803
if 
  37@ > 2 
else_jump @AMBULAN_5990 
if 
  3 > 89@ 
else_jump @AMBULAN_5990 
if 
   not Actor.Dead(87@)
else_jump @AMBULAN_5990 
if 
0106:   actor " + PlayerActor + @" near_actor 87@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_5951 
if 
  102@ == 1 
else_jump @AMBULAN_5944 
0575: set_actor 87@ keep_position 0 
0588: disable_actor 87@ validate_position 1 
Actor.PutAt(87@, 115@, 128@, 141@)
102@ = 0 

:AMBULAN_5944
jump @AMBULAN_5990 

:AMBULAN_5951
if 
  102@ == 0 
else_jump @AMBULAN_5990 
0575: set_actor 87@ keep_position 1 
0588: disable_actor 87@ validate_position 0 
102@ = 1 

:AMBULAN_5990
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_6004
if 
  37@ > 3 
else_jump @AMBULAN_6191 
if 
  3 > 92@ 
else_jump @AMBULAN_6191 
if 
   not Actor.Dead(90@)
else_jump @AMBULAN_6191 
if 
0106:   actor " + PlayerActor + @" near_actor 90@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_6152 
if 
  103@ == 1 
else_jump @AMBULAN_6145 
0575: set_actor 90@ keep_position 0 
0588: disable_actor 90@ validate_position 1 
Actor.PutAt(90@, 116@, 129@, 142@)
103@ = 0 

:AMBULAN_6145
jump @AMBULAN_6191 

:AMBULAN_6152
if 
  103@ == 0 
else_jump @AMBULAN_6191 
0575: set_actor 90@ keep_position 1 
0588: disable_actor 90@ validate_position 0 
103@ = 1 

:AMBULAN_6191
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_6205
if 
  37@ > 4 
else_jump @AMBULAN_6392 
if 
  3 > 95@ 
else_jump @AMBULAN_6392 
if 
   not Actor.Dead(93@)
else_jump @AMBULAN_6392 
if 
0106:   actor " + PlayerActor + @" near_actor 93@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_6353 
if 
  104@ == 1 
else_jump @AMBULAN_6346 
0575: set_actor 93@ keep_position 0 
0588: disable_actor 93@ validate_position 1 
Actor.PutAt(93@, 117@, 130@, 143@)
104@ = 0 

:AMBULAN_6346
jump @AMBULAN_6392 

:AMBULAN_6353
if 
  104@ == 0 
else_jump @AMBULAN_6392 
0575: set_actor 93@ keep_position 1 
0588: disable_actor 93@ validate_position 0 
104@ = 1 

:AMBULAN_6392
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_6406
if 
  37@ > 5 
else_jump @AMBULAN_6593 
if 
  3 > 58@ 
else_jump @AMBULAN_6593 
if 
   not Actor.Dead(56@)
else_jump @AMBULAN_6593 
if 
0106:   actor " + PlayerActor + @" near_actor 56@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_6554 
if 
  105@ == 1 
else_jump @AMBULAN_6547 
0575: set_actor 56@ keep_position 0 
0588: disable_actor 56@ validate_position 1 
Actor.PutAt(56@, 118@, 131@, 144@)
105@ = 0 

:AMBULAN_6547
jump @AMBULAN_6593 

:AMBULAN_6554
if 
  105@ == 0 
else_jump @AMBULAN_6593 
0575: set_actor 56@ keep_position 1 
0588: disable_actor 56@ validate_position 0 
105@ = 1 

:AMBULAN_6593
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_6607
if 
  37@ > 6 
else_jump @AMBULAN_6794 
if 
  3 > 61@ 
else_jump @AMBULAN_6794 
if 
   not Actor.Dead(59@)
else_jump @AMBULAN_6794 
if 
0106:   actor " + PlayerActor + @" near_actor 59@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_6755 
if 
  106@ == 1 
else_jump @AMBULAN_6748 
0575: set_actor 59@ keep_position 0 
0588: disable_actor 59@ validate_position 1 
Actor.PutAt(59@, 119@, 132@, 145@)
106@ = 0 

:AMBULAN_6748
jump @AMBULAN_6794 

:AMBULAN_6755
if 
  106@ == 0 
else_jump @AMBULAN_6794 
0575: set_actor 59@ keep_position 1 
0588: disable_actor 59@ validate_position 0 
106@ = 1 

:AMBULAN_6794
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_6808
if 
  37@ > 7 
else_jump @AMBULAN_6995 
if 
  3 > 64@ 
else_jump @AMBULAN_6995 
if 
   not Actor.Dead(62@)
else_jump @AMBULAN_6995 
if 
0106:   actor " + PlayerActor + @" near_actor 62@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_6956 
if 
  107@ == 1 
else_jump @AMBULAN_6949 
0575: set_actor 62@ keep_position 0 
0588: disable_actor 62@ validate_position 1 
Actor.PutAt(62@, 120@, 133@, 146@)
107@ = 0 

:AMBULAN_6949
jump @AMBULAN_6995 

:AMBULAN_6956
if 
  107@ == 0 
else_jump @AMBULAN_6995 
0575: set_actor 62@ keep_position 1 
0588: disable_actor 62@ validate_position 0 
107@ = 1 

:AMBULAN_6995
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_7009
if 
  37@ > 8 
else_jump @AMBULAN_7196 
if 
  3 > 67@ 
else_jump @AMBULAN_7196 
if 
   not Actor.Dead(65@)
else_jump @AMBULAN_7196 
if 
0106:   actor " + PlayerActor + @" near_actor 65@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_7157 
if 
  108@ == 1 
else_jump @AMBULAN_7150 
0575: set_actor 65@ keep_position 0 
0588: disable_actor 65@ validate_position 1 
Actor.PutAt(65@, 121@, 134@, 147@)
108@ = 0 

:AMBULAN_7150
jump @AMBULAN_7196 

:AMBULAN_7157
if 
  108@ == 0 
else_jump @AMBULAN_7196 
0575: set_actor 65@ keep_position 1 
0588: disable_actor 65@ validate_position 0 
108@ = 1 

:AMBULAN_7196
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_7210
if 
  37@ > 9 
else_jump @AMBULAN_7397 
if 
  3 > 70@ 
else_jump @AMBULAN_7397 
if 
   not Actor.Dead(68@)
else_jump @AMBULAN_7397 
if 
0106:   actor " + PlayerActor + @" near_actor 68@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_7358 
if 
  109@ == 1 
else_jump @AMBULAN_7351 
0575: set_actor 68@ keep_position 0 
0588: disable_actor 68@ validate_position 1 
Actor.PutAt(68@, 122@, 135@, 148@)
109@ = 0 

:AMBULAN_7351
jump @AMBULAN_7397 

:AMBULAN_7358
if 
  109@ == 0 
else_jump @AMBULAN_7397 
0575: set_actor 68@ keep_position 1 
0588: disable_actor 68@ validate_position 0 
109@ = 1 

:AMBULAN_7397
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_7411
if 
  37@ > 10 
else_jump @AMBULAN_7598 
if 
  3 > 73@ 
else_jump @AMBULAN_7598 
if 
   not Actor.Dead(71@)
else_jump @AMBULAN_7598 
if 
0106:   actor " + PlayerActor + @" near_actor 71@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_7559 
if 
  110@ == 1 
else_jump @AMBULAN_7552 
0575: set_actor 71@ keep_position 0 
0588: disable_actor 71@ validate_position 1 
Actor.PutAt(71@, 123@, 136@, 149@)
110@ = 0 

:AMBULAN_7552
jump @AMBULAN_7598 

:AMBULAN_7559
if 
  110@ == 0 
else_jump @AMBULAN_7598 
0575: set_actor 71@ keep_position 1 
0588: disable_actor 71@ validate_position 0 
110@ = 1 

:AMBULAN_7598
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_7612
if 
  37@ > 11 
else_jump @AMBULAN_7799 
if 
  3 > 76@ 
else_jump @AMBULAN_7799 
if 
   not Actor.Dead(74@)
else_jump @AMBULAN_7799 
if 
0106:   actor " + PlayerActor + @" near_actor 74@ radius 50.0 50.0 20.0 0 in_car 
else_jump @AMBULAN_7760 
if 
  111@ == 1 
else_jump @AMBULAN_7753 
0575: set_actor 74@ keep_position 0 
0588: disable_actor 74@ validate_position 1 
Actor.PutAt(74@, 124@, 137@, 150@)
111@ = 0 

:AMBULAN_7753
jump @AMBULAN_7799 

:AMBULAN_7760
if 
  111@ == 0 
else_jump @AMBULAN_7799 
0575: set_actor 74@ keep_position 1 
0588: disable_actor 74@ validate_position 0 
111@ = 1 

:AMBULAN_7799
239@ += 1 
jump @AMBULAN_7827 

:AMBULAN_7813
239@ = 0 
jump @AMBULAN_7827 

:AMBULAN_7827
return 

:AMBULAN_7829
wait 0 
Actor.StorePos(" + PlayerActor + @", 170@, 171@, 172@)
0087: 190@ = 167@ 
0087: 193@ = 167@ 
0087: 191@ = 168@ 
0087: 194@ = 168@ 
0087: 192@ = 169@ 
0087: 195@ = 169@ 
07EF: get_town_number_from_point 170@ 171@ 172@ store_to 96@ 
008F: 237@ = integer " + Paramedic_Mission_Level + @" to_float 
237@ *= 60.0 
005B: 237@ += 238@ 
if 
  96@ == 0 
else_jump @AMBULAN_7970 
238@ += 15.0 
jump @AMBULAN_7980 

:AMBULAN_7970
238@ += 1.0 

:AMBULAN_7980
if 
  100.0 > 237@ 
else_jump @AMBULAN_8011 
237@ = 100.0 

:AMBULAN_8011
if 
  238@ > 10000.0 
else_jump @AMBULAN_8077 
if 
  " + Paramedic_Mission_Level + @" == 1 
else_jump @AMBULAN_8077 
03D5: remove_text 'ALEVEL'  
00BC: show_text_highpriority GXT 'A_CANC' time 3000 flag 1  

:AMBULAN_8077
0063: 190@ -= 237@ 
005B: 193@ += 237@ 
0063: 191@ -= 237@ 
005B: 194@ += 237@ 
if 
  8 > " + Paramedic_Mission_Level + @" 
else_jump @AMBULAN_8242 
if 
0025:   197@ > 190@ 
else_jump @AMBULAN_8154 
0087: 190@ = 197@ 

:AMBULAN_8154
if 
0025:   193@ > 198@ 
else_jump @AMBULAN_8181 
0087: 193@ = 198@ 

:AMBULAN_8181
if 
0025:   199@ > 191@ 
else_jump @AMBULAN_8208 
0087: 191@ = 199@ 

:AMBULAN_8208
if 
0025:   166@ > 200@ 
else_jump @AMBULAN_8235 
0087: 194@ = 200@ 

:AMBULAN_8235
jump @AMBULAN_8274 

:AMBULAN_8242
0087: 190@ = 197@ 
0087: 193@ = 198@ 
0087: 191@ = 199@ 
0087: 194@ = 200@ 

:AMBULAN_8274
0208: 165@ = random_float_in_ranges 190@ 193@ 
0208: 166@ = random_float_in_ranges 191@ 194@ 
0293: " + _13 + @" = get_controller_mode 
if 
00E1:   player 0 pressed_key 19 
else_jump @AMBULAN_8325 
53@ = 1 

:AMBULAN_8325
if 
  53@ == 1 
else_jump @AMBULAN_8426 
if 
   not " + _13 + @" == 3 
else_jump @AMBULAN_8421 
if 
80E1:   not player 0 pressed_key 19 
else_jump @AMBULAN_8414 
03D5: remove_text 'ALEVEL'  
00BC: show_text_highpriority GXT 'A_CANC' time 3000 flag 1  
79@ = 1 
return 

:AMBULAN_8414
jump @AMBULAN_8426 

:AMBULAN_8421
0293: " + _13 + @" = get_controller_mode 

:AMBULAN_8426
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @AMBULAN_8497 
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #AMBULAN)
else_jump @AMBULAN_8497 
03D5: remove_text 'ALEVEL'  
00BC: show_text_highpriority GXT 'A_CANC' time 3000 flag 1  
79@ = 1 
return 

:AMBULAN_8497
02C0: store_to 176@ 177@ 178@ ped_path_coords_closest_to 165@ 166@ 169@ 
if 
0025:   197@ > 176@ 
else_jump @AMBULAN_8550 
jump @AMBULAN_7829 
jump @AMBULAN_8642 

:AMBULAN_8550
if 
0025:   176@ > 198@ 
else_jump @AMBULAN_8583 
jump @AMBULAN_7829 
jump @AMBULAN_8642 

:AMBULAN_8583
if 
0025:   199@ > 177@ 
else_jump @AMBULAN_8616 
jump @AMBULAN_7829 
jump @AMBULAN_8642 

:AMBULAN_8616
if 
0025:   177@ > 200@ 
else_jump @AMBULAN_8642 
jump @AMBULAN_7829 

:AMBULAN_8642
if 
  6.0 > 178@ 
else_jump @AMBULAN_8670 
jump @AMBULAN_7829 

:AMBULAN_8670
050A: 185@ = distance_between_XYZ 170@ 171@ 172@ and_XYZ 176@ 177@ 178@ 
if 
  50.0 > 185@ 
else_jump @AMBULAN_8721 
jump @AMBULAN_7829 

:AMBULAN_8721
050A: 186@ = distance_between_XYZ 167@ 168@ 169@ and_XYZ 176@ 177@ 178@ 
if 
  30.0 > 186@ 
else_jump @AMBULAN_8772 
jump @AMBULAN_7829 

:AMBULAN_8772
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  2 > " + STAT_Unlocked_Cities_Number + @" 
else_jump @AMBULAN_9234 
if 
  " + STAT_Unlocked_Cities_Number + @" == 0 
else_jump @AMBULAN_9048 
if and
  78.4427 > 176@ 
  -699.519 > 177@ 
else_jump @AMBULAN_8858 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_8858
if and
  -252.6557 > 176@ 
  -285.766 > 177@ 
else_jump @AMBULAN_8900 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_8900
if 
  -948.3447 > 176@ 
else_jump @AMBULAN_8932 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_8932
if and
  176@ > 1473.448 
  177@ > 403.7353 
else_jump @AMBULAN_8974 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_8974
if 
  177@ > 578.6325 
else_jump @AMBULAN_9006 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_9006
if and
  837.5551 > 176@ 
  177@ > 347.4097 
else_jump @AMBULAN_9048 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_9048
if 
  " + STAT_Unlocked_Cities_Number + @" == 1 
else_jump @AMBULAN_9234 
if and
  176@ > 1473.448 
  177@ > 403.7353 
else_jump @AMBULAN_9108 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_9108
if and
  177@ > 578.6325 
  176@ > -1528.498 
else_jump @AMBULAN_9150 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_9150
if and
  837.5551 > 176@ 
  176@ > -1528.498 
  177@ > 347.4097 
else_jump @AMBULAN_9202 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_9202
if 
  177@ > 1380.0 
else_jump @AMBULAN_9234 
wait 0 
jump @AMBULAN_7829 

:AMBULAN_9234
if 
  37@ > 0 
else_jump @AMBULAN_9303 
050A: 212@ = distance_between_XYZ 113@ 126@ 139@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9303 
jump @AMBULAN_7829 

:AMBULAN_9303
if 
  37@ > 1 
else_jump @AMBULAN_9372 
050A: 212@ = distance_between_XYZ 113@ 126@ 139@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9372 
jump @AMBULAN_7829 

:AMBULAN_9372
if 
  37@ > 2 
else_jump @AMBULAN_9441 
050A: 212@ = distance_between_XYZ 114@ 127@ 140@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9441 
jump @AMBULAN_7829 

:AMBULAN_9441
if 
  37@ > 3 
else_jump @AMBULAN_9510 
050A: 212@ = distance_between_XYZ 115@ 128@ 141@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9510 
jump @AMBULAN_7829 

:AMBULAN_9510
if 
  37@ > 4 
else_jump @AMBULAN_9579 
050A: 212@ = distance_between_XYZ 116@ 129@ 142@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9579 
jump @AMBULAN_7829 

:AMBULAN_9579
if 
  37@ > 5 
else_jump @AMBULAN_9648 
050A: 212@ = distance_between_XYZ 117@ 130@ 143@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9648 
jump @AMBULAN_7829 

:AMBULAN_9648
if 
  37@ > 6 
else_jump @AMBULAN_9717 
050A: 212@ = distance_between_XYZ 118@ 131@ 144@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9717 
jump @AMBULAN_7829 

:AMBULAN_9717
if 
  37@ > 7 
else_jump @AMBULAN_9786 
050A: 212@ = distance_between_XYZ 119@ 132@ 145@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9786 
jump @AMBULAN_7829 

:AMBULAN_9786
if 
  37@ > 8 
else_jump @AMBULAN_9855 
050A: 212@ = distance_between_XYZ 120@ 133@ 146@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9855 
jump @AMBULAN_7829 

:AMBULAN_9855
if 
  37@ > 9 
else_jump @AMBULAN_9924 
050A: 212@ = distance_between_XYZ 121@ 134@ 147@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9924 
jump @AMBULAN_7829 

:AMBULAN_9924
if 
  37@ > 10 
else_jump @AMBULAN_9993 
050A: 212@ = distance_between_XYZ 122@ 135@ 148@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_9993 
jump @AMBULAN_7829 

:AMBULAN_9993
if 
  37@ > 11 
else_jump @AMBULAN_10062 
050A: 212@ = distance_between_XYZ 123@ 136@ 149@ and_XYZ 176@ 177@ 178@ 
if 
  25.0 > 212@ 
else_jump @AMBULAN_10062 
jump @AMBULAN_7829 

:AMBULAN_10062
if 
038A:   any_car_in_cube_cornerA 176@ 177@ 177@ cornerB 25.0 25.0 10.0 
else_jump @AMBULAN_10106 
jump @AMBULAN_7829 

:AMBULAN_10106
if 
  1186.0 > 176@ 
else_jump @AMBULAN_10197 
if 
  176@ > 1047.0 
else_jump @AMBULAN_10197 
if 
  -1406.0 > 177@ 
else_jump @AMBULAN_10197 
if 
  177@ > -1567.0 
else_jump @AMBULAN_10197 
jump @AMBULAN_7829 

:AMBULAN_10197
if 
  1444.0 > 176@ 
else_jump @AMBULAN_10288 
if 
  176@ > 1339.0 
else_jump @AMBULAN_10288 
if 
  -1450.0 > 177@ 
else_jump @AMBULAN_10288 
if 
  177@ > -1504.0 
else_jump @AMBULAN_10288 
jump @AMBULAN_7829 

:AMBULAN_10288
if 
  2041.979 > 176@ 
else_jump @AMBULAN_10379 
if 
  176@ > 1999.387 
else_jump @AMBULAN_10379 
if 
  -1408.708 > 177@ 
else_jump @AMBULAN_10379 
if 
  177@ > -1445.462 
else_jump @AMBULAN_10379 
jump @AMBULAN_7829 

:AMBULAN_10379
if 
  1202.0 > 176@ 
else_jump @AMBULAN_10470 
if 
  176@ > 1162.0 
else_jump @AMBULAN_10470 
if 
  -1238.0 > 177@ 
else_jump @AMBULAN_10470 
if 
  177@ > -1250.0 
else_jump @AMBULAN_10470 
jump @AMBULAN_7829 

:AMBULAN_10470
if 
  1176.0 > 176@ 
else_jump @AMBULAN_10561 
if 
  176@ > 1158.0 
else_jump @AMBULAN_10561 
if 
  1364.0 > 177@ 
else_jump @AMBULAN_10561 
if 
  177@ > 1345.0 
else_jump @AMBULAN_10561 
jump @AMBULAN_7829 

:AMBULAN_10561
if 
  -2307.0 > 176@ 
else_jump @AMBULAN_10652 
if 
  176@ > -2333.0 
else_jump @AMBULAN_10652 
if 
  1100.0 > 177@ 
else_jump @AMBULAN_10652 
if 
  177@ > 1036.0 
else_jump @AMBULAN_10652 
jump @AMBULAN_7829 

:AMBULAN_10652
if 
  2009.0 > 176@ 
else_jump @AMBULAN_10743 
if 
  176@ > 1989.0 
else_jump @AMBULAN_10743 
if 
  1571.0 > 177@ 
else_jump @AMBULAN_10743 
if 
  177@ > 1513.0 
else_jump @AMBULAN_10743 
jump @AMBULAN_7829 

:AMBULAN_10743
if 
  2632.818 > 176@ 
else_jump @AMBULAN_10834 
if 
  176@ > 2546.463 
else_jump @AMBULAN_10834 
if 
  -1129.673 > 177@ 
else_jump @AMBULAN_10834 
if 
  177@ > -1144.012 
else_jump @AMBULAN_10834 
jump @AMBULAN_7829 

:AMBULAN_10834
if 
  -222.5044 > 176@ 
else_jump @AMBULAN_10925 
if 
  176@ > -229.096 
else_jump @AMBULAN_10925 
if 
  1412.086 > 177@ 
else_jump @AMBULAN_10925 
if 
  177@ > 1393.817 
else_jump @AMBULAN_10925 
jump @AMBULAN_7829 

:AMBULAN_10925
238@ = 0.0 
return 

:AMBULAN_10937
if 
  2 > 37@ 
else_jump @AMBULAN_11046 
if 
0025:   185@ > 186@ 
else_jump @AMBULAN_10997 
0087: 187@ = 185@ 
0073: 187@ /= 189@ 
jump @AMBULAN_11013 

:AMBULAN_10997
0087: 187@ = 186@ 
0073: 187@ /= 189@ 

:AMBULAN_11013
187@ *= 1000.0 
0092: 35@ = float 187@ to_integer 
005E: " + _8210 + @" += 35@ 
jump @AMBULAN_11088 

:AMBULAN_11046
0087: 187@ = 186@ 
0073: 187@ /= 189@ 
187@ *= 1000.0 
0092: 35@ = float 187@ to_integer 
005E: " + _8210 + @" += 35@ 

:AMBULAN_11088
return 

:AMBULAN_11090
wait 0 
if 
  " + _8210 + @" == 0 
else_jump @AMBULAN_11142 
00BC: show_text_highpriority GXT 'A_FAIL2' time 3000 flag 1  
79@ = 1 
jump @AMBULAN_13155 

:AMBULAN_11142
0293: " + _13 + @" = get_controller_mode 
if 
00E1:   player 0 pressed_key 19 
else_jump @AMBULAN_11171 
53@ = 1 

:AMBULAN_11171
if 
  53@ == 1 
else_jump @AMBULAN_11229 
if 
80E1:   not player 0 pressed_key 19 
else_jump @AMBULAN_11229 
00BC: show_text_highpriority GXT 'A_CANC' time 3000 flag 1  
jump @AMBULAN_13155 

:AMBULAN_11229
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #AMBULAN)
else_jump @AMBULAN_11278 
00BC: show_text_highpriority GXT 'A_CANC' time 3000 flag 1  
jump @AMBULAN_13155 
jump @AMBULAN_11334 

:AMBULAN_11278
34@ = Actor.CurrentCar(" + PlayerActor + @")
if 
   not Car.Wrecked(34@)
else_jump @AMBULAN_11334 
01E9: 43@ = car 34@ num_passengers 
01EA: 42@ = car 34@ max_passengers 
008A: " + _8212 + @" = 42@ 
0066: " + _8212 + @" -= 43@ 

:AMBULAN_11334
if and
  37@ > 6 
  45@ == 2 
  51@ == 0 
else_jump @AMBULAN_11380 
45@ = 1 
51@ += 1 

:AMBULAN_11380
if and
  37@ > 9 
  45@ == 2 
  51@ == 1 
else_jump @AMBULAN_11426 
45@ = 1 
51@ += 1 

:AMBULAN_11426
if and
  37@ > 12 
  45@ == 2 
  51@ == 2 
else_jump @AMBULAN_11472 
45@ = 1 
51@ += 1 

:AMBULAN_11472
gosub @AMBULAN_5273 
if 
  52@ == 1 
else_jump @AMBULAN_11528 
0103:   actor " + PlayerActor + @" in_sphere 167@ 168@ 169@ radius 6.0 6.0 2.0 sphere 1 stopped_in_car 

:AMBULAN_11528
0871: init_jump_table 240@ total_jumps 12 default_jump 1 @AMBULAN_12808 jumps 0 @AMBULAN_11656 1 @AMBULAN_11752 2 @AMBULAN_11848 3 @AMBULAN_11944 4 @AMBULAN_12040 5 @AMBULAN_12136 6 @AMBULAN_12232 
0872: jump_table_jumps 7 @AMBULAN_12328 8 @AMBULAN_12424 9 @AMBULAN_12520 10 @AMBULAN_12616 11 @AMBULAN_12712 -1 @AMBULAN_12822 -1 @AMBULAN_12822 -1 @AMBULAN_12822 -1 @AMBULAN_12822 

:AMBULAN_11656
if 
  83@ > 0 
else_jump @AMBULAN_11738 
0085: 77@ = 81@ 
0085: 80@ = 83@ 
0085: 78@ = 82@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_11730 
jump @AMBULAN_13155 

:AMBULAN_11730
0085: 83@ = 80@ 

:AMBULAN_11738
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_11752
if 
  86@ > 0 
else_jump @AMBULAN_11834 
0085: 77@ = 84@ 
0085: 80@ = 86@ 
0085: 78@ = 85@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_11826 
jump @AMBULAN_13155 

:AMBULAN_11826
0085: 86@ = 80@ 

:AMBULAN_11834
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_11848
if 
  89@ > 0 
else_jump @AMBULAN_11930 
0085: 77@ = 87@ 
0085: 80@ = 89@ 
0085: 78@ = 88@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_11922 
jump @AMBULAN_13155 

:AMBULAN_11922
0085: 89@ = 80@ 

:AMBULAN_11930
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_11944
if 
  92@ > 0 
else_jump @AMBULAN_12026 
0085: 77@ = 90@ 
0085: 80@ = 92@ 
0085: 78@ = 91@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12018 
jump @AMBULAN_13155 

:AMBULAN_12018
0085: 92@ = 80@ 

:AMBULAN_12026
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12040
if 
  95@ > 0 
else_jump @AMBULAN_12122 
0085: 77@ = 93@ 
0085: 80@ = 95@ 
0085: 78@ = 94@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12114 
jump @AMBULAN_13155 

:AMBULAN_12114
0085: 95@ = 80@ 

:AMBULAN_12122
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12136
if 
  58@ > 0 
else_jump @AMBULAN_12218 
0085: 77@ = 56@ 
0085: 80@ = 58@ 
0085: 78@ = 57@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12210 
jump @AMBULAN_13155 

:AMBULAN_12210
0085: 58@ = 80@ 

:AMBULAN_12218
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12232
if 
  61@ > 0 
else_jump @AMBULAN_12314 
0085: 77@ = 59@ 
0085: 80@ = 61@ 
0085: 78@ = 60@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12306 
jump @AMBULAN_13155 

:AMBULAN_12306
0085: 61@ = 80@ 

:AMBULAN_12314
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12328
if 
  64@ > 0 
else_jump @AMBULAN_12410 
0085: 77@ = 62@ 
0085: 80@ = 64@ 
0085: 78@ = 63@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12402 
jump @AMBULAN_13155 

:AMBULAN_12402
0085: 64@ = 80@ 

:AMBULAN_12410
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12424
if 
  67@ > 0 
else_jump @AMBULAN_12506 
0085: 77@ = 65@ 
0085: 80@ = 67@ 
0085: 78@ = 66@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12498 
jump @AMBULAN_13155 

:AMBULAN_12498
0085: 67@ = 80@ 

:AMBULAN_12506
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12520
if 
  70@ > 0 
else_jump @AMBULAN_12602 
0085: 77@ = 68@ 
0085: 80@ = 70@ 
0085: 78@ = 69@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12594 
jump @AMBULAN_13155 

:AMBULAN_12594
0085: 70@ = 80@ 

:AMBULAN_12602
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12616
if 
  73@ > 0 
else_jump @AMBULAN_12698 
0085: 77@ = 71@ 
0085: 80@ = 73@ 
0085: 78@ = 72@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12690 
jump @AMBULAN_13155 

:AMBULAN_12690
0085: 73@ = 80@ 

:AMBULAN_12698
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12712
if 
  76@ > 0 
else_jump @AMBULAN_12794 
0085: 77@ = 74@ 
0085: 80@ = 76@ 
0085: 78@ = 75@ 
gosub @AMBULAN_13989 
if 
  79@ == 1 
else_jump @AMBULAN_12786 
jump @AMBULAN_13155 

:AMBULAN_12786
0085: 76@ = 80@ 

:AMBULAN_12794
240@ += 1 
jump @AMBULAN_12822 

:AMBULAN_12808
240@ = 0 
jump @AMBULAN_12822 

:AMBULAN_12822
if 
003B:   46@ == 37@ 
else_jump @AMBULAN_13148 
008B: 44@ = " + Paramedic_Mission_Level + @" 
006E: 44@ *= " + Paramedic_Mission_Level + @" 
44@ *= 50 
09EE: set_status_text_stay_on_screen 1 
01E3: show_text_1number_styled GXT 'REWARD' number 44@ time 6000 style 6  
005E: " + _412 + @" += 46@ 
005A: 55@ += 46@ 
37@ += 1 
46@ = 0 
36@ = 0 
Player.Money(" + PlayerChar + @") += 44@
52@ = 0 
Marker.Disable(47@)
Marker.Disable(82@)
Marker.Disable(85@)
Marker.Disable(88@)
Marker.Disable(91@)
Marker.Disable(94@)
Marker.Disable(57@)
Marker.Disable(60@)
Marker.Disable(63@)
Marker.Disable(66@)
Marker.Disable(69@)
Marker.Disable(72@)
Marker.Disable(75@)
0627: update_integer_stat 158 to " + Paramedic_Mission_Level + @" 
" + Paramedic_Mission_Level + @" += 1 
if 
  " + Paramedic_Mission_Level + @" == 13 
else_jump @AMBULAN_13141 
09EE: set_status_text_stay_on_screen 1 
01E3: show_text_1number_styled GXT 'A_COMP1' number 5000 time 5000 style 5  
Player.Money(" + PlayerChar + @") += 5000
0394: play_music 2 
if 
  " + _1487 + @" == 0 
else_jump @AMBULAN_13139 
00BB: show_text_lowpriority GXT 'A_COMP3' time 5000 flag 1  
0653: 196@ = float_stat 24 
196@ *= 1.5 
0A1F: increase_float_stat 24 by 196@ 
// NEW BONUSES:
" + Medic_Uniform_Available + @" = 1
08DD: lose_stuff_after_wasted 0
//
0595: mission_complete 
" + _1487 + @" = 1 

:AMBULAN_13139
return 

:AMBULAN_13141
jump @AMBULAN_3149 

:AMBULAN_13148
jump @AMBULAN_11090 

:AMBULAN_13155
014F: stop_timer " + _8210 + @" 
0151: remove_status_text " + Paramedic_Mission_Level + @" 
0151: remove_status_text " + _8212 + @" 
03D5: remove_text 'ALEVEL'  
if 
   not " + Paramedic_Mission_Level + @" == 13 
else_jump @AMBULAN_13234 
00BA: show_text_styled GXT 'A_FAIL1' time 5000 style 5  
01E3: show_text_1number_styled GXT 'A_SAVES' number 55@ time 6000 style 6  

:AMBULAN_13234
if 
   not " + Paramedic_Mission_Level + @" == 13 
else_jump @AMBULAN_13648 
if 
   not Actor.Dead(81@)
else_jump @AMBULAN_13285 
02A9: set_actor 81@ immune_to_nonplayer 0 
0321: AS_actor 81@ die_headshotted 
Actor.DestroyWithFade(81@)

:AMBULAN_13285
if 
   not Actor.Dead(84@)
else_jump @AMBULAN_13318 
02A9: set_actor 84@ immune_to_nonplayer 0 
0321: AS_actor 84@ die_headshotted 
Actor.DestroyWithFade(84@)

:AMBULAN_13318
if 
   not Actor.Dead(87@)
else_jump @AMBULAN_13351 
02A9: set_actor 87@ immune_to_nonplayer 0 
0321: AS_actor 87@ die_headshotted 
Actor.DestroyWithFade(87@)

:AMBULAN_13351
if 
   not Actor.Dead(90@)
else_jump @AMBULAN_13384 
02A9: set_actor 90@ immune_to_nonplayer 0 
0321: AS_actor 90@ die_headshotted 
Actor.DestroyWithFade(90@)

:AMBULAN_13384
if 
   not Actor.Dead(93@)
else_jump @AMBULAN_13417 
02A9: set_actor 93@ immune_to_nonplayer 0 
0321: AS_actor 93@ die_headshotted 
Actor.DestroyWithFade(93@)

:AMBULAN_13417
if 
   not Actor.Dead(56@)
else_jump @AMBULAN_13450 
02A9: set_actor 56@ immune_to_nonplayer 0 
0321: AS_actor 56@ die_headshotted 
Actor.DestroyWithFade(56@)

:AMBULAN_13450
if 
   not Actor.Dead(59@)
else_jump @AMBULAN_13483 
02A9: set_actor 59@ immune_to_nonplayer 0 
0321: AS_actor 59@ die_headshotted 
Actor.DestroyWithFade(59@)

:AMBULAN_13483
if 
   not Actor.Dead(62@)
else_jump @AMBULAN_13516 
02A9: set_actor 62@ immune_to_nonplayer 0 
0321: AS_actor 62@ die_headshotted 
Actor.DestroyWithFade(62@)

:AMBULAN_13516
if 
   not Actor.Dead(65@)
else_jump @AMBULAN_13549 
02A9: set_actor 65@ immune_to_nonplayer 0 
0321: AS_actor 65@ die_headshotted 
Actor.DestroyWithFade(65@)

:AMBULAN_13549
if 
   not Actor.Dead(68@)
else_jump @AMBULAN_13582 
02A9: set_actor 68@ immune_to_nonplayer 0 
0321: AS_actor 68@ die_headshotted 
Actor.DestroyWithFade(68@)

:AMBULAN_13582
if 
   not Actor.Dead(71@)
else_jump @AMBULAN_13615 
02A9: set_actor 71@ immune_to_nonplayer 0 
0321: AS_actor 71@ die_headshotted 
Actor.DestroyWithFade(71@)

:AMBULAN_13615
if 
   not Actor.Dead(74@)
else_jump @AMBULAN_13648 
02A9: set_actor 74@ immune_to_nonplayer 0 
0321: AS_actor 74@ die_headshotted 
Actor.DestroyWithFade(74@)

:AMBULAN_13648
Actor.RemoveReferences(81@)
Actor.RemoveReferences(84@)
Actor.RemoveReferences(87@)
Actor.RemoveReferences(90@)
Actor.RemoveReferences(93@)
Actor.RemoveReferences(56@)
Actor.RemoveReferences(59@)
Actor.RemoveReferences(62@)
Actor.RemoveReferences(65@)
Actor.RemoveReferences(68@)
Actor.RemoveReferences(71@)
Actor.RemoveReferences(74@)
52@ = 0 
Marker.Disable(47@)
Marker.Disable(82@)
Marker.Disable(85@)
Marker.Disable(88@)
Marker.Disable(91@)
Marker.Disable(94@)
Marker.Disable(57@)
Marker.Disable(60@)
Marker.Disable(63@)
Marker.Disable(66@)
Marker.Disable(69@)
Marker.Disable(72@)
Marker.Disable(75@)
065C: release_decision_maker 235@ 
03C7: set_sensitivity_to_crime 1.0 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
99@ = 0 

:AMBULAN_13804
if 
  10 > 99@ 
else_jump @AMBULAN_13934 
if 
  224@(99@,10i) == 1 
else_jump @AMBULAN_13871 
0746: set_acquaintance 4 of_actors_pedtype 99@ to_actors_pedtype 0 
234@ -= 1 
224@(99@,10i) = 0 

:AMBULAN_13871
if 
  214@(99@,10i) == 1 
else_jump @AMBULAN_13920 
0746: set_acquaintance 3 of_actors_pedtype 99@ to_actors_pedtype 0 
234@ -= 1 
214@(99@,10i) = 0 

:AMBULAN_13920
99@ += 1 
jump @AMBULAN_13804 

:AMBULAN_13934
" + OnMission + @" = 0 
" + ONMISSION_Paramedic + @" = 0 
mission_cleanup 
if 
  " + _1487 + @" == 1 
else_jump @AMBULAN_13987 
" + _1487 + @" = 2 
08F8: display_stat_update_box 0" );
create_thread<BACKON>();
AppendLine( @"
:AMBULAN_13987
return 

:AMBULAN_13989
if 
   Actor.Dead(77@)
else_jump @AMBULAN_14030 
00BC: show_text_highpriority GXT 'A_FAIL3' time 3000 flag 1  
79@ = 1 
return 

:AMBULAN_14030
if 
  " + _8210 + @" == 0 
else_jump @AMBULAN_14083 
0321: AS_actor 77@ die_headshotted 
Actor.DestroyWithFade(77@)
00BC: show_text_highpriority GXT 'A_FAIL2' time 3000 flag 1  
79@ = 1 
return 

:AMBULAN_14083
if 
  80@ == 3 
else_jump @AMBULAN_14251 
Actor.StorePos(77@, 179@, 180@, 181@)
40@ = Car.Health(34@)
if 
001D:   39@ > 40@ 
else_jump @AMBULAN_14251 
0085: 41@ = 39@ 
0062: 41@ -= 40@ 
41@ *= 50 
008B: 35@ = " + _8210 + @" 
0062: 35@ -= 41@ 
if 
  35@ > 10 
else_jump @AMBULAN_14207 
0066: " + _8210 + @" -= 41@ 

:AMBULAN_14207
0947: actor 77@ speak_from_audio_table 344 store_spoken_phrase_id_to 236@ 
if 
  0 > " + _8210 + @" 
else_jump @AMBULAN_14243 
" + _8210 + @" = 0 

:AMBULAN_14243
0085: 39@ = 40@ 

:AMBULAN_14251
if 
  80@ == 1 
else_jump @AMBULAN_14536 
if 
0106:   actor " + PlayerActor + @" near_actor 77@ radius 10.0 10.0 2.0 0 in_car 
else_jump @AMBULAN_14536 
01E9: 43@ = car 34@ num_passengers 
01EA: 42@ = car 34@ max_passengers 
if 
003B:   43@ == 42@ 
else_jump @AMBULAN_14388 
if 
  50@ == 0 
else_jump @AMBULAN_14374 
00BC: show_text_highpriority GXT 'A_FULL' time 5000 flag 1  

:AMBULAN_14374
50@ = 1 
jump @AMBULAN_14395 

:AMBULAN_14388
50@ = 0 

:AMBULAN_14395
39@ = Car.Health(34@)
if 
  50@ == 0 
else_jump @AMBULAN_14513 
if 
  97@ == 0 
else_jump @AMBULAN_14465 
05CA: AS_actor 77@ enter_car 34@ passenger_seat -1 time -2 
97@ = 1 
jump @AMBULAN_14506 

:AMBULAN_14465
062E: get_actor 77@ task 1482 status_store_to 98@ 
if 
04A4:   98@ == 7 
else_jump @AMBULAN_14506 
05CA: AS_actor 77@ enter_car 34@ passenger_seat -1 time -2 

:AMBULAN_14506
jump @AMBULAN_14529 

:AMBULAN_14513
00BC: show_text_highpriority GXT 'A_FULL' time 5000 flag 1  

:AMBULAN_14529
80@ = 2 

:AMBULAN_14536
if 
  80@ == 2 
else_jump @AMBULAN_14615 
if 
80F4:   not actor " + PlayerActor + @" near_actor 77@ radius 20.0 20.0 0 in_car 
else_jump @AMBULAN_14592 
80@ = 1 

:AMBULAN_14592
if 
8449:   not actor 77@ in_a_car 
else_jump @AMBULAN_14615 
80@ = 1 

:AMBULAN_14615
if 
  80@ == 2 
else_jump @AMBULAN_14758 
if 
0449:   actor 77@ in_a_car 
else_jump @AMBULAN_14758 
97@ = 0 
Marker.Disable(78@)
if 
  52@ == 0 
else_jump @AMBULAN_14700 
018A: 47@ = create_checkpoint_at 167@ 168@ 169@ 
52@ = 1 

:AMBULAN_14700
0085: 49@ = 152@(240@,13i) 
49@ /= 1000 
01E3: show_text_1number_styled GXT 'A_TIME' number 49@ time 6000 style 6  
005E: " + _8210 + @" += 152@(240@,13i) 
80@ = 3 

:AMBULAN_14758
if 
  80@ == 3 
else_jump @AMBULAN_14843 
if 
0103:   actor " + PlayerActor + @" in_sphere 167@ 168@ 169@ radius 6.0 6.0 2.0 sphere 0 stopped_in_car 
else_jump @AMBULAN_14843 
05D3: AS_actor 77@ goto_point 173@ 174@ 175@ mode 6 time -1 ms 
80@ = 4 

:AMBULAN_14843
if 
  80@ == 4 
else_jump @AMBULAN_15074 
if 
8449:   not actor 77@ in_a_car 
else_jump @AMBULAN_15074 
05D3: AS_actor 77@ goto_point 173@ 174@ 175@ mode 6 time -1 ms 
09EE: set_status_text_stay_on_screen 1 
00BA: show_text_styled GXT 'A_PASS' time 3000 style 5  
if 
  45@ == 1 
else_jump @AMBULAN_15014 
0085: 49@ = 48@ 
49@ /= 1000 
01E3: show_text_1number_styled GXT 'A_TIME' number 49@ time 6000 style 6  
34@ = Actor.CurrentCar(" + PlayerActor + @")
54@ = Car.Health(34@)
54@ += 110 
Car.Health(34@) = 54@
005E: " + _8210 + @" += 48@ 
45@ += 1 

:AMBULAN_15014
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
46@ += 1 
0623: add 1 to_integer_stat 151 
80@ = 0 
0332: set_actor 77@ bleeding 0 
0961: set_actor 77@ keep_tasks_after_cleanup 1 
Actor.RemoveReferences(77@)

:AMBULAN_15074
return" );
            }

        }

    }

}