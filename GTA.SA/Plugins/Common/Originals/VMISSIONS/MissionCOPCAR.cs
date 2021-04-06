using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class COPCAR : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @COPCAR_52 
if 
wasted_or_busted 
else_jump @COPCAR_43 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
gosub @COPCAR_14804 

:COPCAR_43
gosub @COPCAR_14806 
end_thread 

:COPCAR_52
" + OnMission + @" = 1 
wait 0 
if 
  " + Mission_Vigilante_Passed + @" == 0 
else_jump @COPCAR_94 
increment_mission_attempts 

:COPCAR_94
054C: use_GXT_table 'COPCAR' 
51@ = 0 
" + _8222 + @" = -100 
58@ = 0 
" + _8223 + @" = 0 
65@ = 0 
62@ = 0 
52@ = 0 
53@ = 0 
64@ = 0 
54@ = 0 
55@ = 0 
56@ = 0 
57@ = 0 
59@ = 0 
60@ = 0 
61@ = 0 
63@ = 0 
90@ = 0 
142@ = 4.0 
144@ = 0.0 
143@ = 0.9 
91@ = 0 
" + tempvar_Angle + @" = 0.0 
124@ = 0.0 
145@ = 0.0 
146@ = 0.0 
147@ = 0.0 
148@ = 0.0 
164@ = 0.0 
165@ = 0.0 
166@ = 0.0 
167@ = 0.0 
170@ = 0.0 
171@ = 0.0 
172@ = 0.0 
173@ = 0.0 
04AF: 176@ = 521 
04AF: 177@ = 522 
04AF: 178@ = 461 
04AF: 179@ = 462 
04AF: 180@ = 463 
04AF: 181@ = 468 
04AF: 182@ = 581 
04AF: 183@ = 586 
04AF: 184@ = 411 
04AF: 185@ = 415 
04AF: 186@ = 429 
04AF: 187@ = 451 
04AF: 188@ = 477 
04AF: 189@ = 480 
04AF: 190@ = 506 
04AF: 191@ = 541 
04AF: 192@ = 603 
04AF: 193@ = 400 
04AF: 194@ = 401 
04AF: 195@ = 402 
04AF: 196@ = 410 
04AF: 197@ = 412 
04AF: 198@ = 413 
04AF: 199@ = 419 
04AF: 200@ = 422 
04AF: 201@ = 424 
04AF: 202@ = 434 
04AF: 203@ = 436 
04AF: 204@ = 439 
04AF: 205@ = 440 
04AF: 206@ = 474 
04AF: 207@ = 475 
04AF: 208@ = 478 
04AF: 209@ = 482 
04AF: 210@ = 483 
04AF: 211@ = 489 
04AF: 212@ = 491 
04AF: 213@ = 496 
04AF: 214@ = 500 
04AF: 215@ = 517 
04AF: 216@ = 518 
04AF: 217@ = 526 
04AF: 218@ = 527 
04AF: 219@ = 533 
04AF: 220@ = 534 
04AF: 221@ = 535 
04AF: 222@ = 536 
04AF: 223@ = 542 
04AF: 224@ = 543 
04AF: 225@ = 545 
04AF: 226@ = 549 
04AF: 227@ = 554 
04AF: 228@ = 555 
04AF: 229@ = 558 
04AF: 230@ = 559 
04AF: 231@ = 562 
04AF: 232@ = 565 
04AF: 233@ = 567 
04AF: 234@ = 575 
04AF: 235@ = 576 
04AF: 236@ = 579 
04AF: 237@ = 587 
04AF: 238@ = 589 
04AF: 239@ = 600 
04AF: 240@ = 602 
04AF: 241@ = 605 
04AF: 242@ = 442 
04AF: 243@ = 404 
04AF: 244@ = 405 
04AF: 245@ = 418 
04AF: 246@ = 421 
04AF: 247@ = 426 
04AF: 248@ = 445 
04AF: 249@ = 458 
04AF: 250@ = 466 
04AF: 251@ = 467 
04AF: 252@ = 479 
04AF: 253@ = 492 
04AF: 254@ = 507 
04AF: 255@ = 516 
04AF: 256@ = 529 
04AF: 257@ = 540 
04AF: 258@ = 546 
04AF: 259@ = 547 
04AF: 260@ = 550 
04AF: 261@ = 551 
04AF: 262@ = 560 
04AF: 263@ = 561 
04AF: 264@ = 580 
04AF: 265@ = 585 
04AF: 266@ = 604 
Model.Load(#COLT45)
Model.Load(#MICRO_UZI)
Model.Load(#AK47)
Model.Load(#CHROMEGUN)
Model.Load(#BAT)
038B: load_requested_models 

:COPCAR_1163
if or
   not Model.Available(#COLT45)
   not Model.Available(#MICRO_UZI)
   not Model.Available(#AK47)
   not Model.Available(#CHROMEGUN)
else_jump @COPCAR_1205 
wait 0 
jump @COPCAR_1163 

:COPCAR_1205
if 
   not Model.Available(#BAT)
else_jump @COPCAR_1232 
wait 0 
jump @COPCAR_1205 

:COPCAR_1232
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @COPCAR_1263 
34@ = Actor.CurrentCar(" + PlayerActor + @")
053F: set_car 34@ tires_vulnerability 0 

:COPCAR_1263
07E5: copy_decision_maker -1 to 267@ 
0708: reset_decision_maker 267@ event 41 
07E6: copy_group_decision_maker -1 to 268@ 
0749: reset_group_decision_maker 268@ event 41 

:COPCAR_1291
73@ = 0 
82@ = 0 
89@ = 0 
52@ = 0 
269@ = 0 
66@ = 0 
67@ = 0 
68@ = 0 
69@ = 0 
70@ = 0 
71@ = 0 
74@ = 0 
75@ = 0 
76@ = 0 
77@ = 0 
78@ = 0 
79@ = 0 
80@ = 0 
83@ = 0 
174@ = 0 
175@ = 0 
84@ = 0 
85@ = 0 
86@ = 0 
87@ = 0 
128@ = 0.0 
129@ = 0.0 
130@ = 0.0 
131@ = 0.0 
270@ = 0 
gosub @COPCAR_14947 
0209: 271@ = random_int_in_ranges 9 255 

:COPCAR_1530
if or
04A4:   271@ == 105 
04A4:   271@ == 106 
04A4:   271@ == 107 
else_jump @COPCAR_1579 
0209: 271@ = random_int_in_ranges 9 255 
jump @COPCAR_1530 

:COPCAR_1579
if 
87DE:   not model 271@ exists 
else_jump @COPCAR_1661 
0209: 271@ = random_int_in_ranges 9 255 

:COPCAR_1605
if or
04A4:   271@ == 105 
04A4:   271@ == 106 
04A4:   271@ == 107 
else_jump @COPCAR_1654 
0209: 271@ = random_int_in_ranges 9 255 
jump @COPCAR_1605 

:COPCAR_1654
jump @COPCAR_1579 

:COPCAR_1661
Model.Load(271@)

:COPCAR_1666
gosub @COPCAR_18589 
if 
  58@ == 1 
else_jump @COPCAR_1698 
jump @COPCAR_14804 

:COPCAR_1698
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Float_3 + @")
0086: " + tempvar_Float_1 + @" = " + tempvar_X_coord + @" 
" + tempvar_Float_1 + @" -= 800.0 
0089: 272@ = " + tempvar_X_coord + @" 
272@ += 800.0 
0208: 104@ = random_float_in_ranges " + tempvar_Float_1 + @" 272@ 
0086: " + tempvar_Float_2 + @" = " + tempvar_Y_coord + @" 
" + tempvar_Float_2 + @" -= 800.0 
0089: 273@ = " + tempvar_Y_coord + @" 
273@ += 800.0 
0208: 105@ = random_float_in_ranges " + tempvar_Float_2 + @" 273@ 
106@ = 10.0 
if 
  4 > 51@ 
else_jump @COPCAR_1867 
03D3: get_route_nearest_for 104@ 105@ 106@ store_to 104@ 105@ 106@ Z_angle_to 113@ 
106@ += 0.5 

:COPCAR_1867
if and
  51@ > 3 
  8 > 51@ 
else_jump @COPCAR_2252 
04B9: unknown_get_at 104@ 105@ 106@ height 8.0 radius 500.0 store_to 104@ 105@ 106@ 107@ 108@ 109@ 113@ 
if and
  104@ == 0.0 
  105@ == 0.0 
  107@ == 0.0 
  108@ == 0.0 
else_jump @COPCAR_1996 
wait 0 
jump @COPCAR_1666 

:COPCAR_1996
0087: 125@ = 107@ 
0063: 125@ -= 104@ 
0087: 126@ = 108@ 
0063: 126@ -= 105@ 
0087: 140@ = 125@ 
006B: 140@ *= 125@ 
0087: 141@ = 126@ 
006B: 141@ *= 126@ 
0087: 127@ = 140@ 
005B: 127@ += 141@ 
01FB: 127@ = square_root 127@ 
149@ = 8.0 
0073: 149@ /= 127@ 
0087: 140@ = 125@ 
006B: 140@ *= 149@ 
0087: 107@ = 104@ 
005B: 107@ += 140@ 
0087: 141@ = 126@ 
006B: 141@ *= 149@ 
0087: 108@ = 105@ 
005B: 108@ += 141@ 
149@ = 2.0 
0073: 149@ /= 127@ 
0087: 140@ = 125@ 
006B: 140@ *= 149@ 
005B: 104@ += 140@ 
0087: 141@ = 126@ 
006B: 141@ *= 149@ 
005B: 105@ += 141@ 
106@ += 0.5 
109@ += 0.5 

:COPCAR_2252
if 
  51@ > 7 
else_jump @COPCAR_2742 
04B9: unknown_get_at 104@ 105@ 106@ height 13.0 radius 500.0 store_to 104@ 105@ 106@ 110@ 111@ 112@ 113@ 
if and
  104@ == 0.0 
  105@ == 0.0 
  110@ == 0.0 
  111@ == 0.0 
else_jump @COPCAR_2374 
wait 0 
jump @COPCAR_1666 

:COPCAR_2374
0087: 125@ = 110@ 
0063: 125@ -= 104@ 
0087: 126@ = 111@ 
0063: 126@ -= 105@ 
0087: 140@ = 125@ 
006B: 140@ *= 125@ 
0087: 141@ = 126@ 
006B: 141@ *= 126@ 
0087: 127@ = 140@ 
005B: 127@ += 141@ 
01FB: 127@ = square_root 127@ 
149@ = 13.0 
0073: 149@ /= 127@ 
0087: 140@ = 125@ 
006B: 140@ *= 149@ 
0087: 110@ = 104@ 
005B: 110@ += 140@ 
0087: 141@ = 126@ 
006B: 141@ *= 149@ 
0087: 111@ = 105@ 
005B: 111@ += 141@ 
149@ = 2.0 
0073: 149@ /= 127@ 
0087: 140@ = 125@ 
006B: 140@ *= 149@ 
005B: 104@ += 140@ 
0087: 141@ = 126@ 
006B: 141@ *= 149@ 
005B: 105@ += 141@ 
0087: 107@ = 104@ 
0063: 107@ -= 110@ 
107@ /= 2.0 
005B: 107@ += 110@ 
0087: 108@ = 105@ 
0063: 108@ -= 111@ 
108@ /= 2.0 
005B: 108@ += 111@ 
0087: 109@ = 106@ 
0063: 109@ -= 112@ 
109@ /= 2.0 
005B: 109@ += 112@ 
106@ += 0.5 
109@ += 0.5 
112@ += 0.5 

:COPCAR_2742
if 
  1.0 > 106@ 
else_jump @COPCAR_2774 
wait 0 
jump @COPCAR_1666 

:COPCAR_2774
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: 115@ = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY 104@ 105@ 
if or
  150.0 > 115@ 
  115@ > 800.0 
else_jump @COPCAR_2847 
wait 0 
jump @COPCAR_1666 

:COPCAR_2847
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  " + STAT_Unlocked_Cities_Number + @" == 0 
else_jump @COPCAR_3105 
if and
  78.4427 > 104@ 
  -699.519 > 105@ 
else_jump @COPCAR_2915 
wait 0 
jump @COPCAR_1666 

:COPCAR_2915
if and
  -252.6557 > 104@ 
  -285.766 > 105@ 
else_jump @COPCAR_2957 
wait 0 
jump @COPCAR_1666 

:COPCAR_2957
if 
  -948.3447 > 104@ 
else_jump @COPCAR_2989 
wait 0 
jump @COPCAR_1666 

:COPCAR_2989
if and
  104@ > 1473.448 
  105@ > 403.7353 
else_jump @COPCAR_3031 
wait 0 
jump @COPCAR_1666 

:COPCAR_3031
if 
  105@ > 578.6325 
else_jump @COPCAR_3063 
wait 0 
jump @COPCAR_1666 

:COPCAR_3063
if and
  837.5551 > 104@ 
  105@ > 347.4097 
else_jump @COPCAR_3105 
wait 0 
jump @COPCAR_1666 

:COPCAR_3105
if 
  2 > " + STAT_Unlocked_Cities_Number + @" 
else_jump @COPCAR_3353 
if and
  104@ > 1473.448 
  105@ > 403.7353 
else_jump @COPCAR_3165 
wait 0 
jump @COPCAR_1666 

:COPCAR_3165
if and
  105@ > 578.6325 
  104@ > -1528.498 
else_jump @COPCAR_3207 
wait 0 
jump @COPCAR_1666 

:COPCAR_3207
if and
  837.5551 > 104@ 
  104@ > -1528.498 
  105@ > 347.4097 
else_jump @COPCAR_3259 
wait 0 
jump @COPCAR_1666 

:COPCAR_3259
if 
  105@ > 1380.0 
else_jump @COPCAR_3291 
wait 0 
jump @COPCAR_1666 

:COPCAR_3291
if and
  104@ > -2702.72 
  105@ > 1225.669 
  -2663.146 > 104@ 
  1654.808 > 105@ 
else_jump @COPCAR_3353 
wait 0 
jump @COPCAR_1666 

:COPCAR_3353
if and
  104@ > -1735.751 
  105@ > -696.0117 
  -1192.817 > 104@ 
  286.3584 > 105@ 
else_jump @COPCAR_3415 
wait 0 
jump @COPCAR_1666 

:COPCAR_3415
if and
  104@ > -1192.817 
  105@ > -521.9908 
  -1125.656 > 104@ 
  536.9476 > 105@ 
else_jump @COPCAR_3477 
wait 0 
jump @COPCAR_1666 

:COPCAR_3477
if and
  104@ > -1125.656 
  105@ > -329.59 
  -1020.189 > 104@ 
  536.9476 > 105@ 
else_jump @COPCAR_3539 
wait 0 
jump @COPCAR_1666 

:COPCAR_3539
0099: " + _8224 + @" = random_int_in_ranges_0_to_32767 

:COPCAR_3544
if 
  " + _8224 + @" == 0 
else_jump @COPCAR_3574 
0099: " + _8224 + @" = random_int_in_ranges_0_to_32767 
jump @COPCAR_3544 

:COPCAR_3574
if or
   not Model.Available(90@)
   not Model.Available(271@)
else_jump @COPCAR_3638 
wait 0 
gosub @COPCAR_18589 
if 
  58@ == 1 
else_jump @COPCAR_3631 
jump @COPCAR_14804 

:COPCAR_3631
jump @COPCAR_3574 

:COPCAR_3638
35@ = Car.Create(90@, 104@, 105@, 106@)
Car.Health(35@) = 800
00AE: set_car 35@ traffic_behaviour_to 2 
if 
  51@ > 3 
else_jump @COPCAR_3696 
048B: set_car 35@ route_seed " + _8224 + @" 

:COPCAR_3696
04BD: set_car 35@ is_part_of_convoy 1 
Car.Angle(35@) = 113@
0428: set_car 35@ avoid_level_transitions 1 

:COPCAR_3718
if 
04F1:   is_car_waiting_for_world_collision 35@ 
else_jump @COPCAR_3800 
wait 0 
if 
   Car.Wrecked(35@)
else_jump @COPCAR_3761 
jump @COPCAR_14804 

:COPCAR_3761
gosub @COPCAR_18589 
if 
  58@ == 1 
else_jump @COPCAR_3793 
jump @COPCAR_14804 

:COPCAR_3793
jump @COPCAR_3718 

:COPCAR_3800
36@ = Actor.CreateAsDriver(Mission2, 271@, 35@)
if 
  " + OnMission + @" == 0 
else_jump @COPCAR_4020 
018A: 92@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 93@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 94@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 95@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 96@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 97@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 98@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 99@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 100@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 101@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 102@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 103@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
062F: 274@ = create_group_type 0 
062F: 275@ = create_group_type 0 
062F: 276@ = create_group_type 0 

:COPCAR_4020
Marker.Disable(92@)
92@ = Marker.CreateAboveActor(36@)
0085: 50@ = 36@ 
gosub @COPCAR_18086 
if 
  51@ > 0 
else_jump @COPCAR_4144 
0632: release_group 274@ 
062F: 274@ = create_group_type 4 
0630: put_actor 36@ in_group 274@ as_leader 
06AD: set_group 274@ group_decision_maker_to 268@ 
37@ = Actor.CreateAsPassenger(Mission2, 271@, 35@, 0)
Marker.Disable(95@)
95@ = Marker.CreateAboveActor(37@)
0085: 50@ = 37@ 
gosub @COPCAR_18086 
jump @COPCAR_4151 

:COPCAR_4144
69@ = 1 

:COPCAR_4151
if 
  51@ > 1 
else_jump @COPCAR_4219 
38@ = Actor.CreateAsPassenger(Mission2, 271@, 35@, 1)
Marker.Disable(96@)
96@ = Marker.CreateAboveActor(38@)
0085: 50@ = 38@ 
gosub @COPCAR_18086 
jump @COPCAR_4226 

:COPCAR_4219
70@ = 1 

:COPCAR_4226
if 
  51@ > 2 
else_jump @COPCAR_4294 
39@ = Actor.CreateAsPassenger(Mission2, 271@, 35@, 2)
Marker.Disable(97@)
97@ = Marker.CreateAboveActor(39@)
0085: 50@ = 39@ 
gosub @COPCAR_18086 
jump @COPCAR_4301 

:COPCAR_4294
71@ = 1 

:COPCAR_4301
if 
  51@ > 3 
else_jump @COPCAR_4511 
40@ = Car.Create(90@, 107@, 108@, 109@)
04BD: set_car 40@ is_part_of_convoy 1 
Car.Angle(40@) = 113@
0428: set_car 40@ avoid_level_transitions 1 
00AE: set_car 40@ traffic_behaviour_to 2 
Car.Health(40@) = 800
048B: set_car 40@ route_seed " + _8224 + @" 

:COPCAR_4381
if 
04F1:   is_car_waiting_for_world_collision 40@ 
else_jump @COPCAR_4463 
wait 0 
if 
   Car.Wrecked(40@)
else_jump @COPCAR_4424 
jump @COPCAR_14804 

:COPCAR_4424
gosub @COPCAR_18589 
if 
  58@ == 1 
else_jump @COPCAR_4456 
jump @COPCAR_14804 

:COPCAR_4456
jump @COPCAR_4381 

:COPCAR_4463
41@ = Actor.CreateAsDriver(Mission2, 271@, 40@)
0085: 50@ = 41@ 
gosub @COPCAR_18086 
Marker.Disable(93@)
93@ = Marker.CreateAboveActor(41@)
jump @COPCAR_4525 

:COPCAR_4511
82@ = 1 
77@ = 1 

:COPCAR_4525
if 
  51@ > 4 
else_jump @COPCAR_4621 
0632: release_group 275@ 
062F: 275@ = create_group_type 4 
0630: put_actor 41@ in_group 275@ as_leader 
06AD: set_group 275@ group_decision_maker_to 268@ 
42@ = Actor.CreateAsPassenger(Mission2, 271@, 40@, 0)
Marker.Disable(98@)
98@ = Marker.CreateAboveActor(42@)
0085: 50@ = 42@ 
gosub @COPCAR_18086 
jump @COPCAR_4628 

:COPCAR_4621
78@ = 1 

:COPCAR_4628
if 
  51@ > 5 
else_jump @COPCAR_4696 
43@ = Actor.CreateAsPassenger(Mission2, 271@, 40@, 1)
Marker.Disable(99@)
99@ = Marker.CreateAboveActor(43@)
0085: 50@ = 43@ 
gosub @COPCAR_18086 
jump @COPCAR_4703 

:COPCAR_4696
79@ = 1 

:COPCAR_4703
if 
  51@ > 6 
else_jump @COPCAR_4771 
44@ = Actor.CreateAsPassenger(Mission2, 271@, 40@, 2)
Marker.Disable(100@)
100@ = Marker.CreateAboveActor(44@)
0085: 50@ = 44@ 
gosub @COPCAR_18086 
jump @COPCAR_4778 

:COPCAR_4771
80@ = 1 

:COPCAR_4778
if 
  51@ > 7 
else_jump @COPCAR_4988 
45@ = Car.Create(90@, 110@, 111@, 112@)
04BD: set_car 45@ is_part_of_convoy 1 
Car.Angle(45@) = 113@
0428: set_car 45@ avoid_level_transitions 1 
00AE: set_car 45@ traffic_behaviour_to 2 
Car.Health(45@) = 800
048B: set_car 45@ route_seed " + _8224 + @" 

:COPCAR_4858
if 
04F1:   is_car_waiting_for_world_collision 45@ 
else_jump @COPCAR_4940 
wait 0 
if 
   Car.Wrecked(45@)
else_jump @COPCAR_4901 
jump @COPCAR_14804 

:COPCAR_4901
gosub @COPCAR_18589 
if 
  58@ == 1 
else_jump @COPCAR_4933 
jump @COPCAR_14804 

:COPCAR_4933
jump @COPCAR_4858 

:COPCAR_4940
46@ = Actor.CreateAsDriver(Mission2, 271@, 45@)
0085: 50@ = 46@ 
gosub @COPCAR_18086 
Marker.Disable(94@)
94@ = Marker.CreateAboveActor(46@)
jump @COPCAR_5002 

:COPCAR_4988
89@ = 1 
84@ = 1 

:COPCAR_5002
if 
  51@ > 8 
else_jump @COPCAR_5098 
0632: release_group 276@ 
062F: 276@ = create_group_type 4 
0630: put_actor 46@ in_group 276@ as_leader 
06AD: set_group 276@ group_decision_maker_to 268@ 
47@ = Actor.CreateAsPassenger(Mission2, 271@, 45@, 0)
Marker.Disable(101@)
101@ = Marker.CreateAboveActor(47@)
0085: 50@ = 47@ 
gosub @COPCAR_18086 
jump @COPCAR_5105 

:COPCAR_5098
85@ = 1 

:COPCAR_5105
if 
  51@ > 9 
else_jump @COPCAR_5173 
48@ = Actor.CreateAsPassenger(Mission2, 271@, 45@, 1)
Marker.Disable(102@)
102@ = Marker.CreateAboveActor(48@)
0085: 50@ = 48@ 
gosub @COPCAR_18086 
jump @COPCAR_5180 

:COPCAR_5173
86@ = 1 

:COPCAR_5180
if 
  51@ > 10 
else_jump @COPCAR_5248 
49@ = Actor.CreateAsPassenger(Mission2, 271@, 45@, 2)
Marker.Disable(103@)
103@ = Marker.CreateAboveActor(49@)
0085: 50@ = 49@ 
gosub @COPCAR_18086 
jump @COPCAR_5255 

:COPCAR_5248
87@ = 1 

:COPCAR_5255
Model.Destroy(90@)
Model.Destroy(271@)
if 
   not Actor.Dead(36@)
else_jump @COPCAR_5295 
Actor.StorePos(36@, 116@, 117@, " + tempvar_Float_3 + @")

:COPCAR_5295
0843: get_zone_at 116@ 117@ " + tempvar_Float_3 + @" nameA_to " + _8225 + @" 
if 
  51@ == 0 
else_jump @COPCAR_5353 
0384: show_text_1string GXT 'C_BREIF' string " + _8225 + @" time 5000 1  
jump @COPCAR_5372 

:COPCAR_5353
0384: show_text_1string GXT 'C_BREIS' string " + _8225 + @" time 5000 1  

:COPCAR_5372
03AA: NOP 116@ 117@ " + tempvar_Float_3 + @" 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0086: " + _3404 + @" = " + tempvar_X_coord + @" 
0067: " + _3404 + @" -= 116@ 
0086: " + _3405 + @" = " + tempvar_Y_coord + @" 
0067: " + _3405 + @" -= 117@ 
0069: " + _3404 + @" *= " + _3404 + @" 
0069: " + _3405 + @" *= " + _3405 + @" 
0089: 114@ = " + _3405 + @" 
005D: 114@ += " + _3405 + @" 
01FB: 114@ = square_root 114@ 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @COPCAR_5505 
142@ = 8.0 
jump @COPCAR_5515 

:COPCAR_5505
142@ = 4.0 

:COPCAR_5515
005B: 142@ += 144@ 
0073: 114@ /= 142@ 
114@ *= 1000.0 
0092: 63@ = float 114@ to_integer 
if 
  40000 > 63@ 
else_jump @COPCAR_5580 
63@ = 40000 

:COPCAR_5580
005E: " + _8222 + @" += 63@ 
63@ /= 1000 
008A: " + _8227 + @" = 51@ 
" + _8227 + @" += 1 
if 
  65@ == 1 
else_jump @COPCAR_5659 
09EE: set_status_text_stay_on_screen 1 
01E3: show_text_1number_styled GXT 'A_TIME' number 63@ time 4000 style 6  
jump @COPCAR_5757 

:COPCAR_5659
if 
  45000 > " + _8222 + @" 
else_jump @COPCAR_5690 
" + _8222 + @" = 45000 

:COPCAR_5690
" + _8222 + @" += 30000 
03C3: set_timer_to " + _8222 + @" type 1 GXT 'COPTIME' 
65@ = 1 
04F7: status_text " + _8227 + @" type 0 line 1 GXT 'COPLEVL' 
04F7: status_text " + _8223 + @" type 0 line 2 GXT 'KILLS' 

:COPCAR_5757
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 72@ = " + Current_Time_in_ms2 + @" 
008B: 81@ = " + Current_Time_in_ms2 + @" 
008B: 88@ = " + Current_Time_in_ms2 + @" 
if 
  13 > 51@ 
else_jump @COPCAR_5814 
144@ += 0.1 

:COPCAR_5814
0396: pause_timer 0 

:COPCAR_5818
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
gosub @COPCAR_18589 
if 
  58@ == 1 
else_jump @COPCAR_5873 
jump @COPCAR_14804 

:COPCAR_5873
if or
  269@ == -1 
  74@ == -1 
  83@ == -1 
else_jump @COPCAR_5912 
52@ = 1 

:COPCAR_5912
270@ += 1 
if 
  270@ > 2 
else_jump @COPCAR_5944 
270@ = 0 

:COPCAR_5944
if 
  270@ == 0 
else_jump @COPCAR_8260 
if 
   not Actor.Dead(36@)
else_jump @COPCAR_7330 
if 
0449:   actor 36@ in_a_car 
else_jump @COPCAR_6784 
Car.RemoveReferences(35@)
35@ = Actor.CurrentCar(36@)
if 
  269@ == -1 
else_jump @COPCAR_6112 
046D: 55@ = actor 36@ members_in_group 
if 
  55@ > 0 
else_jump @COPCAR_6097 
if 
07FD:   group 274@ alive 
else_jump @COPCAR_6074 
07B3: set_group 274@ give_command 4 

:COPCAR_6074
008B: 72@ = " + Current_Time_in_ms2 + @" 
72@ += 2000 
jump @COPCAR_6105 

:COPCAR_6097
008B: 72@ = " + Current_Time_in_ms2 + @" 

:COPCAR_6105
269@ = 0 

:COPCAR_6112
if 
  269@ == 0 
else_jump @COPCAR_6201 
if or
001E:   " + Current_Time_in_ms2 + @" > 72@ 
07D6:   72@ == " + Current_Time_in_ms2 + @" 
else_jump @COPCAR_6201 
Car.SetMaxSpeed(35@, 100.0)
00AE: set_car 35@ traffic_behaviour_to 2 
Car.SetToPsychoDriver(35@)
008B: 66@ = " + Current_Time_in_ms2 + @" 
269@ = 1 
67@ = 0 

:COPCAR_6201
if 
  269@ > 0 
else_jump @COPCAR_6777 
if 
   Actor.InCar(" + PlayerActor + @", 35@)
else_jump @COPCAR_6275 
062E: get_actor 36@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_6275 
05E2: AS_actor 36@ kill_actor " + PlayerActor + @" 

:COPCAR_6275
0085: 153@ = 35@ 
0085: 154@ = 67@ 
0085: 155@ = 66@ 
0087: 150@ = 145@ 
0087: 151@ = 146@ 
0087: 152@ = 147@ 
if 
  148@ > 0.0 
else_jump @COPCAR_6351 
gosub @COPCAR_16114 

:COPCAR_6351
0085: 67@ = 154@ 
0085: 66@ = 155@ 
0087: 145@ = 150@ 
0087: 146@ = 151@ 
0087: 147@ = 152@ 
if 
  67@ == -9 
else_jump @COPCAR_6481 
062E: get_actor 36@ task 1498 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_6474 
Actor.StorePos(36@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
05DA: AS_actor 36@ run_away_in_panic_from " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" away_radius 15.0 timelimit 1500 

:COPCAR_6474
67@ = 0 

:COPCAR_6481
if 
8185:   not car 35@ health >= 251 
else_jump @COPCAR_6588 
062E: get_actor 36@ task 1498 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_6565 
Actor.StorePos(36@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
05DA: AS_actor 36@ run_away_in_panic_from " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" away_radius 15.0 timelimit 1500 

:COPCAR_6565
008B: 72@ = " + Current_Time_in_ms2 + @" 
72@ += 2000 
jump @COPCAR_6596 

:COPCAR_6588
008B: 72@ = " + Current_Time_in_ms2 + @" 

:COPCAR_6596
gosub @COPCAR_16751 
Actor.StorePos(36@, 116@, 117@, " + tempvar_Float_3 + @")
0086: " + _3404 + @" = " + tempvar_X_coord + @" 
0067: " + _3404 + @" -= 116@ 
0086: " + _3405 + @" = " + tempvar_Y_coord + @" 
0067: " + _3405 + @" -= 117@ 
0069: " + _3404 + @" *= " + _3404 + @" 
0069: " + _3405 + @" *= " + _3405 + @" 
0089: 149@ = " + _3404 + @" 
005D: 149@ += " + _3405 + @" 
01FB: 149@ = square_root 149@ 
148@ = 1000.0 
0073: 148@ /= 149@ 
if 
  148@ > 100.0 
else_jump @COPCAR_6738 
148@ = 100.0 

:COPCAR_6738
if 
  15.0 > 148@ 
else_jump @COPCAR_6769 
148@ = 15.0 

:COPCAR_6769
Car.SetMaxSpeed(35@, 148@)

:COPCAR_6777
jump @COPCAR_7323 

:COPCAR_6784
if 
07FD:   group 274@ alive 
else_jump @COPCAR_6807 
07B3: set_group 274@ give_command 0 

:COPCAR_6807
269@ = -1 
gosub @COPCAR_16751 
if 
001E:   " + Current_Time_in_ms2 + @" > 72@ 
else_jump @COPCAR_7323 
if 
00F2:   actor " + PlayerActor + @" near_actor 36@ radius 45.0 45.0 0 
else_jump @COPCAR_7168 
if 
   not Actor.Driving(" + PlayerActor + @")
else_jump @COPCAR_6931 
062E: get_actor 36@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_6924 
05E2: AS_actor 36@ kill_actor " + PlayerActor + @" 

:COPCAR_6924
jump @COPCAR_7161 

:COPCAR_6931
if 
00F2:   actor " + PlayerActor + @" near_actor 36@ radius 30.0 30.0 0 
else_jump @COPCAR_7006 
062E: get_actor 36@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_6999 
05E2: AS_actor 36@ kill_actor " + PlayerActor + @" 

:COPCAR_6999
jump @COPCAR_7161 

:COPCAR_7006
0085: 156@ = 36@ 
if 
   not Car.Wrecked(35@)
else_jump @COPCAR_7154 
if 
0185:   car 35@ health >= 400 
else_jump @COPCAR_7140 
if 
0202:   actor 36@ near_car 35@ radius 40.0 40.0 sphere 0 
else_jump @COPCAR_7126 
062E: get_actor 36@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_7119 
05CB: AS_actor 36@ enter_car 35@ as_driver -2 ms 

:COPCAR_7119
jump @COPCAR_7133 

:COPCAR_7126
gosub @COPCAR_15324 

:COPCAR_7133
jump @COPCAR_7147 

:COPCAR_7140
gosub @COPCAR_15324 

:COPCAR_7147
jump @COPCAR_7161 

:COPCAR_7154
gosub @COPCAR_15324 

:COPCAR_7161
jump @COPCAR_7323 

:COPCAR_7168
0085: 156@ = 36@ 
if 
   not Car.Wrecked(35@)
else_jump @COPCAR_7316 
if 
0185:   car 35@ health >= 400 
else_jump @COPCAR_7302 
if 
0202:   actor 36@ near_car 35@ radius 40.0 40.0 sphere 0 
else_jump @COPCAR_7288 
062E: get_actor 36@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_7281 
05CB: AS_actor 36@ enter_car 35@ as_driver -2 ms 

:COPCAR_7281
jump @COPCAR_7295 

:COPCAR_7288
gosub @COPCAR_15324 

:COPCAR_7295
jump @COPCAR_7309 

:COPCAR_7302
gosub @COPCAR_15324 

:COPCAR_7309
jump @COPCAR_7323 

:COPCAR_7316
gosub @COPCAR_15324 

:COPCAR_7323
jump @COPCAR_7920 

:COPCAR_7330
Marker.Disable(92@)
Actor.RemoveReferences(36@)
36@ = -1 
if 
  68@ == 0 
else_jump @COPCAR_7406 
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
68@ = 1 

:COPCAR_7406
if 
07FD:   group 274@ alive 
else_jump @COPCAR_7920 
if 
   not Actor.Dead(37@)
else_jump @COPCAR_7571 
if 
86EE:   not actor 37@ in_group 274@ 
else_jump @COPCAR_7501 
062E: get_actor 37@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_7494 
05E2: AS_actor 37@ kill_actor " + PlayerActor + @" 

:COPCAR_7494
jump @COPCAR_7564 

:COPCAR_7501
if 
06EF:   actor 37@ leading_group 274@ 
else_jump @COPCAR_7564 
0085: 36@ = 37@ 
37@ = -1 
68@ = 0 
69@ = 1 
0085: 92@ = 95@ 
95@ = -1 

:COPCAR_7564
jump @COPCAR_7588 

:COPCAR_7571
Marker.Disable(95@)
Actor.RemoveReferences(37@)
37@ = -1 

:COPCAR_7588
if 
   not Actor.Dead(38@)
else_jump @COPCAR_7737 
if 
86EE:   not actor 38@ in_group 274@ 
else_jump @COPCAR_7667 
062E: get_actor 38@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_7660 
05E2: AS_actor 38@ kill_actor " + PlayerActor + @" 

:COPCAR_7660
jump @COPCAR_7730 

:COPCAR_7667
if 
06EF:   actor 38@ leading_group 274@ 
else_jump @COPCAR_7730 
0085: 36@ = 38@ 
38@ = -1 
68@ = 0 
70@ = 1 
0085: 92@ = 96@ 
96@ = -1 

:COPCAR_7730
jump @COPCAR_7754 

:COPCAR_7737
Marker.Disable(96@)
Actor.RemoveReferences(38@)
38@ = -1 

:COPCAR_7754
if 
   not Actor.Dead(39@)
else_jump @COPCAR_7903 
if 
86EE:   not actor 39@ in_group 274@ 
else_jump @COPCAR_7833 
062E: get_actor 39@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_7826 
05E2: AS_actor 39@ kill_actor " + PlayerActor + @" 

:COPCAR_7826
jump @COPCAR_7896 

:COPCAR_7833
if 
06EF:   actor 39@ leading_group 274@ 
else_jump @COPCAR_7896 
0085: 36@ = 39@ 
39@ = -1 
68@ = 0 
71@ = 1 
0085: 92@ = 97@ 
97@ = -1 

:COPCAR_7896
jump @COPCAR_7920 

:COPCAR_7903
Marker.Disable(97@)
Actor.RemoveReferences(39@)
39@ = -1 

:COPCAR_7920
if 
   Actor.Dead(37@)
else_jump @COPCAR_8012 
if 
  69@ == 0 
else_jump @COPCAR_8012 
Actor.RemoveReferences(37@)
37@ = -1 
Marker.Disable(95@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
69@ = 1 

:COPCAR_8012
if 
   Actor.Dead(38@)
else_jump @COPCAR_8104 
if 
  70@ == 0 
else_jump @COPCAR_8104 
Actor.RemoveReferences(38@)
38@ = -1 
Marker.Disable(96@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
70@ = 1 

:COPCAR_8104
if 
   Actor.Dead(39@)
else_jump @COPCAR_8196 
if 
  71@ == 0 
else_jump @COPCAR_8196 
Actor.RemoveReferences(39@)
39@ = -1 
Marker.Disable(97@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
71@ = 1 

:COPCAR_8196
if 
  73@ == 0 
else_jump @COPCAR_8260 
if and
  68@ == 1 
  69@ == 1 
  70@ == 1 
  71@ == 1 
else_jump @COPCAR_8260 
73@ = 1 

:COPCAR_8260
if 
  270@ == 1 
else_jump @COPCAR_11091 
if 
   not Actor.Dead(41@)
else_jump @COPCAR_10161 
if 
0449:   actor 41@ in_a_car 
else_jump @COPCAR_9615 
Car.RemoveReferences(40@)
40@ = Actor.CurrentCar(41@)
if 
  74@ == -1 
else_jump @COPCAR_8428 
046D: 55@ = actor 41@ members_in_group 
if 
  55@ > 0 
else_jump @COPCAR_8413 
if 
07FD:   group 275@ alive 
else_jump @COPCAR_8390 
07B3: set_group 275@ give_command 4 

:COPCAR_8390
008B: 81@ = " + Current_Time_in_ms2 + @" 
81@ += 2000 
jump @COPCAR_8421 

:COPCAR_8413
008B: 81@ = " + Current_Time_in_ms2 + @" 

:COPCAR_8421
74@ = 0 

:COPCAR_8428
if 
  74@ == 0 
else_jump @COPCAR_8587 
if 
001E:   " + Current_Time_in_ms2 + @" > 81@ 
else_jump @COPCAR_8587 
Car.SetMaxSpeed(40@, 100.0)
00AE: set_car 40@ traffic_behaviour_to 2 
if 
  52@ == 0 
else_jump @COPCAR_8535 
if 
   not Car.Wrecked(35@)
else_jump @COPCAR_8528 
Car.SetToPsychoDriver(40@)
jump @COPCAR_8535 

:COPCAR_8528
52@ = 1 

:COPCAR_8535
if 
  52@ == 1 
else_jump @COPCAR_8565 
04BD: set_car 40@ is_part_of_convoy 0 
Car.SetToPsychoDriver(40@)

:COPCAR_8565
008B: 75@ = " + Current_Time_in_ms2 + @" 
74@ = 1 
76@ = 0 

:COPCAR_8587
if 
  74@ > 0 
else_jump @COPCAR_9608 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @COPCAR_8661 
062E: get_actor 41@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_8661 
05E2: AS_actor 41@ kill_actor " + PlayerActor + @" 

:COPCAR_8661
0085: 153@ = 40@ 
0085: 154@ = 76@ 
0085: 155@ = 75@ 
0087: 150@ = 164@ 
0087: 151@ = 165@ 
0087: 152@ = 166@ 
if 
  167@ > 0.0 
else_jump @COPCAR_8737 
gosub @COPCAR_16114 

:COPCAR_8737
0085: 76@ = 154@ 
0085: 75@ = 155@ 
0087: 164@ = 150@ 
0087: 165@ = 151@ 
0087: 166@ = 152@ 
if 
  76@ == -9 
else_jump @COPCAR_8867 
062E: get_actor 41@ task 1498 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_8860 
Actor.StorePos(41@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
05DA: AS_actor 41@ run_away_in_panic_from " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" away_radius 15.0 timelimit 1500 

:COPCAR_8860
76@ = 0 

:COPCAR_8867
if 
8185:   not car 40@ health >= 400 
else_jump @COPCAR_8923 
062E: get_actor 41@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_8923 
05E2: AS_actor 41@ kill_actor " + PlayerActor + @" 

:COPCAR_8923
if 
8185:   not car 40@ health >= 251 
else_jump @COPCAR_9030 
062E: get_actor 41@ task 1498 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_9007 
Actor.StorePos(41@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
05DA: AS_actor 41@ run_away_in_panic_from " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" away_radius 15.0 timelimit 1500 

:COPCAR_9007
008B: 81@ = " + Current_Time_in_ms2 + @" 
81@ += 2000 
jump @COPCAR_9038 

:COPCAR_9030
008B: 81@ = " + Current_Time_in_ms2 + @" 

:COPCAR_9038
gosub @COPCAR_17196 
Actor.StorePos(41@, 162@, 163@, " + tempvar_Float_3 + @")
0086: " + _3404 + @" = " + tempvar_X_coord + @" 
0067: " + _3404 + @" -= 162@ 
0086: " + _3405 + @" = " + tempvar_Y_coord + @" 
0067: " + _3405 + @" -= 163@ 
0069: " + _3404 + @" *= " + _3404 + @" 
0069: " + _3405 + @" *= " + _3405 + @" 
0089: 149@ = " + _3404 + @" 
005D: 149@ += " + _3405 + @" 
01FB: 149@ = square_root 149@ 
167@ = 1000.0 
0073: 167@ /= 149@ 
if 
  167@ > 100.0 
else_jump @COPCAR_9180 
167@ = 100.0 

:COPCAR_9180
if 
  15.0 > 167@ 
else_jump @COPCAR_9211 
167@ = 15.0 

:COPCAR_9211
if 
  52@ == 0 
else_jump @COPCAR_9563 
if 
   not Car.Wrecked(35@)
else_jump @COPCAR_9551 
0085: 157@ = 40@ 
0085: 158@ = 35@ 
gosub @COPCAR_15111 
0087: 167@ = 124@ 
02F8: get_car 40@ Z_angle_sine_to 138@ 
02F9: get_car 40@ Z_angle_cosine_to 139@ 
Car.StorePos(35@, 132@, 133@, " + tempvar_Float_3 + @")
Car.StorePos(40@, 134@, 135@, " + tempvar_Float_3 + @")
0087: 120@ = 134@ 
0063: 120@ -= 132@ 
006B: 138@ *= 120@ 
0087: 121@ = 135@ 
0063: 121@ -= 133@ 
006B: 139@ *= 121@ 
0087: 128@ = 138@ 
005B: 128@ += 139@ 
02F8: get_car 35@ Z_angle_sine_to 138@ 
02F9: get_car 35@ Z_angle_cosine_to 139@ 
Car.StorePos(40@, 134@, 135@, " + tempvar_Float_3 + @")
Car.StorePos(35@, 132@, 133@, " + tempvar_Float_3 + @")
0087: 120@ = 132@ 
0063: 120@ -= 134@ 
006B: 138@ *= 120@ 
0087: 121@ = 133@ 
0063: 121@ -= 135@ 
006B: 139@ *= 121@ 
0087: 129@ = 138@ 
005B: 129@ += 139@ 
if 
  128@ > 0.0 
else_jump @COPCAR_9544 
if 
  0.0 > 129@ 
else_jump @COPCAR_9544 
167@ = 0.0 

:COPCAR_9544
jump @COPCAR_9563 

:COPCAR_9551
Car.SetToPsychoDriver(40@)
52@ = 1 

:COPCAR_9563
if 
  167@ == 0.0 
else_jump @COPCAR_9600 
Car.SetAnimation(40@, 1, 17)
jump @COPCAR_9608 

:COPCAR_9600
Car.SetMaxSpeed(40@, 167@)

:COPCAR_9608
jump @COPCAR_10154 

:COPCAR_9615
if 
07FD:   group 275@ alive 
else_jump @COPCAR_9638 
07B3: set_group 275@ give_command 0 

:COPCAR_9638
74@ = -1 
gosub @COPCAR_17196 
if 
001E:   " + Current_Time_in_ms2 + @" > 81@ 
else_jump @COPCAR_10154 
if 
00F2:   actor " + PlayerActor + @" near_actor 41@ radius 40.0 40.0 0 
else_jump @COPCAR_9999 
if 
   not Actor.Driving(" + PlayerActor + @")
else_jump @COPCAR_9762 
062E: get_actor 41@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_9755 
05E2: AS_actor 41@ kill_actor " + PlayerActor + @" 

:COPCAR_9755
jump @COPCAR_9992 

:COPCAR_9762
if 
00F2:   actor " + PlayerActor + @" near_actor 41@ radius 25.0 25.0 0 
else_jump @COPCAR_9837 
062E: get_actor 41@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_9830 
05E2: AS_actor 41@ kill_actor " + PlayerActor + @" 

:COPCAR_9830
jump @COPCAR_9992 

:COPCAR_9837
0085: 156@ = 41@ 
if 
   not Car.Wrecked(40@)
else_jump @COPCAR_9985 
if 
0185:   car 40@ health >= 400 
else_jump @COPCAR_9971 
if 
0202:   actor 41@ near_car 40@ radius 40.0 40.0 sphere 0 
else_jump @COPCAR_9957 
062E: get_actor 41@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_9950 
05CB: AS_actor 41@ enter_car 40@ as_driver -2 ms 

:COPCAR_9950
jump @COPCAR_9964 

:COPCAR_9957
gosub @COPCAR_15324 

:COPCAR_9964
jump @COPCAR_9978 

:COPCAR_9971
gosub @COPCAR_15324 

:COPCAR_9978
jump @COPCAR_9992 

:COPCAR_9985
gosub @COPCAR_15324 

:COPCAR_9992
jump @COPCAR_10154 

:COPCAR_9999
0085: 156@ = 41@ 
if 
   not Car.Wrecked(40@)
else_jump @COPCAR_10147 
if 
0185:   car 40@ health >= 400 
else_jump @COPCAR_10133 
if 
0202:   actor 41@ near_car 40@ radius 40.0 40.0 sphere 0 
else_jump @COPCAR_10119 
062E: get_actor 41@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_10112 
05CB: AS_actor 41@ enter_car 40@ as_driver -2 ms 

:COPCAR_10112
jump @COPCAR_10126 

:COPCAR_10119
gosub @COPCAR_15324 

:COPCAR_10126
jump @COPCAR_10140 

:COPCAR_10133
gosub @COPCAR_15324 

:COPCAR_10140
jump @COPCAR_10154 

:COPCAR_10147
gosub @COPCAR_15324 

:COPCAR_10154
jump @COPCAR_10751 

:COPCAR_10161
Marker.Disable(93@)
Actor.RemoveReferences(41@)
41@ = -1 
if 
  77@ == 0 
else_jump @COPCAR_10237 
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
77@ = 1 

:COPCAR_10237
if 
07FD:   group 275@ alive 
else_jump @COPCAR_10751 
if 
   not Actor.Dead(42@)
else_jump @COPCAR_10402 
if 
86EE:   not actor 42@ in_group 275@ 
else_jump @COPCAR_10332 
062E: get_actor 42@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_10325 
05E2: AS_actor 42@ kill_actor " + PlayerActor + @" 

:COPCAR_10325
jump @COPCAR_10395 

:COPCAR_10332
if 
06EF:   actor 42@ leading_group 275@ 
else_jump @COPCAR_10395 
0085: 41@ = 42@ 
42@ = -1 
77@ = 0 
78@ = 1 
0085: 93@ = 98@ 
98@ = -1 

:COPCAR_10395
jump @COPCAR_10419 

:COPCAR_10402
Marker.Disable(98@)
Actor.RemoveReferences(42@)
42@ = -1 

:COPCAR_10419
if 
   not Actor.Dead(43@)
else_jump @COPCAR_10568 
if 
86EE:   not actor 43@ in_group 275@ 
else_jump @COPCAR_10498 
062E: get_actor 43@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_10491 
05E2: AS_actor 43@ kill_actor " + PlayerActor + @" 

:COPCAR_10491
jump @COPCAR_10561 

:COPCAR_10498
if 
06EF:   actor 43@ leading_group 275@ 
else_jump @COPCAR_10561 
0085: 41@ = 43@ 
43@ = -1 
77@ = 0 
79@ = 1 
0085: 93@ = 99@ 
99@ = -1 

:COPCAR_10561
jump @COPCAR_10585 

:COPCAR_10568
Marker.Disable(99@)
Actor.RemoveReferences(43@)
43@ = -1 

:COPCAR_10585
if 
   not Actor.Dead(44@)
else_jump @COPCAR_10734 
if 
86EE:   not actor 44@ in_group 275@ 
else_jump @COPCAR_10664 
062E: get_actor 44@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_10657 
05E2: AS_actor 44@ kill_actor " + PlayerActor + @" 

:COPCAR_10657
jump @COPCAR_10727 

:COPCAR_10664
if 
06EF:   actor 44@ leading_group 275@ 
else_jump @COPCAR_10727 
0085: 41@ = 44@ 
44@ = -1 
77@ = 0 
80@ = 1 
0085: 93@ = 100@ 
100@ = -1 

:COPCAR_10727
jump @COPCAR_10751 

:COPCAR_10734
Marker.Disable(100@)
Actor.RemoveReferences(44@)
44@ = -1 

:COPCAR_10751
if 
   Actor.Dead(42@)
else_jump @COPCAR_10843 
if 
  78@ == 0 
else_jump @COPCAR_10843 
Actor.RemoveReferences(42@)
42@ = -1 
Marker.Disable(98@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
78@ = 1 

:COPCAR_10843
if 
   Actor.Dead(43@)
else_jump @COPCAR_10935 
if 
  79@ == 0 
else_jump @COPCAR_10935 
Actor.RemoveReferences(43@)
43@ = -1 
Marker.Disable(99@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
79@ = 1 

:COPCAR_10935
if 
   Actor.Dead(44@)
else_jump @COPCAR_11027 
if 
  80@ == 0 
else_jump @COPCAR_11027 
Actor.RemoveReferences(44@)
44@ = -1 
Marker.Disable(100@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
80@ = 1 

:COPCAR_11027
if 
  82@ == 0 
else_jump @COPCAR_11091 
if and
  77@ == 1 
  78@ == 1 
  79@ == 1 
  80@ == 1 
else_jump @COPCAR_11091 
82@ = 1 

:COPCAR_11091
if 
  270@ == 2 
else_jump @COPCAR_13922 
if 
   not Actor.Dead(46@)
else_jump @COPCAR_12992 
if 
0449:   actor 46@ in_a_car 
else_jump @COPCAR_12446 
Car.RemoveReferences(45@)
45@ = Actor.CurrentCar(46@)
if 
  83@ == -1 
else_jump @COPCAR_11259 
046D: 55@ = actor 46@ members_in_group 
if 
  55@ > 0 
else_jump @COPCAR_11244 
if 
07FD:   group 276@ alive 
else_jump @COPCAR_11221 
07B3: set_group 276@ give_command 4 

:COPCAR_11221
008B: 88@ = " + Current_Time_in_ms2 + @" 
88@ += 2000 
jump @COPCAR_11252 

:COPCAR_11244
008B: 88@ = " + Current_Time_in_ms2 + @" 

:COPCAR_11252
83@ = 0 

:COPCAR_11259
if 
  83@ == 0 
else_jump @COPCAR_11418 
if 
001E:   " + Current_Time_in_ms2 + @" > 88@ 
else_jump @COPCAR_11418 
Car.SetMaxSpeed(45@, 100.0)
00AE: set_car 45@ traffic_behaviour_to 2 
if 
  52@ == 0 
else_jump @COPCAR_11366 
if 
   not Car.Wrecked(40@)
else_jump @COPCAR_11359 
Car.SetToPsychoDriver(45@)
jump @COPCAR_11366 

:COPCAR_11359
52@ = 1 

:COPCAR_11366
if 
  52@ == 1 
else_jump @COPCAR_11396 
04BD: set_car 45@ is_part_of_convoy 0 
Car.SetToPsychoDriver(45@)

:COPCAR_11396
008B: 174@ = " + Current_Time_in_ms2 + @" 
83@ = 1 
175@ = 0 

:COPCAR_11418
if 
  83@ > 0 
else_jump @COPCAR_12439 
if 
   Actor.InCar(" + PlayerActor + @", 45@)
else_jump @COPCAR_11492 
062E: get_actor 46@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_11492 
05E2: AS_actor 46@ kill_actor " + PlayerActor + @" 

:COPCAR_11492
0085: 153@ = 45@ 
0085: 154@ = 175@ 
0085: 155@ = 174@ 
0087: 150@ = 170@ 
0087: 151@ = 171@ 
0087: 152@ = 172@ 
if 
  173@ > 0.0 
else_jump @COPCAR_11568 
gosub @COPCAR_16114 

:COPCAR_11568
0085: 175@ = 154@ 
0085: 174@ = 155@ 
0087: 170@ = 150@ 
0087: 171@ = 151@ 
0087: 172@ = 152@ 
if 
  175@ == -9 
else_jump @COPCAR_11698 
062E: get_actor 46@ task 1498 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_11691 
Actor.StorePos(46@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
05DA: AS_actor 46@ run_away_in_panic_from " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" away_radius 15.0 timelimit 1500 

:COPCAR_11691
175@ = 0 

:COPCAR_11698
if 
8185:   not car 45@ health >= 400 
else_jump @COPCAR_11754 
062E: get_actor 46@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_11754 
05E2: AS_actor 46@ kill_actor " + PlayerActor + @" 

:COPCAR_11754
if 
8185:   not car 45@ health >= 251 
else_jump @COPCAR_11861 
062E: get_actor 46@ task 1498 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_11838 
Actor.StorePos(46@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
05DA: AS_actor 46@ run_away_in_panic_from " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" away_radius 15.0 timelimit 1500 

:COPCAR_11838
008B: 88@ = " + Current_Time_in_ms2 + @" 
88@ += 2000 
jump @COPCAR_11869 

:COPCAR_11861
008B: 88@ = " + Current_Time_in_ms2 + @" 

:COPCAR_11869
gosub @COPCAR_17641 
Actor.StorePos(46@, 168@, 169@, " + tempvar_Float_3 + @")
0086: " + _3404 + @" = " + tempvar_X_coord + @" 
0067: " + _3404 + @" -= 168@ 
0086: " + _3405 + @" = " + tempvar_Y_coord + @" 
0067: " + _3405 + @" -= 169@ 
0069: " + _3404 + @" *= " + _3404 + @" 
0069: " + _3405 + @" *= " + _3405 + @" 
0089: 149@ = " + _3404 + @" 
005D: 149@ += " + _3405 + @" 
01FB: 149@ = square_root 149@ 
173@ = 1000.0 
0073: 173@ /= 149@ 
if 
  173@ > 100.0 
else_jump @COPCAR_12011 
173@ = 100.0 

:COPCAR_12011
if 
  15.0 > 173@ 
else_jump @COPCAR_12042 
173@ = 15.0 

:COPCAR_12042
if 
  52@ == 0 
else_jump @COPCAR_12394 
if 
   not Car.Wrecked(40@)
else_jump @COPCAR_12382 
0085: 157@ = 45@ 
0085: 158@ = 40@ 
gosub @COPCAR_15111 
0087: 173@ = 124@ 
02F8: get_car 45@ Z_angle_sine_to 138@ 
02F9: get_car 45@ Z_angle_cosine_to 139@ 
Car.StorePos(40@, 134@, 135@, " + tempvar_Float_3 + @")
Car.StorePos(45@, 136@, 137@, " + tempvar_Float_3 + @")
0087: 120@ = 136@ 
0063: 120@ -= 134@ 
006B: 138@ *= 120@ 
0087: 121@ = 137@ 
0063: 121@ -= 135@ 
006B: 139@ *= 121@ 
0087: 130@ = 138@ 
005B: 130@ += 139@ 
02F8: get_car 40@ Z_angle_sine_to 138@ 
02F9: get_car 40@ Z_angle_cosine_to 139@ 
Car.StorePos(45@, 136@, 137@, " + tempvar_Float_3 + @")
Car.StorePos(40@, 134@, 135@, " + tempvar_Float_3 + @")
0087: 120@ = 134@ 
0063: 120@ -= 136@ 
006B: 138@ *= 120@ 
0087: 121@ = 135@ 
0063: 121@ -= 137@ 
006B: 139@ *= 121@ 
0087: 131@ = 138@ 
005B: 131@ += 139@ 
if 
  130@ > 0.0 
else_jump @COPCAR_12375 
if 
  0.0 > 131@ 
else_jump @COPCAR_12375 
173@ = 0.0 

:COPCAR_12375
jump @COPCAR_12394 

:COPCAR_12382
Car.SetToPsychoDriver(45@)
52@ = 1 

:COPCAR_12394
if 
  173@ == 0.0 
else_jump @COPCAR_12431 
Car.SetAnimation(45@, 1, 17)
jump @COPCAR_12439 

:COPCAR_12431
Car.SetMaxSpeed(45@, 173@)

:COPCAR_12439
jump @COPCAR_12985 

:COPCAR_12446
if 
07FD:   group 276@ alive 
else_jump @COPCAR_12469 
07B3: set_group 276@ give_command 0 

:COPCAR_12469
83@ = -1 
gosub @COPCAR_17641 
if 
001E:   " + Current_Time_in_ms2 + @" > 88@ 
else_jump @COPCAR_12985 
if 
00F2:   actor " + PlayerActor + @" near_actor 46@ radius 40.0 40.0 0 
else_jump @COPCAR_12830 
if 
   not Actor.Driving(" + PlayerActor + @")
else_jump @COPCAR_12593 
062E: get_actor 46@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_12586 
05E2: AS_actor 46@ kill_actor " + PlayerActor + @" 

:COPCAR_12586
jump @COPCAR_12823 

:COPCAR_12593
if 
00F2:   actor " + PlayerActor + @" near_actor 46@ radius 25.0 25.0 0 
else_jump @COPCAR_12668 
062E: get_actor 46@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_12661 
05E2: AS_actor 46@ kill_actor " + PlayerActor + @" 

:COPCAR_12661
jump @COPCAR_12823 

:COPCAR_12668
0085: 156@ = 46@ 
if 
   not Car.Wrecked(45@)
else_jump @COPCAR_12816 
if 
0185:   car 45@ health >= 400 
else_jump @COPCAR_12802 
if 
0202:   actor 46@ near_car 45@ radius 40.0 40.0 sphere 0 
else_jump @COPCAR_12788 
062E: get_actor 46@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_12781 
05CB: AS_actor 46@ enter_car 45@ as_driver -2 ms 

:COPCAR_12781
jump @COPCAR_12795 

:COPCAR_12788
gosub @COPCAR_15324 

:COPCAR_12795
jump @COPCAR_12809 

:COPCAR_12802
gosub @COPCAR_15324 

:COPCAR_12809
jump @COPCAR_12823 

:COPCAR_12816
gosub @COPCAR_15324 

:COPCAR_12823
jump @COPCAR_12985 

:COPCAR_12830
0085: 156@ = 46@ 
if 
   not Car.Wrecked(45@)
else_jump @COPCAR_12978 
if 
0185:   car 45@ health >= 400 
else_jump @COPCAR_12964 
if 
0202:   actor 46@ near_car 45@ radius 40.0 40.0 sphere 0 
else_jump @COPCAR_12950 
062E: get_actor 46@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_12943 
05CB: AS_actor 46@ enter_car 45@ as_driver -2 ms 

:COPCAR_12943
jump @COPCAR_12957 

:COPCAR_12950
gosub @COPCAR_15324 

:COPCAR_12957
jump @COPCAR_12971 

:COPCAR_12964
gosub @COPCAR_15324 

:COPCAR_12971
jump @COPCAR_12985 

:COPCAR_12978
gosub @COPCAR_15324 

:COPCAR_12985
jump @COPCAR_13582 

:COPCAR_12992
Marker.Disable(94@)
Actor.RemoveReferences(46@)
46@ = -1 
if 
  84@ == 0 
else_jump @COPCAR_13068 
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
84@ = 1 

:COPCAR_13068
if 
07FD:   group 276@ alive 
else_jump @COPCAR_13582 
if 
   not Actor.Dead(47@)
else_jump @COPCAR_13233 
if 
86EE:   not actor 47@ in_group 276@ 
else_jump @COPCAR_13163 
062E: get_actor 47@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_13156 
05E2: AS_actor 47@ kill_actor " + PlayerActor + @" 

:COPCAR_13156
jump @COPCAR_13226 

:COPCAR_13163
if 
06EF:   actor 47@ leading_group 276@ 
else_jump @COPCAR_13226 
0085: 46@ = 47@ 
47@ = -1 
84@ = 0 
85@ = 1 
0085: 94@ = 101@ 
101@ = -1 

:COPCAR_13226
jump @COPCAR_13250 

:COPCAR_13233
Marker.Disable(101@)
Actor.RemoveReferences(47@)
47@ = -1 

:COPCAR_13250
if 
   not Actor.Dead(48@)
else_jump @COPCAR_13399 
if 
86EE:   not actor 48@ in_group 276@ 
else_jump @COPCAR_13329 
062E: get_actor 48@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_13322 
05E2: AS_actor 48@ kill_actor " + PlayerActor + @" 

:COPCAR_13322
jump @COPCAR_13392 

:COPCAR_13329
if 
06EF:   actor 48@ leading_group 276@ 
else_jump @COPCAR_13392 
0085: 46@ = 48@ 
48@ = -1 
84@ = 0 
86@ = 1 
0085: 94@ = 102@ 
102@ = -1 

:COPCAR_13392
jump @COPCAR_13416 

:COPCAR_13399
Marker.Disable(102@)
Actor.RemoveReferences(48@)
48@ = -1 

:COPCAR_13416
if 
   not Actor.Dead(49@)
else_jump @COPCAR_13565 
if 
86EE:   not actor 49@ in_group 276@ 
else_jump @COPCAR_13495 
062E: get_actor 49@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_13488 
05E2: AS_actor 49@ kill_actor " + PlayerActor + @" 

:COPCAR_13488
jump @COPCAR_13558 

:COPCAR_13495
if 
06EF:   actor 49@ leading_group 276@ 
else_jump @COPCAR_13558 
0085: 46@ = 49@ 
49@ = -1 
84@ = 0 
87@ = 1 
0085: 94@ = 103@ 
103@ = -1 

:COPCAR_13558
jump @COPCAR_13582 

:COPCAR_13565
Marker.Disable(103@)
Actor.RemoveReferences(49@)
49@ = -1 

:COPCAR_13582
if 
   Actor.Dead(47@)
else_jump @COPCAR_13674 
if 
  85@ == 0 
else_jump @COPCAR_13674 
Marker.Disable(101@)
Actor.RemoveReferences(47@)
47@ = -1 
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
85@ = 1 

:COPCAR_13674
if 
   Actor.Dead(48@)
else_jump @COPCAR_13766 
if 
  86@ == 0 
else_jump @COPCAR_13766 
Actor.RemoveReferences(48@)
48@ = -1 
Marker.Disable(102@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
86@ = 1 

:COPCAR_13766
if 
   Actor.Dead(49@)
else_jump @COPCAR_13858 
if 
  87@ == 0 
else_jump @COPCAR_13858 
Actor.RemoveReferences(49@)
49@ = -1 
Marker.Disable(103@)
" + _8223 + @" += 1 
0623: add 1 to_integer_stat 152 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
87@ = 1 

:COPCAR_13858
if 
  89@ == 0 
else_jump @COPCAR_13922 
if and
  84@ == 1 
  85@ == 1 
  86@ == 1 
  87@ == 1 
else_jump @COPCAR_13922 
89@ = 1 

:COPCAR_13922
if and
  73@ == 1 
  82@ == 1 
  89@ == 1 
else_jump @COPCAR_13961 
jump @COPCAR_13968 

:COPCAR_13961
jump @COPCAR_5818 

:COPCAR_13968
0627: update_integer_stat 157 to " + _8227 + @" 
51@ += 1 
if or
   Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @COPCAR_14045 
34@ = Actor.CurrentCar(" + PlayerActor + @")
053F: set_car 34@ tires_vulnerability 0 
64@ = Car.Health(34@)
64@ += 100 
Car.Health(34@) = 64@

:COPCAR_14045
Car.RemoveReferences(35@)
Actor.RemoveReferences(36@)
Actor.RemoveReferences(37@)
Actor.RemoveReferences(38@)
Actor.RemoveReferences(39@)
Car.RemoveReferences(40@)
Actor.RemoveReferences(41@)
Actor.RemoveReferences(42@)
Actor.RemoveReferences(43@)
Actor.RemoveReferences(44@)
Car.RemoveReferences(45@)
Actor.RemoveReferences(46@)
Actor.RemoveReferences(47@)
Actor.RemoveReferences(48@)
Actor.RemoveReferences(49@)
Marker.Disable(92@)
Marker.Disable(93@)
Marker.Disable(94@)
Marker.Disable(95@)
Marker.Disable(96@)
Marker.Disable(97@)
Marker.Disable(98@)
Marker.Disable(99@)
Marker.Disable(100@)
Marker.Disable(101@)
Marker.Disable(102@)
Marker.Disable(103@)
0632: release_group 274@ 
0632: release_group 275@ 
0632: release_group 276@ 
0085: 54@ = 51@ 
006A: 54@ *= 51@ 
54@ *= 50 
09EE: set_status_text_stay_on_screen 1 
01E3: show_text_1number_styled GXT 'C_PASS' number 54@ time 5000 style 5  
Player.Money(" + PlayerChar + @") += 54@
if 
  " + Mission_Vigilante_Passed + @" == 0 
else_jump @COPCAR_14324 
if 
  51@ == 12 
else_jump @COPCAR_14324 
03E5: show_text_box 'C_COMP1'  
// NEW BONUSES:
" + Cop_Uniform_Available + @" = 1
08DE: lose_stuff_after_busted 0
//
055F: set_player " + PlayerChar + @" max_armour += 50 
Actor.AddArmour(" + PlayerActor + @", 150)
0595: mission_complete 
0394: play_music 2 
" + Mission_Vigilante_Passed + @" = 1 

:COPCAR_14324
if and
   not Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @COPCAR_14674 
if 
  57@ == 0 
else_jump @COPCAR_14424 
01BD: 53@ = current_time_in_ms 
if 
  " + _8222 + @" > 60000 
else_jump @COPCAR_14409 
56@ = 60000 
jump @COPCAR_14417 

:COPCAR_14409
008B: 56@ = " + _8222 + @" 

:COPCAR_14417
57@ = 1 

:COPCAR_14424
01BD: 59@ = current_time_in_ms 
0085: 60@ = 59@ 
0062: 60@ -= 53@ 
0062: 56@ -= 60@ 
0085: 53@ = 59@ 
0085: 61@ = 56@ 
61@ /= 1000 
if 
  1 > 61@ 
else_jump @COPCAR_14558 
61@ = 0 
if 
001D:   59@ > 91@ 
else_jump @COPCAR_14551 
00BC: show_text_highpriority GXT 'C_TIME' time 3000 flag 1  
58@ = 1 
jump @COPCAR_14804 

:COPCAR_14551
jump @COPCAR_14574 

:COPCAR_14558
0085: 91@ = 59@ 
91@ += 1000 

:COPCAR_14574
if 
  61@ > -1 
else_jump @COPCAR_14663 
if 
  61@ == 1 
else_jump @COPCAR_14640 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'COPCA_T' number 61@ time 200 flag 1  
jump @COPCAR_14663 

:COPCAR_14640
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'COPCART' number 61@ time 200 flag 1  

:COPCAR_14663
wait 0 
jump @COPCAR_14324 

:COPCAR_14674
0396: pause_timer 1 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @COPCAR_14733 
34@ = Actor.CurrentCar(" + PlayerActor + @")
053F: set_car 34@ tires_vulnerability 0 
64@ = Car.Health(34@)
64@ += 200 
Car.Health(34@) = 64@

:COPCAR_14733
if 
  13 > 51@ 
else_jump @COPCAR_14797 
143@ -= 0.075 
if 
  0.0 > 143@ 
else_jump @COPCAR_14792 
143@ = 0.0 

:COPCAR_14792
03C7: set_sensitivity_to_crime 143@ 

:COPCAR_14797
jump @COPCAR_1291 

:COPCAR_14804
return 

:COPCAR_14806
" + OnMission + @" = 0 
Marker.Disable(92@)
Marker.Disable(93@)
Marker.Disable(94@)
Marker.Disable(95@)
Marker.Disable(96@)
Marker.Disable(97@)
Marker.Disable(98@)
Marker.Disable(99@)
Marker.Disable(100@)
Marker.Disable(101@)
Marker.Disable(102@)
Marker.Disable(103@)
0632: release_group 274@ 
0632: release_group 275@ 
0632: release_group 276@ 
014F: stop_timer " + _8222 + @" 
0151: remove_status_text " + _8227 + @" 
0151: remove_status_text " + _8223 + @" 
Model.Destroy(90@)
Model.Destroy(271@)
Model.Destroy(#COLT45)
Model.Destroy(#MICRO_UZI)
Model.Destroy(#AK47)
Model.Destroy(#CHROMEGUN)
Model.Destroy(#BAT)
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
mission_cleanup 
return 

:COPCAR_14947
if 
  51@ == 0 
else_jump @COPCAR_15015 
0209: 159@ = random_int_in_ranges 0 91 
if and
  159@ > 7 
  17 > 159@ 
else_jump @COPCAR_15008 
0209: 159@ = random_int_in_ranges 0 91 

:COPCAR_15008
jump @COPCAR_15092 

:COPCAR_15015
if 
  51@ == 1 
else_jump @COPCAR_15083 
0209: 159@ = random_int_in_ranges 2 91 
if and
  159@ > 7 
  17 > 159@ 
else_jump @COPCAR_15076 
0209: 159@ = random_int_in_ranges 2 91 

:COPCAR_15076
jump @COPCAR_15092 

:COPCAR_15083
0209: 159@ = random_int_in_ranges 67 91 

:COPCAR_15092
0085: 90@ = 176@(159@,91i) 
Model.Load(90@)
return 

:COPCAR_15111
if 
  158@ == -1 
else_jump @COPCAR_15150 
Actor.StorePos(" + PlayerActor + @", 122@, 123@, 120@)
jump @COPCAR_15164 

:COPCAR_15150
Car.StorePos(158@, 122@, 123@, 120@)

:COPCAR_15164
Car.StorePos(157@, 118@, 119@, 120@)
0087: 120@ = 118@ 
0063: 120@ -= 122@ 
0087: 121@ = 119@ 
0063: 121@ -= 123@ 
006B: 120@ *= 120@ 
006B: 121@ *= 121@ 
005B: 120@ += 121@ 
01FB: 120@ = square_root 120@ 
0087: 124@ = 120@ 
124@ += 3.0 
if 
  124@ > 100.0 
else_jump @COPCAR_15291 
124@ = 100.0 

:COPCAR_15291
if 
  0.0 > 124@ 
else_jump @COPCAR_15322 
124@ = 0.0 

:COPCAR_15322
return 

:COPCAR_15324
if 
   not Actor.Dead(156@)
else_jump @COPCAR_16112 
Actor.StorePos(156@, " + _111 + @", " + _112 + @", " + _113 + @")
if 
  " + tempvar_Angle + @" == 919.9 
else_jump @COPCAR_15392 
" + tempvar_Actor_Car + @" = Car.Create(90@, " + _111 + @", " + _112 + @", " + _113 + @")

:COPCAR_15392
if 
00F2:   actor " + PlayerActor + @" near_actor 156@ radius 40.0 40.0 0 
else_jump @COPCAR_15797 
0086: " + _114 + @" = " + _111 + @" 
" + _114 + @" += 40.0 
0086: " + _115 + @" = " + _112 + @" 
" + _115 + @" += 40.0 
" + _111 + @" -= 40.0 
" + _112 + @" -= 40.0 
Car.RemoveReferences(" + tempvar_Actor_Car + @")
" + tempvar_Actor_Car + @" = -1 
0327: " + tempvar_Actor_Car + @" = get_random_car_with_model -1 in_rectangle_cornerA " + _111 + @" " + _112 + @" cornerB " + _114 + @" " + _115 + @" 
if or
  " + tempvar_Actor_Car + @" == -1 
07D6:   35@ == " + tempvar_Actor_Car + @" 
else_jump @COPCAR_15580 
062E: get_actor 156@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_15573 
05E2: AS_actor 156@ kill_actor " + PlayerActor + @" 

:COPCAR_15573
jump @COPCAR_15790 

:COPCAR_15580
if 
0185:   car " + tempvar_Actor_Car + @" health >= 400 
else_jump @COPCAR_15741 
046D: 55@ = actor 156@ members_in_group 
01EA: 160@ = car " + tempvar_Actor_Car + @" max_passengers 
if 
801D:   not  55@ > 160@ 
else_jump @COPCAR_15697 
062E: get_actor 156@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_15690 
Car.DoorStatus(" + tempvar_Actor_Car + @") = 1
Car.SetMaxSpeed(" + tempvar_Actor_Car + @", 0.0)
05CB: AS_actor 156@ enter_car " + tempvar_Actor_Car + @" as_driver -2 ms 

:COPCAR_15690
jump @COPCAR_15734 

:COPCAR_15697
062E: get_actor 156@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_15734 
05E2: AS_actor 156@ kill_actor " + PlayerActor + @" 

:COPCAR_15734
jump @COPCAR_15790 

:COPCAR_15741
062E: get_actor 156@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_15778 
05E2: AS_actor 156@ kill_actor " + PlayerActor + @" 

:COPCAR_15778
Car.RemoveReferences(" + tempvar_Actor_Car + @")
" + tempvar_Actor_Car + @" = -1 

:COPCAR_15790
jump @COPCAR_16112 

:COPCAR_15797
03D3: get_route_nearest_for " + _111 + @" " + _112 + @" " + _113 + @" store_to " + _111 + @" " + _112 + @" " + _113 + @" Z_angle_to " + tempvar_Angle + @" 
if 
80C2:   not sphere_onscreen " + _111 + @" " + _112 + @" " + _113 + @" radius 3.0 
else_jump @COPCAR_16112 
if 
838A:   not any_car_in_cube_cornerA " + _111 + @" " + _112 + @" " + _113 + @" cornerB 3.0 3.0 2.0 
else_jump @COPCAR_16003 
if 
   Model.Available(90@)
else_jump @COPCAR_15996 
062E: get_actor 156@ task 1483 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_15996 
Car.RemoveReferences(" + tempvar_Actor_Car + @")
" + tempvar_Actor_Car + @" = Car.Create(90@, " + _111 + @", " + _112 + @", " + _113 + @")
if 
0185:   car " + tempvar_Actor_Car + @" health >= 800 
else_jump @COPCAR_15978 
Car.Health(" + tempvar_Actor_Car + @") = 800

:COPCAR_15978
Car.Angle(" + tempvar_Actor_Car + @") = " + tempvar_Angle + @"
05CB: AS_actor 156@ enter_car " + tempvar_Actor_Car + @" as_driver -2 ms 

:COPCAR_15996
jump @COPCAR_16112 

:COPCAR_16003
if 
00FF:   actor 156@ sphere 0 in_sphere " + _111 + @" " + _112 + @" " + _113 + @" radius 3.0 3.0 2.0 on_foot 
else_jump @COPCAR_16112 
062E: get_actor 156@ task 1491 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_16112 
02C0: store_to " + _111 + @" " + _112 + @" " + _113 + @" ped_path_coords_closest_to " + _111 + @" " + _112 + @" " + _113 + @" 
05D3: AS_actor 156@ goto_point " + _111 + @" " + _112 + @" " + _113 + @" mode 6 time -2 ms 

:COPCAR_16112
return 

:COPCAR_16114
01BD: 161@ = current_time_in_ms 
077E: get_active_interior_to " + _3396 + @" 
if 
  " + _3396 + @" == 0 
else_jump @COPCAR_16738 
if 
   not Car.Wrecked(153@)
else_jump @COPCAR_16738 
if and
01F4:   car 153@ flipped 
01C1:   car 153@ stopped 
else_jump @COPCAR_16340 
52@ = 1 
if 
0202:   actor " + PlayerActor + @" near_car 153@ radius 90.0 90.0 sphere 0 
else_jump @COPCAR_16238 
03ED: set_car 153@ disable_flipped_explosion_when_empty 0 
154@ = -9 
jump @COPCAR_16340 

:COPCAR_16238
if 
82CA:   not car 153@ bounding_sphere_visible 
else_jump @COPCAR_16340 
Car.StorePos(153@, " + _116 + @", " + _117 + @", " + _118 + @")
03D3: get_route_nearest_for " + _116 + @" " + _117 + @" " + _118 + @" store_to " + _116 + @" " + _117 + @" " + _118 + @" Z_angle_to " + tempvar_Angle + @" 
if 
80C2:   not sphere_onscreen " + _116 + @" " + _117 + @" " + _118 + @" radius 4.0 
else_jump @COPCAR_16340 
Car.PutAt(153@, " + _116 + @", " + _117 + @", " + _118 + @")
Car.Angle(153@) = " + tempvar_Angle + @"

:COPCAR_16340
if 
01AF:   car 153@ sphere 0 in_sphere 150@ 151@ 152@ radius 4.0 4.0 4.0 
else_jump @COPCAR_16675 
if 
  154@ == 0 
else_jump @COPCAR_16415 
0085: 155@ = 161@ 
154@ = 1 

:COPCAR_16415
0062: 161@ -= 155@ 
if 
  154@ == 1 
else_jump @COPCAR_16675 
if 
  161@ > 8000 
else_jump @COPCAR_16675 
if 
0202:   actor " + PlayerActor + @" near_car 153@ radius 90.0 90.0 sphere 0 
else_jump @COPCAR_16517 
03ED: set_car 153@ disable_flipped_explosion_when_empty 0 
01BD: 155@ = current_time_in_ms 
154@ = -9 
jump @COPCAR_16675 

:COPCAR_16517
if 
82CA:   not car 153@ bounding_sphere_visible 
else_jump @COPCAR_16675 
Car.StorePos(153@, " + _116 + @", " + _117 + @", " + _118 + @")
03D3: get_route_nearest_for " + _116 + @" " + _117 + @" " + _118 + @" store_to " + _116 + @" " + _117 + @" " + _118 + @" Z_angle_to " + tempvar_Angle + @" 
if 
838A:   not any_car_in_cube_cornerA " + _116 + @" " + _117 + @" " + _118 + @" cornerB 4.0 4.0 4.0 
else_jump @COPCAR_16675 
if 
80C2:   not sphere_onscreen " + _116 + @" " + _117 + @" " + _118 + @" radius 4.0 
else_jump @COPCAR_16675 
Car.PutAt(153@, " + _116 + @", " + _117 + @", " + _118 + @")
Car.Angle(153@) = " + tempvar_Angle + @"
01BD: 155@ = current_time_in_ms 
154@ = 0 
52@ = 1 

:COPCAR_16675
if 
81AF:   not car 153@ sphere 0 in_sphere 150@ 151@ 152@ radius 4.0 4.0 4.0 
else_jump @COPCAR_16738 
Car.StorePos(153@, 150@, 151@, 152@)
154@ = 0 

:COPCAR_16738
return 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
return 
return 
return 

:COPCAR_16751
if 
   not Actor.Dead(36@)
else_jump @COPCAR_17194 
if 
07FD:   group 274@ alive 
else_jump @COPCAR_17194 
if 
   not Actor.Dead(37@)
else_jump @COPCAR_16908 
if 
86EE:   not actor 37@ in_group 274@ 
else_jump @COPCAR_16901 
if 
00F2:   actor 37@ near_actor 36@ radius 30.0 30.0 0 
else_jump @COPCAR_16864 
0631: put_actor 37@ in_group 274@ 
jump @COPCAR_16901 

:COPCAR_16864
062E: get_actor 37@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_16901 
05E2: AS_actor 37@ kill_actor " + PlayerActor + @" 

:COPCAR_16901
jump @COPCAR_16920 

:COPCAR_16908
Actor.RemoveReferences(37@)
37@ = -1 

:COPCAR_16920
if 
   not Actor.Dead(38@)
else_jump @COPCAR_17045 
if 
86EE:   not actor 38@ in_group 274@ 
else_jump @COPCAR_17038 
if 
00F2:   actor 38@ near_actor 36@ radius 30.0 30.0 0 
else_jump @COPCAR_17001 
0631: put_actor 38@ in_group 274@ 
jump @COPCAR_17038 

:COPCAR_17001
062E: get_actor 38@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17038 
05E2: AS_actor 38@ kill_actor " + PlayerActor + @" 

:COPCAR_17038
jump @COPCAR_17057 

:COPCAR_17045
Actor.RemoveReferences(38@)
38@ = -1 

:COPCAR_17057
if 
   not Actor.Dead(39@)
else_jump @COPCAR_17182 
if 
86EE:   not actor 39@ in_group 274@ 
else_jump @COPCAR_17175 
if 
00F2:   actor 39@ near_actor 36@ radius 30.0 30.0 0 
else_jump @COPCAR_17138 
0631: put_actor 39@ in_group 274@ 
jump @COPCAR_17175 

:COPCAR_17138
062E: get_actor 39@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17175 
05E2: AS_actor 39@ kill_actor " + PlayerActor + @" 

:COPCAR_17175
jump @COPCAR_17194 

:COPCAR_17182
Actor.RemoveReferences(39@)
39@ = -1 

:COPCAR_17194
return 

:COPCAR_17196
if 
   not Actor.Dead(41@)
else_jump @COPCAR_17639 
if 
07FD:   group 275@ alive 
else_jump @COPCAR_17639 
if 
   not Actor.Dead(42@)
else_jump @COPCAR_17353 
if 
86EE:   not actor 42@ in_group 275@ 
else_jump @COPCAR_17346 
if 
00F2:   actor 42@ near_actor 41@ radius 30.0 30.0 0 
else_jump @COPCAR_17309 
0631: put_actor 42@ in_group 275@ 
jump @COPCAR_17346 

:COPCAR_17309
062E: get_actor 42@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17346 
05E2: AS_actor 42@ kill_actor " + PlayerActor + @" 

:COPCAR_17346
jump @COPCAR_17365 

:COPCAR_17353
Actor.RemoveReferences(42@)
42@ = -1 

:COPCAR_17365
if 
   not Actor.Dead(43@)
else_jump @COPCAR_17490 
if 
86EE:   not actor 43@ in_group 275@ 
else_jump @COPCAR_17483 
if 
00F2:   actor 43@ near_actor 41@ radius 30.0 30.0 0 
else_jump @COPCAR_17446 
0631: put_actor 43@ in_group 275@ 
jump @COPCAR_17483 

:COPCAR_17446
062E: get_actor 43@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17483 
05E2: AS_actor 43@ kill_actor " + PlayerActor + @" 

:COPCAR_17483
jump @COPCAR_17502 

:COPCAR_17490
Actor.RemoveReferences(43@)
43@ = -1 

:COPCAR_17502
if 
   not Actor.Dead(44@)
else_jump @COPCAR_17627 
if 
86EE:   not actor 44@ in_group 275@ 
else_jump @COPCAR_17620 
if 
00F2:   actor 44@ near_actor 41@ radius 30.0 30.0 0 
else_jump @COPCAR_17583 
0631: put_actor 44@ in_group 275@ 
jump @COPCAR_17620 

:COPCAR_17583
062E: get_actor 44@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17620 
05E2: AS_actor 44@ kill_actor " + PlayerActor + @" 

:COPCAR_17620
jump @COPCAR_17639 

:COPCAR_17627
Actor.RemoveReferences(44@)
44@ = -1 

:COPCAR_17639
return 

:COPCAR_17641
if 
   not Actor.Dead(46@)
else_jump @COPCAR_18084 
if 
07FD:   group 276@ alive 
else_jump @COPCAR_18084 
if 
   not Actor.Dead(47@)
else_jump @COPCAR_17798 
if 
86EE:   not actor 47@ in_group 276@ 
else_jump @COPCAR_17791 
if 
00F2:   actor 47@ near_actor 46@ radius 30.0 30.0 0 
else_jump @COPCAR_17754 
0631: put_actor 47@ in_group 276@ 
jump @COPCAR_17791 

:COPCAR_17754
062E: get_actor 47@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17791 
05E2: AS_actor 47@ kill_actor " + PlayerActor + @" 

:COPCAR_17791
jump @COPCAR_17810 

:COPCAR_17798
Actor.RemoveReferences(47@)
47@ = -1 

:COPCAR_17810
if 
   not Actor.Dead(48@)
else_jump @COPCAR_17935 
if 
86EE:   not actor 48@ in_group 276@ 
else_jump @COPCAR_17928 
if 
00F2:   actor 48@ near_actor 46@ radius 30.0 30.0 0 
else_jump @COPCAR_17891 
0631: put_actor 48@ in_group 276@ 
jump @COPCAR_17928 

:COPCAR_17891
062E: get_actor 48@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_17928 
05E2: AS_actor 48@ kill_actor " + PlayerActor + @" 

:COPCAR_17928
jump @COPCAR_17947 

:COPCAR_17935
Actor.RemoveReferences(48@)
48@ = -1 

:COPCAR_17947
if 
   not Actor.Dead(49@)
else_jump @COPCAR_18072 
if 
86EE:   not actor 49@ in_group 276@ 
else_jump @COPCAR_18065 
if 
00F2:   actor 49@ near_actor 46@ radius 30.0 30.0 0 
else_jump @COPCAR_18028 
0631: put_actor 49@ in_group 276@ 
jump @COPCAR_18065 

:COPCAR_18028
062E: get_actor 49@ task 1506 status_store_to " + _416 + @" 
if 
04A3:   " + _416 + @" == 7 
else_jump @COPCAR_18065 
05E2: AS_actor 49@ kill_actor " + PlayerActor + @" 

:COPCAR_18065
jump @COPCAR_18084 

:COPCAR_18072
Actor.RemoveReferences(49@)
49@ = -1 

:COPCAR_18084
return 

:COPCAR_18086
060B: set_actor 50@ decision_maker_to 267@ 
0433: set_actor 50@ criminal_flag 1 
02A9: set_actor 50@ immune_to_nonplayer 1 
0982: set_actor 50@ stay_in_car_when_dead 1 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 0 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 4 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 5 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 6 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 7 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 8 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 14 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 9 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 11 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 13 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 12 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 17 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 18 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 19 
077A: set_actor 50@ acquaintance 4 to_actors_pedtype 21 
if 
  51@ == 0 
else_jump @COPCAR_18277 
0209: 159@ = random_int_in_ranges 0 2 

:COPCAR_18277
if 
  51@ > 1 
else_jump @COPCAR_18304 
0209: 159@ = random_int_in_ranges 0 3 

:COPCAR_18304
if 
  51@ > 4 
else_jump @COPCAR_18331 
0209: 159@ = random_int_in_ranges 0 4 

:COPCAR_18331
if 
  51@ > 6 
else_jump @COPCAR_18358 
0209: 159@ = random_int_in_ranges 0 5 

:COPCAR_18358
if 
  51@ > 8 
else_jump @COPCAR_18385 
0209: 159@ = random_int_in_ranges 0 6 

:COPCAR_18385
if 
  159@ == 0 
else_jump @COPCAR_18468 
0209: 159@ = random_int_in_ranges 10 13 
if 
  159@ == 10 
else_jump @COPCAR_18440 
Actor.GiveWeaponAndAmmo(50@, BaseballBat, 9999)

:COPCAR_18440
if 
  159@ == 11 
else_jump @COPCAR_18468 
Actor.GiveWeaponAndAmmo(50@, BaseballBat, 9999)

:COPCAR_18468
if 
  159@ == 1 
else_jump @COPCAR_18496 
Actor.GiveWeaponAndAmmo(50@, Pistol, 9999)

:COPCAR_18496
if 
  159@ == 2 
else_jump @COPCAR_18524 
Actor.GiveWeaponAndAmmo(50@, MicroUzi, 9999)

:COPCAR_18524
if 
  159@ == 3 
else_jump @COPCAR_18552 
Actor.GiveWeaponAndAmmo(50@, AK47, 9999)

:COPCAR_18552
if or
  159@ == 4 
  159@ == 5 
else_jump @COPCAR_18587 
Actor.GiveWeaponAndAmmo(50@, Shotgun, 9999)

:COPCAR_18587
return 

:COPCAR_18589
if 
   not " + _8222 + @" == -100 
else_jump @COPCAR_18666 
if 
  1 > " + _8222 + @" 
else_jump @COPCAR_18666 
58@ = 1 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
00BC: show_text_highpriority GXT 'C_TIME' time 3000 flag 1  
return 

:COPCAR_18666
if and
   not Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @COPCAR_19004 
0396: pause_timer 0 
if 
  57@ == 0 
else_jump @COPCAR_18770 
01BD: 53@ = current_time_in_ms 
if 
  " + _8222 + @" > 60000 
else_jump @COPCAR_18755 
56@ = 60000 
jump @COPCAR_18763 

:COPCAR_18755
008B: 56@ = " + _8222 + @" 

:COPCAR_18763
57@ = 1 

:COPCAR_18770
01BD: 59@ = current_time_in_ms 
0085: 60@ = 59@ 
0062: 60@ -= 53@ 
0062: 56@ -= 60@ 
0085: 53@ = 59@ 
0085: 61@ = 56@ 
61@ /= 1000 
if 
  1 > 61@ 
else_jump @COPCAR_18899 
61@ = 0 
if 
001D:   59@ > 91@ 
else_jump @COPCAR_18892 
00BC: show_text_highpriority GXT 'C_TIME' time 3000 flag 1  
58@ = 1 
return 

:COPCAR_18892
jump @COPCAR_18915 

:COPCAR_18899
0085: 91@ = 59@ 
91@ += 1000 

:COPCAR_18915
if 
  61@ > -1 
else_jump @COPCAR_19004 
if 
  61@ == 1 
else_jump @COPCAR_18981 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'COPCA_T' number 61@ time 200 flag 1  
jump @COPCAR_19004 

:COPCAR_18981
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'COPCART' number 61@ time 200 flag 1  

:COPCAR_19004
0293: " + _13 + @" = get_controller_mode 
if or
   Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @COPCAR_19228 
34@ = Actor.CurrentCar(" + PlayerActor + @")
053F: set_car 34@ tires_vulnerability 0 
if 
   not " + _13 + @" == 3 
else_jump @COPCAR_19147 
if 
00E1:   player 0 pressed_key 19 
else_jump @COPCAR_19115 
if 
  62@ == 1 
else_jump @COPCAR_19108 
62@ = 2 

:COPCAR_19108
jump @COPCAR_19140 

:COPCAR_19115
if 
  62@ == 0 
else_jump @COPCAR_19140 
62@ = 1 

:COPCAR_19140
jump @COPCAR_19221 

:COPCAR_19147
if 
00E1:   player 0 pressed_key 14 
else_jump @COPCAR_19196 
if 
  62@ == 1 
else_jump @COPCAR_19189 
62@ = 2 

:COPCAR_19189
jump @COPCAR_19221 

:COPCAR_19196
if 
  62@ == 0 
else_jump @COPCAR_19221 
62@ = 1 

:COPCAR_19221
57@ = 0 

:COPCAR_19228
if 
  62@ == 2 
else_jump @COPCAR_19355 
if 
   not " + _13 + @" == 3 
else_jump @COPCAR_19313 
if 
80E1:   not player 0 pressed_key 19 
else_jump @COPCAR_19306 
00BC: show_text_highpriority GXT 'C_CANC' time 3000 flag 1  
58@ = 1 
return 

:COPCAR_19306
jump @COPCAR_19355 

:COPCAR_19313
if 
80E1:   not player 0 pressed_key 14 
else_jump @COPCAR_19355 
00BC: show_text_highpriority GXT 'C_CANC' time 3000 flag 1  
58@ = 1 
return 

:COPCAR_19355
return" );
            }

        }

    }

}