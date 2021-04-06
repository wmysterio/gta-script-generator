using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class PIMP : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @PIMP_47 
if 
wasted_or_busted 
else_jump @PIMP_38 
gosub @PIMP_37455 

:PIMP_38
gosub @PIMP_37866 
end_thread 

:PIMP_47
if 
  " + Mission_Pimping_Passed + @" == 0 
else_jump @PIMP_67 
increment_mission_attempts 

:PIMP_67
" + _162 + @" = 1 
" + OnMission + @" = 1 
wait 0 
wait 0 
054C: use_GXT_table 'PIMP' 
0169: set_fade_color_RGB 0 0 0 
fade 1 500 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @PIMP_138 
Player.CanMove(" + PlayerChar + @") = True

:PIMP_138
541@ = 0 
34@ = 0 
537@ = 0 
538@ = 0 
" + _8245 + @" = 0 
514@ = 0 
516@ = 0 
517@ = 0 
520@ = 0 
531@ = 0 
41@ = 0 
42@ = 0 
47@ = 0 
44@ = 0 
46@ = 0 
45@ = 0 
43@ = 0 
48@ = 0 
49@ = 0
147@ = 0 
52@ = 0 
56@ = 0 
55@ = 0 
511@ = 0 
512@ = 0 
37@ = 0 
521@ = 0 
525@ = 0 
524@ = 0 
523@ = 0 
57@ = 1 
175@ = 2286.79 
203@ = -2312.836 
231@ = 12.557 
259@ = 301.0 
176@ = 1537.268 
204@ = -2314.27 
232@ = 12.5469 
260@ = 280.2771 
177@ = 2307.903 
205@ = -1998.647 
233@ = 12.5529 
261@ = 321.3693 
178@ = 1239.282 
206@ = -1918.819 
234@ = 30.3478 
262@ = 284.1407 
179@ = 1685.32 
207@ = -1585.244 
235@ = 12.5469 
263@ = 233.3592 
180@ = 1749.745 
208@ = -1455.778 
236@ = 12.5547 
264@ = 8.5912 
181@ = 1959.539 
209@ = -1452.56 
237@ = 12.5495 
265@ = 186.4147 
182@ = 1793.708 
210@ = -1600.12 
238@ = 12.5387 
266@ = 74.0619 
183@ = 2259.703 
211@ = -1339.907 
239@ = 22.9832 
267@ = 267.1747 
184@ = 2350.009 
212@ = -1504.599 
240@ = 23.0 
268@ = 113.9031 
185@ = 2745.374 
213@ = -1188.68 
241@ = 68.3986 
269@ = 109.0182 
186@ = 2833.886 
214@ = -1585.979 
242@ = 10.086 
270@ = 223.6582 
187@ = 1282.429 
215@ = -1666.13 
243@ = 12.5547 
271@ = 202.373 
188@ = 899.8489 
216@ = -1823.877 
244@ = 11.2302 
272@ = 215.4203 
189@ = 447.2084 
217@ = -1761.314 
245@ = 4.7837 
273@ = 230.4552 
190@ = 765.7432 
218@ = -1541.32 
246@ = 12.5536 
274@ = 264.2591 
191@ = 1269.592 
219@ = -1560.462 
247@ = 12.5643 
275@ = 186.3764 
192@ = 557.9569 
220@ = -1509.402 
248@ = 13.5557 
276@ = 94.5521 
193@ = 434.0113 
221@ = -1555.667 
249@ = 26.5851 
277@ = 273.0415 
194@ = 403.0965 
222@ = -1256.665 
250@ = 51.2 
278@ = 29.0138 
195@ = 1147.13 
223@ = -898.4011 
251@ = 41.7814 
279@ = 234.2193 
196@ = 1020.802 
224@ = -911.898 
252@ = 41.2395 
280@ = 222.6945 
197@ = 828.6284 
225@ = -1056.445 
253@ = 24.2484 
281@ = 22.838 
198@ = 971.1776 
226@ = -1107.744 
254@ = 22.8672 
282@ = 83.3249 
199@ = 1893.362 
227@ = -1741.244 
255@ = 12.5468 
283@ = 177.218 
200@ = 2333.625 
228@ = -1764.659 
256@ = 12.5534 
284@ = 333.4691 
201@ = 1775.942 
229@ = -1895.623 
257@ = 12.3865 
285@ = 248.6633 
202@ = 1707.121 
230@ = -1804.755 
258@ = 12.5391 
286@ = 172.0678 
287@ = -2020.273 
315@ = 932.0927 
343@ = 44.5639 
371@ = 221.8539 
288@ = -2399.298 
316@ = 1071.83 
344@ = 54.7266 
372@ = 327.6848 
289@ = -2400.652 
317@ = 922.1189 
345@ = 44.4453 
373@ = 283.5361 
290@ = -2301.292 
318@ = 1373.105 
346@ = 6.1961 
374@ = 124.8329 
293@ = -2576.948 
321@ = 1144.234 
349@ = 54.7266 
377@ = 124.6449 
294@ = -2694.151 
322@ = 1204.628 
350@ = 54.1953 
378@ = 357.2611 
295@ = -2244.235 
323@ = 643.8406 
351@ = 48.4375 
379@ = 99.8674 
296@ = -1923.351 
324@ = 563.4099 
352@ = 34.1972 
380@ = 44.6685 
297@ = -1736.431 
325@ = 809.515 
353@ = 23.8904 
381@ = 333.3014 
298@ = -1504.571 
326@ = 1083.0 
354@ = 6.1846 
382@ = 156.5032 
299@ = -2400.051 
327@ = 556.1022 
355@ = 23.8906 
383@ = 18.535 
300@ = -2490.255 
328@ = 6.0292 
356@ = 24.6238 
384@ = 56.3408 
301@ = -2757.469 
329@ = 168.1762 
357@ = 6.0408 
385@ = 196.6891 
302@ = -2779.791 
330@ = -319.9682 
358@ = 6.1875 
386@ = 123.0427 
303@ = -2192.023 
331@ = 309.7259 
359@ = 34.1172 
387@ = 7.9069 
304@ = -2195.789 
332@ = 197.3115 
360@ = 34.3203 
388@ = 9.4354 
305@ = -2108.647 
333@ = 217.1542 
361@ = 34.3045 
389@ = 133.6119 
306@ = -1545.449 
334@ = 560.5441 
362@ = 6.1797 
390@ = 165.7533 
307@ = -2779.8 
335@ = -500.7523 
363@ = 6.2925 
391@ = 37.7744 
308@ = -1974.475 
336@ = -975.055 
364@ = 31.2266 
392@ = 138.4206 
309@ = -1587.119 
337@ = -482.9532 
365@ = 5.1484 
393@ = 117.5313 
310@ = -2838.112 
338@ = 846.8309 
366@ = 42.5804 
394@ = 288.0701 
311@ = -2566.241 
339@ = 918.7418 
367@ = 63.9765 
395@ = 178.9968 
312@ = -2601.591 
340@ = 688.1887 
368@ = 26.8125 
396@ = 34.6082 
313@ = -2758.551 
341@ = 394.18 
369@ = 3.3359 
397@ = 315.443 
399@ = 2009.313 
427@ = 1167.793 
455@ = 9.813 
483@ = 266.731 
400@ = 1959.998 
428@ = 945.6432 
456@ = 9.8203 
484@ = 225.7712 
401@ = 2202.737 
429@ = 1254.45 
457@ = 9.8203 
485@ = 110.1904 
402@ = 2186.84 
430@ = 998.9764 
458@ = 9.8203 
486@ = 202.3453 
403@ = 2031.976 
431@ = 1539.9 
459@ = 9.8203 
487@ = 224.9353 
404@ = 2139.462 
432@ = 1516.045 
460@ = 9.8203 
488@ = 351.7 
405@ = 2150.364 
433@ = 1675.969 
461@ = 9.8203 
489@ = 217.8727 
406@ = 1939.55 
434@ = 1389.756 
462@ = 8.2578 
490@ = 271.8136 
407@ = 2595.79 
435@ = 1793.637 
463@ = 9.9692 
491@ = 105.7608 
408@ = 2185.686 
436@ = 1885.912 
464@ = 9.8203 
492@ = 4.9185 
409@ = 2159.891 
437@ = 1931.016 
465@ = 9.8203 
493@ = 94.0854 
410@ = 2057.374 
438@ = 1957.522 
466@ = 10.7324 
494@ = 218.8441 
411@ = 2181.532 
439@ = 2353.484 
467@ = 9.8203 
495@ = 186.4606 
412@ = 2437.607 
440@ = 2376.581 
468@ = 9.8203 
496@ = 87.5329 
413@ = 2335.391 
441@ = 2076.146 
469@ = 9.8125 
497@ = 261.0065 
414@ = 2217.564 
442@ = 1787.844 
470@ = 9.8203 
498@ = 36.1247 
415@ = 1540.732 
443@ = 748.3782 
471@ = 9.8203 
499@ = 259.5982 
416@ = 1011.96 
444@ = 1104.625 
472@ = 9.8203 
500@ = 4.436 
417@ = 1723.904 
445@ = 1541.124 
473@ = 9.8203 
501@ = 317.5323 
418@ = 1958.822 
446@ = 706.9632 
474@ = 9.8199 
502@ = 216.0597 
" + _8246 + @" = 180000 
0395: clear_area 0 at 1918.988 -1791.854 12.3828 radius 30.0 
039E: set_actor " + PlayerActor + @" locked 1 while_in_car 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PIMP_3339 
jump @PIMP_37455 

:PIMP_3339
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @PIMP_3370 
40@ = Actor.MissionCar(" + PlayerActor + @")
jump @PIMP_3377 

:PIMP_3370
jump @PIMP_37455 

:PIMP_3377
if 
   not Car.Wrecked(40@)
else_jump @PIMP_3401 
Car.Health(40@) = 2000

:PIMP_3401
060A: create_decision_maker_type 0 store_to 518@ 
0746: set_acquaintance 1 of_actors_pedtype 7 to_actors_pedtype 0 
02DD: 35@(37@,2i) = get_random_ped_in_zone 'BLUFF' with_pedtype_civilian 1 gang 0 criminal/prostitute 1 
Actor.DestroyInstantly(35@(37@,2i))
02DD: 91@(51@,28i) = get_random_ped_in_zone 'BLUFF' with_pedtype_civilian 1 gang 0 criminal/prostitute 1 
Actor.DestroyInstantly(91@(51@,28i))
if 
  47@ == -13 
else_jump @PIMP_3521 
03C3: set_timer_to " + _8246 + @" type 1 GXT 'PIMP_90' 
014F: stop_timer " + _8246 + @" 

:PIMP_3521
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @PIMP_3545 
0842: 531@ = player " + PlayerChar + @" town_number 

:PIMP_3545
if 
84A4:   not  531@ == 1 
else_jump @PIMP_3765 
if 
84A4:   not  531@ == 2 
else_jump @PIMP_3765 
if 
84A4:   not  531@ == 3 
else_jump @PIMP_3765 
Actor.StorePos(" + PlayerActor + @", 532@, 533@, 534@)
050A: 536@ = distance_between_XYZ 532@ 533@ 534@ and_XYZ 200@ 228@ 256@ 
0087: 535@ = 536@ 
04AF: 531@ = 1 
050A: 536@ = distance_between_XYZ 532@ 533@ 534@ and_XYZ 287@ 315@ 343@ 
if 
0025:   535@ > 536@ 
else_jump @PIMP_3708 
0087: 535@ = 536@ 
04AF: 531@ = 2 

:PIMP_3708
050A: 536@ = distance_between_XYZ 532@ 533@ 534@ and_XYZ 399@ 427@ 455@ 
if 
0025:   535@ > 536@ 
else_jump @PIMP_3765 
0087: 535@ = 536@ 
04AF: 531@ = 3 

:PIMP_3765
wait 0 
if 
  541@ == 1 
else_jump @PIMP_3805 
040D: unload_wav 4 
03CF: load_wav 31400 as 4 
541@ = 2 

:PIMP_3805
if 
  541@ == 2 
else_jump @PIMP_3845 
if 
03D0:   wav 4 loaded 
else_jump @PIMP_3845 
541@ = 3 

:PIMP_3845
if 
  537@ == 1 
else_jump @PIMP_3906 
if 
  1 > " + _8246 + @" 
else_jump @PIMP_3906 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'PIMP_92' time 6000 flag 1  
jump @PIMP_37455 

:PIMP_3906
if 
  537@ == 2 
else_jump @PIMP_3967 
if 
  1 > " + _8246 + @" 
else_jump @PIMP_3967 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'PIMP_91' time 6000 flag 1  
jump @PIMP_37455 

:PIMP_3967
if 
0735:   is_keyboard_key_pressed 87 
else_jump @PIMP_3992 
" + _8246 + @" += 60000 

:PIMP_3992
if 
0735:   is_keyboard_key_pressed 81 
else_jump @PIMP_4015 
" + _8246 + @" -= 30000 

:PIMP_4015
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PIMP_4038 
jump @PIMP_37455 

:PIMP_4038
if 
   Car.Wrecked(40@)
else_jump @PIMP_4061 
jump @PIMP_37455 

:PIMP_4061
if 
0735:   is_keyboard_key_pressed 80 
else_jump @PIMP_4083 
Player.WantedLevel(" + PlayerChar + @") = 2

:PIMP_4083
if 
0735:   is_keyboard_key_pressed 79 
else_jump @PIMP_4105 
Player.WantedLevel(" + PlayerChar + @") = 0

:PIMP_4105
0293: " + _13 + @" = get_controller_mode 
if 
   not " + _13 + @" == 3 
else_jump @PIMP_4316 
if and
00E1:   player 0 pressed_key 19 
  " + _162 + @" == 1 
else_jump @PIMP_4309 
03EB: clear_small_messages_only 
00BC: show_text_highpriority GXT 'PIMP_59' time 6000 flag 1  
if 
   not Actor.Dead(35@)
else_jump @PIMP_4236 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_4231 
if 
0448:   actor 35@ in_car 40@ 
else_jump @PIMP_4231 
0687: clear_actor 35@ task 
0633: AS_actor 35@ exit_car 

:PIMP_4231
Actor.RemoveReferences(35@)

:PIMP_4236
if 
   not Actor.Dead(36@)
else_jump @PIMP_4302 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_4297 
if 
0448:   actor 36@ in_car 40@ 
else_jump @PIMP_4297 
0687: clear_actor 36@ task 
0633: AS_actor 36@ exit_car 

:PIMP_4297
Actor.RemoveReferences(36@)

:PIMP_4302
jump @PIMP_37316 

:PIMP_4309
jump @PIMP_4497 

:PIMP_4316
if and
00E1:   player 0 pressed_key 14 
  " + _162 + @" == 1 
else_jump @PIMP_4497 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'PIMP_59' time 6000 flag 1  
if 
   not Actor.Dead(35@)
else_jump @PIMP_4424 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_4419 
if 
0448:   actor 35@ in_car 40@ 
else_jump @PIMP_4419 
0687: clear_actor 35@ task 
0633: AS_actor 35@ exit_car 

:PIMP_4419
Actor.RemoveReferences(35@)

:PIMP_4424
if 
   not Actor.Dead(36@)
