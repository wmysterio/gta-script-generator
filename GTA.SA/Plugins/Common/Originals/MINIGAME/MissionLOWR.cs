﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class LOWR : MissionCustom {

            Int _local68 = local( 68 ), 
                _local73 = local( 73 ),
                _local99 = local( 99 );

            Actor _local95 = local( 95 );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @LOWR_47 
if 
wasted_or_busted 
else_jump @LOWR_38 
gosub @LOWR_27250 

:LOWR_38
gosub @LOWR_27254 
end_thread 

:LOWR_47
" + OnMission + @" = 1 
34@ = 0 
35@ = 0 
36@ = 0 
37@ = 0 
38@ = 0 
62@ = 0 
63@ = 0 
64@ = 0 
65@ = 0 
32@ = 0 
33@ = 0 
060A: create_decision_maker_type 0 store_to 66@ 
060A: create_decision_maker_type 2 store_to 67@ 

:LOWR_145
wait 0 
if 
0736:   is_keyboard_key_just_pressed 83 
else_jump @LOWR_171 
36@ = 1 

:LOWR_171
39@ += 1 
if 
  39@ > 22 
else_jump @LOWR_203 
39@ = 0 

:LOWR_203
01BD: 40@ = current_time_in_ms 
0085: 42@ = 40@ 
0062: 42@ -= 41@ 
0085: 41@ = 40@ 
005A: 64@ += 42@ 
005A: 65@ += 42@ 
005A: 133@ += 42@ 
005A: 134@ += 42@ 
005A: 135@ += 42@ 
005A: 136@ += 42@ 
005A: 137@ += 42@ 
077E: get_active_interior_to 43@ 
if 
  43@ == 0 
else_jump @LOWR_319 
005E: " + _6471 + @" += 42@ 

:LOWR_319
0871: init_jump_table 34@ total_jumps 7 default_jump 0 @LOWR_466 jumps 0 @LOWR_382 1 @LOWR_396 2 @LOWR_403 3 @LOWR_410 4 @LOWR_424 5 @LOWR_438 6 @LOWR_452 

:LOWR_382
gosub @LOWR_619 
jump @LOWR_466 

:LOWR_396
jump @LOWR_466 

:LOWR_403
jump @LOWR_466 

:LOWR_410
gosub @LOWR_962 
jump @LOWR_466 

:LOWR_424
gosub @LOWR_9455 
jump @LOWR_466 

:LOWR_438
gosub @LOWR_12559 
jump @LOWR_466 

:LOWR_452
gosub @LOWR_17601 
jump @LOWR_466 

:LOWR_466
gosub @LOWR_19756 
if 
0736:   is_keyboard_key_just_pressed 80 
else_jump @LOWR_495 
gosub @LOWR_26533 

:LOWR_495
if 
0736:   is_keyboard_key_just_pressed 79 
else_jump @LOWR_517 
gosub @LOWR_26635 

:LOWR_517
if 
  38@ == 0 
else_jump @LOWR_617 
if 
  37@ == 0 
else_jump @LOWR_601 
if 
  36@ == 0 
else_jump @LOWR_585 
jump @LOWR_145 
jump @LOWR_594 

:LOWR_585
gosub @LOWR_27252 
return 

:LOWR_594
jump @LOWR_610 

:LOWR_601
gosub @LOWR_27250 
return 

:LOWR_610
jump @LOWR_619 

:LOWR_617
return 

:LOWR_619
if 
  35@ == -1 
else_jump @LOWR_748 
69@ = Car.Create(#PONY, 0.0, 0.0, 0.0)
77@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
018A: 102@ = create_checkpoint_at 0.0 0.0 0.0 
018A: 103@ = create_checkpoint_at 0.0 0.0 0.0 
99@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)

:LOWR_748
271@ = 50 
272@ = 1000 
104@ = 0 
43@ = 0 

:LOWR_777
if 
  22 > 43@ 
else_jump @LOWR_820 
105@(43@,22i) = 0 
43@ += 1 
jump @LOWR_777 

:LOWR_820
127@ = 0 
128@ = 0 
129@ = 0 
130@ = 0 
132@ = 0 
0085: 132@ = 130@ 
0085: 132@ = 130@ 
0085: 132@ = 130@ 
0085: 132@ = 130@ 
0085: 132@ = 130@ 
132@ = 0 
269@ = 0.01 
if 
  35@ == -1 
else_jump @LOWR_930 

:LOWR_930
054C: use_GXT_table 'LOWR' 
0732: random_car_generator_disable_model #SAVANNA 
gosub @LOWR_27192 
34@ = 3 
return 

:LOWR_962
if 
  35@ == 0 
else_jump @LOWR_2161 
042B: clear_peds_from_cube_cornerA 1721.117 -1967.489 11.0 cornerB 1904.391 -1838.315 15.0 
127@ = 0 
128@ = 0 
138@ = 1796.947 
145@ = -1924.376 
152@ = 13.2937 
159@ = 60.9627 
139@ = 1802.865 
146@ = -1918.742 
153@ = 13.2965 
160@ = 357.6195 
140@ = 1788.992 
147@ = -1924.501 
154@ = 13.2937 
161@ = 305.5176 
141@ = 1784.189 
148@ = -1913.44 
155@ = 13.2957 
162@ = 188.9639 
142@ = 1790.964 
149@ = -1913.898 
156@ = 13.2985 
163@ = 266.2616 
143@ = 1799.899 
150@ = -1906.425 
157@ = 13.3025 
164@ = 184.4735 
144@ = 1785.94 
151@ = -1904.839 
158@ = 13.297 
165@ = 152.5742 
166@ = 1798.603 
188@ = -1908.26 
210@ = 12.4388 
232@ = 102.3995 
167@ = 1798.887 
189@ = -1907.668 
211@ = 12.4399 
233@ = 174.1189 
168@ = 1798.834 
190@ = -1911.782 
212@ = 12.4374 
234@ = 158.2591 
169@ = 1799.584 
191@ = -1912.795 
213@ = 12.4368 
235@ = 74.6392 
170@ = 1800.902 
192@ = -1918.714 
214@ = 12.4331 
236@ = 256.6391 
171@ = 1798.166 
193@ = -1920.427 
215@ = 12.4321 
237@ = 19.6592 
172@ = 1796.811 
194@ = -1920.426 
216@ = 12.4321 
238@ = 331.8393 
173@ = 1787.78 
195@ = -1919.071 
217@ = 12.4329 
239@ = 331.8393 
174@ = 1786.71 
196@ = -1917.982 
218@ = 12.4332 
240@ = 285.8198 
175@ = 1786.194 
197@ = -1907.356 
219@ = 12.4327 
241@ = 260.4003 
176@ = 1786.898 
198@ = -1906.531 
220@ = 12.4335 
242@ = 141.9807 
177@ = 1786.23 
199@ = -1908.622 
221@ = 12.4328 
243@ = 327.1608 
178@ = 1789.188 
200@ = -1919.665 
222@ = 12.4325 
244@ = 357.2196 
179@ = 1788.103 
201@ = -1907.949 
223@ = 12.4352 
245@ = 200.9411 
180@ = 1797.997 
202@ = -1912.74 
224@ = 12.4368 
246@ = 312.2806 
181@ = 1796.46 
203@ = -1908.882 
225@ = 12.4368 
247@ = 312.2806 
Model.Load(#VLA1)
Model.Load(#VLA2)
Model.Load(#VLA3)
Model.Load(#BFYPRO)
Model.Load(#HFYST)
Model.Load(#SAVANNA)
Model.Load(#REMINGTN)
04ED: load_animation ""LOWRIDER"" 
038B: load_requested_models 

:LOWR_1990
if or
   not Model.Available(#VLA1)
   not Model.Available(#VLA2)
   not Model.Available(#VLA3)
   not Model.Available(#BFYPRO)
   not Model.Available(#HFYST)
else_jump @LOWR_2032 
wait 0 
jump @LOWR_1990 

:LOWR_2032
if or
   not Model.Available(#SAVANNA)
   not Model.Available(#REMINGTN)
else_jump @LOWR_2064 
wait 0 
jump @LOWR_2032 

:LOWR_2064
if 
84EE:   not animation ""LOWRIDER"" loaded 
else_jump @LOWR_2098 
wait 0 
jump @LOWR_2064 

:LOWR_2098
if 
875C:   not marker 102@ enabled 
else_jump @LOWR_2134 
018A: 102@ = create_checkpoint_at 1793.068 -1904.254 12.3989 

:LOWR_2134
0917: audio_zone 'LOWRIDE' enable_sound 1 
" + _6471 + @" = 0 
35@ += 1 

:LOWR_2161
if 
  35@ == 1 
else_jump @LOWR_9428 
if 
  128@ == 0 
else_jump @LOWR_3625 
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 1792.924 -1918.987 radius 150.0 150.0 
else_jump @LOWR_3618 
69@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
70@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
71@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
72@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
73@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
74@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
75@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
0229: set_car 69@ primary_color_to 1 secondary_color_to 0 
0229: set_car 70@ primary_color_to 2 secondary_color_to 1 
0229: set_car 71@ primary_color_to 3 secondary_color_to 2 
0229: set_car 72@ primary_color_to 10 secondary_color_to 3 
0229: set_car 73@ primary_color_to 9 secondary_color_to 4 
0229: set_car 74@ primary_color_to 6 secondary_color_to 5 
0229: set_car 75@ primary_color_to 7 secondary_color_to 6 
03A2: set_car 69@ action 3 
03A2: set_car 73@ action 3 
03A2: set_car 72@ action 3 
Car.ToggleHydraulics(69@) = True
Car.ToggleHydraulics(73@) = True
Car.ToggleHydraulics(72@) = True
Car.ImmuneToNonPlayer(69@) = True
Car.ImmuneToNonPlayer(73@) = True
Car.ImmuneToNonPlayer(72@) = True
43@ = 0 

:LOWR_2529
if 
  7 > 43@ 
else_jump @LOWR_2618 
Car.PutAt(69@(43@,7i), 138@(43@,7f), 145@(43@,7f), 152@(43@,7f))
Car.Angle(69@(43@,7i)) = 159@(43@,7f)
Car.DoorStatus(69@(43@,7i)) = 3
43@ += 1 
jump @LOWR_2529 

:LOWR_2618
wait 0 
77@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
79@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
80@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
82@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
wait 0 
83@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
85@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
86@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
88@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
89@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
wait 0 
78@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
81@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
84@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
87@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
90@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
91@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
92@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
wait 0 
93@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
94@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
95@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
96@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
97@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
98@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
43@ = 0 

:LOWR_3169
if 
  16 > 43@ 
else_jump @LOWR_3287 
if 
056D:   actor 77@(43@,22i) defined 
else_jump @LOWR_3273 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_3273 
Actor.PutAt(77@(43@,22i), 166@(43@,22f), 188@(43@,22f), 210@(43@,22f))
Actor.Angle(77@(43@,22i)) = 232@(43@,22f)

:LOWR_3273
43@ += 1 
jump @LOWR_3169 

:LOWR_3287
wait 0 
43@ = 0 

:LOWR_3298
if 
  22 > 43@ 
else_jump @LOWR_3362 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_3348 
060B: set_actor 77@(43@,22i) decision_maker_to 67@ 

:LOWR_3348
43@ += 4 
jump @LOWR_3298 

:LOWR_3362
if 
   not Actor.Dead(93@)
else_jump @LOWR_3402 
if 
   not Car.Wrecked(70@)
else_jump @LOWR_3402 
036A: put_actor 93@ in_car 70@ 

:LOWR_3402
if 
   not Actor.Dead(94@)
else_jump @LOWR_3442 
if 
   not Car.Wrecked(71@)
else_jump @LOWR_3442 
036A: put_actor 94@ in_car 71@ 

:LOWR_3442
if 
   not Actor.Dead(95@)
else_jump @LOWR_3482 
if 
   not Car.Wrecked(73@)
else_jump @LOWR_3482 
036A: put_actor 95@ in_car 73@ 

:LOWR_3482
if 
   not Actor.Dead(96@)
else_jump @LOWR_3522 
if 
   not Car.Wrecked(69@)
else_jump @LOWR_3522 
036A: put_actor 96@ in_car 69@ 

:LOWR_3522
if 
   not Actor.Dead(97@)
else_jump @LOWR_3562 
if 
   not Car.Wrecked(72@)
else_jump @LOWR_3562 
036A: put_actor 97@ in_car 72@ 

:LOWR_3562
if 
   not Actor.Dead(98@)
else_jump @LOWR_3604 
if 
   not Car.Wrecked(71@)
else_jump @LOWR_3604 
0430: put_actor 98@ into_car 71@ passenger_seat 0 

:LOWR_3604
128@ = 1 
" + _1906 + @" = 1 

:LOWR_3618
jump @LOWR_3766 

:LOWR_3625
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point 1792.924 -1918.987 radius 150.0 150.0 
else_jump @LOWR_3766 
43@ = 0 

:LOWR_3670
if 
  7 > 43@ 
else_jump @LOWR_3711 
Car.Destroy(69@(43@,7i))
43@ += 1 
jump @LOWR_3670 

:LOWR_3711
43@ = 0 

:LOWR_3718
if 
  22 > 43@ 
else_jump @LOWR_3759 
Actor.DestroyInstantly(77@(43@,22i))
43@ += 1 
jump @LOWR_3718 

:LOWR_3759
128@ = 0 

:LOWR_3766
if 
  128@ == 1 
else_jump @LOWR_9015 
if 
  127@ == 0 
else_jump @LOWR_8729 
0871: init_jump_table 39@ total_jumps 21 default_jump 0 @LOWR_8009 jumps 0 @LOWR_3995 1 @LOWR_4371 2 @LOWR_4747 3 @LOWR_4897 4 @LOWR_5047 5 @LOWR_5162 6 @LOWR_5312 
0872: jump_table_jumps 7 @LOWR_5462 8 @LOWR_5578 9 @LOWR_5694 10 @LOWR_6070 11 @LOWR_6253 12 @LOWR_6369 13 @LOWR_6485 14 @LOWR_6792 15 @LOWR_7117 
0872: jump_table_jumps 16 @LOWR_7401 17 @LOWR_7510 18 @LOWR_7619 19 @LOWR_7826 20 @LOWR_8002 -1 @LOWR_8009 -1 @LOWR_8009 -1 @LOWR_8009 -1 @LOWR_8009 

:LOWR_3995
if 
   not Actor.Dead(77@)
else_jump @LOWR_4364 
062E: get_actor 77@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_4269 
0615: define_AS_pack_begin 49@ 
if 
   not Car.Wrecked(74@)
else_jump @LOWR_4203 
if 
01AF:   car 74@ sphere 0 in_sphere 143@ 150@ 157@ radius 0.2 0.2 1.0 
else_jump @LOWR_4155 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
jump @LOWR_4196 

:LOWR_4155
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_4196
jump @LOWR_4244 

:LOWR_4203
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_4244
0616: define_AS_pack_end 49@ 
0618: assign_actor 77@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 
jump @LOWR_4364 

:LOWR_4269
if 
   Actor.Animation(77@) == ""M_SMKLEAN_LOOP""
else_jump @LOWR_4364 
if 
   not Car.Wrecked(74@)
else_jump @LOWR_4364 
if 
81AF:   not car 74@ sphere 0 in_sphere 143@ 150@ 157@ radius 0.2 0.2 1.0 
else_jump @LOWR_4364 
0687: clear_actor 77@ task 

:LOWR_4364
jump @LOWR_8009 

:LOWR_4371
if 
   not Actor.Dead(78@)
else_jump @LOWR_4740 
062E: get_actor 78@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_4645 
0615: define_AS_pack_begin 49@ 
if 
   not Car.Wrecked(74@)
else_jump @LOWR_4579 
if 
01AF:   car 74@ sphere 0 in_sphere 143@ 150@ 157@ radius 0.2 0.2 1.0 
else_jump @LOWR_4531 
0605: actor -1 perform_animation ""F_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
jump @LOWR_4572 

:LOWR_4531
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_4572
jump @LOWR_4620 

:LOWR_4579
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_4620
0616: define_AS_pack_end 49@ 
0618: assign_actor 78@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 
jump @LOWR_4740 

:LOWR_4645
if 
   Actor.Animation(78@) == ""F_SMKLEAN_LOOP""
else_jump @LOWR_4740 
if 
   not Car.Wrecked(74@)
else_jump @LOWR_4740 
if 
81AF:   not car 74@ sphere 0 in_sphere 143@ 150@ 157@ radius 0.2 0.2 1.0 
else_jump @LOWR_4740 
0687: clear_actor 78@ task 

:LOWR_4740
jump @LOWR_8009 

:LOWR_4747
if 
   not Actor.Dead(79@)
else_jump @LOWR_4890 
062E: get_actor 79@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_4890 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(80@)
else_jump @LOWR_4831 
0677: AS_actor -1 chat_with_actor 80@ lead_speaker_flag 1 unknown_flag 1 
jump @LOWR_4872 

:LOWR_4831
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_4872
0616: define_AS_pack_end 49@ 
0618: assign_actor 79@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_4890
jump @LOWR_8009 

:LOWR_4897
if 
   not Actor.Dead(80@)
else_jump @LOWR_5040 
062E: get_actor 80@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5040 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(79@)
else_jump @LOWR_4981 
0677: AS_actor -1 chat_with_actor 79@ lead_speaker_flag 0 unknown_flag 1 
jump @LOWR_5022 

:LOWR_4981
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_5022
0616: define_AS_pack_end 49@ 
0618: assign_actor 80@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_5040
jump @LOWR_8009 

:LOWR_5047
if 
   not Actor.Dead(81@)
else_jump @LOWR_5155 
062E: get_actor 81@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5155 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""CAR_HOOKERTALK"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 81@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_5155
jump @LOWR_8009 

:LOWR_5162
if 
   not Actor.Dead(82@)
else_jump @LOWR_5305 
062E: get_actor 82@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5305 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(83@)
else_jump @LOWR_5246 
0677: AS_actor -1 chat_with_actor 83@ lead_speaker_flag 0 unknown_flag 1 
jump @LOWR_5287 

:LOWR_5246
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_5287
0616: define_AS_pack_end 49@ 
0618: assign_actor 82@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_5305
jump @LOWR_8009 

:LOWR_5312
if 
   not Actor.Dead(83@)
else_jump @LOWR_5455 
062E: get_actor 83@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5455 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(82@)
else_jump @LOWR_5396 
0677: AS_actor -1 chat_with_actor 82@ lead_speaker_flag 1 unknown_flag 1 
jump @LOWR_5437 

:LOWR_5396
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_5437
0616: define_AS_pack_end 49@ 
0618: assign_actor 83@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_5455
jump @LOWR_8009 

:LOWR_5462
if 
   not Actor.Dead(84@)
else_jump @LOWR_5571 
062E: get_actor 84@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5571 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 84@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_5571
jump @LOWR_8009 

:LOWR_5578
if 
   not Actor.Dead(85@)
else_jump @LOWR_5687 
062E: get_actor 85@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5687 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 85@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_5687
jump @LOWR_8009 

:LOWR_5694
if 
   not Actor.Dead(86@)
else_jump @LOWR_6063 
062E: get_actor 86@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_5968 
0615: define_AS_pack_begin 49@ 
if 
   not Car.Wrecked(75@)
else_jump @LOWR_5902 
if 
01AF:   car 75@ sphere 0 in_sphere 144@ 151@ 158@ radius 0.2 0.2 1.0 
else_jump @LOWR_5854 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
jump @LOWR_5895 

:LOWR_5854
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_5895
jump @LOWR_5943 

:LOWR_5902
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 

:LOWR_5943
0616: define_AS_pack_end 49@ 
0618: assign_actor 86@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 
jump @LOWR_6063 

:LOWR_5968
if 
   Actor.Animation(86@) == ""M_SMKLEAN_LOOP""
else_jump @LOWR_6063 
if 
   not Car.Wrecked(75@)
else_jump @LOWR_6063 
if 
81AF:   not car 75@ sphere 0 in_sphere 144@ 151@ 158@ radius 0.2 0.2 1.0 
else_jump @LOWR_6063 
0687: clear_actor 86@ task 

:LOWR_6063
jump @LOWR_8009 

:LOWR_6070
if 
   not Actor.Dead(87@)
else_jump @LOWR_6246 
062E: get_actor 87@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_6246 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
0605: actor -1 perform_animation ""WOMAN_IDLESTANCE"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 87@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_6246
jump @LOWR_8009 

:LOWR_6253
if 
   not Actor.Dead(88@)
else_jump @LOWR_6362 
062E: get_actor 88@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_6362 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 88@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_6362
jump @LOWR_8009 

:LOWR_6369
if 
   not Actor.Dead(89@)
else_jump @LOWR_6478 
062E: get_actor 89@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_6478 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 89@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_6478
jump @LOWR_8009 

:LOWR_6485
if 
   not Actor.Dead(90@)
else_jump @LOWR_6785 
062E: get_actor 90@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_6785 
0615: define_AS_pack_begin 49@ 
05D3: AS_actor -1 goto_point 1786.719 -1915.878 12.3942 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1796.179 -1919.465 12.3928 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1786.719 -1915.878 12.3942 mode 4 time 60000 ms 
05D3: AS_actor -1 goto_point 179@ 201@ 223@ mode 4 time 60000 ms 
if 
   not Actor.Dead(86@)
else_jump @LOWR_6726 
0639: AS_actor -1 rotate_to_actor 86@ 

:LOWR_6726
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 90@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_6785
jump @LOWR_8009 

:LOWR_6792
if 
   not Actor.Dead(91@)
else_jump @LOWR_7110 
062E: get_actor 91@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_7110 
0615: define_AS_pack_begin 49@ 
05D3: AS_actor -1 goto_point 1800.367 -1917.394 12.3938 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1789.057 -1917.901 12.3936 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1788.526 -1907.294 12.3955 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1796.478 -1908.174 12.3983 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 91@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_7110
jump @LOWR_8009 

:LOWR_7117
if 
   not Actor.Dead(92@)
else_jump @LOWR_7394 
062E: get_actor 92@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_7394 
0615: define_AS_pack_begin 49@ 
05D3: AS_actor -1 goto_point 1787.672 -1908.567 12.3949 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1786.719 -1917.107 12.3942 mode 4 time 60000 ms 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
05D3: AS_actor -1 goto_point 1787.672 -1908.567 12.3949 mode 4 time 60000 ms 
05D3: AS_actor -1 goto_point 181@ 203@ 225@ mode 4 time 60000 ms 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 92@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_7394
jump @LOWR_8009 

:LOWR_7401
if 
   not Actor.Dead(93@)
else_jump @LOWR_7503 
062E: get_actor 93@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_7503 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""TAP_HAND"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 93@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_7503
jump @LOWR_8009 

:LOWR_7510
if 
   not Actor.Dead(94@)
else_jump @LOWR_7612 
062E: get_actor 94@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_7612 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""TAP_HAND"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 94@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_7612
jump @LOWR_8009 

:LOWR_7619
43@ = 0 

:LOWR_7626
if 
  7 > 43@ 
else_jump @LOWR_7819 
if 
056E:   car 69@(43@,7i) defined 
else_jump @LOWR_7805 
if 
   not Car.Wrecked(69@(43@,7i))
else_jump @LOWR_7775 
if 
051C:   car 69@(43@,7i) damaged_by_actor " + PlayerActor + @" 
else_jump @LOWR_7768 
44@ = Car.Health(69@(43@,7i))
if 
  950 > 44@ 
else_jump @LOWR_7768 
00BC: show_text_highpriority GXT 'LOW_32' time 5000 flag 1  
127@ = 1 
43@ = 7 

:LOWR_7768
jump @LOWR_7805 

:LOWR_7775
00BC: show_text_highpriority GXT 'LOW_32' time 5000 flag 1  
127@ = 1 
43@ = 7 

:LOWR_7805
43@ += 1 
jump @LOWR_7626 

:LOWR_7819
jump @LOWR_8009 

:LOWR_7826
43@ = 0 

:LOWR_7833
if 
  22 > 43@ 
else_jump @LOWR_7995 
if 
056D:   actor 77@(43@,22i) defined 
else_jump @LOWR_7981 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_7951 
if 
051A:   actor 77@(43@,22i) damaged_by_actor " + PlayerActor + @" 
else_jump @LOWR_7944 
00BC: show_text_highpriority GXT 'LOW_04' time 5000 flag 1  
127@ = 1 
43@ = 22 

:LOWR_7944
jump @LOWR_7981 

:LOWR_7951
00BC: show_text_highpriority GXT 'LOW_04' time 5000 flag 1  
127@ = 1 
43@ = 22 

:LOWR_7981
43@ += 1 
jump @LOWR_7833 

:LOWR_7995
jump @LOWR_8009 

:LOWR_8002
jump @LOWR_8009 

:LOWR_8009
if 
  300 > 133@ 
else_jump @LOWR_8075 
254@ = 1.0 
257@ = 1.0 
260@ = 0.0 
263@ = 0.0 
jump @LOWR_8148 

:LOWR_8075
if 
  133@ > 500 
else_jump @LOWR_8108 
133@ = 0 
jump @LOWR_8148 

:LOWR_8108
254@ = 0.0 
257@ = 0.0 
260@ = 0.0 
263@ = 0.0 

:LOWR_8148
if 
  134@ > 2000 
else_jump @LOWR_8222 
0209: 283@ = random_int_in_ranges 0 16 
gosub @LOWR_20100 
0087: 255@ = 281@ 
0087: 258@ = 279@ 
0087: 261@ = 282@ 
0087: 264@ = 280@ 
134@ = 0 

:LOWR_8222
if 
  135@ > 300 
else_jump @LOWR_8296 
0209: 283@ = random_int_in_ranges 0 16 
gosub @LOWR_20100 
0087: 256@ = 281@ 
0087: 259@ = 279@ 
0087: 262@ = 282@ 
0087: 265@ = 280@ 
135@ = 0 

:LOWR_8296
if 
   not Car.Wrecked(69@)
else_jump @LOWR_8438 
if 
   Car.HasHydraulics(69@)
else_jump @LOWR_8438 
07F5: car 69@ control_hydraulics 257@ 263@ 254@ 260@ 
Car.StorePos(69@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 50@ = 138@ 
0065: 50@ -= " + tempvar_Float_1 + @" 
0087: 51@ = 145@ 
0065: 51@ -= " + tempvar_Float_2 + @" 
006B: 50@ *= 269@ 
006B: 51@ *= 269@ 
07D5: set_car 69@ velocity_in_direction_XYZ 50@ 51@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWR_8438
if 
   not Car.Wrecked(72@)
else_jump @LOWR_8580 
if 
   Car.HasHydraulics(72@)
else_jump @LOWR_8580 
07F5: car 72@ control_hydraulics 258@ 264@ 255@ 261@ 
Car.StorePos(72@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 50@ = 141@ 
0065: 50@ -= " + tempvar_Float_1 + @" 
0087: 51@ = 148@ 
0065: 51@ -= " + tempvar_Float_2 + @" 
006B: 50@ *= 269@ 
006B: 51@ *= 269@ 
07D5: set_car 72@ velocity_in_direction_XYZ 50@ 51@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWR_8580
if 
   not Car.Wrecked(73@)
else_jump @LOWR_8722 
if 
   Car.HasHydraulics(73@)
else_jump @LOWR_8722 
07F5: car 73@ control_hydraulics 259@ 265@ 256@ 262@ 
Car.StorePos(73@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 50@ = 142@ 
0065: 50@ -= " + tempvar_Float_1 + @" 
0087: 51@ = 149@ 
0065: 51@ -= " + tempvar_Float_2 + @" 
006B: 50@ *= 269@ 
006B: 51@ *= 269@ 
07D5: set_car 73@ velocity_in_direction_XYZ 50@ 51@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWR_8722
jump @LOWR_9015 

:LOWR_8729
if 
  127@ == 1 
else_jump @LOWR_9015 
43@ = 0 

:LOWR_8754
if 
  12 > 43@ 
else_jump @LOWR_8815 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_8801 
0792: disembark_instantly_actor 77@(43@,22i) 

:LOWR_8801
43@ += 1 
jump @LOWR_8754 

:LOWR_8815
if 
   not 37@ == 1 
else_jump @LOWR_8905 
43@ = 0 

:LOWR_8840
if 
  22 > 43@ 
else_jump @LOWR_8905 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_8891 
077A: set_actor 77@(43@,22i) acquaintance 4 to_actors_pedtype 0 

:LOWR_8891
43@ += 1 
jump @LOWR_8840 

:LOWR_8905
43@ = 0 

:LOWR_8912
if 
  22 > 43@ 
else_jump @LOWR_8953 
Actor.RemoveReferences(77@(43@,22i))
43@ += 1 
jump @LOWR_8912 

:LOWR_8953
43@ = 0 

:LOWR_8960
if 
  7 > 43@ 
else_jump @LOWR_9001 
Car.RemoveReferences(69@(43@,7i))
43@ += 1 
jump @LOWR_8960 

:LOWR_9001
37@ = 1 
127@ += 1 

:LOWR_9015
if 
  " + _6471 + @" > 120000 
else_jump @LOWR_9066 
00BC: show_text_highpriority GXT 'LOW_35' time 5000 flag 1  
37@ = 1 
jump @LOWR_9428 

:LOWR_9066
if 
0100:   actor " + PlayerActor + @" in_sphere 1793.068 -1904.254 12.3989 radius 4.0 4.0 4.0 sphere 1 in_car 
else_jump @LOWR_9403 
" + tempvar_Actor_Car + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
096E:   car " + tempvar_Actor_Car + @" lowrider 
else_jump @LOWR_9355 
if 
   Car.HasHydraulics(" + tempvar_Actor_Car + @")
else_jump @LOWR_9307 
43@ = Player.Money(" + PlayerChar + @")
if 
002D:   43@ >= 271@ 
else_jump @LOWR_9256 
06C7: AS_actor " + PlayerActor + @" driver_of_car " + tempvar_Actor_Car + @" perform_action 6 timelimit 2000000 
35@ = 99 
Player.CanMove(" + PlayerChar + @") = False
68@ = Actor.MissionCar(" + PlayerActor + @")
fade 0 500 

:LOWR_9225
if 
fading 
else_jump @LOWR_9249 
wait 0 
jump @LOWR_9225 

:LOWR_9249
jump @LOWR_9300 

:LOWR_9256
if 
  62@ == 0 
else_jump @LOWR_9300 
01E5: show_text_1number_highpriority GXT 'LOW_38' number 271@ time 5000 flag 1  
62@ += 1 

:LOWR_9300
jump @LOWR_9348 

:LOWR_9307
if 
  62@ == 0 
else_jump @LOWR_9348 
00BC: show_text_highpriority GXT 'LOW_36' time 5000 flag 1  
62@ += 1 

:LOWR_9348
jump @LOWR_9396 

:LOWR_9355
if 
  62@ == 0 
else_jump @LOWR_9396 
00BC: show_text_highpriority GXT 'LOW_36' time 5000 flag 1  
62@ += 1 

:LOWR_9396
jump @LOWR_9428 

:LOWR_9403
if 
   not 62@ == 0 
else_jump @LOWR_9428 
62@ = 0 

:LOWR_9428
if 
  35@ == 99 
else_jump @LOWR_9453 
gosub @LOWR_27192 

:LOWR_9453
return 

:LOWR_9455
if 
  35@ == 0 
else_jump @LOWR_10048 
fade 0 500 

:LOWR_9480
if 
fading 
else_jump @LOWR_9504 
wait 0 
jump @LOWR_9480 

:LOWR_9504
if 
   not Car.Wrecked(68@)
else_jump @LOWR_9525 
09FE: reset_hydraulics_on_car 68@ 

:LOWR_9525
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
0395: clear_area 1 at 1793.068 -1904.254 12.3989 radius 30.0 
if 
075C:   marker 102@ enabled 
else_jump @LOWR_9584 
Marker.Disable(102@)

:LOWR_9584
if 
   not Car.Wrecked(68@)
else_jump @LOWR_9630 
Car.PutAt(68@, 1793.068, -1904.254, 12.3989)
Car.Angle(68@) = 171.6728

:LOWR_9630
43@ = 0 

:LOWR_9637
if 
  16 > 43@ 
else_jump @LOWR_9698 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_9684 
0792: disembark_instantly_actor 77@(43@,22i) 

:LOWR_9684
43@ += 1 
jump @LOWR_9637 

:LOWR_9698
43@ = 0 

:LOWR_9705
if 
  22 > 43@ 
else_jump @LOWR_9769 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_9755 
060B: set_actor 77@(43@,22i) decision_maker_to 66@ 

:LOWR_9755
43@ += 1 
jump @LOWR_9705 

:LOWR_9769
43@ = 0 

:LOWR_9776
if 
  16 > 43@ 
else_jump @LOWR_9874 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_9860 
Actor.PutAt(77@(43@,22i), 166@(43@,22f), 188@(43@,22f), 210@(43@,22f))
Actor.Angle(77@(43@,22i)) = 232@(43@,22f)

:LOWR_9860
43@ += 1 
jump @LOWR_9776 

:LOWR_9874
43@ = 0 

:LOWR_9881
if 
  7 > 43@ 
else_jump @LOWR_9979 
if 
   not Car.Wrecked(69@(43@,7i))
else_jump @LOWR_9965 
Car.PutAt(69@(43@,7i), 138@(43@,7f), 145@(43@,7f), 152@(43@,7f))
Car.Angle(69@(43@,7i)) = 159@(43@,7f)

:LOWR_9965
43@ += 1 
jump @LOWR_9881 

:LOWR_9979
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
Camera.SetPosition(1796.749, -1916.961, 13.8583, 0.0, 0.0, 0.0)
Camera.PointAt(1796.125, -1916.181, 13.807, 2)
35@ += 1 

:LOWR_10048
if 
  35@ == 1 
else_jump @LOWR_10073 
35@ += 1 

:LOWR_10073
if 
  35@ == 2 
else_jump @LOWR_10231 
if 
   not Actor.Dead(95@)
else_jump @LOWR_10231 
0792: disembark_instantly_actor 95@ 
Actor.PutAt(95@, 1792.631, -1909.274, 12.4371)
Actor.Angle(95@) = 331.0204
Camera.SetPosition(1793.816, -1910.713, 14.0346, 0.0, 0.0, 0.0)
Camera.PointAt(1793.453, -1909.801, 13.8451, 2)
fade 1 500 

:LOWR_10200
if 
fading 
else_jump @LOWR_10224 
wait 0 
jump @LOWR_10200 

:LOWR_10224
35@ += 1 

:LOWR_10231
if 
  35@ == 3 
else_jump @LOWR_10698 
if 
   not Actor.Dead(95@)
else_jump @LOWR_10698 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""PRTIAL_GNGTLKD"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
0605: actor -1 perform_animation ""PRTIAL_GNGTLKE"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
0605: actor -1 perform_animation ""PRTIAL_GNGTLKF"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
0605: actor -1 perform_animation ""PRTIAL_GNGTLKG"" IFP ""LOWRIDER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 95@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 
0209: 43@ = random_int_in_ranges 0 3 
0871: init_jump_table 43@ total_jumps 3 default_jump 0 @LOWR_10684 jumps 0 @LOWR_10540 1 @LOWR_10588 2 @LOWR_10636 -1 @LOWR_10684 -1 @LOWR_10684 -1 @LOWR_10684 -1 @LOWR_10684 

:LOWR_10540
05A9: " + Actor_Speech_GXT_Reference + @" = 'LOWR_BA' 
04AE: " + Actor_Speech_WAV_File + @" = 22808" );
create_thread<AUDIOL>( _local95, 0, 1, 1, 0 );
AppendLine( @"jump @LOWR_10684 

:LOWR_10588
05A9: " + Actor_Speech_GXT_Reference + @" = 'LOWR_BB' 
04AE: " + Actor_Speech_WAV_File + @" = 22809" );
create_thread<AUDIOL>( _local95, 0, 1, 1, 0 );
AppendLine( @"jump @LOWR_10684 

:LOWR_10636
05A9: " + Actor_Speech_GXT_Reference + @" = 'LOWR_BC' 
04AE: " + Actor_Speech_WAV_File + @" = 22810" );
create_thread<AUDIOL>( _local95, 0, 1, 1, 0 );
AppendLine( @"jump @LOWR_10684 

:LOWR_10684
32@ = 0 
35@ += 1 

:LOWR_10698
if 
  35@ == 4 
else_jump @LOWR_10812 
if 
  32@ > 1000 
else_jump @LOWR_10812 
if or
  " + Audio_Line_Is_Active + @" == 0 
00E1:   player 0 pressed_key 16 
else_jump @LOWR_10812" );
create_thread<CLEANAU>();
AppendLine( @"040D: unload_wav 1 
040D: unload_wav 2 
00BE: text_clear_all 
35@ += 1 
131@ = 1 
if 
   not Actor.Dead(95@)
else_jump @LOWR_10812 
0687: clear_actor 95@ task 

:LOWR_10812
if 
  35@ == 5 
else_jump @LOWR_10944 
00BE: text_clear_all 
02A3: enable_widescreen 0 
Camera.SetPosition(1793.485, -1907.354, 13.4436, 0.0, 0.0, 0.0)
Camera.PointAt(1793.129, -1908.289, 13.4481, 2)
0085: 273@ = 271@ 
0085: 43@ = 273@ 
43@ *= -1 
Player.Money(" + PlayerChar + @") += 43@
0512: show_permanent_text_box 'LOW_37'  
03F0: enable_text_draw 1 
wait 1 
35@ += 1 

:LOWR_10944
if 
  35@ == 6 
else_jump @LOWR_12351 
if and
09FA:   is_menu_closed 
0A0F:   new_language_set 
else_jump @LOWR_10990 
03E6: remove_text_box 
0512: show_permanent_text_box 'LOW_37'  

:LOWR_10990
if 
00E1:   player 0 pressed_key 14 
else_jump @LOWR_11416 
if and
   not 274@ == 1 
   not 274@ == -1 
else_jump @LOWR_11365 
if 
  273@ >= 10000 
else_jump @LOWR_11066 
270@ = 1000 
jump @LOWR_11170 

:LOWR_11066
if 
  273@ >= 1000 
else_jump @LOWR_11099 
270@ = 100 
jump @LOWR_11170 

:LOWR_11099
if 
  273@ >= 100 
else_jump @LOWR_11131 
270@ = 10 
jump @LOWR_11170 

:LOWR_11131
if 
  273@ == 0 
else_jump @LOWR_11163 
270@ = 2 
jump @LOWR_11170 

:LOWR_11163
270@ = 1 

:LOWR_11170
43@ = Player.Money(" + PlayerChar + @")
if 
001D:   270@ > 43@ 
else_jump @LOWR_11205 
0085: 270@ = 43@ 

:LOWR_11205
0085: 43@ = 273@ 
005A: 43@ += 270@ 
if 
001D:   43@ > 272@ 
else_jump @LOWR_11256 
0085: 270@ = 272@ 
0062: 270@ -= 273@ 

:LOWR_11256
if 
  0 > 270@ 
else_jump @LOWR_11281 
270@ *= -1 

:LOWR_11281
005A: 273@ += 270@ 
005A: 275@ += 270@ 
270@ *= -1 
Player.Money(" + PlayerChar + @") += 270@
274@ += 1 
if 
  274@ > 1 
else_jump @LOWR_11351 
274@ = 2 
jump @LOWR_11358 

:LOWR_11351
32@ = 0 

:LOWR_11358
jump @LOWR_11409 

:LOWR_11365
if 
  274@ == 1 
else_jump @LOWR_11409 
if 
  32@ > 500 
else_jump @LOWR_11409 
274@ = 2 

:LOWR_11409
jump @LOWR_11807 

:LOWR_11416
if 
   not 274@ == 0 
else_jump @LOWR_11441 
274@ = 0 

:LOWR_11441
if 
00E1:   player 0 pressed_key 17 
else_jump @LOWR_11782 
if 
   not 276@ == 1 
else_jump @LOWR_11749 
if 
  273@ > 10000 
else_jump @LOWR_11510 
270@ = -1000 
jump @LOWR_11582 

:LOWR_11510
if 
  273@ > 1000 
else_jump @LOWR_11543 
270@ = -100 
jump @LOWR_11582 

:LOWR_11543
if 
  273@ > 100 
else_jump @LOWR_11575 
270@ = -10 
jump @LOWR_11582 

:LOWR_11575
270@ = -1 

:LOWR_11582
0085: 43@ = 273@ 
005A: 273@ += 270@ 
if 
001D:   271@ > 273@ 
else_jump @LOWR_11639 
273@ = 0 
0085: 270@ = 43@ 
270@ *= -1 

:LOWR_11639
if 
001D:   271@ > 273@ 
else_jump @LOWR_11673 
0085: 273@ = 271@ 
jump @LOWR_11696 

:LOWR_11673
270@ *= -1 
0062: 275@ -= 270@ 
Player.Money(" + PlayerChar + @") += 270@

:LOWR_11696
276@ += 1 
if 
  276@ > 1 
else_jump @LOWR_11735 
276@ = 2 
jump @LOWR_11742 

:LOWR_11735
32@ = 0 

:LOWR_11742
jump @LOWR_11775 

:LOWR_11749
if 
  32@ > 500 
else_jump @LOWR_11775 
276@ = 2 

:LOWR_11775
jump @LOWR_11807 

:LOWR_11782
if 
   not 276@ == 0 
else_jump @LOWR_11807 
276@ = 0 

:LOWR_11807
gosub @LOWR_26737 
if 
  131@ == 0 
else_jump @LOWR_11883 
if 
00E1:   player 0 pressed_key 16 
else_jump @LOWR_11876 
0093: 46@ = integer 273@ to_float 
46@ *= 0.1 
03E6: remove_text_box 
35@ += 1 

:LOWR_11876
jump @LOWR_11907 

:LOWR_11883
if 
80E1:   not player 0 pressed_key 16 
else_jump @LOWR_11907 
131@ = 0 

:LOWR_11907
if 
00E1:   player 0 pressed_key 15 
else_jump @LOWR_12351 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
if 
056E:   car 70@ defined 
else_jump @LOWR_11960 
Car.Destroy(70@)

:LOWR_11960
if 
056E:   car 73@ defined 
else_jump @LOWR_11981 
Car.Destroy(73@)

:LOWR_11981
if 
056E:   car 71@ defined 
else_jump @LOWR_12002 
Car.Destroy(71@)

:LOWR_12002
if 
056E:   car 74@ defined 
else_jump @LOWR_12023 
Car.Destroy(74@)

:LOWR_12023
if 
056E:   car 72@ defined 
else_jump @LOWR_12044 
Car.Destroy(72@)

:LOWR_12044
if 
056D:   actor 78@ defined 
else_jump @LOWR_12065 
Actor.DestroyInstantly(78@)

:LOWR_12065
if 
056D:   actor 80@ defined 
else_jump @LOWR_12086 
Actor.DestroyInstantly(80@)

:LOWR_12086
if 
056D:   actor 93@ defined 
else_jump @LOWR_12107 
Actor.DestroyInstantly(93@)

:LOWR_12107
if 
056D:   actor 83@ defined 
else_jump @LOWR_12128 
Actor.DestroyInstantly(83@)

:LOWR_12128
if 
056D:   actor 84@ defined 
else_jump @LOWR_12149 
Actor.DestroyInstantly(84@)

:LOWR_12149
if 
056D:   actor 86@ defined 
else_jump @LOWR_12170 
Actor.DestroyInstantly(86@)

:LOWR_12170
if 
056D:   actor 87@ defined 
else_jump @LOWR_12191 
Actor.DestroyInstantly(87@)

:LOWR_12191
if 
056D:   actor 89@ defined 
else_jump @LOWR_12212 
Actor.DestroyInstantly(89@)

:LOWR_12212
if 
056D:   actor 97@ defined 
else_jump @LOWR_12233 
Actor.DestroyInstantly(97@)

:LOWR_12233
if 
056D:   actor 90@ defined 
else_jump @LOWR_12254 
Actor.DestroyInstantly(90@)

:LOWR_12254
if 
   not Actor.Dead(99@)
else_jump @LOWR_12313 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_12313 
if 
   Actor.InCar(99@, 68@)
else_jump @LOWR_12313 
05CD: AS_actor 99@ exit_car 68@ 

:LOWR_12313
fade 1 500 

:LOWR_12320
if 
fading 
else_jump @LOWR_12344 
wait 0 
jump @LOWR_12320 

:LOWR_12344
37@ = 1 

:LOWR_12351
if 
  35@ == 7 
else_jump @LOWR_12380 
03F0: enable_text_draw 0 
35@ += 1 

:LOWR_12380
if 
  35@ == 8 
else_jump @LOWR_12405 
35@ += 1 

:LOWR_12405
if 
  35@ == 9 
else_jump @LOWR_12430 
35@ += 1 

:LOWR_12430
if 
  35@ == 10 
else_jump @LOWR_12507 
if 
  32@ > 2000 
else_jump @LOWR_12507 
00BE: text_clear_all 
fade 0 500 

:LOWR_12476
if 
fading 
else_jump @LOWR_12500 
wait 0 
jump @LOWR_12476 

:LOWR_12500
35@ = 99 

:LOWR_12507
if 
   not 37@ == 1 
else_jump @LOWR_12532 
gosub @LOWR_21030 

:LOWR_12532
if 
  35@ == 99 
else_jump @LOWR_12557 
gosub @LOWR_27192 

:LOWR_12557
return 

:LOWR_12559
if 
  35@ == 0 
else_jump @LOWR_12665 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
00BE: text_clear_all 
Camera.SetPosition(1788.107, -1903.804, 13.3553, 0.0, 0.0, 0.0)
Camera.PointAt(1788.944, -1904.343, 13.2601, 2)
Camera.SetAtPos(1788.944, -1904.343, 13.2601)
35@ += 1 

:LOWR_12665
if 
  35@ == 1 
else_jump @LOWR_15486 
Model.Load(#VLA1)
Model.Load(#VLA2)
Model.Load(#VLA3)
Model.Load(#BFYPRO)
Model.Load(#HFYST)
Model.Load(#SAVANNA)
Model.Load(#REMINGTN)
04ED: load_animation ""LOWRIDER"" 
038B: load_requested_models 

:LOWR_12727
if 
   not Model.Available(#VLA1)
else_jump @LOWR_12753 
wait 0 
jump @LOWR_12727 

:LOWR_12753
if 
   not Model.Available(#VLA2)
else_jump @LOWR_12779 
wait 0 
jump @LOWR_12753 

:LOWR_12779
if 
   not Model.Available(#VLA3)
else_jump @LOWR_12805 
wait 0 
jump @LOWR_12779 

:LOWR_12805
if 
   not Model.Available(#BFYPRO)
else_jump @LOWR_12831 
wait 0 
jump @LOWR_12805 

:LOWR_12831
if 
   not Model.Available(#HFYST)
else_jump @LOWR_12857 
wait 0 
jump @LOWR_12831 

:LOWR_12857
if or
   not Model.Available(#SAVANNA)
   not Model.Available(#REMINGTN)
else_jump @LOWR_12889 
wait 0 
jump @LOWR_12857 

:LOWR_12889
if 
84EE:   not animation ""LOWRIDER"" loaded 
else_jump @LOWR_12923 
wait 0 
jump @LOWR_12889 

:LOWR_12923
138@ = 1798.203 
145@ = -1926.222 
152@ = 12.3895 
159@ = 73.1404 
139@ = 1802.864 
146@ = -1918.741 
153@ = 12.3931 
160@ = 357.6193 
140@ = 1784.635 
147@ = -1924.968 
154@ = 12.3901 
161@ = 305.062 
141@ = 1784.188 
148@ = -1913.439 
155@ = 12.3923 
162@ = 183.5814 
142@ = 1792.318 
149@ = -1919.513 
156@ = 12.3928 
163@ = 8.2504 
143@ = 1801.462 
150@ = -1905.691 
157@ = 12.3995 
164@ = 189.9314 
144@ = 1787.642 
151@ = -1901.136 
158@ = 12.3949 
165@ = 145.4181 
166@ = 1800.0 
188@ = -1907.83 
210@ = 12.4398 
232@ = 73.7198 
167@ = 1799.846 
189@ = -1912.124 
211@ = 12.4582 
233@ = 48.2386 
168@ = 1800.086 
190@ = -1910.434 
212@ = 12.4372 
234@ = 83.7398 
169@ = 1801.321 
191@ = -1916.427 
213@ = 12.4343 
235@ = 83.7398 
170@ = 1798.541 
192@ = -1922.18 
214@ = 12.431 
236@ = 46.5794 
171@ = 1799.49 
193@ = -1920.617 
215@ = 12.4322 
237@ = 46.5794 
172@ = 1787.255 
194@ = -1926.597 
216@ = 12.4283 
238@ = 323.6194 
173@ = 1786.442 
195@ = -1920.201 
217@ = 12.4322 
239@ = 306.1995 
174@ = 1785.824 
196@ = -1919.162 
218@ = 12.4324 
240@ = 294.6196 
175@ = 1786.102 
197@ = -1913.833 
219@ = 12.4327 
241@ = 280.7204 
176@ = 1786.806 
198@ = -1905.246 
220@ = 12.4342 
242@ = 262.8214 
177@ = 1788.693 
199@ = -1902.139 
221@ = 12.4348 
243@ = 247.161 
178@ = 1794.616 
200@ = -1899.608 
222@ = 12.4398 
244@ = 191.0618 
179@ = 1799.135 
201@ = -1902.488 
223@ = 12.4431 
245@ = 157.4622 
180@ = 1795.674 
202@ = -1899.569 
224@ = 12.4407 
246@ = 162.6424 
181@ = 1800.369 
203@ = -1907.003 
225@ = 12.4403 
247@ = 77.6197 
182@ = 1800.826 
204@ = -1917.325 
226@ = 12.434 
248@ = 36.1793 
183@ = 1785.85 
205@ = -1917.955 
227@ = 12.4324 
249@ = 287.0602 
184@ = 1788.538 
206@ = -1927.091 
228@ = 12.428 
250@ = 345.1206 
185@ = 1787.323 
207@ = -1904.11 
229@ = 12.4337 
251@ = 263.3813 
186@ = 1798.39 
208@ = -1901.733 
230@ = 12.4429 
252@ = 142.4208 
" + _1020 + @" = -1 
" + _1021 + @" = -1 
269@ = 0.01 
43@ = 0 

:LOWR_14074
if 
  7 > 43@ 
else_jump @LOWR_14135 
if 
056E:   car 69@(43@,7i) defined 
else_jump @LOWR_14121 
Car.Destroy(69@(43@,7i))

:LOWR_14121
43@ += 1 
jump @LOWR_14074 

:LOWR_14135
43@ = 0 

:LOWR_14142
if 
  22 > 43@ 
else_jump @LOWR_14203 
if 
056D:   actor 77@(43@,22i) defined 
else_jump @LOWR_14189 
Actor.DestroyInstantly(77@(43@,22i))

:LOWR_14189
43@ += 1 
jump @LOWR_14142 

:LOWR_14203
if 
856E:   not car 68@ defined 
else_jump @LOWR_14264 
68@ = Car.Create(#SAVANNA, 1793.496, -1907.423, 12.3992)
Car.Angle(68@) = 181.5231
09FE: reset_hydraulics_on_car 68@ 
jump @LOWR_14310 

:LOWR_14264
if 
   not Car.Wrecked(68@)
else_jump @LOWR_14310 
Car.PutAt(68@, 1793.496, -1907.423, 12.3992)
Car.Angle(68@) = 181.5231

:LOWR_14310
0792: disembark_instantly_actor " + PlayerActor + @" 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_14382 
036A: put_actor " + PlayerActor + @" in_car 68@ 
0605: actor " + PlayerActor + @" perform_animation ""SIT_RELAXED"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 

:LOWR_14382
69@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
70@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
71@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
72@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
73@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
74@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
75@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
0229: set_car 69@ primary_color_to 1 secondary_color_to 0 
0229: set_car 70@ primary_color_to 2 secondary_color_to 1 
0229: set_car 71@ primary_color_to 3 secondary_color_to 2 
0229: set_car 72@ primary_color_to 10 secondary_color_to 3 
0229: set_car 73@ primary_color_to 9 secondary_color_to 4 
0229: set_car 74@ primary_color_to 6 secondary_color_to 5 
0229: set_car 75@ primary_color_to 7 secondary_color_to 6 
43@ = 0 

:LOWR_14613
if 
  7 > 43@ 
else_jump @LOWR_14713 
Car.PutAt(69@(43@,7i), 138@(43@,7f), 145@(43@,7f), 152@(43@,7f))
Car.Angle(69@(43@,7i)) = 159@(43@,7f)
Car.LockInCurrentPosition(69@(43@,7i)) = True
Car.DoorStatus(69@(43@,7i)) = 3
43@ += 1 
jump @LOWR_14613 

:LOWR_14713
Car.LockInCurrentPosition(73@) = False
03A2: set_car 73@ action 3 
Car.ToggleHydraulics(73@) = True
Car.ImmuneToNonPlayer(73@) = True
Car.SetImmunities(73@, 1, 1, 1, 1, 1)
77@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
78@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
79@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
80@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
81@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
82@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
83@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
84@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
85@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
86@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
87@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
88@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
89@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
90@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
91@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
92@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
93@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
94@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
95@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
96@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
97@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
98@ = Actor.CreateAsDriver(Mission2, #VLA3, 73@)
43@ = 0 

:LOWR_15279
if 
  21 > 43@ 
else_jump @LOWR_15357 
Actor.PutAt(77@(43@,22i), 166@(43@,22f), 188@(43@,22f), 210@(43@,22f))
Actor.Angle(77@(43@,22i)) = 232@(43@,22f)
43@ += 1 
jump @LOWR_15279 

:LOWR_15357
99@ = Actor.Create(Mission1, #BFYPRO, 1788.273, -1903.364, 12.4345)
Actor.Angle(99@) = 232.5412
if 
  " + _6472 + @" == 0 
else_jump @LOWR_15427 
0952: load_soundtrack 13 
" + _6472 + @" += 1 
jump @LOWR_15438 

:LOWR_15427
0952: load_soundtrack 0 
" + _6472 + @" = 0 

:LOWR_15438
43@ = 0 

:LOWR_15445
if 
84A4:   not  43@ == 2 
else_jump @LOWR_15479 
wait 0 
0953: get_soundtrack_status_to 43@ 
jump @LOWR_15445 

:LOWR_15479
35@ += 1 

:LOWR_15486
if 
  35@ == 2 
else_jump @LOWR_15610 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @LOWR_15610 
" + tempvar_Actor_Car + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @LOWR_15577 
if 
8431:   not car " + tempvar_Actor_Car + @" passenger_seat_free 0 
else_jump @LOWR_15577 
0432: 277@ = get_actor_handle_from_car " + tempvar_Actor_Car + @" passenger_seat 0 
Actor.DestroyInstantly(277@)

:LOWR_15577
if 
   not Actor.Dead(99@)
else_jump @LOWR_15610 
0430: put_actor 99@ into_car " + tempvar_Actor_Car + @" passenger_seat 0 
35@ += 1 

:LOWR_15610
if 
  35@ == 3 
else_jump @LOWR_16181 
02A3: enable_widescreen 0 
Camera.SetPosition(1788.516, -1910.318, 14.8901, 0.0, 0.0, 0.0)
Camera.PointAt(1789.355, -1909.843, 14.6269, 2)
0581: enable_radar 0 
0826: enable_hud 0 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_15736 
Car.DoorStatus(68@) = 4
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 
Car.SetImmunities(68@, 1, 1, 1, 1, 1)

:LOWR_15736
266@ = 0.62 
267@ = 0.31 
268@ = -0.167 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_15848 
if 
   not Actor.Dead(99@)
else_jump @LOWR_15848 
if 
   Car.Model(68@) == #SAVANNA
else_jump @LOWR_15848 
0792: disembark_instantly_actor 99@ 
0464: put_actor 99@ into_turret_on_car 68@ at_car_offset 266@ 267@ 268@ position 0 shooting_angle_limit 0.0 with_weapon 0 

:LOWR_15848
0615: define_AS_pack_begin 49@ 
0812: AS_actor -1 perform_animation ""LRGIRL_HAIR"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_HURRY"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 49@ 
if 
   not Actor.Dead(99@)
else_jump @LOWR_15983 
if 
0A32:   actor 99@ on_turret_of_car 
else_jump @LOWR_15983 
0618: assign_actor 99@ to_AS_pack 49@ 

:LOWR_15983
061B: remove_references_to_AS_pack 49@ 
32@ = 0 
" + _1020 + @" = -1 
" + _1021 + @" = -1 
if 
  1 > " + _1022 + @" 
else_jump @LOWR_16034 
" + _1022 + @" = 1 

:LOWR_16034
0093: 46@ = integer 273@ to_float 
0093: 47@ = integer 272@ to_float 
0073: 46@ /= 47@ 
46@ *= 4.0 
0092: 43@ = float 46@ to_integer 
005E: " + _1022 + @" += 43@ 
if 
  " + _1022 + @" > 5 
else_jump @LOWR_16109 
" + _1022 + @" = 5 

:LOWR_16109
if 
  1 > " + _1022 + @" 
else_jump @LOWR_16134 
" + _1022 + @" = 1 

:LOWR_16134
wait 500 
fade 1 500 

:LOWR_16146
if 
fading 
else_jump @LOWR_16170 
wait 0 
jump @LOWR_16146 

:LOWR_16170
00BE: text_clear_all 
0954: start_playing_loaded_soundtrack 
35@ += 1 

:LOWR_16181
if 
  35@ == 4 
else_jump @LOWR_16295 
Player.CanMove(" + PlayerChar + @") = True" );
create_thread<BDISPLY>();
create_thread<LOWGAME>( _local68, _local73, _local99 );
AppendLine( @"32@ = 0 
136@ = 0 
130@ = 0 
00BE: text_clear_all 
03E6: remove_text_box 
03E5: show_text_box 'LOW_26'  
65@ = 0 
63@ = 0 
32@ = 0 
35@ += 1 

:LOWR_16295
if 
  35@ == 5 
else_jump @LOWR_16338 
if 
  " + _1017 + @" == 1 
else_jump @LOWR_16338 
35@ += 1 

:LOWR_16338
if 
  35@ == 6 
else_jump @LOWR_17504 
if 
  " + _1017 + @" == 1 
else_jump @LOWR_17497 
if 
  132@ == 0 
else_jump @LOWR_16815 
if or
  136@ > 5000 
00E1:   player 0 pressed_key 13 
else_jump @LOWR_16808 
130@ += 1 
if 
  130@ >= 5 
else_jump @LOWR_16449 
130@ = 0 

:LOWR_16449
if 
   not Car.Wrecked(68@)
else_jump @LOWR_16479 
Car.StorePos(68@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:LOWR_16479
if 
  130@ == 0 
else_jump @LOWR_16542 
Camera.SetPosition(1803.978, -1909.369, 15.0671, 0.0, 0.0, 0.0)
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:LOWR_16542
if 
  130@ == 1 
else_jump @LOWR_16605 
Camera.SetPosition(1795.369, -1900.999, 14.1795, 0.0, 0.0, 0.0)
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:LOWR_16605
if 
  130@ == 2 
else_jump @LOWR_16668 
Camera.SetPosition(1788.793, -1902.99, 13.7203, 0.0, 0.0, 0.0)
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:LOWR_16668
if 
  130@ == 3 
else_jump @LOWR_16731 
Camera.SetPosition(1789.377, -1912.195, 14.0671, 0.0, 0.0, 0.0)
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:LOWR_16731
if 
  130@ == 4 
else_jump @LOWR_16794 
Camera.SetPosition(1796.409, -1912.231, 13.8316, 0.0, 0.0, 0.0)
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:LOWR_16794
132@ += 1 
136@ = 0 

:LOWR_16808
jump @LOWR_16839 

:LOWR_16815
if 
80E1:   not player 0 pressed_key 13 
else_jump @LOWR_16839 
132@ = 0 

:LOWR_16839
if 
0736:   is_keyboard_key_just_pressed 67 
else_jump @LOWR_17490 
068D: get_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_16903 
Car.StorePos(68@, 56@, 57@, 58@)
" + tempvar_Angle + @" = Car.Angle(68@)

:LOWR_16903
" + tempvar_Angle + @" *= -1.0 
02F7: 46@ = cosine " + tempvar_Angle + @" 
02F6: 47@ = sine " + tempvar_Angle + @" 
0089: 50@ = " + tempvar_Float_1 + @" 
0063: 50@ -= 56@ 
0089: 51@ = " + tempvar_Float_2 + @" 
0063: 51@ -= 57@ 
0089: 52@ = " + tempvar_Float_3 + @" 
0063: 52@ -= 58@ 
0087: 53@ = 50@ 
006B: 53@ *= 46@ 
0087: 48@ = 51@ 
006B: 48@ *= 47@ 
0063: 53@ -= 48@ 
0087: 54@ = 50@ 
006B: 54@ *= 47@ 
0087: 48@ = 51@ 
006B: 48@ *= 46@ 
005B: 54@ += 48@ 
03A9: save_newline_to_debug_file 
05B6: 74 
03A8: save_float_to_debug_file 53@ 
03A8: save_float_to_debug_file 54@ 
03A8: save_float_to_debug_file 52@ 
068E: get_camera_target_point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0089: 50@ = " + tempvar_Float_1 + @" 
0063: 50@ -= 56@ 
0089: 51@ = " + tempvar_Float_2 + @" 
0063: 51@ -= 57@ 
0089: 52@ = " + tempvar_Float_3 + @" 
0063: 52@ -= 58@ 
0087: 53@ = 50@ 
006B: 53@ *= 46@ 
0087: 48@ = 51@ 
006B: 48@ *= 47@ 
0063: 53@ -= 48@ 
0087: 54@ = 50@ 
006B: 54@ *= 47@ 
0087: 48@ = 51@ 
006B: 48@ *= 46@ 
005B: 54@ += 48@ 
03A9: save_newline_to_debug_file 
05B6: 75 
03A8: save_float_to_debug_file 53@ 
03A8: save_float_to_debug_file 54@ 
03A8: save_float_to_debug_file 52@ 

:LOWR_17490
jump @LOWR_17504 

:LOWR_17497
35@ += 1 

:LOWR_17504
if 
  35@ == 7 
else_jump @LOWR_17567 
Player.CanMove(" + PlayerChar + @") = False
fade 0 500 

:LOWR_17536
if 
fading 
else_jump @LOWR_17560 
wait 0 
jump @LOWR_17536 

:LOWR_17560
35@ = 99 

:LOWR_17567
gosub @LOWR_23874 
if 
  35@ == 99 
else_jump @LOWR_17599 
gosub @LOWR_27192 

:LOWR_17599
return 

:LOWR_17601
if 
  35@ == 0 
else_jump @LOWR_17639 
0955: end_playing_loaded_soundtrack 
00BE: text_clear_all 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = False
35@ += 1 

:LOWR_17639
if 
  35@ == 1 
else_jump @LOWR_19108 
43@ = 0 

:LOWR_17664
if 
  7 > 43@ 
else_jump @LOWR_17725 
if 
056E:   car 69@(43@,7i) defined 
else_jump @LOWR_17711 
Car.Destroy(69@(43@,7i))

:LOWR_17711
43@ += 1 
jump @LOWR_17664 

:LOWR_17725
43@ = 0 

:LOWR_17732
if 
  22 > 43@ 
else_jump @LOWR_17793 
if 
056D:   actor 77@(43@,22i) defined 
else_jump @LOWR_17779 
Actor.DestroyInstantly(77@(43@,22i))

:LOWR_17779
43@ += 1 
jump @LOWR_17732 

:LOWR_17793
if 
056D:   actor 99@ defined 
else_jump @LOWR_17814 
Actor.DestroyInstantly(99@)

:LOWR_17814
if 
856E:   not car 68@ defined 
else_jump @LOWR_17870 
68@ = Car.Create(#SAVANNA, 1793.496, -1907.423, 12.3992)
Car.Angle(68@) = 181.5231
jump @LOWR_17916 

:LOWR_17870
if 
   not Car.Wrecked(68@)
else_jump @LOWR_17916 
Car.PutAt(68@, 1793.496, -1907.423, 12.3992)
Car.Angle(68@) = 181.5231

:LOWR_17916
69@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
70@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
71@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
72@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
73@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
74@ = Car.Create(#SAVANNA, 0.0, 0.0, 0.0)
75@ = Car.Create(#REMINGTN, 0.0, 0.0, 0.0)
0229: set_car 69@ primary_color_to 1 secondary_color_to 0 
0229: set_car 70@ primary_color_to 2 secondary_color_to 1 
0229: set_car 71@ primary_color_to 3 secondary_color_to 2 
0229: set_car 72@ primary_color_to 10 secondary_color_to 3 
0229: set_car 73@ primary_color_to 9 secondary_color_to 4 
0229: set_car 74@ primary_color_to 6 secondary_color_to 5 
0229: set_car 75@ primary_color_to 7 secondary_color_to 6 
43@ = 0 

:LOWR_18147
if 
  7 > 43@ 
else_jump @LOWR_18247 
Car.PutAt(69@(43@,7i), 138@(43@,7f), 145@(43@,7f), 152@(43@,7f))
Car.Angle(69@(43@,7i)) = 159@(43@,7f)
Car.LockInCurrentPosition(69@(43@,7i)) = True
Car.DoorStatus(69@(43@,7i)) = 3
43@ += 1 
jump @LOWR_18147 

:LOWR_18247
Car.LockInCurrentPosition(73@) = False
03A2: set_car 73@ action 3 
Car.ToggleHydraulics(73@) = True
Car.ImmuneToNonPlayer(73@) = True
Car.SetImmunities(73@, 1, 1, 1, 1, 1)
77@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
78@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
79@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
80@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
81@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
82@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
83@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
84@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
85@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
86@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
87@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
88@ = Actor.Create(Mission1, #VLA3, 0.0, 0.0, 0.0)
89@ = Actor.Create(Mission1, #VLA1, 0.0, 0.0, 0.0)
90@ = Actor.Create(Mission1, #VLA2, 0.0, 0.0, 0.0)
91@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
92@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
93@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
94@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
95@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
96@ = Actor.Create(Mission1, #BFYPRO, 0.0, 0.0, 0.0)
97@ = Actor.Create(Mission1, #HFYST, 0.0, 0.0, 0.0)
98@ = Actor.CreateAsDriver(Mission2, #VLA3, 73@)
43@ = 0 

:LOWR_18813
if 
  21 > 43@ 
else_jump @LOWR_18891 
Actor.PutAt(77@(43@,22i), 166@(43@,22f), 188@(43@,22f), 210@(43@,22f))
Actor.Angle(77@(43@,22i)) = 232@(43@,22f)
43@ += 1 
jump @LOWR_18813 

:LOWR_18891
99@ = Actor.Create(Mission1, #BFYPRO, 1788.273, -1903.364, 12.4345)
Actor.Angle(99@) = 232.5412
if 
   not Car.Wrecked(68@)
else_jump @LOWR_19005 
09FE: reset_hydraulics_on_car 68@ 
if 
8431:   not car 68@ passenger_seat_free 0 
else_jump @LOWR_18979 
0432: 277@ = get_actor_handle_from_car 68@ passenger_seat 0 
Actor.DestroyInstantly(277@)

:LOWR_18979
if 
   not Actor.Dead(99@)
else_jump @LOWR_19005 
0430: put_actor 99@ into_car 68@ passenger_seat 0 

:LOWR_19005
0792: disembark_instantly_actor " + PlayerActor + @" 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_19077 
036A: put_actor " + PlayerActor + @" in_car 68@ 
0605: actor " + PlayerActor + @" perform_animation ""SIT_RELAXED"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 

:LOWR_19077
0A0B: set_rendering_origin_at_3D_coord 1793.0 -1908.0 14.0 angle 180.0 
038B: load_requested_models 
35@ = 99 

:LOWR_19108
if 
  35@ == 99 
else_jump @LOWR_19747 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
0A0B: set_rendering_origin_at_3D_coord 1793.0 -1908.0 14.0 angle 180.0 
038B: load_requested_models 
wait 500 
if 
056E:   car 70@ defined 
else_jump @LOWR_19191 
Car.Destroy(70@)

:LOWR_19191
if 
056E:   car 73@ defined 
else_jump @LOWR_19212 
Car.Destroy(73@)

:LOWR_19212
if 
056E:   car 71@ defined 
else_jump @LOWR_19233 
Car.Destroy(71@)

:LOWR_19233
if 
056E:   car 74@ defined 
else_jump @LOWR_19254 
Car.Destroy(74@)

:LOWR_19254
if 
056E:   car 72@ defined 
else_jump @LOWR_19275 
Car.Destroy(72@)

:LOWR_19275
if 
056D:   actor 78@ defined 
else_jump @LOWR_19296 
Actor.DestroyInstantly(78@)

:LOWR_19296
if 
056D:   actor 80@ defined 
else_jump @LOWR_19317 
Actor.DestroyInstantly(80@)

:LOWR_19317
if 
056D:   actor 93@ defined 
else_jump @LOWR_19338 
Actor.DestroyInstantly(93@)

:LOWR_19338
if 
056D:   actor 83@ defined 
else_jump @LOWR_19359 
Actor.DestroyInstantly(83@)

:LOWR_19359
if 
056D:   actor 84@ defined 
else_jump @LOWR_19380 
Actor.DestroyInstantly(84@)

:LOWR_19380
if 
056D:   actor 86@ defined 
else_jump @LOWR_19401 
Actor.DestroyInstantly(86@)

:LOWR_19401
if 
056D:   actor 87@ defined 
else_jump @LOWR_19422 
Actor.DestroyInstantly(87@)

:LOWR_19422
if 
056D:   actor 89@ defined 
else_jump @LOWR_19443 
Actor.DestroyInstantly(89@)

:LOWR_19443
if 
056D:   actor 97@ defined 
else_jump @LOWR_19464 
Actor.DestroyInstantly(97@)

:LOWR_19464
if 
056D:   actor 90@ defined 
else_jump @LOWR_19485 
Actor.DestroyInstantly(90@)

:LOWR_19485
if 
   not Actor.Dead(81@)
else_jump @LOWR_19530 
if 
   not Car.Wrecked(69@)
else_jump @LOWR_19530 
0792: disembark_instantly_actor 81@ 
036A: put_actor 81@ in_car 69@ 

:LOWR_19530
if 
   not Actor.Dead(88@)
else_jump @LOWR_19575 
if 
   not Car.Wrecked(75@)
else_jump @LOWR_19575 
0792: disembark_instantly_actor 88@ 
036A: put_actor 88@ in_car 75@ 

:LOWR_19575
if 
   not Actor.Dead(99@)
else_jump @LOWR_19615 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_19615 
05CD: AS_actor 99@ exit_car 68@ 

:LOWR_19615
fade 1 500 

:LOWR_19622
if 
fading 
else_jump @LOWR_19646 
wait 0 
jump @LOWR_19622 

:LOWR_19646
if 
001C:   " + LOWR_Player_Points + @" > " + LOWR_Opposition_Points + @" 
else_jump @LOWR_19713 
273@ *= 2 
01E3: show_text_1number_styled GXT 'WINNER' number 273@ time 5000 style 1  
Player.Money(" + PlayerChar + @") += 273@
36@ = 1 
jump @LOWR_19736 

:LOWR_19713
00BC: show_text_highpriority GXT 'LOW_33' time 5000 flag 1  
37@ = 1 

:LOWR_19736
wait 0 
gosub @LOWR_27192 

:LOWR_19747
gosub @LOWR_23874 
return 

:LOWR_19756
if 
0736:   is_keyboard_key_just_pressed 52 
else_jump @LOWR_19781 
269@ += 0.01 

:LOWR_19781
if 
0736:   is_keyboard_key_just_pressed 53 
else_jump @LOWR_19806 
269@ += -0.01 

:LOWR_19806
if 
056E:   car 68@ defined 
else_jump @LOWR_19861 
if 
   Car.Wrecked(68@)
else_jump @LOWR_19861 
00BC: show_text_highpriority GXT 'LOW_34' time 5000 flag 1  
37@ = 1 

:LOWR_19861
if 
   Player.Defined(" + PlayerChar + @")
else_jump @LOWR_20038 
if 
  34@ > 2 
else_jump @LOWR_20038 
if 
  278@ == 0 
else_jump @LOWR_19979 
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 1793.068 -1904.254 radius 125.0 125.0 
else_jump @LOWR_19972 
03DE: set_pedestrians_density_multiplier_to 0.0 
01EB: set_traffic_density_multiplier_to 0.0 
278@ = 1 

:LOWR_19972
jump @LOWR_20038 

:LOWR_19979
if 
80EC:   not actor " + PlayerActor + @" sphere 0 near_point 1793.068 -1904.254 radius 150.0 150.0 
else_jump @LOWR_20038 
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
278@ = 0 

:LOWR_20038
return 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_20098 
if 
   not Actor.Dead(99@)
else_jump @LOWR_20098 
0464: put_actor 99@ into_turret_on_car 68@ at_car_offset 266@ 267@ 268@ position 0 shooting_angle_limit 0.0 with_weapon 0 

:LOWR_20098
return 

:LOWR_20100
if 
  283@ == 0 
else_jump @LOWR_20158 
279@ = 0.0 
280@ = 0.0 
281@ = 0.0 
282@ = 0.0 

:LOWR_20158
if 
  283@ == 1 
else_jump @LOWR_20216 
279@ = 0.0 
280@ = 0.0 
281@ = 0.0 
282@ = 1.0 

:LOWR_20216
if 
  283@ == 2 
else_jump @LOWR_20274 
279@ = 0.0 
280@ = 0.0 
281@ = 1.0 
282@ = 0.0 

:LOWR_20274
if 
  283@ == 3 
else_jump @LOWR_20332 
279@ = 0.0 
280@ = 0.0 
281@ = 1.0 
282@ = 1.0 

:LOWR_20332
if 
  283@ == 4 
else_jump @LOWR_20390 
279@ = 0.0 
280@ = 1.0 
281@ = 0.0 
282@ = 0.0 

:LOWR_20390
if 
  283@ == 5 
else_jump @LOWR_20448 
279@ = 0.0 
280@ = 1.0 
281@ = 0.0 
282@ = 1.0 

:LOWR_20448
if 
  283@ == 6 
else_jump @LOWR_20506 
279@ = 0.0 
280@ = 1.0 
281@ = 1.0 
282@ = 0.0 

:LOWR_20506
if 
  283@ == 7 
else_jump @LOWR_20564 
279@ = 0.0 
280@ = 1.0 
281@ = 1.0 
282@ = 1.0 

:LOWR_20564
if 
  283@ == 8 
else_jump @LOWR_20622 
279@ = 1.0 
280@ = 0.0 
281@ = 0.0 
282@ = 0.0 

:LOWR_20622
if 
  283@ == 9 
else_jump @LOWR_20680 
279@ = 1.0 
280@ = 0.0 
281@ = 0.0 
282@ = 1.0 

:LOWR_20680
if 
  283@ == 10 
else_jump @LOWR_20738 
279@ = 1.0 
280@ = 0.0 
281@ = 1.0 
282@ = 0.0 

:LOWR_20738
if 
  283@ == 11 
else_jump @LOWR_20796 
279@ = 1.0 
280@ = 0.0 
281@ = 1.0 
282@ = 1.0 

:LOWR_20796
if 
  283@ == 12 
else_jump @LOWR_20854 
279@ = 1.0 
280@ = 1.0 
281@ = 0.0 
282@ = 0.0 

:LOWR_20854
if 
  283@ == 13 
else_jump @LOWR_20912 
279@ = 1.0 
280@ = 1.0 
281@ = 0.0 
282@ = 1.0 

:LOWR_20912
if 
  283@ == 14 
else_jump @LOWR_20970 
279@ = 1.0 
280@ = 1.0 
281@ = 1.0 
282@ = 0.0 

:LOWR_20970
if 
  283@ == 15 
else_jump @LOWR_21028 
279@ = 1.0 
280@ = 1.0 
281@ = 1.0 
282@ = 1.0 

:LOWR_21028
return 

:LOWR_21030
if 
  300 > 133@ 
else_jump @LOWR_21096 
254@ = 1.0 
257@ = 1.0 
260@ = 0.0 
263@ = 0.0 
jump @LOWR_21169 

:LOWR_21096
if 
  133@ > 500 
else_jump @LOWR_21129 
133@ = 0 
jump @LOWR_21169 

:LOWR_21129
254@ = 0.0 
257@ = 0.0 
260@ = 0.0 
263@ = 0.0 

:LOWR_21169
if 
  134@ > 2000 
else_jump @LOWR_21243 
0209: 283@ = random_int_in_ranges 0 16 
gosub @LOWR_20100 
0087: 255@ = 281@ 
0087: 258@ = 279@ 
0087: 261@ = 282@ 
0087: 264@ = 280@ 
134@ = 0 

:LOWR_21243
if 
   not Car.Wrecked(69@)
else_jump @LOWR_21385 
if 
   Car.HasHydraulics(69@)
else_jump @LOWR_21385 
07F5: car 69@ control_hydraulics 257@ 263@ 254@ 260@ 
Car.StorePos(69@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 50@ = 138@ 
0065: 50@ -= " + tempvar_Float_1 + @" 
0087: 51@ = 145@ 
0065: 51@ -= " + tempvar_Float_2 + @" 
006B: 50@ *= 269@ 
006B: 51@ *= 269@ 
07D5: set_car 69@ velocity_in_direction_XYZ 50@ 51@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWR_21385
if 
   not Car.Wrecked(72@)
else_jump @LOWR_21527 
if 
   Car.HasHydraulics(72@)
else_jump @LOWR_21527 
07F5: car 72@ control_hydraulics 258@ 264@ 255@ 261@ 
Car.StorePos(72@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 50@ = 141@ 
0065: 50@ -= " + tempvar_Float_1 + @" 
0087: 51@ = 148@ 
0065: 51@ -= " + tempvar_Float_2 + @" 
006B: 50@ *= 269@ 
006B: 51@ *= 269@ 
07D5: set_car 72@ velocity_in_direction_XYZ 50@ 51@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWR_21527
0871: init_jump_table 39@ total_jumps 18 default_jump 0 @LOWR_23872 jumps 0 @LOWR_21720 1 @LOWR_21840 2 @LOWR_21960 3 @LOWR_22076 4 @LOWR_22192 5 @LOWR_22307 6 @LOWR_22423 
0872: jump_table_jumps 7 @LOWR_22539 8 @LOWR_22655 9 @LOWR_22771 10 @LOWR_22891 11 @LOWR_23074 12 @LOWR_23190 13 @LOWR_23306 14 @LOWR_23422 15 @LOWR_23538 
0872: jump_table_jumps 16 @LOWR_23654 17 @LOWR_23763 -1 @LOWR_23872 -1 @LOWR_23872 -1 @LOWR_23872 -1 @LOWR_23872 -1 @LOWR_23872 -1 @LOWR_23872 -1 @LOWR_23872 

:LOWR_21720
if 
   not Actor.Dead(77@)
else_jump @LOWR_21833 
062E: get_actor 77@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_21833 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 77@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_21833
jump @LOWR_23872 

:LOWR_21840
if 
   not Actor.Dead(78@)
else_jump @LOWR_21953 
062E: get_actor 78@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_21953 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""F_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 78@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_21953
jump @LOWR_23872 

:LOWR_21960
if 
   not Actor.Dead(79@)
else_jump @LOWR_22069 
062E: get_actor 79@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22069 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(80@)
else_jump @LOWR_22044 
0677: AS_actor -1 chat_with_actor 80@ lead_speaker_flag 1 unknown_flag 1 
jump @LOWR_22051 

:LOWR_22044
05B9: AS_actor -1 stay_idle 1000 ms 

:LOWR_22051
0616: define_AS_pack_end 49@ 
0618: assign_actor 79@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22069
jump @LOWR_23872 

:LOWR_22076
if 
   not Actor.Dead(80@)
else_jump @LOWR_22185 
062E: get_actor 80@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22185 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(79@)
else_jump @LOWR_22160 
0677: AS_actor -1 chat_with_actor 79@ lead_speaker_flag 0 unknown_flag 1 
jump @LOWR_22167 

:LOWR_22160
05B9: AS_actor -1 stay_idle 1000 ms 

:LOWR_22167
0616: define_AS_pack_end 49@ 
0618: assign_actor 80@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22185
jump @LOWR_23872 

:LOWR_22192
if 
   not Actor.Dead(81@)
else_jump @LOWR_22300 
062E: get_actor 81@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22300 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""CAR_HOOKERTALK"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 81@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22300
jump @LOWR_23872 

:LOWR_22307
if 
   not Actor.Dead(82@)
else_jump @LOWR_22416 
062E: get_actor 82@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22416 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(83@)
else_jump @LOWR_22391 
0677: AS_actor -1 chat_with_actor 83@ lead_speaker_flag 0 unknown_flag 1 
jump @LOWR_22398 

:LOWR_22391
05B9: AS_actor -1 stay_idle 1000 ms 

:LOWR_22398
0616: define_AS_pack_end 49@ 
0618: assign_actor 82@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22416
jump @LOWR_23872 

:LOWR_22423
if 
   not Actor.Dead(83@)
else_jump @LOWR_22532 
062E: get_actor 83@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22532 
0615: define_AS_pack_begin 49@ 
if 
   not Actor.Dead(82@)
else_jump @LOWR_22507 
0677: AS_actor -1 chat_with_actor 82@ lead_speaker_flag 1 unknown_flag 1 
jump @LOWR_22514 

:LOWR_22507
05B9: AS_actor -1 stay_idle 1000 ms 

:LOWR_22514
0616: define_AS_pack_end 49@ 
0618: assign_actor 83@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22532
jump @LOWR_23872 

:LOWR_22539
if 
   not Actor.Dead(84@)
else_jump @LOWR_22648 
062E: get_actor 84@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22648 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 84@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22648
jump @LOWR_23872 

:LOWR_22655
if 
   not Actor.Dead(85@)
else_jump @LOWR_22764 
062E: get_actor 85@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22764 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 85@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22764
jump @LOWR_23872 

:LOWR_22771
if 
   not Actor.Dead(86@)
else_jump @LOWR_22884 
062E: get_actor 86@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_22884 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 86@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_22884
jump @LOWR_23872 

:LOWR_22891
if 
   not Actor.Dead(87@)
else_jump @LOWR_23067 
062E: get_actor 87@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23067 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
0605: actor -1 perform_animation ""WOMAN_IDLESTANCE"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 87@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23067
jump @LOWR_23872 

:LOWR_23074
if 
   not Actor.Dead(88@)
else_jump @LOWR_23183 
062E: get_actor 88@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23183 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 88@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23183
jump @LOWR_23872 

:LOWR_23190
if 
   not Actor.Dead(89@)
else_jump @LOWR_23299 
062E: get_actor 89@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23299 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 1 lockY 1 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 89@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23299
jump @LOWR_23872 

:LOWR_23306
if 
   not Actor.Dead(90@)
else_jump @LOWR_23415 
062E: get_actor 90@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23415 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 90@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23415
jump @LOWR_23872 

:LOWR_23422
if 
   not Actor.Dead(91@)
else_jump @LOWR_23531 
062E: get_actor 91@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23531 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 91@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23531
jump @LOWR_23872 

:LOWR_23538
if 
   not Actor.Dead(92@)
else_jump @LOWR_23647 
062E: get_actor 92@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23647 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 92@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23647
jump @LOWR_23872 

:LOWR_23654
if 
   not Actor.Dead(93@)
else_jump @LOWR_23756 
062E: get_actor 93@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23756 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""TAP_HAND"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 93@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23756
jump @LOWR_23872 

:LOWR_23763
if 
   not Actor.Dead(94@)
else_jump @LOWR_23865 
062E: get_actor 94@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_23865 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""TAP_HAND"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 94@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_23865
jump @LOWR_23872 

:LOWR_23872
return 

:LOWR_23874
0871: init_jump_table 39@ total_jumps 21 default_jump 0 @LOWR_26531 jumps 0 @LOWR_24067 1 @LOWR_24187 2 @LOWR_24303 3 @LOWR_24419 4 @LOWR_24539 5 @LOWR_24659 6 @LOWR_24775 
0872: jump_table_jumps 7 @LOWR_24895 8 @LOWR_25011 9 @LOWR_25127 10 @LOWR_25247 11 @LOWR_25363 12 @LOWR_25483 13 @LOWR_25603 14 @LOWR_25719 15 @LOWR_25835 
0872: jump_table_jumps 16 @LOWR_25951 17 @LOWR_26067 18 @LOWR_26183 19 @LOWR_26299 20 @LOWR_26415 -1 @LOWR_26531 -1 @LOWR_26531 -1 @LOWR_26531 -1 @LOWR_26531 

:LOWR_24067
if 
   not Actor.Dead(77@)
else_jump @LOWR_24180 
062E: get_actor 77@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24180 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 77@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24180
jump @LOWR_26531 

:LOWR_24187
if 
   not Actor.Dead(78@)
else_jump @LOWR_24296 
062E: get_actor 78@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24296 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 78@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24296
jump @LOWR_26531 

:LOWR_24303
if 
   not Actor.Dead(79@)
else_jump @LOWR_24412 
062E: get_actor 79@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24412 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 79@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24412
jump @LOWR_26531 

:LOWR_24419
if 
   not Actor.Dead(80@)
else_jump @LOWR_24532 
062E: get_actor 80@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24532 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKSTND_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 80@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24532
jump @LOWR_26531 

:LOWR_24539
if 
   not Actor.Dead(81@)
else_jump @LOWR_24652 
062E: get_actor 81@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24652 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKSTND_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 81@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24652
jump @LOWR_26531 

:LOWR_24659
if 
   not Actor.Dead(82@)
else_jump @LOWR_24768 
062E: get_actor 82@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24768 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 82@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24768
jump @LOWR_26531 

:LOWR_24775
if 
   not Actor.Dead(83@)
else_jump @LOWR_24888 
062E: get_actor 83@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_24888 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKSTND_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 83@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_24888
jump @LOWR_26531 

:LOWR_24895
if 
   not Actor.Dead(84@)
else_jump @LOWR_25004 
062E: get_actor 84@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25004 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 84@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25004
jump @LOWR_26531 

:LOWR_25011
if 
   not Actor.Dead(85@)
else_jump @LOWR_25120 
062E: get_actor 85@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25120 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 85@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25120
jump @LOWR_26531 

:LOWR_25127
if 
   not Actor.Dead(86@)
else_jump @LOWR_25240 
062E: get_actor 86@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25240 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 86@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25240
jump @LOWR_26531 

:LOWR_25247
if 
   not Actor.Dead(87@)
else_jump @LOWR_25356 
062E: get_actor 87@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25356 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 87@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25356
jump @LOWR_26531 

:LOWR_25363
if 
   not Actor.Dead(88@)
else_jump @LOWR_25476 
062E: get_actor 88@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25476 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKLEAN_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 88@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25476
jump @LOWR_26531 

:LOWR_25483
if 
   not Actor.Dead(89@)
else_jump @LOWR_25596 
062E: get_actor 89@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25596 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""M_SMKSTND_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 89@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25596
jump @LOWR_26531 

:LOWR_25603
if 
   not Actor.Dead(90@)
else_jump @LOWR_25712 
062E: get_actor 90@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25712 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 90@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25712
jump @LOWR_26531 

:LOWR_25719
if 
   not Actor.Dead(91@)
else_jump @LOWR_25828 
062E: get_actor 91@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25828 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_B_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 91@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25828
jump @LOWR_26531 

:LOWR_25835
if 
   not Actor.Dead(92@)
else_jump @LOWR_25944 
062E: get_actor 92@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_25944 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 92@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_25944
jump @LOWR_26531 

:LOWR_25951
if 
   not Actor.Dead(93@)
else_jump @LOWR_26060 
062E: get_actor 93@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_26060 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_C_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 93@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_26060
jump @LOWR_26531 

:LOWR_26067
if 
   not Actor.Dead(94@)
else_jump @LOWR_26176 
062E: get_actor 94@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_26176 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 94@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_26176
jump @LOWR_26531 

:LOWR_26183
if 
   not Actor.Dead(95@)
else_jump @LOWR_26292 
062E: get_actor 95@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_26292 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 95@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_26292
jump @LOWR_26531 

:LOWR_26299
if 
   not Actor.Dead(96@)
else_jump @LOWR_26408 
062E: get_actor 96@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_26408 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 96@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_26408
jump @LOWR_26531 

:LOWR_26415
if 
   not Actor.Dead(97@)
else_jump @LOWR_26524 
062E: get_actor 97@ task 1560 status_store_to 43@ 
if 
04A4:   43@ == 7 
else_jump @LOWR_26524 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RAP_A_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 49@ 
0618: assign_actor 97@ to_AS_pack 49@ 
061B: remove_references_to_AS_pack 49@ 

:LOWR_26524
jump @LOWR_26531 

:LOWR_26531
return 

:LOWR_26533
43@ = 0 

:LOWR_26540
if 
  22 > 43@ 
else_jump @LOWR_26633 
if 
056D:   actor 77@(43@,22i) defined 
else_jump @LOWR_26619 
Actor.DestroyInstantly(77@(43@,22i))
0663: printint ""PED_DELETED"" 43@ 
43@ = 22 
jump @LOWR_26626 

:LOWR_26619
43@ += 1 

:LOWR_26626
jump @LOWR_26540 

:LOWR_26633
return 

:LOWR_26635
43@ = 0 

:LOWR_26642
if 
  7 > 43@ 
else_jump @LOWR_26735 
if 
056E:   car 69@(43@,7i) defined 
else_jump @LOWR_26721 
Car.Destroy(69@(43@,7i))
0663: printint ""CAR_DELETED"" 43@ 
43@ = 7 
jump @LOWR_26728 

:LOWR_26721
43@ += 1 

:LOWR_26728
jump @LOWR_26642 

:LOWR_26735
return 

:LOWR_26737
0871: init_jump_table " + Current_Language + @" total_jumps 1 default_jump 1 @LOWR_26840 jumps 3 @LOWR_26800 -1 @LOWR_26880 -1 @LOWR_26880 -1 @LOWR_26880 -1 @LOWR_26880 -1 @LOWR_26880 -1 @LOWR_26880 

:LOWR_26800
0937: text_draw_box_cornerA 29.0 220.0 cornerB 173.0 409.0 GXT_reference 'BJ_TITL' style 2  
jump @LOWR_26880 

:LOWR_26840
0937: text_draw_box_cornerA 29.0 220.0 cornerB 157.0 409.0 GXT_reference 'BJ_TITL' style 2  
jump @LOWR_26880 

:LOWR_26880
gosub @LOWR_27137 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 240.0 GXT 'WOF_04'  
gosub @LOWR_27137 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 260.0 GXT 'DOLLAR' number 273@  
gosub @LOWR_27137 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 290.0 GXT 'BJ_02'  
gosub @LOWR_27137 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 310.0 GXT 'DOLLAR' number 271@  
gosub @LOWR_27137 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 340.0 GXT 'BJ_03'  
gosub @LOWR_27137 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 360.0 GXT 'DOLLAR' number 272@  
return 

:LOWR_27137
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 0.4714 2.5077 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 

:LOWR_27192
34@ += 1 
35@ = 0 
62@ = 0 
63@ = 0 
64@ = 0 
65@ = 0 
32@ = 0 
33@ = 0 
return 

:LOWR_27250
return 

:LOWR_27252
return 

:LOWR_27254
0917: audio_zone 'LOWRIDE' enable_sound 0 
if 
056E:   car 68@ defined 
else_jump @LOWR_27390 
if 
   not Car.Wrecked(68@)
else_jump @LOWR_27390 
03A2: set_car 68@ action 4 
Car.LockInCurrentPosition(68@) = False
Car.SetImmunities(68@, 0, 0, 0, 0, 0)
if 
   Player.Defined(" + PlayerChar + @")
else_jump @LOWR_27351 
0221: set_player " + PlayerChar + @" apply_brakes_to_car 0 

:LOWR_27351
Car.DoorStatus(68@) = 1
if 
   Actor.InCar(" + PlayerActor + @", 68@)
else_jump @LOWR_27390 
0792: disembark_instantly_actor " + PlayerActor + @" 
036A: put_actor " + PlayerActor + @" in_car 68@ 

:LOWR_27390
43@ = 0 

:LOWR_27397
if 
  7 > 43@ 
else_jump @LOWR_27581 
if 
056E:   car 69@(43@,7i) defined 
else_jump @LOWR_27567 
if 
   not Car.Wrecked(69@(43@,7i))
else_jump @LOWR_27558 
if or
  43@ == 0 
  43@ == 3 
  43@ == 4 
else_jump @LOWR_27536 
if 
   Car.HasHydraulics(69@(43@,7i))
else_jump @LOWR_27536 
07F5: car 69@(43@,7i) control_hydraulics 0.0 0.0 0.0 0.0 

:LOWR_27536
03A2: set_car 69@(43@,7i) action 2 
Car.ToggleHydraulics(69@(43@,7i)) = False

:LOWR_27558
Car.RemoveReferences(69@(43@,7i))

:LOWR_27567
43@ += 1 
jump @LOWR_27397 

:LOWR_27581
43@ = 0 

:LOWR_27588
if 
  22 > 43@ 
else_jump @LOWR_27669 
if 
056D:   actor 77@(43@,22i) defined 
else_jump @LOWR_27655 
if 
   not Actor.Dead(77@(43@,22i))
else_jump @LOWR_27646 

:LOWR_27646
Actor.RemoveReferences(77@(43@,22i))

:LOWR_27655
43@ += 1 
jump @LOWR_27588 

:LOWR_27669
if 
056D:   actor 99@ defined 
else_jump @LOWR_27690 
Actor.RemoveReferences(99@)

:LOWR_27690
Model.Destroy(#WMYMECH)
Model.Destroy(#SAVANNA)
Model.Destroy(#VLA1)
Model.Destroy(#VLA2)
Model.Destroy(#VLA3)
Model.Destroy(#BFYPRO)
Model.Destroy(#HFYST)
Model.Destroy(#SAVANNA)
Model.Destroy(#REMINGTN)
Model.Destroy(#SAVANNA)
04EF: release_animation ""LOWRIDER"" 
Marker.Disable(102@)
0581: enable_radar 1 
0953: get_soundtrack_status_to 43@ 
if 
84A4:   not  43@ == 0 
else_jump @LOWR_27780 
0955: end_playing_loaded_soundtrack 

:LOWR_27780
0733: random_car_generator_enable_model #SAVANNA 
" + _1044 + @" = 1 
065C: release_decision_maker 66@ 
065C: release_decision_maker 67@ 
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}