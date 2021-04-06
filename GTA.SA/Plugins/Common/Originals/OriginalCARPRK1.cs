using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalCARPARK : Original {

        internal OriginalCARPARK() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() { }
        internal override void Update() {
            Script.and( Script.PlayerChar.is_defined(), delegate {
                Script.and( Script.PlayerActor.is_in_area_2d( 0, 2037.536, 2365.373, 2117.177, 2483.922 ), delegate {
                    Script.get_external_script_status<CARPRK1>( Original.ScriptStatus );
                    Script.and( Original.ScriptStatus == 0, delegate {
                        Script.load_external_script<CARPRK1>();
                        Script.and( Script.is_external_script_loaded<CARPRK1>(), delegate {
                            Script.start_new_external_script<CARPRK1>();
                        } );
                    } );
                }, delegate { Script.remove_references_external_script<CARPRK1>(); } );
            } );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class CARPRK1 : External {

            public override void START( LabelJump label ) {
                AppendLine( @"set_wb_check_to 0 
0@ = 0 
1@ = 0 
2@ = 0 
3@ = 0 
4@ = 0 
5@ = 0 
6@ = 0 
7@ = 0 
8@ = 0 
9@ = 0 

:CARPRK1_85
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @CARPRK1_2769 
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2037.568 2366.152 9.8203 cornerB 2119.283 2472.418 14.1172 
else_jump @CARPRK1_251 
if 
  0@ == 0 
else_jump @CARPRK1_244 
03C5: create_random_car_for_carpark 2077.872 2398.657 9.8203 z_angle 89.6383 
03C5: create_random_car_for_carpark 2087.099 2414.177 9.8203 z_angle 90.4575 
03C5: create_random_car_for_carpark 2104.859 2416.439 9.8203 z_angle 270.7819 
0@ = 1 

:CARPRK1_244
jump @CARPRK1_308 

:CARPRK1_251
if 
  0@ == 1 
else_jump @CARPRK1_308 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 9.8203 cornerB 2117.283 2441.002 14.1172 
0@ = 0 

:CARPRK1_308
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 13.1172 cornerB 2119.283 2441.002 18.4219 
else_jump @CARPRK1_520 
if 
  1@ == 0 
else_jump @CARPRK1_513 
03C5: create_random_car_for_carpark 2104.537 2412.3 14.1172 z_angle 89.9851 
03C5: create_random_car_for_carpark 2095.321 2398.559 14.1172 z_angle 90.1384 
03C5: create_random_car_for_carpark 2087.071 2405.525 14.1172 z_angle 267.6596 
03C5: create_random_car_for_carpark 2087.187 2420.887 14.1172 z_angle 90.4995 
03C5: create_random_car_for_carpark 2078.36 2410.139 14.1172 z_angle 270.9704 
03C5: create_random_car_for_carpark 2069.168 2396.778 14.1172 z_angle 98.3338 
1@ = 1 

:CARPRK1_513
jump @CARPRK1_577 

:CARPRK1_520
if 
  1@ == 1 
else_jump @CARPRK1_577 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 14.1172 cornerB 2117.283 2441.002 18.4219 
1@ = 0 

:CARPRK1_577
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 17.4219 cornerB 2119.283 2441.002 22.7188 
else_jump @CARPRK1_789 
if 
  2@ == 0 
else_jump @CARPRK1_782 
03C5: create_random_car_for_carpark 2104.517 2405.886 18.4219 z_angle 92.3912 
03C5: create_random_car_for_carpark 2095.688 2396.195 18.4219 z_angle 270.3566 
03C5: create_random_car_for_carpark 2087.0 2416.442 18.4219 z_angle 89.9821 
03C5: create_random_car_for_carpark 2086.925 2402.896 18.4219 z_angle 270.2662 
03C5: create_random_car_for_carpark 2069.071 2409.651 18.4219 z_angle 89.1894 
03C5: create_random_car_for_carpark 2078.146 2416.5 18.4219 z_angle 270.7297 
2@ = 1 

:CARPRK1_782
jump @CARPRK1_846 

:CARPRK1_789
if 
  2@ == 1 
else_jump @CARPRK1_846 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 18.4219 cornerB 2117.283 2441.002 22.7188 
2@ = 0 

:CARPRK1_846
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 21.7188 cornerB 2119.283 2441.002 27.0234 
else_jump @CARPRK1_1058 
if 
  3@ == 0 
else_jump @CARPRK1_1051 
03C5: create_random_car_for_carpark 2104.499 2411.852 22.7188 z_angle 90.7897 
03C5: create_random_car_for_carpark 2104.483 2407.618 22.7188 z_angle 91.9516 
03C5: create_random_car_for_carpark 2087.242 2400.854 22.7188 z_angle 269.9636 
03C5: create_random_car_for_carpark 2078.313 2412.077 22.7188 z_angle 267.6149 
03C5: create_random_car_for_carpark 2069.138 2396.251 22.7188 z_angle 92.2442 
03C5: create_random_car_for_carpark 2078.179 2392.021 22.7188 z_angle 87.7661 
3@ = 1 

:CARPRK1_1051
jump @CARPRK1_1115 

:CARPRK1_1058
if 
  3@ == 1 
else_jump @CARPRK1_1115 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 22.7188 cornerB 2117.283 2441.002 27.0234 
3@ = 0 

:CARPRK1_1115
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 24.7815 cornerB 2119.283 2441.002 31.3203 
else_jump @CARPRK1_1327 
if 
  4@ == 0 
else_jump @CARPRK1_1320 
03C5: create_random_car_for_carpark 2069.661 2416.422 27.0234 z_angle 268.612 
03C5: create_random_car_for_carpark 2077.872 2398.657 27.0234 z_angle 89.6383 
03C5: create_random_car_for_carpark 2087.195 2394.364 27.0234 z_angle 271.5008 
03C5: create_random_car_for_carpark 2087.099 2414.177 27.0234 z_angle 90.4575 
03C5: create_random_car_for_carpark 2095.818 2398.686 27.0234 z_angle 268.2181 
03C5: create_random_car_for_carpark 2104.859 2416.439 27.0234 z_angle 270.7819 
4@ = 1 

:CARPRK1_1320
jump @CARPRK1_1384 

:CARPRK1_1327
if 
  4@ == 1 
else_jump @CARPRK1_1384 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 27.0234 cornerB 2117.283 2441.002 31.3203 
4@ = 0 

:CARPRK1_1384
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 30.3203 cornerB 2119.283 2441.002 35.6172 
else_jump @CARPRK1_1596 
if 
  5@ == 0 
else_jump @CARPRK1_1589 
03C5: create_random_car_for_carpark 2104.537 2412.3 31.3203 z_angle 89.9851 
03C5: create_random_car_for_carpark 2095.321 2398.559 31.3203 z_angle 90.1384 
03C5: create_random_car_for_carpark 2087.071 2405.525 31.3203 z_angle 267.6596 
03C5: create_random_car_for_carpark 2087.187 2420.887 31.3203 z_angle 90.4995 
03C5: create_random_car_for_carpark 2078.36 2410.139 31.3203 z_angle 270.9704 
03C5: create_random_car_for_carpark 2069.168 2396.778 31.3203 z_angle 98.3338 
5@ = 1 

:CARPRK1_1589
jump @CARPRK1_1653 

:CARPRK1_1596
if 
  5@ == 1 
else_jump @CARPRK1_1653 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 31.3203 cornerB 2117.283 2441.002 35.6172 
5@ = 0 

:CARPRK1_1653
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 34.6172 cornerB 2119.283 2441.002 39.9219 
else_jump @CARPRK1_1865 
if 
  6@ == 0 
else_jump @CARPRK1_1858 
03C5: create_random_car_for_carpark 2104.517 2405.886 35.6172 z_angle 92.3912 
03C5: create_random_car_for_carpark 2095.688 2396.195 35.6172 z_angle 270.3566 
03C5: create_random_car_for_carpark 2087.0 2416.442 35.6172 z_angle 89.9821 
03C5: create_random_car_for_carpark 2086.925 2402.896 35.6172 z_angle 270.2662 
03C5: create_random_car_for_carpark 2069.071 2409.651 35.6172 z_angle 89.1894 
03C5: create_random_car_for_carpark 2078.146 2416.5 35.6172 z_angle 270.7297 
6@ = 1 

:CARPRK1_1858
jump @CARPRK1_1922 

:CARPRK1_1865
if 
  6@ == 1 
else_jump @CARPRK1_1922 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 35.6172 cornerB 2117.283 2441.002 39.9219 
6@ = 0 

:CARPRK1_1922
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 38.9219 cornerB 2119.283 2441.002 44.2188 
else_jump @CARPRK1_2134 
if 
  7@ == 0 
else_jump @CARPRK1_2127 
03C5: create_random_car_for_carpark 2104.499 2411.852 39.9219 z_angle 90.7897 
03C5: create_random_car_for_carpark 2104.483 2407.618 39.9219 z_angle 91.9516 
03C5: create_random_car_for_carpark 2087.242 2400.854 39.9219 z_angle 269.9636 
03C5: create_random_car_for_carpark 2078.313 2412.077 39.9219 z_angle 267.6149 
03C5: create_random_car_for_carpark 2069.138 2396.251 39.9219 z_angle 92.2442 
03C5: create_random_car_for_carpark 2078.179 2392.021 39.9219 z_angle 87.7661 
7@ = 1 

:CARPRK1_2127
jump @CARPRK1_2191 

:CARPRK1_2134
if 
  7@ == 1 
else_jump @CARPRK1_2191 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 39.9219 cornerB 2117.283 2441.002 44.2188 
7@ = 0 

:CARPRK1_2191
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 43.2188 cornerB 2119.283 2441.002 48.5234 
else_jump @CARPRK1_2403 
if 
  8@ == 0 
else_jump @CARPRK1_2396 
03C5: create_random_car_for_carpark 2069.661 2416.422 44.2188 z_angle 268.612 
03C5: create_random_car_for_carpark 2077.872 2398.657 44.2188 z_angle 89.6383 
03C5: create_random_car_for_carpark 2087.195 2394.364 44.2188 z_angle 271.5008 
03C5: create_random_car_for_carpark 2087.099 2414.177 44.2188 z_angle 90.4575 
03C5: create_random_car_for_carpark 2095.818 2398.686 44.2188 z_angle 268.2181 
03C5: create_random_car_for_carpark 2104.859 2416.439 44.2188 z_angle 270.7819 
8@ = 1 

:CARPRK1_2396
jump @CARPRK1_2460 

:CARPRK1_2403
if 
  8@ == 1 
else_jump @CARPRK1_2460 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 44.2188 cornerB 2117.283 2441.002 48.5234 
8@ = 0 

:CARPRK1_2460
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2052.432 2366.152 44.5234 cornerB 2119.283 2441.002 55.9123 
else_jump @CARPRK1_2672 
if 
  9@ == 0 
else_jump @CARPRK1_2665 
03C5: create_random_car_for_carpark 2104.537 2412.3 48.5234 z_angle 89.9851 
03C5: create_random_car_for_carpark 2095.321 2398.559 48.5234 z_angle 90.1384 
03C5: create_random_car_for_carpark 2087.071 2405.525 48.5234 z_angle 267.6596 
03C5: create_random_car_for_carpark 2087.187 2420.887 48.5234 z_angle 90.4995 
03C5: create_random_car_for_carpark 2078.36 2410.139 48.5234 z_angle 270.9704 
03C5: create_random_car_for_carpark 2069.168 2396.778 48.5234 z_angle 98.3338 
9@ = 1 

:CARPRK1_2665
jump @CARPRK1_2729 

:CARPRK1_2672
if 
  9@ == 1 
else_jump @CARPRK1_2729 
03BA: clear_cars_from_cube_cornerA 2052.432 2366.152 48.5234 cornerB 2117.283 2441.002 52.9123 
9@ = 0 

:CARPRK1_2729
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 2037.536 2365.373 cornerB 2119.9 2483.922 
else_jump @CARPRK1_2769 
end_thread 

:CARPRK1_2769
jump @CARPRK1_85 
end_thread" );

            }

        }

    }

}