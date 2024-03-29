﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class FBOOTHR : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @FBOOTHR_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:FBOOTHR_60
04ED: load_animation ""FOOD"" 

:FBOOTHR_68
if 
84EE:   not animation ""FOOD"" loaded 
jf @FBOOTHR_98 
wait 0 
jump @FBOOTHR_68 

:FBOOTHR_98
9@ = 0.0 
3@ = 0 
if 
  1@ == 0 
jf @FBOOTHR_154 
5@ = 0 
4@ = 1 
jump @FBOOTHR_168 

:FBOOTHR_154
5@ = -2 
4@ = 2 

:FBOOTHR_168
7@ = 0 
if 
   not Actor.Dead(0@)
jf @FBOOTHR_215 
0446: set_actor 0@ dismemberment_possible 0 
6@ = 1800000 
jump @FBOOTHR_222 

:FBOOTHR_215
6@ = 0 

:FBOOTHR_222
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @FBOOTHR_356 
if 
09C5:   unknown_actor 0@ 
jf @FBOOTHR_342 
if 
  " + FOOD_Player_Aggressive_Flag + @" == 0 
jf @FBOOTHR_302 
gosub @FBOOTHR_370 
jump @FBOOTHR_335 

:FBOOTHR_302
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @FBOOTHR_328 
" + FOOD_Player_Aggressive_Flag + @" = 1 

:FBOOTHR_328
jump @FBOOTHR_2971 

:FBOOTHR_335
jump @FBOOTHR_349 

:FBOOTHR_342
gosub @FBOOTHR_2895 

:FBOOTHR_349
jump @FBOOTHR_363 

:FBOOTHR_356
gosub @FBOOTHR_2895 

:FBOOTHR_363
jump @FBOOTHR_222 

:FBOOTHR_370
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @FBOOTHR_503 jumps 1 @FBOOTHR_433 2 @FBOOTHR_447 3 @FBOOTHR_461 4 @FBOOTHR_475 5 @FBOOTHR_489 -1 @FBOOTHR_503 -1 @FBOOTHR_503 

:FBOOTHR_433
gosub @FBOOTHR_505 
jump @FBOOTHR_503 

:FBOOTHR_447
gosub @FBOOTHR_732 
jump @FBOOTHR_503 

:FBOOTHR_461
gosub @FBOOTHR_2118 
jump @FBOOTHR_503 

:FBOOTHR_475
gosub @FBOOTHR_2895 
jump @FBOOTHR_503 

:FBOOTHR_489
gosub @FBOOTHR_2455 
jump @FBOOTHR_503 

:FBOOTHR_503
return 

:FBOOTHR_505
0871: init_jump_table 5@ total_jumps 2 default_jump 0 @FBOOTHR_730 jumps 0 @FBOOTHR_568 1 @FBOOTHR_628 -1 @FBOOTHR_730 -1 @FBOOTHR_730 -1 @FBOOTHR_730 -1 @FBOOTHR_730 -1 @FBOOTHR_730 

:FBOOTHR_568
0812: AS_actor 0@ perform_animation ""FF_SIT_IN_R"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
3@ = 1 
5@ += 1 
jump @FBOOTHR_730 

:FBOOTHR_628
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_SIT_IN_R""
jf @FBOOTHR_688 
0613: 9@ = actor 0@ animation ""FF_SIT_IN_R"" time 

:FBOOTHR_688
if 
  9@ == 1.0 
jf @FBOOTHR_723 
5@ = 0 
4@ += 1 

:FBOOTHR_723
jump @FBOOTHR_730 

:FBOOTHR_730
return 

:FBOOTHR_732
0871: init_jump_table 5@ total_jumps 5 default_jump 0 @FBOOTHR_2116 jumps -2 @FBOOTHR_795 0 @FBOOTHR_1120 1 @FBOOTHR_1577 2 @FBOOTHR_1819 3 @FBOOTHR_2022 -1 @FBOOTHR_2116 -1 @FBOOTHR_2116 

:FBOOTHR_795
if 
06FF:   any_ped_near_actor 0@ in_range 2.2 
jf @FBOOTHR_865 
0812: AS_actor 0@ perform_animation ""FF_SIT_LOOK"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHR_1106 

