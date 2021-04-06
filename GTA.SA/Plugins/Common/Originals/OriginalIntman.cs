using GTA.Core;

namespace GTA.Plugins.Common {

    internal partial class OriginalIntman : Original {

        internal OriginalIntman() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Valet_Uniform_Available.value = 1;
            Croupier_Uniform_Available.value = 1;
            Gimp_Suit_Available.value = 1;
            Rural_Clothes_Available.value = 1;

            Float[] CLOTH_X = new Float[] { 2243.807, 1458.7, -1886.1, 2574.3, 2090.5, 2112.8, 2772.0, 1654.0, 2105.7, 501.7, 2818.6, 457.2, 2795.2, 451.9, -2371.1, -1692.9, -2489.0 };
            Float[] CLOTH_Y = new Float[] { -1668.567, -1140.0, 862.4, 1901.7, 2221.0, -1214.7, 2447.6, 1733.4, 2257.4, -1358.5, 2401.5, -1500.7, 2424.6, -1480.0, 910.2, 952.8, -26.9 };
            Float[] CLOTH_Z = new Float[] { 20.0313, 24.2, 35.2, 11.0, 11.0, 23.9, 11.0, 11.0, 11.0, 16.4, 11.0, 31.3, 11.0, 30.9, 47.2, 26.3, 32.6 };
            Array<RadarMarker> clothMarkers = Script.global_array( ( ushort ) CLOTH_X.Length );
            for( ushort i = 0; i < CLOTH_X.Length; i++ )
                clothMarkers[ i ].create_short_range( RadarIconID.TSHIRT, CLOTH_X[ i ], CLOTH_Y[ i ], CLOTH_Z[ i ] ).set_radar_mode( 2 );
            Script.set_interior_access( "CSCHP", 1 );
            Script.set_interior_access( "CSSPRT", 1 );
            Script.set_interior_access( "LACS1", 1 );
            Script.set_interior_access( "CLOTHGP", 1 );
            Script.set_interior_access( "CSDESGN", 1 );
            Script.set_interior_access( "CSEXL", 1 );

            Float[] BARB_X = new Float[] { 2070.27, 822.6, -2570.1, 2726.6, 2080.3, 675.7, -1449.869 };
            Float[] BARB_Y = new Float[] { -1791.092, -1590.3, 245.4, -2026.4, 2119.0, -496.6, 2593.85 };
            Float[] BARB_Z = new Float[] { 17.1484, 13.5, 10.3, 17.5, 10.8, 16.8, 54.8359 };
            Array<RadarMarker> barbMarkers = Script.global_array( ( ushort ) BARB_X.Length );
            for( ushort i = 0; i < BARB_X.Length; i++ )
                barbMarkers[ i ].create_short_range( RadarIconID.BARBERS, BARB_X[ i ], BARB_Y[ i ], BARB_Z[ i ] ).set_radar_mode( 2 );
            Script.set_interior_access( "BARBERS", 1 );
            Script.set_interior_access( "BARBER2", 1 );
            Script.set_interior_access( "BARBER3", 1 );

            Float[] PIZZA_X = new Float[] { 2107.624, -1805.7, 2750.9, 2351.8, 2635.5, 2083.4, -1719.1, 2330.2, 203.2, 1365.549 };
            Float[] PIZZA_Y = new Float[] { -1807.516, 943.2, 2470.9, 2529.0, 1847.4, 2221.0, 1359.4, 75.2, -200.4, 249.0039 };
            Float[] PIZZA_Z = new Float[] { 21.2114, 24.8, 11.0, 10.8, 11.0, 11.0, 8.6, 31.0, 6.5, 18.5669 };
            Float[] CHICKEN_X = new Float[] { 2397.8, 2421.6, -2671.6, 2392.4, 2844.5, 2635.5, 2105.7, -2154.0, -1816.2, -1216.0, 172.73, 932.0 };
            Float[] CHICKEN_Y = new Float[] { -1895.6, -1509.6, 257.4, 2046.5, 2401.1, 1674.3, 2228.7, -2461.2, 620.8, 1831.4, 1176.76, -1353.0 };
            Float[] CHICKEN_Z = new Float[] { 13.7, 24.1, 4.6, 10.8, 11.0, 11.0, 11.0, 30.8, 37.5, 45.3, 13.7, 14.0, };
            Float[] BURGER_X = new Float[] { 812.9, 1199.1, 2362.2, 2469.5, 2172.9, 1875.3, 1161.5, -2356.0, -1913.3, -2335.6 };
            Float[] BURGER_Y = new Float[] { -1616.1, -924.0, 2069.9, 2033.8, 2795.7, 2072.0, 2072.0, 1009.0, 826.2, -165.6 };
            Float[] BURGER_Z = new Float[] { 13.6, 43.3, 10.8, 10.8, 10.8, 10.8, 10.8, 49.0, 36.9, 39.5 };
            Array<RadarMarker> pizzaMarkers = Script.global_array( ( ushort ) PIZZA_X.Length );
            Array<RadarMarker> chickenMarkers = Script.global_array( ( ushort ) CHICKEN_X.Length );
            Array<RadarMarker> burgerMarkers = Script.global_array( ( ushort ) BURGER_X.Length );
            for( ushort i = 0; i < PIZZA_X.Length; i++ )
                pizzaMarkers[ i ].create_short_range( RadarIconID.PIZZA, PIZZA_X[ i ], PIZZA_Y[ i ], PIZZA_Z[ i ] ).set_radar_mode( 2 );
            for( ushort i = 0; i < CHICKEN_X.Length; i++ )
                chickenMarkers[ i ].create_short_range( RadarIconID.CHICKEN, CHICKEN_X[ i ], CHICKEN_Y[ i ], CHICKEN_Z[ i ] ).set_radar_mode( 2 );
            for( ushort i = 0; i < BURGER_X.Length; i++ )
                burgerMarkers[ i ].create_short_range( RadarIconID.BURGER_SHOT, BURGER_X[ i ], BURGER_Y[ i ], BURGER_Z[ i ] ).set_radar_mode( 2 );
            Script.set_interior_access( "FDPIZA", 1 );
            Script.set_interior_access( "FDCHICK", 1 );
            Script.set_interior_access( "FDBURG", 1 );

            Float[] TATTOO_X = new Float[] { 1971.7, 2071.6, 2094.6, -2490.5 };
            Float[] TATTOO_Y = new Float[] { -2036.6, -1779.9, 2119.0, -40.1 };
            Float[] TATTOO_Z = new Float[] { 13.5, 13.5, 10.8, 39.3 };
            Array<RadarMarker> tatooMarkers = Script.global_array( ( ushort ) TATTOO_X.Length );
            for( ushort i = 0; i < TATTOO_X.Length; i++ )
                tatooMarkers[ i ].create_short_range( RadarIconID.TATTOO, TATTOO_X[ i ], TATTOO_Y[ i ], TATTOO_Z[ i ] ).set_radar_mode( 2 );
            Script.set_interior_access( "TATTOO", 1 );
            Script.set_interior_access( "TATTO2", 1 );
            Script.set_interior_access( "TATTO3", 1 );

            Float[] AMMU_X = new Float[] { 1372.9, 2400.5, -2626.6, 2535.9, 2156.5, 779.7, -2092.7, 240.0, -1509.4, -315.67, 2332.9 };
            Float[] AMMU_Y = new Float[] { -1278.8, -1978.4, 209.4, 2083.5, 943.2, 1874.3, -2463.8, -178.2, 2611.8, 829.87, 63.6 };
            Float[] AMMU_Z = new Float[] { 12.5, 13.5, 4.9, 10.8, 10.8, 4.9, 30.6, 2.0, 58.5, 13.43, 31.0 };
            Array<RadarMarker> ammuMarkers = Script.global_array( ( ushort ) AMMU_X.Length );
            for( ushort i = 0; i < AMMU_X.Length; i++ )
                ammuMarkers[ i ].create_short_range_for_mission( RadarIconID.AMMUNATION, AMMU_X[ i ], AMMU_Y[ i ], AMMU_Z[ i ] ).set_radar_mode( 2 );
            Script.set_interior_access( "AMMUN1", 1 );
            Script.set_interior_access( "AMMUN2", 1 );
            Script.set_interior_access( "AMMUN3", 1 );
            Script.set_interior_access( "AMMUN4", 1 );
            Script.set_interior_access( "AMMUN5", 1 );

            Script.set_interior_access( "RCPLAY", 1 );

