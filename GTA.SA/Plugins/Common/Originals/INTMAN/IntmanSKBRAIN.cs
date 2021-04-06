using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class SKBRAIN : External {

            Actor _local2 = local( 2 );
            Float _local13 = local( 13 ), 
                  _local14 = local( 14 ), 
                  _local15 = local( 15 );

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @SKBRAIN_114 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)
061D: create_AS_origin_at 0.0 0.0 0.0 Z_angle 0.0 unknown_angle 0.0 AS_pack -1 handle_as 1@ 
6@ = Object.Create(#NULL, 0.0, 0.0, 0.0)

:SKBRAIN_114
if 
   not Actor.Dead(0@)
jf @SKBRAIN_138 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_B + @" 

:SKBRAIN_138
04ED: load_animation ""FOOD"" 

:SKBRAIN_146
if 
84EE:   not animation ""FOOD"" loaded 
jf @SKBRAIN_176 
wait 0 
jump @SKBRAIN_146 

:SKBRAIN_176
3@ = 1 
4@ = 0 
5@ = 0 
7@ = 0 

:SKBRAIN_204
wait 0 
if and
   not Actor.Dead(0@)
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @SKBRAIN_377 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @SKBRAIN_283 
gosub @SKBRAIN_1552 
jump @SKBRAIN_370 

:SKBRAIN_283
if or
0457:   player " + PlayerChar + @" aiming_at_actor 0@ 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @SKBRAIN_331 
if 
03CA:   object 6@ exists 
jf @SKBRAIN_331 
Object.Destroy(6@)

:SKBRAIN_331
if 
  " + FOOD_Player_Aggressive_Flag + @" == 0 
jf @SKBRAIN_363 
gosub @SKBRAIN_391 
jump @SKBRAIN_370 

:SKBRAIN_363
jump @SKBRAIN_1590 

:SKBRAIN_370
jump @SKBRAIN_384 

:SKBRAIN_377
gosub @SKBRAIN_1552 

:SKBRAIN_384
jump @SKBRAIN_204 

:SKBRAIN_391
0871: init_jump_table 3@ total_jumps 3 default_jump 0 @SKBRAIN_496 jumps 1 @SKBRAIN_454 2 @SKBRAIN_468 3 @SKBRAIN_482 -1 @SKBRAIN_496 -1 @SKBRAIN_496 -1 @SKBRAIN_496 -1 @SKBRAIN_496 

:SKBRAIN_454
gosub @SKBRAIN_498 
jump @SKBRAIN_496 

:SKBRAIN_468
gosub @SKBRAIN_841 
jump @SKBRAIN_496 

:SKBRAIN_482
gosub @SKBRAIN_1185 
jump @SKBRAIN_496 

:SKBRAIN_496
return 

:SKBRAIN_498
0871: init_jump_table 4@ total_jumps 2 default_jump 0 @SKBRAIN_839 jumps 0 @SKBRAIN_561 1 @SKBRAIN_737 -1 @SKBRAIN_839 -1 @SKBRAIN_839 -1 @SKBRAIN_839 -1 @SKBRAIN_839 -1 @SKBRAIN_839 

:SKBRAIN_561
04C4: store_coords_to 13@ 14@ 15@ from_actor 0@ with_offset 0.0 3.0 3.0" );
                _local2.get_of_closest_map_attractor<PCUSTOM>( _local13, _local14, _local15, ( double ) 20.0, 2753 );
AppendLine( @"if 
  2@ > -1 
jf @SKBRAIN_730 
04C4: store_coords_to 10@ 11@ 12@ from_actor 0@ with_offset -5.0 -5.0 -5.0 
6@ = Object.Create(#PIZZAHIGH, 10@, 11@, 12@)
0605: actor 0@ perform_animation ""SHP_TRAY_IN"" IFP ""FOOD"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:SKBRAIN_730
jump @SKBRAIN_839 

:SKBRAIN_737
9@ = 0.0 
if 
   Actor.Animation(0@) == ""SHP_TRAY_IN""
jf @SKBRAIN_832 
0613: 9@ = actor 0@ animation ""SHP_TRAY_IN"" time 
if 
  9@ == 1.0 
jf @SKBRAIN_832 
4@ = 0 
3@ += 1 

:SKBRAIN_832
jump @SKBRAIN_839 

:SKBRAIN_839
return 

:SKBRAIN_841
0871: init_jump_table 4@ total_jumps 3 default_jump 0 @SKBRAIN_1183 jumps 0 @SKBRAIN_904 1 @SKBRAIN_1044 2 @SKBRAIN_1143 -1 @SKBRAIN_1183 -1 @SKBRAIN_1183 -1 @SKBRAIN_1183 -1 @SKBRAIN_1183 

:SKBRAIN_904
if 
03CA:   object 6@ exists 
jf @SKBRAIN_1023 
070A: AS_actor 0@ attach_to_object 6@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
0812: AS_actor 0@ perform_animation ""SHP_TRAY_LIFT"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
TIMERB = 0 
4@ += 1 
jump @SKBRAIN_1037 

:SKBRAIN_1023
4@ = 0 
3@ += 1 

:SKBRAIN_1037
jump @SKBRAIN_1183 

:SKBRAIN_1044
9@ = 0.0 
if 
   Actor.Animation(0@) == ""SHP_TRAY_LIFT""
jf @SKBRAIN_1136 
0613: 9@ = actor 0@ animation ""SHP_TRAY_LIFT"" time 
if 
  9@ == 1.0 
jf @SKBRAIN_1136 
4@ += 1 

:SKBRAIN_1136
jump @SKBRAIN_1183 

:SKBRAIN_1143
if 
  TIMERB > 2000 
jf @SKBRAIN_1176 
4@ = 0 
3@ += 1 

:SKBRAIN_1176
jump @SKBRAIN_1183 

:SKBRAIN_1183
return 

:SKBRAIN_1185
0871: init_jump_table 4@ total_jumps 4 default_jump 0 @SKBRAIN_1550 jumps 0 @SKBRAIN_1248 1 @SKBRAIN_1340 2 @SKBRAIN_1397 3 @SKBRAIN_1529 -1 @SKBRAIN_1550 -1 @SKBRAIN_1550 -1 @SKBRAIN_1550 

:SKBRAIN_1248
04C4: store_coords_to 13@ 14@ 15@ from_actor 0@ with_offset 0.0 3.0 3.0" );
                _local2.get_of_closest_map_attractor<PCUSTOM>( _local13, _local14, _local15, ( double ) 20.0, 2753 );
AppendLine( @"if 
  2@ == -1 
jf @SKBRAIN_1333 
4@ += 1 

:SKBRAIN_1333
jump @SKBRAIN_1550 

:SKBRAIN_1340
0812: AS_actor 0@ perform_animation ""SHP_TRAY_RETURN"" IFP ""FOOD"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 
jump @SKBRAIN_1550 

:SKBRAIN_1397
9@ = 0.0 
if 
   Actor.Animation(0@) == ""SHP_TRAY_RETURN""
jf @SKBRAIN_1522 
0613: 9@ = actor 0@ animation ""SHP_TRAY_RETURN"" time 
if 
  9@ == 1.0 
jf @SKBRAIN_1522 
if 
03CA:   object 6@ exists 
jf @SKBRAIN_1507 
Object.Destroy(6@)

:SKBRAIN_1507
074C: AS_actor 0@ goto_AS_origin 1@ 
4@ += 1 

:SKBRAIN_1522
jump @SKBRAIN_1550 

:SKBRAIN_1529
4@ = 0 
3@ = 1 
jump @SKBRAIN_1550 

:SKBRAIN_1550
return 

:SKBRAIN_1552
04EF: release_animation ""FOOD"" 
Object.RemoveReferences(6@)
if 
   not Actor.Dead(0@)
jf @SKBRAIN_1586 
0792: disembark_instantly_actor 0@ 

:SKBRAIN_1586
end_thread 
return 

:SKBRAIN_1590
wait 0 
if and
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @SKBRAIN_1762 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @SKBRAIN_1664 
gosub @SKBRAIN_1552 
jump @SKBRAIN_1755 

:SKBRAIN_1664
if 
   not Actor.Dead(0@)
jf @SKBRAIN_1755 
062E: get_actor 0@ task 1476 status_store_to 7@ 
if 
04A4:   7@ == 7 
jf @SKBRAIN_1755 
05C4: AS_actor 0@ hands_up -2 ms 
if 
0737:   actor 0@ lifting_object -1 
jf @SKBRAIN_1755 
if 
03CA:   object 6@ exists 
jf @SKBRAIN_1755 
Object.Destroy(6@)

:SKBRAIN_1755
jump @SKBRAIN_1769 

:SKBRAIN_1762
gosub @SKBRAIN_1552 

:SKBRAIN_1769
jump @SKBRAIN_1590 
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