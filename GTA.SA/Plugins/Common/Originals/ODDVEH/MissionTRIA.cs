﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class TRIA : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @TRIA_36 
if 
wasted_or_busted 
else_jump @TRIA_27 
gosub @TRIA_22678 

:TRIA_27
gosub @TRIA_22919 
end_thread 

:TRIA_36
0A0E: disable_text_with_style 1 
" + OnMission + @" = 1 
if 
  " + Mission_BeatTheCock_Passed + @" == 0 
else_jump @TRIA_67 
increment_mission_attempts 

:TRIA_67
054C: use_GXT_table 'RACETOR' 
0912: set_text_priority 1 leftmargin 355 maxwidth 370 
wait 0 
03F0: enable_text_draw 1 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRIA_130 
Player.CanMove(" + PlayerChar + @") = False

:TRIA_130
fade 0 1000 

:TRIA_137
if 
fading 
else_jump @TRIA_161 
wait 0 
jump @TRIA_137 

:TRIA_161
060A: create_decision_maker_type 0 store_to 816@ 
802@ = 0 
817@ = 0 
782@ = 0 
783@ = 0 
34@ = 582.7242 
46@ = 356.2812 
58@ = 52.2072 
70@ = 52.2072 
35@ = 584.0833 
47@ = 329.3647 
59@ = 0.5427 
71@ = 2.0841 
36@ = 572.9216 
48@ = 323.5937 
60@ = 1.0585 
72@ = 4.8106 
37@ = 585.724 
49@ = 345.6341 
61@ = 0.4929 
73@ = 1.8511 
38@ = 582.7242 
50@ = 359.0323 
62@ = 0.4993 
74@ = 2.637 
39@ = 582.7242 
51@ = 356.2812 
63@ = 56.2072 
75@ = 56.2072 
40@ = 582.7242 
52@ = 356.2812 
64@ = 58.2072 
76@ = 58.2072 
if 
  " + Mission_BeatTheCock_Type + @" == 1 
else_jump @TRIA_501 
jump @TRIA_526 

:TRIA_501
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_526 
jump @TRIA_3828 

:TRIA_526
819@ = 0 
820@ = 1 
821@ = 7 
822@ = 8 
823@ = 8 
824@ = 37 
825@ = 37 
826@ = 38 
827@ = 62 
792@ = -243.9 
793@ = -1719.31 
794@ = 2.35 
143@ = 181.3364 
263@ = -1885.854 
383@ = 3.5158 
503@ = 194.886 
144@ = 187.69 
264@ = -1915.42 
384@ = 0.0 
504@ = 187.4411 
145@ = 190.3243 
265@ = -1965.07 
385@ = -1.09 
505@ = 122.2256 
146@ = 129.4773 
266@ = -2001.432 
386@ = -0.5606 
506@ = 44.5101 
147@ = 24.1326 
267@ = -1872.092 
387@ = -0.1744 
507@ = 46.3064 
148@ = -38.8038 
268@ = -1799.4 
388@ = -0.4976 
508@ = 29.2224 
149@ = -132.8051 
269@ = -1809.788 
389@ = -1.1548 
509@ = 74.9425 
150@ = -228.93 
270@ = -1726.7 
390@ = -0.01 
510@ = 70.775 
151@ = -248.1052 
271@ = -1716.78 
391@ = 1.9372 
511@ = 157.2827 
152@ = -262.3395 
272@ = -1787.277 
392@ = 8.7655 
512@ = 167.5477 
153@ = -277.3514 
273@ = -1855.098 
393@ = 21.3005 
513@ = 168.3277 
154@ = -280.5171 
274@ = -1887.12 
394@ = 24.786 
514@ = 176.1066 
155@ = -281.7469 
275@ = -2087.827 
395@ = 38.443 
515@ = 141.1524 
156@ = -464.7682 
276@ = -2179.815 
396@ = 58.8239 
516@ = 68.1063 
157@ = -641.5079 
277@ = -2196.429 
397@ = 11.5282 
517@ = 129.7469 
158@ = -783.5144 
278@ = -2459.294 
398@ = 73.7524 
518@ = 140.2978 
159@ = -871.3914 
279@ = -2407.987 
399@ = 54.4911 
519@ = 51.7369 
160@ = -942.5181 
280@ = -2368.063 
400@ = 58.8718 
520@ = 85.4252 
161@ = -1056.249 
281@ = -2378.243 
401@ = 48.5923 
521@ = 94.4035 
162@ = -1238.965 
282@ = -2327.315 
402@ = 18.2458 
522@ = 58.7494 
163@ = -1403.78 
283@ = -2165.124 
403@ = 17.4059 
523@ = 77.2286 
164@ = -1659.685 
284@ = -2190.13 
404@ = 32.3572 
524@ = 144.7275 
165@ = -1732.831 
285@ = -2312.709 
405@ = 45.225 
525@ = 109.6972 
166@ = -1826.058 
286@ = -2340.271 
406@ = 33.7243 
526@ = 125.1071 
167@ = -1917.68 
287@ = -2432.147 
407@ = 29.6249 
527@ = 124.1505 
168@ = -1972.515 
288@ = -2478.326 
408@ = 29.6259 
528@ = 117.8682 
169@ = -2025.629 
289@ = -2500.391 
409@ = 31.0671 
529@ = 73.6687 
170@ = -2119.107 
290@ = -2431.265 
410@ = 29.4766 
530@ = 50.8121 
171@ = -2188.57 
291@ = -2377.538 
411@ = 29.6172 
531@ = 0.0 
172@ = -2215.89 
292@ = -2352.601 
412@ = 29.6981 
532@ = 61.4763 
173@ = -2341.21 
293@ = -2256.627 
413@ = 16.8759 
533@ = 39.8273 
174@ = -2430.18 
294@ = -2278.378 
414@ = 13.7817 
534@ = 45.7545 
175@ = -2498.637 
295@ = -2208.573 
415@ = 27.9284 
535@ = 50.0042 
176@ = -2619.839 
296@ = -2067.536 
416@ = 38.1676 
536@ = 55.7597 
176@ = -2867.784 
296@ = -1824.571 
416@ = 36.6821 
536@ = 16.2011 
177@ = -2923.241 
297@ = -1561.889 
417@ = 10.0017 
537@ = 7.7626 
178@ = -2899.031 
298@ = -1152.584 
418@ = 8.32 
538@ = 351.8611 
179@ = -2858.125 
299@ = -835.5231 
419@ = 8.4844 
539@ = 352.7365 
180@ = -2814.01 
300@ = -529.22 
420@ = 6.1876 
540@ = 343.4993 
181@ = -2779.95 
301@ = -489.85 
421@ = 6.33 
541@ = 305.3686 
182@ = -2708.981 
302@ = -529.5283 
422@ = 10.196 
542@ = 276.1151 
183@ = -2670.157 
303@ = -481.2506 
423@ = 21.3104 
543@ = 345.938 
184@ = -2666.663 
304@ = -406.0401 
424@ = 31.3067 
544@ = 324.8106 
185@ = -2583.74 
305@ = -369.7502 
425@ = 46.2653 
545@ = 275.6224 
186@ = -2515.971 
306@ = -367.1822 
426@ = 58.2571 
546@ = 272.1555 
186@ = -2411.156 
306@ = -371.7223 
426@ = 72.2992 
546@ = 236.1908 
187@ = -2340.564 
307@ = -416.5017 
427@ = 78.5669 
547@ = 230.3644 
188@ = -2338.824 
308@ = -463.832 
428@ = 79.0233 
548@ = 107.323 
189@ = -2387.69 
309@ = -423.99 
429@ = 82.4307 
549@ = 46.7979 
190@ = -2496.379 
310@ = -446.1119 
430@ = 75.3116 
550@ = 79.2676 
191@ = -2544.498 
311@ = -465.218 
431@ = 68.9665 
551@ = 119.0487 
191@ = -2556.852 
311@ = -466.8922 
431@ = 69.2275 
551@ = 116.1301 
192@ = -2580.532 
312@ = -468.6765 
432@ = 67.3814 
552@ = 105.1953 
193@ = -2612.064 
313@ = -475.2015 
433@ = 67.8512 
553@ = 102.5922 
194@ = -2623.105 
314@ = -500.2463 
434@ = 69.917 
554@ = 197.9217 
195@ = -2613.75 
315@ = -497.1339 
435@ = 71.9272 
555@ = 288.9547 
196@ = -2579.733 
316@ = -492.6317 
436@ = 75.158 
556@ = 278.9598 
197@ = -2542.8 
317@ = -490.87 
437@ = 80.34 
557@ = 280.2745 
198@ = -2497.678 
318@ = -480.3432 
438@ = 94.0158 
558@ = 282.4144 
199@ = -2466.401 
319@ = -497.2612 
439@ = 104.2728 
559@ = 198.2153 
200@ = -2452.08 
320@ = -544.5864 
440@ = 120.5837 
560@ = 197.1636 
201@ = -2469.514 
321@ = -618.502 
441@ = 131.3831 
561@ = 208.6952 
202@ = -2471.06 
322@ = -618.73 
442@ = 131.73 
562@ = 85.5749 
203@ = -2498.368 
323@ = -617.9995 
443@ = 131.5625 
563@ = 94.5939 
204@ = -2498.981 
324@ = -653.2845 
444@ = 137.3194 
564@ = 168.6758 
205@ = -2501.356 
325@ = -695.9691 
445@ = 138.3174 
565@ = 180.3733 
743@ = -2500.0 
744@ = -710.0 
745@ = 138.49 
828@ = 63 
118@ = 9 
04AF: 829@ = 154 
04AF: 830@ = 18 
04AF: 831@ = 45 
04AF: 832@ = 18 
04AF: 833@ = 45 
04AF: 834@ = 154 
04AF: 835@ = 154 
04AF: 836@ = 167 
04AF: 837@ = 167 
04AF: 838@ = 167 
04AF: 839@ = 167 
04AF: 840@ = 167 
04AF: 841@ = 510 
04AF: 842@ = 510 
04AF: 843@ = 510 
04AF: 844@ = 510 
04AF: 845@ = 510 
04AF: 846@ = 510 
04AF: 847@ = 510 
04AF: 848@ = 510 
04AF: 849@ = 510 
04AF: 850@ = 510 
04AF: 851@ = 510 
04AF: 852@ = 510 
770@ = 60.0 
771@ = 40.0 
772@ = 25.0 
773@ = 2.25 
774@ = 2.0 
775@ = 1.8 
776@ = 1.3 
777@ = 1.25 
778@ = 1.16 
695@ = 2.3 
707@ = -6.0 
696@ = 3.0 
708@ = 8.0 
697@ = 5.0 
709@ = -4.0 
698@ = 2.6 
710@ = -1.0 
699@ = 5.0 
711@ = 9.0 
700@ = 0.0 
712@ = -4.0 
701@ = -4.0 
713@ = 0.0 
702@ = 0.0 
714@ = 0.9 
703@ = 3.1 
715@ = -4.0 
704@ = 3.0 
716@ = -5.0 
705@ = -5.0 
717@ = -3.0 
706@ = -2.0 
718@ = 9.0 
jump @TRIA_8781 

