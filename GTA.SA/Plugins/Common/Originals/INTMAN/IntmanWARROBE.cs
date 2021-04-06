using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class WARROBE : External {

            Int tmp_9816 = global( _9816.startIndex ),
                tmp_9897 = global( _9897.startIndex ),
                tmp_9921 = global( _9921.startIndex ),
                tmp_2486 = global( _2486.startIndex ),
                tmp_2438 = global( _2438.startIndex ),
                tmp_2474 = global( _2474.startIndex ),
                tmp_9953 = global( _9953.startIndex ),
                tmp_2498 = global( _2498.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _9868 + @" = 0 
" + _9872 + @" = 0 
" + _9870 + @" = 0 
" + _9873 + @" = 0 
" + _9874 + @" = 0 
" + _2425 + @" = 0 
" + _2514 + @" = 0 
" + _2515 + @" = 0 
" + _9878 + @" = 0.0 
" + _9875 + @" = 0.0 
" + _9876 + @" = 0.0 
" + _9877 + @" = 0.0 
" + _9878 + @" = 0.0 
" + _9879 + @" = 0.0 
" + _9880 + @" = 0.0 
" + _9881 + @" = 0.0 
" + _9882 + @" = 0.0 
" + _9883 + @" = 0.0 
" + _9884 + @" = 0.0 
" + _9885 + @" = 0.0 
" + _9886 + @" = 0.0 
" + _9887 + @" = 0.0 
" + _9888 + @" = 0.0 
" + _9889 + @" = 0.0 
" + _9890 + @" = 0.0 
" + _9891 + @" = 0.0 
" + _9892 + @" = 0.0 
" + _9893 + @" = 0.0 
" + _9894 + @" = 0.0 
" + _9808 + @" = 0 
" + _9815 + @" = 0 
" + _9882 + @" = 0.0 
" + _9886 + @" = 0.0 
" + _9887 + @" = 0.0 
" + _9888 + @" = 0.0 
" + _9813 + @" = 0.0 
" + _9814 + @" = 0.0 
" + _9812 + @" = 0 
" + _9810 + @" = 0 
" + _9809 + @" = 0 
" + _9870 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2546 + @" = 0 
" + _2547 + @" = 0 
" + _9945 + @" = 0 
" + _9946 + @" = 0 
" + _9947 + @" = 0 
" + _9948 + @" = 0 
" + _9949 + @" = 0 
" + _9950 + @" = 0 
" + _9951 + @" = 0 
" + _9952 + @" = 0 
" + _9967 + @" = 0 
" + _9965 + @" = 0 
" + _9968 + @" = 0 
" + _9970 + @" = 0 
" + _9971 + @" = 0 
" + _9972 + @" = 0 
" + _9973 + @" = 0 
" + _9975 + @" = 0 
" + _9976 + @" = 0 
" + _9977 + @" = 0 
" + _9978 + @" = 0 
" + _9869 + @" = -370 
Model.Load(" + _9869 + @")
04ED: load_animation ""CLOTHES"" 
03CF: load_wav 20800 as 4 
038B: load_requested_models 
set_wb_check_to 0 

:WARROBE_584
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @WARROBE_6450 
077E: get_active_interior_to " + _9895 + @" 
if 
  " + _9895 + @" == 14 
jf @WARROBE_6436 
if 
  " + _9812 + @" > 0 
jf @WARROBE_737 
if 
0A0F:   new_language_set 
jf @WARROBE_737 
03E6: remove_text_box 
08DA: remove_panel " + _9871 + @" 
08DA: remove_panel " + _9966 + @" 
08DA: remove_panel " + _9969 + @" 
08DA: remove_panel " + _9974 + @" 
08DA: remove_panel " + _2417 + @" 
08DA: remove_panel " + _2421 + @" 
" + _9870 + @" = 0 
" + _9965 + @" = 0 
" + _9970 + @" = 0 
" + _9973 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
09FB: " + Current_Language + @" = current_language 

:WARROBE_737
if 
  " + _9812 + @" == 0 
jf @WARROBE_819 
" + _9977 + @" = 1 
" + _9875 + @" = 43.529 
" + _9876 + @" = 0.694 
" + _9877 + @" = 0.012 
" + _9882 + @" = 90.0 
" + _9878 + @" = 0.0 
" + _9812 + @" = 1 

:WARROBE_819
if 
  " + _9812 + @" == 1 
jf @WARROBE_1280 
if 
  " + _9868 + @" == 0 
jf @WARROBE_1226 
03F0: enable_text_draw 1 
08F8: display_stat_update_box 0 
" + _9883 + @" = 212.8715 
0059: " + _9883 + @" += " + _9875 + @" 
" + _9884 + @" = -42.8156 
0059: " + _9884 + @" += " + _9876 + @" 
" + _9885 + @" = 1002.116 
0059: " + _9885 + @" += " + _9877 + @" 
" + _9886 + @" = 213.4791 
0059: " + _9886 + @" += " + _9875 + @" 
" + _9887 + @" = -42.0238 
0059: " + _9887 + @" += " + _9876 + @" 
" + _9888 + @" = 1002.053 
0059: " + _9888 + @" += " + _9877 + @" 
" + _9889 + @" = 214.5148 
0059: " + _9889 + @" += " + _9875 + @" 
" + _9890 + @" = -41.6106 
0059: " + _9890 + @" += " + _9876 + @" 
" + _9891 + @" = 1002.494 
0059: " + _9891 + @" += " + _9877 + @" 
" + _9892 + @" = 214.5367 
0059: " + _9892 + @" += " + _9875 + @" 
" + _9893 + @" = -40.6175 
0059: " + _9893 + @" += " + _9876 + @" 
" + _9894 + @" = 1002.609 
0059: " + _9894 + @" += " + _9877 + @" 
" + _9879 + @" = 214.622 
0059: " + _9879 + @" += " + _9875 + @" 
" + _9880 + @" = -40.652 
0059: " + _9880 + @" += " + _9876 + @" 
" + _9881 + @" = 1001.033 
0059: " + _9881 + @" += " + _9877 + @" 
" + _10001 + @" = 213.874 
0059: " + _10001 + @" += " + _9875 + @" 
" + _10002 + @" = -39.811 
0059: " + _10002 + @" += " + _9876 + @" 
" + _10003 + @" = 1002.2 
0059: " + _10003 + @" += " + _9877 + @" 
" + _9811 + @" = Object.Init(" + _9869 + @", " + _10001 + @", " + _10002 + @", " + _10003 + @")
Object.Angle(" + _9811 + @") = " + _9878 + @"
" + Show_Shop_Sphere + @" = 1 
" + _9868 + @" = 1 

:WARROBE_1226
if 
  " + _9868 + @" == 1 
jf @WARROBE_1280 
if 
04EE:   animation ""CLOTHES"" loaded 
jf @WARROBE_1280 
" + _9868 + @" = 0 
" + _9812 + @" = 2 

:WARROBE_1280
if 
  " + _9812 + @" == 2 
jf @WARROBE_1364 
if 
0102:   actor " + PlayerActor + @" in_sphere " + _9879 + @" " + _9880 + @" " + _9881 + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @WARROBE_1364 
if 
   Player.Controllable(" + PlayerChar + @")
jf @WARROBE_1364 
" + _9812 + @" = 3 

:WARROBE_1364
if 
  " + _9812 + @" == 3 
jf @WARROBE_1499 
if 
   Player.Defined(" + PlayerChar + @")
jf @WARROBE_1485 
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 1.0 
0581: enable_radar 0 
TIMERA = 0 
" + _9868 + @" = 0 
" + _9812 + @" = 4 
jump @WARROBE_1499 

:WARROBE_1485
gosub @WARROBE_6798 
jump @WARROBE_584 

:WARROBE_1499
if 
  " + _9812 + @" == 4 
jf @WARROBE_1880 
if 
  " + _9868 + @" == 0 
jf @WARROBE_1785 
if 
  TIMERA >= 300 
jf @WARROBE_1785 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
08C7: put_actor " + PlayerActor + @" at " + _9879 + @" " + _9880 + @" " + _9881 + @" dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = " + _9882 + @"
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
Camera.SetPosition(" + _9883 + @", " + _9884 + @", " + _9885 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9886 + @", " + _9887 + @", " + _9888 + @", 2)
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_IN"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9813 + @" = 0.0 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_IN""
jf @WARROBE_1723 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation ""CLO_IN"" time 

:WARROBE_1723
if 
03CA:   object " + _9811 + @" exists 
jf @WARROBE_1778 
075A: set_object " + _9811 + @" animation ""CLO_POSE_OUT_O"" IFP_file ""CLOTHES"" 4.0 lockF 0 loop 1 

:WARROBE_1778
" + _9868 + @" = 1 

:WARROBE_1785
if 
  " + _9868 + @" == 1 
jf @WARROBE_1880 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_IN""
jf @WARROBE_1843 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation ""CLO_IN"" time 

:WARROBE_1843
if 
  " + _9813 + @" == 1.0 
jf @WARROBE_1880 
0793: save_player_clothes 
" + _9868 + @" = 0 
" + _9812 + @" = 5 

:WARROBE_1880
if 
  " + _9812 + @" == 5 
jf @WARROBE_2617 
if 
  " + _9870 + @" == 0 
jf @WARROBE_1941 
if 
  1 > " + _9868 + @" 
jf @WARROBE_1941 
gosub @WARROBE_9292 

:WARROBE_1941
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9868 + @" == 0 
jf @WARROBE_2014 
if 
00E1:   player 0 pressed_key 16 
jf @WARROBE_1990 
" + _9868 + @" = 1 

:WARROBE_1990
if 
00E1:   player 0 pressed_key 15 
jf @WARROBE_2014 
" + _9868 + @" = 2 

:WARROBE_2014
if 
  " + _9868 + @" == 1 
jf @WARROBE_2249 
if 
80E1:   not player 0 pressed_key 16 
jf @WARROBE_2249 
08D8: " + _9872 + @" = panel " + _9871 + @" selected_row 
if 
  0 > " + _9872 + @" 
jf @WARROBE_2082 
" + _9872 + @" = 0 

:WARROBE_2082
if 
  " + _9870 + @" == 1 
jf @WARROBE_2114 
08DA: remove_panel " + _9871 + @" 
03E6: remove_text_box 
" + _9870 + @" = 0 

:WARROBE_2114
if or
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'UNIFORM' 
jf @WARROBE_2203 
06D1: " + _9864 + @" = ""CLO_POSE_TORSO"" 
" + _9868 + @" = 0 
" + _9812 + @" = 7 
jump @WARROBE_2249 

:WARROBE_2203
gosub @WARROBE_7198 
if 
  " + _9965 + @" == 0 
jf @WARROBE_2235 
gosub @WARROBE_8122 

:WARROBE_2235
" + _9868 + @" = 0 
" + _9812 + @" = 6 

:WARROBE_2249
if 
  " + _9868 + @" == 2 
jf @WARROBE_2457 
if 
80E1:   not player 0 pressed_key 15 
jf @WARROBE_2457 
if 
  " + _9870 + @" == 1 
jf @WARROBE_2316 
08DA: remove_panel " + _9871 + @" 
03E6: remove_text_box 
" + _9870 + @" = 0 

:WARROBE_2316
if 
  " + _9965 + @" == 1 
jf @WARROBE_2348 
08DA: remove_panel " + _9966 + @" 
03E6: remove_text_box 
" + _9965 + @" = 0 

:WARROBE_2348
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_OUT"" IFP ""CLOTHES"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
" + _9813 + @" = 0.0 
if 
03CA:   object " + _9811 + @" exists 
jf @WARROBE_2450 
075A: set_object " + _9811 + @" animation ""CLO_POSE_IN_O"" IFP_file ""CLOTHES"" 1000.0 lockF 0 loop 1 

:WARROBE_2450
" + _9868 + @" = 5 

:WARROBE_2457
if 
  " + _9868 + @" == 5 
jf @WARROBE_2545 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_OUT""
jf @WARROBE_2517 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation ""CLO_OUT"" time 

:WARROBE_2517
if 
  " + _9813 + @" == 1.0 
jf @WARROBE_2545 
" + _9868 + @" = 6 

:WARROBE_2545
if 
  " + _9868 + @" == 6 
jf @WARROBE_2617 
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0581: enable_radar 1 
" + _9976 + @" = 0 
" + _9870 + @" = 0 
" + _9965 + @" = 0 
" + _9970 + @" = 0 
" + _9812 + @" = 11 

:WARROBE_2617
if 
  " + _9812 + @" == 6 
jf @WARROBE_3004 
if 
  " + _9965 + @" == 0 
jf @WARROBE_2667 
gosub @WARROBE_7198 
gosub @WARROBE_8122 

:WARROBE_2667
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9868 + @" == 0 
jf @WARROBE_2792 
if 
00E1:   player 0 pressed_key 15 
jf @WARROBE_2716 
" + _9868 + @" = 1 

:WARROBE_2716
if 
00E1:   player 0 pressed_key 16 
jf @WARROBE_2792 
08D7: " + _9967 + @" = panel " + _9966 + @" active_row 
if 
  0 > " + _9967 + @" 
jf @WARROBE_2766 
" + _9967 + @" = 0 

:WARROBE_2766
06D1: " + _9864 + @" = " + tmp_9816 + @"(" + _9967 + @",12v) 
gosub @WARROBE_8524 
" + _9868 + @" = 2 

:WARROBE_2792
if 
  " + _9868 + @" == 1 
jf @WARROBE_2898 
if 
80E1:   not player 0 pressed_key 15 
jf @WARROBE_2898 
" + _9868 + @" = 0 
" + _9812 + @" = 5 
if 
  " + _9965 + @" == 1 
jf @WARROBE_2873 
03E6: remove_text_box 
08DA: remove_panel " + _9966 + @" 
" + _9965 + @" = 0 

:WARROBE_2873
if 
  " + _9870 + @" == 0 
jf @WARROBE_2898 
gosub @WARROBE_9292 

:WARROBE_2898
if 
  " + _9868 + @" == 2 
jf @WARROBE_3004 
if 
80E1:   not player 0 pressed_key 16 
jf @WARROBE_3004 
if 
  " + _9965 + @" == 1 
jf @WARROBE_2965 
03E6: remove_text_box 
08DA: remove_panel " + _9966 + @" 
" + _9965 + @" = 0 

:WARROBE_2965
if 
  " + _9970 + @" == 0 
jf @WARROBE_2990 
gosub @WARROBE_8835 

:WARROBE_2990
" + _9868 + @" = 0 
" + _9812 + @" = 7 

:WARROBE_3004
if 
  " + _9812 + @" == 7 
jf @WARROBE_3711 
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_3154 
if 
  " + _9973 + @" == 0 
jf @WARROBE_3147 
gosub @WARROBE_11522 
if 
  " + _9896 + @" == 0 
jf @WARROBE_3147 
if 
  " + _9973 + @" == 1 
jf @WARROBE_3126 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_3126
" + _9868 + @" = 0 
" + _9812 + @" = 5 
jump @WARROBE_584 

:WARROBE_3147
jump @WARROBE_3254 

:WARROBE_3154
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'UNIFORM' 
jf @WARROBE_3222 
if 
  " + _9970 + @" == 0 
jf @WARROBE_3215 
gosub @WARROBE_10908 
gosub @WARROBE_8835 

:WARROBE_3215
jump @WARROBE_3254 

:WARROBE_3222
if 
  " + _9970 + @" == 0 
jf @WARROBE_3254 
gosub @WARROBE_8524 
gosub @WARROBE_8835 

:WARROBE_3254
if 
  " + _9868 + @" == 0 
jf @WARROBE_3353 
if 
00E1:   player 0 pressed_key 15 
jf @WARROBE_3296 
" + _9868 + @" = 1 

:WARROBE_3296
if 
00E1:   player 0 pressed_key 16 
jf @WARROBE_3353 
08D7: " + _9971 + @" = panel " + _9969 + @" active_row 
if 
  0 > " + _9971 + @" 
jf @WARROBE_3346 
" + _9971 + @" = 0 

:WARROBE_3346
" + _9868 + @" = 2 

:WARROBE_3353
if 
  " + _9868 + @" == 1 
jf @WARROBE_3591 
if 
80E1:   not player 0 pressed_key 15 
jf @WARROBE_3591 
if 
  " + _9970 + @" == 1 
jf @WARROBE_3420 
08DA: remove_panel " + _9969 + @" 
03E6: remove_text_box 
" + _9970 + @" = 0 

:WARROBE_3420
if 
  " + _9973 + @" == 1 
jf @WARROBE_3452 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_3452
if or
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'UNIFORM' 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_3545 
if 
  " + _9870 + @" == 0 
jf @WARROBE_3524 
gosub @WARROBE_9292 

:WARROBE_3524
" + _9812 + @" = 5 
" + _9868 + @" = 0 
jump @WARROBE_3591 

:WARROBE_3545
if 
  " + _9965 + @" == 0 
jf @WARROBE_3577 
gosub @WARROBE_7198 
gosub @WARROBE_8122 

:WARROBE_3577
" + _9868 + @" = 0 
" + _9812 + @" = 6 

:WARROBE_3591
if 
  " + _9868 + @" == 2 
jf @WARROBE_3711 
if 
80E1:   not player 0 pressed_key 16 
jf @WARROBE_3711 
if 
  " + _9970 + @" == 1 
jf @WARROBE_3658 
08DA: remove_panel " + _9969 + @" 
03E6: remove_text_box 
" + _9970 + @" = 0 

:WARROBE_3658
if 
  " + _9973 + @" == 1 
jf @WARROBE_3690 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_3690
" + _9976 + @" = 0 
" + _9868 + @" = 0 
" + _9812 + @" = 8 

:WARROBE_3711
if 
  " + _9812 + @" == 8 
jf @WARROBE_4589 
if 
  " + _9868 + @" == 0 
jf @WARROBE_4203 
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_3835 
" + Selected_Menu_Item + @" = 0 
" + ShoppingItem_ModelCRC + @" = 0 
0084: " + ShoppingItem_BodyPart + @" = " + tmp_2486 + @"(" + _9971 + @",12i) 
05A9: " + _9806 + @" = " + tmp_9897 + @"(" + _9971 + @",12s) 
08F7: get_player " + PlayerChar + @" bodypart " + ShoppingItem_BodyPart + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
jump @WARROBE_3879 

:WARROBE_3835
0084: " + Selected_Menu_Item + @" = " + tmp_2438 + @"(" + _9971 + @",12i) 
0084: " + ShoppingItem_ModelCRC + @" = " + tmp_2474 + @"(" + _9971 + @",12i) 
0084: " + ShoppingItem_BodyPart + @" = " + _2547 + @" 
05A9: " + _9806 + @" = " + tmp_9897 + @"(" + _9971 + @",12s) 

:WARROBE_3879
if or
04A3:   " + ShoppingItem_BodyPart + @" == 13 
04A3:   " + ShoppingItem_BodyPart + @" == 14 
04A3:   " + ShoppingItem_BodyPart + @" == 15 
04A3:   " + ShoppingItem_BodyPart + @" == 16 
jf @WARROBE_3964 
Camera.SetPosition(" + _9889 + @", " + _9890 + @", " + _9891 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9892 + @", " + _9893 + @", " + _9894 + @", 2)
jump @WARROBE_4026 

:WARROBE_3964
Camera.SetPosition(" + _9883 + @", " + _9884 + @", " + _9885 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9886 + @", " + _9887 + @", " + _9888 + @", 2)
if 
803A:   not  " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @WARROBE_4026 
03D1: play_wav 4 

:WARROBE_4026
if or
04A3:   " + ShoppingItem_BodyPart + @" == 0 
04A3:   " + ShoppingItem_BodyPart + @" == 2 
04A3:   " + ShoppingItem_BodyPart + @" == 3 
jf @WARROBE_4071 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
0793: save_player_clothes 

:WARROBE_4071
0784: set_player " + PlayerChar + @" textureCRC " + Selected_Menu_Item + @" modelCRC " + ShoppingItem_ModelCRC + @" bodypart " + ShoppingItem_BodyPart + @" 
Player.Build(" + PlayerChar + @")
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_IN"" IFP ""CLOTHES"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9813 + @" = 0.0 
if 
03CA:   object " + _9811 + @" exists 
jf @WARROBE_4196 
075A: set_object " + _9811 + @" animation ""CLO_POSE_IN_O"" IFP_file ""CLOTHES"" 1000.0 lockF 0 loop 1 

:WARROBE_4196
" + _9868 + @" = 1 

:WARROBE_4203
if 
  " + _9868 + @" == 1 
jf @WARROBE_4445 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_POSE_IN""
jf @WARROBE_4271 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation ""CLO_POSE_IN"" time 

:WARROBE_4271
if 
  " + _9813 + @" == 1.0 
jf @WARROBE_4445 
if 
85AD:   not  " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_4377 
0812: AS_actor " + PlayerActor + @" perform_animation " + _9864 + @" IFP ""CLOTHES"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9813 + @" = 0.0 
" + _9868 + @" = 2 
jump @WARROBE_4445 

:WARROBE_4377
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_LOOP"" IFP ""CLOTHES"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9813 + @" = 0.0 
" + _9812 + @" = 9 
" + _9868 + @" = 0 

:WARROBE_4445
if 
  " + _9868 + @" == 2 
jf @WARROBE_4589 
if 
   Actor.Animation(" + PlayerActor + @") == " + _9864 + @"
jf @WARROBE_4493 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation " + _9864 + @" time 

:WARROBE_4493
if 
  " + _9813 + @" == 1.0 
jf @WARROBE_4589 
gosub @WARROBE_10424 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_LOOP"" IFP ""CLOTHES"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9813 + @" = 0.0 
" + _9812 + @" = 9 
" + _9868 + @" = 0 

:WARROBE_4589
if 
  " + _9812 + @" == 9 
jf @WARROBE_6277 
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9868 + @" == 0 
jf @WARROBE_4867 
if 
00E1:   player 0 pressed_key 16 
jf @WARROBE_4699 
03D5: remove_text 'WARDNO'  
03D5: remove_text 'WARDNO2'  
" + _2545 + @" = 0 
" + _2546 + @" = 0 
" + _9978 + @" = 0 
" + _9868 + @" = 1 

:WARROBE_4699
if 
00E1:   player 0 pressed_key 15 
jf @WARROBE_4867 
03D5: remove_text 'WARDNO'  
03D5: remove_text 'WARDNO2'  
" + _2545 + @" = 0 
" + _2546 + @" = 0 
" + _9978 + @" = 0 
if 
  " + _2418 + @" == 1 
jf @WARROBE_4791 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:WARROBE_4791
if 
  " + _9976 + @" == 0 
jf @WARROBE_4823 
" + _9868 + @" = 3 
jump @WARROBE_4867 

:WARROBE_4823
if 
  " + _2422 + @" == 1 
jf @WARROBE_4853 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:WARROBE_4853
" + _9868 + @" = 0 
" + _9812 + @" = 7 

:WARROBE_4867
if 
  2 > " + _9868 + @" 
jf @WARROBE_4892 
gosub @WARROBE_10424 

:WARROBE_4892
if 
  " + _9868 + @" == 1 
jf @WARROBE_5427 
if 
80E1:   not player 0 pressed_key 16 
jf @WARROBE_5427 
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_5186 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_5117 
if 
  " + _2418 + @" == 1 
jf @WARROBE_5006 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:WARROBE_5006
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
gosub @WARROBE_10692 
" + _9978 + @" = 1 
0793: save_player_clothes 
Player.Build(" + PlayerChar + @")
08F7: get_player " + PlayerChar + @" bodypart " + ShoppingItem_BodyPart + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_BUY"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9813 + @" = 0.0 
" + _9868 + @" = 2 
jump @WARROBE_5179 

:WARROBE_5117
if 
  " + _2545 + @" == 0 
jf @WARROBE_5179 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
00BC: show_text_highpriority GXT 'WARDNO2' time 5000 flag 1  
" + _9868 + @" = 0 
" + _2545 + @" = 1 

:WARROBE_5179
jump @WARROBE_5427 

:WARROBE_5186
if 
803A:   not  " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @WARROBE_5365 
if 
  " + _2418 + @" == 1 
jf @WARROBE_5237 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:WARROBE_5237
08C8: set_shopping_item_with_textureCRC " + Selected_Menu_Item + @" price_to 0 
0790: charge_money_for_shopping_item_with_textureCRC " + Selected_Menu_Item + @" 
" + _9978 + @" = 1 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
08C9: reset_shopping_item " + Selected_Menu_Item + @" price 
gosub @WARROBE_10692 
0793: save_player_clothes 
Player.Build(" + PlayerChar + @")
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_BUY"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9813 + @" = 0.0 
" + _9868 + @" = 2 
jump @WARROBE_5427 

:WARROBE_5365
if 
  " + _2545 + @" == 0 
jf @WARROBE_5427 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
00BC: show_text_highpriority GXT 'WARDNO' time 5000 flag 1  
" + _9868 + @" = 0 
" + _2545 + @" = 1 

:WARROBE_5427
if 
  " + _9868 + @" == 2 
jf @WARROBE_5569 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_BUY""
jf @WARROBE_5487 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation ""CLO_BUY"" time 

:WARROBE_5487
if 
  " + _9813 + @" == 1.0 
jf @WARROBE_5569 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_LOOP"" IFP ""CLOTHES"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9813 + @" = 0.0 
" + _9868 + @" = 3 

:WARROBE_5569
if 
  " + _9868 + @" == 3 
jf @WARROBE_5702 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_OUT"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9813 + @" = 0.0 
if 
03CA:   object " + _9811 + @" exists 
jf @WARROBE_5695 
075A: set_object " + _9811 + @" animation ""CLO_POSE_OUT_O"" IFP_file ""CLOTHES"" 1000.0 lockF 0 loop 1 

:WARROBE_5695
" + _9868 + @" = 4 

:WARROBE_5702
if 
  " + _9868 + @" == 4 
jf @WARROBE_6277 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_POSE_OUT""
jf @WARROBE_5772 
0613: " + _9813 + @" = actor " + PlayerActor + @" animation ""CLO_POSE_OUT"" time 

:WARROBE_5772
if 
  " + _9813 + @" == 1.0 
jf @WARROBE_6277 
0794: restore_player_clothes 
Player.Build(" + PlayerChar + @")
0793: save_player_clothes 
if 
  " + _2418 + @" == 1 
jf @WARROBE_5834 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:WARROBE_5834
if 
  " + _2422 + @" == 1 
jf @WARROBE_5864 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:WARROBE_5864
" + _9976 + @" = 1 
if 
  " + _9978 + @" == 1 
jf @WARROBE_5953 
" + _9868 + @" = 0 
" + _9812 + @" = 5 
if 
  " + _9870 + @" == 0 
jf @WARROBE_5946 
if 
  1 > " + _9868 + @" 
jf @WARROBE_5946 
gosub @WARROBE_9292 

:WARROBE_5946
jump @WARROBE_6277 

:WARROBE_5953
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_6149 
if 
  " + _9973 + @" == 0 
jf @WARROBE_6142 
gosub @WARROBE_11522 
if 
  " + _9896 + @" == 0 
jf @WARROBE_6128 
if 
  " + _9973 + @" == 1 
jf @WARROBE_6057 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_6057
" + _9868 + @" = 0 
" + _9812 + @" = 5 
if 
  " + _9870 + @" == 0 
jf @WARROBE_6114 
if 
  1 > " + _9868 + @" 
jf @WARROBE_6114 
gosub @WARROBE_9292 

:WARROBE_6114
jump @WARROBE_584 
jump @WARROBE_6142 

:WARROBE_6128
" + _9868 + @" = 0 
" + _9812 + @" = 7 

:WARROBE_6142
jump @WARROBE_6277 

:WARROBE_6149
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'UNIFORM' 
jf @WARROBE_6231 
if 
  " + _9970 + @" == 0 
jf @WARROBE_6210 
gosub @WARROBE_10908 
gosub @WARROBE_8835 

:WARROBE_6210
" + _9868 + @" = 0 
" + _9812 + @" = 7 
jump @WARROBE_6277 

:WARROBE_6231
if 
  " + _9970 + @" == 0 
jf @WARROBE_6263 
gosub @WARROBE_8524 
gosub @WARROBE_8835 

:WARROBE_6263
" + _9868 + @" = 0 
" + _9812 + @" = 7 

:WARROBE_6277
if 
  " + _9812 + @" == 11 
jf @WARROBE_6429 
if 
80FF:   not actor " + PlayerActor + @" sphere " + Show_Shop_Sphere + @" in_sphere " + _9879 + @" " + _9880 + @" " + _9881 + @" radius 1.0 1.0 4.0 on_foot 
jf @WARROBE_6429 
" + _9870 + @" = 0 
" + _9965 + @" = 0 
" + _9970 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _9973 + @" = 0 
" + _9872 + @" = 0 
" + _2517 + @" = 0 
" + _9978 + @" = 0 
" + _9812 + @" = 2 
" + _9868 + @" = 0 
" + _2545 + @" = 0 
" + Show_Shop_Sphere + @" = 1 

:WARROBE_6429
jump @WARROBE_6443 

:WARROBE_6436
gosub @WARROBE_6798 

:WARROBE_6443
jump @WARROBE_6457 

:WARROBE_6450
gosub @WARROBE_6798 

:WARROBE_6457
jump @WARROBE_584 
if 
  " + _9812 + @" >= 1 
jf @WARROBE_6484 
03E6: remove_text_box 

:WARROBE_6484
if 
  " + _9870 + @" == 1 
jf @WARROBE_6516 
08DA: remove_panel " + _9871 + @" 
03E6: remove_text_box 
" + _9870 + @" = 0 

:WARROBE_6516
if 
  " + _9965 + @" == 1 
jf @WARROBE_6548 
08DA: remove_panel " + _9966 + @" 
03E6: remove_text_box 
" + _9965 + @" = 0 

:WARROBE_6548
if 
  " + _9970 + @" == 1 
jf @WARROBE_6580 
08DA: remove_panel " + _9969 + @" 
03E6: remove_text_box 
" + _9970 + @" = 0 

:WARROBE_6580
if 
  " + _9973 + @" == 1 
jf @WARROBE_6612 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_6612
if 
  " + _2418 + @" == 1 
jf @WARROBE_6644 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:WARROBE_6644
if 
  " + _2422 + @" == 1 
jf @WARROBE_6676 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:WARROBE_6676
03D5: remove_text 'WARDNO'  
03D5: remove_text 'WARDNO2'  
" + _9870 + @" = 0 
" + _9965 + @" = 0 
" + _9970 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _9973 + @" = 0 
" + _9872 + @" = 0 
" + _2517 + @" = 0 
" + _2545 + @" = 0 
" + _2546 + @" = 0 
" + _9978 + @" = 0 
" + _9868 + @" = 0 
" + _9976 + @" = 0 
" + _9812 + @" = 2 
return 

:WARROBE_6798
if 
  " + _9870 + @" == 1 
jf @WARROBE_6830 
08DA: remove_panel " + _9871 + @" 
03E6: remove_text_box 
" + _9870 + @" = 0 

:WARROBE_6830
if 
  " + _9965 + @" == 1 
jf @WARROBE_6862 
08DA: remove_panel " + _9966 + @" 
03E6: remove_text_box 
" + _9965 + @" = 0 

:WARROBE_6862
if 
  " + _9970 + @" == 1 
jf @WARROBE_6894 
08DA: remove_panel " + _9969 + @" 
03E6: remove_text_box 
" + _9970 + @" = 0 

:WARROBE_6894
if 
  " + _9973 + @" == 1 
jf @WARROBE_6926 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_6926
if 
  " + _2418 + @" == 1 
jf @WARROBE_6958 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:WARROBE_6958
if 
  " + _2422 + @" == 1 
jf @WARROBE_6990 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:WARROBE_6990
if 
  " + _9812 + @" >= 1 
jf @WARROBE_7010 
03E6: remove_text_box 

:WARROBE_7010
03D5: remove_text 'WARDNO'  
03D5: remove_text 'WARDNO2'  
" + _9870 + @" = 0 
" + _9965 + @" = 0 
" + _9970 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _9973 + @" = 0 
" + _9872 + @" = 0 
" + _2517 + @" = 0 
" + _9978 + @" = 0 
" + Show_Shop_Sphere + @" = 1 
" + _9810 + @" = 0 
" + _2545 + @" = 0 
" + _2546 + @" = 0 
" + _9868 + @" = 0 
" + _9812 + @" = 0 
" + _9976 + @" = 0 
Object.Destroy(" + _9811 + @")
Model.Destroy(" + _9869 + @")
04EF: release_animation ""CLOTHES"" 
087C: release_shopping_data 
03F0: enable_text_draw 0 
0581: enable_radar 1 
08F8: display_stat_update_box 1 
09BD: allow_other_threads_to_display_text_boxes 0 
" + _9977 + @" = 0 
040D: unload_wav 4 
end_thread 
return 

:WARROBE_7198
" + _9945 + @" = 0 
" + _9946 + @" = 0 
" + _9947 + @" = 0 
" + _9948 + @" = 0 
" + _9949 + @" = 0 
" + _9950 + @" = 0 
" + _9951 + @" = 0 
075E: load_shopping_data_PRICES_subsection " + tmp_9921 + @"(" + _9872 + @",12s) 
075D: load_shopping_data_SHOPS_subsection ""CLOTHES"" 
075F: store_shopping_data_entries_number_to " + _9873 + @" 
" + _2515 + @" = 0 
" + _9896 + @" = 0 

:WARROBE_7286
if 
001C:   " + _9873 + @" > " + _2515 + @" 
jf @WARROBE_8062 
0760: store_shopping_data_index " + _2515 + @" textureCRC_to " + Selected_Menu_Item + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 1 store_to " + ShoppingItem_BodyPart + @" 
if 
0942:   item_with_textureCRC " + Selected_Menu_Item + @" is_clothing 
jf @WARROBE_8048 
0871: init_jump_table " + ShoppingItem_BodyPart + @" total_jumps 7 default_jump 0 @WARROBE_8048 jumps 0 @WARROBE_7402 2 @WARROBE_7495 3 @WARROBE_7587 13 @WARROBE_7680 14 @WARROBE_7773 15 @WARROBE_7866 16 @WARROBE_7957 

:WARROBE_7402
if 
  " + _9945 + @" == 0 
jf @WARROBE_7488 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'TORSO' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 0 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_TORSO"" 
" + _9896 + @" += 1 
" + _9945 + @" = 1 

:WARROBE_7488
jump @WARROBE_8048 

:WARROBE_7495
if 
  " + _9946 + @" == 0 
jf @WARROBE_7580 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'LEGS' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 2 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_LEGS"" 
" + _9896 + @" += 1 
" + _9946 + @" = 1 

:WARROBE_7580
jump @WARROBE_8048 

:WARROBE_7587
if 
  " + _9947 + @" == 0 
jf @WARROBE_7673 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'FEET' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 3 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_SHOES"" 
" + _9896 + @" += 1 
" + _9947 + @" = 1 

:WARROBE_7673
jump @WARROBE_8048 

:WARROBE_7680
if 
  " + _9948 + @" == 0 
jf @WARROBE_7766 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'CHAINS' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 13 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_TORSO"" 
" + _9896 + @" += 1 
" + _9948 + @" = 1 

:WARROBE_7766
jump @WARROBE_8048 

:WARROBE_7773
if 
  " + _9949 + @" == 0 
jf @WARROBE_7859 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'WATCHES' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 14 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_WATCH"" 
" + _9896 + @" += 1 
" + _9949 + @" = 1 

:WARROBE_7859
jump @WARROBE_8048 

:WARROBE_7866
if 
  " + _9950 + @" == 0 
jf @WARROBE_7950 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHADES' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 15 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_HAT"" 
" + _9896 + @" += 1 
" + _9950 + @" = 1 

:WARROBE_7950
jump @WARROBE_8048 

:WARROBE_7957
if 
  " + _9951 + @" == 0 
jf @WARROBE_8041 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'HATS' 
04AE: " + tmp_9953 + @"(" + _9896 + @",12i) = 16 
06D1: " + tmp_9816 + @"(" + _9896 + @",12v) = ""CLO_POSE_HAT"" 
" + _9896 + @" += 1 
" + _9951 + @" = 1 

:WARROBE_8041
jump @WARROBE_8048 

:WARROBE_8048
" + _2515 + @" += 1 
jump @WARROBE_7286 

:WARROBE_8062
0084: " + _2515 + @" = " + _9896 + @" 

:WARROBE_8070
if 
  12 > " + _2515 + @" 
jf @WARROBE_8120 
05A9: " + tmp_9897 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @WARROBE_8070 

:WARROBE_8120
return 

:WARROBE_8122
if 
  " + _9965 + @" == 0 
jf @WARROBE_8522 
0512: show_permanent_text_box 'WARDH2'  
if 
04A3:   " + Current_Language + @" == 0 
jf @WARROBE_8213 
08D4: " + _9966 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_8454 

:WARROBE_8213
if 
04A3:   " + Current_Language + @" == 1 
jf @WARROBE_8275 
08D4: " + _9966 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_8454 

:WARROBE_8275
if 
04A3:   " + Current_Language + @" == 2 
jf @WARROBE_8337 
08D4: " + _9966 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_8454 

:WARROBE_8337
if 
04A3:   " + Current_Language + @" == 3 
jf @WARROBE_8399 
08D4: " + _9966 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_8454 

:WARROBE_8399
if 
04A3:   " + Current_Language + @" == 4 
jf @WARROBE_8454 
08D4: " + _9966 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:WARROBE_8454
08D6: set_panel " + _9966 + @" column 0 alignment 1 
08DB: set_panel " + _9966 + @" column 0 header 'DUMMY' data s" + tmp_9897 + @"[0] s" + tmp_9897 + @"[1] s" + tmp_9897 + @"[2] s" + tmp_9897 + @"[3] s" + tmp_9897 + @"[4] s" + tmp_9897 + @"[5] s" + tmp_9897 + @"[6] s" + tmp_9897 + @"[7] s" + tmp_9897 + @"[8] s" + tmp_9897 + @"[9] s" + tmp_9897 + @"[10] s" + tmp_9897 + @"[11] 
" + _9965 + @" = 1 

:WARROBE_8522
return 

:WARROBE_8524
" + _2515 + @" = 0 
" + _9896 + @" = 0 
" + _9968 + @" = 0 
08F7: get_player " + PlayerChar + @" bodypart " + tmp_9953 + @"(" + _9967 + @",12i) textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
075F: store_shopping_data_entries_number_to " + _9873 + @" 

:WARROBE_8568
if 
001C:   " + _9873 + @" > " + _2515 + @" 
jf @WARROBE_8775 
0760: store_shopping_data_index " + _2515 + @" textureCRC_to " + Selected_Menu_Item + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 0 store_to " + ShoppingItem_ModelCRC + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 1 store_to " + ShoppingItem_BodyPart + @" 
if 
0942:   item_with_textureCRC " + Selected_Menu_Item + @" is_clothing 
jf @WARROBE_8761 
if 
003A:   " + ShoppingItem_BodyPart + @" == " + tmp_9953 + @"(" + _9967 + @",12i) 
jf @WARROBE_8761 
0084: " + tmp_2438 + @"(" + _9968 + @",12i) = " + Selected_Menu_Item + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _9806 + @" 
05A9: " + tmp_9897 + @"(" + _9968 + @",12s) = " + _9806 + @" 
0084: " + tmp_2474 + @"(" + _9968 + @",12i) = " + ShoppingItem_ModelCRC + @" 
0084: " + _2547 + @" = " + ShoppingItem_BodyPart + @" 
if 
003A:   " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @WARROBE_8743 
" + tmp_2498 + @"(" + _9968 + @",12i) = 0 
jump @WARROBE_8754 

:WARROBE_8743
" + tmp_2498 + @"(" + _9968 + @",12i) = 1 

:WARROBE_8754
" + _9968 + @" += 1 

:WARROBE_8761
" + _2515 + @" += 1 
jump @WARROBE_8568 

:WARROBE_8775
0084: " + _2515 + @" = " + _9968 + @" 

:WARROBE_8783
if 
  12 > " + _2515 + @" 
jf @WARROBE_8833 
05A9: " + tmp_9897 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @WARROBE_8783 

:WARROBE_8833
return 

:WARROBE_8835
if 
  " + _9970 + @" == 0 
jf @WARROBE_9290 
0512: show_permanent_text_box 'WARDH3'  
if 
04A3:   " + Current_Language + @" == 0 
jf @WARROBE_8926 
08D4: " + _9969 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9167 

:WARROBE_8926
if 
04A3:   " + Current_Language + @" == 1 
jf @WARROBE_8988 
08D4: " + _9969 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9167 

:WARROBE_8988
if 
04A3:   " + Current_Language + @" == 2 
jf @WARROBE_9050 
08D4: " + _9969 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9167 

:WARROBE_9050
if 
04A3:   " + Current_Language + @" == 3 
jf @WARROBE_9112 
08D4: " + _9969 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9167 

:WARROBE_9112
if 
04A3:   " + Current_Language + @" == 4 
jf @WARROBE_9167 
08D4: " + _9969 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:WARROBE_9167
08D6: set_panel " + _9969 + @" column 0 alignment 1 
08DB: set_panel " + _9969 + @" column 0 header 'DUMMY' data s" + tmp_9897 + @"[0] s" + tmp_9897 + @"[1] s" + tmp_9897 + @"[2] s" + tmp_9897 + @"[3] s" + tmp_9897 + @"[4] s" + tmp_9897 + @"[5] s" + tmp_9897 + @"[6] s" + tmp_9897 + @"[7] s" + tmp_9897 + @"[8] s" + tmp_9897 + @"[9] s" + tmp_9897 + @"[10] s" + tmp_9897 + @"[11] 
" + _2515 + @" = 0 

:WARROBE_9235
if 
001C:   " + _9968 + @" > " + _2515 + @" 
jf @WARROBE_9283 
08D9: set_panel " + _9969 + @" row " + _2515 + @" enable " + tmp_2498 + @"(" + _2515 + @",12i) 
" + _2515 + @" += 1 
jump @WARROBE_9235 

:WARROBE_9283
" + _9970 + @" = 1 

:WARROBE_9290
return 

:WARROBE_9292
if 
  " + _9870 + @" == 0 
jf @WARROBE_10422 
gosub @WARROBE_11522 
if 
  " + _9973 + @" == 1 
jf @WARROBE_9349 
08DA: remove_panel " + _9974 + @" 
03E6: remove_text_box 
" + _9973 + @" = 0 

:WARROBE_9349
if 
  " + _9896 + @" == 0 
jf @WARROBE_9381 
" + _9975 + @" = 0 
jump @WARROBE_9388 

:WARROBE_9381
" + _9975 + @" = 1 

:WARROBE_9388
" + _9896 + @" = 0 
if 
04A3:   " + Current_Language + @" == 0 
jf @WARROBE_9457 
08D4: " + _9871 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9698 

:WARROBE_9457
if 
04A3:   " + Current_Language + @" == 1 
jf @WARROBE_9519 
08D4: " + _9871 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9698 

:WARROBE_9519
if 
04A3:   " + Current_Language + @" == 2 
jf @WARROBE_9581 
08D4: " + _9871 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9698 

:WARROBE_9581
if 
04A3:   " + Current_Language + @" == 3 
jf @WARROBE_9643 
08D4: " + _9871 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_9698 

:WARROBE_9643
if 
04A3:   " + Current_Language + @" == 4 
jf @WARROBE_9698 
08D4: " + _9871 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:WARROBE_9698
08D6: set_panel " + _9871 + @" column 0 alignment 1 
if 
  " + _2549 + @" == 1 
jf @WARROBE_9768 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP1' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'CSCHP' 
" + _9896 + @" += 1 

:WARROBE_9768
if 
  " + _2550 + @" == 1 
jf @WARROBE_9829 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP2' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'CSSPRT' 
" + _9896 + @" += 1 

:WARROBE_9829
if 
  " + _2551 + @" == 1 
jf @WARROBE_9890 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP3' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'LACS1' 
" + _9896 + @" += 1 

:WARROBE_9890
if 
  " + _2552 + @" == 1 
jf @WARROBE_9951 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP4' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'CLOTHGP' 
" + _9896 + @" += 1 

:WARROBE_9951
if 
  " + _2553 + @" == 1 
jf @WARROBE_10012 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP5' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'CSDESGN' 
" + _9896 + @" += 1 

:WARROBE_10012
if 
  " + _2554 + @" == 1 
jf @WARROBE_10073 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP6' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'CSEXL' 
" + _9896 + @" += 1 

:WARROBE_10073
" + _9972 + @" = 0 
if or
  " + Gimp_Suit_Available + @" == 1 
  " + Valet_Uniform_Available + @" == 1 
  " + Croupier_Uniform_Available + @" == 1 
  " + Racing_Suit_Available + @" == 1 
  " + Cop_Uniform_Available + @" == 1 
  " + Rural_Clothes_Available + @" == 1 
jf @WARROBE_10140 
" + _9972 + @" = 1 

:WARROBE_10140
if or
  " + Medic_Uniform_Available + @" == 1 
  " + Pimp_Suit_Available + @" == 1 
jf @WARROBE_10172 
" + _9972 + @" = 1 

:WARROBE_10172
if 
  " + _9972 + @" == 1 
jf @WARROBE_10233 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP7' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'UNIFORM' 
" + _9896 + @" += 1 

:WARROBE_10233
if 
  " + _9975 + @" == 1 
jf @WARROBE_10294 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'REMCLT' 
05A9: " + tmp_9921 + @"(" + _9896 + @",12s) = 'REMOVE' 
" + _9896 + @" += 1 

:WARROBE_10294
0084: " + _2515 + @" = " + _9896 + @" 

:WARROBE_10302
if 
  12 > " + _2515 + @" 
jf @WARROBE_10352 
05A9: " + tmp_9897 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @WARROBE_10302 

:WARROBE_10352
0512: show_permanent_text_box 'WARDH1'  
08DB: set_panel " + _9871 + @" column 0 header 'DUMMY' data s" + tmp_9897 + @"[0] s" + tmp_9897 + @"[1] s" + tmp_9897 + @"[2] s" + tmp_9897 + @"[3] s" + tmp_9897 + @"[4] s" + tmp_9897 + @"[5] s" + tmp_9897 + @"[6] s" + tmp_9897 + @"[7] s" + tmp_9897 + @"[8] s" + tmp_9897 + @"[9] s" + tmp_9897 + @"[10] s" + tmp_9897 + @"[11] 
" + _9870 + @" = 1 

:WARROBE_10422
return 

:WARROBE_10424
if 
  " + _2418 + @" == 0 
jf @WARROBE_10690 
if 
05AD:   " + tmp_9921 + @"(" + _9872 + @",12s) == 'REMOVE' 
jf @WARROBE_10489 
0512: show_permanent_text_box 'REMOH2'  
jump @WARROBE_10500 

:WARROBE_10489
0512: show_permanent_text_box 'WARDH4'  

:WARROBE_10500
08D4: " + _2417 + @" = create_panel_with_title 'CLOTCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2417 + @" column 0 alignment 1 
08DB: set_panel " + _2417 + @" column 0 header 'DUMMY' data " + _9806 + @" 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 
09DB: set_panel " + _2417 + @" column 0 width 140 
09DB: set_panel " + _2417 + @" column 1 width 46 
" + _2418 + @" = 1 

:WARROBE_10690
return 

:WARROBE_10692
if 
  " + _2422 + @" == 0 
jf @WARROBE_10906 
08D4: " + _2421 + @" = create_panel_with_title 'CLOTCHO' position 29.0 25.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2421 + @" column 0 alignment 1 
08DB: set_panel " + _2421 + @" column 0 header 'DUMMY' data 'CHANGED' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
09DB: set_panel " + _2421 + @" column 0 width 140 
09DB: set_panel " + _2421 + @" column 1 width 46 
" + _2422 + @" = 1 

:WARROBE_10906
return 

:WARROBE_10908
075E: load_shopping_data_PRICES_subsection ""UNIFORM"" 
075D: load_shopping_data_SHOPS_subsection ""CLOTHES"" 
075F: store_shopping_data_entries_number_to " + _9873 + @" 
" + _2515 + @" = 0 
" + _9896 + @" = 0 
" + _9968 + @" = 0 

:WARROBE_10956
if 
001C:   " + _9873 + @" > " + _2515 + @" 
jf @WARROBE_11462 
0760: store_shopping_data_index " + _2515 + @" textureCRC_to " + Selected_Menu_Item + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 0 store_to " + ShoppingItem_ModelCRC + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 1 store_to " + ShoppingItem_BodyPart + @" 
0084: " + tmp_2438 + @"(" + _9968 + @",12i) = " + Selected_Menu_Item + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _9806 + @" 
05A9: " + tmp_9897 + @"(" + _9968 + @",12s) = " + _9806 + @" 
0084: " + tmp_2474 + @"(" + _9968 + @",12i) = " + ShoppingItem_ModelCRC + @" 
04AE: " + _2547 + @" = 17 
08F7: get_player " + PlayerChar + @" bodypart 17 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
003A:   " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @WARROBE_11104 
" + tmp_2498 + @"(" + _9968 + @",12i) = 0 
jump @WARROBE_11115 

:WARROBE_11104
" + tmp_2498 + @"(" + _9968 + @",12i) = 1 

:WARROBE_11115
if and
  " + Gimp_Suit_Available + @" == 1 
05AD:   " + _9806 + @" == 'GIMP' 
jf @WARROBE_11154 
" + _9968 + @" += 1 

:WARROBE_11154
if and
  " + Valet_Uniform_Available + @" == 1 
05AD:   " + _9806 + @" == 'VALETU' 
jf @WARROBE_11193 
" + _9968 + @" += 1 

:WARROBE_11193
if and
  " + Rural_Clothes_Available + @" == 1 
05AD:   " + _9806 + @" == 'COUNTRY' 
jf @WARROBE_11232 
" + _9968 + @" += 1 

:WARROBE_11232
if and
  " + Croupier_Uniform_Available + @" == 1 
05AD:   " + _9806 + @" == 'CROUP' 
jf @WARROBE_11271 
" + _9968 + @" += 1 

:WARROBE_11271
if and
  " + Cop_Uniform_Available + @" == 1 
05AD:   " + _9806 + @" == 'POLICE' 
jf @WARROBE_11310 
" + _9968 + @" += 1 

:WARROBE_11310
if and
  " + Medic_Uniform_Available + @" == 1 
05AD:   " + _9806 + @" == 'PAMEDIC' 
jf @WARROBE_11349 
" + _9968 + @" += 1 

:WARROBE_11349
if and
  " + Pimp_Suit_Available + @" == 1 
05AD:   " + _9806 + @" == 'PIMPSUT' 
jf @WARROBE_11388 
" + _9968 + @" += 1 

:WARROBE_11388
if and
  " + Racing_Suit_Available + @" == 1 
05AD:   " + _9806 + @" == 'RDRIVER' 
jf @WARROBE_11427 
" + _9968 + @" += 1 

:WARROBE_11427
06D1: " + _9864 + @" = ""CLO_POSE_TORSO"" 
" + _2515 + @" += 1 
jump @WARROBE_10956 

:WARROBE_11462
0084: " + _2515 + @" = " + _9968 + @" 

:WARROBE_11470
if 
  12 > " + _2515 + @" 
jf @WARROBE_11520 
05A9: " + tmp_9897 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @WARROBE_11470 

:WARROBE_11520
return 

:WARROBE_11522
" + _2515 + @" = 0 
" + _9896 + @" = 0 
if 
  " + _9973 + @" == 0 
jf @WARROBE_12530 
if 
04A3:   " + Current_Language + @" == 0 
jf @WARROBE_11616 
08D4: " + _9974 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_11857 

:WARROBE_11616
if 
04A3:   " + Current_Language + @" == 1 
jf @WARROBE_11678 
08D4: " + _9974 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_11857 

:WARROBE_11678
if 
04A3:   " + Current_Language + @" == 2 
jf @WARROBE_11740 
08D4: " + _9974 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_11857 

:WARROBE_11740
if 
04A3:   " + Current_Language + @" == 3 
jf @WARROBE_11802 
08D4: " + _9974 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @WARROBE_11857 

:WARROBE_11802
if 
04A3:   " + Current_Language + @" == 4 
jf @WARROBE_11857 
08D4: " + _9974 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:WARROBE_11857
08D6: set_panel " + _9974 + @" column 0 alignment 1 
08F7: get_player " + PlayerChar + @" bodypart 0 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_11933 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'TORSO' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 0 
" + _9896 + @" += 1 

:WARROBE_11933
08F7: get_player " + PlayerChar + @" bodypart 2 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12000 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'LEGS' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 2 
" + _9896 + @" += 1 

:WARROBE_12000
08F7: get_player " + PlayerChar + @" bodypart 3 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12067 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'FEET' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 3 
" + _9896 + @" += 1 

:WARROBE_12067
08F7: get_player " + PlayerChar + @" bodypart 13 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12134 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'CHAINS' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 13 
" + _9896 + @" += 1 

:WARROBE_12134
08F7: get_player " + PlayerChar + @" bodypart 14 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12201 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'WATCHES' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 14 
" + _9896 + @" += 1 

:WARROBE_12201
08F7: get_player " + PlayerChar + @" bodypart 15 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12268 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHADES' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 15 
" + _9896 + @" += 1 

:WARROBE_12268
08F7: get_player " + PlayerChar + @" bodypart 16 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12335 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'HATS' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 16 
" + _9896 + @" += 1 

:WARROBE_12335
08F7: get_player " + PlayerChar + @" bodypart 17 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
   not " + _2542 + @" == 0 
jf @WARROBE_12402 
05A9: " + tmp_9897 + @"(" + _9896 + @",12s) = 'SHOP7' 
04AE: " + tmp_2486 + @"(" + _9896 + @",12i) = 17 
" + _9896 + @" += 1 

:WARROBE_12402
0084: " + _2515 + @" = " + _9896 + @" 

:WARROBE_12410
if 
  12 > " + _2515 + @" 
jf @WARROBE_12460 
05A9: " + tmp_9897 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @WARROBE_12410 

:WARROBE_12460
0512: show_permanent_text_box 'REMOH1'  
08DB: set_panel " + _9974 + @" column 0 header 'DUMMY' data s" + tmp_9897 + @"[0] s" + tmp_9897 + @"[1] s" + tmp_9897 + @"[2] s" + tmp_9897 + @"[3] s" + tmp_9897 + @"[4] s" + tmp_9897 + @"[5] s" + tmp_9897 + @"[6] s" + tmp_9897 + @"[7] s" + tmp_9897 + @"[8] s" + tmp_9897 + @"[9] s" + tmp_9897 + @"[10] s" + tmp_9897 + @"[11] 
" + _9973 + @" = 1 

:WARROBE_12530
return 
end_thread" );
            }

        }

    }

}