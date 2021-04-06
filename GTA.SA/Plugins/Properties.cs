using System;
using System.Linq;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public enum BuyPropertyMessage : int { PROPERTY, HOTEL_NUMBER }

    public sealed class Properties {

        public static bool EnableAngarJetpack = true, EnableAngarAssetsMoneyPickup = true;

        private static Properties instance;
        private static bool isPluginSaveGameExist;
        private static Array<RadarMarker> hSaveGameMarkers;
        private static HandlerProperty defaultSetup = setup => {

            /* ---------------------------------------- LOS SANTOS -------------------------------------- */

            setup.add_property( 316.0696, -1772.569, 4.1893, 30000, action => {
                action.set_camera_position( 316.0747, -1786.757, 5.0712 )
                      .set_camera_point( 316.1206, -1785.778, 5.2692 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "BEACSV" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "BEACSV" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 1687.98, -2100.643, 13.3343, 10000, action => {
                action.set_camera_position( 1689.118, -2120.165, 18.6369 )
                      .set_camera_point( 1689.188, -2119.187, 18.4393 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "CARLAS1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "CARLAS1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 1331.186, -630.4962, 108.6349, 100000, action => {
                action.set_camera_position( 1325.974, -598.7552, 116.1597 )
                      .set_camera_point( 1326.254, -599.7052, 116.0219 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "CESAFE1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "CESAFE1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 892.6662, -1639.714, 14.4567, 10000, action => {
                action.set_camera_position( 894.7908, -1663.996, 20.202 )
                      .set_camera_point( 894.803, -1663.003, 20.0891 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            }, BuyPropertyMessage.HOTEL_NUMBER );

            setup.add_property( 2103.346, -1288.339, 23.8168, 10000, action => {
                action.set_camera_position( 2114.379, -1299.742, 32.8721 )
                      .set_camera_point( 2114.305, -1298.833, 32.4622 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 2483.024, -2001.074, 13.054, 10000, action => {
                action.set_camera_position( 2484.971, -2013.007, 17.5718 )
                      .set_camera_point( 2484.96, -2012.031, 17.3533 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            /* ---------------------------------------- LOS SANTOS: COUNTRISIDE -------------------------------------- */

            setup.add_property( 2236.928, 162.8057, 26.8462, 35000, action => {
                action.set_camera_position( 2233.14, 152.5748, 33.5239 )
                      .set_camera_point( 2233.16, 153.5324, 33.2366 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "BURBDOO" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "BURBDOO" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 793.5623, -514.4116, 16.3973, 40000, action => {
                action.set_camera_position( 789.7151, -529.9901, 20.74 )
                      .set_camera_point( 789.8545, -529.0045, 20.6445 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "BURBDO2" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "BURBDO2" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 207.6395, -107.5835, 4.8965, 10000, action => { // 206.8, -112.1, 4.3965
                action.set_camera_position( 189.8908, -107.1989, 5.7226 )
                      .set_camera_point( 190.8559, -107.2361, 5.4634 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            /* ---------------------------------------- SAN FIERRO: COUNTRISIDE -------------------------------------- */

            setup.add_property( -1439.014, -1540.59, 101.2579, 100000, action => {
                action.set_camera_position( -1437.184, -1507.732, 103.8198 )
                      .set_camera_point( -1437.047, -1508.711, 103.9666 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    Car carSanchez = Script.global(), carWalton = Script.global(), carTractor = Script.global();
                    Script.CAR_PARK.init( carSanchez, -1460.87, -1566.737, 101.0579, 2.0, 468, forceSpawn_bool: true );
                    Script.CAR_PARK.init( carWalton, -1446.239, -1494.731, 101.0514, 6.0, 478, forceSpawn_bool: true );
                    Script.CAR_PARK.init( carTractor, -1439.643, -1576.823, 101.0578, 264.1183, 531, forceSpawn_bool: true );
                    Script.CAR_PARK.set_to_player_owned( carSanchez, 1 ).set_chance_to_generate( carSanchez, 101 );
                    Script.CAR_PARK.set_to_player_owned( carWalton, 1 ).set_chance_to_generate( carWalton, 101 );
                    Script.CAR_PARK.set_to_player_owned( carTractor, 1 ).set_chance_to_generate( carTractor, 101 );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -2079.097, -2309.899, 30.1172, 20000, action => {
                action.set_camera_position( -2079.061, -2298.056, 35.15 )
                      .set_camera_point( -2078.88, -2299.029, 35.0066 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            /* ---------------------------------------- SAN FIERRO -------------------------------------- */

            setup.add_property( -2106.639, 900.5537, 76.2032, 120000, action => {
                action.set_camera_position( -2098.967, 923.2947, 80.2446 )
                      .set_camera_point( -2098.986, 922.2994, 80.3401 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "SAV1SFE" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "SAV1SFE" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -2695.745, 818.4718, 49.4844, 20000, action => {
                action.set_camera_position( -2700.657, 791.45, 70.2223 )
                      .set_camera_point( -2700.661, 792.4032, 69.9203 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "SAV1SFW" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "SAV1SFW" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -2456.926, -131.3292, 25.5376, 40000, action => {
                action.set_camera_position( -2476.432, -127.2039, 26.6779 )
                      .set_camera_point( -2475.458, -127.2469, 26.8974 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "SVGSFS1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "SVGSFS1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -2213.864, 723.5587, 48.914, 20000, action => {
                action.set_camera_position( -2213.188, 744.9976, 50.024 )
                      .set_camera_point( -2213.273, 744.0281, 50.254 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -2027.83, -44.0454, 38.7692, 20000, action => {
                action.set_camera_position( -2000.427, -64.4142, 40.0479 )
                      .set_camera_point( -2001.257, -63.8685, 40.1625 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -2419.677, 334.1621, 34.6796, 50000, action => {
                action.set_camera_position( -2379.854, 312.8534, 34.2136 )
                      .set_camera_point( -2380.683, 313.311, 34.5349 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            }, BuyPropertyMessage.HOTEL_NUMBER );

            /* ---------------------------------------- LAS VENTURAS: COUNTRISIDE -------------------------------------- */

            setup.add_property( -366.1849, 1166.031, 19.2422, 30000, action => {
                action.set_camera_position( -362.3164, 1152.664, 21.4821 )
                      .set_camera_point( -362.6989, 1153.587, 21.5142 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "CN2GAR1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "CN2GAR1" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -1534.17, 2650.3, 55.3437, 20000, action => {
                action.set_camera_position( -1545.093, 2663.056, 61.0133 )
                      .set_camera_point( -1544.282, 2662.509, 60.8075 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( -1045.775, 1552.976, 32.798, 20000, action => {
                action.set_camera_position( -1035.191, 1568.456, 39.7221 )
                      .set_camera_point( -1035.971, 1567.886, 39.4659 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 426.4972, 2530.689, 16.1, 80000, action => {
                action.set_camera_position( 445.128, 2540.436, 25.6202 )
                      .set_camera_point( 444.1882, 2540.142, 25.4462 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "CN2GAR2" );
                    Garage.deactivate( "DHANGAR" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "CN2GAR2" );
                    Garage.activate( "DHANGAR" );

                    if( EnableAngarJetpack ) {
                        Pickup jetpackPickup = Script.global();
                        jetpackPickup.create( 370, 15, 431.045, 2537.78, 16.24631 );
                    }
                    if( EnableAngarAssetsMoneyPickup ) {
                        AssetMoneyPickup moneyPickup = Script.global();
                        moneyPickup.create( 420.5204, 2532.687, 16.0869, 10000, 10000 );
                    }

                    Heli carLEVIATHN = Script.global();
                    Plane carHYDRA =   Script.global();
                    Bike carPCJ600 =   Script.global();

                    Script.CAR_PARK.init( carLEVIATHN, 383.178, 2538.891, 16.53, 180.0, 417, forceSpawn_bool: true );
                    Script.CAR_PARK.init( carHYDRA, 292.0, 2542.0, 16.0, 180.0, 520, forceSpawn_bool: true );
                    Script.CAR_PARK.init( carPCJ600, 435.2751, 2527.523, 16.371, 90.0, 461, forceSpawn_bool: true );

                    Script.CAR_PARK.set_to_player_owned( carLEVIATHN, 1 ).set_chance_to_generate( carLEVIATHN, 101 );
                    Script.CAR_PARK.set_to_player_owned( carHYDRA, 1 ).set_chance_to_generate( carHYDRA, 101 );
                    Script.CAR_PARK.set_to_player_owned( carPCJ600, 1 ).set_chance_to_generate( carPCJ600, 101 );

                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            /* ---------------------------------------- LAS VENTURAS -------------------------------------- */

            setup.add_property( 2441.002, 695.1089, 10.6646, 20000, action => {
                action.set_camera_position( 2430.869, 698.3348, 12.9763 )
                      .set_camera_point( 2431.789, 697.9644, 12.843 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "VESVGRG" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "VESVGRG" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 1283.844, 2528.703, 10.3203, 50000, action => {
                action.set_camera_position( 1295.982, 2525.57, 14.1002 )
                      .set_camera_point( 1294.994, 2525.724, 14.0597 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "BLOB69" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "BLOB69" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 922.3647, 2011.898, 10.766, 30000, action => {
                action.set_camera_position( 908.9885, 2006.151, 17.7914 )
                      .set_camera_point( 909.9134, 2006.143, 17.4113 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "BLOB7" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "BLOB7" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 1402.317, 1901.978, 10.8449, 30000, action => {
                action.set_camera_position( 1385.519, 1901.313, 14.5901 )
                      .set_camera_point( 1386.472, 1901.076, 14.4041 );
                action.BeforeCreate = delegate {
                    Garage.deactivate( "BLOB6" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Garage.activate( "BLOB6" );
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

            setup.add_property( 1969.932, 1623.243, 12.3619, 6000, action => {
                action.set_camera_position( 2036.76, 1623.074, 13.4128 )
                      .set_camera_point( 2035.8, 1623.087, 13.6921 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            }, BuyPropertyMessage.HOTEL_NUMBER );

            setup.add_property( 2234.909, 1285.698, 10.3203, 6000, action => {
                action.set_camera_position( 2146.165, 1286.25, 33.6386 )
                      .set_camera_point( 2147.164, 1286.218, 33.5943 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            }, BuyPropertyMessage.HOTEL_NUMBER );

            setup.add_property( 2370.477, 2165.474, 10.3269, 6000, action => {
                action.set_camera_position( 2342.496, 2140.662, 11.3215 )
                      .set_camera_point( 2343.243, 2141.272, 11.5827 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            }, BuyPropertyMessage.HOTEL_NUMBER );

            setup.add_property( 2220.626, 1837.348, 10.3203, 6000, action => {
                action.set_camera_position( 2119.739, 1767.835, 26.2058 )
                      .set_camera_point( 2120.53, 1768.447, 26.1978 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            }, BuyPropertyMessage.HOTEL_NUMBER );

            setup.add_property( 2819.125, 2149.372, 10.3203, 10000, action => {
                action.set_camera_position( 2820.361, 2174.83, 19.0746 )
                      .set_camera_point( 2820.384, 2173.834, 18.9889 );
                action.BeforeCreate = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, false );
                };
                action.AfterBuying = delegate {
                    Script.set_closest_entry_exit_flag( action.X, action.Y, 10.0, 16384, true );
                    if( isPluginSaveGameExist )
                        hSaveGameMarkers[ action.ID ].create_short_range( RadarIconID.SAVE_GAME, action.X, action.Y, action.Z ).set_radar_mode( 2 );
                };
            } );

        };

        // ---------------------------------------------------------------------------------------------------------------------------

        private ushort totalProperties;
        private PropertiesSetup propertiesSetup = new PropertiesSetup();

        // ---------------------------------------------------------------------------------------------------------------------------

        private Player p = Script.PlayerChar;
        private Actor a = Script.PlayerActor;

        // ---------------------------------------------------------------------------------------------------------------------------

        Int propertiesStatus = Script.global();

        Array<RadarMarker> hMarkers;
        Array<Pickup> hPickups;

        Int index = Script.local(); // 0@
        Float camX = Script.local(), // 1@
              camY = Script.local(), // 2@
              camZ = Script.local(), // 3@
              camPointX = Script.local(), // 4@
              camPointY = Script.local(), // 5@
              camPointZ = Script.local(), // 6@
              counter = Script.local(); // 7@

        sString message = Script.local(); // 30-31@

        // ---------------------------------------------------------------------------------------------------------------------------

        public Properties( SaveGame saveGame ) {
            if( saveGame == null )
                throw new Exception( Localization.PluginNeedDefaultModeInProperiesAndSaveGame( nameof( Properties ), nameof( SaveGame ) ) );
            if( !saveGame.isDefault )
                throw new Exception( Localization.PluginNeedDefaultModeInProperiesAndSaveGame( nameof( Properties ), nameof( SaveGame ) ) );
            isPluginSaveGameExist = true;
            new Properties( defaultSetup );
        }
        public Properties() : this( defaultSetup ) { }
        public Properties( HandlerProperty setup ) {
            if( instance != null )
                throw new Exception( Localization.PluginMustBeOnce( nameof( Properties ) ) );
            instance = this;
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( Properties ) ) );
            if( Script.Current.ScriptName == "MAIN" )
                throw new Exception( Localization.PluginCreatedInMainTrhead( nameof( Properties ) ) );
            if( setup == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( Properties ), nameof( HandlerProperty ) ) );

            setup.Invoke( propertiesSetup );
            totalProperties = ( ushort ) propertiesSetup.properties.Count;

            if( 1 > totalProperties )
                throw new Exception( Localization.PluginOverflowCountOfPropertiesOrZero( nameof( Properties ), PropertiesSetup.LIMIT ) );

            hMarkers = Script.global_array( totalProperties );
            hPickups = Script.global_array( totalProperties );
            if( isPluginSaveGameExist ) {
                hSaveGameMarkers = Script.global_array( ( ushort ) ( totalProperties + 7 ) );
                hSaveGameMarkers[ 30 ].create_short_range( RadarIconID.SAVE_GAME, 2495.53, -1711.88, 1014.24 ).set_radar_mode( 2 );
                if( SaveGame.isOverrided13point ) {
                    hSaveGameMarkers[ 31 ].create_short_range( RadarIconID.SAVE_GAME, SaveGame.px, SaveGame.py, SaveGame.pz ).set_radar_mode( 2 );
                } else {
                    hSaveGameMarkers[ 31 ].create_short_range( RadarIconID.SAVE_GAME, -2037.89, -2526.96, 30.13 ).set_radar_mode( 2 );
                }
                hSaveGameMarkers[ 32 ].create_short_range( RadarIconID.SAVE_GAME, 877.81, -26.91, 62.69 ).set_radar_mode( 2 );
                hSaveGameMarkers[ 33 ].create_short_range( RadarIconID.SAVE_GAME, -2026.481, 156.8028, 28.5391 ).set_radar_mode( 2 );
                hSaveGameMarkers[ 34 ].create_short_range( RadarIconID.SAVE_GAME, -693.3776, 957.824, 11.7829 ).set_radar_mode( 2 );
                hSaveGameMarkers[ 35 ].create_short_range( RadarIconID.SAVE_GAME, 2024.564, 996.4728, 10.3203 ).set_radar_mode( 2 );
                hSaveGameMarkers[ 36 ].create_short_range( RadarIconID.SAVE_GAME, 1263.05, -773.67, 1091.39 ).set_radar_mode( 2 );
            }
            for( ushort i = 0; i < totalProperties; i++ ) {
                var element = propertiesSetup.properties.ElementAt( i ).Value;
                if( !element.setup.isCameraPositionExist )
                    throw new Exception( Localization.PluginNeedSetCameraPositionInProperty( nameof( Properties ) ) );
                hMarkers[ i ].create_short_range( RadarIconID.PROPERTY_GREEN, element.setup.posX, element.setup.posY, element.setup.posZ ).set_radar_mode( 2 );
                hPickups[ i ].create_forsale_property( sString.FORSALE_PROPERTY, element.setup.posX, element.setup.posY, element.setup.posZ, element.setup.price );
                if( element.setup.beforeCreate != null )
                    element.setup.beforeCreate.Invoke();
            }
            Script.Jump += WAIT_DEFAULT;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void WAIT_DEFAULT( LabelJump label ) {
            Script.wait( Script.DefaultWaitTime );
            index.value = 0;
            counter.value = 0;
            Script.Jump += CHECK_BUYING;
        }

        private void CHECK_BUYING( LabelJump label ) {
            Script.and( is_property_buyed( index ), delegate {
                counter += 1;
                Script.and( counter >= totalProperties, delegate {
                    Script.Jump += END_SCRIPT;
                } );
            }, delegate {
                Script.and( hPickups[ index ].is_picked_up(), delegate {
                    Script.play_sound( 1149, 0.0, 0.0, 0.0 );
                    Script.set_fade_color_rgb( 0, 0, 1 );
                    Script.fade( FadeType.OUT, Script.DefaultWaitTime );
                    p.can_move( false ).ignored_by_everyone( true );

                    Script.wait( Script.is_fading() );

                    Script.enable_widescreen( true );
                    hPickups[ index ].destroy();
                    hMarkers[ index ].disable();
                    propertiesStatus.set_bit( index );
                    Script.Jump += SHOW_BUY_SCENE;
                } );
            } );
            index += 1;
            Script.and( index >= totalProperties, delegate {
                Script.jump( WAIT_DEFAULT );
            } );
            Script.jump( label );
        }

        private void END_SCRIPT( LabelJump label ) {
            Script.end_thread();
        }

        private void SHOW_BUY_SCENE( LabelJump label ) {
            message.value = "BUYPRO"; // ­eљўњ›њЇoc¦© Јpњo—pe¦e®a!
            Script.jump_table( index, table => {
                for( ushort i = 0; i < totalProperties; i++ ) {
                    var element = propertiesSetup.properties.ElementAt( i ).Value;
                    table.label( i, l => {
                        Script.increment_int_stat( StatsID.PROPERTY_BUDGET, element.setup.price );
                        camX.value = element.setup.cameraX;
                        camY.value = element.setup.cameraY;
                        camZ.value = element.setup.cameraZ;
                        if( element.setup.isCameraPointExist ) {
                            camPointX.value = element.setup.cameraPointX;
                            camPointY.value = element.setup.cameraPointY;
                            camPointZ.value = element.setup.cameraPointZ;
                        } else {
                            camPointX.value = element.setup.posX;
                            camPointY.value = element.setup.posY;
                            camPointZ.value = element.setup.posZ;
                        }
                        if( element.message == BuyPropertyMessage.HOTEL_NUMBER )
                            message.value = "HSUITE"; // ­Њpњo—pe¦e® ®oЇep ў o¦eћe!
                        if( element.setup.afterBuying != null )
                            element.setup.afterBuying.Invoke();
                        Script.jump( table.EndLabel );
                    } );
                }
            } );

            Script.CAMERA.set_position( camX, camY, camZ ).set_point_at( camPointX, camPointY, camPointZ, 2 );
            Script.remove_text_box();
            Script.text_clear_all();
            Script.set_fade_color_rgb( 0, 0, 1 );
            Script.fade( FadeType.IN, Script.DefaultWaitTime );

            Script.wait( !Script.is_fading() );

            Script.show_text_styled( message, 5000, 2 );
            Script.play_music( MusicID.PROPERTY_BUYED );
            Script.wait( 6000 );
            Script.enable_widescreen( false );
            Script.and( p.is_defined(), delegate {
                Script.CAMERA.set_behind_player().restore_with_jumpcut();
                p.can_move( true ).ignored_by_everyone( false );
            } );
            Script.jump( WAIT_DEFAULT );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_property_buyed( Int id ) { return propertiesStatus.is_bit_set( id ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}