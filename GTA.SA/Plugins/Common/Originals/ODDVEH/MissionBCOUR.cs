﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class BCOUR : MissionCustom {

            AssetMoneyPickup _2000 = global(),
                             _1996 = global(),
                             _1998 = global();

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @BCOUR_47 
if 
wasted_or_busted 
else_jump @BCOUR_38 
gosub @BCOUR_14327 

:BCOUR_38
gosub @BCOUR_16271 
end_thread 

:BCOUR_47
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @BCOUR_71 
0842: 872@ = player " + PlayerChar + @" town_number 

:BCOUR_71
if 
04A4:   872@ == 1 
else_jump @BCOUR_109 
if 
  " + Mission_Courier_LS_Passed + @" == 0 
else_jump @BCOUR_109 
increment_mission_attempts 

:BCOUR_109
if 
04A4:   872@ == 3 
else_jump @BCOUR_147 
if 
  " + Mission_Courier_LV_Passed + @" == 0 
else_jump @BCOUR_147 
increment_mission_attempts 

:BCOUR_147
if 
04A4:   872@ == 2 
else_jump @BCOUR_185 
if 
  " + Mission_Courier_SF_Passed + @" == 0 
else_jump @BCOUR_185 
increment_mission_attempts 

:BCOUR_185
" + OnMission + @" = 1 
wait 0 
wait 0 
054C: use_GXT_table 'BCOU' 
0169: set_fade_color_RGB 0 0 0 
37@ = Object.Create(#KMB_PACKET, -2492.508, 0.5813, 24.7593)
if 
  746@ == -13 
else_jump @BCOUR_284 
38@ = Actor.Create(Mission1, #WMYDRUG, -2455.662, -105.3974, 26.5568)

:BCOUR_284
Model.Load(#WAYFARER)
Model.Load(#WMYDRUG)
04ED: load_animation ""SMOKING"" 
038B: load_requested_models 

:BCOUR_306
if or
   not Model.Available(#WAYFARER)
   not Model.Available(#WMYDRUG)
84EE:   not animation ""SMOKING"" loaded 
else_jump @BCOUR_348 
wait 0 
jump @BCOUR_306 

:BCOUR_348
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @BCOUR_371 
Player.CanMove(" + PlayerChar + @") = True

:BCOUR_371
875@ = 0 
882@ = 0 
879@ = 0 
880@ = 0 
866@ = 0 
867@ = 0 
34@ = 0 
869@ = 0 
870@ = 0 
871@ = 0 
744@ = 0 
745@ = 0 
743@ = 0 
746@ = 0 
747@ = 0 
748@ = 0 
749@ = 0 
868@ = 0 
760@ = 0 
761@ = 0 
762@ = 0 
383@ = -2594.816 
413@ = 52.5992 
443@ = 3.3359 
103@ = -2797.952 
133@ = 209.7299 
163@ = 6.1963 
104@ = -2492.771 
134@ = -196.6625 
164@ = 24.6236 
105@ = -2611.989 
135@ = -110.7328 
165@ = 3.331 
106@ = -2176.392 
136@ = -41.7131 
166@ = 34.3125 
107@ = -2243.896 
137@ = 603.6998 
167@ = 40.1216 
108@ = -1569.994 
138@ = 662.3286 
168@ = 6.1874 
109@ = -2756.371 
139@ = 379.1574 
169@ = 3.3281 
110@ = -2609.902 
140@ = 131.9432 
170@ = 3.326 
111@ = -2743.858 
141@ = 761.4077 
171@ = 53.3828 
112@ = -2600.543 
142@ = 980.7458 
172@ = 77.2676 
113@ = -2153.959 
143@ = 716.1611 
173@ = 68.5511 
114@ = -2153.604 
144@ = 251.9152 
174@ = 34.3125 
115@ = -2808.285 
145@ = -340.2412 
175@ = 6.1797 
116@ = -2428.846 
146@ = -164.1249 
176@ = 34.3125 
117@ = -1984.213 
147@ = 128.7572 
177@ = 26.6797 
118@ = -1888.46 
148@ = 819.6346 
178@ = 34.1797 
119@ = -1503.329 
149@ = 919.9264 
179@ = 6.1776 
120@ = -2533.885 
150@ = 987.9146 
180@ = 77.3017 
473@ = 1346.019 
503@ = -1741.781 
533@ = 12.397 
193@ = 1286.769 
223@ = -1676.166 
253@ = 12.5625 
194@ = 1544.063 
224@ = -1675.754 
254@ = 12.56 
195@ = 1320.097 
225@ = -1795.099 
255@ = 12.5391 
196@ = 1614.261 
226@ = -1885.756 
256@ = 12.5536 
197@ = 2009.173 
227@ = -1716.913 
257@ = 12.5469 
198@ = 1256.513 
228@ = -1010.974 
258@ = 32.9002 
199@ = 1016.673 
229@ = -1508.782 
259@ = 12.541 
200@ = 1286.769 
230@ = -1676.166 
260@ = 12.5625 
201@ = 1544.063 
231@ = -1675.754 
261@ = 12.56 
202@ = 1320.097 
232@ = -1795.099 
262@ = 12.5391 
203@ = 1614.261 
233@ = -1885.756 
263@ = 12.5536 
204@ = 2009.173 
234@ = -1716.913 
264@ = 12.5469 
205@ = 2865.389 
235@ = -1438.957 
265@ = 9.9659 
206@ = 2740.561 
236@ = -2103.442 
266@ = 11.1221 
207@ = 1346.455 
237@ = -989.3849 
267@ = 28.0294 
208@ = 150.4926 
238@ = -1945.385 
268@ = 2.7657 
209@ = 378.0941 
239@ = -2053.585 
269@ = 7.0156 
210@ = 804.5734 
240@ = -1020.714 
270@ = 25.6819 
563@ = 1904.681 
593@ = 2096.17 
623@ = 9.8203 
283@ = 1698.404 
313@ = 2054.898 
343@ = 9.8203 
284@ = 2159.833 
314@ = 2066.728 
344@ = 9.8125 
285@ = 1935.701 
315@ = 2158.464 
345@ = 9.8203 
286@ = 1654.331 
316@ = 1803.812 
346@ = 9.8125 
287@ = 2083.325 
317@ = 1503.754 
347@ = 9.8125 
288@ = 1720.11 
318@ = 1298.548 
348@ = 9.8203 
289@ = 2233.837 
319@ = 1282.195 
349@ = 9.8203 
290@ = 1698.404 
320@ = 2063.969 
350@ = 9.8203 
291@ = 2159.833 
321@ = 2066.728 
351@ = 9.8125 
292@ = 1935.701 
322@ = 2158.464 
352@ = 9.8203 
293@ = 1654.331 
323@ = 1803.812 
353@ = 9.8125 
294@ = 2083.325 
324@ = 1503.754 
354@ = 9.8125 
295@ = 1917.762 
325@ = 2768.874 
355@ = 9.8203 
296@ = 2344.569 
326@ = 2779.965 
356@ = 9.8203 
297@ = 973.123 
327@ = 1782.238 
357@ = 7.6562 
298@ = 2346.52 
328@ = 2296.973 
358@ = 7.1478 
299@ = 1488.175 
329@ = 2148.474 
359@ = 9.8203 
300@ = 1104.697 
330@ = 1648.064 
360@ = 4.8273 
653@ = 0 
654@ = 0 
655@ = 0 
656@ = 0 
657@ = 0 
658@ = 0 
659@ = 0 
660@ = 0 
661@ = 0 
662@ = 0 
663@ = 0 
664@ = 0 
665@ = 0 
666@ = 0 
667@ = 0 
668@ = 0 
669@ = 0 
670@ = 0 
671@ = 0 
672@ = 0 
673@ = 0 
674@ = 0 
675@ = 0 
676@ = 0 
677@ = 0 
678@ = 0 
679@ = 0 
680@ = 0 
681@ = 0 
753@ = 99 
0501: set_player " + PlayerChar + @" driveby_mode 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @BCOUR_2468 
jump @BCOUR_14327 

:BCOUR_2468
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @BCOUR_2492 
36@ = Actor.MissionCar(" + PlayerActor + @")

:BCOUR_2492
753@ = 99 
754@ = 0 
755@ = 0 
758@ = 0 
756@ = 0 
757@ = 0 
857@ = 0 
862@ = 0 
881@ = 0 

:BCOUR_2555
wait 0 
if 
  882@ == 0 
else_jump @BCOUR_2591 
03CF: load_wav 5600 as 3 
882@ = 1 

:BCOUR_2591
if 
  882@ == 1 
else_jump @BCOUR_2631 
if 
03D0:   wav 3 loaded 
else_jump @BCOUR_2631 
882@ = 2 

:BCOUR_2631
if 
0735:   is_keyboard_key_pressed 87 
else_jump @BCOUR_2656 
" + _8264 + @" += 60000 

:BCOUR_2656
if 
0735:   is_keyboard_key_pressed 81 
else_jump @BCOUR_2681 
" + _8264 + @" -= 45000 

:BCOUR_2681
if 
0735:   is_keyboard_key_pressed 80 
else_jump @BCOUR_2703 
Player.WantedLevel(" + PlayerChar + @") = 2

:BCOUR_2703
if 
0735:   is_keyboard_key_pressed 79 
else_jump @BCOUR_2725 
Player.WantedLevel(" + PlayerChar + @") = 0

:BCOUR_2725
if 
0735:   is_keyboard_key_pressed 88 
else_jump @BCOUR_2765 
if 
  881@ == 0 
else_jump @BCOUR_2765 
881@ = 1 

:BCOUR_2765
if 
0735:   is_keyboard_key_pressed 90 
else_jump @BCOUR_2787 
881@ = 0 

:BCOUR_2787
if 
  862@ == 1 
else_jump @BCOUR_2838 
014F: stop_timer " + _8264 + @" 
0151: remove_status_text " + _8265 + @" 
00BC: show_text_highpriority GXT 'BCOU_11' time 6000 flag 1  
jump @BCOUR_14327 

:BCOUR_2838
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @BCOUR_2861 
jump @BCOUR_14327 

:BCOUR_2861
if 
   Car.Wrecked(36@)
else_jump @BCOUR_2884 
jump @BCOUR_14327 

:BCOUR_2884
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_2959 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_2959 
if 
00E1:   player 0 pressed_key 19 
else_jump @BCOUR_2959 
00BC: show_text_highpriority GXT 'BCOU_35' time 6000 flag 1  
jump @BCOUR_14327 

:BCOUR_2959
if 
  743@ == 10 
else_jump @BCOUR_2984 
jump @BCOUR_15206 

:BCOUR_2984
if 
  743@ == -99 
else_jump @BCOUR_3074 
763@(793@,30i) = Object.Init(#KMB_PACKET, 0.0, 0.0, 100.0)
066D: 827@(793@,30i) = attach_particle ""COKE_TRAIL"" to_object 763@(793@,30i) with_offset 0.0 0.0 0.0 type 1 

:BCOUR_3074
if 
  749@ == 1 
else_jump @BCOUR_3116 
if 
00E1:   player 0 pressed_key 16 
else_jump @BCOUR_3116 
748@ = 50 

:BCOUR_3116
if 
  868@ == 1 
else_jump @BCOUR_3172 
if 
00E1:   player 0 pressed_key 16 
else_jump @BCOUR_3172 
866@ = 2 
Player.CanMove(" + PlayerChar + @") = True
868@ = 0 

:BCOUR_3172
if 
  753@ == 0 
else_jump @BCOUR_3289 
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_3289 
if 
   not Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_3289 
33@ = 0 
754@ = 1 
008B: 752@ = " + _8264 + @" 
752@ /= 1000 
753@ = 1 
00BE: text_clear_all 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'BCOU_37' number " + _8263 + @" time 4000 flag 1  
03E6: remove_text_box 

:BCOUR_3289
if 
  753@ == 1 
else_jump @BCOUR_3442 
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_3442 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_3442 
33@ = 0 
753@ = 0 
754@ = 0 
875@ = 0 
00BE: text_clear_all 
03E6: remove_text_box 
if 
  746@ > 9 
else_jump @BCOUR_3408 
00BC: show_text_highpriority GXT 'BCOU_6' time 4000 flag 1  

:BCOUR_3408
if 
  10 > 746@ 
else_jump @BCOUR_3442 
00BC: show_text_highpriority GXT 'BCOU_3' time 4000 flag 1  

:BCOUR_3442
if 
  754@ == 1 
else_jump @BCOUR_3725 
0085: 751@ = 33@ 
751@ /= 1000 
if 
  875@ == 0 
else_jump @BCOUR_3527 
if and
  21000 > " + _8264 + @" 
  " + _8264 + @" > 1 
else_jump @BCOUR_3527 
875@ = 1 

:BCOUR_3527
if 
  875@ == 0 
else_jump @BCOUR_3571 
if 
  " + _8264 + @" > 20099 
else_jump @BCOUR_3571 
875@ = 2 

:BCOUR_3571
if 
  875@ == 1 
else_jump @BCOUR_3605 
0084: " + _8263 + @" = " + _8264 + @" 
" + _8263 + @" /= 1000 

:BCOUR_3605
if 
  875@ == 2 
else_jump @BCOUR_3638 
" + _8263 + @" = 20 
0066: " + _8263 + @" -= 751@ 

:BCOUR_3638
00BE: text_clear_all 
if 
  " + _8263 + @" > 0 
else_jump @BCOUR_3681 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'BCOU_37' number " + _8263 + @" time 4000 flag 1  

:BCOUR_3681
if 
  33@ > 21000 
else_jump @BCOUR_3725 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_35' time 6000 flag 1  
jump @BCOUR_14327 

:BCOUR_3725
if 
  746@ == -1 
else_jump @BCOUR_4823 
if 
  748@ == 0 
else_jump @BCOUR_4010 
060A: create_decision_maker_type 0 store_to 39@ 
Actor.DestroyInstantly(38@)
0395: clear_area 1 at -2455.662 -105.3974 26.5568 radius 10.0 
38@ = Actor.Create(Mission1, #WMYDRUG, -2455.662, -105.3974, 26.5568)
Actor.Angle(38@) = 176.0958
060B: set_actor 38@ decision_maker_to 39@ 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
Camera.SetPosition(-2468.393, -96.8149, 26.1614, 0.0, 0.0, 0.0)
Camera.PointAt(-2467.693, -97.5246, 26.0805, 2)
if 
   not Actor.Dead(38@)
else_jump @BCOUR_3989 
05D6: clear_scmpath 
05D7: add_point_to_scmpath -2457.04 -110.2905 25.0058 
05D7: add_point_to_scmpath -2460.845 -108.7783 24.9517 
05D7: add_point_to_scmpath -2462.371 -106.9304 24.9069 
05D8: AS_assign_scmpath to_actor 38@ flags 6 0 
0648: unknown_actor 38@ task_set 150.0 

:BCOUR_3989
748@ = 10 
749@ = 1 
33@ = 0 

:BCOUR_4010
if 
  748@ == 10 
else_jump @BCOUR_4093 
if 
  33@ > 4000 
else_jump @BCOUR_4093 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4093 
00BC: show_text_highpriority GXT 'BCOU_2' time 4000 flag 1 
748@ = 15 
33@ = 0 

:BCOUR_4093
if 
  748@ == 15 
else_jump @BCOUR_4160 
if 
  33@ > 1000 
else_jump @BCOUR_4160 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4160 
748@ = 20 
33@ = 0 

:BCOUR_4160
if 
  748@ == 20 
else_jump @BCOUR_4211 
if 
  33@ > 1000 
else_jump @BCOUR_4211 
33@ = 0 
748@ = 25 

:BCOUR_4211
if 
  748@ == 25 
else_jump @BCOUR_4283 
if 
  33@ > 200 
else_jump @BCOUR_4283 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4283 
0687: clear_actor 38@ task 
33@ = 0 
748@ = 40 

:BCOUR_4283
if 
  748@ == 40 
else_jump @BCOUR_4433 
if 
  33@ > 1000 
else_jump @BCOUR_4336 
00BC: show_text_highpriority GXT 'BCOU_3' time 4000 flag 1  

:BCOUR_4336
if 
  33@ > 4000 
else_jump @BCOUR_4433 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4401 
0687: clear_actor 38@ task 
05D3: AS_actor 38@ goto_point -2457.086 -126.3415 25.013 mode 6 time 5000 ms 

:BCOUR_4401
33@ = 0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_1' time 4000 flag 1 
748@ = 45 

:BCOUR_4433
if 
  748@ == 45 
else_jump @BCOUR_4477 
if 
  33@ > 4000 
else_jump @BCOUR_4477 
748@ = 50 

:BCOUR_4477
if 
  748@ == 50 
else_jump @BCOUR_4713 
00BE: text_clear_all 
749@ = 0 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4560 
0687: clear_actor 38@ task 
Actor.PutAt(38@, -2457.086, -126.3415, 25.013)
Actor.Angle(38@) = 180.0
Object.Destroy(37@)

:BCOUR_4560
02A3: enable_widescreen 0 
Object.Destroy(37@)
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
748@ = 60 
33@ = 0 
746@ = 1 
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_4622 
067F: set_car 36@ lights 0 

:BCOUR_4622
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4669 
0687: clear_actor 38@ task 
05D4: AS_actor 38@ rotate_angle 100.0 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  

:BCOUR_4669
753@ = 0 
37@ = Object.Create(#KMB_PACKET, -2458.249, -98.5704, 28.1875)
Object.CollisionDetection(37@) = True
Object.ToggleInMovingList(37@) = True

:BCOUR_4713
if 
  748@ == 60 
else_jump @BCOUR_4823 
if 
  33@ > 2000 
else_jump @BCOUR_4823 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_4823 
0687: clear_actor 38@ task 
0605: actor 38@ perform_animation ""M_SMKSTND_LOOP"" IFP ""SMOKING"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
748@ = 99 

:BCOUR_4823
if 
  746@ == 0 
else_jump @BCOUR_5065 
0842: 872@ = player " + PlayerChar + @" town_number 
if 
04A4:   872@ == 1 
else_jump @BCOUR_4904 
37@ = Object.Create(#KMB_PACKET, 1361.558, -1764.276, 18.0781)
Object.CollisionDetection(37@) = True
Object.ToggleInMovingList(37@) = True

:BCOUR_4904
if 
04A4:   872@ == 2 
else_jump @BCOUR_4966 
37@ = Object.Create(#KMB_PACKET, -2584.613, 60.3094, 3.9701)
Object.CollisionDetection(37@) = True
Object.ToggleInMovingList(37@) = True
014C: set_parked_car_generator " + carPark_2776 + @" cars_to_generate_to 0 
014C: set_parked_car_generator " + carPark_2778 + @" cars_to_generate_to 0 
014C: set_parked_car_generator " + carPark_2779 + @" cars_to_generate_to 0 

:BCOUR_4966
if 
04A4:   872@ == 3 
else_jump @BCOUR_5021 
37@ = Object.Create(#KMB_PACKET, 1884.329, 2078.721, 15.0869)
Object.CollisionDetection(37@) = True
Object.ToggleInMovingList(37@) = True

:BCOUR_5021
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
32@ = 0 
34@ = 1 
753@ = 0 
746@ = 1 

:BCOUR_5065
if 
  34@ == 1 
else_jump @BCOUR_5120 
if 
  32@ > 7000 
else_jump @BCOUR_5120 
34@ = 0 
03E5: show_text_box 'BCOU_84'  

:BCOUR_5120
if 
  746@ == 1 
else_jump @BCOUR_5824 
755@ = 4 
758@ = 3 
756@ = 3 
744@ = 0 
759@ = 0 
" + _8265 + @" = 6 
861@ = 0 
867@ = 0 

:BCOUR_5194
if 
  7 > 861@ 
else_jump @BCOUR_5237 
797@(861@,30i) = 0 
861@ += 1 
jump @BCOUR_5194 

:BCOUR_5237
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_5824 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_5824 
if 
04A4:   872@ == 2 
else_jump @BCOUR_5435 

:BCOUR_5290
if 
001D:   758@ > 744@ 
else_jump @BCOUR_5435 
018A: 42@(744@,30i) = create_checkpoint_at 103@(744@,30f) 133@(744@,30f) 163@(744@,30f) 
0087: 713@(744@,30f) = 163@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) point_to 0.0 0.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_5290 

:BCOUR_5435
if 
04A4:   872@ == 1 
else_jump @BCOUR_5598 

:BCOUR_5453
if 
001D:   758@ > 744@ 
else_jump @BCOUR_5598 
018A: 42@(744@,30i) = create_checkpoint_at 193@(744@,30f) 223@(744@,30f) 253@(744@,30f) 
0087: 713@(744@,30f) = 253@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) point_to -2000.0 -2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_5453 

:BCOUR_5598
if 
04A4:   872@ == 3 
else_jump @BCOUR_5761 

:BCOUR_5616
if 
001D:   758@ > 744@ 
else_jump @BCOUR_5761 
018A: 42@(744@,30i) = create_checkpoint_at 283@(744@,30f) 313@(744@,30f) 343@(744@,30f) 
0087: 713@(744@,30f) = 343@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) point_to -2000.0 2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_5616 

:BCOUR_5761
747@ = 0 
746@ = 9 
757@ = 0 
" + _8264 + @" = 180000 
03C4: set_status_text " + _8265 + @" type 0 GXT 'BCOU_83' 
03C3: set_timer_to " + _8264 + @" type 1 GXT 'BCOU_34' 

:BCOUR_5824
if 
  746@ == 2 
else_jump @BCOUR_6528 
755@ = 8 
758@ = 7 
756@ = 4 
744@ = 3 
759@ = 3 
" + _8265 + @" = 6 
861@ = 0 
867@ = 0 

:BCOUR_5898
if 
  7 > 861@ 
else_jump @BCOUR_5941 
797@(861@,30i) = 0 
861@ += 1 
jump @BCOUR_5898 

:BCOUR_5941
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_6528 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_6528 
if 
04A4:   872@ == 2 
else_jump @BCOUR_6139 

:BCOUR_5994
if 
001D:   758@ > 744@ 
else_jump @BCOUR_6139 
018A: 42@(744@,30i) = create_checkpoint_at 103@(744@,30f) 133@(744@,30f) 163@(744@,30f) 
0087: 713@(744@,30f) = 163@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) point_to 0.0 0.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_5994 

:BCOUR_6139
if 
04A4:   872@ == 1 
else_jump @BCOUR_6302 

:BCOUR_6157
if 
001D:   758@ > 744@ 
else_jump @BCOUR_6302 
018A: 42@(744@,30i) = create_checkpoint_at 193@(744@,30f) 223@(744@,30f) 253@(744@,30f) 
0087: 713@(744@,30f) = 253@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) point_to -2000.0 -2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_6157 

:BCOUR_6302
if 
04A4:   872@ == 3 
else_jump @BCOUR_6465 

:BCOUR_6320
if 
001D:   758@ > 744@ 
else_jump @BCOUR_6465 
018A: 42@(744@,30i) = create_checkpoint_at 283@(744@,30f) 313@(744@,30f) 343@(744@,30f) 
0087: 713@(744@,30f) = 343@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) point_to -2000.0 2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_6320 

:BCOUR_6465
747@ = 0 
746@ = 9 
757@ = 0 
" + _8264 + @" = 300000 
03C4: set_status_text " + _8265 + @" type 0 GXT 'BCOU_83' 
03C3: set_timer_to " + _8264 + @" type 1 GXT 'BCOU_34' 

:BCOUR_6528
if 
  746@ == 3 
else_jump @BCOUR_7232 
755@ = 13 
758@ = 12 
756@ = 5 
744@ = 7 
759@ = 7 
" + _8265 + @" = 7 
861@ = 0 
867@ = 0 

:BCOUR_6602
if 
  8 > 861@ 
else_jump @BCOUR_6645 
797@(861@,30i) = 0 
861@ += 1 
jump @BCOUR_6602 

:BCOUR_6645
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_7232 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_7232 
if 
04A4:   872@ == 2 
else_jump @BCOUR_6843 

:BCOUR_6698
if 
001D:   758@ > 744@ 
else_jump @BCOUR_6843 
018A: 42@(744@,30i) = create_checkpoint_at 103@(744@,30f) 133@(744@,30f) 163@(744@,30f) 
0087: 713@(744@,30f) = 163@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) point_to 0.0 0.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_6698 

:BCOUR_6843
if 
04A4:   872@ == 1 
else_jump @BCOUR_7006 

:BCOUR_6861
if 
001D:   758@ > 744@ 
else_jump @BCOUR_7006 
018A: 42@(744@,30i) = create_checkpoint_at 193@(744@,30f) 223@(744@,30f) 253@(744@,30f) 
0087: 713@(744@,30f) = 253@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) point_to -2000.0 -2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_6861 

:BCOUR_7006
if 
04A4:   872@ == 3 
else_jump @BCOUR_7169 

:BCOUR_7024
if 
001D:   758@ > 744@ 
else_jump @BCOUR_7169 
018A: 42@(744@,30i) = create_checkpoint_at 283@(744@,30f) 313@(744@,30f) 343@(744@,30f) 
0087: 713@(744@,30f) = 343@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) point_to -2000.0 2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_7024 

:BCOUR_7169
747@ = 0 
746@ = 9 
757@ = 0 
" + _8264 + @" = 300000 
03C4: set_status_text " + _8265 + @" type 0 GXT 'BCOU_83' 
03C3: set_timer_to " + _8264 + @" type 1 GXT 'BCOU_34' 

:BCOUR_7232
if 
  746@ == 4 
else_jump @BCOUR_8010 
755@ = 19 
758@ = 18 
756@ = 6 
744@ = 12 
759@ = 12 
" + _8265 + @" = 8 
861@ = 0 
867@ = 0 

:BCOUR_7306
if 
  9 > 861@ 
else_jump @BCOUR_7349 
797@(861@,30i) = 0 
861@ += 1 
jump @BCOUR_7306 

:BCOUR_7349
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_8010 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_8010 
if 
04A4:   872@ == 2 
else_jump @BCOUR_7547 

:BCOUR_7402
if 
001D:   758@ > 744@ 
else_jump @BCOUR_7547 
018A: 42@(744@,30i) = create_checkpoint_at 103@(744@,30f) 133@(744@,30f) 163@(744@,30f) 
0087: 713@(744@,30f) = 163@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) point_to 0.0 0.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_7402 

:BCOUR_7547
if 
04A4:   872@ == 1 
else_jump @BCOUR_7710 

:BCOUR_7565
if 
001D:   758@ > 744@ 
else_jump @BCOUR_7710 
018A: 42@(744@,30i) = create_checkpoint_at 193@(744@,30f) 223@(744@,30f) 253@(744@,30f) 
0087: 713@(744@,30f) = 253@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) point_to -2000.0 -2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_7565 

:BCOUR_7710
if 
04A4:   872@ == 3 
else_jump @BCOUR_7873 

:BCOUR_7728
if 
001D:   758@ > 744@ 
else_jump @BCOUR_7873 
018A: 42@(744@,30i) = create_checkpoint_at 283@(744@,30f) 313@(744@,30f) 343@(744@,30f) 
0087: 713@(744@,30f) = 343@(744@,30f) 
713@(744@,30f) += 2.2 
06D5: 683@(744@,30i) = create_racing_checkpoint_at 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) point_to -2000.0 2000.0 0.0 type 4 radius 1.8 
744@ += 1 
jump @BCOUR_7728 

:BCOUR_7873
747@ = 0 
746@ = 9 
757@ = 0 
if 
04A4:   872@ == 1 
else_jump @BCOUR_7922 
" + _8264 + @" = 600000 

:BCOUR_7922
if 
04A4:   872@ == 2 
else_jump @BCOUR_7950 
" + _8264 + @" = 420000 

:BCOUR_7950
if 
04A4:   872@ == 3 
else_jump @BCOUR_7978 
" + _8264 + @" = 480000 

:BCOUR_7978
03C4: set_status_text " + _8265 + @" type 0 GXT 'BCOU_83' 
03C3: set_timer_to " + _8264 + @" type 1 GXT 'BCOU_34' 

:BCOUR_8010
if 
  746@ == 9 
else_jump @BCOUR_9618 
if 
  867@ == 0 
else_jump @BCOUR_8110 
if 
   not Actor.Dead(38@)
else_jump @BCOUR_8110 
if 
8104:   not actor " + PlayerActor + @" near_actor 38@ radius 100.0 100.0 100.0 sphere 0 
else_jump @BCOUR_8110 
Actor.DestroyInstantly(38@)
867@ = 1 

:BCOUR_8110
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_9618 
if 
  747@ == 0 
else_jump @BCOUR_8361 
if 
00E1:   player 0 pressed_key 7 
else_jump @BCOUR_8199 
if 
00E1:   player 0 pressed_key 17 
else_jump @BCOUR_8199 
879@ = 0 
gosub @BCOUR_12131 
gosub @BCOUR_14247 

:BCOUR_8199
if 
00E1:   player 0 pressed_key 5 
else_jump @BCOUR_8254 
if 
00E1:   player 0 pressed_key 17 
else_jump @BCOUR_8254 
879@ = 0 
gosub @BCOUR_13189 
gosub @BCOUR_14247 

:BCOUR_8254
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_8361 
if 
   not Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_8361 
40@ = Marker.CreateAboveCar(36@)
07E0: set_marker 40@ type_to 1 

:BCOUR_8304
if 
001D:   755@ > 744@ 
else_jump @BCOUR_8346 
Marker.Disable(42@(744@,30i))
744@ += 1 
jump @BCOUR_8304 

:BCOUR_8346
0085: 744@ = 759@ 
747@ = 1 

:BCOUR_8361
if 
  747@ == 1 
else_jump @BCOUR_8617 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_8617 
Marker.Disable(40@)

:BCOUR_8403
if 
001D:   758@ > 744@ 
else_jump @BCOUR_8602 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_8588 
if 
04A4:   872@ == 2 
else_jump @BCOUR_8492 
018A: 42@(744@,30i) = create_checkpoint_at 103@(744@,30f) 133@(744@,30f) 163@(744@,30f) 

:BCOUR_8492
if 
04A4:   872@ == 1 
else_jump @BCOUR_8540 
018A: 42@(744@,30i) = create_checkpoint_at 193@(744@,30f) 223@(744@,30f) 253@(744@,30f) 

:BCOUR_8540
if 
04A4:   872@ == 3 
else_jump @BCOUR_8588 
018A: 42@(744@,30i) = create_checkpoint_at 283@(744@,30f) 313@(744@,30f) 343@(744@,30f) 

:BCOUR_8588
744@ += 1 
jump @BCOUR_8403 

:BCOUR_8602
747@ = 0 
0085: 744@ = 759@ 

:BCOUR_8617
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_9541 
if 
04A4:   872@ == 2 
else_jump @BCOUR_8935 

:BCOUR_8654
if 
001D:   758@ > 744@ 
else_jump @BCOUR_8935 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_8921 
if 
03CA:   object 763@(793@,30i) exists 
else_jump @BCOUR_8921 
if 
04E6:   object 763@(793@,30i) near_point 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) radius 0.7 1.7 3.0 flag 0 
else_jump @BCOUR_8921 
Marker.Disable(42@(744@,30i))
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))
0623: add 1 to_integer_stat 154 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
06D6: disable_racing_checkpoint 683@(744@,30i) 
653@(744@,30i) = 1 
757@ += 1 
if 
003B:   757@ == 756@ 
else_jump @BCOUR_8905 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_6' time 6000 flag 1  
746@ = 10 
jump @BCOUR_8921 

