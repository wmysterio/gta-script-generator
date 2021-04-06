using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class JFUD : External {

            public override void START( LabelJump label ) {
                AppendLine( @"" + _675 + @" = 0 
" + _2751 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2544 + @" = 0 
" + JFUD_X_Offset + @" = 0.0 
" + JFUD_Y_Offset + @" = 0.0 
" + JFUD_Z_Offset + @" = 0.0 
" + _10064 + @" = 0.0 
" + JFUD_X_Camera + @" = 0.0 
" + JFUD_Y_Camera + @" = 0.0 
" + JFUD_Z_Camera + @" = 0.0 
" + JFUD_X_Aim_Camera + @" = 0.0 
" + JFUD_Y_Aim_Camera + @" = 0.0 
" + JFUD_Z_Aim_Camera + @" = 0.0 
" + _10075 + @" = 0.0 
" + _10076 + @" = 0.0 
" + _10077 + @" = 0.0 
" + _10078 + @" = 0.0 
" + _10079 + @" = 0.0 
" + _10080 + @" = 0.0 
" + _10056 + @" = 0 
" + _10055 + @" = 0.0 
" + _10049 + @" = 0.0 
" + _10050 + @" = 0.0 
" + _10051 + @" = 0.0 
" + _10041 + @" = 0 
" + _10035 + @" = 0 
" + _10045 + @" = 0 
" + _10047 + @" = 0 
" + flag_Player_Attack_Food_Seller + @" = 0 
" + _10052 + @" = 0.0 
" + Show_Shop_Sphere + @" = 1 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @JFUD_358 
04AE: " + Seller_Model + @" = 155 
" + JFUD_LOW_Food_Model + @" = -376 
" + JFUD_MED_Food_Model + @" = -377 
" + JFUD_HIGH_Food_Model + @" = -57 
" + JFUD_HEALTHY_Food_Model + @" = -378 

:JFUD_358
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDCHICK' 
jf @JFUD_423 
04AE: " + Seller_Model + @" = 167 
" + JFUD_LOW_Food_Model + @" = -379 
" + JFUD_MED_Food_Model + @" = -380 
" + JFUD_HIGH_Food_Model + @" = -381 
" + JFUD_HEALTHY_Food_Model + @" = -382 

:JFUD_423
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDBURG' 
jf @JFUD_487 
04AE: " + Seller_Model + @" = 205 
" + JFUD_LOW_Food_Model + @" = -383 
" + JFUD_MED_Food_Model + @" = -384 
" + JFUD_HIGH_Food_Model + @" = -60 
" + JFUD_HEALTHY_Food_Model + @" = -385 

:JFUD_487
Model.Load(" + JFUD_LOW_Food_Model + @")
Model.Load(" + JFUD_MED_Food_Model + @")
Model.Load(" + JFUD_HIGH_Food_Model + @")
Model.Load(" + JFUD_HEALTHY_Food_Model + @")
03CF: load_wav 1828 as 4 
Model.Load(" + Seller_Model + @")
038B: load_requested_models 
set_wb_check_to 0 
if 
  " + _10041 + @" == 1000000 
jf @JFUD_563 
" + JFUD_Selected_Food + @" = Object.Create(" + Selected_Menu_Item + @", " + X_Start_Anim_Food + @", " + Y_Start_Anim_Food + @", " + Z_Start_Anim_Food + @")

:JFUD_563
jump @JFUD_574

:JFUD_574
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @JFUD_9696 
if 
8844:   not string " + Current_Shop_GXT_Name + @" empty 
jf @JFUD_9682 
if 
  " + JFUD_Stage + @" > 0 
jf @JFUD_672 
if 
0A0F:   new_language_set 
jf @JFUD_672 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
08DA: remove_panel " + _2421 + @" 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
09FB: " + Current_Language + @" = current_language 

:JFUD_672
if 
  " + JFUD_Stage + @" == 0 
jf @JFUD_1005 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @JFUD_795 
075F: store_shopping_data_entries_number_to " + _10036 + @" 
" + JFUD_X_Offset + @" = 0.0 
" + JFUD_Y_Offset + @" = 0.0 
" + JFUD_Z_Offset + @" = 0.0 
" + _10064 + @" = 0.0 
" + _684 + @" = 0.0 
" + _685 + @" = 2.5 
05A9: " + _10043 + @" = " + Current_Shop_GXT_Name + @" 
" + JFUD_Stage + @" = 1 

:JFUD_795
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDCHICK' 
jf @JFUD_900 
075F: store_shopping_data_entries_number_to " + _10036 + @" 
" + JFUD_X_Offset + @" = -5.211 
" + JFUD_Y_Offset + @" = 112.784 
" + JFUD_Z_Offset + @" = 0.3 
" + _10064 + @" = 0.0 
" + _684 + @" = 0.0 
" + _685 + @" = 2.5 
05A9: " + _10043 + @" = " + Current_Shop_GXT_Name + @" 
" + JFUD_Stage + @" = 1 

:JFUD_900
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDBURG' 
jf @JFUD_1005 
075F: store_shopping_data_entries_number_to " + _10036 + @" 
" + _684 + @" = 0.0 
" + _685 + @" = 2.5 
" + JFUD_X_Offset + @" = 1.566 
" + JFUD_Y_Offset + @" = 51.419 
" + JFUD_Z_Offset + @" = 0.01 
" + _10064 + @" = 0.0 
05A9: " + _10043 + @" = " + Current_Shop_GXT_Name + @" 
" + JFUD_Stage + @" = 1 

:JFUD_1005
if 
  " + JFUD_Stage + @" == 1 
jf @JFUD_1427 
03F0: enable_text_draw 1 
08F8: display_stat_update_box 0 
" + JFUD_X_Food_Seller + @" = 374.0 
0059: " + JFUD_X_Food_Seller + @" += " + JFUD_X_Offset + @" 
" + JFUD_Y_Food_Seller + @" = -117.141 
0059: " + JFUD_Y_Food_Seller + @" += " + JFUD_Y_Offset + @" 
" + JFUD_Z_Food_Seller + @" = 1000.539 
0059: " + JFUD_Z_Food_Seller + @" += " + JFUD_Z_Offset + @" 
" + JFUD_Food_Seller_Angle + @" = 180.0 
0059: " + JFUD_Food_Seller_Angle + @" += " + _10064 + @" 
" + JFUD_X_Camera + @" = 374.0 
0059: " + JFUD_X_Camera + @" += " + JFUD_X_Offset + @" 
" + JFUD_Y_Camera + @" = -119.1869 
0059: " + JFUD_Y_Camera + @" += " + JFUD_Y_Offset + @" 
" + JFUD_Z_Camera + @" = 1002.019 
0059: " + JFUD_Z_Camera + @" += " + JFUD_Z_Offset + @" 
" + JFUD_X_Aim_Camera + @" = 373.9532 
0059: " + JFUD_X_Aim_Camera + @" += " + JFUD_X_Offset + @" 
" + JFUD_Y_Aim_Camera + @" = -118.189 
0059: " + JFUD_Y_Aim_Camera + @" += " + JFUD_Y_Offset + @" 
" + JFUD_Z_Aim_Camera + @" = 1001.975 
0059: " + JFUD_Z_Aim_Camera + @" += " + JFUD_Z_Offset + @" 
" + _10075 + @" = 374.717 
0059: " + _10075 + @" += " + JFUD_X_Offset + @" 
" + _10076 + @" = -122.55 
0059: " + _10076 + @" += " + JFUD_Y_Offset + @" 
" + _10077 + @" = 1002.572 
0059: " + _10077 + @" += " + JFUD_Z_Offset + @" 
" + _10078 + @" = 374.599 
0059: " + _10078 + @" += " + JFUD_X_Offset + @" 
" + _10079 + @" = -121.608 
0059: " + _10079 + @" += " + JFUD_Y_Offset + @" 
" + _10080 + @" = 1002.256 
0059: " + _10080 + @" += " + JFUD_Z_Offset + @" 
if 
  " + Food_Seller_Exists + @" == 0 
jf @JFUD_1420 
" + Food_Seller + @" = Actor.Create(CivMale, " + Seller_Model + @", " + JFUD_X_Food_Seller + @", " + JFUD_Y_Food_Seller + @", " + JFUD_Z_Food_Seller + @")
Actor.Angle(" + Food_Seller + @") = " + JFUD_Food_Seller_Angle + @"
02A9: set_actor " + Food_Seller + @" immune_to_nonplayer 1 
060B: set_actor " + Food_Seller + @" decision_maker_to 65542 
04C4: store_coords_to " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" from_actor " + Food_Seller + @" with_offset " + _684 + @" " + _685 + @" 0.0 
" + flag_Player_Attack_Food_Seller + @" = 0 
" + Food_Seller_Exists + @" = 1 

:JFUD_1420
" + JFUD_Stage + @" = 2 

:JFUD_1427
if 
  " + JFUD_Stage + @" == 2 
jf @JFUD_2034 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_1476 
gosub @JFUD_9887 

:JFUD_1476
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_1989 
if 
  " + flag_Player_Attack_Food_Seller + @" == 0 
jf @JFUD_1937 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + Food_Seller + @" 
031D:   actor " + Food_Seller + @" hit_by_weapon 57 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @JFUD_1587 
0947: actor " + Food_Seller + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _2563 + @" 
05C4: AS_actor " + Food_Seller + @" hands_up -2 ms 
" + FOOD_Player_Aggressive_Flag + @" = 1 
" + flag_Player_Attack_Food_Seller + @" = 1 
jump @JFUD_1930 

:JFUD_1587
if 
  11 > " + Total_Food_Eaten + @" 
jf @JFUD_1765 
" + Show_Shop_Sphere + @" = 1 
if 
0102:   actor " + PlayerActor + @" in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @JFUD_1758 
if 
   Player.Controllable(" + PlayerChar + @")
jf @JFUD_1758 
0947: actor " + Food_Seller + @" speak_from_audio_table 333 store_spoken_phrase_id_to " + _2563 + @" 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
if 
  2 > " + _88 + @" 
jf @JFUD_1751 
if 
  " + _169 + @" == 1 
jf @JFUD_1751 
if 
  2 > " + Shops_Player_Cash + @" 
jf @JFUD_1751 
Player.Money(" + PlayerChar + @") += 2

:JFUD_1751
" + JFUD_Stage + @" = 3 

:JFUD_1758
jump @JFUD_1930 

:JFUD_1765
if 
  " + _10045 + @" == 0 
jf @JFUD_1899 
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_1847 
0947: actor " + Food_Seller + @" speak_from_audio_table 322 store_spoken_phrase_id_to " + _2563 + @" 
00BC: show_text_highpriority GXT 'FOOD1' time 5000 flag 1  
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
jump @JFUD_1892 

:JFUD_1847
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_1885 
gosub @JFUD_9887 

:JFUD_1885
jump @JFUD_574 

:JFUD_1892
" + _10045 + @" = 1 

:JFUD_1899
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_1930 
gosub @JFUD_9887 

:JFUD_1930
jump @JFUD_1982 

:JFUD_1937
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_1975 
gosub @JFUD_9887 

:JFUD_1975
jump @JFUD_574 

:JFUD_1982
jump @JFUD_2034 

:JFUD_1989
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_2027 
gosub @JFUD_9887 

:JFUD_2027
jump @JFUD_574 

:JFUD_2034
if 
  " + JFUD_Stage + @" == 3 
jf @JFUD_4339 
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
09BC: put_actor " + PlayerActor + @" at " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" no_offset_and_dont_warp_gang 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
Actor.Angle(" + PlayerActor + @") = " + _10055 + @"
" + JFUD_Player_Health + @" = Actor.Health(" + PlayerActor + @")
0653: " + JFUD_STAT_Fat + @" = float_stat 21 
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 1.0 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_2401 
Actor.StorePos(" + Food_Seller + @", " + _2755 + @", " + _2756 + @", " + _2757 + @")
if or
8044:   not  " + _2755 + @" == " + JFUD_X_Food_Seller + @" 
8044:   not  " + _2756 + @" == " + JFUD_Y_Food_Seller + @" 
8044:   not  " + _2757 + @" == " + JFUD_Z_Food_Seller + @" 
jf @JFUD_2224 
Actor.PutAt(" + Food_Seller + @", " + JFUD_X_Food_Seller + @", " + JFUD_Y_Food_Seller + @", " + JFUD_Z_Food_Seller + @")
Actor.Angle(" + Food_Seller + @") = " + JFUD_Food_Seller_Angle + @"

:JFUD_2224
04C4: store_coords_to " + X_Start_Anim_Food + @" " + Y_Start_Anim_Food + @" " + Z_Start_Anim_Food + @" from_actor " + Food_Seller + @" with_offset 0.0 0.8 0.1 
if 
   not Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_2333 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_IN"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 

:JFUD_2333
0947: actor " + Food_Seller + @" speak_from_audio_table 333 store_spoken_phrase_id_to " + _10081 + @" 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_IN""
jf @JFUD_2394 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_IN"" time 

:JFUD_2394
jump @JFUD_2446 

:JFUD_2401
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_2439 
gosub @JFUD_9887 

:JFUD_2439
jump @JFUD_574 

:JFUD_2446
TIMERA = 0 

:JFUD_2453
if 
  TIMERA >= 600 
jf @JFUD_2631 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_2506 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_2506
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_2574 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_2560 
gosub @JFUD_9887 

:JFUD_2560
jump @JFUD_574 
jump @JFUD_2624 

:JFUD_2574
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_IN""
jf @JFUD_2624 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_IN"" time 

:JFUD_2624
jump @JFUD_2453 

:JFUD_2631
if 
   Player.Defined(" + PlayerChar + @")
jf @JFUD_2700 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Camera.SetPosition(" + JFUD_X_Camera + @", " + JFUD_Y_Camera + @", " + JFUD_Z_Camera + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + JFUD_X_Aim_Camera + @", " + JFUD_Y_Aim_Camera + @", " + JFUD_Z_Aim_Camera + @", 2)
jump @JFUD_2714 

:JFUD_2700
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_2714
if 
   not Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_2925 

:JFUD_2745
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_2925 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_2800 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_2800
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_2868 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_2854 
gosub @JFUD_9887 

:JFUD_2854
jump @JFUD_574 
jump @JFUD_2918 

:JFUD_2868
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_IN""
jf @JFUD_2918 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_IN"" time 

:JFUD_2918
jump @JFUD_2745 

:JFUD_2925
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_3053 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_POSE"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_3046 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_POSE"" time 

:JFUD_3046
jump @JFUD_3098 

:JFUD_3053
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_3091 
gosub @JFUD_9887 

:JFUD_3091
jump @JFUD_574 

:JFUD_3098
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_3282 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_3153 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_3153
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_3221 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_3207 
gosub @JFUD_9887 

:JFUD_3207
jump @JFUD_574 
jump @JFUD_3275 

:JFUD_3221
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_3275 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_POSE"" time 

:JFUD_3275
jump @JFUD_3098 

:JFUD_3282
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_3419 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT_IN"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_IN""
jf @JFUD_3412 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_IN"" time 

:JFUD_3412
jump @JFUD_3464 

:JFUD_3419
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_3457 
gosub @JFUD_9887 

:JFUD_3457
jump @JFUD_574 

:JFUD_3464
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_3654 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_3519 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_3519
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_3587 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_3573 
gosub @JFUD_9887 

:JFUD_3573
jump @JFUD_574 
jump @JFUD_3647 

:JFUD_3587
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_IN""
jf @JFUD_3647 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_IN"" time 

:JFUD_3647
jump @JFUD_3464 

:JFUD_3654
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1145 
" + _10042 + @" = 0 
" + _10038 + @" = 0 
0760: store_shopping_data_index " + _10042 + @" textureCRC_to " + Selected_Menu_Item + @" 
" + JFUD_Selected_Food + @" = Object.Create(" + Selected_Menu_Item + @", " + X_Start_Anim_Food + @", " + Y_Start_Anim_Food + @", " + Z_Start_Anim_Food + @")
0761: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" price_to " + _10034 + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _10039 + @" 
0084: " + _2751 + @" = " + _10034 + @" 
05A9: " + _2752 + @" = " + _10039 + @" 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_3915 
070A: AS_actor " + Food_Seller + @" attach_to_object " + JFUD_Selected_Food + @" offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
" + _10038 + @" = 1 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT""
jf @JFUD_3908 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT"" time 

:JFUD_3908
jump @JFUD_3960 

:JFUD_3915
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_3953 
gosub @JFUD_9887 

:JFUD_3953
jump @JFUD_574 

:JFUD_3960
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_4144 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_4015 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_4015
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_4083 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_4069 
gosub @JFUD_9887 

:JFUD_4069
jump @JFUD_574 
jump @JFUD_4137 

:JFUD_4083
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT""
jf @JFUD_4137 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT"" time 

:JFUD_4137
jump @JFUD_3960 

:JFUD_4144
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_4287 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT_LOOP"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_LOOP""
jf @JFUD_4280 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_LOOP"" time 

:JFUD_4280
jump @JFUD_4332 

:JFUD_4287
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_4325 
gosub @JFUD_9887 

:JFUD_4325
jump @JFUD_574 

:JFUD_4332
" + JFUD_Stage + @" = 4 

:JFUD_4339
if 
  " + JFUD_Stage + @" == 4 
jf @JFUD_9675 
if 
  " + _10045 + @" == 0 
jf @JFUD_9668 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
jf @JFUD_4603 
if 
  " + _2418 + @" == 1 
jf @JFUD_4447 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_4447
" + _2544 + @" = 0 
" + _10042 + @" -= 1 
TIMERA = 0 

:JFUD_4468
if 
  150 > TIMERA 
jf @JFUD_4589 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_4521 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_4521
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_4582 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_4575 
gosub @JFUD_9887 

:JFUD_4575
jump @JFUD_574 

:JFUD_4582
jump @JFUD_4468 

:JFUD_4589
" + _10047 + @" = 0 
" + _10038 + @" = 0 

:JFUD_4603
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
jf @JFUD_4815 
if 
  " + _2418 + @" == 1 
jf @JFUD_4659 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_4659
" + _2544 + @" = 0 
" + _10042 + @" += 1 
TIMERA = 0 

:JFUD_4680
if 
  150 > TIMERA 
jf @JFUD_4801 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_4733 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_4733
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_4794 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_4787 
gosub @JFUD_9887 

:JFUD_4787
jump @JFUD_574 

:JFUD_4794
jump @JFUD_4680 

:JFUD_4801
" + _10038 + @" = 0 
" + _10047 + @" = 0 

:JFUD_4815
if 
  0 > " + _10042 + @" 
jf @JFUD_4848 
0084: " + _10042 + @" = " + _10036 + @" 
" + _10042 + @" -= 1 

:JFUD_4848
if 
003A:   " + _10042 + @" == " + _10036 + @" 
jf @JFUD_4874 
" + _10042 + @" = 0 

:JFUD_4874
if 
  " + _10038 + @" == 0 
jf @JFUD_5930 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_5026 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_RETURN"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_RETURN""
jf @JFUD_5019 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_RETURN"" time 

:JFUD_5019
jump @JFUD_5071 

:JFUD_5026
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_5064 
gosub @JFUD_9887 

:JFUD_5064
jump @JFUD_574 

:JFUD_5071
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_5259 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_5126 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_5126
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_5194 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_5180 
gosub @JFUD_9887 

:JFUD_5180
jump @JFUD_574 
jump @JFUD_5252 

:JFUD_5194
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_RETURN""
jf @JFUD_5252 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_RETURN"" time 

:JFUD_5252
jump @JFUD_5071 

:JFUD_5259
gosub @JFUD_Remove_Food 
0760: store_shopping_data_index " + _10042 + @" textureCRC_to " + Selected_Menu_Item + @" 
" + JFUD_Selected_Food + @" = Object.Create(" + Selected_Menu_Item + @", " + X_Start_Anim_Food + @", " + Y_Start_Anim_Food + @", " + Z_Start_Anim_Food + @")
0761: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" price_to " + _10034 + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _10039 + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1145 
0084: " + _2751 + @" = " + _10034 + @" 
05A9: " + _2752 + @" = " + _10039 + @" 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_5506 
070A: AS_actor " + Food_Seller + @" attach_to_object " + JFUD_Selected_Food + @" offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT""
jf @JFUD_5499 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT"" time 

:JFUD_5499
jump @JFUD_5551 

:JFUD_5506
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_5544 
gosub @JFUD_9887 

:JFUD_5544
jump @JFUD_574 

:JFUD_5551
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_5735 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_5606 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_5606
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_5674 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_5660 
gosub @JFUD_9887 

:JFUD_5660
jump @JFUD_574 
jump @JFUD_5728 

:JFUD_5674
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT""
jf @JFUD_5728 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT"" time 

:JFUD_5728
jump @JFUD_5551 

:JFUD_5735
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_5878 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT_LOOP"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_LOOP""
jf @JFUD_5871 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_LOOP"" time 

:JFUD_5871
jump @JFUD_5923 

:JFUD_5878
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_5916 
gosub @JFUD_9887 

:JFUD_5916
jump @JFUD_574 

:JFUD_5923
" + _10038 + @" = 1 

:JFUD_5930
if 
  " + _10045 + @" == 0 
jf @JFUD_5955 
gosub @JFUD_12352 

:JFUD_5955
if 
00E1:   player 0 pressed_key 16 
jf @JFUD_9668 

:JFUD_5972
if 
00E1:   player 0 pressed_key 16 
jf @JFUD_6091 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_6023 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_6023
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_6084 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_6077 
gosub @JFUD_9887 

:JFUD_6077
jump @JFUD_574 

:JFUD_6084
jump @JFUD_5972 

:JFUD_6091
" + _2544 + @" = 0 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'FOOD1'  
if 
   Player.Defined(" + PlayerChar + @")
jf @JFUD_6151 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
jump @JFUD_6165 

:JFUD_6151
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_6165
if 
002C:   " + Shops_Player_Cash + @" >= " + _10034 + @" 
jf @JFUD_9534 
if 
  11 > " + Total_Food_Eaten + @" 
jf @JFUD_6997 
0790: charge_money_for_shopping_item_with_textureCRC " + Selected_Menu_Item + @" 
" + _10047 + @" = 1 
if 
03D0:   wav 4 loaded 
jf @JFUD_6252 
if 
03D2:   wav 4 ended 
jf @JFUD_6252 
09F1: play_audio_at_actor " + PlayerActor + @" event 1168 

:JFUD_6252
if 
  " + _672 + @" == 0 
jf @JFUD_6282 
01BD: " + _5285 + @" = current_time_in_ms 
" + _672 + @" = 1 

:JFUD_6282
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
" + Total_Food_Eaten + @" += 1 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_6337 
0947: actor " + Food_Seller + @" speak_from_audio_table 323 store_spoken_phrase_id_to " + _2563 + @" 
jump @JFUD_6382 

:JFUD_6337
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_6375 
gosub @JFUD_9887 

:JFUD_6375
jump @JFUD_574 

:JFUD_6382
TIMERA = 0 
if 
  " + _2418 + @" == 1 
jf @JFUD_6421 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_6421
if 
  " + _2422 + @" == 0 
jf @JFUD_6789 
08D4: " + _2421 + @" = create_panel_with_title 'FOODCHO' position 29.0 25.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2421 + @" column 0 alignment 1 
08DB: set_panel " + _2421 + @" column 0 header 'MEAL' data 'BOUGHT' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2421 + @" column 1 alignment 2 
08DB: set_panel " + _2421 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2421 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + _10034 + @"  
09DB: set_panel " + _2421 + @" column 0 width 140 
09DB: set_panel " + _2421 + @" column 1 width 46 
" + _2422 + @" = 1 

:JFUD_6789
if 
  1000 >= TIMERA 
jf @JFUD_6910 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_6842 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_6842
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_6903 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_6896 
gosub @JFUD_9887 

:JFUD_6896
jump @JFUD_574 

:JFUD_6903
jump @JFUD_6789 

:JFUD_6910
if 
  " + _2422 + @" == 1 
jf @JFUD_6940 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:JFUD_6940
if 
  " + _2418 + @" == 0 
jf @JFUD_6965 
gosub @JFUD_12352 

:JFUD_6965
if 
  " + _88 + @" == 1 
jf @JFUD_6990 
" + _88 + @" = 2 

:JFUD_6990
jump @JFUD_9527 

:JFUD_6997
if 
  " + _10045 + @" == 0 
jf @JFUD_9527 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_7079 
0947: actor " + Food_Seller + @" speak_from_audio_table 322 store_spoken_phrase_id_to " + _2563 + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
00BC: show_text_highpriority GXT 'FOOD1' time 5000 flag 1  
jump @JFUD_7124 

:JFUD_7079
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_7117 
gosub @JFUD_9887 

:JFUD_7117
jump @JFUD_574 

:JFUD_7124
if 
  " + _2418 + @" == 1 
jf @JFUD_7156 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_7156
if 
  " + _2422 + @" == 1 
jf @JFUD_7188 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:JFUD_7188
if 
  " + _88 + @" == 2 
jf @JFUD_7314 
0169: set_fade_color_RGB 0 0 0 
043C: disable_sounds_after_fadeout 0 
fade 0 0 
gosub @JFUD_Remove_Food 
Actor.DestroyInstantly(" + Food_Seller + @")
" + _88 + @" = 3 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2544 + @" = 0 
" + _10038 + @" = 0 
" + _10042 + @" = 0 
" + JFUD_Stage + @" = 2 
Actor.Health(" + PlayerActor + @") = " + JFUD_Player_Health + @"
062A: change_float_stat 21 to " + JFUD_STAT_Fat + @" 
" + _28 + @" = 1 
jump @JFUD_574 

:JFUD_7314
if 
  " + Total_Food_Eaten + @" >= 11 
jf @JFUD_8116 
gosub @JFUD_9710 
gosub @JFUD_Remove_Food 
if 
  10 > " + JFUD_Player_Health + @" 
jf @JFUD_7379 
0084: " + JFUD_Player_Health + @" = " + JFUD_Player_Health + @" 
jump @JFUD_7411 

:JFUD_7379
" + JFUD_Player_Health + @" -= 10 
if 
  10 > " + JFUD_Player_Health + @" 
jf @JFUD_7411 
" + JFUD_Player_Health + @" = 10 

:JFUD_7411
Actor.Health(" + PlayerActor + @") = " + JFUD_Player_Health + @"
062A: change_float_stat 21 to " + JFUD_STAT_Fat + @" 
Camera.SetPosition(" + _10075 + @", " + _10076 + @", " + _10077 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _10078 + @", " + _10079 + @", " + _10080 + @", 2)
if 
   Player.Defined(" + PlayerChar + @")
jf @JFUD_7638 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0086: " + _10049 + @" = " + tempvar_X_coord + @" 
" + _10049 + @" += 0.355 
0086: " + _10050 + @" = " + tempvar_Y_coord + @" 
" + _10050 + @" -= 0.116 
0086: " + _10051 + @" = " + tempvar_Z_coord + @" 
" + _10051 + @" -= 0.048 
064B: " + _10048 + @" = create_particle ""PUKE"" at " + _10049 + @" " + _10050 + @" " + _10051 + @" type 1 
0812: AS_actor " + PlayerActor + @" perform_animation ""EAT_VOMIT_P"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
" + _10052 + @" = 0.0 
0947: actor " + PlayerActor + @" speak_from_audio_table 353 store_spoken_phrase_id_to " + _2563 + @" 
jump @JFUD_7652 

:JFUD_7638
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_7652
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_7726 
0812: AS_actor " + Food_Seller + @" perform_animation ""EAT_VOMIT_SK"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0947: actor " + Food_Seller + @" speak_from_audio_table 325 store_spoken_phrase_id_to " + _2563 + @" 
jump @JFUD_7771 

:JFUD_7726
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_7764 
gosub @JFUD_9887 

:JFUD_7764
jump @JFUD_574 

:JFUD_7771
if 
   Actor.Animation(" + PlayerActor + @") == ""EAT_VOMIT_P""
jf @JFUD_7821 
0613: " + _10052 + @" = actor " + PlayerActor + @" animation ""EAT_VOMIT_P"" time 

:JFUD_7821
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_8099 
wait 0 
if 
  " + _10056 + @" == 0 
jf @JFUD_7915 
if 
  " + _10052 + @" >= 0.463 
jf @JFUD_7915 
if 
03D0:   wav 4 loaded 
jf @JFUD_7908 
09F1: play_audio_at_actor " + PlayerActor + @" event 1169 

:JFUD_7908
" + _10056 + @" = 1 

:JFUD_7915
if 
  " + _10056 + @" == 1 
jf @JFUD_7966 
if 
  " + _10052 + @" >= 0.52 
jf @JFUD_7966 
064C: make_particle " + _10048 + @" visible 
" + _10056 + @" = 2 

:JFUD_7966
if 
   Player.Defined(" + PlayerChar + @")
jf @JFUD_8010 
0613: " + _10052 + @" = actor " + PlayerActor + @" animation ""EAT_VOMIT_P"" time 
jump @JFUD_8024 

:JFUD_8010
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_8024
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_8047 
jump @JFUD_8092 

:JFUD_8047
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_8085 
gosub @JFUD_9887 

:JFUD_8085
jump @JFUD_574 

:JFUD_8092
jump @JFUD_7821 

:JFUD_8099
064E: stop_particle " + _10048 + @" 
0650: destroy_particle " + _10048 + @" 
jump @JFUD_8867 

:JFUD_8116
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_8250 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_RETURN"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_RETURN""
jf @JFUD_8243 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_RETURN"" time 

:JFUD_8243
jump @JFUD_8295 

:JFUD_8250
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_8288 
gosub @JFUD_9887 

:JFUD_8288
jump @JFUD_574 

:JFUD_8295
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_8483 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_8350 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_8350
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_8418 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_8404 
gosub @JFUD_9887 

:JFUD_8404
jump @JFUD_574 
jump @JFUD_8476 

:JFUD_8418
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_RETURN""
jf @JFUD_8476 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_RETURN"" time 

:JFUD_8476
jump @JFUD_8295 

:JFUD_8483
gosub @JFUD_Remove_Food 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_8630 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT_OUT"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_OUT""
jf @JFUD_8623 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_OUT"" time 

:JFUD_8623
jump @JFUD_8675 

:JFUD_8630
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_8668 
gosub @JFUD_9887 

:JFUD_8668
jump @JFUD_574 

:JFUD_8675
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_8867 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_8730 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_8730
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_8798 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_8784 
gosub @JFUD_9887 

:JFUD_8784
jump @JFUD_574 
jump @JFUD_8860 

:JFUD_8798
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_OUT""
jf @JFUD_8860 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_OUT"" time 

:JFUD_8860
jump @JFUD_8675 

:JFUD_8867
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_8995 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_POSE"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_8988 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_POSE"" time 

:JFUD_8988
jump @JFUD_9040 

:JFUD_8995
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_9033 
gosub @JFUD_9887 

:JFUD_9033
jump @JFUD_574 

:JFUD_9040
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_9231 
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @JFUD_9088 
jump @JFUD_9102 

:JFUD_9088
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_9102
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_9179 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_9172 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_POSE"" time 

:JFUD_9172
jump @JFUD_9224 

:JFUD_9179
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_9217 
gosub @JFUD_9887 

:JFUD_9217
jump @JFUD_574 

:JFUD_9224
jump @JFUD_9040 

:JFUD_9231
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut

:JFUD_9246
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 on_foot 
jf @JFUD_9485 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_9322 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_9322
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_9390 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_9376 
gosub @JFUD_9887 

:JFUD_9376
jump @JFUD_574 
jump @JFUD_9478 

:JFUD_9390
if 
  " + flag_Player_Attack_Food_Seller + @" == 0 
jf @JFUD_9478 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + Food_Seller + @" 
031D:   actor " + Food_Seller + @" hit_by_weapon 57 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @JFUD_9478 
0947: actor " + Food_Seller + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _2563 + @" 
05C4: AS_actor " + Food_Seller + @" hands_up -2 ms 
" + FOOD_Player_Aggressive_Flag + @" = 1 
" + flag_Player_Attack_Food_Seller + @" = 1 

:JFUD_9478
jump @JFUD_9246 

:JFUD_9485
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _10038 + @" = 0 
" + _10042 + @" = 0 
" + JFUD_Stage + @" = 2 
" + _10045 + @" = 1 

:JFUD_9527
jump @JFUD_9668 

:JFUD_9534
if 
  " + _2544 + @" == 0 
jf @JFUD_9668 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_9616 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + Food_Seller + @" speak_from_audio_table 324 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'SHOPNO' time 5000 flag 1  
jump @JFUD_9661 

:JFUD_9616
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_9654 
gosub @JFUD_9887 

:JFUD_9654
jump @JFUD_574 

:JFUD_9661
" + _2544 + @" = 1 

:JFUD_9668
gosub @JFUD_10132 

:JFUD_9675
jump @JFUD_9689 

:JFUD_9682
gosub @JFUD_9887 

:JFUD_9689
jump @JFUD_9703 

:JFUD_9696
gosub @JFUD_9887 

:JFUD_9703
jump @JFUD_574 

:JFUD_9710
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'FOOD1'  
if 
  " + _2418 + @" == 1 
jf @JFUD_9764 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_9764
if 
  " + _2422 + @" == 1 
jf @JFUD_9796 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:JFUD_9796
" + _10038 + @" = 0 
" + _10042 + @" = 0 
" + _10047 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + JFUD_Stage + @" = 2 
" + _2544 + @" = 0 
Model.Destroy(" + JFUD_LOW_Food_Model + @")
Model.Destroy(" + JFUD_MED_Food_Model + @")
Model.Destroy(" + JFUD_HIGH_Food_Model + @")
Model.Destroy(" + JFUD_HEALTHY_Food_Model + @")
if 
  " + Food_Seller_Exists + @" == 1 
jf @JFUD_9885 
03E6: remove_text_box 

:JFUD_9885
return 

:JFUD_9887
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'FOOD1'  
if 
  " + Food_Seller_Exists + @" == 1 
jf @JFUD_9929 
03E6: remove_text_box 

:JFUD_9929
if 
  " + _2418 + @" == 1 
jf @JFUD_9961 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_9961
if 
  " + _2422 + @" == 1 
jf @JFUD_9993 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:JFUD_9993
" + Food_Seller_Exists + @" = 0 
" + _10035 + @" = 0 
" + _10042 + @" = 0 
" + _10038 + @" = 0 
" + _10045 + @" = 0 
" + _10047 + @" = 0 
" + flag_Player_Attack_Food_Seller + @" = 0 
" + _10056 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + JFUD_Stage + @" = 0 
" + _2544 + @" = 0 
0650: destroy_particle " + _10048 + @" 
Actor.DestroyInstantly(" + Food_Seller + @")
Model.Destroy(" + Seller_Model + @")
Model.Destroy(" + JFUD_LOW_Food_Model + @")
Model.Destroy(" + JFUD_MED_Food_Model + @")
Model.Destroy(" + JFUD_HIGH_Food_Model + @")
Model.Destroy(" + JFUD_HEALTHY_Food_Model + @")
03F0: enable_text_draw 0 
08F8: display_stat_update_box 1 
09BD: allow_other_threads_to_display_text_boxes 0 
040D: unload_wav 4 
end_thread 
return 

:JFUD_10132
if 
00E1:   player 0 pressed_key 15 
jf @JFUD_12350 
if 
  " + _2418 + @" == 1 
jf @JFUD_10181 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:JFUD_10181
if 
  " + _2422 + @" == 1 
jf @JFUD_10213 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:JFUD_10213
if 
00E1:   player 0 pressed_key 15 
jf @JFUD_10332 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_10264 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_10264
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_10325 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_10318 
gosub @JFUD_9887 

:JFUD_10318
jump @JFUD_574 

:JFUD_10325
jump @JFUD_10213 

:JFUD_10332
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'FOOD1'  
if 
  " + _88 + @" == 2 
jf @JFUD_10454 
0169: set_fade_color_RGB 0 0 0 
fade 0 0 
gosub @JFUD_Remove_Food 
Actor.DestroyInstantly(" + Food_Seller + @")
" + _88 + @" = 3 
" + _10038 + @" = 0 
" + _10042 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + JFUD_Stage + @" = 2 
" + _2544 + @" = 0 
jump @JFUD_12350 

:JFUD_10454
" + Show_Shop_Sphere + @" = 0 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
  " + _10047 + @" == 1 
jf @JFUD_10687 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDBURG' 
jf @JFUD_10554 
0605: actor " + PlayerActor + @" perform_animation ""EAT_BURGER"" IFP ""FOOD"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @JFUD_10687 

:JFUD_10554
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @JFUD_10623 
0605: actor " + PlayerActor + @" perform_animation ""EAT_PIZZA"" IFP ""FOOD"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
jump @JFUD_10687 

:JFUD_10623
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDCHICK' 
jf @JFUD_10687 
0605: actor " + PlayerActor + @" perform_animation ""EAT_CHICKEN"" IFP ""FOOD"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:JFUD_10687
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_10832 
0947: actor " + Food_Seller + @" speak_from_audio_table 331 store_spoken_phrase_id_to " + _10081 + @" 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_RETURN"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_RETURN""
jf @JFUD_10825 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_RETURN"" time 

:JFUD_10825
jump @JFUD_10877 

:JFUD_10832
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_10870 
gosub @JFUD_9887 

:JFUD_10870
jump @JFUD_574 

:JFUD_10877
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_11065 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_10932 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_10932
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_11000 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_10986 
gosub @JFUD_9887 

:JFUD_10986
jump @JFUD_574 
jump @JFUD_11058 

:JFUD_11000
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_RETURN""
jf @JFUD_11058 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_RETURN"" time 

:JFUD_11058
jump @JFUD_10877 

:JFUD_11065
gosub @JFUD_Remove_Food 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_11212 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_LIFT_OUT"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_OUT""
jf @JFUD_11205 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_OUT"" time 

:JFUD_11205
jump @JFUD_11257 

:JFUD_11212
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_11250 
gosub @JFUD_9887 

:JFUD_11250
jump @JFUD_574 

:JFUD_11257
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_11449 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_11312 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_11312
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_11380 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_11366 
gosub @JFUD_9887 

:JFUD_11366
jump @JFUD_574 
jump @JFUD_11442 

:JFUD_11380
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_LIFT_OUT""
jf @JFUD_11442 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_LIFT_OUT"" time 

:JFUD_11442
jump @JFUD_11257 

:JFUD_11449
if 
  " + _10047 + @" == 1 
jf @JFUD_11505 
if 
03D0:   wav 4 loaded 
jf @JFUD_11505 
if 
03D2:   wav 4 ended 
jf @JFUD_11505 
09F1: play_audio_at_actor " + PlayerActor + @" event 1168 

:JFUD_11505
" + _10038 + @" = 0 
" + _10042 + @" = 0 
" + JFUD_Stage + @" = 2 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _10047 + @" = 0 
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
if 
  " + Food_Seller_Exists + @" == 1 
jf @JFUD_11576 
03E6: remove_text_box 

:JFUD_11576
gosub @JFUD_Remove_Food 
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_11710 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_THANK"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
0947: actor " + Food_Seller + @" speak_from_audio_table 331 store_spoken_phrase_id_to " + _10081 + @" 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_THANK""
jf @JFUD_11703 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_THANK"" time 

:JFUD_11703
jump @JFUD_11755 

:JFUD_11710
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_11748 
gosub @JFUD_9887 

:JFUD_11748
jump @JFUD_574 

:JFUD_11755
if 
   not " + _10052 + @" == 1.0 
jf @JFUD_11931 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_11810 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_11810
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_11878 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_11864 
gosub @JFUD_9887 

:JFUD_11864
jump @JFUD_574 
jump @JFUD_11924 

:JFUD_11878
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_THANK""
jf @JFUD_11924 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_THANK"" time 

:JFUD_11924
jump @JFUD_11755 

:JFUD_11931
if 
   not Actor.Dead(" + Food_Seller + @")
jf @JFUD_12059 
0812: AS_actor " + Food_Seller + @" perform_animation ""SHP_TRAY_POSE"" IFP ""FOOD"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _10052 + @" = 0.0 
if 
   Actor.Animation(" + Food_Seller + @") == ""SHP_TRAY_POSE""
jf @JFUD_12052 
0613: " + _10052 + @" = actor " + Food_Seller + @" animation ""SHP_TRAY_POSE"" time 

:JFUD_12052
jump @JFUD_12104 

:JFUD_12059
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_12097 
gosub @JFUD_9887 

:JFUD_12097
jump @JFUD_574 

:JFUD_12104
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 on_foot 
jf @JFUD_12343 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @JFUD_12180 
gosub @JFUD_9887 
jump @JFUD_574 

:JFUD_12180
if 
   Actor.Dead(" + Food_Seller + @")
jf @JFUD_12248 
gosub @JFUD_9710 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _10043 + @" 
jf @JFUD_12234 
gosub @JFUD_9887 

:JFUD_12234
jump @JFUD_574 
jump @JFUD_12336 

:JFUD_12248
if 
  " + flag_Player_Attack_Food_Seller + @" == 0 
jf @JFUD_12336 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + Food_Seller + @" 
031D:   actor " + Food_Seller + @" hit_by_weapon 57 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @JFUD_12336 
0947: actor " + Food_Seller + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _2563 + @" 
05C4: AS_actor " + Food_Seller + @" hands_up -2 ms 
" + FOOD_Player_Aggressive_Flag + @" = 1 
" + flag_Player_Attack_Food_Seller + @" = 1 

:JFUD_12336
jump @JFUD_12104 

:JFUD_12343
" + Show_Shop_Sphere + @" = 1 

:JFUD_12350
return 

:JFUD_12352
if 
  " + _2418 + @" == 0 
jf @JFUD_12991 
0512: show_permanent_text_box 'FOOD_H'  
if 
04A3:   " + Current_Language + @" == 0 
jf @JFUD_12443 
08D4: " + _2417 + @" = create_panel_with_title 'FOODCHO' position 29.0 145.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @JFUD_12684 

:JFUD_12443
if 
04A3:   " + Current_Language + @" == 1 
jf @JFUD_12505 
08D4: " + _2417 + @" = create_panel_with_title 'FOODCHO' position 29.0 145.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @JFUD_12684 

:JFUD_12505
if 
04A3:   " + Current_Language + @" == 2 
jf @JFUD_12567 
08D4: " + _2417 + @" = create_panel_with_title 'FOODCHO' position 29.0 165.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @JFUD_12684 

:JFUD_12567
if 
04A3:   " + Current_Language + @" == 3 
jf @JFUD_12629 
08D4: " + _2417 + @" = create_panel_with_title 'FOODCHO' position 29.0 145.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @JFUD_12684 

:JFUD_12629
if 
04A3:   " + Current_Language + @" == 4 
jf @JFUD_12684 
08D4: " + _2417 + @" = create_panel_with_title 'FOODCHO' position 29.0 145.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  

:JFUD_12684
08D6: set_panel " + _2417 + @" column 0 alignment 1 
08DB: set_panel " + _2417 + @" column 0 header 'MEAL' data " + _2752 + @" 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2417 + @" column 1 alignment 2 
08DB: set_panel " + _2417 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2417 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + _2751 + @"  
09DB: set_panel " + _2417 + @" column 0 width 140 
09DB: set_panel " + _2417 + @" column 1 width 46 
" + _2418 + @" = 1 

:JFUD_12991
return 

:JFUD_Remove_Food
Object.Destroy(" + JFUD_Selected_Food + @")
return 
end_thread" );
            }

        }

    }

}