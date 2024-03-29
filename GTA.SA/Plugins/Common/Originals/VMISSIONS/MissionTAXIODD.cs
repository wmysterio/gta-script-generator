﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class TAXIODD : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"34@ = 0 
gosub @TAXIODD_54 
if 
wasted_or_busted 
else_jump @TAXIODD_45 
gosub @TAXIODD_18814 

:TAXIODD_45
gosub @TAXIODD_18987 
end_thread 

:TAXIODD_54
if 
  " + Mission_Taxi_Passed + @" == 0 
else_jump @TAXIODD_74 
increment_mission_attempts 

:TAXIODD_74
" + OnMission + @" = 1 
" + _411 + @" = 1 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TAXIODD_231 
if 
   Actor.DrivingTaxiVehicle(" + PlayerActor + @")
else_jump @TAXIODD_231 
37@ = Actor.MissionCar(" + PlayerActor + @")
01E9: 35@ = car 37@ num_passengers 
if 
   not 35@ == 0 
else_jump @TAXIODD_179 
00BC: show_text_highpriority GXT 'TX_FULL' time 5000 flag 1  
wait 4500 
00BE: text_clear_all 
return 

:TAXIODD_179
36@ = Car.Health(37@)
if 
8185:   not car 37@ health >= 400 
else_jump @TAXIODD_231 
00BC: show_text_highpriority GXT 'TX_ILL' time 5000 flag 1  
wait 4500 
00BE: text_clear_all 
return 

:TAXIODD_231
0084: " + _8201 + @" = " + _56 + @" 
" + _56 + @" = 1 
85@ = 0 
86@ = 0 
87@ = 0 
38@ = 0 
39@ = 0 
40@ = 0 
41@ = 0 
42@ = 0 
47@ = 0 
48@ = 0 
32@ = 0 
33@ = 0 
102@ = 0 
127@ = 0 
130@ = 0 
132@ = 0 
133@ = 0 
134@ = 0 
135@ = 0 
136@ = 0 
137@ = 0 
139@ = 0 
140@ = 0 
141@ = 0 
142@ = 0 
143@ = 0 
144@ = 0 
145@ = 0 
124@ = 0 
125@ = 0 
126@ = 0 
108@ = 0 
146@ = 0 
if 
  38@ == -99 
