using GTA.Core;

namespace GTA.Plugins.Common {

    internal partial class OriginalODDVEH : Original {

        private static Bike parked_BMX_Glen_Park = Script.global(), parked_NRG500_Easter_Basin = Script.global(), carPark_2769 = Script.global(), carPark_2776 = Script.global(), carPark_2778 = Script.global(), carPark_2779 = Script.global();
        private static Car carPark_2759 = Script.global(), carPark_2760 = Script.global();

        private static AssetMoneyPickup _1931 = Script.global();
        private static AssetMoneyPickup _5271 = Script.global();
        private static AssetMoneyPickup _1933 = Script.global();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal OriginalODDVEH() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            _1799.value = 1;
            _1872.value = 1;
            _1869.value = 1;
            Mission_BeatTheCock_Type.value = 1;

            X_STUNT_Mission_BMX.value = 1946.09;
            Y_STUNT_Mission_BMX.value = -1380.72;
            Z_STUNT_Mission_BMX.value = 18.0;
            X_STUNT_Mission_NRG500.value = -1696.531;
            Y_STUNT_Mission_NRG500.value = 77.7192;
            Z_STUNT_Mission_NRG500.value = 3.5547;
            _2343.value = 1359.45;
            _2344.value = -1755.0;
            _2345.value = 12.85;
            _2346.value = -2590.44;
            _2347.value = 73.21;
            _2348.value = 3.91;
            _2349.value = 1887.79;
            _2350.value = 2087.39;
            _2351.value = 10.05;
            _2352.value = 823.6816;
            _2353.value = 854.1741;
            _2354.value = 10.7949;
            _2355.value = -2309.23;
            _2356.value = -1651.22;
            _2357.value = 483.09;
            _2373.value = -77.6456;
            _2374.value = -1136.401;
            _2375.value = 0.0781;
            STUNT_Missions_BestTime[ 0 ].value = 999999999;
            STUNT_Missions_BestTime[ 1 ].value = 999999999;

            Script.CAR_PARK.init( parked_BMX_Glen_Park, X_STUNT_Mission_BMX, Y_STUNT_Mission_BMX, Z_STUNT_Mission_BMX, 88.1761, 481, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_NRG500_Easter_Basin, X_STUNT_Mission_NRG500, Y_STUNT_Mission_NRG500, Z_STUNT_Mission_NRG500, 312.9365, 522, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2769, _2355, _2356, _2357, 206.39, 510, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2776, _2343, _2344, _2345, 53.1, 481, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2778, _2346, _2347, _2348, 42.0, 463, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2779, _2349, _2350, _2351, 183.4, 462, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2759, 687.3733, 890.67, -40.4285, 35.14, 406, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2760, 620.882, 861.2452, -43.9534, 298.7428, 486, forceSpawn_bool: true );
            Script.CAR_PARK.set_chance_to_generate( parked_BMX_Glen_Park, 101 );
            Script.CAR_PARK.set_chance_to_generate( parked_NRG500_Easter_Basin, 101 );
            Script.CAR_PARK.set_chance_to_generate( carPark_2769, 101 );
            Script.CAR_PARK.set_chance_to_generate( carPark_2776, 101 );
            Script.CAR_PARK.set_chance_to_generate( carPark_2778, 101 );
            Script.CAR_PARK.set_chance_to_generate( carPark_2779, 101 );
            Script.CAR_PARK.set_chance_to_generate( carPark_2759, 0 );
            Script.CAR_PARK.set_chance_to_generate( carPark_2760, 0 );