:FBOOTHR_865
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 0.0 0.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @FBOOTHR_942 
8@ = Object.Create(#CJ_PIZZA_2, 10@, 11@, 12@)
jump @FBOOTHR_958 

:FBOOTHR_942
8@ = Object.Create(#CJ_BURG_2, 10@, 11@, 12@)

:FBOOTHR_958
070A: AS_actor 0@ attach_to_object 8@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
if 
03A3:   actor 0@ male 
jf @FBOOTHR_1064 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHR_1106 

:FBOOTHR_1064
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:FBOOTHR_1106
5@ = 1 
jump @FBOOTHR_2116 

:FBOOTHR_1120
if 
0737:   actor 0@ lifting_object -1 
jf @FBOOTHR_1252 
if 
03A3:   actor 0@ male 
jf @FBOOTHR_1203 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHR_1245 

:FBOOTHR_1203
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:FBOOTHR_1245
jump @FBOOTHR_1563 

:FBOOTHR_1252
if 
06FF:   any_ped_near_actor 0@ in_range 2.2 
jf @FBOOTHR_1322 
0812: AS_actor 0@ perform_animation ""FF_SIT_LOOK"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHR_1563 

:FBOOTHR_1322
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 0.0 0.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @FBOOTHR_1399 
8@ = Object.Create(#CJ_PIZZA_2, 10@, 11@, 12@)
jump @FBOOTHR_1415 

:FBOOTHR_1399
8@ = Object.Create(#CJ_BURG_2, 10@, 11@, 12@)

:FBOOTHR_1415
070A: AS_actor 0@ attach_to_object 8@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
if 
03A3:   actor 0@ male 
jf @FBOOTHR_1521 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @FBOOTHR_1563 

:FBOOTHR_1521
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:FBOOTHR_1563
5@ += 1 
jump @FBOOTHR_2116 

:FBOOTHR_1577
Actor.StorePos(0@, 13@, 14@, 15@)
15@ -= 1.04 
04C4: store_coords_to 16@ 17@ 18@ from_actor 0@ with_offset 0.1 0.5 0.0 
04C4: store_coords_to 19@ 20@ 21@ from_actor 0@ with_offset 1.0 -0.5 0.0 
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset -1.0 0.0 -0.65 
if or
   Actor.Animation(0@) == ""FF_SIT_LOOK""
   Actor.Animation(0@) == ""FF_SIT_EAT1""
   Actor.Animation(0@) == ""FF_SIT_EAT2""
jf @FBOOTHR_1812 
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -366 solid 0 for_actor 0@ 
Actor.PutAt(0@, 10@, 11@, 12@)
Actor.LockInCurrentPosition(0@) = True
TIMERB = 0 
5@ += 1 

:FBOOTHR_1812
jump @FBOOTHR_2116 

:FBOOTHR_1819
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @FBOOTHR_1871 
054E: clear_actor 0@ damage 
6@ = 0 
4@ = 5 
5@ = 0 
jump @FBOOTHR_2116 

:FBOOTHR_1871
if 
001D:   TIMERB > 6@ 
jf @FBOOTHR_2015 
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @FBOOTHR_1952 
5@ = 0 
4@ += 1 
jump @FBOOTHR_2015 

:FBOOTHR_1952
if 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @FBOOTHR_2015 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
5@ += 1 

:FBOOTHR_2015
jump @FBOOTHR_2116 

:FBOOTHR_2022
if 
0184:   actor 0@ health >= 0 
jf @FBOOTHR_2102 
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @FBOOTHR_2095 
5@ = 0 
4@ += 1 

:FBOOTHR_2095
jump @FBOOTHR_2109 

:FBOOTHR_2102
0568: set_actor 0@ untargetable 1 

:FBOOTHR_2109
jump @FBOOTHR_2116 

:FBOOTHR_2116
return 

:FBOOTHR_2118
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @FBOOTHR_2453 jumps 0 @FBOOTHR_2181 1 @FBOOTHR_2264 2 @FBOOTHR_2299 -1 @FBOOTHR_2453 -1 @FBOOTHR_2453 -1 @FBOOTHR_2453 -1 @FBOOTHR_2453 

:FBOOTHR_2181
if 
0737:   actor 0@ lifting_object -1 
jf @FBOOTHR_2206 
070B: set_actor 0@ onbone_attached_object_operation 1 

:FBOOTHR_2206
0812: AS_actor 0@ perform_animation ""FF_SIT_OUT_R_180"" IFP ""FOOD"" framedelta 99.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
5@ += 1 
jump @FBOOTHR_2453 

:FBOOTHR_2264
Actor.PutAt(0@, 13@, 14@, 15@)
Actor.LockInCurrentPosition(0@) = False
5@ += 1 
jump @FBOOTHR_2453 

:FBOOTHR_2299
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_SIT_OUT_R_180""
jf @FBOOTHR_2446 
0613: 9@ = actor 0@ animation ""FF_SIT_OUT_R_180"" time 
if 
  9@ == 1.0 
jf @FBOOTHR_2446 
088D: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model #CJ_PIZZA_CHAIR3 collision_detection 1 
088D: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model #CJ_PIZZA_CHAIR2 collision_detection 0 
5@ = 0 
4@ += 1 

:FBOOTHR_2446
jump @FBOOTHR_2453 

:FBOOTHR_2453
return 

:FBOOTHR_2455
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @FBOOTHR_2893 jumps 0 @FBOOTHR_2518 1 @FBOOTHR_2570 2 @FBOOTHR_2726 -1 @FBOOTHR_2893 -1 @FBOOTHR_2893 -1 @FBOOTHR_2893 -1 @FBOOTHR_2893 

:FBOOTHR_2518
0812: AS_actor 0@ perform_animation ""FF_DAM_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
5@ += 1 
jump @FBOOTHR_2893 

:FBOOTHR_2570
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_DAM_FWD""
jf @FBOOTHR_2656 
0613: 9@ = actor 0@ animation ""FF_DAM_FWD"" time 
if 
  9@ == 1.0 
jf @FBOOTHR_2656 
5@ += 1 

:FBOOTHR_2656
if 
8184:   not actor 0@ health >= 0 
jf @FBOOTHR_2719 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
gosub @FBOOTHR_2895 

:FBOOTHR_2719
jump @FBOOTHR_2893 

:FBOOTHR_2726
if 
8184:   not actor 0@ health >= 0 
jf @FBOOTHR_2796 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
gosub @FBOOTHR_2895 
jump @FBOOTHR_2879 

:FBOOTHR_2796
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @FBOOTHR_2865 
4@ = 3 
5@ = 0 
gosub @FBOOTHR_2971 
jump @FBOOTHR_2879 

:FBOOTHR_2865
4@ = 2 
5@ = 2 

:FBOOTHR_2879
" + FOOD_Player_Aggressive_Flag + @" = 1 
jump @FBOOTHR_2893 

:FBOOTHR_2893
return 

:FBOOTHR_2895
Object.RemoveReferences(8@)
04EF: release_animation ""FOOD"" 
if 
   not Actor.Dead(0@)
jf @FBOOTHR_2967 
0446: set_actor 0@ dismemberment_possible 1 
08A0: actor 0@ in_radius 100.0 near_model #NULL with_offset 0.0 0.0 0.0 end_script_named ""PCUSTOM"" 

:FBOOTHR_2967
end_thread 
return 

:FBOOTHR_2971
wait 0 
if and
8844:   not string " + Current_Shop_GXT_Name + @" empty 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @FBOOTHR_3312 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
jf @FBOOTHR_3305 
0871: init_jump_table 4@ total_jumps 5 default_jump 1 @FBOOTHR_3291 jumps 1 @FBOOTHR_3082 2 @FBOOTHR_3164 3 @FBOOTHR_3213 4 @FBOOTHR_3227 5 @FBOOTHR_3277 -1 @FBOOTHR_3305 -1 @FBOOTHR_3305 

:FBOOTHR_3082
if 
  5@ > 1 
jf @FBOOTHR_3114 
gosub @FBOOTHR_370 
jump @FBOOTHR_3157 

:FBOOTHR_3114
062E: get_actor 0@ task 1477 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @FBOOTHR_3157 
05C5: AS_actor 0@ cower -2 ms 
gosub @FBOOTHR_2895 

:FBOOTHR_3157
jump @FBOOTHR_3305 

:FBOOTHR_3164
if 
  5@ == 2 
jf @FBOOTHR_3199 
0209: 6@ = random_int_in_ranges 0 5 
6@ *= 500 

:FBOOTHR_3199
gosub @FBOOTHR_370 
jump @FBOOTHR_3305 

:FBOOTHR_3213
gosub @FBOOTHR_370 
jump @FBOOTHR_3305 

:FBOOTHR_3227
062E: get_actor 0@ task 1477 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @FBOOTHR_3270 
05C5: AS_actor 0@ cower -2 ms 
gosub @FBOOTHR_2895 

:FBOOTHR_3270
jump @FBOOTHR_3305 

:FBOOTHR_3277
gosub @FBOOTHR_370 
jump @FBOOTHR_3305 

:FBOOTHR_3291
gosub @FBOOTHR_2895 
jump @FBOOTHR_3305 

:FBOOTHR_3305
jump @FBOOTHR_3319 

:FBOOTHR_3312
gosub @FBOOTHR_2895 

:FBOOTHR_3319
jump @FBOOTHR_2971 
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