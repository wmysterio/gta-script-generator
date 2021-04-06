using GTA.Core;
using System.Collections.Generic;

namespace GTA.Plugins.Common {

    internal partial class OriginalVehicleMissions : Original {

        internal OriginalVehicleMissions() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            _56.value = 1;
            Array<Car> cars = Script.global_array( 14 );
            Script.CAR_PARK.init( cars[ 0 ], 2033.888, -1432.67, 16.6453, 177.829, 416, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 1 ], 1178.048, -1338.175, 13.405, 269.4923, 416, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 2 ], -303.7814, 1032.326, 19.086, 268.5016, 416, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 3 ], -1507.164, 2525.455, 55.1875, 358.5728, 416, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 4 ], 1229.665, 297.6883, 19.0547, 154.9553, 416, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 5 ], -2202.52, -2315.986, 30.1172, 319.6815, 416, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 6 ], -2057.0, 58.0, 28.0, 90.0, 544, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 7 ], -2057.0, 64.0, 28.0, 90.0, 407, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 8 ], 1763.824, 2075.757, 9.9093, 179.4753, 407, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 9 ], 1751.512, -1455.102, 12.5547, 263.5589, 407, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 10 ], 2251.028, -1788.661, 12.7625, 358.9591, 609, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 11 ], -2118.171, -4.0948, 35.0203, 270.142, 609, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 12 ], 2596.747, 1444.245, 10.3203, 178.2712, 609, forceSpawn_bool: true );
            Script.CAR_PARK.init( cars[ 13 ], 1918.988, -1789.324, 12.5, 270.0, 575, forceSpawn_bool: true );
            for( ushort i = 0; i < 14; i++ )
                Script.CAR_PARK.set_chance_to_generate( cars[ i ], 101 );
            Script.init_external_script_brain<HOUSE>();
            Script.create_thread<R3>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal class BACKON : Thread {

            public override void START( LabelJump label ) {
                wait( 5000 );
                display_stat_update_box( 1 );
                end_thread();
            }

        }

        internal class FRTEXT : Thread {

            public override void START( LabelJump label ) {
                wait( 5000 );
                remove_text_box();
                show_text_box( "FREI_16" );
                end_thread();
            }

        }

        private class R3 : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"
:R3_11
wait 70 
if 
  " + OnMission + @" == 0 
else_jump @R3_4103 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @R3_4103 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @R3_4001 
if 
89BE:   not are_text_boxes_locked_to_any_thread 
else_jump @R3_3994 
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_110 
jump @R3_4110 
jump @R3_3994 

