﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class OTBSTAF : External {

            Actor _local2 = local( 2 );

            Float _local9 = local( 9 ),
                  _local10 = local( 10 ),
                  _local11 = local( 11 );

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @OTBSTAF_92 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)
061D: create_AS_origin_at 0.0 0.0 0.0 Z_angle 0.0 unknown_angle 0.0 AS_pack -1 handle_as 1@ 

:OTBSTAF_92
04ED: load_animation ""INT_SHOP"" 

:OTBSTAF_104
if 
84EE:   not animation ""INT_SHOP"" loaded 
jf @OTBSTAF_138 
wait 0 
jump @OTBSTAF_104 

:OTBSTAF_138
if 
   not Actor.Dead(0@)
jf @OTBSTAF_162 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_B + @" 

:OTBSTAF_162
3@ = 1 
4@ = 0 
6@ = 0 

:OTBSTAF_183
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBSTAF_256 
if 
  " + _2881 + @" == 0 
jf @OTBSTAF_242 
gosub @OTBSTAF_270 
jump @OTBSTAF_249 

:OTBSTAF_242
jump @OTBSTAF_848 

:OTBSTAF_249
jump @OTBSTAF_263 

:OTBSTAF_256
gosub @OTBSTAF_832 

:OTBSTAF_263
jump @OTBSTAF_183 

:OTBSTAF_270
0871: init_jump_table 3@ total_jumps 2 default_jump 0 @OTBSTAF_361 jumps 1 @OTBSTAF_333 2 @OTBSTAF_347 -1 @OTBSTAF_361 -1 @OTBSTAF_361 -1 @OTBSTAF_361 -1 @OTBSTAF_361 -1 @OTBSTAF_361 

:OTBSTAF_333
gosub @OTBSTAF_363 
jump @OTBSTAF_361 

:OTBSTAF_347
gosub @OTBSTAF_668 
jump @OTBSTAF_361 

:OTBSTAF_361
return 

:OTBSTAF_363
0871: init_jump_table 4@ total_jumps 2 default_jump 0 @OTBSTAF_666 jumps 0 @OTBSTAF_426 1 @OTBSTAF_562 -1 @OTBSTAF_666 -1 @OTBSTAF_666 -1 @OTBSTAF_666 -1 @OTBSTAF_666 -1 @OTBSTAF_666 

:OTBSTAF_426
04C4: store_coords_to 9@ 10@ 11@ from_actor 0@ with_offset 0.0 3.0 3.0" );
                _local2.get_of_closest_map_attractor<PCUSTOM>( _local9, _local10, _local11, ( double ) 3.0, 2753 );
AppendLine( @"if 
  2@ > -1 
jf @OTBSTAF_555 
0605: actor 0@ perform_animation ""SHOP_CASHIER"" IFP ""INT_SHOP"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
4@ += 1 

:OTBSTAF_555
jump @OTBSTAF_666 

:OTBSTAF_562
8@ = 0.0 
if 
   Actor.Animation(0@) == ""SHOP_CASHIER""
jf @OTBSTAF_659 
0613: 8@ = actor 0@ animation ""SHOP_CASHIER"" time 
if 
  8@ == 1.0 
jf @OTBSTAF_659 
4@ = 0 
3@ += 1 

:OTBSTAF_659
jump @OTBSTAF_666 

:OTBSTAF_666
return 

:OTBSTAF_668
0871: init_jump_table 4@ total_jumps 1 default_jump 0 @OTBSTAF_830 jumps 0 @OTBSTAF_731 -1 @OTBSTAF_830 -1 @OTBSTAF_830 -1 @OTBSTAF_830 -1 @OTBSTAF_830 -1 @OTBSTAF_830 -1 @OTBSTAF_830 

:OTBSTAF_731
04C4: store_coords_to 9@ 10@ 11@ from_actor 0@ with_offset 0.0 3.0 3.0" );
                _local2.get_of_closest_map_attractor<PCUSTOM>( _local9, _local10, _local11, 3.0, 2753 );
AppendLine( @"if 
  2@ == -1 
jf @OTBSTAF_823 
4@ = 0 
3@ = 1 

:OTBSTAF_823
jump @OTBSTAF_830 

:OTBSTAF_830
return 

:OTBSTAF_832
04EF: release_animation ""INT_SHOP"" 
end_thread 
return 

:OTBSTAF_848
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @OTBSTAF_918 
062E: get_actor 0@ task 1476 status_store_to 6@ 
if 
04A4:   6@ == 7 
jf @OTBSTAF_911 
05C4: AS_actor 0@ hands_up -2 ms 

:OTBSTAF_911
jump @OTBSTAF_925 

:OTBSTAF_918
gosub @OTBSTAF_832 

:OTBSTAF_925
jump @OTBSTAF_848 
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