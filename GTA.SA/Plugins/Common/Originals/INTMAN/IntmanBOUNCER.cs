﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class BOUNCER : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @BOUNCER_60 
0@ = Actor.Create(CivMale, #NULL, 0.0, 0.0, 0.0)

:BOUNCER_60
if 
   not Model.Available(#COLT45)
jf @BOUNCER_88 
Model.Load(#COLT45)
jump @BOUNCER_60 

:BOUNCER_88
if 
   not Actor.Dead(0@)
jf @BOUNCER_187 
Actor.GiveWeaponAndAmmo(0@, Pistol, 99999999)
01B9: set_actor 0@ armed_weapon_to 0 
if 
   Actor.HasWeapon(0@, 3)
jf @BOUNCER_148 
0555: remove_weapon 3 from_actor 0@ 

:BOUNCER_148
Actor.WeaponAccuracy(0@) = 80
0978: copy_decision_maker 65537 to " + _9538 + @" 
0708: reset_decision_maker " + _9538 + @" event 27 
0708: reset_decision_maker " + _9538 + @" event 48 
060B: set_actor 0@ decision_maker_to " + _9538 + @" 

:BOUNCER_187
3@ = 0 
4@ = 0 

:BOUNCER_201
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BOUNCER_279 
if 
  " + _9471 + @" == 0 
jf @BOUNCER_265 
gosub @BOUNCER_293 
jump @BOUNCER_272 

:BOUNCER_265
jump @BOUNCER_693 

:BOUNCER_272
jump @BOUNCER_286 

:BOUNCER_279
gosub @BOUNCER_864 

:BOUNCER_286
jump @BOUNCER_201 

:BOUNCER_293
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @BOUNCER_370 jumps 0 @BOUNCER_356 -1 @BOUNCER_370 -1 @BOUNCER_370 -1 @BOUNCER_370 -1 @BOUNCER_370 -1 @BOUNCER_370 -1 @BOUNCER_370 

:BOUNCER_356
gosub @BOUNCER_372 
jump @BOUNCER_370 

:BOUNCER_370
return 

:BOUNCER_372
0871: init_jump_table 4@ total_jumps 3 default_jump 0 @BOUNCER_691 jumps 0 @BOUNCER_435 1 @BOUNCER_498 2 @BOUNCER_658 -1 @BOUNCER_691 -1 @BOUNCER_691 -1 @BOUNCER_691 -1 @BOUNCER_691 

:BOUNCER_435
062E: get_actor 0@ task 1502 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BOUNCER_491 
05DE: AS_actor 0@ walk_around_ped_path 
TIMERB = 0 
6@ = 5000 
4@ += 1 

:BOUNCER_491
jump @BOUNCER_691 

:BOUNCER_498
if 
002D:   TIMERB >= 6@ 
jf @BOUNCER_651 
0209: 2@ = random_int_in_ranges 1 10 
if 
  2@ > 5 
jf @BOUNCER_595 
062E: get_actor 0@ task 1481 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BOUNCER_588 
05C9: AS_actor 0@ on_guard -1 ms 
6@ = 5000 

:BOUNCER_588
jump @BOUNCER_637 

:BOUNCER_595
062E: get_actor 0@ task 1502 status_store_to 2@ 
if 
04A4:   2@ == 7 
jf @BOUNCER_637 
05DE: AS_actor 0@ walk_around_ped_path 
6@ = 5000 

:BOUNCER_637
TIMERB = 0 
4@ += 1 

:BOUNCER_651
jump @BOUNCER_691 

:BOUNCER_658
if 
002D:   TIMERB >= 6@ 
jf @BOUNCER_684 
4@ = 1 

:BOUNCER_684
jump @BOUNCER_691 

:BOUNCER_691
return 

:BOUNCER_693
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @BOUNCER_850 
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
jf @BOUNCER_799 
01B9: set_actor 0@ armed_weapon_to 22 
062E: get_actor 0@ task 1588 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @BOUNCER_792 
0634: AS_actor 0@ attack_using_weapon_actor " + PlayerActor + @" flags 1 perform_actions_after_time 4000 chance_of_action 60 

:BOUNCER_792
jump @BOUNCER_843 

:BOUNCER_799
01B9: set_actor 0@ armed_weapon_to 22 
062E: get_actor 0@ task 1506 status_store_to 5@ 
if 
04A4:   5@ == 7 
jf @BOUNCER_843 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 

:BOUNCER_843
jump @BOUNCER_857 

:BOUNCER_850
gosub @BOUNCER_864 

:BOUNCER_857
jump @BOUNCER_693 

:BOUNCER_864
065C: release_decision_maker " + _9538 + @" 
Actor.RemoveReferences(0@)
end_thread 
return 
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