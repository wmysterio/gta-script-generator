﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class MTBIKER : MissionCustom {

            Int tmp_1807 = global( _1807.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @MTBIKER_36 
if 
wasted_or_busted 
else_jump @MTBIKER_27 
gosub @MTBIKER_14393 

:MTBIKER_27
gosub @MTBIKER_14690 
end_thread 

:MTBIKER_36
" + OnMission + @" = 1 
0A0E: disable_text_with_style 1 
if 
  " + Mission_Chiliad_Challenge_Passed + @" == 0 
else_jump @MTBIKER_67 
increment_mission_attempts 

:MTBIKER_67
054C: use_GXT_table 'RACETOR' 
0912: set_text_priority 1 leftmargin 355 maxwidth 370 
wait 0 
03F0: enable_text_draw 1 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @MTBIKER_130 
Player.CanMove(" + PlayerChar + @") = False

:MTBIKER_130
fade 0 1000 

:MTBIKER_137
if 
fading 
else_jump @MTBIKER_161 
wait 0 
jump @MTBIKER_137 

:MTBIKER_161
060A: create_decision_maker_type 0 store_to 669@ 
647@ = 0 

:MTBIKER_175
if 
  9 > 647@ 
else_jump @MTBIKER_229 
690@(647@,10i) = 0 
670@(647@,10i) = 0 
647@ += 1 
jump @MTBIKER_175 

:MTBIKER_229
656@ = 0 
657@ = 0 
34@ = 582.7242 
41@ = 356.2812 
48@ = 52.2072 
55@ = 52.2072 
35@ = 584.0833 
42@ = 329.3647 
49@ = 0.5427 
56@ = 2.0841 
36@ = 572.9216 
43@ = 323.5937 
50@ = 1.0585 
57@ = 4.8106 
37@ = 585.724 
44@ = 345.6341 
51@ = 0.4929 
58@ = 1.8511 
38@ = 582.7242 
45@ = 359.0323 
52@ = 0.4993 
59@ = 2.637 
39@ = 582.7242 
46@ = 356.2812 
53@ = 56.2072 
60@ = 56.2072 
40@ = 582.7242 
47@ = 356.2812 
54@ = 58.2072 
61@ = 58.2072 
Player.SetClothes(" + PlayerChar + @", ""BBSHORTWHT"", ""BOXINGSHORT"", Legs)
Player.Build(" + PlayerChar + @")
if 
  " + _1799 + @" == 1 
else_jump @MTBIKER_585 
jump @MTBIKER_635 

:MTBIKER_585
if 
  " + _1799 + @" == 2 
else_jump @MTBIKER_610 
jump @MTBIKER_1570 

:MTBIKER_610
if 
  " + _1799 + @" == 3 
else_jump @MTBIKER_635 
jump @MTBIKER_3025 

:MTBIKER_635
if 
  " + _1799 + @" == 1 
else_jump @MTBIKER_669 
00BA: show_text_styled GXT 'MTROUT1' time 3000 style 5  

:MTBIKER_669
103@ = -2304.344 
223@ = -1667.125 
343@ = 483.386 
463@ = 208.0 
104@ = -2280.48 
224@ = -1730.315 
344@ = 467.8242 
464@ = 178.6093 
105@ = -2357.182 
225@ = -1815.429 
345@ = 431.4012 
465@ = 64.067 
106@ = -2447.403 
226@ = -1718.435 
346@ = 430.9626 
466@ = 148.4592 
107@ = -2446.652 
227@ = -1810.658 
347@ = 409.0582 
467@ = 93.195 
108@ = -2527.586 
228@ = -1711.376 
348@ = 401.175 
468@ = 16.0889 
109@ = -2552.845 
229@ = -1668.842 
349@ = 398.455 
469@ = 155.2717 
110@ = -2534.517 
230@ = -1802.53 
350@ = 374.7244 
470@ = 127.1514 
111@ = -2595.25 
231@ = -1631.995 
351@ = 342.7061 
471@ = 176.454 
112@ = -2526.43 
232@ = -1888.459 
352@ = 292.5149 
472@ = 77.3269 
113@ = -2652.859 
233@ = -1739.147 
353@ = 255.1567 
473@ = 189.6474 
114@ = -2491.229 
234@ = -2034.597 
354@ = 150.1413 
474@ = 225.1505 
115@ = -2428.644 
235@ = -2088.887 
355@ = 121.97 
475@ = 243.2365 
116@ = -2322.059 
236@ = -2097.64 
356@ = 114.0331 
476@ = 292.4177 
117@ = -2218.131 
237@ = -2047.089 
357@ = 118.8139 
477@ = 315.497 
118@ = -2168.42 
238@ = -1991.872 
358@ = 117.8448 
478@ = 314.2462 
119@ = -2102.545 
239@ = -1895.227 
359@ = 108.4655 
479@ = 174.3973 
120@ = -2162.365 
240@ = -2039.522 
360@ = 91.2074 
480@ = 135.1339 
121@ = -2373.667 
241@ = -2195.089 
361@ = 32.3837 
481@ = 112.827 
700@ = 19 
92@ = 6 
04AF: 701@ = 23 
04AF: 702@ = 52 
04AF: 703@ = 51 
04AF: 704@ = 52 
04AF: 705@ = 23 
04AF: 706@ = 51 
04AF: 707@ = 510 
04AF: 708@ = 510 
04AF: 709@ = 510 
04AF: 710@ = 510 
04AF: 711@ = 510 
04AF: 712@ = 510 
652@ = 38.0 
653@ = 27.0 
654@ = 23.0 
jump @MTBIKER_4244 

:MTBIKER_1570
if 
  " + _1799 + @" == 2 
else_jump @MTBIKER_1604 
00BA: show_text_styled GXT 'MTROUT2' time 3000 style 5  

:MTBIKER_1604
103@ = -2304.344 
223@ = -1667.125 
343@ = 483.586 
463@ = 208.0 
104@ = -2279.857 
224@ = -1732.752 
344@ = 466.799 
464@ = 163.4517 
105@ = -2355.609 
225@ = -1815.324 
345@ = 431.5401 
465@ = 90.1409 
106@ = -2458.843 
226@ = -1733.434 
346@ = 426.432 
466@ = 187.8666 
107@ = -2460.904 
227@ = -1807.384 
347@ = 406.6599 
467@ = 60.8579 
108@ = -2521.292 
228@ = -1707.753 
348@ = 401.2728 
468@ = 2.4494 
109@ = -2467.126 
229@ = -1467.868 
349@ = 388.9202 
469@ = 270.5872 
110@ = -2324.367 
230@ = -1455.149 
350@ = 380.9767 
470@ = 233.5233 
111@ = -2251.922 
231@ = -1492.653 
351@ = 377.8563 
471@ = 196.094 
112@ = -2191.949 
232@ = -1713.993 
352@ = 375.5497 
472@ = 322.9377 
113@ = -2206.778 
233@ = -1528.34 
353@ = 359.6156 
473@ = 20.0752 
114@ = -2280.683 
234@ = -1426.188 
354@ = 355.6379 
474@ = 58.5606 
115@ = -2419.222 
235@ = -1392.925 
355@ = 358.1968 
475@ = 98.4498 
116@ = -2569.767 
236@ = -1460.698 
356@ = 357.2175 
476@ = 325.2711 
117@ = -2440.889 
237@ = -1368.257 
357@ = 337.413 
477@ = 304.5745 
118@ = -2357.07 
238@ = -1286.362 
358@ = 306.1062 
478@ = 103.378 
119@ = -2508.153 
239@ = -1273.621 
359@ = 271.7476 
479@ = 103.6739 
120@ = -2595.492 
240@ = -1360.244 
360@ = 264.5467 
480@ = 100.454 
121@ = -2671.155 
241@ = -1378.19 
361@ = 252.3816 
481@ = 352.7671 
122@ = -2608.5 
242@ = -1285.22 
362@ = 219.88 
482@ = 335.6836 
123@ = -2537.294 
243@ = -1121.297 
363@ = 175.3035 
483@ = 140.5565 
124@ = -2634.553 
244@ = -1169.384 
364@ = 166.8249 
484@ = 128.43 
125@ = -2747.937 
245@ = -1377.943 
365@ = 143.0419 
485@ = 168.2364 
126@ = -2773.78 
246@ = -1670.301 
366@ = 140.4944 
486@ = 169.7697 
127@ = -2733.364 
247@ = -1876.022 
367@ = 138.8912 
487@ = 269.3722 
128@ = -2620.579 
248@ = -2066.746 
368@ = 129.5185 
488@ = 201.5526 
129@ = -2438.379 
249@ = -2086.928 
369@ = 123.3899 
489@ = 257.1008 
130@ = -2335.784 
250@ = -2102.442 
370@ = 112.9194 
490@ = 283.7088 
131@ = -2101.005 
251@ = -1893.245 
371@ = 108.8372 
491@ = 174.9563 
132@ = -2156.216 
252@ = -2031.774 
372@ = 91.9901 
492@ = 145.72 
133@ = -2236.111 
253@ = -2118.767 
373@ = 66.3876 
493@ = 131.2891 
134@ = -2374.958 
254@ = -2195.454 
374@ = 32.3626 
494@ = 113.8008 
700@ = 32 
92@ = 6 
04AF: 701@ = 23 
04AF: 702@ = 52 
04AF: 703@ = 51 
04AF: 704@ = 52 
04AF: 705@ = 23 
04AF: 706@ = 51 
04AF: 707@ = 510 
04AF: 708@ = 510 
04AF: 709@ = 510 
04AF: 710@ = 510 
04AF: 711@ = 510 
04AF: 712@ = 510 
652@ = 35.0 
653@ = 30.0 
654@ = 28.0 
jump @MTBIKER_4244 

:MTBIKER_3025
if 
  " + _1799 + @" == 3 
else_jump @MTBIKER_3059 
00BA: show_text_styled GXT 'MTROUT3' time 3000 style 5  

:MTBIKER_3059
103@ = -2432.876 
223@ = -1939.654 
343@ = 303.7731 
463@ = 273.0 
104@ = -2339.998 
224@ = -1941.224 
344@ = 295.8086 
464@ = 269.6869 
105@ = -2286.782 
225@ = -1940.24 
345@ = 268.8093 
465@ = 245.1214 
106@ = -2234.891 
226@ = -1925.067 
346@ = 242.4752 
466@ = 300.1313 
107@ = -2205.429 
227@ = -1914.029 
347@ = 239.2782 
467@ = 269.1174 
108@ = -2204.861 
228@ = -1914.031 
348@ = 239.1954 
468@ = 269.4709 
109@ = -2173.895 
229@ = -1903.88 
349@ = 233.6897 
469@ = 314.003 
110@ = -2169.728 
230@ = -1885.136 
350@ = 231.1551 
470@ = 8.2283 
111@ = -2173.511 
231@ = -1861.948 
351@ = 222.7416 
471@ = 13.9626 
112@ = -2173.641 
232@ = -1843.246 
352@ = 217.9074 
472@ = 13.6434 
113@ = -2148.431 
233@ = -1792.73 
353@ = 210.1444 
473@ = 294.9009 
114@ = -2129.241 
234@ = -1775.973 
354@ = 207.5088 
474@ = 313.3039 
115@ = -2109.724 
235@ = -1755.573 
355@ = 195.2899 
475@ = 332.9617 
116@ = -2101.756 
236@ = -1744.009 
356@ = 195.9091 
476@ = 324.6714 
117@ = -2072.08 
237@ = -1644.9 
357@ = 174.3308 
477@ = 357.332 
118@ = -2050.7 
238@ = -1571.491 
358@ = 137.474 
478@ = 272.8463 
119@ = -2041.665 
239@ = -1509.007 
359@ = 124.2398 
479@ = 16.1558 
120@ = -2033.56 
240@ = -1438.604 
360@ = 93.2658 
480@ = 210.8019 
121@ = -1991.328 
241@ = -1596.526 
361@ = 86.5936 
481@ = 182.1263 
122@ = -2027.707 
242@ = -1789.331 
362@ = 96.554 
482@ = 160.6694 
123@ = -2099.854 
243@ = -1890.88 
363@ = 109.2095 
483@ = 175.6702 
124@ = -2118.301 
244@ = -1948.25 
364@ = 99.0724 
484@ = 162.0987 
125@ = -2233.649 
245@ = -2117.046 
365@ = 67.2467 
485@ = 134.1193 
126@ = -2373.892 
246@ = -2194.998 
366@ = 32.3799 
486@ = 115.9183 
700@ = 24 
92@ = 3 
04AF: 701@ = 51 
04AF: 702@ = 52 
04AF: 703@ = 23 
04AF: 707@ = 510 
04AF: 708@ = 510 
04AF: 709@ = 510 
652@ = 40.0 
653@ = 30.0 
654@ = 25.0 
07C0: load_path 829 
07C0: load_path 830 
07C0: load_path 831 
07C0: load_path 832 
07C0: load_path 833 
07C0: load_path 834 

:MTBIKER_4138
if or
87C1:   not path 829 available 
87C1:   not path 830 available 
87C1:   not path 831 available 
87C1:   not path 832 available 
87C1:   not path 833 available 
87C1:   not path 834 available 
else_jump @MTBIKER_4190 
wait 0 
jump @MTBIKER_4138 

:MTBIKER_4190
06D5: 780@ = create_racing_checkpoint_at 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) point_to 777@ 778@ 779@ type 0 radius 6.0 
06D6: disable_racing_checkpoint 780@ 
jump @MTBIKER_4244 

:MTBIKER_4244
0087: 655@ = 654@ 

:MTBIKER_4252
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @MTBIKER_4279 
wait 0 
jump @MTBIKER_4252 

:MTBIKER_4279
0395: clear_area 0 at 103@ 223@ 343@ radius 0.5 
Camera.SetAtPos(103@, 223@, 343@)
0085: 713@ = 700@ 
713@ -= 1 
643@ = 0 
644@ = 0 
645@ = 0 
646@ = 0 
0085: 744@ = 92@ 

:MTBIKER_4359
if 
001D:   744@ > 644@ 
else_jump @MTBIKER_4403 
745@(644@,10i) = 0 
644@ += 1 
jump @MTBIKER_4359 

:MTBIKER_4403
018A: 755@ = create_checkpoint_at 103@ 223@ 343@ 
756@ = 0 

:MTBIKER_4424
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
758@ = 0 
644@ = 0 
if 
  756@ == 0 
else_jump @MTBIKER_4651 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @MTBIKER_4651 
Actor.PutAt(" + PlayerActor + @", 103@, 223@, 343@)
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 104@ 224@ radius 100.0 100.0 
else_jump @MTBIKER_4651 
643@ = 0 
0088: " + tempvar_Float_1 + @" = 103@ 
" + tempvar_Float_1 + @" += 7.0 
0088: " + tempvar_Float_2 + @" = 223@ 
" + tempvar_Float_2 + @" += 7.0 
0088: " + tempvar_Float_3 + @" = 343@ 
" + tempvar_Float_3 + @" += 4.0 
0087: 659@ = 103@ 
659@ -= 7.0 
0087: 660@ = 223@ 
660@ -= 7.0 
0087: 661@ = 343@ 
661@ -= 4.0 
756@ += 1 

:MTBIKER_4651
if 
  756@ == 1 
else_jump @MTBIKER_4771 
0085: 647@ = 744@ 
647@ -= 1 
if and
   Model.Available(701@(643@,6i))
   Model.Available(707@(643@,6i))
else_jump @MTBIKER_4727 
643@ += 1 
jump @MTBIKER_4745 

:MTBIKER_4727
Model.Load(701@(643@,6i))
Model.Load(707@(643@,6i))

:MTBIKER_4745
if 
003B:   643@ == 647@ 
else_jump @MTBIKER_4771 
756@ += 1 

:MTBIKER_4771
if 
  756@ == 2 
else_jump @MTBIKER_6410 
774@ = Car.Create(707@, 103@, 223@, 343@)
039F: set_car 774@ race_to 104@ 224@ 
0085: 647@ = 744@ 
647@ -= 1 
644@ = 0 

:MTBIKER_4839
if 
001D:   744@ > 644@ 
else_jump @MTBIKER_6170 
0085: 645@ = 644@ 
645@ /= 2 
645@ *= 2 
if 
003B:   645@ == 644@ 
else_jump @MTBIKER_4957 
" + tempvar_Float_1 + @" = 2.0 
0085: 646@ = 644@ 
646@ *= 4 
0093: 662@ = integer 646@ to_float 
662@ *= -3.0 
0088: " + tempvar_Float_2 + @" = 662@ 
jump @MTBIKER_5015 

:MTBIKER_4957
" + tempvar_Float_1 + @" = -2.0 
0085: 646@ = 644@ 
646@ -= 1 
646@ *= 4 
0093: 662@ = integer 646@ to_float 
662@ *= -1.2 
0088: " + tempvar_Float_2 + @" = 662@ 

:MTBIKER_5015
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
663@ = Car.Angle(774@)
0088: " + tempvar_Float_3 + @" = 343@ 
0089: 714@(644@,6f) = " + tempvar_Float_1 + @" 
0089: 720@(644@,6f) = " + tempvar_Float_2 + @" 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0089: 726@(644@,6f) = " + tempvar_Float_3 + @" 
if 
001D:   647@ > 644@ 
else_jump @MTBIKER_5409 
732@(644@,6i) = Car.Create(707@(644@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
072F: enable_car 732@(644@,6i) stuck_check_distance 0.5 time 5000 and_restore_if stuck 1 flipped 0 unk_place_on_road_properly 1 to_path 1 
0423: set_car 732@(644@,6i) improved_handling_to 1.5 
Model.Destroy(707@(644@,6i))
Car.Angle(732@(644@,6i)) = 663@
Car.SetImmunities(732@(644@,6i), 0, 1, 0, 0, 0)
039C: set_car 732@(644@,6i) watertight 1 
03AB: set_car 732@(644@,6i) strong 1 
03ED: set_car 732@(644@,6i) disable_flipped_explosion_when_empty 1 
04E0: car 732@(644@,6i) abandon_path_radius 5 
053F: set_car 732@(644@,6i) tires_vulnerability 0 
738@(644@,6i) = Actor.CreateAsDriver(CivMale, 701@(644@,6i), 732@(644@,6i))
054E: clear_actor 738@(644@,6i) damage 
Model.Destroy(701@(644@,6i))
054A: set_actor 738@(644@,6i) can_be_shot_in_a_car 0 
060B: set_actor 738@(644@,6i) decision_maker_to 669@ 
0A21: set_car 732@(644@,6i) not_affected_by_cheats 1 
Car.SetToNormalDriver(732@(644@,6i))
00AE: set_car 732@(644@,6i) traffic_behaviour_to 2 
Car.SetMaxSpeed(732@(644@,6i), 655@)
Car.ImmuneToNonPlayer(732@(644@,6i)) = True
jump @MTBIKER_6156 

:MTBIKER_5409
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset -4.0435 6.5755 -0.8 
0376: 770@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 770@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset -5.6392 2.9435 -0.8 
0376: 759@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 759@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset -6.0071 -2.0778 -0.8 
0376: 760@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 760@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset -7.6039 -5.0807 -0.8 
0376: 761@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 761@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset -7.0724 -6.4057 -0.8 
0376: 762@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 762@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset -5.9988 -13.553 -0.8 
0376: 763@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 763@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset 6.073 -15.2059 -0.8 
0376: 764@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 764@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset 7.2639 -12.9933 -0.8 
0376: 765@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 765@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset 5.8429 -7.7069 -0.8 
0376: 766@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 766@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset 8.4135 -3.7971 -0.8 
0376: 767@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 767@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset 6.2507 0.3634 -0.8 
0376: 768@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 768@ turn_to_and_look_at 103@ 223@ 343@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 774@ with_offset 8.6397 2.419 -0.8 
0376: 769@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 769@ turn_to_and_look_at 103@ 223@ 343@ 
Car.Destroy(774@)
Marker.Disable(755@)
018A: 755@ = create_checkpoint_at 714@(647@,6f) 720@(647@,6f) 726@(647@,6f) 
01EB: set_traffic_density_multiplier_to 0.5 
008B: 738@(644@,6i) = " + PlayerActor + @" 
0085: 757@ = 644@ 

:MTBIKER_6156
644@ += 1 
jump @MTBIKER_4839 

:MTBIKER_6170
756@ += 1 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @MTBIKER_6266 
732@(757@,6i) = Actor.MissionCar(" + PlayerActor + @")
Car.Health(732@(757@,6i)) = 500
054F: clear_car 732@(757@,6i) damage 
Actor.PutAt(" + PlayerActor + @", 714@(757@,6f), 720@(757@,6f), 726@(757@,6f))
Car.Angle(732@(757@,6i)) = 463@
Camera.SetBehindPlayer

:MTBIKER_6266
02A3: enable_widescreen 1 
wait 500 
fade 1 1000 
00BE: text_clear_all 

:MTBIKER_6284
if 
fading 
else_jump @MTBIKER_6308 
wait 0 
jump @MTBIKER_6284 

:MTBIKER_6308
if 
  " + _1799 + @" == 1 
else_jump @MTBIKER_6342 
00BC: show_text_highpriority GXT 'MTROUT1' time 3000 flag 6  

:MTBIKER_6342
if 
  " + _1799 + @" == 2 
else_jump @MTBIKER_6376 
00BC: show_text_highpriority GXT 'MTROUT2' time 3000 flag 6  

:MTBIKER_6376
if 
  " + _1799 + @" == 3 
else_jump @MTBIKER_6410 
00BC: show_text_highpriority GXT 'MTROUT3' time 3000 flag 6  

:MTBIKER_6410
if 
  756@ == 3 
else_jump @MTBIKER_6736 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @MTBIKER_6736 
0085: 647@ = 744@ 
647@ -= 1 
644@ = 0 

:MTBIKER_6466
if 
001D:   647@ > 644@ 
else_jump @MTBIKER_6657 
if or
   Car.Wrecked(732@(644@,6i))
   Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_6537 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @MTBIKER_14393 

:MTBIKER_6537
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_6643 
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_6643 
if or
8185:   not car 732@(644@,6i) health >= 999 
   not Actor.InCar(738@(644@,6i), 732@(644@,6i))
else_jump @MTBIKER_6643 
00BA: show_text_styled GXT 'RACES_3' time 1200 style 4 
09B9: show_entered_car_name 0 
756@ = 7 

:MTBIKER_6643
644@ += 1 
jump @MTBIKER_6466 

:MTBIKER_6657
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
00BA: show_text_styled GXT 'RACES_4' time 1100 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
008B: 771@ = " + Current_Time_in_ms2 + @" 
771@ += 999 
756@ += 1 

:MTBIKER_6736
if 
  756@ == 4 
else_jump @MTBIKER_6834 
if 
001E:   " + Current_Time_in_ms2 + @" > 771@ 
else_jump @MTBIKER_6834 
00BA: show_text_styled GXT 'RACES_5' time 1100 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
008B: 771@ = " + Current_Time_in_ms2 + @" 
771@ += 999 
756@ += 1 

:MTBIKER_6834
if 
  756@ == 5 
else_jump @MTBIKER_6932 
if 
001E:   " + Current_Time_in_ms2 + @" > 771@ 
else_jump @MTBIKER_6932 
00BA: show_text_styled GXT 'RACES_6' time 1100 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
008B: 771@ = " + Current_Time_in_ms2 + @" 
771@ += 999 
756@ += 1 

:MTBIKER_6932
if 
  756@ == 6 
else_jump @MTBIKER_7159 
if 
001E:   " + Current_Time_in_ms2 + @" > 771@ 
else_jump @MTBIKER_7159 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @MTBIKER_7159 
00BA: show_text_styled GXT 'RACES_7' time 800 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
Player.CanMove(" + PlayerChar + @") = True
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
03F4: set_all_cars_apply_damage_rules 1 
Camera.Restore
02A3: enable_widescreen 0 
09B9: show_entered_car_name 0 
008B: 651@ = " + Current_Time_in_ms2 + @" 
0085: 647@ = 744@ 
647@ -= 1 
644@ = 0 

:MTBIKER_7081
if 
001D:   647@ > 644@ 
else_jump @MTBIKER_7145 
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_7131 
Car.ImmuneToNonPlayer(732@(644@,6i)) = False

:MTBIKER_7131
644@ += 1 
jump @MTBIKER_7081 

:MTBIKER_7145
771@ = 0 
756@ += 1 

:MTBIKER_7159
if 
  756@ > 6 
else_jump @MTBIKER_12466 

:MTBIKER_7177
if 
001D:   744@ > 644@ 
else_jump @MTBIKER_11790 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @MTBIKER_11776 
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_9482 
if 
87D6:   not  738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_7348 
if 
051A:   actor 738@(644@,6i) damaged_by_actor " + PlayerActor + @" 
else_jump @MTBIKER_7348 
if 
   not Car.Wrecked(732@(757@,6i))
else_jump @MTBIKER_7348 
if 
851B:   not actor 738@(644@,6i) damaged_by_car 732@(757@,6i) 
else_jump @MTBIKER_7348 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @MTBIKER_14393 

:MTBIKER_7348
if 
  756@ == 8 
else_jump @MTBIKER_9093 
if 
87D6:   not  738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_9093 
if 
003B:   745@(757@,10i) == 745@(644@,10i) 
else_jump @MTBIKER_7531 
Actor.StorePos(738@(644@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 773@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 714@(644@,6f) 720@(644@,6f) 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 664@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 714@(644@,6f) 720@(644@,6f) 
if 
0025:   664@ > 773@ 
else_jump @MTBIKER_7524 
758@ += 1 

:MTBIKER_7524
jump @MTBIKER_7565 

:MTBIKER_7531
if 
001D:   745@(644@,10i) > 745@(757@,10i) 
else_jump @MTBIKER_7565 
758@ += 1 

:MTBIKER_7565
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_7681 
if 
80EC:   not actor 738@(644@,6i) sphere 0 near_point 62@(644@,10f) 72@(644@,10f) radius 3.0 3.0 
else_jump @MTBIKER_7681 
Actor.StorePos(738@(644@,6i), 62@(644@,10f), 72@(644@,10f), " + tempvar_Float_3 + @")
008B: 93@(644@,10i) = " + Current_Time_in_ms2 + @" 
93@(644@,10i) += 2000 

:MTBIKER_7681
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_8524 
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_7891 
if 
  670@(644@,10i) == 0 
else_jump @MTBIKER_7781 
if 
   not Actor.InCar(738@(644@,6i), 732@(644@,6i))
else_jump @MTBIKER_7781 
670@(644@,10i) = 1 

:MTBIKER_7781
if 
  670@(644@,10i) == 1 
else_jump @MTBIKER_7891 
if 
   Actor.InCar(738@(644@,6i), 732@(644@,6i))
else_jump @MTBIKER_7891 
0687: clear_actor 738@(644@,6i) task 
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 
670@(644@,10i) = 0 

:MTBIKER_7891
if 
00EC:   actor 738@(644@,6i) sphere 0 near_point 62@(644@,10f) 72@(644@,10f) radius 3.0 3.0 
else_jump @MTBIKER_8524 
if 
001E:   " + Current_Time_in_ms2 + @" > 93@(644@,10i) 
else_jump @MTBIKER_8524 
if 
82CB:   not actor 738@(644@,6i) bounding_sphere_visible 
else_jump @MTBIKER_8524 
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_8201 
if 
   not Actor.InCar(738@(644@,6i), 732@(644@,6i))
else_jump @MTBIKER_8194 
046C: 665@ = car 732@(644@,6i) driver 
if 
  665@ == -1 
else_jump @MTBIKER_8080 
036A: put_actor 738@(644@,6i) in_car 732@(644@,6i) 
jump @MTBIKER_8194 

:MTBIKER_8080
Car.RemoveReferences(732@(644@,6i))
732@(644@,6i) = Car.Create(707@(644@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
036A: put_actor 738@(644@,6i) in_car 732@(644@,6i) 
039F: set_car 732@(644@,6i) race_to 714@(644@,6f) 720@(644@,6f) 
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 

:MTBIKER_8194
jump @MTBIKER_8315 

:MTBIKER_8201
Car.Destroy(732@(644@,6i))
732@(644@,6i) = Car.Create(707@(644@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
036A: put_actor 738@(644@,6i) in_car 732@(644@,6i) 
039F: set_car 732@(644@,6i) race_to 714@(644@,6f) 720@(644@,6f) 
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 

:MTBIKER_8315
Actor.StorePos(738@(644@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
02C1: store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" car_path_coords_closest_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
838A:   not any_car_in_cube_cornerA " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" cornerB 10.0 10.0 10.0 
else_jump @MTBIKER_8524 
if 
80C2:   not sphere_onscreen " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 4.0 
else_jump @MTBIKER_8524 
Actor.PutAt(738@(644@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
   Actor.Driving(738@(644@,6i))
else_jump @MTBIKER_8524 
774@ = Actor.CurrentCar(738@(644@,6i))
Actor.Angle(738@(644@,6i)) = 463@(644@,120f)
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 

:MTBIKER_8524
if 
   Actor.Driving(738@(644@,6i))
else_jump @MTBIKER_8575 
0085: 647@ = 745@(757@,10i) 
647@ += 5 
774@ = Actor.CurrentCar(738@(644@,6i))

:MTBIKER_8575
643@ = 0 
646@ = 0 

:MTBIKER_8589
if 
001D:   744@ > 643@ 
else_jump @MTBIKER_8671 
0085: 775@ = 745@(643@,10i) 
775@ -= 3 
if 
001D:   775@ > 745@(644@,10i) 
else_jump @MTBIKER_8657 
646@ += 1 

:MTBIKER_8657
643@ += 1 
jump @MTBIKER_8589 

:MTBIKER_8671
if 
  646@ > 0 
else_jump @MTBIKER_9093 
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_9093 
if 
8104:   not actor " + PlayerActor + @" near_actor 738@(644@,6i) radius 30.0 30.0 5.0 sphere 0 
else_jump @MTBIKER_9093 
if 
82CB:   not actor 738@(644@,6i) bounding_sphere_visible 
else_jump @MTBIKER_9093 
if 
838A:   not any_car_in_cube_cornerA 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) cornerB 10.0 10.0 10.0 
else_jump @MTBIKER_9093 
if 
80C2:   not sphere_onscreen 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) radius 4.0 
else_jump @MTBIKER_9093 
Actor.PutAt(738@(644@,6i), 714@(644@,6f), 720@(644@,6f), 726@(644@,6f))
if 
   Actor.Driving(738@(644@,6i))
else_jump @MTBIKER_8983 
774@ = Actor.CurrentCar(738@(644@,6i))
Actor.Angle(738@(644@,6i)) = 463@(644@,120f)
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 
jump @MTBIKER_9093 

:MTBIKER_8983
732@(644@,6i) = Car.Create(707@(644@,6i), 714@(644@,6f), 720@(644@,6f), 726@(644@,6f))
036A: put_actor 738@(644@,6i) in_car 732@(644@,6i) 
Actor.Angle(738@(644@,6i)) = 463@(644@,120f)
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 

:MTBIKER_9093
if 
  656@ == 0 
else_jump @MTBIKER_9215 
if 
07D6:   738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_9215 
if 
80FE:   not actor 738@(644@,6i) sphere 0 in_sphere 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) radius 500.0 500.0 500.0 
else_jump @MTBIKER_9215 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @MTBIKER_14393 

:MTBIKER_9215
if 
  " + _1799 + @" == 3 
else_jump @MTBIKER_9410 
if and
  13 > 745@(644@,10i) 
  745@(644@,10i) > 4 
else_jump @MTBIKER_9338 
if 
0100:   actor 738@(644@,6i) in_sphere 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) radius 4.0 4.0 1.5 sphere 0 in_car 
else_jump @MTBIKER_9331 
jump @MTBIKER_12473 

:MTBIKER_9331
jump @MTBIKER_9403 

:MTBIKER_9338
if 
0100:   actor 738@(644@,6i) in_sphere 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) radius 15.0 15.0 5.0 sphere 0 in_car 
else_jump @MTBIKER_9403 
jump @MTBIKER_12473 

:MTBIKER_9403
jump @MTBIKER_9475 

:MTBIKER_9410
if 
0100:   actor 738@(644@,6i) in_sphere 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) radius 15.0 15.0 5.0 sphere 0 in_car 
else_jump @MTBIKER_9475 
jump @MTBIKER_12473 

:MTBIKER_9475
jump @MTBIKER_9536 

:MTBIKER_9482
if 
87D6:   not  738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_9536 
if 
84AD:   not actor 738@(644@,6i) in_water 
else_jump @MTBIKER_9536 
745@(644@,10i) = 0 

:MTBIKER_9536
if 
07D6:   738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_11382 
if 
   not Car.Wrecked(732@(757@,6i))
else_jump @MTBIKER_11350 
Actor.StorePos(738@(757@,6i), 583@(644@,10f), 593@(644@,10f), 603@(644@,10f))
Car.StorePos(732@(757@,6i), 613@, 623@, 633@)
0063: 603@(644@,10f) -= 726@(644@,6f) 
0063: 633@ -= 726@(644@,6f) 
if or
  -24.5 > 603@(644@,10f) 
  -24.5 > 633@ 
else_jump @MTBIKER_10121 
if 
  657@ == 0 
else_jump @MTBIKER_9731 
657@ = 1 
008B: 668@ = " + Current_Time_in_ms2 + @" 
668@ += 1500 

:MTBIKER_9731
if 
  657@ == 1 
else_jump @MTBIKER_10114 
0085: 649@ = 668@ 
0064: 649@ -= " + Current_Time_in_ms2 + @" 
649@ /= 1000 
if 
  1 > 649@ 
else_jump @MTBIKER_9798 
649@ = 0 

:MTBIKER_9798
if 
001E:   " + Current_Time_in_ms2 + @" > 668@ 
else_jump @MTBIKER_10114 
0085: 658@ = 745@(644@,10i) 
658@ -= 1 
if 
  2 >= " + FreeFall_Stage + @" 
else_jump @MTBIKER_10091 
if 
  " + FreeFall_Stage + @" > 0 
else_jump @MTBIKER_9879 
" + FreeFall_Stage + @" = 6 

:MTBIKER_9879
Player.CanMove(" + PlayerChar + @") = False
Player.CanMove(" + PlayerChar + @") = False
Player.CanMove(" + PlayerChar + @") = False
fade 0 500 

:MTBIKER_9907
if 
fading 
else_jump @MTBIKER_9931 
wait 0 
jump @MTBIKER_9907 

:MTBIKER_9931
if 
   not Car.Wrecked(732@(757@,6i))
else_jump @MTBIKER_10040 
if 
   not Actor.InCar(738@(644@,6i), 732@(757@,6i))
else_jump @MTBIKER_9994 
036A: put_actor 738@(644@,6i) in_car 732@(757@,6i) 

:MTBIKER_9994
Car.PutAt(732@(757@,6i), 103@(658@,120f), 223@(658@,120f), 343@(658@,120f))
Car.Angle(732@(757@,6i)) = 463@(658@,120f)

:MTBIKER_10040
fade 1 500 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut

:MTBIKER_10051
if 
fading 
else_jump @MTBIKER_10075 
wait 0 
jump @MTBIKER_10051 

:MTBIKER_10075
Camera.SetBehindPlayer
Player.CanMove(" + PlayerChar + @") = True
jump @MTBIKER_10114 

:MTBIKER_10091
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @MTBIKER_14393 

:MTBIKER_10114
jump @MTBIKER_10146 

:MTBIKER_10121
if 
  657@ == 1 
else_jump @MTBIKER_10146 
657@ = 0 

:MTBIKER_10146
if 
   not Car.Wrecked(732@(757@,6i))
else_jump @MTBIKER_11343 
if 
   not Actor.InCar(" + PlayerActor + @", 732@(757@,6i))
else_jump @MTBIKER_11050 
if 
  656@ == 0 
else_jump @MTBIKER_10301 
06D6: disable_racing_checkpoint 780@ 
Marker.Disable(755@)
if 
   not Car.Wrecked(732@(757@,6i))
else_jump @MTBIKER_10256 
755@ = Marker.CreateAboveCar(732@(757@,6i))
07E0: set_marker 755@ type_to 1 

:MTBIKER_10256
0085: 666@ = 644@ 
720@(644@,6f) += 1000.0 
008B: 667@ = " + Current_Time_in_ms2 + @" 
667@ += 25400 
656@ = 1 

:MTBIKER_10301
0085: 649@ = 667@ 
0064: 649@ -= " + Current_Time_in_ms2 + @" 
649@ /= 1000 
if 
  1 > 649@ 
else_jump @MTBIKER_10350 
649@ = 0 

:MTBIKER_10350
if 
001E:   " + Current_Time_in_ms2 + @" > 667@ 
else_jump @MTBIKER_10394 
00BC: show_text_highpriority GXT 'RACES20' time 5000 flag 1  
jump @MTBIKER_14393 
return 

:MTBIKER_10394
if 
  649@ == 1 
else_jump @MTBIKER_10442 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'RACE_51' number 649@ time 200 flag 1  
jump @MTBIKER_10465 

:MTBIKER_10442
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'RACES50' number 649@ time 200 flag 1  

:MTBIKER_10465
if 
003B:   745@(644@,10i) == 700@ 
else_jump @MTBIKER_11043 
if 
07D6:   738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_11043 
if 
001C:   " + Current_Time_in_ms2 + @" > " + tmp_1807 + @"(" + _1799 + @",5i) 
else_jump @MTBIKER_10715 
0084: " + tmp_1807 + @"(" + _1799 + @",5i) = " + Current_Time_in_ms2 + @" 
008B: 776@ = " + Current_Time_in_ms2 + @" 
0062: 776@ -= 651@ 
0084: " + tmp_1807 + @"(" + _1799 + @",5i) = " + Current_Time_in_ms2 + @" 
042E: downdate_integer_stat 12 to " + tmp_1807 + @"(" + _1799 + @",5i) 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
if 
  649@ > 9 
else_jump @MTBIKER_10686 
036D: show_text_2numbers_styled GXT 'LAPMTB2' numbers 648@ 649@ time 5000 style 6  
jump @MTBIKER_10708 

:MTBIKER_10686
036D: show_text_2numbers_styled GXT 'LAPMTB' numbers 648@ 649@ time 5000 style 6  

:MTBIKER_10708
jump @MTBIKER_10997 

:MTBIKER_10715
008B: 776@ = " + tmp_1807 + @"(" + _1799 + @",5i) 
0062: 776@ -= 651@ 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
if 
  649@ > 9 
else_jump @MTBIKER_10836 
036D: show_text_2numbers_styled GXT 'RACES08' numbers 648@ 649@ time 5000 style 6  
jump @MTBIKER_10858 

:MTBIKER_10836
036D: show_text_2numbers_styled GXT 'RACES22' numbers 648@ 649@ time 5000 style 6  

:MTBIKER_10858
008B: 776@ = " + Current_Time_in_ms2 + @" 
0062: 776@ -= 651@ 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
if 
  649@ > 9 
else_jump @MTBIKER_10975 
036D: show_text_2numbers_styled GXT 'RACE_52' numbers 648@ 649@ time 5000 style 4 
jump @MTBIKER_10997 

:MTBIKER_10975
036D: show_text_2numbers_styled GXT 'RACE_53' numbers 648@ 649@ time 5000 style 4 

:MTBIKER_10997
758@ += 1 
if 
  758@ == 1 
else_jump @MTBIKER_11036 
jump @MTBIKER_14411 
jump @MTBIKER_11043 

:MTBIKER_11036
jump @MTBIKER_14393 

:MTBIKER_11043
jump @MTBIKER_11343 

:MTBIKER_11050
if 
  656@ == 1 
else_jump @MTBIKER_11343 
03D5: remove_text 'RACES50'  
Marker.Disable(755@)
720@(644@,6f) -= 1000.0 
645@ = 0 
0085: 647@ = 92@ 
647@ -= 1 
018A: 755@ = create_checkpoint_at 714@(666@,6f) 720@(666@,6f) 726@(666@,6f) 
Marker.SetColor(755@, 0)
018B: set_marker 755@ radar_mode 2 
Marker.SetIconSize(755@, 3)
if 
003B:   745@(666@,10i) == 713@ 
else_jump @MTBIKER_11245 
06D5: 780@ = create_racing_checkpoint_at 714@(666@,6f) 720@(666@,6f) 726@(666@,6f) point_to 0.0 0.0 0.0 type 1 radius 6.0 
jump @MTBIKER_11336 

:MTBIKER_11245
0085: 647@ = 745@(666@,10i) 
647@ += 1 
if 
003B:   745@(666@,10i) == 713@ 
else_jump @MTBIKER_11294 
647@ = 1 

:MTBIKER_11294
06D5: 780@ = create_racing_checkpoint_at 714@(666@,6f) 720@(666@,6f) 726@(666@,6f) point_to 777@ 778@ 779@ type 0 radius 6.0 

:MTBIKER_11336
656@ = 0 

:MTBIKER_11343
jump @MTBIKER_11375 

:MTBIKER_11350
00BC: show_text_highpriority GXT 'RACES24' time 5000 flag 1  
jump @MTBIKER_14393 
return 

:MTBIKER_11375
jump @MTBIKER_11776 

:MTBIKER_11382
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_11776 
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_11776 
Actor.StorePos(738@(644@,6i), 583@(644@,10f), 593@(644@,10f), 603@(644@,10f))
0063: 603@(644@,10f) -= 726@(644@,6f) 
if 
  -15.5 > 603@(644@,10f) 
else_jump @MTBIKER_11776 
if 
80C2:   not sphere_onscreen 103@(658@,120f) 223@(658@,120f) 343@(658@,120f) radius 10.0 
else_jump @MTBIKER_11776 
0085: 658@ = 745@(644@,10i) 
658@ -= 1 
if 
   Actor.InCar(738@(644@,6i), 732@(644@,6i))
else_jump @MTBIKER_11631 
Car.PutAt(732@(644@,6i), 103@(658@,120f), 223@(658@,120f), 343@(658@,120f))
Car.Angle(732@(644@,6i)) = 463@(644@,120f)
jump @MTBIKER_11776 

:MTBIKER_11631
046C: 665@ = car 732@(644@,6i) driver 
if 
  665@ == -1 
else_jump @MTBIKER_11714 
036A: put_actor 738@(644@,6i) in_car 732@(644@,6i) 
Car.PutAt(732@(644@,6i), 103@(658@,120f), 223@(658@,120f), 343@(658@,120f))
jump @MTBIKER_11776 

:MTBIKER_11714
Car.RemoveReferences(732@(644@,6i))
732@(644@,6i) = Car.Create(707@(644@,6i), 103@(658@,120f), 223@(658@,120f), 343@(658@,120f))
036A: put_actor 738@(644@,6i) in_car 732@(644@,6i) 

:MTBIKER_11776
644@ += 1 
jump @MTBIKER_7177 

:MTBIKER_11790
038E: draw_box_position 40@ 47@ size 54@ 61@ RGBA 0 0 0 255 
038E: draw_box_position 39@ 46@ size 53@ 60@ RGBA 134 155 184 255 
038E: draw_box_position 34@ 41@ size 48@ 55@ RGBA 0 0 0 255 
758@ += 1 
gosub @MTBIKER_14325 
033F: set_text_draw_letter_size 49@ 56@ 
if 
  758@ == 1 
else_jump @MTBIKER_11919 
033E: set_draw_text_position 35@ 42@ GXT 'ST'  

:MTBIKER_11919
if 
  758@ == 2 
else_jump @MTBIKER_11954 
033E: set_draw_text_position 35@ 42@ GXT 'ND'  

:MTBIKER_11954
if 
  758@ == 3 
else_jump @MTBIKER_11989 
033E: set_draw_text_position 35@ 42@ GXT 'RD'  

:MTBIKER_11989
if 
  758@ > 3 
else_jump @MTBIKER_12024 
033E: set_draw_text_position 35@ 42@ GXT 'TH'  

:MTBIKER_12024
if 
  2 >= 758@ 
else_jump @MTBIKER_12109 
0087: 655@ = 652@ 
if 
  " + _1799 + @" == 1 
else_jump @MTBIKER_12109 
if or
  745@(644@,10i) == 17 
  745@(644@,10i) == 16 
else_jump @MTBIKER_12109 
0087: 655@ = 654@ 

:MTBIKER_12109
if and
  758@ > 2 
  4 > 758@ 
else_jump @MTBIKER_12201 
0087: 655@ = 653@ 
if 
  " + _1799 + @" == 1 
else_jump @MTBIKER_12201 
if or
  745@(644@,10i) == 17 
  745@(644@,10i) == 16 
else_jump @MTBIKER_12201 
0087: 655@ = 654@ 

:MTBIKER_12201
if 
  758@ == 6 
else_jump @MTBIKER_12227 
0087: 655@ = 654@ 

:MTBIKER_12227
gosub @MTBIKER_14325 
033F: set_text_draw_letter_size 50@ 57@ 
0342: set_text_draw_centered 1 
045A: draw_text_1number 36@ 43@ GXT 'NUMBER' number 758@  
gosub @MTBIKER_14325 
033F: set_text_draw_letter_size 51@ 58@ 
045A: draw_text_1number 37@ 44@ GXT 'OUT_OF' number 92@  
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 776@ = " + Current_Time_in_ms2 + @" 
0062: 776@ -= 651@ 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
gosub @MTBIKER_14325 
0342: set_text_draw_centered 1 
033F: set_text_draw_letter_size 52@ 59@ 
if 
  649@ > 9 
else_jump @MTBIKER_12443 
045B: draw_text_2numbers 38@ 45@ GXT 'TIME' numbers 648@ 649@  
jump @MTBIKER_12466 

:MTBIKER_12443
045B: draw_text_2numbers 38@ 45@ GXT 'TIME_0' numbers 648@ 649@  

:MTBIKER_12466
jump @MTBIKER_4424 

:MTBIKER_12473
if 
  756@ == 7 
else_jump @MTBIKER_12498 
756@ = 8 

:MTBIKER_12498
if 
07D6:   738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_12546 
018C: play_sound 1058 at 0.0 0.0 0.0 
Marker.Disable(755@)

:MTBIKER_12546
745@(644@,10i) += 1 
if 
003B:   745@(644@,10i) == 700@ 
else_jump @MTBIKER_13253 
if 
07D6:   738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_13142 
if 
001C:   " + Current_Time_in_ms2 + @" > " + tmp_1807 + @"(" + _1799 + @",5i) 
else_jump @MTBIKER_12807 
0084: " + tmp_1807 + @"(" + _1799 + @",5i) = " + Current_Time_in_ms2 + @" 
008B: 776@ = " + Current_Time_in_ms2 + @" 
0062: 776@ -= 651@ 
0084: " + tmp_1807 + @"(" + _1799 + @",5i) = " + Current_Time_in_ms2 + @" 
042E: downdate_integer_stat 12 to " + tmp_1807 + @"(" + _1799 + @",5i) 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
if 
  649@ > 9 
else_jump @MTBIKER_12778 
036D: show_text_2numbers_styled GXT 'LAPMTB2' numbers 648@ 649@ time 5000 style 6  
jump @MTBIKER_12800 

:MTBIKER_12778
036D: show_text_2numbers_styled GXT 'LAPMTB' numbers 648@ 649@ time 5000 style 6  

:MTBIKER_12800
jump @MTBIKER_13089 

:MTBIKER_12807
008B: 776@ = " + tmp_1807 + @"(" + _1799 + @",5i) 
0062: 776@ -= 651@ 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
if 
  649@ > 9 
else_jump @MTBIKER_12928 
036D: show_text_2numbers_styled GXT 'RACES08' numbers 648@ 649@ time 5000 style 6  
jump @MTBIKER_12950 

:MTBIKER_12928
036D: show_text_2numbers_styled GXT 'RACES22' numbers 648@ 649@ time 5000 style 6  

:MTBIKER_12950
008B: 776@ = " + Current_Time_in_ms2 + @" 
0062: 776@ -= 651@ 
776@ /= 1000 
0085: 648@ = 776@ 
648@ /= 60 
0085: 647@ = 648@ 
647@ *= 60 
0085: 649@ = 776@ 
0062: 649@ -= 647@ 
if 
  649@ > 9 
else_jump @MTBIKER_13067 
036D: show_text_2numbers_styled GXT 'TIME' numbers 648@ 649@ time 5000 style 4  
jump @MTBIKER_13089 

:MTBIKER_13067
036D: show_text_2numbers_styled GXT 'TIME_0' numbers 648@ 649@ time 5000 style 4  

:MTBIKER_13089
758@ += 1 
if 
  758@ == 1 
else_jump @MTBIKER_13128 
jump @MTBIKER_14411 
jump @MTBIKER_13135 

:MTBIKER_13128
jump @MTBIKER_14393 

:MTBIKER_13135
jump @MTBIKER_13253 

:MTBIKER_13142
06C7: AS_actor 738@(644@,6i) driver_of_car -1 perform_action 6 timelimit 2000000 
0085: 658@ = 745@(644@,10i) 
658@ -= 1 
if 
80C2:   not sphere_onscreen 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) radius 30.0 
else_jump @MTBIKER_13253 
if 
   not Car.Wrecked(774@)
else_jump @MTBIKER_13253 
039F: set_car 774@ race_to 103@(658@,120f) 223@(658@,120f) 

:MTBIKER_13253
0085: 647@ = 745@(644@,10i) 
0087: 714@(644@,6f) = 103@(647@,120f) 
0087: 720@(644@,6f) = 223@(647@,120f) 
0087: 726@(644@,6f) = 343@(647@,120f) 
if 
07D6:   738@(644@,6i) == " + PlayerActor + @" 
else_jump @MTBIKER_13694 
647@ += 1 
0087: 777@ = 103@(647@,120f) 
0087: 778@ = 223@(647@,120f) 
0087: 779@ = 343@(647@,120f) 
018A: 755@ = create_checkpoint_at 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) 
Marker.SetColor(755@, 0)
018B: set_marker 755@ radar_mode 2 
Marker.SetIconSize(755@, 3)
if 
  756@ == 1 
else_jump @MTBIKER_13486 
06D5: 780@ = create_racing_checkpoint_at 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) point_to 777@ 778@ 779@ type 0 radius 6.0 

:MTBIKER_13486
06D6: disable_racing_checkpoint 780@ 
if 
001D:   713@ > 745@(644@,10i) 
else_jump @MTBIKER_13563 
06D5: 780@ = create_racing_checkpoint_at 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) point_to 777@ 778@ 779@ type 0 radius 6.0 
jump @MTBIKER_13605 

:MTBIKER_13563
06D5: 780@ = create_racing_checkpoint_at 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) point_to 777@ 778@ 779@ type 1 radius 6.0 

:MTBIKER_13605
if 
  745@(644@,10i) == 3 
else_jump @MTBIKER_13687 
Actor.RemoveReferences(770@)
Actor.RemoveReferences(759@)
Actor.RemoveReferences(760@)
Actor.RemoveReferences(761@)
Actor.RemoveReferences(762@)
Actor.RemoveReferences(763@)
Actor.RemoveReferences(764@)
Actor.RemoveReferences(765@)
Actor.RemoveReferences(766@)
Actor.RemoveReferences(767@)
Actor.RemoveReferences(768@)
Actor.RemoveReferences(769@)

:MTBIKER_13687
jump @MTBIKER_14318 

:MTBIKER_13694
if 
  " + _1799 + @" == 3 
else_jump @MTBIKER_14080 
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_14073 
if 
  745@(644@,10i) == 1 
else_jump @MTBIKER_13858 
if 
  644@ == 0 
else_jump @MTBIKER_13806 
0209: " + _8266 + @" = random_int_in_ranges 832 835 
05EB: assign_car 732@(644@,6i) to_path " + _8266 + @" 
08C6: set_actor 738@(644@,6i) stay_on_bike 1 

:MTBIKER_13806
if 
  644@ == 1 
else_jump @MTBIKER_13858 
0209: " + _8266 + @" = random_int_in_ranges 829 832 
05EB: assign_car 732@(644@,6i) to_path " + _8266 + @" 
08C6: set_actor 738@(644@,6i) stay_on_bike 1 

:MTBIKER_13858
if 
  745@(644@,10i) == 13 
else_jump @MTBIKER_13980 
060E:   car 732@(644@,6i) assigned_to_path 
05EC: release_car 732@(644@,6i) from_path 
if 
803B:   not  745@(644@,10i) == 700@ 
else_jump @MTBIKER_13980 
08C6: set_actor 738@(644@,6i) stay_on_bike 0 
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 
jump @MTBIKER_9536 

:MTBIKER_13980
if 
  745@(644@,10i) > 13 
else_jump @MTBIKER_14073 
if 
803B:   not  745@(644@,10i) == 700@ 
else_jump @MTBIKER_14073 
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 
jump @MTBIKER_9536 

:MTBIKER_14073
jump @MTBIKER_14318 

:MTBIKER_14080
if 
803B:   not  745@(644@,10i) == 700@ 
else_jump @MTBIKER_14151 
05D1: AS_actor 738@(644@,6i) drive_car -1 to 714@(644@,6f) 720@(644@,6f) 726@(644@,6f) speed 655@ 3 model #CSPLAY 1 
jump @MTBIKER_9536 

:MTBIKER_14151
if 
002D:   745@(644@,10i) >= 700@ 
else_jump @MTBIKER_14318 
if 
   not Car.Wrecked(732@(644@,6i))
else_jump @MTBIKER_14318 
if 
   not Actor.Dead(738@(644@,6i))
else_jump @MTBIKER_14318 
if 
   Actor.InCar(738@(644@,6i), 732@(644@,6i))
else_jump @MTBIKER_14318 
if 
  690@(644@,10i) == 0 
else_jump @MTBIKER_14318 
0687: clear_actor 738@(644@,6i) task 
690@(644@,10i) = 1 
05D1: AS_actor 738@(644@,6i) drive_car -1 to -2399.863 -2206.549 32.5652 speed 655@ 3 model #CSPLAY 1 

:MTBIKER_14318
jump @MTBIKER_9536 

:MTBIKER_14325
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 0.6146 2.4961 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
060D: draw_text_shadow 2 rgba 0 0 0 180 
return 

:MTBIKER_14393
00BA: show_text_styled GXT 'RACES_8' time 5000 style 1  
return 

:MTBIKER_14411
008B: 646@ = " + _1799 + @" 
646@ += 1 
646@ *= 10000 
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 1 
if 
  " + _1799 + @" == 1 
else_jump @MTBIKER_14505 
00BA: show_text_styled GXT 'RACES18' time 500 style 1  
Player.Money(" + PlayerChar + @") += 500
00BC: show_text_highpriority GXT 'MTWIN1' time 5000 flag 1  
0394: play_music 1 

:MTBIKER_14505
if 
  " + _1799 + @" == 2 
else_jump @MTBIKER_14567 
00BC: show_text_highpriority GXT 'MTWIN2' time 5000 flag 1  
00BA: show_text_styled GXT 'RACES18' time 1000 style 1  
Player.Money(" + PlayerChar + @") += 1000
0394: play_music 1 

:MTBIKER_14567
if 
  " + _1799 + @" == 3 
else_jump @MTBIKER_14629 
00BA: show_text_styled GXT 'RACES18' time 2000 style 1  
Player.Money(" + PlayerChar + @") += 2000
00BC: show_text_highpriority GXT 'MTWIN3' time 5000 flag 1  
0394: play_music 2 

:MTBIKER_14629
" + _1799 + @" += 1 
if 
  " + _1799 + @" > 3 
else_jump @MTBIKER_14688 
if 
  " + Mission_Chiliad_Challenge_Passed + @" == 0 
else_jump @MTBIKER_14681 
0595: mission_complete 
" + Mission_Chiliad_Challenge_Passed + @" = 1 

:MTBIKER_14681
" + _1799 + @" = 1 

:MTBIKER_14688
return 

:MTBIKER_14690
" + OnMission + @" = 0 
if 
   not Car.Wrecked(732@)
else_jump @MTBIKER_14734 
if 
06AA:   NOP_false 732@ 
else_jump @MTBIKER_14734 
05EC: release_car 732@ from_path 

:MTBIKER_14734
if 
   not Car.Wrecked(733@)
else_jump @MTBIKER_14771 
if 
06AA:   NOP_false 733@ 
else_jump @MTBIKER_14771 
05EC: release_car 733@ from_path 

:MTBIKER_14771
0873: release_path 829 
0873: release_path 830 
0873: release_path 831 
0873: release_path 832 
0873: release_path 833 
0873: release_path 834 
Model.Destroy(701@)
Model.Destroy(702@)
Model.Destroy(703@)
Model.Destroy(704@)
Model.Destroy(705@)
Model.Destroy(706@)
Model.Destroy(707@)
Model.Destroy(708@)
Model.Destroy(709@)
Model.Destroy(710@)
Model.Destroy(711@)
Model.Destroy(712@)
Actor.RemoveReferences(770@)
Actor.RemoveReferences(759@)
Actor.RemoveReferences(760@)
Actor.RemoveReferences(761@)
Actor.RemoveReferences(762@)
Actor.RemoveReferences(763@)
Actor.RemoveReferences(764@)
Actor.RemoveReferences(765@)
Actor.RemoveReferences(766@)
Actor.RemoveReferences(767@)
Actor.RemoveReferences(768@)
Actor.RemoveReferences(769@)
09B9: show_entered_car_name 1 
Marker.Disable(755@)
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
0912: set_text_priority 0 leftmargin 380 maxwidth 464 
03F0: enable_text_draw 0 
mission_cleanup 
return" );
            }

        }

    }

}