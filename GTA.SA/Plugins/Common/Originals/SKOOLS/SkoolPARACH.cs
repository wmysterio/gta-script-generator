using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalSkools {

        private sealed class PARACH : External {

            public override void START( LabelJump label ) {
                AppendLine( @"" + _8275 + @" = 0 
0209: 31@ = random_int_in_ranges 0 6 
11@ = 10 
17@ = 0 
12@ = 0 
" + _8289 + @" = 0 
if 
  12@ == 100 
else_jump @PARACH_122 
0@ = Pickup.Create(#BRIEFCASE, 3, 32.1527, 2239.726, 125.672)
8@ = Actor.Create(CivMale, #WMYPLT, 32.1527, 2239.726, 125.672)

:PARACH_122
if 
   not Actor.Dead(8@)
else_jump @PARACH_146 
0819: 30@ = actor 8@ distance_from_ground 

:PARACH_146
wait 0 
008A: " + _8290 + @" = 17@ 
if 
  " + _8289 + @" == 2 
else_jump @PARACH_202 
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_202 
gosub @PARACH_6417 

:PARACH_202
if 
   not 0@ == -1 
else_jump @PARACH_293 
if 
  11@ == 10 
else_jump @PARACH_293 
if 
   not 0@ == -1 
else_jump @PARACH_286 
if 
   Pickup.Picked_up(0@)
else_jump @PARACH_279 
11@ = 0 

:PARACH_279
jump @PARACH_293 

:PARACH_286
11@ = 0 

:PARACH_293
if 
  0@ == -1 
else_jump @PARACH_336 
if 
  11@ == 10 
else_jump @PARACH_336 
11@ = 0 

:PARACH_336
if 
  11@ == 0 
else_jump @PARACH_384 
04ED: load_animation ""PARACHUTE"" 
Model.Load(#PARACHUTE)
Model.Load(#PARA_PACK)
11@ = 1 

:PARACH_384
if 
  11@ == 1 
else_jump @PARACH_443 
if and
04EE:   animation ""PARACHUTE"" loaded 
   Model.Available(#PARACHUTE)
   Model.Available(#PARA_PACK)
else_jump @PARACH_443 
11@ = 2 

:PARACH_443
if 
  11@ == 2 
else_jump @PARACH_654 
if 
   not Actor.Dead(8@)
else_jump @PARACH_491 
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")

:PARACH_491
9@ = Object.Create(#PARACHUTE, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
10@ = Object.Create(#PARA_PACK, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0750: set_object 9@ visibility 0 
if 
   not Actor.Dead(8@)
else_jump @PARACH_647 
069B: attach_object 9@ to_actor 8@ with_offset 0.0 0.0 0.0 rotation 0.0 0.0 0.0 
0453: set_object 10@ XYZ_rotation 90.0 90.0 90.0 
070A: AS_actor 8@ attach_to_object 10@ offset -0.11 -0.05 0.0 on_bone 1 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 

:PARACH_647
11@ = 3 

:PARACH_654
if 
  11@ == 3 
else_jump @PARACH_6053 
if 
   not Actor.Dead(8@)
else_jump @PARACH_6053 
if 
  31@ == 0 
else_jump @PARACH_756 
0819: 30@ = actor 8@ distance_from_ground 
if 
  5.0 > 30@ 
else_jump @PARACH_749 
31@ = 2 
jump @PARACH_756 

:PARACH_749
31@ = 5 

:PARACH_756
31@ -= 1 
if 
87D6:   not  8@ == " + PlayerActor + @" 
else_jump @PARACH_789 
gosub @PARACH_6503 

:PARACH_789
if 
   Actor.Driving(8@)
else_jump @PARACH_819 
" + _8302 + @" = 1 
jump @PARACH_826 

:PARACH_819
" + _8302 + @" = 0 

:PARACH_826
if 
   not Actor.Dead(8@)
else_jump @PARACH_1186 
if or
0818:   actor 8@ in_air 
  " + _8302 + @" == 0 
else_jump @PARACH_1186 
if and
  17@ == 0 
  14@ == 0 
  30@ > 5.0 
else_jump @PARACH_1186 
if 
  " + _8302 + @" == 0 
else_jump @PARACH_988 
02F6: " + _8303 + @" = sine " + _8301 + @" 
0069: " + _8303 + @" *= " + _8300 + @" 
" + _8303 + @" *= -1.0 
02F7: " + _8304 + @" = cosine " + _8301 + @" 
0069: " + _8304 + @" *= " + _8300 + @" 
083D: get_actor 8@ velocity_in_direction_XYZ " + _8276 + @" " + _8276 + @" " + _8276 + @" 
083C: set_actor 8@ velocity_in_direction_XYZ " + _8303 + @" " + _8304 + @" " + _8276 + @" 

:PARACH_988
17@ = 1 
" + _8275 + @" = 1 
0085: 18@ = 32@ 
27@ = Actor.Angle(8@)
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_1071 
" + _8297 + @" = 3.0 
" + _8298 + @" = -2.0 
16@ = 0 
gosub @PARACH_6083 

:PARACH_1071
if 
  7@ == 0 
else_jump @PARACH_1141 
0812: AS_actor 8@ perform_animation ""FALL_SKYDIVE"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
jump @PARACH_1186 

:PARACH_1141
0812: AS_actor 8@ perform_animation ""FALL_SKYDIVE"" IFP ""PARACHUTE"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 

:PARACH_1186
if 
  17@ == 1 
else_jump @PARACH_2838 
if 
04AD:   actor 8@ in_water 
else_jump @PARACH_1268 
0829: actor 8@ perform_animation ""FALL_SKYDIVE_DIE"" IFP_file ""PARACHUTE"" 1000.0 time 0 and_dies 
17@ = 2 

:PARACH_1268
if 
  3.0 > 30@ 
else_jump @PARACH_1337 
0829: actor 8@ perform_animation ""FALL_SKYDIVE_DIE"" IFP_file ""PARACHUTE"" 1000.0 time 0 and_dies 
17@ = 2 

:PARACH_1337
083D: get_actor 8@ velocity_in_direction_XYZ " + _8276 + @" " + _8276 + @" " + _8277 + @" 
if 
0027:   1@ > " + _8277 + @" 
else_jump @PARACH_1378 
0088: " + _8277 + @" = 1@ 

:PARACH_1378
008A: " + _8282 + @" = 32@ 
0066: " + _8282 + @" -= 18@ 
008F: 28@ = integer " + _8282 + @" to_float 
28@ /= 2000.0 
if 
  28@ > 1.0 
else_jump @PARACH_1443 
28@ = 1.0 

:PARACH_1443
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_1490 
if 
  1.0 >= 28@ 
else_jump @PARACH_1490 
gosub @PARACH_6307 

:PARACH_1490
if 
  28@ == 1.0 
else_jump @PARACH_2431 
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_2413 
0494: get_joystick 0 direction_offset_to " + _8282 + @" " + _8283 + @" " + _8284 + @" " + _8284 + @" 
008D: " + _8279 + @" = integer " + _8282 + @" to_float 
" + _8279 + @" /= 256.0 
005D: 25@ += " + _8279 + @" 
0088: " + _8280 + @" = 25@ 
" + _8280 + @" /= 30.0 
if 
  -1.6 > " + _8280 + @" 
else_jump @PARACH_1621 
" + _8280 + @" = -1.6 

:PARACH_1621
if 
  " + _8280 + @" > 1.6 
else_jump @PARACH_1652 
" + _8280 + @" = 1.6 

:PARACH_1652
0065: 27@ -= " + _8280 + @" 
if 
  " + _8279 + @" == 0.0 
else_jump @PARACH_1712 
if 
   not 25@ == 0.0 
else_jump @PARACH_1712 
25@ *= 0.95 

:PARACH_1712
0088: " + _8278 + @" = 26@ 
" + _8278 + @" *= 6.0 
008D: " + _8281 + @" = integer " + _8283 + @" to_float 
0061: " + _8281 + @" -= " + _8278 + @" 
" + _8281 + @" /= 256.0 
005D: 26@ += " + _8281 + @" 
if 
  -30.0 > 26@ 
else_jump @PARACH_1795 
26@ = -30.0 

:PARACH_1795
if 
  26@ > 30.0 
else_jump @PARACH_1826 
26@ = 30.0 

:PARACH_1826
if 
  " + _8281 + @" == 0.0 
else_jump @PARACH_1878 
if 
   not 26@ == 0.0 
else_jump @PARACH_1878 
26@ *= 0.97 

:PARACH_1878
02F6: " + tempvar_Float_1 + @" = sine 27@ 
02F7: " + tempvar_Float_2 + @" = cosine 27@ 
0088: " + _8279 + @" = 26@ 
" + _8279 + @" /= -5.0 
006D: " + tempvar_Float_1 + @" *= 2@ 
0069: " + tempvar_Float_1 + @" *= " + _8279 + @" 
" + tempvar_Float_1 + @" *= -1.0 
006D: " + tempvar_Float_2 + @" *= 2@ 
0069: " + tempvar_Float_2 + @" *= " + _8279 + @" 
083D: get_actor 8@ velocity_in_direction_XYZ " + _8278 + @" " + _8279 + @" " + _8276 + @" 
" + tempvar_Float_1 + @" *= -1.0 
0059: " + tempvar_Float_1 + @" += " + _8278 + @" 
" + tempvar_Float_1 + @" *= 0.1 
0061: " + _8278 + @" -= " + tempvar_Float_1 + @" 
" + tempvar_Float_2 + @" *= -1.0 
0059: " + tempvar_Float_2 + @" += " + _8279 + @" 
" + tempvar_Float_2 + @" *= 0.1 
0061: " + _8279 + @" -= " + tempvar_Float_2 + @" 
083C: set_actor 8@ velocity_in_direction_XYZ " + _8278 + @" " + _8279 + @" " + _8277 + @" 
083E: set_actor 8@ rotation 26@ 0.0 27@ while_in_air 
if 
  -100 > " + _8283 + @" 
else_jump @PARACH_2171 
if 
   not 15@ == 4 
else_jump @PARACH_2164 
15@ = 4 
0812: AS_actor 8@ perform_animation ""FALL_SKYDIVE_ACCEL"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 

:PARACH_2164
jump @PARACH_2406 

:PARACH_2171
if and
  " + _8282 + @" == 0 
   not 15@ == 0 
else_jump @PARACH_2248 
15@ = 0 
0812: AS_actor 8@ perform_animation ""FALL_SKYDIVE"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 

:PARACH_2248
if and
  0 > " + _8282 + @" 
   not 15@ == -1 
else_jump @PARACH_2327 
15@ = -1 
0812: AS_actor 8@ perform_animation ""FALL_SKYDIVE_L"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 

:PARACH_2327
if and
  " + _8282 + @" > 0 
   not 15@ == 1 
else_jump @PARACH_2406 
15@ = 1 
0812: AS_actor 8@ perform_animation ""FALL_SKYDIVE_R"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 

:PARACH_2406
jump @PARACH_2431 

:PARACH_2413
083C: set_actor 8@ velocity_in_direction_XYZ 0.0 0.0 1@ 

:PARACH_2431
if or
00E1:   player 0 pressed_key 17 
  " + _8299 + @" == 1 
else_jump @PARACH_2652 
if 
   not " + _8299 + @" == 2 
else_jump @PARACH_2652 
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_2652 
17@ = 0 
15@ = 0 
14@ = 1 
0750: set_object 9@ visibility 1 
wait 0 
if 
   not Actor.Dead(8@)
else_jump @PARACH_2652 
0812: AS_actor 8@ perform_animation ""PARA_OPEN"" IFP ""PARACHUTE"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_OPEN_O"" IFP_file ""PARACHUTE"" 1000.0 lockF 0 loop 1 
083D: get_actor 8@ velocity_in_direction_XYZ " + _8276 + @" " + _8276 + @" 24@ 
0088: " + _8288 + @" = 24@ 
" + _8288 + @" += 5.0 

:PARACH_2652
if and
  12@ == 1 
87D6:   not  8@ == " + PlayerActor + @" 
else_jump @PARACH_2838 
17@ = 0 
15@ = 0 
14@ = 1 
0750: set_object 9@ visibility 1 
wait 0 
if 
   not Actor.Dead(8@)
else_jump @PARACH_2838 
0812: AS_actor 8@ perform_animation ""PARA_OPEN"" IFP ""PARACHUTE"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_OPEN_O"" IFP_file ""PARACHUTE"" 1000.0 lockF 0 loop 1 
083D: get_actor 8@ velocity_in_direction_XYZ " + _8276 + @" " + _8276 + @" 24@ 
0088: " + _8288 + @" = 24@ 
" + _8288 + @" += 5.0 

:PARACH_2838
if 
  14@ == 1 
else_jump @PARACH_3568 
if 
   not Actor.Dead(8@)
else_jump @PARACH_3540 
if 
   Actor.Animation(8@) == ""PARA_OPEN""
else_jump @PARACH_3540 
0613: " + _8274 + @" = actor 8@ animation ""PARA_OPEN"" time 
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
" + _8274 + @" *= 2.0 
" + _8274 + @" -= 0.5 
if 
  " + _8274 + @" > 1.0 
else_jump @PARACH_2983 
" + _8274 + @" = 1.0 

:PARACH_2983
if 
  0.0 > " + _8274 + @" 
else_jump @PARACH_3014 
" + _8274 + @" = 0.0 

:PARACH_3014
if and
  0.25 >= " + _8274 + @" 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_3120 
" + _8297 + @" = -2.0 
" + _8298 + @" = -2.0 
0089: 28@ = " + _8274 + @" 
28@ *= 4.0 
if 
  16@ == 1 
else_jump @PARACH_3113 
16@ = 2 
gosub @PARACH_6083 

:PARACH_3113
gosub @PARACH_6307 

:PARACH_3120
if and
  " + _8274 + @" > 0.25 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_3236 
" + _8297 + @" = 5.0 
" + _8298 + @" = -5.0 
0089: 28@ = " + _8274 + @" 
28@ -= 0.25 
28@ *= 1.333 
if 
  16@ == 2 
else_jump @PARACH_3229 
16@ = 3 
gosub @PARACH_6083 

:PARACH_3229
gosub @PARACH_6307 

:PARACH_3236
0086: " + _8276 + @" = " + _8288 + @" 
0069: " + _8276 + @" *= " + _8274 + @" 
" + _8276 + @" *= -1.0 
005F: " + _8276 + @" += 24@ 
083D: get_actor 8@ velocity_in_direction_XYZ " + _8278 + @" " + _8279 + @" " + _8277 + @" 
02F6: " + tempvar_Float_1 + @" = sine 27@ 
02F7: " + tempvar_Float_2 + @" = cosine 27@ 
006D: " + tempvar_Float_1 + @" *= 5@ 
" + tempvar_Float_1 + @" *= -1.0 
006D: " + tempvar_Float_2 + @" *= 5@ 
" + tempvar_Float_1 + @" *= -1.0 
0059: " + tempvar_Float_1 + @" += " + _8278 + @" 
" + tempvar_Float_1 + @" *= 0.01 
0061: " + _8278 + @" -= " + tempvar_Float_1 + @" 
" + tempvar_Float_2 + @" *= -1.0 
0059: " + tempvar_Float_2 + @" += " + _8279 + @" 
" + tempvar_Float_2 + @" *= 0.01 
0061: " + _8279 + @" -= " + tempvar_Float_2 + @" 
083C: set_actor 8@ velocity_in_direction_XYZ " + _8278 + @" " + _8279 + @" " + _8276 + @" 
if 
  " + _8274 + @" == 1.0 
else_jump @PARACH_3540 
0812: AS_actor 8@ perform_animation ""PARA_FLOAT"" IFP ""PARACHUTE"" framedelta 2.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_FLOAT_O"" IFP_file ""PARACHUTE"" 2.0 lockF 1 loop 1 
14@ = 2 
0089: 29@ = " + _8276 + @" 
25@ = 0.0 

:PARACH_3540
if 
  3.0 > 30@ 
else_jump @PARACH_3568 
14@ = 3 

:PARACH_3568
if 
  14@ == 2 
else_jump @PARACH_5824 
if and
   not 13@ == 5 
04AD:   actor 8@ in_water 
else_jump @PARACH_3616 
13@ = 4 

:PARACH_3616
if 
  13@ == 0 
else_jump @PARACH_4766 
02F6: " + tempvar_Float_1 + @" = sine 27@ 
02F7: " + tempvar_Float_2 + @" = cosine 27@ 
" + _8284 + @" = 0 
" + _8285 + @" = 0 
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_3706 
0494: get_joystick 0 direction_offset_to " + _8282 + @" " + _8283 + @" " + _8284 + @" " + _8285 + @" 
jump @PARACH_3728 

:PARACH_3706
008A: " + _8282 + @" = 22@ 
" + _8283 + @" = 0 
" + _8284 + @" = 0 

:PARACH_3728
if and
   not " + _8284 + @" == 0 
   not " + _8285 + @" == 0 
else_jump @PARACH_3753 

:PARACH_3753
if or
  " + _8283 + @" > 100 
  12@ == 2 
else_jump @PARACH_3811 
006D: " + tempvar_Float_1 + @" *= 6@ 
" + tempvar_Float_1 + @" *= -1.0 
006D: " + tempvar_Float_2 + @" *= 6@ 
jump @PARACH_3837 

:PARACH_3811
006D: " + tempvar_Float_1 + @" *= 5@ 
" + tempvar_Float_1 + @" *= -1.0 
006D: " + tempvar_Float_2 + @" *= 5@ 

:PARACH_3837
0084: " + _8285 + @" = " + _8283 + @" 
083E: set_actor 8@ rotation 0.0 25@ 27@ while_in_air 
if 
  30@ > 3.0 
else_jump @PARACH_4574 
008D: " + _8281 + @" = integer " + _8282 + @" to_float 
" + _8281 + @" /= 128.0 
005D: 25@ += " + _8281 + @" 
if 
  25@ > 45.0 
else_jump @PARACH_3939 
25@ = 45.0 

:PARACH_3939
if 
  -45.0 > 25@ 
else_jump @PARACH_3970 
25@ = -45.0 

:PARACH_3970
0088: " + _8280 + @" = 25@ 
" + _8280 + @" /= 15.0 
0065: 27@ -= " + _8280 + @" 
if 
  " + _8281 + @" == 0.0 
else_jump @PARACH_4048 
if 
   not 25@ == 0.0 
else_jump @PARACH_4048 
25@ *= 0.95 

:PARACH_4048
083E: set_actor 8@ rotation 0.0 25@ 27@ while_in_air 
if or
  " + _8283 + @" > 100 
  12@ == 2 
else_jump @PARACH_4211 
0088: " + tempvar_Float_3 + @" = 4@ 
if 
   not 15@ == 4 
else_jump @PARACH_4204 
15@ = 4 
0812: AS_actor 8@ perform_animation ""PARA_DECEL"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_DECEL_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 

:PARACH_4204
jump @PARACH_4574 

:PARACH_4211
0088: " + tempvar_Float_3 + @" = 3@ 
if and
  " + _8281 + @" == 0.0 
   not 15@ == 0 
else_jump @PARACH_4336 
15@ = 0 
0812: AS_actor 8@ perform_animation ""PARA_FLOAT"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_FLOAT_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 

:PARACH_4336
if and
  0.0 > " + _8281 + @" 
   not 15@ == -1 
else_jump @PARACH_4455 
15@ = -1 
0812: AS_actor 8@ perform_animation ""PARA_STEERL"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_STEERL_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 

:PARACH_4455
if and
  " + _8281 + @" > 0.0 
   not 15@ == 1 
else_jump @PARACH_4574 
15@ = 1 
0812: AS_actor 8@ perform_animation ""PARA_STEERR"" IFP ""PARACHUTE"" framedelta 1.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_STEERR_O"" IFP_file ""PARACHUTE"" 1.0 lockF 1 loop 1 

:PARACH_4574
083D: get_actor 8@ velocity_in_direction_XYZ " + _8278 + @" " + _8279 + @" " + _8276 + @" 
" + tempvar_Float_1 + @" *= -1.0 
0059: " + tempvar_Float_1 + @" += " + _8278 + @" 
" + tempvar_Float_1 + @" *= 0.1 
0061: " + _8278 + @" -= " + tempvar_Float_1 + @" 
" + tempvar_Float_2 + @" *= -1.0 
0059: " + tempvar_Float_2 + @" += " + _8279 + @" 
" + tempvar_Float_2 + @" *= 0.1 
0061: " + _8279 + @" -= " + tempvar_Float_2 + @" 
" + tempvar_Float_3 + @" *= -1.0 
005F: " + tempvar_Float_3 + @" += 29@ 
" + tempvar_Float_3 + @" *= 0.2 
0088: " + _8276 + @" = 29@ 
0061: " + _8276 + @" -= " + tempvar_Float_3 + @" 
0089: 29@ = " + _8276 + @" 
083C: set_actor 8@ velocity_in_direction_XYZ " + _8278 + @" " + _8279 + @" " + _8276 + @" 
0069: " + _8278 + @" *= " + _8278 + @" 
0069: " + _8279 + @" *= " + _8279 + @" 
0086: " + _8280 + @" = " + _8278 + @" 
0059: " + _8280 + @" += " + _8279 + @" 
01FB: " + _8280 + @" = square_root " + _8280 + @" 

:PARACH_4766
if 
  3.0 > 30@ 
else_jump @PARACH_5104 
Actor.Angle(8@) = 27@
25@ = 0.0 
02F6: " + tempvar_Float_1 + @" = sine 27@ 
02F7: " + tempvar_Float_2 + @" = cosine 27@ 
006D: " + tempvar_Float_1 + @" *= 6@ 
" + tempvar_Float_1 + @" *= -1.0 
006D: " + tempvar_Float_2 + @" *= 6@ 
083C: set_actor 8@ velocity_in_direction_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" -2.0 
if 
  13@ == 0 
else_jump @PARACH_5012 
13@ = 1 
0812: AS_actor 8@ perform_animation ""PARA_DECEL"" IFP ""PARACHUTE"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_DECEL_O"" IFP_file ""PARACHUTE"" 4.0 lockF 1 loop 1 
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_5012 
0086: " + _8297 + @" = " + _8292 + @" 
0086: " + _8298 + @" = " + _8291 + @" 
gosub @PARACH_6083 

:PARACH_5012
if and
  13@ == 1 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_5104 
28@ = 3.0 
0063: 28@ -= 30@ 
28@ *= 0.75 
if 
  28@ > 1.0 
else_jump @PARACH_5097 
28@ = 1.0 

:PARACH_5097
gosub @PARACH_6307 

:PARACH_5104
if and
  1.5 > 30@ 
  13@ == 1 
else_jump @PARACH_5219 
13@ = 2 
0812: AS_actor 8@ perform_animation ""PARA_LAND"" IFP ""PARACHUTE"" framedelta 1000.0 loopA 0 lockX 1 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_LAND_O"" IFP_file ""PARACHUTE"" 1000.0 lockF 0 loop 1 

:PARACH_5219
if 
  13@ == 2 
else_jump @PARACH_5496 
if 
   Actor.Animation(8@) == ""PARA_LAND""
else_jump @PARACH_5496 
0613: " + _8274 + @" = actor 8@ animation ""PARA_LAND"" time 
if 
  " + _8274 + @" == 1.0 
else_jump @PARACH_5496 
Object.Destroy(9@)
Object.Destroy(10@)
Actor.StoreDeadActorPos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if 
   not 0@ == -1 
else_jump @PARACH_5351 
Pickup.Destroy(0@)

:PARACH_5351
05B9: AS_actor 8@ stay_idle 1 ms 
0792: disembark_instantly_actor 8@ 
14@ = 3 
083E: set_actor 8@ rotation 0.0 0.0 0.0 while_in_air 
Actor.Angle(8@) = 27@
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_5438 
" + _8289 + @" = 1 

:PARACH_5438
if 
  " + OnMission + @" == 1 
else_jump @PARACH_5463 
gosub @PARACH_6417 

:PARACH_5463
0@ = 0 
0@ = Pickup.Create(#BRIEFCASE, 3, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
13@ = 3 

:PARACH_5496
if 
  13@ == 4 
else_jump @PARACH_5623 
0812: AS_actor 8@ perform_animation ""PARA_LAND_WATER"" IFP ""PARACHUTE"" framedelta 1000.0 loopA 0 lockX 1 lockY 0 lockF 1 time -2 
075A: set_object 9@ animation ""PARA_LAND_WATER_O"" IFP_file ""PARACHUTE"" 1.0 lockF 0 loop 1 
13@ = 5 
" + _8274 + @" = 0.0 

:PARACH_5623
if 
  13@ == 5 
else_jump @PARACH_5824 
if 
   Actor.Animation(8@) == ""PARA_LAND_WATER""
else_jump @PARACH_5699 
0613: " + _8274 + @" = actor 8@ animation ""PARA_LAND_WATER"" time 

:PARACH_5699
if 
  " + _8274 + @" == 1.0 
else_jump @PARACH_5824 
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_5746 
" + _8289 + @" = 1 

:PARACH_5746
Object.Destroy(9@)
Object.Destroy(10@)
13@ = 3 
05B9: AS_actor 8@ stay_idle 1 ms 
0792: disembark_instantly_actor 8@ 
14@ = 3 
083E: set_actor 8@ rotation 0.0 0.0 0.0 while_in_air 
Actor.Angle(8@) = 27@
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")

:PARACH_5824
if and
  14@ == 3 
  13@ == 0 
else_jump @PARACH_5935 
075A: set_object 9@ animation ""PARA_LAND_O"" IFP_file ""PARACHUTE"" 1.0 lockF 0 loop 1 
0829: actor 8@ perform_animation ""FALL_SKYDIVE_DIE"" IFP_file ""PARACHUTE"" 1000.0 time 0 and_dies 
13@ = 1 

:PARACH_5935
if 
  14@ == 3 
else_jump @PARACH_6053 
if 
   Pickup.Picked_up(0@)
else_jump @PARACH_6004 
11@ = 10 
17@ = 0 
14@ = 0 
7@ = 0 
13@ = 0 

:PARACH_6004
if 
80FE:   not actor 8@ sphere 0 in_sphere " + tempvar_X_coord + @" " + tempvar_Y_coord + @" " + tempvar_Z_coord + @" radius 50.0 50.0 50.0 
else_jump @PARACH_6053 
jump @PARACH_6417 

:PARACH_6053
if 
   Actor.Dead(8@)
else_jump @PARACH_6076 
jump @PARACH_6417 

:PARACH_6076
jump @PARACH_146 

:PARACH_6083
068D: get_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0086: " + _8278 + @" = " + tempvar_X_coord + @" 
0061: " + _8278 + @" -= " + tempvar_Float_1 + @" 
0086: " + _8279 + @" = " + tempvar_Y_coord + @" 
0061: " + _8279 + @" -= " + tempvar_Float_2 + @" 
0086: " + _8293 + @" = " + tempvar_Float_3 + @" 
0061: " + _8293 + @" -= " + tempvar_Z_coord + @" 
0086: " + _8276 + @" = " + _8278 + @" 
0069: " + _8276 + @" *= " + _8278 + @" 
0086: " + _8277 + @" = " + _8279 + @" 
0069: " + _8277 + @" *= " + _8279 + @" 
0086: " + _8294 + @" = " + _8276 + @" 
0059: " + _8294 + @" += " + _8277 + @" 
" + _8294 + @" *= -1.0 
01FB: " + _8294 + @" = square_root " + _8294 + @" 
0086: " + _8295 + @" = " + _8297 + @" 
0061: " + _8295 + @" -= " + _8293 + @" 
" + _8294 + @" *= -1.0 
0086: " + _8296 + @" = " + _8298 + @" 
0061: " + _8296 + @" -= " + _8294 + @" 
if 
  16@ == 0 
else_jump @PARACH_6305 
16@ = 1 
0086: " + _8291 + @" = " + _8294 + @" 
0086: " + _8292 + @" = " + _8293 + @" 

:PARACH_6305
return 

:PARACH_6307
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0088: " + _8278 + @" = 28@ 
" + _8278 + @" *= 180.0 
02F7: " + _8278 + @" = cosine " + _8278 + @" 
" + _8278 + @" -= 1.0 
" + _8278 + @" *= -0.5 
0086: " + tempvar_Float_3 + @" = " + _8295 + @" 
0069: " + tempvar_Float_3 + @" *= " + _8278 + @" 
0059: " + tempvar_Float_3 + @" += " + _8293 + @" 
0086: " + tempvar_Float_2 + @" = " + _8296 + @" 
0069: " + tempvar_Float_2 + @" *= " + _8278 + @" 
0059: " + tempvar_Float_2 + @" += " + _8294 + @" 
return 

:PARACH_6417
04EF: release_animation ""PARACHUTE"" 
Model.Destroy(#PARACHUTE)
Model.Destroy(#PARA_PACK)
if 
   not 0@ == -1 
else_jump @PARACH_6463 
Pickup.Destroy(0@)

:PARACH_6463
Object.Destroy(9@)
Object.Destroy(10@)
if 
07D6:   8@ == " + PlayerActor + @" 
else_jump @PARACH_6499 
" + _8299 + @" = 0 

:PARACH_6499
end_thread 
return 

:PARACH_6503
Actor.StorePos(8@, " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
0086: " + tempvar_Float_1 + @" = " + _8271 + @" 
0061: " + tempvar_Float_1 + @" -= " + tempvar_X_coord + @" 
0086: " + tempvar_Float_2 + @" = " + _8272 + @" 
0061: " + tempvar_Float_2 + @" -= " + tempvar_Y_coord + @" 
0086: " + tempvar_Float_3 + @" = " + tempvar_Z_coord + @" 
0061: " + tempvar_Float_3 + @" -= " + _8273 + @" 
if 
  17@ == 1 
else_jump @PARACH_6683 
0069: " + tempvar_Float_1 + @" *= " + tempvar_Float_1 + @" 
0069: " + tempvar_Float_2 + @" *= " + tempvar_Float_2 + @" 
0059: " + tempvar_Float_1 + @" += " + tempvar_Float_2 + @" 
01FB: " + tempvar_Float_1 + @" = square_root " + tempvar_Float_1 + @" 
0086: " + _8276 + @" = " + tempvar_Float_3 + @" 
0071: " + _8276 + @" /= " + tempvar_Float_1 + @" 
0088: " + _8277 + @" = 3@ 
0075: " + _8277 + @" /= 5@ 
" + _8277 + @" *= -1.2 
if 
0024:   " + _8277 + @" > " + _8276 + @" 
else_jump @PARACH_6683 
12@ = 1 

:PARACH_6683
if 
  14@ == 2 
else_jump @PARACH_7350 
0604: get_Z_angle_for_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" store_to 20@ 
19@ = Actor.Angle(8@)
3@ -= 1.0 
4@ -= 1.0 
0087: 21@ = 20@ 
0063: 21@ -= 19@ 
if 
001D:   32@ > 23@ 
else_jump @PARACH_7137 
0085: 23@ = 32@ 
23@ += 3000 
0208: " + _8286 + @" = random_float_in_ranges -20.0 0.0 
0208: " + _8287 + @" = random_float_in_ranges 0.0 20.0 
0069: " + tempvar_Float_1 + @" *= " + tempvar_Float_1 + @" 
0069: " + tempvar_Float_2 + @" *= " + tempvar_Float_2 + @" 
0059: " + tempvar_Float_1 + @" += " + tempvar_Float_2 + @" 
01FB: " + tempvar_Float_1 + @" = square_root " + tempvar_Float_1 + @" 
0086: " + _8277 + @" = " + tempvar_Float_1 + @" 
0075: " + _8277 + @" /= 5@ 
0086: " + _8276 + @" = " + tempvar_Float_3 + @" 
0071: " + _8276 + @" /= " + _8277 + @" 
0088: " + _8277 + @" = 3@ 
005F: " + _8277 + @" += 4@ 
" + _8277 + @" /= 2.0 
0088: " + _8278 + @" = 3@ 
0067: " + _8278 + @" -= 4@ 
" + _8278 + @" /= 4.0 
0059: " + _8278 + @" += " + _8277 + @" 
0088: " + _8279 + @" = 3@ 
0067: " + _8279 + @" -= 4@ 
" + _8279 + @" /= -4.0 
0059: " + _8279 + @" += " + _8277 + @" 
" + _8278 + @" *= -1.0 
" + _8279 + @" *= -1.0 
if and
0024:   " + _8278 + @" > " + _8276 + @" 
0024:   " + _8276 + @" > " + _8279 + @" 
else_jump @PARACH_7085 
0209: " + _8282 + @" = random_int_in_ranges 0 2 
if 
  " + _8282 + @" == 0 
else_jump @PARACH_7060 
12@ = 2 

:PARACH_7060
if 
  " + _8282 + @" == 1 
else_jump @PARACH_7085 
12@ = 0 

:PARACH_7085
if 
0034:   " + _8276 + @" >= " + _8278 + @" 
else_jump @PARACH_7111 
12@ = 0 

:PARACH_7111
if 
0034:   " + _8279 + @" >= " + _8276 + @" 
else_jump @PARACH_7137 
12@ = 2 

:PARACH_7137
if or
0026:   " + _8286 + @" > 21@ 
0027:   21@ > " + _8287 + @" 
else_jump @PARACH_7323 
if 
  -180.0 > 21@ 
else_jump @PARACH_7195 
21@ += 360.0 

:PARACH_7195
if 
  21@ > 180.0 
else_jump @PARACH_7226 
21@ -= 360.0 

:PARACH_7226
21@ /= 180.0 
if 
  21@ > 1.0 
else_jump @PARACH_7267 
21@ = 1.0 

:PARACH_7267
if 
  -1.0 > 21@ 
else_jump @PARACH_7298 
21@ = -1.0 

:PARACH_7298
21@ *= -128.0 
0092: 22@ = float 21@ to_integer 
jump @PARACH_7330 

:PARACH_7323
22@ = 0 

:PARACH_7330
3@ += 1.0 
4@ += 1.0 

:PARACH_7350
return 
end_thread" );
            }

        }

    }

}