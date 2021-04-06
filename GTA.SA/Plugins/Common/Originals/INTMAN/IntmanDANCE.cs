using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class DANCE : External {

            Int tmp_5315 = global( _5315.startIndex ),
                tmp_5320 = global( _5320.startIndex ),
                tmp_5325 = global( _5325.startIndex ),
                tmp_5330 = global( _5330.startIndex ),
                tmp_5335 = global( _5335.startIndex ),
                tmp_5340 = global( _5340.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"08BA: set " + _5295 + @" bit 31 
09BD: allow_other_threads_to_display_text_boxes 1 
03F0: enable_text_draw 1 
09EE: set_status_text_stay_on_screen 1 
if 
  13@ > 0 
jf @DANCE_72 
5@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:DANCE_72
18@ = 5 
23@ = 5 
16@ = -1 
24@ = -1 
17@ = -1 
13@ = 0 
" + DANCE_SCORE + @" = 0 
" + _9528 + @" = 0 
" + _9527 + @" = -1 
" + _9529 + @" = 1 
22@ = 5 
TIMERA = 10000 

:DANCE_157
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @DANCE_367 
if 
  6@ > 0 
jf @DANCE_353 
if 
  " + _5298 + @" == 1 
jf @DANCE_245 
if 
   not 6@ == 2 
jf @DANCE_245 
6@ = 2 
7@ = 0 

:DANCE_245
if 
  5@ == -1 
jf @DANCE_302 
if 
   not 22@ == 5 
jf @DANCE_288 
gosub @DANCE_9479 

:DANCE_288
gosub @DANCE_381 
jump @DANCE_346 

:DANCE_302
if 
   not Actor.Dead(5@)
jf @DANCE_339 
gosub @DANCE_9479 
gosub @DANCE_381 
jump @DANCE_346 

:DANCE_339
gosub @DANCE_16653 

:DANCE_346
jump @DANCE_360 

:DANCE_353
gosub @DANCE_381 

:DANCE_360
jump @DANCE_374 

:DANCE_367
gosub @DANCE_16653 

:DANCE_374
jump @DANCE_157 

:DANCE_381
0871: init_jump_table 6@ total_jumps 4 default_jump 0 @DANCE_500 jumps 0 @DANCE_444 1 @DANCE_458 2 @DANCE_472 3 @DANCE_486 -1 @DANCE_500 -1 @DANCE_500 -1 @DANCE_500 

:DANCE_444
gosub @DANCE_502 
jump @DANCE_500 

:DANCE_458
gosub @DANCE_1090 
jump @DANCE_500 

:DANCE_472
gosub @DANCE_2086 
jump @DANCE_500 

:DANCE_486
gosub @DANCE_2412 
jump @DANCE_500 

:DANCE_500
return 

:DANCE_502
0871: init_jump_table 7@ total_jumps 4 default_jump 0 @DANCE_1088 jumps 0 @DANCE_565 1 @DANCE_646 2 @DANCE_803 3 @DANCE_948 -1 @DANCE_1088 -1 @DANCE_1088 -1 @DANCE_1088 

:DANCE_565
Player.CanMove(" + PlayerChar + @") = False
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 1 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
0826: enable_hud 0 
0581: enable_radar 0 
if 
   not 5@ == -1 
jf @DANCE_625 
0253: save_current_time 

:DANCE_625
fade 0 500 
7@ += 1 
jump @DANCE_1088 

:DANCE_646
if 
   not fading 
jf @DANCE_796 
gosub @DANCE_2764 
04ED: load_animation " + DANCE_ANIM_IFP + @" 
if 
84EE:   not animation " + DANCE_ANIM_IFP + @" loaded 
jf @DANCE_694 
jump @DANCE_1088 

:DANCE_694
if 
   not 5@ == -1 
jf @DANCE_718 
00C0: set_current_time_hours_to 0 minutes_to 0 

:DANCE_718
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at 0@ 1@ 2@ radius 1.5 
Actor.PutAt(" + PlayerActor + @", 0@, 1@, 2@)
Actor.Angle(" + PlayerActor + @") = 3@
gosub @DANCE_6883 
gosub @DANCE_5828 
17@ = 0 
0952: load_soundtrack 4@ 
7@ += 1 

:DANCE_796
jump @DANCE_1088 

:DANCE_803
0953: get_soundtrack_status_to 13@ 
if 
04A4:   13@ == 2 
jf @DANCE_941 
0954: start_playing_loaded_soundtrack 
0812: AS_actor " + PlayerActor + @" perform_animation ""DANCE_LOOP"" IFP " + DANCE_ANIM_IFP + @" framedelta 99.0 loopA 1 lockX 0 lockY 0 lockF 1 time 1215752191 
if 
   not Actor.Dead(5@)
jf @DANCE_920 
0812: AS_actor 5@ perform_animation ""DANCE_LOOP"" IFP " + DANCE_ANIM_IFP + @" framedelta 99.0 loopA 1 lockX 0 lockY 0 lockF 1 time 1215752191 

:DANCE_920
fade 1 500 
TIMERB = 0 
7@ += 1 

:DANCE_941
jump @DANCE_1088 

:DANCE_948
if 
   not fading 
jf @DANCE_1081 
if 
  5@ == -1 
jf @DANCE_1043 
if 
  TIMERB >= 10000 
jf @DANCE_1036" );
create_thread<BDISPLY>();
AppendLine( @"03C4: set_status_text " + DANCE_SCORE + @" type 0 GXT 'DNC_001' 
6@ = 1 
7@ = 1 

:DANCE_1036
jump @DANCE_1081 

:DANCE_1043" );
create_thread<BDISPLY>();
AppendLine( @"03C4: set_status_text " + DANCE_SCORE + @" type 0 GXT 'DNC_001' 
6@ = 1 
7@ = 1 

:DANCE_1081
jump @DANCE_1088 

:DANCE_1088
return 

:DANCE_1090
0871: init_jump_table 7@ total_jumps 1 default_jump 0 @DANCE_2084 jumps 1 @DANCE_1153 -1 @DANCE_2084 -1 @DANCE_2084 -1 @DANCE_2084 -1 @DANCE_2084 -1 @DANCE_2084 -1 @DANCE_2084 

:DANCE_1153
gosub @DANCE_5692 
gosub @DANCE_8068 
gosub @DANCE_5723 
gosub @DANCE_5504 
gosub @DANCE_2932 
if 
  6@ == 3 
jf @DANCE_1213 
jump @DANCE_2084 

:DANCE_1213
gosub @DANCE_3662 
gosub @DANCE_5367 
gosub @DANCE_5828 
gosub @DANCE_8952 
gosub @DANCE_9617 
if 
  22@ == 3 
jf @DANCE_1387 
if 
  99999999 > " + DANCE_SCORE + @" 
jf @DANCE_1341 
if 
  29@ == 2 
jf @DANCE_1334 
30@ = 10 
30@ *= 2 
005E: " + DANCE_SCORE + @" += 30@ 
jump @DANCE_1341 

:DANCE_1334
" + DANCE_SCORE + @" += 10 

:DANCE_1341
26@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_1380 
gosub @DANCE_4113 

:DANCE_1380
jump @DANCE_2084 

:DANCE_1387
if 
  22@ == 1 
jf @DANCE_1526 
if 
  99999999 > " + DANCE_SCORE + @" 
jf @DANCE_1480 
if 
  29@ == 2 
jf @DANCE_1473 
30@ = 50 
30@ *= 2 
005E: " + DANCE_SCORE + @" += 30@ 
jump @DANCE_1480 

:DANCE_1473
" + DANCE_SCORE + @" += 50 

:DANCE_1480
28@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_1519 
gosub @DANCE_4113 

:DANCE_1519
jump @DANCE_2084 

:DANCE_1526
if 
  22@ == 2 
jf @DANCE_1665 
if 
  99999999 > " + DANCE_SCORE + @" 
jf @DANCE_1619 
if 
  29@ == 2 
jf @DANCE_1612 
30@ = 20 
30@ *= 2 
005E: " + DANCE_SCORE + @" += 30@ 
jump @DANCE_1619 

:DANCE_1612
" + DANCE_SCORE + @" += 20 

:DANCE_1619
26@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_1658 
gosub @DANCE_4113 

:DANCE_1658
jump @DANCE_2084 

:DANCE_1665
if 
  22@ == 0 
jf @DANCE_1768 
if 
  " + DANCE_SCORE + @" > 0 
jf @DANCE_1715 
" + DANCE_SCORE + @" -= 0 
jump @DANCE_1722 

:DANCE_1715
" + DANCE_SCORE + @" = 0 

:DANCE_1722
27@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_1761 
gosub @DANCE_4740 

:DANCE_1761
jump @DANCE_2084 

:DANCE_1768
if 
  22@ == 4 
jf @DANCE_1871 
if 
  " + DANCE_SCORE + @" > 0 
jf @DANCE_1818 
" + DANCE_SCORE + @" -= 0 
jump @DANCE_1825 

:DANCE_1818
" + DANCE_SCORE + @" = 0 

:DANCE_1825
27@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_1864 
gosub @DANCE_4740 

:DANCE_1864
jump @DANCE_2084 

:DANCE_1871
if 
  22@ == 10 
jf @DANCE_1974 
if 
  " + DANCE_SCORE + @" > 0 
jf @DANCE_1921 
" + DANCE_SCORE + @" -= 0 
jump @DANCE_1928 

:DANCE_1921
" + DANCE_SCORE + @" = 0 

:DANCE_1928
27@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_1967 
gosub @DANCE_4740 

:DANCE_1967
jump @DANCE_2084 

:DANCE_1974
if 
  22@ == 11 
jf @DANCE_2077 
if 
  " + DANCE_SCORE + @" > 0 
jf @DANCE_2024 
" + DANCE_SCORE + @" -= 0 
jump @DANCE_2031 

:DANCE_2024
" + DANCE_SCORE + @" = 0 

:DANCE_2031
27@ += 1 
gosub @DANCE_8131 
if 
   not 31@ == -1 
jf @DANCE_2070 
gosub @DANCE_4740 

:DANCE_2070
jump @DANCE_2084 

:DANCE_2077
jump @DANCE_2084 

:DANCE_2084
return 

:DANCE_2086
0871: init_jump_table 7@ total_jumps 4 default_jump 0 @DANCE_2410 jumps 0 @DANCE_2149 1 @DANCE_2170 2 @DANCE_2222 3 @DANCE_2396 -1 @DANCE_2410 -1 @DANCE_2410 -1 @DANCE_2410 

:DANCE_2149
fade 0 500 
7@ += 1 
jump @DANCE_2410 

:DANCE_2170
if 
   not fading 
jf @DANCE_2215 
0953: get_soundtrack_status_to 13@ 
if 
04A4:   13@ == 3 
jf @DANCE_2208 
0955: end_playing_loaded_soundtrack 

:DANCE_2208
7@ += 1 

:DANCE_2215
jump @DANCE_2410 

:DANCE_2222
0151: remove_status_text " + DANCE_SCORE + @" 
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 0 
03F4: set_all_cars_apply_damage_rules 1 
0826: enable_hud 1 
0581: enable_radar 1 
03E6: remove_text_box 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
0792: disembark_instantly_actor " + PlayerActor + @" 
0812: AS_actor " + PlayerActor + @" perform_animation ""DANCE_LOOP"" IFP " + DANCE_ANIM_IFP + @" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 0 time 0 
if 
   not Actor.Dead(5@)
jf @DANCE_2355 
0792: disembark_instantly_actor 5@ 
0812: AS_actor 5@ perform_animation ""DANCE_LOOP"" IFP " + DANCE_ANIM_IFP + @" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 0 time 0 

:DANCE_2355
if 
   not 5@ == -1 
jf @DANCE_2375 
0254: restore_current_time 

:DANCE_2375
fade 1 1500 
7@ += 1 
jump @DANCE_2410 

:DANCE_2396
gosub @DANCE_16653 
jump @DANCE_2410 

:DANCE_2410
return 

:DANCE_2412
0871: init_jump_table 7@ total_jumps 2 default_jump 0 @DANCE_2762 jumps 0 @DANCE_2475 1 @DANCE_2567 -1 @DANCE_2762 -1 @DANCE_2762 -1 @DANCE_2762 -1 @DANCE_2762 -1 @DANCE_2762 

:DANCE_2475
0991: set_soundtrack_paused 1 
if 
   Actor.Animation(" + PlayerActor + @") == " + DANCE_ANIM + @"
jf @DANCE_2508 
0612: set_actor " + PlayerActor + @" animation " + DANCE_ANIM + @" paused 0 

:DANCE_2508
if 
   not Actor.Dead(5@)
jf @DANCE_2553 
if 
   Actor.Animation(5@) == " + _5303 + @"
jf @DANCE_2553 
0612: set_actor 5@ animation " + _5303 + @" paused 0 

:DANCE_2553
7@ += 1 
jump @DANCE_2762 

:DANCE_2567
gosub @DANCE_2932 
if 
  18@ == 100 
jf @DANCE_2620 
" + DANCE_SCORE + @" = 0 
6@ = 2 
7@ = 0 
jump @DANCE_2762 

:DANCE_2620
if 
  18@ == 99 
jf @DANCE_2755 
if 
  6@ > 0 
jf @DANCE_2755 
0991: set_soundtrack_paused 0 
if 
   Actor.Animation(" + PlayerActor + @") == " + DANCE_ANIM + @"
jf @DANCE_2689 
0612: set_actor " + PlayerActor + @" animation " + DANCE_ANIM + @" paused 1 

:DANCE_2689
if 
   not Actor.Dead(5@)
jf @DANCE_2734 
if 
   Actor.Animation(5@) == " + _5303 + @"
jf @DANCE_2734 
0612: set_actor 5@ animation " + _5303 + @" paused 1 

:DANCE_2734
6@ = 1 
7@ = 1 
jump @DANCE_2762 

:DANCE_2755
jump @DANCE_2762 

:DANCE_2762
return 

:DANCE_2764
0871: init_jump_table 4@ total_jumps 4 default_jump 1 @DANCE_2906 jumps 1 @DANCE_2827 2 @DANCE_2846 3 @DANCE_2865 4 @DANCE_2889 -1 @DANCE_2930 -1 @DANCE_2930 -1 @DANCE_2930 

:DANCE_2827
06D1: " + DANCE_ANIM_IFP + @" = ""GFUNK"" 
jump @DANCE_2930 

:DANCE_2846
06D1: " + DANCE_ANIM_IFP + @" = ""GFUNK"" 
jump @DANCE_2930 

:DANCE_2865
06D1: " + DANCE_ANIM_IFP + @" = ""RUNNINGMAN"" 
jump @DANCE_2930 

:DANCE_2889
06D1: " + DANCE_ANIM_IFP + @" = ""WOP"" 
jump @DANCE_2930 

:DANCE_2906
06D1: " + DANCE_ANIM_IFP + @" = ""WOP"" 
4@ = 4 
jump @DANCE_2930 

:DANCE_2930
return 

:DANCE_2932
gosub @DANCE_16964 
0871: init_jump_table 23@ total_jumps 7 default_jump 0 @DANCE_3660 jumps 1 @DANCE_3386 2 @DANCE_3340 3 @DANCE_3294 4 @DANCE_3248 5 @DANCE_3002 99 @DANCE_3432 100 @DANCE_3615 

:DANCE_3002
if 
  " + _9534 + @" == 10 
jf @DANCE_3041 
18@ = 4 
23@ = 4 
jump @DANCE_3660 

:DANCE_3041
if 
  " + _9534 + @" == 13 
jf @DANCE_3080 
18@ = 3 
23@ = 3 
jump @DANCE_3660 

:DANCE_3080
if 
  " + _9534 + @" == 9 
jf @DANCE_3119 
18@ = 2 
23@ = 2 
jump @DANCE_3660 

:DANCE_3119
if 
  " + _9534 + @" == 14 
jf @DANCE_3158 
18@ = 1 
23@ = 1 
jump @DANCE_3660 

:DANCE_3158
if 
00E1:   player 0 pressed_key 15 
jf @DANCE_3203 
18@ = 99 
23@ = 99 
TIMERB = 0 
jump @DANCE_3660 

:DANCE_3203
if 
00E1:   player 0 pressed_key 16 
jf @DANCE_3241 
18@ = 100 
23@ = 100 
jump @DANCE_3660 

:DANCE_3241
jump @DANCE_3660 

:DANCE_3248
18@ = 5 
if 
  " + _9534 + @" == 0 
jf @DANCE_3287 
23@ = 5 
jump @DANCE_3660 

:DANCE_3287
jump @DANCE_3660 

:DANCE_3294
18@ = 5 
if 
  " + _9534 + @" == 0 
jf @DANCE_3333 
23@ = 5 
jump @DANCE_3660 

:DANCE_3333
jump @DANCE_3660 

:DANCE_3340
18@ = 5 
if 
  " + _9534 + @" == 0 
jf @DANCE_3379 
23@ = 5 
jump @DANCE_3660 

:DANCE_3379
jump @DANCE_3660 

:DANCE_3386
18@ = 5 
if 
  " + _9534 + @" == 0 
jf @DANCE_3425 
23@ = 5 
jump @DANCE_3660 

:DANCE_3425
jump @DANCE_3660 

:DANCE_3432
18@ = 5 
if 
80E1:   not player 0 pressed_key 15 
jf @DANCE_3477 
23@ = 5 
jump @DANCE_3660 
jump @DANCE_3608 

:DANCE_3477
if 
  5@ == -1 
jf @DANCE_3564 
if 
   not 22@ == 5 
jf @DANCE_3557 
if and
   not 6@ == 3 
  TIMERB >= 800 
jf @DANCE_3557 
03E6: remove_text_box 
6@ = 3 
7@ = 0 
return 

:DANCE_3557
jump @DANCE_3608 

:DANCE_3564
if and
   not 6@ == 3 
  TIMERB >= 800 
jf @DANCE_3608 
03E6: remove_text_box 
6@ = 3 
7@ = 0 
return 

:DANCE_3608
jump @DANCE_3660 

:DANCE_3615
18@ = 5 
if 
80E1:   not player 0 pressed_key 16 
jf @DANCE_3653 
23@ = 5 
jump @DANCE_3660 

:DANCE_3653
jump @DANCE_3660 

:DANCE_3660
return 

:DANCE_3662
07B1: unknown_get_dance_track 0 store_to 14@ 13@ 15@ 
if 
  14@ > 3000 
jf @DANCE_3708 
22@ = 5 
jump @DANCE_4111 

:DANCE_3708
if 
001D:   15@ > 16@ 
jf @DANCE_4022 
if 
  18@ == 5 
jf @DANCE_3787 
if 
  -110 > 14@ 
jf @DANCE_3780 
22@ = 0 
0085: 16@ = 15@ 
return 

:DANCE_3780
jump @DANCE_4015 

:DANCE_3787
" + _1043 + @" = 1 
if 
003B:   18@ == 13@ 
jf @DANCE_3998 
if and
  35 >= 14@ 
  14@ >= -35 
jf @DANCE_3869 
22@ = 1 
" + _1043 + @" = 3 
0085: 16@ = 15@ 
return 
jump @DANCE_3991 

:DANCE_3869
if and
  60 >= 14@ 
  14@ >= -60 
jf @DANCE_3925 
22@ = 2 
" + _1043 + @" = 2 
0085: 16@ = 15@ 
return 
jump @DANCE_3991 

:DANCE_3925
if and
  110 >= 14@ 
  14@ >= -110 
jf @DANCE_3974 
22@ = 3 
0085: 16@ = 15@ 
return 
jump @DANCE_3991 

:DANCE_3974
22@ = 11 
0085: 16@ = 15@ 
return 

:DANCE_3991
jump @DANCE_4015 

:DANCE_3998
22@ = 10 
0085: 16@ = 15@ 
return 

:DANCE_4015
jump @DANCE_4111 

:DANCE_4022
if or
  22@ == 1 
  22@ == 2 
  22@ == 3 
jf @DANCE_4063 
22@ = 8 
return 

:DANCE_4063
if or
  22@ == 0 
  22@ == 4 
  22@ == 10 
  22@ == 11 
jf @DANCE_4111 
22@ = 9 
return 

:DANCE_4111
return 

:DANCE_4113
0871: init_jump_table 17@ total_jumps 15 default_jump 1 @DANCE_4241 jumps 2 @DANCE_4270 3 @DANCE_4299 4 @DANCE_4328 5 @DANCE_4357 6 @DANCE_4386 7 @DANCE_4415 8 @DANCE_4444 
0872: jump_table_jumps 9 @DANCE_4473 10 @DANCE_4502 11 @DANCE_4532 12 @DANCE_4562 13 @DANCE_4592 14 @DANCE_4622 15 @DANCE_4652 16 @DANCE_4682 -1 @DANCE_4712 

:DANCE_4241
06D1: " + DANCE_ANIM + @" = ""DANCE_G1"" 
17@ = 2 
jump @DANCE_4712 

:DANCE_4270
06D1: " + DANCE_ANIM + @" = ""DANCE_G2"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4299
06D1: " + DANCE_ANIM + @" = ""DANCE_G3"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4328
06D1: " + DANCE_ANIM + @" = ""DANCE_G4"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4357
06D1: " + DANCE_ANIM + @" = ""DANCE_G5"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4386
06D1: " + DANCE_ANIM + @" = ""DANCE_G6"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4415
06D1: " + DANCE_ANIM + @" = ""DANCE_G7"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4444
06D1: " + DANCE_ANIM + @" = ""DANCE_G8"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4473
06D1: " + DANCE_ANIM + @" = ""DANCE_G9"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4502
06D1: " + DANCE_ANIM + @" = ""DANCE_G10"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4532
06D1: " + DANCE_ANIM + @" = ""DANCE_G11"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4562
06D1: " + DANCE_ANIM + @" = ""DANCE_G12"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4592
06D1: " + DANCE_ANIM + @" = ""DANCE_G13"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4622
06D1: " + DANCE_ANIM + @" = ""DANCE_G14"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4652
06D1: " + DANCE_ANIM + @" = ""DANCE_G15"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4682
06D1: " + DANCE_ANIM + @" = ""DANCE_G16"" 
17@ += 1 
jump @DANCE_4712 

:DANCE_4712
0812: AS_actor " + PlayerActor + @" perform_animation " + DANCE_ANIM + @" IFP " + DANCE_ANIM_IFP + @" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 0 
return 

:DANCE_4740
0871: init_jump_table 17@ total_jumps 15 default_jump 1 @DANCE_4868 jumps 2 @DANCE_4897 3 @DANCE_4926 4 @DANCE_4955 5 @DANCE_4984 6 @DANCE_5013 7 @DANCE_5042 8 @DANCE_5071 
0872: jump_table_jumps 9 @DANCE_5100 10 @DANCE_5129 11 @DANCE_5159 12 @DANCE_5189 13 @DANCE_5219 14 @DANCE_5249 15 @DANCE_5279 16 @DANCE_5309 -1 @DANCE_5339 

:DANCE_4868
06D1: " + DANCE_ANIM + @" = ""DANCE_B1"" 
17@ = 2 
jump @DANCE_5339 

:DANCE_4897
06D1: " + DANCE_ANIM + @" = ""DANCE_B2"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_4926
06D1: " + DANCE_ANIM + @" = ""DANCE_B3"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_4955
06D1: " + DANCE_ANIM + @" = ""DANCE_B4"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_4984
06D1: " + DANCE_ANIM + @" = ""DANCE_B5"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5013
06D1: " + DANCE_ANIM + @" = ""DANCE_B6"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5042
06D1: " + DANCE_ANIM + @" = ""DANCE_B7"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5071
06D1: " + DANCE_ANIM + @" = ""DANCE_B8"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5100
06D1: " + DANCE_ANIM + @" = ""DANCE_B9"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5129
06D1: " + DANCE_ANIM + @" = ""DANCE_B10"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5159
06D1: " + DANCE_ANIM + @" = ""DANCE_B11"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5189
06D1: " + DANCE_ANIM + @" = ""DANCE_B12"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5219
06D1: " + DANCE_ANIM + @" = ""DANCE_B13"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5249
06D1: " + DANCE_ANIM + @" = ""DANCE_B14"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5279
06D1: " + DANCE_ANIM + @" = ""DANCE_B15"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5309
06D1: " + DANCE_ANIM + @" = ""DANCE_B16"" 
17@ += 1 
jump @DANCE_5339 

:DANCE_5339
0812: AS_actor " + PlayerActor + @" perform_animation " + DANCE_ANIM + @" IFP " + DANCE_ANIM_IFP + @" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 0 
return 

:DANCE_5367
if 
   Actor.Animation(" + PlayerActor + @") == " + DANCE_ANIM + @"
jf @DANCE_5493 
061A: get_actor " + PlayerActor + @" animation " + DANCE_ANIM + @" total_time_to 12@ 
0613: 11@ = actor " + PlayerActor + @" animation " + DANCE_ANIM + @" time 
0093: 8@ = integer 21@ to_float 
0087: 0@ = 8@ 
0073: 0@ /= 12@ 
005B: 11@ += 0@ 
if 
  11@ >= 1.0 
jf @DANCE_5477 
31@ = 1 
return 
jump @DANCE_5486 

:DANCE_5477
31@ = -1 
return 

:DANCE_5486
jump @DANCE_5502 

:DANCE_5493
31@ = 0 
return 

:DANCE_5502
return 

:DANCE_5504
if 
  5@ > -1 
jf @DANCE_5690 
if 
   Actor.Animation(5@) == " + _5303 + @"
jf @DANCE_5632 
061A: get_actor 5@ animation " + _5303 + @" total_time_to 12@ 
0613: 11@ = actor 5@ animation " + _5303 + @" time 
0093: 8@ = integer 21@ to_float 
0087: 0@ = 8@ 
0073: 0@ /= 12@ 
005B: 11@ += 0@ 
if 
  11@ >= 1.0 
jf @DANCE_5625 
gosub @DANCE_7066 
return 

:DANCE_5625
jump @DANCE_5690 

:DANCE_5632
07B1: unknown_get_dance_track 0 store_to 14@ 13@ 15@ 
if 
  15@ == 0 
jf @DANCE_5690 
if 
  25 >= 14@ 
jf @DANCE_5690 
gosub @DANCE_7066 
return 

:DANCE_5690
return 

:DANCE_5692
01BD: 19@ = current_time_in_ms 
0085: 21@ = 19@ 
0062: 21@ -= 20@ 
0085: 20@ = 19@ 
return 

:DANCE_5723
gosub @DANCE_5367 
if 
  31@ == 1 
jf @DANCE_5826 
if or
  22@ == 1 
  22@ == 2 
  22@ == 3 
  22@ == 8 
jf @DANCE_5810 
gosub @DANCE_4113 
31@ = -1 
return 
jump @DANCE_5826 

:DANCE_5810
gosub @DANCE_4740 
31@ = -1 
return 

:DANCE_5826
return 

:DANCE_5828
0871: init_jump_table 17@ total_jumps 5 default_jump 0 @DANCE_6881 jumps -1 @DANCE_5891 4 @DANCE_6089 8 @DANCE_6287 12 @DANCE_6485 16 @DANCE_6683 -1 @DANCE_6881 -1 @DANCE_6881 

:DANCE_5891
if and
  5@ == -1 
  " + tmp_5315 + @"[0] > 0.0 
jf @DANCE_5965 
Camera.SetPosition(" + tmp_5315 + @"[0], " + tmp_5320 + @"[0], " + tmp_5325 + @"[0], 0.0, 0.0, 0.0)
Camera.PointAt(" + tmp_5330 + @"[0], " + tmp_5335 + @"[0], " + tmp_5340 + @"[0], 2)
jump @DANCE_6082 

:DANCE_5965
04C4: store_coords_to 8@ 9@ 10@ from_actor " + PlayerActor + @" with_offset -2.3176 0.9635 0.5141 
04C4: store_coords_to 0@ 1@ 2@ from_actor " + PlayerActor + @" with_offset -1.3381 0.8235 0.6587 
10@ -= 1.0 
2@ -= 1.0 
Camera.SetPosition(8@, 9@, 10@, 0.0, 0.0, 0.0)
Camera.PointAt(0@, 1@, 2@, 2)

:DANCE_6082
jump @DANCE_6881 

:DANCE_6089
if and
  5@ == -1 
  " + tmp_5315 + @"[1] > 0.0 
jf @DANCE_6163 
Camera.SetPosition(" + tmp_5315 + @"[1], " + tmp_5320 + @"[1], " + tmp_5325 + @"[1], 0.0, 0.0, 0.0)
Camera.PointAt(" + tmp_5330 + @"[1], " + tmp_5335 + @"[1], " + tmp_5340 + @"[1], 2)
jump @DANCE_6280 

:DANCE_6163
04C4: store_coords_to 8@ 9@ 10@ from_actor " + PlayerActor + @" with_offset 3.5814 0.8987 0.6651 
04C4: store_coords_to 0@ 1@ 2@ from_actor " + PlayerActor + @" with_offset 2.6071 0.853 0.8857 
10@ -= 1.0 
2@ -= 1.0 
Camera.SetPosition(8@, 9@, 10@, 0.0, 0.0, 0.0)
Camera.PointAt(0@, 1@, 2@, 2)

:DANCE_6280
jump @DANCE_6881 

:DANCE_6287
if and
  5@ == -1 
  " + tmp_5315 + @"[2] > 0.0 
jf @DANCE_6361 
Camera.SetPosition(" + tmp_5315 + @"[2], " + tmp_5320 + @"[2], " + tmp_5325 + @"[2], 0.0, 0.0, 0.0)
Camera.PointAt(" + tmp_5330 + @"[2], " + tmp_5335 + @"[2], " + tmp_5340 + @"[2], 2)
jump @DANCE_6478 

:DANCE_6361
04C4: store_coords_to 8@ 9@ 10@ from_actor " + PlayerActor + @" with_offset 0.3843 2.9502 1.8476 
04C4: store_coords_to 0@ 1@ 2@ from_actor " + PlayerActor + @" with_offset 0.461 2.0089 1.5188 
10@ -= 1.0 
2@ -= 1.0 
Camera.SetPosition(8@, 9@, 10@, 0.0, 0.0, 0.0)
Camera.PointAt(0@, 1@, 2@, 2)

:DANCE_6478
jump @DANCE_6881 

:DANCE_6485
if and
  5@ == -1 
  " + tmp_5315 + @"[3] > 0.0 
jf @DANCE_6559 
Camera.SetPosition(" + tmp_5315 + @"[3], " + tmp_5320 + @"[3], " + tmp_5325 + @"[3], 0.0, 0.0, 0.0)
Camera.PointAt(" + tmp_5330 + @"[3], " + tmp_5335 + @"[3], " + tmp_5340 + @"[3], 2)
jump @DANCE_6676 

:DANCE_6559
04C4: store_coords_to 8@ 9@ 10@ from_actor " + PlayerActor + @" with_offset -2.2621 0.1226 0.6863 
04C4: store_coords_to 0@ 1@ 2@ from_actor " + PlayerActor + @" with_offset -1.2706 0.1649 0.8096 
10@ -= 1.0 
2@ -= 1.0 
Camera.SetPosition(8@, 9@, 10@, 0.0, 0.0, 0.0)
Camera.PointAt(0@, 1@, 2@, 2)

:DANCE_6676
jump @DANCE_6881 

:DANCE_6683
if and
  5@ == -1 
  " + tmp_5315 + @"[4] > 0.0 
jf @DANCE_6757 
Camera.SetPosition(" + tmp_5315 + @"[4], " + tmp_5320 + @"[4], " + tmp_5325 + @"[4], 0.0, 0.0, 0.0)
Camera.PointAt(" + tmp_5330 + @"[4], " + tmp_5335 + @"[4], " + tmp_5340 + @"[4], 2)
jump @DANCE_6874 

:DANCE_6757
04C4: store_coords_to 8@ 9@ 10@ from_actor " + PlayerActor + @" with_offset -1.6647 1.7322 2.3217 
04C4: store_coords_to 0@ 1@ 2@ from_actor " + PlayerActor + @" with_offset -0.8677 1.3108 1.889 
10@ -= 1.0 
2@ -= 1.0 
Camera.SetPosition(8@, 9@, 10@, 0.0, 0.0, 0.0)
Camera.PointAt(0@, 1@, 2@, 2)

:DANCE_6874
jump @DANCE_6881 

:DANCE_6881
return 

:DANCE_6883
if 
   not 5@ == -1 
jf @DANCE_7064 
04C4: store_coords_to 8@ 9@ 10@ from_actor " + PlayerActor + @" with_offset 1.0 1.3 0.0 
02CE: 10@ = ground_z_at 8@ 9@ 10@ 
if 
   Actor.Dead(5@)
jf @DANCE_6974 
gosub @DANCE_7709 
jump @DANCE_7017 

:DANCE_6974
if 
06EE:   actor 5@ in_group " + PlayerGroup + @" 
jf @DANCE_6998 
06C9: remove_actor 5@ from_group 

:DANCE_6998
0792: disembark_instantly_actor 5@ 
Actor.PutAt(5@, 8@, 9@, 10@)

:DANCE_7017
if and
   not Actor.Dead(5@)
   not Actor.Dead(" + PlayerActor + @")
jf @DANCE_7064 
11@ = Actor.Angle(" + PlayerActor + @")
11@ += 180.0 
Actor.Angle(5@) = 11@

:DANCE_7064
return 

:DANCE_7066
0871: init_jump_table 25@ total_jumps 15 default_jump 1 @DANCE_7194 jumps 2 @DANCE_7223 3 @DANCE_7252 4 @DANCE_7281 5 @DANCE_7310 6 @DANCE_7339 7 @DANCE_7368 8 @DANCE_7397 
0872: jump_table_jumps 9 @DANCE_7426 10 @DANCE_7455 11 @DANCE_7485 12 @DANCE_7515 13 @DANCE_7545 14 @DANCE_7575 15 @DANCE_7605 16 @DANCE_7635 -1 @DANCE_7665 

:DANCE_7194
06D1: " + _5303 + @" = ""DANCE_G1"" 
25@ = 2 
jump @DANCE_7665 

:DANCE_7223
06D1: " + _5303 + @" = ""DANCE_G2"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7252
06D1: " + _5303 + @" = ""DANCE_G3"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7281
06D1: " + _5303 + @" = ""DANCE_G4"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7310
06D1: " + _5303 + @" = ""DANCE_G5"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7339
06D1: " + _5303 + @" = ""DANCE_G6"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7368
06D1: " + _5303 + @" = ""DANCE_G7"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7397
06D1: " + _5303 + @" = ""DANCE_G8"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7426
06D1: " + _5303 + @" = ""DANCE_G9"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7455
06D1: " + _5303 + @" = ""DANCE_G10"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7485
06D1: " + _5303 + @" = ""DANCE_G11"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7515
06D1: " + _5303 + @" = ""DANCE_G12"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7545
06D1: " + _5303 + @" = ""DANCE_G13"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7575
06D1: " + _5303 + @" = ""DANCE_G14"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7605
06D1: " + _5303 + @" = ""DANCE_G15"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7635
06D1: " + _5303 + @" = ""DANCE_G16"" 
25@ += 1 
jump @DANCE_7665 

:DANCE_7665
if
   not Actor.Dead(5@)
jf @DANCE_7707 
0812: AS_actor 5@ perform_animation " + _5303 + @" IFP " + DANCE_ANIM_IFP + @" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time 0 

:DANCE_7707
return 

:DANCE_7709
0209: 13@ = random_int_in_ranges 1 5 
0871: init_jump_table 13@ total_jumps 5 default_jump 0 @DANCE_8066 jumps 1 @DANCE_7781 2 @DANCE_7838 3 @DANCE_7895 4 @DANCE_7952 5 @DANCE_8009 -1 @DANCE_8066 -1 @DANCE_8066 

:DANCE_7781
if 
   not Model.Available(#BFYRI)
jf @DANCE_7811 
Model.Load(#BFYRI)
wait 0 
jump @DANCE_7781 

:DANCE_7811
5@ = Actor.Create(CivFemale, #BFYRI, 8@, 9@, 10@)
return 
jump @DANCE_8066 

:DANCE_7838
if 
   not Model.Available(#OFYST)
jf @DANCE_7868 
Model.Load(#OFYST)
wait 0 
jump @DANCE_7838 

:DANCE_7868
5@ = Actor.Create(CivFemale, #OFYST, 8@, 9@, 10@)
return 
jump @DANCE_8066 

:DANCE_7895
if 
   not Model.Available(#WFYST)
jf @DANCE_7925 
Model.Load(#WFYST)
wait 0 
jump @DANCE_7895 

:DANCE_7925
5@ = Actor.Create(CivFemale, #WFYST, 8@, 9@, 10@)
return 
jump @DANCE_8066 

:DANCE_7952
if 
   not Model.Available(#HFYRI)
jf @DANCE_7982 
Model.Load(#HFYRI)
wait 0 
jump @DANCE_7952 

:DANCE_7982
5@ = Actor.Create(CivFemale, #HFYRI, 8@, 9@, 10@)
return 
jump @DANCE_8066 

:DANCE_8009
if 
   not Model.Available(#WFYRI)
jf @DANCE_8039 
Model.Load(#WFYRI)
wait 0 
jump @DANCE_8009 

:DANCE_8039
5@ = Actor.Create(CivFemale, #WFYRI, 8@, 9@, 10@)
return 
jump @DANCE_8066 

:DANCE_8066
return 

:DANCE_8068
if 
8846:   not string " + DANCE_ANIM + @" empty 
jf @DANCE_8129 
07B1: unknown_get_dance_track 0 store_to 14@ 13@ 15@ 
if 
  13@ == 33 
jf @DANCE_8129 
6@ = 2 
7@ = 0 

:DANCE_8129
return 

:DANCE_8131
0871: init_jump_table 24@ total_jumps 2 default_jump 1 @DANCE_8194 jumps 2 @DANCE_8446 3 @DANCE_8698 -1 @DANCE_8950 -1 @DANCE_8950 -1 @DANCE_8950 -1 @DANCE_8950 -1 @DANCE_8950 

:DANCE_8194
if 
  22@ == 1 
jf @DANCE_8228 
00BA: show_text_styled GXT 'DNC_005' time 1000 style 5  

:DANCE_8228
if 
  22@ == 2 
jf @DANCE_8262 
00BA: show_text_styled GXT 'DNC_006' time 1000 style 5  

:DANCE_8262
if 
  22@ == 3 
jf @DANCE_8296 
00BA: show_text_styled GXT 'DNC_007' time 1000 style 5  

:DANCE_8296
if 
  22@ == 0 
jf @DANCE_8330 
00BA: show_text_styled GXT 'DNC_008' time 1000 style 5  

:DANCE_8330
if 
  22@ == 4 
jf @DANCE_8364 
00BA: show_text_styled GXT 'DNC_009' time 1000 style 5  

:DANCE_8364
if 
  22@ == 10 
jf @DANCE_8398 
00BA: show_text_styled GXT 'DNC_010' time 1000 style 5  

:DANCE_8398
if 
  22@ == 11 
jf @DANCE_8432 
00BA: show_text_styled GXT 'DNC_011' time 1000 style 5  

:DANCE_8432
24@ = 2 
jump @DANCE_8950 

:DANCE_8446
if 
  22@ == 1 
jf @DANCE_8480 
00BA: show_text_styled GXT 'DNC_012' time 1000 style 5  

:DANCE_8480
if 
  22@ == 2 
jf @DANCE_8514 
00BA: show_text_styled GXT 'DNC_013' time 1000 style 5  

:DANCE_8514
if 
  22@ == 3 
jf @DANCE_8548 
00BA: show_text_styled GXT 'DNC_014' time 1000 style 5  

:DANCE_8548
if 
  22@ == 0 
jf @DANCE_8582 
00BA: show_text_styled GXT 'DNC_015' time 1000 style 5  

:DANCE_8582
if 
  22@ == 4 
jf @DANCE_8616 
00BA: show_text_styled GXT 'DNC_016' time 1000 style 5  

:DANCE_8616
if 
  22@ == 10 
jf @DANCE_8650 
00BA: show_text_styled GXT 'DNC_017' time 1000 style 5  

:DANCE_8650
if 
  22@ == 11 
jf @DANCE_8684 
00BA: show_text_styled GXT 'DNC_018' time 1000 style 5  

:DANCE_8684
24@ += 1 
jump @DANCE_8950 

:DANCE_8698
if 
  22@ == 1 
jf @DANCE_8732 
00BA: show_text_styled GXT 'DNC_019' time 1000 style 5  

:DANCE_8732
if 
  22@ == 2 
jf @DANCE_8766 
00BA: show_text_styled GXT 'DNC_020' time 1000 style 5  

:DANCE_8766
if 
  22@ == 3 
jf @DANCE_8800 
00BA: show_text_styled GXT 'DNC_021' time 1000 style 5  

:DANCE_8800
if 
  22@ == 0 
jf @DANCE_8834 
00BA: show_text_styled GXT 'DNC_022' time 1000 style 5  

:DANCE_8834
if 
  22@ == 4 
jf @DANCE_8868 
00BA: show_text_styled GXT 'DNC_023' time 1000 style 5  

:DANCE_8868
if 
  22@ == 10 
jf @DANCE_8902 
00BA: show_text_styled GXT 'DNC_024' time 1000 style 5  

:DANCE_8902
if 
  22@ == 11 
jf @DANCE_8936 
00BA: show_text_styled GXT 'DNC_025' time 1000 style 5  

:DANCE_8936
24@ += 1 
jump @DANCE_8950 

:DANCE_8950
return 

:DANCE_8952
0085: 13@ = 26@ 
005A: 13@ += 27@ 
005A: 13@ += 28@ 
if 
  13@ > 0 
jf @DANCE_9477 
if 
  13@ >= 4 
jf @DANCE_9477 
if 
  28@ == 4 
jf @DANCE_9147 
if or
  29@ == 1 
  29@ == 2 
jf @DANCE_9101 
" + _9527 + @" = 2 
TIMERA = 0 
00BA: show_text_styled GXT 'DNC_002' time 50000 style 7  
29@ = 2 
jump @DANCE_9140 

:DANCE_9101
" + _9527 + @" = 2 
TIMERA = 0 
00BA: show_text_styled GXT 'DNC_004' time 50000 style 7  
29@ = 1 

:DANCE_9140
jump @DANCE_9456 

:DANCE_9147
if 
001D:   26@ > 27@ 
jf @DANCE_9270 
if 
   not 29@ == 1 
jf @DANCE_9205 
" + _9527 + @" = 4 
TIMERA = 0 
jump @DANCE_9238 

:DANCE_9205
if 
  TIMERA >= 10000 
jf @DANCE_9238 
" + _9527 + @" = 4 
TIMERA = 0 

:DANCE_9238
00BA: show_text_styled GXT 'DNC_004' time 50000 style 7  
29@ = 1 
jump @DANCE_9456 

:DANCE_9270
if 
  29@ == 2 
jf @DANCE_9334 
" + _9527 + @" = 3 
TIMERA = 0 
00BA: show_text_styled GXT 'DNC_004' time 50000 style 7  
29@ = 1 
jump @DANCE_9456 

:DANCE_9334
if 
  29@ == 1 
jf @DANCE_9398 
" + _9527 + @" = 5 
TIMERA = 0 
00BA: show_text_styled GXT 'DNC_003' time 50000 style 7  
29@ = 0 
jump @DANCE_9456 

:DANCE_9398
if 
  TIMERA >= 10000 
jf @DANCE_9431 
" + _9527 + @" = 5 
TIMERA = 0 

:DANCE_9431
00BA: show_text_styled GXT 'DNC_003' time 50000 style 7  
29@ = 0 

:DANCE_9456
28@ = 0 
26@ = 0 
27@ = 0 

:DANCE_9477
return 

:DANCE_9479
03E4: set_text_draw_align_right 0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 1 
033F: set_text_draw_letter_size 0.5014 1.8889 
081C: draw_text_outline 2 RGBA 0 0 0 255 
if 
  6@ == 3 
jf @DANCE_9569 
0343: set_text_draw_linewidth 240.0 
033E: set_draw_text_position 32.0 32.0 GXT 'DNC_H2'  
jump @DANCE_9615 

:DANCE_9569
if 
   not 6@ == 2 
jf @DANCE_9615 
0343: set_text_draw_linewidth 220.0 
033E: set_draw_text_position 32.0 32.0 GXT 'DNC_H1'  

:DANCE_9615
return 

:DANCE_9617
0871: init_jump_table " + _9528 + @" total_jumps 6 default_jump 0 @DANCE_10043 jumps 0 @DANCE_9680 1 @DANCE_10003 6 @DANCE_9843 8 @DANCE_9883 9 @DANCE_9923 10 @DANCE_9963 -1 @DANCE_10043 

:DANCE_9680
if 
  " + _9527 + @" == 2 
jf @DANCE_9719 
" + _9528 + @" = 6 
" + _9527 + @" = -1 
jump @DANCE_10043 

:DANCE_9719
if 
  " + _9527 + @" == 3 
jf @DANCE_9758 
" + _9528 + @" = 8 
" + _9527 + @" = -1 
jump @DANCE_10043 

:DANCE_9758
if 
  " + _9527 + @" == 4 
jf @DANCE_9797 
" + _9528 + @" = 9 
" + _9527 + @" = -1 
jump @DANCE_10043 

:DANCE_9797
if 
  " + _9527 + @" == 5 
jf @DANCE_9836 
" + _9528 + @" = 10 
" + _9527 + @" = -1 
jump @DANCE_10043 

:DANCE_9836
jump @DANCE_10043 

:DANCE_9843
if 
03D2:   wav 4 ended 
jf @DANCE_9876 
040D: unload_wav 4 
gosub @DANCE_10045 
" + _9528 + @" = 1 

:DANCE_9876
jump @DANCE_10043 

:DANCE_9883
if 
03D2:   wav 4 ended 
jf @DANCE_9916 
040D: unload_wav 4 
gosub @DANCE_11697 
" + _9528 + @" = 1 

:DANCE_9916
jump @DANCE_10043 

:DANCE_9923
if 
03D2:   wav 4 ended 
jf @DANCE_9956 
040D: unload_wav 4 
gosub @DANCE_13349 
" + _9528 + @" = 1 

:DANCE_9956
jump @DANCE_10043 

:DANCE_9963
if 
03D2:   wav 4 ended 
jf @DANCE_9996 
040D: unload_wav 4 
gosub @DANCE_15001 
" + _9528 + @" = 1 

:DANCE_9996
jump @DANCE_10043 

:DANCE_10003
if 
03D0:   wav 4 loaded 
jf @DANCE_10036 
0949: link_wav 4 to_actor " + PlayerActor + @" 
03D1: play_wav 4 
" + _9528 + @" = 0 

:DANCE_10036
jump @DANCE_10043 

:DANCE_10043
return 

:DANCE_10045
0871: init_jump_table " + _9529 + @" total_jumps 56 default_jump 1 @DANCE_10498 jumps 1 @DANCE_10519 2 @DANCE_10540 3 @DANCE_10561 4 @DANCE_10582 5 @DANCE_10603 6 @DANCE_10624 7 @DANCE_10645 
0872: jump_table_jumps 8 @DANCE_10666 9 @DANCE_10687 10 @DANCE_10708 11 @DANCE_10729 12 @DANCE_10750 13 @DANCE_10771 14 @DANCE_10792 15 @DANCE_10813 16 @DANCE_10834 
0872: jump_table_jumps 17 @DANCE_10855 18 @DANCE_10876 19 @DANCE_10897 20 @DANCE_10918 21 @DANCE_10939 22 @DANCE_10960 23 @DANCE_10981 24 @DANCE_11002 25 @DANCE_11023 
0872: jump_table_jumps 26 @DANCE_11044 27 @DANCE_11065 28 @DANCE_11086 29 @DANCE_11107 30 @DANCE_11128 31 @DANCE_11149 32 @DANCE_11170 33 @DANCE_11191 34 @DANCE_11212 
0872: jump_table_jumps 35 @DANCE_11233 36 @DANCE_11254 37 @DANCE_11275 38 @DANCE_11296 39 @DANCE_11317 40 @DANCE_11338 41 @DANCE_11359 42 @DANCE_11380 43 @DANCE_11401 
0872: jump_table_jumps 44 @DANCE_11422 45 @DANCE_11443 46 @DANCE_11464 47 @DANCE_11485 48 @DANCE_11506 49 @DANCE_11527 50 @DANCE_11548 51 @DANCE_11569 52 @DANCE_11590 
0872: jump_table_jumps 53 @DANCE_11611 54 @DANCE_11632 55 @DANCE_11653 56 @DANCE_11674 -1 @DANCE_11695 -1 @DANCE_11695 -1 @DANCE_11695 -1 @DANCE_11695 -1 @DANCE_11695 

:DANCE_10498
03CF: load_wav 11455 as 4 
" + _9529 + @" = 1 
jump @DANCE_11695 

:DANCE_10519
03CF: load_wav 11400 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10540
03CF: load_wav 11401 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10561
03CF: load_wav 11402 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10582
03CF: load_wav 11403 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10603
03CF: load_wav 11404 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10624
03CF: load_wav 11405 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10645
03CF: load_wav 11406 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10666
03CF: load_wav 11407 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10687
03CF: load_wav 11408 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10708
03CF: load_wav 11409 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10729
03CF: load_wav 11410 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10750
03CF: load_wav 11411 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10771
03CF: load_wav 11412 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10792
03CF: load_wav 11413 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10813
03CF: load_wav 11414 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10834
03CF: load_wav 11415 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10855
03CF: load_wav 11416 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10876
03CF: load_wav 11417 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10897
03CF: load_wav 11418 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10918
03CF: load_wav 11419 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10939
03CF: load_wav 11420 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10960
03CF: load_wav 11421 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_10981
03CF: load_wav 11422 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11002
03CF: load_wav 11423 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11023
03CF: load_wav 11424 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11044
03CF: load_wav 11425 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11065
03CF: load_wav 11426 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11086
03CF: load_wav 11427 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11107
03CF: load_wav 11428 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11128
03CF: load_wav 11429 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11149
03CF: load_wav 11430 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11170
03CF: load_wav 11431 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11191
03CF: load_wav 11432 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11212
03CF: load_wav 11433 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11233
03CF: load_wav 11434 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11254
03CF: load_wav 11435 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11275
03CF: load_wav 11436 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11296
03CF: load_wav 11437 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11317
03CF: load_wav 11438 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11338
03CF: load_wav 11439 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11359
03CF: load_wav 11440 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11380
03CF: load_wav 11441 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11401
03CF: load_wav 11442 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11422
03CF: load_wav 11443 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11443
03CF: load_wav 11444 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11464
03CF: load_wav 11445 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11485
03CF: load_wav 11446 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11506
03CF: load_wav 11447 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11527
03CF: load_wav 11448 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11548
03CF: load_wav 11449 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11569
03CF: load_wav 11450 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11590
03CF: load_wav 11451 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11611
03CF: load_wav 11452 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11632
03CF: load_wav 11453 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11653
03CF: load_wav 11454 as 4 
" + _9529 + @" += 1 
jump @DANCE_11695 

:DANCE_11674
03CF: load_wav 11455 as 4 
" + _9529 + @" = 1 
jump @DANCE_11695 

:DANCE_11695
return 

:DANCE_11697
0871: init_jump_table " + _9529 + @" total_jumps 56 default_jump 1 @DANCE_12150 jumps 1 @DANCE_12171 2 @DANCE_12192 3 @DANCE_12213 4 @DANCE_12234 5 @DANCE_12255 6 @DANCE_12276 7 @DANCE_12297 
0872: jump_table_jumps 8 @DANCE_12318 9 @DANCE_12339 10 @DANCE_12360 11 @DANCE_12381 12 @DANCE_12402 13 @DANCE_12423 14 @DANCE_12444 15 @DANCE_12465 16 @DANCE_12486 
0872: jump_table_jumps 17 @DANCE_12507 18 @DANCE_12528 19 @DANCE_12549 20 @DANCE_12570 21 @DANCE_12591 22 @DANCE_12612 23 @DANCE_12633 24 @DANCE_12654 25 @DANCE_12675 
0872: jump_table_jumps 26 @DANCE_12696 27 @DANCE_12717 28 @DANCE_12738 29 @DANCE_12759 30 @DANCE_12780 31 @DANCE_12801 32 @DANCE_12822 33 @DANCE_12843 34 @DANCE_12864 
0872: jump_table_jumps 35 @DANCE_12885 36 @DANCE_12906 37 @DANCE_12927 38 @DANCE_12948 39 @DANCE_12969 40 @DANCE_12990 41 @DANCE_13011 42 @DANCE_13032 43 @DANCE_13053 
0872: jump_table_jumps 44 @DANCE_13074 45 @DANCE_13095 46 @DANCE_13116 47 @DANCE_13137 48 @DANCE_13158 49 @DANCE_13179 50 @DANCE_13200 51 @DANCE_13221 52 @DANCE_13242 
0872: jump_table_jumps 53 @DANCE_13263 54 @DANCE_13284 55 @DANCE_13305 56 @DANCE_13326 -1 @DANCE_13347 -1 @DANCE_13347 -1 @DANCE_13347 -1 @DANCE_13347 -1 @DANCE_13347 

:DANCE_12150
03CF: load_wav 11655 as 4 
" + _9529 + @" = 1 
jump @DANCE_13347 

:DANCE_12171
03CF: load_wav 11600 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12192
03CF: load_wav 11601 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12213
03CF: load_wav 11602 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12234
03CF: load_wav 11603 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12255
03CF: load_wav 11604 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12276
03CF: load_wav 11605 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12297
03CF: load_wav 11606 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12318
03CF: load_wav 11607 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12339
03CF: load_wav 11608 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12360
03CF: load_wav 11609 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12381
03CF: load_wav 11610 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12402
03CF: load_wav 11611 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12423
03CF: load_wav 11612 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12444
03CF: load_wav 11613 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12465
03CF: load_wav 11614 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12486
03CF: load_wav 11615 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12507
03CF: load_wav 11616 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12528
03CF: load_wav 11617 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12549
03CF: load_wav 11618 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12570
03CF: load_wav 11619 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12591
03CF: load_wav 11620 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12612
03CF: load_wav 11621 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12633
03CF: load_wav 11622 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12654
03CF: load_wav 11623 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12675
03CF: load_wav 11624 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12696
03CF: load_wav 11625 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12717
03CF: load_wav 11626 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12738
03CF: load_wav 11627 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12759
03CF: load_wav 11628 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12780
03CF: load_wav 11629 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12801
03CF: load_wav 11630 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12822
03CF: load_wav 11631 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12843
03CF: load_wav 11632 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12864
03CF: load_wav 11633 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12885
03CF: load_wav 11634 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12906
03CF: load_wav 11635 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12927
03CF: load_wav 11636 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12948
03CF: load_wav 11637 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12969
03CF: load_wav 11638 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_12990
03CF: load_wav 11639 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13011
03CF: load_wav 11640 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13032
03CF: load_wav 11641 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13053
03CF: load_wav 11642 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13074
03CF: load_wav 11643 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13095
03CF: load_wav 11644 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13116
03CF: load_wav 11645 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13137
03CF: load_wav 11646 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13158
03CF: load_wav 11647 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13179
03CF: load_wav 11648 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13200
03CF: load_wav 11649 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13221
03CF: load_wav 11650 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13242
03CF: load_wav 11651 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13263
03CF: load_wav 11652 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13284
03CF: load_wav 11653 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13305
03CF: load_wav 11654 as 4 
" + _9529 + @" += 1 
jump @DANCE_13347 

:DANCE_13326
03CF: load_wav 11655 as 4 
" + _9529 + @" = 1 
jump @DANCE_13347 

:DANCE_13347
return 

:DANCE_13349
0871: init_jump_table " + _9529 + @" total_jumps 56 default_jump 1 @DANCE_13802 jumps 1 @DANCE_13823 2 @DANCE_13844 3 @DANCE_13865 4 @DANCE_13886 5 @DANCE_13907 6 @DANCE_13928 7 @DANCE_13949 
0872: jump_table_jumps 8 @DANCE_13970 9 @DANCE_13991 10 @DANCE_14012 11 @DANCE_14033 12 @DANCE_14054 13 @DANCE_14075 14 @DANCE_14096 15 @DANCE_14117 16 @DANCE_14138 
0872: jump_table_jumps 17 @DANCE_14159 18 @DANCE_14180 19 @DANCE_14201 20 @DANCE_14222 21 @DANCE_14243 22 @DANCE_14264 23 @DANCE_14285 24 @DANCE_14306 25 @DANCE_14327 
0872: jump_table_jumps 26 @DANCE_14348 27 @DANCE_14369 28 @DANCE_14390 29 @DANCE_14411 30 @DANCE_14432 31 @DANCE_14453 32 @DANCE_14474 33 @DANCE_14495 34 @DANCE_14516 
0872: jump_table_jumps 35 @DANCE_14537 36 @DANCE_14558 37 @DANCE_14579 38 @DANCE_14600 39 @DANCE_14621 40 @DANCE_14642 41 @DANCE_14663 42 @DANCE_14684 43 @DANCE_14705 
0872: jump_table_jumps 44 @DANCE_14726 45 @DANCE_14747 46 @DANCE_14768 47 @DANCE_14789 48 @DANCE_14810 49 @DANCE_14831 50 @DANCE_14852 51 @DANCE_14873 52 @DANCE_14894 
0872: jump_table_jumps 53 @DANCE_14915 54 @DANCE_14936 55 @DANCE_14957 56 @DANCE_14978 -1 @DANCE_14999 -1 @DANCE_14999 -1 @DANCE_14999 -1 @DANCE_14999 -1 @DANCE_14999 

:DANCE_13802
03CF: load_wav 11855 as 4 
" + _9529 + @" = 1 
jump @DANCE_14999 

:DANCE_13823
03CF: load_wav 11800 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13844
03CF: load_wav 11801 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13865
03CF: load_wav 11802 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13886
03CF: load_wav 11803 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13907
03CF: load_wav 11804 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13928
03CF: load_wav 11805 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13949
03CF: load_wav 11806 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13970
03CF: load_wav 11807 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_13991
03CF: load_wav 11808 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14012
03CF: load_wav 11809 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14033
03CF: load_wav 11810 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14054
03CF: load_wav 11811 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14075
03CF: load_wav 11812 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14096
03CF: load_wav 11813 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14117
03CF: load_wav 11814 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14138
03CF: load_wav 11815 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14159
03CF: load_wav 11816 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14180
03CF: load_wav 11817 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14201
03CF: load_wav 11818 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14222
03CF: load_wav 11819 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14243
03CF: load_wav 11820 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14264
03CF: load_wav 11821 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14285
03CF: load_wav 11822 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14306
03CF: load_wav 11823 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14327
03CF: load_wav 11824 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14348
03CF: load_wav 11825 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14369
03CF: load_wav 11826 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14390
03CF: load_wav 11827 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14411
03CF: load_wav 11828 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14432
03CF: load_wav 11829 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14453
03CF: load_wav 11830 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14474
03CF: load_wav 11831 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14495
03CF: load_wav 11832 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14516
03CF: load_wav 11833 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14537
03CF: load_wav 11834 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14558
03CF: load_wav 11835 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14579
03CF: load_wav 11836 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14600
03CF: load_wav 11837 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14621
03CF: load_wav 11838 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14642
03CF: load_wav 11839 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14663
03CF: load_wav 11840 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14684
03CF: load_wav 11841 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14705
03CF: load_wav 11842 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14726
03CF: load_wav 11843 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14747
03CF: load_wav 11844 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14768
03CF: load_wav 11845 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14789
03CF: load_wav 11846 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14810
03CF: load_wav 11847 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14831
03CF: load_wav 11848 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14852
03CF: load_wav 11849 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14873
03CF: load_wav 11850 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14894
03CF: load_wav 11851 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14915
03CF: load_wav 11852 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14936
03CF: load_wav 11853 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14957
03CF: load_wav 11854 as 4 
" + _9529 + @" += 1 
jump @DANCE_14999 

:DANCE_14978
03CF: load_wav 11855 as 4 
" + _9529 + @" = 1 
jump @DANCE_14999 

:DANCE_14999
return 

:DANCE_15001
0871: init_jump_table " + _9529 + @" total_jumps 56 default_jump 1 @DANCE_15454 jumps 1 @DANCE_15475 2 @DANCE_15496 3 @DANCE_15517 4 @DANCE_15538 5 @DANCE_15559 6 @DANCE_15580 7 @DANCE_15601 
0872: jump_table_jumps 8 @DANCE_15622 9 @DANCE_15643 10 @DANCE_15664 11 @DANCE_15685 12 @DANCE_15706 13 @DANCE_15727 14 @DANCE_15748 15 @DANCE_15769 16 @DANCE_15790 
0872: jump_table_jumps 17 @DANCE_15811 18 @DANCE_15832 19 @DANCE_15853 20 @DANCE_15874 21 @DANCE_15895 22 @DANCE_15916 23 @DANCE_15937 24 @DANCE_15958 25 @DANCE_15979 
0872: jump_table_jumps 26 @DANCE_16000 27 @DANCE_16021 28 @DANCE_16042 29 @DANCE_16063 30 @DANCE_16084 31 @DANCE_16105 32 @DANCE_16126 33 @DANCE_16147 34 @DANCE_16168 
0872: jump_table_jumps 35 @DANCE_16189 36 @DANCE_16210 37 @DANCE_16231 38 @DANCE_16252 39 @DANCE_16273 40 @DANCE_16294 41 @DANCE_16315 42 @DANCE_16336 43 @DANCE_16357 
0872: jump_table_jumps 44 @DANCE_16378 45 @DANCE_16399 46 @DANCE_16420 47 @DANCE_16441 48 @DANCE_16462 49 @DANCE_16483 50 @DANCE_16504 51 @DANCE_16525 52 @DANCE_16546 
0872: jump_table_jumps 53 @DANCE_16567 54 @DANCE_16588 55 @DANCE_16609 56 @DANCE_16630 -1 @DANCE_16651 -1 @DANCE_16651 -1 @DANCE_16651 -1 @DANCE_16651 -1 @DANCE_16651 

:DANCE_15454
03CF: load_wav 12055 as 4 
" + _9529 + @" = 1 
jump @DANCE_16651 

:DANCE_15475
03CF: load_wav 12000 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15496
03CF: load_wav 12001 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15517
03CF: load_wav 12002 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15538
03CF: load_wav 12003 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15559
03CF: load_wav 12004 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15580
03CF: load_wav 12005 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15601
03CF: load_wav 12006 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15622
03CF: load_wav 12007 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15643
03CF: load_wav 12008 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15664
03CF: load_wav 12009 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15685
03CF: load_wav 12010 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15706
03CF: load_wav 12011 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15727
03CF: load_wav 12012 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15748
03CF: load_wav 12013 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15769
03CF: load_wav 12014 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15790
03CF: load_wav 12015 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15811
03CF: load_wav 12016 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15832
03CF: load_wav 12017 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15853
03CF: load_wav 12018 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15874
03CF: load_wav 12019 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15895
03CF: load_wav 12020 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15916
03CF: load_wav 12021 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15937
03CF: load_wav 12022 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15958
03CF: load_wav 12023 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_15979
03CF: load_wav 12024 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16000
03CF: load_wav 12025 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16021
03CF: load_wav 12026 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16042
03CF: load_wav 12027 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16063
03CF: load_wav 12028 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16084
03CF: load_wav 12029 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16105
03CF: load_wav 12030 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16126
03CF: load_wav 12031 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16147
03CF: load_wav 12032 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16168
03CF: load_wav 12033 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16189
03CF: load_wav 12034 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16210
03CF: load_wav 12035 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16231
03CF: load_wav 12036 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16252
03CF: load_wav 12037 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16273
03CF: load_wav 12038 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16294
03CF: load_wav 12039 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16315
03CF: load_wav 12040 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16336
03CF: load_wav 12041 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16357
03CF: load_wav 12042 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16378
03CF: load_wav 12043 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16399
03CF: load_wav 12044 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16420
03CF: load_wav 12045 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16441
03CF: load_wav 12046 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16462
03CF: load_wav 12047 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16483
03CF: load_wav 12048 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16504
03CF: load_wav 12049 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16525
03CF: load_wav 12050 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16546
03CF: load_wav 12051 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16567
03CF: load_wav 12052 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16588
03CF: load_wav 12053 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16609
03CF: load_wav 12054 as 4 
" + _9529 + @" += 1 
jump @DANCE_16651 

:DANCE_16630
03CF: load_wav 12055 as 4 
" + _9529 + @" = 1 
jump @DANCE_16651 

:DANCE_16651
return 

:DANCE_16653
" + _1044 + @" = 1 
" + _5298 + @" = 0 
04EF: release_animation " + DANCE_ANIM_IFP + @" 
00BE: text_clear_all 
if 
   not Actor.Dead(5@)
jf @DANCE_16767 
if and
   not Actor.Model(5@) == #GANGRL3
   not Actor.Model(5@) == #MECGRL3
   not Actor.Model(5@) == #GUNGRL3
   not Actor.Model(5@) == #COPGRL3
   not Actor.Model(5@) == #NURGRL3
   not Actor.Model(5@) == #CROGRL3
jf @DANCE_16767 
0665: get_actor 5@ model_to 13@ 
Model.Destroy(13@)
Actor.DestroyInstantly(5@)

:DANCE_16767
0953: get_soundtrack_status_to 13@ 
if 
04A4:   13@ == 3 
jf @DANCE_16792 
0955: end_playing_loaded_soundtrack 

:DANCE_16792
13@ = 0 

:DANCE_16799
" + tmp_5315 + @"(13@,5f) = 0.0 
" + tmp_5320 + @"(13@,5f) = 0.0 
" + tmp_5325 + @"(13@,5f) = 0.0 
" + tmp_5330 + @"(13@,5f) = 0.0 
" + tmp_5335 + @"(13@,5f) = 0.0 
" + tmp_5340 + @"(13@,5f) = 0.0 
13@ += 1 
  13@ >= 5 
jf @DANCE_16799 
09EE: set_status_text_stay_on_screen 0 
03F0: enable_text_draw 0 
if 
  " + DANCE_SCORE + @" >= 0 
jf @DANCE_16938 
0629: change_integer_stat 156 to " + DANCE_SCORE + @" 

:DANCE_16938
040D: unload_wav 4 
Player.CanMove(" + PlayerChar + @") = True
08C0: clear " + _5295 + @" bit 31 
09BD: allow_other_threads_to_display_text_boxes 0 
end_thread 
return 

:DANCE_16964
0494: get_joystick 0 direction_offset_to " + _9530 + @" " + _9531 + @" " + _9532 + @" " + _9533 + @" 
008D: " + _9535 + @" = integer " + _9530 + @" to_float 
0086: " + _9536 + @" = " + _9535 + @" 
008D: " + _9535 + @" = integer " + _9531 + @" to_float 
0086: " + _9537 + @" = " + _9535 + @" 
0509: " + _9535 + @" = distance_between_XY 0.0 0.0 and_XY " + _9536 + @" " + _9537 + @" 
" + _9534 + @" = 0 
if 
  " + _9535 + @" > 64.0 
jf @DANCE_17325 
05A4: get_angle_between_vectors_origin_to " + _9536 + @" " + _9537 + @" and_origin_to 0.0 -1.0 store_to " + _9535 + @" 
if 
  15.0 > " + _9535 + @" 
jf @DANCE_17117 
" + _9534 + @" = 13 
jump @DANCE_17325 

:DANCE_17117
if 
  75.0 > " + _9535 + @" 
jf @DANCE_17184 
if 
  " + _9530 + @" > 0 
jf @DANCE_17170 
" + _9534 + @" = 11 
jump @DANCE_17177 

:DANCE_17170
" + _9534 + @" = 15 

:DANCE_17177
jump @DANCE_17325 

:DANCE_17184
if 
  105.0 > " + _9535 + @" 
jf @DANCE_17251 
if 
  " + _9530 + @" > 0 
jf @DANCE_17237 
" + _9534 + @" = 10 
jump @DANCE_17244 

:DANCE_17237
" + _9534 + @" = 9 

:DANCE_17244
jump @DANCE_17325 

:DANCE_17251
if 
  165.0 > " + _9535 + @" 
jf @DANCE_17318 
if 
  " + _9530 + @" > 0 
jf @DANCE_17304 
" + _9534 + @" = 16 
jump @DANCE_17311 

:DANCE_17304
" + _9534 + @" = 12 

:DANCE_17311
jump @DANCE_17325 

:DANCE_17318
" + _9534 + @" = 14 

:DANCE_17325
return 
0662: printstring " + DANCE_ANIM + @" 
07B1: unknown_get_dance_track 1 store_to 13@ 13@ 13@ 
0663: printint ""NEXT_BEAT_NUMBER"" 13@ 
return 
end_thread" );
            }

        }

    }

}