:BCOUR_8905
00BC: show_text_highpriority GXT 'BCOU_5' time 6000 flag 1  

:BCOUR_8921
744@ += 1 
jump @BCOUR_8654 

:BCOUR_8935
if 
04A4:   872@ == 1 
else_jump @BCOUR_9234 

:BCOUR_8953
if 
001D:   758@ > 744@ 
else_jump @BCOUR_9234 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_9220 
if 
03CA:   object 763@(793@,30i) exists 
else_jump @BCOUR_9220 
if 
04E6:   object 763@(793@,30i) near_point 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) radius 1.2 1.7 3.0 flag 0 
else_jump @BCOUR_9220 
Marker.Disable(42@(744@,30i))
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))
0623: add 1 to_integer_stat 154 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
06D6: disable_racing_checkpoint 683@(744@,30i) 
653@(744@,30i) = 1 
757@ += 1 
if 
003B:   757@ == 756@ 
else_jump @BCOUR_9204 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_6' time 6000 flag 1  
746@ = 10 
jump @BCOUR_9220 

:BCOUR_9204
00BC: show_text_highpriority GXT 'BCOU_5' time 6000 flag 1  

:BCOUR_9220
744@ += 1 
jump @BCOUR_8953 

:BCOUR_9234
if 
04A4:   872@ == 3 
else_jump @BCOUR_9533 

