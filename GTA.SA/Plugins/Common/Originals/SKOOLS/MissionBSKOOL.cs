using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalSkools {

        private sealed class BSKOOL : MissionCustom {

            Int tmp_201 = global( _201.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @BSKOOL_47 
if 
wasted_or_busted 
else_jump @BSKOOL_38 
gosub @BSKOOL_11889 

:BSKOOL_38
gosub @BSKOOL_11990 
end_thread 

:BSKOOL_47
03D5: remove_text 'M_FAIL'  
if 
  " + Mission_Driving_School_Passed + @" == 0 
else_jump @BSKOOL_78 
increment_mission_attempts 

:BSKOOL_78
" + OnMission + @" = 1 
054C: use_GXT_table 'BS' 
0169: set_fade_color_RGB 0 0 0 
wait 0 
if 
  " + OnMission + @" == 0 
else_jump @BSKOOL_218 
38@ = Car.Create(#BF400, " + _277 + @", " + _278 + @", " + _257 + @")
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)
" + tmp_201 + @"[20] = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
" + tmp_201 + @"[30] = Object.Init(#TRAFFICCONE, 0.0, 0.0, 100.0)
56@ = Object.Create(#LANDJUMP2, " + _277 + @", " + _278 + @", " + _257 + @")

:BSKOOL_218
34@ = 0 
61@ = 0 
62@ = 0 
57@ = 0 
63@ = 0 
64@ = 0 
65@ = 0 
66@ = 0 
67@ = 0 
51@ = 0 
if 
  " + _2162 + @" == 0 
else_jump @BSKOOL_313 
" + _2162 + @" = 1 

:BSKOOL_313
" + _247 + @" = 1 
" + _307 + @" = 1130.44 
" + _308 + @" = 1341.0 
" + _327 + @" = 1173.93 
" + _328 + @" = 1351.066 
" + _329 + @" = 9.9219 
Actor.PutAt(" + PlayerActor + @", 1171.521, 1351.183, 9.9219)
Model.Load(#BF400)
Model.Load(#FCR900)
Model.Load(#PCJ600)
Model.Load(#TRAFFICCONE)
Model.Load(#LANDJUMP2)
Model.Load(#NRG500)
Model.Load(#SANCHEZ)
Model.Load(#WMYMECH)

:BSKOOL_429
if or
   not Model.Available(#BF400)
   not Model.Available(#FCR900)
   not Model.Available(#PCJ600)
   not Model.Available(#TRAFFICCONE)
   not Model.Available(#LANDJUMP2)
else_jump @BSKOOL_476 
wait 0 
jump @BSKOOL_429 

:BSKOOL_476
if or
   not Model.Available(#SANCHEZ)
   not Model.Available(#WMYMECH)
   not Model.Available(#NRG500)
else_jump @BSKOOL_512 
wait 0 
jump @BSKOOL_476 

:BSKOOL_512
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
Player.CanMove(" + PlayerChar + @") = True
0826: enable_hud 0 
jump @BSKOOL_644 

:BSKOOL_644
Player.CanMove(" + PlayerChar + @") = False
03E6: remove_text_box 
00BE: text_clear_all 
50@ = Player.WantedLevel(" + PlayerChar + @")
Player.ClearWantedLevel(" + PlayerChar + @")
gosub @BSKOOL_16619 
34@ = 0 
57@ = 0 
03F0: enable_text_draw 1 
64@ = 255 
63@ = 2 
if 
  7 > " + _2162 + @" 
else_jump @BSKOOL_734 
008A: " + _247 + @" = 37@ 

:BSKOOL_734
fade 1 500 

:BSKOOL_741
if 
fading 
else_jump @BSKOOL_774 
00BE: text_clear_all 
gosub @BSKOOL_12670 
wait 0 
jump @BSKOOL_741 

:BSKOOL_774
gosub @BSKOOL_12670 
0581: enable_radar 0 

:BSKOOL_785
wait 0 
gosub @BSKOOL_12670 
if 
  51@ == 0 
else_jump @BSKOOL_828 
03CF: load_wav 3800 as 3 
51@ = 1 

:BSKOOL_828
if 
  51@ == 1 
else_jump @BSKOOL_868 
if 
03D0:   wav 3 loaded 
else_jump @BSKOOL_868 
51@ = 2 

:BSKOOL_868
if 
  51@ == 2 
else_jump @BSKOOL_897 
03D1: play_wav 3 
51@ = 3 

:BSKOOL_897
if 
  57@ == 0 
else_jump @BSKOOL_1394 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if or
  -100 > " + Move_Axis_X + @" 
00E1:   player 0 pressed_key 10 
else_jump @BSKOOL_1012 
37@ -= 1 
" + _247 + @" -= 1 
if 
  " + _2162 + @" > 1 
else_jump @BSKOOL_1012 
if 
  4 > 34@ 
else_jump @BSKOOL_1012 
34@ = 3 

:BSKOOL_1012
if or
  " + Move_Axis_X + @" > 100 
00E1:   player 0 pressed_key 11 
else_jump @BSKOOL_1093 
37@ += 1 
" + _247 + @" += 1 
if 
  " + _2162 + @" > 1 
else_jump @BSKOOL_1093 
if 
  4 > 34@ 
else_jump @BSKOOL_1093 
34@ = 3 

:BSKOOL_1093
if 
  1 > " + _247 + @" 
else_jump @BSKOOL_1127 
0084: " + _247 + @" = " + _2162 + @" 
008B: 37@ = " + _2162 + @" 

:BSKOOL_1127
if 
001C:   " + _247 + @" > " + _2162 + @" 
else_jump @BSKOOL_1160 
37@ = 1 
" + _247 + @" = 1 

:BSKOOL_1160
if 
00E1:   player 0 pressed_key 10 
else_jump @BSKOOL_1195 
wait 0 
gosub @BSKOOL_12670 
jump @BSKOOL_1160 

:BSKOOL_1195
if 
00E1:   player 0 pressed_key 11 
else_jump @BSKOOL_1230 
wait 0 
gosub @BSKOOL_12670 
jump @BSKOOL_1195 

:BSKOOL_1230
if 
  -100 > " + Move_Axis_X + @" 
else_jump @BSKOOL_1282 
wait 0 
gosub @BSKOOL_12670 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @BSKOOL_1230 

:BSKOOL_1282
if 
  " + Move_Axis_X + @" > 100 
else_jump @BSKOOL_1334 
wait 0 
gosub @BSKOOL_12670 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
jump @BSKOOL_1282 

:BSKOOL_1334
if 
00E1:   player 0 pressed_key 16 
else_jump @BSKOOL_1394 
if 
  4 > 34@ 
else_jump @BSKOOL_1376 
34@ = 3 

:BSKOOL_1376
040D: unload_wav 3 
51@ = 0 
jump @BSKOOL_1639 

:BSKOOL_1394
if 
0735:   is_keyboard_key_pressed 81 
else_jump @BSKOOL_1416 
" + _2162 + @" = 6 

:BSKOOL_1416
if 
0735:   is_keyboard_key_pressed 53 
else_jump @BSKOOL_1480 
" + _2162 + @" = 6 
" + _2164 + @" = 100 
" + _2165 + @" = 100 
" + _2166 + @" = 100 
" + _2167 + @" = 100 
" + _2168 + @" = 100 
" + _2169 + @" = 100 

:BSKOOL_1480
if and
  " + _2164 + @" > 69 
  " + _2165 + @" > 69 
  " + _2166 + @" > 69 
  " + _2167 + @" > 69 
  " + _2168 + @" > 69 
  " + _2169 + @" > 69 
else_jump @BSKOOL_1540 
" + _2170 + @" = 1 

:BSKOOL_1540
if 
  " + Mission_Driving_School_Passed + @" == 0 
else_jump @BSKOOL_1590 
if 
  " + _2170 + @" == 1 
else_jump @BSKOOL_1590 
gosub @BSKOOL_20609 
jump @BSKOOL_11917 

:BSKOOL_1590
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_1625 
040D: unload_wav 3 
51@ = 0 
jump @BSKOOL_11889 

:BSKOOL_1625
gosub @BSKOOL_15809 
jump @BSKOOL_785 

:BSKOOL_1639
fade 0 500 

:BSKOOL_1646
if 
fading 
else_jump @BSKOOL_1677 
gosub @BSKOOL_12670 
wait 0 
jump @BSKOOL_1646 

:BSKOOL_1677
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_1698 
05EC: release_car 38@ from_path 

:BSKOOL_1698
Car.Destroy(38@)
Actor.DestroyInstantly(49@)
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
Car.Destroy(38@)
gosub @BSKOOL_20948 
34@ = 5 
0581: enable_radar 1 
if 
  " + _247 + @" == 1 
else_jump @BSKOOL_3452 

:BSKOOL_1776
gosub @BSKOOL_16582 

:BSKOOL_1783
" + _258 + @" = 180.0 
" + _253 + @" = 16000 
35@ = 181 
gosub @BSKOOL_16619 
38@ = Car.Create(#BF400, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(38@) = 180.0
gosub @BSKOOL_21019 
if 
  34@ == 0 
else_jump @BSKOOL_1939 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_1896 
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)

:BSKOOL_1896
Camera.SetPosition(1125.66, 1334.4, 22.5, 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 2)
return 

:BSKOOL_1939
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car 38@ with_offset 0.0 0.0 0.0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BS_A_1' time 5000 flag 4  
gosub @BSKOOL_17341 

:BSKOOL_1993
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_2028 
48@ = 2 
jump @BSKOOL_3392 

:BSKOOL_2028
gosub @BSKOOL_17408 
if 
  48@ == 1 
else_jump @BSKOOL_2060 
jump @BSKOOL_11889 

:BSKOOL_2060
if 
  " + _249 + @" == 0 
else_jump @BSKOOL_2108 
00BC: show_text_highpriority GXT 'BS_A_1' time 5000 flag 4  
gosub @BSKOOL_17484 
jump @BSKOOL_3445 

:BSKOOL_2108
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_3445 
gosub @BSKOOL_17642 
" + _258 + @" = Car.Angle(38@)
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_2213 
if 
  " + _258 + @" > 80.0 
else_jump @BSKOOL_2213 
if 
  90.0 > " + _258 + @" 
else_jump @BSKOOL_2213 
" + _274 + @" = 1 
58@ = 1 

:BSKOOL_2213
if 
  58@ == 1 
else_jump @BSKOOL_2432 
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_2298 
if 
  " + _258 + @" > 350.0 
else_jump @BSKOOL_2298 
if 
  360.0 > " + _258 + @" 
else_jump @BSKOOL_2298 
" + _274 + @" = 2 

:BSKOOL_2298
if 
  " + _274 + @" == 2 
else_jump @BSKOOL_2365 
if 
  " + _258 + @" > 270.0 
else_jump @BSKOOL_2365 
if 
  280.0 > " + _258 + @" 
else_jump @BSKOOL_2365 
" + _274 + @" = 3 

:BSKOOL_2365
if 
  " + _274 + @" == 3 
else_jump @BSKOOL_2432 
if 
  " + _258 + @" > 170.0 
else_jump @BSKOOL_2432 
if 
  180.0 > " + _258 + @" 
else_jump @BSKOOL_2432 
" + _274 + @" = 4 

:BSKOOL_2432
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_2506 
if 
  " + _258 + @" > 270.0 
else_jump @BSKOOL_2506 
if 
  280.0 > " + _258 + @" 
else_jump @BSKOOL_2506 
58@ = 2 
" + _274 + @" = 1 

:BSKOOL_2506
if 
  58@ == 2 
else_jump @BSKOOL_2725 
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_2591 
if 
  " + _258 + @" > 350.0 
else_jump @BSKOOL_2591 
if 
  360.0 > " + _258 + @" 
else_jump @BSKOOL_2591 
" + _274 + @" = 2 

:BSKOOL_2591
if 
  " + _274 + @" == 2 
else_jump @BSKOOL_2658 
if 
  " + _258 + @" > 80.0 
else_jump @BSKOOL_2658 
if 
  90.0 > " + _258 + @" 
else_jump @BSKOOL_2658 
" + _274 + @" = 3 

:BSKOOL_2658
if 
  " + _274 + @" == 3 
else_jump @BSKOOL_2725 
if 
  " + _258 + @" > 170.0 
else_jump @BSKOOL_2725 
if 
  180.0 > " + _258 + @" 
else_jump @BSKOOL_2725 
" + _274 + @" = 4 

:BSKOOL_2725
if or
80E1:   not player 0 pressed_key 16 
80E1:   not player 0 pressed_key 14 
   not Actor.InCar(" + PlayerActor + @", 38@)
  " + _253 + @" == 0 
else_jump @BSKOOL_3445 
gosub @BSKOOL_17676 
gosub @BSKOOL_17689 
if 
  " + _274 + @" == 4 
else_jump @BSKOOL_2802 
" + _266 + @" = 100 

:BSKOOL_2802
if 
  " + _274 + @" == 3 
else_jump @BSKOOL_2827 
" + _266 + @" = 75 

:BSKOOL_2827
if 
  " + _274 + @" == 2 
else_jump @BSKOOL_2852 
" + _266 + @" = 50 

:BSKOOL_2852
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_2877 
" + _266 + @" = 25 

:BSKOOL_2877
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_2902 
" + _266 + @" = 0 

:BSKOOL_2902
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @BSKOOL_2950 
" + Current_Flight_Record + @" = 0 

:BSKOOL_2950
gosub @BSKOOL_17933 
gosub @BSKOOL_18311 
if 
001C:   " + Current_Flight_Record + @" > " + _2166 + @" 
else_jump @BSKOOL_3170 
008B: 67@ = " + _2166 + @" 
0084: " + _2166 + @" = " + Current_Flight_Record + @" 
59@ = 1 
gosub @BSKOOL_18775 
if 
  65@ == 4 
else_jump @BSKOOL_3070 
if 
  " + _2173 + @" == 0 
else_jump @BSKOOL_3070 
" + _2173 + @" = 1 
" + _2172 + @" = 1 
" + _2171 + @" = 1 

:BSKOOL_3070
if 
  65@ == 3 
else_jump @BSKOOL_3120 
if 
  " + _2172 + @" == 0 
else_jump @BSKOOL_3120 
" + _2172 + @" = 1 
" + _2171 + @" = 1 

:BSKOOL_3120
if 
  65@ == 2 
else_jump @BSKOOL_3163 
if 
  " + _2171 + @" == 0 
else_jump @BSKOOL_3163 
" + _2171 + @" = 1 

:BSKOOL_3163
jump @BSKOOL_3177 

:BSKOOL_3170
65@ = 0 

:BSKOOL_3177
if 
  " + _2162 + @" == 1 
else_jump @BSKOOL_3261 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_3261 
59@ = 2 
" + _2162 + @" = 2 
48@ = 2 
37@ += 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1185 

:BSKOOL_3261
32@ = 0 

:BSKOOL_3268
if 
  32@ > -1 
else_jump @BSKOOL_3392 
wait 0 
gosub @BSKOOL_18340 
if 
   not 59@ == 2 
else_jump @BSKOOL_3346 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_3346 
48@ = 2 
jump @BSKOOL_3392 

:BSKOOL_3346
gosub @BSKOOL_19005 
gosub @BSKOOL_20526 
if 
  " + _326 + @" == 1 
else_jump @BSKOOL_3385 
jump @BSKOOL_3392 

:BSKOOL_3385
jump @BSKOOL_3268 

:BSKOOL_3392
gosub @BSKOOL_20609 
gosub @BSKOOL_20948 
if 
  48@ == 2 
else_jump @BSKOOL_3438 
jump @BSKOOL_644 
jump @BSKOOL_3445 

:BSKOOL_3438
jump @BSKOOL_1776 

:BSKOOL_3445
jump @BSKOOL_1993 

:BSKOOL_3452
if 
  " + _247 + @" == 2 
else_jump @BSKOOL_4877 

:BSKOOL_3470
gosub @BSKOOL_16582 

:BSKOOL_3477
" + _258 + @" = 0.0 
" + _253 + @" = 11000 
35@ = 182 
gosub @BSKOOL_16619 
38@ = Car.Create(#PCJ600, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(38@) = 180.0
gosub @BSKOOL_21019 
if 
  34@ == 0 
else_jump @BSKOOL_3633 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_3590 
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)

:BSKOOL_3590
Camera.SetPosition(1130.66, 1264.4, 14.5, 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 2)
return 

:BSKOOL_3633
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset -2.0 82.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset 2.0 88.0 0.0 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car 38@ with_offset 0.0 0.0 0.0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BS_B_1' time 5000 flag 4  
gosub @BSKOOL_17341 

:BSKOOL_3745
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_3780 
48@ = 2 
jump @BSKOOL_4817 

:BSKOOL_3780
if 
  " + _249 + @" == 0 
else_jump @BSKOOL_3828 
00BC: show_text_highpriority GXT 'BS_B_1' time 5000 flag 4  
gosub @BSKOOL_17484 
jump @BSKOOL_4870 

:BSKOOL_3828
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_4870 
gosub @BSKOOL_17642 
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_3906 
if 
00B0:   car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_3906 
" + _274 + @" = 1 

:BSKOOL_3906
if or
01C1:   car 38@ stopped 
   not Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_4870 
gosub @BSKOOL_17676 
gosub @BSKOOL_17689 
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_3969 
" + _267 + @" = 0 

:BSKOOL_3969
42@ = Car.Angle(38@)
0092: 39@ = float 42@ to_integer 
if 
  39@ == 0 
else_jump @BSKOOL_4017 
" + _266 + @" = 100 
jump @BSKOOL_4302 

:BSKOOL_4017
if 
  39@ == 360 
else_jump @BSKOOL_4050 
" + _266 + @" = 100 
jump @BSKOOL_4302 

:BSKOOL_4050
if 
  39@ > 0 
else_jump @BSKOOL_4093 
if 
  21 > 39@ 
else_jump @BSKOOL_4093 
" + _266 + @" = 100 

:BSKOOL_4093
if 
  39@ > 179 
else_jump @BSKOOL_4172 
if 
  340 > 39@ 
else_jump @BSKOOL_4172 
39@ -= 180 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.62 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @BSKOOL_4302 

:BSKOOL_4172
if 
  39@ > 339 
else_jump @BSKOOL_4217 
if 
  360 > 39@ 
else_jump @BSKOOL_4217 
" + _266 + @" = 100 

:BSKOOL_4217
if 
  39@ > 20 
else_jump @BSKOOL_4302 
if 
  180 > 39@ 
else_jump @BSKOOL_4302 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.62 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @BSKOOL_4302 

:BSKOOL_4302
if 
  1 > " + _266 + @" 
else_jump @BSKOOL_4327 
" + _266 + @" = 0 

:BSKOOL_4327
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @BSKOOL_4375 
" + Current_Flight_Record + @" = 0 

:BSKOOL_4375
gosub @BSKOOL_17933 
gosub @BSKOOL_18311 
if 
001C:   " + Current_Flight_Record + @" > " + _2167 + @" 
else_jump @BSKOOL_4595 
008B: 67@ = " + _2167 + @" 
0084: " + _2167 + @" = " + Current_Flight_Record + @" 
59@ = 1 
gosub @BSKOOL_18775 
if 
  65@ == 4 
else_jump @BSKOOL_4495 
if 
  " + _2176 + @" == 0 
else_jump @BSKOOL_4495 
" + _2176 + @" = 1 
" + _2175 + @" = 1 
" + _2174 + @" = 1 

:BSKOOL_4495
if 
  65@ == 3 
else_jump @BSKOOL_4545 
if 
  " + _2175 + @" == 0 
else_jump @BSKOOL_4545 
" + _2175 + @" = 1 
" + _2174 + @" = 1 

:BSKOOL_4545
if 
  65@ == 2 
else_jump @BSKOOL_4588 
if 
  " + _2174 + @" == 0 
else_jump @BSKOOL_4588 
" + _2174 + @" = 1 

:BSKOOL_4588
jump @BSKOOL_4602 

:BSKOOL_4595
65@ = 0 

:BSKOOL_4602
if 
  " + _2162 + @" == 2 
else_jump @BSKOOL_4686 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_4686 
59@ = 2 
" + _2162 + @" = 3 
48@ = 2 
37@ += 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1185 

:BSKOOL_4686
32@ = 0 

:BSKOOL_4693
if 
  32@ > -1 
else_jump @BSKOOL_4817 
wait 0 
gosub @BSKOOL_18340 
if 
   not 59@ == 2 
else_jump @BSKOOL_4771 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_4771 
48@ = 2 
jump @BSKOOL_4817 

:BSKOOL_4771
gosub @BSKOOL_19005 
gosub @BSKOOL_20526 
if 
  " + _326 + @" == 1 
else_jump @BSKOOL_4810 
jump @BSKOOL_4817 

:BSKOOL_4810
jump @BSKOOL_4693 

:BSKOOL_4817
gosub @BSKOOL_20609 
gosub @BSKOOL_20948 
if 
  48@ == 2 
else_jump @BSKOOL_4863 
jump @BSKOOL_644 
jump @BSKOOL_4870 

:BSKOOL_4863
jump @BSKOOL_3470 

:BSKOOL_4870
jump @BSKOOL_3745 

:BSKOOL_4877
if 
  " + _247 + @" == 3 
else_jump @BSKOOL_6645 

:BSKOOL_4895
gosub @BSKOOL_16582 

:BSKOOL_4902
" + _258 + @" = 180.0 
" + _253 + @" = 9000 
35@ = 183 
gosub @BSKOOL_16619 
38@ = Car.Create(#FCR900, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(38@) = 180.0
gosub @BSKOOL_21019 
if 
  34@ == 0 
else_jump @BSKOOL_5058 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_5015 
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)

:BSKOOL_5015
Camera.SetPosition(1125.66, 1283.4, 10.5, 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 2)
return 

:BSKOOL_5058
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset -3.5 56.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset 3.5 84.0 0.0 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car 38@ with_offset 0.0 124.0 0.0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BS_C_1' time 5000 flag 4  
gosub @BSKOOL_17341 

:BSKOOL_5170
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_5205 
48@ = 2 
jump @BSKOOL_6585 

:BSKOOL_5205
if 
  " + _249 + @" == 0 
else_jump @BSKOOL_5253 
00BC: show_text_highpriority GXT 'BS_C_1' time 5000 flag 4  
gosub @BSKOOL_17484 
jump @BSKOOL_6638 

:BSKOOL_5253
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_6638 
gosub @BSKOOL_17642 
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_5331 
if 
00B0:   car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_5331 
" + _274 + @" = 1 

:BSKOOL_5331
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_5472 
if 
80B0:   not car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_5449 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if or
0024:   " + tempvar_X_coord + @" > " + _309 + @" 
0024:   " + _311 + @" > " + tempvar_X_coord + @" 
0024:   " + tempvar_Y_coord + @" > " + _310 + @" 
else_jump @BSKOOL_5442 
gosub @BSKOOL_17676 
jump @BSKOOL_5449 

:BSKOOL_5442
" + _274 + @" = 2 

:BSKOOL_5449
if 
87F1:   not player " + PlayerChar + @" performing_wheelie 
else_jump @BSKOOL_5472 
gosub @BSKOOL_17676 

:BSKOOL_5472
42@ = Car.Angle(38@)
0087: 44@ = 42@ 
if 
   not 44@ == 0.0 
else_jump @BSKOOL_5622 
if and
  360.0 > 44@ 
  44@ > 180.0 
else_jump @BSKOOL_5550 
44@ += 0.1 

:BSKOOL_5550
if 
  44@ == 360.0 
else_jump @BSKOOL_5581 
  44@ > 0.0 

:BSKOOL_5581
if and
  180.0 >= 44@ 
  44@ > 0.0 
else_jump @BSKOOL_5622 
44@ -= 0.1 

:BSKOOL_5622
if or
01C1:   car 38@ stopped 
   not Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_6638 
gosub @BSKOOL_17676 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_5701 
gosub @BSKOOL_17689 
jump @BSKOOL_5708 

:BSKOOL_5701
" + _267 + @" = 0 

:BSKOOL_5708
42@ = Car.Angle(38@)
0092: 39@ = float 42@ to_integer 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_6056 
if 
  39@ == 0 
else_jump @BSKOOL_5774 
" + _266 + @" = 0 
jump @BSKOOL_6070 

:BSKOOL_5774
if 
  39@ == 180 
else_jump @BSKOOL_5807 
" + _266 + @" = 100 
jump @BSKOOL_6070 

:BSKOOL_5807
if 
  39@ == 360 
else_jump @BSKOOL_5840 
" + _266 + @" = 0 
jump @BSKOOL_6070 

:BSKOOL_5840
if 
  39@ > 0 
else_jump @BSKOOL_5910 
if 
  175 > 39@ 
else_jump @BSKOOL_5910 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @BSKOOL_6070 

:BSKOOL_5910
if 
  39@ > 174 
else_jump @BSKOOL_5955 
if 
  186 > 39@ 
else_jump @BSKOOL_5955 
" + _266 + @" = 100 

:BSKOOL_5955
if 
  39@ > 185 
else_jump @BSKOOL_6049 
if 
  360 > 39@ 
else_jump @BSKOOL_6049 
39@ -= 180 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @BSKOOL_6070 

:BSKOOL_6049
jump @BSKOOL_6070 

:BSKOOL_6056
" + _266 + @" = 0 
jump @BSKOOL_6070 

:BSKOOL_6070
if 
  1 > " + _266 + @" 
else_jump @BSKOOL_6095 
" + _266 + @" = 0 

:BSKOOL_6095
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @BSKOOL_6143 
" + Current_Flight_Record + @" = 0 

:BSKOOL_6143
gosub @BSKOOL_17933 
gosub @BSKOOL_18311 
if 
001C:   " + Current_Flight_Record + @" > " + _2164 + @" 
else_jump @BSKOOL_6363 
008B: 67@ = " + _2164 + @" 
0084: " + _2164 + @" = " + Current_Flight_Record + @" 
59@ = 1 
gosub @BSKOOL_18775 
if 
  65@ == 4 
else_jump @BSKOOL_6263 
if 
  " + _2179 + @" == 0 
else_jump @BSKOOL_6263 
" + _2179 + @" = 1 
" + _2178 + @" = 1 
" + _2177 + @" = 1 

:BSKOOL_6263
if 
  65@ == 3 
else_jump @BSKOOL_6313 
if 
  " + _2178 + @" == 0 
else_jump @BSKOOL_6313 
" + _2178 + @" = 1 
" + _2177 + @" = 1 

:BSKOOL_6313
if 
  65@ == 2 
else_jump @BSKOOL_6356 
if 
  " + _2177 + @" == 0 
else_jump @BSKOOL_6356 
" + _2177 + @" = 1 

:BSKOOL_6356
jump @BSKOOL_6370 

:BSKOOL_6363
65@ = 0 

:BSKOOL_6370
if 
  " + _2162 + @" == 3 
else_jump @BSKOOL_6454 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_6454 
59@ = 2 
" + _2162 + @" = 4 
48@ = 2 
37@ += 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1185 

:BSKOOL_6454
32@ = 0 

:BSKOOL_6461
if 
  32@ > -1 
else_jump @BSKOOL_6585 
wait 0 
gosub @BSKOOL_18340 
if 
   not 59@ == 2 
else_jump @BSKOOL_6539 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_6539 
48@ = 2 
jump @BSKOOL_6585 

:BSKOOL_6539
gosub @BSKOOL_19005 
gosub @BSKOOL_20526 
if 
  " + _326 + @" == 1 
else_jump @BSKOOL_6578 
jump @BSKOOL_6585 

:BSKOOL_6578
jump @BSKOOL_6461 

:BSKOOL_6585
gosub @BSKOOL_20948 
gosub @BSKOOL_20609 
if 
  48@ == 2 
else_jump @BSKOOL_6631 
jump @BSKOOL_644 
jump @BSKOOL_6638 

:BSKOOL_6631
jump @BSKOOL_4895 

:BSKOOL_6638
jump @BSKOOL_5170 

:BSKOOL_6645
if 
  " + _247 + @" == 5 
else_jump @BSKOOL_8421 

:BSKOOL_6663
gosub @BSKOOL_16582 

:BSKOOL_6670
" + _258 + @" = 180.0 
" + _253 + @" = 9000 
35@ = 184 
gosub @BSKOOL_16619 
38@ = Car.Create(#FCR900, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(38@) = 180.0
gosub @BSKOOL_21019 
if 
  34@ == 0 
else_jump @BSKOOL_6826 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_6783 
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)

:BSKOOL_6783
Camera.SetPosition(1125.66, 1283.4, 10.5, 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 2)
return 

:BSKOOL_6826
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset -3.5 56.0 0.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset 3.5 84.0 0.0 
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car 38@ with_offset 0.0 124.0 0.0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BS_D_1' time 5000 flag 4  
gosub @BSKOOL_17341 

:BSKOOL_6938
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_6973 
48@ = 2 
jump @BSKOOL_8361 

:BSKOOL_6973
if 
  " + _249 + @" == 0 
else_jump @BSKOOL_7021 
00BC: show_text_highpriority GXT 'BS_D_1' time 5000 flag 4  
gosub @BSKOOL_17484 
jump @BSKOOL_8414 

:BSKOOL_7021
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_8414 
gosub @BSKOOL_17642 
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_7099 
if 
00B0:   car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_7099 
" + _274 + @" = 1 

:BSKOOL_7099
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_7240 
if 
80B0:   not car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_7217 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if or
0024:   " + tempvar_X_coord + @" > " + _309 + @" 
0024:   " + _311 + @" > " + tempvar_X_coord + @" 
0024:   " + tempvar_Y_coord + @" > " + _310 + @" 
else_jump @BSKOOL_7210 
gosub @BSKOOL_17676 
jump @BSKOOL_7217 

:BSKOOL_7210
" + _274 + @" = 2 

:BSKOOL_7217
if 
87F2:   not player " + PlayerChar + @" performing_stoppie 
else_jump @BSKOOL_7240 
gosub @BSKOOL_17676 

:BSKOOL_7240
42@ = Car.Angle(38@)
0087: 44@ = 42@ 
if 
   not 44@ == 0.0 
else_jump @BSKOOL_7390 
if and
  360.0 > 44@ 
  44@ > 180.0 
else_jump @BSKOOL_7318 
44@ += 0.1 

:BSKOOL_7318
if 
  44@ == 360.0 
else_jump @BSKOOL_7349 
  44@ > 0.0 

:BSKOOL_7349
if and
  180.0 >= 44@ 
  44@ > 0.0 
else_jump @BSKOOL_7390 
44@ -= 0.1 

:BSKOOL_7390
02E3: 43@ = car 38@ speed 
if or
01C1:   car 38@ stopped 
   not Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_8414 
gosub @BSKOOL_17676 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_7477 
gosub @BSKOOL_17689 
jump @BSKOOL_7484 

:BSKOOL_7477
" + _267 + @" = 0 

:BSKOOL_7484
42@ = Car.Angle(38@)
0092: 39@ = float 42@ to_integer 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_7832 
if 
  39@ == 0 
else_jump @BSKOOL_7550 
" + _266 + @" = 0 
jump @BSKOOL_7846 

:BSKOOL_7550
if 
  39@ == 180 
else_jump @BSKOOL_7583 
" + _266 + @" = 100 
jump @BSKOOL_7846 

:BSKOOL_7583
if 
  39@ == 360 
else_jump @BSKOOL_7616 
" + _266 + @" = 0 
jump @BSKOOL_7846 

:BSKOOL_7616
if 
  39@ > 0 
else_jump @BSKOOL_7686 
if 
  175 > 39@ 
else_jump @BSKOOL_7686 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @BSKOOL_7846 

:BSKOOL_7686
if 
  39@ > 174 
else_jump @BSKOOL_7731 
if 
  186 > 39@ 
else_jump @BSKOOL_7731 
" + _266 + @" = 100 

:BSKOOL_7731
if 
  39@ > 185 
else_jump @BSKOOL_7825 
if 
  360 > 39@ 
else_jump @BSKOOL_7825 
39@ -= 180 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @BSKOOL_7846 

:BSKOOL_7825
jump @BSKOOL_7846 

:BSKOOL_7832
" + _266 + @" = 0 
jump @BSKOOL_7846 

:BSKOOL_7846
if 
  1 > " + _266 + @" 
else_jump @BSKOOL_7871 
" + _266 + @" = 0 

:BSKOOL_7871
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @BSKOOL_7919 
" + Current_Flight_Record + @" = 0 

:BSKOOL_7919
gosub @BSKOOL_17933 
gosub @BSKOOL_18311 
if 
001C:   " + Current_Flight_Record + @" > " + _2165 + @" 
else_jump @BSKOOL_8139 
008B: 67@ = " + _2165 + @" 
0084: " + _2165 + @" = " + Current_Flight_Record + @" 
59@ = 1 
gosub @BSKOOL_18775 
if 
  65@ == 4 
else_jump @BSKOOL_8039 
if 
  " + _2185 + @" == 0 
else_jump @BSKOOL_8039 
" + _2185 + @" = 1 
" + _2184 + @" = 1 
" + _2183 + @" = 1 

:BSKOOL_8039
if 
  65@ == 3 
else_jump @BSKOOL_8089 
if 
  " + _2184 + @" == 0 
else_jump @BSKOOL_8089 
" + _2184 + @" = 1 
" + _2183 + @" = 1 

:BSKOOL_8089
if 
  65@ == 2 
else_jump @BSKOOL_8132 
if 
  " + _2183 + @" == 0 
else_jump @BSKOOL_8132 
" + _2183 + @" = 1 

:BSKOOL_8132
jump @BSKOOL_8146 

:BSKOOL_8139
65@ = 0 

:BSKOOL_8146
if 
  " + _2162 + @" == 5 
else_jump @BSKOOL_8230 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_8230 
59@ = 2 
" + _2162 + @" = 6 
48@ = 2 
37@ += 1 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1185 

:BSKOOL_8230
32@ = 0 

:BSKOOL_8237
if 
  32@ > -1 
else_jump @BSKOOL_8361 
wait 0 
gosub @BSKOOL_18340 
if 
   not 59@ == 2 
else_jump @BSKOOL_8315 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_8315 
48@ = 2 
jump @BSKOOL_8361 

:BSKOOL_8315
gosub @BSKOOL_19005 
gosub @BSKOOL_20526 
if 
  " + _326 + @" == 1 
else_jump @BSKOOL_8354 
jump @BSKOOL_8361 

:BSKOOL_8354
jump @BSKOOL_8237 

:BSKOOL_8361
gosub @BSKOOL_20948 
gosub @BSKOOL_20609 
if 
  48@ == 2 
else_jump @BSKOOL_8407 
jump @BSKOOL_644 
jump @BSKOOL_8414 

:BSKOOL_8407
jump @BSKOOL_6663 

:BSKOOL_8414
jump @BSKOOL_6938 

:BSKOOL_8421
if 
  " + _247 + @" == 4 
else_jump @BSKOOL_10014 

:BSKOOL_8439
gosub @BSKOOL_16582 

:BSKOOL_8446
" + _258 + @" = 180.0 
" + _253 + @" = 9000 
35@ = 185 
gosub @BSKOOL_16619 
38@ = Car.Create(#SANCHEZ, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(38@) = " + _258 + @"
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset -2.5 46.0 2.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset 2.5 50.0 2.0 
gosub @BSKOOL_21019 
if 
  34@ == 0 
else_jump @BSKOOL_8658 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_8615 
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)

:BSKOOL_8615
Camera.SetPosition(1127.66, 1288.4, 12.75, 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 2)
return 

:BSKOOL_8658
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car 38@ with_offset 0.0 124.0 0.0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BS_E_1' time 5000 flag 4  
gosub @BSKOOL_17341 

:BSKOOL_8712
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_8747 
48@ = 2 
jump @BSKOOL_9954 

:BSKOOL_8747
if 
  " + _249 + @" == 0 
else_jump @BSKOOL_8795 
00BC: show_text_highpriority GXT 'BS_E_1' time 5000 flag 4  
gosub @BSKOOL_17484 
jump @BSKOOL_10007 

:BSKOOL_8795
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_10007 
gosub @BSKOOL_17642 
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_8873 
if 
00B0:   car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_8873 
" + _274 + @" = 1 

:BSKOOL_8873
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_8991 
if 
80B0:   not car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_8991 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if or
0024:   " + tempvar_X_coord + @" > " + _309 + @" 
0024:   " + _311 + @" > " + tempvar_X_coord + @" 
0024:   " + tempvar_Y_coord + @" > " + _310 + @" 
else_jump @BSKOOL_8984 
gosub @BSKOOL_17676 
jump @BSKOOL_8991 

:BSKOOL_8984
" + _274 + @" = 2 

:BSKOOL_8991
if or
01C1:   car 38@ stopped 
   not Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_10007 
gosub @BSKOOL_17676 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_9070 
gosub @BSKOOL_17689 
jump @BSKOOL_9077 

:BSKOOL_9070
" + _267 + @" = 0 

:BSKOOL_9077
42@ = Car.Angle(38@)
0092: 39@ = float 42@ to_integer 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_9425 
if 
  39@ == 0 
else_jump @BSKOOL_9143 
" + _266 + @" = 0 
jump @BSKOOL_9439 

:BSKOOL_9143
if 
  39@ == 180 
else_jump @BSKOOL_9176 
" + _266 + @" = 100 
jump @BSKOOL_9439 

:BSKOOL_9176
if 
  39@ == 360 
else_jump @BSKOOL_9209 
" + _266 + @" = 0 
jump @BSKOOL_9439 

:BSKOOL_9209
if 
  39@ > 0 
else_jump @BSKOOL_9279 
if 
  175 > 39@ 
else_jump @BSKOOL_9279 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @BSKOOL_9439 

:BSKOOL_9279
if 
  39@ > 174 
else_jump @BSKOOL_9324 
if 
  186 > 39@ 
else_jump @BSKOOL_9324 
" + _266 + @" = 100 

:BSKOOL_9324
if 
  39@ > 185 
else_jump @BSKOOL_9418 
if 
  360 > 39@ 
else_jump @BSKOOL_9418 
39@ -= 180 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @BSKOOL_9439 

:BSKOOL_9418
jump @BSKOOL_9439 

:BSKOOL_9425
" + _266 + @" = 0 
jump @BSKOOL_9439 

:BSKOOL_9439
if 
  1 > " + _266 + @" 
else_jump @BSKOOL_9464 
" + _266 + @" = 0 

:BSKOOL_9464
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @BSKOOL_9512 
" + Current_Flight_Record + @" = 0 

:BSKOOL_9512
gosub @BSKOOL_17933 
gosub @BSKOOL_18311 
if 
001C:   " + Current_Flight_Record + @" > " + _2168 + @" 
else_jump @BSKOOL_9732 
008B: 67@ = " + _2168 + @" 
0084: " + _2168 + @" = " + Current_Flight_Record + @" 
59@ = 1 
gosub @BSKOOL_18775 
if 
  65@ == 4 
else_jump @BSKOOL_9632 
if 
  " + _2182 + @" == 0 
else_jump @BSKOOL_9632 
" + _2182 + @" = 1 
" + _2181 + @" = 1 
" + _2180 + @" = 1 

:BSKOOL_9632
if 
  65@ == 3 
else_jump @BSKOOL_9682 
if 
  " + _2181 + @" == 0 
else_jump @BSKOOL_9682 
" + _2181 + @" = 1 
" + _2180 + @" = 1 

:BSKOOL_9682
if 
  65@ == 2 
else_jump @BSKOOL_9725 
if 
  " + _2180 + @" == 0 
else_jump @BSKOOL_9725 
" + _2180 + @" = 1 

:BSKOOL_9725
jump @BSKOOL_9739 

:BSKOOL_9732
65@ = 0 

:BSKOOL_9739
if 
  " + _2162 + @" == 4 
else_jump @BSKOOL_9823 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_9823 
59@ = 2 
" + _2162 + @" = 5 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1185 
48@ = 2 
37@ += 1 

:BSKOOL_9823
32@ = 0 

:BSKOOL_9830
if 
  32@ > -1 
else_jump @BSKOOL_9954 
wait 0 
gosub @BSKOOL_18340 
if 
   not 59@ == 2 
else_jump @BSKOOL_9908 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_9908 
48@ = 2 
jump @BSKOOL_9954 

:BSKOOL_9908
gosub @BSKOOL_19005 
gosub @BSKOOL_20526 
if 
  " + _326 + @" == 1 
else_jump @BSKOOL_9947 
jump @BSKOOL_9954 

:BSKOOL_9947
jump @BSKOOL_9830 

:BSKOOL_9954
gosub @BSKOOL_20609 
gosub @BSKOOL_20948 
if 
  48@ == 2 
else_jump @BSKOOL_10000 
jump @BSKOOL_644 
jump @BSKOOL_10007 

:BSKOOL_10000
jump @BSKOOL_8439 

:BSKOOL_10007
jump @BSKOOL_8712 

:BSKOOL_10014
if 
  " + _247 + @" == 6 
else_jump @BSKOOL_11889 

:BSKOOL_10032
gosub @BSKOOL_16582 

:BSKOOL_10039
" + _258 + @" = 180.0 
" + _253 + @" = 9000 
35@ = 186 
gosub @BSKOOL_16619 
38@ = Car.Create(#NRG500, " + _255 + @", " + _256 + @", " + _257 + @")
Car.Angle(38@) = " + _258 + @"
0407: store_coords_to " + _309 + @" " + _310 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset -2.5 46.0 2.0 
0407: store_coords_to " + _311 + @" " + _312 + @" " + tempvar_Z_coord + @" from_car 38@ with_offset 2.5 52.0 2.0 
gosub @BSKOOL_21019 
if 
  34@ == 0 
else_jump @BSKOOL_10251 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_10208 
49@ = Actor.CreateAsDriver(CivFemale, #WMYMECH, 38@)

:BSKOOL_10208
Camera.SetPosition(1122.66, 1265.4, 15.75, 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 2)
return 

:BSKOOL_10251
0407: store_coords_to " + _305 + @" " + _306 + @" " + _257 + @" from_car 38@ with_offset 0.0 114.0 0.0 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'BS_F_1' time 5000 flag 4  
gosub @BSKOOL_17341 

:BSKOOL_10305
wait 0 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_10340 
48@ = 2 
jump @BSKOOL_11690 

:BSKOOL_10340
if 
  " + _249 + @" == 0 
else_jump @BSKOOL_10388 
00BC: show_text_highpriority GXT 'BS_F_1' time 5000 flag 4  
gosub @BSKOOL_17484 
jump @BSKOOL_11882 

:BSKOOL_10388
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_11882 
gosub @BSKOOL_17642 
if 
  " + _274 + @" == 0 
else_jump @BSKOOL_10466 
if 
00B0:   car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_10466 
" + _274 + @" = 1 

:BSKOOL_10466
if 
  " + _274 + @" == 1 
else_jump @BSKOOL_10584 
if 
80B0:   not car 38@ sphere 0 in_rectangle_cornerA " + _309 + @" " + _310 + @" cornerB " + _311 + @" " + _312 + @" 
else_jump @BSKOOL_10584 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if or
0024:   " + tempvar_X_coord + @" > " + _309 + @" 
0024:   " + _311 + @" > " + tempvar_X_coord + @" 
0024:   " + tempvar_Y_coord + @" > " + _310 + @" 
else_jump @BSKOOL_10577 
gosub @BSKOOL_17676 
jump @BSKOOL_10584 

:BSKOOL_10577
" + _274 + @" = 2 

:BSKOOL_10584
if 
  " + _274 + @" == 2 
else_jump @BSKOOL_10630 
if 
81F3:   not car 38@ in_air 
else_jump @BSKOOL_10630 
01BD: 70@ = current_time_in_ms 
" + _274 + @" = 3 

:BSKOOL_10630
if 
  " + _274 + @" == 3 
else_jump @BSKOOL_10716 
01BD: 69@ = current_time_in_ms 
0085: 68@ = 69@ 
0062: 68@ -= 70@ 
if 
  68@ > 250 
else_jump @BSKOOL_10716 
if or
87F2:   not player " + PlayerChar + @" performing_stoppie 
07F1:   player " + PlayerChar + @" performing_wheelie 
else_jump @BSKOOL_10716 
gosub @BSKOOL_17676 

:BSKOOL_10716
if or
01C1:   car 38@ stopped 
   not Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_11882 
gosub @BSKOOL_17676 
0086: " + _255 + @" = " + _305 + @" 
0086: " + _256 + @" = " + _306 + @" 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_10795 
gosub @BSKOOL_17689 
jump @BSKOOL_10802 

:BSKOOL_10795
" + _267 + @" = 0 

:BSKOOL_10802
42@ = Car.Angle(38@)
0092: 39@ = float 42@ to_integer 
if 
  " + _274 + @" > 0 
else_jump @BSKOOL_11150 
if 
  39@ == 0 
else_jump @BSKOOL_10868 
" + _266 + @" = 0 
jump @BSKOOL_11164 

:BSKOOL_10868
if 
  39@ == 180 
else_jump @BSKOOL_10901 
" + _266 + @" = 100 
jump @BSKOOL_11164 

:BSKOOL_10901
if 
  39@ == 360 
else_jump @BSKOOL_10934 
" + _266 + @" = 0 
jump @BSKOOL_11164 

:BSKOOL_10934
if 
  39@ > 0 
else_jump @BSKOOL_11004 
if 
  175 > 39@ 
else_jump @BSKOOL_11004 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _266 + @" = float " + _276 + @" to_integer 
jump @BSKOOL_11164 

:BSKOOL_11004
if 
  39@ > 174 
else_jump @BSKOOL_11049 
if 
  186 > 39@ 
else_jump @BSKOOL_11049 
" + _266 + @" = 100 

:BSKOOL_11049
if 
  39@ > 185 
else_jump @BSKOOL_11143 
if 
  360 > 39@ 
else_jump @BSKOOL_11143 
39@ -= 180 
0091: " + _276 + @" = integer 39@ to_float 
" + _276 + @" *= 0.56 
008C: " + _273 + @" = float " + _276 + @" to_integer 
" + _266 + @" = 100 
0060: " + _266 + @" -= " + _273 + @" 
jump @BSKOOL_11164 

:BSKOOL_11143
jump @BSKOOL_11164 

:BSKOOL_11150
" + _266 + @" = 0 
jump @BSKOOL_11164 

:BSKOOL_11164
if 
  1 > " + _266 + @" 
else_jump @BSKOOL_11189 
" + _266 + @" = 0 

:BSKOOL_11189
0084: " + Current_Flight_Record + @" = " + _267 + @" 
0058: " + Current_Flight_Record + @" += " + _266 + @" 
" + Current_Flight_Record + @" /= 2 
if 
  " + _267 + @" == 0 
else_jump @BSKOOL_11237 
" + Current_Flight_Record + @" = 0 

:BSKOOL_11237
gosub @BSKOOL_17933 
gosub @BSKOOL_18311 
if 
001C:   " + Current_Flight_Record + @" > " + _2169 + @" 
else_jump @BSKOOL_11457 
008B: 67@ = " + _2169 + @" 
0084: " + _2169 + @" = " + Current_Flight_Record + @" 
59@ = 1 
gosub @BSKOOL_18775 
if 
  65@ == 4 
else_jump @BSKOOL_11357 
if 
  " + _2188 + @" == 0 
else_jump @BSKOOL_11357 
" + _2188 + @" = 1 
" + _2187 + @" = 1 
" + _2186 + @" = 1 

:BSKOOL_11357
if 
  65@ == 3 
else_jump @BSKOOL_11407 
if 
  " + _2187 + @" == 0 
else_jump @BSKOOL_11407 
" + _2187 + @" = 1 
" + _2186 + @" = 1 

:BSKOOL_11407
if 
  65@ == 2 
else_jump @BSKOOL_11450 
if 
  " + _2186 + @" == 0 
else_jump @BSKOOL_11450 
" + _2186 + @" = 1 

:BSKOOL_11450
jump @BSKOOL_11464 

:BSKOOL_11457
65@ = 0 

:BSKOOL_11464
if 
  " + _2170 + @" == 0 
else_jump @BSKOOL_11559 
if 
  " + _2162 + @" == 6 
else_jump @BSKOOL_11559 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_11559 
59@ = 2 
" + _2170 + @" = 1 
48@ = 2 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1185 

:BSKOOL_11559
32@ = 0 

:BSKOOL_11566
if 
  32@ > -1 
else_jump @BSKOOL_11690 
wait 0 
gosub @BSKOOL_18340 
if 
   not 59@ == 2 
else_jump @BSKOOL_11644 
if 
00E1:   player 0 pressed_key 15 
else_jump @BSKOOL_11644 
48@ = 2 
jump @BSKOOL_11690 

:BSKOOL_11644
gosub @BSKOOL_19005 
gosub @BSKOOL_20526 
if 
  " + _326 + @" == 1 
else_jump @BSKOOL_11683 
jump @BSKOOL_11690 

:BSKOOL_11683
jump @BSKOOL_11566 

:BSKOOL_11690
gosub @BSKOOL_20609 
gosub @BSKOOL_20948 
if 
  48@ == 2 
else_jump @BSKOOL_11875 
if 
  " + _2170 + @" == 1 
else_jump @BSKOOL_11861 
if 
  " + Mission_Driving_School_Passed + @" == 0 
else_jump @BSKOOL_11861 
fade 0 1000 

:BSKOOL_11765
if 
fading 
else_jump @BSKOOL_11789 
wait 0 
jump @BSKOOL_11765 

:BSKOOL_11789
Actor.PutAt(" + PlayerActor + @", 1171.521, 1351.183, 9.9219)
Actor.Angle(" + PlayerActor + @") = 11.0
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
fade 1 2000 

:BSKOOL_11830
if 
fading 
else_jump @BSKOOL_11854 
wait 0 
jump @BSKOOL_11830 

:BSKOOL_11854
jump @BSKOOL_11917 

:BSKOOL_11861
jump @BSKOOL_644 
jump @BSKOOL_11882 

:BSKOOL_11875
jump @BSKOOL_10032 

:BSKOOL_11882
jump @BSKOOL_10305 

:BSKOOL_11889
040D: unload_wav 3 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1186 
00BE: text_clear_all 
return 

:BSKOOL_11917
fade 1 500 
if 
  " + Mission_Driving_School_Passed + @" == 0 
else_jump @BSKOOL_11961 
0595: mission_complete 
" + Mission_Driving_School_Passed + @" = 1 
0624: add 50.0 to_float_stat 229 

:BSKOOL_11961
00BE: text_clear_all 
00BA: show_text_styled GXT 'BS_Z_7' time 5000 style 5  
0394: play_music 2 
Player.ClearWantedLevel(" + PlayerChar + @")
return 

:BSKOOL_11990
014F: stop_timer " + _253 + @" 
03F0: enable_text_draw 0 
0826: enable_hud 1 
0581: enable_radar 1 
01B7: release_weather 
Model.Destroy(#TRAFFICCONE)
Model.Destroy(#LANDJUMP2)
Model.Destroy(#FCR900)
Model.Destroy(#BF400)
Model.Destroy(#PCJ600)
Model.Destroy(#NRG500)
Model.Destroy(#SANCHEZ)
Model.Destroy(#WMYMECH)
if 
  " + parked_NRG500_Exists + @" == 0 
else_jump @BSKOOL_12231 
if 
  " + _2173 + @" == 1 
else_jump @BSKOOL_12231 
if 
  " + _2176 + @" == 1 
else_jump @BSKOOL_12231 
if 
  " + _2179 + @" == 1 
else_jump @BSKOOL_12231 
if 
  " + _2185 + @" == 1 
else_jump @BSKOOL_12231 
if 
  " + _2182 + @" == 1 
else_jump @BSKOOL_12231 
if 
  " + _2188 + @" == 1 
else_jump @BSKOOL_12231 
" + parked_NRG500_Exists + @" = 1 
if 
  " + parked_FCR900_Exists + @" == 0 
else_jump @BSKOOL_12206 
" + parked_FCR900_Exists + @" = 1 

:BSKOOL_12206
if 
  " + parked_Freeway_Exists + @" == 0 
else_jump @BSKOOL_12231 
" + parked_Freeway_Exists + @" = 1 

:BSKOOL_12231
if 
  " + parked_FCR900_Exists + @" == 0 
else_jump @BSKOOL_12389 
if 
  " + _2172 + @" == 1 
else_jump @BSKOOL_12389 
if 
  " + _2175 + @" == 1 
else_jump @BSKOOL_12389 
if 
  " + _2178 + @" == 1 
else_jump @BSKOOL_12389 
if 
  " + _2184 + @" == 1 
else_jump @BSKOOL_12389 
if 
  " + _2181 + @" == 1 
else_jump @BSKOOL_12389 
if 
  " + _2187 + @" == 1 
else_jump @BSKOOL_12389 
" + parked_FCR900_Exists + @" = 1 
if 
  " + parked_Freeway_Exists + @" == 0 
else_jump @BSKOOL_12389 
" + parked_Freeway_Exists + @" = 1 

:BSKOOL_12389
if 
  " + parked_Freeway_Exists + @" == 0 
else_jump @BSKOOL_12522 
if 
  " + _2171 + @" == 1 
else_jump @BSKOOL_12522 
if 
  " + _2174 + @" == 1 
else_jump @BSKOOL_12522 
if 
  " + _2177 + @" == 1 
else_jump @BSKOOL_12522 
if 
  " + _2183 + @" == 1 
else_jump @BSKOOL_12522 
if 
  " + _2180 + @" == 1 
else_jump @BSKOOL_12522 
if 
  " + _2186 + @" == 1 
else_jump @BSKOOL_12522 
" + parked_Freeway_Exists + @" = 1 

:BSKOOL_12522
if 
  " + parked_NRG500_Exists + @" == 1 
else_jump @BSKOOL_12571" );
CAR_PARK.set_chance_to_generate( parked_NRG500, 101 );
AppendLine( @"0624: add 200.0 to_float_stat 229 
" + parked_NRG500_Exists + @" = 2 

:BSKOOL_12571
if 
  " + parked_FCR900_Exists + @" == 1 
else_jump @BSKOOL_12620" );
CAR_PARK.set_chance_to_generate( parked_FCR900, 101 );
AppendLine( @"0624: add 100.0 to_float_stat 229 
" + parked_FCR900_Exists + @" = 2 

:BSKOOL_12620
if 
  " + parked_Freeway_Exists + @" == 1 
else_jump @BSKOOL_12659" );
CAR_PARK.set_chance_to_generate( parked_Freeway, 101 );
AppendLine( @"" + parked_Freeway_Exists + @" = 2 

:BSKOOL_12659
" + OnMission + @" = 0 
mission_cleanup 
return 

:BSKOOL_12670
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 225.0 size 612.0 438.0 RGBA 0 0 0 64@ 
if 
  63@ == 1 
else_jump @BSKOOL_12792 
if 
  255 > 64@ 
else_jump @BSKOOL_12785 
64@ += 5 
if 
  64@ > 255 
else_jump @BSKOOL_12778 
64@ = 255 

:BSKOOL_12778
jump @BSKOOL_12792 

:BSKOOL_12785
63@ = 2 

:BSKOOL_12792
if 
  63@ == 3 
else_jump @BSKOOL_12874 
if 
  64@ > 0 
else_jump @BSKOOL_12867 
64@ -= 5 
if 
  0 > 64@ 
else_jump @BSKOOL_12860 
64@ = 0 

:BSKOOL_12860
jump @BSKOOL_12874 

:BSKOOL_12867
63@ = 0 

:BSKOOL_12874
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 0.0 size 640.0 197.0 RGBA 0 0 0 255 
gosub @BSKOOL_16462 
0340: set_text_draw_RGBA 190 190 190 255 
if 
  " + _247 + @" == 1 
else_jump @BSKOOL_13069 
033E: set_draw_text_position 322.0 41.0 GXT 'BS_A'  
if 
  " + _2166 + @" > 69 
else_jump @BSKOOL_13004 
008B: 66@ = " + _2166 + @" 
jump @BSKOOL_13062 

:BSKOOL_13004
008B: 66@ = " + _2166 + @" 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0340: set_text_draw_RGBA 166 202 240 255 
033E: set_draw_text_position 320.0 80.0 GXT 'BS_Z_3'  

:BSKOOL_13062
gosub @BSKOOL_14954 

:BSKOOL_13069
if 
  " + _247 + @" == 2 
else_jump @BSKOOL_13206 
033E: set_draw_text_position 322.0 41.0 GXT 'BS_B'  
if 
  " + _2167 + @" > 69 
else_jump @BSKOOL_13141 
008B: 66@ = " + _2167 + @" 
jump @BSKOOL_13199 

:BSKOOL_13141
008B: 66@ = " + _2167 + @" 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0340: set_text_draw_RGBA 166 202 240 255 
033E: set_draw_text_position 320.0 80.0 GXT 'BS_Z_3'  

:BSKOOL_13199
gosub @BSKOOL_14954 

:BSKOOL_13206
if 
  " + _247 + @" == 3 
else_jump @BSKOOL_13343 
033E: set_draw_text_position 322.0 41.0 GXT 'BS_C'  
if 
  " + _2164 + @" > 69 
else_jump @BSKOOL_13278 
008B: 66@ = " + _2164 + @" 
jump @BSKOOL_13336 

:BSKOOL_13278
008B: 66@ = " + _2164 + @" 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0340: set_text_draw_RGBA 166 202 240 255 
033E: set_draw_text_position 320.0 80.0 GXT 'BS_Z_3'  

:BSKOOL_13336
gosub @BSKOOL_14954 

:BSKOOL_13343
if 
  " + _247 + @" == 5 
else_jump @BSKOOL_13480 
033E: set_draw_text_position 322.0 41.0 GXT 'BS_D'  
if 
  " + _2165 + @" > 69 
else_jump @BSKOOL_13415 
008B: 66@ = " + _2165 + @" 
jump @BSKOOL_13473 

:BSKOOL_13415
008B: 66@ = " + _2165 + @" 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0340: set_text_draw_RGBA 166 202 240 255 
033E: set_draw_text_position 320.0 80.0 GXT 'BS_Z_3'  

:BSKOOL_13473
gosub @BSKOOL_14954 

:BSKOOL_13480
if 
  " + _247 + @" == 4 
else_jump @BSKOOL_13617 
033E: set_draw_text_position 322.0 41.0 GXT 'BS_E'  
if 
  " + _2168 + @" > 69 
else_jump @BSKOOL_13552 
008B: 66@ = " + _2168 + @" 
jump @BSKOOL_13610 

:BSKOOL_13552
008B: 66@ = " + _2168 + @" 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0340: set_text_draw_RGBA 166 202 240 255 
033E: set_draw_text_position 320.0 80.0 GXT 'BS_Z_3'  

:BSKOOL_13610
gosub @BSKOOL_14954 

:BSKOOL_13617
if 
  " + _247 + @" == 6 
else_jump @BSKOOL_13754 
033E: set_draw_text_position 322.0 41.0 GXT 'BS_F'  
if 
  " + _2169 + @" > 69 
else_jump @BSKOOL_13689 
008B: 66@ = " + _2169 + @" 
jump @BSKOOL_13747 

:BSKOOL_13689
008B: 66@ = " + _2169 + @" 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
0340: set_text_draw_RGBA 166 202 240 255 
033E: set_draw_text_position 320.0 80.0 GXT 'BS_Z_3'  

:BSKOOL_13747
gosub @BSKOOL_14954 

:BSKOOL_13754
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 248 211 7 255 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @BSKOOL_13832 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'BS_X_4'  
jump @BSKOOL_13865 

:BSKOOL_13832
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 360.0 GXT 'BS_X_4'  

:BSKOOL_13865
if 
   not 57@ == 1 
else_jump @BSKOOL_14259 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 248 211 7 255 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @BSKOOL_13961 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'BS_X_5'  
jump @BSKOOL_13994 

:BSKOOL_13961
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 70.0 340.0 GXT 'BS_X_5'  

:BSKOOL_13994
if 
   not " + _2162 + @" == 1 
else_jump @BSKOOL_14123 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 248 211 7 255 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @BSKOOL_14090 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BS_X_3'  
jump @BSKOOL_14123 

:BSKOOL_14090
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BS_X_3'  

:BSKOOL_14123
if 
  " + _2162 + @" == 1 
else_jump @BSKOOL_14252 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 173 173 173 125 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @BSKOOL_14219 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BS_X_3'  
jump @BSKOOL_14252 

:BSKOOL_14219
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BS_X_3'  

:BSKOOL_14252
jump @BSKOOL_14370 

:BSKOOL_14259
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 248 211 7 255 
if 
04A3:   " + Current_Language + @" == 1 
else_jump @BSKOOL_14337 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BS_X_3'  
jump @BSKOOL_14370 

:BSKOOL_14337
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 437.0 340.0 GXT 'BS_X_3'  

:BSKOOL_14370
gosub @BSKOOL_16284 
033F: set_text_draw_letter_size 0.32 1.25 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 150.0 360.0 GXT 'BS_X04'  
if 
   not 57@ == 1 
else_jump @BSKOOL_14646 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 255 255 255 255 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 150.0 340.0 GXT 'SCH_PRS'  
if 
   not " + _2162 + @" == 1 
else_jump @BSKOOL_14568 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 255 255 255 255 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'BS_X03'  

:BSKOOL_14568
if 
  " + _2162 + @" == 1 
else_jump @BSKOOL_14639 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 173 173 173 125 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'BS_X03'  

:BSKOOL_14639
jump @BSKOOL_14700 

:BSKOOL_14646
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 255 255 255 255 
033F: set_text_draw_letter_size 0.32 1.25 
033E: set_draw_text_position 537.4 340.0 GXT 'BS_X03'  

:BSKOOL_14700
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

:BSKOOL_14954
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 8 position 320.0 430.0 size 640.0 250.0 RGBA 0 0 0 255 
gosub @BSKOOL_16284 
03E4: set_text_draw_align_right 0 
0340: set_text_draw_RGBA 166 202 240 255 
if 
  66@ > 69 
else_jump @BSKOOL_15066 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
045A: draw_text_1number 320.0 80.0 GXT 'BS_Y_6' number 66@  

:BSKOOL_15066
if 
  70 > 66@ 
else_jump @BSKOOL_15091 
65@ = 1 

:BSKOOL_15091
if 
  66@ > 69 
else_jump @BSKOOL_15134 
if 
  85 > 66@ 
else_jump @BSKOOL_15134 
65@ = 2 

:BSKOOL_15134
if 
  66@ > 84 
else_jump @BSKOOL_15177 
if 
  100 > 66@ 
else_jump @BSKOOL_15177 
65@ = 3 

:BSKOOL_15177
if 
  66@ == 100 
else_jump @BSKOOL_15202 
65@ = 4 

:BSKOOL_15202
if 
  65@ > 1 
else_jump @BSKOOL_15307 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 4 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 
jump @BSKOOL_15387 

:BSKOOL_15307
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 250.0 306.0 size -60.0 60.0 RGBA 180 180 180 255 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 7 position 395.0 306.0 size 60.0 60.0 RGBA 180 180 180 255 

:BSKOOL_15387
03E3: set_texture_to_be_drawn_antialiased 1 
if 
  65@ == 1 
else_jump @BSKOOL_15495 
038D: draw_texture 6 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 166 202 240 255 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 320.0 375.0 GXT 'BS_Z_4'  

:BSKOOL_15495
if 
  65@ == 2 
else_jump @BSKOOL_15599 
038D: draw_texture 1 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 166 202 240 255 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 320.0 375.0 GXT 'BS_Y_12'  

:BSKOOL_15599
if 
  65@ == 3 
else_jump @BSKOOL_15703 
038D: draw_texture 2 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 166 202 240 255 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 320.0 375.0 GXT 'BS_Y_11'  

:BSKOOL_15703
if 
  65@ == 4 
else_jump @BSKOOL_15807 
038D: draw_texture 3 position 320.0 307.0 size 110.0 95.0 RGBA 160 160 160 255 
gosub @BSKOOL_16284 
0340: set_text_draw_RGBA 166 202 240 255 
03E4: set_text_draw_align_right 0 
0342: set_text_draw_centered 1 
033E: set_draw_text_position 320.0 375.0 GXT 'BS_Y_10'  

:BSKOOL_15807
return 

:BSKOOL_15809
if 
  34@ == 0 
else_jump @BSKOOL_15984 
if 
  " + _247 + @" == 1 
else_jump @BSKOOL_15852 
gosub @BSKOOL_1783 

:BSKOOL_15852
if 
  " + _247 + @" == 2 
else_jump @BSKOOL_15877 
gosub @BSKOOL_3477 

:BSKOOL_15877
if 
  " + _247 + @" == 3 
else_jump @BSKOOL_15902 
gosub @BSKOOL_4902 

:BSKOOL_15902
if 
  " + _247 + @" == 5 
else_jump @BSKOOL_15927 
gosub @BSKOOL_6670 

:BSKOOL_15927
if 
  " + _247 + @" == 4 
else_jump @BSKOOL_15952 
gosub @BSKOOL_8446 

:BSKOOL_15952
if 
  " + _247 + @" == 6 
else_jump @BSKOOL_15977 
gosub @BSKOOL_10039 

:BSKOOL_15977
34@ = 1 

:BSKOOL_15984
if 
  34@ == 1 
else_jump @BSKOOL_16068 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_16068 
if 
87C1:   not path 35@ available 
else_jump @BSKOOL_16046 
07C0: load_path 35@ 
jump @BSKOOL_16068 

:BSKOOL_16046
05EB: assign_car 38@ to_path 35@ 
63@ = 3 
34@ = 2 

:BSKOOL_16068
if 
  34@ == 2 
else_jump @BSKOOL_16153 
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_16139 
if 
860E:   not car 38@ assigned_to_path 
else_jump @BSKOOL_16132 
63@ = 1 
34@ = 4 

:BSKOOL_16132
jump @BSKOOL_16153 

:BSKOOL_16139
63@ = 1 
34@ = 4 

:BSKOOL_16153
if 
  34@ == 3 
else_jump @BSKOOL_16185 
63@ = 1 
34@ = 4 

:BSKOOL_16185
if 
  34@ == 4 
else_jump @BSKOOL_16282 
if 
  63@ == 2 
else_jump @BSKOOL_16282 
05EC: release_car 38@ from_path 
Car.Destroy(38@)
Actor.DestroyInstantly(49@)
0395: clear_area 1 at " + _327 + @" " + _328 + @" " + _329 + @" radius 300.0 
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
Car.Destroy(38@)
gosub @BSKOOL_20948 
34@ = 0 

:BSKOOL_16282
return 

:BSKOOL_16284
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

:BSKOOL_16346
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

:BSKOOL_16462
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
03E0: draw_text_behind_textures 1 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.0 3.8 
060D: draw_text_shadow 2 rgba 0 0 0 255 
0349: set_text_draw_font 2 
return 

:BSKOOL_16582
fade 0 500 

:BSKOOL_16589
if 
fading 
else_jump @BSKOOL_16613 
wait 0 
jump @BSKOOL_16589 

:BSKOOL_16613
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
return 

:BSKOOL_16619
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
43@ = 0.0 
42@ = 0.0 
44@ = 0.0 
39@ = 0 
40@ = 0 
48@ = 0 
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
41@ = 0 
" + _264 + @" = 0 
" + _265 + @" = 0 
" + _272 + @" = 0 
" + _273 + @" = 0 
" + _276 + @" = 0.0 
" + _274 + @" = 0 
" + _275 + @" = 0 
" + _279 + @" = 0.0 
45@ = 0.0 
46@ = 0 
47@ = 0 
59@ = 0 
58@ = 0 
return 

:BSKOOL_17341
036A: put_actor " + PlayerActor + @" in_car 38@ 
Car.DoorStatus(38@) = 4
wait 0 
0581: enable_radar 1 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
fade 1 500 

:BSKOOL_17375
if 
fading 
else_jump @BSKOOL_17399 
wait 0 
jump @BSKOOL_17375 

:BSKOOL_17399
Player.CanMove(" + PlayerChar + @") = True
return 

:BSKOOL_17408
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_17475 
if 
  " + _249 + @" == 1 
else_jump @BSKOOL_17468 
if 
   not Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_17468 
48@ = 1 

:BSKOOL_17468
jump @BSKOOL_17482 

:BSKOOL_17475
48@ = 1 

:BSKOOL_17482
return 

:BSKOOL_17484
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_17527 
if 
   Actor.InCar(" + PlayerActor + @", 38@)
else_jump @BSKOOL_17527 
02E3: 43@ = car 38@ speed 

:BSKOOL_17527
if or
00E1:   player 0 pressed_key 16 
00E1:   player 0 pressed_key 14 
else_jump @BSKOOL_17640 
if 
  43@ > 0.1 
else_jump @BSKOOL_17640 
00BE: text_clear_all 
if or
  " + _247 + @" == 1 
  " + _247 + @" == 2 
  " + _247 + @" == 3 
  " + _247 + @" == 5 
  " + _247 + @" == 4 
  " + _247 + @" == 6 
else_jump @BSKOOL_17633 
014E: start_timer_at " + _253 + @" count_in_direction 1 

:BSKOOL_17633
" + _249 + @" = 1 

:BSKOOL_17640
return 

:BSKOOL_17642
if 
  " + _253 + @" == 0 
else_jump @BSKOOL_17674 
Player.CanMove(" + PlayerChar + @") = False
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 

:BSKOOL_17674
return 

:BSKOOL_17676
Player.CanMove(" + PlayerChar + @") = False
0396: pause_timer 1 
return 

:BSKOOL_17689
Car.StorePos(38@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0509: " + _259 + @" = distance_between_XY " + tempvar_X_coord + @" " + tempvar_Y_coord + @" and_XY " + _255 + @" " + _256 + @" 
if 
  " + _259 + @" > 0.5 
else_jump @BSKOOL_17826 
if 
  10.0 > " + _259 + @" 
else_jump @BSKOOL_17812 
" + _259 + @" -= 0.5 
" + _259 + @" *= 10.42 
008C: " + _273 + @" = float " + _259 + @" to_integer 
" + _267 + @" = 100 
0060: " + _267 + @" -= " + _273 + @" 
jump @BSKOOL_17819 

:BSKOOL_17812
" + _267 + @" = 0 

:BSKOOL_17819
jump @BSKOOL_17833 

:BSKOOL_17826
" + _267 + @" = 100 

:BSKOOL_17833
0058: " + Current_Flight_Record + @" += " + _267 + @" 
return 
40@ = Car.Health(38@)
" + _268 + @" = 1000 
0066: " + _268 + @" -= 40@ 
if 
  " + _247 + @" == 16 
else_jump @BSKOOL_17899 
" + _268 + @" /= 10 
jump @BSKOOL_17906 

:BSKOOL_17899
" + _268 + @" /= 2 

:BSKOOL_17906
if 
  " + _268 + @" > 100 
else_jump @BSKOOL_17931 
" + _268 + @" = 100 

:BSKOOL_17931
return 

:BSKOOL_17933
" + _272 + @" = 0 
" + _200 + @" = 0 
if 
  " + _247 + @" == 1 
else_jump @BSKOOL_18024 

:BSKOOL_17965
if 
  15 > " + _200 + @" 
else_jump @BSKOOL_18024 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @BSKOOL_18010 
" + _272 + @" += 10 

:BSKOOL_18010
" + _200 + @" += 1 
jump @BSKOOL_17965 

:BSKOOL_18024
if 
  " + _247 + @" == 2 
else_jump @BSKOOL_18101 

:BSKOOL_18042
if 
  25 > " + _200 + @" 
else_jump @BSKOOL_18101 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @BSKOOL_18087 
" + _272 + @" += 10 

:BSKOOL_18087
" + _200 + @" += 1 
jump @BSKOOL_18042 

:BSKOOL_18101
if or
  " + _247 + @" == 3 
  " + _247 + @" == 5 
else_jump @BSKOOL_18185 

:BSKOOL_18126
if 
  30 > " + _200 + @" 
else_jump @BSKOOL_18185 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @BSKOOL_18171 
" + _272 + @" += 10 

:BSKOOL_18171
" + _200 + @" += 1 
jump @BSKOOL_18126 

:BSKOOL_18185
if or
  " + _247 + @" == 4 
  " + _247 + @" == 6 
else_jump @BSKOOL_18269 

:BSKOOL_18210
if 
  14 > " + _200 + @" 
else_jump @BSKOOL_18269 
if 
0366:   object " + tmp_201 + @"(" + _200 + @",46i) damaged 
else_jump @BSKOOL_18255 
" + _272 + @" += 10 

:BSKOOL_18255
" + _200 + @" += 1 
jump @BSKOOL_18210 

:BSKOOL_18269
" + _272 + @" *= 2 
if 
  " + _272 + @" > 90 
else_jump @BSKOOL_18301 
" + _272 + @" = 100 

:BSKOOL_18301
0060: " + Current_Flight_Record + @" -= " + _272 + @" 
return 

:BSKOOL_18311
if 
  1 > " + Current_Flight_Record + @" 
else_jump @BSKOOL_18336 
" + Current_Flight_Record + @" = 0 

:BSKOOL_18336
00BE: text_clear_all 
return 

:BSKOOL_18340
if 
   not Car.Wrecked(38@)
else_jump @BSKOOL_18773 
if 
  " + _333 + @" == 0 
else_jump @BSKOOL_18465 
0407: store_coords_to " + _330 + @" " + _331 + @" " + _332 + @" from_car 38@ with_offset 10.0 0.0 5.0 
" + _332 + @" = 15.0 
Camera.SetPosition(" + _330 + @", " + _331 + @", " + _332 + @", 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
" + _333 + @" = 1 

:BSKOOL_18465
if 
  32@ > 3000 
else_jump @BSKOOL_18612 
if 
  6000 > 32@ 
else_jump @BSKOOL_18612 
if 
  " + _333 + @" == 1 
else_jump @BSKOOL_18612 
0407: store_coords_to " + _330 + @" " + _331 + @" " + _332 + @" from_car 38@ with_offset 0.0 10.0 5.0 
" + _332 + @" = 15.0 
Camera.SetPosition(" + _330 + @", " + _331 + @", " + _332 + @", 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
" + _333 + @" = 2 

:BSKOOL_18612
if 
  32@ > 6000 
else_jump @BSKOOL_18740 
if 
  " + _333 + @" == 2 
else_jump @BSKOOL_18740 
0407: store_coords_to " + _330 + @" " + _331 + @" " + _332 + @" from_car 38@ with_offset -10.0 0.0 5.0 
" + _332 + @" = 15.0 
Camera.SetPosition(" + _330 + @", " + _331 + @", " + _332 + @", 0.0, 0.0, 0.0)
Camera.OnVehicle(38@, 15, 1)
0460: set_camera_transverse_delay 50.0 time 2000 
" + _333 + @" = 3 

:BSKOOL_18740
if 
  32@ > 9000 
else_jump @BSKOOL_18773 
" + _333 + @" = 1 
32@ = 0 

:BSKOOL_18773
return 

:BSKOOL_18775
65@ = 0 
if 
  " + Current_Flight_Record + @" > 69 
else_jump @BSKOOL_18864 
if 
  85 > " + Current_Flight_Record + @" 
else_jump @BSKOOL_18864 
if and
  67@ > 69 
  85 > 67@ 
else_jump @BSKOOL_18857 
65@ = 0 
jump @BSKOOL_18864 

:BSKOOL_18857
65@ = 2 

:BSKOOL_18864
if 
  " + Current_Flight_Record + @" > 84 
else_jump @BSKOOL_18946 
if 
  100 > " + Current_Flight_Record + @" 
else_jump @BSKOOL_18946 
if and
  67@ > 84 
  100 > 67@ 
else_jump @BSKOOL_18939 
65@ = 0 
jump @BSKOOL_18946 

:BSKOOL_18939
65@ = 3 

:BSKOOL_18946
if 
  " + Current_Flight_Record + @" == 100 
else_jump @BSKOOL_19003 
if 
  67@ == 100 
else_jump @BSKOOL_18996 
65@ = 0 
jump @BSKOOL_19003 

:BSKOOL_18996
65@ = 4 

:BSKOOL_19003
return 

:BSKOOL_19005
0826: enable_hud 0 
0581: enable_radar 0 
00BE: text_clear_all 
014F: stop_timer " + _253 + @" 
if 
  2 > 65@ 
else_jump @BSKOOL_19078 
0937: text_draw_box_cornerA 160.0 220.0 cornerB 490.0 400.0 GXT_reference 'BS_Z_8' style 3  
jump @BSKOOL_19111 

:BSKOOL_19078
0937: text_draw_box_cornerA 160.0 200.0 cornerB 490.0 400.0 GXT_reference 'DUMMY' style 3 

:BSKOOL_19111
gosub @BSKOOL_16346 
0904: get_interface 3 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 255.0 GXT 'BS_Y_1'  
gosub @BSKOOL_16346 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 475.0 255.0 GXT 'BS_Y_6' number " + _266 + @"  
gosub @BSKOOL_16346 
0904: get_interface 3 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 275.0 GXT 'BS_Y_2'  
gosub @BSKOOL_16346 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 475.0 275.0 GXT 'BS_Y_6' number " + _267 + @"  
gosub @BSKOOL_16346 
0904: get_interface 3 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 295.0 GXT 'BS_Y_3'  
gosub @BSKOOL_16346 
03E4: set_text_draw_align_right 1 
0904: get_interface 0 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
045A: draw_text_1number 475.0 295.0 GXT 'BS_Y_6' number " + _272 + @"  
gosub @BSKOOL_16346 
0904: get_interface 3 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 315.0 GXT 'BS_Y_5'  
gosub @BSKOOL_16346 
03E4: set_text_draw_align_right 1 
0340: set_text_draw_RGBA 255 255 255 255 
045A: draw_text_1number 475.0 315.0 GXT 'BS_Y_6' number " + Current_Flight_Record + @"  
if or
  59@ == 1 
  59@ == 2 
else_jump @BSKOOL_19915 
if 
  65@ > 0 
else_jump @BSKOOL_19915 
038D: draw_texture 4 position 250.0 200.0 size -60.0 60.0 RGBA 180 180 180 255 
038D: draw_texture 4 position 392.0 200.0 size 60.0 60.0 RGBA 180 180 180 255 
if 
  65@ == 2 
else_jump @BSKOOL_19724 
038D: draw_texture 1 position 320.0 200.0 size 110.0 95.0 RGBA 160 160 160 255 

:BSKOOL_19724
if 
  65@ == 3 
else_jump @BSKOOL_19778 
038D: draw_texture 2 position 320.0 200.0 size 110.0 95.0 RGBA 160 160 160 255 

:BSKOOL_19778
if 
  65@ == 4 
else_jump @BSKOOL_19832 
038D: draw_texture 3 position 320.0 200.0 size 110.0 95.0 RGBA 160 160 160 255 

:BSKOOL_19832
gosub @BSKOOL_16462 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.0 3.4 
0904: get_interface 6 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 323.0 65.0 GXT 'BS_Y_9'  

:BSKOOL_19915
if or
  59@ == 1 
  59@ == 2 
else_jump @BSKOOL_20007 
gosub @BSKOOL_16462 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.0 3.4 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 323.0 110.0 GXT 'BS_Y_8'  

:BSKOOL_20007
if 
   not 59@ == 2 
else_jump @BSKOOL_20312 
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 4 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 330.0 345.0 GXT 'SCH_PRS'  
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 345.0 GXT 'BS_Z_5'  
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 4 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 330.0 365.0 GXT 'BS_X04'  
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 365.0 GXT 'BS_Z_6'  
jump @BSKOOL_20524 

:BSKOOL_20312
if 
   not " + _2162 + @" == 6 
else_jump @BSKOOL_20384 
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0340: set_text_draw_RGBA 255 255 255 255 
033E: set_draw_text_position 170.0 345.0 GXT 'BS_Z_9'  

:BSKOOL_20384
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 4 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 330.0 365.0 GXT 'SCH_PRS'  
gosub @BSKOOL_16346 
033F: set_text_draw_letter_size 0.52 1.45 
0904: get_interface 6 color_RGBA_to 52@ 53@ 54@ 55@ 
0340: set_text_draw_RGBA 52@ 53@ 54@ 55@ 
033E: set_draw_text_position 170.0 365.0 GXT 'BS_Z_5'  

:BSKOOL_20524
return 

:BSKOOL_20526
if 
00E1:   player 0 pressed_key 16 
else_jump @BSKOOL_20582 
if 
  " + _12 + @" == 1 
else_jump @BSKOOL_20575 
" + _12 + @" = 0 
" + _326 + @" = 1 

:BSKOOL_20575
jump @BSKOOL_20607 

:BSKOOL_20582
if 
  " + _12 + @" == 0 
else_jump @BSKOOL_20607 
" + _12 + @" = 1 

:BSKOOL_20607
return 

:BSKOOL_20609
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1186 
fade 0 500 

:BSKOOL_20636
if 
fading 
else_jump @BSKOOL_20705 
if 
  " + Mission_Driving_School_Passed + @" == 0 
else_jump @BSKOOL_20692 
if 
  " + _2170 + @" == 1 
else_jump @BSKOOL_20692 
gosub @BSKOOL_12670 

:BSKOOL_20692
00BE: text_clear_all 
wait 0 
jump @BSKOOL_20636 

:BSKOOL_20705
00BE: text_clear_all 
03D6: remove_styled_text 'BS_Y_8'  
03D6: remove_styled_text 'BS_Y_9'  
0221: set_player " + PlayerChar + @" apply_brakes_to_car 0 
0792: disembark_instantly_actor " + PlayerActor + @" 
if 
  48@ == 2 
else_jump @BSKOOL_20831 
00BE: text_clear_all 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @BSKOOL_20804 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1171.521 1351.183 9.9219 
jump @BSKOOL_20824 

:BSKOOL_20804
Actor.PutAt(" + PlayerActor + @", 1171.521, 1351.183, 9.9219)

:BSKOOL_20824
jump @BSKOOL_20894 

:BSKOOL_20831
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @BSKOOL_20874 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at 1171.521 1351.183 9.9219 
jump @BSKOOL_20894 

:BSKOOL_20874
Actor.PutAt(" + PlayerActor + @", 1171.521, 1351.183, 9.9219)

:BSKOOL_20894
Actor.Angle(" + PlayerActor + @") = 5.0
Car.Destroy(38@)
0395: clear_area 1 at 1171.521 1351.183 9.9219 radius 2.0 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
014F: stop_timer " + _253 + @" 
0396: pause_timer 0 
return 

:BSKOOL_20948
" + _200 + @" = 0 

:BSKOOL_20955
if 
  46 > " + _200 + @" 
else_jump @BSKOOL_20996 
Object.Destroy(" + tmp_201 + @"(" + _200 + @",46i))
" + _200 + @" += 1 
jump @BSKOOL_20955 

:BSKOOL_20996
if 
03CA:   object 56@ exists 
else_jump @BSKOOL_21017 
Object.Destroy(56@)

:BSKOOL_21017
return 

:BSKOOL_21019
" + _200 + @" = 0 
if 
  " + _247 + @" == 1 
else_jump @BSKOOL_21103 

:BSKOOL_21044
if 
  15 > " + _200 + @" 
else_jump @BSKOOL_21103 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 500.0)
" + _200 + @" += 1 
jump @BSKOOL_21044 

:BSKOOL_21103
if 
  " + _247 + @" == 2 
else_jump @BSKOOL_21180 

:BSKOOL_21121
if 
  25 > " + _200 + @" 
else_jump @BSKOOL_21180 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 500.0)
" + _200 + @" += 1 
jump @BSKOOL_21121 

:BSKOOL_21180
if or
  " + _247 + @" == 3 
  " + _247 + @" == 5 
else_jump @BSKOOL_21264 

:BSKOOL_21205
if 
  30 > " + _200 + @" 
else_jump @BSKOOL_21264 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 500.0)
" + _200 + @" += 1 
jump @BSKOOL_21205 

:BSKOOL_21264
if or
  " + _247 + @" == 4 
  " + _247 + @" == 6 
else_jump @BSKOOL_21378 

:BSKOOL_21289
if 
  14 > " + _200 + @" 
else_jump @BSKOOL_21348 
" + tmp_201 + @"(" + _200 + @",46i) = Object.Init(#TRAFFICCONE, 0.0, 0.0, 500.0)
" + _200 + @" += 1 
jump @BSKOOL_21289 

:BSKOOL_21348
56@ = Object.Init(#LANDJUMP2, 0.0, 0.0, 500.0)
Object.CollisionDetection(56@) = True

:BSKOOL_21378
if 
  " + _247 + @" == 1 
else_jump @BSKOOL_22056 
" + _285 + @" = 6.0 
" + _279 + @" = 0.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car 38@ with_offset 0.0 1.0 -0.2 

:BSKOOL_21445
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 0.0 
else_jump @BSKOOL_21528 
Object.PutAt(" + tmp_201 + @"[0], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21528
if 
  " + _279 + @" == 24.0 
else_jump @BSKOOL_21563 
Object.PutAt(" + tmp_201 + @"[1], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21563
if 
  " + _279 + @" == 48.0 
else_jump @BSKOOL_21598 
Object.PutAt(" + tmp_201 + @"[2], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21598
if 
  " + _279 + @" == 72.0 
else_jump @BSKOOL_21633 
Object.PutAt(" + tmp_201 + @"[3], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21633
if 
  " + _279 + @" == 96.0 
else_jump @BSKOOL_21668 
Object.PutAt(" + tmp_201 + @"[4], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21668
if 
  " + _279 + @" == 120.0 
else_jump @BSKOOL_21703 
Object.PutAt(" + tmp_201 + @"[5], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21703
if 
  " + _279 + @" == 144.0 
else_jump @BSKOOL_21738 
Object.PutAt(" + tmp_201 + @"[6], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21738
if 
  " + _279 + @" == 168.0 
else_jump @BSKOOL_21773 
Object.PutAt(" + tmp_201 + @"[7], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21773
if 
  " + _279 + @" == 192.0 
else_jump @BSKOOL_21808 
Object.PutAt(" + tmp_201 + @"[8], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21808
if 
  " + _279 + @" == 216.0 
else_jump @BSKOOL_21843 
Object.PutAt(" + tmp_201 + @"[9], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21843
if 
  " + _279 + @" == 240.0 
else_jump @BSKOOL_21878 
Object.PutAt(" + tmp_201 + @"[10], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21878
if 
  " + _279 + @" == 264.0 
else_jump @BSKOOL_21913 
Object.PutAt(" + tmp_201 + @"[11], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21913
if 
  " + _279 + @" == 288.0 
else_jump @BSKOOL_21948 
Object.PutAt(" + tmp_201 + @"[12], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21948
if 
  " + _279 + @" == 312.0 
else_jump @BSKOOL_21983 
Object.PutAt(" + tmp_201 + @"[13], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_21983
if 
  " + _279 + @" == 336.0 
else_jump @BSKOOL_22018 
Object.PutAt(" + tmp_201 + @"[14], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_22018
" + _279 + @" += 24.0 
if 
  360.0 > " + _279 + @" 
else_jump @BSKOOL_22056 
jump @BSKOOL_21445 

:BSKOOL_22056
if 
  " + _247 + @" == 2 
else_jump @BSKOOL_22798 
" + _285 + @" = 6.0 
" + _279 + @" = 90.0 
0407: store_coords_to " + _280 + @" " + _281 + @" " + _284 + @" from_car 38@ with_offset 0.0 86.0 -0.2 

:BSKOOL_22123
02F6: " + _282 + @" = sine " + _279 + @" 
0069: " + _282 + @" *= " + _285 + @" 
0059: " + _282 + @" += " + _280 + @" 
02F7: " + _283 + @" = cosine " + _279 + @" 
0069: " + _283 + @" *= " + _285 + @" 
0059: " + _283 + @" += " + _281 + @" 
if 
  " + _279 + @" == 120.0 
else_jump @BSKOOL_22206 
Object.PutAt(" + tmp_201 + @"[0], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_22206
if 
  " + _279 + @" == 150.0 
else_jump @BSKOOL_22241 
Object.PutAt(" + tmp_201 + @"[1], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_22241
if 
  " + _279 + @" == 180.0 
else_jump @BSKOOL_22276 
Object.PutAt(" + tmp_201 + @"[2], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_22276
if 
  " + _279 + @" == 210.0 
else_jump @BSKOOL_22311 
Object.PutAt(" + tmp_201 + @"[3], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_22311
if 
  " + _279 + @" == 240.0 
else_jump @BSKOOL_22346 
Object.PutAt(" + tmp_201 + @"[4], " + _282 + @", " + _283 + @", " + _284 + @")

:BSKOOL_22346
" + _279 + @" += 30.0 
if 
  271.0 > " + _279 + @" 
else_jump @BSKOOL_22384 
jump @BSKOOL_22123 

:BSKOOL_22384
035C: place_object " + tmp_201 + @"[7] relative_to_car 38@ with_offset -7.0 74.0 -0.2 
035C: place_object " + tmp_201 + @"[8] relative_to_car 38@ with_offset 7.0 74.0 -0.2 
035C: place_object " + tmp_201 + @"[9] relative_to_car 38@ with_offset -7.0 78.0 -0.2 
035C: place_object " + tmp_201 + @"[10] relative_to_car 38@ with_offset 7.0 78.0 -0.2 
035C: place_object " + tmp_201 + @"[11] relative_to_car 38@ with_offset -7.0 82.0 -0.2 
035C: place_object " + tmp_201 + @"[12] relative_to_car 38@ with_offset 7.0 82.0 -0.2 
035C: place_object " + tmp_201 + @"[13] relative_to_car 38@ with_offset -7.0 86.0 -0.2 
035C: place_object " + tmp_201 + @"[14] relative_to_car 38@ with_offset 7.0 86.0 -0.2 
035C: place_object " + tmp_201 + @"[15] relative_to_car 38@ with_offset 0.0 82.0 -0.2 
035C: place_object " + tmp_201 + @"[16] relative_to_car 38@ with_offset -3.0 4.0 -0.2 
035C: place_object " + tmp_201 + @"[17] relative_to_car 38@ with_offset 3.0 4.0 -0.2 
035C: place_object " + tmp_201 + @"[18] relative_to_car 38@ with_offset -3.0 0.0 -0.2 
035C: place_object " + tmp_201 + @"[19] relative_to_car 38@ with_offset 3.0 0.0 -0.2 
035C: place_object " + tmp_201 + @"[20] relative_to_car 38@ with_offset -3.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[21] relative_to_car 38@ with_offset 3.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[22] relative_to_car 38@ with_offset 0.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[23] relative_to_car 38@ with_offset 0.0 74.0 -0.2 
035C: place_object " + tmp_201 + @"[24] relative_to_car 38@ with_offset 0.0 78.0 -0.2 

:BSKOOL_22798
if or
  " + _247 + @" == 3 
  " + _247 + @" == 5 
else_jump @BSKOOL_23513 
035C: place_object " + tmp_201 + @"[0] relative_to_car 38@ with_offset -3.0 4.0 -0.2 
035C: place_object " + tmp_201 + @"[1] relative_to_car 38@ with_offset 3.0 4.0 -0.2 
035C: place_object " + tmp_201 + @"[2] relative_to_car 38@ with_offset -3.0 0.0 -0.2 
035C: place_object " + tmp_201 + @"[3] relative_to_car 38@ with_offset 3.0 0.0 -0.2 
035C: place_object " + tmp_201 + @"[4] relative_to_car 38@ with_offset -3.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[5] relative_to_car 38@ with_offset 3.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[6] relative_to_car 38@ with_offset 0.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[7] relative_to_car 38@ with_offset -3.5 56.0 -0.2 
035C: place_object " + tmp_201 + @"[8] relative_to_car 38@ with_offset 3.5 56.0 -0.2 
035C: place_object " + tmp_201 + @"[9] relative_to_car 38@ with_offset -3.5 60.0 -0.2 
035C: place_object " + tmp_201 + @"[10] relative_to_car 38@ with_offset 3.5 60.0 -0.2 
035C: place_object " + tmp_201 + @"[11] relative_to_car 38@ with_offset -3.5 64.0 -0.2 
035C: place_object " + tmp_201 + @"[12] relative_to_car 38@ with_offset 3.5 64.0 -0.2 
035C: place_object " + tmp_201 + @"[13] relative_to_car 38@ with_offset -3.5 68.0 -0.2 
035C: place_object " + tmp_201 + @"[14] relative_to_car 38@ with_offset 3.5 68.0 -0.2 
035C: place_object " + tmp_201 + @"[15] relative_to_car 38@ with_offset -3.5 72.0 -0.2 
035C: place_object " + tmp_201 + @"[16] relative_to_car 38@ with_offset 3.5 72.0 -0.2 
035C: place_object " + tmp_201 + @"[17] relative_to_car 38@ with_offset -3.5 76.0 -0.2 
035C: place_object " + tmp_201 + @"[18] relative_to_car 38@ with_offset 3.5 76.0 -0.2 
035C: place_object " + tmp_201 + @"[19] relative_to_car 38@ with_offset -3.5 80.0 -0.2 
035C: place_object " + tmp_201 + @"[20] relative_to_car 38@ with_offset 3.5 80.0 -0.2 
035C: place_object " + tmp_201 + @"[21] relative_to_car 38@ with_offset -3.5 84.0 -0.2 
035C: place_object " + tmp_201 + @"[22] relative_to_car 38@ with_offset 3.5 84.0 -0.2 
035C: place_object " + tmp_201 + @"[23] relative_to_car 38@ with_offset -3.0 120.0 -0.2 
035C: place_object " + tmp_201 + @"[24] relative_to_car 38@ with_offset 3.0 120.0 -0.2 
035C: place_object " + tmp_201 + @"[25] relative_to_car 38@ with_offset -3.0 124.0 -0.2 
035C: place_object " + tmp_201 + @"[26] relative_to_car 38@ with_offset 3.0 124.0 -0.2 
035C: place_object " + tmp_201 + @"[27] relative_to_car 38@ with_offset -3.0 128.0 -0.2 
035C: place_object " + tmp_201 + @"[28] relative_to_car 38@ with_offset 3.0 128.0 -0.2 
035C: place_object " + tmp_201 + @"[29] relative_to_car 38@ with_offset 0.0 128.0 -0.2 

:BSKOOL_23513
if or
  " + _247 + @" == 4 
  " + _247 + @" == 6 
else_jump @BSKOOL_24080 
035C: place_object " + tmp_201 + @"[0] relative_to_car 38@ with_offset -3.0 4.0 -0.2 
035C: place_object " + tmp_201 + @"[1] relative_to_car 38@ with_offset 3.0 4.0 -0.2 
035C: place_object " + tmp_201 + @"[2] relative_to_car 38@ with_offset -3.0 0.0 -0.2 
035C: place_object " + tmp_201 + @"[3] relative_to_car 38@ with_offset 3.0 0.0 -0.2 
035C: place_object " + tmp_201 + @"[4] relative_to_car 38@ with_offset -3.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[5] relative_to_car 38@ with_offset 3.0 -4.0 -0.2 
035C: place_object " + tmp_201 + @"[6] relative_to_car 38@ with_offset 0.0 -4.0 -0.2 
035C: place_object 56@ relative_to_car 38@ with_offset 0.0 48.0 -0.2 
if 
  " + _247 + @" == 4 
else_jump @BSKOOL_23901 
035C: place_object " + tmp_201 + @"[7] relative_to_car 38@ with_offset -3.0 120.0 -0.2 
035C: place_object " + tmp_201 + @"[8] relative_to_car 38@ with_offset 3.0 120.0 -0.2 
035C: place_object " + tmp_201 + @"[9] relative_to_car 38@ with_offset -3.0 124.0 -0.2 
035C: place_object " + tmp_201 + @"[10] relative_to_car 38@ with_offset 3.0 124.0 -0.2 
035C: place_object " + tmp_201 + @"[11] relative_to_car 38@ with_offset -3.0 128.0 -0.2 
035C: place_object " + tmp_201 + @"[12] relative_to_car 38@ with_offset 3.0 128.0 -0.2 
035C: place_object " + tmp_201 + @"[13] relative_to_car 38@ with_offset 0.0 128.0 -0.2 

:BSKOOL_23901
if 
  " + _247 + @" == 6 
else_jump @BSKOOL_24080 
035C: place_object " + tmp_201 + @"[7] relative_to_car 38@ with_offset -3.0 110.0 -0.2 
035C: place_object " + tmp_201 + @"[8] relative_to_car 38@ with_offset 3.0 110.0 -0.2 
035C: place_object " + tmp_201 + @"[9] relative_to_car 38@ with_offset -3.0 114.0 -0.2 
035C: place_object " + tmp_201 + @"[10] relative_to_car 38@ with_offset 3.0 114.0 -0.2 
035C: place_object " + tmp_201 + @"[11] relative_to_car 38@ with_offset -3.0 118.0 -0.2 
035C: place_object " + tmp_201 + @"[12] relative_to_car 38@ with_offset 3.0 118.0 -0.2 
035C: place_object " + tmp_201 + @"[13] relative_to_car 38@ with_offset 0.0 118.0 -0.2 

:BSKOOL_24080
return" );
            }

        }

    }

}