:TRIA_3828
819@ = 0 
820@ = 1 
821@ = 9 
822@ = 10 
823@ = 10 
824@ = 96 
825@ = 96 
826@ = 97 
827@ = 103 
792@ = 1408.9 
793@ = -298.31 
794@ = 1.14 
143@ = 2135.432 
263@ = -67.9555 
383@ = 5.4915 
503@ = 66.3885 
144@ = 2113.189 
264@ = -61.7735 
384@ = -1.6317 
504@ = 79.829 
145@ = 2042.62 
265@ = -68.5141 
385@ = -1.9576 
505@ = 105.8667 
146@ = 1914.295 
266@ = -82.3669 
386@ = -1.573 
506@ = 101.7482 
147@ = 1844.035 
267@ = -62.2716 
387@ = -1.6096 
507@ = 84.9519 
148@ = 1742.236 
268@ = -20.0478 
388@ = -1.287 
508@ = 79.6055 
149@ = 1618.168 
269@ = -15.6618 
389@ = -1.6797 
509@ = 156.9966 
150@ = 1599.854 
270@ = -118.7409 
390@ = -1.4099 
510@ = 164.6305 
151@ = 1533.974 
271@ = -213.8303 
391@ = -1.8143 
511@ = 126.3196 
152@ = 1426.781 
272@ = -284.0623 
392@ = 0.4372 
512@ = 144.5477 
153@ = 1398.955 
273@ = -320.351 
393@ = 4.0182 
513@ = 153.3551 
154@ = 1358.093 
274@ = -336.8423 
394@ = 1.9089 
514@ = 116.3511 
155@ = 1289.739 
275@ = -376.0291 
395@ = 1.8575 
515@ = 115.9818 
156@ = 1226.153 
276@ = -418.5785 
396@ = 4.1044 
516@ = 98.6074 
157@ = 1042.313 
277@ = -450.289 
397@ = 50.3135 
517@ = 101.4914 
158@ = 955.7357 
278@ = -394.1266 
398@ = 62.9355 
518@ = 78.1451 
159@ = 862.81 
279@ = -348.28 
399@ = 35.11 
519@ = 56.0 
160@ = 735.1562 
280@ = -269.1867 
400@ = 8.7576 
520@ = 73.8366 
161@ = 469.2164 
281@ = -284.2076 
401@ = 9.4602 
521@ = 112.1922 
162@ = 251.8701 
282@ = -371.7388 
402@ = 7.7356 
522@ = 68.255 
163@ = 223.9637 
283@ = -281.344 
403@ = 0.4297 
523@ = 271.1071 
164@ = 232.8023 
284@ = -147.7986 
404@ = 0.4375 
524@ = 357.6566 
165@ = 212.8295 
285@ = 51.8381 
405@ = 1.0781 
525@ = 109.6694 
166@ = -68.0222 
286@ = 199.2302 
406@ = 1.1111 
526@ = 65.8208 
167@ = -214.4978 
287@ = 242.3661 
407@ = 10.9924 
527@ = 77.1542 
168@ = -474.3636 
288@ = 283.1361 
408@ = 1.0859 
528@ = 87.3102 
169@ = -704.3909 
289@ = 237.3473 
409@ = 1.2298 
529@ = 125.775 
170@ = -753.5148 
290@ = 113.9041 
410@ = 13.0728 
530@ = 238.8586 
171@ = -774.6131 
291@ = 19.818 
411@ = 32.2693 
531@ = 99.2499 
172@ = -882.6287 
292@ = -30.0806 
412@ = 32.3448 
532@ = 159.807 
173@ = -693.5931 
293@ = 14.1184 
413@ = 64.7495 
533@ = 274.7533 
174@ = -747.8843 
294@ = -87.2834 
414@ = 65.6724 
534@ = 116.1896 
175@ = -914.7136 
295@ = -149.6012 
415@ = 52.8499 
535@ = 134.4302 
176@ = -962.9247 
296@ = -326.8087 
416@ = 35.2353 
536@ = 168.4629 
177@ = -1053.014 
297@ = -459.1835 
417@ = 34.307 
537@ = 115.9967 
178@ = -1192.145 
298@ = -713.6215 
418@ = 54.6026 
538@ = 156.9905 
179@ = -1487.715 
299@ = -817.6843 
419@ = 64.4213 
539@ = 92.4112 
180@ = -1740.777 
300@ = -724.1766 
420@ = 30.4857 
540@ = 49.0549 
181@ = -1781.205 
301@ = -583.264 
421@ = 15.3359 
541@ = 100.3213 
182@ = -1823.7 
302@ = -529.5533 
422@ = 13.9686 
542@ = 4.2211 
183@ = -1799.017 
303@ = -273.0101 
423@ = 20.3398 
543@ = 354.7032 
184@ = -1800.123 
304@ = -65.1682 
424@ = 10.9423 
544@ = 359.6422 
185@ = -1725.062 
305@ = 327.4661 
425@ = 6.039 
545@ = 315.311 
186@ = -1557.097 
306@ = 578.606 
426@ = 6.028 
546@ = 0.4208 
187@ = -1541.106 
307@ = 769.1249 
427@ = 6.0391 
547@ = 353.7148 
188@ = -1583.378 
308@ = 1116.991 
428@ = 6.0468 
548@ = 1.1392 
189@ = -1809.283 
309@ = 1378.625 
429@ = 6.0391 
549@ = 81.656 
190@ = -2100.213 
310@ = 1275.833 
430@ = 15.1271 
550@ = 95.1487 
191@ = -2350.208 
311@ = 1176.574 
431@ = 41.5671 
551@ = 90.0114 
192@ = -2510.877 
312@ = 1187.856 
432@ = 39.1262 
552@ = 85.252 
193@ = -2669.68 
313@ = 1245.143 
433@ = 54.4297 
553@ = 8.9025 
194@ = -2673.893 
314@ = 1643.352 
434@ = 65.0251 
554@ = 0.2767 
195@ = -2674.047 
315@ = 2075.544 
435@ = 54.4218 
555@ = 359.5528 
196@ = -2738.813 
316@ = 2389.167 
436@ = 71.7769 
556@ = 13.6254 
197@ = -2547.931 
317@ = 2616.462 
437@ = 59.9948 
557@ = 274.8428 
198@ = -2291.888 
318@ = 2639.561 
438@ = 54.2564 
558@ = 274.3506 
199@ = -1943.441 
319@ = 2477.796 
439@ = 53.9877 
559@ = 203.7195 
200@ = -1773.83 
320@ = 2183.409 
440@ = 15.1278 
560@ = 244.4939 
201@ = -1671.435 
321@ = 1994.474 
441@ = 18.605 
561@ = 169.1263 
202@ = -1665.7 
322@ = 1828.964 
442@ = 24.836 
562@ = 278.2649 
203@ = -1515.527 
323@ = 1841.554 
443@ = 28.9903 
563@ = 271.1894 
204@ = -1264.993 
324@ = 1827.301 
444@ = 39.4348 
564@ = 234.95 
205@ = -1121.385 
325@ = 1807.539 
445@ = 41.2592 
565@ = 284.4989 
206@ = -988.9796 
326@ = 1847.639 
446@ = 61.9118 
566@ = 237.4219 
207@ = -855.0579 
327@ = 1858.897 
447@ = 59.216 
567@ = 15.0168 
208@ = -827.7874 
328@ = 2022.61 
448@ = 59.1866 
568@ = 302.1424 
209@ = -643.984 
329@ = 2054.752 
449@ = 59.3829 
569@ = 252.3283 
210@ = -460.4977 
330@ = 2022.137 
450@ = 59.1932 
570@ = 314.0172 
211@ = -385.3306 
331@ = 2052.059 
451@ = 61.1139 
571@ = 121.3349 
212@ = -471.1979 
332@ = 1868.452 
452@ = 81.3094 
572@ = 185.3215 
213@ = -424.8187 
333@ = 1785.552 
453@ = 69.9688 
573@ = 353.9297 
214@ = -392.5027 
334@ = 1899.678 
454@ = 56.3096 
574@ = 190.7471 
215@ = -437.5663 
335@ = 1639.054 
455@ = 34.5544 
575@ = 155.0889 
216@ = -419.9048 
336@ = 1375.711 
456@ = 29.3441 
576@ = 198.0373 
217@ = -254.2456 
337@ = 1241.245 
457@ = 22.9055 
577@ = 262.7647 
218@ = -17.3116 
338@ = 1265.996 
458@ = 7.1868 
578@ = 269.9033 
219@ = 207.218 
339@ = 1174.193 
459@ = 13.9973 
579@ = 316.9584 
220@ = 339.0704 
340@ = 1382.287 
460@ = 6.1753 
580@ = 342.3971 
221@ = 388.3414 
341@ = 1547.929 
461@ = 13.8468 
581@ = 343.6689 
222@ = 633.4001 
342@ = 1754.867 
462@ = 3.9566 
582@ = 317.1131 
223@ = 669.8152 
343@ = 2168.323 
463@ = 20.5117 
583@ = 358.9947 
224@ = 689.647 
344@ = 2565.16 
464@ = 27.2334 
584@ = 311.5221 
225@ = 891.8608 
345@ = 2603.754 
465@ = 9.595 
585@ = 247.505 
226@ = 1044.021 
346@ = 2515.857 
466@ = 9.6323 
586@ = 231.5339 
227@ = 1244.597 
347@ = 2379.124 
467@ = 12.6162 
587@ = 243.279 
228@ = 1443.869 
348@ = 2448.945 
468@ = 5.7498 
588@ = 288.6619 
229@ = 1666.893 
349@ = 2445.993 
469@ = 6.0409 
589@ = 251.8771 
230@ = 1788.89 
350@ = 2302.641 
470@ = 4.9096 
590@ = 178.4221 
231@ = 1787.288 
351@ = 2020.553 
471@ = 2.9839 
591@ = 180.0315 
232@ = 1757.569 
352@ = 1803.75 
472@ = 6.6726 
592@ = 151.3169 
233@ = 1719.659 
353@ = 1733.205 
473@ = 9.6719 
593@ = 76.1769 
234@ = 1647.86 
354@ = 1740.389 
474@ = 9.6719 
594@ = 353.7883 
235@ = 1666.322 
355@ = 1871.767 
475@ = 9.6797 
595@ = 276.203 
236@ = 1707.177 
356@ = 1939.953 
476@ = 9.6719 
596@ = 1.2039 
237@ = 1736.212 
357@ = 2053.139 
477@ = 9.6797 
597@ = 263.9626 
238@ = 1897.32 
358@ = 2044.712 
478@ = 9.6719 
598@ = 254.9706 
239@ = 1994.816 
359@ = 2022.869 
479@ = 9.6797 
599@ = 270.1811 
240@ = 2126.005 
360@ = 2014.889 
480@ = 9.6719 
600@ = 199.0654 
241@ = 2126.798 
361@ = 1885.59 
481@ = 9.6797 
601@ = 178.0925 
242@ = 2098.335 
362@ = 1802.86 
482@ = 9.6797 
602@ = 156.4693 
243@ = 2056.644 
363@ = 1720.575 
483@ = 9.6719 
603@ = 156.0535 
244@ = 2049.26 
364@ = 1554.789 
484@ = 9.6719 
604@ = 179.2217 
245@ = 2050.827 
365@ = 1403.362 
485@ = 9.6719 
605@ = 179.9112 
246@ = 2048.7 
366@ = 1089.746 
486@ = 9.6641 
606@ = 179.8144 
743@ = 2046.0 
744@ = 979.0 
745@ = 9.49 
828@ = 104 
118@ = 9 
04AF: 829@ = 154 
04AF: 830@ = 18 
04AF: 831@ = 45 
04AF: 832@ = 18 
04AF: 833@ = 45 
04AF: 834@ = 154 
04AF: 835@ = 154 
04AF: 836@ = 167 
04AF: 837@ = 167 
04AF: 838@ = 167 
04AF: 839@ = 167 
04AF: 840@ = 167 
04AF: 841@ = 510 
04AF: 842@ = 510 
04AF: 843@ = 510 
04AF: 844@ = 510 
04AF: 845@ = 510 
04AF: 846@ = 510 
04AF: 847@ = 510 
04AF: 848@ = 510 
04AF: 849@ = 510 
04AF: 850@ = 510 
04AF: 851@ = 510 
04AF: 852@ = 510 
770@ = 50.0 
771@ = 40.0 
772@ = 30.0 
773@ = 2.23 
774@ = 2.1 
775@ = 1.8 
776@ = 1.33 
777@ = 1.3 
778@ = 1.25 
695@ = 2.3 
707@ = -6.0 
696@ = 3.0 
708@ = -4.0 
697@ = 5.0 
709@ = -4.0 
698@ = 2.6 
710@ = -1.0 
699@ = 5.0 
711@ = 5.0 
700@ = 0.0 
712@ = -4.0 
701@ = -4.0 
713@ = 0.0 
702@ = 0.0 
714@ = 0.9 
703@ = 3.1 
715@ = -4.0 
704@ = 3.0 
716@ = -5.0 
705@ = -5.0 
717@ = -3.0 
706@ = -2.0 
718@ = 4.0 
746@ = 0 
747@ = 0 
748@ = 0 
749@ = 0 
750@ = 0 
751@ = 0 
752@ = 0 
753@ = 0 
754@ = 0 
755@ = 0 
756@ = 0 
757@ = 0 
jump @TRIA_8781 
06D5: 963@ = create_racing_checkpoint_at 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) point_to 960@ 961@ 962@ type 0 radius 6.0 
06D6: disable_racing_checkpoint 963@ 