:BCOUR_9252
if 
001D:   758@ > 744@ 
else_jump @BCOUR_9533 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_9519 
if 
03CA:   object 763@(793@,30i) exists 
else_jump @BCOUR_9519 
if 
04E6:   object 763@(793@,30i) near_point 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) radius 1.2 1.7 3.0 flag 0 
else_jump @BCOUR_9519 
Marker.Disable(42@(744@,30i))
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))
0623: add 1 to_integer_stat 154 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
06D6: disable_racing_checkpoint 683@(744@,30i) 
653@(744@,30i) = 1 
757@ += 1 
if 
003B:   757@ == 756@ 
else_jump @BCOUR_9503 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_6' time 6000 flag 1  
746@ = 10 
jump @BCOUR_9519 

:BCOUR_9503
00BC: show_text_highpriority GXT 'BCOU_5' time 6000 flag 1  

:BCOUR_9519
744@ += 1 
jump @BCOUR_9252 

:BCOUR_9533
0085: 744@ = 759@ 

:BCOUR_9541
0085: 874@ = 756@ 
0062: 874@ -= 757@ 
008B: 873@ = " + _8265 + @" 
if 
03CA:   object 763@(793@,30i) exists 
else_jump @BCOUR_9592 
873@ += 1 

:BCOUR_9592
if 
001D:   874@ > 873@ 
else_jump @BCOUR_9618 
862@ = 1 