else_jump @PIMP_4490 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_4485 
if 
0448:   actor 36@ in_car 40@ 
else_jump @PIMP_4485 
0687: clear_actor 36@ task 
0633: AS_actor 36@ exit_car 

:PIMP_4485
Actor.RemoveReferences(36@)

:PIMP_4490
jump @PIMP_37316 

:PIMP_4497
530@ = 0 

:PIMP_4504
if 
  28 > 530@ 
else_jump @PIMP_4667 
if 
  119@(530@,28i) == 1 
else_jump @PIMP_4653 
if 
056D:   actor 91@(530@,28i) defined 
else_jump @PIMP_4653 
if 
051A:   actor 91@(530@,28i) damaged_by_actor " + PlayerActor + @" 
else_jump @PIMP_4610 
00BC: show_text_highpriority GXT 'PIMP_52' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_4610
if 
   Actor.Dead(91@(530@,28i))
else_jump @PIMP_4653 
00BC: show_text_highpriority GXT 'PIMP_52' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_4653
530@ += 1 
jump @PIMP_4504 

:PIMP_4667
if 
  516@ == 0 
else_jump @PIMP_4761 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_4761 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_4761 
33@ = 0 
517@ = 1 
008B: 515@ = " + _8246 + @" 
515@ /= 1000 
516@ = 1 
00BE: text_clear_all 
03E6: remove_text_box 

:PIMP_4761
if 
  516@ == 1 
else_jump @PIMP_4844 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_4844 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_4844 
33@ = 0 
516@ = 0 
517@ = 0 
538@ = 0 
00BE: text_clear_all 

:PIMP_4844
if 
  517@ == 1 
else_jump @PIMP_5127 
0085: 514@ = 33@ 
514@ /= 1000 
if 
  538@ == 0 
else_jump @PIMP_4929 
if and
  21000 > " + _8246 + @" 
  " + _8246 + @" > 1 
else_jump @PIMP_4929 
538@ = 1 

:PIMP_4929
if 
  538@ == 0 
else_jump @PIMP_4973 
if 
  " + _8246 + @" > 20099 
else_jump @PIMP_4973 
538@ = 2 

:PIMP_4973
if 
  538@ == 1 
else_jump @PIMP_5007 
0084: " + _8245 + @" = " + _8246 + @" 
" + _8245 + @" /= 1000 

:PIMP_5007
if 
  538@ == 2 
else_jump @PIMP_5040 
" + _8245 + @" = 20 
0066: " + _8245 + @" -= 514@ 

:PIMP_5040
00BE: text_clear_all 
if 
  " + _8245 + @" > 0 
else_jump @PIMP_5083 
09C1: add_next_text_to_brief_history 0 
01E5: show_text_1number_highpriority GXT 'PIMP_1' number " + _8245 + @" time 4000 flag 1  

:PIMP_5083
if 
  33@ > 21000 
else_jump @PIMP_5127 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'PIMP_59' time 6000 flag 1  
jump @PIMP_37455 

:PIMP_5127
if 
  41@ == -13 
else_jump @PIMP_5202 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 1954.348, -1867.164, 12.5391)
88@ = Marker.CreateAboveActor(35@(37@,2i))
89@ = Marker.CreateAboveActor(" + PlayerActor + @")
90@ = Marker.CreateAboveActor(" + PlayerActor + @")

:PIMP_5202
if 
  41@ == 0 
else_jump @PIMP_5234 
gosub @PIMP_35718 
41@ = 1 

:PIMP_5234
if 
  41@ == 1 
else_jump @PIMP_11866 
if 
04A4:   531@ == 1 
else_jump @PIMP_7643 
Model.Load(#BFYPRO)
Model.Load(#HFYPRO)

:PIMP_5278
if or
   not Model.Available(#BFYPRO)
   not Model.Available(#HFYPRO)
else_jump @PIMP_5308 
wait 0 
jump @PIMP_5278 

:PIMP_5308
if 
  42@ == 0 
else_jump @PIMP_5392 
if 
0154:   actor " + PlayerActor + @" in_zone 'IWD'  
else_jump @PIMP_5392 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 202@, 230@, 258@)
Actor.Angle(35@(37@,2i)) = 286@
gosub @PIMP_35590 

:PIMP_5392
if 
  42@ == 0 
else_jump @PIMP_5476 
if 
0154:   actor " + PlayerActor + @" in_zone 'GAN'  
else_jump @PIMP_5476 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 201@, 229@, 257@)
Actor.Angle(35@(37@,2i)) = 285@
gosub @PIMP_35590 

:PIMP_5476
if 
  42@ == 0 
else_jump @PIMP_5560 
if 
0154:   actor " + PlayerActor + @" in_zone 'ELCO'  
else_jump @PIMP_5560 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 200@, 228@, 256@)
Actor.Angle(35@(37@,2i)) = 284@
gosub @PIMP_35590 

:PIMP_5560
if 
  42@ == 0 
else_jump @PIMP_5644 
if 
0154:   actor " + PlayerActor + @" in_zone 'LMEX'  
else_jump @PIMP_5644 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 199@, 227@, 255@)
Actor.Angle(35@(37@,2i)) = 283@
gosub @PIMP_35590 

:PIMP_5644
if 
  42@ == 0 
else_jump @PIMP_5728 
if 
0154:   actor " + PlayerActor + @" in_zone 'LDOC'  
else_jump @PIMP_5728 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 176@, 204@, 232@)
Actor.Angle(35@(37@,2i)) = 260@
gosub @PIMP_35590 

:PIMP_5728
if 
  42@ == 0 
else_jump @PIMP_5812 
if 
0154:   actor " + PlayerActor + @" in_zone 'LAIR'  
else_jump @PIMP_5812 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 177@, 205@, 233@)
Actor.Angle(35@(37@,2i)) = 261@
gosub @PIMP_35590 

:PIMP_5812
if 
  42@ == 0 
else_jump @PIMP_5896 
if 
0154:   actor " + PlayerActor + @" in_zone 'LIND'  
else_jump @PIMP_5896 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 175@, 203@, 231@)
Actor.Angle(35@(37@,2i)) = 259@
gosub @PIMP_35590 

:PIMP_5896
if 
  42@ == 0 
else_jump @PIMP_5980 
if 
0154:   actor " + PlayerActor + @" in_zone 'BLUF'  
else_jump @PIMP_5980 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 176@, 204@, 232@)
Actor.Angle(35@(37@,2i)) = 260@
gosub @PIMP_35590 

:PIMP_5980
if 
  42@ == 0 
else_jump @PIMP_6064 
if 
0154:   actor " + PlayerActor + @" in_zone 'COM'  
else_jump @PIMP_6064 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 180@, 208@, 236@)
Actor.Angle(35@(37@,2i)) = 264@
gosub @PIMP_35590 

:PIMP_6064
if 
  42@ == 0 
else_jump @PIMP_6148 
if 
0154:   actor " + PlayerActor + @" in_zone 'LDT'  
else_jump @PIMP_6148 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 179@, 207@, 235@)
Actor.Angle(35@(37@,2i)) = 263@
gosub @PIMP_35590 

:PIMP_6148
if 
  42@ == 0 
else_jump @PIMP_6232 
if 
0154:   actor " + PlayerActor + @" in_zone 'GLN'  
else_jump @PIMP_6232 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 182@, 210@, 238@)
Actor.Angle(35@(37@,2i)) = 266@
gosub @PIMP_35590 

:PIMP_6232
if 
  42@ == 0 
else_jump @PIMP_6316 
if 
0154:   actor " + PlayerActor + @" in_zone 'CHC'  
else_jump @PIMP_6316 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 181@, 209@, 237@)
Actor.Angle(35@(37@,2i)) = 265@
gosub @PIMP_35590 

:PIMP_6316
if 
  42@ == 0 
else_jump @PIMP_6400 
if 
0154:   actor " + PlayerActor + @" in_zone 'JEF'  
else_jump @PIMP_6400 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 184@, 212@, 240@)
Actor.Angle(35@(37@,2i)) = 268@
gosub @PIMP_35590 

:PIMP_6400
if 
  42@ == 0 
else_jump @PIMP_6484 
if 
0154:   actor " + PlayerActor + @" in_zone 'ELS'  
else_jump @PIMP_6484 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 183@, 211@, 239@)
Actor.Angle(35@(37@,2i)) = 267@
gosub @PIMP_35590 

:PIMP_6484
if 
  42@ == 0 
else_jump @PIMP_6568 
if 
0154:   actor " + PlayerActor + @" in_zone 'LFL'  
else_jump @PIMP_6568 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 186@, 214@, 242@)
Actor.Angle(35@(37@,2i)) = 270@
gosub @PIMP_35590 

:PIMP_6568
if 
  42@ == 0 
else_jump @PIMP_6652 
if 
0154:   actor " + PlayerActor + @" in_zone 'EBE'  
else_jump @PIMP_6652 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 185@, 213@, 241@)
Actor.Angle(35@(37@,2i)) = 269@
gosub @PIMP_35590 

:PIMP_6652
if 
  42@ == 0 
else_jump @PIMP_6736 
if 
0154:   actor " + PlayerActor + @" in_zone 'CONF'  
else_jump @PIMP_6736 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 188@, 216@, 244@)
Actor.Angle(35@(37@,2i)) = 272@
gosub @PIMP_35590 

:PIMP_6736
if 
  42@ == 0 
else_jump @PIMP_6820 
if 
0154:   actor " + PlayerActor + @" in_zone 'VERO'  
else_jump @PIMP_6820 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 187@, 215@, 243@)
Actor.Angle(35@(37@,2i)) = 271@
gosub @PIMP_35590 

:PIMP_6820
if 
  42@ == 0 
else_jump @PIMP_6904 
if 
0154:   actor " + PlayerActor + @" in_zone 'MKT'  
else_jump @PIMP_6904 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 190@, 218@, 246@)
Actor.Angle(35@(37@,2i)) = 274@
gosub @PIMP_35590 

:PIMP_6904
if 
  42@ == 0 
else_jump @PIMP_6988 
if 
0154:   actor " + PlayerActor + @" in_zone 'MAR'  
else_jump @PIMP_6988 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 189@, 217@, 245@)
Actor.Angle(35@(37@,2i)) = 273@
gosub @PIMP_35590 

:PIMP_6988
if 
  42@ == 0 
else_jump @PIMP_7072 
if 
0154:   actor " + PlayerActor + @" in_zone 'SMB'  
else_jump @PIMP_7072 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 190@, 218@, 246@)
Actor.Angle(35@(37@,2i)) = 274@
gosub @PIMP_35590 

:PIMP_7072
if 
  42@ == 0 
else_jump @PIMP_7156 
if 
0154:   actor " + PlayerActor + @" in_zone 'PLS'  
else_jump @PIMP_7156 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 193@, 221@, 249@)
Actor.Angle(35@(37@,2i)) = 277@
gosub @PIMP_35590 

:PIMP_7156
if 
  42@ == 0 
else_jump @PIMP_7240 
if 
0154:   actor " + PlayerActor + @" in_zone 'ROD'  
else_jump @PIMP_7240 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 194@, 222@, 250@)
Actor.Angle(35@(37@,2i)) = 278@
gosub @PIMP_35590 

:PIMP_7240
if 
  42@ == 0 
else_jump @PIMP_7324 
if 
0154:   actor " + PlayerActor + @" in_zone 'RIH'  
else_jump @PIMP_7324 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 192@, 220@, 248@)
Actor.Angle(35@(37@,2i)) = 276@
gosub @PIMP_35590 

:PIMP_7324
if 
  42@ == 0 
else_jump @PIMP_7408 
if 
0154:   actor " + PlayerActor + @" in_zone 'VIN'  
else_jump @PIMP_7408 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 195@, 223@, 251@)
Actor.Angle(35@(37@,2i)) = 279@
gosub @PIMP_35590 

:PIMP_7408
if 
  42@ == 0 
else_jump @PIMP_7492 
if 
0154:   actor " + PlayerActor + @" in_zone 'MUL'  
else_jump @PIMP_7492 
35@(37@,2i) = Actor.Create(Prostitute, #BFYPRO, 198@, 226@, 254@)
Actor.Angle(35@(37@,2i)) = 282@
gosub @PIMP_35590 

:PIMP_7492
if 
  42@ == 0 
else_jump @PIMP_7576 
if 
0154:   actor " + PlayerActor + @" in_zone 'SUN'  
else_jump @PIMP_7576 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 196@, 224@, 252@)
Actor.Angle(35@(37@,2i)) = 280@
gosub @PIMP_35590 

:PIMP_7576
if 
  42@ == 0 
else_jump @PIMP_7635 
35@(37@,2i) = Actor.Create(Prostitute, #HFYPRO, 180@, 208@, 236@)
Actor.Angle(35@(37@,2i)) = 264@
gosub @PIMP_35590 

:PIMP_7635
Model.Destroy(#BFYPRO)
Model.Destroy(#HFYPRO)

:PIMP_7643
if 
04A4:   531@ == 2 
else_jump @PIMP_10050 
Model.Load(#SWFOPRO)
Model.Load(#WFYPRO)

:PIMP_7670
if or
   not Model.Available(#SWFOPRO)
   not Model.Available(#WFYPRO)
else_jump @PIMP_7701 
wait 0 
jump @PIMP_7670 

:PIMP_7701
if 
  42@ == 0 
else_jump @PIMP_7786 
if 
0154:   actor " + PlayerActor + @" in_zone 'CALT'  
else_jump @PIMP_7786 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 288@, 316@, 344@)
Actor.Angle(35@(37@,2i)) = 372@
gosub @PIMP_35590 

:PIMP_7786
if 
  42@ == 0 
else_jump @PIMP_7870 
if 
0154:   actor " + PlayerActor + @" in_zone 'JUNIHO'  
else_jump @PIMP_7870 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 287@, 315@, 343@)
Actor.Angle(35@(37@,2i)) = 371@
gosub @PIMP_35590 

:PIMP_7870
if 
  42@ == 0 
else_jump @PIMP_7954 
if 
0154:   actor " + PlayerActor + @" in_zone 'ESPN'  
else_jump @PIMP_7954 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 289@, 317@, 345@)
Actor.Angle(35@(37@,2i)) = 373@
gosub @PIMP_35590 

:PIMP_7954
if 
  42@ == 0 
else_jump @PIMP_8039 
if 
0154:   actor " + PlayerActor + @" in_zone 'JUNIHI'  
else_jump @PIMP_8039 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 290@, 318@, 346@)
Actor.Angle(35@(37@,2i)) = 374@
gosub @PIMP_35590 

:PIMP_8039
if 
  42@ == 0 
else_jump @PIMP_8124 
if 
0154:   actor " + PlayerActor + @" in_zone 'SUNMA'  
else_jump @PIMP_8124 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 292@, 320@, 348@)
Actor.Angle(35@(37@,2i)) = 376@
gosub @PIMP_35590 

:PIMP_8124
if 
  42@ == 0 
else_jump @PIMP_8208 
if 
0154:   actor " + PlayerActor + @" in_zone 'SUNNN'  
else_jump @PIMP_8208 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 291@, 319@, 347@)
Actor.Angle(35@(37@,2i)) = 375@
gosub @PIMP_35590 

:PIMP_8208
if 
  42@ == 0 
else_jump @PIMP_8292 
if 
0154:   actor " + PlayerActor + @" in_zone 'BATTP'  
else_jump @PIMP_8292 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 294@, 322@, 350@)
Actor.Angle(35@(37@,2i)) = 378@
gosub @PIMP_35590 