            Script.create_thread<ODDVEH>();
            Script.create_thread<TRI>();
            Script.create_thread<TRUCKS>();
            Script.create_thread<QUARRYS>();
            Script.create_thread<VALET_L>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class ODDVEH : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":ODDVEH_11
wait " + DefaultWaitTime + @"
if 
   Player.Defined(" + PlayerChar + @")
else_jump @ODDVEH_1143 
if 
  " + OnMission + @" == 0 
else_jump @ODDVEH_1143 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @ODDVEH_1108 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #BMX)
else_jump @ODDVEH_134 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere " + _2343 + @" " + _2344 + @" " + _2345 + @" radius 3.0 3.0 3.0 
else_jump @ODDVEH_134 
" + ONMISSION_Courier + @" = 1 

:ODDVEH_134
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #FREEWAY)
else_jump @ODDVEH_202 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere " + _2346 + @" " + _2347 + @" " + _2348 + @" radius 3.0 3.0 3.0 
else_jump @ODDVEH_202 
" + ONMISSION_Courier + @" = 1 

:ODDVEH_202
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #FAGGIO)
else_jump @ODDVEH_270 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere " + _2349 + @" " + _2350 + @" " + _2351 + @" radius 3.0 3.0 3.0 
else_jump @ODDVEH_270 
" + ONMISSION_Courier + @" = 1 

:ODDVEH_270
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #BMX)
else_jump @ODDVEH_334 
if 
  " + ONMISSION_Courier + @" == 0 
else_jump @ODDVEH_334 
00BA: show_text_styled GXT 'COUR1' time 1000 style 2" );
                start_mission<BCOUR>();
                AppendLine( @"" + ONMISSION_Courier + @" = 1 

:ODDVEH_334
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #FREEWAY)
else_jump @ODDVEH_398 
if 
  " + ONMISSION_Courier + @" == 0 
else_jump @ODDVEH_398 
00BA: show_text_styled GXT 'COUR1' time 1000 style 2" );
                start_mission<BCOUR>();
                AppendLine( @"" + ONMISSION_Courier + @" = 1 

:ODDVEH_398
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #FAGGIO)
else_jump @ODDVEH_462 
if 
  " + ONMISSION_Courier + @" == 0 
else_jump @ODDVEH_462 
00BA: show_text_styled GXT 'COUR1' time 1000 style 2" );
                start_mission<BCOUR>();
                AppendLine( @"" + ONMISSION_Courier + @" = 1 

:ODDVEH_462
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #MTBIKE)
else_jump @ODDVEH_530 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere " + _2355 + @" " + _2356 + @" " + _2357 + @" radius 10.5 10.5 10.5 
else_jump @ODDVEH_530 
" + ONMISSION_Chiliad + @" = 1 

:ODDVEH_530
if and
   Actor.DrivingVehicleType(" + PlayerActor + @", #MTBIKE)
  " + ONMISSION_Chiliad + @" == 0 
else_jump @ODDVEH_718 
00BE: text_clear_all 
0652: " + STAT_Cycling_Skill + @" = integer_stat 230 
if 
  " + STAT_Cycling_Skill + @" >= 400 
else_jump @ODDVEH_675 
00BF: " + Time_Hours + @" = current_time_hours, " + Time_Mins + @" = current_time_minutes 
if and
  " + Time_Hours + @" >= 7 
  18 > " + Time_Hours + @" 
else_jump @ODDVEH_652 
00BA: show_text_styled GXT 'MOUNTN' time 1000 style 2" );
                start_mission<MTBIKER>();
                AppendLine( @"" + ONMISSION_Chiliad + @" = 1 
jump @ODDVEH_668 

:ODDVEH_652
00BC: show_text_highpriority GXT 'MTIME4' time 1000 flag 1  

:ODDVEH_668
jump @ODDVEH_711 

:ODDVEH_675
if 
  " + Help_Chiliad_Cycling_Shown + @" == 0 
else_jump @ODDVEH_711 
03E5: show_text_box 'MTBSKIL'  
" + Help_Chiliad_Cycling_Shown + @" = 1 

:ODDVEH_711
jump @ODDVEH_743 

:ODDVEH_718
if 
  " + Help_Chiliad_Cycling_Shown + @" == 1 
else_jump @ODDVEH_743 
" + Help_Chiliad_Cycling_Shown + @" = 0 

:ODDVEH_743
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #BMX)
else_jump @ODDVEH_811 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere " + X_STUNT_Mission_BMX + @" " + Y_STUNT_Mission_BMX + @" " + Z_STUNT_Mission_BMX + @" radius 4.0 4.0 3.0 
else_jump @ODDVEH_811 
" + ONMISSION_Stunt_BMX + @" = 1 

:ODDVEH_811
if and
   Actor.DrivingVehicleType(" + PlayerActor + @", #BMX)
  " + ONMISSION_Stunt_BMX + @" == 0 
else_jump @ODDVEH_948 
0652: " + STAT_Cycling_Skill + @" = integer_stat 230 
if 
  " + STAT_Cycling_Skill + @" >= 200 
else_jump @ODDVEH_905 
00BA: show_text_styled GXT 'BMX' time 1000 style 2  
" + STUNT_Mission_Type + @" = 0" );
                start_mission<STUNT>();
                AppendLine( @"" + ONMISSION_Stunt_BMX + @" = 1 
jump @ODDVEH_941 

:ODDVEH_905
if 
  " + Help_BMX_Cycling_Shown + @" == 0 
else_jump @ODDVEH_941 
03E5: show_text_box 'MTBSKI2'  
" + Help_BMX_Cycling_Shown + @" = 1 

:ODDVEH_941
jump @ODDVEH_973 

:ODDVEH_948
if 
  " + Help_BMX_Cycling_Shown + @" == 1 
else_jump @ODDVEH_973 
" + Help_BMX_Cycling_Shown + @" = 0 

:ODDVEH_973
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #NRG500)
else_jump @ODDVEH_1041 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere " + X_STUNT_Mission_NRG500 + @" " + Y_STUNT_Mission_NRG500 + @" " + Z_STUNT_Mission_NRG500 + @" radius 4.0 4.0 3.0 
else_jump @ODDVEH_1041 
" + ONMISSION_Stunt_NRG500 + @" = 1 

:ODDVEH_1041
if and
   Actor.DrivingVehicleType(" + PlayerActor + @", #NRG500)
  " + ONMISSION_Stunt_NRG500 + @" == 0 
else_jump @ODDVEH_1101 
00BA: show_text_styled GXT 'NRG500' time 1000 style 2  
" + STUNT_Mission_Type + @" = 1" );
                start_mission<STUNT>();
                AppendLine( @"" + ONMISSION_Stunt_NRG500 + @" = 1 

:ODDVEH_1101
jump @ODDVEH_1143 

:ODDVEH_1108
" + _158 + @" = 0 
" + ONMISSION_Courier + @" = 0 
" + ONMISSION_Chiliad + @" = 0 
" + ONMISSION_Stunt_BMX + @" = 0 
" + ONMISSION_Stunt_NRG500 + @" = 0 

:ODDVEH_1143
jump @ODDVEH_11" );

            }

        }

        private sealed class TRI : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":TRI_11
wait 0 
if 
  " + OnMission + @" == 0 
else_jump @TRI_618 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRI_618 
if or
  " + Weekday + @" == 1 
  " + Weekday + @" == 7 
else_jump @TRI_618 
if or
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 181.0 -1878.0 2.0 radius 1.4 1.8 1.5 on_foot 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 2135.432 -67.9555 1.8 radius 1.4 1.8 1.5 on_foot 
else_jump @TRI_543 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  " + STAT_Unlocked_Cities_Number + @" > 1 
else_jump @TRI_500 
0652: " + STAT_Cycling_Skill + @" = integer_stat 230 
if 
  " + STAT_Cycling_Skill + @" >= 500 
else_jump @TRI_457 
0652: " + STAT_Stamina + @" = integer_stat 22 
if 
  " + STAT_Stamina + @" >= 500 
else_jump @TRI_414 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @TRI_407 
00BA: show_text_styled GXT 'BOTTY' time 1000 style 2" );
                print_gosub_LITCAS_268();
                AppendLine( @"if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRI_403 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 181.0 -1878.0 2.0 radius 20.4 20.8 20.5 on_foot 
else_jump @TRI_348 
" + Mission_BeatTheCock_Type + @" = 1 

:TRI_348
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere 2135.432 -67.9555 20.8 radius 20.4 20.8 20.5 on_foot 
else_jump @TRI_403 
" + Mission_BeatTheCock_Type + @" = 2 

:TRI_403" );
                start_mission<TRIA>();
                AppendLine( @"
:TRI_407
jump @TRI_450 

:TRI_414
if 
  " + Help_TRI_Stamina_Shown + @" == 0 
else_jump @TRI_450 
03E5: show_text_box 'STASKIL'  
" + Help_TRI_Stamina_Shown + @" = 1 

:TRI_450
jump @TRI_493 

:TRI_457
if 
  " + Help_TRI_Cycling_Shown + @" == 0 
else_jump @TRI_493 
03E5: show_text_box 'MTBSKIL'  
" + Help_TRI_Cycling_Shown + @" = 1 

:TRI_493
jump @TRI_536 

:TRI_500
if 
  " + Help_TRI_NoCock_Shown + @" == 0 
else_jump @TRI_536 
03E5: show_text_box 'NOCOCK'  
" + Help_TRI_NoCock_Shown + @" = 1 

:TRI_536
jump @TRI_618 

:TRI_543
if 
  " + Help_TRI_Cycling_Shown + @" == 1 
else_jump @TRI_568 
" + Help_TRI_Cycling_Shown + @" = 0 

:TRI_568
if 
  " + Help_TRI_Stamina_Shown + @" == 1 
else_jump @TRI_593 
" + Help_TRI_Stamina_Shown + @" = 0 

:TRI_593
if 
  " + Help_TRI_NoCock_Shown + @" == 1 
else_jump @TRI_618 
" + Help_TRI_NoCock_Shown + @" = 0 

:TRI_618
jump @TRI_11" );
            }

        }

        private sealed class QUARRYS : Thread {

            RadarMarker Marker_Quarry_Mission = global();

            public override void START( LabelJump label ) {
                Marker_Quarry_Mission.create_short_range( RadarIconID.TRUCKING, _2352, _2353, _2354 );
                AppendLine( @"
:QUARRYS_27
wait 0 
if 
  " + OnMission + @" == 0 
else_jump @QUARRYS_161 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @QUARRYS_161 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere + " + _2352 + " " + _2353 + " " + _2354 + @" radius 1.5 1.8 1.5 on_foot 
else_jump @QUARRYS_161 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @QUARRYS_161 
Player.CanMove(" + PlayerChar + @") = False
0A2D: hide_styled_text_while_fading 0
00BA: show_text_styled GXT 'QUARRY' time 3000 style 5" );
                print_gosub_LITCAS_268();
                start_mission<QUARRY>();
                AppendLine( @"
:QUARRYS_161
jump @QUARRYS_27" );
            }

        }

        private sealed class VALET_L : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":VALET_L_11
wait 0 
if 
  " + _1872 + @" == 1 
else_jump @VALET_L_197 
if 
04A3:   " + Current_Town_Number + @" == 2
else_jump @VALET_L_197" );
                get_external_script_status<VALET>( ScriptStatus );
                AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @VALET_L_197 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @VALET_L_197 
if 
00A3:   actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA -1893.419 1119.227 cornerB -1617.915 828.85 
else_jump @VALET_L_168 
" + _1884 + @" = 2" );
                load_external_script<VALET>();
                AppendLine( @"if " );
                is_external_script_loaded<VALET>().write();
                AppendLine( @"else_jump @VALET_L_161" );
                start_new_external_script<VALET>();
                AppendLine( @"
:VALET_L_161
jump @VALET_L_197 

:VALET_L_168
if 
  " + _1884 + @" == 2 
else_jump @VALET_L_197" );
                remove_references_external_script<VALET>();
                AppendLine( @"" + _1884 + @" = 0 

:VALET_L_197
jump @VALET_L_11" );
            }

        }

        private sealed class TRUCKS : Thread {

            RadarMarker Marker_Trucking_Mission = global();

            public override void START( LabelJump label ) {
                Marker_Trucking_Mission.create_short_range( RadarIconID.TRUCKING, _2373, _2374, _2375 );
                AppendLine( @"
:TRUCKS_27
wait " + DefaultWaitTime + @" 
if 
  " + OnMission + @" == 0 
else_jump @TRUCKS_162 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRUCKS_162 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _2373 + " " + _2374 + " " + _2375 + @" radius 1.2 1.2 1.5 on_foot 
else_jump @TRUCKS_162 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @TRUCKS_162 
Player.CanMove(" + PlayerChar + @") = False
0A2D: hide_styled_text_while_fading 0
00BA: show_text_styled GXT 'TRUCK' time 3000 style 5" );
                print_gosub_LITCAS_268();
                start_mission<TRUCK>();
                AppendLine( @"
:TRUCKS_162
jump @TRUCKS_27" );
            }

        }

    }

}