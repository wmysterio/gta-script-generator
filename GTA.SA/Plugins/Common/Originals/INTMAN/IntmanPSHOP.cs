﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PSHOP : External {

            Int _local1 = local( 1 ), _local2 = local( 2 ), _local10 = local( 10 ), _local9 = local( 9 );

            public override void START( LabelJump label ) {
                AppendLine( @"" + FOOD_Player_Aggressive_Flag + @" = 0 
0871: init_jump_table 0@ total_jumps 3 default_jump 0 @PSHOP_552 jumps 0 @PSHOP_81 1 @PSHOP_238 2 @PSHOP_395 -1 @PSHOP_552 -1 @PSHOP_552 -1 @PSHOP_552 -1 @PSHOP_552 

:PSHOP_81
3@ = 377.3 
4@ = -117.182 
5@ = 1000.637 
6@ = 180.0 
7@ = 360.0 
04AF: 11@ = 155 
Model.Load(11@)
Model.Load(#PIZZAHIGH)
Model.Load(#CJ_PIZZA_2)

:PSHOP_152
if 
   not Model.Available(11@)
jf @PSHOP_179 
wait 0 
jump @PSHOP_152 

:PSHOP_179
if 
   not Model.Available(#PIZZAHIGH)
jf @PSHOP_205 
wait 0 
jump @PSHOP_179 

:PSHOP_205
if 
   not Model.Available(#CJ_PIZZA_2)
jf @PSHOP_231 
wait 0 
jump @PSHOP_205 

:PSHOP_231
jump @PSHOP_552 

:PSHOP_238
3@ = 371.5365 
4@ = -4.4935 
5@ = 1000.859 
6@ = 180.0 
7@ = 360.0 
04AF: 11@ = 167 
Model.Load(11@)
Model.Load(#BURGERHIGH)
Model.Load(#CJ_BURG_2)

:PSHOP_309
if 
   not Model.Available(11@)
jf @PSHOP_336 
wait 0 
jump @PSHOP_309 

:PSHOP_336
if 
   not Model.Available(#BURGERHIGH)
jf @PSHOP_362 
wait 0 
jump @PSHOP_336 

:PSHOP_362
if 
   not Model.Available(#CJ_BURG_2)
jf @PSHOP_388 
wait 0 
jump @PSHOP_362 

:PSHOP_388
jump @PSHOP_552 

:PSHOP_395
3@ = 378.4146 
4@ = -65.8567 
5@ = 1000.508 
6@ = 180.0 
7@ = 360.0 
04AF: 11@ = 205 
Model.Load(11@)
Model.Load(#BURGERHIGH)
Model.Load(#CJ_BURG_2)

:PSHOP_466
if 
   not Model.Available(11@)
jf @PSHOP_493 
wait 0 
jump @PSHOP_466 

:PSHOP_493
if 
   not Model.Available(#BURGERHIGH)
jf @PSHOP_519 
wait 0 
jump @PSHOP_493 

:PSHOP_519
if 
   not Model.Available(#CJ_BURG_2)
jf @PSHOP_545 
wait 0 
jump @PSHOP_519 

:PSHOP_545
jump @PSHOP_552 

:PSHOP_552
0615: define_AS_pack_begin 8@ 
0638: AS_actor -1 stay_put 1 
05BA: AS_actor -1 move_mouth -2 ms 
0616: define_AS_pack_end 8@ 
061D: create_AS_origin_at 3@ 4@ 5@ Z_angle 6@ unknown_angle 7@ AS_pack 8@ handle_as 9@ 
0621: create_actor_pedtype 4 model 11@ at_AS_origin 9@ task 1466 handle_as 10@" );
                start_new_external_script<SKBRAIN>( _local10, _local9 );
                load_external_script<SKBRAIN>();
AppendLine( @"
:PSHOP_628
if 
   Player.Defined(" + PlayerChar + @")
jf @PSHOP_873 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @PSHOP_684 
gosub @PSHOP_884 

:PSHOP_684
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
jf @PSHOP_707 
" + FOOD_Player_Aggressive_Flag + @" = 1 

:PSHOP_707
if 
   not Actor.Dead(10@)
jf @PSHOP_782 
if 
0457:   player " + PlayerChar + @" aiming_at_actor 10@ 
jf @PSHOP_756 
" + FOOD_Player_Aggressive_Flag + @" = 1 
jump @PSHOP_782 

:PSHOP_756
if 
051A:   actor 10@ damaged_by_actor " + PlayerActor + @" 
jf @PSHOP_782 
" + FOOD_Player_Aggressive_Flag + @" = 1 

:PSHOP_782
if 
  " + FOOD_Player_Aggressive_Flag + @" == 1 
jf @PSHOP_873 
Actor.StorePos(" + PlayerActor + @", 3@, 4@, 5@)
08E5: get_actor_in_sphere 3@ 4@ 5@ radius 20.0 handle_as 1@ 
if 
  1@ > -1 
jf @PSHOP_873 
2@ += 1" );
                start_new_external_script<FFPNC>( _local1, _local2 );
                load_external_script<FFPNC>();
AppendLine( @"
:PSHOP_873
wait 0 
jump @PSHOP_628 

:PSHOP_884
" + FOOD_Player_Aggressive_Flag + @" = 0 
Actor.RemoveReferences(10@)
Model.Destroy(#WMYPIZZ)
Model.Destroy(#WMYBELL)
Model.Destroy(#WFYBURG)
Model.Destroy(#PIZZAHIGH)
Model.Destroy(#BURGERHIGH)
Model.Destroy(#CJ_PIZZA_2)
Model.Destroy(#CJ_BURG_2)
Actor.DestroyInstantly(10@)
061E: remove_references_to_AS_origin 9@ 
061B: remove_references_to_AS_pack 8@ 
end_thread 
end_thread" );
            }

        }

    }

}