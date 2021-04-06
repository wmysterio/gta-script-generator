using GTA.Core;

namespace GTA.Plugins.Common {

    internal partial class OriginalRases : Original {

        internal OriginalRases() : base() { }

        private static Car carPark_2786 = Script.global(), carPark_2787 = Script.global(), carPark_2788 = Script.global(), carPark_5275 = Script.global(), carPark_5188 = Script.global();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.CAR_PARK.init( carPark_2786, 2692.029, -1674.024, 9.4656, 178.8279, 556, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2787, 2676.695, -1673.756, 9.4038, 178.8279, 494, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_2788, 1105.1937, 1614.6265, 12.8156, 86.1912, 495, forceSpawn_bool: true, carColor1: 118, carColor2: 119 );
            Script.CAR_PARK.init( carPark_5275, 1092.6581, 1615.6495, 13.47, 278.7626, 573, forceSpawn_bool: true );
            Script.CAR_PARK.init( carPark_5188, -2151.0, -409.1, 34.1, 307.2, 504, forceSpawn_bool: true );
            Script.CAR_PARK.set_to_player_owned( carPark_2786, true ).set_chance_to_generate( carPark_2786, 0 );
            Script.CAR_PARK.set_to_player_owned( carPark_2787, true ).set_chance_to_generate( carPark_2787, 0 );
            Script.CAR_PARK.set_to_player_owned( carPark_2788, true ).set_chance_to_generate( carPark_2788, 0 );
            Script.CAR_PARK.set_to_player_owned( carPark_5275, true ).set_chance_to_generate( carPark_5275, 0 );
            Script.CAR_PARK.set_to_player_owned( carPark_5188, true ).set_chance_to_generate( carPark_5188, 0 );

