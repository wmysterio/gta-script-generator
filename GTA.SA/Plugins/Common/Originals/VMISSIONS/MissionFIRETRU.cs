using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class FIRETRU : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @FIRETRU_16 
gosub @FIRETRU_10460 
end_thread 

:FIRETRU_16
" + OnMission + @" = 1 
" + ONMISSION_Firefighter + @" = 1 
wait 0 
if 
  " + _1489 + @" == 0 
else_jump @FIRETRU_65 
increment_mission_attempts 

:FIRETRU_65
060A: create_decision_maker_type 0 store_to 165@ 
054C: use_GXT_table 'FIRETRK' 
08F8: display_stat_update_box 0 
162@ = 0.0 
" + _8215 + @" = 0 
79@ = 0 
80@ = 0 
" + _8214 + @" = 0 
81@ = 0 
83@ = 0 
82@ = 0 
121@ = 7.0 
" + _8213 + @" = 1
77@ = 0 
126@ = 0 
78@ = 0 
84@ = 0 
35@ = -1 
35@ = -1 
35@ = -1 
87@ = 0 
54@ = 0 
55@ = 0 
56@ = 0 
57@ = 0 
58@ = 0 
59@ = 0 
60@ = 0 
61@ = 0 
62@ = 0 
104@ = 0 
105@ = 0 
106@ = 0 
107@ = 0 
108@ = 0 
109@ = 0 
110@ = 0 
111@ = 0 
112@ = 0 
113@ = 0 
114@ = 0 
115@ = 0 
116@ = 0 
117@ = 0 
118@ = 0 
119@ = 0 
" + _8221 + @" = 0 
" + _8220 + @" = 0 
03C7: set_sensitivity_to_crime 0.5 
if 
  " + OnMission + @" == 0 
