using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class TATTO : External {

            Int tmp_2438 = global( _2438.startIndex ),
                tmp_2426 = global( _2426.startIndex ),
                tmp_2450 = global( _2450.startIndex ),
                tmp_2498 = global( _2498.startIndex ),
                tmp_9712 = global( _9712.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _9706 + @" = 0 
" + _9707 + @" = 0 
" + _2513 + @" = 0 
" + _2425 + @" = 0 
" + _2514 + @" = 0 
" + _2515 + @" = 0 
" + _9664 + @" = 0 
" + _9639 + @" = 0.0 
" + _9640 + @" = 0.0 
" + _9641 + @" = 0.0 
" + _9642 + @" = 0.0 
" + _9660 + @" = 0.0 
" + _9657 + @" = 0.0 
" + _9659 + @" = 0.0 
" + _9658 + @" = 0.0 
" + _9653 + @" = 0.0 
" + _9654 + @" = 0.0 
" + _9655 + @" = 0.0 
" + _9656 + @" = 0.0 
" + _9652 + @" = 0 
" + _9650 + @" = 0 
" + _9649 + @" = 0 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9705 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9708 + @" = 0 
" + _9709 + @" = 500 
" + _9711 + @" = 0 
" + _9721 + @" = 0 
" + _9722 + @" = 0 
" + _9724 + @" = 0 
" + _9725 + @" = 0 
" + _9639 + @" = 0.0 
" + _9640 + @" = 0.0 
" + _9641 + @" = 0.0 
" + _9661 + @" = 0.0 
" + _9662 + @" = 0.0 
" + _9663 + @" = 0.0 
" + _9726 + @" = 0.0  
" + _9727 + @" = 0.0 
" + _9728 + @" = 0.0 
" + TATOO_Selected_Torso_Part + @" = 0 
" + X_Buy_Marker + @" = 0.0 
" + Y_Buy_Marker + @" = 0.0 
" + Z_Buy_Marker + @" = 0.0 
" + X_Camera + @" = 0.0 
" + Y_Camera + @" = 0.0 
" + Z_Camera + @" = 0.0 
04AE: " + Seller_Model + @" = 180 
Model.Load(#TATTOO_KIT)
0390: load_txd_dictionary 'LD_TATT' 
Model.Load(" + Seller_Model + @")
03CF: load_wav 40000 as 4 
038B: load_requested_models 
set_wb_check_to 0 

:TATTO_515
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @TATTO_7605 
if 
8844:   not string " + Current_Shop_GXT_Name + @" empty 
jf @TATTO_7591 
if 
  " + _9652 + @" > 0 
jf @TATTO_637 
if 
0A0F:   new_language_set 
jf @TATTO_637 
03E6: remove_text_box 
08DA: remove_panel " + _2421 + @" 
08DA: remove_panel " + _2423 + @" 
08DA: remove_panel " + _2419 + @" 
08DA: remove_panel " + _9723 + @" 
" + _2420 + @" = 0 
" + _2422 + @" = 0 
" + _2424 + @" = 0 
" + _9722 + @" = 0 
09FB: " + Current_Language + @" = current_language 

:TATTO_637
if 
  " + _9652 + @" == 0 
jf @TATTO_940 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'TATTO2' 
jf @TATTO_750 
" + _9726 + @" = 0.0 
" + _9727 + @" = 0.0 
" + _9728 + @" = 0.0 
" + _9660 + @" = 125.0 
" + _9642 + @" = 155.0 
05A9: " + _9647 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9706 + @" 
" + _9652 + @" = 1 

:TATTO_750
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'TATTOO' 
jf @TATTO_845 
" + _9726 + @" = 0.0 
" + _9727 + @" = -18.266 
" + _9728 + @" = 0.0 
" + _9660 + @" = 125.0 
" + _9642 + @" = 155.0 
05A9: " + _9647 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9706 + @" 
" + _9652 + @" = 1 

:TATTO_845
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'TATTO3' 
jf @TATTO_940 
" + _9726 + @" = 0.0 
" + _9727 + @" = -35.32 
" + _9728 + @" = 0.0 
" + _9660 + @" = 125.0 
" + _9642 + @" = 155.0 
05A9: " + _9647 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9706 + @" 
" + _9652 + @" = 1 

:TATTO_940
if 
  " + _9652 + @" == 1 
jf @TATTO_1579 
if 
  " + _9664 + @" == 0 
jf @TATTO_1462 
" + X_Buy_Marker + @" = -203.318 
0059: " + X_Buy_Marker + @" += " + _9726 + @" 
" + Y_Buy_Marker + @" = -7.062 
0059: " + Y_Buy_Marker + @" += " + _9727 + @" 
" + Z_Buy_Marker + @" = 1001.28 
0059: " + Z_Buy_Marker + @" += " + _9728 + @" 
" + _9639 + @" = -201.668 
0059: " + _9639 + @" += " + _9726 + @" 
" + _9640 + @" = -6.217 
0059: " + _9640 + @" += " + _9727 + @" 
" + _9641 + @" = 1001.28 
0059: " + _9641 + @" += " + _9728 + @" 
" + X_Camera + @" = -203.2045 
0059: " + X_Camera + @" += " + _9726 + @" 
" + Y_Camera + @" = -5.3316 
0059: " + Y_Camera + @" += " + _9727 + @" 
" + Z_Camera + @" = 1002.432 
0059: " + Z_Camera + @" += " + _9728 + @" 
" + _9661 + @" = -202.2993 
0059: " + _9661 + @" += " + _9726 + @" 
" + _9662 + @" = -5.7376 
0059: " + _9662 + @" += " + _9727 + @" 
" + _9663 + @" = 1002.306 
0059: " + _9663 + @" += " + _9728 + @" 
0086: " + _9653 + @" = " + _9639 + @" 
0086: " + _9654 + @" = " + _9640 + @" 
0086: " + _9655 + @" = " + _9641 + @" 
" + _9655 + @" += 1.0 
0086: " + _9656 + @" = " + _9642 + @" 
03F0: enable_text_draw 1 
08F8: display_stat_update_box 0 
" + _9645 + @" = Actor.Create(CivMale, " + Seller_Model + @", " + _9639 + @", " + _9640 + @", " + _9641 + @")
02A9: set_actor " + _9645 + @" immune_to_nonplayer 1 
060B: set_actor " + _9645 + @" decision_maker_to 65542 
Actor.Angle(" + _9645 + @") = " + _9642 + @"
0985: set_objects_in_sphere " + _9639 + @" " + _9640 + @" " + _9641 + @" radius 1.5 with_model -369 solid 0 for_actor " + _9645 + @" 
" + _9649 + @" = 0 
" + _9651 + @" = Object.Init(#TATTOO_KIT, " + _9653 + @", " + _9654 + @", " + _9655 + @")
Object.Angle(" + _9651 + @") = " + _9656 + @"
04F4: put_actor " + _9645 + @" into_turret_on_object " + _9651 + @" offset_from_object_origin 0.0 0.0 0.0 orientation 0 both_side_angle_limit 180.0 lock_weapon 0 
" + Show_Shop_Sphere + @" = 1 
0812: AS_actor " + _9645 + @" perform_animation ""TAT_IDLE_LOOP_T"" IFP ""TATTOOS"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
TIMERA = 0 
0947: actor " + _9645 + @" speak_from_audio_table 330 store_spoken_phrase_id_to " + _10081 + @" 
" + _9664 + @" = 1 

:TATTO_1462
if 
  " + _9664 + @" == 1 
jf @TATTO_1579 
if 
  TIMERA >= 300 
jf @TATTO_1579 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_1565 
075A: set_object " + _9651 + @" animation ""TAT_IDLE_LOOP_O"" IFP_file ""TATTOOS"" 4.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_1565
" + _9664 + @" = 0 
" + _9652 + @" = 2 

:TATTO_1579
if 
  " + _9652 + @" == 2 
jf @TATTO_1963 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_1628 
gosub @TATTO_7873 

:TATTO_1628
if 
   not Actor.Dead(" + _9645 + @")
jf @TATTO_1918 
if 
  " + _9649 + @" == 0 
jf @TATTO_1866 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + _9645 + @" 
031D:   actor " + _9645 + @" hit_by_weapon 57 
jf @TATTO_1786 
0947: actor " + _9645 + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _10081 + @" 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_1765 
075A: set_object " + _9651 + @" animation ""TAT_DROP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_1765
05C4: AS_actor " + _9645 + @" hands_up -2 ms 
" + _9649 + @" = 1 
jump @TATTO_1859 

:TATTO_1786
" + Show_Shop_Sphere + @" = 1 
if 
0102:   actor " + PlayerActor + @" in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @TATTO_1859 
if 
   Player.Controllable(" + PlayerChar + @")
jf @TATTO_1859 
" + _9652 + @" = 3 

:TATTO_1859
jump @TATTO_1911 

:TATTO_1866
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_1904 
gosub @TATTO_7873 

:TATTO_1904
jump @TATTO_515 

:TATTO_1911
jump @TATTO_1963 

:TATTO_1918
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_1956 
gosub @TATTO_7873 

:TATTO_1956
jump @TATTO_515 

:TATTO_1963
if 
  " + _9652 + @" == 3 
jf @TATTO_2098 
if 
   Player.Defined(" + PlayerChar + @")
jf @TATTO_2084 
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 1.0 
0581: enable_radar 0 
TIMERA = 0 
" + _9664 + @" = 0 
" + _9652 + @" = 4 
jump @TATTO_2098 

:TATTO_2084
gosub @TATTO_7873 
jump @TATTO_515 

:TATTO_2098
if 
  " + _9652 + @" == 4 
jf @TATTO_2930 
if 
   Actor.Dead(" + _9645 + @")
jf @TATTO_2177 
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_2170 
gosub @TATTO_7873 

:TATTO_2170
jump @TATTO_515 

:TATTO_2177
if 
  " + _9664 + @" == 0 
jf @TATTO_2639 
if 
  TIMERA >= 300 
jf @TATTO_2639 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
08C7: put_actor " + PlayerActor + @" at " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = " + _9660 + @"
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
Actor.StorePos(" + _9645 + @", " + _2755 + @", " + _2756 + @", " + _2757 + @")
if or
8044:   not  " + _2755 + @" == " + _9639 + @" 
8044:   not  " + _2756 + @" == " + _9640 + @" 
8044:   not  " + _2757 + @" == " + _9641 + @" 
jf @TATTO_2328 
Actor.PutAt(" + _9645 + @", " + _9639 + @", " + _9640 + @", " + _9641 + @")
Actor.Angle(" + _9645 + @") = " + _9642 + @"

:TATTO_2328
Camera.SetPosition(" + X_Camera + @", " + Y_Camera + @", " + Z_Camera + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9661 + @", " + _9662 + @", " + _9663 + @", 2)
0793: save_player_clothes 
08F7: get_player " + PlayerChar + @" bodypart 0 textureCRC_to " + _9665 + @" modelCRC_to " + _9666 + @" 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 0 
Player.Build(" + PlayerChar + @")
0793: save_player_clothes 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_SIT_IN_P"" IFP ""TATTOOS"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9657 + @" = 0.0 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_SIT_IN_P""
jf @TATTO_2516 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_SIT_IN_P"" time 

:TATTO_2516
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_2579 
075A: set_object " + _9651 + @" animation ""TAT_SIT_IN_O"" IFP_file ""TATTOOS"" 4.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_2579
0812: AS_actor " + _9645 + @" perform_animation ""TAT_SIT_IN_T"" IFP ""TATTOOS"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9659 + @" = 0.0 
" + _9664 + @" = 1 

:TATTO_2639
if 
  " + _9664 + @" == 1 
jf @TATTO_2930 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_SIT_IN_P""
jf @TATTO_2709 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_SIT_IN_P"" time 

:TATTO_2709
if 
  " + _9657 + @" == 1.0 
jf @TATTO_2930 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_SIT_LOOP_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_2850 
075A: set_object " + _9651 + @" animation ""TAT_SIT_LOOP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_2850
0812: AS_actor " + _9645 + @" perform_animation ""TAT_SIT_LOOP_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
0947: actor " + _9645 + @" speak_from_audio_table 333 store_spoken_phrase_id_to " + _10081 + @" 
" + _9664 + @" = 0 
" + _9652 + @" = 5 

:TATTO_2930
if 
  " + _9652 + @" == 5 
jf @TATTO_4725 
if 
   Actor.Dead(" + _9645 + @")
jf @TATTO_3009 
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_3002 
gosub @TATTO_7873 

:TATTO_3002
jump @TATTO_515 

:TATTO_3009
if 
  2 > " + _9664 + @" 
jf @TATTO_3041 
gosub @TATTO_12073 
gosub @TATTO_10776 

:TATTO_3041
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9664 + @" == 0 
jf @TATTO_3114 
if 
00E1:   player 0 pressed_key 16 
jf @TATTO_3090 
" + _9664 + @" = 1 

:TATTO_3090
if 
00E1:   player 0 pressed_key 15 
jf @TATTO_3114 
" + _9664 + @" = 4 

:TATTO_3114
if 
  " + _9664 + @" == 1 
jf @TATTO_3306 
if 
80E1:   not player 0 pressed_key 16 
jf @TATTO_3306 
08D8: " + _2516 + @" = panel " + _2419 + @" selected_row 
if 
  0 > " + _2516 + @" 
jf @TATTO_3182 
" + _2516 + @" = 0 

:TATTO_3182
if 
  " + _2516 + @" == 9 
jf @TATTO_3278 
if 
  " + _2420 + @" == 1 
jf @TATTO_3232 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:TATTO_3232
if 
  " + _9722 + @" == 0 
jf @TATTO_3257 
gosub @TATTO_12175 

:TATTO_3257
" + _9664 + @" = 0 
" + _9652 + @" = 8 
jump @TATTO_3306 

:TATTO_3278
gosub @TATTO_8186 
gosub @TATTO_8413 
" + _9721 + @" = 0 
gosub @TATTO_13314 

:TATTO_3306
if 
  " + _9664 + @" == 2 
jf @TATTO_3338 
" + _9721 + @" = 0 
gosub @TATTO_13835 

:TATTO_3338
if 
  " + _9664 + @" == 3 
jf @TATTO_3418 
0084: " + _9705 + @" = " + _2516 + @" 
if 
  " + _2420 + @" == 1 
jf @TATTO_3396 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:TATTO_3396
" + _9709 + @" = 500 
" + _9652 + @" = 6 
" + _9664 + @" = 0 

:TATTO_3418
if 
  " + _9664 + @" == 4 
jf @TATTO_3524 
if 
80E1:   not player 0 pressed_key 15 
jf @TATTO_3524 
if 
  " + _2420 + @" == 1 
jf @TATTO_3485 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:TATTO_3485
if 
  " + _2424 + @" == 1 
jf @TATTO_3517 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:TATTO_3517
" + _9664 + @" = 5 

:TATTO_3524
if 
  " + _9664 + @" == 5 
jf @TATTO_3838 
" + _9721 + @" = 0 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_LOOP_P""
jf @TATTO_3659 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_BACK_SIT_OUT_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9657 + @" = 0.0 
" + _9664 + @" = 6 
jump @TATTO_3838 

:TATTO_3659
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_SIT_OUT_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_3777 
075A: set_object " + _9651 + @" animation ""TAT_SIT_OUT_O"" IFP_file ""TATTOOS"" 1000.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_3777
0812: AS_actor " + _9645 + @" perform_animation ""TAT_SIT_OUT_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9659 + @" = 0.0 
" + _9664 + @" = 7 

:TATTO_3838
if 
  " + _9664 + @" == 6 
jf @TATTO_4131 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_OUT_P""
jf @TATTO_3920 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_BACK_SIT_OUT_P"" time 

:TATTO_3920
if 
  " + _9657 + @" == 1.0 
jf @TATTO_4131 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_SIT_OUT_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_4059 
075A: set_object " + _9651 + @" animation ""TAT_SIT_OUT_O"" IFP_file ""TATTOOS"" 1000.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_4059
0812: AS_actor " + _9645 + @" perform_animation ""TAT_SIT_OUT_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0947: actor " + _9645 + @" speak_from_audio_table 331 store_spoken_phrase_id_to " + _10081 + @" 
" + _9659 + @" = 0.0 
" + _9664 + @" = 7 

:TATTO_4131
if 
  " + _9664 + @" == 7 
jf @TATTO_4442 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_SIT_OUT_P""
jf @TATTO_4203 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_SIT_OUT_P"" time 

:TATTO_4203
if 
   Actor.Animation(" + _9645 + @") == ""TAT_SIT_OUT_T""
jf @TATTO_4257 
0613: " + _9659 + @" = actor " + _9645 + @" animation ""TAT_SIT_OUT_T"" time 

:TATTO_4257
if 
  " + _9659 + @" == 1.0 
jf @TATTO_4400 
0812: AS_actor " + _9645 + @" perform_animation ""TAT_IDLE_LOOP_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_4400 
075A: set_object " + _9651 + @" animation ""TAT_IDLE_LOOP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_4400
if 
  " + _9657 + @" == 1.0 
jf @TATTO_4442 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9664 + @" = 8 

:TATTO_4442
if 
  " + _9664 + @" == 8 
jf @TATTO_4725 
0784: set_player " + PlayerChar + @" textureCRC " + _9665 + @" modelCRC " + _9666 + @" bodypart 0 
Player.Build(" + PlayerChar + @")
0793: save_player_clothes 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0581: enable_radar 1 
if 
   Actor.Animation(" + _9645 + @") == ""TAT_SIT_OUT_T""
jf @TATTO_4575 
0613: " + _9659 + @" = actor " + _9645 + @" animation ""TAT_SIT_OUT_T"" time 

:TATTO_4575
if 
  " + _9659 + @" == 1.0 
jf @TATTO_4718 
0812: AS_actor " + _9645 + @" perform_animation ""TAT_IDLE_LOOP_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_4718 
075A: set_object " + _9651 + @" animation ""TAT_IDLE_LOOP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_4718
" + _9652 + @" = 7 

:TATTO_4725
if 
  " + _9652 + @" == 6 
jf @TATTO_6147 
if 
   Actor.Dead(" + _9645 + @")
jf @TATTO_4804 
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_4797 
gosub @TATTO_7873 

:TATTO_4797
jump @TATTO_515 

:TATTO_4804
" + Show_Shop_Sphere + @" = 0 
if 
  1 > " + _9664 + @" 
jf @TATTO_4836 
gosub @TATTO_11385 

:TATTO_4836
if 
  " + _9664 + @" == 0 
jf @TATTO_5032 
08D7: " + _9708 + @" = panel " + _2423 + @" active_row 
if 
  0 > " + _9708 + @" 
jf @TATTO_4887 
" + _9708 + @" = 0 

:TATTO_4887
if 
803A:   not  " + _9709 + @" == " + _9708 + @" 
jf @TATTO_4921 
gosub @TATTO_12060 
0084: " + _9709 + @" = " + _9708 + @" 

:TATTO_4921
gosub @TATTO_15460 
if 
00E1:   player 0 pressed_key 16 
jf @TATTO_4980 
" + _2544 + @" = 0 
" + _2545 + @" = 0 
" + _2422 + @" = 0 
gosub @TATTO_15460 
" + _9664 + @" = 1 

:TATTO_4980
if 
00E1:   player 0 pressed_key 15 
jf @TATTO_5032 
gosub @TATTO_10503 
" + _2544 + @" = 0 
" + _2545 + @" = 0 
" + _2422 + @" = 0 
" + _9664 + @" = 8 

:TATTO_5032
if 
  " + _9664 + @" == 8 
jf @TATTO_5127 
if 
80E1:   not player 0 pressed_key 15 
jf @TATTO_5127 
if 
  " + _2424 + @" == 1 
jf @TATTO_5099 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:TATTO_5099
gosub @TATTO_12073 
gosub @TATTO_10776 
" + _9664 + @" = 0 
" + _9652 + @" = 5 

:TATTO_5127
if 
  " + _9664 + @" == 1 
jf @TATTO_5248 
gosub @TATTO_15460 
if 
80E1:   not player 0 pressed_key 16 
jf @TATTO_5248 
gosub @TATTO_15460 
08D8: " + _2517 + @" = panel " + _2423 + @" selected_row 
if 
  0 > " + _2517 + @" 
jf @TATTO_5209 
" + _2517 + @" = 0 

:TATTO_5209
0084: " + Selected_Menu_Item + @" = " + tmp_2438 + @"(" + _2517 + @",12i) 
0084: " + _9646 + @" = " + tmp_2426 + @"(" + _2517 + @",12i) 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
" + _9664 + @" = 2 

:TATTO_5248
if 
  " + _9664 + @" == 2 
jf @TATTO_5950 
gosub @TATTO_15460 
if 
002C:   " + Shops_Player_Cash + @" >= " + _9646 + @" 
jf @TATTO_5877 
gosub @TATTO_15460 
if 
803A:   not  " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @TATTO_5808 
if 
  " + _2424 + @" == 1 
jf @TATTO_5350 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:TATTO_5350
0947: actor " + _9645 + @" speak_from_audio_table 323 store_spoken_phrase_id_to " + _10081 + @" 
0790: charge_money_for_shopping_item_with_textureCRC " + Selected_Menu_Item + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
if 
  " + _2424 + @" == 1 
jf @TATTO_5412 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:TATTO_5412
if 
  " + _2422 + @" == 0 
jf @TATTO_5780 
08D4: " + _2421 + @" = create_panel_with_title 'TATTO' position 29.0 25.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2421 + @" column 0 alignment 1 
08DB: set_panel " + _2421 + @" column 0 header 'TATTO' data 'BOUGHT' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2421 + @" column 1 alignment 2 
08DB: set_panel " + _2421 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2421 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + _9646 + @"  
09DB: set_panel " + _2421 + @" column 0 width 140 
09DB: set_panel " + _2421 + @" column 1 width 46 
" + _2422 + @" = 1 

:TATTO_5780
" + _9721 + @" = 0 
gosub @TATTO_14230 
" + _9664 + @" = 3 
jump @TATTO_5870 

:TATTO_5808
if 
  " + _2545 + @" == 0 
jf @TATTO_5870 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
00BC: show_text_highpriority GXT 'CLTHNO2' time 5000 flag 1  
" + _9664 + @" = 0 
" + _2545 + @" = 1 

:TATTO_5870
jump @TATTO_5950 

:TATTO_5877
if 
  " + _2544 + @" == 0 
jf @TATTO_5950 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + _9645 + @" speak_from_audio_table 324 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'SHOPNO' time 5000 flag 1  
" + _9664 + @" = 0 
" + _2544 + @" = 1 

:TATTO_5950
if 
  " + _9664 + @" == 3 
jf @TATTO_5982 
" + _9721 + @" = 0 
gosub @TATTO_14372 

:TATTO_5982
if 
  " + _9664 + @" == 4 
jf @TATTO_6021 
" + _9721 + @" = 0 
gosub @TATTO_14704 
" + _9664 + @" = 5 

:TATTO_6021
if 
  " + _9664 + @" == 5 
jf @TATTO_6053 
" + _9721 + @" = 0 
gosub @TATTO_14842 

:TATTO_6053
if 
  " + _9664 + @" == 6 
jf @TATTO_6147 
if 
  " + _2422 + @" == 1 
jf @TATTO_6101 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:TATTO_6101
" + _9664 + @" = 0 
" + _9652 + @" = 5 
if 
  2 > " + _9664 + @" 
jf @TATTO_6147 
gosub @TATTO_12073 
gosub @TATTO_10776 

:TATTO_6147
if 
  " + _9652 + @" == 7 
jf @TATTO_6714 
if 
   Actor.Dead(" + _9645 + @")
jf @TATTO_6226 
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_6219 
gosub @TATTO_7873 

:TATTO_6219
jump @TATTO_515 

:TATTO_6226
if 
  " + _9649 + @" == 0 
jf @TATTO_6361 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + _9645 + @" 
031D:   actor " + _9645 + @" hit_by_weapon 57 
jf @TATTO_6361 
0947: actor " + _9645 + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _10081 + @" 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_6347 
075A: set_object " + _9651 + @" animation ""TAT_DROP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_6347
05C4: AS_actor " + _9645 + @" hands_up -2 ms 
" + _9649 + @" = 1 

:TATTO_6361
if 
   Actor.Animation(" + _9645 + @") == ""TAT_SIT_OUT_T""
jf @TATTO_6415 
0613: " + _9659 + @" = actor " + _9645 + @" animation ""TAT_SIT_OUT_T"" time 

:TATTO_6415
if 
  " + _9659 + @" == 1.0 
jf @TATTO_6558 
0812: AS_actor " + _9645 + @" perform_animation ""TAT_IDLE_LOOP_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_6558 
075A: set_object " + _9651 + @" animation ""TAT_IDLE_LOOP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_6558
if 
80FF:   not actor " + PlayerActor + @" sphere " + Show_Shop_Sphere + @" in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 on_foot 
jf @TATTO_6714 
" + _9652 + @" = 2 
" + _9664 + @" = 0 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9705 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + _9725 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
" + Show_Shop_Sphere + @" = 1 

:TATTO_6714
if 
  " + _9652 + @" == 8 
jf @TATTO_7584 
if 
   Actor.Dead(" + _9645 + @")
jf @TATTO_6793 
gosub @TATTO_7619 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9647 + @" 
jf @TATTO_6786 
gosub @TATTO_7873 

:TATTO_6786
jump @TATTO_515 

:TATTO_6793
if 
  1 > " + _9664 + @" 
jf @TATTO_6836 
if 
  " + _9722 + @" == 0 
jf @TATTO_6836 
gosub @TATTO_12175 

:TATTO_6836
if 
  " + _9664 + @" == 0 
jf @TATTO_6916 
if 
00E1:   player 0 pressed_key 15 
jf @TATTO_6885 
" + _2544 + @" = 0 
" + _9664 + @" = 1 

:TATTO_6885
if 
00E1:   player 0 pressed_key 16 
jf @TATTO_6916 
" + _2544 + @" = 0 
" + _9664 + @" = 2 

:TATTO_6916
if 
  " + _9664 + @" == 1 
jf @TATTO_7036 
if 
80E1:   not player 0 pressed_key 15 
jf @TATTO_7036 
if 
  " + _9722 + @" == 1 
jf @TATTO_6983 
08DA: remove_panel " + _9723 + @" 
03E6: remove_text_box 
" + _9722 + @" = 0 

:TATTO_6983
if 
  " + _2420 + @" == 0 
jf @TATTO_7015 
gosub @TATTO_12073 
gosub @TATTO_10776 

:TATTO_7015
" + _2544 + @" = 0 
" + _9664 + @" = 0 
" + _9652 + @" = 5 

:TATTO_7036
if 
  " + _9664 + @" == 2 
jf @TATTO_7302 
if 
80E1:   not player 0 pressed_key 16 
jf @TATTO_7302 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
if 
  " + Shops_Player_Cash + @" >= 400 
jf @TATTO_7229 
08D8: " + _9725 + @" = panel " + _9723 + @" selected_row 
if 
  0 > " + _9725 + @" 
jf @TATTO_7131 
" + _9725 + @" = 0 

:TATTO_7131
if 
  " + _9722 + @" == 1 
jf @TATTO_7163 
08DA: remove_panel " + _9723 + @" 
03E6: remove_text_box 
" + _9722 + @" = 0 

:TATTO_7163
0084: " + _2547 + @" = " + tmp_9712 + @"(" + _9725 + @",9i) 
gosub @TATTO_8413 
Player.Money(" + PlayerChar + @") += -400
0947: actor " + _9645 + @" speak_from_audio_table 326 store_spoken_phrase_id_to " + _10081 + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
" + _9664 + @" = 3 
jump @TATTO_7302 

:TATTO_7229
if 
  " + _2544 + @" == 0 
jf @TATTO_7302 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + _9645 + @" speak_from_audio_table 324 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'SHOPNO' time 5000 flag 1  
" + _9664 + @" = 0 
" + _2544 + @" = 1 

:TATTO_7302
if 
  " + _9664 + @" == 3 
jf @TATTO_7334 
" + _9721 + @" = 1 
gosub @TATTO_13314 

:TATTO_7334
if 
  " + _9664 + @" == 4 
jf @TATTO_7366 
" + _9721 + @" = 1 
gosub @TATTO_13835 

:TATTO_7366
if 
  " + _9664 + @" == 5 
jf @TATTO_7417 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart " + _2547 + @" 
" + _9721 + @" = 1 
gosub @TATTO_14230 
" + _9664 + @" = 6 

:TATTO_7417
if 
  " + _9664 + @" == 6 
jf @TATTO_7449 
" + _9721 + @" = 1 
gosub @TATTO_14372 

:TATTO_7449
if 
  " + _9664 + @" == 7 
jf @TATTO_7488 
" + _9721 + @" = 1 
gosub @TATTO_14704 
" + _9664 + @" = 8 

:TATTO_7488
if 
  " + _9664 + @" == 8 
jf @TATTO_7520 
" + _9721 + @" = 1 
gosub @TATTO_14842 

:TATTO_7520
if 
  " + _9664 + @" == 9 
jf @TATTO_7584 
" + _9664 + @" = 0 
" + _9652 + @" = 5 
if 
  2 > " + _9664 + @" 
jf @TATTO_7584 
gosub @TATTO_12073 
gosub @TATTO_10776 

:TATTO_7584
jump @TATTO_7598 

:TATTO_7591
gosub @TATTO_7873 

:TATTO_7598
jump @TATTO_7612 

:TATTO_7605
gosub @TATTO_7873 

:TATTO_7612
jump @TATTO_515 

:TATTO_7619
if 
  " + _9652 + @" >= 1 
jf @TATTO_7639 
03E6: remove_text_box 

:TATTO_7639
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
if 
  " + _2420 + @" == 1 
jf @TATTO_7693 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:TATTO_7693
if 
  " + _2424 + @" == 1 
jf @TATTO_7725 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:TATTO_7725
if 
  " + _9722 + @" == 1 
jf @TATTO_7757 
08DA: remove_panel " + _9723 + @" 
03E6: remove_text_box 
" + _9722 + @" = 0 

:TATTO_7757
if 
  " + _2422 + @" == 1 
jf @TATTO_7787 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:TATTO_7787
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9705 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + _9725 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9652 + @" = 2 
" + _9664 + @" = 0 
return 

:TATTO_7873
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
" + Show_Shop_Sphere + @" = 1 
" + _9649 + @" = 0 
" + _9652 + @" = 0 
" + _9664 + @" = 0 
if 
  " + _2420 + @" == 1 
jf @TATTO_7955 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:TATTO_7955
if 
  " + _2424 + @" == 1 
jf @TATTO_7987 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:TATTO_7987
if 
  " + _9722 + @" == 1 
jf @TATTO_8019 
08DA: remove_panel " + _9723 + @" 
03E6: remove_text_box 
" + _9722 + @" = 0 

:TATTO_8019
if 
  " + _2422 + @" == 1 
jf @TATTO_8049 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:TATTO_8049
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9705 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + _9725 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
if 
   not Actor.Dead(" + _9645 + @")
jf @TATTO_8140 
0465: remove_actor " + _9645 + @" from_turret_mode 

:TATTO_8140
Object.Destroy(" + _9651 + @")
Model.Destroy(#TATTOO_KIT)
Actor.DestroyInstantly(" + _9645 + @")
Model.Destroy(" + Seller_Model + @")
0391: release_textures 
03F0: enable_text_draw 0 
0581: enable_radar 1 
08F8: display_stat_update_box 1 
09BD: allow_other_threads_to_display_text_boxes 0 
040D: unload_wav 4 
end_thread 
return 

:TATTO_8186
if 
  " + _2516 + @" == 0 
jf @TATTO_8211 
04AE: " + _2547 + @" = 4 

:TATTO_8211
if 
  " + _2516 + @" == 1 
jf @TATTO_8236 
04AE: " + _2547 + @" = 5 

:TATTO_8236
if 
  " + _2516 + @" == 2 
jf @TATTO_8261 
04AE: " + _2547 + @" = 6 

:TATTO_8261
if 
  " + _2516 + @" == 3 
jf @TATTO_8286 
04AE: " + _2547 + @" = 7 

:TATTO_8286
if 
  " + _2516 + @" == 4 
jf @TATTO_8311 
04AE: " + _2547 + @" = 8 

:TATTO_8311
if 
  " + _2516 + @" == 5 
jf @TATTO_8336 
04AE: " + _2547 + @" = 9 

:TATTO_8336
if 
  " + _2516 + @" == 6 
jf @TATTO_8361 
04AE: " + _2547 + @" = 10 

:TATTO_8361
if 
  " + _2516 + @" == 7 
jf @TATTO_8386 
04AE: " + _2547 + @" = 11 

:TATTO_8386
if 
  " + _2516 + @" == 8 
jf @TATTO_8411 
04AE: " + _2547 + @" = 12 

:TATTO_8411
return 

:TATTO_8413
if 
04A3:   " + _2547 + @" == 4 
jf @TATTO_8648 
" + _2513 + @" = 4 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_ARML_IN_P"" 
06D1: " + _9673 + @" = ""TAT_ARML_IN_T"" 
06D1: " + _9677 + @" = ""TAT_ARML_IN_O"" 
06D1: " + _9681 + @" = ""TAT_ARML_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_ARML_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_ARML_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_ARML_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_ARML_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_ARML_OUT_O"" 

:TATTO_8648
if 
04A3:   " + _2547 + @" == 5 
jf @TATTO_8883 
" + _2513 + @" = 5 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_ARML_IN_P"" 
06D1: " + _9673 + @" = ""TAT_ARML_IN_T"" 
06D1: " + _9677 + @" = ""TAT_ARML_IN_O"" 
06D1: " + _9681 + @" = ""TAT_ARML_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_ARML_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_ARML_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_ARML_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_ARML_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_ARML_OUT_O"" 

:TATTO_8883
if 
04A3:   " + _2547 + @" == 6 
jf @TATTO_9118 
" + _2513 + @" = 6 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_ARMR_IN_P"" 
06D1: " + _9673 + @" = ""TAT_ARMR_IN_T"" 
06D1: " + _9677 + @" = ""TAT_ARMR_IN_O"" 
06D1: " + _9681 + @" = ""TAT_ARMR_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_ARMR_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_ARMR_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_ARMR_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_ARMR_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_ARMR_OUT_O"" 

:TATTO_9118
if 
04A3:   " + _2547 + @" == 7 
jf @TATTO_9353 
" + _2513 + @" = 7 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_ARMR_IN_P"" 
06D1: " + _9673 + @" = ""TAT_ARMR_IN_T"" 
06D1: " + _9677 + @" = ""TAT_ARMR_IN_O"" 
06D1: " + _9681 + @" = ""TAT_ARMR_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_ARMR_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_ARMR_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_ARMR_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_ARMR_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_ARMR_OUT_O"" 

:TATTO_9353
if 
04A3:   " + _2547 + @" == 8 
jf @TATTO_9588 
" + _2513 + @" = 8 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_BACK_IN_P"" 
06D1: " + _9673 + @" = ""TAT_BACK_IN_T"" 
06D1: " + _9677 + @" = ""TAT_BACK_IN_O"" 
06D1: " + _9681 + @" = ""TAT_BACK_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_BACK_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_BACK_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_BACK_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_BACK_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_BACK_OUT_O"" 

:TATTO_9588
if 
04A3:   " + _2547 + @" == 9 
jf @TATTO_9814 
" + _2513 + @" = 9 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_CHE_IN_P"" 
06D1: " + _9673 + @" = ""TAT_CHE_IN_T"" 
06D1: " + _9677 + @" = ""TAT_CHE_IN_O"" 
06D1: " + _9681 + @" = ""TAT_CHE_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_CHE_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_CHE_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_CHE_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_CHE_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_CHE_OUT_O"" 

:TATTO_9814
if 
04A3:   " + _2547 + @" == 10 
jf @TATTO_10040 
" + _2513 + @" = 10 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_CHE_IN_P"" 
06D1: " + _9673 + @" = ""TAT_CHE_IN_T"" 
06D1: " + _9677 + @" = ""TAT_CHE_IN_O"" 
06D1: " + _9681 + @" = ""TAT_CHE_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_CHE_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_CHE_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_CHE_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_CHE_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_CHE_OUT_O"" 

:TATTO_10040
if 
04A3:   " + _2547 + @" == 11 
jf @TATTO_10266 
" + _2513 + @" = 11 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_CHE_IN_P"" 
06D1: " + _9673 + @" = ""TAT_BEL_IN_T"" 
06D1: " + _9677 + @" = ""TAT_BEL_IN_O"" 
06D1: " + _9681 + @" = ""TAT_CHE_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_BEL_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_BEL_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_CHE_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_BEL_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_BEL_OUT_O"" 

:TATTO_10266
if 
04A3:   " + _2547 + @" == 12 
jf @TATTO_10501 
" + _2513 + @" = 12 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @TATTO_10503 
06D1: " + _9669 + @" = ""TAT_BACK_IN_P"" 
06D1: " + _9673 + @" = ""TAT_BACK_IN_T"" 
06D1: " + _9677 + @" = ""TAT_BACK_IN_O"" 
06D1: " + _9681 + @" = ""TAT_BACK_POSE_P"" 
06D1: " + _9685 + @" = ""TAT_BACK_POSE_T"" 
06D1: " + _9689 + @" = ""TAT_BACK_POSE_O"" 
06D1: " + _9693 + @" = ""TAT_BACK_OUT_P"" 
06D1: " + _9697 + @" = ""TAT_BACK_OUT_T"" 
06D1: " + _9701 + @" = ""TAT_BACK_OUT_O"" 

:TATTO_10501
return 

:TATTO_10503
" + _2514 + @" = 0 
" + _9707 + @" = 0 

:TATTO_10517
if 
001C:   " + _9706 + @" > " + _2514 + @" 
jf @TATTO_10694 
0760: store_shopping_data_index " + _2514 + @" textureCRC_to " + Selected_Menu_Item + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 0 store_to " + ShoppingItem_ModelCRC + @" 
if 
003A:   " + ShoppingItem_ModelCRC + @" == " + _2513 + @" 
jf @TATTO_10680 
0084: " + tmp_2438 + @"(" + _9707 + @",12i) = " + Selected_Menu_Item + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _9643 + @" 
0761: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" price_to " + _9646 + @" 
0084: " + tmp_2426 + @"(" + _9707 + @",12i) = " + _9646 + @" 
05A9: " + tmp_2450 + @"(" + _9707 + @",12s) = " + _9643 + @" 
if 
003A:   " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @TATTO_10662 
" + tmp_2498 + @"(" + _9707 + @",12i) = 0 
jump @TATTO_10673 

:TATTO_10662
" + tmp_2498 + @"(" + _9707 + @",12i) = 1 

:TATTO_10673
" + _9707 + @" += 1 

:TATTO_10680
" + _2514 + @" += 1 
jump @TATTO_10517 

:TATTO_10694
0084: " + _2515 + @" = " + _9707 + @" 

:TATTO_10702
if 
  12 > " + _2515 + @" 
jf @TATTO_10774 
" + tmp_2438 + @"(" + _2515 + @",12i) = -1 
" + tmp_2426 + @"(" + _2515 + @",12i) = 0 
05A9: " + tmp_2450 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @TATTO_10702 

:TATTO_10774
return 

:TATTO_10776
if 
  " + _2420 + @" == 0 
jf @TATTO_11383 
0512: show_permanent_text_box 'TATTA'  
05A9: " + _2518 + @" = 'LARMTP' 
05A9: " + _2520 + @" = 'LARMLW' 
05A9: " + _2522 + @" = 'RARMTP' 
05A9: " + _2524 + @" = 'RARMLW' 
05A9: " + _2526 + @" = 'BACK' 
05A9: " + _2528 + @" = 'LCHEST' 
05A9: " + _2530 + @" = 'RCHEST' 
05A9: " + _2532 + @" = 'BELLY' 
05A9: " + _2534 + @" = 'LBACK' 
if 
  " + _9711 + @" > 0 
jf @TATTO_10970 
05A9: " + _2536 + @" = 'TATREM' 
jump @TATTO_10984 

:TATTO_10970
05A9: " + _2536 + @" = 'DUMMY' 

:TATTO_10984
05A9: " + _2538 + @" = 'DUMMY' 
05A9: " + _2540 + @" = 'DUMMY' 
if 
04A3:   " + Current_Language + @" == 0 
jf @TATTO_11074 
08D4: " + _2419 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @TATTO_11315 

:TATTO_11074
if 
04A3:   " + Current_Language + @" == 1 
jf @TATTO_11136 
08D4: " + _2419 + @" = create_panel_with_title 'TATTO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @TATTO_11315 

:TATTO_11136
if 
04A3:   " + Current_Language + @" == 2 
jf @TATTO_11198 
08D4: " + _2419 + @" = create_panel_with_title 'TATTO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @TATTO_11315 

:TATTO_11198
if 
04A3:   " + Current_Language + @" == 3 
jf @TATTO_11260 
08D4: " + _2419 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @TATTO_11315 

:TATTO_11260
if 
04A3:   " + Current_Language + @" == 4 
jf @TATTO_11315 
08D4: " + _2419 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:TATTO_11315
08D6: set_panel " + _2419 + @" column 1 alignment 1 
08DB: set_panel " + _2419 + @" column 0 header 'DUMMY' data " + _2518 + @" " + _2520 + @" " + _2522 + @" " + _2524 + @" " + _2526 + @" " + _2528 + @" " + _2530 + @" " + _2532 + @" " + _2534 + @" " + _2536 + @" " + _2538 + @" " + _2540 + @" 
" + _2420 + @" = 1 

:TATTO_11383
return 

:TATTO_11385
if 
  " + _2424 + @" == 0 
jf @TATTO_12058 
0512: show_permanent_text_box 'TATTB'  
if 
04A3:   " + Current_Language + @" == 0 
jf @TATTO_11476 
08D4: " + _2423 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_11717 

:TATTO_11476
if 
04A3:   " + Current_Language + @" == 1 
jf @TATTO_11538 
08D4: " + _2423 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_11717 

:TATTO_11538
if 
04A3:   " + Current_Language + @" == 2 
jf @TATTO_11600 
08D4: " + _2423 + @" = create_panel_with_title 'TATTO' position 29.0 165.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_11717 

:TATTO_11600
if 
04A3:   " + Current_Language + @" == 3 
jf @TATTO_11662 
08D4: " + _2423 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_11717 

:TATTO_11662
if 
04A3:   " + Current_Language + @" == 4 
jf @TATTO_11717 
08D4: " + _2423 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  

:TATTO_11717
08D6: set_panel " + _2423 + @" column 0 alignment 1 
08DB: set_panel " + _2423 + @" column 0 header 'TATTO' data s" + tmp_2450 + @"[0] s" + tmp_2450 + @"[1] s" + tmp_2450 + @"[2] s" + tmp_2450 + @"[3] s" + tmp_2450 + @"[4] s" + tmp_2450 + @"[5] s" + tmp_2450 + @"[6] s" + tmp_2450 + @"[7] s" + tmp_2450 + @"[8] s" + tmp_2450 + @"[9] s" + tmp_2450 + @"[10] s" + tmp_2450 + @"[11]  
08D6: set_panel " + _2423 + @" column 1 alignment 2 
08DB: set_panel " + _2423 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
" + _2425 + @" = 0 

:TATTO_11918
if 
001C:   " + _9707 + @" > " + _2425 + @" 
jf @TATTO_11977 
08EE: set_panel " + _2423 + @" column 1 row " + _2425 + @" text_1number GXT 'DOLLAR' number " + tmp_2426 + @"(" + _2425 + @",12i)  
" + _2425 + @" += 1 
jump @TATTO_11918 

:TATTO_11977
" + _2515 + @" = 0 

:TATTO_11984
if 
001C:   " + _9707 + @" > " + _2515 + @" 
jf @TATTO_12032 
08D9: set_panel " + _2423 + @" row " + _2515 + @" enable " + tmp_2498 + @"(" + _2515 + @",12i) 
" + _2515 + @" += 1 
jump @TATTO_11984 

:TATTO_12032
09DB: set_panel " + _2423 + @" column 0 width 140 
09DB: set_panel " + _2423 + @" column 1 width 46 
" + _2424 + @" = 1 

:TATTO_12058
return 

:TATTO_12060
038F: load_texture " + tmp_2450 + @"(" + _9708 + @",12s) as 1 
return 

:TATTO_12073
" + _2515 + @" = 0 
" + _9711 + @" = 0 

:TATTO_12087
if 
  9 > " + _2515 + @" 
jf @TATTO_12173 
04AE: " + TATOO_Selected_Torso_Part + @" = 4 
0058: " + TATOO_Selected_Torso_Part + @" += " + _2515 + @" 
08F7: get_player " + PlayerChar + @" bodypart " + TATOO_Selected_Torso_Part + @" textureCRC_to " + _9667 + @" modelCRC_to " + _9668 + @" 
if 
   not " + _9667 + @" == 0 
jf @TATTO_12159 
" + _9711 + @" += 1 

:TATTO_12159
" + _2515 + @" += 1 
jump @TATTO_12087 

:TATTO_12173
return 

:TATTO_12175
if 
  " + _9722 + @" == 0 
jf @TATTO_13312 
" + _9724 + @" = 0 
" + _2515 + @" = 0 

:TATTO_12207
if 
  9 > " + _2515 + @" 
jf @TATTO_12658 
04AE: " + TATOO_Selected_Torso_Part + @" = 4 
0058: " + TATOO_Selected_Torso_Part + @" += " + _2515 + @" 
08F7: get_player " + PlayerChar + @" bodypart " + TATOO_Selected_Torso_Part + @" textureCRC_to " + _9667 + @" modelCRC_to " + _9668 + @" 
if 
   not " + _9667 + @" == 0 
jf @TATTO_12644 
0084: " + tmp_9712 + @"(" + _9724 + @",9i) = " + TATOO_Selected_Torso_Part + @" 
0871: init_jump_table " + TATOO_Selected_Torso_Part + @" total_jumps 9 default_jump 0 @TATTO_12637 jumps 4 @TATTO_12412 5 @TATTO_12437 6 @TATTO_12462 7 @TATTO_12487 8 @TATTO_12512 9 @TATTO_12537 10 @TATTO_12562 
0872: jump_table_jumps 11 @TATTO_12587 12 @TATTO_12612 -1 @TATTO_12637 -1 @TATTO_12637 -1 @TATTO_12637 -1 @TATTO_12637 -1 @TATTO_12637 -1 @TATTO_12637 -1 @TATTO_12637 

:TATTO_12412
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'LARMTP' 
jump @TATTO_12637 

:TATTO_12437
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'LARMLW' 
jump @TATTO_12637 

:TATTO_12462
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'RARMTP' 
jump @TATTO_12637 

:TATTO_12487
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'RARMLW' 
jump @TATTO_12637 

:TATTO_12512
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'BACK' 
jump @TATTO_12637 

:TATTO_12537
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'LCHEST' 
jump @TATTO_12637 

:TATTO_12562
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'RCHEST' 
jump @TATTO_12637 

:TATTO_12587
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'BELLY' 
jump @TATTO_12637 

:TATTO_12612
05A9: " + tmp_2450 + @"(" + _9724 + @",12s) = 'LBACK' 
jump @TATTO_12637 

:TATTO_12637
" + _9724 + @" += 1 

:TATTO_12644
" + _2515 + @" += 1 
jump @TATTO_12207 

:TATTO_12658
0084: " + _2515 + @" = " + _9724 + @" 

:TATTO_12666
if 
  12 > " + _2515 + @" 
jf @TATTO_12716 
05A9: " + tmp_2450 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @TATTO_12666 

:TATTO_12716
0512: show_permanent_text_box 'TATTA'  
if 
04A3:   " + Current_Language + @" == 0 
jf @TATTO_12789 
08D4: " + _9723 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_13030 

:TATTO_12789
if 
04A3:   " + Current_Language + @" == 1 
jf @TATTO_12851 
08D4: " + _9723 + @" = create_panel_with_title 'TATTO' position 29.0 165.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_13030 

:TATTO_12851
if 
04A3:   " + Current_Language + @" == 2 
jf @TATTO_12913 
08D4: " + _9723 + @" = create_panel_with_title 'TATTO' position 29.0 165.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_13030 

:TATTO_12913
if 
04A3:   " + Current_Language + @" == 3 
jf @TATTO_12975 
08D4: " + _9723 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @TATTO_13030 

:TATTO_12975
if 
04A3:   " + Current_Language + @" == 4 
jf @TATTO_13030 
08D4: " + _9723 + @" = create_panel_with_title 'TATTO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  

:TATTO_13030
08D6: set_panel " + _9723 + @" column 0 alignment 1 
08DB: set_panel " + _9723 + @" column 0 header 'TATTO' data s" + tmp_2450 + @"[0] s" + tmp_2450 + @"[1] s" + tmp_2450 + @"[2] s" + tmp_2450 + @"[3] s" + tmp_2450 + @"[4] s" + tmp_2450 + @"[5] s" + tmp_2450 + @"[6] s" + tmp_2450 + @"[7] s" + tmp_2450 + @"[8] s" + tmp_2450 + @"[9] s" + tmp_2450 + @"[10] s" + tmp_2450 + @"[11]  
08D6: set_panel " + _9723 + @" column 1 alignment 2 
08DB: set_panel " + _9723 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
" + _2425 + @" = 0 

:TATTO_13231
if 
001C:   " + _9724 + @" > " + _2425 + @" 
jf @TATTO_13286 
08EE: set_panel " + _2423 + @" column 1 row " + _2425 + @" text_1number GXT 'DOLLAR' number 400  
" + _2425 + @" += 1 
jump @TATTO_13231 

:TATTO_13286
09DB: set_panel " + _9723 + @" column 0 width 140 
09DB: set_panel " + _9723 + @" column 1 width 46 
" + _9722 + @" = 1 

:TATTO_13312
return 

:TATTO_13314
if or
04A3:   " + _2547 + @" == 8 
04A3:   " + _2547 + @" == 12 
jf @TATTO_13588 
if 
   not Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_LOOP_P""
jf @TATTO_13542 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_BACK_SIT_IN_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9657 + @" = 0.0 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_IN_P""
jf @TATTO_13496 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_BACK_SIT_IN_P"" time 

:TATTO_13496
if 
  " + _9721 + @" == 1 
jf @TATTO_13528 
" + _9664 + @" = 4 
jump @TATTO_13535 

:TATTO_13528
" + _9664 + @" = 2 

:TATTO_13535
jump @TATTO_13581 

:TATTO_13542
if 
  " + _9721 + @" == 1 
jf @TATTO_13574 
" + _9664 + @" = 5 
jump @TATTO_13581 

:TATTO_13574
" + _9664 + @" = 3 

:TATTO_13581
jump @TATTO_13833 

:TATTO_13588
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_LOOP_P""
jf @TATTO_13794 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_BACK_SIT_OUT_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9657 + @" = 0.0 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_OUT_P""
jf @TATTO_13748 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_BACK_SIT_OUT_P"" time 

:TATTO_13748
if 
  " + _9721 + @" == 1 
jf @TATTO_13780 
" + _9664 + @" = 4 
jump @TATTO_13787 

:TATTO_13780
" + _9664 + @" = 2 

:TATTO_13787
jump @TATTO_13833 

:TATTO_13794
if 
  " + _9721 + @" == 1 
jf @TATTO_13826 
" + _9664 + @" = 5 
jump @TATTO_13833 

:TATTO_13826
" + _9664 + @" = 3 

:TATTO_13833
return 

:TATTO_13835
if or
04A3:   " + _2547 + @" == 8 
04A3:   " + _2547 + @" == 12 
jf @TATTO_14049 
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_IN_P""
jf @TATTO_13922 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_BACK_SIT_IN_P"" time 

:TATTO_13922
if 
  " + _9657 + @" == 1.0 
jf @TATTO_14042 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_BACK_SIT_LOOP_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
  " + _9721 + @" == 1 
jf @TATTO_14035 
" + _9664 + @" = 5 
jump @TATTO_14042 

:TATTO_14035
" + _9664 + @" = 3 

:TATTO_14042
jump @TATTO_14228 

:TATTO_14049
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_SIT_OUT_P""
jf @TATTO_14113 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation ""TAT_BACK_SIT_OUT_P"" time 

:TATTO_14113
if 
  " + _9657 + @" == 1.0 
jf @TATTO_14228 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_SIT_LOOP_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
  " + _9721 + @" == 1 
jf @TATTO_14221 
" + _9664 + @" = 5 
jump @TATTO_14228 

:TATTO_14221
" + _9664 + @" = 3 

:TATTO_14228
return 

:TATTO_14230
0812: AS_actor " + PlayerActor + @" perform_animation " + _9669 + @" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
03D1: play_wav 4 
" + _9657 + @" = 0.0 
0812: AS_actor " + _9645 + @" perform_animation " + _9673 + @" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_14370 
075A: set_object " + _9651 + @" animation " + _9677 + @" IFP_file ""TATTOOS"" 1000.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_14370
return 

:TATTO_14372
if 
   Actor.Animation(" + PlayerActor + @") == " + _9669 + @"
jf @TATTO_14402 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation " + _9669 + @" time 

:TATTO_14402
if 
   Actor.Animation(" + _9645 + @") == " + _9673 + @"
jf @TATTO_14432 
0613: " + _9657 + @" = actor " + _9645 + @" animation " + _9673 + @" time 

:TATTO_14432
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_14478 
if 
0837:   object " + _9651 + @" animation == " + _9677 + @" 
jf @TATTO_14478 
0839: get_object " + _9651 + @" animation " + _9677 + @" progress_to " + _9658 + @" 

:TATTO_14478
if 
  " + _9657 + @" == 1.0 
jf @TATTO_14702 
0812: AS_actor " + PlayerActor + @" perform_animation " + _9681 + @" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
0812: AS_actor " + _9645 + @" perform_animation " + _9685 + @" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_14635 
075A: set_object " + _9651 + @" animation " + _9689 + @" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_14635
0793: save_player_clothes 
Player.Build(" + PlayerChar + @")
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
if 
  " + _9721 + @" == 1 
jf @TATTO_14688 
" + _9664 + @" = 7 
jump @TATTO_14702 

:TATTO_14688
gosub @TATTO_10503 
" + _9664 + @" = 4 

:TATTO_14702
return 

:TATTO_14704
0812: AS_actor " + PlayerActor + @" perform_animation " + _9693 + @" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9657 + @" = 0.0 
0812: AS_actor " + _9645 + @" perform_animation " + _9697 + @" IFP ""TATTOOS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_14840 
075A: set_object " + _9651 + @" animation " + _9701 + @" IFP_file ""TATTOOS"" 1000.0 lockF 0 loop 1 
" + _9658 + @" = 0.0 

:TATTO_14840
return 

:TATTO_14842
if 
   Actor.Animation(" + PlayerActor + @") == " + _9693 + @"
jf @TATTO_14872 
0613: " + _9657 + @" = actor " + PlayerActor + @" animation " + _9693 + @" time 

:TATTO_14872
if 
   Actor.Animation(" + _9645 + @") == " + _9697 + @"
jf @TATTO_14902 
0613: " + _9659 + @" = actor " + _9645 + @" animation " + _9697 + @" time 

:TATTO_14902
if 
   Actor.Animation(" + PlayerActor + @") == ""TAT_BACK_OUT_P""
jf @TATTO_15202 
if 
  " + _9657 + @" == 1.0 
jf @TATTO_15054 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_BACK_SIT_LOOP_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
  " + _9721 + @" == 1 
jf @TATTO_15047 
" + _9664 + @" = 9 
jump @TATTO_15054 

:TATTO_15047
" + _9664 + @" = 6 

:TATTO_15054
if 
  " + _9659 + @" == 1.0 
jf @TATTO_15195 
0812: AS_actor " + _9645 + @" perform_animation ""TAT_SIT_LOOP_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_15195 
075A: set_object " + _9651 + @" animation ""TAT_SIT_LOOP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_15195
jump @TATTO_15458 

:TATTO_15202
if 
  " + _9657 + @" == 1.0 
jf @TATTO_15317 
0812: AS_actor " + PlayerActor + @" perform_animation ""TAT_SIT_LOOP_P"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9657 + @" = 0.0 
if 
  " + _9721 + @" == 1 
jf @TATTO_15310 
" + _9664 + @" = 9 
jump @TATTO_15317 

:TATTO_15310
" + _9664 + @" = 6 

:TATTO_15317
if 
  " + _9659 + @" == 1.0 
jf @TATTO_15458 
0812: AS_actor " + _9645 + @" perform_animation ""TAT_SIT_LOOP_T"" IFP ""TATTOOS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9659 + @" = 0.0 
if 
03CA:   object " + _9651 + @" exists 
jf @TATTO_15458 
075A: set_object " + _9651 + @" animation ""TAT_SIT_LOOP_O"" IFP_file ""TATTOOS"" 1000.0 lockF 1 loop 0 
" + _9658 + @" = 0.0 

:TATTO_15458
return 

:TATTO_15460
03E3: set_texture_to_be_drawn_antialiased 1 
038E: draw_box_position 280.0 58.0 size 70.0 70.0 RGBA 0 0 0 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 1 position 280.0 58.0 size 64.0 64.0 RGBA 255 255 255 200 
return 
end_thread" );
            }

        }

    }

}