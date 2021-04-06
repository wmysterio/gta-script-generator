using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class CLOTH : External {

            Int tmp_2438 = global( _2438.startIndex ),
                tmp_2426 = global( _2426.startIndex ),
                tmp_2474 = global( _2474.startIndex ),
                tmp_2486 = global( _2486.startIndex ),
                tmp_2450 = global( _2450.startIndex ),
                tmp_2498 = global( _2498.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _2418 + @" = 0 
" + _2420 + @" = 0 
" + _2422 + @" = 0 
" + _2424 + @" = 0 
" + _2425 + @" = 0 
" + _2513 + @" = 0 
" + _2514 + @" = 0 
" + _2515 + @" = 0 
" + _2544 + @" = 0 
" + _2545 + @" = 0  
" + _2546 + @" = 0 
" + _2547 + @" = 0
" + _9983 + @" = 0 
" + _9986 + @" = 0  
" + _9987 + @" = 0 
" + _9988 + @" = 0 
" + _9990 + @" = 0 
" + _9991 + @" = 0.0 
" + _9992 + @" = 0.0 
" + _9993 + @" = 0 
" + _9998 + @" = 0 
" + _9999 + @" = 0  
" + _10000 + @" = 0 
" + _10001 + @" = 0.0 
" + _10002 + @" = 0.0 
" + _10003 + @" = 0.0 
" + _10004 + @" = 0.0 
" + _10005 + @" = 0.0 
" + _10006 + @" = 0.0 
" + _10007 + @" = 0.0 
" + _10008 + @" = 0.0 
" + _10009 + @" = 0.0 
" + _10010 + @" = 0.0 
" + _10011 + @" = 0.0 
" + _10012 + @" = 0.0 
" + _10013 + @" = 0.0 
" + _10014 + @" = 0.0 
" + _10015 + @" = 0.0 
" + _10016 + @" = 0.0 
" + _10017 + @" = 0.0 
" + _10018 + @" = 0.0 
" + _10019 + @" = 0.0 
" + _10020 + @" = 0.0 
" + _10021 + @" = 0.0 
" + _10022 + @" = 0.0 
" + _10023 + @" = 0.0 
" + _10024 + @" = 0.0 
" + _10025 + @" = 0.0 
" + _10026 + @" = 0.0 
" + _10027 + @" = 0.0
" + _10011 + @" = 0.0 
" + _10015 + @" = 0.0 
" + _10016 + @" = 0.0 
" + _10017 + @" = 0.0 
" + _10029 + @" = 0 
" + _10030 + @" = 0 
" + _10031 + @" = 0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'LACS1' 
jf @CLOTH_577 
04AE: " + Seller_Model + @" = 211 
" + _10028 + @" = -371 

:CLOTH_577
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSCHP' 
jf @CLOTH_618 
04AE: " + Seller_Model + @" = 211 
" + _10028 + @" = -370 

:CLOTH_618
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSSPRT' 
jf @CLOTH_659 
04AE: " + Seller_Model + @" = 217 
" + _10028 + @" = -372 

:CLOTH_659
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CLOTHGP' 
jf @CLOTH_700 
04AE: " + Seller_Model + @" = 211 
" + _10028 + @" = -373 

:CLOTH_700
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSDESGN' 
jf @CLOTH_741 
04AE: " + Seller_Model + @" = 211 
" + _10028 + @" = -374 

:CLOTH_741
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSEXL' 
jf @CLOTH_782 
04AE: " + Seller_Model + @" = 217 
" + _10028 + @" = -375 

:CLOTH_782
Model.Load(" + _10028 + @")
Model.Load(" + Seller_Model + @")
03CF: load_wav 20802 as 4 
038B: load_requested_models 
set_wb_check_to 0 

:CLOTH_816
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @CLOTH_6946 
if 
8844:   not string " + Current_Shop_GXT_Name + @" empty 
jf @CLOTH_6932 
if 
  " + _9990 + @" > 0 
jf @CLOTH_945 
0489: set_actor " + PlayerActor + @" muted 1 
if 
0A0F:   new_language_set 
jf @CLOTH_945 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
08DA: remove_panel " + _2423 + @" 
08DA: remove_panel " + _2421 + @" 
08DA: remove_panel " + _2417 + @" 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _2422 + @" = 0 
" + _2418 + @" = 0 
09FB: " + Current_Language + @" = current_language 

:CLOTH_945
if 
  " + _9990 + @" == 0 
jf @CLOTH_1900 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'LACS1' 
jf @CLOTH_1098 
" + _10004 + @" = 0.0 
" + _10005 + @" = 0.0 
" + _10006 + @" = 0.0 
" + _10024 + @" = 203.528 
" + _10025 + @" = -41.644 
" + _10026 + @" = 1000.852 
" + _10027 + @" = 180.0 
" + _10011 + @" = 90.0 
" + _10007 + @" = 0.0 
05A9: " + _9984 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9999 + @" 
" + _9990 + @" = 1 

:CLOTH_1098
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSCHP' 
jf @CLOTH_1233 
" + _10004 + @" = 2.85 
" + _10005 + @" = -57.534 
" + _10006 + @" = 3.26 
" + _10024 + @" = 208.806 
" + _10025 + @" = -98.713 
" + _10026 + @" = 1004.297 
" + _10027 + @" = 180.0 
" + _10011 + @" = 90.0 
" + _10007 + @" = 0.0 
05A9: " + _9984 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9999 + @" 
" + _9990 + @" = 1 

:CLOTH_1233
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSSPRT' 
jf @CLOTH_1368 
" + _10004 + @" = -12.653 
" + _10005 + @" = -90.758 
" + _10006 + @" = 1.477 
" + _10024 + @" = 207.018 
" + _10025 + @" = -127.782 
" + _10026 + @" = 1002.555 
" + _10027 + @" = 180.0 
" + _10011 + @" = 90.0 
" + _10007 + @" = 0.0 
05A9: " + _9984 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9999 + @" 
" + _9990 + @" = 1 

:CLOTH_1368
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CLOTHGP' 
jf @CLOTH_1503 
" + _10004 + @" = -33.204 
" + _10005 + @" = -46.245 
" + _10006 + @" = 0.0 
" + _10024 + @" = 161.56 
" + _10025 + @" = -81.369 
" + _10026 + @" = 1000.859 
" + _10027 + @" = 180.0 
" + _10011 + @" = 90.0 
" + _10007 + @" = 0.0 
05A9: " + _9984 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9999 + @" 
" + _9990 + @" = 1 

:CLOTH_1503
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSDESGN' 
jf @CLOTH_1765 
if 
  " + Mansion_Total_Passed_Missions + @" > 3 
jf @CLOTH_1655 
09A9: get_string ""TSHIRTLOCGREY"" CRC32_to " + _10031 + @" 
08C8: set_shopping_item_with_textureCRC " + _10031 + @" price_to 15 
09A9: get_string ""BASKBALLLOC"" CRC32_to " + _10031 + @" 
08C8: set_shopping_item_with_textureCRC " + _10031 + @" price_to 20 
09A9: get_string ""TSHIRTMADDGREY"" CRC32_to " + _10031 + @" 
08C8: set_shopping_item_with_textureCRC " + _10031 + @" price_to 300 
09A9: get_string ""TSHIRTMADDGRN"" CRC32_to " + _10031 + @" 
08C8: set_shopping_item_with_textureCRC " + _10031 + @" price_to 300 

:CLOTH_1655
" + _10004 + @" = -5.806 
" + _10005 + @" = 36.733 
" + _10006 + @" = -0.815 
" + _10024 + @" = 204.836 
" + _10025 + @" = -7.328 
" + _10026 + @" = 1000.258 
" + _10027 + @" = 270.0 
" + _10011 + @" = 90.0 
" + _10007 + @" = 0.0 
05A9: " + _9984 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9999 + @" 
" + _9990 + @" = 1 

:CLOTH_1765
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSEXL' 
jf @CLOTH_1900 
" + _10004 + @" = 1.2 
" + _10005 + @" = -114.524 
" + _10006 + @" = -1.51 
" + _10024 + @" = 204.366 
" + _10025 + @" = -157.789 
" + _10026 + @" = 999.563 
" + _10027 + @" = 180.0 
" + _10011 + @" = 90.0 
" + _10007 + @" = 0.0 
05A9: " + _9984 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9999 + @" 
" + _9990 + @" = 1 

:CLOTH_1900
if 
  " + _9990 + @" == 1 
jf @CLOTH_2351 
03F0: enable_text_draw 1 
08F8: display_stat_update_box 0 
" + _10012 + @" = 212.8715 
0059: " + _10012 + @" += " + _10004 + @" 
" + _10013 + @" = -42.8156 
0059: " + _10013 + @" += " + _10005 + @" 
" + _10014 + @" = 1002.116 
0059: " + _10014 + @" += " + _10006 + @" 
" + _10015 + @" = 213.4791 
0059: " + _10015 + @" += " + _10004 + @" 
" + _10016 + @" = -42.0238 
0059: " + _10016 + @" += " + _10005 + @" 
" + _10017 + @" = 1002.053 
0059: " + _10017 + @" += " + _10006 + @" 
" + _10018 + @" = 214.5148 
0059: " + _10018 + @" += " + _10004 + @" 
" + _10019 + @" = -41.6106 
0059: " + _10019 + @" += " + _10005 + @" 
" + _10020 + @" = 1002.494 
0059: " + _10020 + @" += " + _10006 + @" 
" + _10021 + @" = 214.5367 
0059: " + _10021 + @" += " + _10004 + @" 
" + _10022 + @" = -40.6175 
0059: " + _10022 + @" += " + _10005 + @" 
" + _10023 + @" = 1002.609 
0059: " + _10023 + @" += " + _10006 + @" 
" + _10008 + @" = 214.622 
0059: " + _10008 + @" += " + _10004 + @" 
" + _10009 + @" = -40.652 
0059: " + _10009 + @" += " + _10005 + @" 
" + _10010 + @" = 1001.033 
0059: " + _10010 + @" += " + _10006 + @" 
" + _10001 + @" = 213.874 
0059: " + _10001 + @" += " + _10004 + @" 
" + _10002 + @" = -39.811 
0059: " + _10002 + @" += " + _10005 + @" 
" + _10003 + @" = 1002.2 
0059: " + _10003 + @" += " + _10006 + @" 
" + _9981 + @" = Actor.Create(CivMale, " + Seller_Model + @", " + _10024 + @", " + _10025 + @", " + _10026 + @")
02A9: set_actor " + _9981 + @" immune_to_nonplayer 1 
060B: set_actor " + _9981 + @" decision_maker_to 65542 
Actor.Angle(" + _9981 + @") = " + _10027 + @"
" + _9986 + @" = 0 
" + _9989 + @" = Object.Init(" + _10028 + @", " + _10001 + @", " + _10002 + @", " + _10003 + @")
Object.Angle(" + _9989 + @") = " + _10007 + @"
0947: actor " + _9981 + @" speak_from_audio_table 332 store_spoken_phrase_id_to " + _10081 + @" 
" + Show_Shop_Sphere + @" = 1 
" + _9990 + @" = 2 

:CLOTH_2351
if 
  " + _9990 + @" == 2 
jf @CLOTH_2767 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_2400 
gosub @CLOTH_7234 

:CLOTH_2400
if 
   not Actor.Dead(" + _9981 + @")
jf @CLOTH_2722 
if 
  " + _9986 + @" == 0 
jf @CLOTH_2670 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + _9981 + @" 
031D:   actor " + _9981 + @" hit_by_weapon 57 
  " + _1258 + @" == 1 
jf @CLOTH_2504 
0947: actor " + _9981 + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _10081 + @" 
05C4: AS_actor " + _9981 + @" hands_up -2 ms 
" + _9986 + @" = 1 
jump @CLOTH_2577 

:CLOTH_2504
" + Show_Shop_Sphere + @" = 1 
if 
0102:   actor " + PlayerActor + @" in_sphere " + _10008 + @" " + _10009 + @" " + _10010 + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @CLOTH_2577 
if 
   Player.Controllable(" + PlayerChar + @")
jf @CLOTH_2577 
" + _9990 + @" = 3 

:CLOTH_2577
if 
  " + _9988 + @" == 0 
jf @CLOTH_2663 
if 
0105:   actor " + PlayerActor + @" near_actor " + _9981 + @" radius 8.0 8.0 3.0 sphere 0 on_foot 
jf @CLOTH_2656 
0947: actor " + _9981 + @" speak_from_audio_table 328 store_spoken_phrase_id_to " + _10081 + @" 
" + _9988 + @" = 1 
jump @CLOTH_2663 

:CLOTH_2656
" + _9988 + @" = 0 

:CLOTH_2663
jump @CLOTH_2715 

:CLOTH_2670
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_2708 
gosub @CLOTH_7234 

:CLOTH_2708
jump @CLOTH_816 

:CLOTH_2715
jump @CLOTH_2767 

:CLOTH_2722
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_2760 
gosub @CLOTH_7234 

:CLOTH_2760
jump @CLOTH_816 

:CLOTH_2767
if 
  " + _9990 + @" == 3 
jf @CLOTH_2902 
if 
   Player.Defined(" + PlayerChar + @")
jf @CLOTH_2888 
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 1.0 
0581: enable_radar 0 
TIMERA = 0 
" + _9998 + @" = 0 
" + _9990 + @" = 4 
jump @CLOTH_2902 

:CLOTH_2888
gosub @CLOTH_7234 
jump @CLOTH_816 

:CLOTH_2902
if 
  " + _9990 + @" == 4 
jf @CLOTH_3415 
if 
   Actor.Dead(" + _9981 + @")
jf @CLOTH_2981 
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_2974 
gosub @CLOTH_7234 

:CLOTH_2974
jump @CLOTH_816 

:CLOTH_2981
if 
  " + _9998 + @" == 0 
jf @CLOTH_3322 
if 
  TIMERA >= 300 
jf @CLOTH_3322 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
08C7: put_actor " + PlayerActor + @" at " + _10008 + @" " + _10009 + @" " + _10010 + @" dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = " + _10011 + @"
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
Actor.StorePos(" + _9981 + @", " + _2755 + @", " + _2756 + @", " + _2757 + @")
if or
8044:   not  " + _2755 + @" == " + _10024 + @" 
8044:   not  " + _2756 + @" == " + _10025 + @" 
8044:   not  " + _2757 + @" == " + _10026 + @" 
jf @CLOTH_3132 
Actor.PutAt(" + _9981 + @", " + _10024 + @", " + _10025 + @", " + _10026 + @")
Actor.Angle(" + _9981 + @") = " + _10027 + @"

:CLOTH_3132
Camera.SetPosition(" + _10012 + @", " + _10013 + @", " + _10014 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _10015 + @", " + _10016 + @", " + _10017 + @", 2)
0793: save_player_clothes 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_IN"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9991 + @" = 0.0 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_IN""
jf @CLOTH_3260 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation ""CLO_IN"" time 

:CLOTH_3260
if 
03CA:   object " + _9989 + @" exists 
jf @CLOTH_3315 
075A: set_object " + _9989 + @" animation ""CLO_POSE_OUT_O"" IFP_file ""CLOTHES"" 4.0 lockF 0 loop 1 

:CLOTH_3315
" + _9998 + @" = 1 

:CLOTH_3322
if 
  " + _9998 + @" == 1 
jf @CLOTH_3415 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_IN""
jf @CLOTH_3380 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation ""CLO_IN"" time 

:CLOTH_3380
if 
  " + _9991 + @" == 1.0 
jf @CLOTH_3415 
" + _9998 + @" = 0 
" + _9990 + @" = 5 

:CLOTH_3415
if 
  " + _9990 + @" == 5 
jf @CLOTH_4103 
if 
   Actor.Dead(" + _9981 + @")
jf @CLOTH_3494 
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_3487 
gosub @CLOTH_7234 

:CLOTH_3487
jump @CLOTH_816 

:CLOTH_3494
if 
  " + _2420 + @" == 0 
jf @CLOTH_3537 
if 
  1 > " + _9998 + @" 
jf @CLOTH_3537 
gosub @CLOTH_8450 

:CLOTH_3537
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9998 + @" == 0 
jf @CLOTH_3610 
if 
00E1:   player 0 pressed_key 16 
jf @CLOTH_3586 
" + _9998 + @" = 1 

:CLOTH_3586
if 
00E1:   player 0 pressed_key 15 
jf @CLOTH_3610 
" + _9998 + @" = 2 

:CLOTH_3610
if 
  " + _9998 + @" == 1 
jf @CLOTH_3731 
if 
80E1:   not player 0 pressed_key 16 
jf @CLOTH_3731 
08D8: " + _2516 + @" = panel " + _2419 + @" selected_row 
if 
  0 > " + _2516 + @" 
jf @CLOTH_3678 
" + _2516 + @" = 0 

:CLOTH_3678
gosub @CLOTH_7594 
" + _9990 + @" = 6 
if 
  " + _2420 + @" == 1 
jf @CLOTH_3724 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:CLOTH_3724
" + _9998 + @" = 0 

:CLOTH_3731
if 
  " + _9998 + @" == 2 
jf @CLOTH_3939 
if 
80E1:   not player 0 pressed_key 15 
jf @CLOTH_3939 
if 
  " + _2420 + @" == 1 
jf @CLOTH_3798 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:CLOTH_3798
if 
  " + _2424 + @" == 1 
jf @CLOTH_3830 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:CLOTH_3830
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_OUT"" IFP ""CLOTHES"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
" + _9991 + @" = 0.0 
if 
03CA:   object " + _9989 + @" exists 
jf @CLOTH_3932 
075A: set_object " + _9989 + @" animation ""CLO_POSE_IN_O"" IFP_file ""CLOTHES"" 1000.0 lockF 0 loop 1 

:CLOTH_3932
" + _9998 + @" = 5 

:CLOTH_3939
if 
  " + _9998 + @" == 5 
jf @CLOTH_4027 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_OUT""
jf @CLOTH_3999 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation ""CLO_OUT"" time 

:CLOTH_3999
if 
  " + _9991 + @" == 1.0 
jf @CLOTH_4027 
" + _9998 + @" = 6 

:CLOTH_4027
if 
  " + _9998 + @" == 6 
jf @CLOTH_4103 
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0581: enable_radar 1 
0947: actor " + _9981 + @" speak_from_audio_table 331 store_spoken_phrase_id_to " + _10081 + @" 
" + _10029 + @" = 0 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9990 + @" = 8 

:CLOTH_4103
if 
  " + _9990 + @" == 6 
jf @CLOTH_5223 
if 
   Actor.Dead(" + _9981 + @")
jf @CLOTH_4182 
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_4175 
gosub @CLOTH_7234 

:CLOTH_4175
jump @CLOTH_816 

:CLOTH_4182
if 
  " + _2424 + @" == 0 
jf @CLOTH_4225 
if 
  2 > " + _9998 + @" 
jf @CLOTH_4225 
gosub @CLOTH_9020 

:CLOTH_4225
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9998 + @" == 0 
jf @CLOTH_4583 
if 
00E1:   player 0 pressed_key 15 
jf @CLOTH_4274 
" + _9998 + @" = 1 

:CLOTH_4274
if 
00E1:   player 0 pressed_key 16 
jf @CLOTH_4583 
" + _10029 + @" = 0 
08D7: " + _2517 + @" = panel " + _2423 + @" active_row 
if 
  0 > " + _2517 + @" 
jf @CLOTH_4331 
" + _2517 + @" = 0 

:CLOTH_4331
0084: " + Selected_Menu_Item + @" = " + tmp_2438 + @"(" + _2517 + @",12i) 
0084: " + _9982 + @" = " + tmp_2426 + @"(" + _2517 + @",12i) 
0084: " + ShoppingItem_ModelCRC + @" = " + tmp_2474 + @"(" + _2517 + @",12i) 
0084: " + ShoppingItem_BodyPart + @" = " + tmp_2486 + @"(" + _2517 + @",12i) 
05A9: " + _9979 + @" = " + tmp_2450 + @"(" + _2517 + @",12s) 
if or
04A3:   " + ShoppingItem_BodyPart + @" == 13 
04A3:   " + ShoppingItem_BodyPart + @" == 14 
04A3:   " + ShoppingItem_BodyPart + @" == 15 
04A3:   " + ShoppingItem_BodyPart + @" == 16 
jf @CLOTH_4476 
Camera.SetPosition(" + _10018 + @", " + _10019 + @", " + _10020 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _10021 + @", " + _10022 + @", " + _10023 + @", 2)
jump @CLOTH_4544 

:CLOTH_4476
if or
04A3:   " + _2547 + @" == 0 
04A3:   " + _2547 + @" == 2 
jf @CLOTH_4505 
03D1: play_wav 4 

:CLOTH_4505
Camera.SetPosition(" + _10012 + @", " + _10013 + @", " + _10014 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _10015 + @", " + _10016 + @", " + _10017 + @", 2)

:CLOTH_4544
if 
  " + _2424 + @" == 1 
jf @CLOTH_4576 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:CLOTH_4576
" + _9998 + @" = 2 

:CLOTH_4583
if 
  " + _9998 + @" == 1 
jf @CLOTH_4689 
if 
80E1:   not player 0 pressed_key 15 
jf @CLOTH_4689 
" + _9998 + @" = 0 
" + _9990 + @" = 5 
if 
  " + _2424 + @" == 1 
jf @CLOTH_4664 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:CLOTH_4664
if 
  " + _2420 + @" == 0 
jf @CLOTH_4689 
gosub @CLOTH_8450 

:CLOTH_4689
if 
  " + _9998 + @" == 2 
jf @CLOTH_4746 
if 
03D2:   wav 4 ended 
jf @CLOTH_4746 
if 
80E1:   not player 0 pressed_key 16 
jf @CLOTH_4746 
" + _9998 + @" = 3 

:CLOTH_4746
if 
  " + _9998 + @" == 3 
jf @CLOTH_4941 
if or
04A3:   " + _2547 + @" == 0 
04A3:   " + _2547 + @" == 2 
04A3:   " + _2547 + @" == 3 
jf @CLOTH_4809 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 17 
0793: save_player_clothes 

:CLOTH_4809
0784: set_player " + PlayerChar + @" textureCRC " + Selected_Menu_Item + @" modelCRC " + ShoppingItem_ModelCRC + @" bodypart " + ShoppingItem_BodyPart + @" 
Player.Build(" + PlayerChar + @")
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_IN"" IFP ""CLOTHES"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9991 + @" = 0.0 
if 
03CA:   object " + _9989 + @" exists 
jf @CLOTH_4934 
075A: set_object " + _9989 + @" animation ""CLO_POSE_IN_O"" IFP_file ""CLOTHES"" 1000.0 lockF 0 loop 1 

:CLOTH_4934
" + _9998 + @" = 4 

:CLOTH_4941
if 
  " + _9998 + @" == 4 
jf @CLOTH_5079 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_POSE_IN""
jf @CLOTH_5009 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation ""CLO_POSE_IN"" time 

:CLOTH_5009
if 
  " + _9991 + @" == 1.0 
jf @CLOTH_5079 
0812: AS_actor " + PlayerActor + @" perform_animation " + _9994 + @" IFP ""CLOTHES"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9991 + @" = 0.0 
" + _9998 + @" = 5 

:CLOTH_5079
if 
  " + _9998 + @" == 5 
jf @CLOTH_5223 
if 
   Actor.Animation(" + PlayerActor + @") == " + _9994 + @"
jf @CLOTH_5127 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation " + _9994 + @" time 

:CLOTH_5127
if 
  " + _9991 + @" == 1.0 
jf @CLOTH_5223 
gosub @CLOTH_9570 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_LOOP"" IFP ""CLOTHES"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9991 + @" = 0.0 
" + _9990 + @" = 7 
" + _9998 + @" = 0 

:CLOTH_5223
if 
  " + _9990 + @" == 7 
jf @CLOTH_6638 
if 
   Actor.Dead(" + _9981 + @")
jf @CLOTH_5302 
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_5295 
gosub @CLOTH_7234 

:CLOTH_5295
jump @CLOTH_816 

:CLOTH_5302
" + Show_Shop_Sphere + @" = 0 
if 
  " + _9998 + @" == 0 
jf @CLOTH_5607 
if 
00E1:   player 0 pressed_key 16 
jf @CLOTH_5412 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
03D5: remove_text 'CLTHNO1'  
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _2546 + @" = 0 
" + _10030 + @" = 0 
" + _9998 + @" = 1 

:CLOTH_5412
if 
00E1:   player 0 pressed_key 15 
jf @CLOTH_5607 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
03D5: remove_text 'CLTHNO1'  
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _2546 + @" = 0 
" + _10030 + @" = 0 
gosub @CLOTH_8109 
if 
  " + _2418 + @" == 1 
jf @CLOTH_5529 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:CLOTH_5529
if 
  " + _10029 + @" == 0 
jf @CLOTH_5561 
" + _9998 + @" = 3 
jump @CLOTH_5607 

:CLOTH_5561
if 
  " + _2422 + @" == 1 
jf @CLOTH_5593 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:CLOTH_5593
" + _9998 + @" = 0 
" + _9990 + @" = 6 

:CLOTH_5607
if 
  2 > " + _9998 + @" 
jf @CLOTH_5632 
gosub @CLOTH_9570 

:CLOTH_5632
if 
  " + _9998 + @" == 1 
jf @CLOTH_6032 
if 
80E1:   not player 0 pressed_key 16 
jf @CLOTH_6032 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
if 
002C:   " + Shops_Player_Cash + @" >= " + _9982 + @" 
jf @CLOTH_5959 
if 
803A:   not  " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @CLOTH_5879 
if 
  " + _2418 + @" == 1 
jf @CLOTH_5745 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:CLOTH_5745
0790: charge_money_for_shopping_item_with_textureCRC " + Selected_Menu_Item + @" 
" + _10030 + @" = 1 
0947: actor " + _9981 + @" speak_from_audio_table 323 store_spoken_phrase_id_to " + _10081 + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
gosub @CLOTH_9945 
gosub @CLOTH_10315 
0793: save_player_clothes 
Player.Build(" + PlayerChar + @")
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_BUY"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9991 + @" = 0.0 
" + _9998 + @" = 2 
jump @CLOTH_5952 

:CLOTH_5879
if 
  " + _2545 + @" == 0 
jf @CLOTH_5952 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + _9981 + @" speak_from_audio_table 322 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'CLTHNO2' time 5000 flag 1  
" + _9998 + @" = 0 
" + _2545 + @" = 1 

:CLOTH_5952
jump @CLOTH_6032 

:CLOTH_5959
if 
  " + _2544 + @" == 0 
jf @CLOTH_6032 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + _9981 + @" speak_from_audio_table 324 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'SHOPNO' time 5000 flag 1  
" + _9998 + @" = 0 
" + _2544 + @" = 1 

:CLOTH_6032
if 
  " + _9998 + @" == 2 
jf @CLOTH_6174 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_BUY""
jf @CLOTH_6092 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation ""CLO_BUY"" time 

:CLOTH_6092
if 
  " + _9991 + @" == 1.0 
jf @CLOTH_6174 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_LOOP"" IFP ""CLOTHES"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9991 + @" = 0.0 
" + _9998 + @" = 3 

:CLOTH_6174
if 
  " + _9998 + @" == 3 
jf @CLOTH_6307 
0812: AS_actor " + PlayerActor + @" perform_animation ""CLO_POSE_OUT"" IFP ""CLOTHES"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9991 + @" = 0.0 
if 
03CA:   object " + _9989 + @" exists 
jf @CLOTH_6300 
075A: set_object " + _9989 + @" animation ""CLO_POSE_OUT_O"" IFP_file ""CLOTHES"" 1000.0 lockF 0 loop 1 

:CLOTH_6300
" + _9998 + @" = 4 

:CLOTH_6307
if 
  " + _9998 + @" == 4 
jf @CLOTH_6638 
if 
   Actor.Animation(" + PlayerActor + @") == ""CLO_POSE_OUT""
jf @CLOTH_6377 
0613: " + _9991 + @" = actor " + PlayerActor + @" animation ""CLO_POSE_OUT"" time 

:CLOTH_6377
if 
  " + _9991 + @" == 1.0 
jf @CLOTH_6638 
0794: restore_player_clothes 
Player.Build(" + PlayerChar + @")
0793: save_player_clothes 
if 
  " + _2422 + @" == 1 
jf @CLOTH_6439 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:CLOTH_6439
if 
  " + _2424 + @" == 1 
jf @CLOTH_6471 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:CLOTH_6471
if 
  " + _2418 + @" == 1 
jf @CLOTH_6503 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:CLOTH_6503
" + _10029 + @" = 1 
if 
  " + _10030 + @" == 1 
jf @CLOTH_6592 
" + _9998 + @" = 0 
" + _9990 + @" = 5 
if 
  " + _2420 + @" == 0 
jf @CLOTH_6585 
if 
  1 > " + _9998 + @" 
jf @CLOTH_6585 
gosub @CLOTH_8450 

:CLOTH_6585
jump @CLOTH_6638 

:CLOTH_6592
" + _9998 + @" = 0 
" + _9990 + @" = 6 
if 
  " + _2424 + @" == 0 
jf @CLOTH_6638 
gosub @CLOTH_8109 
gosub @CLOTH_9020 

:CLOTH_6638
if 
  " + _9990 + @" == 8 
jf @CLOTH_6925 
if 
   Actor.Dead(" + _9981 + @")
jf @CLOTH_6717 
gosub @CLOTH_6960 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9984 + @" 
jf @CLOTH_6710 
gosub @CLOTH_7234 

:CLOTH_6710
jump @CLOTH_816 

:CLOTH_6717
if 
  " + _9986 + @" == 0 
jf @CLOTH_6798 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + _9981 + @" 
031D:   actor " + _9981 + @" hit_by_weapon 57 
  " + _1258 + @" == 1 
jf @CLOTH_6798 
0947: actor " + _9981 + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _10081 + @" 
05C4: AS_actor " + _9981 + @" hands_up -2 ms 
" + _9986 + @" = 1 

:CLOTH_6798
if 
80FF:   not actor " + PlayerActor + @" sphere " + Show_Shop_Sphere + @" in_sphere " + _10008 + @" " + _10009 + @" " + _10010 + @" radius 1.0 1.0 4.0 on_foot 
jf @CLOTH_6925 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + _9990 + @" = 2 
" + _9998 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _10030 + @" = 0 
" + Show_Shop_Sphere + @" = 1 

:CLOTH_6925
jump @CLOTH_6939 

:CLOTH_6932
gosub @CLOTH_7234 

:CLOTH_6939
jump @CLOTH_6953 

:CLOTH_6946
gosub @CLOTH_7234 

:CLOTH_6953
jump @CLOTH_816 

:CLOTH_6960
if 
  " + _9990 + @" >= 1 
jf @CLOTH_6980 
03E6: remove_text_box 

:CLOTH_6980
if 
  " + _2420 + @" == 1 
jf @CLOTH_7012 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:CLOTH_7012
if 
  " + _2424 + @" == 1 
jf @CLOTH_7044 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:CLOTH_7044
if 
  " + _2422 + @" == 1 
jf @CLOTH_7076 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:CLOTH_7076
if 
  " + _2418 + @" == 1 
jf @CLOTH_7108 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:CLOTH_7108
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
03D5: remove_text 'CLTHNO1'  
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _2546 + @" = 0 
" + _9998 + @" = 0 
" + _10029 + @" = 0 
" + _10030 + @" = 0 
" + _9990 + @" = 2 
return 

:CLOTH_7234
if 
  " + _2420 + @" == 1 
jf @CLOTH_7266 
08DA: remove_panel " + _2419 + @" 
03E6: remove_text_box 
" + _2420 + @" = 0 

:CLOTH_7266
if 
  " + _2424 + @" == 1 
jf @CLOTH_7298 
08DA: remove_panel " + _2423 + @" 
03E6: remove_text_box 
" + _2424 + @" = 0 

:CLOTH_7298
if 
  " + _2422 + @" == 1 
jf @CLOTH_7330 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:CLOTH_7330
if 
  " + _2418 + @" == 1 
jf @CLOTH_7362 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:CLOTH_7362
if 
  " + _9990 + @" >= 1 
jf @CLOTH_7382 
03E6: remove_text_box 

:CLOTH_7382
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'CLTHNO2'  
03D5: remove_text 'CLTHNO1'  
" + _10029 + @" = 0 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2516 + @" = 0 
" + _2517 + @" = 0 
" + Show_Shop_Sphere + @" = 1 
" + _9988 + @" = 0 
" + _9986 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _2546 + @" = 0 
" + _10030 + @" = 0 
" + _9998 + @" = 0 
" + _9990 + @" = 0 
Object.Destroy(" + _9989 + @")
Model.Destroy(" + _10028 + @")
Actor.DestroyInstantly(" + _9981 + @")
Model.Destroy(" + Seller_Model + @")
03F0: enable_text_draw 0 
0581: enable_radar 1 
08F8: display_stat_update_box 1 
09BD: allow_other_threads_to_display_text_boxes 0 
040D: unload_wav 4 
if 
   Player.Defined(" + PlayerChar + @")
jf @CLOTH_7590 
0489: set_actor " + PlayerActor + @" muted 0 

:CLOTH_7590
end_thread 
return 

:CLOTH_7594
if 
  " + _2516 + @" == 0 
jf @CLOTH_7668 
" + _2513 + @" = 0 
04AE: " + _2547 + @" = 0 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_TORSO"" 

:CLOTH_7668
if 
  " + _2516 + @" == 1 
jf @CLOTH_7741 
" + _2513 + @" = 2 
04AE: " + _2547 + @" = 2 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_LEGS"" 

:CLOTH_7741
if 
  " + _2516 + @" == 2 
jf @CLOTH_7815 
" + _2513 + @" = 3 
04AE: " + _2547 + @" = 3 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_SHOES"" 

:CLOTH_7815
if 
  " + _2516 + @" == 3 
jf @CLOTH_7889 
" + _2513 + @" = 13 
04AE: " + _2547 + @" = 13 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_TORSO"" 

:CLOTH_7889
if 
  " + _2516 + @" == 4 
jf @CLOTH_7963 
" + _2513 + @" = 14 
04AE: " + _2547 + @" = 14 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_WATCH"" 

:CLOTH_7963
if 
  " + _2516 + @" == 5 
jf @CLOTH_8035 
" + _2513 + @" = 15 
04AE: " + _2547 + @" = 15 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_HAT"" 

:CLOTH_8035
if 
  " + _2516 + @" == 6 
jf @CLOTH_8107 
" + _2513 + @" = 16 
04AE: " + _2547 + @" = 16 
08F7: get_player " + PlayerChar + @" bodypart " + _2547 + @" textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
gosub @CLOTH_8109 
06D1: " + _9994 + @" = ""CLO_POSE_HAT"" 

:CLOTH_8107
return 

:CLOTH_8109
" + _2514 + @" = 0 
" + _10000 + @" = 0 

:CLOTH_8123
if 
001C:   " + _9999 + @" > " + _2514 + @" 
jf @CLOTH_8368 
0760: store_shopping_data_index " + _2514 + @" textureCRC_to " + Selected_Menu_Item + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 0 store_to " + ShoppingItem_ModelCRC + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 1 store_to " + ShoppingItem_BodyPart + @" 
if 
003A:   " + ShoppingItem_BodyPart + @" == " + _2513 + @" 
jf @CLOTH_8354 
0084: " + tmp_2438 + @"(" + _10000 + @",12i) = " + Selected_Menu_Item + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _9979 + @" 
0761: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" price_to " + _9982 + @" 
0084: " + tmp_2426 + @"(" + _10000 + @",12i) = " + _9982 + @" 
05A9: " + tmp_2450 + @"(" + _10000 + @",12s) = " + _9979 + @" 
0084: " + tmp_2474 + @"(" + _10000 + @",12i) = " + ShoppingItem_ModelCRC + @" 
0084: " + tmp_2486 + @"(" + _10000 + @",12i) = " + ShoppingItem_BodyPart + @" 
if 
003A:   " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @CLOTH_8302 
" + tmp_2498 + @"(" + _10000 + @",12i) = 0 
jump @CLOTH_8347 

:CLOTH_8302
if 
0942:   item_with_textureCRC " + Selected_Menu_Item + @" is_clothing 
jf @CLOTH_8336 
" + tmp_2498 + @"(" + _10000 + @",12i) = 1 
jump @CLOTH_8347 

:CLOTH_8336
" + tmp_2498 + @"(" + _10000 + @",12i) = 2 

:CLOTH_8347
" + _10000 + @" += 1 

:CLOTH_8354
" + _2514 + @" += 1 
jump @CLOTH_8123 

:CLOTH_8368
0084: " + _2515 + @" = " + _10000 + @" 

:CLOTH_8376
if 
  12 > " + _2515 + @" 
jf @CLOTH_8448 
" + tmp_2438 + @"(" + _2515 + @",12i) = -1 
" + tmp_2426 + @"(" + _2515 + @",12i) = 0 
05A9: " + tmp_2450 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @CLOTH_8376 

:CLOTH_8448
return 

:CLOTH_8450
if 
  " + _2420 + @" == 0 
jf @CLOTH_9018 
0512: show_permanent_text_box 'CLOTHA'  
05A9: " + _2518 + @" = 'TORSO' 
05A9: " + _2520 + @" = 'LEGS' 
05A9: " + _2522 + @" = 'FEET' 
05A9: " + _2524 + @" = 'CHAINS' 
05A9: " + _2526 + @" = 'WATCHES' 
05A9: " + _2528 + @" = 'SHADES' 
05A9: " + _2530 + @" = 'HATS' 
05A9: " + _2532 + @" = 'DUMMY' 
05A9: " + _2534 + @" = 'DUMMY' 
05A9: " + _2536 + @" = 'DUMMY' 
05A9: " + _2538 + @" = 'DUMMY' 
05A9: " + _2540 + @" = 'DUMMY' 
if 
04A3:   " + Current_Language + @" == 0 
jf @CLOTH_8709 
08D4: " + _2419 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_8950 

:CLOTH_8709
if 
04A3:   " + Current_Language + @" == 1 
jf @CLOTH_8771 
08D4: " + _2419 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_8950 

:CLOTH_8771
if 
04A3:   " + Current_Language + @" == 2 
jf @CLOTH_8833 
08D4: " + _2419 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_8950 

:CLOTH_8833
if 
04A3:   " + Current_Language + @" == 3 
jf @CLOTH_8895 
08D4: " + _2419 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_8950 

:CLOTH_8895
if 
04A3:   " + Current_Language + @" == 4 
jf @CLOTH_8950 
08D4: " + _2419 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:CLOTH_8950
08D6: set_panel " + _2419 + @" column 0 alignment 1 
08DB: set_panel " + _2419 + @" column 0 header 'DUMMY' data " + _2518 + @" " + _2520 + @" " + _2522 + @" " + _2524 + @" " + _2526 + @" " + _2528 + @" " + _2530 + @" " + _2532 + @" " + _2534 + @" " + _2536 + @" " + _2538 + @" " + _2540 + @" 
" + _2420 + @" = 1 

:CLOTH_9018
return 

:CLOTH_9020
if 
  " + _2424 + @" == 0 
jf @CLOTH_9568 
0512: show_permanent_text_box 'CLOTHB'  
if 
04A3:   " + Current_Language + @" == 0 
jf @CLOTH_9111 
08D4: " + _2423 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_9352 

:CLOTH_9111
if 
04A3:   " + Current_Language + @" == 1 
jf @CLOTH_9173 
08D4: " + _2423 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_9352 

:CLOTH_9173
if 
04A3:   " + Current_Language + @" == 2 
jf @CLOTH_9235 
08D4: " + _2423 + @" = create_panel_with_title 'CLOTCHO' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_9352 

:CLOTH_9235
if 
04A3:   " + Current_Language + @" == 3 
jf @CLOTH_9297 
08D4: " + _2423 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @CLOTH_9352 

:CLOTH_9297
if 
04A3:   " + Current_Language + @" == 4 
jf @CLOTH_9352 
08D4: " + _2423 + @" = create_panel_with_title 'CLOTCHO' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:CLOTH_9352
08D6: set_panel " + _2423 + @" column 0 alignment 1 
08DB: set_panel " + _2423 + @" column 0 header 'DUMMY' data s" + tmp_2450 + @"[0] s" + tmp_2450 + @"[1] s" + tmp_2450 + @"[2] s" + tmp_2450 + @"[3] s" + tmp_2450 + @"[4] s" + tmp_2450 + @"[5] s" + tmp_2450 + @"[6] s" + tmp_2450 + @"[7] s" + tmp_2450 + @"[8] s" + tmp_2450 + @"[9] s" + tmp_2450 + @"[10] s" + tmp_2450 + @"[11] 
" + _2515 + @" = 0 

:CLOTH_9420
if 
001C:   " + _10000 + @" > " + _2515 + @" 
jf @CLOTH_9561 
if 
  " + tmp_2498 + @"(" + _2515 + @",12i) == 0 
jf @CLOTH_9488 
0A23: set_panel " + _2423 + @" row " + _2515 + @" shopping_item_bought 0 
08D9: set_panel " + _2423 + @" row " + _2515 + @" enable 0 
jump @CLOTH_9547 

:CLOTH_9488
if 
  " + tmp_2498 + @"(" + _2515 + @",12i) == 1 
jf @CLOTH_9527 
0A23: set_panel " + _2423 + @" row " + _2515 + @" shopping_item_bought 1 
jump @CLOTH_9547 

:CLOTH_9527
0A23: set_panel " + _2423 + @" row " + _2515 + @" shopping_item_bought 0 
08D9: set_panel " + _2423 + @" row " + _2515 + @" enable 1 

:CLOTH_9547
" + _2515 + @" += 1 
jump @CLOTH_9420 

:CLOTH_9561
" + _2424 + @" = 1 

:CLOTH_9568
return 

:CLOTH_9570
if 
  " + _2418 + @" == 0 
jf @CLOTH_9943 
0512: show_permanent_text_box 'CLOTHC'  
08D4: " + _2417 + @" = create_panel_with_title 'CLOTCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2417 + @" column 0 alignment 1 
08DB: set_panel " + _2417 + @" column 0 header 'CLOTCHO' data " + _9979 + @" 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2417 + @" column 1 alignment 2 
08DB: set_panel " + _2417 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2417 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + _9982 + @"  
09DB: set_panel " + _2417 + @" column 0 width 140 
09DB: set_panel " + _2417 + @" column 1 width 46 
" + _2418 + @" = 1 

:CLOTH_9943
return 

:CLOTH_9945
if 
  " + _2422 + @" == 0 
jf @CLOTH_10313 
08D4: " + _2421 + @" = create_panel_with_title 'CLOTCHO' position 29.0 25.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2421 + @" column 0 alignment 1 
08DB: set_panel " + _2421 + @" column 0 header 'CLOTCHO' data 'BOUGHT' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2421 + @" column 1 alignment 2 
08DB: set_panel " + _2421 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2421 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + _9982 + @"  
09DB: set_panel " + _2421 + @" column 0 width 140 
09DB: set_panel " + _2421 + @" column 1 width 46 
" + _2422 + @" = 1 

:CLOTH_10313
return 

:CLOTH_10315
if 
  " + _2549 + @" == 0 
jf @CLOTH_10365 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSCHP' 
jf @CLOTH_10365 
" + _2549 + @" = 1 

:CLOTH_10365
if 
  " + _2550 + @" == 0 
jf @CLOTH_10415 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSSPRT' 
jf @CLOTH_10415 
" + _2550 + @" = 1 

:CLOTH_10415
if 
  " + _2551 + @" == 0 
jf @CLOTH_10465 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'LACS1' 
jf @CLOTH_10465 
" + _2551 + @" = 1 

:CLOTH_10465
if 
  " + _2552 + @" == 0 
jf @CLOTH_10515 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CLOTHGP' 
jf @CLOTH_10515 
" + _2552 + @" = 1 

:CLOTH_10515
if 
  " + _2553 + @" == 0 
jf @CLOTH_10565 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSDESGN' 
jf @CLOTH_10565 
" + _2553 + @" = 1 

:CLOTH_10565
if 
  " + _2554 + @" == 0 
jf @CLOTH_10615 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'CSEXL' 
jf @CLOTH_10615 
" + _2554 + @" = 1 

:CLOTH_10615
return 
end_thread" );
            }

        }

    }

}