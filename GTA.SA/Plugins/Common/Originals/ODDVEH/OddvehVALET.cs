using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class VALET : External {

            Int tmp_1887 = global( _1887.startIndex ),
                tmp_1874 = global( _1874.startIndex ),
                tmp_10768 = global( _10768.startIndex ),
                tmp_10771 = global( _10771.startIndex ),
                tmp_10774 = global( _10774.startIndex ),
                tmp_10756 = global( _10756.startIndex ),
                tmp_10759 = global( _10759.startIndex ),
                tmp_10762 = global( _10762.startIndex ),
                tmp_10780 = global( _10780.startIndex ),
                tmp_10783 = global( _10783.startIndex ),
                tmp_10786 = global( _10786.startIndex ),
                tmp_10765 = global( _10765.startIndex ),
                tmp_10777 = global( _10777.startIndex ),
                tmp_10789 = global( _10789.startIndex ),
                tmp_1892 = global( _1892.startIndex ),
                tmp_10844 = global( _10844.startIndex ),
                tmp_10848 = global( _10848.startIndex ),
                tmp_10852 = global( _10852.startIndex ),
                tmp_10856 = global( _10856.startIndex ),
                tmp_10792 = global( _10792.startIndex ),
                tmp_10800 = global( _10800.startIndex ),
                tmp_10796 = global( _10796.startIndex ),
                tmp_10804 = global( _10804.startIndex ),
                tmp_10808 = global( _10808.startIndex ),
                tmp_10816 = global( _10816.startIndex ),
                tmp_10824 = global( _10824.startIndex ),
                tmp_10812 = global( _10812.startIndex ),
                tmp_10820 = global( _10820.startIndex ),
                tmp_10828 = global( _10828.startIndex ),
                tmp_10860 = global( _10860.startIndex ),
                tmp_10864 = global( _10864.startIndex ),
                tmp_10868 = global( _10868.startIndex ),
                tmp_10872 = global( _10872.startIndex ),
                tmp_10876 = global( _10876.startIndex ),
                tmp_10880 = global( _10880.startIndex ),
                tmp_10884 = global( _10884.startIndex ),
                tmp_10888 = global( _10888.startIndex ),
                tmp_10892 = global( _10892.startIndex ),
                tmp_10832 = global( _10832.startIndex ),
                tmp_10836 = global( _10836.startIndex ),
                tmp_10840 = global( _10840.startIndex ),
                tmp_10896 = global( _10896.startIndex ),
                tmp_10900 = global( _10900.startIndex ),
                tmp_10904 = global( _10904.startIndex ),
                tmp_10908 = global( _10908.startIndex ),
                tmp_10912 = global( _10912.startIndex ),
                tmp_10916 = global( _10916.startIndex ),
                tmp_10920 = global( _10920.startIndex ),
                tmp_10924 = global( _10924.startIndex ),
                tmp_1878 = global( _1878.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"8@ = 0 
5@ = 1 
" + _1883 + @" = 1 
" + _1896 + @" = 0 
" + tmp_1887 + @"[0] = 1 
" + tmp_1887 + @"[1] = 1 
" + tmp_1887 + @"[2] = 1 
4@ = 0 
if 
  8@ == 99 
else_jump @VALET_400 
" + tmp_1874 + @"(6@,3i) = Actor.Create(CivMale, #WMYVA, " + tmp_10756 + @"(6@,3f), " + tmp_10759 + @"(6@,3f), " + tmp_10762 + @"(6@,3f))
" + _10748 + @" = Actor.Create(CivMale, #WMYVA, " + tmp_10756 + @"(6@,3f), " + tmp_10759 + @"(6@,3f), " + tmp_10762 + @"(6@,3f))
" + _1877 + @" = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
" + tmp_1878 + @"[1] = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
" + _1881 + @" = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
" + _10934 + @" = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
" + _1867 + @" = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
" + _10946 + @" = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
" + _1882 + @" = Car.Create(#CHEETAH, 0.0, 0.0, 0.0)
19@ = Marker.CreateAboveCar(" + _1877 + @")
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 
07E5: copy_decision_maker 65542 to 7@ 
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 

:VALET_400
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_421 
Actor.DestroyInstantly(" + tmp_1874 + @"[0])

:VALET_421
04AE: " + tmp_1892 + @"[0] = 1 
" + tmp_1887 + @"[0] = 1 
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_456 
Actor.DestroyInstantly(" + tmp_1874 + @"[1])

:VALET_456
04AE: " + tmp_1892 + @"[1] = 1 
" + tmp_1887 + @"[1] = 1 
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_491 
Actor.DestroyInstantly(" + tmp_1874 + @"[2])

:VALET_491
04AE: " + tmp_1892 + @"[2] = 1 
" + tmp_1887 + @"[2] = 1 
" + tmp_10756 + @"[0] = 330.4229 
" + tmp_10756 + @"[1] = 328.9663 
" + tmp_10756 + @"[2] = 326.4376 
" + tmp_10759 + @"[0] = -1510.783 
" + tmp_10759 + @"[1] = -1512.467 
" + tmp_10759 + @"[2] = -1515.406 
" + tmp_10762 + @"[0] = 35.0247 
" + tmp_10762 + @"[1] = 35.0247 
" + tmp_10762 + @"[2] = 35.0313 
" + tmp_10765 + @"[0] = 222.0 
" + tmp_10765 + @"[1] = 222.0 
" + tmp_10765 + @"[2] = 222.0 
" + tmp_10768 + @"[0] = -1761.029 
" + tmp_10768 + @"[1] = -1759.914 
" + tmp_10768 + @"[2] = -1749.713 
" + tmp_10771 + @"[0] = 959.5504 
" + tmp_10771 + @"[1] = 960.2669 
" + tmp_10771 + @"[2] = 960.1956 
" + tmp_10774 + @"[0] = 23.8828 
" + tmp_10774 + @"[1] = 23.8828 
" + tmp_10774 + @"[2] = 23.8906 
" + tmp_10777 + @"[0] = 204.3268 
" + tmp_10777 + @"[1] = 199.167 
" + tmp_10777 + @"[2] = 142.3291 
" + tmp_10780 + @"[0] = 2029.758 
" + tmp_10780 + @"[1] = 2027.666 
" + tmp_10780 + @"[2] = 2026.394 
" + tmp_10783 + @"[0] = 1905.943 
" + tmp_10792 + @"[1] = 336.9336 
" + tmp_10796 + @"[1] = 323.919 
" + tmp_10800 + @"[1] = -1531.027 
" + tmp_10804 + @"[1] = -1504.174 
" + tmp_10792 + @"[2] = -1768.295 
" + tmp_10796 + @"[2] = -1729.094 
" + tmp_10800 + @"[2] = 958.9591 
" + tmp_10804 + @"[2] = 942.184 
" + tmp_10792 + @"[3] = 2050.881 
" + tmp_10796 + @"[3] = 2016.906 
" + tmp_10800 + @"[3] = 1958.541 
" + tmp_10804 + @"[3] = 1871.065 
" + tmp_10808 + @"[1] = 336.0477 
" + tmp_10816 + @"[1] = -1452.225 
" + tmp_10824 + @"[1] = 31.9445 
" + tmp_10812 + @"[1] = 271.6679 
" + tmp_10820 + @"[1] = -1550.242 
" + tmp_10828 + @"[1] = 23.1681 
" + tmp_10808 + @"[2] = -1760.178 
" + tmp_10816 + @"[2] = 972.2405 
" + tmp_10824 + @"[2] = 16.1633 
" + tmp_10812 + @"[2] = -1679.605 
" + tmp_10820 + @"[2] = 1064.293 
" + tmp_10828 + @"[2] = 24.8629 
" + tmp_10808 + @"[3] = 1968.502 
" + tmp_10816 + @"[3] = 1755.079 
" + tmp_10824 + @"[3] = 11.4898 
" + tmp_10812 + @"[3] = 1917.811 
" + tmp_10820 + @"[3] = 1788.146 
" + tmp_10828 + @"[3] = 17.3118 
" + tmp_10844 + @"[1] = 363.3463 
" + tmp_10848 + @"[1] = -1522.373 
" + tmp_10852 + @"[1] = 393.1729 
" + tmp_10856 + @"[1] = -1479.321 
" + tmp_10860 + @"[1] = 125.0 
" + tmp_10864 + @"[1] = 324.8593 
" + tmp_10868 + @"[1] = -1591.327 
" + tmp_10872 + @"[1] = 324.8593 
" + tmp_10876 + @"[1] = -1591.327 
" + tmp_10880 + @"[1] = 338.0 
" + tmp_10864 + @"[2] = -1743.524 
" + tmp_10868 + @"[2] = 930.9304 
" + tmp_10872 + @"[2] = -1780.081 
" + tmp_10876 + @"[2] = 908.4018 
" + tmp_10880 + @"[2] = 270.0 
" + tmp_10844 + @"[2] = -1737.715 
" + tmp_10848 + @"[2] = 943.7812 
" + tmp_10852 + @"[2] = -1704.216 
" + tmp_10856 + @"[2] = 911.4586 
" + tmp_10860 + @"[2] = 45.0 
" + tmp_10844 + @"[3] = 2067.529 
" + tmp_10848 + @"[3] = 1957.289 
" + tmp_10852 + @"[3] = 2097.263 
" + tmp_10856 + @"[3] = 1976.0 
" + tmp_10860 + @"[3] = 120.0 
" + tmp_10864 + @"[3] = 2051.536 
" + tmp_10868 + @"[3] = 1933.685 
" + tmp_10872 + @"[3] = 2062.818 
" + tmp_10876 + @"[3] = 1905.085 
" + tmp_10880 + @"[3] = 7.0 
" + tmp_10884 + @"[1] = 332.8306 
" + tmp_10888 + @"[1] = -1516.251 
" + tmp_10892 + @"[1] = 34.8606 
" + tmp_10884 + @"[2] = -1754.514 
" + tmp_10888 + @"[2] = 953.5991 
" + tmp_10892 + @"[2] = 23.75 
" + tmp_10884 + @"[3] = 2035.729 
" + tmp_10888 + @"[3] = 1912.09 
" + tmp_10892 + @"[3] = 11.1751 
" + tmp_10832 + @"[0] = -1748.376 
" + tmp_10836 + @"[0] = 985.3066 
" + tmp_10840 + @"[0] = 17.9009 
" + tmp_10832 + @"[1] = 330.7534 
" + tmp_10836 + @"[1] = -1474.608 
" + tmp_10840 + @"[1] = 24.9126 
" + tmp_10832 + @"[2] = -1738.28 
" + tmp_10836 + @"[2] = 985.5498 
" + tmp_10840 + @"[2] = 16.6718 
" + tmp_10832 + @"[3] = 2061.337 
" + tmp_10836 + @"[3] = 1808.956 
" + tmp_10840 + @"[3] = 9.6719 
" + tmp_10896 + @"[1] = 403.2297 
" + tmp_10900 + @"[1] = -1475.298 
" + tmp_10904 + @"[1] = 30.0032 
" + tmp_10908 + @"[1] = 128.9467 
" + tmp_10912 + @"[1] = 341.1339 
" + tmp_10916 + @"[1] = -1556.116 
" + tmp_10920 + @"[1] = 31.9903 
" + tmp_10924 + @"[1] = 328.7578 
" + tmp_10896 + @"[2] = -1717.204 
" + tmp_10900 + @"[2] = 962.7901 
" + tmp_10904 + @"[2] = 23.7474 
" + tmp_10908 + @"[2] = 179.9692 
" + tmp_10912 + @"[2] = -1791.269 
" + tmp_10916 + @"[2] = 886.3627 
" + tmp_10920 + @"[2] = 23.75 
" + tmp_10924 + @"[2] = 359.2426 
" + tmp_10896 + @"[3] = 2073.563 
" + tmp_10900 + @"[3] = 1879.736 
" + tmp_10904 + @"[3] = 10.4288 
" + tmp_10908 + @"[3] = 45.5873 
" + tmp_10912 + @"[3] = 2084.156 
" + tmp_10916 + @"[3] = 1965.573 
" + tmp_10920 + @"[3] = 9.9974 
" + tmp_10924 + @"[3] = 117.4401 
065C: release_decision_maker 7@ 
07E5: copy_decision_maker 65542 to 7@ 
0709: set_decision_maker 7@ on_event 9 taskID 200 respect 0.0 hate 100.0 like 100.0 dislike 100.0 in_car 1 on_foot 1 
0709: set_decision_maker 7@ on_event 15 taskID 415 respect 0.0 hate 20.0 like 20.0 dislike 20.0 in_car 0 on_foot 1 
0709: set_decision_maker 7@ on_event 15 taskID 200 respect 0.0 hate 80.0 like 80.0 dislike 80.0 in_car 1 on_foot 1 
" + _1896 + @" = 1 

:VALET_1959
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @VALET_2291 
if 
  " + _1873 + @" == 1 
else_jump @VALET_2004 
gosub @VALET_16850 

:VALET_2004
if 
   not " + _10753 + @" == 1 
else_jump @VALET_2284 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_2284 
if 
  5@ == 1 
else_jump @VALET_2095 
if 
0500:   player " + PlayerChar + @" skin == ""VALET"" on_bodypart 17 
else_jump @VALET_2088 
5@ = 0 

:VALET_2088
jump @VALET_2127 

:VALET_2095
if 
8500:   not player " + PlayerChar + @" skin == ""VALET"" on_bodypart 17 
else_jump @VALET_2127 
5@ = 1 

:VALET_2127
gosub @VALET_2371 
if 
  " + _1896 + @" == 1 
else_jump @VALET_2284 
gosub @VALET_3854 
gosub @VALET_7842 
gosub @VALET_13021 
gosub @VALET_16071 
if 
001D:   32@ > 8@ 
else_jump @VALET_2215 
0085: 8@ = 32@ 
8@ += 2300 

:VALET_2215
if 
001D:   32@ > 9@ 
else_jump @VALET_2249 
0085: 9@ = 32@ 
9@ += 100 

:VALET_2249
if 
001D:   32@ > 10@ 
else_jump @VALET_2284 
0085: 10@ = 32@ 
10@ += 900 

:VALET_2284
jump @VALET_2364 

:VALET_2291
if 
  " + _1896 + @" == 1 
else_jump @VALET_2364 
if 
  " + _1870 + @" == 1 
else_jump @VALET_2357 
" + _1870 + @" = 0 
" + OnMission + @" = 0 
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  

:VALET_2357
gosub @VALET_16850 

:VALET_2364
jump @VALET_1959 

:VALET_2371
if 
001D:   32@ > 16@ 
else_jump @VALET_3353 
0085: 16@ = 32@ 
16@ += 1000 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
" + _1884 + @" = 0 
if 
00A3:   actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA -1893.419 1119.227 cornerB -1617.915 828.85 
else_jump @VALET_2472 
" + _1884 + @" = 2 

:VALET_2472
if 
  " + _1884 + @" == 0 
else_jump @VALET_3118 
077E: get_active_interior_to " + _10930 + @" 
if 
  " + _10930 + @" == 0 
else_jump @VALET_2894 
if 
  " + _10931 + @" == 0 
else_jump @VALET_2887 
if 
  " + _10932 + @" == 0 
else_jump @VALET_2670 
if 
  " + _1896 + @" == 1 
else_jump @VALET_2663 
if 
   not " + _1886 + @" == 1 
else_jump @VALET_2663 
if 
  " + _1870 + @" == 1 
else_jump @VALET_2649 
" + _1870 + @" = 0 
" + OnMission + @" = 0 
00BB: show_text_lowpriority GXT 'VAL_A9' time 4000 flag 1  
00BA: show_text_styled GXT 'VAL_A6' time 4000 style 1  

:VALET_2649
gosub @VALET_16850 
" + _1896 + @" = 0 

:VALET_2663
jump @VALET_2887 

:VALET_2670
" + _10931 + @" = 1 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_2747 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[0]) = True
if 
   Actor.Driving(" + tmp_1874 + @"[0])
else_jump @VALET_2747 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[0] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_2747 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = True

:VALET_2747
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_2817 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[1]) = True
if 
   Actor.Driving(" + tmp_1874 + @"[1])
else_jump @VALET_2817 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[1] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_2817 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = True

:VALET_2817
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_2887 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[2]) = True
if 
   Actor.Driving(" + tmp_1874 + @"[2])
else_jump @VALET_2887 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[2] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_2887 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = True

:VALET_2887
jump @VALET_3111 

:VALET_2894
" + _10931 + @" = 1 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_2971 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[0]) = True
if 
   Actor.Driving(" + tmp_1874 + @"[0])
else_jump @VALET_2971 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[0] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_2971 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = True

:VALET_2971
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_3041 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[1]) = True
if 
   Actor.Driving(" + tmp_1874 + @"[1])