:PIMP_8292
if 
  42@ == 0 
else_jump @PIMP_8377 
if 
0154:   actor " + PlayerActor + @" in_zone 'GANTB'  
else_jump @PIMP_8377 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 293@, 321@, 349@)
Actor.Angle(35@(37@,2i)) = 377@
gosub @PIMP_35590 

:PIMP_8377
if 
  42@ == 0 
else_jump @PIMP_8462 
if 
0154:   actor " + PlayerActor + @" in_zone 'CHINA'  
else_jump @PIMP_8462 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 296@, 324@, 352@)
Actor.Angle(35@(37@,2i)) = 380@
gosub @PIMP_35590 

:PIMP_8462
if 
  42@ == 0 
else_jump @PIMP_8546 
if 
0154:   actor " + PlayerActor + @" in_zone 'SFDWT'  
else_jump @PIMP_8546 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 295@, 323@, 351@)
Actor.Angle(35@(37@,2i)) = 379@
gosub @PIMP_35590 

:PIMP_8546
if 
  42@ == 0 
else_jump @PIMP_8630 
if 
0154:   actor " + PlayerActor + @" in_zone 'FINA'  
else_jump @PIMP_8630 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 298@, 326@, 354@)
Actor.Angle(35@(37@,2i)) = 382@
gosub @PIMP_35590 

:PIMP_8630
if 
  42@ == 0 
else_jump @PIMP_8715 
if 
0154:   actor " + PlayerActor + @" in_zone 'ESPE'  
else_jump @PIMP_8715 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 297@, 325@, 353@)
Actor.Angle(35@(37@,2i)) = 381@
gosub @PIMP_35590 

:PIMP_8715
if 
  42@ == 0 
else_jump @PIMP_8800 
if 
0154:   actor " + PlayerActor + @" in_zone 'WESTP'  
else_jump @PIMP_8800 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 300@, 328@, 356@)
Actor.Angle(35@(37@,2i)) = 384@
gosub @PIMP_35590 

:PIMP_8800
if 
  42@ == 0 
else_jump @PIMP_8884 
if 
0154:   actor " + PlayerActor + @" in_zone 'HASH'  
else_jump @PIMP_8884 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 299@, 327@, 355@)
Actor.Angle(35@(37@,2i)) = 383@
gosub @PIMP_35590 

:PIMP_8884
if 
  42@ == 0 
else_jump @PIMP_8969 
if 
0154:   actor " + PlayerActor + @" in_zone 'OCEAF'  
else_jump @PIMP_8969 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 302@, 330@, 358@)
Actor.Angle(35@(37@,2i)) = 386@
gosub @PIMP_35590 

:PIMP_8969
if 
  42@ == 0 
else_jump @PIMP_9053 
if 
0154:   actor " + PlayerActor + @" in_zone 'CUNTC'  
else_jump @PIMP_9053 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 301@, 329@, 357@)
Actor.Angle(35@(37@,2i)) = 385@
gosub @PIMP_35590 

:PIMP_9053
if 
  42@ == 0 
else_jump @PIMP_9138 
if 
0154:   actor " + PlayerActor + @" in_zone 'THEA'  
else_jump @PIMP_9138 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 304@, 332@, 360@)
Actor.Angle(35@(37@,2i)) = 388@
gosub @PIMP_35590 

:PIMP_9138
if 
  42@ == 0 
else_jump @PIMP_9222 
if 
0154:   actor " + PlayerActor + @" in_zone 'GARC'  
else_jump @PIMP_9222 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 303@, 331@, 359@)
Actor.Angle(35@(37@,2i)) = 387@
gosub @PIMP_35590 

:PIMP_9222
if 
  42@ == 0 
else_jump @PIMP_9307 
if 
0154:   actor " + PlayerActor + @" in_zone 'DOH'  
else_jump @PIMP_9307 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 306@, 334@, 362@)
Actor.Angle(35@(37@,2i)) = 390@
gosub @PIMP_35590 

:PIMP_9307
if 
  42@ == 0 
else_jump @PIMP_9391 
if 
0154:   actor " + PlayerActor + @" in_zone 'EASB'  
else_jump @PIMP_9391 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 305@, 333@, 361@)
Actor.Angle(35@(37@,2i)) = 389@
gosub @PIMP_35590 

:PIMP_9391
if 
  42@ == 0 
else_jump @PIMP_9475 
if 
0154:   actor " + PlayerActor + @" in_zone 'HILLP'  
else_jump @PIMP_9475 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 308@, 336@, 364@)
Actor.Angle(35@(37@,2i)) = 392@
gosub @PIMP_35590 

:PIMP_9475
if 
  42@ == 0 
else_jump @PIMP_9560 
if 
0154:   actor " + PlayerActor + @" in_zone 'SILLY'  
else_jump @PIMP_9560 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 309@, 337@, 365@)
Actor.Angle(35@(37@,2i)) = 393@
gosub @PIMP_35590 

:PIMP_9560
if 
  42@ == 0 
else_jump @PIMP_9644 
if 
0154:   actor " + PlayerActor + @" in_zone 'SFAIR'  
else_jump @PIMP_9644 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 307@, 335@, 363@)
Actor.Angle(35@(37@,2i)) = 391@
gosub @PIMP_35590 

:PIMP_9644
if 
  42@ == 0 
else_jump @PIMP_9728 
if 
0154:   actor " + PlayerActor + @" in_zone 'BAYV'  
else_jump @PIMP_9728 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 311@, 339@, 367@)
Actor.Angle(35@(37@,2i)) = 395@
gosub @PIMP_35590 

:PIMP_9728
if 
  42@ == 0 
else_jump @PIMP_9813 
if 
0154:   actor " + PlayerActor + @" in_zone 'PARA'  
else_jump @PIMP_9813 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 310@, 338@, 366@)
Actor.Angle(35@(37@,2i)) = 394@
gosub @PIMP_35590 

:PIMP_9813
if 
  42@ == 0 
else_jump @PIMP_9898 
if 
0154:   actor " + PlayerActor + @" in_zone 'CIVI'  
else_jump @PIMP_9898 
35@(37@,2i) = Actor.Create(Prostitute, #WFYPRO, 313@, 341@, 369@)
Actor.Angle(35@(37@,2i)) = 397@
gosub @PIMP_35590 

:PIMP_9898
if 
  42@ == 0 
else_jump @PIMP_9982 
if 
0154:   actor " + PlayerActor + @" in_zone 'CITYS'  
else_jump @PIMP_9982 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 312@, 340@, 368@)
Actor.Angle(35@(37@,2i)) = 396@
gosub @PIMP_35590 

:PIMP_9982
if 
  42@ == 0 
else_jump @PIMP_10041 
35@(37@,2i) = Actor.Create(Prostitute, #SWFOPRO, 287@, 315@, 343@)
Actor.Angle(35@(37@,2i)) = 371@
gosub @PIMP_35590 

:PIMP_10041
Model.Destroy(#SWFOPRO)
Model.Destroy(#WFYPRO)

:PIMP_10050
if 
04A4:   531@ == 3 
else_jump @PIMP_11866 
Model.Load(#VWFYPRO)
Model.Load(#VBFYPRO)

:PIMP_10077
if or
   not Model.Available(#VWFYPRO)
   not Model.Available(#VBFYPRO)
else_jump @PIMP_10108 
wait 0 
jump @PIMP_10077 

:PIMP_10108
if 
  42@ == 0 
else_jump @PIMP_10192 
if 
0154:   actor " + PlayerActor + @" in_zone 'PINK'  
else_jump @PIMP_10192 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 400@, 428@, 456@)
Actor.Angle(35@(37@,2i)) = 484@
gosub @PIMP_35590 

:PIMP_10192
if 
  42@ == 0 
else_jump @PIMP_10276 
if 
0154:   actor " + PlayerActor + @" in_zone 'DRAG'  
else_jump @PIMP_10276 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 399@, 427@, 455@)
Actor.Angle(35@(37@,2i)) = 483@
gosub @PIMP_35590 

:PIMP_10276
if 
  42@ == 0 
else_jump @PIMP_10361 
if 
0154:   actor " + PlayerActor + @" in_zone 'CAM'  
else_jump @PIMP_10361 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 402@, 430@, 458@)
Actor.Angle(35@(37@,2i)) = 486@
gosub @PIMP_35590 

:PIMP_10361
if 
  42@ == 0 
else_jump @PIMP_10446 
if 
0154:   actor " + PlayerActor + @" in_zone 'LOT'  
else_jump @PIMP_10446 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 401@, 429@, 457@)
Actor.Angle(35@(37@,2i)) = 485@
gosub @PIMP_35590 

:PIMP_10446
if 
  42@ == 0 
else_jump @PIMP_10530 
if 
0154:   actor " + PlayerActor + @" in_zone 'PIRA'  
else_jump @PIMP_10530 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 404@, 432@, 460@)
Actor.Angle(35@(37@,2i)) = 488@
gosub @PIMP_35590 

:PIMP_10530
if 
  42@ == 0 
else_jump @PIMP_10614 
if 
0154:   actor " + PlayerActor + @" in_zone 'ROY'  
else_jump @PIMP_10614 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 403@, 431@, 459@)
Actor.Angle(35@(37@,2i)) = 487@
gosub @PIMP_35590 

:PIMP_10614
if 
  42@ == 0 
else_jump @PIMP_10699 
if 
0154:   actor " + PlayerActor + @" in_zone 'CALI'  
else_jump @PIMP_10699 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 406@, 434@, 462@)
Actor.Angle(35@(37@,2i)) = 490@
gosub @PIMP_35590 

:PIMP_10699
if 
  42@ == 0 
else_jump @PIMP_10784 
if 
0154:   actor " + PlayerActor + @" in_zone 'HIGH'  
else_jump @PIMP_10784 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 405@, 433@, 461@)
Actor.Angle(35@(37@,2i)) = 489@
gosub @PIMP_35590 

:PIMP_10784
if 
  42@ == 0 
else_jump @PIMP_10868 
if 
0154:   actor " + PlayerActor + @" in_zone 'PILG' 
else_jump @PIMP_10868 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 408@, 436@, 464@)
Actor.Angle(35@(37@,2i)) = 492@
gosub @PIMP_35590 

:PIMP_10868
if 
  42@ == 0 
else_jump @PIMP_10952 
if 
0154:   actor " + PlayerActor + @" in_zone 'STAR'  
else_jump @PIMP_10952 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 407@, 435@, 463@)
Actor.Angle(35@(37@,2i)) = 491@
gosub @PIMP_35590 

:PIMP_10952
if 
  42@ == 0 
else_jump @PIMP_11037 
if 
0154:   actor " + PlayerActor + @" in_zone 'STRIP'  
else_jump @PIMP_11037 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 410@, 438@, 466@)
Actor.Angle(35@(37@,2i)) = 494@
gosub @PIMP_35590 

:PIMP_11037
if 
  42@ == 0 
else_jump @PIMP_11122 
if 
0154:   actor " + PlayerActor + @" in_zone 'VISA'  
else_jump @PIMP_11122 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 409@, 437@, 465@)
Actor.Angle(35@(37@,2i)) = 493@
gosub @PIMP_35590 

:PIMP_11122
if 
  42@ == 0 
else_jump @PIMP_11206 
if 
0154:   actor " + PlayerActor + @" in_zone 'ISLE'  
else_jump @PIMP_11206 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 412@, 440@, 468@)
Actor.Angle(35@(37@,2i)) = 496@
gosub @PIMP_35590 

:PIMP_11206
if 
  42@ == 0 
else_jump @PIMP_11290 
if 
0154:   actor " + PlayerActor + @" in_zone 'ROCE'  
else_jump @PIMP_11290 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 411@, 439@, 467@)
Actor.Angle(35@(37@,2i)) = 495@
gosub @PIMP_35590 

:PIMP_11290
if 
  42@ == 0 
else_jump @PIMP_11375 
if 
0154:   actor " + PlayerActor + @" in_zone 'OVS'  
else_jump @PIMP_11375 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 414@, 442@, 470@)
Actor.Angle(35@(37@,2i)) = 498@
gosub @PIMP_35590 

:PIMP_11375
if 
  42@ == 0 
else_jump @PIMP_11460 
if 
0154:   actor " + PlayerActor + @" in_zone 'RING'  
else_jump @PIMP_11460 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 413@, 441@, 469@)
Actor.Angle(35@(37@,2i)) = 497@
gosub @PIMP_35590 

:PIMP_11460
if 
  42@ == 0 
else_jump @PIMP_11544 
if 
0154:   actor " + PlayerActor + @" in_zone 'BFC'  
else_jump @PIMP_11544 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 416@, 444@, 472@)
Actor.Angle(35@(37@,2i)) = 500@
gosub @PIMP_35590 

:PIMP_11544
if 
  42@ == 0 
else_jump @PIMP_11628 
if 
0154:   actor " + PlayerActor + @" in_zone 'GGC'  
else_jump @PIMP_11628 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 415@, 443@, 471@)
Actor.Angle(35@(37@,2i)) = 499@
gosub @PIMP_35590 

:PIMP_11628
if 
  42@ == 0 
else_jump @PIMP_11713 
if 
0154:   actor " + PlayerActor + @" in_zone 'VAIR'  
else_jump @PIMP_11713 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 418@, 446@, 474@)
Actor.Angle(35@(37@,2i)) = 502@
gosub @PIMP_35590 

:PIMP_11713
if 
  42@ == 0 
