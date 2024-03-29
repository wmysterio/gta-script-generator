﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class CASAMB : External {

            Int _local0 = local( 0 ),
                _local1 = local( 1 ),
                _local5 = local( 5 ),
                _local6 = local( 6 ),
                _local7 = local( 7 ),
                _local8 = local( 8 ),
                _local9 = local( 9 ),
                _local10 = local( 10 ),
                _local11 = local( 11 ),
                _local12 = local( 12 ),
                _local16 = local( 16 ),
                _local17 = local( 17 ),
                _local18 = local( 18 ),
                _local19 = local( 19 ),
                _local20 = local( 20 );

            public override void START( LabelJump label ) {
                AppendLine( @"if 
  " + OnMission + @" == 0 
jf @CASAMB_43 
" + _9470 + @" = 0 
" + _9471 + @" = 0 

:CASAMB_43
1@ = 1 
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_91 
Model.Load(#VMAFF1)
Model.Load(#VMAFF3)
Model.Load(#VMAFF2)
Model.Load(#VWFYWAI)

:CASAMB_91
if 
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
jf @CASAMB_130 
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
Model.Load(#VWFYWA2)

:CASAMB_130
if 
08F9:   " + Active_Interior_Name + @" == ""CASINO2"" 
jf @CASAMB_170 
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
Model.Load(#VWFYCRP)

:CASAMB_170
04ED: load_animation ""BAR"" 

:CASAMB_177
if 
84EE:   not animation ""BAR"" loaded 
jf @CASAMB_206 
wait 0 
jump @CASAMB_177 

:CASAMB_206
0615: define_AS_pack_begin 2@ 
0605: actor -1 perform_animation ""BARSERVE_IN"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0605: actor -1 perform_animation ""BARSERVE_LOOP"" IFP ""BAR"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 10000 
0616: define_AS_pack_end 2@ 
0615: define_AS_pack_begin 3@ 
0605: actor -1 perform_animation ""BARSERVE_BOTTLE"" IFP ""BAR"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -1 
0616: define_AS_pack_end 3@ 
0615: define_AS_pack_begin 4@ 
05DE: AS_actor -1 walk_around_ped_path 
0616: define_AS_pack_end 4@ 
if 
   Player.Defined(" + PlayerChar + @")
jf @CASAMB_1779 
0297: reset_player " + PlayerChar + @" destroyed_model_counters 
if 
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
jf @CASAMB_928 
061D: create_AS_origin_at 1953.774 1018.197 991.4766 Z_angle 260.0 unknown_angle 90.0 AS_pack 2@ handle_as 5@ 
061D: create_AS_origin_at 1952.286 1025.58 991.4745 Z_angle 260.0 unknown_angle 90.0 AS_pack 2@ handle_as 6@ 
061D: create_AS_origin_at 1952.3 1010.296 991.4745 Z_angle 260.0 unknown_angle 90.0 AS_pack 2@ handle_as 7@ 
061D: create_AS_origin_at 1952.25 1017.92 991.4766 Z_angle 90.0 unknown_angle 260.0 AS_pack 3@ handle_as 8@ 
061D: create_AS_origin_at 1948.073 1016.505 991.4766 Z_angle 90.0 unknown_angle 180.0 AS_pack 2@ handle_as 9@ 
061D: create_AS_origin_at 1948.564 1022.182 991.4766 Z_angle 90.0 unknown_angle 180.0 AS_pack 2@ handle_as 10@ 
061D: create_AS_origin_at 1949.246 1013.613 991.4766 Z_angle 90.0 unknown_angle 180.0 AS_pack 2@ handle_as 11@ 
061D: create_AS_origin_at 1949.0 1015.8 991.4766 Z_angle 275.0 unknown_angle 85.0 AS_pack 3@ handle_as 12@ 
0621: create_actor_pedtype 5 model #VWFYWA2 at_AS_origin 5@ task 1466 handle_as 16@ 
0621: create_actor_pedtype 5 model #VWFYWA2 at_AS_origin 9@ task 1466 handle_as 17@" );
                start_new_external_script<BARSTAF>( _local16, _local5, _local6, _local7, _local8, 2.5 );
                start_new_external_script<BARSTAF>( _local17, _local9, _local10, _local11, _local12, 2.5 );
                load_external_script<BARSTAF>();
AppendLine( @"061D: create_AS_origin_at 1966.539 984.8237 993.4688 Z_angle 270.0 unknown_angle 270.0 AS_pack 4@ handle_as 13@ 
061D: create_AS_origin_at 1932.395 1033.886 993.4688 Z_angle 60.0 unknown_angle 300.0 AS_pack 4@ handle_as 14@ 
061D: create_AS_origin_at 1959.094 993.7656 991.4766 Z_angle 240.0 unknown_angle 240.0 AS_pack 4@ handle_as 15@ 
0621: create_actor_pedtype 6 model #BMYBOUN at_AS_origin 13@ task 1502 handle_as 18@ 
0621: create_actor_pedtype 6 model #WMYBOUN at_AS_origin 14@ task 1502 handle_as 19@ 
0621: create_actor_pedtype 6 model #BMYBOUN at_AS_origin 15@ task 1502 handle_as 20@" );
                start_new_external_script<BOUNCER>( _local18 );
                start_new_external_script<BOUNCER>( _local19 );
                start_new_external_script<BOUNCER>( _local20 );
                load_external_script<BOUNCER>();
AppendLine( @"
:CASAMB_928
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_1474 
061D: create_AS_origin_at 2195.73 1600.786 1004.063 Z_angle 206.0 unknown_angle -206.0 AS_pack 2@ handle_as 5@ 
061D: create_AS_origin_at 2197.012 1602.852 1004.063 Z_angle 253.0 unknown_angle -253.0 AS_pack 2@ handle_as 6@ 
061D: create_AS_origin_at 2195.786 1606.363 1004.063 Z_angle 349.0 unknown_angle -349.0 AS_pack 2@ handle_as 7@ 
061D: create_AS_origin_at 2196.137 1603.521 1004.063 Z_angle 98.0 unknown_angle -98.0 AS_pack 3@ handle_as 8@ 
061D: create_AS_origin_at 2191.592 1601.286 1004.063 Z_angle 151.0 unknown_angle -151.0 AS_pack 2@ handle_as 9@ 
061D: create_AS_origin_at 2191.176 1604.874 1004.063 Z_angle 58.0 unknown_angle -58.0 AS_pack 2@ handle_as 10@ 
061D: create_AS_origin_at 2192.425 1606.971 1004.063 Z_angle 40.0 unknown_angle -40.0 AS_pack 2@ handle_as 11@ 
061D: create_AS_origin_at 2192.954 1605.687 1004.069 Z_angle 207.0 unknown_angle -207.0 AS_pack 3@ handle_as 12@ 
0621: create_actor_pedtype 5 model #VWFYWAI at_AS_origin 5@ task 1466 handle_as 16@ 
0621: create_actor_pedtype 5 model #VWFYWAI at_AS_origin 9@ task 1466 handle_as 17@" );
                start_new_external_script<BARSTAF>( _local16, _local5, _local6, _local7, _local8, 3.5 );
                start_new_external_script<BARSTAF>( _local17, _local9, _local10, _local11, _local12, 3.5 );
                load_external_script<BARSTAF>();
AppendLine( @"061D: create_AS_origin_at 2247.869 1624.467 1007.367 Z_angle 152.0 unknown_angle -152.0 AS_pack 4@ handle_as 13@ 
061D: create_AS_origin_at 2247.349 1583.257 1007.366 Z_angle 358.0 unknown_angle -358.0 AS_pack 4@ handle_as 14@ 
061D: create_AS_origin_at 2164.643 1582.151 1007.359 Z_angle 13.0 unknown_angle -13.0 AS_pack 4@ handle_as 15@ 
0621: create_actor_pedtype 6 model #VMAFF1 at_AS_origin 13@ task 1502 handle_as 18@ 
0621: create_actor_pedtype 6 model #VMAFF2 at_AS_origin 14@ task 1502 handle_as 19@ 
0621: create_actor_pedtype 6 model #VMAFF3 at_AS_origin 15@ task 1502 handle_as 20@" );
                start_new_external_script<BOUNCER>( _local18 );
                start_new_external_script<BOUNCER>( _local19 );
                start_new_external_script<BOUNCER>( _local20 );
                load_external_script<BOUNCER>();
AppendLine( @"
:CASAMB_1474
if 
08F9:   " + Active_Interior_Name + @" == ""CASINO2"" 
jf @CASAMB_1779 
061D: create_AS_origin_at 1141.206 -5.9198 999.6719 Z_angle 81.0 unknown_angle -81.0 AS_pack 2@ handle_as 5@ 
061D: create_AS_origin_at 1141.831 -8.994 999.6797 Z_angle 94.0 unknown_angle -94.0 AS_pack 2@ handle_as 6@ 
061D: create_AS_origin_at 1141.161 1.224 999.6719 Z_angle 110.0 unknown_angle -110.0 AS_pack 2@ handle_as 7@ 
061D: create_AS_origin_at 1141.159 -3.9906 999.6797 Z_angle 93.0 unknown_angle -93.0 AS_pack 3@ handle_as 8@ 
0621: create_actor_pedtype 5 model #VWFYCRP at_AS_origin 5@ task 1466 handle_as 16@" );
                start_new_external_script<BARSTAF>( _local16, _local5, _local6, _local7, _local8, ( double ) 2.0 );
                load_external_script<BARSTAF>();
AppendLine( @"9@ = -1 
10@ = -1 
11@ = -1 
12@ = -1 
061D: create_AS_origin_at 1143.677 6.4929 999.6797 Z_angle 71.0 unknown_angle -71.0 AS_pack 4@ handle_as 13@ 
0621: create_actor_pedtype 6 model #BMYBOUN at_AS_origin 13@ task 1502 handle_as 18@" );
                start_new_external_script<BOUNCER>( _local18 );
                load_external_script<BOUNCER>();
AppendLine( @"14@ = -1 
15@ = -1 

:CASAMB_1779
if 
   Player.Defined(" + PlayerChar + @")
jf @CASAMB_3006 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @CASAMB_1835 
jump @CASAMB_3017 

:CASAMB_1835
if 
02E0:   actor " + PlayerActor + @" firing_weapon 
jf @CASAMB_1865 
" + _9470 + @" = 1 
" + _9471 + @" = 1 

:CASAMB_1865
0806: get_player " + PlayerChar + @" kills_from_last_checkpoint 0@ 
if 
  0@ > 0 
jf @CASAMB_1898 
" + _9471 + @" = 1 

:CASAMB_1898
if 
   Player.WantedLevel(" + PlayerChar + @") > " + Player_Wanted_Level + @"
jf @CASAMB_1924 
" + _9471 + @" = 1 

:CASAMB_1924
0@ = 0 

:CASAMB_1931
if 
   not Actor.Dead(16@(0@,11i))
jf @CASAMB_2039 
if and
0457:   player " + PlayerChar + @" aiming_at_actor 16@(0@,11i) 
82D8:   not actor " + PlayerActor + @" current_weapon == 56 
jf @CASAMB_2002 
" + _9470 + @" = 1 
" + _9471 + @" = 1 
jump @CASAMB_2039 

:CASAMB_2002
if 
051A:   actor 16@(0@,11i) damaged_by_actor " + PlayerActor + @" 
jf @CASAMB_2039 
" + _9470 + @" = 1 
" + _9471 + @" = 1 

:CASAMB_2039
0@ += 1 
  0@ >= 11 
jf @CASAMB_1931 
if 
  " + _9470 + @" == 1 
jf @CASAMB_2144 
" + _9471 + @" = 1 
08E5: get_actor_in_sphere 27@ 28@ 29@ radius 50.0 handle_as 0@ 
if 
  0@ > -1 
jf @CASAMB_2144 
1@ += 1 " );
                start_new_external_script<FFPNC>( _local0, _local1 );
                load_external_script<FFPNC>();
                AppendLine( @"
:CASAMB_2144
if 
  " + _9471 + @" == 1 
jf @CASAMB_3006 
if and
   Actor.Dead(18@)
   not 13@ == -1 
jf @CASAMB_2480 
if 
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
jf @CASAMB_2239 
27@ = 1966.539 
28@ = 984.8237 
29@ = 993.4688 

:CASAMB_2239
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_2293 
27@ = 2247.869 
28@ = 1624.467 
29@ = 1007.367 

:CASAMB_2293
if 
08F9:   " + Active_Interior_Name + @" == ""CASINO2"" 
jf @CASAMB_2348 
27@ = 1143.677 
28@ = 6.4929 
29@ = 999.6797 

:CASAMB_2348
if and
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 27@ 28@ 29@ radius 8.0 8.0 8.0 
80C2:   not sphere_onscreen 27@ 28@ 29@ radius 3.0 
jf @CASAMB_2480 
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_2452 
0621: create_actor_pedtype 4 model #VMAFF1 at_AS_origin 13@ task 1502 handle_as 18@ 
jump @CASAMB_2468 

:CASAMB_2452
0621: create_actor_pedtype 6 model #BMYBOUN at_AS_origin 13@ task 1502 handle_as 18@ 

:CASAMB_2468" );
                start_new_external_script<BOUNCER>( _local18 );
                load_external_script<BOUNCER>();
AppendLine( @"
:CASAMB_2480
if and
   Actor.Dead(19@)
   not 14@ == -1 
jf @CASAMB_2743 
if 
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
jf @CASAMB_2557 
27@ = 1932.395 
28@ = 1033.886 
29@ = 993.4688 

:CASAMB_2557
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_2611 
27@ = 2247.349 
28@ = 1583.257 
29@ = 1007.366 

:CASAMB_2611
if and
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 27@ 28@ 29@ radius 8.0 8.0 8.0 
80C2:   not sphere_onscreen 27@ 28@ 29@ radius 3.0 
jf @CASAMB_2743 
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_2715 
0621: create_actor_pedtype 6 model #VMAFF2 at_AS_origin 14@ task 1502 handle_as 19@ 
jump @CASAMB_2731 

:CASAMB_2715
0621: create_actor_pedtype 6 model #WMYBOUN at_AS_origin 14@ task 1502 handle_as 19@ 

:CASAMB_2731" );
                start_new_external_script<BOUNCER>( _local19 );
                load_external_script<BOUNCER>();
AppendLine( @"
:CASAMB_2743
if and
   Actor.Dead(20@)
   not 15@ == -1 
jf @CASAMB_3006 
if 
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
jf @CASAMB_2820 
27@ = 1959.094 
28@ = 993.7656 
29@ = 991.4766 

:CASAMB_2820
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_2874 
27@ = 2164.643 
28@ = 1582.151 
29@ = 1007.359 

:CASAMB_2874
if and
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 27@ 28@ 29@ radius 8.0 8.0 8.0 
80C2:   not sphere_onscreen 27@ 28@ 29@ radius 3.0 
jf @CASAMB_3006 
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @CASAMB_2978 
0621: create_actor_pedtype 4 model #VMAFF3 at_AS_origin 15@ task 1502 handle_as 20@ 
jump @CASAMB_2994 

:CASAMB_2978
0621: create_actor_pedtype 6 model #WMYBOUN at_AS_origin 15@ task 1502 handle_as 20@ 

:CASAMB_2994" );
                start_new_external_script<BOUNCER>( _local20 );
                load_external_script<BOUNCER>();
AppendLine( @"
:CASAMB_3006
wait 0 
jump @CASAMB_1779 

:CASAMB_3017
0@ = 0 

:CASAMB_3024
Actor.RemoveReferences(16@(0@,11i))
Actor.DestroyInstantly(16@(0@,11i))
0@ += 1 
  0@ >= 11 
jf @CASAMB_3024 
0@ = 0 

:CASAMB_3070
if 
   not 5@(0@,11i) == -1 
jf @CASAMB_3101 
061E: remove_references_to_AS_origin 5@(0@,11i) 

:CASAMB_3101
0@ += 1 
  0@ >= 11 
jf @CASAMB_3070 
04EF: release_animation ""BAR"" 
Model.Destroy(#VWFYWAI)
Model.Destroy(#VWFYWA2)
Model.Destroy(#VWFYCRP)
Model.Destroy(#BMYBOUN)
Model.Destroy(#WMYBOUN)
Model.Destroy(#VMAFF1)
Model.Destroy(#VMAFF2)
Model.Destroy(#VMAFF3)
061B: remove_references_to_AS_pack 2@ 
061B: remove_references_to_AS_pack 3@ 
061B: remove_references_to_AS_pack 4@ 
end_thread 
end_thread" );
            }

        }

    }

}