            X_Race_Tournament_Point[ 0 ].value = 1766.134;
            Y_Race_Tournament_Point[ 0 ].value = -1704.228;
            Z_Race_Tournament_Point[ 0 ].value = 12.4731;
            X_Race_Tournament_Point[ 1 ].value = -1922.922;
            Y_Race_Tournament_Point[ 1 ].value = 282.7151;
            Z_Race_Tournament_Point[ 1 ].value = 40.0391;
            X_Race_Tournament_Point[ 2 ].value = 1636.916;
            Y_Race_Tournament_Point[ 2 ].value = 912.9478;
            Z_Race_Tournament_Point[ 2 ].value = 9.689;
            X_Race_Tournament_Point[ 3 ].value = 1701.69;
            Y_Race_Tournament_Point[ 3 ].value = 1649.193;
            Z_Race_Tournament_Point[ 3 ].value = 9.6296;
            Races_Best_Result[ 0 ].value = 999999999;
            Races_Best_Result[ 1 ].value = 999999999;
            Races_Best_Result[ 2 ].value = 999999999;
            Races_Best_Result[ 3 ].value = 999999999;
            Races_Best_Result[ 4 ].value = 999999999;
            Races_Best_Result[ 5 ].value = 999999999;
            Races_Best_Result[ 6 ].value = 999999999;
            Races_Best_Result[ 7 ].value = 999999999;
            Races_Best_Result[ 8 ].value = 999999999;
            Races_Best_Result[ 9 ].value = 999999999;
            Races_Best_Result[ 10 ].value = 999999999;
            Races_Best_Result[ 11 ].value = 999999999;
            Races_Best_Result[ 12 ].value = 999999999;
            Races_Best_Result[ 13 ].value = 999999999;
            Races_Best_Result[ 14 ].value = 999999999;
            Races_Best_Result[ 15 ].value = 999999999;
            Races_Best_Result[ 16 ].value = 999999999;
            Races_Best_Result[ 17 ].value = 999999999;
            Races_Best_Result[ 18 ].value = 999999999;
            Races_Best_Result[ 19 ].value = 999999999;
            Races_Best_Result[ 20 ].value = 999999999;
            Races_Best_Result[ 21 ].value = 999999999;
            Races_Best_Result[ 22 ].value = 999999999;
            Races_Best_Result[ 23 ].value = 999999999;
            Races_Best_Result[ 24 ].value = 999999999;
            Races_Best_Result[ 25 ].value = 999999999;
            Races_Best_Result[ 26 ].value = 999999999;
            Races_Best_Result[ 27 ].value = 999999999;
            Races_Best_Result[ 28 ].value = 999999999;
            Races_Best_Result[ 29 ].value = 999999999;
            Races_Current_Best_Time[ 0 ].value = 999999999;
            Races_Current_Best_Time[ 1 ].value = 999999999;
            Races_Current_Best_Time[ 2 ].value = 999999999;
            Races_Current_Best_Time[ 3 ].value = 999999999;
            Races_Current_Best_Time[ 4 ].value = 999999999;
            Races_Current_Best_Time[ 5 ].value = 999999999;
            Races_Current_Best_Time[ 6 ].value = 999999999;
            Races_Current_Best_Time[ 7 ].value = 999999999;
            Races_Current_Best_Time[ 8 ].value = 999999999;
            Races_Current_Best_Time[ 9 ].value = 999999999;
            Races_Current_Best_Time[ 10 ].value = 999999999;
            Races_Current_Best_Time[ 11 ].value = 999999999;
            Races_Current_Best_Time[ 12 ].value = 999999999;
            Races_Current_Best_Time[ 13 ].value = 999999999;
            Races_Current_Best_Time[ 14 ].value = 999999999;
            Races_Current_Best_Time[ 15 ].value = 999999999;
            Races_Current_Best_Time[ 16 ].value = 999999999;
            Races_Current_Best_Time[ 17 ].value = 999999999;
            Races_Current_Best_Time[ 18 ].value = 999999999;
            Races_Current_Best_Time[ 19 ].value = 999999999;
            Races_Current_Best_Time[ 20 ].value = 999999999;
            Races_Current_Best_Time[ 21 ].value = 999999999;
            Races_Current_Best_Time[ 22 ].value = 999999999;
            Races_Current_Best_Time[ 23 ].value = 999999999;
            Races_Current_Best_Time[ 24 ].value = 999999999;
            Races_Current_Best_Time[ 25 ].value = 999999999;
            Races_Current_Best_Time[ 26 ].value = 999999999;
            Races_Current_Best_Time[ 27 ].value = 999999999;
            Races_Current_Best_Time[ 28 ].value = 999999999;
            Races_Current_Best_Time[ 29 ].value = 999999999;
            Races_New_Best_Time[ 0 ].value = 999999999;
            Races_New_Best_Time[ 1 ].value = 999999999;
            Races_New_Best_Time[ 2 ].value = 999999999;
            Races_New_Best_Time[ 3 ].value = 999999999;
            Races_New_Best_Time[ 4 ].value = 999999999;
            Races_New_Best_Time[ 5 ].value = 999999999;
            Races_New_Best_Time[ 6 ].value = 999999999;
            Races_New_Best_Time[ 7 ].value = 999999999;
            Races_New_Best_Time[ 8 ].value = 999999999;
            Races_New_Best_Time[ 9 ].value = 999999999;
            Races_New_Best_Time[ 10 ].value = 999999999;
            Races_New_Best_Time[ 11 ].value = 999999999;
            Races_New_Best_Time[ 12 ].value = 999999999;
            Races_New_Best_Time[ 13 ].value = 999999999;
            Races_New_Best_Time[ 14 ].value = 999999999;
            Races_New_Best_Time[ 15 ].value = 999999999;
            Races_New_Best_Time[ 16 ].value = 999999999;
            Races_New_Best_Time[ 17 ].value = 999999999;
            Races_New_Best_Time[ 18 ].value = 999999999;
            Races_New_Best_Time[ 19 ].value = 999999999;
            Races_New_Best_Time[ 20 ].value = 999999999;
            Races_New_Best_Time[ 21 ].value = 999999999;
            Races_New_Best_Time[ 22 ].value = 999999999;
            Races_New_Best_Time[ 23 ].value = 999999999;
            Races_New_Best_Time[ 24 ].value = 999999999;
            Races_New_Best_Time[ 25 ].value = 999999999;
            Races_New_Best_Time[ 26 ].value = 999999999;
            Races_New_Best_Time[ 27 ].value = 999999999;
            Races_New_Best_Time[ 28 ].value = 999999999;
            Races_New_Best_Time[ 29 ].value = 999999999;

            _1398.value = 1;
            _1940.value = 1;

