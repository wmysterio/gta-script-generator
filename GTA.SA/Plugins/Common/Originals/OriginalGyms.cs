using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalGyms : Original {

        internal OriginalGyms() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {

            Float[] gymMarkerX = new Float[] { 2228.0, -2269.4, 1968.6, 657.5627, 1299.34 };
            Float[] gymMarkerY = new Float[] { -1722.811, -155.6, 2292.1, -1866.3723, -803.568 };
            Float[] gymMarkerZ = new Float[] { 12.5543, 35.3, 35.3, 5.4609, 84.1406 };
            Array<RadarMarker> gymMarker = Script.global_array( ( ushort ) gymMarkerX.Length );
            for( ushort i = 0; i < gymMarkerX.Length; i++ )
                gymMarker[ i ].create_short_range( RadarIconID.GYM, gymMarkerX[ i ], gymMarkerY[ i ], gymMarkerZ[ i ] ).set_radar_mode( 2 );

            Current_Month_Day.value = -1;
            Current_Month.value = -1;
            GYM_Month_Day_When_Limit_Reached.value = -1;
            GYM_Month_When_Limit_Reached.value = -1;
            _1348.value = 1;

            Script.init_external_script_trigger_with_object_model<GYMBIKE>( 2630, 100, 20.0, -1 );
            Script.init_external_script_trigger_with_object_model<GYMBENC>( 2629, 100, 20.0, -1 );
            Script.init_external_script_trigger_with_object_model<GYMTREA>( 2627, 100, 20.0, -1 );
            Script.init_external_script_trigger_with_object_model<GYMDUMB>( 2631, 100, 20.0, -1 );
            Script.create_thread<GYM>();
        }

        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class GYMBIKE : External {

            public override void START( LabelJump label ) {
                AppendLine( @"
5@ = 0.0 
6@ = 0.0 
7@ = 0.0 
8@ = 0.0 
9@ = 0.0 
10@ = 0.0 
11@ = 0.0 
12@ = 0.0 
13@ = 0.0 
14@ = 0.0 
15@ = 0.0 
16@ = 0.0 
17@ = 0.0 
19@ = 0.0 
20@ = 0 
21@ = 0 
22@ = 0 
23@ = 0 
24@ = 0 
25@ = 0 
26@ = 0 
27@ = 0 
28@ = 0 
29@ = 0 
30@ = 0 
" + _8713 + @" = 0 
" + _8715 + @" = 0.0 
" + _8716 + @" = 0.0 
" + _8720 + @" = 0.0 
" + _8721 + @" = 0.0 
" + _8722 + @" = 0 
" + _8723 + @" = 0.0 
" + _8725 + @" = 0 
" + _8727 + @" = 0 
" + _8731 + @" = 0 
" + _8732 + @" = 0 
" + GYM_GymBike_Power + @" = 0 
" + GYM_GymBike_Level + @" = 0 
" + GYM_GymBike_Distance + @" = 0 
TIMERA = 0 
TIMERB = 0 
if 
  30@ == 1 
jf @GYMBIKE_486 
0@ = Object.Init(#CM_BOX, 0.0, 0.0, 0.0)

:GYMBIKE_486
if 
03CA:   object 0@ exists 
jf @GYMBIKE_538 
Object.StorePos(0@, 5@, 6@, 7@)
Object.StorePos(0@, 11@, 12@, 13@)
4@ = Object.Angle(0@)

:GYMBIKE_538
0088: " + _8730 + @" = 7@ // (float) 
" + _8730 + @" += 0.15 
0087: 3@ = 4@ // (float) 
3@ -= 90.0 
02F6: 1@ = sine 3@ // (float) 
02F7: 2@ = cosine 3@ // (float) 
1@ *= 0.05 
2@ *= 0.05 
0088: " + _8728 + @" = 5@ // (float) 
005F: " + _8728 + @" += 2@ // (float) 
0088: " + _8729 + @" = 6@ // (float) 
005F: " + _8729 + @" += 1@ // (float) 
" + _8724 + @" = Object.Create(#PEDALS, " + _8728 + @", " + _8729 + @", " + _8730 + @")
Object.Angle(" + _8724 + @") = 4@
0087: 10@ = 7@ // (float) 
10@ += 0.9 
0087: 3@ = 4@ // (float) 
3@ -= 45.0 
02F6: 1@ = sine 3@ // (float) 
02F7: 2@ = cosine 3@ // (float) 
1@ *= 2.8 
2@ *= 2.8 
0087: 8@ = 5@ // (float) 
005B: 8@ += 2@ // (float) 
0087: 9@ = 6@ // (float) 
005B: 9@ += 1@ // (float) 
4@ -= 180.0 
3@ += 45.0 
02F6: 1@ = sine 3@ // (float) 
02F7: 2@ = cosine 3@ // (float) 
1@ *= 0.5 
2@ *= 0.5 
005B: 5@ += 2@ // (float) 
005B: 6@ += 1@ // (float) 
0087: 3@ = 4@ // (float) 
3@ -= 90.0 
02F6: 1@ = sine 3@ // (float) 
02F7: 2@ = cosine 3@ // (float) 
1@ *= 0.5 
2@ *= 0.5 
0088: " + _8715 + @" = 5@ // (float) 
005F: " + _8715 + @" += 2@ // (float) 
0088: " + _8716 + @" = 6@ // (float) 
005F: " + _8716 + @" += 1@ // (float) 
7@ += 0.05 
" + GYM_GymBike_Power + @" = 0 
" + GYM_GymBike_Distance + @" = 0 
" + _1829 + @" = 0 

:GYMBIKE_960
wait 0 
if 
83CA:   not object 0@ exists 
jf @GYMBIKE_987 
Object.Destroy(" + _8724 + @")
end_thread 

:GYMBIKE_987
if 
8977:   not player_in_radius_of_object 0@ external_script_trigger 
jf @GYMBIKE_1010 
Object.Destroy(" + _8724 + @")
end_thread 

:GYMBIKE_1010
if 
   Player.Defined(" + PlayerChar + @")
jf @GYMBIKE_6332 
if 
  20@ == 0 
jf @GYMBIKE_1371 
if and
  28@ == 0 
8A0C:   not player " + PlayerChar + @" on_jetpack 
jf @GYMBIKE_1330 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 5@ 6@ 7@ radius 1.2 1.2 4.0 on_foot 
jf @GYMBIKE_1296 
if 
  29@ == 0 
jf @GYMBIKE_1145 
0512: show_permanent_text_box 'GYM1_81'  // ~k~~VEHICLE_ENTER_EXIT~ - њcЈoћ©џoўa¦©.
29@ = 1 

:GYMBIKE_1145
if 
00E1:   player 0 pressed_key 15 
jf @GYMBIKE_1289 
if or
  " + OnMission + @" == 0 
  " + ONMISSION_GYMFIGHT + @" == 1 
jf @GYMBIKE_1273 
0835: get_month_day_to " + Current_Month_Day + @" get_month_to " + Current_Month + @" 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" // (int) 
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit + @"_Reached // (int) 
jf @GYMBIKE_1250 
20@ = 1 
" + _1830 + @" = 1 
" + _8714 + @" = 0 
jump @GYMBIKE_1266 

:GYMBIKE_1250
00BC: show_text_highpriority GXT 'GYM1_1A' time 4000 flag 1  // ЏЁ љoc¦a¦o¤®o Јopa—o¦aћ ®aљ co—oќ ce™oљ®¬, Јpњxoљњ џaў¦pa!

:GYMBIKE_1266
jump @GYMBIKE_1289 

:GYMBIKE_1273
00BC: show_text_highpriority GXT 'GYM1_90' time 4000 flag 1  // ~s~Џe—e ceќ¤ac ®e љo Є¦o™o, Јo¤eЇy —Ё ¦e—e ®e Јpњќ¦њ Јoџ›e?

:GYMBIKE_1289
jump @GYMBIKE_1323 

:GYMBIKE_1296
if 
  29@ == 1 
jf @GYMBIKE_1323 
03E6: remove_text_box 
29@ = 0 

:GYMBIKE_1323
jump @GYMBIKE_1371 

:GYMBIKE_1330
if 
80ED:   not actor " + PlayerActor + @" sphere 0 near_point 5@ 6@ radius 2.0 2.0 on_foot 
jf @GYMBIKE_1371 
28@ = 0 

:GYMBIKE_1371
if 
  20@ == 1 
jf @GYMBIKE_6332 
if and
  " + _1830 + @" == 1 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_1501 
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Player.CanMove(" + PlayerChar + @") = False
08C7: put_actor " + PlayerActor + @" at " + _8715 + @" " + _8716 + @" 7@ dont_warp_gang 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Camera.SetPosition(8@, 9@, 10@, 0.0, 0.0, 0.0)
Actor.Angle(" + PlayerActor + @") = 4@
Camera.PointAt(11@, 12@, 10@, 2)
" + _1830 + @" = 2 

:GYMBIKE_1501
if 
  " + _1829 + @" == 0 
jf @GYMBIKE_1611 
04ED: load_animation ""GYMNASIUM"" 

:GYMBIKE_1532
if 
84EE:   not animation ""GYMNASIUM"" loaded 
jf @GYMBIKE_1567 
wait 0 
jump @GYMBIKE_1532 

:GYMBIKE_1567
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMBIKE_1578
if 
83D0:   not wav 4 loaded 
jf @GYMBIKE_1604 
wait 0 
jump @GYMBIKE_1578 

:GYMBIKE_1604
" + _1829 + @" = 1 

:GYMBIKE_1611
if and
  " + _1830 + @" == 2 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_2197 
0792: disembark_instantly_actor " + PlayerActor + @" 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_GETON"" IFP ""GYMNASIUM"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
0512: show_permanent_text_box 'GYM1_60'  // ~k~~GO_FORWARD~ њ ~k~~GO_BACK~ - ўЁ—pa¦© ypoўe®©.~N~~k~~PED_SPRINT~ - Јpoљoћ›њ¦©.~N~~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
if or
  " + Current_Language + @" == 4 
  " + Current_Language + @" == 2 
jf @GYMBIKE_1890 
08D4: " + _8712 + @" = create_panel_with_title 'GYM1_D' position 31.0 180.0 width 178.0 columns 1 interactive 1 background 1 alignment 0  // ‹eћo¦pe®a›ep
08DB: set_panel " + _8712 + @" column 0 header 'GYM1_89' data 'GYM1_61' 'GYM1_62' 'GYM1_63' 'GYM1_64' 'GYM1_65' 'GYM1_66' 'GYM1_67' 'GYM1_68' 'GYM1_69' 'GYM1_70' 'DUMMY' 'DUMMY'  // Ypoўe®© // 1 ypoўe®© // 2 ypoўe®© // 3 ypoўe®© // 4 ypoўe®© // 5 ypoўe®© // 6 ypoўe®© // 7 ypoўe®© // 8 ypoўe®© // 9 ypoўe®© // 10 ypoўe®©
jump @GYMBIKE_2051 

:GYMBIKE_1890
08D4: " + _8712 + @" = create_panel_with_title 'GYM1_D' position 31.0 150.0 width 178.0 columns 1 interactive 1 background 1 alignment 0  // ‹eћo¦pe®a›ep
08DB: set_panel " + _8712 + @" column 0 header 'GYM1_89' data 'GYM1_61' 'GYM1_62' 'GYM1_63' 'GYM1_64' 'GYM1_65' 'GYM1_66' 'GYM1_67' 'GYM1_68' 'GYM1_69' 'GYM1_70' 'DUMMY' 'DUMMY'  // Ypoўe®© // 1 ypoўe®© // 2 ypoўe®© // 3 ypoўe®© // 4 ypoўe®© // 5 ypoўe®© // 6 ypoўe®© // 7 ypoўe®© // 8 ypoўe®© // 9 ypoўe®© // 10 ypoўe®©

:GYMBIKE_2051
090E: set_panel " + _8712 + @" active_row 0 

:GYMBIKE_2058
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_2183 
wait 0 
" + _8714 + @" += 1 
if and
00E1:   player 0 pressed_key 15 
  " + _8714 + @" > 20 
jf @GYMBIKE_2130 
03E6: remove_text_box 
08DA: remove_panel " + _8712 + @" 
" + GYM_GymBike_Level + @" = 0 
jump @GYMBIKE_5327 

:GYMBIKE_2130
if 
00E1:   player 0 pressed_key 16 
jf @GYMBIKE_2176 
03E6: remove_text_box 
08D7: " + GYM_GymBike_Level + @" = panel " + _8712 + @" active_row 
" + GYM_GymBike_Level + @" += 1 
08DA: remove_panel " + _8712 + @" 
jump @GYMBIKE_2183 

:GYMBIKE_2176
jump @GYMBIKE_2058 

:GYMBIKE_2183
" + _1830 + @" = 3 
TIMERB = 0 

:GYMBIKE_2197
if and
  " + _1830 + @" == 3 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_2388 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BIKE_GETON""
jf @GYMBIKE_2388 
0613: 15@ = actor " + PlayerActor + @" animation ""GYM_BIKE_GETON"" time 
if 
  15@ == 1.0 
jf @GYMBIKE_2388 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_SLOW"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
075A: set_object " + _8724 + @" animation ""PEDALS_SLOW"" IFP_file ""GYMNASIUM"" 4.0 lockF 1 loop -1 // IF AND SET 
" + _1830 + @" = 4 

:GYMBIKE_2388
if and
  " + _1830 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_2583 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BIKE_SLOW""
jf @GYMBIKE_2583 
0613: 15@ = actor " + PlayerActor + @" animation ""GYM_BIKE_SLOW"" time 
if 
  15@ == 0.0 
jf @GYMBIKE_2583 
0612: set_actor " + PlayerActor + @" animation ""GYM_BIKE_SLOW"" paused 0 
04F7: status_text " + GYM_GymBike_Power + @" type 1 line 1 GXT 'GYM1_1' // global_variable  // Є®ep™њ¬
04F7: status_text " + GYM_GymBike_Level + @" type 0 line 2 GXT 'GYM1_4' // global_variable  // ypoўe®©
04F7: status_text " + GYM_GymBike_Distance + @" type 0 line 3 GXT 'GYM1_3' // global_variable  // Pacc¦o¬®њe
21@ = 1 
" + _1830 + @" = 5 
TIMERB = 0 

:GYMBIKE_2583
if and
  " + _1830 + @" == 5 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_6332 
if 
  " + _8713 + @" == 0 
jf @GYMBIKE_2642 
0512: show_permanent_text_box 'GYM1_40'  // ЂЁc¦po ®a›њЇaќ ~k~~PED_SPRINT~, ¤¦o—Ё kpy¦њ¦© Јeљaћњ.
" + _8713 + @" = 1 

:GYMBIKE_2642
if and
  TIMERB > 4000 
  " + _8713 + @" == 1 
jf @GYMBIKE_2688 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_41'  // ~k~~CONVERSATION_NO~ - Јo®њџњ¦© ypoўe®©,~n~~k~~CONVERSATION_YES~ - ЈoўЁcњ¦© ypoўe®©.
" + _8713 + @" = 2 

:GYMBIKE_2688
if and
  TIMERB > 8000 
  " + _8713 + @" == 2 
jf @GYMBIKE_2723 
03E6: remove_text_box 
" + _8713 + @" = 101 

:GYMBIKE_2723
0653: 19@ = float_stat 22 
19@ /= 100.0 
0087: 16@ = 17@ // (float) 
005B: 16@ += 19@ // (float) 
007F: 14@ -= frame_delta_time * 0.35 // (float) 
if 
00E1:   player 0 pressed_key 16 
jf @GYMBIKE_2816 
if 
  22@ == 0 
jf @GYMBIKE_2816 
005B: 14@ += 16@ // (float) 
22@ = 1 

:GYMBIKE_2816
if 
80E1:   not player 0 pressed_key 16 
jf @GYMBIKE_2858 
if 
  22@ == 1 
jf @GYMBIKE_2858 
22@ = 0 

:GYMBIKE_2858
if 
  0.0 > 14@ 
jf @GYMBIKE_2889 
14@ = 0.0 

:GYMBIKE_2889
if 
  14@ > 100.0 
jf @GYMBIKE_2920 
14@ = 100.0 

:GYMBIKE_2920
if 
  21@ == 1 
jf @GYMBIKE_3053 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BIKE_SLOW""
jf @GYMBIKE_3053 
0612: set_actor " + PlayerActor + @" animation ""GYM_BIKE_SLOW"" paused 1 
0393: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_SLOW"" at 0.5 times_normal_rate 
0836: set_object " + _8724 + @" animation ""PEDALS_SLOW"" at 0.5 times_normal_rate 
TIMERA = 0 
21@ = 2 

:GYMBIKE_3053
if and
  21@ == 2 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_6228 
0653: 19@ = float_stat 22 
19@ /= 200.0 
if 
  0.0 > 19@ 
jf @GYMBIKE_3124 
19@ = 0.0 

:GYMBIKE_3124
0090: " + _8725 + @" = float 19@ to_integer 
0084: " + _8726 + @" = " + GYM_GymBike_Level + @" // (int) 
0060: " + _8726 + @" -= " + _8725 + @" // (int) 
if 
  14@ == 0.0 
jf @GYMBIKE_3301 
if 
  23@ == 0 
jf @GYMBIKE_3301 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_STILL"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
075A: set_object " + _8724 + @" animation ""PEDALS_STILL"" IFP_file ""GYMNASIUM"" 4.0 lockF 1 loop -1 // IF AND SET 
24@ = 0 
25@ = 0 
26@ = 0 
23@ = 1 

:GYMBIKE_3301
if 
  24@ == 0 
jf @GYMBIKE_3459 
if and
  3 > " + _8726 + @" 
   not 14@ == 0.0 
jf @GYMBIKE_3459 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_SLOW"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
075A: set_object " + _8724 + @" animation ""PEDALS_SLOW"" IFP_file ""GYMNASIUM"" 4.0 lockF 1 loop -1 // IF AND SET 
24@ = 1 
25@ = 0 
26@ = 0 
23@ = 0 

:GYMBIKE_3459
if 
  25@ == 0 
jf @GYMBIKE_3623 
if and
  " + _8726 + @" > 2 
  7 > " + _8726 + @" 
   not 14@ == 0.0 
jf @GYMBIKE_3623 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_FAST"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
075A: set_object " + _8724 + @" animation ""PEDALS_MED"" IFP_file ""GYMNASIUM"" 4.0 lockF 1 loop -1 // IF AND SET 
24@ = 0 
26@ = 0 
25@ = 1 
23@ = 0 

:GYMBIKE_3623
if 
  26@ == 0 
jf @GYMBIKE_3790 
if and
  " + _8726 + @" > 6 
  11 > " + _8726 + @" 
   not 14@ == 0.0 
jf @GYMBIKE_3790 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_FASTER"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
075A: set_object " + _8724 + @" animation ""PEDALS_FAST"" IFP_file ""GYMNASIUM"" 4.0 lockF 1 loop -1 // IF AND SET 
24@ = 0 
25@ = 0 
26@ = 1 
23@ = 0 

:GYMBIKE_3790
if 
00E1:   player 0 pressed_key 11 
jf @GYMBIKE_3928 
if 
  27@ == 0 
jf @GYMBIKE_3928 
if and
  " + GYM_GymBike_Level + @" > 0 
  10 > " + GYM_GymBike_Level + @" 
jf @GYMBIKE_3928 
" + GYM_GymBike_Level + @" += 1 
if 
03D0:   wav 4 loaded 
jf @GYMBIKE_3880 
097B: play_audio_at_object 0@ event 1116 

:GYMBIKE_3880
14@ -= 20.0 
if 
  0.0 > 14@ 
jf @GYMBIKE_3921 
14@ = 0.0 

:GYMBIKE_3921
27@ = 1 

:GYMBIKE_3928
if 
00E1:   player 0 pressed_key 10 
jf @GYMBIKE_4025 
if 
  27@ == 0 
jf @GYMBIKE_4025 
if and
  " + GYM_GymBike_Level + @" > 1 
  11 > " + GYM_GymBike_Level + @" 
jf @GYMBIKE_4025 
" + GYM_GymBike_Level + @" -= 1 
if 
03D0:   wav 4 loaded 
jf @GYMBIKE_4018 
097B: play_audio_at_object 0@ event 1116 

:GYMBIKE_4018
27@ = 2 

:GYMBIKE_4025
if 
80E1:   not player 0 pressed_key 11 
jf @GYMBIKE_4067 
if 
  27@ == 1 
jf @GYMBIKE_4067 
27@ = 0 

:GYMBIKE_4067
if 
80E1:   not player 0 pressed_key 10 
jf @GYMBIKE_4109 
if 
  27@ == 2 
jf @GYMBIKE_4109 
27@ = 0 

:GYMBIKE_4109
if 
  " + GYM_GymBike_Level + @" == 1 
jf @GYMBIKE_4137 
17@ = 6.5 

:GYMBIKE_4137
if 
  " + GYM_GymBike_Level + @" == 2 
jf @GYMBIKE_4165 
17@ = 5.9 

:GYMBIKE_4165
if 
  " + GYM_GymBike_Level + @" == 3 
jf @GYMBIKE_4193 
17@ = 5.0 

:GYMBIKE_4193
if 
  " + GYM_GymBike_Level + @" == 4 
jf @GYMBIKE_4221 
17@ = 4.3 

:GYMBIKE_4221
if 
  " + GYM_GymBike_Level + @" == 5 
jf @GYMBIKE_4249 
17@ = 3.7 

:GYMBIKE_4249
if 
  " + GYM_GymBike_Level + @" == 6 
jf @GYMBIKE_4277 
17@ = 2.9 

:GYMBIKE_4277
if 
  " + GYM_GymBike_Level + @" == 7 
jf @GYMBIKE_4305 
17@ = 2.2 

:GYMBIKE_4305
if 
  " + GYM_GymBike_Level + @" == 8 
jf @GYMBIKE_4333 
17@ = 1.5 

:GYMBIKE_4333
if 
  " + GYM_GymBike_Level + @" == 9 
jf @GYMBIKE_4361 
17@ = 1.1 

:GYMBIKE_4361
if 
  " + GYM_GymBike_Level + @" == 10 
jf @GYMBIKE_4389 
17@ = 0.7 

:GYMBIKE_4389
if 
  14@ >= 0.0 
jf @GYMBIKE_4441 
if 
  10.0 >= 14@ 
jf @GYMBIKE_4441 
18@ = 0.9 

:GYMBIKE_4441
if 
  14@ >= 11.0 
jf @GYMBIKE_4493 
if 
  20.0 >= 14@ 
jf @GYMBIKE_4493 
18@ = 1.0 

:GYMBIKE_4493
if 
  14@ >= 21.0 
jf @GYMBIKE_4545 
if 
  30.0 >= 14@ 
jf @GYMBIKE_4545 
18@ = 1.1 

:GYMBIKE_4545
if 
  14@ >= 31.0 
jf @GYMBIKE_4597 
if 
  40.0 >= 14@ 
jf @GYMBIKE_4597 
18@ = 1.2 

:GYMBIKE_4597
if 
  14@ >= 41.0 
jf @GYMBIKE_4649 
if 
  50.0 >= 14@ 
jf @GYMBIKE_4649 
18@ = 1.3 

:GYMBIKE_4649
if 
  14@ >= 51.0 
jf @GYMBIKE_4701 
if 
  60.0 >= 14@ 
jf @GYMBIKE_4701 
18@ = 1.4 

:GYMBIKE_4701
if 
  14@ >= 61.0 
jf @GYMBIKE_4753 
if 
  70.0 >= 14@ 
jf @GYMBIKE_4753 
18@ = 1.5 

:GYMBIKE_4753
if 
  14@ >= 71.0 
jf @GYMBIKE_4805 
if 
  80.0 >= 14@ 
jf @GYMBIKE_4805 
18@ = 1.6 

:GYMBIKE_4805
if 
  14@ >= 81.0 
jf @GYMBIKE_4857 
if 
  90.0 >= 14@ 
jf @GYMBIKE_4857 
18@ = 1.7 

:GYMBIKE_4857
if 
  14@ >= 91.0 
jf @GYMBIKE_4909 
if 
  100.0 >= 14@ 
jf @GYMBIKE_4909 
18@ = 1.8 

:GYMBIKE_4909
if and
   Actor.Animation(" + PlayerActor + @") == ""GYM_BIKE_SLOW""
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_4968 
0393: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_SLOW"" at 18@ times_normal_rate 

:GYMBIKE_4968
if and
0837:   object " + _8724 + @" animation == ""PEDALS_SLOW"" 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5023 
0836: set_object " + _8724 + @" animation ""PEDALS_SLOW"" at 18@ times_normal_rate 

:GYMBIKE_5023
if and
   Actor.Animation(" + PlayerActor + @") == ""GYM_BIKE_FAST""
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5082 
0393: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_FAST"" at 18@ times_normal_rate 

:GYMBIKE_5082
if and
0837:   object " + _8724 + @" animation == ""PEDALS_MED"" 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5135 
0836: set_object " + _8724 + @" animation ""PEDALS_MED"" at 18@ times_normal_rate 

:GYMBIKE_5135
if and
   Actor.Animation(" + PlayerActor + @") == ""GYM_BIKE_FASTER""
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5198 
0393: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_FASTER"" at 18@ times_normal_rate 

:GYMBIKE_5198
if and
0837:   object " + _8724 + @" animation == ""PEDALS_FAST"" 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5253 
0836: set_object " + _8724 + @" animation ""PEDALS_FAST"" at 18@ times_normal_rate 

:GYMBIKE_5253
if or
00E1:   player 0 pressed_key 15 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMBIKE_5787 
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMBIKE_5311 
" + GYM_Day_Limit + @" = 0.0 

:GYMBIKE_5311
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5787 

:GYMBIKE_5327
015B: shake_player_controller 0 time 1 intensity 1 
0623: add " + GYM_GymBike_Distance + @" to_integer_stat 29 
0085: 31@ = TIMERB // (int) 
31@ /= 1000 
0623: add 31@ to_integer_stat 45 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5468 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BIKE_GETOFF"" IFP ""GYMNASIUM"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
075A: set_object " + _8724 + @" animation ""PEDALS_STILL"" IFP_file ""GYMNASIUM"" 4.0 lockF 0 loop -1 // IF AND SET 

:GYMBIKE_5468
21@ = 0 
22@ = 0 
23@ = 0 
24@ = 0 
25@ = 0 
26@ = 0 
27@ = 0 
20@ = 0 
" + _1830 + @" = 0 
" + GYM_GymBike_Level + @" = 0 
" + GYM_GymBike_Distance + @" = 0 
" + _8721 + @" = 0.0 
" + _8720 + @" = 0.0 
" + GYM_GymBike_Power + @" = 0 
14@ = 0.0 
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  0.0 >= " + GYM_STAT_Fat + @" 
jf @GYMBIKE_5619 
062A: change_float_stat 21 to 0.0 

:GYMBIKE_5619
if 
03CA:   object 0@ exists 
jf @GYMBIKE_5642 
Object.CollisionDetection(0@) = True

:GYMBIKE_5642
" + _1813 + @" = 0 
" + _1814 + @" = 0 
" + _1829 + @" = 0 
04EF: release_animation ""GYMNASIUM"" 
040D: unload_wav 4 
0151: remove_status_text " + GYM_GymBike_Power + @" 
0151: remove_status_text " + GYM_GymBike_Level + @" 
0151: remove_status_text " + GYM_GymBike_Distance + @" 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = False
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBIKE_5731 
Player.CanMove(" + PlayerChar + @") = True

:GYMBIKE_5731
28@ = 1 
08DA: remove_panel " + _8712 + @" 
03E6: remove_text_box 
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 

:GYMBIKE_5759
if 
00E1:   player 0 pressed_key 16 
jf @GYMBIKE_5787 
wait 0 
jump @GYMBIKE_5759 

:GYMBIKE_5787
if 
03CA:   object 0@ exists 
jf @GYMBIKE_5912 
if 
03D0:   wav 4 loaded 
jf @GYMBIKE_5912 
if 
  14@ > 10.0 
jf @GYMBIKE_5879 
if 
  " + _8732 + @" == 0 
jf @GYMBIKE_5872 
097B: play_audio_at_object 0@ event 1113 
" + _8732 + @" = 1 

:GYMBIKE_5872
jump @GYMBIKE_5912 

:GYMBIKE_5879
if 
  " + _8732 + @" == 1 
jf @GYMBIKE_5912 
097B: play_audio_at_object 0@ event 1114 
" + _8732 + @" = 0 

:GYMBIKE_5912
if 
  TIMERA > 250 
jf @GYMBIKE_6228 
TIMERA -= 250 
0088: " + _8720 + @" = 14@ // (float) 
" + _8720 + @" /= 10.0 
008D: " + _6 + @" = integer " + GYM_GymBike_Level + @" to_float 
" + _6 + @" /= 10.0 
" + _6 + @" += 1.0 
0069: " + _6 + @" *= " + _8720 + @" // (float) 
0059: " + _4 + @" += " + _6 + @" // (float) 
if 
  " + _4 + @" >= 400.0 
jf @GYMBIKE_6146 
" + _4 + @" -= 400.0 
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  " + GYM_STAT_Fat + @" >= 1.0 
jf @GYMBIKE_6069 
0626: decrease_float_stat 21 by 8.0 

:GYMBIKE_6069
if 
  " + _8733 + @" == 3 
jf @GYMBIKE_6120 
" + _8733 + @" = 0 
0624: add 4.0 to_float_stat 22 
" + GYM_Day_Limit + @" += 4.0 
jump @GYMBIKE_6146 

:GYMBIKE_6120
0A1F: increase_float_stat 22 by 4.0 
" + GYM_Day_Limit + @" += 4.0 
" + _8733 + @" += 1 

:GYMBIKE_6146
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMBIKE_6191 
0835: get_month_day_to " + GYM_Month_Day_When_Limit_Reached + @" get_month_to " + GYM_Month_When_Limit + @"_Reached 
00BC: show_text_highpriority GXT 'GYM1_1B' time 4000 flag 1  // ЏЁ ce™oљ®¬ љoc¦a¦o¤®o Јoџa®њЇaћc¬, Јpњxoљњ џaў¦pa!

:GYMBIKE_6191
if 
   not " + GYM_GymBike_Distance + @" >= 999999 
jf @GYMBIKE_6228 
0059: " + _8721 + @" += " + _8720 + @" // (float) 
008C: " + GYM_GymBike_Distance + @" = float " + _8721 + @" to_integer 

:GYMBIKE_6228
" + _8722 + @" += 1 
0084: " + _8731 + @" = " + GYM_GymBike_Power + @" // (int) 
" + _8731 + @" -= 100 
if 
  " + _8731 + @" > -40 
jf @GYMBIKE_6275 
" + _8731 + @" = -40 

:GYMBIKE_6275
if 
002C:   " + _8722 + @" >= " + _8731 + @" // (int) 
jf @GYMBIKE_6324 
" + _8722 + @" = 0 
" + GYM_GymBike_Power + @" *= 12 
" + GYM_GymBike_Power + @" /= 10 
015B: shake_player_controller 0 time 100 intensity " + GYM_GymBike_Power + @" 

:GYMBIKE_6324
0090: " + GYM_GymBike_Power + @" = float 14@ to_integer 

:GYMBIKE_6332
jump @GYMBIKE_960 
end_thread
" );

            }

        }

        private sealed class GYMBENC : External {

            public override void START( LabelJump label ) {
                AppendLine( @"" + _8737 + @" = 0.0 
" + _8747 + @" = 0.0 
" + _8743 + @" = 2 
" + _8744 + @" = 0 
" + _8741 + @" = 0 
" + _1824 + @" = 0.0 
" + _1825 + @" = 0.0 
" + _1826 + @" = 0.0 
" + _1827 + @" = 0.0 
" + _8738 + @" = 0 
" + _8735 + @" = 0 
23@ = 0 
24@ = 0 
25@ = 0 
26@ = 0 
27@ = 0 
21@ = 1 
22@ = 0 
29@ = 0 
TIMERA = 0 
TIMERB = 0 
if 
  29@ == 1 
jf @GYMBENC_217 
0@ = Object.Init(#BEACHTOWEL01, 0.0, 0.0, 0.0)

:GYMBENC_217
if 
03CA:   object 0@ exists 
jf @GYMBENC_277 
Object.StorePos(0@, 5@, 6@, 7@)
Object.StorePos(0@, 8@, 9@, 10@)
11@ = Object.Angle(0@)
3@ = Object.Angle(0@)

:GYMBENC_277
1@ = 0.0 
2@ = 0.0 
12@ = 0.0 
13@ = 0.0 
14@ = 0.0 
21@ = 1 
" + _8738 + @" = 0 
0087: 14@ = 7@ // (float) 
14@ += 1.7 
3@ -= 180.0 
0087: 4@ = 3@ // (float) 
4@ -= 270.0 
02F6: 1@ = sine 4@ // (float) 
02F7: 2@ = cosine 4@ // (float) 
1@ *= 1.0 
2@ *= 1.0 
005B: 5@ += 2@ // (float) 
005B: 6@ += 1@ // (float) 
1@ *= 3.0 
2@ *= 3.0 
0087: 12@ = 5@ // (float) 
005B: 12@ += 2@ // (float) 
0087: 13@ = 6@ // (float) 
005B: 13@ += 1@ // (float) 
11@ += 90.0 
02F6: 1@ = sine 11@ // (float) 
02F7: 2@ = cosine 11@ // (float) 
1@ *= 1.0 
2@ *= 1.0 
0063: 8@ -= 2@ // (float) 
0063: 9@ -= 1@ // (float) 
30@ = Object.Create(#KMB_BPRESS, 8@, 9@, 10@)
069A: attach_object 30@ to_object 0@ with_offset -0.45 0.45 0.9 rotation 90.0 180.0 270.0 
3@ -= 180.0 
" + GYM_GymBike_Level + @" = 1 
" + _1829 + @" = 0 

:GYMBENC_632
wait 0 
if 
83CA:   not object 0@ exists 
jf @GYMBENC_659 
Object.Destroy(30@)
end_thread 

:GYMBENC_659
if 
8977:   not player_in_radius_of_object 0@ external_script_trigger 
jf @GYMBENC_682 
Object.Destroy(30@)
end_thread 

:GYMBENC_682
if 
   Player.Defined(" + PlayerChar + @")
jf @GYMBENC_8093 
if and
  " + _1830 + @" == 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_1102 
if and
  23@ == 0 
8A0C:   not player " + PlayerChar + @" on_jetpack 
jf @GYMBENC_1102 
if 
  27@ == 0 
jf @GYMBENC_1061 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 5@ 6@ 7@ radius 1.2 1.2 4.0 on_foot 
jf @GYMBENC_1027 
if 
  22@ == 0 
jf @GYMBENC_840 
0512: show_permanent_text_box 'GYM1_81'  // ~k~~VEHICLE_ENTER_EXIT~ - њcЈoћ©џoўa¦©.
22@ = 1 

:GYMBENC_840
if 
00E1:   player 0 pressed_key 15 
jf @GYMBENC_1020 
if or
  " + OnMission + @" == 0 
  " + ONMISSION_GYMFIGHT + @" == 1 
jf @GYMBENC_1004 
0835: get_month_day_to " + Current_Month_Day + @" get_month_to " + Current_Month + @" 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" // (int) 
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit_Reached + @" // (int) 
jf @GYMBENC_981 
23@ = 1 
" + _1830 + @" = 1 
Player.CanMove(" + PlayerChar + @") = False
08C7: put_actor " + PlayerActor + @" at 5@ 6@ 7@ dont_warp_gang 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Actor.Angle(" + PlayerActor + @") = 3@
" + _8714 + @" = 0 
jump @GYMBENC_997 

:GYMBENC_981
00BC: show_text_highpriority GXT 'GYM1_1A' time 4000 flag 1  // ЏЁ љoc¦a¦o¤®o Јopa—o¦aћ ®aљ co—oќ ce™oљ®¬, Јpњxoљњ џaў¦pa!

:GYMBENC_997
jump @GYMBENC_1020 

:GYMBENC_1004
00BC: show_text_highpriority GXT 'GYM1_90' time 4000 flag 1  // ~s~Џe—e ceќ¤ac ®e љo Є¦o™o, Јo¤eЇy —Ё ¦e—e ®e Јpњќ¦њ Јoџ›e?

:GYMBENC_1020
jump @GYMBENC_1054 

:GYMBENC_1027
if 
  22@ == 1 
jf @GYMBENC_1054 
03E6: remove_text_box 
22@ = 0 

:GYMBENC_1054
jump @GYMBENC_1102 

:GYMBENC_1061
if 
80ED:   not actor " + PlayerActor + @" sphere 0 near_point 5@ 6@ radius 2.0 2.0 on_foot 
jf @GYMBENC_1102 
27@ = 0 

:GYMBENC_1102
if and
  23@ == 1 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_8093 
if 
  " + _1830 + @" == 1 
jf @GYMBENC_1221 
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Player.CanMove(" + PlayerChar + @") = False
08C7: put_actor " + PlayerActor + @" at 5@ 6@ 7@ dont_warp_gang 
Camera.SetPosition(12@, 13@, 14@, 0.0, 0.0, 0.0)
Actor.Angle(" + PlayerActor + @") = 3@
Camera.OnPed(" + PlayerActor + @", 15, 2)
" + _1830 + @" = 2 

:GYMBENC_1221
if 
  " + _1829 + @" == 0 
jf @GYMBENC_1311 
04ED: load_animation ""BENCHPRESS"" 
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMBENC_1264
if or
84EE:   not animation ""BENCHPRESS"" loaded 
83D0:   not wav 4 loaded 
jf @GYMBENC_1304 
wait 0 
jump @GYMBENC_1264 

:GYMBENC_1304
" + _1829 + @" = 1 

:GYMBENC_1311
if and
  " + _1830 + @" == 2 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_2547 
0512: show_permanent_text_box 'GYM1_71'  // ~k~~GO_FORWARD~ њ ~k~~GO_BACK~ - ўЁ—pa¦© ®a™pyџky.~N~~k~~PED_SPRINT~ - ўЁ—op.~N~~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
if or
  " + Current_Language + @" == 4 
  " + Current_Language + @" == 2 
jf @GYMBENC_1538 
08D4: " + _8734 + @" = create_panel_with_title 'GYM1_E' position 31.0 180.0 width 184.0 columns 1 interactive 1 background 1 alignment 0  // Ћ¦a®™a
08DB: set_panel " + _8734 + @" column 0 header 'GYM1_72' data 'GYM1_8' 'GYM1_9' 'GYM1_10' 'GYM1_11' 'GYM1_12' 'GYM1_13' 'GYM1_14' 'GYM1_15' 'GYM1_16' 'GYM1_17' 'DUMMY' 'DUMMY'  // ­a™pyџka // 20 k™ // 30 k™ // 40 k™ // 50 k™ // 60 k™ // 80 k™ // 100 k™ // 120 k™ // 140 k™ // 160 k™
jump @GYMBENC_1699 

:GYMBENC_1538
08D4: " + _8734 + @" = create_panel_with_title 'GYM1_E' position 31.0 150.0 width 184.0 columns 1 interactive 1 background 1 alignment 0  // Ћ¦a®™a
08DB: set_panel " + _8734 + @" column 0 header 'GYM1_72' data 'GYM1_8' 'GYM1_9' 'GYM1_10' 'GYM1_11' 'GYM1_12' 'GYM1_13' 'GYM1_14' 'GYM1_15' 'GYM1_16' 'GYM1_17' 'DUMMY' 'DUMMY'  // ­a™pyџka // 20 k™ // 30 k™ // 40 k™ // 50 k™ // 60 k™ // 80 k™ // 100 k™ // 120 k™ // 140 k™ // 160 k™

:GYMBENC_1699
090E: set_panel " + _8734 + @" active_row 0 

:GYMBENC_1706
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_1824 
wait 0 
" + _8714 + @" += 1 
if and
00E1:   player 0 pressed_key 15 
  " + _8714 + @" > 20 
jf @GYMBENC_1771 
03E6: remove_text_box 
08DA: remove_panel " + _8734 + @" 
jump @GYMBENC_7348 

:GYMBENC_1771
if 
00E1:   player 0 pressed_key 16 
jf @GYMBENC_1817 
03E6: remove_text_box 
08D7: 21@ = panel " + _8734 + @" active_row 
21@ += 1 
08DA: remove_panel " + _8734 + @" 
jump @GYMBENC_1824 

:GYMBENC_1817
jump @GYMBENC_1706 

:GYMBENC_1824
if 
  21@ == 1 
jf @GYMBENC_1862 
" + _8736 + @" = 1.0 
20@ = 5.0 

:GYMBENC_1862
if 
  21@ == 2 
jf @GYMBENC_1900 
20@ = 5.2 
" + _8736 + @" = 2.0 

:GYMBENC_1900
if 
  21@ == 3 
jf @GYMBENC_1938 
20@ = 5.3 
" + _8736 + @" = 3.0 

:GYMBENC_1938
if 
  21@ == 4 
jf @GYMBENC_1976 
20@ = 5.5 
" + _8736 + @" = 4.0 

:GYMBENC_1976
if 
  21@ == 5 
jf @GYMBENC_2014 
20@ = 6.0 
" + _8736 + @" = 5.0 

:GYMBENC_2014
if 
  21@ == 6 
jf @GYMBENC_2052 
20@ = 6.5 
" + _8736 + @" = 6.0 

:GYMBENC_2052
if 
  21@ == 7 
jf @GYMBENC_2090 
20@ = 7.0 
" + _8736 + @" = 7.0 

:GYMBENC_2090
if 
  21@ == 8 
jf @GYMBENC_2128 
20@ = 7.5 
" + _8736 + @" = 8.0 

:GYMBENC_2128
if 
  21@ == 9 
jf @GYMBENC_2166 
20@ = 8.0 
" + _8736 + @" = 9.0 

:GYMBENC_2166
if 
  21@ == 10 
jf @GYMBENC_2204 
20@ = 8.5 
" + _8736 + @" = 10.0 

:GYMBENC_2204
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_2266 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_GETON"" IFP ""BENCHPRESS"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_2266
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_2540 
if and
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_GETON""
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_2540 
0613: " + _1824 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETON"" time 

:GYMBENC_2343
if 
   not " + _1824 + @" > 0.75 
jf @GYMBENC_2413 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_2406 
0613: " + _1824 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETON"" time 

:GYMBENC_2406
jump @GYMBENC_2343 

:GYMBENC_2413
if 
03D0:   wav 4 loaded 
jf @GYMBENC_2436 
097B: play_audio_at_object 0@ event 1117 

:GYMBENC_2436
Object.KeepInMemory(30@) = False
0682: detach_object 30@ 0.0 0.0 0.0 collision_detection 0 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_2526 
070A: AS_actor " + PlayerActor + @" attach_to_object 30@ offset 0.0 0.0 -0.1 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time -1 

:GYMBENC_2526
" + _1830 + @" = 4 
TIMERA = 0 

:GYMBENC_2540
" + _1830 + @" = 4 

:GYMBENC_2547
if and
  " + _1830 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_3225 
if 
  " + _8735 + @" == 0 
jf @GYMBENC_2608 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_37'  // ~w~Ќ¦o—Ё Јoљ®њЇa¦© Ґ¦a®™y, Јoo¤epeљ®o ®a›њЇaќ ~k~~PED_SPRINT~ њ ~k~~PED_FIREWEAPON~.~n~ЌeЇ —Ёc¦pee ¦Ё —yљeҐ© њx ®a›њЇa¦©, ¦eЇ ckopee —yљe¦ џaЈoћ®¬¦©c¬ Ґkaћa Є®ep™њњ.
" + _8735 + @" = 1 

:GYMBENC_2608
if and
  TIMERA > 6000 
  " + _8735 + @" == 1 
jf @GYMBENC_2654 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_25'  // ~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
" + _8735 + @" = 2 

:GYMBENC_2654
if and
  TIMERA > 9000 
  " + _8735 + @" == 2 
jf @GYMBENC_2689 
03E6: remove_text_box 
" + _8735 + @" = 101 

:GYMBENC_2689
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_GETON""
jf @GYMBENC_2776 
0613: " + _1816 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETON"" time 
if 
  " + _1816 + @" == 1.0 
jf @GYMBENC_2769 
jump @GYMBENC_2830 

:GYMBENC_2769
jump @GYMBENC_3225 

:GYMBENC_2776
if and
  " + _1814 + @" == 1 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_3225 
" + _8738 + @" = 0 
" + _1818 + @" = 0 
0151: remove_status_text " + _8738 + @" 
0151: remove_status_text " + _1818 + @" 
jump @GYMBENC_2830 

:GYMBENC_2830
0653: " + _1817 + @" = float_stat 23 
" + _1817 + @" /= 30.0 
if 
  0.0 > " + _1817 + @" 
jf @GYMBENC_2878 
" + _1817 + @" = 0.0 

:GYMBENC_2878
0086: " + _8737 + @" = " + _1817 + @" // (float) 
" + _8737 + @" += 30.0 
if 
  " + _8737 + @" > 75.0 
jf @GYMBENC_2927 
" + _8737 + @" = 75.0 

:GYMBENC_2927
008F: 19@ = integer " + _8738 + @" to_float 
0086: " + _1823 + @" = " + _8737 + @" // (float) 
0061: " + _1823 + @" -= " + _8736 + @" // (float) 
if 
  18.0 >= " + _1823 + @" 
jf @GYMBENC_3017 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_UP_B"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_3017
if 
  " + _1823 + @" > 18.0 
jf @GYMBENC_3104 
if 
  24.0 >= " + _1823 + @" 
jf @GYMBENC_3104 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_UP_A"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_3104
if 
  " + _1823 + @" > 24.0 
jf @GYMBENC_3175 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_UP_SMOOTH"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_3175
04F7: status_text " + _1818 + @" type 1 line 1 GXT 'GYM1_1' // global_variable  // Є®ep™њ¬
04F7: status_text " + _8738 + @" type 0 line 2 GXT 'GYM1_2' // global_variable  // Јoљ§eЇoў
" + _1813 + @" = 1 
" + _1830 + @" = 5 

:GYMBENC_3225
if and
  " + _1830 + @" == 5 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6956 
0653: " + _1817 + @" = float_stat 23 
" + _1817 + @" /= 30.0 
if 
  0.0 > " + _1817 + @" 
jf @GYMBENC_3296 
" + _1817 + @" = 0.0 

:GYMBENC_3296
0086: " + _8737 + @" = " + _1817 + @" // (float) 
" + _8737 + @" += 20.0 
if 
  " + _8737 + @" > 75.0 
jf @GYMBENC_3345 
" + _8737 + @" = 75.0 

:GYMBENC_3345
if 
  " + _8735 + @" == 0 
jf @GYMBENC_3383 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_37'  // ~w~Ќ¦o—Ё Јoљ®њЇa¦© Ґ¦a®™y, Јoo¤epeљ®o ®a›њЇaќ ~k~~PED_SPRINT~ њ ~k~~PED_FIREWEAPON~.~n~ЌeЇ —Ёc¦pee ¦Ё —yљeҐ© њx ®a›њЇa¦©, ¦eЇ ckopee —yљe¦ џaЈoћ®¬¦©c¬ Ґkaћa Є®ep™њњ.
" + _8735 + @" = 1 

:GYMBENC_3383
if and
  TIMERA > 6000 
  " + _8735 + @" == 1 
jf @GYMBENC_3429 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_25'  // ~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
" + _8735 + @" = 2 

:GYMBENC_3429
if and
  TIMERA > 9000 
  " + _8735 + @" == 2 
jf @GYMBENC_3464 
03E6: remove_text_box 
" + _8735 + @" = 101 

:GYMBENC_3464
if or
  " + _1813 + @" == 1 
  " + _1813 + @" == 3 
jf @GYMBENC_3517 
" + _8762 + @" /= 2.0 
0082: 18@ -= frame_delta_time * " + _8736 + @" // (float) 
" + _8762 + @" *= 2.0 

:GYMBENC_3517
if 
  " + _1813 + @" == 4 
jf @GYMBENC_3545 
007F: 18@ -= frame_delta_time * 2.0 // (float) 

:GYMBENC_3545
if 
80E1:   not player 0 pressed_key 16 
jf @GYMBENC_3587 
if 
  26@ == 1 
jf @GYMBENC_3587 
26@ = 2 

:GYMBENC_3587
if 
80E1:   not player 0 pressed_key 17 
jf @GYMBENC_3629 
if 
  26@ == 3 
jf @GYMBENC_3629 
26@ = 0 

:GYMBENC_3629
if or
  " + _1813 + @" == 1 
  " + _1813 + @" == 3 
jf @GYMBENC_3766 
if and
00E1:   player 0 pressed_key 16 
80E1:   not player 0 pressed_key 17 
jf @GYMBENC_3710 
if 
  26@ == 0 
jf @GYMBENC_3710 
005D: 18@ += " + _8737 + @" // (float) 
26@ = 1 

:GYMBENC_3710
if and
00E1:   player 0 pressed_key 17 
80E1:   not player 0 pressed_key 16 
jf @GYMBENC_3766 
if 
  26@ == 2 
jf @GYMBENC_3766 
005D: 18@ += " + _8737 + @" // (float) 
26@ = 3 

:GYMBENC_3766
if 
  0.0 > 18@ 
jf @GYMBENC_3797 
18@ = 0.0 

:GYMBENC_3797
if 
  18@ > 25.0 
jf @GYMBENC_3829 
0947: actor " + PlayerActor + @" speak_from_audio_table 354 store_spoken_phrase_id_to " + _8745 + @" 

:GYMBENC_3829
if 
  18@ >= 100.0 
jf @GYMBENC_3885 
18@ = 100.0 
if 
  " + _1813 + @" == 1 
jf @GYMBENC_3885 
" + _1813 + @" = 2 

:GYMBENC_3885
if and
  " + _1813 + @" == 2 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_3950 
if 
  " + _1819 + @" == 1.0 
jf @GYMBENC_3950 
26@ = 0 
" + _1813 + @" = 3 
TIMERB = 0 

:GYMBENC_3950
if and
  " + _1813 + @" == 3 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6050 
0871: init_jump_table 21@ total_jumps 10 default_jump 0 @GYMBENC_4246 jumps 1 @GYMBENC_4101 2 @GYMBENC_4115 3 @GYMBENC_4129 4 @GYMBENC_4143 5 @GYMBENC_4157 6 @GYMBENC_4171 7 @GYMBENC_4186 
0872: jump_table_jumps 8 @GYMBENC_4201 9 @GYMBENC_4216 10 @GYMBENC_4231 -1 @GYMBENC_4246 -1 @GYMBENC_4246 -1 @GYMBENC_4246 -1 @GYMBENC_4246 -1 @GYMBENC_4246 -1 @GYMBENC_4246 

:GYMBENC_4101
" + GYM_Bench_Weight + @" = 40 
jump @GYMBENC_4246 

:GYMBENC_4115
" + GYM_Bench_Weight + @" = 60 
jump @GYMBENC_4246 

:GYMBENC_4129
" + GYM_Bench_Weight + @" = 80 
jump @GYMBENC_4246 

:GYMBENC_4143
" + GYM_Bench_Weight + @" = 100 
jump @GYMBENC_4246 

:GYMBENC_4157
" + GYM_Bench_Weight + @" = 120 
jump @GYMBENC_4246 

:GYMBENC_4171
" + GYM_Bench_Weight + @" = 160 
jump @GYMBENC_4246 

:GYMBENC_4186
" + GYM_Bench_Weight + @" = 200 
jump @GYMBENC_4246 

:GYMBENC_4201
" + GYM_Bench_Weight + @" = 240 
jump @GYMBENC_4246 

:GYMBENC_4216
" + GYM_Bench_Weight + @" = 280 
jump @GYMBENC_4246 

:GYMBENC_4231
" + GYM_Bench_Weight + @" = 320 
jump @GYMBENC_4246 

:GYMBENC_4246
0652: " + GYM_STAT_Bench_Heaviest_Weight + @" = integer_stat 46 
if 
001C:   " + GYM_Bench_Weight + @" > " + GYM_STAT_Bench_Heaviest_Weight + @" // (int) 
jf @GYMBENC_4279 
0629: change_integer_stat 46 to " + GYM_Bench_Weight + @" 

:GYMBENC_4279
015B: shake_player_controller 0 time 200 intensity 200 
if 
   not " + _8738 + @" >= 999999 
jf @GYMBENC_4317 
" + _8738 + @" += 1 

:GYMBENC_4317
0653: " + _8747 + @" = float_stat 23 
if 
  1000.0 > " + _8747 + @" 
jf @GYMBENC_4625 
if 
  21@ == 1 
jf @GYMBENC_4373 
20@ = 1.0 

:GYMBENC_4373
if 
  21@ == 2 
jf @GYMBENC_4401 
20@ = 1.2 

:GYMBENC_4401
if 
  21@ == 3 
jf @GYMBENC_4429 
20@ = 1.3 

:GYMBENC_4429
if 
  21@ == 4 
jf @GYMBENC_4457 
20@ = 1.5 

:GYMBENC_4457
if 
  21@ == 5 
jf @GYMBENC_4485 
20@ = 2.0 

:GYMBENC_4485
if 
  21@ == 6 
jf @GYMBENC_4513 
20@ = 2.5 

:GYMBENC_4513
if 
  21@ == 7 
jf @GYMBENC_4541 
20@ = 3.0 

:GYMBENC_4541
if 
  21@ == 8 
jf @GYMBENC_4569 
20@ = 4.0 

:GYMBENC_4569
if 
  21@ == 9 
jf @GYMBENC_4597 
20@ = 5.0 

:GYMBENC_4597
if 
  21@ == 10 
jf @GYMBENC_4625 
20@ = 6.0 

:GYMBENC_4625
if 
  800.0 > " + _8747 + @" 
jf @GYMBENC_4926 
if 
  21@ == 1 
jf @GYMBENC_4674 
20@ = 2.0 

:GYMBENC_4674
if 
  21@ == 2 
jf @GYMBENC_4702 
20@ = 2.2 

:GYMBENC_4702
if 
  21@ == 3 
jf @GYMBENC_4730 
20@ = 2.3 

:GYMBENC_4730
if 
  21@ == 4 
jf @GYMBENC_4758 
20@ = 2.5 

:GYMBENC_4758
if 
  21@ == 5 
jf @GYMBENC_4786 
20@ = 3.0 

:GYMBENC_4786
if 
  21@ == 6 
jf @GYMBENC_4814 
20@ = 3.5 

:GYMBENC_4814
if 
  21@ == 7 
jf @GYMBENC_4842 
20@ = 4.0 

:GYMBENC_4842
if 
  21@ == 8 
jf @GYMBENC_4870 
20@ = 5.0 

:GYMBENC_4870
if 
  21@ == 9 
jf @GYMBENC_4898 
20@ = 6.0 

:GYMBENC_4898
if 
  21@ == 10 
jf @GYMBENC_4926 
20@ = 7.0 

:GYMBENC_4926
if 
  600.0 > " + _8747 + @" 
jf @GYMBENC_5227 
if 
  21@ == 1 
jf @GYMBENC_4975 
20@ = 3.0 

:GYMBENC_4975
if 
  21@ == 2 
jf @GYMBENC_5003 
20@ = 3.2 

:GYMBENC_5003
if 
  21@ == 3 
jf @GYMBENC_5031 
20@ = 3.3 

:GYMBENC_5031
if 
  21@ == 4 
jf @GYMBENC_5059 
20@ = 3.5 

:GYMBENC_5059
if 
  21@ == 5 
jf @GYMBENC_5087 
20@ = 4.0 

:GYMBENC_5087
if 
  21@ == 6 
jf @GYMBENC_5115 
20@ = 4.5 

:GYMBENC_5115
if 
  21@ == 7 
jf @GYMBENC_5143 
20@ = 5.0 

:GYMBENC_5143
if 
  21@ == 8 
jf @GYMBENC_5171 
20@ = 6.0 

:GYMBENC_5171
if 
  21@ == 9 
jf @GYMBENC_5199 
20@ = 7.0 

:GYMBENC_5199
if 
  21@ == 10 
jf @GYMBENC_5227 
20@ = 8.0 

:GYMBENC_5227
if 
  400.0 > " + _8747 + @" 
jf @GYMBENC_5528 
if 
  21@ == 1 
jf @GYMBENC_5276 
20@ = 4.0 

:GYMBENC_5276
if 
  21@ == 2 
jf @GYMBENC_5304 
20@ = 4.2 

:GYMBENC_5304
if 
  21@ == 3 
jf @GYMBENC_5332 
20@ = 4.3 

:GYMBENC_5332
if 
  21@ == 4 
jf @GYMBENC_5360 
20@ = 4.5 

:GYMBENC_5360
if 
  21@ == 5 
jf @GYMBENC_5388 
20@ = 5.0 

:GYMBENC_5388
if 
  21@ == 6 
jf @GYMBENC_5416 
20@ = 5.5 

:GYMBENC_5416
if 
  21@ == 7 
jf @GYMBENC_5444 
20@ = 6.0 

:GYMBENC_5444
if 
  21@ == 8 
jf @GYMBENC_5472 
20@ = 7.0 

:GYMBENC_5472
if 
  21@ == 9 
jf @GYMBENC_5500 
20@ = 8.0 

:GYMBENC_5500
if 
  21@ == 10 
jf @GYMBENC_5528 
20@ = 9.0 

:GYMBENC_5528
if 
  200.0 > " + _8747 + @" 
jf @GYMBENC_5829 
if 
  21@ == 1 
jf @GYMBENC_5577 
20@ = 5.0 

:GYMBENC_5577
if 
  21@ == 2 
jf @GYMBENC_5605 
20@ = 5.2 

:GYMBENC_5605
if 
  21@ == 3 
jf @GYMBENC_5633 
20@ = 5.3 

:GYMBENC_5633
if 
  21@ == 4 
jf @GYMBENC_5661 
20@ = 5.5 

:GYMBENC_5661
if 
  21@ == 5 
jf @GYMBENC_5689 
20@ = 6.0 

:GYMBENC_5689
if 
  21@ == 6 
jf @GYMBENC_5717 
20@ = 6.5 

:GYMBENC_5717
if 
  21@ == 7 
jf @GYMBENC_5745 
20@ = 7.0 

:GYMBENC_5745
if 
  21@ == 8 
jf @GYMBENC_5773 
20@ = 7.5 

:GYMBENC_5773
if 
  21@ == 9 
jf @GYMBENC_5801 
20@ = 8.0 

:GYMBENC_5801
if 
  21@ == 10 
jf @GYMBENC_5829 
20@ = 8.5 

:GYMBENC_5829
if 
  " + _8746 + @" == 8 
jf @GYMBENC_5876 
" + _8746 + @" = 0 
0624: add 20@ to_float_stat 23 
005F: " + GYM_Day_Limit + @" += 20@ // (float) 
jump @GYMBENC_5898 

:GYMBENC_5876
0A1F: increase_float_stat 23 by 20@ 
" + _8746 + @" += 1 
005F: " + GYM_Day_Limit + @" += 20@ // (float) 

:GYMBENC_5898
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMBENC_5943 
0835: get_month_day_to " + GYM_Month_Day_When_Limit_Reached + @" get_month_to " + GYM_Month_When_Limit_Reached + @" 
00BC: show_text_highpriority GXT 'GYM1_1B' time 4000 flag 1  // ЏЁ ce™oљ®¬ љoc¦a¦o¤®o Јoџa®њЇaћc¬, Јpњxoљњ џaў¦pa!

:GYMBENC_5943
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  " + GYM_STAT_Fat + @" >= 1.0 
jf @GYMBENC_5980 
0626: decrease_float_stat 21 by 1.0 

:GYMBENC_5980
" + _1818 + @" = 0 
0947: actor " + PlayerActor + @" speak_from_audio_table 355 store_spoken_phrase_id_to " + _8745 + @" 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_DOWN"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
" + _1813 + @" = 4 

:GYMBENC_6050
if and
  " + _1813 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6390 
if and
  18@ == 0.0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6390 
if 
  " + _1819 + @" == 0.0 
jf @GYMBENC_6390 
008F: 19@ = integer " + _8738 + @" to_float 
0086: " + _1823 + @" = " + _8737 + @" // (float) 
0061: " + _1823 + @" -= " + _8736 + @" // (float) 
if and
  18.0 >= " + _1823 + @" 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6215 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_UP_B"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_6215
if and
  " + _1823 + @" > 18.0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6307 
if 
  24.0 >= " + _1823 + @" 
jf @GYMBENC_6307 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_UP_A"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_6307
if and
  " + _1823 + @" > 24.0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6383 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_UP_SMOOTH"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMBENC_6383
" + _1813 + @" = 1 

:GYMBENC_6390
0088: " + _1820 + @" = 18@ // (float) 
" + _1820 + @" /= 100.0 
if and
  " + _1813 + @" > 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6769 
0086: " + _1821 + @" = " + _1820 + @" // (float) 
0061: " + _1821 + @" -= " + _1819 + @" // (float) 
" + _1821 + @" /= 2.0 
if and
  0.05 > " + _1821 + @" 
  " + _1821 + @" > -0.05 
jf @GYMBENC_6503 
0086: " + _1819 + @" = " + _1820 + @" // (float) 
jump @GYMBENC_6511 

:GYMBENC_6503
0059: " + _1819 + @" += " + _1821 + @" // (float) 

:GYMBENC_6511
if and
  " + _1813 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6609 
" + _1822 + @" = 1.0 
0061: " + _1822 + @" -= " + _1819 + @" // (float) 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_DOWN""
jf @GYMBENC_6602 
0614: set_actor " + PlayerActor + @" animation ""GYM_BP_DOWN"" progress_to " + _1822 + @" // 0.0 to 1.0 

:GYMBENC_6602
jump @GYMBENC_6769 

:GYMBENC_6609
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_UP_A""
jf @GYMBENC_6659 
0614: set_actor " + PlayerActor + @" animation ""GYM_BP_UP_A"" progress_to " + _1819 + @" // 0.0 to 1.0 

:GYMBENC_6659
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_UP_B""
jf @GYMBENC_6709 
0614: set_actor " + PlayerActor + @" animation ""GYM_BP_UP_B"" progress_to " + _1819 + @" // 0.0 to 1.0 

:GYMBENC_6709
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_UP_SMOOTH""
jf @GYMBENC_6769 
0614: set_actor " + PlayerActor + @" animation ""GYM_BP_UP_SMOOTH"" progress_to " + _1819 + @" // 0.0 to 1.0 

:GYMBENC_6769
0090: " + _1818 + @" = float 18@ to_integer 
if or
00E1:   player 0 pressed_key 15 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMBENC_6956 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6956 

:GYMBENC_6820
if 
00E1:   player 0 pressed_key 16 
jf @GYMBENC_6848 
wait 0 
jump @GYMBENC_6820 

:GYMBENC_6848
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_6911 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_GETOFF"" IFP ""BENCHPRESS"" framedelta 100.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMBENC_6911
" + _1818 + @" = 0 
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMBENC_6949 
" + GYM_Day_Limit + @" = 0.0 

:GYMBENC_6949
" + _1830 + @" = 6 

:GYMBENC_6956
if and
  " + _1830 + @" == 6 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_8093 
if 
  " + _8738 + @" > 4 
jf @GYMBENC_7613 
if and
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_GETOFF""
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_7606 
0613: " + _1825 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETOFF"" time 

:GYMBENC_7056
if 
   not " + _1825 + @" > 0.26 
jf @GYMBENC_7127 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_7120 
0613: " + _1825 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETOFF"" time 

:GYMBENC_7120
jump @GYMBENC_7056 

:GYMBENC_7127
if and
03D0:   wav 4 loaded 
  " + _8744 + @" == 0 
jf @GYMBENC_7164 
097B: play_audio_at_object 0@ event 1117 
" + _8744 + @" = 1 

:GYMBENC_7164
070B: set_actor " + PlayerActor + @" onbone_attached_object_operation 0 
Object.KeepInMemory(30@) = True
Object.Destroy(30@)
30@ = Object.Create(#KMB_BPRESS, 8@, 9@, 10@)
069A: attach_object 30@ to_object 0@ with_offset -0.45 0.45 0.9 rotation 90.0 180.0 270.0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_7277 
0613: " + _1816 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETOFF"" time 

:GYMBENC_7277
if 
  " + _1816 + @" == 1.0 
jf @GYMBENC_7606 
0605: actor " + PlayerActor + @" perform_animation ""GYM_BP_CELEBRATE"" IFP ""BENCHPRESS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMBENC_7348
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_7606 
23@ = 0 
" + _1813 + @" = 0 
27@ = 1 
21@ = 1 
" + _8738 + @" = 0 
" + _1818 + @" = 0 
" + _1823 + @" = 0.0 
" + _1830 + @" = 0 
18@ = 0.0 
21@ = 1 
" + _8738 + @" = 0 
0653: " + _1817 + @" = float_stat 23 
if 
  " + _1817 + @" >= 1000.0 
jf @GYMBENC_7484 
062A: change_float_stat 23 to 1000.0 

:GYMBENC_7484
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  0.0 >= " + GYM_STAT_Fat + @" 
jf @GYMBENC_7521 
062A: change_float_stat 21 to 0.0 

:GYMBENC_7521
" + _1824 + @" = 0.0 
" + _1825 + @" = 0.0 
0151: remove_status_text " + _8738 + @" 
0151: remove_status_text " + _1818 + @" 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 
04EF: release_animation ""BENCHPRESS"" 
040D: unload_wav 4 
03E6: remove_text_box 
08DA: remove_panel " + _8734 + @" 
" + _8735 + @" = 0 
" + _1829 + @" = 0 

:GYMBENC_7606
jump @GYMBENC_8093 

:GYMBENC_7613
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_8093 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_BP_GETOFF""
jf @GYMBENC_8093 
0613: " + _1825 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETOFF"" time 

:GYMBENC_7683
if 
   not " + _1825 + @" > 0.26 
jf @GYMBENC_7754 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_7747 
0613: " + _1825 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETOFF"" time 

:GYMBENC_7747
jump @GYMBENC_7683 

:GYMBENC_7754
if and
03D0:   wav 4 loaded 
  " + _8744 + @" == 0 
jf @GYMBENC_7791 
097B: play_audio_at_object 0@ event 1117 
" + _8744 + @" = 1 

:GYMBENC_7791
070B: set_actor " + PlayerActor + @" onbone_attached_object_operation 0 
Object.KeepInMemory(30@) = True
Object.Destroy(30@)
30@ = Object.Create(#KMB_BPRESS, 8@, 9@, 10@)
069A: attach_object 30@ to_object 0@ with_offset -0.45 0.45 0.9 rotation 90.0 180.0 270.0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMBENC_7904 
0613: " + _1816 + @" = actor " + PlayerActor + @" animation ""GYM_BP_GETOFF"" time 

:GYMBENC_7904
if 
  " + _1816 + @" == 1.0 
jf @GYMBENC_8093 
" + _1824 + @" = 0.0 
" + _1825 + @" = 0.0 
23@ = 0 
" + _1813 + @" = 0 
27@ = 1 
21@ = 1 
" + _8738 + @" = 0 
" + _1818 + @" = 0 
" + _1823 + @" = 0.0 
" + _1830 + @" = 0 
18@ = 0.0 
21@ = 1 
" + _8738 + @" = 0 
0151: remove_status_text " + _8738 + @" 
0151: remove_status_text " + _1818 + @" 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 
04EF: release_animation ""BENCHPRESS"" 
040D: unload_wav 4 
03E6: remove_text_box 
08DA: remove_panel " + _8734 + @" 
" + _8735 + @" = 0 
" + _1829 + @" = 0 

:GYMBENC_8093
jump @GYMBENC_632 
end_thread
" );

            }

        }

        private sealed class GYMTREA : External {

            public override void START( LabelJump label ) {
                AppendLine( @"
" + _8756 + @" = 0 
" + _8757 + @" = 0 
" + _8755 + @" = 0 
" + _8750 + @" = 0 
" + _8751 + @" = 0 
" + _8752 + @" = 0 
" + _8753 + @" = 0 
" + _8754 + @" = 0 
" + _1831 + @" = 0 
" + _1832 + @" = 0 
" + _1833 + @" = 0 
" + _1834 + @" = 0 
" + _1835 + @" = 0 
" + _1836 + @" = 0 
" + _1837 + @" = 0 
" + _1838 + @" = 0 
" + _1839 + @" = 0 
" + _1840 + @" = 0 
" + _8750 + @" = 1 
" + _8752 + @" = 1 
" + _1830 + @" = 0 
" + _8753 + @" = 0 
" + _1829 + @" = 0 
" + _1840 + @" = 1 
19@ = 1.0 
22@ = 0.0 
21@ = 0.0 
27@ = 0 
TIMERA = 0 
TIMERB = 0 
28@ = 0 
if 
  28@ == 1 
jf @GYMTREA_278 
0@ = Object.Init(#BEACHTOWEL03, 0.0, 0.0, 0.0)

:GYMTREA_278
if 
03CA:   object 0@ exists 
jf @GYMTREA_330 
Object.StorePos(0@, 1@, 2@, 3@)
Object.StorePos(0@, 7@, 8@, 9@)
10@ = Object.Angle(0@)

:GYMTREA_330
19@ = 1.0 
" + _8750 + @" = 1 
" + _8752 + @" = 1 
26@ = 1.0 
0087: 6@ = 3@ // (float) 
6@ += 1.5 
0087: 9@ = 3@ // (float) 
9@ += 0.75 
0087: 11@ = 10@ // (float) 
11@ -= 60.0 
02F6: 12@ = sine 11@ // (float) 
02F7: 13@ = cosine 11@ // (float) 
12@ *= 3.0 
13@ *= 3.0 
0087: 4@ = 1@ // (float) 
0063: 4@ -= 13@ // (float) 
0087: 5@ = 2@ // (float) 
0063: 5@ -= 12@ // (float) 
0087: 11@ = 10@ // (float) 
11@ += 90.0 
02F6: 12@ = sine 11@ // (float) 
02F7: 13@ = cosine 11@ // (float) 
12@ *= 1.5 
13@ *= 1.5 
0063: 1@ -= 13@ // (float) 
0063: 2@ -= 12@ // (float) 
3@ += 0.1 
" + _1829 + @" = 0 

:GYMTREA_573
wait 0 
if 
83CA:   not object 0@ exists 
jf @GYMTREA_595 
end_thread 

:GYMTREA_595
if 
   Player.Defined(" + PlayerChar + @")
jf @GYMTREA_5900 
if and
  " + _1830 + @" == 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_979 
if and
  " + _1831 + @" == 0 
8A0C:   not player " + PlayerChar + @" on_jetpack 
jf @GYMTREA_979 
if 
  " + _1840 + @" == 0 
jf @GYMTREA_938 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 1@ 2@ 3@ radius 1.2 1.2 4.0 on_foot 
jf @GYMTREA_904 
if 
  27@ == 0 
jf @GYMTREA_753 
0512: show_permanent_text_box 'GYM1_81'  // ~k~~VEHICLE_ENTER_EXIT~ - њcЈoћ©џoўa¦©.
27@ = 1 

:GYMTREA_753
if 
00E1:   player 0 pressed_key 15 
jf @GYMTREA_897 
if or
  " + OnMission + @" == 0 
  " + ONMISSION_GYMFIGHT + @" == 1 
jf @GYMTREA_881 
0835: get_month_day_to " + Current_Month_Day + @" get_month_to " + Current_Month + @" 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" // (int) 
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit_Reached + @" // (int) 
jf @GYMTREA_858 
" + _1831 + @" = 1 
" + _1830 + @" = 1 
" + _8714 + @" = 0 
jump @GYMTREA_874 

:GYMTREA_858
00BC: show_text_highpriority GXT 'GYM1_1A' time 4000 flag 1  // ЏЁ љoc¦a¦o¤®o Јopa—o¦aћ ®aљ co—oќ ce™oљ®¬, Јpњxoљњ џaў¦pa!

:GYMTREA_874
jump @GYMTREA_897 

:GYMTREA_881
00BC: show_text_highpriority GXT 'GYM1_90' time 4000 flag 1  // ~s~Џe—e ceќ¤ac ®e љo Є¦o™o, Јo¤eЇy —Ё ¦e—e ®e Јpњќ¦њ Јoџ›e?

:GYMTREA_897
jump @GYMTREA_931 

:GYMTREA_904
if 
  27@ == 1 
jf @GYMTREA_931 
03E6: remove_text_box 
27@ = 0 

:GYMTREA_931
jump @GYMTREA_979 

:GYMTREA_938
if 
80ED:   not actor " + PlayerActor + @" sphere 0 near_point 1@ 2@ radius 2.0 2.0 on_foot 
jf @GYMTREA_979 
" + _1840 + @" = 0 

:GYMTREA_979
if and
  " + _1831 + @" == 1 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_5900 
if and
  " + _1830 + @" == 1 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_1114 
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Player.CanMove(" + PlayerChar + @") = False
08C7: put_actor " + PlayerActor + @" at 1@ 2@ 3@ dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 10@
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
Camera.SetPosition(4@, 5@, 6@, 0.0, 0.0, 0.0)
Camera.PointAt(7@, 8@, 9@, 2)
" + _1830 + @" = 2 

:GYMTREA_1114
if 
  " + _1829 + @" == 0 
jf @GYMTREA_1224 
04ED: load_animation ""GYMNASIUM"" 

:GYMTREA_1145
if 
84EE:   not animation ""GYMNASIUM"" loaded 
jf @GYMTREA_1180 
wait 0 
jump @GYMTREA_1145 

:GYMTREA_1180
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMTREA_1191
if 
83D0:   not wav 4 loaded 
jf @GYMTREA_1217 
wait 0 
jump @GYMTREA_1191 

:GYMTREA_1217
" + _1829 + @" = 1 

:GYMTREA_1224
if 
  " + _1830 + @" == 2 
jf @GYMTREA_1944 
0512: show_permanent_text_box 'GYM1_60'  // ~k~~GO_FORWARD~ њ ~k~~GO_BACK~ - ўЁ—pa¦© ypoўe®©.~N~~k~~PED_SPRINT~ - Јpoљoћ›њ¦©.~N~~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
if or
  " + Current_Language + @" == 4 
  " + Current_Language + @" == 2 
jf @GYMTREA_1446 
08D4: " + _8748 + @" = create_panel_with_title 'GYM1_F' position 31.0 180.0 width 184.0 columns 1 interactive 1 background 1 alignment 0  // ѓopo›ka
08DB: set_panel " + _8748 + @" column 0 header 'GYM1_89' data 'GYM1_61' 'GYM1_62' 'GYM1_63' 'GYM1_64' 'GYM1_65' 'GYM1_66' 'GYM1_67' 'GYM1_68' 'GYM1_69' 'GYM1_70' 'DUMMY' 'DUMMY'  // Ypoўe®© // 1 ypoўe®© // 2 ypoўe®© // 3 ypoўe®© // 4 ypoўe®© // 5 ypoўe®© // 6 ypoўe®© // 7 ypoўe®© // 8 ypoўe®© // 9 ypoўe®© // 10 ypoўe®©
jump @GYMTREA_1607 

:GYMTREA_1446
08D4: " + _8748 + @" = create_panel_with_title 'GYM1_F' position 31.0 150.0 width 184.0 columns 1 interactive 1 background 1 alignment 0  // ѓopo›ka
08DB: set_panel " + _8748 + @" column 0 header 'GYM1_89' data 'GYM1_61' 'GYM1_62' 'GYM1_63' 'GYM1_64' 'GYM1_65' 'GYM1_66' 'GYM1_67' 'GYM1_68' 'GYM1_69' 'GYM1_70' 'DUMMY' 'DUMMY'  // Ypoўe®© // 1 ypoўe®© // 2 ypoўe®© // 3 ypoўe®© // 4 ypoўe®© // 5 ypoўe®© // 6 ypoўe®© // 7 ypoўe®© // 8 ypoўe®© // 9 ypoўe®© // 10 ypoўe®©

:GYMTREA_1607
090E: set_panel " + _8748 + @" active_row 0 

:GYMTREA_1614
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_1739 
wait 0 
" + _8714 + @" += 1 
if and
00E1:   player 0 pressed_key 15 
  " + _8714 + @" > 20 
jf @GYMTREA_1679 
03E6: remove_text_box 
08DA: remove_panel " + _8748 + @" 
jump @GYMTREA_5443 

:GYMTREA_1679
if 
00E1:   player 0 pressed_key 16 
jf @GYMTREA_1732 
03E6: remove_text_box 
08D7: " + _8750 + @" = panel " + _8748 + @" active_row 
" + _8750 + @" += 1 
08DA: remove_panel " + _8748 + @" 
TIMERA = 0 
jump @GYMTREA_1739 

:GYMTREA_1732
jump @GYMTREA_1614 

:GYMTREA_1739
if 
  " + _1815 + @" == 0 
jf @GYMTREA_1780 
03E5: show_text_box 'GYM1_42'  // Ќ¦o—Ё ®a¤a¦© —e™, —Ёc¦po ®a›њЇaќ ~k~~PED_SPRINT~.
wait 4000 
" + _1815 + @" = 1 

:GYMTREA_1780
if 
  " + _1815 + @" == 1 
jf @GYMTREA_1821 
03E5: show_text_box 'GYM1_43'  // ЏЁ Їo›eҐ© њџЇe®њ¦© ypoўe®© ўo ўpeЇ¬ —e™a.~n~~k~~CONVERSATION_NO~ - Јo®њџњ¦© ypoўe®©.~n~~k~~CONVERSATION_YES~ - ЈoўЁcњ¦© ypoўe®©.
wait 5000 
" + _1815 + @" = 2 

:GYMTREA_1821
if 
  " + _1815 + @" == 2 
jf @GYMTREA_1869 
03E5: show_text_box 'GYM1_45'  // ­e љaќ Ґkaћe Є®ep™њњ љoc¦њ™®y¦© ®yћ¬, њ®a¤e ¦Ё yЈaљeҐ© c —e™oўoќ љopo›kњ.
wait 4000 
" + _1815 + @" = 4 
TIMERA = 0 

:GYMTREA_1869
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_1933 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_GETON"" IFP ""GYMNASIUM"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMTREA_1933
wait 0 
" + _1830 + @" = 3 

:GYMTREA_1944
if and
  " + _1830 + @" == 3 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_2164 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_GETON""
jf @GYMTREA_2164 
0613: 14@ = actor " + PlayerActor + @" animation ""GYM_TREAD_GETON"" time 
if 
  14@ == 1.0 
jf @GYMTREA_2164 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_WALK"" IFP ""GYMNASIUM"" framedelta 8.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
04F7: status_text " + _8751 + @" type 1 line 1 GXT 'GYM1_1' // global_variable  // Є®ep™њ¬
04F7: status_text " + _8750 + @" type 0 line 2 GXT 'GYM1_4' // global_variable  // ypoўe®©
04F7: status_text " + _8753 + @" type 0 line 3 GXT 'GYM1_3' // global_variable  // Pacc¦o¬®њe
17@ = 30.0 
" + _1830 + @" = 4 

:GYMTREA_2164
if and
  " + _1830 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_5900 
23@ /= 500.0 
" + _1828 + @" /= 750.0 
005D: 23@ += " + _1828 + @" // (float) 
0087: 18@ = 20@ // (float) 
005B: 18@ += 23@ // (float) 
19@ /= 2.0 
0081: 17@ -= frame_delta_time * 19@ // (float) 
19@ *= 2.0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMTREA_2309 
if 
  " + _1834 + @" == 0 
jf @GYMTREA_2309 
005B: 17@ += 18@ // (float) 
" + _1834 + @" = 1 

:GYMTREA_2309
if 
80E1:   not player 0 pressed_key 16 
jf @GYMTREA_2351 
if 
  " + _1834 + @" == 1 
jf @GYMTREA_2351 
" + _1834 + @" = 0 

:GYMTREA_2351
if 
  0.0 > 17@ 
jf @GYMTREA_2382 
17@ = 0.0 

:GYMTREA_2382
if 
  17@ > 100.0 
jf @GYMTREA_2413 
17@ = 100.0 

:GYMTREA_2413
if 
00E1:   player 0 pressed_key 8 
jf @GYMTREA_2430 

:GYMTREA_2430
if 
00E1:   player 0 pressed_key 9 
jf @GYMTREA_2447 

:GYMTREA_2447
if 
80E1:   not player 0 pressed_key 8 
jf @GYMTREA_2489 
if 
  " + _1833 + @" == 1 
jf @GYMTREA_2489 
" + _1833 + @" = 0 

:GYMTREA_2489
if 
80E1:   not player 0 pressed_key 9 
jf @GYMTREA_2531 
if 
  " + _1833 + @" == 2 
jf @GYMTREA_2531 
" + _1833 + @" = 0 

:GYMTREA_2531
if 
00E1:   player 0 pressed_key 11 
jf @GYMTREA_2669 
if 
  " + _1835 + @" == 0 
jf @GYMTREA_2669 
if and
  " + _8750 + @" > 0 
  10 > " + _8750 + @" 
jf @GYMTREA_2669 
" + _8750 + @" += 1 
if 
03D0:   wav 4 loaded 
jf @GYMTREA_2621 
097B: play_audio_at_object 0@ event 1116 

:GYMTREA_2621
17@ -= 10.0 
if 
  0.0 > 17@ 
jf @GYMTREA_2662 
17@ = 0.0 

:GYMTREA_2662
" + _1835 + @" = 1 

:GYMTREA_2669
if 
00E1:   player 0 pressed_key 10 
jf @GYMTREA_2766 
if 
  " + _1835 + @" == 0 
jf @GYMTREA_2766 
if and
  " + _8750 + @" > 1 
  11 > " + _8750 + @" 
jf @GYMTREA_2766 
" + _8750 + @" -= 1 
if 
03D0:   wav 4 loaded 
jf @GYMTREA_2759 
097B: play_audio_at_object 0@ event 1116 

:GYMTREA_2759
" + _1835 + @" = 2 

:GYMTREA_2766
if 
80E1:   not player 0 pressed_key 11 
jf @GYMTREA_2808 
if 
  " + _1835 + @" == 1 
jf @GYMTREA_2808 
" + _1835 + @" = 0 

:GYMTREA_2808
if 
80E1:   not player 0 pressed_key 10 
jf @GYMTREA_2850 
if 
  " + _1835 + @" == 2 
jf @GYMTREA_2850 
" + _1835 + @" = 0 

:GYMTREA_2850
if 
  " + _8750 + @" == 1 
jf @GYMTREA_2888 
26@ = 1.0 
20@ = 9.5 

:GYMTREA_2888
if 
  " + _8750 + @" == 2 
jf @GYMTREA_2926 
26@ = 2.0 
20@ = 8.5 

:GYMTREA_2926
if 
  " + _8750 + @" == 3 
jf @GYMTREA_2964 
26@ = 3.0 
20@ = 7.5 

:GYMTREA_2964
if 
  " + _8750 + @" == 4 
jf @GYMTREA_3002 
26@ = 4.0 
20@ = 6.5 

:GYMTREA_3002
if 
  " + _8750 + @" == 5 
jf @GYMTREA_3040 
26@ = 5.0 
20@ = 5.5 

:GYMTREA_3040
if 
  " + _8750 + @" == 6 
jf @GYMTREA_3078 
26@ = 6.0 
20@ = 4.5 

:GYMTREA_3078
if 
  " + _8750 + @" == 7 
jf @GYMTREA_3116 
26@ = 7.0 
20@ = 3.5 

:GYMTREA_3116
if 
  " + _8750 + @" == 8 
jf @GYMTREA_3154 
26@ = 8.0 
20@ = 2.5 

:GYMTREA_3154
if 
  " + _8750 + @" == 9 
jf @GYMTREA_3192 
26@ = 9.0 
20@ = 1.5 

:GYMTREA_3192
if 
  " + _8750 + @" == 10 
jf @GYMTREA_3230 
26@ = 10.0 
20@ = 0.5 

:GYMTREA_3230
if 
  " + _1836 + @" == 0 
jf @GYMTREA_3299 
if 
  17@ > 0.0 
jf @GYMTREA_3299 
018C: play_sound 65535 at 1@ 2@ 3@ 
TIMERB = 0 
" + _1836 + @" = 1 

:GYMTREA_3299
if and
  0.0 >= 17@ 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_3803 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_WALK""
jf @GYMTREA_3406 
0605: actor " + PlayerActor + @" perform_animation ""GYM_WALK_FALLOFF"" IFP ""GYMNASIUM"" framedelta 100.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMTREA_3406
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_JOG""
jf @GYMTREA_3485 
0605: actor " + PlayerActor + @" perform_animation ""GYM_JOG_FALLOFF"" IFP ""GYMNASIUM"" framedelta 100.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMTREA_3485
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_SPRINT""
jf @GYMTREA_3569 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_FALLOFF"" IFP ""GYMNASIUM"" framedelta 100.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMTREA_3569
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  0.0 >= " + GYM_STAT_Fat + @" 
jf @GYMTREA_3606 
062A: change_float_stat 21 to 0.0 

:GYMTREA_3606
" + _1831 + @" = 0 
" + _1832 + @" = 0 
" + _1833 + @" = 0 
" + _1834 + @" = 0 
" + _1835 + @" = 0 
" + _1836 + @" = 0 
" + _1837 + @" = 0 
" + _1838 + @" = 0 
" + _1839 + @" = 0 
" + _1840 + @" = 0 
19@ = 1.0 
" + _8750 + @" = 0 
" + _8752 + @" = 1 
" + _1830 + @" = 0 
" + _8753 + @" = 0 
22@ = 0.0 
21@ = 0.0 
" + _1829 + @" = 0 
0151: remove_status_text " + _8751 + @" 
0151: remove_status_text " + _8750 + @" 
0151: remove_status_text " + _8753 + @" 
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
" + _1840 + @" = 1 
0619: enable_actor " + PlayerActor + @" collision_detection 1 
04EF: release_animation ""GYMNASIUM"" 
040D: unload_wav 4 
08DA: remove_panel " + _8748 + @" 
03E6: remove_text_box 

:GYMTREA_3803
if 
  " + _1831 + @" == 1 
jf @GYMTREA_4170 
if and
  " + _1837 + @" == 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_3937 
if and
  " + _8750 + @" > 0 
  3 > " + _8750 + @" 
jf @GYMTREA_3937 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_WALK"" IFP ""GYMNASIUM"" framedelta 100.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
" + _1837 + @" = 1 
" + _1838 + @" = 0 
" + _1839 + @" = 0 

:GYMTREA_3937
if and
  " + _1838 + @" == 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_4052 
if and
  " + _8750 + @" > 2 
  7 > " + _8750 + @" 
jf @GYMTREA_4052 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_JOG"" IFP ""GYMNASIUM"" framedelta 100.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
" + _1837 + @" = 0 
" + _1839 + @" = 0 
" + _1838 + @" = 1 

:GYMTREA_4052
if and
  " + _1839 + @" == 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_4170 
if and
  " + _8750 + @" > 6 
  11 > " + _8750 + @" 
jf @GYMTREA_4170 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_SPRINT"" IFP ""GYMNASIUM"" framedelta 100.0 loop 1 lockX 0 lockY 0 lockF 1 time -1 
" + _1837 + @" = 0 
" + _1838 + @" = 0 
" + _1839 + @" = 1 

:GYMTREA_4170
if 
  17@ >= 0.0 
jf @GYMTREA_4222 
if 
  10.0 >= 17@ 
jf @GYMTREA_4222 
15@ = 0.9 

:GYMTREA_4222
if 
  17@ >= 11.0 
jf @GYMTREA_4274 
if 
  20.0 >= 17@ 
jf @GYMTREA_4274 
15@ = 0.97 

:GYMTREA_4274
if 
  17@ >= 21.0 
jf @GYMTREA_4326 
if 
  30.0 >= 17@ 
jf @GYMTREA_4326 
15@ = 1.04 

:GYMTREA_4326
if 
  17@ >= 31.0 
jf @GYMTREA_4378 
if 
  40.0 >= 17@ 
jf @GYMTREA_4378 
15@ = 1.11 

:GYMTREA_4378
if 
  17@ >= 41.0 
jf @GYMTREA_4430 
if 
  50.0 >= 17@ 
jf @GYMTREA_4430 
15@ = 1.18 

:GYMTREA_4430
if 
  17@ >= 51.0 
jf @GYMTREA_4482 
if 
  60.0 >= 17@ 
jf @GYMTREA_4482 
15@ = 1.25 

:GYMTREA_4482
if 
  17@ >= 61.0 
jf @GYMTREA_4534 
if 
  70.0 >= 17@ 
jf @GYMTREA_4534 
15@ = 1.32 

:GYMTREA_4534
if 
  17@ >= 71.0 
jf @GYMTREA_4586 
if 
  80.0 >= 17@ 
jf @GYMTREA_4586 
15@ = 1.39 

:GYMTREA_4586
if 
  17@ >= 81.0 
jf @GYMTREA_4638 
if 
  90.0 >= 17@ 
jf @GYMTREA_4638 
15@ = 1.46 

:GYMTREA_4638
if 
  17@ >= 91.0 
jf @GYMTREA_4690 
if 
  100.0 >= 17@ 
jf @GYMTREA_4690 
15@ = 1.53 

:GYMTREA_4690
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_4876 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_WALK""
jf @GYMTREA_4762 
0393: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_WALK"" at 15@ times_normal_rate 

:GYMTREA_4762
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_JOG""
jf @GYMTREA_4816 
0393: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_JOG"" at 15@ times_normal_rate 

:GYMTREA_4816
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_TREAD_SPRINT""
jf @GYMTREA_4876 
0393: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_SPRINT"" at 15@ times_normal_rate 

:GYMTREA_4876
if 
03CA:   object 0@ exists 
jf @GYMTREA_5001 
if 
03D0:   wav 4 loaded 
jf @GYMTREA_5001 
if 
  17@ > 10.0 
jf @GYMTREA_4968 
if 
  " + _8757 + @" == 0 
jf @GYMTREA_4961 
097B: play_audio_at_object 0@ event 1118 
" + _8757 + @" = 1 

:GYMTREA_4961
jump @GYMTREA_5001 

:GYMTREA_4968
if 
  " + _8757 + @" == 1 
jf @GYMTREA_5001 
097B: play_audio_at_object 0@ event 1119 
" + _8757 + @" = 0 

:GYMTREA_5001
if 
  TIMERB > 250 
jf @GYMTREA_5320 
TIMERB -= 250 
0087: 21@ = 17@ // (float) 
006B: 21@ *= 26@ // (float) 
21@ /= 80.0 
008D: " + _9 + @" = integer " + _8750 + @" to_float 
" + _9 + @" /= 10.0 
" + _9 + @" += 1.0 
006D: " + _9 + @" *= 21@ // (float) 
0059: " + _7 + @" += " + _9 + @" // (float) 
if 
  " + _7 + @" >= 170.0 
jf @GYMTREA_5243 
" + _7 + @" -= 170.0 
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  " + GYM_STAT_Fat + @" >= 1.0 
jf @GYMTREA_5166 
0626: decrease_float_stat 21 by 8.0 

:GYMTREA_5166
if 
  " + _8758 + @" == 3 
jf @GYMTREA_5217 
" + _8758 + @" = 0 
0624: add 4.0 to_float_stat 22 
" + GYM_Day_Limit + @" += 4.0 
jump @GYMTREA_5243 

:GYMTREA_5217
0A1F: increase_float_stat 22 by 4.0 
" + GYM_Day_Limit + @" += 4.0 
" + _8758 + @" += 1 

:GYMTREA_5243
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMTREA_5288 
0835: get_month_day_to " + GYM_Month_Day_When_Limit_Reached + @" get_month_to " + GYM_Month_When_Limit_Reached + @" 
00BC: show_text_highpriority GXT 'GYM1_1B' time 4000 flag 1  // ЏЁ ce™oљ®¬ љoc¦a¦o¤®o Јoџa®њЇaћc¬, Јpњxoљњ џaў¦pa!

:GYMTREA_5288
008F: 25@ = integer " + _8752 + @" to_float 
006D: " + _9 + @" *= 25@ // (float) 
005B: 22@ += 21@ // (float) 
0090: " + _8753 + @" = float 22@ to_integer 

:GYMTREA_5320
if or
00E1:   player 0 pressed_key 15 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMTREA_5796 
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMTREA_5378 
" + GYM_Day_Limit + @" = 0.0 

:GYMTREA_5378
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_5796 
0605: actor " + PlayerActor + @" perform_animation ""GYM_TREAD_GETOFF"" IFP ""GYMNASIUM"" framedelta 100.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMTREA_5443
015B: shake_player_controller 0 time 1 intensity 1 
0623: add " + _8753 + @" to_integer_stat 28 
0085: 29@ = TIMERA // (int) 
29@ /= 1000 
0623: add 29@ to_integer_stat 44 
03E6: remove_text_box 
08DA: remove_panel " + _8748 + @" 
" + _1831 + @" = 0 
" + _1832 + @" = 0 
" + _1833 + @" = 0 
" + _1834 + @" = 0 
" + _1835 + @" = 0 
" + _1836 + @" = 0 
" + _1837 + @" = 0 
" + _1838 + @" = 0 
" + _1839 + @" = 0 
" + _1840 + @" = 0 
19@ = 1.0 
" + _8750 + @" = 1 
" + _8752 + @" = 1 
" + _1830 + @" = 0 
" + _8753 + @" = 0 
22@ = 0.0 
21@ = 0.0 
" + _1829 + @" = 0 
0151: remove_status_text " + _8751 + @" 
0151: remove_status_text " + _8750 + @" 
0151: remove_status_text " + _8753 + @" 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMTREA_5668 
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 

:GYMTREA_5668
04EF: release_animation ""GYMNASIUM"" 
040D: unload_wav 4 
Camera.Restore_WithJumpCut
" + _1840 + @" = 1 
0653: " + _1817 + @" = float_stat 23 
if 
  " + _1817 + @" >= 1000.0 
jf @GYMTREA_5731 
062A: change_float_stat 23 to 1000.0 

:GYMTREA_5731
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  0.0 >= " + GYM_STAT_Fat + @" 
jf @GYMTREA_5768 
062A: change_float_stat 21 to 0.0 

:GYMTREA_5768
if 
00E1:   player 0 pressed_key 15 
jf @GYMTREA_5796 
wait 0 
jump @GYMTREA_5768 

:GYMTREA_5796
" + _8755 + @" += 1 
0084: " + _8756 + @" = " + _8751 + @" // (int) 
" + _8756 + @" -= 100 
if 
  " + _8756 + @" > -40 
jf @GYMTREA_5843 
" + _8756 + @" = -40 

:GYMTREA_5843
if 
002C:   " + _8755 + @" >= " + _8756 + @" // (int) 
jf @GYMTREA_5892 
" + _8755 + @" = 0 
" + _8751 + @" *= 12 
" + _8751 + @" /= 10 
015B: shake_player_controller 0 time 100 intensity " + _8751 + @" 

:GYMTREA_5892
0090: " + _8751 + @" = float 17@ to_integer 

:GYMTREA_5900
jump @GYMTREA_573 
end_thread
" );

            }

        }

        private sealed class GYMDUMB : External {

            public override void START( LabelJump label ) {
                AppendLine( @"" + GYM_Dumbbells_Panel_Selected_Index + @" = 1 
" + _8763 + @" = 0 
" + _8769 + @" = 0 
" + _8779 + @" = 0.0 
27@ = 0 
23@ = 0 
TIMERA = 0 
TIMERB = 0 
if 
  23@ == 1 
jf @GYMDUMB_111 
0@ = Object.Init(#BEACHTOWEL04, 0.0, 0.0, 0.0)

:GYMDUMB_111
if 
03CA:   object 0@ exists 
jf @GYMDUMB_149 
Object.StorePos(0@, 4@, 5@, 6@)
12@ = Object.Angle(0@)

:GYMDUMB_149
0087: 2@ = 4@ // (float) 
0087: 3@ = 5@ // (float) 
0088: " + _8775 + @" = 4@ // (float) 
0088: " + _8776 + @" = 5@ // (float) 
0087: 9@ = 6@ // (float) 
9@ += 1.7 
0087: 13@ = 12@ // (float) 
0087: 1@ = 12@ // (float) 
1@ -= 90.0 
0088: " + _8773 + @" = 12@ // (float) 
" + _8773 + @" -= 90.0 
0088: " + _8774 + @" = 12@ // (float) 
" + _8774 + @" += 90.0 
02F6: 10@ = sine 13@ // (float) 
02F7: 11@ = cosine 13@ // (float) 
10@ *= 0.95 
11@ *= 0.95 
0063: 4@ -= 11@ // (float) 
0063: 5@ -= 10@ // (float) 
10@ *= 3.5 
11@ *= 3.5 
0087: 7@ = 4@ // (float) 
005B: 7@ += 11@ // (float) 
0087: 8@ = 5@ // (float) 
005B: 8@ += 10@ // (float) 
02F6: 10@ = sine 13@ // (float) 
02F7: 11@ = cosine 13@ // (float) 
10@ *= 0.95 
11@ *= 0.95 
005F: " + _8775 + @" += 11@ // (float) 
005F: " + _8776 + @" += 10@ // (float) 
10@ *= 3.5 
11@ *= 3.5 
0086: " + _8777 + @" = " + _8775 + @" // (float) 
0067: " + _8777 + @" -= 11@ // (float) 
0086: " + _8778 + @" = " + _8776 + @" // (float) 
0067: " + _8778 + @" -= 10@ // (float) 
12@ += 180.0 
0087: 13@ = 12@ // (float) 
13@ += 90.0 
02F6: 10@ = sine 13@ // (float) 
02F7: 11@ = cosine 13@ // (float) 
10@ *= 0.2 
11@ *= 0.2 
005B: 2@ += 11@ // (float) 
005B: 3@ += 10@ // (float) 
25@ = Object.Create(#KMB_DUMBBELL_R, 2@, 3@, 6@)
069A: attach_object 25@ to_object 0@ with_offset 0.05 0.2 0.3 rotation 0.0 90.0 90.0 
26@ = Object.Create(#KMB_DUMBBELL_L, 2@, 3@, 6@)
069A: attach_object 26@ to_object 0@ with_offset 0.05 -0.2 0.3 rotation 0.0 90.0 90.0 
6@ += 0.1 
" + GYM_GymBike_Level + @" = 1 
" + _1829 + @" = 0 

:GYMDUMB_683
wait 0 
if 
83CA:   not object 0@ exists 
jf @GYMDUMB_715 
Object.Destroy(25@)
Object.Destroy(26@)
end_thread 

:GYMDUMB_715
if 
8977:   not player_in_radius_of_object 0@ external_script_trigger 
jf @GYMDUMB_743 
Object.Destroy(25@)
Object.Destroy(26@)
end_thread 

:GYMDUMB_743
if 
   Player.Defined(" + PlayerChar + @")
jf @GYMDUMB_7917 
if 
  " + _1830 + @" == 0 
jf @GYMDUMB_1253 
if and
  17@ == 0 
8A0C:   not player " + PlayerChar + @" on_jetpack 
jf @GYMDUMB_1253 
if 
  21@ == 0 
jf @GYMDUMB_1189 
if or
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 4@ 5@ 6@ radius 1.2 1.2 4.0 on_foot 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _8775 + @" " + _8776 + @" 6@ radius 1.2 1.2 4.0 on_foot 
jf @GYMDUMB_1155 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 4@ 5@ 6@ radius 1.2 1.2 4.0 on_foot 
jf @GYMDUMB_947 
" + _8772 + @" = 0 
jump @GYMDUMB_954 

:GYMDUMB_947
" + _8772 + @" = 1 

:GYMDUMB_954
if 
  27@ == 0 
jf @GYMDUMB_990 
0512: show_permanent_text_box 'GYM1_85'  // ~k~~VEHICLE_ENTER_EXIT~ - њcЈoћ©џoўa¦©.
27@ = 1 

:GYMDUMB_990
if 
00E1:   player 0 pressed_key 15 
jf @GYMDUMB_1148 
if or
  " + OnMission + @" == 0 
  " + ONMISSION_GYMFIGHT + @" == 1 
jf @GYMDUMB_1132 
0835: get_month_day_to " + Current_Month_Day + @" get_month_to " + Current_Month + @" 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" // (int) 
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit_Reached + @" // (int) 
jf @GYMDUMB_1109 
17@ = 1 
" + _1830 + @" = 1 
0619: enable_actor " + PlayerActor + @" collision_detection 0 
Player.CanMove(" + PlayerChar + @") = False
" + _8714 + @" = 0 
jump @GYMDUMB_1125 

:GYMDUMB_1109
00BC: show_text_highpriority GXT 'GYM1_1A' time 4000 flag 1  // ЏЁ љoc¦a¦o¤®o Јopa—o¦aћ ®aљ co—oќ ce™oљ®¬, Јpњxoљњ џaў¦pa!

:GYMDUMB_1125
jump @GYMDUMB_1148 

:GYMDUMB_1132
00BC: show_text_highpriority GXT 'GYM1_90' time 4000 flag 1  // ~s~Џe—e ceќ¤ac ®e љo Є¦o™o, Јo¤eЇy —Ё ¦e—e ®e Јpњќ¦њ Јoџ›e?

:GYMDUMB_1148
jump @GYMDUMB_1182 

:GYMDUMB_1155
if 
  27@ == 1 
jf @GYMDUMB_1182 
03E6: remove_text_box 
27@ = 0 

:GYMDUMB_1182
jump @GYMDUMB_1253 

:GYMDUMB_1189
if or
80ED:   not actor " + PlayerActor + @" sphere 0 near_point 4@ 5@ radius 2.0 2.0 on_foot 
80ED:   not actor " + PlayerActor + @" sphere 0 near_point " + _8775 + @" " + _8776 + @" radius 2.0 2.0 on_foot 
jf @GYMDUMB_1253 
21@ = 0 

:GYMDUMB_1253
if 
  17@ == 1 
jf @GYMDUMB_7917 
if and
  " + _1830 + @" == 1 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_1459 
0619: enable_actor " + PlayerActor + @" collision_detection 0 
if 
  " + _8772 + @" == 0 
jf @GYMDUMB_1381 
Player.CanMove(" + PlayerChar + @") = False
08C7: put_actor " + PlayerActor + @" at 4@ 5@ 6@ dont_warp_gang 
Camera.SetPosition(7@, 8@, 9@, 0.0, 0.0, 0.0)
Actor.Angle(" + PlayerActor + @") = " + _8773 + @"
jump @GYMDUMB_1436 

:GYMDUMB_1381
Player.CanMove(" + PlayerChar + @") = False
08C7: put_actor " + PlayerActor + @" at " + _8775 + @" " + _8776 + @" 6@ dont_warp_gang 
Camera.SetPosition(" + _8777 + @", " + _8778 + @", 9@, 0.0, 0.0, 0.0)
Actor.Angle(" + PlayerActor + @") = " + _8774 + @"

:GYMDUMB_1436
Camera.OnPed(" + PlayerActor + @", 15, 2)
" + _1830 + @" = 2 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 

:GYMDUMB_1459
if 
  " + _1829 + @" == 0 
jf @GYMDUMB_1584 
04ED: load_animation ""FREEWEIGHTS"" 
054C: use_GXT_table 'GYM' 

:GYMDUMB_1503
if 
84EE:   not animation ""FREEWEIGHTS"" loaded 
jf @GYMDUMB_1540 
wait 0 
jump @GYMDUMB_1503 

:GYMDUMB_1540
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMDUMB_1551
if 
83D0:   not wav 4 loaded 
jf @GYMDUMB_1577 
wait 0 
jump @GYMDUMB_1551 

:GYMDUMB_1577
" + _1829 + @" = 1 

:GYMDUMB_1584
if and
  " + _1830 + @" == 2 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2111 
0512: show_permanent_text_box 'GYM1_71'  // ~k~~GO_FORWARD~ њ ~k~~GO_BACK~ - ўЁ—pa¦© ®a™pyџky.~N~~k~~PED_SPRINT~ - ўЁ—op.~N~~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
if or
  " + Current_Language + @" == 4 
  " + Current_Language + @" == 2 
jf @GYMDUMB_1811 
08D4: " + GYM_Dumbbells_Panel + @" = create_panel_with_title 'GYM1_G' position 31.0 180.0 width 184.0 columns 1 interactive 1 background 1 alignment 0  // ‚a®¦eћњ
08DB: set_panel " + GYM_Dumbbells_Panel + @" column 0 header 'GYM1_72' data 'GYM1_26' 'GYM1_27' 'GYM1_28' 'GYM1_29' 'GYM1_30' 'GYM1_31' 'GYM1_32' 'GYM1_33' 'GYM1_34' 'GYM1_35' 'DUMMY' 'DUMMY'  // ­a™pyџka // 10 k™ // 15 k™ // 20 k™ // 25 k™ // 30 k™ // 35 k™ // 40 k™ // 45 k™ // 50 k™ // 55 k™
jump @GYMDUMB_1972 

:GYMDUMB_1811
08D4: " + GYM_Dumbbells_Panel + @" = create_panel_with_title 'GYM1_G' position 31.0 150.0 width 184.0 columns 1 interactive 1 background 1 alignment 0  // ‚a®¦eћњ
08DB: set_panel " + GYM_Dumbbells_Panel + @" column 0 header 'GYM1_72' data 'GYM1_26' 'GYM1_27' 'GYM1_28' 'GYM1_29' 'GYM1_30' 'GYM1_31' 'GYM1_32' 'GYM1_33' 'GYM1_34' 'GYM1_35' 'DUMMY' 'DUMMY'  // ­a™pyџka // 10 k™ // 15 k™ // 20 k™ // 25 k™ // 30 k™ // 35 k™ // 40 k™ // 45 k™ // 50 k™ // 55 k™

:GYMDUMB_1972
090E: set_panel " + GYM_Dumbbells_Panel + @" active_row 0 

:GYMDUMB_1979
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2090 
wait 0 
" + _8714 + @" += 1 
if and
00E1:   player 0 pressed_key 15 
  " + _8714 + @" > 20 
jf @GYMDUMB_2044 
03E6: remove_text_box 
08DA: remove_panel " + GYM_Dumbbells_Panel + @" 
jump @GYMDUMB_7441 

:GYMDUMB_2044
if 
00E1:   player 0 pressed_key 16 
jf @GYMDUMB_2083 
03E6: remove_text_box 
08D7: " + GYM_Dumbbells_Panel_Selected_Index + @" = panel " + GYM_Dumbbells_Panel + @" active_row 
08DA: remove_panel " + GYM_Dumbbells_Panel + @" 
jump @GYMDUMB_2090 

:GYMDUMB_2083
jump @GYMDUMB_1979 

:GYMDUMB_2090
19@ = 1 
18@ = 1 
" + _1830 + @" = 3 

:GYMDUMB_2111
if and
  " + _1830 + @" == 3 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2868 
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 0 
jf @GYMDUMB_2172 
" + _8762 + @" = 1.0 
" + _8768 + @" = 5.0 

:GYMDUMB_2172
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 1 
jf @GYMDUMB_2210 
" + _8762 + @" = 2.0 
" + _8768 + @" = 5.2 

:GYMDUMB_2210
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 2 
jf @GYMDUMB_2248 
" + _8762 + @" = 3.0 
" + _8768 + @" = 5.3 

:GYMDUMB_2248
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 3 
jf @GYMDUMB_2286 
" + _8762 + @" = 4.0 
" + _8768 + @" = 5.5 

:GYMDUMB_2286
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 4 
jf @GYMDUMB_2324 
" + _8762 + @" = 5.0 
" + _8768 + @" = 6.0 

:GYMDUMB_2324
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 5 
jf @GYMDUMB_2362 
" + _8762 + @" = 6.0 
" + _8768 + @" = 6.5 

:GYMDUMB_2362
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 6 
jf @GYMDUMB_2400 
" + _8762 + @" = 7.0 
" + _8768 + @" = 7.0 

:GYMDUMB_2400
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 7 
jf @GYMDUMB_2438 
" + _8762 + @" = 8.0 
" + _8768 + @" = 7.5 

:GYMDUMB_2438
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 8 
jf @GYMDUMB_2476 
" + _8762 + @" = 9.0 
" + _8768 + @" = 8.0 

:GYMDUMB_2476
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 9 
jf @GYMDUMB_2514 
" + _8762 + @" = 10.0 
" + _8768 + @" = 8.5 

:GYMDUMB_2514
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2580 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_PICKUP"" IFP ""FREEWEIGHTS"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_2580
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2868 
if and
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_PICKUP""
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2868 
0613: " + _1826 + @" = actor " + PlayerActor + @" animation ""GYM_FREE_PICKUP"" time 

:GYMDUMB_2663
if 
   not " + _1826 + @" > 0.7789 
jf @GYMDUMB_2736 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2729 
0613: " + _1826 + @" = actor " + PlayerActor + @" animation ""GYM_FREE_PICKUP"" time 

:GYMDUMB_2729
jump @GYMDUMB_2663 

:GYMDUMB_2736
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2854 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_2854 
070A: AS_actor " + PlayerActor + @" attach_to_object 25@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time -1 
09A0: actor " + PlayerActor + @" attach_object 26@ with_offset 0.0 0.0 0.0 on_bone 5 16 perform_animation ""NULL"" IFP_file ""NULL"" time -1 

:GYMDUMB_2854
" + _1830 + @" = 4 
TIMERA = 0 

:GYMDUMB_2868
if and
  " + _1830 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_3404 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_PICKUP""
jf @GYMDUMB_3404 
0613: " + _1816 + @" = actor " + PlayerActor + @" animation ""GYM_FREE_PICKUP"" time 
if 
  " + _1816 + @" == 1.0 
jf @GYMDUMB_3404 
if 
  " + _8761 + @" == 0 
jf @GYMDUMB_3006 
0512: show_permanent_text_box 'GYM1_36'  // Ќ¦o—Ё Јoљ®њЇa¦© ™a®¦eћњ, Јoo¤epeљ®o ®a›њЇaќ ~k~~PED_SPRINT~ њ ~k~~PED_FIREWEAPON~.~n~ЌeЇ —Ёc¦pee ¦Ё —yљeҐ© њx ®a›њЇa¦©, ¦eЇ ckopee —yљe¦ џaЈoћ®¬¦©c¬ Ґkaћa Є®ep™њњ.
" + _8761 + @" = 1 

:GYMDUMB_3006
0653: " + _1817 + @" = float_stat 23 
" + _1817 + @" /= 30.0 
if 
  0.0 > " + _1817 + @" 
jf @GYMDUMB_3054 
" + _1817 + @" = 0.0 

:GYMDUMB_3054
0086: " + _8765 + @" = " + _1817 + @" // (float) 
" + _8765 + @" += 30.0 
if 
  " + _8765 + @" > 75.0 
jf @GYMDUMB_3103 
" + _8765 + @" = 75.0 

:GYMDUMB_3103
008D: " + _8767 + @" = integer " + _8763 + @" to_float 
0086: " + _1823 + @" = " + _8765 + @" // (float) 
0061: " + _1823 + @" -= " + _8762 + @" // (float) 
if 
  18.0 >= " + _1823 + @" 
jf @GYMDUMB_3193 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_B"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_3193
if 
  " + _1823 + @" > 18.0 
jf @GYMDUMB_3280 
if 
  24.0 >= " + _1823 + @" 
jf @GYMDUMB_3280 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_A"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_3280
if 
  " + _1823 + @" > 24.0 
jf @GYMDUMB_3354 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_UP_SMOOTH"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_3354
04F7: status_text " + _1818 + @" type 1 line 1 GXT 'GYM1_1' // global_variable  // Є®ep™њ¬
04F7: status_text " + _8763 + @" type 0 line 2 GXT 'GYM1_2' // global_variable  // Јoљ§eЇoў
" + _1813 + @" = 1 
" + _1830 + @" = 5 

:GYMDUMB_3404
if and
  " + _1830 + @" == 5 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_7053 
if and
  TIMERA > 4000 
  " + _8761 + @" == 1 
jf @GYMDUMB_3473 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_25'  // ~k~~VEHICLE_ENTER_EXIT~ - ўЁxoљ.
" + _8761 + @" = 2 

:GYMDUMB_3473
if and
  TIMERA > 8000 
  " + _8761 + @" == 2 
jf @GYMDUMB_3508 
03E6: remove_text_box 
" + _8761 + @" = 101 

:GYMDUMB_3508
0653: " + _1817 + @" = float_stat 23 
" + _1817 + @" /= 30.0 
if 
  0.0 > " + _1817 + @" 
jf @GYMDUMB_3556 
" + _1817 + @" = 0.0 

:GYMDUMB_3556
0086: " + _8765 + @" = " + _1817 + @" // (float) 
" + _8765 + @" += 20.0 
if 
  " + _8765 + @" > 75.0 
jf @GYMDUMB_3605 
" + _8765 + @" = 75.0 

:GYMDUMB_3605
if or
  " + _1813 + @" == 1 
  " + _1813 + @" == 3 
jf @GYMDUMB_3658 
" + _8762 + @" /= 2.0 
0080: " + _8766 + @" -= frame_delta_time * " + _8762 + @" // (float) 
" + _8762 + @" *= 2.0 

:GYMDUMB_3658
if 
  " + _1813 + @" == 4 
jf @GYMDUMB_3686 
007E: " + _8766 + @" -= frame_delta_time * 2.0 // (float) 

:GYMDUMB_3686
if 
80E1:   not player 0 pressed_key 17 
jf @GYMDUMB_3728 
if 
  20@ == 3 
jf @GYMDUMB_3728 
20@ = 0 

:GYMDUMB_3728
if 
80E1:   not player 0 pressed_key 16 
jf @GYMDUMB_3770 
if 
  20@ == 1 
jf @GYMDUMB_3770 
20@ = 2 

:GYMDUMB_3770
if or
  " + _1813 + @" == 1 
  " + _1813 + @" == 3 
jf @GYMDUMB_3907 
if and
00E1:   player 0 pressed_key 16 
80E1:   not player 0 pressed_key 17 
jf @GYMDUMB_3851 
if 
  20@ == 0 
jf @GYMDUMB_3851 
0059: " + _8766 + @" += " + _8765 + @" // (float) 
20@ = 1 

:GYMDUMB_3851
if and
00E1:   player 0 pressed_key 17 
80E1:   not player 0 pressed_key 16 
jf @GYMDUMB_3907 
if 
  20@ == 2 
jf @GYMDUMB_3907 
0059: " + _8766 + @" += " + _8765 + @" // (float) 
20@ = 3 

:GYMDUMB_3907
if 
  0.0 > " + _8766 + @" 
jf @GYMDUMB_3938 
" + _8766 + @" = 0.0 

:GYMDUMB_3938
if 
  " + _8766 + @" >= 100.0 
jf @GYMDUMB_3994 
" + _8766 + @" = 100.0 
if 
  " + _1813 + @" == 1 
jf @GYMDUMB_3994 
" + _1813 + @" = 2 

:GYMDUMB_3994
if 
  " + _8766 + @" > 25.0 
jf @GYMDUMB_4026 
0947: actor " + PlayerActor + @" speak_from_audio_table 354 store_spoken_phrase_id_to " + _8780 + @" 

:GYMDUMB_4026
if 
  " + _1813 + @" == 2 
jf @GYMDUMB_4086 
if 
  " + _1819 + @" == 1.0 
jf @GYMDUMB_4086 
20@ = 0 
" + _1813 + @" = 3 
TIMERB = 0 

:GYMDUMB_4086
if and
  " + _1813 + @" == 3 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_6177 
if 
   not " + _8763 + @" >= 999999 
jf @GYMDUMB_4137 
" + _8763 + @" += 1 

:GYMDUMB_4137
0871: init_jump_table " + GYM_Dumbbells_Panel_Selected_Index + @" total_jumps 10 default_jump 0 @GYMDUMB_4405 jumps 0 @GYMDUMB_4265 1 @GYMDUMB_4279 2 @GYMDUMB_4293 3 @GYMDUMB_4307 4 @GYMDUMB_4321 5 @GYMDUMB_4335 6 @GYMDUMB_4349 
0872: jump_table_jumps 7 @GYMDUMB_4363 8 @GYMDUMB_4377 9 @GYMDUMB_4391 -1 @GYMDUMB_4405 -1 @GYMDUMB_4405 -1 @GYMDUMB_4405 -1 @GYMDUMB_4405 -1 @GYMDUMB_4405 -1 @GYMDUMB_4405 

:GYMDUMB_4265
" + GYM_Dumbbells_Weight + @" = 20 
jump @GYMDUMB_4405 

:GYMDUMB_4279
" + GYM_Dumbbells_Weight + @" = 30 
jump @GYMDUMB_4405 

:GYMDUMB_4293
" + GYM_Dumbbells_Weight + @" = 40 
jump @GYMDUMB_4405 

:GYMDUMB_4307
" + GYM_Dumbbells_Weight + @" = 50 
jump @GYMDUMB_4405 

:GYMDUMB_4321
" + GYM_Dumbbells_Weight + @" = 60 
jump @GYMDUMB_4405 

:GYMDUMB_4335
" + GYM_Dumbbells_Weight + @" = 70 
jump @GYMDUMB_4405 

:GYMDUMB_4349
" + GYM_Dumbbells_Weight + @" = 80 
jump @GYMDUMB_4405 

:GYMDUMB_4363
" + GYM_Dumbbells_Weight + @" = 90 
jump @GYMDUMB_4405 

:GYMDUMB_4377
" + GYM_Dumbbells_Weight + @" = 100 
jump @GYMDUMB_4405 

:GYMDUMB_4391
" + GYM_Dumbbells_Weight + @" = 110 
jump @GYMDUMB_4405 

:GYMDUMB_4405
0652: " + GYM_STAT_Dumbbells_Heaviest_Weight + @" = integer_stat 47 
if 
001C:   " + GYM_Dumbbells_Weight + @" > " + GYM_STAT_Dumbbells_Heaviest_Weight + @" // (int) 
jf @GYMDUMB_4438 
0629: change_integer_stat 47 to " + GYM_Dumbbells_Weight + @" 

:GYMDUMB_4438
0653: " + _8779 + @" = float_stat 23 
if 
  1000.0 > " + _8779 + @" 
jf @GYMDUMB_4746 
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 1 
jf @GYMDUMB_4494 
" + _8768 + @" = 1.0 

:GYMDUMB_4494
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 2 
jf @GYMDUMB_4522 
" + _8768 + @" = 1.2 

:GYMDUMB_4522
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 3 
jf @GYMDUMB_4550 
" + _8768 + @" = 1.3 

:GYMDUMB_4550
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 4 
jf @GYMDUMB_4578 
" + _8768 + @" = 1.5 

:GYMDUMB_4578
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 5 
jf @GYMDUMB_4606 
" + _8768 + @" = 2.0 

:GYMDUMB_4606
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 6 
jf @GYMDUMB_4634 
" + _8768 + @" = 2.5 

:GYMDUMB_4634
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 7 
jf @GYMDUMB_4662 
" + _8768 + @" = 3.0 

:GYMDUMB_4662
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 8 
jf @GYMDUMB_4690 
" + _8768 + @" = 4.0 

:GYMDUMB_4690
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 9 
jf @GYMDUMB_4718 
" + _8768 + @" = 5.0 

:GYMDUMB_4718
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 10 
jf @GYMDUMB_4746 
" + _8768 + @" = 6.0 

:GYMDUMB_4746
if 
  800.0 > " + _8779 + @" 
jf @GYMDUMB_5047 
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 1 
jf @GYMDUMB_4795 
" + _8768 + @" = 2.0 

:GYMDUMB_4795
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 2 
jf @GYMDUMB_4823 
" + _8768 + @" = 2.2 

:GYMDUMB_4823
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 3 
jf @GYMDUMB_4851 
" + _8768 + @" = 2.3 

:GYMDUMB_4851
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 4 
jf @GYMDUMB_4879 
" + _8768 + @" = 2.5 

:GYMDUMB_4879
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 5 
jf @GYMDUMB_4907 
" + _8768 + @" = 3.0 

:GYMDUMB_4907
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 6 
jf @GYMDUMB_4935 
" + _8768 + @" = 3.5 

:GYMDUMB_4935
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 7 
jf @GYMDUMB_4963 
" + _8768 + @" = 4.0 

:GYMDUMB_4963
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 8 
jf @GYMDUMB_4991 
" + _8768 + @" = 5.0 

:GYMDUMB_4991
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 9 
jf @GYMDUMB_5019 
" + _8768 + @" = 6.0 

:GYMDUMB_5019
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 10 
jf @GYMDUMB_5047 
" + _8768 + @" = 7.0 

:GYMDUMB_5047
if 
  600.0 > " + _8779 + @" 
jf @GYMDUMB_5348 
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 1 
jf @GYMDUMB_5096 
" + _8768 + @" = 3.0 

:GYMDUMB_5096
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 2 
jf @GYMDUMB_5124 
" + _8768 + @" = 3.2 

:GYMDUMB_5124
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 3 
jf @GYMDUMB_5152 
" + _8768 + @" = 3.3 

:GYMDUMB_5152
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 4 
jf @GYMDUMB_5180 
" + _8768 + @" = 3.5 

:GYMDUMB_5180
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 5 
jf @GYMDUMB_5208 
" + _8768 + @" = 4.0 

:GYMDUMB_5208
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 6 
jf @GYMDUMB_5236 
" + _8768 + @" = 4.5 

:GYMDUMB_5236
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 7 
jf @GYMDUMB_5264 
" + _8768 + @" = 5.0 

:GYMDUMB_5264
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 8 
jf @GYMDUMB_5292 
" + _8768 + @" = 6.0 

:GYMDUMB_5292
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 9 
jf @GYMDUMB_5320 
" + _8768 + @" = 7.0 

:GYMDUMB_5320
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 10 
jf @GYMDUMB_5348 
" + _8768 + @" = 8.0 

:GYMDUMB_5348
if 
  400.0 > " + _8779 + @" 
jf @GYMDUMB_5649 
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 1 
jf @GYMDUMB_5397 
" + _8768 + @" = 4.0 

:GYMDUMB_5397
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 2 
jf @GYMDUMB_5425 
" + _8768 + @" = 4.2 

:GYMDUMB_5425
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 3 
jf @GYMDUMB_5453 
" + _8768 + @" = 4.3 

:GYMDUMB_5453
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 4 
jf @GYMDUMB_5481 
" + _8768 + @" = 4.5 

:GYMDUMB_5481
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 5 
jf @GYMDUMB_5509 
" + _8768 + @" = 5.0 

:GYMDUMB_5509
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 6 
jf @GYMDUMB_5537 
" + _8768 + @" = 5.5 

:GYMDUMB_5537
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 7 
jf @GYMDUMB_5565 
" + _8768 + @" = 6.0 

:GYMDUMB_5565
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 8 
jf @GYMDUMB_5593 
" + _8768 + @" = 7.0 

:GYMDUMB_5593
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 9 
jf @GYMDUMB_5621 
" + _8768 + @" = 8.0 

:GYMDUMB_5621
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 10 
jf @GYMDUMB_5649 
" + _8768 + @" = 9.0 

:GYMDUMB_5649
if 
  200.0 > " + _8779 + @" 
jf @GYMDUMB_5950 
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 1 
jf @GYMDUMB_5698 
" + _8768 + @" = 5.0 

:GYMDUMB_5698
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 2 
jf @GYMDUMB_5726 
" + _8768 + @" = 5.2 

:GYMDUMB_5726
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 3 
jf @GYMDUMB_5754 
" + _8768 + @" = 5.3 

:GYMDUMB_5754
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 4 
jf @GYMDUMB_5782 
" + _8768 + @" = 5.5 

:GYMDUMB_5782
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 5 
jf @GYMDUMB_5810 
" + _8768 + @" = 6.0 

:GYMDUMB_5810
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 6 
jf @GYMDUMB_5838 
" + _8768 + @" = 6.5 

:GYMDUMB_5838
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 7 
jf @GYMDUMB_5866 
" + _8768 + @" = 7.0 

:GYMDUMB_5866
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 8 
jf @GYMDUMB_5894 
" + _8768 + @" = 7.5 

:GYMDUMB_5894
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 9 
jf @GYMDUMB_5922 
" + _8768 + @" = 8.0 

:GYMDUMB_5922
if 
  " + GYM_Dumbbells_Panel_Selected_Index + @" == 10 
jf @GYMDUMB_5950 
" + _8768 + @" = 8.5 

:GYMDUMB_5950
if 
  " + _8781 + @" == 8 
jf @GYMDUMB_5997 
" + _8781 + @" = 0 
0624: add " + _8768 + @" to_float_stat 23 
0059: " + GYM_Day_Limit + @" += " + _8768 + @" // (float) 
jump @GYMDUMB_6019 

:GYMDUMB_5997
0A1F: increase_float_stat 23 by " + _8768 + @" 
" + _8781 + @" += 1 
0059: " + GYM_Day_Limit + @" += " + _8768 + @" // (float) 

:GYMDUMB_6019
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMDUMB_6064 
0835: get_month_day_to " + GYM_Month_Day_When_Limit_Reached + @" get_month_to " + GYM_Month_When_Limit_Reached + @" 
00BC: show_text_highpriority GXT 'GYM1_1B' time 4000 flag 1  // ЏЁ ce™oљ®¬ љoc¦a¦o¤®o Јoџa®њЇaћc¬, Јpњxoљњ џaў¦pa!

:GYMDUMB_6064
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  " + GYM_STAT_Fat + @" >= 1.0 
jf @GYMDUMB_6101 
0626: decrease_float_stat 21 by 1.0 

:GYMDUMB_6101
015B: shake_player_controller 0 time 200 intensity 200 
0947: actor " + PlayerActor + @" speak_from_audio_table 355 store_spoken_phrase_id_to " + _8780 + @" 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_DOWN"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 
" + _1813 + @" = 4 

:GYMDUMB_6177
if and
  " + _1813 + @" == 4 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_6500 
if 
  " + _8766 + @" == 0.0 
jf @GYMDUMB_6500 
if 
  " + _1819 + @" == 0.0 
jf @GYMDUMB_6500 
008D: " + _8767 + @" = integer " + _8763 + @" to_float 
0086: " + _1823 + @" = " + _8765 + @" // (float) 
0061: " + _1823 + @" -= " + _8762 + @" // (float) 
if 
  18.0 >= " + _1823 + @" 
jf @GYMDUMB_6332 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_B"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_6332
if 
  " + _1823 + @" > 18.0 
jf @GYMDUMB_6419 
if 
  24.0 >= " + _1823 + @" 
jf @GYMDUMB_6419 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_A"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_6419
if 
  " + _1823 + @" > 24.0 
jf @GYMDUMB_6493 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_UP_SMOOTH"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMDUMB_6493
" + _1813 + @" = 1 

:GYMDUMB_6500
0086: " + _1820 + @" = " + _8766 + @" // (float) 
" + _1820 + @" /= 100.0 
if and
  " + _1813 + @" > 0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_6878 
0086: " + _1821 + @" = " + _1820 + @" // (float) 
0061: " + _1821 + @" -= " + _1819 + @" // (float) 
" + _1821 + @" /= 2.0 
if and
  0.05 > " + _1821 + @" 
  " + _1821 + @" > -0.05 
jf @GYMDUMB_6613 
0086: " + _1819 + @" = " + _1820 + @" // (float) 
jump @GYMDUMB_6621 

:GYMDUMB_6613
0059: " + _1819 + @" += " + _1821 + @" // (float) 

:GYMDUMB_6621
if 
  " + _1813 + @" == 4 
jf @GYMDUMB_6718 
" + _1822 + @" = 1.0 
0061: " + _1822 + @" -= " + _1819 + @" // (float) 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_DOWN""
jf @GYMDUMB_6711 
0614: set_actor " + PlayerActor + @" animation ""GYM_FREE_DOWN"" progress_to " + _1822 + @" // 0.0 to 1.0 

:GYMDUMB_6711
jump @GYMDUMB_6878 

:GYMDUMB_6718
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_A""
jf @GYMDUMB_6766 
0614: set_actor " + PlayerActor + @" animation ""GYM_FREE_A"" progress_to " + _1819 + @" // 0.0 to 1.0 

:GYMDUMB_6766
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_B""
jf @GYMDUMB_6814 
0614: set_actor " + PlayerActor + @" animation ""GYM_FREE_B"" progress_to " + _1819 + @" // 0.0 to 1.0 

:GYMDUMB_6814
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_UP_SMOOTH""
jf @GYMDUMB_6878 
0614: set_actor " + PlayerActor + @" animation ""GYM_FREE_UP_SMOOTH"" progress_to " + _1819 + @" // 0.0 to 1.0 

:GYMDUMB_6878
008C: " + _1818 + @" = float " + _8766 + @" to_integer 
if or
00E1:   player 0 pressed_key 15 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMDUMB_7053 
" + _1818 + @" = 0 

:GYMDUMB_6920
if 
00E1:   player 0 pressed_key 16 
jf @GYMDUMB_6948 
wait 0 
jump @GYMDUMB_6920 

:GYMDUMB_6948
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_7015 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_PUTDOWN"" IFP ""FREEWEIGHTS"" framedelta 100.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMDUMB_7015
if 
  " + GYM_Day_Limit + @" > 200.0 
jf @GYMDUMB_7046 
" + GYM_Day_Limit + @" = 0.0 

:GYMDUMB_7046
" + _1830 + @" = 6 

:GYMDUMB_7053
if and
  " + _1830 + @" == 6 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_7917 
if 
  " + _8763 + @" >= 0 
jf @GYMDUMB_7700 
if 
   Actor.Animation(" + PlayerActor + @") == ""GYM_FREE_PUTDOWN""
jf @GYMDUMB_7693 
0613: " + _1827 + @" = actor " + PlayerActor + @" animation ""GYM_FREE_PUTDOWN"" time 

:GYMDUMB_7154
if 
   not " + _1827 + @" > 0.3 
jf @GYMDUMB_7228 
wait 0 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_7221 
0613: " + _1827 + @" = actor " + PlayerActor + @" animation ""GYM_FREE_PUTDOWN"" time 

:GYMDUMB_7221
jump @GYMDUMB_7154 

:GYMDUMB_7228
070B: set_actor " + PlayerActor + @" onbone_attached_object_operation 0 
09A1: set_actor " + PlayerActor + @" onbone_attached_objectB_operation 0 
069A: attach_object 25@ to_object 0@ with_offset 0.0 0.2 0.3 rotation 0.0 90.0 90.0 
069A: attach_object 26@ to_object 0@ with_offset 0.0 -0.2 0.3 rotation 0.0 90.0 90.0 
0613: " + _1816 + @" = actor " + PlayerActor + @" animation ""GYM_FREE_PUTDOWN"" time 
if and
  " + _1816 + @" == 1.0 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_7693 
if 
  " + _8763 + @" > 4 
jf @GYMDUMB_7441 
0605: actor " + PlayerActor + @" perform_animation ""GYM_FREE_CELEBRATE"" IFP ""FREEWEIGHTS"" framedelta 8.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 

:GYMDUMB_7441
17@ = 0 
" + _1813 + @" = 0 
21@ = 1 
" + GYM_Dumbbells_Panel_Selected_Index + @" = 1 
" + _8763 + @" = 0 
" + _1818 + @" = 0 
" + _1823 + @" = 0.0 
" + _1830 + @" = 0 
" + _8766 + @" = 0.0 
" + GYM_Dumbbells_Panel_Selected_Index + @" = 1 
" + _8763 + @" = 0 
" + _1816 + @" = 0.0 
" + _1826 + @" = 0.0 
0653: " + _1817 + @" = float_stat 23 
if 
  " + _1817 + @" >= 1000.0 
jf @GYMDUMB_7581 
062A: change_float_stat 23 to 1000.0 

:GYMDUMB_7581
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  0.0 >= " + GYM_STAT_Fat + @" 
jf @GYMDUMB_7618 
062A: change_float_stat 21 to 0.0 

:GYMDUMB_7618
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMDUMB_7660 
0151: remove_status_text " + _8763 + @" 
0151: remove_status_text " + _1818 + @" 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 

:GYMDUMB_7660
04EF: release_animation ""FREEWEIGHTS"" 
040D: unload_wav 4 
08DA: remove_panel " + GYM_Dumbbells_Panel + @" 
03E6: remove_text_box 
" + _1829 + @" = 0 

:GYMDUMB_7693
jump @GYMDUMB_7917 

:GYMDUMB_7700
17@ = 0 
" + _1813 + @" = 0 
21@ = 1 
" + GYM_Dumbbells_Panel_Selected_Index + @" = 1 
" + _8763 + @" = 0 
" + _1818 + @" = 0 
" + _1823 + @" = 0.0 
" + _1830 + @" = 0 
" + _8766 + @" = 0.0 
" + GYM_Dumbbells_Panel_Selected_Index + @" = 1 
" + _8763 + @" = 0 
" + _1816 + @" = 0.0 
" + _1826 + @" = 0.0 
0653: " + _1817 + @" = float_stat 23 
if 
  " + _1817 + @" >= 1000.0 
jf @GYMDUMB_7840 
062A: change_float_stat 23 to 1000.0 

:GYMDUMB_7840
0653: " + GYM_STAT_Fat + @" = float_stat 21 
if 
  0.0 >= " + GYM_STAT_Fat + @" 
jf @GYMDUMB_7877 
062A: change_float_stat 21 to 0.0 

:GYMDUMB_7877
0151: remove_status_text " + _8763 + @" 
0151: remove_status_text " + _1818 + @" 
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
0619: enable_actor " + PlayerActor + @" collision_detection 1 
08DA: remove_panel " + GYM_Dumbbells_Panel + @" 
03E6: remove_text_box 
" + _1829 + @" = 0 

:GYMDUMB_7917
jump @GYMDUMB_683 
end_thread
" );

            }

        }

        private sealed class GYM : Thread {

            public override void START( LabelJump label ) {

                wait( 70 );
                and( START, PlayerChar.is_defined(), PlayerChar.is_controllable() );
                PlayerActor.get_active_interior( GymFight_Interior );
                and( GymFight_Interior == 0, delegate {
                    and( OnMission == true, delegate {
                        and( Gyms_Accessible_Flag == true, delegate {
                            set_interior_access( "GYM1", false );
                            set_interior_access( "GYM2", false );
                            set_interior_access( "GYM3", false );
                            Gyms_Accessible_Flag.value = false;
                        } );
                        jump( START );
                    } );
                    or( _1348 == true, Gyms_Accessible_Flag == false, delegate {
                        set_interior_access( "GYM1", true );
                        set_interior_access( "GYM2", true );
                        set_interior_access( "GYM3", true );
                        Gyms_Accessible_Flag.value = true;
                        _1348.value = false;
                    } );
                    jump( START );
                } );

                and( START, _1348 == false );

                and( GymFight_Interior == 5,
                    PlayerActor.is_near_point_3d_on_foot( 0, 767.1537, 4.8323, 999.7185, 50.0, 50.0, 10.0 )
                , delegate {
                    _1348.value = true;
                    start_mission<GYMLS>();
                    jump( START );
                } );

                and( GymFight_Interior == 6,
                    PlayerActor.is_near_point_3d_on_foot( 0, 768.4777, -37.1737, 999.6865, 50.0, 50.0, 10.0 )
                , delegate {
                    _1348.value = true;
                    start_mission<GYMSF>();
                    jump( START );
                } );

                and( GymFight_Interior == 7,
                    PlayerActor.is_near_point_3d_on_foot( 0, 766.5975, -65.293, 999.6562, 50.0, 50.0, 10.0 )
                , delegate {
                    _1348.value = true;
                    start_mission<GYMLV>();
                    jump( START );
                } );
                jump( START );
            }

        }

        private sealed class GYMLS : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @GYMLS_57
0169: set_fade_color_RGB 0 0 0 
if 
wasted_or_busted 
jf @GYMLS_46 
gosub @GYMLS_5862 

:GYMLS_46
gosub @GYMLS_5902 
end_thread 
increment_mission_attempts 

:GYMLS_57
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_80 
07CB: set_actor " + PlayerActor + @" supporting_fire 0 

:GYMLS_80
" + OnMission + @" = 1 
" + _8152 + @" = 0 
0623: add 1 to_integer_stat 198 
" + ONMISSION_GYMFIGHT + @" = 1 
054C: use_GXT_table 'GYM' 
Model.Load(#VBMYBOX)
Model.Load(#VWMYBOX)
Model.Load(#BMYDJ)
04ED: load_animation ""RIOT"" 
04ED: load_animation ""FIGHT_B"" 
04ED: load_animation ""INT_SHOP"" 
04ED: load_animation ""GYMNASIUM"" 
038B: load_requested_models 

:GYMLS_177
if or
84EE:   not animation ""GYMNASIUM"" loaded 
   not Model.Available(#VBMYBOX)
   not Model.Available(#VWMYBOX)
jf @GYMLS_220 
wait 0 
jump @GYMLS_177 

:GYMLS_220
if or
   not Model.Available(#BMYDJ)
84EE:   not animation ""RIOT"" loaded 
84EE:   not animation ""FIGHT_B"" loaded 
84EE:   not animation ""INT_SHOP"" loaded 
jf @GYMLS_277 
wait 0 
jump @GYMLS_220 

:GYMLS_277
060A: create_decision_maker_type 0 store_to 43@ 
060A: create_decision_maker_type 1 store_to 58@ 
060A: create_decision_maker_type 2 store_to 57@ 
0746: set_acquaintance 3 of_actors_pedtype 25 to_actors_pedtype 0 
0708: reset_decision_maker 58@ event 31 
0708: reset_decision_maker 57@ event 31 
0708: reset_decision_maker 58@ event 9 
0708: reset_decision_maker 58@ event 15 
0708: reset_decision_maker 58@ event 37 
0708: reset_decision_maker 57@ event 37 
0709: set_decision_maker 58@ on_event 31 taskID 413 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
0709: set_decision_maker 58@ on_event 9 taskID 415 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
0709: set_decision_maker 58@ on_event 15 taskID 300 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
0709: set_decision_maker 57@ on_event 31 taskID 413 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
0709: set_decision_maker 57@ on_event 15 taskID 300 respect 100.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
0709: set_decision_maker 58@ on_event 37 taskID 300 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker 57@ on_event 37 taskID 300 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0615: define_AS_pack_begin 40@ 
0603: AS_actor -1 goto_point_any_means 762.8681 7.4928 999.7141 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 13.3401 
0605: actor -1 perform_animation ""RIOT_PUNCHES"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 40@ loop 1 
0616: define_AS_pack_end 40@ 
0615: define_AS_pack_begin 54@ 
0603: AS_actor -1 goto_point_any_means 765.2909 16.0319 999.698 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 198.8789 
0643: set_AS_pack 54@ loop 1 
0616: define_AS_pack_end 54@ 
0615: define_AS_pack_begin 53@ 
0603: AS_actor -1 goto_point_any_means 767.2571 14.4044 999.6998 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 263.2938 
0605: actor -1 perform_animation ""GYMSHADOWBOX"" IFP ""GYMNASIUM"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 53@ loop 1 
0616: define_AS_pack_end 53@ 
0615: define_AS_pack_begin 49@ 
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
05B9: AS_actor -1 stay_idle 1000 ms 
0643: set_AS_pack 49@ loop 1 
0616: define_AS_pack_end 49@ 
0615: define_AS_pack_begin 50@ 
05B9: AS_actor -1 stay_idle 500 ms 
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
0643: set_AS_pack 50@ loop 1 
0616: define_AS_pack_end 50@ 
0615: define_AS_pack_begin 51@ 
05B9: AS_actor -1 stay_idle 750 ms 
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
0643: set_AS_pack 51@ loop 1 
0616: define_AS_pack_end 51@ 
34@ = Actor.Create(Mission2, #VWMYBOX, 761.6263, 11.4876, 1000.164)
Actor.Angle(34@) = 128.1297
060B: set_actor 34@ decision_maker_to 58@ 
02A9: set_actor 34@ immune_to_nonplayer 1 
0489: set_actor 34@ muted 1 
35@ = Actor.Create(Mission2, #VWMYBOX, 760.343, 10.1973, 999.7099)
Actor.Angle(35@) = 310.2206
060B: set_actor 35@ decision_maker_to 58@ 
02A9: set_actor 35@ immune_to_nonplayer 1 
0489: set_actor 34@ muted 1 
0615: define_AS_pack_begin 52@ 
0603: AS_actor -1 goto_point_any_means 761.6263 11.4876 1000.164 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 128.1297 
if 
   not Actor.Dead(34@)
jf @GYMLS_1192 
05E2: AS_actor -1 kill_actor 35@ 

:GYMLS_1192
0643: set_AS_pack 52@ loop 1 
0616: define_AS_pack_end 52@ 
0615: define_AS_pack_begin 41@ 
0603: AS_actor -1 goto_point_any_means 760.343 10.1973 999.7099 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 310.2206 
if 
   not Actor.Dead(34@)
jf @GYMLS_1264 
05E2: AS_actor -1 kill_actor 34@ 

:GYMLS_1264
0643: set_AS_pack 41@ loop 1 
0616: define_AS_pack_end 41@ 
0618: assign_actor 34@ to_AS_pack 52@ 
0618: assign_actor 35@ to_AS_pack 41@ 
37@ = Actor.Create(Mission2, #BMYDJ, 762.8681, 7.4928, 999.7141)
Actor.Angle(37@) = 13.3401
0618: assign_actor 37@ to_AS_pack 40@ 
060B: set_actor 37@ decision_maker_to 57@ 
39@ = Actor.Create(Mission2, #VBMYBOX, 767.2571, 14.4044, 999.6998)
Actor.Angle(39@) = 263.2938
060B: set_actor 39@ decision_maker_to 57@ 
0618: assign_actor 39@ to_AS_pack 53@ 
07FE: set_actor 39@ fighting_style_to 5 moves 6 
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMLS_1412
if 
83D0:   not wav 4 loaded 
jf @GYMLS_1438 
wait 0 
jump @GYMLS_1412 

:GYMLS_1438
TIMERA = 0 
64@ = 2 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" 
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit_Reached + @" 
jf @GYMLS_1489 
" + GYM_Day_Limit + @" = 0.0 

:GYMLS_1489
wait 0 
gosub @GYMLS_6164 
if 
  48@ == 0 
jf @GYMLS_1667 
if 
   not Actor.Dead(34@)
jf @GYMLS_1589 
if 
   Actor.Animation(34@) == ""GYM_SHADOWBOX""
jf @GYMLS_1589 
0614: set_actor 34@ animation ""GYMSHADOWBOX"" progress_to 0.0 

:GYMLS_1589
if 
   not Actor.Dead(35@)
jf @GYMLS_1660 
if 
   Actor.Animation(35@) == ""GYM_SHADOWBOX""
jf @GYMLS_1660 
0614: set_actor 35@ animation ""GYMSHADOWBOX"" progress_to 0.5 

:GYMLS_1660
48@ = 1 

:GYMLS_1667
if and
   Actor.Dead(34@)
  TIMERA > 20000 
jf @GYMLS_1727 
if 
   not Actor.Dead(35@)
jf @GYMLS_1727 
0687: clear_actor 35@ task 
05C5: AS_actor 35@ cower 20000 ms 
TIMERA = 0 

:GYMLS_1727
if and
   Actor.Dead(35@)
  TIMERA > 20000 
jf @GYMLS_1787 
if 
   not Actor.Dead(34@)
jf @GYMLS_1787 
0687: clear_actor 34@ task 
05C5: AS_actor 34@ cower 20000 ms 
TIMERA = 0 

:GYMLS_1787
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 760.8566 11.063 1000.164 radius 3.0 3.0 2.0 
jf @GYMLS_1941 
if 
  59@ == 0 
jf @GYMLS_1934 
if 
   not Actor.Dead(34@)
jf @GYMLS_1890 
0792: disembark_instantly_actor 34@ 
060B: set_actor 34@ decision_maker_to 57@ 
05E2: AS_actor 34@ kill_actor " + PlayerActor + @" 

:GYMLS_1890
if 
   not Actor.Dead(35@)
jf @GYMLS_1927 
0792: disembark_instantly_actor 35@ 
060B: set_actor 35@ decision_maker_to 57@ 
05E2: AS_actor 35@ kill_actor " + PlayerActor + @" 

:GYMLS_1927
59@ = 1 

:GYMLS_1934
jump @GYMLS_2029 

:GYMLS_1941
if 
  59@ == 1 
jf @GYMLS_2029 
if and
   not Actor.Dead(34@)
   not Actor.Dead(35@)
jf @GYMLS_2022 
0792: disembark_instantly_actor 34@ 
060B: set_actor 34@ decision_maker_to 58@ 
0618: assign_actor 34@ to_AS_pack 52@ 
0792: disembark_instantly_actor 35@ 
060B: set_actor 35@ decision_maker_to 58@ 
0618: assign_actor 35@ to_AS_pack 41@ 

:GYMLS_2022
59@ = 0 

:GYMLS_2029
09E8: " + Active_Interior + @" = actor " + PlayerActor + @" active_interior 
if 
  " + Active_Interior + @" == 0 
jf @GYMLS_2062 
jump @GYMLS_5862 

:GYMLS_2062
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 767.1368 12.511 999.7036 radius 2.5 2.5 4.0 
jf @GYMLS_2117 
46@ = 0 

:GYMLS_2117
if 
   not Actor.Dead(39@)
jf @GYMLS_5855 
if and
  46@ == 0 
00FE:   actor 39@ sphere 0 in_sphere 767.2571 14.4044 999.6998 radius 1.0 1.0 1.2 
jf @GYMLS_5855 
if 
0101:   actor " + PlayerActor + @" in_sphere 767.1368 12.511 999.7036 radius 0.6 0.6 1.0 sphere 1 stopped 
jf @GYMLS_2236 

:GYMLS_2236
if and
0101:   actor " + PlayerActor + @" in_sphere 767.1368 12.511 999.7036 radius 1.2 1.2 1.2 sphere 0 stopped 
   not Actor.Dead(39@)
jf @GYMLS_5855 
if and
   not Actor.Dead(39@)
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_2343 
Player.CanMove(" + PlayerChar + @") = False
0792: disembark_instantly_actor " + PlayerActor + @" 
0792: disembark_instantly_actor 39@ 
0639: AS_actor 39@ rotate_to_actor " + PlayerActor + @" 
0639: AS_actor " + PlayerActor + @" rotate_to_actor 39@ 

:GYMLS_2343
if 
  " + _8156 + @" == 0 
jf @GYMLS_2418 
040D: unload_wav 1 
03CF: load_wav 4800 as 1 

:GYMLS_2372
if 
83D0:   not wav 1 loaded 
jf @GYMLS_2398 
wait 0 
jump @GYMLS_2372 

:GYMLS_2398
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'BBOX_1' time 3000 flag 1  

:GYMLS_2418
if 
  " + _8156 + @" == 1 
jf @GYMLS_2493 
040D: unload_wav 1 
03CF: load_wav 4803 as 1 

:GYMLS_2447
if 
83D0:   not wav 1 loaded 
jf @GYMLS_2473 
wait 0 
jump @GYMLS_2447 

:GYMLS_2473
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'BBOX_4' time 3000 flag 1  

:GYMLS_2493
0512: show_permanent_text_box 'TALK_1'  

:GYMLS_2504
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_2852 
wait 0 
if 
00E1:   player 0 pressed_key 11 
jf @GYMLS_2717 
0653: 60@ = float_stat 23 
if 
  60@ > 349.0 
jf @GYMLS_2592 
44@ = 1 
03E6: remove_text_box 
jump @GYMLS_2852 
jump @GYMLS_2717 

:GYMLS_2592
44@ = 0 
46@ = 1 
03E6: remove_text_box 
040D: unload_wav 1 
03CF: load_wav 4802 as 1 

:GYMLS_2619
if 
83D0:   not wav 1 loaded 
jf @GYMLS_2645 
wait 0 
jump @GYMLS_2619 

:GYMLS_2645
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'BBOX_3' time 3000 flag 1  
Player.CanMove(" + PlayerChar + @") = True
if 
   not Actor.Dead(39@)
jf @GYMLS_2696 
0618: assign_actor 39@ to_AS_pack 53@ 

:GYMLS_2696
TIMERA = 0 
55@ = 1 
jump @GYMLS_1489 

:GYMLS_2717
if 
00E1:   player 0 pressed_key 10 
jf @GYMLS_2845 
44@ = 0 
46@ = 1 
03E6: remove_text_box 
040D: unload_wav 1 
03CF: load_wav 4801 as 1 

:GYMLS_2761
if 
83D0:   not wav 1 loaded 
jf @GYMLS_2787 
wait 0 
jump @GYMLS_2761 

:GYMLS_2787
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'BBOX_2' time 3000 flag 1  
Player.CanMove(" + PlayerChar + @") = True
if 
   not Actor.Dead(39@)
jf @GYMLS_2838 
0618: assign_actor 39@ to_AS_pack 53@ 

:GYMLS_2838
jump @GYMLS_1489 

:GYMLS_2845
jump @GYMLS_2504 

:GYMLS_2852
03E6: remove_text_box 
00BE: text_clear_all 
0992: set_player " + PlayerChar + @" weapons_scrollable 0 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
gosub @GYMLS_6055 
Actor.DestroyInstantly(37@)
Actor.DestroyInstantly(34@)
Actor.DestroyInstantly(35@)
34@ = Actor.Create(Mission2, #VWMYBOX, 761.6934, 4.2203, 999.7099)
Actor.Angle(34@) = 171.4614
0618: assign_actor 34@ to_AS_pack 49@ 
35@ = Actor.Create(Mission2, #VWMYBOX, 764.7962, 0.7163, 999.715)
Actor.Angle(35@) = 93.8066
0618: assign_actor 35@ to_AS_pack 50@ 
37@ = Actor.Create(Mission2, #BMYDJ, 759.5085, 4.2343, 999.7051)
Actor.Angle(37@) = 189.7654
0618: assign_actor 37@ to_AS_pack 51@ 
if 
   not Actor.Dead(39@)
jf @GYMLS_3080 
08C7: put_actor 39@ at 762.616 2.1235 1000.594 dont_warp_gang 
Actor.Angle(39@) = 135.5749
Actor.Health(39@) = 1000
Actor.SetMaxHealth(39@, 1000)

:GYMLS_3080
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_3126 
08C7: put_actor " + PlayerActor + @" at 759.0147 -1.7235 1000.594 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 312.9747

:GYMLS_3126
if 
   not Actor.Dead(39@)
jf @GYMLS_3174 
060B: set_actor 39@ decision_maker_to 57@ 
05E2: AS_actor 39@ kill_actor " + PlayerActor + @" 
07FE: set_actor 39@ fighting_style_to 5 moves 6 
07DD: set_actor 39@ attack_rate 100 

:GYMLS_3174
Camera.SetBehindPlayer
Player.CanMove(" + PlayerChar + @") = True
if 
  " + _8156 + @" == 0 
jf @GYMLS_3212 
0512: show_permanent_text_box 'GYM1101'  

:GYMLS_3212
if 
  " + _8156 + @" == 1 
jf @GYMLS_3241 
0512: show_permanent_text_box 'GYM1_84'  

:GYMLS_3241
gosub @GYMLS_6111 
TIMERA = 0 
TIMERB = 0 
if and
03D0:   wav 4 loaded 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_3290 
09F1: play_audio_at_actor " + PlayerActor + @" event 1115 

:GYMLS_3290
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_3807 
wait 0 
if 
   not Actor.Dead(35@)
jf @GYMLS_3381 
if 
80FE:   not actor 35@ sphere 0 in_sphere 761.0182 0.6609 1000.594 radius 6.0 6.0 6.0 
jf @GYMLS_3381 
jump @GYMLS_3807 

:GYMLS_3381
if 
   not Actor.Dead(34@)
jf @GYMLS_3437 
if and
  TIMERB > 3000 
  65@ == 0 
jf @GYMLS_3430 
65@ = 1 

:GYMLS_3430
TIMERB = 0 

:GYMLS_3437
if 
   not Actor.Dead(35@)
jf @GYMLS_3493 
if and
  TIMERB > 3000 
  65@ == 1 
jf @GYMLS_3486 
65@ = 0 

:GYMLS_3486
TIMERB = 0 

:GYMLS_3493
if 
  " + _8156 + @" == 1 
jf @GYMLS_3777 
if 
  56@ == 0 
jf @GYMLS_3556 
TIMERA = 0 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_94'  
56@ = 1 

:GYMLS_3556
if 
840C:   not is_german_game 
jf @GYMLS_3682 
if and
  TIMERA > 6000 
  56@ == 1 
jf @GYMLS_3622 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_95'  
TIMERA = 0 
56@ = 2 

:GYMLS_3622
if and
  TIMERA > 6000 
  56@ == 2 
jf @GYMLS_3675 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_96'  
TIMERA = 0 
56@ = 3 

:GYMLS_3675
jump @GYMLS_3735 

:GYMLS_3682
if and
  TIMERA > 6000 
  56@ == 1 
jf @GYMLS_3735 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_96'  
TIMERA = 0 
56@ = 3 

:GYMLS_3735
if and
  TIMERA > 6000 
  56@ == 3 
jf @GYMLS_3777 
03E6: remove_text_box 
TIMERA = 0 
56@ = 0 

:GYMLS_3777
if 
   Actor.Dead(39@)
jf @GYMLS_3800 
jump @GYMLS_3807 

:GYMLS_3800
jump @GYMLS_3290 

:GYMLS_3807
03E6: remove_text_box 
if 
  " + _8156 + @" == 1 
jf @GYMLS_3834 
jump @GYMLS_5431 

:GYMLS_3834
gosub @GYMLS_6055 
Actor.DestroyInstantly(39@)
0395: clear_area 1 at 760.7445 0.6538 1000.594 radius 10.0 
gosub @GYMLS_6003 
39@ = Actor.Create(Mission2, #VBMYBOX, 762.616, 2.1235, 1000.594)
Actor.Angle(39@) = 135.5749
060B: set_actor 39@ decision_maker_to 43@ 
0792: disembark_instantly_actor 39@ 
060B: set_actor 39@ decision_maker_to 43@ 
07FE: set_actor 39@ fighting_style_to 5 moves 6 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_3987 
08C7: put_actor " + PlayerActor + @" at 759.0147 -1.7235 1000.594 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 312.9747

:GYMLS_3987
Actor.DestroyInstantly(34@)
Actor.DestroyInstantly(35@)
Actor.DestroyInstantly(37@)
Camera.SetPosition(764.0964, -4.8216, 1003.062, 0.0, 0.0, 0.0)
Camera.PointAt(763.5206, -4.0516, 1002.787, 2)
gosub @GYMLS_6111 
00BC: show_text_highpriority GXT 'BBOX_5' time 4000 flag 1  
040D: unload_wav 1 
03CF: load_wav 4804 as 1 

:GYMLS_4087
if 
83D0:   not wav 1 loaded 
jf @GYMLS_4130 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4123 

:GYMLS_4123
jump @GYMLS_4087 

:GYMLS_4130
03D1: play_wav 1 
wait 1000 
TIMERA = 0 

:GYMLS_4146
if 
  2000 > TIMERA 
jf @GYMLS_4193 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4186 

:GYMLS_4186
jump @GYMLS_4146 

:GYMLS_4193
Camera.SetPosition(762.5212, -0.4172, 1001.843, 0.0, 0.0, 0.0)
Camera.PointAt(762.5431, 0.5793, 1001.762, 2)
00BC: show_text_highpriority GXT 'GYM1_97' time 2000 flag 1  
TIMERA = 0 

:GYMLS_4267
if 
  2000 > TIMERA 
jf @GYMLS_4314 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4307 

:GYMLS_4307
jump @GYMLS_4267 

:GYMLS_4314
040D: unload_wav 1 
03CF: load_wav 4805 as 1 

:GYMLS_4325
if 
83D0:   not wav 1 loaded 
jf @GYMLS_4368 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4361 

:GYMLS_4361
jump @GYMLS_4325 

:GYMLS_4368
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_94' time 4000 flag 1  
TIMERA = 0 

:GYMLS_4395
if 
  4000 > TIMERA 
jf @GYMLS_4442 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4435 

:GYMLS_4435
jump @GYMLS_4395 

:GYMLS_4442
if 
   not Actor.Dead(39@)
jf @GYMLS_4497 
0605: actor 39@ perform_animation ""FIGHTB_M"" IFP ""FIGHT_B"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLS_4497
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_4545 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLS_4545
TIMERA = 0 

:GYMLS_4552
if 
  3000 > TIMERA 
jf @GYMLS_4599 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4592 

:GYMLS_4592
jump @GYMLS_4552 

:GYMLS_4599
if 
840C:   not is_german_game 
jf @GYMLS_5018 
Camera.SetPosition(759.6699, 1.9955, 1001.068, 0.0, 0.0, 0.0)
Camera.PointAt(760.6637, 2.0051, 1001.178, 2)
00BC: show_text_highpriority GXT 'GYM1_98' time 2000 flag 1  
TIMERA = 0 

:GYMLS_4686
if 
  2000 > TIMERA 
jf @GYMLS_4733 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4726 

:GYMLS_4726
jump @GYMLS_4686 

:GYMLS_4733
040D: unload_wav 1 
03CF: load_wav 4806 as 1 

:GYMLS_4744
if 
83D0:   not wav 1 loaded 
jf @GYMLS_4787 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4780 

:GYMLS_4780
jump @GYMLS_4744 

:GYMLS_4787
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_95' time 4000 flag 1  
TIMERA = 0 

:GYMLS_4814
if 
  4000 > TIMERA 
jf @GYMLS_4861 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_4854 

:GYMLS_4854
jump @GYMLS_4814 

:GYMLS_4861
if 
   not Actor.Dead(39@)
jf @GYMLS_4916 
0605: actor 39@ perform_animation ""FIGHTB_G"" IFP ""FIGHT_B"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLS_4916
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_4964 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLS_4964
TIMERA = 0 

:GYMLS_4971
if 
  3000 > TIMERA 
jf @GYMLS_5018 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_5011 

:GYMLS_5011
jump @GYMLS_4971 

:GYMLS_5018
Camera.SetPosition(764.5368, 3.1767, 1002.349, 0.0, 0.0, 0.0)
Camera.PointAt(763.7495, 2.6046, 1002.12, 2)
00BC: show_text_highpriority GXT 'GYM1_99' time 2000 flag 1  
TIMERA = 0 

:GYMLS_5092
if 
  2000 > TIMERA 
jf @GYMLS_5139 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_5132 

:GYMLS_5132
jump @GYMLS_5092 

:GYMLS_5139
040D: unload_wav 1 
03CF: load_wav 4807 as 1 

:GYMLS_5150
if 
83D0:   not wav 1 loaded 
jf @GYMLS_5193 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_5186 

:GYMLS_5186
jump @GYMLS_5150 

:GYMLS_5193
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_96' time 4000 flag 1  
TIMERA = 0 

:GYMLS_5220
if 
  4000 > TIMERA 
jf @GYMLS_5267 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_5260 

:GYMLS_5260
jump @GYMLS_5220 

:GYMLS_5267
if 
   not Actor.Dead(39@)
jf @GYMLS_5329 
Actor.LockInCurrentPosition(39@) = True
0605: actor 39@ perform_animation ""FIGHTB_3"" IFP ""FIGHT_B"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLS_5329
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_5377 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMLS_5377
TIMERA = 0 

:GYMLS_5384
if 
  2000 > TIMERA 
jf @GYMLS_5431 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_5424 

:GYMLS_5424
jump @GYMLS_5384 

:GYMLS_5431
Actor.DestroyInstantly(37@)
Actor.DestroyInstantly(34@)
Actor.DestroyInstantly(35@)
gosub @GYMLS_6055 
34@ = Actor.Create(Mission2, #VWMYBOX, 761.6263, 11.4876, 1000.164)
Actor.Angle(34@) = 128.1297
060B: set_actor 34@ decision_maker_to 58@ 
02A9: set_actor 34@ immune_to_nonplayer 1 
0489: set_actor 34@ muted 1 
35@ = Actor.Create(Mission2, #VWMYBOX, 760.343, 10.1973, 999.7099)
Actor.Angle(35@) = 310.2206
060B: set_actor 35@ decision_maker_to 58@ 
02A9: set_actor 35@ immune_to_nonplayer 1 
0489: set_actor 34@ muted 1 
0618: assign_actor 34@ to_AS_pack 52@ 
0618: assign_actor 35@ to_AS_pack 41@ 
37@ = Actor.Create(Mission2, #BMYDJ, 762.8681, 7.4928, 999.7141)
Actor.Angle(37@) = 13.3401
0618: assign_actor 37@ to_AS_pack 40@ 
060B: set_actor 37@ decision_maker_to 57@ 
Actor.DestroyInstantly(39@)
39@ = Actor.Create(Mission2, #VBMYBOX, 767.2571, 14.4044, 999.6998)
Actor.Angle(39@) = 263.2938
060B: set_actor 39@ decision_maker_to 57@ 
0618: assign_actor 39@ to_AS_pack 53@ 
07FE: set_actor 39@ fighting_style_to 5 moves 6 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_5741 
08C7: put_actor " + PlayerActor + @" at 765.6662 2.7963 999.718 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 277.3348

:GYMLS_5741
gosub @GYMLS_6027 
gosub @GYMLS_6111 
if 
  " + _8153 + @" == 0 
jf @GYMLS_5784 
//030C: progress_made = 1 
" + _8153 + @" = 1 

:GYMLS_5784
07FE: set_actor " + PlayerActor + @" fighting_style_to 5 moves 6 
if 
  " + _8156 + @" == 0 
jf @GYMLS_5827 
00BC: show_text_highpriority GXT 'GYM1_93' time 3000 flag 1  

:GYMLS_5827
" + _8155 + @" = 0 
" + _8156 + @" = 1 
" + _8157 + @" = 0 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 

:GYMLS_5855
jump @GYMLS_1489 

:GYMLS_5862
return 
01E3: show_text_1number_styled GXT 'M_PASS' number 30000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 30000
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 1 
return 

:GYMLS_5902
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLS_5925 
07CB: set_actor " + PlayerActor + @" supporting_fire 1 

:GYMLS_5925
Model.Destroy(#VBMYBOX)
Model.Destroy(#VWMYBOX)
Model.Destroy(#BMYDJ)
04EF: release_animation ""GYMNASIUM"" 
04EF: release_animation ""RIOT"" 
04EF: release_animation ""FIGHT_B"" 
04EF: release_animation ""INT_SHOP"" 
040D: unload_wav 4 
" + ONMISSION_GYMFIGHT + @" = 0 
" + OnMission + @" = 0 
mission_cleanup 
return 

:GYMLS_6003
03E6: remove_text_box 
00BE: text_clear_all 
02A3: enable_widescreen 1 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
return 

:GYMLS_6027
03E6: remove_text_box 
00BE: text_clear_all 
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
return 

:GYMLS_6055
fade 0 500 

:GYMLS_6062
if 
fading 
jf @GYMLS_6109 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLS_6102 
fade 0 1 

:GYMLS_6102
jump @GYMLS_6062 

:GYMLS_6109
return 

:GYMLS_6111
fade 1 500 

:GYMLS_6118
if 
fading 
jf @GYMLS_6142 
wait 0 
jump @GYMLS_6118 

:GYMLS_6142
return 
040D: unload_wav 1 
03CF: load_wav 63@ as 1 
64@ = 0 
return 

:GYMLS_6164
if and
03D0:   wav 1 loaded 
  64@ == 0 
jf @GYMLS_6207 
03D1: play_wav 1 
00BC: show_text_highpriority GXT 61@s time 10000 flag 1 
64@ = 1 

:GYMLS_6207
if and
03D2:   wav 1 ended 
  64@ == 1 
jf @GYMLS_6245 
040D: unload_wav 1 
03D5: remove_text 61@s 
64@ = 2 

:GYMLS_6245
return" );
            }

        }

        private sealed class GYMSF : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"fade 0 0 
gosub @GYMSF_63 
0169: set_fade_color_RGB 0 0 0 
if 
wasted_or_busted 
jf @GYMSF_52 
gosub @GYMSF_5328 

:GYMSF_52
gosub @GYMSF_5368 
end_thread 
increment_mission_attempts 

:GYMSF_63
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_86 
07CB: set_actor " + PlayerActor + @" supporting_fire 0 

:GYMSF_86
" + ONMISSION_GYMFIGHT + @" = 1 
63@ = 2 
" + OnMission + @" = 1 
0623: add 1 to_integer_stat 198 
054C: use_GXT_table 'GYM' 
Model.Load(#WMYJG)
Model.Load(#OMYKARA)
Model.Load(#WMYLG)
Model.Load(#OMOKUNG)
Model.Load(#WMYKARA)

:GYMSF_147
if or
   not Model.Available(#WMYJG)
   not Model.Available(#OMYKARA)
   not Model.Available(#WMYLG)
   not Model.Available(#OMOKUNG)
   not Model.Available(#WMYKARA)
jf @GYMSF_191 
wait 0 
jump @GYMSF_147 

:GYMSF_191
04ED: load_animation ""PARK"" 
04ED: load_animation ""FIGHT_C"" 
04ED: load_animation ""GYMNASIUM"" 

:GYMSF_223
if or
84EE:   not animation ""PARK"" loaded 
84EE:   not animation ""FIGHT_C"" loaded 
84EE:   not animation ""GYMNASIUM"" loaded 
jf @GYMSF_277 
wait 0 
jump @GYMSF_223 

:GYMSF_277
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMSF_288
if 
83D0:   not wav 4 loaded 
jf @GYMSF_314 
wait 0 
jump @GYMSF_288 

:GYMSF_314
060A: create_decision_maker_type 0 store_to 40@ //
060A: create_decision_maker_type 1 store_to 57@ //
060A: create_decision_maker_type 2 store_to 41@ //
0615: define_AS_pack_begin 52@ 
0603: AS_actor -1 goto_point_any_means 768.064 -41.5728 999.6865 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 358.0992 
05C9: AS_actor -1 on_guard -2 ms 
0616: define_AS_pack_end 52@ 
0615: define_AS_pack_begin 53@ 
0603: AS_actor -1 goto_point_any_means 770.3961 -23.0853 999.5938 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 87.3049 
0605: actor -1 perform_animation ""TAI_CHI_LOOP"" IFP ""PARK"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 53@ 
0615: define_AS_pack_begin 54@ 
05B9: AS_actor -1 stay_idle 1000 ms 
0603: AS_actor -1 goto_point_any_means 766.3062 -23.0554 999.5938 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 272.4196 
0605: actor -1 perform_animation ""TAI_CHI_LOOP"" IFP ""PARK"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 54@ 
0615: define_AS_pack_begin 42@ 
05B9: AS_actor -1 stay_idle 1000 ms 
0603: AS_actor -1 goto_point_any_means 769.8199 -36.4933 999.6865 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 88.548 
0605: actor -1 perform_animation ""FIGHTC_IDLE"" IFP ""FIGHT_C"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 42@ loop 1 
0616: define_AS_pack_end 42@ 
0615: define_AS_pack_begin 43@ 
0603: AS_actor -1 goto_point_any_means 767.057 -37.0465 999.6865 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 270.0 
0605: actor -1 perform_animation ""FIGHTC_IDLE"" IFP ""FIGHT_C"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 43@ loop 1 
0616: define_AS_pack_end 43@ 
0615: define_AS_pack_begin 48@ 
0603: AS_actor -1 goto_point_any_means 768.064 -41.5728 999.6865 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 358.0992 
05C9: AS_actor -1 on_guard -2 ms 
0643: set_AS_pack 48@ loop 1 
0616: define_AS_pack_end 48@ 
38@ = Actor.Create(CivMale, #OMOKUNG, 768.064, -41.5728, 999.6865)
Actor.Angle(38@) = 358.0992
0618: assign_actor 38@ to_AS_pack 48@ 
060B: set_actor 38@ decision_maker_to 57@ 
07FE: set_actor 38@ fighting_style_to 6 moves 6 
0615: define_AS_pack_begin 49@ 
0603: AS_actor -1 goto_point_any_means 770.3961 -23.0853 999.5938 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 87.3049 
0605: actor -1 perform_animation ""TAI_CHI_LOOP"" IFP ""PARK"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 49@ loop 1 
0616: define_AS_pack_end 49@ 
35@ = Actor.Create(CivMale, #WMYJG, 770.3961, -23.0853, 999.5938)
Actor.Angle(35@) = 87.3049
0618: assign_actor 35@ to_AS_pack 49@ 
060B: set_actor 35@ decision_maker_to 41@ 
07FE: set_actor 35@ fighting_style_to 6 moves 6 
0615: define_AS_pack_begin 50@ 
05B9: AS_actor -1 stay_idle 1000 ms 
0603: AS_actor -1 goto_point_any_means 766.3062 -23.0554 999.5938 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 272.4196 
0605: actor -1 perform_animation ""TAI_CHI_LOOP"" IFP ""PARK"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 50@ loop 1 
0616: define_AS_pack_end 50@ 
34@ = Actor.Create(CivMale, #WMYLG, 766.3062, -23.0554, 999.5938)
Actor.Angle(34@) = 272.4196
0618: assign_actor 34@ to_AS_pack 50@ 
060B: set_actor 34@ decision_maker_to 41@ 
07FE: set_actor 34@ fighting_style_to 6 moves 6 
36@ = Actor.Create(CivMale, #OMYKARA, 769.8199, -36.4933, 999.6865)
Actor.Angle(36@) = 95.1885
0618: assign_actor 36@ to_AS_pack 42@ 
060B: set_actor 36@ decision_maker_to 41@ 
07FE: set_actor 36@ fighting_style_to 6 moves 6 
37@ = Actor.Create(CivMale, #WMYKARA, 766.1017, -37.3952, 999.6865)
Actor.Angle(37@) = 271.1251
0618: assign_actor 37@ to_AS_pack 43@ 
060B: set_actor 37@ decision_maker_to 41@ 
07FE: set_actor 37@ fighting_style_to 6 moves 6 
gosub @GYMSF_5567 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" //
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit_Reached + @" //
jf @GYMSF_1318 
" + GYM_Day_Limit + @" = 0.0 

:GYMSF_1318
wait 0 
gosub @GYMSF_5620 
if 
  51@ == 0 
jf @GYMSF_1422 
if 
   not Actor.Dead(37@)
jf @GYMSF_1422 
if 
   Actor.Animation(37@) == ""FIGHTC_SPAR""
jf @GYMSF_1422 
0614: set_actor 37@ animation ""FIGHTC_SPAR"" progress_to 0.45 //
51@ = 1 

:GYMSF_1422
09E8: " + Active_Interior + @" = actor " + PlayerActor + @" active_interior 
if 
  " + Active_Interior + @" == 0 
jf @GYMSF_1455 
jump @GYMSF_5328 

:GYMSF_1455
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 769.7938 -42.1122 999.6865 radius 2.5 2.5 4.0 
jf @GYMSF_1510 
47@ = 0 

:GYMSF_1510
if 
   not Actor.Dead(38@)
jf @GYMSF_5321 
if and
  47@ == 0 
00FE:   actor 38@ sphere 0 in_sphere 768.064 -41.5728 999.6865 radius 1.0 1.0 1.2 
jf @GYMSF_5321 
if 
0101:   actor " + PlayerActor + @" in_sphere 769.7938 -42.1122 999.6865 radius 0.6 0.6 1.0 sphere 1 stopped 
jf @GYMSF_1629 

:GYMSF_1629
if and
0101:   actor " + PlayerActor + @" in_sphere 769.7938 -42.1122 999.6865 radius 1.2 1.2 1.2 sphere 0 stopped 
   not Actor.Dead(38@)
jf @GYMSF_5321 
if and
   not Actor.Dead(38@)
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_1731 
Player.CanMove(" + PlayerChar + @") = False
0792: disembark_instantly_actor " + PlayerActor + @" 
0639: AS_actor 38@ rotate_to_actor " + PlayerActor + @" 
0639: AS_actor " + PlayerActor + @" rotate_to_actor 38@ 

:GYMSF_1731
if 
  " + _8155 + @" == 0 
jf @GYMSF_1806 
040D: unload_wav 1 
03CF: load_wav 21200 as 1 

:GYMSF_1760
if 
83D0:   not wav 1 loaded 
jf @GYMSF_1786 
wait 0 
jump @GYMSF_1760 

:GYMSF_1786
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'KUNG_1' time 3000 flag 1  //

:GYMSF_1806
if 
  " + _8155 + @" == 1 
jf @GYMSF_1881 
040D: unload_wav 1 
03CF: load_wav 21203 as 1 

:GYMSF_1835
if 
83D0:   not wav 1 loaded 
jf @GYMSF_1861 
wait 0 
jump @GYMSF_1835 

:GYMSF_1861
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'KUNG_4' time 3000 flag 1  //

:GYMSF_1881
0512: show_permanent_text_box 'GYM1_73'  //

:GYMSF_1892
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_2216 
wait 0 
if 
00E1:   player 0 pressed_key 11 
jf @GYMSF_2081 
0653: 59@ = float_stat 23 
if 
  59@ > 349.0 
jf @GYMSF_1980 
44@ = 1 
03E6: remove_text_box 
jump @GYMSF_2218 
jump @GYMSF_2081 

:GYMSF_1980
44@ = 0 
47@ = 1 
03E6: remove_text_box 
040D: unload_wav 1 
03CF: load_wav 21202 as 1 

:GYMSF_2007
if 
83D0:   not wav 1 loaded 
jf @GYMSF_2033 
wait 0 
jump @GYMSF_2007 

:GYMSF_2033
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'KUNG_3' time 3000 flag 1  //
Player.CanMove(" + PlayerChar + @") = True
TIMERA = 0 
55@ = 1 
jump @GYMSF_1318 

:GYMSF_2081
if 
00E1:   player 0 pressed_key 10 
jf @GYMSF_2209 
44@ = 0 
47@ = 1 
03E6: remove_text_box 
040D: unload_wav 1 
03CF: load_wav 21201 as 1 

:GYMSF_2125
if 
83D0:   not wav 1 loaded 
jf @GYMSF_2151 
wait 0 
jump @GYMSF_2125 

:GYMSF_2151
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'KUNG_2' time 3000 flag 1  //
if 
   not Actor.Dead(38@)
jf @GYMSF_2195 
0618: assign_actor 38@ to_AS_pack 48@ 

:GYMSF_2195
Player.CanMove(" + PlayerChar + @") = True
jump @GYMSF_1318 

:GYMSF_2209
jump @GYMSF_1892 

:GYMSF_2216
03E6: remove_text_box 

:GYMSF_2218
03E6: remove_text_box 
00BE: text_clear_all 
0992: set_player " + PlayerChar + @" weapons_scrollable 0 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
if 
  44@ == 1 
jf @GYMSF_5321 
gosub @GYMSF_5511 
Actor.DestroyInstantly(36@)
Actor.DestroyInstantly(37@)
if 
   not Actor.Dead(38@)
jf @GYMSF_2333 
08C7: put_actor 38@ at 771.4357 -36.9728 999.6865 dont_warp_gang 
Actor.Angle(38@) = 88.1801
Actor.Health(38@) = 1000
Actor.SetMaxHealth(38@, 1000)

:GYMSF_2333
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_2379 
08C7: put_actor " + PlayerActor + @" at 764.6453 -37.1052 999.6865 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 273.9816

:GYMSF_2379
if 
   not Actor.Dead(38@)
jf @GYMSF_2427 
060B: set_actor 38@ decision_maker_to 41@ 
05E2: AS_actor 38@ kill_actor " + PlayerActor + @" 
07FE: set_actor 38@ fighting_style_to 6 moves 6 
07DD: set_actor 38@ attack_rate 100 //

:GYMSF_2427
Camera.SetBehindPlayer
Player.CanMove(" + PlayerChar + @") = True
if 
  " + _8155 + @" == 0 
jf @GYMSF_2465 
0512: show_permanent_text_box 'GYM1106'  //

:GYMSF_2465
if 
  " + _8155 + @" == 1 
jf @GYMSF_2494 
0512: show_permanent_text_box 'GYM1_84'  //

:GYMSF_2494
gosub @GYMSF_5567 
58@ = 0 
if and
03D0:   wav 4 loaded 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_2536 
09F1: play_audio_at_actor " + PlayerActor + @" event 1115 

:GYMSF_2536
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_3285 
wait 0 
if 
  " + _8155 + @" == 1 
jf @GYMSF_2840 
if 
  56@ == 0 
jf @GYMSF_2619 
TIMERA = 0 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_94'  //
56@ = 1 

:GYMSF_2619
if 
840C:   not is_german_game 
jf @GYMSF_2745 
if and
  TIMERA > 6000 
  56@ == 1 
jf @GYMSF_2685 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_95'  //
TIMERA = 0 
56@ = 2 

:GYMSF_2685
if and
  TIMERA > 6000 
  56@ == 2 
jf @GYMSF_2738 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_96'  //
TIMERA = 0 
56@ = 3 

:GYMSF_2738
jump @GYMSF_2798 

:GYMSF_2745
if and
  TIMERA > 6000 
  56@ == 1 
jf @GYMSF_2798 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_96'  //
TIMERA = 0 
56@ = 3 

:GYMSF_2798
if and
  TIMERA > 6000 
  56@ == 3 
jf @GYMSF_2840 
03E6: remove_text_box 
TIMERA = 0 
56@ = 0 

:GYMSF_2840
if 
   not Actor.Dead(38@)
jf @GYMSF_2911 
if 
80FE:   not actor 38@ sphere 0 in_sphere 768.4611 -36.6685 999.6865 radius 6.0 6.0 6.0 
jf @GYMSF_2911 
jump @GYMSF_3285 

:GYMSF_2911
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 768.4611 -36.6685 999.6865 radius 6.0 6.0 6.0 
jf @GYMSF_3255 
gosub @GYMSF_5511 
Actor.DestroyInstantly(38@)
38@ = Actor.Create(CivMale, #OMOKUNG, 768.064, -41.5728, 999.6865)
Actor.Angle(38@) = 358.0992
0618: assign_actor 38@ to_AS_pack 48@ 
060B: set_actor 38@ decision_maker_to 41@ 
07FE: set_actor 38@ fighting_style_to 6 moves 6 
36@ = Actor.Create(CivMale, #OMYKARA, 769.8199, -36.4933, 999.6865)
Actor.Angle(36@) = 95.1885
0618: assign_actor 36@ to_AS_pack 42@ 
060B: set_actor 36@ decision_maker_to 41@ 
07FE: set_actor 36@ fighting_style_to 6 moves 6 
37@ = Actor.Create(CivMale, #WMYKARA, 766.1017, -37.3952, 999.6865)
Actor.Angle(37@) = 271.1251
0618: assign_actor 37@ to_AS_pack 43@ 
060B: set_actor 37@ decision_maker_to 41@ 
07FE: set_actor 37@ fighting_style_to 6 moves 6 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_3203 
08C7: put_actor " + PlayerActor + @" at 762.756 -37.2153 999.6865 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 90.0
Player.CanMove(" + PlayerChar + @") = True

:GYMSF_3203
00BE: text_clear_all 
03E6: remove_text_box 
gosub @GYMSF_5567 
if 
  " + _8155 + @" == 0 
jf @GYMSF_3248 
00BC: show_text_highpriority GXT 'GYM1_92' time 5000 flag 1  //

:GYMSF_3248
jump @GYMSF_1318 

:GYMSF_3255
if 
   Actor.Dead(38@)
jf @GYMSF_3278 
jump @GYMSF_3285 

:GYMSF_3278
jump @GYMSF_2536 

:GYMSF_3285
03E6: remove_text_box 
if 
  " + _8155 + @" == 1 
jf @GYMSF_3319 
gosub @GYMSF_5511 
jump @GYMSF_4956 

:GYMSF_3319
gosub @GYMSF_5511 
Actor.DestroyInstantly(38@)
0395: clear_area 1 at 768.1746 -36.6986 999.6865 radius 5.0 
38@ = Actor.Create(CivMale, #OMOKUNG, 768.064, -41.5728, 999.6865)
Actor.Angle(38@) = 358.0992
060B: set_actor 38@ decision_maker_to 40@ 
if 
   not Actor.Dead(38@)
jf @GYMSF_3443 
08C7: put_actor 38@ at 771.4357 -36.9728 999.6865 dont_warp_gang 
Actor.Angle(38@) = 88.1801

:GYMSF_3443
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_3494 
0792: disembark_instantly_actor " + PlayerActor + @" 
08C7: put_actor " + PlayerActor + @" at 764.6453 -37.1052 999.6865 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 273.9816

:GYMSF_3494
if 
   not Actor.Dead(38@)
jf @GYMSF_3520 
060B: set_actor 38@ decision_maker_to 65542 

:GYMSF_3520
gosub @GYMSF_5467 
Camera.SetPosition(762.8773, -35.4754, 1001.545, 0.0, 0.0, 0.0)
Camera.PointAt(763.8198, -35.703, 1001.3, 2)
gosub @GYMSF_5567 
00BC: show_text_highpriority GXT 'KUNG_5' time 4000 flag 1  //
040D: unload_wav 1 
03CF: load_wav 21204 as 1 

:GYMSF_3612
if 
83D0:   not wav 1 loaded 
jf @GYMSF_3655 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_3648 

:GYMSF_3648
jump @GYMSF_3612 

:GYMSF_3655
03D1: play_wav 1 
wait 1000 
TIMERA = 0 

:GYMSF_3671
if 
  2000 > TIMERA 
jf @GYMSF_3718 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_3711 

:GYMSF_3711
jump @GYMSF_3671 

:GYMSF_3718
Camera.SetPosition(767.428, -39.4061, 1000.416, 0.0, 0.0, 0.0)
Camera.PointAt(768.1919, -38.7609, 1000.4, 2)
00BC: show_text_highpriority GXT 'GYM1_97' time 2000 flag 1  //
TIMERA = 0 

:GYMSF_3792
if 
  2000 > TIMERA 
jf @GYMSF_3839 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_3832 

:GYMSF_3832
jump @GYMSF_3792 

:GYMSF_3839
040D: unload_wav 1 
03CF: load_wav 21205 as 1 

:GYMSF_3850
if 
83D0:   not wav 1 loaded 
jf @GYMSF_3893 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_3886 

:GYMSF_3886
jump @GYMSF_3850 

:GYMSF_3893
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_94' time 4000 flag 1  //
TIMERA = 0 

:GYMSF_3920
if 
  4000 > TIMERA 
jf @GYMSF_3967 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_3960 

:GYMSF_3960
jump @GYMSF_3920 

:GYMSF_3967
if 
   not Actor.Dead(38@)
jf @GYMSF_4022 
0605: actor 38@ perform_animation ""FIGHTC_M"" IFP ""FIGHT_C"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMSF_4022
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_4070 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMSF_4070
TIMERA = 0 

:GYMSF_4077
if 
  3000 > TIMERA 
jf @GYMSF_4124 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4117 

:GYMSF_4117
jump @GYMSF_4077 

:GYMSF_4124
if 
840C:   not is_german_game 
jf @GYMSF_4543 
Camera.SetPosition(768.0062, -35.1731, 1000.276, 0.0, 0.0, 0.0)
Camera.PointAt(768.757, -35.8325, 1000.314, 2)
00BC: show_text_highpriority GXT 'GYM1_98' time 2000 flag 1  //
TIMERA = 0 

:GYMSF_4211
if 
  2000 > TIMERA 
jf @GYMSF_4258 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4251 

:GYMSF_4251
jump @GYMSF_4211 

:GYMSF_4258
040D: unload_wav 1 
03CF: load_wav 21206 as 1 

:GYMSF_4269
if 
83D0:   not wav 1 loaded 
jf @GYMSF_4312 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4305 

:GYMSF_4305
jump @GYMSF_4269 

:GYMSF_4312
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_95' time 4000 flag 1  //
TIMERA = 0 

:GYMSF_4339
if 
  4000 > TIMERA 
jf @GYMSF_4386 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4379 

:GYMSF_4379
jump @GYMSF_4339 

:GYMSF_4386
if 
   not Actor.Dead(38@)
jf @GYMSF_4441 
0605: actor 38@ perform_animation ""FIGHTC_G"" IFP ""FIGHT_C"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMSF_4441
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_4489 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMSF_4489
TIMERA = 0 

:GYMSF_4496
if 
  3000 > TIMERA 
jf @GYMSF_4543 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4536 

:GYMSF_4536
jump @GYMSF_4496 

:GYMSF_4543
Camera.SetPosition(772.6448, -38.011, 1000.478, 0.0, 0.0, 0.0)
Camera.PointAt(771.679, -37.7522, 1000.485, 2)
00BC: show_text_highpriority GXT 'GYM1_99' time 2000 flag 1  //
TIMERA = 0 

:GYMSF_4617
if 
  2000 > TIMERA 
jf @GYMSF_4664 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4657 

:GYMSF_4657
jump @GYMSF_4617 

:GYMSF_4664
040D: unload_wav 1 
03CF: load_wav 21207 as 1 

:GYMSF_4675
if 
83D0:   not wav 1 loaded 
jf @GYMSF_4718 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4711 

:GYMSF_4711
jump @GYMSF_4675 

:GYMSF_4718
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_96' time 4000 flag 1  //
TIMERA = 0 

:GYMSF_4745
if 
  4000 > TIMERA 
jf @GYMSF_4792 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4785 

:GYMSF_4785
jump @GYMSF_4745 

:GYMSF_4792
if 
   not Actor.Dead(38@)
jf @GYMSF_4854 
Actor.LockInCurrentPosition(38@) = True
0605: actor 38@ perform_animation ""FIGHTC_3"" IFP ""FIGHT_C"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMSF_4854
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_4902 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMSF_4902
TIMERA = 0 

:GYMSF_4909
if 
  2000 > TIMERA 
jf @GYMSF_4956 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_4949 

:GYMSF_4949
jump @GYMSF_4909 

:GYMSF_4956
gosub @GYMSF_5511 
Actor.DestroyInstantly(38@)
38@ = Actor.Create(CivMale, #OMOKUNG, 768.064, -41.5728, 999.6865)
Actor.Angle(38@) = 358.0992
0618: assign_actor 38@ to_AS_pack 48@ 
060B: set_actor 38@ decision_maker_to 41@ 
07FE: set_actor 38@ fighting_style_to 6 moves 6 
36@ = Actor.Create(CivMale, #OMYKARA, 769.8199, -36.4933, 999.6865)
Actor.Angle(36@) = 95.1885
0618: assign_actor 36@ to_AS_pack 42@ 
060B: set_actor 36@ decision_maker_to 41@ 
07FE: set_actor 36@ fighting_style_to 6 moves 6 
37@ = Actor.Create(CivMale, #WMYKARA, 766.1017, -37.3952, 999.6865)
Actor.Angle(37@) = 271.1251
0618: assign_actor 37@ to_AS_pack 43@ 
060B: set_actor 37@ decision_maker_to 41@ 
07FE: set_actor 37@ fighting_style_to 6 moves 6 
gosub @GYMSF_5487 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_5214 
0792: disembark_instantly_actor " + PlayerActor + @" 
08C7: put_actor " + PlayerActor + @" at 765.9402 -41.602 999.6865 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 265.007
Player.CanMove(" + PlayerChar + @") = True
Camera.SetBehindPlayer

:GYMSF_5214
gosub @GYMSF_5567 
if 
  " + _8154 + @" == 0 
jf @GYMSF_5250 
//030C: progress_made = 1 
" + _8154 + @" = 1 

:GYMSF_5250
if 
  " + _8155 + @" == 0 
jf @GYMSF_5284 
00BC: show_text_highpriority GXT 'GYM1_93' time 3000 flag 1  //

:GYMSF_5284
07FE: set_actor " + PlayerActor + @" fighting_style_to 6 moves 6 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 
" + _8155 + @" = 1 
" + _8156 + @" = 0 
" + _8157 + @" = 0 

:GYMSF_5321
jump @GYMSF_1318 

:GYMSF_5328
return 
01E3: show_text_1number_styled GXT 'M_PASS' number 30000 time 5000 style 1  //
Player.Money(" + PlayerChar + @") += 30000
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 1 
return 

:GYMSF_5368
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMSF_5391 
07CB: set_actor " + PlayerActor + @" supporting_fire 1 

:GYMSF_5391
Model.Destroy(#WMYJG)
Model.Destroy(#OMYKARA)
Model.Destroy(#WMYLG)
Model.Destroy(#OMOKUNG)
Model.Destroy(#WMYKARA)
04EF: release_animation ""GYMNASIUM"" 
04EF: release_animation ""PARK"" 
04EF: release_animation ""FIGHT_C"" 
040D: unload_wav 4 
" + ONMISSION_GYMFIGHT + @" = 0 
" + OnMission + @" = 0 
mission_cleanup 
return 

:GYMSF_5467
02A3: enable_widescreen 1 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
return 

:GYMSF_5487
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
return 

:GYMSF_5511
fade 0 500 

:GYMSF_5518
if 
fading 
jf @GYMSF_5565 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMSF_5558 
fade 0 1 

:GYMSF_5558
jump @GYMSF_5518 

:GYMSF_5565
return 

:GYMSF_5567
fade 1 500 

:GYMSF_5574
if 
fading 
jf @GYMSF_5598 
wait 0 
jump @GYMSF_5574 

:GYMSF_5598
return 
040D: unload_wav 1 
03CF: load_wav 62@ as 1 
63@ = 0 
return 

:GYMSF_5620
if and
03D0:   wav 1 loaded 
  63@ == 0 
jf @GYMSF_5663 
03D1: play_wav 1 
00BC: show_text_highpriority GXT 60@s time 10000 flag 1 
63@ = 1 

:GYMSF_5663
if and
03D2:   wav 1 ended 
  63@ == 1 
jf @GYMSF_5701 
040D: unload_wav 1 
03D5: remove_text 60@s 
63@ = 2 

:GYMSF_5701
return" );
            }

        }

        private sealed class GYMLV : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @GYMLV_57
0169: set_fade_color_RGB 0 0 0 
if 
wasted_or_busted 
jf @GYMLV_46 
gosub @GYMLV_5200 

:GYMLV_46
gosub @GYMLV_5240 
end_thread 
increment_mission_attempts 

:GYMLV_57
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_80 
07CB: set_actor " + PlayerActor + @" supporting_fire 0 

:GYMLV_80
" + ONMISSION_GYMFIGHT + @" = 1 
" + OnMission + @" = 1 
0623: add 1 to_integer_stat 198 
054C: use_GXT_table 'GYM' 
Model.Load(#VBMYBOX)
Model.Load(#VWMYBOX)
Model.Load(#BMYDJ)
04ED: load_animation ""RIOT"" 
04ED: load_animation ""FIGHT_D"" 
04ED: load_animation ""GYMNASIUM"" 
04ED: load_animation ""INT_SHOP"" 
038B: load_requested_models 

:GYMLV_170
if or
84EE:   not animation ""GYMNASIUM"" loaded 
   not Model.Available(#VBMYBOX)
   not Model.Available(#VWMYBOX)
jf @GYMLV_213 
wait 0 
jump @GYMLV_170 

:GYMLV_213
if or
   not Model.Available(#BMYDJ)
84EE:   not animation ""RIOT"" loaded 
84EE:   not animation ""FIGHT_D"" loaded 
84EE:   not animation ""INT_SHOP"" loaded 
jf @GYMLV_270 
wait 0 
jump @GYMLV_213 

:GYMLV_270
060A: create_decision_maker_type 0 store_to 41@ 
060A: create_decision_maker_type 2 store_to 51@ 
0746: set_acquaintance 4 of_actors_pedtype 24 to_actors_pedtype 0 
0615: define_AS_pack_begin 63@ 
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
05B9: AS_actor -1 stay_idle 1000 ms 
0643: set_AS_pack 63@ loop 1 
0616: define_AS_pack_end 63@ 
0615: define_AS_pack_begin 64@ 
05B9: AS_actor -1 stay_idle 500 ms 
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
0643: set_AS_pack 64@ loop 1 
0616: define_AS_pack_end 64@ 
0615: define_AS_pack_begin 65@ 
05B9: AS_actor -1 stay_idle 750 ms 
0605: actor -1 perform_animation ""RIOT_SHOUT"" IFP ""RIOT"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0639: AS_actor -1 rotate_to_actor " + PlayerActor + @" 
0643: set_AS_pack 65@ loop 1 
0616: define_AS_pack_end 65@ 
0615: define_AS_pack_begin 52@ 
0603: AS_actor -1 goto_point_any_means 773.8429 -61.5409 999.7184 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 93.0279 
0605: actor -1 perform_animation ""GYMSHADOWBOX"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 52@ 
0615: define_AS_pack_begin 53@ 
0603: AS_actor -1 goto_point_any_means 771.2518 -69.3033 999.6562 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 85.5162 
0616: define_AS_pack_end 53@ 
0615: define_AS_pack_begin 54@ 
0603: AS_actor -1 goto_point_any_means 762.3508 -78.2144 999.6562 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 359.2498 
0605: actor -1 perform_animation ""SHOP_PAY"" IFP ""INT_SHOP"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 54@ 
0615: define_AS_pack_begin 48@ 
0603: AS_actor -1 goto_point_any_means 762.3508 -78.2144 999.6562 mode 4 use_car -1 
05D4: AS_actor -1 rotate_angle 359.2498 
0605: actor -1 perform_animation ""SHOP_PAY"" IFP ""INT_SHOP"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 48@ loop 1 
0616: define_AS_pack_end 48@ 
34@ = Actor.Create(CivMale, #VWMYBOX, 762.3508, -78.2144, 999.6562)
Actor.Angle(34@) = 359.2498
060B: set_actor 34@ decision_maker_to 51@ 
0618: assign_actor 34@ to_AS_pack 48@ 
07FE: set_actor 34@ fighting_style_to 7 moves 6 
36@ = Actor.Create(CivMale, #VWMYBOX, 766.2026, -69.2071, 1000.569)
Actor.Angle(36@) = 330.7023
060B: set_actor 36@ decision_maker_to 41@ 
37@ = Actor.Create(CivMale, #VBMYBOX, 767.1087, -67.9132, 1000.569)
Actor.Angle(37@) = 129.3961
060B: set_actor 37@ decision_maker_to 41@ 
0615: define_AS_pack_begin 42@ 
05B9: AS_actor -1 stay_idle 1000 ms 
0605: actor -1 perform_animation ""GYMSHADOWBOX"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 42@ 
0615: define_AS_pack_begin 43@ 
0605: actor -1 perform_animation ""GYMSHADOWBOX"" IFP ""GYMNASIUM"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 43@ 
0618: assign_actor 36@ to_AS_pack 42@ 
0618: assign_actor 37@ to_AS_pack 43@ 
040D: unload_wav 4 
03CF: load_wav 1820 as 4 

:GYMLV_1078
if 
83D0:   not wav 4 loaded 
jf @GYMLV_1104 
wait 0 
jump @GYMLV_1078 

:GYMLV_1104
62@ = 2 
if or
001C:   " + Current_Month_Day + @" > " + GYM_Month_Day_When_Limit_Reached + @" 
001C:   " + Current_Month + @" > " + GYM_Month_When_Limit_Reached + @" 
jf @GYMLV_1148 
" + GYM_Day_Limit + @" = 0.0 

:GYMLV_1148
wait 0 
gosub @GYMLV_5494 
if 
  57@ == 0 
jf @GYMLV_1279 
if 
   Actor.Dead(36@)
jf @GYMLV_1228 
if 
   not Actor.Dead(37@)
jf @GYMLV_1228 
0792: disembark_instantly_actor 37@ 
05C5: AS_actor 37@ cower -2 ms 
57@ = 1 

:GYMLV_1228
if 
   Actor.Dead(37@)
jf @GYMLV_1279 
if 
   not Actor.Dead(36@)
jf @GYMLV_1279 
0792: disembark_instantly_actor 36@ 
05C5: AS_actor 36@ cower -2 ms 
57@ = 1 

:GYMLV_1279
09E8: " + Active_Interior + @" = actor " + PlayerActor + @" active_interior 
if 
  " + Active_Interior + @" == 0 
jf @GYMLV_1312 
jump @GYMLV_5200 

:GYMLV_1312
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 763.3589 -76.7606 999.6562 radius 2.5 2.5 4.0 
jf @GYMLV_1367 
45@ = 0 

:GYMLV_1367
if 
   not Actor.Dead(34@)
jf @GYMLV_5193 
if and
  45@ == 0 
00FE:   actor 34@ sphere 0 in_sphere 762.3508 -78.2144 999.6562 radius 1.0 1.0 1.2 
jf @GYMLV_5193 
if 
0101:   actor " + PlayerActor + @" in_sphere 763.3589 -76.7606 999.6562 radius 0.6 0.6 1.0 sphere 1 stopped 
jf @GYMLV_1486 

:GYMLV_1486
if and
0101:   actor " + PlayerActor + @" in_sphere 763.3589 -76.7606 999.6562 radius 1.2 1.2 1.2 sphere 0 stopped 
   not Actor.Dead(34@)
jf @GYMLV_5193 
if and
   not Actor.Dead(34@)
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_1593 
Player.CanMove(" + PlayerChar + @") = False
0792: disembark_instantly_actor " + PlayerActor + @" 
0687: clear_actor 34@ task 
0639: AS_actor 34@ rotate_to_actor " + PlayerActor + @" 
0639: AS_actor " + PlayerActor + @" rotate_to_actor 34@ 

:GYMLV_1593
if 
  " + _8157 + @" == 0 
jf @GYMLV_1670 
040D: unload_wav 1 
03CF: load_wav 43400 as 1 

:GYMLV_1624
if 
83D0:   not wav 1 loaded 
jf @GYMLV_1650 
wait 0 
jump @GYMLV_1624 

:GYMLV_1650
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'WBOX_1' time 3000 flag 1  

:GYMLV_1670
if 
  " + _8157 + @" == 1 
jf @GYMLV_1747 
040D: unload_wav 1 
03CF: load_wav 43403 as 1 

:GYMLV_1701
if 
83D0:   not wav 1 loaded 
jf @GYMLV_1727 
wait 0 
jump @GYMLV_1701 

:GYMLV_1727
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'WBOX_4' time 3000 flag 1  

:GYMLV_1747
0512: show_permanent_text_box 'GYM1_73'  

:GYMLV_1758
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_2062 
wait 0 
if 
00E1:   player 0 pressed_key 11 
jf @GYMLV_1949 
0653: 58@ = float_stat 23 
if 
  58@ > 349.0 
jf @GYMLV_1846 
44@ = 1 
03E6: remove_text_box 
jump @GYMLV_2064 
jump @GYMLV_1949 

:GYMLV_1846
44@ = 0 
45@ = 1 
03E6: remove_text_box 
040D: unload_wav 1 
03CF: load_wav 43402 as 1 

:GYMLV_1875
if 
83D0:   not wav 1 loaded 
jf @GYMLV_1901 
wait 0 
jump @GYMLV_1875 

:GYMLV_1901
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'WBOX_3' time 3000 flag 1  
Player.CanMove(" + PlayerChar + @") = True
TIMERA = 0 
55@ = 1 
jump @GYMLV_1148 

:GYMLV_1949
if 
00E1:   player 0 pressed_key 10 
jf @GYMLV_2055 
44@ = 0 
45@ = 1 
03E6: remove_text_box 
040D: unload_wav 1 
03CF: load_wav 43401 as 1 

:GYMLV_1995
if 
83D0:   not wav 1 loaded 
jf @GYMLV_2021 
wait 0 
jump @GYMLV_1995 

:GYMLV_2021
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'WBOX_2' time 3000 flag 1  
Player.CanMove(" + PlayerChar + @") = True
jump @GYMLV_1148 

:GYMLV_2055
jump @GYMLV_1758 

:GYMLV_2062
03E6: remove_text_box 

:GYMLV_2064
03E6: remove_text_box 
00BE: text_clear_all 
0992: set_player " + PlayerChar + @" weapons_scrollable 0 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
if 
  44@ == 1 
jf @GYMLV_5193 
gosub @GYMLV_5385 
Actor.DestroyInstantly(36@)
Actor.DestroyInstantly(37@)
Actor.DestroyInstantly(34@)
36@ = Actor.Create(CivMale, #VBMYBOX, 767.9493, -64.6707, 999.6562)
Actor.Angle(36@) = 166.9465
0618: assign_actor 36@ to_AS_pack 63@ 
37@ = Actor.Create(CivMale, #VWMYBOX, 770.7913, -67.3238, 999.6562)
Actor.Angle(37@) = 90.0184
0618: assign_actor 37@ to_AS_pack 64@ 
38@ = Actor.Create(CivMale, #VBMYBOX, 770.4339, -69.5049, 999.6562)
Actor.Angle(38@) = 91.3393
0618: assign_actor 38@ to_AS_pack 65@ 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_2392 
0792: disembark_instantly_actor " + PlayerActor + @" 
34@ = Actor.Create(Mission1, #VWMYBOX, 768.2548, -67.2063, 1000.569)
Actor.Angle(34@) = 145.0
Actor.Health(34@) = 1000
Actor.SetMaxHealth(34@, 1000)
08C7: put_actor " + PlayerActor + @" at 764.8033 -70.2273 1000.569 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 310.0
060B: set_actor 34@ decision_maker_to 51@ 
05E2: AS_actor 34@ kill_actor " + PlayerActor + @" 
07FE: set_actor 34@ fighting_style_to 7 moves 6 
07DD: set_actor 34@ attack_rate 100 
Camera.Restore_WithJumpCut
Camera.SetBehindPlayer
gosub @GYMLV_5441 

:GYMLV_2392
Player.CanMove(" + PlayerChar + @") = True
if 
  " + _8157 + @" == 0 
jf @GYMLV_2428 
0512: show_permanent_text_box 'GYM1101'  

:GYMLV_2428
if 
  " + _8157 + @" == 1 
jf @GYMLV_2457 
0512: show_permanent_text_box 'GYM1_84'  

:GYMLV_2457
gosub @GYMLV_5441 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if and
03D0:   wav 4 loaded 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_2506 
09F1: play_audio_at_actor " + PlayerActor + @" event 1115 

:GYMLV_2506
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_3164 
wait 0 
if 
  " + _8157 + @" == 1 
jf @GYMLV_2810 
if 
  56@ == 0 
jf @GYMLV_2589 
TIMERA = 0 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_94'  
56@ = 1 

:GYMLV_2589
if 
840C:   not is_german_game 
jf @GYMLV_2715 
if and
  TIMERA > 6000 
  56@ == 1 
jf @GYMLV_2655 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_95'  
TIMERA = 0 
56@ = 2 

:GYMLV_2655
if and
  TIMERA > 6000 
  56@ == 2 
jf @GYMLV_2708 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_96'  
TIMERA = 0 
56@ = 3 

:GYMLV_2708
jump @GYMLV_2768 

:GYMLV_2715
if and
  TIMERA > 6000 
  56@ == 1 
jf @GYMLV_2768 
03E6: remove_text_box 
0512: show_permanent_text_box 'GYM1_96'  
TIMERA = 0 
56@ = 3 

:GYMLV_2768
if and
  TIMERA > 6000 
  56@ == 3 
jf @GYMLV_2810 
03E6: remove_text_box 
TIMERA = 0 
56@ = 0 

:GYMLV_2810
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_2840 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:GYMLV_2840
if 
   Actor.Dead(34@)
jf @GYMLV_2863 
jump @GYMLV_3164 

:GYMLV_2863
if 
  1000.7 > " + tempvar_Float_3 + @" 
jf @GYMLV_3157 
gosub @GYMLV_5385 
Actor.DestroyInstantly(34@)
Actor.DestroyInstantly(36@)
Actor.DestroyInstantly(37@)
Actor.DestroyInstantly(38@)
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_2962 
0792: disembark_instantly_actor " + PlayerActor + @" 
08C7: put_actor " + PlayerActor + @" at 762.854 -69.5929 999.6562 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 103.4243

:GYMLV_2962
34@ = Actor.Create(CivMale, #VWMYBOX, 762.3508, -78.2144, 999.6562)
Actor.Angle(34@) = 359.2498
060B: set_actor 34@ decision_maker_to 41@ 
0618: assign_actor 34@ to_AS_pack 48@ 
07FE: set_actor 34@ fighting_style_to 7 moves 6 
36@ = Actor.Create(CivMale, #VWMYBOX, 766.2026, -69.2071, 1000.569)
Actor.Angle(36@) = 330.7023
0618: assign_actor 36@ to_AS_pack 42@ 
37@ = Actor.Create(CivMale, #VBMYBOX, 767.1087, -67.9132, 1000.569)
Actor.Angle(37@) = 129.3961
0618: assign_actor 37@ to_AS_pack 43@ 
00BE: text_clear_all 
03E6: remove_text_box 
gosub @GYMLV_5441 
if 
  " + _8157 + @" == 0 
jf @GYMLV_3150 
00BC: show_text_highpriority GXT 'GYM1_92' time 5000 flag 1  

:GYMLV_3150
jump @GYMLV_1148 

:GYMLV_3157
jump @GYMLV_2506 

:GYMLV_3164
03E6: remove_text_box 
if 
  " + _8157 + @" == 1 
jf @GYMLV_3191 
jump @GYMLV_4847 

:GYMLV_3191
gosub @GYMLV_5385 
gosub @GYMLV_5341 
0395: clear_area 1 at 768.2548 -67.2063 1000.569 radius 10.0 
Actor.DestroyInstantly(34@)
Actor.DestroyInstantly(36@)
Actor.DestroyInstantly(37@)
Actor.DestroyInstantly(38@)
34@ = Actor.Create(CivMale, #VWMYBOX, 768.2548, -67.2063, 1000.569)
060B: set_actor 34@ decision_maker_to 41@ 
07FE: set_actor 34@ fighting_style_to 7 moves 6 
if and
   not Actor.Dead(34@)
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_3381 
0792: disembark_instantly_actor " + PlayerActor + @" 
0687: clear_actor 34@ task 
08C7: put_actor " + PlayerActor + @" at 764.8033 -70.2273 1000.569 dont_warp_gang 
08C7: put_actor 34@ at 768.2548 -67.2063 1000.569 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 310.0
Actor.Angle(34@) = 145.0

:GYMLV_3381
Camera.SetPosition(765.1049, -74.2975, 1003.591, 0.0, 0.0, 0.0)
Camera.PointAt(765.3495, -73.4547, 1003.112, 2)
gosub @GYMLV_5441 
00BC: show_text_highpriority GXT 'WBOX_5' time 4000 flag 1  
040D: unload_wav 1 
03CF: load_wav 43404 as 1 

:GYMLV_3468
if 
83D0:   not wav 1 loaded 
jf @GYMLV_3511 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_3504 

:GYMLV_3504
jump @GYMLV_3468 

:GYMLV_3511
03D1: play_wav 1 
wait 1000 
TIMERA = 0 

:GYMLV_3527
if 
  2000 > TIMERA 
jf @GYMLV_3574 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_3567 

:GYMLV_3567
jump @GYMLV_3527 

:GYMLV_3574
Camera.SetPosition(767.7358, -70.2958, 1001.493, 0.0, 0.0, 0.0)
Camera.PointAt(767.9329, -69.3157, 1001.47, 2)
00BC: show_text_highpriority GXT 'GYM1_97' time 2000 flag 1  
TIMERA = 0 

:GYMLV_3648
if 
  2000 > TIMERA 
jf @GYMLV_3695 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_3688 

:GYMLV_3688
jump @GYMLV_3648 

:GYMLV_3695
040D: unload_wav 1 
03CF: load_wav 43405 as 1 

:GYMLV_3708
if 
83D0:   not wav 1 loaded 
jf @GYMLV_3751 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_3744 

:GYMLV_3744
jump @GYMLV_3708 

:GYMLV_3751
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_94' time 4000 flag 1  
TIMERA = 0 

:GYMLV_3778
if 
  4000 > TIMERA 
jf @GYMLV_3825 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_3818 

:GYMLV_3818
jump @GYMLV_3778 

:GYMLV_3825
if 
   not Actor.Dead(34@)
jf @GYMLV_3880 
0605: actor 34@ perform_animation ""FIGHTD_M"" IFP ""FIGHT_D"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLV_3880
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_3928 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLV_3928
TIMERA = 0 

:GYMLV_3935
if 
  3000 > TIMERA 
jf @GYMLV_3982 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_3975 

:GYMLV_3975
jump @GYMLV_3935 

:GYMLV_3982
if 
840C:   not is_german_game 
jf @GYMLV_4403 
Camera.SetPosition(765.0073, -67.3258, 1001.465, 0.0, 0.0, 0.0)
Camera.PointAt(766.0051, -67.2777, 1001.419, 2)
00BC: show_text_highpriority GXT 'GYM1_98' time 2000 flag 1  
TIMERA = 0 

:GYMLV_4069
if 
  2000 > TIMERA 
jf @GYMLV_4116 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4109 

:GYMLV_4109
jump @GYMLV_4069 

:GYMLV_4116
040D: unload_wav 1 
03CF: load_wav 43406 as 1 

:GYMLV_4129
if 
83D0:   not wav 1 loaded 
jf @GYMLV_4172 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4165 

:GYMLV_4165
jump @GYMLV_4129 

:GYMLV_4172
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_95' time 4000 flag 1  
TIMERA = 0 

:GYMLV_4199
if 
  4000 > TIMERA 
jf @GYMLV_4246 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4239 

:GYMLV_4239
jump @GYMLV_4199 

:GYMLV_4246
if 
   not Actor.Dead(34@)
jf @GYMLV_4301 
0605: actor 34@ perform_animation ""FIGHTD_G"" IFP ""FIGHT_D"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLV_4301
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_4349 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLV_4349
TIMERA = 0 

:GYMLV_4356
if 
  3000 > TIMERA 
jf @GYMLV_4403 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4396 

:GYMLV_4396
jump @GYMLV_4356 

:GYMLV_4403
Camera.SetPosition(770.4639, -65.7272, 1002.231, 0.0, 0.0, 0.0)
Camera.PointAt(769.6946, -66.3243, 1002.003, 2)
00BC: show_text_highpriority GXT 'GYM1_99' time 2000 flag 1  
if and
   not Actor.Dead(34@)
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_4499 
0639: AS_actor 34@ rotate_to_actor " + PlayerActor + @" 

:GYMLV_4499
TIMERA = 0 

:GYMLV_4506
if 
  2000 > TIMERA 
jf @GYMLV_4553 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4546 

:GYMLV_4546
jump @GYMLV_4506 

:GYMLV_4553
040D: unload_wav 1 
03CF: load_wav 43407 as 1 

:GYMLV_4566
if 
83D0:   not wav 1 loaded 
jf @GYMLV_4609 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4602 

:GYMLV_4602
jump @GYMLV_4566 

:GYMLV_4609
03D1: play_wav 1 
00BC: show_text_highpriority GXT 'GYM1_96' time 4000 flag 1  
TIMERA = 0 

:GYMLV_4636
if 
  4000 > TIMERA 
jf @GYMLV_4683 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4676 

:GYMLV_4676
jump @GYMLV_4636 

:GYMLV_4683
if 
   not Actor.Dead(34@)
jf @GYMLV_4745 
Actor.LockInCurrentPosition(34@) = True
0605: actor 34@ perform_animation ""FIGHTD_3"" IFP ""FIGHT_D"" framedelta 4.0 loop 0 lockX 1 lockY 1 lockF 0 time -1 

:GYMLV_4745
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_4793 
0605: actor " + PlayerActor + @" perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 1 time -1 

:GYMLV_4793
TIMERA = 0 

:GYMLV_4800
if 
  2000 > TIMERA 
jf @GYMLV_4847 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_4840 

:GYMLV_4840
jump @GYMLV_4800 

:GYMLV_4847
gosub @GYMLV_5385 
if 
  " + _8158 + @" == 0 
jf @GYMLV_4883 
//030C: progress_made = 1 
" + _8158 + @" = 1 

:GYMLV_4883
Actor.DestroyInstantly(34@)
Actor.DestroyInstantly(36@)
Actor.DestroyInstantly(37@)
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_4949 
0792: disembark_instantly_actor " + PlayerActor + @" 
08C7: put_actor " + PlayerActor + @" at 762.854 -69.5929 999.6562 dont_warp_gang 
Actor.Angle(" + PlayerActor + @") = 103.4243

:GYMLV_4949
34@ = Actor.Create(CivMale, #VWMYBOX, 762.3508, -78.2144, 999.6562)
Actor.Angle(34@) = 359.2498
060B: set_actor 34@ decision_maker_to 51@ 
0618: assign_actor 34@ to_AS_pack 48@ 
07FE: set_actor 34@ fighting_style_to 7 moves 6 
36@ = Actor.Create(CivMale, #VWMYBOX, 766.2026, -69.2071, 1000.569)
Actor.Angle(36@) = 330.7023
0618: assign_actor 36@ to_AS_pack 42@ 
060B: set_actor 36@ decision_maker_to 41@ 
37@ = Actor.Create(CivMale, #VBMYBOX, 767.1087, -67.9132, 1000.569)
Actor.Angle(37@) = 129.3961
0618: assign_actor 37@ to_AS_pack 43@ 
060B: set_actor 37@ decision_maker_to 41@ 
gosub @GYMLV_5361 
gosub @GYMLV_5441 
07FE: set_actor " + PlayerActor + @" fighting_style_to 7 moves 6 
if 
  " + _8157 + @" == 0 
jf @GYMLV_5165 
00BC: show_text_highpriority GXT 'GYM1_93' time 3000 flag 1  

:GYMLV_5165
" + _8155 + @" = 0 
" + _8156 + @" = 0 
" + _8157 + @" = 1 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 

:GYMLV_5193
jump @GYMLV_1148 

:GYMLV_5200
return 
01E3: show_text_1number_styled GXT 'M_PASS' number 30000 time 5000 style 1  
Player.Money(" + PlayerChar + @") += 30000
Player.ClearWantedLevel(" + PlayerChar + @")
0394: play_music 1 
return 

:GYMLV_5240
if 
   not Actor.Dead(" + PlayerActor + @")
jf @GYMLV_5263 
07CB: set_actor " + PlayerActor + @" supporting_fire 1 

:GYMLV_5263
Model.Destroy(#VBMYBOX)
Model.Destroy(#VWMYBOX)
Model.Destroy(#BMYDJ)
04EF: release_animation ""GYMNASIUM"" 
04EF: release_animation ""RIOT"" 
04EF: release_animation ""FIGHT_D"" 
04EF: release_animation ""INT_SHOP"" 
040D: unload_wav 4 
" + ONMISSION_GYMFIGHT + @" = 0 
" + OnMission + @" = 0 
mission_cleanup 
return 

:GYMLV_5341
02A3: enable_widescreen 1 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
return 

:GYMLV_5361
Camera.SetBehindPlayer
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
Camera.Restore_WithJumpCut
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
return 

:GYMLV_5385
fade 0 500 

:GYMLV_5392
if 
fading 
jf @GYMLV_5439 
wait 0 
if 
00E1:   player 0 pressed_key 16 
jf @GYMLV_5432 
fade 0 1 

:GYMLV_5432
jump @GYMLV_5392 

:GYMLV_5439
return 

:GYMLV_5441
fade 1 500 

:GYMLV_5448
if 
fading 
jf @GYMLV_5472 
wait 0 
jump @GYMLV_5448 

:GYMLV_5472
return 
040D: unload_wav 1 
03CF: load_wav 61@ as 1 
62@ = 0 
return 

:GYMLV_5494
if and
03D0:   wav 1 loaded 
  62@ == 0 
jf @GYMLV_5537 
03D1: play_wav 1 
00BC: show_text_highpriority GXT 59@s time 10000 flag 1 
62@ = 1 

:GYMLV_5537
if and
03D2:   wav 1 ended 
  62@ == 1 
jf @GYMLV_5575 
040D: unload_wav 1 
03D5: remove_text 59@s 
62@ = 2 

:GYMLV_5575
return" );
            }

        }

    }

}