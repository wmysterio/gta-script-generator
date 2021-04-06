using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BLACKJ : External {

            Float tmp_BJACK_X_Player_Sprite = global( BJACK_X_Player_Sprite.startIndex ),
                  tmp_BJACK_Y_Player_Sprite = global( BJACK_Y_Player_Sprite.startIndex ),
                  tmp_BJACK_X_Chip_offset = global( BJACK_X_Chip_offset.startIndex ),
                  tmp_BJACK_Y_Chip_offset = global( BJACK_Y_Chip_offset.startIndex ),
                  tmp_BJACK_Z_Chip_offset = global( BJACK_Z_Chip_offset.startIndex ),
                  tmp_BJACK_X_Screenpos = global( BJACK_X_Screenpos.startIndex ),
                  tmp_BJACK_Y_Screenpos = global( BJACK_Y_Screenpos.startIndex ),
                  tmp_9208 = global( _9208.startIndex ),
                  tmp_9141 = global( _9141.startIndex ),
                  tmp_9149 = global( _9149.startIndex ),
                  tmp_9157 = global( _9157.startIndex ),
                  tmp_9087 = global( _9087.startIndex ),
                  tmp_9095 = global( _9095.startIndex ),
                  tmp_9103 = global( _9103.startIndex ),
                  tmp_9111 = global( _9111.startIndex ),
                  tmp_9119 = global( _9119.startIndex ),
                  tmp_9127 = global( _9127.startIndex );

            Int _local10 = local( 10 );

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
3@ = 0 
4@ = 0 
5@ = 0 
22@ = 0 
23@ = 0 
24@ = 0 
if 
  3@ == -1 
jf @BLACKJ_193 
0@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
1@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
" + _9217 + @" = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + _9218 + @" = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
" + tmp_9208 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)

:BLACKJ_193
29@ = -99 

:BLACKJ_200
wait 0 
if 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BLACKJ_2463 
if 
03CA:   object 0@ exists 
jf @BLACKJ_2447 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @BLACKJ_2431 
if 
  " + _9217 + @" == 0 
jf @BLACKJ_2343 
if 
   Player.Defined(" + PlayerChar + @")
jf @BLACKJ_2327 
if 
  2@ == 0 
jf @BLACKJ_1076 
if 
  3@ == 0 
jf @BLACKJ_869 
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_366 
04AF: 26@ = 171 
jump @BLACKJ_374 

:BLACKJ_366
04AF: 26@ = 171 

:BLACKJ_374
if 
   not Model.Available(26@)
jf @BLACKJ_395 
Model.Load(26@)

:BLACKJ_395
if 
84EE:   not animation ""CASINO"" loaded 
jf @BLACKJ_426 
04ED: load_animation ""CASINO"" 

:BLACKJ_426
if 
  29@ == -99 
jf @BLACKJ_862 
0653: 13@ = float_stat 81 
if 
  " + _9207 + @" == 0 
jf @BLACKJ_675 
if 
  1.0 > 13@ 
jf @BLACKJ_511 
29@ = 100 
30@ = 1 
jump @BLACKJ_661 

:BLACKJ_511
if 
  10.0 > 13@ 
jf @BLACKJ_554 
29@ = 1000 
30@ = 10 
jump @BLACKJ_661 

:BLACKJ_554
if 
  100.0 > 13@ 
jf @BLACKJ_597 
29@ = 10000 
30@ = 100 
jump @BLACKJ_661 

:BLACKJ_597
if 
  1000.0 > 13@ 
jf @BLACKJ_643 
29@ = 100000 
30@ = 1000 
jump @BLACKJ_661 

:BLACKJ_643
29@ = 1000000 
30@ = 10000 

:BLACKJ_661
" + _9207 + @" += 1 
jump @BLACKJ_862 

:BLACKJ_675
0209: 10@ = random_int_in_ranges 0 5 
0871: init_jump_table 10@ total_jumps 5 default_jump 0 @BLACKJ_862 jumps 0 @BLACKJ_747 1 @BLACKJ_768 2 @BLACKJ_790 3 @BLACKJ_812 4 @BLACKJ_837 -1 @BLACKJ_862 -1 @BLACKJ_862 

:BLACKJ_747
29@ = 100 
30@ = 1 
jump @BLACKJ_862 

:BLACKJ_768
29@ = 1000 
30@ = 10 
jump @BLACKJ_862 

:BLACKJ_790
29@ = 10000 
30@ = 100 
jump @BLACKJ_862 

:BLACKJ_812
29@ = 100000 
30@ = 1000 
jump @BLACKJ_862 

:BLACKJ_837
29@ = 1000000 
30@ = 10000 
jump @BLACKJ_862 

:BLACKJ_862
3@ += 1 

:BLACKJ_869
if 
  3@ == 1 
jf @BLACKJ_920 
if and
   Model.Available(26@)
04EE:   animation ""CASINO"" loaded 
jf @BLACKJ_920 
3@ += 1 

:BLACKJ_920
if 
  3@ == 2 
jf @BLACKJ_1076 
if 
856D:   not actor 1@ defined 
jf @BLACKJ_1062 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.4 0.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
1@ = Actor.Create(CivMale, 26@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
060B: set_actor 1@ decision_maker_to " + Interior_Decision_Maker_A + @" 
" + tempvar_Angle + @" = Object.Angle(0@)
" + tempvar_Angle + @" += 180.0 
Actor.Angle(1@) = " + tempvar_Angle + @"
Model.Destroy(26@)
0A0A: unknown_object 0@ flag 1 

:BLACKJ_1062
2@ += 1 
3@ = 0 

:BLACKJ_1076
if 
  2@ == 1 
jf @BLACKJ_2320 
if 
   not Actor.Dead(1@)
jf @BLACKJ_2320 
if 
  " + _9470 + @" == 0 
jf @BLACKJ_2271 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.4 0.0 
if 
00FF:   actor 1@ sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.4 0.4 2.0 on_foot 
jf @BLACKJ_2215 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.5 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.5 0.5 2.0 on_foot 
jf @BLACKJ_2159 
if 
044B:   actor " + PlayerActor + @" on_foot 
jf @BLACKJ_2152 
if 
  22@ == 0 
jf @BLACKJ_2128 
if 
00E1:   player 0 pressed_key 15 
jf @BLACKJ_1875 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001E:   " + BJACK_Player_cash + @" > 30@ 
jf @BLACKJ_1845 
10@ = 0 
0653: 13@ = float_stat 81 
if 
  29@ == 1000000 
jf @BLACKJ_1449 
if 
  1000.0 > 13@ 
jf @BLACKJ_1442 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
10@ = 1 

:BLACKJ_1442
jump @BLACKJ_1654 

:BLACKJ_1449
if 
  29@ == 100000 
jf @BLACKJ_1521 
if 
  100.0 > 13@ 
jf @BLACKJ_1514 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
10@ = 1 

:BLACKJ_1514
jump @BLACKJ_1654 

:BLACKJ_1521
if 
  29@ == 10000 
jf @BLACKJ_1591 
if 
  10.0 > 13@ 
jf @BLACKJ_1584 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
10@ = 1 

:BLACKJ_1584
jump @BLACKJ_1654 

:BLACKJ_1591
if 
  29@ == 1000 
jf @BLACKJ_1654 
if 
  1.0 > 13@ 
jf @BLACKJ_1654 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
10@ = 1 

:BLACKJ_1654
if 
  10@ == 0 
jf @BLACKJ_1744 
if 
  21@ == 1 
jf @BLACKJ_1701 
00BE: text_clear_all 
03E6: remove_text_box 
21@ = 0 

:BLACKJ_1701
2@ = 0 
3@ = 0 
008A: " + _9217 + @" = 0@ 
" + _9205 + @" = 0 
22@ = 1 
jump @BLACKJ_1838 

:BLACKJ_1744
if 
   not Actor.Dead(1@)
jf @BLACKJ_1838 
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_1816 
09D6: unknown_set_actor 1@ sound 5850 flags 1 1 0 
0967: actor 1@ move_mouth 2000 ms 
jump @BLACKJ_1838 

:BLACKJ_1816
09D6: unknown_set_actor 1@ sound 5851 flags 1 1 0 
0967: actor 1@ move_mouth 2000 ms 

:BLACKJ_1838
jump @BLACKJ_1868 

:BLACKJ_1845
00BC: show_text_highpriority GXT 'BJ_2' time 5000 flag 1  
gosub @BLACKJ_18303 

:BLACKJ_1868
jump @BLACKJ_2121 

:BLACKJ_1875
if 
   not 21@ == 1 
jf @BLACKJ_2121 
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_2121 
0989: set_text_boxes_width 200 
0871: init_jump_table 29@ total_jumps 5 default_jump 0 @BLACKJ_2114 jumps 100 @BLACKJ_2024 1000 @BLACKJ_2042 10000 @BLACKJ_2060 100000 @BLACKJ_2078 1000000 @BLACKJ_2096 -1 @BLACKJ_2114 -1 @BLACKJ_2114 

:BLACKJ_2024
0512: show_permanent_text_box 'BJ_1A'  
jump @BLACKJ_2114 

:BLACKJ_2042
0512: show_permanent_text_box 'BJ_1B'  
jump @BLACKJ_2114 

:BLACKJ_2060
0512: show_permanent_text_box 'BJ_1C'  
jump @BLACKJ_2114 

:BLACKJ_2078
0512: show_permanent_text_box 'BJ_1D'  
jump @BLACKJ_2114 

:BLACKJ_2096
0512: show_permanent_text_box 'BJ_1E'  
jump @BLACKJ_2114 

:BLACKJ_2114
21@ = 1 

:BLACKJ_2121
jump @BLACKJ_2152 

:BLACKJ_2128
if 
80E1:   not player 0 pressed_key 15 
jf @BLACKJ_2152 
22@ = 0 

:BLACKJ_2152
jump @BLACKJ_2208 

:BLACKJ_2159
if 
  21@ == 1 
jf @BLACKJ_2208 
03D5: remove_text 'BJ_2'  
03D5: remove_text 'GAMBSTA'  
03E6: remove_text_box 
21@ = 0 

:BLACKJ_2208
jump @BLACKJ_2264 

:BLACKJ_2215
if 
  21@ == 1 
jf @BLACKJ_2264 
03D5: remove_text 'BJ_2'  
03D5: remove_text 'GAMBSTA'  
03E6: remove_text_box 
21@ = 0 

:BLACKJ_2264
jump @BLACKJ_2320 

:BLACKJ_2271
if 
  21@ == 1 
jf @BLACKJ_2320 
03D5: remove_text 'BJ_2'  
03D5: remove_text 'GAMBSTA'  
03E6: remove_text_box 
21@ = 0 

:BLACKJ_2320
jump @BLACKJ_2336 

:BLACKJ_2327
gosub @BLACKJ_2479 
end_thread 

:BLACKJ_2336
jump @BLACKJ_2424 

:BLACKJ_2343
if 
003C:   " + _9217 + @" == 0@ 
jf @BLACKJ_2424 
if 
   Player.Defined(" + PlayerChar + @")
jf @BLACKJ_2424 
if 
  5@ == 0 
jf @BLACKJ_2410 
gosub @BLACKJ_2533 
jump @BLACKJ_2424 

:BLACKJ_2410
gosub @BLACKJ_34567 
" + _9217 + @" = 0 

:BLACKJ_2424
jump @BLACKJ_2440 

:BLACKJ_2431
gosub @BLACKJ_2479 
end_thread 

:BLACKJ_2440
jump @BLACKJ_2456 

:BLACKJ_2447
gosub @BLACKJ_2479 
end_thread 

:BLACKJ_2456
jump @BLACKJ_2472 

:BLACKJ_2463
gosub @BLACKJ_2479 
end_thread 

:BLACKJ_2472
jump @BLACKJ_200 

:BLACKJ_2479
if 
03CA:   object 0@ exists 
jf @BLACKJ_2502 
0A0A: unknown_object 0@ flag 0 

:BLACKJ_2502
Actor.RemoveReferences(1@)
04EF: release_animation ""CASINO"" 
" + _9207 + @" -= 1 
2@ = 0 
return 

:BLACKJ_2533
if 
0736:   is_keyboard_key_just_pressed 32 
jf @BLACKJ_2582 
31@ += 1 
if 
  31@ > 5 
jf @BLACKJ_2580 
31@ = 0 

:BLACKJ_2580
086A: NOP 

:BLACKJ_2582
if 
  31@ == 1 
jf @BLACKJ_2838 
008A: " + _9219 + @" = 2@ 
008A: " + _9220 + @" = 3@ 
008A: " + _9221 + @" = 4@ 
0084: " + _9222 + @" = " + BJACK_Player_total1 + @" 
0084: " + _9223 + @" = " + BJACK_Player_total1_B + @" 
0084: " + _9224 + @" = " + BJACK_Player_total2 + @" 
0084: " + _9225 + @" = " + BJACK_Player_total2_B + @" 
0084: " + _9226 + @" = " + BJACK_Dealer_total + @" 
0084: " + _9227 + @" = " + BJACK_Dealer_total2 + @" 
065D: NOP " + _9219 + @" ""M_STAGE"" 
065D: NOP " + _9220 + @" ""M_GOALS"" 
065D: NOP " + _9221 + @" ""M_GOALS2"" 
065D: NOP " + _9222 + @" ""PLAYER_TOTAL1"" 
065D: NOP " + _9223 + @" ""PLAYER_TOTAL1_B"" 
065D: NOP " + _9224 + @" ""PLAYER_TOTAL2"" 
065D: NOP " + _9225 + @" ""PLAYER_TOTAL2_B"" 
065D: NOP " + _9226 + @" ""DEALER_TOTAL"" 
065D: NOP " + _9227 + @" ""DEALER_TOTAL2"" 

:BLACKJ_2838
if 
  31@ == 2 
jf @BLACKJ_3148 
0084: " + _9219 + @" = " + BJACK_Player_cannot_Split + @" 
0084: " + _9220 + @" = " + BJACK_Player_has_split + @" 
0084: " + _9221 + @" = " + BJACK_Player_cannot_double + @" 
0084: " + _9222 + @" = " + BJACK_Player_has_doubled1 + @" 
0084: " + _9223 + @" = " + BJACK_Player_has_doubled2 + @" 
0084: " + _9224 + @" = " + BJACK_Player_has_stucked1 + @" 
0084: " + _9225 + @" = " + BJACK_Player_has_stucked2 + @" 
0084: " + _9226 + @" = " + BJACK_Player_has_hit1 + @" 
0084: " + _9227 + @" = " + BJACK_Dealer_has_stuck + @" 
065D: NOP " + _9219 + @" ""PLAYER_CANNOT_SPLIT"" 
065D: NOP " + _9220 + @" ""PLAYER_HAS_SPLIT"" 
065D: NOP " + _9221 + @" ""PLAYER_CANNOT_DOUBLE"" 
065D: NOP " + _9222 + @" ""PLAYER_HAS_DOUBLED1"" 
065D: NOP " + _9223 + @" ""PLAYER_HAS_DOUBLED2"" 
065D: NOP " + _9224 + @" ""PLAYER_HAS_STUCK1"" 
065D: NOP " + _9225 + @" ""PLAYER_HAS_STUCK2"" 
065D: NOP " + _9226 + @" ""PLAYER_HAS_HIT"" 
065D: NOP " + _9227 + @" ""DEALER_HAS_STUCK"" 

:BLACKJ_3148
if 
  31@ == 3 
jf @BLACKJ_3441 
0084: " + _9219 + @" = " + BJACK_Player_has_quit + @" 
0084: " + _9220 + @" = " + BJACK_Player_has_won1 + @" 
0084: " + _9221 + @" = " + BJACK_Player_has_won2 + @" 
0084: " + _9222 + @" = " + BJACK_Player_has_input + @" 
0084: " + _9223 + @" = " + BJACK_Dealer_wins_by_default + @" 
0084: " + _9224 + @" = " + BJACK_Dealer_got_ace + @" 
0084: " + _9225 + @" = " + BJACK_Player_got_ace1 + @" 
0084: " + _9226 + @" = " + BJACK_Player_got_ace2 + @" 
0084: " + _9227 + @" = " + BJACK_Player_got_BJACK + @" 
065D: NOP " + _9219 + @" ""PLAYER_HAS_QUIT"" 
065D: NOP " + _9220 + @" ""PLAYER_HAS_WON1"" 
065D: NOP " + _9221 + @" ""PLAYER_HAS_WON2"" 
065D: NOP " + _9222 + @" ""PLAYER_HAS_INPUT"" 
065D: NOP " + _9223 + @" ""DEALER_WINS_BY_DEFAULT"" 
065D: NOP " + _9224 + @" ""DEALER_GOT_ACE"" 
065D: NOP " + _9225 + @" ""PLAYER_GOT_ACE1"" 
065D: NOP " + _9226 + @" ""PLAYER_GOT_ACE2"" 
065D: NOP " + _9227 + @" ""PLAYER_GOT_BJ"" 

:BLACKJ_3441
if 
  31@ == 4 
jf @BLACKJ_3679 
0084: " + _9219 + @" = " + BJACK_Player_cash + @" 
008A: " + _9220 + @" = 30@ 
008A: " + _9221 + @" = 29@ 
0084: " + _9222 + @" = " + BJACK_last_bet + @" 
0084: " + _9223 + @" = " + BJACK_Bet1 + @" 
0084: " + _9224 + @" = " + BJACK_Bet2 + @" 
0084: " + _9225 + @" = " + BJACK_Bet_Step + @" 
0084: " + _9226 + @" = " + BJACK_Half_Bet + @" 
0084: " + _9227 + @" = " + BJACK_Refund + @" 
065D: NOP " + _9219 + @" ""BJ_PLAYERS_CASH"" 
065D: NOP " + _9220 + @" ""MIN_BET"" 
065D: NOP " + _9221 + @" ""MAX_BET"" 
065D: NOP " + _9222 + @" ""BJ_LAST_BET"" 
065D: NOP " + _9223 + @" ""BJ_BET1"" 
065D: NOP " + _9224 + @" ""BJ_BET2"" 
065D: NOP " + _9225 + @" ""BJ_BET_STEP"" 
065D: NOP " + _9226 + @" ""BJ_HALF_BET"" 
065D: NOP " + _9227 + @" ""BJ_REFUND"" 

:BLACKJ_3679
if 
  31@ == 5 
jf @BLACKJ_3780 
0084: " + _9219 + @" = " + BJACK_Player_got_BJACK + @" 
0084: " + _9220 + @" = " + BJACK_Payout + @" 
0084: " + _9221 + @" = " + BJACK_Initial_Stake + @" 
065D: NOP " + _9219 + @" ""PLAYER_GOT_BJ"" 
065D: NOP " + _9220 + @" ""BJ_PAYOUT"" 
065D: NOP " + _9221 + @" ""BJ_INITIAL_STAKE"" 

:BLACKJ_3780
6@ += 1 
if 
  6@ > 9 
jf @BLACKJ_3812 
6@ = 0 

:BLACKJ_3812
01BD: 7@ = current_time_in_ms 
0085: 9@ = 7@ 
0062: 9@ -= 8@ 
0085: 8@ = 7@ 
if or
0A2A:   text_box 'SGPUNT' displayed  
0A2A:   text_box 'SGGAMB' displayed  
0A2A:   text_box 'SGPROF' displayed  
0A2A:   text_box 'SGHIRO' displayed  
jf @BLACKJ_4365 
if 
   not " + _9206 + @" == 1 
jf @BLACKJ_4079 
if 
   not Actor.Dead(1@)
jf @BLACKJ_4065 
0209: 10@ = random_int_in_ranges 0 3 
0871: init_jump_table 10@ total_jumps 3 default_jump 0 @BLACKJ_4065 jumps 0 @BLACKJ_4002 1 @BLACKJ_4023 2 @BLACKJ_4044 -1 @BLACKJ_4065 -1 @BLACKJ_4065 -1 @BLACKJ_4065 -1 @BLACKJ_4065 

:BLACKJ_4002
09D6: unknown_set_actor 1@ sound 5820 flags 1 1 0 
jump @BLACKJ_4065 

:BLACKJ_4023
09D6: unknown_set_actor 1@ sound 5821 flags 1 1 0 
jump @BLACKJ_4065 

:BLACKJ_4044
09D6: unknown_set_actor 1@ sound 5822 flags 1 1 0 
jump @BLACKJ_4065 

:BLACKJ_4065
" + _9206 + @" = 1 
TIMERA = 0 

:BLACKJ_4079
if 
  23@ == 0 
jf @BLACKJ_4130 
if 
00E1:   player 0 pressed_key 16 
jf @BLACKJ_4123 
03E6: remove_text_box 
23@ = 1 

:BLACKJ_4123
jump @BLACKJ_4172 

:BLACKJ_4130
if 
80E1:   not player 0 pressed_key 16 
jf @BLACKJ_4172 
if 
   not 23@ == 0 
jf @BLACKJ_4172 
23@ = 0 

:BLACKJ_4172
if 
  25@ == 0 
jf @BLACKJ_4223 
if 
00E1:   player 0 pressed_key 17 
jf @BLACKJ_4216 
03E6: remove_text_box 
25@ = 1 

:BLACKJ_4216
jump @BLACKJ_4265 

:BLACKJ_4223
if 
80E1:   not player 0 pressed_key 17 
jf @BLACKJ_4265 
if 
   not 25@ == 0 
jf @BLACKJ_4265 
25@ = 0 

:BLACKJ_4265
if 
  24@ == 0 
jf @BLACKJ_4316 
if 
00E1:   player 0 pressed_key 14 
jf @BLACKJ_4309 
03E6: remove_text_box 
24@ = 1 

:BLACKJ_4309
jump @BLACKJ_4358 

:BLACKJ_4316
if 
80E1:   not player 0 pressed_key 14 
jf @BLACKJ_4358 
if 
   not 24@ == 0 
jf @BLACKJ_4358 
24@ = 0 

:BLACKJ_4358
jump @BLACKJ_4390 

:BLACKJ_4365
if 
   not " + _9206 + @" == 0 
jf @BLACKJ_4390 
" + _9206 + @" = 0 

:BLACKJ_4390
0871: init_jump_table 2@ total_jumps 7 default_jump 0 @BLACKJ_4551 jumps 0 @BLACKJ_4453 1 @BLACKJ_4467 2 @BLACKJ_4481 3 @BLACKJ_4495 4 @BLACKJ_4509 5 @BLACKJ_4523 6 @BLACKJ_4537 

:BLACKJ_4453
gosub @BLACKJ_5015 
jump @BLACKJ_4551 

:BLACKJ_4467
gosub @BLACKJ_7716 
jump @BLACKJ_4551 

:BLACKJ_4481
gosub @BLACKJ_9615 
jump @BLACKJ_4551 

:BLACKJ_4495
gosub @BLACKJ_10189 
jump @BLACKJ_4551 

:BLACKJ_4509
gosub @BLACKJ_10622 
jump @BLACKJ_4551 

:BLACKJ_4523
gosub @BLACKJ_15357 
jump @BLACKJ_4551 

:BLACKJ_4537
gosub @BLACKJ_15879 
jump @BLACKJ_4551 

:BLACKJ_4551
if 
0736:   is_keyboard_key_just_pressed 85 
jf @BLACKJ_4646 
" + BJACK_Flag_Card_Cheat + @" += 1 
if 
  " + BJACK_Flag_Card_Cheat + @" > 1 
jf @BLACKJ_4626 
" + BJACK_Flag_Card_Cheat + @" = 0 
0663: printint ""CARD_CHEAT_OFF"" " + BJACK_Flag_Card_Cheat + @" 
jump @BLACKJ_4646 

:BLACKJ_4626
0663: printint ""CARD_CHEAT_ON"" " + BJACK_Flag_Card_Cheat + @" 

:BLACKJ_4646
if 
   not " + BJACK_Flag_Card_Cheat + @" == 0 
jf @BLACKJ_4792 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_4728 
" + BJACK_Cheat_Card_ID + @" += 1 
if 
  " + BJACK_Cheat_Card_ID + @" > 52 
jf @BLACKJ_4712 
" + BJACK_Cheat_Card_ID + @" = 1 

:BLACKJ_4712
0663: printint ""NEXT_CARD"" " + BJACK_Cheat_Card_ID + @" 

:BLACKJ_4728
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_4792 
" + BJACK_Cheat_Card_ID + @" -= 1 
if 
  1 > " + BJACK_Cheat_Card_ID + @" 
jf @BLACKJ_4776 
" + BJACK_Cheat_Card_ID + @" = 52 

:BLACKJ_4776
0663: printint ""NEXT_CARD"" " + BJACK_Cheat_Card_ID + @" 

:BLACKJ_4792
if 
  22@ == 0 
jf @BLACKJ_4966 
if and
00E1:   player 0 pressed_key 15 
   not 2@ == 2 
jf @BLACKJ_4959 
if 
   not Actor.Dead(1@)
jf @BLACKJ_4912 
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_4898 
09D6: unknown_set_actor 1@ sound 5852 flags 1 1 0 
jump @BLACKJ_4912 

:BLACKJ_4898
09D6: unknown_set_actor 1@ sound 5853 flags 1 1 0 

:BLACKJ_4912
5@ = 1 
22@ = 1 
if 
   not " + BJACK_Refund + @" == 0 
jf @BLACKJ_4952 
Player.Money(" + PlayerChar + @") += " + BJACK_Refund + @"

:BLACKJ_4952
" + BJACK_last_bet + @" = 0 

:BLACKJ_4959
jump @BLACKJ_4990 

:BLACKJ_4966
if 
80E1:   not player 0 pressed_key 15 
jf @BLACKJ_4990 
22@ = 0 

:BLACKJ_4990
if 
   Actor.Dead(1@)
jf @BLACKJ_5013 
5@ = 1 

:BLACKJ_5013
return 

:BLACKJ_5015
if 
  3@ == 0 
jf @BLACKJ_5950 
09BD: allow_other_threads_to_display_text_boxes 1 
Player.CanMove(" + PlayerChar + @") = False
" + _9325 + @" = 0 
" + BJACK_Card_Width + @" = 51.0 
" + BJACK_Card_Height + @" = 64.0 
" + tmp_9087 + @"[0] = 233.0 
" + tmp_9095 + @"[0] = 381.0 
" + tmp_9103 + @"[0] = 233.0 
" + tmp_9111 + @"[0] = 311.0 
" + tmp_9119 + @"[0] = 233.0 
" + tmp_9127 + @"[0] = 381.0 
" + tmp_BJACK_X_Player_Sprite + @"[0] = 226.0 
" + tmp_BJACK_Y_Player_Sprite + @"[0] = 60.0 
" + BJACK_Border_Width + @" = 6.0 
" + tmp_BJACK_X_Screenpos + @"[0] = 29.0 
" + tmp_BJACK_Y_Screenpos + @"[0] = 220.0 
0871: init_jump_table " + Current_Language + @" total_jumps 1 default_jump 1 @BLACKJ_5271 jumps 3 @BLACKJ_5244 -1 @BLACKJ_5298 -1 @BLACKJ_5298 -1 @BLACKJ_5298 -1 @BLACKJ_5298 -1 @BLACKJ_5298 -1 @BLACKJ_5298 

:BLACKJ_5244
" + tmp_BJACK_X_Screenpos + @"[1] = 173.9799 
" + tmp_BJACK_Y_Screenpos + @"[1] = 409.0 
jump @BLACKJ_5298 

:BLACKJ_5271
" + tmp_BJACK_X_Screenpos + @"[1] = 157.0 
" + tmp_BJACK_Y_Screenpos + @"[1] = 409.0 
jump @BLACKJ_5298 

:BLACKJ_5298
" + tmp_BJACK_X_Screenpos + @"[2] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[2] = 240.0 
" + tmp_BJACK_X_Screenpos + @"[3] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[3] = 260.0 
" + tmp_BJACK_X_Screenpos + @"[4] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[4] = 290.0 
" + tmp_BJACK_X_Screenpos + @"[5] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[5] = 310.0 
" + tmp_BJACK_X_Screenpos + @"[6] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[6] = 340.0 
" + tmp_BJACK_X_Screenpos + @"[7] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[7] = 360.0 
" + tmp_BJACK_X_Screenpos + @"[8] = 29.0 
" + tmp_BJACK_Y_Screenpos + @"[8] = 220.0 
0871: init_jump_table " + Current_Language + @" total_jumps 4 default_jump 1 @BLACKJ_5555 jumps 1 @BLACKJ_5528 2 @BLACKJ_5501 3 @BLACKJ_5501 4 @BLACKJ_5501 -1 @BLACKJ_5582 -1 @BLACKJ_5582 -1 @BLACKJ_5582 

:BLACKJ_5501
" + tmp_BJACK_X_Screenpos + @"[9] = 169.0 
" + tmp_BJACK_Y_Screenpos + @"[9] = 409.0 
jump @BLACKJ_5582 

:BLACKJ_5528
" + tmp_BJACK_X_Screenpos + @"[9] = 177.0 
" + tmp_BJACK_Y_Screenpos + @"[9] = 409.0 
jump @BLACKJ_5582 

:BLACKJ_5555
" + tmp_BJACK_X_Screenpos + @"[9] = 157.0 
" + tmp_BJACK_Y_Screenpos + @"[9] = 409.0 
jump @BLACKJ_5582 

:BLACKJ_5582
" + tmp_BJACK_X_Screenpos + @"[10] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[10] = 240.0 
" + tmp_BJACK_X_Screenpos + @"[11] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[11] = 260.0 
" + tmp_BJACK_X_Screenpos + @"[12] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[12] = 290.0 
" + tmp_BJACK_X_Screenpos + @"[13] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[13] = 310.0 
" + tmp_BJACK_X_Screenpos + @"[14] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[14] = 310.0 
" + tmp_BJACK_X_Screenpos + @"[15] = 36.0 
" + tmp_BJACK_Y_Screenpos + @"[15] = 340.0 
" + tmp_BJACK_X_Screenpos + @"[16] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[16] = 360.0 
" + tmp_BJACK_X_Screenpos + @"[17] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[17] = 360.0 
" + tmp_BJACK_X_Screenpos + @"[18] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[18] = 360.0 
" + tmp_BJACK_X_Screenpos + @"[19] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[19] = 360.0 
" + tmp_BJACK_X_Screenpos + @"[20] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[20] = 382.0 
" + tmp_BJACK_X_Screenpos + @"[21] = 40.0 
" + tmp_BJACK_Y_Screenpos + @"[21] = 382.0 
" + tmp_BJACK_X_Screenpos + @"[22] = 209.0 
" + tmp_BJACK_Y_Screenpos + @"[22] = 293.0 
" + tmp_BJACK_X_Screenpos + @"[23] = 209.0 
" + tmp_BJACK_Y_Screenpos + @"[23] = 361.0 
" + tmp_BJACK_X_Screenpos + @"[24] = 1.0 
" + tmp_BJACK_Y_Screenpos + @"[24] = 4.0 
" + tmp_BJACK_X_Screenpos + @"[25] = 320.0 
" + tmp_BJACK_Y_Screenpos + @"[25] = 197.0 
" + tmp_BJACK_X_Screenpos + @"[26] = 320.0 
" + tmp_BJACK_Y_Screenpos + @"[26] = 233.0 
gosub @BLACKJ_32389 
Model.Load(#BLCK_JACK)
04ED: load_animation ""CASINO"" 
3@ += 1 

:BLACKJ_5950
if 
  3@ == 1 
jf @BLACKJ_6000 
if and
   Model.Available(#BLCK_JACK)
04EE:   animation ""CASINO"" loaded 
jf @BLACKJ_6000 
3@ += 1 

:BLACKJ_6000
if 
  3@ == 2 
jf @BLACKJ_7552 
03F0: enable_text_draw 1 
0390: load_txd_dictionary 'LD_CARD' 
038F: load_texture ""CD1C"" as 1 
038F: load_texture ""CD2C"" as 2 
038F: load_texture ""CD3C"" as 3 
038F: load_texture ""CD4C"" as 4 
038F: load_texture ""CD5C"" as 5 
038F: load_texture ""CD6C"" as 6 
038F: load_texture ""CD7C"" as 7 
038F: load_texture ""CD8C"" as 8 
038F: load_texture ""CD9C"" as 9 
038F: load_texture ""CD10C"" as 10 
038F: load_texture ""CD11C"" as 11 
038F: load_texture ""CD12C"" as 12 
038F: load_texture ""CD13C"" as 13 
038F: load_texture ""CD1D"" as 14 
038F: load_texture ""CD2D"" as 15 
038F: load_texture ""CD3D"" as 16 
038F: load_texture ""CD4D"" as 17 
038F: load_texture ""CD5D"" as 18 
038F: load_texture ""CD6D"" as 19 
038F: load_texture ""CD7D"" as 20 
038F: load_texture ""CD8D"" as 21 
038F: load_texture ""CD9D"" as 22 
038F: load_texture ""CD10D"" as 23 
038F: load_texture ""CD11D"" as 24 
038F: load_texture ""CD12D"" as 25 
038F: load_texture ""CD13D"" as 26 
038F: load_texture ""CD1S"" as 27 
038F: load_texture ""CD2S"" as 28 
038F: load_texture ""CD3S"" as 29 
038F: load_texture ""CD4S"" as 30 
038F: load_texture ""CD5S"" as 31 
038F: load_texture ""CD6S"" as 32 
038F: load_texture ""CD7S"" as 33 
038F: load_texture ""CD8S"" as 34 
038F: load_texture ""CD9S"" as 35 
038F: load_texture ""CD10S"" as 36 
038F: load_texture ""CD11S"" as 37 
038F: load_texture ""CD12S"" as 38 
038F: load_texture ""CD13S"" as 39 
038F: load_texture ""CD1H"" as 40 
038F: load_texture ""CD2H"" as 41 
038F: load_texture ""CD3H"" as 42 
038F: load_texture ""CD4H"" as 43 
038F: load_texture ""CD5H"" as 44 
038F: load_texture ""CD6H"" as 45 
038F: load_texture ""CD7H"" as 46 
038F: load_texture ""CD8H"" as 47 
038F: load_texture ""CD9H"" as 48 
038F: load_texture ""CD10H"" as 49 
038F: load_texture ""CD11H"" as 50 
038F: load_texture ""CD12H"" as 51 
038F: load_texture ""CD13H"" as 52 
038F: load_texture ""CDBACK"" as 53 
059D: shuffle_card_decks 6 
0581: enable_radar 0 
03AD: NOP 0 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.4 0.0 
" + tempvar_Angle + @" = Object.Angle(0@)
" + tempvar_Angle + @" += 180.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += -0.4 
if 
   not Actor.Dead(1@)
jf @BLACKJ_6707 
0792: disembark_instantly_actor 1@ 
Actor.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.Angle(1@) = " + tempvar_Angle + @"

:BLACKJ_6707
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.3192 -1.6334 0.1415 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += -0.4 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
   not Actor.Dead(1@)
jf @BLACKJ_6798 
0639: AS_actor " + PlayerActor + @" rotate_to_actor 1@ 

:BLACKJ_6798
if 
03CA:   object 0@ exists 
jf @BLACKJ_6911 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.4379 -2.243 1.16 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.2822 -1.3256 0.7939 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:BLACKJ_6911
if 
03CA:   object 0@ exists 
jf @BLACKJ_7545 
" + _9216 + @" = -0.14 
" + tmp_BJACK_X_Chip_offset + @"[0] = 0.0 
" + tmp_BJACK_Y_Chip_offset + @"[0] = -0.885 
0086: " + tmp_BJACK_Z_Chip_offset + @"[0] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[1] = 0.045 
" + tmp_BJACK_Y_Chip_offset + @"[1] = -0.935 
0086: " + tmp_BJACK_Z_Chip_offset + @"[1] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[2] = -0.05 
" + tmp_BJACK_Y_Chip_offset + @"[2] = -0.93 
0086: " + tmp_BJACK_Z_Chip_offset + @"[2] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[3] = -0.01 
" + tmp_BJACK_Y_Chip_offset + @"[3] = -0.98 
0086: " + tmp_BJACK_Z_Chip_offset + @"[3] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[4] = 0.06 
" + tmp_BJACK_Y_Chip_offset + @"[4] = -0.995 
0086: " + tmp_BJACK_Z_Chip_offset + @"[4] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[5] = 0.02 
" + tmp_BJACK_Y_Chip_offset + @"[5] = -1.075 
0086: " + tmp_BJACK_Z_Chip_offset + @"[5] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[6] = -0.07 
" + tmp_BJACK_Y_Chip_offset + @"[6] = -1.03 
0086: " + tmp_BJACK_Z_Chip_offset + @"[6] = " + _9216 + @" 
" + tmp_BJACK_X_Chip_offset + @"[7] = 0.065 
" + tmp_BJACK_Y_Chip_offset + @"[7] = -1.05 
0086: " + tmp_BJACK_Z_Chip_offset + @"[7] = " + _9216 + @" 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[0] " + tmp_BJACK_Y_Chip_offset + @"[0] " + _9216 + @" 
" + tmp_9208 + @"[0] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[0]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[1] " + tmp_BJACK_Y_Chip_offset + @"[1] " + _9216 + @" 
" + tmp_9208 + @"[1] = Object.Init(#CHIP_STACK08, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[1]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[2] " + tmp_BJACK_Y_Chip_offset + @"[2] " + _9216 + @" 
" + tmp_9208 + @"[2] = Object.Init(#CHIP_STACK09, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[2]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[3] " + tmp_BJACK_Y_Chip_offset + @"[3] " + _9216 + @" 
" + tmp_9208 + @"[3] = Object.Init(#CHIP_STACK10, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[3]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[4] " + tmp_BJACK_Y_Chip_offset + @"[4] " + _9216 + @" 
" + tmp_9208 + @"[4] = Object.Init(#CHIP_STACK11, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[4]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[5] " + tmp_BJACK_Y_Chip_offset + @"[5] " + _9216 + @" 
" + tmp_9208 + @"[5] = Object.Init(#CHIP_STACK12, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[5]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[6] " + tmp_BJACK_Y_Chip_offset + @"[6] " + _9216 + @" 
" + tmp_9208 + @"[6] = Object.Init(#CHIP_STACK13, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[6]) = " + tempvar_Angle + @"
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"[7] " + tmp_BJACK_Y_Chip_offset + @"[7] " + _9216 + @" 
" + tmp_9208 + @"[7] = Object.Init(#CHIP_STACK14, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9208 + @"[7]) = " + tempvar_Angle + @"

:BLACKJ_7545
3@ = 99 

:BLACKJ_7552
if 
  3@ == 99 
jf @BLACKJ_7714 
if 
   not Actor.Dead(1@)
jf @BLACKJ_7700 
0209: 10@ = random_int_in_ranges 0 2 
0871: init_jump_table 10@ total_jumps 2 default_jump 0 @BLACKJ_7700 jumps 0 @BLACKJ_7658 1 @BLACKJ_7679 -1 @BLACKJ_7700 -1 @BLACKJ_7700 -1 @BLACKJ_7700 -1 @BLACKJ_7700 -1 @BLACKJ_7700 

:BLACKJ_7658
09D6: unknown_set_actor 1@ sound 5809 flags 1 1 0 
jump @BLACKJ_7700 

:BLACKJ_7679
09D6: unknown_set_actor 1@ sound 5810 flags 1 1 0 
jump @BLACKJ_7700 

:BLACKJ_7700
2@ += 1 
3@ = 0 

:BLACKJ_7714
return 

:BLACKJ_7716
if 
  3@ == 0 
jf @BLACKJ_8323 
" + BJACK_Card_ID + @" = 0 
10@ = 0 

:BLACKJ_7748
if 
  8 > 10@ 
jf @BLACKJ_7813 
" + tmp_9141 + @"(10@,8i) = 0 
" + tmp_9149 + @"(10@,8i) = 0 
" + tmp_9157 + @"(10@,8i) = 0 
10@ += 1 
jump @BLACKJ_7748 

:BLACKJ_7813
" + BJACK_Player_cannot_Split + @" = 0 
" + BJACK_Player_has_split + @" = 0 
" + BJACK_Player_cannot_double + @" = 0 
" + BJACK_Player_has_doubled1 + @" = 0 
" + BJACK_Player_has_doubled2 + @" = 0 
" + BJACK_Player_has_stucked1 + @" = 0 
" + BJACK_Player_has_stucked2 + @" = 0 
" + BJACK_Player_has_hit1 + @" = 0 
" + BJACK_Dealer_has_stuck + @" = 0 
" + BJACK_Player_has_quit + @" = 0 
" + BJACK_Player_has_won1 + @" = 0 
" + BJACK_Player_has_won2 + @" = 0 
" + BJACK_Player_has_input + @" = 0 
" + BJACK_Dealer_wins_by_default + @" = 0 
" + BJACK_Player_total1 + @" = 0 
" + BJACK_Player_total1_B + @" = 0 
" + BJACK_Player_total2 + @" = 0 
" + BJACK_Player_total2_B + @" = 0 
" + BJACK_Dealer_total + @" = 0 
" + BJACK_Dealer_total2 + @" = 0 
" + BJACK_Dealer_got_ace + @" = 0 
" + BJACK_Player_got_ace1 + @" = 0 
" + BJACK_Player_got_ace2 + @" = 0 
" + BJACK_Refund + @" = 0 
if 
001F:   30@ > " + _9205 + @" 
jf @BLACKJ_8008 
008A: " + _9205 + @" = 30@ 

:BLACKJ_8008
0084: " + BJACK_Bet1 + @" = " + _9205 + @" 
" + BJACK_Bet2 + @" = 0 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Bet1 + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_8073 
008A: " + BJACK_Bet1 + @" = 30@ 

:BLACKJ_8073
if 
001C:   " + BJACK_Bet1 + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_8136 
00BC: show_text_highpriority GXT 'BJ_2' time 5000 flag 1  
gosub @BLACKJ_18303 
5@ = 1 
jump @BLACKJ_9613 
jump @BLACKJ_8305 

:BLACKJ_8136
008B: 10@ = " + BJACK_Bet1 + @" 
10@ *= -1 
Player.Money(" + PlayerChar + @") += 10@
0084: " + BJACK_Refund + @" = " + BJACK_Bet1 + @" 
0084: " + BJACK_Initial_Stake + @" = " + BJACK_Bet1 + @" 
if 
   not Actor.Dead(1@)
jf @BLACKJ_8305 
0209: 10@ = random_int_in_ranges 0 2 
0871: init_jump_table 10@ total_jumps 2 default_jump 0 @BLACKJ_8305 jumps 0 @BLACKJ_8263 1 @BLACKJ_8284 -1 @BLACKJ_8305 -1 @BLACKJ_8305 -1 @BLACKJ_8305 -1 @BLACKJ_8305 -1 @BLACKJ_8305 

:BLACKJ_8263
09D6: unknown_set_actor 1@ sound 5809 flags 1 1 0 
jump @BLACKJ_8305 

:BLACKJ_8284
09D6: unknown_set_actor 1@ sound 5810 flags 1 1 0 
jump @BLACKJ_8305 

:BLACKJ_8305" );
                end_thread_named<CASHWIN>();
AppendLine( @"3@ += 1 

:BLACKJ_8323
if 
  3@ == 1 
jf @BLACKJ_9542 
if 
876F:   not text_priority_displayed 
jf @BLACKJ_9467 
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_8438 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_8438 
0989: set_text_boxes_width 200 
0512: show_permanent_text_box 'BJ_H1'  

:BLACKJ_8438
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
00E1:   player 0 pressed_key 14 
jf @BLACKJ_8887 
if and
   not 24@ == 1 
   not 24@ == -1 
jf @BLACKJ_8836 
if 
  " + BJACK_Bet1 + @" >= 10000 
jf @BLACKJ_8537 
" + BJACK_Bet_Step + @" = 1000 
jump @BLACKJ_8641 

:BLACKJ_8537
if 
  " + BJACK_Bet1 + @" >= 1000 
jf @BLACKJ_8570 
" + BJACK_Bet_Step + @" = 100 
jump @BLACKJ_8641 

:BLACKJ_8570
if 
  " + BJACK_Bet1 + @" >= 100 
jf @BLACKJ_8602 
" + BJACK_Bet_Step + @" = 10 
jump @BLACKJ_8641 

:BLACKJ_8602
if 
  " + BJACK_Bet1 + @" == 0 
jf @BLACKJ_8634 
" + BJACK_Bet_Step + @" = 2 
jump @BLACKJ_8641 

:BLACKJ_8634
" + BJACK_Bet_Step + @" = 1 

:BLACKJ_8641
if 
001C:   " + BJACK_Bet_Step + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_8668 
0084: " + BJACK_Bet_Step + @" = " + BJACK_Player_cash + @" 

:BLACKJ_8668
008B: 10@ = " + BJACK_Bet1 + @" 
005C: 10@ += " + BJACK_Bet_Step + @" 
if 
001D:   10@ > 29@ 
jf @BLACKJ_8719 
008A: " + BJACK_Bet_Step + @" = 29@ 
0060: " + BJACK_Bet_Step + @" -= " + BJACK_Bet1 + @" 

:BLACKJ_8719
if 
  0 > " + BJACK_Bet_Step + @" 
jf @BLACKJ_8744 
" + BJACK_Bet_Step + @" *= -1 

:BLACKJ_8744
0058: " + BJACK_Bet1 + @" += " + BJACK_Bet_Step + @" 
0058: " + BJACK_Refund + @" += " + BJACK_Bet_Step + @" 
0058: " + BJACK_Initial_Stake + @" += " + BJACK_Bet_Step + @" 
" + BJACK_Bet_Step + @" *= -1 
Player.Money(" + PlayerChar + @") += " + BJACK_Bet_Step + @"
24@ += 1 
if 
  24@ > 1 
jf @BLACKJ_8822 
24@ = 2 
jump @BLACKJ_8829 

:BLACKJ_8822
TIMERA = 0 

:BLACKJ_8829
jump @BLACKJ_8880 

:BLACKJ_8836
if 
  24@ == 1 
jf @BLACKJ_8880 
if 
  TIMERA > 500 
jf @BLACKJ_8880 
24@ = 2 

:BLACKJ_8880
jump @BLACKJ_9286 

:BLACKJ_8887
if 
   not 25@ == 0 
jf @BLACKJ_8912 
25@ = 0 

:BLACKJ_8912
if 
00E1:   player 0 pressed_key 17 
jf @BLACKJ_9261 
if 
   not 25@ == 1 
jf @BLACKJ_9228 
if 
  " + BJACK_Bet1 + @" > 10000 
jf @BLACKJ_8981 
" + BJACK_Bet_Step + @" = -1000 
jump @BLACKJ_9053 

:BLACKJ_8981
if 
  " + BJACK_Bet1 + @" > 1000 
jf @BLACKJ_9014 
" + BJACK_Bet_Step + @" = -100 
jump @BLACKJ_9053 

:BLACKJ_9014
if 
  " + BJACK_Bet1 + @" > 100 
jf @BLACKJ_9046 
" + BJACK_Bet_Step + @" = -10 
jump @BLACKJ_9053 

:BLACKJ_9046
" + BJACK_Bet_Step + @" = -1 

:BLACKJ_9053
008B: 10@ = " + BJACK_Bet1 + @" 
0058: " + BJACK_Bet1 + @" += " + BJACK_Bet_Step + @" 
if 
001F:   30@ > " + BJACK_Bet1 + @" 
jf @BLACKJ_9110 
" + BJACK_Bet1 + @" = 0 
008A: " + BJACK_Bet_Step + @" = 10@ 
" + BJACK_Bet_Step + @" *= -1 

:BLACKJ_9110
if 
001F:   30@ > " + BJACK_Bet1 + @" 
jf @BLACKJ_9144 
008A: " + BJACK_Bet1 + @" = 30@ 
jump @BLACKJ_9175 

:BLACKJ_9144
" + BJACK_Bet_Step + @" *= -1 
0060: " + BJACK_Refund + @" -= " + BJACK_Bet_Step + @" 
0060: " + BJACK_Initial_Stake + @" -= " + BJACK_Bet_Step + @" 
Player.Money(" + PlayerChar + @") += " + BJACK_Bet_Step + @"

:BLACKJ_9175
25@ += 1 
if 
  25@ > 1 
jf @BLACKJ_9214 
25@ = 2 
jump @BLACKJ_9221 

:BLACKJ_9214
TIMERA = 0 

:BLACKJ_9221
jump @BLACKJ_9254 

:BLACKJ_9228
if 
  TIMERA > 500 
jf @BLACKJ_9254 
25@ = 2 

:BLACKJ_9254
jump @BLACKJ_9286 

:BLACKJ_9261
if 
   not 25@ == 0 
jf @BLACKJ_9286 
25@ = 0 

:BLACKJ_9286
if 
  23@ == 0 
jf @BLACKJ_9404 
if 
00E1:   player 0 pressed_key 16 
jf @BLACKJ_9397 
0084: " + _9205 + @" = " + BJACK_Bet1 + @" 
0623: add " + BJACK_Bet1 + @" to_integer_stat 35 
008F: 13@ = integer " + BJACK_Bet1 + @" to_float 
13@ *= 0.001 
0624: add 13@ to_float_stat 81 
" + BJACK_Refund + @" = 0 
0084: " + BJACK_last_bet + @" = " + BJACK_Bet1 + @" 
gosub @BLACKJ_24857 
23@ = 1 
3@ = 99 

:BLACKJ_9397
jump @BLACKJ_9428 

:BLACKJ_9404
if 
80E1:   not player 0 pressed_key 16 
jf @BLACKJ_9428 
23@ = 0 

:BLACKJ_9428
gosub @BLACKJ_23204 
if 
   not 3@ == 99 
jf @BLACKJ_9460 
3@ += 1 

:BLACKJ_9460
jump @BLACKJ_9542 

:BLACKJ_9467
if 
  23@ == 0 
jf @BLACKJ_9518 
if 
00E1:   player 0 pressed_key 16 
jf @BLACKJ_9511 
23@ = 1 
00BE: text_clear_all 

:BLACKJ_9511
jump @BLACKJ_9542 

:BLACKJ_9518
if 
80E1:   not player 0 pressed_key 16 
jf @BLACKJ_9542 
23@ = 0 

:BLACKJ_9542
if 
  3@ == 2 
jf @BLACKJ_9574 
gosub @BLACKJ_24857 
3@ = 1 

:BLACKJ_9574
if 
  3@ == 99 
jf @BLACKJ_9613 
gosub @BLACKJ_10563 
3@ = 0 
2@ += 1 

:BLACKJ_9613
return 

:BLACKJ_9615
if 
  3@ == 0 
jf @BLACKJ_9673 
gosub @BLACKJ_29764 
if 
   not " + BJACK_Card_ID + @" == 0 
jf @BLACKJ_9666 
0084: " + tmp_9149 + @"[0] = " + BJACK_Card_ID + @" 

:BLACKJ_9666
3@ += 1 

:BLACKJ_9673
if 
  3@ == 1 
jf @BLACKJ_9743 
if 
   not Actor.Dead(1@)
jf @BLACKJ_9743 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_9743 
3@ += 1 

:BLACKJ_9743
if 
  3@ == 2 
jf @BLACKJ_9801 
gosub @BLACKJ_29764 
if 
   not " + BJACK_Card_ID + @" == 0 
jf @BLACKJ_9794 
0084: " + tmp_9141 + @"[0] = " + BJACK_Card_ID + @" 

:BLACKJ_9794
3@ += 1 

:BLACKJ_9801
if 
  3@ == 3 
jf @BLACKJ_9871 
if 
   not Actor.Dead(1@)
jf @BLACKJ_9871 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_9871 
3@ += 1 

:BLACKJ_9871
if 
  3@ == 4 
jf @BLACKJ_9929 
gosub @BLACKJ_29764 
if 
   not " + BJACK_Card_ID + @" == 0 
jf @BLACKJ_9922 
0084: " + tmp_9149 + @"[1] = " + BJACK_Card_ID + @" 

:BLACKJ_9922
3@ += 1 

:BLACKJ_9929
if 
  3@ == 5 
jf @BLACKJ_9999 
if 
   not Actor.Dead(1@)
jf @BLACKJ_9999 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_9999 
3@ += 1 

:BLACKJ_9999
if 
  3@ == 6 
jf @BLACKJ_10057 
gosub @BLACKJ_29764 
if 
   not " + BJACK_Card_ID + @" == 0 
jf @BLACKJ_10050 
0084: " + tmp_9141 + @"[1] = " + BJACK_Card_ID + @" 

:BLACKJ_10050
3@ += 1 

:BLACKJ_10057
if 
  3@ == 7 
jf @BLACKJ_10127 
if 
   not Actor.Dead(1@)
jf @BLACKJ_10127 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_10127 
3@ = 99 

:BLACKJ_10127
if 
  3@ == 99 
jf @BLACKJ_10166 
21@ = 0 
3@ = 0 
2@ += 1 

:BLACKJ_10166
gosub @BLACKJ_31220 
gosub @BLACKJ_29865 
gosub @BLACKJ_25143 
return 

:BLACKJ_10189
gosub @BLACKJ_10563 
if 
  3@ == 0 
jf @BLACKJ_10352 
gosub @BLACKJ_31220 
" + BJACK_Player_got_BJACK + @" = 0 
" + _9189 + @" = 0 
if or
  " + BJACK_Player_total1 + @" == 21 
  " + BJACK_Dealer_total + @" == 21 
jf @BLACKJ_10345 
if 
  " + BJACK_Player_total1 + @" == 21 
jf @BLACKJ_10285 
" + BJACK_Player_got_BJACK + @" = 1 

:BLACKJ_10285
if 
  " + BJACK_Dealer_total + @" == 21 
jf @BLACKJ_10310 
" + _9189 + @" = 1 

:BLACKJ_10310
" + BJACK_Player_has_stucked1 + @" = 1 
" + BJACK_Dealer_has_stuck + @" = 1 
2@ += 2 
3@ = 0 
jump @BLACKJ_10352 

:BLACKJ_10345
3@ = 99 

:BLACKJ_10352
if 
  3@ == 99 
jf @BLACKJ_10398 
3@ = 0 
4@ = 0 
21@ = 0 
2@ += 1 

:BLACKJ_10398
gosub @BLACKJ_31220 
gosub @BLACKJ_29865 
gosub @BLACKJ_25143 
if 
  " + BJACK_Player_got_BJACK + @" == 0 
jf @BLACKJ_10451 
gosub @BLACKJ_18456 
jump @BLACKJ_10561 

:BLACKJ_10451
if 
   not " + BJACK_Dealer_total + @" == 21 
jf @BLACKJ_10554 
if 
   not Actor.Dead(1@)
jf @BLACKJ_10547 
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_10533 
09D6: unknown_set_actor 1@ sound 5811 flags 1 1 0 
jump @BLACKJ_10547 

:BLACKJ_10533
09D6: unknown_set_actor 1@ sound 5812 flags 1 1 0 

:BLACKJ_10547
jump @BLACKJ_10561 

:BLACKJ_10554
gosub @BLACKJ_18456 

:BLACKJ_10561
return 

:BLACKJ_10563
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_10620 
03E6: remove_text_box 

:BLACKJ_10620
return 

:BLACKJ_10622
if 
  3@ == 0 
jf @BLACKJ_12235 
if 
  " + BJACK_Player_cannot_Split + @" == 0 
jf @BLACKJ_10808 
0084: " + _9314 + @" = " + tmp_9149 + @"[0] 
gosub @BLACKJ_32241 
008B: 10@ = " + _9315 + @" 
0084: " + _9314 + @" = " + tmp_9149 + @"[1] 
gosub @BLACKJ_32241 
008B: 11@ = " + _9315 + @" 
if 
003B:   10@ == 11@ 
jf @BLACKJ_10762 
if 
   not " + tmp_9149 + @"[2] == 0 
jf @BLACKJ_10755 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_Split + @" = 1 

:BLACKJ_10755
jump @BLACKJ_10776 

:BLACKJ_10762
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_Split + @" = 1 

:BLACKJ_10776
if 
   not " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_10808 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_Split + @" = 1 

:BLACKJ_10808
if 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11140 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_10939 
if 
   not " + tmp_9149 + @"[2] == 0 
jf @BLACKJ_10876 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_double + @" = 1 

:BLACKJ_10876
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Bet1 + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_10932 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_double + @" = 1 

:BLACKJ_10932
jump @BLACKJ_11140 

:BLACKJ_10939
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_11052 
if 
   not " + tmp_9149 + @"[2] == 0 
jf @BLACKJ_10989 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_double + @" = 1 

:BLACKJ_10989
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Bet1 + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_11045 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_double + @" = 1 

:BLACKJ_11045
jump @BLACKJ_11140 

:BLACKJ_11052
if 
   not " + tmp_9157 + @"[2] == 0 
jf @BLACKJ_11084 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_double + @" = 1 

:BLACKJ_11084
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Bet2 + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_11140 
gosub @BLACKJ_10563 
" + BJACK_Player_cannot_double + @" = 1 

:BLACKJ_11140
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_11744 
if and
  " + BJACK_Player_cannot_Split + @" == 0 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11256 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11249 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H3'  

:BLACKJ_11249
21@ = 1 

:BLACKJ_11256
if and
  " + BJACK_Player_cannot_Split + @" == 1 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11317 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11310 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H2'  

:BLACKJ_11310
21@ = 2 

:BLACKJ_11317
if and
  " + BJACK_Player_cannot_Split + @" == 1 
  " + BJACK_Player_cannot_double + @" == 1 
jf @BLACKJ_11378 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11371 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H5'  

:BLACKJ_11371
21@ = 3 

:BLACKJ_11378
if and
  " + BJACK_Player_cannot_Split + @" == 1 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11439 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11432 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H2'  

:BLACKJ_11432
21@ = 2 

:BLACKJ_11439
if and
  " + BJACK_Player_cannot_Split + @" == 1 
  " + BJACK_Player_cannot_double + @" == 1 
jf @BLACKJ_11500 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11493 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H5'  

:BLACKJ_11493
21@ = 3 

:BLACKJ_11500
if and
  " + BJACK_Player_cannot_Split + @" == 0 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11561 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11554 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H3'  

:BLACKJ_11554
21@ = 1 

:BLACKJ_11561
if and
  " + BJACK_Player_cannot_Split + @" == 1 
  " + BJACK_Player_cannot_double + @" == 1 
jf @BLACKJ_11622 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11615 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H5'  

:BLACKJ_11615
21@ = 3 

:BLACKJ_11622
if and
  " + BJACK_Player_cannot_Split + @" == 0 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11683 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11676 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H3'  

:BLACKJ_11676
21@ = 1 

:BLACKJ_11683
if and
  " + BJACK_Player_cannot_Split + @" == 1 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_11744 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_11737 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H2'  

:BLACKJ_11737
21@ = 2 

:BLACKJ_11744
if 
876F:   not text_priority_displayed 
jf @BLACKJ_12160 
if 
  25@ == 0 
jf @BLACKJ_11834 
if 
00E1:   player 0 pressed_key 17 
jf @BLACKJ_11827 
" + BJACK_Player_has_hit1 + @" = 1 
4@ = 0 
3@ += 1 
25@ = 1 
jump @BLACKJ_12235 

:BLACKJ_11827
jump @BLACKJ_11858 

:BLACKJ_11834
if 
80E1:   not player 0 pressed_key 17 
jf @BLACKJ_11858 
25@ = 0 

:BLACKJ_11858
if 
  " + BJACK_Player_cannot_Split + @" == 0 
jf @BLACKJ_11939 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_11939 
if 
00E1:   player 0 pressed_key 7 
jf @BLACKJ_11939 
" + BJACK_Player_has_split + @" = 1 
3@ += 1 
4@ = 0 
jump @BLACKJ_12235 

:BLACKJ_11939
if 
  " + BJACK_Player_cannot_double + @" == 0 
jf @BLACKJ_12027 
if 
00E1:   player 0 pressed_key 14 
jf @BLACKJ_12027 
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_12006 
" + BJACK_Player_has_doubled1 + @" = 1 
jump @BLACKJ_12013 

:BLACKJ_12006
" + BJACK_Player_has_doubled2 + @" = 1 

:BLACKJ_12013
3@ += 1 
jump @BLACKJ_12235 

:BLACKJ_12027
if 
  23@ == 0 
jf @BLACKJ_12129 
if 
00E1:   player 0 pressed_key 16 
jf @BLACKJ_12122 
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_12094 
" + BJACK_Player_has_stucked1 + @" = 1 
jump @BLACKJ_12101 

:BLACKJ_12094
" + BJACK_Player_has_stucked2 + @" = 1 

:BLACKJ_12101
23@ = 1 
3@ += 1 
jump @BLACKJ_12235 

:BLACKJ_12122
jump @BLACKJ_12153 

:BLACKJ_12129
if 
80E1:   not player 0 pressed_key 16 
jf @BLACKJ_12153 
23@ = 0 

:BLACKJ_12153
jump @BLACKJ_12235 

:BLACKJ_12160
if 
  25@ == 0 
jf @BLACKJ_12211 
if 
00E1:   player 0 pressed_key 17 
jf @BLACKJ_12204 
25@ = 1 
00BE: text_clear_all 

:BLACKJ_12204
jump @BLACKJ_12235 

:BLACKJ_12211
if 
80E1:   not player 0 pressed_key 17 
jf @BLACKJ_12235 
25@ = 0 

:BLACKJ_12235
if 
  3@ == 1 
jf @BLACKJ_15204 
if 
  " + BJACK_Player_has_hit1 + @" == 1 
jf @BLACKJ_12734 
if 
  4@ == 0 
jf @BLACKJ_12303 
gosub @BLACKJ_29764 
4@ += 1 

:BLACKJ_12303
if 
  4@ == 1 
jf @BLACKJ_12373 
if 
   not Actor.Dead(1@)
jf @BLACKJ_12373 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_12373 
4@ += 1 

:BLACKJ_12373
if 
  4@ == 2 
jf @BLACKJ_12702 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_12503 
10@ = 0 

:BLACKJ_12416
if 
  8 > 10@ 
jf @BLACKJ_12496 
if 
  " + tmp_9149 + @"(10@,8i) == 0 
jf @BLACKJ_12482 
0084: " + tmp_9149 + @"(10@,8i) = " + BJACK_Card_ID + @" 
10@ = 8 
4@ = 99 

:BLACKJ_12482
10@ += 1 
jump @BLACKJ_12416 

:BLACKJ_12496
jump @BLACKJ_12702 

:BLACKJ_12503
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_12615 
10@ = 0 

:BLACKJ_12528
if 
  8 > 10@ 
jf @BLACKJ_12608 
if 
  " + tmp_9149 + @"(10@,8i) == 0 
jf @BLACKJ_12594 
0084: " + tmp_9149 + @"(10@,8i) = " + BJACK_Card_ID + @" 
10@ = 8 
4@ = 99 

:BLACKJ_12594
10@ += 1 
jump @BLACKJ_12528 

:BLACKJ_12608
jump @BLACKJ_12702 

:BLACKJ_12615
10@ = 0 

:BLACKJ_12622
if 
  8 > 10@ 
jf @BLACKJ_12702 
if 
  " + tmp_9157 + @"(10@,8i) == 0 
jf @BLACKJ_12688 
0084: " + tmp_9157 + @"(10@,8i) = " + BJACK_Card_ID + @" 
10@ = 8 
4@ = 99 

:BLACKJ_12688
10@ += 1 
jump @BLACKJ_12622 

:BLACKJ_12702
if 
  4@ == 99 
jf @BLACKJ_12734 
" + BJACK_Player_has_hit1 + @" = 0 
gosub @BLACKJ_18456 

:BLACKJ_12734
10@ = 0 
if 
  " + BJACK_Player_has_split + @" == 1 
jf @BLACKJ_12791 
if or
  " + tmp_9157 + @"[0] == 0 
  " + tmp_9149 + @"[1] == 0 
jf @BLACKJ_12791 
10@ = 1 

:BLACKJ_12791
if and
  " + BJACK_Player_has_split + @" == 1 
  10@ == 1 
jf @BLACKJ_13266 
if 
  4@ == 0 
jf @BLACKJ_12943 
008D: " + _9195 + @" = integer " + BJACK_Bet1 + @" to_float 
008C: " + BJACK_Half_Bet + @" = float " + _9195 + @" to_integer 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Half_Bet + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_12936 
" + BJACK_Player_has_split + @" = 0 
4@ = 99 
00BC: show_text_highpriority GXT 'BJ_3' time 5000 flag 1  
gosub @BLACKJ_18303 
jump @BLACKJ_12943 

:BLACKJ_12936
4@ += 1 

:BLACKJ_12943
if 
  4@ == 1 
jf @BLACKJ_13045 
0623: add " + BJACK_Half_Bet + @" to_integer_stat 35 
008F: 13@ = integer " + BJACK_Half_Bet + @" to_float 
13@ *= 0.001 
0624: add 13@ to_float_stat 81 
" + BJACK_Half_Bet + @" *= -1 
Player.Money(" + PlayerChar + @") += " + BJACK_Half_Bet + @"
" + BJACK_Half_Bet + @" *= -1 
0058: " + BJACK_Bet1 + @" += " + BJACK_Half_Bet + @" 
0058: " + BJACK_Initial_Stake + @" += " + BJACK_Half_Bet + @" 
gosub @BLACKJ_23204 
4@ += 1 

:BLACKJ_13045
if 
  4@ == 2 
jf @BLACKJ_13100 
0084: " + tmp_9157 + @"[0] = " + tmp_9149 + @"[0] 
0084: " + tmp_9149 + @"[0] = " + tmp_9149 + @"[1] 
" + tmp_9149 + @"[1] = 0 
gosub @BLACKJ_29764 
4@ += 1 

:BLACKJ_13100
if 
  4@ == 3 
jf @BLACKJ_13178 
if 
   not Actor.Dead(1@)
jf @BLACKJ_13178 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_13178 
0084: " + tmp_9149 + @"[1] = " + BJACK_Card_ID + @" 
4@ += 1 

:BLACKJ_13178
if 
  4@ == 4 
jf @BLACKJ_13266 
008D: " + _9195 + @" = integer " + BJACK_Bet1 + @" to_float 
" + _9195 + @" /= 2.0 
008C: " + BJACK_Half_Bet + @" = float " + _9195 + @" to_integer 
0084: " + BJACK_Bet1 + @" = " + BJACK_Half_Bet + @" 
0084: " + BJACK_Bet2 + @" = " + BJACK_Half_Bet + @" 
" + BJACK_Player_cannot_double + @" = 0 
gosub @BLACKJ_10563 
gosub @BLACKJ_18456 
4@ = 99 

:BLACKJ_13266
if and
  " + BJACK_Player_has_split + @" == 1 
  " + BJACK_Player_has_stucked1 + @" == 1 
  " + tmp_9157 + @"[1] == 0 
jf @BLACKJ_13472 
if 
  4@ == 0 
jf @BLACKJ_13330 
gosub @BLACKJ_29764 
4@ += 1 

:BLACKJ_13330
if 
  4@ == 1 
jf @BLACKJ_13400 
if 
   not Actor.Dead(1@)
jf @BLACKJ_13400 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_13400 
4@ += 1 

:BLACKJ_13400
if 
  4@ == 2 
jf @BLACKJ_13454 
0084: " + tmp_9157 + @"[1] = " + BJACK_Card_ID + @" 
" + BJACK_Player_cannot_double + @" = 0 
gosub @BLACKJ_10563 
gosub @BLACKJ_18456 
4@ = 99 

:BLACKJ_13454
if 
  4@ == 99 
jf @BLACKJ_13472 

:BLACKJ_13472
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_13875 
if and
  " + BJACK_Player_has_doubled1 + @" == 1 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_13868 
if 
  4@ == 0 
jf @BLACKJ_13642 
008D: " + _9195 + @" = integer " + BJACK_Bet1 + @" to_float 
008C: " + BJACK_Half_Bet + @" = float " + _9195 + @" to_integer 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Half_Bet + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_13635 
" + BJACK_Player_has_doubled1 + @" = 0 
4@ = 99 
00BC: show_text_highpriority GXT 'BJ_3' time 5000 flag 1  
gosub @BLACKJ_18303 
jump @BLACKJ_13642 

:BLACKJ_13635
4@ += 1 

:BLACKJ_13642
if 
  4@ == 1 
jf @BLACKJ_13751 
0623: add " + BJACK_Half_Bet + @" to_integer_stat 35 
008F: 13@ = integer " + BJACK_Half_Bet + @" to_float 
13@ *= 0.001 
0624: add 13@ to_float_stat 81 
" + BJACK_Half_Bet + @" *= -1 
Player.Money(" + PlayerChar + @") += " + BJACK_Half_Bet + @"
" + BJACK_Half_Bet + @" *= -1 
0058: " + BJACK_Bet1 + @" += " + BJACK_Half_Bet + @" 
0058: " + BJACK_Initial_Stake + @" += " + BJACK_Half_Bet + @" 
gosub @BLACKJ_23204 
gosub @BLACKJ_29764 
4@ += 1 

:BLACKJ_13751
if 
  4@ == 2 
jf @BLACKJ_13821 
if 
   not Actor.Dead(1@)
jf @BLACKJ_13821 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_13821 
4@ += 1 

:BLACKJ_13821
if 
  4@ == 3 
jf @BLACKJ_13868 
0084: " + tmp_9149 + @"[2] = " + BJACK_Card_ID + @" 
" + BJACK_Player_has_stucked1 + @" = 1 
gosub @BLACKJ_18456 
4@ = 99 

:BLACKJ_13868
jump @BLACKJ_14638 

:BLACKJ_13875
if and
  " + BJACK_Player_has_doubled1 + @" == 1 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_14260 
if 
  4@ == 0 
jf @BLACKJ_14027 
008D: " + _9195 + @" = integer " + BJACK_Bet1 + @" to_float 
008C: " + BJACK_Half_Bet + @" = float " + _9195 + @" to_integer 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Half_Bet + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_14020 
" + BJACK_Player_has_doubled1 + @" = 0 
00BC: show_text_highpriority GXT 'BJ_3' time 5000 flag 1  
gosub @BLACKJ_18303 
4@ = 99 
jump @BLACKJ_14027 

:BLACKJ_14020
4@ += 1 

:BLACKJ_14027
if 
  4@ == 1 
jf @BLACKJ_14136 
0623: add " + BJACK_Half_Bet + @" to_integer_stat 35 
008F: 13@ = integer " + BJACK_Half_Bet + @" to_float 
13@ *= 0.001 
0624: add 13@ to_float_stat 81 
" + BJACK_Half_Bet + @" *= -1 
Player.Money(" + PlayerChar + @") += " + BJACK_Half_Bet + @"
" + BJACK_Half_Bet + @" *= -1 
0058: " + BJACK_Bet1 + @" += " + BJACK_Half_Bet + @" 
0058: " + BJACK_Initial_Stake + @" += " + BJACK_Half_Bet + @" 
gosub @BLACKJ_23204 
gosub @BLACKJ_29764 
4@ += 1 

:BLACKJ_14136
if 
  4@ == 2 
jf @BLACKJ_14206 
if 
   not Actor.Dead(1@)
jf @BLACKJ_14206 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_14206 
4@ += 1 

:BLACKJ_14206
if 
  4@ == 3 
jf @BLACKJ_14260 
0084: " + tmp_9149 + @"[2] = " + BJACK_Card_ID + @" 
" + BJACK_Player_has_stucked1 + @" = 1 
gosub @BLACKJ_18456 
4@ = 0 
jump @BLACKJ_13266 

:BLACKJ_14260
if and
  " + BJACK_Player_has_doubled2 + @" == 1 
  " + BJACK_Player_has_stucked2 + @" == 0 
jf @BLACKJ_14638 
if 
  4@ == 0 
jf @BLACKJ_14412 
008D: " + _9195 + @" = integer " + BJACK_Bet1 + @" to_float 
008C: " + BJACK_Half_Bet + @" = float " + _9195 + @" to_integer 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
gosub @BLACKJ_33768 
0058: " + BJACK_Player_cash + @" += " + Max_Wager + @" 
if 
001C:   " + BJACK_Half_Bet + @" > " + BJACK_Player_cash + @" 
jf @BLACKJ_14405 
" + BJACK_Player_has_doubled2 + @" = 0 
4@ = 99 
00BC: show_text_highpriority GXT 'BJ_3' time 5000 flag 1  
gosub @BLACKJ_18303 
jump @BLACKJ_14412 

:BLACKJ_14405
4@ += 1 

:BLACKJ_14412
if 
  4@ == 1 
jf @BLACKJ_14521 
0623: add " + BJACK_Half_Bet + @" to_integer_stat 35 
008F: 13@ = integer " + BJACK_Half_Bet + @" to_float 
13@ *= 0.001 
0624: add 13@ to_float_stat 81 
" + BJACK_Half_Bet + @" *= -1 
Player.Money(" + PlayerChar + @") += " + BJACK_Half_Bet + @"
" + BJACK_Half_Bet + @" *= -1 
0058: " + BJACK_Bet2 + @" += " + BJACK_Half_Bet + @" 
0058: " + BJACK_Initial_Stake + @" += " + BJACK_Half_Bet + @" 
gosub @BLACKJ_23204 
gosub @BLACKJ_29764 
4@ += 1 

:BLACKJ_14521
if 
  4@ == 2 
jf @BLACKJ_14591 
if 
   not Actor.Dead(1@)
jf @BLACKJ_14591 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_14591 
4@ += 1 

:BLACKJ_14591
if 
  4@ == 3 
jf @BLACKJ_14638 
0084: " + tmp_9157 + @"[2] = " + BJACK_Card_ID + @" 
" + BJACK_Player_has_stucked2 + @" = 1 
gosub @BLACKJ_18456 
4@ = 99 

:BLACKJ_14638
gosub @BLACKJ_31220 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_14720 
if 
  " + BJACK_Player_total1 + @" > 20 
jf @BLACKJ_14688 
" + BJACK_Player_has_stucked1 + @" = 1 

:BLACKJ_14688
if 
   not " + tmp_9149 + @"[4] == 0 
jf @BLACKJ_14713 
" + BJACK_Player_has_stucked1 + @" = 1 

:BLACKJ_14713
jump @BLACKJ_14866 

:BLACKJ_14720
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_14816 
if 
  " + BJACK_Player_total1 + @" > 20 
jf @BLACKJ_14777 
" + BJACK_Player_has_stucked1 + @" = 1 
4@ = 0 
jump @BLACKJ_13266 

:BLACKJ_14777
if 
   not " + tmp_9149 + @"[4] == 0 
jf @BLACKJ_14816 
" + BJACK_Player_has_stucked1 + @" = 1 
4@ = 0 
jump @BLACKJ_13266 

:BLACKJ_14816
if 
  " + BJACK_Player_total2 + @" > 20 
jf @BLACKJ_14841 
" + BJACK_Player_has_stucked2 + @" = 1 

:BLACKJ_14841
if 
   not " + tmp_9157 + @"[4] == 0 
jf @BLACKJ_14866 
" + BJACK_Player_has_stucked2 + @" = 1 

:BLACKJ_14866
if 
  " + BJACK_Player_has_split + @" == 1 
jf @BLACKJ_15044 
if and
  " + BJACK_Player_has_stucked1 + @" == 1 
  " + BJACK_Player_has_stucked2 + @" == 1 
jf @BLACKJ_15044 
if and
  " + BJACK_Player_total1 + @" == 21 
  " + tmp_9149 + @"[2] == 0 
jf @BLACKJ_15012 
if or
   not " + BJACK_Player_total2 + @" == 21 
   not " + tmp_9157 + @"[2] == 0 
jf @BLACKJ_14973 
" + BJACK_Player_got_BJACK + @" = 2 
jump @BLACKJ_15005 

:BLACKJ_14973
if and
  " + BJACK_Player_total2 + @" == 21 
  " + tmp_9157 + @"[2] == 0 
jf @BLACKJ_15005 
" + BJACK_Player_got_BJACK + @" = 4 

:BLACKJ_15005
jump @BLACKJ_15044 

:BLACKJ_15012
if and
  " + BJACK_Player_total2 + @" == 21 
  " + tmp_9157 + @"[2] == 0 
jf @BLACKJ_15044 
" + BJACK_Player_got_BJACK + @" = 3 

:BLACKJ_15044
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_15133 
if 
  " + BJACK_Player_has_stucked1 + @" == 1 
jf @BLACKJ_15094 
3@ = 99 
jump @BLACKJ_15126 

:BLACKJ_15094
if 
  4@ == 99 
jf @BLACKJ_15126 
3@ = 0 
4@ = 0 

:BLACKJ_15126
jump @BLACKJ_15204 

:BLACKJ_15133
if and
  " + BJACK_Player_has_stucked1 + @" == 1 
  " + BJACK_Player_has_stucked2 + @" == 1 
jf @BLACKJ_15172 
3@ = 99 
jump @BLACKJ_15204 

:BLACKJ_15172
if 
  4@ == 99 
jf @BLACKJ_15204 
3@ = 0 
4@ = 0 

:BLACKJ_15204
if 
  " + BJACK_Player_has_split + @" == 1 
jf @BLACKJ_15295 
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_15271 
gosub @BLACKJ_34152 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[22] " + tmp_BJACK_Y_Screenpos + @"[22] GXT 'BJ_ARR'  
jump @BLACKJ_15295 

:BLACKJ_15271
gosub @BLACKJ_34152 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[23] " + tmp_BJACK_Y_Screenpos + @"[23] GXT 'BJ_ARR'  

:BLACKJ_15295
if 
  3@ == 99 
jf @BLACKJ_15334 
gosub @BLACKJ_10563 
3@ = 0 
2@ += 1 

:BLACKJ_15334
gosub @BLACKJ_31220 
gosub @BLACKJ_29865 
gosub @BLACKJ_25143 
return 

:BLACKJ_15357
if 
  3@ == 0 
jf @BLACKJ_15510 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_15439 
if 
  " + BJACK_Player_total1 + @" > 21 
jf @BLACKJ_15432 
" + BJACK_Dealer_has_stuck + @" = 1 
" + BJACK_Dealer_wins_by_default + @" = 1 
3@ = 99 

:BLACKJ_15432
jump @BLACKJ_15485 

:BLACKJ_15439
if and
  " + BJACK_Player_total1 + @" > 21 
  " + BJACK_Player_total2 + @" > 21 
jf @BLACKJ_15485 
" + BJACK_Dealer_has_stuck + @" = 1 
" + BJACK_Dealer_wins_by_default + @" = 1 
3@ = 99 

:BLACKJ_15485
if 
   not 3@ == 99 
jf @BLACKJ_15510 
3@ += 1 

:BLACKJ_15510
if 
  3@ == 1 
jf @BLACKJ_15617 
if 
  " + BJACK_Dealer_total + @" > 16 
jf @BLACKJ_15560 
" + BJACK_Dealer_has_stuck + @" = 1 
jump @BLACKJ_15567 

:BLACKJ_15560
3@ += 1 

:BLACKJ_15567
if 
   not " + tmp_9141 + @"[4] == 0 
jf @BLACKJ_15592 
" + BJACK_Dealer_has_stuck + @" = 1 

:BLACKJ_15592
if 
  " + BJACK_Dealer_has_stuck + @" == 1 
jf @BLACKJ_15617 
3@ = 99 

:BLACKJ_15617
if 
  3@ == 2 
jf @BLACKJ_15649 
gosub @BLACKJ_29764 
3@ += 1 

:BLACKJ_15649
if 
  3@ == 3 
jf @BLACKJ_15719 
if 
   not Actor.Dead(1@)
jf @BLACKJ_15719 
062E: get_actor 1@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @BLACKJ_15719 
3@ += 1 

:BLACKJ_15719
if 
  3@ == 4 
jf @BLACKJ_15824 
10@ = 0 

:BLACKJ_15744
if 
  8 > 10@ 
jf @BLACKJ_15817 
if 
  " + tmp_9141 + @"(10@,8i) == 0 
jf @BLACKJ_15803 
0084: " + tmp_9141 + @"(10@,8i) = " + BJACK_Card_ID + @" 
10@ = 8 

:BLACKJ_15803
10@ += 1 
jump @BLACKJ_15744 

:BLACKJ_15817
3@ = 0 

:BLACKJ_15824
if 
  3@ == 99 
jf @BLACKJ_15856 
2@ += 1 
3@ = 0 

:BLACKJ_15856
gosub @BLACKJ_31220 
gosub @BLACKJ_29865 
gosub @BLACKJ_25143 
return 

:BLACKJ_15879
if 
  3@ == 0 
jf @BLACKJ_17945 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_16141 
if 
   not " + BJACK_Player_total1 + @" > 21 
jf @BLACKJ_16134 
if 
  " + BJACK_Dealer_total + @" > 21 
jf @BLACKJ_15965 
" + BJACK_Player_has_won1 + @" = 1 
jump @BLACKJ_16134 

:BLACKJ_15965
if 
001C:   " + BJACK_Player_total1 + @" > " + BJACK_Dealer_total + @" 
jf @BLACKJ_15998 
" + BJACK_Player_has_won1 + @" = 1 
jump @BLACKJ_16134 

:BLACKJ_15998
if 
003A:   " + BJACK_Player_total1 + @" == " + BJACK_Dealer_total + @" 
jf @BLACKJ_16127 
if 
  " + BJACK_Player_got_BJACK + @" == 1 
jf @BLACKJ_16081 
if 
  " + _9189 + @" == 1 
jf @BLACKJ_16067 
" + BJACK_Player_has_won1 + @" = 2 
jump @BLACKJ_16074 

:BLACKJ_16067
" + BJACK_Player_has_won1 + @" = 1 

:BLACKJ_16074
jump @BLACKJ_16120 

:BLACKJ_16081
if 
  " + _9189 + @" == 1 
jf @BLACKJ_16113 
" + BJACK_Player_has_won1 + @" = 0 
jump @BLACKJ_16120 

:BLACKJ_16113
" + BJACK_Player_has_won1 + @" = 2 

:BLACKJ_16120
jump @BLACKJ_16134 

:BLACKJ_16127
" + BJACK_Player_has_won1 + @" = 0 

:BLACKJ_16134
jump @BLACKJ_16593 

:BLACKJ_16141
if 
   not " + BJACK_Player_total1 + @" > 21 
jf @BLACKJ_16367 
if 
  " + BJACK_Dealer_total + @" > 21 
jf @BLACKJ_16191 
" + BJACK_Player_has_won1 + @" = 1 
jump @BLACKJ_16367 

:BLACKJ_16191
if 
001C:   " + BJACK_Player_total1 + @" > " + BJACK_Dealer_total + @" 
jf @BLACKJ_16224 
" + BJACK_Player_has_won1 + @" = 1 
jump @BLACKJ_16367 

:BLACKJ_16224
if 
003A:   " + BJACK_Player_total1 + @" == " + BJACK_Dealer_total + @" 
jf @BLACKJ_16360 
if or
  " + BJACK_Player_got_BJACK + @" == 2 
  " + BJACK_Player_got_BJACK + @" == 4 
jf @BLACKJ_16314 
if 
  " + _9189 + @" == 1 
jf @BLACKJ_16300 
" + BJACK_Player_has_won1 + @" = 2 
jump @BLACKJ_16307 

:BLACKJ_16300
" + BJACK_Player_has_won1 + @" = 1 

:BLACKJ_16307
jump @BLACKJ_16353 

:BLACKJ_16314
if 
  " + _9189 + @" == 1 
jf @BLACKJ_16346 
" + BJACK_Player_has_won1 + @" = 0 
jump @BLACKJ_16353 

:BLACKJ_16346
" + BJACK_Player_has_won1 + @" = 2 

:BLACKJ_16353
jump @BLACKJ_16367 

:BLACKJ_16360
" + BJACK_Player_has_won1 + @" = 0 

:BLACKJ_16367
if 
   not " + BJACK_Player_total2 + @" > 21 
jf @BLACKJ_16593 
if 
  " + BJACK_Dealer_total + @" > 21 
jf @BLACKJ_16417 
" + BJACK_Player_has_won2 + @" = 1 
jump @BLACKJ_16593 

:BLACKJ_16417
if 
001C:   " + BJACK_Player_total2 + @" > " + BJACK_Dealer_total + @" 
jf @BLACKJ_16450 
" + BJACK_Player_has_won2 + @" = 1 
jump @BLACKJ_16593 

:BLACKJ_16450
if 
003A:   " + BJACK_Player_total2 + @" == " + BJACK_Dealer_total + @" 
jf @BLACKJ_16586 
if or
  " + BJACK_Player_got_BJACK + @" == 3 
  " + BJACK_Player_got_BJACK + @" == 4 
jf @BLACKJ_16540 
if 
  " + _9189 + @" == 1 
jf @BLACKJ_16526 
" + BJACK_Player_has_won2 + @" = 2 
jump @BLACKJ_16533 

:BLACKJ_16526
" + BJACK_Player_has_won2 + @" = 1 

:BLACKJ_16533
jump @BLACKJ_16579 

:BLACKJ_16540
if 
  " + _9189 + @" == 1 
jf @BLACKJ_16572 
" + BJACK_Player_has_won2 + @" = 0 
jump @BLACKJ_16579 

:BLACKJ_16572
" + BJACK_Player_has_won2 + @" = 2 

:BLACKJ_16579
jump @BLACKJ_16593 

:BLACKJ_16586
" + BJACK_Player_has_won2 + @" = 0 

:BLACKJ_16593
TIMERA = 0 
" + BJACK_Payout + @" = 0 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_16738 
if 
  " + BJACK_Player_has_won1 + @" == 1 
jf @BLACKJ_16705 
if 
  " + BJACK_Player_got_BJACK + @" == 1 
jf @BLACKJ_16683 
" + BJACK_Payout + @" = 3 
0068: " + BJACK_Payout + @" *= " + BJACK_Bet1 + @" 
jump @BLACKJ_16698 

:BLACKJ_16683
" + BJACK_Payout + @" = 2 
0068: " + BJACK_Payout + @" *= " + BJACK_Bet1 + @" 

:BLACKJ_16698
jump @BLACKJ_16731 

:BLACKJ_16705
if 
  " + BJACK_Player_has_won1 + @" == 2 
jf @BLACKJ_16731 
0084: " + BJACK_Payout + @" = " + BJACK_Bet1 + @" 

:BLACKJ_16731
jump @BLACKJ_16980 

:BLACKJ_16738
if 
  " + BJACK_Player_has_won1 + @" == 1 
jf @BLACKJ_16825 
if or
  " + BJACK_Player_got_BJACK + @" == 2 
  " + BJACK_Player_got_BJACK + @" == 4 
jf @BLACKJ_16803 
" + BJACK_Payout + @" = 3 
0068: " + BJACK_Payout + @" *= " + BJACK_Bet1 + @" 
jump @BLACKJ_16818 

:BLACKJ_16803
" + BJACK_Payout + @" = 2 
0068: " + BJACK_Payout + @" *= " + BJACK_Bet1 + @" 

:BLACKJ_16818
jump @BLACKJ_16851 

:BLACKJ_16825
if 
  " + BJACK_Player_has_won1 + @" == 2 
jf @BLACKJ_16851 
0084: " + BJACK_Payout + @" = " + BJACK_Bet1 + @" 

:BLACKJ_16851
if 
  " + BJACK_Player_has_won2 + @" == 1 
jf @BLACKJ_16954 
if or
  " + BJACK_Player_got_BJACK + @" == 3 
  " + BJACK_Player_got_BJACK + @" == 4 
jf @BLACKJ_16924 
008B: 10@ = " + BJACK_Bet2 + @" 
10@ *= 3 
005E: " + BJACK_Payout + @" += 10@ 
jump @BLACKJ_16947 

:BLACKJ_16924
008B: 10@ = " + BJACK_Bet2 + @" 
10@ *= 2 
005E: " + BJACK_Payout + @" += 10@ 

:BLACKJ_16947
jump @BLACKJ_16980 

:BLACKJ_16954
if 
  " + BJACK_Player_has_won2 + @" == 2 
jf @BLACKJ_16980 
0058: " + BJACK_Payout + @" += " + BJACK_Bet2 + @" 

:BLACKJ_16980
008B: 10@ = " + BJACK_Payout + @" 
0064: 10@ -= " + BJACK_Initial_Stake + @" 
0623: add 10@ to_integer_stat 37 
Player.Money(" + PlayerChar + @") += " + BJACK_Payout + @"" );
                create_thread<CASHWIN>( _local10, 3000, 69 );
AppendLine( @"08F8: display_stat_update_box 0 
if 
  10@ > 0 
jf @BLACKJ_17498 
0627: update_integer_stat 38 to 10@ 
0093: 13@ = integer 10@ to_float 
0093: 14@ = integer 29@ to_float 
0073: 13@ /= 14@ 
" + _9325 + @" += 1 
if 
  5 > " + _9325 + @" 
jf @BLACKJ_17333 
if 
   not Actor.Dead(1@)
jf @BLACKJ_17326 
if 
  13@ > 0.8 
jf @BLACKJ_17158 
0209: 10@ = random_int_in_ranges 0 4 
jump @BLACKJ_17167 

:BLACKJ_17158
0209: 10@ = random_int_in_ranges 0 3 

:BLACKJ_17167
0871: init_jump_table 10@ total_jumps 4 default_jump 0 @BLACKJ_17326 jumps 0 @BLACKJ_17230 1 @BLACKJ_17251 2 @BLACKJ_17272 3 @BLACKJ_17293 -1 @BLACKJ_17326 -1 @BLACKJ_17326 -1 @BLACKJ_17326 

:BLACKJ_17230
09D6: unknown_set_actor 1@ sound 5847 flags 1 1 0 
jump @BLACKJ_17326 

:BLACKJ_17251
09D6: unknown_set_actor 1@ sound 5848 flags 1 1 0 
jump @BLACKJ_17326 

:BLACKJ_17272
09D6: unknown_set_actor 1@ sound 5849 flags 1 1 0 
jump @BLACKJ_17326 

:BLACKJ_17293
if 
   Player.Defined(" + PlayerChar + @")
jf @BLACKJ_17319 
0947: actor " + PlayerActor + @" speak_from_audio_table 100 store_spoken_phrase_id_to 10@ 

:BLACKJ_17319
jump @BLACKJ_17326 

:BLACKJ_17326
jump @BLACKJ_17491 

:BLACKJ_17333
if 
   not Actor.Dead(1@)
jf @BLACKJ_17484 
0209: 10@ = random_int_in_ranges 0 3 
0871: init_jump_table 10@ total_jumps 3 default_jump 0 @BLACKJ_17484 jumps 0 @BLACKJ_17421 1 @BLACKJ_17442 2 @BLACKJ_17463 -1 @BLACKJ_17484 -1 @BLACKJ_17484 -1 @BLACKJ_17484 -1 @BLACKJ_17484 

:BLACKJ_17421
09D6: unknown_set_actor 1@ sound 5854 flags 1 1 0 
jump @BLACKJ_17484 

:BLACKJ_17442
09D6: unknown_set_actor 1@ sound 5855 flags 1 1 0 
jump @BLACKJ_17484 

:BLACKJ_17463
09D6: unknown_set_actor 1@ sound 5856 flags 1 1 0 
jump @BLACKJ_17484 

:BLACKJ_17484
" + _9325 + @" = 0 

:BLACKJ_17491
jump @BLACKJ_17920 

:BLACKJ_17498
10@ *= -1 
0627: update_integer_stat 39 to 10@ 
10@ *= -1 
" + _9325 + @" = 0 
0093: 13@ = integer 10@ to_float 
13@ *= -1.0 
0093: 14@ = integer 29@ to_float 
0073: 13@ /= 14@ 
if 
   not Actor.Dead(1@)
jf @BLACKJ_17920 
if 
  0 > 10@ 
jf @BLACKJ_17806 
if 
  13@ > 0.8 
jf @BLACKJ_17631 
0209: 10@ = random_int_in_ranges 0 4 
jump @BLACKJ_17640 

:BLACKJ_17631
0209: 10@ = random_int_in_ranges 0 3 

:BLACKJ_17640
0871: init_jump_table 10@ total_jumps 4 default_jump 0 @BLACKJ_17799 jumps 0 @BLACKJ_17703 1 @BLACKJ_17724 2 @BLACKJ_17745 3 @BLACKJ_17766 -1 @BLACKJ_17799 -1 @BLACKJ_17799 -1 @BLACKJ_17799 

:BLACKJ_17703
09D6: unknown_set_actor 1@ sound 5817 flags 1 1 0 
jump @BLACKJ_17799 

:BLACKJ_17724
09D6: unknown_set_actor 1@ sound 5818 flags 1 1 0 
jump @BLACKJ_17799 

:BLACKJ_17745
09D6: unknown_set_actor 1@ sound 5819 flags 1 1 0 
jump @BLACKJ_17799 

:BLACKJ_17766
if 
   Player.Defined(" + PlayerChar + @")
jf @BLACKJ_17792 
0947: actor " + PlayerActor + @" speak_from_audio_table 101 store_spoken_phrase_id_to 10@ 

:BLACKJ_17792
jump @BLACKJ_17799 

:BLACKJ_17799
jump @BLACKJ_17920 

:BLACKJ_17806
0209: 10@ = random_int_in_ranges 0 2 
0871: init_jump_table 10@ total_jumps 2 default_jump 0 @BLACKJ_17920 jumps 0 @BLACKJ_17878 1 @BLACKJ_17899 -1 @BLACKJ_17920 -1 @BLACKJ_17920 -1 @BLACKJ_17920 -1 @BLACKJ_17920 -1 @BLACKJ_17920 

:BLACKJ_17878
09D6: unknown_set_actor 1@ sound 5815 flags 1 1 0 
jump @BLACKJ_17920 

:BLACKJ_17899
09D6: unknown_set_actor 1@ sound 5816 flags 1 1 0 
jump @BLACKJ_17920 

:BLACKJ_17920
08F8: display_stat_update_box 1 
" + BJACK_Initial_Stake + @" = 0 
gosub @BLACKJ_23204 
3@ += 1 

:BLACKJ_17945
if 
  3@ == 1 
jf @BLACKJ_18076 
if 
  TIMERA > 3000 
jf @BLACKJ_17996 
3@ += 1 
jump @BLACKJ_18076 

:BLACKJ_17996
if 
  23@ == 0 
jf @BLACKJ_18052 
if 
00E1:   player 0 pressed_key 16 
jf @BLACKJ_18045 
23@ = 1 
3@ += 1 

:BLACKJ_18045
jump @BLACKJ_18076 

:BLACKJ_18052
if 
80E1:   not player 0 pressed_key 16 
jf @BLACKJ_18076 
23@ = 0 

:BLACKJ_18076
if 
  3@ == 2 
jf @BLACKJ_18108 
TIMERA = 0 
3@ += 1 

:BLACKJ_18108
if 
  3@ == 3 
jf @BLACKJ_18248 
if 
00E1:   player 0 pressed_key 16 
jf @BLACKJ_18164 
23@ = 1 
3@ = 99 
jump @BLACKJ_18248 

:BLACKJ_18164
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_18248 
if 
88FE:   not text_box_displayed 
jf @BLACKJ_18248 
0989: set_text_boxes_width 128 
0512: show_permanent_text_box 'BJ_H4'  

:BLACKJ_18248
if 
  3@ == 99 
jf @BLACKJ_18287 
gosub @BLACKJ_10563 
2@ = 1 
3@ = 0 

:BLACKJ_18287
gosub @BLACKJ_29865 
gosub @BLACKJ_25143 
return 

:BLACKJ_18303
if 
   not Actor.Dead(1@)
jf @BLACKJ_18454 
0209: 10@ = random_int_in_ranges 0 3 
0871: init_jump_table 10@ total_jumps 3 default_jump 0 @BLACKJ_18454 jumps 0 @BLACKJ_18391 1 @BLACKJ_18412 2 @BLACKJ_18433 -1 @BLACKJ_18454 -1 @BLACKJ_18454 -1 @BLACKJ_18454 -1 @BLACKJ_18454 

:BLACKJ_18391
09D6: unknown_set_actor 1@ sound 5823 flags 1 1 0 
jump @BLACKJ_18454 

:BLACKJ_18412
09D6: unknown_set_actor 1@ sound 5824 flags 1 1 0 
jump @BLACKJ_18454 

:BLACKJ_18433
09D6: unknown_set_actor 1@ sound 5825 flags 1 1 0 
jump @BLACKJ_18454 

:BLACKJ_18454
return 

:BLACKJ_18456
gosub @BLACKJ_31220 
if 
   not Actor.Dead(1@)
jf @BLACKJ_21799 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_19594 
if 
  " + BJACK_Player_total1_B + @" == 0 
jf @BLACKJ_19170 
0871: init_jump_table " + BJACK_Player_total1 + @" total_jumps 18 default_jump 1 @BLACKJ_19086 jumps 4 @BLACKJ_18708 5 @BLACKJ_18729 6 @BLACKJ_18750 7 @BLACKJ_18771 8 @BLACKJ_18792 9 @BLACKJ_18813 10 @BLACKJ_18834 
0872: jump_table_jumps 11 @BLACKJ_18855 12 @BLACKJ_18876 13 @BLACKJ_18897 14 @BLACKJ_18918 15 @BLACKJ_18939 16 @BLACKJ_18960 17 @BLACKJ_18981 18 @BLACKJ_19002 19 @BLACKJ_19023 
0872: jump_table_jumps 20 @BLACKJ_19044 21 @BLACKJ_19065 -1 @BLACKJ_19155 -1 @BLACKJ_19155 -1 @BLACKJ_19155 -1 @BLACKJ_19155 -1 @BLACKJ_19155 -1 @BLACKJ_19155 -1 @BLACKJ_19155 

:BLACKJ_18708
09D6: unknown_set_actor 1@ sound 5841 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18729
09D6: unknown_set_actor 1@ sound 5842 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18750
09D6: unknown_set_actor 1@ sound 5843 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18771
09D6: unknown_set_actor 1@ sound 5844 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18792
09D6: unknown_set_actor 1@ sound 5845 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18813
09D6: unknown_set_actor 1@ sound 5846 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18834
09D6: unknown_set_actor 1@ sound 5829 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18855
09D6: unknown_set_actor 1@ sound 5830 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18876
09D6: unknown_set_actor 1@ sound 5831 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18897
09D6: unknown_set_actor 1@ sound 5832 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18918
09D6: unknown_set_actor 1@ sound 5833 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18939
09D6: unknown_set_actor 1@ sound 5834 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18960
09D6: unknown_set_actor 1@ sound 5835 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_18981
09D6: unknown_set_actor 1@ sound 5836 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_19002
09D6: unknown_set_actor 1@ sound 5837 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_19023
09D6: unknown_set_actor 1@ sound 5838 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_19044
09D6: unknown_set_actor 1@ sound 5839 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_19065
09D6: unknown_set_actor 1@ sound 5840 flags 1 1 0 
jump @BLACKJ_19155 

:BLACKJ_19086
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_19134 
09D6: unknown_set_actor 1@ sound 5813 flags 1 1 0 
jump @BLACKJ_19148 

:BLACKJ_19134
09D6: unknown_set_actor 1@ sound 5814 flags 1 1 0 

:BLACKJ_19148
jump @BLACKJ_19155 

:BLACKJ_19155
0967: actor 1@ move_mouth 1500 ms 
jump @BLACKJ_19587 

:BLACKJ_19170
0871: init_jump_table " + BJACK_Player_total1 + @" total_jumps 10 default_jump 1 @BLACKJ_19510 jumps 12 @BLACKJ_19298 13 @BLACKJ_19319 14 @BLACKJ_19340 15 @BLACKJ_19361 16 @BLACKJ_19382 17 @BLACKJ_19403 18 @BLACKJ_19424 
0872: jump_table_jumps 19 @BLACKJ_19445 20 @BLACKJ_19466 21 @BLACKJ_19487 -1 @BLACKJ_19579 -1 @BLACKJ_19579 -1 @BLACKJ_19579 -1 @BLACKJ_19579 -1 @BLACKJ_19579 -1 @BLACKJ_19579 

:BLACKJ_19298
09D6: unknown_set_actor 1@ sound 5801 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19319
09D6: unknown_set_actor 1@ sound 5802 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19340
09D6: unknown_set_actor 1@ sound 5803 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19361
09D6: unknown_set_actor 1@ sound 5804 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19382
09D6: unknown_set_actor 1@ sound 5805 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19403
09D6: unknown_set_actor 1@ sound 5806 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19424
09D6: unknown_set_actor 1@ sound 5807 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19445
09D6: unknown_set_actor 1@ sound 5808 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19466
09D6: unknown_set_actor 1@ sound 5800 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19487
09D6: unknown_set_actor 1@ sound 65535 flags 1 1 0 
jump @BLACKJ_19579 

:BLACKJ_19510
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_19558 
09D6: unknown_set_actor 1@ sound 5813 flags 1 1 0 
jump @BLACKJ_19572 

:BLACKJ_19558
09D6: unknown_set_actor 1@ sound 5814 flags 1 1 0 

:BLACKJ_19572
jump @BLACKJ_19579 

:BLACKJ_19579
0967: actor 1@ move_mouth 3000 ms 

:BLACKJ_19587
jump @BLACKJ_21799 

:BLACKJ_19594
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_20709 
if 
  " + BJACK_Player_total1_B + @" == 0 
jf @BLACKJ_20285 
0871: init_jump_table " + BJACK_Player_total1 + @" total_jumps 18 default_jump 1 @BLACKJ_20201 jumps 4 @BLACKJ_19823 5 @BLACKJ_19844 6 @BLACKJ_19865 7 @BLACKJ_19886 8 @BLACKJ_19907 9 @BLACKJ_19928 10 @BLACKJ_19949 
0872: jump_table_jumps 11 @BLACKJ_19970 12 @BLACKJ_19991 13 @BLACKJ_20012 14 @BLACKJ_20033 15 @BLACKJ_20054 16 @BLACKJ_20075 17 @BLACKJ_20096 18 @BLACKJ_20117 19 @BLACKJ_20138 
0872: jump_table_jumps 20 @BLACKJ_20159 21 @BLACKJ_20180 -1 @BLACKJ_20270 -1 @BLACKJ_20270 -1 @BLACKJ_20270 -1 @BLACKJ_20270 -1 @BLACKJ_20270 -1 @BLACKJ_20270 -1 @BLACKJ_20270 

:BLACKJ_19823
09D6: unknown_set_actor 1@ sound 5841 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19844
09D6: unknown_set_actor 1@ sound 5842 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19865
09D6: unknown_set_actor 1@ sound 5843 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19886
09D6: unknown_set_actor 1@ sound 5844 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19907
09D6: unknown_set_actor 1@ sound 5845 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19928
09D6: unknown_set_actor 1@ sound 5846 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19949
09D6: unknown_set_actor 1@ sound 5829 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19970
09D6: unknown_set_actor 1@ sound 5830 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_19991
09D6: unknown_set_actor 1@ sound 5831 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20012
09D6: unknown_set_actor 1@ sound 5832 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20033
09D6: unknown_set_actor 1@ sound 5833 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20054
09D6: unknown_set_actor 1@ sound 5834 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20075
09D6: unknown_set_actor 1@ sound 5835 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20096
09D6: unknown_set_actor 1@ sound 5836 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20117
09D6: unknown_set_actor 1@ sound 5837 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20138
09D6: unknown_set_actor 1@ sound 5838 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20159
09D6: unknown_set_actor 1@ sound 5839 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20180
09D6: unknown_set_actor 1@ sound 5840 flags 1 1 0 
jump @BLACKJ_20270 

:BLACKJ_20201
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_20249 
09D6: unknown_set_actor 1@ sound 5813 flags 1 1 0 
jump @BLACKJ_20263 

:BLACKJ_20249
09D6: unknown_set_actor 1@ sound 5814 flags 1 1 0 

:BLACKJ_20263
jump @BLACKJ_20270 

:BLACKJ_20270
0967: actor 1@ move_mouth 1500 ms 
jump @BLACKJ_20702 

:BLACKJ_20285
0871: init_jump_table " + BJACK_Player_total1 + @" total_jumps 10 default_jump 1 @BLACKJ_20625 jumps 12 @BLACKJ_20413 13 @BLACKJ_20434 14 @BLACKJ_20455 15 @BLACKJ_20476 16 @BLACKJ_20497 17 @BLACKJ_20518 18 @BLACKJ_20539 
0872: jump_table_jumps 19 @BLACKJ_20560 20 @BLACKJ_20581 21 @BLACKJ_20602 -1 @BLACKJ_20694 -1 @BLACKJ_20694 -1 @BLACKJ_20694 -1 @BLACKJ_20694 -1 @BLACKJ_20694 -1 @BLACKJ_20694 

:BLACKJ_20413
09D6: unknown_set_actor 1@ sound 5801 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20434
09D6: unknown_set_actor 1@ sound 5802 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20455
09D6: unknown_set_actor 1@ sound 5803 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20476
09D6: unknown_set_actor 1@ sound 5804 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20497
09D6: unknown_set_actor 1@ sound 5805 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20518
09D6: unknown_set_actor 1@ sound 5806 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20539
09D6: unknown_set_actor 1@ sound 5807 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20560
09D6: unknown_set_actor 1@ sound 5808 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20581
09D6: unknown_set_actor 1@ sound 5800 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20602
09D6: unknown_set_actor 1@ sound 65535 flags 1 1 0 
jump @BLACKJ_20694 

:BLACKJ_20625
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_20673 
09D6: unknown_set_actor 1@ sound 5813 flags 1 1 0 
jump @BLACKJ_20687 

:BLACKJ_20673
09D6: unknown_set_actor 1@ sound 5814 flags 1 1 0 

:BLACKJ_20687
jump @BLACKJ_20694 

:BLACKJ_20694
0967: actor 1@ move_mouth 3000 ms 

:BLACKJ_20702
jump @BLACKJ_21799 

:BLACKJ_20709
if 
  " + BJACK_Player_total2_B + @" == 0 
jf @BLACKJ_21382 
0871: init_jump_table " + BJACK_Player_total2 + @" total_jumps 18 default_jump 1 @BLACKJ_21298 jumps 4 @BLACKJ_20920 5 @BLACKJ_20941 6 @BLACKJ_20962 7 @BLACKJ_20983 8 @BLACKJ_21004 9 @BLACKJ_21025 10 @BLACKJ_21046 
0872: jump_table_jumps 11 @BLACKJ_21067 12 @BLACKJ_21088 13 @BLACKJ_21109 14 @BLACKJ_21130 15 @BLACKJ_21151 16 @BLACKJ_21172 17 @BLACKJ_21193 18 @BLACKJ_21214 19 @BLACKJ_21235 
0872: jump_table_jumps 20 @BLACKJ_21256 21 @BLACKJ_21277 -1 @BLACKJ_21367 -1 @BLACKJ_21367 -1 @BLACKJ_21367 -1 @BLACKJ_21367 -1 @BLACKJ_21367 -1 @BLACKJ_21367 -1 @BLACKJ_21367 

:BLACKJ_20920
09D6: unknown_set_actor 1@ sound 5841 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_20941
09D6: unknown_set_actor 1@ sound 5842 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_20962
09D6: unknown_set_actor 1@ sound 5843 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_20983
09D6: unknown_set_actor 1@ sound 5844 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21004
09D6: unknown_set_actor 1@ sound 5845 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21025
09D6: unknown_set_actor 1@ sound 5846 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21046
09D6: unknown_set_actor 1@ sound 5829 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21067
09D6: unknown_set_actor 1@ sound 5830 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21088
09D6: unknown_set_actor 1@ sound 5831 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21109
09D6: unknown_set_actor 1@ sound 5832 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21130
09D6: unknown_set_actor 1@ sound 5833 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21151
09D6: unknown_set_actor 1@ sound 5834 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21172
09D6: unknown_set_actor 1@ sound 5835 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21193
09D6: unknown_set_actor 1@ sound 5836 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21214
09D6: unknown_set_actor 1@ sound 5837 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21235
09D6: unknown_set_actor 1@ sound 5838 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21256
09D6: unknown_set_actor 1@ sound 5839 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21277
09D6: unknown_set_actor 1@ sound 5840 flags 1 1 0 
jump @BLACKJ_21367 

:BLACKJ_21298
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_21346 
09D6: unknown_set_actor 1@ sound 5813 flags 1 1 0 
jump @BLACKJ_21360 

:BLACKJ_21346
09D6: unknown_set_actor 1@ sound 5814 flags 1 1 0 

:BLACKJ_21360
jump @BLACKJ_21367 

:BLACKJ_21367
0967: actor 1@ move_mouth 1500 ms 
jump @BLACKJ_21799 

:BLACKJ_21382
0871: init_jump_table " + BJACK_Player_total2 + @" total_jumps 10 default_jump 1 @BLACKJ_21722 jumps 12 @BLACKJ_21510 13 @BLACKJ_21531 14 @BLACKJ_21552 15 @BLACKJ_21573 16 @BLACKJ_21594 17 @BLACKJ_21615 18 @BLACKJ_21636 
0872: jump_table_jumps 19 @BLACKJ_21657 20 @BLACKJ_21678 21 @BLACKJ_21699 -1 @BLACKJ_21791 -1 @BLACKJ_21791 -1 @BLACKJ_21791 -1 @BLACKJ_21791 -1 @BLACKJ_21791 -1 @BLACKJ_21791 

:BLACKJ_21510
09D6: unknown_set_actor 1@ sound 5801 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21531
09D6: unknown_set_actor 1@ sound 5802 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21552
09D6: unknown_set_actor 1@ sound 5803 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21573
09D6: unknown_set_actor 1@ sound 5804 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21594
09D6: unknown_set_actor 1@ sound 5805 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21615
09D6: unknown_set_actor 1@ sound 5806 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21636
09D6: unknown_set_actor 1@ sound 5807 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21657
09D6: unknown_set_actor 1@ sound 5808 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21678
09D6: unknown_set_actor 1@ sound 5800 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21699
09D6: unknown_set_actor 1@ sound 65535 flags 1 1 0 
jump @BLACKJ_21791 

:BLACKJ_21722
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @BLACKJ_21770 
09D6: unknown_set_actor 1@ sound 5813 flags 1 1 0 
jump @BLACKJ_21784 

:BLACKJ_21770
09D6: unknown_set_actor 1@ sound 5814 flags 1 1 0 

:BLACKJ_21784
jump @BLACKJ_21791 

:BLACKJ_21791
0967: actor 1@ move_mouth 3000 ms 

:BLACKJ_21799
return 
if 
0736:   is_keyboard_key_just_pressed 67 
jf @BLACKJ_21866 
" + _9307 + @" += 1 
if 
  " + _9307 + @" > 7 
jf @BLACKJ_21848 
" + _9307 + @" = 0 

:BLACKJ_21848
0663: printint ""BJ_CHIP_NUM"" " + _9307 + @" 

:BLACKJ_21866
if 
03CA:   object 0@ exists 
jf @BLACKJ_22185 
if 
03CA:   object " + tmp_9208 + @"(" + _9307 + @",8i) exists 
jf @BLACKJ_22185 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset " + tmp_BJACK_X_Chip_offset + @"(" + _9307 + @",8f) " + tmp_BJACK_Y_Chip_offset + @"(" + _9307 + @",8f) " + tmp_BJACK_Z_Chip_offset + @"(" + _9307 + @",8f) 
Object.PutAt(" + tmp_9208 + @"(" + _9307 + @",8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_21985 
" + tmp_BJACK_Z_Chip_offset + @"(" + _9307 + @",8f) += 0.005 

:BLACKJ_21985
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_22015 
" + tmp_BJACK_Z_Chip_offset + @"(" + _9307 + @",8f) += -0.005 

:BLACKJ_22015
if 
0736:   is_keyboard_key_just_pressed 128 
jf @BLACKJ_22045 
" + tmp_BJACK_X_Chip_offset + @"(" + _9307 + @",8f) += 0.005 

:BLACKJ_22045
if 
0736:   is_keyboard_key_just_pressed 129 
jf @BLACKJ_22075 
" + tmp_BJACK_X_Chip_offset + @"(" + _9307 + @",8f) += -0.005 

:BLACKJ_22075
if 
0736:   is_keyboard_key_just_pressed 139 
jf @BLACKJ_22105 
" + tmp_BJACK_Y_Chip_offset + @"(" + _9307 + @",8f) += 0.005 

:BLACKJ_22105
if 
0736:   is_keyboard_key_just_pressed 145 
jf @BLACKJ_22135 
" + tmp_BJACK_Y_Chip_offset + @"(" + _9307 + @",8f) += -0.005 

:BLACKJ_22135
if 
0736:   is_keyboard_key_just_pressed 69 
jf @BLACKJ_22160 
" + _9216 + @" += 0.005 

:BLACKJ_22160
if 
0736:   is_keyboard_key_just_pressed 68 
jf @BLACKJ_22185 
" + _9216 + @" += -0.005 

:BLACKJ_22185
if 
0736:   is_keyboard_key_just_pressed 137 
jf @BLACKJ_23202 
03A9: save_newline_to_debug_file 
05B6: 183 
03A9: save_newline_to_debug_file 
10@ = 0 

:BLACKJ_22342
if 
  8 > 10@ 
jf @BLACKJ_23202 
05B6: 184 
03A7: save_int_to_debug_file 10@ 
05B6: 185 
03A8: save_float_to_debug_file " + tmp_BJACK_X_Chip_offset + @"(10@,8f) 
03A9: save_newline_to_debug_file 
05B6: 186 
03A7: save_int_to_debug_file 10@ 
05B6: 187 
03A8: save_float_to_debug_file " + tmp_BJACK_Y_Chip_offset + @"(10@,8f) 
03A9: save_newline_to_debug_file 
05B6: 188 
03A7: save_int_to_debug_file 10@ 
05B6: 189 
03A8: save_float_to_debug_file " + tmp_BJACK_Z_Chip_offset + @"(10@,8f) 
03A9: save_newline_to_debug_file 
10@ += 1 
jump @BLACKJ_22342 

:BLACKJ_23202
return 

:BLACKJ_23204
008B: 12@ = " + BJACK_Initial_Stake + @" 
0093: 13@ = integer 12@ to_float 
13@ /= 1.0 
if 
  13@ > 10.0 
jf @BLACKJ_23261 
13@ = 10.0 

:BLACKJ_23261
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_23315 
14@ += 0.0 

:BLACKJ_23315
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -1 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[0] exists 
jf @BLACKJ_23417 
Object.StorePos(" + tmp_9208 + @"[0], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[0], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_23417
0093: 13@ = integer 12@ to_float 
13@ /= 5.0 
if 
  13@ > 10.0 
jf @BLACKJ_23466 
13@ = 10.0 

:BLACKJ_23466
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_23520 
14@ += 0.0 

:BLACKJ_23520
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -5 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[1] exists 
jf @BLACKJ_23622 
Object.StorePos(" + tmp_9208 + @"[1], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[1], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_23622
0093: 13@ = integer 12@ to_float 
13@ /= 10.0 
if 
  13@ > 10.0 
jf @BLACKJ_23671 
13@ = 10.0 

:BLACKJ_23671
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_23725 
14@ += 0.0 

:BLACKJ_23725
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -10 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[2] exists 
jf @BLACKJ_23827 
Object.StorePos(" + tmp_9208 + @"[2], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[2], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_23827
0093: 13@ = integer 12@ to_float 
13@ /= 50.0 
if 
  13@ > 10.0 
jf @BLACKJ_23876 
13@ = 10.0 

:BLACKJ_23876
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_23930 
14@ += 0.0 

:BLACKJ_23930
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -50 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[3] exists 
jf @BLACKJ_24032 
Object.StorePos(" + tmp_9208 + @"[3], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[3], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_24032
0093: 13@ = integer 12@ to_float 
13@ /= 100.0 
if 
  13@ > 10.0 
jf @BLACKJ_24081 
13@ = 10.0 

:BLACKJ_24081
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_24135 
14@ += 0.0 

:BLACKJ_24135
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -100 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[4] exists 
jf @BLACKJ_24237 
Object.StorePos(" + tmp_9208 + @"[4], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[4], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_24237
0093: 13@ = integer 12@ to_float 
13@ /= 200.0 
if 
  13@ > 10.0 
jf @BLACKJ_24286 
13@ = 10.0 

:BLACKJ_24286
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_24340 
14@ += 0.0 

:BLACKJ_24340
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -200 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[5] exists 
jf @BLACKJ_24443 
Object.StorePos(" + tmp_9208 + @"[5], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[5], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_24443
0093: 13@ = integer 12@ to_float 
13@ /= 500.0 
if 
  13@ > 10.0 
jf @BLACKJ_24492 
13@ = 10.0 

:BLACKJ_24492
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_24546 
14@ += 0.0 

:BLACKJ_24546
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -500 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[6] exists 
jf @BLACKJ_24649 
Object.StorePos(" + tmp_9208 + @"[6], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[6], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_24649
0093: 13@ = integer 12@ to_float 
13@ /= 1000.0 
if 
  13@ > 10.0 
jf @BLACKJ_24698 
13@ = 10.0 

:BLACKJ_24698
0092: 11@ = float 13@ to_integer 
0093: 14@ = integer 11@ to_float 
14@ *= 0.0126 
if 
  11@ > 0 
jf @BLACKJ_24752 
14@ += 0.0 

:BLACKJ_24752
0089: 13@ = " + _9216 + @" 
005B: 13@ += 14@ 
11@ *= -1000 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9208 + @"[7] exists 
jf @BLACKJ_24855 
Object.StorePos(" + tmp_9208 + @"[7], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 13@ 13@ " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 13@ 
Object.PutAt(" + tmp_9208 + @"[7], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BLACKJ_24855
return 

:BLACKJ_24857
03E3: set_texture_to_be_drawn_antialiased 0 
0937: text_draw_box_cornerA " + tmp_BJACK_X_Screenpos + @"[0] " + tmp_BJACK_Y_Screenpos + @"[0] cornerB " + tmp_BJACK_X_Screenpos + @"[1] " + tmp_BJACK_Y_Screenpos + @"[1] GXT_reference 'BJ_TITL' style 2  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[2] " + tmp_BJACK_Y_Screenpos + @"[2] GXT 'BJ_01'  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[3] " + tmp_BJACK_Y_Screenpos + @"[3] GXT 'DOLLAR' number " + BJACK_Initial_Stake + @"  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[4] " + tmp_BJACK_Y_Screenpos + @"[4] GXT 'BJ_02'  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[5] " + tmp_BJACK_Y_Screenpos + @"[5] GXT 'DOLLAR' number 30@  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[6] " + tmp_BJACK_Y_Screenpos + @"[6] GXT 'BJ_03'  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[7] " + tmp_BJACK_Y_Screenpos + @"[7] GXT 'DOLLAR' number 29@  
return 

:BLACKJ_25143
03E3: set_texture_to_be_drawn_antialiased 0 
0937: text_draw_box_cornerA " + tmp_BJACK_X_Screenpos + @"[8] " + tmp_BJACK_Y_Screenpos + @"[8] cornerB " + tmp_BJACK_X_Screenpos + @"[9] " + tmp_BJACK_Y_Screenpos + @"[9] GXT_reference 'BJ_TITL' style 2  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[10] " + tmp_BJACK_Y_Screenpos + @"[10] GXT 'BJ_01'  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[11] " + tmp_BJACK_Y_Screenpos + @"[11] GXT 'DOLLAR' number " + BJACK_Initial_Stake + @"  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[12] " + tmp_BJACK_Y_Screenpos + @"[12] GXT 'BJ_04'  
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
if 
  2@ > 4 
jf @BLACKJ_25457 
if 
  " + BJACK_Dealer_total2 + @" == 0 
jf @BLACKJ_25427 
if 
  " + BJACK_Dealer_total + @" > 21 
jf @BLACKJ_25400 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[13] " + tmp_BJACK_Y_Screenpos + @"[13] GXT 'BJ_BUST'  
jump @BLACKJ_25420 

:BLACKJ_25400
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[13] " + tmp_BJACK_Y_Screenpos + @"[13] GXT 'BJ_0' number " + BJACK_Dealer_total + @"  

:BLACKJ_25420
jump @BLACKJ_25450 

:BLACKJ_25427
045B: draw_text_2numbers " + tmp_BJACK_X_Screenpos + @"[14] " + tmp_BJACK_Y_Screenpos + @"[14] GXT 'BJ_OR2' numbers " + BJACK_Dealer_total + @" " + BJACK_Dealer_total2 + @"  

:BLACKJ_25450
jump @BLACKJ_25474 

:BLACKJ_25457
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[13] " + tmp_BJACK_Y_Screenpos + @"[13] GXT 'BJ_HIDE'  

:BLACKJ_25474
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[15] " + tmp_BJACK_Y_Screenpos + @"[15] GXT 'BJ_05'  
if 
  " + BJACK_Player_total2 + @" == 0 
jf @BLACKJ_25674 
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
if 
  " + BJACK_Player_total1_B + @" == 0 
jf @BLACKJ_25644 
if 
  " + BJACK_Player_total1 + @" > 21 
jf @BLACKJ_25617 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[16] " + tmp_BJACK_Y_Screenpos + @"[16] GXT 'BJ_BUST'  
jump @BLACKJ_25637 

:BLACKJ_25617
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[16] " + tmp_BJACK_Y_Screenpos + @"[16] GXT 'BJ_0' number " + BJACK_Player_total1 + @"  

:BLACKJ_25637
jump @BLACKJ_25667 

:BLACKJ_25644
045B: draw_text_2numbers " + tmp_BJACK_X_Screenpos + @"[17] " + tmp_BJACK_Y_Screenpos + @"[17] GXT 'BJ_OR2' numbers " + BJACK_Player_total1 + @" " + BJACK_Player_total1_B + @"  

:BLACKJ_25667
jump @BLACKJ_25940 

:BLACKJ_25674
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
if 
  " + BJACK_Player_total1_B + @" == 0 
jf @BLACKJ_25784 
if 
  " + BJACK_Player_total1 + @" > 21 
jf @BLACKJ_25757 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[18] " + tmp_BJACK_Y_Screenpos + @"[18] GXT 'BJ_BUST'  
jump @BLACKJ_25777 

:BLACKJ_25757
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[18] " + tmp_BJACK_Y_Screenpos + @"[18] GXT 'BJ_0' number " + BJACK_Player_total1 + @"  

:BLACKJ_25777
jump @BLACKJ_25807 

:BLACKJ_25784
045B: draw_text_2numbers " + tmp_BJACK_X_Screenpos + @"[19] " + tmp_BJACK_Y_Screenpos + @"[19] GXT 'BJ_OR2' numbers " + BJACK_Player_total1 + @" " + BJACK_Player_total1_B + @"  

:BLACKJ_25807
gosub @BLACKJ_34042 
03E3: set_texture_to_be_drawn_antialiased 0 
033F: set_text_draw_letter_size 0.6253 2.7876 
if 
  " + BJACK_Player_total2_B + @" == 0 
jf @BLACKJ_25917 
if 
  " + BJACK_Player_total2 + @" > 21 
jf @BLACKJ_25890 
033E: set_draw_text_position " + tmp_BJACK_X_Screenpos + @"[20] " + tmp_BJACK_Y_Screenpos + @"[20] GXT 'BJ_BUST'  
jump @BLACKJ_25910 

:BLACKJ_25890
045A: draw_text_1number " + tmp_BJACK_X_Screenpos + @"[20] " + tmp_BJACK_Y_Screenpos + @"[20] GXT 'BJ_0' number " + BJACK_Player_total2 + @"  

:BLACKJ_25910
jump @BLACKJ_25940 

:BLACKJ_25917
045B: draw_text_2numbers " + tmp_BJACK_X_Screenpos + @"[21] " + tmp_BJACK_Y_Screenpos + @"[21] GXT 'BJ_OR2' numbers " + BJACK_Player_total2 + @" " + BJACK_Player_total2_B + @"  

:BLACKJ_25940
return 
if 
0736:   is_keyboard_key_just_pressed 76 
jf @BLACKJ_26016 
" + _9308 + @" += 1 
if 
  " + _9308 + @" > 26 
jf @BLACKJ_25989 
" + _9308 + @" = -1 

:BLACKJ_25989
0663: printint ""SCREEN_POSITION_EDIT"" " + _9308 + @" 

:BLACKJ_26016
if 
  " + _9308 + @" > -1 
jf @BLACKJ_26154 
if 
0736:   is_keyboard_key_just_pressed 128 
jf @BLACKJ_26064 
" + tmp_BJACK_X_Screenpos + @"(" + _9308 + @",27f) += 1.0 

:BLACKJ_26064
if 
0736:   is_keyboard_key_just_pressed 129 
jf @BLACKJ_26094 
" + tmp_BJACK_X_Screenpos + @"(" + _9308 + @",27f) += -1.0 

:BLACKJ_26094
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_26124 
" + tmp_BJACK_Y_Screenpos + @"(" + _9308 + @",27f) += -1.0 

:BLACKJ_26124
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_26154 
" + tmp_BJACK_Y_Screenpos + @"(" + _9308 + @",27f) += 1.0 

:BLACKJ_26154
if 
  " + _9308 + @" > -1 
jf @BLACKJ_26913 
if 
0736:   is_keyboard_key_just_pressed 137 
jf @BLACKJ_26913 
03A9: save_newline_to_debug_file 
05B6: 190 
10@ = 0 

:BLACKJ_26327
if 
  27 > 10@ 
jf @BLACKJ_26911 
03A9: save_newline_to_debug_file 
05B6: 191 
03A7: save_int_to_debug_file 10@ 
05B6: 192 
03A8: save_float_to_debug_file " + tmp_BJACK_X_Screenpos + @"(10@,27f) 
03A9: save_newline_to_debug_file 
05B6: 193 
03A7: save_int_to_debug_file 10@ 
05B6: 194 
03A8: save_float_to_debug_file " + tmp_BJACK_Y_Screenpos + @"(10@,27f) 
10@ += 1 
jump @BLACKJ_26327 

:BLACKJ_26911
03A9: save_newline_to_debug_file 

:BLACKJ_26913
return 
if 
0736:   is_keyboard_key_just_pressed 66 
jf @BLACKJ_27279 
" + _9309 + @" += 1 
if 
  " + _9309 + @" > 7 
jf @BLACKJ_26962 
" + _9309 + @" = 0 

:BLACKJ_26962
if 
  " + _9309 + @" == 1 
jf @BLACKJ_26998 
0662: printstring ""EDIT_CARD_SIZE"" 

:BLACKJ_26998
if 
  " + _9309 + @" == 2 
jf @BLACKJ_27041 
0662: printstring ""EDIT_CARD_POSITIONS_X"" 

:BLACKJ_27041
if 
  " + _9309 + @" == 3 
jf @BLACKJ_27091 
0662: printstring ""EDIT_PLAYERS_CARD_POSITION_1"" 

:BLACKJ_27091
if 
  " + _9309 + @" == 4 
jf @BLACKJ_27142 
0662: printstring ""EDIT_PLAYERS_CARD_POSITION_1B"" 

:BLACKJ_27142
if 
  " + _9309 + @" == 5 
jf @BLACKJ_27192 
0662: printstring ""EDIT_PLAYERS_CARD_POSITION_2"" 

:BLACKJ_27192
if 
  " + _9309 + @" == 6 
jf @BLACKJ_27240 
0662: printstring ""EDIT_DEALERS_CARD_POSITION"" 

:BLACKJ_27240
if 
  " + _9309 + @" == 7 
jf @BLACKJ_27279 
0662: printstring ""EDIT_BORDER_WIDTH"" 

:BLACKJ_27279
if 
  " + _9309 + @" == 1 
jf @BLACKJ_27491 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_27330 
" + BJACK_Card_Height + @" += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27330
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_27394 
" + BJACK_Card_Height + @" += -1.0 
if 
  1.0 > " + BJACK_Card_Height + @" 
jf @BLACKJ_27387 
" + BJACK_Card_Height + @" = 1.0 

:BLACKJ_27387
gosub @BLACKJ_32389 

:BLACKJ_27394
if 
0736:   is_keyboard_key_just_pressed 128 
jf @BLACKJ_27427 
" + BJACK_Card_Width + @" += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27427
if 
0736:   is_keyboard_key_just_pressed 129 
jf @BLACKJ_27491 
" + BJACK_Card_Width + @" += -1.0 
if 
  1.0 > " + BJACK_Card_Width + @" 
jf @BLACKJ_27484 
" + BJACK_Card_Width + @" = 1.0 

:BLACKJ_27484
gosub @BLACKJ_32389 

:BLACKJ_27491
if 
  " + _9309 + @" == 2 
jf @BLACKJ_27615 
if 
0736:   is_keyboard_key_just_pressed 128 
jf @BLACKJ_27562 
" + tmp_9087 + @"[0] += 1.0 
" + tmp_9103 + @"[0] += 1.0 
" + tmp_9119 + @"[0] += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27562
if 
0736:   is_keyboard_key_just_pressed 129 
jf @BLACKJ_27615 
" + tmp_9087 + @"[0] += -1.0 
" + tmp_9103 + @"[0] += -1.0 
" + tmp_9119 + @"[0] += -1.0 
gosub @BLACKJ_32389 

:BLACKJ_27615
if 
  " + _9309 + @" == 3 
jf @BLACKJ_27699 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_27666 
" + tmp_9095 + @"[0] += -1.0 
gosub @BLACKJ_32389 

:BLACKJ_27666
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_27699 
" + tmp_9095 + @"[0] += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27699
if 
  " + _9309 + @" == 4 
jf @BLACKJ_27783 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_27750 
" + tmp_9111 + @"[0] += -1.0 
gosub @BLACKJ_32389 

:BLACKJ_27750
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_27783 
" + tmp_9111 + @"[0] += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27783
if 
  " + _9309 + @" == 5 
jf @BLACKJ_27867 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_27834 
" + tmp_9127 + @"[0] += -1.0 
gosub @BLACKJ_32389 

:BLACKJ_27834
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_27867 
" + tmp_9127 + @"[0] += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27867
if 
  " + _9309 + @" == 6 
jf @BLACKJ_28017 
if 
0736:   is_keyboard_key_just_pressed 128 
jf @BLACKJ_27918 
" + tmp_BJACK_X_Player_Sprite + @"[0] += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_27918
if 
0736:   is_keyboard_key_just_pressed 129 
jf @BLACKJ_27951 
" + tmp_BJACK_X_Player_Sprite + @"[0] += -1.0 
gosub @BLACKJ_32389 

:BLACKJ_27951
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BLACKJ_27984 
" + tmp_BJACK_Y_Player_Sprite + @"[0] += -1.0 
gosub @BLACKJ_32389 

:BLACKJ_27984
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BLACKJ_28017 
" + tmp_BJACK_Y_Player_Sprite + @"[0] += 1.0 
gosub @BLACKJ_32389 

:BLACKJ_28017
if 
  " + _9309 + @" == 7 
jf @BLACKJ_28087 
if 
0736:   is_keyboard_key_just_pressed 128 
jf @BLACKJ_28061 
" + BJACK_Border_Width + @" += 1.0 

:BLACKJ_28061
if 
0736:   is_keyboard_key_just_pressed 129 
jf @BLACKJ_28087 
" + BJACK_Border_Width + @" += -1.0 

:BLACKJ_28087
if 
  " + _9309 + @" > 0 
jf @BLACKJ_29762 
if 
0736:   is_keyboard_key_just_pressed 137 
jf @BLACKJ_29762 
03A9: save_newline_to_debug_file 
05B6: 195 
03A9: save_newline_to_debug_file 
05B6: 196 
03A8: save_float_to_debug_file " + BJACK_Card_Width + @" 
03A9: save_newline_to_debug_file 
05B6: 197 
03A8: save_float_to_debug_file " + BJACK_Card_Height + @" 
03A9: save_newline_to_debug_file 
05B6: 198 
03A8: save_float_to_debug_file " + tmp_9087 + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 199 
03A8: save_float_to_debug_file " + tmp_9095 + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 200 
03A8: save_float_to_debug_file " + tmp_9103 + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 201 
03A8: save_float_to_debug_file " + tmp_9111 + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 202 
03A8: save_float_to_debug_file " + tmp_9119 + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 203 
03A8: save_float_to_debug_file " + tmp_9127 + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 204 
03A8: save_float_to_debug_file " + tmp_BJACK_X_Player_Sprite + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 205 
03A8: save_float_to_debug_file " + tmp_BJACK_Y_Player_Sprite + @"[0] 
03A9: save_newline_to_debug_file 
05B6: 206 
03A8: save_float_to_debug_file " + BJACK_Border_Width + @" 
03A9: save_newline_to_debug_file 

:BLACKJ_29762
return 

:BLACKJ_29764
if 
  " + BJACK_Flag_Card_Cheat + @" == 0 
jf @BLACKJ_29801 
" + BJACK_Card_ID + @" = 0 
059E: get_card_to " + BJACK_Card_ID + @" 
jump @BLACKJ_29809 

:BLACKJ_29801
0084: " + BJACK_Card_ID + @" = " + BJACK_Cheat_Card_ID + @" 

:BLACKJ_29809
if 
   not Actor.Dead(1@)
jf @BLACKJ_29863 
0605: actor 1@ perform_animation ""DEALONE"" IFP ""CASINO"" framedelta 6.0 loop 0 lockX 0 lockY 0 lockF 0 time 500 

:BLACKJ_29863
return 

:BLACKJ_29865
if 
876F:   not text_priority_displayed 
jf @BLACKJ_31218 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_30100 
0089: 13@ = " + BJACK_Card_Width + @" 
13@ /= 2.0 
0086: " + tempvar_Float_1 + @" = " + tmp_9087 + @"[0] 
0067: " + tempvar_Float_1 + @" -= 13@ 
0061: " + tempvar_Float_1 + @" -= " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Height + @" 
13@ /= 2.0 
0086: " + tempvar_Float_2 + @" = " + tmp_9095 + @"[0] 
0067: " + tempvar_Float_2 + @" -= 13@ 
0061: " + tempvar_Float_2 + @" -= " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Width + @" 
13@ /= 2.0 
0089: 17@ = " + tmp_9087 + @"[4] 
005B: 17@ += 13@ 
005D: 17@ += " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Height + @" 
13@ /= 2.0 
0089: 18@ = " + tmp_9095 + @"[4] 
005B: 18@ += 13@ 
005D: 18@ += " + BJACK_Border_Width + @" 
03E3: set_texture_to_be_drawn_antialiased 1 
0937: text_draw_box_cornerA " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" cornerB 17@ 18@ GXT_reference 'DUMMY' style 0 
jump @BLACKJ_30297 

:BLACKJ_30100
0089: 13@ = " + BJACK_Card_Width + @" 
13@ /= 2.0 
0086: " + tempvar_Float_1 + @" = " + tmp_9103 + @"[0] 
0067: " + tempvar_Float_1 + @" -= 13@ 
0061: " + tempvar_Float_1 + @" -= " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Height + @" 
13@ /= 2.0 
0086: " + tempvar_Float_2 + @" = " + tmp_9111 + @"[0] 
0067: " + tempvar_Float_2 + @" -= 13@ 
0061: " + tempvar_Float_2 + @" -= " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Width + @" 
13@ /= 2.0 
0089: 17@ = " + tmp_9119 + @"[4] 
005B: 17@ += 13@ 
005D: 17@ += " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Height + @" 
13@ /= 2.0 
0089: 18@ = " + tmp_9127 + @"[4] 
005B: 18@ += 13@ 
005D: 18@ += " + BJACK_Border_Width + @" 
03E3: set_texture_to_be_drawn_antialiased 1 
0937: text_draw_box_cornerA " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" cornerB 17@ 18@ GXT_reference 'DUMMY' style 0 

:BLACKJ_30297
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_30549 
0089: 13@ = " + BJACK_Card_Width + @" 
13@ /= 2.0 
0086: " + tempvar_Float_1 + @" = " + tmp_BJACK_X_Player_Sprite + @"[0] 
0067: " + tempvar_Float_1 + @" -= 13@ 
0061: " + tempvar_Float_1 + @" -= " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Height + @" 
13@ /= 2.0 
0086: " + tempvar_Float_2 + @" = " + tmp_BJACK_Y_Player_Sprite + @"[0] 
0067: " + tempvar_Float_2 + @" -= 13@ 
0061: " + tempvar_Float_2 + @" -= " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Width + @" 
13@ /= 2.0 
0089: 17@ = " + tmp_BJACK_X_Player_Sprite + @"[4] 
005B: 17@ += 13@ 
005D: 17@ += " + BJACK_Border_Width + @" 
0089: 13@ = " + BJACK_Card_Height + @" 
13@ /= 2.0 
0089: 18@ = " + tmp_BJACK_Y_Player_Sprite + @"[4] 
005B: 18@ += 13@ 
005D: 18@ += " + BJACK_Border_Width + @" 
03E3: set_texture_to_be_drawn_antialiased 1 
0937: text_draw_box_cornerA " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" cornerB 17@ 18@ GXT_reference 'DUMMY' style 0 

:BLACKJ_30549
" + _9311 + @" = 0 

:BLACKJ_30556
if 
  8 > " + _9311 + @" 
jf @BLACKJ_31218 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_30666 
if 
   not " + tmp_9149 + @"(" + _9311 + @",8i) == 0 
jf @BLACKJ_30659 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture " + tmp_9149 + @"(" + _9311 + @",8i) position " + tmp_9087 + @"(" + _9311 + @",8f) " + tmp_9095 + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 

:BLACKJ_30659
jump @BLACKJ_30800 

:BLACKJ_30666
if 
   not " + tmp_9149 + @"(" + _9311 + @",8i) == 0 
jf @BLACKJ_30733 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture " + tmp_9149 + @"(" + _9311 + @",8i) position " + tmp_9103 + @"(" + _9311 + @",8f) " + tmp_9111 + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 

:BLACKJ_30733
if 
   not " + tmp_9157 + @"(" + _9311 + @",8i) == 0 
jf @BLACKJ_30800 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture " + tmp_9157 + @"(" + _9311 + @",8i) position " + tmp_9119 + @"(" + _9311 + @",8f) " + tmp_9127 + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 

:BLACKJ_30800
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_31199 
if 
   not " + tmp_9141 + @"(" + _9311 + @",8i) == 0 
jf @BLACKJ_31192 
if 
  " + _9311 + @" == 0 
jf @BLACKJ_31147 
if 
  " + BJACK_Player_has_split + @" == 0 
jf @BLACKJ_31030 
if 
  " + BJACK_Player_has_stucked1 + @" == 0 
jf @BLACKJ_30978 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 53 position " + tmp_BJACK_X_Player_Sprite + @"(" + _9311 + @",8f) " + tmp_BJACK_Y_Player_Sprite + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 
jump @BLACKJ_31023 

:BLACKJ_30978
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture " + tmp_9141 + @"(" + _9311 + @",8i) position " + tmp_BJACK_X_Player_Sprite + @"(" + _9311 + @",8f) " + tmp_BJACK_Y_Player_Sprite + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 

:BLACKJ_31023
jump @BLACKJ_31140 

:BLACKJ_31030
if 
  " + BJACK_Player_has_stucked2 + @" == 0 
jf @BLACKJ_31095 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 53 position " + tmp_BJACK_X_Player_Sprite + @"(" + _9311 + @",8f) " + tmp_BJACK_Y_Player_Sprite + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 
jump @BLACKJ_31140 

:BLACKJ_31095
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture " + tmp_9141 + @"(" + _9311 + @",8i) position " + tmp_BJACK_X_Player_Sprite + @"(" + _9311 + @",8f) " + tmp_BJACK_Y_Player_Sprite + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 

:BLACKJ_31140
jump @BLACKJ_31192 

:BLACKJ_31147
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture " + tmp_9141 + @"(" + _9311 + @",8i) position " + tmp_BJACK_X_Player_Sprite + @"(" + _9311 + @",8f) " + tmp_BJACK_Y_Player_Sprite + @"(" + _9311 + @",8f) size " + BJACK_Card_Width + @" " + BJACK_Card_Height + @" RGBA 128 128 128 255 

:BLACKJ_31192
jump @BLACKJ_31204 

:BLACKJ_31199
0989: set_text_boxes_width 200 

:BLACKJ_31204
" + _9311 + @" += 1 
jump @BLACKJ_30556 

:BLACKJ_31218
return 

:BLACKJ_31220
" + BJACK_Dealer_total + @" = 0 
" + BJACK_Dealer_total2 + @" = 0 
" + BJACK_Player_total1 + @" = 0 
" + BJACK_Player_total1_B + @" = 0 
" + BJACK_Player_total2 + @" = 0 
" + BJACK_Player_total2_B + @" = 0 
" + BJACK_Dealer_got_ace + @" = 0 
" + BJACK_Player_got_ace1 + @" = 0 
" + BJACK_Player_got_ace2 + @" = 0 
" + _9312 + @" = 0 

:BLACKJ_31290
if 
  8 > " + _9312 + @" 
jf @BLACKJ_31775 
if 
   not " + tmp_9141 + @"(" + _9312 + @",8i) == 0 
jf @BLACKJ_31459 
0084: " + _9313 + @" = " + tmp_9141 + @"(" + _9312 + @",8i) 
0084: " + _9314 + @" = " + _9313 + @" 
gosub @BLACKJ_32050 
0084: " + _9313 + @" = " + _9315 + @" 
if 
  " + _9313 + @" == 1 
jf @BLACKJ_31443 
if 
  " + BJACK_Dealer_got_ace + @" == 0 
jf @BLACKJ_31422 
" + BJACK_Dealer_total + @" += 11 
" + BJACK_Dealer_got_ace + @" = 1 
jump @BLACKJ_31429 

:BLACKJ_31422
" + BJACK_Dealer_total + @" += 1 

:BLACKJ_31429
" + BJACK_Dealer_total2 + @" += 1 
jump @BLACKJ_31459 

:BLACKJ_31443
0058: " + BJACK_Dealer_total + @" += " + _9313 + @" 
0058: " + BJACK_Dealer_total2 + @" += " + _9313 + @" 

:BLACKJ_31459
if 
   not " + tmp_9149 + @"(" + _9312 + @",8i) == 0 
jf @BLACKJ_31610 
0084: " + _9313 + @" = " + tmp_9149 + @"(" + _9312 + @",8i) 
0084: " + _9314 + @" = " + _9313 + @" 
gosub @BLACKJ_32050 
0084: " + _9313 + @" = " + _9315 + @" 
if 
  " + _9313 + @" == 1 
jf @BLACKJ_31594 
if 
  " + BJACK_Player_got_ace1 + @" == 0 
jf @BLACKJ_31573 
" + BJACK_Player_total1 + @" += 11 
" + BJACK_Player_got_ace1 + @" = 1 
jump @BLACKJ_31580 

:BLACKJ_31573
" + BJACK_Player_total1 + @" += 1 

:BLACKJ_31580
" + BJACK_Player_total1_B + @" += 1 
jump @BLACKJ_31610 

:BLACKJ_31594
0058: " + BJACK_Player_total1 + @" += " + _9313 + @" 
0058: " + BJACK_Player_total1_B + @" += " + _9313 + @" 

:BLACKJ_31610
if 
   not " + tmp_9157 + @"(" + _9312 + @",8i) == 0 
jf @BLACKJ_31761 
0084: " + _9313 + @" = " + tmp_9157 + @"(" + _9312 + @",8i) 
0084: " + _9314 + @" = " + _9313 + @" 
gosub @BLACKJ_32050 
0084: " + _9313 + @" = " + _9315 + @" 
if 
  " + _9313 + @" == 1 
jf @BLACKJ_31745 
if 
  " + BJACK_Player_got_ace2 + @" == 0 
jf @BLACKJ_31724 
" + BJACK_Player_total2 + @" += 11 
" + BJACK_Player_got_ace2 + @" = 1 
jump @BLACKJ_31731 

:BLACKJ_31724
" + BJACK_Player_total2 + @" += 1 

:BLACKJ_31731
" + BJACK_Player_total2_B + @" += 1 
jump @BLACKJ_31761 

:BLACKJ_31745
0058: " + BJACK_Player_total2 + @" += " + _9313 + @" 
0058: " + BJACK_Player_total2_B + @" += " + _9313 + @" 

:BLACKJ_31761
" + _9312 + @" += 1 
jump @BLACKJ_31290 

:BLACKJ_31775
if 
001C:   " + BJACK_Dealer_total + @" > " + BJACK_Dealer_total2 + @" 
jf @BLACKJ_31859 
if 
  " + BJACK_Dealer_total + @" > 21 
jf @BLACKJ_31827 
0084: " + BJACK_Dealer_total + @" = " + BJACK_Dealer_total2 + @" 
" + BJACK_Dealer_total2 + @" = 0 

:BLACKJ_31827
if 
  " + BJACK_Dealer_total + @" == 21 
jf @BLACKJ_31852 
" + BJACK_Dealer_total2 + @" = 0 

:BLACKJ_31852
jump @BLACKJ_31866 

:BLACKJ_31859
" + BJACK_Dealer_total2 + @" = 0 

:BLACKJ_31866
if 
001C:   " + BJACK_Player_total1 + @" > " + BJACK_Player_total1_B + @" 
jf @BLACKJ_31950 
if 
  " + BJACK_Player_total1 + @" > 21 
jf @BLACKJ_31918 
0084: " + BJACK_Player_total1 + @" = " + BJACK_Player_total1_B + @" 
" + BJACK_Player_total1_B + @" = 0 

:BLACKJ_31918
if 
  " + BJACK_Player_total1 + @" == 21 
jf @BLACKJ_31943 
" + BJACK_Player_total1_B + @" = 0 

:BLACKJ_31943
jump @BLACKJ_31957 

:BLACKJ_31950
" + BJACK_Player_total1_B + @" = 0 

:BLACKJ_31957
if 
001C:   " + BJACK_Player_total2 + @" > " + BJACK_Player_total2_B + @" 
jf @BLACKJ_32041 
if 
  " + BJACK_Player_total2 + @" > 21 
jf @BLACKJ_32009 
0084: " + BJACK_Player_total2 + @" = " + BJACK_Player_total2_B + @" 
" + BJACK_Player_total2_B + @" = 0 

:BLACKJ_32009
if 
  " + BJACK_Player_total2 + @" == 21 
jf @BLACKJ_32034 
" + BJACK_Player_total2_B + @" = 0 

:BLACKJ_32034
jump @BLACKJ_32048 

:BLACKJ_32041
" + BJACK_Player_total2_B + @" = 0 

:BLACKJ_32048
return 

:BLACKJ_32050
if 
  14 > " + _9314 + @" 
jf @BLACKJ_32076 
0084: " + _9315 + @" = " + _9314 + @" 

:BLACKJ_32076
if and
  27 > " + _9314 + @" 
  " + _9314 + @" > 13 
jf @BLACKJ_32116 
0084: " + _9315 + @" = " + _9314 + @" 
" + _9315 + @" -= 13 

:BLACKJ_32116
if and
  40 > " + _9314 + @" 
  " + _9314 + @" > 26 
jf @BLACKJ_32156 
0084: " + _9315 + @" = " + _9314 + @" 
" + _9315 + @" -= 26 

:BLACKJ_32156
if and
  53 > " + _9314 + @" 
  " + _9314 + @" > 39 
jf @BLACKJ_32196 
0084: " + _9315 + @" = " + _9314 + @" 
" + _9315 + @" -= 39 

:BLACKJ_32196
if 
  14 > " + _9315 + @" 
jf @BLACKJ_32239 
if 
  " + _9315 + @" > 10 
jf @BLACKJ_32239 
" + _9315 + @" = 10 

:BLACKJ_32239
return 

:BLACKJ_32241
if 
  14 > " + _9314 + @" 
jf @BLACKJ_32267 
0084: " + _9315 + @" = " + _9314 + @" 

:BLACKJ_32267
if and
  27 > " + _9314 + @" 
  " + _9314 + @" > 13 
jf @BLACKJ_32307 
0084: " + _9315 + @" = " + _9314 + @" 
" + _9315 + @" -= 13 

:BLACKJ_32307
if and
  40 > " + _9314 + @" 
  " + _9314 + @" > 26 
jf @BLACKJ_32347 
0084: " + _9315 + @" = " + _9314 + @" 
" + _9315 + @" -= 26 

:BLACKJ_32347
if and
  53 > " + _9314 + @" 
  " + _9314 + @" > 39 
jf @BLACKJ_32387 
0084: " + _9315 + @" = " + _9314 + @" 
" + _9315 + @" -= 39 

:BLACKJ_32387
return 

:BLACKJ_32389
0086: " + tmp_9119 + @"[0] = " + tmp_9087 + @"[0] 
0086: " + tmp_9127 + @"[0] = " + tmp_9095 + @"[0] 
0086: " + tmp_9103 + @"[0] = " + tmp_9087 + @"[0] 
0086: " + tmp_9111 + @"[0] = " + tmp_9095 + @"[0] 
0061: " + tmp_9111 + @"[0] -= " + BJACK_Card_Height + @" 
0061: " + tmp_9111 + @"[0] -= " + BJACK_Border_Width + @" 
10@ = 0 

:BLACKJ_32444
if 
  8 > 10@ 
jf @BLACKJ_32773 
if 
  5 > 10@ 
jf @BLACKJ_32663 
0086: " + _9137 + @" = " + BJACK_Card_Width + @" 
0059: " + _9137 + @" += " + BJACK_Border_Width + @" 
0091: " + _9139 + @" = integer 10@ to_float 
0069: " + _9139 + @" *= " + _9137 + @" 
0086: " + tmp_9087 + @"(10@,8f) = " + tmp_9087 + @"[0] 
0059: " + tmp_9087 + @"(10@,8f) += " + _9139 + @" 
0086: " + tmp_9095 + @"(10@,8f) = " + tmp_9095 + @"[0] 
0086: " + tmp_9103 + @"(10@,8f) = " + tmp_9103 + @"[0] 
0059: " + tmp_9103 + @"(10@,8f) += " + _9139 + @" 
0086: " + tmp_9111 + @"(10@,8f) = " + tmp_9111 + @"[0] 
0086: " + tmp_9119 + @"(10@,8f) = " + tmp_9119 + @"[0] 
0059: " + tmp_9119 + @"(10@,8f) += " + _9139 + @" 
0086: " + tmp_9127 + @"(10@,8f) = " + tmp_9127 + @"[0] 
0086: " + tmp_BJACK_X_Player_Sprite + @"(10@,8f) = " + tmp_BJACK_X_Player_Sprite + @"[0] 
0059: " + tmp_BJACK_X_Player_Sprite + @"(10@,8f) += " + _9139 + @" 
0086: " + tmp_BJACK_Y_Player_Sprite + @"(10@,8f) = " + tmp_BJACK_Y_Player_Sprite + @"[0] 
jump @BLACKJ_32759 

:BLACKJ_32663
0086: " + tmp_9087 + @"(10@,8f) = " + tmp_9087 + @"[4] 
0086: " + tmp_9095 + @"(10@,8f) = " + tmp_9095 + @"[4] 
0086: " + tmp_9103 + @"(10@,8f) = " + tmp_9103 + @"[4] 
0086: " + tmp_9111 + @"(10@,8f) = " + tmp_9111 + @"[4] 
0086: " + tmp_9119 + @"(10@,8f) = " + tmp_9119 + @"[4] 
0086: " + tmp_9127 + @"(10@,8f) = " + tmp_9127 + @"[4] 
0086: " + tmp_BJACK_X_Player_Sprite + @"(10@,8f) = " + tmp_BJACK_X_Player_Sprite + @"[4] 
0086: " + tmp_BJACK_Y_Player_Sprite + @"(10@,8f) = " + tmp_BJACK_Y_Player_Sprite + @"[4] 

:BLACKJ_32759
10@ += 1 
jump @BLACKJ_32444 

:BLACKJ_32773
return 
0454: store_debug_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
03CA:   object 0@ exists 
jf @BLACKJ_32824 
Object.StorePos(0@, " + _9316 + @", " + _9317 + @", " + _9318 + @")
" + tempvar_Angle + @" = Object.Angle(0@)

:BLACKJ_32824
" + tempvar_Angle + @" *= -1.0 
02F7: 13@ = cosine " + tempvar_Angle + @" 
02F6: 14@ = sine " + tempvar_Angle + @" 
0086: " + _9319 + @" = " + tempvar_Float_1 + @" 
0061: " + _9319 + @" -= " + _9316 + @" 
0086: " + _9320 + @" = " + tempvar_Float_2 + @" 
0061: " + _9320 + @" -= " + _9317 + @" 
0086: " + _9321 + @" = " + tempvar_Float_3 + @" 
0061: " + _9321 + @" -= " + _9318 + @" 
0086: " + _9322 + @" = " + _9319 + @" 
006D: " + _9322 + @" *= 13@ 
0086: " + _9324 + @" = " + _9320 + @" 
006D: " + _9324 + @" *= 14@ 
0061: " + _9322 + @" -= " + _9324 + @" 
0086: " + _9323 + @" = " + _9319 + @" 
006D: " + _9323 + @" *= 14@ 
0086: " + _9324 + @" = " + _9320 + @" 
006D: " + _9324 + @" *= 13@ 
0059: " + _9323 + @" += " + _9324 + @" 
03A9: save_newline_to_debug_file 
05B6: 207 
03A8: save_float_to_debug_file " + _9322 + @" 
03A8: save_float_to_debug_file " + _9323 + @" 
03A8: save_float_to_debug_file " + _9321 + @" 
0463: store_debug_camera_target_point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0086: " + _9319 + @" = " + tempvar_Float_1 + @" 
0061: " + _9319 + @" -= " + _9316 + @" 
0086: " + _9320 + @" = " + tempvar_Float_2 + @" 
0061: " + _9320 + @" -= " + _9317 + @" 
0086: " + _9321 + @" = " + tempvar_Float_3 + @" 
0061: " + _9321 + @" -= " + _9318 + @" 
0086: " + _9322 + @" = " + _9319 + @" 
006D: " + _9322 + @" *= 13@ 
0086: " + _9324 + @" = " + _9320 + @" 
006D: " + _9324 + @" *= 14@ 
0061: " + _9322 + @" -= " + _9324 + @" 
0086: " + _9323 + @" = " + _9319 + @" 
006D: " + _9323 + @" *= 14@ 
0086: " + _9324 + @" = " + _9320 + @" 
006D: " + _9324 + @" *= 13@ 
0059: " + _9323 + @" += " + _9324 + @" 
03A9: save_newline_to_debug_file 
05B6: 208 
03A8: save_float_to_debug_file " + _9322 + @" 
03A8: save_float_to_debug_file " + _9323 + @" 
03A8: save_float_to_debug_file " + _9321 + @" 
return 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
03CA:   object 0@ exists 
jf @BLACKJ_33465 
Object.StorePos(0@, " + _9316 + @", " + _9317 + @", " + _9318 + @")
" + tempvar_Angle + @" = Object.Angle(0@)

:BLACKJ_33465
" + tempvar_Angle + @" *= -1.0 
02F7: 13@ = cosine " + tempvar_Angle + @" 
02F6: 14@ = sine " + tempvar_Angle + @" 
0086: " + _9319 + @" = " + tempvar_Float_1 + @" 
0061: " + _9319 + @" -= " + _9316 + @" 
0086: " + _9320 + @" = " + tempvar_Float_2 + @" 
0061: " + _9320 + @" -= " + _9317 + @" 
0086: " + _9321 + @" = " + tempvar_Float_3 + @" 
0061: " + _9321 + @" -= " + _9318 + @" 
0086: " + _9322 + @" = " + _9319 + @" 
006D: " + _9322 + @" *= 13@ 
0086: " + _9324 + @" = " + _9320 + @" 
006D: " + _9324 + @" *= 14@ 
0061: " + _9322 + @" -= " + _9324 + @" 
0086: " + _9323 + @" = " + _9319 + @" 
006D: " + _9323 + @" *= 14@ 
0086: " + _9324 + @" = " + _9320 + @" 
006D: " + _9324 + @" *= 13@ 
0059: " + _9323 + @" += " + _9324 + @" 
03A9: save_newline_to_debug_file 
05B6: 209 
03A8: save_float_to_debug_file " + _9322 + @" 
03A8: save_float_to_debug_file " + _9323 + @" 
03A8: save_float_to_debug_file " + _9321 + @" 
return 

:BLACKJ_33768
0653: 13@ = float_stat 81 
if 
  1.0 > 13@ 
jf @BLACKJ_33810 
" + Max_Wager + @" = 100 
jump @BLACKJ_33930 

:BLACKJ_33810
if 
  10.0 > 13@ 
jf @BLACKJ_33846 
" + Max_Wager + @" = 1000 
jump @BLACKJ_33930 

:BLACKJ_33846
if 
  100.0 > 13@ 
jf @BLACKJ_33882 
" + Max_Wager + @" = 10000 
jump @BLACKJ_33930 

:BLACKJ_33882
if 
  1000.0 > 13@ 
jf @BLACKJ_33920 
" + Max_Wager + @" = 100000 
jump @BLACKJ_33930 

:BLACKJ_33920
" + Max_Wager + @" = 1000000 

:BLACKJ_33930
return 
0340: set_text_draw_RGBA 255 255 255 255 
0341: set_text_draw_align_justify 0 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.6 1.6 
return 
0340: set_text_draw_RGBA 255 180 180 255 
0341: set_text_draw_align_justify 0 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 2.0 3.0 
return 

:BLACKJ_34042
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 0.4714 2.5077 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 0.4714 2.5077 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 

:BLACKJ_34152
0340: set_text_draw_RGBA 255 255 0 255 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size " + tmp_BJACK_X_Screenpos + @"[24] " + tmp_BJACK_Y_Screenpos + @"[24] 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 6 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 3 
081C: draw_text_outline 3 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.2 4.0 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 0 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 3 
081C: draw_text_outline 3 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.2 4.0 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 4 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 3 
081C: draw_text_outline 3 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.2 4.0 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 4 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 2 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 0.52 1.45 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 

:BLACKJ_34567
09BD: allow_other_threads_to_display_text_boxes 0 
2@ = 0 
3@ = 0 
4@ = 0 
5@ = 0 
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @BLACKJ_34656 
03E6: remove_text_box 

:BLACKJ_34656
Camera.Restore
10@ = 0 

:BLACKJ_34665
if 
  8 > 10@ 
jf @BLACKJ_34726 
if 
03CA:   object " + tmp_9208 + @"(10@,8i) exists 
jf @BLACKJ_34712 
Object.Destroy(" + tmp_9208 + @"(10@,8i))

:BLACKJ_34712
10@ += 1 
jump @BLACKJ_34665 

:BLACKJ_34726
if 
   not Actor.Dead(1@)
jf @BLACKJ_34749 
0638: AS_actor 1@ stay_put 1 

:BLACKJ_34749" );
                end_thread_named<CASHWIN>();
AppendLine( @"Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
04EF: release_animation ""CASINO"" 
0391: release_textures 
03F0: enable_text_draw 0 
0581: enable_radar 1 
03AD: NOP 1 
0989: set_text_boxes_width 200
return 
end_thread" );
            }

        }

    }

}