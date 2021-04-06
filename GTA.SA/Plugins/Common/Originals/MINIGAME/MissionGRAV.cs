using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class GRAV : MissionCustom {

            Int tmp_6236 = global( _6236.startIndex ),
                tmp_2082 = global( _2082.startIndex ),
                tmp_2102 = global( _2102.startIndex ),
                tmp_2122 = global( _2122.startIndex ),
                tmp_6358 = global( _6358.startIndex ),
                tmp_6318 = global( _6318.startIndex ),
                tmp_2142 = global( _2142.startIndex ),
                tmp_6328 = global( _6328.startIndex ),
                tmp_6338 = global( _6338.startIndex ),
                tmp_6348 = global( _6348.startIndex ),
                tmp_6368 = global( _6368.startIndex ),
                tmp_6378 = global( _6378.startIndex ),
                tmp_6388 = global( _6388.startIndex ),
                tmp_2152 = global( _2152.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @GRAV_36 
if 
wasted_or_busted 
else_jump @GRAV_27 
gosub @GRAV_6531 

:GRAV_27
gosub @GRAV_6551 
end_thread 

:GRAV_36
" + OnMission + @" = 1 
increment_mission_attempts 
wait 0 
054C: use_GXT_table 'GRAV' 
03CF: load_wav 1810 as 4 

:GRAV_78
if 
83D0:   not wav 4 loaded 
else_jump @GRAV_104 
wait 0 
jump @GRAV_78 

:GRAV_104
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
Player.CanMove(" + PlayerChar + @") = False
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 0 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 50.0 
09F5: disable_player_mutal_activities 1 
03F0: enable_text_draw 1 
0342: set_text_draw_centered 1 
033F: set_text_draw_letter_size 3.0 3.0 
0390: load_txd_dictionary 'LD_GRAV' 
038F: load_texture ""SKY"" as 1 
038F: load_texture ""BEEA"" as 2 
038F: load_texture ""FLWRA"" as 3 
038F: load_texture ""GHOST"" as 4 
038F: load_texture ""LEAF"" as 5 
038F: load_texture ""FLWR"" as 6 
038F: load_texture ""TVCORN"" as 7 
038F: load_texture ""TVL"" as 8 
038F: load_texture ""TVR"" as 9 
038F: load_texture ""THORN"" as 10 
038F: load_texture ""BEE2"" as 11 
038F: load_texture ""BEE1"" as 12 
038F: load_texture ""HIVE"" as 13 
038F: load_texture ""TIMER"" as 14 
038F: load_texture ""BUMBLE"" as 15 
038F: load_texture ""PLAYW"" as 16 
038F: load_texture ""PLAYY"" as 17 
038F: load_texture ""HISCOREW"" as 18 
038F: load_texture ""HISCOREY"" as 19 
038F: load_texture ""EXITW"" as 20 
038F: load_texture ""EXITY"" as 21 
05A9: s" + tmp_6236 + @"[0] = 'GRAV_0' 
05A9: s" + tmp_6236 + @"[1] = 'GRAV_1' 
05A9: s" + tmp_6236 + @"[2] = 'GRAV_2' 
05A9: s" + tmp_6236 + @"[3] = 'GRAV_3' 
05A9: s" + tmp_6236 + @"[4] = 'GRAV_4' 
05A9: s" + tmp_6236 + @"[5] = 'GRAV_5' 
05A9: s" + tmp_6236 + @"[6] = 'GRAV_6' 
05A9: s" + tmp_6236 + @"[7] = 'GRAV_7' 
05A9: s" + tmp_6236 + @"[8] = 'GRAV_8' 
05A9: s" + tmp_6236 + @"[9] = 'GRAV_9' 
05A9: s" + tmp_6236 + @"[10] = 'GRAV_A' 
05A9: s" + tmp_6236 + @"[11] = 'GRAV_B' 
05A9: s" + tmp_6236 + @"[12] = 'GRAV_C' 
05A9: s" + tmp_6236 + @"[13] = 'GRAV_D' 
05A9: s" + tmp_6236 + @"[14] = 'GRAV_E' 
05A9: s" + tmp_6236 + @"[15] = 'GRAV_F' 
05A9: s" + tmp_6236 + @"[16] = 'GRAV_G' 
05A9: s" + tmp_6236 + @"[17] = 'GRAV_H' 
05A9: s" + tmp_6236 + @"[18] = 'GRAV_I' 
05A9: s" + tmp_6236 + @"[19] = 'GRAV_J' 
05A9: s" + tmp_6236 + @"[20] = 'GRAV_K' 
05A9: s" + tmp_6236 + @"[21] = 'GRAV_L' 
05A9: s" + tmp_6236 + @"[22] = 'GRAV_M' 
05A9: s" + tmp_6236 + @"[23] = 'GRAV_N' 
05A9: s" + tmp_6236 + @"[24] = 'GRAV_O' 
05A9: s" + tmp_6236 + @"[25] = 'GRAV_P' 
05A9: s" + tmp_6236 + @"[26] = 'GRAV_Q' 
05A9: s" + tmp_6236 + @"[27] = 'GRAV_R' 
05A9: s" + tmp_6236 + @"[28] = 'GRAV_S' 
05A9: s" + tmp_6236 + @"[29] = 'GRAV_T' 
05A9: s" + tmp_6236 + @"[30] = 'GRAV_U' 
05A9: s" + tmp_6236 + @"[31] = 'GRAV_V' 
05A9: s" + tmp_6236 + @"[32] = 'GRAV_W' 
05A9: s" + tmp_6236 + @"[33] = 'GRAV_X' 
05A9: s" + tmp_6236 + @"[34] = 'GRAV_Y' 
05A9: s" + tmp_6236 + @"[35] = 'GRAV_Z' 
05A9: s" + tmp_6236 + @"[36] = 'GRAV_PE' 
" + tmp_6318 + @"[0] = 176.0 
" + tmp_6358 + @"[0] = 96.0 
" + tmp_6328 + @"[0] = 224.0 
" + tmp_6368 + @"[0] = 96.0 
" + tmp_6338 + @"[0] = 272.0 
" + tmp_6378 + @"[0] = 96.0 
" + tmp_6348 + @"[0] = 464.0 
" + tmp_6388 + @"[0] = 96.0 
" + tmp_6318 + @"[1] = 176.0 
" + tmp_6358 + @"[1] = 128.0 
" + tmp_6328 + @"[1] = 224.0 
" + tmp_6368 + @"[1] = 128.0 
" + tmp_6338 + @"[1] = 272.0 
" + tmp_6378 + @"[1] = 128.0 
" + tmp_6348 + @"[1] = 464.0 
" + tmp_6388 + @"[1] = 128.0 
" + tmp_6318 + @"[2] = 176.0 
" + tmp_6358 + @"[2] = 160.0 
" + tmp_6328 + @"[2] = 224.0 
" + tmp_6368 + @"[2] = 160.0 
" + tmp_6338 + @"[2] = 272.0 
" + tmp_6378 + @"[2] = 160.0 
" + tmp_6348 + @"[2] = 464.0 
" + tmp_6388 + @"[2] = 160.0 
" + tmp_6318 + @"[3] = 176.0 
" + tmp_6358 + @"[3] = 192.0 
" + tmp_6328 + @"[3] = 224.0 
" + tmp_6368 + @"[3] = 192.0 
" + tmp_6338 + @"[3] = 272.0 
" + tmp_6378 + @"[3] = 192.0 
" + tmp_6348 + @"[3] = 464.0 
" + tmp_6388 + @"[3] = 192.0 
" + tmp_6318 + @"[4] = 176.0 
" + tmp_6358 + @"[4] = 224.0 
" + tmp_6328 + @"[4] = 224.0 
" + tmp_6368 + @"[4] = 224.0 
" + tmp_6338 + @"[4] = 272.0 
" + tmp_6378 + @"[4] = 224.0 
" + tmp_6348 + @"[4] = 464.0 
" + tmp_6388 + @"[4] = 224.0 
" + tmp_6318 + @"[5] = 176.0 
" + tmp_6358 + @"[5] = 256.0 
" + tmp_6328 + @"[5] = 224.0 
" + tmp_6368 + @"[5] = 256.0 
" + tmp_6338 + @"[5] = 272.0 
" + tmp_6378 + @"[5] = 256.0 
" + tmp_6348 + @"[5] = 464.0 
" + tmp_6388 + @"[5] = 256.0 
" + tmp_6318 + @"[6] = 176.0 
" + tmp_6358 + @"[6] = 288.0 
" + tmp_6328 + @"[6] = 224.0 
" + tmp_6368 + @"[6] = 288.0 
" + tmp_6338 + @"[6] = 272.0 
" + tmp_6378 + @"[6] = 288.0 
" + tmp_6348 + @"[6] = 464.0 
" + tmp_6388 + @"[6] = 288.0 
" + tmp_6318 + @"[7] = 176.0 
" + tmp_6358 + @"[7] = 320.0 
" + tmp_6328 + @"[7] = 224.0 
" + tmp_6368 + @"[7] = 320.0 
" + tmp_6338 + @"[7] = 272.0 
" + tmp_6378 + @"[7] = 320.0 
" + tmp_6348 + @"[7] = 464.0 
" + tmp_6388 + @"[7] = 320.0 
" + tmp_6318 + @"[8] = 176.0 
" + tmp_6358 + @"[8] = 352.0 
" + tmp_6328 + @"[8] = 224.0 
" + tmp_6368 + @"[8] = 352.0 
" + tmp_6338 + @"[8] = 272.0 
" + tmp_6378 + @"[8] = 352.0 
" + tmp_6348 + @"[8] = 464.0 
" + tmp_6388 + @"[8] = 352.0 
" + tmp_6318 + @"[9] = 176.0 
" + tmp_6358 + @"[9] = 384.0 
" + tmp_6328 + @"[9] = 224.0 
" + tmp_6368 + @"[9] = 384.0 
" + tmp_6338 + @"[9] = 272.0 
" + tmp_6378 + @"[9] = 384.0 
" + tmp_6348 + @"[9] = 464.0 
" + tmp_6388 + @"[9] = 384.0 
if 
  " + _6405 + @" == 0 
else_jump @GRAV_2054 
05A9: s" + tmp_2082 + @"[0] = s" + tmp_6236 + @"[12] 
05A9: s" + tmp_2102 + @"[0] = s" + tmp_6236 + @"[36] 
05A9: s" + tmp_2122 + @"[0] = s" + tmp_6236 + @"[36] 
" + tmp_2152 + @"[0] = 10 
" + tmp_2142 + @"[0] = 1000 
" + _6406 + @" = 1 
gosub @GRAV_13469 
" + tmp_2152 + @"[1] = 9 
" + tmp_2142 + @"[1] = 900 
" + _6406 + @" = 2 
gosub @GRAV_13469 
" + tmp_2152 + @"[2] = 8 
" + tmp_2142 + @"[2] = 800 
" + _6406 + @" = 3 
gosub @GRAV_13469 
" + tmp_2152 + @"[3] = 7 
" + tmp_2142 + @"[3] = 700 
" + _6406 + @" = 4 
gosub @GRAV_13469 
" + tmp_2152 + @"[4] = 6 
" + tmp_2142 + @"[4] = 600 
" + _6406 + @" = 5 
gosub @GRAV_13469 
" + tmp_2152 + @"[5] = 5 
" + tmp_2142 + @"[5] = 500 
" + _6406 + @" = 6 
gosub @GRAV_13469 
" + tmp_2152 + @"[6] = 4 
" + tmp_2142 + @"[6] = 400 
" + _6406 + @" = 7 
gosub @GRAV_13469 
" + tmp_2152 + @"[7] = 3 
" + tmp_2142 + @"[7] = 300 
" + _6406 + @" = 8 
gosub @GRAV_13469 
" + tmp_2152 + @"[8] = 2 
" + tmp_2142 + @"[8] = 200 
" + _6406 + @" = 9 
gosub @GRAV_13469 
" + tmp_2152 + @"[9] = 1 
" + tmp_2142 + @"[9] = 100 
" + _6405 + @" = 1 

:GRAV_2054
008B: 57@ = " + tmp_2142 + @"[0] 

:GRAV_2062
" + _6210 + @" = 1 
54@ = 0 
" + _6213 + @" = 0 
" + _6208 + @" = 1 
51@ = 2 
47@ = 1 
43@ = 180.0 
44@ = 2.0 
" + _6439 + @" = 3648.0 
" + _6224 + @" = 2.5 
" + _6232 + @" = 120000 
" + _6211 + @" = 0 
" + _6204 + @" = 0.0 
" + _6205 + @" = 0.0 
56@ = 0 
01BD: " + _6231 + @" = current_time_in_ms 
" + _6209 + @" = 0 

:GRAV_2200
wait 0 
038D: draw_texture 1 position 128.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 128.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
fade 1 0 
0494: get_joystick 0 direction_offset_to 34@ 35@ 36@ 37@ 

:GRAV_2442
if 
  58@ == 1 
else_jump @GRAV_2497 
if and
80E1:   not player 0 pressed_key 8 
80E1:   not player 0 pressed_key 9 
  35@ == 0 
else_jump @GRAV_2497 
58@ = 0 

:GRAV_2497
if 
  " + _6208 + @" == 1 
else_jump @GRAV_2735 
038D: draw_texture 15 position 320.0 196.0 size 256.0 128.0 RGBA 150 150 150 255 
038D: draw_texture 17 position 320.0 312.0 size 64.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 18 position 320.0 344.0 size 128.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 20 position 320.0 376.0 size 64.0 32.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_2735 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1074 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1076 
01BD: " + _6235 + @" = current_time_in_ms 
" + _6208 + @" = 0 
32@ = 0 

:GRAV_2735
if 
  " + _6208 + @" == 2 
else_jump @GRAV_2953 
038D: draw_texture 15 position 320.0 196.0 size 256.0 128.0 RGBA 150 150 150 255 
038D: draw_texture 16 position 320.0 312.0 size 64.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 19 position 320.0 344.0 size 128.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 20 position 320.0 376.0 size 64.0 32.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_2953 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1074 
01BD: " + _6235 + @" = current_time_in_ms 
" + _6403 + @" = 4 
" + _6208 + @" = 4 

:GRAV_2953
if 
  " + _6208 + @" == 3 
else_jump @GRAV_3165 
038D: draw_texture 15 position 320.0 196.0 size 256.0 128.0 RGBA 150 150 150 255 
038D: draw_texture 16 position 320.0 312.0 size 64.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 18 position 320.0 344.0 size 128.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 21 position 320.0 376.0 size 64.0 32.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_3165 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1075 
fade 0 0 
jump @GRAV_6551 

:GRAV_3165
if 
  58@ == 0 
else_jump @GRAV_3627 
if 
  " + _6208 + @" == 1 
else_jump @GRAV_3331 
if or
00E1:   player 0 pressed_key 8 
  -64 > 35@ 
else_jump @GRAV_3266 
" + _6208 + @" = 3 
58@ = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1073 
jump @GRAV_2442 

:GRAV_3266
if or
00E1:   player 0 pressed_key 9 
  35@ > 64 
else_jump @GRAV_3331 
" + _6208 + @" = 2 
58@ = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1073 
jump @GRAV_2442 

:GRAV_3331
if 
  " + _6208 + @" == 2 
else_jump @GRAV_3479 
if or
00E1:   player 0 pressed_key 8 
  -64 > 35@ 
else_jump @GRAV_3414 
" + _6208 + @" = 1 
58@ = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1073 
jump @GRAV_2442 

:GRAV_3414
if or
00E1:   player 0 pressed_key 9 
  35@ > 64 
else_jump @GRAV_3479 
" + _6208 + @" = 3 
58@ = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1073 
jump @GRAV_2442 

:GRAV_3479
if 
  " + _6208 + @" == 3 
else_jump @GRAV_3627 
if or
00E1:   player 0 pressed_key 8 
  -64 > 35@ 
else_jump @GRAV_3562 
" + _6208 + @" = 2 
58@ = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1073 
jump @GRAV_2442 

:GRAV_3562
if or
00E1:   player 0 pressed_key 9 
  35@ > 64 
else_jump @GRAV_3627 
" + _6208 + @" = 1 
58@ = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1073 
jump @GRAV_2442 

:GRAV_3627
if 
  " + _6208 + @" == 0 
else_jump @GRAV_5140 
if 
0735:   is_keyboard_key_pressed 49 
else_jump @GRAV_3667 
51@ += 1 

:GRAV_3667
0494: get_joystick 0 direction_offset_to 34@ 35@ 36@ 37@ 
if 
  47@ == 1 
else_jump @GRAV_4331 
if 
  " + _6217 + @" == 12 
else_jump @GRAV_3758 
if 
  33@ > 10 
else_jump @GRAV_3751 
" + _6217 + @" = 11 
33@ = 0 

:GRAV_3751
jump @GRAV_3790 

:GRAV_3758
if 
  33@ > 10 
else_jump @GRAV_3790 
" + _6217 + @" = 12 
33@ = 0 

:GRAV_3790
if 
  34@ == 0 
else_jump @GRAV_3889 
if and
80E1:   not player 0 pressed_key 10 
80E1:   not player 0 pressed_key 11 
else_jump @GRAV_3889 
if 
  43@ > 180.0 
else_jump @GRAV_3860 
0063: 43@ -= 44@ 

:GRAV_3860
if 
  180.0 > 43@ 
else_jump @GRAV_3889 
005B: 43@ += 44@ 

:GRAV_3889
if and
  34@ > 0 
  64 > 34@ 
else_jump @GRAV_3943 
if 
  195.0 > 43@ 
else_jump @GRAV_3943 
005B: 43@ += 44@ 

:GRAV_3943
if and
  0 > 34@ 
  34@ > -64 
else_jump @GRAV_3997 
if 
  43@ > 165.0 
else_jump @GRAV_3997 
0063: 43@ -= 44@ 

:GRAV_3997
if 
00E1:   player 0 pressed_key 11 
else_jump @GRAV_4076 
if 
  210.0 > 43@ 
else_jump @GRAV_4076 
43@ += 4.0 
if 
  180.0 > 43@ 
else_jump @GRAV_4076 
43@ += 4.0 

:GRAV_4076
if and
  34@ > 63 
  130 > 34@ 
else_jump @GRAV_4164 
if 
  210.0 > 43@ 
else_jump @GRAV_4164 
43@ += 4.0 
if 
  180.0 > 43@ 
else_jump @GRAV_4164 
43@ += 4.0 

:GRAV_4164
if 
00E1:   player 0 pressed_key 10 
else_jump @GRAV_4243 
if 
  43@ > 150.0 
else_jump @GRAV_4243 
43@ -= 4.0 
if 
  43@ > 180.0 
else_jump @GRAV_4243 
43@ -= 4.0 

:GRAV_4243
if and
  -63 > 34@ 
  34@ > -130 
else_jump @GRAV_4331 
if 
  43@ > 150.0 
else_jump @GRAV_4331 
43@ -= 4.0 
if 
  43@ > 180.0 
else_jump @GRAV_4331 
43@ -= 4.0 

:GRAV_4331
if 
  " + _6210 + @" == 1 
else_jump @GRAV_4808 
" + _6202 + @" = 300.0 
" + _6203 + @" = 4096.0 
gosub @GRAV_8566 
gosub @GRAV_6741 
0086: " + _6202 + @" = " + _6206 + @" 
0086: " + _6203 + @" = " + _6207 + @" 
" + _6210 + @" = 0 
60@ = 1 
fade 1 0 

:GRAV_4419
if 
fading 
else_jump @GRAV_4803 
038D: draw_texture 1 position 128.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 128.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
wait 0 
jump @GRAV_4419 

:GRAV_4803
01BD: " + _6231 + @" = current_time_in_ms 

:GRAV_4808
if 
  " + _6210 + @" == 0 
else_jump @GRAV_4872 
gosub @GRAV_11542 
if 
  47@ == 1 
else_jump @GRAV_4865 
gosub @GRAV_7557 
gosub @GRAV_10265 

:GRAV_4865
gosub @GRAV_10661 

:GRAV_4872
if 
  47@ == 0 
else_jump @GRAV_4936 
if 
  51@ > 0 
else_jump @GRAV_4936 
32@ = 0 
51@ -= 1 
47@ = 2 
gosub @GRAV_7179 

:GRAV_4936
if 
  47@ == 2 
else_jump @GRAV_5032 
if 
05A5:   is_area_center " + _6202 + @" " + _6203 + @" scale 4.0 4.0 overlaping_area_center " + _6206 + @" " + _6207 + @" scale 4.0 4.0 
else_jump @GRAV_5032 
47@ = 1 
43@ = 180.0 
0086: " + _6202 + @" = " + _6206 + @" 
0086: " + _6203 + @" = " + _6207 + @" 

:GRAV_5032
if 
  " + _6208 + @" == 0 
else_jump @GRAV_5140 
if 
  47@ == 0 
else_jump @GRAV_5140 
if 
  51@ == 0 
else_jump @GRAV_5140 
" + _6208 + @" = 4 
" + _6403 + @" = 0 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1077 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1078 

:GRAV_5140
if 
  " + _6208 + @" == 4 
else_jump @GRAV_5209 
if and
00E1:   player 0 pressed_key 15 
   not " + _6403 + @" == 1 
else_jump @GRAV_5209 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1077 
jump @GRAV_2062 

:GRAV_5209
if 
  " + _6208 + @" == 4 
else_jump @GRAV_5522 
if 
  " + _6403 + @" == 0 
else_jump @GRAV_5297 
gosub @GRAV_6703 
033F: set_text_draw_letter_size 2.0 4.0 
033E: set_draw_text_position 320.0 196.0 GXT 'GR_A_5'  
01BD: " + _6316 + @" = current_time_in_ms 
" + _6403 + @" = 1 

:GRAV_5297
if 
  " + _6403 + @" == 1 
else_jump @GRAV_5407 
gosub @GRAV_6703 
033F: set_text_draw_letter_size 2.0 4.0 
033E: set_draw_text_position 320.0 196.0 GXT 'GR_A_5'  
01BD: " + _6315 + @" = current_time_in_ms 
01BD: " + _6315 + @" = current_time_in_ms 
0084: " + _6314 + @" = " + _6315 + @" 
0060: " + _6314 + @" -= " + _6316 + @" 
if 
  " + _6314 + @" > 5000 
else_jump @GRAV_5407 
" + _6403 + @" = 2 

:GRAV_5407
if 
  " + _6403 + @" == 2 
else_jump @GRAV_5465 
if 
001E:   " + tmp_2142 + @"[9] > 54@ 
else_jump @GRAV_5458 
" + _6403 + @" = 4 
jump @GRAV_5465 

:GRAV_5458
gosub @GRAV_11656 

:GRAV_5465
if 
  " + _6403 + @" == 3 
else_jump @GRAV_5497 
gosub @GRAV_11973 
gosub @GRAV_12856 

:GRAV_5497
if 
  " + _6403 + @" == 4 
else_jump @GRAV_5522 
gosub @GRAV_12856 

:GRAV_5522
if 
  " + _6208 + @" == 0 
else_jump @GRAV_6205 
gosub @GRAV_6703 
045A: draw_text_1number 560.0 390.0 GXT 'VP15' number 51@  
074B: draw_texture 2 position 560.0 390.0 scale 44.0 44.0 angle 180.0 color_RGBA 150 150 150 150 
074B: draw_texture 12 position 560.0 390.0 scale 36.0 36.0 angle 180.0 color_RGBA 150 150 150 150 
gosub @GRAV_6703 
045A: draw_text_1number 90.0 390.0 GXT 'VP15' number " + _6216 + @"  
074B: draw_texture 3 position 90.0 390.0 scale 40.0 40.0 angle 180.0 color_RGBA 150 150 150 150 
074B: draw_texture 6 position 90.0 390.0 scale 32.0 32.0 angle 180.0 color_RGBA 150 150 150 150 
0084: " + _6228 + @" = " + _6226 + @" 
" + _6228 + @" /= 1000 
0084: " + Time_Mins + @" = " + _6228 + @" 
" + Time_Mins + @" /= 60 
0084: " + _6227 + @" = " + Time_Mins + @" 
" + _6227 + @" *= 60 
0060: " + _6228 + @" -= " + _6227 + @" 
gosub @GRAV_6703 
if 
  " + _6228 + @" > 9 
else_jump @GRAV_5879 
045B: draw_text_2numbers 320.0 390.0 GXT 'TIME' numbers " + Time_Mins + @" " + _6228 + @"  
jump @GRAV_5906 

:GRAV_5879
045B: draw_text_2numbers 320.0 390.0 GXT 'TIME_0' numbers " + Time_Mins + @" " + _6228 + @"  

:GRAV_5906
074B: draw_texture 14 position 320.0 390.0 scale 40.0 40.0 angle 180.0 color_RGBA 150 150 150 150 
gosub @GRAV_6703 
045A: draw_text_1number 320.0 70.0 GXT 'VP15' number 54@  
074B: draw_texture 13 position 320.0 70.0 scale 40.0 40.0 angle 180.0 color_RGBA 150 150 150 150 
01BD: " + _6229 + @" = current_time_in_ms 
0084: " + _6230 + @" = " + _6229 + @" 
0060: " + _6230 + @" -= " + _6231 + @" 
if 
001C:   " + _6232 + @" > " + _6230 + @" 
else_jump @GRAV_6082 
0084: " + _6226 + @" = " + _6232 + @" 
0060: " + _6226 + @" -= " + _6230 + @" 
jump @GRAV_6205 

:GRAV_6082
if 
  47@ == 1 
else_jump @GRAV_6205 
if 
  51@ > 0 
else_jump @GRAV_6144 
51@ -= 1 
" + _6210 + @" = 1 
01BD: " + _6231 + @" = current_time_in_ms 
jump @GRAV_6205 

:GRAV_6144
47@ = 0 
" + _6208 + @" = 4 
" + _6403 + @" = 0 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1077 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1078 

:GRAV_6205
038D: draw_texture 7 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
  " + _6208 + @" == 0 
else_jump @GRAV_6367 

:GRAV_6367
if 
  " + _6208 + @" == 4 
else_jump @GRAV_6524 
if 
  " + _6403 + @" == 4 
else_jump @GRAV_6524 
01BD: " + _6233 + @" = current_time_in_ms 
0084: " + _6234 + @" = " + _6233 + @" 
0060: " + _6234 + @" -= " + _6235 + @" 
if 
  10000 > " + _6234 + @" 
else_jump @GRAV_6524 
0937: text_draw_box_cornerA 35.0 15.0 cornerB 200.0 45.0 GXT_reference 'DUMMY' style 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 230.0 
0349: set_text_draw_font 1 
033F: set_text_draw_letter_size 0.5 1.8 
033E: set_draw_text_position 40.0 20.0 GXT 'GR_BCK'  

:GRAV_6524
jump @GRAV_2200 

:GRAV_6531
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
return 
return 

:GRAV_6551
040D: unload_wav 4 
03D5: remove_text 'BUSY'  
09F5: disable_player_mutal_activities 0 
0151: remove_status_text " + _6226 + @" 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @GRAV_6686 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _425 + @" " + _426 + @" " + _427 + @" radius 2.0 2.0 2.0 on_foot 
else_jump @GRAV_6665 
0086: " + tempvar_Float_2 + @" = " + _426 + @" 
" + tempvar_Float_2 + @" += 2.0 
Actor.PutAt(" + PlayerActor + @", " + _425 + @", " + tempvar_Float_2 + @", " + _427 + @")

:GRAV_6665
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
Player.CanMove(" + PlayerChar + @") = True
fade 1 1500 

:GRAV_6686
043C: disable_sounds_after_fadeout 1 
0391: release_textures 
" + OnMission + @" = 0 
mission_cleanup 
return 

:GRAV_6703
0340: set_text_draw_RGBA 168 142 51 255 
033F: set_text_draw_letter_size 1.0 2.0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
return 

:GRAV_6741
674@ = 99999.9 
678@ = 0 

:GRAV_6758
if and
  51 > 678@ 
   not 471@(678@,101f) == 999.0 
   not 0.1 > 471@(678@,101f) 
else_jump @GRAV_7177 
0086: " + _6441 + @" = " + _6203 + @" 
if 
  " + _6441 + @" > 3000.0 
else_jump @GRAV_6940 
if 
  4100.0 > " + _6441 + @" 
else_jump @GRAV_6940 
0509: 673@ = distance_between_XY " + _6202 + @" " + _6203 + @" and_XY 471@(678@,101f) 572@(678@,101f) 
if 
0025:   674@ > 673@ 
else_jump @GRAV_6940 
0087: 674@ = 673@ 
0088: " + _6206 + @" = 471@(678@,101f) 
0088: " + _6207 + @" = 572@(678@,101f) 
" + _6207 + @" -= 32.0 

:GRAV_6940
678@ += 1 
0340: set_text_draw_RGBA 168 142 51 255 
033F: set_text_draw_letter_size 1.0 2.0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
008B: 59@ = " + _6213 + @" 
59@ += 1 
045A: draw_text_1number 320.0 224.0 GXT 'GR_LVL' number 59@  
038D: draw_texture 7 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
wait 0 
jump @GRAV_6758 

:GRAV_7177
return 

:GRAV_7179
674@ = 99999.9 
673@ = 0.0 
678@ = 0 

:GRAV_7206
if and
  51 > 678@ 
   not 471@(678@,101f) == 999.0 
   not 0.1 > 471@(678@,101f) 
else_jump @GRAV_7403 
0088: " + _6441 + @" = 572@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -200.0 
  600.0 > " + _6441 + @" 
else_jump @GRAV_7389 
0509: 673@ = distance_between_XY " + _6202 + @" " + _6203 + @" and_XY 471@(678@,101f) 572@(678@,101f) 
if 
0025:   674@ > 673@ 
else_jump @GRAV_7389 
0087: 674@ = 673@ 
0088: " + _6206 + @" = 471@(678@,101f) 
0088: " + _6207 + @" = 572@(678@,101f) 
" + _6207 + @" -= 32.0 

:GRAV_7389
678@ += 1 
jump @GRAV_7206 

:GRAV_7403
0086: " + _6218 + @" = " + _6206 + @" 
0061: " + _6218 + @" -= " + _6202 + @" 
0086: " + _6219 + @" = " + _6207 + @" 
0061: " + _6219 + @" -= " + _6203 + @" 
0086: " + _6220 + @" = " + _6218 + @" 
0069: " + _6220 + @" *= " + _6218 + @" 
0086: " + _6221 + @" = " + _6219 + @" 
0069: " + _6221 + @" *= " + _6219 + @" 
0086: " + _6222 + @" = " + _6220 + @" 
0059: " + _6222 + @" += " + _6221 + @" 
01FB: " + _6223 + @" = square_root " + _6222 + @" 
0086: " + _6220 + @" = " + _6218 + @" 
0071: " + _6220 + @" /= " + _6223 + @" 
0086: " + _6221 + @" = " + _6219 + @" 
0071: " + _6221 + @" /= " + _6223 + @" 
0086: " + _6204 + @" = " + _6224 + @" 
0069: " + _6204 + @" *= " + _6220 + @" 
0086: " + _6205 + @" = " + _6224 + @" 
0069: " + _6205 + @" *= " + _6221 + @" 
return 

:GRAV_7557
678@ = 0 

:GRAV_7564
if and
  51 > 678@ 
   not 269@(678@,101f) == 999.0 
else_jump @GRAV_7931 
0088: " + _6441 + @" = 572@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -64.0 
  480.0 > " + _6441 + @" 
else_jump @GRAV_7917 
if 
05A5:   is_area_center " + _6202 + @" " + _6203 + @" scale 32.0 44.0 overlaping_area_center 269@(678@,101f) 370@(678@,101f) scale 32.0 32.0 
else_jump @GRAV_7917 
269@(678@,101f) = 999.0 
if 
   not " + _6216 + @" == 1 
else_jump @GRAV_7780 
54@ += 10 
" + _6211 + @" += 1 
" + _6216 + @" -= 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1071 
jump @GRAV_7901 

:GRAV_7780
005C: 54@ += " + _6211 + @" 
" + _6226 + @" /= 100 
005C: 54@ += " + _6226 + @" 
" + _6211 + @" = 0 
" + _6213 + @" += 1 
0085: 55@ = 54@ 
0062: 55@ -= 56@ 
0085: 56@ = 55@ 
if 
  55@ > 665 
else_jump @GRAV_7887 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1074 
51@ += 1 

:GRAV_7887
" + _6210 + @" = 1 
32@ = 0 

:GRAV_7901
269@(678@,101f) = -999.0 
return 

:GRAV_7917
678@ += 1 
jump @GRAV_7564 

:GRAV_7931
678@ = 0 

:GRAV_7938
if and
  51 > 678@ 
   not 471@(678@,101f) == 999.0 
else_jump @GRAV_8366 
0088: " + _6441 + @" = 572@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -64.0 
  480.0 > " + _6441 + @" 
else_jump @GRAV_8352 
if 
05A5:   is_area_center " + _6202 + @" " + _6203 + @" scale 32.0 44.0 overlaping_area_center 471@(678@,101f) 572@(678@,101f) scale 96.0 32.0 
else_jump @GRAV_8345 
0086: " + _6441 + @" = " + _6203 + @" 
" + _6441 + @" += 12.0 
if 
0027:   572@(678@,101f) > " + _6441 + @" 
else_jump @GRAV_8288 
if 
  " + _6209 + @" == 0 
else_jump @GRAV_8281 
if or
80E1:   not player 0 pressed_key 16 
  0.0 > " + _6205 + @" 
else_jump @GRAV_8281 
0088: " + _6440 + @" = 471@(678@,101f) 
" + _6440 + @" -= 52.0 
if 
8024:   not  " + _6440 + @" > " + _6202 + @" 
else_jump @GRAV_8281 
0088: " + _6440 + @" = 471@(678@,101f) 
" + _6440 + @" += 52.0 
if 
8024:   not  " + _6202 + @" > " + _6440 + @" 
else_jump @GRAV_8281 
" + _6205 + @" *= -0.1 
0088: " + _6203 + @" = 572@(678@,101f) 
" + _6203 + @" -= 38.0 
" + _6209 + @" = 1 

:GRAV_8281
jump @GRAV_8338 

:GRAV_8288
" + _6204 + @" *= -0.5 
" + _6205 + @" *= -0.5 
" + _6203 + @" += 4.0 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1072 

:GRAV_8338
jump @GRAV_8352 

:GRAV_8345
" + _6209 + @" = 0 

:GRAV_8352
678@ += 1 
jump @GRAV_7938 

:GRAV_8366
678@ = 0 

:GRAV_8373
if and
  100 > 678@ 
   not 67@(678@,101f) == 999.0 
else_jump @GRAV_8564 
0088: " + _6441 + @" = 168@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -64.0 
  480.0 > " + _6441 + @" 
else_jump @GRAV_8550 
if 
05A5:   is_area_center " + _6202 + @" " + _6203 + @" scale 32.0 44.0 overlaping_area_center 67@(678@,101f) 168@(678@,101f) scale 128.0 40.0 
else_jump @GRAV_8550 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1070 
60@ = 0 
47@ = 0 
32@ = 0 

:GRAV_8550
678@ += 1 
jump @GRAV_8373 

:GRAV_8564
return 

:GRAV_8566
fade 0 0 

:GRAV_8572
if 
fading 
else_jump @GRAV_8956 
038D: draw_texture 1 position 128.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 128.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
wait 0 
jump @GRAV_8572 

:GRAV_8956
678@ = 0 
0084: " + _6214 + @" = " + _6213 + @" 
" + _6214 + @" += 1 
" + _6214 + @" *= 10 
if 
  " + _6214 + @" > 50 
else_jump @GRAV_9010 
" + _6214 + @" = 50 

:GRAV_9010
if 
001E:   " + _6214 + @" > 678@ 
else_jump @GRAV_9331 
0209: " + _6312 + @" = random_int_in_ranges 2 7 
" + _6312 + @" *= 80 
008D: " + _6440 + @" = integer " + _6312 + @" to_float 
0209: " + _6215 + @" = random_int_in_ranges 0 30 
" + _6215 + @" *= 128 
0089: 67@(678@,101f) = " + _6440 + @" 
008F: 168@(678@,101f) = integer " + _6215 + @" to_float 
678@ += 1 
0340: set_text_draw_RGBA 168 142 51 255 
033F: set_text_draw_letter_size 1.0 2.0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
008B: 59@ = " + _6213 + @" 
59@ += 1 
045A: draw_text_1number 320.0 224.0 GXT 'GR_LVL' number 59@  
038D: draw_texture 7 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
wait 0 
jump @GRAV_9010 

:GRAV_9331
67@(678@,101f) = 999.0 
168@(678@,101f) = 999.0 
678@ = 0 

:GRAV_9366
if 
001E:   " + _6214 + @" > 678@ 
else_jump @GRAV_9735 
0209: " + _6312 + @" = random_int_in_ranges 2 7 
" + _6312 + @" *= 80 
008D: " + _6440 + @" = integer " + _6312 + @" to_float 
0209: " + _6215 + @" = random_int_in_ranges 0 32 
" + _6215 + @" *= 128 
" + _6215 + @" += 64 
0089: 269@(678@,101f) = " + _6440 + @" 
008F: 370@(678@,101f) = integer " + _6215 + @" to_float 
" + _6440 + @" -= 48.0 
" + _6215 + @" += 32 
0089: 471@(678@,101f) = " + _6440 + @" 
008F: 572@(678@,101f) = integer " + _6215 + @" to_float 
678@ += 1 
0340: set_text_draw_RGBA 168 142 51 255 
033F: set_text_draw_letter_size 1.0 2.0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
008B: 59@ = " + _6213 + @" 
59@ += 1 
045A: draw_text_1number 320.0 224.0 GXT 'GR_LVL' number 59@  
038D: draw_texture 7 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
wait 0 
jump @GRAV_9366 

:GRAV_9735
269@(678@,101f) = 999.0 
370@(678@,101f) = 999.0 
471@(678@,101f) = 999.0 
572@(678@,101f) = 999.0 
0084: " + _6212 + @" = " + _6214 + @" 
0084: " + _6216 + @" = " + _6212 + @" 
008B: 678@ = " + _6214 + @" 
67@(678@,101f) = 52.0 
168@(678@,101f) = 4096.0 
678@ += 1 
67@(678@,101f) = 164.0 
168@(678@,101f) = 4096.0 
678@ += 1 
67@(678@,101f) = 268.0 
168@(678@,101f) = 4096.0 
678@ += 1 
67@(678@,101f) = 372.0 
168@(678@,101f) = 4096.0 
678@ += 1 
67@(678@,101f) = 476.0 
168@(678@,101f) = 4096.0 
678@ += 1 
67@(678@,101f) = 580.0 
168@(678@,101f) = 4096.0 
678@ += 1 
67@(678@,101f) = 52.0 
168@(678@,101f) = 0.0 
678@ += 1 
67@(678@,101f) = 164.0 
168@(678@,101f) = 0.0 
678@ += 1 
67@(678@,101f) = 268.0 
168@(678@,101f) = 0.0 
678@ += 1 
67@(678@,101f) = 372.0 
168@(678@,101f) = 0.0 
678@ += 1 
67@(678@,101f) = 476.0 
168@(678@,101f) = 0.0 
678@ += 1 
67@(678@,101f) = 580.0 
168@(678@,101f) = 0.0 
678@ += 1 
67@(678@,101f) = 999.0 
168@(678@,101f) = 999.0 
return 

:GRAV_10265
if 
  47@ == 1 
else_jump @GRAV_10659 
if 
  50.0 > " + _6202 + @" 
else_jump @GRAV_10314 
" + _6202 + @" = 50.0 

:GRAV_10314
if 
  " + _6202 + @" > 590.0 
else_jump @GRAV_10345 
" + _6202 + @" = 590.0 

:GRAV_10345
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_10428 
if 
  " + _6209 + @" == 1 
else_jump @GRAV_10397 
" + _6209 + @" = 0 
0078: " + _6205 + @" += frame_delta_time * 1.0 

:GRAV_10397
if 
  20.0 > " + _6205 + @" 
else_jump @GRAV_10428 
0078: " + _6205 + @" += frame_delta_time * 0.1 

:GRAV_10428
if 
00E1:   player 0 pressed_key 14 
else_jump @GRAV_10494 
if 
  " + _6209 + @" == 0 
else_jump @GRAV_10494 
if 
  " + _6205 + @" > 0.0 
else_jump @GRAV_10494 
007E: " + _6205 + @" -= frame_delta_time * 0.05 

:GRAV_10494
0086: " + _6440 + @" = " + _6204 + @" 
" + _6440 + @" /= 16.0 
0080: " + _6204 + @" -= frame_delta_time * " + _6440 + @" 
if 
00E1:   player 0 pressed_key 10 
else_jump @GRAV_10544 
34@ = -127 

:GRAV_10544
if 
00E1:   player 0 pressed_key 11 
else_jump @GRAV_10568 
34@ = 127 

:GRAV_10568
0091: " + _6440 + @" = integer 34@ to_float 
" + _6440 + @" /= 512.0 
007A: " + _6204 + @" += frame_delta_time * " + _6440 + @" 
007A: " + _6202 + @" += frame_delta_time * " + _6204 + @" 
if 
  " + _6209 + @" == 0 
else_jump @GRAV_10651 
if 
  " + _6205 + @" > -20.0 
else_jump @GRAV_10651 
007E: " + _6205 + @" -= frame_delta_time * 0.05 

:GRAV_10651
0080: " + _6203 + @" -= frame_delta_time * " + _6205 + @" 

:GRAV_10659
return 

:GRAV_10661
038D: draw_texture 1 position 128.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 128.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 384.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 128.0 size 256.0 256.0 RGBA 150 150 150 255 
038D: draw_texture 1 position 640.0 384.0 size 256.0 256.0 RGBA 150 150 150 255 
678@ = 0 

:GRAV_10884
if and
  100 > 678@ 
   not 67@(678@,101f) == 999.0 
else_jump @GRAV_11017 
0088: " + _6441 + @" = 168@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -64.0 
  480.0 > " + _6441 + @" 
else_jump @GRAV_11003 
038D: draw_texture 10 position 67@(678@,101f) " + _6441 + @" size 128.0 64.0 RGBA 150 150 150 255 

:GRAV_11003
678@ += 1 
jump @GRAV_10884 

:GRAV_11017
678@ = 0 

:GRAV_11024
if and
  100 > 678@ 
   not 269@(678@,101f) == 999.0 
else_jump @GRAV_11157 
0088: " + _6441 + @" = 370@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -64.0 
  480.0 > " + _6441 + @" 
else_jump @GRAV_11143 
038D: draw_texture 6 position 269@(678@,101f) " + _6441 + @" size 32.0 32.0 RGBA 150 150 150 255 

:GRAV_11143
678@ += 1 
jump @GRAV_11024 

:GRAV_11157
678@ = 0 

:GRAV_11164
if and
  100 > 678@ 
   not 471@(678@,101f) == 999.0 
else_jump @GRAV_11297 
0088: " + _6441 + @" = 572@(678@,101f) 
0061: " + _6441 + @" -= " + _6439 + @" 
if and
  " + _6441 + @" > -64.0 
  480.0 > " + _6441 + @" 
else_jump @GRAV_11283 
038D: draw_texture 5 position 471@(678@,101f) " + _6441 + @" size 128.0 32.0 RGBA 150 150 150 255 

:GRAV_11283
678@ += 1 
jump @GRAV_11164 

:GRAV_11297
0086: " + _6440 + @" = " + _6202 + @" 
0061: " + _6440 + @" -= " + _6438 + @" 
0086: " + _6441 + @" = " + _6203 + @" 
0061: " + _6441 + @" -= " + _6439 + @" 
if 
  47@ == 1 
else_jump @GRAV_11469 
if 
80E1:   not player 0 pressed_key 16 
else_jump @GRAV_11406 
074B: draw_texture 12 position " + _6440 + @" " + _6441 + @" scale 48.0 48.0 angle 43@ color_RGBA 150 150 150 255 
jump @GRAV_11462 

:GRAV_11406
074B: draw_texture " + _6217 + @" position " + _6440 + @" " + _6441 + @" scale 48.0 48.0 angle 43@ color_RGBA 150 150 150 255 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1167 

:GRAV_11462
jump @GRAV_11540 

:GRAV_11469
if 
  47@ == 2 
else_jump @GRAV_11540 
074B: draw_texture 4 position " + _6440 + @" " + _6441 + @" scale 48.0 48.0 angle 180.0 color_RGBA 150 150 150 255 
007A: " + _6202 + @" += frame_delta_time * " + _6204 + @" 
007A: " + _6203 + @" += frame_delta_time * " + _6205 + @" 

:GRAV_11540
return 

:GRAV_11542
0086: " + _6441 + @" = " + _6203 + @" 
0061: " + _6441 + @" -= " + _6439 + @" 
if 
  200.0 > " + _6441 + @" 
else_jump @GRAV_11605 
" + _6442 + @" = 200.0 
0061: " + _6442 + @" -= " + _6441 + @" 
0061: " + _6439 + @" -= " + _6442 + @" 

:GRAV_11605
if 
  " + _6441 + @" > 300.0 
else_jump @GRAV_11652 
0086: " + _6442 + @" = " + _6441 + @" 
" + _6442 + @" -= 300.0 
0059: " + _6439 + @" += " + _6442 + @" 

:GRAV_11652
return 
return 

:GRAV_11656
" + _6398 + @" = 9 
" + _6399 + @" = 0 
" + _6400 + @" = 1 

:GRAV_11677
if and
  " + _6398 + @" >= 0 
  " + _6400 + @" == 1 
else_jump @GRAV_11774 
if 
001F:   54@ > " + tmp_2142 + @"(" + _6398 + @",10i) 
else_jump @GRAV_11760 
" + _6398 + @" -= 1 
" + _6399 + @" = 1 
" + _6403 + @" = 3 
" + _6313 + @" = 1 
jump @GRAV_11767 

:GRAV_11760
" + _6400 + @" = 0 

:GRAV_11767
jump @GRAV_11677 

:GRAV_11774
if 
  " + _6399 + @" == 1 
else_jump @GRAV_11971 
" + _6398 + @" += 1 
" + _6401 + @" = 9 
" + _6402 + @" = 8 

:GRAV_11813
if 
002C:   " + _6402 + @" >= " + _6398 + @" 
else_jump @GRAV_11933 
05A9: " + tmp_2082 + @"(" + _6401 + @",10s) = " + tmp_2082 + @"(" + _6402 + @",10s) 
05A9: " + tmp_2102 + @"(" + _6401 + @",10s) = " + tmp_2102 + @"(" + _6402 + @",10s) 
05A9: " + tmp_2122 + @"(" + _6401 + @",10s) = " + tmp_2122 + @"(" + _6402 + @",10s) 
0084: " + tmp_2152 + @"(" + _6401 + @",10i) = " + tmp_2152 + @"(" + _6402 + @",10i) 
0084: " + tmp_2142 + @"(" + _6401 + @",10i) = " + tmp_2142 + @"(" + _6402 + @",10i) 
" + _6401 + @" -= 1 
" + _6402 + @" -= 1 
jump @GRAV_11813 

:GRAV_11933
008A: " + tmp_2142 + @"(" + _6398 + @",10i) = 54@ 
0084: " + tmp_2152 + @"(" + _6398 + @",10i) = " + _6213 + @" 
" + _6404 + @" = 0 
" + _6310 + @" = 10 

:GRAV_11971
return 

:GRAV_11973
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if and
80E1:   not player 0 pressed_key 8 
80E1:   not player 0 pressed_key 9 
80E1:   not player 0 pressed_key 10 
80E1:   not player 0 pressed_key 11 
80E1:   not player 0 pressed_key 16 
else_jump @GRAV_12062 
if and
  " + Move_Axis_Y + @" == 0 
  " + Move_Axis_X + @" == 0 
else_jump @GRAV_12062 
" + _6311 + @" = 0 

:GRAV_12062
if 
  " + _6404 + @" == 0 
else_jump @GRAV_12342 
05A9: " + tmp_2082 + @"(" + _6398 + @",10s) = " + tmp_6236 + @"(" + _6310 + @",37s) 
05A9: " + tmp_2102 + @"(" + _6398 + @",10s) = s" + tmp_6236 + @"[10] 
05A9: " + tmp_2122 + @"(" + _6398 + @",10s) = s" + tmp_6236 + @"[10] 
if 
  " + _6311 + @" == 0 
else_jump @GRAV_12342 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_Y + @" 
else_jump @GRAV_12221 
if 
  36 > " + _6310 + @" 
else_jump @GRAV_12207 
" + _6310 + @" += 1 
jump @GRAV_12214 

:GRAV_12207
" + _6310 + @" = 0 

:GRAV_12214
" + _6311 + @" = 1 

:GRAV_12221
if or
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_Y + @" > 100 
else_jump @GRAV_12304 
if 
  " + _6310 + @" > 0 
else_jump @GRAV_12290 
" + _6310 + @" -= 1 
jump @GRAV_12297 

:GRAV_12290
" + _6310 + @" = 36 

:GRAV_12297
" + _6311 + @" = 1 

:GRAV_12304
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_12342 
" + _6310 + @" = 10 
" + _6404 + @" = 1 
" + _6311 + @" = 1 

:GRAV_12342
if 
  " + _6404 + @" == 1 
else_jump @GRAV_12598 
05A9: " + tmp_2102 + @"(" + _6398 + @",10s) = " + tmp_6236 + @"(" + _6310 + @",37s) 
if 
  " + _6311 + @" == 0 
else_jump @GRAV_12598 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_Y + @" 
else_jump @GRAV_12477 
if 
  36 > " + _6310 + @" 
else_jump @GRAV_12463 
" + _6310 + @" += 1 
jump @GRAV_12470 

:GRAV_12463
" + _6310 + @" = 0 

:GRAV_12470
" + _6311 + @" = 1 

:GRAV_12477
if or
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_Y + @" > 100 
else_jump @GRAV_12560 
if 
  " + _6310 + @" > 0 
else_jump @GRAV_12546 
" + _6310 + @" -= 1 
jump @GRAV_12553 

:GRAV_12546
" + _6310 + @" = 36 

:GRAV_12553
" + _6311 + @" = 1 

:GRAV_12560
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_12598 
" + _6310 + @" = 10 
" + _6404 + @" = 2 
" + _6311 + @" = 1 

:GRAV_12598
if 
  " + _6404 + @" == 2 
else_jump @GRAV_12854 
05A9: " + tmp_2122 + @"(" + _6398 + @",10s) = " + tmp_6236 + @"(" + _6310 + @",37s) 
if 
  " + _6311 + @" == 0 
else_jump @GRAV_12854 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_Y + @" 
else_jump @GRAV_12733 
if 
  36 > " + _6310 + @" 
else_jump @GRAV_12719 
" + _6310 + @" += 1 
jump @GRAV_12726 

:GRAV_12719
" + _6310 + @" = 0 

:GRAV_12726
" + _6311 + @" = 1 

:GRAV_12733
if or
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_Y + @" > 100 
else_jump @GRAV_12816 
if 
  " + _6310 + @" > 0 
else_jump @GRAV_12802 
" + _6310 + @" -= 1 
jump @GRAV_12809 

:GRAV_12802
" + _6310 + @" = 36 

:GRAV_12809
" + _6311 + @" = 1 

:GRAV_12816
if 
00E1:   player 0 pressed_key 16 
else_jump @GRAV_12854 
" + _6404 + @" = 3 
" + _6311 + @" = 1 
" + _6403 + @" = 4 

:GRAV_12854
return 

:GRAV_12856
" + _6317 + @" = 0 

:GRAV_12863
if 
  10 > " + _6317 + @" 
else_jump @GRAV_13028 
gosub @GRAV_6703 
033E: set_draw_text_position " + tmp_6318 + @"(" + _6317 + @",10f) " + tmp_6358 + @"(" + _6317 + @",10f) GXT " + tmp_2082 + @"(" + _6317 + @",10s) 
gosub @GRAV_6703 
033E: set_draw_text_position " + tmp_6328 + @"(" + _6317 + @",10f) " + tmp_6368 + @"(" + _6317 + @",10f) GXT " + tmp_2102 + @"(" + _6317 + @",10s) 
gosub @GRAV_6703 
033E: set_draw_text_position " + tmp_6338 + @"(" + _6317 + @",10f) " + tmp_6378 + @"(" + _6317 + @",10f) GXT " + tmp_2122 + @"(" + _6317 + @",10s) 
gosub @GRAV_6703 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_6348 + @"(" + _6317 + @",10f) " + tmp_6388 + @"(" + _6317 + @",10f) GXT 'GRAV_LV' number " + tmp_2142 + @"(" + _6317 + @",10i)  
" + _6317 + @" += 1 
jump @GRAV_12863 

:GRAV_13028
gosub @GRAV_6703 
033E: set_draw_text_position 320.0 64.0 GXT 'GRAV_2F'  
if and
  51@ == 0 
  " + _6313 + @" == 1 
else_jump @GRAV_13467 
if 
  " + _6404 + @" == 0 
else_jump @GRAV_13148 
gosub @GRAV_6703 
0340: set_text_draw_RGBA 255 64 0 255 
033E: set_draw_text_position " + tmp_6318 + @"(" + _6398 + @",10f) " + tmp_6358 + @"(" + _6398 + @",10f) GXT " + tmp_2082 + @"(" + _6398 + @",10s) 
jump @GRAV_13191 

:GRAV_13148
gosub @GRAV_6703 
0340: set_text_draw_RGBA 255 128 0 255 
033E: set_draw_text_position " + tmp_6318 + @"(" + _6398 + @",10f) " + tmp_6358 + @"(" + _6398 + @",10f) GXT " + tmp_2082 + @"(" + _6398 + @",10s) 

:GRAV_13191
if 
  " + _6404 + @" == 1 
else_jump @GRAV_13258 
gosub @GRAV_6703 
0340: set_text_draw_RGBA 255 64 0 255 
033E: set_draw_text_position " + tmp_6328 + @"(" + _6398 + @",10f) " + tmp_6368 + @"(" + _6398 + @",10f) GXT " + tmp_2102 + @"(" + _6398 + @",10s) 
jump @GRAV_13301 

:GRAV_13258
gosub @GRAV_6703 
0340: set_text_draw_RGBA 255 128 0 255 
033E: set_draw_text_position " + tmp_6328 + @"(" + _6398 + @",10f) " + tmp_6368 + @"(" + _6398 + @",10f) GXT " + tmp_2102 + @"(" + _6398 + @",10s) 

:GRAV_13301
if 
  " + _6404 + @" == 2 
else_jump @GRAV_13368 
gosub @GRAV_6703 
0340: set_text_draw_RGBA 255 64 0 255 
033E: set_draw_text_position " + tmp_6338 + @"(" + _6398 + @",10f) " + tmp_6378 + @"(" + _6398 + @",10f) GXT " + tmp_2122 + @"(" + _6398 + @",10s) 
jump @GRAV_13411 

:GRAV_13368
gosub @GRAV_6703 
0340: set_text_draw_RGBA 255 128 0 255 
033E: set_draw_text_position " + tmp_6338 + @"(" + _6398 + @",10f) " + tmp_6378 + @"(" + _6398 + @",10f) GXT " + tmp_2122 + @"(" + _6398 + @",10s) 

:GRAV_13411
gosub @GRAV_6703 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 128 0 255 
045A: draw_text_1number " + tmp_6348 + @"(" + _6398 + @",10f) " + tmp_6388 + @"(" + _6398 + @",10f) GXT 'GRAV_LV' number " + tmp_2142 + @"(" + _6398 + @",10i)  

:GRAV_13467
return 

:GRAV_13469
0209: " + _6407 + @" = random_int_in_ranges 1 30 
if 
  " + _6407 + @" == 1 
else_jump @GRAV_13571 
if 
  " + _6409 + @" == 0 
else_jump @GRAV_13564 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[23] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[15] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[36] 
" + _6409 + @" = 1 
jump @GRAV_13571 

:GRAV_13564
jump @GRAV_13469 

:GRAV_13571
if 
  " + _6407 + @" == 2 
else_jump @GRAV_13664 
if 
  " + _6410 + @" == 0 
else_jump @GRAV_13657 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[18] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[22] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[34] 
" + _6410 + @" = 1 
jump @GRAV_13664 

:GRAV_13657
jump @GRAV_13469 

:GRAV_13664
if 
  " + _6407 + @" == 3 
else_jump @GRAV_13757 
if 
  " + _6411 + @" == 0 
else_jump @GRAV_13750 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[18] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[21] 
" + _6411 + @" = 1 
jump @GRAV_13757 

:GRAV_13750
jump @GRAV_13469 

:GRAV_13757
if 
  " + _6407 + @" == 4 
else_jump @GRAV_13850 
if 
  " + _6412 + @" == 0 
else_jump @GRAV_13843 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[12] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[20] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[27] 
" + _6412 + @" = 1 
jump @GRAV_13850 

:GRAV_13843
jump @GRAV_13469 

:GRAV_13850
if 
  " + _6407 + @" == 5 
else_jump @GRAV_13943 
if 
  " + _6413 + @" == 0 
else_jump @GRAV_13936 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[11] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[25] 
" + _6413 + @" = 1 
jump @GRAV_13943 

:GRAV_13936
jump @GRAV_13469 

:GRAV_13943
if 
  " + _6407 + @" == 6 
else_jump @GRAV_14036 
if 
  " + _6414 + @" == 0 
else_jump @GRAV_14029 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[10] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[31] 
" + _6414 + @" = 1 
jump @GRAV_14036 

:GRAV_14029
jump @GRAV_13469 

:GRAV_14036
if 
  " + _6407 + @" == 7 
else_jump @GRAV_14129 
if 
  " + _6415 + @" == 0 
else_jump @GRAV_14122 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[24] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
" + _6415 + @" = 1 
jump @GRAV_14129 

:GRAV_14122
jump @GRAV_13469 

:GRAV_14129
if 
  " + _6407 + @" == 8 
else_jump @GRAV_14222 
if 
  " + _6416 + @" == 0 
else_jump @GRAV_14215 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[28] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[19] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[21] 
" + _6416 + @" = 1 
jump @GRAV_14222 

:GRAV_14215
jump @GRAV_13469 

:GRAV_14222
if 
  " + _6407 + @" == 9 
else_jump @GRAV_14315 
if 
  " + _6417 + @" == 0 
else_jump @GRAV_14308 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[28] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[29] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[14] 
" + _6417 + @" = 1 
jump @GRAV_14315 

:GRAV_14308
jump @GRAV_13469 

:GRAV_14315
if 
  " + _6407 + @" == 10 
else_jump @GRAV_14408 
if 
  " + _6418 + @" == 0 
else_jump @GRAV_14401 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[19] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[30] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
" + _6418 + @" = 1 
jump @GRAV_14408 

:GRAV_14401
jump @GRAV_13469 

:GRAV_14408
if 
  " + _6407 + @" == 11 
else_jump @GRAV_14501 
if 
  " + _6419 + @" == 0 
else_jump @GRAV_14494 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[20] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[22] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[11] 
" + _6419 + @" = 1 
jump @GRAV_14501 

:GRAV_14494
jump @GRAV_13469 

:GRAV_14501
if 
  " + _6407 + @" == 12 
else_jump @GRAV_14594 
if 
  " + _6420 + @" == 0 
else_jump @GRAV_14587 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[16] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[28] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
" + _6420 + @" = 1 
jump @GRAV_14594 

:GRAV_14587
jump @GRAV_13469 

:GRAV_14594
if 
  " + _6407 + @" == 13 
else_jump @GRAV_14687 
if 
  " + _6421 + @" == 0 
else_jump @GRAV_14680 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[28] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
" + _6421 + @" = 1 
jump @GRAV_14687 

:GRAV_14680
jump @GRAV_13469 

:GRAV_14687
if 
  " + _6407 + @" == 14 
else_jump @GRAV_14780 
if 
  " + _6422 + @" == 0 
else_jump @GRAV_14773 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[34] 
" + _6422 + @" = 1 
jump @GRAV_14780 

:GRAV_14773
jump @GRAV_13469 

:GRAV_14780
if 
  " + _6407 + @" == 15 
else_jump @GRAV_14873 
if 
  " + _6423 + @" == 0 
else_jump @GRAV_14866 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[16] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[10] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[35] 
" + _6423 + @" = 1 
jump @GRAV_14873 

:GRAV_14866
jump @GRAV_13469 

:GRAV_14873
if 
  " + _6407 + @" == 16 
else_jump @GRAV_14966 
if 
  " + _6424 + @" == 0 
else_jump @GRAV_14959 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[10] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[35] 
" + _6424 + @" = 1 
jump @GRAV_14966 

:GRAV_14959
jump @GRAV_13469 

:GRAV_14966
if 
  " + _6407 + @" == 17 
else_jump @GRAV_15059 
if 
  " + _6425 + @" == 0 
else_jump @GRAV_15052 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[20] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[18] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[23] 
" + _6425 + @" = 1 
jump @GRAV_15059 

:GRAV_15052
jump @GRAV_13469 

:GRAV_15059
if 
  " + _6407 + @" == 18 
else_jump @GRAV_15152 
if 
  " + _6426 + @" == 0 
else_jump @GRAV_15145 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[11] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[14] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[10] 
" + _6426 + @" = 1 
jump @GRAV_15152 

:GRAV_15145
jump @GRAV_13469 

:GRAV_15152
if 
  " + _6407 + @" == 19 
else_jump @GRAV_15245 
if 
  " + _6427 + @" == 0 
else_jump @GRAV_15238 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[11] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[10] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[33] 
" + _6427 + @" = 1 
jump @GRAV_15245 

:GRAV_15238
jump @GRAV_13469 

:GRAV_15245
if 
  " + _6407 + @" == 20 
else_jump @GRAV_15338 
if 
  " + _6428 + @" == 0 
else_jump @GRAV_15331 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[21] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[24] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[30] 
" + _6428 + @" = 1 
jump @GRAV_15338 

:GRAV_15331
jump @GRAV_13469 

:GRAV_15338
if 
  " + _6407 + @" == 21 
else_jump @GRAV_15431 
if 
  " + _6429 + @" == 0 
else_jump @GRAV_15424 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[19] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[23] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[24] 
" + _6429 + @" = 1 
jump @GRAV_15431 

:GRAV_15424
jump @GRAV_13469 

:GRAV_15431
if 
  " + _6407 + @" == 22 
else_jump @GRAV_15524 
if 
  " + _6430 + @" == 0 
else_jump @GRAV_15517 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[22] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[34] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[29] 
" + _6430 + @" = 1 
jump @GRAV_15524 

:GRAV_15517
jump @GRAV_13469 

:GRAV_15524
if 
  " + _6407 + @" == 23 
else_jump @GRAV_15617 
if 
  " + _6431 + @" == 0 
else_jump @GRAV_15610 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[13] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[14] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[15] 
" + _6431 + @" = 1 
jump @GRAV_15617 

:GRAV_15610
jump @GRAV_13469 

:GRAV_15617
if 
  " + _6407 + @" == 24 
else_jump @GRAV_15710 
if 
  " + _6432 + @" == 0 
else_jump @GRAV_15703 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[20] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[17] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[35] 
" + _6432 + @" = 1 
jump @GRAV_15710 

:GRAV_15703
jump @GRAV_13469 

:GRAV_15710
if 
  " + _6407 + @" == 25 
else_jump @GRAV_15803 
if 
  " + _6433 + @" == 0 
else_jump @GRAV_15796 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[22] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[14] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[24] 
" + _6433 + @" = 1 
jump @GRAV_15803 

:GRAV_15796
jump @GRAV_13469 

:GRAV_15803
if 
  " + _6407 + @" == 26 
else_jump @GRAV_15896 
if 
  " + _6434 + @" == 0 
else_jump @GRAV_15889 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[16] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[15] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
" + _6434 + @" = 1 
jump @GRAV_15896 

:GRAV_15889
jump @GRAV_13469 

:GRAV_15896
if 
  " + _6407 + @" == 27 
else_jump @GRAV_15989 
if 
  " + _6435 + @" == 0 
else_jump @GRAV_15982 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[27] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[22] 
" + _6435 + @" = 1 
jump @GRAV_15989 

:GRAV_15982
jump @GRAV_13469 

:GRAV_15989
if 
  " + _6407 + @" == 28 
else_jump @GRAV_16082 
if 
  " + _6436 + @" == 0 
else_jump @GRAV_16075 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[10] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[36] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[32] 
" + _6436 + @" = 1 
jump @GRAV_16082 

:GRAV_16075
jump @GRAV_13469 

:GRAV_16082
if 
  " + _6407 + @" == 29 
else_jump @GRAV_16175 
if 
  " + _6437 + @" == 0 
else_jump @GRAV_16168 
05A9: " + tmp_2082 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[27] 
05A9: " + tmp_2102 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[18] 
05A9: " + tmp_2122 + @"(" + _6406 + @",10s) = s" + tmp_6236 + @"[12] 
" + _6437 + @" = 1 
jump @GRAV_16175 

:GRAV_16168
jump @GRAV_13469 

:GRAV_16175
return" );
            }

        }

    }

}