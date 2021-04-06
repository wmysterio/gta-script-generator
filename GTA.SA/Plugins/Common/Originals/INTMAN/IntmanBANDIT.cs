using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BANDIT : External {

            Int tmp_3413 = global( _3413.startIndex ),
                tmp_3431 = global( _3431.startIndex ),
                tmp_3449 = global( _3449.startIndex );

            Actor _local16 = local( 16 );

            public override void START( LabelJump label ) {
                AppendLine( @"4@ = 0 
6@ = 0 
10@ = 0.0 
11@ = 0.0 
12@ = 0.0 
13@ = 0 
0209: 14@ = random_int_in_ranges 0 5 
if 
  14@ == 1 
jf @BANDIT_96 
14@ = 5 

:BANDIT_96
if 
  14@ == 0 
jf @BANDIT_121 
14@ = 1 

:BANDIT_121
if 
  14@ == 2 
jf @BANDIT_146 
14@ = 10 

:BANDIT_146
if 
  14@ == 3 
jf @BANDIT_171 
14@ = 20 

:BANDIT_171
if 
  14@ == 4 
jf @BANDIT_196 
14@ = 50 

:BANDIT_196
if 
  4@ == 1 
jf @BANDIT_253 
0@ = Object.Init(#KB_BANDIT_U, 0.0, 0.0, 0.0)
1@ = Object.Init(#CJ_WHEEL_1, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BANDIT_253
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
03CA:   object 0@ exists 
jf @BANDIT_2859 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @BANDIT_2845 
if 
   Player.Defined(" + PlayerChar + @")
jf @BANDIT_2831 
0871: init_jump_table 4@ total_jumps 7 default_jump 0 @BANDIT_2824 jumps 0 @BANDIT_373 1 @BANDIT_590 2 @BANDIT_792 3 @BANDIT_1356 4 @BANDIT_1595 5 @BANDIT_1943 6 @BANDIT_2549 

:BANDIT_373
15@ = Object.Model(0@)
if 
   Model.Available(15@)
jf @BANDIT_583 
" + tempvar_Angle + @" = Object.Angle(0@)
if 
83CA:   not object 1@ exists 
jf @BANDIT_462 
080A: get_object 0@ spoot 1 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
1@ = Object.Init(#CJ_WHEEL_1, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(1@) = " + tempvar_Angle + @"

:BANDIT_462
if 
83CA:   not object 2@ exists 
jf @BANDIT_519 
080A: get_object 0@ spoot 2 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
2@ = Object.Init(#CJ_WHEEL_02, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(2@) = " + tempvar_Angle + @"

:BANDIT_519
if 
83CA:   not object 3@ exists 
jf @BANDIT_576 
080A: get_object 0@ spoot 3 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
3@ = Object.Init(#CJ_WHEEL_03, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(3@) = " + tempvar_Angle + @"

:BANDIT_576
4@ += 1 

:BANDIT_583
jump @BANDIT_2824 

:BANDIT_590
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 -0.5" );
                _local16.get_of_closest_map_attractor<PEDSLOT>( tempvar_Float_1, tempvar_Float_2, tempvar_Float_3, 1.5, 2325 );
AppendLine( @"if 
  16@ == -1 
jf @BANDIT_785 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @BANDIT_758 
0513: show_text_box_1number 'SLOT_02' number 14@  
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 0 
03CF: load_wav 1814 as 4 
gosub @BANDIT_2873 
4@ += 1 
jump @BANDIT_785 

:BANDIT_758
if 
  13@ == 1 
jf @BANDIT_785 
0391: release_textures 
13@ = 0 

:BANDIT_785
jump @BANDIT_2824 

:BANDIT_792
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 -0.5" );
                _local16.get_of_closest_map_attractor<PEDSLOT>( tempvar_Float_1, tempvar_Float_2, tempvar_Float_3, 1.5, 2325 );
AppendLine( @"if 
  16@ == -1 
jf @BANDIT_1306 
04ED: load_animation ""CASINO"" 
if 
04EE:   animation ""CASINO"" loaded 
jf @BANDIT_1299 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @BANDIT_1256 
0A3E: unknown_get_actor_in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 handle_as 17@ 
if 
  17@ == -1 
jf @BANDIT_1249 
if 
89BE:   not are_text_boxes_locked_to_any_thread 
jf @BANDIT_1249 
gosub @BANDIT_2873 
if 
00E1:   player 0 pressed_key 15 
jf @BANDIT_1249 
008A: " + _3396 + @" = 14@ 
" + _3396 + @" -= 1 
if 
   Player.Money(" + PlayerChar + @") > " + _3396 + @"
jf @BANDIT_1229 
Player.CanMove(" + PlayerChar + @") = False
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 1 
" + tempvar_Angle + @" = Object.Angle(0@)
0804: AS_actor " + PlayerActor + @" walk_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" angle " + tempvar_Angle + @" radius 0.4 animation ""SLOT_PLYR"" IFP_file ""CASINO"" 4.0 LA 0 LX 0 LY 0 LF 0 LT 0 
008A: " + _3396 + @" = 14@ 
" + _3396 + @" *= -1 
Player.Money(" + PlayerChar + @") += " + _3396 + @"
0623: add 14@ to_integer_stat 35 
0091: " + _3401 + @" = integer 14@ to_float 
" + _3401 + @" *= 0.001 
0624: add " + _3401 + @" to_float_stat 81 
03E6: remove_text_box 
09BD: allow_other_threads_to_display_text_boxes 1 
008B: 5@ = " + Current_Time_in_ms2 + @" 
5@ += 750 
4@ += 1 
jump @BANDIT_1249 

:BANDIT_1229
018C: play_sound 1053 at 0.0 0.0 0.0 

:BANDIT_1249
jump @BANDIT_1299 

:BANDIT_1256
if 
  13@ == 1 
jf @BANDIT_1283 
0391: release_textures 
13@ = 0 

:BANDIT_1283
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
4@ = 1 

:BANDIT_1299
jump @BANDIT_1349 

:BANDIT_1306
if 
  13@ == 1 
jf @BANDIT_1333 
0391: release_textures 
13@ = 0 

:BANDIT_1333
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
4@ = 1 

:BANDIT_1349
jump @BANDIT_2824 

:BANDIT_1356
gosub @BANDIT_2873 
if 
001E:   " + Current_Time_in_ms2 + @" > 5@ 
jf @BANDIT_1588 
03CF: load_wav 1814 as 4 
if 
03D0:   wav 4 loaded 
jf @BANDIT_1424 
097A: play_audio_at 0.0 0.0 0.0 event 1087 

:BANDIT_1424
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
03F0: enable_text_draw 1 
if 
  13@ == 0 
jf @BANDIT_1539 
0390: load_txd_dictionary 'LD_SLOT' 
038F: load_texture ""CHERRY"" as 1 
038F: load_texture ""GRAPES"" as 2 
038F: load_texture ""R_69"" as 3 
038F: load_texture ""BELL"" as 4 
038F: load_texture ""BAR1_O"" as 5 
038F: load_texture ""BAR2_O"" as 6 
13@ = 1 

:BANDIT_1539
03CF: load_wav 1814 as 4 
if 
03D0:   wav 4 loaded 
jf @BANDIT_1581 
097A: play_audio_at 0.0 0.0 0.0 event 1089 

:BANDIT_1581
4@ += 1 

:BANDIT_1588
jump @BANDIT_2824 

:BANDIT_1595
0079: 10@ += frame_delta_time * 1.0 
if 
  10@ > 10.0 
jf @BANDIT_1682 
10@ = 10.0 
0209: " + _3396 + @" = random_int_in_ranges 2000 3000 
6@ = 0 
008B: 5@ = " + Current_Time_in_ms2 + @" 
005C: 5@ += " + _3396 + @" 
0687: clear_actor " + PlayerActor + @" task 
4@ += 1 

:BANDIT_1682
0079: 11@ += frame_delta_time * 1.1 
if 
  11@ > 10.0 
jf @BANDIT_1723 
11@ = 10.0 

:BANDIT_1723
0079: 12@ += frame_delta_time * 1.05 
if 
  12@ > 10.0 
jf @BANDIT_1764 
12@ = 10.0 

:BANDIT_1764
" + tempvar_Angle + @" = Object.Angle(0@)
" + _3400 + @" = 0 

:BANDIT_1779
if 
  3 > " + _3400 + @" 
jf @BANDIT_1929 
if 
  10@(" + _3400 + @",3f) > 0.0 
jf @BANDIT_1915 
007B: 7@(" + _3400 + @",3f) += frame_delta_time * 10@(" + _3400 + @",3f) 
if or
  7@(" + _3400 + @",3f) > 360.0 
  7@(" + _3400 + @",3f) == 360.0 
jf @BANDIT_1891 
7@(" + _3400 + @",3f) -= 360.0 

:BANDIT_1891
0453: set_object 1@(" + _3400 + @",3i) XYZ_rotation 7@(" + _3400 + @",3f) 0.0 " + tempvar_Angle + @" 

:BANDIT_1915
" + _3400 + @" += 1 
jump @BANDIT_1779 

:BANDIT_1929
gosub @BANDIT_2873 
jump @BANDIT_2824 

:BANDIT_1943
if 
001E:   " + Current_Time_in_ms2 + @" > 5@ 
jf @BANDIT_2370 
007F: 10@(6@,3f) -= frame_delta_time * 0.3 
if 
  0.6 > 10@(6@,3f) 
jf @BANDIT_2370 
0088: " + _3401 + @" = 7@(6@,3f) 
" + _3401 + @" /= 20.0 
008C: " + _3396 + @" = float " + _3401 + @" to_integer 
" + _3396 + @" *= 20 
008D: " + _3401 + @" = integer " + _3396 + @" to_float 
0088: " + _3402 + @" = 7@(6@,3f) 
0061: " + _3402 + @" -= " + _3401 + @" 
if 
  10.0 > " + _3402 + @" 
jf @BANDIT_2356 
10@(6@,3f) = 0.0 
0088: " + _3401 + @" = 7@(6@,3f) 
" + _3401 + @" /= 20.0 
008C: " + _3396 + @" = float " + _3401 + @" to_integer 
008F: 7@(6@,3f) = integer " + _3396 + @" to_float 
7@(6@,3f) *= 20.0 
0209: " + _3396 + @" = random_int_in_ranges 750 1000 
008B: 5@ = " + Current_Time_in_ms2 + @" 
005C: 5@ += " + _3396 + @" 
if 
  2 > 6@ 
jf @BANDIT_2300 
03CF: load_wav 1814 as 4 
if 
03D0:   wav 4 loaded 
jf @BANDIT_2244 
097A: play_audio_at 0.0 0.0 0.0 event 1088 

:BANDIT_2244
03CF: load_wav 1814 as 4 
if 
03D0:   wav 4 loaded 
jf @BANDIT_2286 
097A: play_audio_at 0.0 0.0 0.0 event 1089 

:BANDIT_2286
6@ += 1 
jump @BANDIT_2349 

:BANDIT_2300
03CF: load_wav 1814 as 4 
if 
03D0:   wav 4 loaded 
jf @BANDIT_2342 
097A: play_audio_at 0.0 0.0 0.0 event 1088 

:BANDIT_2342
4@ += 1 

:BANDIT_2349
jump @BANDIT_2370 

:BANDIT_2356
10@(6@,3f) = 0.6 

:BANDIT_2370
" + tempvar_Angle + @" = Object.Angle(0@)
" + _3400 + @" = 0 

:BANDIT_2385
if 
  3 > " + _3400 + @" 
jf @BANDIT_2535 
if 
  10@(" + _3400 + @",3f) > 0.0 
jf @BANDIT_2521 
007B: 7@(" + _3400 + @",3f) += frame_delta_time * 10@(" + _3400 + @",3f) 
if or
  7@(" + _3400 + @",3f) > 360.0 
  7@(" + _3400 + @",3f) == 360.0 
jf @BANDIT_2497 
7@(" + _3400 + @",3f) -= 360.0 

:BANDIT_2497
0453: set_object 1@(" + _3400 + @",3i) XYZ_rotation 7@(" + _3400 + @",3f) 0.0 " + tempvar_Angle + @" 

:BANDIT_2521
" + _3400 + @" += 1 
jump @BANDIT_2385 

:BANDIT_2535
gosub @BANDIT_2873 
jump @BANDIT_2824 

:BANDIT_2549
0088: " + _3401 + @" = 7@ 
" + _3401 + @" /= 20.0 
008C: " + _3396 + @" = float " + _3401 + @" to_integer 
0088: " + _3401 + @" = 8@ 
" + _3401 + @" /= 20.0 
008C: " + Color_Red + @" = float " + _3401 + @" to_integer 
0088: " + _3401 + @" = 9@ 
" + _3401 + @" /= 20.0 
008C: " + Color_Green + @" = float " + _3401 + @" to_integer 
if and
003A:   " + tmp_3413 + @"(" + _3396 + @",18i) == " + tmp_3431 + @"(" + Color_Red + @",18i) 
003A:   " + tmp_3413 + @"(" + _3396 + @",18i) == " + tmp_3449 + @"(" + Color_Green + @",18i) 
jf @BANDIT_2772 
008A: " + Gambles_CashWin + @" = 14@ 
0068: " + Gambles_CashWin + @" *= " + tmp_3413 + @"(" + _3396 + @",18i)" );
                create_thread<CASHWIN>( Gambles_CashWin );
AppendLine( @"Player.Money(" + PlayerChar + @") += " + Gambles_CashWin + @"
03CF: load_wav 1814 as 4 
if 
03D0:   wav 4 loaded 
jf @BANDIT_2751 
097A: play_audio_at 0.0 0.0 0.0 event 1090 

:BANDIT_2751
0623: add " + Gambles_CashWin + @" to_integer_stat 37 
0627: update_integer_stat 38 to " + Gambles_CashWin + @" 
jump @BANDIT_2792 

:BANDIT_2772" );
                create_thread<CASHWIN>( 0, 2500 );
AppendLine( @"0627: update_integer_stat 39 to 14@ 

:BANDIT_2792
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
4@ = 1 
gosub @BANDIT_2873 
jump @BANDIT_2824 

:BANDIT_2824
jump @BANDIT_2838 

:BANDIT_2831
jump @BANDIT_3455 

:BANDIT_2838
jump @BANDIT_2852 

:BANDIT_2845
jump @BANDIT_3455 

:BANDIT_2852
jump @BANDIT_2866 

:BANDIT_2859
jump @BANDIT_3455 

:BANDIT_2866
jump @BANDIT_253 

:BANDIT_2873
if 
  13@ == 1 
jf @BANDIT_3453 
03E3: set_texture_to_be_drawn_antialiased 1 
0937: text_draw_box_cornerA " + _3468 + @" " + _3473 + @" cornerB " + _3469 + @" " + _3474 + @" GXT_reference 'DUMMY' style 0 
" + _3400 + @" = 0 

:BANDIT_2927
if 
  3 > " + _3400 + @" 
jf @BANDIT_3453 
0088: " + _3401 + @" = 7@(" + _3400 + @",3f) 
" + _3401 + @" /= 20.0 
008C: " + _3396 + @" = float " + _3401 + @" to_integer 
if 
  " + _3400 + @" == 0 
jf @BANDIT_3013 
0084: " + Color_Red + @" = " + tmp_3413 + @"(" + _3396 + @",18i) 
0086: " + _3404 + @" = " + _3467 + @" 

:BANDIT_3013
if 
  " + _3400 + @" == 1 
jf @BANDIT_3061 
0084: " + Color_Red + @" = " + tmp_3431 + @"(" + _3396 + @",18i) 
0086: " + _3404 + @" = " + _3467 + @" 
" + _3404 + @" += 64.0 

:BANDIT_3061
if 
  " + _3400 + @" == 2 
jf @BANDIT_3109 
0084: " + Color_Red + @" = " + tmp_3449 + @"(" + _3396 + @",18i) 
0086: " + _3404 + @" = " + _3467 + @" 
" + _3404 + @" += 128.0 

:BANDIT_3109
if 
003A:   " + Color_Red + @" == " + _3407 + @" 
jf @BANDIT_3164 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 1 position " + _3404 + @" " + _3472 + @" size 64.0 64.0 RGBA 200 200 200 255 

:BANDIT_3164
if 
003A:   " + Color_Red + @" == " + _3408 + @" 
jf @BANDIT_3219 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 2 position " + _3404 + @" " + _3472 + @" size 64.0 64.0 RGBA 200 200 200 255 

:BANDIT_3219
if 
003A:   " + Color_Red + @" == " + _3409 + @" 
jf @BANDIT_3274 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 3 position " + _3404 + @" " + _3472 + @" size 64.0 64.0 RGBA 200 200 200 255 

:BANDIT_3274
if 
003A:   " + Color_Red + @" == " + _3410 + @" 
jf @BANDIT_3329 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position " + _3404 + @" " + _3472 + @" size 64.0 64.0 RGBA 200 200 200 255 

:BANDIT_3329
if 
003A:   " + Color_Red + @" == " + _3411 + @" 
jf @BANDIT_3384 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position " + _3404 + @" " + _3472 + @" size 64.0 64.0 RGBA 200 200 200 255 

:BANDIT_3384
if 
003A:   " + Color_Red + @" == " + _3412 + @" 
jf @BANDIT_3439 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 6 position " + _3404 + @" " + _3472 + @" size 64.0 64.0 RGBA 200 200 200 255 

:BANDIT_3439
" + _3400 + @" += 1 
jump @BANDIT_2927 

:BANDIT_3453
return 

:BANDIT_3455
if 
  4@ > 0 
jf @BANDIT_3550 
if 
  4@ > 1 
jf @BANDIT_3500 
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:BANDIT_3500
if 
  4@ > 2 
jf @BANDIT_3528 
04EF: release_animation ""CASINO"" 

:BANDIT_3528
Object.Destroy(1@)
Object.Destroy(2@)
Object.Destroy(3@)
4@ = 0 

:BANDIT_3550
if 
  13@ == 1 
jf @BANDIT_3577 
0391: release_textures 
13@ = 0 

:BANDIT_3577
end_thread 
return 
end_thread" );
            }

        }

    }

}