else_jump @VALET_3041 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[1] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_3041 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = True

:VALET_3041
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_3111 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[2]) = True
if 
   Actor.Driving(" + tmp_1874 + @"[2])
else_jump @VALET_3111 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[2] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_3111 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = True

:VALET_3111
jump @VALET_3353 

:VALET_3118
if 
  " + _10931 + @" == 1 
else_jump @VALET_3353 
" + _10931 + @" = 0 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_3213 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[0]) = False
if 
   Actor.Driving(" + tmp_1874 + @"[0])
else_jump @VALET_3213 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[0] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_3213 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = False

:VALET_3213
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_3283 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[1]) = False
if 
   Actor.Driving(" + tmp_1874 + @"[1])
else_jump @VALET_3283 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[1] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_3283 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = False

:VALET_3283
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_3353 
Actor.LockInCurrentPosition(" + tmp_1874 + @"[2]) = False
if 
   Actor.Driving(" + tmp_1874 + @"[2])
else_jump @VALET_3353 
0811: " + tempvar_Actor_Car + @" = actor " + tmp_1874 + @"[2] used_car 
if 
   not Car.Wrecked(" + tempvar_Actor_Car + @")
else_jump @VALET_3353 
Car.LockInCurrentPosition(" + tempvar_Actor_Car + @") = False

:VALET_3353
if 
  " + _10750 + @" == 1 
else_jump @VALET_3597 
if 
  " + _1884 + @" == 1 
else_jump @VALET_3444 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 328.1585 -1512.888 35.0247 radius 10.0 10.0 10.0 
else_jump @VALET_3444 
" + _10750 + @" = 0 

:VALET_3444
if 
  " + _1884 + @" == 2 
else_jump @VALET_3517 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere -1753.936 961.8587 23.8906 radius 10.0 10.0 10.0 
else_jump @VALET_3517 
" + _10750 + @" = 0 

:VALET_3517
if 
  " + _1884 + @" == 3 
else_jump @VALET_3590 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 2021.337 1918.236 11.3438 radius 10.0 10.0 10.0 
else_jump @VALET_3590 
" + _10750 + @" = 0 

:VALET_3590
jump @VALET_3852 

:VALET_3597
if 
   not " + OnMission + @" == 1 
else_jump @VALET_3852 
if 
  " + _1869 + @" == 1 
else_jump @VALET_3852 
if 
  " + _1870 + @" == 0 
else_jump @VALET_3852 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_3852 
if 
  " + _1884 + @" == 2 
else_jump @VALET_3852 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere -1753.936 961.8587 23.8906 radius 2.0 2.0 2.0 on_foot 
else_jump @VALET_3852 
if 
0500:   player " + PlayerChar + @" skin == ""VALET"" on_bodypart 17 
else_jump @VALET_3836 
if 
   not Player.WantedLevel(" + PlayerChar + @") > 0
else_jump @VALET_3813 
00BC: show_text_highpriority GXT 'VAL_A7' time 5000 flag 1  
" + _1870 + @" = 1 
" + OnMission + @" = 1 
jump @VALET_3829 

:VALET_3813
00BC: show_text_highpriority GXT 'VAL_C1' time 1000 flag 1  

:VALET_3829
jump @VALET_3852 

:VALET_3836
00BC: show_text_highpriority GXT 'VAL_90' time 1000 flag 1  

:VALET_3852
return 

:VALET_3854
if 
  " + _1870 + @" == 1 
else_jump @VALET_7840 
if 
   Player.WantedLevel(" + PlayerChar + @") > 1
else_jump @VALET_3894 
06D0: enable_emergency_traffic 1 

:VALET_3894
if 
8500:   not player " + PlayerChar + @" skin == ""VALET"" on_bodypart 17 
else_jump @VALET_3958 
00BA: show_text_styled GXT 'VAL_A6' time 4000 style 1  
00BB: show_text_lowpriority GXT 'VAL_B1' time 5000 flag 1  
" + _10936 + @" = 8 

:VALET_3958
if 
   not " + _10934 + @" == 0 
else_jump @VALET_4102 
if 
856E:   not car " + _10934 + @" defined 
else_jump @VALET_4047 
if 
  " + _10937 + @" > 0 
else_jump @VALET_4033 
00BA: show_text_styled GXT 'VAL_A6' time 4000 style 1  
" + _10936 + @" = 8 

:VALET_4033
" + _10934 + @" = 0 
jump @VALET_4102 

:VALET_4047
if 
   Car.Wrecked(" + _10934 + @")
else_jump @VALET_4102 
00BA: show_text_styled GXT 'VAL_A6' time 4000 style 1  
00BB: show_text_lowpriority GXT 'VAL_B6' time 5000 flag 1  
" + _10936 + @" = 8 

:VALET_4102
if 
  " + _5286 + @" == 0 
else_jump @VALET_4152 
if 
   not Car.Wrecked(" + _10946 + @")
else_jump @VALET_4152 
0987: get_car_blocking_car " + _10946 + @" store_to " + VALET_Car + @" 
0084: " + _10754 + @" = " + VALET_Car + @" 

:VALET_4152
if 
  " + _10936 + @" == 0 
