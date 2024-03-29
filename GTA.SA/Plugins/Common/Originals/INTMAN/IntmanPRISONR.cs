﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PRISONR : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @PRISONR_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:PRISONR_60
if 
   not Actor.Dead(0@)
jf @PRISONR_109 
089F: get_actor 0@ pedtype_to 9@ 
if 
04A4:   9@ == 6 
jf @PRISONR_109 
Actor.DestroyInstantly(0@)
end_thread 

:PRISONR_109
04ED: load_animation ""GANGS"" 
Model.Load(#CIGAR)

:PRISONR_122
if 
84EE:   not animation ""GANGS"" loaded 
jf @PRISONR_153 
wait 0 
jump @PRISONR_122 

:PRISONR_153
if 
   not Model.Available(#CIGAR)
jf @PRISONR_179 
wait 0 
jump @PRISONR_153 

:PRISONR_179
if 
   not Actor.Dead(0@)
jf @PRISONR_266 
Actor.StorePos(0@, 6@, 7@, 8@)
12@ = Object.Create(#CIGAR, 6@, 7@, 8@)
070A: AS_actor 0@ attach_to_object 12@ offset 0.0 0.1 -0.02 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time -1 

:PRISONR_266
3@ = 1 
4@ = 0 
10@ = 0 

:PRISONR_287
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PRISONR_374 
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @PRISONR_360 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 
jump @PRISONR_1286 
jump @PRISONR_367 

:PRISONR_360
gosub @PRISONR_388 

:PRISONR_367
jump @PRISONR_381 

:PRISONR_374
gosub @PRISONR_1259 

:PRISONR_381
jump @PRISONR_287 

:PRISONR_388
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @PRISONR_465 jumps 1 @PRISONR_451 -1 @PRISONR_465 -1 @PRISONR_465 -1 @PRISONR_465 -1 @PRISONR_465 -1 @PRISONR_465 -1 @PRISONR_465 

:PRISONR_451
gosub @PRISONR_467 
jump @PRISONR_465 

:PRISONR_465
return 

:PRISONR_467
0871: init_jump_table 4@ total_jumps 5 default_jump 0 @PRISONR_1257 jumps 0 @PRISONR_530 1 @PRISONR_943 2 @PRISONR_986 3 @PRISONR_1029 4 @PRISONR_1148 -1 @PRISONR_1257 -1 @PRISONR_1257 

:PRISONR_530
0209: 9@ = random_int_in_ranges 0 100 
if 
  9@ >= 80 
jf @PRISONR_753 
Actor.StorePos(0@, 6@, 7@, 8@)
073F: get_actor_in_sphere 6@ 7@ 8@ radius 2.0 with_pedtype_civilian 1 gang 1 criminal/prostitute 1 handle_as 11@ 
if and
   not Actor.Dead(11@)
803B:   not  11@ == 0@ 
jf @PRISONR_649 
05E2: AS_actor 0@ kill_actor 11@ 
4@ = 2 
jump @PRISONR_1257 
jump @PRISONR_746 

:PRISONR_649
0605: actor 0@ perform_animation ""SMKCIG_PRTL"" IFP ""GANGS"" framedelta 1.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 
0669: 13@ = attach_particle ""EXHALE"" to_actor 0@ with_offset 0.0 0.0 0.0 type 1 
0883: attach_particle 13@ to_actor 0@ mode 5 
4@ = 3 
jump @PRISONR_1257 

:PRISONR_746
jump @PRISONR_936 

:PRISONR_753
if 
  9@ >= 30 
jf @PRISONR_839 
0605: actor 0@ perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 1.0 loop 1 lockX 0 lockY 0 lockF 0 time 5000 
0947: actor 0@ speak_from_audio_table 45 store_spoken_phrase_id_to 9@ 
4@ = 1 
jump @PRISONR_1257 
jump @PRISONR_936 

:PRISONR_839
0605: actor 0@ perform_animation ""SMKCIG_PRTL"" IFP ""GANGS"" framedelta 1.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 
0669: 13@ = attach_particle ""EXHALE"" to_actor 0@ with_offset 0.0 0.0 0.0 type 1 
0883: attach_particle 13@ to_actor 0@ mode 5 
4@ = 3 
jump @PRISONR_1257 

:PRISONR_936
jump @PRISONR_1257 

:PRISONR_943
062E: get_actor 0@ task 1541 status_store_to 9@ 
if 
04A4:   9@ == 7 
jf @PRISONR_979 
4@ = 0 

:PRISONR_979
jump @PRISONR_1257 

:PRISONR_986
062E: get_actor 0@ task 1506 status_store_to 9@ 
if 
04A4:   9@ == 7 
jf @PRISONR_1022 
4@ = 0 

:PRISONR_1022
jump @PRISONR_1257 

:PRISONR_1029
if 
   Actor.Animation(0@) == ""SMKCIG_PRTL""
jf @PRISONR_1129 
0613: 6@ = actor 0@ animation ""SMKCIG_PRTL"" time 
if and
  6@ >= 0.5 
  1.0 > 6@ 
jf @PRISONR_1122 
064C: make_particle 13@ visible 
4@ += 1 

:PRISONR_1122
jump @PRISONR_1141 

:PRISONR_1129
4@ = 0 
0650: destroy_particle 13@ 

:PRISONR_1141
jump @PRISONR_1257 

:PRISONR_1148
if 
   Actor.Animation(0@) == ""SMKCIG_PRTL""
jf @PRISONR_1238 
0613: 6@ = actor 0@ animation ""SMKCIG_PRTL"" time 
if 
  6@ >= 1.0 
jf @PRISONR_1231 
0650: destroy_particle 13@ 
4@ = 0 

:PRISONR_1231
jump @PRISONR_1250 

:PRISONR_1238
4@ = 0 
0650: destroy_particle 13@ 

:PRISONR_1250
jump @PRISONR_1257 

:PRISONR_1257
return 

:PRISONR_1259
04EF: release_animation ""GANGS"" 
Model.Destroy(#CIGAR)
Object.Destroy(12@)
0650: destroy_particle 13@ 
end_thread 
return 

:PRISONR_1286
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PRISONR_1356 
062E: get_actor 0@ task 1477 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @PRISONR_1349 
05C5: AS_actor 0@ cower -2 ms 

:PRISONR_1349
jump @PRISONR_1363 

:PRISONR_1356
gosub @PRISONR_1259 

:PRISONR_1363
jump @PRISONR_1286 
0663: printint ""PEDSTATE"" 3@ 
0663: printint ""SUBSTATESTATUS"" 4@ 
0663: printint ""LOOP_TIMER"" TIMERB 
0663: printint ""SCRIPT_TIMER"" TIMERA 
return 
end_thread" );
            }

        }

    }

}