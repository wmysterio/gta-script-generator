using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalVehicleMissions {

        private sealed class HOUSE : External {

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
5@ = 0 
4@ = 0 
7@ = 0 
8@ = 0 
14@ = 0 
15@ = 0 
if 
  1@ == 1 
else_jump @HOUSE_132 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)
0978: copy_decision_maker 65542 to " + _5350 + @" 
0978: copy_decision_maker 65542 to " + _5351 + @" 
0978: copy_decision_maker 65542 to " + _5352 + @" 

:HOUSE_132
0209: 2@ = random_int_in_ranges 0 6 
if 
  2@ == 2 
else_jump @HOUSE_168 
0209: 3@ = random_int_in_ranges 0 6 

:HOUSE_168
wait 0 
if and
056D:   actor 0@ defined 
  5@ == 0 
else_jump @HOUSE_5624 
if and
   Player.Defined(" + PlayerChar + @")
   not Actor.Dead(0@)
else_jump @HOUSE_5610 
if 
  15@ == 0 
else_jump @HOUSE_550 
089F: get_actor 0@ pedtype_to 13@ 
14@ = 1 
if 
84A4:   not  13@ == 7 
else_jump @HOUSE_527 
if 
84A4:   not  13@ == 9 
else_jump @HOUSE_504 
if 
84A4:   not  13@ == 10 
else_jump @HOUSE_481 
if 
84A4:   not  13@ == 11 
else_jump @HOUSE_458 
if 
84A4:   not  13@ == 12 
else_jump @HOUSE_435 
if 
84A4:   not  13@ == 13 
else_jump @HOUSE_412 
if 
84A4:   not  13@ == 14 
else_jump @HOUSE_389 
14@ = 0 
jump @HOUSE_405 

:HOUSE_389
09D5: play_sound_of_actor 0@ soundslot 7 unknown_flags 1 0 0 as 13@ 

:HOUSE_405
jump @HOUSE_428 

:HOUSE_412
09D5: play_sound_of_actor 0@ soundslot 5 unknown_flags 1 0 0 as 13@ 

:HOUSE_428
jump @HOUSE_451 

:HOUSE_435
09D5: play_sound_of_actor 0@ soundslot 6 unknown_flags 1 0 0 as 13@ 

:HOUSE_451
jump @HOUSE_474 

:HOUSE_458
09D5: play_sound_of_actor 0@ soundslot 8 unknown_flags 1 0 0 as 13@ 

:HOUSE_474
jump @HOUSE_497 

:HOUSE_481
09D5: play_sound_of_actor 0@ soundslot 2 unknown_flags 1 0 0 as 13@ 

:HOUSE_497
jump @HOUSE_520 

:HOUSE_504
09D5: play_sound_of_actor 0@ soundslot 3 unknown_flags 1 0 0 as 13@ 

:HOUSE_520
jump @HOUSE_543 

:HOUSE_527
09D5: play_sound_of_actor 0@ soundslot 1 unknown_flags 1 0 0 as 13@ 

:HOUSE_543
15@ = 1 

:HOUSE_550
if 
8737:   not actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_2056 
if 
   not 8@ == 1 
else_jump @HOUSE_2049 
if 
  14@ == 0 
else_jump @HOUSE_1686 
if 
03A3:   actor 0@ male 
else_jump @HOUSE_1221 
065C: release_decision_maker " + _5350 + @" 
0978: copy_decision_maker 65542 to " + _5350 + @" 
if 
   not " + _5350 + @" == -1 
else_jump @HOUSE_661 
060B: set_actor 0@ decision_maker_to " + _5350 + @" 

:HOUSE_661
077A: set_actor 0@ acquaintance 3 to_actors_pedtype 0 
0709: set_decision_maker " + _5350 + @" on_event 37 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 37 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 31 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 31 taskID 413 respect 0.0 hate 100.0 like 40.0 dislike 40.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 36 taskID 1000 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 36 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 36 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 427 respect 0.0 hate 100.0 like 70.0 dislike 70.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 11 taskID 600 respect 0.0 hate 100.0 like 100.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 415 respect 0.0 hate 100.0 like 50.0 dislike 50.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 1000 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 920 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 427 respect 0.0 hate 100.0 like 30.0 dislike 30.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 62 taskID 935 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 
jump @HOUSE_1679 

:HOUSE_1221
065C: release_decision_maker " + _5351 + @" 
0978: copy_decision_maker 65542 to " + _5351 + @" 
if 
   not " + _5351 + @" == -1 
else_jump @HOUSE_1262 
060B: set_actor 0@ decision_maker_to " + _5351 + @" 

:HOUSE_1262
077A: set_actor 0@ acquaintance 3 to_actors_pedtype 0 
0709: set_decision_maker " + _5351 + @" on_event 37 taskID 427 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 37 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 31 taskID 601 respect 0.0 hate 100.0 like 50.0 dislike 50.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 31 taskID 413 respect 0.0 hate 100.0 like 30.0 dislike 30.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 31 taskID 427 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 36 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 36 taskID 427 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 9 taskID 1000 respect 0.0 hate 100.0 like 60.0 dislike 60.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 9 taskID 427 respect 0.0 hate 100.0 like 40.0 dislike 40.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 62 taskID 935 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 11 taskID 600 respect 0.0 hate 100.0 like 40.0 dislike 40.0 in_car 1 on_foot 1 

:HOUSE_1679
jump @HOUSE_2042 

:HOUSE_1686
065C: release_decision_maker " + _5352 + @" 
0978: copy_decision_maker 65542 to " + _5352 + @" 
if 
   not " + _5352 + @" == -1 
else_jump @HOUSE_1727 
060B: set_actor 0@ decision_maker_to " + _5352 + @" 

:HOUSE_1727
077A: set_actor 0@ acquaintance 3 to_actors_pedtype 0 
0709: set_decision_maker " + _5352 + @" on_event 37 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 31 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 36 taskID 1000 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 36 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 9 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 11 taskID 600 respect 0.0 hate 100.0 like 100.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 15 taskID 1000 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 62 taskID 935 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 

:HOUSE_2042
8@ = 1 

:HOUSE_2049
jump @HOUSE_3571 

:HOUSE_2056
if 
   not 8@ == 2 
else_jump @HOUSE_3571 
if 
  14@ == 0 
else_jump @HOUSE_3208 
if 
03A3:   actor 0@ male 
else_jump @HOUSE_2743 
065C: release_decision_maker " + _5350 + @" 
0978: copy_decision_maker 65542 to " + _5350 + @" 
if 
   not " + _5350 + @" == -1 
else_jump @HOUSE_2149 
060B: set_actor 0@ decision_maker_to " + _5350 + @" 

:HOUSE_2149
0709: set_decision_maker " + _5350 + @" on_event 37 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 37 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 31 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 31 taskID 413 respect 0.0 hate 100.0 like 40.0 dislike 40.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 36 taskID 1000 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 36 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 36 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 1000 respect 0.0 hate 100.0 like 30.0 dislike 30.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 427 respect 0.0 hate 100.0 like 60.0 dislike 60.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 11 taskID 600 respect 0.0 hate 100.0 like 50.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 415 respect 0.0 hate 100.0 like 50.0 dislike 50.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 920 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 15 taskID 427 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5350 + @" on_event 62 taskID 935 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 
077A: set_actor 0@ acquaintance 4 to_actors_pedtype 0 
0709: set_decision_maker " + _5350 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 100.0 dislike 0.0 in_car 1 on_foot 1 
jump @HOUSE_3201 

:HOUSE_2743
065C: release_decision_maker " + _5351 + @" 
0978: copy_decision_maker 65542 to " + _5351 + @" 
if 
   not " + _5351 + @" == -1 
else_jump @HOUSE_2784 
060B: set_actor 0@ decision_maker_to " + _5351 + @" 

:HOUSE_2784
077A: set_actor 0@ acquaintance 4 to_actors_pedtype 0 
0709: set_decision_maker " + _5351 + @" on_event 37 taskID 427 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 37 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 31 taskID 601 respect 0.0 hate 100.0 like 50.0 dislike 50.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 31 taskID 413 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 31 taskID 427 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 36 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 36 taskID 427 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 30.0 dislike 30.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 9 taskID 1000 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 9 taskID 427 respect 0.0 hate 100.0 like 30.0 dislike 30.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 11 taskID 600 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5351 + @" on_event 62 taskID 935 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 

:HOUSE_3201
jump @HOUSE_3564 

:HOUSE_3208
065C: release_decision_maker " + _5352 + @" 
0978: copy_decision_maker 65542 to " + _5352 + @" 
if 
   not " + _5352 + @" == -1 
else_jump @HOUSE_3249 
060B: set_actor 0@ decision_maker_to " + _5352 + @" 

:HOUSE_3249
0709: set_decision_maker " + _5352 + @" on_event 37 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 31 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 36 taskID 1000 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 36 taskID 1029 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 9 taskID 251 respect 0.0 hate 100.0 like 10.0 dislike 10.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 9 taskID 1000 respect 0.0 hate 100.0 like 30.0 dislike 30.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 11 taskID 600 respect 0.0 hate 100.0 like 50.0 dislike 0.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 15 taskID 1000 respect 0.0 hate 100.0 like 20.0 dislike 20.0 in_car 1 on_foot 1 
0709: set_decision_maker " + _5352 + @" on_event 62 taskID 935 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 
077A: set_actor 0@ acquaintance 4 to_actors_pedtype 0 

:HOUSE_3564
8@ = 2 

:HOUSE_3571
if or
074F:   actor 0@ ped_event == 36 
074F:   actor 0@ ped_event == 15 
074F:   actor 0@ ped_event == 9 
074F:   actor 0@ ped_event == 37 
  " + BURGLARY_Noise_i + @" == 100 
else_jump @HOUSE_4393 
if 
  " + BURGLARY_Detected_Flag + @" == 0 
else_jump @HOUSE_4393 
if and
  2@ == 4 
  14@ == 0 
else_jump @HOUSE_3753 
if 
   not Model.Available(#CELLPHONE)
else_jump @HOUSE_3688 
Model.Load(#CELLPHONE)
jump @HOUSE_3746 

:HOUSE_3688
if 
   not Actor.Dead(0@)
else_jump @HOUSE_3711 
0729: AS_actor 0@ hold_cellphone 1 

:HOUSE_3711
09D5: play_sound_of_actor 0@ soundslot 120 unknown_flags 1 0 0 as 13@ 
01BD: 9@ = current_time_in_ms 
7@ = 1 
" + BURGLARY_Detected_Flag + @" = 1 

:HOUSE_3746
jump @HOUSE_4393 

:HOUSE_3753
if 
  2@ == 2 
else_jump @HOUSE_4379 
if 
02D8:   actor 0@ current_weapon == 0 
else_jump @HOUSE_4305 
if 
  3@ == 1 
else_jump @HOUSE_3925 
if 
   not Model.Available(#BAT)
else_jump @HOUSE_3835 
Model.Load(#BAT)
jump @HOUSE_3918 

:HOUSE_3835
Actor.GiveWeaponAndAmmo(0@, BaseballBat, 0)
01B9: set_actor 0@ armed_weapon_to 5 
09D5: play_sound_of_actor 0@ soundslot 20 unknown_flags 1 0 0 as 13@ 
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_3904 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:HOUSE_3904
7@ = 1 
" + BURGLARY_Detected_Flag + @" = 1 

:HOUSE_3918
jump @HOUSE_4298 

:HOUSE_3925
if 
  3@ == 3 
else_jump @HOUSE_4078 
if 
   not Model.Available(#COLT45)
else_jump @HOUSE_3971 
Model.Load(#COLT45)
jump @HOUSE_4071 

:HOUSE_3971
Actor.GiveWeaponAndAmmo(0@, Pistol, 40)
01B9: set_actor 0@ armed_weapon_to 22 
09D5: play_sound_of_actor 0@ soundslot 20 unknown_flags 1 0 0 as 13@ 
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4040 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:HOUSE_4040
7@ = 1 
" + BURGLARY_Detected_Flag + @" = 1 
09D5: play_sound_of_actor 0@ soundslot 176 unknown_flags 1 0 0 as 13@ 

:HOUSE_4071
jump @HOUSE_4298 

:HOUSE_4078
if 
  3@ == 5 
else_jump @HOUSE_4231 
if 
   not Model.Available(#SAWNOFF)
else_jump @HOUSE_4124 
Model.Load(#SAWNOFF)
jump @HOUSE_4224 

:HOUSE_4124
Actor.GiveWeaponAndAmmo(0@, Sawnoff, 40)
01B9: set_actor 0@ armed_weapon_to 26 
09D5: play_sound_of_actor 0@ soundslot 20 unknown_flags 1 0 0 as 13@ 
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4193 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:HOUSE_4193
7@ = 1 
" + BURGLARY_Detected_Flag + @" = 1 
09D5: play_sound_of_actor 0@ soundslot 182 unknown_flags 1 0 0 as 13@ 

:HOUSE_4224
jump @HOUSE_4298 

:HOUSE_4231
09D5: play_sound_of_actor 0@ soundslot 89 unknown_flags 1 0 0 as 13@ 
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4284 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:HOUSE_4284
7@ = 1 
" + BURGLARY_Detected_Flag + @" = 1 

:HOUSE_4298
jump @HOUSE_4372 

:HOUSE_4305
09D5: play_sound_of_actor 0@ soundslot 89 unknown_flags 1 0 0 as 13@ 
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4358 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:HOUSE_4358
7@ = 1 
" + BURGLARY_Detected_Flag + @" = 1 

:HOUSE_4372
jump @HOUSE_4393 

:HOUSE_4379
" + BURGLARY_Detected_Flag + @" = 1 
7@ = 1 

:HOUSE_4393
if or
  7@ == 1 
  7@ == 2 
else_jump @HOUSE_5603 
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_5196 
if and
874F:   not actor 0@ ped_event == 36 
874F:   not actor 0@ ped_event == 15 
874F:   not actor 0@ ped_event == 9 
874F:   not actor 0@ ped_event == 37 
else_jump @HOUSE_5196 
0871: init_jump_table 2@ total_jumps 5 default_jump 1 @HOUSE_5092 jumps 0 @HOUSE_4549 1 @HOUSE_4608 2 @HOUSE_4709 3 @HOUSE_4769 4 @HOUSE_4828 -1 @HOUSE_5196 -1 @HOUSE_5196 

:HOUSE_4549
062E: get_actor 0@ task 1477 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4601 
05C5: AS_actor 0@ cower -2 ms 
09D5: play_sound_of_actor 0@ soundslot 85 unknown_flags 1 0 0 as 13@ 

:HOUSE_4601
jump @HOUSE_5196 

:HOUSE_4608
062E: get_actor 0@ task 1476 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4702 
05C4: AS_actor 0@ hands_up -2 ms 
if 
0737:   actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_4686 
09D5: play_sound_of_actor 0@ soundslot 145 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_4702 

:HOUSE_4686
09D5: play_sound_of_actor 0@ soundslot 115 unknown_flags 1 0 0 as 13@ 

:HOUSE_4702
jump @HOUSE_5196 

:HOUSE_4709
062E: get_actor 0@ task 1506 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4762 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 
09D5: play_sound_of_actor 0@ soundslot 20 unknown_flags 1 0 0 as 13@ 

:HOUSE_4762
jump @HOUSE_5196 

:HOUSE_4769
062E: get_actor 0@ task 1466 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_4821 
05BA: AS_actor 0@ move_mouth -2 ms 
09D5: play_sound_of_actor 0@ soundslot 114 unknown_flags 1 0 0 as 13@ 

:HOUSE_4821
jump @HOUSE_5196 

:HOUSE_4828
if 
  " + ONMISSION_Burglary + @" == 1 
else_jump @HOUSE_5085 
if 
  7@ == 1 
else_jump @HOUSE_4991 
01BD: 10@ = current_time_in_ms 
0085: 11@ = 10@ 
0062: 11@ -= 9@ 
if 
  11@ > 8000 
else_jump @HOUSE_4984 
if 
   not Actor.Dead(0@)
else_jump @HOUSE_4984 
062E: get_actor 0@ task 1833 status_store_to 12@ 
if 
84A4:   not  12@ == 7 
else_jump @HOUSE_4956 
0729: AS_actor 0@ hold_cellphone 0 

:HOUSE_4956
Model.Destroy(#CELLPHONE)
7@ = 2 
09D5: play_sound_of_actor 0@ soundslot 44 unknown_flags 1 0 0 as 13@ 

:HOUSE_4984
jump @HOUSE_5085 

:HOUSE_4991
062E: get_actor 0@ task 1476 status_store_to 12@ 
if 
04A4:   12@ == 7 
else_jump @HOUSE_5085 
05C4: AS_actor 0@ hands_up -2 ms 
if 
0737:   actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_5069 
09D5: play_sound_of_actor 0@ soundslot 145 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5085 

:HOUSE_5069
09D5: play_sound_of_actor 0@ soundslot 115 unknown_flags 1 0 0 as 13@ 

:HOUSE_5085
jump @HOUSE_5196 

:HOUSE_5092
if 
0737:   actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_5134 
09D5: play_sound_of_actor 0@ soundslot 145 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5189 

:HOUSE_5134
if 
03A3:   actor 0@ male 
else_jump @HOUSE_5173 
09D5: play_sound_of_actor 0@ soundslot 110 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5189 

:HOUSE_5173
09D5: play_sound_of_actor 0@ soundslot 110 unknown_flags 1 0 0 as 13@ 

:HOUSE_5189
jump @HOUSE_5196 

:HOUSE_5196
0871: init_jump_table 2@ total_jumps 5 default_jump 1 @HOUSE_5499 jumps 0 @HOUSE_5259 1 @HOUSE_5282 2 @HOUSE_5347 3 @HOUSE_5370 4 @HOUSE_5393 -1 @HOUSE_5603 -1 @HOUSE_5603 

:HOUSE_5259
09D5: play_sound_of_actor 0@ soundslot 85 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5603 

:HOUSE_5282
if 
0737:   actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_5324 
09D5: play_sound_of_actor 0@ soundslot 145 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5340 

:HOUSE_5324
09D5: play_sound_of_actor 0@ soundslot 115 unknown_flags 1 0 0 as 13@ 

:HOUSE_5340
jump @HOUSE_5603 

:HOUSE_5347
09D5: play_sound_of_actor 0@ soundslot 20 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5603 

:HOUSE_5370
09D5: play_sound_of_actor 0@ soundslot 114 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5603 

:HOUSE_5393
if 
  7@ == 1 
else_jump @HOUSE_5434 
09D5: play_sound_of_actor 0@ soundslot 44 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5492 

:HOUSE_5434
if 
0737:   actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_5476 
09D5: play_sound_of_actor 0@ soundslot 145 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5492 

:HOUSE_5476
09D5: play_sound_of_actor 0@ soundslot 115 unknown_flags 1 0 0 as 13@ 

:HOUSE_5492
jump @HOUSE_5603 

:HOUSE_5499
if 
0737:   actor " + PlayerActor + @" lifting_object -1 
else_jump @HOUSE_5541 
09D5: play_sound_of_actor 0@ soundslot 145 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5596 

:HOUSE_5541
if 
03A3:   actor 0@ male 
else_jump @HOUSE_5580 
09D5: play_sound_of_actor 0@ soundslot 110 unknown_flags 1 0 0 as 13@ 
jump @HOUSE_5596 

:HOUSE_5580
09D5: play_sound_of_actor 0@ soundslot 110 unknown_flags 1 0 0 as 13@ 

:HOUSE_5596
jump @HOUSE_5603 

:HOUSE_5603
jump @HOUSE_5617 

:HOUSE_5610
5@ = 1 

:HOUSE_5617
jump @HOUSE_5666 

:HOUSE_5624
065C: release_decision_maker " + _5350 + @" 
065C: release_decision_maker " + _5351 + @" 
065C: release_decision_maker " + _5352 + @" 
Actor.RemoveReferences(0@)
Model.Destroy(#CELLPHONE)
Model.Destroy(#BAT)
Model.Destroy(#COLT45)
Model.Destroy(#SAWNOFF)
end_thread 

:HOUSE_5666
jump @HOUSE_168 
end_thread" );
            }

        }

    }

}