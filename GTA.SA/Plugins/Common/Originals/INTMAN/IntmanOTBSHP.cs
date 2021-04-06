using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class OTBSHP : External {

            Int _local0 = local( 0 ),
                _local1 = local( 1 ),
                _local3 = local( 3 ),
                _local4 = local( 4 ),
                _local5 = local( 5 ),
                _local6 = local( 6 ),
                _local7 = local( 7 ),
                _local8 = local( 8 ),
                _local9 = local( 9 ),
                _local10 = local( 10 );

            public override void START( LabelJump label ) {
                AppendLine( @"if 
  " + OnMission + @" == 0 
jf @OTBSHP_36 
" + _2881 + @" = 0 

:OTBSHP_36
1@ = 1 
Model.Load(#VBFYCRP)
Model.Load(#VWFYCRP)

:OTBSHP_52
if 
   not Model.Available(#VWFYCRP)
jf @OTBSHP_79 
wait 0 
jump @OTBSHP_52 

:OTBSHP_79
if 
   not Model.Available(#VBFYCRP)
jf @OTBSHP_105 
wait 0 
jump @OTBSHP_79 

:OTBSHP_105
0615: define_AS_pack_begin 2@ 
0638: AS_actor -1 stay_put 1 
05BA: AS_actor -1 move_mouth -2 ms 
0616: define_AS_pack_end 2@ 
061D: create_AS_origin_at 820.3698 -0.3935 1003.18 Z_angle 270.0 unknown_angle 90.0 AS_pack 2@ handle_as 3@ 
061D: create_AS_origin_at 820.133 4.2015 1003.18 Z_angle 270.0 unknown_angle 90.0 AS_pack 2@ handle_as 4@ 
061D: create_AS_origin_at 820.3185 6.4021 1003.18 Z_angle 270.0 unknown_angle 90.0 AS_pack 2@ handle_as 5@ 
061D: create_AS_origin_at 820.0 2.0 1003.0 Z_angle 270.0 unknown_angle 90.0 AS_pack 2@ handle_as 6@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 3@ task 1466 handle_as 7@ 
0621: create_actor_pedtype 5 model #VBFYCRP at_AS_origin 4@ task 1466 handle_as 8@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 5@ task 1466 handle_as 9@ 
0621: create_actor_pedtype 5 model #VBFYCRP at_AS_origin 6@ task 1466 handle_as 10@" );
                start_new_external_script<OTBSTAF>( _local7, _local3 );
                start_new_external_script<OTBSTAF>( _local8, _local4 );
                start_new_external_script<OTBSTAF>( _local9, _local5 );
                start_new_external_script<OTBSTAF>( _local10, _local6 );
                load_external_script<OTBSTAF>();
AppendLine( @"
:OTBSHP_369
if 
   Player.Defined(" + PlayerChar + @")
jf @OTBSHP_655 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @OTBSHP_425 
jump @OTBSHP_666 

:OTBSHP_425
if or
02E0:   actor " + PlayerActor + @" firing_weapon 
   Player.WantedLevel(" + PlayerChar + @") > " + Player_Wanted_Level + @"
jf @OTBSHP_456 
" + _2881 + @" = 1 

:OTBSHP_456
0@ = 0 

:OTBSHP_463
if 
   not Actor.Dead(7@(0@,4i))
jf @OTBSHP_557 
if and
0457:   player " + PlayerChar + @" aiming_at_actor 7@(0@,4i) 
82D8:   not actor " + PlayerActor + @" current_weapon == 56 
jf @OTBSHP_527 
" + _2881 + @" = 1 
jump @OTBSHP_557 

:OTBSHP_527
if 
051A:   actor 7@(0@,4i) damaged_by_actor " + PlayerActor + @" 
jf @OTBSHP_557 
" + _2881 + @" = 1 

:OTBSHP_557
0@ += 1 
  0@ >= 4 
jf @OTBSHP_463 
if 
  " + _2881 + @" == 1 
jf @OTBSHP_655 
08E5: get_actor_in_sphere 11@ 12@ 13@ radius 20.0 handle_as 0@ 
if 
  0@ > -1 
jf @OTBSHP_655 
1@ += 1 " );
                start_new_external_script<FFPNC>( _local0, _local1 );
                load_external_script<FFPNC>();
AppendLine( @"
:OTBSHP_655
wait 0 
jump @OTBSHP_369 

:OTBSHP_666
0@ = 0 

:OTBSHP_673
Actor.RemoveReferences(7@(0@,4i))
Actor.DestroyInstantly(7@(0@,4i))
061E: remove_references_to_AS_origin 3@(0@,4i) 
0@ += 1 
  0@ >= 4 
jf @OTBSHP_673 
Model.Destroy(#VWFYCRP)
Model.Destroy(#VBFYCRP)
061B: remove_references_to_AS_pack 2@ 
end_thread 
end_thread" );
            }

        }

    }

}