:R3_110
if or
   Actor.DrivingTaxiVehicle(" + PlayerActor + @")
   Actor.DrivingVehicleType(" + PlayerActor + @", #AMBULAN)
   Actor.DrivingVehicleType(" + PlayerActor + @", #FIRETRUK)
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
   Actor.DrivingVehicleType(" + PlayerActor + @", #BOXBURG)
   Actor.DrivingPoliceVehicle(" + PlayerActor + @")
else_jump @R3_2901 
" + _63 + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
82BF:   not car " + _63 + @" sunk 
else_jump @R3_2901 
if 
   Actor.DrivingTaxiVehicle(" + PlayerActor + @")
else_jump @R3_673 
if 
8596:   not NOP_false " + PlayerChar + @" 
else_jump @R3_673 
if 
  " + ONMISSION_TAXI + @" == 0 
else_jump @R3_673 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_286 
if 
88FE:   not text_box_displayed 
else_jump @R3_286 
03E5: show_text_box 'TTUTOR'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_286
if 
   not " + _13 + @"== 3 
else_jump @R3_492 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_485 

:R3_321
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_447 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_367 
jump @R3_11 

:R3_367
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingTaxiVehicle(" + PlayerActor + @")
else_jump @R3_395 
jump @R3_11 

:R3_395
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_415 
jump @R3_11 

:R3_415
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_440 
jump @R3_11 

:R3_440
jump @R3_321 

:R3_447
00BA: show_text_styled GXT 'TAXI_M' time 6000 style 5  
wait 0" );
                start_mission<TAXIODD>();
                AppendLine( @"" + ONMISSION_TAXI + @" = 1 
jump @R3_11 

:R3_485
jump @R3_673 

:R3_492
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_673 

:R3_509
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_635 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_555 
jump @R3_11 

:R3_555
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingTaxiVehicle(" + PlayerActor + @")
else_jump @R3_583 
jump @R3_11 

:R3_583
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_603 
jump @R3_11 

:R3_603
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_628 
jump @R3_11 

:R3_628
jump @R3_509 

:R3_635
00BA: show_text_styled GXT 'TAXI_M' time 6000 style 5  
wait 0" );
                start_mission<TAXIODD>();
                AppendLine( @"" + ONMISSION_TAXI + @" = 1 
jump @R3_11 

:R3_673
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #AMBULAN)
else_jump @R3_1138 
if 
  " + ONMISSION_Paramedic + @" == 0 
else_jump @R3_1138 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_759 
if 
88FE:   not text_box_displayed 
else_jump @R3_759 
03E5: show_text_box 'ATUTOR'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_759
if 
   not " + _13 + @"== 3 
else_jump @R3_961 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_954 

:R3_794
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_923 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_840 
jump @R3_11 

:R3_840
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #AMBULAN)
else_jump @R3_871 
jump @R3_11 

:R3_871
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_891 
jump @R3_11 

:R3_891
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_916 
jump @R3_11 

:R3_916
jump @R3_794 

:R3_923
00BA: show_text_styled GXT 'AMBUL_M' time 6000 style 5  
wait 0" );
                start_mission<AMBULAN>();
                AppendLine( @"jump @R3_11 

:R3_954
jump @R3_1138 

:R3_961
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_1138 

:R3_978
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_1107 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_1024 
jump @R3_11 

:R3_1024
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #AMBULAN)
else_jump @R3_1055 
jump @R3_11 

:R3_1055
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_1075 
jump @R3_11 

:R3_1075
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_1100 
jump @R3_11 

:R3_1100
jump @R3_978 

:R3_1107
00BA: show_text_styled GXT 'AMBUL_M' time 6000 style 5  
wait 0" );
                start_mission<AMBULAN>();
                AppendLine( @"jump @R3_11 

:R3_1138
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #FIRETRUK)
else_jump @R3_1603 
if 
  " + ONMISSION_Firefighter + @" == 0 
else_jump @R3_1603 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_1224 
if 
88FE:   not text_box_displayed 
else_jump @R3_1224 
03E5: show_text_box 'FTUTOR'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_1224
if 
   not " + _13 + @"== 3 
else_jump @R3_1426 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_1419 

:R3_1259
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_1388 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_1305 
jump @R3_11 

:R3_1305
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #FIRETRUK)
else_jump @R3_1336 
jump @R3_11 

:R3_1336
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_1356 
jump @R3_11 

:R3_1356
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_1381 
jump @R3_11 

:R3_1381
jump @R3_1259 

:R3_1388
00BA: show_text_styled GXT 'FIRE_M' time 6000 style 5  
wait 0" );
                start_mission<FIRETRU>();
                AppendLine( @"jump @R3_11 

:R3_1419
jump @R3_1603 

:R3_1426
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_1603 

:R3_1443
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_1572 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_1489 
jump @R3_11 

:R3_1489
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #FIRETRUK)
else_jump @R3_1520 
jump @R3_11 

:R3_1520
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_1540 
jump @R3_11 

:R3_1540
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_1565 
jump @R3_11 

:R3_1565
jump @R3_1443 

:R3_1572
00BA: show_text_styled GXT 'FIRE_M' time 6000 style 5  
wait 0" );
                start_mission<FIRETRU>();
                AppendLine( @"jump @R3_11 

:R3_1603
if or
   Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @R3_2269 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_1676 
if 
88FE:   not text_box_displayed 
else_jump @R3_1676 
03E5: show_text_box 'CTUTOR'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_1676
if 
   not " + _13 + @"== 3 
else_jump @R3_1985 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_1978 

:R3_1711
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_1863 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_1757 
jump @R3_11 

:R3_1757
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @R3_1780 
jump @R3_11 

:R3_1780
if and
   not Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @R3_1811 
jump @R3_11 

:R3_1811
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_1831 
jump @R3_11 

:R3_1831
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_1856 
jump @R3_11 

:R3_1856
jump @R3_1711 

:R3_1863
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @R3_1905 
00BA: show_text_styled GXT 'COP_M3' time 6000 style 5  
jump @R3_1963 

:R3_1905
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #CHEETAH)
else_jump @R3_1947 
00BA: show_text_styled GXT 'COP_M2' time 6000 style 5  
jump @R3_1963 

:R3_1947
00BA: show_text_styled GXT 'COP_M' time 6000 style 5  

:R3_1963
wait 0" );
                start_mission<COPCAR>();
                AppendLine( @"jump @R3_11 

:R3_1978
jump @R3_2269 

:R3_1985
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_2269 

:R3_2002
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_2154 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_2048 
jump @R3_11 

:R3_2048
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @R3_2071 
jump @R3_11 

:R3_2071
if and
   not Actor.DrivingPoliceVehicle(" + PlayerActor + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @R3_2102 
jump @R3_11 

:R3_2102
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_2122 
jump @R3_11 

:R3_2122
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_2147 
jump @R3_11 

:R3_2147
jump @R3_2002 

:R3_2154
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #HUNTER)
else_jump @R3_2196 
00BA: show_text_styled GXT 'COP_M3' time 6000 style 5  
jump @R3_2254 

:R3_2196
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #CHEETAH)
else_jump @R3_2238 
00BA: show_text_styled GXT 'COP_M2' time 6000 style 5  
jump @R3_2254 

:R3_2238
00BA: show_text_styled GXT 'COP_M' time 6000 style 5  

:R3_2254
wait 0" );
                start_mission<COPCAR>();
                AppendLine( @"jump @R3_11 

:R3_2269
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #BOXBURG)
else_jump @R3_2901 
if 
  " + ONMISSION_Burglary + @" == 0 
else_jump @R3_2901 
00BF: " + Time_Hours + @" = current_time_hours, " + Time_Mins + @" = current_time_minutes 
if or
  " + Time_Hours + @" >= 20 
  6 > " + Time_Hours + @" 
else_jump @R3_2388 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_2388 
if 
88FE:   not text_box_displayed 
else_jump @R3_2388 
03E5: show_text_box 'BTUTOR2'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_2388
if 
   not " + _13 + @"== 3 
else_jump @R3_2657 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_2650 
00BF: " + Time_Hours + @" = current_time_hours, " + Time_Mins + @" = current_time_minutes 
if or
  " + Time_Hours + @" >= 20 
  6 > " + Time_Hours + @" 
else_jump @R3_2634 

:R3_2456
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_2585 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_2502 
jump @R3_11 

:R3_2502
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #BOXBURG)
else_jump @R3_2533 
jump @R3_11 

:R3_2533
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_2553 
jump @R3_11 

:R3_2553
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_2578 
jump @R3_11 

:R3_2578
jump @R3_2456 

:R3_2585
0A2D: hide_styled_text_while_fading 0 
00BA: show_text_styled GXT 'BURGLAR' time 6000 style 5  
wait 0" );
                start_mission<BURGJB>();
                AppendLine( @"" + ONMISSION_Burglary + @" = 1 
jump @R3_11 
jump @R3_2650 

:R3_2634
00BC: show_text_highpriority GXT 'BURGHEL' time 1000 flag 1  

:R3_2650
jump @R3_2901 

:R3_2657
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_2901 
00BF: " + Time_Hours + @" = current_time_hours, " + Time_Mins + @" = current_time_minutes 
if or
  " + Time_Hours + @" >= 20 
  6 > " + Time_Hours + @" 
else_jump @R3_2885 

:R3_2707
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_2836 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_2753 
jump @R3_11 

:R3_2753
if or
   not Player.Defined(" + PlayerChar + @")
   not Actor.DrivingVehicleType(" + PlayerActor + @", #BOXBURG)
else_jump @R3_2784 
jump @R3_11 

:R3_2784
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_2804 
jump @R3_11 

:R3_2804
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_2829 
jump @R3_11 

:R3_2829
jump @R3_2707 

:R3_2836
0A2D: hide_styled_text_while_fading 0 
00BA: show_text_styled GXT 'BURGLAR' time 6000 style 5  
wait 0" );
                start_mission<BURGJB>();
                AppendLine( @"" + ONMISSION_Burglary + @" = 1 
jump @R3_11 
jump @R3_2901 

:R3_2885
00BC: show_text_highpriority GXT 'BURGHEL' time 1000 flag 1  

:R3_2901
if 
  " + STAT_Unlocked_Cities_Number + @" > 1 
else_jump @R3_3455 
if or
   Actor.DrivingVehicleType(" + PlayerActor + @", #FREIGHT)
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAK)
else_jump @R3_3455 
" + _63 + @" = Actor.CurrentCar(" + PlayerActor + @")
if and
82BF:   not car " + _63 + @" sunk 
8981:   not train " + _63 + @" wrecked 
else_jump @R3_3455 
if 
  " + _161 + @" == 0 
else_jump @R3_3455 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_3042 
if 
88FE:   not text_box_displayed 
else_jump @R3_3042 
03E5: show_text_box 'FTUTORA'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_3042
if 
   not " + _13 + @"== 3 
else_jump @R3_3261 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_3254 

:R3_3077
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_3232 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_3123 
jump @R3_11 

:R3_3123
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @R3_3146 
jump @R3_11 

:R3_3146
if and
   not Actor.DrivingVehicleType(" + PlayerActor + @", #FREIGHT)
   not Actor.DrivingVehicleType(" + PlayerActor + @", #STREAK)
else_jump @R3_3180 
jump @R3_11 

:R3_3180
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_3200 
jump @R3_11 

:R3_3200
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_3225 
jump @R3_11 

:R3_3225
jump @R3_3077 

:R3_3232
wait 0" );
                start_mission<FREIGHT>();
                AppendLine( @"" + _160 + @" = 1 
jump @R3_11 

:R3_3254
jump @R3_3455 

:R3_3261
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_3455 

:R3_3278
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_3433 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_3324 
jump @R3_11 

:R3_3324
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @R3_3347 
jump @R3_11 

:R3_3347
if and
   not Actor.DrivingVehicleType(" + PlayerActor + @", #FREIGHT)
   not Actor.DrivingVehicleType(" + PlayerActor + @", #STREAK)
else_jump @R3_3381 
jump @R3_11 

:R3_3381
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_3401 
jump @R3_11 

:R3_3401
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_3426 
jump @R3_11 

:R3_3426
jump @R3_3278 

:R3_3433
wait 0" );
                start_mission<FREIGHT>();
                AppendLine( @"" + _160 + @" = 1 
jump @R3_11 

:R3_3455
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #BROADWAY)
else_jump @R3_3994 
" + _63 + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
82BF:   not car " + _63 + @" sunk 
else_jump @R3_3994 
if 
  " + _162 + @" == 0 
else_jump @R3_3994 
if 
  " + Help_Toggle_OddJob_Shown + @" == 0 
else_jump @R3_3565 
if 
88FE:   not text_box_displayed 
else_jump @R3_3565 
03E5: show_text_box 'PTUTORA'  
" + Help_Toggle_OddJob_Shown + @" = 1 

:R3_3565
if 
   not " + _13 + @"== 3 
else_jump @R3_3792 
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_3785 

:R3_3600
if 
00E1:   player 0 pressed_key 19 
else_jump @R3_3747 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_3646 
jump @R3_11 

:R3_3646
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @R3_3669 
jump @R3_11 

:R3_3669
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #BROADWAY)
else_jump @R3_3695 
jump @R3_11 

:R3_3695
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_3715 
jump @R3_11 

:R3_3715
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_3740 
jump @R3_11 

:R3_3740
jump @R3_3600 

:R3_3747
00BA: show_text_styled GXT 'PIMP' time 6000 style 5  
wait 0" );
                start_mission<PIMP>();
                AppendLine( @"" + _159 + @" = 1 
jump @R3_11 

:R3_3785
jump @R3_3994 

:R3_3792
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_3994 

:R3_3809
if 
00E1:   player 0 pressed_key 14 
else_jump @R3_3956 
wait 0 
if 
  " + OnMission + @" == 1 
else_jump @R3_3855 
jump @R3_11 

:R3_3855
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @R3_3878 
jump @R3_11 

:R3_3878
if 
   not Actor.DrivingVehicleType(" + PlayerActor + @", #BROADWAY)
else_jump @R3_3904 
jump @R3_11 

:R3_3904
if 
09BE:   are_text_boxes_locked_to_any_thread 
else_jump @R3_3924 
jump @R3_11 

:R3_3924
if 
08B4:   test " + _390 + @" bit 1 
else_jump @R3_3949 
jump @R3_11 

:R3_3949
jump @R3_3809 

:R3_3956
00BA: show_text_styled GXT 'PIMP' time 6000 style 5  
wait 0" );
                start_mission<PIMP>();
                AppendLine( @"" + _159 + @" = 1 
jump @R3_11 

:R3_3994
jump @R3_4103 

:R3_4001
if 
  " + Help_Toggle_OddJob_Shown + @" == 1 
else_jump @R3_4103 
03D5: remove_text 'TTUTOR'  
03D5: remove_text 'ATUTOR'  
03D5: remove_text 'FTUTOR'  
03D5: remove_text 'CTUTOR'  
03D5: remove_text 'BTUTOR2'  
03D5: remove_text 'FTUTORA'  
03D5: remove_text 'PTUTORA'  
" + Help_Toggle_OddJob_Shown + @" = 0 

:R3_4103
jump @R3_11 

:R3_4110
wait 70 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @R3_4144 
wait 5000 
jump @R3_11 

:R3_4144
jump @R3_4110" );
            }

        }

    }

}