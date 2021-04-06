using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private class LOWGAME : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"12@ = 0.01 
" + _1020 + @" = 0 
13@ = 0 
16@ = 0 
" + LOWR_Player_Points + @" = 0 
" + LOWR_Opposition_Points + @" = 0 
18@ = 0 
23@ = 0 
24@ = 0 
25@ = -1 
27@ = 0 
19@ = 0 
if 
  13@ == -1 
else_jump @LOWGAME_198 
0@ = Car.Create(#PONY, 0.0, 0.0, 0.0)
1@ = Car.Create(#PONY, 0.0, 0.0, 0.0)
2@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
wait 0 
wait 0 
wait 0 

:LOWGAME_198
if 
056E:   car 0@ defined 
else_jump @LOWGAME_244 
if 
   Car.Wrecked(0@)
else_jump @LOWGAME_237 
jump @LOWGAME_8722 

:LOWGAME_237
jump @LOWGAME_251 

:LOWGAME_244
jump @LOWGAME_8722 

:LOWGAME_251
if 
056E:   car 1@ defined 
else_jump @LOWGAME_297 
if 
   Car.Wrecked(1@)
else_jump @LOWGAME_290 
jump @LOWGAME_8722 

:LOWGAME_290
jump @LOWGAME_304 

:LOWGAME_297
jump @LOWGAME_8722 

:LOWGAME_304
if 
  1 > " + _1022 + @" 
else_jump @LOWGAME_336 
" + _1022 + @" = 1 
jump @LOWGAME_361 

:LOWGAME_336
if 
  " + _1022 + @" > 5 
else_jump @LOWGAME_361 
" + _1022 + @" = 5 

:LOWGAME_361
if 
   not Car.Wrecked(0@)
else_jump @LOWGAME_391 
Car.StorePos(0@, 3@, 4@, 5@)

:LOWGAME_391
if 
   not Car.Wrecked(1@)
else_jump @LOWGAME_421 
Car.StorePos(1@, 6@, 7@, 8@)

:LOWGAME_421
" + _1017 + @" = 1 

:LOWGAME_428
wait 0 
if 
  5 > 13@ 
else_jump @LOWGAME_480 
if 
856E:   not car 0@ defined 
else_jump @LOWGAME_480 
" + _1044 + @" = 1 
13@ = 5 

:LOWGAME_480
0871: init_jump_table 13@ total_jumps 6 default_jump 0 @LOWGAME_7662 jumps 0 @LOWGAME_543 1 @LOWGAME_1319 2 @LOWGAME_1399 3 @LOWGAME_7512 4 @LOWGAME_7526 5 @LOWGAME_7601 -1 @LOWGAME_7662 

:LOWGAME_543
01EB: set_traffic_density_multiplier_to 0.0 
03DE: set_pedestrians_density_multiplier_to 0.0 
0395: clear_area 1 at 3@ 4@ 5@ radius 200.0 
04ED: load_animation ""LOWRIDER"" 

:LOWGAME_587
if 
84EE:   not animation ""LOWRIDER"" loaded 
else_jump @LOWGAME_621 
wait 0 
jump @LOWGAME_587 

:LOWGAME_621
if 
   not Car.Wrecked(0@)
else_jump @LOWGAME_696 
Car.DoorStatus(0@) = 4
0221: set_player " + PlayerChar + @" apply_brakes_to_car 1 
Car.SetImmunities(0@, 1, 1, 1, 1, 1)
" + tempvar_Float_1 + @" = 0.62 
" + tempvar_Float_2 + @" = 0.31 
" + tempvar_Float_3 + @" = -0.167 

:LOWGAME_696
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_HURRY"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_HAIR"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
0643: set_AS_pack 15@ loop 1 
0616: define_AS_pack_end 15@ 
if 
   not Actor.Dead(2@)
else_jump @LOWGAME_1068 
if 
0A32:   actor 2@ on_turret_of_car 
else_jump @LOWGAME_1068 
0618: assign_actor 2@ to_AS_pack 15@ 

:LOWGAME_1068
16@ = 0 
if 
   not Car.Wrecked(0@)
else_jump @LOWGAME_1224 
if or
   Car.Model(0@) == #REMINGTN
   Car.Model(0@) == #SLAMVAN
   Car.Model(0@) == #TORNADO
else_jump @LOWGAME_1140 
16@ = 1 
jump @LOWGAME_1224 

:LOWGAME_1140
if or
   Car.Model(0@) == #BLADE
   Car.Model(0@) == #BROADWAY
   Car.Model(0@) == #SAVANNA
else_jump @LOWGAME_1217 
096D: get_car 0@ component_on_slot 7 model_to 17@ 
if 
   not 17@ == -1 
else_jump @LOWGAME_1210 
16@ = 1 

:LOWGAME_1210
jump @LOWGAME_1224 

:LOWGAME_1217
16@ = 1 

:LOWGAME_1224
if 
   not Actor.Dead(2@)
else_jump @LOWGAME_1263 
if 
8A32:   not actor 2@ on_turret_of_car 
else_jump @LOWGAME_1263 
16@ = 1 

:LOWGAME_1263
" + _1027 + @" = 0 
" + _1028 + @" = 0 
" + _1029 + @" = 0 
" + LOWR_Player_Points + @" = 0 
" + LOWR_Last_Displayed_Text_ID + @" = 0 
" + LOWR_Opposition_Points + @" = 0 
13@ += 1 
jump @LOWGAME_7662 

:LOWGAME_1319
0953: get_soundtrack_status_to 17@ 
if 
04A4:   17@ == 3 
else_jump @LOWGAME_1392 
04F7: status_text " + LOWR_Player_Points + @" type 0 line 1 GXT 'LOWR1' 
04F7: status_text " + LOWR_Opposition_Points + @" type 0 line 2 GXT 'LOWR2' 
13@ += 1 
32@ = 0 

:LOWGAME_1392
jump @LOWGAME_7662 

:LOWGAME_1399
0953: get_soundtrack_status_to 17@ 
if 
0736:   is_keyboard_key_just_pressed 32 
else_jump @LOWGAME_1429 
32@ = 90000 

:LOWGAME_1429
07B1: unknown_get_dance_track -1 store_to 20@ 21@ 22@ 
if 
   not 21@ == 33 
else_jump @LOWGAME_7491 
09EE: set_status_text_stay_on_screen 1 
gosub @LOWGAME_10566 
07B1: unknown_get_dance_track 0 store_to 20@ 21@ 22@ 
if 
803B:   not  22@ == 25@ 
else_jump @LOWGAME_2071 
28@ = -1 
if 
   not 18@ == 0 
else_jump @LOWGAME_1984 
if and
  20@ > -35 
  35 > 20@ 
else_jump @LOWGAME_1607 
if 
003B:   18@ == 21@ 
else_jump @LOWGAME_1586 
28@ = 0 
jump @LOWGAME_1600 

:LOWGAME_1586
23@ = 1 
28@ = 5 

:LOWGAME_1600
jump @LOWGAME_1878 

:LOWGAME_1607
if and
  20@ > -50 
  50 > 20@ 
else_jump @LOWGAME_1686 
if 
003B:   18@ == 21@ 
else_jump @LOWGAME_1665 
28@ = 1 
jump @LOWGAME_1679 

:LOWGAME_1665
23@ = 1 
28@ = 5 

:LOWGAME_1679
jump @LOWGAME_1878 

:LOWGAME_1686
if and
  20@ > -100 
  100 > 20@ 
else_jump @LOWGAME_1765 
if 
003B:   18@ == 21@ 
else_jump @LOWGAME_1744 
28@ = 2 
jump @LOWGAME_1758 

:LOWGAME_1744
23@ = 1 
28@ = 5 

:LOWGAME_1758
jump @LOWGAME_1878 

:LOWGAME_1765
if or
  20@ > -200 
  200 > 20@ 
else_jump @LOWGAME_1878 
if 
003B:   18@ == 21@ 
else_jump @LOWGAME_1864 
23@ = 1 
if 
  0 > 20@ 
else_jump @LOWGAME_1850 
28@ = 3 
jump @LOWGAME_1857 

:LOWGAME_1850
28@ = 4 

:LOWGAME_1857
jump @LOWGAME_1878 

:LOWGAME_1864
23@ = 1 
28@ = 5 

:LOWGAME_1878
" + _1043 + @" = 1 
if 
  28@ == 0 
else_jump @LOWGAME_1924 
04AE: " + _1043 + @" = 3 
30@ += 1 
jump @LOWGAME_1977 

:LOWGAME_1924
if 
  28@ == 1 
else_jump @LOWGAME_1963 
04AE: " + _1043 + @" = 2 
30@ += 1 
jump @LOWGAME_1977 

:LOWGAME_1963
04AE: " + _1043 + @" = 1 
31@ += 1 

:LOWGAME_1977
jump @LOWGAME_2024 

:LOWGAME_1984
if 
  -200 > 20@ 
else_jump @LOWGAME_2024 
23@ = 1 
28@ = 3 
31@ += 1 

:LOWGAME_2024
if 
   not 28@ == -1 
else_jump @LOWGAME_2071 
gosub @LOWGAME_9681 
gosub @LOWGAME_10047 
gosub @LOWGAME_8731 
0085: 25@ = 22@ 

:LOWGAME_2071
if 
  0 > " + LOWR_Player_Points + @" 
else_jump @LOWGAME_2096 
" + LOWR_Player_Points + @" = 0 

:LOWGAME_2096
if 
   not Car.Wrecked(0@)
else_jump @LOWGAME_2239 
if 
81AD:   not car 0@ sphere 0 near_point 3@ 4@ radius 3.0 3.0 
else_jump @LOWGAME_2239 
Car.StorePos(0@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 9@ = 3@ 
0065: 9@ -= " + tempvar_Float_1 + @" 
0087: 10@ = 4@ 
0065: 10@ -= " + tempvar_Float_2 + @" 
006B: 9@ *= 12@ 
006B: 10@ *= 12@ 
07D5: set_car 0@ velocity_in_direction_XYZ 9@ 10@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWGAME_2239
if 
   not Car.Wrecked(1@)
else_jump @LOWGAME_2382 
if 
81AD:   not car 1@ sphere 0 near_point 6@ 7@ radius 3.0 3.0 
else_jump @LOWGAME_2382 
Car.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 9@ = 6@ 
0065: 9@ -= " + tempvar_Float_1 + @" 
0087: 10@ = 7@ 
0065: 10@ -= " + tempvar_Float_2 + @" 
006B: 9@ *= 12@ 
006B: 10@ *= 12@ 
07D5: set_car 1@ velocity_in_direction_XYZ 9@ 10@ 0.0 rotation_velocitiesXY 0.0 0.0 unk 0.0 

:LOWGAME_2382
if and
  100 > 20@ 
  20@ > -100 
else_jump @LOWGAME_2912 
if 
  21@ == 9 
else_jump @LOWGAME_2465 
" + _1023 + @" = 1.0 
" + _1024 + @" = 1.0 
" + _1025 + @" = 0.0 
" + _1026 + @" = 0.0 

:LOWGAME_2465
if 
  21@ == 10 
else_jump @LOWGAME_2523 
" + _1023 + @" = 0.0 
" + _1024 + @" = 0.0 
" + _1025 + @" = 1.0 
" + _1026 + @" = 1.0 

:LOWGAME_2523
if 
  21@ == 11 
else_jump @LOWGAME_2581 
" + _1023 + @" = 0.0 
" + _1024 + @" = 0.0 
" + _1025 + @" = 1.0 
" + _1026 + @" = 0.0 

:LOWGAME_2581
if 
  21@ == 12 
else_jump @LOWGAME_2639 
" + _1023 + @" = 0.0 
" + _1024 + @" = 1.0 
" + _1025 + @" = 0.0 
" + _1026 + @" = 0.0 

:LOWGAME_2639
if 
  21@ == 13 
else_jump @LOWGAME_2697 
" + _1023 + @" = 1.0 
" + _1024 + @" = 0.0 
" + _1025 + @" = 1.0 
" + _1026 + @" = 0.0 

:LOWGAME_2697
if 
  21@ == 14 
else_jump @LOWGAME_2755 
" + _1023 + @" = 0.0 
" + _1024 + @" = 1.0 
" + _1025 + @" = 0.0 
" + _1026 + @" = 1.0 

:LOWGAME_2755
if 
  21@ == 15 
else_jump @LOWGAME_2813 
" + _1023 + @" = 1.0 
" + _1024 + @" = 0.0 
" + _1025 + @" = 0.0 
" + _1026 + @" = 0.0 

:LOWGAME_2813
if 
  21@ == 16 
else_jump @LOWGAME_2871 
" + _1023 + @" = 0.0 
" + _1024 + @" = 0.0 
" + _1025 + @" = 0.0 
" + _1026 + @" = 1.0 

:LOWGAME_2871
if 
803B:   not  22@ == 27@ 
else_jump @LOWGAME_2905 
gosub @LOWGAME_7669 
0085: 27@ = 22@ 

:LOWGAME_2905
jump @LOWGAME_2952 

:LOWGAME_2912
" + _1023 + @" = 0.0 
" + _1024 + @" = 0.0 
" + _1025 + @" = 0.0 
" + _1026 + @" = 0.0 

:LOWGAME_2952
if 
   not Car.Wrecked(1@)
else_jump @LOWGAME_3001 
if 
   Car.HasHydraulics(1@)
else_jump @LOWGAME_3001 
07F5: car 1@ control_hydraulics " + _1023 + @" " + _1024 + @" " + _1025 + @" " + _1026 + @" 

:LOWGAME_3001
if 
  16@ == 0 
else_jump @LOWGAME_7453 
if 
  " + _1020 + @" == -1 
else_jump @LOWGAME_3062 
if 
   not 18@ == 0 
else_jump @LOWGAME_3062 
" + _1020 + @" = 0 

:LOWGAME_3062
if 
  " + _1020 + @" == 0 
else_jump @LOWGAME_3112 
if 
  30@ > 5 
else_jump @LOWGAME_3112 
" + _1020 + @" += 1 
30@ = 0 

:LOWGAME_3112
if 
  " + _1020 + @" == 1 
else_jump @LOWGAME_3169 
if 
  30@ > 5 
else_jump @LOWGAME_3169 
" + _1020 + @" += 1 
30@ = 0 
31@ = 0 

:LOWGAME_3169
if 
  " + _1020 + @" == 2 
else_jump @LOWGAME_3258 
if 
  30@ > 5 
else_jump @LOWGAME_3226 
" + _1020 + @" += 1 
30@ = 0 
31@ = 0 

:LOWGAME_3226
if 
  31@ > 1 
else_jump @LOWGAME_3258 
" + _1020 + @" -= 1 
31@ = 0 

:LOWGAME_3258
if 
  " + _1020 + @" == 3 
else_jump @LOWGAME_3347 
if 
  30@ > 5 
else_jump @LOWGAME_3315 
" + _1020 + @" += 1 
30@ = 0 
31@ = 0 

:LOWGAME_3315
if 
  31@ > 1 
else_jump @LOWGAME_3347 
" + _1020 + @" -= 1 
31@ = 0 

:LOWGAME_3347
if 
  " + _1020 + @" == 4 
else_jump @LOWGAME_3436 
if 
  30@ > 5 
else_jump @LOWGAME_3404 
" + _1020 + @" += 1 
30@ = 0 
31@ = 0 

:LOWGAME_3404
if 
  31@ > 1 
else_jump @LOWGAME_3436 
" + _1020 + @" -= 1 
31@ = 0 

:LOWGAME_3436
if 
  " + _1020 + @" == 5 
else_jump @LOWGAME_3493 
if 
  31@ > 1 
else_jump @LOWGAME_3493 
" + _1020 + @" -= 1 
30@ = 0 
31@ = 0 

:LOWGAME_3493
if 
   not Actor.Dead(2@)
else_jump @LOWGAME_7453 
if 
803A:   not  " + _1021 + @" == " + _1020 + @" 
else_jump @LOWGAME_5115 
if 
  " + _1020 + @" == -1 
else_jump @LOWGAME_3699 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_HAIR"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_HURRY"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0643: set_AS_pack 15@ loop 1 
0616: define_AS_pack_end 15@ 

:LOWGAME_3699
if and
  " + _1021 + @" == -1 
  " + _1020 + @" == 0 
else_jump @LOWGAME_3855 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLE_TO_L0"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L0_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_3855
if and
  " + _1021 + @" == 0 
  " + _1020 + @" == 1 
else_jump @LOWGAME_4009 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L0_TO_L1"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L1_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4009
if and
  " + _1021 + @" == 1 
  " + _1020 + @" == 2 
else_jump @LOWGAME_4163 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L1_TO_L2"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L2_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4163
if and
  " + _1021 + @" == 2 
  " + _1020 + @" == 3 
else_jump @LOWGAME_4317 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L2_TO_L3"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L3_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4317
if and
  " + _1021 + @" == 3 
  " + _1020 + @" == 4 
else_jump @LOWGAME_4471 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L3_TO_L4"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L4_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4471
if and
  " + _1021 + @" == 4 
  " + _1020 + @" == 5 
else_jump @LOWGAME_4625 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L4_TO_L5"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L5_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4625
if and
  " + _1021 + @" > 1 
  " + _1020 + @" == 1 
else_jump @LOWGAME_4781 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L345_TO_L1"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L1_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4781
if and
  " + _1021 + @" == 1 
  " + _1020 + @" == 0 
else_jump @LOWGAME_4936 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L12_TO_L0"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 15@ 
0618: assign_actor 2@ to_AS_pack 15@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L0_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_4936
if and
  " + _1021 + @" == 0 
  " + _1020 + @" == -1 
else_jump @LOWGAME_5107 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_HAIR"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_HURRY"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0812: AS_actor -1 perform_animation ""LRGIRL_IDLELOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_5107
0084: " + _1021 + @" = " + _1020 + @" 

:LOWGAME_5115
if and
803B:   not  19@ == 18@ 
   not 18@ == 0 
else_jump @LOWGAME_6256 
17@ = 0 
26@ = 1.0 
if 
   Actor.Animation(2@) == ""LRGIRL_IDLE_TO_L0""
else_jump @LOWGAME_5220 
0613: 26@ = actor 2@ animation ""LRGIRL_IDLE_TO_L0"" time 

:LOWGAME_5220
if 
   Actor.Animation(2@) == ""LRGIRL_L12_TO_L0""
else_jump @LOWGAME_5280 
0613: 26@ = actor 2@ animation ""LRGIRL_L12_TO_L0"" time 

:LOWGAME_5280
if 
   Actor.Animation(2@) == ""LRGIRL_L345_TO_L1""
else_jump @LOWGAME_5342 
0613: 26@ = actor 2@ animation ""LRGIRL_L345_TO_L1"" time 

:LOWGAME_5342
if 
   Actor.Animation(2@) == ""LRGIRL_L0_TO_L1""
else_jump @LOWGAME_5400 
0613: 26@ = actor 2@ animation ""LRGIRL_L0_TO_L1"" time 

:LOWGAME_5400
if 
   Actor.Animation(2@) == ""LRGIRL_L1_TO_L2""
else_jump @LOWGAME_5458 
0613: 26@ = actor 2@ animation ""LRGIRL_L1_TO_L2"" time 

:LOWGAME_5458
if 
   Actor.Animation(2@) == ""LRGIRL_L2_TO_L3""
else_jump @LOWGAME_5516 
0613: 26@ = actor 2@ animation ""LRGIRL_L2_TO_L3"" time 

:LOWGAME_5516
if 
   Actor.Animation(2@) == ""LRGIRL_L3_TO_L4""
else_jump @LOWGAME_5574 
0613: 26@ = actor 2@ animation ""LRGIRL_L3_TO_L4"" time 

:LOWGAME_5574
if 
   Actor.Animation(2@) == ""LRGIRL_L4_TO_L5""
else_jump @LOWGAME_5632 
0613: 26@ = actor 2@ animation ""LRGIRL_L4_TO_L5"" time 

:LOWGAME_5632
if 
   Actor.Animation(2@) == ""LRGIRL_BDBNCE""
else_jump @LOWGAME_5686 
0613: 26@ = actor 2@ animation ""LRGIRL_BDBNCE"" time 

:LOWGAME_5686
if 
  0.9 > 26@ 
else_jump @LOWGAME_5714 
17@ = 1 

:LOWGAME_5714
if 
  17@ == 0 
else_jump @LOWGAME_6248 
if 
  " + _1020 + @" == 0 
else_jump @LOWGAME_5818 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L0_BNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 

:LOWGAME_5818
if 
  " + _1020 + @" == 1 
else_jump @LOWGAME_5904 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L1_BNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 

:LOWGAME_5904
if 
  " + _1020 + @" == 2 
else_jump @LOWGAME_5990 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L2_BNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 

:LOWGAME_5990
if 
  " + _1020 + @" == 3 
else_jump @LOWGAME_6076 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L3_BNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 

:LOWGAME_6076
if 
  " + _1020 + @" == 4 
else_jump @LOWGAME_6162 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L4_BNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 

:LOWGAME_6162
if 
  " + _1020 + @" == 5 
else_jump @LOWGAME_6248 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L5_BNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 

:LOWGAME_6248
0085: 19@ = 18@ 

:LOWGAME_6256
if 
  23@ == 1 
else_jump @LOWGAME_6489 
if 
  18@ == 0 
else_jump @LOWGAME_6482 
if 
  " + _1020 + @" > 0 
else_jump @LOWGAME_6482 
if 
   not Actor.Animation(2@) == ""LRGIRL_BDBNCE""
else_jump @LOWGAME_6468 
0615: define_AS_pack_begin 14@ 
0812: AS_actor -1 perform_animation ""LRGIRL_BDBNCE"" IFP ""LOWRIDER"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
0616: define_AS_pack_end 14@ 
0618: assign_actor 2@ to_AS_pack 14@ 
061B: remove_references_to_AS_pack 14@ 
061B: remove_references_to_AS_pack 15@ 
0615: define_AS_pack_begin 15@ 
0812: AS_actor -1 perform_animation ""LRGIRL_L1_LOOP"" IFP ""LOWRIDER"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 15@ 

:LOWGAME_6468
" + _1020 + @" = 1 
" + _1021 + @" = 1 

:LOWGAME_6482
23@ = 0 

:LOWGAME_6489
17@ = 0 
26@ = 1.0 
if 
   Actor.Animation(2@) == ""LRGIRL_BDBNCE""
else_jump @LOWGAME_6560 
0613: 26@ = actor 2@ animation ""LRGIRL_BDBNCE"" time 

:LOWGAME_6560
if 
   Actor.Animation(2@) == ""LRGIRL_IDLE_TO_L0""
else_jump @LOWGAME_6622 
0613: 26@ = actor 2@ animation ""LRGIRL_IDLE_TO_L0"" time 

:LOWGAME_6622
if 
   Actor.Animation(2@) == ""LRGIRL_L12_TO_L0""
else_jump @LOWGAME_6682 
0613: 26@ = actor 2@ animation ""LRGIRL_L12_TO_L0"" time 

:LOWGAME_6682
if 
   Actor.Animation(2@) == ""LRGIRL_L345_TO_L1""
else_jump @LOWGAME_6744 
0613: 26@ = actor 2@ animation ""LRGIRL_L345_TO_L1"" time 

:LOWGAME_6744
if 
   Actor.Animation(2@) == ""LRGIRL_L0_BNCE""
else_jump @LOWGAME_6800 
0613: 26@ = actor 2@ animation ""LRGIRL_L0_BNCE"" time 

:LOWGAME_6800
if 
   Actor.Animation(2@) == ""LRGIRL_L0_TO_L1""
else_jump @LOWGAME_6858 
0613: 26@ = actor 2@ animation ""LRGIRL_L0_TO_L1"" time 

:LOWGAME_6858
if 
   Actor.Animation(2@) == ""LRGIRL_L1_TO_L2""
else_jump @LOWGAME_6916 
0613: 26@ = actor 2@ animation ""LRGIRL_L1_TO_L2"" time 

:LOWGAME_6916
if 
   Actor.Animation(2@) == ""LRGIRL_L2_TO_L3""
else_jump @LOWGAME_6974 
0613: 26@ = actor 2@ animation ""LRGIRL_L2_TO_L3"" time 

:LOWGAME_6974
if 
   Actor.Animation(2@) == ""LRGIRL_L3_TO_L4""
else_jump @LOWGAME_7032 
0613: 26@ = actor 2@ animation ""LRGIRL_L3_TO_L4"" time 

:LOWGAME_7032
if 
   Actor.Animation(2@) == ""LRGIRL_L4_TO_L5""
else_jump @LOWGAME_7090 
0613: 26@ = actor 2@ animation ""LRGIRL_L4_TO_L5"" time 

:LOWGAME_7090
if 
   Actor.Animation(2@) == ""LRGIRL_L1_BNCE""
else_jump @LOWGAME_7146 
0613: 26@ = actor 2@ animation ""LRGIRL_L1_BNCE"" time 

:LOWGAME_7146
if 
   Actor.Animation(2@) == ""LRGIRL_L2_BNCE""
else_jump @LOWGAME_7202 
0613: 26@ = actor 2@ animation ""LRGIRL_L2_BNCE"" time 

:LOWGAME_7202
if 
   Actor.Animation(2@) == ""LRGIRL_L3_BNCE""
else_jump @LOWGAME_7258 
0613: 26@ = actor 2@ animation ""LRGIRL_L3_BNCE"" time 

:LOWGAME_7258
if 
   Actor.Animation(2@) == ""LRGIRL_L4_BNCE""
else_jump @LOWGAME_7314 
0613: 26@ = actor 2@ animation ""LRGIRL_L4_BNCE"" time 

:LOWGAME_7314
if 
   Actor.Animation(2@) == ""LRGIRL_L5_BNCE""
else_jump @LOWGAME_7370 
0613: 26@ = actor 2@ animation ""LRGIRL_L5_BNCE"" time 

:LOWGAME_7370
if 
  0.9 > 26@ 
else_jump @LOWGAME_7398 
17@ = 1 

:LOWGAME_7398
if 
  17@ == 0 
else_jump @LOWGAME_7453 
062E: get_actor 2@ task 1560 status_store_to 17@ 
if 
04A4:   17@ == 7 
else_jump @LOWGAME_7453 
0618: assign_actor 2@ to_AS_pack 15@ 

:LOWGAME_7453
if 
00E1:   player 0 pressed_key 15 
else_jump @LOWGAME_7484 
" + LOWR_Player_Points + @" = 0 
13@ += 1 

:LOWGAME_7484
jump @LOWGAME_7505 

:LOWGAME_7491
13@ += 1 
32@ = 0 

:LOWGAME_7505
jump @LOWGAME_7662 

:LOWGAME_7512
13@ += 1 
jump @LOWGAME_7662 

:LOWGAME_7526
if 
   Player.Defined(" + PlayerChar + @")
else_jump @LOWGAME_7549 
Player.CanMove(" + PlayerChar + @") = False

:LOWGAME_7549
fade 0 500 

:LOWGAME_7556
if 
fading 
else_jump @LOWGAME_7580 
wait 0 
jump @LOWGAME_7556 

:LOWGAME_7580
" + _1044 + @" = 1 
13@ += 1 
jump @LOWGAME_7662 

:LOWGAME_7601
0953: get_soundtrack_status_to 17@ 
if 
04A4:   17@ == 3 
else_jump @LOWGAME_7626 
0955: end_playing_loaded_soundtrack 

:LOWGAME_7626
0151: remove_status_text " + LOWR_Player_Points + @" 
0151: remove_status_text " + LOWR_Opposition_Points + @" 
04EF: release_animation ""LOWRIDER"" 
jump @LOWGAME_8722 
jump @LOWGAME_7662 

:LOWGAME_7662
jump @LOWGAME_428 

:LOWGAME_7669
0209: 17@ = random_int_in_ranges 0 10 
if or
  " + _1022 + @" == 0 
  " + _1022 + @" == 1 
else_jump @LOWGAME_7894 
0871: init_jump_table 17@ total_jumps 10 default_jump 0 @LOWGAME_7887 jumps 0 @LOWGAME_7831 1 @LOWGAME_7831 2 @LOWGAME_7845 3 @LOWGAME_7845 4 @LOWGAME_7845 5 @LOWGAME_7845 6 @LOWGAME_7859 
0872: jump_table_jumps 7 @LOWGAME_7859 8 @LOWGAME_7859 9 @LOWGAME_7873 -1 @LOWGAME_7887 -1 @LOWGAME_7887 -1 @LOWGAME_7887 -1 @LOWGAME_7887 -1 @LOWGAME_7887 -1 @LOWGAME_7887 

:LOWGAME_7831
" + LOWR_Opposition_Points + @" += 0 
jump @LOWGAME_7887 

:LOWGAME_7845
" + LOWR_Opposition_Points + @" += 10 
jump @LOWGAME_7887 

:LOWGAME_7859
" + LOWR_Opposition_Points + @" += 20 
jump @LOWGAME_7887 

:LOWGAME_7873
" + LOWR_Opposition_Points + @" += 50 
jump @LOWGAME_7887 

:LOWGAME_7887
jump @LOWGAME_8695 

:LOWGAME_7894
if 
  " + _1022 + @" == 2 
else_jump @LOWGAME_8103 
0871: init_jump_table 17@ total_jumps 10 default_jump 0 @LOWGAME_8096 jumps 0 @LOWGAME_8040 1 @LOWGAME_8054 2 @LOWGAME_8054 3 @LOWGAME_8054 4 @LOWGAME_8054 5 @LOWGAME_8068 6 @LOWGAME_8068 
0872: jump_table_jumps 7 @LOWGAME_8068 8 @LOWGAME_8082 9 @LOWGAME_8082 -1 @LOWGAME_8096 -1 @LOWGAME_8096 -1 @LOWGAME_8096 -1 @LOWGAME_8096 -1 @LOWGAME_8096 -1 @LOWGAME_8096 

:LOWGAME_8040
" + LOWR_Opposition_Points + @" += 0 
jump @LOWGAME_8096 

:LOWGAME_8054
" + LOWR_Opposition_Points + @" += 10 
jump @LOWGAME_8096 

:LOWGAME_8068
" + LOWR_Opposition_Points + @" += 20 
jump @LOWGAME_8096 

:LOWGAME_8082
" + LOWR_Opposition_Points + @" += 50 
jump @LOWGAME_8096 

:LOWGAME_8096
jump @LOWGAME_8695 

:LOWGAME_8103
if 
  " + _1022 + @" == 3 
else_jump @LOWGAME_8312 
0871: init_jump_table 17@ total_jumps 10 default_jump 0 @LOWGAME_8305 jumps 0 @LOWGAME_8249 1 @LOWGAME_8263 2 @LOWGAME_8263 3 @LOWGAME_8263 4 @LOWGAME_8277 5 @LOWGAME_8277 6 @LOWGAME_8277 
0872: jump_table_jumps 7 @LOWGAME_8291 8 @LOWGAME_8291 9 @LOWGAME_8291 -1 @LOWGAME_8305 -1 @LOWGAME_8305 -1 @LOWGAME_8305 -1 @LOWGAME_8305 -1 @LOWGAME_8305 -1 @LOWGAME_8305 

:LOWGAME_8249
" + LOWR_Opposition_Points + @" += 0 
jump @LOWGAME_8305 

:LOWGAME_8263
" + LOWR_Opposition_Points + @" += 10 
jump @LOWGAME_8305 

:LOWGAME_8277
" + LOWR_Opposition_Points + @" += 20 
jump @LOWGAME_8305 

:LOWGAME_8291
" + LOWR_Opposition_Points + @" += 50 
jump @LOWGAME_8305 

:LOWGAME_8305
jump @LOWGAME_8695 

:LOWGAME_8312
if 
  " + _1022 + @" == 4 
else_jump @LOWGAME_8507 
0871: init_jump_table 17@ total_jumps 10 default_jump 0 @LOWGAME_8500 jumps 0 @LOWGAME_8458 1 @LOWGAME_8458 2 @LOWGAME_8458 3 @LOWGAME_8472 4 @LOWGAME_8472 5 @LOWGAME_8472 6 @LOWGAME_8472 
0872: jump_table_jumps 7 @LOWGAME_8486 8 @LOWGAME_8486 9 @LOWGAME_8486 -1 @LOWGAME_8500 -1 @LOWGAME_8500 -1 @LOWGAME_8500 -1 @LOWGAME_8500 -1 @LOWGAME_8500 -1 @LOWGAME_8500 

:LOWGAME_8458
" + LOWR_Opposition_Points + @" += 10 
jump @LOWGAME_8500 

:LOWGAME_8472
" + LOWR_Opposition_Points + @" += 20 
jump @LOWGAME_8500 

:LOWGAME_8486
" + LOWR_Opposition_Points + @" += 50 
jump @LOWGAME_8500 

:LOWGAME_8500
jump @LOWGAME_8695 

:LOWGAME_8507
if 
  " + _1022 + @" == 5 
else_jump @LOWGAME_8695 
0871: init_jump_table 17@ total_jumps 10 default_jump 0 @LOWGAME_8695 jumps 0 @LOWGAME_8653 1 @LOWGAME_8653 2 @LOWGAME_8667 3 @LOWGAME_8667 4 @LOWGAME_8667 5 @LOWGAME_8667 6 @LOWGAME_8681 
0872: jump_table_jumps 7 @LOWGAME_8681 8 @LOWGAME_8681 9 @LOWGAME_8681 -1 @LOWGAME_8695 -1 @LOWGAME_8695 -1 @LOWGAME_8695 -1 @LOWGAME_8695 -1 @LOWGAME_8695 -1 @LOWGAME_8695 

:LOWGAME_8653
" + LOWR_Opposition_Points + @" += 10 
jump @LOWGAME_8695 

:LOWGAME_8667
" + LOWR_Opposition_Points + @" += 20 
jump @LOWGAME_8695 

:LOWGAME_8681
" + LOWR_Opposition_Points + @" += 50 
jump @LOWGAME_8695 

:LOWGAME_8695
if 
  0 > " + LOWR_Opposition_Points + @" 
else_jump @LOWGAME_8720 
" + LOWR_Opposition_Points + @" = 0 

:LOWGAME_8720
return 

:LOWGAME_8722
" + _1017 + @" = 0 
end_thread 

:LOWGAME_8731
0871: init_jump_table 28@ total_jumps 3 default_jump 1 @LOWGAME_8844 jumps 0 @LOWGAME_8794 1 @LOWGAME_8811 2 @LOWGAME_8828 -1 @LOWGAME_8860 -1 @LOWGAME_8860 -1 @LOWGAME_8860 -1 @LOWGAME_8860 

:LOWGAME_8794
015B: shake_player_controller 0 time 200 intensity 255 
jump @LOWGAME_8860 

:LOWGAME_8811
015B: shake_player_controller 0 time 200 intensity 200 
jump @LOWGAME_8860 

:LOWGAME_8828
015B: shake_player_controller 0 time 200 intensity 110 
jump @LOWGAME_8860 

:LOWGAME_8844
015B: shake_player_controller 0 time 200 intensity 50 
jump @LOWGAME_8860 

:LOWGAME_8860
0871: init_jump_table 29@ total_jumps 2 default_jump 1 @LOWGAME_8923 jumps 2 @LOWGAME_9175 3 @LOWGAME_9427 -1 @LOWGAME_9679 -1 @LOWGAME_9679 -1 @LOWGAME_9679 -1 @LOWGAME_9679 -1 @LOWGAME_9679 

:LOWGAME_8923
if 
  28@ == 0 
else_jump @LOWGAME_8957 
00BA: show_text_styled GXT 'DNC_005' time 1000 style 5  

:LOWGAME_8957
if 
  28@ == 1 
else_jump @LOWGAME_8991 
00BA: show_text_styled GXT 'DNC_006' time 1000 style 5  

:LOWGAME_8991
if 
  28@ == 2 
else_jump @LOWGAME_9025 
00BA: show_text_styled GXT 'DNC_007' time 1000 style 5  

:LOWGAME_9025
if 
  28@ == 3 
else_jump @LOWGAME_9059 
00BA: show_text_styled GXT 'DNC_008' time 1000 style 5  

:LOWGAME_9059
if 
  28@ == 4 
else_jump @LOWGAME_9093 
00BA: show_text_styled GXT 'DNC_009' time 1000 style 5  

:LOWGAME_9093
if 
  28@ == 5 
else_jump @LOWGAME_9127 
00BA: show_text_styled GXT 'DNC_010' time 1000 style 5  

:LOWGAME_9127
if 
  28@ == 6 
else_jump @LOWGAME_9161 
00BA: show_text_styled GXT 'DNC_011' time 1000 style 5  

:LOWGAME_9161
29@ = 2 
jump @LOWGAME_9679 

:LOWGAME_9175
if 
  28@ == 0 
else_jump @LOWGAME_9209 
00BA: show_text_styled GXT 'DNC_012' time 1000 style 5  

:LOWGAME_9209
if 
  28@ == 1 
else_jump @LOWGAME_9243 
00BA: show_text_styled GXT 'DNC_013' time 1000 style 5  

:LOWGAME_9243
if 
  28@ == 2 
else_jump @LOWGAME_9277 
00BA: show_text_styled GXT 'DNC_014' time 1000 style 5  

:LOWGAME_9277
if 
  28@ == 3 
else_jump @LOWGAME_9311 
00BA: show_text_styled GXT 'DNC_015' time 1000 style 5  

:LOWGAME_9311
if 
  28@ == 4 
else_jump @LOWGAME_9345 
00BA: show_text_styled GXT 'DNC_016' time 1000 style 5  

:LOWGAME_9345
if 
  28@ == 5 
else_jump @LOWGAME_9379 
00BA: show_text_styled GXT 'DNC_017' time 1000 style 5  

:LOWGAME_9379
if 
  28@ == 6 
else_jump @LOWGAME_9413 
00BA: show_text_styled GXT 'DNC_018' time 1000 style 5  

:LOWGAME_9413
29@ += 1 
jump @LOWGAME_9679 

:LOWGAME_9427
if 
  28@ == 0 
else_jump @LOWGAME_9461 
00BA: show_text_styled GXT 'DNC_019' time 1000 style 5  

:LOWGAME_9461
if 
  28@ == 1 
else_jump @LOWGAME_9495 
00BA: show_text_styled GXT 'DNC_020' time 1000 style 5  

:LOWGAME_9495
if 
  28@ == 2 
else_jump @LOWGAME_9529 
00BA: show_text_styled GXT 'DNC_021' time 1000 style 5  

:LOWGAME_9529
if 
  28@ == 3 
else_jump @LOWGAME_9563 
00BA: show_text_styled GXT 'DNC_022' time 1000 style 5  

:LOWGAME_9563
if 
  28@ == 4 
else_jump @LOWGAME_9597 
00BA: show_text_styled GXT 'DNC_023' time 1000 style 5  

:LOWGAME_9597
if 
  28@ == 5 
else_jump @LOWGAME_9631 
00BA: show_text_styled GXT 'DNC_024' time 1000 style 5  

:LOWGAME_9631
if 
  28@ == 6 
else_jump @LOWGAME_9665 
00BA: show_text_styled GXT 'DNC_025' time 1000 style 5  

:LOWGAME_9665
29@ += 1 
jump @LOWGAME_9679 

:LOWGAME_9679
return 

:LOWGAME_9681
008B: 17@ = " + _1028 + @" 
005C: 17@ += " + _1029 + @" 
005C: 17@ += " + _1027 + @" 
if 
  17@ > 0 
else_jump @LOWGAME_10045 
if 
  17@ >= 4 
else_jump @LOWGAME_10045 
if 
  " + _1027 + @" == 4 
else_jump @LOWGAME_9848 
if or
  " + LOWR_Last_Displayed_Text_ID + @" == 1 
  " + LOWR_Last_Displayed_Text_ID + @" == 2 
else_jump @LOWGAME_9816 
00BA: show_text_styled GXT 'DNC_002' time 50000 style 7  
" + LOWR_Last_Displayed_Text_ID + @" = 2 
jump @LOWGAME_9841 

:LOWGAME_9816
00BA: show_text_styled GXT 'DNC_004' time 50000 style 7  
" + LOWR_Last_Displayed_Text_ID + @" = 1 

:LOWGAME_9841
jump @LOWGAME_10024 

:LOWGAME_9848
if 
001C:   " + _1028 + @" > " + _1029 + @" 
else_jump @LOWGAME_9899 
00BA: show_text_styled GXT 'DNC_004' time 50000 style 7  
" + LOWR_Last_Displayed_Text_ID + @" = 1 
jump @LOWGAME_10024 

:LOWGAME_9899
if 
  " + LOWR_Last_Displayed_Text_ID + @" == 2 
else_jump @LOWGAME_9949 
00BA: show_text_styled GXT 'DNC_004' time 50000 style 7  
" + LOWR_Last_Displayed_Text_ID + @" = 1 
jump @LOWGAME_10024 

:LOWGAME_9949
if 
  " + LOWR_Last_Displayed_Text_ID + @" == 1 
else_jump @LOWGAME_9999 
00BA: show_text_styled GXT 'DNC_003' time 50000 style 7  
" + LOWR_Last_Displayed_Text_ID + @" = 0 
jump @LOWGAME_10024 

:LOWGAME_9999
00BA: show_text_styled GXT 'DNC_003' time 50000 style 7  
" + LOWR_Last_Displayed_Text_ID + @" = 0 

:LOWGAME_10024
" + _1027 + @" = 0 
" + _1028 + @" = 0 
" + _1029 + @" = 0 

:LOWGAME_10045
return 

:LOWGAME_10047
0871: init_jump_table 28@ total_jumps 7 default_jump 0 @LOWGAME_10533 jumps 0 @LOWGAME_10110 1 @LOWGAME_10199 2 @LOWGAME_10288 3 @LOWGAME_10377 4 @LOWGAME_10416 5 @LOWGAME_10455 6 @LOWGAME_10494 

:LOWGAME_10110
if 
  999999 > " + LOWR_Player_Points + @" 
else_jump @LOWGAME_10185 
if 
  " + LOWR_Last_Displayed_Text_ID + @" == 2 
else_jump @LOWGAME_10178 
17@ = 50 
17@ *= 10 
005E: " + LOWR_Player_Points + @" += 17@ 
jump @LOWGAME_10185 

:LOWGAME_10178
" + LOWR_Player_Points + @" += 50 

:LOWGAME_10185
" + _1027 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10199
if 
  999999 > " + LOWR_Player_Points + @" 
else_jump @LOWGAME_10274 
if 
  " + LOWR_Last_Displayed_Text_ID + @" == 2 
else_jump @LOWGAME_10267 
17@ = 20 
17@ *= 10 
005E: " + LOWR_Player_Points + @" += 17@ 
jump @LOWGAME_10274 

:LOWGAME_10267
" + LOWR_Player_Points + @" += 20 

:LOWGAME_10274
" + _1028 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10288
if 
  999999 > " + LOWR_Player_Points + @" 
else_jump @LOWGAME_10363 
if 
  " + LOWR_Last_Displayed_Text_ID + @" == 2 
else_jump @LOWGAME_10356 
17@ = 10 
17@ *= 10 
005E: " + LOWR_Player_Points + @" += 17@ 
jump @LOWGAME_10363 

:LOWGAME_10356
" + LOWR_Player_Points + @" += 10 

:LOWGAME_10363
" + _1028 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10377
if 
  " + LOWR_Player_Points + @" > 0 
else_jump @LOWGAME_10402 
" + LOWR_Player_Points + @" += 0 

:LOWGAME_10402
" + _1029 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10416
if 
  " + LOWR_Player_Points + @" > 0 
else_jump @LOWGAME_10441 
" + LOWR_Player_Points + @" += 0 

:LOWGAME_10441
" + _1029 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10455
if 
  " + LOWR_Player_Points + @" > 0 
else_jump @LOWGAME_10480 
" + LOWR_Player_Points + @" += 0 

:LOWGAME_10480
" + _1029 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10494
if 
  " + LOWR_Player_Points + @" > 0 
else_jump @LOWGAME_10519 
" + LOWR_Player_Points + @" += 0 

:LOWGAME_10519
" + _1029 + @" += 1 
jump @LOWGAME_10533 

:LOWGAME_10533
if 
  " + LOWR_Player_Points + @" > 999999 
else_jump @LOWGAME_10564 
" + LOWR_Player_Points + @" = 999999 

:LOWGAME_10564
return 

:LOWGAME_10566
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008F: 26@ = integer " + Special_Axis_X + @" to_float 
0087: 9@ = 26@ 
008F: 26@ = integer " + Special_Axis_Y + @" to_float 
0087: 10@ = 26@ 
0509: 26@ = distance_between_XY 0.0 0.0 and_XY 9@ 10@ 
18@ = 0 
if 
  26@ > 64.0 
else_jump @LOWGAME_10927 
05A4: get_angle_between_vectors_origin_to 9@ 10@ and_origin_to 0.0 -1.0 store_to 26@ 
if 
  15.0 > 26@ 
else_jump @LOWGAME_10719 
18@ = 13 
jump @LOWGAME_10927 

:LOWGAME_10719
if 
  75.0 > 26@ 
else_jump @LOWGAME_10786 
if 
  " + Special_Axis_X + @" > 0 
else_jump @LOWGAME_10772 
18@ = 11 
jump @LOWGAME_10779 

:LOWGAME_10772
18@ = 15 

:LOWGAME_10779
jump @LOWGAME_10927 

:LOWGAME_10786
if 
  105.0 > 26@ 
else_jump @LOWGAME_10853 
if 
  " + Special_Axis_X + @" > 0 
else_jump @LOWGAME_10839 
18@ = 10 
jump @LOWGAME_10846 

:LOWGAME_10839
18@ = 9 

:LOWGAME_10846
jump @LOWGAME_10927 

:LOWGAME_10853
if 
  165.0 > 26@ 
else_jump @LOWGAME_10920 
if 
  " + Special_Axis_X + @" > 0 
else_jump @LOWGAME_10906 
18@ = 16 
jump @LOWGAME_10913 

:LOWGAME_10906
18@ = 12 

:LOWGAME_10913
jump @LOWGAME_10927 

:LOWGAME_10920
18@ = 14 

:LOWGAME_10927
return" );
            }

        }

    }

}