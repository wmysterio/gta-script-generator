using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class FREIGHT : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @FREIGHT_80 
if 
wasted_or_busted 
else_jump @FREIGHT_38 
gosub @FREIGHT_2819 

:FREIGHT_38
gosub @FREIGHT_3174 
if 
  " + _8239 + @" == 1 
else_jump @FREIGHT_78" );
create_thread<FRTEXT>();
AppendLine( @"" + _8239 + @" = 2 

:FREIGHT_78
end_thread 

:FREIGHT_80
Player.ClearWantedLevel(" + PlayerChar + @")
03C7: set_sensitivity_to_crime 0.0 
135@ = 999999.0 
" + OnMission + @" = 1 
" + _161 + @" = 1 
130@ = 0 
126@ = 0 
125@ = 0 
if 
  " + _163 + @" == 0 
else_jump @FREIGHT_162 
" + _163 + @" = 1 

:FREIGHT_162
45@ = 1698.826 
65@ = -1953.75 
85@ = 12.5469 
34@ = 150000 
39@ = 60000 
46@ = 789.4952 
66@ = -1343.796 
86@ = -2.5794 
35@ = 60000 
40@ = 140000 
47@ = -1943.241 
67@ = 159.585 
87@ = 24.7186 
36@ = 140000 
41@ = 150000 
48@ = 1463.359 
68@ = 2632.25 
88@ = 9.8203 
37@ = 150000 
42@ = 105000 
49@ = 2864.623 
69@ = 1248.266 
89@ = 9.8203 
38@ = 105000 
43@ = 150000 
if 
  " + _163 + @" == 1 
else_jump @FREIGHT_438 
127@ = 15000 

:FREIGHT_438
if 
  " + _163 + @" == 2 
else_jump @FREIGHT_464 
127@ = 10000 

:FREIGHT_464
if 
  " + _163 + @" == 3 
else_jump @FREIGHT_489 
127@ = 0 

:FREIGHT_489
129@ = 0 

:FREIGHT_496
005A: 34@(129@,5i) += 127@ 
005A: 39@(129@,5i) += 127@ 
129@ += 1 
  129@ >= 5 
else_jump @FREIGHT_496 
0169: set_fade_color_RGB 0 0 0 
" + OnMission + @" = 1 
if 
  " + _8239 + @" == 0 
else_jump @FREIGHT_576 
increment_mission_attempts 

:FREIGHT_576
054C: use_GXT_table 'FTRAIN' 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_627 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @FREIGHT_627 
" + tempvar_Actor_Car + @" = Actor.MissionCar(" + PlayerActor + @")

:FREIGHT_627
if 
  " + _8239 + @" == 0 
else_jump @FREIGHT_671 
01E3: show_text_1number_styled GXT 'FREI_04' number " + _163 + @" time 5000 style 4  
jump @FREIGHT_687 

:FREIGHT_671
00BA: show_text_styled GXT 'FREI_X' time 5000 style 4  

:FREIGHT_687
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_721 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:FREIGHT_721
0509: 134@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 1698.826 -1953.75 
if 
0025:   135@ > 134@ 
else_jump @FREIGHT_776 
0087: 135@ = 134@ 
125@ = 0 

:FREIGHT_776
0509: 134@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 789.4952 -1343.796 
if 
0025:   135@ > 134@ 
else_jump @FREIGHT_831 
0087: 135@ = 134@ 
125@ = 1 

:FREIGHT_831
0509: 134@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY -1943.241 159.585 
if 
0025:   135@ > 134@ 
else_jump @FREIGHT_886 
0087: 135@ = 134@ 
125@ = 2 

:FREIGHT_886
0509: 134@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 1463.359 2632.25 
if 
0025:   135@ > 134@ 
else_jump @FREIGHT_941 
0087: 135@ = 134@ 
125@ = 3 

:FREIGHT_941
0509: 134@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2864.623 1248.266 
if 
0025:   135@ > 134@ 
else_jump @FREIGHT_996 
0087: 135@ = 134@ 
125@ = 4 

:FREIGHT_996
Model.Load(#FREIBOX)
Model.Load(#STREAKC)
Model.Load(#FREIFLAT)
Model.Load(#STREAK)
Model.Load(#FREIGHT)

:FREIGHT_1021
if or
   not Model.Available(#FREIBOX)
   not Model.Available(#STREAKC)
   not Model.Available(#FREIFLAT)
   not Model.Available(#STREAK)
   not Model.Available(#FREIGHT)
else_jump @FREIGHT_1068 
wait 0 
jump @FREIGHT_1021 

:FREIGHT_1068
32@ = 0 
33@ = 0 
06DB: destroy_all_trains 
06D7: enable_train_traffic 0 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_1128 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @FREIGHT_1128 
" + tempvar_Actor_Car + @" = Actor.CurrentCar(" + PlayerActor + @")

:FREIGHT_1128
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @FREIGHT_1195 
if 
09E3:   train " + tempvar_Actor_Car + @" traveling_clockwise 
else_jump @FREIGHT_1181 
125@ += 1 
133@ = 0 
jump @FREIGHT_1195 

:FREIGHT_1181
125@ -= 1 
133@ = 1 

:FREIGHT_1195
if 
  125@ == 5 
else_jump @FREIGHT_1220 
125@ = 0 

:FREIGHT_1220
if 
  125@ == -1 
else_jump @FREIGHT_1245 
125@ = 4 

:FREIGHT_1245
gosub @FREIGHT_3349 
018A: 105@(125@,20i) = create_checkpoint_at 45@(125@,20f) 65@(125@,20f) 85@(125@,20f) 
if 
  133@ == 0 
else_jump @FREIGHT_1319 
008A: " + _8238 + @" = 34@(125@,5i) 
jump @FREIGHT_1331 

:FREIGHT_1319
008A: " + _8238 + @" = 39@(125@,5i) 

:FREIGHT_1331
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_2766 
wait 0 
if 
0736:   is_keyboard_key_just_pressed 65 
else_jump @FREIGHT_1373 
jump @FREIGHT_2258 

:FREIGHT_1373
if or
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAK)
   Actor.DrivingVehicleType(" + PlayerActor + @", #FREIGHT)
else_jump @FREIGHT_1442 
" + tempvar_Actor_Car + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
820D:   not car " + tempvar_Actor_Car + @" flipped 
else_jump @FREIGHT_1435 
00BE: text_clear_all 
03E6: remove_text_box 
jump @FREIGHT_2773 

:FREIGHT_1435
jump @FREIGHT_1453 

:FREIGHT_1442
00BE: text_clear_all 
03E6: remove_text_box 
jump @FREIGHT_2773 

:FREIGHT_1453
02E3: 137@ = car " + tempvar_Actor_Car + @" speed 
0090: " + _8242 + @" = float 137@ to_integer 
if and
  33@ > 3000 
  126@ == 0 
else_jump @FREIGHT_1515 
126@ = 1 
00BE: text_clear_all 
03E5: show_text_box 'FREI_03'  

:FREIGHT_1515
if and
  33@ > 8000 
  126@ == 1 
else_jump @FREIGHT_1603 
126@ = 2 
00BE: text_clear_all 
03E6: remove_text_box 
if 
  " + _8243 + @" == 0 
else_jump @FREIGHT_1588 
03E5: show_text_box 'FREI_12'  
jump @FREIGHT_1603 

:FREIGHT_1588
33@ = 18000 
126@ = 3 

:FREIGHT_1603
if and
  33@ > 12000 
  126@ == 2 
else_jump @FREIGHT_1691 
126@ = 3 
00BE: text_clear_all 
03E6: remove_text_box 
if 
  " + _8243 + @" == 0 
else_jump @FREIGHT_1676 
03E5: show_text_box 'FREI_13'  
jump @FREIGHT_1691 

:FREIGHT_1676
33@ = 18000 
126@ = 3 

:FREIGHT_1691
if and
  33@ > 16000 
  126@ == 3 
else_jump @FREIGHT_2038 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_1747 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:FREIGHT_1747
136@ = 0.0 
" + _8238 + @" = 0 
0509: 136@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 45@(125@,20f) 65@(125@,20f) 
0090: " + _8241 + @" = float 136@ to_integer 
if 
  136@ > 3000.0 
else_jump @FREIGHT_1835 
136@ /= 0.021 
jump @FREIGHT_1845 

:FREIGHT_1835
136@ /= 0.019 

:FREIGHT_1845
if 
  10000.0 > 136@ 
else_jump @FREIGHT_1876 
136@ = 10000.0 

:FREIGHT_1876
0090: " + _8238 + @" = float 136@ to_integer 
if 
  " + _163 + @" == 1 
else_jump @FREIGHT_1910 
127@ = 15000 

:FREIGHT_1910
if 
  " + _163 + @" == 2 
else_jump @FREIGHT_1935 
127@ = 0 

:FREIGHT_1935
if 
  " + _163 + @" == 3 
else_jump @FREIGHT_1960 
127@ = 0 

:FREIGHT_1960
005E: " + _8238 + @" += 127@ 
126@ = 4 
" + _8243 + @" = 1 
03C3: set_timer_to " + _8238 + @" type 1 GXT 'FREI_14' 
04F7: status_text " + _8241 + @" type 0 line 1 GXT 'FREI_10' 
04F7: status_text " + _8242 + @" type 0 line 2 GXT 'FREI_11' 
00BE: text_clear_all 
03E6: remove_text_box 

:FREIGHT_2038
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_2068 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:FREIGHT_2068
0509: 136@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 45@(125@,20f) 65@(125@,20f) 
0090: " + _8241 + @" = float 136@ to_integer 
if 
0981:   train " + tempvar_Actor_Car + @" wrecked 
else_jump @FREIGHT_2124 
jump @FREIGHT_2819 

:FREIGHT_2124
if 
00E1:   player 0 pressed_key 19 
else_jump @FREIGHT_2152 
00BE: text_clear_all 
03E6: remove_text_box 
jump @FREIGHT_2773 

:FREIGHT_2152
if 
  0 >= " + _8238 + @" 
else_jump @FREIGHT_2177 
jump @FREIGHT_2819 

:FREIGHT_2177
if 
0101:   actor " + PlayerActor + @" in_sphere 45@(125@,20f) 65@(125@,20f) 85@(125@,20f) radius 10.0 10.0 10.0 sphere 1 stopped 
else_jump @FREIGHT_2522 
if or
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAK)
   Actor.DrivingVehicleType(" + PlayerActor + @", #FREIGHT)
else_jump @FREIGHT_2522 

:FREIGHT_2258
if 
075C:   marker 105@(125@,20i) enabled 
else_jump @FREIGHT_2287 
Marker.Disable(105@(125@,20i))

:FREIGHT_2287
130@ += 1 
008B: 127@ = " + _8238 + @" 
014F: stop_timer " + _8238 + @" 
0151: remove_status_text " + _8241 + @" 
0151: remove_status_text " + _8242 + @" 
if 
  130@ == 5 
else_jump @FREIGHT_2342 
jump @FREIGHT_2905 

:FREIGHT_2342
if 
  133@ == 0 
else_jump @FREIGHT_2374 
125@ += 1 
jump @FREIGHT_2381 

:FREIGHT_2374
125@ -= 1 

:FREIGHT_2381
if 
  125@ == 5 
else_jump @FREIGHT_2406 
125@ = 0 

:FREIGHT_2406
if 
  125@ == -1 
else_jump @FREIGHT_2431 
125@ = 4 

:FREIGHT_2431
if 
  127@ > 15000 
else_jump @FREIGHT_2458 
127@ = 15000 

:FREIGHT_2458
0085: 128@ = 127@ 
128@ /= 100 
006E: 128@ *= " + _163 + @" 
01E3: show_text_1number_styled GXT 'FREI_07' number 128@ time 3000 style 1  
Player.Money(" + PlayerChar + @") += 128@
32@ = 0 
132@ = 1 

:FREIGHT_2522
if and
  132@ == 1 
  32@ > 6000 
else_jump @FREIGHT_2759 
0085: 128@ = 127@ 
128@ /= 1000 
01E3: show_text_1number_styled GXT 'FREI_05' number 128@ time 4000 style 6  
" + _8238 + @" = 0 
if 
  133@ == 0 
else_jump @FREIGHT_2635 
008A: " + _8238 + @" = 34@(125@,5i) 
005E: " + _8238 + @" += 127@ 
jump @FREIGHT_2655 

:FREIGHT_2635
008A: " + _8238 + @" = 39@(125@,5i) 
005E: " + _8238 + @" += 127@ 

:FREIGHT_2655
014F: stop_timer " + _8238 + @" 
0151: remove_status_text " + _8241 + @" 
0151: remove_status_text " + _8242 + @" 
03C3: set_timer_to " + _8238 + @" type 1 GXT 'FREI_14' 
04F7: status_text " + _8241 + @" type 0 line 1 GXT 'FREI_10' 
04F7: status_text " + _8242 + @" type 0 line 2 GXT 'FREI_11' 
018A: 105@(125@,20i) = create_checkpoint_at 45@(125@,20f) 65@(125@,20f) 85@(125@,20f) 
132@ = 0 

:FREIGHT_2759
jump @FREIGHT_1331 

:FREIGHT_2766
jump @FREIGHT_2819 

:FREIGHT_2773
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
00BE: text_clear_all 
03E6: remove_text_box 
00BA: show_text_styled GXT 'FREI_02' time 5000 style 1  
014F: stop_timer " + _8238 + @" 
0151: remove_status_text " + _8241 + @" 
0151: remove_status_text " + _8242 + @" 
wait 2000 
return 

:FREIGHT_2819
if 
075C:   marker 105@(125@,20i) enabled 
else_jump @FREIGHT_2848 
Marker.Disable(105@(125@,20i))

:FREIGHT_2848
014F: stop_timer " + _8238 + @" 
0151: remove_status_text " + _8241 + @" 
0151: remove_status_text " + _8242 + @" 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
03E6: remove_text_box 
00BE: text_clear_all 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
00BC: show_text_highpriority GXT 'FREI_06' time 4000 flag 1  
return 

:FREIGHT_2905
if 
  " + _163 + @" == 2 
else_jump @FREIGHT_3032 
if 
  " + _8239 + @" == 0 
else_jump @FREIGHT_2976 
01E3: show_text_1number_styled GXT 'M_PASS' number 50000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 50000
0394: play_music 2 

:FREIGHT_2976
if 
  " + _8239 + @" == 2 
else_jump @FREIGHT_3025 
01E3: show_text_1number_styled GXT 'M_PASS' number 10000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 10000
0394: play_music 2 

:FREIGHT_3025
jump @FREIGHT_3051 

:FREIGHT_3032
01E3: show_text_1number_styled GXT 'FREI_15' number " + _163 + @" time 5000 style 1  

:FREIGHT_3051
if and
  " + _8240 + @" == 0 
  " + _163 + @" == 1 
else_jump @FREIGHT_3085 
0595: mission_complete 
" + _8240 + @" = 1 

:FREIGHT_3085
if and
  " + _8239 + @" == 0 
  " + _163 + @" == 2 
else_jump @FREIGHT_3119 
0595: mission_complete 
" + _8239 + @" = 1 

:FREIGHT_3119
014F: stop_timer " + _8238 + @" 
0151: remove_status_text " + _8241 + @" 
0151: remove_status_text " + _8242 + @" 
Player.ClearWantedLevel(" + PlayerChar + @")
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0394: play_music 1 
if 
   not " + _163 + @" == 2 
else_jump @FREIGHT_3172 
" + _163 + @" += 1 

:FREIGHT_3172
return 

:FREIGHT_3174
if 
075C:   marker 105@(125@,20i) enabled 
else_jump @FREIGHT_3203 
Marker.Disable(105@(125@,20i))

:FREIGHT_3203
Model.Destroy(#FREIBOX)
Model.Destroy(#STREAKC)
Model.Destroy(#FREIFLAT)
Model.Destroy(#STREAK)
Model.Destroy(#FREIGHT)
" + OnMission + @" = 0 
" + _161 + @" = 0 
Player.ClearWantedLevel(" + PlayerChar + @")
0151: remove_status_text " + _8241 + @" 
0151: remove_status_text " + _8242 + @" 
014F: stop_timer " + _8238 + @" 
Player.ClearWantedLevel(" + PlayerChar + @")
03C7: set_sensitivity_to_crime 1.0 
mission_cleanup 
return 
02A3: enable_widescreen 1 
Player.CanMove(" + PlayerChar + @") = False
return 
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
return 
0169: set_fade_color_RGB 0 0 0 
fade 0 2000 

:FREIGHT_3323
if 
fading 
else_jump @FREIGHT_3347 
wait 0 
jump @FREIGHT_3323 

:FREIGHT_3347
return 

:FREIGHT_3349
0169: set_fade_color_RGB 0 0 0 
fade 1 2000 

:FREIGHT_3364
if 
fading 
else_jump @FREIGHT_3388 
wait 0 
jump @FREIGHT_3364 

:FREIGHT_3388
return 
if 
0736:   is_keyboard_key_just_pressed 83 
else_jump @FREIGHT_3405 

:FREIGHT_3405
if 
0736:   is_keyboard_key_just_pressed 68 
else_jump @FREIGHT_3420 

:FREIGHT_3420
if 
0736:   is_keyboard_key_just_pressed 70 
else_jump @FREIGHT_3435 

:FREIGHT_3435
if 
0736:   is_keyboard_key_just_pressed 66 
else_jump @FREIGHT_3450 

:FREIGHT_3450
if 
0736:   is_keyboard_key_just_pressed 75 
else_jump @FREIGHT_3486 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_3486 
05BE: AS_actor " + PlayerActor + @" die 

:FREIGHT_3486
if 
0736:   is_keyboard_key_just_pressed 72 
else_jump @FREIGHT_3531 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FREIGHT_3531 
Actor.AddArmour(" + PlayerActor + @", 100)
055E: set_player " + PlayerChar + @" max_health += 100 

:FREIGHT_3531
return" );
            }

        }

    }

}