else_jump @VALET_4575 
if 
   Model.Available(#WMYVA)
else_jump @VALET_4570 
if 
   Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_4263 
" + tmp_1874 + @"[0] = Actor.Create(CivMale, #WMYVA, -1783.804, 968.6431, 23.7343)
060B: set_actor " + tmp_1874 + @"[0] decision_maker_to 7@ 
02A9: set_actor " + tmp_1874 + @"[0] immune_to_nonplayer 1 
0446: set_actor " + tmp_1874 + @"[0] dismemberment_possible 0 
" + tmp_1892 + @"[0] = 2 
0@ = 2 

:VALET_4263
if 
   Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_4340 
" + tmp_1874 + @"[1] = Actor.Create(CivMale, #WMYVA, -1782.65, 965.0251, 23.8906)
060B: set_actor " + tmp_1874 + @"[1] decision_maker_to 7@ 
02A9: set_actor " + tmp_1874 + @"[1] immune_to_nonplayer 1 
0446: set_actor " + tmp_1874 + @"[1] dismemberment_possible 0 
" + tmp_1892 + @"[1] = 2 
1@ = 2 

:VALET_4340
if 
   Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_4417 
" + tmp_1874 + @"[2] = Actor.Create(CivMale, #WMYVA, -1783.731, 965.4009, 23.8961)
060B: set_actor " + tmp_1874 + @"[2] decision_maker_to 7@ 
02A9: set_actor " + tmp_1874 + @"[2] immune_to_nonplayer 1 
0446: set_actor " + tmp_1874 + @"[2] dismemberment_possible 0 
" + tmp_1892 + @"[2] = 2 
2@ = 2 

:VALET_4417
03DE: set_pedestrians_density_multiplier_to 0.3 
06D0: enable_emergency_traffic 0 
" + _10934 + @" = 0 
054C: use_GXT_table 'VALET1' 
00BE: text_clear_all 
00BA: show_text_styled GXT 'VAL_A7' time 3000 style 1  
" + VALET_Parked_Cars_Number + @" = 0 
0085: 17@ = 32@ 
17@ += 4000 
" + _10936 + @" = 1 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_4517 
039E: set_actor " + tmp_1874 + @"[0] locked 1 while_in_car 

:VALET_4517
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_4540 
039E: set_actor " + tmp_1874 + @"[1] locked 1 while_in_car 

:VALET_4540
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_4563 
039E: set_actor " + tmp_1874 + @"[2] locked 1 while_in_car 

:VALET_4563
jump @VALET_4575 

:VALET_4570
Model.Load(#WMYVA)

:VALET_4575
if 
  " + _10936 + @" == 1 
else_jump @VALET_4642 
if 
001D:   32@ > 17@ 
else_jump @VALET_4642 
" + _10933 + @" = 3 
" + _10935 + @" = 2 
18@ = 1 
00BE: text_clear_all 
" + _10936 + @" = 2 

:VALET_4642
if 
  " + _10936 + @" == 2 
else_jump @VALET_4947 
if 
001D:   32@ > 17@ 
else_jump @VALET_4947 
00BE: text_clear_all 
01E3: show_text_1number_styled GXT 'VAL_60' number 18@ time 4000 style 1  
02FD: show_text_2numbers_lowpriority GXT 'VAL_76' numbers " + _10933 + @" " + _10935 + @" time 4000 flag 1  
" + _10935 + @" *= 60000 
0151: remove_status_text " + _10935 + @" 
0151: remove_status_text " + _10933 + @" 
03C3: set_timer_to " + _10935 + @" type 1 GXT 'VAL_A8' 
04F7: status_text " + _10933 + @" type 0 line 1 GXT 'VAL_A3' 
0085: 17@ = 32@ 
17@ += 5000 
" + _10936 + @" = 4 
if 
  " + tmp_1892 + @"[0] == 6 
else_jump @VALET_4831 
" + tmp_1892 + @"[0] = 1 
" + _1897 + @" = 0 

:VALET_4831
if 
  " + tmp_1892 + @"[1] == 6 
else_jump @VALET_4863 
" + tmp_1892 + @"[1] = 1 
" + _1898 + @" = 0 

:VALET_4863
if 
  " + tmp_1892 + @"[2] == 6 
else_jump @VALET_4895 
" + tmp_1892 + @"[2] = 1 
" + _1899 + @" = 0 

:VALET_4895
if 
   not " + _1881 + @" == 0 
else_jump @VALET_4921 
0084: " + _10946 + @" = " + _1881 + @" 

:VALET_4921
if 
   not " + _1877 + @" == 0 
else_jump @VALET_4947 
0084: " + _10946 + @" = " + _1877 + @" 

:VALET_4947
if 
  " + _10936 + @" == 3 
else_jump @VALET_4991 
if 
001D:   32@ > 17@ 
else_jump @VALET_4991 
" + _10936 + @" = 4 

:VALET_4991
if and
   Actor.Dead(" + tmp_1874 + @"[0])
  " + _1897 + @" == 0 
  " + tmp_1892 + @"[0] == 6 
else_jump @VALET_5077 
" + _1897 + @" = 1 
" + _10935 + @" -= 20000 
if 
  0 > " + _10935 + @" 
else_jump @VALET_5061 
" + _10935 + @" = 0 

:VALET_5061
00BB: show_text_lowpriority GXT 'VAL_A19' time 4000 flag 1  

:VALET_5077
if and
   Actor.Dead(" + tmp_1874 + @"[1])
  " + _1898 + @" == 0 
  " + tmp_1892 + @"[1] == 6 
else_jump @VALET_5163 
" + _1898 + @" = 1 
" + _10935 + @" -= 20000 
if 
  0 > " + _10935 + @" 
else_jump @VALET_5147 
" + _10935 + @" = 0 

:VALET_5147
00BB: show_text_lowpriority GXT 'VAL_A19' time 4000 flag 1  

:VALET_5163
if and
   Actor.Dead(" + tmp_1874 + @"[2])
  " + _1899 + @" == 0 
  " + tmp_1892 + @"[2] == 6 
else_jump @VALET_5249 
" + _1899 + @" = 1 
" + _10935 + @" -= 20000 
if 
  0 > " + _10935 + @" 
else_jump @VALET_5233 
" + _10935 + @" = 0 

:VALET_5233
00BB: show_text_lowpriority GXT 'VAL_A19' time 4000 flag 1  

:VALET_5249
if 
  " + _10936 + @" > 3 
else_jump @VALET_5326 
if 
  " + _10935 + @" == 0 
else_jump @VALET_5326 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'VAL_47' time 4000 flag 1  
00BA: show_text_styled GXT 'VAL_A6' time 4000 style 1  
" + _10936 + @" = 8 

:VALET_5326
if 
  " + _10936 + @" == 4 
else_jump @VALET_5476 
if 
   not " + _1877 + @" == 0 
else_jump @VALET_5476 
if 
   not Car.Wrecked(" + _1877 + @")
else_jump @VALET_5476 
if 
003A:   " + _1877 + @" == " + _10946 + @" 
else_jump @VALET_5476 
046C: " + VALET_Car_Driver + @" = car " + _1877 + @" driver 
if 
  " + VALET_Car_Driver + @" == -1 
else_jump @VALET_5476 
" + _10936 + @" = 20 
00BB: show_text_lowpriority GXT 'VAL_84' time 4000 flag 1  
19@ = Marker.CreateAboveCar(" + _1877 + @")
07E0: set_marker 19@ type_to 1 
0084: " + _10934 + @" = " + _1877 + @" 
" + _10936 + @" = 5 

:VALET_5476
if 
  " + _10936 + @" == 5 
else_jump @VALET_5875 
if 
   not Car.Wrecked(" + _10934 + @")
else_jump @VALET_5849 
046C: " + VALET_Car_Driver + @" = car " + _10934 + @" driver 
if 
   not " + VALET_Car_Driver + @" == -1 
else_jump @VALET_5842 
if 
003A:   " + VALET_Car_Driver + @" == " + PlayerActor + @" 
else_jump @VALET_5765 
00BE: text_clear_all 
00BB: show_text_lowpriority GXT 'VAL_25' time 4000 flag 1  
Marker.Disable(19@)
" + _10937 + @" = 60 
Car.Health(" + _10934 + @") = 1000
0151: remove_status_text " + _10937 + @" 
04F7: status_text " + _10937 + @" type 0 line 2 GXT 'VAL_A17' 
0810: store_random_parkplace_in_cube_cornerA " + tmp_10808 + @"(" + _1884 + @",4f) " + tmp_10816 + @"(" + _1884 + @",4f) " + tmp_10824 + @"(" + _1884 + @",4f) cornerB " + tmp_10812 + @"(" + _1884 + @",4f) " + tmp_10820 + @"(" + _1884 + @",4f) " + tmp_10828 + @"(" + _1884 + @",4f) position_to 21@ 22@ 23@ 
if 
   not 21@ == 0.0 
else_jump @VALET_5758 
0395: clear_area 0 at 21@ 22@ 23@ radius 5.0 
0088: " + _10942 + @" = 21@ 
0088: " + _10943 + @" = 22@ 
0088: " + _10944 + @" = 23@ 
Marker.Disable(20@)
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 
" + _10936 + @" = 6 

:VALET_5758
jump @VALET_5842 

:VALET_5765
if or
003A:   " + VALET_Car_Driver + @" == " + tmp_1874 + @"[0] 
003A:   " + VALET_Car_Driver + @" == " + tmp_1874 + @"[1] 
003A:   " + VALET_Car_Driver + @" == " + tmp_1874 + @"[2] 
else_jump @VALET_5842 
Marker.Disable(19@)
00BB: show_text_lowpriority GXT 'VAL_79' time 4000 flag 1  
" + _10936 + @" = 4 
" + _10934 + @" = 0 
" + _10946 + @" = 0 

:VALET_5842
jump @VALET_5875 

:VALET_5849
Marker.Disable(19@)
" + _10936 + @" = 4 
" + _10934 + @" = 0 
" + _10946 + @" = 0 

:VALET_5875
if 
  " + _10936 + @" == 6 
else_jump @VALET_7430 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_7430 
if 
   not Car.Wrecked(" + _10934 + @")
else_jump @VALET_7407 
" + _10937 + @" = Car.Health(" + _10934 + @")
" + VALET_Stage + @" = 17 
0066: " + VALET_Stage + @" -= 18@ 
" + VALET_Stage + @" *= 20 
" + _10937 + @" += -1000 
0094: make " + _10937 + @" absolute_integer 
008F: 13@ = integer " + _10937 + @" to_float 
008F: 27@ = integer " + VALET_Stage + @" to_float 
0087: 28@ = 13@ 
0073: 28@ /= 27@ 
if 
  28@ > 1.0 
else_jump @VALET_6031 
28@ = 1.0 

:VALET_6031
28@ -= 1.0 
0097: make 28@ absolute_float 
28@ *= 45.0 
0090: " + _10937 + @" = float 28@ to_integer 
if 
  " + _10937 + @" > 45 
else_jump @VALET_6089 
" + _10937 + @" = 45 

:VALET_6089
if 
  0 > " + _10937 + @" 
else_jump @VALET_6114 
" + _10937 + @" = 0 

:VALET_6114
046C: " + VALET_Car_Driver + @" = car " + _10934 + @" driver 
if 
803A:   not  " + VALET_Car_Driver + @" == " + PlayerActor + @" 
else_jump @VALET_6173 
Marker.Disable(20@)
19@ = Marker.CreateAboveCar(" + _10934 + @")
07E0: set_marker 19@ type_to 1 
0151: remove_status_text " + _10937 + @" 
" + _10936 + @" = 7 

:VALET_6173
if and
   not " + VALET_Car_Driver + @" == -1 
803A:   not  " + VALET_Car_Driver + @" == " + PlayerActor + @" 
803A:   not  " + VALET_Car_Driver + @" == " + tmp_1874 + @"[0] 
803A:   not  " + VALET_Car_Driver + @" == " + tmp_1874 + @"[1] 
803A:   not  " + VALET_Car_Driver + @" == " + tmp_1874 + @"[2] 
else_jump @VALET_6263 
" + _10934 + @" = 0 
Marker.Disable(19@)
0151: remove_status_text " + _10937 + @" 
" + _10936 + @" = 4 
00BB: show_text_lowpriority GXT 'VAL_A4' time 4000 flag 1  

:VALET_6263
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @VALET_6314 
if 
   not Actor.InCar(" + PlayerActor + @", " + _10934 + @")
else_jump @VALET_6314 
00BC: show_text_highpriority GXT 'VAL_A18' time 1000 flag 1  

:VALET_6314
if 
01B0:   car " + _10934 + @" sphere 1 in_sphere 21@ 22@ 23@ radius 4.0 4.0 4.0 stopped 
else_jump @VALET_7400 
Marker.Disable(20@)
081D: set_car " + _10934 + @" engine_broken 1 
Car.RemoveReferences(" + _10934 + @")
0151: remove_status_text " + _10937 + @" 
008B: 6@ = " + _10935 + @" 
03D3: get_route_nearest_for 21@ 22@ 23@ store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" Z_angle_to 24@ 
Car.StorePos(" + _10934 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0509: 26@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 21@ 22@ 
25@ = Car.Angle(" + _10934 + @")
0097: make 24@ absolute_float 
if 
  24@ > 180.0 
else_jump @VALET_6484 
24@ -= 180.0 

:VALET_6484
0097: make 25@ absolute_float 
if 
  25@ > 180.0 
else_jump @VALET_6520 
25@ -= 180.0 

:VALET_6520
0087: 27@ = 24@ 
0063: 27@ -= 25@ 
0097: make 27@ absolute_float 
0093: 13@ = integer 18@ to_float 
13@ *= 2.0 
29@ = 45.0 
0063: 29@ -= 13@ 
0087: 28@ = 27@ 
0073: 28@ /= 29@ 
13@ = 1.0 
0063: 13@ -= 28@ 
if 
  0.0 > 13@ 
else_jump @VALET_6642 
13@ = 0.0 

:VALET_6642
13@ *= 10.0 
0090: " + _10939 + @" = float 13@ to_integer 
0090: " + _10940 + @" = float 13@ to_integer 
0093: 13@ = integer 18@ to_float 
13@ -= 20.0 
0097: make 13@ absolute_float 
13@ /= 6.0 
0087: 27@ = 26@ 
0073: 27@ /= 13@ 
28@ = 1.0 
0063: 28@ -= 27@ 
if 
  0.0 > 28@ 
else_jump @VALET_6766 
28@ = 0.0 

:VALET_6766
28@ *= 5.0 
0090: " + VALET_Stage + @" = float 28@ to_integer 
0084: " + _10938 + @" = " + VALET_Stage + @" 
0058: " + _10940 + @" += " + VALET_Stage + @" 
if and
   not " + _10940 + @" == 1 
   not " + _10937 + @" == 1 
else_jump @VALET_6847 
02FD: show_text_2numbers_lowpriority GXT 'VAL_A10' numbers " + _10940 + @" " + _10937 + @" time 2500 flag 1  

:VALET_6847
if and
  " + _10940 + @" == 1 
   not " + _10937 + @" == 1 
else_jump @VALET_6894 
02FD: show_text_2numbers_lowpriority GXT 'VAL_A12' numbers " + _10940 + @" " + _10937 + @" time 2500 flag 1  

:VALET_6894
if and
   not " + _10940 + @" == 1 
  " + _10937 + @" == 1 
else_jump @VALET_6941 
02FD: show_text_2numbers_lowpriority GXT 'VAL_A11' numbers " + _10940 + @" " + _10937 + @" time 2500 flag 1  

:VALET_6941
if and
  " + _10940 + @" == 0 
  " + _10937 + @" == 0 
else_jump @VALET_6988 
02FD: show_text_2numbers_lowpriority GXT 'VAL_A13' numbers " + _10940 + @" " + _10937 + @" time 2500 flag 1  

:VALET_6988
0084: " + VALET_Stage + @" = " + _10940 + @" 
0058: " + VALET_Stage + @" += " + _10937 + @" 
if 
   not " + VALET_Stage + @" == 1 
else_jump @VALET_7048 
01E4: show_text_1number_lowpriority GXT 'VAL_A14' number " + VALET_Stage + @" time 2500 flag 1  
jump @VALET_7067 

:VALET_7048
01E4: show_text_1number_lowpriority GXT 'VAL_A15' number " + VALET_Stage + @" time 2500 flag 1  

:VALET_7067
00BB: show_text_lowpriority GXT 'VAL_A16' time 3000 flag 1  
" + _10937 + @" *= 1000 
" + _10940 + @" *= 1000 
0058: " + _10935 + @" += " + _10937 + @" 
0058: " + _10935 + @" += " + _10940 + @" 
" + _10937 + @" = 0 
" + _10934 + @" = 0 
" + _10933 + @" -= 1 
" + VALET_Parked_Cars_Number + @" += 1 
0652: " + VALET_Stage + @" = integer_stat 175 
if 
001C:   " + VALET_Parked_Cars_Number + @" > " + VALET_Stage + @" 
else_jump @VALET_7178 
0629: change_integer_stat 175 to " + VALET_Parked_Cars_Number + @" 

:VALET_7178
if 
  " + _10933 + @" == 0 
else_jump @VALET_7393 
00BE: text_clear_all 
014F: stop_timer " + _10935 + @" 
0151: remove_status_text " + _10933 + @" 
18@ += 1 
" + _10936 + @" = 2 
008A: " + _10933 + @" = 18@ 
" + _10933 + @" += 2 
" + _10935 + @" = 2 
if 
  6 > 18@ 
else_jump @VALET_7361 
008A: " + VALET_Stage + @" = 18@ 
" + VALET_Stage + @" -= 1 
01E3: show_text_1number_styled GXT 'VAL_62' number " + VALET_Stage + @" time 3000 style 1  
008A: " + VALET_Stage + @" = 18@ 
" + VALET_Stage + @" *= 100 
" + VALET_Stage + @" -= 100 
01E4: show_text_1number_lowpriority GXT 'VAL_65' number " + VALET_Stage + @" time 4000 flag 1  
Player.Money(" + PlayerChar + @") += " + VALET_Stage + @"
0085: 17@ = 32@ 
17@ += 5000 

:VALET_7361
if 
  18@ == 6 
else_jump @VALET_7386 
gosub @VALET_16442 

:VALET_7386
jump @VALET_7400 

:VALET_7393
" + _10936 + @" = 4 

:VALET_7400
jump @VALET_7430 

:VALET_7407
00BA: show_text_styled GXT 'VAL_A6' time 4000 style 1  
" + _10936 + @" = 8 

:VALET_7430
if 
  " + _10936 + @" == 7 
else_jump @VALET_7675 
if 
   not Car.Wrecked(" + _10934 + @")
else_jump @VALET_7649 
046C: " + VALET_Car_Driver + @" = car " + _10934 + @" driver 
if 
   not " + VALET_Car_Driver + @" == -1 
else_jump @VALET_7642 
if 
003A:   " + VALET_Car_Driver + @" == " + PlayerActor + @" 
else_jump @VALET_7565 
Marker.Disable(19@)
018A: 20@ = create_checkpoint_at 21@ 22@ 23@ 
0151: remove_status_text " + _10937 + @" 
04F7: status_text " + _10937 + @" type 0 line 2 GXT 'VAL_A17' 
" + _10936 + @" = 6 
jump @VALET_7642 

:VALET_7565
if or
003A:   " + VALET_Car_Driver + @" == " + tmp_1874 + @"[0] 
003A:   " + VALET_Car_Driver + @" == " + tmp_1874 + @"[1] 
003A:   " + VALET_Car_Driver + @" == " + tmp_1874 + @"[2] 
else_jump @VALET_7642 
Marker.Disable(19@)
00BB: show_text_lowpriority GXT 'VAL_79' time 4000 flag 1  
" + _10936 + @" = 4 
" + _10934 + @" = 0 
" + _10946 + @" = 0 

:VALET_7642
jump @VALET_7675 

:VALET_7649
Marker.Disable(19@)
" + _10936 + @" = 4 
" + _10934 + @" = 0 
" + _10946 + @" = 0 

:VALET_7675
if 
  " + _10936 + @" == 8 
else_jump @VALET_7840 
Marker.Disable(19@)
Marker.Disable(20@)
0151: remove_status_text " + _10937 + @" 
014F: stop_timer " + _10935 + @" 
0151: remove_status_text " + _10933 + @" 
03DE: set_pedestrians_density_multiplier_to 1.0 
06D0: enable_emergency_traffic 1 
" + _1870 + @" = 0 
" + OnMission + @" = 0 
" + _10936 + @" = 0 
" + _10934 + @" = 0 
" + _10750 + @" = 1 
03C7: set_sensitivity_to_crime 1.0 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_7794 
039E: set_actor " + tmp_1874 + @"[0] locked 0 while_in_car 

:VALET_7794
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_7817 
039E: set_actor " + tmp_1874 + @"[1] locked 0 while_in_car 

:VALET_7817
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_7840 
039E: set_actor " + tmp_1874 + @"[2] locked 0 while_in_car 

:VALET_7840
return 

:VALET_7842
6@ = 0 

:VALET_7849
if 
  3 > 6@ 
else_jump @VALET_13019 
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_7985 
if 
095D:   actor " + tmp_1874 + @"(6@,3i) stuck_under_car 
else_jump @VALET_7985 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 2089 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_7985 
0792: disembark_instantly_actor " + tmp_1874 + @"(6@,3i) 
0829: actor " + tmp_1874 + @"(6@,3i) perform_animation ""KO_SKID_FRONT"" IFP_file ""PED"" 1000.0 time 0 and_dies 

:VALET_7985
if and
   not " + tmp_1892 + @"(6@,3i) == 4 
   not " + tmp_1892 + @"(6@,3i) == 5 
else_jump @VALET_8395 
if and
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_8395 
if 
074F:   actor " + tmp_1874 + @"(6@,3i) ped_event == 9 
else_jump @VALET_8344 
if or
0104:   actor " + PlayerActor + @" near_actor " + tmp_1874 + @"(6@,3i) radius 5.0 5.0 5.0 sphere 0 
051A:   actor " + tmp_1874 + @"(6@,3i) damaged_by_actor " + PlayerActor + @" 
else_jump @VALET_8328 
" + tmp_1892 + @"(6@,3i) = 5 
" + _10928 + @" += 1 
0687: clear_actor " + tmp_1874 + @"(6@,3i) task 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_8203 
if 
0104:   actor " + PlayerActor + @" near_actor " + tmp_1874 + @"[0] radius 15.0 15.0 15.0 sphere 0 
else_jump @VALET_8203 
" + tmp_1892 + @"[0] = 5 

:VALET_8203
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_8262 
if 
0104:   actor " + PlayerActor + @" near_actor " + tmp_1874 + @"[1] radius 15.0 15.0 15.0 sphere 0 
else_jump @VALET_8262 
" + tmp_1892 + @"[1] = 5 

:VALET_8262
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_8321 
if 
0104:   actor " + PlayerActor + @" near_actor " + tmp_1874 + @"[2] radius 15.0 15.0 15.0 sphere 0 
else_jump @VALET_8321 
" + tmp_1892 + @"[2] = 5 

:VALET_8321
jump @VALET_8344 

:VALET_8328
008A: " + tmp_1892 + @"(6@,3i) = 0@(6@,3i) 

:VALET_8344
if 
   not " + tmp_1892 + @"(6@,3i) == 9 
else_jump @VALET_8395 
if 
04A3:   " + _1895 + @" == 7 
else_jump @VALET_8395 
" + tmp_1892 + @"(6@,3i) = 9 

:VALET_8395
if 
   not " + tmp_1892 + @"(6@,3i) == 1 
else_jump @VALET_8704 
if 
056D:   actor " + tmp_1874 + @"(6@,3i) defined 
else_jump @VALET_8704 
if 
   Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_8704 
0889: store_actor " + tmp_1874 + @"(6@,3i) center_of_body_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
   not " + tmp_1892 + @"(6@,3i) == 6 
else_jump @VALET_8684 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_8576 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 15.0 15.0 15.0 
else_jump @VALET_8576 
" + tmp_1892 + @"[0] = 5 
" + tmp_1892 + @"[1] = 5 
" + tmp_1892 + @"[2] = 5 

:VALET_8576
if 
  " + _1870 + @" == 1 
else_jump @VALET_8684 
if or
0024:   " + tmp_10808 + @"(" + _1884 + @",4f) > " + tempvar_Float_1 + @" 
0024:   " + tmp_10816 + @"(" + _1884 + @",4f) > " + tempvar_Float_2 + @" 
0024:   " + tmp_10824 + @"(" + _1884 + @",4f) > " + tempvar_Float_3 + @" 
0024:   " + tempvar_Float_1 + @" > " + tmp_10812 + @"(" + _1884 + @",4f) 
0024:   " + tempvar_Float_2 + @" > " + tmp_10820 + @"(" + _1884 + @",4f) 
0024:   " + tempvar_Float_3 + @" > " + tmp_10828 + @"(" + _1884 + @",4f) 
else_jump @VALET_8684 
Player.SetMinWantedLevel(" + PlayerChar + @", 1)

:VALET_8684
" + tmp_1892 + @"(6@,3i) = 6 
Actor.RemoveReferences(" + tmp_1874 + @"(6@,3i))

:VALET_8704
0871: init_jump_table " + tmp_1892 + @"(6@,3i) total_jumps 11 default_jump 0 @VALET_13005 jumps 1 @VALET_8836 2 @VALET_9149 3 @VALET_9763 4 @VALET_10506 5 @VALET_10614 6 @VALET_12998 7 @VALET_11111 
0872: jump_table_jumps 8 @VALET_12285 9 @VALET_12607 10 @VALET_10325 11 @VALET_12792 -1 @VALET_13005 -1 @VALET_13005 -1 @VALET_13005 -1 @VALET_13005 -1 @VALET_13005 

:VALET_8836
if 
  " + tmp_1887 + @"(6@,3i) == 1 
else_jump @VALET_9142 
Model.Load(#WMYVA)
if 
   Model.Available(#WMYVA)
else_jump @VALET_9142 
if 
  " + _1884 + @" == 1 
else_jump @VALET_8948 
" + tmp_1874 + @"(6@,3i) = Actor.Create(Mission1, #WMYVA, " + tmp_10756 + @"(6@,3f), " + tmp_10759 + @"(6@,3f), " + tmp_10762 + @"(6@,3f))
Actor.Angle(" + tmp_1874 + @"(6@,3i)) = " + tmp_10765 + @"(6@,3f)

:VALET_8948
if 
  " + _1884 + @" == 2 
else_jump @VALET_9017 
" + tmp_1874 + @"(6@,3i) = Actor.Create(Mission1, #WMYVA, " + tmp_10768 + @"(6@,3f), " + tmp_10771 + @"(6@,3f), " + tmp_10774 + @"(6@,3f))
Actor.Angle(" + tmp_1874 + @"(6@,3i)) = " + tmp_10777 + @"(6@,3f)

:VALET_9017
if 
  " + _1884 + @" == 3 
else_jump @VALET_9086 
" + tmp_1874 + @"(6@,3i) = Actor.Create(Mission1, #WMYVA, " + tmp_10780 + @"(6@,3f), " + tmp_10783 + @"(6@,3f), " + tmp_10786 + @"(6@,3f))
Actor.Angle(" + tmp_1874 + @"(6@,3i)) = " + tmp_10789 + @"(6@,3f)

:VALET_9086
060B: set_actor " + tmp_1874 + @"(6@,3i) decision_maker_to 7@ 
02A9: set_actor " + tmp_1874 + @"(6@,3i) immune_to_nonplayer 1 
0446: set_actor " + tmp_1874 + @"(6@,3i) dismemberment_possible 0 
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 

:VALET_9142
jump @VALET_13005 

:VALET_9149
if 
001D:   32@ > 8@ 
else_jump @VALET_9756 
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_9756 
if 
  " + _1884 + @" == 1 
else_jump @VALET_9342 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10756 + @"(6@,3f) " + tmp_10759 + @"(6@,3f) " + tmp_10762 + @"(6@,3f) radius 2.0 2.0 2.0 
else_jump @VALET_9342 
0615: define_AS_pack_begin 11@ 
05F5: AS_actor -1 goto_point_using_paths " + tmp_10756 + @"(6@,3f) " + tmp_10759 + @"(6@,3f) " + tmp_10762 + @"(6@,3f) mode 6 time -2 
05D4: AS_actor -1 rotate_angle " + tmp_10765 + @"(6@,3f) 
0616: define_AS_pack_end 11@ 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 
" + tmp_1892 + @"(6@,3i) = 3 

:VALET_9342
if 
  " + _1884 + @" == 2 
else_jump @VALET_9602 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10768 + @"(6@,3f) " + tmp_10771 + @"(6@,3f) " + tmp_10774 + @"(6@,3f) radius 2.0 2.0 2.0 
else_jump @VALET_9503 
0615: define_AS_pack_begin 11@ 
05F5: AS_actor -1 goto_point_using_paths " + tmp_10768 + @"(6@,3f) " + tmp_10771 + @"(6@,3f) " + tmp_10774 + @"(6@,3f) mode 6 time -2 
05D4: AS_actor -1 rotate_angle " + tmp_10777 + @"(6@,3f) 
0616: define_AS_pack_end 11@ 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 
" + tmp_1892 + @"(6@,3i) = 3 
jump @VALET_9602 

:VALET_9503
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1492 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_9602 
" + _10755 + @" = Actor.Angle(" + tmp_1874 + @"(6@,3i))
0061: " + _10755 + @" -= " + tmp_10777 + @"(6@,3f) 
0096: make " + _10755 + @" absolute_float 
if 
   not 10.0 > " + _10755 + @" 
else_jump @VALET_9602 
05D4: AS_actor " + tmp_1874 + @"(6@,3i) rotate_angle " + tmp_10777 + @"(6@,3f) 

:VALET_9602
if 
  " + _1884 + @" == 3 
else_jump @VALET_9756 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10780 + @"(6@,3f) " + tmp_10783 + @"(6@,3f) " + tmp_10786 + @"(6@,3f) radius 2.0 2.0 2.0 
else_jump @VALET_9756 
0615: define_AS_pack_begin 11@ 
05F5: AS_actor -1 goto_point_using_paths " + tmp_10780 + @"(6@,3f) " + tmp_10783 + @"(6@,3f) " + tmp_10786 + @"(6@,3f) mode 6 time -2 
05D4: AS_actor -1 rotate_angle " + tmp_10789 + @"(6@,3f) 
0616: define_AS_pack_end 11@ 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 
" + tmp_1892 + @"(6@,3i) = 3 

:VALET_9756
jump @VALET_13005 

:VALET_9763
if 
001D:   32@ > 9@ 
else_jump @VALET_10318 
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_10318 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1560 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_10318 
if 
  " + _1884 + @" == 1 
else_jump @VALET_9996 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10756 + @"(6@,3f) " + tmp_10759 + @"(6@,3f) " + tmp_10762 + @"(6@,3f) radius 3.0 3.0 3.0 
else_jump @VALET_9985 
0615: define_AS_pack_begin 11@ 
05F5: AS_actor -1 goto_point_using_paths " + tmp_10756 + @"(6@,3f) " + tmp_10759 + @"(6@,3f) " + tmp_10762 + @"(6@,3f) mode 6 time -2 
05D4: AS_actor -1 rotate_angle " + tmp_10765 + @"(6@,3f) 
0616: define_AS_pack_end 11@ 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 
jump @VALET_9996 

:VALET_9985
" + tmp_1892 + @"(6@,3i) = 2 

:VALET_9996
if 
  " + _1884 + @" == 2 
else_jump @VALET_10157 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10768 + @"(6@,3f) " + tmp_10771 + @"(6@,3f) " + tmp_10774 + @"(6@,3f) radius 3.0 3.0 3.0 
else_jump @VALET_10146 
0615: define_AS_pack_begin 11@ 
05F5: AS_actor -1 goto_point_using_paths " + tmp_10768 + @"(6@,3f) " + tmp_10771 + @"(6@,3f) " + tmp_10774 + @"(6@,3f) mode 6 time -2 
05D4: AS_actor -1 rotate_angle " + tmp_10777 + @"(6@,3f) 
0616: define_AS_pack_end 11@ 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 
jump @VALET_10157 

:VALET_10146
" + tmp_1892 + @"(6@,3i) = 2 

:VALET_10157
if 
  " + _1884 + @" == 3 
else_jump @VALET_10318 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10780 + @"(6@,3f) " + tmp_10783 + @"(6@,3f) " + tmp_10786 + @"(6@,3f) radius 3.0 3.0 3.0 
else_jump @VALET_10307 
0615: define_AS_pack_begin 11@ 
05F5: AS_actor -1 goto_point_using_paths " + tmp_10780 + @"(6@,3f) " + tmp_10783 + @"(6@,3f) " + tmp_10786 + @"(6@,3f) mode 6 time -2 
05D4: AS_actor -1 rotate_angle " + tmp_10789 + @"(6@,3f) 
0616: define_AS_pack_end 11@ 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 
jump @VALET_10318 

:VALET_10307
" + tmp_1892 + @"(6@,3i) = 2 

:VALET_10318
jump @VALET_13005 

:VALET_10325
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_10499 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1560 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_10499 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10832 + @"(" + _1884 + @",4f) " + tmp_10836 + @"(" + _1884 + @",4f) " + tmp_10840 + @"(" + _1884 + @",4f) radius 3.0 3.0 3.0 
else_jump @VALET_10477 
05F5: AS_actor " + tmp_1874 + @"(6@,3i) goto_point_using_paths " + tmp_10832 + @"(" + _1884 + @",4f) " + tmp_10836 + @"(" + _1884 + @",4f) " + tmp_10840 + @"(" + _1884 + @",4f) mode 6 time -2 
jump @VALET_10499 

:VALET_10477
0@(6@,3i) = 3 
" + tmp_1892 + @"(6@,3i) = 3 

:VALET_10499
jump @VALET_13005 

:VALET_10506
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_10607 
if 
874F:   not actor " + tmp_1874 + @"(6@,3i) ped_event == 9 
else_jump @VALET_10591 
0812: AS_actor " + tmp_1874 + @"(6@,3i) perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 time -2 
4@ += 1 

:VALET_10591
008A: " + tmp_1892 + @"(6@,3i) = 0@(6@,3i) 

:VALET_10607
jump @VALET_13005 

:VALET_10614
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_11104 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1506 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_10679 
05E2: AS_actor " + tmp_1874 + @"(6@,3i) kill_actor " + PlayerActor + @" 

:VALET_10679
if 
001D:   32@ > 9@ 
else_jump @VALET_11104 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_11104 
if 
  " + _1884 + @" == 1 
else_jump @VALET_10844 
if or
8104:   not actor " + tmp_1874 + @"(6@,3i) near_actor " + PlayerActor + @" radius 15.0 15.0 15.0 sphere 0 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10756 + @"(6@,3f) " + tmp_10759 + @"(6@,3f) " + tmp_10762 + @"(6@,3f) radius 10.0 10.0 10.0 
else_jump @VALET_10844 
0687: clear_actor " + tmp_1874 + @"(6@,3i) task 
008A: " + tmp_1892 + @"(6@,3i) = 0@(6@,3i) 

:VALET_10844
if 
  " + _1884 + @" == 2 
else_jump @VALET_10974 
if or
8104:   not actor " + tmp_1874 + @"(6@,3i) near_actor " + PlayerActor + @" radius 15.0 15.0 15.0 sphere 0 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10768 + @"(6@,3f) " + tmp_10771 + @"(6@,3f) " + tmp_10774 + @"(6@,3f) radius 10.0 10.0 10.0 
else_jump @VALET_10974 
0687: clear_actor " + tmp_1874 + @"(6@,3i) task 
008A: " + tmp_1892 + @"(6@,3i) = 0@(6@,3i) 

:VALET_10974
if 
  " + _1884 + @" == 3 
else_jump @VALET_11104 
if or
8104:   not actor " + tmp_1874 + @"(6@,3i) near_actor " + PlayerActor + @" radius 15.0 15.0 15.0 sphere 0 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10780 + @"(6@,3f) " + tmp_10783 + @"(6@,3f) " + tmp_10786 + @"(6@,3f) radius 10.0 10.0 10.0 
else_jump @VALET_11104 
0687: clear_actor " + tmp_1874 + @"(6@,3i) task 
008A: " + tmp_1892 + @"(6@,3i) = 0@(6@,3i) 

:VALET_11104
jump @VALET_13005 

:VALET_11111
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_12278 
if 
  " + _1884 + @" == 1 
else_jump @VALET_11240 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10756 + @"(6@,3f) " + tmp_10759 + @"(6@,3f) " + tmp_10762 + @"(6@,3f) radius 23.0 23.0 8.0 
else_jump @VALET_11240 
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_11240
if 
  " + _1884 + @" == 2 
else_jump @VALET_11349 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10768 + @"(6@,3f) " + tmp_10771 + @"(6@,3f) " + tmp_10774 + @"(6@,3f) radius 23.0 23.0 8.0 
else_jump @VALET_11349 
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_11349
if 
  " + _1884 + @" == 3 
else_jump @VALET_11458 
if 
80FE:   not actor " + tmp_1874 + @"(6@,3i) sphere 0 in_sphere " + tmp_10780 + @"(6@,3f) " + tmp_10783 + @"(6@,3f) " + tmp_10786 + @"(6@,3f) radius 23.0 23.0 8.0 
else_jump @VALET_11458 
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_11458
if 
   not " + tmp_1892 + @"(6@,3i) == 2 
else_jump @VALET_12278 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1560 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_12033 
if 
   not Car.Wrecked(" + tmp_1878 + @"(6@,3i))
else_jump @VALET_11993 
if 
   Actor.InCar(" + tmp_1874 + @"(6@,3i), " + tmp_1878 + @"(6@,3i))
else_jump @VALET_11828 
0810: store_random_parkplace_in_cube_cornerA " + tmp_10808 + @"(" + _1884 + @",4f) " + tmp_10816 + @"(" + _1884 + @",4f) " + tmp_10824 + @"(" + _1884 + @",4f) cornerB " + tmp_10812 + @"(" + _1884 + @",4f) " + tmp_10820 + @"(" + _1884 + @",4f) " + tmp_10828 + @"(" + _1884 + @",4f) position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
   not " + tempvar_Float_1 + @" == 0.0 
else_jump @VALET_11821 
if 
003A:   " + tmp_1878 + @"(6@,3i) == " + _1877 + @" 
else_jump @VALET_11664 
" + _1877 + @" = 0 

:VALET_11664
0086: " + _10942 + @" = " + tempvar_Float_1 + @" 
0086: " + _10943 + @" = " + tempvar_Float_2 + @" 
0086: " + _10944 + @" = " + tempvar_Float_3 + @" 
if 
0686:   car " + tmp_1878 + @"(6@,3i) attached 
else_jump @VALET_11734 
0684: detach_car " + tmp_1878 + @"(6@,3i) 0.0 0.0 0.0 collision_detection 0 

:VALET_11734
05D1: AS_actor " + tmp_1874 + @"(6@,3i) drive_car " + tmp_1878 + @"(6@,3i) to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" speed 15.0 1 model #NULL 0 
if 
  " + _1870 + @" == 1 
else_jump @VALET_11799 
039E: set_actor " + tmp_1874 + @"(6@,3i) locked 1 while_in_car 

:VALET_11799
" + tmp_1892 + @"(6@,3i) = 8 
0@(6@,3i) = 7 

:VALET_11821
jump @VALET_11986 

:VALET_11828
if 
   not Car.Wrecked(" + tmp_1878 + @"(6@,3i))
else_jump @VALET_11953 
if 
0205:   actor " + tmp_1874 + @"(6@,3i) near_car " + tmp_1878 + @"(6@,3i) radius 20.0 20.0 20.0 flag 0 
else_jump @VALET_11946 
0615: define_AS_pack_begin 11@ 
05B9: AS_actor -1 stay_idle 3000 ms 
05CB: AS_actor -1 enter_car " + tmp_1878 + @"(6@,3i) as_driver -2 ms 
0616: define_AS_pack_end 11@ 
" + _10929 + @" += 1 
0618: assign_actor " + tmp_1874 + @"(6@,3i) to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 

:VALET_11946
jump @VALET_11986 

:VALET_11953
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_11986
jump @VALET_12026 

:VALET_11993
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_12026
jump @VALET_12278 

:VALET_12033
if and
   not Car.Wrecked(" + tmp_1878 + @"(6@,3i))
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_12278 
0811: " + VALET_Car + @" = actor " + PlayerActor + @" used_car 
if 
003A:   " + VALET_Car + @" == " + tmp_1878 + @"(6@,3i) 
else_jump @VALET_12174 
if 
0500:   player " + PlayerChar + @" skin == ""VALET"" on_bodypart 17 
else_jump @VALET_12174 
if and
89DE:   not actor " + tmp_1874 + @"(6@,3i) entering_car 
   not Actor.Driving(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_12174 
0687: clear_actor " + tmp_1874 + @"(6@,3i) task 
" + tmp_1892 + @"(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_12174
if 
   not Car.Wrecked(" + tmp_1878 + @"(6@,3i))
else_jump @VALET_12271 
if 
8205:   not actor " + tmp_1874 + @"(6@,3i) near_car " + tmp_1878 + @"(6@,3i) radius 20.0 20.0 20.0 flag 0 
else_jump @VALET_12271 
" + tmp_1892 + @"(6@,3i) = 2 
0@(6@,3i) = 2 
" + tmp_1878 + @"(6@,3i) = 0 

:VALET_12271
jump @VALET_12278 

:VALET_12278
jump @VALET_13005 

:VALET_12285
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_12600 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1489 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_12460 
if 
00A4:   actor " + tmp_1874 + @"(6@,3i) sphere 0 in_cube_cornerA " + tmp_10808 + @"(" + _1884 + @",4f) " + tmp_10816 + @"(" + _1884 + @",4f) " + tmp_10824 + @"(" + _1884 + @",4f) cornerB " + tmp_10812 + @"(" + _1884 + @",4f) " + tmp_10820 + @"(" + _1884 + @",4f) " + tmp_10828 + @"(" + _1884 + @",4f) 
else_jump @VALET_12431 
" + tmp_1892 + @"(6@,3i) = 3 
0@(6@,3i) = 3 
jump @VALET_12453 

:VALET_12431
" + tmp_1892 + @"(6@,3i) = 3 
0@(6@,3i) = 3 

:VALET_12453
jump @VALET_12600 

:VALET_12460
if or
  " + OnMission + @" == 0 
  " + _1870 + @" == 1 
  " + _1886 + @" > 0 
else_jump @VALET_12600 
if 
   not Car.Wrecked(" + tmp_1878 + @"(6@,3i))
else_jump @VALET_12600 
0987: get_car_blocking_car " + tmp_1878 + @"(6@,3i) store_to " + VALET_Car + @" 
if 
   not Car.Wrecked(" + VALET_Car + @")
else_jump @VALET_12600 
046C: " + VALET_Car_Driver + @" = car " + VALET_Car + @" driver 
if or
003A:   " + VALET_Car_Driver + @" == " + PlayerActor + @" 
  " + VALET_Car_Driver + @" == -1 
else_jump @VALET_12600 
if 
   not " + VALET_Car + @" == -1 
else_jump @VALET_12600 
0084: " + _10754 + @" = " + VALET_Car + @" 

:VALET_12600
jump @VALET_13005 

:VALET_12607
if and
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
   not Car.Wrecked(" + tmp_1878 + @"(6@,3i))
else_jump @VALET_12785 
if 
   not Actor.InCar(" + tmp_1874 + @"(6@,3i), " + tmp_1878 + @"(6@,3i))
else_jump @VALET_12785 
046C: " + _10749 + @" = car " + tmp_1878 + @"(6@,3i) driver 
if 
   not " + _10749 + @" == -1 
else_jump @VALET_12785 
0811: " + VALET_Car + @" = actor " + PlayerActor + @" used_car 
if 
003A:   " + VALET_Car + @" == " + tmp_1878 + @"(6@,3i) 
else_jump @VALET_12774 
if 
0500:   player " + PlayerChar + @" skin == ""VALET"" on_bodypart 17 
else_jump @VALET_12756 
jump @VALET_12767 

:VALET_12756
" + tmp_1892 + @"(6@,3i) = 2 

:VALET_12767
jump @VALET_12785 

:VALET_12774
" + tmp_1892 + @"(6@,3i) = 2 

:VALET_12785
jump @VALET_13005 

:VALET_12792
if 
   not Actor.Dead(" + tmp_1874 + @"(6@,3i))
else_jump @VALET_12991 
062E: get_actor " + tmp_1874 + @"(6@,3i) task 1655 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_12991 
if 
  6@ == 0 
else_jump @VALET_12991 
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_12991 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_12991 
062E: get_actor " + tmp_1874 + @"[1] task 1655 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_12991 
062E: get_actor " + tmp_1874 + @"[0] task 1655 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_12991 
0677: AS_actor " + tmp_1874 + @"[0] chat_with_actor " + tmp_1874 + @"[1] lead_speaker_flag 1 unknown_flag 1 
0677: AS_actor " + tmp_1874 + @"[1] chat_with_actor " + tmp_1874 + @"[0] lead_speaker_flag 0 unknown_flag 1 
0@ = 11 
1@ = 11 

:VALET_12991
jump @VALET_13005 

:VALET_12998
jump @VALET_13005 

:VALET_13005
6@ += 1 
jump @VALET_7849 

:VALET_13019
return 

:VALET_13021
if or
  " + _1890 + @" == 0 
  " + _10752 + @" > 0 
else_jump @VALET_13235 
if 
  " + _1885 + @" == 0 
else_jump @VALET_13235 
if 
  " + _1881 + @" == 0 
else_jump @VALET_13235 
if 
8339:   not anything_in_cube_cornerA " + tmp_10792 + @"(" + _1884 + @",4f) " + tmp_10800 + @"(" + _1884 + @",4f) 0.0 cornerB " + tmp_10796 + @"(" + _1884 + @",4f) " + tmp_10804 + @"(" + _1884 + @",4f) 80.0 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @VALET_13164 
" + _10752 + @" -= 1 
" + _1885 + @" = 1 
15@ = 0 

:VALET_13164
if 
  " + _1885 + @" == 0 
else_jump @VALET_13235 
if and
  " + _10934 + @" == 0 
  " + _1877 + @" == 0 
  " + _1881 + @" == 0 
else_jump @VALET_13235 
" + _10752 + @" -= 1 
" + _1885 + @" = 1 
15@ = 0 

:VALET_13235
if 
   not " + _1881 + @" == 0 
else_jump @VALET_13392 
if 
   Car.Wrecked(" + _1881 + @")
else_jump @VALET_13283 
" + _1891 + @" = 1 
" + _1881 + @" = 0 

:VALET_13283
if 
   not Car.Wrecked(" + _1881 + @")
else_jump @VALET_13392 
046C: " + VALET_Car_Driver + @" = car " + _1881 + @" driver 
if 
   not Actor.Dead(" + VALET_Car_Driver + @")
else_jump @VALET_13347 
if 
8448:   not actor " + VALET_Car_Driver + @" in_car " + _1881 + @" 
else_jump @VALET_13347 
Car.RemoveReferences(" + _1881 + @")

:VALET_13347
if or
  " + VALET_Car_Driver + @" == -1 
003A:   " + VALET_Car_Driver + @" == " + PlayerActor + @" 
else_jump @VALET_13392 
Car.RemoveReferences(" + _1881 + @")
" + _1891 + @" = 2 
" + _1881 + @" = 0 

:VALET_13392
if 
   not " + _1877 + @" == 0 
else_jump @VALET_13507 
if 
   Car.Wrecked(" + _1877 + @")
else_jump @VALET_13433 
" + _1877 + @" = 0 

:VALET_13433
if 
   not Car.Wrecked(" + _1877 + @")
else_jump @VALET_13507 
046C: " + VALET_Car_Driver + @" = car " + _1877 + @" driver 
if 
003A:   " + VALET_Car_Driver + @" == " + PlayerActor + @" 
else_jump @VALET_13507 
if 
803A:   not  " + _1877 + @" == " + _1867 + @" 
else_jump @VALET_13500 
Car.RemoveReferences(" + _1877 + @")

:VALET_13500
" + _1877 + @" = 0 

:VALET_13507
if 
001D:   32@ > 9@ 
else_jump @VALET_14641 
if or
  " + tmp_1892 + @"[0] == 2 
  " + tmp_1892 + @"[1] == 2 
  " + tmp_1892 + @"[2] == 2 
  " + _1870 + @" == 1 
  " + OnMission + @" == 1 
else_jump @VALET_14641 
if and
   not " + tmp_1892 + @"[0] == 7 
   not " + tmp_1892 + @"[1] == 7 
   not " + tmp_1892 + @"[2] == 7 
else_jump @VALET_14641 
053E: " + _1882 + @" = get_random_car_with_model -1 in_rectangle_cornerA " + tmp_10792 + @"(" + _1884 + @",4f) " + tmp_10800 + @"(" + _1884 + @",4f) cornerB " + tmp_10796 + @"(" + _1884 + @",4f) " + tmp_10804 + @"(" + _1884 + @",4f) 
if 
   not Car.Wrecked(" + _1867 + @")
else_jump @VALET_13709 
if 
00B0:   car " + _1867 + @" sphere 0 in_rectangle_cornerA " + tmp_10792 + @"(" + _1884 + @",4f) " + tmp_10800 + @"(" + _1884 + @",4f) cornerB " + tmp_10796 + @"(" + _1884 + @",4f) " + tmp_10804 + @"(" + _1884 + @",4f) 
else_jump @VALET_13709 
0084: " + _1882 + @" = " + _1867 + @" 

:VALET_13709
if 
  " + _1882 + @" == -1 
else_jump @VALET_13797 
if 
   not Car.Wrecked(" + _1881 + @")
else_jump @VALET_13797 
if 
00B0:   car " + _1881 + @" sphere 0 in_rectangle_cornerA " + tmp_10792 + @"(" + _1884 + @",4f) " + tmp_10800 + @"(" + _1884 + @",4f) cornerB " + tmp_10796 + @"(" + _1884 + @",4f) " + tmp_10804 + @"(" + _1884 + @",4f) 
else_jump @VALET_13797 
0084: " + _1882 + @" = " + _1881 + @" 

:VALET_13797
if 
  " + _1882 + @" == -1 
else_jump @VALET_13885 
if 
   not Car.Wrecked(" + _10946 + @")
else_jump @VALET_13885 
if 
00B0:   car " + _10946 + @" sphere 0 in_rectangle_cornerA " + tmp_10792 + @"(" + _1884 + @",4f) " + tmp_10800 + @"(" + _1884 + @",4f) cornerB " + tmp_10796 + @"(" + _1884 + @",4f) " + tmp_10804 + @"(" + _1884 + @",4f) 
else_jump @VALET_13885 
0084: " + _1882 + @" = " + _10946 + @" 

:VALET_13885
" + _10724 + @" = 0 
if 
   not " + _1882 + @" == -1 
else_jump @VALET_14022 
0084: " + _10945 + @" = " + _1882 + @" 
if 
   not Car.Wrecked(" + _1882 + @")
else_jump @VALET_14022 
046C: " + VALET_Car_Driver + @" = car " + _1882 + @" driver 
if 
  " + VALET_Car_Driver + @" == -1 
else_jump @VALET_14022 
08EC: 12@ = car " + _1882 + @" class 
if and
84A4:   not  12@ == 0 
84A4:   not  12@ == 1 
84A4:   not  12@ == 2 
84A4:   not  12@ == 3 
else_jump @VALET_14022 
0084: " + _10754 + @" = " + _1882 + @" 
" + _1882 + @" = -1 

:VALET_14022
if 
   not " + _1882 + @" == -1 
else_jump @VALET_14087 
if 
   not Car.Wrecked(" + _1882 + @")
else_jump @VALET_14087 
if 
0975:   car " + _1882 + @" emergency_vehicle 
else_jump @VALET_14087 
0084: " + _10754 + @" = " + _1882 + @" 
" + _1882 + @" = -1 

:VALET_14087
if 
   not " + _1882 + @" == -1 
else_jump @VALET_14641 
if 
   not Car.Wrecked(" + _1882 + @")
else_jump @VALET_14267 
046C: " + VALET_Car_Driver + @" = car " + _1882 + @" driver 
if 
   not " + VALET_Car_Driver + @" == -1 
else_jump @VALET_14267 
if 
   not Actor.Dead(" + VALET_Car_Driver + @")
else_jump @VALET_14267 
if 
8448:   not actor " + VALET_Car_Driver + @" in_car " + _1882 + @" 
else_jump @VALET_14197 
0084: " + _1877 + @" = " + _1882 + @" 
04E0: car " + _1877 + @" abandon_path_radius 1 

:VALET_14197
062E: get_actor " + VALET_Car_Driver + @" task 1560 status_store_to 3@ 
if 
04A4:   3@ == 1 
else_jump @VALET_14267 
0646: unknown_get_actor " + VALET_Car_Driver + @" task_1560_status_store_to 3@ 
if 
  3@ == 1 
else_jump @VALET_14267 
0084: " + _1877 + @" = " + _1882 + @" 
04E0: car " + _1877 + @" abandon_path_radius 1 

:VALET_14267
if 
  " + VALET_Car_Driver + @" == -1 
else_jump @VALET_14300 
0084: " + _1877 + @" = " + _1882 + @" 
04E0: car " + _1877 + @" abandon_path_radius 1 

:VALET_14300
0811: " + VALET_Car + @" = actor " + PlayerActor + @" used_car 
if 
003A:   " + VALET_Car + @" == " + _1877 + @" 
else_jump @VALET_14334 
" + _1877 + @" = 0 

:VALET_14334
if 
003A:   " + _1877 + @" == " + _1882 + @" 
else_jump @VALET_14634 
if 
   not Car.Wrecked(" + _1882 + @")
else_jump @VALET_14521 
01EA: 30@ = car " + _1882 + @" max_passengers 
6@ = 0 

:VALET_14384
if 
001D:   30@ > 6@ 
else_jump @VALET_14521 
if 
8431:   not car " + _1882 + @" passenger_seat_free 6@ 
else_jump @VALET_14507 
0432: " + _10749 + @" = get_actor_handle_from_car " + _1882 + @" passenger_seat 6@ 
if 
   not Actor.Dead(" + _10749 + @")
else_jump @VALET_14507 
if 
0448:   actor " + _10749 + @" in_car " + _1882 + @" 
else_jump @VALET_14507 
062E: get_actor " + _10749 + @" task 1502 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_14507 
Actor.RemoveReferences(" + _10749 + @")
05DE: AS_actor " + _10749 + @" walk_around_ped_path 

:VALET_14507
6@ += 1 
jump @VALET_14384 

:VALET_14521
if 
  " + tmp_1892 + @"[0] == 2 
else_jump @VALET_14561 
" + tmp_1892 + @"[0] = 7 
0084: " + tmp_1878 + @"[0] = " + _1877 + @" 
jump @VALET_14634 

:VALET_14561
if 
  " + tmp_1892 + @"[1] == 2 
else_jump @VALET_14601 
" + tmp_1892 + @"[1] = 7 
0084: " + tmp_1878 + @"[1] = " + _1877 + @" 
jump @VALET_14634 

:VALET_14601
if 
  " + tmp_1892 + @"[2] == 2 
else_jump @VALET_14634 
" + tmp_1892 + @"[2] = 7 
0084: " + tmp_1878 + @"[2] = " + _1877 + @" 

:VALET_14634
" + _1882 + @" = 0 

:VALET_14641
if 
  " + _1885 + @" == 1 
else_jump @VALET_16069 
if 
001D:   32@ > 10@ 
else_jump @VALET_16069 
" + _1891 + @" = 3 
" + _1881 + @" = 0 
053E: " + VALET_Car + @" = get_random_car_with_model -1 in_rectangle_cornerA " + tmp_10844 + @"(" + _1884 + @",4f) " + tmp_10848 + @"(" + _1884 + @",4f) cornerB " + tmp_10852 + @"(" + _1884 + @",4f) " + tmp_10856 + @"(" + _1884 + @",4f) 
if 
   not " + VALET_Car + @" == -1 
else_jump @VALET_14983 
if 
   not Car.Wrecked(" + VALET_Car + @")
else_jump @VALET_14983 
24@ = Car.Angle(" + VALET_Car + @")
0087: 13@ = 24@ 
0065: 13@ -= " + tmp_10860 + @"(" + _1884 + @",4f) 
0097: make 13@ absolute_float 
if 
  45.0 > 13@ 
else_jump @VALET_14983 
08EC: 12@ = car " + VALET_Car + @" class 
if or
04A4:   12@ == 0 
04A4:   12@ == 1 
04A4:   12@ == 2 
04A4:   12@ == 3 
else_jump @VALET_14983 
12@ = Car.Model(" + VALET_Car + @")
if or
84A4:   not  12@ == 596 
84A4:   not  12@ == 420 
else_jump @VALET_14983 
046C: " + _10747 + @" = car " + VALET_Car + @" driver 
if 
   not " + _10747 + @" == -1 
else_jump @VALET_14983 
if 
   not Actor.Dead(" + _10747 + @")
else_jump @VALET_14983 
062E: get_actor " + _10747 + @" task 1490 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_14983 
0084: " + _1881 + @" = " + VALET_Car + @" 
073B: unknown_car " + _1881 + @" flag 0 

:VALET_14983
if 
  " + _1881 + @" == 0 
else_jump @VALET_15292 
053E: " + VALET_Car + @" = get_random_car_with_model -1 in_rectangle_cornerA " + tmp_10864 + @"(" + _1884 + @",4f) " + tmp_10868 + @"(" + _1884 + @",4f) cornerB " + tmp_10872 + @"(" + _1884 + @",4f) " + tmp_10876 + @"(" + _1884 + @",4f) 
if 
   not " + VALET_Car + @" == -1 
else_jump @VALET_15292 
if 
   not Car.Wrecked(" + VALET_Car + @")
else_jump @VALET_15292 
24@ = Car.Angle(" + VALET_Car + @")
0087: 13@ = 24@ 
0065: 13@ -= " + tmp_10880 + @"(" + _1884 + @",4f) 
0097: make 13@ absolute_float 
if 
  45.0 > 13@ 
else_jump @VALET_15292 
08EC: 12@ = car " + VALET_Car + @" class 
if or
04A4:   12@ == 0 
04A4:   12@ == 1 
04A4:   12@ == 2 
04A4:   12@ == 3 
else_jump @VALET_15292 
12@ = Car.Model(" + VALET_Car + @")
if or
84A4:   not  12@ == 596 
84A4:   not  12@ == 420 
else_jump @VALET_15292 
046C: " + _10747 + @" = car " + VALET_Car + @" driver 
if 
   not " + _10747 + @" == -1 
else_jump @VALET_15292 
if 
   not Actor.Dead(" + _10747 + @")
else_jump @VALET_15292 
062E: get_actor " + _10747 + @" task 1490 status_store_to 3@ 
if 
04A4:   3@ == 7 
else_jump @VALET_15292 
0084: " + _1881 + @" = " + VALET_Car + @" 
073B: unknown_car " + _1881 + @" flag 0 

:VALET_15292
if or
  " + _1870 + @" == 1 
  " + _1886 + @" > 0 
else_jump @VALET_15771 
if 
  " + _1881 + @" == 0 
else_jump @VALET_15771 
15@ += 1 
if 
  15@ == 6 
else_jump @VALET_15462 
0209: 6@ = random_int_in_ranges 0 3 
if 
  6@ == 0 
else_jump @VALET_15400 
Model.Load(#PREVION)
04AF: 14@ = 436 

:VALET_15400
if 
  6@ == 1 
else_jump @VALET_15431 
Model.Load(#FELTZER)
04AF: 14@ = 533 

:VALET_15431
if 
  6@ == 2 
else_jump @VALET_15462 
Model.Load(#ELEGANT)
04AF: 14@ = 507 

:VALET_15462
if 
  15@ >= 6 
else_jump @VALET_15771 
if 
   not 14@ == 0 
else_jump @VALET_15771 
if 
   Model.Available(14@)
else_jump @VALET_15771 
if 
80C2:   not sphere_onscreen " + tmp_10896 + @"(" + _1884 + @",4f) " + tmp_10900 + @"(" + _1884 + @",4f) " + tmp_10904 + @"(" + _1884 + @",4f) radius 5.0 
else_jump @VALET_15646 
0395: clear_area 0 at " + tmp_10896 + @"(" + _1884 + @",4f) " + tmp_10900 + @"(" + _1884 + @",4f) " + tmp_10904 + @"(" + _1884 + @",4f) radius 5.0 
" + _1881 + @" = Car.Create(14@, " + tmp_10896 + @"(" + _1884 + @",4f), " + tmp_10900 + @"(" + _1884 + @",4f), " + tmp_10904 + @"(" + _1884 + @",4f))
Car.Angle(" + _1881 + @") = " + tmp_10908 + @"(" + _1884 + @",4f)
0560: create_random_actor_in_car " + _1881 + @" handle_as " + _10747 + @" 
073B: unknown_car " + _1881 + @" flag 0 
jump @VALET_15771 

:VALET_15646
if 
80C2:   not sphere_onscreen " + tmp_10912 + @"(" + _1884 + @",4f) " + tmp_10916 + @"(" + _1884 + @",4f) " + tmp_10920 + @"(" + _1884 + @",4f) radius 5.0 
else_jump @VALET_15771 
0395: clear_area 0 at " + tmp_10912 + @"(" + _1884 + @",4f) " + tmp_10916 + @"(" + _1884 + @",4f) " + tmp_10920 + @"(" + _1884 + @",4f) radius 5.0 
" + _1881 + @" = Car.Create(14@, " + tmp_10912 + @"(" + _1884 + @",4f), " + tmp_10916 + @"(" + _1884 + @",4f), " + tmp_10920 + @"(" + _1884 + @",4f))
Car.Angle(" + _1881 + @") = " + tmp_10924 + @"(" + _1884 + @",4f)
0560: create_random_actor_in_car " + _1881 + @" handle_as " + _10747 + @" 
073B: unknown_car " + _1881 + @" flag 0 

:VALET_15771
if 
   not " + _1881 + @" == 0 
else_jump @VALET_16069 
" + _1885 + @" = 0 
if and
   not Actor.Dead(" + _10747 + @")
   not Car.Wrecked(" + _1881 + @")
else_jump @VALET_16039 
if 
  " + _1901 + @" == 1 
else_jump @VALET_15844 
0229: set_car " + _1881 + @" primary_color_to 3 secondary_color_to 3 

:VALET_15844
Actor.RemoveReferences(" + _10747 + @")
0615: define_AS_pack_begin 11@ 
if 
  " + OnMission + @" == 0 
else_jump @VALET_15911 
05D1: AS_actor -1 drive_car " + _1881 + @" to " + tmp_10884 + @"(" + _1884 + @",4f) " + tmp_10888 + @"(" + _1884 + @",4f) " + tmp_10892 + @"(" + _1884 + @",4f) speed 17.0 0 model #NULL 0 

:VALET_15911
if 
  " + OnMission + @" == 1 
else_jump @VALET_15968 
05D1: AS_actor -1 drive_car " + _1881 + @" to " + tmp_10884 + @"(" + _1884 + @",4f) " + tmp_10888 + @"(" + _1884 + @",4f) " + tmp_10892 + @"(" + _1884 + @",4f) speed 17.0 0 model #NULL 2 

:VALET_15968
05DE: AS_actor -1 walk_around_ped_path 
0616: define_AS_pack_end 11@ 
if 
   not Actor.Dead(" + _10747 + @")
else_jump @VALET_16000 
039E: set_actor " + _10747 + @" locked 1 while_in_car 

:VALET_16000
if 
  " + _1870 + @" == 1 
else_jump @VALET_16026 
0084: " + _10946 + @" = " + _1881 + @" 

:VALET_16026
0618: assign_actor " + _10747 + @" to_AS_pack 11@ 
061B: remove_references_to_AS_pack 11@ 

:VALET_16039
if 
   not 14@ == 0 
else_jump @VALET_16069 
Model.Destroy(14@)
14@ = 0 

:VALET_16069
return 

:VALET_16071
if or
  " + _1870 + @" == 1 
  " + _1871 + @" == 1 
else_jump @VALET_16440 
if and
   not " + _10754 + @" == -1 
803A:   not  " + _10754 + @" == " + _1867 + @" 
803A:   not  " + _10754 + @" == " + _10934 + @" 
else_jump @VALET_16440 
if 
803A:   not  " + _10947 + @" == " + _10754 + @" 
else_jump @VALET_16440 
if 
   not Car.Wrecked(" + _10754 + @")
else_jump @VALET_16440 
Car.StorePos(" + _10754 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if or
  -1760.178 > " + tempvar_Float_1 + @" 
  972.2405 > " + tempvar_Float_2 + @" 
  16.1633 > " + tempvar_Float_3 + @" 
  " + tempvar_Float_1 + @" > -1679.605 
  " + tempvar_Float_2 + @" > 1064.293 
  " + tempvar_Float_3 + @" > 24.8629 
else_jump @VALET_16440 
if 
   not Actor.InCar(" + PlayerActor + @", " + _10754 + @")
else_jump @VALET_16440 
if 
82CA:   not car " + _10754 + @" bounding_sphere_visible 
else_jump @VALET_16297 
Car.Destroy(" + _10754 + @")
jump @VALET_16440 

:VALET_16297
046C: " + _10749 + @" = car " + _10754 + @" driver 
if 
  " + _10749 + @" == -1 
else_jump @VALET_16440 
if 
8205:   not actor " + PlayerActor + @" near_car " + _10754 + @" radius 8.0 8.0 8.0 flag 0 
else_jump @VALET_16440 
0376: " + _10749 + @" = create_random_actor_at 0.0 0.0 0.0 
Actor.RemoveReferences(" + _10749 + @")
Car.RemoveReferences(" + _10754 + @")
if and
   not Actor.Dead(" + _10749 + @")
   not Car.Wrecked(" + _10754 + @")
else_jump @VALET_16440 
036A: put_actor " + _10749 + @" in_car " + _10754 + @" 
05D2: AS_actor " + _10749 + @" run_to_and_hijack_car " + _10754 + @" max_search_radius 20.0 traffic_behavior 2 
" + _10754 + @" = 0 

:VALET_16440
return 

:VALET_16442
if 
  " + _1900 + @" == 0 
else_jump @VALET_16825 
//0394: play_music 1 
" + _1900 + @" = 1 
fade 0 500 

:VALET_16478
if 
fading 
else_jump @VALET_16502 
wait 0 
jump @VALET_16478 

:VALET_16502
00BE: text_clear_all 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @VALET_16787 
Player.CanMove(" + PlayerChar + @") = False
02A3: enable_widescreen 1" );
_5271.create( -1757.668, 961.7819, 24.3828, 2000, 2000 );
AppendLine( @"Camera.SetAtPos(-1757.668, 961.7819, 24.3828)
Camera.SetPosition(-1761.832, 910.2675, 30.7224, 0.0, 0.0, 0.0)
Camera.PointAt(-1761.689, 911.2571, 30.7291, 2)
fade 1 500 

:VALET_16632
if 
fading 
else_jump @VALET_16656 
wait 0 
jump @VALET_16632 

:VALET_16656
0394: play_music 2 
00BA: show_text_styled GXT 'ASS_ACQ' time 5000 style 6  
wait 5000 
Camera.SetPosition(-1748.38, 951.821, 27.5455, 0.0, 0.0, 0.0)
Camera.PointAt(-1748.938, 952.5872, 27.2272, 2)
01E5: show_text_1number_highpriority GXT 'ASS_LUV' number 2000 time 6000 flag 1  
wait 6000 
fade 0 500 

:VALET_16763
if 
fading 
else_jump @VALET_16787 
wait 0 
jump @VALET_16763 

:VALET_16787
if 
   Player.Defined(" + PlayerChar + @")
else_jump @VALET_16825 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
02A3: enable_widescreen 0 
Player.CanMove(" + PlayerChar + @") = True
fade 1 500 

:VALET_16825
00BA: show_text_styled GXT 'VAL_A33' time 5000 style 1  
" + _10936 + @" = 8 
return 

:VALET_16850
Model.Destroy(#WMYVA)
Actor.RemoveReferences(" + tmp_1874 + @"[0])
Actor.RemoveReferences(" + tmp_1874 + @"[1])
Actor.RemoveReferences(" + tmp_1874 + @"[2])
0151: remove_status_text " + _10937 + @" 
014F: stop_timer " + _10935 + @" 
0151: remove_status_text " + _10933 + @" 
065C: release_decision_maker 7@ 
if 
   not Actor.Dead(" + tmp_1874 + @"[0])
else_jump @VALET_16911 
Actor.DestroyInstantly(" + tmp_1874 + @"[0])

:VALET_16911
if 
   not Actor.Dead(" + tmp_1874 + @"[1])
else_jump @VALET_16932 
Actor.DestroyInstantly(" + tmp_1874 + @"[1])

:VALET_16932
if 
   not Actor.Dead(" + tmp_1874 + @"[2])
else_jump @VALET_16953 
Actor.DestroyInstantly(" + tmp_1874 + @"[2])

:VALET_16953
if 
  " + _1870 + @" == 1 
else_jump @VALET_16982 
03DE: set_pedestrians_density_multiplier_to 1.0 
06D0: enable_emergency_traffic 1 

:VALET_16982
" + tmp_1892 + @"[0] = 1 
" + tmp_1892 + @"[1] = 1 
" + tmp_1892 + @"[2] = 1 
4@ = 0 
" + _10932 + @" = 0 
if 
   not Car.Wrecked(" + _10934 + @")
else_jump @VALET_17073 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_17073 
if 
   not Actor.InCar(" + PlayerActor + @", " + _10934 + @")
else_jump @VALET_17073 
Car.Destroy(" + _10934 + @")

:VALET_17073
if 
   not Car.Wrecked(" + tmp_1878 + @"[0])
else_jump @VALET_17129 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_17129 
if 
   not Actor.InCar(" + PlayerActor + @", " + tmp_1878 + @"[0])
else_jump @VALET_17129 
Car.Destroy(" + tmp_1878 + @"[0])

:VALET_17129
if 
   not Car.Wrecked(" + tmp_1878 + @"[1])
else_jump @VALET_17185 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_17185 
if 
   not Actor.InCar(" + PlayerActor + @", " + tmp_1878 + @"[1])
else_jump @VALET_17185 
Car.Destroy(" + tmp_1878 + @"[1])

:VALET_17185
if 
   not Car.Wrecked(" + tmp_1878 + @"[2])
else_jump @VALET_17241 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_17241 
if 
   not Actor.InCar(" + PlayerActor + @", " + tmp_1878 + @"[2])
else_jump @VALET_17241 
Car.Destroy(" + tmp_1878 + @"[2])

:VALET_17241
if 
   not Car.Wrecked(" + _1877 + @")
else_jump @VALET_17297 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_17297 
if 
   not Actor.InCar(" + PlayerActor + @", " + _1877 + @")
else_jump @VALET_17297 
Car.Destroy(" + _1877 + @")

:VALET_17297
if 
   not Car.Wrecked(" + _1881 + @")
else_jump @VALET_17353 
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @VALET_17353 
if 
   not Actor.InCar(" + PlayerActor + @", " + _1881 + @")
else_jump @VALET_17353 
Car.Destroy(" + _1881 + @")

:VALET_17353
" + _1897 + @" = 0 
" + _1898 + @" = 0 
" + _1899 + @" = 0 
" + _10934 + @" = 0 
" + tmp_1878 + @"[0] = 0 
" + tmp_1878 + @"[1] = 0 
" + tmp_1878 + @"[2] = 0 
" + _1877 + @" = 0 
" + _1891 + @" = 4 
" + _1881 + @" = 0 
" + _10936 + @" = 0 
" + _10753 + @" = 0 
" + _1873 + @" = 0 
" + _1896 + @" = 0 
Marker.Disable(20@)
Marker.Disable(19@)
end_thread 
return 
end_thread" );
            }

        }

    }

}