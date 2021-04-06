using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalBonuses : Original {

        Int tmp_arr_horseshoe, tmp_arr_photo, tmp_arr_oyster;

        internal OriginalBonuses() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {

            Array<Pickup> horseshoes = Script.global_array( 50 ),
                          photos = Script.global_array( 50 ),
                          oysters = Script.global_array( 50 );

            tmp_arr_horseshoe = Script.global( horseshoes.startIndex );
            tmp_arr_photo = Script.global( photos.startIndex );
            tmp_arr_oyster = Script.global( oysters.startIndex );

            Script.AppendLine( @"0959: " + tmp_arr_horseshoe + @"[0] = create_horseshoe_at 1224.0 2617.0 11.0 
0959: " + tmp_arr_horseshoe + @"[1] = create_horseshoe_at 2323.0 1284.0 97.0 
0959: " + tmp_arr_horseshoe + @"[2] = create_horseshoe_at 2035.0 2305.0 18.0 
0959: " + tmp_arr_horseshoe + @"[3] = create_horseshoe_at 2491.0 2263.0 15.0 
0959: " + tmp_arr_horseshoe + @"[4] = create_horseshoe_at 1433.0 2796.0 20.0 
0959: " + tmp_arr_horseshoe + @"[5] = create_horseshoe_at 2071.0 712.0 11.0 
0959: " + tmp_arr_horseshoe + @"[6] = create_horseshoe_at 2239.0 1839.0 18.0 
0959: " + tmp_arr_horseshoe + @"[7] = create_horseshoe_at 2583.0 2387.0 16.0 
0959: " + tmp_arr_horseshoe + @"[8] = create_horseshoe_at 2864.0 857.0 13.0 
0959: " + tmp_arr_horseshoe + @"[9] = create_horseshoe_at 2612.0 2200.0 -1.0 
0959: " + tmp_arr_horseshoe + @"[10] = create_horseshoe_at 2274.0 1507.0 24.0 
0959: " + tmp_arr_horseshoe + @"[11] = create_horseshoe_at 2184.0 2529.0 11.0 
0959: " + tmp_arr_horseshoe + @"[12] = create_horseshoe_at 1863.0 2314.0 15.0 
0959: " + tmp_arr_horseshoe + @"[13] = create_horseshoe_at 2054.0 2434.0 166.0 
0959: " + tmp_arr_horseshoe + @"[14] = create_horseshoe_at 1603.0 1435.0 11.0 
0959: " + tmp_arr_horseshoe + @"[15] = create_horseshoe_at 1362.92 1015.24 11.0 
0959: " + tmp_arr_horseshoe + @"[16] = create_horseshoe_at 2058.7 2159.1 16.0 
0959: " + tmp_arr_horseshoe + @"[17] = create_horseshoe_at 2003.0 1672.0 12.0 
0959: " + tmp_arr_horseshoe + @"[18] = create_horseshoe_at 2238.0 1135.0 49.0 
0959: " + tmp_arr_horseshoe + @"[19] = create_horseshoe_at 1934.06 988.79 22.0 
0959: " + tmp_arr_horseshoe + @"[20] = create_horseshoe_at 1768.0 2847.0 9.0 
0959: " + tmp_arr_horseshoe + @"[21] = create_horseshoe_at 1084.0 1076.0 11.0 
0959: " + tmp_arr_horseshoe + @"[22] = create_horseshoe_at 2879.0 2522.0 11.0 
0959: " + tmp_arr_horseshoe + @"[23] = create_horseshoe_at 2371.0 2009.0 15.0 
0959: " + tmp_arr_horseshoe + @"[24] = create_horseshoe_at 1521.0 1690.0 10.6 
0959: " + tmp_arr_horseshoe + @"[25] = create_horseshoe_at 2417.0 1281.0 21.0 
0959: " + tmp_arr_horseshoe + @"[26] = create_horseshoe_at 1376.0 2304.0 15.0 
0959: " + tmp_arr_horseshoe + @"[27] = create_horseshoe_at 1393.0 1832.0 12.34 
0959: " + tmp_arr_horseshoe + @"[28] = create_horseshoe_at 984.0 2563.0 12.0 
0959: " + tmp_arr_horseshoe + @"[29] = create_horseshoe_at 1767.0 601.0 13.0 
0959: " + tmp_arr_horseshoe + @"[30] = create_horseshoe_at 2108.0 1003.0 46.0 
0959: " + tmp_arr_horseshoe + @"[31] = create_horseshoe_at 2705.98 1862.52 24.41 
0959: " + tmp_arr_horseshoe + @"[32] = create_horseshoe_at 2493.0 922.0 16.0 
0959: " + tmp_arr_horseshoe + @"[33] = create_horseshoe_at 1881.0 2846.0 11.0 
0959: " + tmp_arr_horseshoe + @"[34] = create_horseshoe_at 2020.0 2352.0 11.0 
0959: " + tmp_arr_horseshoe + @"[35] = create_horseshoe_at 1680.3 2226.86 16.11 
0959: " + tmp_arr_horseshoe + @"[36] = create_horseshoe_at 1462.0 936.0 10.0 
0959: " + tmp_arr_horseshoe + @"[37] = create_horseshoe_at 2125.5 789.23 11.45 
0959: " + tmp_arr_horseshoe + @"[38] = create_horseshoe_at 2588.0 1902.0 15.0 
0959: " + tmp_arr_horseshoe + @"[39] = create_horseshoe_at 919.0 2070.0 11.0 
0959: " + tmp_arr_horseshoe + @"[40] = create_horseshoe_at 2173.0 2465.0 11.0 
0959: " + tmp_arr_horseshoe + @"[41] = create_horseshoe_at 2031.25 2207.33 11.0 
0959: " + tmp_arr_horseshoe + @"[42] = create_horseshoe_at 2509.0 1144.0 19.0 
0959: " + tmp_arr_horseshoe + @"[43] = create_horseshoe_at 2215.0 1968.0 11.0 
0959: " + tmp_arr_horseshoe + @"[44] = create_horseshoe_at 2626.0 2841.0 11.0 
0959: " + tmp_arr_horseshoe + @"[45] = create_horseshoe_at 2440.08 2161.07 20.0 
0959: " + tmp_arr_horseshoe + @"[46] = create_horseshoe_at 1582.0 2401.0 19.0 
0959: " + tmp_arr_horseshoe + @"[47] = create_horseshoe_at 2077.0 1912.0 14.0 
0959: " + tmp_arr_horseshoe + @"[48] = create_horseshoe_at 970.0 1787.0 11.0 
0959: " + tmp_arr_horseshoe + @"[49] = create_horseshoe_at 1526.22 751.0 29.04 
0958: " + tmp_arr_photo + @"[0] = create_photo_at -2511.28 -672.99 195.75 
0958: " + tmp_arr_photo + @"[1] = create_photo_at -2723.63 -314.72 55.79 
0958: " + tmp_arr_photo + @"[2] = create_photo_at -1737.71 -579.55 26.19 
0958: " + tmp_arr_photo + @"[3] = create_photo_at -1486.08 920.04 41.37 
0958: " + tmp_arr_photo + @"[4] = create_photo_at -1269.82 963.63 130.37 
0958: " + tmp_arr_photo + @"[5] = create_photo_at -1650.01 422.0 21.17 
0958: " + tmp_arr_photo + @"[6] = create_photo_at -1851.72 -96.73 24.37 
0958: " + tmp_arr_photo + @"[7] = create_photo_at -2732.0 -244.0 19.0 
0958: " + tmp_arr_photo + @"[8] = create_photo_at -2802.75 375.47 36.59 
0958: " + tmp_arr_photo + @"[9] = create_photo_at -2773.04 783.45 67.66 
0958: " + tmp_arr_photo + @"[10] = create_photo_at -2680.07 1590.8 143.53 
0958: " + tmp_arr_photo + @"[11] = create_photo_at -2476.75 1543.44 49.26 
0958: " + tmp_arr_photo + @"[12] = create_photo_at -1879.04 1456.52 9.34 
0958: " + tmp_arr_photo + @"[13] = create_photo_at -1561.55 655.19 56.52 
0958: " + tmp_arr_photo + @"[14] = create_photo_at -1325.15 494.19 26.83 
0958: " + tmp_arr_photo + @"[15] = create_photo_at -1941.41 137.72 37.83 
0958: " + tmp_arr_photo + @"[16] = create_photo_at -2153.23 462.25 103.27 
0958: " + tmp_arr_photo + @"[17] = create_photo_at -2243.96 577.76 49.0 
0958: " + tmp_arr_photo + @"[18] = create_photo_at -2051.0 456.0 167.0 
0958: " + tmp_arr_photo + @"[19] = create_photo_at -1951.0 659.0 81.0 
0958: " + tmp_arr_photo + @"[20] = create_photo_at -2064.0 926.0 63.0 
0958: " + tmp_arr_photo + @"[21] = create_photo_at -2357.33 1017.01 59.76 
0958: " + tmp_arr_photo + @"[22] = create_photo_at -2072.0 1066.0 74.0 
0958: " + tmp_arr_photo + @"[23] = create_photo_at -1744.0 972.46 156.89 
0958: " + tmp_arr_photo + @"[24] = create_photo_at -1941.0 883.0 68.0 
0958: " + tmp_arr_photo + @"[25] = create_photo_at -1839.51 1086.88 101.29 
0958: " + tmp_arr_photo + @"[26] = create_photo_at -1704.8 1338.0 14.0 
0958: " + tmp_arr_photo + @"[27] = create_photo_at -2346.62 536.85 86.02 
0958: " + tmp_arr_photo + @"[28] = create_photo_at -2443.0 755.0 49.0 
0958: " + tmp_arr_photo + @"[29] = create_photo_at -2765.0 375.0 15.0 
0958: " + tmp_arr_photo + @"[30] = create_photo_at -2880.31 -935.83 40.82 
0958: " + tmp_arr_photo + @"[31] = create_photo_at -2083.0 -808.0 69.0 
0958: " + tmp_arr_photo + @"[32] = create_photo_at -1954.0 -760.0 53.0 
0958: " + tmp_arr_photo + @"[33] = create_photo_at -964.53 -331.59 47.16 
0958: " + tmp_arr_photo + @"[34] = create_photo_at -1689.0 51.0 38.0 
0958: " + tmp_arr_photo + @"[35] = create_photo_at -2080.0 256.05 107.0 
0958: " + tmp_arr_photo + @"[36] = create_photo_at -2413.0 331.0 37.0 
0958: " + tmp_arr_photo + @"[37] = create_photo_at -2244.42 731.32 61.88 
0958: " + tmp_arr_photo + @"[38] = create_photo_at -2462.0 369.0 59.0 
0958: " + tmp_arr_photo + @"[39] = create_photo_at -1124.44 -153.15 18.5 
0958: " + tmp_arr_photo + @"[40] = create_photo_at -1275.78 53.68 89.07 
0958: " + tmp_arr_photo + @"[41] = create_photo_at -2430.0 38.0 51.0 
0958: " + tmp_arr_photo + @"[42] = create_photo_at -2591.0 162.0 15.0 
0958: " + tmp_arr_photo + @"[43] = create_photo_at -2591.0 -16.0 17.0 
0958: " + tmp_arr_photo + @"[44] = create_photo_at -2648.0 -5.0 31.0 
0958: " + tmp_arr_photo + @"[45] = create_photo_at -2593.0 56.0 16.0 
0958: " + tmp_arr_photo + @"[46] = create_photo_at -1619.31 1341.39 11.3 
0958: " + tmp_arr_photo + @"[47] = create_photo_at -2307.0 207.0 42.0 
0958: " + tmp_arr_photo + @"[48] = create_photo_at -2343.0 -79.0 38.0 
0958: " + tmp_arr_photo + @"[49] = create_photo_at -1906.66 518.58 61.71 
095A: " + tmp_arr_oyster + @"[0] = create_oyster_at 979.0 -2210.0 -3.0 
095A: " + tmp_arr_oyster + @"[1] = create_oyster_at 2750.0 -2584.0 -5.0 
095A: " + tmp_arr_oyster + @"[2] = create_oyster_at 1279.0 -806.0 85.0 
095A: " + tmp_arr_oyster + @"[3] = create_oyster_at 2945.13 -2051.93 -3.0 
095A: " + tmp_arr_oyster + @"[4] = create_oyster_at 67.0 -1018.0 -5.0 
095A: " + tmp_arr_oyster + @"[5] = create_oyster_at 2327.0 -2662.0 -5.0 
095A: " + tmp_arr_oyster + @"[6] = create_oyster_at 2621.0 -2506.0 -5.0 
095A: " + tmp_arr_oyster + @"[7] = create_oyster_at 1249.0 -2687.0 -1.0 
095A: " + tmp_arr_oyster + @"[8] = create_oyster_at 725.0 -1849.0 -5.0 
095A: " + tmp_arr_oyster + @"[9] = create_oyster_at 723.0 -1586.0 -3.0 
095A: " + tmp_arr_oyster + @"[10] = create_oyster_at 155.0 -1975.0 -8.0 
095A: " + tmp_arr_oyster + @"[11] = create_oyster_at 1968.0 -1203.0 17.0 
095A: " + tmp_arr_oyster + @"[12] = create_oyster_at -2657.0 1564.0 -6.0 
095A: " + tmp_arr_oyster + @"[13] = create_oyster_at -1252.0 501.0 -8.0 
095A: " + tmp_arr_oyster + @"[14] = create_oyster_at -1625.0 4.0 -10.0 
095A: " + tmp_arr_oyster + @"[15] = create_oyster_at -1484.0 1489.0 -10.0 
095A: " + tmp_arr_oyster + @"[16] = create_oyster_at -2505.406 1543.724 -22.5553 
095A: " + tmp_arr_oyster + @"[17] = create_oyster_at -2727.0 -469.0 -5.0 
095A: " + tmp_arr_oyster + @"[18] = create_oyster_at -1266.0 966.0 -10.0 
095A: " + tmp_arr_oyster + @"[19] = create_oyster_at -1013.0 478.0 -7.0 
095A: " + tmp_arr_oyster + @"[20] = create_oyster_at -1364.0 390.0 -5.0 
095A: " + tmp_arr_oyster + @"[21] = create_oyster_at 2578.0 2382.0 16.0 
095A: " + tmp_arr_oyster + @"[22] = create_oyster_at 2090.0 1898.0 8.0 
095A: " + tmp_arr_oyster + @"[23] = create_oyster_at 2130.0 1152.0 7.0 
095A: " + tmp_arr_oyster + @"[24] = create_oyster_at 2013.0 1670.0 7.0 
095A: " + tmp_arr_oyster + @"[25] = create_oyster_at 2531.0 1569.0 9.0 
095A: " + tmp_arr_oyster + @"[26] = create_oyster_at 2998.0 2998.0 -10.0 
095A: " + tmp_arr_oyster + @"[27] = create_oyster_at -832.0 925.0 -2.0 
095A: " + tmp_arr_oyster + @"[28] = create_oyster_at 486.0 -253.0 -4.0 
095A: " + tmp_arr_oyster + @"[29] = create_oyster_at -90.0 -910.0 -5.0 
095A: " + tmp_arr_oyster + @"[30] = create_oyster_at 26.43 -1320.94 -10.04 
095A: " + tmp_arr_oyster + @"[31] = create_oyster_at -207.0 -1682.0 -8.0 
095A: " + tmp_arr_oyster + @"[32] = create_oyster_at -1672.0 -1641.0 -2.0 
095A: " + tmp_arr_oyster + @"[33] = create_oyster_at -1175.0 -2639.0 -2.5 
095A: " + tmp_arr_oyster + @"[34] = create_oyster_at -1097.0 -2858.0 -8.0 
095A: " + tmp_arr_oyster + @"[35] = create_oyster_at -2889.0 -1042.0 -9.0 
095A: " + tmp_arr_oyster + @"[36] = create_oyster_at -659.0 874.0 -2.0 
095A: " + tmp_arr_oyster + @"[37] = create_oyster_at -955.0 2628.0 35.0 
095A: " + tmp_arr_oyster + @"[38] = create_oyster_at -1066.0 2197.0 32.0 
095A: " + tmp_arr_oyster + @"[39] = create_oyster_at 40.0 -531.0 -8.0 
095A: " + tmp_arr_oyster + @"[40] = create_oyster_at -765.0 247.0 -8.0 
095A: " + tmp_arr_oyster + @"[41] = create_oyster_at 2098.0 -108.0 -2.0 
095A: " + tmp_arr_oyster + @"[42] = create_oyster_at 2767.0 470.0 -8.0 
095A: " + tmp_arr_oyster + @"[43] = create_oyster_at -783.0 2116.0 35.0 
095A: " + tmp_arr_oyster + @"[44] = create_oyster_at -821.0 1374.0 -8.0 
095A: " + tmp_arr_oyster + @"[45] = create_oyster_at -2110.5 2329.72 -7.5 
095A: " + tmp_arr_oyster + @"[46] = create_oyster_at -1538.0 1708.0 -3.27 
095A: " + tmp_arr_oyster + @"[47] = create_oyster_at -2685.0 2153.0 -5.0 
095A: " + tmp_arr_oyster + @"[48] = create_oyster_at 796.0 2939.0 -5.0 
095A: " + tmp_arr_oyster + @"[49] = create_oyster_at 2179.0 235.0 -5.0" );
            Script.create_thread<COLLS>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private class COLLS : Thread {

            Int All_Ousters_Collected = global(),
                All_Horseshoes_Collected = global(),
                All_Photos_Taken = global(),
                All_Tags_Sprayed = global(),
                _100_Percent_Complete = global(),
                end_flag = global();

            Array<Pickup> torenoWeapons = global_array( 4 ),
                          casinoWeapons = global_array( 4 ),
                          garageWeapons = global_array( 4 ),
                          jonsonWeapons = global_array( 4 );

            Int stat_var = local();
            Float stat_var_f = local( 0 );

            public override void START( LabelJump label ) { Jump += LOOP; }

            private void LOOP( LabelJump label ) {
                wait( 3000 );

                and( All_Ousters_Collected == 0, delegate { // 1
                    get_int_stat( 243, stat_var );
                    and( stat_var == 50, delegate {
                        set_int_stat( 225, 1000 );
                        torenoWeapons[ 0 ].create_with_ammo( WeaponModel.ROCKETLA, 15, 20, -686.0, 934.0, 13.5 );
                        torenoWeapons[ 1 ].create_with_ammo( WeaponModel.HEATSEEK, 15, 15, -690.0, 934.0, 13.5 );
                        torenoWeapons[ 2 ].create_with_ammo( WeaponModel.MINIGUN, 15, 500, -690.0, 939.0, 13.5 );
                        torenoWeapons[ 3 ].create_with_ammo( WeaponModel.FLAME, 15, 300, -686.0, 939.0, 13.5 );
                        //remove_text_box();
                        //show_text_box( "OYST100" ); // ‹ce pakyҐkњ co—pa®Ё! KЄ¦њ, Eћe®a, Ђap—apa њ –њҐeћ© ўce™љa —yљy¦ xo¦e¦© ¦e—¬, ў ®eџaўњcњЇoc¦њ o¦ ¦o™o, kak ¦Ё ўЁ™ћ¬љњҐ©!
                        play_music( 2 );
                        All_Ousters_Collected.value = true;
                        end_flag += 1;
                    } );
                } );

                and( All_Horseshoes_Collected == 0, delegate { // 2
                    get_int_stat( 241, stat_var );
                    and( stat_var == 50, delegate {
                        casinoWeapons[ 0 ].create_with_ammo( WeaponModel.M4, 15, 60, 2021.879, 1001.467, 10.3203 );
                        casinoWeapons[ 1 ].create_with_ammo( WeaponModel.MP5LNG, 15, 120, 2025.286, 1001.496, 10.3203 );
                        casinoWeapons[ 2 ].create_with_ammo( WeaponModel.SHOTGSPA, 15, 120, 2021.327, 1013.349, 10.3203 );
                        casinoWeapons[ 3 ].create_with_ammo( WeaponModel.SATCHEL, 15, 20, 2023.775, 1013.527, 10.5203 );
                        remove_text_box();
                        show_text_box( "LUCK100" ); // ‹ce ЈoљkoўЁ co—pa®Ё! K kaџњ®o Ќe¦Ёpe ѓpako®a љoc¦aўћe®o opy›њe!
                        play_music( 2 );
                        All_Horseshoes_Collected.value = true;
                        end_flag += 1;
                    } );
                } );

                and( All_Photos_Taken == 0, delegate { // 3
                    get_int_stat( 231, stat_var );
                    and( stat_var == 50, delegate {
                        garageWeapons[ 0 ].create_with_ammo( WeaponModel.SNIPER, 15, 60, -2035.773, 139.4337, 28.3359 );
                        garageWeapons[ 1 ].create_with_ammo( WeaponModel.MICRO_UZI, 15, 120, -2038.43, 139.6281, 28.3359 );
                        garageWeapons[ 2 ].create_with_ammo( WeaponModel.CHROMEGUN, 15, 120, -2038.664, 137.4694, 28.3359 );
                        garageWeapons[ 3 ].create_with_ammo( WeaponModel.GRENADE, 15, 20, -2035.474, 137.2511, 28.3359 );
                        remove_text_box();
                        show_text_box( "FOTO100" ); // ‹ce c®њЇkњ cљeћa®Ё! ‹ ™apa› Ca®-Ѓњeppo љoc¦aўћe®o opy›њe!
                        play_music( 2 );
                        All_Photos_Taken.value = true;
                        end_flag += 1;
                    } );
                } );

                and( All_Tags_Sprayed == 0, delegate { // 4
                    get_total_tags_sprayed( stat_var );
                    and( stat_var == 100, delegate {
                        jonsonWeapons[ 0 ].create_with_ammo( WeaponModel.AK47, 15, 120, 2499.39, -1707.463, 1014.25 );
                        jonsonWeapons[ 1 ].create_with_ammo( WeaponModel.TEC9, 15, 120, 2499.514, -1709.64, 1014.25 );
                        jonsonWeapons[ 2 ].create_with_ammo( WeaponModel.SAWNOFF, 15, 60, 2493.491, -1708.237, 1014.932 );
                        jonsonWeapons[ 3 ].create_with_ammo( WeaponModel.MOLOTOV, 15, 20, 2493.553, -1706.863, 1015.132 );
                        remove_text_box();
                        show_text_box( "TAG_100" ); // ЏЁ џakpacњћ ўce ™paњ¦њ ў ™opoљe! Џўo¬ —a®љa Јoћy¤њћa ЈoљkpeЈћe®њe! K љoЇy CJ'¬ ў ‡oc-Ca®¦oce љoc¦aўћe®o opy›њe!
                        set_gang_weapons( 1, 24, 29, 4 );
                        play_music( 2 );
                        All_Tags_Sprayed.value = true;
                        end_flag += 1;
                    } );
                } );

                and( _100_Percent_Complete == 0, delegate { // 5
                    get_progress_percentage( stat_var_f );
                    and( stat_var_f >= 100.0, delegate {
                        and( PlayerChar.is_defined(), delegate {
                            Car parked_Rhino = Script.global(), parked_Hydra = Script.global();
                            CAR_PARK.init( parked_Rhino, 2435.302, -1671.848, 12.8007, 90.0, RHINO, forceSpawn_bool: 1 );
                            CAR_PARK.init( parked_Hydra, 2527.2, -1677.1, 19.2, 90.0, HYDRA, forceSpawn_bool: 1 );
                            CAR_PARK.set_chance_to_generate( parked_Rhino, 101 );
                            CAR_PARK.set_chance_to_generate( parked_Hydra, 101 );
                            PlayerChar.add_money( 1000000 );
                            set_int_stat( 225, 1000 );
                            set_int_stat( 22 , 1000 );
                            set_int_stat( 25 , 1000 );
                            set_int_stat( 80 , 1000 );
                            set_int_stat( 68 , 1000 );
                            set_int_stat( 65 , 1000 );
                            set_int_stat( 66 , 1000 );
                            set_int_stat( 230, 1000 );
                            remove_text_box();
                            show_text_box( "GAME100" ); // …™pa Јpoќљe®a ®a 100%! Џўoњ c¦a¦њc¦њka њ љe®e›®Ёe cpeљc¦ўa џaЇe¦®o ўoџpocћњ! Rhino њ Hydra љoc¦aўћe®Ё k љoЇy CJ'¬ ®a ‚poyў C¦pњ¦.
                            play_music( 2 );
                            _100_Percent_Complete.value = true;
                            end_flag += 1;
                        } );
                    } );
                } );
                and( end_flag == 5, delegate { Jump += END_SCRIPT; } );
                jump( LOOP );
            }

            private void END_SCRIPT( LabelJump label ) { end_thread(); }

        }

    }

}