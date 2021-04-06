using GTA.Core;

namespace GTA.Plugins.Common {

    internal partial class OriginalSkools : Original {

        internal OriginalSkools() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Car carPark_5178 = Script.global(), carPark_5183 = Script.global(), carPark_5184 = Script.global();
        private static Plane parked_Rustler = Script.global(), parked_Stunt = Script.global();
        private static Heli parked_Hunter = Script.global();
        private static Boat parked_Jetmax = Script.global(), parked_Squalo = Script.global(), parked_Marquis = Script.global();
        private static Bike parked_Freeway = Script.global(), parked_FCR900 = Script.global(), parked_NRG500 = Script.global();

        internal override void Start() {
            _666.value = 415.55;
            _667.value = 2533.57;
            _668.value = 19.18;
            _2367.value = -2187.378;
            _2368.value = 2416.552;
            _2369.value = 4.166;
            _2370.value = 1173.877;
            _2371.value = 1351.037;
            _2372.value = 9.9219;
            X_Driving_School.value = -2026.811;
            Y_Driving_School.value = -114.9093;
            Z_Driving_School.value = 1034.179;
            _5187.value = 1;
            _53.value = 1;
            Flight_School_Brief_Played.value = 1;
            Flight_School_Contests_Passed.value = 1;
            Flight_School_Current_Contest.value = 1;
            _1962.value = 1;
            _1963.value = 60000;
            _1964.value = 80000;
            _1965.value = 180000;
            _1966.value = 10;
            _1967.value = 200000;

            Script.CAR_PARK.init( carPark_5178, -2093.9, -83.7, 33.9, 359.1, 506, 31, 0, true );
            Script.CAR_PARK.init( carPark_5183, -2076.8, -84.0, 33.7, 1.1, 541, 15, 15, true );
            Script.CAR_PARK.init_with_number_plate( carPark_5184, -2064.4, -83.7, 34.1, 0.0, 434, "__GOLD__", 15, 15, true );
            Script.CAR_PARK.init( parked_Rustler, 325.12, 2537.1, 17.52, 180.0, 476, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_Stunt, 348.0, 2537.1, 17.42, 180.0, 513, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_Hunter, 365.51, 2537.1, 17.42, 180.0, 425, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_Marquis, -2227.104, 2445.776, 0.0, 229.3771, 484, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_Squalo, -2225.0806, 2402.9692, 0.0, 49.0555, 446, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_Jetmax, -2247.836, 2425.675, 0.0, 220.2123, 493, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_Freeway, 1174.76, 1364.832, 10.1203, 280.0355, 463, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_FCR900, 1174.999, 1366.479, 10.1203, 282.2258, 521, forceSpawn_bool: true );
            Script.CAR_PARK.init( parked_NRG500, 1174.467, 1368.359, 10.1203, 283.0546, 522, forceSpawn_bool: true );

            Script.CAR_PARK.set_to_player_owned( carPark_5178, true ).set_chance_to_generate( carPark_5178, 0 );
            Script.CAR_PARK.set_to_player_owned( carPark_5183, true ).set_chance_to_generate( carPark_5183, 0 );
            Script.CAR_PARK.set_to_player_owned( carPark_5184, true ).set_chance_to_generate( carPark_5184, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Rustler, true ).set_chance_to_generate( parked_Rustler, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Stunt, true ).set_chance_to_generate( parked_Stunt, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Hunter, true ).set_chance_to_generate( parked_Hunter, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Marquis, true ).set_chance_to_generate( parked_Marquis, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Squalo, true ).set_chance_to_generate( parked_Squalo, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Jetmax, true ).set_chance_to_generate( parked_Jetmax, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_Freeway, true ).set_chance_to_generate( parked_Freeway, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_FCR900, true ).set_chance_to_generate( parked_FCR900, 0 );
            Script.CAR_PARK.set_to_player_owned( parked_NRG500, true ).set_chance_to_generate( parked_NRG500, 0 );

            Array<RadarMarker> skoolMarkers = Script.global_array( 4 );
            skoolMarkers[ 0 ].create_short_range( RadarIconID.SCHOOL, _666, _667, _668 ).set_radar_mode( 2 );
            skoolMarkers[ 1 ].create_short_range( RadarIconID.SCHOOL, _2367, _2368, _2369 ).set_radar_mode( 2 );
            skoolMarkers[ 2 ].create_short_range( RadarIconID.SCHOOL, _2370, _2371, _2372 ).set_radar_mode( 2 );
            skoolMarkers[ 3 ].create_short_range( RadarIconID.SCHOOL, X_Driving_School, Y_Driving_School, Z_Driving_School ).set_radar_mode( 2 );

            Script.create_thread<CSCHOO>();
            Script.create_thread<PSCH>();
            Script.create_thread<BSCHOO>();
            Script.create_thread<BIKES>();
            Script.create_thread_wb<APCHECK>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class APCHECK : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"set_wb_check_to 0 
" + Airport_Open_Flag + @" = 0 
" + _1195 + @" = Object.Init(#WS_APGATE, -1543.742, -432.703, 6.039)
Object.Angle(" + _1195 + @") = -45.0
Object.RemoveFromMissionCleanupList(" + _1195 + @")
" + _1196 + @" = Object.Init(#WS_APGATE, -1547.625, -428.82, 6.039)
Object.Angle(" + _1196 + @") = -45.0
Object.RemoveFromMissionCleanupList(" + _1196 + @")
" + _1197 + @" = Object.Init(#WS_APGATE, -1222.953, 53.826, 14.134)
Object.Angle(" + _1197 + @") = -135.0
Object.RemoveFromMissionCleanupList(" + _1197 + @")
" + _1198 + @" = Object.Init(#WS_APGATE, -1218.206, 68.883, 14.134)
Object.Angle(" + _1198 + @") = -135.0
Object.RemoveFromMissionCleanupList(" + _1198 + @")
" + _1199 + @" = Object.Init(#WS_APGATE, 1964.342, -2189.776, 13.533)
Object.Angle(" + _1199 + @") = 180.0
Object.RemoveFromMissionCleanupList(" + _1199 + @")
" + _1200 + @" = Object.Init(#WS_APGATE, 1958.851, -2189.777, 13.553)
Object.Angle(" + _1200 + @") = 180.0
Object.RemoveFromMissionCleanupList(" + _1200 + @")
" + _1201 + @" = Object.Init(#WS_APGATE, 1704.777, 1605.165, 10.058)
Object.Angle(" + _1201 + @") = 73.0
Object.RemoveFromMissionCleanupList(" + _1201 + @")
" + _1202 + @" = Object.Init(#WS_APGATE, 1706.364, 1610.422, 10.058)
Object.Angle(" + _1202 + @") = 73.0
Object.RemoveFromMissionCleanupList(" + _1202 + @")

:APCHECK_318
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APCHECK_895 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere -1540.66 -435.786 6.039 radius 65.0 65.0 10.0 
else_jump @APCHECK_537 
if 
  " + ONMISSION_Mike_Toreno + @" == 1 
else_jump @APCHECK_468 
" + Airport_Open_Flag + @" = 1" );
                create_thread<APGUARD>( -1 );
                AppendLine( @"Object.PutAt(" + _1195 + @", -1540.66, -435.786, 6.039)
Object.PutAt(" + _1196 + @", -1550.709, -425.736, 6.039)
jump @APCHECK_530 

:APCHECK_468" );
                create_thread<APGUARD>( 1 );
                create_thread<APGATE>( _1195, -1540.66, -435.786, 6.039 );
                create_thread<APGATE>( _1196, -1550.709, -425.736, 6.039 );
                AppendLine( @"
:APCHECK_530
jump @APCHECK_1087 

:APCHECK_537
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 1968.697 -2189.776 13.553 radius 65.0 65.0 10.0 
else_jump @APCHECK_654" );
                create_thread<APGUARD>( 2 );
                create_thread<APGATE>( _1199, 1968.697, -2189.776, 13.553 );
                create_thread<APGATE>( _1200, 1954.571, -2189.777, 13.553 );
                AppendLine( @"jump @APCHECK_1547 

:APCHECK_654
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 1703.4 1600.518 10.058 radius 65.0 65.0 10.0 
else_jump @APCHECK_771" );
                create_thread<APGUARD>( 3 );
                create_thread<APGATE>( _1201, 1703.4, 1600.518, 10.058 );
                create_thread<APGATE>( _1202, 1707.722, 1614.937, 10.058 );
                AppendLine( @"jump @APCHECK_1777 

:APCHECK_771
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere -1226.162 65.3807 13.0375 radius 65.0 65.0 10.0 
else_jump @APCHECK_888" );
                create_thread<APGUARD>( 4 );
                create_thread<APGATE>( _1197, -1226.59, 50.189, 14.134 );
                create_thread<APGATE>( _1198, -1214.392, 72.697, 14.134 );
                AppendLine( @"jump @APCHECK_1317 

:APCHECK_888
jump @APCHECK_1080 

:APCHECK_895" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1195 + @", -1543.742, -432.703, 6.039)
Object.PutAt(" + _1196 + @", -1547.625, -428.82, 6.039)
Object.PutAt(" + _1197 + @", -1222.953, 53.826, 14.134)
Object.PutAt(" + _1198 + @", -1218.206, 68.883, 14.134)
Object.PutAt(" + _1199 + @", 1964.342, -2189.776, 13.533)
Object.PutAt(" + _1200 + @", 1958.851, -2189.777, 13.553)
Object.PutAt(" + _1201 + @", 1704.777, 1605.165, 10.058)
Object.PutAt(" + _1202 + @", 1706.364, 1610.422, 10.058)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1080
jump @APCHECK_318 

:APCHECK_1087
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APCHECK_1245 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere -1540.66 -435.786 6.039 radius 66.0 66.0 10.0 
else_jump @APCHECK_1238 
if 
  " + OnMission + @" == 0 
else_jump @APCHECK_1238" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1195 + @", -1543.742, -432.703, 6.039)
Object.PutAt(" + _1196 + @", -1547.625, -428.82, 6.039)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1238
jump @APCHECK_1310 

:APCHECK_1245" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1195 + @", -1543.742, -432.703, 6.039)
Object.PutAt(" + _1196 + @", -1547.625, -428.82, 6.039)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1310
jump @APCHECK_1087 

:APCHECK_1317
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APCHECK_1475 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere -1226.162 65.3807 13.0375 radius 66.0 66.0 10.0 
else_jump @APCHECK_1468 
if 
  " + OnMission + @" == 0 
else_jump @APCHECK_1468" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1197 + @", -1222.953, 53.826, 14.134)
Object.PutAt(" + _1198 + @", -1218.206, 68.883, 14.134)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1468
jump @APCHECK_1540 

:APCHECK_1475" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1197 + @", -1222.953, 53.826, 14.134)
Object.PutAt(" + _1198 + @", -1218.206, 68.883, 14.134)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1540
jump @APCHECK_1317 

:APCHECK_1547
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APCHECK_1705 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 1968.697 -2189.776 13.553 radius 66.0 66.0 10.0 
else_jump @APCHECK_1698 
if 
  " + OnMission + @" == 0 
else_jump @APCHECK_1698" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1199 + @", 1964.342, -2189.776, 13.533)
Object.PutAt(" + _1200 + @", 1958.851, -2189.777, 13.553)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1698
jump @APCHECK_1770 

:APCHECK_1705" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1199 + @", 1964.342, -2189.776, 13.533)
Object.PutAt(" + _1200 + @", 1958.851, -2189.777, 13.553)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1770
jump @APCHECK_1547 

:APCHECK_1777
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APCHECK_1935 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 1703.4 1600.518 10.058 radius 66.0 66.0 10.0 
else_jump @APCHECK_1928 
if 
  " + OnMission + @" == 0 
else_jump @APCHECK_1928" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1201 + @", 1704.777, 1605.165, 10.058)
Object.PutAt(" + _1202 + @", 1706.364, 1610.422, 10.058)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_1928
jump @APCHECK_2000 

:APCHECK_1935" );
                end_thread_named<APGATE>();
                AppendLine( @"Object.PutAt(" + _1201 + @", 1704.777, 1605.165, 10.058)
Object.PutAt(" + _1202 + @", 1706.364, 1610.422, 10.058)
" + Airport_Open_Flag + @" = 0 
jump @APCHECK_318 

:APCHECK_2000
jump @APCHECK_1777 
end_thread" );
            }

        }

        private sealed class APGUARD : Thread {

            Actor _local1 = local( 1 );

            public override void START( LabelJump label ) {
                AppendLine( @"3@ = 0 

:APGUARD_18
if 
   not Model.Available(#WMYSGRD)
else_jump @APGUARD_48 
Model.Load(#WMYSGRD)
wait 0 
jump @APGUARD_18 

:APGUARD_48
0871: init_jump_table 0@ total_jumps 5 default_jump 0 @APGUARD_333 jumps -1 @APGUARD_111 1 @APGUARD_169 2 @APGUARD_210 3 @APGUARD_251 4 @APGUARD_292 -1 @APGUARD_333 -1 @APGUARD_333 

:APGUARD_111
1@ = Actor.Create(CivMale, #WMYSGRD, -1544.88, -441.1089, 5.0068)
Actor.Angle(1@) = 7.3631
03FE: set_actor 1@ money 0 
Actor.RemoveFromMissionCleanupList(1@)
0762: AS_actor 1@ dies 
jump @APGUARD_333 

:APGUARD_169
1@ = Actor.Create(CivMale, #WMYSGRD, -1544.396, -443.2464, 5.045)
Actor.Angle(1@) = 54.6458
jump @APGUARD_333 

:APGUARD_210
1@ = Actor.Create(CivMale, #WMYSGRD, 1955.809, -2181.541, 12.5865)
Actor.Angle(1@) = 272.1978
jump @APGUARD_333 

:APGUARD_251
1@ = Actor.Create(CivMale, #WMYSGRD, 1717.202, 1617.376, 9.1924)
Actor.Angle(1@) = 186.0379
jump @APGUARD_333 

:APGUARD_292
1@ = Actor.Create(CivMale, #WMYSGRD, -1229.438, 55.3906, 13.2328)
Actor.Angle(1@) = 301.4596
jump @APGUARD_333 

:APGUARD_333
060B: set_actor 1@ decision_maker_to 65543 
02A9: set_actor 1@ immune_to_nonplayer 1 
Actor.RemoveFromMissionCleanupList(1@)

:APGUARD_355
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APGUARD_542 
if 
   not Actor.Dead(1@)
else_jump @APGUARD_528 
if 
8104:   not actor " + PlayerActor + @" near_actor 1@ radius 67.0 67.0 10.0 sphere 0 
else_jump @APGUARD_434 
gosub @APGUARD_883 

:APGUARD_434
if 
   not Actor.Dead(1@)
else_jump @APGUARD_493 
if 
0104:   actor " + PlayerActor + @" near_actor 1@ radius 15.0 15.0 15.0 sphere 0 
else_jump @APGUARD_493 
gosub @APGUARD_556 

:APGUARD_493
if 
051A:   actor 1@ damaged_by_actor " + PlayerActor + @" 
else_jump @APGUARD_521 
077A: set_actor 1@ acquaintance 4 to_actors_pedtype 0 

:APGUARD_521
jump @APGUARD_535 

:APGUARD_528
gosub @APGUARD_883 

:APGUARD_535
jump @APGUARD_549 

:APGUARD_542
gosub @APGUARD_883 

:APGUARD_549
jump @APGUARD_355 

:APGUARD_556
if 
0104:   actor " + PlayerActor + @" near_actor 1@ radius 5.0 5.0 3.0 sphere 0 
else_jump @APGUARD_881 
0652: 2@ = integer_stat 223 
if and
874F:   not actor 1@ ped_event == 36 
04B5:   2@ >= 180 
else_jump @APGUARD_757 
if 
  3@ == 0 
else_jump @APGUARD_750 
0209: 3@ = random_int_in_ranges 1 100 
if 
  3@ > 50 
else_jump @APGUARD_700 
05A9: " + Actor_Speech_GXT_Reference + @" = 'G_OPEN1' 
04AE: " + Actor_Speech_WAV_File + @" = 16802 
jump @APGUARD_722 

:APGUARD_700
05A9: " + Actor_Speech_GXT_Reference + @" = 'G_OPEN2' 
04AE: " + Actor_Speech_WAV_File + @" = 16803 

:APGUARD_722" );
                create_thread<AUDIOL>( _local1, 1, 1, 2, 0 );
                AppendLine( @"3@ = 1 
return 

:APGUARD_750
jump @APGUARD_881 

:APGUARD_757
if 
  3@ == 0 
else_jump @APGUARD_881 
0209: 3@ = random_int_in_ranges 1 100 
if 
  3@ > 50 
else_jump @APGUARD_831 
05A9: " + Actor_Speech_GXT_Reference + @" = 'G_CLOS1' 
04AE: " + Actor_Speech_WAV_File + @" = 16800 
jump @APGUARD_853 

:APGUARD_831
05A9: " + Actor_Speech_GXT_Reference + @" = 'G_CLOS2' 
04AE: " + Actor_Speech_WAV_File + @" = 16801 

:APGUARD_853" );
                create_thread<AUDIOL>( _local1, 1, 1, 2, 0 );
                AppendLine( @"3@ = 1 
return 

:APGUARD_881
return 

:APGUARD_883
if 
   Player.Defined(" + PlayerChar + @")
else_jump @APGUARD_935 
if 
  " + OnMission + @" == 0 
else_jump @APGUARD_928 
Actor.DestroyInstantly(1@)
Model.Destroy(#WMYSGRD)
end_thread 

:APGUARD_928
jump @APGUARD_946 

:APGUARD_935
Actor.DestroyInstantly(1@)
Model.Destroy(#WMYSGRD)
end_thread 

:APGUARD_946
return" );
            }

        }

        private sealed class APGATE : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"5@ = 0 
6@ = 0 
4@ = 0 
if 
  4@ > 0 
else_jump @APGATE_72 
0@ = Object.Init(#WS_APGATE, 0.0, 0.0, 0.0)

:APGATE_72
wait 0 
if and
03CA:   object 0@ exists 
   Player.Defined(" + PlayerChar + @")
else_jump @APGATE_104 
gosub @APGATE_111 

:APGATE_104
jump @APGATE_72 

:APGATE_111
0871: init_jump_table 5@ total_jumps 1 default_jump 0 @APGATE_188 jumps 0 @APGATE_174 -1 @APGATE_188 -1 @APGATE_188 -1 @APGATE_188 -1 @APGATE_188 -1 @APGATE_188 -1 @APGATE_188 

:APGATE_174
gosub @APGATE_190 
jump @APGATE_188 

:APGATE_188
return 

:APGATE_190
0871: init_jump_table 6@ total_jumps 4 default_jump 0 @APGATE_1046 jumps 0 @APGATE_253 1 @APGATE_692 2 @APGATE_828 3 @APGATE_910 -1 @APGATE_1046 -1 @APGATE_1046 -1 @APGATE_1046 

:APGATE_253
0652: 10@ = integer_stat 223 
if 
04B5:   10@ >= 180 
else_jump @APGATE_362 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 10.0 10.0 sphere 0 
else_jump @APGATE_355 
Object.StorePos(0@, 11@, 14@, 17@)
if 
03D0:   wav 3 loaded 
else_jump @APGATE_348 
097B: play_audio_at_object 0@ event 1100 

:APGATE_348
6@ += 1 

:APGATE_355
jump @APGATE_685 

:APGATE_362
if 
  " + Airport_Open_Flag + @" > 0 
else_jump @APGATE_462 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 10.0 10.0 sphere 0 
else_jump @APGATE_455 
Object.StorePos(0@, 11@, 14@, 17@)
if 
03D0:   wav 3 loaded 
else_jump @APGATE_448 
097B: play_audio_at_object 0@ event 1100 

:APGATE_448
6@ += 1 

:APGATE_455
jump @APGATE_685 

:APGATE_462
0400: store_coords_to 11@ 14@ 17@ from_object 0@ with_offset 0.0 5.2 0.0 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 11@ 14@ 17@ radius 4.5 4.5 4.5 
else_jump @APGATE_584 
Object.StorePos(0@, 11@, 14@, 17@)
if 
03D0:   wav 3 loaded 
else_jump @APGATE_570 
097B: play_audio_at_object 0@ event 1100 

:APGATE_570
6@ += 1 
jump @APGATE_685 

:APGATE_584
0400: store_coords_to 11@ 14@ 17@ from_object 0@ with_offset 0.0 -3.0 0.0 
if and
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 11@ 14@ 17@ radius 3.0 3.0 3.0 
  180 >= 10@ 
8A2A:   not text_box 'AP_0003' displayed  
else_jump @APGATE_685 
03E5: show_text_box 'AP_0003'  

:APGATE_685
jump @APGATE_1046 

:APGATE_692
gosub @APGATE_1048 
if 
034E: move_object 0@ to 1@ 2@ 3@ speed 13@ 16@ 19@ collision_check 1 
else_jump @APGATE_821 
if 
04E6:   object 0@ near_point 1@ 2@ 3@ radius 0.1 0.1 0.1 flag 0 
else_jump @APGATE_821 
Object.PutAt(0@, 1@, 2@, 3@)
if 
03D0:   wav 3 loaded 
else_jump @APGATE_814 
097B: play_audio_at_object 0@ event 1101 

:APGATE_814
6@ += 1 

:APGATE_821
jump @APGATE_1046 

:APGATE_828
if 
8471:   not actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 20.0 20.0 sphere 0 
else_jump @APGATE_903 
Object.StorePos(0@, 12@, 15@, 18@)
if 
03D0:   wav 3 loaded 
else_jump @APGATE_896 
097B: play_audio_at_object 0@ event 1100 

:APGATE_896
6@ += 1 

:APGATE_903
jump @APGATE_1046 

:APGATE_910
gosub @APGATE_1048 
if 
034E: move_object 0@ to 11@ 14@ 17@ speed 13@ 16@ 19@ collision_check 1 
else_jump @APGATE_1039 
if 
04E6:   object 0@ near_point 11@ 14@ 17@ radius 0.1 0.1 0.1 flag 0 
else_jump @APGATE_1039 
Object.PutAt(0@, 11@, 14@, 17@)
if 
03D0:   wav 3 loaded 
else_jump @APGATE_1032 
097B: play_audio_at_object 0@ event 1101 

:APGATE_1032
6@ = 0 

:APGATE_1039
jump @APGATE_1046 

:APGATE_1046
return 

:APGATE_1048
13@ = Object.Angle(0@)
if and
  13@ > 70.0 
  75.0 > 13@ 
else_jump @APGATE_1124 
13@ = 0.03 
16@ = 0.1 
19@ = 0.1 
jump @APGATE_1154 

:APGATE_1124
13@ = 0.1 
16@ = 0.1 
19@ = 0.1 

:APGATE_1154
return" );
            }

        }

        private sealed class PSCH : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":PSCH_34
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @PSCH_262 
if 
  " + OnMission + @" == 0 
else_jump @PSCH_262 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + _666 + @" " + _667 + @" " + _668 + @" radius 1.0 1.0 1.0 on_foot 
else_jump @PSCH_262 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @PSCH_262 
if 
  " + Toreno_Total_Passed_Missions + @" > 3 
else_jump @PSCH_262 
0169: set_fade_color_RGB 0 0 0 
" + OnMission + @" = 1 
if 
  " + Flight_School_Intro_Flag + @" == 0 
else_jump @PSCH_202" );
                print_gosub_PSAVE1_4206();
                AppendLine( @"" + Flight_School_Intro_Flag + @" = 1 
jump @PSCH_258 

:PSCH_202
0169: set_fade_color_RGB 0 0 0 
if 
  " + Mission_Learning_to_Fly_Passed + @" == 0 
else_jump @PSCH_244 
00BA: show_text_styled GXT 'DESERT5' time 1000 style 2

:PSCH_244
Player.CanMove(" + PlayerChar + @") = False" );
                print_gosub_LITCAS_268();
                AppendLine( @"
:PSCH_258" );
                start_mission<DESERT5>();
                AppendLine( @"
:PSCH_262
jump @PSCH_34 " );

            }

        }

        private sealed class BSCHOO : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":BSCHOO_34
wait 0 
if 
  " + OnMission + @" == 0 
else_jump @BSCHOO_148 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @BSCHOO_148 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + _2367 + @" " + _2368 + @" " + _2369 + @" radius 1.0 1.0 1.5 on_foot 
else_jump @BSCHOO_148 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @BSCHOO_148 
Player.CanMove(" + PlayerChar + @") = False" );
                print_gosub_LITCAS_268();
                start_mission<BOAT>();
                AppendLine( @"
:BSCHOO_148
jump @BSCHOO_34" );

            }

        }

        private sealed class BIKES : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":BIKES_34
wait 0 
if 
  " + OnMission + @" == 0 
else_jump @BIKES_148 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @BIKES_148 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + _2370 + @" " + _2371 + @" " + _2372 + @" radius 1.0 1.0 1.5 on_foot 
else_jump @BIKES_148 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @BIKES_148 
Player.CanMove(" + PlayerChar + @") = False" );
                print_gosub_LITCAS_268();
                start_mission<BSKOOL>();
                AppendLine( @"
:BIKES_148
jump @BIKES_34 " );

            }

        }

        private sealed class CSCHOO : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":CSCHOO_34
wait 0 
if 
  " + OnMission + @" == 0 
else_jump @CSCHOO_148 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @CSCHOO_148 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @CSCHOO_148 
077E: get_active_interior_to " + Active_Interior + @" 
if 
   not " + Active_Interior + @" == 0 
else_jump @CSCHOO_148 
if 
  " + Garage_Total_Passed_Missions + @" > 0 
else_jump @CSCHOO_148
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + X_Driving_School + @" " + Y_Driving_School + @" " + Z_Driving_School + @" radius 1.0 1.0 1.5 on_foot 
else_jump @CSCHOO_148 
" + OnMission + @" = 1 
0169: set_fade_color_RGB 0 0 0 
00BA: show_text_styled GXT 'FAR_1' time 1000 style 2
Player.CanMove(" + PlayerChar + @") = False" );
                print_gosub_LITCAS_268();
                start_mission<DSKOOL>();
                AppendLine( @"
:CSCHOO_148
jump @CSCHOO_34 " );

            }

        }

    }

}