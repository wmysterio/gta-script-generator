﻿using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalDealer : Original {

        internal OriginalDealer() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.init_external_script_trigger_with_actor_model<DEALER>( 28, 100 );
            Script.init_external_script_trigger_with_actor_model<DEALER>( 29, 100 );
            Script.init_external_script_trigger_with_actor_model<DEALER>( 30, 100 );
            Script.init_external_script_trigger_with_actor_model<DEALER>( 254, 100 );
            Script.attach_anims_to_model<DEALER>( 28 );
            Script.attach_anims_to_model<DEALER>( 29 );
            Script.attach_anims_to_model<DEALER>( 30 );
            Script.attach_anims_to_model<DEALER>( 254 );
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class DEALER : External {

            public override void START( LabelJump label ) {
                AppendLine( @"13@ = 0 
if 
  13@ == 1 
jf @DEALER_60 
0@ = Actor.Create(Dealer, #NULL, 0.0, 0.0, 0.0)

:DEALER_60
1@ = 0 
2@ = 0 
11@ = -1 
14@ = 0 
if and
   not Actor.Dead(0@)
   not Actor.Dead(" + PlayerActor + @")
jf @DEALER_338 
Actor.StorePos(0@, 3@, 4@, 5@)
08F1: get_zone_at 3@ 4@ 5@ nameB_to 19@s // 8-byte string 
05AA: 17@s = 19@s // @s = 'short' 
0978: copy_decision_maker 65539 to 8@ 
060B: set_actor 0@ decision_maker_to 8@ 
03FE: set_actor 0@ money 2000 
0717: assign_actor 0@ to_dialogue_mode 
09A4: set_dialogue_classB_question_GXT 'DEAL1' answer_Y_GXT 'DEAL2' answer_N_GXT 'DEAL3' question_WAV 192 answer_Y_WAV 77 answer_N_WAV 78  // ЏЁ xo¤eҐ© kyЈњ¦© ®eЇ®o™o ¦paўkњ? // ­e Јpњ®њЇaќ Їe®¬ ўcep©eџ, Јape®©. // ѓa ЈoҐeћ ¦Ё ®axyќ, Јape®©!
0652: 13@ = integer_stat 64 
if 
  13@ >= 500 
jf @DEALER_271 
09AA: set_dialogue_classB_end_GXT 'DEAL2' WAV 79  // ­e Јpњ®њЇaќ Їe®¬ ўcep©eџ, Јape®©.
09AA: set_dialogue_classB_end_GXT 'DEAL3' WAV 75  // ѓa ЈoҐeћ ¦Ё ®axyќ, Јape®©!
jump @DEALER_297 

:DEALER_271
09AA: set_dialogue_classB_end_GXT 'DEAL2' WAV 80  // ­e Јpњ®њЇaќ Їe®¬ ўcep©eџ, Јape®©.
09AA: set_dialogue_classB_end_GXT 'DEAL3' WAV 76  // ѓa ЈoҐeћ ¦Ё ®axyќ, Јape®©!

:DEALER_297
09FB: 13@ = current_language 
if 
04A4:   13@ == 0 // == constant 
jf @DEALER_329 
0A47: set_dialogue_mode_enabled_without_GXT 
jump @DEALER_331 

:DEALER_329
0719: enable_dialogue_mode 

:DEALER_331
jump @DEALER_345 

:DEALER_338
gosub @DEALER_3913 

:DEALER_345
wait 0 
if 
   not Actor.Dead(0@)
jf @DEALER_471 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @DEALER_457 
if or
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
0457:   player " + PlayerChar + @" aiming_at_actor 0@ 
jf @DEALER_429 
gosub @DEALER_641 
gosub @DEALER_3368 
jump @DEALER_450 

:DEALER_429
gosub @DEALER_846 
gosub @DEALER_485 
gosub @DEALER_931 

:DEALER_450
jump @DEALER_464 

:DEALER_457
gosub @DEALER_3913 

:DEALER_464
jump @DEALER_478 

:DEALER_471
gosub @DEALER_3913 

:DEALER_478
jump @DEALER_345 

:DEALER_485
if 
  11@ == -1 
jf @DEALER_604 
if 
  TIMERA > 15000 
jf @DEALER_597 
Actor.StorePos(0@, 3@, 4@, 5@)
089E: get_actor_that_buys_drugs_in_sphere 3@ 4@ 5@ radius 5.0 handle_as 11@ 
if 
   not 11@ == -1 
jf @DEALER_597 
if 
   Actor.Driving(11@)
jf @DEALER_597 
12@ = Actor.CurrentCar(11@)

:DEALER_597
jump @DEALER_639 

:DEALER_604
if or
   Actor.Dead(11@)
856D:   not actor 11@ defined 
074F:   actor 0@ ped_event == 36 
jf @DEALER_639 
11@ = -1 

:DEALER_639
return 

:DEALER_641
Actor.RemoveReferences(11@)
if 
   not Actor.Dead(11@)
jf @DEALER_709 
if 
   not Car.Wrecked(12@)
jf @DEALER_709 
if 
8495:   not car 12@ burning 
jf @DEALER_709 
05D2: AS_actor 11@ run_to_and_hijack_car 12@ max_search_radius 20.0 traffic_behavior 2 

:DEALER_709
TIMERA = 0 
11@ = -1 
return 

:DEALER_725
if 
   not Actor.Dead(0@)
jf @DEALER_844 
if 
   not Actor.Dead(11@)
jf @DEALER_844 
Actor.StorePos(0@, 3@, 4@, 5@)
Actor.StorePos(11@, 6@, 7@, 8@)
0509: 9@ = distance_between_XY 3@ 4@ and_XY 6@ 7@ 
if 
  9@ > 2.0 
jf @DEALER_837 
13@ = 1 
jump @DEALER_844 

:DEALER_837
13@ = 0 

:DEALER_844
return 

:DEALER_846
if 
   Model.Available(#COLT45)
jf @DEALER_929 
if 
   not Actor.HasWeapon(0@, 22)
jf @DEALER_929 
Actor.GiveWeaponAndAmmo(0@, Pistol, 1000)
if 
   not 15@ == 1 
jf @DEALER_922 
01B9: set_actor 0@ armed_weapon_to 0 
jump @DEALER_929 

:DEALER_922
01B9: set_actor 0@ armed_weapon_to 22 

:DEALER_929
return 

:DEALER_931
0871: init_jump_table 1@ total_jumps 4 default_jump 1 @DEALER_1285 jumps 0 @DEALER_994 1 @DEALER_1151 2 @DEALER_1211 3 @DEALER_1271 -1 @DEALER_1299 -1 @DEALER_1299 -1 @DEALER_1299 

:DEALER_994
if 
089B:   unknown_is_actor_in_dialogue_mode 0@ 
jf @DEALER_1038 
2@ = 0 
1@ = 3 
gosub @DEALER_2884 
jump @DEALER_1144 

:DEALER_1038
if 
  11@ > -1 
jf @DEALER_1137 
gosub @DEALER_725 
if 
  13@ == 0 
jf @DEALER_1109 
2@ = 0 
1@ = 2 
gosub @DEALER_2636 
jump @DEALER_1130 

:DEALER_1109
2@ = 0 
1@ = 1 
gosub @DEALER_1793 

:DEALER_1130
jump @DEALER_1144 

:DEALER_1137
gosub @DEALER_1301 

:DEALER_1144
jump @DEALER_1299 

:DEALER_1151
if 
  11@ > -1 
jf @DEALER_1183 
gosub @DEALER_1793 
jump @DEALER_1204 

:DEALER_1183
1@ = 0 
2@ = 0 
gosub @DEALER_1301 

:DEALER_1204
jump @DEALER_1299 

:DEALER_1211
if 
  11@ > -1 
jf @DEALER_1243 
gosub @DEALER_2636 
jump @DEALER_1264 

:DEALER_1243
1@ = 0 
2@ = 0 
gosub @DEALER_1301 

:DEALER_1264
jump @DEALER_1299 

:DEALER_1271
gosub @DEALER_2884 
jump @DEALER_1299 

:DEALER_1285
gosub @DEALER_3913 
jump @DEALER_1299 

:DEALER_1299
return 

:DEALER_1301
0871: init_jump_table 2@ total_jumps 3 default_jump 0 @DEALER_1791 jumps 0 @DEALER_1364 1 @DEALER_1488 2 @DEALER_1758 -1 @DEALER_1791 -1 @DEALER_1791 -1 @DEALER_1791 -1 @DEALER_1791 

:DEALER_1364
if 
874F:   not actor 0@ ped_event == 36 
jf @DEALER_1481 
089C: unknown_actor 0@ unknown_check 1 
062E: get_actor 0@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_1481 
0605: actor 0@ perform_animation ""DEALER_IDLE"" IFP ""DEALER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
TIMERB = 0 
14@ = 3000 
2@ += 1 

:DEALER_1481
jump @DEALER_1791 

:DEALER_1488
if 
002D:   TIMERB >= 14@ // (int) 
jf @DEALER_1751 
09B6: set_actor 0@ wanted_by_police 0 
0209: 13@ = random_int_in_ranges 1 15 
if 
  13@ > 5 
jf @DEALER_1659 
if 
  13@ > 10 
jf @DEALER_1610 
062E: get_actor 0@ task 1481 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_1603 
05C9: AS_actor 0@ on_guard -1 ms 
14@ = 2000 

:DEALER_1603
jump @DEALER_1652 

:DEALER_1610
062E: get_actor 0@ task 1502 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_1652 
05DE: AS_actor 0@ walk_around_ped_path 
14@ = 1500 

:DEALER_1652
jump @DEALER_1737 

:DEALER_1659
062E: get_actor 0@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_1737 
0605: actor 0@ perform_animation ""DEALER_IDLE"" IFP ""DEALER"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 
14@ = 3000 

:DEALER_1737
TIMERB = 0 
2@ += 1 

:DEALER_1751
jump @DEALER_1791 

:DEALER_1758
if 
002D:   TIMERB >= 14@ // (int) 
jf @DEALER_1784 
2@ = 1 

:DEALER_1784
jump @DEALER_1791 

:DEALER_1791
return 

:DEALER_1793
0871: init_jump_table 2@ total_jumps 6 default_jump 0 @DEALER_2634 jumps 0 @DEALER_1856 1 @DEALER_1907 2 @DEALER_2044 3 @DEALER_2074 4 @DEALER_2295 5 @DEALER_2505 -1 @DEALER_2634 

:DEALER_1856
089C: unknown_actor 0@ unknown_check 0 
05C9: AS_actor 0@ on_guard -1 ms 
05D9: AS_actor 11@ run_to_actor 0@ timelimit 20000 stop_within_radius 1.0 
TIMERB = 0 
2@ += 1 
jump @DEALER_2634 

:DEALER_1907
Actor.StorePos(0@, 3@, 4@, 5@)
Actor.StorePos(11@, 6@, 7@, 8@)
0509: 9@ = distance_between_XY 3@ 4@ and_XY 6@ 7@ 
05BF: AS_actor 0@ look_at_actor 11@ -1 ms 
if 
  1.8 >= 9@ 
jf @DEALER_1997 
2@ += 1 
jump @DEALER_2037 

:DEALER_1997
if 
  TIMERB > 20000 
jf @DEALER_2037 
gosub @DEALER_641 
2@ = 0 
1@ = 0 

:DEALER_2037
jump @DEALER_2634 

:DEALER_2044
0639: AS_actor 11@ rotate_to_actor 0@ 
0639: AS_actor 0@ rotate_to_actor 11@ 
2@ += 1 
jump @DEALER_2634 

:DEALER_2074
062E: get_actor 11@ task 1593 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2139 
062E: get_actor 11@ task 1466 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2139 
05BA: AS_actor 11@ move_mouth -1 ms 

:DEALER_2139
062E: get_actor 0@ task 1593 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2288 
062E: get_actor 0@ task 1466 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2204 
05BA: AS_actor 0@ move_mouth -1 ms 

:DEALER_2204
062E: get_actor 11@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2288 
0947: actor 11@ speak_from_audio_table 83 store_spoken_phrase_id_to 13@ 
0605: actor 11@ perform_animation ""SHOP_PAY"" IFP ""DEALER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
2@ += 1 

:DEALER_2288
jump @DEALER_2634 

:DEALER_2295
062E: get_actor 11@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2498 
0647: AS_actor 0@ clear_look_task 
062E: get_actor 11@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2404 
0605: actor 11@ perform_animation ""DRUGS_BUY"" IFP ""DEALER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
09B6: set_actor 11@ wanted_by_police 1 

:DEALER_2404
062E: get_actor 0@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2498 
0947: actor 0@ speak_from_audio_table 84 store_spoken_phrase_id_to 13@ 
0605: actor 0@ perform_animation ""DEALER_DEAL"" IFP ""DEALER"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
09B6: set_actor 0@ wanted_by_police 1 
2@ += 1 

:DEALER_2498
jump @DEALER_2634 

:DEALER_2505
062E: get_actor 11@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2570 
062E: get_actor 11@ task 1466 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2570 
05BA: AS_actor 11@ move_mouth -1 ms 

:DEALER_2570
062E: get_actor 0@ task 1541 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2627 
09A7: set_actor 11@ drugged_up 1 
gosub @DEALER_641 
2@ = 0 
1@ = 0 

:DEALER_2627
jump @DEALER_2634 

:DEALER_2634
return 

:DEALER_2636
0871: init_jump_table 2@ total_jumps 3 default_jump 0 @DEALER_2882 jumps 0 @DEALER_2699 1 @DEALER_2769 2 @DEALER_2825 -1 @DEALER_2882 -1 @DEALER_2882 -1 @DEALER_2882 -1 @DEALER_2882 

:DEALER_2699
089C: unknown_actor 0@ unknown_check 0 
Actor.StorePos(0@, 3@, 4@, 5@)
05BF: AS_actor 0@ look_at_actor 11@ -1 ms 
0850: AS_actor 0@ follow_actor 11@ 
0947: actor 0@ speak_from_audio_table 84 store_spoken_phrase_id_to 13@ 
TIMERB = 0 
2@ += 1 
jump @DEALER_2882 

:DEALER_2769
if 
  TIMERB > 6000 
jf @DEALER_2818 
0647: AS_actor 0@ clear_look_task 
05F5: AS_actor 0@ goto_point_using_paths 3@ 4@ 5@ mode 4 time -2 
2@ += 1 

:DEALER_2818
jump @DEALER_2882 

:DEALER_2825
062E: get_actor 0@ task 1525 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_2875 
gosub @DEALER_641 
2@ = 0 
1@ = 0 

:DEALER_2875
jump @DEALER_2882 

:DEALER_2882
return 

:DEALER_2884
0871: init_jump_table 2@ total_jumps 4 default_jump 0 @DEALER_3366 jumps 0 @DEALER_2947 1 @DEALER_2976 2 @DEALER_3178 3 @DEALER_3312 -1 @DEALER_3366 -1 @DEALER_3366 -1 @DEALER_3366 

:DEALER_2947
TIMERB = 0 
0639: AS_actor 0@ rotate_to_actor " + PlayerActor + @" 
2@ += 1 
jump @DEALER_3366 

:DEALER_2976
if 
88FE:   not text_box_displayed 
jf @DEALER_3039 
if and
871A:   not actor 0@ current_dialogue_text == 'DEAL2'  // ­e Јpњ®њЇaќ Їe®¬ ўcep©eџ, Јape®©.
871A:   not actor 0@ current_dialogue_text == 'DEAL3'  // ѓa ЈoҐeћ ¦Ё ®axyќ, Јape®©!
jf @DEALER_3039 
03E5: show_text_box 'TALK_1'  // ~k~~CONVERSATION_NO~ - ®e™a¦њў®Ёќ o¦ўe¦,~n~~k~~CONVERSATION_YES~ - Јoџњ¦њў®Ёќ o¦ўe¦.

:DEALER_3039
062E: get_actor 0@ task 1593 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_3128 
05BF: AS_actor 0@ look_at_actor " + PlayerActor + @" -1 ms 
062E: get_actor 0@ task 1466 status_store_to 13@ // ret 7 if not found 
if 
04A4:   13@ == 7 // == constant 
jf @DEALER_3114 
05BA: AS_actor 0@ move_mouth -2 ms 

:DEALER_3114
2@ += 1 
jump @DEALER_3171 

:DEALER_3128
if or
889B:   not unknown_is_actor_in_dialogue_mode 0@ 
  TIMERB > 15000 
jf @DEALER_3171 
0647: AS_actor 0@ clear_look_task 
2@ = 0 
1@ = 0 

:DEALER_3171
jump @DEALER_3366 

:DEALER_3178
if and
071A:   actor 0@ current_dialogue_text == 'DEAL3'  // ѓa ЈoҐeћ ¦Ё ®axyќ, Јape®©!
  TIMERB > 9000 
jf @DEALER_3220 
03E6: remove_text_box 
gosub @DEALER_3368 

:DEALER_3220
if and
071A:   actor 0@ current_dialogue_text == 'DEAL2'  // ­e Јpњ®њЇaќ Їe®¬ ўcep©eџ, Јape®©.
  TIMERB > 9000 
jf @DEALER_3262 
03E6: remove_text_box 
gosub @DEALER_3595 

:DEALER_3262
if or
889B:   not unknown_is_actor_in_dialogue_mode 0@ 
  TIMERB > 15000 
jf @DEALER_3305 
0647: AS_actor 0@ clear_look_task 
2@ = 0 
1@ = 0 

:DEALER_3305
jump @DEALER_3366 

:DEALER_3312
if 
  TIMERB > 2000 
jf @DEALER_3359 
0708: reset_decision_maker 8@ event 37 
01B9: set_actor 0@ armed_weapon_to 0 
2@ = 0 
1@ = 0 

:DEALER_3359
jump @DEALER_3366 

:DEALER_3366
return 

:DEALER_3368
03E6: remove_text_box 
0647: AS_actor 0@ clear_look_task 
089C: unknown_actor 0@ unknown_check 0 
if 
   Actor.HasWeapon(0@, 22)
jf @DEALER_3407 
01B9: set_actor 0@ armed_weapon_to 22 

:DEALER_3407
if 
   not 15@ == 1 
jf @DEALER_3593 
15@ = 1 
0652: 13@ = integer_stat 64 
if 
  13@ > 500 
jf @DEALER_3529 
077A: set_actor 0@ acquaintance 4 to_actors_pedtype 0 // see ped.dat 
0708: reset_decision_maker 8@ event 36 
0709: set_decision_maker 8@ on_event 36 taskID 927 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 // see *.ped files 
2@ = 0 
1@ = 0 
jump @DEALER_3593 

:DEALER_3529
077A: set_actor 0@ acquaintance 4 to_actors_pedtype 0 // see ped.dat 
0708: reset_decision_maker 8@ event 36 
0709: set_decision_maker 8@ on_event 36 taskID 1000 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 // see *.ped files 
2@ = 0 
1@ = 0 

:DEALER_3593
return 

:DEALER_3595
03E6: remove_text_box 
0647: AS_actor 0@ clear_look_task 
089C: unknown_actor 0@ unknown_check 0 
0652: 13@ = integer_stat 68 
if 
   not 15@ == 2 
jf @DEALER_3868 
15@ = 2 
if 
  13@ > 500 
jf @DEALER_3738 
077A: set_actor 0@ acquaintance 3 to_actors_pedtype 0 // see ped.dat 
01B9: set_actor 0@ armed_weapon_to 0 
0708: reset_decision_maker 8@ event 37 
0709: set_decision_maker 8@ on_event 37 taskID 927 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 1 on_foot 1 // see *.ped files 
2@ = 0 
1@ = 0 
jump @DEALER_3868 

:DEALER_3738
077A: set_actor 0@ acquaintance 3 to_actors_pedtype 0 // see ped.dat 
0708: reset_decision_maker 8@ event 37 
if 
   Actor.HasWeapon(0@, 22)
jf @DEALER_3820 
01B9: set_actor 0@ armed_weapon_to 22 
0709: set_decision_maker 8@ on_event 37 taskID 1020 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 // see *.ped files 
jump @DEALER_3854 

:DEALER_3820
0709: set_decision_maker 8@ on_event 37 taskID 413 respect 0.0 hate 100.0 like 0.0 dislike 0.0 in_car 0 on_foot 1 // see *.ped files 

:DEALER_3854
TIMERB = 0 
2@ += 1 

:DEALER_3868
return 

:DEALER_3870
076B: get_zone 17@s dealer_density_to 16@ 
if 
  16@ > 0 
jf @DEALER_3903 
16@ -= 1 

:DEALER_3903
076A: set_zone 17@s dealer_density_to 16@ 
return 

:DEALER_3913
if 
  15@ == 1 
jf @DEALER_3938 
gosub @DEALER_3870 

:DEALER_3938
08ED: remove_actor 0@ from_dialogue_mode 
if 
  11@ > -1 
jf @DEALER_3966 
Actor.RemoveReferences(11@)

:DEALER_3966
065C: release_decision_maker 8@ 
end_thread 
return 
0663: printint ""PEDSTATE"" 1@ 
0663: printint ""SUBSTATESTATUS"" 2@ 
0663: printint ""TIMER_B"" TIMERB 
0663: printint ""TIMER_A"" TIMERA 
return 
end_thread
" );

            }

        }

    }

}