:BCOUR_9618
if 
  746@ > 8 
else_jump @BCOUR_9702 
if 
  25 > 746@ 
else_jump @BCOUR_9702 
if 
  1 > " + _8264 + @" 
else_jump @BCOUR_9702 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_33' time 6000 flag 1  
014F: stop_timer " + _8264 + @" 
jump @BCOUR_14327 

:BCOUR_9702
if 
  746@ == 10 
else_jump @BCOUR_9859 
746@ = 20 
if 
04A4:   872@ == 2 
else_jump @BCOUR_9771 
018A: 72@ = create_checkpoint_at 383@(745@,30f) 413@(745@,30f) 443@(745@,30f) 

:BCOUR_9771
if 
04A4:   872@ == 1 
else_jump @BCOUR_9815 
018A: 72@ = create_checkpoint_at 473@(745@,30f) 503@(745@,30f) 533@(745@,30f) 

:BCOUR_9815
if 
04A4:   872@ == 3 
else_jump @BCOUR_9859 
018A: 72@ = create_checkpoint_at 563@(745@,30f) 593@(745@,30f) 623@(745@,30f) 

:BCOUR_9859
if 
  746@ == 20 
else_jump @BCOUR_10610 
077E: get_active_interior_to 35@ 
if 
  35@ == 0 
