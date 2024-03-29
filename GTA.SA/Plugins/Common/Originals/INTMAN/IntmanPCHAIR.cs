﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PCHAIR : External {

            Actor _local0 = local( 0 ); // 0@

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @PCHAIR_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:PCHAIR_60
04ED: load_animation ""FOOD"" 

:PCHAIR_68
if 
84EE:   not animation ""FOOD"" loaded 
jf @PCHAIR_98 
wait 0 
jump @PCHAIR_68 

:PCHAIR_98
9@ = 0.0 
3@ = 0 
if 
  1@ == 0 
jf @PCHAIR_154 
5@ = 0 
4@ = 1 
jump @PCHAIR_168 

:PCHAIR_154
5@ = -2 
4@ = 2 

:PCHAIR_168
7@ = 0 
if 
   not Actor.Dead(0@)
jf @PCHAIR_215 
0446: set_actor 0@ dismemberment_possible 0 
6@ = 1800000 
jump @PCHAIR_222 

:PCHAIR_215
6@ = 0 

:PCHAIR_222
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PCHAIR_345 
if 
09C5:   unknown_actor 0@ 
jf @PCHAIR_331 
if or
  " + FOOD_Player_Aggressive_Flag + @" == 1 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @PCHAIR_317 
" + FOOD_Player_Aggressive_Flag + @" = 1 
jump @PCHAIR_3035 
jump @PCHAIR_324 

:PCHAIR_317
gosub @PCHAIR_359 

:PCHAIR_324
jump @PCHAIR_338 

:PCHAIR_331
gosub @PCHAIR_2959 

:PCHAIR_338
jump @PCHAIR_352 

:PCHAIR_345
gosub @PCHAIR_2959 

:PCHAIR_352
jump @PCHAIR_222 

:PCHAIR_359
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @PCHAIR_492 jumps 1 @PCHAIR_422 2 @PCHAIR_436 3 @PCHAIR_450 4 @PCHAIR_464 5 @PCHAIR_478 -1 @PCHAIR_492 -1 @PCHAIR_492 

:PCHAIR_422
gosub @PCHAIR_494 
jump @PCHAIR_492 

:PCHAIR_436
gosub @PCHAIR_715 
jump @PCHAIR_492 

:PCHAIR_450
gosub @PCHAIR_2157 
jump @PCHAIR_492 

:PCHAIR_464
gosub @PCHAIR_2959 
jump @PCHAIR_492 

:PCHAIR_478
gosub @PCHAIR_2526 
jump @PCHAIR_492 

:PCHAIR_492
return 

:PCHAIR_494
0871: init_jump_table 5@ total_jumps 2 default_jump 0 @PCHAIR_713 jumps 0 @PCHAIR_557 1 @PCHAIR_615 -1 @PCHAIR_713 -1 @PCHAIR_713 -1 @PCHAIR_713 -1 @PCHAIR_713 -1 @PCHAIR_713 

:PCHAIR_557
0812: AS_actor 0@ perform_animation ""FF_SIT_IN"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
3@ = 1 
5@ += 1 
jump @PCHAIR_713 

:PCHAIR_615
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_SIT_IN""
jf @PCHAIR_671 
0613: 9@ = actor 0@ animation ""FF_SIT_IN"" time 

:PCHAIR_671
if 
  9@ == 1.0 
jf @PCHAIR_706 
5@ = 0 
4@ += 1 

:PCHAIR_706
jump @PCHAIR_713 

:PCHAIR_713
return 

:PCHAIR_715
0871: init_jump_table 5@ total_jumps 5 default_jump 0 @PCHAIR_2155 jumps -2 @PCHAIR_778 0 @PCHAIR_1103 1 @PCHAIR_1560 2 @PCHAIR_1858 3 @PCHAIR_2061 -1 @PCHAIR_2155 -1 @PCHAIR_2155 

:PCHAIR_778
if 
06FF:   any_ped_near_actor 0@ in_range 2.2 
jf @PCHAIR_848 
0812: AS_actor 0@ perform_animation ""FF_SIT_LOOK"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @PCHAIR_1089 

:PCHAIR_848
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 0.0 0.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @PCHAIR_925 
8@ = Object.Create(#CJ_PIZZA_2, 10@, 11@, 12@)
jump @PCHAIR_941 

:PCHAIR_925
8@ = Object.Create(#CJ_BURG_2, 10@, 11@, 12@)

:PCHAIR_941
070A: AS_actor 0@ attach_to_object 8@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
if 
03A3:   actor 0@ male 
jf @PCHAIR_1047 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @PCHAIR_1089 

:PCHAIR_1047
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:PCHAIR_1089
5@ = 1 
jump @PCHAIR_2155 

:PCHAIR_1103
if 
0737:   actor 0@ lifting_object -1 
jf @PCHAIR_1235 
if 
03A3:   actor 0@ male 
jf @PCHAIR_1186 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @PCHAIR_1228 

:PCHAIR_1186
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:PCHAIR_1228
jump @PCHAIR_1546 

:PCHAIR_1235
if 
06FF:   any_ped_near_actor 0@ in_range 2.2 
jf @PCHAIR_1305 
0812: AS_actor 0@ perform_animation ""FF_SIT_LOOK"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @PCHAIR_1546 

:PCHAIR_1305
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 0.0 0.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @PCHAIR_1382 
8@ = Object.Create(#CJ_PIZZA_2, 10@, 11@, 12@)
jump @PCHAIR_1398 

:PCHAIR_1382
8@ = Object.Create(#CJ_BURG_2, 10@, 11@, 12@)

:PCHAIR_1398
070A: AS_actor 0@ attach_to_object 8@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
if 
03A3:   actor 0@ male 
jf @PCHAIR_1504 
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT1"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 
jump @PCHAIR_1546 

:PCHAIR_1504
0812: AS_actor 0@ perform_animation ""FF_SIT_EAT2"" IFP ""FOOD"" framedelta 1000.0 loopA 1 lockX 0 lockY 0 lockF 0 time 50000000 

:PCHAIR_1546
5@ += 1 
jump @PCHAIR_2155 

:PCHAIR_1560
Actor.StorePos(0@, 13@, 14@, 15@)
15@ -= 1.04 
04C4: store_coords_to 16@ 17@ 18@ from_actor 0@ with_offset 0.5 -0.5 0.0 
04C4: store_coords_to 19@ 20@ 21@ from_actor 0@ with_offset -0.5 -1.0 0.0 
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset 0.0 1.0 -0.65 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDBURG' 
jf @PCHAIR_1727 
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -364 solid 0 for_actor 0@ 
jump @PCHAIR_1751 

:PCHAIR_1727
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -365 solid 0 for_actor 0@ 

:PCHAIR_1751
if or
   Actor.Animation(0@) == ""FF_SIT_LOOK""
   Actor.Animation(0@) == ""FF_SIT_EAT1""
   Actor.Animation(0@) == ""FF_SIT_EAT2""
jf @PCHAIR_1851 
Actor.PutAt(0@, 10@, 11@, 12@)
Actor.LockInCurrentPosition(0@) = True
TIMERB = 0 
5@ += 1 

:PCHAIR_1851
jump @PCHAIR_2155 

:PCHAIR_1858
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @PCHAIR_1910 
054E: clear_actor 0@ damage 
6@ = 0 
4@ = 5 
5@ = 0 
jump @PCHAIR_2155 

:PCHAIR_1910
if 
001D:   TIMERB > 6@ 
jf @PCHAIR_2054 
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @PCHAIR_1991 
5@ = 0 
4@ += 1 
jump @PCHAIR_2054 

:PCHAIR_1991
if 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @PCHAIR_2054 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
5@ += 1 

:PCHAIR_2054
jump @PCHAIR_2155 

:PCHAIR_2061
if 
0184:   actor 0@ health >= 0 
jf @PCHAIR_2141 
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @PCHAIR_2134 
5@ = 0 
4@ += 1 

:PCHAIR_2134
jump @PCHAIR_2148 

:PCHAIR_2141
0568: set_actor 0@ untargetable 1 

:PCHAIR_2148
jump @PCHAIR_2155 

:PCHAIR_2155
return 

:PCHAIR_2157
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @PCHAIR_2524 jumps 0 @PCHAIR_2220 1 @PCHAIR_2301 2 @PCHAIR_2336 -1 @PCHAIR_2524 -1 @PCHAIR_2524 -1 @PCHAIR_2524 -1 @PCHAIR_2524 

:PCHAIR_2220
if 
0737:   actor 0@ lifting_object -1 
jf @PCHAIR_2245 
070B: set_actor 0@ onbone_attached_object_operation 1 

:PCHAIR_2245
0812: AS_actor 0@ perform_animation ""FF_SIT_OUT_180"" IFP ""FOOD"" framedelta 99.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
5@ += 1 
jump @PCHAIR_2524 

:PCHAIR_2301
Actor.PutAt(0@, 13@, 14@, 15@)
Actor.LockInCurrentPosition(0@) = False
5@ += 1 
jump @PCHAIR_2524 

:PCHAIR_2336
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_SIT_OUT_180""
jf @PCHAIR_2517 
0613: 9@ = actor 0@ animation ""FF_SIT_OUT_180"" time 
if 
  9@ == 1.0 
jf @PCHAIR_2517 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDBURG' 
jf @PCHAIR_2479 
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -364 solid 1 for_actor 0@ 
jump @PCHAIR_2503 

:PCHAIR_2479
0985: set_objects_in_sphere 13@ 14@ 15@ radius 1.5 with_model -365 solid 1 for_actor 0@ 

:PCHAIR_2503
5@ = 0 
4@ += 1 

:PCHAIR_2517
jump @PCHAIR_2524 

:PCHAIR_2524
return 

:PCHAIR_2526
0871: init_jump_table 5@ total_jumps 3 default_jump 0 @PCHAIR_2957 jumps 0 @PCHAIR_2589 1 @PCHAIR_2641 2 @PCHAIR_2797 -1 @PCHAIR_2957 -1 @PCHAIR_2957 -1 @PCHAIR_2957 -1 @PCHAIR_2957 

:PCHAIR_2589
0812: AS_actor 0@ perform_animation ""FF_DAM_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
5@ += 1 
jump @PCHAIR_2957 

:PCHAIR_2641
9@ = 0.0 
if 
   Actor.Animation(0@) == ""FF_DAM_FWD""
jf @PCHAIR_2727 
0613: 9@ = actor 0@ animation ""FF_DAM_FWD"" time 
if 
  9@ == 1.0 
jf @PCHAIR_2727 
5@ += 1 

:PCHAIR_2727
if 
8184:   not actor 0@ health >= 0 
jf @PCHAIR_2790 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
gosub @PCHAIR_2959 

:PCHAIR_2790
jump @PCHAIR_2957 

:PCHAIR_2797
if 
8184:   not actor 0@ health >= 0 
jf @PCHAIR_2867 
0812: AS_actor 0@ perform_animation ""FF_DIE_FWD"" IFP ""FOOD"" framedelta 16.0 loopA 0 lockX 0 lockY 0 lockF 1 time 0 
gosub @PCHAIR_2959 
jump @PCHAIR_2950 

:PCHAIR_2867
if 
8339:   not anything_in_cube_cornerA 16@ 17@ 18@ cornerB 19@ 20@ 21@ solid 0 car 0 actor 1 object 0 particle 0 
jf @PCHAIR_2936 
4@ = 3 
5@ = 0 
gosub @PCHAIR_3035 
jump @PCHAIR_2950 

:PCHAIR_2936
4@ = 2 
5@ = 2 

:PCHAIR_2950
jump @PCHAIR_2957 

:PCHAIR_2957
return 

:PCHAIR_2959
Object.RemoveReferences(8@)
04EF: release_animation ""FOOD"" 
if 
   not Actor.Dead(0@)
jf @PCHAIR_3031 
0446: set_actor 0@ dismemberment_possible 1 " );
                _local0.task.use_closest_map_attractor<PCUSTOM>( ( double ) 100.0, NULL, ( double ) 0.0, ( double ) 0.0, ( double ) 0.0 );
AppendLine( @"
:PCHAIR_3031
end_thread 
return 

:PCHAIR_3035
wait 0 
if and
8844:   not string " + Current_Shop_GXT_Name + @" empty 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PCHAIR_3376 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
jf @PCHAIR_3369 
0871: init_jump_table 4@ total_jumps 5 default_jump 1 @PCHAIR_3355 jumps 1 @PCHAIR_3146 2 @PCHAIR_3228 3 @PCHAIR_3277 4 @PCHAIR_3291 5 @PCHAIR_3341 -1 @PCHAIR_3369 -1 @PCHAIR_3369 

:PCHAIR_3146
if 
  5@ > 1 
jf @PCHAIR_3178 
gosub @PCHAIR_359 
jump @PCHAIR_3221 

:PCHAIR_3178
062E: get_actor 0@ task 1477 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @PCHAIR_3221 
05C5: AS_actor 0@ cower -2 ms 
gosub @PCHAIR_2959 

:PCHAIR_3221
jump @PCHAIR_3369 

:PCHAIR_3228
if 
  5@ == 2 
jf @PCHAIR_3263 
0209: 6@ = random_int_in_ranges 0 5 
6@ *= 500 

:PCHAIR_3263
gosub @PCHAIR_359 
jump @PCHAIR_3369 

:PCHAIR_3277
gosub @PCHAIR_359 
jump @PCHAIR_3369 

:PCHAIR_3291
062E: get_actor 0@ task 1477 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @PCHAIR_3334 
05C5: AS_actor 0@ cower -2 ms 
gosub @PCHAIR_2959 

:PCHAIR_3334
jump @PCHAIR_3369 

:PCHAIR_3341
gosub @PCHAIR_359 
jump @PCHAIR_3369 

:PCHAIR_3355
gosub @PCHAIR_2959 
jump @PCHAIR_3369 

:PCHAIR_3369
jump @PCHAIR_3383 

:PCHAIR_3376
gosub @PCHAIR_2959 

:PCHAIR_3383
jump @PCHAIR_3035 
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