            Script.set_interior_access( "CHANGER", 1 );

            Script.set_interior_access( "TRICAS", 1 );
            Script.set_interior_access( "MAFCAS", 1 );
            Script.set_interior_access( "CASINO2", 1 );

            Script.set_interior_access( "BAR1", 1 );
            Script.set_interior_access( "BAR2", 1 );
            Script.set_interior_access( "UFOBAR", 1 );

            Script.set_interior_access( "GENOTB", 1 );

            Script.set_interior_access( "LASTRIP", 1 );
            Script.set_interior_access( "STRIP2", 1 );

            #region SETUP CASINO OBJECT AND POSITION

            Int tmp_3658 = Script.global( _3658.startIndex ),
                tmp_3507 = Script.global( _3507.startIndex ),
                tmp_3811 = Script.global( _3811.startIndex ),
                tmp_3814 = Script.global( _3814.startIndex ),
                tmp_3817 = Script.global( _3817.startIndex ),
                tmp_3820 = Script.global( _3820.startIndex ),
                tmp_3826 = Script.global( _3826.startIndex ),
                tmp_3828 = Script.global( _3828.startIndex ),
                tmp_3830 = Script.global( _3830.startIndex ),
                tmp_3867 = Script.global( _3867.startIndex ),
                tmp_3870 = Script.global( _3870.startIndex ),
                tmp_3873 = Script.global( _3873.startIndex ),
                tmp_3876 = Script.global( _3876.startIndex ),
                tmp_3879 = Script.global( _3879.startIndex ),
                tmp_3885 = Script.global( _3885.startIndex ),
                tmp_3887 = Script.global( _3887.startIndex ),
                tmp_3889 = Script.global( _3889.startIndex ),
                tmp_3926 = Script.global( _3926.startIndex ),
                tmp_3413 = Script.global( _3413.startIndex ),
                tmp_3431 = Script.global( _3431.startIndex ),
                tmp_3449 = Script.global( _3449.startIndex );