else_jump @BCOUR_9920 
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @BCOUR_9920 
Player.CanMove(" + PlayerChar + @") = True

:BCOUR_9920
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_10610 
if 
  747@ == 0 
else_jump @BCOUR_10000 
if 
   not Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_10000 
40@ = Marker.CreateAboveCar(36@)
07E0: set_marker 40@ type_to 1 
Marker.Disable(72@)
747@ = 1 

:BCOUR_10000
if 
  747@ == 1 
else_jump @BCOUR_10181 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_10181 
Marker.Disable(40@)
if 
04A4:   872@ == 2 
else_jump @BCOUR_10086 
018A: 72@ = create_checkpoint_at 383@(745@,30f) 413@(745@,30f) 443@(745@,30f) 

:BCOUR_10086
if 
04A4:   872@ == 3 
else_jump @BCOUR_10130 
018A: 72@ = create_checkpoint_at 563@(745@,30f) 593@(745@,30f) 623@(745@,30f) 

:BCOUR_10130
if 
04A4:   872@ == 1 
else_jump @BCOUR_10174 
018A: 72@ = create_checkpoint_at 473@(745@,30f) 503@(745@,30f) 533@(745@,30f) 

:BCOUR_10174
747@ = 0 

:BCOUR_10181
if 
04A4:   872@ == 2 
else_jump @BCOUR_10324 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_10324 
if 
0100:   actor " + PlayerActor + @" in_sphere 383@(745@,30f) 413@(745@,30f) 443@(745@,30f) radius 4.0 4.0 4.0 sphere 1 in_car 
else_jump @BCOUR_10324 
Player.CanMove(" + PlayerChar + @") = False
if 
01C1:   car 36@ stopped 
else_jump @BCOUR_10324 
Marker.Disable(72@)
014F: stop_timer " + _8264 + @" 
0151: remove_status_text " + _8265 + @" 
760@ += 1 
746@ = 50 

:BCOUR_10324
if 
04A4:   872@ == 1 
else_jump @BCOUR_10467 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_10467 
if 
0100:   actor " + PlayerActor + @" in_sphere 473@(745@,30f) 503@(745@,30f) 533@(745@,30f) radius 4.0 4.0 4.0 sphere 1 in_car 
else_jump @BCOUR_10467 
Player.CanMove(" + PlayerChar + @") = False
if 
01C1:   car 36@ stopped 
else_jump @BCOUR_10467 
Marker.Disable(72@)
014F: stop_timer " + _8264 + @" 
0151: remove_status_text " + _8265 + @" 
761@ += 1 
746@ = 50 

:BCOUR_10467
if 
04A4:   872@ == 3 
else_jump @BCOUR_10610 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_10610 
if 
0100:   actor " + PlayerActor + @" in_sphere 563@(745@,30f) 593@(745@,30f) 623@(745@,30f) radius 4.0 4.0 4.0 sphere 1 in_car 
else_jump @BCOUR_10610 
Player.CanMove(" + PlayerChar + @") = False
if 
01C1:   car 36@ stopped 
else_jump @BCOUR_10610 
Marker.Disable(72@)
014F: stop_timer " + _8264 + @" 
0151: remove_status_text " + _8265 + @" 
762@ += 1 
746@ = 50 

:BCOUR_10610
if 
  746@ == 50 
else_jump @BCOUR_11169 
Player.CanMove(" + PlayerChar + @") = True
868@ = 0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BCOU_12' time 4000 flag 1  
if 
04A4:   872@ == 1 
else_jump @BCOUR_10738 
08D4: 863@ = create_panel_with_title 'BCOU_81' position 31.0 80.0 width 99.0 columns 2 interactive 0 background 1 alignment 1  
008B: 869@ = " + _8264 + @" 
869@ /= 100 
006A: 869@ *= 761@ 

:BCOUR_10738
if 
04A4:   872@ == 3 
else_jump @BCOUR_10816 
08D4: 863@ = create_panel_with_title 'BCOU_82' position 31.0 80.0 width 99.0 columns 2 interactive 0 background 1 alignment 1  
008B: 869@ = " + _8264 + @" 
869@ /= 100 
006A: 869@ *= 762@ 

:BCOUR_10816
if 
04A4:   872@ == 2 
else_jump @BCOUR_10894 
08D4: 863@ = create_panel_with_title 'BCOU_80' position 31.0 80.0 width 99.0 columns 2 interactive 0 background 1 alignment 1  
008B: 869@ = " + _8264 + @" 
869@ /= 100 
006A: 869@ *= 760@ 

