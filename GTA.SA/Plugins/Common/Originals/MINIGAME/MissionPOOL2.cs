using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class POOL2 : MissionCustom {

            Int _local164 = local( 164 ),
                _local39 = local( 39 );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @POOL2_47 
if 
wasted_or_busted 
else_jump @POOL2_38 
gosub @POOL2_60776 

:POOL2_38
gosub @POOL2_60828 
end_thread 

:POOL2_47
increment_mission_attempts 
" + OnMission + @" = 1 
01BD: 181@ = current_time_in_ms 
34@ = 0 
35@ = 0 
37@ = 0 
38@ = 0 
178@ = 0 
208@ = -0.957 
210@ = -0.49 
209@ = 0.957 
211@ = 0.49 
203@ = 0.05 
204@ = 2.0 
127@ = 1 

:POOL2_163
wait 0 
01BD: 39@ = current_time_in_ms 
0085: 182@ = 39@ 
0062: 182@ -= 181@ 
0085: 181@ = 39@ 
005A: 183@ += 182@ 
005A: 205@ += 182@ 
005A: 206@ += 182@ 
gosub @POOL2_2290 

:POOL2_227
0871: init_jump_table 34@ total_jumps 13 default_jump 0 @POOL2_537 jumps 0 @POOL2_355 1 @POOL2_369 2 @POOL2_383 3 @POOL2_397 4 @POOL2_411 5 @POOL2_425 6 @POOL2_439 
0872: jump_table_jumps 7 @POOL2_453 8 @POOL2_467 9 @POOL2_481 10 @POOL2_495 11 @POOL2_509 12 @POOL2_523 -1 @POOL2_537 -1 @POOL2_537 -1 @POOL2_537 

:POOL2_355
gosub @POOL2_680 
jump @POOL2_537 

:POOL2_369
gosub @POOL2_5410 
jump @POOL2_537 

:POOL2_383
gosub @POOL2_8958 
jump @POOL2_537 

:POOL2_397
gosub @POOL2_9675 
jump @POOL2_537 

:POOL2_411
gosub @POOL2_10505 
jump @POOL2_537 

:POOL2_425
gosub @POOL2_12137 
jump @POOL2_537 

:POOL2_439
gosub @POOL2_15511 
jump @POOL2_537 

:POOL2_453
gosub @POOL2_15513 
jump @POOL2_537 

:POOL2_467
gosub @POOL2_20853 
jump @POOL2_537 

:POOL2_481
gosub @POOL2_21376 
jump @POOL2_537 

:POOL2_495
gosub @POOL2_22768 
jump @POOL2_537 

:POOL2_509
gosub @POOL2_24866 
jump @POOL2_537 

:POOL2_523
gosub @POOL2_26060 
jump @POOL2_537 

:POOL2_537
if 
803B:   not  179@ == 34@ 
else_jump @POOL2_571 
0085: 179@ = 34@ 
jump @POOL2_227 

:POOL2_571
gosub @POOL2_26186 
if 
  108@ == 0 
else_jump @POOL2_678 
if 
  38@ == 0 
else_jump @POOL2_662 
if 
  37@ == 0 
else_jump @POOL2_646 
jump @POOL2_163 
jump @POOL2_655 

:POOL2_646
gosub @POOL2_60794 
return 

:POOL2_655
jump @POOL2_671 

:POOL2_662
gosub @POOL2_60776 
return 

:POOL2_671
jump @POOL2_680 

:POOL2_678
return 

:POOL2_680
if 
  35@ == -1 
else_jump @POOL2_972 
163@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + _9457 + @" = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
164@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
" + _9458 + @" = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
168@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
358@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
359@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
82@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + _9459 + @" = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
347@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
213@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
214@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)

:POOL2_972
if 
  35@ == 0 
else_jump @POOL2_1158 
if 
03CA:   object " + _9457 + @" exists 
else_jump @POOL2_1158 
008B: 163@ = " + _9457 + @" 
008B: 164@ = " + _9458 + @" 
if 
   not Actor.Dead(164@)
else_jump @POOL2_1082 
02A9: set_actor 164@ immune_to_nonplayer 1 
Actor.SetImmunities(164@, 1, 1, 1, 1, 1)
0619: enable_actor 164@ collision_detection 0 
060A: create_decision_maker_type 0 store_to 207@ 
060B: set_actor 164@ decision_maker_to 207@ 

