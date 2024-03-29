﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class FBOOTHL : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @FBOOTHL_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:FBOOTHL_60
04ED: load_animation ""FOOD"" 

:FBOOTHL_68
if 
84EE:   not animation ""FOOD"" loaded 
jf @FBOOTHL_98 
wait 0 
jump @FBOOTHL_68 

:FBOOTHL_98
9@ = 0.0 
3@ = 0 
if 
  1@ == 0 
jf @FBOOTHL_154 
5@ = 0 
4@ = 1 
jump @FBOOTHL_168 

:FBOOTHL_154
5@ = -2 
4@ = 2 

:FBOOTHL_168
7@ = 0 
if 
   not Actor.Dead(0@)
jf @FBOOTHL_215 
0446: set_actor 0@ dismemberment_possible 0 
6@ = 1800000 
jump @FBOOTHL_222 

:FBOOTHL_215
6@ = 0 

:FBOOTHL_222
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @FBOOTHL_356 
if 
09C5:   unknown_actor 0@ 
jf @FBOOTHL_342 
if 
  " + FOOD_Player_Aggressive_Flag + @" == 0 
jf @FBOOTHL_302 
gosub @FBOOTHL_370 
jump @FBOOTHL_335 

:FBOOTHL_302
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @FBOOTHL_328 
" + FOOD_Player_Aggressive_Flag + @" = 1 

:FBOOTHL_328
jump @FBOOTHL_2971 

:FBOOTHL_335
jump @FBOOTHL_349 

:FBOOTHL_342
gosub @FBOOTHL_2895 

:FBOOTHL_349
jump @FBOOTHL_363 

:FBOOTHL_356
gosub @FBOOTHL_2895 

:FBOOTHL_363
jump @FBOOTHL_222 

:FBOOTHL_370
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @FBOOTHL_503 jumps 1 @FBOOTHL_433 2 @FBOOTHL_447 3 @FBOOTHL_461 4 @FBOOTHL_475 5 @FBOOTHL_489 -1 @FBOOTHL_503 -1 @FBOOTHL_503 

:FBOOTHL_433
gosub @FBOOTHL_505 
jump @FBOOTHL_503 

:FBOOTHL_447
gosub @FBOOTHL_732 
jump @FBOOTHL_503 

:FBOOTHL_461
gosub @FBOOTHL_2118 
jump @FBOOTHL_503 

:FBOOTHL_475
gosub @FBOOTHL_2895 
jump @FBOOTHL_503 

:FBOOTHL_489
gosub @FBOOTHL_2455 
jump @FBOOTHL_503 

:FBOOTHL_503
return 

:FBOOTHL_505
0871: init_jump_table 5@ total_jumps 2 default_jump 0 @FBOOTHL_730 jumps 0 @FBOOTHL_568 1 @FBOOTHL_628 -1 @FBOOTHL_730 -1 @FBOOTHL_730 -1 @FBOOTHL_730 -1 @FBOOTHL_730 -1 @FBOOTHL_730 

:FBOOTHL_568
0812: AS_actor 0@ perform_animation ""FF_SIT_IN_L"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
3@ = 1 
5@ += 1 
jump @FBOOTHL_730 

:FBOOTHL_628
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_SIT_IN_L""
jf @FBOOTHL_688 
0613: 9@ = actor 0@ animation ""FF_SIT_IN_L"" time 

:FBOOTHL_688
if 
  9@ == 1.0 
jf @FBOOTHL_723 
5@ = 0 
4@ += 1 

:FBOOTHL_723
jump @FBOOTHL_730 

:FBOOTHL_730
return 

:FBOOTHL_732
0871: init_jump_table 5@ total_jumps 5 default_jump 0 @FBOOTHL_2116 jumps -2 @FBOOTHL_795 0 @FBOOTHL_1120 1 @FBOOTHL_1577 2 @FBOOTHL_1819 3 @FBOOTHL_2022 -1 @FBOOTHL_2116 -1 @FBOOTHL_2116 

:FBOOTHL_795
if 
06FF:   any_ped_near_actor 0@ in_range 2.2 
jf @FBOOTHL_865 
0812: AS_actor 0@ perform_animation ""FF_SIT_LOOK"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHL_1106 

