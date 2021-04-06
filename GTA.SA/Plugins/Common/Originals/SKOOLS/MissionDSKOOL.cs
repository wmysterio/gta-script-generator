using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalSkools {

        private sealed class DSKOOL : MissionCustom {

            Int tmp_201 = global( _201.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @DSKOOL_47 
if 
wasted_or_busted 
else_jump @DSKOOL_38 
gosub @DSKOOL_24457 

:DSKOOL_38
gosub @DSKOOL_24586 
end_thread 

:DSKOOL_47
" + OnMission + @" = 1 
if 
  " + Mission_Back_to_School_Passed + @" == 0 
else_jump @DSKOOL_74 
increment_mission_attempts 

:DSKOOL_74
054C: use_GXT_table 'DS' 
if 
  " + OnMission + @" == 0 
else_jump @DSKOOL_291 
" + _198 + @" = Car.Create(#BANSHEE, " + _277 + @", " + _278 + @", " + _257 + @")
" + _196 + @" = Car.Create(#BANSHEE, " + _277 + @", " + _278 + @", " + _257 + @")
" + _197 + @" = Car.Create(#BANSHEE, " + _277 + @", " + _278 + @", " + _257 + @")
" + tmp_201 + @"[20] = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + tmp_201 + @"[30] = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
57@ = Object.Create(#AD_JUMP, " + _277 + @", " + _278 + @", " + _257 + @")
58@ = Object.Create(#AD_JUMP, " + _277 + @", " + _278 + @", " + _257 + @")
59@ = Object.Create(#AD_JUMP, " + _277 + @", " + _278 + @", " + _257 + @")
0376: 55@ = create_random_actor_at 0.0 0.0 100.0 
0376: 56@ = create_random_actor_at 0.0 0.0 100.0 

:DSKOOL_291
0169: set_fade_color_RGB 0 0 0 
00BE: text_clear_all 
0A0E: disable_text_with_style 1 
wait 0 
fade 0 500 

:DSKOOL_316
if 
fading 
else_jump @DSKOOL_340 
wait 0 
jump @DSKOOL_316 

:DSKOOL_340
34@ = 0 
39@ = 0 
43@ = 0 
44@ = 0 
54@ = 0 
45@ = 0 
46@ = 0 
47@ = 0 
48@ = 0 
" + _247 + @" = 1 
50@ = 1 
" + _307 + @" = -2050.6 
" + _308 + @" = -130.0 
" + _327 + @" = -2031.2 
" + _328 + @" = -118.0 
" + _329 + @" = 1034.2 
61@ = 0 
62@ = 0 
63@ = 0 
64@ = 0 
86@ = 0 
87@ = 0 
88@ = 0 
89@ = 0 
90@ = 0 
60@ = 0 
07E5: copy_decision_maker 65542 to 49@ 
Model.Load(#INFERNUS)
Model.Load(#BLISTAC)
Model.Load(#BANSHEE)
Model.Load(#COPCARSF)
Model.Load(#SFPD1)
Model.Load(#TRAFFICCONE)
Model.Load(#TEMP_STINGER2)
Model.Load(#GARYS_LUV_RAMP)
Model.Load(#AD_JUMP)
Model.Load(#AD_ROADMARK1)
Model.Load(#AD_ROADMARK2)
Model.Load(#AD_FINISH)
Model.Load(#TAXI)
Model.Load(#SUPERGT)
0390: load_txd_dictionary 'LD_DRV' 
038F: load_texture ""BRONZE"" as 1 
038F: load_texture ""SILVER"" as 2 
038F: load_texture ""GOLD"" as 3 
038F: load_texture ""RIBB"" as 4 
038F: load_texture ""TVCORN"" as 5 
038F: load_texture ""NAWARD"" as 6 
038F: load_texture ""RIBBW"" as 7 
038F: load_texture ""BLKDOT"" as 8 
038F: load_texture ""TVBASE"" as 9 
038F: load_texture ""NAWTXT"" as 10 
038B: load_requested_models 
Camera.SetAtPos(-2031.1, -118.2, 1034.2)
03D6: remove_styled_text 'FAR_1'  
09D2: set_cops_chase_criminals 0 
01E8: create_forbidden_for_cars_cube_cornerA -2015.37 -76.08 10.0 cornerB -2078.3 -66.75 50.0 
Player.ClearWantedLevel(" + PlayerChar + @")" );
                if( OriginalSetup.OriginalScriptAccess[ 9 ].state ) {
                    AppendLine( @"Garage.Deactivate('BODLAWN')
Garage.Deactivate('MODLAST')
Garage.Deactivate('MDSSFSE')
if 
  " + _1499 + @" == 1 
else_jump @DSKOOL_887 
Garage.Deactivate('MDS1SFS')
Garage.Deactivate('VECMOD')" );
                }
                AppendLine( @"
:DSKOOL_887
0A14: disable_respray_garages 1 
if 
  " + _5187 + @" == 0 
else_jump @DSKOOL_1425 

:DSKOOL_909
if 
  " + _5187 + @" == 0 
else_jump @DSKOOL_1425 
wait 0 
if 
  39@ == 0 
else_jump @DSKOOL_1228 
" + _53 + @" = 1 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1 
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 1 
Actor.PutAt(" + PlayerActor + @", -2031.7, -116.4, 1034.2)
Actor.Angle(" + PlayerActor + @") = 86.9
Model.Load(#WMYMECH)
038B: load_requested_models 
0395: clear_area 1 at -2033.2 -116.5 1034.2 radius 30.0 
91@ = Actor.Create(Mission1, #WMYMECH, -2033.2, -116.5, 1034.2)
0A09: set_actor 91@ muted 1 
060B: set_actor 91@ decision_maker_to 49@ 
Actor.Angle(91@) = 270.0
0568: set_actor 91@ untargetable 1 
0961: set_actor 91@ keep_tasks_after_cleanup 1 
05BA: AS_actor 91@ move_mouth -2 ms 
Camera.SetPosition(-2030.7, -115.8, 1035.8, 0.0, 0.0, 0.0)
Camera.PointAt(-2033.9, -116.1, 1035.7, 2)
61@ = 1 
62@ = 0 
gosub @DSKOOL_46061 
if 
   not Actor.Dead(91@)
else_jump @DSKOOL_1200 
0967: actor 91@ move_mouth 20000 ms 

:DSKOOL_1200
fade 1 1000 
0707: start_scene_skip_to @DSKOOL_1264 
32@ = 0 
39@ = 1 

:DSKOOL_1228
if 
  39@ == 1 
else_jump @DSKOOL_1411 
if 
  61@ == 0 
else_jump @DSKOOL_1411 

:DSKOOL_1264
0701: end_scene_skip 
if 
   not Actor.Dead(91@)
else_jump @DSKOOL_1287 
0968: actor 91@ stop_mouth 

:DSKOOL_1287
00BE: text_clear_all 
040D: unload_wav 1 
040D: unload_wav 2 
61@ = 0 
fade 0 500 

:DSKOOL_1311
if 
fading 
else_jump @DSKOOL_1335 
wait 0 
jump @DSKOOL_1311 

:DSKOOL_1335
00BE: text_clear_all 
06AB: set_actor " + PlayerActor + @" all_weapons_hidden 0 
02A3: enable_widescreen 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
39@ = 0 
" + _5187 + @" = 1 
fade 1 500 

:DSKOOL_1380
if 
fading 
else_jump @DSKOOL_1404 
wait 0 
jump @DSKOOL_1380 

:DSKOOL_1404
jump @DSKOOL_24457 

:DSKOOL_1411
gosub @DSKOOL_45966 
jump @DSKOOL_909 

:DSKOOL_1425
Player.CanMove(" + PlayerChar + @") = False
03E6: remove_text_box 
00BE: text_clear_all 
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
gosub @DSKOOL_30297 
34@ = 0 
39@ = 0 
03F0: enable_text_draw 1 
44@ = 255 
43@ = 2 
if 
  17 > " + _53 + @" 
else_jump @DSKOOL_1516 
008A: " + _247 + @" = 50@ 

:DSKOOL_1516
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_1541 
" + _247 + @" = 4 

:DSKOOL_1541
if 
  " + _247 + @" == 6 
else_jump @DSKOOL_1566 
" + _247 + @" = 7 

:DSKOOL_1566
if 
  " + _247 + @" == 8 
else_jump @DSKOOL_1591 
" + _247 + @" = 9 

:DSKOOL_1591
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_1616 
" + _247 + @" = 13 

:DSKOOL_1616
select_interior 0 
0860: link_actor " + PlayerActor + @" to_interior 0 
Actor.PutAt(" + PlayerActor + @", -2035.4, -119.1, 33.2)
Camera.SetAtPos(-2035.4, -119.1, 33.2)
03CF: load_wav 3800 as 3 

:DSKOOL_1671
if 
83D0:   not wav 3 loaded 
else_jump @DSKOOL_1697 
wait 0 
jump @DSKOOL_1671 

:DSKOOL_1697
03D1: play_wav 3 
04FA: reset_sky_colors_with_fade 0 
0826: enable_hud 0 
0581: enable_radar 0 
fade 1 500 
gosub @DSKOOL_25622 

:DSKOOL_1727
if 
fading 
else_jump @DSKOOL_1758 
wait 0 
gosub @DSKOOL_25622 
jump @DSKOOL_1727 

:DSKOOL_1758
gosub @DSKOOL_25622 

:DSKOOL_1765
wait 0 
if 
0735:   is_keyboard_key_pressed 83 
else_jump @DSKOOL_1791 
jump @DSKOOL_24495 

:DSKOOL_1791
gosub @DSKOOL_25622 
if 
  39@ == 0 
else_jump @DSKOOL_2755 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @DSKOOL_2113 
50@ -= 1 
" + _247 + @" -= 1 
if 
  50@ == 3 
else_jump @DSKOOL_1895 
50@ = 2 

:DSKOOL_1895
if 
  50@ == 6 
else_jump @DSKOOL_1920 
50@ = 5 

:DSKOOL_1920
if 
  50@ == 8 
else_jump @DSKOOL_1945 
50@ = 7 

:DSKOOL_1945
if 
  50@ == 12 
else_jump @DSKOOL_1970 
50@ = 11 

:DSKOOL_1970
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_1995 
" + _247 + @" = 2 

:DSKOOL_1995
if 
  " + _247 + @" == 6 
else_jump @DSKOOL_2020 
" + _247 + @" = 5 

:DSKOOL_2020
if 
  " + _247 + @" == 8 
else_jump @DSKOOL_2045 
" + _247 + @" = 7 

:DSKOOL_2045
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_2070 
" + _247 + @" = 11 

:DSKOOL_2070
if 
  " + _53 + @" > 1 
else_jump @DSKOOL_2113 
if 
  4 > 34@ 
else_jump @DSKOOL_2113 
34@ = 3 

:DSKOOL_2113
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @DSKOOL_2394 
50@ += 1 
" + _247 + @" += 1 
if 
  50@ == 3 
else_jump @DSKOOL_2176 
50@ = 4 

:DSKOOL_2176
if 
  50@ == 6 
else_jump @DSKOOL_2201 
50@ = 7 

:DSKOOL_2201
if 
  50@ == 8 
else_jump @DSKOOL_2226 
50@ = 9 

:DSKOOL_2226
if 
  50@ == 12 
else_jump @DSKOOL_2251 
50@ = 13 

:DSKOOL_2251
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_2276 
" + _247 + @" = 4 

:DSKOOL_2276
if 
  " + _247 + @" == 6 
else_jump @DSKOOL_2301 
" + _247 + @" = 7 

:DSKOOL_2301
if 
  " + _247 + @" == 8 
else_jump @DSKOOL_2326 
" + _247 + @" = 9 

:DSKOOL_2326
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_2351 
" + _247 + @" = 13 

:DSKOOL_2351
if 
  " + _53 + @" > 1 
else_jump @DSKOOL_2394 
if 
  4 > 34@ 
else_jump @DSKOOL_2394 
34@ = 3 

:DSKOOL_2394
if 
  1 > " + _247 + @" 
else_jump @DSKOOL_2428 
0084: " + _247 + @" = " + _53 + @" 
008B: 50@ = " + _53 + @" 

:DSKOOL_2428
if 
001C:   " + _247 + @" > " + _53 + @" 
else_jump @DSKOOL_2461 
" + _247 + @" = 1 
50@ = 1 

:DSKOOL_2461
if 
  " + _53 + @" > 1 
else_jump @DSKOOL_2583 

:DSKOOL_2479
if 
  -100 > " + Move_Axis_X + @" 
else_jump @DSKOOL_2531 
wait 0 
gosub @DSKOOL_25622 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @DSKOOL_2479 

:DSKOOL_2531
if 
  " + Move_Axis_X + @" > 100 
else_jump @DSKOOL_2583 
wait 0 
gosub @DSKOOL_25622 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @DSKOOL_2531 

:DSKOOL_2583
if 
00E1:   player 0 pressed_key 10 
else_jump @DSKOOL_2618 
wait 0 
gosub @DSKOOL_25622 
jump @DSKOOL_2583 

:DSKOOL_2618
if 
00E1:   player 0 pressed_key 11 
else_jump @DSKOOL_2653 
wait 0 
gosub @DSKOOL_25622 
jump @DSKOOL_2618 

:DSKOOL_2653
if 
00E1:   player 0 pressed_key 16 
else_jump @DSKOOL_2755 
if or
  " + _247 + @" == 4 
  " + _247 + @" == 7 
  " + _247 + @" == 9 
  " + _247 + @" == 13 
else_jump @DSKOOL_2723 
39@ = 1 
jump @DSKOOL_2755 

:DSKOOL_2723
if 
  4 > 34@ 
else_jump @DSKOOL_2748 
34@ = 3 

:DSKOOL_2748
jump @DSKOOL_3661 

:DSKOOL_2755
if 
  39@ == 1 
else_jump @DSKOOL_3135 
if 
  4 > 34@ 
else_jump @DSKOOL_2798 
34@ = 3 

:DSKOOL_2798
if 
  34@ == 0 
else_jump @DSKOOL_2823 
34@ = 5 

:DSKOOL_2823
gosub @DSKOOL_30068 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 320.0 160.0 GXT 'DS1_59'  
gosub @DSKOOL_30068 
0342: set_text_draw_centered 0 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 100.0 205.0 GXT 'DS1_60'  
gosub @DSKOOL_30068 
0342: set_text_draw_centered 0 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 101.0 231.0 GXT 'DS1_61'  
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @DSKOOL_3004 
jump @DSKOOL_3661 

:DSKOOL_3004
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @DSKOOL_3135 
if 
  " + _247 + @" == 4 
else_jump @DSKOOL_3053 
" + _247 + @" = 3 

:DSKOOL_3053
if 
  " + _247 + @" == 7 
else_jump @DSKOOL_3078 
" + _247 + @" = 6 

:DSKOOL_3078
if 
  " + _247 + @" == 9 
else_jump @DSKOOL_3103 
" + _247 + @" = 8 

:DSKOOL_3103
if 
  " + _247 + @" == 13 
else_jump @DSKOOL_3128 
" + _247 + @" = 12 

:DSKOOL_3128
jump @DSKOOL_3661 

:DSKOOL_3135
if 
0735:   is_keyboard_key_pressed 81 
else_jump @DSKOOL_3280 
if 
  " + Mission_Back_to_School_Passed + @" == 0 
else_jump @DSKOOL_3273 
" + _107 + @" = 100 
" + _105 + @" = 100 
" + _98 + @" = 100 
" + _96 + @" = 100 
" + _94 + @" = 100 
" + _103 + @" = 100 
" + _91 + @" = 100 
" + _101 + @" = 100 
" + _92 + @" = 100 
" + _102 + @" = 100 
" + _100 + @" = 100 
" + _97 + @" = 100 
" + Mission_Back_to_School_Passed + @" = 1 

:DSKOOL_3273
" + _53 + @" = 16 

:DSKOOL_3280
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_3647 
gosub @DSKOOL_25622 
fade 0 500 

:DSKOOL_3311
if 
fading 
else_jump @DSKOOL_3349 
gosub @DSKOOL_25622 
wait 0 
gosub @DSKOOL_25622 
jump @DSKOOL_3311 

:DSKOOL_3349
gosub @DSKOOL_25622 
040D: unload_wav 3 
00BE: text_clear_all 
04FA: reset_sky_colors_with_fade 1 
0860: link_actor " + PlayerActor + @" to_interior 3 
select_interior 3 
04E4: refresh_game_renderer_at -2031.1 -118.2 
Camera.SetAtPos(-2031.1, -118.2, 1034.2)
Actor.PutAt(" + PlayerActor + @", -2029.7, -115.5, 1034.2)
Actor.Angle(" + PlayerActor + @") = 0.0
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_3473 
if 
060E:   car " + _198 + @" assigned_to_path 
else_jump @DSKOOL_3473 
05EC: release_car " + _198 + @" from_path 

:DSKOOL_3473
Car.Destroy(" + _198 + @")
0395: clear_area 1 at -2051.0 -174.0 34.0 radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
Actor.DestroyInstantly(55@)
Actor.DestroyInstantly(56@)
Car.Destroy(" + _196 + @")
Car.Destroy(" + _197 + @")
Object.Destroy(57@)
Object.Destroy(58@)
Object.Destroy(59@)
0873: release_path 1 
0873: release_path 2 
0873: release_path 3 
0873: release_path 4 
0873: release_path 5 
0873: release_path 7 
0873: release_path 9 
0873: release_path 10 
0873: release_path 11 
0873: release_path 13 
0873: release_path 14 
0873: release_path 15 
0873: release_path 16 
gosub @DSKOOL_35404 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
fade 1 500 

:DSKOOL_3616
if 
fading 
else_jump @DSKOOL_3640 
wait 0 
jump @DSKOOL_3616 

:DSKOOL_3640
jump @DSKOOL_24457 

:DSKOOL_3647
gosub @DSKOOL_29049 
jump @DSKOOL_1765 

:DSKOOL_3661
fade 0 500 

:DSKOOL_3668
if 
fading 
else_jump @DSKOOL_3699 
wait 0 
gosub @DSKOOL_25622 
jump @DSKOOL_3668 

:DSKOOL_3699
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_3720 
05EC: release_car " + _198 + @" from_path 

:DSKOOL_3720
040D: unload_wav 3 
Car.Destroy(" + _198 + @")
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
Actor.DestroyInstantly(55@)
Actor.DestroyInstantly(56@)
Car.Destroy(" + _196 + @")
Car.Destroy(" + _197 + @")
Car.Destroy(" + _198 + @")
Object.Destroy(57@)
Object.Destroy(58@)
Object.Destroy(59@)
gosub @DSKOOL_35404 
34@ = 5 
0826: enable_hud 1 
0581: enable_radar 1 
if 
  " + _247 + @" == 1 
else_jump @DSKOOL_5391 

:DSKOOL_3836
gosub @DSKOOL_30188 

:DSKOOL_3843
" + _258 + @" = 180.0 
" + _253 + @" = 11000 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#INFERNUS, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = 180.0
gosub @DSKOOL_35458 
if 
  34@ == 0 
else_jump @DSKOOL_3997 
Camera.SetPosition(-2028.3, -143.0, 38.4, 0.0, 0.0, 0.0)
Camera.PointAt(-2052.3, -129.9, 34.2, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_3995 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_3995
return 

:DSKOOL_3997
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 0.0 0.0 0.0 
00BE: text_clear_all 
00BA: show_text_styled GXT 'DS1_88' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_44' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_4067
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_4102 
" + _325 + @" = 2 
jump @DSKOOL_5329 

:DSKOOL_4102
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_4134 
jump @DSKOOL_24457 

:DSKOOL_4134
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_4216 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_4202 
00BA: show_text_styled GXT 'DS1_88' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_44' time 5000 flag 4  

:DSKOOL_4202
gosub @DSKOOL_31183 
jump @DSKOOL_5384 

:DSKOOL_4216
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_5384 
gosub @DSKOOL_31503 
" + _258 + @" = Car.Angle(" + _198 + @")
if 
  " + _274 + @" == 0 
else_jump @DSKOOL_4321 
if 
  " + _258 + @" > 80.0 
else_jump @DSKOOL_4321 
if 
  90.0 > " + _258 + @" 
else_jump @DSKOOL_4321 
" + _274 + @" = 1 
40@ = 1 

:DSKOOL_4321
if 
  40@ == 1 
else_jump @DSKOOL_4540 
if 
  " + _274 + @" == 1 
else_jump @DSKOOL_4406 
if 
  " + _258 + @" > 350.0 
else_jump @DSKOOL_4406 
if 
  360.0 > " + _258 + @" 
else_jump @DSKOOL_4406 
" + _274 + @" = 2 

:DSKOOL_4406
if 
  " + _274 + @" == 2 
else_jump @DSKOOL_4473 
if 
  " + _258 + @" > 270.0 
else_jump @DSKOOL_4473 
if 
  280.0 > " + _258 + @" 
else_jump @DSKOOL_4473 
" + _274 + @" = 3 

:DSKOOL_4473
if 
  " + _274 + @" == 3 
else_jump @DSKOOL_4540 
if 
  " + _258 + @" > 170.0 
else_jump @DSKOOL_4540 
if 
  180.0 > " + _258 + @" 
else_jump @DSKOOL_4540 
" + _274 + @" = 4 

:DSKOOL_4540
if 
  " + _274 + @" == 0 
else_jump @DSKOOL_4614 
if 
  " + _258 + @" > 270.0 
else_jump @DSKOOL_4614 
if 
  280.0 > " + _258 + @" 
else_jump @DSKOOL_4614 
40@ = 2 
" + _274 + @" = 1 

:DSKOOL_4614
if 
  40@ == 2 
else_jump @DSKOOL_4833 
if 
  " + _274 + @" == 1 
else_jump @DSKOOL_4699 
if 
  " + _258 + @" > 350.0 
else_jump @DSKOOL_4699 
if 
  360.0 > " + _258 + @" 
else_jump @DSKOOL_4699 
" + _274 + @" = 2 

:DSKOOL_4699
if 
  " + _274 + @" == 2 
else_jump @DSKOOL_4766 
if 
  " + _258 + @" > 80.0 
else_jump @DSKOOL_4766 
if 
  90.0 > " + _258 + @" 
else_jump @DSKOOL_4766 
" + _274 + @" = 3 

:DSKOOL_4766
if 
  " + _274 + @" == 3 
else_jump @DSKOOL_4833 
if 
  " + _258 + @" > 170.0 
else_jump @DSKOOL_4833 
if 
  180.0 > " + _258 + @" 
else_jump @DSKOOL_4833 
" + _274 + @" = 4 

:DSKOOL_4833
if or
80E1:   not player 0 pressed_key 16 
80E1:   not player 0 pressed_key 14 
  " + _253 + @" == 0 
else_jump @DSKOOL_5384 
gosub @DSKOOL_31537 
gosub @DSKOOL_31577 
if 
  " + _274 + @" == 4 
else_jump @DSKOOL_4902 
" + _266 + @" = 100 

:DSKOOL_4902
if 
  " + _274 + @" == 3 
else_jump @DSKOOL_4927 
" + _266 + @" = 75 

:DSKOOL_4927
if 
  " + _274 + @" == 2 
else_jump @DSKOOL_4952 
" + _266 + @" = 50 

:DSKOOL_4952
if 
  " + _274 + @" == 1 
else_jump @DSKOOL_4977 
" + _266 + @" = 25 

:DSKOOL_4977
if 
  " + _274 + @" == 0 
else_jump @DSKOOL_5002 
" + _266 + @" = 0 

:DSKOOL_5002
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_5050 
" + Current_Flight_Record + @" = 0 

:DSKOOL_5050
if 
  " + _274 + @" == 0 
else_jump @DSKOOL_5075 
" + Current_Flight_Record + @" = 0 

:DSKOOL_5075
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _107 + @" 
else_jump @DSKOOL_5145 
008B: 47@ = " + _107 + @" 
0084: " + _107 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_5152 

:DSKOOL_5145
45@ = 0 

:DSKOOL_5152
if 
  " + _53 + @" == 1 
else_jump @DSKOOL_5216 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_5216 
41@ = 2 
" + _53 + @" = 2 
" + _325 + @" = 2 
50@ = 2 

:DSKOOL_5216
32@ = 0 

:DSKOOL_5223
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_5283 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_5283 
" + _325 + @" = 2 
jump @DSKOOL_5329 

:DSKOOL_5283
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_5322 
jump @DSKOOL_5329 

:DSKOOL_5322
jump @DSKOOL_5223 

:DSKOOL_5329
gosub @DSKOOL_35120 
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_5377 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_5384 

:DSKOOL_5377
jump @DSKOOL_3836 

:DSKOOL_5384
jump @DSKOOL_4067 

:DSKOOL_5391
if 
  " + _247 + @" == 2 
else_jump @DSKOOL_6710 

:DSKOOL_5409
gosub @DSKOOL_30188 

:DSKOOL_5416
" + _258 + @" = 0.0 
" + _253 + @" = 11000 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#BLISTAC, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = 180.0
gosub @DSKOOL_35458 
if 
  34@ == 0 
else_jump @DSKOOL_5570 
Camera.SetPosition(-2060.2, -227.3, 36.6, 0.0, 0.0, 0.0)
Camera.PointAt(-2049.5, -210.6, 34.0, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_5568 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_5568
return 

:DSKOOL_5570
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -2.0 82.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 2.0 88.0 0.0 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 0.0 0.0 0.0 
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_45' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_5698
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_5733 
" + _325 + @" = 2 
jump @DSKOOL_6648 

:DSKOOL_5733
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_5765 
jump @DSKOOL_24457 

:DSKOOL_5765
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_5847 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_5833 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_45' time 5000 flag 4  

:DSKOOL_5833
gosub @DSKOOL_31183 
jump @DSKOOL_6703 

:DSKOOL_5847
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_6703 
gosub @DSKOOL_31503 
if 
  " + _274 + @" == 0 
else_jump @DSKOOL_5925 
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @DSKOOL_5925 
" + _274 + @" = 1 

:DSKOOL_5925
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_6703 
gosub @DSKOOL_31537 
gosub @DSKOOL_31577 
if 
  " + _274 + @" == 0 
else_jump @DSKOOL_5980 
" + _267 + @" = 0 

:DSKOOL_5980
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_6028 
" + _266 + @" = 100 
jump @DSKOOL_6321 

:DSKOOL_6028
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_6061 
" + _266 + @" = 100 
jump @DSKOOL_6321 

:DSKOOL_6061
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_6104 
if 
  21 > " + _252 + @" 
else_jump @DSKOOL_6104 
" + _266 + @" = 100 

:DSKOOL_6104
if 
  " + _252 + @" > 179 
else_jump @DSKOOL_6191 
if 
  340 > " + _252 + @" 
else_jump @DSKOOL_6191 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.62 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_6321 

:DSKOOL_6191
if 
  " + _252 + @" > 339 
else_jump @DSKOOL_6236 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_6236 
" + _266 + @" = 100 

:DSKOOL_6236
if 
  " + _252 + @" > 20 
else_jump @DSKOOL_6321 
if 
  180 > " + _252 + @" 
else_jump @DSKOOL_6321 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.62 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_6321 

:DSKOOL_6321
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_6346 
" + _266 + @" = 0 

:DSKOOL_6346
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_6394 
" + Current_Flight_Record + @" = 0 

:DSKOOL_6394
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _105 + @" 
else_jump @DSKOOL_6464 
008B: 47@ = " + _105 + @" 
0084: " + _105 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_6471 

:DSKOOL_6464
45@ = 0 

:DSKOOL_6471
if 
  " + _53 + @" == 2 
else_jump @DSKOOL_6535 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_6535 
41@ = 2 
" + _53 + @" = 4 
" + _325 + @" = 2 
50@ = 4 

:DSKOOL_6535
32@ = 0 

:DSKOOL_6542
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_6602 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_6602 
" + _325 + @" = 2 
jump @DSKOOL_6648 

:DSKOOL_6602
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_6641 
jump @DSKOOL_6648 

:DSKOOL_6641
jump @DSKOOL_6542 

:DSKOOL_6648
gosub @DSKOOL_35120 
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_6696 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_6703 

:DSKOOL_6696
jump @DSKOOL_5409 

:DSKOOL_6703
jump @DSKOOL_5698 

:DSKOOL_6710
if or
  " + _247 + @" == 3 
  " + _247 + @" == 4 
else_jump @DSKOOL_8322 

:DSKOOL_6735
gosub @DSKOOL_30188 

:DSKOOL_6742
" + _258 + @" = 180.0 
" + _253 + @" = 6000 
gosub @DSKOOL_30297 
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_6795 
" + _255 + @" += 20.0 

:DSKOOL_6795
if 
  " + _247 + @" == 4 
else_jump @DSKOOL_6823 
" + _255 + @" -= 20.0 

:DSKOOL_6823
" + _198 + @" = Car.Create(#BANSHEE, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
gosub @DSKOOL_35458 
if 
  34@ == 0 
else_jump @DSKOOL_6950 
Camera.SetPosition(-2022.6, -173.4, 36.2, 0.0, 0.0, 0.0)
Camera.PointAt(-2034.2, -165.4, 34.5, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_6948 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_6948
return 

:DSKOOL_6950
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_7004 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 40.0 37.0 0.0 
jump @DSKOOL_7033 

:DSKOOL_7004
0407: store_coords_to " + _303 + @" " + _304 + @" " + _257 + @" from_car " + _198 + @" with_offset -40.0 37.0 0.0 

:DSKOOL_7033
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_32' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_7074
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_7109 
" + _325 + @" = 2 
jump @DSKOOL_8260 

:DSKOOL_7109
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_7141 
jump @DSKOOL_24457 

:DSKOOL_7141
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_7223 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_7209 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_32' time 5000 flag 4  

:DSKOOL_7209
gosub @DSKOOL_31183 
jump @DSKOOL_8315 

:DSKOOL_7223
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_8315 
gosub @DSKOOL_31503 
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_8315 
gosub @DSKOOL_31537 
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_7310 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
jump @DSKOOL_7326 

:DSKOOL_7310
0086: " + _255 + @" = " + _303 + @" 
0086: " + _256 + @" = " + _304 + @" 

:DSKOOL_7326
gosub @DSKOOL_31577 
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_7381 
" + _266 + @" = 0 
jump @DSKOOL_7933 

:DSKOOL_7381
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_7414 
" + _266 + @" = 0 
jump @DSKOOL_7933 

:DSKOOL_7414
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_7683 
if 
  " + _252 + @" == 90 
else_jump @DSKOOL_7464 
" + _266 + @" = 100 
jump @DSKOOL_7933 

:DSKOOL_7464
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_7533 
if 
  85 > " + _252 + @" 
else_jump @DSKOOL_7533 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_7933 

:DSKOOL_7533
if 
  " + _252 + @" > 84 
else_jump @DSKOOL_7576 
if 
  96 > " + _252 + @" 
else_jump @DSKOOL_7576 
" + _266 + @" = 100 

:DSKOOL_7576
if 
  " + _252 + @" > 95 
else_jump @DSKOOL_7676 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_7676 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 90 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_7933 

:DSKOOL_7676
jump @DSKOOL_7933 

:DSKOOL_7683
if 
  " + _252 + @" == 270 
else_jump @DSKOOL_7716 
" + _266 + @" = 100 
jump @DSKOOL_7933 

:DSKOOL_7716
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_7786 
if 
  265 > " + _252 + @" 
else_jump @DSKOOL_7786 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.37 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_7933 

:DSKOOL_7786
if 
  " + _252 + @" > 264 
else_jump @DSKOOL_7831 
if 
  276 > " + _252 + @" 
else_jump @DSKOOL_7831 
" + _266 + @" = 100 

:DSKOOL_7831
if 
  " + _252 + @" > 275 
else_jump @DSKOOL_7933 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_7933 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 270 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_7933 

:DSKOOL_7933
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_7958 
" + _266 + @" = 0 

:DSKOOL_7958
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_8006 
" + Current_Flight_Record + @" = 0 

:DSKOOL_8006
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _98 + @" 
else_jump @DSKOOL_8076 
008B: 47@ = " + _98 + @" 
0084: " + _98 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_8083 

:DSKOOL_8076
45@ = 0 

:DSKOOL_8083
if 
  " + _53 + @" == 4 
else_jump @DSKOOL_8147 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_8147 
41@ = 2 
" + _53 + @" = 5 
" + _325 + @" = 2 
50@ = 5 

:DSKOOL_8147
32@ = 0 

:DSKOOL_8154
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_8214 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_8214 
" + _325 + @" = 2 
jump @DSKOOL_8260 

:DSKOOL_8214
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_8253 
jump @DSKOOL_8260 

:DSKOOL_8253
jump @DSKOOL_8154 

:DSKOOL_8260
gosub @DSKOOL_35120 
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_8308 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_8315 

:DSKOOL_8308
jump @DSKOOL_6735 

:DSKOOL_8315
jump @DSKOOL_7074 

:DSKOOL_8322
if 
  " + _247 + @" == 5 
else_jump @DSKOOL_9825 

:DSKOOL_8340
gosub @DSKOOL_30188 

:DSKOOL_8347
" + _258 + @" = 180.0 
" + _253 + @" = 6000 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#COPCARSF, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
0407: store_coords_to " + _255 + @" " + _256 + @" " + _257 + @" from_car " + _198 + @" with_offset 2.0 38.0 -0.5 
0407: store_coords_to " + _277 + @" " + _278 + @" " + _257 + @" from_car " + _198 + @" with_offset -2.0 40.0 -0.5 
59@ = Object.Create(#TEMP_STINGER2, -2050.8, -167.0, 34.6)
Object.Angle(59@) = 90.0
gosub @DSKOOL_35458 
if 
  34@ == 0 
else_jump @DSKOOL_8595 
Camera.SetPosition(-2047.7, -243.3, 37.0, 0.0, 0.0, 0.0)
Camera.PointAt(-2049.7, -227.4, 34.1, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_8593 
55@ = Actor.CreateAsDriver(Mission2, #SFPD1, " + _198 + @")

:DSKOOL_8593
return 

:DSKOOL_8595
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 0.0 104.0 0.0 
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_30' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_8665
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_8700 
" + _325 + @" = 2 
jump @DSKOOL_9758 

:DSKOOL_8700
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_8732 
jump @DSKOOL_24457 

:DSKOOL_8732
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_8814 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_8800 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_30' time 5000 flag 4  

:DSKOOL_8800
gosub @DSKOOL_31183 
jump @DSKOOL_9818 

:DSKOOL_8814
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_9818 
gosub @DSKOOL_31503 
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _255 + @" " + _256 + @" cornerB " + _277 + @" " + _278 + @" 
else_jump @DSKOOL_8892 
if 
8496:   not tire 3 on_car " + _198 + @" deflated 
else_jump @DSKOOL_8892 
04FE: deflate_tire 3 on_car " + _198 + @" 

:DSKOOL_8892
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_9818 
gosub @DSKOOL_31537 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
Car.StorePos(" + _198 + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: " + _259 + @" = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY " + _255 + @" " + _256 + @" 
if 
  " + _259 + @" > 1.0 
else_jump @DSKOOL_9068 
if 
  10.0 > " + _259 + @" 
else_jump @DSKOOL_9054 
" + _259 + @" -= 1.0 
" + _259 + @" *= 11.0 
008C: " + _273 + @" = float " + _259 + @" to_integer 
" + _267 + @" = 100 
0060: " + _267 + @" -= " + _273 + @" 
jump @DSKOOL_9061 

:DSKOOL_9054
" + _267 + @" = 0 

:DSKOOL_9061
jump @DSKOOL_9075 

:DSKOOL_9068
" + _267 + @" = 100 

:DSKOOL_9075
if 
8496:   not tire 3 on_car " + _198 + @" deflated 
else_jump @DSKOOL_9100 
" + _267 + @" = 0 

:DSKOOL_9100
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_9148 
" + _266 + @" = 0 
jump @DSKOOL_9431 

:DSKOOL_9148
if 
  " + _252 + @" == 180 
else_jump @DSKOOL_9181 
" + _266 + @" = 100 
jump @DSKOOL_9431 

:DSKOOL_9181
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_9214 
" + _266 + @" = 0 
jump @DSKOOL_9431 

:DSKOOL_9214
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_9284 
if 
  175 > " + _252 + @" 
else_jump @DSKOOL_9284 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_9431 

:DSKOOL_9284
if 
  " + _252 + @" > 174 
else_jump @DSKOOL_9329 
if 
  186 > " + _252 + @" 
else_jump @DSKOOL_9329 
" + _266 + @" = 100 

:DSKOOL_9329
if 
  " + _252 + @" > 185 
else_jump @DSKOOL_9431 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_9431 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_9431 

:DSKOOL_9431
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_9456 
" + _266 + @" = 0 

:DSKOOL_9456
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_9504 
" + Current_Flight_Record + @" = 0 

:DSKOOL_9504
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _96 + @" 
else_jump @DSKOOL_9574 
008B: 47@ = " + _96 + @" 
0084: " + _96 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_9581 

:DSKOOL_9574
45@ = 0 

:DSKOOL_9581
if 
  " + _53 + @" == 5 
else_jump @DSKOOL_9645 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_9645 
41@ = 2 
" + _53 + @" = 7 
" + _325 + @" = 2 
50@ = 7 

:DSKOOL_9645
32@ = 0 

:DSKOOL_9652
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_9712 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_9712 
" + _325 + @" = 2 
jump @DSKOOL_9758 

:DSKOOL_9712
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_9751 
jump @DSKOOL_9758 

:DSKOOL_9751
jump @DSKOOL_9652 

:DSKOOL_9758
gosub @DSKOOL_35120 
Object.Destroy(59@)
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_9811 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_9818 

:DSKOOL_9811
jump @DSKOOL_8340 

:DSKOOL_9818
jump @DSKOOL_8665 

:DSKOOL_9825
if or
  " + _247 + @" == 6 
  " + _247 + @" == 7 
else_jump @DSKOOL_11927 

:DSKOOL_9850
gosub @DSKOOL_30188 

:DSKOOL_9857
" + _258 + @" = 180.0 
" + _253 + @" = 0 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#BANSHEE, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
gosub @DSKOOL_35458 
if 
  " + _247 + @" == 6 
else_jump @DSKOOL_10186 
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -4.0 50.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 44.0 0.0 
0407: store_coords_to " + _313 + @" " + _314 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 12.0 38.0 0.0 
0407: store_coords_to " + _315 + @" " + _316 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 44.0 0.0 
0407: store_coords_to " + _317 + @" " + _318 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 2.0 0.0 
0407: store_coords_to " + _319 + @" " + _320 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 12.0 -4.0 0.0 
0407: store_coords_to " + _321 + @" " + _322 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 2.0 0.0 
0407: store_coords_to " + _323 + @" " + _324 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -4.0 8.0 0.0 
59@ = Object.Create(#AD_FINISH, -2050.5, -135.5, 34.35)

:DSKOOL_10186
if 
  " + _247 + @" == 7 
else_jump @DSKOOL_10510 
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 44.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 12.0 50.0 0.0 
0407: store_coords_to " + _313 + @" " + _314 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 44.0 0.0 
0407: store_coords_to " + _315 + @" " + _316 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -4.0 38.0 0.0 
0407: store_coords_to " + _317 + @" " + _318 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 2.0 0.0 
0407: store_coords_to " + _319 + @" " + _320 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -4.0 -4.0 0.0 
0407: store_coords_to " + _321 + @" " + _322 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 4.0 2.0 0.0 
0407: store_coords_to " + _323 + @" " + _324 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 12.0 8.0 0.0 
0407: store_coords_to " + _277 + @" " + _278 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 8.0 0.0 0.0 
59@ = Object.Create(#AD_FINISH, -2058.5, -135.5, 34.35)
Car.PutAt(" + _198 + @", " + _277 + @", " + _278 + @", " + tempvar_Z_coord + @")
Car.Angle(" + _198 + @") = " + _258 + @"

:DSKOOL_10510
if 
  34@ == 0 
else_jump @DSKOOL_10605 
Camera.SetPosition(-2054.6, -109.1, 36.4, 0.0, 0.0, 0.0)
Camera.PointAt(-2054.6, -122.0, 34.2, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_10603 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_10603
return 

:DSKOOL_10605
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_29' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_10646
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_10681 
" + _325 + @" = 2 
jump @DSKOOL_11860 

:DSKOOL_10681
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_10713 
jump @DSKOOL_24457 

:DSKOOL_10713
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_10795 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_10781 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_29' time 5000 flag 4  

:DSKOOL_10781
gosub @DSKOOL_31183 
jump @DSKOOL_11920 

:DSKOOL_10795
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_11920 
if 
  " + _253 + @" > 90000 
else_jump @DSKOOL_10839 
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_10839
if 
  " + _273 + @" == 0 
else_jump @DSKOOL_10894 
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @DSKOOL_10894 
" + _273 + @" = 1 

:DSKOOL_10894
if 
  " + _273 + @" == 1 
else_jump @DSKOOL_10949 
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _313 + @" " + _314 + @" cornerB " + _315 + @" " + _316 + @" 
else_jump @DSKOOL_10949 
" + _273 + @" = 2 

:DSKOOL_10949
if 
  " + _273 + @" == 2 
else_jump @DSKOOL_11004 
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _317 + @" " + _318 + @" cornerB " + _319 + @" " + _320 + @" 
else_jump @DSKOOL_11004 
" + _273 + @" = 3 

:DSKOOL_11004
if 
  " + _273 + @" == 3 
else_jump @DSKOOL_11066 
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _321 + @" " + _322 + @" cornerB " + _323 + @" " + _324 + @" 
else_jump @DSKOOL_11066 
" + _254 + @" += 1 
" + _273 + @" = 0 

:DSKOOL_11066
00BE: text_clear_all 
if 
  4 > " + _254 + @" 
else_jump @DSKOOL_11127 
0084: " + _275 + @" = " + _254 + @" 
" + _275 + @" += 1 
01E5: show_text_1number_highpriority GXT 'DS1_73' number " + _275 + @" time 5000 flag 4  
jump @DSKOOL_11143 

:DSKOOL_11127
00BC: show_text_highpriority GXT 'DS1_74' time 5000 flag 4  

:DSKOOL_11143
if or
01C1:   car " + _198 + @" stopped 
  " + _254 + @" == 5 
else_jump @DSKOOL_11920 
gosub @DSKOOL_31537 
0084: " + _273 + @" = " + _253 + @" 
0084: " + _301 + @" = " + _273 + @" 
" + _301 + @" /= 1000 
0084: " + _302 + @" = " + _301 + @" 
" + _302 + @" *= 1000 
0084: " + _274 + @" = " + _273 + @" 
0060: " + _274 + @" -= " + _302 + @" 
0084: " + _302 + @" = " + _274 + @" 
" + _302 + @" /= 10 
" + _270 + @" = 0 
if 
  5 > " + _254 + @" 
else_jump @DSKOOL_11283 
" + _270 + @" = 0 
jump @DSKOOL_11541 

:DSKOOL_11283
if 
  36000 > " + _273 + @" 
else_jump @DSKOOL_11311 
" + _270 + @" = 100 

:DSKOOL_11311
if 
  " + _273 + @" >= 36000 
else_jump @DSKOOL_11412 
if 
  40000 > " + _273 + @" 
else_jump @DSKOOL_11412 
0084: " + _274 + @" = " + _273 + @" 
" + _274 + @" -= 35999 
008D: " + _276 + @" = integer " + _274 + @" to_float 
" + _276 + @" *= 0.0075 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _270 + @" = 100 
0060: " + _270 + @" -= " + _273 + @" 

:DSKOOL_11412
if 
  " + _273 + @" >= 40000 
else_jump @DSKOOL_11513 
if 
  45000 > " + _273 + @" 
else_jump @DSKOOL_11513 
0084: " + _274 + @" = " + _273 + @" 
" + _274 + @" -= 39999 
008D: " + _276 + @" = integer " + _274 + @" to_float 
" + _276 + @" *= 0.0138 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _270 + @" = 70 
0060: " + _270 + @" -= " + _273 + @" 

:DSKOOL_11513
if 
  " + _273 + @" >= 45000 
else_jump @DSKOOL_11541 
" + _270 + @" = 0 

:DSKOOL_11541
if 
  1 > " + _270 + @" 
else_jump @DSKOOL_11566 
" + _270 + @" = 0 

:DSKOOL_11566
if 
  " + _270 + @" > 99 
else_jump @DSKOOL_11591 
" + _270 + @" = 100 

:DSKOOL_11591
0084: " + Current_Flight_Record + @" = " + _270 + @" 
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _94 + @" 
else_jump @DSKOOL_11669 
008B: 47@ = " + _94 + @" 
0084: " + _94 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_11676 

:DSKOOL_11669
45@ = 0 

:DSKOOL_11676
if 
  " + _53 + @" == 7 
else_jump @DSKOOL_11740 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_11740 
41@ = 2 
" + _53 + @" = 9 
" + _325 + @" = 2 
50@ = 9 

:DSKOOL_11740
" + _254 + @" = 6 
32@ = 0 

:DSKOOL_11754
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_11814 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_11814 
" + _325 + @" = 2 
jump @DSKOOL_11860 

:DSKOOL_11814
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_11853 
jump @DSKOOL_11860 

:DSKOOL_11853
jump @DSKOOL_11754 

:DSKOOL_11860
gosub @DSKOOL_35120 
Object.Destroy(59@)
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_11913 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_11920 

:DSKOOL_11913
jump @DSKOOL_9850 

:DSKOOL_11920
jump @DSKOOL_10646 

:DSKOOL_11927
if or
  " + _247 + @" == 8 
  " + _247 + @" == 9 
else_jump @DSKOOL_13423 

:DSKOOL_11952
gosub @DSKOOL_30188 

:DSKOOL_11959
Model.Load(#BANSHEE)

:DSKOOL_11964
if 
   not Model.Available(#BANSHEE)
else_jump @DSKOOL_11991 
wait 0 
jump @DSKOOL_11964 

:DSKOOL_11991
" + _258 + @" = 180.0 
" + _253 + @" = 11000 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#BANSHEE, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
59@ = Object.Create(#AD_ROADMARK1, -2050.0, -172.5, 34.35)
Object.Angle(59@) = 180.0
gosub @DSKOOL_35458 
if 
  34@ == 0 
else_jump @DSKOOL_12176 
Camera.SetPosition(-2042.1, -223.4, 36.3, 0.0, 0.0, 0.0)
Camera.PointAt(-2049.1, -210.0, 34.8, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_12174 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_12174
return 

:DSKOOL_12176
0400: store_coords_to " + _282 + @" " + _283 + @" " + _284 + @" from_object " + tmp_201 + @"[15] with_offset 0.0 5.0 0.0 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 0.0 0.0 0.0 
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_36' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_12275
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_12310 
" + _325 + @" = 2 
jump @DSKOOL_13356 

:DSKOOL_12310
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_12342 
jump @DSKOOL_24457 

:DSKOOL_12342
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_12424 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_12410 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_36' time 5000 flag 4  

:DSKOOL_12410
gosub @DSKOOL_31183 
jump @DSKOOL_13416 

:DSKOOL_12424
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_13416 
if 
80B0:   not car " + _198 + @" sphere 0 in_rectangle_cornerA -2042.0 -126.0 cornerB -2058.0 -220.0 
else_jump @DSKOOL_12485 
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_12485
if 
  " + _254 + @" == 0 
else_jump @DSKOOL_12552 
if 
01AF:   car " + _198 + @" sphere 1 in_sphere " + _282 + @" " + _283 + @" " + _284 + @" radius 4.0 4.0 4.0 
else_jump @DSKOOL_12552 
" + _254 + @" = 1 

:DSKOOL_12552
if 
  " + _254 + @" == 1 
else_jump @DSKOOL_12619 
if 
01B0:   car " + _198 + @" sphere 1 in_sphere " + _255 + @" " + _256 + @" " + _257 + @" radius 4.0 4.0 4.0 stopped 
else_jump @DSKOOL_12619 
" + _254 + @" = 2 

:DSKOOL_12619
gosub @DSKOOL_31503 
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_13416 
gosub @DSKOOL_31537 
if 
  " + _254 + @" > 0 
else_jump @DSKOOL_12681 
gosub @DSKOOL_31577 
jump @DSKOOL_12688 

:DSKOOL_12681
" + _267 + @" = 0 

:DSKOOL_12688
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_12736 
" + _266 + @" = 100 
jump @DSKOOL_13029 

:DSKOOL_12736
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_12769 
" + _266 + @" = 100 
jump @DSKOOL_13029 

:DSKOOL_12769
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_12812 
if 
  21 > " + _252 + @" 
else_jump @DSKOOL_12812 
" + _266 + @" = 100 

:DSKOOL_12812
if 
  " + _252 + @" > 179 
else_jump @DSKOOL_12899 
if 
  340 > " + _252 + @" 
else_jump @DSKOOL_12899 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.62 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_13029 

:DSKOOL_12899
if 
  " + _252 + @" > 339 
else_jump @DSKOOL_12944 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_12944 
" + _266 + @" = 100 

:DSKOOL_12944
if 
  " + _252 + @" > 20 
else_jump @DSKOOL_13029 
if 
  180 > " + _252 + @" 
else_jump @DSKOOL_13029 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.62 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_13029 

:DSKOOL_13029
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_13054 
" + _266 + @" = 0 

:DSKOOL_13054
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_13102 
" + Current_Flight_Record + @" = 0 

:DSKOOL_13102
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _103 + @" 
else_jump @DSKOOL_13172 
008B: 47@ = " + _103 + @" 
0084: " + _103 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_13179 

:DSKOOL_13172
45@ = 0 

:DSKOOL_13179
if 
  " + _53 + @" == 9 
else_jump @DSKOOL_13243 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_13243 
41@ = 2 
" + _53 + @" = 10 
" + _325 + @" = 2 
50@ = 10 

:DSKOOL_13243
32@ = 0 

:DSKOOL_13250
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_13310 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_13310 
" + _325 + @" = 2 
jump @DSKOOL_13356 

:DSKOOL_13310
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_13349 
jump @DSKOOL_13356 

:DSKOOL_13349
jump @DSKOOL_13250 

:DSKOOL_13356
gosub @DSKOOL_35120 
Object.Destroy(59@)
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_13409 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_13416 

:DSKOOL_13409
jump @DSKOOL_11952 

:DSKOOL_13416
jump @DSKOOL_12275 

:DSKOOL_13423
if 
  " + _247 + @" == 10 
else_jump @DSKOOL_15321 

:DSKOOL_13441
gosub @DSKOOL_30188 

:DSKOOL_13448
" + _258 + @" = 270.0 
" + _253 + @" = 6000 
gosub @DSKOOL_30297 
0086: " + _277 + @" = " + _255 + @" 
" + _277 + @" += 6.0 
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 75.0 
" + _196 + @" = Car.Create(#BANSHEE, " + _277 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _196 + @") = " + _258 + @"
Car.LockInCurrentPosition(" + _196 + @") = True
0086: " + _277 + @" = " + _255 + @" 
" + _277 + @" -= 6.0 
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 75.0 
" + _197 + @" = Car.Create(#BANSHEE, " + _277 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _197 + @") = " + _258 + @"
Car.LockInCurrentPosition(" + _197 + @") = True
0086: " + _277 + @" = " + _255 + @" 
0086: " + _278 + @" = " + _256 + @" 
" + _198 + @" = Car.Create(#BANSHEE, " + _277 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _198 + @") = 180.0
if 
  34@ == 0 
else_jump @DSKOOL_13747 
Camera.SetPosition(-2045.8, -210.5, 35.3, 0.0, 0.0, 0.0)
Camera.PointAt(-2053.5, -198.1, 34.2, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_13745 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_13745
return 

:DSKOOL_13747
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_1' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_13788
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_13823 
" + _325 + @" = 2 
jump @DSKOOL_15256 

:DSKOOL_13823
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_13855 
jump @DSKOOL_24457 

:DSKOOL_13855
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_13937 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_13923 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_1' time 5000 flag 4  

:DSKOOL_13923
gosub @DSKOOL_31183 
jump @DSKOOL_15314 

:DSKOOL_13937
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_15314 
gosub @DSKOOL_31503 
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_15314 
gosub @DSKOOL_31537 
" + _256 + @" -= 75.0 
Car.StorePos(" + _198 + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: " + _259 + @" = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY " + _255 + @" " + _256 + @" 
if 
  " + _259 + @" > 0.5 
else_jump @DSKOOL_14130 
if 
  5.0 > " + _259 + @" 
else_jump @DSKOOL_14116 
" + _259 + @" -= 0.5 
" + _259 + @" *= 22.0 
008C: " + _273 + @" = float " + _259 + @" to_integer 
" + _267 + @" = 100 
0060: " + _267 + @" -= " + _273 + @" 
jump @DSKOOL_14123 

:DSKOOL_14116
" + _267 + @" = 0 

:DSKOOL_14123
jump @DSKOOL_14137 

:DSKOOL_14130
" + _267 + @" = 100 

:DSKOOL_14137
0058: " + Current_Flight_Record + @" += " + _267 + @" 
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_14193 
" + _266 + @" = 0 
jump @DSKOOL_14737 

:DSKOOL_14193
if 
  " + _252 + @" == 90 
else_jump @DSKOOL_14225 
" + _266 + @" = 100 
jump @DSKOOL_14737 

:DSKOOL_14225
if 
  " + _252 + @" == 180 
else_jump @DSKOOL_14258 
" + _266 + @" = 0 
jump @DSKOOL_14737 

:DSKOOL_14258
if 
  " + _252 + @" == 270 
else_jump @DSKOOL_14291 
" + _266 + @" = 100 
jump @DSKOOL_14737 

:DSKOOL_14291
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_14360 
if 
  85 > " + _252 + @" 
else_jump @DSKOOL_14360 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_14737 

:DSKOOL_14360
if 
  " + _252 + @" > 84 
else_jump @DSKOOL_14403 
if 
  96 > " + _252 + @" 
else_jump @DSKOOL_14403 
" + _266 + @" = 100 

:DSKOOL_14403
if 
  " + _252 + @" > 95 
else_jump @DSKOOL_14503 
if 
  180 > " + _252 + @" 
else_jump @DSKOOL_14503 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 90 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_14737 

:DSKOOL_14503
if 
  " + _252 + @" > 180 
else_jump @DSKOOL_14590 
if 
  265 > " + _252 + @" 
else_jump @DSKOOL_14590 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_14737 

:DSKOOL_14590
if 
  " + _252 + @" > 264 
else_jump @DSKOOL_14635 
if 
  276 > " + _252 + @" 
else_jump @DSKOOL_14635 
" + _266 + @" = 100 

:DSKOOL_14635
if 
  " + _252 + @" > 275 
else_jump @DSKOOL_14737 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_14737 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 270 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 1.16 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_14737 

:DSKOOL_14737
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_14762 
" + _266 + @" = 0 

:DSKOOL_14762
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_14810 
" + Current_Flight_Record + @" = 0 

:DSKOOL_14810
gosub @DSKOOL_31731 
" + _269 + @" = 200 
if 
   not Car.Wrecked(" + _196 + @")
else_jump @DSKOOL_14897 
" + _261 + @" = Car.Health(" + _196 + @")
" + _264 + @" = 1000 
0060: " + _264 + @" -= " + _261 + @" 
" + _264 + @" /= 10 
if 
  " + _264 + @" > 100 
else_jump @DSKOOL_14897 
" + _264 + @" = 100 

:DSKOOL_14897
if 
   not Car.Wrecked(" + _197 + @")
else_jump @DSKOOL_14969 
" + _262 + @" = Car.Health(" + _197 + @")
" + _265 + @" = 1000 
0060: " + _265 + @" -= " + _262 + @" 
" + _265 + @" /= 10 
if 
  " + _265 + @" > 100 
else_jump @DSKOOL_14969 
" + _265 + @" = 100 

:DSKOOL_14969
0084: " + _269 + @" = " + _264 + @" 
0058: " + _269 + @" += " + _265 + @" 
0084: " + _272 + @" = " + _268 + @" 
0058: " + _272 + @" += " + _269 + @" 
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _91 + @" 
else_jump @DSKOOL_15072 
008B: 47@ = " + _91 + @" 
0084: " + _91 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_15079 

:DSKOOL_15072
45@ = 0 

:DSKOOL_15079
if 
  " + _53 + @" == 10 
else_jump @DSKOOL_15143 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_15143 
41@ = 2 
" + _53 + @" = 11 
" + _325 + @" = 2 
50@ = 11 

:DSKOOL_15143
32@ = 0 

:DSKOOL_15150
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_15210 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_15210 
" + _325 + @" = 2 
jump @DSKOOL_15256 

:DSKOOL_15210
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_15249 
jump @DSKOOL_15256 

:DSKOOL_15249
jump @DSKOOL_15150 

:DSKOOL_15256
gosub @DSKOOL_35120 
Car.Destroy(" + _196 + @")
Car.Destroy(" + _197 + @")
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_15307 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_15314 

:DSKOOL_15307
jump @DSKOOL_13441 

:DSKOOL_15314
jump @DSKOOL_13788 

:DSKOOL_15321
if 
  " + _247 + @" == 11 
else_jump @DSKOOL_16925 

:DSKOOL_15339
gosub @DSKOOL_30188 

:DSKOOL_15346
" + _258 + @" = 180.0 
" + _253 + @" = 0 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#BANSHEE, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
0086: " + _277 + @" = " + _255 + @" 
" + _277 + @" += 1.0 
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 25.0 
" + _258 + @" = 90.0 
58@ = Object.Create(#GARYS_LUV_RAMP, " + _277 + @", " + _278 + @", " + _257 + @")
Object.Angle(58@) = 270.0
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -50.0 30.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 50.0 200.0 0.0 
if 
  34@ == 0 
else_jump @DSKOOL_15621 
Camera.SetPosition(-2052.6, -138.4, 34.9, 0.0, 0.0, 0.0)
Camera.PointAt(-2044.2, -208.2, 37.1, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_15619 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_15619
return 

:DSKOOL_15621
00BE: text_clear_all 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 0.0 100.0 0.0 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_34' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_15691
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_15726 
" + _325 + @" = 2 
jump @DSKOOL_16865 

:DSKOOL_15726
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_15758 
jump @DSKOOL_24457 

:DSKOOL_15758
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_15840 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_15826 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_34' time 5000 flag 4  

:DSKOOL_15826
gosub @DSKOOL_31183 
jump @DSKOOL_16918 

:DSKOOL_15840
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_16918 
if 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere " + _305 + @" " + _306 + @" " + _257 + @" radius 4.0 4.0 4.0 
else_jump @DSKOOL_15898 

:DSKOOL_15898
if 
00B0:   car " + _198 + @" sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @DSKOOL_15985 
06BE: " + _276 + @" = car " + _198 + @" y_angle 
if 
  4.0 > " + _276 + @" 
else_jump @DSKOOL_15985 
if 
  " + _276 + @" > -4.0 
else_jump @DSKOOL_15985 
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 

:DSKOOL_15985
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_16918 
gosub @DSKOOL_31537 
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_16918 
gosub @DSKOOL_31537 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
Car.StorePos(" + _198 + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: " + _259 + @" = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY " + _255 + @" " + _256 + @" 
if 
  " + _259 + @" > 1.0 
else_jump @DSKOOL_16184 
if 
  10.0 > " + _259 + @" 
else_jump @DSKOOL_16170 
" + _259 + @" -= 1.0 
" + _259 + @" *= 11.0 
008C: " + _273 + @" = float " + _259 + @" to_integer 
" + _267 + @" = 100 
0060: " + _267 + @" -= " + _273 + @" 
jump @DSKOOL_16177 

:DSKOOL_16170
" + _267 + @" = 0 

:DSKOOL_16177
jump @DSKOOL_16191 

:DSKOOL_16184
" + _267 + @" = 100 

:DSKOOL_16191
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_16239 
" + _266 + @" = 0 
jump @DSKOOL_16522 

:DSKOOL_16239
if 
  " + _252 + @" == 180 
else_jump @DSKOOL_16272 
" + _266 + @" = 100 
jump @DSKOOL_16522 

:DSKOOL_16272
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_16305 
" + _266 + @" = 0 
jump @DSKOOL_16522 

:DSKOOL_16305
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_16375 
if 
  175 > " + _252 + @" 
else_jump @DSKOOL_16375 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_16522 

:DSKOOL_16375
if 
  " + _252 + @" > 174 
else_jump @DSKOOL_16420 
if 
  186 > " + _252 + @" 
else_jump @DSKOOL_16420 
" + _266 + @" = 100 

:DSKOOL_16420
if 
  " + _252 + @" > 185 
else_jump @DSKOOL_16522 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_16522 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_16522 

:DSKOOL_16522
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_16547 
" + _266 + @" = 0 

:DSKOOL_16547
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_16595 
" + Current_Flight_Record + @" = 0 

:DSKOOL_16595
gosub @DSKOOL_31731 
0084: " + _272 + @" = " + _268 + @" 
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _101 + @" 
else_jump @DSKOOL_16681 
008B: 47@ = " + _101 + @" 
0084: " + _101 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_16688 

:DSKOOL_16681
45@ = 0 

:DSKOOL_16688
if 
  " + _53 + @" == 11 
else_jump @DSKOOL_16752 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_16752 
41@ = 2 
" + _53 + @" = 13 
" + _325 + @" = 2 
50@ = 13 

:DSKOOL_16752
32@ = 0 

:DSKOOL_16759
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_16819 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_16819 
" + _325 + @" = 2 
jump @DSKOOL_16865 

:DSKOOL_16819
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_16858 
jump @DSKOOL_16865 

:DSKOOL_16858
jump @DSKOOL_16759 

:DSKOOL_16865
gosub @DSKOOL_35120 
Object.Destroy(58@)
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_16911 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_16918 

:DSKOOL_16911
jump @DSKOOL_15339 

:DSKOOL_16918
jump @DSKOOL_15691 

:DSKOOL_16925
if or
  " + _247 + @" == 12 
  " + _247 + @" == 13 
else_jump @DSKOOL_18334 

:DSKOOL_16950
gosub @DSKOOL_30188 

:DSKOOL_16957
" + _258 + @" = 0.0 
" + _253 + @" = 6000 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#TAXI, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
08F3: set_car " + _198 + @" contains_goodies 0 
gosub @DSKOOL_35458 
if 
  34@ == 0 
else_jump @DSKOOL_17116 
Camera.SetPosition(-2051.9, -185.5, 37.8, 0.0, 0.0, 0.0)
Camera.PointAt(-2052.2, -152.9, 34.3, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_17114 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_17114
return 

:DSKOOL_17116
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_17170 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car " + _198 + @" with_offset 6.5 -40.0 0.0 
jump @DSKOOL_17199 

:DSKOOL_17170
0407: store_coords_to " + _303 + @" " + _304 + @" " + _257 + @" from_car " + _198 + @" with_offset -6.5 -40.0 0.0 

:DSKOOL_17199
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSREVE' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_28' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_17240
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_17275 
" + _325 + @" = 2 
jump @DSKOOL_18272 

:DSKOOL_17275
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_17307 
jump @DSKOOL_24457 

:DSKOOL_17307
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_17389 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_17375 
00BA: show_text_styled GXT 'DSREVE' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_28' time 5000 flag 4  

:DSKOOL_17375
gosub @DSKOOL_31183 
jump @DSKOOL_18327 

:DSKOOL_17389
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_18327 
gosub @DSKOOL_31503 
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_18327 
gosub @DSKOOL_31537 
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_17476 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
jump @DSKOOL_17492 

:DSKOOL_17476
0086: " + _255 + @" = " + _303 + @" 
0086: " + _256 + @" = " + _304 + @" 

:DSKOOL_17492
gosub @DSKOOL_31577 
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_17569 
if 
80B0:   not car " + _198 + @" sphere 0 in_rectangle_cornerA -2046.9 -161.4 cornerB -2041.2 -174.5 
else_jump @DSKOOL_17562 
" + _267 + @" = 0 

:DSKOOL_17562
jump @DSKOOL_17614 

:DSKOOL_17569
if 
80B0:   not car " + _198 + @" sphere 0 in_rectangle_cornerA -2054.2 -161.4 cornerB -2060.0 -174.5 
else_jump @DSKOOL_17614 
" + _267 + @" = 0 

:DSKOOL_17614
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_17662 
" + _266 + @" = 0 
jump @DSKOOL_17945 

:DSKOOL_17662
if 
  " + _252 + @" == 180 
else_jump @DSKOOL_17695 
" + _266 + @" = 100 
jump @DSKOOL_17945 

:DSKOOL_17695
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_17728 
" + _266 + @" = 0 
jump @DSKOOL_17945 

:DSKOOL_17728
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_17798 
if 
  175 > " + _252 + @" 
else_jump @DSKOOL_17798 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_17945 

:DSKOOL_17798
if 
  " + _252 + @" > 174 
else_jump @DSKOOL_17843 
if 
  186 > " + _252 + @" 
else_jump @DSKOOL_17843 
" + _266 + @" = 100 

:DSKOOL_17843
if 
  " + _252 + @" > 185 
else_jump @DSKOOL_17945 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_17945 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_17945 

:DSKOOL_17945
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_17970 
" + _266 + @" = 0 

:DSKOOL_17970
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_18018 
" + Current_Flight_Record + @" = 0 

:DSKOOL_18018
gosub @DSKOOL_31821 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _92 + @" 
else_jump @DSKOOL_18088 
008B: 47@ = " + _92 + @" 
0084: " + _92 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_18095 

:DSKOOL_18088
45@ = 0 

:DSKOOL_18095
if 
  " + _53 + @" == 13 
else_jump @DSKOOL_18159 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_18159 
41@ = 2 
" + _53 + @" = 14 
" + _325 + @" = 2 
50@ = 14 

:DSKOOL_18159
32@ = 0 

:DSKOOL_18166
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_18226 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_18226 
" + _325 + @" = 2 
jump @DSKOOL_18272 

:DSKOOL_18226
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_18265 
jump @DSKOOL_18272 

:DSKOOL_18265
jump @DSKOOL_18166 

:DSKOOL_18272
gosub @DSKOOL_35120 
gosub @DSKOOL_35404 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_18320 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_18327 

:DSKOOL_18320
jump @DSKOOL_16950 

:DSKOOL_18327
jump @DSKOOL_17240 

:DSKOOL_18334
if 
  " + _247 + @" == 14 
else_jump @DSKOOL_20041 

:DSKOOL_18352
gosub @DSKOOL_30188 

:DSKOOL_18359
" + _258 + @" = 180.0 
" + _253 + @" = 0 
gosub @DSKOOL_30297 
" + _198 + @" = Car.Create(#COPCARSF, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
08F3: set_car " + _198 + @" contains_goodies 0 
0086: " + _277 + @" = " + _255 + @" 
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 10.0 
" + _196 + @" = Car.Create(#COPCARSF, " + _277 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _196 + @") = " + _258 + @"
0560: create_random_actor_in_car " + _196 + @" handle_as 56@ 
Car.SetMaxSpeed(" + _196 + @", 0.0)
59@ = Object.Create(#AD_ROADMARK2, -2045.0, -177.5, 34.35)
Object.Angle(59@) = 180.0
57@ = Object.Create(#AD_ROADMARK2, -2057.0, -177.5, 34.35)
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset -12.0 -4.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car " + _198 + @" with_offset 12.0 100.0 0.0 
if 
  34@ == 0 
else_jump @DSKOOL_18698 
Camera.SetPosition(-2047.0, -220.2, 36.0, 0.0, 0.0, 0.0)
Camera.PointAt(-2050.2, -193.9, 32.5, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_18696 
55@ = Actor.CreateAsDriver(Mission2, #SFPD1, " + _198 + @")

:DSKOOL_18696
return 

:DSKOOL_18698
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_35' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_18739
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_18774 
" + _325 + @" = 2 
jump @DSKOOL_19966 

:DSKOOL_18774
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_18806 
jump @DSKOOL_24457 

:DSKOOL_18806
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_18888 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_18874 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_35' time 5000 flag 4  

:DSKOOL_18874
gosub @DSKOOL_31183 
jump @DSKOOL_20034 

:DSKOOL_18888
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_20034 
if 
   not Car.Wrecked(" + _196 + @")
else_jump @DSKOOL_20034 
if 
80B0:   not car " + _196 + @" sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @DSKOOL_18964 
Car.LockInCurrentPosition(" + _196 + @") = True
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_18964
if 
80B0:   not car " + _198 + @" sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @DSKOOL_19008 
Car.LockInCurrentPosition(" + _196 + @") = True
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_19008
" + _251 + @" = Car.Angle(" + _196 + @")
if or
  " + _251 + @" > 340.0 
  20.0 > " + _251 + @" 
else_jump @DSKOOL_19061 
Car.LockInCurrentPosition(" + _196 + @") = True
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_19061
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_20034 
Car.LockInCurrentPosition(" + _196 + @") = True
gosub @DSKOOL_31537 
Car.StorePos(" + _196 + @", " + _255 + @", " + _256 + @", " + _257 + @")
Car.StorePos(" + _198 + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: " + _259 + @" = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY " + _255 + @" " + _256 + @" 
if 
  " + _259 + @" > 4.0 
else_jump @DSKOOL_19242 
if 
  11.0 > " + _259 + @" 
else_jump @DSKOOL_19228 
" + _259 + @" -= 4.0 
" + _259 + @" *= 14.14 
008C: " + _273 + @" = float " + _259 + @" to_integer 
" + _267 + @" = 100 
0060: " + _267 + @" -= " + _273 + @" 
jump @DSKOOL_19235 

:DSKOOL_19228
" + _267 + @" = 0 

:DSKOOL_19235
jump @DSKOOL_19249 

:DSKOOL_19242
" + _267 + @" = 100 

:DSKOOL_19249
0058: " + Current_Flight_Record + @" += " + _267 + @" 
" + _251 + @" = Car.Angle(" + _196 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_19305 
" + _266 + @" = 100 
jump @DSKOOL_19598 

:DSKOOL_19305
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_19338 
" + _266 + @" = 100 
jump @DSKOOL_19598 

:DSKOOL_19338
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_19381 
if 
  21 > " + _252 + @" 
else_jump @DSKOOL_19381 
" + _266 + @" = 100 

:DSKOOL_19381
if 
  " + _252 + @" > 179 
else_jump @DSKOOL_19468 
if 
  340 > " + _252 + @" 
else_jump @DSKOOL_19468 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.62 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_19598 

:DSKOOL_19468
if 
  " + _252 + @" > 339 
else_jump @DSKOOL_19513 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_19513 
" + _266 + @" = 100 

:DSKOOL_19513
if 
  " + _252 + @" > 20 
else_jump @DSKOOL_19598 
if 
  180 > " + _252 + @" 
else_jump @DSKOOL_19598 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.62 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_19598 

:DSKOOL_19598
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_19623 
" + _266 + @" = 0 

:DSKOOL_19623
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_19671 
" + Current_Flight_Record + @" = 0 

:DSKOOL_19671
gosub @DSKOOL_31731 
if 
  3 > " + _268 + @" 
else_jump @DSKOOL_19703 
" + _268 + @" = 0 

:DSKOOL_19703
0084: " + _272 + @" = " + _268 + @" 
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _102 + @" 
else_jump @DSKOOL_19782 
008B: 47@ = " + _102 + @" 
0084: " + _102 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_19789 

:DSKOOL_19782
45@ = 0 

:DSKOOL_19789
if 
  " + _53 + @" == 14 
else_jump @DSKOOL_19853 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_19853 
41@ = 2 
" + _53 + @" = 15 
" + _325 + @" = 2 
50@ = 15 

:DSKOOL_19853
32@ = 0 

:DSKOOL_19860
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_19920 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_19920 
" + _325 + @" = 2 
jump @DSKOOL_19966 

:DSKOOL_19920
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_19959 
jump @DSKOOL_19966 

:DSKOOL_19959
jump @DSKOOL_19860 

:DSKOOL_19966
gosub @DSKOOL_35120 
Car.Destroy(" + _196 + @")
Object.Destroy(59@)
Object.Destroy(57@)
Actor.DestroyInstantly(56@)
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_20027 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_20034 

:DSKOOL_20027
jump @DSKOOL_18352 

:DSKOOL_20034
jump @DSKOOL_18739 

:DSKOOL_20041
if 
  " + _247 + @" == 15 
else_jump @DSKOOL_22693 

:DSKOOL_20059
gosub @DSKOOL_30188 

:DSKOOL_20066
" + _258 + @" = 180.0 
" + _253 + @" = 6000 
gosub @DSKOOL_30297 
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" += 20.0 
" + _198 + @" = Car.Create(#BANSHEE, " + _255 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _198 + @") = " + _258 + @"
0852: set_car " + _198 + @" damages_visible 0 
0086: " + _277 + @" = " + _255 + @" 
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 55.0 
" + _258 + @" = 90.0 
57@ = Object.Create(#AD_JUMP, " + _277 + @", " + _278 + @", " + _257 + @")
Object.Angle(57@) = 180.0
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 75.0 
" + _196 + @" = Car.Create(#INFERNUS, " + _277 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _196 + @") = " + _258 + @"
Car.LockInCurrentPosition(" + _196 + @") = True
0086: " + _278 + @" = " + _256 + @" 
" + _278 + @" -= 80.0 
" + _197 + @" = Car.Create(#INFERNUS, " + _277 + @", " + _278 + @", " + _257 + @")
Car.Angle(" + _197 + @") = " + _258 + @"
Car.LockInCurrentPosition(" + _197 + @") = True
if 
  34@ == 0 
else_jump @DSKOOL_20399 
Camera.SetPosition(-2061.2, -158.9, 37.5, 0.0, 0.0, 0.0)
Camera.PointAt(-2040.3, -197.0, 35.1, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_20397 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_20397
return 

:DSKOOL_20399
00BE: text_clear_all 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_33' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_20440
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_20475 
" + _325 + @" = 2 
jump @DSKOOL_22623 

:DSKOOL_20475
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_20507 
jump @DSKOOL_24457 

:DSKOOL_20507
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_20589 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_20575 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_33' time 5000 flag 4  

:DSKOOL_20575
gosub @DSKOOL_31183 
jump @DSKOOL_22686 

:DSKOOL_20589
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_22686 
gosub @DSKOOL_31503 
if 
  " + _254 + @" == 0 
else_jump @DSKOOL_20685 
if 
00B1:   car " + _198 + @" sphere 0 in_cube_cornerA -2047.0 -186.0 37.2 cornerB -2054.0 -190.0 39.0 
else_jump @DSKOOL_20685 
" + _254 + @" = 1 

:DSKOOL_20685
if 
  " + _254 + @" == 1 
else_jump @DSKOOL_20765 
Car.Health(" + _198 + @") = 1000
if 
81F3:   not car " + _198 + @" in_air 
else_jump @DSKOOL_20765 
if 
01F4:   car " + _198 + @" flipped 
else_jump @DSKOOL_20765 
Car.Health(" + _198 + @") = 700
0852: set_car " + _198 + @" damages_visible 1 
" + _254 + @" = 2 

:DSKOOL_20765
if 
81F3:   not car " + _198 + @" in_air 
else_jump @DSKOOL_20804 
if 
01F4:   car " + _198 + @" flipped 
else_jump @DSKOOL_20804 
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 

:DSKOOL_20804
if 
80B0:   not car " + _198 + @" sphere 0 in_rectangle_cornerA -2042.0 -100.0 cornerB -2058.0 -280.0 
else_jump @DSKOOL_20849 
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_20849
" + _251 + @" = Car.Angle(" + _198 + @")
if or
  " + _251 + @" > 200.0 
  160.0 > " + _251 + @" 
else_jump @DSKOOL_20898 
" + _276 + @" = 1.0 

:DSKOOL_20898
06BE: 36@ = car " + _198 + @" y_angle 
if 
  37@ == 0 
else_jump @DSKOOL_20980 
if 
  36@ > 5.0 
else_jump @DSKOOL_20952 
38@ = 1 

:DSKOOL_20952
if 
  -5.0 > 36@ 
else_jump @DSKOOL_20980 
38@ = 2 

:DSKOOL_20980
if 
  38@ == 1 
else_jump @DSKOOL_21319 
if 
  37@ == 0 
else_jump @DSKOOL_21044 
if 
  36@ > 90.0 
else_jump @DSKOOL_21044 
37@ = 1 

:DSKOOL_21044
if 
  37@ == 1 
else_jump @DSKOOL_21090 
if 
  36@ > 170.0 
else_jump @DSKOOL_21090 
37@ = 2 

:DSKOOL_21090
if 
  37@ == 2 
else_jump @DSKOOL_21157 
if 
  0.0 > 36@ 
else_jump @DSKOOL_21157 
if 
  36@ > -170.0 
else_jump @DSKOOL_21157 
37@ = 3 

:DSKOOL_21157
if 
  37@ == 3 
else_jump @DSKOOL_21252 
if 
  0.0 > 36@ 
else_jump @DSKOOL_21224 
if 
  36@ > -90.0 
else_jump @DSKOOL_21224 
37@ = 4 

:DSKOOL_21224
if 
  36@ > 10.0 
else_jump @DSKOOL_21252 
37@ = 0 

:DSKOOL_21252
if 
  37@ == 4 
else_jump @DSKOOL_21319 
if 
  0.0 > 36@ 
else_jump @DSKOOL_21319 
if 
  36@ > -5.0 
else_jump @DSKOOL_21319 
37@ = 5 

:DSKOOL_21319
if 
  38@ == 2 
else_jump @DSKOOL_21658 
if 
  37@ == 0 
else_jump @DSKOOL_21383 
if 
  -90.0 > 36@ 
else_jump @DSKOOL_21383 
37@ = 1 

:DSKOOL_21383
if 
  37@ == 1 
else_jump @DSKOOL_21429 
if 
  -170.0 > 36@ 
else_jump @DSKOOL_21429 
37@ = 2 

:DSKOOL_21429
if 
  37@ == 2 
else_jump @DSKOOL_21496 
if 
  36@ > 0.0 
else_jump @DSKOOL_21496 
if 
  170.0 > 36@ 
else_jump @DSKOOL_21496 
37@ = 3 

:DSKOOL_21496
if 
  37@ == 3 
else_jump @DSKOOL_21591 
if 
  36@ > 0.0 
else_jump @DSKOOL_21563 
if 
  90.0 > 36@ 
else_jump @DSKOOL_21563 
37@ = 4 

:DSKOOL_21563
if 
  -10.0 > 36@ 
else_jump @DSKOOL_21591 
37@ = 0 

:DSKOOL_21591
if 
  37@ == 4 
else_jump @DSKOOL_21658 
if 
  36@ > 0.0 
else_jump @DSKOOL_21658 
if 
  5.0 > 36@ 
else_jump @DSKOOL_21658 
37@ = 5 

:DSKOOL_21658
if 
01C1:   car " + _198 + @" stopped 
else_jump @DSKOOL_22686 
gosub @DSKOOL_31537 
if 
  37@ == 5 
else_jump @DSKOOL_21706 
" + _267 + @" = 100 

:DSKOOL_21706
if 
  37@ == 4 
else_jump @DSKOOL_21731 
" + _267 + @" = 80 

:DSKOOL_21731
if 
  37@ == 3 
else_jump @DSKOOL_21756 
" + _267 + @" = 60 

:DSKOOL_21756
if 
  37@ == 2 
else_jump @DSKOOL_21781 
" + _267 + @" = 40 

:DSKOOL_21781
if 
  37@ == 1 
else_jump @DSKOOL_21806 
" + _267 + @" = 20 

:DSKOOL_21806
if 
  37@ == 0 
else_jump @DSKOOL_21831 
" + _267 + @" = 0 

:DSKOOL_21831
if 
  " + _254 + @" == 0 
else_jump @DSKOOL_21856 
" + _267 + @" = 0 

:DSKOOL_21856
if 
01F4:   car " + _198 + @" flipped 
else_jump @DSKOOL_21879 
" + _267 + @" = 0 

:DSKOOL_21879
if 
80B0:   not car " + _198 + @" sphere 0 in_rectangle_cornerA -2042.0 -215.0 cornerB -2058.0 -280.0 
else_jump @DSKOOL_21924 
" + _267 + @" = 0 

:DSKOOL_21924
" + _251 + @" = Car.Angle(" + _198 + @")
008C: " + _252 + @" = float " + _251 + @" to_integer 
if 
  " + _252 + @" == 0 
else_jump @DSKOOL_21972 
" + _266 + @" = 0 
jump @DSKOOL_22255 

:DSKOOL_21972
if 
  " + _252 + @" == 180 
else_jump @DSKOOL_22005 
" + _266 + @" = 100 
jump @DSKOOL_22255 

:DSKOOL_22005
if 
  " + _252 + @" == 360 
else_jump @DSKOOL_22038 
" + _266 + @" = 0 
jump @DSKOOL_22255 

:DSKOOL_22038
if 
  " + _252 + @" > 0 
else_jump @DSKOOL_22108 
if 
  175 > " + _252 + @" 
else_jump @DSKOOL_22108 
008D: " + _276 + @" = integer " + _252 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @DSKOOL_22255 

:DSKOOL_22108
if 
  " + _252 + @" > 174 
else_jump @DSKOOL_22153 
if 
  186 > " + _252 + @" 
else_jump @DSKOOL_22153 
" + _266 + @" = 100 

:DSKOOL_22153
if 
  " + _252 + @" > 185 
else_jump @DSKOOL_22255 
if 
  360 > " + _252 + @" 
else_jump @DSKOOL_22255 
0084: " + _273 + @" = " + _252 + @" 
" + _273 + @" -= 180 
008D: " + _276 + @" = integer " + _273 + @" to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @DSKOOL_22255 

:DSKOOL_22255
if 
  1 > " + _266 + @" 
else_jump @DSKOOL_22280 
" + _266 + @" = 0 

:DSKOOL_22280
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @DSKOOL_22328 
" + Current_Flight_Record + @" = 0 

:DSKOOL_22328
gosub @DSKOOL_31731 
if 
  2 > " + _268 + @" 
else_jump @DSKOOL_22360 
" + _268 + @" = 0 

:DSKOOL_22360
0084: " + _272 + @" = " + _268 + @" 
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _100 + @" 
else_jump @DSKOOL_22439 
008B: 47@ = " + _100 + @" 
0084: " + _100 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_22446 

:DSKOOL_22439
45@ = 0 

:DSKOOL_22446
if 
  " + _53 + @" == 15 
else_jump @DSKOOL_22510 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_22510 
41@ = 2 
" + _53 + @" = 16 
" + _325 + @" = 2 
50@ = 16 

:DSKOOL_22510
32@ = 0 

:DSKOOL_22517
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_22577 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_22577 
" + _325 + @" = 2 
jump @DSKOOL_22623 

:DSKOOL_22577
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_22616 
jump @DSKOOL_22623 

:DSKOOL_22616
jump @DSKOOL_22517 

:DSKOOL_22623
gosub @DSKOOL_35120 
Car.Destroy(" + _196 + @")
Car.Destroy(" + _197 + @")
Object.Destroy(57@)
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_22679 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_22686 

:DSKOOL_22679
jump @DSKOOL_20059 

:DSKOOL_22686
jump @DSKOOL_20440 

:DSKOOL_22693
if 
  " + _247 + @" == 16 
else_jump @DSKOOL_24457 

:DSKOOL_22711
gosub @DSKOOL_30188 

:DSKOOL_22718
" + _258 + @" = 180.0 
" + _253 + @" = 0 
gosub @DSKOOL_30297 
" + _255 + @" = -2046.7 
" + _256 + @" = -90.2 
" + _257 + @" = 33.9 
" + _282 + @" = -1724.3 
" + _283 + @" = 1294.0 
" + _284 + @" = 6.0 
" + _198 + @" = Car.Create(#SUPERGT, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(" + _198 + @") = 0.0
039C: set_car " + _198 + @" watertight 1 
if 
  34@ == 0 
else_jump @DSKOOL_22931 
Camera.SetPosition(-2017.3, -45.0, 34.41, 0.0, 0.0, 0.0)
Camera.PointAt(-2039.0, -100.3, 37.4, 2)
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_22929 
0560: create_random_actor_in_car " + _198 + @" handle_as 55@ 

:DSKOOL_22929
return 

:DSKOOL_22931
00BE: text_clear_all 
01EB: set_traffic_density_multiplier_to 0.5 
Camera.SetAtPos(" + _255 + @", " + _256 + @", " + _257 + @")
018A: 35@ = create_checkpoint_at " + _282 + @" " + _283 + @" " + _284 + @" 
06D5: 42@ = create_racing_checkpoint_at " + _282 + @" " + _283 + @" " + _284 + @" point_to " + _255 + @" " + _256 + @" " + _257 + @" type 0 radius 5.0 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_31' time 5000 flag 4  
gosub @DSKOOL_31009 

:DSKOOL_23034
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_23069 
" + _325 + @" = 2 
jump @DSKOOL_24136 

:DSKOOL_23069
gosub @DSKOOL_31077 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_23101 
jump @DSKOOL_24457 

:DSKOOL_23101
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_23126 
jump @DSKOOL_24136 

:DSKOOL_23126
if 
  " + _249 + @" == 0 
else_jump @DSKOOL_23208 
if 
   not " + _325 + @" == 2 
else_jump @DSKOOL_23194 
00BA: show_text_styled GXT 'DSTART' time 5000 style 4  
00BC: show_text_highpriority GXT 'DS1_31' time 5000 flag 4  

:DSKOOL_23194
gosub @DSKOOL_31183 
jump @DSKOOL_24450 

:DSKOOL_23208
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_24450 
if 
  " + _253 + @" > 260000 
else_jump @DSKOOL_23252 
Player.CanMove(" + PlayerChar + @") = False

:DSKOOL_23252
if 
  " + _254 + @" == 0 
else_jump @DSKOOL_23373 
if 
01AF:   car " + _198 + @" sphere 0 in_sphere " + _282 + @" " + _283 + @" " + _284 + @" radius 4.0 4.0 4.0 
else_jump @DSKOOL_23373 
Marker.Disable(35@)
018A: 35@ = create_checkpoint_at " + _255 + @" " + _256 + @" " + _257 + @" 
06D6: disable_racing_checkpoint 42@ 
06D5: 42@ = create_racing_checkpoint_at " + _255 + @" " + _256 + @" " + _257 + @" point_to " + _255 + @" " + _256 + @" " + _257 + @" type 1 radius 5.0 
" + _254 + @" = 1 

:DSKOOL_23373
if 
  " + _254 + @" == 1 
else_jump @DSKOOL_23445 
if 
01AF:   car " + _198 + @" sphere 0 in_sphere " + _255 + @" " + _256 + @" " + _257 + @" radius 4.0 4.0 4.0 
else_jump @DSKOOL_23445 
Marker.Disable(35@)
" + _254 + @" = 2 

:DSKOOL_23445
00BE: text_clear_all 
if or
01C1:   car " + _198 + @" stopped 
  " + _254 + @" == 2 
02BF:   car " + _198 + @" sunk 
  " + _253 + @" >= 140000 
else_jump @DSKOOL_24450 
gosub @DSKOOL_31537 
06D6: disable_racing_checkpoint 42@ 
0084: " + _273 + @" = " + _253 + @" 
0084: " + _301 + @" = " + _273 + @" 
" + _301 + @" /= 1000 
0084: " + _302 + @" = " + _301 + @" 
" + _302 + @" *= 1000 
0084: " + _274 + @" = " + _273 + @" 
0060: " + _274 + @" -= " + _302 + @" 
0084: " + _302 + @" = " + _274 + @" 
" + _302 + @" /= 10 
" + _270 + @" = 0 
if 
  2 > " + _254 + @" 
else_jump @DSKOOL_23607 
" + _270 + @" = 0 
jump @DSKOOL_23865 

:DSKOOL_23607
if 
  100000 > " + _273 + @" 
else_jump @DSKOOL_23635 
" + _270 + @" = 100 

:DSKOOL_23635
if 
  " + _273 + @" >= 100000 
else_jump @DSKOOL_23736 
if 
  120000 > " + _273 + @" 
else_jump @DSKOOL_23736 
0084: " + _274 + @" = " + _273 + @" 
" + _274 + @" -= 99999 
008D: " + _276 + @" = integer " + _274 + @" to_float 
" + _276 + @" *= 0.0015 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _270 + @" = 100 
0060: " + _270 + @" -= " + _273 + @" 

:DSKOOL_23736
if 
  " + _273 + @" >= 120000 
else_jump @DSKOOL_23837 
if 
  140000 > " + _273 + @" 
else_jump @DSKOOL_23837 
0084: " + _274 + @" = " + _273 + @" 
" + _274 + @" -= 119999 
008D: " + _276 + @" = integer " + _274 + @" to_float 
" + _276 + @" *= 0.0035 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _270 + @" = 70 
0060: " + _270 + @" -= " + _273 + @" 

:DSKOOL_23837
if 
  " + _273 + @" >= 140000 
else_jump @DSKOOL_23865 
" + _270 + @" = 0 

:DSKOOL_23865
if 
  1 > " + _270 + @" 
else_jump @DSKOOL_23890 
" + _270 + @" = 0 

:DSKOOL_23890
if 
  " + _270 + @" > 99 
else_jump @DSKOOL_23915 
" + _270 + @" = 100 

:DSKOOL_23915
0084: " + Current_Flight_Record + @" = " + _270 + @" 
gosub @DSKOOL_31731 
0084: " + _272 + @" = " + _268 + @" 
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
gosub @DSKOOL_32444 
if 
001C:   " + Current_Flight_Record + @" > " + _97 + @" 
else_jump @DSKOOL_24009 
008B: 47@ = " + _97 + @" 
0084: " + _97 + @" = " + Current_Flight_Record + @" 
41@ = 1 
gosub @DSKOOL_32926 
jump @DSKOOL_24016 

:DSKOOL_24009
45@ = 0 

:DSKOOL_24016
" + _254 + @" = 5 
32@ = 0 

:DSKOOL_24030
wait 0 
gosub @DSKOOL_32473 
if 
   not 41@ == 2 
else_jump @DSKOOL_24090 
if 
00E1:   player 0 pressed_key 15 
else_jump @DSKOOL_24090 
" + _325 + @" = 2 
jump @DSKOOL_24136 

:DSKOOL_24090
gosub @DSKOOL_33226 
gosub @DSKOOL_35037 
if 
  " + _326 + @" == 1 
else_jump @DSKOOL_24129 
jump @DSKOOL_24136 

:DSKOOL_24129
jump @DSKOOL_24030 

:DSKOOL_24136
if 
  " + Mission_Back_to_School_Passed + @" == 0 
else_jump @DSKOOL_24385 
if 
  " + _53 + @" == 16 
else_jump @DSKOOL_24385 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_24385 
fade 0 500 

:DSKOOL_24197
if 
fading 
else_jump @DSKOOL_24221 
wait 0 
jump @DSKOOL_24197 

:DSKOOL_24221
select_interior 3 
0860: link_actor " + PlayerActor + @" to_interior 3 
04FA: reset_sky_colors_with_fade 1 
04E4: refresh_game_renderer_at -2031.1 -118.2 
Camera.SetAtPos(-2031.1, -118.2, 1034.2)
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.PutAt(" + PlayerActor + @", -2029.7, -115.5, 1034.2)
Actor.Angle(" + PlayerActor + @") = 0.0
0792: disembark_instantly_actor " + PlayerActor + @" 
Car.Destroy(" + _198 + @")
0395: clear_area 1 at -2051.0 -174.0 34.0 radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
fade 1 500 

:DSKOOL_24354
if 
fading 
else_jump @DSKOOL_24378 
wait 0 
jump @DSKOOL_24354 

:DSKOOL_24378
jump @DSKOOL_24495 

:DSKOOL_24385
gosub @DSKOOL_35120 
Marker.Disable(35@)
06D6: disable_racing_checkpoint 42@ 
01EB: set_traffic_density_multiplier_to 1.0 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_24443 
00BE: text_clear_all 
jump @DSKOOL_1425 
jump @DSKOOL_24450 

:DSKOOL_24443
jump @DSKOOL_22711 

:DSKOOL_24450
jump @DSKOOL_23034 

:DSKOOL_24457
00BE: text_clear_all 
if 
  " + _325 + @" == 1 
else_jump @DSKOOL_24493 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  

:DSKOOL_24493
return 

:DSKOOL_24495
if 
  " + Mission_Back_to_School_Passed + @" == 0 
else_jump @DSKOOL_24584 
00BE: text_clear_all 
01E3: show_text_1number_styled GXT 'DS_PASS' number 15 time 5000 style 1  
0624: add 40.0 to_float_stat 160 
0394: play_music 2 
Player.ClearWantedLevel(" + PlayerChar + @")
0318: set_latest_mission_passed 'FAR_1'  
" + Mission_Back_to_School_Passed + @" = 1 

:DSKOOL_24584
return 

:DSKOOL_24586
if 
  " + _7417 + @" == 0 
else_jump @DSKOOL_24834 
if 
  " + _107 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _105 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _98 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _96 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _94 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _103 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _91 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _101 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _92 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _102 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _100 + @" >= 70 
else_jump @DSKOOL_24834 
if 
  " + _97 + @" >= 70 
else_jump @DSKOOL_24834" );
                CAR_PARK.set_chance_to_generate( carPark_5178, 101 );
                AppendLine( @"" + _7417 + @" = 1 

:DSKOOL_24834
if 
  " + _7418 + @" == 0 
else_jump @DSKOOL_25082 
if 
  " + _107 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _105 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _98 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _96 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _94 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _103 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _91 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _101 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _92 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _102 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _100 + @" >= 85 
else_jump @DSKOOL_25082 
if 
  " + _97 + @" >= 85 
else_jump @DSKOOL_25082 " );
                CAR_PARK.set_chance_to_generate( carPark_5183, 101 );
                AppendLine( @"" + _7418 + @" = 1 

:DSKOOL_25082
if 
  " + _7419 + @" == 0 
else_jump @DSKOOL_25330 
if 
  " + _107 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _105 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _98 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _96 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _94 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _103 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _91 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _101 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _92 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _102 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _100 + @" == 100 
else_jump @DSKOOL_25330 
if 
  " + _97 + @" == 100 
else_jump @DSKOOL_25330" );
                CAR_PARK.set_chance_to_generate( carPark_5184, 101 );
                AppendLine( @"" + _7419 + @" = 1 

:DSKOOL_25330
014F: stop_timer " + _253 + @" 
03F0: enable_text_draw 0 
01B7: release_weather 
Model.Destroy(#BANSHEE)
Model.Destroy(#TAXI)
Model.Destroy(#TRAFFICCONE)
Model.Destroy(#WMYMECH)
Model.Destroy(#BLISTAC)
Model.Destroy(#INFERNUS)
Model.Destroy(#SUPERGT)
Model.Destroy(#COPCARSF)
Model.Destroy(#SFPD1)
Model.Destroy(#TEMP_STINGER2)
Model.Destroy(#GARYS_LUV_RAMP)
Model.Destroy(#AD_JUMP)
Model.Destroy(#AD_ROADMARK1)
Model.Destroy(#AD_ROADMARK2)
Model.Destroy(#AD_FINISH)
091D: remove_forbidden_for_boats_cube_cornerA -2015.37 -76.08 10.0 cornerB -2078.3 -66.75 50.0 
09EC: set_garages_leave_camera_alone 0 
097A: play_audio_at 0.0 0.0 0.0 event 1184" );
                if( OriginalSetup.OriginalScriptAccess[ 9 ].state ) {
                    AppendLine( @"
Garage.Activate('BODLAWN')
Garage.Activate('MODLAST')
Garage.Activate('MDSSFSE')
if 
  " + _1499 + @" == 1 
else_jump @DSKOOL_25544 
Garage.Activate('MDS1SFS')
Garage.Activate('VECMOD')" );
                }
                AppendLine( @"
:DSKOOL_25544
0A14: disable_respray_garages 0 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @DSKOOL_25571 
0A09: set_actor " + PlayerActor + @" muted 0 

:DSKOOL_25571
09F5: disable_player_mutal_activities 0 
0391: release_textures 
01EB: set_traffic_density_multiplier_to 1.0 
0826: enable_hud 1 
0581: enable_radar 1 
Marker.Disable(35@)
06D6: disable_racing_checkpoint 42@ 
09D2: set_cops_chase_criminals 1 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + OnMission + @" = 0 
mission_cleanup 
return 

:DSKOOL_25622
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 225.0 size 612.0 438.0 RGBA 0 0 0 44@ 
if 
  43@ == 1 
else_jump @DSKOOL_25744 
if 
  255 > 44@ 
else_jump @DSKOOL_25737 
44@ += 5 
if 
  44@ > 255 
else_jump @DSKOOL_25730 
44@ = 255 

:DSKOOL_25730
jump @DSKOOL_25744 

:DSKOOL_25737
43@ = 2 

:DSKOOL_25744
if 
  43@ == 3 
else_jump @DSKOOL_25826 
if 
  44@ > 0 
else_jump @DSKOOL_25819 
44@ -= 5 
if 
  0 > 44@ 
else_jump @DSKOOL_25812 
44@ = 0 

:DSKOOL_25812
jump @DSKOOL_25826 

:DSKOOL_25819
43@ = 0 

:DSKOOL_25826
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 0.0 size 640.0 197.0 RGBA 0 0 0 255 
gosub @DSKOOL_30126 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  " + _247 + @" == 1 
else_jump @DSKOOL_25938 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_P'  
008B: 46@ = " + _107 + @" 
gosub @DSKOOL_27891 

:DSKOOL_25938
if 
  " + _247 + @" == 2 
else_jump @DSKOOL_25992 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_O'  
008B: 46@ = " + _105 + @" 
gosub @DSKOOL_27891 

:DSKOOL_25992
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_26046 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_I'  
008B: 46@ = " + _98 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26046
if 
  " + _247 + @" == 4 
else_jump @DSKOOL_26100 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_I'  
008B: 46@ = " + _98 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26100
if 
  " + _247 + @" == 5 
else_jump @DSKOOL_26154 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_F'  
008B: 46@ = " + _96 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26154
if 
  " + _247 + @" == 6 
else_jump @DSKOOL_26208 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_E'  
008B: 46@ = " + _94 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26208
if 
  " + _247 + @" == 7 
else_jump @DSKOOL_26262 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_E'  
008B: 46@ = " + _94 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26262
if 
  " + _247 + @" == 8 
else_jump @DSKOOL_26316 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_N'  
008B: 46@ = " + _103 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26316
if 
  " + _247 + @" == 9 
else_jump @DSKOOL_26370 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_N'  
008B: 46@ = " + _103 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26370
if 
  " + _247 + @" == 10 
else_jump @DSKOOL_26424 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_A'  
008B: 46@ = " + _91 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26424
if 
  " + _247 + @" == 11 
else_jump @DSKOOL_26478 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_K'  
008B: 46@ = " + _101 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26478
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_26532 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_C'  
008B: 46@ = " + _92 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26532
if 
  " + _247 + @" == 13 
else_jump @DSKOOL_26586 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_C'  
008B: 46@ = " + _92 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26586
if 
  " + _247 + @" == 14 
else_jump @DSKOOL_26640 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_L'  
008B: 46@ = " + _102 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26640
if 
  " + _247 + @" == 15 
else_jump @DSKOOL_26694 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_J'  
008B: 46@ = " + _100 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26694
if 
  " + _247 + @" == 16 
else_jump @DSKOOL_26748 
033E: set_draw_text_position 322.0 31.0 GXT 'DS_G'  
008B: 46@ = " + _97 + @" 
gosub @DSKOOL_27891 

:DSKOOL_26748
gosub @DSKOOL_29948 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @DSKOOL_26843 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'DS1_53'  
jump @DSKOOL_26876 

:DSKOOL_26843
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'DS1_53'  

:DSKOOL_26876
if 
   not 39@ == 1 
else_jump @DSKOOL_27303 
gosub @DSKOOL_29948 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @DSKOOL_26989 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'DS1_54'  
jump @DSKOOL_27022 

:DSKOOL_26989
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'DS1_54'  

:DSKOOL_27022
if 
   not " + _53 + @" == 1 
else_jump @DSKOOL_27175 
gosub @DSKOOL_29948 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @DSKOOL_27135 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'DS1_52'  
jump @DSKOOL_27168 

:DSKOOL_27135
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'DS1_52'  

:DSKOOL_27168
jump @DSKOOL_27303 

:DSKOOL_27175
gosub @DSKOOL_29948 
0904: get_interface 8 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @DSKOOL_27270 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'DS1_52'  
jump @DSKOOL_27303 

:DSKOOL_27270
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'DS1_52'  

:DSKOOL_27303
gosub @DSKOOL_29948 
033F: set_text_draw_letter_size 0.32 1.25 
0904: get_interface 4 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 150.0 360.0 GXT 'DS1_63'  
if 
   not 39@ == 1 
else_jump @DSKOOL_27637 
gosub @DSKOOL_29948 
0904: get_interface 4 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 150.0 340.0 GXT 'SCH_PRS'  
if 
   not " + _53 + @" == 1 
else_jump @DSKOOL_27549 
gosub @DSKOOL_29948 
0904: get_interface 4 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'DS1_62'  

:DSKOOL_27549
if 
  " + _53 + @" == 1 
else_jump @DSKOOL_27637 
gosub @DSKOOL_29948 
0904: get_interface 4 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'DS1_62'  

:DSKOOL_27637
033F: set_text_draw_letter_size 0.52 1.45 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 160.0 112.0 size 320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 160.0 317.0 size 320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 480.0 112.0 size -320.0 224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 5 position 480.0 317.0 size -320.0 -224.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 9 position 160.0 435.0 size 320.0 17.0 RGBA 150 150 150 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 9 position 480.0 435.0 size -320.0 17.0 RGBA 150 150 150 255 
return 

:DSKOOL_27891
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 430.0 size 640.0 250.0 RGBA 0 0 0 255 
if 
  70 > 46@ 
else_jump @DSKOOL_27953 
45@ = 1 

:DSKOOL_27953
if 
  46@ > 69 
else_jump @DSKOOL_27996 
if 
  85 > 46@ 
else_jump @DSKOOL_27996 
45@ = 2 

:DSKOOL_27996
if 
  46@ > 84 
else_jump @DSKOOL_28039 
if 
  100 > 46@ 
else_jump @DSKOOL_28039 
45@ = 3 

:DSKOOL_28039
if 
  46@ == 100 
else_jump @DSKOOL_28064 
45@ = 4 

:DSKOOL_28064
gosub @DSKOOL_29948 
03E4: set_text_draw_align_right 0 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
if 
  45@ > 1 
else_jump @DSKOOL_28154 
045A: draw_text_1number 217.0 75.0 GXT 'DS1_58' number 46@  
jump @DSKOOL_28349 

:DSKOOL_28154
if 
04A3:   " + Current_Language + @" == 0 
else_jump @DSKOOL_28193 
033E: set_draw_text_position 175.0 75.0 GXT 'DS1_67'  

:DSKOOL_28193
if 
04A3:   " + Current_Language + @" == 1 
else_jump @DSKOOL_28232 
033E: set_draw_text_position 83.0 75.0 GXT 'DS1_67'  

:DSKOOL_28232
if 
04A3:   " + Current_Language + @" == 2 
else_jump @DSKOOL_28271 
033E: set_draw_text_position 89.0 75.0 GXT 'DS1_67'  

:DSKOOL_28271
if 
04A3:   " + Current_Language + @" == 3 
else_jump @DSKOOL_28310 
033E: set_draw_text_position 147.0 75.0 GXT 'DS1_67'  

:DSKOOL_28310
if 
04A3:   " + Current_Language + @" == 4 
else_jump @DSKOOL_28349 
033E: set_draw_text_position 65.0 75.0 GXT 'DS1_67'  

:DSKOOL_28349
if 
  45@ > 1 
else_jump @DSKOOL_28454 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 
jump @DSKOOL_28534 

:DSKOOL_28454
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 

:DSKOOL_28534
03E3: set_texture_to_be_drawn_antialiased 1 
if 
  45@ == 1 
else_jump @DSKOOL_28711 
if 
04A3:   " + Current_Language + @" == 0 
else_jump @DSKOOL_28617 
038D: draw_texture 6 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
jump @DSKOOL_28653 

:DSKOOL_28617
038D: draw_texture 10 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 

:DSKOOL_28653
gosub @DSKOOL_29948 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 266.0 375.0 GXT 'DS1_68'  

:DSKOOL_28711
if 
  45@ == 2 
else_jump @DSKOOL_28823 
038D: draw_texture 1 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @DSKOOL_29948 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 280.0 375.0 GXT 'DS1_57'  

:DSKOOL_28823
if 
  45@ == 3 
else_jump @DSKOOL_28935 
038D: draw_texture 2 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @DSKOOL_29948 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 283.0 375.0 GXT 'DS1_56'  

:DSKOOL_28935
if 
  45@ == 4 
else_jump @DSKOOL_29047 
038D: draw_texture 3 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @DSKOOL_29948 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 294.0 375.0 GXT 'DS1_55'  

:DSKOOL_29047
return 

:DSKOOL_29049
if 
  34@ == 0 
else_jump @DSKOOL_29374 
if 
  " + _247 + @" == 1 
else_jump @DSKOOL_29092 
gosub @DSKOOL_3843 

:DSKOOL_29092
if 
  " + _247 + @" == 2 
else_jump @DSKOOL_29117 
gosub @DSKOOL_5416 

:DSKOOL_29117
if 
  " + _247 + @" == 4 
else_jump @DSKOOL_29142 
gosub @DSKOOL_6742 

:DSKOOL_29142
if 
  " + _247 + @" == 5 
else_jump @DSKOOL_29167 
gosub @DSKOOL_8347 

:DSKOOL_29167
if 
  " + _247 + @" == 7 
else_jump @DSKOOL_29192 
gosub @DSKOOL_9857 

:DSKOOL_29192
if 
  " + _247 + @" == 9 
else_jump @DSKOOL_29217 
gosub @DSKOOL_11959 

:DSKOOL_29217
if 
  " + _247 + @" == 10 
else_jump @DSKOOL_29242 
gosub @DSKOOL_13448 

:DSKOOL_29242
if 
  " + _247 + @" == 11 
else_jump @DSKOOL_29267 
gosub @DSKOOL_15346 

:DSKOOL_29267
if 
  " + _247 + @" == 13 
else_jump @DSKOOL_29292 
gosub @DSKOOL_16957 

:DSKOOL_29292
if 
  " + _247 + @" == 14 
else_jump @DSKOOL_29317 
gosub @DSKOOL_18359 

:DSKOOL_29317
if 
  " + _247 + @" == 15 
else_jump @DSKOOL_29342 
gosub @DSKOOL_20066 

:DSKOOL_29342
if 
  " + _247 + @" == 16 
else_jump @DSKOOL_29367 
gosub @DSKOOL_22718 

:DSKOOL_29367
34@ = 1 

:DSKOOL_29374
if 
  34@ == 1 
else_jump @DSKOOL_29611 
if 
  " + _247 + @" == 14 
else_jump @DSKOOL_29545 
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_29538 
if 
87C1:   not path 14 available 
else_jump @DSKOOL_29445 
07C0: load_path 14 

:DSKOOL_29445
if 
87C1:   not path 3 available 
else_jump @DSKOOL_29464 
07C0: load_path 3 

:DSKOOL_29464
if 
07C1:   path 14 available 
else_jump @DSKOOL_29538 
if 
07C1:   path 3 available 
else_jump @DSKOOL_29538 
05EB: assign_car " + _198 + @" to_path 14 
if 
   not Car.Wrecked(" + _196 + @")
else_jump @DSKOOL_29524 
05EB: assign_car " + _196 + @" to_path 3 

:DSKOOL_29524
43@ = 3 
34@ = 2 

:DSKOOL_29538
jump @DSKOOL_29611 

:DSKOOL_29545
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_29611 
if 
87C1:   not path " + _247 + @" available 
else_jump @DSKOOL_29589 
07C0: load_path " + _247 + @" 
jump @DSKOOL_29611 

:DSKOOL_29589
05EB: assign_car " + _198 + @" to_path " + _247 + @" 
43@ = 3 
34@ = 2 

:DSKOOL_29611
if 
  34@ == 2 
else_jump @DSKOOL_29696 
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_29682 
if 
860E:   not car " + _198 + @" assigned_to_path 
else_jump @DSKOOL_29675 
43@ = 1 
34@ = 4 

:DSKOOL_29675
jump @DSKOOL_29696 

:DSKOOL_29682
43@ = 1 
34@ = 4 

:DSKOOL_29696
if 
  34@ == 3 
else_jump @DSKOOL_29728 
43@ = 1 
34@ = 4 

:DSKOOL_29728
if 
  34@ == 4 
else_jump @DSKOOL_29946 
if 
  43@ == 2 
else_jump @DSKOOL_29946 
if 
  " + _247 + @" == 14 
else_jump @DSKOOL_29803 
if 
   not Car.Wrecked(" + _196 + @")
else_jump @DSKOOL_29803 
05EC: release_car " + _196 + @" from_path 

:DSKOOL_29803
05EC: release_car " + _198 + @" from_path 
Car.Destroy(" + _198 + @")
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
Actor.DestroyInstantly(55@)
Actor.DestroyInstantly(56@)
Car.Destroy(" + _196 + @")
Car.Destroy(" + _197 + @")
Car.Destroy(" + _198 + @")
Object.Destroy(57@)
Object.Destroy(58@)
Object.Destroy(59@)
0873: release_path 1 
0873: release_path 2 
0873: release_path 3 
0873: release_path 4 
0873: release_path 5 
0873: release_path 7 
0873: release_path 9 
0873: release_path 10 
0873: release_path 11 
0873: release_path 13 
0873: release_path 14 
0873: release_path 15 
0873: release_path 16 
gosub @DSKOOL_35404 
34@ = 0 

:DSKOOL_29946
return 

:DSKOOL_29948
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 

:DSKOOL_30010
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 0 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.52 1.45 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 

:DSKOOL_30068
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 0.8 2.6 
060D: draw_text_shadow 2 rgba 0 0 0 255 
return 

:DSKOOL_30126
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.2 4.0 
060D: draw_text_shadow 3 rgba 0 0 0 255 
0349: set_text_draw_font 3 
return 

:DSKOOL_30188
fade 0 500 

:DSKOOL_30195
if 
fading 
else_jump @DSKOOL_30219 
wait 0 
jump @DSKOOL_30195 

:DSKOOL_30219
if 
  " + _247 + @" == 16 
else_jump @DSKOOL_30258 
01EB: set_traffic_density_multiplier_to 1.0 
03DE: set_pedestrians_density_multiplier_to 1.0 
jump @DSKOOL_30272 

:DSKOOL_30258
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 

:DSKOOL_30272
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
set_weather 6 
select_interior 0 
0860: link_actor " + PlayerActor + @" to_interior 0 
04FA: reset_sky_colors_with_fade 0 
return 

:DSKOOL_30297
" + _309 + @" = 0.0 
" + _310 + @" = 0.0 
" + _311 + @" = 0.0 
" + _312 + @" = 0.0 
" + _313 + @" = 0.0 
" + _314 + @" = 0.0 
" + _315 + @" = 0.0 
" + _316 + @" = 0.0 
" + _317 + @" = 0.0 
" + _318 + @" = 0.0 
" + _319 + @" = 0.0 
" + _320 + @" = 0.0 
" + _321 + @" = 0.0 
" + _322 + @" = 0.0 
" + _323 + @" = 0.0 
" + _324 + @" = 0.0 
" + _12 + @" = 0 
" + _277 + @" = 0.0 
" + _278 + @" = 0.0 
" + _282 + @" = 0.0 
" + _283 + @" = 0.0 
" + _284 + @" = 0.0 
" + _285 + @" = 10.0 
" + _249 + @" = 0 
" + _280 + @" = 0.0 
" + _281 + @" = 0.0 
" + _330 + @" = 0.0 
" + _331 + @" = 0.0 
" + _332 + @" = 0.0 
" + _333 + @" = 0 
" + _261 + @" = 0 
" + _262 + @" = 0 
" + _303 + @" = 0.0 
" + _304 + @" = 0.0 
" + _305 + @" = 0.0 
" + _306 + @" = 0.0 
" + _326 + @" = 0 
" + _266 + @" = 0 
" + _250 + @" = 0.0 
" + _251 + @" = 0.0 
" + _252 + @" = 0 
" + _260 + @" = 0 
" + _325 + @" = 0 
" + _254 + @" = 0 
" + _286 + @" = 0 
" + _287 + @" = 0 
" + _289 + @" = 0 
" + _290 + @" = 0 
" + _292 + @" = 0 
" + _293 + @" = 0 
" + _295 + @" = 0 
" + _296 + @" = 0 
" + _298 + @" = 0 
" + _299 + @" = 0 
" + _288 + @" = 0 
" + _291 + @" = 0 
" + _294 + @" = 0 
" + _297 + @" = 0 
" + _300 + @" = 0 
" + _301 + @" = 0 
" + _302 + @" = 0 
" + Current_Flight_Record + @" = 0 
" + _269 + @" = 0 
0086: " + _255 + @" = " + _307 + @" 
0086: " + _256 + @" = " + _308 + @" 
02CE: " + _257 + @" = ground_z_at " + _255 + @" " + _256 + @" 50.0 
" + _268 + @" = 0 
" + _259 + @" = 0.0 
" + _267 + @" = 0 
" + _270 + @" = 0 
" + _263 + @" = 0 
" + _264 + @" = 0 
" + _265 + @" = 0 
" + _272 + @" = 0 
" + _273 + @" = 0 
" + _276 + @" = 0.0 
" + _274 + @" = 0 
" + _275 + @" = 0 
" + _279 + @" = 0.0 
36@ = 0.0 
37@ = 0 
38@ = 0 
41@ = 0 
40@ = 0 
return 

:DSKOOL_31009
036A: put_actor " + PlayerActor + @" in_car " + _198 + @" 
Car.DoorStatus(" + _198 + @") = 4
wait 0 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
Player.ClearWantedLevel(" + PlayerChar + @")
fade 1 500 

:DSKOOL_31044
if 
fading 
else_jump @DSKOOL_31068 
wait 0 
jump @DSKOOL_31044 

:DSKOOL_31068
Player.CanMove(" + PlayerChar + @") = True
return 

:DSKOOL_31077
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_31144 
if 
  " + _249 + @" == 1 
else_jump @DSKOOL_31137 
if 
   not Actor.InCar(" + PlayerActor + @", " + _198 + @")
else_jump @DSKOOL_31137 
" + _325 + @" = 1 

:DSKOOL_31137
jump @DSKOOL_31181 

:DSKOOL_31144
if 
02BF:   car " + _198 + @" sunk 
else_jump @DSKOOL_31174 
" + _325 + @" = 2 
jump @DSKOOL_31181 

:DSKOOL_31174
" + _325 + @" = 1 

:DSKOOL_31181
return 

:DSKOOL_31183
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_31226 
if 
   Actor.InCar(" + PlayerActor + @", " + _198 + @")
else_jump @DSKOOL_31226 
02E3: " + _250 + @" = car " + _198 + @" speed 

:DSKOOL_31226
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @DSKOOL_31501 
if 
  " + _250 + @" > 0.5 
else_jump @DSKOOL_31501 
00BE: text_clear_all 
if or
  " + _247 + @" == 10 
  " + _247 + @" == 12 
  " + _247 + @" == 13 
  " + _247 + @" == 5 
  " + _247 + @" == 3 
  " + _247 + @" == 4 
else_jump @DSKOOL_31339 
014E: start_timer_at " + _253 + @" count_in_direction 1 
0890: enable_sound_when_timer " + _253 + @" reach 3 seconds 

:DSKOOL_31339
if or
  " + _247 + @" == 15 
  " + _247 + @" == 8 
  " + _247 + @" == 9 
  " + _247 + @" == 2 
  " + _247 + @" == 1 
else_jump @DSKOOL_31399 
014E: start_timer_at " + _253 + @" count_in_direction 1 
0890: enable_sound_when_timer " + _253 + @" reach 3 seconds 

:DSKOOL_31399
if or
  " + _247 + @" == 6 
  " + _247 + @" == 7 
  " + _247 + @" == 16 
else_jump @DSKOOL_31438 
014E: start_timer_at " + _253 + @" count_in_direction 0 

:DSKOOL_31438
if 
  " + _247 + @" == 14 
else_jump @DSKOOL_31494 
if 
   not Car.Wrecked(" + _196 + @")
else_jump @DSKOOL_31494 
Car.SetSpeedInstantly(" + _196 + @", 6.0)
Car.SetAnimation(" + _196 + @", 9, 864000000)

:DSKOOL_31494
" + _249 + @" = 1 

:DSKOOL_31501
return 

:DSKOOL_31503
if 
  " + _253 + @" == 0 
else_jump @DSKOOL_31535 
Player.CanMove(" + PlayerChar + @") = False
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 

:DSKOOL_31535
return 

:DSKOOL_31537
Player.CanMove(" + PlayerChar + @") = False
Car.LockInCurrentPosition(" + _198 + @") = True
0396: pause_timer 1 
097A: play_audio_at 0.0 0.0 0.0 event 1183 
return 

:DSKOOL_31577
Car.StorePos(" + _198 + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: " + _259 + @" = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY " + _255 + @" " + _256 + @" 
if 
  " + _259 + @" > 0.5 
else_jump @DSKOOL_31714 
if 
  10.0 > " + _259 + @" 
else_jump @DSKOOL_31700 
" + _259 + @" -= 0.5 
" + _259 + @" *= 10.42 
008C: " + _273 + @" = float " + _259 + @" to_integer 
" + _267 + @" = 100 
0060: " + _267 + @" -= " + _273 + @" 
jump @DSKOOL_31707 

:DSKOOL_31700
" + _267 + @" = 0 

:DSKOOL_31707
jump @DSKOOL_31721 

:DSKOOL_31714
" + _267 + @" = 100 

:DSKOOL_31721
0058: " + Current_Flight_Record + @" += " + _267 + @" 
return 

:DSKOOL_31731
" + _260 + @" = Car.Health(" + _198 + @")
" + _268 + @" = 1000 
0060: " + _268 + @" -= " + _260 + @" 
if 
  " + _247 + @" == 16 
else_jump @DSKOOL_31787 
" + _268 + @" /= 10 
jump @DSKOOL_31794 

:DSKOOL_31787
" + _268 + @" /= 2 

:DSKOOL_31794
if 
  " + _268 + @" > 100 
else_jump @DSKOOL_31819 
" + _268 + @" = 100 

:DSKOOL_31819
return 

:DSKOOL_31821
" + _272 + @" = 0 
" + _200 + @" = 0 
if 
  " + _247 + @" == 1 
else_jump @DSKOOL_31912 

:DSKOOL_31853
if 
  15 > " + _200 + @" 
else_jump @DSKOOL_31912 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_31898 
" + _272 + @" += 10 

:DSKOOL_31898
" + _200 + @" += 1 
jump @DSKOOL_31853 

:DSKOOL_31912
if 
  " + _247 + @" == 2 
else_jump @DSKOOL_31989 

:DSKOOL_31930
if 
  25 > " + _200 + @" 
else_jump @DSKOOL_31989 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_31975 
" + _272 + @" += 10 

:DSKOOL_31975
" + _200 + @" += 1 
jump @DSKOOL_31930 

:DSKOOL_31989
if or
  " + _247 + @" == 3 
  " + _247 + @" == 4 
else_jump @DSKOOL_32073 

:DSKOOL_32014
if 
  46 > " + _200 + @" 
else_jump @DSKOOL_32073 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_32059 
" + _272 + @" += 10 

:DSKOOL_32059
" + _200 + @" += 1 
jump @DSKOOL_32014 

:DSKOOL_32073
if 
  " + _247 + @" == 5 
else_jump @DSKOOL_32150 

:DSKOOL_32091
if 
  37 > " + _200 + @" 
else_jump @DSKOOL_32150 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_32136 
" + _272 + @" += 10 

:DSKOOL_32136
" + _200 + @" += 1 
jump @DSKOOL_32091 

:DSKOOL_32150
if or
  " + _247 + @" == 6 
  " + _247 + @" == 7 
else_jump @DSKOOL_32234 

:DSKOOL_32175
if 
  42 > " + _200 + @" 
else_jump @DSKOOL_32234 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_32220 
" + _272 + @" += 10 

:DSKOOL_32220
" + _200 + @" += 1 
jump @DSKOOL_32175 

:DSKOOL_32234
if or
  " + _247 + @" == 8 
  " + _247 + @" == 9 
else_jump @DSKOOL_32318 

:DSKOOL_32259
if 
  30 > " + _200 + @" 
else_jump @DSKOOL_32318 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_32304 
" + _272 + @" += 10 

:DSKOOL_32304
" + _200 + @" += 1 
jump @DSKOOL_32259 

:DSKOOL_32318
if or
  " + _247 + @" == 12 
  " + _247 + @" == 13 
else_jump @DSKOOL_32402 

:DSKOOL_32343
if 
  31 > " + _200 + @" 
else_jump @DSKOOL_32402 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @DSKOOL_32388 
" + _272 + @" += 10 

:DSKOOL_32388
" + _200 + @" += 1 
jump @DSKOOL_32343 

:DSKOOL_32402
" + _272 + @" *= 2 
if 
  " + _272 + @" > 90 
else_jump @DSKOOL_32434 
" + _272 + @" = 100 

:DSKOOL_32434
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
return 

:DSKOOL_32444
if 
  1 > " + Current_Flight_Record + @" 
else_jump @DSKOOL_32469 
" + Current_Flight_Record + @" = 0 

:DSKOOL_32469
00BE: text_clear_all 
return 

:DSKOOL_32473
if 
   not Car.Wrecked(" + _198 + @")
else_jump @DSKOOL_32924 
if 
  " + _333 + @" == 0 
else_jump @DSKOOL_32669 
Car.StorePos(" + _198 + @", " + _330 + @", " + _331 + @", " + _332 + @")
" + _332 + @" += 5.0 
0407: store_coords_to " + _330 + @" " + _331 + @" " + tempvar_Float_3 + @" from_car " + _198 + @" with_offset 15.0 0.0 5.0 
Camera.SetPosition(" + _330 + @", " + _331 + @", " + _332 + @", 0.0, 0.0, 0.0)
0A39: get_vehicle_camera_mode_to 60@ 
if or
  60@ == 1 
  60@ == 2 
  60@ == 3 
else_jump @DSKOOL_32639 
Camera.OnVehicle(" + _198 + @", 15, 1)
jump @DSKOOL_32648 

:DSKOOL_32639
Camera.OnVehicle(" + _198 + @", 15, 2)

:DSKOOL_32648
0460: set_camera_transverse_delay 50.0 time 2000 
09EC: set_garages_leave_camera_alone 1 
" + _333 + @" = 1 

:DSKOOL_32669
if 
  32@ > 3000 
else_jump @DSKOOL_32806 
if 
  6000 > 32@ 
else_jump @DSKOOL_32806 
if 
  " + _333 + @" == 1 
else_jump @DSKOOL_32806 
0407: store_coords_to " + _330 + @" " + _331 + @" " + tempvar_Float_3 + @" from_car " + _198 + @" with_offset 0.0 15.0 5.0 
Camera.SetPosition(" + _330 + @", " + _331 + @", " + _332 + @", 0.0, 0.0, 0.0)
Camera.OnVehicle(" + _198 + @", 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
" + _333 + @" = 2 

:DSKOOL_32806
if 
  32@ > 6000 
else_jump @DSKOOL_32924 
if 
  " + _333 + @" == 2 
else_jump @DSKOOL_32924 
0407: store_coords_to " + _330 + @" " + _331 + @" " + tempvar_Float_3 + @" from_car " + _198 + @" with_offset -15.0 0.0 5.0 
Camera.SetPosition(" + _330 + @", " + _331 + @", " + _332 + @", 0.0, 0.0, 0.0)
Camera.OnVehicle(" + _198 + @", 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
" + _333 + @" = 3 

:DSKOOL_32924
return 

:DSKOOL_32926
45@ = 0 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @DSKOOL_33035 
if 
  85 > " + Current_Flight_Record + @" 
else_jump @DSKOOL_33035 
if and
  47@ > 69 
  85 > 47@ 
else_jump @DSKOOL_33008 
45@ = 0 
jump @DSKOOL_33035 

:DSKOOL_33008
097A: play_audio_at 0.0 0.0 0.0 event 1058 
45@ = 2 

:DSKOOL_33035
if 
  " + Current_Flight_Record + @" > 84 
else_jump @DSKOOL_33137 
if 
  100 > " + Current_Flight_Record + @" 
else_jump @DSKOOL_33137 
if and
  47@ > 84 
  100 > 47@ 
else_jump @DSKOOL_33110 
45@ = 0 
jump @DSKOOL_33137 

:DSKOOL_33110
097A: play_audio_at 0.0 0.0 0.0 event 1058 
45@ = 3 

:DSKOOL_33137
if 
  " + Current_Flight_Record + @" == 100 
else_jump @DSKOOL_33224 
if 
  47@ == 100 
else_jump @DSKOOL_33187 
45@ = 0 
jump @DSKOOL_33224 

:DSKOOL_33187
0624: add 30.0 to_float_stat 160 
097A: play_audio_at 0.0 0.0 0.0 event 1058 
45@ = 4 

:DSKOOL_33224
return 

:DSKOOL_33226
0826: enable_hud 0 
0581: enable_radar 0 
00BE: text_clear_all 
014F: stop_timer " + _253 + @" 
if 
  2 > 45@ 
else_jump @DSKOOL_33299 
0937: text_draw_box_cornerA 160.0 220.0 cornerB 490.0 400.0 GXT_reference 'DS1_65' style 3  
jump @DSKOOL_33332 

:DSKOOL_33299
0937: text_draw_box_cornerA 160.0 200.0 cornerB 490.0 400.0 GXT_reference 'DUMMY' style 3 

:DSKOOL_33332
if or
  " + _247 + @" == 6 
  " + _247 + @" == 7 
  " + _247 + @" == 16 
else_jump @DSKOOL_33640 
gosub @DSKOOL_30010 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 255.0 GXT 'DS1_72'  
gosub @DSKOOL_30010 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
if 
  " + _302 + @" > 9 
else_jump @DSKOOL_33499 
045B: draw_text_2numbers 450.0 255.0 GXT 'DS1_21' numbers " + _301 + @" " + _302 + @"  
jump @DSKOOL_33526 

:DSKOOL_33499
045B: draw_text_2numbers 450.0 255.0 GXT 'DS1_22' numbers " + _301 + @" " + _302 + @"  

:DSKOOL_33526
gosub @DSKOOL_30010 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 275.0 GXT 'DS1_23'  
gosub @DSKOOL_30010 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 450.0 275.0 GXT 'DS1_69' number " + _270 + @"  
jump @DSKOOL_33854 

:DSKOOL_33640
gosub @DSKOOL_30010 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 255.0 GXT 'DS1_5'  
gosub @DSKOOL_30010 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 450.0 255.0 GXT 'DS1_69' number " + _266 + @"  
gosub @DSKOOL_30010 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 275.0 GXT 'DS1_6'  
gosub @DSKOOL_30010 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 450.0 275.0 GXT 'DS1_69' number " + _267 + @"  

:DSKOOL_33854
gosub @DSKOOL_30010 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 295.0 GXT 'DS1_7'  
gosub @DSKOOL_30010 
03E4: set_text_draw_align_right 1 
0904: get_interface 0 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
045A: draw_text_1number 450.0 295.0 GXT 'DS1_70' number " + _272 + @"  
gosub @DSKOOL_30010 
0904: get_interface 3 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 315.0 GXT 'DS1_10'  
gosub @DSKOOL_30010 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 450.0 315.0 GXT 'DS1_69' number " + Current_Flight_Record + @"  
if or
  41@ == 1 
  41@ == 2 
else_jump @DSKOOL_34444 
if 
  45@ > 0 
else_jump @DSKOOL_34444 
038D: draw_texture 4 position 250.0 199.0 size -60.0 60.0 RGBA 180 180 180 255 
038D: draw_texture 4 position 392.0 199.0 size 60.0 60.0 RGBA 180 180 180 255 
if 
  45@ == 2 
else_jump @DSKOOL_34253 
038D: draw_texture 1 position 320.0 200.0 size 110.0 95.0 RGBA 160 160 160 255 

:DSKOOL_34253
if 
  45@ == 3 
else_jump @DSKOOL_34307 
038D: draw_texture 2 position 320.0 200.0 size 110.0 95.0 RGBA 160 160 160 255 

:DSKOOL_34307
if 
  45@ == 4 
else_jump @DSKOOL_34361 
038D: draw_texture 3 position 320.0 200.0 size 110.0 95.0 RGBA 160 160 160 255 

:DSKOOL_34361
gosub @DSKOOL_30126 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.0 3.4 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 323.0 65.0 GXT 'DS1_47'  

:DSKOOL_34444
if or
  41@ == 1 
  41@ == 2 
else_jump @DSKOOL_34536 
gosub @DSKOOL_30126 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.0 3.4 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 323.0 110.0 GXT 'DS1_46'  

:DSKOOL_34536
if 
   not 41@ == 2 
else_jump @DSKOOL_34841 
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 340.0 345.0 GXT 'SCH_PRS'  
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 345.0 GXT 'DS1_66'  
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 340.0 365.0 GXT 'DS1_63'  
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 365.0 GXT 'DS1_53'  
jump @DSKOOL_35035 

:DSKOOL_34841
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 180.0 345.0 GXT 'DS1_71'  
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 340.0 365.0 GXT 'SCH_PRS'  
gosub @DSKOOL_30010 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 51@ 52@ 53@ 54@ 
0340: set_text_draw_RGBA 51@ 52@ 53@ 54@ 
033E: set_draw_text_position 180.0 365.0 GXT 'DS1_66'  

:DSKOOL_35035
return 

:DSKOOL_35037
if 
00E1:   player 0 pressed_key 16 
else_jump @DSKOOL_35093 
if 
  " + _12 + @" == 1 
else_jump @DSKOOL_35086 
" + _12 + @" = 0 
" + _326 + @" = 1 

:DSKOOL_35086
jump @DSKOOL_35118 

:DSKOOL_35093
if 
  " + _12 + @" == 0 
else_jump @DSKOOL_35118 
" + _12 + @" = 1 

:DSKOOL_35118
return 

:DSKOOL_35120
097A: play_audio_at 0.0 0.0 0.0 event 1184 
00BE: text_clear_all 
fade 0 500 

:DSKOOL_35149
if 
fading 
else_jump @DSKOOL_35173 
wait 0 
jump @DSKOOL_35149 

:DSKOOL_35173
00BE: text_clear_all 
03D6: remove_styled_text 'DS1_46'  
03D6: remove_styled_text 'DS1_47'  
09EC: set_garages_leave_camera_alone 0 
0221: set_player " + PlayerChar + @" apply_brakes_to_car 0 
0792: disembark_instantly_actor " + PlayerActor + @" 
if 
  " + _325 + @" == 2 
else_jump @DSKOOL_35291 
00BE: text_clear_all 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @DSKOOL_35270 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at " + _327 + @" " + _328 + @" " + _329 + @" 
jump @DSKOOL_35284 

:DSKOOL_35270
Actor.PutAt(" + PlayerActor + @", " + _327 + @", " + _328 + @", " + _329 + @")

:DSKOOL_35284
jump @DSKOOL_35342 

:DSKOOL_35291
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @DSKOOL_35328 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at " + _327 + @" " + _328 + @" " + _329 + @" 
jump @DSKOOL_35342 

:DSKOOL_35328
Actor.PutAt(" + PlayerActor + @", " + _327 + @", " + _328 + @", " + _329 + @")

:DSKOOL_35342
00BE: text_clear_all 
wait 0 
00BE: text_clear_all 
Car.Destroy(" + _198 + @")
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
00BE: text_clear_all 
wait 0 
00BE: text_clear_all 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
0826: enable_hud 1 
0581: enable_radar 1 
return 

:DSKOOL_35404
00BE: text_clear_all 
" + _200 + @" = 0 

:DSKOOL_35413
if 
  46 > " + _200 + @" 
else_jump @DSKOOL_35456 
00BE: text_clear_all 
Object.Destroy(" + tmp_201 + @"(" + _200 + @",46i))
" + _200 + @" += 1 
jump @DSKOOL_35413 

:DSKOOL_35456
return 

:DSKOOL_35458
" + _200 + @" = 0 
if 
  " + _247 + @" == 1 
else_jump @DSKOOL_35542 

:DSKOOL_35483
if 
  15 > " + _200 + @" 
else_jump @DSKOOL_35542 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35483 

:DSKOOL_35542
if 
  " + _247 + @" == 2 
else_jump @DSKOOL_35619 

:DSKOOL_35560
if 
  25 > " + _200 + @" 
else_jump @DSKOOL_35619 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35560 

:DSKOOL_35619
if or
  " + _247 + @" == 3 
  " + _247 + @" == 4 
else_jump @DSKOOL_35703 

:DSKOOL_35644
if 
  46 > " + _200 + @" 
else_jump @DSKOOL_35703 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35644 

:DSKOOL_35703
if 
  " + _247 + @" == 5 
else_jump @DSKOOL_35780 

:DSKOOL_35721
if 
  37 > " + _200 + @" 
else_jump @DSKOOL_35780 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35721 

:DSKOOL_35780
if or
  " + _247 + @" == 6 
  " + _247 + @" == 7 
else_jump @DSKOOL_35864 

:DSKOOL_35805
if 
  42 > " + _200 + @" 
else_jump @DSKOOL_35864 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35805 

:DSKOOL_35864
if or
  " + _247 + @" == 8 
  " + _247 + @" == 9 
else_jump @DSKOOL_35948 

:DSKOOL_35889
if 
  30 > " + _200 + @" 
else_jump @DSKOOL_35948 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35889 

:DSKOOL_35948
if or
  " + _247 + @" == 12 
  " + _247 + @" == 13 
else_jump @DSKOOL_36032 

:DSKOOL_35973
if 
  31 > " + _200 + @" 
else_jump @DSKOOL_36032 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + _200 + @" += 1 
jump @DSKOOL_35973 

:DSKOOL_36032
if 
  " + _247 + @" == 1 
else_jump @DSKOOL_36736 
" + _285 + @" = 6.0 
" + _279 + @" = 0.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset 0.0 1.0 -0.5 
02CE: " + _284 + @" = ground_z_at " + _280 + @" " + _281 + @" 40.0 
" + _284 + @" += 0.4 

:DSKOOL_36125
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 0.0 
else_jump @DSKOOL_36208 
Object.PutAt(" + tmp_201 + @"[0], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36208
if 
  " + _279 + @" == 24.0 
else_jump @DSKOOL_36243 
Object.PutAt(" + tmp_201 + @"[1], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36243
if 
  " + _279 + @" == 48.0 
else_jump @DSKOOL_36278 
Object.PutAt(" + tmp_201 + @"[2], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36278
if 
  " + _279 + @" == 72.0 
else_jump @DSKOOL_36313 
Object.PutAt(" + tmp_201 + @"[3], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36313
if 
  " + _279 + @" == 96.0 
else_jump @DSKOOL_36348 
Object.PutAt(" + tmp_201 + @"[4], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36348
if 
  " + _279 + @" == 120.0 
else_jump @DSKOOL_36383 
Object.PutAt(" + tmp_201 + @"[5], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36383
if 
  " + _279 + @" == 144.0 
else_jump @DSKOOL_36418 
Object.PutAt(" + tmp_201 + @"[6], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36418
if 
  " + _279 + @" == 168.0 
else_jump @DSKOOL_36453 
Object.PutAt(" + tmp_201 + @"[7], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36453
if 
  " + _279 + @" == 192.0 
else_jump @DSKOOL_36488 
Object.PutAt(" + tmp_201 + @"[8], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36488
if 
  " + _279 + @" == 216.0 
else_jump @DSKOOL_36523 
Object.PutAt(" + tmp_201 + @"[9], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36523
if 
  " + _279 + @" == 240.0 
else_jump @DSKOOL_36558 
Object.PutAt(" + tmp_201 + @"[10], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36558
if 
  " + _279 + @" == 264.0 
else_jump @DSKOOL_36593 
Object.PutAt(" + tmp_201 + @"[11], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36593
if 
  " + _279 + @" == 288.0 
else_jump @DSKOOL_36628 
Object.PutAt(" + tmp_201 + @"[12], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36628
if 
  " + _279 + @" == 312.0 
else_jump @DSKOOL_36663 
Object.PutAt(" + tmp_201 + @"[13], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36663
if 
  " + _279 + @" == 336.0 
else_jump @DSKOOL_36698 
Object.PutAt(" + tmp_201 + @"[14], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36698
" + _279 + @" += 24.0 
if 
  360.0 > " + _279 + @" 
else_jump @DSKOOL_36736 
jump @DSKOOL_36125 

:DSKOOL_36736
if 
  " + _247 + @" == 2 
else_jump @DSKOOL_37625 
" + _285 + @" = 6.0 
" + _279 + @" = 90.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset 0.0 86.0 -0.5 
02CE: " + _284 + @" = ground_z_at " + _280 + @" " + _281 + @" 40.0 
" + _284 + @" += 0.4 

:DSKOOL_36829
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 120.0 
else_jump @DSKOOL_36912 
Object.PutAt(" + tmp_201 + @"[0], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36912
if 
  " + _279 + @" == 150.0 
else_jump @DSKOOL_36947 
Object.PutAt(" + tmp_201 + @"[1], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36947
if 
  " + _279 + @" == 180.0 
else_jump @DSKOOL_36982 
Object.PutAt(" + tmp_201 + @"[2], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_36982
if 
  " + _279 + @" == 210.0 
else_jump @DSKOOL_37017 
Object.PutAt(" + tmp_201 + @"[3], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_37017
if 
  " + _279 + @" == 240.0 
else_jump @DSKOOL_37052 
Object.PutAt(" + tmp_201 + @"[4], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_37052
" + _279 + @" += 30.0 
if 
  271.0 > " + _279 + @" 
else_jump @DSKOOL_37090 
jump @DSKOOL_36829 

:DSKOOL_37090
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset -7.0 74.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset 7.0 74.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset -7.0 78.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset 7.0 78.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset -7.0 82.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset 7.0 82.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset -7.0 86.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset 7.0 86.0 -0.5 
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset 0.0 82.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset -3.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset 3.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[18] relative_to_car " + _198 + @" with_offset -3.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[19] relative_to_car " + _198 + @" with_offset 3.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[20] relative_to_car " + _198 + @" with_offset -3.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[21] relative_to_car " + _198 + @" with_offset 3.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[22] relative_to_car " + _198 + @" with_offset 0.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[23] relative_to_car " + _198 + @" with_offset 0.0 74.0 -0.5 
035C: place_object " + tmp_201 + @"[24] relative_to_car " + _198 + @" with_offset 0.0 78.0 -0.5 
" + _200 + @" = 7 

:DSKOOL_37511
if 
  25 > " + _200 + @" 
else_jump @DSKOOL_37625 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_37611 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_37611
" + _200 + @" += 1 
jump @DSKOOL_37511 

:DSKOOL_37625
if or
  " + _247 + @" == 12 
  " + _247 + @" == 13 
else_jump @DSKOOL_38116 
035C: place_object " + tmp_201 + @"[0] relative_to_car " + _198 + @" with_offset 0.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[1] relative_to_car " + _198 + @" with_offset -3.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[2] relative_to_car " + _198 + @" with_offset 3.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[3] relative_to_car " + _198 + @" with_offset -3.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[4] relative_to_car " + _198 + @" with_offset 3.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[5] relative_to_car " + _198 + @" with_offset -3.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[6] relative_to_car " + _198 + @" with_offset 3.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset -3.0 -8.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset 3.0 -8.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset -3.0 -12.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset 3.0 -12.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset -3.0 -16.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset 3.0 -16.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset -3.0 -20.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset 3.0 -20.0 -0.5 
" + _200 + @" = 0 

:DSKOOL_38002
if 
  15 > " + _200 + @" 
else_jump @DSKOOL_38116 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_38102 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_38102
" + _200 + @" += 1 
jump @DSKOOL_38002 

:DSKOOL_38116
if 
  " + _247 + @" == 12 
else_jump @DSKOOL_38623 
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset -3.0 -24.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset 6.0 -22.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset 0.0 -28.0 -0.5 
035C: place_object " + tmp_201 + @"[18] relative_to_car " + _198 + @" with_offset 8.0 -24.0 -0.5 
035C: place_object " + tmp_201 + @"[19] relative_to_car " + _198 + @" with_offset 3.0 -30.0 -0.5 
035C: place_object " + tmp_201 + @"[20] relative_to_car " + _198 + @" with_offset 10.0 -26.0 -0.5 
035C: place_object " + tmp_201 + @"[21] relative_to_car " + _198 + @" with_offset 4.0 -32.0 -0.5 
035C: place_object " + tmp_201 + @"[22] relative_to_car " + _198 + @" with_offset 10.0 -30.0 -0.5 
035C: place_object " + tmp_201 + @"[23] relative_to_car " + _198 + @" with_offset 9.0 -32.0 -0.5 
035C: place_object " + tmp_201 + @"[24] relative_to_car " + _198 + @" with_offset 4.0 -36.0 -0.5 
035C: place_object " + tmp_201 + @"[25] relative_to_car " + _198 + @" with_offset 9.0 -36.0 -0.5 
035C: place_object " + tmp_201 + @"[26] relative_to_car " + _198 + @" with_offset 4.0 -40.0 -0.5 
035C: place_object " + tmp_201 + @"[27] relative_to_car " + _198 + @" with_offset 9.0 -40.0 -0.5 
035C: place_object " + tmp_201 + @"[28] relative_to_car " + _198 + @" with_offset 4.0 -44.0 -0.5 
035C: place_object " + tmp_201 + @"[29] relative_to_car " + _198 + @" with_offset 9.0 -44.0 -0.5 
035C: place_object " + tmp_201 + @"[30] relative_to_car " + _198 + @" with_offset 6.5 -44.0 -0.5 
" + _200 + @" = 15 

:DSKOOL_38509
if 
  31 > " + _200 + @" 
else_jump @DSKOOL_38623 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_38609 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_38609
" + _200 + @" += 1 
jump @DSKOOL_38509 

:DSKOOL_38623
if 
  " + _247 + @" == 13 
else_jump @DSKOOL_39130 
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset 3.0 -24.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset -6.0 -22.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset 0.0 -28.0 -0.5 
035C: place_object " + tmp_201 + @"[18] relative_to_car " + _198 + @" with_offset -8.0 -24.0 -0.5 
035C: place_object " + tmp_201 + @"[19] relative_to_car " + _198 + @" with_offset -3.0 -30.0 -0.5 
035C: place_object " + tmp_201 + @"[20] relative_to_car " + _198 + @" with_offset -10.0 -26.0 -0.5 
035C: place_object " + tmp_201 + @"[21] relative_to_car " + _198 + @" with_offset -4.0 -32.0 -0.5 
035C: place_object " + tmp_201 + @"[22] relative_to_car " + _198 + @" with_offset -10.0 -30.0 -0.5 
035C: place_object " + tmp_201 + @"[23] relative_to_car " + _198 + @" with_offset -9.0 -32.0 -0.5 
035C: place_object " + tmp_201 + @"[24] relative_to_car " + _198 + @" with_offset -4.0 -36.0 -0.5 
035C: place_object " + tmp_201 + @"[25] relative_to_car " + _198 + @" with_offset -9.0 -36.0 -0.5 
035C: place_object " + tmp_201 + @"[26] relative_to_car " + _198 + @" with_offset -4.0 -40.0 -0.5 
035C: place_object " + tmp_201 + @"[27] relative_to_car " + _198 + @" with_offset -9.0 -40.0 -0.5 
035C: place_object " + tmp_201 + @"[28] relative_to_car " + _198 + @" with_offset -4.0 -44.0 -0.5 
035C: place_object " + tmp_201 + @"[29] relative_to_car " + _198 + @" with_offset -9.0 -44.0 -0.5 
035C: place_object " + tmp_201 + @"[30] relative_to_car " + _198 + @" with_offset -6.5 -44.0 -0.5 
" + _200 + @" = 15 

:DSKOOL_39016
if 
  31 > " + _200 + @" 
else_jump @DSKOOL_39130 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_39116 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39116
" + _200 + @" += 1 
jump @DSKOOL_39016 

:DSKOOL_39130
if or
  " + _247 + @" == 6 
  " + _247 + @" == 7 
else_jump @DSKOOL_40833 
035C: place_object " + tmp_201 + @"[0] relative_to_car " + _198 + @" with_offset -4.0 8.0 -0.5 
035C: place_object " + tmp_201 + @"[1] relative_to_car " + _198 + @" with_offset 4.0 8.0 -0.5 
035C: place_object " + tmp_201 + @"[2] relative_to_car " + _198 + @" with_offset -4.0 2.0 -0.5 
035C: place_object " + tmp_201 + @"[3] relative_to_car " + _198 + @" with_offset 4.0 2.0 -0.5 
035C: place_object " + tmp_201 + @"[4] relative_to_car " + _198 + @" with_offset -4.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[5] relative_to_car " + _198 + @" with_offset -4.0 14.0 -0.5 
035C: place_object " + tmp_201 + @"[6] relative_to_car " + _198 + @" with_offset 4.0 14.0 -0.5 
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset -4.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset 4.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset -4.0 26.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset 4.0 26.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset -4.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset 4.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset -4.0 38.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset 4.0 38.0 -0.5 
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset -4.0 44.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset 4.0 44.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset -4.0 50.0 -0.5 
" + _200 + @" = 0 

:DSKOOL_39576
if 
  18 > " + _200 + @" 
else_jump @DSKOOL_39690 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_39676 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39676
" + _200 + @" += 1 
jump @DSKOOL_39576 

:DSKOOL_39690
" + _279 + @" = 90.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset 4.0 50.0 -0.5 
02CE: " + _284 + @" = ground_z_at " + _280 + @" " + _281 + @" 40.0 
" + _284 + @" += 0.4 

:DSKOOL_39755
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 126.0 
else_jump @DSKOOL_39838 
Object.PutAt(" + tmp_201 + @"[18], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39838
if 
  " + _279 + @" == 144.0 
else_jump @DSKOOL_39873 
Object.PutAt(" + tmp_201 + @"[19], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39873
if 
  " + _279 + @" == 162.0 
else_jump @DSKOOL_39908 
Object.PutAt(" + tmp_201 + @"[20], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39908
if 
  " + _279 + @" == 180.0 
else_jump @DSKOOL_39943 
Object.PutAt(" + tmp_201 + @"[21], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39943
if 
  " + _279 + @" == 198.0 
else_jump @DSKOOL_39978 
Object.PutAt(" + tmp_201 + @"[22], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_39978
if 
  " + _279 + @" == 216.0 
else_jump @DSKOOL_40013 
Object.PutAt(" + tmp_201 + @"[23], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40013
if 
  " + _279 + @" == 234.0 
else_jump @DSKOOL_40048 
Object.PutAt(" + tmp_201 + @"[24], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40048
" + _279 + @" += 18.0 
if 
  271.0 > " + _279 + @" 
else_jump @DSKOOL_40086 
jump @DSKOOL_39755 

:DSKOOL_40086
035C: place_object " + tmp_201 + @"[25] relative_to_car " + _198 + @" with_offset 12.0 8.0 -0.5 
035C: place_object " + tmp_201 + @"[26] relative_to_car " + _198 + @" with_offset 12.0 2.0 -0.5 
035C: place_object " + tmp_201 + @"[27] relative_to_car " + _198 + @" with_offset 12.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[28] relative_to_car " + _198 + @" with_offset 12.0 14.0 -0.5 
035C: place_object " + tmp_201 + @"[29] relative_to_car " + _198 + @" with_offset 12.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[30] relative_to_car " + _198 + @" with_offset 12.0 26.0 -0.5 
035C: place_object " + tmp_201 + @"[31] relative_to_car " + _198 + @" with_offset 12.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[32] relative_to_car " + _198 + @" with_offset 12.0 38.0 -0.5 
035C: place_object " + tmp_201 + @"[33] relative_to_car " + _198 + @" with_offset 12.0 44.0 -0.5 
035C: place_object " + tmp_201 + @"[34] relative_to_car " + _198 + @" with_offset 12.0 50.0 -0.5 
" + _200 + @" = 25 

:DSKOOL_40323
if 
  35 > " + _200 + @" 
else_jump @DSKOOL_40437 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_40423 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40423
" + _200 + @" += 1 
jump @DSKOOL_40323 

:DSKOOL_40437
" + _279 + @" = 270.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset 4.0 -4.0 -0.5 
02CE: " + _284 + @" = ground_z_at " + _280 + @" " + _281 + @" 40.0 
" + _284 + @" += 0.4 

:DSKOOL_40502
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 306.0 
else_jump @DSKOOL_40585 
Object.PutAt(" + tmp_201 + @"[35], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40585
if 
  " + _279 + @" == 324.0 
else_jump @DSKOOL_40620 
Object.PutAt(" + tmp_201 + @"[36], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40620
if 
  " + _279 + @" == 342.0 
else_jump @DSKOOL_40655 
Object.PutAt(" + tmp_201 + @"[37], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40655
if 
  " + _279 + @" == 360.0 
else_jump @DSKOOL_40690 
Object.PutAt(" + tmp_201 + @"[38], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40690
if 
  " + _279 + @" == 378.0 
else_jump @DSKOOL_40725 
Object.PutAt(" + tmp_201 + @"[39], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40725
if 
  " + _279 + @" == 396.0 
else_jump @DSKOOL_40760 
Object.PutAt(" + tmp_201 + @"[40], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40760
if 
  " + _279 + @" == 414.0 
else_jump @DSKOOL_40795 
Object.PutAt(" + tmp_201 + @"[41], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_40795
" + _279 + @" += 18.0 
if 
  451.0 > " + _279 + @" 
else_jump @DSKOOL_40833 
jump @DSKOOL_40502 

:DSKOOL_40833
if 
  " + _247 + @" == 5 
else_jump @DSKOOL_41823 
035C: place_object " + tmp_201 + @"[0] relative_to_car " + _198 + @" with_offset 2.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[1] relative_to_car " + _198 + @" with_offset -2.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[2] relative_to_car " + _198 + @" with_offset 3.0 44.0 -0.5 
035C: place_object " + tmp_201 + @"[3] relative_to_car " + _198 + @" with_offset -3.0 44.0 -0.5 
035C: place_object " + tmp_201 + @"[4] relative_to_car " + _198 + @" with_offset 3.0 48.0 -0.5 
035C: place_object " + tmp_201 + @"[5] relative_to_car " + _198 + @" with_offset -3.0 48.0 -0.5 
035C: place_object " + tmp_201 + @"[6] relative_to_car " + _198 + @" with_offset 3.0 52.0 -0.5 
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset -3.0 52.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset 3.0 56.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset -3.0 56.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset 4.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset -2.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset 5.0 64.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset -1.0 64.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset 6.0 68.0 -0.5 
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset 0.0 68.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset 6.0 72.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset 0.0 72.0 -0.5 
035C: place_object " + tmp_201 + @"[18] relative_to_car " + _198 + @" with_offset 6.0 76.0 -0.5 
035C: place_object " + tmp_201 + @"[19] relative_to_car " + _198 + @" with_offset 0.0 76.0 -0.5 
035C: place_object " + tmp_201 + @"[20] relative_to_car " + _198 + @" with_offset 6.0 80.0 -0.5 
035C: place_object " + tmp_201 + @"[21] relative_to_car " + _198 + @" with_offset 0.0 80.0 -0.5 
035C: place_object " + tmp_201 + @"[22] relative_to_car " + _198 + @" with_offset 5.0 84.0 -0.5 
035C: place_object " + tmp_201 + @"[23] relative_to_car " + _198 + @" with_offset -1.0 84.0 -0.5 
035C: place_object " + tmp_201 + @"[24] relative_to_car " + _198 + @" with_offset 4.0 88.0 -0.5 
035C: place_object " + tmp_201 + @"[25] relative_to_car " + _198 + @" with_offset -2.0 88.0 -0.5 
035C: place_object " + tmp_201 + @"[26] relative_to_car " + _198 + @" with_offset 3.0 92.0 -0.5 
035C: place_object " + tmp_201 + @"[27] relative_to_car " + _198 + @" with_offset -3.0 92.0 -0.5 
035C: place_object " + tmp_201 + @"[28] relative_to_car " + _198 + @" with_offset 3.0 96.0 -0.5 
035C: place_object " + tmp_201 + @"[29] relative_to_car " + _198 + @" with_offset -3.0 96.0 -0.5 
035C: place_object " + tmp_201 + @"[30] relative_to_car " + _198 + @" with_offset 3.0 100.0 -0.5 
035C: place_object " + tmp_201 + @"[31] relative_to_car " + _198 + @" with_offset -3.0 100.0 -0.5 
035C: place_object " + tmp_201 + @"[32] relative_to_car " + _198 + @" with_offset 3.0 104.0 -0.5 
035C: place_object " + tmp_201 + @"[33] relative_to_car " + _198 + @" with_offset -3.0 104.0 -0.5 
035C: place_object " + tmp_201 + @"[34] relative_to_car " + _198 + @" with_offset 3.0 108.0 -0.5 
035C: place_object " + tmp_201 + @"[35] relative_to_car " + _198 + @" with_offset -3.0 108.0 -0.5 
035C: place_object " + tmp_201 + @"[36] relative_to_car " + _198 + @" with_offset 0.0 108.0 -0.5 
" + _200 + @" = 0 

:DSKOOL_41709
if 
  37 > " + _200 + @" 
else_jump @DSKOOL_41823 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_41809 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_41809
" + _200 + @" += 1 
jump @DSKOOL_41709 

:DSKOOL_41823
if or
  " + _247 + @" == 3 
  " + _247 + @" == 4 
else_jump @DSKOOL_42619 
035C: place_object " + tmp_201 + @"[0] relative_to_car " + _198 + @" with_offset -4.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[1] relative_to_car " + _198 + @" with_offset 4.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[2] relative_to_car " + _198 + @" with_offset -4.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[3] relative_to_car " + _198 + @" with_offset 4.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[4] relative_to_car " + _198 + @" with_offset -4.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[5] relative_to_car " + _198 + @" with_offset 4.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[6] relative_to_car " + _198 + @" with_offset 0.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset -4.0 8.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset 4.0 8.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset -4.0 12.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset 4.0 12.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset -4.0 16.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset 4.0 16.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset -4.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset 4.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset -4.0 24.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset 4.0 24.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset -4.0 28.0 -0.5 
035C: place_object " + tmp_201 + @"[18] relative_to_car " + _198 + @" with_offset 4.0 28.0 -0.5 
035C: place_object " + tmp_201 + @"[19] relative_to_car " + _198 + @" with_offset -4.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[20] relative_to_car " + _198 + @" with_offset 4.0 32.0 -0.5 
" + _200 + @" = 0 

:DSKOOL_42338
if 
  21 > " + _200 + @" 
else_jump @DSKOOL_42452 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_42438 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42438
" + _200 + @" += 1 
jump @DSKOOL_42338 

:DSKOOL_42452
" + _279 + @" = 90.0 
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_42516 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset 4.0 30.0 -0.5 
jump @DSKOOL_42545 

:DSKOOL_42516
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset -4.0 30.0 -0.5 

:DSKOOL_42545
02CE: " + _284 + @" = ground_z_at " + _280 + @" " + _281 + @" 40.0 
" + _284 + @" += 0.4 

:DSKOOL_42571
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 

:DSKOOL_42619
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_42742 
if 
  " + _279 + @" == 126.0 
else_jump @DSKOOL_42672 
Object.PutAt(" + tmp_201 + @"[21], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42672
if 
  " + _279 + @" == 144.0 
else_jump @DSKOOL_42707 
Object.PutAt(" + tmp_201 + @"[22], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42707
if 
  " + _279 + @" == 162.0 
else_jump @DSKOOL_42742 
Object.PutAt(" + tmp_201 + @"[23], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42742
if 
  " + _247 + @" == 4 
else_jump @DSKOOL_42865 
if 
  " + _279 + @" == 198.0 
else_jump @DSKOOL_42795 
Object.PutAt(" + tmp_201 + @"[21], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42795
if 
  " + _279 + @" == 216.0 
else_jump @DSKOOL_42830 
Object.PutAt(" + tmp_201 + @"[22], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42830
if 
  " + _279 + @" == 234.0 
else_jump @DSKOOL_42865 
Object.PutAt(" + tmp_201 + @"[23], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42865
if or
  " + _247 + @" == 3 
  " + _247 + @" == 4 
else_jump @DSKOOL_43016 
if 
  " + _279 + @" == 180.0 
else_jump @DSKOOL_42925 
Object.PutAt(" + tmp_201 + @"[24], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_42925
" + _279 + @" += 18.0 
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_42988 
if 
  181.0 > " + _279 + @" 
else_jump @DSKOOL_42981 
jump @DSKOOL_42571 

:DSKOOL_42981
jump @DSKOOL_43016 

:DSKOOL_42988
if 
  235.0 > " + _279 + @" 
else_jump @DSKOOL_43016 
jump @DSKOOL_42571 

:DSKOOL_43016
if 
  " + _247 + @" == 3 
else_jump @DSKOOL_43638 
035C: place_object " + tmp_201 + @"[25] relative_to_car " + _198 + @" with_offset 8.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[26] relative_to_car " + _198 + @" with_offset 8.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[27] relative_to_car " + _198 + @" with_offset 12.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[28] relative_to_car " + _198 + @" with_offset 12.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[29] relative_to_car " + _198 + @" with_offset 16.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[30] relative_to_car " + _198 + @" with_offset 16.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[31] relative_to_car " + _198 + @" with_offset 20.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[32] relative_to_car " + _198 + @" with_offset 20.0 33.0 -0.5 
035C: place_object " + tmp_201 + @"[33] relative_to_car " + _198 + @" with_offset 24.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[34] relative_to_car " + _198 + @" with_offset 24.0 33.0 -0.5 
035C: place_object " + tmp_201 + @"[35] relative_to_car " + _198 + @" with_offset 28.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[36] relative_to_car " + _198 + @" with_offset 28.0 34.0 -0.5 
035C: place_object " + tmp_201 + @"[37] relative_to_car " + _198 + @" with_offset 32.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[38] relative_to_car " + _198 + @" with_offset 32.0 34.0 -0.5 
035C: place_object " + tmp_201 + @"[39] relative_to_car " + _198 + @" with_offset 36.0 39.0 -0.5 
035C: place_object " + tmp_201 + @"[40] relative_to_car " + _198 + @" with_offset 36.0 35.0 -0.5 
035C: place_object " + tmp_201 + @"[41] relative_to_car " + _198 + @" with_offset 40.0 39.0 -0.5 
035C: place_object " + tmp_201 + @"[42] relative_to_car " + _198 + @" with_offset 40.0 35.0 -0.5 
035C: place_object " + tmp_201 + @"[43] relative_to_car " + _198 + @" with_offset 44.0 39.0 -0.5 
035C: place_object " + tmp_201 + @"[44] relative_to_car " + _198 + @" with_offset 44.0 35.0 -0.5 
035C: place_object " + tmp_201 + @"[45] relative_to_car " + _198 + @" with_offset 44.0 37.0 -0.5 
" + _200 + @" = 25 

:DSKOOL_43524
if 
  46 > " + _200 + @" 
else_jump @DSKOOL_43638 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_43624 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_43624
" + _200 + @" += 1 
jump @DSKOOL_43524 

:DSKOOL_43638
if 
  " + _247 + @" == 4 
else_jump @DSKOOL_44260 
035C: place_object " + tmp_201 + @"[25] relative_to_car " + _198 + @" with_offset -8.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[26] relative_to_car " + _198 + @" with_offset -8.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[27] relative_to_car " + _198 + @" with_offset -12.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[28] relative_to_car " + _198 + @" with_offset -12.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[29] relative_to_car " + _198 + @" with_offset -16.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[30] relative_to_car " + _198 + @" with_offset -16.0 32.0 -0.5 
035C: place_object " + tmp_201 + @"[31] relative_to_car " + _198 + @" with_offset -20.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[32] relative_to_car " + _198 + @" with_offset -20.0 33.0 -0.5 
035C: place_object " + tmp_201 + @"[33] relative_to_car " + _198 + @" with_offset -24.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[34] relative_to_car " + _198 + @" with_offset -24.0 33.0 -0.5 
035C: place_object " + tmp_201 + @"[35] relative_to_car " + _198 + @" with_offset -28.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[36] relative_to_car " + _198 + @" with_offset -28.0 34.0 -0.5 
035C: place_object " + tmp_201 + @"[37] relative_to_car " + _198 + @" with_offset -32.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[38] relative_to_car " + _198 + @" with_offset -32.0 34.0 -0.5 
035C: place_object " + tmp_201 + @"[39] relative_to_car " + _198 + @" with_offset -36.0 39.0 -0.5 
035C: place_object " + tmp_201 + @"[40] relative_to_car " + _198 + @" with_offset -36.0 35.0 -0.5 
035C: place_object " + tmp_201 + @"[41] relative_to_car " + _198 + @" with_offset -40.0 39.0 -0.5 
035C: place_object " + tmp_201 + @"[42] relative_to_car " + _198 + @" with_offset -40.0 35.0 -0.5 
035C: place_object " + tmp_201 + @"[43] relative_to_car " + _198 + @" with_offset -44.0 39.0 -0.5 
035C: place_object " + tmp_201 + @"[44] relative_to_car " + _198 + @" with_offset -44.0 35.0 -0.5 
035C: place_object " + tmp_201 + @"[45] relative_to_car " + _198 + @" with_offset -44.0 37.0 -0.5 
" + _200 + @" = 25 

:DSKOOL_44146
if 
  46 > " + _200 + @" 
else_jump @DSKOOL_44260 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_44246 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_44246
" + _200 + @" += 1 
jump @DSKOOL_44146 

:DSKOOL_44260
if 
  " + _247 + @" == 8 
else_jump @DSKOOL_44744 
035C: place_object " + tmp_201 + @"[0] relative_to_car " + _198 + @" with_offset -8.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[1] relative_to_car " + _198 + @" with_offset -6.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[2] relative_to_car " + _198 + @" with_offset -4.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[3] relative_to_car " + _198 + @" with_offset -2.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[4] relative_to_car " + _198 + @" with_offset 0.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[5] relative_to_car " + _198 + @" with_offset 7.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[6] relative_to_car " + _198 + @" with_offset 5.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset 3.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset 1.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset -1.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset -8.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset -6.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset -4.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset -2.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset 0.0 60.0 -0.5 
" + _200 + @" = 0 

:DSKOOL_44630
if 
  15 > " + _200 + @" 
else_jump @DSKOOL_44744 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_44730 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_44730
" + _200 + @" += 1 
jump @DSKOOL_44630 

:DSKOOL_44744
if 
  " + _247 + @" == 9 
else_jump @DSKOOL_45228 
035C: place_object " + tmp_201 + @"[0] relative_to_car " + _198 + @" with_offset 7.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[1] relative_to_car " + _198 + @" with_offset 5.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[2] relative_to_car " + _198 + @" with_offset 3.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[3] relative_to_car " + _198 + @" with_offset 1.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[4] relative_to_car " + _198 + @" with_offset -1.0 20.0 -0.5 
035C: place_object " + tmp_201 + @"[5] relative_to_car " + _198 + @" with_offset -8.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[6] relative_to_car " + _198 + @" with_offset -6.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[7] relative_to_car " + _198 + @" with_offset -4.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[8] relative_to_car " + _198 + @" with_offset -2.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[9] relative_to_car " + _198 + @" with_offset 0.0 40.0 -0.5 
035C: place_object " + tmp_201 + @"[10] relative_to_car " + _198 + @" with_offset 7.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[11] relative_to_car " + _198 + @" with_offset 5.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[12] relative_to_car " + _198 + @" with_offset 3.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[13] relative_to_car " + _198 + @" with_offset 1.0 60.0 -0.5 
035C: place_object " + tmp_201 + @"[14] relative_to_car " + _198 + @" with_offset -1.0 60.0 -0.5 
" + _200 + @" = 0 

:DSKOOL_45114
if 
  15 > " + _200 + @" 
else_jump @DSKOOL_45228 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_45214 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45214
" + _200 + @" += 1 
jump @DSKOOL_45114 

:DSKOOL_45228
if or
  " + _247 + @" == 8 
  " + _247 + @" == 9 
else_jump @DSKOOL_45964 
" + _285 + @" = 8.0 
" + _279 + @" = 90.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car " + _198 + @" with_offset -0.5 81.0 -0.5 
02CE: " + _284 + @" = ground_z_at " + _280 + @" " + _281 + @" 40.0 
" + _284 + @" += 0.4 

:DSKOOL_45328
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 90.0 
else_jump @DSKOOL_45411 
Object.PutAt(" + tmp_201 + @"[23], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45411
if 
  " + _279 + @" == 120.0 
else_jump @DSKOOL_45446 
Object.PutAt(" + tmp_201 + @"[24], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45446
if 
  " + _279 + @" == 150.0 
else_jump @DSKOOL_45481 
Object.PutAt(" + tmp_201 + @"[25], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45481
if 
  " + _279 + @" == 180.0 
else_jump @DSKOOL_45516 
Object.PutAt(" + tmp_201 + @"[26], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45516
if 
  " + _279 + @" == 210.0 
else_jump @DSKOOL_45551 
Object.PutAt(" + tmp_201 + @"[27], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45551
if 
  " + _279 + @" == 240.0 
else_jump @DSKOOL_45586 
Object.PutAt(" + tmp_201 + @"[28], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45586
if 
  " + _279 + @" == 270.0 
else_jump @DSKOOL_45621 
Object.PutAt(" + tmp_201 + @"[29], " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45621
" + _279 + @" += 30.0 
if 
  271.0 > " + _279 + @" 
else_jump @DSKOOL_45659 
jump @DSKOOL_45328 

:DSKOOL_45659
035C: place_object " + tmp_201 + @"[15] relative_to_car " + _198 + @" with_offset 0.0 80.0 -0.5 
035C: place_object " + tmp_201 + @"[16] relative_to_car " + _198 + @" with_offset -3.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[17] relative_to_car " + _198 + @" with_offset 3.0 4.0 -0.5 
035C: place_object " + tmp_201 + @"[18] relative_to_car " + _198 + @" with_offset -3.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[19] relative_to_car " + _198 + @" with_offset 3.0 0.0 -0.5 
035C: place_object " + tmp_201 + @"[20] relative_to_car " + _198 + @" with_offset -3.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[21] relative_to_car " + _198 + @" with_offset 3.0 -4.0 -0.5 
035C: place_object " + tmp_201 + @"[22] relative_to_car " + _198 + @" with_offset 0.0 -4.0 -0.5 
" + _200 + @" = 15 

:DSKOOL_45850
if 
  23 > " + _200 + @" 
else_jump @DSKOOL_45964 
if 
03CA:   object " + tmp_201 + @"(" + _200 + @",46i) exists 
else_jump @DSKOOL_45950 
Object.StorePos(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")
02CE: " + _284 + @" = ground_z_at " + _282 + @" " + _283 + @" 40.0 
" + _284 + @" += 0.4 
Object.PutAt(" + tmp_201 + @"(" + _200 + @",46i), " + _282 + @", " + _283 + @", " + _284 + @")

:DSKOOL_45950
" + _200 + @" += 1 
jump @DSKOOL_45850 

:DSKOOL_45964
return 

:DSKOOL_45966
if 
  61@ == 1 
else_jump @DSKOOL_46059 
if 
001D:   86@ > 62@ 
else_jump @DSKOOL_46031 
gosub @DSKOOL_46227 
gosub @DSKOOL_46334 
gosub @DSKOOL_46488 
jump @DSKOOL_46059 

:DSKOOL_46031
if 
   not Actor.Dead(91@)
else_jump @DSKOOL_46052 
0968: actor 91@ stop_mouth 

:DSKOOL_46052
61@ = 0 

:DSKOOL_46059
return 

:DSKOOL_46061
if 
  61@ == 1 
else_jump @DSKOOL_46196 
05AA: 65@s = 'MEC_D1' 
05AA: 67@s = 'MEC_D2' 
05AA: 69@s = 'MEC_D3' 
05AA: 71@s = 'MEC_D4' 
05AA: 73@s = 'MEC_D5' 
04AF: 79@ = 26002 
04AF: 80@ = 26003 
04AF: 81@ = 26004 
04AF: 82@ = 26005 
04AF: 83@ = 26006 
86@ = 5 

:DSKOOL_46196
0085: 89@ = 62@ 
87@ = 0 
88@ = 0 
90@ = 1 
return 

:DSKOOL_46227
if 
001D:   86@ > 89@ 
else_jump @DSKOOL_46332 
if 
  87@ == 0 
else_jump @DSKOOL_46289 
03CF: load_wav 79@(89@,7i) as 1 
89@ += 1 
87@ = 1 

:DSKOOL_46289
if 
  88@ == 0 
else_jump @DSKOOL_46332 
03CF: load_wav 79@(89@,7i) as 2 
89@ += 1 
88@ = 1 

:DSKOOL_46332
return 

:DSKOOL_46334
if 
  90@ == 1 
else_jump @DSKOOL_46410 
if 
  87@ == 1 
else_jump @DSKOOL_46410 
if 
03D0:   wav 1 loaded 
else_jump @DSKOOL_46410 
03D1: play_wav 1 
00BC: show_text_highpriority GXT 65@(62@,7s) time 4500 flag 1 
87@ = 2 

:DSKOOL_46410
if 
  90@ == 2 
else_jump @DSKOOL_46486 
if 
  88@ == 1 
else_jump @DSKOOL_46486 
if 
03D0:   wav 2 loaded 
else_jump @DSKOOL_46486 
03D1: play_wav 2 
00BC: show_text_highpriority GXT 65@(62@,7s) time 4500 flag 1 
88@ = 2 

:DSKOOL_46486
return 

:DSKOOL_46488
if 
  87@ == 2 
else_jump @DSKOOL_46551 
if 
03D2:   wav 1 ended 
else_jump @DSKOOL_46551 
03D5: remove_text 65@(62@,7s) 
62@ += 1 
90@ = 2 
87@ = 0 

:DSKOOL_46551
if 
  88@ == 2 
else_jump @DSKOOL_46614 
if 
03D2:   wav 2 ended 
else_jump @DSKOOL_46614 
03D5: remove_text 65@(62@,7s) 
62@ += 1 
90@ = 1 
88@ = 0 

:DSKOOL_46614
return" );
            }

        }

    }

}