:POOL2_1082
Object.StorePos(163@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 1 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 100.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
041D: set_camera_near_clip 0.01 
08F5: save_player_group 
129@ = 0 
108@ = 0 
gosub @POOL2_57818 
35@ += 1 

:POOL2_1158
if 
  35@ == 1 
else_jump @POOL2_1336 
if 
03CA:   object 163@ exists 
else_jump @POOL2_1336 
Object.StorePos(163@, 102@, 103@, 104@)
105@ = Object.Angle(163@)
104@ += -0.1 
054C: use_GXT_table 'POOL' 
03CF: load_wav 1802 as 4 
Model.Load(#K_POOLQ)
04ED: load_animation ""POOL"" 

:POOL2_1254
if or
84EE:   not animation ""POOL"" loaded 
   not Model.Available(#K_POOLQ)
83D0:   not wav 4 loaded 
else_jump @POOL2_1292 
wait 0 
jump @POOL2_1254 

:POOL2_1292
0390: load_txd_dictionary 'LD_POOL' 
038F: load_texture ""BALL"" as 1 
038F: load_texture ""NIB"" as 2 
125@ = 0 
35@ += 1 

:POOL2_1336
if 
  35@ == 2 
else_jump @POOL2_1368 
34@ += 1 
35@ = 0 

:POOL2_1368
return 
0052: NOP 98@ 100@ " + tempvar_Float_3 + @" 99@ 100@ " + tempvar_Float_3 + @" 
0052: NOP 98@ 100@ " + tempvar_Float_3 + @" 98@ 101@ " + tempvar_Float_3 + @" 
0052: NOP 99@ 101@ " + tempvar_Float_3 + @" 99@ 100@ " + tempvar_Float_3 + @" 
0052: NOP 99@ 101@ " + tempvar_Float_3 + @" 98@ 101@ " + tempvar_Float_3 + @" 
if 
0736:   is_keyboard_key_just_pressed 129 
else_jump @POOL2_1476 
208@ += -0.0001 

:POOL2_1476
if 
0736:   is_keyboard_key_just_pressed 128 
else_jump @POOL2_1502 
208@ += 0.0001 

:POOL2_1502
if 
0736:   is_keyboard_key_just_pressed 131 
else_jump @POOL2_1528 
210@ += -0.0001 

:POOL2_1528
if 
0736:   is_keyboard_key_just_pressed 130 
else_jump @POOL2_1554 
210@ += 0.0001 

:POOL2_1554
if 
0736:   is_keyboard_key_just_pressed 141 
else_jump @POOL2_1580 
209@ += -0.0001 

:POOL2_1580
if 
0736:   is_keyboard_key_just_pressed 143 
else_jump @POOL2_1606 
209@ += 0.0001 

:POOL2_1606
if 
0736:   is_keyboard_key_just_pressed 139 
else_jump @POOL2_1632 
211@ += -0.0001 

:POOL2_1632
if 
0736:   is_keyboard_key_just_pressed 145 
else_jump @POOL2_1658 
211@ += 0.0001 

:POOL2_1658
if 
0736:   is_keyboard_key_just_pressed 137 
else_jump @POOL2_2222 
03A9: save_newline_to_debug_file 
05B6: 13 
03A8: save_float_to_debug_file 208@ 
03A9: save_newline_to_debug_file 
05B6: 14 
03A8: save_float_to_debug_file 210@ 
03A9: save_newline_to_debug_file 
05B6: 15 
03A8: save_float_to_debug_file 209@ 
03A9: save_newline_to_debug_file 
05B6: 16 
03A8: save_float_to_debug_file 211@ 

:POOL2_2222
if 
03CA:   object 163@ exists 
else_jump @POOL2_2288 
0400: store_coords_to 98@ 100@ " + tempvar_Float_3 + @" from_object 163@ with_offset 208@ 210@ 0.7 
0400: store_coords_to 99@ 101@ " + tempvar_Float_3 + @" from_object 163@ with_offset 209@ 211@ 0.7 

:POOL2_2288
return 

:POOL2_2290
if 
0736:   is_keyboard_key_just_pressed 32 
else_jump @POOL2_2339 
212@ += 1 
if 
  212@ > 11 
else_jump @POOL2_2337 
212@ = 0 

:POOL2_2337
086A: NOP 

:POOL2_2339
if 
  212@ == 1 
else_jump @POOL2_2556 
008A: " + _6443 + @" = 34@ 
008A: " + _6444 + @" = 35@ 
008A: " + _6445 + @" = 36@ 
008A: " + _6446 + @" = 108@ 
008A: " + _6447 + @" = 125@ 
008A: " + _6448 + @" = 129@ 
008A: " + _6449 + @" = 217@ 
008A: " + _6450 + @" = 218@ 
065D: NOP " + _6443 + @" ""M_STAGE"" 
065D: NOP " + _6444 + @" ""M_GOALS"" 
065D: NOP " + _6445 + @" ""FLAG3"" 
065D: NOP " + _6446 + @" ""QUIT"" 
065D: NOP " + _6447 + @" ""PL_CIRCLE_PRESSED"" 
065D: NOP " + _6448 + @" ""OUTPUT_TEXT"" 
065D: NOP " + _6449 + @" ""PLAYER1_COLOUR"" 
065D: NOP " + _6450 + @" ""PLAYER2_COLOUR"" 

:POOL2_2556
if 
  212@ == 2 
else_jump @POOL2_2806 
008A: " + _6443 + @" = 66@ 
008A: " + _6444 + @" = 67@ 
008A: " + _6445 + @" = 68@ 
008A: " + _6446 + @" = 69@ 
008A: " + _6447 + @" = 70@ 
008A: " + _6448 + @" = 71@ 
008A: " + _6449 + @" = 72@ 
008A: " + _6450 + @" = 73@ 
065D: NOP " + _6443 + @" ""BALL_POTTED[0]"" 
065D: NOP " + _6444 + @" ""BALL_POTTED[1]"" 
065D: NOP " + _6445 + @" ""BALL_POTTED[2]"" 
065D: NOP " + _6446 + @" ""BALL_POTTED[3]"" 
065D: NOP " + _6447 + @" ""BALL_POTTED[4]"" 
065D: NOP " + _6448 + @" ""BALL_POTTED[5]"" 
065D: NOP " + _6449 + @" ""BALL_POTTED[6]"" 
065D: NOP " + _6450 + @" ""BALL_POTTED[7]"" 

:POOL2_2806
if 
  212@ == 3 
else_jump @POOL2_3062 
008A: " + _6443 + @" = 74@ 
008A: " + _6444 + @" = 75@ 
008A: " + _6445 + @" = 76@ 
008A: " + _6446 + @" = 77@ 
008A: " + _6447 + @" = 78@ 
008A: " + _6448 + @" = 79@ 
008A: " + _6449 + @" = 80@ 
008A: " + _6450 + @" = 81@ 
065D: NOP " + _6443 + @" ""BALL_POTTED[8]"" 
065D: NOP " + _6444 + @" ""BALL_POTTED[9]"" 
065D: NOP " + _6445 + @" ""BALL_POTTED[10]"" 
065D: NOP " + _6446 + @" ""BALL_POTTED[11]"" 
065D: NOP " + _6447 + @" ""BALL_POTTED[12]"" 
065D: NOP " + _6448 + @" ""BALL_POTTED[13]"" 
065D: NOP " + _6449 + @" ""BALL_POTTED[14]"" 
065D: NOP " + _6450 + @" ""BALL_POTTED[15]"" 

:POOL2_3062
if 
  212@ == 4 
else_jump @POOL2_3319 
008A: " + _6443 + @" = 219@ 
008A: " + _6444 + @" = 220@ 
008A: " + _6445 + @" = 229@ 
008A: " + _6446 + @" = 230@ 
008A: " + _6447 + @" = 231@ 
008A: " + _6448 + @" = 232@ 
008A: " + _6449 + @" = 251@ 
008A: " + _6450 + @" = 250@ 
065D: NOP " + _6443 + @" ""PLAYER1_IS_HUMAN"" 
065D: NOP " + _6444 + @" ""PLAYER2_IS_HUMAN"" 
065D: NOP " + _6445 + @" ""TURN_PLAYER"" 
065D: NOP " + _6446 + @" ""CURRENT_CHAR_IS_HUMAN"" 
065D: NOP " + _6447 + @" ""TURN_COLOUR"" 
065D: NOP " + _6448 + @" ""TURN_IS_SCRATCH"" 
065D: NOP " + _6449 + @" ""THIS_CHAR_GOT_TASK"" 
065D: NOP " + _6450 + @" ""SHOT_PLAYED"" 

:POOL2_3319
if 
  212@ == 5 
else_jump @POOL2_3547 
008A: " + _6444 + @" = 233@ 
008A: " + _6445 + @" = 271@ 
008A: " + _6446 + @" = 272@ 
008A: " + _6447 + @" = 273@ 
008A: " + _6448 + @" = 274@ 
008A: " + _6449 + @" = 278@ 
008A: " + _6450 + @" = 236@ 
065D: NOP " + _6444 + @" ""SKIP_CHALK_CUE"" 
065D: NOP " + _6445 + @" ""NO_OF_BALLS_POTTED_THIS_TURN"" 
065D: NOP " + _6446 + @" ""SPOTS_POTTED"" 
065D: NOP " + _6447 + @" ""STRIPES_POTTED"" 
065D: NOP " + _6448 + @" ""FOUL_TYPE"" 
065D: NOP " + _6449 + @" ""FIRST_MOVING_BALL"" 
065D: NOP " + _6450 + @" ""CAMERA_MODE"" 

:POOL2_3547
if 
  212@ == 6 
else_jump @POOL2_3885 
008A: " + _6443 + @" = 255@ 
008A: " + _6444 + @" = 256@ 
008A: " + _6445 + @" = 257@ 
008A: " + _6446 + @" = 258@ 
008A: " + _6447 + @" = 259@ 
008A: " + _6448 + @" = 260@ 
008A: " + _6449 + @" = 261@ 
008A: " + _6450 + @" = 262@ 
065D: NOP " + _6443 + @" ""BALLS_POTTED_THIS_TURN[0]"" 
065D: NOP " + _6444 + @" ""BALLS_POTTED_THIS_TURN[1]"" 
065D: NOP " + _6445 + @" ""BALLS_POTTED_THIS_TURN[2]"" 
065D: NOP " + _6446 + @" ""BALLS_POTTED_THIS_TURN[3]"" 
065D: NOP " + _6447 + @" ""BALLS_POTTED_THIS_TURN[4]"" 
065D: NOP " + _6448 + @" ""BALLS_POTTED_THIS_TURN[5]"" 
065D: NOP " + _6449 + @" ""BALLS_POTTED_THIS_TURN[6]"" 
065D: NOP " + _6450 + @" ""BALLS_POTTED_THIS_TURN[7]"" 

:POOL2_3885
if 
  212@ == 7 
else_jump @POOL2_4229 
008A: " + _6443 + @" = 263@ 
008A: " + _6444 + @" = 264@ 
008A: " + _6445 + @" = 265@ 
008A: " + _6446 + @" = 266@ 
008A: " + _6447 + @" = 267@ 
008A: " + _6448 + @" = 268@ 
008A: " + _6449 + @" = 269@ 
008A: " + _6450 + @" = 270@ 
065D: NOP " + _6443 + @" ""BALLS_POTTED_THIS_TURN[8]"" 
065D: NOP " + _6444 + @" ""BALLS_POTTED_THIS_TURN[9]"" 
065D: NOP " + _6445 + @" ""BALLS_POTTED_THIS_TURN[10]"" 
065D: NOP " + _6446 + @" ""BALLS_POTTED_THIS_TURN[11]"" 
065D: NOP " + _6447 + @" ""BALLS_POTTED_THIS_TURN[12]"" 
065D: NOP " + _6448 + @" ""BALLS_POTTED_THIS_TURN[13]"" 
065D: NOP " + _6449 + @" ""BALLS_POTTED_THIS_TURN[14]"" 
065D: NOP " + _6450 + @" ""BALLS_POTTED_THIS_TURN[15]"" 

:POOL2_4229
if 
  212@ == 8 
else_jump @POOL2_4535 
008A: " + _6443 + @" = 109@ 
008A: " + _6444 + @" = 110@ 
008A: " + _6445 + @" = 111@ 
008A: " + _6446 + @" = 112@ 
008A: " + _6447 + @" = 113@ 
008A: " + _6448 + @" = 114@ 
008A: " + _6449 + @" = 115@ 
008A: " + _6450 + @" = 116@ 
065D: NOP " + _6443 + @" ""BALL_IS_STATIONARY[0]"" 
065D: NOP " + _6444 + @" ""BALL_IS_STATIONARY[1]"" 
065D: NOP " + _6445 + @" ""BALL_IS_STATIONARY[2]"" 
065D: NOP " + _6446 + @" ""BALL_IS_STATIONARY[3]"" 
065D: NOP " + _6447 + @" ""BALL_IS_STATIONARY[4]"" 
065D: NOP " + _6448 + @" ""BALL_IS_STATIONARY[5]"" 
065D: NOP " + _6449 + @" ""BALL_IS_STATIONARY[6]"" 
065D: NOP " + _6450 + @" ""BALL_IS_STATIONARY[7]"" 

:POOL2_4535
if 
  212@ == 9 
else_jump @POOL2_4847 
008A: " + _6443 + @" = 117@ 
008A: " + _6444 + @" = 118@ 
008A: " + _6445 + @" = 119@ 
008A: " + _6446 + @" = 120@ 
008A: " + _6447 + @" = 121@ 
008A: " + _6448 + @" = 122@ 
008A: " + _6449 + @" = 123@ 
008A: " + _6450 + @" = 124@ 
065D: NOP " + _6443 + @" ""BALL_IS_STATIONARY[8]"" 
065D: NOP " + _6444 + @" ""BALL_IS_STATIONARY[9]"" 
065D: NOP " + _6445 + @" ""BALL_IS_STATIONARY[10]"" 
065D: NOP " + _6446 + @" ""BALL_IS_STATIONARY[11]"" 
065D: NOP " + _6447 + @" ""BALL_IS_STATIONARY[12]"" 
065D: NOP " + _6448 + @" ""BALL_IS_STATIONARY[13]"" 
065D: NOP " + _6449 + @" ""BALL_IS_STATIONARY[14]"" 
065D: NOP " + _6450 + @" ""BALL_IS_STATIONARY[15]"" 

:POOL2_4847
if 
  212@ == 10 
else_jump @POOL2_5105 
0088: " + _6451 + @" = 48@ 
0088: " + _6452 + @" = 49@ 
0088: " + _6453 + @" = 50@ 
0088: " + _6454 + @" = 51@ 
0088: " + _6455 + @" = 98@ 
0088: " + _6456 + @" = 99@ 
0088: " + _6457 + @" = 100@ 
0088: " + _6458 + @" = 101@ 
065E: NOP " + _6451 + @" ""CUE_BALL_SPEED"" 
065E: NOP " + _6452 + @" ""CUE_BALL_ROT_X"" 
065E: NOP " + _6453 + @" ""CUE_BALL_ROT_Y"" 
065E: NOP " + _6454 + @" ""CUE_BALL_ROT_Z"" 
065E: NOP " + _6455 + @" ""POOL_TABLE_MIN_X"" 
065E: NOP " + _6456 + @" ""POOL_TABLE_MAX_X"" 
065E: NOP " + _6457 + @" ""POOL_TABLE_MIN_Y"" 
065E: NOP " + _6458 + @" ""POOL_TABLE_MAX_Y"" 

:POOL2_5105
if 
  212@ == 11 
else_jump @POOL2_5304 
008A: " + _6443 + @" = 32@ 
008A: " + _6444 + @" = 33@ 
0088: " + _6453 + @" = 650@ 
0088: " + _6454 + @" = 203@ 
0088: " + _6455 + @" = 204@ 
008A: " + _6448 + @" = 277@ 
065D: NOP " + _6443 + @" ""TIMERA"" 
065D: NOP " + _6444 + @" ""TIMERB"" 
065E: NOP " + _6453 + @" ""BALL_TURN_MASS"" 
065E: NOP " + _6454 + @" ""POOL_STOP_VELOCITY"" 
065E: NOP " + _6455 + @" ""POOL_STOP_ROTATION_VELOCITY"" 
065D: NOP " + _6448 + @" ""BALL_STRIKES_CUSHION"" 

:POOL2_5304
if 
0736:   is_keyboard_key_just_pressed 65 
else_jump @POOL2_5408 
if 
  219@ == 1 
else_jump @POOL2_5378 
219@ = 0 
0662: printstring ""CHEAT_PLAYER1_NOT_HUMAN"" 
jump @POOL2_5408 

:POOL2_5378
219@ = 1 
0662: printstring ""CHEAT_PLAYER1_HUMAN"" 

:POOL2_5408
return 

:POOL2_5410
if 
  35@ == -1 
else_jump @POOL2_5450 
107@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)

:POOL2_5450
if 
  35@ == 0 
else_jump @POOL2_7124 
0826: enable_hud 1 
0581: enable_radar 0 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
if 
001C:   " + _9460 + @" > " + BJACK_Player_cash + @" 
else_jump @POOL2_5523 
108@ = 1 
00BE: text_clear_all 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
jump @POOL2_7078 

:POOL2_5523
0395: clear_area 1 at 102@ 103@ 104@ radius 15.0 
Object.PutAt(163@, 102@, 103@, 104@)
0400: store_coords_to 98@ 100@ " + tempvar_Float_3 + @" from_object 163@ with_offset -0.9098 -0.4589 0.7 
0400: store_coords_to 99@ 101@ " + tempvar_Float_3 + @" from_object 163@ with_offset 0.9242 0.4809 0.7 
if 
0025:   98@ > 99@ 
else_jump @POOL2_5656 
0088: " + tempvar_Float_1 + @" = 98@ 
0087: 98@ = 99@ 
0089: 99@ = " + tempvar_Float_1 + @" 

:POOL2_5656
if 
0025:   100@ > 101@ 
else_jump @POOL2_5699 
0088: " + tempvar_Float_2 + @" = 100@ 
0087: 100@ = 101@ 
0089: 101@ = " + tempvar_Float_2 + @" 

:POOL2_5699
0830: create_pool_table_collision_cornerA 98@ 100@ " + tempvar_Float_3 + @" cornerB 99@ 101@ " + tempvar_Float_3 + @" 
0400: store_coords_to 175@ 176@ 177@ from_object 163@ with_offset 0.0 0.0 1.5 
0509: 42@ = distance_between_XY 98@ 100@ and_XY 99@ 100@ 
0509: 43@ = distance_between_XY 98@ 100@ and_XY 98@ 101@ 
if 
0025:   42@ > 43@ 
else_jump @POOL2_5866 
0087: 42@ = 98@ 
005B: 42@ += 99@ 
42@ /= 2.0 
0087: 55@ = 42@ 
0087: 61@ = 100@ 
0087: 58@ = 42@ 
0087: 64@ = 101@ 
jump @POOL2_5924 

:POOL2_5866
0087: 42@ = 100@ 
005B: 42@ += 101@ 
42@ /= 2.0 
0087: 55@ = 98@ 
0087: 61@ = 42@ 
0087: 58@ = 99@ 
0087: 64@ = 42@ 

:POOL2_5924
0087: 54@ = 98@ 
0087: 60@ = 100@ 
0087: 56@ = 98@ 
0087: 62@ = 101@ 
0087: 57@ = 99@ 
0087: 63@ = 101@ 
0087: 59@ = 99@ 
0087: 65@ = 100@ 
52@ = 0.037 
0087: 53@ = 52@ 
53@ *= 2.0 
39@ = 0 

:POOL2_6023
if 
  16 > 39@ 
else_jump @POOL2_6084 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_6070 
Object.Destroy(82@(39@,16i))

:POOL2_6070
39@ += 1 
jump @POOL2_6023 

:POOL2_6084
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.2734375 -0.0546875 0.9296875 
82@ = Object.Init(#K_POOLBALLCUE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
Object.Angle(82@) = " + tempvar_Angle + @"
0400: store_coords_to 558@ 559@ 560@ from_object 163@ with_offset 0.3408 -0.0284 0.9297 
561@ = Object.Angle(163@)
561@ += 90.0 
83@ = Object.Init(#K_POOLBALLSPT01, 558@, 559@, 560@)
84@ = Object.Init(#K_POOLBALLSPT02, 0.0, 0.0, 0.0)
85@ = Object.Init(#K_POOLBALLSPT03, 0.0, 0.0, 0.0)
86@ = Object.Init(#K_POOLBALLSPT04, 0.0, 0.0, 0.0)
87@ = Object.Init(#K_POOLBALLSPT05, 0.0, 0.0, 0.0)
88@ = Object.Init(#K_POOLBALLSPT06, 0.0, 0.0, 0.0)
89@ = Object.Init(#K_POOLBALLSPT07, 0.0, 0.0, 0.0)
90@ = Object.Init(#K_POOLBALL8, 0.0, 0.0, 0.0)
91@ = Object.Init(#K_POOLBALLSTP01, 0.0, 0.0, 0.0)
92@ = Object.Init(#K_POOLBALLSTP02, 0.0, 0.0, 0.0)
93@ = Object.Init(#K_POOLBALLSTP03, 0.0, 0.0, 0.0)
94@ = Object.Init(#K_POOLBALLSTP04, 0.0, 0.0, 0.0)
95@ = Object.Init(#K_POOLBALLSTP05, 0.0, 0.0, 0.0)
96@ = Object.Init(#K_POOLBALLSTP06, 0.0, 0.0, 0.0)
97@ = Object.Init(#K_POOLBALLSTP07, 0.0, 0.0, 0.0)
gosub @POOL2_50546 
0581: enable_radar 0 
Player.CanMove(" + PlayerChar + @") = False
03E6: remove_text_box 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.5261 -1.9684 1.637 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.0746 -1.0853 1.5092 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
if 
   not Actor.Dead(164@)
else_jump @POOL2_6892 
0792: disembark_instantly_actor 164@ 
070B: set_actor 164@ onbone_attached_object_operation 0 
if 
03CA:   object " + _9459 + @" exists 
else_jump @POOL2_6692 
Object.Destroy(" + _9459 + @")

:POOL2_6692
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0219 -1.1236 0.0363 
Actor.PutAt(164@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 42@ = 105@ 
42@ += 130.0 
Actor.Angle(164@) = 42@
0615: define_AS_pack_begin 47@ 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.5261 -1.9684 1.637 
06A9: AS_actor -1 look_at_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 999999 ms 
if 
  108@ == 0 
else_jump @POOL2_6874 
0812: AS_actor -1 perform_animation ""POOL_IDLE_STANCE"" IFP ""POOL"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 1 time -1 

:POOL2_6874
0616: define_AS_pack_end 47@ 
0618: assign_actor 164@ to_AS_pack 47@ 
061B: remove_references_to_AS_pack 47@ 

:POOL2_6892
if 
83CA:   not object 107@ exists 
else_jump @POOL2_6937 
107@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)
Object.CollisionDetection(107@) = False

:POOL2_6937
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_7051 
0792: disembark_instantly_actor " + PlayerActor + @" 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -1.9295 -2.2083 0.0363 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0089: 221@ = " + tempvar_Float_1 + @" 
0089: 222@ = " + tempvar_Float_2 + @" 
0089: 223@ = " + tempvar_Float_3 + @" 
0087: 42@ = 105@ 
42@ += 390.0 
Actor.Angle(" + PlayerActor + @") = 42@

:POOL2_7051
0085: 358@ = 164@ 
0085: 359@ = 107@ 
gosub @POOL2_30670 
0A3F: set_unused_flag 0 

:POOL2_7078" );
create_thread<CLEANAU>();
AppendLine( @"fade 1 1000 

:POOL2_7093
if 
fading 
else_jump @POOL2_7117 
wait 0 
jump @POOL2_7093 

:POOL2_7117
35@ += 1 

:POOL2_7124
if 
  35@ == 1 
else_jump @POOL2_7557 
if 
   not Actor.Dead(164@)
else_jump @POOL2_7539 
if 
   Actor.Model(164@) == #BMYPOL1
else_jump @POOL2_7361 
0209: 39@ = random_int_in_ranges 0 3 
0871: init_jump_table 39@ total_jumps 3 default_jump 0 @POOL2_7335 jumps 0 @POOL2_7248 1 @POOL2_7277 2 @POOL2_7306 -1 @POOL2_7335 -1 @POOL2_7335 -1 @POOL2_7335 -1 @POOL2_7335 

:POOL2_7248
05A9: " + Actor_Speech_GXT_Reference + @" = 'POOL_B1' 
04AE: " + Actor_Speech_WAV_File + @" = 31600 
jump @POOL2_7335 

:POOL2_7277
05A9: " + Actor_Speech_GXT_Reference + @" = 'POOL_B2' 
04AE: " + Actor_Speech_WAV_File + @" = 31601 
jump @POOL2_7335 

:POOL2_7306
05A9: " + Actor_Speech_GXT_Reference + @" = 'POOL_B3' 
04AE: " + Actor_Speech_WAV_File + @" = 31602 
jump @POOL2_7335 

:POOL2_7335" );
create_thread<AUDIOL>( _local164, 0, 1, 1, 0 );
AppendLine( @"jump @POOL2_7539 

:POOL2_7361
0209: 39@ = random_int_in_ranges 0 3 
0871: init_jump_table 39@ total_jumps 3 default_jump 0 @POOL2_7520 jumps 0 @POOL2_7433 1 @POOL2_7462 2 @POOL2_7491 -1 @POOL2_7520 -1 @POOL2_7520 -1 @POOL2_7520 -1 @POOL2_7520 

:POOL2_7433
05A9: " + Actor_Speech_GXT_Reference + @" = 'POOL_B4' 
04AE: " + Actor_Speech_WAV_File + @" = 31603 
jump @POOL2_7520 

:POOL2_7462
05A9: " + Actor_Speech_GXT_Reference + @" = 'POOL_B5' 
04AE: " + Actor_Speech_WAV_File + @" = 31604 
jump @POOL2_7520 

:POOL2_7491
05A9: " + Actor_Speech_GXT_Reference + @" = 'POOL_B6' 
04AE: " + Actor_Speech_WAV_File + @" = 31605 
jump @POOL2_7520 

:POOL2_7520" );
create_thread<AUDIOL>( _local164, 0, 1, 1, 0 );
AppendLine( @"
:POOL2_7539
03F0: enable_text_draw 1 
32@ = 0 
35@ += 1 

:POOL2_7557
if 
  35@ == 2 
else_jump @POOL2_7717 
if or
876F:   not text_priority_displayed 
00E1:   player 0 pressed_key 16 
else_jump @POOL2_7717 
00BE: text_clear_all 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_7620 
159@ = Player.Money(" + PlayerChar + @")

:POOL2_7620
0989: set_text_boxes_width 200 
0512: show_permanent_text_box 'PL_H1'  
" + _9460 + @" = 50 
" + _9461 + @" = 1000 
008B: 161@ = " + _9460 + @" 
008B: 162@ = " + _9460 + @" 
008B: 155@ = " + _9460 + @" 
008B: 39@ = " + _9460 + @" 
39@ *= -1 
Player.Money(" + PlayerChar + @") += 39@
02A3: enable_widescreen 0" );
create_thread<CLEANAU>();
AppendLine( @"35@ += 1 

:POOL2_7717
if 
  35@ == 3 
else_jump @POOL2_8897 
gosub @POOL2_54522 
" + BJACK_Player_cash + @" = Player.Money(" + PlayerChar + @")
if 
00E1:   player 0 pressed_key 14 
else_jump @POOL2_8176 
if and
   not 126@ == 1 
   not 126@ == -1 
else_jump @POOL2_8125 
if 
  155@ >= 10000 
else_jump @POOL2_7826 
160@ = 1000 
jump @POOL2_7930 

:POOL2_7826
if 
  155@ >= 1000 
else_jump @POOL2_7859 
160@ = 100 
jump @POOL2_7930 

:POOL2_7859
if 
  155@ >= 100 
else_jump @POOL2_7891 
160@ = 10 
jump @POOL2_7930 

:POOL2_7891
if 
  155@ == 0 
else_jump @POOL2_7923 
160@ = 2 
jump @POOL2_7930 

:POOL2_7923
160@ = 1 

:POOL2_7930
if 
001F:   160@ > " + BJACK_Player_cash + @" 
else_jump @POOL2_7957 
008B: 160@ = " + BJACK_Player_cash + @" 

:POOL2_7957
0085: 39@ = 155@ 
005A: 39@ += 160@ 
if 
001F:   39@ > " + _9461 + @" 
else_jump @POOL2_8008 
008B: 160@ = " + _9461 + @" 
0062: 160@ -= 155@ 

:POOL2_8008
if 
  0 > 160@ 
else_jump @POOL2_8033 
160@ *= -1 

:POOL2_8033
005A: 155@ += 160@ 
005A: 161@ += 160@ 
005A: 162@ += 160@ 
160@ *= -1 
Player.Money(" + PlayerChar + @") += 160@
126@ += 1 
if 
  126@ > 1 
else_jump @POOL2_8111 
126@ = 2 
jump @POOL2_8118 

:POOL2_8111
32@ = 0 

:POOL2_8118
jump @POOL2_8169 

:POOL2_8125
if 
  126@ == 1 
else_jump @POOL2_8169 
if 
  32@ > 500 
else_jump @POOL2_8169 
126@ = 2 

:POOL2_8169
jump @POOL2_8550 

:POOL2_8176
if 
   not 126@ == 0 
else_jump @POOL2_8201 
126@ = 0 

:POOL2_8201
if 
00E1:   player 0 pressed_key 17 
else_jump @POOL2_8525 
if 
   not 128@ == 1 
else_jump @POOL2_8492 
if 
  155@ > 10000 
else_jump @POOL2_8270 
160@ = -1000 
jump @POOL2_8342 

:POOL2_8270
if 
  155@ > 1000 
else_jump @POOL2_8303 
160@ = -100 
jump @POOL2_8342 

:POOL2_8303
if 
  155@ > 100 
else_jump @POOL2_8335 
160@ = -10 
jump @POOL2_8342 

:POOL2_8335
160@ = -1 

:POOL2_8342
0085: 39@ = 155@ 
005A: 39@ += 160@ 
if 
001E:   " + _9460 + @" > 39@ 
else_jump @POOL2_8400 
0085: 160@ = 155@ 
0064: 160@ -= " + _9460 + @" 
160@ *= -1 

:POOL2_8400
005A: 155@ += 160@ 
005A: 161@ += 160@ 
005A: 162@ += 160@ 
160@ *= -1 
Player.Money(" + PlayerChar + @") += 160@
128@ += 1 
if 
  128@ > 1 
else_jump @POOL2_8478 
128@ = 2 
jump @POOL2_8485 

:POOL2_8478
32@ = 0 

:POOL2_8485
jump @POOL2_8518 

:POOL2_8492
if 
  32@ > 500 
else_jump @POOL2_8518 
128@ = 2 

:POOL2_8518
jump @POOL2_8550 

:POOL2_8525
if 
   not 128@ == 0 
else_jump @POOL2_8550 
128@ = 0 

:POOL2_8550
if 
00E1:   player 0 pressed_key 16 
else_jump @POOL2_8619 
if 
   not Actor.Dead(164@)
else_jump @POOL2_8591 
03FE: set_actor 164@ money 162@ 

:POOL2_8591
161@ = 0 
178@ = 0 
35@ = 99 
jump @POOL2_8680 

:POOL2_8619
if 
00E1:   player 1 pressed_key 12 
else_jump @POOL2_8680 
09D8: NOP 1 
0A3F: set_unused_flag 1 
" + _1904 + @" = 1 
Player.Money(" + PlayerChar + @") += 161@
161@ = 0 
178@ = 1 
35@ = 99 

:POOL2_8680
if 
00E1:   player 0 pressed_key 15 
else_jump @POOL2_8872 
if 
  127@ == 0 
else_jump @POOL2_8865 
if 
   not Actor.Dead(213@)
else_jump @POOL2_8782 
223@ += 1.1 
0792: disembark_instantly_actor 213@ 
02CE: 223@ = ground_z_at 221@ 222@ 223@ 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@

:POOL2_8782
if 
   not Actor.Dead(214@)
else_jump @POOL2_8849 
227@ += 1.1 
0792: disembark_instantly_actor 214@ 
02CE: 227@ = ground_z_at 225@ 226@ 227@ 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@

:POOL2_8849
03E6: remove_text_box 
108@ = 1 
127@ = 1 

:POOL2_8865
jump @POOL2_8897 

:POOL2_8872
if 
  127@ == 1 
else_jump @POOL2_8897 
127@ = 0 

:POOL2_8897
if 
  35@ == 99 
else_jump @POOL2_8956 
if 
   not Actor.Dead(164@)
else_jump @POOL2_8936 
0647: AS_actor 164@ clear_look_task 

:POOL2_8936
0826: enable_hud 0 
03E6: remove_text_box 
35@ = 0 
34@ += 1 

:POOL2_8956
return 

:POOL2_8958
if 
  35@ == -1 
else_jump @POOL2_9114 
213@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
214@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
215@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
106@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)
107@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)
216@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)

:POOL2_9114
if 
  35@ == 0 
else_jump @POOL2_9673 
if 
  178@ == 0 
else_jump @POOL2_9185 
217@ = -1 
218@ = -1 
219@ = 1 
220@ = 0 
jump @POOL2_9213 

:POOL2_9185
217@ = -1 
218@ = -1 
219@ = 1 
220@ = 1 

:POOL2_9213
0400: store_coords_to 221@ 222@ 223@ from_object 163@ with_offset 0.0 1.8 0.0 
0087: 224@ = 105@ 
224@ += 180.0 
0400: store_coords_to 225@ 226@ 227@ from_object 163@ with_offset 0.0 -1.8 0.0 
0087: 228@ = 105@ 
008B: 213@ = " + PlayerActor + @" 
0085: 214@ = 164@ 
if 
83CA:   not object 106@ exists 
else_jump @POOL2_9358 
106@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)
Object.CollisionDetection(106@) = False

:POOL2_9358
if 
83CA:   not object 107@ exists 
else_jump @POOL2_9403 
107@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)
Object.CollisionDetection(107@) = False

:POOL2_9403
if 
   not Actor.Dead(213@)
else_jump @POOL2_9448 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@
06AB: set_actor 213@ all_weapons_hidden 1 

:POOL2_9448
if 
   not Actor.Dead(214@)
else_jump @POOL2_9493 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@
06AB: set_actor 214@ all_weapons_hidden 1 

:POOL2_9493
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
0085: 231@ = 217@ 
232@ = 1 
04AF: 180@ = 0 
278@ = -1 
279@ = 0 
236@ = 1 
if 
  236@ == 0 
else_jump @POOL2_9622 
242@ = 10.0 
243@ = 0.02 
244@ = 0.0 
jump @POOL2_9652 

:POOL2_9622
242@ = 22.5 
243@ = 0.02 
244@ = 0.0 

:POOL2_9652
184@ = 1 
35@ = 0 
34@ += 1 

:POOL2_9673
return 

:POOL2_9675
if 
  233@ == 0 
else_jump @POOL2_10212 
if 
  35@ == 0 
else_jump @POOL2_10060 
if 
   not Actor.Dead(213@)
else_jump @POOL2_9773 
223@ += 1.0 
02CE: 223@ = ground_z_at 221@ 222@ 223@ 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@

:POOL2_9773
if 
   not Actor.Dead(214@)
else_jump @POOL2_9835 
227@ += 1.1 
02CE: 227@ = ground_z_at 225@ 226@ 227@ 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@

:POOL2_9835
if 
   not Actor.Dead(215@)
else_jump @POOL2_10060 
070B: set_actor 215@ onbone_attached_object_operation 0 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 215@ with_offset 1.0 3.0 1.0 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
Camera.OnPed(215@, 15, 2)
0615: define_AS_pack_begin 47@ 
0812: AS_actor -1 perform_animation ""POOL_CHALKCUE"" IFP ""POOL"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""POOL_IDLE_STANCE"" IFP ""POOL"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 47@ 
if 
  108@ == 0 
else_jump @POOL2_10041 
0618: assign_actor 215@ to_AS_pack 47@ 

:POOL2_10041
061B: remove_references_to_AS_pack 47@ 
32@ = 0 
35@ += 1 

:POOL2_10060
if 
  35@ == 1 
else_jump @POOL2_10138 
if 
   not Actor.Dead(215@)
else_jump @POOL2_10138 
062E: get_actor 215@ task 1560 status_store_to 39@ 
if or
04A4:   39@ == 7 
  32@ > 3000 
else_jump @POOL2_10138 
35@ = 99 

:POOL2_10138
if 
  32@ > 500 
else_jump @POOL2_10205 
if 
00E1:   player 180@ pressed_key 16 
else_jump @POOL2_10205 
if 
   not Actor.Dead(215@)
else_jump @POOL2_10205 
126@ = 1 
35@ = 99 

:POOL2_10205
jump @POOL2_10235 

:POOL2_10212
if 
   not Actor.Dead(215@)
else_jump @POOL2_10235 
35@ = 99 

:POOL2_10235
if 
  35@ == 99 
else_jump @POOL2_10280 
040D: unload_wav 4 
03E6: remove_text_box 
32@ = 0 
34@ += 1 
35@ = 0 

:POOL2_10280
if 
00E1:   player 180@ pressed_key 15 
else_jump @POOL2_10471 
if and
  127@ == 0 
  183@ > 1000 
else_jump @POOL2_10464 
if 
   not Actor.Dead(213@)
else_jump @POOL2_10386 
223@ += 1.1 
02CE: 223@ = ground_z_at 221@ 222@ 223@ 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@

:POOL2_10386
if 
   not Actor.Dead(214@)
else_jump @POOL2_10448 
227@ += 1.1 
02CE: 227@ = ground_z_at 225@ 226@ 227@ 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@

:POOL2_10448
03E6: remove_text_box 
108@ = 1 
127@ = 1 

:POOL2_10464
jump @POOL2_10503 

:POOL2_10471
if 
  127@ == 1 
else_jump @POOL2_10496 
127@ = 0 

:POOL2_10496
183@ = 0 

:POOL2_10503
return 

:POOL2_10505
if and
   not 232@ == 0 
  230@ == 1 
else_jump @POOL2_10537 
gosub @POOL2_59389 

:POOL2_10537
if 
   not 232@ == 0 
else_jump @POOL2_10821 
if 
  66@ == 1 
else_jump @POOL2_10706 
if 
83CA:   not object 82@ exists 
else_jump @POOL2_10699 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.35 0.0 0.9296875 
0089: 627@ = " + tempvar_Float_1 + @" 
0089: 628@ = " + tempvar_Float_2 + @" 
gosub @POOL2_54002 
0088: " + tempvar_Float_1 + @" = 627@ 
0088: " + tempvar_Float_2 + @" = 628@ 
82@ = Object.Init(#K_POOLBALLCUE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
Object.Angle(82@) = " + tempvar_Angle + @"

:POOL2_10699
66@ = 0 

:POOL2_10706
if 
00E1:   player 180@ pressed_key 14 
else_jump @POOL2_10796 
if 
  128@ == 0 
else_jump @POOL2_10789 
if 
  198@ == 2 
else_jump @POOL2_10774 
198@ = 0 
jump @POOL2_10782 

:POOL2_10774
205@ = 3001 

:POOL2_10782
128@ = 1 

:POOL2_10789
jump @POOL2_10821 

:POOL2_10796
if 
  128@ == 1 
else_jump @POOL2_10821 
128@ = 0 

:POOL2_10821
if 
  232@ == 1 
else_jump @POOL2_11055 
if 
  35@ == 0 
else_jump @POOL2_11055 
if 
  230@ == 1 
else_jump @POOL2_10972 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.35 0.0 0.0 
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
Object.PutAt(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 560@)
Object.Angle(82@) = " + tempvar_Angle + @"
32@ = 0 
35@ = 99 
jump @POOL2_12101 
jump @POOL2_11055 

:POOL2_10972
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.35 0.0 0.0 
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
Object.PutAt(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 560@)
Object.Angle(82@) = " + tempvar_Angle + @"
35@ = 99 
jump @POOL2_12101 

:POOL2_11055
if 
  232@ == 2 
else_jump @POOL2_11846 
if 
  35@ == 0 
else_jump @POOL2_11471 
if 
  230@ == 1 
else_jump @POOL2_11349 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.35 0.0 0.0 
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
0089: 627@ = " + tempvar_Float_1 + @" 
0089: 628@ = " + tempvar_Float_2 + @" 
gosub @POOL2_54002 
0088: " + tempvar_Float_1 + @" = 627@ 
0088: " + tempvar_Float_2 + @" = 628@ 
Object.PutAt(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 560@)
Object.Angle(82@) = " + tempvar_Angle + @"
32@ = 0 
35@ += 1 
198@ = 0 
205@ = 0 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 -0.001 2.5 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 0.001 0.0 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
jump @POOL2_11471 

:POOL2_11349
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.35 0.0 0.0 
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
0089: 627@ = " + tempvar_Float_1 + @" 
0089: 628@ = " + tempvar_Float_2 + @" 
gosub @POOL2_54002 
0088: " + tempvar_Float_1 + @" = 627@ 
0088: " + tempvar_Float_2 + @" = 628@ 
Object.PutAt(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 560@)
Object.Angle(82@) = " + tempvar_Angle + @"
35@ = 99 
jump @POOL2_12101 

:POOL2_11471
if 
  35@ == 1 
else_jump @POOL2_11846 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
39@ = 0 
if or
00E1:   player 180@ pressed_key 0 
00E1:   player 180@ pressed_key 1 
else_jump @POOL2_11542 
39@ = 1 

:POOL2_11542
if 
  39@ == 1 
else_jump @POOL2_11757 
0494: get_joystick 180@ direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 235@ = integer " + Move_Axis_X + @" to_float 
008F: 234@ = integer " + Move_Axis_Y + @" to_float 
235@ /= 128.0 
234@ /= -128.0 
235@ *= 0.01 
234@ *= 0.01 
gosub @POOL2_54371 
006D: " + _6466 + @" *= 234@ 
006D: " + _6468 + @" *= 234@ 
0059: " + tempvar_Float_1 + @" += " + _6466 + @" 
0059: " + tempvar_Float_2 + @" += " + _6468 + @" 
006D: " + _6467 + @" *= 235@ 
006D: " + _6469 + @" *= 235@ 
0059: " + tempvar_Float_1 + @" += " + _6467 + @" 
0059: " + tempvar_Float_2 + @" += " + _6469 + @" 
0089: 627@ = " + tempvar_Float_1 + @" 
0089: 628@ = " + tempvar_Float_2 + @" 
gosub @POOL2_54002 
0088: " + tempvar_Float_1 + @" = 627@ 
0088: " + tempvar_Float_2 + @" = 628@ 
Object.PutAt(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 560@)

:POOL2_11757
if 
00E1:   player 180@ pressed_key 16 
else_jump @POOL2_11821 
if 
  126@ == 0 
else_jump @POOL2_11814 
35@ = 99 
126@ = 1 
jump @POOL2_12101 

:POOL2_11814
jump @POOL2_11846 

:POOL2_11821
if 
  126@ == 1 
else_jump @POOL2_11846 
126@ = 0 

:POOL2_11846
if 
  232@ == 0 
else_jump @POOL2_11878 
35@ = 99 
jump @POOL2_12101 

:POOL2_11878
if 
00E1:   player 180@ pressed_key 15 
else_jump @POOL2_12069 
if and
  127@ == 0 
  183@ > 1000 
else_jump @POOL2_12062 
if 
   not Actor.Dead(213@)
else_jump @POOL2_11984 
223@ += 1.1 
02CE: 223@ = ground_z_at 221@ 222@ 223@ 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@

:POOL2_11984
if 
   not Actor.Dead(214@)
else_jump @POOL2_12046 
227@ += 1.1 
02CE: 227@ = ground_z_at 225@ 226@ 227@ 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@

:POOL2_12046
03E6: remove_text_box 
108@ = 1 
127@ = 1 

:POOL2_12062
jump @POOL2_12101 

:POOL2_12069
if 
  127@ == 1 
else_jump @POOL2_12094 
127@ = 0 

:POOL2_12094
183@ = 0 

:POOL2_12101
if 
  35@ == 99 
else_jump @POOL2_12135 
34@ += 1 
35@ = 0 
03E6: remove_text_box 

:POOL2_12135
return 

:POOL2_12137
if 
  230@ == 1 
else_jump @POOL2_15142 
gosub @POOL2_57034 
if 
  35@ == -1 
else_jump @POOL2_12202 
238@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)

:POOL2_12202
if 
  35@ == 0 
else_jump @POOL2_13396 
if 
   not Actor.Dead(213@)
else_jump @POOL2_12282 
223@ += 1.1 
02CE: 223@ = ground_z_at 221@ 222@ 223@ 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@

:POOL2_12282
if 
   not Actor.Dead(214@)
else_jump @POOL2_12344 
227@ += 1.1 
02CE: 227@ = ground_z_at 225@ 226@ 227@ 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@

:POOL2_12344
if 
   not Actor.Dead(215@)
else_jump @POOL2_12405 
Actor.StorePos(215@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Float_3 + @" += -10.0 
Actor.PutAt(215@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.LockInCurrentPosition(215@) = True

:POOL2_12405
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 -0.001 2.5 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 0.001 0.0 
if 
03CA:   object 82@ exists 
else_jump @POOL2_12505 
" + tempvar_Angle + @" = Object.Angle(82@)
0453: set_object 82@ XYZ_rotation 0.0 0.0 " + tempvar_Angle + @" 

:POOL2_12505
if 
83CA:   not object 238@ exists 
else_jump @POOL2_12594 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 0.0 -10.0 
238@ = Object.Init(#K_POOLQ2, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.ToggleInMovingList(238@) = False
Object.CollisionDetection(238@) = False
0418: set_object 238@ draw_last 1 
jump @POOL2_12615 

:POOL2_12594
Object.ToggleInMovingList(238@) = False
Object.CollisionDetection(238@) = False
0418: set_object 238@ draw_last 1 

:POOL2_12615
205@ = 0 
198@ = 0 
if 
  245@ == 0 
else_jump @POOL2_13348 
239@ = -1 
42@ = 99999.9 
if 
03CA:   object 82@ exists 
else_jump @POOL2_13197 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
  231@ == -1 
else_jump @POOL2_12848 
39@ = 1 

:POOL2_12719
if 
  16 > 39@ 
else_jump @POOL2_12841 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_12827 
Object.StorePos(82@(39@,16i), 165@, 166@, 167@)
0509: 43@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 165@ 166@ 
if 
0025:   42@ > 43@ 
else_jump @POOL2_12827 
0085: 239@ = 39@ 
0087: 42@ = 43@ 

:POOL2_12827
39@ += 1 
jump @POOL2_12719 

:POOL2_12841
jump @POOL2_13197 

:POOL2_12848
if 
  231@ == 0 
else_jump @POOL2_13002 
39@ = 1 

:POOL2_12873
if 
  8 > 39@ 
else_jump @POOL2_12995 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_12981 
Object.StorePos(82@(39@,16i), 165@, 166@, 167@)
0509: 43@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 165@ 166@ 
if 
0025:   42@ > 43@ 
else_jump @POOL2_12981 
0085: 239@ = 39@ 
0087: 42@ = 43@ 

:POOL2_12981
39@ += 1 
jump @POOL2_12873 

:POOL2_12995
jump @POOL2_13197 

:POOL2_13002
if 
  231@ == 1 
else_jump @POOL2_13156 
39@ = 9 

:POOL2_13027
if 
  16 > 39@ 
else_jump @POOL2_13149 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_13135 
Object.StorePos(82@(39@,16i), 165@, 166@, 167@)
0509: 43@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 165@ 166@ 
if 
0025:   42@ > 43@ 
else_jump @POOL2_13135 
0085: 239@ = 39@ 
0087: 42@ = 43@ 

:POOL2_13135
39@ += 1 
jump @POOL2_13027 

:POOL2_13149
jump @POOL2_13197 

:POOL2_13156
if 
  231@ == 2 
else_jump @POOL2_13197 
if 
03CA:   object 90@ exists 
else_jump @POOL2_13197 
239@ = 8 

:POOL2_13197
if and
   not 239@ == -1 
  16 > 239@ 
else_jump @POOL2_13341 
if 
03CA:   object 82@ exists 
else_jump @POOL2_13341 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
03CA:   object 82@(239@,16i) exists 
else_jump @POOL2_13290 
Object.StorePos(82@(239@,16i), 165@, 166@, 167@)

:POOL2_13290
0087: 169@ = 165@ 
0065: 169@ -= " + tempvar_Float_1 + @" 
0087: 170@ = 166@ 
0065: 170@ -= " + tempvar_Float_2 + @" 
0604: get_Z_angle_for_point 169@ 170@ store_to 42@ 
Object.Angle(82@) = 42@

:POOL2_13341
jump @POOL2_13355 

:POOL2_13348
245@ = 0 

:POOL2_13355
240@ = 0 
gosub @POOL2_28396 
199@ = 0.0 
200@ = 0.0 
35@ += 1 

:POOL2_13396
if 
  35@ == 1 
else_jump @POOL2_13627 
if 
00E1:   player 180@ pressed_key 13 
else_jump @POOL2_13602 
if 
  237@ == 0 
else_jump @POOL2_13510 
if 
  236@ == 0 
else_jump @POOL2_13489 
236@ = 1 
237@ = 1 
jump @POOL2_13503 

:POOL2_13489
236@ = 0 
237@ = 1 

:POOL2_13503
205@ = 0 

:POOL2_13510
if 
  236@ == 0 
else_jump @POOL2_13565 
242@ = 10.0 
243@ = 0.02 
244@ = 0.0 
jump @POOL2_13595 

:POOL2_13565
242@ = 22.5 
243@ = 0.02 
244@ = 0.0 

:POOL2_13595
jump @POOL2_13627 

:POOL2_13602
if 
  237@ == 1 
else_jump @POOL2_13627 
237@ = 0 

:POOL2_13627
0A4A: store_joystick_X_offset_to 201@ Y_offset_to 202@ 
if or
00E1:   player 180@ pressed_key 0 
  201@ > 0.01 
  -0.01 > 201@ 
else_jump @POOL2_13780 
" + tempvar_Angle + @" = Object.Angle(82@)
0494: get_joystick 180@ direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 42@ = integer " + Move_Axis_X + @" to_float 
42@ /= 128.0 
42@ *= 1.0 
005F: " + tempvar_Angle + @" += 42@ 
201@ *= -0.4 
005F: " + tempvar_Angle + @" += 201@ 
0453: set_object 82@ XYZ_rotation 0.0 0.0 0.0 
Object.Angle(82@) = " + tempvar_Angle + @"

:POOL2_13780
if 
  236@ == 0 
else_jump @POOL2_13895 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 -0.001 2.5 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset 0.0 0.001 0.0 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:POOL2_13895
if 
  236@ == 1 
else_jump @POOL2_14010 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 82@ with_offset 0.0 -0.5 0.3 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 82@ with_offset 0.0 0.5 0.0 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:POOL2_14010
if 
  236@ == 0 
else_jump @POOL2_14143 
if 
00E1:   player 180@ pressed_key 14 
else_jump @POOL2_14118 
if 
  128@ == 0 
else_jump @POOL2_14111 
if 
  198@ == 2 
else_jump @POOL2_14096 
198@ = 0 
jump @POOL2_14104 

:POOL2_14096
205@ = 3001 

:POOL2_14104
128@ = 1 

:POOL2_14111
jump @POOL2_14143 

:POOL2_14118
if 
  128@ == 1 
else_jump @POOL2_14143 
128@ = 0 

:POOL2_14143
if 
03CA:   object 238@ exists 
else_jump @POOL2_14282 
if 
  236@ == 0 
else_jump @POOL2_14209 
0400: store_coords_to 165@ 166@ 167@ from_object 82@ with_offset 244@ -0.05 243@ 
jump @POOL2_14234 

:POOL2_14209
0400: store_coords_to 165@ 166@ 167@ from_object 82@ with_offset 244@ -0.05 243@ 

:POOL2_14234
" + tempvar_Angle + @" = Object.Angle(82@)
" + tempvar_Angle + @" += 180.0 
Object.PutAt(238@, 165@, 166@, 167@)
0453: set_object 238@ XYZ_rotation 242@ 0.0 " + tempvar_Angle + @" 

:POOL2_14282
if 
80E1:   not player 180@ pressed_key 0 
else_jump @POOL2_14321 
240@ = 0 
gosub @POOL2_28396 
jump @POOL2_14421 

:POOL2_14321
if 
   not 240@ == 0 
else_jump @POOL2_14407 
39@ = 0 

:POOL2_14346
if 
  10 > 39@ 
else_jump @POOL2_14407 
if 
03CA:   object 347@(39@,10i) exists 
else_jump @POOL2_14393 
Object.Destroy(347@(39@,10i))

:POOL2_14393
39@ += 1 
jump @POOL2_14346 

:POOL2_14407
240@ = 0 
32@ = 0 

:POOL2_14421
if 
0736:   is_keyboard_key_just_pressed 131 
else_jump @POOL2_14447 
242@ += 0.5 

:POOL2_14447
if 
0736:   is_keyboard_key_just_pressed 130 
else_jump @POOL2_14473 
242@ += -0.5 

:POOL2_14473
if 
0736:   is_keyboard_key_just_pressed 87 
else_jump @POOL2_14498 
243@ += 0.001 

:POOL2_14498
if 
0736:   is_keyboard_key_just_pressed 83 
else_jump @POOL2_14523 
243@ += -0.001 

:POOL2_14523
if 
0736:   is_keyboard_key_just_pressed 128 
else_jump @POOL2_14549 
244@ += 0.0001 

:POOL2_14549
if 
0736:   is_keyboard_key_just_pressed 129 
else_jump @POOL2_14575 
244@ += -0.0001 

:POOL2_14575
if 
0736:   is_keyboard_key_just_pressed 137 
else_jump @POOL2_15002 
03A9: save_newline_to_debug_file 
05B6: 17 
03A8: save_float_to_debug_file 242@ 
03A9: save_newline_to_debug_file 
05B6: 18 
03A8: save_float_to_debug_file 243@ 
03A9: save_newline_to_debug_file 
05B6: 19 
03A8: save_float_to_debug_file 244@ 

:POOL2_15002
if 
00E1:   player 180@ pressed_key 16 
else_jump @POOL2_15080 
if 
  126@ == 0 
else_jump @POOL2_15073 
if 
03CA:   object 238@ exists 
else_jump @POOL2_15059 
Object.Destroy(238@)

:POOL2_15059
35@ = 99 
126@ = 1 

:POOL2_15073
jump @POOL2_15105 

:POOL2_15080
if 
  126@ == 1 
else_jump @POOL2_15105 
126@ = 0 

:POOL2_15105
if 
0735:   is_keyboard_key_pressed 72 
else_jump @POOL2_15135 
gosub @POOL2_33712 
Object.Angle(82@) = 363@

:POOL2_15135
jump @POOL2_15164 

:POOL2_15142
gosub @POOL2_33712 
Object.Angle(82@) = 363@
35@ = 99 

:POOL2_15164
if 
00E1:   player 180@ pressed_key 15 
else_jump @POOL2_15355 
if and
  127@ == 0 
  183@ > 1000 
else_jump @POOL2_15348 
if 
   not Actor.Dead(213@)
else_jump @POOL2_15270 
223@ += 1.1 
02CE: 223@ = ground_z_at 221@ 222@ 223@ 
Actor.PutAt(213@, 221@, 222@, 223@)
Actor.Angle(213@) = 224@

:POOL2_15270
if 
   not Actor.Dead(214@)
else_jump @POOL2_15332 
227@ += 1.1 
02CE: 227@ = ground_z_at 225@ 226@ 227@ 
Actor.PutAt(214@, 225@, 226@, 227@)
Actor.Angle(214@) = 228@

:POOL2_15332
03E6: remove_text_box 
108@ = 1 
127@ = 1 

:POOL2_15348
jump @POOL2_15387 

:POOL2_15355
if 
  127@ == 1 
else_jump @POOL2_15380 
127@ = 0 

:POOL2_15380
183@ = 0 

:POOL2_15387
if 
  35@ == 99 
else_jump @POOL2_15509 
39@ = 0 

:POOL2_15412
if 
  10 > 39@ 
else_jump @POOL2_15473 
if 
03CA:   object 347@(39@,10i) exists 
else_jump @POOL2_15459 
Object.Destroy(347@(39@,10i))

:POOL2_15459
39@ += 1 
jump @POOL2_15412 

:POOL2_15473
199@ = 0.0 
200@ = 0.0 
34@ += 2 
35@ = 0 
03E6: remove_text_box 

:POOL2_15509
return 

:POOL2_15511
return 

:POOL2_15513
gosub @POOL2_57034 
if 
  230@ == 1 
else_jump @POOL2_16275 
if 
00E1:   player 180@ pressed_key 15 
else_jump @POOL2_15609 
if 
  127@ == 0 
else_jump @POOL2_15602 
34@ = 5 
35@ = 0 
127@ = 1 
245@ = 1 

:POOL2_15602
jump @POOL2_16268 

:POOL2_15609
if 
  127@ == 1 
else_jump @POOL2_15634 
127@ = 0 

:POOL2_15634
if 
  35@ == 0 
else_jump @POOL2_15666 
gosub @POOL2_18801 
35@ += 1 

:POOL2_15666
if 
  250@ == 0 
else_jump @POOL2_15691 
gosub @POOL2_53449 

:POOL2_15691
if 
  250@ == 0 
else_jump @POOL2_15993 
gosub @POOL2_16733 
if 
  252@ == 1 
else_jump @POOL2_15983 
if 
0A4B:   controls_set_to_joystick 
else_jump @POOL2_15852 
if 
00E1:   player 180@ pressed_key 3 
else_jump @POOL2_15835 
0494: get_joystick 180@ direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 42@ = integer " + Special_Axis_Y + @" to_float 
42@ /= 128.0 
42@ *= -0.2 
246@ = 0.2 
005B: 246@ += 42@ 
jump @POOL2_15845 

:POOL2_15835
246@ = 0.2 

:POOL2_15845
jump @POOL2_15976 

:POOL2_15852
0A4A: store_joystick_X_offset_to 201@ Y_offset_to 202@ 
005B: 200@ += 202@ 
if 
  200@ > 128.0 
else_jump @POOL2_15899 
200@ = 128.0 

:POOL2_15899
if 
  -128.0 > 200@ 
else_jump @POOL2_15930 
200@ = -128.0 

:POOL2_15930
0087: 42@ = 200@ 
42@ /= 128.0 
42@ *= -0.2 
246@ = 0.2 
005B: 246@ += 42@ 

:POOL2_15976
jump @POOL2_15993 

:POOL2_15983
246@ = 0.0 

:POOL2_15993
if 
  250@ == 0 
else_jump @POOL2_16053 
if 
  246@ > 0.25 
else_jump @POOL2_16046 
gosub @POOL2_19798 
jump @POOL2_16053 

:POOL2_16046
gosub @POOL2_18640 

:POOL2_16053
if 
  35@ == 1 
else_jump @POOL2_16101 
if 
   not Actor.Dead(215@)
else_jump @POOL2_16101 
gosub @POOL2_18983 
35@ += 1 

:POOL2_16101
if 
  35@ == 2 
else_jump @POOL2_16126 
gosub @POOL2_16987 

:POOL2_16126
if 
  35@ == 3 
else_jump @POOL2_16227 
if 
   not Actor.Dead(215@)
else_jump @POOL2_16227 
592@ += 1.1 
02CE: 592@ = ground_z_at 584@ 588@ 592@ 
Actor.PutAt(215@, 584@, 588@, 592@)
Actor.Angle(215@) = 596@
0619: enable_actor 215@ collision_detection 1 
32@ = 0 
35@ = 99 

:POOL2_16227
if 
  35@ == 99 
else_jump @POOL2_16268 
03E6: remove_text_box 
32@ = 0 
34@ += 1 
35@ = 0 

:POOL2_16268
jump @POOL2_16731 

:POOL2_16275
if 
  35@ == 0 
else_jump @POOL2_16307 
gosub @POOL2_18801 
35@ += 1 

:POOL2_16307
if 
  250@ == 0 
else_jump @POOL2_16456 
gosub @POOL2_16733 
if 
  252@ == 1 
else_jump @POOL2_16439 
if 
  2000 > 32@ 
else_jump @POOL2_16386 
246@ = 0.2 
jump @POOL2_16432 

:POOL2_16386
if 
  3000 > 32@ 
else_jump @POOL2_16422 
246@ = 0.0 
jump @POOL2_16432 

:POOL2_16422
246@ = 1.0 

:POOL2_16432
jump @POOL2_16456 

:POOL2_16439
32@ = 0 
246@ = 0.0 

:POOL2_16456
if 
  250@ == 0 
else_jump @POOL2_16516 
if 
  246@ > 0.25 
else_jump @POOL2_16509 
gosub @POOL2_19798 
jump @POOL2_16516 

:POOL2_16509
gosub @POOL2_18640 

:POOL2_16516
if 
  35@ == 1 
else_jump @POOL2_16564 
if 
   not Actor.Dead(215@)
else_jump @POOL2_16564 
gosub @POOL2_18983 
35@ += 1 

:POOL2_16564
if 
  35@ == 2 
else_jump @POOL2_16589 
gosub @POOL2_16987 

:POOL2_16589
if 
  35@ == 3 
else_jump @POOL2_16690 
if 
   not Actor.Dead(215@)
else_jump @POOL2_16690 
592@ += 1.1 
02CE: 592@ = ground_z_at 584@ 588@ 592@ 
Actor.PutAt(215@, 584@, 588@, 592@)
Actor.Angle(215@) = 596@
0619: enable_actor 215@ collision_detection 1 
32@ = 0 
35@ = 99 

:POOL2_16690
if 
  35@ == 99 
else_jump @POOL2_16731 
03E6: remove_text_box 
32@ = 0 
34@ += 1 
35@ = 0 

:POOL2_16731
return 

:POOL2_16733
252@ = 0 
if 
   not Actor.Dead(215@)
else_jump @POOL2_16985 
if 
  600@ == 1 
else_jump @POOL2_16814 
if 
   Actor.Animation(215@) == ""POOL_SHORT_SHOT""
else_jump @POOL2_16814 
252@ = 1 

:POOL2_16814
if 
  600@ == 2 
else_jump @POOL2_16870 
if 
   Actor.Animation(215@) == ""POOL_MED_SHOT""
else_jump @POOL2_16870 
252@ = 1 

:POOL2_16870
if 
  600@ == 3 
else_jump @POOL2_16927 
if 
   Actor.Animation(215@) == ""POOL_LONG_SHOT""
else_jump @POOL2_16927 
252@ = 1 

:POOL2_16927
if 
  600@ == 4 
else_jump @POOL2_16985 
if 
   Actor.Animation(215@) == ""POOL_XLONG_SHOT""
else_jump @POOL2_16985 
252@ = 1 

:POOL2_16985
return 

:POOL2_16987
if 
   not Actor.Dead(215@)
else_jump @POOL2_17598 
if 
  251@ == 0 
else_jump @POOL2_17598 
if 
  600@ == 1 
else_jump @POOL2_17165 
0615: define_AS_pack_begin 47@ 
0812: AS_actor -1 perform_animation ""POOL_SHORT_START"" IFP ""POOL"" framedelta 8.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""POOL_SHORT_SHOT"" IFP ""POOL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 47@ 
if 
  108@ == 0 
else_jump @POOL2_17160 
0618: assign_actor 215@ to_AS_pack 47@ 

:POOL2_17160
061B: remove_references_to_AS_pack 47@ 

:POOL2_17165
if 
  600@ == 2 
else_jump @POOL2_17305 
0615: define_AS_pack_begin 47@ 
0812: AS_actor -1 perform_animation ""POOL_MED_START"" IFP ""POOL"" framedelta 8.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""POOL_MED_SHOT"" IFP ""POOL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 47@ 
if 
  108@ == 0 
else_jump @POOL2_17300 
0618: assign_actor 215@ to_AS_pack 47@ 

:POOL2_17300
061B: remove_references_to_AS_pack 47@ 

:POOL2_17305
if 
  600@ == 3 
else_jump @POOL2_17447 
0615: define_AS_pack_begin 47@ 
0812: AS_actor -1 perform_animation ""POOL_LONG_START"" IFP ""POOL"" framedelta 8.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""POOL_LONG_SHOT"" IFP ""POOL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 47@ 
if 
  108@ == 0 
else_jump @POOL2_17442 
0618: assign_actor 215@ to_AS_pack 47@ 

:POOL2_17442
061B: remove_references_to_AS_pack 47@ 

:POOL2_17447
if 
  600@ == 4 
else_jump @POOL2_17591 
0615: define_AS_pack_begin 47@ 
0812: AS_actor -1 perform_animation ""POOL_XLONG_START"" IFP ""POOL"" framedelta 8.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""POOL_XLONG_SHOT"" IFP ""POOL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 47@ 
if 
  108@ == 0 
else_jump @POOL2_17586 
0618: assign_actor 215@ to_AS_pack 47@ 

:POOL2_17586
061B: remove_references_to_AS_pack 47@ 

:POOL2_17591
251@ += 1 

:POOL2_17598
if 
  251@ == 1 
else_jump @POOL2_18116 
if 
  250@ == 0 
else_jump @POOL2_18102 
if 
   not Actor.Dead(215@)
else_jump @POOL2_18095 
062E: get_actor 215@ task 1560 status_store_to 39@ 
if 
84A4:   not  39@ == 7 
else_jump @POOL2_18081 
if 
  600@ == 1 
else_jump @POOL2_17780 
if 
   Actor.Animation(215@) == ""POOL_SHORT_SHOT""
else_jump @POOL2_17780 
0614: set_actor 215@ animation ""POOL_SHORT_SHOT"" progress_to 247@ 
0393: actor 215@ perform_animation ""POOL_SHORT_SHOT"" at 248@ times_normal_rate 

:POOL2_17780
if 
  600@ == 2 
else_jump @POOL2_17875 
if 
   Actor.Animation(215@) == ""POOL_MED_SHOT""
else_jump @POOL2_17875 
0614: set_actor 215@ animation ""POOL_MED_SHOT"" progress_to 247@ 
0393: actor 215@ perform_animation ""POOL_MED_SHOT"" at 248@ times_normal_rate 

:POOL2_17875
if 
  600@ == 3 
else_jump @POOL2_17973 
if 
   Actor.Animation(215@) == ""POOL_LONG_SHOT""
else_jump @POOL2_17973 
0614: set_actor 215@ animation ""POOL_LONG_SHOT"" progress_to 247@ 
0393: actor 215@ perform_animation ""POOL_LONG_SHOT"" at 248@ times_normal_rate 

:POOL2_17973
if 
  600@ == 4 
else_jump @POOL2_18074 
if 
   Actor.Animation(215@) == ""POOL_XLONG_SHOT""
else_jump @POOL2_18074 
0614: set_actor 215@ animation ""POOL_XLONG_SHOT"" progress_to 247@ 
0393: actor 215@ perform_animation ""POOL_XLONG_SHOT"" at 248@ times_normal_rate 

:POOL2_18074
jump @POOL2_18095 

:POOL2_18081
32@ = 0 
251@ += 1 

:POOL2_18095
jump @POOL2_18116 

:POOL2_18102
32@ = 0 
251@ += 1 

:POOL2_18116
if 
  251@ == 2 
else_jump @POOL2_18535 
if 
   not Actor.Dead(215@)
else_jump @POOL2_18535 
062E: get_actor 215@ task 1560 status_store_to 39@ 
if and
84A4:   not  39@ == 7 
  5000 > 32@ 
else_jump @POOL2_18528 
42@ = 1.0 
0063: 42@ -= 248@ 
42@ /= 20.0 
005B: 248@ += 42@ 
if 
  0.8 > 248@ 
else_jump @POOL2_18254 
248@ += 0.01 

:POOL2_18254
if and
  1.2 > 248@ 
  248@ > 0.8 
else_jump @POOL2_18295 
248@ = 1.0 

:POOL2_18295
if 
   Actor.Animation(215@) == ""POOL_SHORT_SHOT""
else_jump @POOL2_18353 
0393: actor 215@ perform_animation ""POOL_SHORT_SHOT"" at 248@ times_normal_rate 

:POOL2_18353
if 
   Actor.Animation(215@) == ""POOL_MED_SHOT""
else_jump @POOL2_18407 
0393: actor 215@ perform_animation ""POOL_MED_SHOT"" at 248@ times_normal_rate 

:POOL2_18407
if 
   Actor.Animation(215@) == ""POOL_LONG_SHOT""
else_jump @POOL2_18463 
0393: actor 215@ perform_animation ""POOL_LONG_SHOT"" at 248@ times_normal_rate 

:POOL2_18463
if 
   Actor.Animation(215@) == ""POOL_XLONG_SHOT""
else_jump @POOL2_18521 
0393: actor 215@ perform_animation ""POOL_XLONG_SHOT"" at 248@ times_normal_rate 

:POOL2_18521
jump @POOL2_18535 

:POOL2_18528
251@ += 1 

:POOL2_18535
if 
  251@ == 3 
else_jump @POOL2_18638 
if 
   not Actor.Dead(215@)
else_jump @POOL2_18631 
if 
  108@ == 0 
else_jump @POOL2_18631 
0812: AS_actor 215@ perform_animation ""POOL_IDLE_STANCE"" IFP ""POOL"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 

:POOL2_18631
35@ += 1 

:POOL2_18638
return 

:POOL2_18640
0087: 42@ = 246@ 
0063: 42@ -= 247@ 
if or
  42@ >= 0.05 
  -0.05 >= 42@ 
else_jump @POOL2_18791 
42@ /= 3.0 
if and
  0.01 > 42@ 
  42@ > -0.01 
else_jump @POOL2_18776 
if 
  42@ > 0.0 
else_jump @POOL2_18766 
42@ = 0.01 
jump @POOL2_18776 

:POOL2_18766
42@ = -0.01 

:POOL2_18776
005B: 247@ += 42@ 
jump @POOL2_18799 

:POOL2_18791
0087: 247@ = 246@ 

:POOL2_18799
return 

:POOL2_18801
250@ = 0 
251@ = 0 
618@ = 565.0 
619@ = 386.0 
0087: 622@ = 618@ 
0087: 623@ = 619@ 
621@ = 67.0 
620@ = 78.0 
624@ = 19.0 
625@ = 16.0 
248@ = 0.0 
247@ = 0.0 
248@ = 0.0 
246@ = 0.0 
32@ = 0 
33@ = 0 
if 
   not 230@ == 0 
else_jump @POOL2_18974 
0512: show_permanent_text_box 'PL_H4'  

:POOL2_18974
gosub @POOL2_51426 
return 

:POOL2_18983
0619: enable_actor 215@ collision_detection 0 
0087: 42@ = 104@ 
42@ += 1.0 
02CE: 594@ = ground_z_at 102@ 103@ 42@ 
Actor.PutAt(215@, 586@, 590@, 594@)
Actor.Angle(215@) = 598@
if 
003B:   213@ == 215@ 
else_jump @POOL2_19249 
if 
   not Actor.Dead(213@)
else_jump @POOL2_19242 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 213@ with_offset 0.0 -1.5 0.0 
if 
   not Actor.Dead(214@)
else_jump @POOL2_19242 
Actor.PutAt(214@, 225@, 226@, 227@)
if 
00EC:   actor 214@ sphere 0 near_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" radius 2.0 2.0 
else_jump @POOL2_19215 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 214@ with_offset -2.0 0.0 -1.0 
Actor.PutAt(214@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:POOL2_19215
if 
03CA:   object 82@ exists 
else_jump @POOL2_19242 
0655: AS_actor 214@ look_at_object 82@ 10000 ms 

:POOL2_19242
jump @POOL2_19428 

:POOL2_19249
if 
   not Actor.Dead(214@)
else_jump @POOL2_19428 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 214@ with_offset 0.0 -1.5 0.0 
if 
   not Actor.Dead(213@)
else_jump @POOL2_19428 
Actor.PutAt(213@, 221@, 222@, 223@)
if 
00EC:   actor 213@ sphere 0 near_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" radius 2.0 2.0 
else_jump @POOL2_19428 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 213@ with_offset -2.0 0.0 -1.0 
Actor.PutAt(213@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
03CA:   object 82@ exists 
else_jump @POOL2_19428 
0655: AS_actor 213@ look_at_object 82@ 10000 ms 

:POOL2_19428
if 
  600@ == 1 
else_jump @POOL2_19543 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 215@ with_offset 0.1532 -0.9733 1.1819 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 215@ with_offset -0.0267 -0.3468 0.4236 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:POOL2_19543
if 
  600@ == 2 
else_jump @POOL2_19591 
" + tempvar_Float_1 + @" = 0.4 
" + tempvar_Float_2 + @" = -1.0 
" + tempvar_Float_3 + @" = 1.0 

:POOL2_19591
if 
  600@ == 3 
else_jump @POOL2_19639 
" + tempvar_Float_1 + @" = 0.3 
" + tempvar_Float_2 + @" = -0.5 
" + tempvar_Float_3 + @" = 1.0 

:POOL2_19639
if 
  600@ == 4 
else_jump @POOL2_19687 
" + tempvar_Float_1 + @" = 0.3 
" + tempvar_Float_2 + @" = -0.5 
" + tempvar_Float_3 + @" = 1.0 

:POOL2_19687
if 
   not 600@ == 1 
else_jump @POOL2_19796 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 215@ with_offset " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 82@ with_offset 0.0 0.3 0.0 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:POOL2_19796
return 

:POOL2_19798
if 
  230@ == 1 
else_jump @POOL2_19898 
0087: 249@ = 246@ 
0063: 249@ -= 247@ 
249@ /= 0.1 
0087: 248@ = 249@ 
248@ *= 2.0 
if 
  0.6 > 248@ 
else_jump @POOL2_19891 
248@ = 0.6 

:POOL2_19891
jump @POOL2_19955 

:POOL2_19898
0087: 248@ = 364@ 
248@ *= 2.0 
if 
  0.6 > 248@ 
else_jump @POOL2_19947 
248@ = 0.6 

:POOL2_19947
0087: 249@ = 364@ 

:POOL2_19955
if 
03CA:   object 82@ exists 
else_jump @POOL2_20844 
" + tempvar_Angle + @" = Object.Angle(82@)
02F6: 42@ = sine " + tempvar_Angle + @" 
0087: 169@ = 42@ 
169@ *= -1.0 
02F7: 42@ = cosine " + tempvar_Angle + @" 
0087: 170@ = 42@ 
171@ = 0.0 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0089: 165@ = " + tempvar_Float_1 + @" 
005B: 165@ += 169@ 
0089: 166@ = " + tempvar_Float_2 + @" 
005B: 166@ += 170@ 
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 165@ 166@ 
0073: 169@ /= 42@ 
0073: 170@ /= 42@ 
006B: 169@ *= 249@ 
006B: 170@ *= 249@ 
Object.KeepInMemory(82@) = False
Object.CollisionDetection(82@) = False
Object.ToggleInMovingList(82@) = False
Object.Throw(82@, 169@, 170@, 171@)
278@ = -1 
279@ = 0 
277@ = 0 
206@ = 0 
39@ = 0 

:POOL2_20196
if 
  16 > 39@ 
else_jump @POOL2_20239 
109@(39@,16i) = 0 
39@ += 1 
jump @POOL2_20196 

:POOL2_20239
097B: play_audio_at_object 82@ event 1014 
253@ = 0.0 
254@ = 0.0 
0088: " + tempvar_Float_1 + @" = 622@ 
0067: " + tempvar_Float_1 + @" -= 618@ 
0088: " + tempvar_Float_2 + @" = 623@ 
0067: " + tempvar_Float_2 + @" -= 619@ 
0075: " + tempvar_Float_1 + @" /= 620@ 
0075: " + tempvar_Float_2 + @" /= 621@ 
if 
  230@ == 0 
else_jump @POOL2_20363 
0208: " + tempvar_Float_1 + @" = random_float_in_ranges -0.2 0.2 
0208: " + tempvar_Float_2 + @" = random_float_in_ranges -0.2 0.2 

:POOL2_20363
if or
  " + tempvar_Float_1 + @" > 0.2 
  -0.2 > " + tempvar_Float_1 + @" 
  " + tempvar_Float_2 + @" > 0.2 
  -0.2 > " + tempvar_Float_2 + @" 
  230@ == 0 
else_jump @POOL2_20534 
006D: " + tempvar_Float_1 + @" *= 249@ 
006D: " + tempvar_Float_2 + @" *= 249@ 
0089: 253@ = " + tempvar_Float_1 + @" 
253@ *= 0.5 
0089: 254@ = " + tempvar_Float_2 + @" 
254@ *= -0.5 
" + tempvar_Float_1 + @" *= 10.0 
" + tempvar_Float_2 + @" *= 10.0 
if 
  230@ == 1 
else_jump @POOL2_20527 
05A2: set_object 82@ rotation_velocity_about_an_axis " + tempvar_Float_2 + @" 0.0 " + tempvar_Float_1 + @" through_center_of_mass 

:POOL2_20527
jump @POOL2_20554 

:POOL2_20534
253@ = 0.0 
254@ = 0.0 

:POOL2_20554
622@ = 559.0 
623@ = 381.0 
if 
  129@ == 1 
else_jump @POOL2_20744 
03A9: save_newline_to_debug_file 
05B6: 20 
03A8: save_float_to_debug_file 249@ 
03A8: save_float_to_debug_file " + tempvar_Float_1 + @" 
03A8: save_float_to_debug_file " + tempvar_Float_2 + @" 
03A8: save_float_to_debug_file " + tempvar_Float_3 + @" 

:POOL2_20744
Object.CollisionDetection(82@) = True
Object.ToggleInMovingList(82@) = True
if 
   not Actor.Dead(213@)
else_jump @POOL2_20801 
if 
03CA:   object 82@ exists 
else_jump @POOL2_20801 
0655: AS_actor 213@ look_at_object 82@ 10000 ms 

:POOL2_20801
if 
   not Actor.Dead(214@)
else_jump @POOL2_20844 
if 
03CA:   object 82@ exists 
else_jump @POOL2_20844 
0655: AS_actor 214@ look_at_object 82@ 10000 ms 

:POOL2_20844
250@ = 1 
return 

:POOL2_20853
if 
  35@ == 0 
else_jump @POOL2_21171 
if 
   not Actor.Dead(215@)
else_jump @POOL2_21171 
Object.StorePos(163@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0089: 169@ = " + tempvar_Float_1 + @" 
0063: 169@ -= 584@ 
0089: 170@ = " + tempvar_Float_2 + @" 
0063: 170@ -= 588@ 
005F: " + tempvar_Float_1 + @" += 169@ 
005F: " + tempvar_Float_2 + @" += 170@ 
" + tempvar_Float_3 + @" += 2.5 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
Object.StorePos(163@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Float_3 + @" += 0.5 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
32@ = 0 
04C4: store_coords_to 165@ 166@ 167@ from_actor 215@ with_offset 0.0 -0.2 0.0 
02CE: 167@ = ground_z_at 165@ 166@ 167@ 
" + tempvar_Angle + @" = Actor.Angle(215@)
Actor.PutAt(215@, 610@, 611@, 612@)
Actor.Angle(215@) = " + tempvar_Angle + @"
if 
  108@ == 0 
else_jump @POOL2_21164 
0812: AS_actor 215@ perform_animation ""POOL_IDLE_STANCE"" IFP ""POOL"" framedelta 1000.0 loopA 1 lockX 1 lockY 1 lockF 0 time -1 

:POOL2_21164
35@ += 1 

:POOL2_21171
if 
  35@ == 1 
else_jump @POOL2_21296 
39@ = 0 
40@ = 0 

:POOL2_21203
if 
  16 > 39@ 
else_jump @POOL2_21264 
if 
  109@(39@,16i) == 1 
else_jump @POOL2_21250 
40@ += 1 

:POOL2_21250
39@ += 1 
jump @POOL2_21203 

:POOL2_21264
if 
  40@ == 16 
else_jump @POOL2_21296 
35@ += 1 
32@ = 0 

:POOL2_21296
if 
  35@ == 2 
else_jump @POOL2_21340 
if 
  32@ > 700 
else_jump @POOL2_21340 
35@ = 99 

:POOL2_21340
if 
  35@ == 99 
else_jump @POOL2_21374 
03E6: remove_text_box 
34@ += 1 
35@ = 0 

:POOL2_21374
return 

:POOL2_21376
if 
  35@ == 0 
else_jump @POOL2_21408 
274@ = 0 
35@ += 1 

:POOL2_21408
if 
  35@ == 1 
else_jump @POOL2_21458 
if 
  278@ == -1 
else_jump @POOL2_21451 
274@ = 1 

:POOL2_21451
35@ += 1 

:POOL2_21458
if 
  35@ == 2 
else_jump @POOL2_21694 
if 
   not 278@ == -1 
else_jump @POOL2_21687 
if 
  231@ == -1 
else_jump @POOL2_21544 
if 
  278@ == 8 
else_jump @POOL2_21537 
274@ = 2 

:POOL2_21537
jump @POOL2_21687 

:POOL2_21544
if 
  231@ == 0 
else_jump @POOL2_21594 
if 
  278@ >= 8 
else_jump @POOL2_21587 
274@ = 2 

:POOL2_21587
jump @POOL2_21687 

:POOL2_21594
if 
  231@ == 1 
else_jump @POOL2_21644 
if 
  8 >= 278@ 
else_jump @POOL2_21637 
274@ = 2 

:POOL2_21637
jump @POOL2_21687 

:POOL2_21644
if 
  231@ == 2 
else_jump @POOL2_21687 
if 
   not 278@ == 8 
else_jump @POOL2_21687 
274@ = 2 

:POOL2_21687
35@ += 1 

:POOL2_21694
if 
  35@ == 3 
else_jump @POOL2_21744 
if 
  255@ == 1 
else_jump @POOL2_21737 
274@ = 3 

:POOL2_21737
35@ += 1 

:POOL2_21744
if 
  35@ == 4 
else_jump @POOL2_22338 
if 
  271@ == 1 
else_jump @POOL2_22016 
if 
   not 274@ == 3 
else_jump @POOL2_22009 
if 
  231@ == -1 
else_jump @POOL2_21859 
if 
   not 263@ == 1 
else_jump @POOL2_21852 
if 
  184@ == 0 
else_jump @POOL2_21852 

:POOL2_21852
jump @POOL2_22009 

:POOL2_21859
if 
  231@ == 0 
else_jump @POOL2_21909 
if 
  273@ > 0 
else_jump @POOL2_21902 
274@ = 4 

:POOL2_21902
jump @POOL2_22009 

:POOL2_21909
if 
  231@ == 1 
else_jump @POOL2_21959 
if 
  272@ > 0 
else_jump @POOL2_21952 
274@ = 4 

:POOL2_21952
jump @POOL2_22009 

:POOL2_21959
if 
  231@ == 2 
else_jump @POOL2_22009 
if or
  272@ > 0 
  273@ > 0 
else_jump @POOL2_22009 
274@ = 4 

:POOL2_22009
jump @POOL2_22331 

:POOL2_22016
if 
  271@ > 1 
else_jump @POOL2_22331 
if 
  231@ == -1 
else_jump @POOL2_22181 
if and
  272@ > 0 
  273@ == 0 
else_jump @POOL2_22113 
if 
   not 263@ == 1 
else_jump @POOL2_22113 
if 
  184@ == 0 
else_jump @POOL2_22113 

:POOL2_22113
if and
  272@ == 0 
  273@ > 0 
else_jump @POOL2_22174 
if 
   not 263@ == 1 
else_jump @POOL2_22174 
if 
  184@ == 0 
else_jump @POOL2_22174 

:POOL2_22174
jump @POOL2_22331 

:POOL2_22181
if 
  231@ == 0 
else_jump @POOL2_22231 
if 
  273@ > 0 
else_jump @POOL2_22224 
274@ = 4 

:POOL2_22224
jump @POOL2_22331 

:POOL2_22231
if 
  231@ == 1 
else_jump @POOL2_22281 
if 
  272@ > 0 
else_jump @POOL2_22274 
274@ = 4 

:POOL2_22274
jump @POOL2_22331 

:POOL2_22281
if 
  231@ == 2 
else_jump @POOL2_22331 
if or
  273@ > 0 
  272@ > 0 
else_jump @POOL2_22331 
274@ = 4 

:POOL2_22331
35@ += 1 

:POOL2_22338
if 
  35@ == 5 
else_jump @POOL2_22456 
if 
   not 231@ == 2 
else_jump @POOL2_22406 
if 
  263@ == 1 
else_jump @POOL2_22399 
274@ = 5 

:POOL2_22399
jump @POOL2_22449 

:POOL2_22406
if 
  263@ == 1 
else_jump @POOL2_22449 
if 
   not 274@ == 0 
else_jump @POOL2_22449 
274@ = 5 

:POOL2_22449
35@ += 1 

:POOL2_22456
if 
  35@ == 6 
else_jump @POOL2_22542 
if 
  274@ == 0 
else_jump @POOL2_22535 
if 
  271@ == 0 
else_jump @POOL2_22535 
if 
  277@ == 0 
else_jump @POOL2_22535 
274@ = 6 

:POOL2_22535
35@ = 99 

:POOL2_22542
if 
  35@ == 99 
else_jump @POOL2_22766 
if and
  274@ == 0 
  184@ == 0 
  271@ > 0 
  231@ == -1 
else_jump @POOL2_22750 
if 
001D:   272@ > 273@ 
else_jump @POOL2_22678 
if 
  229@ == 1 
else_jump @POOL2_22657 
217@ = 0 
218@ = 1 
jump @POOL2_22671 

:POOL2_22657
217@ = 1 
218@ = 0 

:POOL2_22671
jump @POOL2_22750 

:POOL2_22678
if 
001D:   273@ > 272@ 
else_jump @POOL2_22750 
if 
  229@ == 1 
else_jump @POOL2_22736 
217@ = 1 
218@ = 0 
jump @POOL2_22750 

:POOL2_22736
217@ = 0 
218@ = 1 

:POOL2_22750
03E6: remove_text_box 
35@ = 0 
34@ += 1 

:POOL2_22766
return 

:POOL2_22768
if 
  35@ == 0 
else_jump @POOL2_24594 
32@ = 0 
if and
  67@ == 1 
  68@ == 1 
  69@ == 1 
  70@ == 1 
  71@ == 1 
else_jump @POOL2_22914 
if and
  72@ == 1 
  73@ == 1 
else_jump @POOL2_22914 
if 
  217@ == 0 
else_jump @POOL2_22889 
217@ = 2 

:POOL2_22889
if 
  218@ == 0 
else_jump @POOL2_22914 
218@ = 2 

:POOL2_22914
if and
  75@ == 1 
  76@ == 1 
  77@ == 1 
  78@ == 1 
  79@ == 1 
else_jump @POOL2_23035 
if and
  80@ == 1 
  81@ == 1 
else_jump @POOL2_23035 
if 
  217@ == 1 
else_jump @POOL2_23010 
217@ = 2 

:POOL2_23010
if 
  218@ == 1 
else_jump @POOL2_23035 
218@ = 2 

:POOL2_23035
0871: init_jump_table 274@ total_jumps 7 default_jump 0 @POOL2_24479 jumps 0 @POOL2_23098 1 @POOL2_23429 2 @POOL2_23627 3 @POOL2_23825 4 @POOL2_24023 5 @POOL2_24221 6 @POOL2_24281 

:POOL2_23098
if 
  271@ > 0 
else_jump @POOL2_23231 
if 
   not 74@ == 1 
else_jump @POOL2_23203 
232@ = 0 
233@ = 1 
if 
  229@ == 1 
else_jump @POOL2_23181 
0085: 231@ = 217@ 
jump @POOL2_23189 

:POOL2_23181
0085: 231@ = 218@ 

:POOL2_23189
35@ = 99 
jump @POOL2_23224 

:POOL2_23203
276@ = 1 
275@ = 1 
35@ = 99 

:POOL2_23224
jump @POOL2_23422 

:POOL2_23231
if 
  229@ == 1 
else_jump @POOL2_23355 
232@ = 0 
229@ = 2 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
0085: 230@ = 220@ 
233@ = 0 
0085: 231@ = 218@ 
if 
  220@ == 1 
else_jump @POOL2_23334 
04AF: 180@ = 1 
jump @POOL2_23341 

:POOL2_23334
04AF: 180@ = 0 

:POOL2_23341
35@ = 99 
jump @POOL2_23422 

:POOL2_23355
232@ = 0 
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
233@ = 0 
0085: 231@ = 217@ 
04AF: 180@ = 0 
35@ = 99 

:POOL2_23422
jump @POOL2_24479 

:POOL2_23429
if 
  229@ == 1 
else_jump @POOL2_23553 
229@ = 2 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
0085: 230@ = 220@ 
232@ = 2 
233@ = 0 
0085: 231@ = 218@ 
if 
  220@ == 1 
else_jump @POOL2_23532 
04AF: 180@ = 1 
jump @POOL2_23539 

:POOL2_23532
04AF: 180@ = 0 

:POOL2_23539
35@ = 99 
jump @POOL2_23620 

:POOL2_23553
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
232@ = 2 
233@ = 0 
0085: 231@ = 217@ 
04AF: 180@ = 0 
35@ = 99 

:POOL2_23620
jump @POOL2_24479 

:POOL2_23627
if 
  229@ == 1 
else_jump @POOL2_23751 
229@ = 2 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
0085: 230@ = 220@ 
232@ = 2 
233@ = 0 
0085: 231@ = 218@ 
if 
  220@ == 1 
else_jump @POOL2_23730 
04AF: 180@ = 1 
jump @POOL2_23737 

:POOL2_23730
04AF: 180@ = 0 

:POOL2_23737
35@ = 99 
jump @POOL2_23818 

:POOL2_23751
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
232@ = 2 
233@ = 0 
0085: 231@ = 217@ 
04AF: 180@ = 0 
35@ = 99 

:POOL2_23818
jump @POOL2_24479 

:POOL2_23825
if 
  229@ == 1 
else_jump @POOL2_23949 
229@ = 2 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
0085: 230@ = 220@ 
232@ = 2 
233@ = 0 
0085: 231@ = 218@ 
if 
  220@ == 1 
else_jump @POOL2_23928 
04AF: 180@ = 1 
jump @POOL2_23935 

:POOL2_23928
04AF: 180@ = 0 

:POOL2_23935
35@ = 99 
jump @POOL2_24016 

:POOL2_23949
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
232@ = 2 
233@ = 0 
0085: 231@ = 217@ 
04AF: 180@ = 0 
35@ = 99 

:POOL2_24016
jump @POOL2_24479 

:POOL2_24023
if 
  229@ == 1 
else_jump @POOL2_24147 
229@ = 2 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
0085: 230@ = 220@ 
232@ = 2 
233@ = 0 
0085: 231@ = 218@ 
if 
  220@ == 1 
else_jump @POOL2_24126 
04AF: 180@ = 1 
jump @POOL2_24133 

:POOL2_24126
04AF: 180@ = 0 

:POOL2_24133
35@ = 99 
jump @POOL2_24214 

:POOL2_24147
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
232@ = 2 
233@ = 0 
0085: 231@ = 217@ 
04AF: 180@ = 0 
35@ = 99 

:POOL2_24214
jump @POOL2_24479 

:POOL2_24221
if 
  184@ == 0 
else_jump @POOL2_24253 
275@ = 0 
jump @POOL2_24260 

:POOL2_24253
275@ = 1 

:POOL2_24260
276@ = 1 
35@ = 99 
jump @POOL2_24479 

:POOL2_24281
if 
  229@ == 1 
else_jump @POOL2_24405 
229@ = 2 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
0085: 230@ = 220@ 
232@ = 2 
233@ = 0 
0085: 231@ = 218@ 
if 
  220@ == 1 
else_jump @POOL2_24384 
04AF: 180@ = 1 
jump @POOL2_24391 

:POOL2_24384
04AF: 180@ = 0 

:POOL2_24391
35@ = 99 
jump @POOL2_24472 

:POOL2_24405
229@ = 1 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
0085: 230@ = 219@ 
232@ = 2 
233@ = 0 
0085: 231@ = 217@ 
04AF: 180@ = 0 
35@ = 99 

:POOL2_24472
jump @POOL2_24479 

:POOL2_24479
if 
  178@ == 0 
else_jump @POOL2_24533 
if 
  230@ == 1 
else_jump @POOL2_24526 
0512: show_permanent_text_box 'PL_H5'  

:POOL2_24526
jump @POOL2_24580 

:POOL2_24533
if 
04A4:   180@ == 0 
else_jump @POOL2_24569 
0512: show_permanent_text_box 'PL_H8'  
jump @POOL2_24580 

:POOL2_24569
0512: show_permanent_text_box 'PL_H9'  

:POOL2_24580
32@ = 0 
33@ = 0 

:POOL2_24594
if 
  35@ == 99 
else_jump @POOL2_24702 
gosub @POOL2_54829 
if 
  230@ == 1 
else_jump @POOL2_24669 
if 
00E1:   player 180@ pressed_key 16 
else_jump @POOL2_24662 
35@ += 1 

:POOL2_24662
jump @POOL2_24702 

:POOL2_24669
if or
  33@ > 2000 
00E1:   player 180@ pressed_key 16 
else_jump @POOL2_24702 
35@ += 1 

:POOL2_24702
if 
  35@ == 100 
else_jump @POOL2_24864 
03E6: remove_text_box 
39@ = 0 
271@ = 0 

:POOL2_24736
if 
  16 > 39@ 
else_jump @POOL2_24779 
255@(39@,16i) = 0 
39@ += 1 
jump @POOL2_24736 

:POOL2_24779
272@ = 0 
273@ = 0 
if 
  276@ == 1 
else_jump @POOL2_24839 
184@ = 1 
34@ += 1 
35@ = 0 
jump @POOL2_24860 

:POOL2_24839
184@ = 0 
34@ = 3 
35@ = 0 

:POOL2_24860
wait 0 

:POOL2_24864
return 

:POOL2_24866
if 
  35@ == 0 
else_jump @POOL2_25319 
if 
  275@ == 0 
else_jump @POOL2_24966 
if 
  229@ == 1 
else_jump @POOL2_24943 
0085: 215@ = 214@ 
0085: 216@ = 107@ 
jump @POOL2_24959 

:POOL2_24943
0085: 215@ = 213@ 
0085: 216@ = 106@ 

:POOL2_24959
jump @POOL2_25023 

:POOL2_24966
if 
  229@ == 1 
else_jump @POOL2_25007 
0085: 215@ = 213@ 
0085: 216@ = 106@ 
jump @POOL2_25023 

:POOL2_25007
0085: 215@ = 214@ 
0085: 216@ = 107@ 

:POOL2_25023
if 
   not Actor.Dead(215@)
else_jump @POOL2_25319 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 215@ with_offset 1.0 2.0 0.0 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
Camera.OnPed(215@, 15, 2)
if 
  178@ == 0 
else_jump @POOL2_25247 
if 
003B:   215@ == 213@ 
else_jump @POOL2_25209 
0085: 39@ = 162@ 
39@ *= 2 
Player.Money(" + PlayerChar + @") += 39@" );
create_thread<CASHWIN>( _local39, 5000, 80 );
AppendLine( @"if 
   not Actor.Dead(164@)
else_jump @POOL2_25202 
03FE: set_actor 164@ money 0 

:POOL2_25202
jump @POOL2_25240 

:POOL2_25209
0085: 39@ = 162@ 
39@ *= -1" );
create_thread<CASHWIN>( _local39, 5000, 80 );
AppendLine( @"
:POOL2_25240
jump @POOL2_25305 

:POOL2_25247
if 
003B:   215@ == 213@ 
else_jump @POOL2_25289 
00BA: show_text_styled GXT 'PL_08' time 5000 style 1  
jump @POOL2_25305 

:POOL2_25289
00BA: show_text_styled GXT 'PL_09' time 5000 style 1  

:POOL2_25305
32@ = 0 
35@ += 1 

:POOL2_25319
if 
  35@ == 1 
else_jump @POOL2_25363 
if 
  32@ > 5000 
else_jump @POOL2_25363 
35@ += 1 

:POOL2_25363
if 
  35@ == 2 
else_jump @POOL2_25936 
fade 0 500 

:POOL2_25388
if 
fading 
else_jump @POOL2_25412 
wait 0 
jump @POOL2_25388 

:POOL2_25412
39@ = 0 

:POOL2_25419
if 
  16 > 39@ 
else_jump @POOL2_25480 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_25466 
Object.Destroy(82@(39@,16i))

:POOL2_25466
39@ += 1 
jump @POOL2_25419 

:POOL2_25480
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 163@ with_offset -0.2734375 -0.0546875 0.9296875 
82@ = Object.Init(#K_POOLBALLCUE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(163@)
" + tempvar_Angle + @" += 270.0 
Object.Angle(82@) = " + tempvar_Angle + @"
0400: store_coords_to 558@ 559@ 560@ from_object 163@ with_offset 0.3408 -0.0284 0.9297 
561@ = Object.Angle(163@)
561@ += 90.0 
83@ = Object.Init(#K_POOLBALLSPT01, 558@, 559@, 560@)
84@ = Object.Init(#K_POOLBALLSPT02, 0.0, 0.0, 0.0)
85@ = Object.Init(#K_POOLBALLSPT03, 0.0, 0.0, 0.0)
86@ = Object.Init(#K_POOLBALLSPT04, 0.0, 0.0, 0.0)
87@ = Object.Init(#K_POOLBALLSPT05, 0.0, 0.0, 0.0)
88@ = Object.Init(#K_POOLBALLSPT06, 0.0, 0.0, 0.0)
89@ = Object.Init(#K_POOLBALLSPT07, 0.0, 0.0, 0.0)
90@ = Object.Init(#K_POOLBALL8, 0.0, 0.0, 0.0)
91@ = Object.Init(#K_POOLBALLSTP01, 0.0, 0.0, 0.0)
92@ = Object.Init(#K_POOLBALLSTP02, 0.0, 0.0, 0.0)
93@ = Object.Init(#K_POOLBALLSTP03, 0.0, 0.0, 0.0)
94@ = Object.Init(#K_POOLBALLSTP04, 0.0, 0.0, 0.0)
95@ = Object.Init(#K_POOLBALLSTP05, 0.0, 0.0, 0.0)
96@ = Object.Init(#K_POOLBALLSTP06, 0.0, 0.0, 0.0)
97@ = Object.Init(#K_POOLBALLSTP07, 0.0, 0.0, 0.0)
gosub @POOL2_50546 
35@ = 99 

:POOL2_25936
if 
  35@ == 99 
else_jump @POOL2_25970 
03E6: remove_text_box 
34@ += 1 
35@ = 0 

:POOL2_25970
return 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.3 3.36 
0342: set_text_draw_centered 1 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 3 
0904: get_interface 6 color_RGBA_to " + Color_Red + @" " + Color_Green + @" " + Gambles_CashWin + @" " + _3400 + @" 
0340: set_text_draw_RGBA " + Color_Red + @" " + Color_Green + @" " + Gambles_CashWin + @" 255 
return 

:POOL2_26060
275@ = 0 
271@ = 0 
272@ = 0 
273@ = 0 
274@ = 0 
39@ = 0 

:POOL2_26102
if 
  16 > 39@ 
else_jump @POOL2_26156 
255@(39@,16i) = 0 
66@(39@,16i) = 0 
39@ += 1 
jump @POOL2_26102 

:POOL2_26156
232@ = 0 
276@ = 0 
34@ = 1 
35@ = 0 
return 

:POOL2_26186
if 
03CA:   object 163@ exists 
else_jump @POOL2_26234 
Object.StorePos(163@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0395: clear_area 1 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 10.0 

:POOL2_26234
if 
03CA:   object 82@ exists 
else_jump @POOL2_26272 
05A8: get_object 82@ speed_to 48@ 
05A6: get_object 82@ rotation_velocity_about_an_axis_X 49@ axis_Y 50@ axis_Z 51@ through_center_of_body 

:POOL2_26272
if 
  206@ > 2000 
else_jump @POOL2_26762 
0088: " + tempvar_Float_1 + @" = 204@ 
" + tempvar_Float_1 + @" *= -1.0 
39@ = 0 

:POOL2_26316
if 
  16 > 39@ 
else_jump @POOL2_26762 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_26737 
05A8: get_object 82@(39@,16i) speed_to 42@ 
if 
0025:   203@ > 42@ 
else_jump @POOL2_26719 
if 
  0.005 > 42@ 
else_jump @POOL2_26635 
05A6: get_object 82@(39@,16i) rotation_velocity_about_an_axis_X 42@ axis_Y 43@ axis_Z 44@ through_center_of_body 
40@ = 0 
if or
0025:   42@ > 204@ 
0026:   " + tempvar_Float_1 + @" > 42@ 
else_jump @POOL2_26465 
40@ = 1 

:POOL2_26465
if or
0025:   43@ > 204@ 
0026:   " + tempvar_Float_1 + @" > 43@ 
else_jump @POOL2_26499 
40@ = 1 

:POOL2_26499
if or
0025:   44@ > 204@ 
0026:   " + tempvar_Float_1 + @" > 44@ 
else_jump @POOL2_26533 
40@ = 1 

:POOL2_26533
if 
  40@ == 0 
else_jump @POOL2_26617 
Object.Throw(82@(39@,16i), 0.0, 0.0, 0.0)
05A2: set_object 82@(39@,16i) rotation_velocity_about_an_axis 0.0 0.0 0.0 through_center_of_mass 
109@(39@,16i) = 1 
jump @POOL2_26628 

:POOL2_26617
109@(39@,16i) = 0 

:POOL2_26628
jump @POOL2_26712 

:POOL2_26635
059F: get_object 82@(39@,16i) velocity_in_direction " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_1 + @" *= 0.9 
" + tempvar_Float_2 + @" *= 0.9 
" + tempvar_Float_3 + @" *= 0.9 
Object.Throw(82@(39@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
109@(39@,16i) = 0 

:POOL2_26712
jump @POOL2_26730 

:POOL2_26719
109@(39@,16i) = 0 

:POOL2_26730
jump @POOL2_26748 

:POOL2_26737
109@(39@,16i) = 1 

:POOL2_26748
39@ += 1 
jump @POOL2_26316 

:POOL2_26762
if 
   not 108@ == 1 
else_jump @POOL2_26826 
0085: 358@ = 213@ 
0085: 359@ = 106@ 
gosub @POOL2_30670 
0085: 358@ = 214@ 
0085: 359@ = 107@ 
gosub @POOL2_30670 

:POOL2_26826
253@ *= 0.98 
254@ *= 0.98 
39@ = 0 

:POOL2_26853
if 
  16 > 39@ 
else_jump @POOL2_27127 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_27113 
Object.StorePos(82@(39@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 43@ = 52@ 
43@ *= 2.0 
0087: 42@ = 560@ 
0063: 42@ -= 43@ 
if 
0027:   42@ > " + tempvar_Float_3 + @" 
else_jump @POOL2_27113 
if 
  66@(39@,16i) == 0 
else_jump @POOL2_27113 
097A: play_audio_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" event 1017 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_27027 
Object.Destroy(82@(39@,16i))

:POOL2_27027
66@(39@,16i) = 1 
255@(39@,16i) = 1 
271@ += 1 
if and
  39@ > 0 
  8 > 39@ 
else_jump @POOL2_27088 
272@ += 1 

:POOL2_27088
if 
  39@ > 8 
else_jump @POOL2_27113 
273@ += 1 

:POOL2_27113
39@ += 1 
jump @POOL2_26853 

:POOL2_27127
39@ = 0 

:POOL2_27134
if 
  16 > 39@ 
else_jump @POOL2_27513 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_27499 
if 
08FF:   object 82@(39@,16i) received_damage_type 54 
else_jump @POOL2_27226 
277@ += 1 
if 
  39@ == 0 
else_jump @POOL2_27226 
279@ = 1 

:POOL2_27226
if 
  278@ == -1 
else_jump @POOL2_27342 
if 
  39@ > 0 
else_jump @POOL2_27342 
if 
08FF:   object 82@(39@,16i) received_damage_type 53 
else_jump @POOL2_27342 
0085: 278@ = 39@ 
if 
  279@ == 0 
else_jump @POOL2_27342 
if 
03CA:   object 82@ exists 
else_jump @POOL2_27342 
05A7: set_object 82@ velocity_in_direction_X 253@ direction_Y 254@ direction_Z 0.0 

:POOL2_27342
if 
08FF:   object 82@(39@,16i) received_damage_type 50 
else_jump @POOL2_27490 
277@ += 1 
if 
  39@ == 0 
else_jump @POOL2_27396 
279@ = 1 

:POOL2_27396
if 
  278@ == -1 
else_jump @POOL2_27490 
if 
  39@ > 0 
else_jump @POOL2_27490 
0085: 278@ = 39@ 
if 
  279@ == 0 
else_jump @POOL2_27490 
if 
03CA:   object 82@ exists 
else_jump @POOL2_27490 
05A7: set_object 82@ velocity_in_direction_X 253@ direction_Y 254@ direction_Z 0.0 

:POOL2_27490
0900: clear_object 82@(39@,16i) last_weapon_damage 

:POOL2_27499
39@ += 1 
jump @POOL2_27134 

:POOL2_27513
if 
0736:   is_keyboard_key_just_pressed 68 
else_jump @POOL2_27604 
if 
  129@ == 1 
else_jump @POOL2_27579 
129@ = 0 
0662: printstring ""OUTPUT_TEXT_OFF"" 
jump @POOL2_27604 

:POOL2_27579
129@ = 1 
0662: printstring ""OUTPUT_TEXT_ON"" 

:POOL2_27604
if 
83CA:   not object 163@ exists 
else_jump @POOL2_27627 
34@ = 99 

:POOL2_27627
if 
   not Actor.Dead(164@)
else_jump @POOL2_27651 
" + _6459 + @" = Actor.Health(164@)

:POOL2_27651
if 
   Actor.Dead(164@)
else_jump @POOL2_27674 
34@ = 99 

:POOL2_27674
if 
  108@ == 1 
else_jump @POOL2_28237 
0826: enable_hud 1 
if 
  161@ > 0 
else_jump @POOL2_27722 
Player.Money(" + PlayerChar + @") += 161@

:POOL2_27722
if 
   not Actor.Dead(164@)
else_jump @POOL2_27794 
Actor.LockInCurrentPosition(164@) = False
065C: release_decision_maker 207@ 
060A: create_decision_maker_type 2 store_to 207@ 
060B: set_actor 164@ decision_maker_to 207@ 
0619: enable_actor 164@ collision_detection 1 
Actor.SetImmunities(164@, 0, 0, 0, 0, 0)
06AB: set_actor 164@ all_weapons_hidden 1 

:POOL2_27794
03DE: set_pedestrians_density_multiplier_to 1.0 
03F0: enable_text_draw 0 
0581: enable_radar 1 
39@ = 0 

:POOL2_27816
if 
  16 > 39@ 
else_jump @POOL2_27857 
Object.RemoveReferences(82@(39@,16i))
39@ += 1 
jump @POOL2_27816 

:POOL2_27857
Camera.Restore_WithJumpCut
if 
03CA:   object 238@ exists 
else_jump @POOL2_27880 
Object.Destroy(238@)

:POOL2_27880
104@ += 0.1 
Object.PutAt(163@, 102@, 103@, 104@)
0400: store_coords_to 98@ 100@ " + tempvar_Float_3 + @" from_object 163@ with_offset -0.96 -0.49 0.7 
0400: store_coords_to 99@ 101@ " + tempvar_Float_3 + @" from_object 163@ with_offset 0.96 0.49 0.7 
if 
0025:   98@ > 99@ 
else_jump @POOL2_28005 
0088: " + tempvar_Float_1 + @" = 98@ 
0087: 98@ = 99@ 
0089: 99@ = " + tempvar_Float_1 + @" 

:POOL2_28005
if 
0025:   100@ > 101@ 
else_jump @POOL2_28048 
0088: " + tempvar_Float_2 + @" = 100@ 
0087: 100@ = 101@ 
0089: 101@ = " + tempvar_Float_2 + @" 

:POOL2_28048
0830: create_pool_table_collision_cornerA 98@ 100@ " + tempvar_Float_3 + @" cornerB 99@ 101@ " + tempvar_Float_3 + @" 
39@ = 0 

:POOL2_28075
if 
  16 > 39@ 
else_jump @POOL2_28173 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_28159 
Object.StorePos(82@(39@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Float_3 + @" += 0.1 
Object.PutAt(82@(39@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:POOL2_28159
39@ += 1 
jump @POOL2_28075 

:POOL2_28173
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_28215 
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 

:POOL2_28215
Object.Destroy(106@)
Object.Destroy(107@)
Model.Destroy(#K_POOLQ)
04EF: release_animation ""POOL"" 

:POOL2_28237
if and
  34@ == 99 
  108@ == 0 
else_jump @POOL2_28282 
03F0: enable_text_draw 0 
0581: enable_radar 1 
34@ = 0 
wait 500 

:POOL2_28282
if 
0736:   is_keyboard_key_just_pressed 73 
else_jump @POOL2_28394 
if 
03CA:   object 82@ exists 
else_jump @POOL2_28394 
Object.KeepInMemory(82@) = False
Object.CollisionDetection(82@) = False
Object.ToggleInMovingList(82@) = False
0208: " + tempvar_Float_1 + @" = random_float_in_ranges -5.0 5.0 
0208: " + tempvar_Float_2 + @" = random_float_in_ranges -5.0 5.0 
Object.Throw(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 0.0)
Object.CollisionDetection(82@) = True
Object.ToggleInMovingList(82@) = True

:POOL2_28394
return 

:POOL2_28396
281@ = 0 
280@ = 1.7 
if 
03CA:   object 82@ exists 
else_jump @POOL2_28619 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 42@ = 98@ 
42@ += 0.02 
if 
0027:   42@ > " + tempvar_Float_1 + @" 
else_jump @POOL2_28487 
281@ = 99 

:POOL2_28487
0087: 42@ = 99@ 
42@ -= 0.02 
if 
0026:   " + tempvar_Float_1 + @" > 42@ 
else_jump @POOL2_28531 
281@ = 99 

:POOL2_28531
0087: 42@ = 100@ 
42@ += 0.02 
if 
0027:   42@ > " + tempvar_Float_2 + @" 
else_jump @POOL2_28575 
281@ = 99 

:POOL2_28575
0087: 42@ = 101@ 
42@ -= 0.02 
if 
0026:   " + tempvar_Float_2 + @" > 42@ 
else_jump @POOL2_28619 
281@ = 99 

:POOL2_28619
if 
   not 281@ == 99 
else_jump @POOL2_30668 
if 
   not 240@ == 0 
else_jump @POOL2_28662 
281@ = 2 

:POOL2_28662
if 
  281@ == 0 
else_jump @POOL2_29271 
if 
03CA:   object 82@ exists 
else_jump @POOL2_29271 
39@ = 0 

:POOL2_28703
if 
  3 > 39@ 
else_jump @POOL2_28847 
304@(39@,3f) = -999999.9 
307@(39@,3f) = -999999.9 
310@(39@,3f) = -999999.9 
313@(39@,3f) = -999999.9 
316@(39@,3f) = -999999.9 
319@(39@,3f) = -999999.9 
322@(39@,3f) = -999999.9 
325@(39@,3f) = -999999.9 
39@ += 1 
jump @POOL2_28703 

:POOL2_28847
0087: 301@ = 280@ 
0087: 301@ = 280@ 
0087: 300@ = 280@ 
300@ /= 10.0 
" + tempvar_Angle + @" = Object.Angle(82@)
0453: set_object 82@ XYZ_rotation 0.0 0.0 " + tempvar_Angle + @" 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
0027:   98@ > " + tempvar_Float_1 + @" 
else_jump @POOL2_28958 
0088: " + tempvar_Float_1 + @" = 98@ 
" + tempvar_Float_1 + @" += 0.01 

:POOL2_28958
if 
0026:   " + tempvar_Float_1 + @" > 99@ 
else_jump @POOL2_28995 
0088: " + tempvar_Float_1 + @" = 99@ 
" + tempvar_Float_1 + @" -= 0.01 

:POOL2_28995
if 
0027:   100@ > " + tempvar_Float_2 + @" 
else_jump @POOL2_29032 
0088: " + tempvar_Float_2 + @" = 100@ 
" + tempvar_Float_2 + @" += 0.01 

:POOL2_29032
if 
0026:   " + tempvar_Float_2 + @" > 101@ 
else_jump @POOL2_29069 
0088: " + tempvar_Float_2 + @" = 101@ 
" + tempvar_Float_2 + @" -= 0.01 

:POOL2_29069
0400: store_coords_to 165@ 166@ 167@ from_object 82@ with_offset 0.0 1.0 0.0 
0087: 282@ = 165@ 
0065: 282@ -= " + tempvar_Float_1 + @" 
0087: 283@ = 166@ 
0065: 283@ -= " + tempvar_Float_2 + @" 
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 165@ 166@ 
0073: 282@ /= 42@ 
0073: 283@ /= 42@ 
006B: 282@ *= 301@ 
006B: 283@ *= 301@ 
0089: 487@ = " + tempvar_Float_1 + @" 
0089: 488@ = " + tempvar_Float_2 + @" 
0089: 304@ = " + tempvar_Float_1 + @" 
0089: 307@ = " + tempvar_Float_2 + @" 
0089: 483@ = " + tempvar_Float_1 + @" 
005B: 483@ += 282@ 
0089: 484@ = " + tempvar_Float_2 + @" 
005B: 484@ += 283@ 
284@ = 0 
328@ = 0 
515@ = 0 
281@ += 1 

:POOL2_29271
if 
  281@ == 1 
else_jump @POOL2_29690 
241@ = 0 

:POOL2_29296
if and
  301@ > 0.0 
  3 > 284@ 
else_jump @POOL2_29676 
gosub @POOL2_48189 
0087: 310@(284@,3f) = 505@ 
0087: 313@(284@,3f) = 506@ 
0085: 39@ = 284@ 
39@ += 1 
if 
  3 > 39@ 
else_jump @POOL2_29412 
0087: 304@(39@,3f) = 505@ 
0087: 307@(39@,3f) = 506@ 

:POOL2_29412
0509: 42@ = distance_between_XY 304@(284@,3f) 307@(284@,3f) and_XY 310@(284@,3f) 313@(284@,3f) 
0063: 301@ -= 42@ 
if 
  485@ == 0 
else_jump @POOL2_29662 
if 
   not 504@ == -1 
else_jump @POOL2_29506 
301@ *= 0.5 
jump @POOL2_29516 

:POOL2_29506
301@ *= 0.75 

:POOL2_29516
if 
  328@ == 0 
else_jump @POOL2_29584 
if 
   not 504@ == -1 
else_jump @POOL2_29584 
0085: 328@ = 504@ 
0087: 329@ = 301@ 
0087: 330@ = 509@ 
0087: 331@ = 510@ 

:POOL2_29584
0087: 487@ = 505@ 
0087: 488@ = 506@ 
006B: 507@ *= 301@ 
006B: 508@ *= 301@ 
0087: 483@ = 487@ 
005B: 483@ += 507@ 
0087: 484@ = 488@ 
005B: 484@ += 508@ 
284@ += 1 
jump @POOL2_29669 

:POOL2_29662
284@ = 3 

:POOL2_29669
jump @POOL2_29296 

:POOL2_29676
240@ += 1 
281@ += 1 

:POOL2_29690
if 
  281@ == 2 
else_jump @POOL2_30636 
39@ = 0 

:POOL2_29715
if 
  10 > 39@ 
else_jump @POOL2_29827 
if 
03CA:   object 347@(39@,10i) exists 
else_jump @POOL2_29762 
Object.Destroy(347@(39@,10i))

:POOL2_29762
347@(39@,10i) = Object.Create(#K_POOLBALLCUE, 0.0, 0.0, 0.0)
Object.CollisionDetection(347@(39@,10i)) = False
08D2: object 347@(39@,10i) scale_model 0.3 
39@ += 1 
jump @POOL2_29715 

:POOL2_29827
357@ = 0 
343@ = 0.005 
007B: 342@ += frame_delta_time * 343@ 
if 
0025:   342@ > 300@ 
else_jump @POOL2_29879 
0063: 342@ -= 300@ 

:POOL2_29879
346@ = 0.0 
39@ = 0 

:POOL2_29896
if 
  3 > 39@ 
else_jump @POOL2_30629 
if and
  304@(39@,3f) > -9999.9 
  307@(39@,3f) > -9999.9 
  310@(39@,3f) > -9999.9 
  313@(39@,3f) > -9999.9 
else_jump @POOL2_30615 
0509: 42@ = distance_between_XY 304@(39@,3f) 307@(39@,3f) and_XY 310@(39@,3f) 313@(39@,3f) 
0087: 169@ = 310@(39@,3f) 
0063: 169@ -= 304@(39@,3f) 
0087: 170@ = 313@(39@,3f) 
0063: 170@ -= 307@(39@,3f) 
0087: 43@ = 42@ 
0073: 43@ /= 300@ 
0092: 40@ = float 43@ to_integer 
40@ += 1 
0073: 169@ /= 42@ 
0073: 170@ /= 42@ 
0087: 344@ = 169@ 
0087: 345@ = 170@ 
006B: 344@ *= 342@ 
006B: 345@ *= 342@ 
006B: 169@ *= 300@ 
006B: 170@ *= 300@ 
if 
03CA:   object 82@ exists 
else_jump @POOL2_30335 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
0027:   98@ > " + tempvar_Float_1 + @" 
else_jump @POOL2_30224 
0088: " + tempvar_Float_1 + @" = 98@ 
" + tempvar_Float_1 + @" += 0.01 

:POOL2_30224
if 
0026:   " + tempvar_Float_1 + @" > 99@ 
else_jump @POOL2_30261 
0088: " + tempvar_Float_1 + @" = 99@ 
" + tempvar_Float_1 + @" -= 0.01 

:POOL2_30261
if 
0027:   100@ > " + tempvar_Float_2 + @" 
else_jump @POOL2_30298 
0088: " + tempvar_Float_2 + @" = 100@ 
" + tempvar_Float_2 + @" += 0.01 

:POOL2_30298
if 
0026:   " + tempvar_Float_2 + @" > 101@ 
else_jump @POOL2_30335 
0088: " + tempvar_Float_2 + @" = 101@ 
" + tempvar_Float_2 + @" -= 0.01 

:POOL2_30335
0087: 196@ = 304@(39@,3f) 
0063: 196@ -= 169@ 
0087: 197@ = 307@(39@,3f) 
0063: 197@ -= 170@ 
005B: 196@ += 344@ 
005B: 197@ += 345@ 
005A: 40@ += 357@ 

:POOL2_30399
if and
001D:   40@ > 357@ 
  10 > 357@ 
else_jump @POOL2_30615 
0088: " + tempvar_Float_1 + @" = 196@ 
005F: " + tempvar_Float_1 + @" += 169@ 
0088: " + tempvar_Float_2 + @" = 197@ 
005F: " + tempvar_Float_2 + @" += 170@ 
0089: 196@ = " + tempvar_Float_1 + @" 
0089: 197@ = " + tempvar_Float_2 + @" 
if 
03CA:   object 347@(357@,10i) exists 
else_jump @POOL2_30601 
if or
0026:   " + tempvar_Float_1 + @" > 99@ 
0027:   98@ > " + tempvar_Float_1 + @" 
0026:   " + tempvar_Float_2 + @" > 101@ 
0027:   100@ > " + tempvar_Float_2 + @" 
else_jump @POOL2_30572 
0750: set_object 347@(357@,10i) visibility 0 
Object.PutAt(347@(357@,10i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
jump @POOL2_30601 

:POOL2_30572
0750: set_object 347@(357@,10i) visibility 1 
Object.PutAt(347@(357@,10i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:POOL2_30601
357@ += 1 
jump @POOL2_30399 

:POOL2_30615
39@ += 1 
jump @POOL2_29896 

:POOL2_30629
281@ += 1 

:POOL2_30636
if 
  281@ == 3 
else_jump @POOL2_30661 
281@ = 99 

:POOL2_30661
jump @POOL2_28619 

:POOL2_30668
return 

:POOL2_30670
if 
   not Actor.Dead(358@)
else_jump @POOL2_33710 
if 
07D6:   358@ == " + PlayerActor + @" 
else_jump @POOL2_30719 
360@ = 0 
jump @POOL2_30726 

:POOL2_30719
360@ = 1 

:POOL2_30726
if 
   Actor.Animation(358@) == ""POOL_XLONG_SHOT""
else_jump @POOL2_30992 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_30819 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_30819
0613: 42@ = actor 358@ animation ""POOL_XLONG_SHOT"" time 
if 
0837:   object 359@ animation == ""POOL_XLONG_SHOT_O"" 
else_jump @POOL2_30913 
083A: set_object 359@ animation ""POOL_XLONG_SHOT_O"" progress_to 42@ 
jump @POOL2_30992 

:POOL2_30913
if 
075A: set_object 359@ animation ""POOL_XLONG_SHOT_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_30992 
0836: set_object 359@ animation ""POOL_XLONG_SHOT_O"" at 0.0 times_normal_rate 

:POOL2_30992
if and
   Actor.Animation(358@) == ""POOL_XLONG_START""
   not Actor.Animation(358@) == ""POOL_XLONG_SHOT""
else_jump @POOL2_31286 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_31108 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_31108
0613: 42@ = actor 358@ animation ""POOL_XLONG_START"" time 
if 
0837:   object 359@ animation == ""POOL_XLONG_START_O"" 
else_jump @POOL2_31205 
083A: set_object 359@ animation ""POOL_XLONG_START_O"" progress_to 42@ 
jump @POOL2_31286 

:POOL2_31205
if 
075A: set_object 359@ animation ""POOL_XLONG_START_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_31286 
0836: set_object 359@ animation ""POOL_XLONG_START_O"" at 0.0 times_normal_rate 

:POOL2_31286
if 
   Actor.Animation(358@) == ""POOL_LONG_SHOT""
else_jump @POOL2_31546 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_31378 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_31378
0613: 42@ = actor 358@ animation ""POOL_LONG_SHOT"" time 
if 
0837:   object 359@ animation == ""POOL_LONG_SHOT_O"" 
else_jump @POOL2_31469 
083A: set_object 359@ animation ""POOL_LONG_SHOT_O"" progress_to 42@ 
jump @POOL2_31546 

:POOL2_31469
if 
075A: set_object 359@ animation ""POOL_LONG_SHOT_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_31546 
0836: set_object 359@ animation ""POOL_LONG_SHOT_O"" at 0.0 times_normal_rate 

:POOL2_31546
if and
   Actor.Animation(358@) == ""POOL_LONG_START""
   not Actor.Animation(358@) == ""POOL_LONG_SHOT""
else_jump @POOL2_31833 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_31660 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_31660
0613: 42@ = actor 358@ animation ""POOL_LONG_START"" time 
if 
0837:   object 359@ animation == ""POOL_LONG_START_O"" 
else_jump @POOL2_31754 
083A: set_object 359@ animation ""POOL_LONG_START_O"" progress_to 42@ 
jump @POOL2_31833 

:POOL2_31754
if 
075A: set_object 359@ animation ""POOL_LONG_START_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_31833 
0836: set_object 359@ animation ""POOL_LONG_START_O"" at 0.0 times_normal_rate 

:POOL2_31833
if 
   Actor.Animation(358@) == ""POOL_MED_SHOT""
else_jump @POOL2_32087 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_31924 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_31924
0613: 42@ = actor 358@ animation ""POOL_MED_SHOT"" time 
if 
0837:   object 359@ animation == ""POOL_MED_SHOT_O"" 
else_jump @POOL2_32012 
083A: set_object 359@ animation ""POOL_MED_SHOT_O"" progress_to 42@ 
jump @POOL2_32087 

:POOL2_32012
if 
075A: set_object 359@ animation ""POOL_MED_SHOT_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_32087 
0836: set_object 359@ animation ""POOL_MED_SHOT_O"" at 0.0 times_normal_rate 

:POOL2_32087
if and
   Actor.Animation(358@) == ""POOL_MED_START""
   not Actor.Animation(358@) == ""POOL_MED_SHOT""
else_jump @POOL2_32367 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_32199 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_32199
0613: 42@ = actor 358@ animation ""POOL_MED_START"" time 
if 
0837:   object 359@ animation == ""POOL_MED_START_O"" 
else_jump @POOL2_32290 
083A: set_object 359@ animation ""POOL_MED_START_O"" progress_to 42@ 
jump @POOL2_32367 

:POOL2_32290
if 
075A: set_object 359@ animation ""POOL_MED_START_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_32367 
0836: set_object 359@ animation ""POOL_MED_START_O"" at 0.0 times_normal_rate 

:POOL2_32367
if 
   Actor.Animation(358@) == ""POOL_SHORT_SHOT""
else_jump @POOL2_32633 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_32460 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_32460
0613: 42@ = actor 358@ animation ""POOL_SHORT_SHOT"" time 
if 
0837:   object 359@ animation == ""POOL_SHORT_SHOT_O"" 
else_jump @POOL2_32554 
083A: set_object 359@ animation ""POOL_SHORT_SHOT_O"" progress_to 42@ 
jump @POOL2_32633 

:POOL2_32554
if 
075A: set_object 359@ animation ""POOL_SHORT_SHOT_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_32633 
0836: set_object 359@ animation ""POOL_SHORT_SHOT_O"" at 0.0 times_normal_rate 

:POOL2_32633
if and
   Actor.Animation(358@) == ""POOL_SHORT_START""
   not Actor.Animation(358@) == ""POOL_SHORT_SHOT""
else_jump @POOL2_32927 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_32749 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_32749
0613: 42@ = actor 358@ animation ""POOL_SHORT_START"" time 
if 
0837:   object 359@ animation == ""POOL_SHORT_START_O"" 
else_jump @POOL2_32846 
083A: set_object 359@ animation ""POOL_SHORT_START_O"" progress_to 42@ 
jump @POOL2_32927 

:POOL2_32846
if 
075A: set_object 359@ animation ""POOL_SHORT_START_O"" IFP_file ""POOL"" 10000.0 lockF 0 loop 1 
else_jump @POOL2_32927 
0836: set_object 359@ animation ""POOL_SHORT_START_O"" at 0.0 times_normal_rate 

:POOL2_32927
if 
   Actor.Animation(358@) == ""POOL_CHALKCUE""
else_jump @POOL2_33130 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_33018 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_33018
0613: 42@ = actor 358@ animation ""POOL_CHALKCUE"" time 
if 
  42@ > 0.28 
else_jump @POOL2_33123 
if 
   not 361@(360@,2i) == 1 
else_jump @POOL2_33123 
Object.StorePos(359@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
097A: play_audio_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" event 1018 
361@(360@,2i) = 1 

:POOL2_33123
jump @POOL2_33163 

:POOL2_33130
if 
   not 361@(360@,2i) == 0 
else_jump @POOL2_33163 
361@(360@,2i) = 0 

:POOL2_33163
if 
   Actor.Animation(358@) == ""POOL_IDLE_STANCE""
else_jump @POOL2_33257 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_33257 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_33257
if 
   Actor.Animation(358@) == ""POOL_WALK""
else_jump @POOL2_33344 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_33344 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_33344
if 
   Actor.Animation(358@) == ""POOL_WALK_START""
else_jump @POOL2_33437 
if 
8737:   not actor 358@ lifting_object 359@ 
else_jump @POOL2_33437 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL2_33437
39@ = 0 
if and
   Actor.Animation(358@) == ""IDLE_STANCE""
803B:   not  215@ == 358@ 
else_jump @POOL2_33488 
39@ = 1 

:POOL2_33488
if and
   Actor.Animation(358@) == ""IDLE_STANCE""
  35@ == 6 
else_jump @POOL2_33531 
39@ = 1 

:POOL2_33531
if 
  39@ == 1 
else_jump @POOL2_33710 
062E: get_actor 358@ task 1560 status_store_to 40@ 
if 
04A4:   40@ == 7 
else_jump @POOL2_33710 
070B: set_actor 358@ onbone_attached_object_operation 0 
070A: AS_actor 358@ attach_to_object 359@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 
0615: define_AS_pack_begin 47@ 
0812: AS_actor -1 perform_animation ""POOL_IDLE_STANCE"" IFP ""POOL"" framedelta 4.0 loopA 1 lockX 1 lockY 1 lockF 0 time -1 
0616: define_AS_pack_end 47@ 
if 
  108@ == 0 
else_jump @POOL2_33705 
0618: assign_actor 358@ to_AS_pack 47@ 

:POOL2_33705
061B: remove_references_to_AS_pack 47@ 

:POOL2_33710
return 

:POOL2_33712
369@ = 99999.9 
370@ = 99999.9 
371@ = 99999.9 
363@ = 99999.9 
365@ = 0.0 
364@ = 99999.9 
366@ = 0 

:POOL2_33779
if 
  6 > 366@ 
else_jump @POOL2_34021 
382@(366@,6f) = 0.0 
388@(366@,6f) = 0.0 
394@(366@,6f) = 0.0 
400@(366@,6f) = 0.0 
406@(366@,6f) = 0.0 
412@(366@,6f) = 0.0 
418@(366@,6f) = 0.0 
424@(366@,6f) = 0.0 
430@(366@,6f) = 0.0 
436@(366@,6f) = 0.0 
442@(366@,6f) = 0.0 
448@(366@,6f) = 0.0 
454@(366@,6f) = 0.0 
460@(366@,6f) = 0.0 
466@(366@,6f) = 0.0 
366@ += 1 
jump @POOL2_33779 

:POOL2_34021
366@ = 1 

:POOL2_34028
if 
  16 > 366@ 
else_jump @POOL2_38299 
wait 0 
381@ = 0 
if 
03CA:   object 82@(366@,16i) exists 
else_jump @POOL2_37232 
if 
  66@(366@,16i) == 0 
else_jump @POOL2_37218 
if 
  8 > 366@ 
else_jump @POOL2_34131 
368@ = 0 
jump @POOL2_34170 

:POOL2_34131
if 
  366@ == 8 
else_jump @POOL2_34163 
368@ = 2 
jump @POOL2_34170 

:POOL2_34163
368@ = 1 

:POOL2_34170
if or
003B:   368@ == 231@ 
  231@ == -1 
else_jump @POOL2_37204 
if and
  231@ == -1 
  368@ == 2 
else_jump @POOL2_34235 
381@ = 1 
jump @POOL2_37197 

:POOL2_34235
if 
  129@ == 1 
else_jump @POOL2_34392 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 21 
03A7: save_int_to_debug_file 366@ 

:POOL2_34392
367@ = 0 

:POOL2_34399
if 
  6 > 367@ 
else_jump @POOL2_37197 
if 
  129@ == 1 
else_jump @POOL2_34572 
03A9: save_newline_to_debug_file 
05B6: 22 
03A7: save_int_to_debug_file 367@ 

:POOL2_34572
0085: 516@ = 82@(366@,16i) 
0085: 517@ = 367@ 
gosub @POOL2_48775 
if 
  129@ == 1 
else_jump @POOL2_34754 
03A9: save_newline_to_debug_file 
05B6: 23 
03A8: save_float_to_debug_file 519@ 

:POOL2_34754
if 
  518@ == 1 
else_jump @POOL2_36740 
0085: 481@ = 82@(366@,16i) 
482@ = 0 
0087: 483@ = 54@(367@,6f) 
0087: 484@ = 60@(367@,6f) 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_34857 
473@ = 1.0 
jump @POOL2_34903 

:POOL2_34857
if 
003B:   486@ == 368@ 
else_jump @POOL2_34893 
473@ = 0.2 
jump @POOL2_34903 

:POOL2_34893
473@ = 0.1 

:POOL2_34903
if 
  129@ == 1 
else_jump @POOL2_35058 
03A9: save_newline_to_debug_file 
05B6: 24 
03A8: save_float_to_debug_file 473@ 

:POOL2_35058
Object.StorePos(82@(366@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 54@(367@,6f) 60@(367@,6f) 
475@ = 2.3 
0063: 475@ -= 42@ 
475@ /= 2.3 
if 
  129@ == 1 
else_jump @POOL2_35284 
03A9: save_newline_to_debug_file 
05B6: 25 
03A8: save_float_to_debug_file 475@ 

:POOL2_35284
476@ = 90.0 
0063: 476@ -= 519@ 
476@ /= 90.0 
if 
  129@ == 1 
else_jump @POOL2_35467 
03A9: save_newline_to_debug_file 
05B6: 26 
03A8: save_float_to_debug_file 476@ 

:POOL2_35467
0085: 481@ = 82@ 
0085: 482@ = 82@(366@,16i) 
0087: 483@ = 526@ 
0087: 484@ = 527@ 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_35545 
474@ = 1.0 
jump @POOL2_35776 

:POOL2_35545
if 
  129@ == 1 
else_jump @POOL2_35695 
03A9: save_newline_to_debug_file 
05B6: 27 

:POOL2_35695
if 
  231@ == -1 
else_jump @POOL2_35730 
474@ = 0.05 
jump @POOL2_35776 

:POOL2_35730
if 
003B:   486@ == 231@ 
else_jump @POOL2_35766 
474@ = 0.05 
jump @POOL2_35776 

:POOL2_35766
474@ = -1000.0 

:POOL2_35776
if 
  129@ == 1 
else_jump @POOL2_35931 
03A9: save_newline_to_debug_file 
05B6: 28 
03A8: save_float_to_debug_file 474@ 

:POOL2_35931
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 526@ 527@ 
if 
  0.3 > 42@ 
else_jump @POOL2_36019 
43@ = 0.3 
0063: 43@ -= 42@ 
42@ = 0.3 
005B: 42@ += 43@ 

:POOL2_36019
42@ += -0.3 
43@ = 2.0 
0063: 43@ -= 42@ 
43@ /= 2.0 
0087: 472@ = 43@ 
if 
  129@ == 1 
else_jump @POOL2_36220 
03A9: save_newline_to_debug_file 
05B6: 29 
03A8: save_float_to_debug_file 472@ 

:POOL2_36220
473@ *= 1.0 
474@ *= 1.0 
472@ *= 0.3 
475@ *= 0.4 
476@ *= 0.8 
0087: 477@ = 473@ 
005B: 477@ += 474@ 
005B: 477@ += 472@ 
005B: 477@ += 475@ 
005B: 477@ += 476@ 
477@ /= 5.0 
0871: init_jump_table 366@ total_jumps 15 default_jump 0 @POOL2_36733 jumps 1 @POOL2_36448 2 @POOL2_36467 3 @POOL2_36486 4 @POOL2_36505 5 @POOL2_36524 6 @POOL2_36543 7 @POOL2_36562 
0872: jump_table_jumps 8 @POOL2_36581 9 @POOL2_36600 10 @POOL2_36619 11 @POOL2_36638 12 @POOL2_36657 13 @POOL2_36676 14 @POOL2_36695 15 @POOL2_36714 -1 @POOL2_36733 

:POOL2_36448
0087: 382@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36467
0087: 388@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36486
0087: 394@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36505
0087: 400@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36524
0087: 406@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36543
0087: 412@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36562
0087: 418@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36581
0087: 424@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36600
0087: 430@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36619
0087: 436@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36638
0087: 442@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36657
0087: 448@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36676
0087: 454@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36695
0087: 460@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36714
0087: 466@(367@,6f) = 477@ 
jump @POOL2_36733 

:POOL2_36733
jump @POOL2_37183 

:POOL2_36740
0871: init_jump_table 366@ total_jumps 15 default_jump 0 @POOL2_37183 jumps 1 @POOL2_36868 2 @POOL2_36889 3 @POOL2_36910 4 @POOL2_36931 5 @POOL2_36952 6 @POOL2_36973 7 @POOL2_36994 
0872: jump_table_jumps 8 @POOL2_37015 9 @POOL2_37036 10 @POOL2_37057 11 @POOL2_37078 12 @POOL2_37099 13 @POOL2_37120 14 @POOL2_37141 15 @POOL2_37162 -1 @POOL2_37183 

:POOL2_36868
382@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_36889
388@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_36910
394@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_36931
400@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_36952
406@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_36973
412@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_36994
418@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37015
424@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37036
430@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37057
436@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37078
442@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37099
448@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37120
454@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37141
460@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37162
466@(367@,6f) = -1.0 
jump @POOL2_37183 

:POOL2_37183
367@ += 1 
jump @POOL2_34399 

:POOL2_37197
jump @POOL2_37211 

:POOL2_37204
381@ = 1 

:POOL2_37211
jump @POOL2_37225 

:POOL2_37218
381@ = 1 

:POOL2_37225
jump @POOL2_37239 

:POOL2_37232
381@ = 1 

:POOL2_37239
if 
  381@ == 1 
else_jump @POOL2_38285 
0871: init_jump_table 366@ total_jumps 15 default_jump 0 @POOL2_38285 jumps 1 @POOL2_37385 2 @POOL2_37445 3 @POOL2_37505 4 @POOL2_37565 5 @POOL2_37625 6 @POOL2_37685 7 @POOL2_37745 
0872: jump_table_jumps 8 @POOL2_37805 9 @POOL2_37865 10 @POOL2_37925 11 @POOL2_37985 12 @POOL2_38045 13 @POOL2_38105 14 @POOL2_38165 15 @POOL2_38225 -1 @POOL2_38285 

:POOL2_37385
367@ = 0 

:POOL2_37392
if 
  6 > 367@ 
else_jump @POOL2_37438 
382@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37392 

:POOL2_37438
jump @POOL2_38285 

:POOL2_37445
367@ = 0 

:POOL2_37452
if 
  6 > 367@ 
else_jump @POOL2_37498 
388@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37452 

:POOL2_37498
jump @POOL2_38285 

:POOL2_37505
367@ = 0 

:POOL2_37512
if 
  6 > 367@ 
else_jump @POOL2_37558 
394@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37512 

:POOL2_37558
jump @POOL2_38285 

:POOL2_37565
367@ = 0 

:POOL2_37572
if 
  6 > 367@ 
else_jump @POOL2_37618 
400@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37572 

:POOL2_37618
jump @POOL2_38285 

:POOL2_37625
367@ = 0 

:POOL2_37632
if 
  6 > 367@ 
else_jump @POOL2_37678 
406@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37632 

:POOL2_37678
jump @POOL2_38285 

:POOL2_37685
367@ = 0 

:POOL2_37692
if 
  6 > 367@ 
else_jump @POOL2_37738 
412@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37692 

:POOL2_37738
jump @POOL2_38285 

:POOL2_37745
367@ = 0 

:POOL2_37752
if 
  6 > 367@ 
else_jump @POOL2_37798 
418@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37752 

:POOL2_37798
jump @POOL2_38285 

:POOL2_37805
367@ = 0 

:POOL2_37812
if 
  6 > 367@ 
else_jump @POOL2_37858 
424@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37812 

:POOL2_37858
jump @POOL2_38285 

:POOL2_37865
367@ = 0 

:POOL2_37872
if 
  6 > 367@ 
else_jump @POOL2_37918 
430@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37872 

:POOL2_37918
jump @POOL2_38285 

:POOL2_37925
367@ = 0 

:POOL2_37932
if 
  6 > 367@ 
else_jump @POOL2_37978 
436@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37932 

:POOL2_37978
jump @POOL2_38285 

:POOL2_37985
367@ = 0 

:POOL2_37992
if 
  6 > 367@ 
else_jump @POOL2_38038 
442@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_37992 

:POOL2_38038
jump @POOL2_38285 

:POOL2_38045
367@ = 0 

:POOL2_38052
if 
  6 > 367@ 
else_jump @POOL2_38098 
448@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_38052 

:POOL2_38098
jump @POOL2_38285 

:POOL2_38105
367@ = 0 

:POOL2_38112
if 
  6 > 367@ 
else_jump @POOL2_38158 
454@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_38112 

:POOL2_38158
jump @POOL2_38285 

:POOL2_38165
367@ = 0 

:POOL2_38172
if 
  6 > 367@ 
else_jump @POOL2_38218 
460@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_38172 

:POOL2_38218
jump @POOL2_38285 

:POOL2_38225
367@ = 0 

:POOL2_38232
if 
  6 > 367@ 
else_jump @POOL2_38278 
466@(367@,6f) = -1.0 
367@ += 1 
jump @POOL2_38232 

:POOL2_38278
jump @POOL2_38285 

:POOL2_38285
366@ += 1 
jump @POOL2_34028 

:POOL2_38299
478@ = -9999.9 
479@ = -1 
480@ = -1 
366@ = 0 
if 
  129@ == 1 
else_jump @POOL2_38480 
03A9: save_newline_to_debug_file 
05B6: 30 

:POOL2_38480
if 
  6 > 366@ 
else_jump @POOL2_41804 
if 
  129@ == 1 
else_jump @POOL2_38794 
03A9: save_newline_to_debug_file 
05B6: 31 
03A7: save_int_to_debug_file 366@ 
03A9: save_newline_to_debug_file 
05B6: 32 
03A8: save_float_to_debug_file 382@(366@,6f) 

:POOL2_38794
if 
0025:   382@(366@,6f) > 478@ 
else_jump @POOL2_38844 
0087: 478@ = 382@(366@,6f) 
479@ = 1 
0085: 480@ = 366@ 

:POOL2_38844
if 
  129@ == 1 
else_jump @POOL2_39003 
03A9: save_newline_to_debug_file 
05B6: 33 
03A8: save_float_to_debug_file 388@(366@,6f) 

:POOL2_39003
if 
0025:   388@(366@,6f) > 478@ 
else_jump @POOL2_39053 
0087: 478@ = 388@(366@,6f) 
479@ = 2 
0085: 480@ = 366@ 

:POOL2_39053
if 
  129@ == 1 
else_jump @POOL2_39212 
03A9: save_newline_to_debug_file 
05B6: 34 
03A8: save_float_to_debug_file 394@(366@,6f) 

:POOL2_39212
if 
0025:   394@(366@,6f) > 478@ 
else_jump @POOL2_39262 
0087: 478@ = 394@(366@,6f) 
479@ = 3 
0085: 480@ = 366@ 

:POOL2_39262
if 
  129@ == 1 
else_jump @POOL2_39421 
03A9: save_newline_to_debug_file 
05B6: 35 
03A8: save_float_to_debug_file 400@(366@,6f) 

:POOL2_39421
if 
0025:   400@(366@,6f) > 478@ 
else_jump @POOL2_39471 
0087: 478@ = 400@(366@,6f) 
479@ = 4 
0085: 480@ = 366@ 

:POOL2_39471
if 
  129@ == 1 
else_jump @POOL2_39630 
03A9: save_newline_to_debug_file 
05B6: 36 
03A8: save_float_to_debug_file 406@(366@,6f) 

:POOL2_39630
if 
0025:   406@(366@,6f) > 478@ 
else_jump @POOL2_39680 
0087: 478@ = 406@(366@,6f) 
479@ = 5 
0085: 480@ = 366@ 

:POOL2_39680
if 
  129@ == 1 
else_jump @POOL2_39839 
03A9: save_newline_to_debug_file 
05B6: 37 
03A8: save_float_to_debug_file 412@(366@,6f) 

:POOL2_39839
if 
0025:   412@(366@,6f) > 478@ 
else_jump @POOL2_39889 
0087: 478@ = 412@(366@,6f) 
479@ = 6 
0085: 480@ = 366@ 

:POOL2_39889
if 
  129@ == 1 
else_jump @POOL2_40048 
03A9: save_newline_to_debug_file 
05B6: 38 
03A8: save_float_to_debug_file 418@(366@,6f) 

:POOL2_40048
if 
0025:   418@(366@,6f) > 478@ 
else_jump @POOL2_40098 
0087: 478@ = 418@(366@,6f) 
479@ = 7 
0085: 480@ = 366@ 

:POOL2_40098
if 
  129@ == 1 
else_jump @POOL2_40257 
03A9: save_newline_to_debug_file 
05B6: 39 
03A8: save_float_to_debug_file 424@(366@,6f) 

:POOL2_40257
if 
0025:   424@(366@,6f) > 478@ 
else_jump @POOL2_40307 
0087: 478@ = 424@(366@,6f) 
479@ = 8 
0085: 480@ = 366@ 

:POOL2_40307
if 
  129@ == 1 
else_jump @POOL2_40466 
03A9: save_newline_to_debug_file 
05B6: 40 
03A8: save_float_to_debug_file 430@(366@,6f) 

:POOL2_40466
if 
0025:   430@(366@,6f) > 478@ 
else_jump @POOL2_40516 
0087: 478@ = 430@(366@,6f) 
479@ = 9 
0085: 480@ = 366@ 

:POOL2_40516
if 
  129@ == 1 
else_jump @POOL2_40675 
03A9: save_newline_to_debug_file 
05B6: 41 
03A8: save_float_to_debug_file 436@(366@,6f) 

:POOL2_40675
if 
0025:   436@(366@,6f) > 478@ 
else_jump @POOL2_40725 
0087: 478@ = 436@(366@,6f) 
479@ = 10 
0085: 480@ = 366@ 

:POOL2_40725
if 
  129@ == 1 
else_jump @POOL2_40884 
03A9: save_newline_to_debug_file 
05B6: 42 
03A8: save_float_to_debug_file 442@(366@,6f) 

:POOL2_40884
if 
0025:   442@(366@,6f) > 478@ 
else_jump @POOL2_40934 
0087: 478@ = 442@(366@,6f) 
479@ = 11 
0085: 480@ = 366@ 

:POOL2_40934
if 
  129@ == 1 
else_jump @POOL2_41093 
03A9: save_newline_to_debug_file 
05B6: 43 
03A8: save_float_to_debug_file 448@(366@,6f) 

:POOL2_41093
if 
0025:   448@(366@,6f) > 478@ 
else_jump @POOL2_41143 
0087: 478@ = 448@(366@,6f) 
479@ = 12 
0085: 480@ = 366@ 

:POOL2_41143
if 
  129@ == 1 
else_jump @POOL2_41302 
03A9: save_newline_to_debug_file 
05B6: 44 
03A8: save_float_to_debug_file 454@(366@,6f) 

:POOL2_41302
if 
0025:   454@(366@,6f) > 478@ 
else_jump @POOL2_41352 
0087: 478@ = 454@(366@,6f) 
479@ = 13 
0085: 480@ = 366@ 

:POOL2_41352
if 
  129@ == 1 
else_jump @POOL2_41511 
03A9: save_newline_to_debug_file 
05B6: 45 
03A8: save_float_to_debug_file 460@(366@,6f) 

:POOL2_41511
if 
0025:   460@(366@,6f) > 478@ 
else_jump @POOL2_41561 
0087: 478@ = 460@(366@,6f) 
479@ = 14 
0085: 480@ = 366@ 

:POOL2_41561
if 
  129@ == 1 
else_jump @POOL2_41720 
03A9: save_newline_to_debug_file 
05B6: 46 
03A8: save_float_to_debug_file 466@(366@,6f) 

:POOL2_41720
if 
0025:   466@(366@,6f) > 478@ 
else_jump @POOL2_41770 
0087: 478@ = 466@(366@,6f) 
479@ = 15 
0085: 480@ = 366@ 

:POOL2_41770
if 
  129@ == 1 
else_jump @POOL2_41790 
03A9: save_newline_to_debug_file 

:POOL2_41790
366@ += 1 
jump @POOL2_38480 

:POOL2_41804
if 
  478@ > 0.0 
else_jump @POOL2_42225 
Object.StorePos(82@(479@,16i), 372@, 373@, 374@)
Object.StorePos(82@, 378@, 379@, 380@)
0087: 375@ = 54@(480@,6f) 
0063: 375@ -= 372@ 
0087: 376@ = 60@(480@,6f) 
0063: 376@ -= 373@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 54@(480@,6f) 60@(480@,6f) 
0073: 375@ /= 42@ 
0073: 376@ /= 42@ 
0087: 43@ = 52@ 
43@ *= -2.0 
006B: 375@ *= 43@ 
006B: 376@ *= 43@ 
0087: 369@ = 372@ 
005B: 369@ += 375@ 
0087: 370@ = 373@ 
005B: 370@ += 376@ 
0088: " + tempvar_Float_1 + @" = 372@ 
0067: " + tempvar_Float_1 + @" -= 369@ 
0088: " + tempvar_Float_2 + @" = 373@ 
0067: " + tempvar_Float_2 + @" -= 370@ 
0087: 169@ = 369@ 
0063: 169@ -= 378@ 
0087: 170@ = 370@ 
0063: 170@ -= 379@ 
05A4: get_angle_between_vectors_origin_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_origin_to 169@ 170@ store_to 365@ 
0087: 42@ = 365@ 
42@ /= 90.0 
42@ *= 0.25 
006D: " + tempvar_Float_1 + @" *= 42@ 
006D: " + tempvar_Float_2 + @" *= 42@ 
005D: 369@ += " + tempvar_Float_1 + @" 
005D: 370@ += " + tempvar_Float_2 + @" 
0509: 42@ = distance_between_XY 378@ 379@ and_XY 369@ 370@ 
0509: 43@ = distance_between_XY 372@ 373@ and_XY 369@ 370@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 2.0 6.0 
006B: 371@ *= 42@ 
jump @POOL2_46712 

:POOL2_42225
if 
  129@ == 1 
else_jump @POOL2_42375 
03A9: save_newline_to_debug_file 
05B6: 47 

:POOL2_42375
366@ = 1 

:POOL2_42382
if 
  16 > 366@ 
else_jump @POOL2_42981 
wait 0 
if 
03CA:   object 82@(366@,16i) exists 
else_jump @POOL2_42967 
if 
  66@(366@,16i) == 0 
else_jump @POOL2_42967 
if 
  366@ == 0 
else_jump @POOL2_42478 
368@ = 3 
jump @POOL2_42549 

:POOL2_42478
if 
  8 > 366@ 
else_jump @POOL2_42510 
368@ = 0 
jump @POOL2_42549 

:POOL2_42510
if 
  366@ == 8 
else_jump @POOL2_42542 
368@ = 2 
jump @POOL2_42549 

:POOL2_42542
368@ = 1 

:POOL2_42549
if or
003B:   368@ == 231@ 
  231@ == -1 
else_jump @POOL2_42967 
if and
  231@ == 0 
  368@ == 2 
else_jump @POOL2_42607 
jump @POOL2_42967 

:POOL2_42607
0085: 528@ = 82@ 
0085: 529@ = 82@(366@,16i) 
gosub @POOL2_49095 
if 
   not 530@ == 0 
else_jump @POOL2_42967 
if 
  530@ == 1 
else_jump @POOL2_42693 
0087: 369@ = 539@ 
0087: 370@ = 540@ 
jump @POOL2_42898 

:POOL2_42693
if 
  530@ == 2 
else_jump @POOL2_42734 
0087: 369@ = 541@ 
0087: 370@ = 542@ 
jump @POOL2_42898 

:POOL2_42734
0088: " + tempvar_Float_1 + @" = 541@ 
0067: " + tempvar_Float_1 + @" -= 539@ 
0088: " + tempvar_Float_2 + @" = 542@ 
0067: " + tempvar_Float_2 + @" -= 540@ 
0509: 42@ = distance_between_XY 539@ 540@ and_XY 541@ 542@ 
0075: " + tempvar_Float_1 + @" /= 42@ 
0075: " + tempvar_Float_2 + @" /= 42@ 
0087: 42@ = 52@ 
42@ *= 2.0 
42@ *= 0.8 
42@ *= 2.0 
0208: 43@ = random_float_in_ranges 0.0 42@ 
006D: " + tempvar_Float_1 + @" *= 43@ 
006D: " + tempvar_Float_2 + @" *= 43@ 
0087: 369@ = 539@ 
005D: 369@ += " + tempvar_Float_1 + @" 
0087: 370@ = 540@ 
005D: 370@ += " + tempvar_Float_2 + @" 

:POOL2_42898
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 369@ 370@ 
0208: 43@ = random_float_in_ranges 2.0 5.0 
0087: 371@ = 42@ 
006B: 371@ *= 43@ 
366@ = 16 

:POOL2_42967
366@ += 1 
jump @POOL2_42382 

:POOL2_42981
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_45009 
if 
  129@ == 1 
else_jump @POOL2_43162 
03A9: save_newline_to_debug_file 
05B6: 48 

:POOL2_43162
366@ = 1 

:POOL2_43169
if 
  16 > 366@ 
else_jump @POOL2_45009 
wait 0 
if 
03CA:   object 82@(366@,16i) exists 
else_jump @POOL2_44995 
if 
  66@(366@,16i) == 0 
else_jump @POOL2_44995 
if 
  366@ == 0 
else_jump @POOL2_43265 
368@ = 3 
jump @POOL2_43336 

:POOL2_43265
if 
  8 > 366@ 
else_jump @POOL2_43297 
368@ = 0 
jump @POOL2_43336 

:POOL2_43297
if 
  366@ == 8 
else_jump @POOL2_43329 
368@ = 2 
jump @POOL2_43336 

:POOL2_43329
368@ = 1 

:POOL2_43336
if or
003B:   368@ == 231@ 
  231@ == -1 
else_jump @POOL2_44995 
if and
  231@ == -1 
  368@ == 2 
else_jump @POOL2_43394 
jump @POOL2_44995 

:POOL2_43394
Object.StorePos(82@, 372@, 373@, 374@)
Object.StorePos(82@(366@,16i), 375@, 376@, 377@)
if 
  129@ == 1 
else_jump @POOL2_43576 
03A9: save_newline_to_debug_file 
05B6: 49 

:POOL2_43576
0087: 378@ = 372@ 
005B: 378@ += 375@ 
378@ /= 2.0 
0087: 379@ = 100@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_43808 
0085: 549@ = 82@ 
0085: 550@ = 82@(366@,16i) 
0087: 551@ = 378@ 
0087: 552@ = 379@ 
gosub @POOL2_49954 
if 
  553@ == 1 
else_jump @POOL2_43808 
0087: 369@ = 378@ 
0087: 370@ = 379@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 3.0 6.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_43808
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_44195 
if 
  129@ == 1 
else_jump @POOL2_43989 
03A9: save_newline_to_debug_file 
05B6: 50 

:POOL2_43989
0087: 379@ = 101@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_44195 
0085: 549@ = 82@ 
0085: 550@ = 82@(366@,16i) 
0087: 551@ = 378@ 
0087: 552@ = 379@ 
gosub @POOL2_49954 
if 
  553@ == 1 
else_jump @POOL2_44195 
0087: 369@ = 378@ 
0087: 370@ = 379@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 3.0 6.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_44195
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_44608 
if 
  129@ == 1 
else_jump @POOL2_44376 
03A9: save_newline_to_debug_file 
05B6: 51 

:POOL2_44376
0087: 379@ = 373@ 
005B: 379@ += 376@ 
379@ /= 2.0 
0087: 378@ = 98@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_44608 
0085: 549@ = 82@ 
0085: 550@ = 82@(366@,16i) 
0087: 551@ = 378@ 
0087: 552@ = 379@ 
gosub @POOL2_49954 
if 
  553@ == 1 
else_jump @POOL2_44608 
0087: 369@ = 378@ 
0087: 370@ = 379@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 3.0 6.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_44608
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_44995 
if 
  129@ == 1 
else_jump @POOL2_44789 
03A9: save_newline_to_debug_file 
05B6: 52 

:POOL2_44789
0087: 378@ = 99@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_44995 
0085: 549@ = 82@ 
0085: 550@ = 82@(366@,16i) 
0087: 551@ = 378@ 
0087: 552@ = 379@ 
gosub @POOL2_49954 
if 
  553@ == 1 
else_jump @POOL2_44995 
0087: 369@ = 378@ 
0087: 370@ = 379@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 3.0 6.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_44995
366@ += 1 
jump @POOL2_43169 

:POOL2_45009
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_46481 
if 
  129@ == 1 
else_jump @POOL2_45190 
03A9: save_newline_to_debug_file 
05B6: 53 

:POOL2_45190
366@ = 1 

:POOL2_45197
if 
  16 > 366@ 
else_jump @POOL2_46481 
wait 0 
if 
03CA:   object 82@(366@,16i) exists 
else_jump @POOL2_46467 
if 
  66@(366@,16i) == 0 
else_jump @POOL2_46467 
if 
  366@ == 0 
else_jump @POOL2_45293 
368@ = 3 
jump @POOL2_45364 

:POOL2_45293
if 
  8 > 366@ 
else_jump @POOL2_45325 
368@ = 0 
jump @POOL2_45364 

:POOL2_45325
if 
  366@ == 8 
else_jump @POOL2_45357 
368@ = 2 
jump @POOL2_45364 

:POOL2_45357
368@ = 1 

:POOL2_45364
if or
003B:   368@ == 231@ 
  231@ == -1 
else_jump @POOL2_46467 
if and
  231@ == -1 
  368@ == 2 
else_jump @POOL2_45422 
jump @POOL2_46467 

:POOL2_45422
Object.StorePos(82@, 372@, 373@, 374@)
Object.StorePos(82@(366@,16i), 375@, 376@, 377@)
0087: 378@ = 372@ 
005B: 378@ += 375@ 
378@ /= 2.0 
0087: 379@ = 100@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_45697 
0085: 554@ = 82@ 
0087: 555@ = 378@ 
0087: 556@ = 379@ 
gosub @POOL2_50474 
if 
  557@ == 1 
else_jump @POOL2_45697 
0087: 369@ = 378@ 
0208: 42@ = random_float_in_ranges -0.05 0.05 
005B: 369@ += 42@ 
0087: 370@ = 379@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 5.0 8.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_45697
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_45945 
0087: 379@ = 101@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_45945 
0085: 554@ = 82@ 
0087: 555@ = 378@ 
0087: 556@ = 379@ 
gosub @POOL2_50474 
if 
  557@ == 1 
else_jump @POOL2_45945 
0087: 369@ = 378@ 
0208: 42@ = random_float_in_ranges -0.05 0.05 
005B: 369@ += 42@ 
0087: 370@ = 379@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 5.0 8.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_45945
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_46219 
0087: 379@ = 373@ 
005B: 379@ += 376@ 
379@ /= 2.0 
0087: 378@ = 98@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_46219 
0085: 554@ = 82@ 
0087: 555@ = 378@ 
0087: 556@ = 379@ 
gosub @POOL2_50474 
if 
  557@ == 1 
else_jump @POOL2_46219 
0087: 369@ = 378@ 
0087: 370@ = 379@ 
0208: 42@ = random_float_in_ranges -0.05 0.05 
005B: 370@ += 42@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 5.0 8.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_46219
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_46467 
0087: 378@ = 99@ 
0087: 543@ = 378@ 
0087: 544@ = 379@ 
gosub @POOL2_49698 
if 
  545@ == 0 
else_jump @POOL2_46467 
0085: 554@ = 82@ 
0087: 555@ = 378@ 
0087: 556@ = 379@ 
gosub @POOL2_50474 
if 
  557@ == 1 
else_jump @POOL2_46467 
0087: 369@ = 378@ 
0087: 370@ = 379@ 
0208: 42@ = random_float_in_ranges -0.05 0.05 
005B: 370@ += 42@ 
0509: 42@ = distance_between_XY 372@ 373@ and_XY 378@ 379@ 
0509: 43@ = distance_between_XY 375@ 376@ and_XY 378@ 379@ 
0087: 371@ = 42@ 
005B: 371@ += 43@ 
0208: 42@ = random_float_in_ranges 5.0 8.0 
006B: 371@ *= 42@ 
366@ = 16 

:POOL2_46467
366@ += 1 
jump @POOL2_45197 

:POOL2_46481
if and
  369@ == 99999.9 
  370@ == 99999.9 
else_jump @POOL2_46712 
if 
  129@ == 1 
else_jump @POOL2_46662 
03A9: save_newline_to_debug_file 
05B6: 54 

:POOL2_46662
0208: 363@ = random_float_in_ranges 0.0 360.0 
0208: 364@ = random_float_in_ranges 4.0 8.0 
369@ = 0.0 
370@ = 0.0 

:POOL2_46712
if and
  363@ == 99999.9 
  364@ == 99999.9 
else_jump @POOL2_46875 
Object.StorePos(82@, 372@, 373@, 374@)
0087: 375@ = 369@ 
0063: 375@ -= 372@ 
0087: 376@ = 370@ 
0063: 376@ -= 373@ 
0604: get_Z_angle_for_point 375@ 376@ store_to 363@ 
0087: 364@ = 371@ 
364@ *= 1.0 
if 
  90.0 > 365@ 
else_jump @POOL2_46875 
0087: 42@ = 365@ 
42@ /= 90.0 
42@ *= 2.0 
005B: 364@ += 42@ 

:POOL2_46875
if 
  0.7 > 364@ 
else_jump @POOL2_46906 
364@ = 0.7 

:POOL2_46906
if 
  364@ > 4.0 
else_jump @POOL2_46937 
364@ = 4.0 

:POOL2_46937
return 

:POOL2_46939
jump @POOL2_46990 
481@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
482@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)

:POOL2_46990
485@ = 1 
504@ = -1 
if 
03CA:   object 481@ exists 
else_jump @POOL2_47083 
Object.StorePos(481@, 487@, 488@, " + tempvar_Float_3 + @")
0087: 491@ = 483@ 
0063: 491@ -= 487@ 
0087: 492@ = 484@ 
0063: 492@ -= 488@ 
0509: 497@ = distance_between_XY 487@ 488@ and_XY 483@ 484@ 

:POOL2_47083
wait 0 
if or
  231@ == -1 
  231@ == 2 
  231@ == 1 
else_jump @POOL2_47172 
501@ = 1 

:POOL2_47126
if 
  16 > 501@ 
else_jump @POOL2_47165 
gosub @POOL2_47267 
501@ += 1 
jump @POOL2_47126 

:POOL2_47165
jump @POOL2_47258 

:POOL2_47172
503@ = 1 

:POOL2_47179
if 
  16 > 503@ 
else_jump @POOL2_47258 
0085: 501@ = 503@ 
501@ += 7 
if 
  501@ > 15 
else_jump @POOL2_47237 
501@ += -15 

:POOL2_47237
gosub @POOL2_47267 
503@ += 1 
jump @POOL2_47179 

:POOL2_47258
482@ = 0 
return 

:POOL2_47267
if 
03CA:   object 82@(501@,16i) exists 
else_jump @POOL2_48187 
if 
  66@(501@,16i) == 0 
else_jump @POOL2_48187 
if 
803B:   not  82@(501@,16i) == 481@ 
else_jump @POOL2_48187 
502@ = 0 
if 
03CA:   object 482@ exists 
else_jump @POOL2_47385 
if 
003B:   82@(501@,16i) == 482@ 
else_jump @POOL2_47385 
502@ = 1 

:POOL2_47385
if 
  502@ == 0 
else_jump @POOL2_48187 
Object.StorePos(82@(501@,16i), 489@, 490@, " + tempvar_Float_3 + @")
0087: 493@ = 489@ 
0063: 493@ -= 487@ 
0087: 494@ = 490@ 
0063: 494@ -= 488@ 
0509: 498@ = distance_between_XY 487@ 488@ and_XY 489@ 490@ 
05A4: get_angle_between_vectors_origin_to 491@ 492@ and_origin_to 493@ 494@ store_to 42@ 
0509: 499@ = distance_between_XY 489@ 490@ and_XY 483@ 484@ 
if 
0025:   53@ > 499@ 
else_jump @POOL2_47817 
if 
  501@ == 0 
else_jump @POOL2_47555 
486@ = 3 
jump @POOL2_47626 

:POOL2_47555
if 
  8 > 501@ 
else_jump @POOL2_47587 
486@ = 0 
jump @POOL2_47626 

:POOL2_47587
if 
  501@ == 8 
else_jump @POOL2_47619 
486@ = 2 
jump @POOL2_47626 

:POOL2_47619
486@ = 1 

:POOL2_47626
if 
  129@ == 1 
else_jump @POOL2_47781 
03A9: save_newline_to_debug_file 
05B6: 55 
03A7: save_int_to_debug_file 501@ 

:POOL2_47781
0085: 504@ = 501@ 
485@ = 0 
501@ = 16 
503@ = 16 
jump @POOL2_48187 

:POOL2_47817
if 
  90.0 >= 42@ 
else_jump @POOL2_48187 
if 
0025:   497@ > 498@ 
else_jump @POOL2_48187 
02F6: 500@ = sine 42@ 
0087: 42@ = 500@ 
006B: 42@ *= 498@ 
if 
0025:   53@ > 42@ 
else_jump @POOL2_48187 
if 
  501@ == 0 
else_jump @POOL2_47932 
486@ = 3 
jump @POOL2_48003 

:POOL2_47932
if 
  8 > 501@ 
else_jump @POOL2_47964 
486@ = 0 
jump @POOL2_48003 

:POOL2_47964
if 
  501@ == 8 
else_jump @POOL2_47996 
486@ = 2 
jump @POOL2_48003 

:POOL2_47996
486@ = 1 

:POOL2_48003
if 
  129@ == 1 
else_jump @POOL2_48158 
03A9: save_newline_to_debug_file 
05B6: 56 
03A7: save_int_to_debug_file 501@ 

:POOL2_48158
0085: 504@ = 501@ 
485@ = 0 
501@ = 16 
503@ = 16 

:POOL2_48187
return 

:POOL2_48189
485@ = 1 
504@ = -1 
0087: 491@ = 483@ 
0063: 491@ -= 487@ 
0087: 492@ = 484@ 
0063: 492@ -= 488@ 
if or
0025:   98@ > 483@ 
0025:   483@ > 99@ 
0025:   100@ > 484@ 
0025:   484@ > 101@ 
else_jump @POOL2_48750 
505@ = -99999.9 
506@ = -99999.9 
39@ = 0 
if and
05B0:   unknown_calculate 487@ 488@ 483@ and 484@ 98@ 100@ 98@ 101@ store_to 505@ 506@ 
   not 515@ == 1 
else_jump @POOL2_48369 
39@ = 1 
jump @POOL2_48554 

:POOL2_48369
if and
05B0:   unknown_calculate 487@ 488@ 483@ and 484@ 99@ 100@ 99@ 101@ store_to 505@ 506@ 
   not 515@ == 2 
else_jump @POOL2_48433 
39@ = 2 
jump @POOL2_48554 

:POOL2_48433
if and
05B0:   unknown_calculate 487@ 488@ 483@ and 484@ 98@ 100@ 99@ 100@ store_to 505@ 506@ 
   not 515@ == 3 
else_jump @POOL2_48497 
39@ = 3 
jump @POOL2_48554 

:POOL2_48497
if and
05B0:   unknown_calculate 487@ 488@ 483@ and 484@ 98@ 101@ 99@ 101@ store_to 505@ 506@ 
   not 515@ == 4 
else_jump @POOL2_48554 
39@ = 4 

:POOL2_48554
0509: 42@ = distance_between_XY 483@ 484@ and_XY 487@ 488@ 
if 
  42@ > 0.0 
else_jump @POOL2_48608 
0073: 491@ /= 42@ 
0073: 492@ /= 42@ 

:POOL2_48608
if or
  39@ == 1 
  39@ == 2 
else_jump @POOL2_48659 
0087: 507@ = 491@ 
507@ *= -1.0 
0087: 508@ = 492@ 

:POOL2_48659
if or
  39@ == 3 
  39@ == 4 
else_jump @POOL2_48710 
0087: 507@ = 491@ 
0087: 508@ = 492@ 
508@ *= -1.0 

:POOL2_48710
if 
   not 39@ == 0 
else_jump @POOL2_48736 
0085: 515@ = 39@ 

:POOL2_48736
485@ = 0 
jump @POOL2_48773 

:POOL2_48750
0087: 505@ = 483@ 
0087: 506@ = 484@ 
485@ = 1 

:POOL2_48773
return 

:POOL2_48775
if 
03CA:   object 516@ exists 
else_jump @POOL2_48845 
Object.StorePos(516@, 526@, 527@, " + tempvar_Float_3 + @")
0087: 520@ = 54@(517@,6f) 
0063: 520@ -= 526@ 
0087: 521@ = 60@(517@,6f) 
0063: 521@ -= 527@ 

:POOL2_48845
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 54@(517@,6f) 60@(517@,6f) 
0087: 522@ = 520@ 
0073: 522@ /= 42@ 
0087: 523@ = 521@ 
0073: 523@ /= 42@ 
522@ *= -1.0 
523@ *= -1.0 
0087: 42@ = 52@ 
42@ *= 2.0 
006B: 522@ *= 42@ 
006B: 523@ *= 42@ 
005B: 526@ += 522@ 
005B: 527@ += 523@ 
if 
03CA:   object 82@ exists 
else_jump @POOL2_49034 
Object.StorePos(82@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 524@ = 526@ 
0065: 524@ -= " + tempvar_Float_1 + @" 
0087: 525@ = 527@ 
0065: 525@ -= " + tempvar_Float_2 + @" 

:POOL2_49034
05A4: get_angle_between_vectors_origin_to 520@ 521@ and_origin_to 524@ 525@ store_to 519@ 
if 
  90.0 > 519@ 
else_jump @POOL2_49086 
518@ = 1 
jump @POOL2_49093 

:POOL2_49086
518@ = 0 

:POOL2_49093
return 

:POOL2_49095
530@ = 0 
531@ = 0 
532@ = 0 
if and
03CA:   object 528@ exists 
03CA:   object 529@ exists 
else_jump @POOL2_49696 
Object.StorePos(528@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.StorePos(529@, 537@, 538@, " + tempvar_Float_3 + @")
0087: 533@ = 537@ 
0065: 533@ -= " + tempvar_Float_1 + @" 
0087: 534@ = 538@ 
0065: 534@ -= " + tempvar_Float_2 + @" 
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 537@ 538@ 
0073: 533@ /= 42@ 
0073: 534@ /= 42@ 
0087: 535@ = 534@ 
0087: 536@ = 533@ 
536@ *= -1.0 
0087: 42@ = 52@ 
42@ *= 2.0 
42@ *= 0.8 
0087: 43@ = 535@ 
006B: 43@ *= 42@ 
0087: 539@ = 537@ 
005B: 539@ += 43@ 
0087: 43@ = 536@ 
006B: 43@ *= 42@ 
0087: 540@ = 538@ 
005B: 540@ += 43@ 
0085: 481@ = 528@ 
0085: 482@ = 529@ 
0087: 483@ = 539@ 
0087: 484@ = 540@ 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_49412 
531@ = 1 

:POOL2_49412
0087: 42@ = 52@ 
42@ *= 2.0 
42@ *= -0.8 
0087: 43@ = 535@ 
006B: 43@ *= 42@ 
0087: 541@ = 537@ 
005B: 541@ += 43@ 
0087: 43@ = 536@ 
006B: 43@ *= 42@ 
0087: 542@ = 538@ 
005B: 542@ += 43@ 
0085: 481@ = 528@ 
0085: 482@ = 529@ 
0087: 483@ = 541@ 
0087: 484@ = 542@ 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_49568 
532@ = 1 

:POOL2_49568
if and
  531@ == 0 
  532@ == 0 
else_jump @POOL2_49600 
530@ = 0 

:POOL2_49600
if and
  531@ == 1 
  532@ == 0 
else_jump @POOL2_49632 
530@ = 1 

:POOL2_49632
if and
  531@ == 0 
  532@ == 1 
else_jump @POOL2_49664 
530@ = 2 

:POOL2_49664
if and
  531@ == 1 
  532@ == 1 
else_jump @POOL2_49696 
530@ = 3 

:POOL2_49696
return 

:POOL2_49698
545@ = 0 
547@ = 2.5 
006B: 547@ *= 52@ 
548@ = 0 

:POOL2_49730
if 
  6 > 548@ 
else_jump @POOL2_49952 
0509: 546@ = distance_between_XY 543@ 544@ and_XY 54@(548@,6f) 60@(548@,6f) 
if 
0025:   547@ > 546@ 
else_jump @POOL2_49938 
03A9: save_newline_to_debug_file 
05B6: 57 
545@ = 1 
548@ = 6 

:POOL2_49938
548@ += 1 
jump @POOL2_49730 

:POOL2_49952
return 

:POOL2_49954
553@ = 0 
03A9: save_newline_to_debug_file 
05B6: 58 
0085: 481@ = 549@ 
482@ = 0 
0087: 483@ = 551@ 
0087: 484@ = 552@ 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_50472 
05B6: 59 
0085: 481@ = 550@ 
482@ = 0 
0087: 483@ = 551@ 
0087: 484@ = 552@ 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_50472 
05B6: 60 
553@ = 1 

:POOL2_50472
return 

:POOL2_50474
557@ = 0 
0085: 481@ = 549@ 
482@ = 0 
0087: 483@ = 551@ 
0087: 484@ = 552@ 
gosub @POOL2_46939 
if 
  485@ == 1 
else_jump @POOL2_50544 
557@ = 1 

:POOL2_50544
return 

:POOL2_50546
0087: 565@ = 52@ 
565@ *= 2.0 
0087: 562@ = 52@ 
562@ *= -1.0 
0087: 566@ = 565@ 
566@ *= -1.0 
0087: 42@ = 565@ 
006B: 42@ *= 565@ 
0087: 43@ = 52@ 
006B: 43@ *= 52@ 
0087: 563@ = 42@ 
0063: 563@ -= 43@ 
01FB: 563@ = square_root 563@ 
0087: 564@ = 563@ 
564@ *= -1.0 
567@ = 1 

:POOL2_50681
if 
  15 > 567@ 
else_jump @POOL2_50724 
Object.KeepInMemory(82@(567@,16i)) = False
567@ += 1 
jump @POOL2_50681 

:POOL2_50724
Object.PutAt(83@, 558@, 559@, 560@)
Object.Angle(83@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 83@ with_offset 562@ 564@ 0.0 
Object.PutAt(91@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(91@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 91@ with_offset 565@ 0.0 0.0 
Object.PutAt(85@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(85@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 91@ with_offset 562@ 564@ 0.0 
Object.PutAt(89@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(89@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 89@ with_offset 565@ 0.0 0.0 
Object.PutAt(90@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(90@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 90@ with_offset 565@ 0.0 0.0 
Object.PutAt(92@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(92@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 89@ with_offset 562@ 564@ 0.0 
Object.PutAt(93@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(93@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 93@ with_offset 565@ 0.0 0.0 
Object.PutAt(84@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(84@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 84@ with_offset 565@ 0.0 0.0 
Object.PutAt(97@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(97@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 97@ with_offset 565@ 0.0 0.0 
Object.PutAt(87@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(87@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 93@ with_offset 562@ 564@ 0.0 
Object.PutAt(88@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(88@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 88@ with_offset 565@ 0.0 0.0 
Object.PutAt(94@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(94@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 94@ with_offset 565@ 0.0 0.0 
Object.PutAt(95@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(95@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 95@ with_offset 565@ 0.0 0.0 
Object.PutAt(86@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(86@) = 561@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 86@ with_offset 565@ 0.0 0.0 
Object.PutAt(96@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(96@) = 561@
return 

:POOL2_51426
602@ = -0.96 
603@ = 0.49 
604@ = 0.97 
605@ = 0.49 
606@ = 0.97 
607@ = -0.49 
608@ = -0.96 
609@ = -0.49 
0400: store_coords_to 571@ 572@ 573@ from_object 82@ with_offset 0.0 -5.0 0.0 
Object.StorePos(82@, 574@, 575@, 576@)
02CE: " + tempvar_Float_3 + @" = ground_z_at 574@ 575@ 576@ 
0400: store_coords_to 577@ 578@ 579@ from_object 163@ with_offset 602@ 603@ 0.0 
0400: store_coords_to 580@ 581@ 582@ from_object 163@ with_offset 604@ 605@ 0.0 
if 
05B0:   unknown_calculate 571@ 572@ 574@ and 575@ 577@ 578@ 580@ 581@ store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
else_jump @POOL2_51712 
0089: 585@ = " + tempvar_Float_1 + @" 
0089: 589@ = " + tempvar_Float_2 + @" 
0089: 593@ = " + tempvar_Float_3 + @" 
0087: 616@ = 604@ 
0063: 616@ -= 602@ 
0087: 617@ = 605@ 
0063: 617@ -= 603@ 

:POOL2_51712
0400: store_coords_to 577@ 578@ 579@ from_object 163@ with_offset 606@ 607@ 0.0 
if 
05B0:   unknown_calculate 571@ 572@ 574@ and 575@ 577@ 578@ 580@ 581@ store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
else_jump @POOL2_51836 
0089: 585@ = " + tempvar_Float_1 + @" 
0089: 589@ = " + tempvar_Float_2 + @" 
0089: 593@ = " + tempvar_Float_3 + @" 
0087: 616@ = 606@ 
0063: 616@ -= 604@ 
0087: 617@ = 607@ 
0063: 617@ -= 605@ 

:POOL2_51836
0400: store_coords_to 580@ 581@ 582@ from_object 163@ with_offset 608@ 609@ 0.0 
if 
05B0:   unknown_calculate 571@ 572@ 574@ and 575@ 577@ 578@ 580@ 581@ store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
else_jump @POOL2_51960 
0089: 585@ = " + tempvar_Float_1 + @" 
0089: 589@ = " + tempvar_Float_2 + @" 
0089: 593@ = " + tempvar_Float_3 + @" 
0087: 616@ = 608@ 
0063: 616@ -= 606@ 
0087: 617@ = 609@ 
0063: 617@ -= 607@ 

:POOL2_51960
0400: store_coords_to 577@ 578@ 579@ from_object 163@ with_offset 602@ 603@ 0.0 
if 
05B0:   unknown_calculate 571@ 572@ 574@ and 575@ 577@ 578@ 580@ 581@ store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
else_jump @POOL2_52084 
0089: 585@ = " + tempvar_Float_1 + @" 
0089: 589@ = " + tempvar_Float_2 + @" 
0089: 593@ = " + tempvar_Float_3 + @" 
0087: 616@ = 602@ 
0063: 616@ -= 608@ 
0087: 617@ = 603@ 
0063: 617@ -= 609@ 

:POOL2_52084
0087: 614@ = 574@ 
0063: 614@ -= 571@ 
0087: 615@ = 575@ 
0063: 615@ -= 572@ 
05A4: get_angle_between_vectors_origin_to 614@ 615@ and_origin_to 616@ 617@ store_to 613@ 
if 
  613@ > 90.0 
else_jump @POOL2_52174 
613@ += -180.0 
613@ *= -1.0 

:POOL2_52174
0087: 169@ = 574@ 
0063: 169@ -= 585@ 
0087: 170@ = 575@ 
0063: 170@ -= 589@ 
0087: 171@ = 576@ 
0063: 171@ -= 593@ 
0604: get_Z_angle_for_point 169@ 170@ store_to 597@ 
0087: 595@ = 597@ 
0087: 596@ = 597@ 
0087: 598@ = 597@ 
0087: 594@ = 593@ 
0087: 591@ = 593@ 
0087: 592@ = 593@ 
0509: 599@ = distance_between_XY 574@ 575@ and_XY 585@ 589@ 
0073: 169@ /= 599@ 
0073: 170@ /= 599@ 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 3.0 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 3.0 
0087: 583@ = 585@ 
0065: 583@ -= " + tempvar_Float_1 + @" 
0087: 587@ = 589@ 
0065: 587@ -= " + tempvar_Float_2 + @" 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 1.0 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 1.0 
0087: 610@ = 585@ 
0065: 610@ -= " + tempvar_Float_1 + @" 
0087: 611@ = 589@ 
0065: 611@ -= " + tempvar_Float_2 + @" 
0087: 612@ = 593@ 
if 
  0.25 > 599@ 
else_jump @POOL2_52493 
600@ = 1 
jump @POOL2_52570 

:POOL2_52493
if 
  0.65 > 599@ 
else_jump @POOL2_52528 
600@ = 2 
jump @POOL2_52570 

:POOL2_52528
if 
  1.1 > 599@ 
else_jump @POOL2_52563 
600@ = 3 
jump @POOL2_52570 

:POOL2_52563
600@ = 4 

:POOL2_52570
if 
  613@ > 70.0 
else_jump @POOL2_52623 
600@ += 1 
if 
  600@ > 4 
else_jump @POOL2_52623 
600@ = 4 

:POOL2_52623
if 
  600@ == 1 
else_jump @POOL2_52709 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 0.615 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 0.615 
0087: 584@ = 574@ 
0065: 584@ -= " + tempvar_Float_1 + @" 
0087: 588@ = 575@ 
0065: 588@ -= " + tempvar_Float_2 + @" 

:POOL2_52709
if 
  600@ == 2 
else_jump @POOL2_52795 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 1.0 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 1.0 
0087: 584@ = 574@ 
0065: 584@ -= " + tempvar_Float_1 + @" 
0087: 588@ = 575@ 
0065: 588@ -= " + tempvar_Float_2 + @" 

:POOL2_52795
if 
  600@ == 3 
else_jump @POOL2_52881 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 1.6 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 1.6 
0087: 584@ = 574@ 
0065: 584@ -= " + tempvar_Float_1 + @" 
0087: 588@ = 575@ 
0065: 588@ -= " + tempvar_Float_2 + @" 

:POOL2_52881
if 
  600@ == 4 
else_jump @POOL2_52967 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 2.1 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 2.1 
0087: 584@ = 574@ 
0065: 584@ -= " + tempvar_Float_1 + @" 
0087: 588@ = 575@ 
0065: 588@ -= " + tempvar_Float_2 + @" 

:POOL2_52967
0509: " + Distance_Between_Points + @" = distance_between_XY 574@ 575@ and_XY 584@ 588@ 
0087: 42@ = 599@ 
42@ += 0.3 
if 
0027:   42@ > " + Distance_Between_Points + @" 
else_jump @POOL2_53103 
0087: 42@ = 599@ 
42@ += 0.3 
0088: " + tempvar_Float_1 + @" = 169@ 
006D: " + tempvar_Float_1 + @" *= 42@ 
0088: " + tempvar_Float_2 + @" = 170@ 
006D: " + tempvar_Float_2 + @" *= 42@ 
0087: 584@ = 574@ 
0065: 584@ -= " + tempvar_Float_1 + @" 
0087: 588@ = 575@ 
0065: 588@ -= " + tempvar_Float_2 + @" 

:POOL2_53103
if 
  600@ == 1 
else_jump @POOL2_53189 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 0.655 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 0.655 
0087: 586@ = 574@ 
0065: 586@ -= " + tempvar_Float_1 + @" 
0087: 590@ = 575@ 
0065: 590@ -= " + tempvar_Float_2 + @" 

:POOL2_53189
if 
  600@ == 2 
else_jump @POOL2_53275 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 1.0 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 1.0 
0087: 586@ = 574@ 
0065: 586@ -= " + tempvar_Float_1 + @" 
0087: 590@ = 575@ 
0065: 590@ -= " + tempvar_Float_2 + @" 

:POOL2_53275
if 
  600@ == 3 
else_jump @POOL2_53361 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 1.6 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 1.6 
0087: 586@ = 574@ 
0065: 586@ -= " + tempvar_Float_1 + @" 
0087: 590@ = 575@ 
0065: 590@ -= " + tempvar_Float_2 + @" 

:POOL2_53361
if 
  600@ == 4 
else_jump @POOL2_53447 
0088: " + tempvar_Float_1 + @" = 169@ 
" + tempvar_Float_1 + @" *= 2.1 
0088: " + tempvar_Float_2 + @" = 170@ 
" + tempvar_Float_2 + @" *= 2.1 
0087: 586@ = 574@ 
0065: 586@ -= " + tempvar_Float_1 + @" 
0087: 590@ = 575@ 
0065: 590@ -= " + tempvar_Float_2 + @" 

:POOL2_53447
return 

:POOL2_53449
038D: draw_texture 1 position 618@ 619@ size 620@ 621@ RGBA 128 128 128 255 
038D: draw_texture 2 position 622@ 623@ size 624@ 625@ RGBA 128 128 128 255 
if or
00E1:   player 180@ pressed_key 1 
00E1:   player 180@ pressed_key 0 
else_jump @POOL2_54000 
0494: get_joystick 180@ direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008D: " + tempvar_Float_1 + @" = integer " + Move_Axis_X + @" to_float 
008D: " + tempvar_Float_2 + @" = integer " + Move_Axis_Y + @" to_float 
" + tempvar_Float_1 + @" /= 128.0 
" + tempvar_Float_2 + @" /= 128.0 
" + tempvar_Float_1 + @" *= 5.0 
" + tempvar_Float_2 + @" *= 5.0 
0087: 42@ = 622@ 
005D: 42@ += " + tempvar_Float_1 + @" 
0087: 44@ = 620@ 
44@ /= 2.0 
0087: 43@ = 618@ 
005B: 43@ += 44@ 
if 
0025:   43@ > 42@ 
else_jump @POOL2_53715 
0087: 43@ = 618@ 
0063: 43@ -= 44@ 
if 
0025:   42@ > 43@ 
else_jump @POOL2_53715 
0088: " + tempvar_Float_1 + @" = 42@ 

:POOL2_53715
0087: 42@ = 623@ 
005D: 42@ += " + tempvar_Float_2 + @" 
0087: 44@ = 621@ 
44@ /= 2.0 
0087: 43@ = 619@ 
005B: 43@ += 44@ 
if 
0025:   43@ > 42@ 
else_jump @POOL2_53827 
0087: 43@ = 619@ 
0063: 43@ -= 44@ 
if 
0025:   42@ > 43@ 
else_jump @POOL2_53827 
0088: " + tempvar_Float_2 + @" = 42@ 

:POOL2_53827
0509: 42@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 618@ 619@ 
0087: 43@ = 620@ 
43@ /= 3.2 
if 
0025:   42@ > 43@ 
else_jump @POOL2_53984 
0089: 169@ = " + tempvar_Float_1 + @" 
0063: 169@ -= 618@ 
0089: 170@ = " + tempvar_Float_2 + @" 
0063: 170@ -= 619@ 
0073: 169@ /= 42@ 
0073: 170@ /= 42@ 
006B: 169@ *= 43@ 
006B: 170@ *= 43@ 
0087: 622@ = 618@ 
005B: 622@ += 169@ 
0087: 623@ = 619@ 
005B: 623@ += 170@ 
jump @POOL2_54000 

:POOL2_53984
0089: 622@ = " + tempvar_Float_1 + @" 
0089: 623@ = " + tempvar_Float_2 + @" 

:POOL2_54000
return 

:POOL2_54002
0087: 631@ = 52@ 
631@ *= 2.0 
629@ = 1 

:POOL2_54027
if 
  16 > 629@ 
else_jump @POOL2_54229 
if 
03CA:   object 82@(629@,16i) exists 
else_jump @POOL2_54215 
Object.StorePos(82@(629@,16i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 630@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 627@ 628@ 
if 
0025:   631@ > 630@ 
else_jump @POOL2_54215 
0087: 632@ = 627@ 
0065: 632@ -= " + tempvar_Float_1 + @" 
0087: 633@ = 628@ 
0065: 633@ -= " + tempvar_Float_2 + @" 
0073: 632@ /= 630@ 
0073: 633@ /= 630@ 
006B: 632@ *= 631@ 
006B: 633@ *= 631@ 
0089: 627@ = " + tempvar_Float_1 + @" 
005B: 627@ += 632@ 
0089: 628@ = " + tempvar_Float_2 + @" 
005B: 628@ += 633@ 

:POOL2_54215
629@ += 1 
jump @POOL2_54027 

:POOL2_54229
0087: 630@ = 98@ 
if 
0025:   630@ > 627@ 
else_jump @POOL2_54264 
0087: 627@ = 630@ 

:POOL2_54264
0087: 630@ = 99@ 
if 
0025:   627@ > 630@ 
else_jump @POOL2_54299 
0087: 627@ = 630@ 

:POOL2_54299
0087: 630@ = 100@ 
if 
0025:   630@ > 628@ 
else_jump @POOL2_54334 
0087: 628@ = 630@ 

:POOL2_54334
0087: 630@ = 101@ 
if 
0025:   628@ > 630@ 
else_jump @POOL2_54369 
0087: 628@ = 630@ 

:POOL2_54369
return 

:POOL2_54371
0400: store_coords_to " + _6460 + @" " + _6461 + @" " + _6462 + @" from_object 163@ with_offset 0.0 0.0 0.0 
0400: store_coords_to " + _6463 + @" " + _6464 + @" " + _6465 + @" from_object 163@ with_offset 0.0 -1.0 0.0 
0086: " + _6466 + @" = " + _6460 + @" 
0061: " + _6466 + @" -= " + _6463 + @" 
0086: " + _6468 + @" = " + _6461 + @" 
0061: " + _6468 + @" -= " + _6464 + @" 
0509: " + _6470 + @" = distance_between_XY " + _6460 + @" " + _6461 + @" and_XY " + _6463 + @" " + _6464 + @" 
0071: " + _6466 + @" /= " + _6470 + @" 
0071: " + _6468 + @" /= " + _6470 + @" 
0086: " + _6467 + @" = " + _6468 + @" 
0086: " + _6469 + @" = " + _6466 + @" 
" + _6469 + @" *= -1.0 
return 

:POOL2_54522
0937: text_draw_box_cornerA 29.0 220.0 cornerB 641@ 647@ GXT_reference 'BJ_TITL' style 2  
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
0343: set_text_draw_linewidth 640.0 
033E: set_draw_text_position 36.0 240.0 GXT 'BJ_01'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 260.0 GXT 'DOLLAR' number 155@  
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
0343: set_text_draw_linewidth 640.0 
033E: set_draw_text_position 36.0 290.0 GXT 'BJ_02'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 310.0 GXT 'DOLLAR' number " + _9460 + @"  
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
0343: set_text_draw_linewidth 640.0 
033E: set_draw_text_position 36.0 340.0 GXT 'BJ_03'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 360.0 GXT 'DOLLAR' number " + _9461 + @"  
return 

:POOL2_54829
if and
  274@ == 0 
  271@ == 0 
else_jump @POOL2_54875 
635@ = 1 
gosub @POOL2_57034 
jump @POOL2_56226 

:POOL2_54875
0937: text_draw_box_cornerA 29.0 220.0 cornerB 637@ 643@ GXT_reference 'SCORE' style 2  
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 240.0 GXT 'PL_01'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
if 
  217@ == 0 
else_jump @POOL2_55000 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_12'  

:POOL2_55000
if 
  217@ == 1 
else_jump @POOL2_55039 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_13'  

:POOL2_55039
if 
  217@ == -1 
else_jump @POOL2_55078 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_15'  

:POOL2_55078
if 
  217@ == 2 
else_jump @POOL2_55117 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_14'  

:POOL2_55117
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
if 
  178@ == 1 
else_jump @POOL2_55184 
033E: set_draw_text_position 36.0 290.0 GXT 'PL_02'  
jump @POOL2_55205 

:POOL2_55184
033E: set_draw_text_position 36.0 290.0 GXT 'PL_03'  

:POOL2_55205
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
if 
  218@ == 0 
else_jump @POOL2_55259 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_12'  

:POOL2_55259
if 
  218@ == 1 
else_jump @POOL2_55298 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_13'  

:POOL2_55298
if 
  218@ == -1 
else_jump @POOL2_55337 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_15'  

:POOL2_55337
if 
  218@ == 2 
else_jump @POOL2_55376 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_14'  

:POOL2_55376
if 
  274@ > 0 
else_jump @POOL2_55696 
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 340.0 GXT 'PL_04'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
0871: init_jump_table 274@ total_jumps 7 default_jump 0 @POOL2_55689 jumps 0 @POOL2_55514 1 @POOL2_55521 2 @POOL2_55549 3 @POOL2_55577 4 @POOL2_55605 5 @POOL2_55633 6 @POOL2_55661 

:POOL2_55514
jump @POOL2_55689 

:POOL2_55521
033E: set_draw_text_position 36.0 360.0 GXT 'FOUL1'  
jump @POOL2_55689 

:POOL2_55549
033E: set_draw_text_position 36.0 360.0 GXT 'FOUL2'  
jump @POOL2_55689 

:POOL2_55577
033E: set_draw_text_position 36.0 360.0 GXT 'FOUL3'  
jump @POOL2_55689 

:POOL2_55605
033E: set_draw_text_position 36.0 360.0 GXT 'FOUL4'  
jump @POOL2_55689 

:POOL2_55633
033E: set_draw_text_position 36.0 360.0 GXT 'FOUL5'  
jump @POOL2_55689 

:POOL2_55661
033E: set_draw_text_position 36.0 360.0 GXT 'FOUL6'  
jump @POOL2_55689 

:POOL2_55689
jump @POOL2_56226 

:POOL2_55696
if 
  271@ > 0 
else_jump @POOL2_56226 
if 
  271@ == 1 
else_jump @POOL2_55888 
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 340.0 GXT 'PL_05'  
39@ = 1 

:POOL2_55781
if 
  16 > 39@ 
else_jump @POOL2_55881 
if 
   not 255@(39@,16i) == 0 
else_jump @POOL2_55867 
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
045A: draw_text_1number 36.0 360.0 GXT 'NUM' number 39@  
39@ = 16 

:POOL2_55867
39@ += 1 
jump @POOL2_55781 

:POOL2_55881
jump @POOL2_56226 

:POOL2_55888
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 340.0 GXT 'PL_06'  
39@ = 1 
0085: 40@ = 271@ 
42@ = 36.0 

:POOL2_55955
if 
  40@ > 0 
else_jump @POOL2_56226 

:POOL2_55973
if 
  16 > 39@ 
else_jump @POOL2_56219 
if 
   not 255@(39@,16i) == 0 
else_jump @POOL2_56180 
if 
  40@ > 1 
else_jump @POOL2_56122 
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
0A08: get_gxt_string_1number 'COMMA' number 39@ width_to 41@  
0093: 43@ = integer 41@ to_float 
045A: draw_text_1number 42@ 360.0 GXT 'COMMA' number 39@  
005B: 42@ += 43@ 
39@ += 1 
40@ -= 1 
jump @POOL2_56173 

:POOL2_56122
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
045A: draw_text_1number 42@ 360.0 GXT 'NUM' number 39@  
40@ = -1 
39@ = 16 

:POOL2_56173
jump @POOL2_56187 

:POOL2_56180
39@ += 1 

:POOL2_56187
if 
  39@ >= 16 
else_jump @POOL2_56212 
40@ = -1 

:POOL2_56212
jump @POOL2_55973 

:POOL2_56219
jump @POOL2_55955 

:POOL2_56226
return 
if or
0736:   is_keyboard_key_just_pressed 131 
0736:   is_keyboard_key_just_pressed 87 
else_jump @POOL2_56258 
621@ += 1.0 

:POOL2_56258
if or
0736:   is_keyboard_key_just_pressed 130 
0736:   is_keyboard_key_just_pressed 90 
else_jump @POOL2_56288 
621@ += -1.0 

:POOL2_56288
if or
0736:   is_keyboard_key_just_pressed 128 
0736:   is_keyboard_key_just_pressed 68 
else_jump @POOL2_56318 
620@ += 1.0 

:POOL2_56318
if or
0736:   is_keyboard_key_just_pressed 129 
0736:   is_keyboard_key_just_pressed 65 
else_jump @POOL2_56348 
620@ += -1.0 

:POOL2_56348
if or
0736:   is_keyboard_key_just_pressed 145 
0736:   is_keyboard_key_just_pressed 87 
else_jump @POOL2_56378 
624@ += 1.0 

:POOL2_56378
if or
0736:   is_keyboard_key_just_pressed 139 
0736:   is_keyboard_key_just_pressed 90 
else_jump @POOL2_56408 
624@ += -1.0 

:POOL2_56408
if or
0736:   is_keyboard_key_just_pressed 143 
0736:   is_keyboard_key_just_pressed 68 
else_jump @POOL2_56438 
625@ += 1.0 

:POOL2_56438
if or
0736:   is_keyboard_key_just_pressed 141 
0736:   is_keyboard_key_just_pressed 65 
else_jump @POOL2_56468 
625@ += -1.0 

:POOL2_56468
if 
0736:   is_keyboard_key_just_pressed 137 
else_jump @POOL2_57032 
03A9: save_newline_to_debug_file 
05B6: 61 
03A8: save_float_to_debug_file 621@ 
03A9: save_newline_to_debug_file 
05B6: 62 
03A8: save_float_to_debug_file 620@ 
03A9: save_newline_to_debug_file 
05B6: 63 
03A8: save_float_to_debug_file 624@ 
03A9: save_newline_to_debug_file 
05B6: 64 
03A8: save_float_to_debug_file 625@ 

:POOL2_57032
return 

:POOL2_57034
if 
  635@ == 0 
else_jump @POOL2_57283 
39@ = 0 
if 
  3000 > 205@ 
else_jump @POOL2_57085 
39@ = 1 

:POOL2_57085
if 
  236@ == 1 
else_jump @POOL2_57142 
205@ = 0 
39@ = 1 
if 
  198@ > 1 
else_jump @POOL2_57142 
198@ = 0 

:POOL2_57142
if 
  198@ == 0 
else_jump @POOL2_57187 
03E6: remove_text_box 
0512: show_permanent_text_box 'PL_H3'  
205@ = 0 
198@ += 1 

:POOL2_57187
if 
  34@ == 5 
else_jump @POOL2_57269 
if 
  198@ == 1 
else_jump @POOL2_57262 
if 
  205@ > 3000 
else_jump @POOL2_57262 
03E6: remove_text_box 
0512: show_permanent_text_box 'PL_H7'  
198@ += 1 

:POOL2_57262
jump @POOL2_57276 

:POOL2_57269
39@ = 1 

:POOL2_57276
jump @POOL2_57297 

:POOL2_57283
39@ = 1 
635@ = 0 

:POOL2_57297
if 
  39@ == 1 
else_jump @POOL2_57816 
0937: text_draw_box_cornerA 29.0 270.0 cornerB 638@ 644@ GXT_reference 'SCORE' style 2  
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 290.0 GXT 'PL_01'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
if 
  217@ == 0 
else_jump @POOL2_57440 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_12'  

:POOL2_57440
if 
  217@ == 1 
else_jump @POOL2_57479 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_13'  

:POOL2_57479
if 
  217@ == -1 
else_jump @POOL2_57518 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_15'  

:POOL2_57518
if 
  217@ == 2 
else_jump @POOL2_57557 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_14'  

:POOL2_57557
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
if 
  178@ == 1 
else_jump @POOL2_57624 
033E: set_draw_text_position 36.0 340.0 GXT 'PL_02'  
jump @POOL2_57645 

:POOL2_57624
033E: set_draw_text_position 36.0 340.0 GXT 'PL_03'  

:POOL2_57645
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
if 
  218@ == 0 
else_jump @POOL2_57699 
033E: set_draw_text_position 36.0 360.0 GXT 'PL_12'  

:POOL2_57699
if 
  218@ == 1 
else_jump @POOL2_57738 
033E: set_draw_text_position 36.0 360.0 GXT 'PL_13'  

:POOL2_57738
if 
  218@ == -1 
else_jump @POOL2_57777 
033E: set_draw_text_position 36.0 360.0 GXT 'PL_15'  

:POOL2_57777
if 
  218@ == 2 
else_jump @POOL2_57816 
033E: set_draw_text_position 36.0 360.0 GXT 'PL_14'  

:POOL2_57816
return 

:POOL2_57818
636@ = 0.4753 
642@ = 2.3176 
0871: init_jump_table " + Current_Language + @" total_jumps 4 default_jump 1 @POOL2_58009 jumps 1 @POOL2_57901 2 @POOL2_57955 3 @POOL2_57982 4 @POOL2_57928 -1 @POOL2_58036 -1 @POOL2_58036 -1 @POOL2_58036 

:POOL2_57901
637@ = 210.6556 
643@ = 426.4957 
jump @POOL2_58036 

:POOL2_57928
637@ = 175.0805 
643@ = 426.4957 
jump @POOL2_58036 

:POOL2_57955
637@ = 190.782 
643@ = 409.0 
jump @POOL2_58036 

:POOL2_57982
637@ = 214.9799 
643@ = 409.0 
jump @POOL2_58036 

:POOL2_58009
637@ = 174.4835 
643@ = 409.0 
jump @POOL2_58036 

:POOL2_58036
0871: init_jump_table " + Current_Language + @" total_jumps 3 default_jump 1 @POOL2_58180 jumps 2 @POOL2_58126 3 @POOL2_58153 4 @POOL2_58099 -1 @POOL2_58207 -1 @POOL2_58207 -1 @POOL2_58207 -1 @POOL2_58207 

:POOL2_58099
638@ = 179.098 
644@ = 396.8582 
jump @POOL2_58207 

:POOL2_58126
638@ = 166.0992 
644@ = 396.8582 
jump @POOL2_58207 

:POOL2_58153
638@ = 205.4915 
644@ = 396.8582 
jump @POOL2_58207 

:POOL2_58180
638@ = 157.0 
644@ = 396.8582 
jump @POOL2_58207 

:POOL2_58207
0871: init_jump_table " + Current_Language + @" total_jumps 1 default_jump 1 @POOL2_58295 jumps 3 @POOL2_58270 -1 @POOL2_58322 -1 @POOL2_58322 -1 @POOL2_58322 -1 @POOL2_58322 -1 @POOL2_58322 -1 @POOL2_58322 

:POOL2_58270
0087: 639@ = 638@ 
645@ = 394.4953 
jump @POOL2_58322 

:POOL2_58295
639@ = 168.1938 
645@ = 394.4953 
jump @POOL2_58322 

:POOL2_58322
640@ = 0.4914 
646@ = 2.3977 
0871: init_jump_table " + Current_Language + @" total_jumps 1 default_jump 1 @POOL2_58432 jumps 3 @POOL2_58405 -1 @POOL2_58459 -1 @POOL2_58459 -1 @POOL2_58459 -1 @POOL2_58459 -1 @POOL2_58459 -1 @POOL2_58459 

:POOL2_58405
641@ = 178.0981 
647@ = 409.0 
jump @POOL2_58459 

:POOL2_58432
641@ = 157.0 
647@ = 409.0 
jump @POOL2_58459 

:POOL2_58459
return 
if 
0736:   is_keyboard_key_just_pressed 67 
else_jump @POOL2_58526 
648@ += 1 
if 
  648@ > 5 
else_jump @POOL2_58508 
648@ = 0 

:POOL2_58508
0663: printint ""SCREEN_EDIT"" 648@ 

:POOL2_58526
if 
0736:   is_keyboard_key_just_pressed 131 
else_jump @POOL2_58556 
642@(648@,6f) += -0.1 

:POOL2_58556
if 
0736:   is_keyboard_key_just_pressed 130 
else_jump @POOL2_58586 
642@(648@,6f) += 0.1 

:POOL2_58586
if 
0736:   is_keyboard_key_just_pressed 128 
else_jump @POOL2_58616 
636@(648@,6f) += 0.1 

:POOL2_58616
if 
0736:   is_keyboard_key_just_pressed 129 
else_jump @POOL2_58646 
636@(648@,6f) += -0.1 

:POOL2_58646
if 
0736:   is_keyboard_key_just_pressed 137 
else_jump @POOL2_59387 
03A9: save_newline_to_debug_file 
05B6: 65 
03A9: save_newline_to_debug_file 
39@ = 0 

:POOL2_58803
if 
  6 > 39@ 
else_jump @POOL2_59387 
05B6: 66 
03A7: save_int_to_debug_file 39@ 
05B6: 67 
03A8: save_float_to_debug_file 636@(39@,6f) 
03A9: save_newline_to_debug_file 
05B6: 68 
03A7: save_int_to_debug_file 39@ 
05B6: 69 
03A8: save_float_to_debug_file 642@(39@,6f) 
03A9: save_newline_to_debug_file 
39@ += 1 
jump @POOL2_58803 

:POOL2_59387
return 

:POOL2_59389
39@ = 0 
if 
  3000 > 205@ 
else_jump @POOL2_59422 
39@ = 1 

:POOL2_59422
if 
  198@ == 0 
else_jump @POOL2_59467 
03E6: remove_text_box 
0512: show_permanent_text_box 'PL_H6'  
205@ = 0 
198@ += 1 

:POOL2_59467
if 
  34@ == 4 
else_jump @POOL2_59542 
if 
  198@ == 1 
else_jump @POOL2_59542 
if 
  205@ > 3000 
else_jump @POOL2_59542 
03E6: remove_text_box 
0512: show_permanent_text_box 'PL_H7'  
198@ += 1 

:POOL2_59542
if 
  39@ == 1 
else_jump @POOL2_60139 
0937: text_draw_box_cornerA 29.0 220.0 cornerB 639@ 645@ GXT_reference 'SCORE' style 2  
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 240.0 GXT 'PL_01'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
if 
  217@ == 0 
else_jump @POOL2_59685 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_12'  

:POOL2_59685
if 
  217@ == 1 
else_jump @POOL2_59724 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_13'  

:POOL2_59724
if 
  217@ == -1 
else_jump @POOL2_59763 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_15'  

:POOL2_59763
if 
  217@ == 2 
else_jump @POOL2_59802 
033E: set_draw_text_position 36.0 260.0 GXT 'PL_14'  

:POOL2_59802
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
if 
  178@ == 1 
else_jump @POOL2_59869 
033E: set_draw_text_position 36.0 290.0 GXT 'PL_02'  
jump @POOL2_59890 

:POOL2_59869
033E: set_draw_text_position 36.0 290.0 GXT 'PL_03'  

:POOL2_59890
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
if 
  218@ == 0 
else_jump @POOL2_59944 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_12'  

:POOL2_59944
if 
  218@ == 1 
else_jump @POOL2_59983 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_13'  

:POOL2_59983
if 
  218@ == -1 
else_jump @POOL2_60022 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_15'  

:POOL2_60022
if 
  218@ == 2 
else_jump @POOL2_60061 
033E: set_draw_text_position 36.0 310.0 GXT 'PL_14'  

:POOL2_60061
gosub @POOL2_60436 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 340.0 GXT 'PL_16'  
gosub @POOL2_60436 
033F: set_text_draw_letter_size 636@ 642@ 
033E: set_draw_text_position 36.0 360.0 GXT 'PL_17'  

:POOL2_60139
return 
033F: set_text_draw_letter_size 0.4487 1.5974 
0340: set_text_draw_RGBA 128 148 178 255 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.4487 1.5974 
0340: set_text_draw_RGBA 128 148 178 255 
03E4: set_text_draw_align_right 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.9 2.4 
0340: set_text_draw_RGBA 128 148 178 255 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.9 2.4 
0340: set_text_draw_RGBA 81 25 29 255 
0342: set_text_draw_centered 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.54 1.44 
0340: set_text_draw_RGBA 128 148 178 255 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.405 1.08 
0340: set_text_draw_RGBA 128 148 178 255 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 
033F: set_text_draw_letter_size 0.54 1.44 
0340: set_text_draw_RGBA 81 25 29 255 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:POOL2_60436
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 640@ 646@ 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0087: 649@ = 637@ 
649@ -= 20.0 
0343: set_text_draw_linewidth 649@ 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 
if 
0736:   is_keyboard_key_just_pressed 130 
else_jump @POOL2_60600 
650@ += -0.0001 
39@ = 0 

:POOL2_60536
if 
  16 > 39@ 
else_jump @POOL2_60600 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_60586 
0908: set_object 82@(39@,16i) turn_mass_to 650@ 

:POOL2_60586
39@ += 1 
jump @POOL2_60536 

:POOL2_60600
if 
0736:   is_keyboard_key_just_pressed 137 
else_jump @POOL2_60680 

:POOL2_60616
if 
  16 > 39@ 
else_jump @POOL2_60680 
if 
03CA:   object 82@(39@,16i) exists 
else_jump @POOL2_60666 
0908: set_object 82@(39@,16i) turn_mass_to 650@ 

:POOL2_60666
39@ += 1 
jump @POOL2_60616 

:POOL2_60680
if 
0736:   is_keyboard_key_just_pressed 145 
else_jump @POOL2_60696 

:POOL2_60696
if 
0736:   is_keyboard_key_just_pressed 139 
else_jump @POOL2_60722 
203@ += -0.001 

:POOL2_60722
if 
0736:   is_keyboard_key_just_pressed 143 
else_jump @POOL2_60748 
204@ += 0.001 

:POOL2_60748
if 
0736:   is_keyboard_key_just_pressed 141 
else_jump @POOL2_60774 
204@ += -0.001 

:POOL2_60774
return 

:POOL2_60776
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
return 

:POOL2_60794
01E3: show_text_1number_styled GXT 'M_PASS' number 10000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 10000
Player.ClearWantedLevel(" + PlayerChar + @")
return 

:POOL2_60828
08F6: restore_player_group 
09D8: NOP 0 
0A3F: set_unused_flag 0 
" + _1904 + @" = 0 
040D: unload_wav 4 
39@ = 0 

:POOL2_60856
if 
  10 > 39@ 
else_jump @POOL2_60917 
if 
03CA:   object 347@(39@,10i) exists 
else_jump @POOL2_60903 
Object.Destroy(347@(39@,10i))

:POOL2_60903
39@ += 1 
jump @POOL2_60856 

:POOL2_60917
if 
   not Actor.Dead(" + _9458 + @")
else_jump @POOL2_60982 
0647: AS_actor " + _9458 + @" clear_look_task 
Actor.StorePos(" + _9458 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0089: 223@ = " + tempvar_Float_3 + @" 
0089: 227@ = " + tempvar_Float_3 + @" 

:POOL2_60982
if 
   not Actor.Dead(" + _9458 + @")
else_jump @POOL2_61026 
Actor.StorePos(" + _9458 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.PutAt(" + _9458 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", 227@)

:POOL2_61026
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_61151 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.PutAt(" + PlayerActor + @", 221@, 222@, 223@)
if 
   not Actor.Dead(" + _9458 + @")
else_jump @POOL2_61100 
Actor.StorePos(" + _9458 + @", 165@, 166@, 167@)

:POOL2_61100
0087: 169@ = 165@ 
0065: 169@ -= " + tempvar_Float_1 + @" 
0087: 170@ = 166@ 
0065: 170@ -= " + tempvar_Float_2 + @" 
0604: get_Z_angle_for_point 169@ 170@ store_to " + tempvar_Angle + @" 
Actor.Angle(" + PlayerActor + @") = " + tempvar_Angle + @"

:POOL2_61151
Model.Load(#POOLCUE)

:POOL2_61156
if 
   not Model.Available(#POOLCUE)
else_jump @POOL2_61183 
wait 0 
jump @POOL2_61156 

:POOL2_61183
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_61223 
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 0 
070B: set_actor " + PlayerActor + @" onbone_attached_object_operation 0 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", PoolCue, 9999)

:POOL2_61223
if 
03CA:   object 106@ exists 
else_jump @POOL2_61244 
Object.Destroy(106@)

:POOL2_61244
if 
03CA:   object 107@ exists 
else_jump @POOL2_61265 
Object.Destroy(107@)

:POOL2_61265
if 
03CA:   object 238@ exists 
else_jump @POOL2_61286 
Object.Destroy(238@)

:POOL2_61286
if 
03CA:   object " + _9459 + @" exists 
else_jump @POOL2_61307 
Object.Destroy(" + _9459 + @")

:POOL2_61307
Model.Destroy(#POOLCUE)
Model.Destroy(#K_POOLQ)
04EF: release_animation ""POOL"" 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_61352 
0792: disembark_instantly_actor " + PlayerActor + @" 
0619: enable_actor " + PlayerActor + @" collision_detection 1 

:POOL2_61352
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
00BE: text_clear_all 
03E6: remove_text_box 
" + OnMission + @" = 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL2_61458 
0792: disembark_instantly_actor " + PlayerActor + @" 
0792: disembark_instantly_actor " + PlayerActor + @" 
0792: disembark_instantly_actor " + PlayerActor + @" 
0792: disembark_instantly_actor " + PlayerActor + @" 
0792: disembark_instantly_actor " + PlayerActor + @" 
0647: AS_actor " + PlayerActor + @" clear_look_task 
0615: define_AS_pack_begin 47@ 
05BA: AS_actor -1 move_mouth 1 ms 
05B9: AS_actor -1 stay_idle 1 ms 
0616: define_AS_pack_end 47@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 47@ 
061B: remove_references_to_AS_pack 47@ 

:POOL2_61458
mission_cleanup 
return 
0454: store_debug_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
03CA:   object 163@ exists 
else_jump @POOL2_61511 
Object.StorePos(163@, 165@, 166@, 167@)
" + tempvar_Angle + @" = Object.Angle(163@)

:POOL2_61511
" + tempvar_Angle + @" *= -1.0 
02F7: 42@ = cosine " + tempvar_Angle + @" 
02F6: 43@ = sine " + tempvar_Angle + @" 
0089: 169@ = " + tempvar_Float_1 + @" 
0063: 169@ -= 165@ 
0089: 170@ = " + tempvar_Float_2 + @" 
0063: 170@ -= 166@ 
0089: 171@ = " + tempvar_Float_3 + @" 
0063: 171@ -= 167@ 
0087: 172@ = 169@ 
006B: 172@ *= 42@ 
0087: 44@ = 170@ 
006B: 44@ *= 43@ 
0063: 172@ -= 44@ 
0087: 173@ = 169@ 
006B: 173@ *= 43@ 
0087: 44@ = 170@ 
006B: 44@ *= 42@ 
005B: 173@ += 44@ 
03A9: save_newline_to_debug_file 
05B6: 70 
03A8: save_float_to_debug_file 172@ 
03A8: save_float_to_debug_file 173@ 
03A8: save_float_to_debug_file 171@ 
0463: store_debug_camera_target_point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0089: 169@ = " + tempvar_Float_1 + @" 
0063: 169@ -= 165@ 
0089: 170@ = " + tempvar_Float_2 + @" 
0063: 170@ -= 166@ 
0089: 171@ = " + tempvar_Float_3 + @" 
0063: 171@ -= 167@ 
0087: 172@ = 169@ 
006B: 172@ *= 42@ 
0087: 44@ = 170@ 
006B: 44@ *= 43@ 
0063: 172@ -= 44@ 
0087: 173@ = 169@ 
006B: 173@ *= 43@ 
0087: 44@ = 170@ 
006B: 44@ *= 42@ 
005B: 173@ += 44@ 
03A9: save_newline_to_debug_file 
05B6: 71 
03A8: save_float_to_debug_file 172@ 
03A8: save_float_to_debug_file 173@ 
03A8: save_float_to_debug_file 171@ 
return 
0454: store_debug_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
056D:   actor 215@ defined 
else_jump @POOL2_62165 
if 
   not Actor.Dead(215@)
else_jump @POOL2_62165 
Actor.StorePos(215@, 165@, 166@, 167@)
" + tempvar_Angle + @" = Actor.Angle(215@)

:POOL2_62165
" + tempvar_Angle + @" *= -1.0 
02F7: 42@ = cosine " + tempvar_Angle + @" 
02F6: 43@ = sine " + tempvar_Angle + @" 
0089: 169@ = " + tempvar_Float_1 + @" 
0063: 169@ -= 165@ 
0089: 170@ = " + tempvar_Float_2 + @" 
0063: 170@ -= 166@ 
0089: 171@ = " + tempvar_Float_3 + @" 
0063: 171@ -= 167@ 
0087: 172@ = 169@ 
006B: 172@ *= 42@ 
0087: 44@ = 170@ 
006B: 44@ *= 43@ 
0063: 172@ -= 44@ 
0087: 173@ = 169@ 
006B: 173@ *= 43@ 
0087: 44@ = 170@ 
006B: 44@ *= 42@ 
005B: 173@ += 44@ 
03A9: save_newline_to_debug_file 
05B6: 72 
03A8: save_float_to_debug_file 172@ 
03A8: save_float_to_debug_file 173@ 
03A8: save_float_to_debug_file 171@ 
0463: store_debug_camera_target_point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0089: 169@ = " + tempvar_Float_1 + @" 
0063: 169@ -= 165@ 
0089: 170@ = " + tempvar_Float_2 + @" 
0063: 170@ -= 166@ 
0089: 171@ = " + tempvar_Float_3 + @" 
0063: 171@ -= 167@ 
0087: 172@ = 169@ 
006B: 172@ *= 42@ 
0087: 44@ = 170@ 
006B: 44@ *= 43@ 
0063: 172@ -= 44@ 
0087: 173@ = 169@ 
006B: 173@ *= 43@ 
0087: 44@ = 170@ 
006B: 44@ *= 42@ 
005B: 173@ += 44@ 
03A9: save_newline_to_debug_file 
05B6: 73 
03A8: save_float_to_debug_file 172@ 
03A8: save_float_to_debug_file 173@ 
03A8: save_float_to_debug_file 171@ 
return" );
            }

        }

    }

}