:FBOOTHL_865
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 0.0 0.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @FBOOTHL_942 
8@ = Object.Create(#CJ_PIZZA_2, 10@, 11@, 12@)
jump @FBOOTHL_958 

:FBOOTHL_942
8@ = Object.Create(#CJ_BURG_2, 10@, 11@, 12@)

:FBOOTHL_958
070A: AS_actor 0@ attach_to_object 8@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
if 
03A3:   actor 0@ male 
jf @FBOOTHL_1064 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHL_1106 

:FBOOTHL_1064
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:FBOOTHL_1106
5@ = 1 
jump @FBOOTHL_2116 

:FBOOTHL_1120
if 
0737:   actor 0@ lifting_object -1 
jf @FBOOTHL_1252 
if 
03A3:   actor 0@ male 
jf @FBOOTHL_1203 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHL_1245 

:FBOOTHL_1203
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:FBOOTHL_1245
jump @FBOOTHL_1563 

:FBOOTHL_1252
if 
06FF:   any_ped_near_actor 0@ in_range 2.2 
jf @FBOOTHL_1322 
0812: AS_actor 0@ perform_animation ""FF_SIT_LOOK"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHL_1563 

:FBOOTHL_1322
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 0.0 0.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @FBOOTHL_1399 
8@ = Object.Create(#CJ_PIZZA_2, 10@, 11@, 12@)
jump @FBOOTHL_1415 

:FBOOTHL_1399
8@ = Object.Create(#CJ_BURG_2, 10@, 11@, 12@)

:FBOOTHL_1415
070A: AS_actor 0@ attach_to_object 8@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
if 
03A3:   actor 0@ male 
jf @FBOOTHL_1521 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHL_1563 

:FBOOTHL_1521
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:FBOOTHL_1563
5@ += 1 
jump @FBOOTHL_2116 

:FBOOTHL_1577
Actor.StorePos(0@, 13@, 14@, 15@)
15@ -= 1.04 
04C4: store_coords_to 16@ 17@ 18@ from_actor 0@ with_offset -0.1 0.5 0.0 
04C4: store_coords_to 19@ 20@ 21@ from_actor 0@ with_offset -1.0 -0.5 0.0 
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 1.0 0.0 -0.65 
if or
   Actor.Animation(0@) == ""FF_SIT_LOOK""
   Actor.Animation(0@) == ""FF_SIT_EAT1""
   Actor.Animation(0@) == ""FF_SIT_EAT2""
jf @FBOOTHL_1812 
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -366 solid 0 for_actor 0@ 
Actor.PutAt(0@, 10@, 11@, 12@)
Actor.LockInCurrentPosition(0@) = True
TIMERB = 0 
5@ += 1 

:FBOOTHL_1812
jump @FBOOTHL_2116 

:FBOOTHL_1819
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @FBOOTHL_1871 
054E: clear_actor 0@ damage 
6@ = 0 
4@ = 5 
5@ = 0 
jump @FBOOTHL_2116 

:FBOOTHL_1871
if 
001D:   TIMERB > 6@ 
jf @FBOOTHL_2015 
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @FBOOTHL_1952 
5@ = 0 
4@ += 1 
jump @FBOOTHL_2015 

:FBOOTHL_1952
if 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @FBOOTHL_2015 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
5@ += 1 

:FBOOTHL_2015
jump @FBOOTHL_2116 

:FBOOTHL_2022
if 
0184:   actor 0@ health >= 0 
jf @FBOOTHL_2102 
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @FBOOTHL_2095 
5@ = 0 
4@ += 1 

:FBOOTHL_2095
jump @FBOOTHL_2109 

:FBOOTHL_2102
0568: set_actor 0@ untargetable 1 

:FBOOTHL_2109
jump @FBOOTHL_2116 

:FBOOTHL_2116
return 

:FBOOTHL_2118
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @FBOOTHL_2453 jumps 0 @FBOOTHL_2181 1 @FBOOTHL_2264 2 @FBOOTHL_2299 -1 @FBOOTHL_2453 -1 @FBOOTHL_2453 -1 @FBOOTHL_2453 -1 @FBOOTHL_2453 

:FBOOTHL_2181
if 
0737:   actor 0@ lifting_object -1 
jf @FBOOTHL_2206 
070B: set_actor 0@ onbone_attached_object_operation 1 

:FBOOTHL_2206
0812: AS_actor 0@ perform_animation ""FF_SIT_OUT_L_180"" IFP ""FOOD"" framedelta 99.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
5@ += 1 
jump @FBOOTHL_2453 

:FBOOTHL_2264
Actor.PutAt(0@, 13@, 14@, 15@)
Actor.LockInCurrentPosition(0@) = False
5@ += 1 
jump @FBOOTHL_2453 

:FBOOTHL_2299
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_SIT_OUT_L_180""
jf @FBOOTHL_2446 
0613: 9@ = actor 0@ animation ""FF_SIT_OUT_L_180"" time 
if 
  9@ == 1.0 
jf @FBOOTHL_2446 
088D: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model #CJ_PIZZA_CHAIR3 collision_detection 1 
088D: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model #CJ_PIZZA_CHAIR2 collision_detection 0 
5@ = 0 
4@ += 1 

:FBOOTHL_2446
jump @FBOOTHL_2453 

:FBOOTHL_2453
return 

:FBOOTHL_2455
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @FBOOTHL_2893 jumps 0 @FBOOTHL_2518 1 @FBOOTHL_2570 2 @FBOOTHL_2726 -1 @FBOOTHL_2893 -1 @FBOOTHL_2893 -1 @FBOOTHL_2893 -1 @FBOOTHL_2893 

:FBOOTHL_2518
0812: AS_actor 0@ perform_animation ""FF_DAM_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
5@ += 1 
jump @FBOOTHL_2893 

:FBOOTHL_2570
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_DAM_FWD""
jf @FBOOTHL_2656 
0613: 9@ = actor 0@ animation ""FF_DAM_FWD"" time 
if 
  9@ == 1.0 
jf @FBOOTHL_2656 
5@ += 1 

:FBOOTHL_2656
if 
8184:   not actor 0@ health >= 0 
jf @FBOOTHL_2719 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
gosub @FBOOTHL_2895 

:FBOOTHL_2719
jump @FBOOTHL_2893 

:FBOOTHL_2726
if 
8184:   not actor 0@ health >= 0 
jf @FBOOTHL_2796 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
gosub @FBOOTHL_2895 
jump @FBOOTHL_2879 

:FBOOTHL_2796
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @FBOOTHL_2865 
4@ = 3 
5@ = 0 
gosub @FBOOTHL_2971 
jump @FBOOTHL_2879 

:FBOOTHL_2865
4@ = 2 
5@ = 2 

:FBOOTHL_2879
" + FOOD_Player_Aggressive_Flag + @" = 1 
jump @FBOOTHL_2893 

:FBOOTHL_2893
return 

:FBOOTHL_2895
Object.RemoveReferences(8@)
04EF: release_animation ""FOOD"" 
if 
   not Actor.Dead(0@)
jf @FBOOTHL_2967 
0446: set_actor 0@ dismemberment_possible 1 
08A0: actor 0@ in_radius 100.0 near_model #NULL with_offset 0.0 0.0 0.0 end_script_named ""PCUSTOM"" 

:FBOOTHL_2967
end_thread 
return 

:FBOOTHL_2971
wait 0 
if and
8844:   not string " + Current_Shop_GXT_Name + @" empty 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @FBOOTHL_3312 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
jf @FBOOTHL_3305 
0871: init_jump_table 4@ total_jumps 5 default_jump 1 @FBOOTHL_3291 jumps 1 @FBOOTHL_3082 2 @FBOOTHL_3164 3 @FBOOTHL_3213 4 @FBOOTHL_3227 5 @FBOOTHL_3277 -1 @FBOOTHL_3305 -1 @FBOOTHL_3305 

:FBOOTHL_3082
if 
  5@ > 1 
jf @FBOOTHL_3114 
gosub @FBOOTHL_370 
jump @FBOOTHL_3157 

:FBOOTHL_3114
062E: get_actor 0@ task 1477 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @FBOOTHL_3157 
05C5: AS_actor 0@ cower -2 ms 
gosub @FBOOTHL_2895 

:FBOOTHL_3157
jump @FBOOTHL_3305 

:FBOOTHL_3164
if 
  5@ == 2 
jf @FBOOTHL_3199 
0209: 6@ = random_int_in_ranges 0 5 
6@ *= 500 

:FBOOTHL_3199
gosub @FBOOTHL_370 
jump @FBOOTHL_3305 

:FBOOTHL_3213
gosub @FBOOTHL_370 
jump @FBOOTHL_3305 

:FBOOTHL_3227
062E: get_actor 0@ task 1477 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @FBOOTHL_3270 
05C5: AS_actor 0@ cower -2 ms 
gosub @FBOOTHL_2895 

:FBOOTHL_3270
jump @FBOOTHL_3305 

:FBOOTHL_3277
gosub @FBOOTHL_370 
jump @FBOOTHL_3305 

:FBOOTHL_3291
gosub @FBOOTHL_2895 
jump @FBOOTHL_3305 

:FBOOTHL_3305
jump @FBOOTHL_3319 

:FBOOTHL_3312
gosub @FBOOTHL_2895 

:FBOOTHL_3319
jump @FBOOTHL_2971 
0662: printstring ""I__________________________I"" 
0662: printstring ""H"" 
0662: printstring ""G"" 
0662: printstring ""F"" 
0662: printstring ""E"" 
0663: printint ""PEDSTATE"" 4@ 
0663: printint ""SUBSTATESTATUS"" 5@ 
0663: printint ""TIMERB"" TIMERB 
0663: printint ""TIMERA"" TIMERA 
return 
end_thread" );
            }

        }

    }

}