else_jump @TAXIODD_721 
0662: printstring ""SHOULD_NEVER_BE_IN_FAKE_ENTITY_CREATION"" 
89@ = Car.Create(#TAXI, 0.0, 0.0, 0.0)
88@ = Actor.Create(CivMale, #WMYBU, 0.0, 0.0, 0.0)
49@ = 0 

:TAXIODD_593
90@(49@,4i) = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
49@ += 1 
  49@ >= 4 
else_jump @TAXIODD_593 
96@ = Marker.CreateAboveActor(88@)
018A: 97@ = create_checkpoint_at 0.0 0.0 0.0 
49@ = 0 

:TAXIODD_676
018A: 98@(49@,3i) = create_checkpoint_at 0.0 0.0 0.0 
49@ += 1 
  49@ >= 3 
else_jump @TAXIODD_676 

:TAXIODD_721
054C: use_GXT_table 'TAXI1' 
gosub @TAXIODD_17953 
060A: create_decision_maker_type 0 store_to 101@ 
gosub @TAXIODD_17955 
if 
  34@ == 1 
else_jump @TAXIODD_778 
jump @TAXIODD_17025 

:TAXIODD_778
wait 0 
gosub @TAXIODD_16595 
gosub @TAXIODD_16949 
if or
  40@ == 1 
  41@ == 1 
else_jump @TAXIODD_828 
jump @TAXIODD_1465 

:TAXIODD_828
gosub @TAXIODD_17820 
gosub @TAXIODD_17854 
if 
   Actor.Dead(" + PlayerActor + @")
else_jump @TAXIODD_872 
124@ = 1 
jump @TAXIODD_1465 

:TAXIODD_872
if 
  38@ == 0 
else_jump @TAXIODD_930 
0662: printstring ""STAGE_SHOULD_NEVER_BE_0_IN_MAIN_LOOP"" 

:TAXIODD_930
83@ = 0 
0293: " + _13 + @" = get_controller_mode 
if 
   not " + _13 + @" == 3 
else_jump @TAXIODD_991 
if 
00E1:   player 0 pressed_key 19 
else_jump @TAXIODD_984 
83@ = 1 

:TAXIODD_984
jump @TAXIODD_1015 

:TAXIODD_991
if 
00E1:   player 0 pressed_key 14 
else_jump @TAXIODD_1015 
83@ = 1 

:TAXIODD_1015
if 
  135@ == 0 
else_jump @TAXIODD_1081 
if 
  83@ == 1 
else_jump @TAXIODD_1074 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TAXIODD_1074 
135@ = 1 

:TAXIODD_1074
jump @TAXIODD_1129 

:TAXIODD_1081
if 
  83@ == 0 
else_jump @TAXIODD_1129 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TAXIODD_1129 
124@ = 1 
jump @TAXIODD_1465 

:TAXIODD_1129
if 
   Car.Wrecked(89@)
else_jump @TAXIODD_1159 
124@ = 1 
jump @TAXIODD_1465 

:TAXIODD_1159
51@ = Car.Health(89@)
if 
  250 >= 51@ 
else_jump @TAXIODD_1287 
if 
   not Actor.Dead(88@)
else_jump @TAXIODD_1273 
if 
   Actor.InCar(88@, 89@)
else_jump @TAXIODD_1273 
00BC: show_text_highpriority GXT 'TX_FLED' time 5000 flag 1  
if 
  138@ == 0 
else_jump @TAXIODD_1273 
0947: actor 88@ speak_from_audio_table 221 store_spoken_phrase_id_to 116@ 
138@ = 1 

:TAXIODD_1273
126@ = 1 
jump @TAXIODD_1465 

:TAXIODD_1287
if 
  130@ == 1 
else_jump @TAXIODD_1344 
if 
  " + _8199 + @" == 0 
else_jump @TAXIODD_1344 
124@ = 1 
108@ = 2 
jump @TAXIODD_1465 

:TAXIODD_1344
gosub @TAXIODD_2884 
if 
  127@ == 0 
else_jump @TAXIODD_1390 
124@ = 1 
108@ = 1 
jump @TAXIODD_1465 

:TAXIODD_1390
if 
  38@ == 1 
else_jump @TAXIODD_1415 
gosub @TAXIODD_1657 

:TAXIODD_1415
if 
  38@ == 2 
else_jump @TAXIODD_1440 
gosub @TAXIODD_2277 

:TAXIODD_1440
if 
  38@ == 3 
else_jump @TAXIODD_1465 
125@ = 1 

:TAXIODD_1465
if 
  40@ == 0 
else_jump @TAXIODD_1609 
if 
  124@ == 0 
else_jump @TAXIODD_1593 
if 
  126@ == 0 
else_jump @TAXIODD_1572 
if 
  125@ == 0 
else_jump @TAXIODD_1551 
jump @TAXIODD_778 
jump @TAXIODD_1565 

:TAXIODD_1551
gosub @TAXIODD_18712 
jump @TAXIODD_778 

:TAXIODD_1565
jump @TAXIODD_1586 

:TAXIODD_1572
gosub @TAXIODD_18748 
jump @TAXIODD_778 

:TAXIODD_1586
jump @TAXIODD_1602 

:TAXIODD_1593
gosub @TAXIODD_18814 
return 

:TAXIODD_1602
jump @TAXIODD_1611 

:TAXIODD_1609
return 

:TAXIODD_1611
0662: printstring ""SHOULD_NEVER_BE_HERE_IN_END_OF_MAIN_LOOP"" 
return 

:TAXIODD_1657
if 
  39@ == 0 
else_jump @TAXIODD_1829 
128@ = 0 
129@ = 0 
138@ = 0 
139@ = 0 
145@ = 0 
107@ = 0 
Car.ToggleTaxiLight(89@) = True
if 
  144@ == 1 
else_jump @TAXIODD_1756 
39@ = 20 
jump @TAXIODD_1829 

:TAXIODD_1756
gosub @TAXIODD_3350 
if 
  133@ == 0 
else_jump @TAXIODD_1795 
39@ = 1 
jump @TAXIODD_1829 

:TAXIODD_1795
00BC: show_text_highpriority GXT 'TX_JUNK' time " + _8199 + @" flag 1  
139@ = 1 
0396: pause_timer 0 
39@ = 10 

:TAXIODD_1829
if 
  133@ == 1 
else_jump @TAXIODD_1966 
if 
  134@ == 0 
else_jump @TAXIODD_1879 
gosub @TAXIODD_3392 
jump @TAXIODD_1966 

:TAXIODD_1879
gosub @TAXIODD_3350 
if 
  133@ == 0 
else_jump @TAXIODD_1966 
gosub @TAXIODD_3392 
03D5: remove_text 'TX_JUNK'  
" + _8199 + @" += 10000 
if 
  139@ == 1 
else_jump @TAXIODD_1959 
0396: pause_timer 1 
139@ = 0 

:TAXIODD_1959
39@ = 0 

:TAXIODD_1966
if 
  39@ == 1 
else_jump @TAXIODD_2071 
gosub @TAXIODD_4416 
if 
  128@ == 1 
else_jump @TAXIODD_2071 
if 
  130@ == 0 
else_jump @TAXIODD_2060 
" + _8199 + @" = 36000 
03C3: set_timer_to " + _8199 + @" type 1 GXT 'TX_TIME' 
130@ = 1 

:TAXIODD_2060
0396: pause_timer 0 
39@ = 2 

:TAXIODD_2071
if 
  39@ == 2 
else_jump @TAXIODD_2167 
if 
   not Actor.Dead(88@)
else_jump @TAXIODD_2167 
if 
   Actor.InCar(88@, 89@)
else_jump @TAXIODD_2167 
Marker.Disable(96@)
0647: AS_actor 88@ clear_look_task 
Car.ToggleTaxiLight(89@) = False
0947: actor 88@ speak_from_audio_table 224 store_spoken_phrase_id_to 116@ 
117@ = Car.Health(89@)
39@ = 99 

:TAXIODD_2167
if 
  39@ == 10 
else_jump @TAXIODD_2185 

:TAXIODD_2185
if 
  39@ == 20 
else_jump @TAXIODD_2243 
if 
001D:   47@ > 106@ 
else_jump @TAXIODD_2243 
144@ = 0 
106@ = 0 
39@ = 0 

:TAXIODD_2243
gosub @TAXIODD_4917 
if 
  39@ == 99 
else_jump @TAXIODD_2275 
gosub @TAXIODD_17893 

:TAXIODD_2275
return 

:TAXIODD_2277
if 
  39@ == 0 
else_jump @TAXIODD_2368 
gosub @TAXIODD_7029 
0396: pause_timer 0 
131@ = 0 
102@ = 0 
136@ = 0 
if 
  143@ == 0 
else_jump @TAXIODD_2361 
0085: 105@ = 47@ 
105@ += 5000 

:TAXIODD_2361
39@ += 1 

:TAXIODD_2368
if 
   Actor.Dead(88@)
else_jump @TAXIODD_2391 
126@ = 1 

:TAXIODD_2391
if and
   not Actor.InCar(88@, 89@)
  131@ == 0 
else_jump @TAXIODD_2424 
126@ = 1 

:TAXIODD_2424
gosub @TAXIODD_3350 
if 
  133@ == 1 
else_jump @TAXIODD_2497 
if 
  134@ == 0 
else_jump @TAXIODD_2490 
00BC: show_text_highpriority GXT 'TX_REP' time 6000 flag 1  
gosub @TAXIODD_3392 

:TAXIODD_2490
jump @TAXIODD_2522 

:TAXIODD_2497
if 
  134@ == 1 
else_jump @TAXIODD_2522 
gosub @TAXIODD_3392 

:TAXIODD_2522
if 
  39@ == 1 
else_jump @TAXIODD_2639 
if 
0100:   actor 88@ in_sphere 121@ 122@ 123@ radius 4.0 4.0 4.0 sphere 1 in_car 
else_jump @TAXIODD_2639 
if and
   Actor.InCar(88@, 89@)
   Actor.InCar(" + PlayerActor + @", 89@)
else_jump @TAXIODD_2639 
Player.CanMove(" + PlayerChar + @") = False
Marker.Disable(97@)
131@ = 1 
0396: pause_timer 1 
39@ += 1 

:TAXIODD_2639
if 
  39@ == 2 
else_jump @TAXIODD_2714 
if 
01C1:   car 89@ stopped 
else_jump @TAXIODD_2714 
if 
   Actor.InCar(88@, 89@)
else_jump @TAXIODD_2700 
0622: AS_actor 88@ bail_car 89@ 

:TAXIODD_2700
gosub @TAXIODD_18204 
39@ += 1 

:TAXIODD_2714
if 
  39@ == 3 
else_jump @TAXIODD_2777 
if 
   not Actor.InCar(88@, 89@)
else_jump @TAXIODD_2777 
Actor.RemoveReferences(88@)
146@ -= 1 
Player.CanMove(" + PlayerChar + @") = True
39@ = 99 

:TAXIODD_2777
if 
  131@ == 0 
else_jump @TAXIODD_2802 
gosub @TAXIODD_6778 

:TAXIODD_2802
if 
  143@ == 0 
else_jump @TAXIODD_2857 
if 
001D:   47@ > 105@ 
else_jump @TAXIODD_2857 
03E5: show_text_box 'TX_TIP'  
143@ = 1 

:TAXIODD_2857
if 
  39@ == 99 
else_jump @TAXIODD_2882 
gosub @TAXIODD_17893 

:TAXIODD_2882
return 

:TAXIODD_2884
if 
   Actor.DrivingTaxiVehicle(" + PlayerActor + @")
else_jump @TAXIODD_2947 
if 
   not 127@ == 1 
else_jump @TAXIODD_2940 
89@ = Actor.MissionCar(" + PlayerActor + @")
127@ = 1 
gosub @TAXIODD_2956 

:TAXIODD_2940
jump @TAXIODD_2954 

:TAXIODD_2947
127@ = 0 

:TAXIODD_2954
return 

:TAXIODD_2956
51@ = 0 
90@(51@,4i) = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
Object.CollisionDetection(90@(51@,4i)) = False
0750: set_object 90@(51@,4i) visibility 0 
0681: attach_object 90@(51@,4i) to_car 89@ with_offset 0.0 2.3 0.0 rotation 0.0 0.0 0.0 
51@ = 1 
90@(51@,4i) = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
Object.CollisionDetection(90@(51@,4i)) = False
0750: set_object 90@(51@,4i) visibility 0 
0681: attach_object 90@(51@,4i) to_car 89@ with_offset 0.0 -2.6 0.0 rotation 0.0 0.0 0.0 
51@ = 2 
90@(51@,4i) = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
Object.CollisionDetection(90@(51@,4i)) = False
0750: set_object 90@(51@,4i) visibility 0 
0681: attach_object 90@(51@,4i) to_car 89@ with_offset -1.0 -1.0 0.0 rotation 0.0 0.0 0.0 
51@ = 3 
90@(51@,4i) = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
Object.CollisionDetection(90@(51@,4i)) = False
0750: set_object 90@(51@,4i) visibility 0 
0681: attach_object 90@(51@,4i) to_car 89@ with_offset 1.0 -1.0 0.0 rotation 0.0 0.0 0.0 
return 

:TAXIODD_3350
if 
0185:   car 89@ health >= 400 
else_jump @TAXIODD_3383 
133@ = 0 
jump @TAXIODD_3390 

:TAXIODD_3383
133@ = 1 

:TAXIODD_3390
return 

:TAXIODD_3392
if 
  134@ == 1 
else_jump @TAXIODD_3456 
49@ = 0 

:TAXIODD_3417
Marker.Disable(98@(49@,3i))
49@ += 1 
  49@ >= 3 
else_jump @TAXIODD_3417 
134@ = 0 
return 

:TAXIODD_3456
if 
0154:   actor " + PlayerActor + @" in_zone 'LA'  
else_jump @TAXIODD_3523 
51@ = 0 
gosub @TAXIODD_3903 
51@ += 1 
gosub @TAXIODD_3960 
51@ += 1 
gosub @TAXIODD_4245 

:TAXIODD_3523
if 
0154:   actor " + PlayerActor + @" in_zone 'VE'  
else_jump @TAXIODD_3562 
51@ = 0 
gosub @TAXIODD_4131 

:TAXIODD_3562
if 
0154:   actor " + PlayerActor + @" in_zone 'SF'  
else_jump @TAXIODD_3615 
51@ = 0 
gosub @TAXIODD_4188 
51@ += 1 
gosub @TAXIODD_4302 

:TAXIODD_3615
if 
0154:   actor " + PlayerActor + @" in_zone 'RED'  
else_jump @TAXIODD_3668 
51@ = 0 
gosub @TAXIODD_4017 
51@ += 1 
gosub @TAXIODD_4245 

:TAXIODD_3668
if 
0154:   actor " + PlayerActor + @" in_zone 'FLINTC'  
else_jump @TAXIODD_3735 
51@ = 0 
gosub @TAXIODD_3960 
51@ += 1 
gosub @TAXIODD_4017 
51@ += 1 
gosub @TAXIODD_4302 

:TAXIODD_3735
if 
0154:   actor " + PlayerActor + @" in_zone 'WHET'  
else_jump @TAXIODD_3802 
51@ = 0 
gosub @TAXIODD_3960 
51@ += 1 
gosub @TAXIODD_4017 
51@ += 1 
gosub @TAXIODD_4302 

:TAXIODD_3802
if 
0154:   actor " + PlayerActor + @" in_zone 'ROBAD'  
else_jump @TAXIODD_3841 
51@ = 0 
gosub @TAXIODD_4074 

:TAXIODD_3841
if 
0154:   actor " + PlayerActor + @" in_zone 'BONE'  
else_jump @TAXIODD_3894 
51@ = 0 
gosub @TAXIODD_4074 
51@ += 1 
gosub @TAXIODD_4131 

:TAXIODD_3894
134@ = 1 
return 

:TAXIODD_3903
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_3932 
Marker.Disable(98@(51@,3i))

:TAXIODD_3932
02A8: 98@(51@,3i) = create_marker 63 at 2067.4 -1831.2 13.5 
return 

:TAXIODD_3960
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_3989 
Marker.Disable(98@(51@,3i))

:TAXIODD_3989
02A8: 98@(51@,3i) = create_marker 63 at 488.0 -1734.0 34.4 
return 

:TAXIODD_4017
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4046 
Marker.Disable(98@(51@,3i))

:TAXIODD_4046
02A8: 98@(51@,3i) = create_marker 63 at 720.016 -454.625 15.328 
return 

:TAXIODD_4074
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4103 
Marker.Disable(98@(51@,3i))

:TAXIODD_4103
02A8: 98@(51@,3i) = create_marker 63 at -1420.547 2583.945 58.031 
return 

:TAXIODD_4131
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4160 
Marker.Disable(98@(51@,3i))

:TAXIODD_4160
02A8: 98@(51@,3i) = create_marker 63 at 1966.532 2162.65 10.995 
return 

:TAXIODD_4188
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4217 
Marker.Disable(98@(51@,3i))

:TAXIODD_4217
02A8: 98@(51@,3i) = create_marker 63 at -2425.46 1020.83 49.39 
return 

:TAXIODD_4245
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4274 
Marker.Disable(98@(51@,3i))

:TAXIODD_4274
02A8: 98@(51@,3i) = create_marker 63 at 1021.8 -1018.7 30.9 
return 

:TAXIODD_4302
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4331 
Marker.Disable(98@(51@,3i))

:TAXIODD_4331
02A8: 98@(51@,3i) = create_marker 63 at -1908.9 292.3 40.0 
return 
if 
075C:   marker 98@(51@,3i) enabled 
else_jump @TAXIODD_4388 
Marker.Disable(98@(51@,3i))

:TAXIODD_4388
02A8: 98@(51@,3i) = create_marker 63 at -103.6 1112.4 18.7 
return 

:TAXIODD_4416
if 
001D:   47@ > 102@ 
else_jump @TAXIODD_4531 
if 
  136@ == 0 
else_jump @TAXIODD_4499 
00BC: show_text_highpriority GXT 'TX_NONE' time 6000 flag 1  
0085: 102@ = 47@ 
102@ += 5000 
137@ = 1 
jump @TAXIODD_4531 

:TAXIODD_4499
00BC: show_text_highpriority GXT 'TX_PKUP' time 6000 flag 1  
0085: 102@ = 47@ 
102@ += 5000 

:TAXIODD_4531
02DD: 88@ = get_random_ped_in_zone 'SAN_AND' with_pedtype_civilian 1 gang 0 criminal/prostitute 1 
if 
  88@ == -1 
else_jump @TAXIODD_4571 
return 

:TAXIODD_4571
146@ += 1 
if or
   Actor.Dead(88@)
   Actor.Driving(88@)
051A:   actor 88@ damaged_by_actor " + PlayerActor + @" 
else_jump @TAXIODD_4621 
Actor.RemoveReferences(88@)
146@ -= 1 
return 

:TAXIODD_4621
0665: get_actor 88@ model_to 94@ 
if 
003B:   94@ == 95@ 
else_jump @TAXIODD_4662 
Actor.RemoveReferences(88@)
146@ -= 1 
return 

:TAXIODD_4662
Actor.StorePos(88@, 58@, 59@, 60@)
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 58@ 59@ 60@ radius 88.0 88.0 19.0 
else_jump @TAXIODD_4732 
Actor.RemoveReferences(88@)
146@ -= 1 
return 

:TAXIODD_4732
136@ = 1 
if 
  137@ == 1 
else_jump @TAXIODD_4796 
00BC: show_text_highpriority GXT 'TX_PKUP' time 6000 flag 1  
0085: 102@ = 47@ 
102@ += 5000 
137@ = 0 

:TAXIODD_4796
0792: disembark_instantly_actor 88@ 
060B: set_actor 88@ decision_maker_to 101@ 
05BA: AS_actor 88@ move_mouth -2 ms 
145@ = 0 
gosub @TAXIODD_6172 
if 
075C:   marker 96@ enabled 
else_jump @TAXIODD_4851 
Marker.Disable(96@)

:TAXIODD_4851
96@ = Marker.CreateAboveActor(88@)
07E0: set_marker 96@ type_to 1 
Actor.StorePos(" + PlayerActor + @", 118@, 119@, 120@)
118@ += 4.0 
119@ += 4.0 
0085: 95@ = 94@ 
128@ = 1 
return 

:TAXIODD_4917
if 
  128@ == 0 
else_jump @TAXIODD_4937 
return 

:TAXIODD_4937
if 
001D:   47@ > 102@ 
else_jump @TAXIODD_4988 
00BC: show_text_highpriority GXT 'TX_PKUP' time 6000 flag 1  
0085: 102@ = 47@ 
102@ += 5000 

:TAXIODD_4988
83@ = 0 
84@ = 1 
if or
   Actor.Dead(88@)
051A:   actor 88@ damaged_by_actor " + PlayerActor + @" 
else_jump @TAXIODD_5072 
83@ = 1 
84@ = 0 
00BC: show_text_highpriority GXT 'TX_OOPS' time 6000 flag 1  
0085: 102@ = 47@ 
102@ += 5000 

:TAXIODD_5072
if 
   Car.Wrecked(89@)
else_jump @TAXIODD_5095 
83@ = 1 

:TAXIODD_5095
if 
  83@ == 0 
else_jump @TAXIODD_5139 
if 
   not Actor.InCar(" + PlayerActor + @", 89@)
else_jump @TAXIODD_5139 
83@ = 1 

:TAXIODD_5139
if 
  83@ == 0 
else_jump @TAXIODD_5185 
Actor.StorePos(" + PlayerActor + @", 58@, 59@, 60@)
Actor.StorePos(88@, 61@, 62@, 63@)

:TAXIODD_5185
if 
  83@ == 0 
else_jump @TAXIODD_5252 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 61@ 62@ 63@ radius 90.0 90.0 20.0 
else_jump @TAXIODD_5252 
83@ = 1 

:TAXIODD_5252
if 
  83@ == 1 
else_jump @TAXIODD_5399 
if 
  84@ == 1 
else_jump @TAXIODD_5295 
102@ = 0 

:TAXIODD_5295
128@ = 0 
138@ = 0 
Marker.Disable(96@)
if 
  133@ == 1 
else_jump @TAXIODD_5346 
39@ = 10 
jump @TAXIODD_5353 

:TAXIODD_5346
39@ = 1 

:TAXIODD_5353
if 
   not Actor.Dead(88@)
else_jump @TAXIODD_5381 
0647: AS_actor 88@ clear_look_task 
gosub @TAXIODD_6415 

:TAXIODD_5381
Actor.RemoveReferences(88@)
146@ -= 1 
0396: pause_timer 0 
return 

:TAXIODD_5399
if and
   Actor.InCar(" + PlayerActor + @", 89@)
0103:   actor " + PlayerActor + @" in_sphere 61@ 62@ 63@ radius 10.0 10.0 3.0 sphere 0 stopped_in_car 
else_jump @TAXIODD_5718 
if 
  129@ == 0 
else_jump @TAXIODD_5556 
gosub @TAXIODD_3350 
if 
  133@ == 1 
else_jump @TAXIODD_5515 
00BC: show_text_highpriority GXT 'TX_JUNK' time 5000 flag 1  
jump @TAXIODD_5295 

:TAXIODD_5515
gosub @TAXIODD_6415 
0085: 107@ = 47@ 
107@ += 300 
129@ = 1 
0396: pause_timer 1 
jump @TAXIODD_5709 

:TAXIODD_5556
if 
  107@ > 0 
else_jump @TAXIODD_5636 
if 
001D:   47@ > 107@ 
else_jump @TAXIODD_5636 
062E: get_actor 88@ task 2586 status_store_to 42@ 
if 
04A4:   42@ == 7 
else_jump @TAXIODD_5636 
gosub @TAXIODD_6453 
107@ = 0 

:TAXIODD_5636
if 
  107@ == 0 
else_jump @TAXIODD_5709 
if 
   not Actor.InCar(88@, 89@)
else_jump @TAXIODD_5709 
062E: get_actor 88@ task 1482 status_store_to 42@ 
if 
04A4:   42@ == 7 
else_jump @TAXIODD_5709 
gosub @TAXIODD_6453 

:TAXIODD_5709
return 
jump @TAXIODD_5831 

:TAXIODD_5718
if 
  129@ == 1 
else_jump @TAXIODD_5824 
if 
   Actor.InCar(" + PlayerActor + @", 89@)
else_jump @TAXIODD_5822 
if 
8100:   not actor " + PlayerActor + @" in_sphere 61@ 62@ 63@ radius 10.0 10.0 3.0 sphere 0 in_car 
else_jump @TAXIODD_5822 
gosub @TAXIODD_6172 
05BA: AS_actor 88@ move_mouth -2 ms 
129@ = 0 
0396: pause_timer 0 

:TAXIODD_5822
return 

:TAXIODD_5824
107@ = 0 

:TAXIODD_5831
if 
   not Actor.Driving(88@)
else_jump @TAXIODD_5893 
062E: get_actor 88@ task 1471 status_store_to 42@ 
if and
84A4:   not  42@ == 1 
84A4:   not  42@ == 0 
else_jump @TAXIODD_5893 
05BF: AS_actor 88@ look_at_actor " + PlayerActor + @" -2 ms 

:TAXIODD_5893
if 
   not Actor.Driving(88@)
else_jump @TAXIODD_6072 
062E: get_actor 88@ task 1492 status_store_to 42@ 
if and
84A4:   not  42@ == 1 
84A4:   not  42@ == 0 
else_jump @TAXIODD_6072 
050A: 82@ = distance_between_XYZ 58@ 59@ 60@ and_XYZ 118@ 119@ 120@ 
if 
  82@ > 4.0 
else_jump @TAXIODD_6072 
0087: 74@ = 58@ 
0087: 75@ = 59@ 
0087: 77@ = 61@ 
0087: 78@ = 62@ 
0087: 58@ = 74@ 
0063: 58@ -= 77@ 
0087: 59@ = 75@ 
0063: 59@ -= 78@ 
0604: get_Z_angle_for_point 58@ 59@ store_to 73@ 
05D4: AS_actor 88@ rotate_angle 73@ 

:TAXIODD_6072
if 
  145@ == 0 
else_jump @TAXIODD_6170 
if 
  129@ == 0 
else_jump @TAXIODD_6170 
050A: 82@ = distance_between_XYZ 58@ 59@ 60@ and_XYZ 61@ 62@ 63@ 
if 
  10.0 > 82@ 
else_jump @TAXIODD_6170 
0947: actor 88@ speak_from_audio_table 222 store_spoken_phrase_id_to 116@ 
145@ = 1 

:TAXIODD_6170
return 

:TAXIODD_6172
140@ = 0 
gosub @TAXIODD_6518 
141@ = 0 
gosub @TAXIODD_6648 
83@ = 0 
if 
  140@ == 1 
else_jump @TAXIODD_6271 
if 
  141@ == 1 
else_jump @TAXIODD_6257 
83@ = 0 
jump @TAXIODD_6264 

:TAXIODD_6257
83@ = 1 

:TAXIODD_6264
jump @TAXIODD_6310 

:TAXIODD_6271
if 
  141@ == 1 
else_jump @TAXIODD_6303 
83@ = 1 
jump @TAXIODD_6310 

:TAXIODD_6303
83@ = 0 

:TAXIODD_6310
if 
  83@ == 1 
else_jump @TAXIODD_6375 
0A1A: actor 88@ perform_walk_animation ""HIKER_POSE_L"" IFP ""MISC"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 -1 ms 
jump @TAXIODD_6413 

:TAXIODD_6375
0A1A: actor 88@ perform_walk_animation ""HIKER_POSE"" IFP ""MISC"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 -1 ms 

:TAXIODD_6413
return 

:TAXIODD_6415
0A1A: actor 88@ perform_walk_animation ""ROADCROSS"" IFP ""PED"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 100 ms 
return 

:TAXIODD_6453
140@ = 0 
gosub @TAXIODD_6518 
if 
  140@ == 1 
else_jump @TAXIODD_6504 
05CA: AS_actor 88@ enter_car 89@ passenger_seat 2 time -2 
jump @TAXIODD_6516 

:TAXIODD_6504
05CA: AS_actor 88@ enter_car 89@ passenger_seat 1 time -2 

:TAXIODD_6516
return 

:TAXIODD_6518
Actor.StorePos(88@, 58@, 59@, 60@)
Object.StorePos(92@, 61@, 62@, 63@)
Object.StorePos(93@, 64@, 65@, 66@)
050A: 80@ = distance_between_XYZ 58@ 59@ 60@ and_XYZ 61@ 62@ 63@ 
050A: 81@ = distance_between_XYZ 58@ 59@ 60@ and_XYZ 64@ 65@ 66@ 
if 
0025:   81@ > 80@ 
else_jump @TAXIODD_6639 
140@ = 0 
jump @TAXIODD_6646 

:TAXIODD_6639
140@ = 1 

:TAXIODD_6646
return 

:TAXIODD_6648
Actor.StorePos(88@, 58@, 59@, 60@)
Object.StorePos(90@, 61@, 62@, 63@)
Object.StorePos(91@, 64@, 65@, 66@)
050A: 80@ = distance_between_XYZ 58@ 59@ 60@ and_XYZ 61@ 62@ 63@ 
050A: 81@ = distance_between_XYZ 58@ 59@ 60@ and_XYZ 64@ 65@ 66@ 
if 
0025:   81@ > 80@ 
else_jump @TAXIODD_6769 
141@ = 1 
jump @TAXIODD_6776 

:TAXIODD_6769
141@ = 0 

:TAXIODD_6776
return 

:TAXIODD_6778
if 
  132@ == 0 
else_jump @TAXIODD_6798 
return 

:TAXIODD_6798
if 
001D:   47@ > 104@ 
else_jump @TAXIODD_6838 
0151: remove_status_text " + _8200 + @" 
132@ = 0 
" + _8200 + @" = 0 
return 

:TAXIODD_6838
51@ = Car.Health(89@)
if 
001D:   51@ > 117@ 
else_jump @TAXIODD_6880 
0085: 117@ = 51@ 
jump @TAXIODD_6939 

:TAXIODD_6880
if 
001D:   117@ > 51@ 
else_jump @TAXIODD_6939 
0085: 52@ = 117@ 
0062: 52@ -= 51@ 
0085: 117@ = 51@ 
52@ *= 180 
0062: 104@ -= 52@ 

:TAXIODD_6939
0085: 51@ = 104@ 
0062: 51@ -= 103@ 
0085: 52@ = 47@ 
0062: 52@ -= 103@ 
008A: " + _8200 + @" = 51@ 
0066: " + _8200 + @" -= 52@ 
" + _8200 + @" *= 100 
0074: " + _8200 + @" /= 51@ 
if 
  0 > " + _8200 + @" 
else_jump @TAXIODD_7027 
" + _8200 + @" = 0 

:TAXIODD_7027
return 

:TAXIODD_7029
if 
   Actor.Dead(88@)
else_jump @TAXIODD_7047 
return 

:TAXIODD_7047
0085: 112@ = 113@ 
113@ = 0 
110@ = -1 
gosub @TAXIODD_7670 
Actor.StorePos(88@, 58@, 59@, 60@)
0087: 67@ = 58@ 
0063: 67@ -= 121@ 
0087: 68@ = 59@ 
0063: 68@ -= 122@ 
0087: 70@ = 67@ 
006B: 70@ *= 67@ 
0087: 71@ = 68@ 
006B: 71@ *= 68@ 
0087: 80@ = 70@ 
005B: 80@ += 71@ 
01FB: 81@ = square_root 80@ 
0092: 111@ = float 81@ to_integer 
if 
  200 > 111@ 
else_jump @TAXIODD_7212 
jump @TAXIODD_7029 

:TAXIODD_7212
0085: 51@ = 111@ 
if 
  " + _8198 + @" == 0 
else_jump @TAXIODD_7245 
51@ *= 100 

:TAXIODD_7245
if 
  " + _8198 + @" == 1 
else_jump @TAXIODD_7270 
51@ *= 95 

:TAXIODD_7270
if 
  " + _8198 + @" == 2 
else_jump @TAXIODD_7295 
51@ *= 80 

:TAXIODD_7295
if 
  " + _8198 + @" == 3 
else_jump @TAXIODD_7320 
51@ *= 79 

:TAXIODD_7320
if 
  " + _8198 + @" == 4 
else_jump @TAXIODD_7345 
51@ *= 78 

:TAXIODD_7345
if 
  " + _8198 + @" == 5 
else_jump @TAXIODD_7370 
51@ *= 76 

:TAXIODD_7370
if and
  " + _8198 + @" > 5 
  10 >= " + _8198 + @" 
else_jump @TAXIODD_7402 
51@ *= 75 

:TAXIODD_7402
if and
  " + _8198 + @" > 10 
  20 >= " + _8198 + @" 
else_jump @TAXIODD_7434 
51@ *= 70 

:TAXIODD_7434
if and
  " + _8198 + @" > 20 
  50 >= " + _8198 + @" 
else_jump @TAXIODD_7466 
51@ *= 65 

:TAXIODD_7466
if 
  " + _8198 + @" > 50 
else_jump @TAXIODD_7491 
51@ *= 60 

:TAXIODD_7491
005E: " + _8199 + @" += 51@ 
0085: 52@ = 112@ 
52@ *= 500 
005E: " + _8199 + @" += 52@ 
005A: 51@ += 52@ 
0085: 52@ = 113@ 
52@ *= 1000 
005E: " + _8199 + @" += 52@ 
005A: 51@ += 52@ 
0085: 103@ = 47@ 
0085: 104@ = 51@ 
104@ *= 95 
104@ /= 100 
005A: 104@ += 47@ 
" + _8200 + @" = 0 
04F7: status_text " + _8200 + @" type 1 line 3 GXT 'TX_ADDS' 
132@ = 1 
if 
075C:   marker 97@ enabled 
else_jump @TAXIODD_7654 
Marker.Disable(97@)

:TAXIODD_7654
018A: 97@ = create_checkpoint_at 121@ 122@ 123@ 
return 

:TAXIODD_7670
if 
0154:   actor " + PlayerActor + @" in_zone 'LA'  
else_jump @TAXIODD_7702 
gosub @TAXIODD_8407 

:TAXIODD_7702
if 
0154:   actor " + PlayerActor + @" in_zone 'VE'  
else_jump @TAXIODD_7734 
gosub @TAXIODD_10663 

:TAXIODD_7734
if 
0154:   actor " + PlayerActor + @" in_zone 'SF'  
else_jump @TAXIODD_7766 
gosub @TAXIODD_13606 

:TAXIODD_7766
if 
0154:   actor " + PlayerActor + @" in_zone 'RED'  
else_jump @TAXIODD_7891 
0209: 51@ = random_int_in_ranges 0 2 
0871: init_jump_table 51@ total_jumps 2 default_jump 0 @TAXIODD_7891 jumps 0 @TAXIODD_7863 1 @TAXIODD_7877 -1 @TAXIODD_7891 -1 @TAXIODD_7891 -1 @TAXIODD_7891 -1 @TAXIODD_7891 -1 @TAXIODD_7891 

:TAXIODD_7863
gosub @TAXIODD_15463 
jump @TAXIODD_7891 

:TAXIODD_7877
gosub @TAXIODD_8407 
jump @TAXIODD_7891 

:TAXIODD_7891
if 
0154:   actor " + PlayerActor + @" in_zone 'FLINTC'  
else_jump @TAXIODD_8030 
0209: 51@ = random_int_in_ranges 0 3 
0871: init_jump_table 51@ total_jumps 3 default_jump 0 @TAXIODD_8030 jumps 0 @TAXIODD_7988 1 @TAXIODD_8002 2 @TAXIODD_8016 -1 @TAXIODD_8030 -1 @TAXIODD_8030 -1 @TAXIODD_8030 -1 @TAXIODD_8030 

:TAXIODD_7988
gosub @TAXIODD_15561 
jump @TAXIODD_8030 

:TAXIODD_8002
gosub @TAXIODD_8407 
jump @TAXIODD_8030 

:TAXIODD_8016
gosub @TAXIODD_13606 
jump @TAXIODD_8030 

:TAXIODD_8030
if 
0154:   actor " + PlayerActor + @" in_zone 'WHET'  
else_jump @TAXIODD_8155 
0209: 51@ = random_int_in_ranges 0 2 
0871: init_jump_table 51@ total_jumps 2 default_jump 0 @TAXIODD_8155 jumps 0 @TAXIODD_8127 1 @TAXIODD_8141 -1 @TAXIODD_8155 -1 @TAXIODD_8155 -1 @TAXIODD_8155 -1 @TAXIODD_8155 -1 @TAXIODD_8155 

:TAXIODD_8127
gosub @TAXIODD_15661 
jump @TAXIODD_8155 

:TAXIODD_8141
gosub @TAXIODD_13606 
jump @TAXIODD_8155 

:TAXIODD_8155
if 
0154:   actor " + PlayerActor + @" in_zone 'ROBAD'  
else_jump @TAXIODD_8280 
0209: 51@ = random_int_in_ranges 0 2 
0871: init_jump_table 51@ total_jumps 2 default_jump 0 @TAXIODD_8280 jumps 0 @TAXIODD_8252 1 @TAXIODD_8266 -1 @TAXIODD_8280 -1 @TAXIODD_8280 -1 @TAXIODD_8280 -1 @TAXIODD_8280 -1 @TAXIODD_8280 

:TAXIODD_8252
gosub @TAXIODD_15758 
jump @TAXIODD_8280 

:TAXIODD_8266
gosub @TAXIODD_13606 
jump @TAXIODD_8280 

:TAXIODD_8280
if 
0154:   actor " + PlayerActor + @" in_zone 'BONE'  
else_jump @TAXIODD_8405 
0209: 51@ = random_int_in_ranges 0 2 
0871: init_jump_table 51@ total_jumps 2 default_jump 0 @TAXIODD_8405 jumps 0 @TAXIODD_8377 1 @TAXIODD_8391 -1 @TAXIODD_8405 -1 @TAXIODD_8405 -1 @TAXIODD_8405 -1 @TAXIODD_8405 -1 @TAXIODD_8405 

:TAXIODD_8377
gosub @TAXIODD_16098 
jump @TAXIODD_8405 

:TAXIODD_8391
gosub @TAXIODD_10663 
jump @TAXIODD_8405 

:TAXIODD_8405
return 

:TAXIODD_8407
if 
  34@ == 1 
else_jump @TAXIODD_8447 
0085: 110@ = 148@ 
110@ += 1 
jump @TAXIODD_8456 

:TAXIODD_8447
0209: 110@ = random_int_in_ranges 1 35 

:TAXIODD_8456
0871: init_jump_table 110@ total_jumps 34 default_jump 1 @TAXIODD_10544 jumps 1 @TAXIODD_8714 2 @TAXIODD_8767 3 @TAXIODD_8820 4 @TAXIODD_8873 5 @TAXIODD_8926 6 @TAXIODD_8979 7 @TAXIODD_9032 
0872: jump_table_jumps 8 @TAXIODD_9085 9 @TAXIODD_9138 10 @TAXIODD_9191 11 @TAXIODD_9244 12 @TAXIODD_9297 13 @TAXIODD_9350 14 @TAXIODD_9403 15 @TAXIODD_9456 16 @TAXIODD_9509 
0872: jump_table_jumps 17 @TAXIODD_9562 18 @TAXIODD_9622 19 @TAXIODD_9682 20 @TAXIODD_9742 21 @TAXIODD_9795 22 @TAXIODD_9848 23 @TAXIODD_9901 24 @TAXIODD_9954 25 @TAXIODD_10007 
0872: jump_table_jumps 26 @TAXIODD_10060 27 @TAXIODD_10113 28 @TAXIODD_10166 29 @TAXIODD_10219 30 @TAXIODD_10279 31 @TAXIODD_10332 32 @TAXIODD_10385 33 @TAXIODD_10438 34 @TAXIODD_10491 

:TAXIODD_8714
00BC: show_text_highpriority GXT 'TX_LS1' time 5000 flag 1  
121@ = 2468.146 
122@ = -1736.184 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_8767
00BC: show_text_highpriority GXT 'TX_LS2' time 5000 flag 1  
121@ = 2794.0 
122@ = -1828.0 
123@ = 10.0 
jump @TAXIODD_10661 

:TAXIODD_8820
00BC: show_text_highpriority GXT 'TX_LS3' time 5000 flag 1  
121@ = 1884.193 
122@ = -1257.521 
123@ = 12.3984 
jump @TAXIODD_10661 

:TAXIODD_8873
00BC: show_text_highpriority GXT 'TX_LS4' time 5000 flag 1  
121@ = 2317.48 
122@ = -1386.604 
123@ = 22.8784 
jump @TAXIODD_10661 

:TAXIODD_8926
00BC: show_text_highpriority GXT 'TX_LS5' time 5000 flag 1  
121@ = 2237.76 
122@ = -1304.165 
123@ = 22.8488 
jump @TAXIODD_10661 

:TAXIODD_8979
00BC: show_text_highpriority GXT 'TX_LS6' time 5000 flag 1  
121@ = 2221.087 
122@ = -1137.332 
123@ = 24.625 
jump @TAXIODD_10661 

:TAXIODD_9032
00BC: show_text_highpriority GXT 'TX_LS7' time 5000 flag 1  
121@ = 2146.737 
122@ = -1179.795 
123@ = 22.8278 
jump @TAXIODD_10661 

:TAXIODD_9085
00BC: show_text_highpriority GXT 'TX_LS8' time 5000 flag 1  
121@ = 2075.558 
122@ = -1202.793 
123@ = 22.7571 
jump @TAXIODD_10661 

:TAXIODD_9138
00BC: show_text_highpriority GXT 'TX_LS9' time 5000 flag 1  
121@ = 2320.0 
122@ = -1655.0 
123@ = 14.0 
jump @TAXIODD_10661 

:TAXIODD_9191
00BC: show_text_highpriority GXT 'TX_LS10' time 5000 flag 1  
121@ = 2455.0 
122@ = -1502.0 
123@ = 24.0 
jump @TAXIODD_10661 

:TAXIODD_9244
00BC: show_text_highpriority GXT 'TX_LS11' time 5000 flag 1  
121@ = 2181.0 
122@ = -1771.0 
123@ = 13.0 
jump @TAXIODD_10661 

:TAXIODD_9297
00BC: show_text_highpriority GXT 'TX_LS12' time 5000 flag 1  
121@ = 2084.731 
122@ = -1800.86 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_9350
00BC: show_text_highpriority GXT 'TX_LS13' time 5000 flag 1  
121@ = 2078.015 
122@ = -1791.589 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_9403
00BC: show_text_highpriority GXT 'TX_LS14' time 5000 flag 1  
121@ = 2081.287 
122@ = -1779.5 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_9456
00BC: show_text_highpriority GXT 'TX_LS15' time 5000 flag 1  
121@ = 2418.542 
122@ = -2085.119 
123@ = 12.2928 
jump @TAXIODD_10661 

:TAXIODD_9509
00BC: show_text_highpriority GXT 'TX_LS16' time 5000 flag 1  
121@ = 1742.689 
122@ = -1858.697 
123@ = 12.4185 
jump @TAXIODD_10661 

:TAXIODD_9562
00BC: show_text_highpriority GXT 'TX_LS17' time 5000 flag 1  
121@ = 1668.0 
122@ = -2253.0 
123@ = 13.0 
113@ = 40 
jump @TAXIODD_10661 

:TAXIODD_9622
00BC: show_text_highpriority GXT 'TX_LS18' time 5000 flag 1  
121@ = 1432.198 
122@ = -2274.648 
123@ = 12.3906 
113@ = 30 
jump @TAXIODD_10661 

:TAXIODD_9682
00BC: show_text_highpriority GXT 'TX_LS19' time 5000 flag 1  
121@ = 1256.0 
122@ = -2028.0 
123@ = 60.0 
113@ = 30 
jump @TAXIODD_10661 

:TAXIODD_9742
00BC: show_text_highpriority GXT 'TX_LS20' time 5000 flag 1  
121@ = 1532.789 
122@ = -1675.442 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_9795
00BC: show_text_highpriority GXT 'TX_LS21' time 5000 flag 1  
121@ = 1472.35 
122@ = -1729.706 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_9848
00BC: show_text_highpriority GXT 'TX_LS22' time 5000 flag 1  
121@ = 1855.419 
122@ = -1383.273 
123@ = 12.3984 
jump @TAXIODD_10661 

:TAXIODD_9901
00BC: show_text_highpriority GXT 'TX_LS23' time 5000 flag 1  
121@ = 2025.0 
122@ = -1413.0 
123@ = 17.0 
jump @TAXIODD_10661 

:TAXIODD_9954
00BC: show_text_highpriority GXT 'TX_LS24' time 5000 flag 1  
121@ = 1361.218 
122@ = -1277.904 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_10007
00BC: show_text_highpriority GXT 'TX_LS25' time 5000 flag 1  
121@ = 1192.0 
122@ = -1324.0 
123@ = 13.0 
jump @TAXIODD_10661 

:TAXIODD_10060
00BC: show_text_highpriority GXT 'TX_LS26' time 5000 flag 1  
121@ = 1031.066 
122@ = -1329.704 
123@ = 12.3861 
jump @TAXIODD_10661 

:TAXIODD_10113
00BC: show_text_highpriority GXT 'TX_LS27' time 5000 flag 1  
121@ = 814.0 
122@ = -1330.0 
123@ = 13.0 
jump @TAXIODD_10661 

:TAXIODD_10166
00BC: show_text_highpriority GXT 'TX_LS28' time 5000 flag 1  
121@ = 667.7637 
122@ = -1265.69 
123@ = 12.4687 
jump @TAXIODD_10661 

:TAXIODD_10219
00BC: show_text_highpriority GXT 'TX_LS29' time 5000 flag 1  
121@ = 368.1992 
122@ = -2042.537 
123@ = 6.6582 
113@ = 30 
jump @TAXIODD_10661 

:TAXIODD_10279
00BC: show_text_highpriority GXT 'TX_LS30' time 5000 flag 1  
121@ = 152.5806 
122@ = -1754.831 
123@ = 3.9518 
jump @TAXIODD_10661 

:TAXIODD_10332
00BC: show_text_highpriority GXT 'TX_LS31' time 5000 flag 1  
121@ = 508.2797 
122@ = -1358.598 
123@ = 14.9532 
jump @TAXIODD_10661 

:TAXIODD_10385
00BC: show_text_highpriority GXT 'TX_LS32' time 5000 flag 1  
121@ = 1199.846 
122@ = -933.0658 
123@ = 41.7332 
jump @TAXIODD_10661 

:TAXIODD_10438
00BC: show_text_highpriority GXT 'TX_LS33' time 5000 flag 1  
121@ = 816.2869 
122@ = -1630.762 
123@ = 12.3906 
jump @TAXIODD_10661 

:TAXIODD_10491
00BC: show_text_highpriority GXT 'TX_LS34' time 5000 flag 1  
121@ = 1311.97 
122@ = -1712.289 
123@ = 12.3906 
jump @TAXIODD_10661 

:TAXIODD_10544
if 
  34@ == 1 
else_jump @TAXIODD_10569 
110@ = 0 

:TAXIODD_10569
0662: printstring ""UNKNOWN_LOS_SANTOS_TAXI_DESTINATION"" 
00BC: show_text_highpriority GXT 'TX_LS1' time 5000 flag 1  
121@ = 2468.146 
122@ = -1736.184 
123@ = 12.3828 
jump @TAXIODD_10661 

:TAXIODD_10661
return 

:TAXIODD_10663
if 
  34@ == 1 
else_jump @TAXIODD_10703 
0085: 110@ = 148@ 
110@ += 1 
jump @TAXIODD_10712 

:TAXIODD_10703
0209: 110@ = random_int_in_ranges 1 46 

:TAXIODD_10712
0871: init_jump_table 110@ total_jumps 45 default_jump 1 @TAXIODD_13485 jumps 1 @TAXIODD_11100 2 @TAXIODD_11153 3 @TAXIODD_11206 4 @TAXIODD_11259 5 @TAXIODD_11312 6 @TAXIODD_11365 7 @TAXIODD_11418 
0872: jump_table_jumps 8 @TAXIODD_11471 9 @TAXIODD_11524 10 @TAXIODD_11577 11 @TAXIODD_11630 12 @TAXIODD_11683 13 @TAXIODD_11736 14 @TAXIODD_11789 15 @TAXIODD_11842 16 @TAXIODD_11895 
0872: jump_table_jumps 17 @TAXIODD_11948 18 @TAXIODD_12001 19 @TAXIODD_12054 20 @TAXIODD_12107 21 @TAXIODD_12160 22 @TAXIODD_12213 23 @TAXIODD_12266 24 @TAXIODD_12319 25 @TAXIODD_12372 
0872: jump_table_jumps 26 @TAXIODD_12425 27 @TAXIODD_12478 28 @TAXIODD_12531 29 @TAXIODD_12584 30 @TAXIODD_12637 31 @TAXIODD_12690 32 @TAXIODD_12743 33 @TAXIODD_12796 34 @TAXIODD_12849 
0872: jump_table_jumps 35 @TAXIODD_12902 36 @TAXIODD_12955 37 @TAXIODD_13008 38 @TAXIODD_13061 39 @TAXIODD_13114 40 @TAXIODD_13167 41 @TAXIODD_13220 42 @TAXIODD_13273 43 @TAXIODD_13326 
0872: jump_table_jumps 44 @TAXIODD_13379 45 @TAXIODD_13432 -1 @TAXIODD_13604 -1 @TAXIODD_13604 -1 @TAXIODD_13604 -1 @TAXIODD_13604 -1 @TAXIODD_13604 -1 @TAXIODD_13604 -1 @TAXIODD_13604 

:TAXIODD_11100
00BC: show_text_highpriority GXT 'TX_VE1' time 5000 flag 1  
121@ = 2491.378 
122@ = 2773.608 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11153
00BC: show_text_highpriority GXT 'TX_VE2' time 5000 flag 1  
121@ = 2899.211 
122@ = 2435.624 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11206
00BC: show_text_highpriority GXT 'TX_VE3' time 5000 flag 1  
121@ = 2220.495 
122@ = 1838.497 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11259
00BC: show_text_highpriority GXT 'TX_VE4' time 5000 flag 1  
121@ = 2246.202 
122@ = 1896.591 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11312
00BC: show_text_highpriority GXT 'TX_VE5' time 5000 flag 1  
121@ = 2127.307 
122@ = 2355.785 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11365
00BC: show_text_highpriority GXT 'TX_VE6' time 5000 flag 1  
121@ = 2289.589 
122@ = 2415.939 
123@ = 9.7773 
jump @TAXIODD_13604 

:TAXIODD_11418
00BC: show_text_highpriority GXT 'TX_VE7' time 5000 flag 1  
121@ = 2636.223 
122@ = 2344.803 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11471
00BC: show_text_highpriority GXT 'TX_VE8' time 5000 flag 1  
121@ = 1439.0 
122@ = 754.0 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_11524
00BC: show_text_highpriority GXT 'TX_VE9' time 5000 flag 1  
121@ = 1095.619 
122@ = 1375.292 
123@ = 9.7977 
jump @TAXIODD_13604 

:TAXIODD_11577
00BC: show_text_highpriority GXT 'TX_VE10' time 5000 flag 1  
121@ = 1162.077 
122@ = 1124.441 
123@ = 9.8125 
jump @TAXIODD_13604 

:TAXIODD_11630
00BC: show_text_highpriority GXT 'TX_VE11' time 5000 flag 1  
121@ = 1710.624 
122@ = 1448.153 
123@ = 9.6643 
jump @TAXIODD_13604 

:TAXIODD_11683
00BC: show_text_highpriority GXT 'TX_VE12' time 5000 flag 1  
121@ = 2490.384 
122@ = 2771.702 
123@ = 9.7964 
jump @TAXIODD_13604 

:TAXIODD_11736
00BC: show_text_highpriority GXT 'TX_VE13' time 5000 flag 1  
121@ = 1465.187 
122@ = 2773.965 
123@ = 9.6875 
jump @TAXIODD_13604 

:TAXIODD_11789
00BC: show_text_highpriority GXT 'TX_VE14' time 5000 flag 1  
121@ = 1436.145 
122@ = 2670.385 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_11842
00BC: show_text_highpriority GXT 'TX_VE15' time 5000 flag 1  
121@ = 1486.472 
122@ = 2257.945 
123@ = 9.8128 
jump @TAXIODD_13604 

:TAXIODD_11895
00BC: show_text_highpriority GXT 'TX_VE16' time 5000 flag 1  
121@ = 1694.188 
122@ = 2200.378 
123@ = 9.8203 
jump @TAXIODD_13604 

:TAXIODD_11948
00BC: show_text_highpriority GXT 'TX_VE17' time 5000 flag 1  
121@ = 1744.656 
122@ = 2055.81 
123@ = 9.7309 
jump @TAXIODD_13604 

:TAXIODD_12001
00BC: show_text_highpriority GXT 'TX_VE18' time 5000 flag 1  
121@ = 1840.554 
122@ = 2169.654 
123@ = 9.801 
jump @TAXIODD_13604 

:TAXIODD_12054
00BC: show_text_highpriority GXT 'TX_VE19' time 5000 flag 1  
121@ = 1928.357 
122@ = 2434.31 
123@ = 9.813 
jump @TAXIODD_13604 

:TAXIODD_12107
00BC: show_text_highpriority GXT 'TX_VE20' time 5000 flag 1  
121@ = 2424.123 
122@ = 2315.745 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12160
00BC: show_text_highpriority GXT 'TX_VE21' time 5000 flag 1  
121@ = 2431.154 
122@ = 2375.061 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12213
00BC: show_text_highpriority GXT 'TX_VE22' time 5000 flag 1  
121@ = 2370.298 
122@ = 2467.925 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12266
00BC: show_text_highpriority GXT 'TX_VE23' time 5000 flag 1  
121@ = 2272.043 
122@ = 2286.755 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12319
00BC: show_text_highpriority GXT 'TX_VE24' time 5000 flag 1  
121@ = 2324.513 
122@ = 2155.099 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12372
00BC: show_text_highpriority GXT 'TX_VE25' time 5000 flag 1  
121@ = 2508.472 
122@ = 2131.205 
123@ = 9.8125 
jump @TAXIODD_13604 

:TAXIODD_12425
00BC: show_text_highpriority GXT 'TX_VE26' time 5000 flag 1  
121@ = 2530.914 
122@ = 2083.355 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12478
00BC: show_text_highpriority GXT 'TX_VE27' time 5000 flag 1  
121@ = 2546.51 
122@ = 1968.607 
123@ = 9.8125 
jump @TAXIODD_13604 

:TAXIODD_12531
00BC: show_text_highpriority GXT 'TX_VE28' time 5000 flag 1  
121@ = 2530.781 
122@ = 1821.228 
123@ = 9.8129 
jump @TAXIODD_13604 

:TAXIODD_12584
00BC: show_text_highpriority GXT 'TX_VE29' time 5000 flag 1  
121@ = 2360.313 
122@ = 2071.996 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12637
00BC: show_text_highpriority GXT 'TX_VE30' time 5000 flag 1  
121@ = 2035.457 
122@ = 1912.279 
123@ = 11.1768 
jump @TAXIODD_13604 

:TAXIODD_12690
00BC: show_text_highpriority GXT 'TX_VE31' time 5000 flag 1  
121@ = 2078.414 
122@ = 2041.116 
123@ = 9.8203 
jump @TAXIODD_13604 

:TAXIODD_12743
00BC: show_text_highpriority GXT 'TX_VE32' time 5000 flag 1  
121@ = 2159.09 
122@ = 1678.112 
123@ = 9.6953 
jump @TAXIODD_13604 

:TAXIODD_12796
00BC: show_text_highpriority GXT 'TX_VE33' time 5000 flag 1  
121@ = 2028.496 
122@ = 1711.744 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12849
00BC: show_text_highpriority GXT 'TX_VE34' time 5000 flag 1  
121@ = 2076.406 
122@ = 1519.038 
123@ = 9.6875 
jump @TAXIODD_13604 

:TAXIODD_12902
00BC: show_text_highpriority GXT 'TX_VE35' time 5000 flag 1  
121@ = 2040.251 
122@ = 1342.891 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_12955
00BC: show_text_highpriority GXT 'TX_VE36' time 5000 flag 1  
121@ = 2230.47 
122@ = 1284.891 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_13008
00BC: show_text_highpriority GXT 'TX_VE37' time 5000 flag 1  
121@ = 2074.51 
122@ = 1162.833 
123@ = 9.6875 
jump @TAXIODD_13604 

:TAXIODD_13061
00BC: show_text_highpriority GXT 'TX_VE38' time 5000 flag 1  
121@ = 2039.257 
122@ = 1174.172 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_13114
00BC: show_text_highpriority GXT 'TX_VE39' time 5000 flag 1  
121@ = 2040.284 
122@ = 1005.619 
123@ = 9.6645 
jump @TAXIODD_13604 

:TAXIODD_13167
00BC: show_text_highpriority GXT 'TX_VE40' time 5000 flag 1  
121@ = 1608.522 
122@ = 1827.752 
123@ = 9.8281 
jump @TAXIODD_13604 

:TAXIODD_13220
00BC: show_text_highpriority GXT 'TX_VE41' time 5000 flag 1  
121@ = 2483.514 
122@ = 922.5383 
123@ = 9.8203 
jump @TAXIODD_13604 

:TAXIODD_13273
00BC: show_text_highpriority GXT 'TX_VE42' time 5000 flag 1  
121@ = 2544.668 
122@ = 1016.168 
123@ = 9.7593 
jump @TAXIODD_13604 

:TAXIODD_13326
00BC: show_text_highpriority GXT 'TX_VE43' time 5000 flag 1  
121@ = 2491.765 
122@ = 1533.687 
123@ = 9.6875 
jump @TAXIODD_13604 

:TAXIODD_13379
00BC: show_text_highpriority GXT 'TX_VE44' time 5000 flag 1  
121@ = 2828.649 
122@ = 1292.268 
123@ = 9.8281 
jump @TAXIODD_13604 

:TAXIODD_13432
00BC: show_text_highpriority GXT 'TX_VE45' time 5000 flag 1  
121@ = 2524.493 
122@ = 2297.584 
123@ = 9.6797 
jump @TAXIODD_13604 

:TAXIODD_13485
if 
  34@ == 1 
else_jump @TAXIODD_13510 
110@ = 0 

:TAXIODD_13510
0662: printstring ""UNKNOWN_LAS_VENTURAS_TAXI_DESTINATION"" 
00BC: show_text_highpriority GXT 'TX_VE1' time 5000 flag 1  
121@ = 2491.378 
122@ = 2773.608 
123@ = 9.764 
jump @TAXIODD_13604 

:TAXIODD_13604
return 

:TAXIODD_13606
if 
  34@ == 1 
else_jump @TAXIODD_13646 
0085: 110@ = 148@ 
110@ += 1 
jump @TAXIODD_13655 

:TAXIODD_13646
0209: 110@ = random_int_in_ranges 1 28 

:TAXIODD_13655
0871: init_jump_table 110@ total_jumps 27 default_jump 1 @TAXIODD_15344 jumps 1 @TAXIODD_13913 2 @TAXIODD_13966 3 @TAXIODD_14019 4 @TAXIODD_14072 5 @TAXIODD_14125 6 @TAXIODD_14178 7 @TAXIODD_14231 
0872: jump_table_jumps 8 @TAXIODD_14284 9 @TAXIODD_14337 10 @TAXIODD_14390 11 @TAXIODD_14443 12 @TAXIODD_14496 13 @TAXIODD_14549 14 @TAXIODD_14602 15 @TAXIODD_14655 16 @TAXIODD_14708 
0872: jump_table_jumps 17 @TAXIODD_14761 18 @TAXIODD_14814 19 @TAXIODD_14867 20 @TAXIODD_14920 21 @TAXIODD_14973 22 @TAXIODD_15026 23 @TAXIODD_15079 24 @TAXIODD_15132 25 @TAXIODD_15185 
0872: jump_table_jumps 26 @TAXIODD_15238 27 @TAXIODD_15291 -1 @TAXIODD_15461 -1 @TAXIODD_15461 -1 @TAXIODD_15461 -1 @TAXIODD_15461 -1 @TAXIODD_15461 -1 @TAXIODD_15461 -1 @TAXIODD_15461 

:TAXIODD_13913
00BC: show_text_highpriority GXT 'TX_SF1' time 5000 flag 1  
121@ = -1974.876 
122@ = 486.737 
123@ = 30.371 
jump @TAXIODD_15461 

:TAXIODD_13966
00BC: show_text_highpriority GXT 'TX_SF2' time 5000 flag 1  
121@ = -2044.419 
122@ = 500.771 
123@ = 35.176 
jump @TAXIODD_15461 

:TAXIODD_14019
00BC: show_text_highpriority GXT 'TX_SF3' time 5000 flag 1  
121@ = -2150.581 
122@ = 251.624 
123@ = 35.176 
jump @TAXIODD_15461 

:TAXIODD_14072
00BC: show_text_highpriority GXT 'TX_SF4' time 5000 flag 1  
121@ = -1988.513 
122@ = 138.31 
123@ = 27.857 
jump @TAXIODD_15461 

:TAXIODD_14125
00BC: show_text_highpriority GXT 'TX_SF5' time 5000 flag 1  
121@ = -2216.399 
122@ = -297.305 
123@ = 35.202 
jump @TAXIODD_15461 

:TAXIODD_14178
00BC: show_text_highpriority GXT 'TX_SF6' time 5000 flag 1  
121@ = -2726.428 
122@ = -310.5865 
123@ = 6.0313 
jump @TAXIODD_15461 

:TAXIODD_14231
00BC: show_text_highpriority GXT 'TX_SF7' time 5000 flag 1  
121@ = -2704.649 
122@ = -3.5644 
123@ = 3.1953 
jump @TAXIODD_15461 

:TAXIODD_14284
00BC: show_text_highpriority GXT 'TX_SF8' time 5000 flag 1  
121@ = -2708.997 
122@ = 127.501 
123@ = 4.584 
jump @TAXIODD_15461 

:TAXIODD_14337
00BC: show_text_highpriority GXT 'TX_SF9' time 5000 flag 1  
121@ = -2751.905 
122@ = 376.781 
123@ = 4.584 
jump @TAXIODD_15461 

:TAXIODD_14390
00BC: show_text_highpriority GXT 'TX_SF10' time 5000 flag 1  
121@ = -2415.75 
122@ = 330.9614 
123@ = 33.9765 
jump @TAXIODD_15461 

:TAXIODD_14443
00BC: show_text_highpriority GXT 'TX_SF11' time 5000 flag 1  
121@ = -2454.926 
122@ = 138.9312 
123@ = 33.9765 
jump @TAXIODD_15461 

:TAXIODD_14496
00BC: show_text_highpriority GXT 'TX_SF12' time 5000 flag 1  
121@ = -2499.214 
122@ = -16.6149 
123@ = 24.6094 
jump @TAXIODD_15461 

:TAXIODD_14549
00BC: show_text_highpriority GXT 'TX_SF13' time 5000 flag 1  
121@ = -2431.735 
122@ = -198.9205 
123@ = 34.1563 
jump @TAXIODD_15461 

:TAXIODD_14602
00BC: show_text_highpriority GXT 'TX_SF14' time 5000 flag 1  
121@ = -1815.151 
122@ = 597.754 
123@ = 38.528 
jump @TAXIODD_15461 

:TAXIODD_14655
00BC: show_text_highpriority GXT 'TX_SF15' time 5000 flag 1  
121@ = -1530.776 
122@ = 487.201 
123@ = 9.44 
jump @TAXIODD_15461 

:TAXIODD_14708
00BC: show_text_highpriority GXT 'TX_SF16' time 5000 flag 1  
121@ = -1745.08 
122@ = 27.759 
123@ = 5.452 
jump @TAXIODD_15461 

:TAXIODD_14761
00BC: show_text_highpriority GXT 'TX_SF17' time 5000 flag 1  
121@ = -1414.557 
122@ = -301.347 
123@ = 14.637 
jump @TAXIODD_15461 

:TAXIODD_14814
00BC: show_text_highpriority GXT 'TX_SF18' time 5000 flag 1  
121@ = -2618.467 
122@ = 1432.752 
123@ = 6.1016 
jump @TAXIODD_15461 

:TAXIODD_14867
00BC: show_text_highpriority GXT 'TX_SF19' time 5000 flag 1  
121@ = -1904.765 
122@ = 882.7293 
123@ = 34.0156 
jump @TAXIODD_15461 

:TAXIODD_14920
00BC: show_text_highpriority GXT 'TX_SF20' time 5000 flag 1  
121@ = -2134.729 
122@ = 919.0828 
123@ = 78.8438 
jump @TAXIODD_15461 

:TAXIODD_14973
00BC: show_text_highpriority GXT 'TX_SF21' time 5000 flag 1  
121@ = -2361.836 
122@ = 993.0967 
123@ = 49.6875 
jump @TAXIODD_15461 

:TAXIODD_15026
00BC: show_text_highpriority GXT 'TX_SF22' time 5000 flag 1  
121@ = -2753.69 
122@ = 779.9389 
123@ = 53.2422 
jump @TAXIODD_15461 

:TAXIODD_15079
00BC: show_text_highpriority GXT 'TX_SF23' time 5000 flag 1  
121@ = -1714.717 
122@ = 1332.564 
123@ = 6.0391 
jump @TAXIODD_15461 

:TAXIODD_15132
00BC: show_text_highpriority GXT 'TX_SF24' time 5000 flag 1  
121@ = -2251.033 
122@ = 717.7971 
123@ = 48.2969 
jump @TAXIODD_15461 

:TAXIODD_15185
00BC: show_text_highpriority GXT 'TX_SF25' time 5000 flag 1  
121@ = -1807.813 
122@ = 936.0701 
123@ = 23.75 
jump @TAXIODD_15461 

:TAXIODD_15238
00BC: show_text_highpriority GXT 'TX_SF26' time 5000 flag 1  
121@ = -1969.205 
122@ = 1115.312 
123@ = 52.6942 
jump @TAXIODD_15461 

:TAXIODD_15291
00BC: show_text_highpriority GXT 'TX_SF27' time 5000 flag 1  
121@ = -2540.593 
122@ = 1222.188 
123@ = 36.4283 
jump @TAXIODD_15461 

:TAXIODD_15344
if 
  34@ == 1 
else_jump @TAXIODD_15369 
110@ = 0 

:TAXIODD_15369
0662: printstring ""UNKNOWN_SAN_FIERRO_TAXI_DESTINATION"" 
00BC: show_text_highpriority GXT 'TX_SF1' time 5000 flag 1  
121@ = -1974.876 
122@ = 486.737 
123@ = 30.371 
jump @TAXIODD_15461 

:TAXIODD_15461
return 

:TAXIODD_15463
0662: printstring ""NO_RED_COUNTY_DESTINATIONS_YET"" 
if 
  34@ == 1 
else_jump @TAXIODD_15529 
110@ = 0 
jump @TAXIODD_15559 

:TAXIODD_15529
0662: printstring ""CHOOSING_LOS_SANTOS"" 
gosub @TAXIODD_8407 

:TAXIODD_15559
return 

:TAXIODD_15561
0662: printstring ""NO_FLINT_COUNTY_DESTINATIONS_YET"" 
if 
  34@ == 1 
else_jump @TAXIODD_15629 
110@ = 0 
jump @TAXIODD_15659 

:TAXIODD_15629
0662: printstring ""CHOOSING_SAN_FIERRO"" 
gosub @TAXIODD_13606 

:TAXIODD_15659
return 

:TAXIODD_15661
0662: printstring ""NO_WHETSTONE_DESTINATIONS_YET"" 
if 
  34@ == 1 
else_jump @TAXIODD_15726 
110@ = 0 
jump @TAXIODD_15756 

:TAXIODD_15726
0662: printstring ""CHOOSING_SAN_FIERRO"" 
gosub @TAXIODD_13606 

:TAXIODD_15756
return 

:TAXIODD_15758
if 
  34@ == 1 
else_jump @TAXIODD_15798 
0085: 110@ = 148@ 
110@ += 1 
jump @TAXIODD_15807 

:TAXIODD_15798
0209: 110@ = random_int_in_ranges 1 3 

:TAXIODD_15807
0871: init_jump_table 110@ total_jumps 2 default_jump 1 @TAXIODD_15976 jumps 1 @TAXIODD_15870 2 @TAXIODD_15923 -1 @TAXIODD_16096 -1 @TAXIODD_16096 -1 @TAXIODD_16096 -1 @TAXIODD_16096 -1 @TAXIODD_16096 

:TAXIODD_15870
00BC: show_text_highpriority GXT 'TX_TR1' time 5000 flag 1  
121@ = -1934.078 
122@ = 2382.762 
123@ = 48.5 
jump @TAXIODD_16096 

:TAXIODD_15923
00BC: show_text_highpriority GXT 'TX_TR2' time 5000 flag 1  
121@ = -846.9434 
122@ = 1528.154 
123@ = 20.551 
jump @TAXIODD_16096 

:TAXIODD_15976
if 
  34@ == 1 
else_jump @TAXIODD_16001 
110@ = 0 

:TAXIODD_16001
0662: printstring ""UNKNOWN_TIERRA_ROBADA_TAXI_DESTINATION"" 
00BC: show_text_highpriority GXT 'TX_TR1' time 5000 flag 1  
121@ = -1934.078 
122@ = 2382.762 
123@ = 48.5 
jump @TAXIODD_16096 

:TAXIODD_16096
return 

:TAXIODD_16098
if 
  34@ == 1 
else_jump @TAXIODD_16138 
0085: 110@ = 148@ 
110@ += 1 
jump @TAXIODD_16147 

:TAXIODD_16138
0209: 110@ = random_int_in_ranges 1 6 

:TAXIODD_16147
0871: init_jump_table 110@ total_jumps 5 default_jump 1 @TAXIODD_16475 jumps 1 @TAXIODD_16210 2 @TAXIODD_16263 3 @TAXIODD_16316 4 @TAXIODD_16369 5 @TAXIODD_16422 -1 @TAXIODD_16593 -1 @TAXIODD_16593 

:TAXIODD_16210
00BC: show_text_highpriority GXT 'TX_BC1' time 5000 flag 1  
121@ = 689.646 
122@ = 1943.252 
123@ = 4.539 
jump @TAXIODD_16593 

:TAXIODD_16263
00BC: show_text_highpriority GXT 'TX_BC2' time 5000 flag 1  
121@ = -904.3732 
122@ = 2007.643 
123@ = 59.9141 
jump @TAXIODD_16593 

:TAXIODD_16316
00BC: show_text_highpriority GXT 'TX_BC3' time 5000 flag 1  
121@ = 392.0225 
122@ = 2547.806 
123@ = 15.5568 
jump @TAXIODD_16593 

:TAXIODD_16369
00BC: show_text_highpriority GXT 'TX_BC4' time 5000 flag 1  
121@ = 832.8276 
122@ = 1705.429 
123@ = 4.8587 
jump @TAXIODD_16593 

:TAXIODD_16422
00BC: show_text_highpriority GXT 'TX_BC5' time 5000 flag 1  
121@ = -84.9834 
122@ = 1358.616 
123@ = 9.3644 
jump @TAXIODD_16593 

:TAXIODD_16475
if 
  34@ == 1 
else_jump @TAXIODD_16500 
110@ = 0 

:TAXIODD_16500
0662: printstring ""UNKNOWN_BONE_COUNTY_TAXI_DESTINATION"" 
00BC: show_text_highpriority GXT 'TX_BC1' time 5000 flag 1  
121@ = 689.646 
122@ = 1943.252 
123@ = 4.539 
jump @TAXIODD_16593 

:TAXIODD_16593
return 

:TAXIODD_16595
if 
0736:   is_keyboard_key_just_pressed 32 
else_jump @TAXIODD_16644 
48@ += 1 
if 
  48@ > 2 
else_jump @TAXIODD_16642 
48@ = 0 

:TAXIODD_16642
086A: NOP 

:TAXIODD_16644
if 
  48@ == 1 
else_jump @TAXIODD_16819 
008A: " + _8202 + @" = 38@ 
008A: " + _8203 + @" = 39@ 
008A: " + _8204 + @" = 47@ 
0084: " + _8205 + @" = " + Total_Passengers_DroppedOff + @" 
008A: " + _8206 + @" = 146@ 
" + _8207 + @" = 0 
" + _8208 + @" = 0 
" + _8209 + @" = 0 
065D: NOP " + _8202 + @" ""M_STAGE"" 
065D: NOP " + _8203 + @" ""M_GOALS"" 
065D: NOP " + _8206 + @" ""CLEANUP_TESTING"" 
065D: NOP " + _8204 + @" ""M_MISSION_TIMER"" 
065D: NOP " + _8205 + @" ""TOTAL_TAXI_PASSED"" 

:TAXIODD_16819
if 
  48@ == 2 
else_jump @TAXIODD_16837 

:TAXIODD_16837
if 
0736:   is_keyboard_key_just_pressed 98 
else_jump @TAXIODD_16859 
40@ = 1 

:TAXIODD_16859
if 
0736:   is_keyboard_key_just_pressed 80 
else_jump @TAXIODD_16947 
if 
  41@ == 0 
else_jump @TAXIODD_16922 
41@ = 1 
0662: printstring ""LEVEL_PAUSED"" 
jump @TAXIODD_16947 

:TAXIODD_16922
41@ = 0 
0662: printstring ""LEVEL_UNPAUSED"" 

:TAXIODD_16947
return 

:TAXIODD_16949
if 
8736:   not is_keyboard_key_just_pressed 74 
else_jump @TAXIODD_16966 
return 

:TAXIODD_16966
if 
  38@ == 2 
else_jump @TAXIODD_17023 
0395: clear_area 0 at 121@ 122@ 123@ radius 10.0 
Actor.PutAt(" + PlayerActor + @", 121@, 122@, 123@)
39@ = 1 

:TAXIODD_17023
return 

:TAXIODD_17025
147@ = 0 
148@ = 0 

:TAXIODD_17039
110@ = 0 
0871: init_jump_table 147@ total_jumps 8 default_jump 1 @TAXIODD_17549 jumps 0 @TAXIODD_17174 1 @TAXIODD_17220 2 @TAXIODD_17268 3 @TAXIODD_17314 4 @TAXIODD_17360 5 @TAXIODD_17408 6 @TAXIODD_17453 
0872: jump_table_jumps 7 @TAXIODD_17502 -1 @TAXIODD_17556 -1 @TAXIODD_17556 -1 @TAXIODD_17556 -1 @TAXIODD_17556 -1 @TAXIODD_17556 -1 @TAXIODD_17556 -1 @TAXIODD_17556 -1 @TAXIODD_17556 

:TAXIODD_17174
gosub @TAXIODD_8407 
if 
   not 110@ == 0 
else_jump @TAXIODD_17213 
0662: printstring ""LOS_SANTOS"" 

:TAXIODD_17213
jump @TAXIODD_17556 

:TAXIODD_17220
gosub @TAXIODD_10663 
if 
   not 110@ == 0 
else_jump @TAXIODD_17261 
0662: printstring ""LAS_VENTURAS"" 

:TAXIODD_17261
jump @TAXIODD_17556 

:TAXIODD_17268
gosub @TAXIODD_13606 
if 
   not 110@ == 0 
else_jump @TAXIODD_17307 
0662: printstring ""SAN_FIERRO"" 

:TAXIODD_17307
jump @TAXIODD_17556 

:TAXIODD_17314
gosub @TAXIODD_15463 
if 
   not 110@ == 0 
else_jump @TAXIODD_17353 
0662: printstring ""RED_COUNTY"" 

:TAXIODD_17353
jump @TAXIODD_17556 

:TAXIODD_17360
gosub @TAXIODD_15561 
if 
   not 110@ == 0 
else_jump @TAXIODD_17401 
0662: printstring ""FLINT_COUNTY"" 

:TAXIODD_17401
jump @TAXIODD_17556 

:TAXIODD_17408
gosub @TAXIODD_15661 
if 
   not 110@ == 0 
else_jump @TAXIODD_17446 
0662: printstring ""WHETSTONE"" 

:TAXIODD_17446
jump @TAXIODD_17556 

:TAXIODD_17453
gosub @TAXIODD_15758 
if 
   not 110@ == 0 
else_jump @TAXIODD_17495 
0662: printstring ""TIERRA_ROBADA"" 

:TAXIODD_17495
jump @TAXIODD_17556 

:TAXIODD_17502
gosub @TAXIODD_16098 
if 
   not 110@ == 0 
else_jump @TAXIODD_17542 
0662: printstring ""BONE_COUNTY"" 

:TAXIODD_17542
jump @TAXIODD_17556 

:TAXIODD_17549
147@ = -1 

:TAXIODD_17556
if 
  110@ == 0 
else_jump @TAXIODD_17599 
wait 0 
147@ += 1 
148@ = 0 
jump @TAXIODD_17039 

:TAXIODD_17599
0663: printint ""J_A_D___ID"" 110@ 

:TAXIODD_17616
if 
8736:   not is_keyboard_key_just_pressed 74 
else_jump @TAXIODD_17700 
if 
0736:   is_keyboard_key_just_pressed 65 
else_jump @TAXIODD_17660 
147@ += 1 
jump @TAXIODD_17039 

:TAXIODD_17660
if 
0736:   is_keyboard_key_just_pressed 68 
else_jump @TAXIODD_17689 
148@ += 1 
jump @TAXIODD_17039 

:TAXIODD_17689
wait 0 
jump @TAXIODD_17616 

:TAXIODD_17700
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TAXIODD_17744 
018A: 97@ = create_checkpoint_at 121@ 122@ 123@ 
Actor.PutAt(" + PlayerActor + @", 121@, 122@, 123@)

:TAXIODD_17744
148@ += 1 
0662: printstring ""PRESS_N_FOR_NEXT_FARE"" 

:TAXIODD_17776
if 
8736:   not is_keyboard_key_just_pressed 78 
else_jump @TAXIODD_17802 
wait 0 
jump @TAXIODD_17776 

:TAXIODD_17802
Marker.Disable(97@)
wait 0 
jump @TAXIODD_17039 
return 

:TAXIODD_17820
43@ += 1 
if 
  43@ > 9 
else_jump @TAXIODD_17852 
43@ = 0 

:TAXIODD_17852
return 

:TAXIODD_17854
01BD: 44@ = current_time_in_ms 
0085: 46@ = 44@ 
0062: 46@ -= 45@ 
0085: 45@ = 44@ 
005A: 47@ += 46@ 
return 

:TAXIODD_17893
38@ += 1 
39@ = 0 
32@ = 0 
33@ = 0 
return 

:TAXIODD_17923
38@ = 1 
39@ = 0 
32@ = 0 
33@ = 0 
return 

:TAXIODD_17953
return 

:TAXIODD_17955
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TAXIODD_17982 
wait 0 
jump @TAXIODD_17955 

:TAXIODD_17982
gosub @TAXIODD_18128 
gosub @TAXIODD_18164 
if 
  " + _183 + @" == 0 
else_jump @TAXIODD_18032 
03E5: show_text_box 'TX_H1'  
" + _183 + @" = 1 

:TAXIODD_18032
gosub @TAXIODD_2884 
109@ = 0 
112@ = 0 
113@ = 0 
" + _8198 + @" = 0 
03C4: set_status_text " + _8198 + @" type 0 GXT 'TX_TOTL' 
" + _8199 + @" = 0 
114@ = 5 
115@ = 500 
94@ = -1 
95@ = -1 
gosub @TAXIODD_17893 
return 

:TAXIODD_18128
Model.Load(#CR_AMMOBOX)
038B: load_requested_models 

:TAXIODD_18135
if 
   not Model.Available(#CR_AMMOBOX)
else_jump @TAXIODD_18162 
wait 0 
jump @TAXIODD_18135 

:TAXIODD_18162
return 

:TAXIODD_18164
04ED: load_animation ""MISC"" 

:TAXIODD_18172
if 
84EE:   not animation ""MISC"" loaded 
else_jump @TAXIODD_18202 
wait 0 
jump @TAXIODD_18172 

:TAXIODD_18202
return 

:TAXIODD_18204
if 
  132@ == 1 
else_jump @TAXIODD_18244 
0085: 51@ = 111@ 
51@ /= 16 
jump @TAXIODD_18259 

:TAXIODD_18244
0085: 51@ = 111@ 
51@ /= 40 

:TAXIODD_18259
0085: 52@ = 51@ 
Player.Money(" + PlayerChar + @") += 51@
01E3: show_text_1number_styled GXT 'TX_PAY' number 51@ time 6000 style 6  
018C: play_sound 1058 at 0.0 0.0 0.0 
005A: 109@ += 51@ 
" + _8198 + @" += 1 
" + Total_Passengers_DroppedOff + @" += 1 
142@ = 0 
if 
003C:   " + _8198 + @" == 114@ 
else_jump @TAXIODD_18430 
036D: show_text_2numbers_styled GXT 'TX_SEQ' numbers " + _8198 + @" 115@ time 5000 style 5  
Player.Money(" + PlayerChar + @") += 115@
005A: 109@ += 115@ 
142@ = 1 
005A: 52@ += 115@ 
114@ += 5 
115@ += 500 

:TAXIODD_18430
if and
  " + Mission_Taxi_Passed + @" == 0 
  " + Total_Passengers_DroppedOff + @" > 49 
else_jump @TAXIODD_18534 
0595: mission_complete 
0394: play_music 2 
00BA: show_text_styled GXT 'TX_DONE' time 5000 style 5  
00BC: show_text_highpriority GXT 'TX_NTRO' time 7000 flag 1  
144@ = 1 
0085: 106@ = 47@ 
106@ += 7000 
0572: toggle_taxi_nitros 1 
" + Mission_Taxi_Passed + @" = 1 
jump @TAXIODD_18695 

:TAXIODD_18534
if 
  " + _8200 + @" > 0 
else_jump @TAXIODD_18627 
if 
  142@ == 1 
else_jump @TAXIODD_18593 
00BA: show_text_styled GXT 'TX_FAST' time 5000 style 4  
jump @TAXIODD_18609 

:TAXIODD_18593
00BA: show_text_styled GXT 'TX_FAST' time 5000 style 5  

:TAXIODD_18609
0947: actor 88@ speak_from_audio_table 226 store_spoken_phrase_id_to 116@ 
jump @TAXIODD_18695 

:TAXIODD_18627
if 
  142@ == 1 
else_jump @TAXIODD_18668 
00BA: show_text_styled GXT 'TX_WIN' time 5000 style 4  
jump @TAXIODD_18684 

:TAXIODD_18668
00BA: show_text_styled GXT 'TX_WIN' time 5000 style 5  

:TAXIODD_18684
0947: actor 88@ speak_from_audio_table 225 store_spoken_phrase_id_to 116@ 

:TAXIODD_18695
0A10: increase_integer_stat 150 by 1 
0A10: increase_integer_stat 149 by 52@ 
return 

:TAXIODD_18712
" + _8199 + @" += 10000 
0151: remove_status_text " + _8200 + @" 
132@ = 0 
125@ = 0 
gosub @TAXIODD_17923 
return 

:TAXIODD_18748
if 
   not Actor.Dead(88@)
else_jump @TAXIODD_18776 
Actor.RemoveReferences(88@)
146@ -= 1 

:TAXIODD_18776
Marker.Disable(96@)
Marker.Disable(97@)
0151: remove_status_text " + _8200 + @" 
132@ = 0 
126@ = 0 
gosub @TAXIODD_17923 
return 

:TAXIODD_18814
00BA: show_text_styled GXT 'TX_END' time 5000 style 5  
01E3: show_text_1number_styled GXT 'TX_PAY' number 109@ time 6000 style 6  
03EB: clear_small_messages_only 
0871: init_jump_table 108@ total_jumps 3 default_jump 0 @TAXIODD_18983 jumps 1 @TAXIODD_18914 2 @TAXIODD_18937 3 @TAXIODD_18960 -1 @TAXIODD_18983 -1 @TAXIODD_18983 -1 @TAXIODD_18983 -1 @TAXIODD_18983 

:TAXIODD_18914
00BC: show_text_highpriority GXT 'TX_F1' time 5000 flag 1  
jump @TAXIODD_18983 

:TAXIODD_18937
00BC: show_text_highpriority GXT 'TX_F2' time 5000 flag 1  
jump @TAXIODD_18983 

:TAXIODD_18960
00BC: show_text_highpriority GXT 'TX_F3' time 5000 flag 1  
jump @TAXIODD_18983 

:TAXIODD_18983
03E6: remove_text_box 
return 

:TAXIODD_18987
if 
   not Actor.Dead(88@)
else_jump @TAXIODD_19064 
0647: AS_actor 88@ clear_look_task 
if 
   Car.Wrecked(89@)
else_jump @TAXIODD_19038 
gosub @TAXIODD_6415 
jump @TAXIODD_19064 

:TAXIODD_19038
if 
   not Actor.InCar(88@, 89@)
else_jump @TAXIODD_19064 
gosub @TAXIODD_6415 

:TAXIODD_19064
Car.RemoveReferences(89@)
Actor.RemoveReferences(88@)
49@ = 0 

:TAXIODD_19081
Object.RemoveReferences(90@(49@,4i))
49@ += 1 
  49@ >= 4 
else_jump @TAXIODD_19081 
Marker.Disable(96@)
Marker.Disable(97@)
49@ = 0 

:TAXIODD_19128
Marker.Disable(98@(49@,3i))
49@ += 1 
  49@ >= 3 
else_jump @TAXIODD_19128 
0151: remove_status_text " + _8198 + @" 
014F: stop_timer " + _8199 + @" 
0151: remove_status_text " + _8200 + @" 
04EF: release_animation ""MISC"" 
Model.Destroy(#CR_AMMOBOX)
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
03C7: set_sensitivity_to_crime 1.0 
06D0: enable_emergency_traffic 1 
06D7: enable_train_traffic 1 
0084: " + _56 + @" = " + _8201 + @" 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + _411 + @" = 0 
" + OnMission + @" = 0 
" + ONMISSION_TAXI + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}