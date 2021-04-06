using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class SHTR : MissionCustom {

            Int tmp_SHTR_characters = global( SHTR_characters.startIndex ),
                tmp_2022 = global( _2022.startIndex ),
                tmp_2072 = global( _2072.startIndex ),
                tmp_2062 = global( _2062.startIndex ),
                tmp_2002 = global( _2002.startIndex ),
                tmp_2042 = global( _2042.startIndex ),
                tmp_5659 = global( _5659.startIndex ),
                tmp_5725 = global( _5725.startIndex ),
                tmp_5707 = global( _5707.startIndex ),
                tmp_5691 = global( _5691.startIndex ),
                tmp_5675 = global( _5675.startIndex ),
                tmp_5773 = global( _5773.startIndex ),
                tmp_5757 = global( _5757.startIndex ),
                tmp_5741 = global( _5741.startIndex ),
                tmp_5789 = global( _5789.startIndex ),
                tmp_5837 = global( _5837.startIndex ),
                tmp_5821 = global( _5821.startIndex ),
                tmp_5805 = global( _5805.startIndex ),
                tmp_5860 = global( _5860.startIndex ),
                tmp_5613 = global( _5613.startIndex ),
                tmp_5629 = global( _5629.startIndex ),
                tmp_5877 = global( _5877.startIndex ),
                tmp_5925 = global( _5925.startIndex ),
                tmp_5597 = global( _5597.startIndex ),
                tmp_5893 = global( _5893.startIndex ),
                tmp_5981 = global( _5981.startIndex ),
                tmp_5965 = global( _5965.startIndex ),
                tmp_5973 = global( _5973.startIndex ),
                tmp_6071 = global( _6071.startIndex ),
                tmp_6081 = global( _6081.startIndex ),
                tmp_6091 = global( _6091.startIndex ),
                tmp_6101 = global( _6101.startIndex ),
                tmp_6111 = global( _6111.startIndex ),
                tmp_6121 = global( _6121.startIndex ),
                tmp_6131 = global( _6131.startIndex ),
                tmp_6141 = global( _6141.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @SHTR_67 
if 
wasted_or_busted 
else_jump @SHTR_27 
gosub @SHTR_6767 

:SHTR_27
fade 1 500 

:SHTR_34
if 
fading 
else_jump @SHTR_58 
wait 0 
jump @SHTR_34 

:SHTR_58
gosub @SHTR_6787 
end_thread 

:SHTR_67
" + OnMission + @" = 1 
if 
  " + _2202 + @" == 0 
else_jump @SHTR_94 
increment_mission_attempts 

:SHTR_94
wait 0 
09F5: disable_player_mutal_activities 1 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 0 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 50.0 
043C: disable_sounds_after_fadeout 0 
054C: use_GXT_table 'SHTR' 
03CF: load_wav 1806 as 4 

:SHTR_167
if 
83D0:   not wav 4 loaded 
else_jump @SHTR_193 
wait 0 
jump @SHTR_167 

:SHTR_193
Actor.LockInCurrentPosition(" + PlayerActor + @") = True
Player.CanMove(" + PlayerChar + @") = False
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 1 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 25.0 
03F0: enable_text_draw 1 
0390: load_txd_dictionary 'LD_SHTR' 
038F: load_texture ""SPLSH"" as 1 
038F: load_texture ""BSTARS"" as 2 
038F: load_texture ""FSTAR"" as 3 
038F: load_texture ""HI_A"" as 4 
038F: load_texture ""HI_B"" as 5 
038F: load_texture ""HI_C"" as 6 
038F: load_texture ""UN_A"" as 7 
038F: load_texture ""UN_B"" as 8 
038F: load_texture ""UN_C"" as 9 
038F: load_texture ""SHIP"" as 10 
038F: load_texture ""FIRE"" as 11 
038F: load_texture ""UFO"" as 12 
038F: load_texture ""KAMI"" as 13 
038F: load_texture ""NMEF"" as 14 
038F: load_texture ""EX1"" as 15 
038F: load_texture ""EX2"" as 16 
038F: load_texture ""EX3"" as 17 
038F: load_texture ""EX4"" as 18 
038F: load_texture ""CBARL"" as 19 
038F: load_texture ""CBARM"" as 20 
038F: load_texture ""CBARR"" as 21 
038F: load_texture ""HBARL"" as 22 
038F: load_texture ""HBARM"" as 23 
038F: load_texture ""HBARR"" as 24 
038F: load_texture ""TVCORN"" as 25 
038F: load_texture ""TVL"" as 26 
038F: load_texture ""TVR"" as 27 
038F: load_texture ""PA"" as 28 
038F: load_texture ""PM2"" as 29 
038F: load_texture ""PM3"" as 30 
038F: load_texture ""PS1"" as 31 
038F: load_texture ""PS2"" as 32 
038F: load_texture ""PS3"" as 33 

:SHTR_582
gosub @SHTR_17446 
gosub @SHTR_15794 
03DE: set_pedestrians_density_multiplier_to 0.0 
01EB: set_traffic_density_multiplier_to 0.0 
038D: draw_texture 25 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 25 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 25 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 25 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
33@ = 0 

:SHTR_761
wait 0 
0086: " + _5588 + @" = " + _5592 + @" 
" + _5593 + @" = 2 
" + _5589 + @" = 1.0 
gosub @SHTR_6986 
" + _5590 + @" = 1.0 
gosub @SHTR_7229 
0086: " + _5592 + @" = " + _5588 + @" 
fade 1 0 
0494: get_joystick 0 direction_offset_to " + _5569 + @" " + _5570 + @" " + _5571 + @" " + _5572 + @" 

:SHTR_844
if 
  " + _5652 + @" == 1 
else_jump @SHTR_899 
if and
80E1:   not player 0 pressed_key 8 
80E1:   not player 0 pressed_key 9 
  " + _5570 + @" == 0 
else_jump @SHTR_899 
" + _5652 + @" = 0 

:SHTR_899
if 
  " + _5648 + @" == 1 
else_jump @SHTR_1135 
038D: draw_texture 1 position 320.0 164.0 size 386.0 192.0 RGBA 150 150 150 255 
038D: draw_texture 4 position 320.0 312.0 size 64.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 8 position 320.0 344.0 size 128.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 9 position 320.0 376.0 size 64.0 32.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_1135 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1062 
01BD: " + _5582 + @" = current_time_in_ms 
01BD: " + _5992 + @" = current_time_in_ms 
" + _5648 + @" = 0 

:SHTR_1135
if 
  " + _5648 + @" == 2 
else_jump @SHTR_1353 
038D: draw_texture 1 position 320.0 164.0 size 386.0 192.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 320.0 312.0 size 64.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 5 position 320.0 344.0 size 128.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 9 position 320.0 376.0 size 64.0 32.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_1353 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 
01BD: " + _5992 + @" = current_time_in_ms 
" + _6156 + @" = 4 
" + _5648 + @" = 4 

:SHTR_1353
if 
  " + _5648 + @" == 3 
else_jump @SHTR_1565 
038D: draw_texture 1 position 320.0 164.0 size 386.0 192.0 RGBA 150 150 150 255 
038D: draw_texture 7 position 320.0 312.0 size 64.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 8 position 320.0 344.0 size 128.0 32.0 RGBA 150 150 150 255 
038D: draw_texture 6 position 320.0 376.0 size 64.0 32.0 RGBA 150 150 150 255 
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_1565 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1066 
fade 0 0 
jump @SHTR_27 

:SHTR_1565
if 
  " + _5652 + @" == 0 
else_jump @SHTR_2027 
if 
  " + _5648 + @" == 1 
else_jump @SHTR_1731 
if or
00E1:   player 0 pressed_key 8 
  -64 > " + _5570 + @" 
else_jump @SHTR_1666 
" + _5648 + @" = 3 
" + _5652 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
jump @SHTR_844 

:SHTR_1666
if or
00E1:   player 0 pressed_key 9 
  " + _5570 + @" > 64 
else_jump @SHTR_1731 
" + _5648 + @" = 2 
" + _5652 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
jump @SHTR_844 

:SHTR_1731
if 
  " + _5648 + @" == 2 
else_jump @SHTR_1879 
if or
00E1:   player 0 pressed_key 8 
  -64 > " + _5570 + @" 
else_jump @SHTR_1814 
" + _5648 + @" = 1 
" + _5652 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
jump @SHTR_844 

:SHTR_1814
if or
00E1:   player 0 pressed_key 9 
  " + _5570 + @" > 64 
else_jump @SHTR_1879 
" + _5648 + @" = 3 
" + _5652 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
jump @SHTR_844 

:SHTR_1879
if 
  " + _5648 + @" == 3 
else_jump @SHTR_2027 
if or
00E1:   player 0 pressed_key 8 
  -64 > " + _5570 + @" 
else_jump @SHTR_1962 
" + _5648 + @" = 2 
" + _5652 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
jump @SHTR_844 

:SHTR_1962
if or
00E1:   player 0 pressed_key 9 
  " + _5570 + @" > 64 
else_jump @SHTR_2027 
" + _5648 + @" = 1 
" + _5652 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
jump @SHTR_844 

:SHTR_2027
if 
  " + _5648 + @" == 0 
else_jump @SHTR_5956 
0494: get_joystick 0 direction_offset_to " + _5569 + @" " + _5570 + @" " + _5571 + @" " + _5572 + @" 
if 
  " + _5580 + @" == 0 
else_jump @SHTR_2150 
01BD: " + _5594 + @" = current_time_in_ms 
if 
  " + _5649 + @" > 0 
else_jump @SHTR_2150 
" + _5649 + @" -= 1 
" + _5653 + @" = 2.0 
" + _5654 + @" = 4.0 
" + _5581 + @" = 5 
" + _5580 + @" = 2 
" + _5960 + @" = 0 

:SHTR_2150
if 
  " + _5580 + @" == 1 
else_jump @SHTR_2200 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_2200
if or
  " + _5580 + @" == 1 
  " + _5580 + @" == 3 
else_jump @SHTR_2287 
0084: " + _5573 + @" = " + _5569 + @" 
" + _5573 + @" /= 20 
008D: " + _5574 + @" = integer " + _5573 + @" to_float 
007A: " + _5575 + @" += frame_delta_time * " + _5574 + @" 
0084: " + _5573 + @" = " + _5570 + @" 
" + _5573 + @" /= 20 
008D: " + _5574 + @" = integer " + _5573 + @" to_float 
007A: " + _5576 + @" += frame_delta_time * " + _5574 + @" 

:SHTR_2287
if or
  " + _5580 + @" == 1 
  " + _5580 + @" == 3 
else_jump @SHTR_2420 
if 
00E1:   player 0 pressed_key 8 
else_jump @SHTR_2339 
007E: " + _5576 + @" -= frame_delta_time * 6.0 

:SHTR_2339
if 
00E1:   player 0 pressed_key 9 
else_jump @SHTR_2366 
0078: " + _5576 + @" += frame_delta_time * 6.0 

:SHTR_2366
if 
00E1:   player 0 pressed_key 10 
else_jump @SHTR_2393 
007E: " + _5575 + @" -= frame_delta_time * 6.0 

:SHTR_2393
if 
00E1:   player 0 pressed_key 11 
else_jump @SHTR_2420 
0078: " + _5575 + @" += frame_delta_time * 6.0 

:SHTR_2420
if 
  80.0 > " + _5575 + @" 
else_jump @SHTR_2451 
" + _5575 + @" = 80.0 

:SHTR_2451
if 
  " + _5575 + @" > 560.0 
else_jump @SHTR_2482 
" + _5575 + @" = 560.0 

:SHTR_2482
if 
  80.0 > " + _5576 + @" 
else_jump @SHTR_2513 
" + _5576 + @" = 80.0 

:SHTR_2513
if 
  " + _5576 + @" > 368.0 
else_jump @SHTR_2544 
" + _5576 + @" = 368.0 

:SHTR_2544
if 
  " + _5579 + @" == 1 
else_jump @SHTR_2683 
01BD: " + _5583 + @" = current_time_in_ms 
0084: " + _5584 + @" = " + _5583 + @" 
0060: " + _5584 + @" -= " + _5582 + @" 
if 
  " + _5957 + @" == 0 
else_jump @SHTR_2651 
if 
80E1:   not player 0 pressed_key 16 
else_jump @SHTR_2644 
if 
001C:   " + _5584 + @" > " + _5956 + @" 
else_jump @SHTR_2644 
" + _5579 + @" = 0 

:SHTR_2644
jump @SHTR_2683 

:SHTR_2651
if or
80E1:   not player 0 pressed_key 16 
001C:   " + _5584 + @" > " + _5956 + @" 
else_jump @SHTR_2683 
" + _5579 + @" = 0 

:SHTR_2683
if 
  7 > " + _5581 + @" 
else_jump @SHTR_2708 
" + _5581 + @" = 7 

:SHTR_2708
" + _5581 + @" -= 7 
if or
  " + _5580 + @" == 1 
  " + _5580 + @" == 3 
else_jump @SHTR_3210 
if 
  1000 > " + _5581 + @" 
else_jump @SHTR_3210 
if 
  " + _5579 + @" == 0 
else_jump @SHTR_3210 
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_3210 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1059 
02F7: " + _5856 + @" = cosine " + _5854 + @" 
0086: " + _5857 + @" = " + _5591 + @" 
0069: " + _5857 + @" *= " + _5856 + @" 
02F6: " + _5855 + @" = sine " + _5854 + @" 
0086: " + _5858 + @" = " + _5591 + @" 
0069: " + _5858 + @" *= " + _5855 + @" 
if 
  " + tmp_5659 + @"(" + _5658 + @",16i) == 0 
else_jump @SHTR_2949 
0086: " + tmp_5707 + @"(" + _5658 + @",16f) = " + _5575 + @" 
0086: " + tmp_5691 + @"(" + _5658 + @",16f) = " + _5576 + @" 
0086: " + tmp_5675 + @"(" + _5658 + @",16f) = " + tmp_5707 + @"(" + _5658 + @",16f) 
" + tmp_5675 + @"(" + _5658 + @",16f) += 16.0 
" + tmp_5659 + @"(" + _5658 + @",16i) = 1 

:SHTR_2949
if or
  " + _5958 + @" == 1 
  " + _5958 + @" == 2 
else_jump @SHTR_3061 
if 
  " + tmp_5725 + @"(" + _5658 + @",16i) == 0 
else_jump @SHTR_3061 
0086: " + tmp_5773 + @"(" + _5658 + @",16f) = " + _5575 + @" 
0086: " + tmp_5757 + @"(" + _5658 + @",16f) = " + _5576 + @" 
0086: " + tmp_5741 + @"(" + _5658 + @",16f) = " + tmp_5773 + @"(" + _5658 + @",16f) 
" + tmp_5741 + @"(" + _5658 + @",16f) += 16.0 
" + tmp_5725 + @"(" + _5658 + @",16i) = 1 

:SHTR_3061
if 
  " + _5958 + @" == 2 
else_jump @SHTR_3166 
if 
  " + tmp_5789 + @"(" + _5658 + @",16i) == 0 
else_jump @SHTR_3166 
0086: " + tmp_5837 + @"(" + _5658 + @",16f) = " + _5575 + @" 
0086: " + tmp_5821 + @"(" + _5658 + @",16f) = " + _5576 + @" 
0086: " + tmp_5805 + @"(" + _5658 + @",16f) = " + tmp_5837 + @"(" + _5658 + @",16f) 
" + tmp_5805 + @"(" + _5658 + @",16f) += 16.0 
" + tmp_5789 + @"(" + _5658 + @",16i) = 1 

:SHTR_3166
01BD: " + _5582 + @" = current_time_in_ms 
" + _5658 + @" += 1 
" + _5579 + @" = 1 
if 
  " + _5658 + @" == 16 
else_jump @SHTR_3210 
" + _5658 + @" = 0 

:SHTR_3210
gosub @SHTR_9211 
gosub @SHTR_10139 
if 
  " + _5951 + @" == 0 
else_jump @SHTR_4076 
038D: draw_texture " + _5952 + @" position " + _5954 + @" " + _5955 + @" size 32.0 32.0 RGBA 150 150 150 255 
if 
  " + _5953 + @" == 0 
else_jump @SHTR_3360 
if and
  368.0 > " + _5955 + @" 
  " + _5954 + @" > 80.0 
else_jump @SHTR_3351 
" + _5954 + @" += -1.0 
" + _5955 + @" += 1.0 
jump @SHTR_3360 

:SHTR_3351
0209: " + _5953 + @" = random_int_in_ranges 0 4 

:SHTR_3360
if 
  " + _5953 + @" == 1 
else_jump @SHTR_3445 
if and
  " + _5954 + @" > 80.0 
  " + _5955 + @" > 80.0 
else_jump @SHTR_3436 
" + _5954 + @" += -1.0 
" + _5955 + @" += -1.0 
jump @SHTR_3445 

:SHTR_3436
0209: " + _5953 + @" = random_int_in_ranges 0 4 

:SHTR_3445
if 
  " + _5953 + @" == 2 
else_jump @SHTR_3530 
if and
  " + _5955 + @" > 80.0 
  560.0 > " + _5954 + @" 
else_jump @SHTR_3521 
" + _5954 + @" += 1.0 
" + _5955 + @" += -1.0 
jump @SHTR_3530 

:SHTR_3521
0209: " + _5953 + @" = random_int_in_ranges 0 4 

:SHTR_3530
if 
  " + _5953 + @" == 3 
else_jump @SHTR_3615 
if and
  560.0 > " + _5954 + @" 
  368.0 > " + _5955 + @" 
else_jump @SHTR_3606 
" + _5954 + @" += 1.0 
" + _5955 + @" += 1.0 
jump @SHTR_3615 

:SHTR_3606
0209: " + _5953 + @" = random_int_in_ranges 0 4 

:SHTR_3615
if 
05A5:   is_area_center " + _5575 + @" " + _5576 + @" scale 32.0 32.0 overlaping_area_center " + _5954 + @" " + _5955 + @" scale 32.0 32.0 
else_jump @SHTR_4076 
if 
  6.5 > " + _5654 + @" 
else_jump @SHTR_3701 
" + _5653 + @" += 0.5 
" + _5654 + @" += 0.5 

:SHTR_3701
" + _5954 + @" = 0.0 
" + _5955 + @" = 0.0 
" + _5953 + @" = 0 
if 
  " + _5952 + @" == 28 
else_jump @SHTR_3780 
" + _5957 + @" = 1 
" + _5951 + @" = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_3780
if 
  " + _5952 + @" == 33 
else_jump @SHTR_3839 
" + _5956 + @" = 50 
" + _5952 + @" = 28 
" + _5951 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_3839
if 
  " + _5952 + @" == 30 
else_jump @SHTR_3898 
" + _5958 + @" = 2 
" + _5952 + @" = 33 
" + _5951 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_3898
if 
  " + _5952 + @" == 32 
else_jump @SHTR_3957 
" + _5956 + @" = 100 
" + _5952 + @" = 30 
" + _5951 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_3957
if 
  " + _5952 + @" == 29 
else_jump @SHTR_4016 
" + _5958 + @" = 1 
" + _5952 + @" = 32 
" + _5951 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_4016
if 
  " + _5952 + @" == 31 
else_jump @SHTR_4076 
" + _5956 + @" = 150 
" + _5952 + @" = 29 
" + _5951 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_4076
if 
  " + _5655 + @" == 0 
else_jump @SHTR_4190 
if 
  33@ > 500 
else_jump @SHTR_4190 
if 
  " + tmp_5860 + @"[0] == 0 
else_jump @SHTR_4190 
" + _5859 + @" = 0 
if 
  60.0 > " + _5949 + @" 
else_jump @SHTR_4169 
" + _5949 + @" += 5.0 

:SHTR_4169
gosub @SHTR_8027 
33@ = 0 
" + _5655 + @" += 1 

:SHTR_4190
if and
  " + _5655 + @" > 0 
  8 > " + _5655 + @" 
else_jump @SHTR_4230 
0084: " + _5859 + @" = " + _5655 + @" 
gosub @SHTR_7472 

:SHTR_4230
if 
  " + _5655 + @" == 8 
else_jump @SHTR_4347 
if and
  " + tmp_5860 + @"[0] == 0 
  " + tmp_5860 + @"[1] == 0 
  " + tmp_5860 + @"[2] == 0 
  " + tmp_5860 + @"[3] == 0 
else_jump @SHTR_4347 
if and
  " + tmp_5860 + @"[4] == 0 
  " + tmp_5860 + @"[5] == 0 
  " + tmp_5860 + @"[6] == 0 
  " + tmp_5860 + @"[7] == 0 
else_jump @SHTR_4347 
" + _5950 + @" = 0 
" + _5876 + @" = 0 
" + _5655 + @" = 0 

:SHTR_4347
gosub @SHTR_8789 
gosub @SHTR_7564 
gosub @SHTR_9636 
if 
  " + _5580 + @" == 2 
else_jump @SHTR_5128 
if 
  " + _5960 + @" == 2 
else_jump @SHTR_4773 
01BD: " + _5595 + @" = current_time_in_ms 
0084: " + _5596 + @" = " + _5595 + @" 
0060: " + _5596 + @" -= " + _5594 + @" 
if and
  " + _5596 + @" >= 0 
  100 > " + _5596 + @" 
else_jump @SHTR_4482 
038D: draw_texture 15 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4482
if and
  " + _5596 + @" >= 100 
  200 > " + _5596 + @" 
else_jump @SHTR_4540 
038D: draw_texture 16 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4540
if and
  " + _5596 + @" >= 200 
  300 > " + _5596 + @" 
else_jump @SHTR_4599 
038D: draw_texture 17 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4599
if and
  " + _5596 + @" >= 300 
  400 > " + _5596 + @" 
else_jump @SHTR_4658 
038D: draw_texture 18 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4658
if 
  " + _5596 + @" > 499 
else_jump @SHTR_4766 
" + _5575 + @" = 80.0 
" + _5576 + @" = 224.0 
" + _5580 + @" = 3 
" + _5960 + @" = 0 
" + _5950 + @" = 0 
" + _5951 + @" = 1 
" + _5952 + @" = 31 
" + _5956 + @" = 250 
" + _5957 + @" = 0 
" + _5958 + @" = 0 
" + _5953 + @" = 0 
01BD: " + _5594 + @" = current_time_in_ms 

:SHTR_4766
jump @SHTR_5128 

:SHTR_4773
01BD: " + _5595 + @" = current_time_in_ms 
0084: " + _5596 + @" = " + _5595 + @" 
0060: " + _5596 + @" -= " + _5594 + @" 
if and
  " + _5596 + @" >= 0 
  100 > " + _5596 + @" 
else_jump @SHTR_4851 
038D: draw_texture 15 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4851
if and
  " + _5596 + @" >= 100 
  200 > " + _5596 + @" 
else_jump @SHTR_4909 
038D: draw_texture 16 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4909
if and
  " + _5596 + @" >= 200 
  300 > " + _5596 + @" 
else_jump @SHTR_4968 
038D: draw_texture 17 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_4968
if and
  " + _5596 + @" >= 300 
  400 > " + _5596 + @" 
else_jump @SHTR_5027 
038D: draw_texture 18 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_5027
if 
  " + _5596 + @" > 499 
else_jump @SHTR_5128 
01BD: " + _5594 + @" = current_time_in_ms 
" + _5575 + @" = 80.0 
" + _5576 + @" = 224.0 
" + _5950 + @" = 0 
" + _5951 + @" = 1 
" + _5952 + @" = 31 
" + _5956 + @" = 250 
" + _5957 + @" = 0 
" + _5958 + @" = 0 
" + _5953 + @" = 0 
" + _5580 + @" = 3 

:SHTR_5128
if 
  " + _5580 + @" == 3 
else_jump @SHTR_5781 
01BD: " + _5595 + @" = current_time_in_ms 
0084: " + _5596 + @" = " + _5595 + @" 
0060: " + _5596 + @" -= " + _5594 + @" 
if and
  " + _5596 + @" >= 0 
  100 > " + _5596 + @" 
else_jump @SHTR_5224 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5224
if and
  " + _5596 + @" >= 200 
  300 > " + _5596 + @" 
else_jump @SHTR_5283 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5283
if and
  " + _5596 + @" >= 400 
  500 > " + _5596 + @" 
else_jump @SHTR_5342 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5342
if and
  " + _5596 + @" >= 600 
  700 > " + _5596 + @" 
else_jump @SHTR_5401 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5401
if and
  " + _5596 + @" >= 800 
  900 > " + _5596 + @" 
else_jump @SHTR_5460 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5460
if and
  " + _5596 + @" >= 1000 
  1100 > " + _5596 + @" 
else_jump @SHTR_5519 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5519
if and
  " + _5596 + @" >= 1200 
  1300 > " + _5596 + @" 
else_jump @SHTR_5578 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5578
if and
  " + _5596 + @" >= 1400 
  1500 > " + _5596 + @" 
else_jump @SHTR_5637 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5637
if and
  " + _5596 + @" >= 1600 
  1700 > " + _5596 + @" 
else_jump @SHTR_5696 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5696
if and
  " + _5596 + @" >= 1800 
  1900 > " + _5596 + @" 
else_jump @SHTR_5755 
038D: draw_texture 10 position " + _5575 + @" " + _5576 + @" size 32.0 32.0 RGBA 150 150 150 150 

:SHTR_5755
if 
  " + _5596 + @" >= 2000 
else_jump @SHTR_5781 
" + _5580 + @" = 1 

:SHTR_5781
if 
001C:   " + _5650 + @" > " + _5651 + @" 
else_jump @SHTR_5815 
0084: " + _5651 + @" = " + _5650 + @" 
" + _5568 + @" = 1 

:SHTR_5815
gosub @SHTR_6947 
033F: set_text_draw_letter_size 0.6 1.2 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number 560.0 48.0 GXT 'SHTR_2B' number " + _5649 + @"  
gosub @SHTR_6947 
0342: set_text_draw_centered 0 
0341: set_text_draw_align_justify 1 
033F: set_text_draw_letter_size 0.6 1.2 
045A: draw_text_1number 80.0 48.0 GXT 'SHTR_2D' number " + _5650 + @"  
gosub @SHTR_6947 
033F: set_text_draw_letter_size 0.6 1.2 
045A: draw_text_1number 320.0 48.0 GXT 'SHTR_2C' number " + _5651 + @"  

:SHTR_5956
if 
  " + _5648 + @" == 0 
else_jump @SHTR_6064 
if 
  " + _5580 + @" == 0 
else_jump @SHTR_6064 
if 
  " + _5649 + @" == 0 
else_jump @SHTR_6064 
" + _5648 + @" = 4 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1063 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1067 
" + _6156 + @" = 0 

:SHTR_6064
if 
  " + _5648 + @" == 4 
else_jump @SHTR_6372 
if 
  " + _6156 + @" == 0 
else_jump @SHTR_6152 
gosub @SHTR_6947 
033F: set_text_draw_letter_size 2.0 4.0 
033E: set_draw_text_position 320.0 196.0 GXT 'SHTR_3B'  
01BD: " + _5594 + @" = current_time_in_ms 
" + _6156 + @" = 1 

:SHTR_6152
if 
  " + _6156 + @" == 1 
else_jump @SHTR_6257 
gosub @SHTR_6947 
033F: set_text_draw_letter_size 2.0 4.0 
033E: set_draw_text_position 320.0 196.0 GXT 'SHTR_3B'  
01BD: " + _5595 + @" = current_time_in_ms 
0084: " + _5596 + @" = " + _5595 + @" 
0060: " + _5596 + @" -= " + _5594 + @" 
if 
  " + _5596 + @" > 5000 
else_jump @SHTR_6257 
" + _6156 + @" = 2 

:SHTR_6257
if 
  " + _6156 + @" == 2 
else_jump @SHTR_6315 
if 
001C:   " + tmp_2062 + @"[9] > " + _5650 + @" 
else_jump @SHTR_6308 
" + _6156 + @" = 4 
jump @SHTR_6315 

:SHTR_6308
gosub @SHTR_11097 

:SHTR_6315
if 
  " + _6156 + @" == 3 
else_jump @SHTR_6347 
gosub @SHTR_11414 
gosub @SHTR_12477 

:SHTR_6347
if 
  " + _6156 + @" == 4 
else_jump @SHTR_6372 
gosub @SHTR_12477 

:SHTR_6372
if 
  " + _5648 + @" == 4 
else_jump @SHTR_6441 
if and
00E1:   player 0 pressed_key 15 
   not " + _6156 + @" == 1 
else_jump @SHTR_6441 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1066 
jump @SHTR_582 

:SHTR_6441
038D: draw_texture 25 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 25 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 25 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 25 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
if 
  " + _5648 + @" == 0 
else_jump @SHTR_6603 

:SHTR_6603
if 
  " + _5648 + @" == 4 
else_jump @SHTR_6760 
if 
  " + _6156 + @" == 4 
else_jump @SHTR_6760 
01BD: " + _5991 + @" = current_time_in_ms 
0084: " + _5990 + @" = " + _5991 + @" 
0060: " + _5990 + @" -= " + _5992 + @" 
if 
  10000 > " + _5990 + @" 
else_jump @SHTR_6760 
0937: text_draw_box_cornerA 35.0 15.0 cornerB 200.0 45.0 GXT_reference 'DUMMY' style 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 230.0 
0349: set_text_draw_font 1 
033F: set_text_draw_letter_size 0.5 1.8 
033E: set_draw_text_position 40.0 20.0 GXT 'SH_BCK'  

:SHTR_6760
jump @SHTR_761 

:SHTR_6767
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
return 
return 

:SHTR_6787
03D5: remove_text 'BUSY'  
0391: release_textures 
040D: unload_wav 4 
09F5: disable_player_mutal_activities 0 
043C: disable_sounds_after_fadeout 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1063 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @SHTR_6936 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + X_Pershing_Square_LS + @" " + Y_Pershing_Square_LS + @" " + Z_Pershing_Square_LS + @" radius 2.0 2.0 2.0 on_foot 
else_jump @SHTR_6922 
0086: " + tempvar_Float_2 + @" = " + Y_Pershing_Square_LS + @" 
" + tempvar_Float_2 + @" += 2.0 
Actor.PutAt(" + PlayerActor + @", " + X_Pershing_Square_LS + @", " + tempvar_Float_2 + @", " + Z_Pershing_Square_LS + @")

:SHTR_6922
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
Player.CanMove(" + PlayerChar + @") = True

:SHTR_6936
" + OnMission + @" = 0 
mission_cleanup 
return 

:SHTR_6947
0340: set_text_draw_RGBA 255 255 255 255 
033F: set_text_draw_letter_size 1.0 2.0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
return 

:SHTR_6986
0086: " + _5587 + @" = " + _5588 + @" 
" + _5587 + @" -= 256.0 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 336.0 size 256.0 256.0 RGBA 150 150 150 255 
0086: " + _5587 + @" = " + _5588 + @" 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 336.0 size 256.0 256.0 RGBA 150 150 150 255 
0086: " + _5587 + @" = " + _5588 + @" 
" + _5587 + @" += 256.0 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 336.0 size 256.0 256.0 RGBA 150 150 150 255 
0086: " + _5587 + @" = " + _5588 + @" 
" + _5587 + @" += 512.0 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 336.0 size 256.0 256.0 RGBA 150 150 150 255 
0080: " + _5588 + @" -= frame_delta_time * " + _5589 + @" 
if 
  0.0 > " + _5588 + @" 
else_jump @SHTR_7227 
" + _5588 + @" += 256.0 

:SHTR_7227
return 

:SHTR_7229
0086: " + _5587 + @" = " + _5588 + @" 
" + _5587 + @" -= 256.0 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 112.0 size 256.0 256.0 RGBA 150 150 150 255 
0086: " + _5587 + @" = " + _5588 + @" 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 112.0 size 256.0 256.0 RGBA 150 150 150 255 
0086: " + _5587 + @" = " + _5588 + @" 
" + _5587 + @" += 256.0 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 112.0 size 256.0 256.0 RGBA 150 150 150 255 
0086: " + _5587 + @" = " + _5588 + @" 
" + _5587 + @" += 512.0 
038D: draw_texture " + _5593 + @" position " + _5587 + @" 112.0 size 256.0 256.0 RGBA 150 150 150 255 
0080: " + _5588 + @" -= frame_delta_time * " + _5590 + @" 
if 
  0.0 > " + _5588 + @" 
else_jump @SHTR_7470 
" + _5588 + @" += 256.0 

:SHTR_7470
return 

:SHTR_7472
if 
001F:   33@ > " + _5656 + @" 
else_jump @SHTR_7562 
if 
  " + tmp_5860 + @"(" + _5859 + @",16i) == 0 
else_jump @SHTR_7562 
0086: " + tmp_5877 + @"(" + _5859 + @",16f) = " + _5909 + @" 
0086: " + tmp_5925 + @"(" + _5859 + @",16f) = " + tmp_5925 + @"[0] 
" + tmp_5860 + @"(" + _5859 + @",16i) = 1 
33@ = 0 
" + _5655 + @" += 1 

:SHTR_7562
return 

:SHTR_7564
" + _5859 + @" = 0 

:SHTR_7571
if 
  8 > " + _5859 + @" 
else_jump @SHTR_8025 
if 
  " + tmp_5860 + @"(" + _5859 + @",16i) == 2 
else_jump @SHTR_8011 
01BD: " + tmp_5613 + @"(" + _5859 + @",16i) = current_time_in_ms 
0084: " + tmp_5629 + @"(" + _5859 + @",16i) = " + tmp_5613 + @"(" + _5859 + @",16i) 
0060: " + tmp_5629 + @"(" + _5859 + @",16i) -= " + tmp_5597 + @"(" + _5859 + @",16i) 
if and
  " + tmp_5629 + @"(" + _5859 + @",16i) >= 0 
  100 > " + tmp_5629 + @"(" + _5859 + @",16i) 
else_jump @SHTR_7725 
038D: draw_texture 15 position " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_7725
if and
  " + tmp_5629 + @"(" + _5859 + @",16i) >= 100 
  200 > " + tmp_5629 + @"(" + _5859 + @",16i) 
else_jump @SHTR_7799 
038D: draw_texture 16 position " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_7799
if and
  " + tmp_5629 + @"(" + _5859 + @",16i) >= 200 
  300 > " + tmp_5629 + @"(" + _5859 + @",16i) 
else_jump @SHTR_7874 
038D: draw_texture 17 position " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_7874
if and
  " + tmp_5629 + @"(" + _5859 + @",16i) >= 300 
  400 > " + tmp_5629 + @"(" + _5859 + @",16i) 
else_jump @SHTR_7949 
038D: draw_texture 18 position " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) size 32.0 32.0 RGBA 150 150 150 255 

:SHTR_7949
if 
  " + tmp_5629 + @"(" + _5859 + @",16i) > 499 
else_jump @SHTR_8011 
" + tmp_5877 + @"(" + _5859 + @",16f) = 0.0 
" + tmp_5893 + @"(" + _5859 + @",16f) = 0.0 
" + tmp_5860 + @"(" + _5859 + @",16i) = 0 

:SHTR_8011
" + _5859 + @" += 1 
jump @SHTR_7571 

:SHTR_8025
return 

:SHTR_8027
if 
  " + tmp_5860 + @"[0] == 0 
else_jump @SHTR_8787 
if 
  " + _5876 + @" == 0 
else_jump @SHTR_8787 
0208: " + _5909 + @" = random_float_in_ranges 640.0 720.0 
0086: " + tmp_5877 + @"[0] = " + _5909 + @" 
0208: " + _5942 + @" = random_float_in_ranges 240.0 640.0 
0208: " + _5946 + @" = random_float_in_ranges 80.0 368.0 
0086: " + _5947 + @" = " + _5946 + @" 
0061: " + _5947 + @" -= " + _5949 + @" 
if 
  80.0 > " + _5947 + @" 
else_jump @SHTR_8161 
0059: " + _5946 + @" += " + _5949 + @" 

:SHTR_8161
0086: " + _5948 + @" = " + _5946 + @" 
0059: " + _5948 + @" += " + _5949 + @" 
if 
  80.0 > " + _5948 + @" 
else_jump @SHTR_8206 
0061: " + _5946 + @" -= " + _5949 + @" 

:SHTR_8206
0208: " + tmp_5925 + @"[0] = random_float_in_ranges " + _5653 + @" " + _5654 + @" 
if and
  " + tmp_5925 + @"[0] >= 1.0 
  1.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8256 
" + _5656 + @" = 500 

:SHTR_8256
if and
  " + tmp_5925 + @"[0] >= 1.5 
  2.0 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8295 
" + _5656 + @" = 475 

:SHTR_8295
if and
  " + tmp_5925 + @"[0] >= 2.0 
  2.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8334 
" + _5656 + @" = 450 

:SHTR_8334
if and
  " + tmp_5925 + @"[0] >= 2.5 
  3.0 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8373 
" + _5656 + @" = 425 

:SHTR_8373
if and
  " + tmp_5925 + @"[0] >= 3.0 
  3.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8412 
" + _5656 + @" = 400 

:SHTR_8412
if and
  " + tmp_5925 + @"[0] >= 3.5 
  4.0 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8451 
" + _5656 + @" = 375 

:SHTR_8451
if and
  " + tmp_5925 + @"[0] >= 4.0 
  4.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8490 
" + _5656 + @" = 350 

:SHTR_8490
if and
  " + tmp_5925 + @"[0] >= 4.5 
  5.0 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8529 
" + _5656 + @" = 325 

:SHTR_8529
if and
  " + tmp_5925 + @"[0] >= 5.0 
  5.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8568 
" + _5656 + @" = 300 

:SHTR_8568
if and
  " + tmp_5925 + @"[0] >= 5.5 
  6.0 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8607 
" + _5656 + @" = 275 

:SHTR_8607
if and
  " + tmp_5925 + @"[0] >= 6.0 
  6.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8646 
" + _5656 + @" = 250 

:SHTR_8646
if and
  " + tmp_5925 + @"[0] >= 6.5 
  7.0 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8685 
" + _5656 + @" = 225 

:SHTR_8685
if and
  " + tmp_5925 + @"[0] >= 7.0 
  7.5 > " + tmp_5925 + @"[0] 
else_jump @SHTR_8724 
" + _5656 + @" = 200 

:SHTR_8724
if and
  " + tmp_5925 + @"[0] >= 7.5 
  8.0 >= " + tmp_5925 + @"[0] 
else_jump @SHTR_8763 
" + _5656 + @" = 175 

:SHTR_8763
0209: " + _5959 + @" = random_int_in_ranges 100 1500 
" + tmp_5860 + @"[0] = 1 
" + _5876 + @" = 1 

:SHTR_8787
return 

:SHTR_8789
" + _5859 + @" = 0 

:SHTR_8796
if 
  8 > " + _5859 + @" 
else_jump @SHTR_9209 
if 
  " + tmp_5860 + @"(" + _5859 + @",16i) == 1 
else_jump @SHTR_9195 
038D: draw_texture 12 position " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) size 32.0 32.0 RGBA 150 150 150 255 
0080: " + tmp_5877 + @"(" + _5859 + @",16f) -= frame_delta_time * " + tmp_5925 + @"(" + _5859 + @",16f) 
0086: " + _5941 + @" = " + tmp_5877 + @"(" + _5859 + @",16f) 
0071: " + _5941 + @" /= " + _5942 + @" 
0086: " + _5943 + @" = " + _5941 + @" 
" + _5943 + @" *= 360.0 
02F6: " + _5944 + @" = sine " + _5943 + @" 
0086: " + _5945 + @" = " + _5944 + @" 
0069: " + _5945 + @" *= " + _5949 + @" 
0086: " + tmp_5893 + @"(" + _5859 + @",16f) = " + _5945 + @" 
0059: " + tmp_5893 + @"(" + _5859 + @",16f) += " + _5946 + @" 
if 
  0.0 > " + tmp_5877 + @"(" + _5859 + @",16f) 
else_jump @SHTR_9195 
" + tmp_5877 + @"(" + _5859 + @",16f) = 0.0 
" + tmp_5893 + @"(" + _5859 + @",16f) = 0.0 
if 
  " + _5650 + @" > 24 
else_jump @SHTR_9184 
if 
003A:   " + _5650 + @" == " + _5651 + @" 
else_jump @SHTR_9177 
if and
001C:   " + _5650 + @" > " + tmp_2062 + @"[0] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[1] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[2] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[3] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[4] 
else_jump @SHTR_9177 
if and
001C:   " + _5650 + @" > " + tmp_2062 + @"[5] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[6] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[7] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[8] 
001C:   " + _5650 + @" > " + tmp_2062 + @"[9] 
else_jump @SHTR_9177 
" + _5651 + @" -= 25 

:SHTR_9177
" + _5650 + @" -= 25 

:SHTR_9184
" + tmp_5860 + @"(" + _5859 + @",16i) = 0 

:SHTR_9195
" + _5859 + @" += 1 
jump @SHTR_8796 

:SHTR_9209
return 

:SHTR_9211
" + _5657 + @" = 1 

:SHTR_9218
if 
  16 > " + _5657 + @" 
else_jump @SHTR_9634 
if 
  " + tmp_5659 + @"(" + _5657 + @",16i) == 1 
else_jump @SHTR_9356 
038D: draw_texture 11 position " + tmp_5675 + @"(" + _5657 + @",16f) " + tmp_5691 + @"(" + _5657 + @",16f) size " + _5853 + @" " + _5853 + @" RGBA 150 150 150 255 
007A: " + tmp_5675 + @"(" + _5657 + @",16f) += frame_delta_time * " + _5591 + @" 
if 
  " + tmp_5675 + @"(" + _5657 + @",16f) > 639.0 
else_jump @SHTR_9356 
" + tmp_5691 + @"(" + _5657 + @",16f) = 0.0 
" + tmp_5659 + @"(" + _5657 + @",16i) = 0 

:SHTR_9356
if 
  " + tmp_5725 + @"(" + _5657 + @",16i) == 1 
else_jump @SHTR_9488 
038D: draw_texture 11 position " + tmp_5741 + @"(" + _5657 + @",16f) " + tmp_5757 + @"(" + _5657 + @",16f) size " + _5853 + @" " + _5853 + @" RGBA 150 150 150 255 
007A: " + tmp_5741 + @"(" + _5657 + @",16f) += frame_delta_time * " + _5857 + @" 
0080: " + tmp_5757 + @"(" + _5657 + @",16f) -= frame_delta_time * " + _5858 + @" 
if 
  " + tmp_5741 + @"(" + _5657 + @",16f) > 639.0 
else_jump @SHTR_9488 
" + tmp_5757 + @"(" + _5657 + @",16f) = 0.0 
" + tmp_5725 + @"(" + _5657 + @",16i) = 0 

:SHTR_9488
if 
  " + tmp_5789 + @"(" + _5657 + @",16i) == 1 
else_jump @SHTR_9620 
038D: draw_texture 11 position " + tmp_5805 + @"(" + _5657 + @",16f) " + tmp_5821 + @"(" + _5657 + @",16f) size " + _5853 + @" " + _5853 + @" RGBA 150 150 150 255 
007A: " + tmp_5805 + @"(" + _5657 + @",16f) += frame_delta_time * " + _5857 + @" 
007A: " + tmp_5821 + @"(" + _5657 + @",16f) += frame_delta_time * " + _5858 + @" 
if 
  " + tmp_5805 + @"(" + _5657 + @",16f) > 639.0 
else_jump @SHTR_9620 
" + tmp_5821 + @"(" + _5657 + @",16f) = 0.0 
" + tmp_5789 + @"(" + _5657 + @",16i) = 0 

:SHTR_9620
" + _5657 + @" += 1 
jump @SHTR_9218 

:SHTR_9634
return 

:SHTR_9636
" + _5859 + @" = 0 

:SHTR_9643
if 
  8 > " + _5859 + @" 
else_jump @SHTR_10137 
if 
  " + tmp_5877 + @"(" + _5859 + @",16f) > 320.0 
else_jump @SHTR_9840 
if 
  " + _5989 + @" == 0 
else_jump @SHTR_9840 
if 
  " + tmp_5860 + @"(" + _5859 + @",16i) == 1 
else_jump @SHTR_9840 
if 
  " + tmp_5981 + @"(" + _5859 + @",8i) == 0 
else_jump @SHTR_9840 
0086: " + tmp_5965 + @"(" + _5859 + @",8f) = " + tmp_5877 + @"(" + _5859 + @",16f) 
0086: " + tmp_5973 + @"(" + _5859 + @",8f) = " + tmp_5893 + @"(" + _5859 + @",16f) 
" + tmp_5981 + @"(" + _5859 + @",8i) = 1 
" + _5989 + @" += 1 
0086: " + _5964 + @" = " + tmp_5925 + @"(" + _5859 + @",16f) 
" + _5964 + @" *= 1.5 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1060 

:SHTR_9840
if 
  " + _5989 + @" == 1 
else_jump @SHTR_10123 
if 
  " + tmp_5981 + @"(" + _5859 + @",8i) == 1 
else_jump @SHTR_10123 
if 
  " + _5580 + @" == 1 
else_jump @SHTR_10004 
if 
05A5:   is_area_center " + _5575 + @" " + _5576 + @" scale 32.0 32.0 overlaping_area_center " + tmp_5965 + @"(" + _5859 + @",8f) " + tmp_5973 + @"(" + _5859 + @",8f) scale 8.0 8.0 
else_jump @SHTR_10004 
" + tmp_5981 + @"(" + _5859 + @",8i) = 0 
" + tmp_5965 + @"(" + _5859 + @",8f) = 0.0 
" + tmp_5973 + @"(" + _5859 + @",8f) = 0.0 
" + _5989 + @" = 0 
" + _5580 + @" = 0 

:SHTR_10004
038D: draw_texture 14 position " + tmp_5965 + @"(" + _5859 + @",8f) " + tmp_5973 + @"(" + _5859 + @",8f) size " + _5853 + @" " + _5853 + @" RGBA 150 150 150 255 
0080: " + tmp_5965 + @"(" + _5859 + @",8f) -= frame_delta_time * " + _5964 + @" 
if 
  0.0 > " + tmp_5965 + @"(" + _5859 + @",8f) 
else_jump @SHTR_10123 
" + tmp_5981 + @"(" + _5859 + @",8i) = 0 
" + tmp_5965 + @"(" + _5859 + @",8f) = 0.0 
" + tmp_5973 + @"(" + _5859 + @",8f) = 0.0 
" + _5989 + @" = 0 

:SHTR_10123
" + _5859 + @" += 1 
jump @SHTR_9643 

:SHTR_10137
return 

:SHTR_10139
" + _5859 + @" = 0 

:SHTR_10146
if 
  8 > " + _5859 + @" 
else_jump @SHTR_11095 
if 
  " + tmp_5860 + @"(" + _5859 + @",16i) == 1 
else_jump @SHTR_10945 
" + _5657 + @" = 1 

:SHTR_10193
if 
  16 > " + _5657 + @" 
else_jump @SHTR_10945 
if 
05A5:   is_area_center " + tmp_5675 + @"(" + _5657 + @",16f) " + tmp_5691 + @"(" + _5657 + @",16f) scale " + _5723 + @" " + _5724 + @" overlaping_area_center " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) scale " + _5585 + @" " + _5586 + @" 
else_jump @SHTR_10451 
" + _5650 + @" += 100 
" + tmp_5860 + @"(" + _5859 + @",16i) = 2 
" + tmp_5659 + @"(" + _5657 + @",16i) = 0 
" + tmp_5675 + @"(" + _5657 + @",16f) = 0.0 
" + tmp_5691 + @"(" + _5657 + @",16f) = 0.0 
01BD: " + tmp_5597 + @"(" + _5859 + @",16i) = current_time_in_ms 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1061 
" + _5950 + @" += 1 
if 
  " + _5951 + @" == 1 
else_jump @SHTR_10451 
if 
  " + _5950 + @" == 8 
else_jump @SHTR_10431 
0086: " + _5954 + @" = " + tmp_5877 + @"(" + _5859 + @",16f) 
0086: " + _5955 + @" = " + tmp_5893 + @"(" + _5859 + @",16f) 
" + _5951 + @" = 0 
jump @SHTR_10451 

:SHTR_10431
" + _5954 + @" = 0.0 
" + _5955 + @" = 0.0 

:SHTR_10451
if 
05A5:   is_area_center " + tmp_5741 + @"(" + _5657 + @",16f) " + tmp_5757 + @"(" + _5657 + @",16f) scale " + _5723 + @" " + _5724 + @" overlaping_area_center " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) scale " + _5585 + @" " + _5586 + @" 
else_jump @SHTR_10691 
" + _5650 + @" += 100 
" + tmp_5860 + @"(" + _5859 + @",16i) = 2 
" + tmp_5725 + @"(" + _5657 + @",16i) = 0 
" + tmp_5741 + @"(" + _5657 + @",16f) = 0.0 
" + tmp_5757 + @"(" + _5657 + @",16f) = 0.0 
01BD: " + tmp_5597 + @"(" + _5859 + @",16i) = current_time_in_ms 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1061 
" + _5950 + @" += 1 
if 
  " + _5951 + @" == 1 
else_jump @SHTR_10691 
if 
  " + _5950 + @" == 8 
else_jump @SHTR_10671 
0086: " + _5954 + @" = " + tmp_5877 + @"(" + _5859 + @",16f) 
0086: " + _5955 + @" = " + tmp_5893 + @"(" + _5859 + @",16f) 
" + _5951 + @" = 0 
jump @SHTR_10691 

:SHTR_10671
" + _5954 + @" = 0.0 
" + _5955 + @" = 0.0 

:SHTR_10691
if 
05A5:   is_area_center " + tmp_5805 + @"(" + _5657 + @",16f) " + tmp_5821 + @"(" + _5657 + @",16f) scale " + _5723 + @" " + _5724 + @" overlaping_area_center " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) scale " + _5585 + @" " + _5586 + @" 
else_jump @SHTR_10931 
" + _5650 + @" += 100 
" + tmp_5860 + @"(" + _5859 + @",16i) = 2 
" + tmp_5789 + @"(" + _5657 + @",16i) = 0 
" + tmp_5805 + @"(" + _5657 + @",16f) = 0.0 
" + tmp_5821 + @"(" + _5657 + @",16f) = 0.0 
01BD: " + tmp_5597 + @"(" + _5859 + @",16i) = current_time_in_ms 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1061 
" + _5950 + @" += 1 
if 
  " + _5951 + @" == 1 
else_jump @SHTR_10931 
if 
  " + _5950 + @" == 8 
else_jump @SHTR_10911 
0086: " + _5954 + @" = " + tmp_5877 + @"(" + _5859 + @",16f) 
0086: " + _5955 + @" = " + tmp_5893 + @"(" + _5859 + @",16f) 
" + _5951 + @" = 0 
jump @SHTR_10931 

:SHTR_10911
" + _5954 + @" = 0.0 
" + _5955 + @" = 0.0 

:SHTR_10931
" + _5657 + @" += 1 
jump @SHTR_10193 

:SHTR_10945
if 
  " + tmp_5860 + @"(" + _5859 + @",16i) == 1 
else_jump @SHTR_11081 
if 
  " + _5580 + @" == 1 
else_jump @SHTR_11081 
if 
05A5:   is_area_center " + _5575 + @" " + _5576 + @" scale 32.0 32.0 overlaping_area_center " + tmp_5877 + @"(" + _5859 + @",16f) " + tmp_5893 + @"(" + _5859 + @",16f) scale " + _5585 + @" " + _5586 + @" 
else_jump @SHTR_11081 
" + tmp_5860 + @"(" + _5859 + @",16i) = 2 
01BD: " + tmp_5597 + @"(" + _5859 + @",16i) = current_time_in_ms 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1061 
" + _5580 + @" = 0 

:SHTR_11081
" + _5859 + @" += 1 
jump @SHTR_10146 

:SHTR_11095
return 

:SHTR_11097
" + _6151 + @" = 9 
" + _6152 + @" = 0 
" + _6153 + @" = 1 

:SHTR_11118
if and
  " + _6151 + @" >= 0 
  " + _6153 + @" == 1 
else_jump @SHTR_11215 
if 
001C:   " + _5650 + @" > " + tmp_2062 + @"(" + _6151 + @",10i) 
else_jump @SHTR_11201 
" + _6151 + @" -= 1 
" + _6152 + @" = 1 
" + _6156 + @" = 3 
" + _6069 + @" = 1 
jump @SHTR_11208 

:SHTR_11201
" + _6153 + @" = 0 

:SHTR_11208
jump @SHTR_11118 

:SHTR_11215
if 
  " + _6152 + @" == 1 
else_jump @SHTR_11412 
" + _6151 + @" += 1 
" + _6154 + @" = 9 
" + _6155 + @" = 8 

:SHTR_11254
if 
002C:   " + _6155 + @" >= " + _6151 + @" 
else_jump @SHTR_11374 
05A9: " + tmp_2002 + @"(" + _6154 + @",10s) = " + tmp_2002 + @"(" + _6155 + @",10s) 
05A9: " + tmp_2022 + @"(" + _6154 + @",10s) = " + tmp_2022 + @"(" + _6155 + @",10s) 
05A9: " + tmp_2042 + @"(" + _6154 + @",10s) = " + tmp_2042 + @"(" + _6155 + @",10s) 
0084: " + tmp_2072 + @"(" + _6154 + @",10i) = " + tmp_2072 + @"(" + _6155 + @",10i) 
0084: " + tmp_2062 + @"(" + _6154 + @",10i) = " + tmp_2062 + @"(" + _6155 + @",10i) 
" + _6154 + @" -= 1 
" + _6155 + @" -= 1 
jump @SHTR_11254 

:SHTR_11374
0084: " + tmp_2062 + @"(" + _6151 + @",10i) = " + _5650 + @" 
0084: " + tmp_2072 + @"(" + _6151 + @",10i) = " + _6157 + @" 
" + _6158 + @" = 0 
" + _6067 + @" = 10 

:SHTR_11412
return 

:SHTR_11414
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if and
80E1:   not player 0 pressed_key 8 
80E1:   not player 0 pressed_key 9 
80E1:   not player 0 pressed_key 10 
80E1:   not player 0 pressed_key 11 
80E1:   not player 0 pressed_key 16 
else_jump @SHTR_11503 
if and
  " + Move_Axis_Y + @" == 0 
  " + Move_Axis_X + @" == 0 
else_jump @SHTR_11503 
" + _6068 + @" = 0 

:SHTR_11503
if 
  " + _6158 + @" == 0 
else_jump @SHTR_11843 
05A9: " + tmp_2002 + @"(" + _6151 + @",10s) = " + tmp_SHTR_characters + @"(" + _6067 + @",37s) 
05A9: " + tmp_2022 + @"(" + _6151 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
05A9: " + tmp_2042 + @"(" + _6151 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
if 
  " + _6068 + @" == 0 
else_jump @SHTR_11843 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_Y + @" 
else_jump @SHTR_11682 
if 
  36 > " + _6067 + @" 
else_jump @SHTR_11648 
" + _6067 + @" += 1 
jump @SHTR_11655 

:SHTR_11648
" + _6067 + @" = 0 

:SHTR_11655
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
" + _6068 + @" = 1 

:SHTR_11682
if or
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_Y + @" > 100 
else_jump @SHTR_11785 
if 
  " + _6067 + @" > 0 
else_jump @SHTR_11751 
" + _6067 + @" -= 1 
jump @SHTR_11758 

:SHTR_11751
" + _6067 + @" = 36 

:SHTR_11758
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
" + _6068 + @" = 1 

:SHTR_11785
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_11843 
" + _6067 + @" = 10 
" + _6158 + @" = 1 
" + _6068 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_11843
if 
  " + _6158 + @" == 1 
else_jump @SHTR_12159 
05A9: " + tmp_2022 + @"(" + _6151 + @",10s) = " + tmp_SHTR_characters + @"(" + _6067 + @",37s) 
if 
  " + _6068 + @" == 0 
else_jump @SHTR_12159 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_Y + @" 
else_jump @SHTR_11998 
if 
  36 > " + _6067 + @" 
else_jump @SHTR_11964 
" + _6067 + @" += 1 
jump @SHTR_11971 

:SHTR_11964
" + _6067 + @" = 0 

:SHTR_11971
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
" + _6068 + @" = 1 

:SHTR_11998
if or
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_Y + @" > 100 
else_jump @SHTR_12101 
if 
  " + _6067 + @" > 0 
else_jump @SHTR_12067 
" + _6067 + @" -= 1 
jump @SHTR_12074 

:SHTR_12067
" + _6067 + @" = 36 

:SHTR_12074
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
" + _6068 + @" = 1 

:SHTR_12101
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_12159 
" + _6067 + @" = 10 
" + _6158 + @" = 2 
" + _6068 + @" = 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_12159
if 
  " + _6158 + @" == 2 
else_jump @SHTR_12475 
05A9: " + tmp_2042 + @"(" + _6151 + @",10s) = " + tmp_SHTR_characters + @"(" + _6067 + @",37s) 
if 
  " + _6068 + @" == 0 
else_jump @SHTR_12475 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_Y + @" 
else_jump @SHTR_12314 
if 
  36 > " + _6067 + @" 
else_jump @SHTR_12280 
" + _6067 + @" += 1 
jump @SHTR_12287 

:SHTR_12280
" + _6067 + @" = 0 

:SHTR_12287
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
" + _6068 + @" = 1 

:SHTR_12314
if or
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
  " + Move_Axis_Y + @" > 100 
else_jump @SHTR_12417 
if 
  " + _6067 + @" > 0 
else_jump @SHTR_12383 
" + _6067 + @" -= 1 
jump @SHTR_12390 

:SHTR_12383
" + _6067 + @" = 36 

:SHTR_12390
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1064 
" + _6068 + @" = 1 

:SHTR_12417
if 
00E1:   player 0 pressed_key 16 
else_jump @SHTR_12475 
" + _6158 + @" = 3 
" + _6068 + @" = 1 
" + _6156 + @" = 4 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1065 

:SHTR_12475
return 

:SHTR_12477
" + _6070 + @" = 0 

:SHTR_12484
if 
  10 > " + _6070 + @" 
else_jump @SHTR_12649 
gosub @SHTR_6947 
033E: set_draw_text_position " + tmp_6071 + @"(" + _6070 + @",10f) " + tmp_6111 + @"(" + _6070 + @",10f) GXT " + tmp_2002 + @"(" + _6070 + @",10s) 
gosub @SHTR_6947 
033E: set_draw_text_position " + tmp_6081 + @"(" + _6070 + @",10f) " + tmp_6121 + @"(" + _6070 + @",10f) GXT " + tmp_2022 + @"(" + _6070 + @",10s) 
gosub @SHTR_6947 
033E: set_draw_text_position " + tmp_6091 + @"(" + _6070 + @",10f) " + tmp_6131 + @"(" + _6070 + @",10f) GXT " + tmp_2042 + @"(" + _6070 + @",10s) 
gosub @SHTR_6947 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_6101 + @"(" + _6070 + @",10f) " + tmp_6141 + @"(" + _6070 + @",10f) GXT 'SHTR_LV' number " + tmp_2062 + @"(" + _6070 + @",10i)  
" + _6070 + @" += 1 
jump @SHTR_12484 

:SHTR_12649
gosub @SHTR_6947 
033E: set_draw_text_position 320.0 64.0 GXT 'SHTR_2F'  
if and
  " + _5649 + @" == 0 
  " + _6069 + @" == 1 
else_jump @SHTR_13084 
if 
  " + _6158 + @" == 0 
else_jump @SHTR_12769 
gosub @SHTR_6947 
0340: set_text_draw_RGBA 0 255 0 255 
033E: set_draw_text_position " + tmp_6071 + @"(" + _6151 + @",10f) " + tmp_6111 + @"(" + _6151 + @",10f) GXT " + tmp_2002 + @"(" + _6151 + @",10s) 
jump @SHTR_12811 

:SHTR_12769
gosub @SHTR_6947 
0340: set_text_draw_RGBA 255 0 0 255 
033E: set_draw_text_position " + tmp_6071 + @"(" + _6151 + @",10f) " + tmp_6111 + @"(" + _6151 + @",10f) GXT " + tmp_2002 + @"(" + _6151 + @",10s) 

:SHTR_12811
if 
  " + _6158 + @" == 1 
else_jump @SHTR_12878 
gosub @SHTR_6947 
0340: set_text_draw_RGBA 0 255 0 255 
033E: set_draw_text_position " + tmp_6081 + @"(" + _6151 + @",10f) " + tmp_6121 + @"(" + _6151 + @",10f) GXT " + tmp_2022 + @"(" + _6151 + @",10s) 
jump @SHTR_12920 

:SHTR_12878
gosub @SHTR_6947 
0340: set_text_draw_RGBA 255 0 0 255 
033E: set_draw_text_position " + tmp_6081 + @"(" + _6151 + @",10f) " + tmp_6121 + @"(" + _6151 + @",10f) GXT " + tmp_2022 + @"(" + _6151 + @",10s) 

:SHTR_12920
if 
  " + _6158 + @" == 2 
else_jump @SHTR_12987 
gosub @SHTR_6947 
0340: set_text_draw_RGBA 0 255 0 255 
033E: set_draw_text_position " + tmp_6091 + @"(" + _6151 + @",10f) " + tmp_6131 + @"(" + _6151 + @",10f) GXT " + tmp_2042 + @"(" + _6151 + @",10s) 
jump @SHTR_13029 

:SHTR_12987
gosub @SHTR_6947 
0340: set_text_draw_RGBA 255 0 0 255 
033E: set_draw_text_position " + tmp_6091 + @"(" + _6151 + @",10f) " + tmp_6131 + @"(" + _6151 + @",10f) GXT " + tmp_2042 + @"(" + _6151 + @",10s) 

:SHTR_13029
gosub @SHTR_6947 
0340: set_text_draw_RGBA 255 0 0 255 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_6101 + @"(" + _6151 + @",10f) " + tmp_6141 + @"(" + _6151 + @",10f) GXT 'SHTR_LV' number " + tmp_2062 + @"(" + _6151 + @",10i)  

:SHTR_13084
return 

:SHTR_13086
0209: " + _6161 + @" = random_int_in_ranges 1 30 
if 
  " + _6161 + @" == 1 
else_jump @SHTR_13188 
if 
  " + _6163 + @" == 0 
else_jump @SHTR_13181 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[23] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[15] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[36] 
" + _6163 + @" = 1 
jump @SHTR_13188 

:SHTR_13181
jump @SHTR_13086 

:SHTR_13188
if 
  " + _6161 + @" == 2 
else_jump @SHTR_13281 
if 
  " + _6164 + @" == 0 
else_jump @SHTR_13274 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[18] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[22] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[34] 
" + _6164 + @" = 1 
jump @SHTR_13281 

:SHTR_13274
jump @SHTR_13086 

:SHTR_13281
if 
  " + _6161 + @" == 3 
else_jump @SHTR_13374 
if 
  " + _6165 + @" == 0 
else_jump @SHTR_13367 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[18] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[21] 
" + _6165 + @" = 1 
jump @SHTR_13374 

:SHTR_13367
jump @SHTR_13086 

:SHTR_13374
if 
  " + _6161 + @" == 4 
else_jump @SHTR_13467 
if 
  " + _6166 + @" == 0 
else_jump @SHTR_13460 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[12] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[20] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[27] 
" + _6166 + @" = 1 
jump @SHTR_13467 

:SHTR_13460
jump @SHTR_13086 

:SHTR_13467
if 
  " + _6161 + @" == 5 
else_jump @SHTR_13560 
if 
  " + _6167 + @" == 0 
else_jump @SHTR_13553 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[11] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[25] 
" + _6167 + @" = 1 
jump @SHTR_13560 

:SHTR_13553
jump @SHTR_13086 

:SHTR_13560
if 
  " + _6161 + @" == 6 
else_jump @SHTR_13653 
if 
  " + _6168 + @" == 0 
else_jump @SHTR_13646 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[31] 
" + _6168 + @" = 1 
jump @SHTR_13653 

:SHTR_13646
jump @SHTR_13086 

:SHTR_13653
if 
  " + _6161 + @" == 7 
else_jump @SHTR_13746 
if 
  " + _6169 + @" == 0 
else_jump @SHTR_13739 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[24] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
" + _6169 + @" = 1 
jump @SHTR_13746 

:SHTR_13739
jump @SHTR_13086 

:SHTR_13746
if 
  " + _6161 + @" == 8 
else_jump @SHTR_13839 
if 
  " + _6170 + @" == 0 
else_jump @SHTR_13832 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[28] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[19] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[21] 
" + _6170 + @" = 1 
jump @SHTR_13839 

:SHTR_13832
jump @SHTR_13086 

:SHTR_13839
if 
  " + _6161 + @" == 9 
else_jump @SHTR_13932 
if 
  " + _6171 + @" == 0 
else_jump @SHTR_13925 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[28] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[29] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[14] 
" + _6171 + @" = 1 
jump @SHTR_13932 

:SHTR_13925
jump @SHTR_13086 

:SHTR_13932
if 
  " + _6161 + @" == 10 
else_jump @SHTR_14025 
if 
  " + _6172 + @" == 0 
else_jump @SHTR_14018 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[19] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[30] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
" + _6172 + @" = 1 
jump @SHTR_14025 

:SHTR_14018
jump @SHTR_13086 

:SHTR_14025
if 
  " + _6161 + @" == 11 
else_jump @SHTR_14118 
if 
  " + _6173 + @" == 0 
else_jump @SHTR_14111 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[20] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[22] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[11] 
" + _6173 + @" = 1 
jump @SHTR_14118 

:SHTR_14111
jump @SHTR_13086 

:SHTR_14118
if 
  " + _6161 + @" == 12 
else_jump @SHTR_14211 
if 
  " + _6174 + @" == 0 
else_jump @SHTR_14204 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[16] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[28] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
" + _6174 + @" = 1 
jump @SHTR_14211 

:SHTR_14204
jump @SHTR_13086 

:SHTR_14211
if 
  " + _6161 + @" == 13 
else_jump @SHTR_14304 
if 
  " + _6175 + @" == 0 
else_jump @SHTR_14297 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[28] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
" + _6175 + @" = 1 
jump @SHTR_14304 

:SHTR_14297
jump @SHTR_13086 

:SHTR_14304
if 
  " + _6161 + @" == 14 
else_jump @SHTR_14397 
if 
  " + _6176 + @" == 0 
else_jump @SHTR_14390 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[34] 
" + _6176 + @" = 1 
jump @SHTR_14397 

:SHTR_14390
jump @SHTR_13086 

:SHTR_14397
if 
  " + _6161 + @" == 15 
else_jump @SHTR_14490 
if 
  " + _6177 + @" == 0 
else_jump @SHTR_14483 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[16] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[35] 
" + _6177 + @" = 1 
jump @SHTR_14490 

:SHTR_14483
jump @SHTR_13086 

:SHTR_14490
if 
  " + _6161 + @" == 16 
else_jump @SHTR_14583 
if 
  " + _6178 + @" == 0 
else_jump @SHTR_14576 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[35] 
" + _6178 + @" = 1 
jump @SHTR_14583 

:SHTR_14576
jump @SHTR_13086 

:SHTR_14583
if 
  " + _6161 + @" == 17 
else_jump @SHTR_14676 
if 
  " + _6179 + @" == 0 
else_jump @SHTR_14669 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[20] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[18] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[23] 
" + _6179 + @" = 1 
jump @SHTR_14676 

:SHTR_14669
jump @SHTR_13086 

:SHTR_14676
if 
  " + _6161 + @" == 18 
else_jump @SHTR_14769 
if 
  " + _6180 + @" == 0 
else_jump @SHTR_14762 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[11] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[14] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
" + _6180 + @" = 1 
jump @SHTR_14769 

:SHTR_14762
jump @SHTR_13086 

:SHTR_14769
if 
  " + _6161 + @" == 19 
else_jump @SHTR_14862 
if 
  " + _6181 + @" == 0 
else_jump @SHTR_14855 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[11] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[33] 
" + _6181 + @" = 1 
jump @SHTR_14862 

:SHTR_14855
jump @SHTR_13086 

:SHTR_14862
if 
  " + _6161 + @" == 20 
else_jump @SHTR_14955 
if 
  " + _6182 + @" == 0 
else_jump @SHTR_14948 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[21] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[24] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[30] 
" + _6182 + @" = 1 
jump @SHTR_14955 

:SHTR_14948
jump @SHTR_13086 

:SHTR_14955
if 
  " + _6161 + @" == 21 
else_jump @SHTR_15048 
if 
  " + _6183 + @" == 0 
else_jump @SHTR_15041 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[19] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[23] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[24] 
" + _6183 + @" = 1 
jump @SHTR_15048 

:SHTR_15041
jump @SHTR_13086 

:SHTR_15048
if 
  " + _6161 + @" == 22 
else_jump @SHTR_15141 
if 
  " + _6184 + @" == 0 
else_jump @SHTR_15134 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[22] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[34] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[29] 
" + _6184 + @" = 1 
jump @SHTR_15141 

:SHTR_15134
jump @SHTR_13086 

:SHTR_15141
if 
  " + _6161 + @" == 23 
else_jump @SHTR_15234 
if 
  " + _6185 + @" == 0 
else_jump @SHTR_15227 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[13] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[14] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[15] 
" + _6185 + @" = 1 
jump @SHTR_15234 

:SHTR_15227
jump @SHTR_13086 

:SHTR_15234
if 
  " + _6161 + @" == 24 
else_jump @SHTR_15327 
if 
  " + _6186 + @" == 0 
else_jump @SHTR_15320 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[20] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[17] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[35] 
" + _6186 + @" = 1 
jump @SHTR_15327 

:SHTR_15320
jump @SHTR_13086 

:SHTR_15327
if 
  " + _6161 + @" == 25 
else_jump @SHTR_15420 
if 
  " + _6187 + @" == 0 
else_jump @SHTR_15413 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[22] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[14] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[24] 
" + _6187 + @" = 1 
jump @SHTR_15420 

:SHTR_15413
jump @SHTR_13086 

:SHTR_15420
if 
  " + _6161 + @" == 26 
else_jump @SHTR_15513 
if 
  " + _6188 + @" == 0 
else_jump @SHTR_15506 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[16] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[15] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
" + _6188 + @" = 1 
jump @SHTR_15513 

:SHTR_15506
jump @SHTR_13086 

:SHTR_15513
if 
  " + _6161 + @" == 27 
else_jump @SHTR_15606 
if 
  " + _6189 + @" == 0 
else_jump @SHTR_15599 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[27] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[22] 
" + _6189 + @" = 1 
jump @SHTR_15606 

:SHTR_15599
jump @SHTR_13086 

:SHTR_15606
if 
  " + _6161 + @" == 28 
else_jump @SHTR_15699 
if 
  " + _6190 + @" == 0 
else_jump @SHTR_15692 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[10] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[36] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[32] 
" + _6190 + @" = 1 
jump @SHTR_15699 

:SHTR_15692
jump @SHTR_13086 

:SHTR_15699
if 
  " + _6161 + @" == 29 
else_jump @SHTR_15792 
if 
  " + _6191 + @" == 0 
else_jump @SHTR_15785 
05A9: " + tmp_2002 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[27] 
05A9: " + tmp_2022 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[18] 
05A9: " + tmp_2042 + @"(" + _6160 + @",10s) = s" + tmp_SHTR_characters + @"[12] 
" + _6191 + @" = 1 
jump @SHTR_15792 

:SHTR_15785
jump @SHTR_13086 

:SHTR_15792
return 

:SHTR_15794
05A9: s" + tmp_SHTR_characters + @"[0] = 'SHTR_0' 
05A9: s" + tmp_SHTR_characters + @"[1] = 'SHTR_1' 
05A9: s" + tmp_SHTR_characters + @"[2] = 'SHTR_2' 
05A9: s" + tmp_SHTR_characters + @"[3] = 'SHTR_3' 
05A9: s" + tmp_SHTR_characters + @"[4] = 'SHTR_4' 
05A9: s" + tmp_SHTR_characters + @"[5] = 'SHTR_5' 
05A9: s" + tmp_SHTR_characters + @"[6] = 'SHTR_6' 
05A9: s" + tmp_SHTR_characters + @"[7] = 'SHTR_7' 
05A9: s" + tmp_SHTR_characters + @"[8] = 'SHTR_8' 
05A9: s" + tmp_SHTR_characters + @"[9] = 'SHTR_9' 
05A9: s" + tmp_SHTR_characters + @"[10] = 'SHTR_A' 
05A9: s" + tmp_SHTR_characters + @"[11] = 'SHTR_B' 
05A9: s" + tmp_SHTR_characters + @"[12] = 'SHTR_C' 
05A9: s" + tmp_SHTR_characters + @"[13] = 'SHTR_D' 
05A9: s" + tmp_SHTR_characters + @"[14] = 'SHTR_E' 
05A9: s" + tmp_SHTR_characters + @"[15] = 'SHTR_F' 
05A9: s" + tmp_SHTR_characters + @"[16] = 'SHTR_G' 
05A9: s" + tmp_SHTR_characters + @"[17] = 'SHTR_H' 
05A9: s" + tmp_SHTR_characters + @"[18] = 'SHTR_I' 
05A9: s" + tmp_SHTR_characters + @"[19] = 'SHTR_J' 
05A9: s" + tmp_SHTR_characters + @"[20] = 'SHTR_K' 
05A9: s" + tmp_SHTR_characters + @"[21] = 'SHTR_L' 
05A9: s" + tmp_SHTR_characters + @"[22] = 'SHTR_M' 
05A9: s" + tmp_SHTR_characters + @"[23] = 'SHTR_N' 
05A9: s" + tmp_SHTR_characters + @"[24] = 'SHTR_O' 
05A9: s" + tmp_SHTR_characters + @"[25] = 'SHTR_P' 
05A9: s" + tmp_SHTR_characters + @"[26] = 'SHTR_Q' 
05A9: s" + tmp_SHTR_characters + @"[27] = 'SHTR_R' 
05A9: s" + tmp_SHTR_characters + @"[28] = 'SHTR_S' 
05A9: s" + tmp_SHTR_characters + @"[29] = 'SHTR_T' 
05A9: s" + tmp_SHTR_characters + @"[30] = 'SHTR_U' 
05A9: s" + tmp_SHTR_characters + @"[31] = 'SHTR_V' 
05A9: s" + tmp_SHTR_characters + @"[32] = 'SHTR_W' 
05A9: s" + tmp_SHTR_characters + @"[33] = 'SHTR_X' 
05A9: s" + tmp_SHTR_characters + @"[34] = 'SHTR_Y' 
05A9: s" + tmp_SHTR_characters + @"[35] = 'SHTR_Z' 
05A9: s" + tmp_SHTR_characters + @"[36] = 'SHTR_PE' 
" + tmp_6071 + @"[0] = 176.0 
" + tmp_6111 + @"[0] = 96.0 
" + tmp_6081 + @"[0] = 224.0 
" + tmp_6121 + @"[0] = 96.0 
" + tmp_6091 + @"[0] = 272.0 
" + tmp_6131 + @"[0] = 96.0 
" + tmp_6101 + @"[0] = 464.0 
" + tmp_6141 + @"[0] = 96.0 
" + tmp_6071 + @"[1] = 176.0 
" + tmp_6111 + @"[1] = 128.0 
" + tmp_6081 + @"[1] = 224.0 
" + tmp_6121 + @"[1] = 128.0 
" + tmp_6091 + @"[1] = 272.0 
" + tmp_6131 + @"[1] = 128.0 
" + tmp_6101 + @"[1] = 464.0 
" + tmp_6141 + @"[1] = 128.0 
" + tmp_6071 + @"[2] = 176.0 
" + tmp_6111 + @"[2] = 160.0 
" + tmp_6081 + @"[2] = 224.0 
" + tmp_6121 + @"[2] = 160.0 
" + tmp_6091 + @"[2] = 272.0 
" + tmp_6131 + @"[2] = 160.0 
" + tmp_6101 + @"[2] = 464.0 
" + tmp_6141 + @"[2] = 160.0 
" + tmp_6071 + @"[3] = 176.0 
" + tmp_6111 + @"[3] = 192.0 
" + tmp_6081 + @"[3] = 224.0 
" + tmp_6121 + @"[3] = 192.0 
" + tmp_6091 + @"[3] = 272.0 
" + tmp_6131 + @"[3] = 192.0 
" + tmp_6101 + @"[3] = 464.0 
" + tmp_6141 + @"[3] = 192.0 
" + tmp_6071 + @"[4] = 176.0 
" + tmp_6111 + @"[4] = 224.0 
" + tmp_6081 + @"[4] = 224.0 
" + tmp_6121 + @"[4] = 224.0 
" + tmp_6091 + @"[4] = 272.0 
" + tmp_6131 + @"[4] = 224.0 
" + tmp_6101 + @"[4] = 464.0 
" + tmp_6141 + @"[4] = 224.0 
" + tmp_6071 + @"[5] = 176.0 
" + tmp_6111 + @"[5] = 256.0 
" + tmp_6081 + @"[5] = 224.0 
" + tmp_6121 + @"[5] = 256.0 
" + tmp_6091 + @"[5] = 272.0 
" + tmp_6131 + @"[5] = 256.0 
" + tmp_6101 + @"[5] = 464.0 
" + tmp_6141 + @"[5] = 256.0 
" + tmp_6071 + @"[6] = 176.0 
" + tmp_6111 + @"[6] = 288.0 
" + tmp_6081 + @"[6] = 224.0 
" + tmp_6121 + @"[6] = 288.0 
" + tmp_6091 + @"[6] = 272.0 
" + tmp_6131 + @"[6] = 288.0 
" + tmp_6101 + @"[6] = 464.0 
" + tmp_6141 + @"[6] = 288.0 
" + tmp_6071 + @"[7] = 176.0 
" + tmp_6111 + @"[7] = 320.0 
" + tmp_6081 + @"[7] = 224.0 
" + tmp_6121 + @"[7] = 320.0 
" + tmp_6091 + @"[7] = 272.0 
" + tmp_6131 + @"[7] = 320.0 
" + tmp_6101 + @"[7] = 464.0 
" + tmp_6141 + @"[7] = 320.0 
" + tmp_6071 + @"[8] = 176.0 
" + tmp_6111 + @"[8] = 352.0 
" + tmp_6081 + @"[8] = 224.0 
" + tmp_6121 + @"[8] = 352.0 
" + tmp_6091 + @"[8] = 272.0 
" + tmp_6131 + @"[8] = 352.0 
" + tmp_6101 + @"[8] = 464.0 
" + tmp_6141 + @"[8] = 352.0 
" + tmp_6071 + @"[9] = 176.0 
" + tmp_6111 + @"[9] = 384.0 
" + tmp_6081 + @"[9] = 224.0 
" + tmp_6121 + @"[9] = 384.0 
" + tmp_6091 + @"[9] = 272.0 
" + tmp_6131 + @"[9] = 384.0 
" + tmp_6101 + @"[9] = 464.0 
" + tmp_6141 + @"[9] = 384.0 
if 
  " + _6159 + @" == 0 
else_jump @SHTR_17436 
05A9: s" + tmp_2002 + @"[0] = s" + tmp_SHTR_characters + @"[12] 
05A9: s" + tmp_2022 + @"[0] = s" + tmp_SHTR_characters + @"[36] 
05A9: s" + tmp_2042 + @"[0] = s" + tmp_SHTR_characters + @"[36] 
" + tmp_2072 + @"[0] = 10 
" + tmp_2062 + @"[0] = 1000 
" + _6160 + @" = 1 
gosub @SHTR_13086 
" + tmp_2072 + @"[1] = 9 
" + tmp_2062 + @"[1] = 900 
" + _6160 + @" = 2 
gosub @SHTR_13086 
" + tmp_2072 + @"[2] = 8 
" + tmp_2062 + @"[2] = 800 
" + _6160 + @" = 3 
gosub @SHTR_13086 
" + tmp_2072 + @"[3] = 7 
" + tmp_2062 + @"[3] = 700 
" + _6160 + @" = 4 
gosub @SHTR_13086 
" + tmp_2072 + @"[4] = 6 
" + tmp_2062 + @"[4] = 600 
" + _6160 + @" = 5 
gosub @SHTR_13086 
" + tmp_2072 + @"[5] = 5 
" + tmp_2062 + @"[5] = 500 
" + _6160 + @" = 6 
gosub @SHTR_13086 
" + tmp_2072 + @"[6] = 4 
" + tmp_2062 + @"[6] = 400 
" + _6160 + @" = 7 
gosub @SHTR_13086 
" + tmp_2072 + @"[7] = 3 
" + tmp_2062 + @"[7] = 300 
" + _6160 + @" = 8 
gosub @SHTR_13086 
" + tmp_2072 + @"[8] = 2 
" + tmp_2062 + @"[8] = 200 
" + _6160 + @" = 9 
gosub @SHTR_13086 
" + tmp_2072 + @"[9] = 1 
" + tmp_2062 + @"[9] = 100 
" + _6159 + @" = 1 

:SHTR_17436
0084: " + _5651 + @" = " + tmp_2062 + @"[0] 
return 

:SHTR_17446
" + _5579 + @" = 1 
" + _5580 + @" = 1 
" + _5648 + @" = 1 
" + _5650 + @" = 0 
" + _5649 + @" = 2 
" + _5652 + @" = 0 
" + _5591 + @" = 15.0 
" + _5575 + @" = 80.0 
" + _5576 + @" = 224.0 
" + _5853 + @" = 8.0 
" + _5854 + @" = 10.0 
" + _5653 + @" = 1.0 
" + _5654 + @" = 3.0 
" + _5960 + @" = 0 
" + _5963 + @" = 7.0 
" + _5989 + @" = 0 
" + _5950 + @" = 0 
" + _5951 + @" = 1 
" + _5952 + @" = 31 
" + _5956 + @" = 250 
" + _5957 + @" = 0 
" + _5958 + @" = 0 
" + _5953 + @" = 0 
" + _6158 + @" = 0 
" + _6069 + @" = 0 
" + tmp_5877 + @"[0] = 660.0 
" + tmp_5877 + @"[1] = 660.0 
" + tmp_5877 + @"[2] = 660.0 
" + tmp_5877 + @"[3] = 660.0 
" + _5581 + @" = 0 
" + _5594 + @" = 0 
" + _5595 + @" = 0 
" + _5596 + @" = 0 
" + _5645 + @" = 0 
" + _5646 + @" = 0 
" + _5647 + @" = 0 
" + _5657 + @" = 1 
" + tmp_5659 + @"[1] = 0 
" + tmp_5659 + @"[2] = 0 
" + tmp_5659 + @"[3] = 0 
" + tmp_5659 + @"[4] = 0 
" + tmp_5659 + @"[5] = 0 
" + tmp_5659 + @"[6] = 0 
" + tmp_5659 + @"[7] = 0 
" + tmp_5659 + @"[8] = 0 
" + tmp_5725 + @"[1] = 0 
" + tmp_5725 + @"[2] = 0 
" + tmp_5725 + @"[3] = 0 
" + tmp_5725 + @"[4] = 0 
" + tmp_5725 + @"[5] = 0 
" + tmp_5725 + @"[6] = 0 
" + tmp_5725 + @"[7] = 0 
" + tmp_5725 + @"[8] = 0 
" + tmp_5789 + @"[1] = 0 
" + tmp_5789 + @"[2] = 0 
" + tmp_5789 + @"[3] = 0 
" + tmp_5789 + @"[4] = 0 
" + tmp_5789 + @"[5] = 0 
" + tmp_5789 + @"[6] = 0 
" + tmp_5789 + @"[7] = 0 
" + tmp_5789 + @"[8] = 0 
" + tmp_5860 + @"[0] = 0 
" + tmp_5860 + @"[1] = 0 
" + tmp_5860 + @"[2] = 0 
" + tmp_5860 + @"[3] = 0 
" + tmp_5860 + @"[4] = 0 
" + tmp_5860 + @"[5] = 0 
" + tmp_5860 + @"[6] = 0 
" + tmp_5860 + @"[7] = 0 
" + tmp_5981 + @"[0] = 0 
" + tmp_5981 + @"[1] = 0 
" + tmp_5981 + @"[2] = 0 
" + tmp_5981 + @"[3] = 0 
" + tmp_5981 + @"[4] = 0 
" + tmp_5981 + @"[5] = 0 
" + tmp_5981 + @"[6] = 0 
" + tmp_5981 + @"[7] = 0 
" + _5655 + @" = 0 
" + _5876 + @" = 0 
" + _5585 + @" = 32.0 
" + _5586 + @" = 32.0 
" + _5723 + @" = 8.0 
" + _5724 + @" = 8.0 
" + _5577 + @" = 32.0 
" + _5578 + @" = 32.0 
" + _5949 + @" = 0.0 
return" );
                /*

                */

            }

        }

    }

}