:BCOUR_10894
08DB: set_panel 863@ column 0 header 'BCOU_21' data 'BCOU_22' 'BCOU_23' 'BCOU_24' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel 863@ column 1 alignment 2 
865@ = 0 
008B: 870@ = " + _8265 + @" 
870@ *= 100 
0085: 871@ = 869@ 
005A: 871@ += 870@ 
08EE: set_panel 863@ column 1 row 0 text_1number GXT 'DOLLAR' number 869@  
08EE: set_panel 863@ column 1 row 1 text_1number GXT 'DOLLAR' number 870@  
08EE: set_panel 863@ column 1 row 2 text_1number GXT 'DOLLAR' number 871@  
090E: set_panel 863@ active_row 2 
32@ = 0 
866@ = 1 
Player.Money(" + PlayerChar + @") += 871@
Object.Destroy(37@)
746@ = 55 

:BCOUR_11169
if 
  866@ == 1 
else_jump @BCOUR_11391 
if 
  32@ > 2000 
else_jump @BCOUR_11213 
868@ = 1 

:BCOUR_11213
if 
  761@ == 4 
else_jump @BCOUR_11262 
if 
  32@ > 4000 
else_jump @BCOUR_11262 
08DA: remove_panel 863@ 
866@ = 2 

:BCOUR_11262
if 
  760@ == 4 
else_jump @BCOUR_11311 
if 
  32@ > 4000 
else_jump @BCOUR_11311 
08DA: remove_panel 863@ 
866@ = 2 

:BCOUR_11311
if 
  762@ == 4 
else_jump @BCOUR_11360 
if 
  32@ > 4000 
else_jump @BCOUR_11360 
08DA: remove_panel 863@ 
866@ = 2 

:BCOUR_11360
if 
  32@ > 6000 
else_jump @BCOUR_11391 
08DA: remove_panel 863@ 
866@ = 2 

:BCOUR_11391
if 
  866@ == 2 
else_jump @BCOUR_12009 
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_12009 
if 
   Actor.InCar(" + PlayerActor + @", 36@)
else_jump @BCOUR_12009 
08DA: remove_panel 863@ 
868@ = 0 
if 
04A4:   872@ == 2 
else_jump @BCOUR_11638 
00BE: text_clear_all 
Player.CanMove(" + PlayerChar + @") = True
if 
  760@ == 1 
else_jump @BCOUR_11524 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 2 

:BCOUR_11524
if 
  760@ == 2 
else_jump @BCOUR_11565 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 3 

:BCOUR_11565
if 
  760@ == 3 
else_jump @BCOUR_11606 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 4 

:BCOUR_11606
if 
  760@ == 4 
else_jump @BCOUR_11638 
jump @BCOUR_15206 
746@ = 5 

:BCOUR_11638
if 
04A4:   872@ == 1 
else_jump @BCOUR_11820 
00BE: text_clear_all 
Player.CanMove(" + PlayerChar + @") = True
if 
  761@ == 1 
else_jump @BCOUR_11706 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 2 

:BCOUR_11706
if 
  761@ == 2 
else_jump @BCOUR_11747 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 3 

:BCOUR_11747
if 
  761@ == 3 
else_jump @BCOUR_11788 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 4 

:BCOUR_11788
if 
  761@ == 4 
else_jump @BCOUR_11820 
jump @BCOUR_15206 
746@ = 5 

:BCOUR_11820
if 
04A4:   872@ == 3 
else_jump @BCOUR_12002 
00BE: text_clear_all 
Player.CanMove(" + PlayerChar + @") = True
if 
  762@ == 1 
else_jump @BCOUR_11888 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 2 

:BCOUR_11888
if 
  762@ == 2 
else_jump @BCOUR_11929 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 3 

:BCOUR_11929
if 
  762@ == 3 
else_jump @BCOUR_11970 
00BC: show_text_highpriority GXT 'BCOU_4' time 6000 flag 1  
746@ = 4 

:BCOUR_11970
if 
  762@ == 4 
else_jump @BCOUR_12002 
jump @BCOUR_15206 
746@ = 5 

:BCOUR_12002
866@ = 0 

:BCOUR_12009
if 
03CA:   object 763@(793@,30i) exists 
else_jump @BCOUR_12124 
if 
0474:   actor " + PlayerActor + @" near_object_in_cube 763@(793@,30i) radius 1.5 1.5 1.5 sphere 0 
else_jump @BCOUR_12124 
if 
  32@ > 3000 
else_jump @BCOUR_12124 
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))
" + _8265 + @" += 1 
797@(" + _8265 + @",30i) = 0 

:BCOUR_12124
jump @BCOUR_2555 

:BCOUR_12131
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_13187 
if 
  " + _8265 + @" > 0 
else_jump @BCOUR_13187 
if 
  797@(" + _8265 + @",30i) == 0 
else_jump @BCOUR_13187 
if 
  857@ > 0 
else_jump @BCOUR_12223 
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))

:BCOUR_12223
if 
04A4:   872@ == 1 
else_jump @BCOUR_12404 

:BCOUR_12241
if 
001D:   758@ > 744@ 
else_jump @BCOUR_12389 
if 
  880@ == 0 
else_jump @BCOUR_12375 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_12375 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) radius 5.0 5.0 5.0 
else_jump @BCOUR_12375 
880@ = 1 
879@ = 1 
jump @BCOUR_12375 

:BCOUR_12375
744@ += 1 
jump @BCOUR_12241 

:BCOUR_12389
0085: 744@ = 759@ 
880@ = 0 

:BCOUR_12404
if 
04A4:   872@ == 2 
else_jump @BCOUR_12585 

:BCOUR_12422
if 
001D:   758@ > 744@ 
else_jump @BCOUR_12570 
if 
  880@ == 0 
else_jump @BCOUR_12556 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_12556 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) radius 5.0 5.0 5.0 
else_jump @BCOUR_12556 
880@ = 1 
879@ = 1 
jump @BCOUR_12556 

:BCOUR_12556
744@ += 1 
jump @BCOUR_12422 

:BCOUR_12570
0085: 744@ = 759@ 
880@ = 0 

:BCOUR_12585
if 
04A4:   872@ == 3 
else_jump @BCOUR_12766 

:BCOUR_12603
if 
001D:   758@ > 744@ 
else_jump @BCOUR_12751 
if 
  880@ == 0 
else_jump @BCOUR_12737 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_12737 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) radius 5.0 5.0 5.0 
else_jump @BCOUR_12737 
880@ = 1 
879@ = 1 
jump @BCOUR_12737 

:BCOUR_12737
744@ += 1 
jump @BCOUR_12603 

:BCOUR_12751
0085: 744@ = 759@ 
880@ = 0 

:BCOUR_12766
Car.StorePos(36@, 876@, 877@, 878@)
763@(" + _8265 + @",30i) = Object.Init(#KMB_PACKET, 876@, 877@, 878@)
Object.CollisionDetection(763@(" + _8265 + @",30i)) = True
Object.ToggleInMovingList(763@(" + _8265 + @",30i)) = True
066D: 827@(" + _8265 + @",30i) = attach_particle ""COKE_PUFF"" to_object 763@(" + _8265 + @",30i) with_offset 0.0 0.0 0.5 type 1 
064C: make_particle 827@(" + _8265 + @",30i) visible 
Actor.StorePos(" + PlayerActor + @", 858@, 859@, 860@)
if 
  882@ == 2 
else_jump @BCOUR_12912 
03D1: play_wav 3 

:BCOUR_12912
if 
  879@ == 1 
else_jump @BCOUR_12964 
035C: place_object 763@(" + _8265 + @",30i) relative_to_car 36@ with_offset -1.0 0.0 1.3 
jump @BCOUR_12991 

:BCOUR_12964
035C: place_object 763@(" + _8265 + @",30i) relative_to_car 36@ with_offset 0.0 0.0 0.7 

:BCOUR_12991
794@ = Actor.Angle(" + PlayerActor + @")
795@ -= 30.0 
796@ -= 30.0 
02F7: 795@ = cosine 794@ 
02F6: 796@ = sine 794@ 
if 
  879@ == 1 
else_jump @BCOUR_13100 
795@ *= 15.0 
796@ *= 15.0 
038C: object 763@(" + _8265 + @",30i) scatter 795@ 796@ 1.0 
jump @BCOUR_13140 

:BCOUR_13100
795@ *= 30.0 
796@ *= 30.0 
038C: object 763@(" + _8265 + @",30i) scatter 795@ 796@ 8.5 

:BCOUR_13140
879@ = 0 
857@ += 1 
797@(" + _8265 + @",30i) = 1 
008B: 793@ = " + _8265 + @" 
" + _8265 + @" -= 1 
32@ = 0 

:BCOUR_13187
return 

:BCOUR_13189
if 
  " + _8265 + @" > 0 
else_jump @BCOUR_14245 
if 
   not Car.Wrecked(36@)
else_jump @BCOUR_14245 
if 
  797@(" + _8265 + @",30i) == 0 
else_jump @BCOUR_14245 
if 
  857@ > 0 
else_jump @BCOUR_13281 
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))

