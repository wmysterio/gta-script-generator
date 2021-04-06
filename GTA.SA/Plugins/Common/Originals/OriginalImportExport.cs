using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalImportExport : Original {

        internal OriginalImportExport() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Int tmp_parked_IMPEXPM_cars;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Array<Car> StartCar = Script.global_array( 30 );
            tmp_parked_IMPEXPM_cars = Script.global( StartCar.startIndex );
            Script.CAR_PARK.init( StartCar[ 0 ], -1673.94, 439.02, 7.01, 136.0, 402, forceSpawn_bool: 1, alarm_byte: 70, doorLock_byte: 40 );
            Script.CAR_PARK.init( StartCar[ 1 ], 926.45, -1292.29, 13.6, 270.0, 405, forceSpawn_bool: 1, alarm_byte: 60, doorLock_byte: 30 );
            Script.CAR_PARK.init( StartCar[ 2 ], -2665.44, 990.77, 64.45, 51.0, 411, forceSpawn_bool: 1, alarm_byte: 80, doorLock_byte: 50 );
            Script.CAR_PARK.init( StartCar[ 3 ], -2516.598, 1228.919, 36.4283, 211.5, 483, forceSpawn_bool: 1, alarm_byte: 30, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 4 ], 1122.29, -1699.76, 13.43, 270.0, 445, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 5 ], -1006.41, -628.27, 32.0, 270.0, 470, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 6 ], -2085.23, -2437.52, 30.31, 142.0, 468, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 7 ], -1922.19, 288.34, 40.84, 180.0, 409, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 8 ], -16.66, -2521.17, 36.37, 210.0, 533, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 9 ], 1803.38, -1931.05, 13.66, 0.0, 534, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 10 ], 1272.24, 2603.03, 10.49, 117.0, 415, forceSpawn_bool: 1, alarm_byte: 90, doorLock_byte: 30 );
            Script.CAR_PARK.init( StartCar[ 11 ], -112.4, -41.82, 3.26, 160.0, 489, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 12 ], -2456.1, 741.65, 34.92, 180.0, 439, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 13 ], -1951.81, 2393.83, 50.08, 292.0, 514, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 14 ], -2751.79, -281.5, 6.81, 0.0, 480, forceSpawn_bool: 1, alarm_byte: 90, doorLock_byte: 40 );
            Script.CAR_PARK.init( StartCar[ 15 ], 1923.93, -2118.89, 13.35, 0.0, 535, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 16 ], -1675.94, -618.74, 13.86, 256.0, 496, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 17 ], -2430.22, 320.84, 34.97, 245.0, 580, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 18 ], -2265.33, 200.65, 34.97, 270.0, 475, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 19 ], 2282.7, 2535.88, 10.39, 180.0, 521, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 20 ], 2133.04, 1009.75, 10.49, 270.0, 429, forceSpawn_bool: 1, alarm_byte: 90, doorLock_byte: 50 );
            Script.CAR_PARK.init( StartCar[ 21 ], 2229.3, 1402.99, 10.82, 180.0, 506, forceSpawn_bool: 1, alarm_byte: 90, doorLock_byte: 50 );
            Script.CAR_PARK.init( StartCar[ 22 ], -1550.4, 2687.54, 56.22, 90.0, 508, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 23 ], -2068.69, -83.75, 35.1, 0.0, 579, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 24 ], 682.17, -1867.46, 4.82, 180.0, 424, forceSpawn_bool: 1, alarm_byte: 70, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 25 ], 1747.87, -2098.03, 13.28, 180.0, 536, forceSpawn_bool: 1, alarm_byte: 80, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 26 ], 1144.46, -1101.26, 25.35, 300.0, 463, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 27 ], -2406.25, -2180.84, 33.39, 180.0, 500, forceSpawn_bool: 1, alarm_byte: 70, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 28 ], 2163.79, 1810.23, 10.58, 180.0, 477, forceSpawn_bool: 1, alarm_byte: 80, doorLock_byte: 10 );
            Script.CAR_PARK.init( StartCar[ 29 ], 2207.43, 1286.13, 10.57, 180.0, 587, forceSpawn_bool: 1, alarm_byte: 50, doorLock_byte: 10 );
            for( ushort i = 0; i < 30; i++ )
                Script.AppendLine( $"014C: set_parked_car_generator {StartCar[ i ]} cars_to_generate_to 0 " );
            _1909.value = 1;
            Script.create_thread<IMPEXPM>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class IMPEXPM : Thread {

            Int tmp_WantedCrossOFF_Objects = global( WantedCrossOFF_Objects.startIndex ),
                tmp_Unlocked_Import_Cars = global( Unlocked_Import_Cars.startIndex ),
                tmp_Car_Models_To_Export = global( Car_Models_To_Export.startIndex ),
                tmp_Import_Car_Handles = global( Import_Car_Handles.startIndex ),
                tmp_Export_Cars_Status = global( Export_Cars_Status.startIndex ),
                tmp_Import_Car_Names = global( Import_Car_Names.startIndex ),
                tmp_Import_Cars_Model = global( Import_Cars_Model.startIndex ),
                tmp_Import_Days = global( Import_Days.startIndex ),
                tmp_1130 = global( _1130.startIndex ),
                tmp_1140 = global( _1140.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"if 
   not " + _1181 + @" == 99 
else_jump @IMPEXPM_484 
if 
  " + _1181 + @" == -1000 
else_jump @IMPEXPM_123 
27@ = Object.Init(#NF_BLACKBOARD, 0.0, 0.0, 0.0)
09E2: " + tmp_parked_IMPEXPM_cars + @"[0] = parked_car_generator_w_numberplate #EUROS colors -1 -1 force_spawn 1 alarm 50 door_lock 0 min_delay 0 max_delay 10000 plate ""IMPEXP__"" at 0.0 0.0 0.0 angle 180.0 

:IMPEXPM_123
if 
83CA:   not object 27@ exists 
else_jump @IMPEXPM_190 
27@ = Object.Init(#NF_BLACKBOARD, -1573.881, 135.3845, 2.535)
Object.Angle(27@) = 180.0
Object.KeepInMemory(27@) = True
Object.ToggleInMovingList(27@) = False
Object.RemoveFromMissionCleanupList(27@)

:IMPEXPM_190
" + Current_Wanted_List + @" = 0 
04AE: " + tmp_Unlocked_Import_Cars + @"[0] = 589 
04AE: " + tmp_Unlocked_Import_Cars + @"[1] = 404 
04AE: " + tmp_Unlocked_Import_Cars + @"[2] = 559 
04AE: " + tmp_Unlocked_Import_Cars + @"[3] = 589 
04AE: " + tmp_Unlocked_Import_Cars + @"[4] = 404 
04AE: " + tmp_Unlocked_Import_Cars + @"[5] = 559 
4@ = 6 

:IMPEXPM_252
if 
  42 > 4@ 
else_jump @IMPEXPM_295 
" + tmp_Unlocked_Import_Cars + @"(4@,42i) = -1 
4@ += 1 
jump @IMPEXPM_252 

:IMPEXPM_295
05A9: s" + tmp_Import_Days + @"[0] = 'IE16' 
05A9: s" + tmp_Import_Days + @"[1] = 'IE10' 
05A9: s" + tmp_Import_Days + @"[2] = 'IE11' 
05A9: s" + tmp_Import_Days + @"[3] = 'IE12' 
05A9: s" + tmp_Import_Days + @"[4] = 'IE13' 
05A9: s" + tmp_Import_Days + @"[5] = 'IE14' 
05A9: s" + tmp_Import_Days + @"[6] = 'IE15' 
" + Help_Import_Shown + @" = 1 
" + Import_New_Available_Cars_Number + @" = 0 
" + All_Cars_Collected_Flag + @" = 0 
" + Import_Price_Multiplier + @" = 0.8 
" + Export_Price_Multiplier + @" = 1.0 
" + tmp_Import_Car_Handles + @"[0] = -1 
" + tmp_Import_Car_Handles + @"[1] = -1 
" + tmp_Import_Car_Handles + @"[2] = -1 
" + tmp_Import_Car_Handles + @"[3] = -1 
" + tmp_Import_Car_Handles + @"[4] = -1" );
                create_thread<IMPEXPC>();
                AppendLine( @"" + _1181 + @" = 99 

:IMPEXPM_484
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_563 
if and
00EC:   actor " + PlayerActor + @" sphere 0 near_point -1574.881 135.3845 radius 150.0 150.0 
  " + _1909 + @" == 1 
else_jump @IMPEXPM_563 
15@ = 0 
jump @IMPEXPM_577 

:IMPEXPM_563
jump @IMPEXPM_484 
26@ = 0 

:IMPEXPM_577
if 
  " + _1909 + @" == 1 
else_jump @IMPEXPM_627 
if 
  " + _41 + @" == 1 
else_jump @IMPEXPM_627 
" + _41 + @" = 0 
" + _1146 + @" = 1 

:IMPEXPM_627
gosub @IMPEXPM_11671 
if 
  16@ == -1 
else_jump @IMPEXPM_875 
17@ = Car.Create(#PONY, 0.0, 0.0, 0.0)
20@ = Car.Create(#PONY, 0.0, 0.0, 0.0)
22@ = Car.Create(#PONY, 0.0, 0.0, 0.0)
27@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + tmp_WantedCrossOFF_Objects + @"[0] = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + tmp_1130 + @"[0] = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + tmp_1140 + @"[0] = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
24@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + Crane_Magnet + @" = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + Wanted_List_Object + @" = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)

:IMPEXPM_875
16@ = 0 
20@ = -1 
23@ = 0 
" + _1150 + @" = 0.0 
28@ = 0 
gosub @IMPEXPM_10052 
gosub @IMPEXPM_10709 
if 
  " + _1909 + @" == 1 
else_jump @IMPEXPM_1185 
if 
03CA:   object " + Wanted_List_Object + @" exists 
else_jump @IMPEXPM_966 
Object.Destroy(" + Wanted_List_Object + @")

:IMPEXPM_966
if 
  " + Current_Wanted_List + @" == 0 
else_jump @IMPEXPM_1039 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 27@ with_offset 0.0 0.0 0.0 
" + Wanted_List_Object + @" = Object.Init(#NF_LIST_1, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + Wanted_List_Object + @") = 180.0

:IMPEXPM_1039
if 
  " + Current_Wanted_List + @" == 1 
else_jump @IMPEXPM_1112 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 27@ with_offset 0.0 0.0 0.0 
" + Wanted_List_Object + @" = Object.Init(#NF_LIST_2, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + Wanted_List_Object + @") = 180.0

:IMPEXPM_1112
if 
  " + Current_Wanted_List + @" == 2 
else_jump @IMPEXPM_1185 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 27@ with_offset 0.0 0.0 0.0 
" + Wanted_List_Object + @" = Object.Init(#NF_LIST_3, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + Wanted_List_Object + @") = 180.0

:IMPEXPM_1185
gosub @IMPEXPM_11671 
if 
  " + _1909 + @" == 1 
else_jump @IMPEXPM_1559 
4@ = 0 

:IMPEXPM_1217
if 
  10 > 4@ 
else_jump @IMPEXPM_1559 
if 
03CA:   object " + tmp_WantedCrossOFF_Objects + @"(4@,10i) exists 
else_jump @IMPEXPM_1264 
Object.Destroy(" + tmp_WantedCrossOFF_Objects + @"(4@,10i))

:IMPEXPM_1264
" + tmp_WantedCrossOFF_Objects + @"(4@,10i) = -1 
if or
  " + OnMission + @" == 0 
  " + _1185 + @" == 1 
else_jump @IMPEXPM_1545 
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 1 
else_jump @IMPEXPM_1545 
if 
83CA:   not object " + tmp_WantedCrossOFF_Objects + @"(4@,10i) exists 
else_jump @IMPEXPM_1545 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 27@ with_offset 0.0 0.0 0.0 
0093: 12@ = integer 4@ to_float 
if 
  12@ > 4.0 
else_jump @IMPEXPM_1410 
12@ += -5.0 

:IMPEXPM_1410
0087: 13@ = 12@ 
13@ *= -0.05 
12@ *= -0.2355 
005B: 12@ += 13@ 
005F: " + tempvar_Float_3 + @" += 12@ 
if 
  5 > 4@ 
else_jump @IMPEXPM_1482 
" + tempvar_Float_1 + @" += 1.741 

:IMPEXPM_1482
12@ *= -0.1 
005F: " + tempvar_Float_3 + @" += 12@ 
" + tmp_WantedCrossOFF_Objects + @"(4@,10i) = Object.Init(#WANTED_CROSS_OFF, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.KeepInMemory(" + tmp_WantedCrossOFF_Objects + @"(4@,10i)) = True
Object.Angle(" + tmp_WantedCrossOFF_Objects + @"(4@,10i)) = 180.0

:IMPEXPM_1545
4@ += 1 
jump @IMPEXPM_1217 

:IMPEXPM_1559
wait 0 
if 
  " + _1909 + @" == 0 
else_jump @IMPEXPM_1588 
jump @IMPEXPM_1559 

:IMPEXPM_1588
if 
  26@ == 1 
else_jump @IMPEXPM_1730 
if 
056E:   car 22@ defined 
else_jump @IMPEXPM_1730 
if 
   not Car.Wrecked(22@)
else_jump @IMPEXPM_1680 
Car.LockInCurrentPosition(22@) = True
if 
82CA:   not car 22@ bounding_sphere_visible 
else_jump @IMPEXPM_1673 
Car.Destroy(22@)
26@ = 0 

:IMPEXPM_1673
jump @IMPEXPM_1692 

:IMPEXPM_1680
Car.Destroy(22@)
26@ = 0 

:IMPEXPM_1692
0798: get_crane_magnet " + Crane_Magnet + @" attached_car_handle_to 17@ attached_actor_handle_to 18@ attached_object_handle_to 19@ 
if 
003B:   17@ == 22@ 
else_jump @IMPEXPM_1730 
0799: set_crane_magnet " + Crane_Magnet + @" release_stuff_from_magnet 

:IMPEXPM_1730
if and
   not " + Import_New_Available_Cars_Number + @" == 0 
  33@ > 5000 
else_jump @IMPEXPM_1836 
if and
876F:   not text_priority_displayed 
88FE:   not text_box_displayed 
else_jump @IMPEXPM_1836 
if 
  " + Import_New_Available_Cars_Number + @" == 1 
else_jump @IMPEXPM_1800 
03E5: show_text_box 'IE25'  

:IMPEXPM_1800
if 
  " + Import_New_Available_Cars_Number + @" == 2 
else_jump @IMPEXPM_1829 
03E5: show_text_box 'IE26'  

:IMPEXPM_1829
" + Import_New_Available_Cars_Number + @" = 0 

:IMPEXPM_1836
if 
  " + Help_Import_Shown + @" == 0 
else_jump @IMPEXPM_1941 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_1941 
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point -1574.881 135.3845 radius 40.0 40.0 
else_jump @IMPEXPM_1941 
if and
876F:   not text_priority_displayed 
88FE:   not text_box_displayed 
else_jump @IMPEXPM_1941 
03E5: show_text_box 'IE27'  
" + Help_Import_Shown + @" += 1 

:IMPEXPM_1941
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_7119 
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point -1574.881 135.3845 radius 150.0 150.0 
else_jump @IMPEXPM_7105 
if 
  15@ == 0 
else_jump @IMPEXPM_4301 
if 
  " + All_Cars_Collected_Flag + @" == 0 
else_jump @IMPEXPM_4027 
if 
  16@ == 0 
else_jump @IMPEXPM_2826 
gosub @IMPEXPM_10632 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_2120 
if 
00FE:   actor " + PlayerActor + @" sphere 1 in_sphere -1577.942 52.6333 16.3281 radius 4.0 4.0 6.0 
else_jump @IMPEXPM_2120 

:IMPEXPM_2120
073E: get_car_in_sphere -1577.942 52.6333 16.3281 radius 4.0 model #INFO handle_as " + tempvar_Actor_Car + @" 
if 
056E:   car " + tempvar_Actor_Car + @" defined 
else_jump @IMPEXPM_2533 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @IMPEXPM_2533 
if 
01C1:   car " + tempvar_Actor_Car + @" stopped 
else_jump @IMPEXPM_2533 
if 
81F3:   not car " + tempvar_Actor_Car + @" in_air 
else_jump @IMPEXPM_2533 
if 
803C:   not  " + tempvar_Actor_Car + @" == 17@ 
else_jump @IMPEXPM_2533 
6@ = Car.Model(" + tempvar_Actor_Car + @")
4@ = 0 
5@ = 0 

:IMPEXPM_2252
if 
  10 > 4@ 
else_jump @IMPEXPM_2343 
if 
003C:   " + tmp_Car_Models_To_Export + @"(4@,10i) == 6@ 
else_jump @IMPEXPM_2329 
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 0 
else_jump @IMPEXPM_2329 
5@ = 1 
4@ = 10 

:IMPEXPM_2329
4@ += 1 
jump @IMPEXPM_2252 

:IMPEXPM_2343
if 
  5@ == 1 
else_jump @IMPEXPM_2504 
008B: 22@ = " + tempvar_Actor_Car + @" 
if 
0431:   car " + tempvar_Actor_Car + @" passenger_seat_free 0 
else_jump @IMPEXPM_2431 
0376: 18@ = create_random_actor_at -1576.88 55.26 8.57 
0430: put_actor 18@ into_car " + tempvar_Actor_Car + @" passenger_seat 0 
0337: set_actor 18@ visibility 0 
jump @IMPEXPM_2483 

:IMPEXPM_2431
0432: 18@ = get_actor_handle_from_car " + tempvar_Actor_Car + @" passenger_seat 0 
Actor.DestroyInstantly(18@)
0376: 18@ = create_random_actor_at -1576.88 55.26 8.57 
0430: put_actor 18@ into_car " + tempvar_Actor_Car + @" passenger_seat 0 
0337: set_actor 18@ visibility 0 

:IMPEXPM_2483
16@ += 1 
32@ = 0 
jump @IMPEXPM_2533 

:IMPEXPM_2504
if 
876F:   not text_priority_displayed 
else_jump @IMPEXPM_2533 
00BB: show_text_lowpriority GXT 'IE23' time 3000 flag 1  

:IMPEXPM_2533
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_2826 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @IMPEXPM_2826 
if 
0103:   actor " + PlayerActor + @" in_sphere -1577.942 52.6333 16.3281 radius 4.0 4.0 6.0 sphere 0 stopped_in_car 
else_jump @IMPEXPM_2826 
" + tempvar_Actor_Car + @" = Actor.CurrentCar(" + PlayerActor + @")
6@ = Car.Model(" + tempvar_Actor_Car + @")
4@ = 0 
5@ = 0 

:IMPEXPM_2643
if 
  10 > 4@ 
else_jump @IMPEXPM_2734 
if 
003C:   " + tmp_Car_Models_To_Export + @"(4@,10i) == 6@ 
else_jump @IMPEXPM_2720 
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 0 
else_jump @IMPEXPM_2720 
5@ = 1 
4@ = 10 

:IMPEXPM_2720
4@ += 1 
jump @IMPEXPM_2643 

:IMPEXPM_2734
if 
  5@ == 1 
else_jump @IMPEXPM_2797 
008B: 22@ = " + tempvar_Actor_Car + @" 
if 
   not Car.Wrecked(22@)
else_jump @IMPEXPM_2776 

:IMPEXPM_2776
16@ += 1 
32@ = 0 
jump @IMPEXPM_2826 

:IMPEXPM_2797
if 
876F:   not text_priority_displayed 
else_jump @IMPEXPM_2826 
00BB: show_text_lowpriority GXT 'IE23' time 3000 flag 1  

:IMPEXPM_2826
if 
  16@ == 1 
else_jump @IMPEXPM_3536 
if 
03CA:   object " + Crane_Magnet + @" exists 
else_jump @IMPEXPM_2870 
0797: set_crane_magnet " + Crane_Magnet + @" magnet_lane_length_to 0.7 

:IMPEXPM_2870
" + _1912 + @" = 1 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_2900 
Player.CanMove(" + PlayerChar + @") = False

:IMPEXPM_2900
fade 0 250 

:IMPEXPM_2907
if 
fading 
else_jump @IMPEXPM_2931 
wait 0 
jump @IMPEXPM_2907 

:IMPEXPM_2931
if 
056E:   car 22@ defined 
else_jump @IMPEXPM_3046 
if 
   not Car.Wrecked(22@)
else_jump @IMPEXPM_3046 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_2993 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:IMPEXPM_2993
Car.PutAt(22@, -1577.942, 52.6333, 40.0)
Car.LockInCurrentPosition(22@) = True
4@ = Car.Health(22@)
0091: " + Export_Price_Health_Multiplier + @" = integer 4@ to_float 
" + Export_Price_Health_Multiplier + @" /= 1000.0 

:IMPEXPM_3046
02A3: enable_widescreen 1 
Camera.SetPosition(-1573.419, 53.4591, 17.9655, 0.0, 0.0, 0.0)
Camera.PointAt(-1574.344, 53.0835, 17.9027, 2)
0395: clear_area 1 at -1577.942 52.6333 16.3281 radius 9.0 
wait 0 
if 
   not Car.Wrecked(22@)
else_jump @IMPEXPM_3325 
4@ = Car.Model(22@)
07E4: get_model 4@ dimensions_cornerA_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" dimensions_cornerB_to 7@ 8@ 9@ 
0087: 12@ = 8@ 
0065: 12@ -= " + tempvar_Float_2 + @" 
12@ /= 2.0 
12@ *= -1.0 
02F6: 14@ = sine 45.0 
02F7: 13@ = cosine 45.0 
006B: 13@ *= 12@ 
006B: 14@ *= 12@ 
" + tempvar_Float_1 + @" = -1577.942 
005F: " + tempvar_Float_1 + @" += 14@ 
" + tempvar_Float_2 + @" = 52.6333 
005F: " + tempvar_Float_2 + @" += 13@ 
" + tempvar_Float_3 + @" = 16.3281 
Car.LockInCurrentPosition(22@) = False
Car.PutAt(22@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Car.Angle(22@) = 315.0

:IMPEXPM_3325
fade 1 250 

:IMPEXPM_3332
if 
fading 
else_jump @IMPEXPM_3356 
wait 0 
jump @IMPEXPM_3332 

:IMPEXPM_3356
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_3482 
if 
   not Car.Wrecked(22@)
else_jump @IMPEXPM_3482 
if 
   Actor.InCar(" + PlayerActor + @", 22@)
else_jump @IMPEXPM_3475 
31@ = 1 
0615: define_AS_pack_begin 30@ 
05CD: AS_actor -1 exit_car 22@ 
05D3: AS_actor -1 goto_point -1578.164 63.7954 16.3281 mode 4 time 10000 ms 
0616: define_AS_pack_end 30@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 30@ 
061B: remove_references_to_AS_pack 30@ 
jump @IMPEXPM_3482 

:IMPEXPM_3475
31@ = 0 

:IMPEXPM_3482
00BC: show_text_highpriority GXT 'IE24' time 5000 flag 1  
if 
00E1:   player 0 pressed_key 16 
else_jump @IMPEXPM_3522 
1@ = 1 

:IMPEXPM_3522
32@ = 0 
16@ += 1 

:IMPEXPM_3536
if 
  16@ == 2 
else_jump @IMPEXPM_3646 
if or
  32@ > 5000 
00E1:   player 0 pressed_key 16 
else_jump @IMPEXPM_3604 
if 
  1@ == 0 
else_jump @IMPEXPM_3604 
16@ += 1 

:IMPEXPM_3604
if 
  1@ == 1 
else_jump @IMPEXPM_3646 
if 
80E1:   not player 0 pressed_key 16 
else_jump @IMPEXPM_3646 
1@ = 0 

:IMPEXPM_3646
if 
  16@ == 3 
else_jump @IMPEXPM_4027 
fade 0 500 

:IMPEXPM_3671
if 
fading 
else_jump @IMPEXPM_3695 
wait 0 
jump @IMPEXPM_3671 

:IMPEXPM_3695
if 
   not 31@ == 0 
else_jump @IMPEXPM_3764 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_3764 
0792: disembark_instantly_actor " + PlayerActor + @" 
Actor.PutAt(" + PlayerActor + @", -1578.164, 63.7954, 16.3281)
Actor.Angle(" + PlayerActor + @") = 0.8

:IMPEXPM_3764
gosub @IMPEXPM_9397 
Car.Destroy(22@)
if 
056D:   actor 18@ defined 
else_jump @IMPEXPM_3797 
Actor.DestroyInstantly(18@)

:IMPEXPM_3797
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
" + _1912 + @" = 0 
if 
  " + flag_Player_In_Crane + @" == 2 
else_jump @IMPEXPM_3837 
" + _1911 + @" = 1 

:IMPEXPM_3837
fade 1 500 

:IMPEXPM_3844
if 
fading 
else_jump @IMPEXPM_3868 
wait 0 
jump @IMPEXPM_3844 

:IMPEXPM_3868
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_3891 
Player.CanMove(" + PlayerChar + @") = True

:IMPEXPM_3891
if 
  " + All_Cars_Collected_Flag + @" == 1 
else_jump @IMPEXPM_3950 
00BA: show_text_styled GXT 'IE29' time 5000 style 1  
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
wait 5000 

:IMPEXPM_3950
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_3974 
Player.Money(" + PlayerChar + @") += 29@

:IMPEXPM_3974
01E3: show_text_1number_styled GXT 'IE30' number 29@ time 5000 style 1  
097A: play_audio_at -1000.0 -1000.0 -1000.0 event 1058 
33@ = 0 
jump @IMPEXPM_577 

:IMPEXPM_4027
if 
03CA:   object 27@ exists 
else_jump @IMPEXPM_4301 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 27@ with_offset 0.0 1.5 0.0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_4301 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 2.0 1.0 2.0 on_foot 
else_jump @IMPEXPM_4267 
if 
   not 23@ == 1 
else_jump @IMPEXPM_4166 
03E5: show_text_box 'IE18'  
23@ = 1 

:IMPEXPM_4166
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 0 
if 
  0@ == 0 
else_jump @IMPEXPM_4236 
if 
00E1:   player 0 pressed_key 15 
else_jump @IMPEXPM_4229 
0@ = 1 
15@ = 1 
jump @IMPEXPM_577 

:IMPEXPM_4229
jump @IMPEXPM_4260 

:IMPEXPM_4236
if 
80E1:   not player 0 pressed_key 15 
else_jump @IMPEXPM_4260 
0@ = 0 

:IMPEXPM_4260
jump @IMPEXPM_4301 

:IMPEXPM_4267
if 
  23@ == 1 
else_jump @IMPEXPM_4294 
03E6: remove_text_box 
23@ = 0 

:IMPEXPM_4294
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:IMPEXPM_4301
if 
  15@ == 1 
else_jump @IMPEXPM_7098 

:IMPEXPM_4319
if 
  16@ == 0 
else_jump @IMPEXPM_4596 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_4360 
Player.CanMove(" + PlayerChar + @") = False

:IMPEXPM_4360
0512: show_permanent_text_box 'IE20'  
0581: enable_radar 0 
08D4: " + _1153 + @" = create_panel_with_title 'IE09' position 29.0 170.0 width 180.0 columns 1 interactive 1 background 1 alignment 0  
08DB: set_panel " + _1153 + @" column 0 header 'DUMMY' data 'IE16' 'IE10' 'IE11' 'IE12' 'IE13' 'IE14' 'IE15' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
if 
  4@ == -69 
else_jump @IMPEXPM_4569 
090E: set_panel " + _1153 + @" active_row " + _1148 + @" 
jump @IMPEXPM_4589 

:IMPEXPM_4569
07D0: 4@ = weekday 
4@ += -1 
090E: set_panel " + _1153 + @" active_row 4@ 

:IMPEXPM_4589
16@ += 1 

:IMPEXPM_4596
if 
  16@ == 1 
else_jump @IMPEXPM_4870 
if 
  1@ == 0 
else_jump @IMPEXPM_4689 
if 
00E1:   player 0 pressed_key 16 
else_jump @IMPEXPM_4682 
08D7: " + _1148 + @" = panel " + _1153 + @" active_row 
16@ += 1 
1@ = 1 
03D5: remove_text 'IE28'  

:IMPEXPM_4682
jump @IMPEXPM_4713 

:IMPEXPM_4689
if 
80E1:   not player 0 pressed_key 16 
else_jump @IMPEXPM_4713 
1@ = 0 

:IMPEXPM_4713
if 
  0@ == 0 
else_jump @IMPEXPM_4812 
if 
00E1:   player 0 pressed_key 15 
else_jump @IMPEXPM_4805 
gosub @IMPEXPM_9031 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_4778 
Player.CanMove(" + PlayerChar + @") = True

:IMPEXPM_4778
0581: enable_radar 1 
03E6: remove_text_box 
15@ = 0 
16@ = 0 
0@ = 1 

:IMPEXPM_4805
jump @IMPEXPM_4836 

:IMPEXPM_4812
if 
80E1:   not player 0 pressed_key 15 
else_jump @IMPEXPM_4836 
0@ = 0 

:IMPEXPM_4836
if or
00E1:   player 0 pressed_key 8 
00E1:   player 0 pressed_key 9 
else_jump @IMPEXPM_4870 
03D5: remove_text 'IE28'  

:IMPEXPM_4870
if 
  16@ == 2 
else_jump @IMPEXPM_5558 
0084: " + _1194 + @" = " + _1148 + @" 
gosub @IMPEXPM_10709 
4@ = 0 
5@ = 0 

:IMPEXPM_4917
if 
  6 > 4@ 
else_jump @IMPEXPM_4985 
if 
   not " + tmp_Import_Cars_Model + @"(4@,6i) == -1 
else_jump @IMPEXPM_4971 
5@ = 1 
4@ = 6 

:IMPEXPM_4971
4@ += 1 
jump @IMPEXPM_4917 

:IMPEXPM_4985
if 
  5@ == 0 
else_jump @IMPEXPM_5040 
00BC: show_text_highpriority GXT 'IE28' time 5000 flag 1  
16@ = 1 
jump @IMPEXPM_4319 
jump @IMPEXPM_5558 

:IMPEXPM_5040
0512: show_permanent_text_box 'IE21'  
08DA: remove_panel " + _1153 + @" 
08D4: " + Import_Car_Panel + @" = create_panel_with_title 'IE09' position 29.0 170.0 width 180.0 columns 2 interactive 1 background 1 alignment 0  
4@ = 0 

:IMPEXPM_5100
if 
  6 > 4@ 
else_jump @IMPEXPM_5206 
008B: 6@ = " + tmp_Import_Cars_Model + @"(4@,6i) 
if 
   not 6@ == -1 
else_jump @IMPEXPM_5174 
gosub @IMPEXPM_11862 
05A9: " + tmp_Import_Car_Names + @"(4@,6s) = " + Import_Model_Name + @" 
jump @IMPEXPM_5192 

:IMPEXPM_5174
05A9: " + tmp_Import_Car_Names + @"(4@,6s) = 'DUMMY' 

:IMPEXPM_5192
4@ += 1 
jump @IMPEXPM_5100 

:IMPEXPM_5206
008B: 4@ = " + _1148 + @" 
08DB: set_panel " + Import_Car_Panel + @" column 0 header " + tmp_Import_Days + @"(4@,7s) data s" + tmp_Import_Car_Names + @"[0] s" + tmp_Import_Car_Names + @"[1] s" + tmp_Import_Car_Names + @"[2] s" + tmp_Import_Car_Names + @"[3] s" + tmp_Import_Car_Names + @"[4] s" + tmp_Import_Car_Names + @"[5] 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 
08DB: set_panel " + Import_Car_Panel + @" column 1 header 'COST' data 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY' 'DUMMY'  
4@ = 0 

:IMPEXPM_5431
if 
  6 > 4@ 
else_jump @IMPEXPM_5551 
008B: 6@ = " + tmp_Import_Cars_Model + @"(4@,6i) 
if 
   not 6@ == -1 
else_jump @IMPEXPM_5537 
09E1: get_car_model " + tmp_Import_Cars_Model + @"(4@,6i) price_to " + Import_Car_Price + @" 
008F: 12@ = integer " + Import_Car_Price + @" to_float 
006F: 12@ *= " + Import_Price_Multiplier + @" 
0090: " + Import_Car_Price + @" = float 12@ to_integer 
08EE: set_panel " + Import_Car_Panel + @" column 1 row 4@ text_1number GXT 'DOLLAR' number " + Import_Car_Price + @"  

:IMPEXPM_5537
4@ += 1 
jump @IMPEXPM_5431 

:IMPEXPM_5551
16@ += 1 

:IMPEXPM_5558
if 
  16@ == 3 
else_jump @IMPEXPM_5765 
if 
  1@ == 0 
else_jump @IMPEXPM_5640 
if 
00E1:   player 0 pressed_key 16 
else_jump @IMPEXPM_5633 
08D7: " + Import_Panel_Row + @" = panel " + Import_Car_Panel + @" active_row 
16@ += 1 
1@ = 1 

:IMPEXPM_5633
jump @IMPEXPM_5664 

:IMPEXPM_5640
if 
80E1:   not player 0 pressed_key 16 
else_jump @IMPEXPM_5664 
1@ = 0 

:IMPEXPM_5664
if 
  0@ == 0 
else_jump @IMPEXPM_5741 
if 
00E1:   player 0 pressed_key 15 
else_jump @IMPEXPM_5734 
gosub @IMPEXPM_9031 
16@ = 0 
0@ = 1 
4@ = -69 
jump @IMPEXPM_4319 

:IMPEXPM_5734
jump @IMPEXPM_5765 

:IMPEXPM_5741
if 
80E1:   not player 0 pressed_key 15 
else_jump @IMPEXPM_5765 
0@ = 0 

:IMPEXPM_5765
if 
  16@ == 4 
else_jump @IMPEXPM_6075 
07D0: 4@ = weekday 
4@ += -1 
if 
87D6:   not  4@ == " + _1148 + @" 
else_jump @IMPEXPM_5844 
00BC: show_text_highpriority GXT 'IE19' time 5000 flag 1  
gosub @IMPEXPM_9031 
16@ = 0 

:IMPEXPM_5844
09E1: get_car_model " + tmp_Import_Cars_Model + @"(25@,6i) price_to " + Import_Car_Price + @" 
008F: 12@ = integer " + Import_Car_Price + @" to_float 
006F: 12@ *= " + Import_Price_Multiplier + @" 
0090: " + Import_Car_Price + @" = float 12@ to_integer 
4@ = Player.Money(" + PlayerChar + @")
if 
001E:   " + Import_Car_Price + @" > 4@ 
else_jump @IMPEXPM_5937 
00BC: show_text_highpriority GXT 'IE07' time 5000 flag 1  
gosub @IMPEXPM_9031 
16@ = 0 

:IMPEXPM_5937
if 
   not 16@ == 0 
else_jump @IMPEXPM_5991 
if 
  " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) == -1 
else_jump @IMPEXPM_5991 
gosub @IMPEXPM_9031 
16@ = 0 

:IMPEXPM_5991
if 
   not 16@ == 0 
else_jump @IMPEXPM_6075 
09E1: get_car_model " + tmp_Import_Cars_Model + @"(25@,6i) price_to " + Import_Car_Price + @" 
008F: 12@ = integer " + Import_Car_Price + @" to_float 
006F: 12@ *= " + Import_Price_Multiplier + @" 
0090: " + Import_Car_Price + @" = float 12@ to_integer 
008B: 4@ = " + Import_Car_Price + @" 
4@ *= -1 
Player.Money(" + PlayerChar + @") += 4@
16@ += 1 

:IMPEXPM_6075
if 
  16@ == 5 
else_jump @IMPEXPM_6548 
if 
   not Model.Available(" + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i))
else_jump @IMPEXPM_6153 
Model.Load(" + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i))

:IMPEXPM_6122
if 
   not Model.Available(" + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i))
else_jump @IMPEXPM_6153 
wait 0 
jump @IMPEXPM_6122 

:IMPEXPM_6153
03E6: remove_text_box 
gosub @IMPEXPM_9031 
0395: clear_area 1 at -1572.168 63.2853 16.3281 radius 20.0 
gosub @IMPEXPM_13111 
" + Import_Car + @" = Car.Create(" + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i), -1572.168, 63.2853, 16.3281)
0878: set_car " + Import_Car + @" dirt_level 0.0 
Car.Angle(" + Import_Car + @") = 315.0
Model.Destroy(" + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i))
if 
04A3:   " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) == 589 
else_jump @IMPEXPM_6281 
0229: set_car " + Import_Car + @" primary_color_to 11 secondary_color_to 0 

:IMPEXPM_6281
4@ = Car.Model(" + Import_Car + @")
07E4: get_model 4@ dimensions_cornerA_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" dimensions_cornerB_to 7@ 8@ 9@ 
0087: 12@ = 8@ 
0065: 12@ -= " + tempvar_Float_2 + @" 
12@ /= 2.0 
12@ *= -1.0 
02F7: 13@ = cosine 45.0 
02F6: 14@ = sine 45.0 
006B: 13@ *= 12@ 
006B: 14@ *= 12@ 
" + tempvar_Float_1 + @" = -1572.168 
005F: " + tempvar_Float_1 + @" += 14@ 
" + tempvar_Float_2 + @" = 63.2853 
005F: " + tempvar_Float_2 + @" += 13@ 
" + tempvar_Float_3 + @" = 16.3281 
Car.PutAt(" + Import_Car + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Car.Angle(" + Import_Car + @") = 315.0
00BE: text_clear_all 
02A3: enable_widescreen 1 
Camera.SetPosition(-1567.597, 63.2567, 17.7586, 0.0, 0.0, 0.0)
Camera.PointAt(-1568.576, 63.0585, 17.7094, 2)
00BC: show_text_highpriority GXT 'IE08' time 5000 flag 1  
0623: add 1 to_integer_stat 214 
32@ = 0 
16@ += 1 

:IMPEXPM_6548
if 
  16@ == 6 
else_jump @IMPEXPM_6672 
if 
  32@ > 5000 
else_jump @IMPEXPM_6599 
16@ += 1 
jump @IMPEXPM_6672 

:IMPEXPM_6599
if 
  1@ == 0 
else_jump @IMPEXPM_6648 
if 
00E1:   player 0 pressed_key 16 
else_jump @IMPEXPM_6641 
16@ += 1 

:IMPEXPM_6641
jump @IMPEXPM_6672 

:IMPEXPM_6648
if 
80E1:   not player 0 pressed_key 16 
else_jump @IMPEXPM_6672 
1@ = 0 

:IMPEXPM_6672
if 
  16@ == 7 
else_jump @IMPEXPM_6743 
00BE: text_clear_all 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_6723 
Player.CanMove(" + PlayerChar + @") = True

:IMPEXPM_6723
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
0581: enable_radar 1 
03E6: remove_text_box 
16@ += 1 

:IMPEXPM_6743
if 
  16@ == 8 
else_jump @IMPEXPM_7098 
if 
   not Car.Wrecked(" + Import_Car + @")
else_jump @IMPEXPM_6880 
if and
81AF:   not car " + Import_Car + @" sphere 0 in_sphere -1572.168 63.2853 16.3281 radius 30.0 30.0 5.0 
80C2:   not sphere_onscreen -1572.168 63.2853 16.3281 radius 5.0 
else_jump @IMPEXPM_6873 
Car.RemoveReferences(" + Import_Car + @")
15@ = 0 
16@ = 0 
jump @IMPEXPM_577 

:IMPEXPM_6873
jump @IMPEXPM_6906 

:IMPEXPM_6880
Car.RemoveReferences(" + Import_Car + @")
15@ = 0 
16@ = 0 
jump @IMPEXPM_577 

:IMPEXPM_6906
if 
03CA:   object 27@ exists 
else_jump @IMPEXPM_7098 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 27@ with_offset 0.0 1.5 0.0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_7098 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 2.0 1.0 2.0 on_foot 
else_jump @IMPEXPM_7098 
if 
  0@ == 0 
else_jump @IMPEXPM_7074 
if 
00E1:   player 0 pressed_key 15 
else_jump @IMPEXPM_7067 
0@ = 1 
00BC: show_text_highpriority GXT 'IE08' time 5000 flag 1  

:IMPEXPM_7067
jump @IMPEXPM_7098 

:IMPEXPM_7074
if 
80E1:   not player 0 pressed_key 15 
else_jump @IMPEXPM_7098 
0@ = 0 

:IMPEXPM_7098
jump @IMPEXPM_7112 

:IMPEXPM_7105
jump @IMPEXPM_9043 

:IMPEXPM_7112
jump @IMPEXPM_7126 

:IMPEXPM_7119
jump @IMPEXPM_9043 

:IMPEXPM_7126
if 
0736:   is_keyboard_key_just_pressed 85 
else_jump @IMPEXPM_7235 
4@ = 0 

:IMPEXPM_7148
if 
  10 > 4@ 
else_jump @IMPEXPM_7221 
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 0 
else_jump @IMPEXPM_7207 
008B: 6@ = " + tmp_Car_Models_To_Export + @"(4@,10i) 
4@ = 10 

:IMPEXPM_7207
4@ += 1 
jump @IMPEXPM_7148 

:IMPEXPM_7221
gosub @IMPEXPM_9397 
jump @IMPEXPM_577 

:IMPEXPM_7235
if 
0736:   is_keyboard_key_just_pressed 84 
else_jump @IMPEXPM_9024 
03A9: save_newline_to_debug_file 
03A9: save_newline_to_debug_file 
05B6: 1 
03A7: save_int_to_debug_file " + Current_Wanted_List + @" 
03A9: save_newline_to_debug_file 
05B6: 2 
03A9: save_newline_to_debug_file 
4@ = 0 

:IMPEXPM_7530
if 
  10 > 4@ 
else_jump @IMPEXPM_8120 
03A7: save_int_to_debug_file " + tmp_Car_Models_To_Export + @"(4@,10i) 
05B6: 3 
03A7: save_int_to_debug_file " + tmp_Export_Cars_Status + @"(4@,10i) 
05B6: 4 
05B6: 5 
03A7: save_int_to_debug_file " + tmp_1130 + @"(4@,10i) 
05B6: 6 
03A7: save_int_to_debug_file " + tmp_WantedCrossOFF_Objects + @"(4@,10i) 
03A9: save_newline_to_debug_file 
4@ += 1 
jump @IMPEXPM_7530 

:IMPEXPM_8120
03A9: save_newline_to_debug_file 
05B6: 7 
03A9: save_newline_to_debug_file 
05B6: 8 
03A9: save_newline_to_debug_file 
4@ = 0 

:IMPEXPM_8393
if 
  6 > 4@ 
else_jump @IMPEXPM_8575 
03A7: save_int_to_debug_file " + tmp_Import_Cars_Model + @"(4@,6i) 
05B6: 9 
03A7: save_int_to_debug_file " + tmp_1140 + @"(4@,6i) 
03A9: save_newline_to_debug_file 
4@ += 1 
jump @IMPEXPM_8393 

:IMPEXPM_8575
03A9: save_newline_to_debug_file 
05B6: 10 
03A9: save_newline_to_debug_file 
4@ = 0 

:IMPEXPM_8716
if 
  42 > 4@ 
else_jump @IMPEXPM_9024 
05B6: 11 
03A7: save_int_to_debug_file 4@ 
05B6: 12 
03A7: save_int_to_debug_file " + tmp_Unlocked_Import_Cars + @"(4@,42i) 
03A9: save_newline_to_debug_file 
4@ += 1 
jump @IMPEXPM_8716 

:IMPEXPM_9024
jump @IMPEXPM_1559 

:IMPEXPM_9031
08DA: remove_panel " + _1153 + @" 
08DA: remove_panel " + Import_Car_Panel + @" 
return 

:IMPEXPM_9043
if 
056E:   car 22@ defined 
else_jump @IMPEXPM_9113 
if 
03CA:   object " + Crane_Magnet + @" exists 
else_jump @IMPEXPM_9113 
0798: get_crane_magnet " + Crane_Magnet + @" attached_car_handle_to 17@ attached_actor_handle_to 18@ attached_object_handle_to 19@ 
if 
803B:   not  17@ == 22@ 
else_jump @IMPEXPM_9113 
Car.RemoveReferences(22@)

:IMPEXPM_9113
if 
056E:   car " + Import_Car + @" defined 
else_jump @IMPEXPM_9183 
if 
03CA:   object " + Crane_Magnet + @" exists 
else_jump @IMPEXPM_9183 
0798: get_crane_magnet " + Crane_Magnet + @" attached_car_handle_to 17@ attached_actor_handle_to 18@ attached_object_handle_to 19@ 
if 
87D6:   not  17@ == " + Import_Car + @" 
else_jump @IMPEXPM_9183 
Car.RemoveReferences(" + Import_Car + @")

:IMPEXPM_9183
if 
056D:   actor 18@ defined 
else_jump @IMPEXPM_9204 
Actor.DestroyInstantly(18@)

:IMPEXPM_9204
if 
03CA:   object 24@ exists 
else_jump @IMPEXPM_9225 
Object.Destroy(24@)

:IMPEXPM_9225
4@ = 0 

:IMPEXPM_9232
if 
  10 > 4@ 
else_jump @IMPEXPM_9293 
if 
03CA:   object " + tmp_WantedCrossOFF_Objects + @"(4@,10i) exists 
else_jump @IMPEXPM_9279 
Object.Destroy(" + tmp_WantedCrossOFF_Objects + @"(4@,10i))

:IMPEXPM_9279
4@ += 1 
jump @IMPEXPM_9232 

:IMPEXPM_9293
if 
03CA:   object " + Wanted_List_Object + @" exists 
else_jump @IMPEXPM_9314 
Object.Destroy(" + Wanted_List_Object + @")

:IMPEXPM_9314
if 
  " + _1146 + @" == 1 
else_jump @IMPEXPM_9339 
" + _41 + @" = 1 

:IMPEXPM_9339
jump @IMPEXPM_484 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_9376 
Player.CanMove(" + PlayerChar + @") = True
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:IMPEXPM_9376
02A3: enable_widescreen 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
00BE: text_clear_all 
0@ = 1 
return 
return 

:IMPEXPM_9397
0623: add 1 to_integer_stat 213 
4@ = 0 

:IMPEXPM_9411
if 
  10 > 4@ 
else_jump @IMPEXPM_9675 
if 
003C:   " + tmp_Car_Models_To_Export + @"(4@,10i) == 6@ 
else_jump @IMPEXPM_9661 
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 0 
else_jump @IMPEXPM_9661 
" + tmp_Export_Cars_Status + @"(4@,10i) = 1 
09E1: get_car_model 6@ price_to 29@ 
0093: 12@ = integer 29@ to_float 
006F: 12@ *= " + Export_Price_Multiplier + @" 
006F: 12@ *= " + Export_Price_Health_Multiplier + @" 
0092: 29@ = float 12@ to_integer 
0652: 4@ = integer_stat 213 
0871: init_jump_table 4@ total_jumps 3 default_jump 0 @IMPEXPM_9654 jumps 10 @IMPEXPM_9596 20 @IMPEXPM_9613 30 @IMPEXPM_9630 -1 @IMPEXPM_9654 -1 @IMPEXPM_9654 -1 @IMPEXPM_9654 -1 @IMPEXPM_9654 

:IMPEXPM_9596
29@ += 50000 
jump @IMPEXPM_9654 

:IMPEXPM_9613
29@ += 100000 
jump @IMPEXPM_9654 

:IMPEXPM_9630
29@ += 200000 
" + All_Cars_Collected_Flag + @" = 1 
jump @IMPEXPM_9654 

:IMPEXPM_9654
4@ = 10 

:IMPEXPM_9661
4@ += 1 
jump @IMPEXPM_9411 

:IMPEXPM_9675
gosub @IMPEXPM_11671 
4@ = 0 

:IMPEXPM_9689
if 
  42 > 4@ 
else_jump @IMPEXPM_9770 
if 
  " + tmp_Unlocked_Import_Cars + @"(4@,42i) == -1 
else_jump @IMPEXPM_9756 
008A: " + tmp_Unlocked_Import_Cars + @"(4@,42i) = 6@ 
0085: 5@ = 4@ 
4@ = 42 

:IMPEXPM_9756
4@ += 1 
jump @IMPEXPM_9689 

:IMPEXPM_9770
" + Import_New_Available_Cars_Number + @" = 1 
0871: init_jump_table 5@ total_jumps 6 default_jump 0 @IMPEXPM_10050 jumps 10 @IMPEXPM_9840 16 @IMPEXPM_9873 22 @IMPEXPM_9910 28 @IMPEXPM_9943 34 @IMPEXPM_9980 40 @IMPEXPM_10013 -1 @IMPEXPM_10050 

:IMPEXPM_9840
5@ += 1 
04AE: " + tmp_Unlocked_Import_Cars + @"(5@,42i) = 444 
" + Import_New_Available_Cars_Number + @" += 1 
jump @IMPEXPM_10050 

:IMPEXPM_9873
5@ += 1 
04AE: " + tmp_Unlocked_Import_Cars + @"(5@,42i) = 555 
0394: play_music 2 
" + Import_New_Available_Cars_Number + @" += 1 
jump @IMPEXPM_10050 

:IMPEXPM_9910
5@ += 1 
04AE: " + tmp_Unlocked_Import_Cars + @"(5@,42i) = 568 
" + Import_New_Available_Cars_Number + @" += 1 
jump @IMPEXPM_10050 

:IMPEXPM_9943
5@ += 1 
04AE: " + tmp_Unlocked_Import_Cars + @"(5@,42i) = 451 
0394: play_music 2 
" + Import_New_Available_Cars_Number + @" += 1 
jump @IMPEXPM_10050 

:IMPEXPM_9980
5@ += 1 
04AE: " + tmp_Unlocked_Import_Cars + @"(5@,42i) = 539 
" + Import_New_Available_Cars_Number + @" += 1 
jump @IMPEXPM_10050 

:IMPEXPM_10013
5@ += 1 
04AE: " + tmp_Unlocked_Import_Cars + @"(5@,42i) = 541 
0394: play_music 2 
" + Import_New_Available_Cars_Number + @" += 1 
jump @IMPEXPM_10050 

:IMPEXPM_10050
return 

:IMPEXPM_10052
if and
  " + OnMission + @" == 1 
   not " + _1185 + @" == 1 
else_jump @IMPEXPM_10154 
" + tmp_Car_Models_To_Export + @"[0] = -1 
" + tmp_Car_Models_To_Export + @"[1] = -1 
" + tmp_Car_Models_To_Export + @"[2] = -1 
" + tmp_Car_Models_To_Export + @"[3] = -1 
" + tmp_Car_Models_To_Export + @"[4] = -1 
" + tmp_Car_Models_To_Export + @"[5] = -1 
" + tmp_Car_Models_To_Export + @"[6] = -1 
" + tmp_Car_Models_To_Export + @"[7] = -1 
" + tmp_Car_Models_To_Export + @"[8] = -1 
" + tmp_Car_Models_To_Export + @"[9] = -1 
jump @IMPEXPM_10630 

:IMPEXPM_10154
4@ = 0 
5@ = 0 

:IMPEXPM_10168
if 
  10 > 4@ 
else_jump @IMPEXPM_10229 
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 1 
else_jump @IMPEXPM_10215 
5@ += 1 

:IMPEXPM_10215
4@ += 1 
jump @IMPEXPM_10168 

:IMPEXPM_10229
if 
  5@ == 10 
else_jump @IMPEXPM_10336 
if 
  2 > " + Current_Wanted_List + @" 
else_jump @IMPEXPM_10329 
" + Current_Wanted_List + @" += 1 
4@ = 0 

:IMPEXPM_10279
if 
  10 > 4@ 
else_jump @IMPEXPM_10322 
" + tmp_Export_Cars_Status + @"(4@,10i) = 0 
4@ += 1 
jump @IMPEXPM_10279 

:IMPEXPM_10322
jump @IMPEXPM_10336 

:IMPEXPM_10329
" + All_Cars_Collected_Flag + @" = 1 

:IMPEXPM_10336
if 
  " + Current_Wanted_List + @" == 0 
else_jump @IMPEXPM_10434 
04AE: " + tmp_Car_Models_To_Export + @"[0] = 402 
04AE: " + tmp_Car_Models_To_Export + @"[1] = 405 
04AE: " + tmp_Car_Models_To_Export + @"[2] = 411 
04AE: " + tmp_Car_Models_To_Export + @"[3] = 483 
04AE: " + tmp_Car_Models_To_Export + @"[4] = 445 
04AE: " + tmp_Car_Models_To_Export + @"[5] = 470 
04AE: " + tmp_Car_Models_To_Export + @"[6] = 468 
04AE: " + tmp_Car_Models_To_Export + @"[7] = 409 
04AE: " + tmp_Car_Models_To_Export + @"[8] = 533 
04AE: " + tmp_Car_Models_To_Export + @"[9] = 534 

:IMPEXPM_10434
if 
  " + Current_Wanted_List + @" == 1 
else_jump @IMPEXPM_10532 
04AE: " + tmp_Car_Models_To_Export + @"[0] = 415 
04AE: " + tmp_Car_Models_To_Export + @"[1] = 489 
04AE: " + tmp_Car_Models_To_Export + @"[2] = 439 
04AE: " + tmp_Car_Models_To_Export + @"[3] = 514 
04AE: " + tmp_Car_Models_To_Export + @"[4] = 480 
04AE: " + tmp_Car_Models_To_Export + @"[5] = 535 
04AE: " + tmp_Car_Models_To_Export + @"[6] = 496 
04AE: " + tmp_Car_Models_To_Export + @"[7] = 580 
04AE: " + tmp_Car_Models_To_Export + @"[8] = 475 
04AE: " + tmp_Car_Models_To_Export + @"[9] = 521 

:IMPEXPM_10532
if 
  " + Current_Wanted_List + @" == 2 
else_jump @IMPEXPM_10630 
04AE: " + tmp_Car_Models_To_Export + @"[0] = 429 
04AE: " + tmp_Car_Models_To_Export + @"[1] = 506 
04AE: " + tmp_Car_Models_To_Export + @"[2] = 508 
04AE: " + tmp_Car_Models_To_Export + @"[3] = 579 
04AE: " + tmp_Car_Models_To_Export + @"[4] = 424 
04AE: " + tmp_Car_Models_To_Export + @"[5] = 536 
04AE: " + tmp_Car_Models_To_Export + @"[6] = 463 
04AE: " + tmp_Car_Models_To_Export + @"[7] = 500 
04AE: " + tmp_Car_Models_To_Export + @"[8] = 477 
04AE: " + tmp_Car_Models_To_Export + @"[9] = 587 

:IMPEXPM_10630
return 

:IMPEXPM_10632
if 
03CA:   object " + Crane_Magnet + @" exists 
else_jump @IMPEXPM_10707 
0798: get_crane_magnet " + Crane_Magnet + @" attached_car_handle_to 17@ attached_actor_handle_to 18@ attached_object_handle_to 19@ 
if 
   not 17@ == -1 
else_jump @IMPEXPM_10707 
if 
803B:   not  20@ == 17@ 
else_jump @IMPEXPM_10707 
0085: 20@ = 17@ 

:IMPEXPM_10707
return 

:IMPEXPM_10709
4@ = 0 

:IMPEXPM_10716
if 
  6 > 4@ 
else_jump @IMPEXPM_10759 
" + tmp_Import_Cars_Model + @"(4@,6i) = -1 
4@ += 1 
jump @IMPEXPM_10716 

:IMPEXPM_10759
0871: init_jump_table " + _1194 + @" total_jumps 7 default_jump 0 @IMPEXPM_11207 jumps 0 @IMPEXPM_10822 1 @IMPEXPM_10877 2 @IMPEXPM_10932 3 @IMPEXPM_10987 4 @IMPEXPM_11042 5 @IMPEXPM_11097 6 @IMPEXPM_11152 

:IMPEXPM_10822
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[0] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[7] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[14] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[21] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[28] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[35] 
jump @IMPEXPM_11207 

:IMPEXPM_10877
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[1] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[8] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[15] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[22] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[29] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[36] 
jump @IMPEXPM_11207 

:IMPEXPM_10932
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[2] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[9] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[16] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[23] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[30] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[37] 
jump @IMPEXPM_11207 

:IMPEXPM_10987
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[3] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[10] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[17] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[24] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[31] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[38] 
jump @IMPEXPM_11207 

:IMPEXPM_11042
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[4] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[11] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[18] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[25] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[32] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[39] 
jump @IMPEXPM_11207 

:IMPEXPM_11097
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[5] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[12] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[19] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[26] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[33] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[40] 
jump @IMPEXPM_11207 

:IMPEXPM_11152
0084: " + tmp_Import_Cars_Model + @"[0] = " + tmp_Unlocked_Import_Cars + @"[6] 
0084: " + tmp_Import_Cars_Model + @"[1] = " + tmp_Unlocked_Import_Cars + @"[13] 
0084: " + tmp_Import_Cars_Model + @"[2] = " + tmp_Unlocked_Import_Cars + @"[20] 
0084: " + tmp_Import_Cars_Model + @"[3] = " + tmp_Unlocked_Import_Cars + @"[27] 
0084: " + tmp_Import_Cars_Model + @"[4] = " + tmp_Unlocked_Import_Cars + @"[34] 
0084: " + tmp_Import_Cars_Model + @"[5] = " + tmp_Unlocked_Import_Cars + @"[41] 
jump @IMPEXPM_11207 

:IMPEXPM_11207
return 

:IMPEXPM_11209
4@ = 0 

:IMPEXPM_11216
if 
  5 > 4@ 
else_jump @IMPEXPM_11404 
if 
  " + tmp_Import_Car_Handles + @"(4@,5i) == -1 
else_jump @IMPEXPM_11282 
0084: " + tmp_Import_Car_Handles + @"(4@,5i) = " + Import_Car + @" 
4@ = 10 
jump @IMPEXPM_11397 

:IMPEXPM_11282
if 
056E:   car " + tmp_Import_Car_Handles + @"(4@,5i) defined 
else_jump @IMPEXPM_11370 
if 
   Car.Wrecked(" + tmp_Import_Car_Handles + @"(4@,5i))
else_jump @IMPEXPM_11356 
Car.RemoveReferences(" + tmp_Import_Car_Handles + @"(4@,5i))
" + tmp_Import_Car_Handles + @"(4@,5i) = -1 
jump @IMPEXPM_11209 
jump @IMPEXPM_11363 

:IMPEXPM_11356
4@ += 1 

:IMPEXPM_11363
jump @IMPEXPM_11397 

:IMPEXPM_11370
Car.RemoveReferences(" + tmp_Import_Car_Handles + @"(4@,5i))
" + tmp_Import_Car_Handles + @"(4@,5i) = -1 
jump @IMPEXPM_11209 

:IMPEXPM_11397
jump @IMPEXPM_11216 

:IMPEXPM_11404
if 
  4@ == 5 
else_jump @IMPEXPM_11441 
Car.RemoveReferences(" + tmp_Import_Car_Handles + @"[4])
" + tmp_Import_Car_Handles + @"[4] = -1 
jump @IMPEXPM_11209 

:IMPEXPM_11441
return 
4@ = 0 

:IMPEXPM_11450
if 
  5 > 4@ 
else_jump @IMPEXPM_11669 
if 
   not " + tmp_Import_Car_Handles + @"(4@,5i) == -1 
else_jump @IMPEXPM_11655 
if 
056E:   car " + tmp_Import_Car_Handles + @"(4@,5i) defined 
else_jump @IMPEXPM_11635 
if 
   not Car.Wrecked(" + tmp_Import_Car_Handles + @"(4@,5i))
else_jump @IMPEXPM_11608 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPM_11601 
if 
8202:   not actor " + PlayerActor + @" near_car " + tmp_Import_Car_Handles + @"(4@,5i) radius 500.0 500.0 sphere 0 
else_jump @IMPEXPM_11601 
Car.RemoveReferences(" + tmp_Import_Car_Handles + @"(4@,5i))
" + tmp_Import_Car_Handles + @"(4@,5i) = -1 

:IMPEXPM_11601
jump @IMPEXPM_11628 

:IMPEXPM_11608
Car.RemoveReferences(" + tmp_Import_Car_Handles + @"(4@,5i))
" + tmp_Import_Car_Handles + @"(4@,5i) = -1 

:IMPEXPM_11628
jump @IMPEXPM_11655 

:IMPEXPM_11635
Car.RemoveReferences(" + tmp_Import_Car_Handles + @"(4@,5i))
" + tmp_Import_Car_Handles + @"(4@,5i) = -1 

:IMPEXPM_11655
4@ += 1 
jump @IMPEXPM_11450 

:IMPEXPM_11669
return 

:IMPEXPM_11671
4@ = 0 

:IMPEXPM_11678
if 
  10 > 4@ 
else_jump @IMPEXPM_11860 
if 
  " + Current_Wanted_List + @" == 0 
else_jump @IMPEXPM_11729 
0085: 5@ = 4@ 
5@ += 0 

:IMPEXPM_11729
if 
  " + Current_Wanted_List + @" == 1 
else_jump @IMPEXPM_11762 
0085: 5@ = 4@ 
5@ += 10 

:IMPEXPM_11762
if 
  " + Current_Wanted_List + @" == 2 
else_jump @IMPEXPM_11795 
0085: 5@ = 4@ 
5@ += 20 

:IMPEXPM_11795
if 
  " + tmp_Export_Cars_Status + @"(4@,10i) == 0 
else_jump @IMPEXPM_11835 
014C: set_parked_car_generator " + tmp_parked_IMPEXPM_cars + @"(5@,30i) cars_to_generate_to 101 
jump @IMPEXPM_11846 

:IMPEXPM_11835
014C: set_parked_car_generator " + tmp_parked_IMPEXPM_cars + @"(5@,30i) cars_to_generate_to 0 

:IMPEXPM_11846
4@ += 1 
jump @IMPEXPM_11678 

:IMPEXPM_11860
return 

:IMPEXPM_11862
0871: init_jump_table 6@ total_jumps 42 default_jump 0 @IMPEXPM_13109 jumps 402 @IMPEXPM_12269 404 @IMPEXPM_13088 405 @IMPEXPM_12290 409 @IMPEXPM_12416 411 @IMPEXPM_12311 415 @IMPEXPM_12542 424 @IMPEXPM_12899 
0872: jump_table_jumps 429 @IMPEXPM_12815 434 @IMPEXPM_13004 439 @IMPEXPM_12584 444 @IMPEXPM_12479 445 @IMPEXPM_12353 451 @IMPEXPM_12836 463 @IMPEXPM_12941 468 @IMPEXPM_12395 470 @IMPEXPM_12374 
0872: jump_table_jumps 475 @IMPEXPM_12710 477 @IMPEXPM_12983 480 @IMPEXPM_12626 483 @IMPEXPM_12332 489 @IMPEXPM_12563 496 @IMPEXPM_12668 500 @IMPEXPM_12962 506 @IMPEXPM_12794 508 @IMPEXPM_12857 
0872: jump_table_jumps 514 @IMPEXPM_12605 521 @IMPEXPM_12731 522 @IMPEXPM_12500 533 @IMPEXPM_12437 534 @IMPEXPM_12458 535 @IMPEXPM_12647 536 @IMPEXPM_12920 539 @IMPEXPM_13046 541 @IMPEXPM_13067 
0872: jump_table_jumps 555 @IMPEXPM_12521 559 @IMPEXPM_12248 568 @IMPEXPM_12773 573 @IMPEXPM_13025 579 @IMPEXPM_12878 580 @IMPEXPM_12689 587 @IMPEXPM_12752 589 @IMPEXPM_12227 -1 @IMPEXPM_13109 

:IMPEXPM_12227
05A9: " + Import_Model_Name + @" = 'CLUB' 
jump @IMPEXPM_13109 

:IMPEXPM_12248
05A9: " + Import_Model_Name + @" = 'JESTER' 
jump @IMPEXPM_13109 

:IMPEXPM_12269
05A9: " + Import_Model_Name + @" = 'BUFFALO' 
jump @IMPEXPM_13109 

:IMPEXPM_12290
05A9: " + Import_Model_Name + @" = 'SENTINL' 
jump @IMPEXPM_13109 

:IMPEXPM_12311
05A9: " + Import_Model_Name + @" = 'INFERNU' 
jump @IMPEXPM_13109 

:IMPEXPM_12332
05A9: " + Import_Model_Name + @" = 'CAMPER' 
jump @IMPEXPM_13109 

:IMPEXPM_12353
05A9: " + Import_Model_Name + @" = 'ADMIRAL' 
jump @IMPEXPM_13109 

:IMPEXPM_12374
05A9: " + Import_Model_Name + @" = 'PATRIOT' 
jump @IMPEXPM_13109 

:IMPEXPM_12395
05A9: " + Import_Model_Name + @" = 'SANCHEZ' 
jump @IMPEXPM_13109 

:IMPEXPM_12416
05A9: " + Import_Model_Name + @" = 'STRETCH' 
jump @IMPEXPM_13109 

:IMPEXPM_12437
05A9: " + Import_Model_Name + @" = 'FELTZER' 
jump @IMPEXPM_13109 

:IMPEXPM_12458
05A9: " + Import_Model_Name + @" = 'REMING' 
jump @IMPEXPM_13109 

:IMPEXPM_12479
05A9: " + Import_Model_Name + @" = 'MONSTER' 
jump @IMPEXPM_13109 

:IMPEXPM_12500
05A9: " + Import_Model_Name + @" = 'NRG500' 
jump @IMPEXPM_13109 

:IMPEXPM_12521
05A9: " + Import_Model_Name + @" = 'WINDSOR' 
jump @IMPEXPM_13109 

:IMPEXPM_12542
05A9: " + Import_Model_Name + @" = 'CHEETAH' 
jump @IMPEXPM_13109 

:IMPEXPM_12563
05A9: " + Import_Model_Name + @" = 'RANCHER' 
jump @IMPEXPM_13109 

:IMPEXPM_12584
05A9: " + Import_Model_Name + @" = 'STALION' 
jump @IMPEXPM_13109 

:IMPEXPM_12605
05A9: " + Import_Model_Name + @" = 'PETROL' 
jump @IMPEXPM_13109 

:IMPEXPM_12626
05A9: " + Import_Model_Name + @" = 'COMET' 
jump @IMPEXPM_13109 

:IMPEXPM_12647
05A9: " + Import_Model_Name + @" = 'SLAMVAN' 
jump @IMPEXPM_13109 

:IMPEXPM_12668
05A9: " + Import_Model_Name + @" = 'BLISTAC' 
jump @IMPEXPM_13109 

:IMPEXPM_12689
05A9: " + Import_Model_Name + @" = 'STAFFRD' 
jump @IMPEXPM_13109 

:IMPEXPM_12710
05A9: " + Import_Model_Name + @" = 'SABRE' 
jump @IMPEXPM_13109 

:IMPEXPM_12731
05A9: " + Import_Model_Name + @" = 'FCR900' 
jump @IMPEXPM_13109 

:IMPEXPM_12752
05A9: " + Import_Model_Name + @" = 'EUROS' 
jump @IMPEXPM_13109 

:IMPEXPM_12773
05A9: " + Import_Model_Name + @" = 'BANDITO' 
jump @IMPEXPM_13109 

:IMPEXPM_12794
05A9: " + Import_Model_Name + @" = 'SUPERGT' 
jump @IMPEXPM_13109 

:IMPEXPM_12815
05A9: " + Import_Model_Name + @" = 'BANSHEE' 
jump @IMPEXPM_13109 

:IMPEXPM_12836
05A9: " + Import_Model_Name + @" = 'TURISMO' 
jump @IMPEXPM_13109 

:IMPEXPM_12857
05A9: " + Import_Model_Name + @" = 'JOURNEY' 
jump @IMPEXPM_13109 

:IMPEXPM_12878
05A9: " + Import_Model_Name + @" = 'HUNTLEY' 
jump @IMPEXPM_13109 

:IMPEXPM_12899
05A9: " + Import_Model_Name + @" = 'BFINJC' 
jump @IMPEXPM_13109 

:IMPEXPM_12920
05A9: " + Import_Model_Name + @" = 'BLADE' 
jump @IMPEXPM_13109 

:IMPEXPM_12941
05A9: " + Import_Model_Name + @" = 'FREEWAY' 
jump @IMPEXPM_13109 

:IMPEXPM_12962
05A9: " + Import_Model_Name + @" = 'MESAA' 
jump @IMPEXPM_13109 

:IMPEXPM_12983
05A9: " + Import_Model_Name + @" = 'ZR350' 
jump @IMPEXPM_13109 

:IMPEXPM_13004
05A9: " + Import_Model_Name + @" = 'HOTKNIF' 
jump @IMPEXPM_13109 

:IMPEXPM_13025
05A9: " + Import_Model_Name + @" = 'DUNE' 
jump @IMPEXPM_13109 

:IMPEXPM_13046
05A9: " + Import_Model_Name + @" = 'VORTEX' 
jump @IMPEXPM_13109 

:IMPEXPM_13067
05A9: " + Import_Model_Name + @" = 'BULLET' 
jump @IMPEXPM_13109 

:IMPEXPM_13088
05A9: " + Import_Model_Name + @" = 'PEREN' 
jump @IMPEXPM_13109 

:IMPEXPM_13109
return 

:IMPEXPM_13111
0871: init_jump_table " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) total_jumps 19 default_jump 1 @IMPEXPM_14432 jumps 405 @IMPEXPM_13548 411 @IMPEXPM_13905 415 @IMPEXPM_13853 424 @IMPEXPM_14163 429 @IMPEXPM_14036 470 @IMPEXPM_14189 475 @IMPEXPM_13827 
0872: jump_table_jumps 480 @IMPEXPM_13879 483 @IMPEXPM_13675 489 @IMPEXPM_13931 496 @IMPEXPM_13957 506 @IMPEXPM_13379 533 @IMPEXPM_13700 536 @IMPEXPM_14353 541 @IMPEXPM_14379 555 @IMPEXPM_13405 
0872: jump_table_jumps 559 @IMPEXPM_13458 587 @IMPEXPM_13353 589 @IMPEXPM_13327 -1 @IMPEXPM_14446 -1 @IMPEXPM_14446 -1 @IMPEXPM_14446 -1 @IMPEXPM_14446 -1 @IMPEXPM_14446 -1 @IMPEXPM_14446 

:IMPEXPM_13327
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""N13_LLF_"" 
jump @IMPEXPM_14446 

:IMPEXPM_13353
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_DS3MP__"" 
jump @IMPEXPM_14446 

:IMPEXPM_13379
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_CMACD1_"" 
jump @IMPEXPM_14446 

:IMPEXPM_13405
0209: 4@ = random_int_in_ranges 0 3 
if 
  4@ == 0 
else_jump @IMPEXPM_13451 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""__C0S___"" 

:IMPEXPM_13451
jump @IMPEXPM_14446 

:IMPEXPM_13458
0209: 4@ = random_int_in_ranges 0 3 
if 
  4@ == 1 
else_jump @IMPEXPM_13504 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_X2_GAV_"" 

:IMPEXPM_13504
if 
  4@ == 2 
else_jump @IMPEXPM_13541 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""__G3PO__"" 

:IMPEXPM_13541
jump @IMPEXPM_14446 

:IMPEXPM_13548
0209: 4@ = random_int_in_ranges 0 3 
if 
  4@ == 0 
else_jump @IMPEXPM_13594 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""D0N_D0N_"" 

:IMPEXPM_13594
if 
  4@ == 1 
else_jump @IMPEXPM_13631 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_D0_NNY_"" 

:IMPEXPM_13631
if 
  4@ == 2 
else_jump @IMPEXPM_13668 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""TH3_D0N_"" 

:IMPEXPM_13668
jump @IMPEXPM_14446 

:IMPEXPM_13675
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""SJM1985"" 
jump @IMPEXPM_14446 

:IMPEXPM_13700
0209: 4@ = random_int_in_ranges 0 5 
if 
  4@ == 1 
else_jump @IMPEXPM_13746 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""433_ADF_"" 

:IMPEXPM_13746
if 
  4@ == 2 
else_jump @IMPEXPM_13783 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""DR_F_MBE"" 

:IMPEXPM_13783
if 
  4@ == 3 
else_jump @IMPEXPM_13820 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""ANN_F3RG"" 

:IMPEXPM_13820
jump @IMPEXPM_14446 

:IMPEXPM_13827
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""__FR4Z__"" 
jump @IMPEXPM_14446 

:IMPEXPM_13853
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_IMY_AK_"" 
jump @IMPEXPM_14446 

:IMPEXPM_13879
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_L0LLY__"" 
jump @IMPEXPM_14446 

:IMPEXPM_13905
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_J_L33S_"" 
jump @IMPEXPM_14446 

:IMPEXPM_13931
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""S4_LIJON"" 
jump @IMPEXPM_14446 

:IMPEXPM_13957
0209: 4@ = random_int_in_ranges 0 2 
if 
  4@ == 0 
else_jump @IMPEXPM_14010 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""DI5CO5TU"" 
jump @IMPEXPM_14029 

:IMPEXPM_14010
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""SM53_NUV"" 

:IMPEXPM_14029
jump @IMPEXPM_14446 

:IMPEXPM_14036
0209: 4@ = random_int_in_ranges 0 3 
if 
  4@ == 0 
else_jump @IMPEXPM_14082 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""J3NYTAL5"" 

:IMPEXPM_14082
if 
  4@ == 1 
else_jump @IMPEXPM_14119 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_J3_NCF_"" 

:IMPEXPM_14119
if 
  4@ == 2 
else_jump @IMPEXPM_14156 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""DD0_N4LD"" 

:IMPEXPM_14156
jump @IMPEXPM_14446 

:IMPEXPM_14163
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""LA5H_L3Y"" 
jump @IMPEXPM_14446 

:IMPEXPM_14189
0209: 4@ = random_int_in_ranges 0 4 
if 
  4@ == 0 
else_jump @IMPEXPM_14235 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""AL3X_RES"" 

:IMPEXPM_14235
if 
  4@ == 1 
else_jump @IMPEXPM_14272 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""R_F3RG1E"" 

:IMPEXPM_14272
if 
  4@ == 2 
else_jump @IMPEXPM_14309 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""H4_NNAHF"" 

:IMPEXPM_14309
if 
  4@ == 3 
else_jump @IMPEXPM_14346 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""CL41_RES"" 

:IMPEXPM_14346
jump @IMPEXPM_14446 

:IMPEXPM_14353
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""R055_MCL"" 
jump @IMPEXPM_14446 

:IMPEXPM_14379
0209: 4@ = random_int_in_ranges 0 4 
if 
  4@ == 0 
else_jump @IMPEXPM_14425 
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""T00_FAST"" 

:IMPEXPM_14425
jump @IMPEXPM_14446 

:IMPEXPM_14432
gosub @IMPEXPM_14448 
jump @IMPEXPM_14446 

:IMPEXPM_14446
return 

:IMPEXPM_14448
0209: 4@ = random_int_in_ranges 0 100 
0871: init_jump_table 4@ total_jumps 12 default_jump 0 @IMPEXPM_14897 jumps 0 @IMPEXPM_14585 1 @IMPEXPM_14611 2 @IMPEXPM_14637 3 @IMPEXPM_14663 4 @IMPEXPM_14689 5 @IMPEXPM_14715 6 @IMPEXPM_14741 
0872: jump_table_jumps 7 @IMPEXPM_14767 8 @IMPEXPM_14793 9 @IMPEXPM_14819 10 @IMPEXPM_14845 11 @IMPEXPM_14871 -1 @IMPEXPM_14897 -1 @IMPEXPM_14897 -1 @IMPEXPM_14897 -1 @IMPEXPM_14897 

:IMPEXPM_14585
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""R4N_G3RS"" 
jump @IMPEXPM_14897 

:IMPEXPM_14611
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""GL4S_G0W"" 
jump @IMPEXPM_14897 

:IMPEXPM_14637
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_ARRAN__"" 
jump @IMPEXPM_14897 

:IMPEXPM_14663
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""AM0_RUS0"" 
jump @IMPEXPM_14897 

:IMPEXPM_14689
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_AMAT0__"" 
jump @IMPEXPM_14897 

:IMPEXPM_14715
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""_GA_ZZA_"" 
jump @IMPEXPM_14897 

:IMPEXPM_14741
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""ZID_ANE_"" 
jump @IMPEXPM_14897 

:IMPEXPM_14767
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""MC_C01ST"" 
jump @IMPEXPM_14897 

:IMPEXPM_14793
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""BAW_BAG_"" 
jump @IMPEXPM_14897 

:IMPEXPM_14819
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""BR0_D1E_"" 
jump @IMPEXPM_14897 

:IMPEXPM_14845
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""MR_J0BBY"" 
jump @IMPEXPM_14897 

:IMPEXPM_14871
0674: set_car_model " + tmp_Import_Cars_Model + @"(" + Import_Panel_Row + @",6i) numberplate ""BR0_DICK"" 
jump @IMPEXPM_14897 

:IMPEXPM_14897
return" );

            }

        }

        private sealed class IMPEXPC : Thread {

            Int tmp_Car_Models_To_Export = global( Car_Models_To_Export.startIndex ),
                tmp_Export_Cars_Status = global( Export_Cars_Status.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @":IMPEXPC_11
wait 5000 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPEXPC_306 
if 
  " + OnMission + @" == 0 
else_jump @IMPEXPC_306 
if 
  " + _1909 + @" == 1 
else_jump @IMPEXPC_306 
if and
88FE:   not text_box_displayed 
876F:   not text_priority_displayed 
else_jump @IMPEXPC_306 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @IMPEXPC_281 
if 
  0@ == 0 
else_jump @IMPEXPC_274 
" + tempvar_Actor_Car + @" = Actor.CurrentCar(" + PlayerActor + @")
1@ = Car.Model(" + tempvar_Actor_Car + @")
2@ = 0 
3@ = 0 

:IMPEXPC_147
if 
  10 > 2@ 
else_jump @IMPEXPC_238 
if 
003C:   " + tmp_Car_Models_To_Export + @"(2@,10i) == 1@ 
else_jump @IMPEXPC_224 
if 
  " + tmp_Export_Cars_Status + @"(2@,10i) == 0 
else_jump @IMPEXPC_224 
3@ = 1 
2@ = 10 

:IMPEXPC_224
2@ += 1 
jump @IMPEXPC_147 

:IMPEXPC_238
if 
  3@ == 1 
else_jump @IMPEXPC_274 
03E5: show_text_box 'IE22'  
0@ = 1 

:IMPEXPC_274
jump @IMPEXPC_306 

:IMPEXPC_281
if 
  0@ == 1 
else_jump @IMPEXPC_306 
0@ = 0 

:IMPEXPC_306
jump @IMPEXPC_11" );

            }

        }

    }

}