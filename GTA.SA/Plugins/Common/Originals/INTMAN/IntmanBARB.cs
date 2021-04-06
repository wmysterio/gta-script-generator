using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BARB : External {

            Int tmp_2438 = global( _2438.startIndex ),
                tmp_2426 = global( _2426.startIndex ),
                tmp_2450 = global( _2450.startIndex ),
                tmp_2474 = global( _2474.startIndex ),
                tmp_2486 = global( _2486.startIndex ),
                tmp_2498 = global( _2498.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _9758 + @" = 0.0 
" + _9759 + @" = 0.0 
" + _9760 + @" = 0.0 
" + _9761 + @" = 0.0 
" + _9762 + @" = 0.0 
" + _9763 + @" = 0.0 
" + _9764 + @" = 0.0 
" + _9765 + @" = 0.0 
" + _9766 + @" = 0.0 
" + _9767 + @" = 0.0 
" + _9768 + @" = 0.0 
" + _9769 + @" = 0.0 
" + _9770 + @" = 0.0 
" + _9771 + @" = 0.0 
" + _9772 + @" = 0.0 
" + _9773 + @" = 0.0 
" + _9774 + @" = 0.0 
" + _9775 + @" = 0.0 
" + _9776 + @" = 0.0 
" + _9777 + @" = 0.0 
" + _9778 + @" = 0.0 
" + _9779 + @" = 0.0 
" + _9780 + @" = 0.0 
" + _9781 + @" = 0.0 
" + _9782 + @" = 0.0 
" + _9783 + @" = 0.0 
" + _9784 + @" = 0.0 
" + _9785 + @" = 0.0 
" + _9786 + @" = 0.0 
" + _9787 + @" = 0.0 
" + _9753 + @" = 0.0 
" + _9752 + @" = 0 
" + _9788 + @" = 0.0 
" + _9789 + @" = 0.0 
" + _9790 + @" = 0.0 
" + _9791 + @" = 0.0 
" + _9792 + @" = 0.0 
" + _9793 + @" = 0.0 
" + _9750 + @" = 0 
" + _9734 + @" = 0 
" + _9738 + @" = 0.0 
" + _9739 + @" = 0 
" + _9744 + @" = 0 
" + _9745 + @" = 0.0 
" + _9746 + @" = 0.0 
" + _9747 + @" = 0.0 
" + _9748 + @" = 0.0 
" + _9749 + @" = 0 
" + _2751 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9797 + @" = 0 
" + _9800 + @" = 0 
" + _9801 + @" = 0 
" + _9802 + @" = 0 
" + _9804 + @" = 0 
" + _9805 + @" = 0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBERS' 
jf @BARB_558 
04AE: " + Seller_Model + @" = 156 

:BARB_558
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBER2' 
jf @BARB_591 
04AE: " + Seller_Model + @" = 177 

:BARB_591
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBER3' 
jf @BARB_624 
04AE: " + Seller_Model + @" = 176 

:BARB_624
Model.Load(" + Seller_Model + @")
03CF: load_wav 4400 as 4 
038B: load_requested_models 
set_wb_check_to 0 

:BARB_653
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @BARB_7278 
if 
8844:   not string " + Current_Shop_GXT_Name + @" empty 
jf @BARB_7264 
if 
  " + _9744 + @" > 0 
jf @BARB_751 
if 
0A0F:   new_language_set 
jf @BARB_751 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
08DA: remove_panel " + _2419 + @" 
" + _2418 + @" = 0 
" + _2420 + @" = 0 
09FB: " + Current_Language + @" = current_language 

:BARB_751
if 
  " + _9744 + @" == 0 
jf @BARB_1015 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBERS' 
jf @BARB_851 
" + _9794 + @" = 0.0 
" + _9795 + @" = 0.0 
" + _9796 + @" = 0.0 
05A9: " + _9740 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9729 + @" 
" + _9797 + @" = 0 
" + _9744 + @" = 1 

:BARB_851
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBER2' 
jf @BARB_933 
" + _9794 + @" = 6.987 
" + _9795 + @" = -61.401 
" + _9796 + @" = 0.0 
05A9: " + _9740 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9729 + @" 
" + _9797 + @" = 0 
" + _9744 + @" = 1 

:BARB_933
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBER3' 
jf @BARB_1015 
" + _9794 + @" = 0.371 
" + _9795 + @" = -31.421 
" + _9796 + @" = 0.0 
05A9: " + _9740 + @" = " + Current_Shop_GXT_Name + @" 
075F: store_shopping_data_entries_number_to " + _9729 + @" 
" + _9797 + @" = 0 
" + _9744 + @" = 1 

:BARB_1015
if 
  " + _9744 + @" == 1 
jf @BARB_2030 
03F0: enable_text_draw 1 
08F8: display_stat_update_box 0 
0793: save_player_clothes 
" + X_Buy_Marker + @" = 414.3 
0059: " + X_Buy_Marker + @" += " + _9794 + @" 
" + Y_Buy_Marker + @" = -19.9 
0059: " + Y_Buy_Marker + @" += " + _9795 + @" 
" + Z_Buy_Marker + @" = 1000.806 
0059: " + Z_Buy_Marker + @" += " + _9796 + @" 
" + _9753 + @" = 90.0 
" + _9745 + @" = 414.3 
" + _9745 + @" -= 0.027 
0059: " + _9745 + @" += " + _9794 + @" 
" + _9746 + @" = -19.9 
" + _9746 + @" += 1.898 
0059: " + _9746 + @" += " + _9795 + @" 
" + _9747 + @" = 1000.86 
" + _9748 + @" = 180.0 
" + _9758 + @" = 412.0009 
0059: " + _9758 + @" += " + _9794 + @" 
" + _9759 + @" = -19.8018 
0059: " + _9759 + @" += " + _9795 + @" 
" + _9760 + @" = 1001.765 
0059: " + _9760 + @" += " + _9796 + @" 
" + _9761 + @" = 412.8502 
0059: " + _9761 + @" += " + _9794 + @" 
" + _9762 + @" = -19.2749 
0059: " + _9762 + @" += " + _9795 + @" 
" + _9763 + @" = 1001.797 
0059: " + _9763 + @" += " + _9796 + @" 
" + _9764 + @" = 414.9329 
0059: " + _9764 + @" += " + _9794 + @" 
" + _9765 + @" = -18.4475 
0059: " + _9765 + @" += " + _9795 + @" 
" + _9766 + @" = 1002.286 
0059: " + _9766 + @" += " + _9796 + @" 
" + _9767 + @" = 414.0564 
0059: " + _9767 + @" += " + _9794 + @" 
" + _9768 + @" = -18.7965 
0059: " + _9768 + @" += " + _9795 + @" 
" + _9769 + @" = 1001.955 
0059: " + _9769 + @" += " + _9796 + @" 
" + _9770 + @" = 412.649 
0059: " + _9770 + @" += " + _9794 + @" 
" + _9771 + @" = -19.7078 
0059: " + _9771 + @" += " + _9795 + @" 
" + _9772 + @" = 1001.992 
0059: " + _9772 + @" += " + _9796 + @" 
" + _9773 + @" = 413.3581 
0059: " + _9773 + @" += " + _9794 + @" 
" + _9774 + @" = -19.0046 
0059: " + _9774 + @" += " + _9795 + @" 
" + _9775 + @" = 1002.043 
0059: " + _9775 + @" += " + _9796 + @" 
" + _9776 + @" = 414.5509 
0059: " + _9776 + @" += " + _9794 + @" 
" + _9777 + @" = -20.8773 
0059: " + _9777 + @" += " + _9795 + @" 
" + _9778 + @" = 1001.405 
0059: " + _9778 + @" += " + _9796 + @" 
" + _9779 + @" = 414.0572 
0059: " + _9779 + @" += " + _9794 + @" 
" + _9780 + @" = -20.025 
0059: " + _9780 + @" += " + _9795 + @" 
" + _9781 + @" = 1001.578 
0059: " + _9781 + @" += " + _9796 + @" 
" + _9782 + @" = 412.5159 
0059: " + _9782 + @" += " + _9794 + @" 
" + _9783 + @" = -21.7447 
0059: " + _9783 + @" += " + _9795 + @" 
" + _9784 + @" = 1001.946 
0059: " + _9784 + @" += " + _9796 + @" 
" + _9785 + @" = 412.9438 
0059: " + _9785 + @" += " + _9794 + @" 
" + _9786 + @" = -20.8411 
0059: " + _9786 + @" += " + _9795 + @" 
" + _9787 + @" = 1001.963 
0059: " + _9787 + @" += " + _9796 + @" 
" + _9788 + @" = 411.957 
0059: " + _9788 + @" += " + _9794 + @" 
" + _9789 + @" = -19.779 
0059: " + _9789 + @" += " + _9795 + @" 
" + _9790 + @" = 1000.836 
0059: " + _9790 + @" += " + _9796 + @" 
" + _9791 + @" = 411.795 
0059: " + _9791 + @" += " + _9794 + @" 
" + _9792 + @" = -23.3 
0059: " + _9792 + @" += " + _9795 + @" 
" + _9793 + @" = 1000.836 
0059: " + _9793 + @" += " + _9796 + @" 
" + _9731 + @" = Actor.Create(CivMale, " + Seller_Model + @", " + _9745 + @", " + _9746 + @", " + _9747 + @")
Actor.Angle(" + _9731 + @") = " + _9748 + @"
060B: set_actor " + _9731 + @" decision_maker_to 65542 
02A9: set_actor " + _9731 + @" immune_to_nonplayer 1 
0615: define_AS_pack_begin " + _9737 + @" 
0812: AS_actor -1 perform_animation ""BRB_IN"" IFP ""HAIRCUTS"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""BRB_LOOP"" IFP ""HAIRCUTS"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end " + _9737 + @" 
0615: define_AS_pack_begin " + _9751 + @" 
05D3: AS_actor -1 goto_point " + _9788 + @" " + _9789 + @" " + _9790 + @" mode 4 time 8000 ms 
05D3: AS_actor -1 goto_point " + _9791 + @" " + _9792 + @" " + _9793 + @" mode 4 time 8000 ms 
05D4: AS_actor -1 rotate_angle 180.0 
0616: define_AS_pack_end " + _9751 + @" 
" + _9797 + @" = 0 
" + _9744 + @" = 2 

:BARB_2030
if 
  " + _9744 + @" == 2 
jf @BARB_2439 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_2079 
gosub @BARB_7498 

:BARB_2079
if 
   not Actor.Dead(" + _9731 + @")
jf @BARB_2394 
if 
  " + _2749 + @" == 0 
jf @BARB_2342 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + _9731 + @" 
031D:   actor " + _9731 + @" hit_by_weapon 57 
jf @BARB_2181 
0647: AS_actor " + _9731 + @" clear_look_task 
0947: actor " + _9731 + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _10081 + @" 
05C4: AS_actor " + _9731 + @" hands_up -2 ms 
" + _2749 + @" = 1 
jump @BARB_2335 

:BARB_2181
if 
  " + _9802 + @" == 0 
jf @BARB_2250 
077E: get_active_interior_to " + _9803 + @" 
if 
   not " + _9803 + @" == 0 
jf @BARB_2250 
05BF: AS_actor " + _9731 + @" look_at_actor " + PlayerActor + @" -2 ms 
0947: actor " + _9731 + @" speak_from_audio_table 330 store_spoken_phrase_id_to " + _10081 + @" 
" + _9802 + @" = 1 

:BARB_2250
" + Show_Shop_Sphere + @" = 1 
if 
0102:   actor " + PlayerActor + @" in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 sphere " + Show_Shop_Sphere + @" stopped_on_foot 
jf @BARB_2335 
if 
   Player.Controllable(" + PlayerChar + @")
jf @BARB_2335 
0647: AS_actor " + _9731 + @" clear_look_task 
" + _9797 + @" = 0 
" + _9744 + @" = 3 

:BARB_2335
jump @BARB_2387 

:BARB_2342
gosub @BARB_7292 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_2380 
gosub @BARB_7498 

:BARB_2380
jump @BARB_653 

:BARB_2387
jump @BARB_2439 

:BARB_2394
gosub @BARB_7292 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_2432 
gosub @BARB_7498 

:BARB_2432
jump @BARB_653 

:BARB_2439
if 
  " + _9744 + @" == 3 
jf @BARB_2537 
Player.CanMove(" + PlayerChar + @") = False
09BD: allow_other_threads_to_display_text_boxes 1 
0581: enable_radar 0 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0792: disembark_instantly_actor " + PlayerActor + @" 
0395: clear_area 1 at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 1.0 
TIMERA = 0 
" + _9797 + @" = 0 
" + _9744 + @" = 4 

:BARB_2537
if 
  " + _9744 + @" == 4 
jf @BARB_2925 
if 
   Actor.Dead(" + _9731 + @")
jf @BARB_2616 
gosub @BARB_7292 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_2609 
gosub @BARB_7498 

:BARB_2609
jump @BARB_653 

:BARB_2616
if 
  TIMERA >= 300 
jf @BARB_2925 
Actor.StorePos(" + _9731 + @", " + _2755 + @", " + _2756 + @", " + _2757 + @")
if or
8044:   not  " + _2755 + @" == " + _9745 + @" 
8044:   not  " + _2756 + @" == " + _9746 + @" 
8044:   not  " + _2757 + @" == " + _9747 + @" 
jf @BARB_2706 
Actor.PutAt(" + _9731 + @", " + _9745 + @", " + _9746 + @", " + _9747 + @")
Actor.Angle(" + _9731 + @") = " + _9748 + @"

:BARB_2706
08C7: put_actor " + PlayerActor + @" at " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = " + _9753 + @"
0793: save_player_clothes 
08F7: get_player " + PlayerChar + @" bodypart 1 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
Camera.SetPosition(" + _9758 + @", " + _9759 + @", " + _9760 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9761 + @", " + _9762 + @", " + _9763 + @", 2)
" + _9738 + @" = 0.0 
0812: AS_actor " + PlayerActor + @" perform_animation ""BRB_SIT_IN"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
if 
  " + _676 + @" == 0 
jf @BARB_2903 
if 
  " + _169 + @" == 1 
jf @BARB_2903 
if 
  50 > " + Shops_Player_Cash + @" 
jf @BARB_2903 
Player.Money(" + PlayerChar + @") += 52

:BARB_2903
0618: assign_actor " + _9731 + @" to_AS_pack " + _9737 + @" 
" + _9797 + @" = 0 
" + _9744 + @" = 5 

:BARB_2925
if 
  " + _9744 + @" == 5 
jf @BARB_3194 
if 
   Actor.Dead(" + _9731 + @")
jf @BARB_3004 
gosub @BARB_7292 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_2997 
gosub @BARB_7498 

:BARB_2997
jump @BARB_653 

:BARB_3004
if 
   Actor.Animation(" + PlayerActor + @") == ""BRB_SIT_IN""
jf @BARB_3052 
0613: " + _9738 + @" = actor " + PlayerActor + @" animation ""BRB_SIT_IN"" time 

:BARB_3052
if 
  " + _9738 + @" == 1.0 
jf @BARB_3194 
0812: AS_actor " + PlayerActor + @" perform_animation ""BRB_SIT_LOOP"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 1 time -1 
Camera.SetPosition(" + _9764 + @", " + _9765 + @", " + _9766 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9767 + @", " + _9768 + @", " + _9769 + @", 2)
0947: actor " + _9731 + @" speak_from_audio_table 333 store_spoken_phrase_id_to " + _10081 + @" 
08F7: get_player " + PlayerChar + @" bodypart 1 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
" + _9797 + @" = 0 
" + _9744 + @" = 6 

:BARB_3194
if 
  " + _9744 + @" == 6 
jf @BARB_5429 
if 
   Actor.Dead(" + _9731 + @")
jf @BARB_3273 
gosub @BARB_7292 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_3266 
gosub @BARB_7498 

:BARB_3266
jump @BARB_653 

:BARB_3273
if 
  1 > " + _9797 + @" 
jf @BARB_3323 
if 
  " + _2420 + @" == 0 
jf @BARB_3323 
gosub @BARB_8401 
gosub @BARB_8689 

:BARB_3323
if 
  " + _9797 + @" == 0 
jf @BARB_3389 
if 
00E1:   player 0 pressed_key 16 
jf @BARB_3365 
" + _9797 + @" = 10 

:BARB_3365
if 
00E1:   player 0 pressed_key 15 
jf @BARB_3389 
" + _9797 + @" = 1 

:BARB_3389
if 
  " + _9797 + @" == 1 
jf @BARB_3559 
if 
80E1:   not player 0 pressed_key 15 
jf @BARB_3559 
if 
  " + _2418 + @" == 1 
jf @BARB_3456 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:BARB_3456
if 
  " + _2422 + @" == 1 
jf @BARB_3488 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:BARB_3488
if 
  " + _2420 + @" == 1 
jf @BARB_3520 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:BARB_3520
if 
  " + _9750 + @" == 1 
jf @BARB_3552 
" + _9797 + @" = 2 
jump @BARB_3559 

:BARB_3552
" + _9797 + @" = 5 

:BARB_3559
if 
  " + _9797 + @" == 2 
jf @BARB_3640 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_CUT_IN"" IFP ""HAIRCUTS"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
03D1: play_wav 4 
" + _9738 + @" = 0.0 
" + _9797 + @" = 3 

:BARB_3640
if 
  " + _9797 + @" == 3 
jf @BARB_3900 
if 
   Actor.Animation(" + _9731 + @") == ""BRB_CUT_IN""
jf @BARB_3706 
0613: " + _9738 + @" = actor " + _9731 + @" animation ""BRB_CUT_IN"" time 

:BARB_3706
if 
  " + _9738 + @" == 1.0 
jf @BARB_3800 
if 
  " + _9805 + @" == 0 
jf @BARB_3800 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_CUT"" IFP ""HAIRCUTS"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0794: restore_player_clothes 
Player.Build(" + PlayerChar + @")
0793: save_player_clothes 
" + _9805 + @" = 1 

:BARB_3800
if 
  " + _9805 + @" == 1 
jf @BARB_3900 
if 
03D2:   wav 4 ended 
jf @BARB_3900 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_CUT_OUT"" IFP ""HAIRCUTS"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9738 + @" = 0.0 
" + _9797 + @" = 4 
" + _9805 + @" = 0 

:BARB_3900
if 
  " + _9797 + @" == 4 
jf @BARB_3996 
if 
   Actor.Animation(" + _9731 + @") == ""BRB_CUT_OUT""
jf @BARB_3968 
0613: " + _9738 + @" = actor " + _9731 + @" animation ""BRB_CUT_OUT"" time 

:BARB_3968
if 
  " + _9738 + @" == 1.0 
jf @BARB_3996 
" + _9797 + @" = 5 

:BARB_3996
if 
  " + _9797 + @" == 5 
jf @BARB_4162 
0812: AS_actor " + PlayerActor + @" perform_animation ""BRB_SIT_OUT"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
" + _9738 + @" = 0.0 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_OUT"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
05BF: AS_actor " + _9731 + @" look_at_actor " + PlayerActor + @" -2 ms 
Camera.SetPosition(" + _9776 + @", " + _9777 + @", " + _9778 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9779 + @", " + _9780 + @", " + _9781 + @", 2)
" + _9797 + @" = 6 

:BARB_4162
if 
  " + _9797 + @" == 6 
jf @BARB_4323 
if 
   Actor.Animation(" + PlayerActor + @") == ""BRB_SIT_OUT""
jf @BARB_4230 
0613: " + _9738 + @" = actor " + PlayerActor + @" animation ""BRB_SIT_OUT"" time 

:BARB_4230
if 
  " + _9738 + @" >= 0.8 
jf @BARB_4323 
0618: assign_actor " + PlayerActor + @" to_AS_pack " + _9751 + @" 
0947: actor " + _9731 + @" speak_from_audio_table 331 store_spoken_phrase_id_to " + _10081 + @" 
Camera.SetPosition(" + _9782 + @", " + _9783 + @", " + _9784 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9785 + @", " + _9786 + @", " + _9787 + @", 2)
TIMERA = 0 
" + _9797 + @" = 7 

:BARB_4323
if 
  " + _9797 + @" == 7 
jf @BARB_4463 
if 
  " + _9804 + @" == 0 
jf @BARB_4389 
if 
  TIMERA >= 1500 
jf @BARB_4389 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
" + _9804 + @" = 1 

:BARB_4389
if 
  " + _9744 + @" > 2 
jf @BARB_4409 
03E6: remove_text_box 

:BARB_4409
062E: get_actor " + PlayerActor + @" task 1560 status_store_to " + _9752 + @" 
if 
84A3:   not  " + _9752 + @" == 7 
jf @BARB_4456 
062E: get_actor " + PlayerActor + @" task 1560 status_store_to " + _9752 + @" 
jump @BARB_4463 

:BARB_4456
" + _9797 + @" = 8 

:BARB_4463
if 
  " + _9797 + @" == 8 
jf @BARB_4529 
0647: AS_actor " + _9731 + @" clear_look_task 
Actor.Angle(" + PlayerActor + @") = 180.0
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
09BD: allow_other_threads_to_display_text_boxes 0 
0581: enable_radar 1 
" + _9804 + @" = 0 
" + _9797 + @" = 9 

:BARB_4529
if 
  " + _9797 + @" == 9 
jf @BARB_4719 
if 
80FF:   not actor " + PlayerActor + @" sphere 1 in_sphere " + X_Buy_Marker + @" " + Y_Buy_Marker + @" " + Z_Buy_Marker + @" radius 1.0 1.0 4.0 on_foot 
jf @BARB_4645 
" + _9730 + @" = 0 
" + _9749 + @" = 0 
" + _9750 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9804 + @" = 0 
" + _9797 + @" = 0 
" + _9744 + @" = 2 

:BARB_4645
if 
  " + _2749 + @" == 0 
jf @BARB_4719 
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
0457:   player " + PlayerChar + @" aiming_at_actor " + _9731 + @" 
031D:   actor " + _9731 + @" hit_by_weapon 57 
jf @BARB_4719 
0947: actor " + _9731 + @" speak_from_audio_table 327 store_spoken_phrase_id_to " + _10081 + @" 
05C4: AS_actor " + _9731 + @" hands_up -2 ms 
" + _2749 + @" = 1 

:BARB_4719
if 
  " + _9797 + @" == 10 
jf @BARB_5013 
if 
80E1:   not player 0 pressed_key 16 
jf @BARB_5013 
08D8: " + _9734 + @" = panel " + _2419 + @" selected_row 
if 
  0 > " + _9734 + @" 
jf @BARB_4787 
" + _9734 + @" = 0 

:BARB_4787
if 
  " + _2420 + @" == 1 
jf @BARB_4819 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:BARB_4819
0760: store_shopping_data_index " + _9734 + @" textureCRC_to " + _9733 + @" 
078C: get_shopping_item_with_textureCRC " + _9733 + @" nametag_to " + _9742 + @" 
0761: get_shopping_item_with_textureCRC " + _9733 + @" price_to " + _9732 + @" 
0783: get_shopping_item_with_textureCRC " + _9733 + @" flag 0 store_to " + _9735 + @" 
0783: get_shopping_item_with_textureCRC " + _9733 + @" flag 1 store_to " + _9736 + @" 
0084: " + _2751 + @" = " + _9732 + @" 
05A9: " + _2752 + @" = " + _9742 + @" 
Camera.SetPosition(" + _9764 + @", " + _9765 + @", " + _9766 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9767 + @", " + _9768 + @", " + _9769 + @", 2)
0812: AS_actor " + _9731 + @" perform_animation ""BRB_CUT_IN"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
08F7: get_player " + PlayerChar + @" bodypart 1 textureCRC_to " + _9798 + @" modelCRC_to " + _9799 + @" 
if 
803A:   not  " + _9798 + @" == " + _9733 + @" 
jf @BARB_4996 
03D1: play_wav 4 

:BARB_4996
" + _9738 + @" = 0.0 
" + _9797 + @" = 11 

:BARB_5013
if 
  " + _9797 + @" == 11 
jf @BARB_5183 
if 
   Actor.Animation(" + _9731 + @") == ""BRB_CUT_IN""
jf @BARB_5079 
0613: " + _9738 + @" = actor " + _9731 + @" animation ""BRB_CUT_IN"" time 

:BARB_5079
if 
  " + _9738 + @" == 1.0 
jf @BARB_5183 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_CUT"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0784: set_player " + PlayerChar + @" textureCRC 0 modelCRC 0 bodypart 16 
0784: set_player " + PlayerChar + @" textureCRC " + _9733 + @" modelCRC " + _9735 + @" bodypart " + _9736 + @" 
Player.Build(" + PlayerChar + @")
" + _9750 + @" = 1 
" + _9797 + @" = 12 

:BARB_5183
if 
  " + _9797 + @" == 12 
jf @BARB_5276 
if 
03D2:   wav 4 ended 
jf @BARB_5276 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_CUT_OUT"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9738 + @" = 0.0 
" + _9797 + @" = 13 

:BARB_5276
if 
  " + _9797 + @" == 13 
jf @BARB_5429 
if 
   Actor.Animation(" + _9731 + @") == ""BRB_CUT_OUT""
jf @BARB_5344 
0613: " + _9738 + @" = actor " + _9731 + @" animation ""BRB_CUT_OUT"" time 

:BARB_5344
if 
  " + _9738 + @" == 1.0 
jf @BARB_5429 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_LOOP"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
" + _9738 + @" = 0.0 
" + _9797 + @" = 0 
" + _9744 + @" = 7 

:BARB_5429
if 
  " + _9744 + @" == 7 
jf @BARB_7257 
if 
   Actor.Dead(" + _9731 + @")
jf @BARB_5508 
gosub @BARB_7292 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
if 
85AD:   not  " + Current_Shop_GXT_Name + @" == " + _9740 + @" 
jf @BARB_5501 
gosub @BARB_7498 

:BARB_5501
jump @BARB_653 

:BARB_5508
if 
  " + _2418 + @" == 0 
jf @BARB_5551 
if 
  1 > " + _9797 + @" 
jf @BARB_5551 
gosub @BARB_7760 

:BARB_5551
if 
  " + _9797 + @" == 0 
jf @BARB_5675 
if 
00E1:   player 0 pressed_key 16 
jf @BARB_5629 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'BARBNO'  
" + _2544 + @" = 0 
" + _2545 + @" = 0 
" + _9797 + @" = 2 

:BARB_5629
if 
00E1:   player 0 pressed_key 15 
jf @BARB_5675 
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'BARBNO'  
" + _9797 + @" = 1 

:BARB_5675
if 
  " + _9797 + @" == 1 
jf @BARB_5788 
if 
80E1:   not player 0 pressed_key 15 
jf @BARB_5788 
if 
  " + _2418 + @" == 1 
jf @BARB_5742 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
" + _2418 + @" = 0 

:BARB_5742
if 
  " + _2420 + @" == 0 
jf @BARB_5774 
gosub @BARB_8401 
gosub @BARB_8689 

:BARB_5774
" + _9797 + @" = 0 
" + _9744 + @" = 6 

:BARB_5788
if 
  " + _9797 + @" == 2 
jf @BARB_6912 
if 
80E1:   not player 0 pressed_key 16 
jf @BARB_6912 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + Shops_Player_Cash + @" = Player.Money(" + PlayerChar + @")
if 
002C:   " + Shops_Player_Cash + @" >= " + _9732 + @" 
jf @BARB_6839 
if 
803A:   not  " + _2542 + @" == " + _9733 + @" 
jf @BARB_6759 
if 
  " + _2418 + @" == 1 
jf @BARB_5915 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:BARB_5915
0947: actor " + _9731 + @" speak_from_audio_table 323 store_spoken_phrase_id_to " + _10081 + @" 
0790: charge_money_for_shopping_item_with_textureCRC " + _9733 + @" 
" + _9749 + @" = 1 
" + _9750 + @" = 0 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1054 
0793: save_player_clothes 
08F7: get_player " + PlayerChar + @" bodypart 1 textureCRC_to " + _2542 + @" modelCRC_to " + _2543 + @" 
Camera.SetPosition(" + _9770 + @", " + _9771 + @", " + _9772 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9773 + @", " + _9774 + @", " + _9775 + @", 2)
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBERS' 
jf @BARB_6284 
if or
05AD:   " + _9742 + @" == 'TASH' 
05AD:   " + _9742 + @" == 'GOATEE' 
05AD:   " + _9742 + @" == 'BEARD' 
05AD:   " + _9742 + @" == 'AFROT' 
05AD:   " + _9742 + @" == 'AFROB' 
05AD:   " + _9742 + @" == 'AFROGOT' 
jf @BARB_6159 
06D1: " + _9754 + @" = ""BRB_BEARD_01"" 
jump @BARB_6284 

:BARB_6159
if 
  " + _9739 + @" > 1 
jf @BARB_6184 
" + _9739 + @" = 0 

:BARB_6184
if 
  0 > " + _9739 + @" 
jf @BARB_6209 
" + _9739 + @" = 0 

:BARB_6209
if 
  " + _9739 + @" == 0 
jf @BARB_6259 
06D1: " + _9754 + @" = ""BRB_HAIR_01"" 
" + _9739 + @" += 1 
jump @BARB_6284 

:BARB_6259
06D1: " + _9754 + @" = ""BRB_HAIR_02"" 
" + _9739 + @" -= 1 

:BARB_6284
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBER2' 
jf @BARB_6434 
if 
  " + _9739 + @" > 1 
jf @BARB_6334 
" + _9739 + @" = 0 

:BARB_6334
if 
  0 > " + _9739 + @" 
jf @BARB_6359 
" + _9739 + @" = 0 

:BARB_6359
if 
  " + _9739 + @" == 0 
jf @BARB_6409 
06D1: " + _9754 + @" = ""BRB_HAIR_01"" 
" + _9739 + @" += 1 
jump @BARB_6434 

:BARB_6409
06D1: " + _9754 + @" = ""BRB_HAIR_02"" 
" + _9739 + @" -= 1 

:BARB_6434
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'BARBER3' 
jf @BARB_6663 
if or
05AD:   " + _9742 + @" == 'BLADBEA' 
05AD:   " + _9742 + @" == 'BALDTSH' 
05AD:   " + _9742 + @" == 'BALDGOT' 
jf @BARB_6538 
06D1: " + _9754 + @" = ""BRB_BEARD_01"" 
jump @BARB_6663 

:BARB_6538
if 
  " + _9739 + @" > 1 
jf @BARB_6563 
" + _9739 + @" = 0 

:BARB_6563
if 
  0 > " + _9739 + @" 
jf @BARB_6588 
" + _9739 + @" = 0 

:BARB_6588
if 
  " + _9739 + @" == 0 
jf @BARB_6638 
06D1: " + _9754 + @" = ""BRB_HAIR_01"" 
" + _9739 + @" += 1 
jump @BARB_6663 

:BARB_6638
06D1: " + _9754 + @" = ""BRB_HAIR_02"" 
" + _9739 + @" -= 1 

:BARB_6663
0812: AS_actor " + _9731 + @" perform_animation ""BRB_BUY"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor " + PlayerActor + @" perform_animation " + _9754 + @" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
" + _9738 + @" = 0.0 
" + _9797 + @" = 3 
jump @BARB_6832 

:BARB_6759
if 
  " + _2545 + @" == 0 
jf @BARB_6832 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + _9731 + @" speak_from_audio_table 322 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'BARBNO' time 5000 flag 1  
" + _9797 + @" = 0 
" + _2545 + @" = 1 

:BARB_6832
jump @BARB_6912 

:BARB_6839
if 
  " + _2544 + @" == 0 
jf @BARB_6912 
097A: play_audio_at " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" event 1055 
0947: actor " + _9731 + @" speak_from_audio_table 324 store_spoken_phrase_id_to " + _10081 + @" 
00BC: show_text_highpriority GXT 'SHOPNO' time 5000 flag 1  
" + _9797 + @" = 0 
" + _2544 + @" = 1 

:BARB_6912
if 
  " + _9797 + @" == 3 
jf @BARB_7257 
if 
   Actor.Animation(" + PlayerActor + @") == " + _9754 + @"
jf @BARB_6960 
0613: " + _9738 + @" = actor " + PlayerActor + @" animation " + _9754 + @" time 

:BARB_6960
if 
  " + _9738 + @" == 1.0 
jf @BARB_7257 
if 
  " + _2422 + @" == 1 
jf @BARB_7013 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:BARB_7013
if 
  " + _2418 + @" == 1 
jf @BARB_7045 
03E6: remove_text_box 
08DA: remove_panel " + _2417 + @" 
" + _2418 + @" = 0 

:BARB_7045
0812: AS_actor " + PlayerActor + @" perform_animation ""BRB_SIT_LOOP"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor " + _9731 + @" perform_animation ""BRB_LOOP"" IFP ""HAIRCUTS"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
if 
  " + _676 + @" == 0 
jf @BARB_7172 
if 
  " + OnMission + @" == 1 
jf @BARB_7172 
" + _676 + @" = 1 

:BARB_7172
Camera.SetPosition(" + _9764 + @", " + _9765 + @", " + _9766 + @", 0.0, 0.0, 0.0)
Camera.PointAt(" + _9767 + @", " + _9768 + @", " + _9769 + @", 2)
if 
  " + _2420 + @" == 0 
jf @BARB_7243 
gosub @BARB_8401 
gosub @BARB_8689 

:BARB_7243
" + _9797 + @" = 0 
" + _9744 + @" = 6 

:BARB_7257
jump @BARB_7271 

:BARB_7264
gosub @BARB_7498 

:BARB_7271
jump @BARB_7285 

:BARB_7278
gosub @BARB_7498 

:BARB_7285
jump @BARB_653 

:BARB_7292
if 
  " + _9744 + @" > 0 
jf @BARB_7312 
03E6: remove_text_box 

:BARB_7312
if 
  " + _2418 + @" == 1 
jf @BARB_7344 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:BARB_7344
if 
  " + _2422 + @" == 1 
jf @BARB_7376 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:BARB_7376
if 
  " + _2420 + @" == 1 
jf @BARB_7408 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:BARB_7408
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'BARBNO'  
" + _9744 + @" = 2 
" + _9804 + @" = 0 
" + _9730 + @" = 0 
" + _9749 + @" = 0 
" + _9738 + @" = 0.0 
" + _9750 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9805 + @" = 0 
return 

:BARB_7498
03D5: remove_text 'SHOPNO'  
03D5: remove_text 'BARBNO'  
if 
  " + _9744 + @" > 0 
jf @BARB_7540 
03E6: remove_text_box 

:BARB_7540
if 
  " + _2418 + @" == 1 
jf @BARB_7572 
08DA: remove_panel " + _2417 + @" 
03E6: remove_text_box 
" + _2418 + @" = 0 

:BARB_7572
if 
  " + _2422 + @" == 1 
jf @BARB_7604 
08DA: remove_panel " + _2421 + @" 
03E6: remove_text_box 
" + _2422 + @" = 0 

:BARB_7604
if 
  " + _2420 + @" == 1 
jf @BARB_7636 
03E6: remove_text_box 
08DA: remove_panel " + _2419 + @" 
" + _2420 + @" = 0 

:BARB_7636
" + _9802 + @" = 0 
" + _9730 + @" = 0 
" + _2749 + @" = 0 
" + _9744 + @" = 0 
" + _9749 + @" = 0 
" + _9738 + @" = 0.0 
" + _9750 + @" = 0 
" + _2545 + @" = 0 
" + _2544 + @" = 0 
" + _9804 + @" = 0 
061B: remove_references_to_AS_pack " + _9737 + @" 
061B: remove_references_to_AS_pack " + _9751 + @" 
Model.Destroy(" + Seller_Model + @")
Actor.DestroyInstantly(" + _9731 + @")
0581: enable_radar 1 
03F0: enable_text_draw 0 
08F8: display_stat_update_box 1 
09BD: allow_other_threads_to_display_text_boxes 0 
040D: unload_wav 4 
" + _9805 + @" = 0 
end_thread 
return 

:BARB_7760
if 
  " + _2418 + @" == 0 
jf @BARB_8399 
0512: show_permanent_text_box 'BARB_H2'  
if 
04A3:   " + Current_Language + @" == 0 
jf @BARB_7851 
08D4: " + _2417 + @" = create_panel_with_title 'HAIRCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @BARB_8092 

:BARB_7851
if 
04A3:   " + Current_Language + @" == 1 
jf @BARB_7913 
08D4: " + _2417 + @" = create_panel_with_title 'HAIRCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @BARB_8092 

:BARB_7913
if 
04A3:   " + Current_Language + @" == 2 
jf @BARB_7975 
08D4: " + _2417 + @" = create_panel_with_title 'HAIRCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @BARB_8092 

:BARB_7975
if 
04A3:   " + Current_Language + @" == 3 
jf @BARB_8037 
08D4: " + _2417 + @" = create_panel_with_title 'HAIRCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  
jump @BARB_8092 

:BARB_8037
if 
04A3:   " + Current_Language + @" == 4 
jf @BARB_8092 
08D4: " + _2417 + @" = create_panel_with_title 'HAIRCHO' position 29.0 95.0 width 93.0 columns 2 interactive 0 background 1 alignment 1  

:BARB_8092
08D6: set_panel " + _2417 + @" column 0 alignment 1 
08DB: set_panel " + _2417 + @" column 0 header 'HAIRSTY' data " + _9742 + @" 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08D6: set_panel " + _2417 + @" column 1 alignment 2 
08DB: set_panel " + _2417 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
08EE: set_panel " + _2417 + @" column 1 row 0 text_1number GXT 'DOLLAR' number " + _9732 + @"  
09DB: set_panel " + _2417 + @" column 0 width 140 
09DB: set_panel " + _2417 + @" column 1 width 46 
" + _2418 + @" = 1 

:BARB_8399
return 

:BARB_8401
" + _9800 + @" = 0 
" + _9801 + @" = 0 

:BARB_8415
if 
001C:   " + _9729 + @" > " + _9800 + @" 
jf @BARB_8607 
0760: store_shopping_data_index " + _9800 + @" textureCRC_to " + Selected_Menu_Item + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 0 store_to " + ShoppingItem_ModelCRC + @" 
0783: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" flag 1 store_to " + ShoppingItem_BodyPart + @" 
0084: " + tmp_2438 + @"(" + _9801 + @",12i) = " + Selected_Menu_Item + @" 
078C: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" nametag_to " + _9742 + @" 
0761: get_shopping_item_with_textureCRC " + Selected_Menu_Item + @" price_to " + _9732 + @" 
0084: " + tmp_2426 + @"(" + _9801 + @",12i) = " + _9732 + @" 
05A9: " + tmp_2450 + @"(" + _9801 + @",12s) = " + _9742 + @" 
0084: " + tmp_2474 + @"(" + _9801 + @",12i) = " + ShoppingItem_ModelCRC + @" 
0084: " + tmp_2486 + @"(" + _9801 + @",12i) = " + ShoppingItem_BodyPart + @" 
if 
003A:   " + _2542 + @" == " + Selected_Menu_Item + @" 
jf @BARB_8575 
" + tmp_2498 + @"(" + _9801 + @",12i) = 0 
jump @BARB_8586 

:BARB_8575
" + tmp_2498 + @"(" + _9801 + @",12i) = 1 

:BARB_8586
" + _9801 + @" += 1 
" + _9800 + @" += 1 
jump @BARB_8415 

:BARB_8607
0084: " + _2515 + @" = " + _9801 + @" 

:BARB_8615
if 
  12 > " + _2515 + @" 
jf @BARB_8687 
" + tmp_2438 + @"(" + _2515 + @",12i) = -1 
" + tmp_2426 + @"(" + _2515 + @",12i) = 0 
05A9: " + tmp_2450 + @"(" + _2515 + @",12s) = 'DUMMY' 
" + _2515 + @" += 1 
jump @BARB_8615 

:BARB_8687
return 

:BARB_8689
if 
  " + _2420 + @" == 0 
jf @BARB_9362 
0512: show_permanent_text_box 'BARB_H1'  
if 
04A3:   " + Current_Language + @" == 0 
jf @BARB_8780 
08D4: " + _2419 + @" = create_panel_with_title 'HAIRCHO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @BARB_9021 

:BARB_8780
if 
04A3:   " + Current_Language + @" == 1 
jf @BARB_8842 
08D4: " + _2419 + @" = create_panel_with_title 'HAIRCHO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @BARB_9021 

:BARB_8842
if 
04A3:   " + Current_Language + @" == 2 
jf @BARB_8904 
08D4: " + _2419 + @" = create_panel_with_title 'HAIRCHO' position 29.0 165.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @BARB_9021 

:BARB_8904
if 
04A3:   " + Current_Language + @" == 3 
jf @BARB_8966 
08D4: " + _2419 + @" = create_panel_with_title 'HAIRCHO' position 29.0 145.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  
jump @BARB_9021 

:BARB_8966
if 
04A3:   " + Current_Language + @" == 4 
jf @BARB_9021 
08D4: " + _2419 + @" = create_panel_with_title 'HAIRCHO' position 29.0 165.0 width 93.0 columns 2 interactive 1 background 1 alignment 1  

:BARB_9021
08D6: set_panel " + _2419 + @" column 0 alignment 1 
08DB: set_panel " + _2419 + @" column 0 header 'HAIRSTY' data s" + tmp_2450 + @"[0] s" + tmp_2450 + @"[1] s" + tmp_2450 + @"[2] s" + tmp_2450 + @"[3] s" + tmp_2450 + @"[4] s" + tmp_2450 + @"[5] s" + tmp_2450 + @"[6] s" + tmp_2450 + @"[7] s" + tmp_2450 + @"[8] s" + tmp_2450 + @"[9] s" + tmp_2450 + @"[10] s" + tmp_2450 + @"[11]  
08D6: set_panel " + _2419 + @" column 1 alignment 2 
08DB: set_panel " + _2419 + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
" + _2515 + @" = 0 

:BARB_9222
if 
001C:   " + _9801 + @" > " + _2515 + @" 
jf @BARB_9281 
08EE: set_panel " + _2419 + @" column 1 row " + _2515 + @" text_1number GXT 'DOLLAR' number " + tmp_2426 + @"(" + _2515 + @",12i)  
" + _2515 + @" += 1 
jump @BARB_9222 

:BARB_9281
" + _2515 + @" = 0 

:BARB_9288
if 
001C:   " + _9801 + @" > " + _2515 + @" 
jf @BARB_9336 
08D9: set_panel " + _2419 + @" row " + _2515 + @" enable " + tmp_2498 + @"(" + _2515 + @",12i) 
" + _2515 + @" += 1 
jump @BARB_9288 

:BARB_9336
09DB: set_panel " + _2419 + @" column 0 width 140 
09DB: set_panel " + _2419 + @" column 1 width 46 
" + _2420 + @" = 1 

:BARB_9362
return 
end_thread" );
            }

        }

    }

}