:BCOUR_13281
if 
04A4:   872@ == 1 
else_jump @BCOUR_13462 

:BCOUR_13299
if 
001D:   758@ > 744@ 
else_jump @BCOUR_13447 
if 
  880@ == 0 
else_jump @BCOUR_13433 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_13433 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 193@(744@,30f) 223@(744@,30f) 713@(744@,30f) radius 5.0 5.0 5.0 
else_jump @BCOUR_13433 
880@ = 1 
879@ = 1 
jump @BCOUR_13433 

:BCOUR_13433
744@ += 1 
jump @BCOUR_13299 

:BCOUR_13447
0085: 744@ = 759@ 
880@ = 0 

:BCOUR_13462
if 
04A4:   872@ == 2 
else_jump @BCOUR_13643 

:BCOUR_13480
if 
001D:   758@ > 744@ 
else_jump @BCOUR_13628 
if 
  880@ == 0 
else_jump @BCOUR_13614 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_13614 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 103@(744@,30f) 133@(744@,30f) 713@(744@,30f) radius 5.0 5.0 5.0 
else_jump @BCOUR_13614 
880@ = 1 
879@ = 1 
jump @BCOUR_13614 

:BCOUR_13614
744@ += 1 
jump @BCOUR_13480 

:BCOUR_13628
0085: 744@ = 759@ 
880@ = 0 

:BCOUR_13643
if 
04A4:   872@ == 3 
else_jump @BCOUR_13824 

:BCOUR_13661
if 
001D:   758@ > 744@ 
else_jump @BCOUR_13809 
if 
  880@ == 0 
else_jump @BCOUR_13795 
if 
  653@(744@,30i) == 0 
else_jump @BCOUR_13795 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 283@(744@,30f) 313@(744@,30f) 713@(744@,30f) radius 5.0 5.0 5.0 
else_jump @BCOUR_13795 
880@ = 1 
879@ = 1 
jump @BCOUR_13795 

:BCOUR_13795
744@ += 1 
jump @BCOUR_13661 

:BCOUR_13809
0085: 744@ = 759@ 
880@ = 0 

:BCOUR_13824
Car.StorePos(36@, 876@, 877@, 878@)
763@(" + _8265 + @",30i) = Object.Init(#KMB_PACKET, 876@, 877@, 878@)
Object.CollisionDetection(763@(" + _8265 + @",30i)) = True
Object.ToggleInMovingList(763@(" + _8265 + @",30i)) = True
066D: 827@(" + _8265 + @",30i) = attach_particle ""COKE_PUFF"" to_object 763@(" + _8265 + @",30i) with_offset 0.0 0.0 0.0 type 1 
064C: make_particle 827@(" + _8265 + @",30i) visible 
Actor.StorePos(" + PlayerActor + @", 858@, 859@, 860@)
if 
  882@ == 2 
else_jump @BCOUR_13970 
03D1: play_wav 3 

:BCOUR_13970
if 
  879@ == 1 
else_jump @BCOUR_14022 
035C: place_object 763@(" + _8265 + @",30i) relative_to_car 36@ with_offset 1.0 0.0 1.3 
jump @BCOUR_14049 

:BCOUR_14022
035C: place_object 763@(" + _8265 + @",30i) relative_to_car 36@ with_offset 0.0 0.0 0.7 

:BCOUR_14049
794@ = Actor.Angle(" + PlayerActor + @")
795@ -= 330.0 
796@ -= 330.0 
02F7: 795@ = cosine 794@ 
02F6: 796@ = sine 794@ 
if 
  879@ == 1 
else_jump @BCOUR_14158 
795@ *= -15.0 
796@ *= -15.0 
038C: object 763@(" + _8265 + @",30i) scatter 795@ 796@ 1.0 
jump @BCOUR_14198 

:BCOUR_14158
795@ *= -30.0 
796@ *= -30.0 
038C: object 763@(" + _8265 + @",30i) scatter 795@ 796@ 8.5 

:BCOUR_14198
879@ = 0 
857@ += 1 
797@(" + _8265 + @",30i) = 1 
008B: 793@ = " + _8265 + @" 
" + _8265 + @" -= 1 
32@ = 0 

:BCOUR_14245
return 

:BCOUR_14247
if 
00E1:   player 0 pressed_key 17 
else_jump @BCOUR_14275 
wait 0 
jump @BCOUR_14247 

:BCOUR_14275
return 

:BCOUR_14277
if 
  3000 > 33@ 
else_jump @BCOUR_14307 
wait 0 
jump @BCOUR_14277 

:BCOUR_14307
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))
return 

:BCOUR_14327
0501: set_player " + PlayerChar + @" driveby_mode 1 
if 
04A4:   872@ == 2 
else_jump @BCOUR_14624 
if 
  760@ == 0 
else_jump @BCOUR_14386 
00BA: show_text_styled GXT 'BCOU_40' time 5000 style 1  

:BCOUR_14386
if 
  760@ == 1 
else_jump @BCOUR_14420 
00BA: show_text_styled GXT 'BCOU_41' time 5000 style 1  

:BCOUR_14420
if 
  760@ == 2 
else_jump @BCOUR_14454 
00BA: show_text_styled GXT 'BCOU_42' time 5000 style 1  

:BCOUR_14454
if 
  760@ == 3 
else_jump @BCOUR_14488 
00BA: show_text_styled GXT 'BCOU_43' time 5000 style 1  

:BCOUR_14488
if 
  760@ == 4 
else_jump @BCOUR_14522 
00BA: show_text_styled GXT 'BCOU_44' time 5000 style 1  

:BCOUR_14522
if 
  760@ == 5 
else_jump @BCOUR_14556 
00BA: show_text_styled GXT 'BCOU_45' time 5000 style 1  

:BCOUR_14556
if 
  760@ == 6 
else_jump @BCOUR_14590 
00BA: show_text_styled GXT 'BCOU_46' time 5000 style 1  

:BCOUR_14590
if 
  760@ == 7 
else_jump @BCOUR_14624 
00BA: show_text_styled GXT 'BCOU_47' time 5000 style 1  

:BCOUR_14624
if 
04A4:   872@ == 3 
else_jump @BCOUR_14914 
if 
  762@ == 0 
else_jump @BCOUR_14676 
00BA: show_text_styled GXT 'BCOU_40' time 5000 style 1  

:BCOUR_14676
if 
  762@ == 1 
else_jump @BCOUR_14710 
00BA: show_text_styled GXT 'BCOU_41' time 5000 style 1  

:BCOUR_14710
if 
  762@ == 2 
else_jump @BCOUR_14744 
00BA: show_text_styled GXT 'BCOU_42' time 5000 style 1  

:BCOUR_14744
if 
  762@ == 3 
else_jump @BCOUR_14778 
00BA: show_text_styled GXT 'BCOU_43' time 5000 style 1  

:BCOUR_14778
if 
  762@ == 4 
else_jump @BCOUR_14812 
00BA: show_text_styled GXT 'BCOU_44' time 5000 style 1  

:BCOUR_14812
if 
  762@ == 5 
else_jump @BCOUR_14846 
00BA: show_text_styled GXT 'BCOU_45' time 5000 style 1  

:BCOUR_14846
if 
  762@ == 6 
else_jump @BCOUR_14880 
00BA: show_text_styled GXT 'BCOU_46' time 5000 style 1  

:BCOUR_14880
if 
  762@ == 7 