:TRIA_8781
0087: 779@ = 770@ 
0087: 780@ = 773@ 
0087: 781@ = 776@ 

:TRIA_8805
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRIA_8832 
wait 0 
jump @TRIA_8805 

:TRIA_8832
0395: clear_area 0 at 143@ 263@ 383@ radius 1000001.0 
Camera.SetAtPos(143@, 263@, 383@)
08E7: disable_entrance_markers 1 
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
0085: 853@ = 828@ 
853@ -= 1 
758@ = 0 
759@ = 0 
760@ = 0 
761@ = 0 
0085: 926@ = 118@ 

:TRIA_8930
if 
001D:   926@ > 759@ 
else_jump @TRIA_8974 
927@(759@,12i) = 0 
759@ += 1 
jump @TRIA_8930 

:TRIA_8974
018A: 939@ = create_checkpoint_at 143@ 263@ 383@ 
940@ = 0 

:TRIA_8995
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
942@ = 0 
759@ = 0 
if 
  940@ == 0 
else_jump @TRIA_9266 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRIA_9266 
Actor.PutAt(" + PlayerActor + @", 143@, 263@, 383@)
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Player.SetClothes(" + PlayerChar + @", ""BBSHORTWHT"", ""BOXINGSHORT"", Legs)
Player.Build(" + PlayerChar + @")
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 144@ 264@ radius 100.0 100.0 
else_jump @TRIA_9266 
758@ = 0 
0088: " + tempvar_Float_1 + @" = 143@ 
" + tempvar_Float_1 + @" += 4.0 
0088: " + tempvar_Float_2 + @" = 263@ 
" + tempvar_Float_2 + @" += 4.0 
0088: " + tempvar_Float_3 + @" = 383@ 
" + tempvar_Float_3 + @" += 6.0 
0087: 785@ = 143@ 
785@ -= 7.0 
0087: 786@ = 263@ 
786@ -= 7.0 
0087: 787@ = 383@ 
787@ -= 7.0 
940@ += 1 

:TRIA_9266
if 
  940@ == 1 
