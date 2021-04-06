using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class RCSHOP : External {

            Int _local0 = local( 0 ), 
                _local1 = local( 1 );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _9526 + @" = 0 
2@ = -2237.291 
3@ = 128.5856 
4@ = 1034.422 
5@ = 0.0 
6@ = 360.0 
04AF: 10@ = 217 
Model.Load(10@)

:RCSHOP_81
if 
   not Model.Available(10@)
jf @RCSHOP_108 
wait 0 
jump @RCSHOP_81 

:RCSHOP_108
0615: define_AS_pack_begin 7@ 
0638: AS_actor -1 stay_put 1 
05BA: AS_actor -1 move_mouth -2 ms 
0616: define_AS_pack_end 7@ 
061D: create_AS_origin_at 2@ 3@ 4@ Z_angle 5@ unknown_angle 6@ AS_pack 7@ handle_as 8@ 
0621: create_actor_pedtype 4 model 10@ at_AS_origin 8@ task 1466 handle_as 9@ 

:RCSHOP_169
if 
   Player.Defined(" + PlayerChar + @")
jf @RCSHOP_509 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @RCSHOP_225 
gosub @RCSHOP_520 

:RCSHOP_225
if and
  " + Zero_Total_Passed_Missions + @" == 3 
  " + OnMission + @" == 0 
jf @RCSHOP_305 
if 
0102:   actor " + PlayerActor + @" in_sphere -2219.287 133.8895 1034.641 radius 1.5 1.5 1.5 sphere " + OriginalSetup.OriginalScriptAccess[ 8 ].state + @" stopped_on_foot 
jf @RCSHOP_305 
" + ( OriginalSetup.OriginalScriptAccess[ 8 ].state ? "" : "//" ) + Video_Game + @" = 7 

:RCSHOP_305
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
   Player.WantedLevel(" + PlayerChar + @") > " + Player_Wanted_Level + @"
jf @RCSHOP_336 
" + _9526 + @" = 1 

:RCSHOP_336
if 
   not Actor.Dead(9@)
jf @RCSHOP_418 
if and
0457:   player " + PlayerChar + @" aiming_at_actor 9@ 
82D8:   not actor " + PlayerActor + @" current_weapon == 56 
jf @RCSHOP_392 
" + _9526 + @" = 1 
jump @RCSHOP_418 

:RCSHOP_392
if 
051A:   actor 9@ damaged_by_actor " + PlayerActor + @" 
jf @RCSHOP_418 
" + _9526 + @" = 1 

:RCSHOP_418
if 
  " + _9526 + @" == 1 
jf @RCSHOP_509 
Actor.StorePos(" + PlayerActor + @", 2@, 3@, 4@)
08E5: get_actor_in_sphere 2@ 3@ 4@ radius 20.0 handle_as 0@ 
if 
  0@ > -1 
jf @RCSHOP_509 
1@ += 1" );
                start_new_external_script<FFPNC>( _local0, _local1 );
                load_external_script<FFPNC>();
AppendLine( @"
:RCSHOP_509
wait 0 
jump @RCSHOP_169 

:RCSHOP_520
" + _9526 + @" = 0 
Actor.RemoveReferences(9@)
Model.Destroy(10@)
Actor.DestroyInstantly(9@)
061E: remove_references_to_AS_origin 8@ 
061B: remove_references_to_AS_pack 7@ 
end_thread" );
            }

        }

    }

}