else_jump @BCOUR_14914 
00BA: show_text_styled GXT 'BCOU_47' time 5000 style 1  

:BCOUR_14914
if 
04A4:   872@ == 1 
else_jump @BCOUR_15204 
if 
  761@ == 0 
else_jump @BCOUR_14966 
00BA: show_text_styled GXT 'BCOU_40' time 5000 style 1  

:BCOUR_14966
if 
  761@ == 1 
else_jump @BCOUR_15000 
00BA: show_text_styled GXT 'BCOU_41' time 5000 style 1  

:BCOUR_15000
if 
  761@ == 2 
else_jump @BCOUR_15034 
00BA: show_text_styled GXT 'BCOU_42' time 5000 style 1  

:BCOUR_15034
if 
  761@ == 3 
else_jump @BCOUR_15068 
00BA: show_text_styled GXT 'BCOU_43' time 5000 style 1  

:BCOUR_15068
if 
  761@ == 4 
else_jump @BCOUR_15102 
00BA: show_text_styled GXT 'BCOU_44' time 5000 style 1  

:BCOUR_15102
if 
  761@ == 5 
else_jump @BCOUR_15136 
00BA: show_text_styled GXT 'BCOU_45' time 5000 style 1  

:BCOUR_15136
if 
  761@ == 6 
else_jump @BCOUR_15170 
00BA: show_text_styled GXT 'BCOU_46' time 5000 style 1  

:BCOUR_15170
if 
  761@ == 7 
else_jump @BCOUR_15204 
00BA: show_text_styled GXT 'BCOU_47' time 5000 style 1  

:BCOUR_15204
return 

:BCOUR_15206
040D: unload_wav 3 
if 
04A4:   872@ == 3 
else_jump @BCOUR_15560 
if 
  " + Mission_Courier_LV_Passed + @" == 0 
else_jump @BCOUR_15560 
0595: mission_complete 
" + Mission_Courier_LV_Passed + @" = 1" );
_2000.create( 1887.997, 2073.008, 10.5547, 2000, 2000 );
AppendLine( @"00BE: text_clear_all 
Player.CanMove(" + PlayerChar + @") = False
fade 0 500 

:BCOUR_15297
if 
fading 
else_jump @BCOUR_15321 
wait 0 
jump @BCOUR_15297 

:BCOUR_15321
02A3: enable_widescreen 1 
0A0B: set_rendering_origin_at_3D_coord 1895.53 2063.094 15.8639 angle 47.0 
Camera.SetPosition(1895.53, 2063.094, 15.8639, 0.0, 0.0, 0.0)
Camera.PointAt(1894.813, 2063.775, 15.7175, 2)
fade 1 500 

:BCOUR_15405
if 
fading 
else_jump @BCOUR_15429 
wait 0 
jump @BCOUR_15405 

:BCOUR_15429
0394: play_music 1 
00BA: show_text_styled GXT 'ASS_ACQ' time 5000 style 6  
wait 5000 
Camera.SetPosition(1890.164, 2070.478, 11.8641, 0.0, 0.0, 0.0)
Camera.PointAt(1889.516, 2071.213, 11.6633, 2)
01E5: show_text_1number_highpriority GXT 'ASS_LUV' number 2000 time 6000 flag 1  
wait 6000 
fade 0 500 

:BCOUR_15536
if 
fading 
else_jump @BCOUR_15560 
wait 0 
jump @BCOUR_15536 

:BCOUR_15560
if 
04A4:   872@ == 1 
else_jump @BCOUR_15910 
if 
  " + Mission_Courier_LS_Passed + @" == 0 
else_jump @BCOUR_15910 
0595: mission_complete 
" + Mission_Courier_LS_Passed + @" = 1" );
_1996.create( 1345.859, -1757.432, 13.0078, 2000, 2000 );
AppendLine( @"00BE: text_clear_all 
Player.CanMove(" + PlayerChar + @") = False
fade 0 500 

:BCOUR_15647
if 
fading 
else_jump @BCOUR_15671 
wait 0 
jump @BCOUR_15647 

:BCOUR_15671
02A3: enable_widescreen 1 
0A0B: set_rendering_origin_at_3D_coord 1358.596 -1741.184 18.431 angle 223.0 
Camera.SetPosition(1358.596, -1741.184, 18.431, 0.0, 0.0, 0.0)
Camera.PointAt(1358.372, -1742.135, 18.2203, 2)
fade 1 500 

:BCOUR_15755
if 
fading 
else_jump @BCOUR_15779 
wait 0 
jump @BCOUR_15755 

:BCOUR_15779
0394: play_music 1 
00BA: show_text_styled GXT 'ASS_ACQ' time 5000 style 6  
wait 5000 
Camera.SetPosition(1345.565, -1753.368, 15.2186, 0.0, 0.0, 0.0)
Camera.PointAt(1345.567, -1754.218, 14.692, 2)
01E5: show_text_1number_highpriority GXT 'ASS_LUV' number 2000 time 6000 flag 1  
wait 6000 
fade 0 500 

:BCOUR_15886
if 
fading 
else_jump @BCOUR_15910 
wait 0 
jump @BCOUR_15886 

:BCOUR_15910
if 
04A4:   872@ == 2 
else_jump @BCOUR_16260 
if 
  " + Mission_Courier_SF_Passed + @" == 0 
else_jump @BCOUR_16260 
0595: mission_complete 
" + Mission_Courier_SF_Passed + @" = 1" );
_1998.create( -2593.882, 59.2467, 3.8359, 2000, 2000 );
AppendLine( @"Player.CanMove(" + PlayerChar + @") = False
00BE: text_clear_all 
fade 0 500 

:BCOUR_15997
if 
fading 
else_jump @BCOUR_16021 
wait 0 
jump @BCOUR_15997 

:BCOUR_16021
02A3: enable_widescreen 1 
0A0B: set_rendering_origin_at_3D_coord -2603.114 51.3338 10.1663 angle 275.0 
Camera.SetPosition(-2603.98, 54.4522, 7.5275, 0.0, 0.0, 0.0)
Camera.PointAt(-2603.014, 54.7055, 7.4818, 2)
fade 1 500 

:BCOUR_16105
if 
fading 
else_jump @BCOUR_16129 
wait 0 
jump @BCOUR_16105 

:BCOUR_16129
0394: play_music 1 
00BA: show_text_styled GXT 'ASS_ACQ' time 5000 style 6  
wait 5000 
Camera.SetPosition(-2598.9, 59.0635, 4.8343, 0.0, 0.0, 0.0)
Camera.PointAt(-2597.905, 59.0525, 4.7405, 2)
01E5: show_text_1number_highpriority GXT 'ASS_LUV' number 2000 time 6000 flag 1  
wait 6000 
fade 0 500 

:BCOUR_16236
if 
fading 
else_jump @BCOUR_16260 
wait 0 
jump @BCOUR_16236 

:BCOUR_16260
Player.ClearWantedLevel(" + PlayerChar + @")
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
return 

:BCOUR_16271
03E6: remove_text_box 
040D: unload_wav 3 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @BCOUR_16307 
0501: set_player " + PlayerChar + @" driveby_mode 1 
Player.CanMove(" + PlayerChar + @") = True

:BCOUR_16307
014F: stop_timer " + _8264 + @" 
0151: remove_status_text " + _8265 + @" 
08DA: remove_panel 863@ 
Object.Destroy(37@)
0650: destroy_particle 827@(793@,30i) 
Object.Destroy(763@(793@,30i))
Actor.RemoveReferences(38@)
Model.Destroy(#WAYFARER)
Model.Destroy(#WMYDRUG)
04EF: release_animation ""SMOKING"" 
Marker.Disable(40@)
Marker.Disable(72@)
744@ = 0 

:BCOUR_16387
if 
  30 > 744@ 
else_jump @BCOUR_16428 
Marker.Disable(42@(744@,30i))
744@ += 1 
jump @BCOUR_16387 

:BCOUR_16428
014C: set_parked_car_generator " + carPark_2776 + @" cars_to_generate_to 101 
014C: set_parked_car_generator " + carPark_2778 + @" cars_to_generate_to 101 
014C: set_parked_car_generator " + carPark_2779 + @" cars_to_generate_to 101 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}