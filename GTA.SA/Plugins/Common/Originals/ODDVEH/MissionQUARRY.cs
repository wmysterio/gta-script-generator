using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class QUARRY : MissionCustom {

            Int tmp_Quarry_Stage = global( Quarry_Stage.startIndex ),
                tmp_8174 = global( _8174.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @QUARRY_47 
if 
wasted_or_busted 
else_jump @QUARRY_38 
gosub @QUARRY_25912 

:QUARRY_38
gosub @QUARRY_27542 
end_thread 

:QUARRY_47
if 
  " + Mission_Quarry_Passed + @" == 0 
else_jump @QUARRY_67 
increment_mission_attempts 

:QUARRY_67
" + OnMission + @" = 1 
" + _411 + @" = 1 
82@ = 0 
83@ = 0 
84@ = 0 
34@ = 0 
35@ = 0 
36@ = 0 
37@ = 0 
38@ = 0 
39@ = 0 
40@ = 0 
45@ = 0 
46@ = 0 
47@ = 0 
32@ = 0 
33@ = 0 
230@ = 0 
231@ = 0 
233@ = 0 
234@ = 0 
235@ = 0 
236@ = 0 
238@ = 0 
239@ = 0 
240@ = 0 
241@ = 0 
242@ = 0 
243@ = 0 
251@ = 0 
252@ = 0 
262@ = 0 
263@ = 0 
264@ = 0 
265@ = 0 
266@ = 0 
267@ = 0 
278@ = 0 
279@ = 0 
280@ = 0 
281@ = 0 
282@ = 0 
283@ = 0 
284@ = 0 
292@ = 0 
293@ = 0 
294@ = 0 
295@ = 0 
if 
  34@ == -99 
else_jump @QUARRY_1311 
0662: printstring ""SHOULD_NEVER_BE_IN_FAKE_ENTITY_CREATION"" 
86@ = Car.Create(#SANCHEZ, 0.0, 0.0, 0.0)
87@ = Car.Create(#DOZER, 0.0, 0.0, 0.0)
88@ = Car.Create(#DUMPER, 0.0, 0.0, 0.0)
89@ = Car.Create(#COPBIKE, 0.0, 0.0, 0.0)
91@ = Car.Create(#DUMPER, 0.0, 0.0, 0.0)
85@ = Actor.Create(CivMale, #BMYBE, 0.0, 0.0, 0.0)
92@ = Object.Create(#DEAD_TIED_COP, 0.0, 0.0, 0.0)
93@ = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
121@ = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
48@ = 0 

:QUARRY_679
94@(48@,7i) = Object.Create(#DYN_QUARRYROCK03, 0.0, 0.0, 0.0)
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_679 
48@ = 0 

:QUARRY_734
101@(48@,10i) = Object.Create(#KB_BARREL, 0.0, 0.0, 0.0)
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_734 
48@ = 0 

:QUARRY_789
111@(48@,3i) = Object.Create(#DEAD_TIED_COP, 0.0, 0.0, 0.0)
48@ += 1 
  48@ >= 3 
else_jump @QUARRY_789 
48@ = 0 

:QUARRY_844
114@(48@,7i) = Object.Create(#CM_BOX, 0.0, 0.0, 0.0)
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_844 
06D8: 90@ = create_train_at 0.0 0.0 0.0 type 11 direction 0 
48@ = 0 

:QUARRY_923
06D5: 190@(48@,7i) = create_racing_checkpoint_at 0.0 0.0 0.0 point_to 0.0 0.0 0.0 type 2 radius 0.0 
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_923 
48@ = 0 

:QUARRY_997
122@(48@,3i) = Object.Create(#CR_AMMOBOX, 0.0, 0.0, 0.0)
48@ += 1 
  48@ >= 3 
else_jump @QUARRY_997 
06D5: 197@ = create_racing_checkpoint_at 0.0 0.0 0.0 point_to 0.0 0.0 0.0 type 2 radius 0.0 
125@ = Marker.CreateAboveCar(87@)
126@ = Marker.CreateAboveCar(88@)
130@ = Marker.CreateAboveCar(89@)
141@ = Marker.CreateAboveCar(90@)
152@ = Marker.CreateAboveCar(91@)
018A: 127@ = create_checkpoint_at 0.0 0.0 0.0 
018A: 128@ = create_checkpoint_at 0.0 0.0 0.0 
018A: 131@ = create_checkpoint_at 0.0 0.0 0.0 
018A: 132@ = create_checkpoint_at 0.0 0.0 0.0 
129@ = Marker.CreateAboveObject(92@)
140@ = Marker.CreateAboveObject(101@)
48@ = 0 

:QUARRY_1230
133@(48@,7i) = Marker.CreateAboveObject(94@(48@,7i))
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_1230 
48@ = 0 

:QUARRY_1274
142@(48@,10i) = Marker.CreateAboveObject(101@(48@,10i))
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_1274 

:QUARRY_1311
054C: use_GXT_table 'QUARRY' 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @QUARRY_1424 
if 
   Player.WantedLevel(" + PlayerChar + @") > 0
else_jump @QUARRY_1424 
00BC: show_text_highpriority GXT 'VAL_C1' time 5000 flag 1  
Actor.PutAt(" + PlayerActor + @", 827.9296, 857.7913, 11.311)
Actor.Angle(" + PlayerActor + @") = 120.0
Camera.SetBehindPlayer
Player.CanMove(" + PlayerChar + @") = True
fade 1 500 
0A2D: hide_styled_text_while_fading 1 
return 

:QUARRY_1424
gosub @QUARRY_21090 

:QUARRY_1431
wait 0 
if and
   not 34@ == 18 
   not 34@ == 19 
else_jump @QUARRY_1701 
if 
0736:   is_keyboard_key_just_pressed 83 
else_jump @QUARRY_1525 
008B: 50@ = " + tmp_8174 + @"(" + Quarry_Missions_Passed + @",7i) 
50@ *= 1000 
0085: 206@ = 46@ 
0062: 206@ -= 50@ 
36@ = 1 
jump @QUARRY_2224 

:QUARRY_1525
if 
  " + Mission_Quarry_Passed + @" == 1 
else_jump @QUARRY_1701 
if 
  292@ == 1 
else_jump @QUARRY_1677 
if 
80E1:   not player 0 pressed_key 19 
else_jump @QUARRY_1670 
38@ = 1 
00BC: show_text_highpriority GXT 'QUAR_37' time 5000 flag 1  
00BA: show_text_styled GXT 'SKIPPED' time 5000 style 5  
" + Quarry_Missions_Passed + @" += 1 
if 
  " + Quarry_Missions_Passed + @" == 7 
else_jump @QUARRY_1649 
" + Quarry_Missions_Passed + @" = 0 

:QUARRY_1649
014C: set_parked_car_generator " + carPark_2759 + @" cars_to_generate_to 101 
014C: set_parked_car_generator " + carPark_2760 + @" cars_to_generate_to 101 
jump @QUARRY_2224 

:QUARRY_1670
jump @QUARRY_1701 

:QUARRY_1677
if 
00E1:   player 0 pressed_key 19 
else_jump @QUARRY_1701 
292@ = 1 

:QUARRY_1701
gosub @QUARRY_20409 
gosub @QUARRY_20898 
if or
  38@ == 1 
  39@ == 1 
else_jump @QUARRY_1747 
jump @QUARRY_2224 

:QUARRY_1747
gosub @QUARRY_20987 
gosub @QUARRY_21021 
if 
   Actor.Dead(" + PlayerActor + @")
else_jump @QUARRY_1791 
37@ = 1 
jump @QUARRY_2224 

:QUARRY_1791
if 
  34@ == 0 
else_jump @QUARRY_1849 
0662: printstring ""STAGE_SHOULD_NEVER_BE_0_IN_MAIN_LOOP"" 

:QUARRY_1849
0871: init_jump_table 34@ total_jumps 19 default_jump 0 @QUARRY_2224 jumps 1 @QUARRY_2126 2 @QUARRY_2140 3 @QUARRY_2154 4 @QUARRY_2182 5 @QUARRY_2042 6 @QUARRY_2182 7 @QUARRY_2056 
0872: jump_table_jumps 8 @QUARRY_2182 9 @QUARRY_2070 10 @QUARRY_2084 11 @QUARRY_2182 12 @QUARRY_2098 13 @QUARRY_2182 14 @QUARRY_2112 15 @QUARRY_2182 16 @QUARRY_2168 
0872: jump_table_jumps 17 @QUARRY_2182 18 @QUARRY_2196 19 @QUARRY_2210 -1 @QUARRY_2224 -1 @QUARRY_2224 -1 @QUARRY_2224 -1 @QUARRY_2224 -1 @QUARRY_2224 -1 @QUARRY_2224 

:QUARRY_2042
gosub @QUARRY_6252 
jump @QUARRY_2224 

:QUARRY_2056
gosub @QUARRY_8986 
jump @QUARRY_2224 

:QUARRY_2070
gosub @QUARRY_11447 
jump @QUARRY_2224 

:QUARRY_2084
gosub @QUARRY_11875 
jump @QUARRY_2224 

:QUARRY_2098
gosub @QUARRY_13354 
jump @QUARRY_2224 

:QUARRY_2112
gosub @QUARRY_15693 
jump @QUARRY_2224 

:QUARRY_2126
gosub @QUARRY_2425 
jump @QUARRY_2224 

:QUARRY_2140
gosub @QUARRY_3641 
jump @QUARRY_2224 

:QUARRY_2154
gosub @QUARRY_4711 
jump @QUARRY_2224 

:QUARRY_2168
gosub @QUARRY_17197 
jump @QUARRY_2224 

:QUARRY_2182
36@ = 1 
jump @QUARRY_2224 

:QUARRY_2196
gosub @QUARRY_18899 
jump @QUARRY_2224 

:QUARRY_2210
38@ = 1 
jump @QUARRY_2224 

:QUARRY_2224
if 
  38@ == 0 
else_jump @QUARRY_2377 
if 
  37@ == 0 
else_jump @QUARRY_2361 
if 
  36@ == 0 
else_jump @QUARRY_2292 
jump @QUARRY_1431 
jump @QUARRY_2354 

:QUARRY_2292
gosub @QUARRY_26382 
if 
  295@ == 1 
else_jump @QUARRY_2352 
36@ = 0 
34@ = 18 
35@ = 0 
295@ = 0 
jump @QUARRY_1431 

:QUARRY_2352
return 

:QUARRY_2354
jump @QUARRY_2370 

:QUARRY_2361
gosub @QUARRY_25912 
return 

:QUARRY_2370
jump @QUARRY_2379 

:QUARRY_2377
return 

:QUARRY_2379
0662: printstring ""SHOULD_NEVER_BE_HERE_IN_END_OF_MAIN_LOOP"" 
return 

:QUARRY_2425
if 
   Car.Wrecked(87@)
else_jump @QUARRY_2457 
37@ = 1 
45@ = 1 
return 

:QUARRY_2457
if 
   Car.Wrecked(88@)
else_jump @QUARRY_2489 
37@ = 1 
45@ = 2 
return 

:QUARRY_2489
if 
   not Car.Wrecked(89@)
else_jump @QUARRY_2513 
Car.Health(89@) = 10000

:QUARRY_2513
if 
  35@ == 0 
else_jump @QUARRY_2722 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
230@ = 0 
233@ = 0 
234@ = 0 
282@ = 0 
212@ = 672.7664 
213@ = 888.3682 
214@ = -41.3985 
00BC: show_text_highpriority GXT 'QUAR_00' time 10000 flag 1  
50@ = 7 
50@ -= 1 
0084: " + _8172 + @" = " + tmp_8174 + @"(50@,7i) 
" + _8172 + @" *= 1000 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D1' 
0085: 206@ = 46@ 
if 
   not Car.Wrecked(89@)
else_jump @QUARRY_2701 
09B0: set_car 89@ accessible_for_player_using_controller 0 

:QUARRY_2701
08A5: set_car 88@ attractive_to_magnet 0 
08A5: set_car 87@ attractive_to_magnet 0 
35@ += 1 

:QUARRY_2722
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_2756 
37@ = 1 
45@ = 4 
return 

:QUARRY_2756
if 
  35@ == 1 
else_jump @QUARRY_2819 
if 
  230@ == 1 
else_jump @QUARRY_2819 
Marker.Disable(128@)
Marker.Disable(125@)
Marker.Disable(129@)
Marker.Disable(130@)
35@ = 99 

:QUARRY_2819
if 
  230@ == 0 
else_jump @QUARRY_3030 
if 
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_2968 
if 
075C:   marker 125@ enabled 
else_jump @QUARRY_2961 
Marker.Disable(125@)
018A: 128@ = create_checkpoint_at 212@ 213@ 214@ 
03D5: remove_text 'QUAR_35'  
if 
  234@ == 0 
else_jump @QUARRY_2928 
129@ = Marker.CreateAboveObject(92@)

:QUARRY_2928
if 
  233@ == 0 
else_jump @QUARRY_2961 
130@ = Marker.CreateAboveCar(89@)
Marker.SetColor(130@, 1)

:QUARRY_2961
jump @QUARRY_3030 

:QUARRY_2968
if 
875C:   not marker 125@ enabled 
else_jump @QUARRY_3030 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
Marker.Disable(128@)
Marker.Disable(129@)
Marker.Disable(130@)
00BC: show_text_highpriority GXT 'QUAR_35' time 5000 flag 1  

:QUARRY_3030
if 
  232@ == 0 
else_jump @QUARRY_3098 
if or
   Actor.InCar(" + PlayerActor + @", 89@)
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_3098 
232@ = 1 
00BC: show_text_highpriority GXT 'QUAR_02' time 7000 flag 1  

:QUARRY_3098
if 
  230@ == 0 
else_jump @QUARRY_3614 
if 
  233@ == 0 
else_jump @QUARRY_3279 
if 
01AF:   car 89@ sphere 232@ in_sphere 212@ 213@ 214@ radius 7.0 7.0 4.0 
else_jump @QUARRY_3279 
if 
01AF:   car 89@ sphere 0 in_sphere 212@ 213@ 214@ radius 4.0 4.0 4.0 
else_jump @QUARRY_3279 
233@ = 1 
Marker.Disable(130@)
Car.LockInCurrentPosition(89@) = True
099A: set_car 89@ collision_detection 0 
if 
  234@ == 0 
else_jump @QUARRY_3279 
00BC: show_text_highpriority GXT 'QUAR_03' time 5000 flag 1  

:QUARRY_3279
if 
  234@ == 0 
else_jump @QUARRY_3559 
if 
  233@ == 1 
else_jump @QUARRY_3433 
if 
04E6:   object 92@ near_point 212@ 213@ 214@ radius 7.0 7.0 4.0 flag 232@ 
else_jump @QUARRY_3426 
if 
04E6:   object 92@ near_point 212@ 213@ 214@ radius 4.0 4.0 4.0 flag 0 
else_jump @QUARRY_3426 
234@ = 1 
Marker.Disable(129@)
Object.KeepInMemory(92@) = True
Object.CollisionDetection(92@) = False

:QUARRY_3426
jump @QUARRY_3559 

:QUARRY_3433
if 
04E6:   object 92@ near_point 212@ 213@ 214@ radius 7.0 7.0 4.0 flag 0 
else_jump @QUARRY_3559 
if 
04E6:   object 92@ near_point 212@ 213@ 214@ radius 4.0 4.0 4.0 flag 0 
else_jump @QUARRY_3559 
234@ = 1 
Marker.Disable(129@)
Object.KeepInMemory(92@) = True
Object.CollisionDetection(92@) = False
00BC: show_text_highpriority GXT 'QUAR_04' time 5000 flag 1  

:QUARRY_3559
if and
  234@ == 1 
  233@ == 1 
else_jump @QUARRY_3614 
230@ = 1 
00BC: show_text_highpriority GXT 'QUAR_05' time 5000 flag 1  
282@ = 1 

:QUARRY_3614
if 
  35@ == 99 
else_jump @QUARRY_3639 
gosub @QUARRY_21060 

:QUARRY_3639
return 

:QUARRY_3641
if 
   Car.Wrecked(87@)
else_jump @QUARRY_3673 
37@ = 1 
45@ = 1 
return 

:QUARRY_3673
if 
   Car.Wrecked(88@)
else_jump @QUARRY_3705 
37@ = 1 
45@ = 2 
return 

:QUARRY_3705
if 
   not Car.Wrecked(89@)
else_jump @QUARRY_3729 
Car.Health(89@) = 10000

:QUARRY_3729
if 
  35@ == 0 
else_jump @QUARRY_3809 
231@ = 0 
233@ = 0 
234@ = 0 
018A: 127@ = create_checkpoint_at 705.1055 916.3154 -19.6407 
07E0: set_marker 127@ type_to 1 
240@ = 1 
35@ += 1 

:QUARRY_3809
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_3843 
37@ = 1 
45@ = 4 
return 

:QUARRY_3843
if 
  35@ == 1 
else_jump @QUARRY_3898 
if 
  231@ == 1 
else_jump @QUARRY_3898 
Marker.Disable(126@)
01EC: make_car 88@ very_heavy 1 
35@ = 99 

:QUARRY_3898
if 
8685:   not object 93@ attached 
else_jump @QUARRY_3952 
0681: attach_object 93@ to_car 88@ with_offset 0.0 -1.7 1.5 rotation 0.0 0.0 0.0 

:QUARRY_3952
if 
  231@ == 0 
else_jump @QUARRY_4503 
Object.StorePos(93@, 59@, 60@, 61@)
0798: get_crane_magnet " + _2742 + @" attached_car_handle_to 53@ attached_actor_handle_to 54@ attached_object_handle_to 55@ 
if 
  234@ == 0 
else_jump @QUARRY_4143 
if 
04E6:   object 92@ near_point 59@ 60@ 61@ radius 3.2 3.2 1.5 flag 0 
else_jump @QUARRY_4136 
if 
0685:   object 92@ attached 
else_jump @QUARRY_4136 
if 
803B:   not  55@ == 92@ 
else_jump @QUARRY_4114 
234@ = 1 
0916: set_object 92@ attractive_to_magnet 0 
jump @QUARRY_4136 

:QUARRY_4114
0682: detach_object 92@ 0.0 0.0 0.0 collision_detection 0 

:QUARRY_4136
jump @QUARRY_4238 

:QUARRY_4143
if 
8685:   not object 92@ attached 
else_jump @QUARRY_4238 
Object.StorePos(92@, 59@, 60@, 61@)
02CE: 75@ = ground_z_at 59@ 60@ 61@ 
0087: 76@ = 61@ 
0063: 76@ -= 75@ 
if 
  1.5 > 76@ 
else_jump @QUARRY_4238 
234@ = 0 
0916: set_object 92@ attractive_to_magnet 1 

:QUARRY_4238
if 
  233@ == 0 
else_jump @QUARRY_4376 
if 
01B0:   car 89@ sphere 0 in_sphere 59@ 60@ 61@ radius 3.2 3.2 1.5 stopped 
else_jump @QUARRY_4369 
if 
803B:   not  53@ == 89@ 
else_jump @QUARRY_4369 
0683: attach_car 89@ to_car 88@ with_offset -1000.0 0.0 0.0 rotation 0.0 0.0 0.0 
233@ = 1 
08A5: set_car 89@ attractive_to_magnet 0 

:QUARRY_4369
jump @QUARRY_4471 

:QUARRY_4376
if 
8686:   not car 89@ attached 
else_jump @QUARRY_4471 
Car.StorePos(89@, 59@, 60@, 61@)
02CE: 75@ = ground_z_at 59@ 60@ 61@ 
0087: 76@ = 61@ 
0063: 76@ -= 75@ 
if 
  1.5 > 76@ 
else_jump @QUARRY_4471 
233@ = 0 
08A5: set_car 89@ attractive_to_magnet 1 

:QUARRY_4471
if and
  234@ == 1 
  233@ == 1 
else_jump @QUARRY_4503 
231@ = 1 

:QUARRY_4503
if 
  240@ == 1 
else_jump @QUARRY_4612 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 705.1055 916.3154 -19.6407 radius 4.0 4.0 1.2 
else_jump @QUARRY_4612 
Marker.Disable(127@)
240@ = 0 
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_06' time 7000 flag 1  

:QUARRY_4612
if 
  282@ == 1 
else_jump @QUARRY_4684 
if 
   not Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_4684 
Object.KeepInMemory(92@) = False
Object.CollisionDetection(92@) = True
Car.LockInCurrentPosition(89@) = False
099A: set_car 89@ collision_detection 1 
282@ = 0 

:QUARRY_4684
if 
  35@ == 99 
else_jump @QUARRY_4709 
gosub @QUARRY_21060 

:QUARRY_4709
return 

:QUARRY_4711
if 
   Car.Wrecked(88@)
else_jump @QUARRY_4743 
37@ = 1 
45@ = 2 
return 

:QUARRY_4743
if 
   not Car.Wrecked(89@)
else_jump @QUARRY_4767 
Car.Health(89@) = 10000

:QUARRY_4767
if 
  35@ == 0 
else_jump @QUARRY_4894 
212@ = 985.1581 
213@ = 688.4734 
214@ = 8.7255 
gosub @QUARRY_19761 
236@ = 0 
235@ = 0 
242@ = 0 
280@ = 0 
281@ = 0 
284@ = 0 
172@ = 0 
00BC: show_text_highpriority GXT 'QUAR_07' time 5000 flag 1  
35@ += 1 

:QUARRY_4894
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_4928 
37@ = 1 
45@ = 4 
return 

:QUARRY_4928
if 
  235@ == 0 
else_jump @QUARRY_5136 
if 
8686:   not car 89@ attached 
else_jump @QUARRY_5041 
Car.StorePos(89@, 59@, 60@, 61@)
02CE: 75@ = ground_z_at 59@ 60@ 61@ 
0087: 76@ = 61@ 
0063: 76@ -= 75@ 
if 
  1.5 > 76@ 
else_jump @QUARRY_5041 
37@ = 1 
45@ = 3 

:QUARRY_5041
if 
8685:   not object 92@ attached 
else_jump @QUARRY_5136 
Object.StorePos(92@, 59@, 60@, 61@)
02CE: 75@ = ground_z_at 59@ 60@ 61@ 
0087: 76@ = 61@ 
0063: 76@ -= 75@ 
if 
  1.5 > 76@ 
else_jump @QUARRY_5136 
37@ = 1 
45@ = 3 

:QUARRY_5136
if 
  35@ == 1 
else_jump @QUARRY_5208 
if 
  236@ == 1 
else_jump @QUARRY_5208 
if 
001D:   46@ > 172@ 
else_jump @QUARRY_5208 
Marker.Disable(128@)
06D6: disable_racing_checkpoint 197@ 
35@ = 99 

:QUARRY_5208
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_5373 
if 
075C:   marker 126@ enabled 
else_jump @QUARRY_5359 
Marker.Disable(126@)
03D5: remove_text 'QUAR_36'  
if 
  238@ == 1 
else_jump @QUARRY_5291 
gosub @QUARRY_19761 
jump @QUARRY_5359 

:QUARRY_5291
018A: 128@ = create_checkpoint_at 212@ 213@ 214@ 
0087: 75@ = 213@ 
75@ -= 5.0 
06D5: 197@ = create_racing_checkpoint_at 212@ 75@ 214@ point_to 0.0 0.0 0.0 type 2 radius 5.0 

:QUARRY_5359
284@ = 1 
jump @QUARRY_5453 

:QUARRY_5373
if 
875C:   not marker 126@ enabled 
else_jump @QUARRY_5453 
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
Marker.Disable(128@)
06D6: disable_racing_checkpoint 197@ 
Marker.Disable(131@)
if 
  284@ == 1 
else_jump @QUARRY_5453 
00BC: show_text_highpriority GXT 'QUAR_36' time 5000 flag 1  

:QUARRY_5453
if 
  242@ == 0 
else_jump @QUARRY_5513 
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_5513 
00BC: show_text_highpriority GXT 'QUAR_08' time 7000 flag 1  
242@ = 1 

:QUARRY_5513
if 
075C:   marker 131@ enabled 
else_jump @QUARRY_5698 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 215@ 216@ 217@ radius 4.0 4.0 4.0 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 215@ 216@ 217@ radius 12.0 12.0 12.0 
else_jump @QUARRY_5698 
Marker.Disable(131@)
238@ = 0 
018A: 128@ = create_checkpoint_at 212@ 213@ 214@ 
0087: 75@ = 213@ 
75@ -= 5.0 
06D5: 197@ = create_racing_checkpoint_at 212@ 75@ 214@ point_to 0.0 0.0 0.0 type 2 radius 5.0 
00BC: show_text_highpriority GXT 'QUAR_09' time 5000 flag 1  

:QUARRY_5698
if 
  235@ == 0 
else_jump @QUARRY_5790 
if 
01AF:   car 88@ sphere 0 in_sphere 212@ 213@ 214@ radius 50.0 30.0 10.0 
else_jump @QUARRY_5783 
235@ = 1 
03E5: show_text_box 'QUAR_H4'  
jump @QUARRY_5790 

:QUARRY_5783
235@ = 0 

:QUARRY_5790
if 
  235@ == 1 
else_jump @QUARRY_5913 
098D: get_car 88@ extra_parts_angle 75@ 
if 
  75@ > 0.05 
else_jump @QUARRY_5913 
if 
0686:   car 89@ attached 
else_jump @QUARRY_5875 
0684: detach_car 89@ 0.0 0.0 0.0 collision_detection 0 

:QUARRY_5875
if 
0685:   object 92@ attached 
else_jump @QUARRY_5913 
0682: detach_object 92@ 0.0 0.0 0.0 collision_detection 0 

:QUARRY_5913
if 
  280@ == 0 
else_jump @QUARRY_5954 
if 
02BF:   car 89@ sunk 
else_jump @QUARRY_5954 
280@ = 1 

:QUARRY_5954
if 
  281@ == 0 
else_jump @QUARRY_5995 
if 
04E7:   object 92@ in_water 
else_jump @QUARRY_5995 
281@ = 1 

:QUARRY_5995
if 
  236@ == 0 
else_jump @QUARRY_6061 
if and
  280@ == 1 
  281@ == 1 
else_jump @QUARRY_6061 
236@ = 1 
0085: 172@ = 46@ 
172@ += 2000 

:QUARRY_6061
if 
8685:   not object 93@ attached 
else_jump @QUARRY_6115 
0681: attach_object 93@ to_car 88@ with_offset 0.0 -1.7 1.5 rotation 0.0 0.0 0.0 

:QUARRY_6115
if 
8686:   not car 89@ attached 
else_jump @QUARRY_6225 
Object.StorePos(93@, 59@, 60@, 61@)
if 
01B0:   car 89@ sphere 0 in_sphere 59@ 60@ 61@ radius 3.2 3.2 1.5 stopped 
else_jump @QUARRY_6225 
0683: attach_car 89@ to_car 88@ with_offset -1000.0 0.0 0.0 rotation 0.0 0.0 0.0 

:QUARRY_6225
if 
  35@ == 99 
else_jump @QUARRY_6250 
gosub @QUARRY_21060 

:QUARRY_6250
return 

:QUARRY_6252
if 
   Car.Wrecked(87@)
else_jump @QUARRY_6284 
37@ = 1 
45@ = 1 
return 

:QUARRY_6284
if 
  35@ == 0 
else_jump @QUARRY_6462 
199@ = 0 
48@ = 0 

:QUARRY_6316
244@(48@,7i) = 0 
285@(48@,7i) = 0 
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_6316 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_11' time 10000 flag 1  
50@ = 1 
50@ -= 1 
0084: " + _8172 + @" = " + tmp_8174 + @"(50@,7i) 
" + _8172 + @" *= 1000 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D2' 
0085: 206@ = 46@ 
243@ = 0 
35@ += 1 

:QUARRY_6462
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_6496 
37@ = 1 
45@ = 5 
return 

:QUARRY_6496
if 
  35@ == 1 
else_jump @QUARRY_6539 
if 
  199@ == 7 
else_jump @QUARRY_6539 
35@ = 99 

:QUARRY_6539
if 
075C:   marker 125@ enabled 
else_jump @QUARRY_6663 
if 
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_6656 
Marker.Disable(125@)
03D5: remove_text 'QUAR_35'  
48@ = 0 

:QUARRY_6597
if 
  244@(48@,7i) == 0 
else_jump @QUARRY_6635 
133@(48@,7i) = Marker.CreateAboveObject(94@(48@,7i))

:QUARRY_6635
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_6597 

:QUARRY_6656
jump @QUARRY_8899 

:QUARRY_6663
if 
   not Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_6757 
48@ = 0 

:QUARRY_6689
Marker.Disable(133@(48@,7i))
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_6689 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_35' time 5000 flag 1  
jump @QUARRY_8899 

:QUARRY_6757
Actor.StorePos(" + PlayerActor + @", 59@, 60@, 61@)
48@ = 0 

:QUARRY_6778
80@ = 0 
if 
  244@(48@,7i) == 0 
else_jump @QUARRY_8878 
0871: init_jump_table 48@ total_jumps 7 default_jump 1 @QUARRY_8662 jumps 0 @QUARRY_6870 1 @QUARRY_7126 2 @QUARRY_7382 3 @QUARRY_7638 4 @QUARRY_7894 5 @QUARRY_8150 6 @QUARRY_8406 

:QUARRY_6870
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  30.0 > 78@ 
else_jump @QUARRY_7077 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_7011 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 762.119 836.6474 -3.4382 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_7011
if 
04E6:   object 94@(48@,7i) near_point 762.119 836.6474 -5.4382 radius 15.0 35.0 5.0 flag 0 
else_jump @QUARRY_7070 
80@ = 1 

:QUARRY_7070
jump @QUARRY_7119 

:QUARRY_7077
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_7119 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_7119
jump @QUARRY_8680 

:QUARRY_7126
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  50.0 > 78@ 
else_jump @QUARRY_7333 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_7267 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 735.8682 933.0437 -4.3942 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_7267
if 
04E6:   object 94@(48@,7i) near_point 735.8682 933.0437 -4.3942 radius 20.0 30.0 5.0 flag 0 
else_jump @QUARRY_7326 
80@ = 1 

:QUARRY_7326
jump @QUARRY_7375 

:QUARRY_7333
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_7375 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_7375
jump @QUARRY_8680 

:QUARRY_7382
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  30.0 > 78@ 
else_jump @QUARRY_7589 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_7523 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 518.9683 967.7642 -25.891 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_7523
if 
04E6:   object 94@(48@,7i) near_point 518.9683 967.7642 -17.891 radius 45.0 20.0 9.0 flag 0 
else_jump @QUARRY_7582 
80@ = 1 

:QUARRY_7582
jump @QUARRY_7631 

:QUARRY_7589
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_7631 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_7631
jump @QUARRY_8680 

:QUARRY_7638
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  30.0 > 78@ 
else_jump @QUARRY_7845 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_7779 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 671.3267 941.1938 -29.338 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_7779
if 
04E6:   object 94@(48@,7i) near_point 671.3267 941.1938 -29.338 radius 25.0 25.0 5.0 flag 0 
else_jump @QUARRY_7838 
80@ = 1 

:QUARRY_7838
jump @QUARRY_7887 

:QUARRY_7845
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_7887 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_7887
jump @QUARRY_8680 

:QUARRY_7894
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  30.0 > 78@ 
else_jump @QUARRY_8101 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_8035 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 523.2235 907.1995 -43.4101 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_8035
if 
04E6:   object 94@(48@,7i) near_point 523.2235 907.1995 -40.4101 radius 35.0 25.0 5.0 flag 0 
else_jump @QUARRY_8094 
80@ = 1 

:QUARRY_8094
jump @QUARRY_8143 

:QUARRY_8101
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_8143 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_8143
jump @QUARRY_8680 

:QUARRY_8150
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  30.0 > 78@ 
else_jump @QUARRY_8357 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_8291 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 536.8022 838.0778 -38.2296 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_8291
if 
04E6:   object 94@(48@,7i) near_point 536.8022 838.0778 -38.2296 radius 25.0 15.0 5.0 flag 0 
else_jump @QUARRY_8350 
80@ = 1 

:QUARRY_8350
jump @QUARRY_8399 

:QUARRY_8357
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_8399 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_8399
jump @QUARRY_8680 

:QUARRY_8406
Object.StorePos(94@(48@,7i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  50.0 > 78@ 
else_jump @QUARRY_8613 
if 
  285@(48@,7i) == 0 
else_jump @QUARRY_8547 
06D5: 190@(48@,7i) = create_racing_checkpoint_at 645.2571 773.7028 -28.2457 point_to 0.0 0.0 0.0 type 2 radius 5.0 
285@(48@,7i) = 1 

:QUARRY_8547
if 
04E6:   object 94@(48@,7i) near_point 645.2571 773.7028 -26.2457 radius 35.0 20.0 7.0 flag 0 
else_jump @QUARRY_8606 
80@ = 1 

:QUARRY_8606
jump @QUARRY_8655 

:QUARRY_8613
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_8655 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_8655
jump @QUARRY_8680 

:QUARRY_8662
0662: printstring ""TOO_MANY_ROCKS"" 

:QUARRY_8680
if 
  80@ == 1 
else_jump @QUARRY_8878 
Marker.Disable(133@(48@,7i))
Object.Destroy(94@(48@,7i))
if 
  285@(48@,7i) == 1 
else_jump @QUARRY_8758 
06D6: disable_racing_checkpoint 190@(48@,7i) 
285@(48@,7i) = 0 

:QUARRY_8758
244@(48@,7i) = 1 
199@ += 1 
50@ = 7 
0062: 50@ -= 199@ 
if 
   not 50@ == 0 
else_jump @QUARRY_8878 
if 
  199@ == 1 
else_jump @QUARRY_8856 
02FD: show_text_2numbers_lowpriority GXT 'QUAR_14' numbers 199@ 50@ time 5000 flag 1  
jump @QUARRY_8878 

:QUARRY_8856
02FD: show_text_2numbers_lowpriority GXT 'QUAR_13' numbers 199@ 50@ time 5000 flag 1  

:QUARRY_8878
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_6778 

:QUARRY_8899
if 
  243@ == 0 
else_jump @QUARRY_8959 
if 
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_8959 
00BC: show_text_highpriority GXT 'QUAR_12' time 7000 flag 1  
243@ = 1 

:QUARRY_8959
if 
  35@ == 99 
else_jump @QUARRY_8984 
gosub @QUARRY_21060 

:QUARRY_8984
return 

:QUARRY_8986
if 
   Car.Wrecked(87@)
else_jump @QUARRY_9018 
37@ = 1 
45@ = 1 
return 

:QUARRY_9018
if 
  35@ == 0 
else_jump @QUARRY_9242 
204@ = 0 
48@ = 0 

:QUARRY_9050
253@(48@,4i) = 0 
257@(48@,4i) = 0 
178@(48@,4i) = 0 
48@ += 1 
  48@ >= 4 
else_jump @QUARRY_9050 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_15' time 10000 flag 1  
008A: " + _8172 + @" = 174@ 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D3' 
0085: 206@ = 46@ 
48@ = 0 

:QUARRY_9174
005A: 174@(48@,4i) += 46@ 
48@ += 1 
  48@ >= 4 
else_jump @QUARRY_9174 
251@ = 0 
252@ = 0 
261@ = 0 
243@ = 0 
35@ += 1 

:QUARRY_9242
if 
  35@ == 1 
else_jump @QUARRY_9408 
if 
  252@ == 1 
else_jump @QUARRY_9408 
Actor.StorePos(" + PlayerActor + @", 59@, 60@, 61@)
50@ = 4 
50@ -= 1 
Object.StorePos(101@(50@,10i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  78@ > 20.0 
else_jump @QUARRY_9408 
020C: create_explosion_with_radius 7 at 62@ 63@ 64@ 
Object.Destroy(101@(50@,10i))
253@(50@,4i) = 1 
35@ = 99 

:QUARRY_9408
if 
075C:   marker 125@ enabled 
else_jump @QUARRY_9466 
if 
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_9459 
Marker.Disable(125@)
03D5: remove_text 'QUAR_35'  

:QUARRY_9459
jump @QUARRY_9533 

:QUARRY_9466
if 
   not Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_9533 
Marker.Disable(140@)
Marker.Disable(128@)
251@ = 0 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_35' time 5000 flag 1  

:QUARRY_9533
if 
  252@ == 0 
else_jump @QUARRY_10787 
80@ = 0 
0871: init_jump_table 204@ total_jumps 4 default_jump 1 @QUARRY_10048 jumps 0 @QUARRY_9621 1 @QUARRY_9687 2 @QUARRY_9916 3 @QUARRY_9982 -1 @QUARRY_10067 -1 @QUARRY_10067 -1 @QUARRY_10067 

:QUARRY_9621
if 
04E6:   object 101@(204@,10i) near_point 830.4274 889.852 12.3516 radius 4.0 4.0 1.0 flag 1 
else_jump @QUARRY_9680 
80@ = 1 

:QUARRY_9680
jump @QUARRY_10067 

:QUARRY_9687
if 
  261@ == 0 
else_jump @QUARRY_9850 
if 
04E6:   object 101@(204@,10i) near_point 678.5786 981.4282 -13.749 radius 4.0 4.0 1.0 flag 1 
else_jump @QUARRY_9764 
80@ = 1 

:QUARRY_9764
Object.StorePos(101@(204@,10i), 59@, 60@, 61@)
if 
  -23.6787 > 61@ 
else_jump @QUARRY_9843 
261@ = 1 
Marker.Disable(140@)
Marker.Disable(128@)
251@ = 0 
00BC: show_text_highpriority GXT 'QUAR_21' time 7000 flag 1  

:QUARRY_9843
jump @QUARRY_9909 

:QUARRY_9850
if 
04E6:   object 101@(204@,10i) near_point 660.666 913.719 -41.4059 radius 4.0 4.0 1.0 flag 1 
else_jump @QUARRY_9909 
80@ = 1 

:QUARRY_9909
jump @QUARRY_10067 

:QUARRY_9916
if 
04E6:   object 101@(204@,10i) near_point 648.9208 916.257 -42.2287 radius 4.0 4.0 1.0 flag 1 
else_jump @QUARRY_9975 
80@ = 1 

:QUARRY_9975
jump @QUARRY_10067 

:QUARRY_9982
if 
04E6:   object 101@(204@,10i) near_point 632.4524 810.3196 -43.9609 radius 4.0 4.0 1.0 flag 1 
else_jump @QUARRY_10041 
80@ = 1 

:QUARRY_10041
jump @QUARRY_10067 

:QUARRY_10048
0662: printstring ""UNKNOWN_BOMB_ID"" 

:QUARRY_10067
if 
  80@ == 1 
else_jump @QUARRY_10222 
Marker.Disable(140@)
Marker.Disable(128@)
251@ = 0 
261@ = 0 
Object.KeepInMemory(101@(204@,10i)) = True
Object.CollisionDetection(101@(204@,10i)) = False
0085: 50@ = 204@ 
50@ += 1 
if 
  50@ == 4 
else_jump @QUARRY_10215 
0085: 51@ = 46@ 
51@ += 15000 
if 
001D:   174@(204@,4i) > 51@ 
else_jump @QUARRY_10215 
0085: 174@(204@,4i) = 51@ 

:QUARRY_10215
204@ += 1 

:QUARRY_10222
if 
  204@ == 4 
else_jump @QUARRY_10247 
252@ = 1 

:QUARRY_10247
if 
  80@ == 1 
else_jump @QUARRY_10324 
014F: stop_timer " + _8172 + @" 
if 
  252@ == 0 
else_jump @QUARRY_10324 
008A: " + _8172 + @" = 174@(204@,4i) 
0066: " + _8172 + @" -= 46@ 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D3' 

:QUARRY_10324
if 
  80@ == 1 
else_jump @QUARRY_10522 
if 
  252@ == 1 
else_jump @QUARRY_10383 
00BC: show_text_highpriority GXT 'QUAR_20' time 7000 flag 1  
jump @QUARRY_10522 

:QUARRY_10383
0871: init_jump_table 204@ total_jumps 4 default_jump 0 @QUARRY_10522 jumps 0 @QUARRY_10446 1 @QUARRY_10453 2 @QUARRY_10476 3 @QUARRY_10499 -1 @QUARRY_10522 -1 @QUARRY_10522 -1 @QUARRY_10522 

:QUARRY_10446
jump @QUARRY_10522 

:QUARRY_10453
00BC: show_text_highpriority GXT 'QUAR_17' time 7000 flag 1  
jump @QUARRY_10522 

:QUARRY_10476
00BC: show_text_highpriority GXT 'QUAR_18' time 7000 flag 1  
jump @QUARRY_10522 

:QUARRY_10499
00BC: show_text_highpriority GXT 'QUAR_34' time 7000 flag 1  
jump @QUARRY_10522 

:QUARRY_10522
if and
  251@ == 0 
  252@ == 0 
875C:   not marker 125@ enabled 
else_jump @QUARRY_10787 
140@ = Marker.CreateAboveObject(101@(204@,10i))
251@ = 1 
0871: init_jump_table 204@ total_jumps 4 default_jump 0 @QUARRY_10787 jumps 0 @QUARRY_10634 1 @QUARRY_10661 2 @QUARRY_10733 3 @QUARRY_10760 -1 @QUARRY_10787 -1 @QUARRY_10787 -1 @QUARRY_10787 

:QUARRY_10634
018A: 128@ = create_checkpoint_at 830.4274 889.852 12.3516 
jump @QUARRY_10787 

:QUARRY_10661
if 
  261@ == 0 
else_jump @QUARRY_10706 
018A: 128@ = create_checkpoint_at 678.5786 981.4282 -13.749 
jump @QUARRY_10726 

:QUARRY_10706
018A: 128@ = create_checkpoint_at 660.666 913.719 -41.4059 

:QUARRY_10726
jump @QUARRY_10787 

:QUARRY_10733
018A: 128@ = create_checkpoint_at 648.9208 916.257 -42.2287 
jump @QUARRY_10787 

:QUARRY_10760
018A: 128@ = create_checkpoint_at 632.4524 810.3196 -43.9609 
jump @QUARRY_10787 

:QUARRY_10787
48@ = 0 
0085: 50@ = 204@ 
if 
  252@ == 1 
else_jump @QUARRY_10827 
50@ -= 1 

:QUARRY_10827
if 
002D:   50@ >= 48@ 
else_jump @QUARRY_11360 
if 
  253@(48@,4i) == 0 
else_jump @QUARRY_11265 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
Car.StorePos(87@, 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
Actor.StorePos(" + PlayerActor + @", 65@, 66@, 67@)
050A: 79@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 65@ 66@ 67@ 
if 
803B:   not  48@ == 204@ 
else_jump @QUARRY_11033 
if and
  78@ > 21.0 
  79@ > 21.0 
else_jump @QUARRY_11033 
0085: 174@(48@,4i) = 46@ 
174@(48@,4i) -= 1 

:QUARRY_11033
if 
001D:   46@ > 174@(48@,4i) 
else_jump @QUARRY_11258 
020C: create_explosion_with_radius 10 at 59@ 60@ 61@ 
Object.Destroy(101@(48@,10i))
253@(48@,4i) = 1 
257@(48@,4i) = 0 
0085: 178@(48@,4i) = 46@ 
178@(48@,4i) += 2000 
0087: 218@(48@,4f) = 59@ 
0087: 222@(48@,4f) = 60@ 
0087: 226@(48@,4f) = 61@ 
if 
  20.0 > 78@ 
else_jump @QUARRY_11186 
020B: explode_car 87@ 

:QUARRY_11186
if 
  20.0 > 79@ 
else_jump @QUARRY_11223 
37@ = 1 
45@ = 7 
return 

:QUARRY_11223
if 
003B:   48@ == 204@ 
else_jump @QUARRY_11258 
37@ = 1 
45@ = 6 
return 

:QUARRY_11258
jump @QUARRY_11346 

:QUARRY_11265
if 
  257@(48@,4i) == 0 
else_jump @QUARRY_11346 
if 
001D:   46@ > 178@(48@,4i) 
else_jump @QUARRY_11346 
020C: create_explosion_with_radius 9 at 218@(48@,4f) 222@(48@,4f) 226@(48@,4f) 
257@(48@,4i) = 1 

:QUARRY_11346
48@ += 1 
jump @QUARRY_10827 

:QUARRY_11360
if 
  243@ == 0 
else_jump @QUARRY_11420 
if 
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_11420 
00BC: show_text_highpriority GXT 'QUAR_16' time 7000 flag 1  
243@ = 1 

:QUARRY_11420
if 
  35@ == 99 
else_jump @QUARRY_11445 
gosub @QUARRY_21060 

:QUARRY_11445
return 

:QUARRY_11447
if 
   Car.Wrecked(88@)
else_jump @QUARRY_11479 
37@ = 1 
45@ = 2 
return 

:QUARRY_11479
if 
  35@ == 0 
else_jump @QUARRY_11607 
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
gosub @QUARRY_19814 
00BC: show_text_highpriority GXT 'QUAR_22' time 10000 flag 1  
235@ = 0 
50@ = 4 
50@ -= 1 
0084: " + _8172 + @" = " + tmp_8174 + @"(50@,7i) 
" + _8172 + @" *= 1000 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D1' 
0085: 206@ = 46@ 
35@ += 1 

:QUARRY_11607
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_11641 
37@ = 1 
45@ = 4 
return 

:QUARRY_11641
if 
  35@ == 1 
else_jump @QUARRY_11701 
if 
  235@ == 1 
else_jump @QUARRY_11701 
Marker.Disable(132@)
239@ = 0 
Marker.Disable(126@)
35@ = 99 

:QUARRY_11701
if 
  235@ == 0 
else_jump @QUARRY_11745 
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_11745 
235@ = 1 

:QUARRY_11745
if 
  239@ == 1 
else_jump @QUARRY_11848 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 215@ 216@ 217@ radius 4.0 4.0 4.0 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 215@ 216@ 217@ radius 15.0 10.0 4.0 
else_jump @QUARRY_11848 
Marker.Disable(132@)
239@ = 0 

:QUARRY_11848
if 
  35@ == 99 
else_jump @QUARRY_11873 
gosub @QUARRY_21060 

:QUARRY_11873
return 

:QUARRY_11875
if 
   Car.Wrecked(88@)
else_jump @QUARRY_11907 
37@ = 1 
45@ = 2 
return 

:QUARRY_11907
if 
  35@ == 0 
else_jump @QUARRY_12473 
212@ = 469.377 
213@ = 877.2751 
214@ = -29.0362 
gosub @QUARRY_19761 
48@ = 0 

:QUARRY_11969
0209: 50@ = random_int_in_ranges 2 4 
0208: 59@ = random_float_in_ranges -2.0 2.0 
0208: 60@ = random_float_in_ranges -3.0 3.0 
005B: 59@ += 212@ 
005B: 60@ += 213@ 
02CE: 61@ = ground_z_at 59@ 60@ -20.0 
02CF: 153@(48@,18i) = create_fire_at 59@ 60@ 61@ propagation 0 size 50@ 
48@ += 1 
  48@ >= 15 
else_jump @QUARRY_11969 
48@ = 0 

:QUARRY_12091
0209: 50@ = random_int_in_ranges 0 4 
0208: 59@ = random_float_in_ranges -1.3 1.3 
0208: 60@ = random_float_in_ranges -1.8 1.8 
005B: 59@ += 212@ 
005B: 60@ += 213@ 
02CE: 61@ = ground_z_at 59@ 60@ -20.0 
0871: init_jump_table 50@ total_jumps 4 default_jump 0 @QUARRY_12337 jumps 0 @QUARRY_12225 1 @QUARRY_12253 2 @QUARRY_12281 3 @QUARRY_12309 -1 @QUARRY_12337 -1 @QUARRY_12337 -1 @QUARRY_12337 

:QUARRY_12225
114@(50@,7i) = Object.Create(#CM_BOX, 59@, 60@, 61@)
jump @QUARRY_12337 

:QUARRY_12253
114@(50@,7i) = Object.Create(#BLACKBAG2, 59@, 60@, 61@)
jump @QUARRY_12337 

:QUARRY_12281
114@(50@,7i) = Object.Create(#DYN_WOODPILE, 59@, 60@, 61@)
jump @QUARRY_12337 

:QUARRY_12309
114@(50@,7i) = Object.Create(#DYN_WOODPILE2, 59@, 60@, 61@)
jump @QUARRY_12337 

:QUARRY_12337
0208: 75@ = random_float_in_ranges 0.0 359.0 
0208: 76@ = random_float_in_ranges 0.0 359.0 
0208: 77@ = random_float_in_ranges 0.0 359.0 
0453: set_object 114@(50@,7i) XYZ_rotation 75@ 76@ 77@ 
0654: make_object 114@(50@,7i) fireproof 1 
Object.CollisionDetection(114@(50@,7i)) = False
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_12091 
00BC: show_text_highpriority GXT 'QUAR_23' time 7000 flag 1  
263@ = 0 
35@ += 1 

:QUARRY_12473
if 
  236@ == 0 
else_jump @QUARRY_12806 
50@ = 0 
48@ = 0 

:QUARRY_12505
if 
8685:   not object 111@(48@,3i) attached 
else_jump @QUARRY_12760 
Object.StorePos(111@(48@,3i), 59@, 60@, 61@)
02CE: 75@ = ground_z_at 59@ 60@ 61@ 
0087: 76@ = 61@ 
0063: 76@ -= 75@ 
if 
  0.5 > 76@ 
else_jump @QUARRY_12760 
if 
04E6:   object 111@(48@,3i) near_point 212@ 213@ 214@ radius 12.0 15.0 3.0 flag 0 
else_jump @QUARRY_12744 
51@ = 15 
005A: 51@ += 48@ 
if 
8973:   not fire 153@(51@,18i) exists 
else_jump @QUARRY_12730 
02CF: 153@(51@,18i) = create_fire_at 59@ 60@ 61@ propagation 0 size 3 
0654: make_object 111@(48@,3i) fireproof 1 
Object.KeepInMemory(111@(48@,3i)) = True
Object.CollisionDetection(111@(48@,3i)) = False

:QUARRY_12730
50@ += 1 
jump @QUARRY_12760 

:QUARRY_12744
37@ = 1 
45@ = 8 
return 

:QUARRY_12760
48@ += 1 
  48@ >= 3 
else_jump @QUARRY_12505 
if 
  50@ == 3 
else_jump @QUARRY_12806 
236@ = 1 

:QUARRY_12806
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_12840 
37@ = 1 
45@ = 4 
return 

:QUARRY_12840
if 
  35@ == 1 
else_jump @QUARRY_12883 
if 
  236@ == 1 
else_jump @QUARRY_12883 
35@ = 99 

:QUARRY_12883
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_12994 
if 
075C:   marker 126@ enabled 
else_jump @QUARRY_12987 
Marker.Disable(126@)
03D5: remove_text 'QUAR_36'  
if 
  238@ == 1 
else_jump @QUARRY_12973 
018A: 128@ = create_checkpoint_at 215@ 216@ 217@ 
jump @QUARRY_12987 

:QUARRY_12973
018A: 128@ = create_checkpoint_at 212@ 213@ 214@ 

:QUARRY_12987
jump @QUARRY_13046 

:QUARRY_12994
if 
875C:   not marker 126@ enabled 
else_jump @QUARRY_13046 
Marker.Disable(128@)
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_36' time 5000 flag 1  

:QUARRY_13046
if 
  236@ == 0 
else_jump @QUARRY_13199 
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_13199 
if 
8100:   not actor " + PlayerActor + @" in_sphere 212@ 213@ 214@ radius 25.0 25.0 20.0 sphere 0 in_car 
else_jump @QUARRY_13163 
0100:   actor " + PlayerActor + @" in_sphere 212@ 213@ 214@ radius 4.0 4.0 4.0 sphere 1 in_car 
jump @QUARRY_13199 

:QUARRY_13163
if 
  262@ == 0 
else_jump @QUARRY_13199 
0512: show_permanent_text_box 'QUAR_H1'  
262@ = 1 

:QUARRY_13199
if 
  263@ == 0 
else_jump @QUARRY_13327 
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_13327 
if 
0100:   actor " + PlayerActor + @" in_sphere 215@ 216@ 217@ radius 12.0 12.0 12.0 sphere 1 in_car 
else_jump @QUARRY_13327 
00BC: show_text_highpriority GXT 'QUAR_24' time 7000 flag 1  
263@ = 1 
Marker.Disable(131@)
238@ = 0 
018A: 128@ = create_checkpoint_at 212@ 213@ 214@ 

:QUARRY_13327
if 
  35@ == 99 
else_jump @QUARRY_13352 
gosub @QUARRY_21060 

:QUARRY_13352
return 

:QUARRY_13354
if 
   Car.Wrecked(88@)
else_jump @QUARRY_13386 
37@ = 1 
45@ = 2 
return 

:QUARRY_13386
if 
  35@ == 0 
else_jump @QUARRY_13602 
212@ = -59.3126 
213@ = 2502.254 
214@ = 15.4766 
205@ = Car.Health(88@)
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
50@ = 5 
50@ -= 1 
0084: " + _8172 + @" = " + tmp_8174 + @"(50@,7i) 
" + _8172 + @" *= 1000 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D4' 
0085: 206@ = 46@ 
00BC: show_text_highpriority GXT 'QUAR_38' time 10000 flag 1  
236@ = 0 
264@ = 0 
48@ = 0 

:QUARRY_13552
296@(48@,6i) = 0 
184@(48@,6i) = 0 
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_13552 
35@ += 1 

:QUARRY_13602
if 
  236@ == 0 
else_jump @QUARRY_13974 
80@ = 0 
50@ = 0 
48@ = 0 

:QUARRY_13641
if 
8685:   not object 101@(48@,10i) attached 
else_jump @QUARRY_13819 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
02CE: 75@ = ground_z_at 59@ 60@ 61@ 
0087: 76@ = 61@ 
0063: 76@ -= 75@ 
if 
  1.0 > 76@ 
else_jump @QUARRY_13819 
if 
04E6:   object 101@(48@,10i) near_point 212@ 213@ 214@ radius 12.0 15.0 3.0 flag 0 
else_jump @QUARRY_13790 
50@ += 1 
jump @QUARRY_13819 

:QUARRY_13790
020C: create_explosion_with_radius 2 at 59@ 60@ 61@ 
Object.Destroy(101@(48@,10i))
80@ = 1 

:QUARRY_13819
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_13641 
if 
  80@ == 1 
else_jump @QUARRY_13949 
48@ = 0 

:QUARRY_13865
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_13907 
020C: create_explosion_with_radius 2 at 59@ 60@ 61@ 
Object.Destroy(101@(48@,10i))

:QUARRY_13907
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_13865 
020B: explode_car 88@ 
37@ = 1 
45@ = 9 
return 

:QUARRY_13949
if 
  50@ == 6 
else_jump @QUARRY_13974 
236@ = 1 

:QUARRY_13974
if 
  236@ == 0 
else_jump @QUARRY_14151 
50@ = Car.Health(88@)
0085: 51@ = 205@ 
0062: 51@ -= 50@ 
if 
  51@ > 10 
else_jump @QUARRY_14143 
48@ = 0 

:QUARRY_14041
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_14101 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
020C: create_explosion_with_radius 2 at 59@ 60@ 61@ 
Object.Destroy(101@(48@,10i))

:QUARRY_14101
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_14041 
020B: explode_car 88@ 
37@ = 1 
45@ = 9 
return 

:QUARRY_14143
0085: 205@ = 50@ 

:QUARRY_14151
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_14185 
37@ = 1 
45@ = 10 
return 

:QUARRY_14185
if 
  35@ == 1 
else_jump @QUARRY_14228 
if 
  236@ == 1 
else_jump @QUARRY_14228 
35@ = 99 

:QUARRY_14228
48@ = 0 

:QUARRY_14235
if 
03CA:   object 122@(48@,3i) exists 
else_jump @QUARRY_14485 
if 
8685:   not object 122@(48@,3i) attached 
else_jump @QUARRY_14485 
0871: init_jump_table 48@ total_jumps 3 default_jump 0 @QUARRY_14485 jumps 0 @QUARRY_14338 1 @QUARRY_14387 2 @QUARRY_14436 -1 @QUARRY_14485 -1 @QUARRY_14485 -1 @QUARRY_14485 -1 @QUARRY_14485 

:QUARRY_14338
0681: attach_object 122@(48@,3i) to_car 88@ with_offset -1.0 -5.0 0.3 rotation 0.0 0.0 0.0 
jump @QUARRY_14485 

:QUARRY_14387
0681: attach_object 122@(48@,3i) to_car 88@ with_offset 0.0 -5.0 0.3 rotation 0.0 0.0 0.0 
jump @QUARRY_14485 

:QUARRY_14436
0681: attach_object 122@(48@,3i) to_car 88@ with_offset 1.0 -5.0 0.3 rotation 0.0 0.0 0.0 
jump @QUARRY_14485 

:QUARRY_14485
48@ += 1 
  48@ >= 3 
else_jump @QUARRY_14235 
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_14578 
if 
875C:   not marker 128@ enabled 
else_jump @QUARRY_14571 
Marker.Disable(126@)
018A: 128@ = create_checkpoint_at 212@ 213@ 214@ 
03D5: remove_text 'QUAR_36'  

:QUARRY_14571
jump @QUARRY_14630 

:QUARRY_14578
if 
875C:   not marker 126@ enabled 
else_jump @QUARRY_14630 
Marker.Disable(128@)
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_36' time 5000 flag 1  

:QUARRY_14630
if 
075C:   marker 128@ enabled 
else_jump @QUARRY_14677 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 212@ 213@ 214@ radius 8.0 8.0 4.0 

:QUARRY_14677
if 
  264@ == 0 
else_jump @QUARRY_14760 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 212@ 213@ 214@ radius 24.0 30.0 8.0 
else_jump @QUARRY_14760 
00BC: show_text_highpriority GXT 'QUAR_26' time 7000 flag 1  
264@ = 1 

:QUARRY_14760
if 
01AF:   car 88@ sphere 0 in_sphere 212@ 213@ 214@ radius 10.0 10.0 5.0 
else_jump @QUARRY_14925 
098D: get_car 88@ extra_parts_angle 75@ 
if 
  75@ > 0.05 
else_jump @QUARRY_14925 
48@ = 0 

:QUARRY_14838
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_14904 
if 
0685:   object 101@(48@,10i) attached 
else_jump @QUARRY_14904 
0682: detach_object 101@(48@,10i) 0.0 0.0 0.0 collision_detection 0 

:QUARRY_14904
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_14838 

:QUARRY_14925
80@ = 0 
48@ = 0 

:QUARRY_14939
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_14997 
071E: get_object 101@(48@,10i) health_to 50@ 
if 
  950 >= 50@ 
else_jump @QUARRY_14997 
80@ = 1 

:QUARRY_14997
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_14939 
if 
  80@ == 1 
else_jump @QUARRY_15145 
48@ = 0 

:QUARRY_15043
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_15103 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
020C: create_explosion_with_radius 2 at 59@ 60@ 61@ 
Object.Destroy(101@(48@,10i))

:QUARRY_15103
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_15043 
020B: explode_car 88@ 
37@ = 1 
45@ = 9 
return 

:QUARRY_15145
if 
01AF:   car 88@ sphere 0 in_sphere 212@ 213@ 214@ radius 10.0 10.0 5.0 
else_jump @QUARRY_15656 
098D: get_car 88@ extra_parts_angle 75@ 
if 
  75@ > 0.25 
else_jump @QUARRY_15656 
48@ = 0 

:QUARRY_15223
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_15635 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
80@ = 0 
50@ = 0 

:QUARRY_15275
if 
  3 > 50@ 
else_jump @QUARRY_15403 
if and
  80@ == 0 
03CA:   object 122@(50@,3i) exists 
else_jump @QUARRY_15389 
Object.StorePos(122@(50@,3i), 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  0.75 > 78@ 
else_jump @QUARRY_15389 
80@ = 1 

:QUARRY_15389
50@ += 1 
jump @QUARRY_15275 

:QUARRY_15403
if 
  80@ == 1 
else_jump @QUARRY_15613 
if 
  296@(48@,6i) == 0 
else_jump @QUARRY_15485 
296@(48@,6i) = 1 
0085: 184@(48@,6i) = 46@ 
184@(48@,6i) += 5000 
jump @QUARRY_15606 

:QUARRY_15485
if 
001D:   46@ > 184@(48@,6i) 
else_jump @QUARRY_15606 
0085: 184@(48@,6i) = 46@ 
184@(48@,6i) += 5000 
if 
0685:   object 101@(48@,10i) attached 
else_jump @QUARRY_15578 
0682: detach_object 101@(48@,10i) 0.0 0.0 0.0 collision_detection 0 

:QUARRY_15578
61@ += 1.2 
Object.PutAt(101@(48@,10i), 59@, 60@, 61@)

:QUARRY_15606
jump @QUARRY_15635 

:QUARRY_15613
296@(48@,6i) = 0 
184@(48@,6i) = 0 

:QUARRY_15635
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_15223 

:QUARRY_15656
if 
  35@ == 99 
else_jump @QUARRY_15691 
Marker.Disable(128@)
Marker.Disable(126@)
gosub @QUARRY_21060 

:QUARRY_15691
return 

:QUARRY_15693
if 
   Car.Wrecked(87@)
else_jump @QUARRY_15725 
37@ = 1 
45@ = 1 
return 

:QUARRY_15725
if 
   Car.Wrecked(90@)
else_jump @QUARRY_15757 
37@ = 1 
45@ = 12 
return 

:QUARRY_15757
if 
  35@ == 0 
else_jump @QUARRY_15966 
265@ = 0 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
50@ = 6 
50@ -= 1 
0084: " + _8172 + @" = " + tmp_8174 + @"(50@,7i) 
" + _8172 + @" *= 1000 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D5' 
0085: 206@ = 46@ 
008B: 182@ = " + tmp_8174 + @"(50@,7i) 
182@ -= 15 
182@ *= 1000 
005A: 182@ += 46@ 
266@ = 0 
267@ = 0 
48@ = 0 

:QUARRY_15911
268@(48@,10i) = 1 
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_15911 
00BC: show_text_highpriority GXT 'QUAR_28' time 10000 flag 1  
35@ += 1 

:QUARRY_15966
if 
  266@ == 1 
else_jump @QUARRY_16217 
Object.StorePos(121@, 62@, 63@, 64@)
48@ = 0 

:QUARRY_16005
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_16176 
if 
  268@(48@,10i) == 1 
else_jump @QUARRY_16176 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  2.0 > 78@ 
else_jump @QUARRY_16176 
020C: create_explosion_with_radius 7 at 59@ 60@ 61@ 
Object.Destroy(101@(48@,10i))
if 
   not Car.Wrecked(90@)
else_jump @QUARRY_16176 
020B: explode_car 90@ 
06DD: set_train 90@ speed 0.0 
37@ = 1 
45@ = 11 

:QUARRY_16176
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_16005 
if 
  37@ == 1 
else_jump @QUARRY_16217 
return 

:QUARRY_16217
if 
  35@ == 1 
else_jump @QUARRY_16260 
if 
  267@ == 1 
else_jump @QUARRY_16260 
35@ = 99 

:QUARRY_16260
if 
   Actor.InCar(" + PlayerActor + @", 87@)
else_jump @QUARRY_16327 
if 
  265@ == 0 
else_jump @QUARRY_16320 
265@ = 1 
Marker.Disable(125@)
03D5: remove_text 'QUAR_35'  

:QUARRY_16320
jump @QUARRY_16436 

:QUARRY_16327
if 
  265@ == 1 
else_jump @QUARRY_16389 
48@ = 0 

:QUARRY_16352
Marker.Disable(142@(48@,10i))
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_16352 
265@ = 0 

:QUARRY_16389
if 
875C:   not marker 125@ enabled 
else_jump @QUARRY_16436 
125@ = Marker.CreateAboveCar(87@)
07E0: set_marker 125@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_35' time 5000 flag 1  

:QUARRY_16436
if 
  266@ == 0 
else_jump @QUARRY_16531 
if 
  15000 >= " + _8172 + @" 
else_jump @QUARRY_16531 
06DC: set_train 90@ acc 56.0 
06DD: set_train 90@ speed 56.0 
141@ = Marker.CreateAboveCar(90@)
07E0: set_marker 141@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_29' time 7000 flag 1  
266@ = 1 

:QUARRY_16531
if 
  266@ == 0 
else_jump @QUARRY_16660 
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 727.6937 2412.204 17.6685 cornerB 872.5978 2714.917 21.0511 
else_jump @QUARRY_16660 
06DC: set_train 90@ acc 56.0 
06DD: set_train 90@ speed 56.0 
141@ = Marker.CreateAboveCar(90@)
07E0: set_marker 141@ type_to 1 
014F: stop_timer " + _8172 + @" 
00BC: show_text_highpriority GXT 'QUAR_29' time 7000 flag 1  
266@ = 1 

:QUARRY_16660
if and
  266@ == 1 
  267@ == 0 
else_jump @QUARRY_16740 
if 
01AF:   car 90@ sphere 0 in_sphere 673.9813 1331.079 10.7891 radius 20.0 20.0 8.0 
else_jump @QUARRY_16740 
267@ = 1 

:QUARRY_16740
if 
  265@ == 1 
else_jump @QUARRY_16949 
48@ = 0 

:QUARRY_16765
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_16928 
Object.StorePos(101@(48@,10i), 59@, 60@, 61@)
if and
  59@ > 739.0 
  747.0 > 59@ 
else_jump @QUARRY_16888 
268@(48@,10i) = 1 
if 
875C:   not marker 142@(48@,10i) enabled 
else_jump @QUARRY_16881 
142@(48@,10i) = Marker.CreateAboveObject(101@(48@,10i))

:QUARRY_16881
jump @QUARRY_16928 

:QUARRY_16888
268@(48@,10i) = 0 
if 
075C:   marker 142@(48@,10i) enabled 
else_jump @QUARRY_16928 
Marker.Disable(142@(48@,10i))

:QUARRY_16928
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_16765 

:QUARRY_16949
if 
  266@ == 0 
else_jump @QUARRY_17170 
50@ = 0 
48@ = 0 

:QUARRY_16981
if 
03CA:   object 101@(48@,10i) exists 
else_jump @QUARRY_17037 
if 
  268@(48@,10i) == 0 
else_jump @QUARRY_17030 
50@ += 1 

:QUARRY_17030
jump @QUARRY_17044 

:QUARRY_17037
50@ += 1 

:QUARRY_17044
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_16981 
if 
  50@ == 10 
else_jump @QUARRY_17170 
75@ = 56.0 
75@ *= 2.0 
06DC: set_train 90@ acc 75@ 
06DD: set_train 90@ speed 75@ 
141@ = Marker.CreateAboveCar(90@)
07E0: set_marker 141@ type_to 1 
014F: stop_timer " + _8172 + @" 
00BC: show_text_highpriority GXT 'QUAR_29' time 7000 flag 1  
0085: 207@ = 46@ 
266@ = 1 

:QUARRY_17170
if 
  35@ == 99 
else_jump @QUARRY_17195 
gosub @QUARRY_21060 

:QUARRY_17195
return 

:QUARRY_17197
if 
   Car.Wrecked(91@)
else_jump @QUARRY_17220 
278@ = 1 

:QUARRY_17220
if 
   Car.Wrecked(88@)
else_jump @QUARRY_17252 
37@ = 1 
45@ = 2 
return 

:QUARRY_17252
if 
  35@ == 0 
else_jump @QUARRY_17632 
Car.SetToPsychoDriver(91@)
Car.SetMaxSpeed(91@, 26.0)
00AE: set_car 91@ traffic_behaviour_to 2 
Car.ImmuneToNonPlayer(91@) = True
152@ = Marker.CreateAboveCar(91@)
Car.DoorStatus(91@) = 3
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_32' time 10000 flag 1  
03C4: set_status_text " + _8173 + @" type 1 GXT 'QUAR_D6' 
50@ = 3 
50@ -= 1 
0084: " + _8172 + @" = " + tmp_8174 + @"(50@,7i) 
" + _8172 + @" *= 1000 
03C3: set_timer_to " + _8172 + @" type 1 GXT 'QUAR_D4' 
0085: 206@ = 46@ 
01E8: create_forbidden_for_cars_cube_cornerA 256.6312 734.7498 4.0053 cornerB 343.9576 765.6713 6.4852 
01E8: create_forbidden_for_cars_cube_cornerA 291.2253 762.6765 4.0625 cornerB 354.4869 784.4223 6.6101 
01E8: create_forbidden_for_cars_cube_cornerA -149.9865 460.067 4.9719 cornerB -119.7325 530.4155 12.4813 
01E8: create_forbidden_for_cars_cube_cornerA -100.9858 1190.38 16.1736 cornerB 97.0928 1205.202 19.9344 
01E8: create_forbidden_for_cars_cube_cornerA -124.9028 1209.581 14.6519 cornerB -108.1954 1243.821 19.8554 
01E8: create_forbidden_for_cars_cube_cornerA -113.2273 1246.477 11.3781 cornerB -84.1825 1268.751 17.5621 
283@ = 1 
279@ = 0 
35@ += 1 

:QUARRY_17632
if 
   not Car.Wrecked(91@)
else_jump @QUARRY_17855 
Actor.StorePos(" + PlayerActor + @", 59@, 60@, 61@)
Car.StorePos(91@, 62@, 63@, 64@)
050A: 78@ = distance_between_XYZ 59@ 60@ 61@ and_XYZ 62@ 63@ 64@ 
if 
  78@ > 600.0 
else_jump @QUARRY_17736 
37@ = 1 
45@ = 13 
return 

:QUARRY_17736
if 
  279@ == 0 
else_jump @QUARRY_17798 
if 
  78@ > 500.0 
else_jump @QUARRY_17798 
00BC: show_text_highpriority GXT 'QUAR_33' time 7000 flag 1  
279@ = 1 

:QUARRY_17798
if 
  279@ == 1 
else_jump @QUARRY_17855 
if 
  400.0 > 78@ 
else_jump @QUARRY_17855 
03D5: remove_text 'QUAR_33'  
279@ = 0 

:QUARRY_17855
if 
  0 >= " + _8172 + @" 
else_jump @QUARRY_17889 
37@ = 1 
45@ = 14 
return 

:QUARRY_17889
if 
  35@ == 1 
else_jump @QUARRY_17948 
if 
  278@ == 1 
else_jump @QUARRY_17948 
0085: 172@ = 46@ 
172@ += 2000 
35@ += 1 

:QUARRY_17948
if 
  35@ == 2 
else_jump @QUARRY_17992 
if 
001D:   46@ > 172@ 
else_jump @QUARRY_17992 
35@ = 99 

:QUARRY_17992
if 
   Actor.InCar(" + PlayerActor + @", 88@)
else_jump @QUARRY_18050 
if 
075C:   marker 126@ enabled 
else_jump @QUARRY_18043 
Marker.Disable(126@)
03D5: remove_text 'QUAR_36'  

:QUARRY_18043
jump @QUARRY_18097 

:QUARRY_18050
if 
875C:   not marker 126@ enabled 
else_jump @QUARRY_18097 
126@ = Marker.CreateAboveCar(88@)
07E0: set_marker 126@ type_to 1 
00BC: show_text_highpriority GXT 'QUAR_36' time 5000 flag 1  

:QUARRY_18097
if 
   not Car.Wrecked(91@)
else_jump @QUARRY_18156 
50@ = Car.Health(91@)
if and
  50@ > 300 
  800 >= 50@ 
else_jump @QUARRY_18156 
Car.Health(91@) = 300

:QUARRY_18156
if 
   not Car.Wrecked(91@)
else_jump @QUARRY_18431 
50@ = Car.Health(91@)
if 
  250 >= 50@ 
else_jump @QUARRY_18213 
" + _8173 + @" = 0 
jump @QUARRY_18431 

:QUARRY_18213
if 
  50@ == 1000 
else_jump @QUARRY_18246 
" + _8173 + @" = 100 
jump @QUARRY_18431 

:QUARRY_18246
if 
  50@ == 300 
else_jump @QUARRY_18279 
" + _8173 + @" = 20 
jump @QUARRY_18431 

:QUARRY_18279
if 
  300 > 50@ 
else_jump @QUARRY_18350 
51@ = 300 
0062: 51@ -= 50@ 
" + _8173 + @" = 50 
0066: " + _8173 + @" -= 51@ 
" + _8173 + @" *= 20 
" + _8173 + @" /= 50 
jump @QUARRY_18431 

:QUARRY_18350
if 
  800 > 50@ 
else_jump @QUARRY_18377 
50@ = 800 

:QUARRY_18377
51@ = 1000 
0062: 51@ -= 50@ 
" + _8173 + @" = 200 
0066: " + _8173 + @" -= 51@ 
" + _8173 + @" *= 80 
" + _8173 + @" /= 200 
" + _8173 + @" += 20 

:QUARRY_18431
if 
   not Car.Wrecked(91@)
else_jump @QUARRY_18872 
48@ = 0 

:QUARRY_18454
if 
03CA:   object 94@(48@,7i) exists 
else_jump @QUARRY_18851 
if 
8685:   not object 94@(48@,7i) attached 
else_jump @QUARRY_18851 
0871: init_jump_table 48@ total_jumps 6 default_jump 0 @QUARRY_18851 jumps 0 @QUARRY_18557 1 @QUARRY_18606 2 @QUARRY_18655 3 @QUARRY_18704 4 @QUARRY_18753 5 @QUARRY_18802 -1 @QUARRY_18851 

:QUARRY_18557
0681: attach_object 94@(48@,7i) to_car 91@ with_offset 0.5 -0.7 0.7 rotation 90.0 0.0 0.0 
jump @QUARRY_18851 

:QUARRY_18606
0681: attach_object 94@(48@,7i) to_car 91@ with_offset -0.5 -0.7 0.7 rotation 90.0 0.0 0.0 
jump @QUARRY_18851 

:QUARRY_18655
0681: attach_object 94@(48@,7i) to_car 91@ with_offset 0.5 -1.7 0.73 rotation 90.0 0.0 0.0 
jump @QUARRY_18851 

:QUARRY_18704
0681: attach_object 94@(48@,7i) to_car 91@ with_offset -0.5 -1.7 0.73 rotation 90.0 0.0 0.0 
jump @QUARRY_18851 

:QUARRY_18753
0681: attach_object 94@(48@,7i) to_car 91@ with_offset 0.5 -2.7 0.76 rotation 90.0 0.0 0.0 
jump @QUARRY_18851 

:QUARRY_18802
0681: attach_object 94@(48@,7i) to_car 91@ with_offset -0.5 -2.7 0.76 rotation 90.0 0.0 0.0 
jump @QUARRY_18851 

:QUARRY_18851
48@ += 1 
  48@ >= 6 
else_jump @QUARRY_18454 

:QUARRY_18872
if 
  35@ == 99 
else_jump @QUARRY_18897 
gosub @QUARRY_21060 

:QUARRY_18897
return 

:QUARRY_18899
if 
  35@ == 0 
else_jump @QUARRY_18952 
Player.CanMove(" + PlayerChar + @") = False
0085: 183@ = 46@ 
183@ += 5000 
014F: stop_timer " + _8172 + @" 
35@ += 1 

:QUARRY_18952
if 
  35@ == 1 
else_jump @QUARRY_19019 
if 
001D:   46@ > 183@ 
else_jump @QUARRY_19019 
fade 0 500 
0085: 183@ = 46@ 
183@ += 500 
35@ += 1 

:QUARRY_19019
if 
  35@ == 2 
else_jump @QUARRY_19190 
if and
001D:   46@ > 183@ 
   not fading 
else_jump @QUARRY_19190" );
_1931.create( 818.2578, 853.8873, 10.8059, 2000, 2000 );
AppendLine( @"02A3: enable_widescreen 1 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
Camera.SetAtPos(818.2578, 853.8873, 10.8059)
Camera.SetPosition(849.6491, 839.9428, 42.7363, 0.0, 0.0, 0.0)
Camera.PointAt(848.7661, 840.1115, 42.2983, 2)
0085: 183@ = 46@ 
183@ += 2000 
35@ += 1 

:QUARRY_19190
if 
  35@ == 3 
else_jump @QUARRY_19273 
if 
001D:   46@ > 183@ 
else_jump @QUARRY_19273 
fade 1 500 
00BA: show_text_styled GXT 'ASS_ACQ' time 5000 style 6  
0085: 183@ = 46@ 
183@ += 5000 
35@ += 1 

:QUARRY_19273
if 
  35@ == 4 
else_jump @QUARRY_19403 
if 
001D:   46@ > 183@ 
else_jump @QUARRY_19403 
Camera.SetPosition(825.0984, 855.4503, 13.577, 0.0, 0.0, 0.0)
Camera.PointAt(824.1995, 855.1732, 13.2376, 2)
01E5: show_text_1number_highpriority GXT 'ASS_LUV' number 2000 time 6000 flag 1  
0085: 183@ = 46@ 
183@ += 6000 
35@ += 1 

:QUARRY_19403
if 
  35@ == 5 
else_jump @QUARRY_19470 
if 
001D:   46@ > 183@ 
else_jump @QUARRY_19470 
fade 0 500 
0085: 183@ = 46@ 
183@ += 500 
35@ += 1 

:QUARRY_19470
if 
  35@ == 6 
else_jump @QUARRY_19565 
if and
001D:   46@ > 183@ 
   not fading 
else_jump @QUARRY_19565 
Actor.StorePos(" + PlayerActor + @", 59@, 60@, 61@)
Camera.SetAtPos(59@, 60@, 61@)
02A3: enable_widescreen 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0085: 183@ = 46@ 
183@ += 2000 
35@ += 1 

:QUARRY_19565
if 
  35@ == 7 
else_jump @QUARRY_19670 
if 
001D:   46@ > 183@ 
else_jump @QUARRY_19670 
02FD: show_text_2numbers_lowpriority GXT 'QUAR_P7' numbers 210@ 211@ time 10000 flag 1  
00BB: show_text_lowpriority GXT 'QUAR_H3' time 7000 flag 1  
fade 1 500 
0085: 183@ = 46@ 
183@ += 500 
35@ += 1 

:QUARRY_19670
if 
  35@ == 8 
else_jump @QUARRY_19734 
if and
001D:   46@ > 183@ 
   not fading 
else_jump @QUARRY_19734 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
03F4: set_all_cars_apply_damage_rules 1 
Player.CanMove(" + PlayerChar + @") = True
35@ = 99 

:QUARRY_19734
if 
  35@ == 99 
else_jump @QUARRY_19759 
gosub @QUARRY_21060 

:QUARRY_19759
return 

:QUARRY_19761
215@ = 808.4078 
216@ = 841.9887 
217@ = 8.6694 
018A: 131@ = create_checkpoint_at 215@ 216@ 217@ 
238@ = 1 
return 

:QUARRY_19814
215@ = 371.5454 
216@ = 978.1724 
217@ = 28.521 
018A: 132@ = create_checkpoint_at 215@ 216@ 217@ 
239@ = 1 
return 
00BF: 200@ = current_time_hours, 201@ = current_time_minutes 
0085: 50@ = 202@ 
50@ *= 60 
005A: 50@ += 203@ 
50@ *= 1000 
0085: 173@ = 50@ 
005A: 173@ += 46@ 
005A: 201@ += 203@ 
if 
  201@ >= 60 
else_jump @QUARRY_19962 
200@ += 1 
201@ -= 60 

:QUARRY_19962
005A: 200@ += 202@ 

:QUARRY_19970
if 
  200@ >= 24 
else_jump @QUARRY_20002 
200@ -= 24 
jump @QUARRY_19970 

:QUARRY_20002
80@ = 0 
if 
  201@ > 45 
else_jump @QUARRY_20104 
50@ = 60 
0062: 50@ -= 201@ 
201@ = 0 
200@ += 1 
if 
  200@ == 24 
else_jump @QUARRY_20081 
200@ = 0 

:QUARRY_20081
50@ *= 1000 
005A: 173@ += 50@ 
80@ = 1 

:QUARRY_20104
if 
  80@ == 0 
else_jump @QUARRY_20192 
if and
  201@ > 30 
  45 > 201@ 
else_jump @QUARRY_20192 
50@ = 45 
0062: 50@ -= 201@ 
201@ = 45 
50@ *= 1000 
005A: 173@ += 50@ 
80@ = 1 

:QUARRY_20192
if 
  80@ == 0 
else_jump @QUARRY_20280 
if and
  201@ > 15 
  30 > 201@ 
else_jump @QUARRY_20280 
50@ = 30 
0062: 50@ -= 201@ 
201@ = 30 
50@ *= 1000 
005A: 173@ += 50@ 
80@ = 1 

:QUARRY_20280
if 
  80@ == 0 
else_jump @QUARRY_20368 
if and
  201@ > 0 
  15 > 201@ 
else_jump @QUARRY_20368 
50@ = 15 
0062: 50@ -= 201@ 
201@ = 15 
50@ *= 1000 
005A: 173@ += 50@ 
80@ = 1 

:QUARRY_20368
0085: 50@ = 200@ 
50@ *= 60 
005A: 50@ += 201@ 
50@ *= 1000 
008A: " + _8172 + @" = 50@ 
return 

:QUARRY_20409
if 
0736:   is_keyboard_key_just_pressed 32 
else_jump @QUARRY_20458 
47@ += 1 
if 
  47@ > 2 
else_jump @QUARRY_20456 
47@ = 0 

:QUARRY_20456
086A: NOP 

:QUARRY_20458
if 
  47@ == 1 
else_jump @QUARRY_20585 
008A: " + tmp_Quarry_Stage + @"[0] = 34@ 
008A: " + tmp_Quarry_Stage + @"[1] = 35@ 
008A: " + tmp_Quarry_Stage + @"[2] = 46@ 
" + tmp_Quarry_Stage + @"[3] = 0 
" + tmp_Quarry_Stage + @"[4] = 0 
" + tmp_Quarry_Stage + @"[5] = 0 
" + tmp_Quarry_Stage + @"[6] = 0 
" + tmp_Quarry_Stage + @"[7] = 0 
065D: NOP " + tmp_Quarry_Stage + @"[0] ""M_STAGE"" 
065D: NOP " + tmp_Quarry_Stage + @"[1] ""M_GOALS"" 
065D: NOP " + tmp_Quarry_Stage + @"[2] ""M_MISSION_TIMER"" 

:QUARRY_20585
if 
  47@ == 2 
else_jump @QUARRY_20786 
" + tmp_Quarry_Stage + @"[7] = 0 
48@ = 0 

:QUARRY_20617
0084: " + tmp_Quarry_Stage + @"(48@,8i) = " + tmp_8174 + @"(48@,7i) 
0058: " + tmp_Quarry_Stage + @"[7] += " + tmp_8174 + @"(48@,7i) 
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_20617 
065D: NOP " + tmp_Quarry_Stage + @"[0] ""ROCKFALL"" 
065D: NOP " + tmp_Quarry_Stage + @"[1] ""SABOTAGE"" 
065D: NOP " + tmp_Quarry_Stage + @"[2] ""DESTROY."" 
065D: NOP " + tmp_Quarry_Stage + @"[3] ""REMOVAL."" 
065D: NOP " + tmp_Quarry_Stage + @"[4] ""DELIVERY"" 
065D: NOP " + tmp_Quarry_Stage + @"[5] ""SPILLAGE"" 
065D: NOP " + tmp_Quarry_Stage + @"[6] ""BURIAL.."" 
065D: NOP " + tmp_Quarry_Stage + @"[7] ""TOTAL..."" 

:QUARRY_20786
if 
0736:   is_keyboard_key_just_pressed 98 
else_jump @QUARRY_20808 
38@ = 1 

:QUARRY_20808
if 
0736:   is_keyboard_key_just_pressed 80 
else_jump @QUARRY_20896 
if 
  39@ == 0 
else_jump @QUARRY_20871 
39@ = 1 
0662: printstring ""LEVEL_PAUSED"" 
jump @QUARRY_20896 

:QUARRY_20871
39@ = 0 
0662: printstring ""LEVEL_UNPAUSED"" 

:QUARRY_20896
return 

:QUARRY_20898
if 
0736:   is_keyboard_key_just_pressed 83 
else_jump @QUARRY_20922 
36@ = 1 
return 

:QUARRY_20922
if 
0736:   is_keyboard_key_just_pressed 77 
else_jump @QUARRY_20968 
" + Quarry_Missions_Passed + @" += 1 
0663: printint ""MISSIONS_PASSED"" " + Quarry_Missions_Passed + @" 
return 

:QUARRY_20968
if 
8736:   not is_keyboard_key_just_pressed 74 
else_jump @QUARRY_20985 
return 

:QUARRY_20985
return 

:QUARRY_20987
41@ += 1 
if 
  41@ > 9 
else_jump @QUARRY_21019 
41@ = 0 

:QUARRY_21019
return 

:QUARRY_21021
01BD: 42@ = current_time_in_ms 
0085: 44@ = 42@ 
0062: 44@ -= 43@ 
0085: 43@ = 42@ 
005A: 46@ += 44@ 
return 

:QUARRY_21060
34@ += 1 
35@ = 0 
32@ = 0 
33@ = 0 
return 

:QUARRY_21090
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @QUARRY_21117 
wait 0 
jump @QUARRY_21090 

:QUARRY_21117
Player.CanMove(" + PlayerChar + @") = False
wait 1000 
fade 0 1000 

:QUARRY_21136
if 
fading 
else_jump @QUARRY_21160 
wait 0 
jump @QUARRY_21136 

:QUARRY_21160
if 
  " + Mission_Quarry_Passed + @" == 0 
else_jump @QUARRY_21378 
if 
  " + Quarry_Missions_Passed + @" == 0 
else_jump @QUARRY_21378 
50@ = 1 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 211 
50@ = 2 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 300 
50@ = 3 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 481 
50@ = 4 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 241 
50@ = 5 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 181 
50@ = 6 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 181 
50@ = 7 
50@ -= 1 
" + tmp_8174 + @"(50@,7i) = 481 

:QUARRY_21378
0395: clear_area 0 at " + _2352 + @" " + _2353 + @" " + _2354 + @" radius 1000.0 
Camera.SetAtPos(" + _2352 + @", " + _2353 + @", " + _2354 + @")
Actor.PutAt(" + PlayerActor + @", " + _2352 + @", " + _2353 + @", " + _2354 + @")
Actor.Angle(" + PlayerActor + @") = 90.0
Camera.SetBehindPlayer
wait 500 
008B: 50@ = " + Quarry_Missions_Passed + @" 

:QUARRY_21446
if 
  50@ >= 7 
else_jump @QUARRY_21478 
50@ -= 7 
jump @QUARRY_21446 

:QUARRY_21478
0085: 198@ = 50@ 
198@ += 1 
gosub @QUARRY_21635 
207@ = 0 
014C: set_parked_car_generator " + carPark_2759 + @" cars_to_generate_to 0 
014C: set_parked_car_generator " + carPark_2760 + @" cars_to_generate_to 0 
wait 1500 
0A2D: hide_styled_text_while_fading 1 
0169: set_fade_color_RGB 0 0 0 
fade 1 1000 

:QUARRY_21545
if 
fading 
else_jump @QUARRY_21569 
wait 0 
jump @QUARRY_21545 

:QUARRY_21569
if 
  " + Mission_Quarry_Passed + @" == 1 
else_jump @QUARRY_21598 
03E5: show_text_box 'QUAR_H2'  

:QUARRY_21598
Player.CanMove(" + PlayerChar + @") = True
45@ = 0 
32@ = 0 
33@ = 0 
35@ = 0 
return 

:QUARRY_21635
0871: init_jump_table 198@ total_jumps 7 default_jump 1 @QUARRY_21796 jumps 1 @QUARRY_21698 2 @QUARRY_21712 3 @QUARRY_21782 4 @QUARRY_21726 5 @QUARRY_21740 6 @QUARRY_21754 7 @QUARRY_21768 

:QUARRY_21698
gosub @QUARRY_22158 
jump @QUARRY_21825 

:QUARRY_21712
gosub @QUARRY_22482 
jump @QUARRY_21825 

:QUARRY_21726
gosub @QUARRY_22957 
jump @QUARRY_21825 

:QUARRY_21740
gosub @QUARRY_23543 
jump @QUARRY_21825 

:QUARRY_21754
gosub @QUARRY_24497 
jump @QUARRY_21825 

:QUARRY_21768
gosub @QUARRY_21827 
jump @QUARRY_21825 

:QUARRY_21782
gosub @QUARRY_25306 
jump @QUARRY_21825 

:QUARRY_21796
0662: printstring ""UNKNOWN_QUARRY_MISSION_ID"" 

:QUARRY_21825
return 

:QUARRY_21827
34@ = 1 
Model.Load(#SANCHEZ)
Model.Load(#DOZER)
Model.Load(#DUMPER)
Model.Load(#DEAD_TIED_COP)
Model.Load(#COPBIKE)
Model.Load(#CR_AMMOBOX)
038B: load_requested_models 

:QUARRY_21866
if or
   not Model.Available(#SANCHEZ)
   not Model.Available(#DOZER)
   not Model.Available(#DUMPER)
   not Model.Available(#DEAD_TIED_COP)
   not Model.Available(#COPBIKE)
   not Model.Available(#CR_AMMOBOX)
else_jump @QUARRY_21918 
wait 0 
jump @QUARRY_21866 

:QUARRY_21918
86@ = Car.Create(#SANCHEZ, 819.7281, 858.3189, 11.0469)
Car.Angle(86@) = 291.4761
87@ = Car.Create(#DOZER, 653.1636, 879.9844, -42.5799)
Car.Angle(87@) = 119.7783
88@ = Car.Create(#DUMPER, 717.0151, 938.3721, -19.7314)
Car.Angle(88@) = 38.1129
93@ = Object.Create(#CR_AMMOBOX, 720.5391, 922.5157, -19.8436)
Object.CollisionDetection(93@) = False
0750: set_object 93@ visibility 0 
0681: attach_object 93@ to_car 88@ with_offset 0.0 -1.7 1.5 rotation 0.0 0.0 0.0 
92@ = Object.Create(#DEAD_TIED_COP, 606.9487, 933.0876, -38.5322)
Object.ToggleInMovingList(92@) = True
89@ = Car.Create(#COPBIKE, 560.3003, 844.9364, -13.0258)
03F5: set_car 89@ apply_damage_rules 0 
06D0: enable_emergency_traffic 0 
return 

:QUARRY_22158
34@ = 5 
Model.Load(#DOZER)
Model.Load(#DYN_QUARRYROCK03)
038B: load_requested_models 

:QUARRY_22177
if or
   not Model.Available(#DOZER)
   not Model.Available(#DYN_QUARRYROCK03)
else_jump @QUARRY_22209 
wait 0 
jump @QUARRY_22177 

:QUARRY_22209
87@ = Car.Create(#DOZER, 816.4832, 845.8509, 9.4934)
Car.Angle(87@) = 115.4882
50@ = 0 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 771.6403, 836.2275, 4.8965)
50@ += 1 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 751.6732, 944.9977, 4.8593)
50@ += 1 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 538.9102, 985.6403, -8.5887)
50@ += 1 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 680.5322, 963.4501, -13.6607)
50@ += 1 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 516.8391, 928.7185, -27.6183)
50@ += 1 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 522.6153, 828.3048, -27.1838)
50@ += 1 
94@(50@,7i) = Object.Create(#DYN_QUARRYROCK03, 646.7208, 752.2311, -12.1482)
return 

:QUARRY_22482
34@ = 7 
Model.Load(#DOZER)
Model.Load(#KB_BARREL)
038B: load_requested_models 

:QUARRY_22501
if or
   not Model.Available(#DOZER)
   not Model.Available(#KB_BARREL)
else_jump @QUARRY_22533 
wait 0 
jump @QUARRY_22501 

:QUARRY_22533
87@ = Car.Create(#DOZER, 816.4832, 845.8509, 9.4934)
Car.Angle(87@) = 115.4882
50@ = 0 
101@(50@,10i) = Object.Create(#KB_BARREL, 817.0658, 865.5903, 11.0469)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 714.5327, 920.0583, -19.6787)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 632.2825, 895.8612, -43.9534)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 675.7952, 841.8704, -43.9609)
51@ = 2 
51@ -= 1 
008B: 50@ = " + tmp_8174 + @"(51@,7i) 
50@ *= 100 
48@ = 0 

:QUARRY_22742
0871: init_jump_table 48@ total_jumps 4 default_jump 0 @QUARRY_22930 jumps 0 @QUARRY_22805 1 @QUARRY_22835 2 @QUARRY_22865 3 @QUARRY_22895 -1 @QUARRY_22930 -1 @QUARRY_22930 -1 @QUARRY_22930 

:QUARRY_22805
0085: 174@(48@,4i) = 50@ 
174@(48@,4i) *= 3 
jump @QUARRY_22930 

:QUARRY_22835
0085: 174@(48@,4i) = 50@ 
174@(48@,4i) *= 6 
jump @QUARRY_22930 

:QUARRY_22865
0085: 174@(48@,4i) = 50@ 
174@(48@,4i) *= 8 
jump @QUARRY_22930 

:QUARRY_22895
008B: 174@(48@,4i) = " + tmp_8174 + @"(51@,7i) 
174@(48@,4i) *= 1000 
jump @QUARRY_22930 

:QUARRY_22930
48@ += 1 
  48@ >= 4 
else_jump @QUARRY_22742 
06D0: enable_emergency_traffic 0 
return 

:QUARRY_22957
34@ = 9 
Model.Load(#DUMPER)
Model.Load(#DEAD_TIED_COP)
Model.Load(#SANCHEZ)
Model.Load(#CM_BOX)
Model.Load(#BLACKBAG2)
Model.Load(#DYN_WOODPILE)
Model.Load(#DYN_WOODPILE2)
038B: load_requested_models 

:QUARRY_23001
if or
   not Model.Available(#DUMPER)
   not Model.Available(#DEAD_TIED_COP)
   not Model.Available(#SANCHEZ)
else_jump @QUARRY_23038 
wait 0 
jump @QUARRY_23001 

:QUARRY_23038
if or
   not Model.Available(#CM_BOX)
   not Model.Available(#BLACKBAG2)
   not Model.Available(#DYN_WOODPILE)
   not Model.Available(#DYN_WOODPILE2)
else_jump @QUARRY_23080 
wait 0 
jump @QUARRY_23038 

:QUARRY_23080
88@ = Car.Create(#DUMPER, 355.8632, 895.6545, 19.399)
Car.Angle(88@) = 342.1892
86@ = Car.Create(#SANCHEZ, 819.7281, 858.3189, 11.0469)
Car.Angle(86@) = 291.4761
50@ = 0 
111@(50@,3i) = Object.Create(#DEAD_TIED_COP, 355.8632, 894.6545, 24.2254)
0208: 75@ = random_float_in_ranges 0.0 180.0 
75@ -= 90.0 
if 
  0.0 > 75@ 
else_jump @QUARRY_23236 
75@ += 360.0 

:QUARRY_23236
0681: attach_object 111@(50@,3i) to_car 88@ with_offset 0.5 -0.7 0.7 rotation 90.0 75@ 75@ 
50@ += 1 
111@(50@,3i) = Object.Create(#DEAD_TIED_COP, 355.8632, 895.6545, 24.5629)
0208: 75@ = random_float_in_ranges 0.0 180.0 
75@ -= 90.0 
if 
  0.0 > 75@ 
else_jump @QUARRY_23364 
75@ += 360.0 

:QUARRY_23364
0681: attach_object 111@(50@,3i) to_car 88@ with_offset -0.5 -1.7 0.73 rotation 90.0 75@ 75@ 
50@ += 1 
111@(50@,3i) = Object.Create(#DEAD_TIED_COP, 355.8632, 896.6545, 24.8877)
0208: 75@ = random_float_in_ranges 0.0 180.0 
75@ -= 90.0 
if 
  0.0 > 75@ 
else_jump @QUARRY_23492 
75@ += 360.0 

:QUARRY_23492
0681: attach_object 111@(50@,3i) to_car 88@ with_offset 0.5 -2.7 0.76 rotation 90.0 75@ 75@ 
01EB: set_traffic_density_multiplier_to 3.0 
06D0: enable_emergency_traffic 0 
return 

:QUARRY_23543
34@ = 12 
Model.Load(#DUMPER)
Model.Load(#KB_BARREL)
038B: load_requested_models 

:QUARRY_23562
if or
   not Model.Available(#DUMPER)
   not Model.Available(#KB_BARREL)
else_jump @QUARRY_23594 
wait 0 
jump @QUARRY_23562 

:QUARRY_23594
88@ = Car.Create(#DUMPER, 816.4832, 845.8509, 9.4934)
Car.Angle(88@) = 295.4882
50@ = 0 
101@(50@,10i) = Object.Create(#KB_BARREL, 815.4841, 846.2587, 15.0409)
0681: attach_object 101@(50@,10i) to_car 88@ with_offset 0.5 -0.7 0.9 rotation 90.0 0.0 0.0 
Object.SetImmunities(101@(50@,10i), 0, 0, 0, 1, 0)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 816.6973, 844.8737, 15.046)
0681: attach_object 101@(50@,10i) to_car 88@ with_offset -0.5 -0.7 0.9 rotation 90.0 0.0 0.0 
Object.SetImmunities(101@(50@,10i), 0, 0, 0, 1, 0)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 814.2406, 845.8572, 14.9014)
0681: attach_object 101@(50@,10i) to_car 88@ with_offset 0.5 -1.7 0.93 rotation 90.0 0.0 0.0 
Object.SetImmunities(101@(50@,10i), 0, 0, 0, 1, 0)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 815.048, 844.0368, 14.8892)
0681: attach_object 101@(50@,10i) to_car 88@ with_offset -0.5 -1.7 0.93 rotation 90.0 0.0 0.0 
Object.SetImmunities(101@(50@,10i), 0, 0, 0, 1, 0)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 813.2042, 843.0317, 14.7114)
0681: attach_object 101@(50@,10i) to_car 88@ with_offset 0.5 -2.7 0.96 rotation 90.0 0.0 0.0 
Object.SetImmunities(101@(50@,10i), 0, 0, 0, 1, 0)
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 813.2919, 845.4581, 14.8038)
0681: attach_object 101@(50@,10i) to_car 88@ with_offset -0.5 -2.7 0.96 rotation 90.0 0.0 0.0 
Object.SetImmunities(101@(50@,10i), 0, 0, 0, 1, 0)
50@ = 0 
122@(50@,3i) = Object.Create(#CR_AMMOBOX, 815.4841, 846.2587, 15.0409)
Object.CollisionDetection(122@(50@,3i)) = False
0750: set_object 122@(50@,3i) visibility 0 
0681: attach_object 122@(50@,3i) to_car 88@ with_offset -1.0 -5.0 0.3 rotation 0.0 0.0 0.0 
50@ += 1 
122@(50@,3i) = Object.Create(#CR_AMMOBOX, 816.6973, 844.8737, 15.046)
Object.CollisionDetection(122@(50@,3i)) = False
0750: set_object 122@(50@,3i) visibility 0 
0681: attach_object 122@(50@,3i) to_car 88@ with_offset 0.0 -5.0 0.3 rotation 0.0 0.0 0.0 
50@ += 1 
122@(50@,3i) = Object.Create(#CR_AMMOBOX, 815.048, 844.0368, 14.8892)
Object.CollisionDetection(122@(50@,3i)) = False
0750: set_object 122@(50@,3i) visibility 0 
0681: attach_object 122@(50@,3i) to_car 88@ with_offset 1.0 -5.0 0.3 rotation 0.0 0.0 0.0 
06D0: enable_emergency_traffic 0 
return 

:QUARRY_24497
34@ = 14 
Model.Load(#DOZER)
Model.Load(#KB_BARREL)
Model.Load(#STREAK)
Model.Load(#STREAKC)
038B: load_requested_models 

:QUARRY_24526
if or
   not Model.Available(#DOZER)
   not Model.Available(#KB_BARREL)
   not Model.Available(#STREAK)
   not Model.Available(#STREAKC)
else_jump @QUARRY_24568 
wait 0 
jump @QUARRY_24526 

:QUARRY_24568
87@ = Car.Create(#DOZER, 816.4832, 845.8509, 9.4934)
Car.Angle(87@) = 295.4882
06D8: 90@ = create_train_at 832.5291 2669.716 19.8594 type 11 direction 0 
06DC: set_train 90@ acc 0.0 
06DD: set_train 90@ speed 0.0 
121@ = Object.Create(#CR_AMMOBOX, 816.4832, 848.8509, 9.4934)
Object.CollisionDetection(121@) = False
0750: set_object 121@ visibility 0 
0681: attach_object 121@ to_car 90@ with_offset 0.0 9.0 -1.8 rotation 0.0 0.0 0.0 
50@ = 0 
101@(50@,10i) = Object.Create(#KB_BARREL, 744.1446, 1583.6, 7.5408)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 0.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 743.0427, 1602.768, 7.1368)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 78.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 743.5758, 1616.749, 6.8536)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 64.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 742.6569, 1653.42, 6.158)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 36.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 743.8057, 1671.523, 5.8467)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 14.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 742.5768, 1700.305, 5.4186)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 128.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 743.4429, 1730.141, 5.0731)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 96.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 742.0187, 1765.321, 4.6566)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 65.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 742.176, 1812.375, 4.3281)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 170.0 0.0 
50@ += 1 
101@(50@,10i) = Object.Create(#KB_BARREL, 742.7178, 1869.991, 4.3281)
0453: set_object 101@(48@,10i) XYZ_rotation 0.0 143.0 0.0 
06D7: enable_train_traffic 0 
return 

:QUARRY_25306
34@ = 16 
Model.Load(#DUMPER)
Model.Load(#BMYBE)
Model.Load(#CR_GUNCRATE)
038B: load_requested_models 

:QUARRY_25329
if or
   not Model.Available(#DUMPER)
   not Model.Available(#BMYBE)
   not Model.Available(#CR_GUNCRATE)
else_jump @QUARRY_25365 
wait 0 
jump @QUARRY_25329 

:QUARRY_25365
88@ = Car.Create(#DUMPER, 816.4832, 845.8509, 9.4934)
Car.Angle(88@) = 295.4882
91@ = Car.Create(#DUMPER, 812.4955, 1144.567, 27.3445)
Car.Angle(91@) = 116.9096
Car.DoorStatus(91@) = 2
85@ = Actor.CreateAsDriver(CivMale, #BMYBE, 91@)
50@ = 0 
94@(50@,7i) = Object.Create(#CR_GUNCRATE, 815.4841, 846.2587, 15.0409)
0681: attach_object 94@(50@,7i) to_car 91@ with_offset 0.5 -0.7 0.7 rotation 90.0 0.0 0.0 
50@ += 1 
94@(50@,7i) = Object.Create(#CR_GUNCRATE, 816.6973, 844.8737, 15.046)
0681: attach_object 94@(50@,7i) to_car 91@ with_offset -0.5 -0.7 0.7 rotation 90.0 0.0 0.0 
50@ += 1 
94@(50@,7i) = Object.Create(#CR_GUNCRATE, 814.2406, 845.8572, 14.9014)
0681: attach_object 94@(50@,7i) to_car 91@ with_offset 0.5 -1.7 0.73 rotation 90.0 0.0 0.0 
50@ += 1 
94@(50@,7i) = Object.Create(#CR_GUNCRATE, 815.048, 844.0368, 14.8892)
0681: attach_object 94@(50@,7i) to_car 91@ with_offset -0.5 -1.7 0.73 rotation 90.0 0.0 0.0 
50@ += 1 
94@(50@,7i) = Object.Create(#CR_GUNCRATE, 813.2042, 843.0317, 14.7114)
0681: attach_object 94@(50@,7i) to_car 91@ with_offset 0.5 -2.7 0.76 rotation 90.0 0.0 0.0 
50@ += 1 
94@(50@,7i) = Object.Create(#CR_GUNCRATE, 813.2919, 845.4581, 14.8038)
0681: attach_object 94@(50@,7i) to_car 91@ with_offset -0.5 -2.7 0.76 rotation 90.0 0.0 0.0 
06D0: enable_emergency_traffic 0 
return 

:QUARRY_25912
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
03EB: clear_small_messages_only 
0871: init_jump_table 45@ total_jumps 14 default_jump 0 @QUARRY_26380 jumps 1 @QUARRY_26081 2 @QUARRY_26104 3 @QUARRY_26127 4 @QUARRY_26150 5 @QUARRY_26173 6 @QUARRY_26196 7 @QUARRY_26219 
0872: jump_table_jumps 8 @QUARRY_26242 9 @QUARRY_26265 10 @QUARRY_26058 11 @QUARRY_26288 12 @QUARRY_26311 13 @QUARRY_26334 14 @QUARRY_26357 -1 @QUARRY_26380 -1 @QUARRY_26380 

:QUARRY_26058
00BC: show_text_highpriority GXT 'QUAR_F0' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26081
00BC: show_text_highpriority GXT 'QUAR_F1' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26104
00BC: show_text_highpriority GXT 'QUAR_F2' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26127
00BC: show_text_highpriority GXT 'QUAR_F3' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26150
00BC: show_text_highpriority GXT 'QUAR_F4' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26173
00BC: show_text_highpriority GXT 'QUAR_F5' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26196
00BC: show_text_highpriority GXT 'QUAR_F6' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26219
00BC: show_text_highpriority GXT 'QUAR_F7' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26242
00BC: show_text_highpriority GXT 'QUAR_F8' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26265
00BC: show_text_highpriority GXT 'QUAR_F9' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26288
00BC: show_text_highpriority GXT 'QUAR_FA' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26311
00BC: show_text_highpriority GXT 'QUAR_FB' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26334
00BC: show_text_highpriority GXT 'QUAR_FC' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26357
00BC: show_text_highpriority GXT 'QUAR_FD' time 5000 flag 1  
jump @QUARRY_26380 

:QUARRY_26380
return 

:QUARRY_26382
if 
  207@ == 0 
else_jump @QUARRY_26423 
0085: 50@ = 46@ 
0062: 50@ -= 206@ 
jump @QUARRY_26439 

:QUARRY_26423
0085: 50@ = 207@ 
0062: 50@ -= 206@ 

:QUARRY_26439
0085: 51@ = 50@ 
51@ /= 1000 
0085: 52@ = 51@ 
52@ *= 1000 
0062: 50@ -= 52@ 
if 
  50@ > 50 
else_jump @QUARRY_26504 
51@ += 1 

:QUARRY_26504
293@ = 0 
294@ = 0 
if 
003C:   " + tmp_8174 + @"(" + Quarry_Missions_Passed + @",7i) == 51@ 
else_jump @QUARRY_26555 
293@ = 1 
jump @QUARRY_26585 

:QUARRY_26555
if 
001E:   " + tmp_8174 + @"(" + Quarry_Missions_Passed + @",7i) > 51@ 
else_jump @QUARRY_26585 
294@ = 1 

:QUARRY_26585
if 
  294@ == 1 
else_jump @QUARRY_26615 
008A: " + tmp_8174 + @"(" + Quarry_Missions_Passed + @",7i) = 51@ 

:QUARRY_26615
if and
  " + Mission_Quarry_Passed + @" == 1 
  294@ == 1 
else_jump @QUARRY_26686 
0085: 208@ = 51@ 
208@ /= 60 
0085: 50@ = 208@ 
50@ *= 60 
0085: 209@ = 51@ 
0062: 209@ -= 50@ 

:QUARRY_26686
50@ = 0 
if 
  " + Mission_Quarry_Passed + @" == 1 
else_jump @QUARRY_26751 
48@ = 0 

:QUARRY_26718
005C: 50@ += " + tmp_8174 + @"(48@,7i) 
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_26718 

:QUARRY_26751
0629: change_integer_stat 202 to 50@ 
if and
  " + Mission_Quarry_Passed + @" == 1 
  294@ == 1 
else_jump @QUARRY_26830 
0085: 210@ = 50@ 
210@ /= 60 
0085: 51@ = 210@ 
51@ *= 60 
0085: 211@ = 50@ 
0062: 211@ -= 51@ 

:QUARRY_26830
" + Quarry_Missions_Passed + @" += 1 
if 
  " + Mission_Quarry_Passed + @" == 0 
else_jump @QUARRY_27101 
0871: init_jump_table " + Quarry_Missions_Passed + @" total_jumps 7 default_jump 0 @QUARRY_27023 jumps 1 @QUARRY_26918 2 @QUARRY_26933 3 @QUARRY_26948 4 @QUARRY_26963 5 @QUARRY_26978 6 @QUARRY_26993 7 @QUARRY_27008 

:QUARRY_26918
50@ = 500 
jump @QUARRY_27023 

:QUARRY_26933
50@ = 1000 
jump @QUARRY_27023 

:QUARRY_26948
50@ = 2000 
jump @QUARRY_27023 

:QUARRY_26963
50@ = 3000 
jump @QUARRY_27023 

:QUARRY_26978
50@ = 5000 
jump @QUARRY_27023 

:QUARRY_26993
50@ = 7500 
jump @QUARRY_27023 

:QUARRY_27008
50@ = 10000 
jump @QUARRY_27023 

:QUARRY_27023
if 
  " + Quarry_Missions_Passed + @" == 7 
else_jump @QUARRY_27067 
01E3: show_text_1number_styled GXT 'M_PASS' number 50@ time 3000 style 1  
jump @QUARRY_27086 

:QUARRY_27067
01E3: show_text_1number_styled GXT 'M_PASS' number 50@ time 5000 style 1  

:QUARRY_27086
Player.Money(" + PlayerChar + @") += 50@
jump @QUARRY_27206 

:QUARRY_27101
01E3: show_text_1number_styled GXT 'M_PASSD' number 0 time 5000 style 1  
if 
  293@ == 1 
else_jump @QUARRY_27160 
00BC: show_text_highpriority GXT 'QUAR_P5' time 5000 flag 1  
jump @QUARRY_27206 

:QUARRY_27160
if 
  294@ == 1 
else_jump @QUARRY_27206 
0303: show_text_4numbers_highpriority GXT 'QUAR_P6' numbers 208@ 209@ 210@ 211@ time 10000 flag 1  

:QUARRY_27206
Player.ClearWantedLevel(" + PlayerChar + @")
if 
  " + Mission_Quarry_Passed + @" == 0 
else_jump @QUARRY_27483 
if 
  " + Quarry_Missions_Passed + @" == 1 
else_jump @QUARRY_27270 
00BC: show_text_highpriority GXT 'QUAR_P1' time 5000 flag 1  
jump @QUARRY_27476 

:QUARRY_27270
if 
  " + Quarry_Missions_Passed + @" == 7 
else_jump @QUARRY_27457 
0595: mission_complete 
0394: play_music 2 
" + Mission_Quarry_Passed + @" = 1 
" + Quarry_Missions_Passed + @" = 0 
00BA: show_text_styled GXT 'QUAR_P2' time 4000 style 4  
50@ = 0 
if 
  " + Mission_Quarry_Passed + @" == 1 
else_jump @QUARRY_27389 
48@ = 0 

:QUARRY_27356
005C: 50@ += " + tmp_8174 + @"(48@,7i) 
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_27356 

:QUARRY_27389
0629: change_integer_stat 202 to 50@ 
0085: 210@ = 50@ 
210@ /= 60 
0085: 51@ = 210@ 
51@ *= 60 
0085: 211@ = 50@ 
0062: 211@ -= 51@ 
295@ = 1 
jump @QUARRY_27476 

:QUARRY_27457
01E5: show_text_1number_highpriority GXT 'QUAR_P4' number " + Quarry_Missions_Passed + @" time 5000 flag 1  

:QUARRY_27476
jump @QUARRY_27508 

:QUARRY_27483
if 
  " + Quarry_Missions_Passed + @" == 7 
else_jump @QUARRY_27508 
" + Quarry_Missions_Passed + @" = 0 

:QUARRY_27508
if 
  " + Mission_Quarry_Passed + @" == 1 
else_jump @QUARRY_27540 
014C: set_parked_car_generator " + carPark_2759 + @" cars_to_generate_to 101 
014C: set_parked_car_generator " + carPark_2760 + @" cars_to_generate_to 101 

:QUARRY_27540
return 

:QUARRY_27542
Car.RemoveReferences(86@)
Car.RemoveReferences(87@)
Car.RemoveReferences(88@)
Car.RemoveReferences(89@)
Car.RemoveReferences(91@)
Actor.RemoveReferences(85@)
Object.RemoveReferences(92@)
Object.RemoveReferences(93@)
Object.RemoveReferences(121@)
07BE: remove_references_to_train 90@ 
48@ = 0 

:QUARRY_27599
Object.RemoveReferences(94@(48@,7i))
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_27599 
48@ = 0 

:QUARRY_27636
Object.RemoveReferences(101@(48@,10i))
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_27636 
48@ = 0 

:QUARRY_27673
Object.RemoveReferences(111@(48@,3i))
48@ += 1 
  48@ >= 3 
else_jump @QUARRY_27673 
48@ = 0 

:QUARRY_27710
Object.RemoveReferences(114@(48@,7i))
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_27710 
48@ = 0 

:QUARRY_27747
Object.RemoveReferences(122@(48@,3i))
48@ += 1 
  48@ >= 3 
else_jump @QUARRY_27747 
48@ = 0 

:QUARRY_27784
06D6: disable_racing_checkpoint 190@(48@,7i) 
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_27784 
06D6: disable_racing_checkpoint 197@ 
Marker.Disable(125@)
Marker.Disable(126@)
Marker.Disable(128@)
Marker.Disable(130@)
Marker.Disable(129@)
Marker.Disable(131@)
Marker.Disable(132@)
Marker.Disable(140@)
Marker.Disable(141@)
Marker.Disable(152@)
Marker.Disable(127@)
48@ = 0 

:QUARRY_27881
Marker.Disable(133@(48@,7i))
48@ += 1 
  48@ >= 7 
else_jump @QUARRY_27881 
48@ = 0 

:QUARRY_27918
Marker.Disable(142@(48@,10i))
48@ += 1 
  48@ >= 10 
else_jump @QUARRY_27918 
014F: stop_timer " + _8172 + @" 
0151: remove_status_text " + _8173 + @" 
0986: remove_references_to_all_fires 
if 
  262@ == 1 
else_jump @QUARRY_27980 
03E6: remove_text_box 

:QUARRY_27980
Model.Destroy(#SANCHEZ)
Model.Destroy(#DOZER)
Model.Destroy(#DUMPER)
Model.Destroy(#DYN_QUARRYROCK02)
Model.Destroy(#DEAD_TIED_COP)
Model.Destroy(#DYN_QUARRYROCK03)
Model.Destroy(#COPBIKE)
Model.Destroy(#CR_AMMOBOX)
Model.Destroy(#KB_BARREL)
Model.Destroy(#STREAK)
Model.Destroy(#STREAKC)
Model.Destroy(#BMYBE)
Model.Destroy(#CR_GUNCRATE)
Model.Destroy(#CM_BOX)
Model.Destroy(#BLACKBAG2)
Model.Destroy(#DYN_WOODPILE)
Model.Destroy(#DYN_WOODPILE2)
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
03C7: set_sensitivity_to_crime 1.0 
06D0: enable_emergency_traffic 1 
06D7: enable_train_traffic 1 
if 
  283@ == 1 
else_jump @QUARRY_28303 
091D: remove_forbidden_for_boats_cube_cornerA 256.6312 734.7498 4.0053 cornerB 343.9576 765.6713 6.4852 
091D: remove_forbidden_for_boats_cube_cornerA 291.2253 762.6765 4.0625 cornerB 354.4869 784.4223 6.6101 
091D: remove_forbidden_for_boats_cube_cornerA -149.9865 460.067 4.9719 cornerB -119.7325 530.4155 12.4813 
091D: remove_forbidden_for_boats_cube_cornerA -100.9858 1190.38 16.1736 cornerB 97.0928 1205.202 19.9344 
091D: remove_forbidden_for_boats_cube_cornerA -124.9028 1209.581 14.6519 cornerB -108.1954 1243.821 19.8554 
091D: remove_forbidden_for_boats_cube_cornerA -113.2273 1246.477 11.3781 cornerB -84.1825 1268.751 17.5621 

:QUARRY_28303
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
0A2D: hide_styled_text_while_fading 1 
" + OnMission + @" = 0 
" + _411 + @" = 0 
mission_cleanup 
return " );
            }

        }

    }

}