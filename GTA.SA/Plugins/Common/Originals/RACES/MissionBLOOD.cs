using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalRases {

        private sealed class BLOOD : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @BLOOD_47 
if 
wasted_or_busted 
else_jump @BLOOD_38 
gosub @BLOOD_13095 

:BLOOD_38
gosub @BLOOD_13196 
end_thread 

:BLOOD_47
" + OnMission + @" = 1 
if 
  " + Mission_BloodRing_Passed + @" == 0 
else_jump @BLOOD_74 
increment_mission_attempts 

:BLOOD_74
054C: use_GXT_table 'BLOOD' 
if 
  " + OnMission + @" == 0 
else_jump @BLOOD_202 
018A: 90@ = create_checkpoint_at 158@ 159@ 160@ 
87@ = Object.Create(#BB_PICKUP, 170@, 171@, 172@)
84@ = Car.Create(#BLOODRA, 154@, 155@, 156@)
85@ = Car.Create(#BLOODRA, 154@, 155@, 156@)
86@ = Car.Create(#BLOODRA, 154@, 155@, 156@)
95@ = Car.Create(#BLOODRA, 154@, 155@, 156@)

:BLOOD_202
0169: set_fade_color_RGB 0 0 0 
00BE: text_clear_all 
0A0E: disable_text_with_style 1 
wait 0 
91@ = 0 
92@ = 0 
if 
  " + Mission_BloodRing_Passed + @" == 0 
else_jump @BLOOD_269 
" + _8249 + @" = 60 
" + _8248 + @" = 60000 

:BLOOD_269
93@ = 0 
94@ = 0 
95@ = 0 
" + _8247 + @" = 30000 
96@ = 0 
97@ = 0 
98@ = 0 
99@ = 0 
100@ = 0 
101@ = 0 
102@ = -1 
154@ = -1280.9 
155@ = 994.8 
156@ = 1037.0 
157@ = 90.0 
158@ = 0.0 
159@ = 0.0 
160@ = 0.0 
161@ = 0.0 
162@ = 0.0 
163@ = 0.0 
164@ = 0.0 
165@ = 0.0 
166@ = 0.0 
167@ = 0.0 
168@ = 0.0 
169@ = 0.0 
170@ = 0.0 
171@ = 0.0 
172@ = 0.0 
173@ = 0.0 
174@ = 0.0 
175@ = 0.0 
176@ = 0.0 
177@ = 0.0 
178@ = 0.0 
179@ = 0.0 
180@ = 0.0 
181@ = 0.0 
182@ = 0.0 
183@ = 0.0 
184@ = 0.0 
103@ = 0 
111@ = 0 
104@ = 0 
105@ = 0 
112@ = 0 
113@ = 0 
114@ = 0 
115@ = 0 
116@ = 0 
117@ = 0 
118@ = 0 
119@ = 0 
120@ = 0 
121@ = 0 
122@ = 0 
123@ = 0 
124@ = 0 
125@ = 0 
126@ = 0 
127@ = 0 
106@ = 0.0 
04AF: 131@ = 36200 
04AF: 132@ = 36202 
04AF: 133@ = 36205 
04AF: 134@ = 36200 
04AF: 135@ = 36202 
04AF: 136@ = 36205 
04AF: 137@ = 36200 
04AF: 138@ = 36202 
04AF: 139@ = 36205 
04AF: 140@ = 36200 
04AF: 141@ = 36202 
04AF: 142@ = 36205 
04AF: 143@ = 36200 
04AF: 144@ = 36202 
04AF: 145@ = 36205 
04AF: 146@ = 36200 
04AF: 147@ = 36202 
04AF: 148@ = 36205 
04AF: 149@ = 36200 
04AF: 150@ = 36202 
04AF: 151@ = 36205 
04AF: 152@ = 36200 
04AF: 153@ = 36202 
107@ = 0 
108@ = 0 
wait 0 
fade 0 500 

:BLOOD_1062
if 
fading 
else_jump @BLOOD_1086 
wait 0 
jump @BLOOD_1062 

:BLOOD_1086
Model.Load(#BLOODRA)
Model.Load(#STALLION)
Model.Load(#MP5LNG)
Model.Load(#BB_PICKUP)
03CF: load_wav 1827 as 4 

:BLOOD_1113
if 
83D0:   not wav 4 loaded 
else_jump @BLOOD_1139 
wait 0 
jump @BLOOD_1113 

:BLOOD_1139
038B: load_requested_models 
016E: override_next_restart at -2126.3 -440.6 34.5 angle 82.7 
0A37: disable_vehicle_lights 1 
0732: random_car_generator_disable_model #LINERUN 
0732: random_car_generator_disable_model #TRASH 
0732: random_car_generator_disable_model #STRETCH 
0732: random_car_generator_disable_model #PONY 
0732: random_car_generator_disable_model #MULE 
0732: random_car_generator_disable_model #MOONBEAM 
0732: random_car_generator_disable_model #MRWHOOP 
0732: random_car_generator_disable_model #SECURICA 
0732: random_car_generator_disable_model #BUS 
0732: random_car_generator_disable_model #BARRACKS 
0732: random_car_generator_disable_model #COACH 
0732: random_car_generator_disable_model #RUMPO 
0732: random_car_generator_disable_model #ROMERO 
0732: random_car_generator_disable_model #PACKER 
0732: random_car_generator_disable_model #MONSTER 
0732: random_car_generator_disable_model #FLATBED 
0732: random_car_generator_disable_model #YANKEE 
0732: random_car_generator_disable_model #SOLAIR 
0732: random_car_generator_disable_model #PATRIOT 
0732: random_car_generator_disable_model #BURRITO 
0732: random_car_generator_disable_model #CAMPER 
0732: random_car_generator_disable_model #DOZER 
0732: random_car_generator_disable_model #RANCHER 
0732: random_car_generator_disable_model #BOXVILLE 
0732: random_car_generator_disable_model #BENSON 
0732: random_car_generator_disable_model #JOURNEY 
0732: random_car_generator_disable_model #PETRO 
0732: random_car_generator_disable_model #RDTRAIN 
0732: random_car_generator_disable_model #CEMENT 
0732: random_car_generator_disable_model #TOWTRUCK 
0732: random_car_generator_disable_model #DFT30 
0732: random_car_generator_disable_model #NEWSVAN 
0732: random_car_generator_disable_model #HOTDOG 
Player.CanMove(" + PlayerChar + @") = False
07E5: copy_decision_maker 65542 to 185@ 
09AC: disable_map_icons 1 
0414: set_player " + PlayerChar + @" free_treatment_once 1 
03AD: NOP 0 
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
04E2: NOP " + PlayerChar + @" 1 
Actor.PutAt(" + PlayerActor + @", -1398.461, 995.641, 1024.462)
select_interior 15 
0860: link_actor " + PlayerActor + @" to_interior 15 
04F9: set_sky_color 2 fade 0 
04E4: refresh_game_renderer_at 154@ 155@ 
Camera.SetAtPos(154@, 155@, 156@)
0395: clear_area 1 at -1280.9 994.8 1037.0 radius 300.0 
0A0B: set_rendering_origin_at_3D_coord -1280.8 994.7 1036.0 angle 90.0 
041A: 103@ = actor " + PlayerActor + @" weapon 29 ammo 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", MP5, 30000)
04AF: 108@ = 504 
gosub @BLOOD_15523 
34@ = Car.Create(#BLOODRA, 154@, 155@, 156@)
0587: enable_car 34@ validate_position 1 
0840: link_car 34@ to_interior 15 
Car.Angle(34@) = 157@
Car.DoorStatus(34@) = 4
036A: put_actor " + PlayerActor + @" in_car 34@ 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 29 
03AB: set_car 34@ strong 1 
03ED: set_car 34@ disable_flipped_explosion_when_empty 1 
053F: set_car 34@ tires_vulnerability 0 
Car.Health(34@) = 1249
0561: 83@ = create_passenger_in_car 34@ seat 0 
0860: link_actor 83@ to_interior 15 
060B: set_actor 83@ decision_maker_to 185@ 
Actor.GiveWeaponAndAmmo(83@, MP5, 30000)
Actor.SetImmunities(83@, 1, 0, 0, 0, 0)

:BLOOD_1662
if 
  16 > 93@ 
else_jump @BLOOD_2121 
wait 0 
gosub @BLOOD_13320 
09B2: get_random_available_car_unk 1 model_to 104@ class_to 105@ 
if 
  104@ >= 0 
else_jump @BLOOD_1755 
0085: 108@ = 104@ 
gosub @BLOOD_15523 
35@(93@,16i) = Car.Create(104@, 154@, 155@, 156@)

:BLOOD_1755
if 
  104@ == -1 
else_jump @BLOOD_1809 
04AF: 108@ = 439 
gosub @BLOOD_15523 
35@(93@,16i) = Car.Create(#STALLION, 154@, 155@, 156@)

:BLOOD_1809
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_2107 
Car.Angle(35@(93@,16i)) = 157@
0587: enable_car 35@(93@,16i) validate_position 1 
04E0: car 35@(93@,16i) abandon_path_radius 255 
053F: set_car 35@(93@,16i) tires_vulnerability 0 
0560: create_random_actor_in_car 35@(93@,16i) handle_as 51@(93@,16i) 
0860: link_actor 51@(93@,16i) to_interior 15 
060B: set_actor 51@(93@,16i) decision_maker_to 185@ 
Actor.SetImmunities(51@(93@,16i), 1, 0, 0, 0, 0)
01EA: 101@ = car 35@(93@,16i) max_passengers 
if 
  101@ > 0 
else_jump @BLOOD_2026 
0561: 67@(93@,16i) = create_passenger_in_car 35@(93@,16i) seat 0 
060B: set_actor 67@(93@,16i) decision_maker_to 185@ 
Actor.SetImmunities(67@(93@,16i), 1, 0, 0, 0, 0)
Actor.GiveWeaponAndAmmo(67@(93@,16i), MP5, 30000)

:BLOOD_2026
if 
047A:   actor 51@(93@,16i) driving_bike 
else_jump @BLOOD_2068 
08C6: set_actor 51@(93@,16i) stay_on_bike 1 
08C6: set_actor 67@(93@,16i) stay_on_bike 1 

:BLOOD_2068
03CC: enable_car 35@(93@,16i) stuck_check_distance_to 1.0 time_to 3000 
03ED: set_car 35@(93@,16i) disable_flipped_explosion_when_empty 1 
0840: link_car 35@(93@,16i) to_interior 15 

:BLOOD_2107
93@ += 1 
jump @BLOOD_1662 

:BLOOD_2121
02A3: enable_widescreen 1 
Camera.SetPosition(-1273.2, 992.4, 1038.5, 0.0, 0.0, 0.0)
Camera.PointAt(-1307.9, 995.3, 1034.2, 2)
06D5: 89@ = create_racing_checkpoint_at -1432.6 1016.1 1024.1 point_to 0.0 0.0 0.0 type 2 radius 6.0 
0169: set_fade_color_RGB 0 0 0 
wait 500 
fade 1 1500 

:BLOOD_2238
if 
fading 
else_jump @BLOOD_2262 
wait 0 
jump @BLOOD_2238 

:BLOOD_2262
0707: start_scene_skip_to @BLOOD_2988 
00BC: show_text_highpriority GXT 'BLOD_10' time 5000 flag 1  
32@ = 0 

:BLOOD_2292
if 
  5000 > 32@ 
else_jump @BLOOD_2322 
wait 0 
jump @BLOOD_2292 

:BLOOD_2322
Camera.SetPosition(-1441.9, 1054.6, 1040.5, 0.0, 0.0, 0.0)
Camera.PointAt(-1432.0, 1012.6, 1034.7, 2)
00BC: show_text_highpriority GXT 'BLOD_01' time 5000 flag 1  
32@ = 0 

:BLOOD_2396
if 
  5000 > 32@ 
else_jump @BLOOD_2426 
wait 0 
jump @BLOOD_2396 

:BLOOD_2426
Camera.SetPosition(-1464.6, 943.6, 1036.1, 0.0, 0.0, 0.0)
Camera.PointAt(-1436.1, 923.4, 1040.2, 2)
if 
  " + Mission_BloodRing_Passed + @" == 0 
else_jump @BLOOD_2518 
00BC: show_text_highpriority GXT 'BLOD_11' time 5000 flag 1  
jump @BLOOD_2537 

:BLOOD_2518
01E5: show_text_1number_highpriority GXT 'BLOD_12' number " + _1940 + @" time 5000 flag 1  

:BLOOD_2537
32@ = 0 

:BLOOD_2544
if 
  5000 > 32@ 
else_jump @BLOOD_2574 
wait 0 
jump @BLOOD_2544 

:BLOOD_2574
Camera.SetPosition(-1492.7, 1029.5, 1038.4, 0.0, 0.0, 0.0)
Camera.PointAt(-1539.1, 1032.3, 1038.9, 2)
00BC: show_text_highpriority GXT 'BLOD_03' time 5000 flag 1  
32@ = 0 

:BLOOD_2648
if 
  5000 > 32@ 
else_jump @BLOOD_2678 
wait 0 
jump @BLOOD_2648 

:BLOOD_2678
Camera.SetPosition(-1314.1, 1040.6, 1038.7, 0.0, 0.0, 0.0)
Camera.PointAt(-1373.1, 1047.2, 1034.5, 2)
00BC: show_text_highpriority GXT 'BLOD_02' time 5000 flag 1  
32@ = 0 

:BLOOD_2752
if 
  5000 > 32@ 
else_jump @BLOOD_2782 
wait 0 
jump @BLOOD_2752 

:BLOOD_2782
87@ = Object.Create(#BB_PICKUP, -1345.2, 978.7, 1024.9)
0566: link_object 87@ to_interior 15 
Camera.SetPosition(-1342.1, 975.2, 1026.6, 0.0, 0.0, 0.0)
Camera.PointAt(-1345.2, 979.7, 1026.4, 2)
00BC: show_text_highpriority GXT 'SPANNER' time 5000 flag 1  
32@ = 0 

:BLOOD_2886
if 
  5000 > 32@ 
else_jump @BLOOD_2988 
wait 0 
if 
03CA:   object 87@ exists 
else_jump @BLOOD_2981 
if 
  358.0 > 106@ 
else_jump @BLOOD_2971 
106@ += 3.0 
Object.Angle(87@) = 106@
jump @BLOOD_2981 

:BLOOD_2971
106@ = 0.0 

:BLOOD_2981
jump @BLOOD_2886 

:BLOOD_2988
0701: end_scene_skip 
fade 0 500 

:BLOOD_2997
if 
fading 
else_jump @BLOOD_3093 
wait 0 
if 
03CA:   object 87@ exists 
else_jump @BLOOD_3086 
if 
  358.0 > 106@ 
else_jump @BLOOD_3076 
106@ += 3.0 
Object.Angle(87@) = 106@
jump @BLOOD_3086 

:BLOOD_3076
106@ = 0.0 

:BLOOD_3086
jump @BLOOD_2997 

:BLOOD_3093
06D6: disable_racing_checkpoint 89@ 
158@ = -1432.6 
159@ = 1016.1 
160@ = 1024.1 
06D5: 89@ = create_racing_checkpoint_at 158@ 159@ 160@ point_to 0.0 0.0 0.0 type 2 radius 6.0 
018A: 90@ = create_checkpoint_at 158@ 159@ 160@ 
Object.Destroy(87@)
gosub @BLOOD_14429 
00BE: text_clear_all 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
fade 1 500 

:BLOOD_3207
if 
fading 
else_jump @BLOOD_3231 
wait 0 
jump @BLOOD_3207 

:BLOOD_3231
00BA: show_text_styled GXT 'RACE2' time 1100 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1056 
wait 1000 
00BA: show_text_styled GXT 'RACE3' time 1100 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1056 
wait 1000 
00BA: show_text_styled GXT 'RACE4' time 1100 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1056 
wait 1000 
00BA: show_text_styled GXT 'RACE5' time 800 style 4  
097A: play_audio_at 0.0 0.0 0.0 event 1164 
097A: play_audio_at 0.0 0.0 0.0 event 1057 
wait 800 
00BE: text_clear_all 
Player.CanMove(" + PlayerChar + @") = True
014E: start_timer_at " + _8247 + @" count_in_direction 1 
93@ = 0 

:BLOOD_3438
if 
  16 > 93@ 
else_jump @BLOOD_3563 
wait 0 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_3549 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_3549 
Car.SetSpeedInstantly(35@(93@,16i), 10.0)
Car.SetMaxSpeed(35@(93@,16i), 100.0)
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 9 timelimit 5000 

:BLOOD_3549
93@ += 1 
jump @BLOOD_3438 

:BLOOD_3563
wait 0 
Player.ClearWantedLevel(" + PlayerChar + @")
if 
0735:   is_keyboard_key_pressed 83 
else_jump @BLOOD_3594 
jump @BLOOD_13113 

:BLOOD_3594
if 
  91@ == 0 
else_jump @BLOOD_12351 
if 
   not Car.Wrecked(34@)
else_jump @BLOOD_12351 
if 
00A3:   actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA -1530.0 995.0 cornerB -1384.0 923.0 
else_jump @BLOOD_3803 
if 
  97@ == 0 
else_jump @BLOOD_3796 
if 
   not Actor.Dead(52@)
else_jump @BLOOD_3705 
0687: clear_actor 52@ task 

:BLOOD_3705
if 
   not Actor.Dead(53@)
else_jump @BLOOD_3726 
0687: clear_actor 53@ task 

:BLOOD_3726
if 
   not Actor.Dead(67@)
else_jump @BLOOD_3747 
0687: clear_actor 67@ task 

:BLOOD_3747
if 
   not Actor.Dead(68@)
else_jump @BLOOD_3768 
0687: clear_actor 68@ task 

:BLOOD_3768
if 
   not Actor.Dead(69@)
else_jump @BLOOD_3789 
0687: clear_actor 69@ task 

:BLOOD_3789
97@ = 1 

:BLOOD_3796
jump @BLOOD_3933 

:BLOOD_3803
if 
  97@ == 1 
else_jump @BLOOD_3933 
if 
   not Actor.Dead(52@)
else_jump @BLOOD_3842 
0687: clear_actor 52@ task 

:BLOOD_3842
if 
   not Actor.Dead(53@)
else_jump @BLOOD_3863 
0687: clear_actor 53@ task 

:BLOOD_3863
if 
   not Actor.Dead(67@)
else_jump @BLOOD_3884 
0687: clear_actor 67@ task 

:BLOOD_3884
if 
   not Actor.Dead(68@)
else_jump @BLOOD_3905 
0687: clear_actor 68@ task 

:BLOOD_3905
if 
   not Actor.Dead(69@)
else_jump @BLOOD_3926 
0687: clear_actor 69@ task 

:BLOOD_3926
97@ = 0 

:BLOOD_3933
if 
00A3:   actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA -1530.0 995.0 cornerB -1384.0 1076.0 
else_jump @BLOOD_4108 
if 
  98@ == 0 
else_jump @BLOOD_4101 
if 
   not Actor.Dead(55@)
else_jump @BLOOD_4010 
0687: clear_actor 55@ task 

:BLOOD_4010
if 
   not Actor.Dead(56@)
else_jump @BLOOD_4031 
0687: clear_actor 56@ task 

:BLOOD_4031
if 
   not Actor.Dead(70@)
else_jump @BLOOD_4052 
0687: clear_actor 70@ task 

:BLOOD_4052
if 
   not Actor.Dead(71@)
else_jump @BLOOD_4073 
0687: clear_actor 71@ task 

:BLOOD_4073
if 
   not Actor.Dead(72@)
else_jump @BLOOD_4094 
0687: clear_actor 72@ task 

:BLOOD_4094
98@ = 1 

:BLOOD_4101
jump @BLOOD_4238 

:BLOOD_4108
if 
  98@ == 1 
else_jump @BLOOD_4238 
if 
   not Actor.Dead(55@)
else_jump @BLOOD_4147 
0687: clear_actor 55@ task 

:BLOOD_4147
if 
   not Actor.Dead(56@)
else_jump @BLOOD_4168 
0687: clear_actor 56@ task 

:BLOOD_4168
if 
   not Actor.Dead(70@)
else_jump @BLOOD_4189 
0687: clear_actor 70@ task 

:BLOOD_4189
if 
   not Actor.Dead(71@)
else_jump @BLOOD_4210 
0687: clear_actor 71@ task 

:BLOOD_4210
if 
   not Actor.Dead(72@)
else_jump @BLOOD_4231 
0687: clear_actor 72@ task 

:BLOOD_4231
98@ = 0 

:BLOOD_4238
if 
00A3:   actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA -1265.0 995.0 cornerB -1384.0 923.0 
else_jump @BLOOD_4413 
if 
  99@ == 0 
else_jump @BLOOD_4406 
if 
   not Actor.Dead(58@)
else_jump @BLOOD_4315 
0687: clear_actor 58@ task 

:BLOOD_4315
if 
   not Actor.Dead(59@)
else_jump @BLOOD_4336 
0687: clear_actor 59@ task 

:BLOOD_4336
if 
   not Actor.Dead(73@)
else_jump @BLOOD_4357 
0687: clear_actor 73@ task 

:BLOOD_4357
if 
   not Actor.Dead(74@)
else_jump @BLOOD_4378 
0687: clear_actor 74@ task 

:BLOOD_4378
if 
   not Actor.Dead(75@)
else_jump @BLOOD_4399 
0687: clear_actor 75@ task 

:BLOOD_4399
99@ = 1 

:BLOOD_4406
jump @BLOOD_4543 

:BLOOD_4413
if 
  99@ == 1 
else_jump @BLOOD_4543 
if 
   not Actor.Dead(58@)
else_jump @BLOOD_4452 
0687: clear_actor 58@ task 

:BLOOD_4452
if 
   not Actor.Dead(59@)
else_jump @BLOOD_4473 
0687: clear_actor 59@ task 

:BLOOD_4473
if 
   not Actor.Dead(73@)
else_jump @BLOOD_4494 
0687: clear_actor 73@ task 

:BLOOD_4494
if 
   not Actor.Dead(74@)
else_jump @BLOOD_4515 
0687: clear_actor 74@ task 

:BLOOD_4515
if 
   not Actor.Dead(75@)
else_jump @BLOOD_4536 
0687: clear_actor 75@ task 

:BLOOD_4536
99@ = 0 

:BLOOD_4543
if 
00A3:   actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA -1265.0 995.0 cornerB -1384.0 1076.0 
else_jump @BLOOD_4718 
if 
  100@ == 0 
else_jump @BLOOD_4711 
if 
   not Actor.Dead(61@)
else_jump @BLOOD_4620 
0687: clear_actor 61@ task 

:BLOOD_4620
if 
   not Actor.Dead(62@)
else_jump @BLOOD_4641 
0687: clear_actor 62@ task 

:BLOOD_4641
if 
   not Actor.Dead(76@)
else_jump @BLOOD_4662 
0687: clear_actor 76@ task 

:BLOOD_4662
if 
   not Actor.Dead(77@)
else_jump @BLOOD_4683 
0687: clear_actor 77@ task 

:BLOOD_4683
if 
   not Actor.Dead(78@)
else_jump @BLOOD_4704 
0687: clear_actor 78@ task 

:BLOOD_4704
100@ = 1 

:BLOOD_4711
jump @BLOOD_4848 

:BLOOD_4718
if 
  100@ == 1 
else_jump @BLOOD_4848 
if 
   not Actor.Dead(61@)
else_jump @BLOOD_4757 
0687: clear_actor 61@ task 

:BLOOD_4757
if 
   not Actor.Dead(62@)
else_jump @BLOOD_4778 
0687: clear_actor 62@ task 

:BLOOD_4778
if 
   not Actor.Dead(76@)
else_jump @BLOOD_4799 
0687: clear_actor 76@ task 

:BLOOD_4799
if 
   not Actor.Dead(77@)
else_jump @BLOOD_4820 
0687: clear_actor 77@ task 

:BLOOD_4820
if 
   not Actor.Dead(78@)
else_jump @BLOOD_4841 
0687: clear_actor 78@ task 

:BLOOD_4841
100@ = 0 

:BLOOD_4848
if 
  16 > 93@ 
else_jump @BLOOD_11472 
if 
  93@ == 0 
else_jump @BLOOD_5608 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_5608 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_5327 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_5271 
if 
  97@ == 0 
else_jump @BLOOD_5152 
062E: get_actor 51@(93@,16i) task 1489 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5152 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5152 
0208: 173@ = random_float_in_ranges -1530.0 -1384.0 
0208: 174@ = random_float_in_ranges 995.0 923.0 
02CE: 175@ = ground_z_at 173@ 174@ 1078.7 
if 
  1034.1 > 175@ 
else_jump @BLOOD_5152 
if 
  175@ > 1022.8 
else_jump @BLOOD_5152 
05D1: AS_actor 51@(93@,16i) drive_car 35@(93@,16i) to 173@ 174@ 175@ speed 100.0 2 model #NULL 3 

:BLOOD_5152
if 
  97@ == 1 
else_jump @BLOOD_5264 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5264 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5264 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_5264
jump @BLOOD_5327 

:BLOOD_5271
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5327 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_5327
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_5608 
if 
  97@ == 0 
else_jump @BLOOD_5517 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5517 
if 
   not Car.Wrecked(36@)
else_jump @BLOOD_5461 
0713: actor 67@(93@,16i) driveby_actor -1 car 36@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 
jump @BLOOD_5517 

:BLOOD_5461
if 
   not Car.Wrecked(37@)
else_jump @BLOOD_5517 
0713: actor 67@(93@,16i) driveby_actor -1 car 37@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 

:BLOOD_5517
if 
  97@ == 1 
else_jump @BLOOD_5608 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5608 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_5608
if or
  93@ == 1 
  93@ == 2 
else_jump @BLOOD_6214 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_6214 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_5996 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_5940 
if 
  97@ == 0 
else_jump @BLOOD_5821 
if 
   not Car.Wrecked(35@)
else_jump @BLOOD_5821 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5821 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5821 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 35@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_5821
if 
  97@ == 1 
else_jump @BLOOD_5933 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5933 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5933 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_5933
jump @BLOOD_5996 

:BLOOD_5940
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_5996 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_5996
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_6214 
if 
  97@ == 0 
else_jump @BLOOD_6123 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6123 
if 
   not Car.Wrecked(35@)
else_jump @BLOOD_6123 
0713: actor 67@(93@,16i) driveby_actor -1 car 35@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_6123
if 
  97@ == 1 
else_jump @BLOOD_6214 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6214 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_6214
if 
  93@ == 3 
else_jump @BLOOD_6956 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_6956 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_6675 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_6619 
if 
  98@ == 0 
else_jump @BLOOD_6500 
062E: get_actor 51@(93@,16i) task 1489 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6500 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6500 
0208: 176@ = random_float_in_ranges -1530.0 -1384.0 
0208: 177@ = random_float_in_ranges 995.0 1056.0 
02CE: 178@ = ground_z_at 176@ 177@ 1078.7 
if 
  1034.1 > 178@ 
else_jump @BLOOD_6500 
if 
  178@ > 1022.8 
else_jump @BLOOD_6500 
05D1: AS_actor 51@(93@,16i) drive_car 35@(93@,16i) to 176@ 177@ 178@ speed 100.0 2 model #NULL 3 

:BLOOD_6500
if 
  98@ == 1 
else_jump @BLOOD_6612 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6612 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6612 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_6612
jump @BLOOD_6675 

:BLOOD_6619
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6675 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_6675
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_6956 
if 
  98@ == 0 
else_jump @BLOOD_6865 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6865 
if 
   not Car.Wrecked(39@)
else_jump @BLOOD_6809 
0713: actor 67@(93@,16i) driveby_actor -1 car 39@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 
jump @BLOOD_6865 

:BLOOD_6809
if 
   not Car.Wrecked(40@)
else_jump @BLOOD_6865 
0713: actor 67@(93@,16i) driveby_actor -1 car 40@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 

:BLOOD_6865
if 
  98@ == 1 
else_jump @BLOOD_6956 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_6956 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_6956
if or
  93@ == 4 
  93@ == 5 
else_jump @BLOOD_7562 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_7562 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_7344 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_7288 
if 
  98@ == 0 
else_jump @BLOOD_7169 
if 
   not Car.Wrecked(38@)
else_jump @BLOOD_7169 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7169 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7169 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 38@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_7169
if 
  98@ == 1 
else_jump @BLOOD_7281 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7281 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7281 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_7281
jump @BLOOD_7344 

:BLOOD_7288
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7344 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_7344
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_7562 
if 
  98@ == 0 
else_jump @BLOOD_7471 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7471 
if 
   not Car.Wrecked(38@)
else_jump @BLOOD_7471 
0713: actor 67@(93@,16i) driveby_actor -1 car 38@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_7471
if 
  98@ == 1 
else_jump @BLOOD_7562 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7562 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_7562
if 
  93@ == 6 
else_jump @BLOOD_8304 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_8304 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_8023 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_7967 
if 
  99@ == 0 
else_jump @BLOOD_7848 
062E: get_actor 51@(93@,16i) task 1489 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7848 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7848 
0208: 179@ = random_float_in_ranges -1265.0 -1384.0 
0208: 180@ = random_float_in_ranges 995.0 923.0 
02CE: 181@ = ground_z_at 179@ 180@ 1078.7 
if 
  1034.1 > 181@ 
else_jump @BLOOD_7848 
if 
  181@ > 1022.8 
else_jump @BLOOD_7848 
05D1: AS_actor 51@(93@,16i) drive_car 35@(93@,16i) to 179@ 180@ 181@ speed 100.0 2 model #NULL 3 

:BLOOD_7848
if 
  99@ == 1 
else_jump @BLOOD_7960 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7960 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_7960 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_7960
jump @BLOOD_8023 

:BLOOD_7967
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8023 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_8023
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_8304 
if 
  99@ == 0 
else_jump @BLOOD_8213 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8213 
if 
   not Car.Wrecked(42@)
else_jump @BLOOD_8157 
0713: actor 67@(93@,16i) driveby_actor -1 car 42@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 
jump @BLOOD_8213 

:BLOOD_8157
if 
   not Car.Wrecked(43@)
else_jump @BLOOD_8213 
0713: actor 67@(93@,16i) driveby_actor -1 car 43@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 

:BLOOD_8213
if 
  99@ == 1 
else_jump @BLOOD_8304 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8304 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_8304
if or
  93@ == 7 
  93@ == 8 
else_jump @BLOOD_8910 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_8910 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_8692 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_8636 
if 
  99@ == 0 
else_jump @BLOOD_8517 
if 
   not Car.Wrecked(41@)
else_jump @BLOOD_8517 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8517 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8517 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 41@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_8517
if 
  99@ == 1 
else_jump @BLOOD_8629 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8629 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8629 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_8629
jump @BLOOD_8692 

:BLOOD_8636
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8692 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_8692
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_8910 
if 
  99@ == 0 
else_jump @BLOOD_8819 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8819 
if 
   not Car.Wrecked(41@)
else_jump @BLOOD_8819 
0713: actor 67@(93@,16i) driveby_actor -1 car 41@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_8819
if 
  99@ == 1 
else_jump @BLOOD_8910 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_8910 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_8910
if 
  93@ == 9 
else_jump @BLOOD_9652 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_9652 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_9371 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_9315 
if 
  100@ == 0 
else_jump @BLOOD_9196 
062E: get_actor 51@(93@,16i) task 1489 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9196 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9196 
0208: 182@ = random_float_in_ranges -1265.0 -1384.0 
0208: 183@ = random_float_in_ranges 995.0 1056.0 
02CE: 184@ = ground_z_at 182@ 183@ 1078.7 
if 
  1034.1 > 184@ 
else_jump @BLOOD_9196 
if 
  184@ > 1022.8 
else_jump @BLOOD_9196 
05D1: AS_actor 51@(93@,16i) drive_car 35@(93@,16i) to 182@ 183@ 184@ speed 100.0 2 model #NULL 3 

:BLOOD_9196
if 
  100@ == 1 
else_jump @BLOOD_9308 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9308 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9308 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_9308
jump @BLOOD_9371 

:BLOOD_9315
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9371 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_9371
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_9652 
if 
  100@ == 0 
else_jump @BLOOD_9561 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9561 
if 
   not Car.Wrecked(45@)
else_jump @BLOOD_9505 
0713: actor 67@(93@,16i) driveby_actor -1 car 45@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 
jump @BLOOD_9561 

:BLOOD_9505
if 
   not Car.Wrecked(46@)
else_jump @BLOOD_9561 
0713: actor 67@(93@,16i) driveby_actor -1 car 46@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 50 

:BLOOD_9561
if 
  100@ == 1 
else_jump @BLOOD_9652 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9652 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_9652
if or
  93@ == 10 
  93@ == 11 
else_jump @BLOOD_10258 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_10258 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_10040 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_9984 
if 
  100@ == 0 
else_jump @BLOOD_9865 
if 
   not Car.Wrecked(44@)
else_jump @BLOOD_9865 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9865 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9865 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 44@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_9865
if 
  100@ == 1 
else_jump @BLOOD_9977 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9977 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_9977 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_9977
jump @BLOOD_10040 

:BLOOD_9984
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10040 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_10040
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_10258 
if 
  100@ == 0 
else_jump @BLOOD_10167 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10167 
if 
   not Car.Wrecked(44@)
else_jump @BLOOD_10167 
0713: actor 67@(93@,16i) driveby_actor -1 car 44@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_10167
if 
  100@ == 1 
else_jump @BLOOD_10258 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10258 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 25 

:BLOOD_10258
if or
  93@ == 12 
  93@ == 13 
else_jump @BLOOD_10593 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_10593 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_10500 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_10444 
062E: get_actor 51@(93@,16i) task 1761 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10437 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10437 
06E1: AS_actor 51@(93@,16i) using_car 35@(93@,16i) target_car 34@ with_order 17 max_speed 100.0 traffic_flag 3 

:BLOOD_10437
jump @BLOOD_10500 

:BLOOD_10444
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10500 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_10500
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_10593 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10593 
0713: actor 67@(93@,16i) driveby_actor -1 car 34@ point 0.0 0.0 0.0 radius 50.0 8 0 firing_rate 40 

:BLOOD_10593
if or
  93@ == 14 
  93@ == 15 
else_jump @BLOOD_11090 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_11090 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_10843 
if 
8495:   not car 35@(93@,16i) burning 
else_jump @BLOOD_10787 
062E: get_actor 51@(93@,16i) task 1489 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10780 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10780 
05D1: AS_actor 51@(93@,16i) drive_car 35@(93@,16i) to 158@ 159@ 160@ speed 100.0 2 model #NULL 3 

:BLOOD_10780
jump @BLOOD_10843 

:BLOOD_10787
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_10843 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 6 timelimit 2000000 

:BLOOD_10843
if 
   not Actor.Dead(67@(93@,16i))
else_jump @BLOOD_11090 
062E: get_actor 67@(93@,16i) task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_11090 
0085: 88@ = 35@(93@,16i) 
if 
  93@ == 14 
else_jump @BLOOD_10999 
gosub @BLOOD_16754 
0085: 84@ = 95@ 
if 
   not 84@ == -1 
else_jump @BLOOD_10999 
0713: actor 67@(93@,16i) driveby_actor -1 car 84@ point 0.0 0.0 0.0 radius 30.0 8 0 firing_rate 50 

:BLOOD_10999
if 
  93@ == 15 
else_jump @BLOOD_11090 
gosub @BLOOD_16754 
0085: 85@ = 95@ 
if 
   not 85@ == -1 
else_jump @BLOOD_11090 
0713: actor 67@(93@,16i) driveby_actor -1 car 85@ point 0.0 0.0 0.0 radius 30.0 8 0 firing_rate 50 

:BLOOD_11090
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_11199 
if 
   not Actor.Dead(83@)
else_jump @BLOOD_11199 
if or
051C:   car 35@(93@,16i) damaged_by_actor 83@ 
051C:   car 35@(93@,16i) damaged_by_actor " + PlayerActor + @" 
else_jump @BLOOD_11179 
112@(93@,16i) = 1 
jump @BLOOD_11190 

:BLOOD_11179
112@(93@,16i) = 0 

:BLOOD_11190
054F: clear_car 35@(93@,16i) damage 

:BLOOD_11199
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_11411 
if 
   not Actor.Dead(51@(93@,16i))
else_jump @BLOOD_11404 
if 
01F4:   car 35@(93@,16i) flipped 
else_jump @BLOOD_11330 
if 
8202:   not actor " + PlayerActor + @" near_car 35@(93@,16i) radius 7.0 7.0 sphere 0 
else_jump @BLOOD_11330 
Car.StorePos(35@(93@,16i), 167@, 168@, 169@)
Car.PutAt(35@(93@,16i), 167@, 168@, 169@)

:BLOOD_11330
if 
03CE:   car 35@(93@,16i) stuck 
else_jump @BLOOD_11404 
062E: get_actor 51@(93@,16i) task 1735 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_11404 
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 3 timelimit 3000 

:BLOOD_11404
jump @BLOOD_11458 

:BLOOD_11411
if 
  112@(93@,16i) == 1 
else_jump @BLOOD_11440 
111@ += 1 

:BLOOD_11440
112@(93@,16i) = 0 
gosub @BLOOD_14581 

:BLOOD_11458
93@ += 1 
jump @BLOOD_11479 

:BLOOD_11472
93@ = 0 

:BLOOD_11479
if 
   not Car.Wrecked(47@)
else_jump @BLOOD_11544 
if 
01AF:   car 47@ sphere 0 in_sphere 158@ 159@ 160@ radius 7.0 7.0 7.0 
else_jump @BLOOD_11544 
gosub @BLOOD_14250 

:BLOOD_11544
if 
   not Car.Wrecked(48@)
else_jump @BLOOD_11609 
if 
01AF:   car 48@ sphere 0 in_sphere 158@ 159@ 160@ radius 7.0 7.0 7.0 
else_jump @BLOOD_11609 
gosub @BLOOD_14250 

:BLOOD_11609
if 
   not Car.Wrecked(49@)
else_jump @BLOOD_11674 
if 
01AF:   car 49@ sphere 0 in_sphere 158@ 159@ 160@ radius 7.0 7.0 7.0 
else_jump @BLOOD_11674 
gosub @BLOOD_14250 

:BLOOD_11674
if 
   not Car.Wrecked(50@)
else_jump @BLOOD_11739 
if 
01AF:   car 50@ sphere 0 in_sphere 158@ 159@ 160@ radius 7.0 7.0 7.0 
else_jump @BLOOD_11739 
gosub @BLOOD_14250 

:BLOOD_11739
if 
03CA:   object 87@ exists 
else_jump @BLOOD_11927 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 87@ radius 5.0 5.0 sphere 0 
else_jump @BLOOD_11864 
Object.Destroy(87@)
96@ = Car.Health(34@)
if 
  999 > 96@ 
else_jump @BLOOD_11841 
96@ += 500 
Car.Health(34@) = 96@
jump @BLOOD_11857 

:BLOOD_11841
96@ = 1500 
Car.Health(34@) = 96@

:BLOOD_11857
jump @BLOOD_11920 

:BLOOD_11864
if 
  358.0 > 106@ 
else_jump @BLOOD_11910 
106@ += 3.0 
Object.Angle(87@) = 106@
jump @BLOOD_11920 

:BLOOD_11910
106@ = 0.0 

:BLOOD_11920
jump @BLOOD_11934 

:BLOOD_11927
gosub @BLOOD_14429 

:BLOOD_11934
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 158@ 159@ 160@ radius 7.0 7.0 7.0 
else_jump @BLOOD_12095 
if 
  " + _8247 + @" > 0 
else_jump @BLOOD_12095 
96@ = Car.Health(34@)
if 
  1199 > 96@ 
else_jump @BLOOD_12044 
96@ += 300 
Car.Health(34@) = 96@
jump @BLOOD_12060 

:BLOOD_12044
96@ = 1500 
Car.Health(34@) = 96@

:BLOOD_12060
" + _8247 + @" += 15000 
018C: play_sound 1058 at 0.0 0.0 0.0 
gosub @BLOOD_14250 

:BLOOD_12095
if 
01F4:   car 34@ flipped 
else_jump @BLOOD_12171 
if 
01C1:   car 34@ stopped 
else_jump @BLOOD_12171 
Car.StorePos(34@, 167@, 168@, 169@)
157@ = Car.Angle(34@)
Car.PutAt(34@, 167@, 168@, 169@)
Car.Angle(34@) = 157@

:BLOOD_12171
if 
   not Actor.Dead(83@)
else_jump @BLOOD_12293 
062E: get_actor 83@ task 1811 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @BLOOD_12293 
0085: 88@ = 34@ 
gosub @BLOOD_16754 
0085: 86@ = 95@ 
if 
   not 86@ == -1 
else_jump @BLOOD_12293 
0713: actor 83@ driveby_actor -1 car 86@ point 0.0 0.0 0.0 radius 30.0 8 0 firing_rate 100 

:BLOOD_12293
gosub @BLOOD_17482 
if 
001C:   " + _8247 + @" > " + _8248 + @" 
else_jump @BLOOD_12326 
91@ = 1 

:BLOOD_12326
if 
  0 >= " + _8247 + @" 
else_jump @BLOOD_12351 
91@ = 2 

:BLOOD_12351
if 
  91@ == 1 
else_jump @BLOOD_12754 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
0394: play_music 1 
93@ = 0 

:BLOOD_12391
if 
  16 > 93@ 
else_jump @BLOOD_12458 
wait 0 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_12444 
Car.LockInCurrentPosition(35@(93@,16i)) = True

:BLOOD_12444
93@ += 1 
jump @BLOOD_12391 

:BLOOD_12458
gosub @BLOOD_17028 
008B: 109@ = " + _1940 + @" 
109@ *= 60 
0623: add 109@ to_integer_stat 179 
0623: add 111@ to_integer_stat 178 
" + _1940 + @" += 1 
" + _8248 + @" += 60000 
32@ = 0 

:BLOOD_12520
if 
  5000 > 32@ 
else_jump @BLOOD_12550 
wait 0 
jump @BLOOD_12520 

:BLOOD_12550
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:BLOOD_12565
if 
fading 
else_jump @BLOOD_12589 
wait 0 
jump @BLOOD_12565 

:BLOOD_12589
02A3: enable_widescreen 0 
08DA: remove_panel 110@ 
select_interior 0 
0860: link_actor " + PlayerActor + @" to_interior 0 
04E4: refresh_game_renderer_at -2126.3 -440.6 
0A0B: set_rendering_origin_at_3D_coord -2119.0 -440.7 34.5 angle 82.6 
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.PutAt(" + PlayerActor + @", -2126.3, -440.6, 34.5)
Actor.Angle(" + PlayerActor + @") = 82.7
014F: stop_timer " + _8247 + @" 
Marker.Disable(90@)
06D6: disable_racing_checkpoint 89@ 
09AC: disable_map_icons 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0169: set_fade_color_RGB 0 0 0 
fade 1 500 

:BLOOD_12716
if 
fading 
else_jump @BLOOD_12740 
wait 0 
jump @BLOOD_12716 

:BLOOD_12740
Player.CanMove(" + PlayerChar + @") = True
jump @BLOOD_13113 

:BLOOD_12754
if 
  91@ == 2 
else_jump @BLOOD_13088 
Player.CanMove(" + PlayerChar + @") = False
93@ = 0 

:BLOOD_12786
if 
  16 > 93@ 
else_jump @BLOOD_12853 
wait 0 
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_12839 
Car.LockInCurrentPosition(35@(93@,16i)) = True

:BLOOD_12839
93@ += 1 
jump @BLOOD_12786 

:BLOOD_12853
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:BLOOD_12868
if 
fading 
else_jump @BLOOD_12892 
wait 0 
jump @BLOOD_12868 

:BLOOD_12892
02A3: enable_widescreen 0 
00BE: text_clear_all 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
00BC: show_text_highpriority GXT 'BLOD_05' time 5000 flag 1  
select_interior 0 
0860: link_actor " + PlayerActor + @" to_interior 0 
04E4: refresh_game_renderer_at -2126.3 -440.6 
0A0B: set_rendering_origin_at_3D_coord -2119.0 -440.7 34.5 angle 82.6 
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.PutAt(" + PlayerActor + @", -2126.3, -440.6, 34.5)
Actor.Angle(" + PlayerActor + @") = 82.7
014F: stop_timer " + _8247 + @" 
Marker.Disable(90@)
06D6: disable_racing_checkpoint 89@ 
09AC: disable_map_icons 0 
01F6: cancel_override_restart 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0169: set_fade_color_RGB 0 0 0 
fade 1 500 

:BLOOD_13050
if 
fading 
else_jump @BLOOD_13074 
wait 0 
jump @BLOOD_13050 

:BLOOD_13074
Player.CanMove(" + PlayerChar + @") = True
jump @BLOOD_13095 

:BLOOD_13088
jump @BLOOD_3563 

:BLOOD_13095
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
return 

:BLOOD_13113
01F6: cancel_override_restart 
0414: set_player " + PlayerChar + @" free_treatment_once 0 
00BE: text_clear_all 
Player.ClearWantedLevel(" + PlayerChar + @")
if 
  " + Mission_BloodRing_Passed + @" == 0 
else_jump @BLOOD_13194 
0595: mission_complete" );
CAR_PARK.set_chance_to_generate( carPark_5188, 101 );
AppendLine( @"0394: play_music 2 
01E3: show_text_1number_styled GXT 'M_PASS' number 10000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 10000
" + Mission_BloodRing_Passed + @" = 1 

:BLOOD_13194
return 

:BLOOD_13196
if 
0844:   string " + Current_Shop_GXT_Name + @" empty 
else_jump @BLOOD_13214 
Camera.Restore_WithJumpCut

:BLOOD_13214
04FA: reset_sky_colors_with_fade 0 
Marker.Disable(90@)
014F: stop_timer " + _8247 + @" 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @BLOOD_13251 
0A09: set_actor " + PlayerActor + @" muted 0 

:BLOOD_13251
09F5: disable_player_mutal_activities 0 
03F0: enable_text_draw 0 
Model.Destroy(#BLOODRA)
Model.Destroy(#STALLION)
Model.Destroy(#MP5LNG)
Model.Destroy(#BB_PICKUP)
Actor.SetWeaponAmmo(" + PlayerActor + @", MP5, 103@)
06D6: disable_racing_checkpoint 89@ 
0734: reset_random_car_generator_models 
0A37: disable_vehicle_lights 0 
09AC: disable_map_icons 0 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + OnMission + @" = 0 
mission_cleanup 
return 

:BLOOD_13320
if 
  93@ == 0 
else_jump @BLOOD_13378 
154@ = -1285.77 
155@ = 1014.54 
156@ = 1036.5 
157@ = 104.4 

:BLOOD_13378
if 
  93@ == 1 
else_jump @BLOOD_13436 
154@ = -1299.5 
155@ = 1030.74 
156@ = 1036.8 
157@ = 132.6 

:BLOOD_13436
if 
  93@ == 2 
else_jump @BLOOD_13494 
154@ = -1319.3 
155@ = 1042.82 
156@ = 1037.1 
157@ = 135.4 

:BLOOD_13494
if 
  93@ == 3 
else_jump @BLOOD_13552 
154@ = -1349.33 
155@ = 1054.47 
156@ = 1037.3 
157@ = 155.4 

:BLOOD_13552
if 
  93@ == 4 
else_jump @BLOOD_13610 
154@ = -1384.33 
155@ = 1058.55 
156@ = 1037.5 
157@ = 173.2 

:BLOOD_13610
if 
  93@ == 5 
else_jump @BLOOD_13668 
154@ = -1296.7 
155@ = 960.2 
156@ = 1035.6 
157@ = 60.5 

:BLOOD_13668
if 
  93@ == 6 
else_jump @BLOOD_13726 
154@ = -1418.77 
155@ = 1057.54 
156@ = 1037.5 
157@ = 180.4 

:BLOOD_13726
if 
  93@ == 7 
else_jump @BLOOD_13784 
154@ = -1460.3 
155@ = 1050.3 
156@ = 1037.5 
157@ = 203.9 

:BLOOD_13784
if 
  93@ == 8 
else_jump @BLOOD_13842 
154@ = -1499.77 
155@ = 1029.54 
156@ = 1037.2 
157@ = 242.4 

:BLOOD_13842
if 
  93@ == 9 
else_jump @BLOOD_13900 
154@ = -1513.77 
155@ = 986.54 
156@ = 1036.5 
157@ = 271.4 

:BLOOD_13900
if 
  93@ == 10 
else_jump @BLOOD_13958 
154@ = -1496.77 
155@ = 959.54 
156@ = 1036.0 
157@ = 293.4 

:BLOOD_13958
if 
  93@ == 11 
else_jump @BLOOD_14016 
154@ = -1461.84 
155@ = 938.32 
156@ = 1035.3 
157@ = 345.6 

:BLOOD_14016
if 
  93@ == 12 
else_jump @BLOOD_14074 
154@ = -1424.36 
155@ = 931.29 
156@ = 1035.2 
157@ = 0.0 

:BLOOD_14074
if 
  93@ == 13 
else_jump @BLOOD_14132 
154@ = -1363.77 
155@ = 932.44 
156@ = 1035.3 
157@ = 17.85 

:BLOOD_14132
if 
  93@ == 14 
else_jump @BLOOD_14190 
154@ = -1332.77 
155@ = 940.3 
156@ = 1037.0 
157@ = 39.98 

:BLOOD_14190
if 
  93@ == 15 
else_jump @BLOOD_14248 
154@ = -1443.29 
155@ = 933.86 
156@ = 1035.3 
157@ = 351.4 

:BLOOD_14248
return 

:BLOOD_14250
0208: 158@ = random_float_in_ranges -1290.0 -1508.0 
0208: 159@ = random_float_in_ranges 939.0 1052.0 
02CE: 160@ = ground_z_at 158@ 159@ 1056.7 
if 
  160@ > 1034.1 
else_jump @BLOOD_14324 
jump @BLOOD_14250 

:BLOOD_14324
if 
  1022.8 > 160@ 
else_jump @BLOOD_14352 
jump @BLOOD_14250 

:BLOOD_14352
Marker.Disable(90@)
018A: 90@ = create_checkpoint_at 158@ 159@ 160@ 
if 
   not Actor.Dead(65@)
else_jump @BLOOD_14392 
0687: clear_actor 65@ task 

:BLOOD_14392
if 
   not Actor.Dead(66@)
else_jump @BLOOD_14413 
0687: clear_actor 66@ task 

:BLOOD_14413
07F3: move_racing_checkpoint 89@ to 158@ 159@ 160@ 
return 

:BLOOD_14429
0208: 170@ = random_float_in_ranges -1290.0 -1508.0 
0208: 171@ = random_float_in_ranges 939.0 1052.0 
02CE: 172@ = ground_z_at 170@ 171@ 1056.7 
if 
  172@ > 1034.1 
else_jump @BLOOD_14503 
jump @BLOOD_14429 

:BLOOD_14503
if 
  1022.8 > 172@ 
else_jump @BLOOD_14531 
jump @BLOOD_14429 

:BLOOD_14531
172@ += 0.5 
87@ = Object.Create(#BB_PICKUP, 170@, 171@, 172@)
0566: link_object 87@ to_interior 15 
Object.CollisionDetection(87@) = False
Object.ToggleInMovingList(87@) = False
return 

:BLOOD_14581
gosub @BLOOD_15052 
if 
   not 102@ == -1 
else_jump @BLOOD_15050 
03CD: disable_car 35@(93@,16i) stuck_check 
Car.RemoveReferences(35@(93@,16i))
Actor.RemoveReferences(51@(93@,16i))
Actor.RemoveReferences(67@(93@,16i))
09B2: get_random_available_car_unk 1 model_to 104@ class_to 105@ 
if 
  104@ >= 0 
else_jump @BLOOD_14718 
0085: 108@ = 104@ 
gosub @BLOOD_15523 
35@(93@,16i) = Car.Create(104@, 154@, 155@, 156@)
Car.Angle(35@(93@,16i)) = 157@

:BLOOD_14718
if 
   not Car.Wrecked(35@(93@,16i))
else_jump @BLOOD_15050 
0587: enable_car 35@(93@,16i) validate_position 1 
04E0: car 35@(93@,16i) abandon_path_radius 255 
053F: set_car 35@(93@,16i) tires_vulnerability 0 
0560: create_random_actor_in_car 35@(93@,16i) handle_as 51@(93@,16i) 
0860: link_actor 51@(93@,16i) to_interior 15 
060B: set_actor 51@(93@,16i) decision_maker_to 185@ 
Actor.SetImmunities(51@(93@,16i), 1, 0, 0, 0, 0)
0588: disable_actor 51@(93@,16i) validate_position 1 
01EA: 101@ = car 35@(93@,16i) max_passengers 
if 
  101@ > 0 
else_jump @BLOOD_14934 
0561: 67@(93@,16i) = create_passenger_in_car 35@(93@,16i) seat 0 
060B: set_actor 67@(93@,16i) decision_maker_to 185@ 
Actor.SetImmunities(67@(93@,16i), 1, 0, 0, 0, 0)
Actor.GiveWeaponAndAmmo(67@(93@,16i), MP5, 30000)

:BLOOD_14934
if 
047A:   actor 51@(93@,16i) driving_bike 
else_jump @BLOOD_14976 
08C6: set_actor 51@(93@,16i) stay_on_bike 1 
08C6: set_actor 67@(93@,16i) stay_on_bike 1 

:BLOOD_14976
03CC: enable_car 35@(93@,16i) stuck_check_distance_to 1.0 time_to 3000 
03ED: set_car 35@(93@,16i) disable_flipped_explosion_when_empty 1 
0840: link_car 35@(93@,16i) to_interior 15 
Car.SetSpeedInstantly(35@(93@,16i), 25.0)
06C7: AS_actor 51@(93@,16i) driver_of_car 35@(93@,16i) perform_action 9 timelimit 3000 

:BLOOD_15050
return 

:BLOOD_15052
0209: 102@ = random_int_in_ranges 1 4 
if 
  102@ == 1 
else_jump @BLOOD_15176 
if 
838A:   not any_car_in_cube_cornerA -1461.84 938.32 1035.0 cornerB 5.0 5.0 5.0 
else_jump @BLOOD_15169 
154@ = -1461.84 
155@ = 938.32 
156@ = 1035.0 
157@ = 345.6 
jump @BLOOD_15176 

:BLOOD_15169
102@ = 2 

:BLOOD_15176
if 
  102@ == 2 
else_jump @BLOOD_15291 
if 
838A:   not any_car_in_cube_cornerA -1424.36 933.86 1035.0 cornerB 5.0 5.0 5.0 
else_jump @BLOOD_15284 
154@ = -1424.36 
155@ = 933.86 
156@ = 1035.0 
157@ = 0.0 
jump @BLOOD_15291 

:BLOOD_15284
102@ = 3 

:BLOOD_15291
if 
  102@ == 3 
else_jump @BLOOD_15406 
if 
838A:   not any_car_in_cube_cornerA -1443.29 931.29 1035.0 cornerB 5.0 5.0 5.0 
else_jump @BLOOD_15399 
154@ = -1443.29 
155@ = 931.29 
156@ = 1035.0 
157@ = 351.4 
jump @BLOOD_15406 

:BLOOD_15399
102@ = 1 

:BLOOD_15406
if 
  102@ == 1 
else_jump @BLOOD_15521 
if 
838A:   not any_car_in_cube_cornerA -1461.84 938.32 1035.0 cornerB 5.0 5.0 5.0 
else_jump @BLOOD_15514 
154@ = -1461.84 
155@ = 938.32 
156@ = 1035.0 
157@ = 345.6 
jump @BLOOD_15521 

:BLOOD_15514
102@ = -1 

:BLOOD_15521
return 

:BLOOD_15523
0209: 107@ = random_int_in_ranges 1 37 
if 
  107@ == 1 
else_jump @BLOOD_15565 
0674: set_car_model 108@ numberplate ""GOT_M00_"" 

:BLOOD_15565
if 
  107@ == 2 
else_jump @BLOOD_15598 
0674: set_car_model 108@ numberplate ""M00TV_4U"" 

:BLOOD_15598
if 
  107@ == 3 
else_jump @BLOOD_15631 
0674: set_car_model 108@ numberplate ""MATHEW_2"" 

:BLOOD_15631
if 
  107@ == 4 
else_jump @BLOOD_15664 
0674: set_car_model 108@ numberplate ""D4_DEW0R"" 

:BLOOD_15664
if 
  107@ == 5 
else_jump @BLOOD_15697 
0674: set_car_model 108@ numberplate ""D0DE_777"" 

:BLOOD_15697
if 
  107@ == 6 
else_jump @BLOOD_15730 
0674: set_car_model 108@ numberplate ""DAM0_666"" 

:BLOOD_15730
if 
  107@ == 7 
else_jump @BLOOD_15763 
0674: set_car_model 108@ numberplate ""C0NEY_88"" 

:BLOOD_15763
if 
  107@ == 8 
else_jump @BLOOD_15796 
0674: set_car_model 108@ numberplate ""PRE4CHER"" 

:BLOOD_15796
if 
  107@ == 9 
else_jump @BLOOD_15829 
0674: set_car_model 108@ numberplate ""DBP_4NDY"" 

:BLOOD_15829
if 
  107@ == 10 
else_jump @BLOOD_15862 
0674: set_car_model 108@ numberplate ""EV1L_SLY"" 

:BLOOD_15862
if 
  107@ == 11 
else_jump @BLOOD_15895 
0674: set_car_model 108@ numberplate ""N1_R4V3N"" 

:BLOOD_15895
if 
  107@ == 12 
else_jump @BLOOD_15928 
0674: set_car_model 108@ numberplate ""D1VX_Z00"" 

:BLOOD_15928
if 
  107@ == 13 
else_jump @BLOOD_15960 
0674: set_car_model 108@ numberplate ""MR_B3NN"" 

:BLOOD_15960
if 
  107@ == 14 
else_jump @BLOOD_15993 
0674: set_car_model 108@ numberplate ""R3D_R4SP"" 

:BLOOD_15993
if 
  107@ == 15 
else_jump @BLOOD_16026 
0674: set_car_model 108@ numberplate ""LA_B0MBA"" 

:BLOOD_16026
if 
  107@ == 16 
else_jump @BLOOD_16059 
0674: set_car_model 108@ numberplate ""L3337_0G"" 

:BLOOD_16059
if 
  107@ == 17 
else_jump @BLOOD_16092 
0674: set_car_model 108@ numberplate ""BUDD4H_X"" 

:BLOOD_16092
if 
  107@ == 18 
else_jump @BLOOD_16125 
0674: set_car_model 108@ numberplate ""T3H_BUCK"" 

:BLOOD_16125
if 
  107@ == 19 
else_jump @BLOOD_16158 
0674: set_car_model 108@ numberplate ""CHUNKY_1"" 

:BLOOD_16158
if 
  107@ == 20 
else_jump @BLOOD_16191 
0674: set_car_model 108@ numberplate ""EV1L_BNZ"" 

:BLOOD_16191
if 
  107@ == 21 
else_jump @BLOOD_16224 
0674: set_car_model 108@ numberplate ""S4ND_M4N"" 

:BLOOD_16224
if 
  107@ == 22 
else_jump @BLOOD_16257 
0674: set_car_model 108@ numberplate ""RKK_DBP1"" 

:BLOOD_16257
if 
  107@ == 23 
else_jump @BLOOD_16290 
0674: set_car_model 108@ numberplate ""RE1_K0KU"" 

:BLOOD_16290
if 
  107@ == 24 
else_jump @BLOOD_16323 
0674: set_car_model 108@ numberplate ""S3XY_JUD"" 

:BLOOD_16323
if 
  107@ == 25 
else_jump @BLOOD_16356 
0674: set_car_model 108@ numberplate ""SUNRA_93"" 

:BLOOD_16356
if 
  107@ == 26 
else_jump @BLOOD_16389 
0674: set_car_model 108@ numberplate ""UG_FUX69"" 

:BLOOD_16389
if 
  107@ == 27 
else_jump @BLOOD_16422 
0674: set_car_model 108@ numberplate ""LI0N_CUM"" 

:BLOOD_16422
if 
  107@ == 28 
else_jump @BLOOD_16455 
0674: set_car_model 108@ numberplate ""RKK_PWND"" 

:BLOOD_16455
if 
  107@ == 29 
else_jump @BLOOD_16488 
0674: set_car_model 108@ numberplate ""HAZE_B0B"" 

:BLOOD_16488
if 
  107@ == 30 
else_jump @BLOOD_16521 
0674: set_car_model 108@ numberplate ""T3H_FLUF"" 

:BLOOD_16521
if 
  107@ == 31 
else_jump @BLOOD_16554 
0674: set_car_model 108@ numberplate ""BM_4NDY_"" 

:BLOOD_16554
if 
  107@ == 32 
else_jump @BLOOD_16587 
0674: set_car_model 108@ numberplate ""BM_D34N_"" 

:BLOOD_16587
if 
  107@ == 33 
else_jump @BLOOD_16620 
0674: set_car_model 108@ numberplate ""BM_L4C3Y"" 

:BLOOD_16620
if 
  107@ == 34 
else_jump @BLOOD_16653 
0674: set_car_model 108@ numberplate ""BM_D3V__"" 

:BLOOD_16653
if 
  107@ == 35 
else_jump @BLOOD_16686 
0674: set_car_model 108@ numberplate ""NU_SK00L"" 

:BLOOD_16686
if 
  107@ == 36 
else_jump @BLOOD_16719 
0674: set_car_model 108@ numberplate ""G4L_AVET"" 

:BLOOD_16719
if 
  107@ == 37 
else_jump @BLOOD_16752 
0674: set_car_model 108@ numberplate ""M0J0_J0J"" 

:BLOOD_16752
return 

:BLOOD_16754
Car.StorePos(88@, 161@, 162@, " + tempvar_Float_3 + @")
94@ = 0 
165@ = 99999.0 
95@ = -1 

:BLOOD_16792
if 
  16 > 94@ 
else_jump @BLOOD_16941 
if 
803B:   not  88@ == 35@(94@,16i) 
else_jump @BLOOD_16927 
if 
   not Car.Wrecked(35@(94@,16i))
else_jump @BLOOD_16927 
Car.StorePos(35@(94@,16i), 163@, 164@, " + tempvar_Float_3 + @")
0509: 166@ = distance_between_XY 161@ 162@ and_XY 163@ 164@ 
if 
0025:   165@ > 166@ 
else_jump @BLOOD_16927 
0087: 165@ = 166@ 
0085: 95@ = 35@(94@,16i) 

:BLOOD_16927
94@ += 1 
jump @BLOOD_16792 

:BLOOD_16941
if 
803B:   not  88@ == 34@ 
else_jump @BLOOD_17026 
Car.StorePos(34@, 163@, 164@, " + tempvar_Float_3 + @")
0509: 166@ = distance_between_XY 161@ 162@ and_XY 163@ 164@ 
if 
0025:   165@ > 166@ 
else_jump @BLOOD_17026 
0087: 165@ = 166@ 
0085: 95@ = 34@ 

:BLOOD_17026
return 

:BLOOD_17028
if 
84A3:   not  " + Current_Language + @" == 4 
else_jump @BLOOD_17090 
08D4: 110@ = create_panel_with_title 'BLOD_06' position 190.0 141.0 width 120.0 columns 2 interactive 0 background 1 alignment 1  
jump @BLOOD_17127 

:BLOOD_17090
08D4: 110@ = create_panel_with_title 'BLOD_06' position 190.0 141.0 width 150.0 columns 2 interactive 0 background 1 alignment 1  

:BLOOD_17127
08DB: set_panel 110@ column 0 header 'DUMMY' data 'BLOD_07' 'BLOD_08' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08DB: set_panel 110@ column 1 header 'DUMMY' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 
08EE: set_panel 110@ column 1 row 0 text_1number GXT 'BLOD_09' number " + _1940 + @"  
08EE: set_panel 110@ column 1 row 1 text_1number GXT 'BLOD_09' number 111@  
if 
84A3:   not  " + Current_Language + @" == 4 
else_jump @BLOOD_17461 
09DB: set_panel 110@ column 0 width 200 
09DB: set_panel 110@ column 1 width 40 
jump @BLOOD_17480 

:BLOOD_17461
09DB: set_panel 110@ column 0 width 260 
09DB: set_panel 110@ column 1 width 40 

:BLOOD_17480
return 

:BLOOD_17482
if 
  129@ == 0 
else_jump @BLOOD_17545 
0209: 128@ = random_int_in_ranges 8000 16000 
0209: 130@ = random_int_in_ranges 1 22 
03CF: load_wav 131@(130@,23i) as 4 
33@ = 0 
129@ = 1 

:BLOOD_17545
if 
  129@ == 1 
else_jump @BLOOD_17585 
if 
03D0:   wav 4 loaded 
else_jump @BLOOD_17585 
129@ = 2 

:BLOOD_17585
if 
  129@ == 2 
else_jump @BLOOD_17633 
if 
001D:   33@ > 128@ 
else_jump @BLOOD_17633 
03D1: play_wav 4 
129@ = 3 

:BLOOD_17633
if 
  129@ == 3 
else_jump @BLOOD_17673 
if 
03D2:   wav 4 ended 
else_jump @BLOOD_17673 
129@ = 0 

:BLOOD_17673
return" );
            }

        }

    }

}