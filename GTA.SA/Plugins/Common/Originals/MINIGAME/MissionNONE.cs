using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class NONE : MissionCustom {

            Int tmp_5355 = global( _5355.startIndex ),
                tmp_5365 = global( _5365.startIndex ),
                tmp_5385 = global( _5385.startIndex ),
                tmp_5405 = global( _5405.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @NONE_16 
gosub @NONE_12441 
end_thread 

:NONE_16
" + OnMission + @" = 1 
increment_mission_attempts 
wait 0 
054C: use_GXT_table 'DUAL' 
09F5: disable_player_mutal_activities 1 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 0 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 50.0 
03F0: enable_text_draw 1 
0391: release_textures 
0390: load_txd_dictionary 'LD_NONE' 
038F: load_texture ""SHIP"" as 1 
038F: load_texture ""TVCORN"" as 2 
038F: load_texture ""SHOOT"" as 3 
038F: load_texture ""LIGHT"" as 4 
038F: load_texture ""EXPLM01"" as 5 
038F: load_texture ""EXPLM02"" as 6 
038F: load_texture ""EXPLM03"" as 7 
038F: load_texture ""EXPLM04"" as 8 
038F: load_texture ""EXPLM05"" as 9 
038F: load_texture ""EXPLM06"" as 10 
038F: load_texture ""EXPLM07"" as 11 
038F: load_texture ""EXPLM08"" as 12 
038F: load_texture ""EXPLM09"" as 13 
038F: load_texture ""EXPLM10"" as 14 
038F: load_texture ""EXPLM11"" as 15 
038F: load_texture ""EXPLM12"" as 16 
038F: load_texture ""FORCE"" as 17 
038F: load_texture ""WARP"" as 18 
038F: load_texture ""THRUST"" as 19 
038F: load_texture ""SHPNORM"" as 20 
038F: load_texture ""SHPWARP"" as 21 
038F: load_texture ""SHIP2"" as 22 
038F: load_texture ""SHIP3"" as 23 
038F: load_texture ""TITLE"" as 24 
03CF: load_wav 1829 as 4 

:NONE_403
if 
83D0:   not wav 4 loaded 
else_jump @NONE_429 
wait 0 
jump @NONE_403 

:NONE_429
097A: play_audio_at 0.0 0.0 0.0 event 1181 
34@ = 3.0 
35@ = 2.0 
36@ = 1.0 
37@ = 0.0 
38@ = -1.0 
39@ = -2.0 
40@ = -3.0 
41@ = -2.0 
42@ = -1.0 
43@ = -4.0 
44@ = 4.0 
45@ = 3.0 
46@ = 2.0 
47@ = -2.0 
48@ = -4.0 
49@ = -6.0 
50@ = -3.0 
51@ = -2.0 
52@ = -7.0 
53@ = -6.0 
54@ = 300 
55@ = 200 
56@ = 400 
57@ = 600 
58@ = 400 
59@ = 500 
60@ = 200 
61@ = 300 
62@ = 400 
63@ = 6000 
64@ = 2.0 
65@ = 3.0 
66@ = 1.0 
67@ = 0.0 
68@ = 1.0 
69@ = 3.0 
70@ = -3.0 
71@ = -3.0 
72@ = 2.0 
73@ = -5.0 
74@ = 0.0 
75@ = 3.0 
76@ = 4.0 
77@ = 5.0 
78@ = 12.0 
79@ = 6.0 
80@ = 3.0 
81@ = 0.0 
82@ = -4.0 
83@ = -6.0 
84@ = 100 
85@ = 400 
86@ = 300 
87@ = 500 
88@ = 400 
89@ = 200 
90@ = 400 
91@ = 400 
92@ = 400 
93@ = 6000 
94@ = 5.0 
95@ = -3.0 
96@ = 6.0 
97@ = -6.0 
98@ = 3.0 
99@ = -3.0 
100@ = 3.0 
101@ = -3.0 
102@ = 3.0 
103@ = -6.0 
104@ = 4.0 
105@ = 4.0 
106@ = 4.0 
107@ = 4.0 
108@ = 4.0 
109@ = 4.0 
110@ = 4.0 
111@ = 4.0 
112@ = 4.0 
113@ = 4.0 
114@ = 300 
115@ = 300 
116@ = 300 
117@ = 300 
118@ = 300 
119@ = 300 
120@ = 300 
121@ = 300 
122@ = 300 
123@ = 300 
124@ = 0.0 
132@ = 5.0 
125@ = 5.0 
133@ = 5.0 
126@ = 5.0 
134@ = 0.0 
127@ = -5.0 
135@ = 0.0 
128@ = -5.0 
136@ = -5.0 
129@ = 0.0 
137@ = -5.0 
130@ = 5.0 
138@ = -5.0 
131@ = -5.0 
139@ = 5.0 
05AA: 140@s = 'DUAL_0' 
05AA: 142@s = 'DUAL_1' 
05AA: 144@s = 'DUAL_2' 
05AA: 146@s = 'DUAL_3' 
05AA: 148@s = 'DUAL_4' 
05AA: 150@s = 'DUAL_5' 
05AA: 152@s = 'DUAL_6' 
05AA: 154@s = 'DUAL_7' 
05AA: 156@s = 'DUAL_8' 
05AA: 158@s = 'DUAL_9' 
05AA: 160@s = 'DUAL_AA' 
05AA: 162@s = 'DUAL_B' 
05AA: 164@s = 'DUAL_C' 
05AA: 166@s = 'DUAL_D' 
05AA: 168@s = 'DUAL_E' 
05AA: 170@s = 'DUAL_F' 
05AA: 172@s = 'DUAL_G' 
05AA: 174@s = 'DUAL_H' 
05AA: 176@s = 'DUAL_I' 
05AA: 178@s = 'DUAL_J' 
05AA: 180@s = 'DUAL_K' 
05AA: 182@s = 'DUAL_L' 
05AA: 184@s = 'DUAL_M' 
05AA: 186@s = 'DUAL_N' 
05AA: 188@s = 'DUAL_O' 
05AA: 190@s = 'DUAL_P' 
05AA: 192@s = 'DUAL_Q' 
05AA: 194@s = 'DUAL_R' 
05AA: 196@s = 'DUAL_S' 
05AA: 198@s = 'DUAL_T' 
05AA: 200@s = 'DUAL_U' 
05AA: 202@s = 'DUAL_V' 
05AA: 204@s = 'DUAL_W' 
05AA: 206@s = 'DUAL_X' 
05AA: 208@s = 'DUAL_Y' 
05AA: 210@s = 'DUAL_Z' 
05AA: 212@s = 'DUAL_FS' 
if 
  " + _5354 + @" == 0 
else_jump @NONE_2319 
" + tmp_5355 + @"[0] = 250000 
" + tmp_5355 + @"[1] = 100000 
" + tmp_5355 + @"[2] = 75000 
" + tmp_5355 + @"[3] = 50000 
" + tmp_5355 + @"[4] = 25000 
" + tmp_5355 + @"[5] = 10000 
" + tmp_5355 + @"[6] = 7500 
" + tmp_5355 + @"[7] = 5000 
" + tmp_5355 + @"[8] = 2500 
" + tmp_5355 + @"[9] = 1000 
05A9: s" + tmp_5365 + @"[0] = 160@s 
05A9: s" + tmp_5385 + @"[0] = 166@s 
05A9: s" + tmp_5405 + @"[0] = 210@s 
05A9: s" + tmp_5365 + @"[1] = 164@s 
05A9: s" + tmp_5385 + @"[1] = 160@s 
05A9: s" + tmp_5405 + @"[1] = 186@s 
05A9: s" + tmp_5365 + @"[2] = 176@s 
05A9: s" + tmp_5385 + @"[2] = 184@s 
05A9: s" + tmp_5405 + @"[2] = 208@s 
05A9: s" + tmp_5365 + @"[3] = 204@s 
05A9: s" + tmp_5385 + @"[3] = 176@s 
05A9: s" + tmp_5405 + @"[3] = 182@s 
05A9: s" + tmp_5365 + @"[4] = 166@s 
05A9: s" + tmp_5385 + @"[4] = 162@s 
05A9: s" + tmp_5405 + @"[4] = 190@s 
05A9: s" + tmp_5365 + @"[5] = 166@s 
05A9: s" + tmp_5385 + @"[5] = 160@s 
05A9: s" + tmp_5405 + @"[5] = 202@s 
05A9: s" + tmp_5365 + @"[6] = 166@s 
05A9: s" + tmp_5385 + @"[6] = 188@s 
05A9: s" + tmp_5405 + @"[6] = 166@s 
05A9: s" + tmp_5365 + @"[7] = 186@s 
05A9: s" + tmp_5385 + @"[7] = 170@s 
05A9: s" + tmp_5405 + @"[7] = 212@s 
05A9: s" + tmp_5365 + @"[8] = 180@s 
05A9: s" + tmp_5385 + @"[8] = 184@s 
05A9: s" + tmp_5405 + @"[8] = 162@s 
05A9: s" + tmp_5365 + @"[9] = 196@s 
05A9: s" + tmp_5385 + @"[9] = 178@s 
05A9: s" + tmp_5405 + @"[9] = 182@s 
" + _5354 + @" = 1 

:NONE_2319
214@ = 336.4137 
215@ = 58.2432 
216@ = 201.225 
217@ = 88.9168 
218@ = 29.78 
219@ = 260.0 
220@ = 28.5713 
221@ = 0 
222@ = 0 
223@ = 0 
224@ = 0 
fade 1 0 
038E: draw_box_position 320.0 224.0 size 640.0 448.0 RGBA 0 0 0 255 
225@ = 0 
226@ = -1 
227@ = 0 

:NONE_2475
0208: 290@(227@,60f) = random_float_in_ranges 0.0 300.0 
0208: 230@(227@,60f) = random_float_in_ranges 0.0 360.0 
227@ += 1 
  227@ >= 60 
else_jump @NONE_2475 
350@ = 8.0 

:NONE_2544
wait 0 
038E: draw_box_position 320.0 224.0 size 640.0 448.0 RGBA 0 0 0 255 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
392@ = 0 
0494: get_joystick 0 direction_offset_to 422@ 423@ 424@ 424@ 
if or
00E1:   player 0 pressed_key 8 
  -100 > 423@ 
else_jump @NONE_2760 
if 
  221@ == 0 
else_jump @NONE_2746 
if 
  225@ == 2 
else_jump @NONE_2701 
225@ = 1 
097A: play_audio_at 0.0 0.0 0.0 event 1179 
jump @NONE_2746 

:NONE_2701
if 
  225@ == 1 
else_jump @NONE_2746 
225@ = 0 
097A: play_audio_at 0.0 0.0 0.0 event 1179 

:NONE_2746
221@ = 1 
jump @NONE_2927 

:NONE_2760
if or
00E1:   player 0 pressed_key 9 
  423@ > 100 
else_jump @NONE_2913 
if 
  222@ == 0 
else_jump @NONE_2899 
if 
  225@ == 0 
else_jump @NONE_2854 
225@ = 1 
097A: play_audio_at 0.0 0.0 0.0 event 1179 
jump @NONE_2899 

:NONE_2854
if 
  225@ == 1 
else_jump @NONE_2899 
225@ = 2 
097A: play_audio_at 0.0 0.0 0.0 event 1179 

:NONE_2899
222@ = 1 
jump @NONE_2920 

:NONE_2913
222@ = 0 

:NONE_2920
221@ = 0 

:NONE_2927
gosub @NONE_12369 
if 
  225@ == 0 
else_jump @NONE_2971 
0340: set_text_draw_RGBA 255 0 0 255 
jump @NONE_2985 

:NONE_2971
0340: set_text_draw_RGBA 255 255 255 255 

:NONE_2985
033F: set_text_draw_letter_size 1.0 3.0 
033E: set_draw_text_position 320.0 250.0 GXT 'SPAC_04'  
gosub @NONE_12369 
if 
  225@ == 1 
else_jump @NONE_3062 
0340: set_text_draw_RGBA 255 0 0 255 
jump @NONE_3076 

:NONE_3062
0340: set_text_draw_RGBA 255 255 255 255 

:NONE_3076
033F: set_text_draw_letter_size 1.0 3.0 
033E: set_draw_text_position 320.0 300.0 GXT 'SPAC_06'  
gosub @NONE_12369 
if 
  225@ == 2 
else_jump @NONE_3153 
0340: set_text_draw_RGBA 255 0 0 255 
jump @NONE_3167 

:NONE_3153
0340: set_text_draw_RGBA 255 255 255 255 

:NONE_3167
033F: set_text_draw_letter_size 1.0 3.0 
033E: set_draw_text_position 320.0 350.0 GXT 'SPAC_05'  
227@ = 0 

:NONE_3207
0087: 425@ = 350@ 
425@ /= 2.0 
007B: 290@(227@,60f) += frame_delta_time * 425@ 
02F7: " + tempvar_Float_1 + @" = cosine 230@(227@,60f) 
02F6: " + tempvar_Float_2 + @" = sine 230@(227@,60f) 
006D: " + tempvar_Float_1 + @" *= 290@(227@,60f) 
006D: " + tempvar_Float_2 + @" *= 290@(227@,60f) 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 1.0 1.0 RGBA 255 255 255 255 
if or
  " + tempvar_Float_1 + @" > 640.0 
  0.0 > " + tempvar_Float_1 + @" 
  0.0 > " + tempvar_Float_2 + @" 
  " + tempvar_Float_2 + @" > 448.0 
else_jump @NONE_3419 
290@(227@,60f) = 10.0 
0208: 230@(227@,60f) = random_float_in_ranges 0.0 360.0 

:NONE_3419
227@ += 1 
  227@ >= 60 
else_jump @NONE_3207 
038D: draw_texture 24 position 320.0 140.0 size 256.0 128.0 RGBA 220 220 220 255 
038D: draw_texture 2 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @NONE_3785 
if 
  223@ == 0 
else_jump @NONE_3778 
223@ += 1 
097A: play_audio_at 0.0 0.0 0.0 event 1180 
if 
  225@ == 0 
else_jump @NONE_3707 
jump @NONE_3799 

:NONE_3707
if 
  225@ == 1 
else_jump @NONE_3732 
jump @NONE_10411 

:NONE_3732
if 
  225@ == 2 
else_jump @NONE_3778 
0391: release_textures 
Player.CanMove(" + PlayerChar + @") = True
fade 0 0 
wait 0 
fade 1 500 
return 

:NONE_3778
jump @NONE_3792 

:NONE_3785
223@ = 0 

:NONE_3792
jump @NONE_2544 

:NONE_3799
351@ = 90.0 
227@ = 0 

:NONE_3816
352@(227@,10i) = 0 
362@(227@,10i) = 0 
372@(227@,10i) = 0 
382@(227@,10i) = 0 
227@ += 1 
  227@ >= 10 
else_jump @NONE_3816 
392@ = 0 
393@ = 0 
394@ = 0 
227@ = 0 

:NONE_3909
395@(227@,8i) = 0 
227@ += 1 
  227@ >= 8 
else_jump @NONE_3909 
403@ = 0 
404@ = 255 
405@ = -50 
406@ = 0 
407@ = 100 
0085: 408@ = 407@ 
409@ = 0 
410@ = 0 
411@ = 100 
412@ = 3 
413@ = 0 
414@ = 0 
415@ = 0 
416@ = 0 
417@ = 0 
418@ = 0 
419@ = 1 
420@ = 0 
421@ = 190.0 
350@ = 8.0 

:NONE_4089
wait 0 
038E: draw_box_position 320.0 224.0 size 640.0 448.0 RGBA 0 0 0 255 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
227@ = 0 

:NONE_4136
0087: 425@ = 350@ 
425@ /= 2.0 
007B: 290@(227@,60f) += frame_delta_time * 425@ 
02F7: " + tempvar_Float_1 + @" = cosine 230@(227@,60f) 
02F6: " + tempvar_Float_2 + @" = sine 230@(227@,60f) 
006D: " + tempvar_Float_1 + @" *= 290@(227@,60f) 
006D: " + tempvar_Float_2 + @" *= 290@(227@,60f) 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 1.0 1.0 RGBA 255 255 255 255 
if or
  " + tempvar_Float_1 + @" > 640.0 
  0.0 > " + tempvar_Float_1 + @" 
  0.0 > " + tempvar_Float_2 + @" 
  " + tempvar_Float_2 + @" > 448.0 
else_jump @NONE_4348 
290@(227@,60f) = 10.0 
0208: 230@(227@,60f) = random_float_in_ranges 0.0 360.0 

:NONE_4348
227@ += 1 
  227@ >= 60 
else_jump @NONE_4136 
if 
  394@ == 0 
else_jump @NONE_5395 
if 
  2 > 418@ 
else_jump @NONE_4559 
if 
00E1:   player 0 pressed_key 11 
else_jump @NONE_4447 
0079: 351@ += frame_delta_time * -1.325 
0656: get_angle 351@ absolute_degrees_to 351@ 
jump @NONE_4559 

:NONE_4447
if 
00E1:   player 0 pressed_key 10 
else_jump @NONE_4489 
0079: 351@ += frame_delta_time * 1.325 
0656: get_angle 351@ absolute_degrees_to 351@ 
jump @NONE_4559 

:NONE_4489
0494: get_joystick 0 direction_offset_to 422@ 423@ 424@ 424@ 
0093: 425@ = integer 422@ to_float 
425@ *= -1.0 
425@ /= 25.0 
425@ /= 2.0 
007B: 351@ += frame_delta_time * 425@ 
0656: get_angle 351@ absolute_degrees_to 351@ 

:NONE_4559
02F7: " + tempvar_Float_1 + @" = cosine 351@ 
02F6: " + tempvar_Float_2 + @" = sine 351@ 
0089: 426@ = " + tempvar_Float_2 + @" 
426@ *= 22.0 
if 
  0.0 > 426@ 
else_jump @NONE_4624 
426@ *= -1.0 

:NONE_4624
426@ += 26.0 
0089: 427@ = " + tempvar_Float_1 + @" 
427@ *= 22.0 
if 
  0.0 > 427@ 
else_jump @NONE_4683 
427@ *= -1.0 

:NONE_4683
427@ += 26.0 
if 
  418@ == 2 
else_jump @NONE_4766 
007F: 421@ -= frame_delta_time * 1.0 
350@ = 16.0 
if 
  20.0 > 421@ 
else_jump @NONE_4759 
418@ = 3 

:NONE_4759
jump @NONE_4873 

:NONE_4766
if 
  418@ == 3 
else_jump @NONE_4853 
0079: 421@ += frame_delta_time * 1.0 
if 
  421@ > 190.0 
else_jump @NONE_4846 
421@ = 190.0 
416@ = 0 
419@ += 1 
418@ = 0 

:NONE_4846
jump @NONE_4873 

:NONE_4853
350@ = 8.0 
421@ = 190.0 

:NONE_4873
006D: " + tempvar_Float_1 + @" *= 421@ 
006D: " + tempvar_Float_2 + @" *= 421@ 
0089: 428@ = " + tempvar_Float_1 + @" 
428@ += 320.0 
0089: 429@ = " + tempvar_Float_2 + @" 
429@ += 224.0 
if 
001F:   403@ > " + Current_Time_in_ms2 + @" 
else_jump @NONE_5025 
005A: 404@ += 405@ 
if 
  404@ > 255 
else_jump @NONE_4986 
404@ = 255 
405@ = -50 

:NONE_4986
if 
  0 > 404@ 
else_jump @NONE_5018 
404@ = 0 
405@ = 50 

:NONE_5018
jump @NONE_5033 

:NONE_5025
404@ = 255 

:NONE_5033
0087: 431@ = 421@ 
431@ /= 5.9375 
0087: 430@ = 431@ 
430@ *= 2.0 
0088: " + tempvar_Angle + @" = 351@ 
" + tempvar_Angle + @" += 90.0 
if 
  2 > 418@ 
else_jump @NONE_5143 
074B: draw_texture 20 position 428@ 429@ scale 430@ 431@ angle " + tempvar_Angle + @" color_RGBA 220 220 220 404@ 
jump @NONE_5174 

:NONE_5143
074B: draw_texture 21 position 428@ 429@ scale 430@ 431@ angle " + tempvar_Angle + @" color_RGBA 220 220 220 404@ 

:NONE_5174
if 
  2 > 418@ 
else_jump @NONE_5388 
if 
00E1:   player 0 pressed_key 17 
else_jump @NONE_5381 
if 
  224@ == 0 
else_jump @NONE_5374 
227@ = 0 

:NONE_5234
if 
  352@(227@,10i) == 0 
else_jump @NONE_5326 
0087: 432@(227@,10f) = 351@ 
442@(227@,10f) = 190.0 
352@(227@,10i) = 1 
452@(227@,10f) = -12.0 
0089: 462@(227@,10f) = " + tempvar_Angle + @" 
227@ = 9 

:NONE_5326
227@ += 1 
  227@ >= 10 
else_jump @NONE_5234 
097A: play_audio_at 0.0 0.0 0.0 event 1170 
224@ = 1 

:NONE_5374
jump @NONE_5388 

:NONE_5381
224@ = 0 

:NONE_5388
jump @NONE_6019 

:NONE_5395
if 
  394@ == 1 
else_jump @NONE_5503 
227@ = 0 

:NONE_5420
395@(227@,8i) = 1 
0087: 472@(227@,8f) = 428@ 
0087: 480@(227@,8f) = 429@ 
227@ += 1 
  227@ >= 8 
else_jump @NONE_5420 
097A: play_audio_at 0.0 0.0 0.0 event 1172 
394@ += 1 

:NONE_5503
if 
  394@ == 2 
else_jump @NONE_5940 
227@ = 0 

:NONE_5528
if 
  395@(227@,8i) > 0 
else_jump @NONE_5711 
if 
  395@(227@,8i) == 1 
else_jump @NONE_5583 
395@(227@,8i) = 5 

:NONE_5583
005B: 472@(227@,8f) += 124@(227@,8f) 
005B: 480@(227@,8f) += 132@(227@,8f) 
395@(227@,8i) += 1 
if 
  395@(227@,8i) > 16 
else_jump @NONE_5666 
395@(227@,8i) = 0 
jump @NONE_5711 

:NONE_5666
038D: draw_texture 395@(227@,8i) position 472@(227@,8f) 480@(227@,8f) size 32.0 32.0 RGBA 220 220 220 255 

:NONE_5711
227@ += 1 
  227@ >= 8 
else_jump @NONE_5528 
424@ = 0 
227@ = 0 

:NONE_5746
005A: 424@ += 395@(227@,8i) 
227@ += 1 
  227@ >= 8 
else_jump @NONE_5746 
if 
  424@ == 0 
else_jump @NONE_5940 
351@ = 90.0 
008B: 403@ = " + Current_Time_in_ms2 + @" 
403@ += 2500 
409@ = 0 
410@ = 0 
411@ = 100 
408@ = 100 
412@ -= 1 
if 
  412@ > 0 
else_jump @NONE_5897 
394@ = 0 
407@ = 100 
jump @NONE_5940 

:NONE_5897
008B: 488@ = " + Current_Time_in_ms2 + @" 
488@ += 3000 
394@ = 3 
097A: play_audio_at 0.0 0.0 0.0 event 1178 

:NONE_5940
if 
  394@ == 3 
else_jump @NONE_6019 
if 
001F:   488@ > " + Current_Time_in_ms2 + @" 
else_jump @NONE_6012 
gosub @NONE_12369 
033E: set_draw_text_position 320.0 100.0 GXT 'SPAC_01'  
jump @NONE_6019 

:NONE_6012
406@ = 1 

:NONE_6019
227@ = 0 

:NONE_6026
if 
  352@(227@,10i) == 1 
else_jump @NONE_6264 
0087: 425@ = 452@(227@,10f) 
425@ /= 2.0 
007B: 442@(227@,10f) += frame_delta_time * 425@ 
02F7: " + tempvar_Float_1 + @" = cosine 432@(227@,10f) 
02F6: " + tempvar_Float_2 + @" = sine 432@(227@,10f) 
006D: " + tempvar_Float_1 + @" *= 442@(227@,10f) 
006D: " + tempvar_Float_2 + @" *= 442@(227@,10f) 
0089: 489@(227@,10f) = " + tempvar_Float_1 + @" 
489@(227@,10f) += 320.0 
0089: 499@(227@,10f) = " + tempvar_Float_2 + @" 
499@(227@,10f) += 224.0 
074B: draw_texture 3 position 489@(227@,10f) 499@(227@,10f) scale 8.0 8.0 angle 462@(227@,10f) color_RGBA 52 183 195 255 
if 
  10.0 > 442@(227@,10f) 
else_jump @NONE_6264 
352@(227@,10i) = 0 

:NONE_6264
227@ += 1 
  227@ >= 10 
else_jump @NONE_6026 
if 
  418@ == 0 
else_jump @NONE_6383 
if 
001E:   " + Current_Time_in_ms2 + @" > 509@ 
else_jump @NONE_6376 
0208: 510@ = random_float_in_ranges 0.0 360.0 
0209: 511@ = random_int_in_ranges 0 3 
413@ = 0 
512@ = 10 
008B: 509@ = " + Current_Time_in_ms2 + @" 
509@ += 8000 

:NONE_6376
jump @NONE_6399 

:NONE_6383
008B: 509@ = " + Current_Time_in_ms2 + @" 
509@ += 1000 

:NONE_6399
if 
  512@ > 0 
else_jump @NONE_6644 
if 
001E:   " + Current_Time_in_ms2 + @" > 393@ 
else_jump @NONE_6644 
227@ = 0 

:NONE_6443
if 
  372@(227@,10i) == 0 
else_jump @NONE_6623 
0087: 513@(227@,10f) = 510@ 
523@(227@,10f) = 5.0 
533@(227@,10f) = 3.0 
543@(227@,10f) = 10.0 
553@(227@,10i) = 0 
008B: 563@(227@,10i) = " + Current_Time_in_ms2 + @" 
563@(227@,10i) += 500 
372@(227@,10i) = 1 
593@(227@,10f) = 320.0 
603@(227@,10f) = 224.0 
008B: 393@ = " + Current_Time_in_ms2 + @" 
393@ += 200 
512@ -= 1 
227@ = 9 

:NONE_6623
227@ += 1 
  227@ >= 10 
else_jump @NONE_6443 

:NONE_6644
420@ = 0 
227@ = 0 

:NONE_6658
if 
  372@(227@,10i) == 1 
else_jump @NONE_8181 
if 
  10 > 553@(227@,10i) 
else_jump @NONE_6982 
if 
001E:   " + Current_Time_in_ms2 + @" > 563@(227@,10i) 
else_jump @NONE_6982 
0085: 424@ = 553@(227@,10i) 
if 
  511@ == 0 
else_jump @NONE_6815 
0087: 533@(227@,10f) = 34@(424@,10f) 
0087: 523@(227@,10f) = 44@(424@,10f) 
008B: 563@(227@,10i) = " + Current_Time_in_ms2 + @" 
005A: 563@(227@,10i) += 54@(424@,10i) 

:NONE_6815
if 
  511@ == 1 
else_jump @NONE_6893 
0087: 533@(227@,10f) = 64@(424@,10f) 
0087: 523@(227@,10f) = 74@(424@,10f) 
008B: 563@(227@,10i) = " + Current_Time_in_ms2 + @" 
005A: 563@(227@,10i) += 84@(424@,10i) 

:NONE_6893
if 
  511@ == 2 
else_jump @NONE_6971 
0087: 533@(227@,10f) = 94@(424@,10f) 
0087: 523@(227@,10f) = 104@(424@,10f) 
008B: 563@(227@,10i) = " + Current_Time_in_ms2 + @" 
005A: 563@(227@,10i) += 114@(424@,10i) 

:NONE_6971
553@(227@,10i) += 1 

:NONE_6982
420@ = 1 
0087: 425@ = 533@(227@,10f) 
425@ /= 2.0 
007B: 543@(227@,10f) += frame_delta_time * 425@ 
0087: 425@ = 523@(227@,10f) 
425@ /= 2.0 
007B: 513@(227@,10f) += frame_delta_time * 425@ 
0656: get_angle 513@(227@,10f) absolute_degrees_to 513@(227@,10f) 
02F7: " + tempvar_Float_1 + @" = cosine 513@(227@,10f) 
02F6: " + tempvar_Float_2 + @" = sine 513@(227@,10f) 
006D: " + tempvar_Float_1 + @" *= 543@(227@,10f) 
006D: " + tempvar_Float_2 + @" *= 543@(227@,10f) 
0087: 593@(227@,10f) = 573@(227@,10f) 
0087: 603@(227@,10f) = 583@(227@,10f) 
0089: 573@(227@,10f) = " + tempvar_Float_1 + @" 
573@(227@,10f) += 320.0 
0089: 583@(227@,10f) = " + tempvar_Float_2 + @" 
583@(227@,10f) += 224.0 
0087: 613@ = 543@(227@,10f) 
613@ /= 5.0 
0088: " + tempvar_Float_1 + @" = 573@(227@,10f) 
0067: " + tempvar_Float_1 + @" -= 593@(227@,10f) 
0088: " + tempvar_Float_2 + @" = 583@(227@,10f) 
0067: " + tempvar_Float_2 + @" -= 603@(227@,10f) 
0604: get_Z_angle_for_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" store_to " + tempvar_Angle + @" 
if 
  511@ == 0 
else_jump @NONE_7350 
074B: draw_texture 1 position 573@(227@,10f) 583@(227@,10f) scale 613@ 613@ angle " + tempvar_Angle + @" color_RGBA 220 220 220 255 
jump @NONE_7453 

:NONE_7350
if 
  511@ == 1 
else_jump @NONE_7414 
074B: draw_texture 22 position 573@(227@,10f) 583@(227@,10f) scale 613@ 613@ angle " + tempvar_Angle + @" color_RGBA 220 220 220 255 
jump @NONE_7453 

:NONE_7414
074B: draw_texture 23 position 573@(227@,10f) 583@(227@,10f) scale 613@ 613@ angle " + tempvar_Angle + @" color_RGBA 220 220 220 255 

:NONE_7453
0088: " + tempvar_Float_1 + @" = 351@ 
" + tempvar_Float_1 + @" += 10.0 
0088: " + tempvar_Float_2 + @" = 351@ 
" + tempvar_Float_2 + @" -= 10.0 
if and
0026:   " + tempvar_Float_1 + @" > 513@(227@,10f) 
0027:   513@(227@,10f) > " + tempvar_Float_2 + @" 
else_jump @NONE_7726 
424@ = 18 
0062: 424@ -= 419@ 
if 
  4 > 424@ 
else_jump @NONE_7564 
424@ = 4 

:NONE_7564
0209: 424@ = random_int_in_ranges 0 424@ 
if 
  424@ == 0 
else_jump @NONE_7726 
228@ = 0 

:NONE_7599
if 
  382@(228@,10i) == 0 
else_jump @NONE_7705 
0087: 614@(228@,10f) = 513@(227@,10f) 
0087: 624@(228@,10f) = 543@(227@,10f) 
382@(228@,10i) = 1 
634@(228@,10f) = 6.0 
097A: play_audio_at 0.0 0.0 0.0 event 1171 
228@ = 9 

:NONE_7705
228@ += 1 
  228@ >= 10 
else_jump @NONE_7599 

:NONE_7726
if or
  543@(227@,10f) > 320.0 
  10.0 > 543@(227@,10f) 
else_jump @NONE_7776 
372@(227@,10i) = 0 

:NONE_7776
228@ = 0 

:NONE_7783
if 
  352@(228@,10i) == 1 
else_jump @NONE_8160 
if 
05A5:   is_area_center 489@(228@,10f) 499@(228@,10f) scale 12.0 12.0 overlaping_area_center 573@(227@,10f) 583@(227@,10f) scale 613@ 613@ 
else_jump @NONE_8160 
372@(227@,10i) = 0 
352@(228@,10i) = 0 
413@ += 1 
if 
  413@ == 10 
else_jump @NONE_8010 
0087: 644@ = 573@(227@,10f) 
0087: 645@ = 583@(227@,10f) 
008B: 415@ = " + Current_Time_in_ms2 + @" 
415@ += 1500 
0087: 646@ = 513@(227@,10f) 
0087: 647@ = 543@(227@,10f) 
417@ += 1 
414@ = 100 
006A: 414@ *= 419@ 
005A: 392@ += 414@ 
jump @NONE_8033 

:NONE_8010
424@ = 10 
006A: 424@ *= 419@ 
005A: 392@ += 424@ 

:NONE_8033
229@ = 0 

:NONE_8040
if 
  362@(229@,10i) == 0 
else_jump @NONE_8132 
0087: 648@(229@,10f) = 573@(227@,10f) 
0087: 658@(229@,10f) = 583@(227@,10f) 
362@(229@,10i) += 1 
097A: play_audio_at 0.0 0.0 0.0 event 1172 
229@ = 9 

:NONE_8132
229@ += 1 
  229@ >= 10 
else_jump @NONE_8040 
228@ = 9 

:NONE_8160
228@ += 1 
  228@ >= 10 
else_jump @NONE_7783 

:NONE_8181
227@ += 1 
  227@ >= 10 
else_jump @NONE_6658 
if 
  418@ == 1 
else_jump @NONE_8265 
if 
  420@ == 0 
else_jump @NONE_8265 
097A: play_audio_at 0.0 0.0 0.0 event 1176 
418@ = 2 

:NONE_8265
227@ = 0 

:NONE_8272
if 
  382@(227@,10i) == 1 
else_jump @NONE_8758 
0087: 425@ = 634@(227@,10f) 
425@ /= 2.0 
007B: 624@(227@,10f) += frame_delta_time * 425@ 
02F7: " + tempvar_Float_1 + @" = cosine 614@(227@,10f) 
02F6: " + tempvar_Float_2 + @" = sine 614@(227@,10f) 
006D: " + tempvar_Float_1 + @" *= 624@(227@,10f) 
006D: " + tempvar_Float_2 + @" *= 624@(227@,10f) 
0089: 668@(227@,10f) = " + tempvar_Float_1 + @" 
668@(227@,10f) += 320.0 
0089: 678@(227@,10f) = " + tempvar_Float_2 + @" 
678@(227@,10f) += 224.0 
038D: draw_texture 4 position 668@(227@,10f) 678@(227@,10f) size 8.0 8.0 RGBA 244 0 0 255 
if 
85A5:   not is_area_center 668@(227@,10f) 678@(227@,10f) scale 8.0 8.0 overlaping_area_center 320.0 224.0 scale 640.0 448.0 
else_jump @NONE_8534 
382@(227@,10i) = 0 

:NONE_8534
if 
  394@ == 0 
else_jump @NONE_8758 
if 
05A5:   is_area_center 668@(227@,10f) 678@(227@,10f) scale 8.0 8.0 overlaping_area_center 428@ 429@ scale 426@ 427@ 
else_jump @NONE_8758 
if 
001E:   " + Current_Time_in_ms2 + @" > 403@ 
else_jump @NONE_8627 
407@ -= 20 

:NONE_8627
382@(227@,10i) = 0 
229@ = 0 

:NONE_8645
if 
  362@(229@,10i) == 0 
else_jump @NONE_8737 
0087: 648@(229@,10f) = 668@(227@,10f) 
0087: 658@(229@,10f) = 678@(227@,10f) 
362@(229@,10i) += 1 
097A: play_audio_at 0.0 0.0 0.0 event 1172 
229@ = 9 

:NONE_8737
229@ += 1 
  229@ >= 10 
else_jump @NONE_8645 

:NONE_8758
227@ += 1 
  227@ >= 10 
else_jump @NONE_8272 
if 
  394@ == 0 
else_jump @NONE_9001 
if 
  409@ > 0 
else_jump @NONE_9001 
if 
  409@ > 1 
else_jump @NONE_8847 
411@ = 100 
409@ -= 1 

:NONE_8847
005A: 410@ += 411@ 
if 
  410@ > 255 
else_jump @NONE_8889 
410@ = 255 
411@ = -20 

:NONE_8889
if 
  0 > 410@ 
else_jump @NONE_8928 
410@ = 0 
411@ = 100 
409@ = 0 

:NONE_8928
0088: " + tempvar_Angle + @" = 351@ 
" + tempvar_Angle + @" += 90.0 
097A: play_audio_at 0.0 0.0 0.0 event 1177 
074B: draw_texture 17 position 428@ 429@ scale 64.0 32.0 angle " + tempvar_Angle + @" color_RGBA 220 220 220 410@ 

:NONE_9001
227@ = 0 

:NONE_9008
if 
  362@(227@,10i) > 0 
else_jump @NONE_9159 
if 
  362@(227@,10i) == 1 
else_jump @NONE_9063 
362@(227@,10i) = 5 

:NONE_9063
362@(227@,10i) += 1 
if 
  362@(227@,10i) > 16 
else_jump @NONE_9114 
362@(227@,10i) = 0 
jump @NONE_9159 

:NONE_9114
038D: draw_texture 362@(227@,10i) position 648@(227@,10f) 658@(227@,10f) size 32.0 32.0 RGBA 220 220 220 255 

:NONE_9159
227@ += 1 
  227@ >= 10 
else_jump @NONE_9008 
if 
  417@ == 1 
else_jump @NONE_9566 
0079: 647@ += frame_delta_time * 1.0 
0656: get_angle 646@ absolute_degrees_to 646@ 
02F7: " + tempvar_Float_1 + @" = cosine 646@ 
02F6: " + tempvar_Float_2 + @" = sine 646@ 
006D: " + tempvar_Float_1 + @" *= 647@ 
006D: " + tempvar_Float_2 + @" *= 647@ 
0089: 688@ = " + tempvar_Float_1 + @" 
688@ += 320.0 
0089: 689@ = " + tempvar_Float_2 + @" 
689@ += 224.0 
038D: draw_texture 18 position 688@ 689@ size 16.0 16.0 RGBA 255 255 255 255 
if 
  394@ == 0 
else_jump @NONE_9510 
if 
05A5:   is_area_center 688@ 689@ scale 16.0 16.0 overlaping_area_center 428@ 429@ scale 426@ 427@ 
else_jump @NONE_9510 
416@ += 1 
if 
  416@ == 1 
else_jump @NONE_9420 
097A: play_audio_at 0.0 0.0 0.0 event 1173 

:NONE_9420
if 
  416@ == 2 
else_jump @NONE_9458 
097A: play_audio_at 0.0 0.0 0.0 event 1174 

:NONE_9458
if 
  416@ == 3 
else_jump @NONE_9503 
097A: play_audio_at 0.0 0.0 0.0 event 1175 
418@ = 1 

:NONE_9503
417@ = 0 

:NONE_9510
if 
85A5:   not is_area_center 688@ 689@ scale 16.0 16.0 overlaping_area_center 320.0 224.0 scale 640.0 448.0 
else_jump @NONE_9566 
417@ = 0 

:NONE_9566
if or
  0 > 407@ 
  407@ == 0 
else_jump @NONE_9623 
407@ = 0 
if 
  394@ == 0 
else_jump @NONE_9623 
394@ = 1 

:NONE_9623
if 
001D:   408@ > 407@ 
else_jump @NONE_9657 
0085: 408@ = 407@ 
409@ += 1 

:NONE_9657
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
033E: set_draw_text_position 95.0 45.0 GXT 'NONE_01'  
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
045A: draw_text_1number 95.0 70.0 GXT 'NUMBER' number 392@  
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
033E: set_draw_text_position 550.0 45.0 GXT 'NONE_02'  
038D: draw_texture 20 position 527.2529 84.2723 size 48.0 24.0 RGBA 220 220 220 255 
gosub @NONE_12369 
0342: set_text_draw_centered 0 
033F: set_text_draw_letter_size 0.6 2.6 
045A: draw_text_1number 554.7283 70.0 GXT 'NONE_03' number 412@  
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
033E: set_draw_text_position 550.0 350.0 GXT 'NONE_04'  
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
045A: draw_text_1number 550.0 375.0 GXT 'NONE_05' number 407@  
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
033E: set_draw_text_position 95.0 350.0 GXT 'NONE_07'  
gosub @NONE_12369 
033F: set_text_draw_letter_size 0.6 2.6 
045A: draw_text_1number 95.0 375.0 GXT 'NUMBER' number 419@  
if 
001F:   415@ > " + Current_Time_in_ms2 + @" 
else_jump @NONE_10100 
gosub @NONE_12369 
0340: set_text_draw_RGBA 0 180 180 255 
033F: set_text_draw_letter_size 0.5 1.5 
045A: draw_text_1number 644@ 645@ GXT 'NUMBER' number 414@  

:NONE_10100
if 
  394@ == 0 
else_jump @NONE_10164 
if 
  418@ > 0 
else_jump @NONE_10164 
gosub @NONE_12369 
033E: set_draw_text_position 320.0 100.0 GXT 'NONE_06'  

:NONE_10164
038D: draw_texture 2 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 15 
else_jump @NONE_10332 
406@ = 1 

:NONE_10332
if 
  406@ == 1 
else_jump @NONE_10404 
if 
001F:   392@ > " + tmp_5355 + @"[9] 
else_jump @NONE_10397 
690@ = 10 
691@ = 0 
jump @NONE_10411 
jump @NONE_10404 

:NONE_10397
jump @NONE_2544 

:NONE_10404
jump @NONE_4089 

:NONE_10411
wait 0 
038E: draw_box_position 320.0 224.0 size 640.0 448.0 RGBA 0 0 0 255 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
227@ = 9 

:NONE_10458
if 
  227@ > -1 
else_jump @NONE_10705 
if 
001F:   392@ > " + tmp_5355 + @"(227@,10i) 
else_jump @NONE_10684 
if 
   not 227@ == 9 
else_jump @NONE_10596 
0085: 228@ = 227@ 
228@ += 1 
0084: " + tmp_5355 + @"(228@,10i) = " + tmp_5355 + @"(227@,10i) 
05A9: " + tmp_5365 + @"(228@,10s) = " + tmp_5365 + @"(227@,10s) 
05A9: " + tmp_5385 + @"(228@,10s) = " + tmp_5385 + @"(227@,10s) 
05A9: " + tmp_5405 + @"(228@,10s) = " + tmp_5405 + @"(227@,10s) 

:NONE_10596
008A: " + tmp_5355 + @"(227@,10i) = 392@ 
05A9: " + tmp_5365 + @"(227@,10s) = 212@s 
05A9: " + tmp_5385 + @"(227@,10s) = 212@s 
05A9: " + tmp_5405 + @"(227@,10s) = 212@s 
0085: 226@ = 227@ 
if 
  227@ == 0 
else_jump @NONE_10677 
392@ = 0 

:NONE_10677
jump @NONE_10691 

:NONE_10684
392@ = 0 

:NONE_10691
227@ -= 1 
jump @NONE_10458 

:NONE_10705
if 
  226@ > -1 
else_jump @NONE_11207 
if 
  691@ == 0 
else_jump @NONE_10781 
05A9: " + tmp_5365 + @"(226@,10s) = 140@(690@,37s) 
05A9: " + tmp_5385 + @"(226@,10s) = 212@s 
05A9: " + tmp_5405 + @"(226@,10s) = 212@s 

:NONE_10781
if 
  691@ == 1 
else_jump @NONE_10827 
05A9: " + tmp_5385 + @"(226@,10s) = 140@(690@,37s) 
05A9: " + tmp_5405 + @"(226@,10s) = 212@s 

:NONE_10827
if 
  691@ == 2 
else_jump @NONE_10861 
05A9: " + tmp_5405 + @"(226@,10s) = 140@(690@,37s) 

:NONE_10861
0494: get_joystick 0 direction_offset_to 422@ 423@ 424@ 424@ 
if or
00E1:   player 0 pressed_key 8 
  -100 > 423@ 
else_jump @NONE_10982 
if 
001E:   " + Current_Time_in_ms2 + @" > 221@ 
else_jump @NONE_10975 
if 
  36 > 690@ 
else_jump @NONE_10952 
690@ += 1 
jump @NONE_10959 

:NONE_10952
690@ = 0 

:NONE_10959
008B: 221@ = " + Current_Time_in_ms2 + @" 
221@ += 250 

:NONE_10975
jump @NONE_10998 

:NONE_10982
008B: 221@ = " + Current_Time_in_ms2 + @" 
221@ -= 250 

:NONE_10998
if or
00E1:   player 0 pressed_key 9 
  423@ > 100 
else_jump @NONE_11103 
if 
001E:   " + Current_Time_in_ms2 + @" > 222@ 
else_jump @NONE_11096 
if 
  690@ > 0 
else_jump @NONE_11073 
690@ -= 1 
jump @NONE_11080 

:NONE_11073
690@ = 36 

:NONE_11080
008B: 222@ = " + Current_Time_in_ms2 + @" 
222@ += 250 

:NONE_11096
jump @NONE_11119 

:NONE_11103
008B: 222@ = " + Current_Time_in_ms2 + @" 
222@ -= 250 

:NONE_11119
if 
00E1:   player 0 pressed_key 16 
else_jump @NONE_11200 
if 
  223@ == 0 
else_jump @NONE_11193 
691@ += 1 
223@ += 1 
if 
  691@ == 3 
else_jump @NONE_11193 
226@ = -1 

:NONE_11193
jump @NONE_11207 

:NONE_11200
223@ = 0 

:NONE_11207
227@ = 0 

:NONE_11214
290@(227@,60f) += 8.0 
02F7: " + tempvar_Float_1 + @" = cosine 230@(227@,60f) 
02F6: " + tempvar_Float_2 + @" = sine 230@(227@,60f) 
006D: " + tempvar_Float_1 + @" *= 290@(227@,60f) 
006D: " + tempvar_Float_2 + @" *= 290@(227@,60f) 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 1.0 1.0 RGBA 255 255 255 255 
if or
  " + tempvar_Float_1 + @" > 640.0 
  0.0 > " + tempvar_Float_1 + @" 
  0.0 > " + tempvar_Float_2 + @" 
  " + tempvar_Float_2 + @" > 448.0 
else_jump @NONE_11410 
290@(227@,60f) = 10.0 
0208: 230@(227@,60f) = random_float_in_ranges 0.0 360.0 

:NONE_11410
227@ += 1 
  227@ >= 60 
else_jump @NONE_11214 
gosub @NONE_12369 
0349: set_text_draw_font 1 
033E: set_draw_text_position 214@ 215@ GXT 'SPAC_06'  
0087: 692@ = 216@ 
0087: 693@ = 217@ 
227@ = 0 

:NONE_11482
if 
  10 > 227@ 
else_jump @NONE_12101 
0087: 692@ = 216@ 
gosub @NONE_12369 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0349: set_text_draw_font 1 
if 
003B:   226@ == 227@ 
else_jump @NONE_11558 
0340: set_text_draw_RGBA 0 155 0 255 

:NONE_11558
if or
05AD:   " + tmp_5365 + @"(227@,10s) == 142@s 
05AD:   " + tmp_5365 + @"(227@,10s) == 176@s 
else_jump @NONE_11603 
692@ += 8.0 

:NONE_11603
033E: set_draw_text_position 692@ 693@ GXT " + tmp_5365 + @"(227@,10s) 
if or
05AD:   " + tmp_5365 + @"(227@,10s) == 142@s 
05AD:   " + tmp_5365 + @"(227@,10s) == 176@s 
else_jump @NONE_11663 
692@ -= 8.0 

:NONE_11663
005B: 692@ += 218@ 
gosub @NONE_12369 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0349: set_text_draw_font 1 
if 
003B:   226@ == 227@ 
else_jump @NONE_11721 
0340: set_text_draw_RGBA 0 155 0 255 

:NONE_11721
if or
05AD:   " + tmp_5385 + @"(227@,10s) == 142@s 
05AD:   " + tmp_5385 + @"(227@,10s) == 176@s 
else_jump @NONE_11766 
692@ += 8.0 

:NONE_11766
033E: set_draw_text_position 692@ 693@ GXT " + tmp_5385 + @"(227@,10s) 
if or
05AD:   " + tmp_5385 + @"(227@,10s) == 142@s 
05AD:   " + tmp_5385 + @"(227@,10s) == 176@s 
else_jump @NONE_11826 
692@ -= 8.0 

:NONE_11826
005B: 692@ += 218@ 
gosub @NONE_12369 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0349: set_text_draw_font 1 
if 
003B:   226@ == 227@ 
else_jump @NONE_11884 
0340: set_text_draw_RGBA 0 155 0 255 

:NONE_11884
if or
05AD:   " + tmp_5405 + @"(227@,10s) == 142@s 
05AD:   " + tmp_5405 + @"(227@,10s) == 176@s 
else_jump @NONE_11929 
692@ += 8.0 

:NONE_11929
033E: set_draw_text_position 692@ 693@ GXT " + tmp_5405 + @"(227@,10s) 
if or
05AD:   " + tmp_5405 + @"(227@,10s) == 142@s 
05AD:   " + tmp_5405 + @"(227@,10s) == 176@s 
else_jump @NONE_11989 
692@ -= 8.0 

:NONE_11989
0087: 692@ = 216@ 
005B: 692@ += 219@ 
gosub @NONE_12369 
0342: set_text_draw_centered 0 
03E4: set_text_draw_align_right 1 
0349: set_text_draw_font 1 
if 
003B:   226@ == 227@ 
else_jump @NONE_12055 
0340: set_text_draw_RGBA 0 155 0 255 

:NONE_12055
045A: draw_text_1number 692@ 693@ GXT 'NUMBER' number " + tmp_5355 + @"(227@,10i)  
005B: 693@ += 220@ 
227@ += 1 
jump @NONE_11482 

:NONE_12101
038D: draw_texture 2 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 2 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
  226@ == -1 
else_jump @NONE_12362 
if or
00E1:   player 0 pressed_key 15 
00E1:   player 0 pressed_key 14 
00E1:   player 0 pressed_key 17 
else_jump @NONE_12299 
jump @NONE_2544 

:NONE_12299
if 
00E1:   player 0 pressed_key 16 
else_jump @NONE_12355 
if 
  223@ == 0 
else_jump @NONE_12348 
223@ += 1 
jump @NONE_2544 

:NONE_12348
jump @NONE_12362 

:NONE_12355
223@ = 0 

:NONE_12362
jump @NONE_10411 

:NONE_12369
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 1.0 3.0 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
060D: draw_text_shadow 0 rgba 0 0 0 180 
0349: set_text_draw_font 2 
return 

:NONE_12441
097A: play_audio_at 0.0 0.0 0.0 event 1182 
03D5: remove_text 'BUSY'  
09F5: disable_player_mutal_activities 0 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}