else_jump @TRIA_9359 
Model.Load(#WMYBE)
Model.Load(#BMYBE)
Model.Load(#HMYBE)
Model.Load(#WMYBELL)
Model.Load(#MTBIKE)

:TRIA_9307
if or
   not Model.Available(#WMYBE)
   not Model.Available(#BMYBE)
   not Model.Available(#HMYBE)
   not Model.Available(#WMYBELL)
   not Model.Available(#MTBIKE)
else_jump @TRIA_9352 
wait 0 
jump @TRIA_9307 

:TRIA_9352
940@ = 2 

:TRIA_9359
if 
  940@ == 2 
else_jump @TRIA_11299 
768@ = Car.Create(841@, 143@, 263@, 383@)
039F: set_car 768@ race_to 144@ 264@ 
0085: 762@ = 926@ 
762@ -= 1 
769@ = Car.Create(841@, 143@(822@,120f), 263@(822@,120f), -100.0)
Car.Angle(769@) = 503@(822@,120f)
0407: store_coords_to 785@ 786@ 787@ from_car 769@ with_offset 785@ 786@ 787@ 
791@ = Car.Angle(769@)
0087: 787@ = 383@ 
759@ = 0 

:TRIA_9505
if 
001D:   926@ > 759@ 
else_jump @TRIA_11059 
0085: 760@ = 759@ 
760@ /= 2 
760@ *= 2 
if 
003B:   760@ == 759@ 
else_jump @TRIA_9623 
" + tempvar_Float_1 + @" = 1.5 
0085: 761@ = 759@ 
761@ *= 2 
0093: 788@ = integer 761@ to_float 
788@ *= -1.0 
0088: " + tempvar_Float_2 + @" = 788@ 
jump @TRIA_9681 

:TRIA_9623
" + tempvar_Float_1 + @" = -1.5 
0085: 761@ = 759@ 
761@ -= 1 
761@ *= 2 
0093: 788@ = integer 761@ to_float 
788@ *= -1.0 
0088: " + tempvar_Float_2 + @" = 788@ 

:TRIA_9681
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
789@ = Car.Angle(768@)
0088: " + tempvar_Float_3 + @" = 383@ 
0089: 854@(759@,12f) = " + tempvar_Float_1 + @" 
0089: 866@(759@,12f) = " + tempvar_Float_2 + @" 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0089: 878@(759@,12f) = " + tempvar_Float_3 + @" 
if 
001D:   762@ > 759@ 
else_jump @TRIA_10303 
914@(759@,12i) = Actor.Create(CivMale, 829@(759@,12i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", -100.0)
02A9: set_actor 914@(759@,12i) immune_to_nonplayer 1 
060B: set_actor 914@(759@,12i) decision_maker_to 816@ 
131@(759@,12i) = 0 
804@(759@,12i) = 0 
Actor.Angle(914@(759@,12i)) = 503@
04D8: set_actor 914@(759@,12i) drowns_in_water 0 
054E: clear_actor 914@(759@,12i) damage 
054A: set_actor 914@(759@,12i) can_be_shot_in_a_car 0 
if 
  131@(759@,12i) == 0 
else_jump @TRIA_10296 
0085: 760@ = 759@ 
760@ /= 2 
760@ *= 2 
if 
003B:   760@ == 759@ 
else_jump @TRIA_10027 
" + tempvar_Float_1 + @" = 3.5 
0085: 761@ = 759@ 
761@ *= 2 
0093: 788@ = integer 761@ to_float 
788@ *= -1.0 
0088: " + tempvar_Float_2 + @" = 788@ 
jump @TRIA_10085 

:TRIA_10027
" + tempvar_Float_1 + @" = -3.5 
0085: 761@ = 759@ 
761@ -= 1 
761@ *= 2 
0093: 788@ = integer 761@ to_float 
788@ *= -1.0 
0088: " + tempvar_Float_2 + @" = 788@ 

:TRIA_10085
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 769@ with_offset " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
902@(759@,12i) = Car.Create(841@(759@,12i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", -100.0)
0A21: set_car 902@(759@,12i) not_affected_by_cheats 1 
0423: set_car 902@(759@,12i) improved_handling_to 1.5 
131@(759@,12i) = 1 
072F: enable_car 902@(759@,12i) stuck_check_distance 0.5 time 5000 and_restore_if stuck 1 flipped 0 unk_place_on_road_properly 1 to_path 1 
Car.Angle(902@(759@,12i)) = 175.0
Car.SetImmunities(902@(759@,12i), 1, 1, 1, 1, 1)
Car.Health(902@(759@,12i)) = 2000
039C: set_car 902@(759@,12i) watertight 1 
03AB: set_car 902@(759@,12i) strong 1 
03ED: set_car 902@(759@,12i) disable_flipped_explosion_when_empty 1 
04E0: car 902@(759@,12i) abandon_path_radius 5 
053F: set_car 902@(759@,12i) tires_vulnerability 0 

:TRIA_10296
jump @TRIA_11045 

:TRIA_10303
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -4.0435 6.5755 -0.8 
0376: 954@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 954@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -5.6392 2.9435 -0.8 
0376: 943@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 943@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -6.0071 -2.0778 -0.8 
0376: 944@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 944@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -7.6039 -5.0807 -0.8 
0376: 945@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 945@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -7.0724 -6.4057 -0.8 
0376: 946@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 946@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -5.9988 -13.553 -0.8 
0376: 947@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 947@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 6.073 -15.2059 -0.8 
0376: 948@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 948@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 7.2639 -12.9933 -0.8 
0376: 949@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 949@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 5.8429 -7.7069 -0.8 
0376: 950@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 950@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 8.4135 -3.7971 -0.8 
0376: 951@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 951@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 6.2507 0.3634 -0.8 
0376: 952@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 952@ turn_to_and_look_at 143@ 263@ 383@ 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 8.6397 2.419 -0.8 
0376: 953@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 953@ turn_to_and_look_at 143@ 263@ 383@ 
Marker.Disable(939@)
018A: 939@ = create_checkpoint_at 854@(762@,12f) 866@(762@,12f) 878@(762@,12f) 
01EB: set_traffic_density_multiplier_to 0.5 
008B: 914@(759@,12i) = " + PlayerActor + @" 
0085: 941@ = 759@ 

:TRIA_11045
759@ += 1 
jump @TRIA_9505 

:TRIA_11059
940@ += 1 
Car.Destroy(768@)
Car.Destroy(769@)
769@ = Car.Create(841@, 143@(822@,120f), 263@(822@,120f), 383@(822@,120f))
Car.Angle(769@) = 503@(822@,120f)
0407: store_coords_to 795@ 796@ 797@ from_car 769@ with_offset 5.0 -15.0 0.0 
Car.Angle(769@) = 791@
902@(941@,12i) = Car.Create(#MTBIKE, 795@, 796@, -100.0)
Car.Angle(902@(941@,12i)) = 791@
039C: set_car 902@(941@,12i) watertight 1 
Car.Destroy(769@)
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRIA_11257 
Actor.PutAt(" + PlayerActor + @", 854@(941@,12f), 866@(941@,12f), 878@(941@,12f))
Actor.Angle(" + PlayerActor + @") = 503@
Camera.SetBehindPlayer

:TRIA_11257
02A3: enable_widescreen 1 
wait 500 
fade 1 3000 

:TRIA_11273
if 
fading 
else_jump @TRIA_11297 
wait 0 
jump @TRIA_11273 

:TRIA_11297
00BE: text_clear_all 

:TRIA_11299
if 
  940@ == 3 
else_jump @TRIA_11510 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRIA_11510 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
00BA: show_text_styled GXT 'RACES_4' time 1100 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
0085: 762@ = 926@ 
762@ -= 1 
759@ = 0 

:TRIA_11411
if 
001D:   762@ > 759@ 
else_jump @TRIA_11487 
if 
   Actor.Dead(914@(759@,12i))
else_jump @TRIA_11473 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @TRIA_22678 

:TRIA_11473
759@ += 1 
jump @TRIA_11411 

:TRIA_11487
008B: 955@ = " + Current_Time_in_ms2 + @" 
955@ += 999 
940@ += 1 

:TRIA_11510
if 
  940@ == 4 
else_jump @TRIA_11608 
if 
001E:   " + Current_Time_in_ms2 + @" > 955@ 
else_jump @TRIA_11608 
00BA: show_text_styled GXT 'RACES_5' time 1100 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
008B: 955@ = " + Current_Time_in_ms2 + @" 
955@ += 999 
940@ += 1 

:TRIA_11608
if 
  940@ == 5 
else_jump @TRIA_11706 
if 
001E:   " + Current_Time_in_ms2 + @" > 955@ 
else_jump @TRIA_11706 
00BA: show_text_styled GXT 'RACES_6' time 1100 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
008B: 955@ = " + Current_Time_in_ms2 + @" 
955@ += 999 
940@ += 1 

:TRIA_11706
if 
  940@ == 6 
else_jump @TRIA_11933 
if 
001E:   " + Current_Time_in_ms2 + @" > 955@ 
else_jump @TRIA_11933 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRIA_11933 
00BA: show_text_styled GXT 'RACES_7' time 800 style 4  
018C: play_sound 65535 at 0.0 0.0 0.0 
Player.CanMove(" + PlayerChar + @") = True
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
03F4: set_all_cars_apply_damage_rules 1 
Camera.Restore
02A3: enable_widescreen 0 
09B9: show_entered_car_name 0 
008B: 767@ = " + Current_Time_in_ms2 + @" 
0085: 762@ = 926@ 
762@ -= 1 
759@ = 0 

:TRIA_11855
if 
001D:   762@ > 759@ 
else_jump @TRIA_11919 
if 
   not Car.Wrecked(902@(759@,12i))
else_jump @TRIA_11905 
Car.ImmuneToNonPlayer(902@(759@,12i)) = False

:TRIA_11905
759@ += 1 
jump @TRIA_11855 

:TRIA_11919
955@ = 0 
940@ += 1 

:TRIA_11933
if 
  940@ > 6 
else_jump @TRIA_19672 

:TRIA_11951
if 
001D:   926@ > 759@ 
else_jump @TRIA_18612 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRIA_18598 
if 
   not Actor.Dead(914@(759@,12i))
else_jump @TRIA_14949 
if 
  940@ == 8 
else_jump @TRIA_14942 
if 
87D6:   not  914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_14942 
if 
003B:   927@(941@,12i) == 927@(759@,12i) 
else_jump @TRIA_12189 
Actor.StorePos(914@(759@,12i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 957@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 854@(759@,12f) 866@(759@,12f) 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 790@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 854@(759@,12f) 866@(759@,12f) 
if 
0025:   790@ > 957@ 
else_jump @TRIA_12182 
942@ += 1 

:TRIA_12182
jump @TRIA_12223 

:TRIA_12189
if 
001D:   927@(759@,12i) > 927@(941@,12i) 
else_jump @TRIA_12223 
942@ += 1 

:TRIA_12223
if 
80EC:   not actor 914@(759@,12i) sphere 0 near_point 82@(759@,12f) 94@(759@,12f) radius 2.0 2.0 
else_jump @TRIA_12439 
Actor.StorePos(914@(759@,12i), 82@(759@,12f), 94@(759@,12f), " + tempvar_Float_3 + @")
if and
002D:   927@(759@,12i) >= 819@ 
002D:   821@ >= 927@(759@,12i) 
else_jump @TRIA_12361 
008B: 119@(759@,12i) = " + Current_Time_in_ms2 + @" 
119@(759@,12i) += 1500 
jump @TRIA_12439 

:TRIA_12361
if 
003B:   927@(759@,12i) == 822@ 
else_jump @TRIA_12415 
008B: 119@(759@,12i) = " + Current_Time_in_ms2 + @" 
119@(759@,12i) += 1500 
jump @TRIA_12439 

:TRIA_12415
008B: 119@(759@,12i) = " + Current_Time_in_ms2 + @" 
119@(759@,12i) += 4000 

:TRIA_12439
if and
002D:   927@(759@,12i) >= 826@ 
002D:   827@ >= 927@(759@,12i) 
else_jump @TRIA_12640 
if 
   Actor.Animation(914@(759@,12i)) == ""SPRINT_PANIC""
else_jump @TRIA_12534 
0393: actor 914@(759@,12i) perform_animation ""SPRINT_PANIC"" at 781@ times_normal_rate 

:TRIA_12534
if 
   Actor.Animation(914@(759@,12i)) == ""RUN_CIVI""
else_jump @TRIA_12586 
0393: actor 914@(759@,12i) perform_animation ""RUN_CIVI"" at 781@ times_normal_rate 

:TRIA_12586
if 
   Actor.Animation(914@(759@,12i)) == ""WALK_CIVI""
else_jump @TRIA_12640 
0393: actor 914@(759@,12i) perform_animation ""WALK_CIVI"" at 781@ times_normal_rate 

:TRIA_12640
if 
00EC:   actor 914@(759@,12i) sphere 0 near_point 82@(759@,12f) 94@(759@,12f) radius 3.0 3.0 
else_jump @TRIA_14201 
if 
001E:   " + Current_Time_in_ms2 + @" > 119@(759@,12i) 
else_jump @TRIA_14201 
if and
002D:   927@(759@,12i) >= 819@ 
002D:   821@ >= 927@(759@,12i) 
else_jump @TRIA_13220 
if 
04AD:   actor 914@(759@,12i) in_water 
else_jump @TRIA_13197 
0087: 785@ = 854@(759@,12f) 
005B: 785@ += 695@(759@,12f) 
0087: 786@ = 866@(759@,12f) 
005B: 786@ += 707@(759@,12f) 
if 
001D:   927@(759@,12i) > 819@ 
else_jump @TRIA_12982 
if 
   not 3 > 927@(759@,12i) 
else_jump @TRIA_12939 
062E: get_actor 914@(759@,12i) task 2017 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_12932 
07E1: AS_actor 914@(759@,12i) swim_to 785@ 786@ 878@(759@,12f) 
0A28: set_actor 914@(759@,12i) swimming_speed_to 780@ 

:TRIA_12932
jump @TRIA_12975 

:TRIA_12939
07E1: AS_actor 914@(759@,12i) swim_to 785@ 786@ 878@(759@,12f) 
0A28: set_actor 914@(759@,12i) swimming_speed_to 2.2 

:TRIA_12975
jump @TRIA_13190 

:TRIA_12982
if 
82CB:   not actor 914@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_13190 
0085: 784@ = 927@(759@,12i) 
784@ -= 1 
if 
80C2:   not sphere_onscreen 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 10.0 
else_jump @TRIA_13190 
Actor.PutAt(914@(759@,12i), 854@(759@,12f), 866@(759@,12f), 878@(759@,12f))
Actor.Angle(914@(759@,12i)) = 503@(759@,120f)
0687: clear_actor 914@(759@,12i) task 
062E: get_actor 914@(759@,12i) task 2017 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_13190 
07E1: AS_actor 914@(759@,12i) swim_to 785@ 786@ 878@(759@,12f) 
0A28: set_actor 914@(759@,12i) swimming_speed_to 780@ 

:TRIA_13190
jump @TRIA_13220 

:TRIA_13197
if 
003B:   927@(759@,12i) == 821@ 
else_jump @TRIA_13220 

:TRIA_13220
if and
002D:   927@(759@,12i) >= 823@ 
002D:   824@ >= 927@(759@,12i) 
else_jump @TRIA_14058 
if 
   not Car.Wrecked(902@(759@,12i))
else_jump @TRIA_14058 
0871: init_jump_table 804@(759@,12i) total_jumps 2 default_jump 1 @TRIA_13667 jumps 0 @TRIA_13342 1 @TRIA_13417 -1 @TRIA_14058 -1 @TRIA_14058 -1 @TRIA_14058 -1 @TRIA_14058 -1 @TRIA_14058 

:TRIA_13342
0615: define_AS_pack_begin 803@ 
05D3: AS_actor -1 goto_point 792@ 793@ 794@ mode 7 time -2 ms 
05CB: AS_actor -1 enter_car 902@(759@,12i) as_driver -2 ms 
0616: define_AS_pack_end 803@ 
0618: assign_actor 914@(759@,12i) to_AS_pack 803@ 
061B: remove_references_to_AS_pack 803@ 
804@(759@,12i) = 1 
jump @TRIA_14058 

:TRIA_13417
if 
82CB:   not actor 914@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_13660 
if 
80C2:   not sphere_onscreen 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 10.0 
else_jump @TRIA_13660 
if 
   not Actor.InCar(914@(759@,12i), 902@(759@,12i))
else_jump @TRIA_13660 
if 
82CA:   not car 902@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_13660 
if 
   not Actor.Driving(914@(759@,12i))
else_jump @TRIA_13660 
046C: 798@ = car 902@(759@,12i) driver 
if 
  798@ == -1 
else_jump @TRIA_13660 
0085: 784@ = 927@(759@,12i) 
784@ -= 1 
036A: put_actor 914@(759@,12i) in_car 902@(759@,12i) 
05D1: AS_actor 914@(759@,12i) drive_car -1 to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) speed 779@ 3 model #CSPLAY 1 
804@(759@,12i) = 2 

:TRIA_13660
jump @TRIA_14058 

:TRIA_13667
if 
82CB:   not actor 914@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_14051 
if 
80C2:   not sphere_onscreen 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 10.0 
else_jump @TRIA_14051 
if 
82CA:   not car 902@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_14051 
046C: 798@ = car 902@(759@,12i) driver 
if 
  798@ == -1 
else_jump @TRIA_14051 
062E: get_actor 914@(759@,12i) task 1489 status_store_to 731@(759@,12i) 
0085: 784@ = 927@(759@,12i) 
784@ -= 1 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_14051 
if 
   not Actor.InCar(914@(759@,12i), 902@(759@,12i))
else_jump @TRIA_13957 
046C: 798@ = car 902@(759@,12i) driver 
if 
  798@ == -1 
else_jump @TRIA_13950 
036A: put_actor 914@(759@,12i) in_car 902@(759@,12i) 
05D1: AS_actor 914@(759@,12i) drive_car -1 to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) speed 779@ 3 model #CSPLAY 1 

:TRIA_13950
jump @TRIA_14051 

:TRIA_13957
Actor.PutAt(914@(759@,12i), 854@(759@,12f), 866@(759@,12f), 878@(759@,12f))
039F: set_car 902@(759@,12i) race_to 854@(759@,12f) 866@(759@,12f) 
05D1: AS_actor 914@(759@,12i) drive_car -1 to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) speed 779@ 3 model #CSPLAY 1 

:TRIA_14051
jump @TRIA_14058 

:TRIA_14058
if and
002D:   927@(759@,12i) >= 826@ 
002D:   827@ >= 927@(759@,12i) 
else_jump @TRIA_14201 
if 
82CB:   not actor 914@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_14201 
if 
80C2:   not sphere_onscreen 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 10.0 
else_jump @TRIA_14201 
0085: 784@ = 927@(759@,12i) 
784@ -= 1 
Actor.PutAt(914@(759@,12i), 854@(759@,12f), 866@(759@,12f), 878@(759@,12f))

:TRIA_14201
if 
   Actor.Driving(914@(759@,12i))
else_jump @TRIA_14252 
0085: 762@ = 927@(941@,12i) 
762@ += 5 
768@ = Actor.CurrentCar(914@(759@,12i))

:TRIA_14252
758@ = 0 
761@ = 0 

:TRIA_14266
if 
001D:   926@ > 758@ 
else_jump @TRIA_14348 
0085: 958@ = 927@(758@,12i) 
958@ -= 2 
if 
001D:   958@ > 927@(759@,12i) 
else_jump @TRIA_14334 
761@ += 1 

:TRIA_14334
758@ += 1 
jump @TRIA_14266 

:TRIA_14348
if 
  761@ > 0 
else_jump @TRIA_14942 
0085: 784@ = 927@(759@,12i) 
784@ -= 1 
if 
   not Actor.Dead(914@(759@,12i))
else_jump @TRIA_14942 
if 
8104:   not actor " + PlayerActor + @" near_actor 914@(759@,12i) radius 30.0 30.0 30.0 sphere 0 
else_jump @TRIA_14942 
if 
82CB:   not actor 914@(759@,12i) bounding_sphere_visible 
else_jump @TRIA_14942 
if 
838A:   not any_car_in_cube_cornerA 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) cornerB 4.0 4.0 3.0 
else_jump @TRIA_14942 
if 
80C2:   not sphere_onscreen 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 4.0 
else_jump @TRIA_14942 
Actor.PutAt(914@(759@,12i), 854@(759@,12f), 866@(759@,12f), 878@(759@,12f))
0687: clear_actor 914@(759@,12i) task 
062E: get_actor 914@(759@,12i) task 1489 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_14942 
if and
002D:   927@(759@,12i) >= 823@ 
002D:   824@ >= 927@(759@,12i) 
else_jump @TRIA_14942 
if 
   Actor.Driving(914@(759@,12i))
else_jump @TRIA_14760 
768@ = Actor.CurrentCar(914@(759@,12i))
Car.Angle(768@) = 503@(759@,120f)
05D1: AS_actor 914@(759@,12i) drive_car -1 to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) speed 779@ 3 model #CSPLAY 1 
jump @TRIA_14942 

:TRIA_14760
if 
   not Car.Wrecked(902@(759@,12i))
else_jump @TRIA_14942 
if 
   not Actor.InCar(914@(759@,12i), 902@(759@,12i))
else_jump @TRIA_14942 
if 
   not Actor.InCar(" + PlayerActor + @", 902@(759@,12i))
else_jump @TRIA_14942 
046C: 798@ = car 902@(759@,12i) driver 
if 
  798@ == -1 
else_jump @TRIA_14942 
0687: clear_actor 914@(759@,12i) task 
036A: put_actor 914@(759@,12i) in_car 902@(759@,12i) 
Car.Angle(902@(759@,12i)) = 503@(759@,120f)
05D1: AS_actor 914@(759@,12i) drive_car -1 to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) speed 779@ 3 model #CSPLAY 1 

:TRIA_14942
jump @TRIA_15051 

:TRIA_14949
if and
051A:   actor 914@(759@,12i) damaged_by_actor " + PlayerActor + @" 
   Actor.Dead(914@(759@,12i))
else_jump @TRIA_15051 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_15051 
if 
851B:   not actor 914@(759@,12i) damaged_by_car 902@(941@,12i) 
else_jump @TRIA_15051 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @TRIA_22678 

:TRIA_15051
if 
   not Actor.Dead(914@(759@,12i))
else_jump @TRIA_16445 
if 
07D6:   914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_15193 
if 
  782@ == 0 
else_jump @TRIA_15193 
if 
80FE:   not actor 914@(759@,12i) sphere 0 in_sphere 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 600.0 600.0 600.0 
else_jump @TRIA_15193 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @TRIA_22678 

:TRIA_15193
if 
001D:   927@(759@,12i) > 827@ 
else_jump @TRIA_15299 
if 
  746@(759@,12i) == 0 
else_jump @TRIA_15299 
0615: define_AS_pack_begin 803@ 
05D3: AS_actor -1 goto_point 743@ 744@ 745@ mode 7 time -2 ms 
05BD: AS_actor -1 tired -2 ms 
0616: define_AS_pack_end 803@ 
0618: assign_actor 914@(759@,12i) to_AS_pack 803@ 
061B: remove_references_to_AS_pack 803@ 
746@(759@,12i) = 1 

:TRIA_15299
if and
002D:   927@(759@,12i) >= 826@ 
002D:   827@ >= 927@(759@,12i) 
else_jump @TRIA_15703 
if 
00FE:   actor 914@(759@,12i) sphere 0 in_sphere 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 8.0 8.0 5.0 
else_jump @TRIA_15703 
if 
003B:   927@(759@,12i) == 826@ 
else_jump @TRIA_15429 
jump @TRIA_19747 
jump @TRIA_15477 

:TRIA_15429
062E: get_actor 914@(759@,12i) task 2606 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_15477 
jump @TRIA_19747 

:TRIA_15477
if 
003B:   927@(759@,12i) == 828@ 
else_jump @TRIA_15703 
if 
07D6:   914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_15592 
942@ += 1 
if 
  1 >= 942@ 
else_jump @TRIA_15562 
jump @TRIA_22696 
jump @TRIA_15585 

:TRIA_15562
00BC: show_text_highpriority GXT 'RACES_8' time 5000 flag 1  
jump @TRIA_22678 

:TRIA_15585
jump @TRIA_15703 

:TRIA_15592
06C7: AS_actor 914@(759@,12i) driver_of_car -1 perform_action 6 timelimit 2000000 
0085: 784@ = 927@(759@,12i) 
784@ -= 1 
if 
80C2:   not sphere_onscreen 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 30.0 
else_jump @TRIA_15703 
if 
   not Car.Wrecked(768@)
else_jump @TRIA_15703 
039F: set_car 768@ race_to 143@(759@,120f) 263@(759@,120f) 

:TRIA_15703
if and
002D:   927@(759@,12i) >= 821@ 
002D:   824@ >= 927@(759@,12i) 
else_jump @TRIA_16268 
if 
07D6:   914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_16110 
if and
002D:   927@(759@,12i) >= 823@ 
002D:   824@ >= 927@(759@,12i) 
else_jump @TRIA_15961 
if 
0100:   actor 914@(759@,12i) in_sphere 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 40.0 40.0 40.0 sphere 0 in_car 
else_jump @TRIA_15954 
0085: 765@ = 823@ 
765@ += 1 
if 
001D:   927@(759@,12i) > 765@ 
else_jump @TRIA_15947 
062E: get_actor 914@(759@,12i) task 1489 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_15940 
jump @TRIA_19747 

:TRIA_15940
jump @TRIA_15954 

:TRIA_15947
jump @TRIA_19747 

:TRIA_15954
jump @TRIA_16103 

:TRIA_15961
if 
00FE:   actor 914@(759@,12i) sphere 0 in_sphere 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 8.0 8.0 5.0 
else_jump @TRIA_16103 
if 
  2 > 927@(759@,12i) 
else_jump @TRIA_16096 
062E: get_actor 914@(759@,12i) task 2017 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_16089 
jump @TRIA_19747 

:TRIA_16089
jump @TRIA_16103 

:TRIA_16096
jump @TRIA_19747 

:TRIA_16103
jump @TRIA_16268 

:TRIA_16110
if 
0100:   actor 914@(759@,12i) in_sphere 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 40.0 40.0 40.0 sphere 0 in_car 
else_jump @TRIA_16268 
0085: 765@ = 823@ 
765@ += 1 
if 
001D:   927@(759@,12i) > 765@ 
else_jump @TRIA_16261 
062E: get_actor 914@(759@,12i) task 1489 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_16254 
jump @TRIA_19747 

:TRIA_16254
jump @TRIA_16268 

:TRIA_16261
jump @TRIA_19747 

:TRIA_16268
if and
002D:   927@(759@,12i) >= 819@ 
001D:   821@ > 927@(759@,12i) 
else_jump @TRIA_16445 
if 
00FE:   actor 914@(759@,12i) sphere 0 in_sphere 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) radius 8.0 8.0 5.0 
else_jump @TRIA_16445 
if 
  2 > 927@(759@,12i) 
else_jump @TRIA_16438 
062E: get_actor 914@(759@,12i) task 2017 status_store_to 731@(759@,12i) 
if 
04A4:   731@(759@,12i) == 7 
else_jump @TRIA_16431 
jump @TRIA_19747 

:TRIA_16431
jump @TRIA_16445 

:TRIA_16438
jump @TRIA_19747 

:TRIA_16445
if 
07D6:   914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_18598 
if and
002D:   927@(759@,12i) >= 823@ 
002D:   824@ >= 927@(759@,12i) 
else_jump @TRIA_17258 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_17233 
if 
   not Actor.InCar(" + PlayerActor + @", 902@(941@,12i))
else_jump @TRIA_16933 
if 
  782@ == 0 
else_jump @TRIA_16658 
06D6: disable_racing_checkpoint 963@ 
Marker.Disable(939@)
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_16613 
939@ = Marker.CreateAboveCar(902@(941@,12i))
07E0: set_marker 939@ type_to 1 

:TRIA_16613
0085: 799@ = 759@ 
866@(759@,12f) += 1000.0 
008B: 800@ = " + Current_Time_in_ms2 + @" 
800@ += 25400 
782@ = 1 

:TRIA_16658
0085: 764@ = 800@ 
0064: 764@ -= " + Current_Time_in_ms2 + @" 
764@ /= 1000 
if 
  1 > 764@ 
else_jump @TRIA_16707 
764@ = 0 

:TRIA_16707
if 
001E:   " + Current_Time_in_ms2 + @" > 800@ 
else_jump @TRIA_16751 
00BC: show_text_highpriority GXT 'RACES20' time 5000 flag 1  
jump @TRIA_22678 
return 

:TRIA_16751
09C1: add_next_text_to_brief_history 0 
if 
  764@ == 1 
else_jump @TRIA_16799 
01E5: show_text_1number_highpriority GXT 'RACE_51' number 764@ time 200 flag 1  
jump @TRIA_16818 

:TRIA_16799
01E5: show_text_1number_highpriority GXT 'RACES50' number 764@ time 200 flag 1  

:TRIA_16818
if 
003B:   927@(759@,12i) == 828@ 
else_jump @TRIA_16926 
if 
07D6:   914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_16926 
942@ += 1 
if 
  1 >= 942@ 
else_jump @TRIA_16903 
jump @TRIA_22696 
jump @TRIA_16926 

:TRIA_16903
00BC: show_text_highpriority GXT 'RACES_8' time 5000 flag 1  
jump @TRIA_22678 

:TRIA_16926
jump @TRIA_17226 

:TRIA_16933
if 
  782@ == 1 
else_jump @TRIA_17226 
03D5: remove_text 'RACES50'  
Marker.Disable(939@)
866@(759@,12f) -= 1000.0 
760@ = 0 
0085: 762@ = 118@ 
762@ -= 1 
018A: 939@ = create_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) 
Marker.SetColor(939@, 0)
018B: set_marker 939@ radar_mode 2 
Marker.SetIconSize(939@, 3)
if 
003B:   927@(799@,12i) == 853@ 
else_jump @TRIA_17128 
06D5: 963@ = create_racing_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) point_to 0.0 0.0 0.0 type 1 radius 6.0 
jump @TRIA_17219 

:TRIA_17128
0085: 762@ = 927@(799@,12i) 
762@ += 1 
if 
003B:   927@(799@,12i) == 853@ 
else_jump @TRIA_17177 
762@ = 1 

:TRIA_17177
06D5: 963@ = create_racing_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) point_to 960@ 961@ 962@ type 0 radius 6.0 

:TRIA_17219
782@ = 0 

:TRIA_17226
jump @TRIA_17258 

:TRIA_17233
00BC: show_text_highpriority GXT 'RACES24' time 5000 flag 1  
jump @TRIA_22678 
return 

:TRIA_17258
0085: 765@ = 826@ 
765@ += 1 
if and
002D:   927@(759@,12i) >= 826@ 
001D:   765@ > 927@(759@,12i) 
else_jump @TRIA_17928 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_17928 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @TRIA_17635 
if 
  782@ == 0 
else_jump @TRIA_17468 
902@(941@,12i) = Actor.MissionCar(" + PlayerActor + @")
06D6: disable_racing_checkpoint 963@ 
Marker.Disable(939@)
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_17423 
939@ = Marker.CreateAboveCar(902@(941@,12i))
07E0: set_marker 939@ type_to 1 

:TRIA_17423
0085: 799@ = 759@ 
866@(759@,12f) += 1000.0 
008B: 800@ = " + Current_Time_in_ms2 + @" 
800@ += 25400 
782@ = 1 

:TRIA_17468
0085: 764@ = 800@ 
0064: 764@ -= " + Current_Time_in_ms2 + @" 
764@ /= 1000 
if 
  1 > 764@ 
else_jump @TRIA_17517 
764@ = 0 

:TRIA_17517
if 
001E:   " + Current_Time_in_ms2 + @" > 800@ 
else_jump @TRIA_17561 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @TRIA_22678 
return 

:TRIA_17561
09C1: add_next_text_to_brief_history 0 
if 
  764@ == 1 
else_jump @TRIA_17609 
01E5: show_text_1number_highpriority GXT 'RACE_49' number 764@ time 200 flag 1  
jump @TRIA_17628 

:TRIA_17609
01E5: show_text_1number_highpriority GXT 'RACES48' number 764@ time 200 flag 1  

:TRIA_17628
jump @TRIA_17928 

:TRIA_17635
if 
  782@ == 1 
else_jump @TRIA_17928 
03D5: remove_text 'RACES48'  
Marker.Disable(939@)
866@(759@,12f) -= 1000.0 
760@ = 0 
0085: 762@ = 118@ 
762@ -= 1 
018A: 939@ = create_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) 
Marker.SetColor(939@, 0)
018B: set_marker 939@ radar_mode 2 
Marker.SetIconSize(939@, 3)
if 
003B:   927@(799@,12i) == 853@ 
else_jump @TRIA_17830 
06D5: 963@ = create_racing_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) point_to 0.0 0.0 0.0 type 1 radius 6.0 
jump @TRIA_17921 

:TRIA_17830
0085: 762@ = 927@(799@,12i) 
762@ += 1 
if 
003B:   927@(799@,12i) == 853@ 
else_jump @TRIA_17879 
762@ = 1 

:TRIA_17879
06D5: 963@ = create_racing_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) point_to 960@ 961@ 962@ type 0 radius 6.0 

:TRIA_17921
782@ = 0 

:TRIA_17928
0085: 765@ = 826@ 
765@ += 1 
if and
002D:   927@(759@,12i) >= 765@ 
002D:   827@ >= 927@(759@,12i) 
else_jump @TRIA_18598 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_18598 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @TRIA_18305 
if 
  782@ == 0 
else_jump @TRIA_18138 
902@(941@,12i) = Actor.MissionCar(" + PlayerActor + @")
06D6: disable_racing_checkpoint 963@ 
Marker.Disable(939@)
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_18093 
939@ = Marker.CreateAboveCar(902@(941@,12i))
07E0: set_marker 939@ type_to 1 

:TRIA_18093
0085: 799@ = 759@ 
866@(759@,12f) += 1000.0 
008B: 800@ = " + Current_Time_in_ms2 + @" 
800@ += 5000 
782@ = 1 

:TRIA_18138
0085: 764@ = 800@ 
0064: 764@ -= " + Current_Time_in_ms2 + @" 
764@ /= 1000 
if 
  1 > 764@ 
else_jump @TRIA_18187 
764@ = 0 

:TRIA_18187
if 
001E:   " + Current_Time_in_ms2 + @" > 800@ 
else_jump @TRIA_18231 
00BC: show_text_highpriority GXT 'RACES25' time 5000 flag 1  
jump @TRIA_22678 
return 

:TRIA_18231
09C1: add_next_text_to_brief_history 0 
if 
  764@ == 1 
else_jump @TRIA_18279 
01E5: show_text_1number_highpriority GXT 'RACE_49' number 764@ time 200 flag 1  
jump @TRIA_18298 

:TRIA_18279
01E5: show_text_1number_highpriority GXT 'RACES48' number 764@ time 200 flag 1  

:TRIA_18298
jump @TRIA_18598 

:TRIA_18305
if 
  782@ == 1 
else_jump @TRIA_18598 
03D5: remove_text 'RACES48'  
Marker.Disable(939@)
866@(759@,12f) -= 1000.0 
760@ = 0 
0085: 762@ = 118@ 
762@ -= 1 
018A: 939@ = create_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) 
Marker.SetColor(939@, 0)
018B: set_marker 939@ radar_mode 2 
Marker.SetIconSize(939@, 3)
if 
003B:   927@(799@,12i) == 853@ 
else_jump @TRIA_18500 
06D5: 963@ = create_racing_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) point_to 0.0 0.0 0.0 type 1 radius 6.0 
jump @TRIA_18591 

:TRIA_18500
0085: 762@ = 927@(799@,12i) 
762@ += 1 
if 
003B:   927@(799@,12i) == 853@ 
else_jump @TRIA_18549 
762@ = 1 

:TRIA_18549
06D5: 963@ = create_racing_checkpoint_at 854@(799@,12f) 866@(799@,12f) 878@(799@,12f) point_to 960@ 961@ 962@ type 0 radius 6.0 

:TRIA_18591
782@ = 0 

:TRIA_18598
759@ += 1 
jump @TRIA_11951 

:TRIA_18612
038E: draw_box_position 40@ 52@ size 64@ 76@ RGBA 0 0 0 255 
038E: draw_box_position 39@ 51@ size 63@ 75@ RGBA 134 155 184 255 
038E: draw_box_position 34@ 46@ size 58@ 70@ RGBA 0 0 0 255 
942@ += 1 
gosub @TRIA_19679 
033F: set_text_draw_letter_size 59@ 71@ 
if 
  942@ == 1 
else_jump @TRIA_18741 
033E: set_draw_text_position 35@ 47@ GXT 'ST'  

:TRIA_18741
if 
  942@ == 2 
else_jump @TRIA_18776 
033E: set_draw_text_position 35@ 47@ GXT 'ND'  

:TRIA_18776
if 
  942@ == 3 
else_jump @TRIA_18811 
033E: set_draw_text_position 35@ 47@ GXT 'RD'  

:TRIA_18811
if 
  942@ > 3 
else_jump @TRIA_18846 
033E: set_draw_text_position 35@ 47@ GXT 'TH'  

:TRIA_18846
if 
  7 >= 942@ 
else_jump @TRIA_19115 
0087: 779@ = 770@ 
0087: 780@ = 773@ 
0087: 781@ = 776@ 
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_18971 
if or
  927@(759@,12i) == 19 
  927@(759@,12i) == 20 
  927@(759@,12i) == 37 
  927@(759@,12i) == 38 
else_jump @TRIA_18971 
779@ = 20.0 

:TRIA_18971
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_19043 
if or
  927@(759@,12i) == 69 
  927@(759@,12i) == 70 
  927@(759@,12i) == 71 
else_jump @TRIA_19043 
779@ = 20.0 

:TRIA_19043
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_19115 
if or
  927@(759@,12i) == 89 
  927@(759@,12i) == 90 
  927@(759@,12i) == 91 
else_jump @TRIA_19115 
779@ = 20.0 

:TRIA_19115
if and
  942@ > 7 
  9 > 942@ 
else_jump @TRIA_19391 
0087: 779@ = 771@ 
0087: 780@ = 774@ 
0087: 781@ = 777@ 
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_19247 
if or
  927@(759@,12i) == 19 
  927@(759@,12i) == 20 
  927@(759@,12i) == 37 
  927@(759@,12i) == 38 
else_jump @TRIA_19247 
779@ = 20.0 

:TRIA_19247
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_19319 
if or
  927@(759@,12i) == 69 
  927@(759@,12i) == 70 
  927@(759@,12i) == 71 
else_jump @TRIA_19319 
779@ = 20.0 

:TRIA_19319
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_19391 
if or
  927@(759@,12i) == 91 
  927@(759@,12i) == 92 
  927@(759@,12i) == 93 
else_jump @TRIA_19391 
779@ = 20.0 

:TRIA_19391
if 
  942@ == 9 
else_jump @TRIA_19433 
0087: 779@ = 772@ 
0087: 780@ = 775@ 
0087: 781@ = 778@ 

:TRIA_19433
gosub @TRIA_19679 
033F: set_text_draw_letter_size 60@ 72@ 
0342: set_text_draw_centered 1 
045A: draw_text_1number 36@ 48@ GXT 'NUMBER' number 942@  
gosub @TRIA_19679 
033F: set_text_draw_letter_size 61@ 73@ 
045A: draw_text_1number 37@ 49@ GXT 'OUT_OF' number 118@  
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 959@ = " + Current_Time_in_ms2 + @" 
0062: 959@ -= 767@ 
959@ /= 1000 
0085: 763@ = 959@ 
763@ /= 60 
0085: 762@ = 763@ 
762@ *= 60 
0085: 764@ = 959@ 
0062: 764@ -= 762@ 
gosub @TRIA_19679 
0342: set_text_draw_centered 1 
033F: set_text_draw_letter_size 62@ 74@ 
if 
  764@ > 9 
else_jump @TRIA_19649 
045B: draw_text_2numbers 38@ 50@ GXT 'TIME' numbers 763@ 764@  
jump @TRIA_19672 

:TRIA_19649
045B: draw_text_2numbers 38@ 50@ GXT 'TIME_0' numbers 763@ 764@  

:TRIA_19672
jump @TRIA_8995 

:TRIA_19679
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

:TRIA_19747
if 
  940@ == 7 
else_jump @TRIA_19772 
940@ = 8 

:TRIA_19772
927@(759@,12i) += 1 
0085: 762@ = 927@(759@,12i) 
0087: 854@(759@,12f) = 143@(762@,120f) 
0087: 866@(759@,12f) = 263@(762@,120f) 
0087: 878@(759@,12f) = 383@(762@,120f) 
if 
07D6:   914@(759@,12i) == " + PlayerActor + @" 
else_jump @TRIA_21813 
if 
002D:   927@(759@,12i) >= 828@ 
else_jump @TRIA_19951 
942@ += 1 
if 
  1 >= 942@ 
else_jump @TRIA_19928 
jump @TRIA_22696 
jump @TRIA_19951 

:TRIA_19928
00BC: show_text_highpriority GXT 'RACES_8' time 5000 flag 1  
jump @TRIA_22678 

:TRIA_19951
if 
  817@ == 0 
else_jump @TRIA_20010 
if 
003B:   927@(759@,12i) == 820@ 
else_jump @TRIA_20010 
03E5: show_text_box 'TRAI2'  
817@ = 1 

:TRIA_20010
if 
  817@ == 1 
else_jump @TRIA_20069 
if 
003B:   927@(759@,12i) == 822@ 
else_jump @TRIA_20069 
03E5: show_text_box 'TRAI3'  
817@ = 2 

:TRIA_20069
if 
  817@ == 2 
else_jump @TRIA_20128 
if 
003B:   927@(759@,12i) == 826@ 
else_jump @TRIA_20128 
03E5: show_text_box 'TRAI4'  
817@ = 3 

:TRIA_20128
018C: play_sound 1058 at 0.0 0.0 0.0 
Marker.Disable(939@)
762@ += 1 
0087: 960@ = 143@(762@,120f) 
0087: 961@ = 263@(762@,120f) 
0087: 962@ = 383@(762@,120f) 
018A: 939@ = create_checkpoint_at 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) 
Marker.SetColor(939@, 0)
018B: set_marker 939@ radar_mode 2 
Marker.SetIconSize(939@, 3)
if 
  940@ == 1 
else_jump @TRIA_20303 
06D5: 963@ = create_racing_checkpoint_at 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) point_to 960@ 961@ 962@ type 0 radius 6.0 