            _1742.value = 1099.551;
            _1743.value = 1601.497;
            _1744.value = 11.5546;
            _1745.value = -2120.042;
            _1746.value = -444.2838;
            _1747.value = 34.5312;
            _1748.value = 2695.624;
            _1749.value = -1704.688;
            _1750.value = 10.8437;

            Array<RadarMarker> tournametMarkers = Script.global_array( 3 );
            tournametMarkers[ 0 ].create_short_range( RadarIconID.STADIUM_TOURNAMENT, _1742, _1743, _1744 );
            tournametMarkers[ 1 ].create_short_range( RadarIconID.STADIUM_TOURNAMENT, _1745, _1746, _1747 );
            tournametMarkers[ 2 ].create_short_range( RadarIconID.STADIUM_TOURNAMENT, _1748, _1749, _1750 );

            Script.create_thread<TRACE>();
            Script.create_thread<BLOODR>();
            Script.create_thread<HOTR>();
            Script.create_thread<KICKS>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class TRACE : Thread {

            Float tmp_X_Race_Tournament_Point = global( X_Race_Tournament_Point.startIndex ),
                  tmp_Y_Race_Tournament_Point = global( Y_Race_Tournament_Point.startIndex ),
                  tmp_Z_Race_Tournament_Point = global( Z_Race_Tournament_Point.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"0570: " + _528 + @" = create_asset_radar_marker_with_icon 53 at " + tmp_X_Race_Tournament_Point + @"[0] " + tmp_Y_Race_Tournament_Point + @"[0] " + tmp_Z_Race_Tournament_Point + @"[0] 
0570: " + _529 + @" = create_asset_radar_marker_with_icon 53 at " + tmp_X_Race_Tournament_Point + @"[1] " + tmp_Y_Race_Tournament_Point + @"[1] " + tmp_Z_Race_Tournament_Point + @"[1] 
0570: " + _530 + @" = create_asset_radar_marker_with_icon 53 at " + tmp_X_Race_Tournament_Point + @"[2] " + tmp_Y_Race_Tournament_Point + @"[2] " + tmp_Z_Race_Tournament_Point + @"[2] 
0570: " + _531 + @" = create_asset_radar_marker_with_icon 53 at " + tmp_X_Race_Tournament_Point + @"[3] " + tmp_Y_Race_Tournament_Point + @"[3] " + tmp_Z_Race_Tournament_Point + @"[3] 

:TRACE_98
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRACE_892 
if 
  " + OnMission + @" == 0 
else_jump @TRACE_892 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @TRACE_892 
if 
  " + _1398 + @" == 1 
else_jump @TRACE_892 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tmp_X_Race_Tournament_Point + @"[0] " + tmp_Y_Race_Tournament_Point + @"[0] " + tmp_Z_Race_Tournament_Point + @"[0] radius 1.2 1.2 2.0 on_foot 
else_jump @TRACE_622 
" + OnMission + @" = 1 
Player.CanMove(" + PlayerChar + @") = False
00BA: show_text_styled GXT 'TRACE_1' time 1000 style 2  
" + Custom_Tournament_Flag + @" = 1 
04AE: " + Current_Tournament + @" = 0" );
                start_mission<CPRACE>();
                AppendLine( @"
:TRACE_622
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tmp_X_Race_Tournament_Point + @"[1] " + tmp_Y_Race_Tournament_Point + @"[1] " + tmp_Z_Race_Tournament_Point + @"[1] radius 1.2 1.2 2.0 on_foot 
else_jump @TRACE_712 
" + OnMission + @" = 1 
Player.CanMove(" + PlayerChar + @") = False
00BA: show_text_styled GXT 'TRACE_1' time 1000 style 2  
" + Custom_Tournament_Flag + @" = 1 
04AE: " + Current_Tournament + @" = 1 " );
                start_mission<CPRACE>();
                AppendLine( @"
:TRACE_712
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tmp_X_Race_Tournament_Point + @"[2] " + tmp_Y_Race_Tournament_Point + @"[2] " + tmp_Z_Race_Tournament_Point + @"[2] radius 1.2 1.2 2.0 on_foot 
else_jump @TRACE_802 
" + OnMission + @" = 1 
Player.CanMove(" + PlayerChar + @") = False
00BA: show_text_styled GXT 'TRACE_1' time 1000 style 2  
" + Custom_Tournament_Flag + @" = 1 
04AE: " + Current_Tournament + @" = 2 " );
                start_mission<CPRACE>();
                AppendLine( @"
:TRACE_802
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tmp_X_Race_Tournament_Point + @"[3] " + tmp_Y_Race_Tournament_Point + @"[3] " + tmp_Z_Race_Tournament_Point + @"[3] radius 1.2 1.2 2.0 on_foot 
else_jump @TRACE_892 
" + OnMission + @" = 1 
Player.CanMove(" + PlayerChar + @") = False
00BA: show_text_styled GXT 'TRACE_1' time 1000 style 2  
" + Custom_Tournament_Flag + @" = 1 
04AE: " + Current_Tournament + @" = 3 " );
                start_mission<CPRACE>();
                AppendLine( @"
:TRACE_892
jump @TRACE_98" );

            }

        }

        private sealed class BLOODR : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":BLOODR_11
wait " + DefaultWaitTime + @" 
if 
  " + OnMission + @" == 0 
else_jump @BLOODR_135 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @BLOODR_135 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _1745 + @" " + _1746 + @" " + _1747 + @" radius 1.4 1.8 1.5 on_foot 
else_jump @BLOODR_135 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @BLOODR_135" );
                print_gosub_LITCAS_268();
                AppendLine( @"00BA: show_text_styled GXT 'STAD_04' time 1000 style 2" );
                start_mission<BLOOD>();
                AppendLine( @"
:BLOODR_135
jump @BLOODR_11" );
            }

        }

        private sealed class HOTR : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":HOTR_11
wait " + DefaultWaitTime + @" 
if 
  " + OnMission + @" == 0 
else_jump @HOTR_199 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @HOTR_199 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _1748 + @" " + _1749 + @" " + _1750 + @" radius 1.4 1.8 1.5 on_foot 
else_jump @HOTR_199 
0652: " + STAT_Driving_Skill + @" = integer_stat 160 
if 
  " + STAT_Driving_Skill + @" > 199 
else_jump @HOTR_183 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @HOTR_176 
00BA: show_text_styled GXT 'STAD_03' time 1000 style 2" );
                print_gosub_LITCAS_268();
                AppendLine( @"04AE: " + Race_Index + @" = 25 // = constant 
" + Custom_Tournament_Flag + @" = 0" );
                start_mission<CPRACE>();
                AppendLine( @"
:HOTR_176
jump @HOTR_199 

:HOTR_183
00BC: show_text_highpriority GXT 'STATCAR' time 500 flag 1

:HOTR_199
jump @HOTR_11" );
            }

        }

        private sealed class KICKS : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":KICKS_59
wait " + DefaultWaitTime + @" 
if 
  " + OnMission + @" == 0 
else_jump @KICKS_318 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @KICKS_318 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + _1742 + @" " + _1743 + @" " + _1744 + @" radius 1.4 1.8 1.5 on_foot 
else_jump @KICKS_318 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @KICKS_318 
07D0: " + Weekday + @" = weekday 
if or
  " + Weekday + @" == 0 
  " + Weekday + @" == 2 
  " + Weekday + @" == 4 
else_jump @KICKS_291 
0652: " + STAT_Driving_Skill + @" = integer_stat 229 
if 
  " + STAT_Driving_Skill + @" > 199 
else_jump @KICKS_268 
00BA: show_text_styled GXT 'STAD_01' time 1000 style 2" );
                print_gosub_LITCAS_268();
                AppendLine( @"04AE: " + Race_Index + @" = 26 // = constant 
" + Custom_Tournament_Flag + @" = 0" );
                start_mission<CPRACE>();
                AppendLine( @"jump @KICKS_284 

:KICKS_268
00BC: show_text_highpriority GXT 'STATBIK' time 500 flag 1

:KICKS_284
jump @KICKS_318 

:KICKS_291
00BA: show_text_styled GXT 'STAD_02' time 1000 style 2" );
                print_gosub_LITCAS_268();
                start_mission<KICKSTA>();
                AppendLine( @"
:KICKS_318
jump @KICKS_59" );
            }

        }

    }

}