else_jump @FIRETRU_789 
018A: 63@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 64@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 65@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 66@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 67@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 68@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 69@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 70@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 71@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 72@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 73@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 74@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 75@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
018A: 76@ = create_checkpoint_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
35@ = Car.Create(#PATRIOT, 0.0, 0.0, 0.0)
39@ = Actor.Create(Mission1, #LAPD1, 0.0, 0.0, 0.0)
0325: 49@ = create_car 35@ fire 
0325: 50@ = create_car 35@ fire 
0325: 51@ = create_car 35@ fire 
0325: 52@ = create_car 35@ fire 
0326: 53@ = create_actor 39@ fire 
0326: 54@ = create_actor 39@ fire 
0326: 55@ = create_actor 39@ fire 
0326: 56@ = create_actor 39@ fire 
0326: 57@ = create_actor 39@ fire 
0326: 58@ = create_actor 39@ fire 
0326: 59@ = create_actor 39@ fire 
0326: 60@ = create_actor 39@ fire 
0326: 61@ = create_actor 39@ fire 
0326: 62@ = create_actor 39@ fire 

:FIRETRU_789
88@ = 0 
89@ = 0 
92@ = 0 
93@ = 0 
94@ = 0 
95@ = 0 
96@ = 0 
97@ = 0 
98@ = 0 
99@ = 0 
100@ = 0 
101@ = 0 
102@ = 0 
103@ = 0 
104@ = 0 
105@ = 0 
106@ = 0 
107@ = 0 
108@ = 0 
109@ = 0 
110@ = 0 
111@ = 0 
112@ = 0 
113@ = 0 
114@ = 0 
115@ = 0 
116@ = 0 
117@ = 0 
118@ = 0 
0209: 125@ = random_int_in_ranges 25 44 
if 
  125@ == 25 
else_jump @FIRETRU_1027 
04AF: 126@ = 405 

:FIRETRU_1027
if 
  125@ == 26 
else_jump @FIRETRU_1053 
04AF: 126@ = 418 

:FIRETRU_1053
if 
  125@ == 27 
else_jump @FIRETRU_1079 
04AF: 126@ = 421 

:FIRETRU_1079
if 
  125@ == 28 
else_jump @FIRETRU_1105 
04AF: 126@ = 400 

:FIRETRU_1105
if 
  125@ == 29 
else_jump @FIRETRU_1131 
04AF: 126@ = 404 

:FIRETRU_1131
if 
  125@ == 30 
else_jump @FIRETRU_1157 
04AF: 126@ = 445 

:FIRETRU_1157
if 
  125@ == 31 
else_jump @FIRETRU_1183 
04AF: 126@ = 466 

:FIRETRU_1183
if 
  125@ == 32 
else_jump @FIRETRU_1209 
04AF: 126@ = 467 

:FIRETRU_1209
if 
  125@ == 33 
else_jump @FIRETRU_1235 
04AF: 126@ = 479 

:FIRETRU_1235
if 
  125@ == 34 
else_jump @FIRETRU_1261 
04AF: 126@ = 413 

:FIRETRU_1261
if 
  125@ == 35 
else_jump @FIRETRU_1287 
04AF: 126@ = 420 

:FIRETRU_1287
if 
  125@ == 36 
else_jump @FIRETRU_1313 
04AF: 126@ = 438 

:FIRETRU_1313
if 
  125@ == 37 
else_jump @FIRETRU_1339 
04AF: 126@ = 440 

:FIRETRU_1339
if 
  125@ == 38 
else_jump @FIRETRU_1365 
04AF: 126@ = 551 

:FIRETRU_1365
if 
  125@ == 39 
else_jump @FIRETRU_1391 
04AF: 126@ = 470 

:FIRETRU_1391
if 
  125@ == 40 
else_jump @FIRETRU_1417 
04AF: 126@ = 482 

:FIRETRU_1417
if 
  125@ == 41 
else_jump @FIRETRU_1443 
04AF: 126@ = 546 

:FIRETRU_1443
if 
  125@ == 42 
else_jump @FIRETRU_1469 
04AF: 126@ = 492 

:FIRETRU_1469
if 
  125@ == 43 
else_jump @FIRETRU_1495 
04AF: 126@ = 560 

:FIRETRU_1495
Model.Load(126@)
wait 0 
gosub @FIRETRU_8348 
if 
  77@ == 1 
else_jump @FIRETRU_1536 
jump @FIRETRU_10460 

:FIRETRU_1536
if 
   not Model.Available(126@)
else_jump @FIRETRU_1600 
wait 0 
Model.Load(126@)
gosub @FIRETRU_8348 
if 
  77@ == 1 
else_jump @FIRETRU_1593 
jump @FIRETRU_10460 

:FIRETRU_1593
jump @FIRETRU_1536 

:FIRETRU_1600
119@ = 0 
gosub @FIRETRU_5971 
0087: 127@ = 153@ 
0087: 128@ = 154@ 
0087: 129@ = 155@ 
0395: clear_area 0 at 127@ 128@ 129@ radius 5.0 
35@ = Car.Create(126@, 127@, 128@, 129@)
0574: set_car 35@ keep_position 1 
Car.Angle(35@) = 160@
0587: enable_car 35@ validate_position 0 
Car.SetImmunities(35@, 0, 1, 0, 0, 0)
0208: 123@ = random_float_in_ranges 0.0 359.9 
Car.Angle(35@) = 123@
0325: 50@ = create_car 35@ fire 
Marker.Disable(64@)
64@ = Marker.CreateAboveCar(35@)
07E0: set_marker 64@ type_to 1 
018B: set_marker 64@ radar_mode 2 
03ED: set_car 35@ disable_flipped_explosion_when_empty 1 
119@ = 1 
88@ += 1 
0560: create_random_actor_in_car 35@ handle_as 40@ 
060B: set_actor 40@ decision_maker_to 165@ 
0588: disable_actor 40@ validate_position 0 
02A9: set_actor 40@ immune_to_nonplayer 1 
Actor.SetImmunities(40@, 0, 1, 1, 0, 0)
88@ += 1 
if 
  " + _8213 + @" > 2 
else_jump @FIRETRU_1913 
0561: 41@ = create_passenger_in_car 35@ seat 0 
060B: set_actor 41@ decision_maker_to 165@ 
0588: disable_actor 41@ validate_position 0 
02A9: set_actor 41@ immune_to_nonplayer 1 
Actor.SetImmunities(41@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_1913
if 
  " + _8213 + @" > 3 
else_jump @FIRETRU_1985 
0561: 42@ = create_passenger_in_car 35@ seat 1 
060B: set_actor 42@ decision_maker_to 165@ 
0588: disable_actor 42@ validate_position 0 
02A9: set_actor 42@ immune_to_nonplayer 1 
Actor.SetImmunities(42@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_1985
if 
  " + _8213 + @" > 4 
else_jump @FIRETRU_2176 
gosub @FIRETRU_5971 
0087: 130@ = 153@ 
0087: 131@ = 154@ 
0087: 132@ = 155@ 
0395: clear_area 0 at 130@ 131@ 132@ radius 5.0 
36@ = Car.Create(126@, 130@, 131@, 132@)
0574: set_car 36@ keep_position 1 
Car.Angle(36@) = 160@
0587: enable_car 36@ validate_position 0 
Car.SetImmunities(36@, 0, 1, 0, 0, 0)
039F: set_car 36@ race_to 127@ 128@ 
0325: 51@ = create_car 36@ fire 
Car.SetSpeedInstantly(36@, 20.0)
Marker.Disable(65@)
65@ = Marker.CreateAboveCar(36@)
07E0: set_marker 65@ type_to 1 
018B: set_marker 65@ radar_mode 2 
03ED: set_car 36@ disable_flipped_explosion_when_empty 1 
88@ += 1 

:FIRETRU_2176
if 
  " + _8213 + @" > 5 
else_jump @FIRETRU_2246 
0560: create_random_actor_in_car 36@ handle_as 43@ 
060B: set_actor 43@ decision_maker_to 165@ 
0588: disable_actor 43@ validate_position 0 
02A9: set_actor 43@ immune_to_nonplayer 1 
Actor.SetImmunities(43@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_2246
if 
  " + _8213 + @" > 6 
else_jump @FIRETRU_2318 
0561: 44@ = create_passenger_in_car 36@ seat 0 
060B: set_actor 44@ decision_maker_to 165@ 
0588: disable_actor 44@ validate_position 0 
02A9: set_actor 44@ immune_to_nonplayer 1 
Actor.SetImmunities(44@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_2318
if 
  " + _8213 + @" > 7 
else_jump @FIRETRU_2390 
0561: 45@ = create_passenger_in_car 36@ seat 1 
060B: set_actor 45@ decision_maker_to 165@ 
0588: disable_actor 45@ validate_position 0 
02A9: set_actor 45@ immune_to_nonplayer 1 
Actor.SetImmunities(45@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_2390
if 
  " + _8213 + @" > 8 
else_jump @FIRETRU_2581 
gosub @FIRETRU_5971 
0087: 133@ = 153@ 
0087: 134@ = 154@ 
0087: 135@ = 155@ 
0395: clear_area 0 at 133@ 134@ 135@ radius 5.0 
37@ = Car.Create(126@, 133@, 134@, 135@)
0574: set_car 37@ keep_position 1 
Car.Angle(37@) = 160@
0587: enable_car 37@ validate_position 0 
Car.SetImmunities(37@, 0, 1, 0, 0, 0)
039F: set_car 37@ race_to 127@ 128@ 
0325: 52@ = create_car 37@ fire 
Car.SetSpeedInstantly(37@, 20.0)
Marker.Disable(66@)
66@ = Marker.CreateAboveCar(37@)
07E0: set_marker 66@ type_to 1 
018B: set_marker 66@ radar_mode 2 
03ED: set_car 37@ disable_flipped_explosion_when_empty 1 
88@ += 1 

:FIRETRU_2581
Model.Destroy(126@)
if 
  " + _8213 + @" > 9 
else_jump @FIRETRU_2656 
0560: create_random_actor_in_car 37@ handle_as 46@ 
060B: set_actor 46@ decision_maker_to 165@ 
0588: disable_actor 46@ validate_position 0 
02A9: set_actor 46@ immune_to_nonplayer 1 
Actor.SetImmunities(46@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_2656
if 
  " + _8213 + @" > 10 
else_jump @FIRETRU_2728 
0561: 47@ = create_passenger_in_car 37@ seat 0 
060B: set_actor 47@ decision_maker_to 165@ 
0588: disable_actor 47@ validate_position 0 
02A9: set_actor 47@ immune_to_nonplayer 1 
Actor.SetImmunities(47@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_2728
if 
  " + _8213 + @" > 11 
else_jump @FIRETRU_2800 
0561: 48@ = create_passenger_in_car 37@ seat 1 
060B: set_actor 48@ decision_maker_to 165@ 
0588: disable_actor 48@ validate_position 0 
02A9: set_actor 48@ immune_to_nonplayer 1 
Actor.SetImmunities(48@, 0, 1, 1, 0, 0)
88@ += 1 

:FIRETRU_2800
if 
   not Car.Wrecked(35@)
else_jump @FIRETRU_2823 
Car.SetDriverBehaviour(35@, 11)

:FIRETRU_2823
if 
   not Car.Wrecked(36@)
else_jump @FIRETRU_2846 
Car.SetDriverBehaviour(36@, 11)

:FIRETRU_2846
if 
   not Car.Wrecked(37@)
else_jump @FIRETRU_2869 
Car.SetDriverBehaviour(37@, 11)

:FIRETRU_2869
gosub @FIRETRU_8348 
if 
  77@ == 1 
else_jump @FIRETRU_2901 
jump @FIRETRU_10460 

:FIRETRU_2901
if 
   not Actor.Dead(40@)
else_jump @FIRETRU_3008 
Actor.StorePos(40@, 146@, 147@, 148@)
0843: get_zone_at 146@ 147@ 148@ nameA_to " + _8216 + @" 
if 
  5 > " + _8213 + @" 
else_jump @FIRETRU_2989 
0384: show_text_1string GXT 'F_START' string " + _8216 + @" time 5000 1  
jump @FIRETRU_3008 

:FIRETRU_2989
0384: show_text_1string GXT 'F_STAR1' string " + _8216 + @" time 5000 1  

:FIRETRU_3008
if 
  " + _8213 + @" == 1 
else_jump @FIRETRU_3038 
88@ -= 1 
Actor.DestroyInstantly(40@)

:FIRETRU_3038
if 
  80@ == 0 
else_jump @FIRETRU_3104 
03C3: set_timer_to " + _8215 + @" type 1 GXT 'FIRTIME' 
04F7: status_text " + _8213 + @" type 0 line 1 GXT 'FLEV' 
80@ = 1 
jump @FIRETRU_3108 

:FIRETRU_3104
0396: pause_timer 0 

:FIRETRU_3108
008B: 85@ = " + _8213 + @" 
85@ -= 4 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
008B: 87@ = " + Current_Time_in_ms2 + @" 
87@ += 3000 

:FIRETRU_3144
if 
0735:   is_keyboard_key_pressed 32 
else_jump @FIRETRU_3169 
" + _8215 + @" = 300000 

:FIRETRU_3169
if 
0735:   is_keyboard_key_pressed 137 
else_jump @FIRETRU_3311 
if 
   not Car.Wrecked(35@)
else_jump @FIRETRU_3215 
03F5: set_car 35@ apply_damage_rules 0 
03F5: set_car 35@ apply_damage_rules 1 

:FIRETRU_3215
if 
  " + _8213 + @" > 4 
else_jump @FIRETRU_3263 
if 
   not Car.Wrecked(36@)
else_jump @FIRETRU_3263 
03F5: set_car 36@ apply_damage_rules 0 
03F5: set_car 36@ apply_damage_rules 1 

:FIRETRU_3263
if 
  " + _8213 + @" > 8 
else_jump @FIRETRU_3311 
if 
   not Car.Wrecked(37@)
else_jump @FIRETRU_3311 
03F5: set_car 37@ apply_damage_rules 0 
03F5: set_car 37@ apply_damage_rules 1 

:FIRETRU_3311
if 
0735:   is_keyboard_key_pressed 83 
else_jump @FIRETRU_3347 
" + _1489 + @" = 0 
" + _8213 + @" = 12 
jump @FIRETRU_9900 

:FIRETRU_3347
if 
0735:   is_keyboard_key_pressed 90 
else_jump @FIRETRU_3515 
014F: stop_timer " + _8215 + @" 
0151: remove_status_text " + _8214 + @" 
0151: remove_status_text " + _8213 + @" 
03D5: remove_text 'F_START'  
03D5: remove_text 'F_STAR1'  
03D5: remove_text 'FIRELVL'  
00BA: show_text_styled GXT 'F_PASS1' time 5000 style 5  
008B: 79@ = " + _8213 + @" 
006E: 79@ *= " + _8213 + @" 
79@ *= 50 
005A: 83@ += 79@ 
01E3: show_text_1number_styled GXT 'REWARD' number 79@ time 6000 style 6  
Player.Money(" + PlayerChar + @") += 79@
01E3: show_text_1number_styled GXT 'F_COMP1' number 5000 time 5000 style 5  
Player.Money(" + PlayerChar + @") += 5000
0394: play_music 2 

:FIRETRU_3515
if 
  77@ == 1 
else_jump @FIRETRU_3540 
jump @FIRETRU_10460 

:FIRETRU_3540
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
gosub @FIRETRU_8348 
if 
  77@ == 1 
else_jump @FIRETRU_3581 
jump @FIRETRU_10460 

:FIRETRU_3581
if 
  2 > " + Help_Firetruck_Shown + @" 
else_jump @FIRETRU_3778 
if 
  " + Help_Firetruck_Shown + @" == 0 
else_jump @FIRETRU_3701 
if 
88FE:   not text_box_displayed 
else_jump @FIRETRU_3694 
if 
876F:   not text_priority_displayed 
else_jump @FIRETRU_3687 
if 
  32@ > 1000 
else_jump @FIRETRU_3680 
03E5: show_text_box 'SPRAY_1'  
" + Help_Firetruck_Shown + @" = 1 

:FIRETRU_3680
jump @FIRETRU_3694 

:FIRETRU_3687
32@ = 0 

:FIRETRU_3694
jump @FIRETRU_3778 

:FIRETRU_3701
if 
88FE:   not text_box_displayed 
else_jump @FIRETRU_3778 
if 
876F:   not text_priority_displayed 
else_jump @FIRETRU_3771 
if 
  32@ > 1000 
else_jump @FIRETRU_3764 
03E5: show_text_box 'SIREN_1'  
" + Help_Firetruck_Shown + @" = 2 

:FIRETRU_3764
jump @FIRETRU_3778 

:FIRETRU_3771
32@ = 0 

:FIRETRU_3778
if 
   not Car.Wrecked(35@)
else_jump @FIRETRU_4161 
if 
0205:   actor " + PlayerActor + @" near_car 35@ radius 50.0 50.0 10.0 flag 0 
else_jump @FIRETRU_3999 
if 
  104@ == 0 
else_jump @FIRETRU_3992 
0587: enable_car 35@ validate_position 1 
0574: set_car 35@ keep_position 0 
104@ = 1 
if 
  " + _8213 + @" > 1 
else_jump @FIRETRU_3910 
if 
   not Actor.Dead(40@)
else_jump @FIRETRU_3910 
0588: disable_actor 40@ validate_position 1 

:FIRETRU_3910
if 
  " + _8213 + @" > 2 
else_jump @FIRETRU_3951 
if 
   not Actor.Dead(41@)
else_jump @FIRETRU_3951 
0588: disable_actor 41@ validate_position 1 

:FIRETRU_3951
if 
  " + _8213 + @" > 3 
else_jump @FIRETRU_3992 
if 
   not Actor.Dead(42@)
else_jump @FIRETRU_3992 
0588: disable_actor 42@ validate_position 1 

:FIRETRU_3992
jump @FIRETRU_4161 

:FIRETRU_3999
if 
  104@ == 1 
else_jump @FIRETRU_4161 
0587: enable_car 35@ validate_position 0 
0574: set_car 35@ keep_position 1 
104@ = 0 
if 
  " + _8213 + @" > 1 
else_jump @FIRETRU_4079 
if 
   not Actor.Dead(40@)
else_jump @FIRETRU_4079 
0588: disable_actor 40@ validate_position 0 

:FIRETRU_4079
if 
  " + _8213 + @" > 2 
else_jump @FIRETRU_4120 
if 
   not Actor.Dead(41@)
else_jump @FIRETRU_4120 
0588: disable_actor 41@ validate_position 0 

:FIRETRU_4120
if 
  " + _8213 + @" > 3 
else_jump @FIRETRU_4161 
if 
   not Actor.Dead(42@)
else_jump @FIRETRU_4161 
0588: disable_actor 42@ validate_position 0 

:FIRETRU_4161
if 
  " + _8213 + @" > 4 
else_jump @FIRETRU_4963 
if 
   not Car.Wrecked(36@)
else_jump @FIRETRU_4562 
if 
0205:   actor " + PlayerActor + @" near_car 36@ radius 50.0 50.0 10.0 flag 0 
else_jump @FIRETRU_4400 
if 
  105@ == 0 
else_jump @FIRETRU_4393 
0587: enable_car 36@ validate_position 1 
0574: set_car 36@ keep_position 0 
105@ = 1 
if 
  " + _8213 + @" > 5 
else_jump @FIRETRU_4311 
if 
   not Actor.Dead(43@)
else_jump @FIRETRU_4311 
0588: disable_actor 43@ validate_position 1 

:FIRETRU_4311
if 
  " + _8213 + @" > 6 
else_jump @FIRETRU_4352 
if 
   not Actor.Dead(44@)
else_jump @FIRETRU_4352 
0588: disable_actor 44@ validate_position 1 

:FIRETRU_4352
if 
  " + _8213 + @" > 7 
else_jump @FIRETRU_4393 
if 
   not Actor.Dead(45@)
else_jump @FIRETRU_4393 
0588: disable_actor 45@ validate_position 1 

:FIRETRU_4393
jump @FIRETRU_4562 

:FIRETRU_4400
if 
  105@ == 1 
else_jump @FIRETRU_4562 
0587: enable_car 36@ validate_position 0 
0574: set_car 36@ keep_position 1 
105@ = 0 
if 
  " + _8213 + @" > 5 
else_jump @FIRETRU_4480 
if 
   not Actor.Dead(43@)
else_jump @FIRETRU_4480 
0588: disable_actor 43@ validate_position 0 

:FIRETRU_4480
if 
  " + _8213 + @" > 6 
else_jump @FIRETRU_4521 
if 
   not Actor.Dead(44@)
else_jump @FIRETRU_4521 
0588: disable_actor 44@ validate_position 0 

:FIRETRU_4521
if 
  " + _8213 + @" > 7 
else_jump @FIRETRU_4562 
if 
   not Actor.Dead(45@)
else_jump @FIRETRU_4562 
0588: disable_actor 45@ validate_position 0 

:FIRETRU_4562
if 
  " + _8213 + @" > 8 
else_jump @FIRETRU_4963 
if 
   not Car.Wrecked(37@)
else_jump @FIRETRU_4963 
if 
0205:   actor " + PlayerActor + @" near_car 37@ radius 50.0 50.0 10.0 flag 0 
else_jump @FIRETRU_4801 
if 
  106@ == 0 
else_jump @FIRETRU_4794 
0587: enable_car 37@ validate_position 1 
0574: set_car 37@ keep_position 0 
if 
  " + _8213 + @" > 9 
else_jump @FIRETRU_4705 
if 
   not Actor.Dead(46@)
else_jump @FIRETRU_4705 
0588: disable_actor 46@ validate_position 1 

:FIRETRU_4705
if 
  " + _8213 + @" > 10 
else_jump @FIRETRU_4746 
if 
   not Actor.Dead(47@)
else_jump @FIRETRU_4746 
0588: disable_actor 47@ validate_position 1 

:FIRETRU_4746
if 
  " + _8213 + @" > 11 
else_jump @FIRETRU_4787 
if 
   not Actor.Dead(48@)
else_jump @FIRETRU_4787 
0588: disable_actor 48@ validate_position 1 

:FIRETRU_4787
106@ = 1 

:FIRETRU_4794
jump @FIRETRU_4963 

:FIRETRU_4801
if 
  106@ == 1 
else_jump @FIRETRU_4963 
0587: enable_car 37@ validate_position 0 
0574: set_car 37@ keep_position 1 
106@ = 0 
if 
  " + _8213 + @" > 9 
else_jump @FIRETRU_4881 
if 
   not Actor.Dead(46@)
else_jump @FIRETRU_4881 
0588: disable_actor 46@ validate_position 0 

:FIRETRU_4881
if 
  " + _8213 + @" > 10 
else_jump @FIRETRU_4922 
if 
   not Actor.Dead(47@)
else_jump @FIRETRU_4922 
0588: disable_actor 47@ validate_position 0 

:FIRETRU_4922
if 
  " + _8213 + @" > 11 
else_jump @FIRETRU_4963 
if 
   not Actor.Dead(48@)
else_jump @FIRETRU_4963 
0588: disable_actor 48@ validate_position 0 

:FIRETRU_4963
0085: 34@ = 35@ 
0085: 49@ = 50@ 
0085: 90@ = 92@ 
0085: 63@ = 64@ 
" + _8221 + @" = 1 
gosub @FIRETRU_8684 
0085: 50@ = 49@ 
0085: 92@ = 90@ 
0085: 64@ = 63@ 
if 
  " + _8213 + @" > 1 
else_jump @FIRETRU_5114 
0085: 39@ = 40@ 
0085: 91@ = 95@ 
0085: 53@ = 54@ 
0085: 67@ = 68@ 
gosub @FIRETRU_9212 
0085: 95@ = 91@ 
0085: 54@ = 53@ 
0085: 68@ = 67@ 

:FIRETRU_5114
if 
  " + _8213 + @" > 2 
else_jump @FIRETRU_5195 
0085: 39@ = 41@ 
0085: 91@ = 96@ 
0085: 53@ = 55@ 
0085: 67@ = 69@ 
gosub @FIRETRU_9212 
0085: 96@ = 91@ 
0085: 55@ = 53@ 
0085: 69@ = 67@ 

:FIRETRU_5195
if 
  " + _8213 + @" > 3 
else_jump @FIRETRU_5276 
0085: 39@ = 42@ 
0085: 91@ = 97@ 
0085: 53@ = 56@ 
0085: 67@ = 70@ 
gosub @FIRETRU_9212 
0085: 97@ = 91@ 
0085: 56@ = 53@ 
0085: 70@ = 67@ 

:FIRETRU_5276
if 
  " + _8213 + @" > 4 
else_jump @FIRETRU_5364 
0085: 34@ = 36@ 
0085: 49@ = 51@ 
0085: 90@ = 93@ 
0085: 63@ = 65@ 
" + _8221 + @" = 2 
gosub @FIRETRU_8684 
0085: 51@ = 49@ 
0085: 93@ = 90@ 
0085: 65@ = 63@ 

:FIRETRU_5364
if 
  " + _8213 + @" > 5 
else_jump @FIRETRU_5445 
0085: 39@ = 43@ 
0085: 91@ = 98@ 
0085: 53@ = 57@ 
0085: 67@ = 71@ 
gosub @FIRETRU_9212 
0085: 98@ = 91@ 
0085: 57@ = 53@ 
0085: 71@ = 67@ 

:FIRETRU_5445
if 
  " + _8213 + @" > 6 
else_jump @FIRETRU_5526 
0085: 39@ = 44@ 
0085: 91@ = 99@ 
0085: 53@ = 58@ 
0085: 67@ = 72@ 
gosub @FIRETRU_9212 
0085: 99@ = 91@ 
0085: 58@ = 53@ 
0085: 72@ = 67@ 

:FIRETRU_5526
if 
  " + _8213 + @" > 7 
else_jump @FIRETRU_5607 
0085: 39@ = 45@ 
0085: 91@ = 100@ 
0085: 53@ = 59@ 
0085: 67@ = 73@ 
gosub @FIRETRU_9212 
0085: 100@ = 91@ 
0085: 59@ = 53@ 
0085: 73@ = 67@ 

:FIRETRU_5607
if 
  " + _8213 + @" > 8 
else_jump @FIRETRU_5695 
0085: 34@ = 37@ 
0085: 49@ = 52@ 
0085: 90@ = 94@ 
0085: 63@ = 66@ 
" + _8221 + @" = 3 
gosub @FIRETRU_8684 
0085: 52@ = 49@ 
0085: 94@ = 90@ 
0085: 66@ = 63@ 

:FIRETRU_5695
if 
  " + _8213 + @" > 9 
else_jump @FIRETRU_5776 
0085: 39@ = 46@ 
0085: 91@ = 101@ 
0085: 53@ = 60@ 
0085: 67@ = 74@ 
gosub @FIRETRU_9212 
0085: 101@ = 91@ 
0085: 60@ = 53@ 
0085: 74@ = 67@ 

:FIRETRU_5776
if 
  " + _8213 + @" > 10 
else_jump @FIRETRU_5857 
0085: 39@ = 47@ 
0085: 91@ = 102@ 
0085: 53@ = 61@ 
0085: 67@ = 75@ 
gosub @FIRETRU_9212 
0085: 102@ = 91@ 
0085: 61@ = 53@ 
0085: 75@ = 67@ 

:FIRETRU_5857
if 
  " + _8213 + @" > 11 
else_jump @FIRETRU_5938 
0085: 39@ = 48@ 
0085: 91@ = 103@ 
0085: 53@ = 62@ 
0085: 67@ = 76@ 
gosub @FIRETRU_9212 
0085: 103@ = 91@ 
0085: 62@ = 53@ 
0085: 76@ = 67@ 

:FIRETRU_5938
if 
002D:   89@ >= 88@ 
else_jump @FIRETRU_5964 
jump @FIRETRU_9900 

:FIRETRU_5964
jump @FIRETRU_3144 

:FIRETRU_5971
wait 0 
120@ = 0 
32@ = 0 

:FIRETRU_5989
if 
  120@ == 0 
else_jump @FIRETRU_8079 
120@ = 1 
163@ = 1 
162@ += 1.0 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FIRETRU_6098 
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #FIRETRUK)
else_jump @FIRETRU_6091 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_CANC' time 3000 flag 1  
77@ = 1 

:FIRETRU_6091
jump @FIRETRU_6105 

:FIRETRU_6098
77@ = 1 

:FIRETRU_6105
0293: " + _13 + @" = get_controller_mode 
if 
   not " + _13 + @" == 3 
else_jump @FIRETRU_6159 
if 
00E1:   player 0 pressed_key 19 
else_jump @FIRETRU_6152 
82@ = 1 

:FIRETRU_6152
jump @FIRETRU_6183 

:FIRETRU_6159
if 
00E1:   player 0 pressed_key 14 
else_jump @FIRETRU_6183 
82@ = 1 

:FIRETRU_6183
if 
  82@ == 1 
else_jump @FIRETRU_6310 
if 
   not " + _13 + @" == 3 
else_jump @FIRETRU_6268 
if 
80E1:   not player 0 pressed_key 19 
else_jump @FIRETRU_6261 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_CANC' time 3000 flag 1  
77@ = 1 

:FIRETRU_6261
jump @FIRETRU_6310 

:FIRETRU_6268
if 
80E1:   not player 0 pressed_key 14 
else_jump @FIRETRU_6310 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_CANC' time 3000 flag 1  
77@ = 1 

:FIRETRU_6310
if 
  77@ == 1 
else_jump @FIRETRU_6335 
jump @FIRETRU_10460 

:FIRETRU_6335
Actor.StorePos(" + PlayerActor + @", 143@, 144@, 145@)
008F: 156@ = integer " + _8213 + @" to_float 
156@ *= 60.0 
005B: 156@ += 162@ 
if 
  170.0 > 156@ 
else_jump @FIRETRU_6406 
156@ = 170.0 

:FIRETRU_6406
0087: 149@ = 143@ 
005B: 149@ += 156@ 
0087: 151@ = 143@ 
0063: 151@ -= 156@ 
0087: 150@ = 144@ 
005B: 150@ += 156@ 
0087: 152@ = 144@ 
0063: 152@ -= 156@ 
0208: 153@ = random_float_in_ranges 151@ 149@ 
0208: 154@ = random_float_in_ranges 152@ 150@ 
04B9: unknown_get_at 153@ 154@ 145@ height 10.0 radius 500.0 store_to 153@ 154@ 155@ 157@ 158@ 159@ 160@ 
if 
  153@ == 0.0 
else_jump @FIRETRU_6625 
if 
  154@ == 0.0 
else_jump @FIRETRU_6625 
if 
  157@ == 0.0 
else_jump @FIRETRU_6625 
if 
  158@ == 0.0 
else_jump @FIRETRU_6625 
120@ = 0 

:FIRETRU_6625
if 
  120@ == 1 
else_jump @FIRETRU_6794 
050A: 124@ = distance_between_XYZ 143@ 144@ 145@ and_XYZ 153@ 154@ 155@ 
if 
  140.0 > 124@ 
else_jump @FIRETRU_6694 
120@ = 0 

:FIRETRU_6694
if 
  119@ == 1 
else_jump @FIRETRU_6780 
if 
  35.0 > 162@ 
else_jump @FIRETRU_6773 
0843: get_zone_at 153@ 154@ 155@ nameA_to " + _8218 + @" 
if 
85AD:   not  " + _8218 + @" == " + _8216 + @" 
else_jump @FIRETRU_6773 
120@ = 0 

:FIRETRU_6773
jump @FIRETRU_6794 

:FIRETRU_6780
0843: get_zone_at 153@ 154@ 155@ nameA_to " + _8216 + @" 

:FIRETRU_6794
if 
  120@ == 1 
else_jump @FIRETRU_7396 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  2 > " + STAT_Unlocked_Cities_Number + @" 
else_jump @FIRETRU_7396 
if 
  " + STAT_Unlocked_Cities_Number + @" == 0 
else_jump @FIRETRU_7154 
if and
  78.4427 > 153@ 
  -699.519 > 154@ 
else_jump @FIRETRU_6894 
120@ = 0 

:FIRETRU_6894
if 
  120@ == 1 
else_jump @FIRETRU_7154 
if and
  -252.6557 > 153@ 
  -285.766 > 154@ 
else_jump @FIRETRU_6950 
120@ = 0 

:FIRETRU_6950
if 
  120@ == 1 
else_jump @FIRETRU_7154 
if 
  -948.3447 > 153@ 
else_jump @FIRETRU_6996 
120@ = 0 

:FIRETRU_6996
if 
  120@ == 1 
else_jump @FIRETRU_7154 
if and
  153@ > 1473.448 
  154@ > 403.7353 
else_jump @FIRETRU_7052 
120@ = 0 

:FIRETRU_7052
if 
  120@ == 1 
else_jump @FIRETRU_7154 
if 
  154@ > 578.6325 
else_jump @FIRETRU_7098 
120@ = 0 

:FIRETRU_7098
if 
  120@ == 1 
else_jump @FIRETRU_7154 
if and
  837.5551 > 153@ 
  154@ > 347.4097 
else_jump @FIRETRU_7154 
120@ = 0 

:FIRETRU_7154
if 
  120@ == 1 
else_jump @FIRETRU_7396 
if 
  " + STAT_Unlocked_Cities_Number + @" == 1 
else_jump @FIRETRU_7396 
if and
  153@ > 1473.448 
  154@ > 403.7353 
else_jump @FIRETRU_7228 
120@ = 0 

:FIRETRU_7228
if 
  120@ == 1 
else_jump @FIRETRU_7396 
if and
  154@ > 578.6325 
  153@ > -1528.498 
else_jump @FIRETRU_7284 
120@ = 0 

:FIRETRU_7284
if 
  120@ == 1 
else_jump @FIRETRU_7396 
if and
  837.5551 > 153@ 
  153@ > -1528.498 
  154@ > 347.4097 
else_jump @FIRETRU_7350 
120@ = 0 

:FIRETRU_7350
if 
  120@ == 1 
else_jump @FIRETRU_7396 
if 
  154@ > 1380.0 
else_jump @FIRETRU_7396 
120@ = 0 

:FIRETRU_7396
if 
  120@ == 1 
else_jump @FIRETRU_7596 
if 
  2150.0 > 153@ 
else_jump @FIRETRU_7505 
if 
  153@ > 1970.0 
else_jump @FIRETRU_7505 
if 
  -2274.0 > 154@ 
else_jump @FIRETRU_7505 
if 
  154@ > -2670.0 
else_jump @FIRETRU_7505 
120@ = 0 

:FIRETRU_7505
if 
  2150.0 > 153@ 
else_jump @FIRETRU_7596 
if 
  153@ > 1590.0 
else_jump @FIRETRU_7596 
if 
  -2397.0 > 154@ 
else_jump @FIRETRU_7596 
if 
  154@ > -2670.0 
else_jump @FIRETRU_7596 
120@ = 0 

:FIRETRU_7596
if 
  120@ == 1 
else_jump @FIRETRU_7796 
if 
  -1070.0 > 153@ 
else_jump @FIRETRU_7705 
if 
  153@ > -1737.0 
else_jump @FIRETRU_7705 
if 
  -185.0 > 154@ 
else_jump @FIRETRU_7705 
if 
  154@ > -590.0 
else_jump @FIRETRU_7705 
120@ = 0 

:FIRETRU_7705
if 
  -1081.0 > 153@ 
else_jump @FIRETRU_7796 
if 
  153@ > -1600.0 
else_jump @FIRETRU_7796 
if 
  415.0 > 154@ 
else_jump @FIRETRU_7796 
if 
  154@ > -185.0 
else_jump @FIRETRU_7796 
120@ = 0 

:FIRETRU_7796
if 
  120@ == 1 
else_jump @FIRETRU_7905 
if 
  1733.0 > 153@ 
else_jump @FIRETRU_7905 
if 
  153@ > 1500.0 
else_jump @FIRETRU_7905 
if 
  1702.0 > 154@ 
else_jump @FIRETRU_7905 
if 
  154@ > 1529.0 
else_jump @FIRETRU_7905 
120@ = 0 

:FIRETRU_7905
if 
  120@ == 1 
else_jump @FIRETRU_8068 
if 
  " + _8213 + @" > 4 
else_jump @FIRETRU_8068 
050A: 161@ = distance_between_XYZ 127@ 128@ 129@ and_XYZ 153@ 154@ 155@ 
if 
  20.0 > 161@ 
else_jump @FIRETRU_7999 
120@ = 0 
jump @FIRETRU_8068 

:FIRETRU_7999
if 
  " + _8213 + @" > 8 
else_jump @FIRETRU_8068 
050A: 161@ = distance_between_XYZ 130@ 131@ 132@ and_XYZ 153@ 154@ 155@ 
if 
  20.0 > 161@ 
else_jump @FIRETRU_8068 
120@ = 0 

:FIRETRU_8068
wait 0 
jump @FIRETRU_5989 

:FIRETRU_8079
if 
  " + _8213 + @" > 4 
else_jump @FIRETRU_8211 
050A: 161@ = distance_between_XYZ 127@ 128@ 129@ and_XYZ 153@ 154@ 155@ 
if 
  " + _8213 + @" > 8 
else_jump @FIRETRU_8186 
050A: 161@ = distance_between_XYZ 130@ 131@ 132@ and_XYZ 153@ 154@ 155@ 
161@ /= 4.0 
005B: 124@ += 161@ 
jump @FIRETRU_8204 

:FIRETRU_8186
005B: 124@ += 161@ 
161@ /= 8.0 

:FIRETRU_8204
jump @FIRETRU_8211 

:FIRETRU_8211
if 
  9 > " + _8213 + @" 
else_jump @FIRETRU_8254 
0087: 122@ = 124@ 
122@ /= 8.0 
jump @FIRETRU_8272 

:FIRETRU_8254
0087: 122@ = 124@ 
122@ /= 10.0 

:FIRETRU_8272
122@ *= 1000.0 
0092: 78@ = float 122@ to_integer 
005E: " + _8215 + @" += 78@ 
if 
  60000 > " + _8215 + @" 
else_jump @FIRETRU_8329 
" + _8215 + @" = 60000 

:FIRETRU_8329
163@ = 0 
162@ = 0.0 
return 

:FIRETRU_8348
if 
  80@ == 1 
else_jump @FIRETRU_8411 
if 
  1 > " + _8215 + @" 
else_jump @FIRETRU_8411 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_FAIL2' time 5000 flag 1  
77@ = 1 
return 

:FIRETRU_8411
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @FIRETRU_8473 
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #FIRETRUK)
else_jump @FIRETRU_8473 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_CANC' time 3000 flag 1  
77@ = 1 
return 

:FIRETRU_8473
0293: " + _13 + @" = get_controller_mode 
if 
   not " + _13 + @" == 3 
else_jump @FIRETRU_8527 
if 
00E1:   player 0 pressed_key 19 
else_jump @FIRETRU_8520 
82@ = 1 

:FIRETRU_8520
jump @FIRETRU_8551 

:FIRETRU_8527
if 
00E1:   player 0 pressed_key 14 
else_jump @FIRETRU_8551 
82@ = 1 

:FIRETRU_8551
if 
  82@ == 1 
else_jump @FIRETRU_8682 
if 
   not " + _13 + @" == 3 
else_jump @FIRETRU_8638 
if 
80E1:   not player 0 pressed_key 19 
else_jump @FIRETRU_8631 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_CANC' time 3000 flag 1  
77@ = 1 
return 

:FIRETRU_8631
jump @FIRETRU_8682 

:FIRETRU_8638
if 
80E1:   not player 0 pressed_key 14 
else_jump @FIRETRU_8682 
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_CANC' time 3000 flag 1  
77@ = 1 
return 

:FIRETRU_8682
return 

:FIRETRU_8684
if 
   not 90@ == 10 
else_jump @FIRETRU_9210 
if 
   not Car.Wrecked(34@)
else_jump @FIRETRU_9034 
" + _8220 + @" = 1 
if 
0973:   fire 49@ exists 
else_jump @FIRETRU_8903 
if 
82D0:   not fire 49@ extinguished 
else_jump @FIRETRU_8772 
86@ = Car.Health(34@)
jump @FIRETRU_8896 

:FIRETRU_8772
if 
   not 90@ == 10 
else_jump @FIRETRU_8896 
Marker.Disable(63@)
068B: set_car 34@ all_disembark 
02D1: remove_fire 49@ 
0623: add 1 to_integer_stat 153 
if 
  81@ == 0 
else_jump @FIRETRU_8855 
04F7: status_text " + _8214 + @" type 0 line 2 GXT 'F_EXTIN' 
81@ = 1 

:FIRETRU_8855
097A: play_audio_at 0.0 0.0 0.0 event 1058 
90@ = 10 
" + _8214 + @" += 1 
89@ += 1 

:FIRETRU_8896
jump @FIRETRU_9027 

:FIRETRU_8903
if 
   not 90@ == 10 
else_jump @FIRETRU_9027 
Marker.Disable(63@)
068B: set_car 34@ all_disembark 
02D1: remove_fire 49@ 
0623: add 1 to_integer_stat 153 
if 
  81@ == 0 
else_jump @FIRETRU_8986 
04F7: status_text " + _8214 + @" type 0 line 2 GXT 'F_EXTIN' 
81@ = 1 

:FIRETRU_8986
097A: play_audio_at 0.0 0.0 0.0 event 1058 
90@ = 10 
" + _8214 + @" += 1 
89@ += 1 

:FIRETRU_9027
jump @FIRETRU_9203 

:FIRETRU_9034
if 
02BF:   car 34@ sunk 
else_jump @FIRETRU_9176 
if 
   not 90@ == 10 
else_jump @FIRETRU_9169 
Marker.Disable(63@)
068B: set_car 34@ all_disembark 
0623: add 1 to_integer_stat 153 
if 
  81@ == 0 
else_jump @FIRETRU_9128 
04F7: status_text " + _8214 + @" type 0 line 2 GXT 'F_EXTIN' 
81@ = 1 

:FIRETRU_9128
097A: play_audio_at 0.0 0.0 0.0 event 1058 
90@ = 10 
" + _8214 + @" += 1 
89@ += 1 

:FIRETRU_9169
jump @FIRETRU_9203 

:FIRETRU_9176
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_FAIL4' time 5000 flag 1  
77@ = 1 
return 

:FIRETRU_9203
jump @FIRETRU_9210 

:FIRETRU_9210
return 

:FIRETRU_9212
if 
  2 > 91@ 
else_jump @FIRETRU_9898 
if 
   not Actor.Dead(39@)
else_jump @FIRETRU_9695 
if 
  91@ == 0 
else_jump @FIRETRU_9427 
if 
   not Actor.Driving(39@)
else_jump @FIRETRU_9359 
0326: 53@ = create_actor 39@ fire 
Actor.StorePos(39@, 138@, 139@, 140@)
05DA: AS_actor 39@ run_away_in_panic_from 138@ 139@ 140@ away_radius 20.0 timelimit -1 
67@ = Marker.CreateAboveActor(39@)
07E0: set_marker 67@ type_to 1 
018B: set_marker 67@ radar_mode 2 
91@ = 1 
jump @FIRETRU_9427 

:FIRETRU_9359
if 
  90@ == 10 
else_jump @FIRETRU_9427 
if 
   Actor.Driving(39@)
else_jump @FIRETRU_9427 
062E: get_actor 39@ task 1587 status_store_to 164@ 
if 
04A4:   164@ == 7 
else_jump @FIRETRU_9427 
0633: AS_actor 39@ exit_car 

:FIRETRU_9427
if 
  91@ == 1 
else_jump @FIRETRU_9688 
" + _8220 + @" = 2 
if 
0973:   fire 53@ exists 
else_jump @FIRETRU_9592 
if 
02D0:   fire 53@ extinguished 
else_jump @FIRETRU_9585 
02D1: remove_fire 53@ 
Marker.Disable(67@)
0623: add 1 to_integer_stat 153 
if 
  81@ == 0 
else_jump @FIRETRU_9544 
04F7: status_text " + _8214 + @" type 0 line 2 GXT 'F_EXTIN' 
81@ = 1 

:FIRETRU_9544
097A: play_audio_at 0.0 0.0 0.0 event 1058 
" + _8214 + @" += 1 
89@ += 1 
91@ = 2 

:FIRETRU_9585
jump @FIRETRU_9688 

:FIRETRU_9592
Marker.Disable(67@)
0623: add 1 to_integer_stat 153 
if 
  81@ == 0 
else_jump @FIRETRU_9647 
04F7: status_text " + _8214 + @" type 0 line 2 GXT 'F_EXTIN' 
81@ = 1 

:FIRETRU_9647
097A: play_audio_at 0.0 0.0 0.0 event 1058 
" + _8214 + @" += 1 
89@ += 1 
91@ = 2 

:FIRETRU_9688
jump @FIRETRU_9898 

:FIRETRU_9695
if 
04AD:   actor 39@ in_water 
else_jump @FIRETRU_9871 
if 
  91@ == 1 
else_jump @FIRETRU_9837 
02D1: remove_fire 53@ 
Marker.Disable(67@)
0623: add 1 to_integer_stat 153 
if 
  81@ == 0 
else_jump @FIRETRU_9789 
04F7: status_text " + _8214 + @" type 0 line 2 GXT 'F_EXTIN' 
81@ = 1 

:FIRETRU_9789
097A: play_audio_at 0.0 0.0 0.0 event 1058 
" + _8214 + @" += 1 
89@ += 1 
91@ = 2 
jump @FIRETRU_9864 

:FIRETRU_9837
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_FAIL2' time 5000 flag 1  
77@ = 1 
return 

:FIRETRU_9864
jump @FIRETRU_9898 

:FIRETRU_9871
00BE: text_clear_all 
00BC: show_text_highpriority GXT 'F_FAIL3' time 5000 flag 1  
77@ = 1 
return 

:FIRETRU_9898
return 

:FIRETRU_9900
0396: pause_timer 1 
031A: remove_all_fires 
Marker.Disable(63@)
Marker.Disable(64@)
Marker.Disable(65@)
Marker.Disable(66@)
Marker.Disable(67@)
Marker.Disable(68@)
Marker.Disable(69@)
Marker.Disable(70@)
Marker.Disable(71@)
Marker.Disable(72@)
Marker.Disable(73@)
Marker.Disable(74@)
Marker.Disable(75@)
Marker.Disable(76@)
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @FIRETRU_10024 
38@ = Actor.CurrentCar(" + PlayerActor + @")
84@ = Car.Health(38@)
84@ += 150 
Car.Health(38@) = 84@

:FIRETRU_10024
Car.RemoveReferences(35@)
if 
   not Car.Wrecked(35@)
else_jump @FIRETRU_10052 
Car.ImmuneToNonPlayer(35@) = False

:FIRETRU_10052
Car.RemoveReferences(36@)
if 
   not Car.Wrecked(36@)
else_jump @FIRETRU_10080 
Car.ImmuneToNonPlayer(36@) = False

:FIRETRU_10080
Car.RemoveReferences(37@)
if 
   not Car.Wrecked(37@)
else_jump @FIRETRU_10108 
Car.ImmuneToNonPlayer(37@) = False

:FIRETRU_10108
Actor.RemoveReferences(40@)
Actor.RemoveReferences(41@)
Actor.RemoveReferences(42@)
Actor.RemoveReferences(43@)
Actor.RemoveReferences(44@)
Actor.RemoveReferences(45@)
Actor.RemoveReferences(46@)
Actor.RemoveReferences(47@)
Actor.RemoveReferences(48@)
Model.Destroy(126@)
0627: update_integer_stat 159 to " + _8213 + @" 
" + _8213 + @" += 1 
if 
  " + _8213 + @" == 13 
else_jump @FIRETRU_10379 
014F: stop_timer " + _8215 + @" 
0151: remove_status_text " + _8214 + @" 
0151: remove_status_text " + _8213 + @" 
03D5: remove_text 'F_START'  
03D5: remove_text 'F_STAR1'  
03D5: remove_text 'FIRELVL'  
00BA: show_text_styled GXT 'F_PASS1' time 5000 style 6  
008B: 79@ = " + _8213 + @" 
006E: 79@ *= " + _8213 + @" 
79@ *= 50 
005A: 83@ += 79@ 
79@ += 5000 
01E3: show_text_1number_styled GXT 'F_COMP1' number 13450 time 5000 style 5  
Player.Money(" + PlayerChar + @") += 79@
0394: play_music 2 
if 
  " + _1489 + @" == 0 
else_jump @FIRETRU_10363 
08F8: display_stat_update_box 0 
055D: make_player " + PlayerChar + @" fireproof 1 
0595: mission_complete 
" + _1489 + @" = 1 

:FIRETRU_10363
77@ = 1 
return 
jump @FIRETRU_10453 

:FIRETRU_10379
00BA: show_text_styled GXT 'F_PASS1' time 5000 style 6  
008B: 79@ = " + _8213 + @" 
006E: 79@ *= " + _8213 + @" 
79@ *= 50 
005A: 83@ += 79@ 
01E3: show_text_1number_styled GXT 'REWARD' number 79@ time 6000 style 7  
Player.Money(" + PlayerChar + @") += 79@

:FIRETRU_10453
jump @FIRETRU_789 

:FIRETRU_10460
014F: stop_timer " + _8215 + @" 
0151: remove_status_text " + _8214 + @" 
0151: remove_status_text " + _8213 + @" 
03D5: remove_text 'F_START'  
03D5: remove_text 'F_STAR1'  
03D5: remove_text 'FIRELVL'  
if 
   not " + _8213 + @" == 13 
else_jump @FIRETRU_10568 
00BA: show_text_styled GXT 'F_FAIL1' time 5000 style 5  
01E3: show_text_1number_styled GXT 'TSCORE' number 83@ time 6000 style 6  
jump @FIRETRU_10568 

:FIRETRU_10568
03C7: set_sensitivity_to_crime 1.0 
Marker.Disable(63@)
Marker.Disable(64@)
Marker.Disable(65@)
Marker.Disable(66@)
Marker.Disable(67@)
Marker.Disable(68@)
Marker.Disable(69@)
Marker.Disable(70@)
Marker.Disable(71@)
Marker.Disable(72@)
Marker.Disable(73@)
Marker.Disable(74@)
Marker.Disable(75@)
Marker.Disable(76@)
if 
   not " + _8213 + @" == 13 
else_jump @FIRETRU_11245 
if 
   not Actor.Dead(40@)
else_jump @FIRETRU_10708 
02A9: set_actor 40@ immune_to_nonplayer 0 
Actor.Health(40@) = 10
Actor.SetImmunities(40@, 0, 0, 0, 0, 0)

:FIRETRU_10708
if 
   not Actor.Dead(41@)
else_jump @FIRETRU_10753 
02A9: set_actor 41@ immune_to_nonplayer 0 
Actor.Health(41@) = 10
Actor.SetImmunities(41@, 0, 0, 0, 0, 0)

:FIRETRU_10753
if 
   not Actor.Dead(42@)
else_jump @FIRETRU_10798 
02A9: set_actor 42@ immune_to_nonplayer 0 
Actor.Health(42@) = 10
Actor.SetImmunities(42@, 0, 0, 0, 0, 0)

:FIRETRU_10798
if 
   not Actor.Dead(43@)
else_jump @FIRETRU_10843 
02A9: set_actor 43@ immune_to_nonplayer 0 
Actor.Health(43@) = 10
Actor.SetImmunities(43@, 0, 0, 0, 0, 0)

:FIRETRU_10843
if 
   not Actor.Dead(44@)
else_jump @FIRETRU_10888 
02A9: set_actor 44@ immune_to_nonplayer 0 
Actor.Health(44@) = 10
Actor.SetImmunities(44@, 0, 0, 0, 0, 0)

:FIRETRU_10888
if 
   not Actor.Dead(45@)
else_jump @FIRETRU_10933 
02A9: set_actor 45@ immune_to_nonplayer 0 
Actor.Health(45@) = 10
Actor.SetImmunities(45@, 0, 0, 0, 0, 0)

:FIRETRU_10933
if 
   not Actor.Dead(46@)
else_jump @FIRETRU_10978 
02A9: set_actor 46@ immune_to_nonplayer 0 
Actor.Health(46@) = 10
Actor.SetImmunities(46@, 0, 0, 0, 0, 0)

:FIRETRU_10978
if 
   not Actor.Dead(47@)
else_jump @FIRETRU_11023 
02A9: set_actor 47@ immune_to_nonplayer 0 
Actor.Health(47@) = 10
Actor.SetImmunities(47@, 0, 0, 0, 0, 0)

:FIRETRU_11023
if 
   not Actor.Dead(48@)
else_jump @FIRETRU_11068 
02A9: set_actor 48@ immune_to_nonplayer 0 
Actor.Health(48@) = 10
Actor.SetImmunities(48@, 0, 0, 0, 0, 0)

:FIRETRU_11068
if 
   not Car.Wrecked(35@)
else_jump @FIRETRU_11127 
Car.ImmuneToNonPlayer(35@) = False
Car.SetImmunities(35@, 0, 0, 0, 0, 0)
if 
0495:   car 35@ burning 
else_jump @FIRETRU_11127 
020B: explode_car 35@ 

:FIRETRU_11127
if 
   not Car.Wrecked(36@)
else_jump @FIRETRU_11186 
Car.ImmuneToNonPlayer(36@) = False
Car.SetImmunities(36@, 0, 0, 0, 0, 0)
if 
0495:   car 36@ burning 
else_jump @FIRETRU_11186 
020B: explode_car 36@ 

:FIRETRU_11186
if 
   not Car.Wrecked(37@)
else_jump @FIRETRU_11245 
Car.ImmuneToNonPlayer(37@) = False
Car.SetImmunities(37@, 0, 0, 0, 0, 0)
if 
0495:   car 37@ burning 
else_jump @FIRETRU_11245 
020B: explode_car 37@ 

:FIRETRU_11245
Actor.RemoveReferences(40@)
Actor.RemoveReferences(41@)
Actor.RemoveReferences(42@)
Actor.RemoveReferences(43@)
Actor.RemoveReferences(44@)
Actor.RemoveReferences(45@)
Actor.RemoveReferences(46@)
Actor.RemoveReferences(47@)
Actor.RemoveReferences(48@)
Car.RemoveReferences(35@)
Car.RemoveReferences(36@)
Car.RemoveReferences(37@)
Model.Destroy(126@)
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
" + OnMission + @" = 0 
" + ONMISSION_Firefighter + @" = 0 
0986: remove_references_to_all_fires 
065C: release_decision_maker 165@ 
mission_cleanup 
if 
  " + _1489 + @" == 1 
else_jump @FIRETRU_11388 
03E6: remove_text_box 
03E5: show_text_box 'FIREPRO'  
" + _1489 + @" = 2 
08F8: display_stat_update_box 0" );
create_thread<BACKON>();
AppendLine( @"
:FIRETRU_11388
return" );
            }

        }

    }

}