else_jump @PIMP_11798 
if 
0154:   actor " + PlayerActor + @" in_zone 'LDM'  
else_jump @PIMP_11798 
35@(37@,2i) = Actor.Create(Prostitute, #VBFYPRO, 417@, 445@, 473@)
Actor.Angle(35@(37@,2i)) = 501@
gosub @PIMP_35590 

:PIMP_11798
if 
  42@ == 0 
else_jump @PIMP_11857 
35@(37@,2i) = Actor.Create(Prostitute, #VWFYPRO, 399@, 427@, 455@)
Actor.Angle(35@(37@,2i)) = 483@
gosub @PIMP_35590 

:PIMP_11857
Model.Destroy(#VWFYPRO)
Model.Destroy(#VBFYPRO)

:PIMP_11866
if 
  42@ == 1 
else_jump @PIMP_12081 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_12081 
05BA: AS_actor 35@(37@,2i) move_mouth -1 ms 
Marker.Disable(88@)
88@ = Marker.CreateAboveActor(35@(37@,2i))
060B: set_actor 35@(37@,2i) decision_maker_to 518@ 
02A9: set_actor 35@(37@,2i) immune_to_nonplayer 1 
039E: set_actor 35@(37@,2i) locked 1 while_in_car 
07E0: set_marker 88@ type_to 1 
if 
  37@ == 0 
else_jump @PIMP_12020 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'PIMP_2' time 6000 flag 1  
039E: set_actor 35@(37@,2i) locked 1 while_in_car 

:PIMP_12020
if 
  37@ == 1 
else_jump @PIMP_12067 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'PIMP_30' time 6000 flag 1  
039E: set_actor 35@(37@,2i) locked 1 while_in_car 

:PIMP_12067
42@ = 2 
43@ = 1 

:PIMP_12081
if 
  43@ == 1 
else_jump @PIMP_12227 
if 
056D:   actor 35@ defined 
else_jump @PIMP_12154 
if 
   Actor.Dead(35@)
else_jump @PIMP_12154 
00BC: show_text_highpriority GXT 'PIMP_51' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_12154
if 
  52@ == 1 
else_jump @PIMP_12227 
if 
056D:   actor 36@ defined 
else_jump @PIMP_12227 
if 
   Actor.Dead(36@)
else_jump @PIMP_12227 
00BC: show_text_highpriority GXT 'PIMP_51' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_12227
if 
  42@ == 2 
else_jump @PIMP_12869 
if 
  523@ == 1 
else_jump @PIMP_12305 
if 
  32@ > 4000 
else_jump @PIMP_12305 
00BC: show_text_highpriority GXT 'PIMP_57' time 6000 flag 1  
523@ = 99 

:PIMP_12305
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_12869 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_12869 
if 
  521@ == 0 
else_jump @PIMP_12405 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_12405 
522@ = Marker.CreateAboveCar(40@)
07E0: set_marker 522@ type_to 1 
Marker.Disable(88@)
521@ = 1 

:PIMP_12405
if 
  521@ == 1 
else_jump @PIMP_12501 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_12501 
Marker.Disable(522@)
521@ = 0 
Marker.Disable(88@)
88@ = Marker.CreateAboveActor(35@(37@,2i))
07E0: set_marker 88@ type_to 1 
00BC: show_text_highpriority GXT 'PIMP_54' time 6000 flag 1  
521@ = 0 

:PIMP_12501
if 
  44@ == 0 
else_jump @PIMP_12688 
if 
  521@ == 0 
else_jump @PIMP_12688 
if 
00F4:   actor " + PlayerActor + @" near_actor 35@(37@,2i) radius 7.0 7.0 0 in_car 
else_jump @PIMP_12688 
if 
  45@ == 0 
else_jump @PIMP_12637 
0615: define_AS_pack_begin 38@ 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
05BA: AS_actor -1 move_mouth -1 ms 
0616: define_AS_pack_end 38@ 
0618: assign_actor 35@(37@,2i) to_AS_pack 38@ 
061B: remove_references_to_AS_pack 38@ 
45@ = 1 

:PIMP_12637
if 
01C1:   car 40@ stopped 
else_jump @PIMP_12688 
0687: clear_actor 35@(37@,2i) task 
05CA: AS_actor 35@(37@,2i) enter_car 40@ passenger_seat -1 time 60000 
44@ = 1 

:PIMP_12688
if 
   not Car.Wrecked(40@)
else_jump @PIMP_12869 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_12869 
if 
0448:   actor 35@(37@,2i) in_car 40@ 
else_jump @PIMP_12869 
if 
  2 > 56@ 
else_jump @PIMP_12779 
56@ += 1 
0623: add 1 to_integer_stat 171 

:PIMP_12779
44@ = 2 
Marker.Disable(88@)
42@ = 99 
47@ = 1 
gosub @PIMP_35718 
520@ = 1 
32@ = 0 
if 
  49@ == 10 
else_jump @PIMP_12869 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'SEXGOD' time 6000 flag 1  
jump @PIMP_37797 

:PIMP_12869
if 
  44@ == 1 
else_jump @PIMP_13007 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_13007 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_13007 
062E: get_actor 35@(37@,2i) task 1482 status_store_to 539@ 
if 
04A4:   539@ == 7 
else_jump @PIMP_13007 
if 
   not Actor.InCar(35@(37@,2i), 40@)
else_jump @PIMP_13007 
0687: clear_actor 35@(37@,2i) task 
05CA: AS_actor 35@(37@,2i) enter_car 40@ passenger_seat -1 time 60000 

:PIMP_13007
if 
  47@ == 1 
else_jump @PIMP_29178 
if 
04A4:   531@ == 1 
else_jump @PIMP_19041 
if 
  58@ == 1 
else_jump @PIMP_13897 
if 
  60@ == 1 
else_jump @PIMP_13140 
if 
  61@ == 1 
else_jump @PIMP_13140 
if 
  62@ == 1 
else_jump @PIMP_13140 
if 
  63@ == 1 
else_jump @PIMP_13140 
58@ = 2 

:PIMP_13140
0209: 50@ = random_int_in_ranges 0 4 
if 
  50@ == 0 
else_jump @PIMP_13336 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_13336 
Model.Load(#SWMYHP1)

:PIMP_13193
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_13219 
wait 0 
jump @PIMP_13193 

:PIMP_13219
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_10' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_13336
if 
  50@ == 1 
else_jump @PIMP_13523 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_13523 
Model.Load(#SWMYHP1)

:PIMP_13380
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_13406 
wait 0 
jump @PIMP_13380 

:PIMP_13406
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_11' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_13523
if 
  50@ == 2 
else_jump @PIMP_13710 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_13710 
Model.Load(#SWMYHP1)

:PIMP_13567
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_13593 
wait 0 
jump @PIMP_13567 

:PIMP_13593
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_12' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_13710
if 
  50@ == 3 
else_jump @PIMP_13897 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_13897 
Model.Load(#BMYST)

:PIMP_13754
if 
   not Model.Available(#BMYST)
else_jump @PIMP_13780 
wait 0 
jump @PIMP_13754 

:PIMP_13780
91@(50@,28i) = Actor.Create(CivMale, #BMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_13' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_13897
if 
  58@ == 2 
else_jump @PIMP_14755 
if 
  64@ == 1 
else_jump @PIMP_13994 
if 
  65@ == 1 
else_jump @PIMP_13994 
if 
  66@ == 1 
else_jump @PIMP_13994 
if 
  67@ == 1 
else_jump @PIMP_13994 
58@ = 3 

:PIMP_13994
0209: 50@ = random_int_in_ranges 4 8 
if 
  50@ == 4 
else_jump @PIMP_14190 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_14190 
Model.Load(#BMYST)

:PIMP_14047
if 
   not Model.Available(#BMYST)
else_jump @PIMP_14073 
wait 0 
jump @PIMP_14047 

:PIMP_14073
91@(50@,28i) = Actor.Create(CivMale, #BMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_14' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_14190
if 
  50@ == 5 
else_jump @PIMP_14381 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_14381 
Model.Load(#WMYBU)

:PIMP_14235
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_14262 
wait 0 
jump @PIMP_14235 

:PIMP_14262
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_15' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_14381
if 
  50@ == 6 
else_jump @PIMP_14568 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_14568 
Model.Load(#BMYST)

:PIMP_14425
if 
   not Model.Available(#BMYST)
else_jump @PIMP_14451 
wait 0 
jump @PIMP_14425 

:PIMP_14451
91@(50@,28i) = Actor.Create(CivMale, #BMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_16' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_14568
if 
  50@ == 7 
else_jump @PIMP_14755 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_14755 
Model.Load(#BMYST)

:PIMP_14612
if 
   not Model.Available(#BMYST)
else_jump @PIMP_14638 
wait 0 
jump @PIMP_14612 

:PIMP_14638
91@(50@,28i) = Actor.Create(CivMale, #BMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_17' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_14755
if 
  58@ == 3 
else_jump @PIMP_15613 
if 
  68@ == 1 
else_jump @PIMP_14852 
if 
  69@ == 1 
else_jump @PIMP_14852 
if 
  70@ == 1 
else_jump @PIMP_14852 
if 
  71@ == 1 
else_jump @PIMP_14852 
58@ = 4 

:PIMP_14852
0209: 50@ = random_int_in_ranges 8 12 
if 
  50@ == 8 
else_jump @PIMP_15048 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_15048 
Model.Load(#WMOPREA)

:PIMP_14905
if 
   not Model.Available(#WMOPREA)
else_jump @PIMP_14931 
wait 0 
jump @PIMP_14905 

:PIMP_14931
91@(50@,28i) = Actor.Create(CivMale, #WMOPREA, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMOPREA)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_18' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_15048
if 
  50@ == 9 
else_jump @PIMP_15235 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_15235 
Model.Load(#HMYST)

:PIMP_15092
if 
   not Model.Available(#HMYST)
else_jump @PIMP_15118 
wait 0 
jump @PIMP_15092 

:PIMP_15118
91@(50@,28i) = Actor.Create(CivMale, #HMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#HMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_19' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_15235
if 
  50@ == 10 
else_jump @PIMP_15422 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_15422 
Model.Load(#HMYST)

:PIMP_15279
if 
   not Model.Available(#HMYST)
else_jump @PIMP_15305 
wait 0 
jump @PIMP_15279 

:PIMP_15305
91@(50@,28i) = Actor.Create(CivMale, #HMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#HMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_20' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_15422
if 
  50@ == 11 
else_jump @PIMP_15613 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_15613 
Model.Load(#WMYBU)

:PIMP_15467
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_15494 
wait 0 
jump @PIMP_15467 

:PIMP_15494
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_21' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_15613
if 
  58@ == 4 
else_jump @PIMP_16471 
if 
  72@ == 1 
else_jump @PIMP_15710 
if 
  73@ == 1 
else_jump @PIMP_15710 
if 
  74@ == 1 
else_jump @PIMP_15710 
if 
  75@ == 1 
else_jump @PIMP_15710 
58@ = 5 

:PIMP_15710
0209: 50@ = random_int_in_ranges 12 16 
if 
  50@ == 12 
else_jump @PIMP_15910 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_15910 
Model.Load(#WMYBU)

:PIMP_15764
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_15791 
wait 0 
jump @PIMP_15764 

:PIMP_15791
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_22' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_15910
if 
  50@ == 13 
else_jump @PIMP_16097 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_16097 
Model.Load(#WMYBMX)

:PIMP_15954
if 
   not Model.Available(#WMYBMX)
else_jump @PIMP_15980 
wait 0 
jump @PIMP_15954 

:PIMP_15980
91@(50@,28i) = Actor.Create(CivMale, #WMYBMX, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYBMX)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_23' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_16097
if 
  50@ == 14 
else_jump @PIMP_16284 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_16284 
Model.Load(#BMYBU)

:PIMP_16141
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_16167 
wait 0 
jump @PIMP_16141 

:PIMP_16167
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_24' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_16284
if 
  50@ == 15 
else_jump @PIMP_16471 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_16471 
Model.Load(#WMYMECH)

:PIMP_16328
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_16354 
wait 0 
jump @PIMP_16328 

:PIMP_16354
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_25' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_16471
if 
  58@ == 5 
else_jump @PIMP_17329 
if 
  76@ == 1 
else_jump @PIMP_16568 
if 
  77@ == 1 
else_jump @PIMP_16568 
if 
  78@ == 1 
else_jump @PIMP_16568 
if 
  79@ == 1 
else_jump @PIMP_16568 
58@ = 6 

:PIMP_16568
0209: 50@ = random_int_in_ranges 16 20 
if 
  50@ == 16 
else_jump @PIMP_16768 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_16768 
Model.Load(#WMYBU)

:PIMP_16622
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_16649 
wait 0 
jump @PIMP_16622 

:PIMP_16649
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_26' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_16768
if 
  50@ == 17 
else_jump @PIMP_16955 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_16955 
Model.Load(#HMYST)

:PIMP_16812
if 
   not Model.Available(#HMYST)
else_jump @PIMP_16838 
wait 0 
jump @PIMP_16812 

:PIMP_16838
91@(50@,28i) = Actor.Create(CivMale, #HMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#HMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_27' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_16955
if 
  50@ == 18 
else_jump @PIMP_17142 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_17142 
Model.Load(#WMYBMX)

:PIMP_16999
if 
   not Model.Available(#WMYBMX)
else_jump @PIMP_17025 
wait 0 
jump @PIMP_16999 

:PIMP_17025
91@(50@,28i) = Actor.Create(CivMale, #WMYBMX, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYBMX)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_28' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_17142
if 
  50@ == 19 
else_jump @PIMP_17329 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_17329 
Model.Load(#BMYBU)

:PIMP_17186
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_17212 
wait 0 
jump @PIMP_17186 

:PIMP_17212
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_29' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_17329
if 
  58@ == 6 
else_jump @PIMP_18183 
if 
  80@ == 1 
else_jump @PIMP_17426 
if 
  81@ == 1 
else_jump @PIMP_17426 
if 
  82@ == 1 
else_jump @PIMP_17426 
if 
  83@ == 1 
else_jump @PIMP_17426 
58@ = 7 

:PIMP_17426
0209: 50@ = random_int_in_ranges 20 24 
if 
  50@ == 20 
else_jump @PIMP_17622 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_17622 
Model.Load(#WMYGOL1)

:PIMP_17479
if 
   not Model.Available(#WMYGOL1)
else_jump @PIMP_17505 
wait 0 
jump @PIMP_17479 

:PIMP_17505
91@(50@,28i) = Actor.Create(CivMale, #WMYGOL1, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYGOL1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_80' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_17622
if 
  50@ == 21 
else_jump @PIMP_17809 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_17809 
Model.Load(#WMYMECH)

:PIMP_17666
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_17692 
wait 0 
jump @PIMP_17666 

:PIMP_17692
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_81' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_17809
if 
  50@ == 22 
else_jump @PIMP_17996 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_17996 
Model.Load(#HMYST)

:PIMP_17853
if 
   not Model.Available(#HMYST)
else_jump @PIMP_17879 
wait 0 
jump @PIMP_17853 

:PIMP_17879
91@(50@,28i) = Actor.Create(CivMale, #HMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#HMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_82' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_17996
if 
  50@ == 23 
else_jump @PIMP_18183 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_18183 
Model.Load(#WMOPREA)

:PIMP_18040
if 
   not Model.Available(#WMOPREA)
else_jump @PIMP_18066 
wait 0 
jump @PIMP_18040 

:PIMP_18066
91@(50@,28i) = Actor.Create(CivMale, #WMOPREA, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMOPREA)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_83' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_18183
if 
  58@ == 7 
else_jump @PIMP_19041 
if 
  84@ == 1 
else_jump @PIMP_18280 
if 
  85@ == 1 
else_jump @PIMP_18280 
if 
  86@ == 1 
else_jump @PIMP_18280 
if 
  87@ == 1 
else_jump @PIMP_18280 
58@ = 1 

:PIMP_18280
0209: 50@ = random_int_in_ranges 24 28 
if 
  50@ == 24 
else_jump @PIMP_18480 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_18480 
Model.Load(#BMYBOUN)

:PIMP_18334
if 
   not Model.Available(#BMYBOUN)
else_jump @PIMP_18361 
wait 0 
jump @PIMP_18334 

:PIMP_18361
91@(50@,28i) = Actor.Create(CivMale, #BMYBOUN, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYBOUN)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_84' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_18480
if 
  50@ == 25 
else_jump @PIMP_18667 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_18667 
Model.Load(#BMYDJ)

:PIMP_18524
if 
   not Model.Available(#BMYDJ)
else_jump @PIMP_18550 
wait 0 
jump @PIMP_18524 

:PIMP_18550
91@(50@,28i) = Actor.Create(CivMale, #BMYDJ, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#BMYDJ)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_85' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_18667
if 
  50@ == 26 
else_jump @PIMP_18854 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_18854 
Model.Load(#WMYDRUG)

:PIMP_18711
if 
   not Model.Available(#WMYDRUG)
else_jump @PIMP_18737 
wait 0 
jump @PIMP_18711 

:PIMP_18737
91@(50@,28i) = Actor.Create(CivMale, #WMYDRUG, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#WMYDRUG)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_86' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_18854
if 
  50@ == 27 
else_jump @PIMP_19041 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_19041 
Model.Load(#HMYST)

:PIMP_18898
if 
   not Model.Available(#HMYST)
else_jump @PIMP_18924 
wait 0 
jump @PIMP_18898 

:PIMP_18924
91@(50@,28i) = Actor.Create(CivMale, #HMYST, 175@(50@,28f), 203@(50@,28f), 231@(50@,28f))
Actor.Angle(91@(50@,28i)) = 259@(50@,28f)
Model.Destroy(#HMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP_87' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_19041
if 
04A4:   531@ == 2 
else_jump @PIMP_24878 
if 
  58@ == 1 
else_jump @PIMP_19913 
if 
  60@ == 1 
else_jump @PIMP_19156 
if 
  61@ == 1 
else_jump @PIMP_19156 
if 
  62@ == 1 
else_jump @PIMP_19156 
if 
  63@ == 1 
else_jump @PIMP_19156 
58@ = 2 

:PIMP_19156
0209: 50@ = random_int_in_ranges 0 4 
if 
  50@ == 0 
else_jump @PIMP_19352 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_19352 
Model.Load(#SWMYHP1)

:PIMP_19209
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_19235 
wait 0 
jump @PIMP_19209 

:PIMP_19235
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP200' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_19352
if 
  50@ == 1 
else_jump @PIMP_19539 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_19539 
Model.Load(#SWMYHP1)

:PIMP_19396
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_19422 
wait 0 
jump @PIMP_19396 

:PIMP_19422
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP201' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_19539
if 
  50@ == 2 
else_jump @PIMP_19726 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_19726 
Model.Load(#WMYMECH)

:PIMP_19583
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_19609 
wait 0 
jump @PIMP_19583 

:PIMP_19609
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP202' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_19726
if 
  50@ == 3 
else_jump @PIMP_19913 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_19913 
Model.Load(#WMYMECH)

:PIMP_19770
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_19796 
wait 0 
jump @PIMP_19770 

:PIMP_19796
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP203' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_19913
if 
  58@ == 2 
else_jump @PIMP_20793 
if 
  64@ == 1 
else_jump @PIMP_20010 
if 
  65@ == 1 
else_jump @PIMP_20010 
if 
  66@ == 1 
else_jump @PIMP_20010 
if 
  67@ == 1 
else_jump @PIMP_20010 
58@ = 3 

:PIMP_20010
0209: 50@ = random_int_in_ranges 4 8 
if 
  50@ == 4 
else_jump @PIMP_20217 
60@(50@,28i) = 1 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_20217 
Model.Load(#BMYBU)

:PIMP_20074
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_20100 
wait 0 
jump @PIMP_20074 

:PIMP_20100
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP204' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_20217
if 
  50@ == 5 
else_jump @PIMP_20419 
60@(50@,28i) = 1 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_20419 
Model.Load(#WMYBU)

:PIMP_20273
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_20300 
wait 0 
jump @PIMP_20273 

:PIMP_20300
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP205' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_20419
if 
  50@ == 6 
else_jump @PIMP_20606 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_20606 
Model.Load(#WMYMECH)

:PIMP_20463
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_20489 
wait 0 
jump @PIMP_20463 

:PIMP_20489
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP206' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_20606
if 
  50@ == 7 
else_jump @PIMP_20793 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_20793 
Model.Load(#BMYST)

:PIMP_20650
if 
   not Model.Available(#BMYST)
else_jump @PIMP_20676 
wait 0 
jump @PIMP_20650 

:PIMP_20676
91@(50@,28i) = Actor.Create(CivMale, #BMYST, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP207' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_20793
if 
  58@ == 3 
else_jump @PIMP_21651 
if 
  68@ == 1 
else_jump @PIMP_20890 
if 
  69@ == 1 
else_jump @PIMP_20890 
if 
  70@ == 1 
else_jump @PIMP_20890 
if 
  71@ == 1 
else_jump @PIMP_20890 
58@ = 4 

:PIMP_20890
0209: 50@ = random_int_in_ranges 8 12 
if 
  50@ == 8 
else_jump @PIMP_21086 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_21086 
Model.Load(#OMOST)

:PIMP_20943
if 
   not Model.Available(#OMOST)
else_jump @PIMP_20969 
wait 0 
jump @PIMP_20943 

:PIMP_20969
91@(50@,28i) = Actor.Create(CivMale, #OMOST, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#OMOST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP208' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_21086
if 
  50@ == 9 
else_jump @PIMP_21277 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_21277 
Model.Load(#WMYBU)

:PIMP_21131
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_21158 
wait 0 
jump @PIMP_21131 

:PIMP_21158
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP209' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_21277
if 
  50@ == 10 
else_jump @PIMP_21464 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_21464 
Model.Load(#BMYBU)

:PIMP_21321
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_21347 
wait 0 
jump @PIMP_21321 

:PIMP_21347
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP210' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_21464
if 
  50@ == 11 
else_jump @PIMP_21651 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_21651 
Model.Load(#BMYST)

:PIMP_21508
if 
   not Model.Available(#BMYST)
else_jump @PIMP_21534 
wait 0 
jump @PIMP_21508 

:PIMP_21534
91@(50@,28i) = Actor.Create(CivMale, #BMYST, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP211' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_21651
if 
  58@ == 4 
else_jump @PIMP_22509 
if 
  72@ == 1 
else_jump @PIMP_21748 
if 
  73@ == 1 
else_jump @PIMP_21748 
if 
  74@ == 1 
else_jump @PIMP_21748 
if 
  75@ == 1 
else_jump @PIMP_21748 
58@ = 5 

:PIMP_21748
0209: 50@ = random_int_in_ranges 12 16 
if 
  50@ == 12 
else_jump @PIMP_21948 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_21948 
Model.Load(#WMYBU)

:PIMP_21802
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_21829 
wait 0 
jump @PIMP_21802 

:PIMP_21829
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP212' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_21948
if 
  50@ == 13 
else_jump @PIMP_22135 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_22135 
Model.Load(#WMYDRUG)

:PIMP_21992
if 
   not Model.Available(#WMYDRUG)
else_jump @PIMP_22018 
wait 0 
jump @PIMP_21992 

:PIMP_22018
91@(50@,28i) = Actor.Create(CivMale, #WMYDRUG, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYDRUG)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP213' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_22135
if 
  50@ == 14 
else_jump @PIMP_22322 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_22322 
Model.Load(#BMYBU)

:PIMP_22179
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_22205 
wait 0 
jump @PIMP_22179 

:PIMP_22205
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP214' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_22322
if 
  50@ == 15 
else_jump @PIMP_22509 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_22509 
Model.Load(#WMYGOL1)

:PIMP_22366
if 
   not Model.Available(#WMYGOL1)
else_jump @PIMP_22392 
wait 0 
jump @PIMP_22366 

:PIMP_22392
91@(50@,28i) = Actor.Create(CivMale, #WMYGOL1, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYGOL1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP215' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_22509
if 
  58@ == 5 
else_jump @PIMP_23367 
if 
  76@ == 1 
else_jump @PIMP_22606 
if 
  77@ == 1 
else_jump @PIMP_22606 
if 
  78@ == 1 
else_jump @PIMP_22606 
if 
  79@ == 1 
else_jump @PIMP_22606 
58@ = 6 

:PIMP_22606
0209: 50@ = random_int_in_ranges 16 20 
if 
  50@ == 16 
else_jump @PIMP_22806 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_22806 
Model.Load(#WMYBU)

:PIMP_22660
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_22687 
wait 0 
jump @PIMP_22660 

:PIMP_22687
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP216' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_22806
if 
  50@ == 17 
else_jump @PIMP_22993 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_22993 
Model.Load(#WMYDRUG)

:PIMP_22850
if 
   not Model.Available(#WMYDRUG)
else_jump @PIMP_22876 
wait 0 
jump @PIMP_22850 

:PIMP_22876
91@(50@,28i) = Actor.Create(CivMale, #WMYDRUG, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYDRUG)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP217' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_22993
if 
  50@ == 18 
else_jump @PIMP_23180 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_23180 
Model.Load(#WMYCON)

:PIMP_23037
if 
   not Model.Available(#WMYCON)
else_jump @PIMP_23063 
wait 0 
jump @PIMP_23037 

:PIMP_23063
91@(50@,28i) = Actor.Create(CivMale, #WMYCON, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYCON)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP218' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_23180
if 
  50@ == 19 
else_jump @PIMP_23367 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_23367 
Model.Load(#WMYMECH)

:PIMP_23224
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_23250 
wait 0 
jump @PIMP_23224 

:PIMP_23250
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP219' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_23367
if 
  58@ == 6 
else_jump @PIMP_24020 
if 
  80@ == 1 
else_jump @PIMP_23446 
if 
  81@ == 1 
else_jump @PIMP_23446 
if 
  82@ == 1 
else_jump @PIMP_23446 
58@ = 7 

:PIMP_23446
0209: 50@ = random_int_in_ranges 20 23 
if 
  50@ == 20 
else_jump @PIMP_23646 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_23646 
Model.Load(#WMYBU)

:PIMP_23500
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_23527 
wait 0 
jump @PIMP_23500 

:PIMP_23527
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP220' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_23646
if 
  50@ == 21 
else_jump @PIMP_23833 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_23833 
Model.Load(#BMYBU)

:PIMP_23690
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_23716 
wait 0 
jump @PIMP_23690 

:PIMP_23716
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP221' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_23833
if 
  50@ == 22 
else_jump @PIMP_24020 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_24020 
Model.Load(#WMYSGRD)

:PIMP_23877
if 
   not Model.Available(#WMYSGRD)
else_jump @PIMP_23903 
wait 0 
jump @PIMP_23877 

:PIMP_23903
91@(50@,28i) = Actor.Create(CivMale, #WMYSGRD, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYSGRD)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP222' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_24020
if 
  58@ == 7 
else_jump @PIMP_24878 
if 
  83@ == 1 
else_jump @PIMP_24117 
if 
  84@ == 1 
else_jump @PIMP_24117 
if 
  85@ == 1 
else_jump @PIMP_24117 
if 
  86@ == 1 
else_jump @PIMP_24117 
58@ = 1 

:PIMP_24117
0209: 50@ = random_int_in_ranges 23 27 
if 
  50@ == 23 
else_jump @PIMP_24317 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_24317 
Model.Load(#WMYBU)

:PIMP_24171
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_24198 
wait 0 
jump @PIMP_24171 

:PIMP_24198
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP223' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_24317
if 
  50@ == 24 
else_jump @PIMP_24504 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_24504 
Model.Load(#WMYDRUG)

:PIMP_24361
if 
   not Model.Available(#WMYDRUG)
else_jump @PIMP_24387 
wait 0 
jump @PIMP_24361 

:PIMP_24387
91@(50@,28i) = Actor.Create(CivMale, #WMYDRUG, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYDRUG)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP224' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_24504
if 
  50@ == 25 
else_jump @PIMP_24691 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_24691 
Model.Load(#WMYBMX)

:PIMP_24548
if 
   not Model.Available(#WMYBMX)
else_jump @PIMP_24574 
wait 0 
jump @PIMP_24548 

:PIMP_24574
91@(50@,28i) = Actor.Create(CivMale, #WMYBMX, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#WMYBMX)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP225' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_24691
if 
  50@ == 26 
else_jump @PIMP_24878 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_24878 
Model.Load(#BMYBU)

:PIMP_24735
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_24761 
wait 0 
jump @PIMP_24735 

:PIMP_24761
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 287@(50@,28f), 315@(50@,28f), 343@(50@,28f))
Actor.Angle(91@(50@,28i)) = 371@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP226' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_24878
if 
04A4:   531@ == 3 
else_jump @PIMP_29178 
if 
  58@ == 1 
else_jump @PIMP_25754 
if 
  60@ == 1 
else_jump @PIMP_24993 
if 
  61@ == 1 
else_jump @PIMP_24993 
if 
  62@ == 1 
else_jump @PIMP_24993 
if 
  63@ == 1 
else_jump @PIMP_24993 
58@ = 2 

:PIMP_24993
0209: 50@ = random_int_in_ranges 0 4 
if 
  50@ == 0 
else_jump @PIMP_25189 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_25189 
Model.Load(#SWMYHP1)

:PIMP_25046
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_25072 
wait 0 
jump @PIMP_25046 

:PIMP_25072
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP300' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_25189
if 
  50@ == 1 
else_jump @PIMP_25376 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_25376 
Model.Load(#SWMYHP1)

:PIMP_25233
if 
   not Model.Available(#SWMYHP1)
else_jump @PIMP_25259 
wait 0 
jump @PIMP_25233 

:PIMP_25259
91@(50@,28i) = Actor.Create(CivMale, #SWMYHP1, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#SWMYHP1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP301' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_25376
if 
  50@ == 2 
else_jump @PIMP_25563 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_25563 
Model.Load(#BMYBU)

:PIMP_25420
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_25446 
wait 0 
jump @PIMP_25420 

:PIMP_25446
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP302' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_25563
if 
  50@ == 3 
else_jump @PIMP_25754 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_25754 
Model.Load(#WMYBU)

:PIMP_25608
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_25635 
wait 0 
jump @PIMP_25608 

:PIMP_25635
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP303' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_25754
if 
  58@ == 2 
else_jump @PIMP_26612 
if 
  64@ == 1 
else_jump @PIMP_25851 
if 
  65@ == 1 
else_jump @PIMP_25851 
if 
  66@ == 1 
else_jump @PIMP_25851 
if 
  67@ == 1 
else_jump @PIMP_25851 
58@ = 3 

:PIMP_25851
0209: 50@ = random_int_in_ranges 4 8 
if 
  50@ == 4 
else_jump @PIMP_26047 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_26047 
Model.Load(#DWMOLC1)

:PIMP_25904
if 
   not Model.Available(#DWMOLC1)
else_jump @PIMP_25930 
wait 0 
jump @PIMP_25904 

:PIMP_25930
91@(50@,28i) = Actor.Create(CivMale, #DWMOLC1, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#DWMOLC1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP304' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_26047
if 
  50@ == 5 
else_jump @PIMP_26234 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_26234 
Model.Load(#DWMOLC2)

:PIMP_26091
if 
   not Model.Available(#DWMOLC2)
else_jump @PIMP_26117 
wait 0 
jump @PIMP_26091 

:PIMP_26117
91@(50@,28i) = Actor.Create(CivMale, #DWMOLC2, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#DWMOLC2)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP305' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_26234
if 
  50@ == 6 
else_jump @PIMP_26421 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_26421 
Model.Load(#BMYBU)

:PIMP_26278
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_26304 
wait 0 
jump @PIMP_26278 

:PIMP_26304
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP306' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_26421
if 
  50@ == 7 
else_jump @PIMP_26612 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_26612 
Model.Load(#WMYBU)

:PIMP_26466
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_26493 
wait 0 
jump @PIMP_26466 

:PIMP_26493
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP307' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_26612
if 
  58@ == 3 
else_jump @PIMP_27470 
if 
  68@ == 1 
else_jump @PIMP_26709 
if 
  69@ == 1 
else_jump @PIMP_26709 
if 
  70@ == 1 
else_jump @PIMP_26709 
if 
  71@ == 1 
else_jump @PIMP_26709 
58@ = 4 

:PIMP_26709
0209: 50@ = random_int_in_ranges 8 12 
if 
  50@ == 8 
else_jump @PIMP_26905 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_26905 
Model.Load(#DWMOLC1)

:PIMP_26762
if 
   not Model.Available(#DWMOLC1)
else_jump @PIMP_26788 
wait 0 
jump @PIMP_26762 

:PIMP_26788
91@(50@,28i) = Actor.Create(CivMale, #DWMOLC1, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#DWMOLC1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP308' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_26905
if 
  50@ == 9 
else_jump @PIMP_27092 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_27092 
Model.Load(#DWMOLC2)

:PIMP_26949
if 
   not Model.Available(#DWMOLC2)
else_jump @PIMP_26975 
wait 0 
jump @PIMP_26949 

:PIMP_26975
91@(50@,28i) = Actor.Create(CivMale, #DWMOLC2, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#DWMOLC2)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP309' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_27092
if 
  50@ == 10 
else_jump @PIMP_27279 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_27279 
Model.Load(#BMYBU)

:PIMP_27136
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_27162 
wait 0 
jump @PIMP_27136 

:PIMP_27162
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP310' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_27279
if 
  50@ == 11 
else_jump @PIMP_27470 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_27470 
Model.Load(#WMYBU)

:PIMP_27324
if 
   not Model.Available(#WMYBU)
else_jump @PIMP_27351 
wait 0 
jump @PIMP_27324 

:PIMP_27351
91@(50@,28i) = Actor.Create(CivMale, #WMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP311' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_27470
if 
  58@ == 4 
else_jump @PIMP_28324 
if 
  72@ == 1 
else_jump @PIMP_27567 
if 
  73@ == 1 
else_jump @PIMP_27567 
if 
  74@ == 1 
else_jump @PIMP_27567 
if 
  75@ == 1 
else_jump @PIMP_27567 
58@ = 5 

:PIMP_27567
0209: 50@ = random_int_in_ranges 12 16 
if 
  50@ == 12 
else_jump @PIMP_27763 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_27763 
Model.Load(#WMYMECH)

:PIMP_27620
if 
   not Model.Available(#WMYMECH)
else_jump @PIMP_27646 
wait 0 
jump @PIMP_27620 

:PIMP_27646
91@(50@,28i) = Actor.Create(CivMale, #WMYMECH, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMYMECH)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP312' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_27763
if 
  50@ == 13 
else_jump @PIMP_27950 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_27950 
Model.Load(#DWMYLC1)

:PIMP_27807
if 
   not Model.Available(#DWMYLC1)
else_jump @PIMP_27833 
wait 0 
jump @PIMP_27807 

:PIMP_27833
91@(50@,28i) = Actor.Create(CivMale, #DWMYLC1, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#DWMYLC1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP313' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_27950
if 
  50@ == 14 
else_jump @PIMP_28137 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_28137 
Model.Load(#BMYBU)

:PIMP_27994
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_28020 
wait 0 
jump @PIMP_27994 

:PIMP_28020
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP314' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_28137
if 
  50@ == 15 
else_jump @PIMP_28324 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_28324 
Model.Load(#WMYDRUG)

:PIMP_28181
if 
   not Model.Available(#WMYDRUG)
else_jump @PIMP_28207 
wait 0 
jump @PIMP_28181 

:PIMP_28207
91@(50@,28i) = Actor.Create(CivMale, #WMYDRUG, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMYDRUG)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP315' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_28324
if 
  58@ == 5 
else_jump @PIMP_29178 
if 
  76@ == 1 
else_jump @PIMP_28421 
if 
  77@ == 1 
else_jump @PIMP_28421 
if 
  78@ == 1 
else_jump @PIMP_28421 
if 
  79@ == 1 
else_jump @PIMP_28421 
58@ = 1 

:PIMP_28421
0209: 50@ = random_int_in_ranges 16 20 
if 
  50@ == 16 
else_jump @PIMP_28617 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_28617 
Model.Load(#WMOPREA)

:PIMP_28474
if 
   not Model.Available(#WMOPREA)
else_jump @PIMP_28500 
wait 0 
jump @PIMP_28474 

:PIMP_28500
91@(50@,28i) = Actor.Create(CivMale, #WMOPREA, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMOPREA)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP316' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_28617
if 
  50@ == 17 
else_jump @PIMP_28804 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_28804 
Model.Load(#WMYST)

:PIMP_28661
if 
   not Model.Available(#WMYST)
else_jump @PIMP_28687 
wait 0 
jump @PIMP_28661 

:PIMP_28687
91@(50@,28i) = Actor.Create(CivMale, #WMYST, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#WMYST)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP317' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_28804
if 
  50@ == 18 
else_jump @PIMP_28991 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_28991 
Model.Load(#BMYBU)

:PIMP_28848
if 
   not Model.Available(#BMYBU)
else_jump @PIMP_28874 
wait 0 
jump @PIMP_28848 

:PIMP_28874
91@(50@,28i) = Actor.Create(CivMale, #BMYBU, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#BMYBU)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP318' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_28991
if 
  50@ == 19 
else_jump @PIMP_29178 
if 
  60@(50@,28i) == 0 
else_jump @PIMP_29178 
Model.Load(#DWMYLC1)

:PIMP_29035
if 
   not Model.Available(#DWMYLC1)
else_jump @PIMP_29061 
wait 0 
jump @PIMP_29035 

:PIMP_29061
91@(50@,28i) = Actor.Create(CivMale, #DWMYLC1, 399@(50@,28f), 427@(50@,28f), 455@(50@,28f))
Actor.Angle(91@(50@,28i)) = 483@(50@,28f)
Model.Destroy(#DWMYLC1)
02A9: set_actor 91@(50@,28i) immune_to_nonplayer 1 
00BC: show_text_highpriority GXT 'PIMP319' time 4000 flag 1  
47@ = 2 
32@ = 0 
60@(50@,28i) = 1 
119@(50@,28i) = 1 

:PIMP_29178
if 
  520@ == 1 
else_jump @PIMP_29735 
if 
  32@ > 5000 
else_jump @PIMP_29735 
if 
  1 > 49@ 
else_jump @PIMP_29301 
if 
  37@ == 0 
else_jump @PIMP_29267 
00BC: show_text_highpriority GXT 'PIMP_3' time 6000 flag 1  

:PIMP_29267
if 
  37@ == 1 
else_jump @PIMP_29301 
00BC: show_text_highpriority GXT 'PIMP_31' time 6000 flag 1  

:PIMP_29301
if 
  49@ > 0 
else_jump @PIMP_29721 
541@ = 1 
if 
   not 513@ == 1 
else_jump @PIMP_29721 
08D4: 529@ = create_panel_with_title 'PIMP_70' position 31.0 80.0 width 89.0 columns 2 interactive 0 background 1 alignment 1  
34@ = 1 
08DB: set_panel 529@ column 0 header 'PIMP_71' data 'PIMP_72' 'PIMP_73' 'PIMP_74' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel 529@ column 1 alignment 2 
528@ = 300 
0085: 526@ = 49@ 
006A: 526@ *= 528@ 
08EE: set_panel 529@ column 1 row 0 text_1number GXT 'DOLLAR' number 528@  
08EE: set_panel 529@ column 1 row 1 text_1number GXT 'PIMP_75' number 49@  
08EE: set_panel 529@ column 1 row 2 text_1number GXT 'DOLLAR' number 526@  
090E: set_panel 529@ active_row 2 
0093: 527@ = integer 526@ to_float 
if 
  37@ == 0 
else_jump @PIMP_29672 
00BC: show_text_highpriority GXT 'PIMP_7' time 6000 flag 1  
Player.Money(" + PlayerChar + @") += 526@
0624: add 527@ to_float_stat 36 

:PIMP_29672
if 
  37@ == 1 
else_jump @PIMP_29721 
00BC: show_text_highpriority GXT 'PIMP_32' time 6000 flag 1  
Player.Money(" + PlayerChar + @") += 526@
0624: add 527@ to_float_stat 36 

:PIMP_29721
520@ = 2 
32@ = 0 

:PIMP_29735
if 
  520@ == 2 
else_jump @PIMP_29809 
if 
  32@ > 6000 
else_jump @PIMP_29809 
if 
  34@ == 1 
else_jump @PIMP_29802 
08DA: remove_panel 529@ 
34@ = 0 

:PIMP_29802
520@ = 3 

:PIMP_29809
if 
  47@ == 2 
else_jump @PIMP_29982 
if 
   not Actor.Dead(91@(50@,28i))
else_jump @PIMP_29899 
if 
  37@ == 0 
else_jump @PIMP_29873 
0085: 511@ = 50@ 

:PIMP_29873
if 
  37@ == 1 
else_jump @PIMP_29899 
0085: 512@ = 50@ 

:PIMP_29899
Marker.Disable(89@)
89@ = Marker.CreateAboveActor(91@(50@,28i))
Marker.SetColor(89@, 4)
" + _8246 + @" = 180000 
014F: stop_timer " + _8246 + @" 
537@ = 0 
03C3: set_timer_to " + _8246 + @" type 1 GXT 'PIMP_90' 
537@ = 1 
47@ = 3 
48@ = 0 

:PIMP_29982
if 
  47@ == 3 
else_jump @PIMP_30738 
if 
   not Actor.Dead(91@(50@,28i))
else_jump @PIMP_30738 
if 
   not Car.Wrecked(40@)
else_jump @PIMP_30738 
if 
  521@ == 0 
else_jump @PIMP_30100 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_30100 
522@ = Marker.CreateAboveCar(40@)
07E0: set_marker 522@ type_to 1 
Marker.Disable(89@)
521@ = 1 

:PIMP_30100
if 
  521@ == 1 
else_jump @PIMP_30196 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_30196 
Marker.Disable(522@)
521@ = 0 
Marker.Disable(89@)
89@ = Marker.CreateAboveActor(91@(50@,28i))
Marker.SetColor(89@, 4)
00BC: show_text_highpriority GXT 'PIMP_53' time 6000 flag 1  
521@ = 0 

:PIMP_30196
if 
051A:   actor 91@(50@,28i) damaged_by_actor " + PlayerActor + @" 
else_jump @PIMP_30242 
00BC: show_text_highpriority GXT 'PIMP_52' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_30242
if 
   not Car.Wrecked(40@)
else_jump @PIMP_30738 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_30738 
if 
  46@ == 0 
else_jump @PIMP_30738 
if 
  521@ == 0 
else_jump @PIMP_30738 
if 
00F4:   actor " + PlayerActor + @" near_actor 91@(50@,28i) radius 10.0 10.0 0 in_car 
else_jump @PIMP_30738 
if 
  48@ == 0 
else_jump @PIMP_30449 
if 
  37@ == 0 
else_jump @PIMP_30408 
00BC: show_text_highpriority GXT 'PIMP_6' time 4000 flag 1  
48@ = 1 

:PIMP_30408
if 
  37@ == 1 
else_jump @PIMP_30449 
00BC: show_text_highpriority GXT 'PIMP_33' time 4000 flag 1  
48@ = 1 

:PIMP_30449
0085: 53@ = 37@ 
if 
01C1:   car 40@ stopped 
else_jump @PIMP_30738 
0639: AS_actor 91@(50@,28i) rotate_to_actor 35@(53@,2i) 
0687: clear_actor 35@(53@,2i) task 
0085: 54@ = 50@ 
537@ = 0 
014F: stop_timer " + _8246 + @" 
" + _8246 + @" = 180000 
0615: define_AS_pack_begin 39@ 
05CD: AS_actor -1 exit_car 40@ 
040D: unload_wav 4 
if 
04A4:   531@ == 1 
else_jump @PIMP_30592 
05D3: AS_actor -1 goto_point 175@(50@,28f) 203@(50@,28f) 231@(50@,28f) mode 6 time 10000 ms 

:PIMP_30592
if 
04A4:   531@ == 2 
else_jump @PIMP_30640 
05D3: AS_actor -1 goto_point 287@(50@,28f) 315@(50@,28f) 343@(50@,28f) mode 6 time 10000 ms 

:PIMP_30640
if 
04A4:   531@ == 3 
else_jump @PIMP_30688 
05D3: AS_actor -1 goto_point 399@(50@,28f) 427@(50@,28f) 455@(50@,28f) mode 6 time 10000 ms 

:PIMP_30688
0616: define_AS_pack_end 39@ 
0618: assign_actor 35@(53@,2i) to_AS_pack 39@ 
061B: remove_references_to_AS_pack 39@ 
46@ = 1 
55@ = 1 
47@ = 4 
32@ = 0 

:PIMP_30738
if 
  55@ == 1 
else_jump @PIMP_30900 
if 
   not Actor.Dead(35@(53@,2i))
else_jump @PIMP_30900 
if 
   not Actor.Dead(91@(54@,28i))
else_jump @PIMP_30900 
if 
00F2:   actor 35@(53@,2i) near_actor 91@(54@,28i) radius 3.0 3.0 0 
else_jump @PIMP_30900 
0687: clear_actor 35@(53@,2i) task 
0687: clear_actor 91@(54@,28i) task 
0677: AS_actor 35@(53@,2i) chat_with_actor 91@(54@,28i) lead_speaker_flag 1 unknown_flag 1 
0677: AS_actor 91@(54@,28i) chat_with_actor 35@(53@,2i) lead_speaker_flag 0 unknown_flag 1 
55@ = 0 

:PIMP_30900
if 
  47@ == 4 
else_jump @PIMP_31126 
if 
051A:   actor 91@(50@,28i) damaged_by_actor " + PlayerActor + @" 
else_jump @PIMP_30964 
00BC: show_text_highpriority GXT 'PIMP_52' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_30964
if 
   not Actor.Dead(35@(53@,2i))
else_jump @PIMP_31126 
if 
   not Actor.Dead(91@(50@,28i))
else_jump @PIMP_31126 
if 
  52@ == 1 
else_jump @PIMP_31029 
47@ = 15 

:PIMP_31029
if 
  52@ == 0 
else_jump @PIMP_31126 
if 
  37@ == 0 
else_jump @PIMP_31126 
42@ = 0 
41@ = 0 
37@ = 1 
47@ = 99 
Marker.Disable(89@)
45@ = 0 
44@ = 0 
46@ = 0 
52@ = 1 

:PIMP_31126
if 
  47@ == 15 
else_jump @PIMP_31230 
if 
051A:   actor 91@(50@,28i) damaged_by_actor " + PlayerActor + @" 
else_jump @PIMP_31190 
00BC: show_text_highpriority GXT 'PIMP_52' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_31190
Marker.Disable(89@)
45@ = 0 
44@ = 0 
46@ = 0 
gosub @PIMP_35660 
47@ = 20 

:PIMP_31230
if 
  47@ == 20 
else_jump @PIMP_31301 
if 
051A:   actor 91@(50@,28i) damaged_by_actor " + PlayerActor + @" 
else_jump @PIMP_31294 
00BC: show_text_highpriority GXT 'PIMP_52' time 8000 flag 1  
jump @PIMP_37455 

:PIMP_31294
47@ = 25 

:PIMP_31301
if 
  47@ == 25 
else_jump @PIMP_32099 
0209: 513@ = random_int_in_ranges 0 4 
if 
  2 > 49@ 
else_jump @PIMP_31353 
513@ = 3 

:PIMP_31353
if 
  513@ == 0 
else_jump @PIMP_31652 
47@ = 30 
00BC: show_text_highpriority GXT 'PIMP_35' time 6000 flag 1  
524@ = 1 
32@ = 0 
if 
  37@ == 0 
else_jump @PIMP_31530 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_31530 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(511@,28i))
0770: set_actor 91@(511@,28i) target_priority 1 
119@(511@,28i) = 0 
Marker.SetColor(90@, 0)
014F: stop_timer " + _8246 + @" 
" + _8246 + @" = 180000 
03C3: set_timer_to " + _8246 + @" type 1 GXT 'PIMP_90' 
537@ = 2 

:PIMP_31530
if 
  37@ == 1 
else_jump @PIMP_31652 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_31652 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(512@,28i))
0770: set_actor 91@(512@,28i) target_priority 1 
119@(512@,28i) = 0 
Marker.SetColor(90@, 0)
014F: stop_timer " + _8246 + @" 
" + _8246 + @" = 180000 
03C3: set_timer_to " + _8246 + @" type 1 GXT 'PIMP_90' 
537@ = 2 

:PIMP_31652
if 
  513@ == 1 
else_jump @PIMP_31975 
47@ = 40 
00BC: show_text_highpriority GXT 'PIMP_39' time 6000 flag 1  
525@ = 1 
32@ = 0 
if 
  37@ == 0 
else_jump @PIMP_31841 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_31841 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(511@,28i))
0770: set_actor 91@(511@,28i) target_priority 1 
119@(511@,28i) = 0 
03FE: set_actor 91@(511@,28i) money 250 
Marker.SetColor(90@, 0)
014F: stop_timer " + _8246 + @" 
" + _8246 + @" = 180000 
03C3: set_timer_to " + _8246 + @" type 1 GXT 'PIMP_90' 
537@ = 2 

:PIMP_31841
if 
  37@ == 1 
else_jump @PIMP_31975 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_31975 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(512@,28i))
0770: set_actor 91@(512@,28i) target_priority 1 
119@(512@,28i) = 0 
Marker.SetColor(90@, 0)
03FE: set_actor 91@(512@,28i) money 250 
014F: stop_timer " + _8246 + @" 
" + _8246 + @" = 180000 
03C3: set_timer_to " + _8246 + @" type 1 GXT 'PIMP_90' 
537@ = 2 

:PIMP_31975
if 
  513@ == 2 
else_jump @PIMP_32037 
523@ = 0 
47@ = 50 
00BC: show_text_highpriority GXT 'PIMP_56' time 4000 flag 1  
32@ = 0 
523@ = 1 

:PIMP_32037
if 
  513@ == 3 
else_jump @PIMP_32099 
523@ = 0 
47@ = 50 
00BC: show_text_highpriority GXT 'PIMP_56' time 4000 flag 1  
32@ = 0 
523@ = 1 

:PIMP_32099
if 
  47@ == 30 
else_jump @PIMP_32970 
if 
  525@ == 1 
else_jump @PIMP_32177 
if 
  32@ > 4000 
else_jump @PIMP_32177 
00BC: show_text_highpriority GXT 'PIMP_37' time 6000 flag 1  
525@ = 99 

:PIMP_32177
if 
  524@ == 1 
else_jump @PIMP_32237 
if 
  32@ > 4000 
else_jump @PIMP_32237 
00BC: show_text_highpriority GXT 'PIMP_36' time 6000 flag 1  
524@ = 99 

:PIMP_32237
if 
   not Car.Wrecked(40@)
else_jump @PIMP_32506 
if 
  521@ == 0 
else_jump @PIMP_32317 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_32317 
522@ = Marker.CreateAboveCar(40@)
07E0: set_marker 522@ type_to 1 
Marker.Disable(90@)
521@ = 1 

:PIMP_32317
if 
  521@ == 1 
else_jump @PIMP_32506 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_32506 
Marker.Disable(522@)
if 
  37@ == 0 
else_jump @PIMP_32421 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_32421 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(511@,28i))
Marker.SetColor(90@, 0)

:PIMP_32421
if 
  37@ == 1 
else_jump @PIMP_32483 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_32483 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(512@,28i))
Marker.SetColor(90@, 0)

:PIMP_32483
00BC: show_text_highpriority GXT 'PIMP_55' time 6000 flag 1  
521@ = 0 

:PIMP_32506
if 
  521@ == 0 
else_jump @PIMP_32838 
if 
  37@ == 0 
else_jump @PIMP_32681 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_32681 
if 
00F2:   actor " + PlayerActor + @" near_actor 35@(37@,2i) radius 50.0 50.0 0 
else_jump @PIMP_32681 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_32681 
0687: clear_actor 35@(37@,2i) task 
05E2: AS_actor 35@(37@,2i) kill_actor 91@(511@,28i) 
05E2: AS_actor 91@(511@,28i) kill_actor 35@(37@,2i) 
00BC: show_text_highpriority GXT 'PIMP_55' time 6000 flag 1  
47@ = 35 

:PIMP_32681
if 
  37@ == 1 
else_jump @PIMP_32838 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_32838 
if 
00F2:   actor " + PlayerActor + @" near_actor 35@(37@,2i) radius 50.0 50.0 0 
else_jump @PIMP_32838 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_32838 
05E2: AS_actor 91@(512@,28i) kill_actor 35@(37@,2i) 
0687: clear_actor 35@(37@,2i) task 
05E2: AS_actor 35@(37@,2i) kill_actor 91@(512@,28i) 
00BC: show_text_highpriority GXT 'PIMP_55' time 6000 flag 1  
47@ = 35 

:PIMP_32838
if 
  37@ == 0 
else_jump @PIMP_32904 
if 
   Actor.Dead(91@(511@,28i))
else_jump @PIMP_32904 
Marker.Disable(90@)
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
47@ = 50 

:PIMP_32904
if 
  37@ == 1 
else_jump @PIMP_32970 
if 
   Actor.Dead(91@(512@,28i))
else_jump @PIMP_32970 
Marker.Disable(90@)
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
47@ = 50 

:PIMP_32970
if 
  47@ == 35 
else_jump @PIMP_33511 
516@ = 99 
if 
  525@ == 1 
else_jump @PIMP_33055 
if 
  32@ > 4000 
else_jump @PIMP_33055 
00BC: show_text_highpriority GXT 'PIMP_37' time 6000 flag 1  
525@ = 99 

:PIMP_33055
if 
  524@ == 1 
else_jump @PIMP_33115 
if 
  32@ > 4000 
else_jump @PIMP_33115 
00BC: show_text_highpriority GXT 'PIMP_36' time 6000 flag 1  
524@ = 99 

:PIMP_33115
if 
   not Car.Wrecked(40@)
else_jump @PIMP_33379 
if 
  521@ == 0 
else_jump @PIMP_33190 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_33190 
522@ = Marker.CreateAboveCar(40@)
07E0: set_marker 522@ type_to 1 
521@ = 1 

:PIMP_33190
if 
  521@ == 1 
else_jump @PIMP_33379 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_33379 
Marker.Disable(522@)
if 
  37@ == 0 
else_jump @PIMP_33294 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_33294 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(511@,28i))
Marker.SetColor(90@, 0)

:PIMP_33294
if 
  37@ == 1 
else_jump @PIMP_33356 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_33356 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(512@,28i))
Marker.SetColor(90@, 0)

:PIMP_33356
00BC: show_text_highpriority GXT 'PIMP_55' time 6000 flag 1  
521@ = 0 

:PIMP_33379
if 
  37@ == 0 
else_jump @PIMP_33445 
if 
   Actor.Dead(91@(511@,28i))
else_jump @PIMP_33445 
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
Marker.Disable(90@)
47@ = 50 

:PIMP_33445
if 
  37@ == 1 
else_jump @PIMP_33511 
if 
   Actor.Dead(91@(512@,28i))
else_jump @PIMP_33511 
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
Marker.Disable(90@)
47@ = 50 

:PIMP_33511
if 
  47@ == 40 
else_jump @PIMP_34338 
if 
  525@ == 1 
else_jump @PIMP_33589 
if 
  32@ > 4000 
else_jump @PIMP_33589 
00BC: show_text_highpriority GXT 'PIMP_37' time 6000 flag 1  
525@ = 99 

:PIMP_33589
if 
  524@ == 1 
else_jump @PIMP_33649 
if 
  32@ > 4000 
else_jump @PIMP_33649 
00BC: show_text_highpriority GXT 'PIMP_36' time 6000 flag 1  
524@ = 99 

:PIMP_33649
if 
   not Car.Wrecked(40@)
else_jump @PIMP_33918 
if 
  521@ == 0 
else_jump @PIMP_33729 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_33729 
522@ = Marker.CreateAboveCar(40@)
07E0: set_marker 522@ type_to 1 
Marker.Disable(90@)
521@ = 1 

:PIMP_33729
if 
  521@ == 1 
else_jump @PIMP_33918 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_33918 
Marker.Disable(522@)
if 
  37@ == 0 
else_jump @PIMP_33833 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_33833 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(511@,28i))
Marker.SetColor(90@, 0)

:PIMP_33833
if 
  37@ == 1 
else_jump @PIMP_33895 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_33895 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(512@,28i))
Marker.SetColor(90@, 0)

:PIMP_33895
00BC: show_text_highpriority GXT 'PIMP_55' time 6000 flag 1  
521@ = 0 

:PIMP_33918
if 
  521@ == 0 
else_jump @PIMP_34206 
if 
  37@ == 0 
else_jump @PIMP_34071 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_34071 
if 
00F2:   actor " + PlayerActor + @" near_actor 35@(37@,2i) radius 20.0 20.0 0 
else_jump @PIMP_34071 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_34071 
05DD: AS_actor 91@(511@,28i) flee_from_actor " + PlayerActor + @" from_origin_radius 100.0 timelimit -1 
00BC: show_text_highpriority GXT 'PIMP_37' time 6000 flag 1  
47@ = 45 

:PIMP_34071
if 
  37@ == 1 
else_jump @PIMP_34206 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_34206 
if 
00F2:   actor " + PlayerActor + @" near_actor 35@(37@,2i) radius 20.0 20.0 0 
else_jump @PIMP_34206 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_34206 
05DD: AS_actor 91@(512@,28i) flee_from_actor " + PlayerActor + @" from_origin_radius 100.0 timelimit -1 
00BC: show_text_highpriority GXT 'PIMP_37' time 6000 flag 1  
47@ = 45 

:PIMP_34206
if 
  37@ == 0 
else_jump @PIMP_34272 
if 
   Actor.Dead(91@(511@,28i))
else_jump @PIMP_34272 
Marker.Disable(90@)
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
47@ = 50 

:PIMP_34272
if 
  37@ == 1 
else_jump @PIMP_34338 
if 
   Actor.Dead(91@(512@,28i))
else_jump @PIMP_34338 
Marker.Disable(90@)
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
47@ = 50 

:PIMP_34338
if 
  47@ == 45 
else_jump @PIMP_34889 
516@ = 99 
if 
  525@ == 1 
else_jump @PIMP_34423 
if 
  32@ > 4000 
else_jump @PIMP_34423 
00BC: show_text_highpriority GXT 'PIMP_37' time 6000 flag 1  
525@ = 99 

:PIMP_34423
if 
  524@ == 1 
else_jump @PIMP_34483 
if 
  32@ > 4000 
else_jump @PIMP_34483 
00BC: show_text_highpriority GXT 'PIMP_36' time 6000 flag 1  
524@ = 99 

:PIMP_34483
if 
   not Car.Wrecked(40@)
else_jump @PIMP_34747 
if 
  521@ == 0 
else_jump @PIMP_34558 
if 
   not Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_34558 
522@ = Marker.CreateAboveCar(40@)
07E0: set_marker 522@ type_to 1 
521@ = 1 

:PIMP_34558
if 
  521@ == 1 
else_jump @PIMP_34747 
if 
   Actor.InCar(" + PlayerActor + @", 40@)
else_jump @PIMP_34747 
Marker.Disable(522@)
if 
  37@ == 0 
else_jump @PIMP_34662 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_34662 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(511@,28i))
Marker.SetColor(90@, 0)

:PIMP_34662
if 
  37@ == 1 
else_jump @PIMP_34724 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_34724 
Marker.Disable(90@)
90@ = Marker.CreateAboveActor(91@(512@,28i))
Marker.SetColor(90@, 0)

:PIMP_34724
00BC: show_text_highpriority GXT 'PIMP_55' time 6000 flag 1  
521@ = 0 

:PIMP_34747
if 
  37@ == 0 
else_jump @PIMP_34818 
if 
   Actor.Dead(91@(511@,28i))
else_jump @PIMP_34818 
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
Marker.Disable(90@)
wait 2000 
47@ = 50 

:PIMP_34818
if 
  37@ == 1 
else_jump @PIMP_34889 
if 
   Actor.Dead(91@(512@,28i))
else_jump @PIMP_34889 
00BC: show_text_highpriority GXT 'PIMP_38' time 4000 flag 1  
Marker.Disable(90@)
wait 2000 
47@ = 50 

:PIMP_34889
if 
  47@ == 50 
else_jump @PIMP_35170 
537@ = 0 
014F: stop_timer " + _8246 + @" 
" + _8246 + @" = 180000 
516@ = 0 
if 
   not Actor.Dead(35@(37@,2i))
else_jump @PIMP_35114 
00BE: text_clear_all 
0687: clear_actor 35@(37@,2i) task 
Marker.Disable(88@)
88@ = Marker.CreateAboveActor(35@(37@,2i))
07E0: set_marker 88@ type_to 1 
47@ = 25 
if 
  37@ == 0 
else_jump @PIMP_35056 
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_35056 
Actor.RemoveReferences(91@(511@,28i))
119@(511@,28i) = 0 

:PIMP_35056
if 
  37@ == 1 
else_jump @PIMP_35114 
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_35114 
Actor.RemoveReferences(91@(512@,28i))
119@(512@,28i) = 0 

:PIMP_35114
47@ = 99 
42@ = 2 
49@ += 1 
0652: 540@ = integer_stat 210 
if 
801D:   not  540@ > 49@ 
else_jump @PIMP_35170 
0629: change_integer_stat 210 to 49@ 

:PIMP_35170
if 
   not Actor.Dead(91@(50@,28i))
else_jump @PIMP_35259 
if 
0104:   actor " + PlayerActor + @" near_actor 91@(50@,28i) radius 50.0 50.0 60.0 sphere 0 
else_jump @PIMP_35248 
0575: set_actor 91@(50@,28i) keep_position 0 
jump @PIMP_35259 

:PIMP_35248
0575: set_actor 91@(50@,28i) keep_position 1 

:PIMP_35259
if 
   not Actor.Dead(91@(511@,28i))
else_jump @PIMP_35348 
if 
0104:   actor " + PlayerActor + @" near_actor 91@(511@,28i) radius 50.0 50.0 60.0 sphere 0 
else_jump @PIMP_35337 
0575: set_actor 91@(511@,28i) keep_position 0 
jump @PIMP_35348 

:PIMP_35337
0575: set_actor 91@(511@,28i) keep_position 1 

:PIMP_35348
if 
   not Actor.Dead(91@(512@,28i))
else_jump @PIMP_35437 
if 
0104:   actor " + PlayerActor + @" near_actor 91@(512@,28i) radius 50.0 50.0 60.0 sphere 0 
else_jump @PIMP_35426 
0575: set_actor 91@(512@,28i) keep_position 0 
jump @PIMP_35437 

:PIMP_35426
0575: set_actor 91@(512@,28i) keep_position 1 

:PIMP_35437
if 
   not Actor.Dead(35@)
else_jump @PIMP_35510 
if 
0104:   actor " + PlayerActor + @" near_actor 35@ radius 50.0 50.0 60.0 sphere 0 
else_jump @PIMP_35503 
0575: set_actor 35@ keep_position 0 
jump @PIMP_35510 

:PIMP_35503
0575: set_actor 35@ keep_position 1 

:PIMP_35510
if 
   not Actor.Dead(36@)
else_jump @PIMP_35583 
if 
0104:   actor " + PlayerActor + @" near_actor 36@ radius 50.0 50.0 60.0 sphere 0 
else_jump @PIMP_35576 
0575: set_actor 36@ keep_position 0 
jump @PIMP_35583 

:PIMP_35576
0575: set_actor 36@ keep_position 1 

:PIMP_35583
jump @PIMP_3765 

:PIMP_35590
if 
   not 35@(37@,2i) == -1 
else_jump @PIMP_35658 
089F: get_actor 35@(37@,2i) pedtype_to 519@ 
if 
83A3:   not actor 35@(37@,2i) male 
else_jump @PIMP_35658 
41@ = 99 
42@ = 1 

:PIMP_35658
return 

:PIMP_35660
if 
  37@ == 0 
else_jump @PIMP_35687 
37@ = 1 
return 

:PIMP_35687
if 
  37@ == 1 
else_jump @PIMP_35714 
37@ = 0 
return 

:PIMP_35714
return 
return 

:PIMP_35718
if 
04A4:   531@ == 1 
else_jump @PIMP_36304 
if or
0154:   actor " + PlayerActor + @" in_zone 'IWD'  
0154:   actor " + PlayerActor + @" in_zone 'GAN'  
0154:   actor " + PlayerActor + @" in_zone 'ELCO'  
0154:   actor " + PlayerActor + @" in_zone 'LMEX'  
else_jump @PIMP_35810 
58@ = 1 

:PIMP_35810
if or
0154:   actor " + PlayerActor + @" in_zone 'LDOC'  
0154:   actor " + PlayerActor + @" in_zone 'LAIR'  
0154:   actor " + PlayerActor + @" in_zone 'LIND'  
0154:   actor " + PlayerActor + @" in_zone 'BLUF'  
else_jump @PIMP_35884 
58@ = 2 

:PIMP_35884
if or
0154:   actor " + PlayerActor + @" in_zone 'COM'  
0154:   actor " + PlayerActor + @" in_zone 'LDT'  
0154:   actor " + PlayerActor + @" in_zone 'GLN'  
0154:   actor " + PlayerActor + @" in_zone 'LMEX'  
else_jump @PIMP_35958 
58@ = 3 

:PIMP_35958
if or
0154:   actor " + PlayerActor + @" in_zone 'JEF'  
0154:   actor " + PlayerActor + @" in_zone 'ELS'  
0154:   actor " + PlayerActor + @" in_zone 'LFL'  
0154:   actor " + PlayerActor + @" in_zone 'EBE'  
else_jump @PIMP_36032 
58@ = 4 

:PIMP_36032
if or
0154:   actor " + PlayerActor + @" in_zone 'CONF'  
0154:   actor " + PlayerActor + @" in_zone 'VERO'  
0154:   actor " + PlayerActor + @" in_zone 'SMB'  
0154:   actor " + PlayerActor + @" in_zone 'MAR'  
0154:   actor " + PlayerActor + @" in_zone 'MKT'  
else_jump @PIMP_36120 
58@ = 5 

:PIMP_36120
if or
0154:   actor " + PlayerActor + @" in_zone 'SMB'  
0154:   actor " + PlayerActor + @" in_zone 'PLS'  
0154:   actor " + PlayerActor + @" in_zone 'ROD'  
0154:   actor " + PlayerActor + @" in_zone 'RIH'  
else_jump @PIMP_36194 
58@ = 6 

:PIMP_36194
if or
0154:   actor " + PlayerActor + @" in_zone 'VIN'  
0154:   actor " + PlayerActor + @" in_zone 'MUL'  
0154:   actor " + PlayerActor + @" in_zone 'SUN'  
else_jump @PIMP_36254 
58@ = 7 

:PIMP_36254
if 
  1 > 58@ 
else_jump @PIMP_36279 
58@ = 1 

:PIMP_36279
if 
  58@ > 7 
else_jump @PIMP_36304 
58@ = 1 

:PIMP_36304
if 
04A4:   531@ == 2 
else_jump @PIMP_36876 
if or
0154:   actor " + PlayerActor + @" in_zone 'BAYV'  
0154:   actor " + PlayerActor + @" in_zone 'PARA'  
0154:   actor " + PlayerActor + @" in_zone 'CIVI'  
0154:   actor " + PlayerActor + @" in_zone 'CITYS'  
else_jump @PIMP_36396 
58@ = 1 

:PIMP_36396
if or
0154:   actor " + PlayerActor + @" in_zone 'CALT'  
0154:   actor " + PlayerActor + @" in_zone 'JUNIHO'  
0154:   actor " + PlayerActor + @" in_zone 'JUNIHI'  
0154:   actor " + PlayerActor + @" in_zone 'ESPN'  
else_jump @PIMP_36470 
58@ = 2 

:PIMP_36470
if or
0154:   actor " + PlayerActor + @" in_zone 'SUNMA'  
0154:   actor " + PlayerActor + @" in_zone 'SUNNN'  
0154:   actor " + PlayerActor + @" in_zone 'GANTB'  
0154:   actor " + PlayerActor + @" in_zone 'BATTP'  
else_jump @PIMP_36544 
58@ = 3 

:PIMP_36544
if or
0154:   actor " + PlayerActor + @" in_zone 'CHINA'  
0154:   actor " + PlayerActor + @" in_zone 'SFDWT'  
0154:   actor " + PlayerActor + @" in_zone 'FINA'  
0154:   actor " + PlayerActor + @" in_zone 'ESPE'  
else_jump @PIMP_36618 
58@ = 4 

:PIMP_36618
if or
0154:   actor " + PlayerActor + @" in_zone 'WESTP'  
0154:   actor " + PlayerActor + @" in_zone 'HASH'  
0154:   actor " + PlayerActor + @" in_zone 'OCEAF'  
0154:   actor " + PlayerActor + @" in_zone 'CUNTC'  
else_jump @PIMP_36692 
58@ = 5 

:PIMP_36692
if or
0154:   actor " + PlayerActor + @" in_zone 'THEA'  
0154:   actor " + PlayerActor + @" in_zone 'GARC'  
0154:   actor " + PlayerActor + @" in_zone 'DOH'  
0154:   actor " + PlayerActor + @" in_zone 'EASB'  
else_jump @PIMP_36766 
58@ = 6 

:PIMP_36766
if or
0154:   actor " + PlayerActor + @" in_zone 'HILLP'  
0154:   actor " + PlayerActor + @" in_zone 'SILLY'  
0154:   actor " + PlayerActor + @" in_zone 'SFAIR'  
else_jump @PIMP_36826 
58@ = 7 

:PIMP_36826
if 
  1 > 58@ 
else_jump @PIMP_36851 
58@ = 1 

:PIMP_36851
if 
  58@ > 7 
else_jump @PIMP_36876 
58@ = 1 

:PIMP_36876
if 
04A4:   531@ == 3 
else_jump @PIMP_37314 
if or
0154:   actor " + PlayerActor + @" in_zone 'BFC'  
0154:   actor " + PlayerActor + @" in_zone 'GGC'  
0154:   actor " + PlayerActor + @" in_zone 'VAIR'  
0154:   actor " + PlayerActor + @" in_zone 'LDM'  
else_jump @PIMP_36968 
58@ = 1 

:PIMP_36968
if or
0154:   actor " + PlayerActor + @" in_zone 'PINK'  
0154:   actor " + PlayerActor + @" in_zone 'DRAG'  
0154:   actor " + PlayerActor + @" in_zone 'CAM'  
0154:   actor " + PlayerActor + @" in_zone 'LOT'  
else_jump @PIMP_37042 
58@ = 2 

:PIMP_37042
if or
0154:   actor " + PlayerActor + @" in_zone 'PIRA'  
0154:   actor " + PlayerActor + @" in_zone 'ROY'  
0154:   actor " + PlayerActor + @" in_zone 'CALI'  
0154:   actor " + PlayerActor + @" in_zone 'HIGH'  
else_jump @PIMP_37116 
58@ = 3 

:PIMP_37116
if or
0154:   actor " + PlayerActor + @" in_zone 'PILG' 
0154:   actor " + PlayerActor + @" in_zone 'STAR'  
0154:   actor " + PlayerActor + @" in_zone 'STRIP'  
0154:   actor " + PlayerActor + @" in_zone 'VISA'  
else_jump @PIMP_37190 
58@ = 4 

:PIMP_37190
if or
0154:   actor " + PlayerActor + @" in_zone 'ISLE'  
0154:   actor " + PlayerActor + @" in_zone 'ROCE'  
0154:   actor " + PlayerActor + @" in_zone 'OVS'  
0154:   actor " + PlayerActor + @" in_zone 'RING'  
else_jump @PIMP_37264 
58@ = 5 

:PIMP_37264
if 
  1 > 58@ 
else_jump @PIMP_37289 
58@ = 1 

:PIMP_37289
if 
  58@ > 5 
else_jump @PIMP_37314 
58@ = 1 

:PIMP_37314
return 

:PIMP_37316
0293: " + _13 + @" = get_controller_mode 
if 
   not " + _13 + @" == 3 
else_jump @PIMP_37397 

:PIMP_37339
if 
00E1:   player 0 pressed_key 19 
else_jump @PIMP_37390 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PIMP_37383 
jump @PIMP_37455 

:PIMP_37383
jump @PIMP_37339 

:PIMP_37390
jump @PIMP_37448 

:PIMP_37397
if 
00E1:   player 0 pressed_key 14 
else_jump @PIMP_37448 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @PIMP_37441 
jump @PIMP_37455 

:PIMP_37441
jump @PIMP_37397 

:PIMP_37448
jump @PIMP_37455 

:PIMP_37455
if 
  49@ == 0 
else_jump @PIMP_37489 
00BA: show_text_styled GXT 'PIMP_40' time 5000 style 1  

:PIMP_37489
if 
  49@ == 1 
else_jump @PIMP_37523 
00BA: show_text_styled GXT 'PIMP_41' time 5000 style 1  

:PIMP_37523
if 
  49@ == 2 
else_jump @PIMP_37557 
00BA: show_text_styled GXT 'PIMP_42' time 5000 style 1  

:PIMP_37557
if 
  49@ == 3 
else_jump @PIMP_37591 
00BA: show_text_styled GXT 'PIMP_43' time 5000 style 1  

:PIMP_37591
if 
  49@ == 4 
else_jump @PIMP_37625 
00BA: show_text_styled GXT 'PIMP_44' time 5000 style 1  

:PIMP_37625
if 
  49@ == 5 
else_jump @PIMP_37659 
00BA: show_text_styled GXT 'PIMP_45' time 5000 style 1  

:PIMP_37659
if 
  49@ == 6 
else_jump @PIMP_37693 
00BA: show_text_styled GXT 'PIMP_46' time 5000 style 1  

:PIMP_37693
if 
  49@ == 7 
else_jump @PIMP_37727 
00BA: show_text_styled GXT 'PIMP_47' time 5000 style 1  

:PIMP_37727
if 
  49@ == 8 
else_jump @PIMP_37761 
00BA: show_text_styled GXT 'PIMP_48' time 5000 style 1  

:PIMP_37761
if 
  49@ == 9 
else_jump @PIMP_37795 
00BA: show_text_styled GXT 'PIMP_49' time 5000 style 1  

:PIMP_37795
return 

:PIMP_37797
01E3: show_text_1number_styled GXT 'PIMP_50' number 1000 time 5000 style 1  
0394: play_music 2 
Player.Money(" + PlayerChar + @") += 1000
Player.ClearWantedLevel(" + PlayerChar + @")
if 
  " + Mission_Pimping_Passed + @" == 0 
else_jump @PIMP_37864 
0595: mission_complete 
// NEW BONUSES:
" + Pimp_Suit_Available + @" = 1
//
0A3D: enable_prostitutes_pay_you 1 and_scm_inject 
" + Mission_Pimping_Passed + @" = 1 

:PIMP_37864
return 

:PIMP_37866
040D: unload_wav 4 
014F: stop_timer " + _8246 + @" 
Model.Destroy(#WMYMECH)
Model.Destroy(#BMYST)
Model.Destroy(#WMYBU)
Model.Destroy(#BMYBU)
Model.Destroy(#WMYGOL1)
Model.Destroy(#WMYDRUG)
Model.Destroy(#DWMOLC2)
Model.Destroy(#DWMYLC1)
Model.Destroy(#DWMOLC1)
Model.Destroy(#WFYPRO)
Model.Destroy(#SWFOPRO)
Model.Destroy(#BFYPRO)
Model.Destroy(#HFYPRO)
Model.Destroy(#VWFYPRO)
Model.Destroy(#VBFYPRO)
Model.Destroy(#WMYSGRD)
Model.Destroy(#OMOST)
Model.Destroy(#WMYMECH)
Model.Destroy(#WMOPREA)
Model.Destroy(#WMYBMX)
Model.Destroy(#SWMYHP1)
Model.Destroy(#HMYST)
Model.Destroy(#BMYBOUN)
Model.Destroy(#BMYDJ)
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @PIMP_37998 
039E: set_actor " + PlayerActor + @" locked 0 while_in_car 

:PIMP_37998
Marker.Disable(88@)
Marker.Disable(89@)
Marker.Disable(90@)
Marker.Disable(522@)
if 
  34@ == 1 
else_jump @PIMP_38041 
08DA: remove_panel 529@ 

:PIMP_38041
0746: set_acquaintance 3 of_actors_pedtype 7 to_actors_pedtype 0 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + _162 + @" = 0 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}