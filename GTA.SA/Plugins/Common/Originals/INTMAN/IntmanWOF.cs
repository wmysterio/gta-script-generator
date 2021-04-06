using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class WOF : External {

            Int tmp_9388 = global( _9388.startIndex ),
                tmp_9394 = global( _9394.startIndex ),
                tmp_9400 = global( _9400.startIndex ),
                tmp_9406 = global( _9406.startIndex ),
                tmp_9412 = global( _9412.startIndex ),
                tmp_9418 = global( _9418.startIndex ),
                tmp_9424 = global( _9424.startIndex ),
                tmp_9430 = global( _9430.startIndex ),
                tmp_9339 = global( _9339.startIndex ),
                tmp_9345 = global( _9345.startIndex ),
                tmp_9351 = global( _9351.startIndex ),
                tmp_9357 = global( _9357.startIndex ),
                tmp_9363 = global( _9363.startIndex ),
                tmp_9369 = global( _9369.startIndex ),
                tmp_9375 = global( _9375.startIndex ),
                tmp_9381 = global( _9381.startIndex ),
                tmp_9327 = global( _9327.startIndex );

            Int _local10 = local( 10 );

            public override void START( LabelJump label ) {
                AppendLine( @"5@ = 0 
6@ = 0 
22@ = 0.0 
23@ = 0.0 
13@ = 0 
15@ = 0 
16@ = 0 
25@ = -1 
27@ = 0 
0209: TIMERA = random_int_in_ranges 0 30000 
jump @WOF_438 
0@ = Object.Create(#WHEEL_O_FORTUNE, 0.0, 0.0, 0.0)
4@ = Object.Create(#WHEEL_O_FORTUNE, 0.0, 0.0, 0.0)
2@ = Object.Create(#WHEEL_O_FORTUNE, 0.0, 0.0, 0.0)
1@ = Object.Create(#WHEEL_O_FORTUNE, 0.0, 0.0, 0.0)
3@ = Object.Create(#WHEEL_O_FORTUNE, 0.0, 0.0, 0.0)
7@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
" + tmp_9339 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9345 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9351 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9357 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9363 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9369 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9375 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + tmp_9381 + @"[0] = Object.Create(#CHIP_STACK07, 0.0, 0.0, 0.0)
" + _9436 + @" = Object.Create(#ROULETTE_MARKER, 0.0, 0.0, 0.0)

:WOF_438
wait 0 
if 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @WOF_2376 
if 
03CA:   object 0@ exists 
jf @WOF_2362 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @WOF_2348 
if 
  " + _9440 + @" == 0 
jf @WOF_2253 
if 
   Player.Defined(" + PlayerChar + @")
jf @WOF_2239 
if 
  5@ == 0 
jf @WOF_1066 
if 
  6@ == 0 
jf @WOF_583 
Model.Load(#VBFYCRP)
04ED: load_animation ""CASINO"" 
6@ += 1 

:WOF_583
if 
  6@ == 1 
jf @WOF_633 
if and
   Model.Available(#VBFYCRP)
04EE:   animation ""CASINO"" loaded 
jf @WOF_633 
6@ += 1 

:WOF_633
if 
  6@ == 2 
jf @WOF_1029 
if 
856D:   not actor 7@ defined 
jf @WOF_781 
20@ = Object.Angle(0@)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.5 -0.3974 0.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
7@ = Actor.Create(CivFemale, #VBFYCRP, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
060B: set_actor 7@ decision_maker_to " + Interior_Decision_Maker_A + @" 
0088: " + tempvar_Angle + @" = 20@ 
" + tempvar_Angle + @" += 180.0 
Actor.Angle(7@) = " + tempvar_Angle + @"
Actor.LockInCurrentPosition(7@) = True
Model.Destroy(#VBFYCRP)

:WOF_781
if 
83CA:   not object 4@ exists 
jf @WOF_851 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.159 0.0 
4@ = Object.Init(#WHEEL_SUPPORT, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(4@) = 20@

:WOF_851
if 
83CA:   not object 2@ exists 
jf @WOF_952 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -0.132 -1.049194 -0.834192 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += 1.0 
2@ = Object.Init(#WHEEL_TABLE, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(2@) = 20@
gosub @WOF_15505 

:WOF_952
if 
83CA:   not object 1@ exists 
jf @WOF_1022 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 0.0 1.05 
1@ = Object.Init(#CLICKER, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(1@) = 20@

:WOF_1022
6@ += 1 

:WOF_1029
if 
  6@ == 3 
jf @WOF_1066 
0209: TIMERA = random_int_in_ranges 0 50000 
5@ += 1 

:WOF_1066
if 
  5@ == 1 
jf @WOF_2189 
if 
   not Actor.Dead(7@)
jf @WOF_1309 
if 
  TIMERA > 50000 
jf @WOF_1309 
0605: actor 7@ perform_animation ""WOF"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0209: 10@ = random_int_in_ranges 0 3 
0871: init_jump_table 10@ total_jumps 3 default_jump 0 @WOF_1295 jumps 0 @WOF_1226 1 @WOF_1249 2 @WOF_1272 -1 @WOF_1295 -1 @WOF_1295 -1 @WOF_1295 -1 @WOF_1295 

:WOF_1226
09D6: unknown_set_actor 7@ sound 43608 flags 1 1 0 
jump @WOF_1295 

:WOF_1249
09D6: unknown_set_actor 7@ sound 43609 flags 1 1 0 
jump @WOF_1295 

:WOF_1272
09D6: unknown_set_actor 7@ sound 43610 flags 1 1 0 
jump @WOF_1295 

:WOF_1295
25@ = 0 
TIMERA = 0 

:WOF_1309
if 
   not Actor.Dead(7@)
jf @WOF_2189 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 -1.0 0.0 
if 
  " + _9470 + @" == 0 
jf @WOF_2189 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.5 0.5 2.0 on_foot 
jf @WOF_2162 
if 
044B:   actor " + PlayerActor + @" on_foot 
jf @WOF_2155 
if 
  15@ == 0 
jf @WOF_2131 
if 
00E1:   player 0 pressed_key 15 
jf @WOF_1865 
10@ = 0 
0653: 8@ = float_stat 81 
if 
  19@ == 1000000 
jf @WOF_1558 
if 
  1000.0 > 8@ 
jf @WOF_1551 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
gosub @WOF_2390 
10@ = 1 

:WOF_1551
jump @WOF_1784 

:WOF_1558
if 
  19@ == 100000 
jf @WOF_1637 
if 
  100.0 > 8@ 
jf @WOF_1630 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
gosub @WOF_2390 
10@ = 1 

:WOF_1630
jump @WOF_1784 

:WOF_1637
if 
  19@ == 10000 
jf @WOF_1714 
if 
  10.0 > 8@ 
jf @WOF_1707 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
gosub @WOF_2390 
10@ = 1 

:WOF_1707
jump @WOF_1784 

:WOF_1714
if 
  19@ == 1000 
jf @WOF_1784 
if 
  1.0 > 8@ 
jf @WOF_1784 
00BC: show_text_highpriority GXT 'GAMBSTA' time 5000 flag 1  
gosub @WOF_2390 
10@ = 1 

:WOF_1784
if 
  10@ == 0 
jf @WOF_1858 
if 
  14@ == 1 
jf @WOF_1829 
03E6: remove_text_box 
14@ = 0 

:WOF_1829
5@ = 0 
6@ = 0 
008A: " + _9440 + @" = 0@ 
15@ = 1 

:WOF_1858
jump @WOF_2124 

:WOF_1865
if 
  14@ == 0 
jf @WOF_2124 
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @WOF_2124 
0871: init_jump_table 19@ total_jumps 5 default_jump 1 @WOF_2099 jumps 100 @WOF_2009 1000 @WOF_2027 10000 @WOF_2045 100000 @WOF_2063 1000000 @WOF_2081 -1 @WOF_2117 -1 @WOF_2117 

:WOF_2009
0512: show_permanent_text_box 'WOF_06A'  
jump @WOF_2117 

:WOF_2027
0512: show_permanent_text_box 'WOF_06B'  
jump @WOF_2117 

:WOF_2045
0512: show_permanent_text_box 'WOF_06C'  
jump @WOF_2117 

:WOF_2063
0512: show_permanent_text_box 'WOF_06D'  
jump @WOF_2117 

:WOF_2081
0512: show_permanent_text_box 'WOF_06E'  
jump @WOF_2117 

:WOF_2099
0512: show_permanent_text_box 'WOF_06'  
jump @WOF_2117 

:WOF_2117
14@ = 1 

:WOF_2124
jump @WOF_2155 

:WOF_2131
if 
80E1:   not player 0 pressed_key 15 
jf @WOF_2155 
15@ = 0 

:WOF_2155
jump @WOF_2189 

:WOF_2162
if 
  14@ == 1 
jf @WOF_2189 
03E6: remove_text_box 
14@ = 0 

:WOF_2189
if or
02CC:   object 0@ bounding_sphere_visible 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 5.0 5.0 sphere 0 
jf @WOF_2232 
gosub @WOF_9892 

:WOF_2232
jump @WOF_2246 

:WOF_2239
gosub @WOF_2465 

:WOF_2246
jump @WOF_2341 

:WOF_2253
if 
003C:   " + _9440 + @" == 0@ 
jf @WOF_2341 
if 
   Player.Defined(" + PlayerChar + @")
jf @WOF_2341 
if 
  13@ == 0 
jf @WOF_2327 
gosub @WOF_9892 
gosub @WOF_2506 
jump @WOF_2341 

:WOF_2327
gosub @WOF_11175 
" + _9440 + @" = 0 

:WOF_2341
jump @WOF_2355 

:WOF_2348
gosub @WOF_2465 

:WOF_2355
jump @WOF_2369 

:WOF_2362
gosub @WOF_2465 

:WOF_2369
jump @WOF_2383 

:WOF_2376
gosub @WOF_2465 

:WOF_2383
jump @WOF_438 

:WOF_2390
10@ = 0 
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @WOF_2447 
09D6: unknown_set_actor 7@ sound 43651 flags 1 1 0 
jump @WOF_2463 

:WOF_2447
09D6: unknown_set_actor 7@ sound 43651 flags 1 1 0 

:WOF_2463
return 

:WOF_2465
Actor.RemoveReferences(7@)
Object.RemoveReferences(4@)
Object.RemoveReferences(2@)
Object.RemoveReferences(1@)
04EF: release_animation ""CASINO"" 
" + _9450 + @" -= 1 
end_thread 
return 

:WOF_2506
0871: init_jump_table 5@ total_jumps 7 default_jump 0 @WOF_2667 jumps 0 @WOF_2569 1 @WOF_2583 2 @WOF_2597 3 @WOF_2611 4 @WOF_2625 5 @WOF_2639 6 @WOF_2653 

:WOF_2569
gosub @WOF_2815 
jump @WOF_2667 

:WOF_2583
gosub @WOF_4181 
jump @WOF_2667 

:WOF_2597
gosub @WOF_7344 
jump @WOF_2667 

:WOF_2611
gosub @WOF_7670 
jump @WOF_2667 

:WOF_2625
gosub @WOF_7814 
jump @WOF_2667 

:WOF_2639
gosub @WOF_7848 
jump @WOF_2667 

:WOF_2653
gosub @WOF_9496 
jump @WOF_2667 

:WOF_2667
gosub @WOF_13533 
if 
  5@ == 1 
jf @WOF_2772 
if 
  15@ == 0 
jf @WOF_2748 
if 
00E1:   player 0 pressed_key 15 
jf @WOF_2741 
13@ = 1 
15@ = 1 

:WOF_2741
jump @WOF_2772 

:WOF_2748
if 
80E1:   not player 0 pressed_key 15 
jf @WOF_2772 
15@ = 0 

:WOF_2772
if 
   Actor.Dead(7@)
jf @WOF_2813 
if 
  5@ > 0 
jf @WOF_2813 
13@ = 1 

:WOF_2813
return 

:WOF_2815
if 
  6@ == 0 
jf @WOF_4076 
if 
   Player.Defined(" + PlayerChar + @")
jf @WOF_4069 
09BD: allow_other_threads_to_display_text_boxes 1 
Player.CanMove(" + PlayerChar + @") = False
Object.StorePos(0@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
06BA: AS_actor " + PlayerActor + @" turn_to_and_look_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
03F0: enable_text_draw 1 
0581: enable_radar 0 
04ED: load_animation ""CASINO"" 
00BE: text_clear_all 
10@ = 0 

:WOF_2915
if 
  6 > 10@ 
jf @WOF_3053 
" + _9387 + @" = -0.118 
0086: " + tmp_9388 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9394 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9400 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9406 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9412 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9418 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9424 + @"(10@,6f) = " + _9387 + @" 
0086: " + tmp_9430 + @"(10@,6f) = " + _9387 + @" 
10@ += 1 
jump @WOF_2915 

:WOF_3053
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.634 0.253 " + tmp_9388 + @"[0] 
" + tmp_9339 + @"[0] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9339 + @"[0]) = 20@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.201 0.253 " + tmp_9388 + @"[1] 
" + tmp_9339 + @"[1] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9339 + @"[1]) = 20@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.243 0.253 " + tmp_9388 + @"[2] 
" + tmp_9339 + @"[2] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9339 + @"[2]) = 20@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.635 -0.106 " + tmp_9388 + @"[3] 
" + tmp_9339 + @"[3] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9339 + @"[3]) = 20@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.201 -0.106 " + tmp_9388 + @"[4] 
" + tmp_9339 + @"[4] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9339 + @"[4]) = 20@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.243 -0.106 " + tmp_9388 + @"[5] 
" + tmp_9339 + @"[5] = Object.Init(#CHIP_STACK07, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + tmp_9339 + @"[5]) = 20@
10@ = 0 

:WOF_3372
if 
  6 > 10@ 
jf @WOF_3458 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset 0.07 0.0 0.0 
" + tmp_9345 + @"(10@,6i) = Object.Init(#CHIP_STACK08, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3372 

:WOF_3458
10@ = 0 

:WOF_3465
if 
  6 > 10@ 
jf @WOF_3551 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset -0.07 0.0 0.0 
" + tmp_9351 + @"(10@,6i) = Object.Init(#CHIP_STACK09, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3465 

:WOF_3551
10@ = 0 

:WOF_3558
if 
  6 > 10@ 
jf @WOF_3644 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset 0.07 0.07 0.0 
" + tmp_9357 + @"(10@,6i) = Object.Init(#CHIP_STACK10, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3558 

:WOF_3644
10@ = 0 

:WOF_3651
if 
  6 > 10@ 
jf @WOF_3737 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset 0.07 -0.07 0.0 
" + tmp_9363 + @"(10@,6i) = Object.Init(#CHIP_STACK11, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3651 

:WOF_3737
10@ = 0 

:WOF_3744
if 
  6 > 10@ 
jf @WOF_3830 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset -0.07 0.07 0.0 
" + tmp_9369 + @"(10@,6i) = Object.Init(#CHIP_STACK12, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3744 

:WOF_3830
10@ = 0 

:WOF_3837
if 
  6 > 10@ 
jf @WOF_3923 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset -0.07 -0.07 0.0 
" + tmp_9375 + @"(10@,6i) = Object.Init(#CHIP_STACK13, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3837 

:WOF_3923
10@ = 0 

:WOF_3930
if 
  6 > 10@ 
jf @WOF_4016 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object " + tmp_9339 + @"(10@,6i) with_offset 0.0 0.07 0.0 
" + tmp_9381 + @"(10@,6i) = Object.Init(#CHIP_STACK14, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
10@ += 1 
jump @WOF_3930 

:WOF_4016
" + _9325 + @" = 0 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.635 0.253 0.041 
" + _9436 + @" = Object.Init(#ROULETTE_MARKER, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_4069
6@ += 1 

:WOF_4076
if 
  6@ == 1 
jf @WOF_4122 
if 
04EE:   animation ""CASINO"" loaded 
jf @WOF_4122 
6@ += 1 

:WOF_4122
if 
  6@ == 2 
jf @WOF_4147 
6@ = 99 

:WOF_4147
if 
  6@ == 99 
jf @WOF_4179 
5@ += 1 
6@ = 0 

:WOF_4179
return 

:WOF_4181
if 
  6@ == 0 
jf @WOF_4648 
10@ = 0 

:WOF_4206
if 
  6 > 10@ 
jf @WOF_4249 
" + tmp_9327 + @"(10@,6i) = 0 
10@ += 1 
jump @WOF_4206 

:WOF_4249
" + _9333 + @" = 0 
" + _9334 + @" = 0 
TIMERA = 0 
TIMERB = 0 
0512: show_permanent_text_box 'WOFHD01'  
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 -0.7 0.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Actor.Angle(" + PlayerActor + @") = 20@
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.7734 -0.6326 0.9882 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.4684 -0.0634 0.2246 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
if 
03CA:   object " + _9436 + @" exists 
jf @WOF_4473 
0750: set_object " + _9436 + @" visibility 1 

:WOF_4473
23@ = 0.0 
24@ = 0.0 
" + _9438 + @" = 0 
" + _9439 + @" = 0 
if 
   not Actor.Dead(7@)
jf @WOF_4641 
0209: 10@ = random_int_in_ranges 0 2 
0871: init_jump_table 10@ total_jumps 2 default_jump 0 @WOF_4641 jumps 0 @WOF_4595 1 @WOF_4618 -1 @WOF_4641 -1 @WOF_4641 -1 @WOF_4641 -1 @WOF_4641 -1 @WOF_4641 

:WOF_4595
09D6: unknown_set_actor 7@ sound 43600 flags 1 1 0 
jump @WOF_4641 

:WOF_4618
09D6: unknown_set_actor 7@ sound 43601 flags 1 1 0 
jump @WOF_4641 

:WOF_4641
6@ += 1 

:WOF_4648
if 
  6@ == 1 
jf @WOF_7308 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
if 
   not 17@ == 0 
jf @WOF_4820 
10@ = 0 
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 9 
00E1:   player 0 pressed_key 10 
00E1:   player 0 pressed_key 11 
jf @WOF_4749 
10@ = 1 

:WOF_4749
if or
  " + Move_Axis_Y + @" > 100 
  -100 > " + Move_Axis_Y + @" 
  " + Move_Axis_X + @" > 100 
  -100 > " + Move_Axis_X + @" 
jf @WOF_4795 
10@ = 1 

:WOF_4795
if 
  10@ == 0 
jf @WOF_4820 
17@ = 0 

:WOF_4820
0085: 10@ = 17@ 
if or
00E1:   player 0 pressed_key 8 
  -100 > " + Move_Axis_Y + @" 
jf @WOF_4859 
17@ = 1 

:WOF_4859
if or
00E1:   player 0 pressed_key 9 
  " + Move_Axis_Y + @" > 100 
jf @WOF_4890 
17@ = 2 

:WOF_4890
if or
00E1:   player 0 pressed_key 10 
  -100 > " + Move_Axis_X + @" 
jf @WOF_4921 
17@ = 3 

:WOF_4921
if or
00E1:   player 0 pressed_key 11 
  " + Move_Axis_X + @" > 100 
jf @WOF_4952 
17@ = 4 

:WOF_4952
if 
803B:   not  17@ == 10@ 
jf @WOF_5226 
if 
  17@ == 4 
jf @WOF_5056 
if or
  " + _9334 + @" == 0 
  " + _9334 + @" == 1 
  " + _9334 + @" == 3 
  " + _9334 + @" == 4 
jf @WOF_5042 
" + _9334 + @" += 1 
jump @WOF_5049 

:WOF_5042
" + _9334 + @" += -2 

:WOF_5049
TIMERA = 0 

:WOF_5056
if 
  17@ == 3 
jf @WOF_5141 
if or
  " + _9334 + @" == 1 
  " + _9334 + @" == 2 
  " + _9334 + @" == 4 
  " + _9334 + @" == 5 
jf @WOF_5127 
" + _9334 + @" += -1 
jump @WOF_5134 

:WOF_5127
" + _9334 + @" += 2 

:WOF_5134
TIMERA = 0 

:WOF_5141
if or
  17@ == 1 
  17@ == 2 
jf @WOF_5226 
if or
  " + _9334 + @" == 0 
  " + _9334 + @" == 1 
  " + _9334 + @" == 2 
jf @WOF_5212 
" + _9334 + @" += 3 
jump @WOF_5219 

:WOF_5212
" + _9334 + @" += -3 

:WOF_5219
TIMERA = 0 

:WOF_5226
if 
00E1:   player 0 pressed_key 14 
jf @WOF_5817 
if and
   not 16@ == 1 
   not 16@ == -1 
jf @WOF_5766 
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) >= 100000 
jf @WOF_5308 
" + _9335 + @" = 10000 
jump @WOF_5494 

:WOF_5308
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) >= 10000 
jf @WOF_5346 
" + _9335 + @" = 1000 
jump @WOF_5494 

:WOF_5346
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) >= 1000 
jf @WOF_5383 
" + _9335 + @" = 100 
jump @WOF_5494 

:WOF_5383
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) >= 100 
jf @WOF_5419 
" + _9335 + @" = 10 
jump @WOF_5494 

:WOF_5419
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) == 0 
jf @WOF_5487 
if 
  " + _9334 + @" == 2 
jf @WOF_5473 
" + _9335 + @" = 5 
jump @WOF_5480 

:WOF_5473
" + _9335 + @" = 2 

:WOF_5480
jump @WOF_5494 

:WOF_5487
" + _9335 + @" = 1 

:WOF_5494
10@ = Player.Money(" + PlayerChar + @")
gosub @WOF_11541 
005C: 10@ += " + Max_Wager + @" 
if 
001E:   " + _9335 + @" > 10@ 
jf @WOF_5544 
008A: " + _9335 + @" = 10@ 

:WOF_5544
" + _9333 + @" = 0 
10@ = 0 

:WOF_5558
if 
  6 > 10@ 
jf @WOF_5602 
0058: " + _9333 + @" += " + tmp_9327 + @"(10@,6i) 
10@ += 1 
jump @WOF_5558 

:WOF_5602
0085: 10@ = 19@ 
0064: 10@ -= " + _9333 + @" 
if 
001E:   " + _9335 + @" > 10@ 
jf @WOF_5645 
008A: " + _9335 + @" = 10@ 

:WOF_5645
if 
  0 > " + _9335 + @" 
jf @WOF_5670 
" + _9335 + @" *= -1 

:WOF_5670
0058: " + tmp_9327 + @"(" + _9334 + @",6i) += " + _9335 + @" 
0058: " + _9438 + @" += " + _9335 + @" 
0058: " + _9439 + @" += " + _9335 + @" 
" + _9335 + @" *= -1 
Player.Money(" + PlayerChar + @") += " + _9335 + @"
16@ += 1 
if 
  16@ > 1 
jf @WOF_5752 
16@ = 2 
jump @WOF_5759 

:WOF_5752
TIMERA = 0 

:WOF_5759
jump @WOF_5810 

:WOF_5766
if 
  16@ == 1 
jf @WOF_5810 
if 
  TIMERA > 500 
jf @WOF_5810 
16@ = 2 

:WOF_5810
jump @WOF_6337 

:WOF_5817
if 
00E1:   player 0 pressed_key 17 
jf @WOF_6312 
if 
   not 18@ == 1 
jf @WOF_6279 
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) > 100000 
jf @WOF_5892 
" + _9335 + @" = -10000 
jump @WOF_6010 

:WOF_5892
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) > 10000 
jf @WOF_5930 
" + _9335 + @" = -1000 
jump @WOF_6010 

:WOF_5930
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) > 1000 
jf @WOF_5967 
" + _9335 + @" = -100 
jump @WOF_6010 

:WOF_5967
if 
  " + tmp_9327 + @"(" + _9334 + @",6i) > 100 
jf @WOF_6003 
" + _9335 + @" = -10 
jump @WOF_6010 

:WOF_6003
" + _9335 + @" = -1 

:WOF_6010
008B: 10@ = " + tmp_9327 + @"(" + _9334 + @",6i) 
0058: " + tmp_9327 + @"(" + _9334 + @",6i) += " + _9335 + @" 
if 
  " + _9334 + @" == 2 
jf @WOF_6107 
if 
  5 > " + tmp_9327 + @"(" + _9334 + @",6i) 
jf @WOF_6100 
" + tmp_9327 + @"(" + _9334 + @",6i) = 0 
008A: " + _9335 + @" = 10@ 
" + _9335 + @" *= -1 

:WOF_6100
jump @WOF_6155 

:WOF_6107
if 
  2 > " + tmp_9327 + @"(" + _9334 + @",6i) 
jf @WOF_6155 
" + tmp_9327 + @"(" + _9334 + @",6i) = 0 
008A: " + _9335 + @" = 10@ 
" + _9335 + @" *= -1 

:WOF_6155
if 
  0 > " + tmp_9327 + @"(" + _9334 + @",6i) 
jf @WOF_6195 
" + tmp_9327 + @"(" + _9334 + @",6i) = 0 
jump @WOF_6226 

:WOF_6195
0058: " + _9438 + @" += " + _9335 + @" 
0058: " + _9439 + @" += " + _9335 + @" 
" + _9335 + @" *= -1 
Player.Money(" + PlayerChar + @") += " + _9335 + @"

:WOF_6226
18@ += 1 
if 
  18@ > 1 
jf @WOF_6265 
18@ = 2 
jump @WOF_6272 

:WOF_6265
TIMERA = 0 

:WOF_6272
jump @WOF_6305 

:WOF_6279
if 
  TIMERA > 500 
jf @WOF_6305 
18@ = 2 

:WOF_6305
jump @WOF_6337 

:WOF_6312
if 
   not 18@ == 0 
jf @WOF_6337 
18@ = 0 

:WOF_6337
" + _9333 + @" = 0 
10@ = 0 

:WOF_6351
if 
  6 > 10@ 
jf @WOF_6395 
0058: " + _9333 + @" += " + tmp_9327 + @"(10@,6i) 
10@ += 1 
jump @WOF_6351 

:WOF_6395
if 
  " + _9334 + @" == 0 
jf @WOF_6456 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.635 0.253 0.041 
Object.PutAt(" + _9436 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_6456
if 
  " + _9334 + @" == 1 
jf @WOF_6517 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.201 0.253 0.041 
Object.PutAt(" + _9436 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_6517
if 
  " + _9334 + @" == 2 
jf @WOF_6578 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.243 0.253 0.041 
Object.PutAt(" + _9436 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_6578
if 
  " + _9334 + @" == 3 
jf @WOF_6639 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.635 -0.106 0.041 
Object.PutAt(" + _9436 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_6639
if 
  " + _9334 + @" == 4 
jf @WOF_6700 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.201 -0.106 0.041 
Object.PutAt(" + _9436 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_6700
if 
  " + _9334 + @" == 5 
jf @WOF_6761 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset 0.243 -0.106 0.041 
Object.PutAt(" + _9436 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_6761
0871: init_jump_table " + Current_Language + @" total_jumps 1 default_jump 1 @WOF_6864 jumps 3 @WOF_6824 -1 @WOF_6904 -1 @WOF_6904 -1 @WOF_6904 -1 @WOF_6904 -1 @WOF_6904 -1 @WOF_6904 

:WOF_6824
0937: text_draw_box_cornerA 29.0 220.0 cornerB 173.0 409.0 GXT_reference 'BJ_TITL' style 2  
jump @WOF_6904 

:WOF_6864
0937: text_draw_box_cornerA 29.0 220.0 cornerB 157.0 409.0 GXT_reference 'BJ_TITL' style 2  
jump @WOF_6904 

:WOF_6904
gosub @WOF_11748 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 240.0 GXT 'WOF_04'  
gosub @WOF_11748 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 260.0 GXT 'DOLLAR' number " + tmp_9327 + @"(" + _9334 + @",6i)  
gosub @WOF_11748 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 290.0 GXT 'WOF_05'  
gosub @WOF_11748 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 310.0 GXT 'DOLLAR' number " + _9333 + @"  
gosub @WOF_11748 
0340: set_text_draw_RGBA 134 155 184 255 
033E: set_draw_text_position 36.0 340.0 GXT 'BJ_03'  
gosub @WOF_11748 
033F: set_text_draw_letter_size 0.6253 2.7876 
045A: draw_text_1number 36.0 360.0 GXT 'DOLLAR' number 19@  
if 
00E1:   player 0 pressed_key 16 
jf @WOF_7283 
if 
  16@ == 0 
jf @WOF_7276 
if 
  " + _9333 + @" > 0 
jf @WOF_7269 
0623: add " + _9333 + @" to_integer_stat 35 
008F: 8@ = integer " + _9333 + @" to_float 
8@ *= 0.001 
0624: add 8@ to_float_stat 81 
TIMERA = 0 
" + _9439 + @" = 0 
6@ = 99 

:WOF_7269
16@ = 1 

:WOF_7276
jump @WOF_7308 

:WOF_7283
if 
   not 16@ == 0 
jf @WOF_7308 
16@ = 0 

:WOF_7308
if 
  6@ == 99 
jf @WOF_7342 
03E6: remove_text_box 
5@ += 1 
6@ = 0 

:WOF_7342
return 

:WOF_7344
if 
   not Actor.Dead(7@)
jf @WOF_7668 
0605: actor 7@ perform_animation ""WOF"" IFP ""CASINO"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0209: 10@ = random_int_in_ranges 0 3 
0871: init_jump_table 10@ total_jumps 3 default_jump 0 @WOF_7534 jumps 0 @WOF_7465 1 @WOF_7488 2 @WOF_7511 -1 @WOF_7534 -1 @WOF_7534 -1 @WOF_7534 -1 @WOF_7534 

:WOF_7465
09D6: unknown_set_actor 7@ sound 43608 flags 1 1 0 
jump @WOF_7534 

:WOF_7488
09D6: unknown_set_actor 7@ sound 43609 flags 1 1 0 
jump @WOF_7534 

:WOF_7511
09D6: unknown_set_actor 7@ sound 43610 flags 1 1 0 
jump @WOF_7534 

:WOF_7534
25@ = 0 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -1.3681 -2.0088 0.7317 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 2@ with_offset -0.8154 -1.1754 0.7401 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 2)
if 
03CA:   object " + _9436 + @" exists 
jf @WOF_7661 
0750: set_object " + _9436 + @" visibility 0 

:WOF_7661
5@ += 1 

:WOF_7668
return 

:WOF_7670
if and
  2.0 > 23@ 
  25@ > 1 
jf @WOF_7812 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 4@ with_offset -0.3059 -0.9385 0.4225 
Camera.SetPosition(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 0.0, 0.0, 0.0)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 4@ with_offset -0.0298 -0.0515 0.7929 
0460: set_camera_transverse_delay 0.0 time 6000 
Camera.PointAt(" + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @", 1)
5@ += 1 

:WOF_7812
return 

:WOF_7814
if 
  25@ == 4 
jf @WOF_7846 
6@ = 0 
5@ += 1 

:WOF_7846
return 

:WOF_7848
if 
  6@ == 0 
jf @WOF_9049 
0087: 8@ = 21@ 
8@ -= 3.333333 
if 
  0.0 > 8@ 
jf @WOF_7915 
8@ += 360.0 

:WOF_7915
8@ /= 6.666667 
0090: " + _9336 + @" = float 8@ to_integer 
" + _9336 + @" += 1 
gosub @WOF_11803 
10@ = 0 
" + _9338 + @" = 0 
if 
  " + _9337 + @" == 1 
jf @WOF_8012 
if 
  " + tmp_9327 + @"[2] > 0 
jf @WOF_8012 
" + _9338 + @" = 2 
0068: " + _9338 + @" *= " + tmp_9327 + @"[2] 

:WOF_8012
if 
  " + _9337 + @" == 2 
jf @WOF_8063 
if 
  " + tmp_9327 + @"[4] > 0 
jf @WOF_8063 
" + _9338 + @" = 3 
0068: " + _9338 + @" *= " + tmp_9327 + @"[4] 

:WOF_8063
if 
  " + _9337 + @" == 5 
jf @WOF_8114 
if 
  " + tmp_9327 + @"[1] > 0 
jf @WOF_8114 
" + _9338 + @" = 6 
0068: " + _9338 + @" *= " + tmp_9327 + @"[1] 

:WOF_8114
if 
  " + _9337 + @" == 10 
jf @WOF_8165 
if 
  " + tmp_9327 + @"[3] > 0 
jf @WOF_8165 
" + _9338 + @" = 11 
0068: " + _9338 + @" *= " + tmp_9327 + @"[3] 

:WOF_8165
if 
  " + _9337 + @" == 20 
jf @WOF_8216 
if 
  " + tmp_9327 + @"[0] > 0 
jf @WOF_8216 
" + _9338 + @" = 21 
0068: " + _9338 + @" *= " + tmp_9327 + @"[0] 

:WOF_8216
if 
  " + _9337 + @" == 40 
jf @WOF_8267 
if 
  " + tmp_9327 + @"[5] > 0 
jf @WOF_8267 
" + _9338 + @" = 41 
0068: " + _9338 + @" *= " + tmp_9327 + @"[5] 

:WOF_8267
TIMERA = 0 
008B: 10@ = " + _9338 + @" 
0064: 10@ -= " + _9438 + @" 
Player.Money(" + PlayerChar + @") += " + _9338 + @"
if 
  10@ > 0 
jf @WOF_8330 
0623: add 10@ to_integer_stat 37 
jump @WOF_8330 

:WOF_8330" );
                create_thread<CASHWIN>( _local10, 3000 );
                AppendLine( @"08F8: display_stat_update_box 0 
if 
  10@ > 0 
jf @WOF_9003 
0627: update_integer_stat 38 to 10@ 
0093: 8@ = integer 10@ to_float 
0093: 9@ = integer 19@ to_float 
0073: 8@ /= 9@ 
" + _9325 + @" += 1 
if 
  3 > " + _9325 + @" 
jf @WOF_8832 
if 
  8@ > 0.9 
jf @WOF_8654 
if 
   Player.Defined(" + PlayerChar + @")
jf @WOF_8647 
if 
   not Actor.Dead(7@)
jf @WOF_8647 
0209: 10@ = random_int_in_ranges 0 5 
0871: init_jump_table 10@ total_jumps 4 default_jump 1 @WOF_8633 jumps 0 @WOF_8547 1 @WOF_8570 2 @WOF_8593 3 @WOF_8616 -1 @WOF_8647 -1 @WOF_8647 -1 @WOF_8647 

:WOF_8547
09D6: unknown_set_actor 7@ sound 43648 flags 1 1 0 
jump @WOF_8647 

:WOF_8570
09D6: unknown_set_actor 7@ sound 43649 flags 1 1 0 
jump @WOF_8647 

:WOF_8593
09D6: unknown_set_actor 7@ sound 43650 flags 1 1 0 
jump @WOF_8647 

:WOF_8616
0947: actor " + PlayerActor + @" speak_from_audio_table 100 store_spoken_phrase_id_to 10@ 
jump @WOF_8647 

:WOF_8633
gosub @WOF_9227 
jump @WOF_8647 

:WOF_8647
jump @WOF_8825 

:WOF_8654
if 
   not Actor.Dead(7@)
jf @WOF_8825 
0209: 10@ = random_int_in_ranges 0 10 
0871: init_jump_table 10@ total_jumps 3 default_jump 1 @WOF_8811 jumps 0 @WOF_8742 1 @WOF_8765 2 @WOF_8788 -1 @WOF_8825 -1 @WOF_8825 -1 @WOF_8825 -1 @WOF_8825 

:WOF_8742
09D6: unknown_set_actor 7@ sound 43648 flags 1 1 0 
jump @WOF_8825 

:WOF_8765
09D6: unknown_set_actor 7@ sound 43649 flags 1 1 0 
jump @WOF_8825 

:WOF_8788
09D6: unknown_set_actor 7@ sound 43650 flags 1 1 0 
jump @WOF_8825 

:WOF_8811
gosub @WOF_9227 
jump @WOF_8825 

:WOF_8825
jump @WOF_8996 

:WOF_8832
if 
   not Actor.Dead(7@)
jf @WOF_8989 
0209: 10@ = random_int_in_ranges 0 3 
0871: init_jump_table 10@ total_jumps 3 default_jump 0 @WOF_8989 jumps 0 @WOF_8920 1 @WOF_8943 2 @WOF_8966 -1 @WOF_8989 -1 @WOF_8989 -1 @WOF_8989 -1 @WOF_8989 

:WOF_8920
09D6: unknown_set_actor 7@ sound 43662 flags 1 1 0 
jump @WOF_8989 

:WOF_8943
09D6: unknown_set_actor 7@ sound 43663 flags 1 1 0 
jump @WOF_8989 

:WOF_8966
09D6: unknown_set_actor 7@ sound 43664 flags 1 1 0 
jump @WOF_8989 

:WOF_8989
" + _9325 + @" = 0 

:WOF_8996
jump @WOF_9038 

:WOF_9003
10@ *= -1 
0627: update_integer_stat 39 to 10@ 
10@ *= -1 
gosub @WOF_9227 
" + _9325 + @" = 0 

:WOF_9038
08F8: display_stat_update_box 1 
6@ += 1 

:WOF_9049
if 
  6@ == 1 
jf @WOF_9100 
if 
  3000 > TIMERA 
jf @WOF_9093 
jump @WOF_9100 

:WOF_9093
6@ += 1 

:WOF_9100
if 
  6@ == 2 
jf @WOF_9193 
0512: show_permanent_text_box 'WOF_09'  
10@ = 0 

:WOF_9136
if 
  6 > 10@ 
jf @WOF_9179 
" + tmp_9327 + @"(10@,6i) = 0 
10@ += 1 
jump @WOF_9136 

:WOF_9179
TIMERA = 0 
6@ = 99 

:WOF_9193
if 
  6@ == 99 
jf @WOF_9225 
TIMERA = 0 
5@ += 1 

:WOF_9225
return 

:WOF_9227
if 
   not Actor.Dead(7@)
jf @WOF_9494 
0871: init_jump_table " + _9337 + @" total_jumps 6 default_jump 0 @WOF_9494 jumps 1 @WOF_9306 2 @WOF_9329 5 @WOF_9352 10 @WOF_9375 20 @WOF_9398 40 @WOF_9421 -1 @WOF_9494 

:WOF_9306
09D6: unknown_set_actor 7@ sound 43655 flags 1 1 0 
jump @WOF_9494 

:WOF_9329
09D6: unknown_set_actor 7@ sound 43656 flags 1 1 0 
jump @WOF_9494 

:WOF_9352
09D6: unknown_set_actor 7@ sound 43657 flags 1 1 0 
jump @WOF_9494 

:WOF_9375
09D6: unknown_set_actor 7@ sound 43658 flags 1 1 0 
jump @WOF_9494 

:WOF_9398
09D6: unknown_set_actor 7@ sound 43659 flags 1 1 0 
jump @WOF_9494 

:WOF_9421
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @WOF_9471 
09D6: unknown_set_actor 7@ sound 43660 flags 1 1 0 
jump @WOF_9487 

:WOF_9471
09D6: unknown_set_actor 7@ sound 43661 flags 1 1 0 

:WOF_9487
jump @WOF_9494 

:WOF_9494
return 

:WOF_9496
if 
00E1:   player 0 pressed_key 16 
jf @WOF_9538 
16@ = -1 
00BE: text_clear_all 
03E6: remove_text_box 
5@ = 1 
6@ = 0 

:WOF_9538
return 
0904: get_interface 6 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 3 
081C: draw_text_outline 3 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.2 4.0 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 0 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 3 
081C: draw_text_outline 3 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.2 4.0 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 4 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 3 
081C: draw_text_outline 3 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 1.2 4.0 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 
0904: get_interface 4 color_RGBA_to " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0340: set_text_draw_RGBA " + _9201 + @" " + _9202 + @" " + _9203 + @" " + _9204 + @" 
0349: set_text_draw_font 2 
081C: draw_text_outline 2 RGBA 0 0 0 255 
033F: set_text_draw_letter_size 0.52 1.45 
0341: set_text_draw_align_justify 1 
03E4: set_text_draw_align_right 0 
0343: set_text_draw_linewidth 1000.0 
0348: enable_text_draw_proportional 1 
0342: set_text_draw_centered 1 
0345: enable_text_draw_background 0 
return 

:WOF_9892
0871: init_jump_table 25@ total_jumps 5 default_jump 0 @WOF_10591 jumps 0 @WOF_9955 1 @WOF_9991 2 @WOF_10050 3 @WOF_10220 4 @WOF_10584 -1 @WOF_10591 -1 @WOF_10591 

:WOF_9955
0208: 24@ = random_float_in_ranges 0.1 0.15 
TIMERB = 0 
25@ += 1 
jump @WOF_10591 

:WOF_9991
007B: 23@ += frame_delta_time * 24@ 
007B: 22@ += frame_delta_time * 23@ 
if 
  TIMERB > 500 
jf @WOF_10043 
24@ = -0.005 
25@ += 1 

:WOF_10043
jump @WOF_10591 

:WOF_10050
007B: 23@ += frame_delta_time * 24@ 
007B: 22@ += frame_delta_time * 23@ 
if 
  0.3 > 23@ 
jf @WOF_10213 
0087: 21@ = 22@ 
0087: 8@ = 21@ 
8@ /= 6.6667 
0092: 10@ = float 8@ to_integer 
0093: 9@ = integer 10@ to_float 
0063: 8@ -= 9@ 
8@ += -1.0 
8@ *= -1.0 
8@ *= 6.666667 
005B: 21@ += 8@ 
if 
  21@ > 360.0 
jf @WOF_10206 
21@ += -360.0 

:WOF_10206
25@ += 1 

:WOF_10213
jump @WOF_10591 

:WOF_10220
0087: 8@ = 22@ 
0063: 8@ -= 21@ 
if 
  -180.0 > 8@ 
jf @WOF_10267 
8@ += 360.0 

:WOF_10267
if 
  8@ > 180.0 
jf @WOF_10298 
8@ += -360.0 

:WOF_10298
if 
  23@ > 0.01 
jf @WOF_10416 
if 
  8@ > 3.333333 
jf @WOF_10409 
0087: 22@ = 21@ 
22@ += 3.333333 
if 
  22@ > 360.0 
jf @WOF_10389 
22@ += -360.0 

:WOF_10389
23@ *= -1.0 
24@ *= -1.0 

:WOF_10409
jump @WOF_10561 

:WOF_10416
if 
  -0.01 > 23@ 
jf @WOF_10534 
if 
  -3.333333 > 8@ 
jf @WOF_10527 
0087: 22@ = 21@ 
22@ -= 3.333333 
if 
  0.0 > 22@ 
jf @WOF_10507 
22@ += 360.0 

:WOF_10507
23@ *= -1.0 
24@ *= -1.0 

:WOF_10527
jump @WOF_10561 

:WOF_10534
23@ = 0.0 
24@ = 0.0 
25@ += 1 

:WOF_10561
007B: 23@ += frame_delta_time * 24@ 
007B: 22@ += frame_delta_time * 23@ 
jump @WOF_10591 

:WOF_10584
jump @WOF_10591 

:WOF_10591
if 
   not 23@ == 0.0 
jf @WOF_10690 
if 
  22@ > 360.0 
jf @WOF_10643 
22@ += -360.0 

:WOF_10643
if 
  0.0 > 22@ 
jf @WOF_10674 
22@ += 360.0 

:WOF_10674
0453: set_object 0@ XYZ_rotation 0.0 22@ 20@ 

:WOF_10690
if 
03CA:   object 1@ exists 
jf @WOF_11173 
if 
  23@ > 0.2 
jf @WOF_11095 
if 
  0.8 > 23@ 
jf @WOF_11032 
0087: 8@ = 22@ 
8@ += 3.33333 
8@ /= 6.6667 
0092: 10@ = float 8@ to_integer 
0093: 9@ = integer 10@ to_float 
0063: 8@ -= 9@ 
8@ += -1.0 
8@ *= -1.0 
8@ *= 6.666667 
if 
  8@ > 5.0 
jf @WOF_10959 
8@ += -5.0 
8@ /= 1.66667 
8@ += -1.0 
8@ *= -1.0 
8@ *= 5.0 
0087: 26@ = 8@ 
26@ *= -1.0 
if 
   not 27@ == 1 
jf @WOF_10952 
097B: play_audio_at_object 1@ event 1027 
27@ = 1 

:WOF_10952
jump @WOF_11025 

:WOF_10959
0079: 26@ += frame_delta_time * 0.5 
if 
  26@ > 0.0 
jf @WOF_11000 
26@ = 0.0 

:WOF_11000
if 
   not 27@ == 0 
jf @WOF_11025 
27@ = 0 

:WOF_11025
jump @WOF_11088 

:WOF_11032
if 
  26@ == -5.0 
jf @WOF_11078 
26@ = -2.0 
097B: play_audio_at_object 1@ event 1027 
jump @WOF_11088 

:WOF_11078
26@ = -5.0 

:WOF_11088
jump @WOF_11157 

:WOF_11095
if 
  0.0 > 26@ 
jf @WOF_11157 
0079: 26@ += frame_delta_time * 0.5 
if 
  26@ > 0.0 
jf @WOF_11157 
26@ = 0.0 

:WOF_11157
0453: set_object 1@ XYZ_rotation 0.0 26@ 20@ 

:WOF_11173
return 

:WOF_11175
09BD: allow_other_threads_to_display_text_boxes 0 
13@ = 0 
5@ = 0 
6@ = 0 
if 
  " + _9439 + @" > 0 
jf @WOF_11226 
Player.Money(" + PlayerChar + @") += " + _9439 + @"

:WOF_11226
" + _9439 + @" = 0 
if 
   not Actor.Dead(7@)
jf @WOF_11315 
0209: 10@ = random_int_in_ranges 0 2 
if 
  10@ == 0 
jf @WOF_11299 
09D6: unknown_set_actor 7@ sound 43653 flags 1 1 0 
jump @WOF_11315 

:WOF_11299
09D6: unknown_set_actor 7@ sound 43654 flags 1 1 0 

:WOF_11315
if 
   Player.Defined(" + PlayerChar + @")
jf @WOF_11338 
Player.CanMove(" + PlayerChar + @") = True

:WOF_11338" );
                end_thread_named<CASHWIN>();
AppendLine( @"03F0: enable_text_draw 0 
0581: enable_radar 1 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
10@ = 0 

:WOF_11368
if 
  6 > 10@ 
jf @WOF_11472 
Object.Destroy(" + tmp_9339 + @"(10@,6i))
Object.Destroy(" + tmp_9345 + @"(10@,6i))
Object.Destroy(" + tmp_9351 + @"(10@,6i))
Object.Destroy(" + tmp_9357 + @"(10@,6i))
Object.Destroy(" + tmp_9363 + @"(10@,6i))
Object.Destroy(" + tmp_9369 + @"(10@,6i))
Object.Destroy(" + tmp_9375 + @"(10@,6i))
Object.Destroy(" + tmp_9381 + @"(10@,6i))
10@ += 1 
jump @WOF_11368 

:WOF_11472
Object.Destroy(" + _9436 + @")
08DA: remove_panel " + _9437 + @" 
if and
8A2A:   not text_box 'SGPUNT' displayed  
8A2A:   not text_box 'SGGAMB' displayed  
8A2A:   not text_box 'SGPROF' displayed  
8A2A:   not text_box 'SGHIRO' displayed  
jf @WOF_11539 
03E6: remove_text_box 

:WOF_11539
return 

:WOF_11541
0653: 8@ = float_stat 81 
if 
  1.0 > 8@ 
jf @WOF_11583 
" + Max_Wager + @" = 100 
jump @WOF_11703 

:WOF_11583
if 
  10.0 > 8@ 
jf @WOF_11619 
" + Max_Wager + @" = 1000 
jump @WOF_11703 

:WOF_11619
if 
  100.0 > 8@ 
jf @WOF_11655 
" + Max_Wager + @" = 10000 
jump @WOF_11703 

:WOF_11655
if 
  1000.0 > 8@ 
jf @WOF_11693 
" + Max_Wager + @" = 100000 
jump @WOF_11703 

:WOF_11693
" + Max_Wager + @" = 1000000 

:WOF_11703
return 
033F: set_text_draw_letter_size 0.4487 1.5974 
0340: set_text_draw_RGBA 128 148 178 255 
0341: set_text_draw_align_justify 1 
0343: set_text_draw_linewidth 2000.0 
0348: enable_text_draw_proportional 1 
return 

:WOF_11748
0340: set_text_draw_RGBA 180 180 180 255 
033F: set_text_draw_letter_size 0.4714 2.5077 
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0342: set_text_draw_centered 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
return 

:WOF_11803
if 
  " + _9336 + @" == 1 
jf @WOF_11835 
" + _9337 + @" = 40 
jump @WOF_13531 

:WOF_11835
if 
  " + _9336 + @" == 2 
jf @WOF_11867 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_11867
if 
  " + _9336 + @" == 3 
jf @WOF_11899 
" + _9337 + @" = 10 
jump @WOF_13531 

:WOF_11899
if 
  " + _9336 + @" == 4 
jf @WOF_11931 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_11931
if 
  " + _9336 + @" == 5 
jf @WOF_11963 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_11963
if 
  " + _9336 + @" == 6 
jf @WOF_11995 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_11995
if 
  " + _9336 + @" == 7 
jf @WOF_12027 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_12027
if 
  " + _9336 + @" == 8 
jf @WOF_12059 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12059
if 
  " + _9336 + @" == 9 
jf @WOF_12091 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12091
if 
  " + _9336 + @" == 10 
jf @WOF_12123 
" + _9337 + @" = 10 
jump @WOF_13531 

:WOF_12123
if 
  " + _9336 + @" == 11 
jf @WOF_12155 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12155
if 
  " + _9336 + @" == 12 
jf @WOF_12187 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12187
if 
  " + _9336 + @" == 13 
jf @WOF_12219 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12219
if 
  " + _9336 + @" == 14 
jf @WOF_12251 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_12251
if 
  " + _9336 + @" == 15 
jf @WOF_12283 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12283
if 
  " + _9336 + @" == 16 
jf @WOF_12315 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12315
if 
  " + _9336 + @" == 17 
jf @WOF_12347 
" + _9337 + @" = 20 
jump @WOF_13531 

:WOF_12347
if 
  " + _9336 + @" == 18 
jf @WOF_12379 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12379
if 
  " + _9336 + @" == 19 
jf @WOF_12411 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12411
if 
  " + _9336 + @" == 20 
jf @WOF_12443 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_12443
if 
  " + _9336 + @" == 21 
jf @WOF_12475 
" + _9337 + @" = 10 
jump @WOF_13531 

:WOF_12475
if 
  " + _9336 + @" == 22 
jf @WOF_12507 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12507
if 
  " + _9336 + @" == 23 
jf @WOF_12539 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12539
if 
  " + _9336 + @" == 24 
jf @WOF_12571 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12571
if 
  " + _9336 + @" == 25 
jf @WOF_12603 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_12603
if 
  " + _9336 + @" == 26 
jf @WOF_12635 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12635
if 
  " + _9336 + @" == 27 
jf @WOF_12667 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12667
if 
  " + _9336 + @" == 28 
jf @WOF_12699 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12699
if 
  " + _9336 + @" == 29 
jf @WOF_12731 
" + _9337 + @" = 40 
jump @WOF_13531 

:WOF_12731
if 
  " + _9336 + @" == 30 
jf @WOF_12763 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12763
if 
  " + _9336 + @" == 31 
jf @WOF_12795 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12795
if 
  " + _9336 + @" == 32 
jf @WOF_12827 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12827
if 
  " + _9336 + @" == 33 
jf @WOF_12859 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12859
if 
  " + _9336 + @" == 34 
jf @WOF_12891 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12891
if 
  " + _9336 + @" == 35 
jf @WOF_12923 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_12923
if 
  " + _9336 + @" == 36 
jf @WOF_12955 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_12955
if 
  " + _9336 + @" == 37 
jf @WOF_12987 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_12987
if 
  " + _9336 + @" == 38 
jf @WOF_13019 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13019
if 
  " + _9336 + @" == 39 
jf @WOF_13051 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_13051
if 
  " + _9336 + @" == 40 
jf @WOF_13083 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13083
if 
  " + _9336 + @" == 41 
jf @WOF_13115 
" + _9337 + @" = 20 
jump @WOF_13531 

:WOF_13115
if 
  " + _9336 + @" == 42 
jf @WOF_13147 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13147
if 
  " + _9336 + @" == 43 
jf @WOF_13179 
" + _9337 + @" = 10 
jump @WOF_13531 

:WOF_13179
if 
  " + _9336 + @" == 44 
jf @WOF_13211 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13211
if 
  " + _9336 + @" == 45 
jf @WOF_13243 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_13243
if 
  " + _9336 + @" == 46 
jf @WOF_13275 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13275
if 
  " + _9336 + @" == 47 
jf @WOF_13307 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_13307
if 
  " + _9336 + @" == 48 
jf @WOF_13339 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13339
if 
  " + _9336 + @" == 49 
jf @WOF_13371 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_13371
if 
  " + _9336 + @" == 50 
jf @WOF_13403 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13403
if 
  " + _9336 + @" == 51 
jf @WOF_13435 
" + _9337 + @" = 5 
jump @WOF_13531 

:WOF_13435
if 
  " + _9336 + @" == 52 
jf @WOF_13467 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13467
if 
  " + _9336 + @" == 53 
jf @WOF_13499 
" + _9337 + @" = 2 
jump @WOF_13531 

:WOF_13499
if 
  " + _9336 + @" == 54 
jf @WOF_13531 
" + _9337 + @" = 1 
jump @WOF_13531 

:WOF_13531
return 

:WOF_13533
if 
0736:   is_keyboard_key_just_pressed 85 
jf @WOF_13575 
" + _9387 + @" += 0.001 
0664: printfloat ""CHIP_SET_Z"" " + _9387 + @" 

:WOF_13575
if 
0736:   is_keyboard_key_just_pressed 74 
jf @WOF_13617 
" + _9387 + @" += -0.001 
0664: printfloat ""CHIP_SET_Z"" " + _9387 + @" 

:WOF_13617
10@ = 0 

:WOF_13624
if 
  6 > 10@ 
jf @WOF_15503 
008B: 12@ = " + tmp_9327 + @"(10@,6i) 
0093: 8@ = integer 12@ to_float 
8@ /= 1.0 
if 
  8@ > 10.0 
jf @WOF_13703 
8@ = 10.0 

:WOF_13703
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_13757 
9@ += 0.03 

:WOF_13757
0086: " + tmp_9388 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9388 + @"(10@,6f) += 9@ 
11@ *= -1 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9339 + @"(10@,6i) exists 
jf @WOF_13883 
Object.StorePos(" + tmp_9339 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9388 + @"(10@,6f) 
Object.PutAt(" + tmp_9339 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_13883
0093: 8@ = integer 12@ to_float 
8@ /= 5.0 
if 
  8@ > 10.0 
jf @WOF_13932 
8@ = 10.0 

:WOF_13932
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_13986 
9@ += 0.03 

:WOF_13986
0086: " + tmp_9394 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9394 + @"(10@,6f) += 9@ 
11@ *= -5 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9345 + @"(10@,6i) exists 
jf @WOF_14112 
Object.StorePos(" + tmp_9345 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9394 + @"(10@,6f) 
Object.PutAt(" + tmp_9345 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_14112
0093: 8@ = integer 12@ to_float 
8@ /= 10.0 
if 
  8@ > 10.0 
jf @WOF_14161 
8@ = 10.0 

:WOF_14161
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_14215 
9@ += 0.03 

:WOF_14215
0086: " + tmp_9400 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9400 + @"(10@,6f) += 9@ 
11@ *= -10 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9351 + @"(10@,6i) exists 
jf @WOF_14341 
Object.StorePos(" + tmp_9351 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9400 + @"(10@,6f) 
Object.PutAt(" + tmp_9351 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_14341
0093: 8@ = integer 12@ to_float 
8@ /= 50.0 
if 
  8@ > 10.0 
jf @WOF_14390 
8@ = 10.0 

:WOF_14390
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_14444 
9@ += 0.03 

:WOF_14444
0086: " + tmp_9406 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9406 + @"(10@,6f) += 9@ 
11@ *= -50 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9357 + @"(10@,6i) exists 
jf @WOF_14570 
Object.StorePos(" + tmp_9357 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9406 + @"(10@,6f) 
Object.PutAt(" + tmp_9357 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_14570
0093: 8@ = integer 12@ to_float 
8@ /= 100.0 
if 
  8@ > 10.0 
jf @WOF_14619 
8@ = 10.0 

:WOF_14619
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_14673 
9@ += 0.03 

:WOF_14673
0086: " + tmp_9412 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9412 + @"(10@,6f) += 9@ 
11@ *= -100 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9363 + @"(10@,6i) exists 
jf @WOF_14799 
Object.StorePos(" + tmp_9363 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9412 + @"(10@,6f) 
Object.PutAt(" + tmp_9363 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_14799
0093: 8@ = integer 12@ to_float 
8@ /= 200.0 
if 
  8@ > 10.0 
jf @WOF_14848 
8@ = 10.0 

:WOF_14848
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_14902 
9@ += 0.03 

:WOF_14902
0086: " + tmp_9418 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9418 + @"(10@,6f) += 9@ 
11@ *= -200 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9369 + @"(10@,6i) exists 
jf @WOF_15029 
Object.StorePos(" + tmp_9369 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9418 + @"(10@,6f) 
Object.PutAt(" + tmp_9369 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_15029
0093: 8@ = integer 12@ to_float 
8@ /= 500.0 
if 
  8@ > 10.0 
jf @WOF_15078 
8@ = 10.0 

:WOF_15078
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_15132 
9@ += 0.03 

:WOF_15132
0086: " + tmp_9424 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9424 + @"(10@,6f) += 9@ 
11@ *= -500 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9375 + @"(10@,6i) exists 
jf @WOF_15259 
Object.StorePos(" + tmp_9375 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9424 + @"(10@,6f) 
Object.PutAt(" + tmp_9375 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_15259
0093: 8@ = integer 12@ to_float 
8@ /= 1000.0 
if 
  8@ > 10.0 
jf @WOF_15308 
8@ = 10.0 

:WOF_15308
0092: 11@ = float 8@ to_integer 
0093: 9@ = integer 11@ to_float 
9@ *= 0.0126 
if 
  11@ > 0 
jf @WOF_15362 
9@ += 0.03 

:WOF_15362
0086: " + tmp_9430 + @"(10@,6f) = " + _9387 + @" 
005F: " + tmp_9430 + @"(10@,6f) += 9@ 
11@ *= -1000 
005A: 12@ += 11@ 
if 
03CA:   object " + tmp_9381 + @"(10@,6i) exists 
jf @WOF_15489 
Object.StorePos(" + tmp_9381 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 8@ 8@ " + tempvar_Float_3 + @" from_object 2@ with_offset 0.0 0.0 " + tmp_9430 + @"(10@,6f) 
Object.PutAt(" + tmp_9381 + @"(10@,6i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:WOF_15489
10@ += 1 
jump @WOF_13624 

:WOF_15503
return 

:WOF_15505
if 
03CA:   object 0@ exists 
jf @WOF_15865 
0653: 8@ = float_stat 81 
if 
  " + _9450 + @" == 0 
jf @WOF_15715 
if 
  1.0 > 8@ 
jf @WOF_15581 
19@ = 100 
jump @WOF_15701 

:WOF_15581
if 
  10.0 > 8@ 
jf @WOF_15617 
19@ = 1000 
jump @WOF_15701 

:WOF_15617
if 
  100.0 > 8@ 
jf @WOF_15653 
19@ = 10000 
jump @WOF_15701 

:WOF_15653
if 
  1000.0 > 8@ 
jf @WOF_15691 
19@ = 100000 
jump @WOF_15701 

:WOF_15691
19@ = 1000000 

:WOF_15701
" + _9450 + @" += 1 
jump @WOF_15865 

:WOF_15715
0209: 10@ = random_int_in_ranges 0 5 
0871: init_jump_table 10@ total_jumps 5 default_jump 0 @WOF_15865 jumps 0 @WOF_15787 1 @WOF_15801 2 @WOF_15816 3 @WOF_15831 4 @WOF_15848 -1 @WOF_15865 -1 @WOF_15865 

:WOF_15787
19@ = 100 
jump @WOF_15865 

:WOF_15801
19@ = 1000 
jump @WOF_15865 

:WOF_15816
19@ = 10000 
jump @WOF_15865 

:WOF_15831
19@ = 100000 
jump @WOF_15865 

:WOF_15848
19@ = 1000000 
jump @WOF_15865 

:WOF_15865
return 
0454: store_debug_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
03CA:   object 4@ exists 
jf @WOF_15916 
Object.StorePos(4@, " + _9441 + @", " + _9442 + @", " + _9443 + @")
" + tempvar_Angle + @" = Object.Angle(4@)

:WOF_15916
" + tempvar_Angle + @" *= -1.0 
02F7: 8@ = cosine " + tempvar_Angle + @" 
02F6: 9@ = sine " + tempvar_Angle + @" 
0086: " + _9444 + @" = " + tempvar_Float_1 + @" 
0061: " + _9444 + @" -= " + _9441 + @" 
0086: " + _9445 + @" = " + tempvar_Float_2 + @" 
0061: " + _9445 + @" -= " + _9442 + @" 
0086: " + _9446 + @" = " + tempvar_Float_3 + @" 
0061: " + _9446 + @" -= " + _9443 + @" 
0086: " + _9447 + @" = " + _9444 + @" 
006D: " + _9447 + @" *= 8@ 
0086: " + _9449 + @" = " + _9445 + @" 
006D: " + _9449 + @" *= 9@ 
0061: " + _9447 + @" -= " + _9449 + @" 
0086: " + _9448 + @" = " + _9444 + @" 
006D: " + _9448 + @" *= 9@ 
0086: " + _9449 + @" = " + _9445 + @" 
006D: " + _9449 + @" *= 8@ 
0059: " + _9448 + @" += " + _9449 + @" 
03A9: save_newline_to_debug_file 
05B6: 210 
03A8: save_float_to_debug_file " + _9447 + @" 
03A8: save_float_to_debug_file " + _9448 + @" 
03A8: save_float_to_debug_file " + _9446 + @" 
0463: store_debug_camera_target_point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0086: " + _9444 + @" = " + tempvar_Float_1 + @" 
0061: " + _9444 + @" -= " + _9441 + @" 
0086: " + _9445 + @" = " + tempvar_Float_2 + @" 
0061: " + _9445 + @" -= " + _9442 + @" 
0086: " + _9446 + @" = " + tempvar_Float_3 + @" 
0061: " + _9446 + @" -= " + _9443 + @" 
0086: " + _9447 + @" = " + _9444 + @" 
006D: " + _9447 + @" *= 8@ 
0086: " + _9449 + @" = " + _9445 + @" 
006D: " + _9449 + @" *= 9@ 
0061: " + _9447 + @" -= " + _9449 + @" 
0086: " + _9448 + @" = " + _9444 + @" 
006D: " + _9448 + @" *= 9@ 
0086: " + _9449 + @" = " + _9445 + @" 
006D: " + _9449 + @" *= 8@ 
0059: " + _9448 + @" += " + _9449 + @" 
03A9: save_newline_to_debug_file 
05B6: 211 
03A8: save_float_to_debug_file " + _9447 + @" 
03A8: save_float_to_debug_file " + _9448 + @" 
03A8: save_float_to_debug_file " + _9446 + @" 
return 
end_thread" );
            }

        }

    }

}