:TRIA_20303
06D6: disable_racing_checkpoint 963@ 
if 
001D:   853@ > 927@(759@,12i) 
else_jump @TRIA_20380 
06D5: 963@ = create_racing_checkpoint_at 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) point_to 960@ 961@ 962@ type 0 radius 6.0 
jump @TRIA_20422 

:TRIA_20380
06D5: 963@ = create_racing_checkpoint_at 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) point_to 960@ 961@ 962@ type 1 radius 6.0 

:TRIA_20422
if 
  927@(759@,12i) == 3 
else_jump @TRIA_20504 
Actor.DestroyInstantly(954@)
Actor.DestroyInstantly(943@)
Actor.DestroyInstantly(944@)
Actor.DestroyInstantly(945@)
Actor.DestroyInstantly(946@)
Actor.DestroyInstantly(947@)
Actor.DestroyInstantly(948@)
Actor.DestroyInstantly(949@)
Actor.DestroyInstantly(950@)
Actor.DestroyInstantly(951@)
Actor.DestroyInstantly(952@)
Actor.DestroyInstantly(953@)

:TRIA_20504
0085: 762@ = 824@ 
762@ -= 3 
if 
003B:   927@(759@,12i) == 762@ 
else_jump @TRIA_21419 
768@ = Car.Create(841@, 143@(825@,120f), 263@(825@,120f), 383@(825@,120f))
0085: 762@ = 824@ 
762@ -= 1 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -4.0435 6.5755 0.8 
0376: 954@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 954@ turn_to_and_look_at 143@(762@,120f) 263@(824@,120f) 383@(824@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -5.6392 2.9435 0.8 
0376: 943@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 943@ turn_to_and_look_at 143@(762@,120f) 263@(824@,120f) 383@(824@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -6.0071 -2.0778 0.8 
0376: 944@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 944@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -7.6039 -5.0807 0.8 
0376: 945@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 945@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -7.0724 -6.4057 0.8 
0376: 946@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 946@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset -5.9988 -13.553 0.8 
0376: 947@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 947@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 6.073 -15.2059 0.8 
0376: 948@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 948@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 7.2639 -12.9933 0.8 
0376: 949@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 949@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 5.8429 -7.7069 0.8 
0376: 950@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 950@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 8.4135 -3.7971 0.8 
0376: 951@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 951@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 6.2507 0.3634 0.8 
0376: 952@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 952@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 768@ with_offset 8.6397 2.419 0.8 
0376: 953@ = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06BA: AS_actor 953@ turn_to_and_look_at 143@(762@,120f) 263@(762@,120f) 383@(762@,120f) 
Car.Destroy(768@)

:TRIA_21419
0085: 765@ = 824@ 
765@ += 2 
if 
003B:   927@(759@,12i) == 765@ 
else_jump @TRIA_21517 
Actor.RemoveReferences(954@)
Actor.RemoveReferences(943@)
Actor.RemoveReferences(944@)
Actor.RemoveReferences(945@)
Actor.RemoveReferences(946@)
Actor.RemoveReferences(947@)
Actor.RemoveReferences(948@)
Actor.RemoveReferences(949@)
Actor.RemoveReferences(950@)
Actor.RemoveReferences(951@)
Actor.RemoveReferences(952@)
Actor.RemoveReferences(953@)

:TRIA_21517
if 
  927@(759@,12i) == 21 
else_jump @TRIA_21570 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_21570 
039C: set_car 902@(941@,12i) watertight 1 

:TRIA_21570
if 
  927@(759@,12i) == 22 
else_jump @TRIA_21623 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_21623 
039C: set_car 902@(941@,12i) watertight 0 

:TRIA_21623
0085: 765@ = 826@ 
765@ += 2 
if 
003B:   927@(759@,12i) == 765@ 
else_jump @TRIA_21721 
Actor.RemoveReferences(954@)
Actor.RemoveReferences(943@)
Actor.RemoveReferences(944@)
Actor.RemoveReferences(945@)
Actor.RemoveReferences(946@)
Actor.RemoveReferences(947@)
Actor.RemoveReferences(948@)
Actor.RemoveReferences(949@)
Actor.RemoveReferences(950@)
Actor.RemoveReferences(951@)
Actor.RemoveReferences(952@)
Actor.RemoveReferences(953@)

:TRIA_21721
if 
003B:   927@(759@,12i) == 826@ 
else_jump @TRIA_21806 
if 
   not Car.Wrecked(902@(941@,12i))
else_jump @TRIA_21806 
if 
   Actor.InCar(" + PlayerActor + @", 902@(941@,12i))
else_jump @TRIA_21806 
06C7: AS_actor " + PlayerActor + @" driver_of_car 902@(941@,12i) perform_action 6 timelimit 2000000 

:TRIA_21806
jump @TRIA_22671 

:TRIA_21813
if 
802D:   not  927@(759@,12i) >= 828@ 
else_jump @TRIA_22671 
0687: clear_actor 914@(759@,12i) task 
if 
003B:   927@(759@,12i) == 820@ 
else_jump @TRIA_22071 
05D3: AS_actor 914@(759@,12i) goto_point 854@(759@,12f) 866@(759@,12f) 878@ mode 7 time -2 ms 
if 
   Actor.Animation(914@(759@,12i)) == ""SPRINT_PANIC""
else_jump @TRIA_21958 
0393: actor 914@(759@,12i) perform_animation ""SPRINT_PANIC"" at 781@ times_normal_rate 

:TRIA_21958
if 
   Actor.Animation(914@(759@,12i)) == ""RUN_CIVI""
else_jump @TRIA_22010 
0393: actor 914@(759@,12i) perform_animation ""RUN_CIVI"" at 781@ times_normal_rate 

:TRIA_22010
if 
   Actor.Animation(914@(759@,12i)) == ""WALK_CIVI""
else_jump @TRIA_22064 
0393: actor 914@(759@,12i) perform_animation ""WALK_CIVI"" at 781@ times_normal_rate 

:TRIA_22064
jump @TRIA_16445 

:TRIA_22071
if and
001D:   927@(759@,12i) > 820@ 
002D:   821@ >= 927@(759@,12i) 
else_jump @TRIA_22407 
if 
04AD:   actor 914@(759@,12i) in_water 
else_jump @TRIA_22348 
0087: 785@ = 854@(759@,12f) 
005B: 785@ += 695@(759@,12f) 
0087: 786@ = 866@(759@,12f) 
005B: 786@ += 707@(759@,12f) 
07E1: AS_actor 914@(759@,12i) swim_to 785@ 786@ 878@(759@,12f) 
0A28: set_actor 914@(759@,12i) swimming_speed_to 780@ 
if 
003B:   927@(759@,12i) == 821@ 
else_jump @TRIA_22341 
if 
  804@(759@,12i) == 0 
else_jump @TRIA_22341 
if 
   not Car.Wrecked(902@(759@,12i))
else_jump @TRIA_22341 
0615: define_AS_pack_begin 803@ 
05D3: AS_actor -1 goto_point 792@ 793@ 794@ mode 7 time -2 ms 
05CB: AS_actor -1 enter_car 902@(759@,12i) as_driver -2 ms 
0616: define_AS_pack_end 803@ 
0618: assign_actor 914@(759@,12i) to_AS_pack 803@ 
061B: remove_references_to_AS_pack 803@ 
804@(759@,12i) = 1 

:TRIA_22341
jump @TRIA_22400 

:TRIA_22348
if 
  927@(759@,12i) == 2 
else_jump @TRIA_22400 
05D3: AS_actor 914@(759@,12i) goto_point 854@(759@,12f) 866@(759@,12f) 878@ mode 7 time -2 ms 

:TRIA_22400
jump @TRIA_16445 

:TRIA_22407
if and
002D:   927@(759@,12i) >= 823@ 
002D:   824@ >= 927@(759@,12i) 
else_jump @TRIA_22512 
if 
  804@(759@,12i) > 0 
else_jump @TRIA_22505 
05D1: AS_actor 914@(759@,12i) drive_car -1 to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) speed 779@ 3 model #CSPLAY 1 

:TRIA_22505
jump @TRIA_16445 

:TRIA_22512
if and
002D:   927@(759@,12i) >= 826@ 
002D:   827@ >= 927@(759@,12i) 
else_jump @TRIA_22671 
if 
003B:   927@(759@,12i) == 826@ 
else_jump @TRIA_22611 
05D3: AS_actor 914@(759@,12i) goto_point 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) mode 7 time -2 ms 
jump @TRIA_22664 

