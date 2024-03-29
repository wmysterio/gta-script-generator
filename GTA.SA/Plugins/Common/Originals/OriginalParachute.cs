﻿using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalParachute : Original {

        internal OriginalParachute() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            _1500.value = 5.0;
            _1501.value = -5.0;
            _1503.value = -1.5;
            _1504.value = -30.0;
            _1505.value = 32.0;
        }
        internal override void Update() {
            Script.and( Script.PlayerActor.is_has_weapon( 46 ), delegate {
                Script.get_external_script_status<PLCHUTE>( Original.ScriptStatus );
                Script.and( Original.ScriptStatus == 0, delegate {
                    Script.load_external_script<PLCHUTE>();
                    Script.and( Script.is_external_script_loaded<PLCHUTE>(), delegate {
                        Script.start_new_external_script<PLCHUTE>();
                    } );
                } );
            }, delegate { Script.remove_references_external_script<PLCHUTE>(); } );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class PLCHUTE : External {

            public override void START( LabelJump label ) {
                AppendLine( @"Model.Load(#GUN_PARA)

:PLCHUTE_16
if 
    not Model.Available(#GUN_PARA)
jf @PLCHUTE_43 
wait 0 
jump @PLCHUTE_16 

:PLCHUTE_43
if 
    not Actor.Dead(" + PlayerActor + @")
jf @PLCHUTE_59 

:PLCHUTE_59
" + _1498 + @" = 0 
" + FreeFall_Stage + @" = 0 
" + Parachute_Creation_Stage + @" = 0 
if 
    " + _1498 + @" == 999 
jf @PLCHUTE_118 
" + Pickup_Parachute + @" = Pickup.Create(#GUN_PARA, 3, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")

:PLCHUTE_118
wait 0 
if 
    not Actor.Dead(" + PlayerActor + @")
jf @PLCHUTE_5455 
if 
8800:   not in_two_players_mode 
jf @PLCHUTE_5455 
if 
    not " + FreeFall_Stage + @" == 0 
jf @PLCHUTE_176 
0992: set_player " + PlayerChar + @" weapons_scrollable 0 

:PLCHUTE_176
if 
    " + Parachute_Creation_Stage + @" > 0 
jf @PLCHUTE_219 
if 
    not Actor.HasWeapon(" + PlayerActor + @", 46)
jf @PLCHUTE_219 
gosub @PLCHUTE_5521 

:PLCHUTE_219
if 
    " + Parachute_Creation_Stage + @" == 0 
jf @PLCHUTE_274 
if 
    Actor.HasWeapon(" + PlayerActor + @", 46)
jf @PLCHUTE_274 
Model.Load(#PARACHUTE)
" + Parachute_Creation_Stage + @" = 1 
" + _1498 + @" = 0 

:PLCHUTE_274
if 
    " + Parachute_Creation_Stage + @" == 1 
jf @PLCHUTE_377 
if 
    Model.Available(#PARACHUTE)
jf @PLCHUTE_377 
17@ = Object.Create(#PARACHUTE, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
069B: attach_object 17@ to_actor " + PlayerActor + @" with_offset 0.0 0.0 0.0 rotation 0.0 0.0 0.0 
0750: set_object 17@ visibility 0 
" + Parachute_Creation_Stage + @" = 2 

:PLCHUTE_377
if and
    " + Parachute_Creation_Stage + @" == 2 
    " + FreeFall_Stage + @" == 1 
jf @PLCHUTE_409 
" + Parachute_Creation_Stage + @" = 3 

:PLCHUTE_409
if and
    " + FreeFall_Stage + @" == 0 
    " + Parachute_Creation_Stage + @" > 0 
jf @PLCHUTE_565 
if 
0818:   actor " + PlayerActor + @" in_air 
jf @PLCHUTE_565 
083D: get_actor " + PlayerActor + @" velocity_in_direction_XYZ " + _1507 + @" " + _1508 + @" " + _1509 + @" 
if 
    -10.0 > " + _1509 + @" 
jf @PLCHUTE_565 
0819: 7@ = actor " + PlayerActor + @" distance_from_ground 
if 
    7@ > 20.0 
jf @PLCHUTE_565 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1037 
" + FreeFall_Stage + @" = 1 
01B9: set_actor " + PlayerActor + @" armed_weapon_to 46 
0@ = 0 
" + _8268 + @" = 0.0 

:PLCHUTE_565
if 
    " + FreeFall_Stage + @" == 1 
jf @PLCHUTE_2386 
if 
    0@ == 0 
jf @PLCHUTE_608 
0@ = 2 

:PLCHUTE_608
if 
    0@ == 2 
jf @PLCHUTE_729 
062E: get_actor " + PlayerActor + @" task 2066 status_store_to 27@ // ret 7 if not found 
if 
04A4:   27@ == 7 // == constant 
jf @PLCHUTE_729 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE"" IFP ""PED"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 // versionB 
04ED: load_animation ""PARACHUTE"" 
15@ = 1 
1@ = Actor.Angle(" + PlayerActor + @")
0@ = 3 

:PLCHUTE_729
if 
    0@ == 3 
jf @PLCHUTE_2386 
062E: get_actor " + PlayerActor + @" task 2066 status_store_to 27@ // ret 7 if not found 
if 
04A4:   27@ == 7 // == constant 
jf @PLCHUTE_815 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE"" IFP ""PED"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 // versionB 

:PLCHUTE_815
0819: 7@ = actor " + PlayerActor + @" distance_from_ground 
if and
    100.0 > 7@ 
    7@ > 60.0 
jf @PLCHUTE_912 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_912 
if 
    " + OnMission + @" == 0 
jf @PLCHUTE_912 
00BC: show_text_highpriority GXT 'PARA_01' time 1000 flag 1  // ~s~O¦kpЁўaќ ЈapaҐ«¦!

:PLCHUTE_912
0494: get_joystick 0 direction_offset_to 10@ 11@ 12@ 12@ 
if 
    " + _1511 + @" == 1 
jf @PLCHUTE_960 
10@ = 0 
11@ = 0 

:PLCHUTE_960
0093: 21@ = integer 10@ to_float 
21@ /= 4.267 
0063: 21@ -= 2@ // (float) 
21@ /= 20.0 
005B: 2@ += 21@ // (float) 
0087: 21@ = 2@ // (float) 
21@ /= 5.0 
0063: 1@ -= 21@ // (float) 
if 
    1@ > 180.0 
jf @PLCHUTE_1061 
1@ -= 360.0 

:PLCHUTE_1061
if 
    -180.0 > 1@ 
jf @PLCHUTE_1092 
1@ += 360.0 

:PLCHUTE_1092
0093: 22@ = integer 11@ to_float 
22@ /= 4.267 
0063: 22@ -= 3@ // (float) 
22@ /= 20.0 
005B: 3@ += 22@ // (float) 
083D: get_actor " + PlayerActor + @" velocity_in_direction_XYZ 8@ 9@ " + _1509 + @" 
if 
0024:   " + _1504 + @" > " + _1509 + @" // (float) 
jf @PLCHUTE_1177 
0086: " + _1509 + @" = " + _1504 + @" // (float) 

:PLCHUTE_1177
if 
0024:   " + _8268 + @" > " + _1509 + @" // (float) 
jf @PLCHUTE_1204 
0086: " + _8268 + @" = " + _1509 + @" // (float) 

:PLCHUTE_1204
if 
0024:   " + _1504 + @" > " + _8268 + @" // (float) 
jf @PLCHUTE_1231 
0086: " + _8268 + @" = " + _1504 + @" // (float) 

:PLCHUTE_1231
if and
0024:   " + _1509 + @" > " + _8268 + @" // (float) 
    not " + _1902 + @" == 1 
jf @PLCHUTE_1407 
if 
84AD:   not actor " + PlayerActor + @" in_water 
jf @PLCHUTE_1361 
if 
    -20.0 > " + _8268 + @" 
jf @PLCHUTE_1308 
" + FreeFall_Stage + @" = 2 
jump @PLCHUTE_1354 

:PLCHUTE_1308
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE"" IFP ""PED"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 0 time 100 // versionB 
" + FreeFall_Stage + @" = 7 

:PLCHUTE_1354
jump @PLCHUTE_1407 

:PLCHUTE_1361
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE"" IFP ""PED"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 0 time 100 // versionB 
" + FreeFall_Stage + @" = 7 

:PLCHUTE_1407
0087: 4@ = 3@ // (float) 
4@ /= 30.0 
006F: 4@ *= " + _1505 + @" // (float) 
02F6: " + _1507 + @" = sine 1@ // (float) 
02F7: " + _1508 + @" = cosine 1@ // (float) 
006D: " + _1507 + @" *= 4@ // (float) 
006D: " + _1508 + @" *= 4@ // (float) 
" + _1508 + @" *= -1.0 
0059: " + _1508 + @" += " + _1506 + @" // (float) 
0087: 21@ = 8@ // (float) 
0065: 21@ -= " + _1507 + @" // (float) 
21@ *= 0.01 
0088: " + _1507 + @" = 8@ // (float) 
0067: " + _1507 + @" -= 21@ // (float) 
0087: 21@ = 9@ // (float) 
0065: 21@ -= " + _1508 + @" // (float) 
21@ *= 0.01 
0088: " + _1508 + @" = 9@ // (float) 
0067: " + _1508 + @" -= 21@ // (float) 
0085: 12@ = 10@ // (int) 
0085: 13@ = 11@ // (int) 
0095: make 12@ absolute_integer 
0095: make 13@ absolute_integer 
if or
    12@ > 40 
    13@ > 40 
jf @PLCHUTE_2109 
if 
001D:   12@ > 13@ // (int) 
jf @PLCHUTE_1872 
if 
    10@ >= 0 
jf @PLCHUTE_1751 
if 
    not 15@ == 2 
jf @PLCHUTE_1751 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_1744 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE_R"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 

:PLCHUTE_1744
15@ = 2 

:PLCHUTE_1751
if 
    0 > 10@ 
jf @PLCHUTE_1865 
if 
    not 15@ == 3 
jf @PLCHUTE_1865 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_1858 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE_L"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 

:PLCHUTE_1858
15@ = 3 

:PLCHUTE_1865
jump @PLCHUTE_2102 

:PLCHUTE_1872
if 
    11@ >= 0 
jf @PLCHUTE_1984 
if 
    not 15@ == 4 
jf @PLCHUTE_1984 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_1977 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 

:PLCHUTE_1977
15@ = 4 

:PLCHUTE_1984
if 
    0 > 11@ 
jf @PLCHUTE_2102 
if 
    not 15@ == 5 
jf @PLCHUTE_2102 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_2095 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE_ACCEL"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 

:PLCHUTE_2095
15@ = 5 

:PLCHUTE_2102
jump @PLCHUTE_2203 

:PLCHUTE_2109
if 
    not 15@ == 1 
jf @PLCHUTE_2203 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_2203 
0812: AS_actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 
15@ = 1 

:PLCHUTE_2203
if or
00E1:   player 0 pressed_key 17 
    " + _1512 + @" == 1 
jf @PLCHUTE_2386 
if 
    not " + _1902 + @" == 1 
jf @PLCHUTE_2386 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_2386 
if and
    " + Parachute_Creation_Stage + @" == 3 
    " + _1511 + @" == 0 
jf @PLCHUTE_2386 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_OPEN"" IFP ""PARACHUTE"" framedelta 8.0 loopA 0 lockX 0 lockY 0 lockF 1 time -2 // versionB 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1038 
008A: " + _8270 + @" = TIMERA // (int) 
" + _8270 + @" += 1100 
" + FreeFall_Stage + @" = 3 
0@ = 0 

:PLCHUTE_2386
if 
    " + FreeFall_Stage + @" == 2 
jf @PLCHUTE_2504 
if 
04EE:   animation ""PARACHUTE"" loaded 
jf @PLCHUTE_2492 
Actor.Angle(" + PlayerActor + @") = 1@
0829: actor " + PlayerActor + @" perform_animation ""FALL_SKYDIVE_DIE"" IFP_file ""PARACHUTE"" 1000.0 time 0 and_dies 
09F1: play_audio_at_actor " + PlayerActor + @" event 1189 
jump @PLCHUTE_2497 

:PLCHUTE_2492
05BE: AS_actor " + PlayerActor + @" die 

:PLCHUTE_2497
gosub @PLCHUTE_5521 

:PLCHUTE_2504
if 
    " + FreeFall_Stage + @" == 3 
jf @PLCHUTE_4781 
if 
    " + _8270 + @" > 0 
jf @PLCHUTE_2586 
if 
001F:   TIMERA > " + _8270 + @" // (int) 
jf @PLCHUTE_2586 
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1039 
" + _8270 + @" = 0 

:PLCHUTE_2586
if 
    0@ == 0 
jf @PLCHUTE_2689 
0087: 25@ = 3@ // (float) 
25@ /= 500.0 
0087: 26@ = 2@ // (float) 
26@ /= 500.0 
0085: 18@ = TIMERA // (int) 
0085: 19@ = TIMERA // (int) 
0087: 5@ = 4@ // (float) 
5@ *= -1.0 
0089: 6@ = " + _1509 + @" // (float) 
0@ = 1 

:PLCHUTE_2689
if 
    0@ == 1 
jf @PLCHUTE_2856 
0085: 10@ = TIMERA // (int) 
0062: 10@ -= 19@ // (int) 
if 
    500 > 10@ 
jf @PLCHUTE_2829 
0085: 10@ = TIMERA // (int) 
0062: 10@ -= 18@ // (int) 
0085: 18@ = TIMERA // (int) 
0093: 21@ = integer 10@ to_float 
0087: 22@ = 25@ // (float) 
006B: 22@ *= 21@ // (float) 
0087: 23@ = 26@ // (float) 
006B: 23@ *= 21@ // (float) 
0063: 3@ -= 22@ // (float) 
0063: 2@ -= 23@ // (float) 
jump @PLCHUTE_2856 

:PLCHUTE_2829
2@ = 0.0 
3@ = 0.0 
0@ = 2 

:PLCHUTE_2856
if 
    0@ == 2 
jf @PLCHUTE_2964 
if 
03CA:   object 17@ exists 
jf @PLCHUTE_2964 
0750: set_object 17@ visibility 1 
08D2: object 17@ scale_model 0.0 
0085: 19@ = TIMERA // (int) 
wait 0 
075A: set_object 17@ animation ""PARA_OPEN_O"" IFP_file ""PARACHUTE"" 1000.0 lockF 0 loop 1 // IF AND SET 
0@ = 3 

:PLCHUTE_2964
if 
    0@ == 3 
jf @PLCHUTE_3067 
0085: 10@ = TIMERA // (int) 
0062: 10@ -= 19@ // (int) 
if 
    500 > 10@ 
jf @PLCHUTE_3050 
0093: 21@ = integer 10@ to_float 
21@ /= 500.0 
08D2: object 17@ scale_model 21@ 
jump @PLCHUTE_3067 

:PLCHUTE_3050
08D2: object 17@ scale_model 1.0 
0@ = 4 

:PLCHUTE_3067
if 
    0@ == 5 
jf @PLCHUTE_3136 
20@ = Object.Create(#PARA_COLLISION, 0.0, 0.0, 0.0)
0750: set_object 20@ visibility 0 
Object.ToggleInMovingList(20@) = True
04D9: object 20@ set_scripted_collision_check 1 
0@ = 6 

:PLCHUTE_3136
if 
    0@ == 6 
jf @PLCHUTE_4354 
0494: get_joystick 0 direction_offset_to 10@ 11@ 12@ 12@ 
if 
    " + _1511 + @" == 1 
jf @PLCHUTE_3202 
10@ = 0 
11@ = 0 

:PLCHUTE_3202
0093: 21@ = integer 10@ to_float 
21@ /= 4.267 
0063: 21@ -= 2@ // (float) 
21@ /= 20.0 
005B: 2@ += 21@ // (float) 
0087: 21@ = 2@ // (float) 
21@ /= 15.0 
0063: 1@ -= 21@ // (float) 
if 
    1@ > 180.0 
jf @PLCHUTE_3303 
1@ -= 360.0 

:PLCHUTE_3303
if 
    -180.0 > 1@ 
jf @PLCHUTE_3334 
1@ += 360.0 

:PLCHUTE_3334
02F6: " + _1507 + @" = sine 1@ // (float) 
02F7: " + _1508 + @" = cosine 1@ // (float) 
0069: " + _1507 + @" *= " + _1500 + @" // (float) 
0069: " + _1508 + @" *= " + _1500 + @" // (float) 
" + _1507 + @" *= -1.0 
0085: 12@ = 10@ // (int) 
0085: 13@ = 11@ // (int) 
0095: make 12@ absolute_integer 
0095: make 13@ absolute_integer 
if or
    12@ > 40 
    13@ > 40 
jf @PLCHUTE_4066 
if 
001D:   12@ > 13@ // (int) 
jf @PLCHUTE_3741 
0089: 21@ = " + _1501 + @" // (float) 
0065: 21@ -= " + _1509 + @" // (float) 
21@ /= 20.0 
005F: " + _1509 + @" += 21@ // (float) 
if 
    10@ >= 0 
jf @PLCHUTE_3607 
if 
    not 15@ == 2 
jf @PLCHUTE_3607 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_STEERR"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 
075A: set_object 17@ animation ""PARA_STEERR_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 // IF AND SET 
15@ = 2 

:PLCHUTE_3607
if 
    0 > 10@ 
jf @PLCHUTE_3734 
if 
    not 15@ == 3 
jf @PLCHUTE_3734 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_STEERL"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 
075A: set_object 17@ animation ""PARA_STEERL_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 // IF AND SET 
15@ = 3 

:PLCHUTE_3734
jump @PLCHUTE_4059 

:PLCHUTE_3741
if 
    11@ >= 0 
jf @PLCHUTE_3900 
0089: 21@ = " + _1503 + @" // (float) 
0065: 21@ -= " + _1509 + @" // (float) 
21@ /= 20.0 
005F: " + _1509 + @" += 21@ // (float) 
if 
    not 15@ == 4 
jf @PLCHUTE_3900 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_DECEL"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 
075A: set_object 17@ animation ""PARA_DECEL_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 // IF AND SET 
15@ = 4 

:PLCHUTE_3900
if 
    0 > 11@ 
jf @PLCHUTE_4059 
0089: 21@ = " + _1501 + @" // (float) 
0065: 21@ -= " + _1509 + @" // (float) 
21@ /= 20.0 
005F: " + _1509 + @" += 21@ // (float) 
if 
    not 15@ == 5 
jf @PLCHUTE_4059 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_FLOAT"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 
075A: set_object 17@ animation ""PARA_FLOAT_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 // IF AND SET 
15@ = 5 

:PLCHUTE_4059
jump @PLCHUTE_4225 

:PLCHUTE_4066
0089: 21@ = " + _1501 + @" // (float) 
0065: 21@ -= " + _1509 + @" // (float) 
21@ /= 20.0 
005F: " + _1509 + @" += 21@ // (float) 
if 
    not 15@ == 5 
jf @PLCHUTE_4225 
if 
    not 15@ == 1 
jf @PLCHUTE_4225 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_FLOAT"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 // versionB 
075A: set_object 17@ animation ""PARA_FLOAT_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 // IF AND SET 
15@ = 1 

:PLCHUTE_4225
Object.StorePos(17@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0815: put_object 20@ at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_keep_rotation 
if 
04DA:   has_object 20@ collided 
jf @PLCHUTE_4318 
075A: set_object 17@ animation ""PARA_RIP_LOOP_O"" IFP_file ""PARACHUTE"" 8.0 lockF 1 loop 1 // IF AND SET 
0@ = 7 

:PLCHUTE_4318
if 
00E1:   player 0 pressed_key 15 
jf @PLCHUTE_4354 
0792: disembark_instantly_actor " + PlayerActor + @" 
" + FreeFall_Stage + @" = 6 
" + _1498 + @" = 3 

:PLCHUTE_4354
if 
03CA:   object 17@ exists 
jf @PLCHUTE_4593 
if 
0837:   object 17@ animation == ""PARA_OPEN_O"" 
jf @PLCHUTE_4593 
0839: get_object 17@ animation ""PARA_OPEN_O"" progress_to 21@ 
0087: 22@ = 6@ // (float) 
0065: 22@ -= " + _1501 + @" // (float) 
0087: 23@ = 22@ // (float) 
006B: 23@ *= 21@ // (float) 
0088: " + _1509 + @" = 6@ // (float) 
0067: " + _1509 + @" -= 23@ // (float) 
0087: 22@ = 5@ // (float) 
0065: 22@ -= " + _1500 + @" // (float) 
0087: 23@ = 22@ // (float) 
006B: 23@ *= 21@ // (float) 
0087: 4@ = 5@ // (float) 
0063: 4@ -= 23@ // (float) 
02F6: " + _1507 + @" = sine 1@ // (float) 
02F7: " + _1508 + @" = cosine 1@ // (float) 
006D: " + _1507 + @" *= 4@ // (float) 
006D: " + _1508 + @" *= 4@ // (float) 
" + _1507 + @" *= -1.0 
if and
    21@ == 1.0 
    0@ == 4 
jf @PLCHUTE_4593 
0@ = 5 

:PLCHUTE_4593
if 
    not Actor.Dead(" + PlayerActor + @")
jf @PLCHUTE_4781 
if 
04AD:   actor " + PlayerActor + @" in_water 
jf @PLCHUTE_4732 
0812: AS_actor " + PlayerActor + @" perform_animation ""PARA_LAND_WATER"" IFP ""PARACHUTE"" framedelta 8.0 loopA 1 lockX 1 lockY 0 lockF 0 time 1000 // versionB 
075A: set_object 17@ animation ""PARA_LAND_WATER_O"" IFP_file ""PARACHUTE"" 1000.0 lockF 0 loop 1 // IF AND SET 
" + FreeFall_Stage + @" = 5 
0@ = 0 

:PLCHUTE_4732
083D: get_actor " + PlayerActor + @" velocity_in_direction_XYZ 21@ 21@ 23@ 
if 
    23@ > -0.1 
jf @PLCHUTE_4781 
" + FreeFall_Stage + @" = 4 
0@ = 0 

:PLCHUTE_4781
if 
    " + FreeFall_Stage + @" == 4 
jf @PLCHUTE_5271 
if 
    0@ == 0 
jf @PLCHUTE_5168 
" + _1498 + @" = 1 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
" + tempvar_Z_coord + @" -= 1.0 
Actor.PutAt(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
083E: set_actor " + PlayerActor + @" rotation 0.0 0.0 1@ while_in_air 
if 
    -10.0 > " + _1509 + @" 
jf @PLCHUTE_4922 
" + FreeFall_Stage + @" = 2 
0@ = 0 
jump @PLCHUTE_5092 

:PLCHUTE_4922
if 
    -4.0 > " + _1509 + @" 
jf @PLCHUTE_5047 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""PARA_Land"" IFP ""PARACHUTE"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 // versionB
//0812: AS_actor -1 perform_animation ""FALL_FRONT"" IFP ""PED"" framedelta 20.0 loopA 0 lockX 0 lockY 0 lockF 1 time 700 // versionB 
//0812: AS_actor -1 perform_animation ""GETUP_FRONT"" IFP ""PED"" framedelta 8.0 loopA 0 lockX 1 lockY 0 lockF 0 time -2 // versionB 
0616: define_AS_pack_end 14@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 
jump @PLCHUTE_5085 

:PLCHUTE_5047
0812: AS_actor " + PlayerActor + @" perform_animation ""RUN_PLAYER"" IFP ""PED"" framedelta 8.0 loopA 1 lockX 1 lockY 0 lockF 0 time 1000 // versionB 

:PLCHUTE_5085
0@ = 1 

:PLCHUTE_5092
075A: set_object 17@ animation ""PARA_LAND_O"" IFP_file ""PARACHUTE"" 1000.0 lockF 0 loop 1 // IF AND SET 
0682: detach_object 17@ 0.0 0.0 0.0 collision_detection 0 
0085: 18@ = TIMERA // (int) 
18@ += 1000 

:PLCHUTE_5168
if 
    0@ == 1 
jf @PLCHUTE_5271 
if 
0837:   object 17@ animation == ""PARA_LAND_O"" 
jf @PLCHUTE_5271 
0839: get_object 17@ animation ""PARA_LAND_O"" progress_to 21@ 
if 
    21@ == 1.0 
jf @PLCHUTE_5271 
" + _1498 + @" = 2 
gosub @PLCHUTE_5521 

:PLCHUTE_5271
if 
    " + FreeFall_Stage + @" == 5 
jf @PLCHUTE_5328 
" + _1498 + @" = 1 
if 
    0@ == 0 
jf @PLCHUTE_5328 
" + _1498 + @" = 2 
gosub @PLCHUTE_5521 

:PLCHUTE_5328
if and
    " + FreeFall_Stage + @" > 0 
    4 > " + FreeFall_Stage + @" 
jf @PLCHUTE_5405 
if 
    not Actor.Dead(" + PlayerActor + @")
jf @PLCHUTE_5405 
083C: set_actor " + PlayerActor + @" velocity_in_direction_XYZ " + _1507 + @" " + _1508 + @" " + _1509 + @" 
Actor.Angle(" + PlayerActor + @") = 1@
083E: set_actor " + PlayerActor + @" rotation 3@ 2@ 1@ while_in_air 

:PLCHUTE_5405
if 
    " + FreeFall_Stage + @" == 6 
jf @PLCHUTE_5430 
gosub @PLCHUTE_5521 

:PLCHUTE_5430
if 
    " + FreeFall_Stage + @" == 7 
jf @PLCHUTE_5455 
gosub @PLCHUTE_5462 

:PLCHUTE_5455
jump @PLCHUTE_118 

:PLCHUTE_5462
" + FreeFall_Stage + @" = 0 
0@ = 0 
Model.Destroy(#PARACHUTE)
04EF: release_animation ""PARACHUTE"" 
083E: set_actor " + PlayerActor + @" rotation 0.0 0.0 1@ while_in_air 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 
return 

:PLCHUTE_5521
0682: detach_object 17@ 0.0 0.0 0.0 collision_detection 0 
09A2: destroy_object_with_fade 17@ 
Object.Destroy(20@)
0555: remove_weapon 46 from_actor " + PlayerActor + @" 
" + FreeFall_Stage + @" = 0 
" + Parachute_Creation_Stage + @" = 0 
0@ = 0 
Model.Destroy(#PARACHUTE)
04EF: release_animation ""PARACHUTE"" 
Model.Destroy(#GUN_PARA)
083E: set_actor " + PlayerActor + @" rotation 0.0 0.0 1@ while_in_air 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 
end_thread" );

            }

        }

    }

}