using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class SHRANGE : MissionCustom {

            Int tmp_8089 = global( _8089.startIndex ),
                tmp_8086 = global( _8086.startIndex ),
                tmp_8028 = global( _8028.startIndex ),
                tmp_8025 = global( _8025.startIndex ),
                tmp_8032 = global( _8032.startIndex ),
                tmp_8121 = global( _8121.startIndex ),
                tmp_8071 = global( _8071.startIndex ),
                tmp_8054 = global( _8054.startIndex ),
                tmp_8097 = global( _8097.startIndex ),
                tmp_8057 = global( _8057.startIndex ),
                tmp_8094 = global( _8094.startIndex ),
                tmp_8038 = global( _8038.startIndex ),
                tmp_8046 = global( _8046.startIndex ),
                tmp_8066 = global( _8066.startIndex ),
                tmp_8077 = global( _8077.startIndex ),
                tmp_8035 = global( _8035.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"set_wb_check_to 0 
" + OnMission + @" = 1 
" + ONMISSION_Shooting + @" = 1 
" + _8017 + @" = 286.1649 
" + _8021 + @" = -30.9591 
" + _8018 + @" = 301.8877 
" + _8022 + @" = -77.2586 
" + _8019 + @" = 306.4883 
" + _8023 + @" = -141.9047 
" + _8020 + @" = 307.0919 
" + _8024 + @" = -159.2197 
" + tmp_8057 + @"[0] = -319 
" + tmp_8057 + @"[1] = -320 
" + tmp_8057 + @"[2] = -321 
" + tmp_8057 + @"[3] = -322 
" + tmp_8057 + @"[4] = -323 
" + tmp_8057 + @"[5] = -324 
" + tmp_8057 + @"[6] = -325 
" + tmp_8057 + @"[7] = -326 
" + tmp_8038 + @"[1] = 0.275 
" + tmp_8046 + @"[1] = -3.502 
" + tmp_8038 + @"[2] = -0.214 
" + tmp_8046 + @"[2] = -3.479 
" + tmp_8038 + @"[3] = 0.245 
" + tmp_8046 + @"[3] = -2.791 
" + tmp_8038 + @"[4] = -0.168 
" + tmp_8046 + @"[4] = -2.806 
" + tmp_8038 + @"[5] = 0.079 
" + tmp_8046 + @"[5] = -2.123 
" + tmp_8038 + @"[6] = -0.589 
" + tmp_8046 + @"[6] = -2.317 
" + tmp_8038 + @"[7] = -0.357 
" + tmp_8046 + @"[7] = -1.855 
35@ = 290.6264 
39@ = -24.5548 
43@ = 1000.523 
47@ = 3.0583 
51@ = 6.1726 
55@ = -13.6242 
59@ = 0.0 
36@ = 303.0788 
40@ = -61.2269 
44@ = 1000.523 
48@ = 2.9464 
52@ = 6.0799 
56@ = -13.6242 
60@ = 270.0 
37@ = 300.1018 
41@ = -137.0399 
45@ = 1003.055 
49@ = 3.1341 
53@ = 6.1264 
57@ = -13.6242 
61@ = 90.0 
38@ = 299.4518 
42@ = -166.3517 
46@ = 998.6105 
50@ = 3.0055 
54@ = 4.6018 
58@ = -13.6242 
62@ = 90.0 
" + Shooting_Index + @" = 0 

:SHRANGE_600
if 
  3 > " + Shooting_Index + @" 
else_jump @SHRANGE_723 
" + tmp_8089 + @"(" + Shooting_Index + @",3i) = 1 
" + tmp_8086 + @"(" + Shooting_Index + @",3i) = 0 
" + tmp_8028 + @"(" + Shooting_Index + @",4i) = 0 
" + tmp_8025 + @"(" + Shooting_Index + @",3i) = 0 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 0 
" + tmp_8054 + @"(" + Shooting_Index + @",3f) = 90.0 
" + tmp_8121 + @"(" + Shooting_Index + @",3i) = 0 
" + tmp_8071 + @"(" + Shooting_Index + @",3i) = 0 
" + Shooting_Index + @" += 1 
jump @SHRANGE_600 

:SHRANGE_723
" + _8070 + @" = 0 
" + _8075 + @" = 0 
" + _8076 + @" = 0 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  " + STAT_Unlocked_Cities_Number + @" == 0 
else_jump @SHRANGE_777 
" + _5273 + @" = 2 

:SHRANGE_777
if 
  " + STAT_Unlocked_Cities_Number + @" == 1 
else_jump @SHRANGE_827 
if 
  " + _5273 + @" == 2 
else_jump @SHRANGE_820 
" + _5274 + @" = 1 

:SHRANGE_820
" + _5273 + @" = 3 

:SHRANGE_827
if 
  " + STAT_Unlocked_Cities_Number + @" > 1 
else_jump @SHRANGE_877 
if 
  4 > " + _5273 + @" 
else_jump @SHRANGE_870 
" + _5274 + @" = 1 

:SHRANGE_870
" + _5273 + @" = 4 

:SHRANGE_877
07E5: copy_decision_maker 65538 to " + _8069 + @" 
0708: reset_decision_maker " + _8069 + @" event 15 
0709: set_decision_maker " + _8069 + @" on_event 15 taskID 300 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
03CF: load_wav 1801 as 4 
Model.Load(#TARGET_HEAD)
Model.Load(#TARGET_LARM)
Model.Load(#TARGET_RARM)
Model.Load(#TARGET_LLEG)
Model.Load(#TARGET_RLEG)
Model.Load(#TARGET_RTORSO)
Model.Load(#TARGET_LTORSO)
Model.Load(#TARGET_FRAME)
Model.Load(#COLT45)
Model.Load(#MICRO_UZI)
Model.Load(#CHROMEGUN)
Model.Load(#AK47)

:SHRANGE_995
if or
   not Model.Available(#COLT45)
   not Model.Available(#MICRO_UZI)
   not Model.Available(#CHROMEGUN)
   not Model.Available(#AK47)
else_jump @SHRANGE_1037 
wait 0 
jump @SHRANGE_995 

:SHRANGE_1037
if or
   not Model.Available(#TARGET_HEAD)
   not Model.Available(#TARGET_LARM)
   not Model.Available(#TARGET_RARM)
   not Model.Available(#TARGET_LLEG)
   not Model.Available(#TARGET_RLEG)
else_jump @SHRANGE_1084 
wait 0 
jump @SHRANGE_1037 

:SHRANGE_1084
if or
   not Model.Available(#TARGET_RTORSO)
   not Model.Available(#TARGET_LTORSO)
   not Model.Available(#TARGET_FRAME)
83D0:   not wav 4 loaded 
else_jump @SHRANGE_1125 
wait 0 
jump @SHRANGE_1084 

:SHRANGE_1125
if 
  " + ONMISSION_Shooting + @" == 47 
else_jump @SHRANGE_1201 
" + tmp_8097 + @"[0] = Object.Init(" + tmp_8057 + @"(" + Shooting_Index + @",8i), 293.757, 1.0, 1000.516)
0376: " + tmp_8094 + @"[0] = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + _8065 + @" = Object.Create(#POOLCUE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:SHRANGE_1201
077E: get_active_interior_to " + _8074 + @" 

:SHRANGE_1206
if 
0736:   is_keyboard_key_just_pressed 87 
else_jump @SHRANGE_1298 
" + Shooting_Index + @" = 9 

:SHRANGE_1228
if 
  16 > " + Shooting_Index + @" 
else_jump @SHRANGE_1291 
if 
03CA:   object " + tmp_8097 + @"(" + Shooting_Index + @",24i) exists 
else_jump @SHRANGE_1277 
0723: break_object " + tmp_8097 + @"(" + Shooting_Index + @",24i) intensity 1 

:SHRANGE_1277
" + Shooting_Index + @" += 1 
jump @SHRANGE_1228 

:SHRANGE_1291
" + _8126 + @" = 20 

:SHRANGE_1298
wait 0 
077E: get_active_interior_to " + Shooting_Index + @" 
if 
803A:   not  " + Shooting_Index + @" == " + _8074 + @" 
else_jump @SHRANGE_1333 
jump @SHRANGE_17001 

:SHRANGE_1333
if 
   Player.Defined(" + PlayerChar + @")
else_jump @SHRANGE_1370 
gosub @SHRANGE_13462 
gosub @SHRANGE_11073 
gosub @SHRANGE_1379 

:SHRANGE_1370
jump @SHRANGE_1206 
end_thread 

:SHRANGE_1379
if 
00E1:   player 0 pressed_key 15 
else_jump @SHRANGE_1444 
if 
   not " + _8070 + @" == 0 
else_jump @SHRANGE_1444 
00BE: text_clear_all 
34@ = 1 
" + _8070 + @" = 20 
" + _8075 + @" = 1 
" + _8076 + @" = 0 

:SHRANGE_1444
0871: init_jump_table " + _8070 + @" total_jumps 7 default_jump 0 @SHRANGE_11071 jumps 0 @SHRANGE_1507 1 @SHRANGE_1813 2 @SHRANGE_5136 3 @SHRANGE_5349 4 @SHRANGE_6528 5 @SHRANGE_8379 20 @SHRANGE_10196 

:SHRANGE_1507
if 
  " + Shooting_Index_2 + @" == 0 
else_jump @SHRANGE_1580 
if 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 286.1649 -30.9591 1000.516 radius 2.0 2.0 2.0 
else_jump @SHRANGE_1580 
" + _8070 + @" = 1 

:SHRANGE_1580
if 
  " + Shooting_Index_2 + @" == 1 
else_jump @SHRANGE_1653 
if 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 301.8877 -77.2586 1000.523 radius 2.0 2.0 2.0 
else_jump @SHRANGE_1653 
" + _8070 + @" = 1 

:SHRANGE_1653
if 
  " + Shooting_Index_2 + @" == 2 
else_jump @SHRANGE_1726 
if 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 306.4883 -141.9047 1003.055 radius 2.0 2.0 2.0 
else_jump @SHRANGE_1726 
" + _8070 + @" = 1 

:SHRANGE_1726
if 
  " + Shooting_Index_2 + @" == 3 
else_jump @SHRANGE_1799 
if 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere 307.0919 -159.2197 998.601 radius 2.0 2.0 2.0 
else_jump @SHRANGE_1799 
" + _8070 + @" = 1 

:SHRANGE_1799
64@ = 0 
jump @SHRANGE_11071 

:SHRANGE_1813
if 
  " + _5287 + @" > 0 
else_jump @SHRANGE_1881 
if and
  7 > " + _8075 + @" 
  " + _8075 + @" > 0 
else_jump @SHRANGE_1881 
" + _8075 + @" = 7 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
00BE: text_clear_all 

:SHRANGE_1881
if 
  " + _8075 + @" == 0 
else_jump @SHRANGE_2033 
34@ = 0 
0992: set_player " + PlayerChar + @" weapons_scrollable 0 
04B8: get_weapon_data_from_actor " + PlayerActor + @" slot 3 weapon " + _8135 + @" ammo " + _8131 + @" model " + _8139 + @" 
04B8: get_weapon_data_from_actor " + PlayerActor + @" slot 4 weapon " + _8136 + @" ammo " + _8132 + @" model " + _8140 + @" 
04B8: get_weapon_data_from_actor " + PlayerActor + @" slot 5 weapon " + _8137 + @" ammo " + _8133 + @" model " + _8141 + @" 
04B8: get_weapon_data_from_actor " + PlayerActor + @" slot 6 weapon " + _8138 + @" ammo " + _8134 + @" model " + _8142 + @" 
" + _8124 + @" = 0 
Player.CanMove(" + PlayerChar + @") = False
0169: set_fade_color_RGB 0 0 0 
08F8: display_stat_update_box 0 
fade 0 1000 
" + _8075 + @" = 1 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1500 

:SHRANGE_2033
if 
  " + _8075 + @" == 1 
else_jump @SHRANGE_2267 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_2267 
02A3: enable_widescreen 1 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'ANR_1' time 4000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_2' time 4000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_3' time 4000 flag 1  
" + _8083 + @" = -0.83 
" + _8084 + @" = 0.47 
" + tempvar_Float_3 + @" = 1.7 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
" + _8083 + @" = 0.17 
" + _8084 + @" = 0.63 
" + tempvar_Float_3 + @" = 1.7 
gosub @SHRANGE_16833 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
fade 1 1000 
" + _8075 + @" = 2 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 4000 

:SHRANGE_2267
if 
  " + _8075 + @" == 2 
else_jump @SHRANGE_2461 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_2461 
" + tmp_8086 + @"[1] = 3 
" + tmp_8089 + @"[1] = 0 
" + _8083 + @" = -0.63 
" + _8084 + @" = -3.47 
" + tempvar_Float_3 + @" = 0.2 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
" + _8083 + @" = 0.4 
" + _8084 + @" = -2.5 
" + tempvar_Float_3 + @" = 0.5 
gosub @SHRANGE_16833 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
fade 1 1000 
" + _8075 + @" = 3 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 2000 

:SHRANGE_2461
if 
  " + _8075 + @" == 3 
else_jump @SHRANGE_2590 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_2590 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", Pistol, 99999)
" + _8083 + @" = 0.0 
005F: " + _8083 + @" += 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = -1.0 
gosub @SHRANGE_16833 
05D3: AS_actor " + PlayerActor + @" goto_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" mode 4 time -2 ms 
" + _8075 + @" = 4 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 3000 

:SHRANGE_2590
if 
  " + _8075 + @" == 4 
else_jump @SHRANGE_3034 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_3034 
" + tmp_8086 + @"[1] = 4 
0088: " + _8081 + @" = 59@(" + Shooting_Index_2 + @",4f) 
" + _8081 + @" += 90.0 
Actor.Angle(" + PlayerActor + @") = " + _8081 + @"
0088: " + _8083 + @" = 47@(" + Shooting_Index_2 + @",4f) 
" + _8083 + @" -= 0.8201 
" + _8084 + @" = -0.4944 
" + tempvar_Float_3 + @" = 2.1312 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0088: " + _8083 + @" = 47@(" + Shooting_Index_2 + @",4f) 
" + _8083 + @" -= 0.1125 
" + _8084 + @" = -0.0237 
" + tempvar_Float_3 + @" = 1.6042 
gosub @SHRANGE_16833 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
0088: " + _8083 + @" = 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = -2.0 
" + tempvar_Float_3 + @" = 0.0 
gosub @SHRANGE_16833 
08C7: put_actor " + PlayerActor + @" at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" dont_warp_gang 
0088: " + _8083 + @" = 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = 0.0 
" + tempvar_Float_3 + @" = 0.0 
gosub @SHRANGE_16833 
Actor.Angle(" + PlayerActor + @") = 59@(" + Shooting_Index_2 + @",4f)
05D3: AS_actor " + PlayerActor + @" goto_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" mode 4 time -2 ms 
if 
  " + _8124 + @" == 0 
else_jump @SHRANGE_2955 
" + tmp_8028 + @"[0] = 1 
" + tmp_8028 + @"[2] = 1 

:SHRANGE_2955
" + tmp_8086 + @"[0] = 1 
" + tmp_8086 + @"[2] = 1 
" + tmp_8032 + @"[0] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 0 
" + tmp_8025 + @"[0] = 1 
" + tmp_8025 + @"[1] = 1 
" + tmp_8025 + @"[2] = 1 
" + _8075 + @" = 5 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 3000 

:SHRANGE_3034
if 
  " + _8075 + @" == 5 
else_jump @SHRANGE_3225 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_3225 
00BE: text_clear_all 
00BA: show_text_styled GXT 'ANR_6' time 2000 style 1  
" + _8083 + @" = 2.1566 
" + _8084 + @" = 2.4369 
" + tempvar_Float_3 + @" = 1.4565 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
" + _8083 + @" = 1.9771 
" + _8084 + @" = 3.4129 
" + tempvar_Float_3 + @" = 1.3326 
gosub @SHRANGE_16833 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
" + _8075 + @" = 6 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 3000 

:SHRANGE_3225
if 
  " + _8075 + @" == 6 
else_jump @SHRANGE_3464 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_3464 
if 
   not Actor.Dead(" + tmp_8094 + @"[0])
else_jump @SHRANGE_3285 
Actor.WeaponAccuracy(" + tmp_8094 + @"[0]) = 100

:SHRANGE_3285
03D6: remove_styled_text 'ANR_6'  
00BB: show_text_lowpriority GXT 'ANR_7' time 4000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_10' time 4000 flag 1  
" + _8083 + @" = 0.7525 
" + _8084 + @" = -0.3628 
" + tempvar_Float_3 + @" = 1.6174 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
" + _8083 + @" = 0.1734 
" + _8084 + @" = 0.446 
" + tempvar_Float_3 + @" = 1.5146 
gosub @SHRANGE_16833 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
" + _8075 + @" = 7 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 8000 

:SHRANGE_3464
if 
  " + _8075 + @" == 7 
else_jump @SHRANGE_3595 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_3595 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @SHRANGE_3517 

:SHRANGE_3517
if 
  " + _5287 + @" == 0 
else_jump @SHRANGE_3572 
" + _5287 + @" = 1 
fade 0 1000 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
jump @SHRANGE_3588 

:SHRANGE_3572
00BA: show_text_styled GXT 'ANR_6' time 2000 style 1  

:SHRANGE_3588
" + _8075 + @" = 8 

:SHRANGE_3595
if 
  " + _8075 + @" == 8 
else_jump @SHRANGE_3903 
if and
   not fading 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_3903 
0088: " + _8083 + @" = 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = 0.0 
" + tempvar_Float_3 + @" = 0.0 
gosub @SHRANGE_16833 
if 
83CA:   not object " + _8065 + @" exists 
else_jump @SHRANGE_3725 
" + _8065 + @" = Object.Create(#POOLCUE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0750: set_object " + _8065 + @" visibility 0 
Actor.Angle(" + PlayerActor + @") = 59@(" + Shooting_Index_2 + @",4f)

:SHRANGE_3725
0792: disembark_instantly_actor " + PlayerActor + @" 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 22 
082A: set_player " + PlayerChar + @" able_to_use_crouch_button 0 
if 
  " + _8124 + @" == 0 
else_jump @SHRANGE_3799 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", Pistol, 99999)

:SHRANGE_3799
" + tmp_8086 + @"[1] = 4 
" + tmp_8089 + @"[1] = 0 
" + _8075 + @" = 9 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 800 
if 
  " + _8124 + @" == 0 
else_jump @SHRANGE_3868 
" + tmp_8028 + @"[0] = 1 
" + tmp_8028 + @"[2] = 1 

:SHRANGE_3868
" + tmp_8086 + @"[0] = 1 
" + tmp_8086 + @"[2] = 1 
" + tmp_8032 + @"[0] = 4 
" + tmp_8032 + @"[1] = 4 
" + tmp_8032 + @"[2] = 4 

:SHRANGE_3903
if 
  " + _8075 + @" == 9 
else_jump @SHRANGE_4082 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_4082 
fade 1 1000 
0465: remove_actor " + PlayerActor + @" from_turret_mode 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 22 
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
" + tmp_8032 + @"[0] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 0 
" + tmp_8025 + @"[0] = 1 
" + tmp_8025 + @"[1] = 1 
" + tmp_8025 + @"[2] = 1 
if 
  " + _5274 + @" == 1 
else_jump @SHRANGE_4075 
03E5: show_text_box 'ANR_56'  
" + _5274 + @" = 0 

:SHRANGE_4075
" + _8075 + @" = 10 

:SHRANGE_4082
if 
  " + _8075 + @" == 10 
else_jump @SHRANGE_4165 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_4165 
00BA: show_text_styled GXT 'RACE2' time 1000 style 4  
" + _8075 + @" = 11 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
Player.CanMove(" + PlayerChar + @") = True

:SHRANGE_4165
if 
  " + _8075 + @" == 11 
else_jump @SHRANGE_4241 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_4241 
00BA: show_text_styled GXT 'RACE3' time 1000 style 4  
" + _8075 + @" = 12 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 

:SHRANGE_4241
if 
  " + _8075 + @" == 12 
else_jump @SHRANGE_4317 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_4317 
00BA: show_text_styled GXT 'RACE4' time 1000 style 4  
" + _8075 + @" = 13 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 

:SHRANGE_4317
if 
  " + _8075 + @" == 13 
else_jump @SHRANGE_4400 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_4400 
00BA: show_text_styled GXT 'RACE5' time 1000 style 4  
" + _8075 + @" = 14 
if 
   not Actor.Dead(" + tmp_8094 + @"[0])
else_jump @SHRANGE_4400 
Actor.WeaponAccuracy(" + tmp_8094 + @"[0]) = 80

:SHRANGE_4400
if 
  " + _8075 + @" == 14 
else_jump @SHRANGE_4432 
" + _8070 + @" = 2 
" + _8075 + @" = 0 

:SHRANGE_4432
if 
  " + _8075 + @" == 16 
else_jump @SHRANGE_4651 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_4651 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @SHRANGE_4621 
if 
83CA:   not object " + _8065 + @" exists 
else_jump @SHRANGE_4621 
0088: " + _8083 + @" = 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = 0.0 
" + tempvar_Float_3 + @" = 0.0 
gosub @SHRANGE_16833 
" + _8065 + @" = Object.Create(#POOLCUE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0750: set_object " + _8065 + @" visibility 0 
Actor.Angle(" + PlayerActor + @") = 59@(" + Shooting_Index_2 + @",4f)
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 22 
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
082A: set_player " + PlayerChar + @" able_to_use_crouch_button 0 

:SHRANGE_4621
fade 0 1000 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 2500 
" + _8075 + @" = 17 

:SHRANGE_4651
if 
  " + _8075 + @" == 17 
else_jump @SHRANGE_5036 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_5036 
if 
  " + _8124 + @" == 3 
else_jump @SHRANGE_4755 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", MicroUzi, 99999)
0465: remove_actor " + PlayerActor + @" from_turret_mode 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 28 

:SHRANGE_4755
if 
  " + _8124 + @" == 6 
else_jump @SHRANGE_4822 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", Shotgun, 99999)
0465: remove_actor " + PlayerActor + @" from_turret_mode 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 25 

:SHRANGE_4822
if 
  " + _8124 + @" == 9 
else_jump @SHRANGE_4889 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", AK47, 99999)
0465: remove_actor " + PlayerActor + @" from_turret_mode 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 30 

:SHRANGE_4889
fade 1 1000 
00BE: text_clear_all 
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
if 
  " + _8124 + @" == 3 
else_jump @SHRANGE_4945 
00BA: show_text_styled GXT 'ANR_47' time 3000 style 1  

:SHRANGE_4945
if 
  " + _8124 + @" == 6 
else_jump @SHRANGE_4979 
00BA: show_text_styled GXT 'ANR_23' time 3000 style 1  

:SHRANGE_4979
if 
  " + _8124 + @" == 9 
else_jump @SHRANGE_5013 
00BA: show_text_styled GXT 'ANR_50' time 3000 style 1  

:SHRANGE_5013
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 4000 
" + _8075 + @" = 18 

:SHRANGE_5036
if 
  " + _8075 + @" == 18 
else_jump @SHRANGE_5129 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_5129 
" + tmp_8032 + @"[0] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 0 
64@ = 0 
" + tmp_8025 + @"[0] = 1 
" + tmp_8025 + @"[1] = 1 
" + tmp_8025 + @"[2] = 1 
" + _8075 + @" = 10 

:SHRANGE_5129
jump @SHRANGE_11071 

:SHRANGE_5136
if 
  " + _8075 + @" == 0 
else_jump @SHRANGE_5207 
if 
   not Actor.Dead(" + tmp_8094 + @"[0])
else_jump @SHRANGE_5177 
Actor.WeaponAccuracy(" + tmp_8094 + @"[0]) = 87

:SHRANGE_5177
if 
   not Actor.Dead(" + tmp_8094 + @"[2])
else_jump @SHRANGE_5200 
Actor.WeaponAccuracy(" + tmp_8094 + @"[2]) = 87

:SHRANGE_5200
" + _8075 + @" = 1 

:SHRANGE_5207
if 
  " + _8075 + @" == 1 
else_jump @SHRANGE_5342 
if and
  " + tmp_8032 + @"[0] == 3 
  " + tmp_8025 + @"[0] == 3 
else_jump @SHRANGE_5264 
" + _8070 + @" = 20 
" + _8075 + @" = 0 

:SHRANGE_5264
if and
  " + tmp_8032 + @"[2] == 3 
  " + tmp_8025 + @"[2] == 3 
else_jump @SHRANGE_5303 
" + _8070 + @" = 20 
" + _8075 + @" = 0 

:SHRANGE_5303
if and
  " + tmp_8032 + @"[1] == 3 
  " + tmp_8025 + @"[1] == 3 
else_jump @SHRANGE_5342 
" + _8070 + @" = 3 
" + _8075 + @" = 0 

:SHRANGE_5342
jump @SHRANGE_11071 

:SHRANGE_5349
if 
  " + _8075 + @" == 0 
else_jump @SHRANGE_5930 
if or
  " + _8124 + @" == 0 
  " + _8124 + @" == 3 
  " + _8124 + @" == 6 
  " + _8124 + @" == 9 
else_jump @SHRANGE_5422 
00BA: show_text_styled GXT 'ANR_41' time 2000 style 1  

:SHRANGE_5422
if or
  " + _8124 + @" == 1 
  " + _8124 + @" == 4 
  " + _8124 + @" == 7 
  " + _8124 + @" == 10 
else_jump @SHRANGE_5477 
00BA: show_text_styled GXT 'ANR_42' time 2000 style 1  

:SHRANGE_5477
if or
  " + _8124 + @" == 2 
  " + _8124 + @" == 5 
  " + _8124 + @" == 8 
else_jump @SHRANGE_5546 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 5500 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 5 
" + tmp_8032 + @"[2] = 5 

:SHRANGE_5546
if 
  " + _8124 + @" == 11 
else_jump @SHRANGE_5617 
00BA: show_text_styled GXT 'ANR_45' time 3000 style 1  
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 5500 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 5 
" + tmp_8032 + @"[2] = 5 

:SHRANGE_5617
if 
003A:   " + _8124 + @" == " + _1861 + @" 
else_jump @SHRANGE_5923 
if or
  " + _8124 + @" == 0 
  " + _8124 + @" == 1 
else_jump @SHRANGE_5670 
0624: add 50.0 to_float_stat 69 

:SHRANGE_5670
if or
  " + _8124 + @" == 3 
  " + _8124 + @" == 4 
else_jump @SHRANGE_5704 
0624: add 50.0 to_float_stat 75 

:SHRANGE_5704
if or
  " + _8124 + @" == 6 
  " + _8124 + @" == 7 
else_jump @SHRANGE_5738 
0624: add 50.0 to_float_stat 72 

:SHRANGE_5738
if or
  " + _8124 + @" == 9 
  " + _8124 + @" == 10 
else_jump @SHRANGE_5772 
0624: add 50.0 to_float_stat 77 

:SHRANGE_5772
if 
  " + _8124 + @" == 2 
else_jump @SHRANGE_5799 
0624: add 100.0 to_float_stat 69 

:SHRANGE_5799
if 
  " + _8124 + @" == 5 
else_jump @SHRANGE_5826 
0624: add 100.0 to_float_stat 75 

:SHRANGE_5826
if 
  " + _8124 + @" == 8 
else_jump @SHRANGE_5853 
0624: add 100.0 to_float_stat 72 

:SHRANGE_5853
if 
  " + _8124 + @" == 11 
else_jump @SHRANGE_5908 
0624: add 100.0 to_float_stat 77 
062A: change_float_stat 69 to 1000.0 
Player.Money(" + PlayerChar + @") += 10000
0394: play_music 2 
" + _5272 + @" = 1 

:SHRANGE_5908
" + _1861 + @" += 1 
0629: change_integer_stat 174 to " + _1861 + @" 

:SHRANGE_5923
" + _8075 + @" = 1 

:SHRANGE_5930
if 
  " + _8075 + @" == 1 
else_jump @SHRANGE_6521 
if 
  " + _8124 + @" == 0 
else_jump @SHRANGE_5980 
" + _8070 + @" = 4 
" + _8075 + @" = 0 

:SHRANGE_5980
if or
  " + _8124 + @" == 3 
  " + _8124 + @" == 6 
  " + _8124 + @" == 9 
else_jump @SHRANGE_6026 
" + _8070 + @" = 4 
" + _8075 + @" = 10 

:SHRANGE_6026
if 
  " + _8124 + @" == 1 
else_jump @SHRANGE_6058 
" + _8070 + @" = 5 
" + _8075 + @" = 0 

:SHRANGE_6058
if or
  " + _8124 + @" == 4 
  " + _8124 + @" == 7 
  " + _8124 + @" == 10 
else_jump @SHRANGE_6104 
" + _8070 + @" = 5 
" + _8075 + @" = 10 

:SHRANGE_6104
if or
  " + _8124 + @" == 2 
  " + _8124 + @" == 5 
  " + _8124 + @" == 8 
else_jump @SHRANGE_6150 
" + _8070 + @" = 1 
" + _8075 + @" = 16 

:SHRANGE_6150
if 
  " + _8124 + @" == 2 
else_jump @SHRANGE_6212 
" + tmp_8028 + @"[0] = 2 
" + tmp_8028 + @"[2] = 2 
" + tmp_8086 + @"[0] = 1 
" + tmp_8086 + @"[2] = 1 
00BA: show_text_styled GXT 'ANR_29' time 2000 style 1  

:SHRANGE_6212
if 
  " + _8124 + @" == 5 
else_jump @SHRANGE_6274 
" + tmp_8028 + @"[0] = 3 
" + tmp_8028 + @"[2] = 3 
" + tmp_8086 + @"[0] = 1 
" + tmp_8086 + @"[2] = 1 
00BA: show_text_styled GXT 'ANR_53' time 2000 style 1  

:SHRANGE_6274
if 
  " + _8124 + @" == 8 
else_jump @SHRANGE_6336 
" + tmp_8028 + @"[0] = 4 
" + tmp_8028 + @"[2] = 4 
" + tmp_8086 + @"[0] = 1 
" + tmp_8086 + @"[2] = 1 
00BA: show_text_styled GXT 'ANR_31' time 2000 style 1  

:SHRANGE_6336
if 
  " + _8124 + @" == 5 
else_jump @SHRANGE_6409 
if 
  2 >= " + _5273 + @" 
else_jump @SHRANGE_6393 
" + _8070 + @" = 20 
" + _8075 + @" = 1 
jump @SHRANGE_6409 

:SHRANGE_6393
00BB: show_text_lowpriority GXT 'ANR_44' time 4000 flag 1  

:SHRANGE_6409
if 
  " + _8124 + @" == 8 
else_jump @SHRANGE_6482 
if 
  3 >= " + _5273 + @" 
else_jump @SHRANGE_6466 
" + _8070 + @" = 20 
" + _8075 + @" = 1 
jump @SHRANGE_6482 

:SHRANGE_6466
00BB: show_text_lowpriority GXT 'ANR_44' time 4000 flag 1  

:SHRANGE_6482
if 
  " + _8124 + @" == 11 
else_jump @SHRANGE_6514 
" + _8070 + @" = 20 
" + _8075 + @" = 1 

:SHRANGE_6514
" + _8124 + @" += 1 

:SHRANGE_6521
jump @SHRANGE_11071 

:SHRANGE_6528
if 
  " + _8075 + @" == 0 
else_jump @SHRANGE_6639 
" + tmp_8071 + @"[0] = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8071 + @"[2] = 0 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 5 
" + tmp_8032 + @"[2] = 5 
" + tmp_8025 + @"[0] = 4 
" + tmp_8025 + @"[1] = 4 
" + tmp_8025 + @"[2] = 4 
" + _8075 + @" = 1 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 6000 
64@ = 0 

:SHRANGE_6639
if 
  " + _8075 + @" == 1 
else_jump @SHRANGE_6732 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_6732 
if 
  3 > " + _5287 + @" 
else_jump @SHRANGE_6709 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:SHRANGE_6709
" + _8075 + @" = 2 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1500 

:SHRANGE_6732
if 
  " + _8075 + @" == 2 
else_jump @SHRANGE_7037 
if 
  " + _5287 + @" > 1 
else_jump @SHRANGE_6841 
00BE: text_clear_all 
if 
03CA:   object " + tmp_8097 + @"[8] exists 
else_jump @SHRANGE_6791 
Object.Destroy(" + tmp_8097 + @"[8])

:SHRANGE_6791
03D6: remove_styled_text 'ANR_18'  
03D6: remove_styled_text 'ANR_19'  
" + _8076 + @" = 0 
" + _8075 + @" = 3 
" + _8076 + @" = 0 
jump @SHRANGE_7037 

:SHRANGE_6841
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_7037 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
03D6: remove_styled_text 'ANR_41'  
00BA: show_text_styled GXT 'ANR_18' time 4000 style 1  
00BB: show_text_lowpriority GXT 'ANR_9' time 4000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_10' time 3000 flag 1  
" + _8083 + @" = -2.0835 
" + _8084 + @" = 6.0428 
" + tempvar_Float_3 + @" = 0.0387 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
" + _8075 + @" = 3 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
" + tmp_8032 + @"[0] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 0 

:SHRANGE_7037
if 
  " + _8075 + @" == 3 
else_jump @SHRANGE_7111 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_7111 
fade 1 1000 
" + _8075 + @" = 4 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 6000 
64@ = 0 

:SHRANGE_7111
if 
  " + _8075 + @" == 4 
else_jump @SHRANGE_7693 
if 
  " + _5287 + @" == 1 
else_jump @SHRANGE_7200 
if 
03CA:   object " + tmp_8097 + @"[8] exists 
else_jump @SHRANGE_7200 
Object.StorePos(" + tmp_8097 + @"[8], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Float_3 + @" -= 2.0 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)

:SHRANGE_7200
if or
001F:   32@ > " + _8076 + @" 
  " + _5287 + @" > 1 
else_jump @SHRANGE_7693 
if 
   not fading 
else_jump @SHRANGE_7473 
if 
  " + _5287 + @" == 1 
else_jump @SHRANGE_7296 
if 
  64@ == 0 
else_jump @SHRANGE_7289 
fade 0 1000 
64@ = 1 

:SHRANGE_7289
jump @SHRANGE_7473 

:SHRANGE_7296
if 
  64@ == 0 
else_jump @SHRANGE_7473 
if 
  " + _8124 + @" == 1 
else_jump @SHRANGE_7348 
00BA: show_text_styled GXT 'ANR_18' time 3000 style 1  

:SHRANGE_7348
if 
  " + _8124 + @" == 4 
else_jump @SHRANGE_7382 
00BA: show_text_styled GXT 'ANR_48' time 3000 style 1  

:SHRANGE_7382
if 
  " + _8124 + @" == 7 
else_jump @SHRANGE_7416 
00BA: show_text_styled GXT 'ANR_24' time 3000 style 1  

:SHRANGE_7416
if 
  " + _8124 + @" == 10 
else_jump @SHRANGE_7450 
00BA: show_text_styled GXT 'ANR_51' time 3000 style 1  

:SHRANGE_7450
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
64@ = 1 

:SHRANGE_7473
if 
   not fading 
else_jump @SHRANGE_7693 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_7693 
if 
  2 > " + _5287 + @" 
else_jump @SHRANGE_7605 
if 
  64@ == 1 
else_jump @SHRANGE_7605 
64@ = 2 
fade 1 700 
" + _5287 + @" = 2 
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
0465: remove_actor " + PlayerActor + @" from_turret_mode 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 22 

:SHRANGE_7605
" + tmp_8032 + @"[0] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 0 
" + tmp_8071 + @"[0] = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8071 + @"[2] = 0 
00BA: show_text_styled GXT 'RACE2' time 1000 style 4  
" + _8075 + @" = 5 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
Player.CanMove(" + PlayerChar + @") = True

:SHRANGE_7693
if 
  " + _8075 + @" == 5 
else_jump @SHRANGE_7769 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_7769 
00BA: show_text_styled GXT 'RACE3' time 1000 style 4  
" + _8075 + @" = 6 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 

:SHRANGE_7769
if 
  " + _8075 + @" == 6 
else_jump @SHRANGE_7845 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_7845 
00BA: show_text_styled GXT 'RACE4' time 1000 style 4  
" + _8075 + @" = 7 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 

:SHRANGE_7845
if 
  " + _8075 + @" == 7 
else_jump @SHRANGE_7905 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_7905 
00BA: show_text_styled GXT 'RACE5' time 1000 style 4  
" + _8075 + @" = 8 

:SHRANGE_7905
if 
  " + _8075 + @" == 8 
else_jump @SHRANGE_8040 
if and
  " + tmp_8032 + @"[0] == 3 
  " + tmp_8071 + @"[0] == 3 
else_jump @SHRANGE_7962 
" + _8070 + @" = 20 
" + _8075 + @" = 0 

:SHRANGE_7962
if and
  " + tmp_8032 + @"[2] == 3 
  " + tmp_8071 + @"[2] == 3 
else_jump @SHRANGE_8001 
" + _8070 + @" = 20 
" + _8075 + @" = 0 

:SHRANGE_8001
if and
  " + tmp_8032 + @"[1] == 3 
  " + tmp_8071 + @"[1] == 3 
else_jump @SHRANGE_8040 
" + _8070 + @" = 3 
" + _8075 + @" = 0 

:SHRANGE_8040
if 
  " + _8075 + @" == 10 
else_jump @SHRANGE_8086 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 5 
" + tmp_8032 + @"[2] = 5 
" + _8075 + @" = 11 

:SHRANGE_8086
if 
  " + _8075 + @" == 11 
else_jump @SHRANGE_8263 
if and
  " + tmp_8032 + @"[0] == 99 
  " + tmp_8032 + @"[1] == 99 
  " + tmp_8032 + @"[2] == 99 
else_jump @SHRANGE_8263 
00BE: text_clear_all 
if 
  " + _8124 + @" == 4 
else_jump @SHRANGE_8172 
00BA: show_text_styled GXT 'ANR_48' time 3000 style 1  

:SHRANGE_8172
if 
  " + _8124 + @" == 7 
else_jump @SHRANGE_8206 
00BA: show_text_styled GXT 'ANR_24' time 3000 style 1  

:SHRANGE_8206
if 
  " + _8124 + @" == 10 
else_jump @SHRANGE_8240 
00BA: show_text_styled GXT 'ANR_51' time 3000 style 1  

:SHRANGE_8240
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 4000 
" + _8075 + @" = 12 

:SHRANGE_8263
if 
  " + _8075 + @" == 12 
else_jump @SHRANGE_8372 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_8372 
" + tmp_8025 + @"[0] = 4 
" + tmp_8025 + @"[1] = 4 
" + tmp_8025 + @"[2] = 4 
" + tmp_8071 + @"[0] = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8071 + @"[2] = 0 
" + _8075 + @" = 4 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
Player.CanMove(" + PlayerChar + @") = True

:SHRANGE_8372
jump @SHRANGE_11071 

:SHRANGE_8379
if 
  " + _5287 + @" > 2 
else_jump @SHRANGE_8436 
if and
  4 > " + _8075 + @" 
  " + _8075 + @" > 1 
else_jump @SHRANGE_8436 
" + _8076 + @" = 0 
" + _8075 + @" = 4 

:SHRANGE_8436
if 
  " + _8075 + @" == 0 
else_jump @SHRANGE_8561 
" + _8125 + @" = 0 
" + _8126 + @" = 0 
" + _8127 + @" = 0 
" + tmp_8071 + @"[0] = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8071 + @"[2] = 0 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 5 
" + tmp_8032 + @"[2] = 5 
" + tmp_8025 + @"[0] = 0 
" + tmp_8025 + @"[1] = 5 
" + tmp_8025 + @"[2] = 0 
" + _8075 + @" = 1 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 8000 

:SHRANGE_8561
if 
  " + _8075 + @" == 1 
else_jump @SHRANGE_8654 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_8654 
if 
  3 > " + _5287 + @" 
else_jump @SHRANGE_8631 
0169: set_fade_color_RGB 0 0 0 
fade 0 1000 

:SHRANGE_8631
" + _8075 + @" = 2 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1500 

:SHRANGE_8654
if 
  " + _8075 + @" == 2 
else_jump @SHRANGE_8964 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_8964 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
Player.CanMove(" + PlayerChar + @") = False
03D6: remove_styled_text 'ANR_41'  
00BA: show_text_styled GXT 'ANR_19' time 4000 style 1  
00BB: show_text_lowpriority GXT 'ANR_33' time 3000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_34' time 3000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_35' time 3000 flag 1  
00BB: show_text_lowpriority GXT 'ANR_46' time 3000 flag 1  
" + _8083 + @" = 3.0583 
" + _8084 + @" = 0.6889 
" + tempvar_Float_3 + @" = 1.2953 
gosub @SHRANGE_16833 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
" + _8083 + @" = 2.9703 
" + _8084 + @" = 1.684 
" + tempvar_Float_3 + @" = 1.2513 
gosub @SHRANGE_16833 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
fade 1 1000 
" + _8075 + @" = 3 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 12000 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 5 

:SHRANGE_8964
if 
  " + _8075 + @" == 3 
else_jump @SHRANGE_9070 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_9070 
if 
  3 > " + _5287 + @" 
else_jump @SHRANGE_9026 
fade 0 1000 

:SHRANGE_9026
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1500 
" + _8075 + @" = 4 
" + _8125 + @" = 0 
" + _8126 + @" = 0 
" + _8127 + @" = 0 

:SHRANGE_9070
if 
  " + _8075 + @" == 4 
else_jump @SHRANGE_9376 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_9376 
if 
   not fading 
else_jump @SHRANGE_9376 
03C4: set_status_text " + _8125 + @" type 0 GXT 'ANR_37' 
04F7: status_text " + _8126 + @" type 0 line 2 GXT 'ANR_39' 
04F7: status_text " + _8127 + @" type 0 line 3 GXT 'ANR_38' 
fade 1 1000 
if 
  3 > " + _5287 + @" 
else_jump @SHRANGE_9236 
0465: remove_actor " + PlayerActor + @" from_turret_mode 
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8065 + @" offset_from_object_origin 0.0 0.0 1.0 orientation 0 both_side_angle_limit 90.0 lock_weapon 22 
Camera.Restore_WithJumpCut

:SHRANGE_9236
if 
  " + _5287 + @" == 2 
else_jump @SHRANGE_9268 
" + _5287 + @" = 3 
jump @SHRANGE_9284 

:SHRANGE_9268
00BA: show_text_styled GXT 'ANR_19' time 2000 style 1  

:SHRANGE_9284
" + tmp_8071 + @"[0] = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8071 + @"[2] = 0 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 5 
00BA: show_text_styled GXT 'RACE2' time 1000 style 4  
" + _8075 + @" = 5 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
Player.CanMove(" + PlayerChar + @") = True
02A3: enable_widescreen 0 

:SHRANGE_9376
if 
  " + _8075 + @" == 5 
else_jump @SHRANGE_9452 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_9452 
00BA: show_text_styled GXT 'RACE3' time 1000 style 4  
" + _8075 + @" = 6 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 

:SHRANGE_9452
if 
  " + _8075 + @" == 6 
else_jump @SHRANGE_9528 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_9528 
00BA: show_text_styled GXT 'RACE4' time 1000 style 4  
" + _8075 + @" = 7 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 

:SHRANGE_9528
if 
  " + _8075 + @" == 7 
else_jump @SHRANGE_9609 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_9609 
00BA: show_text_styled GXT 'RACE5' time 1000 style 4  
" + _8075 + @" = 8 
" + _8125 + @" = 0 
" + _8126 + @" = 0 
" + _8127 + @" = 0 

:SHRANGE_9609
if 
  " + _8075 + @" == 8 
else_jump @SHRANGE_9728 
if 
  " + _8126 + @" >= 20 
else_jump @SHRANGE_9674 
" + _8070 + @" = 3 
" + _8075 + @" = 0 
0151: remove_status_text " + _8125 + @" 
0151: remove_status_text " + _8126 + @" 
0151: remove_status_text " + _8127 + @" 

:SHRANGE_9674
if or
  " + _8125 + @" >= 20 
  " + _8127 + @" >= 20 
else_jump @SHRANGE_9728 
" + _8070 + @" = 20 
" + _8075 + @" = 0 
0151: remove_status_text " + _8125 + @" 
0151: remove_status_text " + _8126 + @" 
0151: remove_status_text " + _8127 + @" 

:SHRANGE_9728
if 
  " + _8075 + @" == 10 
else_jump @SHRANGE_9790 
" + tmp_8032 + @"[0] = 5 
" + tmp_8032 + @"[1] = 5 
" + tmp_8032 + @"[2] = 5 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 7000 
" + _8075 + @" = 11 

:SHRANGE_9790
if 
  " + _8075 + @" == 11 
else_jump @SHRANGE_9973 
if and
  " + tmp_8032 + @"[0] == 99 
  " + tmp_8032 + @"[1] == 99 
  " + tmp_8032 + @"[2] == 99 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_9973 
if 
  " + _8124 + @" == 5 
else_jump @SHRANGE_9882 
00BA: show_text_styled GXT 'ANR_49' time 2000 style 1  

:SHRANGE_9882
if 
  " + _8124 + @" == 8 
else_jump @SHRANGE_9916 
00BA: show_text_styled GXT 'ANR_25' time 2000 style 1  

:SHRANGE_9916
if 
  " + _8124 + @" == 11 
else_jump @SHRANGE_9950 
00BA: show_text_styled GXT 'ANR_52' time 2000 style 1  

:SHRANGE_9950
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 4000 
" + _8075 + @" = 12 

:SHRANGE_9973
if 
  " + _8075 + @" == 12 
else_jump @SHRANGE_10189 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_10189 
" + _8125 + @" = 0 
" + _8126 + @" = 0 
" + _8127 + @" = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8025 + @"[0] = 0 
" + tmp_8025 + @"[1] = 5 
" + tmp_8025 + @"[2] = 0 
" + _8125 + @" = 0 
" + _8126 + @" = 0 
" + _8127 + @" = 0 
03C4: set_status_text " + _8125 + @" type 0 GXT 'ANR_37' 
04F7: status_text " + _8126 + @" type 0 line 2 GXT 'ANR_39' 
04F7: status_text " + _8127 + @" type 0 line 3 GXT 'ANR_38' 
00BA: show_text_styled GXT 'RACE2' time 1000 style 4  
" + _8075 + @" = 5 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 1000 
Player.CanMove(" + PlayerChar + @") = True
02A3: enable_widescreen 0 

:SHRANGE_10189
jump @SHRANGE_11071 

:SHRANGE_10196
if 
  " + _8075 + @" == 0 
else_jump @SHRANGE_10253 
00BA: show_text_styled GXT 'ANR_16' time 3000 style 1  
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 3000 
" + _8075 + @" = 1 

:SHRANGE_10253
if 
  " + _8075 + @" == 1 
else_jump @SHRANGE_10304 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_10304 
fade 0 1000 
" + _8075 + @" = 2 

:SHRANGE_10304
if 
  " + _8075 + @" == 2 
else_jump @SHRANGE_10362 
if 
   not fading 
else_jump @SHRANGE_10362 
008A: " + _8076 + @" = 32@ 
" + _8076 + @" += 500 
08F8: display_stat_update_box 1 
" + _8075 + @" = 3 

:SHRANGE_10362
if 
  " + _8075 + @" == 3 
else_jump @SHRANGE_11064 
if 
001F:   32@ > " + _8076 + @" 
else_jump @SHRANGE_11064 
" + _8083 + @" = 2.0 
" + _8084 + @" = -12.0 
" + tempvar_Float_3 + @" = 0.0 
0151: remove_status_text " + _8125 + @" 
0151: remove_status_text " + _8126 + @" 
0151: remove_status_text " + _8127 + @" 
0465: remove_actor " + PlayerActor + @" from_turret_mode 
gosub @SHRANGE_16833 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 
0555: remove_weapon 22 from_actor " + PlayerActor + @" 
if 
  " + _8131 + @" > 0 
else_jump @SHRANGE_10531 

:SHRANGE_10488
if 
   not Model.Available(" + _8139 + @")
else_jump @SHRANGE_10520 
Model.Load(" + _8139 + @")
wait 0 
jump @SHRANGE_10488 

:SHRANGE_10520
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", " + _8135 + @", " + _8131 + @")

:SHRANGE_10531
0555: remove_weapon 28 from_actor " + PlayerActor + @" 
if 
  " + _8132 + @" > 0 
else_jump @SHRANGE_10599 

:SHRANGE_10556
if 
   not Model.Available(" + _8140 + @")
else_jump @SHRANGE_10588 
Model.Load(" + _8140 + @")
wait 0 
jump @SHRANGE_10556 

:SHRANGE_10588
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", " + _8136 + @", " + _8132 + @")

:SHRANGE_10599
0555: remove_weapon 25 from_actor " + PlayerActor + @" 
if 
  " + _8133 + @" > 0 
else_jump @SHRANGE_10667 

:SHRANGE_10624
if 
   not Model.Available(" + _8141 + @")
else_jump @SHRANGE_10656 
Model.Load(" + _8141 + @")
wait 0 
jump @SHRANGE_10624 

:SHRANGE_10656
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", " + _8137 + @", " + _8133 + @")

:SHRANGE_10667
0555: remove_weapon 30 from_actor " + PlayerActor + @" 
if 
  " + _8134 + @" > 0 
else_jump @SHRANGE_10735 

:SHRANGE_10692
if 
   not Model.Available(" + _8142 + @")
else_jump @SHRANGE_10724 
Model.Load(" + _8142 + @")
wait 0 
jump @SHRANGE_10692 

:SHRANGE_10724
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", " + _8138 + @", " + _8134 + @")

:SHRANGE_10735
082A: set_player " + PlayerChar + @" able_to_use_crouch_button 1 
Object.Destroy(" + _8065 + @")
00BE: text_clear_all 
08C7: put_actor " + PlayerActor + @" at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" dont_warp_gang 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @SHRANGE_10786 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False

:SHRANGE_10786
Player.CanMove(" + PlayerChar + @") = True
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @SHRANGE_10829 
Actor.Angle(" + PlayerActor + @") = 59@(" + Shooting_Index_2 + @",4f)

:SHRANGE_10829
" + tmp_8089 + @"[1] = 1 
fade 1 1000 
" + _8070 + @" = 0 
" + _8075 + @" = 0 
" + tmp_8071 + @"[0] = 0 
" + tmp_8071 + @"[1] = 0 
" + tmp_8071 + @"[2] = 0 
" + tmp_8028 + @"[0] = 0 
" + tmp_8028 + @"[1] = 0 
" + tmp_8028 + @"[2] = 0 
" + tmp_8086 + @"[0] = 1 
if 
   Actor.Dead(" + tmp_8094 + @"[1])
else_jump @SHRANGE_10929 
" + tmp_8086 + @"[1] = 0 

:SHRANGE_10929
" + tmp_8086 + @"[2] = 1 
" + tmp_8025 + @"[0] = 0 
" + tmp_8025 + @"[1] = 0 
" + tmp_8025 + @"[2] = 0 
" + tmp_8032 + @"[0] = 0 
" + tmp_8032 + @"[1] = 0 
" + tmp_8032 + @"[2] = 0 
if 
  34@ == 1 
else_jump @SHRANGE_11023 
0A0E: disable_text_with_style 1 
00BB: show_text_lowpriority GXT 'ANR_A1' time 4000 flag 1  
34@ = 0 

:SHRANGE_11023
if and
   not " + _5273 + @" == 4 
   not 34@ == 1 
else_jump @SHRANGE_11064 
00BB: show_text_lowpriority GXT 'ANR_55' time 4000 flag 1  

:SHRANGE_11064
jump @SHRANGE_11071 

:SHRANGE_11071
return 

:SHRANGE_11073
" + Shooting_Index + @" = 0 
0084: " + _8143 + @" = " + tmp_8032 + @"[0] 
0084: " + _8146 + @" = " + tmp_8032 + @"[1] 
0084: " + _8149 + @" = " + tmp_8032 + @"[2] 

:SHRANGE_11104
if 
  3 > " + Shooting_Index + @" 
else_jump @SHRANGE_13460 
0871: init_jump_table " + tmp_8086 + @"(" + Shooting_Index + @",3i) total_jumps 5 default_jump 0 @SHRANGE_13446 jumps 0 @SHRANGE_11189 1 @SHRANGE_11603 2 @SHRANGE_11872 3 @SHRANGE_12860 4 @SHRANGE_13399 -1 @SHRANGE_13446 -1 @SHRANGE_13446 

:SHRANGE_11189
if 
  " + tmp_8089 + @"(" + Shooting_Index + @",3i) == 1 
else_jump @SHRANGE_11596 
" + tmp_8086 + @"(" + Shooting_Index + @",3i) = 1 
0088: " + tempvar_Float_1 + @" = 35@(" + Shooting_Index_2 + @",4f) 
0088: " + tempvar_Float_2 + @" = 39@(" + Shooting_Index_2 + @",4f) 
0088: " + tempvar_Float_3 + @" = 43@(" + Shooting_Index_2 + @",4f) 
0087: 63@ = 59@(" + Shooting_Index_2 + @",4f) 
if 
  " + Shooting_Index + @" == 1 
else_jump @SHRANGE_11387 
if 
  63@ == 90.0 
else_jump @SHRANGE_11321 
005F: " + tempvar_Float_2 + @" += 47@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_11321
if 
  63@ == 270.0 
else_jump @SHRANGE_11354 
0067: " + tempvar_Float_2 + @" -= 47@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_11354
if 
  63@ == 0.0 
else_jump @SHRANGE_11387 
005F: " + tempvar_Float_1 + @" += 47@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_11387
if 
  " + Shooting_Index + @" == 2 
else_jump @SHRANGE_11504 
if 
  63@ == 90.0 
else_jump @SHRANGE_11438 
005F: " + tempvar_Float_2 + @" += 51@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_11438
if 
  63@ == 270.0 
else_jump @SHRANGE_11471 
0067: " + tempvar_Float_2 + @" -= 51@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_11471
if 
  63@ == 0.0 
else_jump @SHRANGE_11504 
005F: " + tempvar_Float_1 + @" += 51@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_11504
0376: " + tmp_8094 + @"(" + Shooting_Index + @",3i) = create_random_actor_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
   not Actor.Dead(" + tmp_8094 + @"(" + Shooting_Index + @",3i))
else_jump @SHRANGE_11596 
Actor.SetImmunities(" + tmp_8094 + @"(" + Shooting_Index + @",3i), 1, 1, 1, 1, 1)
060B: set_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) decision_maker_to " + _8069 + @" 
Actor.WeaponAccuracy(" + tmp_8094 + @"(" + Shooting_Index + @",3i)) = 93
Actor.Angle(" + tmp_8094 + @"(" + Shooting_Index + @",3i)) = 63@

:SHRANGE_11596
jump @SHRANGE_13446 

:SHRANGE_11603
if 
   not Actor.Dead(" + tmp_8094 + @"(" + Shooting_Index + @",3i))
else_jump @SHRANGE_11865 
if 
  " + tmp_8028 + @"(" + Shooting_Index + @",4i) == 0 
else_jump @SHRANGE_11658 
0209: " + tmp_8028 + @"(" + Shooting_Index + @",4i) = random_int_in_ranges 1 5 

:SHRANGE_11658
if 
  " + tmp_8028 + @"(" + Shooting_Index + @",4i) == 1 
else_jump @SHRANGE_11707 
Actor.GiveWeaponAndAmmo(" + tmp_8094 + @"(" + Shooting_Index + @",3i), Pistol, 99999)
01B9: set_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) armed_weapon_to 22 

:SHRANGE_11707
if 
  " + tmp_8028 + @"(" + Shooting_Index + @",4i) == 2 
else_jump @SHRANGE_11756 
Actor.GiveWeaponAndAmmo(" + tmp_8094 + @"(" + Shooting_Index + @",3i), MicroUzi, 99999)
01B9: set_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) armed_weapon_to 28 

:SHRANGE_11756
if 
  " + tmp_8028 + @"(" + Shooting_Index + @",4i) == 3 
else_jump @SHRANGE_11805 
Actor.GiveWeaponAndAmmo(" + tmp_8094 + @"(" + Shooting_Index + @",3i), Shotgun, 99999)
01B9: set_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) armed_weapon_to 25 

:SHRANGE_11805
if 
  " + tmp_8028 + @"(" + Shooting_Index + @",4i) == 4 
else_jump @SHRANGE_11854 
Actor.GiveWeaponAndAmmo(" + tmp_8094 + @"(" + Shooting_Index + @",3i), AK47, 99999)
01B9: set_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) armed_weapon_to 30 

:SHRANGE_11854
" + tmp_8086 + @"(" + Shooting_Index + @",3i) = 2 

:SHRANGE_11865
jump @SHRANGE_13446 

:SHRANGE_11872
" + tmp_8077 + @" = 0 
if 
  " + tmp_8032 + @"(" + Shooting_Index + @",3i) == 2 
else_jump @SHRANGE_11908 
" + tmp_8077 + @" = 1 

:SHRANGE_11908
if and
  " + _8070 + @" == 5 
  " + tmp_8032 + @"[1] == 2 
else_jump @SHRANGE_11940 
" + tmp_8077 + @" = 1 

:SHRANGE_11940
if 
  " + Shooting_Index + @" == 0 
else_jump @SHRANGE_11966 
0084: " + _8144 + @" = " + tmp_8077 + @" 

:SHRANGE_11966
if 
  " + Shooting_Index + @" == 1 
else_jump @SHRANGE_11992 
0084: " + _8147 + @" = " + tmp_8077 + @" 

:SHRANGE_11992
if 
  " + Shooting_Index + @" == 2 
else_jump @SHRANGE_12018 
0084: " + _8150 + @" = " + tmp_8077 + @" 

:SHRANGE_12018
if 
  " + tmp_8077 + @" == 1 
else_jump @SHRANGE_12791 
if 
001F:   32@ > " + tmp_8121 + @"(" + Shooting_Index + @",3i) 
else_jump @SHRANGE_12784 
0209: " + tmp_8077 + @" = random_int_in_ranges 1 8 
if 
  " + _8070 + @" == 5 
else_jump @SHRANGE_12100 
" + tmp_8077 + @" += 8 
jump @SHRANGE_12150 

:SHRANGE_12100
if 
  " + Shooting_Index + @" == 2 
else_jump @SHRANGE_12125 
" + tmp_8077 + @" += 16 

:SHRANGE_12125
if 
  " + Shooting_Index + @" == 1 
else_jump @SHRANGE_12150 
" + tmp_8077 + @" += 8 

:SHRANGE_12150
" + _8092 + @" = 0 

:SHRANGE_12157
if and
0366:   object " + tmp_8097 + @"(" + tmp_8077 + @",24i) damaged 
  8 > " + _8092 + @" 
else_jump @SHRANGE_12244 
" + tmp_8077 + @" += 1 
" + _8092 + @" += 1 
if or
  " + tmp_8077 + @" == 8 
  " + tmp_8077 + @" == 24 
  " + tmp_8077 + @" == 16 
else_jump @SHRANGE_12237 
" + tmp_8077 + @" -= 7 

:SHRANGE_12237
jump @SHRANGE_12157 

:SHRANGE_12244
if 
  " + Shooting_Index + @" == 0 
else_jump @SHRANGE_12270 
0084: " + _8145 + @" = " + _8092 + @" 

:SHRANGE_12270
if 
  " + Shooting_Index + @" == 1 
else_jump @SHRANGE_12296 
0084: " + _8148 + @" = " + _8092 + @" 

:SHRANGE_12296
if 
  " + Shooting_Index + @" == 2 
else_jump @SHRANGE_12322 
0084: " + _8151 + @" = " + _8092 + @" 

:SHRANGE_12322
if 
   not Actor.Dead(" + tmp_8094 + @"(" + Shooting_Index + @",3i))
else_jump @SHRANGE_12784 
Object.StorePos(" + tmp_8097 + @"(" + tmp_8077 + @",24i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if and
  " + tmp_8077 + @" > 8 
  16 > " + tmp_8077 + @" 
else_jump @SHRANGE_12392 
" + tmp_8077 + @" -= 8 

:SHRANGE_12392
if and
  " + tmp_8077 + @" > 16 
  24 > " + tmp_8077 + @" 
else_jump @SHRANGE_12424 
" + tmp_8077 + @" -= 16 

:SHRANGE_12424
if 
  63@ == 0.0 
else_jump @SHRANGE_12457 
0059: " + tempvar_Float_1 + @" += " + tmp_8038 + @"(" + tmp_8077 + @",8f) 

:SHRANGE_12457
if 
  63@ == 90.0 
else_jump @SHRANGE_12490 
0059: " + tempvar_Float_2 + @" += " + tmp_8038 + @"(" + tmp_8077 + @",8f) 

:SHRANGE_12490
if 
  63@ == 270.0 
else_jump @SHRANGE_12523 
0061: " + tempvar_Float_2 + @" -= " + tmp_8038 + @"(" + tmp_8077 + @",8f) 

:SHRANGE_12523
0059: " + tempvar_Float_3 + @" += " + tmp_8046 + @"(" + tmp_8077 + @",8f) 
if 
  " + _8124 + @" >= 8 
else_jump @SHRANGE_12636 
062E: get_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) task 1640 status_store_to " + tmp_8077 + @" 
if 
04A3:   " + tmp_8077 + @" == 7 
else_jump @SHRANGE_12629 
Actor.LockInCurrentPosition(" + tmp_8094 + @"(" + Shooting_Index + @",3i)) = True
0668: AS_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) rotate_and_shoot_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 800 ms 
Actor.WeaponAccuracy(" + tmp_8094 + @"(" + Shooting_Index + @",3i)) = 95

:SHRANGE_12629
jump @SHRANGE_12701 

:SHRANGE_12636
062E: get_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) task 1640 status_store_to " + tmp_8077 + @" 
if 
04A3:   " + tmp_8077 + @" == 7 
else_jump @SHRANGE_12701 
Actor.LockInCurrentPosition(" + tmp_8094 + @"(" + Shooting_Index + @",3i)) = True
0668: AS_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) rotate_and_shoot_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 1500 ms 

:SHRANGE_12701
if 
  " + _8124 + @" >= 8 
else_jump @SHRANGE_12749 
0209: " + tmp_8077 + @" = random_int_in_ranges 200 400 
" + tmp_8121 + @"(" + Shooting_Index + @",3i) += 600 
jump @SHRANGE_12760 

:SHRANGE_12749
0209: " + tmp_8077 + @" = random_int_in_ranges 200 1600 

:SHRANGE_12760
008A: " + tmp_8121 + @"(" + Shooting_Index + @",3i) = 32@ 
0058: " + tmp_8121 + @"(" + Shooting_Index + @",3i) += " + tmp_8077 + @" 

:SHRANGE_12784
jump @SHRANGE_12853 

:SHRANGE_12791
if 
   not Actor.Dead(" + tmp_8094 + @"(" + Shooting_Index + @",3i))
else_jump @SHRANGE_12853 
062E: get_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) task 1640 status_store_to " + tmp_8077 + @" 
if 
84A3:   not  " + tmp_8077 + @" == 7 
else_jump @SHRANGE_12853 
0687: clear_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) task 

:SHRANGE_12853
jump @SHRANGE_13446 

:SHRANGE_12860
if 
   not Actor.Dead(" + tmp_8094 + @"(" + Shooting_Index + @",3i))
else_jump @SHRANGE_13392 
Actor.StorePos(" + tmp_8094 + @"(" + Shooting_Index + @",3i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.LockInCurrentPosition(" + tmp_8094 + @"(" + Shooting_Index + @",3i)) = False
05D6: clear_scmpath 
0615: define_AS_pack_begin " + _8079 + @" 
" + _8083 + @" = 0.0 
005F: " + _8083 + @" += 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = -1.0 
02F7: " + _8081 + @" = cosine 59@(" + Shooting_Index_2 + @",4f) 
02F6: " + _8082 + @" = sine 59@(" + Shooting_Index_2 + @",4f) 
if 
  59@(" + Shooting_Index_2 + @",4f) == 0.0 
else_jump @SHRANGE_13036 
0086: " + tempvar_Float_1 + @" = " + _8083 + @" 
0069: " + tempvar_Float_1 + @" *= " + _8081 + @" 
0086: " + tempvar_Float_2 + @" = " + _8084 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8081 + @" 
jump @SHRANGE_13078 

:SHRANGE_13036
" + _8084 + @" *= -1.0 
0086: " + tempvar_Float_1 + @" = " + _8084 + @" 
0069: " + tempvar_Float_1 + @" *= " + _8082 + @" 
0086: " + tempvar_Float_2 + @" = " + _8083 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8082 + @" 

:SHRANGE_13078
005F: " + tempvar_Float_1 + @" += 35@(" + Shooting_Index_2 + @",4f) 
005F: " + tempvar_Float_2 + @" += 39@(" + Shooting_Index_2 + @",4f) 
005F: " + tempvar_Float_3 + @" += 43@(" + Shooting_Index_2 + @",4f) 
0087: 63@ = 59@(" + Shooting_Index_2 + @",4f) 
63@ -= 180.0 
05D4: AS_actor -1 rotate_angle 63@ 
0087: 63@ = 59@(" + Shooting_Index_2 + @",4f) 
05D7: add_point_to_scmpath " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + _8083 + @" = -0.5 
005F: " + _8083 + @" += 47@(" + Shooting_Index_2 + @",4f) 
" + _8084 + @" = -4.5 
if 
  59@(" + Shooting_Index_2 + @",4f) == 0.0 
else_jump @SHRANGE_13262 
0086: " + tempvar_Float_1 + @" = " + _8083 + @" 
0069: " + tempvar_Float_1 + @" *= " + _8081 + @" 
0086: " + tempvar_Float_2 + @" = " + _8084 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8081 + @" 
jump @SHRANGE_13304 

:SHRANGE_13262
" + _8084 + @" *= -1.0 
0086: " + tempvar_Float_1 + @" = " + _8084 + @" 
0069: " + tempvar_Float_1 + @" *= " + _8082 + @" 
0086: " + tempvar_Float_2 + @" = " + _8083 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8082 + @" 

:SHRANGE_13304
005F: " + tempvar_Float_1 + @" += 35@(" + Shooting_Index_2 + @",4f) 
005F: " + tempvar_Float_2 + @" += 39@(" + Shooting_Index_2 + @",4f) 
005F: " + tempvar_Float_3 + @" += 43@(" + Shooting_Index_2 + @",4f) 
05D7: add_point_to_scmpath " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
0616: define_AS_pack_end " + _8079 + @" 
0618: assign_actor " + tmp_8094 + @"(" + Shooting_Index + @",3i) to_AS_pack " + _8079 + @" 
061B: remove_references_to_AS_pack " + _8079 + @" 
" + tmp_8086 + @"(" + Shooting_Index + @",3i) = 99 

:SHRANGE_13392
jump @SHRANGE_13446 

:SHRANGE_13399
if 
   not Actor.Dead(" + tmp_8094 + @"(" + Shooting_Index + @",3i))
else_jump @SHRANGE_13428 
Actor.DestroyInstantly(" + tmp_8094 + @"(" + Shooting_Index + @",3i))

:SHRANGE_13428
" + tmp_8086 + @"(" + Shooting_Index + @",3i) = 0 
jump @SHRANGE_13446 

:SHRANGE_13446
" + Shooting_Index + @" += 1 
jump @SHRANGE_11104 

:SHRANGE_13460
return 

:SHRANGE_13462
" + Shooting_Index + @" = 0 

:SHRANGE_13469
if 
  3 > " + Shooting_Index + @" 
else_jump @SHRANGE_16831 
0871: init_jump_table " + tmp_8032 + @"(" + Shooting_Index + @",3i) total_jumps 6 default_jump 0 @SHRANGE_16817 jumps 0 @SHRANGE_13554 1 @SHRANGE_14336 2 @SHRANGE_14665 3 @SHRANGE_16266 4 @SHRANGE_16568 5 @SHRANGE_16689 -1 @SHRANGE_16817 

:SHRANGE_13554
0708: reset_decision_maker " + _8069 + @" event 15 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 1 
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 0 
else_jump @SHRANGE_13640 
0209: " + tmp_8025 + @"(" + Shooting_Index + @",3i) = random_int_in_ranges 1 3 
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 2 
else_jump @SHRANGE_13640 
" + tmp_8025 + @"(" + Shooting_Index + @",3i) = 4 

:SHRANGE_13640
" + tempvar_Float_1 + @" = 0.0 
" + tempvar_Float_2 + @" = 5.0 
" + tempvar_Float_3 + @" = 4.0 
0087: 63@ = 59@(" + Shooting_Index_2 + @",4f) 
if 
  5 > " + tmp_8025 + @"(" + Shooting_Index + @",3i) 
else_jump @SHRANGE_13871 
if 
  " + Shooting_Index + @" == 1 
else_jump @SHRANGE_13734 
005F: " + tempvar_Float_1 + @" += 47@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_13734
if 
  " + Shooting_Index + @" == 2 
else_jump @SHRANGE_13764 
005F: " + tempvar_Float_1 + @" += 51@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_13764
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 1 
else_jump @SHRANGE_13796 
" + tempvar_Float_2 + @" += 0.0 

:SHRANGE_13796
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 2 
else_jump @SHRANGE_13828 
" + tempvar_Float_2 + @" += 5.0 

:SHRANGE_13828
if or
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 3 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 4 
else_jump @SHRANGE_13871 
" + tempvar_Float_2 + @" += 10.0 

:SHRANGE_13871
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 5 
else_jump @SHRANGE_13955 
0208: " + _8085 + @" = random_float_in_ranges 0.0 10.0 
0059: " + tempvar_Float_2 + @" += " + _8085 + @" 
0209: " + _8080 + @" = random_int_in_ranges 0 2 
if 
  " + _8080 + @" == 1 
else_jump @SHRANGE_13955 
005F: " + tempvar_Float_1 + @" += 51@(" + Shooting_Index_2 + @",4f) 

:SHRANGE_13955
0086: " + _8083 + @" = " + tempvar_Float_1 + @" 
0086: " + _8084 + @" = " + tempvar_Float_2 + @" 
gosub @SHRANGE_16833 
0084: " + tmp_8077 + @" = " + Shooting_Index + @" 
" + tmp_8077 + @" *= 8 
if 
03CA:   object " + tmp_8097 + @"(" + tmp_8077 + @",24i) exists 
else_jump @SHRANGE_14022 
Object.Destroy(" + tmp_8097 + @"(" + tmp_8077 + @",24i))

:SHRANGE_14022
" + tmp_8097 + @"(" + tmp_8077 + @",24i) = Object.Init(" + tmp_8057 + @"[0], " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0453: set_object " + tmp_8097 + @"(" + tmp_8077 + @",24i) XYZ_rotation 90.0 0.0 63@ 
097B: play_audio_at_object " + tmp_8097 + @"(" + tmp_8077 + @",24i) event 1032 
" + tmp_8054 + @"(" + Shooting_Index + @",3f) = 90.0 
" + _8092 + @" = 1 

:SHRANGE_14098
if 
  8 > " + _8092 + @" 
else_jump @SHRANGE_14306 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
0058: " + _8093 + @" += " + _8092 + @" 
if 
03CA:   object " + tmp_8097 + @"(" + _8093 + @",24i) exists 
else_jump @SHRANGE_14168 
Object.Destroy(" + tmp_8097 + @"(" + _8093 + @",24i))

:SHRANGE_14168
" + tmp_8097 + @"(" + _8093 + @",24i) = Object.Init(" + tmp_8057 + @"(" + _8092 + @",8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
069A: attach_object " + tmp_8097 + @"(" + _8093 + @",24i) to_object " + tmp_8097 + @"(" + tmp_8077 + @",24i) with_offset 0.0 0.0 0.0 rotation 0.0 0.0 0.0 
if 
03CA:   object " + tmp_8097 + @"(" + _8093 + @",24i) exists 
else_jump @SHRANGE_14292 
0453: set_object " + tmp_8097 + @"(" + _8093 + @",24i) XYZ_rotation 90.0 0.0 63@ 
Object.CollisionDetection(" + tmp_8097 + @"(" + _8093 + @",24i)) = False

:SHRANGE_14292
" + _8092 + @" += 1 
jump @SHRANGE_14098 

:SHRANGE_14306
" + tmp_8071 + @"(" + Shooting_Index + @",3i) += 1 
008A: " + tmp_8066 + @"(" + Shooting_Index + @",3i) = 32@ 
jump @SHRANGE_16817 

:SHRANGE_14336
008A: " + tmp_8077 + @" = 32@ 
0060: " + tmp_8077 + @" -= " + tmp_8066 + @"(" + Shooting_Index + @",3i) 
if 
  " + tmp_8077 + @" > 3000 
else_jump @SHRANGE_14383 
" + tmp_8077 + @" = 3000 

:SHRANGE_14383
008D: " + _8081 + @" = integer " + tmp_8077 + @" to_float 
" + _8081 + @" /= 3000.0 
" + _8081 + @" *= -90.0 
" + _8081 + @" += 90.0 
0086: " + tmp_8054 + @"(" + Shooting_Index + @",3f) = " + _8081 + @" 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
if 
03CA:   object " + tmp_8097 + @"(" + _8093 + @",24i) exists 
else_jump @SHRANGE_14492 
0453: set_object " + tmp_8097 + @"(" + _8093 + @",24i) XYZ_rotation " + tmp_8054 + @"(" + Shooting_Index + @",3f) 0.0 63@ 

:SHRANGE_14492
if 
  0.0 >= " + tmp_8054 + @"(" + Shooting_Index + @",3f) 
else_jump @SHRANGE_14658 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 2 
008A: " + tmp_8066 + @"(" + Shooting_Index + @",3i) = 32@ 
if or
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 4 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 5 
else_jump @SHRANGE_14585 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1033 

:SHRANGE_14585
" + _8092 + @" = 0 

:SHRANGE_14592
if 
  8 > " + _8092 + @" 
else_jump @SHRANGE_14658 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
0058: " + _8093 + @" += " + _8092 + @" 
Object.CollisionDetection(" + tmp_8097 + @"(" + _8093 + @",24i)) = True
" + _8092 + @" += 1 
jump @SHRANGE_14592 

:SHRANGE_14658
jump @SHRANGE_16817 

:SHRANGE_14665
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 4 
else_jump @SHRANGE_15301 
008A: " + tmp_8077 + @" = 32@ 
0060: " + tmp_8077 + @" -= " + tmp_8066 + @"(" + Shooting_Index + @",3i) 
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 4 
else_jump @SHRANGE_14740 
" + tmp_8071 + @"(" + Shooting_Index + @",3i) = 1 

:SHRANGE_14740
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 1 
else_jump @SHRANGE_14816 
if 
  " + tmp_8077 + @" > 20000 
else_jump @SHRANGE_14816 
" + tmp_8077 + @" = 20000 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1034 

:SHRANGE_14816
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 2 
else_jump @SHRANGE_14892 
if 
  " + tmp_8077 + @" > 15000 
else_jump @SHRANGE_14892 
" + tmp_8077 + @" = 15000 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1034 

:SHRANGE_14892
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 3 
else_jump @SHRANGE_14968 
if 
  " + tmp_8077 + @" > 10000 
else_jump @SHRANGE_14968 
" + tmp_8077 + @" = 10000 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1034 

:SHRANGE_14968
008D: " + _8081 + @" = integer " + tmp_8077 + @" to_float 
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 1 
else_jump @SHRANGE_15008 
" + _8081 + @" /= 20000.0 

:SHRANGE_15008
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 2 
else_jump @SHRANGE_15040 
" + _8081 + @" /= 15000.0 

:SHRANGE_15040
if 
  " + tmp_8071 + @"(" + Shooting_Index + @",3i) == 3 
else_jump @SHRANGE_15072 
" + _8081 + @" /= 10000.0 

:SHRANGE_15072
" + _8081 + @" *= 10.0 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
Object.StorePos(" + tmp_8097 + @"(" + _8093 + @",24i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
  63@ == 90.0 
else_jump @SHRANGE_15166 
0088: " + tempvar_Float_1 + @" = 35@(" + Shooting_Index_2 + @",4f) 
" + tempvar_Float_1 + @" -= 15.0 
0059: " + tempvar_Float_1 + @" += " + _8081 + @" 

:SHRANGE_15166
if 
  63@ == 270.0 
else_jump @SHRANGE_15217 
0088: " + tempvar_Float_1 + @" = 35@(" + Shooting_Index_2 + @",4f) 
" + tempvar_Float_1 + @" += 15.0 
0061: " + tempvar_Float_1 + @" -= " + _8081 + @" 

:SHRANGE_15217
if 
  63@ == 0.0 
else_jump @SHRANGE_15268 
0088: " + tempvar_Float_2 + @" = 39@(" + Shooting_Index_2 + @",4f) 
" + tempvar_Float_2 + @" += 15.0 
0061: " + tempvar_Float_2 + @" -= " + _8081 + @" 

:SHRANGE_15268
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
Object.PutAt(" + tmp_8097 + @"(" + _8093 + @",24i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:SHRANGE_15301
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 5 
else_jump @SHRANGE_15658 
008A: " + tmp_8077 + @" = 32@ 
0060: " + tmp_8077 + @" -= " + tmp_8066 + @"(" + Shooting_Index + @",3i) 
if 
  " + tmp_8077 + @" > 10000 
else_jump @SHRANGE_15507 
" + tmp_8077 + @" = 10000 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 3 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1034 
097A: play_audio_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" event 1032 
008A: " + tmp_8066 + @"(" + Shooting_Index + @",3i) = 32@ 
" + _8092 + @" = 0 

:SHRANGE_15441
if 
  8 > " + _8092 + @" 
else_jump @SHRANGE_15507 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
0058: " + _8093 + @" += " + _8092 + @" 
Object.CollisionDetection(" + tmp_8097 + @"(" + _8093 + @",24i)) = False
" + _8092 + @" += 1 
jump @SHRANGE_15441 

:SHRANGE_15507
008D: " + _8081 + @" = integer " + tmp_8077 + @" to_float 
" + _8081 + @" /= 10000.0 
006D: " + _8081 + @" *= 51@(" + Shooting_Index_2 + @",4f) 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
if 
  " + _8080 + @" == 0 
else_jump @SHRANGE_15585 
0086: " + _8083 + @" = " + _8081 + @" 
jump @SHRANGE_15605 

:SHRANGE_15585
0088: " + _8083 + @" = 51@(" + Shooting_Index_2 + @",4f) 
0061: " + _8083 + @" -= " + _8081 + @" 

:SHRANGE_15605
" + tempvar_Float_3 + @" = 4.0 
0086: " + _8084 + @" = " + _8085 + @" 
" + _8084 + @" += 5.0 
gosub @SHRANGE_16833 
Object.PutAt(" + tmp_8097 + @"(" + _8093 + @",24i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:SHRANGE_15658
0084: " + tmp_8077 + @" = " + tmp_8035 + @"(" + Shooting_Index + @",3i) 
" + tmp_8035 + @"(" + Shooting_Index + @",3i) = 0 
" + _8092 + @" = 0 

:SHRANGE_15688
if 
  8 > " + _8092 + @" 
else_jump @SHRANGE_15774 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
0058: " + _8093 + @" += " + _8092 + @" 
if 
0366:   object " + tmp_8097 + @"(" + _8093 + @",24i) damaged 
else_jump @SHRANGE_15760 
" + tmp_8035 + @"(" + Shooting_Index + @",3i) += 1 

:SHRANGE_15760
" + _8092 + @" += 1 
jump @SHRANGE_15688 

:SHRANGE_15774
if 
001C:   " + tmp_8035 + @"(" + Shooting_Index + @",3i) > " + tmp_8077 + @" 
else_jump @SHRANGE_15809 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1031 

:SHRANGE_15809
if 
  " + Shooting_Index + @" == 1 
else_jump @SHRANGE_16132 
if 
001C:   " + tmp_8035 + @"[1] > " + tmp_8077 + @" 
else_jump @SHRANGE_16132 
0084: " + _8078 + @" = " + tmp_8035 + @"[1] 
0060: " + _8078 + @" -= " + tmp_8077 + @" 
0209: " + tmp_8077 + @" = random_int_in_ranges 0 2 
if 
  " + tmp_8077 + @" == 0 
else_jump @SHRANGE_16014 
if 
   not Actor.Dead(" + tmp_8094 + @"[0])
else_jump @SHRANGE_16007 
if 
02E0:   actor " + tmp_8094 + @"[0] firing_weapon 
else_jump @SHRANGE_15936 
0058: " + _8125 + @" += " + _8078 + @" 
jump @SHRANGE_16007 

:SHRANGE_15936
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
else_jump @SHRANGE_15967 
0058: " + _8126 + @" += " + _8078 + @" 
jump @SHRANGE_16007 

:SHRANGE_15967
if 
   not Actor.Dead(" + tmp_8094 + @"[2])
else_jump @SHRANGE_16007 
if 
02E0:   actor " + tmp_8094 + @"[2] firing_weapon 
else_jump @SHRANGE_16007 
0058: " + _8127 + @" += " + _8078 + @" 

:SHRANGE_16007
jump @SHRANGE_16132 

:SHRANGE_16014
if 
   not Actor.Dead(" + tmp_8094 + @"[2])
else_jump @SHRANGE_16132 
if 
02E0:   actor " + tmp_8094 + @"[2] firing_weapon 
else_jump @SHRANGE_16061 
0058: " + _8127 + @" += " + _8078 + @" 
jump @SHRANGE_16132 

:SHRANGE_16061
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
else_jump @SHRANGE_16092 
0058: " + _8126 + @" += " + _8078 + @" 
jump @SHRANGE_16132 

:SHRANGE_16092
if 
   not Actor.Dead(" + tmp_8094 + @"[0])
else_jump @SHRANGE_16132 
if 
02E0:   actor " + tmp_8094 + @"[0] firing_weapon 
else_jump @SHRANGE_16132 
0058: " + _8125 + @" += " + _8078 + @" 

:SHRANGE_16132
if 
  " + tmp_8035 + @"(" + Shooting_Index + @",3i) == 7 
else_jump @SHRANGE_16259 
008A: " + tmp_8066 + @"(" + Shooting_Index + @",3i) = 32@ 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 3 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1034 
097A: play_audio_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" event 1032 
0708: reset_decision_maker " + _8069 + @" event 15 
0709: set_decision_maker " + _8069 + @" on_event 15 taskID 300 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 

:SHRANGE_16259
jump @SHRANGE_16817 

:SHRANGE_16266
008A: " + tmp_8077 + @" = 32@ 
0060: " + tmp_8077 + @" -= " + tmp_8066 + @"(" + Shooting_Index + @",3i) 
if 
  " + tmp_8077 + @" > 2000 
else_jump @SHRANGE_16313 
" + tmp_8077 + @" = 2000 

:SHRANGE_16313
008D: " + _8081 + @" = integer " + tmp_8077 + @" to_float 
" + _8081 + @" /= 2000.0 
" + _8081 + @" *= 90.0 
0086: " + tmp_8054 + @"(" + Shooting_Index + @",3f) = " + _8081 + @" 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
if 
03CA:   object " + tmp_8097 + @"(" + _8093 + @",24i) exists 
else_jump @SHRANGE_16412 
0453: set_object " + tmp_8097 + @"(" + _8093 + @",24i) XYZ_rotation " + tmp_8054 + @"(" + Shooting_Index + @",3f) 0.0 63@ 

:SHRANGE_16412
if 
  " + tmp_8054 + @"(" + Shooting_Index + @",3f) >= 90.0 
else_jump @SHRANGE_16561 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 0 
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 3 
else_jump @SHRANGE_16488 
" + tmp_8025 + @"(" + Shooting_Index + @",3i) = 1 
jump @SHRANGE_16561 

:SHRANGE_16488
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 2 
else_jump @SHRANGE_16528 
" + tmp_8025 + @"(" + Shooting_Index + @",3i) = 3 
jump @SHRANGE_16561 

:SHRANGE_16528
if 
  " + tmp_8025 + @"(" + Shooting_Index + @",3i) == 1 
else_jump @SHRANGE_16561 
" + tmp_8025 + @"(" + Shooting_Index + @",3i) = 2 

:SHRANGE_16561
jump @SHRANGE_16817 

:SHRANGE_16568
" + _8092 + @" = 0 

:SHRANGE_16575
if 
  8 > " + _8092 + @" 
else_jump @SHRANGE_16671 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
0058: " + _8093 + @" += " + _8092 + @" 
if 
03CA:   object " + tmp_8097 + @"(" + _8092 + @",24i) exists 
else_jump @SHRANGE_16657 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8092 + @",24i) event 1034 
Object.Destroy(" + tmp_8097 + @"(" + _8092 + @",24i))

:SHRANGE_16657
" + _8092 + @" += 1 
jump @SHRANGE_16575 

:SHRANGE_16671
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 99 
jump @SHRANGE_16817 

:SHRANGE_16689
" + tmp_8054 + @"(" + Shooting_Index + @",3f) += 1.0 
0084: " + _8093 + @" = " + Shooting_Index + @" 
" + _8093 + @" *= 8 
if 
03CA:   object " + tmp_8097 + @"(" + _8093 + @",24i) exists 
else_jump @SHRANGE_16774 
097B: play_audio_at_object " + tmp_8097 + @"(" + _8093 + @",24i) event 1034 
0453: set_object " + tmp_8097 + @"(" + _8093 + @",24i) XYZ_rotation " + tmp_8054 + @"(" + Shooting_Index + @",3f) 0.0 63@ 

:SHRANGE_16774
if 
  " + tmp_8054 + @"(" + Shooting_Index + @",3f) >= 90.0 
else_jump @SHRANGE_16810 
" + tmp_8032 + @"(" + Shooting_Index + @",3i) = 4 

:SHRANGE_16810
jump @SHRANGE_16817 

:SHRANGE_16817
" + Shooting_Index + @" += 1 
jump @SHRANGE_13469 

:SHRANGE_16831
return 

:SHRANGE_16833
02F7: " + _8081 + @" = cosine 59@(" + Shooting_Index_2 + @",4f) 
02F6: " + _8082 + @" = sine 59@(" + Shooting_Index_2 + @",4f) 
if 
  59@(" + Shooting_Index_2 + @",4f) == 0.0 
else_jump @SHRANGE_16921 
0086: " + tempvar_Float_1 + @" = " + _8083 + @" 
0069: " + tempvar_Float_1 + @" *= " + _8081 + @" 
0086: " + tempvar_Float_2 + @" = " + _8084 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8081 + @" 
jump @SHRANGE_16963 

:SHRANGE_16921
" + _8084 + @" *= -1.0 
0086: " + tempvar_Float_1 + @" = " + _8084 + @" 
0069: " + tempvar_Float_1 + @" *= " + _8082 + @" 
0086: " + tempvar_Float_2 + @" = " + _8083 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8082 + @" 

:SHRANGE_16963
005F: " + tempvar_Float_1 + @" += 35@(" + Shooting_Index_2 + @",4f) 
005F: " + tempvar_Float_2 + @" += 39@(" + Shooting_Index_2 + @",4f) 
005F: " + tempvar_Float_3 + @" += 43@(" + Shooting_Index_2 + @",4f) 
return 

:SHRANGE_17001
Actor.DestroyInstantly(" + tmp_8094 + @"[0])
Actor.DestroyInstantly(" + tmp_8094 + @"[1])
Actor.DestroyInstantly(" + tmp_8094 + @"[2])
0151: remove_status_text " + _8125 + @" 
0151: remove_status_text " + _8126 + @" 
0151: remove_status_text " + _8127 + @" 
Model.Destroy(#TARGET_HEAD)
Model.Destroy(#TARGET_LARM)
Model.Destroy(#TARGET_RARM)
Model.Destroy(#TARGET_LLEG)
Model.Destroy(#TARGET_RLEG)
Model.Destroy(#TARGET_RTORSO)
Model.Destroy(#TARGET_LTORSO)
Model.Destroy(#TARGET_FRAME)
Model.Destroy(#COLT45)
Model.Destroy(#MICRO_UZI)
Model.Destroy(#CHROMEGUN)
Model.Destroy(#AK47)
065C: release_decision_maker " + _8069 + @" 
040D: unload_wav 4 
" + _8092 + @" = 0 

:SHRANGE_17107
if 
  24 > " + _8092 + @" 
else_jump @SHRANGE_17168 
if 
03CA:   object " + tmp_8097 + @"(" + _8092 + @",24i) exists 
else_jump @SHRANGE_17154 
Object.Destroy(" + tmp_8097 + @"(" + _8092 + @",24i))

:SHRANGE_17154
" + _8092 + @" += 1 
jump @SHRANGE_17107 

:SHRANGE_17168
" + ONMISSION_Shooting + @" = 0 
" + OnMission + @" = 0 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @SHRANGE_17205 
Actor.LockInCurrentPosition(" + PlayerActor + @") = False

:SHRANGE_17205
end_thread 
return 
end_thread" );
            }

        }

    }

}