:TRIA_22611
0648: unknown_actor 914@(759@,12i) task_set 20.0 
0A2E: AS_actor 914@(759@,12i) go_to 854@(759@,12f) 866@(759@,12f) 878@(759@,12f) mode 7 time -2 stop_radius 8.0 following_paths 

:TRIA_22664
jump @TRIA_16445 

:TRIA_22671
jump @TRIA_16445 

:TRIA_22678
00BA: show_text_styled GXT 'RACEFA' time 5000 style 1  
return 

:TRIA_22696
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 2 
00BA: show_text_styled GXT 'RACES18' time 5000 style 1  
if 
  " + Mission_BeatTheCock_Type + @" == 1 
else_jump @TRIA_22766 
01E4: show_text_1number_lowpriority GXT 'TRAI1' number 10000 time 5000 flag 2  
Player.Money(" + PlayerChar + @") += 10000

:TRIA_22766
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_22811 
01E4: show_text_1number_lowpriority GXT 'TRAI1' number 20000 time 5000 flag 2  
Player.Money(" + PlayerChar + @") += 20000

:TRIA_22811
955@ /= 1000 
0085: 763@ = 955@ 
763@ /= 60 
0085: 762@ = 763@ 
762@ *= 60 
0085: 764@ = 955@ 
0062: 764@ -= 762@ 
if 
  " + Mission_BeatTheCock_Passed + @" == 0 
