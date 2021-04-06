using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class AMUNAT : External {

            Int tmp_2438 = global( _2438.startIndex ), 
                tmp_2426 = global( _2426.startIndex ),
                tmp_2450 = global( _2450.startIndex ),
                tmp_9633 = global( _9633.startIndex ),
                tmp_9617 = global( _9617.startIndex ),
                tmp_9620 = global( _9620.startIndex ),
                tmp_9623 = global( _9623.startIndex ),
                tmp_9625 = global( _9625.startIndex ),
                tmp_9626 = global( _9626.startIndex ),
                tmp_9628 = global( _9628.startIndex ),
                tmp_9630 = global( _9630.startIndex ),
                tmp_9632 = global( _9632.startIndex );

            sString str_2450 = global( _2450.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _9585 + @" = 0.0 
" + _9586 + @" = 0.0 
" + _9587 + @" = 0.0 
" + AMMU_X_Offset + @" = 0.0 
" + AMMU_Y_Offset + @" = 0.0 
" + AMMU_Z_Offset + @" = 0.0 
" + X_Camera + @" = 0.0 
" + Y_Camera + @" = 0.0 
" + Z_Camera + @" = 0.0 
" + AMMU_X_Aim_Camera + @" = 0.0 
" + AMMU_Y_Aim_Camera + @" = 0.0 
" + AMMU_Z_Aim_Camera + @" = 0.0 
" + AMMU_Seller_Animation_Time + @" = 0.0 
" + AMMU_Seller_Angle + @" = 0.0 
" + _2418 + @" = 0 
" + AMMU_X_Seller + @" = 0.0 
" + AMMU_Y_Seller + @" = 0.0 
" + AMMU_Z_Seller + @" = 0.0 
" + flag_AMMU_Seller_Attack_Player + @" = 0 
" + AMMU_Stage + @" = 0 
" + _9575 + @" = 0.0 
" + _9576 + @" = 0.0 
" + _9577 + @" = 0.0 
" + _9572 + @" = 0 
" + _9573 + @" = 0 
" + _9574 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9595 + @" = 0 
" + _9594 + @" = 0 
" + _9596 + @" = 0 
" + _9616 + @" = 0 
" + _9597 + @" = 0 
" + _2515 + @" = 0 
" + _9598 + @" = 0 
" + _9599 + @" = 0 
" + _9600 + @" = 0 
" + _9601 + @" = 0 
" + _9602 + @" = 0 
" + _9603 + @" = 0 
" + _9604 + @" = 0 
" + _9605 + @" = 0 
" + _9606 + @" = 0 
" + _9607 + @" = 0 
" + _9608 + @" = 0 
" + _9609 + @" = 0 
" + _9610 + @" = 0 
" + _9611 + @" = 0 
" + _9612 + @" = 0 
" + _9613 + @" = 0 
" + _9614 + @" = 0 
" + _9615 + @" = 0 
" + _9636 + @" = 0 
" + _9637 + @" = 0 
" + _9638 + @" = 0 
jump @AMUNAT_525 
018D: NOP " + _9570 + @" 65535 " + AMMU_X_Seller + @" " + AMMU_Y_Seller + @" " + AMMU_Z_Seller + @" 
" + _9571 + @" = Object.Create(" + AMMU_Seller_Animation_Time + @", 1659.635, -1576.514, 15.585)
" + _9543 + @" = Object.Create(" + AMMU_Seller_Animation_Time + @", " + _9575 + @", " + _9576 + @", " + _9577 + @")

:AMUNAT_525
04AE: " + Seller_Model + @" = 179 
Model.Load(" + Seller_Model + @")
Model.Load(#COLT45)
Model.Load(#TEC9)
Model.Load(#MICRO_UZI)
Model.Load(#CHROMEGUN)
Model.Load(#GRENADE)
Model.Load(#ARMOUR)
Model.Load(#MP5LNG)
Model.Load(#SAWNOFF)
Model.Load(#SILENCED)
Model.Load(#SATCHEL)
Model.Load(#BOMB)
Model.Load(#CUNTGUN)
Model.Load(#SNIPER)
Model.Load(#AK47)
Model.Load(#M4)
Model.Load(#DESERT_EAGLE)
Model.Load(#SHOTGSPA)
038B: load_requested_models 
set_wb_check_to 0 

:AMUNAT_640
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @AMUNAT_7618 
if 
8844:   not string " + Current_Shop_GXT_Name + @" empty 
jf @AMUNAT_7604 
if 
  " + AMMU_Stage + @" > 0 
jf @AMUNAT_762 
if 
0A0F:   new_language_set 
jf @AMUNAT_762 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
08DA: remove_panel " + _2423 + @" 
08DA: remove_panel " + _2421 + @" 
08DA: remove_panel " + _2417 + @" 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
09FB: " + Current_Language + @" = current_language 

:AMUNAT_762
if 
  " + AMMU_Stage + @" == 0 
jf @AMUNAT_1286 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'AMMUN1' 
jf @AMUNAT_884 
" + AMMU_X_Offset + @" = 0.0 
" + AMMU_Y_Offset + @" = 0.0 
" + AMMU_Z_Offset + @" = 0.0 
" + AMMU_Player_Angle + @" = 180.0 
" + AMMU_Seller_Angle + @" = 0.0 
" + Show_Shop_Sphere + @" = 1 
05A9: " + AMMU_Interior_Name + @" = " + Current_Shop_GXT_Name + @" 
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 1 

:AMUNAT_884
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'AMMUN2' 
jf @AMUNAT_988 
" + AMMU_X_Offset + @" = -0.765 
" + AMMU_Y_Offset + @" = -42.311 
" + AMMU_Z_Offset + @" = -0.013 
" + AMMU_Player_Angle + @" = 180.0 
" + AMMU_Seller_Angle + @" = 0.0 
" + Show_Shop_Sphere + @" = 1 
05A9: " + AMMU_Interior_Name + @" = " + Current_Shop_GXT_Name + @" 
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 1 

:AMUNAT_988
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'AMMUN3' 
jf @AMUNAT_1092 
" + AMMU_X_Offset + @" = -6.264 
" + AMMU_Y_Offset + @" = -71.34 
" + AMMU_Z_Offset + @" = -0.002 
" + AMMU_Player_Angle + @" = 180.0 
" + AMMU_Seller_Angle + @" = 0.0 
" + Show_Shop_Sphere + @" = 1 
05A9: " + AMMU_Interior_Name + @" = " + Current_Shop_GXT_Name + @" 
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 1 

:AMUNAT_1092
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'AMMUN4' 
jf @AMUNAT_1189 
" + AMMU_X_Offset + @" = 11.642 
" + AMMU_Y_Offset + @" = -102.936 
" + AMMU_Z_Offset + @" = -1.929 
" + AMMU_Player_Angle + @" = 180.0 
" + AMMU_Seller_Angle + @" = 0.0 
" + Show_Shop_Sphere + @" = 1 
05A9: " + AMMU_Interior_Name + @" = " + Current_Shop_GXT_Name + @" 
" + AMMU_Stage + @" = 1 

:AMUNAT_1189
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'AMMUN5' 
jf @AMUNAT_1286 
" + AMMU_X_Offset + @" = 16.285 
" + AMMU_Y_Offset + @" = -127.781 
" + AMMU_Z_Offset + @" = -1.929 
" + AMMU_Player_Angle + @" = 180.0 
" + AMMU_Seller_Angle + @" = 0.0 
" + Show_Shop_Sphere + @" = 1 
05A9: " + AMMU_Interior_Name + @" = " + Current_Shop_GXT_Name + @" 
" + AMMU_Stage + @" = 1 

:AMUNAT_1286
if 
  " + AMMU_Stage + @" == 1 
jf @AMUNAT_2318 
03F0: enable_text_draw 1 
08F8: display_stat_update_box 0 
" + X_Buy_Marker + @" = 296.506 
0059: " + X_Buy_Marker + @" += " + AMMU_X_Offset + @" 
" + Y_Buy_Marker + @" = -38.168 
0059: " + Y_Buy_Marker + @" += " + AMMU_Y_Offset + @" 
" + Z_Buy_Marker + @" = 1000.547 
0059: " + Z_Buy_Marker + @" += " + AMMU_Z_Offset + @" 
" + AMMU_X_Seller + @" = 296.506 
0059: " + AMMU_X_Seller + @" += " + AMMU_X_Offset + @" 
" + AMMU_Y_Seller + @" = -40.35 
0059: " + AMMU_Y_Seller + @" += " + AMMU_Y_Offset + @" 
" + AMMU_Z_Seller + @" = 1000.54 
0059: " + AMMU_Z_Seller + @" += " + AMMU_Z_Offset + @" 
" + X_Camera + @" = 296.585 
0059: " + X_Camera + @" += " + AMMU_X_Offset + @" 
" + Y_Camera + @" = -38.345 
0059: " + Y_Camera + @" += " + AMMU_Y_Offset + @" 
" + Z_Camera + @" = 1002.236 
0059: " + Z_Camera + @" += " + AMMU_Z_Offset + @" 
" + AMMU_X_Aim_Camera + @" = 296.501 
0059: " + AMMU_X_Aim_Camera + @" += " + AMMU_X_Offset + @" 
" + AMMU_Y_Aim_Camera + @" = -39.298 
0059: " + AMMU_Y_Aim_Camera + @" += " + AMMU_Y_Offset + @" 
" + AMMU_Z_Aim_Camera + @" = 1001.943 
0059: " + AMMU_Z_Aim_Camera + @" += " + AMMU_Z_Offset + @" 
" + AMMU_Seller + @" = Actor.Create(CivMale, " + Seller_Model + @", " + AMMU_X_Seller + @", " + AMMU_Y_Seller + @", " + AMMU_Z_Seller + @")
Actor.Angle(" + AMMU_Seller + @") = " + AMMU_Seller_Angle + @"
02A9: set_actor " + AMMU_Seller + @" immune_to_nonplayer 1 
060B: set_actor " + AMMU_Seller + @" decision_maker_to 65542 
if 
  " + Casino_Total_Passed_Missions + @" > 2 
jf @AMUNAT_1638 
075F: store_shopping_data_entries_number_to " + AMMU_Available_Weapons + @" 
if 
  " + _2574 + @" == 0 
jf @AMUNAT_1631 
03E5: show_text_box 'NEWWEAP'  
" + _2574 + @" = 1 

:AMUNAT_1631
jump @AMUNAT_2311 

:AMUNAT_1638
if 
  " + Toreno_Total_Passed_Missions + @" > 7 
jf @AMUNAT_1706 
" + AMMU_Available_Weapons + @" = 15 
if 
  " + _2573 + @" == 0 
jf @AMUNAT_1699 
03E5: show_text_box 'NEWWEAP'  
" + _2573 + @" = 1 

:AMUNAT_1699
jump @AMUNAT_2311 

:AMUNAT_1706
if 
  " + Syndicate_Total_Passed_Missions + @" > 9 
jf @AMUNAT_1774 
" + AMMU_Available_Weapons + @" = 14 
if 
  " + _2572 + @" == 0 
jf @AMUNAT_1767 
03E5: show_text_box 'NEWWEAP'  
" + _2572 + @" = 1 

:AMUNAT_1767
jump @AMUNAT_2311 

:AMUNAT_1774
if 
  " + Wuzimu_Total_Passed_Missions + @" > 0 
jf @AMUNAT_1842 
" + AMMU_Available_Weapons + @" = 13 
if 
  " + _2571 + @" == 0 
jf @AMUNAT_1835 
03E5: show_text_box 'NEWWEAP'  
" + _2571 + @" = 1 

:AMUNAT_1835
jump @AMUNAT_2311 

:AMUNAT_1842
if 
  " + Syndicate_Total_Passed_Missions + @" > 7 
jf @AMUNAT_1910 
" + AMMU_Available_Weapons + @" = 12 
if 
  " + _2570 + @" == 0 
jf @AMUNAT_1903 
03E5: show_text_box 'NEWWEAP'  
" + _2570 + @" = 1 

:AMUNAT_1903
jump @AMUNAT_2311 

:AMUNAT_1910
if 
  " + Truth_Total_Passed_Missions + @" > 0 
jf @AMUNAT_1978 
" + AMMU_Available_Weapons + @" = 11 
if 
  " + _2569 + @" == 0 
jf @AMUNAT_1971 
03E5: show_text_box 'NEWWEAP'  
" + _2569 + @" = 1 

:AMUNAT_1971
jump @AMUNAT_2311 

:AMUNAT_1978
if 
  " + All_Catalina_missions_passed + @" == 1 
jf @AMUNAT_2046 
" + AMMU_Available_Weapons + @" = 10 
if 
  " + _2568 + @" == 0 
jf @AMUNAT_2039 
03E5: show_text_box 'NEWWEAP'  
" + _2568 + @" = 1 

:AMUNAT_2039
jump @AMUNAT_2311 

:AMUNAT_2046
if 
  " + OG_Loc_Total_Passed_Missions + @" > 4 
jf @AMUNAT_2114 
" + AMMU_Available_Weapons + @" = 9 
if 
  " + _2567 + @" == 0 
jf @AMUNAT_2107 
03E5: show_text_box 'NEWWEAP'  
" + _2567 + @" = 1 

:AMUNAT_2107
jump @AMUNAT_2311 

:AMUNAT_2114
if 
  " + Smoke_Total_Passed_Missions + @" > 3 
jf @AMUNAT_2182 
" + AMMU_Available_Weapons + @" = 8 
if 
  " + _2566 + @" == 0 
jf @AMUNAT_2175 
03E5: show_text_box 'NEWWEAP'  
" + _2566 + @" = 1 

:AMUNAT_2175
jump @AMUNAT_2311 

:AMUNAT_2182
if 
  " + Ryder_Total_Passed_Missions + @" > 2 
jf @AMUNAT_2250 
" + AMMU_Available_Weapons + @" = 7 
if 
  " + _2565 + @" == 0 
jf @AMUNAT_2243 
03E5: show_text_box 'NEWWEAP'  
" + _2565 + @" = 1 

:AMUNAT_2243
jump @AMUNAT_2311 

:AMUNAT_2250
if 
  2 > " + LS_FINAL_Total_Passed_Missions + @" 
jf @AMUNAT_2311 
" + AMMU_Available_Weapons + @" = 6 
if 
  " + _2564 + @" == 0 
jf @AMUNAT_2311 
03E5: show_text_box 'NEWWEAP'  
" + _2564 + @" = 1 

:AMUNAT_2311
" + AMMU_Stage + @" = 2 

:AMUNAT_2318
if 
  " + AMMU_Stage + @" == 2 
jf @AMUNAT_2978 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_2367 
gosub @AMUNAT_8535 

:AMUNAT_2367
if 
   not Actor.Dead(" + AMMU_Seller + @")
jf @AMUNAT_2933 
if 
  " + flag_AMMU_Seller_Attack_Player + @" == 0 
jf @AMUNAT_2881 
if 
  " + _9584 + @" == 0 
jf @AMUNAT_2480 
0812: AS_actor " + AMMU_Seller + @" perform_animation ""SHP_TRAY_POSE"" IFP ""WEAPONS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
" + _9584 + @" = 1 

:AMUNAT_2480
if 
  " + ONMISSION_Shooting + @" == 0 
jf @AMUNAT_2700 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + AMMU_Seller + @" 
031D:   actor " + AMMU_Seller + @" hit_by_weapon 57 
jf @AMUNAT_2613 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 327 unknown_flags 0 0 1 as " + _10081 + @" 
05BA: AS_actor " + AMMU_Seller + @" move_mouth 5 ms 
081A: set_actor " + AMMU_Seller + @" weapon_skill_to 2 
Actor.GiveWeaponAndAmmo(" + AMMU_Seller + @", Pistol, 30000)
Actor.WeaponAccuracy(" + AMMU_Seller + @") = 80
0638: AS_actor " + AMMU_Seller + @" stay_put 1 
05E2: AS_actor " + AMMU_Seller + @" kill_actor " + PlayerActor + @" 
" + Show_Shop_Sphere + @" = 0 
" + flag_AMMU_Seller_Attack_Player + @" = 1 
jump @AMUNAT_2693 

:AMUNAT_2613
" + Show_Shop_Sphere + @" = 1 
if 
0102:   actor " + PlayerActor + @" in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @AMUNAT_2693 
if 
   Player.Controllable(" + PlayerChar + @")
jf @AMUNAT_2693 
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 3 

:AMUNAT_2693
jump @AMUNAT_2874 

:AMUNAT_2700
if or
0457:   player " + PlayerChar + @" aiming_at_actor " + AMMU_Seller + @" 
031D:   actor " + AMMU_Seller + @" hit_by_weapon 57 
jf @AMUNAT_2810 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 327 unknown_flags 0 0 1 as " + _10081 + @" 
05BA: AS_actor " + AMMU_Seller + @" move_mouth 5 ms 
081A: set_actor " + AMMU_Seller + @" weapon_skill_to 2 
Actor.GiveWeaponAndAmmo(" + AMMU_Seller + @", Pistol, 30000)
Actor.WeaponAccuracy(" + AMMU_Seller + @") = 80
0638: AS_actor " + AMMU_Seller + @" stay_put 1 
05E2: AS_actor " + AMMU_Seller + @" kill_actor " + PlayerActor + @" 
" + Show_Shop_Sphere + @" = 0 
" + flag_AMMU_Seller_Attack_Player + @" = 1 
jump @AMUNAT_2874 

:AMUNAT_2810
" + Show_Shop_Sphere + @" = 1 
if 
0102:   actor " + PlayerActor + @" in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @AMUNAT_2874 
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 3 

:AMUNAT_2874
jump @AMUNAT_2926 

:AMUNAT_2881
gosub @AMUNAT_8273 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_2919 
gosub @AMUNAT_8535 

:AMUNAT_2919
jump @AMUNAT_640 

:AMUNAT_2926
jump @AMUNAT_2978 

:AMUNAT_2933
gosub @AMUNAT_8273 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_2971 
gosub @AMUNAT_8535 

:AMUNAT_2971
jump @AMUNAT_640 

:AMUNAT_2978
if 
  " + AMMU_Stage + @" == 3 
jf @AMUNAT_3062 
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 1.0 
03D5: remove_text 'SHOPNO'  
TIMERA = 0 
" + AMMU_Stage + @" = 4 

:AMUNAT_3062
if 
  " + AMMU_Stage + @" == 4 
jf @AMUNAT_3421 
if 
   Actor.Dead(" + AMMU_Seller + @")
jf @AMUNAT_3141 
gosub @AMUNAT_8273 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_3134 
gosub @AMUNAT_8535 

:AMUNAT_3134
jump @AMUNAT_640 

:AMUNAT_3141
if 
  " + _9584 + @" == 0 
jf @AMUNAT_3421 
if 
  TIMERA >= 300 
jf @AMUNAT_3421 
08C7: put_actor " + PlayerActor + @" at " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = " + AMMU_Player_Angle + @"
Actor.StorePos(" + AMMU_Seller + @", " + _2755 + @", " + _2756 + @", " + _2757 + @")
if or
8044:   not  " + _2755 + @" == " + AMMU_X_Seller + @" 
8044:   not  " + _2756 + @" == " + AMMU_Y_Seller + @" 
8044:   not  " + _2757 + @" == " + AMMU_Z_Seller + @" 
jf @AMUNAT_3271 
Actor.PutAt(" + AMMU_Seller + @", " + AMMU_X_Seller + @", " + AMMU_Y_Seller + @", " + AMMU_Z_Seller + @")
Actor.Angle(" + AMMU_Seller + @") = " + AMMU_Seller_Angle + @"

:AMUNAT_3271
Camera.SetPosition(" + X_Camera + @", " + Y_Camera + @", " + Z_Camera + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + AMMU_X_Aim_Camera + @", " + AMMU_Y_Aim_Camera + @", " + AMMU_Z_Aim_Camera + @", 2)
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 333 unknown_flags 0 0 1 as " + _10081 + @" 
if 
  " + _2576 + @" == 1 
jf @AMUNAT_3352 
" + _2575 + @" = 1 

:AMUNAT_3352
if 
   Player.Defined(" + PlayerChar + @")
jf @AMUNAT_3389 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
jump @AMUNAT_3403 

:AMUNAT_3389
gosub @AMUNAT_8535 
jump @AMUNAT_640 

:AMUNAT_3403
0581: enable_radar 0 
" + AMMU_Stage + @" = 5 
" + _9584 + @" = 0 

:AMUNAT_3421
if 
  " + AMMU_Stage + @" == 5 
jf @AMUNAT_4241 
if 
   Actor.Dead(" + AMMU_Seller + @")
jf @AMUNAT_3500 
gosub @AMUNAT_8273 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_3493 
gosub @AMUNAT_8535 

:AMUNAT_3493
jump @AMUNAT_640 

:AMUNAT_3500
if 
  1 > " + _9584 + @" 
jf @AMUNAT_3550 
if 
  " + _2420 + @" == 0 
jf @AMUNAT_3550 
gosub @AMUNAT_9980 
gosub @AMUNAT_10986 

:AMUNAT_3550
if 
  " + _9584 + @" == 0 
jf @AMUNAT_3616 
if 
00E1:   player 0 pressed_key 16 
jf @AMUNAT_3592 
" + _9584 + @" = 3 

:AMUNAT_3592
if 
00E1:   player 0 pressed_key 15 
jf @AMUNAT_3616 
" + _9584 + @" = 1 

:AMUNAT_3616
if 
  " + _9584 + @" == 1 
jf @AMUNAT_3862 
if 
80E1:   not player 0 pressed_key 15 
jf @AMUNAT_3862 
if 
  " + _2420 + @" == 1 
jf @AMUNAT_3683 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:AMUNAT_3683
if 
  " + _2424 + @" == 1 
jf @AMUNAT_3715 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:AMUNAT_3715
if 
  " + _2418 + @" == 1 
jf @AMUNAT_3747 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
" + _2418 + @" = 0 

:AMUNAT_3747
if 
  " + _2422 + @" == 1 
jf @AMUNAT_3777 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:AMUNAT_3777
03D5: remove_text 'AMMUA'  
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'AMMUC'  
03D5: remove_text 'AMMUD'  
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 331 unknown_flags 0 0 1 as " + _10081 + @" 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
0581: enable_radar 1 
" + _9584 + @" = 2 

:AMUNAT_3862
if 
  " + _9584 + @" == 2 
jf @AMUNAT_4090 
if 
  " + flag_AMMU_Seller_Attack_Player + @" == 0 
jf @AMUNAT_3999 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + AMMU_Seller + @" 
031D:   actor " + AMMU_Seller + @" hit_by_weapon 57 
jf @AMUNAT_3999 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 327 unknown_flags 0 0 1 as " + _10081 + @" 
05BA: AS_actor " + AMMU_Seller + @" move_mouth 5 ms 
081A: set_actor " + AMMU_Seller + @" weapon_skill_to 2 
Actor.GiveWeaponAndAmmo(" + AMMU_Seller + @", Pistol, 30000)
Actor.WeaponAccuracy(" + AMMU_Seller + @") = 80
0638: AS_actor " + AMMU_Seller + @" stay_put 1 
05E2: AS_actor " + AMMU_Seller + @" kill_actor " + PlayerActor + @" 
" + flag_AMMU_Seller_Attack_Player + @" = 1 

:AMUNAT_3999
if 
80FF:   not actor " + PlayerActor + @" sphere 0 in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 on_foot 
jf @AMUNAT_4090 
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9544 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + AMMU_Stage + @" = 2 
" + _9584 + @" = 0 

:AMUNAT_4090
if 
  " + _9584 + @" == 3 
jf @AMUNAT_4241 
if 
80E1:   not player 0 pressed_key 16 
jf @AMUNAT_4241 
08D8: " + _9637 + @" = panel " + _2419 + @" selected_row 
05A9: " + _9549 + @" = " + tmp_2450 + @"(" + _9637 + @",12s) 
if 
  0 > " + _9637 + @" 
jf @AMUNAT_4170 
" + _9637 + @" = 0 

:AMUNAT_4170
if 
  " + _2420 + @" == 1 
jf @AMUNAT_4202 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:AMUNAT_4202
if 
  " + _2424 + @" == 0 
jf @AMUNAT_4227 
gosub @AMUNAT_11388 

:AMUNAT_4227
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 6 

:AMUNAT_4241
if 
  " + AMMU_Stage + @" == 6 
jf @AMUNAT_5565 
if 
   Actor.Dead(" + AMMU_Seller + @")
jf @AMUNAT_4320 
gosub @AMUNAT_8273 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_4313 
gosub @AMUNAT_8535 

:AMUNAT_4313
jump @AMUNAT_640 

:AMUNAT_4320
if 
  1 > " + _9584 + @" 
jf @AMUNAT_4363 
if 
  " + _2424 + @" == 0 
jf @AMUNAT_4363 
gosub @AMUNAT_11388 

:AMUNAT_4363
if 
  " + _9584 + @" == 0 
jf @AMUNAT_4429 
if 
00E1:   player 0 pressed_key 16 
jf @AMUNAT_4405 
" + _9584 + @" = 2 

:AMUNAT_4405
if 
00E1:   player 0 pressed_key 15 
jf @AMUNAT_4429 
" + _9584 + @" = 1 

:AMUNAT_4429
if 
  " + _9584 + @" == 1 
jf @AMUNAT_4542 
if 
80E1:   not player 0 pressed_key 15 
jf @AMUNAT_4542 
if 
  " + _2424 + @" == 1 
jf @AMUNAT_4496 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:AMUNAT_4496
if 
  " + _2420 + @" == 0 
jf @AMUNAT_4528 
gosub @AMUNAT_9980 
gosub @AMUNAT_10986 

:AMUNAT_4528
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 5 

:AMUNAT_4542
if 
  " + _9584 + @" == 2 
jf @AMUNAT_4834 
if 
80E1:   not player 0 pressed_key 16 
jf @AMUNAT_4834 
08D8: " + _9638 + @" = panel " + _2423 + @" selected_row 
if 
  0 > " + _9638 + @" 
jf @AMUNAT_4610 
" + _9638 + @" = 0 

:AMUNAT_4610
0084: " + AMMU_Selected_Weapon + @" = " + tmp_9633 + @"(" + _9638 + @",3i) 
078C: get_shopping_item_with_textureCRC " + AMMU_Selected_Weapon + @" nametag_to " + AMMU_Weapon_Name + @" 
0761: get_shopping_item_with_textureCRC " + AMMU_Selected_Weapon + @" price_to " + AMMU_Weapon_Cost + @" 
if 
84A3:   not  " + AMMU_Selected_Weapon + @" == 48 
jf @AMUNAT_4679 
0782: get_weapon_with_ID " + AMMU_Selected_Weapon + @" weapon_group_to " + AMMU_Selected_Weapon_Weapon_Group + @" 
0781: get_weapon_with_ID " + AMMU_Selected_Weapon + @" model_to " + AMMU_Selected_Weapon_Model + @" 
jump @AMUNAT_4687 

:AMUNAT_4679
04AE: " + AMMU_Selected_Weapon_Model + @" = 373 

:AMUNAT_4687
if 
  " + _2424 + @" == 1 
jf @AMUNAT_4719 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:AMUNAT_4719
0812: AS_actor " + AMMU_Seller + @" perform_animation ""SHP_G_LIFT_IN"" IFP ""WEAPONS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
   Actor.Animation(" + AMMU_Seller + @") == ""SHP_G_LIFT_IN""
jf @AMUNAT_4827 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation ""SHP_G_LIFT_IN"" time 

:AMUNAT_4827
" + _9584 + @" = 3 

:AMUNAT_4834
if 
  " + _9584 + @" == 3 
jf @AMUNAT_4934 
if 
   Actor.Animation(" + AMMU_Seller + @") == ""SHP_G_LIFT_IN""
jf @AMUNAT_4906 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation ""SHP_G_LIFT_IN"" time 

:AMUNAT_4906
if 
  " + AMMU_Seller_Animation_Time + @" == 1.0 
jf @AMUNAT_4934 
" + _9584 + @" = 4 

:AMUNAT_4934
if 
  " + _9584 + @" == 4 
jf @AMUNAT_5110 
" + _9543 + @" = Object.Create(" + AMMU_Selected_Weapon_Model + @", " + AMMU_X_Seller + @", " + AMMU_Y_Seller + @", " + AMMU_Z_Seller + @")
gosub @AMUNAT_8960 
gosub @AMUNAT_9615 
070A: AS_actor " + AMMU_Seller + @" attach_to_object " + _9543 + @" offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
Object.KeepInMemory(" + _9543 + @") = False
0812: AS_actor " + AMMU_Seller + @" perform_animation " + _9554 + @" IFP ""WEAPONS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + _9554 + @"
jf @AMUNAT_5103 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + _9554 + @" time 

:AMUNAT_5103
" + _9584 + @" = 5 

:AMUNAT_5110
if 
  " + _9584 + @" == 5 
jf @AMUNAT_5300 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + _9554 + @"
jf @AMUNAT_5158 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + _9554 + @" time 

:AMUNAT_5158
if 
  " + AMMU_Seller_Animation_Time + @" == 1.0 
jf @AMUNAT_5300 
070B: set_actor " + AMMU_Seller + @" onbone_attached_object_operation 0 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1131 
Object.PutAt(" + _9543 + @", " + _9585 + @", " + _9586 + @", " + _9587 + @")
Object.KeepInMemory(" + _9543 + @") = True
0812: AS_actor " + AMMU_Seller + @" perform_animation " + _9558 + @" IFP ""WEAPONS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + _9558 + @"
jf @AMUNAT_5293 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + _9558 + @" time 

:AMUNAT_5293
" + _9584 + @" = 6 

:AMUNAT_5300
if 
  " + _9584 + @" == 6 
jf @AMUNAT_5565 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + _9558 + @"
jf @AMUNAT_5348 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + _9558 + @" time 

:AMUNAT_5348
if 
  " + AMMU_Seller_Animation_Time + @" == 1.0 
jf @AMUNAT_5565 
0812: AS_actor " + AMMU_Seller + @" perform_animation ""SHP_TRAY_POSE"" IFP ""WEAPONS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
  " + _2418 + @" == 0 
jf @AMUNAT_5448 
gosub @AMUNAT_7632 

:AMUNAT_5448
if 
84A3:   not  " + AMMU_Selected_Weapon + @" == 48 
jf @AMUNAT_5551 
0084: " + _9578 + @" = " + AMMU_Selected_Weapon_Weapon_Group + @" 
" + _9578 + @" += 1 
04B8: get_weapon_data_from_actor " + PlayerActor + @" slot " + _9578 + @" weapon " + _9572 + @" ammo " + _9573 + @" model " + _9574 + @" 
if 
803A:   not  " + _9572 + @" == " + AMMU_Selected_Weapon + @" 
jf @AMUNAT_5551 
if 
  " + _9573 + @" > 0 
jf @AMUNAT_5551 
00BC: show_text_highpriority GXT 'AMMUA' time 5000 flag 1  

:AMUNAT_5551
" + AMMU_Stage + @" = 7 
" + _9584 + @" = 0 

:AMUNAT_5565
if 
  " + AMMU_Stage + @" == 7 
jf @AMUNAT_7597 
if 
   Actor.Dead(" + AMMU_Seller + @")
jf @AMUNAT_5644 
gosub @AMUNAT_8273 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + AMMU_Interior_Name + @" 
jf @AMUNAT_5637 
gosub @AMUNAT_8535 

:AMUNAT_5637
jump @AMUNAT_640 

:AMUNAT_5644
if 
  1 > " + _9584 + @" 
jf @AMUNAT_5687 
if 
  " + _2418 + @" == 0 
jf @AMUNAT_5687 
gosub @AMUNAT_7632 

:AMUNAT_5687
if 
  " + _9584 + @" == 0 
jf @AMUNAT_5753 
if 
00E1:   player 0 pressed_key 16 
jf @AMUNAT_5729 
" + _9584 + @" = 5 

:AMUNAT_5729
if 
00E1:   player 0 pressed_key 15 
jf @AMUNAT_5753 
" + _9584 + @" = 1 

:AMUNAT_5753
if 
  " + _9584 + @" == 1 
jf @AMUNAT_5899 
if 
80E1:   not player 0 pressed_key 15 
jf @AMUNAT_5899 
if 
  " + _2418 + @" == 1 
jf @AMUNAT_5820 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
" + _2418 + @" = 0 

:AMUNAT_5820
0812: AS_actor " + AMMU_Seller + @" perform_animation " + AMMU_Seller_Animation + @" IFP ""WEAPONS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + AMMU_Seller_Animation + @"
jf @AMUNAT_5892 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + AMMU_Seller_Animation + @" time 

:AMUNAT_5892
" + _9584 + @" = 2 

:AMUNAT_5899
if 
  " + _9584 + @" == 2 
jf @AMUNAT_6095 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + AMMU_Seller_Animation + @"
jf @AMUNAT_5947 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + AMMU_Seller_Animation + @" time 

:AMUNAT_5947
if 
  " + AMMU_Seller_Animation_Time + @" == 1.0 
jf @AMUNAT_6095 
070A: AS_actor " + AMMU_Seller + @" attach_to_object " + _9543 + @" offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
Object.KeepInMemory(" + _9543 + @") = False
0812: AS_actor " + AMMU_Seller + @" perform_animation " + _9566 + @" IFP ""WEAPONS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + _9566 + @"
jf @AMUNAT_6088 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + _9566 + @" time 

:AMUNAT_6088
" + _9584 + @" = 3 

:AMUNAT_6095
if 
  " + _9584 + @" == 3 
jf @AMUNAT_6317 
if 
   Actor.Animation(" + AMMU_Seller + @") == " + _9566 + @"
jf @AMUNAT_6143 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation " + _9566 + @" time 

:AMUNAT_6143
if 
  " + AMMU_Seller_Animation_Time + @" == 1.0 
jf @AMUNAT_6317 
070B: set_actor " + AMMU_Seller + @" onbone_attached_object_operation 0 
Object.PutAt(" + _9543 + @", " + _9585 + @", " + _9586 + @", " + _9587 + @")
Object.KeepInMemory(" + _9543 + @") = True
gosub @AMUNAT_8953 
0812: AS_actor " + AMMU_Seller + @" perform_animation ""SHP_G_LIFT_OUT"" IFP ""WEAPONS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
if 
   Actor.Animation(" + AMMU_Seller + @") == ""SHP_G_LIFT_OUT""
jf @AMUNAT_6310 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation ""SHP_G_LIFT_OUT"" time 

:AMUNAT_6310
" + _9584 + @" = 4 

:AMUNAT_6317
if 
  " + _9584 + @" == 4 
jf @AMUNAT_6480 
if 
   Actor.Animation(" + AMMU_Seller + @") == ""SHP_G_LIFT_OUT""
jf @AMUNAT_6391 
0613: " + AMMU_Seller_Animation_Time + @" = actor " + AMMU_Seller + @" animation ""SHP_G_LIFT_OUT"" time 

:AMUNAT_6391
if 
  " + AMMU_Seller_Animation_Time + @" == 1.0 
jf @AMUNAT_6480 
0812: AS_actor " + AMMU_Seller + @" perform_animation ""SHP_TRAY_POSE"" IFP ""WEAPONS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + AMMU_Seller_Animation_Time + @" = 0.0 
" + _9584 + @" = 0 
" + AMMU_Stage + @" = 6 

:AMUNAT_6480
if 
  " + _9584 + @" == 5 
jf @AMUNAT_7048 
if 
80E1:   not player 0 pressed_key 16 
jf @AMUNAT_7048 
03D5: remove_text 'AMMUA'  
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'AMMUC'  
03D5: remove_text 'AMMUD'  
" + _2544 + @" = 0 
" + _9596 + @" = 0 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
if 
002C:   " + Shops_Player_Cash + @" >= " + AMMU_Weapon_Cost + @" 
jf @AMUNAT_6969 
if 
84A3:   not  " + AMMU_Selected_Weapon + @" == 48 
jf @AMUNAT_6791 
041A: " + _9573 + @" = actor " + PlayerActor + @" weapon " + AMMU_Selected_Weapon + @" ammo 
if 
  9999 > " + _9573 + @" 
jf @AMUNAT_6705 
0790: charge_money_for_shopping_item_with_textureCRC " + AMMU_Selected_Weapon + @" 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 323 unknown_flags 0 0 1 as " + _10081 + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1052 
" + _9584 + @" = 6 
TIMERB = 0 
jump @AMUNAT_6784 

:AMUNAT_6705
if 
  " + _9596 + @" == 0 
jf @AMUNAT_6784 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1053 
00BC: show_text_highpriority GXT 'AMMUC' time 5000 flag 1  
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 322 unknown_flags 0 0 1 as " + _10081 + @" 
" + _9584 + @" = 0 
" + _9596 + @" = 1 

:AMUNAT_6784
jump @AMUNAT_6962 

:AMUNAT_6791
04DD: " + _9594 + @" = actor " + PlayerActor + @" armour 
0945: get_player " + PlayerChar + @" max_armour_to " + _9595 + @" 
if 
001C:   " + _9595 + @" > " + _9594 + @" 
jf @AMUNAT_6883 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 323 unknown_flags 0 0 1 as " + _10081 + @" 
0790: charge_money_for_shopping_item_with_textureCRC " + AMMU_Selected_Weapon + @" 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1052 
" + _9584 + @" = 6 
TIMERB = 0 
jump @AMUNAT_6962 

:AMUNAT_6883
if 
  " + _9596 + @" == 0 
jf @AMUNAT_6962 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1053 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 322 unknown_flags 0 0 1 as " + _10081 + @" 
00BC: show_text_highpriority GXT 'AMMUD' time 5000 flag 1  
" + _9584 + @" = 0 
" + _9596 + @" = 1 

:AMUNAT_6962
jump @AMUNAT_7048 

:AMUNAT_6969
if 
  " + _2544 + @" == 0 
jf @AMUNAT_7048 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1053 
09D5: play_sound_of_actor " + AMMU_Seller + @" soundslot 324 unknown_flags 0 0 1 as " + _10081 + @" 
00BC: show_text_highpriority GXT 'SHOPNO' time 5000 flag 1  
" + _9584 + @" = 0 
" + _2544 + @" = 1 

:AMUNAT_7048
if 
  " + _9584 + @" == 6 
jf @AMUNAT_7480 
if 
  " + _2418 + @" == 1 
jf @AMUNAT_7098 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:AMUNAT_7098
if 
  " + _2422 + @" == 0 
jf @AMUNAT_7466 
08D4: " + _2421 + @" = create_panel_with_title 'AMMUN' position 29.0 20.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
08D6: set_panel " + _2421 + @" column 0 alignment 1 
08DB: set_panel " + _2421 + @" column 0 header 'WEAPON' data 'BOUGHT' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2421 + @" column 1 alignment 0 
08DB: set_panel " + _2421 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2421 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + AMMU_Weapon_Cost + @"  
09DB: set_panel " + _2421 + @" column 0 width 140 
09DB: set_panel " + _2421 + @" column 1 width 46 
" + _2422 + @" = 1 

:AMUNAT_7466
TIMERB = 0 
" + _9584 + @" = 7 

:AMUNAT_7480
if 
  " + _9584 + @" == 7 
jf @AMUNAT_7597 
if 
  TIMERB >= 1000 
jf @AMUNAT_7597 
if 
  " + _2422 + @" == 1 
jf @AMUNAT_7547 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:AMUNAT_7547
" + _9584 + @" = 0 
if 
  1 > " + _9584 + @" 
jf @AMUNAT_7597 
if 
  " + _2418 + @" == 0 
jf @AMUNAT_7597 
gosub @AMUNAT_7632 

:AMUNAT_7597
jump @AMUNAT_7611 

:AMUNAT_7604
gosub @AMUNAT_8535 

:AMUNAT_7611
jump @AMUNAT_7625 

:AMUNAT_7618
gosub @AMUNAT_8535 

:AMUNAT_7625
jump @AMUNAT_640 

:AMUNAT_7632
if 
  " + _2418 + @" == 0 
jf @AMUNAT_8271 
0512: show_permanent_text_box 'AMMU_H3'  
if 
04A3:   " + Current_Language + @" == 0 
jf @AMUNAT_7723 
08D4: " + _2417 + @" = create_panel_with_title 'AMMUN' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @AMUNAT_7964 

:AMUNAT_7723
if 
04A3:   " + Current_Language + @" == 1 
jf @AMUNAT_7785 
08D4: " + _2417 + @" = create_panel_with_title 'AMMUN' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @AMUNAT_7964 

:AMUNAT_7785
if 
04A3:   " + Current_Language + @" == 2 
jf @AMUNAT_7847 
08D4: " + _2417 + @" = create_panel_with_title 'AMMUN' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @AMUNAT_7964 

:AMUNAT_7847
if 
04A3:   " + Current_Language + @" == 3 
jf @AMUNAT_7909 
08D4: " + _2417 + @" = create_panel_with_title 'AMMUN' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @AMUNAT_7964 

:AMUNAT_7909
if 
04A3:   " + Current_Language + @" == 4 
jf @AMUNAT_7964 
08D4: " + _2417 + @" = create_panel_with_title 'AMMUN' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  

:AMUNAT_7964
08D6: set_panel " + _2417 + @" column 0 alignment 1 
08DB: set_panel " + _2417 + @" column 0 header 'WEAPON' data " + AMMU_Weapon_Name + @" 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2417 + @" column 1 alignment 0 
08DB: set_panel " + _2417 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2417 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + AMMU_Weapon_Cost + @"  
09DB: set_panel " + _2417 + @" column 0 width 140 
09DB: set_panel " + _2417 + @" column 1 width 46 
" + _2418 + @" = 1 

:AMUNAT_8271
return 

:AMUNAT_8273
if 
  " + _2420 + @" == 1 
jf @AMUNAT_8305 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:AMUNAT_8305
if 
  " + _2424 + @" == 1 
jf @AMUNAT_8337 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:AMUNAT_8337
if 
  " + _2418 + @" == 1 
jf @AMUNAT_8369 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
" + _2418 + @" = 0 

:AMUNAT_8369
if 
  " + _2422 + @" == 1 
jf @AMUNAT_8399 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:AMUNAT_8399
if 
  " + AMMU_Stage + @" >= 1 
jf @AMUNAT_8419 
03E6: remove_text_box 

:AMUNAT_8419
03D5: remove_text 'AMMUA'  
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'AMMUC'  
03D5: remove_text 'AMMUD'  
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + _9544 + @" = 0 
" + _9584 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9596 + @" = 0 
" + AMMU_Stage + @" = 2 
return 

:AMUNAT_8535
if 
  " + _2420 + @" == 1 
jf @AMUNAT_8567 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:AMUNAT_8567
if 
  " + _2424 + @" == 1 
jf @AMUNAT_8599 
03E6: remove_text_box 
08DA: remove_panel " + _2423 + @" 
" + _2424 + @" = 0 

:AMUNAT_8599
if 
  " + _2418 + @" == 1 
jf @AMUNAT_8631 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
" + _2418 + @" = 0 

:AMUNAT_8631
if 
  " + _2422 + @" == 1 
jf @AMUNAT_8661 
08DA: remove_panel " + _2421 + @" 
" + _2422 + @" = 0 

:AMUNAT_8661
if 
  " + AMMU_Stage + @" >= 1 
jf @AMUNAT_8681 
03E6: remove_text_box 

:AMUNAT_8681
03D5: remove_text 'AMMUA'  
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'AMMUC'  
03D5: remove_text 'AMMUD'  
" + _2420 + @" = 0 
" + _2424 + @" = 0 
" + flag_AMMU_Seller_Attack_Player + @" = 0 
" + _9544 + @" = 0 
" + _9584 + @" = 0 
" + _2418 + @" = 0 
" + _2422 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9596 + @" = 0 
" + AMMU_Stage + @" = 0 
Model.Destroy(#COLT45)
Model.Destroy(#SILENCED)
Model.Destroy(#DESERT_EAGLE)
Model.Destroy(#CHROMEGUN)
Model.Destroy(#SAWNOFF)
Model.Destroy(#SHOTGSPA)
Model.Destroy(#GRENADE)
Model.Destroy(#MICRO_UZI)
Model.Destroy(#MP5LNG)
Model.Destroy(#TEC9)
Model.Destroy(#AK47)
Model.Destroy(#M4)
Model.Destroy(#CUNTGUN)
Model.Destroy(#SNIPER)
Model.Destroy(#ARMOUR)
Model.Destroy(#SATCHEL)
Model.Destroy(#BOMB)
03F0: enable_text_draw 0 
Model.Destroy(" + Seller_Model + @")
Actor.DestroyInstantly(" + AMMU_Seller + @")
08F8: display_stat_update_box 1 
0581: enable_radar 1 
09BD: allow_other_threads_to_display_text_boxes 0 
if 
  " + _5274 + @" == 1 
jf @AMUNAT_8949 
03E5: show_text_box 'ANR_56'  
" + _5274 + @" = 0 

:AMUNAT_8949
end_thread 
return 

:AMUNAT_8953
Object.Destroy(" + _9543 + @")
return 

:AMUNAT_8960
if or
04A3:   " + AMMU_Selected_Weapon_Model + @" == 349 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 351 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 355 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 356 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 358 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 357 
jf @AMUNAT_9113 
06D1: " + _9554 + @" = ""SHP_2H_LIFT"" 
06D1: " + _9558 + @" = ""SHP_2H_LIFT_END"" 
0086: " + _9585 + @" = " + AMMU_X_Seller + @" 
" + _9585 + @" += 0.231 
0086: " + _9586 + @" = " + AMMU_Y_Seller + @" 
" + _9586 + @" += 0.636 
0086: " + _9587 + @" = " + AMMU_Z_Seller + @" 
" + _9587 + @" += 1.053 

:AMUNAT_9113
if 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 350 
jf @AMUNAT_9226 
06D1: " + _9554 + @" = ""SHP_2H_LIFT"" 
06D1: " + _9558 + @" = ""SHP_2H_LIFT_END"" 
0086: " + _9585 + @" = " + AMMU_X_Seller + @" 
" + _9585 + @" += 0.231 
0086: " + _9586 + @" = " + AMMU_Y_Seller + @" 
" + _9586 + @" += 0.636 
0086: " + _9587 + @" = " + AMMU_Z_Seller + @" 
" + _9587 + @" += 1.053 

:AMUNAT_9226
if or
04A3:   " + AMMU_Selected_Weapon_Model + @" == 346 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 347 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 348 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 342 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 352 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 353 
jf @AMUNAT_9379 
06D1: " + _9554 + @" = ""SHP_1H_LIFT"" 
06D1: " + _9558 + @" = ""SHP_1H_LIFT_END"" 
0086: " + _9585 + @" = " + AMMU_X_Seller + @" 
" + _9585 + @" += 0.108 
0086: " + _9586 + @" = " + AMMU_Y_Seller + @" 
" + _9586 + @" += 0.654 
0086: " + _9587 + @" = " + AMMU_Z_Seller + @" 
" + _9587 + @" += 1.053 

:AMUNAT_9379
if or
04A3:   " + AMMU_Selected_Weapon_Model + @" == 363 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 372 
jf @AMUNAT_9500 
06D1: " + _9554 + @" = ""SHP_1H_LIFT"" 
06D1: " + _9558 + @" = ""SHP_1H_LIFT_END"" 
0086: " + _9585 + @" = " + AMMU_X_Seller + @" 
" + _9585 + @" += 0.108 
0086: " + _9586 + @" = " + AMMU_Y_Seller + @" 
" + _9586 + @" += 0.654 
0086: " + _9587 + @" = " + AMMU_Z_Seller + @" 
" + _9587 + @" += 1.053 

:AMUNAT_9500
if 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 373 
jf @AMUNAT_9613 
06D1: " + _9554 + @" = ""SHP_AR_LIFT"" 
06D1: " + _9558 + @" = ""SHP_AR_LIFT_END"" 
0086: " + _9585 + @" = " + AMMU_X_Seller + @" 
" + _9585 + @" += 0.175 
0086: " + _9586 + @" = " + AMMU_Y_Seller + @" 
" + _9586 + @" += 0.676 
0086: " + _9587 + @" = " + AMMU_Z_Seller + @" 
" + _9587 + @" += 1.5 

:AMUNAT_9613
return 

:AMUNAT_9615
if or
04A3:   " + AMMU_Selected_Weapon_Model + @" == 349 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 351 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 355 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 356 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 358 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 357 
jf @AMUNAT_9710 
06D1: " + AMMU_Seller_Animation + @" = ""SHP_2H_RET_S"" 
06D1: " + _9566 + @" = ""SHP_2H_RET"" 

:AMUNAT_9710
if 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 350 
jf @AMUNAT_9765 
06D1: " + AMMU_Seller_Animation + @" = ""SHP_2H_RET_S"" 
06D1: " + _9566 + @" = ""SHP_2H_RET"" 

:AMUNAT_9765
if or
04A3:   " + AMMU_Selected_Weapon_Model + @" == 346 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 347 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 348 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 342 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 352 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 353 
jf @AMUNAT_9860 
06D1: " + AMMU_Seller_Animation + @" = ""SHP_1H_RET_S"" 
06D1: " + _9566 + @" = ""SHP_1H_RET"" 

:AMUNAT_9860
if or
04A3:   " + AMMU_Selected_Weapon_Model + @" == 363 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 372 
jf @AMUNAT_9923 
06D1: " + AMMU_Seller_Animation + @" = ""SHP_1H_RET_S"" 
06D1: " + _9566 + @" = ""SHP_1H_RET"" 

:AMUNAT_9923
if 
04A3:   " + AMMU_Selected_Weapon_Model + @" == 373 
jf @AMUNAT_9978 
06D1: " + AMMU_Seller_Animation + @" = ""SHP_AR_RET_S"" 
06D1: " + _9566 + @" = ""SHP_AR_RET"" 

:AMUNAT_9978
return 

:AMUNAT_9980
" + _9597 + @" = 0 
" + _9616 + @" = 0 
" + _2515 + @" = 0 
" + _9598 + @" = 0 
" + _9599 + @" = 0 
" + _9600 + @" = 0 
" + _9601 + @" = 0 
" + _9602 + @" = 0 
" + _9603 + @" = 0 
" + _9604 + @" = 0 
" + _9605 + @" = 0 
" + _9606 + @" = 0 
" + _9607 + @" = 0 
" + _9608 + @" = 0 
" + _9609 + @" = 0 
" + _9610 + @" = 0 
" + _9611 + @" = 0 
" + _9612 + @" = 0 
" + _9613 + @" = 0 
" + _9614 + @" = 0 
" + _9615 + @" = 0 

:AMUNAT_10127
if 
001C:   " + AMMU_Available_Weapons + @" > " + _9597 + @" 
jf @AMUNAT_10904 
0760: store_shopping_data_index " + _9597 + @" textureCRC_to " + AMMU_Selected_Weapon + @" 
0871: init_jump_table " + AMMU_Selected_Weapon + @" total_jumps 16 default_jump 0 @AMUNAT_10890 jumps 16 @AMUNAT_10738 22 @AMUNAT_10282 23 @AMUNAT_10282 24 @AMUNAT_10282 25 @AMUNAT_10358 26 @AMUNAT_10358 27 @AMUNAT_10358 
0872: jump_table_jumps 28 @AMUNAT_10434 29 @AMUNAT_10510 30 @AMUNAT_10586 31 @AMUNAT_10586 32 @AMUNAT_10434 33 @AMUNAT_10662 34 @AMUNAT_10662 39 @AMUNAT_10738 48 @AMUNAT_10814 

:AMUNAT_10282
0084: " + tmp_9617 + @"(" + _9598 + @",3i) = " + AMMU_Selected_Weapon + @" 
" + _9598 + @" += 1 
if 
  " + _9607 + @" == 0 
jf @AMUNAT_10351 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN1' 
" + _9616 + @" += 1 
" + _9607 + @" = 1 

:AMUNAT_10351
jump @AMUNAT_10890 

:AMUNAT_10358
0084: " + tmp_9620 + @"(" + _9599 + @",3i) = " + AMMU_Selected_Weapon + @" 
" + _9599 + @" += 1 
if 
  " + _9608 + @" == 0 
jf @AMUNAT_10427 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN2' 
" + _9616 + @" += 1 
" + _9608 + @" = 1 

:AMUNAT_10427
jump @AMUNAT_10890 

:AMUNAT_10434
0084: " + tmp_9623 + @"(" + _9600 + @",2i) = " + AMMU_Selected_Weapon + @" 
" + _9600 + @" += 1 
if 
  " + _9609 + @" == 0 
jf @AMUNAT_10503 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN3' 
" + _9616 + @" += 1 
" + _9609 + @" = 1 

:AMUNAT_10503
jump @AMUNAT_10890 

:AMUNAT_10510
0084: " + tmp_9625 + @"(" + _9601 + @",1i) = " + AMMU_Selected_Weapon + @" 
" + _9601 + @" += 1 
if 
  " + _9610 + @" == 0 
jf @AMUNAT_10579 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN4' 
" + _9616 + @" += 1 
" + _9610 + @" = 1 

:AMUNAT_10579
jump @AMUNAT_10890 

:AMUNAT_10586
0084: " + tmp_9626 + @"(" + _9602 + @",2i) = " + AMMU_Selected_Weapon + @" 
" + _9602 + @" += 1 
if 
  " + _9611 + @" == 0 
jf @AMUNAT_10655 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN5' 
" + _9616 + @" += 1 
" + _9611 + @" = 1 

:AMUNAT_10655
jump @AMUNAT_10890 

:AMUNAT_10662
0084: " + tmp_9628 + @"(" + _9604 + @",2i) = " + AMMU_Selected_Weapon + @" 
" + _9604 + @" += 1 
if 
  " + _9612 + @" == 0 
jf @AMUNAT_10731 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN6' 
" + _9616 + @" += 1 
" + _9612 + @" = 1 

:AMUNAT_10731
jump @AMUNAT_10890 

:AMUNAT_10738
0084: " + tmp_9630 + @"(" + _9603 + @",2i) = " + AMMU_Selected_Weapon + @" 
" + _9603 + @" += 1 
if 
  " + _9613 + @" == 0 
jf @AMUNAT_10807 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN7' 
" + _9616 + @" += 1 
" + _9613 + @" = 1 

:AMUNAT_10807
jump @AMUNAT_10890 

:AMUNAT_10814
0084: " + tmp_9632 + @"(" + _9605 + @",1i) = " + AMMU_Selected_Weapon + @" 
" + _9605 + @" += 1 
if 
  " + _9614 + @" == 0 
jf @AMUNAT_10883 
05A9: " + tmp_2450 + @"(" + _9616 + @",12s) = 'GUN8' 
" + _9616 + @" += 1 
" + _9614 + @" = 1 

:AMUNAT_10883
jump @AMUNAT_10890 

:AMUNAT_10890
" + _9597 + @" += 1 
jump @AMUNAT_10127 

:AMUNAT_10904
0084: " + _2515 + @" = " + _9616 + @" 

:AMUNAT_10912
if 
  12 > " + _2515 + @" 
jf @AMUNAT_10984 
" + tmp_2438 + @"(" + _2515 + @",12i) = -1 
" + tmp_2426 + @"(" + _2515 + @",12i) = 0 
05A9: " + tmp_2450 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @AMUNAT_10912 

:AMUNAT_10984
return 

:AMUNAT_10986
if 
  " + _2420 + @" == 0 
jf @AMUNAT_11386 
0512: show_permanent_text_box 'AMMU_H'  
if 
04A3:   " + Current_Language + @" == 0 
jf @AMUNAT_11077 
08D4: " + _2419 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_11318 

:AMUNAT_11077
if 
04A3:   " + Current_Language + @" == 1 
jf @AMUNAT_11139 
08D4: " + _2419 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_11318 

:AMUNAT_11139
if 
04A3:   " + Current_Language + @" == 2 
jf @AMUNAT_11201 
08D4: " + _2419 + @" = create_panel_with_title 'AMMUN' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_11318 

:AMUNAT_11201
if 
04A3:   " + Current_Language + @" == 3 
jf @AMUNAT_11263 
08D4: " + _2419 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_11318 

:AMUNAT_11263
if 
04A3:   " + Current_Language + @" == 4 
jf @AMUNAT_11318 
08D4: " + _2419 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:AMUNAT_11318
08D6: set_panel " + _2419 + @" column 0 alignment 1 
08DB: set_panel " + _2419 + @" column 0 header 'DUMMY' data " + str_2450 + @"[0] " + str_2450 + @"[1] " + str_2450 + @"[2] " + str_2450 + @"[3] " + str_2450 + @"[4] " + str_2450 + @"[5] " + str_2450 + @"[6] " + str_2450 + @"[7] " + str_2450 + @"[8] " + str_2450 + @"[9] " + str_2450 + @"[10] " + str_2450 + @"[11] 
" + _2420 + @" = 1 

:AMUNAT_11386
return 

:AMUNAT_11388
" + _9636 + @" = 0 
if 
05AD:   " + _9549 + @" == 'GUN1' 
jf @AMUNAT_11493 

:AMUNAT_11420
if 
001C:   " + _9598 + @" > " + _9636 + @" 
jf @AMUNAT_11493 
078C: get_shopping_item_with_textureCRC " + tmp_9617 + @"(" + _9636 + @",3i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9617 + @"(" + _9636 + @",3i) 
" + _9636 + @" += 1 
jump @AMUNAT_11420 

:AMUNAT_11493
if 
05AD:   " + _9549 + @" == 'GUN2' 
jf @AMUNAT_11591 

:AMUNAT_11518
if 
001C:   " + _9599 + @" > " + _9636 + @" 
jf @AMUNAT_11591 
078C: get_shopping_item_with_textureCRC " + tmp_9620 + @"(" + _9636 + @",3i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9620 + @"(" + _9636 + @",3i) 
" + _9636 + @" += 1 
jump @AMUNAT_11518 

:AMUNAT_11591
if 
05AD:   " + _9549 + @" == 'GUN3' 
jf @AMUNAT_11689 

:AMUNAT_11616
if 
001C:   " + _9600 + @" > " + _9636 + @" 
jf @AMUNAT_11689 
078C: get_shopping_item_with_textureCRC " + tmp_9623 + @"(" + _9636 + @",2i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9623 + @"(" + _9636 + @",2i) 
" + _9636 + @" += 1 
jump @AMUNAT_11616 

:AMUNAT_11689
if 
05AD:   " + _9549 + @" == 'GUN4' 
jf @AMUNAT_11787 

:AMUNAT_11714
if 
001C:   " + _9601 + @" > " + _9636 + @" 
jf @AMUNAT_11787 
078C: get_shopping_item_with_textureCRC " + tmp_9625 + @"(" + _9636 + @",1i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9625 + @"(" + _9636 + @",1i) 
" + _9636 + @" += 1 
jump @AMUNAT_11714 

:AMUNAT_11787
if 
05AD:   " + _9549 + @" == 'GUN5' 
jf @AMUNAT_11885 

:AMUNAT_11812
if 
001C:   " + _9602 + @" > " + _9636 + @" 
jf @AMUNAT_11885 
078C: get_shopping_item_with_textureCRC " + tmp_9626 + @"(" + _9636 + @",2i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9626 + @"(" + _9636 + @",2i) 
" + _9636 + @" += 1 
jump @AMUNAT_11812 

:AMUNAT_11885
if 
05AD:   " + _9549 + @" == 'GUN6' 
jf @AMUNAT_11983 

:AMUNAT_11910
if 
001C:   " + _9604 + @" > " + _9636 + @" 
jf @AMUNAT_11983 
078C: get_shopping_item_with_textureCRC " + tmp_9628 + @"(" + _9636 + @",2i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9628 + @"(" + _9636 + @",2i) 
" + _9636 + @" += 1 
jump @AMUNAT_11910 

:AMUNAT_11983
if 
05AD:   " + _9549 + @" == 'GUN7' 
jf @AMUNAT_12081 

:AMUNAT_12008
if 
001C:   " + _9603 + @" > " + _9636 + @" 
jf @AMUNAT_12081 
078C: get_shopping_item_with_textureCRC " + tmp_9630 + @"(" + _9636 + @",2i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9630 + @"(" + _9636 + @",2i) 
" + _9636 + @" += 1 
jump @AMUNAT_12008 

:AMUNAT_12081
if 
05AD:   " + _9549 + @" == 'GUN8' 
jf @AMUNAT_12179 

:AMUNAT_12106
if 
001C:   " + _9605 + @" > " + _9636 + @" 
jf @AMUNAT_12179 
078C: get_shopping_item_with_textureCRC " + tmp_9632 + @"(" + _9636 + @",1i) nametag_to " + AMMU_Weapon_Name + @" 
05A9: " + tmp_2450 + @"(" + _9636 + @",12s) = " + AMMU_Weapon_Name + @" 
0084: " + tmp_9633 + @"(" + _9636 + @",3i) = " + tmp_9632 + @"(" + _9636 + @",1i) 
" + _9636 + @" += 1 
jump @AMUNAT_12106 

:AMUNAT_12179
0084: " + _2515 + @" = " + _9636 + @" 

:AMUNAT_12187
if 
  12 > " + _2515 + @" 
jf @AMUNAT_12259 
" + tmp_2438 + @"(" + _2515 + @",12i) = -1 
" + tmp_2426 + @"(" + _2515 + @",12i) = 0 
05A9: " + tmp_2450 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @AMUNAT_12187 

:AMUNAT_12259
if 
  " + _2424 + @" == 0 
jf @AMUNAT_12659 
0512: show_permanent_text_box 'AMMU_H2'  
if 
04A3:   " + Current_Language + @" == 0 
jf @AMUNAT_12350 
08D4: " + _2423 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_12591 

:AMUNAT_12350
if 
04A3:   " + Current_Language + @" == 1 
jf @AMUNAT_12412 
08D4: " + _2423 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_12591 

:AMUNAT_12412
if 
04A3:   " + Current_Language + @" == 2 
jf @AMUNAT_12474 
08D4: " + _2423 + @" = create_panel_with_title 'AMMUN' position 29.0 165.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_12591 

:AMUNAT_12474
if 
04A3:   " + Current_Language + @" == 3 
jf @AMUNAT_12536 
08D4: " + _2423 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  
jump @AMUNAT_12591 

:AMUNAT_12536
if 
04A3:   " + Current_Language + @" == 4 
jf @AMUNAT_12591 
08D4: " + _2423 + @" = create_panel_with_title 'AMMUN' position 29.0 145.0 width 186.0 columns 1 interactive 1 background 1 alignment 1  

:AMUNAT_12591
08D6: set_panel " + _2423 + @" column 0 alignment 1 
08DB: set_panel " + _2423 + @" column 0 header 'DUMMY' data " + str_2450 + @"[0] " + str_2450 + @"[1] " + str_2450 + @"[2] " + str_2450 + @"[3] " + str_2450 + @"[4] " + str_2450 + @"[5] " + str_2450 + @"[6] " + str_2450 + @"[7] " + str_2450 + @"[8] " + str_2450 + @"[9] " + str_2450 + @"[10] " + str_2450 + @"[11] 
" + _2424 + @" = 1 

:AMUNAT_12659
return 
end_thread" );
            }
           
        }

    }

}