            Script.AppendLine( @"" + _3407 + @" = 25 
" + _3408 + @" = 100 
" + _3409 + @" = 250 
" + _3410 + @" = 500 
" + _3411 + @" = 1000 
" + _3412 + @" = 5000 
0084: " + tmp_3413 + @"[0] = " + _3412 + @" 
0084: " + tmp_3413 + @"[1] = " + _3409 + @" 
0084: " + tmp_3413 + @"[2] = " + _3411 + @" 
0084: " + tmp_3413 + @"[3] = " + _3410 + @" 
0084: " + tmp_3413 + @"[4] = " + _3407 + @" 
0084: " + tmp_3413 + @"[5] = " + _3408 + @" 
0084: " + tmp_3413 + @"[6] = " + _3407 + @" 
0084: " + tmp_3413 + @"[7] = " + _3408 + @" 
0084: " + tmp_3413 + @"[8] = " + _3410 + @" 
0084: " + tmp_3413 + @"[9] = " + _3409 + @" 
0084: " + tmp_3413 + @"[10] = " + _3410 + @" 
0084: " + tmp_3413 + @"[11] = " + _3411 + @" 
0084: " + tmp_3413 + @"[12] = " + _3407 + @" 
0084: " + tmp_3413 + @"[13] = " + _3408 + @" 
0084: " + tmp_3413 + @"[14] = " + _3409 + @" 
0084: " + tmp_3413 + @"[15] = " + _3408 + @" 
0084: " + tmp_3413 + @"[16] = " + _3410 + @" 
0084: " + tmp_3413 + @"[17] = " + _3407 + @" 
0084: " + tmp_3431 + @"[0] = " + _3409 + @" 
0084: " + tmp_3431 + @"[1] = " + _3410 + @" 
0084: " + tmp_3431 + @"[2] = " + _3407 + @" 
0084: " + tmp_3431 + @"[3] = " + _3408 + @" 
0084: " + tmp_3431 + @"[4] = " + _3412 + @" 
0084: " + tmp_3431 + @"[5] = " + _3410 + @" 
0084: " + tmp_3431 + @"[6] = " + _3408 + @" 
0084: " + tmp_3431 + @"[7] = " + _3407 + @" 
0084: " + tmp_3431 + @"[8] = " + _3410 + @" 
0084: " + tmp_3431 + @"[9] = " + _3411 + @" 
0084: " + tmp_3431 + @"[10] = " + _3408 + @" 
0084: " + tmp_3431 + @"[11] = " + _3409 + @" 
0084: " + tmp_3431 + @"[12] = " + _3407 + @" 
0084: " + tmp_3431 + @"[13] = " + _3411 + @" 
0084: " + tmp_3431 + @"[14] = " + _3407 + @" 
0084: " + tmp_3431 + @"[15] = " + _3409 + @" 
0084: " + tmp_3431 + @"[16] = " + _3410 + @" 
0084: " + tmp_3431 + @"[17] = " + _3408 + @" 
0084: " + tmp_3449 + @"[0] = " + _3408 + @" 
0084: " + tmp_3449 + @"[1] = " + _3407 + @" 
0084: " + tmp_3449 + @"[2] = " + _3409 + @" 
0084: " + tmp_3449 + @"[3] = " + _3410 + @" 
0084: " + tmp_3449 + @"[4] = " + _3408 + @" 
0084: " + tmp_3449 + @"[5] = " + _3410 + @" 
0084: " + tmp_3449 + @"[6] = " + _3409 + @" 
0084: " + tmp_3449 + @"[7] = " + _3408 + @" 
0084: " + tmp_3449 + @"[8] = " + _3407 + @" 
0084: " + tmp_3449 + @"[9] = " + _3411 + @" 
0084: " + tmp_3449 + @"[10] = " + _3412 + @" 
0084: " + tmp_3449 + @"[11] = " + _3407 + @" 
0084: " + tmp_3449 + @"[12] = " + _3410 + @" 
0084: " + tmp_3449 + @"[13] = " + _3409 + @" 
0084: " + tmp_3449 + @"[14] = " + _3408 + @" 
0084: " + tmp_3449 + @"[15] = " + _3411 + @" 
0084: " + tmp_3449 + @"[16] = " + _3410 + @" 
0084: " + tmp_3449 + @"[17] = " + _3407 + @" 
" + _3467 + @" = 261.3555 
" + _3472 + @" = 399.3732 
" + _3468 + @" = 219.0498 
" + _3473 + @" = 356.6364 
" + _3469 + @" = 431.2757 
" + _3474 + @" = 424.3356 
" + _3477 + @" = 36.365 
" + _3481 + @" = 240.157 
" + _3485 + @" = 0.4714 
" + _3487 + @" = 2.5077 
" + _3478 + @" = 29.3763 
" + _3482 + @" = 20.0589 
" + _3486 + @" = 0.6253 
" + _3488 + @" = 2.7876 
" + _3479 + @" = 28.5106 
" + _3483 + @" = 220.0782 
" + _3480 + @" = 157.2242 
" + _3484 + @" = 409.3602 
" + _3489 + @" = 0 
" + _3490 + @" = -0.316 
" + _3491 + @" = 0.497 
" + _3492 + @" = 0.408 
" + _3493 + @" = -1.342 
0086: " + tempvar_Float_1 + @" = " + _3490 + @"
0061: " + tempvar_Float_1 + @" -= " + _3492 + @" 
0086: " + tempvar_Float_2 + @" = " + _3491 + @"
0061: " + tempvar_Float_2 + @" -= " + _3493 + @" 
0086: " + _3494 + @" = " + tempvar_Float_1 + @"
" + _3494 + @" /= 6.0
0086: " + _3495 + @" = " + tempvar_Float_2 + @"
" + _3495 + @" /= 24.0
0086: " + _3496 + @" = " + _3490 + @"
0061: " + _3496 + @" -= " + _3494 + @"
0086: " + _3497 + @" = " + _3491 + @"
0061: " + _3497 + @" -= " + _3495 + @"
" + _3498 + @" = -0.176
" + tmp_3507 + @"[0] = -2.0 
" + tmp_3658 + @"[0] = 2.0 
" + tmp_3507 + @"[1] = 0.0 
" + tmp_3658 + @"[1] = 0.0 
" + tmp_3507 + @"[2] = -2.0 
" + tmp_3658 + @"[2] = 0.0 
" + tmp_3507 + @"[3] = -4.0 
" + tmp_3658 + @"[3] = 0.0 
" + tmp_3507 + @"[4] = 0.0 
" + tmp_3658 + @"[4] = -2.0 
" + tmp_3507 + @"[5] = -2.0 
" + tmp_3658 + @"[5] = -2.0 
" + tmp_3507 + @"[6] = -4.0 
" + tmp_3658 + @"[6] = -2.0 
" + tmp_3507 + @"[7] = 0.0 
" + tmp_3658 + @"[7] = -4.0 
" + tmp_3507 + @"[8] = -2.0 
" + tmp_3658 + @"[8] = -4.0 
" + tmp_3507 + @"[9] = -4.0 
" + tmp_3658 + @"[9] = -4.0 
" + tmp_3507 + @"[10] = 0.0 
" + tmp_3658 + @"[10] = -6.0 
" + tmp_3507 + @"[11] = -2.0 
" + tmp_3658 + @"[11] = -6.0 
" + tmp_3507 + @"[12] = -4.0 
" + tmp_3658 + @"[12] = -6.0 
" + tmp_3507 + @"[13] = 0.0 
" + tmp_3658 + @"[13] = -8.0 
" + tmp_3507 + @"[14] = -2.0 
" + tmp_3658 + @"[14] = -8.0 
" + tmp_3507 + @"[15] = -4.0 
" + tmp_3658 + @"[15] = -8.0 
" + tmp_3507 + @"[16] = 0.0 
" + tmp_3658 + @"[16] = -10.0 
" + tmp_3507 + @"[17] = -2.0 
" + tmp_3658 + @"[17] = -10.0 
" + tmp_3507 + @"[18] = -4.0 
" + tmp_3658 + @"[18] = -10.0 
" + tmp_3507 + @"[19] = 0.0 
" + tmp_3658 + @"[19] = -12.0 
" + tmp_3507 + @"[20] = -2.0 
" + tmp_3658 + @"[20] = -12.0 
" + tmp_3507 + @"[21] = -4.0 
" + tmp_3658 + @"[21] = -12.0 
" + tmp_3507 + @"[22] = 0.0 
" + tmp_3658 + @"[22] = -14.0 
" + tmp_3507 + @"[23] = -2.0 
" + tmp_3658 + @"[23] = -14.0 
" + tmp_3507 + @"[24] = -4.0 
" + tmp_3658 + @"[24] = -14.0 
" + tmp_3507 + @"[25] = 0.0 
" + tmp_3658 + @"[25] = -16.0 
" + tmp_3507 + @"[26] = -2.0 
" + tmp_3658 + @"[26] = -16.0 
" + tmp_3507 + @"[27] = -4.0 
" + tmp_3658 + @"[27] = -16.0 
" + tmp_3507 + @"[28] = 0.0 
" + tmp_3658 + @"[28] = -18.0 
" + tmp_3507 + @"[29] = -2.0 
" + tmp_3658 + @"[29] = -18.0 
" + tmp_3507 + @"[30] = -4.0 
" + tmp_3658 + @"[30] = -18.0 
" + tmp_3507 + @"[31] = 0.0 
" + tmp_3658 + @"[31] = -20.0 
" + tmp_3507 + @"[32] = -2.0 
" + tmp_3658 + @"[32] = -20.0 
" + tmp_3507 + @"[33] = -4.0 
" + tmp_3658 + @"[33] = -20.0 
" + tmp_3507 + @"[34] = 0.0 
" + tmp_3658 + @"[34] = -22.0 
" + tmp_3507 + @"[35] = -2.0 
" + tmp_3658 + @"[35] = -22.0 
" + tmp_3507 + @"[36] = -4.0 
" + tmp_3658 + @"[36] = -22.0 
" + tmp_3507 + @"[37] = -1.0 
" + tmp_3658 + @"[37] = 0.0 
" + tmp_3507 + @"[38] = -3.0 
" + tmp_3658 + @"[38] = 0.0 
" + tmp_3507 + @"[39] = -1.0 
" + tmp_3658 + @"[39] = -2.0 
" + tmp_3507 + @"[40] = -3.0 
" + tmp_3658 + @"[40] = -2.0 
" + tmp_3507 + @"[41] = -1.0 
" + tmp_3658 + @"[41] = -4.0 
" + tmp_3507 + @"[42] = -3.0 
" + tmp_3658 + @"[42] = -4.0 
" + tmp_3507 + @"[43] = -1.0 
" + tmp_3658 + @"[43] = -6.0 
" + tmp_3507 + @"[44] = -3.0 
" + tmp_3658 + @"[44] = -6.0 
" + tmp_3507 + @"[45] = -1.0 
" + tmp_3658 + @"[45] = -8.0 
" + tmp_3507 + @"[46] = -3.0 
" + tmp_3658 + @"[46] = -8.0 
" + tmp_3507 + @"[47] = -1.0 
" + tmp_3658 + @"[47] = -10.0 
" + tmp_3507 + @"[48] = -3.0 
" + tmp_3658 + @"[48] = -10.0 
" + tmp_3507 + @"[49] = -1.0 
" + tmp_3658 + @"[49] = -12.0 
" + tmp_3507 + @"[50] = -3.0 
" + tmp_3658 + @"[50] = -12.0 
" + tmp_3507 + @"[51] = -1.0 
" + tmp_3658 + @"[51] = -14.0 
" + tmp_3507 + @"[52] = -3.0 
" + tmp_3658 + @"[52] = -14.0 
" + tmp_3507 + @"[53] = -1.0 
" + tmp_3658 + @"[53] = -16.0 
" + tmp_3507 + @"[54] = -3.0 
" + tmp_3658 + @"[54] = -16.0 
" + tmp_3507 + @"[55] = -1.0 
" + tmp_3658 + @"[55] = -18.0 
" + tmp_3507 + @"[56] = -3.0 
" + tmp_3658 + @"[56] = -18.0 
" + tmp_3507 + @"[57] = -1.0 
" + tmp_3658 + @"[57] = -20.0 
" + tmp_3507 + @"[58] = -3.0 
" + tmp_3658 + @"[58] = -20.0 
" + tmp_3507 + @"[59] = -1.0 
" + tmp_3658 + @"[59] = -22.0 
" + tmp_3507 + @"[60] = -3.0 
" + tmp_3658 + @"[60] = -22.0 
" + tmp_3507 + @"[61] = 0.0 
" + tmp_3658 + @"[61] = -1.0 
" + tmp_3507 + @"[62] = -2.0 
" + tmp_3658 + @"[62] = -1.0 
" + tmp_3507 + @"[63] = -4.0 
" + tmp_3658 + @"[63] = -1.0 
" + tmp_3507 + @"[64] = 0.0 
" + tmp_3658 + @"[64] = -3.0 
" + tmp_3507 + @"[65] = -2.0 
" + tmp_3658 + @"[65] = -3.0 
" + tmp_3507 + @"[66] = -4.0 
" + tmp_3658 + @"[66] = -3.0 
" + tmp_3507 + @"[67] = 0.0 
" + tmp_3658 + @"[67] = -5.0 
" + tmp_3507 + @"[68] = -2.0 
" + tmp_3658 + @"[68] = -5.0 
" + tmp_3507 + @"[69] = -4.0 
" + tmp_3658 + @"[69] = -5.0 
" + tmp_3507 + @"[70] = 0.0 
" + tmp_3658 + @"[70] = -7.0 
" + tmp_3507 + @"[71] = -2.0 
" + tmp_3658 + @"[71] = -7.0 
" + tmp_3507 + @"[72] = -4.0 
" + tmp_3658 + @"[72] = -7.0 
" + tmp_3507 + @"[73] = 0.0 
" + tmp_3658 + @"[73] = -9.0 
" + tmp_3507 + @"[74] = -2.0 
" + tmp_3658 + @"[74] = -9.0 
" + tmp_3507 + @"[75] = -4.0 
" + tmp_3658 + @"[75] = -9.0 
" + tmp_3507 + @"[76] = 0.0 
" + tmp_3658 + @"[76] = -11.0 
" + tmp_3507 + @"[77] = -2.0 
" + tmp_3658 + @"[77] = -11.0 
" + tmp_3507 + @"[78] = -4.0 
" + tmp_3658 + @"[78] = -11.0 
" + tmp_3507 + @"[79] = 0.0 
" + tmp_3658 + @"[79] = -13.0 
" + tmp_3507 + @"[80] = -2.0 
" + tmp_3658 + @"[80] = -13.0 
" + tmp_3507 + @"[81] = -4.0 
" + tmp_3658 + @"[81] = -13.0 
" + tmp_3507 + @"[82] = 0.0 
" + tmp_3658 + @"[82] = -15.0 
" + tmp_3507 + @"[83] = -2.0 
" + tmp_3658 + @"[83] = -15.0 
" + tmp_3507 + @"[84] = -4.0 
" + tmp_3658 + @"[84] = -15.0 
" + tmp_3507 + @"[85] = 0.0 
" + tmp_3658 + @"[85] = -17.0 
" + tmp_3507 + @"[86] = -2.0 
" + tmp_3658 + @"[86] = -17.0 
" + tmp_3507 + @"[87] = -4.0 
" + tmp_3658 + @"[87] = -17.0 
" + tmp_3507 + @"[88] = 0.0 
" + tmp_3658 + @"[88] = -19.0 
" + tmp_3507 + @"[89] = -2.0 
" + tmp_3658 + @"[89] = -19.0 
" + tmp_3507 + @"[90] = -4.0 
" + tmp_3658 + @"[90] = -19.0 
" + tmp_3507 + @"[91] = 0.0 
" + tmp_3658 + @"[91] = -21.0 
" + tmp_3507 + @"[92] = -2.0 
" + tmp_3658 + @"[92] = -21.0 
" + tmp_3507 + @"[93] = -4.0 
" + tmp_3658 + @"[93] = -21.0 
" + tmp_3507 + @"[94] = -5.0 
" + tmp_3658 + @"[94] = 0.0 
" + tmp_3507 + @"[95] = -5.0 
" + tmp_3658 + @"[95] = -2.0 
" + tmp_3507 + @"[96] = -5.0 
" + tmp_3658 + @"[96] = -4.0 
" + tmp_3507 + @"[97] = -5.0 
" + tmp_3658 + @"[97] = -6.0 
" + tmp_3507 + @"[98] = -5.0 
" + tmp_3658 + @"[98] = -8.0 
" + tmp_3507 + @"[99] = -5.0 
" + tmp_3658 + @"[99] = -10.0 
" + tmp_3507 + @"[100] = -5.0 
" + tmp_3658 + @"[100] = -12.0 
" + tmp_3507 + @"[101] = -5.0 
" + tmp_3658 + @"[101] = -14.0 
" + tmp_3507 + @"[102] = -5.0 
" + tmp_3658 + @"[102] = -16.0 
" + tmp_3507 + @"[103] = -5.0 
" + tmp_3658 + @"[103] = -18.0 
" + tmp_3507 + @"[104] = -5.0 
" + tmp_3658 + @"[104] = -20.0 
" + tmp_3507 + @"[105] = -5.0 
" + tmp_3658 + @"[105] = -22.0 
" + tmp_3507 + @"[106] = -1.0 
" + tmp_3658 + @"[106] = -1.0 
" + tmp_3507 + @"[107] = -3.0 
" + tmp_3658 + @"[107] = -1.0 
" + tmp_3507 + @"[108] = -1.0 
" + tmp_3658 + @"[108] = -3.0 
" + tmp_3507 + @"[109] = -3.0 
" + tmp_3658 + @"[109] = -3.0 
" + tmp_3507 + @"[110] = -1.0 
" + tmp_3658 + @"[110] = -5.0 
" + tmp_3507 + @"[111] = -3.0 
" + tmp_3658 + @"[111] = -5.0 
" + tmp_3507 + @"[112] = -1.0 
" + tmp_3658 + @"[112] = -7.0 
" + tmp_3507 + @"[113] = -3.0 
" + tmp_3658 + @"[113] = -7.0 
" + tmp_3507 + @"[114] = -1.0 
" + tmp_3658 + @"[114] = -9.0 
" + tmp_3507 + @"[115] = -3.0 
" + tmp_3658 + @"[115] = -9.0 
" + tmp_3507 + @"[116] = -1.0 
" + tmp_3658 + @"[116] = -11.0 
" + tmp_3507 + @"[117] = -3.0 
" + tmp_3658 + @"[117] = -11.0 
" + tmp_3507 + @"[118] = -1.0 
" + tmp_3658 + @"[118] = -13.0 
" + tmp_3507 + @"[119] = -3.0 
" + tmp_3658 + @"[119] = -13.0 
" + tmp_3507 + @"[120] = -1.0 
" + tmp_3658 + @"[120] = -15.0 
" + tmp_3507 + @"[121] = -3.0 
" + tmp_3658 + @"[121] = -15.0 
" + tmp_3507 + @"[122] = -1.0 
" + tmp_3658 + @"[122] = -17.0 
" + tmp_3507 + @"[123] = -3.0 
" + tmp_3658 + @"[123] = -17.0 
" + tmp_3507 + @"[124] = -1.0 
" + tmp_3658 + @"[124] = -19.0 
" + tmp_3507 + @"[125] = -3.0 
" + tmp_3658 + @"[125] = -19.0 
" + tmp_3507 + @"[126] = -1.0 
" + tmp_3658 + @"[126] = -21.0 
" + tmp_3507 + @"[127] = -3.0 
" + tmp_3658 + @"[127] = -21.0 
" + tmp_3507 + @"[128] = 0.0 
" + tmp_3658 + @"[128] = -24.0 
" + tmp_3507 + @"[129] = -2.0 
" + tmp_3658 + @"[129] = -24.0 
" + tmp_3507 + @"[130] = -4.0 
" + tmp_3658 + @"[130] = -24.0 
" + tmp_3507 + @"[131] = 2.0 
" + tmp_3658 + @"[131] = -3.0 
" + tmp_3507 + @"[132] = 2.0 
" + tmp_3658 + @"[132] = -11.0 
" + tmp_3507 + @"[133] = 2.0 
" + tmp_3658 + @"[133] = -19.0 
" + tmp_3507 + @"[134] = 4.0 
" + tmp_3658 + @"[134] = -1.0 
" + tmp_3507 + @"[135] = 4.0 
" + tmp_3658 + @"[135] = -21.0 
" + tmp_3507 + @"[136] = 4.0 
" + tmp_3658 + @"[136] = -5.0 
" + tmp_3507 + @"[137] = 4.0 
" + tmp_3658 + @"[137] = -17.0 
" + tmp_3507 + @"[138] = 4.0 
" + tmp_3658 + @"[138] = -9.0 
" + tmp_3507 + @"[139] = 4.0 
" + tmp_3658 + @"[139] = -13.0 
" + tmp_3507 + @"[140] = -5.0 
" + tmp_3658 + @"[140] = -1.0 
" + tmp_3507 + @"[141] = -5.0 
" + tmp_3658 + @"[141] = -3.0 
" + tmp_3507 + @"[142] = -5.0 
" + tmp_3658 + @"[142] = -5.0 
" + tmp_3507 + @"[143] = -5.0 
" + tmp_3658 + @"[143] = -7.0 
" + tmp_3507 + @"[144] = -5.0 
" + tmp_3658 + @"[144] = -9.0 
" + tmp_3507 + @"[145] = -5.0 
" + tmp_3658 + @"[145] = -11.0 
" + tmp_3507 + @"[146] = -5.0 
" + tmp_3658 + @"[146] = -13.0 
" + tmp_3507 + @"[147] = -5.0 
" + tmp_3658 + @"[147] = -15.0 
" + tmp_3507 + @"[148] = -5.0 
" + tmp_3658 + @"[148] = -17.0 
" + tmp_3507 + @"[149] = -5.0 
" + tmp_3658 + @"[149] = -19.0 
" + tmp_3507 + @"[150] = -5.0 
" + tmp_3658 + @"[150] = -21.0 
" + _3809 + @" = 345.3592 
" + _3810 + @" = 55.3183 
04AE: " + tmp_3811 + @"[0] = 5408 
04AE: " + tmp_3811 + @"[1] = 5409 
04AE: " + tmp_3811 + @"[2] = 5410 
04AE: " + tmp_3814 + @"[0] = 5405 
04AE: " + tmp_3814 + @"[1] = 5406 
04AE: " + tmp_3814 + @"[2] = 5407 
04AE: " + tmp_3817 + @"[0] = 5451 
04AE: " + tmp_3817 + @"[1] = 5452 
04AE: " + tmp_3820 + @"[0] = 5448 
04AE: " + tmp_3820 + @"[1] = 5449 
04AE: " + tmp_3820 + @"[2] = 5450 
04AE: " + tmp_3820 + @"[3] = 5462 
04AE: " + tmp_3820 + @"[4] = 5463 
04AE: " + tmp_3820 + @"[5] = 5464 
04AE: " + tmp_3826 + @"[0] = 5453 
04AE: " + tmp_3826 + @"[1] = 5454 
04AE: " + tmp_3828 + @"[0] = 5400 
04AE: " + tmp_3828 + @"[1] = 5401 
04AE: " + tmp_3830 + @"[0] = 5438 
04AE: " + tmp_3830 + @"[1] = 5439 
04AE: " + tmp_3830 + @"[2] = 5440 
04AE: " + tmp_3830 + @"[3] = 5441 
04AE: " + tmp_3830 + @"[4] = 5442 
04AE: " + tmp_3830 + @"[5] = 5443 
04AE: " + tmp_3830 + @"[6] = 5444 
04AE: " + tmp_3830 + @"[7] = 5445 
04AE: " + tmp_3830 + @"[8] = 5446 
04AE: " + tmp_3830 + @"[9] = 5447 
04AE: " + tmp_3830 + @"[10] = 5411 
04AE: " + tmp_3830 + @"[11] = 5412 
04AE: " + tmp_3830 + @"[12] = 5413 
04AE: " + tmp_3830 + @"[13] = 5414 
04AE: " + tmp_3830 + @"[14] = 5415 
04AE: " + tmp_3830 + @"[15] = 5416 
04AE: " + tmp_3830 + @"[16] = 5417 
04AE: " + tmp_3830 + @"[17] = 5418 
04AE: " + tmp_3830 + @"[18] = 5419 
04AE: " + tmp_3830 + @"[19] = 5420 
04AE: " + tmp_3830 + @"[20] = 5421 
04AE: " + tmp_3830 + @"[21] = 5422 
04AE: " + tmp_3830 + @"[22] = 5423 
04AE: " + tmp_3830 + @"[23] = 5424 
04AE: " + tmp_3830 + @"[24] = 5425 
04AE: " + tmp_3830 + @"[25] = 5426 
04AE: " + tmp_3830 + @"[26] = 5427 
04AE: " + tmp_3830 + @"[27] = 5428 
04AE: " + tmp_3830 + @"[28] = 5429 
04AE: " + tmp_3830 + @"[29] = 5430 
04AE: " + tmp_3830 + @"[30] = 5431 
04AE: " + tmp_3830 + @"[31] = 5432 
04AE: " + tmp_3830 + @"[32] = 5433 
04AE: " + tmp_3830 + @"[33] = 5434 
04AE: " + tmp_3830 + @"[34] = 5435 
04AE: " + tmp_3830 + @"[35] = 5436 
04AE: " + tmp_3830 + @"[36] = 5437 
04AE: " + tmp_3867 + @"[0] = 5402 
04AE: " + tmp_3867 + @"[1] = 5403 
04AE: " + tmp_3867 + @"[2] = 5404 
04AE: " + tmp_3870 + @"[0] = 43608 
04AE: " + tmp_3870 + @"[1] = 43609 
04AE: " + tmp_3870 + @"[2] = 43610 
04AE: " + tmp_3873 + @"[0] = 43605 
04AE: " + tmp_3873 + @"[1] = 43606 
04AE: " + tmp_3873 + @"[2] = 43607 
04AE: " + tmp_3876 + @"[0] = 43651 
04AE: " + tmp_3876 + @"[1] = 43652 
04AE: " + tmp_3879 + @"[0] = 43648 
04AE: " + tmp_3879 + @"[1] = 43649 
04AE: " + tmp_3879 + @"[2] = 43650 
04AE: " + tmp_3879 + @"[3] = 43662 
04AE: " + tmp_3879 + @"[4] = 43663 
04AE: " + tmp_3879 + @"[5] = 43664 
04AE: " + tmp_3885 + @"[0] = 43653 
04AE: " + tmp_3885 + @"[1] = 43654 
04AE: " + tmp_3887 + @"[0] = 43600 
04AE: " + tmp_3887 + @"[1] = 43601 
04AE: " + tmp_3889 + @"[0] = 43638 
04AE: " + tmp_3889 + @"[1] = 43639 
04AE: " + tmp_3889 + @"[2] = 43640 
04AE: " + tmp_3889 + @"[3] = 43641 
04AE: " + tmp_3889 + @"[4] = 43642 
04AE: " + tmp_3889 + @"[5] = 43643 
04AE: " + tmp_3889 + @"[6] = 43644 
04AE: " + tmp_3889 + @"[7] = 43645 
04AE: " + tmp_3889 + @"[8] = 43646 
04AE: " + tmp_3889 + @"[9] = 43647 
04AE: " + tmp_3889 + @"[10] = 43611 
04AE: " + tmp_3889 + @"[11] = 43612 
04AE: " + tmp_3889 + @"[12] = 43613 
04AE: " + tmp_3889 + @"[13] = 43614 
04AE: " + tmp_3889 + @"[14] = 43615 
04AE: " + tmp_3889 + @"[15] = 43616 
04AE: " + tmp_3889 + @"[16] = 43617 
04AE: " + tmp_3889 + @"[17] = 43618 
04AE: " + tmp_3889 + @"[18] = 43619 
04AE: " + tmp_3889 + @"[19] = 43620 
04AE: " + tmp_3889 + @"[20] = 43621 
04AE: " + tmp_3889 + @"[21] = 43622 
04AE: " + tmp_3889 + @"[22] = 43623 
04AE: " + tmp_3889 + @"[23] = 43624 
04AE: " + tmp_3889 + @"[24] = 43625 
04AE: " + tmp_3889 + @"[25] = 43626 
04AE: " + tmp_3889 + @"[26] = 43627 
04AE: " + tmp_3889 + @"[27] = 43628 
04AE: " + tmp_3889 + @"[28] = 43629 
04AE: " + tmp_3889 + @"[29] = 43630 
04AE: " + tmp_3889 + @"[30] = 43631 
04AE: " + tmp_3889 + @"[31] = 43632 
04AE: " + tmp_3889 + @"[32] = 43633 
04AE: " + tmp_3889 + @"[33] = 43634 
04AE: " + tmp_3889 + @"[34] = 43635 
04AE: " + tmp_3889 + @"[35] = 43636 
04AE: " + tmp_3889 + @"[36] = 43637 
04AE: " + tmp_3926 + @"[0] = 43602 
04AE: " + tmp_3926 + @"[1] = 43603 
04AE: " + tmp_3926 + @"[2] = 43604" );

            #endregion

            Shooting_X[ 0 ].value = 292.33;
            Shooting_Y[ 0 ].value = -35.39;
            Shooting_Z[ 0 ].value = 1000.5;
            Shooting_X[ 1 ].value = 289.4804;
            Shooting_Y[ 1 ].value = -79.6619;
            Shooting_Z[ 1 ].value = 1001.727;
            Shooting_X[ 2 ].value = 309.9744;
            Shooting_Y[ 2 ].value = -135.3927;
            Shooting_Z[ 2 ].value = 1002.826;
            Shooting_X[ 3 ].value = 306.8972;
            Shooting_Y[ 3 ].value = -164.9947;
            Shooting_Z[ 3 ].value = 1000.259;

            Script.init_external_script_trigger_with_object_model<VIDPOK>( 2640, 100, 4.0, 1 );
            Script.init_external_script_trigger_with_object_model<VIDPOK>( 2785, 100, 4.0, 1 );
            Script.init_external_script_trigger_with_object_model<BLACKJ>( 2188, 50, 70.0, 1 );
            Script.init_external_script_trigger_with_object_model<WOF>( 1895, 50, 70.0, 1 );
            Script.init_external_script_trigger_with_object_model<ROULETE>( 1978, 60, 50.0, 1 );
            Script.init_external_script_trigger_with_object_model<BANDIT>( 2325, 100, 6.0, 1 );

            Script.init_external_script_attractor<DANCER>();
            Script.init_external_script_attractor<PCHAIR>();
            Script.init_external_script_attractor<PCUSTOM>();
            Script.init_external_script_attractor<OTBWTCH>();
            Script.init_external_script_attractor<OTBSLP>();
            Script.init_external_script_attractor<OTBTILL>();
            Script.init_external_script_attractor<FBOOTHR>();
            Script.init_external_script_attractor<FBOOTHL>();
            Script.init_external_script_attractor<BARGUY>();
            Script.init_external_script_attractor<PEDROUL>();
            Script.init_external_script_attractor<PEDCARD>();
            Script.init_external_script_attractor<PEDSLOT>();
            Script.init_external_script_attractor<STRIPW>();
            Script.init_external_script_attractor<STRIPM>();
            Script.init_external_script_attractor<BROWSE>();
            Script.init_external_script_attractor<COPSIT>();
            Script.init_external_script_attractor<COPLOOK>();
            Script.init_external_script_attractor<TICKET>();
            Script.init_external_script_attractor<SHOPPER>();
            Script.init_external_script_attractor<PRISONR>();

            Script.create_thread<INTMAN>();
            Script.create_thread<SHOOT>();
        }
        internal override void Update() {
            Script.get_current_time_in_ms( _5284 );
            Script.and( _672 == 1, delegate {
                _5283.value = _5284;
                _5283 -= _5285;
                Script.and( _5283 >= 180000, delegate {
                    _672.value = 0;
                    Total_Food_Eaten.value = 0;
                    _5283.value = 0;
                    _10045.value = 0;
                } );
            } );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class SHOOT : Thread {

            Int tmp_Shooting_X = global( Shooting_X.startIndex ),
                tmp_Shooting_Y = global( Shooting_Y.startIndex ),
                tmp_Shooting_Z = global( Shooting_Z.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @":SHOOT_11
wait 125 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @SHOOT_324 
if 
  " + OnMission + @" == 0 
else_jump @SHOOT_238 
if 
   not " + Active_Interior + @" == 0 
else_jump @SHOOT_231 
if 
  " + ONMISSION_Shooting + @" == 0 
else_jump @SHOOT_231 
if 
  " + Shooting_Available + @" == 0 
else_jump @SHOOT_231 
" + Shooting_Index + @" = 0 

:SHOOT_110
if 
  4 > " + Shooting_Index + @" 
else_jump @SHOOT_231 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tmp_Shooting_X + @"(" + Shooting_Index + @",4f) " + tmp_Shooting_Y + @"(" + Shooting_Index + @",4f) " + tmp_Shooting_Z + @"(" + Shooting_Index + @",4f) radius 20.0 20.0 10.0 on_foot 
else_jump @SHOOT_217 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @SHOOT_217 
" + OnMission + @" = 1 
0084: " + Shooting_Index_2 + @" = " + Shooting_Index + @"" );
start_mission<SHRANGE>();
AppendLine( @"
:SHOOT_217
" + Shooting_Index + @" += 1 
jump @SHOOT_110 

:SHOOT_231
jump @SHOOT_281 

:SHOOT_238
if 
   not " + Active_Interior + @" == 0 
else_jump @SHOOT_281 
if 
  " + Shooting_Available + @" == 0 
else_jump @SHOOT_281 
" + Shooting_Available + @" = 1 

:SHOOT_281
if 
  " + Shooting_Available + @" == 1 
else_jump @SHOOT_324 
if 
  " + Active_Interior + @" == 0 
else_jump @SHOOT_324 
" + Shooting_Available + @" = 0 

:SHOOT_324
jump @SHOOT_11" );
            }

        }

        private sealed class INTMAN : Thread {

            Int _local1 = local( 1 ); // 1@

            public override void START( LabelJump label ) {
                AppendLine( @"" + Interior_Decision_Maker_A + @" = -1 
if 
  " + Interior_Decision_Maker_A + @" == 9999 
jf @INTMAN_57 
07E5: copy_decision_maker 65543 to " + Interior_Decision_Maker_A + @" 
07E5: copy_decision_maker 65543 to " + Interior_Decision_Maker_B + @" 

:INTMAN_57
if 
   Player.Defined(" + PlayerChar + @")
jf @INTMAN_80 
gosub @INTMAN_91 

:INTMAN_80
wait 0 
jump @INTMAN_57 

:INTMAN_91
0871: init_jump_table 0@ total_jumps 2 default_jump 0 @INTMAN_182 jumps 0 @INTMAN_154 1 @INTMAN_168 -1 @INTMAN_182 -1 @INTMAN_182 -1 @INTMAN_182 -1 @INTMAN_182 -1 @INTMAN_182 

:INTMAN_154
gosub @INTMAN_184 
jump @INTMAN_182 

:INTMAN_168
gosub @INTMAN_2976 
jump @INTMAN_182 

:INTMAN_182
return 

:INTMAN_184
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if 
   not " + _1250 + @" == 0 
jf @INTMAN_2974 
094B: " + Active_Interior_Name + @" = get_active_interior_name_from_actor " + PlayerActor + @" 
if 
8846:   not string " + Active_Interior_Name + @" empty 
jf @INTMAN_2974 
0084: " + _1251 + @" = " + _1250 + @" 
if 
   Player.Defined(" + PlayerChar + @")
jf @INTMAN_266 
" + Player_Wanted_Level + @" = Player.WantedLevel(" + PlayerChar + @")

:INTMAN_266
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
" + _1261 + @" = 0 
" + PLAYER_IN_INTERIOR + @" = 0 
2@ = 0 
if 
  " + OnMission + @" == 0 
jf @INTMAN_359 
" + _9472 + @" = 0 
" + _9470 + @" = 0 
" + _9471 + @" = 0 
" + FOOD_Player_Aggressive_Flag + @" = 0 
" + _2881 + @" = 0 
" + _9473 + @" = 0 
" + _9526 + @" = 0 

:INTMAN_359
if and
08F9:   " + Active_Interior_Name + @" == ""CHANGER"" 
  " + _1250 + @" == 14 
jf @INTMAN_451" );
                get_external_script_status<WARROBE>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_451 " );
                load_external_script<WARROBE>();
                AppendLine( @"038B: load_requested_models 
if " );
                is_external_script_loaded<WARROBE>().write();
                AppendLine( @"jf @INTMAN_451" );
                start_new_external_script<WARROBE>();
                AppendLine( @"0@ += 1 
return 

:INTMAN_451
if or
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
08F9:   " + Active_Interior_Name + @" == ""CASINO2"" 
jf @INTMAN_818 " );
                get_external_script_status<BARSTAF>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_531 " );
                load_external_script<BARSTAF>();
                AppendLine( @"
:INTMAN_531" );
                get_external_script_status<BOUNCER>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_560" );
                load_external_script<BOUNCER>();
                AppendLine( @"
:INTMAN_560" );
                get_external_script_status<FFPNC>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_589" );
                load_external_script<FFPNC>();
                AppendLine( @"
:INTMAN_589" );
                get_external_script_status<CASAMB>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_618" );
                load_external_script<CASAMB>();
                AppendLine( @"
:INTMAN_618
04ED: load_animation ""BAR"" 
04ED: load_animation ""CASINO"" 
if 
08F9:   " + Active_Interior_Name + @" == ""MAFCAS"" 
jf @INTMAN_676 
Model.Load(#VMAFF1)
Model.Load(#VMAFF3)
Model.Load(#VMAFF2)
Model.Load(#VWFYWAI)

:INTMAN_676
if 
08F9:   " + Active_Interior_Name + @" == ""TRICAS"" 
jf @INTMAN_715 
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
Model.Load(#VWFYWA2)

:INTMAN_715
if 
08F9:   " + Active_Interior_Name + @" == ""CASINO2"" 
jf @INTMAN_755 
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
Model.Load(#VWFYCRP)

:INTMAN_755
038B: load_requested_models 
if" );
                is_external_script_loaded<CASAMB>().write();
                AppendLine( @"jf @INTMAN_777" );
                start_new_external_script<CASAMB>();
                AppendLine( @"
:INTMAN_777
if and" );
                is_external_script_loaded<BARSTAF>().write();
                is_external_script_loaded<BOUNCER>().write();
                is_external_script_loaded<FFPNC>().write();
                is_external_script_loaded<CASAMB>().write();
                AppendLine( @"jf @INTMAN_818 
" + _1261 + @" = 1 
0@ += 1 

:INTMAN_818
if or
08F9:   " + Active_Interior_Name + @" == ""BAR1"" 
08F9:   " + Active_Interior_Name + @" == ""BAR2"" 
08F9:   " + Active_Interior_Name + @" == ""UFOBAR"" 
jf @INTMAN_1088" );
                get_external_script_status<BARSTAF>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_893 " );
                load_external_script<BARSTAF>();
                AppendLine( @"
:INTMAN_893" );
                get_external_script_status<FFPNC>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_922" );
                load_external_script<FFPNC>();
                AppendLine( @"
:INTMAN_922" );
                get_external_script_status<BAR>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_951" );
                load_external_script<BAR>();
                AppendLine( @"
:INTMAN_951" );
                get_external_script_status<DANCE>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_980 
" );
                load_external_script<DANCE>();
                AppendLine( @"
:INTMAN_980
04ED: load_animation ""BAR"" 
if 
08F9:   " + Active_Interior_Name + @" == ""BAR1"" 
jf @INTMAN_1020 
04ED: load_animation ""DANCING"" 

:INTMAN_1020
Model.Load(#VWFYCRP)
038B: load_requested_models 
if" );
                is_external_script_loaded<BAR>().write();
                AppendLine( @"jf @INTMAN_1047" );
                start_new_external_script<BAR>();
                AppendLine( @"
:INTMAN_1047
if and" );
                is_external_script_loaded<BARSTAF>().write();
                is_external_script_loaded<FFPNC>().write();
                is_external_script_loaded<BAR>().write();
                is_external_script_loaded<DANCE>().write();
                AppendLine( @"jf @INTMAN_1088 
" + _1261 + @" = 1 
0@ += 1 

:INTMAN_1088
if 
08F9:   " + Active_Interior_Name + @" == ""GENOTB"" 
jf @INTMAN_1286" );
                get_external_script_status<OTBSTAF>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1141" );
                load_external_script<OTBSTAF>();
                AppendLine( @"
:INTMAN_1141" );
                get_external_script_status<FFPNC>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1170" );
                load_external_script<FFPNC>();
                AppendLine( @"
:INTMAN_1170" );
                get_external_script_status<OTBSHP>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1199 
" );
                load_external_script<OTBSHP>();
                AppendLine( @"
:INTMAN_1199
04ED: load_animation ""OTB"" 
04ED: load_animation ""INT_SHOP"" 
Model.Load(#VBFYCRP)
Model.Load(#VWFYCRP)
038B: load_requested_models 
if" );
                is_external_script_loaded<OTBSHP>().write();
                AppendLine( @"jf @INTMAN_1249" );
                start_new_external_script<OTBSHP>();
                AppendLine( @"
:INTMAN_1249
if and" );
                is_external_script_loaded<OTBSTAF>().write();
                is_external_script_loaded<FFPNC>().write();
                is_external_script_loaded<OTBSHP>().write();
                AppendLine( @"jf @INTMAN_1286 
" + _1261 + @" = 1 
0@ += 1 

:INTMAN_1286
if or
08F9:   " + Active_Interior_Name + @" == ""LASTRIP"" 
08F9:   " + Active_Interior_Name + @" == ""STRIP2"" 
jf @INTMAN_1534" );
                get_external_script_status<BARSTAF>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1353" );
                load_external_script<BARSTAF>();
                AppendLine( @"
:INTMAN_1353" );
                get_external_script_status<BOUNCER>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1382" );
                load_external_script<BOUNCER>();
                AppendLine( @"
:INTMAN_1382" );
                get_external_script_status<FFPNC>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1411" );
                load_external_script<FFPNC>();
                AppendLine( @"
:INTMAN_1411" );
                get_external_script_status<STRIP>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1440" );
                load_external_script<STRIP>();
                AppendLine( @"
:INTMAN_1440
04ED: load_animation ""BAR"" 
04ED: load_animation ""STRIP"" 
Model.Load(#BMYBOUN)
Model.Load(#WMYBOUN)
Model.Load(#VWFYCRP)
038B: load_requested_models 
if" );
                is_external_script_loaded<STRIP>().write();
                AppendLine( @"jf @INTMAN_1493" );
                start_new_external_script<STRIP>();
                AppendLine( @"
:INTMAN_1493
if and" );
                is_external_script_loaded<BARSTAF>().write();
                is_external_script_loaded<BOUNCER>().write();
                is_external_script_loaded<FFPNC>().write();
                is_external_script_loaded<STRIP>().write();
                AppendLine( @"jf @INTMAN_1534 
" + _1261 + @" = 1 
0@ += 1 

:INTMAN_1534
if 
  " + _9977 + @" == 0 
jf @INTMAN_1724 
if or
08F9:   " + Active_Interior_Name + @" == ""CSCHP"" 
08F9:   " + Active_Interior_Name + @" == ""CSSPRT"" 
08F9:   " + Active_Interior_Name + @" == ""LACS1"" 
08F9:   " + Active_Interior_Name + @" == ""CLOTHGP"" 
08F9:   " + Active_Interior_Name + @" == ""CSDESGN"" 
08F9:   " + Active_Interior_Name + @" == ""CSEXL"" 
jf @INTMAN_1724" );
                get_external_script_status<CLOTH>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1669" );
                load_external_script<CLOTH>();
                AppendLine( @"
:INTMAN_1669
04ED: load_animation ""INT_SHOP"" 
038B: load_requested_models 
if" );
                is_external_script_loaded<CLOTH>().write();
                AppendLine( @"jf @INTMAN_1724 
" + _1258 + @" = 0" );
                start_new_external_script<CLOTH>();
                AppendLine( @"" + _1261 + @" = 1 
0@ += 1 

:INTMAN_1724
if or
08F9:   " + Active_Interior_Name + @" == ""FDPIZA"" 
08F9:   " + Active_Interior_Name + @" == ""FDCHICK"" 
08F9:   " + Active_Interior_Name + @" == ""FDBURG"" 
jf @INTMAN_2221 " );
                get_external_script_status<JFUD>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1804" );
                load_external_script<JFUD>();
                AppendLine( @"
:INTMAN_1804" );
                get_external_script_status<PSHOP>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1833" );
                load_external_script<PSHOP>();
                AppendLine( @"
:INTMAN_1833" );
                get_external_script_status<SKBRAIN>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1862 " );
                load_external_script<SKBRAIN>();
                AppendLine( @"
:INTMAN_1862" );
                get_external_script_status<FFPNC>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_1891" );
                load_external_script<FFPNC>();
                AppendLine( @"
:INTMAN_1891
04ED: load_animation ""FOOD"" 
04ED: load_animation ""INT_SHOP"" 
if 
08F9:   " + Active_Interior_Name + @" == ""FDPIZA"" 
jf @INTMAN_1952 
Model.Load(#WMYPIZZ)
Model.Load(#PIZZAHIGH)
Model.Load(#CJ_PIZZA_1)
Model.Load(#CJ_PIZZA_2)

:INTMAN_1952
if 
08F9:   " + Active_Interior_Name + @" == ""FDCHICK"" 
jf @INTMAN_1994 
Model.Load(#WMYBELL)
Model.Load(#BURGERHIGH)
Model.Load(#CJ_BURG_1)
Model.Load(#CJ_BURG_2)

:INTMAN_1994
if 
08F9:   " + Active_Interior_Name + @" == ""FDBURG"" 
jf @INTMAN_2035 
Model.Load(#WFYBURG)
Model.Load(#BURGERHIGH)
Model.Load(#CJ_BURG_1)
Model.Load(#CJ_BURG_2)

:INTMAN_2035
038B: load_requested_models 
if" );
                is_external_script_loaded<JFUD>().write();
                AppendLine( @"jf @INTMAN_2057" );
                start_new_external_script<JFUD>();
                AppendLine( @"
:INTMAN_2057
if" );
                is_external_script_loaded<PSHOP>().write();
                AppendLine( @"jf @INTMAN_2180 
if 
08F9:   " + Active_Interior_Name + @" == ""FDPIZA"" 
jf @INTMAN_2110" );
                start_new_external_script<PSHOP>();
                AppendLine( @"jump @INTMAN_2180 

:INTMAN_2110
if 
08F9:   " + Active_Interior_Name + @" == ""FDCHICK"" 
jf @INTMAN_2149" );
                start_new_external_script<PSHOP>();
                AppendLine( @"jump @INTMAN_2180 

:INTMAN_2149
if 
08F9:   " + Active_Interior_Name + @" == ""FDBURG"" 
jf @INTMAN_2180 " );
                start_new_external_script<PSHOP>();
                AppendLine( @"
:INTMAN_2180
if and" );
                is_external_script_loaded<JFUD>().write();
                is_external_script_loaded<PSHOP>().write();
                is_external_script_loaded<SKBRAIN>().write();
                is_external_script_loaded<FFPNC>().write();
                AppendLine( @"jf @INTMAN_2221 
" + _1261 + @" = 1 
0@ += 1 

:INTMAN_2221
if or
08F9:   " + Active_Interior_Name + @" == ""BARBERS"" 
08F9:   " + Active_Interior_Name + @" == ""BARBER2"" 
08F9:   " + Active_Interior_Name + @" == ""BARBER3"" 
jf @INTMAN_2339" );
                get_external_script_status<BARB>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_2339" );
                load_external_script<BARB>();
                AppendLine( @"038B: load_requested_models 
if" );
                is_external_script_loaded<BARB>().write();
                AppendLine( @"jf @INTMAN_2339" );
                start_new_external_script<BARB>();
                AppendLine( @"" + _1261 + @" = 1 
0@ += 1 

:INTMAN_2339
if or
08F9:   " + Active_Interior_Name + @" == ""TATTOO"" 
08F9:   " + Active_Interior_Name + @" == ""TATTO2"" 
08F9:   " + Active_Interior_Name + @" == ""TATTO3"" 
jf @INTMAN_2454" );
                get_external_script_status<TATTO>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_2454" );
                load_external_script<TATTO>();
                AppendLine( @"038B: load_requested_models 
if" );
                is_external_script_loaded<TATTO>().write();
                AppendLine( @"jf @INTMAN_2454" );
                start_new_external_script<TATTO>();
                AppendLine( @"" + _1261 + @" = 1 
0@ += 1 

:INTMAN_2454
if 
08F9:   " + Active_Interior_Name + @" == ""RCPLAY"" 
jf @INTMAN_2596" );
                get_external_script_status<RCSHOP>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_2507 " );
                load_external_script<RCSHOP>();
                AppendLine( @"
:INTMAN_2507" );
                get_external_script_status<FFPNC>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_2536" );
                load_external_script<FFPNC>();
                AppendLine( @"
:INTMAN_2536
Model.Load(#WMYCLOT)
038B: load_requested_models 
if" );
                is_external_script_loaded<RCSHOP>().write();
                AppendLine( @"jf @INTMAN_2563 " );
                start_new_external_script<RCSHOP>();
                AppendLine( @"
:INTMAN_2563
if and" );
                is_external_script_loaded<RCSHOP>().write();
                is_external_script_loaded<FFPNC>().write();
                AppendLine( @"jf @INTMAN_2596 
" + _1261 + @" = 1 
0@ += 1 

:INTMAN_2596
if or
08F9:   " + Active_Interior_Name + @" == ""POLICE1"" 
08F9:   " + Active_Interior_Name + @" == ""POLICE2"" 
08F9:   " + Active_Interior_Name + @" == ""POLICE3"" 
08F9:   " + Active_Interior_Name + @" == ""POLICE4"" 
jf @INTMAN_2728 
" + _1260 + @" = 1 
" + _1261 + @" = 1 
04ED: load_animation ""COP_AMBIENT"" 
04ED: load_animation ""INT_OFFICE"" 
04ED: load_animation ""GANGS"" 
Model.Load(#CIGAR)
038B: load_requested_models 
0@ += 1 

:INTMAN_2728
if or
08F9:   " + Active_Interior_Name + @" == ""AMMUN1"" 
08F9:   " + Active_Interior_Name + @" == ""AMMUN2"" 
08F9:   " + Active_Interior_Name + @" == ""AMMUN3"" 
08F9:   " + Active_Interior_Name + @" == ""AMMUN4"" 
08F9:   " + Active_Interior_Name + @" == ""AMMUN5"" 
jf @INTMAN_2869" );
                get_external_script_status<AMUNAT>( _local1 );
                AppendLine( @"if 
  1@ == 0 
jf @INTMAN_2869" );
                load_external_script<AMUNAT>();
                AppendLine( @"038B: load_requested_models 
if" );
                is_external_script_loaded<AMUNAT>().write();
                AppendLine( @"jf @INTMAN_2869 " );
                start_new_external_script<AMUNAT>();
                AppendLine( @"" + _1261 + @" = 1 
0@ += 1 

:INTMAN_2869
if 
  " + _1261 + @" == 1 
jf @INTMAN_2974 
if 
89F2:   not decision_maker " + Interior_Decision_Maker_A + @" exists 
jf @INTMAN_2927 
07E5: copy_decision_maker 65543 to " + Interior_Decision_Maker_A + @" 
0708: reset_decision_maker " + Interior_Decision_Maker_A + @" event 27 
0708: reset_decision_maker " + Interior_Decision_Maker_A + @" event 48 

:INTMAN_2927
if 
89F2:   not decision_maker " + Interior_Decision_Maker_B + @" exists 
jf @INTMAN_2974 
07E5: copy_decision_maker 65543 to " + Interior_Decision_Maker_B + @" 
0708: reset_decision_maker " + Interior_Decision_Maker_B + @" event 27 
0708: reset_decision_maker " + Interior_Decision_Maker_B + @" event 48 
0708: reset_decision_maker " + Interior_Decision_Maker_B + @" event 9 

:INTMAN_2974
return 

:INTMAN_2976
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if 
803A:   not  " + _1250 + @" == " + _1251 + @" 
jf @INTMAN_3052 
gosub @INTMAN_3136 
" + PLAYER_IN_INTERIOR + @" = 0 
2@ = 0 
" + _1260 + @" = 0 
07B0: get_active_shop_name_to " + Current_Shop_GXT_Name + @" 
0@ -= 1 
return 
jump @INTMAN_3134 

:INTMAN_3052
if 
  " + _1260 + @" == 1 
jf @INTMAN_3095 
if 
82D8:   not actor " + PlayerActor + @" current_weapon == 56 
jf @INTMAN_3095 
Player.SetMinWantedLevel(" + PlayerChar + @", 2)

:INTMAN_3095
if and
  " + PLAYER_IN_INTERIOR + @" == 1 
  2@ == 0 
jf @INTMAN_3134 
gosub @INTMAN_3136 
2@ = 1 

:INTMAN_3134
return 

:INTMAN_3136
04EF: release_animation ""BAR"" 
04EF: release_animation ""CASINO"" 
04EF: release_animation ""DANCING"" 
04EF: release_animation ""OTB"" 
04EF: release_animation ""INT_SHOP"" 
04EF: release_animation ""STRIP"" 
04EF: release_animation ""FOOD"" 
04EF: release_animation ""COP_AMBIENT"" 
04EF: release_animation ""INT_OFFICE"" 
04EF: release_animation ""GANGS"" 
Model.Destroy(#CIGAR)
Model.Destroy(#VMAFF1)
Model.Destroy(#VMAFF3)
Model.Destroy(#VMAFF2)
Model.Destroy(#VWFYWAI)
Model.Destroy(#VWFYWA2)
Model.Destroy(#BMYBOUN)
Model.Destroy(#WMYBOUN)
Model.Destroy(#VWFYCRP)
Model.Destroy(#VBFYCRP)
Model.Destroy(#WMYPIZZ)
Model.Destroy(#PIZZAHIGH)
Model.Destroy(#CJ_PIZZA_1)
Model.Destroy(#CJ_PIZZA_2)
Model.Destroy(#WMYBELL)
Model.Destroy(#BURGERHIGH)
Model.Destroy(#CJ_BURG_1)
Model.Destroy(#CJ_BURG_2)
Model.Destroy(#WFYBURG)
Model.Destroy(#WMYCLOT)" );
                remove_references_external_script<WARROBE>();
                remove_references_external_script<CLOTH>();
                remove_references_external_script<JFUD>();
                remove_references_external_script<BARB>();
                remove_references_external_script<TATTO>();
                remove_references_external_script<AMUNAT>();
                remove_references_external_script<CASAMB>();
                remove_references_external_script<BAR>();
                remove_references_external_script<OTBSHP>();
                remove_references_external_script<STRIP>();
                remove_references_external_script<PSHOP>();
                remove_references_external_script<RCSHOP>();
                remove_references_external_script<DANCE>();
                remove_references_external_script<SKBRAIN>();
                remove_references_external_script<FFPNC>();
                remove_references_external_script<BARSTAF>();
                remove_references_external_script<BOUNCER>();
                remove_references_external_script<OTBSTAF>();
                AppendLine( @"065C: release_decision_maker " + Interior_Decision_Maker_A + @" 
065C: release_decision_maker " + Interior_Decision_Maker_B + @" 
" + Interior_Decision_Maker_A + @" = -1 
" + Interior_Decision_Maker_B + @" = -1 
return" );
            }

        }

    }

}