else_jump @TRIA_22917 
if 
  " + Mission_BeatTheCock_Type + @" == 2 
else_jump @TRIA_22908 
0629: change_integer_stat 22 to 1000 

:TRIA_22908
0595: mission_complete 
" + Mission_BeatTheCock_Passed + @" = 1 

:TRIA_22917
return 

:TRIA_22919
" + OnMission + @" = 0 
Model.Destroy(829@)
Model.Destroy(830@)
Model.Destroy(831@)
Model.Destroy(832@)
Model.Destroy(833@)
Model.Destroy(834@)
Model.Destroy(835@)
Model.Destroy(836@)
Model.Destroy(837@)
Model.Destroy(838@)
Model.Destroy(839@)
Model.Destroy(840@)
Model.Destroy(#WMYBE)
Model.Destroy(#BMYBE)
Model.Destroy(#HMYBE)
Model.Destroy(#WMYBELL)
Model.Destroy(#MTBIKE)
Actor.RemoveReferences(954@)
Actor.RemoveReferences(943@)
Actor.RemoveReferences(944@)
Actor.RemoveReferences(945@)
Actor.RemoveReferences(946@)
Actor.RemoveReferences(947@)
Actor.RemoveReferences(948@)
Actor.RemoveReferences(949@)
Actor.RemoveReferences(950@)
Actor.RemoveReferences(951@)
Actor.RemoveReferences(952@)
Actor.RemoveReferences(953@)
09B9: show_entered_car_name 1 
Marker.Disable(939@)
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
08E7: disable_entrance_markers 0 
01EB: set_traffic_density_multiplier_to 1.0 
03DE: set_pedestrians_density_multiplier_to 1.0 
0912: set_text_priority 0 leftmargin 380 maxwidth 464 
03F0: enable_text_draw 0 
mission_cleanup 
return" );
            }

        }

    }

}