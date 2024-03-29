﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class DUAL : MissionCustom {

            Int tmp_5426 = global( _5426.startIndex ),
                tmp_5446 = global( _5446.startIndex ),
                tmp_5466 = global( _5466.startIndex ),
                tmp_5486 = global( _5486.startIndex ),
                tmp_5436 = global( _5436.startIndex ),
                tmp_5506 = global( _5506.startIndex ),
                tmp_5526 = global( _5526.startIndex ),
                tmp_5546 = global( _5546.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @DUAL_16 
gosub @DUAL_15587 
end_thread 

:DUAL_16
" + OnMission + @" = 1 
wait 0 
054C: use_GXT_table 'DUAL' 
03F0: enable_text_draw 1 
0391: release_textures 
0390: load_txd_dictionary 'LD_SPAC' 
09F5: disable_player_mutal_activities 1 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 0 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 50.0 
038F: load_texture ""BACKGND"" as 1 
038F: load_texture ""LAYER"" as 2 
038F: load_texture ""TVCORN"" as 3 
038F: load_texture ""ROCKSHP"" as 4 
038F: load_texture ""THRUSTG"" as 5 
038F: load_texture ""DARK"" as 7 
038F: load_texture ""LIGHT"" as 8 
038F: load_texture ""EX1"" as 9 
038F: load_texture ""EX2"" as 10 
038F: load_texture ""EX3"" as 11 
038F: load_texture ""EX4"" as 12 
038F: load_texture ""WHITE"" as 13 
038F: load_texture ""SHOOT"" as 14 
038F: load_texture ""HEALTH"" as 15 
038F: load_texture ""POWER"" as 16 
038F: load_texture ""DUALITY"" as 17 
038F: load_texture ""BLACK"" as 18 
03CF: load_wav 1807 as 4 

:DUAL_297
if 
83D0:   not wav 4 loaded 
else_jump @DUAL_323 
wait 0 
jump @DUAL_297 

:DUAL_323
097A: play_audio_at 0.0 0.0 0.0 event 1068 
0209: 51@ = random_int_in_ranges 0 3 
0871: init_jump_table 51@ total_jumps 3 default_jump 0 @DUAL_1516 jumps 0 @DUAL_415 1 @DUAL_782 2 @DUAL_1149 -1 @DUAL_1516 -1 @DUAL_1516 -1 @DUAL_1516 -1 @DUAL_1516 

:DUAL_415
52@ = 160.0 
64@ = 224.0 
76@ = 320.0 
88@ = 500.0 
53@ = 480.0 
65@ = 224.0 
77@ = 320.0 
89@ = 500.0 
54@ = 320.0 
66@ = 156.0 
78@ = 256.0 
90@ = 128.0 
55@ = 452.2068 
67@ = 90.0 
79@ = 32.0 
91@ = 32.0 
56@ = 166.5889 
68@ = 216.6436 
80@ = 32.0 
92@ = 32.0 
57@ = 262.0 
69@ = 300.0 
81@ = 1.0 
93@ = 3.0 
58@ = 370.0 
82@ = 0.9 
94@ = 3.0 
71@ = 342.0 
83@ = 320.0 
95@ = 229.7492 
60@ = 284.4967 
72@ = 314.9901 
84@ = 320.0 
96@ = 320.0 
61@ = 351.9814 
73@ = 356.8015 
jump @DUAL_1516 

:DUAL_782
52@ = 160.0 
64@ = 224.0 
76@ = 320.0 
88@ = 500.0 
53@ = 480.0 
65@ = 224.0 
77@ = 320.0 
89@ = 500.0 
54@ = 320.0 
66@ = 219.561 
78@ = 256.0 
90@ = 128.0 
55@ = 452.2068 
67@ = 215.0997 
79@ = 32.0 
91@ = 32.0 
56@ = 166.5889 
68@ = 216.0905 
80@ = 32.0 
92@ = 32.0 
57@ = 265.0504 
69@ = 70.0389 
81@ = 1.0 
93@ = 3.0 
58@ = 370.0 
82@ = 0.9 
94@ = 3.0 
71@ = 342.0 
83@ = 320.0 
95@ = 91.233 
60@ = 284.4967 
72@ = 84.2511 
84@ = 320.0 
96@ = 296.2502 
61@ = 351.9814 
73@ = 356.8015 
jump @DUAL_1516 

:DUAL_1149
52@ = 160.0 
64@ = 224.0 
76@ = 320.0 
88@ = 500.0 
53@ = 480.0 
65@ = 224.0 
77@ = 320.0 
89@ = 500.0 
54@ = 320.0 
66@ = 296.0475 
78@ = 256.0 
90@ = 128.0 
55@ = 464.383 
67@ = 354.7318 
79@ = 32.0 
91@ = 32.0 
56@ = 166.5889 
68@ = 216.0905 
80@ = 32.0 
92@ = 32.0 
57@ = 265.0504 
69@ = 70.0389 
81@ = 1.0 
93@ = 3.0 
58@ = 370.0 
82@ = 0.9 
94@ = 3.0 
71@ = 119.7153 
83@ = 320.0 
95@ = 135.5804 
60@ = 284.4967 
72@ = 84.2511 
84@ = 320.0 
96@ = 320.0 
61@ = 351.9814 
73@ = 134.4938 
jump @DUAL_1516 

:DUAL_1516
62@ = 33.8609 
74@ = 18.1114 
86@ = 230.0 
98@ = 60.3475 
63@ = 38.1753 
75@ = 20.4681 
87@ = 0.5014 
99@ = 1.8889 
100@ = 0 
101@ = 1 
102@ = 1 
103@ = 1 
104@ = 1 
105@ = 1 
05AA: 106@s = 'DUAL_0' 
05AA: 108@s = 'DUAL_1' 
05AA: 110@s = 'DUAL_2' 
05AA: 112@s = 'DUAL_3' 
05AA: 114@s = 'DUAL_4' 
05AA: 116@s = 'DUAL_5' 
05AA: 118@s = 'DUAL_6' 
05AA: 120@s = 'DUAL_7' 
05AA: 122@s = 'DUAL_8' 
05AA: 124@s = 'DUAL_9' 
05AA: 126@s = 'DUAL_AA' 
05AA: 128@s = 'DUAL_B' 
05AA: 130@s = 'DUAL_C' 
05AA: 132@s = 'DUAL_D' 
05AA: 134@s = 'DUAL_E' 
05AA: 136@s = 'DUAL_F' 
05AA: 138@s = 'DUAL_G' 
05AA: 140@s = 'DUAL_H' 
05AA: 142@s = 'DUAL_I' 
05AA: 144@s = 'DUAL_J' 
05AA: 146@s = 'DUAL_K' 
05AA: 148@s = 'DUAL_L' 
05AA: 150@s = 'DUAL_M' 
05AA: 152@s = 'DUAL_N' 
05AA: 154@s = 'DUAL_O' 
05AA: 156@s = 'DUAL_P' 
05AA: 158@s = 'DUAL_Q' 
05AA: 160@s = 'DUAL_R' 
05AA: 162@s = 'DUAL_S' 
05AA: 164@s = 'DUAL_T' 
05AA: 166@s = 'DUAL_U' 
05AA: 168@s = 'DUAL_V' 
05AA: 170@s = 'DUAL_W' 
05AA: 172@s = 'DUAL_X' 
05AA: 174@s = 'DUAL_Y' 
05AA: 176@s = 'DUAL_Z' 
05AA: 178@s = 'DUAL_FS' 
if 
  " + _5425 + @" == 0 
else_jump @DUAL_2819 
" + tmp_5426 + @"[0] = -10000 
" + tmp_5426 + @"[1] = -7500 
" + tmp_5426 + @"[2] = -5000 
" + tmp_5426 + @"[3] = -2500 
" + tmp_5426 + @"[4] = -1000 
" + tmp_5426 + @"[5] = -750 
" + tmp_5426 + @"[6] = -500 
" + tmp_5426 + @"[7] = -250 
" + tmp_5426 + @"[8] = -175 
" + tmp_5426 + @"[9] = -100 
" + tmp_5436 + @"[0] = 10000 
" + tmp_5436 + @"[1] = 7500 
" + tmp_5436 + @"[2] = 5000 
" + tmp_5436 + @"[3] = 2500 
" + tmp_5436 + @"[4] = 1000 
" + tmp_5436 + @"[5] = 750 
" + tmp_5436 + @"[6] = 500 
" + tmp_5436 + @"[7] = 250 
" + tmp_5436 + @"[8] = 175 
" + tmp_5436 + @"[9] = 100 
05A9: s" + tmp_5446 + @"[0] = 132@s 
05A9: s" + tmp_5466 + @"[0] = 144@s 
05A9: s" + tmp_5486 + @"[0] = 178@s 
05A9: s" + tmp_5446 + @"[1] = 146@s 
05A9: s" + tmp_5466 + @"[1] = 160@s 
05A9: s" + tmp_5486 + @"[1] = 174@s 
05A9: s" + tmp_5446 + @"[2] = 162@s 
05A9: s" + tmp_5466 + @"[2] = 142@s 
05A9: s" + tmp_5486 + @"[2] = 162@s 
05A9: s" + tmp_5446 + @"[3] = 170@s 
05A9: s" + tmp_5466 + @"[3] = 132@s 
05A9: s" + tmp_5486 + @"[3] = 174@s 
05A9: s" + tmp_5446 + @"[4] = 132@s 
05A9: s" + tmp_5466 + @"[4] = 126@s 
05A9: s" + tmp_5486 + @"[4] = 152@s 
05A9: s" + tmp_5446 + @"[5] = 148@s 
05A9: s" + tmp_5466 + @"[5] = 160@s 
05A9: s" + tmp_5486 + @"[5] = 138@s 
05A9: s" + tmp_5446 + @"[6] = 152@s 
05A9: s" + tmp_5466 + @"[6] = 154@s 
05A9: s" + tmp_5486 + @"[6] = 152@s 
05A9: s" + tmp_5446 + @"[7] = 138@s 
05A9: s" + tmp_5466 + @"[7] = 126@s 
05A9: s" + tmp_5486 + @"[7] = 176@s 
05A9: s" + tmp_5446 + @"[8] = 108@s 
05A9: s" + tmp_5466 + @"[8] = 106@s 
05A9: s" + tmp_5486 + @"[8] = 108@s 
05A9: s" + tmp_5446 + @"[9] = 144@s 
05A9: s" + tmp_5466 + @"[9] = 166@s 
05A9: s" + tmp_5486 + @"[9] = 132@s 
05A9: s" + tmp_5506 + @"[0] = 126@s 
05A9: s" + tmp_5526 + @"[0] = 132@s 
05A9: s" + tmp_5546 + @"[0] = 176@s 
05A9: s" + tmp_5506 + @"[1] = 130@s 
05A9: s" + tmp_5526 + @"[1] = 126@s 
05A9: s" + tmp_5546 + @"[1] = 152@s 
05A9: s" + tmp_5506 + @"[2] = 142@s 
05A9: s" + tmp_5526 + @"[2] = 150@s 
05A9: s" + tmp_5546 + @"[2] = 174@s 
05A9: s" + tmp_5506 + @"[3] = 170@s 
05A9: s" + tmp_5526 + @"[3] = 142@s 
05A9: s" + tmp_5546 + @"[3] = 148@s 
05A9: s" + tmp_5506 + @"[4] = 132@s 
05A9: s" + tmp_5526 + @"[4] = 128@s 
05A9: s" + tmp_5546 + @"[4] = 156@s 
05A9: s" + tmp_5506 + @"[5] = 132@s 
05A9: s" + tmp_5526 + @"[5] = 126@s 
05A9: s" + tmp_5546 + @"[5] = 168@s 
05A9: s" + tmp_5506 + @"[6] = 132@s 
05A9: s" + tmp_5526 + @"[6] = 154@s 
05A9: s" + tmp_5546 + @"[6] = 132@s 
05A9: s" + tmp_5506 + @"[7] = 152@s 
05A9: s" + tmp_5526 + @"[7] = 136@s 
05A9: s" + tmp_5546 + @"[7] = 178@s 
05A9: s" + tmp_5506 + @"[8] = 146@s 
05A9: s" + tmp_5526 + @"[8] = 150@s 
05A9: s" + tmp_5546 + @"[8] = 128@s 
05A9: s" + tmp_5506 + @"[9] = 162@s 
05A9: s" + tmp_5526 + @"[9] = 144@s 
05A9: s" + tmp_5546 + @"[9] = 148@s 
" + _5425 + @" = 1 

:DUAL_2819
180@ = -1 
181@ = 0 
182@ = 321.4137 
183@ = 58.2432 
184@ = 201.225 
185@ = 88.9168 
186@ = 29.78 
187@ = 230.5296 
188@ = 28.5713 

:DUAL_2903
wait 0 
fade 1 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
300@ = 0 
0494: get_joystick 0 direction_offset_to 311@ 312@ 39@ 39@ 
if or
00E1:   player 0 pressed_key 11 
  311@ > 100 
else_jump @DUAL_3094 
if 
  103@ == 0 
else_jump @DUAL_3080 
if 
  100@ == 0 
else_jump @DUAL_3035 
100@ = 1 
097A: play_audio_at 0.0 0.0 0.0 event 1046 
jump @DUAL_3080 

:DUAL_3035
if 
  100@ == 2 
else_jump @DUAL_3080 
100@ = 3 
097A: play_audio_at 0.0 0.0 0.0 event 1046 

:DUAL_3080
103@ = 1 
jump @DUAL_3581 

:DUAL_3094
if or
00E1:   player 0 pressed_key 10 
  -100 > 311@ 
else_jump @DUAL_3247 
if 
  103@ == 0 
else_jump @DUAL_3233 
if 
  100@ == 1 
else_jump @DUAL_3188 
100@ = 0 
097A: play_audio_at 0.0 0.0 0.0 event 1046 
jump @DUAL_3233 

:DUAL_3188
if 
  100@ == 3 
else_jump @DUAL_3233 
100@ = 2 
097A: play_audio_at 0.0 0.0 0.0 event 1046 

:DUAL_3233
102@ = 1 
jump @DUAL_3574 

:DUAL_3247
if or
00E1:   player 0 pressed_key 8 
  -100 > 312@ 
else_jump @DUAL_3400 
if 
  104@ == 0 
else_jump @DUAL_3386 
if 
  100@ == 2 
else_jump @DUAL_3341 
100@ = 0 
097A: play_audio_at 0.0 0.0 0.0 event 1046 
jump @DUAL_3386 

:DUAL_3341
if 
  100@ == 3 
else_jump @DUAL_3386 
100@ = 1 
097A: play_audio_at 0.0 0.0 0.0 event 1046 

:DUAL_3386
104@ = 1 
jump @DUAL_3567 

:DUAL_3400
if or
00E1:   player 0 pressed_key 9 
  312@ > 100 
else_jump @DUAL_3553 
if 
  105@ == 0 
else_jump @DUAL_3539 
if 
  100@ == 0 
else_jump @DUAL_3494 
100@ = 2 
097A: play_audio_at 0.0 0.0 0.0 event 1046 
jump @DUAL_3539 

:DUAL_3494
if 
  100@ == 1 
else_jump @DUAL_3539 
100@ = 3 
097A: play_audio_at 0.0 0.0 0.0 event 1046 

:DUAL_3539
105@ = 1 
jump @DUAL_3560 

:DUAL_3553
105@ = 0 

:DUAL_3560
104@ = 0 

:DUAL_3567
102@ = 0 

:DUAL_3574
103@ = 0 

:DUAL_3581
038D: draw_texture 18 position 52@ 64@ size 76@ 88@ RGBA 255 255 255 255 
038D: draw_texture 13 position 53@ 65@ size 77@ 89@ RGBA 255 255 255 255 
038D: draw_texture 17 position 54@ 66@ size 256.0 128.0 RGBA 255 255 255 255 
038D: draw_texture 7 position 55@ 67@ size 32.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 8 position 56@ 68@ size 32.0 32.0 RGBA 255 255 255 255 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 4 
else_jump @DUAL_3795 
033F: set_text_draw_letter_size 82@ 94@ 
jump @DUAL_3803 

:DUAL_3795
033F: set_text_draw_letter_size 81@ 93@ 

:DUAL_3803
033E: set_draw_text_position 57@ 69@ GXT 'SPAC_04'  
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0340: set_text_draw_RGBA 0 0 0 255 
if 
04A3:   " + Current_Language + @" == 4 
else_jump @DUAL_3879 
033F: set_text_draw_letter_size 82@ 94@ 
jump @DUAL_3887 

:DUAL_3879
033F: set_text_draw_letter_size 81@ 93@ 

:DUAL_3887
033E: set_draw_text_position 58@ 69@ GXT 'SPAC_05'  
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
if 
04A3:   " + Current_Language + @" == 4 
else_jump @DUAL_3966 
033F: set_text_draw_letter_size 82@ 94@ 
jump @DUAL_3974 

:DUAL_3966
033F: set_text_draw_letter_size 81@ 93@ 

:DUAL_3974
033E: set_draw_text_position 57@ 71@ GXT 'SPAC_06'  
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0340: set_text_draw_RGBA 0 0 0 255 
if 
04A3:   " + Current_Language + @" == 4 
else_jump @DUAL_4050 
033F: set_text_draw_letter_size 82@ 94@ 
jump @DUAL_4058 

:DUAL_4050
033F: set_text_draw_letter_size 81@ 93@ 

:DUAL_4058
033E: set_draw_text_position 58@ 71@ GXT 'SPAC_06'  
if 
  100@ == 0 
else_jump @DUAL_4125 
038D: draw_texture 8 position 60@ 72@ size 16.0 16.0 RGBA 255 255 255 255 

:DUAL_4125
if 
  100@ == 1 
else_jump @DUAL_4175 
038D: draw_texture 7 position 61@ 72@ size 16.0 16.0 RGBA 255 255 255 255 

:DUAL_4175
if 
  100@ == 2 
else_jump @DUAL_4225 
038D: draw_texture 8 position 60@ 73@ size 16.0 16.0 RGBA 255 255 255 255 

:DUAL_4225
if 
  100@ == 3 
else_jump @DUAL_4275 
038D: draw_texture 7 position 61@ 73@ size 16.0 16.0 RGBA 255 255 255 255 

:DUAL_4275
038D: draw_texture 3 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @DUAL_4755 
if 
  101@ == 0 
else_jump @DUAL_4748 
101@ += 1 
097A: play_audio_at 0.0 0.0 0.0 event 1045 
if 
  100@ == 0 
else_jump @DUAL_4506 
jump @DUAL_4839 

:DUAL_4506
if 
  100@ == 1 
else_jump @DUAL_4552 
0391: release_textures 
Player.CanMove(" + PlayerChar + @") = True
fade 0 0 
wait 0 
fade 1 500 
return 

:DUAL_4552
if 
  100@ == 2 
else_jump @DUAL_4650 
0208: 50@ = random_float_in_ranges -15.0 15.0 
0087: 205@ = 50@ 
0208: 50@ = random_float_in_ranges -15.0 15.0 
0087: 206@ = 50@ 
199@ = 0.0 
200@ = 0.0 
181@ = 1 
jump @DUAL_11763 

:DUAL_4650
if 
  100@ == 3 
else_jump @DUAL_4748 
0208: 50@ = random_float_in_ranges -15.0 15.0 
0087: 205@ = 50@ 
0208: 50@ = random_float_in_ranges -15.0 15.0 
0087: 206@ = 50@ 
199@ = 0.0 
200@ = 0.0 
181@ = 0 
jump @DUAL_11763 

:DUAL_4748
jump @DUAL_4762 

:DUAL_4755
101@ = 0 

:DUAL_4762
0937: text_draw_box_cornerA 62@ 74@ cornerB 86@ 98@ GXT_reference 'DUMMY' style 0 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 86@ 
0349: set_text_draw_font 1 
033F: set_text_draw_letter_size 87@ 99@ 
033E: set_draw_text_position 63@ 75@ GXT 'SPAC_10'  
jump @DUAL_2903 

:DUAL_4839
189@ = 0.0 
193@ = 0.0 
190@ = 0.0 
194@ = 0.0 
199@ = 0.0 
200@ = 0.0 
" + _5566 + @" = 0.0 
" + _5567 + @" = 0.0 
201@ = 0.0 
202@ = 0.0 
203@ = 0.1 
204@ = 100.0 
205@ = 0.0 
206@ = 0.0 
207@ = 0 
208@ = -512.0 
209@ = -256.0 
210@ = 0.0 
211@ = 256.0 
212@ = 512.0 
213@ = -384.0 
214@ = -128.0 
215@ = 128.0 
216@ = 384.0 
217@ = 200.0 
227@ = 200.0 
237@ = -2E11 
218@ = -300.0 
228@ = -300.0 
238@ = -2E11 
219@ = -300.0 
229@ = 300.0 
239@ = -2E11 
220@ = 300.0 
230@ = -300.0 
240@ = -2E11 
221@ = 0.1 
231@ = 300.0 
241@ = -2E11 
222@ = 0.1 
232@ = -300.0 
242@ = 2E11 
223@ = 300.0 
233@ = 0.1 
243@ = 2E11 
224@ = -300.0 
234@ = 0.1 
244@ = 2E11 
225@ = 0.1 
235@ = 500.0 
245@ = 2E11 
226@ = 0.1 
236@ = -500.0 
246@ = 2E11 
247@ = 10 
248@ = 32.0 
249@ = 6.67259 
249@ *= 0.1 
249@ *= 0.1 
249@ *= 0.1 
249@ *= 0.1 
249@ *= 0.1 
249@ *= 0.1 
40@ = 0 

:DUAL_5470
if 
  20 > 40@ 
else_jump @DUAL_5530 
250@(40@,20f) = 1000.0 
270@(40@,20f) = 1000.0 
40@ += 1 
jump @DUAL_5470 

:DUAL_5530
40@ = 0 

:DUAL_5537
if 
  10 > 40@ 
else_jump @DUAL_5580 
290@(40@,10i) = 0 
40@ += 1 
jump @DUAL_5537 

:DUAL_5580
300@ = 0 
Player.CanMove(" + PlayerChar + @") = False
301@ = 100.0 
302@ = 100.0 
303@ = 256.0 
304@ = 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 305@ = " + Current_Time_in_ms2 + @" 
305@ += 4000 
008B: 306@ = " + Current_Time_in_ms2 + @" 
307@ = 0 

:DUAL_5667
008B: 308@ = " + Current_Time_in_ms2 + @" 
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 309@ = " + Current_Time_in_ms2 + @" 
0062: 309@ -= 308@ 
0093: 310@ = integer 309@ to_float 
310@ /= 1.5 
310@ /= 1000.0 
201@ = 0.0 
202@ = 0.0 
0079: 301@ += frame_delta_time * 0.06 
if 
  301@ > 100.0 
else_jump @DUAL_5789 
301@ = 100.0 

:DUAL_5789
if 
00E1:   player 0 pressed_key 15 
else_jump @DUAL_5845 
if 
  307@ == 1 
else_jump @DUAL_5838 
307@ = 0 
304@ = 1 

:DUAL_5838
jump @DUAL_5852 

:DUAL_5845
307@ = 1 

:DUAL_5852
if 
00E1:   player 0 pressed_key 11 
else_jump @DUAL_5886 
0079: 203@ += frame_delta_time * 5.0 
jump @DUAL_5970 

:DUAL_5886
if 
00E1:   player 0 pressed_key 10 
else_jump @DUAL_5920 
0079: 203@ += frame_delta_time * -5.0 
jump @DUAL_5970 

:DUAL_5920
0494: get_joystick 0 direction_offset_to 311@ 312@ 39@ 39@ 
0093: 50@ = integer 311@ to_float 
50@ /= 15.0 
007B: 203@ += frame_delta_time * 50@ 
0656: get_angle 203@ absolute_degrees_to 203@ 

:DUAL_5970
40@ = 0 

:DUAL_5977
if 
001D:   247@ > 40@ 
else_jump @DUAL_7304 
0509: " + Distance_Between_Points + @" = distance_between_XY 199@ 200@ and_XY 217@(40@,10f) 227@(40@,10f) 
313@ = 0 
if 
  " + Distance_Between_Points + @" > 700.0 
else_jump @DUAL_6056 
313@ = 1 

:DUAL_6056
if 
  100.0 > " + Distance_Between_Points + @" 
else_jump @DUAL_6403 
if 
05A5:   is_area_center 199@ 200@ scale 32.0 32.0 overlaping_area_center 217@(40@,10f) 227@(40@,10f) scale 32.0 32.0 
else_jump @DUAL_6403 
if 
  237@(40@,10f) > 0.0 
else_jump @DUAL_6342 
097A: play_audio_at 0.0 0.0 0.0 event 1050 
007F: 302@ -= frame_delta_time * 1.0 
if 
  0.0 > 302@ 
else_jump @DUAL_6335 
302@ = 0.0 
41@ = 0 

:DUAL_6223
if 
  10 > 41@ 
else_jump @DUAL_6319 
if 
  290@(41@,10i) == 0 
else_jump @DUAL_6305 
0087: 324@(41@,10f) = 199@ 
0087: 334@(41@,10f) = 200@ 
290@(41@,10i) += 1 
41@ = 9 

:DUAL_6305
41@ += 1 
jump @DUAL_6223 

:DUAL_6319
008B: 306@ = " + Current_Time_in_ms2 + @" 
306@ += 3000 

:DUAL_6335
jump @DUAL_6403 

:DUAL_6342
097A: play_audio_at 0.0 0.0 0.0 event 1051 
0079: 302@ += frame_delta_time * 1.0 
if 
  302@ > 100.0 
else_jump @DUAL_6403 
302@ = 100.0 

:DUAL_6403
41@ = 0 

:DUAL_6410
if 
  10 > 41@ 
else_jump @DUAL_6605 
if 
001F:   314@(41@,10i) > " + Current_Time_in_ms2 + @" 
else_jump @DUAL_6591 
if 
05A5:   is_area_center 439@(41@,10f) 449@(41@,10f) scale 12.0 12.0 overlaping_area_center 217@(40@,10f) 227@(40@,10f) scale 32.0 32.0 
else_jump @DUAL_6591 
313@ = 2 
if 
001E:   " + Current_Time_in_ms2 + @" > 306@ 
else_jump @DUAL_6584 
if 
  237@(40@,10f) > 0.0 
else_jump @DUAL_6577 
300@ += 10 
jump @DUAL_6584 

:DUAL_6577
300@ -= 10 

:DUAL_6584
41@ = 9 

:DUAL_6591
41@ += 1 
jump @DUAL_6410 

:DUAL_6605
if 
  313@ > 0 
else_jump @DUAL_7000 
if 
  313@ == 2 
else_jump @DUAL_6752 
41@ = 0 

:DUAL_6648
if 
  10 > 41@ 
else_jump @DUAL_6752 
if 
  290@(41@,10i) == 0 
else_jump @DUAL_6738 
0087: 324@(41@,10f) = 217@(40@,10f) 
0087: 334@(41@,10f) = 227@(40@,10f) 
290@(41@,10i) += 1 
41@ = 9 

:DUAL_6738
41@ += 1 
jump @DUAL_6648 

:DUAL_6752
0209: 39@ = random_int_in_ranges 0 2 
if 
  39@ == 0 
else_jump @DUAL_6853 
0208: " + tempvar_Float_1 + @" = random_float_in_ranges 340.0 700.0 
0209: 39@ = random_int_in_ranges 0 2 
if 
  39@ == 0 
else_jump @DUAL_6831 
" + tempvar_Float_1 + @" *= -1.0 

:DUAL_6831
0208: " + tempvar_Float_2 + @" = random_float_in_ranges -700.0 700.0 
jump @DUAL_6920 

:DUAL_6853
0208: " + tempvar_Float_1 + @" = random_float_in_ranges -700.0 700.0 
0208: " + tempvar_Float_2 + @" = random_float_in_ranges 340.0 700.0 
0209: 39@ = random_int_in_ranges 0 2 
if 
  39@ == 0 
else_jump @DUAL_6920 
" + tempvar_Float_2 + @" *= -1.0 

:DUAL_6920
0087: 217@(40@,10f) = 199@ 
005D: 217@(40@,10f) += " + tempvar_Float_1 + @" 
0087: 227@(40@,10f) = 200@ 
005D: 227@(40@,10f) += " + tempvar_Float_2 + @" 
0509: " + Distance_Between_Points + @" = distance_between_XY 199@ 200@ and_XY 217@(40@,10f) 227@(40@,10f) 
jump @DUAL_7290 

:DUAL_7000
0087: 50@ = 237@(40@,10f) 
006B: 50@ *= 204@ 
006B: 50@ *= 249@ 
0086: " + tempvar_Float_3 + @" = " + Distance_Between_Points + @" 
0069: " + tempvar_Float_3 + @" *= " + Distance_Between_Points + @" 
0077: 50@ /= " + tempvar_Float_3 + @" 
0087: 344@ = 217@(40@,10f) 
0063: 344@ -= 199@ 
0087: 345@ = 227@(40@,10f) 
0063: 345@ -= 200@ 
0077: 344@ /= " + Distance_Between_Points + @" 
0077: 345@ /= " + Distance_Between_Points + @" 
0087: 43@ = 344@ 
006B: 43@ *= 50@ 
0087: 44@ = 345@ 
006B: 44@ *= 50@ 
248@ = 32.0 
if 
  43@ > 50000.0 
else_jump @DUAL_7181 
43@ = 50000.0 

:DUAL_7181
if 
  -50000.0 > 43@ 
else_jump @DUAL_7212 
43@ = -50000.0 

:DUAL_7212
if 
  44@ > 50000.0 
else_jump @DUAL_7243 
44@ = 50000.0 

:DUAL_7243
if 
  -50000.0 > 44@ 
else_jump @DUAL_7274 
44@ = -50000.0 

:DUAL_7274
005B: 201@ += 43@ 
005B: 202@ += 44@ 

:DUAL_7290
40@ += 1 
jump @DUAL_5977 

:DUAL_7304
if 
001E:   " + Current_Time_in_ms2 + @" > 306@ 
else_jump @DUAL_8043 
if 
00E1:   player 0 pressed_key 16 
else_jump @DUAL_7494 
if or
  301@ > 0.2 
  301@ == 0.2 
else_jump @DUAL_7487 
02F6: " + tempvar_Float_1 + @" = sine 203@ 
02F7: " + tempvar_Float_2 + @" = cosine 203@ 
" + tempvar_Float_1 + @" *= -20000.0 
" + tempvar_Float_2 + @" *= 20000.0 
005D: 201@ += " + tempvar_Float_1 + @" 
005D: 202@ += " + tempvar_Float_2 + @" 
207@ += 50 
if 
  207@ > 200 
else_jump @DUAL_7457 
207@ = 200 

:DUAL_7457
097A: play_audio_at 0.0 0.0 0.0 event 1042 
007F: 301@ -= frame_delta_time * 0.2 

:DUAL_7487
jump @DUAL_7526 

:DUAL_7494
207@ -= 20 
if 
  0 > 207@ 
else_jump @DUAL_7526 
207@ = 0 

:DUAL_7526
if or
  301@ > 0.1 
  301@ == 0.1 
else_jump @DUAL_7662 
if 
00E1:   player 0 pressed_key 6 
else_jump @DUAL_7662 
0087: 50@ = 203@ 
50@ += 90.0 
0656: get_angle 50@ absolute_degrees_to 50@ 
02F6: " + tempvar_Float_1 + @" = sine 50@ 
02F7: " + tempvar_Float_2 + @" = cosine 50@ 
" + tempvar_Float_1 + @" *= -6000.0 
" + tempvar_Float_2 + @" *= 6000.0 
005D: 201@ += " + tempvar_Float_1 + @" 
005D: 202@ += " + tempvar_Float_2 + @" 
007F: 301@ -= frame_delta_time * 0.1 

:DUAL_7662
if or
  301@ > 0.1 
  301@ == 0.1 
else_jump @DUAL_7798 
if 
00E1:   player 0 pressed_key 4 
else_jump @DUAL_7798 
0087: 50@ = 203@ 
50@ -= 90.0 
0656: get_angle 50@ absolute_degrees_to 50@ 
02F6: " + tempvar_Float_1 + @" = sine 50@ 
02F7: " + tempvar_Float_2 + @" = cosine 50@ 
" + tempvar_Float_1 + @" *= -6000.0 
" + tempvar_Float_2 + @" *= 6000.0 
005D: 201@ += " + tempvar_Float_1 + @" 
005D: 202@ += " + tempvar_Float_2 + @" 
007F: 301@ -= frame_delta_time * 0.1 

:DUAL_7798
0089: 346@ = " + _5566 + @" 
346@ *= 40.0 
0089: 347@ = " + _5567 + @" 
347@ *= 40.0 
0063: 201@ -= 346@ 
0063: 202@ -= 347@ 
0073: 201@ /= 204@ 
0073: 202@ /= 204@ 
006B: 201@ *= 310@ 
006B: 202@ *= 310@ 
005F: " + _5566 + @" += 201@ 
005F: " + _5567 + @" += 202@ 
if or
  301@ > 1.0 
  301@ == 1.0 
else_jump @DUAL_8043 
if 
00E1:   player 0 pressed_key 17 
else_jump @DUAL_8043 
if 
001E:   " + Current_Time_in_ms2 + @" > 348@ 
else_jump @DUAL_8043 
gosub @DUAL_15309 
097A: play_audio_at 0.0 0.0 0.0 event 1041 
008B: 348@ = " + Current_Time_in_ms2 + @" 
348@ += 250 
007F: 301@ -= frame_delta_time * 1.0 
if 
  300@ > 0 
else_jump @DUAL_8043 
300@ -= 1 

:DUAL_8043
0087: 205@ = 199@ 
0087: 206@ = 200@ 
if 
  " + _5566 + @" > 300.0 
else_jump @DUAL_8090 
" + _5566 + @" = 300.0 

:DUAL_8090
if 
  -300.0 > " + _5566 + @" 
else_jump @DUAL_8121 
" + _5566 + @" = -300.0 

:DUAL_8121
if 
  " + _5567 + @" > 300.0 
else_jump @DUAL_8152 
" + _5567 + @" = 300.0 

:DUAL_8152
if 
  -300.0 > " + _5567 + @" 
else_jump @DUAL_8183 
" + _5567 + @" = -300.0 

:DUAL_8183
0088: " + tempvar_Float_1 + @" = 310@ 
0069: " + tempvar_Float_1 + @" *= " + _5566 + @" 
0088: " + tempvar_Float_2 + @" = 310@ 
0069: " + tempvar_Float_2 + @" *= " + _5567 + @" 
005D: 199@ += " + tempvar_Float_1 + @" 
005D: 200@ += " + tempvar_Float_2 + @" 
40@ = 0 

:DUAL_8238
if 
  3 > 40@ 
else_jump @DUAL_9088 
0088: " + tempvar_Float_1 + @" = 205@ 
0067: " + tempvar_Float_1 + @" -= 199@ 
0088: " + tempvar_Float_2 + @" = 206@ 
0067: " + tempvar_Float_2 + @" -= 200@ 
" + tempvar_Float_1 + @" *= 0.6 
" + tempvar_Float_2 + @" *= 0.6 
0093: 50@ = integer 40@ to_float 
50@ += 1.0 
50@ *= 0.3 
006D: " + tempvar_Float_1 + @" *= 50@ 
006D: " + tempvar_Float_2 + @" *= 50@ 
303@ = 512.0 
006B: 303@ *= 50@ 
if 
  40@ == 0 
else_jump @DUAL_8439 
" + tempvar_Float_1 + @" /= 2.0 
" + tempvar_Float_2 + @" /= 2.0 
005D: 189@(40@,4f) += " + tempvar_Float_1 + @" 
005D: 193@(40@,4f) += " + tempvar_Float_2 + @" 
jump @DUAL_8463 

:DUAL_8439
005D: 189@(40@,4f) += " + tempvar_Float_1 + @" 
005D: 193@(40@,4f) += " + tempvar_Float_2 + @" 

:DUAL_8463
0087: 50@ = 303@ 
50@ /= 2.0 
if 
0025:   189@(40@,4f) > 50@ 
else_jump @DUAL_8516 
0063: 189@(40@,4f) -= 303@ 

:DUAL_8516
0087: 50@ = 303@ 
50@ *= -1.0 
if 
0025:   50@ > 189@(40@,4f) 
else_jump @DUAL_8569 
005B: 189@(40@,4f) += 303@ 

:DUAL_8569
0087: 50@ = 303@ 
50@ *= -1.0 
if 
0025:   193@(40@,4f) > 50@ 
else_jump @DUAL_8622 
0063: 193@(40@,4f) -= 303@ 

:DUAL_8622
0087: 50@ = 303@ 
50@ *= -1.0 
if 
0025:   50@ > 193@(40@,4f) 
else_jump @DUAL_8675 
005B: 193@(40@,4f) += 303@ 

:DUAL_8675
50@ = 640.0 
005B: 50@ += 303@ 
0087: 349@ = 50@ 
0073: 349@ /= 303@ 
0092: 350@ = float 349@ to_integer 
0093: 50@ = integer 350@ to_float 
0063: 349@ -= 50@ 
if 
  349@ > 0.0 
else_jump @DUAL_8761 
350@ += 1 

:DUAL_8761
50@ = 448.0 
005B: 50@ += 303@ 
0087: 351@ = 50@ 
0073: 351@ /= 303@ 
0092: 352@ = float 351@ to_integer 
0093: 50@ = integer 352@ to_float 
0063: 351@ -= 50@ 
if 
  351@ > 0.0 
else_jump @DUAL_8847 
352@ += 1 

:DUAL_8847
350@ += 1 
352@ += 1 
0087: 197@ = 189@(40@,4f) 
0087: 198@ = 193@(40@,4f) 
354@ = 0 

:DUAL_8892
if 
001D:   352@ > 354@ 
else_jump @DUAL_9074 
353@ = 0 

:DUAL_8918
if 
001D:   350@ > 353@ 
else_jump @DUAL_9040 
if 
  40@ == 0 
else_jump @DUAL_8990 
038D: draw_texture 1 position 197@ 198@ size 303@ 303@ RGBA 150 150 150 255 
jump @DUAL_9018 

:DUAL_8990
038D: draw_texture 2 position 197@ 198@ size 303@ 303@ RGBA 150 150 150 255 

:DUAL_9018
005B: 197@ += 303@ 
353@ += 1 
jump @DUAL_8918 

:DUAL_9040
0087: 197@ = 189@(40@,4f) 
005B: 198@ += 303@ 
354@ += 1 
jump @DUAL_8892 

:DUAL_9074
40@ += 1 
jump @DUAL_8238 

:DUAL_9088
40@ = 0 

:DUAL_9095
if 
001D:   247@ > 40@ 
else_jump @DUAL_9284 
0088: " + tempvar_Float_1 + @" = 217@(40@,10f) 
0067: " + tempvar_Float_1 + @" -= 199@ 
0088: " + tempvar_Float_2 + @" = 227@(40@,10f) 
0067: " + tempvar_Float_2 + @" -= 200@ 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
if 
  237@(40@,10f) > 0.0 
else_jump @DUAL_9238 
038D: draw_texture 7 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 32.0 32.0 RGBA 150 150 150 255 
jump @DUAL_9270 

:DUAL_9238
038D: draw_texture 8 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 32.0 32.0 RGBA 255 255 255 255 

:DUAL_9270
40@ += 1 
jump @DUAL_9095 

:DUAL_9284
40@ = 0 

:DUAL_9291
if 
  20 > 40@ 
else_jump @DUAL_9986 
0509: " + Distance_Between_Points + @" = distance_between_XY 199@ 200@ and_XY 250@(40@,20f) 270@(40@,20f) 
if or
  " + Distance_Between_Points + @" > 600.0 
05A5:   is_area_center 199@ 200@ scale 32.0 32.0 overlaping_area_center 250@(40@,20f) 270@(40@,20f) scale 18.0 18.0 
else_jump @DUAL_9823 
if 
05A5:   is_area_center 199@ 200@ scale 32.0 32.0 overlaping_area_center 250@(40@,20f) 270@(40@,20f) scale 18.0 18.0 
else_jump @DUAL_9589 
if 
001E:   " + Current_Time_in_ms2 + @" > 306@ 
else_jump @DUAL_9589 
if 
  10 > 40@ 
else_jump @DUAL_9521 
097A: play_audio_at 0.0 0.0 0.0 event 1048 
300@ += 5 
jump @DUAL_9548 

:DUAL_9521
097A: play_audio_at 0.0 0.0 0.0 event 1049 
300@ -= 5 

:DUAL_9548
301@ += 25.0 
if 
  301@ > 100.0 
else_jump @DUAL_9589 
301@ = 100.0 

:DUAL_9589
0209: 39@ = random_int_in_ranges 0 2 
if 
  39@ == 0 
else_jump @DUAL_9699 
0208: " + tempvar_Float_1 + @" = random_float_in_ranges 340.0 700.0 
0209: 39@ = random_int_in_ranges 0 2 
if 
  39@ == 0 
else_jump @DUAL_9668 
" + tempvar_Float_1 + @" *= -1.0 

:DUAL_9668
0208: " + tempvar_Float_2 + @" = random_float_in_ranges -700.0 700.0 
0209: 39@ = random_int_in_ranges 0 2 
jump @DUAL_9775 

:DUAL_9699
0208: " + tempvar_Float_1 + @" = random_float_in_ranges -700.0 700.0 
0209: 39@ = random_int_in_ranges 0 2 
0208: " + tempvar_Float_2 + @" = random_float_in_ranges 340.0 700.0 
0209: 39@ = random_int_in_ranges 0 2 
if 
  39@ == 0 
else_jump @DUAL_9775 
" + tempvar_Float_2 + @" *= -1.0 

:DUAL_9775
0087: 250@(40@,20f) = 199@ 
005D: 250@(40@,20f) += " + tempvar_Float_1 + @" 
0087: 270@(40@,20f) = 200@ 
005D: 270@(40@,20f) += " + tempvar_Float_2 + @" 

:DUAL_9823
0088: " + tempvar_Float_1 + @" = 250@(40@,20f) 
0067: " + tempvar_Float_1 + @" -= 199@ 
0088: " + tempvar_Float_2 + @" = 270@(40@,20f) 
0067: " + tempvar_Float_2 + @" -= 200@ 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
if 
  10 > 40@ 
else_jump @DUAL_9940 
038D: draw_texture 8 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 16.0 16.0 RGBA 255 255 255 255 
jump @DUAL_9972 

:DUAL_9940
038D: draw_texture 7 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 16.0 16.0 RGBA 150 150 150 255 

:DUAL_9972
40@ += 1 
jump @DUAL_9291 

:DUAL_9986
40@ = 0 

:DUAL_9993
if 
  10 > 40@ 
else_jump @DUAL_10296 
if 
  290@(40@,10i) > 0 
else_jump @DUAL_10282 
0088: " + tempvar_Float_1 + @" = 324@(40@,10f) 
0067: " + tempvar_Float_1 + @" -= 199@ 
0088: " + tempvar_Float_2 + @" = 334@(40@,10f) 
0067: " + tempvar_Float_2 + @" -= 200@ 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
if 
  290@(40@,10i) == 1 
else_jump @DUAL_10170 
008B: 355@(40@,10i) = " + Current_Time_in_ms2 + @" 
355@(40@,10i) += 500 
290@(40@,10i) = 9 
097A: play_audio_at 0.0 0.0 0.0 event 1043 

:DUAL_10170
008B: 355@(40@,10i) = " + Current_Time_in_ms2 + @" 
355@(40@,10i) += 500 
290@(40@,10i) += 1 
if 
  290@(40@,10i) > 12 
else_jump @DUAL_10245 
290@(40@,10i) = 0 
jump @DUAL_10282 

:DUAL_10245
038D: draw_texture 290@(40@,10i) position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 32.0 32.0 RGBA 150 150 150 255 

:DUAL_10282
40@ += 1 
jump @DUAL_9993 

:DUAL_10296
40@ = 0 

:DUAL_10303
if 
  10 > 40@ 
else_jump @DUAL_10522 
if 
001F:   314@(40@,10i) > " + Current_Time_in_ms2 + @" 
else_jump @DUAL_10508 
0088: " + tempvar_Float_1 + @" = 310@ 
006D: " + tempvar_Float_1 + @" *= 459@(40@,10f) 
0088: " + tempvar_Float_2 + @" = 310@ 
006D: " + tempvar_Float_2 + @" *= 469@(40@,10f) 
005D: 439@(40@,10f) += " + tempvar_Float_1 + @" 
005D: 449@(40@,10f) += " + tempvar_Float_2 + @" 
0088: " + tempvar_Float_1 + @" = 439@(40@,10f) 
0067: " + tempvar_Float_1 + @" -= 199@ 
0088: " + tempvar_Float_2 + @" = 449@(40@,10f) 
0067: " + tempvar_Float_2 + @" -= 200@ 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
0088: " + tempvar_Angle + @" = 203@ 
038D: draw_texture 14 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 8.0 8.0 RGBA 150 150 150 255 

:DUAL_10508
40@ += 1 
jump @DUAL_10303 

:DUAL_10522
if 
001E:   " + Current_Time_in_ms2 + @" > 306@ 
else_jump @DUAL_10953 
074B: draw_texture 4 position 320.0 224.0 scale 248@ 248@ angle 203@ color_RGBA 150 150 150 255 
0087: 50@ = 302@ 
50@ /= 2.0 
" + tempvar_Float_2 + @" = 400.0 
0067: " + tempvar_Float_2 + @" -= 50@ 
038D: draw_texture 13 position 50.0 350.0 size 14.0 104.0 RGBA 0 0 0 255 
038D: draw_texture 15 position 50.0 " + tempvar_Float_2 + @" size 10.0 302@ RGBA 200 200 200 255 
0087: 50@ = 301@ 
50@ /= 2.0 
" + tempvar_Float_2 + @" = 400.0 
0067: " + tempvar_Float_2 + @" -= 50@ 
038D: draw_texture 13 position 70.0 350.0 size 14.0 104.0 RGBA 0 0 0 255 
038D: draw_texture 16 position 70.0 " + tempvar_Float_2 + @" size 10.0 301@ RGBA 200 200 200 255 
0087: 50@ = 203@ 
50@ += 180.0 
if 
  50@ > 360.0 
else_jump @DUAL_10827 
50@ -= 360.0 

:DUAL_10827
02F6: " + tempvar_Float_1 + @" = sine 50@ 
02F7: " + tempvar_Float_2 + @" = cosine 50@ 
" + tempvar_Float_1 + @" *= -1.0 
" + tempvar_Float_1 + @" *= 24.0 
" + tempvar_Float_2 + @" *= 24.0 
" + tempvar_Float_1 + @" += 320.0 
" + tempvar_Float_2 + @" += 224.0 
if 
  207@ > 0 
else_jump @DUAL_10946 
074B: draw_texture 5 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" scale 16.0 16.0 angle 203@ color_RGBA 207@ 207@ 207@ 255 

:DUAL_10946
jump @DUAL_11146 

:DUAL_10953
41@ = 0 

:DUAL_10960
if 
  10 > 41@ 
else_jump @DUAL_11056 
if 
  290@(41@,10i) == 0 
else_jump @DUAL_11042 
0087: 324@(41@,10f) = 199@ 
0087: 334@(41@,10f) = 200@ 
290@(41@,10i) += 1 
41@ = 9 

:DUAL_11042
41@ += 1 
jump @DUAL_10960 

:DUAL_11056
gosub @DUAL_15515 
097A: play_audio_at 0.0 0.0 0.0 event 1047 
033E: set_draw_text_position 320.0 100.0 GXT 'SPAC_01'  
008B: 39@ = " + Current_Time_in_ms2 + @" 
39@ += 1000 
if 
001D:   39@ > 306@ 
else_jump @DUAL_11146 
304@ = 1 

:DUAL_11146
gosub @DUAL_15515 
if 
  300@ > -1 
else_jump @DUAL_11202 
045A: draw_text_1number 320.0 50.0 GXT 'SPAC_02' number 300@  
jump @DUAL_11268 

:DUAL_11202
0085: 39@ = 300@ 
39@ *= -1 
0340: set_text_draw_RGBA 0 0 0 255 
081C: draw_text_outline 1 RGBA 150 150 150 255 
045A: draw_text_1number 320.0 50.0 GXT 'SPAC_02' number 39@  

:DUAL_11268
038D: draw_texture 3 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
001F:   305@ > " + Current_Time_in_ms2 + @" 
else_jump @DUAL_11623 
gosub @DUAL_15515 
if or
04A3:   " + Current_Language + @" == 2 
04A3:   " + Current_Language + @" == 1 
else_jump @DUAL_11506 
0937: text_draw_box_cornerA 62@ 74@ cornerB 175.1144 94.8235 GXT_reference 'DUMMY' style 0 
0343: set_text_draw_linewidth 175.1144 
jump @DUAL_11542 

:DUAL_11506
0937: text_draw_box_cornerA 62@ 74@ cornerB 160.1144 94.8235 GXT_reference 'DUMMY' style 0 
0343: set_text_draw_linewidth 160.1144 

:DUAL_11542
0342: set_text_draw_centered 0 
0349: set_text_draw_font 1 
if or
04A3:   " + Current_Language + @" == 2 
04A3:   " + Current_Language + @" == 1 
else_jump @DUAL_11594 
033F: set_text_draw_letter_size 0.4 1.8889 
jump @DUAL_11606 

:DUAL_11594
033F: set_text_draw_letter_size 0.5014 1.8889 

:DUAL_11606
033E: set_draw_text_position 63@ 75@ GXT 'SPAC_11'  

:DUAL_11623
if 
  304@ == 1 
else_jump @DUAL_11756 
if 
001F:   300@ > " + tmp_5436 + @"[9] 
else_jump @DUAL_11695 
365@ = 10 
366@ = 0 
181@ = 1 
jump @DUAL_11763 
jump @DUAL_11756 

:DUAL_11695
if 
001E:   " + tmp_5426 + @"[9] > 300@ 
else_jump @DUAL_11749 
365@ = 10 
366@ = 0 
181@ = 0 
jump @DUAL_11763 
jump @DUAL_11756 

:DUAL_11749
jump @DUAL_2903 

:DUAL_11756
jump @DUAL_5667 

:DUAL_11763
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
  181@ == 0 
else_jump @DUAL_12051 
40@ = 9 

:DUAL_11797
if 
  40@ > -1 
else_jump @DUAL_12044 
if 
001E:   " + tmp_5426 + @"(40@,10i) > 300@ 
else_jump @DUAL_12023 
if 
   not 40@ == 9 
else_jump @DUAL_11935 
0085: 41@ = 40@ 
41@ += 1 
0084: " + tmp_5426 + @"(41@,10i) = " + tmp_5426 + @"(40@,10i) 
05A9: " + tmp_5446 + @"(41@,10s) = " + tmp_5446 + @"(40@,10s) 
05A9: " + tmp_5466 + @"(41@,10s) = " + tmp_5466 + @"(40@,10s) 
05A9: " + tmp_5486 + @"(41@,10s) = " + tmp_5486 + @"(40@,10s) 

:DUAL_11935
008A: " + tmp_5426 + @"(40@,10i) = 300@ 
05A9: " + tmp_5446 + @"(40@,10s) = 178@s 
05A9: " + tmp_5466 + @"(40@,10s) = 178@s 
05A9: " + tmp_5486 + @"(40@,10s) = 178@s 
0085: 180@ = 40@ 
if 
  40@ == 0 
else_jump @DUAL_12016 
300@ = 0 

:DUAL_12016
jump @DUAL_12030 

:DUAL_12023
300@ = 0 

:DUAL_12030
40@ -= 1 
jump @DUAL_11797 

:DUAL_12044
jump @DUAL_12305 

:DUAL_12051
40@ = 9 

:DUAL_12058
if 
  40@ > -1 
else_jump @DUAL_12305 
if 
001F:   300@ > " + tmp_5436 + @"(40@,10i) 
else_jump @DUAL_12284 
if 
   not 40@ == 9 
else_jump @DUAL_12196 
0085: 41@ = 40@ 
41@ += 1 
0084: " + tmp_5436 + @"(41@,10i) = " + tmp_5436 + @"(40@,10i) 
05A9: " + tmp_5506 + @"(41@,10s) = " + tmp_5506 + @"(40@,10s) 
05A9: " + tmp_5526 + @"(41@,10s) = " + tmp_5526 + @"(40@,10s) 
05A9: " + tmp_5546 + @"(41@,10s) = " + tmp_5546 + @"(40@,10s) 

:DUAL_12196
008A: " + tmp_5436 + @"(40@,10i) = 300@ 
05A9: " + tmp_5506 + @"(40@,10s) = 178@s 
05A9: " + tmp_5526 + @"(40@,10s) = 178@s 
05A9: " + tmp_5546 + @"(40@,10s) = 178@s 
0085: 180@ = 40@ 
if 
  40@ == 0 
else_jump @DUAL_12277 
300@ = 0 

:DUAL_12277
jump @DUAL_12291 

:DUAL_12284
300@ = 0 

:DUAL_12291
40@ -= 1 
jump @DUAL_12058 

:DUAL_12305
if 
  180@ > -1 
else_jump @DUAL_12970 
if 
  181@ == 0 
else_jump @DUAL_12486 
if 
  366@ == 0 
else_jump @DUAL_12399 
05A9: " + tmp_5446 + @"(180@,10s) = 106@(365@,37s) 
05A9: " + tmp_5466 + @"(180@,10s) = 178@s 
05A9: " + tmp_5486 + @"(180@,10s) = 178@s 

:DUAL_12399
if 
  366@ == 1 
else_jump @DUAL_12445 
05A9: " + tmp_5466 + @"(180@,10s) = 106@(365@,37s) 
05A9: " + tmp_5486 + @"(180@,10s) = 178@s 

:DUAL_12445
if 
  366@ == 2 
else_jump @DUAL_12479 
05A9: " + tmp_5486 + @"(180@,10s) = 106@(365@,37s) 

:DUAL_12479
jump @DUAL_12624 

:DUAL_12486
if 
  366@ == 0 
else_jump @DUAL_12544 
05A9: " + tmp_5506 + @"(180@,10s) = 106@(365@,37s) 
05A9: " + tmp_5526 + @"(180@,10s) = 178@s 
05A9: " + tmp_5546 + @"(180@,10s) = 178@s 

:DUAL_12544
if 
  366@ == 1 
else_jump @DUAL_12590 
05A9: " + tmp_5526 + @"(180@,10s) = 106@(365@,37s) 
05A9: " + tmp_5546 + @"(180@,10s) = 178@s 

:DUAL_12590
if 
  366@ == 2 
else_jump @DUAL_12624 
05A9: " + tmp_5546 + @"(180@,10s) = 106@(365@,37s) 

:DUAL_12624
0494: get_joystick 0 direction_offset_to 311@ 312@ 39@ 39@ 
if or
00E1:   player 0 pressed_key 8 
  -100 > 312@ 
else_jump @DUAL_12745 
if 
001E:   " + Current_Time_in_ms2 + @" > 104@ 
else_jump @DUAL_12738 
if 
  36 > 365@ 
else_jump @DUAL_12715 
365@ += 1 
jump @DUAL_12722 

:DUAL_12715
365@ = 0 

:DUAL_12722
008B: 104@ = " + Current_Time_in_ms2 + @" 
104@ += 250 

:DUAL_12738
jump @DUAL_12761 

:DUAL_12745
008B: 104@ = " + Current_Time_in_ms2 + @" 
104@ -= 250 

:DUAL_12761
if or
00E1:   player 0 pressed_key 9 
  312@ > 100 
else_jump @DUAL_12866 
if 
001E:   " + Current_Time_in_ms2 + @" > 105@ 
else_jump @DUAL_12859 
if 
  365@ > 0 
else_jump @DUAL_12836 
365@ -= 1 
jump @DUAL_12843 

:DUAL_12836
365@ = 36 

:DUAL_12843
008B: 105@ = " + Current_Time_in_ms2 + @" 
105@ += 250 

:DUAL_12859
jump @DUAL_12882 

:DUAL_12866
008B: 105@ = " + Current_Time_in_ms2 + @" 
105@ -= 250 

:DUAL_12882
if 
00E1:   player 0 pressed_key 16 
else_jump @DUAL_12963 
if 
  101@ == 0 
else_jump @DUAL_12956 
366@ += 1 
101@ += 1 
if 
  366@ == 3 
else_jump @DUAL_12956 
180@ = -1 

:DUAL_12956
jump @DUAL_12970 

:DUAL_12963
101@ = 0 

:DUAL_12970
if 
  181@ == 0 
else_jump @DUAL_13109 
40@ = 0 

:DUAL_12995
if 
  10 > 40@ 
else_jump @DUAL_13102 
008B: 367@(40@,10i) = " + tmp_5426 + @"(40@,10i) 
367@(40@,10i) *= -1 
05AA: 377@(40@,10s) = " + tmp_5446 + @"(40@,10s) 
05AA: 397@(40@,10s) = " + tmp_5466 + @"(40@,10s) 
05AA: 417@(40@,10s) = " + tmp_5486 + @"(40@,10s) 
40@ += 1 
jump @DUAL_12995 

:DUAL_13102
jump @DUAL_13212 

:DUAL_13109
40@ = 0 

:DUAL_13116
if 
  10 > 40@ 
else_jump @DUAL_13212 
008B: 367@(40@,10i) = " + tmp_5436 + @"(40@,10i) 
05AA: 377@(40@,10s) = " + tmp_5506 + @"(40@,10s) 
05AA: 397@(40@,10s) = " + tmp_5526 + @"(40@,10s) 
05AA: 417@(40@,10s) = " + tmp_5546 + @"(40@,10s) 
40@ += 1 
jump @DUAL_13116 

:DUAL_13212
40@ = 0 

:DUAL_13219
if 
  3 > 40@ 
else_jump @DUAL_14069 
0088: " + tempvar_Float_1 + @" = 205@ 
0067: " + tempvar_Float_1 + @" -= 199@ 
0088: " + tempvar_Float_2 + @" = 206@ 
0067: " + tempvar_Float_2 + @" -= 200@ 
" + tempvar_Float_1 + @" *= 0.6 
" + tempvar_Float_2 + @" *= 0.6 
0093: 50@ = integer 40@ to_float 
50@ += 1.0 
50@ *= 0.3 
006D: " + tempvar_Float_1 + @" *= 50@ 
006D: " + tempvar_Float_2 + @" *= 50@ 
303@ = 512.0 
006B: 303@ *= 50@ 
if 
  40@ == 0 
else_jump @DUAL_13420 
" + tempvar_Float_1 + @" /= 2.0 
" + tempvar_Float_2 + @" /= 2.0 
005D: 189@(40@,4f) += " + tempvar_Float_1 + @" 
005D: 193@(40@,4f) += " + tempvar_Float_2 + @" 
jump @DUAL_13444 

:DUAL_13420
005D: 189@(40@,4f) += " + tempvar_Float_1 + @" 
005D: 193@(40@,4f) += " + tempvar_Float_2 + @" 

:DUAL_13444
0087: 50@ = 303@ 
50@ /= 2.0 
if 
0025:   189@(40@,4f) > 50@ 
else_jump @DUAL_13497 
0063: 189@(40@,4f) -= 303@ 

:DUAL_13497
0087: 50@ = 303@ 
50@ *= -1.0 
if 
0025:   50@ > 189@(40@,4f) 
else_jump @DUAL_13550 
005B: 189@(40@,4f) += 303@ 

:DUAL_13550
0087: 50@ = 303@ 
50@ *= -1.0 
if 
0025:   193@(40@,4f) > 50@ 
else_jump @DUAL_13603 
0063: 193@(40@,4f) -= 303@ 

:DUAL_13603
0087: 50@ = 303@ 
50@ *= -1.0 
if 
0025:   50@ > 193@(40@,4f) 
else_jump @DUAL_13656 
005B: 193@(40@,4f) += 303@ 

:DUAL_13656
50@ = 640.0 
005B: 50@ += 303@ 
0087: 349@ = 50@ 
0073: 349@ /= 303@ 
0092: 350@ = float 349@ to_integer 
0093: 50@ = integer 350@ to_float 
0063: 349@ -= 50@ 
if 
  349@ > 0.0 
else_jump @DUAL_13742 
350@ += 1 

:DUAL_13742
50@ = 448.0 
005B: 50@ += 303@ 
0087: 351@ = 50@ 
0073: 351@ /= 303@ 
0092: 352@ = float 351@ to_integer 
0093: 50@ = integer 352@ to_float 
0063: 351@ -= 50@ 
if 
  351@ > 0.0 
else_jump @DUAL_13828 
352@ += 1 

:DUAL_13828
350@ += 1 
352@ += 1 
0087: 197@ = 189@(40@,4f) 
0087: 198@ = 193@(40@,4f) 
354@ = 0 

:DUAL_13873
if 
001D:   352@ > 354@ 
else_jump @DUAL_14055 
353@ = 0 

:DUAL_13899
if 
001D:   350@ > 353@ 
else_jump @DUAL_14021 
if 
  40@ == 0 
else_jump @DUAL_13971 
038D: draw_texture 1 position 197@ 198@ size 303@ 303@ RGBA 150 150 150 255 
jump @DUAL_13999 

:DUAL_13971
038D: draw_texture 2 position 197@ 198@ size 303@ 303@ RGBA 150 150 150 255 

:DUAL_13999
005B: 197@ += 303@ 
353@ += 1 
jump @DUAL_13899 

:DUAL_14021
0087: 197@ = 189@(40@,4f) 
005B: 198@ += 303@ 
354@ += 1 
jump @DUAL_13873 

:DUAL_14055
40@ += 1 
jump @DUAL_13219 

:DUAL_14069
gosub @DUAL_15515 
if 
  181@ == 0 
else_jump @DUAL_14121 
0340: set_text_draw_RGBA 0 0 0 255 
081C: draw_text_outline 1 RGBA 150 150 150 255 

:DUAL_14121
0349: set_text_draw_font 1 
033E: set_draw_text_position 182@ 183@ GXT 'SPAC_06'  
0087: 437@ = 184@ 
0087: 438@ = 185@ 
40@ = 0 

:DUAL_14165
if 
  10 > 40@ 
else_jump @DUAL_14964 
0087: 437@ = 184@ 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0349: set_text_draw_font 1 
if 
  181@ == 0 
else_jump @DUAL_14255 
0340: set_text_draw_RGBA 0 0 0 255 
081C: draw_text_outline 1 RGBA 150 150 150 255 

:DUAL_14255
if 
003B:   180@ == 40@ 
else_jump @DUAL_14286 
0340: set_text_draw_RGBA 0 155 0 255 

:DUAL_14286
if or
05AE:   377@(40@,10s) == 108@s 
05AE:   377@(40@,10s) == 142@s 
else_jump @DUAL_14331 
437@ += 8.0 

:DUAL_14331
033E: set_draw_text_position 437@ 438@ GXT 377@(40@,10s) 
if or
05AE:   377@(40@,10s) == 108@s 
05AE:   377@(40@,10s) == 142@s 
else_jump @DUAL_14391 
437@ -= 8.0 

:DUAL_14391
005B: 437@ += 186@ 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0349: set_text_draw_font 1 
if 
  181@ == 0 
else_jump @DUAL_14463 
0340: set_text_draw_RGBA 0 0 0 255 
081C: draw_text_outline 1 RGBA 150 150 150 255 

:DUAL_14463
if 
003B:   180@ == 40@ 
else_jump @DUAL_14494 
0340: set_text_draw_RGBA 0 155 0 255 

:DUAL_14494
if or
05AE:   397@(40@,10s) == 108@s 
05AE:   397@(40@,10s) == 142@s 
else_jump @DUAL_14539 
437@ += 8.0 

:DUAL_14539
033E: set_draw_text_position 437@ 438@ GXT 397@(40@,10s) 
if or
05AE:   397@(40@,10s) == 108@s 
05AE:   397@(40@,10s) == 142@s 
else_jump @DUAL_14599 
437@ -= 8.0 

:DUAL_14599
005B: 437@ += 186@ 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
0349: set_text_draw_font 1 
if 
  181@ == 0 
else_jump @DUAL_14671 
0340: set_text_draw_RGBA 0 0 0 255 
081C: draw_text_outline 1 RGBA 150 150 150 255 

:DUAL_14671
if 
003B:   180@ == 40@ 
else_jump @DUAL_14702 
0340: set_text_draw_RGBA 0 155 0 255 

:DUAL_14702
if or
05AE:   417@(40@,10s) == 108@s 
05AE:   417@(40@,10s) == 142@s 
else_jump @DUAL_14747 
437@ += 8.0 

:DUAL_14747
033E: set_draw_text_position 437@ 438@ GXT 417@(40@,10s) 
if or
05AE:   417@(40@,10s) == 108@s 
05AE:   417@(40@,10s) == 142@s 
else_jump @DUAL_14807 
437@ -= 8.0 

:DUAL_14807
0087: 437@ = 184@ 
005B: 437@ += 187@ 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
03E4: set_text_draw_align_right 1 
0349: set_text_draw_font 1 
if 
  181@ == 0 
else_jump @DUAL_14887 
0340: set_text_draw_RGBA 0 0 0 255 
081C: draw_text_outline 1 RGBA 150 150 150 255 

:DUAL_14887
if 
003B:   180@ == 40@ 
else_jump @DUAL_14918 
0340: set_text_draw_RGBA 0 155 0 255 

:DUAL_14918
045A: draw_text_1number 437@ 438@ GXT 'NUMBER' number 367@(40@,10i)  
005B: 438@ += 188@ 
40@ += 1 
jump @DUAL_14165 

:DUAL_14964
038D: draw_texture 3 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 3 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
  180@ == -1 
else_jump @DUAL_15232 
if or
00E1:   player 0 pressed_key 15 
00E1:   player 0 pressed_key 17 
00E1:   player 0 pressed_key 14 
else_jump @DUAL_15162 
jump @DUAL_2903 

:DUAL_15162
if 
00E1:   player 0 pressed_key 16 
else_jump @DUAL_15218 
if 
  101@ == 0 
else_jump @DUAL_15211 
101@ += 1 
jump @DUAL_2903 

:DUAL_15211
jump @DUAL_15225 

:DUAL_15218
101@ = 0 

:DUAL_15225
jump @DUAL_15302 

:DUAL_15232
0937: text_draw_box_cornerA 62@ 74@ cornerB 86@ 98@ GXT_reference 'DUMMY' style 0 
gosub @DUAL_15515 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 86@ 
0349: set_text_draw_font 1 
033F: set_text_draw_letter_size 87@ 99@ 
033E: set_draw_text_position 63@ 75@ GXT 'SPAC_13'  

:DUAL_15302
jump @DUAL_11763 

:DUAL_15309
40@ = 0 

:DUAL_15316
if 
  10 > 40@ 
else_jump @DUAL_15513 
if 
001E:   " + Current_Time_in_ms2 + @" > 314@(40@,10i) 
else_jump @DUAL_15499 
0087: 50@ = 203@ 
02F6: " + tempvar_Float_1 + @" = sine 50@ 
02F7: " + tempvar_Float_2 + @" = cosine 50@ 
0087: 439@(40@,10f) = 199@ 
0087: 449@(40@,10f) = 200@ 
" + tempvar_Float_1 + @" *= -300.0 
" + tempvar_Float_2 + @" *= 300.0 
0089: 459@(40@,10f) = " + tempvar_Float_1 + @" 
005D: 459@(40@,10f) += " + _5566 + @" 
0089: 469@(40@,10f) = " + tempvar_Float_2 + @" 
005D: 469@(40@,10f) += " + _5567 + @" 
008B: 314@(40@,10i) = " + Current_Time_in_ms2 + @" 
314@(40@,10i) += 1600 
return 

:DUAL_15499
40@ += 1 
jump @DUAL_15316 

:DUAL_15513
return 

:DUAL_15515
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

:DUAL_15587
097A: play_audio_at 0.0 0.0 0.0 event 1069 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @DUAL_15697 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _431 + @" " + _432 + @" " + _433 + @" radius 2.0 2.0 2.0 on_foot 
else_jump @DUAL_15697 
0086: " + tempvar_Float_2 + @" = " + _432 + @" 
" + tempvar_Float_2 + @" += 2.0 
Actor.PutAt(" + PlayerActor + @", " + _431 + @", " + tempvar_Float_2 + @", " + _433 + @")

:DUAL_15697
09F5: disable_player_mutal_activities 0 
" + OnMission + @" = 0 
03D5: remove_text 'BUSY'  
mission_cleanup 
return" );
            }

        }

    }

}