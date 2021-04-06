using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class VIDPOK : External {

            Int tmp_POKER_X_Text_Scale = global( POKER_X_Text_Scale.startIndex ), 
                tmp_POKER_Y_Text_Scale = global( POKER_Y_Text_Scale.startIndex ),
                tmp_POKER_Text_Color_R = global( POKER_Text_Color_R.startIndex ),
                tmp_POKER_Text_Color_G = global( POKER_Text_Color_G.startIndex ),
                tmp_POKER_Text_Color_B = global( POKER_Text_Color_B.startIndex ),
                tmp_POKER_Line_Height = global( POKER_Line_Height.startIndex ),
                tmp_POKER_Text_Centre = global( POKER_Text_Centre.startIndex ),
                tmp_POKER_Text_Edge_R = global( POKER_Text_Edge_R.startIndex ),
                tmp_POKER_Text_Edge_G = global( POKER_Text_Edge_G.startIndex ),
                tmp_POKER_Text_Edge_B = global( POKER_Text_Edge_B.startIndex ),
                tmp_POKER_Line_Width = global( POKER_Line_Width.startIndex ),
                tmp_POKER_Text_Font = global( POKER_Text_Font.startIndex ),
                tmp_POKER_Text_Edge = global( POKER_Text_Edge.startIndex ),
                tmp_POKER_Y_screen = global( POKER_Y_screen.startIndex ),
                tmp_POKER_X_screen = global( POKER_X_screen.startIndex ),
                tmp_POKER_X_Card = global( POKER_X_Card.startIndex ),
                tmp_POKER_Y_Card = global( POKER_Y_Card.startIndex ),
                tmp_POKER_X_Line = global( POKER_X_Line.startIndex ),
                tmp_POKER_Y_Line = global( POKER_Y_Line.startIndex ),
                tmp_POKER_Y_Row = global( POKER_Y_Row.startIndex ),
                tmp_POKER_X_Col = global( POKER_X_Col.startIndex ),
                tmp_9044 = global( _9044.startIndex ),
                tmp_9049 = global( _9049.startIndex ),
                tmp_9054 = global( _9054.startIndex ),
                tmp_9059 = global( _9059.startIndex ),
                tmp_8827 = global( _8827.startIndex ),
                tmp_8837 = global( _8837.startIndex ),
                tmp_8832 = global( _8832.startIndex ),
                tmp_8856 = global( _8856.startIndex ),
                tmp_8861 = global( _8861.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"3@ = 0 
4@ = 0 
5@ = 0 
6@ = 0 
7@ = 0 
if 
  4@ == -1 
jf @VIDPOK_110 
0@ = Object.Create(#KMB_ROCK, 0.0, 0.0, 0.0)
" + _8867 + @" = Object.Create(#KMB_ROCK, 0.0, 0.0, 0.0)

:VIDPOK_110
if 
   Player.Defined(" + PlayerChar + @")
jf @VIDPOK_134 
12@ = Player.Money(" + PlayerChar + @")

:VIDPOK_134
if 
  100 > 12@ 
jf @VIDPOK_166 
13@ = 5 
jump @VIDPOK_309 

:VIDPOK_166
if 
  1000 > 12@ 
jf @VIDPOK_199 
13@ = 6 
jump @VIDPOK_309 

:VIDPOK_199
if 
  10000 > 12@ 
jf @VIDPOK_232 
13@ = 7 
jump @VIDPOK_309 

:VIDPOK_232
if 
  50000 > 12@ 
jf @VIDPOK_267 
13@ = 8 
jump @VIDPOK_309 

:VIDPOK_267
if 
  100000 > 12@ 
jf @VIDPOK_302 
13@ = 9 
jump @VIDPOK_309 

:VIDPOK_302
13@ = 10 

:VIDPOK_309
0209: 12@ = random_int_in_ranges 0 13@ 
0871: init_jump_table 12@ total_jumps 10 default_jump 0 @VIDPOK_591 jumps 0 @VIDPOK_447 1 @VIDPOK_461 2 @VIDPOK_475 3 @VIDPOK_489 4 @VIDPOK_503 5 @VIDPOK_517 6 @VIDPOK_531 
0872: jump_table_jumps 7 @VIDPOK_546 8 @VIDPOK_561 9 @VIDPOK_576 -1 @VIDPOK_591 -1 @VIDPOK_591 -1 @VIDPOK_591 -1 @VIDPOK_591 -1 @VIDPOK_591 -1 @VIDPOK_591 

:VIDPOK_447
1@ = 1 
jump @VIDPOK_591 

:VIDPOK_461
1@ = 5 
jump @VIDPOK_591 

:VIDPOK_475
1@ = 10 
jump @VIDPOK_591 

:VIDPOK_489
1@ = 25 
jump @VIDPOK_591 

:VIDPOK_503
1@ = 50 
jump @VIDPOK_591 

:VIDPOK_517
1@ = 100 
jump @VIDPOK_591 

:VIDPOK_531
1@ = 500 
jump @VIDPOK_591 

:VIDPOK_546
1@ = 1000 
jump @VIDPOK_591 

:VIDPOK_561
1@ = 5000 
jump @VIDPOK_591 

:VIDPOK_576
1@ = 10000 
jump @VIDPOK_591 

:VIDPOK_591
wait 0 
if 
03CA:   object 0@ exists 
jf @VIDPOK_1657 
if 
  " + _8867 + @" == 0 
jf @VIDPOK_1569 
if 
   Player.Defined(" + PlayerChar + @")
jf @VIDPOK_1533 
if 
  " + _9470 + @" == 0 
jf @VIDPOK_1497 
if 
0472:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 5.0 5.0 sphere 0 on_foot 
jf @VIDPOK_1461 
12@ = 0 
13@ = Object.Model(0@)
07E4: get_model 13@ dimensions_cornerA_to 19@ 20@ 21@ dimensions_cornerB_to 22@ 23@ 24@ 
0087: 15@ = 22@ 
0063: 15@ -= 19@ 
if 
  15@ > 4.0 
jf @VIDPOK_1166 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.3 0.3 1.5 on_foot 
jf @VIDPOK_847 
12@ = 1 

:VIDPOK_847
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.838 -1.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.3 0.3 1.5 on_foot 
jf @VIDPOK_925 
12@ = 1 

:VIDPOK_925
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -1.676 -1.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.3 0.3 1.5 on_foot 
jf @VIDPOK_1003 
12@ = 1 

:VIDPOK_1003
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.838 -1.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.3 0.3 1.5 on_foot 
jf @VIDPOK_1081 
12@ = 1 

:VIDPOK_1081
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 1.676 -1.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.3 0.3 1.5 on_foot 
jf @VIDPOK_1159 
12@ = 1 

:VIDPOK_1159
jump @VIDPOK_1244 

:VIDPOK_1166
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.3 0.3 1.5 on_foot 
jf @VIDPOK_1244 
12@ = 1 

:VIDPOK_1244
if 
  12@ == 1 
jf @VIDPOK_1427 
if 
  " + _8870 + @" == 0 
jf @VIDPOK_1396 
if 
00E1:   player 0 pressed_key 15 
jf @VIDPOK_1353 
if 
  2@ == 1 
jf @VIDPOK_1324 
03E6: remove_text_box 
2@ = 0 

:VIDPOK_1324
3@ = 0 
4@ = 0 
008A: " + _8867 + @" = 0@ 
jump @VIDPOK_1389 

:VIDPOK_1353
if 
  2@ == 0 
jf @VIDPOK_1389 
0512: show_permanent_text_box 'VP01'  
2@ = 1 

:VIDPOK_1389
jump @VIDPOK_1420 

:VIDPOK_1396
if 
80E1:   not player 0 pressed_key 15 
jf @VIDPOK_1420 
" + _8870 + @" = 0 

:VIDPOK_1420
jump @VIDPOK_1454 

:VIDPOK_1427
if 
  2@ == 1 
jf @VIDPOK_1454 
03E6: remove_text_box 
2@ = 0 

:VIDPOK_1454
jump @VIDPOK_1490 

:VIDPOK_1461
if 
  2@ == 1 
jf @VIDPOK_1488 
03E6: remove_text_box 
2@ = 0 

:VIDPOK_1488
end_thread 

:VIDPOK_1490
jump @VIDPOK_1526 

:VIDPOK_1497
if 
  2@ == 1 
jf @VIDPOK_1524 
03E6: remove_text_box 
2@ = 0 

:VIDPOK_1524
end_thread 

:VIDPOK_1526
jump @VIDPOK_1562 

:VIDPOK_1533
if 
  2@ == 1 
jf @VIDPOK_1560 
03E6: remove_text_box 
2@ = 0 

:VIDPOK_1560
end_thread 

:VIDPOK_1562
jump @VIDPOK_1650 

:VIDPOK_1569
if 
003C:   " + _8867 + @" == 0@ 
jf @VIDPOK_1650 
if 
   Player.Defined(" + PlayerChar + @")
jf @VIDPOK_1650 
if 
  7@ == 0 
jf @VIDPOK_1636 
gosub @VIDPOK_1695 
jump @VIDPOK_1650 

:VIDPOK_1636
gosub @VIDPOK_35039 
" + _8867 + @" = 0 

:VIDPOK_1650
jump @VIDPOK_1686 

:VIDPOK_1657
if 
  2@ == 1 
jf @VIDPOK_1684 
03E6: remove_text_box 
2@ = 0 

:VIDPOK_1684
end_thread 

:VIDPOK_1686
jump @VIDPOK_591 
return 

:VIDPOK_1695
if 
0735:   is_keyboard_key_pressed 32 
jf @VIDPOK_1717 
25@ = 1 

:VIDPOK_1717
if 
  25@ == 1 
jf @VIDPOK_1801 
008A: " + _8903 + @" = 3@ 
008A: " + _8904 + @" = 4@ 
065D: NOP " + _8903 + @" ""M_STAGE"" 
065D: NOP " + _8904 + @" ""M_GOALS"" 
065D: NOP " + High_Cards_Number + @" ""HIGH_CARDS_HELD"" 

:VIDPOK_1801
8@ += 1 
if 
  8@ > 9 
jf @VIDPOK_1833 
8@ = 0 

:VIDPOK_1833
01BD: 9@ = current_time_in_ms 
0085: 11@ = 9@ 
0062: 11@ -= 10@ 
0085: 10@ = 9@ 
if 
  3@ == 0 
jf @VIDPOK_4544 
if 
  4@ == 0 
jf @VIDPOK_3662 
09BD: allow_other_threads_to_display_text_boxes 1 
if 
03CA:   object 0@ exists 
jf @VIDPOK_1926 
" + tempvar_Angle + @" = Object.Angle(0@)

:VIDPOK_1926
Player.CanMove(" + PlayerChar + @") = False
05D4: AS_actor " + PlayerActor + @" rotate_angle " + tempvar_Angle + @" 
0826: enable_hud 0 
" + _8905 + @" = 200 
" + tmp_POKER_X_screen + @"[0] = 529.0 
" + tmp_POKER_Y_screen + @"[0] = 57.0 
" + tmp_POKER_X_screen + @"[1] = 565.0 
" + tmp_POKER_Y_screen + @"[1] = 384.0 
" + tmp_POKER_X_screen + @"[2] = 527.0 
" + tmp_POKER_Y_screen + @"[2] = 133.0 
" + tmp_POKER_X_screen + @"[3] = 323.0 
" + tmp_POKER_Y_screen + @"[3] = 291.0 
" + tmp_POKER_X_screen + @"[4] = 180.0 
" + tmp_POKER_Y_screen + @"[4] = 413.0 
" + tmp_POKER_X_screen + @"[5] = 79.0 
" + tmp_POKER_Y_screen + @"[5] = 34.0 
" + tmp_POKER_X_screen + @"[6] = 531.0 
" + tmp_POKER_Y_screen + @"[6] = 79.0 
" + tmp_POKER_X_screen + @"[7] = 527.0 
" + tmp_POKER_Y_screen + @"[7] = 157.0 
" + tmp_POKER_X_Card + @"[0] = 122.0 
" + tmp_POKER_Y_Card + @"[0] = 314.0 
" + tmp_POKER_X_Card + @"[1] = 222.0 
" + tmp_POKER_Y_Card + @"[1] = 314.0 
" + tmp_POKER_X_Card + @"[2] = 320.0 
" + tmp_POKER_Y_Card + @"[2] = 314.0 
" + tmp_POKER_X_Card + @"[3] = 419.0 
" + tmp_POKER_Y_Card + @"[3] = 314.0 
" + tmp_POKER_X_Card + @"[4] = 517.0 
" + tmp_POKER_Y_Card + @"[4] = 314.0 
" + POKER_Card_Width + @" = 91.0 
" + POKER_Card_Height + @" = 137.0 
" + tmp_POKER_Y_Row + @"[0] = 33.0 
" + tmp_POKER_Y_Row + @"[1] = 61.0 
" + tmp_POKER_Y_Row + @"[2] = 76.0 
" + tmp_POKER_Y_Row + @"[3] = 92.0 
" + tmp_POKER_Y_Row + @"[4] = 108.0 
" + tmp_POKER_Y_Row + @"[5] = 124.0 
" + tmp_POKER_Y_Row + @"[6] = 140.0 
" + tmp_POKER_Y_Row + @"[7] = 156.0 
" + tmp_POKER_Y_Row + @"[8] = 172.0 
" + tmp_POKER_Y_Row + @"[9] = 188.0 
" + tmp_POKER_X_Col + @"[0] = 86.0 
" + tmp_POKER_X_Col + @"[1] = 239.0 
" + tmp_POKER_X_Col + @"[2] = 286.0 
" + tmp_POKER_X_Col + @"[3] = 330.0 
" + tmp_POKER_X_Col + @"[4] = 378.0 
" + tmp_POKER_X_Col + @"[5] = 450.0 
" + POKER_Hold_Button_Offset + @" = -86.0 
" + POKER_Hold_Width + @" = 49.0 
" + POKER_Hold_Height + @" = 18.0 
" + POKER_X_Bet_One + @" = 123.0 
" + POKER_Y_Bet_One + @" = 401.0 
" + POKER_Bet_One_Width + @" = 81.0 
" + POKER_Bet_One_Height + @" = 18.0 
" + POKER_X_Deal + @" = 222.0 
" + POKER_Y_Deal + @" = 401.0 
" + POKER_Deal_Width + @" = 87.0 
" + POKER_Deal_Height + @" = 18.0 
" + POKER_Border_Thickness + @" = 4.0 
" + tmp_POKER_X_Line + @"[0] = 384.0 
" + tmp_POKER_Y_Line + @"[0] = 131.0 
" + tmp_POKER_Line_Width + @"[0] = 2.0 
" + tmp_POKER_Line_Height + @"[0] = 152.0 
" + tmp_POKER_X_Line + @"[1] = 458.0 
" + tmp_POKER_Y_Line + @"[1] = 131.0 
" + tmp_POKER_Line_Width + @"[1] = 2.0 
" + tmp_POKER_Line_Height + @"[1] = 154.0 
" + tmp_POKER_X_Line + @"[2] = 267.0 
" + tmp_POKER_Y_Line + @"[2] = 207.0 
" + tmp_POKER_Line_Width + @"[2] = 382.0 
" + tmp_POKER_Line_Height + @"[2] = 2.0 
" + tmp_POKER_X_Line + @"[3] = 77.0 
" + tmp_POKER_Y_Line + @"[3] = 131.0 
" + tmp_POKER_Line_Width + @"[3] = 2.0 
" + tmp_POKER_Line_Height + @"[3] = 152.0 
" + tmp_POKER_X_Line + @"[4] = 267.0 
" + tmp_POKER_Y_Line + @"[4] = 54.0 
" + tmp_POKER_Line_Width + @"[4] = 383.0 
" + tmp_POKER_Line_Height + @"[4] = 2.0 
" + tmp_POKER_X_Line + @"[5] = 199.0 
" + tmp_POKER_Y_Line + @"[5] = 131.0 
" + tmp_POKER_Line_Width + @"[5] = 2.0 
" + tmp_POKER_Line_Height + @"[5] = 152.0 
" + tmp_POKER_X_Line + @"[6] = 246.0 
" + tmp_POKER_Y_Line + @"[6] = 131.0 
" + tmp_POKER_Line_Width + @"[6] = 2.0 
" + tmp_POKER_Line_Height + @"[6] = 152.0 
" + tmp_POKER_X_Line + @"[7] = 292.0 
" + tmp_POKER_Y_Line + @"[7] = 131.0 
" + tmp_POKER_Line_Width + @"[7] = 2.0 
" + tmp_POKER_Line_Height + @"[7] = 153.0 
" + tmp_POKER_X_Line + @"[8] = 338.0 
" + tmp_POKER_Y_Line + @"[8] = 131.0 
" + tmp_POKER_Line_Width + @"[8] = 2.0 
" + tmp_POKER_Line_Height + @"[8] = 153.0 
" + tmp_POKER_X_Text_Scale + @"[0] = 0.82 
" + tmp_POKER_Y_Text_Scale + @"[0] = 3.02 
" + tmp_POKER_Text_Color_R + @"[0] = 128 
" + tmp_POKER_Text_Color_G + @"[0] = 0 
" + tmp_POKER_Text_Color_B + @"[0] = 0 
" + tmp_POKER_Text_Font + @"[0] = 1 
" + tmp_POKER_Text_Centre + @"[0] = 1 
" + tmp_POKER_Text_Edge + @"[0] = 1 
0084: " + tmp_POKER_Text_Edge_R + @"[0] = " + _8905 + @" 
0084: " + tmp_POKER_Text_Edge_G + @"[0] = " + _8905 + @" 
" + tmp_POKER_Text_Edge_B + @"[0] = 0 
" + tmp_POKER_X_Text_Scale + @"[1] = 0.52 
" + tmp_POKER_Y_Text_Scale + @"[1] = 2.39 
" + tmp_POKER_Text_Color_R + @"[1] = 128 
" + tmp_POKER_Text_Color_G + @"[1] = 0 
" + tmp_POKER_Text_Color_B + @"[1] = 0 
" + tmp_POKER_Text_Font + @"[1] = 1 
" + tmp_POKER_Text_Centre + @"[1] = 0 
" + tmp_POKER_Text_Edge + @"[1] = 1 
0084: " + tmp_POKER_Text_Edge_R + @"[1] = " + _8905 + @" 
0084: " + tmp_POKER_Text_Edge_G + @"[1] = " + _8905 + @" 
" + tmp_POKER_Text_Edge_B + @"[1] = 0 
" + tmp_POKER_X_Text_Scale + @"[2] = 0.36 
" + tmp_POKER_Y_Text_Scale + @"[2] = 1.53 
0084: " + tmp_POKER_Text_Color_R + @"[2] = " + _8905 + @" 
0084: " + tmp_POKER_Text_Color_G + @"[2] = " + _8905 + @" 
" + tmp_POKER_Text_Color_B + @"[2] = 0 
" + tmp_POKER_Text_Font + @"[2] = 1 
" + tmp_POKER_Text_Centre + @"[2] = 0 
" + tmp_POKER_Text_Edge + @"[2] = 1 
" + tmp_POKER_Text_Edge_R + @"[2] = 0 
" + tmp_POKER_Text_Edge_G + @"[2] = 0 
" + tmp_POKER_Text_Edge_B + @"[2] = 0 
" + tmp_POKER_X_Text_Scale + @"[3] = 0.36 
" + tmp_POKER_Y_Text_Scale + @"[3] = 1.72 
0084: " + tmp_POKER_Text_Color_R + @"[3] = " + _8905 + @" 
0084: " + tmp_POKER_Text_Color_G + @"[3] = " + _8905 + @" 
" + tmp_POKER_Text_Color_B + @"[3] = 0 
" + tmp_POKER_Text_Font + @"[3] = 1 
" + tmp_POKER_Text_Centre + @"[3] = 0 
" + tmp_POKER_Text_Edge + @"[3] = 1 
" + tmp_POKER_Text_Edge_R + @"[3] = 0 
" + tmp_POKER_Text_Edge_G + @"[3] = 0 
" + tmp_POKER_Text_Edge_B + @"[3] = 0 
" + tmp_POKER_X_Text_Scale + @"[4] = 0.42 
" + tmp_POKER_Y_Text_Scale + @"[4] = 1.6 
0084: " + tmp_POKER_Text_Color_R + @"[4] = " + _8905 + @" 
0084: " + tmp_POKER_Text_Color_G + @"[4] = " + _8905 + @" 
" + tmp_POKER_Text_Color_B + @"[4] = 0 
" + tmp_POKER_Text_Font + @"[4] = 1 
" + tmp_POKER_Text_Centre + @"[4] = 0 
" + tmp_POKER_Text_Edge + @"[4] = 1 
" + tmp_POKER_Text_Edge_R + @"[4] = 0 
" + tmp_POKER_Text_Edge_G + @"[4] = 0 
" + tmp_POKER_Text_Edge_B + @"[4] = 0 
" + tmp_POKER_X_Text_Scale + @"[5] = 0.44 
" + tmp_POKER_Y_Text_Scale + @"[5] = 1.35 
0084: " + tmp_POKER_Text_Color_R + @"[5] = " + _8905 + @" 
0084: " + tmp_POKER_Text_Color_G + @"[5] = " + _8905 + @" 
" + tmp_POKER_Text_Color_B + @"[5] = 0 
" + tmp_POKER_Text_Font + @"[5] = 1 
" + tmp_POKER_Text_Centre + @"[5] = 1 
" + tmp_POKER_Text_Edge + @"[5] = 1 
" + tmp_POKER_Text_Edge_R + @"[5] = 0 
" + tmp_POKER_Text_Edge_G + @"[5] = 0 
" + tmp_POKER_Text_Edge_B + @"[5] = 0 
" + POKER_Tile_Height + @" = 81.0 
" + POKER_Tile_Width + @" = 63.0 
" + POKER_Table_X + @" = 268.0 
" + POKER_Table_Y + @" = 130.0 
" + POKER_Table_Width + @" = 384.0 
" + POKER_Table_Height + @" = 152.0 
" + tmp_9044 + @"[0] = 222.0 
" + tmp_9049 + @"[0] = 130.0 
" + tmp_9054 + @"[0] = 49.0 
" + tmp_9059 + @"[0] = 152.0 
" + tmp_9044 + @"[1] = 269.0 
" + tmp_9049 + @"[1] = 130.0 
" + tmp_9054 + @"[1] = 46.0 
" + tmp_9059 + @"[1] = 152.0 
" + tmp_9044 + @"[2] = 314.0 
" + tmp_9049 + @"[2] = 130.0 
" + tmp_9054 + @"[2] = 48.0 
" + tmp_9059 + @"[2] = 152.0 
" + tmp_9044 + @"[3] = 360.0 
" + tmp_9049 + @"[3] = 130.0 
" + tmp_9054 + @"[3] = 46.0 
" + tmp_9059 + @"[3] = 152.0 
" + tmp_9044 + @"[4] = 421.0 
" + tmp_9049 + @"[4] = 130.0 
" + tmp_9054 + @"[4] = 72.0 
" + tmp_9059 + @"[4] = 152.0 
" + POKER_Button_Text_Offset + @" = 2.5 
4@ += 1 

:VIDPOK_3662
if 
  4@ == 1 
jf @VIDPOK_3694 
fade 0 500 
4@ += 1 

:VIDPOK_3694
if 
  4@ == 2 
jf @VIDPOK_3732 
if 
   not fading 
jf @VIDPOK_3732 
4@ += 1 

:VIDPOK_3732
if 
  4@ == 3 
jf @VIDPOK_4505 
03F0: enable_text_draw 1 
0390: load_txd_dictionary 'LD_POKE' 
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
038F: load_texture ""ADDCOIN"" as 54 
038F: load_texture ""DEAL"" as 57 
038F: load_texture ""HOLDOFF"" as 60 
038F: load_texture ""HOLDMID"" as 61 
038F: load_texture ""HOLDON"" as 62 
038F: load_texture ""TVCORN"" as 63 
038F: load_texture ""BACKRED"" as 64 
038F: load_texture ""BACKCYAN"" as 65 
03CF: load_wav 1800 as 4 

:VIDPOK_4420
if 
83D0:   not wav 4 loaded 
jf @VIDPOK_4446 
wait 0 
jump @VIDPOK_4420 

:VIDPOK_4446
if 
   Player.Defined(" + PlayerChar + @")
jf @VIDPOK_4492 
12@ = Player.Money(" + PlayerChar + @")
gosub @VIDPOK_34875 
005C: 12@ += " + Max_Wager + @" 
" + _8826 + @" = 1 

:VIDPOK_4492
fade 1 0 
4@ = 99 

:VIDPOK_4505
if 
  4@ == 99 
jf @VIDPOK_4544 
" + _8844 + @" = 0 
3@ += 1 
4@ = 0 

:VIDPOK_4544
if 
  3@ == 1 
jf @VIDPOK_5712 
if 
  4@ == 0 
jf @VIDPOK_4727 
" + _8843 + @" = 2 
" + _8842 + @" = 2 
12@ = 0 

:VIDPOK_4601
if 
  5 > 12@ 
jf @VIDPOK_4655 
" + tmp_8827 + @"(12@,5i) = 0 
" + tmp_8837 + @"(12@,5i) = 0 
12@ += 1 
jump @VIDPOK_4601 

:VIDPOK_4655
12@ = Player.Money(" + PlayerChar + @")
gosub @VIDPOK_34875 
005C: 12@ += " + Max_Wager + @" 
008B: 13@ = " + _8826 + @" 
006A: 13@ *= 1@ 
if 
001D:   13@ > 12@ 
jf @VIDPOK_4720 
" + _8826 + @" = 1 

:VIDPOK_4720
4@ += 1 

:VIDPOK_4727
if 
  4@ == 1 
jf @VIDPOK_5237 
if 
  " + _8844 + @" == 0 
jf @VIDPOK_4784 
" + _8842 + @" = 3 
" + _8843 + @" = 2 
jump @VIDPOK_4798 

:VIDPOK_4784
" + _8842 + @" = 2 
" + _8843 + @" = 3 

:VIDPOK_4798
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 64 
jf @VIDPOK_4916 
if 
  " + _8871 + @" == 0 
jf @VIDPOK_4909 
if 
  " + _8844 + @" == 0 
jf @VIDPOK_4888 
" + _8844 + @" = 1 
jump @VIDPOK_4895 

:VIDPOK_4888
" + _8844 + @" = 0 

:VIDPOK_4895
" + _8871 + @" += 1 
jump @VIDPOK_5237 

:VIDPOK_4909
jump @VIDPOK_5050 

:VIDPOK_4916
if or
00E1:   player 0 pressed_key 10 
  -64 > " + Move_Axis_X + @" 
jf @VIDPOK_5018 
if 
  " + _8871 + @" == 0 
jf @VIDPOK_5011 
if 
  " + _8844 + @" == 1 
jf @VIDPOK_4990 
" + _8844 + @" = 0 
jump @VIDPOK_4997 

:VIDPOK_4990
" + _8844 + @" = 1 

:VIDPOK_4997
" + _8871 + @" += 1 
jump @VIDPOK_5237 

:VIDPOK_5011
jump @VIDPOK_5050 

:VIDPOK_5018
if and
  " + Move_Axis_X + @" > -64 
  64 > " + Move_Axis_X + @" 
jf @VIDPOK_5050 
" + _8871 + @" = 0 

:VIDPOK_5050
if 
  " + _8869 + @" == 0 
jf @VIDPOK_5213 
if 
00E1:   player 0 pressed_key 16 
jf @VIDPOK_5206 
if 
  " + _8844 + @" == 0 
jf @VIDPOK_5151 
" + _8869 + @" += 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1026 
4@ += 1 
jump @VIDPOK_5237 
jump @VIDPOK_5206 

:VIDPOK_5151
" + _8869 + @" += 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1026 
" + _8843 + @" = 2 
TIMERA = 0 
4@ += 3 
jump @VIDPOK_5237 

:VIDPOK_5206
jump @VIDPOK_5237 

:VIDPOK_5213
if 
80E1:   not player 0 pressed_key 16 
jf @VIDPOK_5237 
" + _8869 + @" = 0 

:VIDPOK_5237
if 
  4@ == 2 
jf @VIDPOK_5373 
if 
  5 > " + _8826 + @" 
jf @VIDPOK_5287 
" + _8826 + @" += 1 
jump @VIDPOK_5294 

:VIDPOK_5287
" + _8826 + @" = 1 

:VIDPOK_5294
008B: 12@ = " + _8826 + @" 
006A: 12@ *= 1@ 
13@ = Player.Money(" + PlayerChar + @")
gosub @VIDPOK_34875 
005C: 13@ += " + Max_Wager + @" 
if 
001D:   12@ > 13@ 
jf @VIDPOK_5359 
" + _8826 + @" = 1 

:VIDPOK_5359
TIMERA = 0 
4@ += 1 

:VIDPOK_5373
if 
  4@ == 3 
jf @VIDPOK_5398 
4@ = 1 

:VIDPOK_5398
if 
  4@ == 4 
jf @VIDPOK_5495 
12@ = Player.Money(" + PlayerChar + @")
gosub @VIDPOK_34875 
005C: 12@ += " + Max_Wager + @" 
008B: 13@ = " + _8826 + @" 
006A: 13@ *= 1@ 
if 
001D:   13@ > 12@ 
jf @VIDPOK_5488 
4@ = 1 
jump @VIDPOK_5495 

:VIDPOK_5488
4@ = 99 

:VIDPOK_5495
if 
  4@ == 99 
jf @VIDPOK_5705 
if 
  " + _8826 + @" == 6 
jf @VIDPOK_5538 
" + _8826 + @" = 4 

:VIDPOK_5538
if 
  " + _8826 + @" == 7 
jf @VIDPOK_5563 
" + _8826 + @" = 3 

:VIDPOK_5563
if 
  " + _8826 + @" == 8 
jf @VIDPOK_5588 
" + _8826 + @" = 2 

:VIDPOK_5588
if 
  " + _8826 + @" == 9 
jf @VIDPOK_5613 
" + _8826 + @" = 1 

:VIDPOK_5613
008B: 12@ = " + _8826 + @" 
006A: 12@ *= 1@ 
0A10: increase_integer_stat 35 by 12@ 
0093: 15@ = integer 12@ to_float 
15@ *= 0.001 
0A1F: increase_float_stat 81 by 15@ 
008A: " + _8872 + @" = 12@ 
12@ *= -1 
Player.Money(" + PlayerChar + @") += 12@
4@ = 0 
3@ += 1 
jump @VIDPOK_5712 

:VIDPOK_5705
gosub @VIDPOK_26530 

:VIDPOK_5712
if 
  3@ == 2 
jf @VIDPOK_6360 
if 
  4@ == 0 
jf @VIDPOK_5834 
" + _8843 + @" = 0 
" + _8842 + @" = 0 
12@ = 0 

:VIDPOK_5769
if 
  5 > 12@ 
jf @VIDPOK_5823 
" + tmp_8827 + @"(12@,5i) = 0 
" + tmp_8837 + @"(12@,5i) = 0 
12@ += 1 
jump @VIDPOK_5769 

:VIDPOK_5823
059D: shuffle_card_decks 1 
4@ += 1 

:VIDPOK_5834
if 
  4@ == 1 
jf @VIDPOK_5886 
059E: get_card_to 12@ 
gosub @VIDPOK_33633 
008A: " + tmp_8827 + @"[0] = 12@ 
TIMERA = 0 
4@ += 1 

:VIDPOK_5886
if 
  4@ == 2 
jf @VIDPOK_5930 
if 
  TIMERA > 400 
jf @VIDPOK_5930 
4@ += 1 

:VIDPOK_5930
if 
  4@ == 3 
jf @VIDPOK_5982 
059E: get_card_to 12@ 
gosub @VIDPOK_33633 
008A: " + tmp_8827 + @"[1] = 12@ 
TIMERA = 0 
4@ += 1 

:VIDPOK_5982
if 
  4@ == 4 
jf @VIDPOK_6026 
if 
  TIMERA > 400 
jf @VIDPOK_6026 
4@ += 1 

:VIDPOK_6026
if 
  4@ == 5 
jf @VIDPOK_6078 
059E: get_card_to 12@ 
gosub @VIDPOK_33633 
008A: " + tmp_8827 + @"[2] = 12@ 
TIMERA = 0 
4@ += 1 

:VIDPOK_6078
if 
  4@ == 6 
jf @VIDPOK_6122 
if 
  TIMERA > 400 
jf @VIDPOK_6122 
4@ += 1 

:VIDPOK_6122
if 
  4@ == 7 
jf @VIDPOK_6174 
059E: get_card_to 12@ 
gosub @VIDPOK_33633 
008A: " + tmp_8827 + @"[3] = 12@ 
TIMERA = 0 
4@ += 1 

:VIDPOK_6174
if 
  4@ == 8 
jf @VIDPOK_6218 
if 
  TIMERA > 400 
jf @VIDPOK_6218 
4@ += 1 

:VIDPOK_6218
if 
  4@ == 9 
jf @VIDPOK_6270 
059E: get_card_to 12@ 
gosub @VIDPOK_33633 
008A: " + tmp_8827 + @"[4] = 12@ 
TIMERA = 0 
4@ += 1 

:VIDPOK_6270
if 
  4@ == 10 
jf @VIDPOK_6314 
if 
  TIMERA > 800 
jf @VIDPOK_6314 
4@ = 99 

:VIDPOK_6314
if 
  4@ == 99 
jf @VIDPOK_6353 
4@ = 0 
3@ += 1 
jump @VIDPOK_6360 

:VIDPOK_6353
gosub @VIDPOK_26530 

:VIDPOK_6360
if 
  3@ == 3 
jf @VIDPOK_7501 
if 
  4@ == 0 
jf @VIDPOK_6485 
" + _8843 + @" = 2 
" + _8842 + @" = 0 
12@ = 0 

:VIDPOK_6417
if 
  5 > 12@ 
jf @VIDPOK_6471 
" + tmp_8837 + @"(12@,5i) = 2 
" + tmp_8832 + @"(12@,5i) = 0 
12@ += 1 
jump @VIDPOK_6417 

:VIDPOK_6471
" + _8844 + @" = 0 
4@ += 1 

:VIDPOK_6485
if 
  4@ == 1 
jf @VIDPOK_7405 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 64 
jf @VIDPOK_6646 
if 
  " + _8871 + @" == 0 
jf @VIDPOK_6639 
if 
  5 > " + _8844 + @" 
jf @VIDPOK_6639 
" + _8844 + @" += 1 
if 
  " + _8844 + @" == 5 
jf @VIDPOK_6611 
" + _8844 + @" = 0 

:VIDPOK_6611
4@ += 1 
TIMERA = 0 
" + _8871 + @" += 1 
jump @VIDPOK_7173 

:VIDPOK_6639
jump @VIDPOK_6812 

:VIDPOK_6646
if or
00E1:   player 0 pressed_key 10 
  -64 > " + Move_Axis_X + @" 
jf @VIDPOK_6780 
if 
  " + _8871 + @" == 0 
jf @VIDPOK_6773 
if and
  " + _8844 + @" > -1 
  5 > " + _8844 + @" 
jf @VIDPOK_6773 
" + _8844 + @" -= 1 
if 
  " + _8844 + @" == -1 
jf @VIDPOK_6745 
" + _8844 + @" = 4 

:VIDPOK_6745
4@ += 1 
" + _8871 + @" += 1 
TIMERA = 0 
jump @VIDPOK_7173 

:VIDPOK_6773
jump @VIDPOK_6812 

:VIDPOK_6780
if and
  " + Move_Axis_X + @" > -64 
  64 > " + Move_Axis_X + @" 
jf @VIDPOK_6812 
" + _8871 + @" = 0 

:VIDPOK_6812
if or
00E1:   player 0 pressed_key 9 
  " + Move_Axis_Y + @" > 64 
jf @VIDPOK_6864 
" + _8844 + @" = 5 
4@ += 1 
TIMERA = 0 
jump @VIDPOK_7173 

:VIDPOK_6864
if or
00E1:   player 0 pressed_key 8 
  -64 > " + Move_Axis_Y + @" 
jf @VIDPOK_6934 
if 
  " + _8844 + @" == 5 
jf @VIDPOK_6934 
" + _8844 + @" = 1 
4@ += 1 
TIMERA = 0 
jump @VIDPOK_7173 

:VIDPOK_6934
if 
00E1:   player 0 pressed_key 16 
jf @VIDPOK_7148 
if 
  " + _8869 + @" == 0 
jf @VIDPOK_7141 
if 
  5 > " + _8844 + @" 
jf @VIDPOK_7093 
if 
  " + tmp_8832 + @"(" + _8844 + @",5i) == 0 
jf @VIDPOK_7027 
" + tmp_8832 + @"(" + _8844 + @",5i) = 1 
jump @VIDPOK_7038 

:VIDPOK_7027
" + tmp_8832 + @"(" + _8844 + @",5i) = 0 

:VIDPOK_7038
TIMERA = 0 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1026 
4@ += 1 
" + _8869 + @" += 1 
jump @VIDPOK_7173 
jump @VIDPOK_7141 

:VIDPOK_7093
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1026 
TIMERA = 0 
4@ += 2 
" + _8869 + @" += 1 
jump @VIDPOK_7173 

:VIDPOK_7141
jump @VIDPOK_7173 

:VIDPOK_7148
if 
   not " + _8869 + @" == 0 
jf @VIDPOK_7173 
" + _8869 + @" = 0 

:VIDPOK_7173
12@ = 0 

:VIDPOK_7180
if 
  6 > 12@ 
jf @VIDPOK_7405 
if 
  5 > 12@ 
jf @VIDPOK_7351 
if 
87D6:   not  12@ == " + _8844 + @" 
jf @VIDPOK_7293 
if 
  " + tmp_8832 + @"(12@,5i) == 0 
jf @VIDPOK_7275 
" + tmp_8837 + @"(12@,5i) = 2 
jump @VIDPOK_7286 

:VIDPOK_7275
" + tmp_8837 + @"(12@,5i) = 4 

:VIDPOK_7286
jump @VIDPOK_7344 

:VIDPOK_7293
if 
  " + tmp_8832 + @"(12@,5i) == 0 
jf @VIDPOK_7333 
" + tmp_8837 + @"(12@,5i) = 3 
jump @VIDPOK_7344 

:VIDPOK_7333
" + tmp_8837 + @"(12@,5i) = 5 

:VIDPOK_7344
jump @VIDPOK_7391 

:VIDPOK_7351
if 
87D6:   not  12@ == " + _8844 + @" 
jf @VIDPOK_7384 
" + _8843 + @" = 2 
jump @VIDPOK_7391 

:VIDPOK_7384
" + _8843 + @" = 3 

:VIDPOK_7391
12@ += 1 
jump @VIDPOK_7180 

:VIDPOK_7405
if 
  4@ == 2 
jf @VIDPOK_7430 
4@ = 1 

:VIDPOK_7430
if 
  4@ == 3 
jf @VIDPOK_7455 
4@ = 99 

:VIDPOK_7455
if 
  4@ == 99 
jf @VIDPOK_7494 
4@ = 0 
3@ += 1 
jump @VIDPOK_7501 

:VIDPOK_7494
gosub @VIDPOK_26530 

:VIDPOK_7501
if 
  3@ == 4 
jf @VIDPOK_8619 
if 
  4@ == 0 
jf @VIDPOK_7741 
" + _8843 + @" = 0 
" + _8842 + @" = 0 
12@ = 0 

:VIDPOK_7558
if 
  5 > 12@ 
jf @VIDPOK_7601 
" + tmp_8837 + @"(12@,5i) = 0 
12@ += 1 
jump @VIDPOK_7558 

:VIDPOK_7601
" + High_Cards_Number + @" = 0 
12@ = 0 

:VIDPOK_7615
if 
  5 > 12@ 
jf @VIDPOK_7734 
if 
   not " + tmp_8832 + @"(12@,5i) == 0 
jf @VIDPOK_7720 
0084: " + _9069 + @" = " + tmp_8827 + @"(12@,5i) 
gosub @VIDPOK_33380 
if or
  " + _9070 + @" == 1 
  " + _9070 + @" == 11 
  " + _9070 + @" == 12 
  " + _9070 + @" == 13 
jf @VIDPOK_7720 
" + High_Cards_Number + @" += 1 

:VIDPOK_7720
12@ += 1 
jump @VIDPOK_7615 

:VIDPOK_7734
4@ += 1 

:VIDPOK_7741
if 
  4@ == 1 
jf @VIDPOK_7845 
12@ = 0 

:VIDPOK_7766
if 
  5 > 12@ 
jf @VIDPOK_7831 
if 
  " + tmp_8832 + @"(12@,5i) == 0 
jf @VIDPOK_7817 
" + tmp_8827 + @"(12@,5i) = 0 

:VIDPOK_7817
12@ += 1 
jump @VIDPOK_7766 

:VIDPOK_7831
TIMERA = 0 
4@ += 1 

:VIDPOK_7845
if 
  4@ == 2 
jf @VIDPOK_7889 
if 
  TIMERA > 500 
jf @VIDPOK_7889 
4@ += 1 

:VIDPOK_7889
if 
  4@ == 3 
jf @VIDPOK_7973 
if 
  " + tmp_8832 + @"[0] == 0 
jf @VIDPOK_7966 
059E: get_card_to 12@ 
gosub @VIDPOK_33635 
008A: " + tmp_8827 + @"[0] = 12@ 
TIMERA = 0 
4@ += 1 
jump @VIDPOK_7973 

:VIDPOK_7966
4@ += 2 

:VIDPOK_7973
if 
  4@ == 4 
jf @VIDPOK_8017 
if 
  TIMERA > 400 
jf @VIDPOK_8017 
4@ += 1 

:VIDPOK_8017
if 
  4@ == 5 
jf @VIDPOK_8101 
if 
  " + tmp_8832 + @"[1] == 0 
jf @VIDPOK_8094 
059E: get_card_to 12@ 
gosub @VIDPOK_33635 
008A: " + tmp_8827 + @"[1] = 12@ 
TIMERA = 0 
4@ += 1 
jump @VIDPOK_8101 

:VIDPOK_8094
4@ += 2 

:VIDPOK_8101
if 
  4@ == 6 
jf @VIDPOK_8145 
if 
  TIMERA > 400 
jf @VIDPOK_8145 
4@ += 1 

:VIDPOK_8145
if 
  4@ == 7 
jf @VIDPOK_8229 
if 
  " + tmp_8832 + @"[2] == 0 
jf @VIDPOK_8222 
059E: get_card_to 12@ 
gosub @VIDPOK_33635 
008A: " + tmp_8827 + @"[2] = 12@ 
TIMERA = 0 
4@ += 1 
jump @VIDPOK_8229 

:VIDPOK_8222
4@ += 2 

:VIDPOK_8229
if 
  4@ == 8 
jf @VIDPOK_8273 
if 
  TIMERA > 400 
jf @VIDPOK_8273 
4@ += 1 

:VIDPOK_8273
if 
  4@ == 9 
jf @VIDPOK_8357 
if 
  " + tmp_8832 + @"[3] == 0 
jf @VIDPOK_8350 
059E: get_card_to 12@ 
gosub @VIDPOK_33635 
008A: " + tmp_8827 + @"[3] = 12@ 
TIMERA = 0 
4@ += 1 
jump @VIDPOK_8357 

:VIDPOK_8350
4@ += 2 

:VIDPOK_8357
if 
  4@ == 10 
jf @VIDPOK_8401 
if 
  TIMERA > 400 
jf @VIDPOK_8401 
4@ += 1 

:VIDPOK_8401
if 
  4@ == 11 
jf @VIDPOK_8485 
if 
  " + tmp_8832 + @"[4] == 0 
jf @VIDPOK_8478 
059E: get_card_to 12@ 
gosub @VIDPOK_33635 
008A: " + tmp_8827 + @"[4] = 12@ 
TIMERA = 0 
4@ += 1 
jump @VIDPOK_8485 

:VIDPOK_8478
4@ += 2 

:VIDPOK_8485
if 
  4@ == 12 
jf @VIDPOK_8529 
if 
  TIMERA > 400 
jf @VIDPOK_8529 
4@ += 1 

:VIDPOK_8529
if 
  4@ == 13 
jf @VIDPOK_8573 
if 
  TIMERA > 800 
jf @VIDPOK_8573 
4@ = 99 

:VIDPOK_8573
if 
  4@ == 99 
jf @VIDPOK_8612 
4@ = 0 
3@ += 1 
jump @VIDPOK_8619 

:VIDPOK_8612
gosub @VIDPOK_26530 

:VIDPOK_8619
if 
  3@ == 5 
jf @VIDPOK_10143 
if 
  4@ == 0 
jf @VIDPOK_8739 
" + _8845 + @" = 0 
" + _8846 + @" = 0 
" + _8847 + @" = 0 
" + _8848 + @" = 0 
" + _8849 + @" = 0 
" + _8850 + @" = 0 
" + _8851 + @" = 0 
" + _8852 + @" = 0 
" + _8853 + @" = 0 
" + _8854 + @" = 0 
" + _8855 + @" = 0 
4@ += 1 

:VIDPOK_8739
if 
  4@ == 1 
jf @VIDPOK_10065 
12@ = 0 

:VIDPOK_8764
if 
  5 > 12@ 
jf @VIDPOK_8858 
0084: " + _9069 + @" = " + tmp_8827 + @"(12@,5i) 
gosub @VIDPOK_33380 
0084: " + tmp_8856 + @"(12@,5i) = " + _9070 + @" 
0084: " + _9069 + @" = " + tmp_8827 + @"(12@,5i) 
gosub @VIDPOK_33528 
0084: " + tmp_8861 + @"(12@,5i) = " + _9070 + @" 
12@ += 1 
jump @VIDPOK_8764 

:VIDPOK_8858
03A9: save_newline_to_debug_file 
14@ = 1 

:VIDPOK_8867
if 
  14@ > 0 
jf @VIDPOK_9052 
12@ = 0 
13@ = 0 
14@ = 0 

:VIDPOK_8906
if 
  5 > 12@ 
jf @VIDPOK_9045 
0085: 13@ = 12@ 
13@ += 1 
if 
  5 > 13@ 
jf @VIDPOK_9031 
if 
001C:   " + tmp_8856 + @"(12@,5i) > " + tmp_8856 + @"(13@,5i) 
jf @VIDPOK_9031 
008B: 26@ = " + tmp_8856 + @"(13@,5i) 
0084: " + tmp_8856 + @"(13@,5i) = " + tmp_8856 + @"(12@,5i) 
008A: " + tmp_8856 + @"(12@,5i) = 26@ 
14@ += 1 

:VIDPOK_9031
12@ += 1 
jump @VIDPOK_8906 

:VIDPOK_9045
jump @VIDPOK_8867 

:VIDPOK_9052
if and
003A:   " + tmp_8861 + @"[0] == " + tmp_8861 + @"[1] 
003A:   " + tmp_8861 + @"[1] == " + tmp_8861 + @"[2] 
003A:   " + tmp_8861 + @"[2] == " + tmp_8861 + @"[3] 
003A:   " + tmp_8861 + @"[3] == " + tmp_8861 + @"[4] 
jf @VIDPOK_9102 
" + _8849 + @" = 1 

:VIDPOK_9102
008B: 12@ = " + tmp_8856 + @"[0] 
12@ += 1 
if 
07D6:   12@ == " + tmp_8856 + @"[1] 
jf @VIDPOK_9270 
008B: 12@ = " + tmp_8856 + @"[1] 
12@ += 1 
if 
07D6:   12@ == " + tmp_8856 + @"[2] 
jf @VIDPOK_9270 
008B: 12@ = " + tmp_8856 + @"[2] 
12@ += 1 
if 
07D6:   12@ == " + tmp_8856 + @"[3] 
jf @VIDPOK_9270 
008B: 12@ = " + tmp_8856 + @"[3] 
12@ += 1 
if 
07D6:   12@ == " + tmp_8856 + @"[4] 
jf @VIDPOK_9270 
" + _8850 + @" = 1 
if 
  " + _8849 + @" == 1 
jf @VIDPOK_9270 
" + _8846 + @" = 1 

:VIDPOK_9270
if and
  " + tmp_8856 + @"[0] == 1 
  " + tmp_8856 + @"[1] == 10 
  " + tmp_8856 + @"[2] == 11 
  " + tmp_8856 + @"[3] == 12 
  " + tmp_8856 + @"[4] == 13 
jf @VIDPOK_9355 
" + _8850 + @" = 1 
if 
  " + _8849 + @" == 1 
jf @VIDPOK_9355 
" + _8846 + @" = 1 
" + _8845 + @" = 1 

:VIDPOK_9355
12@ = 0 
13@ = 0 
14@ = 0 

:VIDPOK_9376
if 
  5 > 12@ 
jf @VIDPOK_9649 
0085: 13@ = 12@ 
13@ += 1 
if 
  5 > 13@ 
jf @VIDPOK_9635 
if 
003A:   " + tmp_8856 + @"(12@,5i) == " + tmp_8856 + @"(13@,5i) 
jf @VIDPOK_9493 
14@ += 1 
if 
  13@ == 4 
jf @VIDPOK_9486 
jump @VIDPOK_9493 

:VIDPOK_9486
jump @VIDPOK_9635 

:VIDPOK_9493
if 
  14@ > 0 
jf @VIDPOK_9635 
if 
  14@ == 1 
jf @VIDPOK_9578 
if 
  " + _8854 + @" == 0 
jf @VIDPOK_9566 
0084: " + _8854 + @" = " + tmp_8856 + @"(12@,5i) 
jump @VIDPOK_9578 

:VIDPOK_9566
0084: " + _8855 + @" = " + tmp_8856 + @"(12@,5i) 

:VIDPOK_9578
if 
  14@ == 2 
jf @VIDPOK_9603 
" + _8851 + @" = 1 

:VIDPOK_9603
if 
  14@ == 3 
jf @VIDPOK_9628 
" + _8847 + @" = 1 

:VIDPOK_9628
14@ = 0 

:VIDPOK_9635
12@ += 1 
jump @VIDPOK_9376 

:VIDPOK_9649
if and
  " + _8851 + @" == 1 
   not " + _8854 + @" == 0 
jf @VIDPOK_9681 
" + _8848 + @" = 1 

:VIDPOK_9681
if and
   not " + _8854 + @" == 0 
   not " + _8855 + @" == 0 
jf @VIDPOK_9713 
" + _8852 + @" = 1 

:VIDPOK_9713
if 
   not " + _8854 + @" == 0 
jf @VIDPOK_9763 
if or
  " + _8854 + @" > 10 
  " + _8854 + @" == 1 
jf @VIDPOK_9763 
" + _8853 + @" = 1 

:VIDPOK_9763
if 
  " + _8845 + @" == 1 
jf @VIDPOK_9795 
" + _8866 + @" = 9 
jump @VIDPOK_10058 

:VIDPOK_9795
if 
  " + _8846 + @" == 1 
jf @VIDPOK_9827 
" + _8866 + @" = 8 
jump @VIDPOK_10058 

:VIDPOK_9827
if 
  " + _8847 + @" == 1 
jf @VIDPOK_9859 
" + _8866 + @" = 7 
jump @VIDPOK_10058 

:VIDPOK_9859
if 
  " + _8848 + @" == 1 
jf @VIDPOK_9891 
" + _8866 + @" = 6 
jump @VIDPOK_10058 

:VIDPOK_9891
if 
  " + _8849 + @" == 1 
jf @VIDPOK_9923 
" + _8866 + @" = 5 
jump @VIDPOK_10058 

:VIDPOK_9923
if 
  " + _8850 + @" == 1 
jf @VIDPOK_9955 
" + _8866 + @" = 4 
jump @VIDPOK_10058 

:VIDPOK_9955
if 
  " + _8851 + @" == 1 
jf @VIDPOK_9987 
" + _8866 + @" = 3 
jump @VIDPOK_10058 

:VIDPOK_9987
if 
  " + _8852 + @" == 1 
jf @VIDPOK_10019 
" + _8866 + @" = 2 
jump @VIDPOK_10058 

:VIDPOK_10019
if 
  " + _8853 + @" == 1 
jf @VIDPOK_10051 
" + _8866 + @" = 1 
jump @VIDPOK_10058 

:VIDPOK_10051
" + _8866 + @" = 0 

:VIDPOK_10058
4@ += 1 

:VIDPOK_10065
if 
  4@ == 2 
jf @VIDPOK_10090 
4@ = 99 

:VIDPOK_10090
if 
  4@ == 99 
jf @VIDPOK_10136 
3@ += 1 
4@ = 0 
TIMERA = 0 
jump @VIDPOK_10143 

:VIDPOK_10136
gosub @VIDPOK_26530 

:VIDPOK_10143
if 
  3@ == 6 
jf @VIDPOK_12154 
if 
  4@ == 0 
jf @VIDPOK_11921 
0085: 12@ = 1@ 
if 
  " + _8866 + @" == 9 
jf @VIDPOK_10383 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_10383 jumps 1 @VIDPOK_10268 2 @VIDPOK_10291 3 @VIDPOK_10314 4 @VIDPOK_10337 5 @VIDPOK_10360 -1 @VIDPOK_10383 -1 @VIDPOK_10383 

:VIDPOK_10268
0085: 14@ = 12@ 
14@ *= 250 
jump @VIDPOK_10383 

:VIDPOK_10291
0085: 14@ = 12@ 
14@ *= 500 
jump @VIDPOK_10383 

:VIDPOK_10314
0085: 14@ = 12@ 
14@ *= 750 
jump @VIDPOK_10383 

:VIDPOK_10337
0085: 14@ = 12@ 
14@ *= 1000 
jump @VIDPOK_10383 

:VIDPOK_10360
0085: 14@ = 12@ 
14@ *= 4000 
jump @VIDPOK_10383 

:VIDPOK_10383
if 
  " + _8866 + @" == 8 
jf @VIDPOK_10577 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_10577 jumps 1 @VIDPOK_10464 2 @VIDPOK_10486 3 @VIDPOK_10508 4 @VIDPOK_10531 5 @VIDPOK_10554 -1 @VIDPOK_10577 -1 @VIDPOK_10577 

:VIDPOK_10464
0085: 14@ = 12@ 
14@ *= 50 
jump @VIDPOK_10577 

:VIDPOK_10486
0085: 14@ = 12@ 
14@ *= 100 
jump @VIDPOK_10577 

:VIDPOK_10508
0085: 14@ = 12@ 
14@ *= 150 
jump @VIDPOK_10577 

:VIDPOK_10531
0085: 14@ = 12@ 
14@ *= 200 
jump @VIDPOK_10577 

:VIDPOK_10554
0085: 14@ = 12@ 
14@ *= 250 
jump @VIDPOK_10577 

:VIDPOK_10577
if 
  " + _8866 + @" == 7 
jf @VIDPOK_10768 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_10768 jumps 1 @VIDPOK_10658 2 @VIDPOK_10680 3 @VIDPOK_10702 4 @VIDPOK_10724 5 @VIDPOK_10746 -1 @VIDPOK_10768 -1 @VIDPOK_10768 

:VIDPOK_10658
0085: 14@ = 12@ 
14@ *= 25 
jump @VIDPOK_10768 

:VIDPOK_10680
0085: 14@ = 12@ 
14@ *= 50 
jump @VIDPOK_10768 

:VIDPOK_10702
0085: 14@ = 12@ 
14@ *= 75 
jump @VIDPOK_10768 

:VIDPOK_10724
0085: 14@ = 12@ 
14@ *= 100 
jump @VIDPOK_10768 

:VIDPOK_10746
0085: 14@ = 12@ 
14@ *= 125 
jump @VIDPOK_10768 

:VIDPOK_10768
if 
  " + _8866 + @" == 6 
jf @VIDPOK_10959 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_10959 jumps 1 @VIDPOK_10849 2 @VIDPOK_10871 3 @VIDPOK_10893 4 @VIDPOK_10915 5 @VIDPOK_10937 -1 @VIDPOK_10959 -1 @VIDPOK_10959 

:VIDPOK_10849
0085: 14@ = 12@ 
14@ *= 9 
jump @VIDPOK_10959 

:VIDPOK_10871
0085: 14@ = 12@ 
14@ *= 18 
jump @VIDPOK_10959 

:VIDPOK_10893
0085: 14@ = 12@ 
14@ *= 27 
jump @VIDPOK_10959 

:VIDPOK_10915
0085: 14@ = 12@ 
14@ *= 36 
jump @VIDPOK_10959 

:VIDPOK_10937
0085: 14@ = 12@ 
14@ *= 45 
jump @VIDPOK_10959 

:VIDPOK_10959
if 
  " + _8866 + @" == 5 
jf @VIDPOK_11150 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_11150 jumps 1 @VIDPOK_11040 2 @VIDPOK_11062 3 @VIDPOK_11084 4 @VIDPOK_11106 5 @VIDPOK_11128 -1 @VIDPOK_11150 -1 @VIDPOK_11150 

:VIDPOK_11040
0085: 14@ = 12@ 
14@ *= 6 
jump @VIDPOK_11150 

:VIDPOK_11062
0085: 14@ = 12@ 
14@ *= 12 
jump @VIDPOK_11150 

:VIDPOK_11084
0085: 14@ = 12@ 
14@ *= 18 
jump @VIDPOK_11150 

:VIDPOK_11106
0085: 14@ = 12@ 
14@ *= 24 
jump @VIDPOK_11150 

:VIDPOK_11128
0085: 14@ = 12@ 
14@ *= 30 
jump @VIDPOK_11150 

:VIDPOK_11150
if 
  " + _8866 + @" == 4 
jf @VIDPOK_11341 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_11341 jumps 1 @VIDPOK_11231 2 @VIDPOK_11253 3 @VIDPOK_11275 4 @VIDPOK_11297 5 @VIDPOK_11319 -1 @VIDPOK_11341 -1 @VIDPOK_11341 

:VIDPOK_11231
0085: 14@ = 12@ 
14@ *= 4 
jump @VIDPOK_11341 

:VIDPOK_11253
0085: 14@ = 12@ 
14@ *= 8 
jump @VIDPOK_11341 

:VIDPOK_11275
0085: 14@ = 12@ 
14@ *= 12 
jump @VIDPOK_11341 

:VIDPOK_11297
0085: 14@ = 12@ 
14@ *= 16 
jump @VIDPOK_11341 

:VIDPOK_11319
0085: 14@ = 12@ 
14@ *= 20 
jump @VIDPOK_11341 

:VIDPOK_11341
if 
  " + _8866 + @" == 3 
jf @VIDPOK_11532 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_11532 jumps 1 @VIDPOK_11422 2 @VIDPOK_11444 3 @VIDPOK_11466 4 @VIDPOK_11488 5 @VIDPOK_11510 -1 @VIDPOK_11532 -1 @VIDPOK_11532 

:VIDPOK_11422
0085: 14@ = 12@ 
14@ *= 3 
jump @VIDPOK_11532 

:VIDPOK_11444
0085: 14@ = 12@ 
14@ *= 6 
jump @VIDPOK_11532 

:VIDPOK_11466
0085: 14@ = 12@ 
14@ *= 9 
jump @VIDPOK_11532 

:VIDPOK_11488
0085: 14@ = 12@ 
14@ *= 12 
jump @VIDPOK_11532 

:VIDPOK_11510
0085: 14@ = 12@ 
14@ *= 15 
jump @VIDPOK_11532 

:VIDPOK_11532
if 
  " + _8866 + @" == 2 
jf @VIDPOK_11723 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_11723 jumps 1 @VIDPOK_11613 2 @VIDPOK_11635 3 @VIDPOK_11657 4 @VIDPOK_11679 5 @VIDPOK_11701 -1 @VIDPOK_11723 -1 @VIDPOK_11723 

:VIDPOK_11613
0085: 14@ = 12@ 
14@ *= 2 
jump @VIDPOK_11723 

:VIDPOK_11635
0085: 14@ = 12@ 
14@ *= 4 
jump @VIDPOK_11723 

:VIDPOK_11657
0085: 14@ = 12@ 
14@ *= 6 
jump @VIDPOK_11723 

:VIDPOK_11679
0085: 14@ = 12@ 
14@ *= 8 
jump @VIDPOK_11723 

:VIDPOK_11701
0085: 14@ = 12@ 
14@ *= 10 
jump @VIDPOK_11723 

:VIDPOK_11723
if 
  " + _8866 + @" == 1 
jf @VIDPOK_11914 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_11914 jumps 1 @VIDPOK_11804 2 @VIDPOK_11826 3 @VIDPOK_11848 4 @VIDPOK_11870 5 @VIDPOK_11892 -1 @VIDPOK_11914 -1 @VIDPOK_11914 

:VIDPOK_11804
0085: 14@ = 12@ 
14@ *= 1 
jump @VIDPOK_11914 

:VIDPOK_11826
0085: 14@ = 12@ 
14@ *= 2 
jump @VIDPOK_11914 

:VIDPOK_11848
0085: 14@ = 12@ 
14@ *= 3 
jump @VIDPOK_11914 

:VIDPOK_11870
0085: 14@ = 12@ 
14@ *= 4 
jump @VIDPOK_11914 

:VIDPOK_11892
0085: 14@ = 12@ 
14@ *= 5 
jump @VIDPOK_11914 

:VIDPOK_11914
4@ += 1 

:VIDPOK_11921
if 
   not " + _8866 + @" == 0 
jf @VIDPOK_12072 
if or
  TIMERA > 4000 
00E1:   player 0 pressed_key 16 
jf @VIDPOK_12065 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1025 
Player.Money(" + PlayerChar + @") += 14@
0085: 12@ = 14@ 
0064: 12@ -= " + _8872 + @" 
0A10: increase_integer_stat 37 by 12@ 
08F8: display_stat_update_box 0 
0627: update_integer_stat 38 to 12@ 
08F8: display_stat_update_box 1 
3@ = 1 
4@ = 0 
" + _8844 + @" = 1 
" + _8869 + @" = 1 
" + _8872 + @" = 0 

:VIDPOK_12065
jump @VIDPOK_12147 

:VIDPOK_12072
if or
  TIMERA > 4000 
00E1:   player 0 pressed_key 16 
jf @VIDPOK_12147 
08F8: display_stat_update_box 0 
0627: update_integer_stat 39 to " + _8872 + @" 
08F8: display_stat_update_box 1 
" + _8872 + @" = 0 
" + _8869 + @" = 1 
3@ = 1 
4@ = 0 
" + _8844 + @" = 1 

:VIDPOK_12147
gosub @VIDPOK_26530 

:VIDPOK_12154
gosub @VIDPOK_12212 
if 
  3@ > 0 
jf @VIDPOK_12210 
if 
00E1:   player 0 pressed_key 15 
jf @VIDPOK_12210 
7@ = 1 
" + _8870 + @" = 1 

:VIDPOK_12210
return 

:VIDPOK_12212
if 
0736:   is_keyboard_key_just_pressed 67 
jf @VIDPOK_12778 
" + _8906 + @" += 1 
if 
  " + _8906 + @" > 13 
jf @VIDPOK_12259 
" + _8906 + @" = 0 

:VIDPOK_12259
if 
  " + _8906 + @" == 1 
jf @VIDPOK_12297 
0662: printstring ""EDIT_BET_DETAILS"" 

:VIDPOK_12297
if 
  " + _8906 + @" == 2 
jf @VIDPOK_12335 
0662: printstring ""EDIT_SHIFT_CARDS"" 

:VIDPOK_12335
if 
  " + _8906 + @" == 3 
jf @VIDPOK_12390 
0662: printstring ""EDIT_SHIFT_TABLE_ROWS_AND_COLUMNS"" 

:VIDPOK_12390
if 
  " + _8906 + @" == 4 
jf @VIDPOK_12429 
0662: printstring ""EDIT_HOLD_BUTTONS"" 

:VIDPOK_12429
if 
  " + _8906 + @" == 5 
jf @VIDPOK_12463 
0662: printstring ""EDIT_BET_ONE"" 

:VIDPOK_12463
if 
  " + _8906 + @" == 6 
jf @VIDPOK_12494 
0662: printstring ""EDIT_DEAL"" 

:VIDPOK_12494
if 
  " + _8906 + @" == 7 
jf @VIDPOK_12537 
0662: printstring ""EDIT_BORDER_THICKNESS"" 

:VIDPOK_12537
if 
  " + _8906 + @" == 8 
jf @VIDPOK_12575 
0662: printstring ""EDIT_TABLE_LINES"" 

:VIDPOK_12575
if 
  " + _8906 + @" == 9 
jf @VIDPOK_12606 
0662: printstring ""EDIT_TEXT"" 

:VIDPOK_12606
if 
  " + _8906 + @" == 10 
jf @VIDPOK_12638 
0662: printstring ""EDIT_TILES"" 

:VIDPOK_12638
if 
  " + _8906 + @" == 11 
jf @VIDPOK_12681 
0662: printstring ""EDIT_TABLE_BACKGROUND"" 

:VIDPOK_12681
if 
  " + _8906 + @" == 12 
jf @VIDPOK_12733 
0662: printstring ""EDIT_TABLE_HIGHLIGHTED_COLUMNS"" 

:VIDPOK_12733
if 
  " + _8906 + @" == 13 
jf @VIDPOK_12778 
0662: printstring ""EDIT_BUTTON_TEXT_OFFSET"" 

:VIDPOK_12778
if 
  " + _8906 + @" == 1 
jf @VIDPOK_12982 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_12862 
" + POKER_Counter + @" += 1 
if 
  " + POKER_Counter + @" > 7 
jf @VIDPOK_12843 
" + POKER_Counter + @" = 0 

:VIDPOK_12843
0663: printint ""EDIT_COUNTER"" " + POKER_Counter + @" 

:VIDPOK_12862
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_12892 
" + tmp_POKER_Y_screen + @"(" + POKER_Counter + @",8f) += -1.0 

:VIDPOK_12892
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_12922 
" + tmp_POKER_Y_screen + @"(" + POKER_Counter + @",8f) += 1.0 

:VIDPOK_12922
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_12952 
" + tmp_POKER_X_screen + @"(" + POKER_Counter + @",8f) += 1.0 

:VIDPOK_12952
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_12982 
" + tmp_POKER_X_screen + @"(" + POKER_Counter + @",8f) += -1.0 

:VIDPOK_12982
if 
  " + _8906 + @" == 2 
jf @VIDPOK_13290 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_13066 
" + POKER_Counter + @" += 1 
if 
  " + POKER_Counter + @" > 4 
jf @VIDPOK_13047 
" + POKER_Counter + @" = 0 

:VIDPOK_13047
0663: printint ""EDIT_COUNTER"" " + POKER_Counter + @" 

:VIDPOK_13066
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_13096 
" + tmp_POKER_Y_Card + @"(" + POKER_Counter + @",5f) += -1.0 

:VIDPOK_13096
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_13126 
" + tmp_POKER_Y_Card + @"(" + POKER_Counter + @",5f) += 1.0 

:VIDPOK_13126
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_13156 
" + tmp_POKER_X_Card + @"(" + POKER_Counter + @",5f) += 1.0 

:VIDPOK_13156
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_13186 
" + tmp_POKER_X_Card + @"(" + POKER_Counter + @",5f) += -1.0 

:VIDPOK_13186
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_13212 
" + POKER_Card_Width + @" += 1.0 

:VIDPOK_13212
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_13238 
" + POKER_Card_Width + @" += -1.0 

:VIDPOK_13238
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_13264 
" + POKER_Card_Height + @" += 1.0 

:VIDPOK_13264
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_13290 
" + POKER_Card_Height + @" += -1.0 

:VIDPOK_13290
if 
  " + _8906 + @" == 3 
jf @VIDPOK_13544 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_13374 
" + POKER_Counter + @" += 1 
if 
  " + POKER_Counter + @" > 9 
jf @VIDPOK_13355 
" + POKER_Counter + @" = 0 

:VIDPOK_13355
0663: printint ""EDIT_COUNTER"" " + POKER_Counter + @" 

:VIDPOK_13374
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_13404 
" + tmp_POKER_Y_Row + @"(" + POKER_Counter + @",10f) += -1.0 

:VIDPOK_13404
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_13434 
" + tmp_POKER_Y_Row + @"(" + POKER_Counter + @",10f) += 1.0 

:VIDPOK_13434
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_13489 
if 
  " + POKER_Counter + @" > 5 
jf @VIDPOK_13475 
" + POKER_Counter + @" = 0 

:VIDPOK_13475
" + tmp_POKER_X_Col + @"(" + POKER_Counter + @",6f) += 1.0 

:VIDPOK_13489
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_13544 
if 
  " + POKER_Counter + @" > 5 
jf @VIDPOK_13530 
" + POKER_Counter + @" = 0 

:VIDPOK_13530
" + tmp_POKER_X_Col + @"(" + POKER_Counter + @",6f) += -1.0 

:VIDPOK_13544
if 
  " + _8906 + @" == 4 
jf @VIDPOK_13731 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_13577 

:VIDPOK_13577
if 
0736:   is_keyboard_key_just_pressed 87 
jf @VIDPOK_13602 
" + POKER_Hold_Button_Offset + @" += -1.0 

:VIDPOK_13602
if 
0736:   is_keyboard_key_just_pressed 83 
jf @VIDPOK_13627 
" + POKER_Hold_Button_Offset + @" += 1.0 

:VIDPOK_13627
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_13653 
" + POKER_Hold_Width + @" += 1.0 

:VIDPOK_13653
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_13679 
" + POKER_Hold_Width + @" += -1.0 

:VIDPOK_13679
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_13705 
" + POKER_Hold_Height + @" += 1.0 

:VIDPOK_13705
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_13731 
" + POKER_Hold_Height + @" += -1.0 

:VIDPOK_13731
if 
  " + _8906 + @" == 5 
jf @VIDPOK_13972 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_13764 

:VIDPOK_13764
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_13790 
" + POKER_Y_Bet_One + @" += -1.0 

:VIDPOK_13790
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_13816 
" + POKER_Y_Bet_One + @" += 1.0 

:VIDPOK_13816
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_13842 
" + POKER_X_Bet_One + @" += 1.0 

:VIDPOK_13842
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_13868 
" + POKER_X_Bet_One + @" += -1.0 

:VIDPOK_13868
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_13894 
" + POKER_Bet_One_Width + @" += 1.0 

:VIDPOK_13894
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_13920 
" + POKER_Bet_One_Width + @" += -1.0 

:VIDPOK_13920
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_13946 
" + POKER_Bet_One_Height + @" += 1.0 

:VIDPOK_13946
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_13972 
" + POKER_Bet_One_Height + @" += -1.0 

:VIDPOK_13972
if 
  " + _8906 + @" == 6 
jf @VIDPOK_14213 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_14005 

:VIDPOK_14005
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_14031 
" + POKER_Y_Deal + @" += -1.0 

:VIDPOK_14031
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_14057 
" + POKER_Y_Deal + @" += 1.0 

:VIDPOK_14057
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_14083 
" + POKER_X_Deal + @" += 1.0 

:VIDPOK_14083
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_14109 
" + POKER_X_Deal + @" += -1.0 

:VIDPOK_14109
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_14135 
" + POKER_Deal_Width + @" += 1.0 

:VIDPOK_14135
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_14161 
" + POKER_Deal_Width + @" += -1.0 

:VIDPOK_14161
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_14187 
" + POKER_Deal_Height + @" += 1.0 

:VIDPOK_14187
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_14213 
" + POKER_Deal_Height + @" += -1.0 

:VIDPOK_14213
if 
  " + _8906 + @" == 7 
jf @VIDPOK_14283 
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_14257 
" + POKER_Border_Thickness + @" += 0.1 

:VIDPOK_14257
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_14283 
" + POKER_Border_Thickness + @" += -0.1 

:VIDPOK_14283
if 
  " + _8906 + @" == 8 
jf @VIDPOK_14663 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_14367 
" + POKER_Counter + @" += 1 
if 
  " + POKER_Counter + @" > 8 
jf @VIDPOK_14348 
" + POKER_Counter + @" = 0 

:VIDPOK_14348
0663: printint ""EDIT_COUNTER"" " + POKER_Counter + @" 

:VIDPOK_14367
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_14397 
" + tmp_POKER_Y_Line + @"(" + POKER_Counter + @",9f) += -1.0 

:VIDPOK_14397
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_14427 
" + tmp_POKER_Y_Line + @"(" + POKER_Counter + @",9f) += 1.0 

:VIDPOK_14427
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_14457 
" + tmp_POKER_X_Line + @"(" + POKER_Counter + @",9f) += 1.0 

:VIDPOK_14457
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_14487 
" + tmp_POKER_X_Line + @"(" + POKER_Counter + @",9f) += -1.0 

:VIDPOK_14487
if 
0736:   is_keyboard_key_just_pressed 142 
jf @VIDPOK_14543 
0089: 15@ = " + tmp_POKER_Line_Width + @"(" + POKER_Counter + @",9f) 
0086: " + tmp_POKER_Line_Width + @"(" + POKER_Counter + @",9f) = " + tmp_POKER_Line_Height + @"(" + POKER_Counter + @",9f) 
0088: " + tmp_POKER_Line_Height + @"(" + POKER_Counter + @",9f) = 15@ 

:VIDPOK_14543
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_14573 
" + tmp_POKER_Line_Width + @"(" + POKER_Counter + @",9f) += -1.0 

:VIDPOK_14573
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_14603 
" + tmp_POKER_Line_Width + @"(" + POKER_Counter + @",9f) += 1.0 

:VIDPOK_14603
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_14633 
" + tmp_POKER_Line_Height + @"(" + POKER_Counter + @",9f) += 1.0 

:VIDPOK_14633
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_14663 
" + tmp_POKER_Line_Height + @"(" + POKER_Counter + @",9f) += -1.0 

:VIDPOK_14663
if 
  " + _8906 + @" == 9 
jf @VIDPOK_15600 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_14747 
" + POKER_Counter + @" += 1 
if 
  " + POKER_Counter + @" > 5 
jf @VIDPOK_14728 
" + POKER_Counter + @" = 0 

:VIDPOK_14728
0663: printint ""EDIT_COUNTER"" " + POKER_Counter + @" 

:VIDPOK_14747
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_14777 
" + tmp_POKER_Y_Text_Scale + @"(" + POKER_Counter + @",6f) += -0.01 

:VIDPOK_14777
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_14807 
" + tmp_POKER_Y_Text_Scale + @"(" + POKER_Counter + @",6f) += 0.01 

:VIDPOK_14807
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_14837 
" + tmp_POKER_X_Text_Scale + @"(" + POKER_Counter + @",6f) += 0.01 

:VIDPOK_14837
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_14867 
" + tmp_POKER_X_Text_Scale + @"(" + POKER_Counter + @",6f) += -0.01 

:VIDPOK_14867
if 
0736:   is_keyboard_key_just_pressed 82 
jf @VIDPOK_14907 
" + tmp_POKER_Text_Color_R + @"(" + POKER_Counter + @",6i) += 1 
0663: printint ""RED"" " + tmp_POKER_Text_Color_R + @"(" + POKER_Counter + @",6i) 

:VIDPOK_14907
if 
0736:   is_keyboard_key_just_pressed 86 
jf @VIDPOK_14947 
" + tmp_POKER_Text_Color_R + @"(" + POKER_Counter + @",6i) += -1 
0663: printint ""RED"" " + tmp_POKER_Text_Color_R + @"(" + POKER_Counter + @",6i) 

:VIDPOK_14947
if 
0736:   is_keyboard_key_just_pressed 84 
jf @VIDPOK_14989 
" + tmp_POKER_Text_Color_G + @"(" + POKER_Counter + @",6i) += 1 
0663: printint ""GREEN"" " + tmp_POKER_Text_Color_G + @"(" + POKER_Counter + @",6i) 

:VIDPOK_14989
if 
0736:   is_keyboard_key_just_pressed 71 
jf @VIDPOK_15031 
" + tmp_POKER_Text_Color_G + @"(" + POKER_Counter + @",6i) += -1 
0663: printint ""GREEN"" " + tmp_POKER_Text_Color_G + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15031
if 
0736:   is_keyboard_key_just_pressed 89 
jf @VIDPOK_15072 
" + tmp_POKER_Text_Color_B + @"(" + POKER_Counter + @",6i) += 1 
0663: printint ""BLUE"" " + tmp_POKER_Text_Color_B + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15072
if 
0736:   is_keyboard_key_just_pressed 72 
jf @VIDPOK_15113 
" + tmp_POKER_Text_Color_B + @"(" + POKER_Counter + @",6i) += -1 
0663: printint ""BLUE"" " + tmp_POKER_Text_Color_B + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15113
if 
0736:   is_keyboard_key_just_pressed 85 
jf @VIDPOK_15153 
" + tmp_POKER_Text_Edge_R + @"(" + POKER_Counter + @",6i) += 1 
0663: printint ""RED"" " + tmp_POKER_Text_Edge_R + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15153
if 
0736:   is_keyboard_key_just_pressed 74 
jf @VIDPOK_15193 
" + tmp_POKER_Text_Edge_R + @"(" + POKER_Counter + @",6i) += -1 
0663: printint ""RED"" " + tmp_POKER_Text_Edge_R + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15193
if 
0736:   is_keyboard_key_just_pressed 73 
jf @VIDPOK_15235 
" + tmp_POKER_Text_Edge_G + @"(" + POKER_Counter + @",6i) += 1 
0663: printint ""GREEN"" " + tmp_POKER_Text_Edge_G + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15235
if 
0736:   is_keyboard_key_just_pressed 75 
jf @VIDPOK_15277 
" + tmp_POKER_Text_Edge_G + @"(" + POKER_Counter + @",6i) += -1 
0663: printint ""GREEN"" " + tmp_POKER_Text_Edge_G + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15277
if 
0736:   is_keyboard_key_just_pressed 79 
jf @VIDPOK_15318 
" + tmp_POKER_Text_Edge_B + @"(" + POKER_Counter + @",6i) += 1 
0663: printint ""BLUE"" " + tmp_POKER_Text_Edge_B + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15318
if 
0736:   is_keyboard_key_just_pressed 76 
jf @VIDPOK_15359 
" + tmp_POKER_Text_Edge_B + @"(" + POKER_Counter + @",6i) += -1 
0663: printint ""BLUE"" " + tmp_POKER_Text_Edge_B + @"(" + POKER_Counter + @",6i) 

:VIDPOK_15359
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_15386 
" + tmp_POKER_Text_Edge + @"(" + POKER_Counter + @",6i) += 1 

:VIDPOK_15386
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_15413 
" + tmp_POKER_Text_Edge + @"(" + POKER_Counter + @",6i) += -1 

:VIDPOK_15413
if 
0736:   is_keyboard_key_just_pressed 136 
jf @VIDPOK_15473 
" + tmp_POKER_Text_Font + @"(" + POKER_Counter + @",6i) += 1 
if 
  " + tmp_POKER_Text_Font + @"(" + POKER_Counter + @",6i) > 3 
jf @VIDPOK_15473 
" + tmp_POKER_Text_Font + @"(" + POKER_Counter + @",6i) = 0 

:VIDPOK_15473
if 
0736:   is_keyboard_key_just_pressed 135 
jf @VIDPOK_15533 
" + tmp_POKER_Text_Font + @"(" + POKER_Counter + @",6i) += -1 
if 
  0 > " + tmp_POKER_Text_Font + @"(" + POKER_Counter + @",6i) 
jf @VIDPOK_15533 
" + tmp_POKER_Text_Font + @"(" + POKER_Counter + @",6i) = 3 

:VIDPOK_15533
if 
0736:   is_keyboard_key_just_pressed 133 
jf @VIDPOK_15600 
if 
  " + tmp_POKER_Text_Centre + @"(" + POKER_Counter + @",6i) == 0 
jf @VIDPOK_15589 
" + tmp_POKER_Text_Centre + @"(" + POKER_Counter + @",6i) = 1 
jump @VIDPOK_15600 

:VIDPOK_15589
" + tmp_POKER_Text_Centre + @"(" + POKER_Counter + @",6i) = 0 

:VIDPOK_15600
if 
  " + _8906 + @" == 10 
jf @VIDPOK_15788 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_15644 
" + POKER_Tile_Height + @" += -1.0 

:VIDPOK_15644
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_15670 
" + POKER_Tile_Height + @" += 1.0 

:VIDPOK_15670
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_15696 
" + POKER_Tile_Width + @" += 1.0 

:VIDPOK_15696
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_15722 
" + POKER_Tile_Width + @" += -1.0 

:VIDPOK_15722
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_15788 
" + POKER_Tile_Type + @" += 1 
if 
  " + POKER_Tile_Type + @" > 3 
jf @VIDPOK_15769 
" + POKER_Tile_Type + @" = 0 

:VIDPOK_15769
0663: printint ""VP_TILE_TYPE"" " + POKER_Tile_Type + @" 

:VIDPOK_15788
if 
  " + _8906 + @" == 11 
jf @VIDPOK_16014 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_15832 
" + POKER_Table_Y + @" += -1.0 

:VIDPOK_15832
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_15858 
" + POKER_Table_Y + @" += 1.0 

:VIDPOK_15858
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_15884 
" + POKER_Table_X + @" += 1.0 

:VIDPOK_15884
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_15910 
" + POKER_Table_X + @" += -1.0 

:VIDPOK_15910
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_15936 
" + POKER_Table_Height + @" += 1.0 

:VIDPOK_15936
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_15962 
" + POKER_Table_Height + @" += -1.0 

:VIDPOK_15962
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_15988 
" + POKER_Table_Width + @" += 1.0 

:VIDPOK_15988
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_16014 
" + POKER_Table_Width + @" += -1.0 

:VIDPOK_16014
if 
  " + _8906 + @" == 12 
jf @VIDPOK_16338 
if 
0736:   is_keyboard_key_just_pressed 97 
jf @VIDPOK_16098 
" + POKER_Counter + @" += 1 
if 
  " + POKER_Counter + @" > 4 
jf @VIDPOK_16079 
" + POKER_Counter + @" = 0 

:VIDPOK_16079
0663: printint ""EDIT_COUNTER"" " + POKER_Counter + @" 

:VIDPOK_16098
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_16128 
" + tmp_9049 + @"(" + POKER_Counter + @",5f) += -1.0 

:VIDPOK_16128
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_16158 
" + tmp_9049 + @"(" + POKER_Counter + @",5f) += 1.0 

:VIDPOK_16158
if 
0736:   is_keyboard_key_just_pressed 128 
jf @VIDPOK_16188 
" + tmp_9044 + @"(" + POKER_Counter + @",5f) += 1.0 

:VIDPOK_16188
if 
0736:   is_keyboard_key_just_pressed 129 
jf @VIDPOK_16218 
" + tmp_9044 + @"(" + POKER_Counter + @",5f) += -1.0 

:VIDPOK_16218
if 
0736:   is_keyboard_key_just_pressed 145 
jf @VIDPOK_16248 
" + tmp_9059 + @"(" + POKER_Counter + @",5f) += 1.0 

:VIDPOK_16248
if 
0736:   is_keyboard_key_just_pressed 139 
jf @VIDPOK_16278 
" + tmp_9059 + @"(" + POKER_Counter + @",5f) += -1.0 

:VIDPOK_16278
if 
0736:   is_keyboard_key_just_pressed 143 
jf @VIDPOK_16308 
" + tmp_9054 + @"(" + POKER_Counter + @",5f) += 1.0 

:VIDPOK_16308
if 
0736:   is_keyboard_key_just_pressed 141 
jf @VIDPOK_16338 
" + tmp_9054 + @"(" + POKER_Counter + @",5f) += -1.0 

:VIDPOK_16338
if 
  " + _8906 + @" == 13 
jf @VIDPOK_16408 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @VIDPOK_16382 
" + POKER_Button_Text_Offset + @" += 0.05 

:VIDPOK_16382
if 
0736:   is_keyboard_key_just_pressed 130 
jf @VIDPOK_16408 
" + POKER_Button_Text_Offset + @" += -0.05 

:VIDPOK_16408
if 
0736:   is_keyboard_key_just_pressed 137 
jf @VIDPOK_26528 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
12@ = 0 

:VIDPOK_16435
if 
  8 > 12@ 
jf @VIDPOK_17019 
03A9: save_newline_to_debug_file 
05B6: 112 
03A7: save_int_to_debug_file 12@ 
05B6: 113 
03A8: save_float_to_debug_file " + tmp_POKER_X_screen + @"(12@,8f) 
03A9: save_newline_to_debug_file 
05B6: 114 
03A7: save_int_to_debug_file 12@ 
05B6: 115 
03A8: save_float_to_debug_file " + tmp_POKER_Y_screen + @"(12@,8f)  
12@ += 1 
jump @VIDPOK_16435 

:VIDPOK_17019
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
12@ = 0 

:VIDPOK_17030
if 
  5 > 12@ 
jf @VIDPOK_17614 
03A9: save_newline_to_debug_file 
05B6: 116 
03A7: save_int_to_debug_file 12@ 
05B6: 117 
03A8: save_float_to_debug_file " + tmp_POKER_X_Card + @"(12@,5f) 
03A9: save_newline_to_debug_file 
05B6: 118 
03A7: save_int_to_debug_file 12@ 
05B6: 119 
03A8: save_float_to_debug_file " + tmp_POKER_Y_Card + @"(12@,5f) 
12@ += 1 
jump @VIDPOK_17030 

:VIDPOK_17614
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 120 
03A8: save_float_to_debug_file " + POKER_Card_Width + @" 
03A9: save_newline_to_debug_file 
05B6: 121 
03A8: save_float_to_debug_file " + POKER_Card_Height + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
12@ = 0 

:VIDPOK_17903
if 
  10 > 12@ 
jf @VIDPOK_18211 
03A9: save_newline_to_debug_file 
05B6: 122 
03A7: save_int_to_debug_file 12@ 
05B6: 123 
03A8: save_float_to_debug_file " + tmp_POKER_Y_Row + @"(12@,10f) 
12@ += 1 
jump @VIDPOK_17903 

:VIDPOK_18211
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
12@ = 0 

:VIDPOK_18222
if 
  6 > 12@ 
jf @VIDPOK_18530 
03A9: save_newline_to_debug_file 
05B6: 124 
03A7: save_int_to_debug_file 12@ 
05B6: 125 
03A8: save_float_to_debug_file " + tmp_POKER_X_Col + @"(12@,6f) 
12@ += 1 
jump @VIDPOK_18222 

:VIDPOK_18530
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 126 
03A8: save_float_to_debug_file " + POKER_Hold_Button_Offset + @" 
03A9: save_newline_to_debug_file 
05B6: 127 
03A8: save_float_to_debug_file " + POKER_Hold_Width + @" 
03A9: save_newline_to_debug_file 
05B6: 128 
03A8: save_float_to_debug_file " + POKER_Hold_Height + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 129 
03A8: save_float_to_debug_file " + POKER_X_Bet_One + @" 
03A9: save_newline_to_debug_file 
05B6: 130 
03A8: save_float_to_debug_file " + POKER_Y_Bet_One + @" 
03A9: save_newline_to_debug_file 
05B6: 131 
03A8: save_float_to_debug_file " + POKER_Bet_One_Width + @" 
03A9: save_newline_to_debug_file 
05B6: 132 
03A8: save_float_to_debug_file " + POKER_Bet_One_Height + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 133 
03A8: save_float_to_debug_file " + POKER_X_Deal + @" 
03A9: save_newline_to_debug_file 
05B6: 134 
03A8: save_float_to_debug_file " + POKER_Y_Deal + @" 
03A9: save_newline_to_debug_file 
05B6: 135 
03A8: save_float_to_debug_file " + POKER_Deal_Width + @" 
03A9: save_newline_to_debug_file 
05B6: 136 
03A8: save_float_to_debug_file " + POKER_Deal_Height + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 137 
03A8: save_float_to_debug_file " + POKER_Border_Thickness + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
12@ = 0 

:VIDPOK_20201
if 
  9 > 12@ 
jf @VIDPOK_21337 
03A9: save_newline_to_debug_file 
05B6: 138 
03A7: save_int_to_debug_file 12@ 
05B6: 139 
03A8: save_float_to_debug_file " + tmp_POKER_X_Line + @"(12@,9f) 
03A9: save_newline_to_debug_file 
05B6: 140 
03A7: save_int_to_debug_file 12@ 
05B6: 141 
03A8: save_float_to_debug_file " + tmp_POKER_Y_Line + @"(12@,9f) 
03A9: save_newline_to_debug_file 
05B6: 142 
03A7: save_int_to_debug_file 12@ 
05B6: 143 
03A8: save_float_to_debug_file " + tmp_POKER_Line_Width + @"(12@,9f) 
03A9: save_newline_to_debug_file 
05B6: 144 
03A7: save_int_to_debug_file 12@ 
05B6: 145 
03A8: save_float_to_debug_file " + tmp_POKER_Line_Height + @"(12@,9f) 
12@ += 1 
jump @VIDPOK_20201 

:VIDPOK_21337
12@ = 0 

:VIDPOK_21344
if 
  6 > 12@ 
jf @VIDPOK_24412 
03A9: save_newline_to_debug_file 
05B6: 146 
03A7: save_int_to_debug_file 12@ 
05B6: 147 
03A8: save_float_to_debug_file " + tmp_POKER_X_Text_Scale + @"(12@,6f) 
03A9: save_newline_to_debug_file 
05B6: 148 
03A7: save_int_to_debug_file 12@ 
05B6: 149 
03A8: save_float_to_debug_file " + tmp_POKER_Y_Text_Scale + @"(12@,6f) 
03A9: save_newline_to_debug_file 
05B6: 150 
03A7: save_int_to_debug_file 12@ 
05B6: 151 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Color_R + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 152 
03A7: save_int_to_debug_file 12@ 
05B6: 153 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Color_G + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 154 
03A7: save_int_to_debug_file 12@ 
05B6: 155 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Color_B + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 156 
03A7: save_int_to_debug_file 12@ 
05B6: 157 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Font + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 158 
03A7: save_int_to_debug_file 12@ 
05B6: 159 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Centre + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 160 
03A7: save_int_to_debug_file 12@ 
05B6: 161 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Edge + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 162 
03A7: save_int_to_debug_file 12@ 
05B6: 163 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Edge_R + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 164 
03A7: save_int_to_debug_file 12@ 
05B6: 165 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Edge_G + @"(12@,6i) 
03A9: save_newline_to_debug_file 
05B6: 166 
03A7: save_int_to_debug_file 12@ 
05B6: 167 
03A7: save_int_to_debug_file " + tmp_POKER_Text_Edge_B + @"(12@,6i) 
12@ += 1 
jump @VIDPOK_21344 

:VIDPOK_24412
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 168 
03A8: save_float_to_debug_file " + POKER_Tile_Height + @" 
03A9: save_newline_to_debug_file 
05B6: 169 
03A8: save_float_to_debug_file " + POKER_Tile_Width + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 170 
03A8: save_float_to_debug_file " + POKER_Table_X + @" 
03A9: save_newline_to_debug_file 
05B6: 171 
03A8: save_float_to_debug_file " + POKER_Table_Y + @" 
03A9: save_newline_to_debug_file 
05B6: 172 
03A8: save_float_to_debug_file " + POKER_Table_Width + @" 
03A9: save_newline_to_debug_file 
05B6: 173 
03A8: save_float_to_debug_file " + POKER_Table_Height + @" 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
12@ = 0 

:VIDPOK_25253
if 
  5 > 12@ 
jf @VIDPOK_26389 
03A9: save_newline_to_debug_file 
05B6: 174 
03A7: save_int_to_debug_file 12@ 
05B6: 175 
03A8: save_float_to_debug_file " + tmp_9044 + @"(12@,5f) 
03A9: save_newline_to_debug_file 
05B6: 176 
03A7: save_int_to_debug_file 12@ 
05B6: 177 
03A8: save_float_to_debug_file " + tmp_9049 + @"(12@,5f) 
03A9: save_newline_to_debug_file 
05B6: 178 
03A7: save_int_to_debug_file 12@ 
05B6: 179 
03A8: save_float_to_debug_file " + tmp_9054 + @"(12@,5f) 
03A9: save_newline_to_debug_file 
05B6: 180 
03A7: save_int_to_debug_file 12@ 
05B6: 181 
03A8: save_float_to_debug_file " + tmp_9059 + @"(12@,5f) 
12@ += 1 
jump @VIDPOK_25253 

:VIDPOK_26389
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 182 
03A8: save_float_to_debug_file " + POKER_Button_Text_Offset + @" 

:VIDPOK_26528
return 

:VIDPOK_26530
if 
  " + _9066 + @" == 0 
jf @VIDPOK_26596 
" + _9065 + @" += 10 
if 
  " + _9065 + @" >= 255 
jf @VIDPOK_26589 
" + _9065 + @" = 255 
" + _9066 + @" = 1 

:VIDPOK_26589
jump @VIDPOK_26635 

:VIDPOK_26596
" + _9065 + @" += -10 
if 
  0 >= " + _9065 + @" 
jf @VIDPOK_26635 
" + _9065 + @" = 0 
" + _9066 + @" = 0 

:VIDPOK_26635
if 
   not " + POKER_Tile_Type + @" == 0 
jf @VIDPOK_26906 
12@ = 0 
0086: " + tempvar_Float_1 + @" = " + POKER_Tile_Width + @" 
" + tempvar_Float_1 + @" /= 2.0 
0086: " + tempvar_Float_2 + @" = " + POKER_Tile_Height + @" 
" + tempvar_Float_2 + @" /= 2.0 

:VIDPOK_26696
if and
  480.0 > " + tempvar_Float_2 + @" 
  100 > 12@ 
jf @VIDPOK_26899 

:VIDPOK_26724
if and
  640.0 > " + tempvar_Float_1 + @" 
  100 > 12@ 
jf @VIDPOK_26866 
if 
  " + POKER_Tile_Type + @" == 1 
jf @VIDPOK_26798 
038D: draw_texture 64 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Tile_Width + @" " + POKER_Tile_Height + @" RGBA 150 150 150 255 

:VIDPOK_26798
if 
  " + POKER_Tile_Type + @" == 2 
jf @VIDPOK_26844 
038D: draw_texture 65 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Tile_Width + @" " + POKER_Tile_Height + @" RGBA 150 150 150 255 

:VIDPOK_26844
12@ += 1 
0059: " + tempvar_Float_1 + @" += " + POKER_Tile_Width + @" 
jump @VIDPOK_26724 

:VIDPOK_26866
0059: " + tempvar_Float_2 + @" += " + POKER_Tile_Height + @" 
0086: " + tempvar_Float_1 + @" = " + POKER_Tile_Width + @" 
" + tempvar_Float_1 + @" /= 2.0 
jump @VIDPOK_26696 

:VIDPOK_26899
jump @VIDPOK_26938 

:VIDPOK_26906
038E: draw_box_position 320.0 240.0 size 640.0 480.0 RGBA 6 16 140 255 

:VIDPOK_26938
038D: draw_texture 63 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 63 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
038D: draw_texture 63 position 480.0 336.0 size -320.0 -224.0 RGBA 150 150 150 255 
038D: draw_texture 63 position 160.0 336.0 size 320.0 -224.0 RGBA 150 150 150 255 
gosub @VIDPOK_33829 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
033E: set_draw_text_position " + tmp_POKER_X_screen + @"[0] " + tmp_POKER_Y_screen + @"[0] GXT 'VP02'  
gosub @VIDPOK_33637 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
045A: draw_text_1number " + tmp_POKER_X_screen + @"[6] " + tmp_POKER_Y_screen + @"[6] GXT 'DOLLAR' number 1@  
12@ = Player.Money(" + PlayerChar + @")
gosub @VIDPOK_34875 
gosub @VIDPOK_33637 
03E4: set_text_draw_align_right 1 
008B: 13@ = " + Max_Wager + @" 
13@ *= -1 
if 
002D:   13@ >= 12@ 
jf @VIDPOK_27233 
033E: set_draw_text_position " + tmp_POKER_X_screen + @"[1] " + tmp_POKER_Y_screen + @"[1] GXT 'VP18'  
jump @VIDPOK_27253 

:VIDPOK_27233
045A: draw_text_1number " + tmp_POKER_X_screen + @"[1] " + tmp_POKER_Y_screen + @"[1] GXT 'VP16' number 12@  

:VIDPOK_27253
gosub @VIDPOK_33829 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
008B: 12@ = " + _8826 + @" 
006A: 12@ *= 1@ 
033E: set_draw_text_position " + tmp_POKER_X_screen + @"[2] " + tmp_POKER_Y_screen + @"[2] GXT 'VP03'  
gosub @VIDPOK_33637 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
045A: draw_text_1number " + tmp_POKER_X_screen + @"[7] " + tmp_POKER_Y_screen + @"[7] GXT 'DOLLAR' number 12@  
gosub @VIDPOK_34213 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 320.0 " + tmp_POKER_Y_screen + @"[4] GXT 'VP17'  
038E: draw_box_position " + POKER_Table_X + @" " + POKER_Table_Y + @" size " + POKER_Table_Width + @" " + POKER_Table_Height + @" RGBA 0 0 0 255 
if 
   not 3@ == 6 
jf @VIDPOK_27635 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_27635 jumps 1 @VIDPOK_27470 2 @VIDPOK_27503 3 @VIDPOK_27536 4 @VIDPOK_27569 5 @VIDPOK_27602 -1 @VIDPOK_27635 -1 @VIDPOK_27635 

:VIDPOK_27470
038E: draw_box_position " + tmp_9044 + @"[0] " + tmp_9049 + @"[0] size " + tmp_9054 + @"[0] " + tmp_9059 + @"[0] RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
jump @VIDPOK_27635 

:VIDPOK_27503
038E: draw_box_position " + tmp_9044 + @"[1] " + tmp_9049 + @"[1] size " + tmp_9054 + @"[1] " + tmp_9059 + @"[1] RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
jump @VIDPOK_27635 

:VIDPOK_27536
038E: draw_box_position " + tmp_9044 + @"[2] " + tmp_9049 + @"[2] size " + tmp_9054 + @"[2] " + tmp_9059 + @"[2] RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
jump @VIDPOK_27635 

:VIDPOK_27569
038E: draw_box_position " + tmp_9044 + @"[3] " + tmp_9049 + @"[3] size " + tmp_9054 + @"[3] " + tmp_9059 + @"[3] RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
jump @VIDPOK_27635 

:VIDPOK_27602
038E: draw_box_position " + tmp_9044 + @"[4] " + tmp_9049 + @"[4] size " + tmp_9054 + @"[4] " + tmp_9059 + @"[4] RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
jump @VIDPOK_27635 

:VIDPOK_27635
if and
  3@ == 6 
   not " + _8866 + @" == 0 
jf @VIDPOK_27972 
12@ = 10 
0064: 12@ -= " + _8866 + @" 
0089: 15@ = " + tmp_POKER_Y_Row + @"(12@,10f) 
15@ += 9.0 
0871: init_jump_table " + _8826 + @" total_jumps 5 default_jump 0 @VIDPOK_27930 jumps 1 @VIDPOK_27760 2 @VIDPOK_27794 3 @VIDPOK_27828 4 @VIDPOK_27862 5 @VIDPOK_27896 -1 @VIDPOK_27930 -1 @VIDPOK_27930 

:VIDPOK_27760
038E: draw_box_position " + tmp_9044 + @"[0] 15@ size " + tmp_9054 + @"[0] 18.0 RGBA 255 " + _9065 + @" 0 255 
jump @VIDPOK_27930 

:VIDPOK_27794
038E: draw_box_position " + tmp_9044 + @"[1] 15@ size " + tmp_9054 + @"[1] 18.0 RGBA 255 " + _9065 + @" 0 255 
jump @VIDPOK_27930 

:VIDPOK_27828
038E: draw_box_position " + tmp_9044 + @"[2] 15@ size " + tmp_9054 + @"[2] 18.0 RGBA 255 " + _9065 + @" 0 255 
jump @VIDPOK_27930 

:VIDPOK_27862
038E: draw_box_position " + tmp_9044 + @"[3] 15@ size " + tmp_9054 + @"[3] 18.0 RGBA 255 " + _9065 + @" 0 255 
jump @VIDPOK_27930 

:VIDPOK_27896
038E: draw_box_position " + tmp_9044 + @"[4] 15@ size " + tmp_9054 + @"[4] 18.0 RGBA 255 " + _9065 + @" 0 255 
jump @VIDPOK_27930 

:VIDPOK_27930
gosub @VIDPOK_33637 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
045A: draw_text_1number " + tmp_POKER_X_screen + @"[3] " + tmp_POKER_Y_screen + @"[3] GXT 'VP04' number 14@  
jump @VIDPOK_28039 

:VIDPOK_27972
if and
  3@ == 6 
  " + _8866 + @" == 0 
jf @VIDPOK_28039 
14@ = 0 
gosub @VIDPOK_33637 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
045A: draw_text_1number " + tmp_POKER_X_screen + @"[3] " + tmp_POKER_Y_screen + @"[3] GXT 'VP04' number 14@  

:VIDPOK_28039
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[1] GXT 'VP06'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[2] GXT 'VP07'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[3] GXT 'VP08'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[4] GXT 'VP09'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[5] GXT 'VP10'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[6] GXT 'VP11'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[7] GXT 'VP12'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[8] GXT 'VP13'  
gosub @VIDPOK_34021 
033E: set_draw_text_position " + tmp_POKER_X_Col + @"[0] " + tmp_POKER_Y_Row + @"[9] GXT 'VP14'  
gosub @VIDPOK_34213 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position " + tmp_POKER_X_screen + @"[5] " + tmp_POKER_Y_screen + @"[5] GXT 'VP05'  
gosub @VIDPOK_34213 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[0] GXT 'VP15' number 1  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[1] GXT 'VP15' number 250  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[2] GXT 'VP15' number 50  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[3] GXT 'VP15' number 25  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[4] GXT 'VP15' number 9  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[5] GXT 'VP15' number 6  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[6] GXT 'VP15' number 4  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[7] GXT 'VP15' number 3  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[8] GXT 'VP15' number 2  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[1] " + tmp_POKER_Y_Row + @"[9] GXT 'VP15' number 1  
gosub @VIDPOK_34213 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[0] GXT 'VP15' number 2  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[1] GXT 'VP15' number 500  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[2] GXT 'VP15' number 100  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[3] GXT 'VP15' number 50  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[4] GXT 'VP15' number 18  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[5] GXT 'VP15' number 12  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[6] GXT 'VP15' number 8  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[7] GXT 'VP15' number 6  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[8] GXT 'VP15' number 4  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[2] " + tmp_POKER_Y_Row + @"[9] GXT 'VP15' number 2  
gosub @VIDPOK_34213 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[0] GXT 'VP15' number 3  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[1] GXT 'VP15' number 750  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[2] GXT 'VP15' number 150  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[3] GXT 'VP15' number 75  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[4] GXT 'VP15' number 27  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[5] GXT 'VP15' number 18  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[6] GXT 'VP15' number 12  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[7] GXT 'VP15' number 9  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[8] GXT 'VP15' number 6  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[3] " + tmp_POKER_Y_Row + @"[9] GXT 'VP15' number 3  
gosub @VIDPOK_34213 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[0] GXT 'VP15' number 4  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[1] GXT 'VP15' number 1000  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[2] GXT 'VP15' number 200  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[3] GXT 'VP15' number 100  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[4] GXT 'VP15' number 36  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[5] GXT 'VP15' number 24  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[6] GXT 'VP15' number 16  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[7] GXT 'VP15' number 12  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[8] GXT 'VP15' number 8  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[4] " + tmp_POKER_Y_Row + @"[9] GXT 'VP15' number 4  
gosub @VIDPOK_34213 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[0] GXT 'VP15' number 5  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[1] GXT 'VP15' number 4000  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[2] GXT 'VP15' number 250  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[3] GXT 'VP15' number 125  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[4] GXT 'VP15' number 45  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[5] GXT 'VP15' number 30  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[6] GXT 'VP15' number 20  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[7] GXT 'VP15' number 15  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[8] GXT 'VP15' number 10  
gosub @VIDPOK_34405 
03E4: set_text_draw_align_right 1 
045A: draw_text_1number " + tmp_POKER_X_Col + @"[5] " + tmp_POKER_Y_Row + @"[9] GXT 'VP15' number 5  
038E: draw_box_position " + tmp_POKER_X_Line + @"[0] " + tmp_POKER_Y_Line + @"[0] size " + tmp_POKER_Line_Width + @"[0] " + tmp_POKER_Line_Height + @"[0] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[1] " + tmp_POKER_Y_Line + @"[1] size " + tmp_POKER_Line_Width + @"[1] " + tmp_POKER_Line_Height + @"[1] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[2] " + tmp_POKER_Y_Line + @"[2] size " + tmp_POKER_Line_Width + @"[2] " + tmp_POKER_Line_Height + @"[2] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[3] " + tmp_POKER_Y_Line + @"[3] size " + tmp_POKER_Line_Width + @"[3] " + tmp_POKER_Line_Height + @"[3] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[4] " + tmp_POKER_Y_Line + @"[4] size " + tmp_POKER_Line_Width + @"[4] " + tmp_POKER_Line_Height + @"[4] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[5] " + tmp_POKER_Y_Line + @"[5] size " + tmp_POKER_Line_Width + @"[5] " + tmp_POKER_Line_Height + @"[5] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[6] " + tmp_POKER_Y_Line + @"[6] size " + tmp_POKER_Line_Width + @"[6] " + tmp_POKER_Line_Height + @"[6] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[7] " + tmp_POKER_Y_Line + @"[7] size " + tmp_POKER_Line_Width + @"[7] " + tmp_POKER_Line_Height + @"[7] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
038E: draw_box_position " + tmp_POKER_X_Line + @"[8] " + tmp_POKER_Y_Line + @"[8] size " + tmp_POKER_Line_Width + @"[8] " + tmp_POKER_Line_Height + @"[8] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
" + _9064 + @" = 0 

:VIDPOK_30112
if 
  5 > " + _9064 + @" 
jf @VIDPOK_31298 
if 
  " + tmp_8827 + @"(" + _9064 + @",5i) == 0 
jf @VIDPOK_30195 
038D: draw_texture 53 position " + tmp_POKER_X_Card + @"(" + _9064 + @",5f) " + tmp_POKER_Y_Card + @"(" + _9064 + @",5f) size " + POKER_Card_Width + @" " + POKER_Card_Height + @" RGBA 128 128 128 255 
jump @VIDPOK_30236 

:VIDPOK_30195
038D: draw_texture " + tmp_8827 + @"(" + _9064 + @",5i) position " + tmp_POKER_X_Card + @"(" + _9064 + @",5f) " + tmp_POKER_Y_Card + @"(" + _9064 + @",5f) size " + POKER_Card_Width + @" " + POKER_Card_Height + @" RGBA 128 128 128 255 

:VIDPOK_30236
0086: " + tempvar_Float_1 + @" = " + tmp_POKER_X_Card + @"(" + _9064 + @",5f) 
0086: " + tempvar_Float_2 + @" = " + tmp_POKER_Y_Card + @"(" + _9064 + @",5f) 
0059: " + tempvar_Float_2 + @" += " + POKER_Hold_Button_Offset + @" 
if 
  " + tmp_8837 + @"(" + _9064 + @",5i) == 0 
jf @VIDPOK_30447 
0086: " + _8930 + @" = " + POKER_Hold_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Hold_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 128 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Hold_Width + @" " + POKER_Hold_Height + @" RGBA 128 128 128 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 128 128 128 255 
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA 0 0 0 128 
0089: 15@ = " + POKER_Hold_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" GXT 'VP19'  

:VIDPOK_30447
if 
  " + tmp_8837 + @"(" + _9064 + @",5i) == 1 
jf @VIDPOK_30628 
0086: " + _8930 + @" = " + POKER_Hold_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Hold_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 128 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Hold_Width + @" " + POKER_Hold_Height + @" RGBA 128 128 128 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 128 128 128 255 
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA 0 0 0 128 
0089: 15@ = " + POKER_Hold_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" GXT 'VP19'  

:VIDPOK_30628
if 
  " + tmp_8837 + @"(" + _9064 + @",5i) == 2 
jf @VIDPOK_30789 
0086: " + _8930 + @" = " + POKER_Hold_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Hold_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 255 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Hold_Width + @" " + POKER_Hold_Height + @" RGBA 0 128 0 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 0 255 0 255 
0089: 15@ = " + POKER_Hold_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" GXT 'VP19'  

:VIDPOK_30789
if 
  " + tmp_8837 + @"(" + _9064 + @",5i) == 3 
jf @VIDPOK_30954 
0086: " + _8930 + @" = " + POKER_Hold_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Hold_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 255 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Hold_Width + @" " + POKER_Hold_Height + @" RGBA 0 128 0 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + _9065 + @" " + tmp_POKER_Text_Color_B + @"[5] 255 
0089: 15@ = " + POKER_Hold_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" GXT 'VP19'  

:VIDPOK_30954
if 
  " + tmp_8837 + @"(" + _9064 + @",5i) == 4 
jf @VIDPOK_31117 
0086: " + _8930 + @" = " + POKER_Hold_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Hold_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 255 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Hold_Width + @" " + POKER_Hold_Height + @" RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 255 0 0 255 
0089: 15@ = " + POKER_Hold_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" GXT 'VP19'  

:VIDPOK_31117
if 
  " + tmp_8837 + @"(" + _9064 + @",5i) == 5 
jf @VIDPOK_31284 
0086: " + _8930 + @" = " + POKER_Hold_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Hold_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 255 
038E: draw_box_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + POKER_Hold_Width + @" " + POKER_Hold_Height + @" RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + _9065 + @" " + tmp_POKER_Text_Color_B + @"[5] 255 
0089: 15@ = " + POKER_Hold_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" GXT 'VP19'  

:VIDPOK_31284
" + _9064 + @" += 1 
jump @VIDPOK_30112 

:VIDPOK_31298
if 
  " + _8842 + @" == 0 
jf @VIDPOK_31481 
0086: " + _8930 + @" = " + POKER_Bet_One_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Bet_One_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 128 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + POKER_Bet_One_Width + @" " + POKER_Bet_One_Height + @" RGBA 128 128 128 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 128 128 128 255 
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA 0 0 0 128 
0089: 15@ = " + POKER_Bet_One_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Bet_One + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Bet_One + @" " + tempvar_Float_2 + @" GXT 'VP20'  

:VIDPOK_31481
if 
  " + _8842 + @" == 1 
jf @VIDPOK_31666 
0086: " + _8930 + @" = " + POKER_Bet_One_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Bet_One_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 128 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + POKER_Bet_One_Width + @" " + POKER_Bet_One_Height + @" RGBA 128 128 128 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 128 128 128 255 
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA 0 0 0 128 
0089: 15@ = " + POKER_Bet_One_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Bet_One + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Bet_One + @" " + tempvar_Float_2 + @" GXT 'VP20'  

:VIDPOK_31666
if 
  " + _8842 + @" == 2 
jf @VIDPOK_31831 
0086: " + _8930 + @" = " + POKER_Bet_One_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Bet_One_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 255 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + POKER_Bet_One_Width + @" " + POKER_Bet_One_Height + @" RGBA 0 128 0 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 0 255 0 255 
0089: 15@ = " + POKER_Bet_One_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Bet_One + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Bet_One + @" " + tempvar_Float_2 + @" GXT 'VP20'  

:VIDPOK_31831
if 
  " + _8842 + @" == 3 
jf @VIDPOK_32000 
0086: " + _8930 + @" = " + POKER_Bet_One_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Bet_One_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 255 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + POKER_Bet_One_Width + @" " + POKER_Bet_One_Height + @" RGBA 0 128 0 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + _9065 + @" " + tmp_POKER_Text_Color_B + @"[5] 255 
0089: 15@ = " + POKER_Bet_One_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Bet_One + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Bet_One + @" " + tempvar_Float_2 + @" GXT 'VP20'  

:VIDPOK_32000
if 
  " + _8842 + @" == 4 
jf @VIDPOK_32167 
0086: " + _8930 + @" = " + POKER_Bet_One_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Bet_One_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 255 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + POKER_Bet_One_Width + @" " + POKER_Bet_One_Height + @" RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 255 0 0 255 
0089: 15@ = " + POKER_Bet_One_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Bet_One + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Bet_One + @" " + tempvar_Float_2 + @" GXT 'VP20'  

:VIDPOK_32167
if 
  " + _8842 + @" == 5 
jf @VIDPOK_32338 
0086: " + _8930 + @" = " + POKER_Bet_One_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Bet_One_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 255 
038E: draw_box_position " + POKER_X_Bet_One + @" " + POKER_Y_Bet_One + @" size " + POKER_Bet_One_Width + @" " + POKER_Bet_One_Height + @" RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + _9065 + @" " + tmp_POKER_Text_Color_B + @"[5] 255 
0089: 15@ = " + POKER_Bet_One_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Bet_One + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Bet_One + @" " + tempvar_Float_2 + @" GXT 'VP20'  

:VIDPOK_32338
if 
  " + _8843 + @" == 0 
jf @VIDPOK_32521 
0086: " + _8930 + @" = " + POKER_Deal_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Deal_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 128 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + POKER_Deal_Width + @" " + POKER_Deal_Height + @" RGBA 128 128 128 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 128 128 128 255 
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA 0 0 0 128 
0089: 15@ = " + POKER_Deal_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Deal + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Deal + @" " + tempvar_Float_2 + @" GXT 'VP21'  

:VIDPOK_32521
if 
  " + _8843 + @" == 1 
jf @VIDPOK_32706 
0086: " + _8930 + @" = " + POKER_Deal_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Deal_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 128 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + POKER_Deal_Width + @" " + POKER_Deal_Height + @" RGBA 128 128 128 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 128 128 128 255 
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA 0 0 0 128 
0089: 15@ = " + POKER_Deal_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Deal + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Deal + @" " + tempvar_Float_2 + @" GXT 'VP21'  

:VIDPOK_32706
if 
  " + _8843 + @" == 2 
jf @VIDPOK_32871 
0086: " + _8930 + @" = " + POKER_Deal_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Deal_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 255 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + POKER_Deal_Width + @" " + POKER_Deal_Height + @" RGBA 0 128 0 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 0 255 0 255 
0089: 15@ = " + POKER_Deal_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Deal + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Deal + @" " + tempvar_Float_2 + @" GXT 'VP21'  

:VIDPOK_32871
if 
  " + _8843 + @" == 3 
jf @VIDPOK_33040 
0086: " + _8930 + @" = " + POKER_Deal_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Deal_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 255 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + POKER_Deal_Width + @" " + POKER_Deal_Height + @" RGBA 0 128 0 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + _9065 + @" " + tmp_POKER_Text_Color_B + @"[5] 255 
0089: 15@ = " + POKER_Deal_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Deal + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Deal + @" " + tempvar_Float_2 + @" GXT 'VP21'  

:VIDPOK_33040
if 
  " + _8843 + @" == 4 
jf @VIDPOK_33207 
0086: " + _8930 + @" = " + POKER_Deal_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Deal_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + _8930 + @" " + _8931 + @" RGBA 0 0 0 255 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + POKER_Deal_Width + @" " + POKER_Deal_Height + @" RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA 255 0 0 255 
0089: 15@ = " + POKER_Deal_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Deal + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Deal + @" " + tempvar_Float_2 + @" GXT 'VP21'  

:VIDPOK_33207
if 
  " + _8843 + @" == 5 
jf @VIDPOK_33378 
0086: " + _8930 + @" = " + POKER_Deal_Width + @" 
0059: " + _8930 + @" += " + POKER_Border_Thickness + @" 
0086: " + _8931 + @" = " + POKER_Deal_Height + @" 
0059: " + _8931 + @" += " + POKER_Border_Thickness + @" 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + _8930 + @" " + _8931 + @" RGBA 255 " + _9065 + @" 0 255 
038E: draw_box_position " + POKER_X_Deal + @" " + POKER_Y_Deal + @" size " + POKER_Deal_Width + @" " + POKER_Deal_Height + @" RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
gosub @VIDPOK_34597 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + _9065 + @" " + tmp_POKER_Text_Color_B + @"[5] 255 
0089: 15@ = " + POKER_Deal_Height + @" 
0077: 15@ /= " + POKER_Button_Text_Offset + @" 
0086: " + tempvar_Float_2 + @" = " + POKER_Y_Deal + @" 
0067: " + tempvar_Float_2 + @" -= 15@ 
033E: set_draw_text_position " + POKER_X_Deal + @" " + tempvar_Float_2 + @" GXT 'VP21'  

:VIDPOK_33378
return 

:VIDPOK_33380
if and
  27 > " + _9069 + @" 
  " + _9069 + @" > 13 
jf @VIDPOK_33420 
0084: " + _9070 + @" = " + _9069 + @" 
" + _9070 + @" -= 13 

:VIDPOK_33420
if and
  40 > " + _9069 + @" 
  " + _9069 + @" > 26 
jf @VIDPOK_33460 
0084: " + _9070 + @" = " + _9069 + @" 
" + _9070 + @" -= 26 

:VIDPOK_33460
if and
  53 > " + _9069 + @" 
  " + _9069 + @" > 39 
jf @VIDPOK_33500 
0084: " + _9070 + @" = " + _9069 + @" 
" + _9070 + @" -= 39 

:VIDPOK_33500
if 
  13 >= " + _9069 + @" 
jf @VIDPOK_33526 
0084: " + _9070 + @" = " + _9069 + @" 

:VIDPOK_33526
return 

:VIDPOK_33528
if 
  14 > " + _9069 + @" 
jf @VIDPOK_33560 
" + _9070 + @" = 1 
jump @VIDPOK_33631 

:VIDPOK_33560
if 
  27 > " + _9069 + @" 
jf @VIDPOK_33592 
" + _9070 + @" = 2 
jump @VIDPOK_33631 

:VIDPOK_33592
if 
  40 > " + _9069 + @" 
jf @VIDPOK_33624 
" + _9070 + @" = 3 
jump @VIDPOK_33631 

:VIDPOK_33624
" + _9070 + @" = 4 

:VIDPOK_33631
return 

:VIDPOK_33633
return 

:VIDPOK_33635
return 

:VIDPOK_33637
033F: set_text_draw_letter_size " + tmp_POKER_X_Text_Scale + @"[0] " + tmp_POKER_Y_Text_Scale + @"[0] 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[0] " + tmp_POKER_Text_Color_G + @"[0] " + tmp_POKER_Text_Color_B + @"[0] 255 
if 
  " + tmp_POKER_Text_Centre + @"[0] == 1 
jf @VIDPOK_33681 
0342: set_text_draw_centered 1 

:VIDPOK_33681
0871: init_jump_table " + tmp_POKER_Text_Font + @"[0] total_jumps 4 default_jump 1 @VIDPOK_33788 jumps 0 @VIDPOK_33744 1 @VIDPOK_33755 2 @VIDPOK_33766 3 @VIDPOK_33777 -1 @VIDPOK_33799 -1 @VIDPOK_33799 -1 @VIDPOK_33799 

:VIDPOK_33744
0349: set_text_draw_font 0 
jump @VIDPOK_33799 

:VIDPOK_33755
0349: set_text_draw_font 1 
jump @VIDPOK_33799 

:VIDPOK_33766
0349: set_text_draw_font 2 
jump @VIDPOK_33799 

:VIDPOK_33777
0349: set_text_draw_font 3 
jump @VIDPOK_33799 

:VIDPOK_33788
0349: set_text_draw_font 0 
jump @VIDPOK_33799 

:VIDPOK_33799
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[0] RGBA " + tmp_POKER_Text_Edge_R + @"[0] " + tmp_POKER_Text_Edge_G + @"[0] " + tmp_POKER_Text_Edge_B + @"[0] 255 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:VIDPOK_33829
033F: set_text_draw_letter_size " + tmp_POKER_X_Text_Scale + @"[1] " + tmp_POKER_Y_Text_Scale + @"[1] 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[1] " + tmp_POKER_Text_Color_G + @"[1] " + tmp_POKER_Text_Color_B + @"[1] 255 
if 
  " + tmp_POKER_Text_Centre + @"[1] == 1 
jf @VIDPOK_33873 
0342: set_text_draw_centered 1 

:VIDPOK_33873
0871: init_jump_table " + tmp_POKER_Text_Font + @"[1] total_jumps 4 default_jump 1 @VIDPOK_33980 jumps 0 @VIDPOK_33936 1 @VIDPOK_33947 2 @VIDPOK_33958 3 @VIDPOK_33969 -1 @VIDPOK_33991 -1 @VIDPOK_33991 -1 @VIDPOK_33991 

:VIDPOK_33936
0349: set_text_draw_font 0 
jump @VIDPOK_33991 

:VIDPOK_33947
0349: set_text_draw_font 1 
jump @VIDPOK_33991 

:VIDPOK_33958
0349: set_text_draw_font 2 
jump @VIDPOK_33991 

:VIDPOK_33969
0349: set_text_draw_font 3 
jump @VIDPOK_33991 

:VIDPOK_33980
0349: set_text_draw_font 0 
jump @VIDPOK_33991 

:VIDPOK_33991
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[1] RGBA " + tmp_POKER_Text_Edge_R + @"[1] " + tmp_POKER_Text_Edge_G + @"[1] " + tmp_POKER_Text_Edge_B + @"[1] 255 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:VIDPOK_34021
033F: set_text_draw_letter_size " + tmp_POKER_X_Text_Scale + @"[2] " + tmp_POKER_Y_Text_Scale + @"[2] 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[2] " + tmp_POKER_Text_Color_G + @"[2] " + tmp_POKER_Text_Color_B + @"[2] 255 
if 
  " + tmp_POKER_Text_Centre + @"[2] == 1 
jf @VIDPOK_34065 
0342: set_text_draw_centered 1 

:VIDPOK_34065
0871: init_jump_table " + tmp_POKER_Text_Font + @"[2] total_jumps 4 default_jump 1 @VIDPOK_34172 jumps 0 @VIDPOK_34128 1 @VIDPOK_34139 2 @VIDPOK_34150 3 @VIDPOK_34161 -1 @VIDPOK_34183 -1 @VIDPOK_34183 -1 @VIDPOK_34183 

:VIDPOK_34128
0349: set_text_draw_font 0 
jump @VIDPOK_34183 

:VIDPOK_34139
0349: set_text_draw_font 1 
jump @VIDPOK_34183 

:VIDPOK_34150
0349: set_text_draw_font 2 
jump @VIDPOK_34183 

:VIDPOK_34161
0349: set_text_draw_font 3 
jump @VIDPOK_34183 

:VIDPOK_34172
0349: set_text_draw_font 0 
jump @VIDPOK_34183 

:VIDPOK_34183
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[2] RGBA " + tmp_POKER_Text_Edge_R + @"[2] " + tmp_POKER_Text_Edge_G + @"[2] " + tmp_POKER_Text_Edge_B + @"[2] 255 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:VIDPOK_34213
033F: set_text_draw_letter_size " + tmp_POKER_X_Text_Scale + @"[3] " + tmp_POKER_Y_Text_Scale + @"[3] 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[3] " + tmp_POKER_Text_Color_G + @"[3] " + tmp_POKER_Text_Color_B + @"[3] 255 
if 
  " + tmp_POKER_Text_Centre + @"[3] == 1 
jf @VIDPOK_34257 
0342: set_text_draw_centered 1 

:VIDPOK_34257
0871: init_jump_table " + tmp_POKER_Text_Font + @"[3] total_jumps 4 default_jump 1 @VIDPOK_34364 jumps 0 @VIDPOK_34320 1 @VIDPOK_34331 2 @VIDPOK_34342 3 @VIDPOK_34353 -1 @VIDPOK_34375 -1 @VIDPOK_34375 -1 @VIDPOK_34375 

:VIDPOK_34320
0349: set_text_draw_font 0 
jump @VIDPOK_34375 

:VIDPOK_34331
0349: set_text_draw_font 1 
jump @VIDPOK_34375 

:VIDPOK_34342
0349: set_text_draw_font 2 
jump @VIDPOK_34375 

:VIDPOK_34353
0349: set_text_draw_font 3 
jump @VIDPOK_34375 

:VIDPOK_34364
0349: set_text_draw_font 0 
jump @VIDPOK_34375 

:VIDPOK_34375
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[3] RGBA " + tmp_POKER_Text_Edge_R + @"[3] " + tmp_POKER_Text_Edge_G + @"[3] " + tmp_POKER_Text_Edge_B + @"[3] 255 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:VIDPOK_34405
033F: set_text_draw_letter_size " + tmp_POKER_X_Text_Scale + @"[4] " + tmp_POKER_Y_Text_Scale + @"[4] 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[4] " + tmp_POKER_Text_Color_G + @"[4] " + tmp_POKER_Text_Color_B + @"[4] 255 
if 
  " + tmp_POKER_Text_Centre + @"[4] == 1 
jf @VIDPOK_34449 
0342: set_text_draw_centered 1 

:VIDPOK_34449
0871: init_jump_table " + tmp_POKER_Text_Font + @"[4] total_jumps 4 default_jump 1 @VIDPOK_34556 jumps 0 @VIDPOK_34512 1 @VIDPOK_34523 2 @VIDPOK_34534 3 @VIDPOK_34545 -1 @VIDPOK_34567 -1 @VIDPOK_34567 -1 @VIDPOK_34567 

:VIDPOK_34512
0349: set_text_draw_font 0 
jump @VIDPOK_34567 

:VIDPOK_34523
0349: set_text_draw_font 1 
jump @VIDPOK_34567 

:VIDPOK_34534
0349: set_text_draw_font 2 
jump @VIDPOK_34567 

:VIDPOK_34545
0349: set_text_draw_font 3 
jump @VIDPOK_34567 

:VIDPOK_34556
0349: set_text_draw_font 0 
jump @VIDPOK_34567 

:VIDPOK_34567
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[4] RGBA " + tmp_POKER_Text_Edge_R + @"[4] " + tmp_POKER_Text_Edge_G + @"[4] " + tmp_POKER_Text_Edge_B + @"[4] 255 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:VIDPOK_34597
033F: set_text_draw_letter_size " + tmp_POKER_X_Text_Scale + @"[5] " + tmp_POKER_Y_Text_Scale + @"[5] 
0340: set_text_draw_RGBA " + tmp_POKER_Text_Color_R + @"[5] " + tmp_POKER_Text_Color_G + @"[5] " + tmp_POKER_Text_Color_B + @"[5] 255 
if 
  " + tmp_POKER_Text_Centre + @"[5] == 1 
jf @VIDPOK_34641 
0342: set_text_draw_centered 1 

:VIDPOK_34641
0871: init_jump_table " + tmp_POKER_Text_Font + @"[5] total_jumps 4 default_jump 1 @VIDPOK_34748 jumps 0 @VIDPOK_34704 1 @VIDPOK_34715 2 @VIDPOK_34726 3 @VIDPOK_34737 -1 @VIDPOK_34759 -1 @VIDPOK_34759 -1 @VIDPOK_34759 

:VIDPOK_34704
0349: set_text_draw_font 0 
jump @VIDPOK_34759 

:VIDPOK_34715
0349: set_text_draw_font 1 
jump @VIDPOK_34759 

:VIDPOK_34726
0349: set_text_draw_font 2 
jump @VIDPOK_34759 

:VIDPOK_34737
0349: set_text_draw_font 3 
jump @VIDPOK_34759 

:VIDPOK_34748
0349: set_text_draw_font 0 
jump @VIDPOK_34759 

:VIDPOK_34759
081C: draw_text_outline " + tmp_POKER_Text_Edge + @"[5] RGBA " + tmp_POKER_Text_Edge_R + @"[5] " + tmp_POKER_Text_Edge_G + @"[5] " + tmp_POKER_Text_Edge_B + @"[5] 255 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.54 1.44 
0340: set_text_draw_RGBA 128 148 178 255 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.54 1.44 
0340: set_text_draw_RGBA 128 148 178 255 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:VIDPOK_34875
0653: 15@ = float_stat 81 
if 
  50.0 > 15@ 
jf @VIDPOK_34917 
" + Max_Wager + @" = 100 
jump @VIDPOK_35037 

:VIDPOK_34917
if 
  150.0 > 15@ 
jf @VIDPOK_34953 
" + Max_Wager + @" = 1000 
jump @VIDPOK_35037 

:VIDPOK_34953
if 
  350.0 > 15@ 
jf @VIDPOK_34989 
" + Max_Wager + @" = 10000 
jump @VIDPOK_35037 

:VIDPOK_34989
if 
  1000.0 > 15@ 
jf @VIDPOK_35027 
" + Max_Wager + @" = 100000 
jump @VIDPOK_35037 

:VIDPOK_35027
" + Max_Wager + @" = 1000000 

:VIDPOK_35037
return 

:VIDPOK_35039
09BD: allow_other_threads_to_display_text_boxes 0 
3@ = 0 
4@ = 0 
5@ = 0 
6@ = 0 
7@ = 0" );
                end_thread_named<CASHWIN>();
AppendLine( @"00BE: text_clear_all 
03E6: remove_text_box 
040D: unload_wav 4 
0391: release_textures 
03F0: enable_text_draw 0 
Player.CanMove(" + PlayerChar + @") = True
0826: enable_hud 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
return 
end_thread " );
            }

        }

    }

}