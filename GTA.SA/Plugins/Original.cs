using System;
using System.Collections.Generic;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public abstract class Original {

        // ---------------------------------------------------------------------------------------------------------------------------

        #region GLOBAL VARIABLES

        #region Int

        internal static Int
            _1148 = Script.global(), ScriptStatus = Script.global(),
            Import_Car = Script.global(), _1909 = Script.global(), _1150 = Script.global(), _41 = Script.global(),
            Import_Car_Price = Script.global(), Import_Panel_Row = Script.global(), _1181 = Script.global(),
            Help_Import_Shown = Script.global(), Import_Car_Panel = Script.global(), _1194 = Script.global(),
            Current_Wanted_List = Script.global(), Wanted_List_Object = Script.global(), _1146 = Script.global(),
            Import_Price_Multiplier = Script.global(), Export_Price_Multiplier = Script.global(), _1185 = Script.global(),
            Export_Price_Health_Multiplier = Script.global(), All_Cars_Collected_Flag = Script.global(),
            _10742 = Script.global(), Import_New_Available_Cars_Number = Script.global(), _1153 = Script.global(),
            _10741 = Script.global(), _10737 = Script.global(), _10712 = Script.global(), _10715 = Script.global(),
            _10714 = Script.global(), _10557 = Script.global(), _10713 = Script.global(), _10740 = Script.global(),
            _10524 = Script.global(), _10743 = Script.global(), _10744 = Script.global(), _10745 = Script.global(),
            _10671 = Script.global(), _10681 = Script.global(), _10691 = Script.global(), _10729 = Script.global(),
            _10701 = Script.global(), _10735 = Script.global(), _10670 = Script.global(), _10680 = Script.global(),
            _10690 = Script.global(), _10700 = Script.global(), _10672 = Script.global(), _10682 = Script.global(),
            _10692 = Script.global(), _10702 = Script.global(), _10734 = Script.global(), _10736 = Script.global(),
            _10559 = Script.global(), _10563 = Script.global(), _10567 = Script.global(), _10571 = Script.global(),
            _10575 = Script.global(), _10579 = Script.global(), _10583 = Script.global(), _10587 = Script.global(),
            _10591 = Script.global(), _10595 = Script.global(), _10599 = Script.global(), _10603 = Script.global(),
            _10560 = Script.global(), _10564 = Script.global(), _10568 = Script.global(), _10572 = Script.global(),
            _10576 = Script.global(), _10580 = Script.global(), _10584 = Script.global(), _10588 = Script.global(),
            _10592 = Script.global(), _10596 = Script.global(), _10600 = Script.global(), _10604 = Script.global(),
            _10561 = Script.global(), _10565 = Script.global(), _10569 = Script.global(), _10573 = Script.global(),
            _10577 = Script.global(), _10581 = Script.global(), _10585 = Script.global(), _10589 = Script.global(),
            _10593 = Script.global(), _10597 = Script.global(), _10601 = Script.global(), _10605 = Script.global(),
            _10730 = Script.global(), _10731 = Script.global(), _10732 = Script.global(), _10733 = Script.global(),
            IMPOUND_Town_Number = Script.global(), _1522 = Script.global(), _10710 = Script.global(),
            _1317 = Script.global(), _1301 = Script.global(), _1340 = Script.global(), _10711 = Script.global(),
            HJ_Player_Car = Script.global(), HJ_Car_Z = Script.global(), _1316 = Script.global(),
            HJ_Temp_Float = Script.global(), HJ_Car_Z_Max = Script.global(), HJ_Car_Angle = Script.global(),
            HJ_TwoWheels_Time = Script.global(), HJ_Wheelie_Time = Script.global(), HJ_Stoppie_Time = Script.global(),
            HJ_Car_X_End_Stunt = Script.global(), HJ_Car_Y_End_Stunt = Script.global(), HJ_Stunt_Height = Script.global(),
            HJ_Stunt_Height_Rem = Script.global(), HJ_Stunt_Bonus_Temp = Script.global(), HJ_Stunt_Flips = Script.global(),
            HJ_Stunt_Bonus_Mult = Script.global(), HJ_Begin_Stunt_Flag = Script.global(), HJ_Stunt_Bonus = Script.global(),
            HJ_Car_Y_Begin_Stunt = Script.global(), HJ_Car_Z_Begin_Stunt = Script.global(), HJ_Car_X = Script.global(),
            HJ_Stunt_Rotation_Int = Script.global(), HJ_Car_X_Begin_Stunt = Script.global(), HJ_Bonus = Script.global(),
            HJ_Stunt_Rotation_Float = Script.global(), HJ_Stunt_Flipping_Flag = Script.global(), HJ_Car_Y = Script.global(),
            HJ_Stoppie_Distance_Feet = Script.global(), HJ_Car_Angle_Begin_Stunt = Script.global(), _1293 = Script.global(),
            HJ_Stunt_Distance_Max_Rem = Script.global(), HJ_Wheelie_Distance_Feet = Script.global(),
            HJ_Stoppie_Distance_Float = Script.global(), HJ_Stunt_Distance_Max_Int = Script.global(),
            HJ_TwoWheels_Distance_Feet = Script.global(), HJ_Wheelie_Distance_Float = Script.global(),
            HJ_TwoWheels_Distance_Float = Script.global(), HJ_Stunt_Distance_Max_Float = Script.global(),
            HJ_Stoppie_Distance_Meters_Rem = Script.global(), HJ_Stoppie_Distance_Feet_Float = Script.global(),
            HJ_Wheelie_Distance_Feet_Float = Script.global(), HJ_Stoppie_Distance_Meters_Int = Script.global(),
            HJ_Wheelie_Distance_Meters_Int = Script.global(), HJ_Wheelie_Distance_Meters_Rem = Script.global(),
            HJ_Wheelie_Distance_Meters_Float = Script.global(), HJ_Stoppie_Distance_Meters_Float = Script.global(),
            HJ_TwoWheels_Distance_Meters_Rem = Script.global(), HJ_TwoWheels_Distance_Feet_Float = Script.global(),
            HJ_TwoWheels_Distance_Meters_Float = Script.global(), HJ_TwoWheels_Distance_Meters_Int = Script.global(),
            _9499 = Script.global(), _9500 = Script.global(), PLANES_Weekday = Script.global(),
            _9502 = Script.global(), _9503 = Script.global(), _9504 = Script.global(), _9501 = Script.global(),
            _9508 = Script.global(), _9509 = Script.global(), _9510 = Script.global(), _9511 = Script.global(),
            _9521 = Script.global(), _9513 = Script.global(), _9514 = Script.global(), _9515 = Script.global(),
            _9516 = Script.global(), _9517 = Script.global(), _9518 = Script.global(), _9519 = Script.global(),
            _9520 = Script.global(), _9512 = Script.global(), _9522 = Script.global(), _9506 = Script.global(),
            PLANES_Conversation_YES = Script.global(), PLAINS_Plane_Flyway = Script.global(), _9505 = Script.global(),
            TRAINS_Text_Shown = Script.global(), PLANES_STAT_Unlocked_Cities_Number = Script.global(),
            TRAINS_Train_Handle = Script.global(), TRAINS_Train_Speed = Script.global(), _9479 = Script.global(),
            _793 = Script.global(), _796 = Script.global(), _794 = Script.global(), _797 = Script.global(),
            _1900 = Script.global(), _1802 = Script.global(), _792 = Script.global(), _795 = Script.global(),
            _10747 = Script.global(), _1901 = Script.global(), _1871 = Script.global(), _10947 = Script.global(),
            _1885 = Script.global(), _1891 = Script.global(), _10724 = Script.global(), _10945 = Script.global(),
            _10929 = Script.global(), _10749 = Script.global(), _1890 = Script.global(), _10752 = Script.global(),
            _10940 = Script.global(), _10938 = Script.global(), _10928 = Script.global(), _1895 = Script.global(),
            _10942 = Script.global(), _10943 = Script.global(), _10944 = Script.global(), _10939 = Script.global(),
            _10754 = Script.global(), _10933 = Script.global(), _1897 = Script.global(), _1898 = Script.global(),
            _1886 = Script.global(), _10750 = Script.global(), _1869 = Script.global(), _5286 = Script.global(),
            _1870 = Script.global(), _10930 = Script.global(), _10931 = Script.global(), _10932 = Script.global(),
            _1882 = Script.global(), _10946 = Script.global(), _1873 = Script.global(), _10753 = Script.global(),
            _10934 = Script.global(), VALET_Car = Script.global(), _10748 = Script.global(), _1881 = Script.global(),
            _1899 = Script.global(), VALET_Stage = Script.global(), _10937 = Script.global(), _1867 = Script.global(),
            VALET_Parked_Cars_Number = Script.global(), VALET_Car_Driver = Script.global(), _10936 = Script.global(),
            _10755 = Script.global(), _1883 = Script.global(), _1896 = Script.global(), _1877 = Script.global(),
            _8172 = Script.global(), _8173 = Script.global(), _1872 = Script.global(), _1884 = Script.global(),
            Quarry_Missions_Passed = Script.global(), Mission_Quarry_Passed = Script.global(), _10935 = Script.global(),
            _8163 = Script.global(), _8164 = Script.global(), _8165 = Script.global(), _8166 = Script.global(),
            _8167 = Script.global(), _8168 = Script.global(), _8169 = Script.global(), _8170 = Script.global(),
            Trucking_Total_Passed_Missions = Script.global(), Mission_Trucking_Passed = Script.global(),
            STAT_Stamina = Script.global(), Mission_BeatTheCock_Passed = Script.global(), _8162 = Script.global(),
            Help_TRI_Cycling_Shown = Script.global(), Help_TRI_NoCock_Shown = Script.global(), _8161 = Script.global(),
            Mission_BeatTheCock_Type = Script.global(), Help_TRI_Stamina_Shown = Script.global(), _8160 = Script.global(),
            Mission_NRG500_Stunt_Passed = Script.global(), Mission_BMX_Stunt_Passed = Script.global(),
            Mission_Chiliad_Challenge_Passed = Script.global(), _8266 = Script.global(), _1799 = Script.global(),
            Mission_Courier_LV_Passed = Script.global(), Mission_Courier_SF_Passed = Script.global(),
            ONMISSION_Chiliad = Script.global(), Mission_Courier_LS_Passed = Script.global(), _8267 = Script.global(),
            STUNT_Mission_Type = Script.global(), ONMISSION_Courier = Script.global(), _8264 = Script.global(),
            ONMISSION_Stunt_BMX = Script.global(), STAT_Cycling_Skill = Script.global(), _8265 = Script.global(),
            Help_BMX_Cycling_Shown = Script.global(), ONMISSION_Stunt_NRG500 = Script.global(), _158 = Script.global(),
            ONMISSION_Mike_Toreno = Script.global(), Help_Chiliad_Cycling_Shown = Script.global(),
            _2165 = Script.global(), _2166 = Script.global(), Airport_Open_Flag = Script.global(),
            _2169 = Script.global(), _2170 = Script.global(), _2173 = Script.global(), _2172 = Script.global(),
            _2171 = Script.global(), _2176 = Script.global(), _2175 = Script.global(), _2174 = Script.global(),
            _2179 = Script.global(), _2178 = Script.global(), _2177 = Script.global(), _2185 = Script.global(),
            _2184 = Script.global(), _2183 = Script.global(), _2182 = Script.global(), _2181 = Script.global(),
            _2180 = Script.global(), _2188 = Script.global(), _2167 = Script.global(), _2168 = Script.global(),
            parked_FCR900_Exists = Script.global(), _2187 = Script.global(), _2186 = Script.global(),
            parked_Freeway_Exists = Script.global(), parked_NRG500_Exists = Script.global(), _8263 = Script.global(),
            Mission_Driving_School_Passed = Script.global(), _2162 = Script.global(), _2164 = Script.global(),
            _8196 = Script.global(), _8190 = Script.global(), _8191 = Script.global(), _8192 = Script.global(),
            _8194 = Script.global(), _8193 = Script.global(), _1962 = Script.global(), _8197 = Script.global(),
            _1963 = Script.global(), _1972 = Script.global(), _1971 = Script.global(), _1970 = Script.global(),
            _1964 = Script.global(), _1975 = Script.global(), _1974 = Script.global(), _1973 = Script.global(),
            _1965 = Script.global(), _1978 = Script.global(), _1977 = Script.global(), _1976 = Script.global(),
            _1966 = Script.global(), _1981 = Script.global(), _1980 = Script.global(), _1979 = Script.global(),
            _1967 = Script.global(), _1984 = Script.global(), _1983 = Script.global(), _1982 = Script.global(),
            parked_Jetmax_Exists = Script.global(), parked_Squalo_Exists = Script.global(), _8189 = Script.global(),
            Mission_Boat_School_Passed = Script.global(), parked_Marquis_Exists = Script.global(),
            _8275 = Script.global(), _8289 = Script.global(), _8290 = Script.global(), _8195 = Script.global(),
            _8302 = Script.global(), _8303 = Script.global(), _8301 = Script.global(), _8300 = Script.global(),
            _8304 = Script.global(), _8276 = Script.global(), _8297 = Script.global(), _8298 = Script.global(),
            _8277 = Script.global(), _8282 = Script.global(), _8283 = Script.global(), _8284 = Script.global(),
            _8279 = Script.global(), _8280 = Script.global(), _8278 = Script.global(), _8281 = Script.global(),
            _8299 = Script.global(), _8288 = Script.global(), _8274 = Script.global(), _8285 = Script.global(),
            _8292 = Script.global(), _8291 = Script.global(), _8293 = Script.global(), _8294 = Script.global(),
            _8295 = Script.global(), _8296 = Script.global(), _8286 = Script.global(), _8287 = Script.global(),
            _8271 = Script.global(), _8272 = Script.global(), _8273 = Script.global(), _1510 = Script.global(),
            _7518 = Script.global(), _7520 = Script.global(), _7519 = Script.global(), _7526 = Script.global(),
            _7513 = Script.global(), _7514 = Script.global(), _7516 = Script.global(), _7521 = Script.global(),
            _7523 = Script.global(), _7524 = Script.global(), _7525 = Script.global(), _7517 = Script.global(),
            parked_Hunter_Exists = Script.global(), parked_Stunt_Exists = Script.global(), _7522 = Script.global(),
            Flight_School_Brief_Played = Script.global(), parked_Rustler_Exists = Script.global(), _98 = Script.global(),
            Flight_School_Current_Contest = Script.global(), Flight_School_Contests_Passed = Script.global(),
            _53 = Script.global(), _96 = Script.global(), _7515 = Script.global(), _1502 = Script.global(),
            _91 = Script.global(), _92 = Script.global(), _97 = Script.global(), _12 = Script.global(),
            _295 = Script.global(), _263 = Script.global(), _279 = Script.global(), _94 = Script.global(),
            _296 = Script.global(), _298 = Script.global(), _299 = Script.global(), _288 = Script.global(),
            _291 = Script.global(), _294 = Script.global(), _297 = Script.global(), _300 = Script.global(),
            _289 = Script.global(), _290 = Script.global(), _292 = Script.global(), _293 = Script.global(),
            _250 = Script.global(), _260 = Script.global(), _286 = Script.global(), _287 = Script.global(),
            _330 = Script.global(), _331 = Script.global(), _332 = Script.global(), _333 = Script.global(),
            _272 = Script.global(), _285 = Script.global(), _280 = Script.global(), _281 = Script.global(),
            _264 = Script.global(), _262 = Script.global(), _265 = Script.global(), _268 = Script.global(),
            _283 = Script.global(), _282 = Script.global(), _269 = Script.global(), _261 = Script.global(),
            _301 = Script.global(), _302 = Script.global(), _270 = Script.global(), _284 = Script.global(),
            _323 = Script.global(), _324 = Script.global(), _254 = Script.global(), _275 = Script.global(),
            _319 = Script.global(), _320 = Script.global(), _321 = Script.global(), _322 = Script.global(),
            _315 = Script.global(), _316 = Script.global(), _317 = Script.global(), _318 = Script.global(),
            _304 = Script.global(), _259 = Script.global(), _313 = Script.global(), _314 = Script.global(),
            _252 = Script.global(), _273 = Script.global(), _276 = Script.global(), _303 = Script.global(),
            _310 = Script.global(), _311 = Script.global(), _312 = Script.global(), _251 = Script.global(),
            _266 = Script.global(), _267 = Script.global(), _326 = Script.global(), _309 = Script.global(),
            _305 = Script.global(), _325 = Script.global(), _249 = Script.global(), _274 = Script.global(),
            _258 = Script.global(), _255 = Script.global(), _256 = Script.global(), _306 = Script.global(),
            _101 = Script.global(), _102 = Script.global(), _100 = Script.global(), _253 = Script.global(),
            _329 = Script.global(), _107 = Script.global(), _105 = Script.global(), _103 = Script.global(),
            _307 = Script.global(), _308 = Script.global(), _327 = Script.global(), _328 = Script.global(),
            _257 = Script.global(), _277 = Script.global(), _278 = Script.global(), _247 = Script.global(),
            _7419 = Script.global(), _196 = Script.global(), _197 = Script.global(), _198 = Script.global(),
            Current_Flight_Record = Script.global(), _7418 = Script.global(), _1499 = Script.global(),
            _5187 = Script.global(), Mission_Back_to_School_Passed = Script.global(), _7417 = Script.global(),
            Mission_Learning_to_Fly_Passed = Script.global(), Flight_School_Intro_Flag = Script.global(),
            _8085 = Script.global(), _8080 = Script.global(), _8093 = Script.global(), _8078 = Script.global(),
            _8148 = Script.global(), _8151 = Script.global(), _8079 = Script.global(), _8082 = Script.global(),
            _8147 = Script.global(), _8150 = Script.global(), _8092 = Script.global(), _8145 = Script.global(),
            _8143 = Script.global(), _8146 = Script.global(), _8149 = Script.global(), _8144 = Script.global(),
            _1861 = Script.global(), _5272 = Script.global(), _8125 = Script.global(), _8127 = Script.global(),
            _8124 = Script.global(), _8083 = Script.global(), _8084 = Script.global(), _8081 = Script.global(),
            _8135 = Script.global(), _8131 = Script.global(), _8139 = Script.global(), _8133 = Script.global(),
            _8136 = Script.global(), _8132 = Script.global(), _8140 = Script.global(), _8137 = Script.global(),
            _8138 = Script.global(), _8134 = Script.global(), _8141 = Script.global(), _8142 = Script.global(),
            _8065 = Script.global(), _8074 = Script.global(), _8126 = Script.global(), _5287 = Script.global(),
            _8075 = Script.global(), _8076 = Script.global(), _5273 = Script.global(), _8069 = Script.global(),
            _8019 = Script.global(), _8023 = Script.global(), _8020 = Script.global(), _8024 = Script.global(),
            _8017 = Script.global(), _8021 = Script.global(), _8018 = Script.global(), _8022 = Script.global(),
            Shooting_Index_2 = Script.global(), Shooting_Index = Script.global(), _8070 = Script.global(),
            _8248 = Script.global(), _8247 = Script.global(), Shooting_Available = Script.global(),
            _8255 = Script.global(), Mission_BloodRing_Passed = Script.global(), _8249 = Script.global(),
            _1804 = Script.global(), _8253 = Script.global(), _8251 = Script.global(), _8252 = Script.global(),
            _8250 = Script.global(), _8262 = Script.global(), _8256 = Script.global(), _8254 = Script.global(),
            STAT_Driving_Skill = Script.global(), Mission_Kickstart_Passed = Script.global(), _8261 = Script.global(),
            _6941 = Script.global(), _6955 = Script.global(), _1398 = Script.global(), _1940 = Script.global(),
            _6940 = Script.global(), _6954 = Script.global(), _6913 = Script.global(), _6927 = Script.global(),
            _6939 = Script.global(), _6953 = Script.global(), _6912 = Script.global(), _6926 = Script.global(),
            _6938 = Script.global(), _6952 = Script.global(), _6911 = Script.global(), _6925 = Script.global(),
            _6909 = Script.global(), _6937 = Script.global(), _6951 = Script.global(), _6910 = Script.global(),
            _6949 = Script.global(), _6908 = Script.global(), _6936 = Script.global(), _6950 = Script.global(),
            _6934 = Script.global(), _6948 = Script.global(), _6907 = Script.global(), _6935 = Script.global(),
            _6960 = Script.global(), _6904 = Script.global(), _6905 = Script.global(), _6906 = Script.global(),
            _6922 = Script.global(), _6923 = Script.global(), _6924 = Script.global(), _6921 = Script.global(),
            _6919 = Script.global(), _6933 = Script.global(), _6947 = Script.global(), _6920 = Script.global(),
            _6945 = Script.global(), _6918 = Script.global(), _6932 = Script.global(), _6946 = Script.global(),
            Races_Won_Number = Script.global(), _1846 = Script.global(), _6931 = Script.global(),
            All_Races_Won_Prize_Flag = Script.global(), Pilot_License_Obtained = Script.global(), _164 = Script.global(),
            Current_Tournament = Script.global(), CPRACE_Debug_Checkpoint_Index = Script.global(), _200 = Script.global(),
            Garage_Total_Passed_Missions = Script.global(), Custom_Tournament_Flag = Script.global(),
            Mission_Pimping_Passed = Script.global(), _8246 = Script.global(), Race_Index = Script.global(),
            _8241 = Script.global(), _8240 = Script.global(), _163 = Script.global(), _8245 = Script.global(),
            _8239 = Script.global(), _8238 = Script.global(), _8242 = Script.global(), _8243 = Script.global(),
            BUGRLARY_Cash = Script.global(), _1790 = Script.global(), _1791 = Script.global(),
            BURGLARY_Time_left = Script.global(), BURGLARY_Daylight = Script.global(), _6917 = Script.global(),
            BURGLARY_Escape_Time_Sec = Script.global(), Mission_Burglary_Passed = Script.global(),
            _5350 = Script.global(), _5351 = Script.global(), _5352 = Script.global(), _6903 = Script.global(),
            _118 = Script.global(), BURGLARY_Detected_Flag = Script.global(), BURGLARY_Noise_i = Script.global(),
            _8224 = Script.global(), _8227 = Script.global(), _111 = Script.global(), _112 = Script.global(),
            _113 = Script.global(), _114 = Script.global(), _115 = Script.global(), _116 = Script.global(),
            Mission_Vigilante_Passed = Script.global(), _8222 = Script.global(), _8223 = Script.global(),
            _8213 = Script.global(), _8221 = Script.global(), _8220 = Script.global(), _117 = Script.global(),
            Help_Firetruck_Shown = Script.global(), _1489 = Script.global(), _8215 = Script.global(),
            _8210 = Script.global(), _8212 = Script.global(), _412 = Script.global(), _8214 = Script.global(),
            _56 = Script.global(), Paramedic_Mission_Level = Script.global(), _1487 = Script.global(),
            _8208 = Script.global(), _8209 = Script.global(), _411 = Script.global(), _183 = Script.global(),
            _8204 = Script.global(), _8205 = Script.global(), _8206 = Script.global(), _8207 = Script.global(),
            _8200 = Script.global(), _8198 = Script.global(), _8202 = Script.global(), _8203 = Script.global(),
            Mission_Taxi_Passed = Script.global(), _8201 = Script.global(), _8199 = Script.global(),
            _13 = Script.global(), _159 = Script.global(), Total_Passengers_DroppedOff = Script.global(),
            ONMISSION_TAXI = Script.global(), Time_Hours = Script.global(), _162 = Script.global(),
            ONMISSION_Paramedic = Script.global(), ONMISSION_Burglary = Script.global(), _160 = Script.global(),
            Help_Toggle_OddJob_Shown = Script.global(), ONMISSION_Firefighter = Script.global(), _63 = Script.global(),
            _6460 = Script.global(), _6461 = Script.global(), _6470 = Script.global(), _161 = Script.global(),
            _6462 = Script.global(), _6463 = Script.global(), _6464 = Script.global(), _6465 = Script.global(),
            _6443 = Script.global(), _6444 = Script.global(), _6445 = Script.global(), _6446 = Script.global(),
            _6447 = Script.global(), _6448 = Script.global(), _6449 = Script.global(), _6450 = Script.global(),
            _6451 = Script.global(), _6452 = Script.global(), _6453 = Script.global(), _6454 = Script.global(),
            _6455 = Script.global(), _6456 = Script.global(), _6457 = Script.global(), _6458 = Script.global(),
            _6466 = Script.global(), _6468 = Script.global(), _6467 = Script.global(), _6459 = Script.global(),
            _9460 = Script.global(), _9461 = Script.global(), _1904 = Script.global(), _6469 = Script.global(),
            _9462 = Script.global(), _9457 = Script.global(), _9458 = Script.global(), _9459 = Script.global(),
            _6434 = Script.global(), _6435 = Script.global(), _6436 = Script.global(), _6437 = Script.global(),
            _6430 = Script.global(), _6431 = Script.global(), _6432 = Script.global(), _6433 = Script.global(),
            _6426 = Script.global(), _6427 = Script.global(), _6428 = Script.global(), _6429 = Script.global(),
            _6422 = Script.global(), _6423 = Script.global(), _6424 = Script.global(), _6425 = Script.global(),
            _6418 = Script.global(), _6419 = Script.global(), _6420 = Script.global(), _6421 = Script.global(),
            _6414 = Script.global(), _6415 = Script.global(), _6416 = Script.global(), _6417 = Script.global(),
            _6410 = Script.global(), _6411 = Script.global(), _6412 = Script.global(), _6413 = Script.global(),
            _6399 = Script.global(), _6400 = Script.global(), _6407 = Script.global(), _6409 = Script.global(),
            _6215 = Script.global(), _6212 = Script.global(), _6438 = Script.global(), _6442 = Script.global(),
            _6223 = Script.global(), _6440 = Script.global(), _6214 = Script.global(), _6312 = Script.global(),
            _6219 = Script.global(), _6220 = Script.global(), _6221 = Script.global(), _6222 = Script.global(),
            _6233 = Script.global(), _6234 = Script.global(), _6441 = Script.global(), _6218 = Script.global(),
            _6226 = Script.global(), _6227 = Script.global(), _6229 = Script.global(), _6230 = Script.global(),
            _6315 = Script.global(), _6314 = Script.global(), _6216 = Script.global(), _6228 = Script.global(),
            _6203 = Script.global(), _6206 = Script.global(), _6207 = Script.global(), _6316 = Script.global(),
            _6209 = Script.global(), _6235 = Script.global(), _6217 = Script.global(), _6202 = Script.global(),
            _6211 = Script.global(), _6204 = Script.global(), _6205 = Script.global(), _6231 = Script.global(),
            _6208 = Script.global(), _6439 = Script.global(), _6224 = Script.global(), _6232 = Script.global(),
            _6405 = Script.global(), _6406 = Script.global(), _6210 = Script.global(), _6213 = Script.global(),
            _6317 = Script.global(), _6313 = Script.global(), _6401 = Script.global(), _6402 = Script.global(),
            _6398 = Script.global(), _6310 = Script.global(), _6404 = Script.global(), _6311 = Script.global(),
            _6175 = Script.global(), _6176 = Script.global(), Time_Mins = Script.global(), _6403 = Script.global(),
            _6186 = Script.global(), _6187 = Script.global(), _6188 = Script.global(), _6189 = Script.global(),
            _6183 = Script.global(), _6184 = Script.global(), _6185 = Script.global(), _6190 = Script.global(),
            _6180 = Script.global(), _6181 = Script.global(), _6182 = Script.global(), _6191 = Script.global(),
            _6177 = Script.global(), _6178 = Script.global(), _6179 = Script.global(), _6159 = Script.global(),
            _6164 = Script.global(), _6166 = Script.global(), _6168 = Script.global(), _6174 = Script.global(),
            _5963 = Script.global(), _5645 = Script.global(), _5646 = Script.global(), _5647 = Script.global(),
            _6170 = Script.global(), _6171 = Script.global(), _6172 = Script.global(), _6173 = Script.global(),
            _6160 = Script.global(), _6165 = Script.global(), _6167 = Script.global(), _6169 = Script.global(),
            _6070 = Script.global(), _6158 = Script.global(), _6163 = Script.global(), _6161 = Script.global(),
            _6154 = Script.global(), _6157 = Script.global(), _6067 = Script.global(), _6068 = Script.global(),
            _6152 = Script.global(), _6153 = Script.global(), _6069 = Script.global(), _6155 = Script.global(),
            _5853 = Script.global(), _5989 = Script.global(), _5964 = Script.global(), _6151 = Script.global(),
            _5943 = Script.global(), _5944 = Script.global(), _5945 = Script.global(), _5657 = Script.global(),
            _5947 = Script.global(), _5948 = Script.global(), _5941 = Script.global(), _5959 = Script.global(),
            _5656 = Script.global(), _5909 = Script.global(), _5942 = Script.global(), _5946 = Script.global(),
            _5568 = Script.global(), _5990 = Script.global(), _5991 = Script.global(), _5587 = Script.global(),
            _5595 = Script.global(), _5596 = Script.global(), _5650 = Script.global(), _5651 = Script.global(),
            _5953 = Script.global(), _5955 = Script.global(), _5859 = Script.global(), _5950 = Script.global(),
            _5958 = Script.global(), _5951 = Script.global(), _5952 = Script.global(), _5954 = Script.global(),
            _5591 = Script.global(), _5855 = Script.global(), _5658 = Script.global(), _5858 = Script.global(),
            _5956 = Script.global(), _5856 = Script.global(), _5854 = Script.global(), _5857 = Script.global(),
            _5574 = Script.global(), _5583 = Script.global(), _5584 = Script.global(), _5957 = Script.global(),
            _5581 = Script.global(), _5575 = Script.global(), _5576 = Script.global(), _5573 = Script.global(),
            _5592 = Script.global(), _5653 = Script.global(), _5654 = Script.global(), _5960 = Script.global(),
            _5648 = Script.global(), _6156 = Script.global(), _5652 = Script.global(), _5770 = Script.global(),
            _5571 = Script.global(), _5572 = Script.global(), _5156 = Script.global(), _5579 = Script.global(),
            _5582 = Script.global(), _5992 = Script.global(), _5570 = Script.global(), _5580 = Script.global(),
            _5589 = Script.global(), _5590 = Script.global(), _5569 = Script.global(), _5649 = Script.global(),
            _2202 = Script.global(), _5588 = Script.global(), _5593 = Script.global(), _5594 = Script.global(),
            _5876 = Script.global(), _5585 = Script.global(), _5586 = Script.global(), _5723 = Script.global(),
            _5724 = Script.global(), _5577 = Script.global(), _5578 = Script.global(), _5949 = Script.global(),
            _5566 = Script.global(), _5567 = Script.global(), _5425 = Script.global(), _5655 = Script.global(),
            BeefyBaron_Time = Script.global(), BeefyBaron_Score = Script.global(), _5354 = Script.global(),
            _10188 = Script.global(), _10189 = Script.global(), _10414 = Script.global(), _10423 = Script.global(),
            _10415 = Script.global(), _10420 = Script.global(), _10421 = Script.global(), _10422 = Script.global(),
            _10424 = Script.global(), _10436 = Script.global(), _10084 = Script.global(), _10085 = Script.global(),
            _10086 = Script.global(), _10087 = Script.global(), _10088 = Script.global(), _10089 = Script.global(),
            _10090 = Script.global(), _10091 = Script.global(), _10092 = Script.global(), _10093 = Script.global(),
            _10094 = Script.global(), _10095 = Script.global(), _10096 = Script.global(), _10097 = Script.global(),
            _10098 = Script.global(), _10099 = Script.global(), _10100 = Script.global(), _10101 = Script.global(),
            _10102 = Script.global(), _10103 = Script.global(), _10104 = Script.global(), _10105 = Script.global(),
            _10106 = Script.global(), _10107 = Script.global(), _10108 = Script.global(), _10109 = Script.global(),
            _10110 = Script.global(), _10111 = Script.global(), _10112 = Script.global(), _10113 = Script.global(),
            _10114 = Script.global(), _10115 = Script.global(), _10116 = Script.global(), _10117 = Script.global(),
            _10118 = Script.global(), _10119 = Script.global(), _10120 = Script.global(), _10121 = Script.global(),
            _10122 = Script.global(), _10123 = Script.global(), _10124 = Script.global(), _10125 = Script.global(),
            _10126 = Script.global(), _10127 = Script.global(), _10128 = Script.global(), _10129 = Script.global(),
            _10130 = Script.global(), _10131 = Script.global(), _10132 = Script.global(), _10133 = Script.global(),
            _10134 = Script.global(), _10135 = Script.global(), _10136 = Script.global(), _10137 = Script.global(),
            _10138 = Script.global(), _10139 = Script.global(), _10140 = Script.global(), _10141 = Script.global(),
            _10142 = Script.global(), _10143 = Script.global(), _10144 = Script.global(), _10145 = Script.global(),
            _10146 = Script.global(), _10147 = Script.global(), _10148 = Script.global(), _10149 = Script.global(),
            _10150 = Script.global(), _10151 = Script.global(), _10152 = Script.global(), _10153 = Script.global(),
            _10154 = Script.global(), _10155 = Script.global(), _10156 = Script.global(), _10157 = Script.global(),
            _10158 = Script.global(), _10159 = Script.global(), _10160 = Script.global(), _10161 = Script.global(),
            _10162 = Script.global(), _10163 = Script.global(), _10164 = Script.global(), _10165 = Script.global(),
            _10166 = Script.global(), _10167 = Script.global(), _10168 = Script.global(), _10169 = Script.global(),
            _10170 = Script.global(), _10171 = Script.global(), _10172 = Script.global(), _10173 = Script.global(),
            _10174 = Script.global(), _10175 = Script.global(), _10176 = Script.global(), _10177 = Script.global(),
            _10178 = Script.global(), _10179 = Script.global(), _10180 = Script.global(), _10181 = Script.global(),
            _10182 = Script.global(), _10183 = Script.global(), _10184 = Script.global(), _10185 = Script.global(),
            _10186 = Script.global(), _10082 = Script.global(), _10187 = Script.global(), _10197 = Script.global(),
            _10190 = Script.global(), _10191 = Script.global(), _10192 = Script.global(), _10193 = Script.global(),
            _10194 = Script.global(), _10195 = Script.global(), _10196 = Script.global(), _10198 = Script.global(),
            _10199 = Script.global(), _10200 = Script.global(), _10201 = Script.global(), _10202 = Script.global(),
            _10203 = Script.global(), _10204 = Script.global(), _10205 = Script.global(), _10206 = Script.global(),
            _10411 = Script.global(), _10412 = Script.global(), _10413 = Script.global(), _10417 = Script.global(),
            _10416 = Script.global(), _10418 = Script.global(), _10419 = Script.global(), _10425 = Script.global(),
            _10427 = Script.global(), _10428 = Script.global(), _10429 = Script.global(), _10430 = Script.global(),
            _10437 = Script.global(), _10438 = Script.global(), _10439 = Script.global(), _10440 = Script.global(),
            _10441 = Script.global(), _10442 = Script.global(), _10443 = Script.global(), _10444 = Script.global(),
            _10445 = Script.global(), _10446 = Script.global(), _10447 = Script.global(), _10448 = Script.global(),
            _10481 = Script.global(), _10483 = Script.global(), _10484 = Script.global(), _10485 = Script.global(),
            _10486 = Script.global(), CARMOD_Car = Script.global(), _10482 = Script.global(), _2758 = Script.global(),
            CARMOD_Disabled_Flag = Script.global(), CARMOD_Menu_Colors = Script.global(), _10083 = Script.global(),
            _1023 = Script.global(), _1024 = Script.global(), _1025 = Script.global(), _1026 = Script.global(),
            LOWR_Last_Displayed_Text_ID = Script.global(), _1027 = Script.global(), _1028 = Script.global(),
            LOWR_Player_Points = Script.global(), Current_Time_in_ms = Script.global(), _1029 = Script.global(),
            _1020 = Script.global(), _6472 = Script.global(), _1022 = Script.global(), _1017 = Script.global(),
            LOWR_CONT_Script_Launched = Script.global(), tempvar_Actor_Car = Script.global(), _1021 = Script.global(),
            Mission_Cesar_Vialpando_Passed = Script.global(), LOWR_Opposition_Points = Script.global(),
            Audio_Line_Is_Active = Script.global(), _1035 = Script.global(), _6471 = Script.global(),
            _5283 = Script.global(), Actor_Speech_WAV_File = Script.global(), _1906 = Script.global(),
            Current_Town_Number = Script.global(), Weekday = Script.global(), _5284 = Script.global(),
            _3408 = Script.global(), _3409 = Script.global(), STAT_Unlocked_Cities_Number = Script.global(),
            _3469 = Script.global(), _3474 = Script.global(), _3412 = Script.global(), _3411 = Script.global(),
            _3467 = Script.global(), _3407 = Script.global(), _3472 = Script.global(), _3410 = Script.global(),
            _3490 = Script.global(), _3491 = Script.global(), _3492 = Script.global(), _3493 = Script.global(),
            _3485 = Script.global(), _3487 = Script.global(), _3468 = Script.global(), _3473 = Script.global(),
            _3501 = Script.global(), _3502 = Script.global(), _3494 = Script.global(), _3495 = Script.global(),
            _3499 = Script.global(), _3500 = Script.global(), _3503 = Script.global(), _3504 = Script.global(),
            _8555 = Script.global(), _8556 = Script.global(), _8557 = Script.global(), _8558 = Script.global(),
            _3486 = Script.global(), _3488 = Script.global(), _3478 = Script.global(), _3506 = Script.global(),
            _3479 = Script.global(), _3483 = Script.global(), _3480 = Script.global(), _3484 = Script.global(),
            _8554 = Script.global(), _3477 = Script.global(), _3481 = Script.global(), _3482 = Script.global(),
            _3505 = Script.global(), _3809 = Script.global(), _3810 = Script.global(), _8553 = Script.global(),
            _3496 = Script.global(), _3497 = Script.global(), _3498 = Script.global(), _8552 = Script.global(),
            ROULETE_Cash_Won = Script.global(), _8551 = Script.global(), _3489 = Script.global(),
            STAT_Gambling_Skill = Script.global(), ROULETE_Player_Cash = Script.global(), _1523 = Script.global(),
            _9441 = Script.global(), _9442 = Script.global(), _9449 = Script.global(), _8549 = Script.global(),
            _9337 = Script.global(), _9336 = Script.global(), _9437 = Script.global(), _9443 = Script.global(),
            _9439 = Script.global(), _9435 = Script.global(), _9335 = Script.global(), _9338 = Script.global(),
            _9447 = Script.global(), _9448 = Script.global(), _9446 = Script.global(), _9440 = Script.global(),
            _9436 = Script.global(), _9387 = Script.global(), _9450 = Script.global(), _9333 = Script.global(),
            _9334 = Script.global(), _9444 = Script.global(), _9445 = Script.global(), _9438 = Script.global(),
            _9201 = Script.global(), _9202 = Script.global(), _9203 = Script.global(), _9204 = Script.global(),
            _9324 = Script.global(), _9323 = Script.global(), BJACK_Player_cash = Script.global(),
            _9319 = Script.global(), _9320 = Script.global(), _9321 = Script.global(), _9322 = Script.global(),
            _9139 = Script.global(), _9316 = Script.global(), _9317 = Script.global(), _9318 = Script.global(),
            _9311 = Script.global(), _9312 = Script.global(), _9313 = Script.global(), _9137 = Script.global(),
            _9205 = Script.global(), _9219 = Script.global(), _9220 = Script.global(), _9221 = Script.global(),
            _9222 = Script.global(), _9223 = Script.global(), _9224 = Script.global(), _9225 = Script.global(),
            _9226 = Script.global(), _9227 = Script.global(), _9189 = Script.global(), _9314 = Script.global(),
            BJACK_Half_Bet = Script.global(), BJACK_Card_ID = Script.global(), BJACK_Payout = Script.global(),
            BJACK_last_bet = Script.global(), BJACK_Bet_Step = Script.global(), BJACK_Refund = Script.global(),
            BJACK_Cheat_Card_ID = Script.global(), BJACK_Dealer_total = Script.global(), _9217 = Script.global(),
            BJACK_Dealer_total2 = Script.global(), BJACK_Initial_Stake = Script.global(), _9218 = Script.global(),
            BJACK_Player_total1 = Script.global(), BJACK_Player_total2 = Script.global(), _9207 = Script.global(),
            BJACK_Player_got_ace1 = Script.global(), BJACK_Player_got_ace2 = Script.global(), _9307 = Script.global(),
            BJACK_Flag_Card_Cheat = Script.global(), BJACK_Dealer_got_ace = Script.global(), _9206 = Script.global(),
            BJACK_Player_has_won1 = Script.global(), BJACK_Player_has_won2 = Script.global(), _9325 = Script.global(),
            BJACK_Player_has_hit1 = Script.global(), BJACK_Player_has_quit = Script.global(), _9315 = Script.global(),
            BJACK_Player_total1_B = Script.global(), BJACK_Player_total2_B = Script.global(), _9195 = Script.global(),
            BJACK_Player_has_input = Script.global(), BJACK_Player_got_BJACK = Script.global(), _9308 = Script.global(),
            BJACK_Player_has_split = Script.global(), BJACK_Dealer_has_stuck = Script.global(), _9309 = Script.global(),
            BJACK_Player_has_stucked1 = Script.global(), BJACK_Player_has_stucked2 = Script.global(),
            BJACK_Player_has_doubled1 = Script.global(), BJACK_Player_has_doubled2 = Script.global(),
            BJACK_Player_cannot_double = Script.global(), BJACK_Player_cannot_Split = Script.global(),
            _3396 = Script.global(), _3400 = Script.global(), BJACK_Dealer_wins_by_default = Script.global(),
            Color_Red = Script.global(), Color_Green = Script.global(), Gambles_CashWin = Script.global(),
            _9065 = Script.global(), _9064 = Script.global(), _8930 = Script.global(), _8931 = Script.global(),
            _8845 = Script.global(), _8866 = Script.global(), _8906 = Script.global(), _9066 = Script.global(),
            _8846 = Script.global(), _8847 = Script.global(), _8848 = Script.global(), _8849 = Script.global(),
            _8850 = Script.global(), _8851 = Script.global(), _8852 = Script.global(), _8853 = Script.global(),
            _8854 = Script.global(), _8855 = Script.global(), _9069 = Script.global(), _9070 = Script.global(),
            _8842 = Script.global(), _8871 = Script.global(), _8869 = Script.global(), _8872 = Script.global(),
            _8903 = Script.global(), _8905 = Script.global(), _8844 = Script.global(), _8843 = Script.global(),
            _8826 = Script.global(), _8867 = Script.global(), _8870 = Script.global(), _8904 = Script.global(),
            POKER_Hold_Height = Script.global(), POKER_Tile_Type = Script.global(), POKER_Counter = Script.global(),
            High_Cards_Number = Script.global(), POKER_Card_Height = Script.global(), POKER_Deal_Height = Script.global(),
            AMMU_Selected_Weapon_Weapon_Group = Script.global(), _9539 = Script.global(), Max_Wager = Script.global(),
            AMMU_Selected_Weapon = Script.global(), AMMU_Weapon_Cost = Script.global(), _9578 = Script.global(),
            ONMISSION_Shooting = Script.global(), _2564 = Script.global(), _2565 = Script.global(),
            _2566 = Script.global(), _2567 = Script.global(), _2568 = Script.global(), _2569 = Script.global(),
            _2570 = Script.global(), _2571 = Script.global(), _2572 = Script.global(), _2573 = Script.global(),
            _2575 = Script.global(), _2576 = Script.global(), _9544 = Script.global(), _5274 = Script.global(),
            Ryder_Total_Passed_Missions = Script.global(), LS_FINAL_Total_Passed_Missions = Script.global(),
            OG_Loc_Total_Passed_Missions = Script.global(), Smoke_Total_Passed_Missions = Script.global(),
            Truth_Total_Passed_Missions = Script.global(), All_Catalina_missions_passed = Script.global(),
            Syndicate_Total_Passed_Missions = Script.global(), Wuzimu_Total_Passed_Missions = Script.global(),
            Casino_Total_Passed_Missions = Script.global(), Toreno_Total_Passed_Missions = Script.global(),
            AMMU_Seller = Script.global(), AMMU_Available_Weapons = Script.global(), _2574 = Script.global(),
            _9570 = Script.global(), AMMU_Selected_Weapon_Model = Script.global(), _9584 = Script.global(),
            _9585 = Script.global(), _9586 = Script.global(), _9587 = Script.global(), _9543 = Script.global(),
            _9575 = Script.global(), _9576 = Script.global(), _9577 = Script.global(), _9572 = Script.global(),
            _9573 = Script.global(), _9574 = Script.global(), _9595 = Script.global(), _9594 = Script.global(),
            _9596 = Script.global(), _9616 = Script.global(), _9597 = Script.global(), _9598 = Script.global(),
            _9599 = Script.global(), _9600 = Script.global(), _9601 = Script.global(), _9602 = Script.global(),
            _9603 = Script.global(), _9604 = Script.global(), _9605 = Script.global(), _9606 = Script.global(),
            _9607 = Script.global(), _9608 = Script.global(), _9609 = Script.global(), _9610 = Script.global(),
            _9611 = Script.global(), _9612 = Script.global(), _9613 = Script.global(), _9614 = Script.global(),
            _9615 = Script.global(), _9636 = Script.global(), _9637 = Script.global(), _9638 = Script.global(),
            flag_AMMU_Seller_Attack_Player = Script.global(), AMMU_Stage = Script.global(), _9571 = Script.global(),
            _9667 = Script.global(), Video_Game = Script.global(), Zero_Total_Passed_Missions = Script.global(),
            _9668 = Script.global(), _9665 = Script.global(), _9666 = Script.global(), _9646 = Script.global(),
            TATOO_Selected_Torso_Part = Script.global(), _9645 = Script.global(), _9651 = Script.global(),
            _9706 = Script.global(), _9707 = Script.global(), _9664 = Script.global(), _9642 = Script.global(),
            _9660 = Script.global(), _9657 = Script.global(), _9659 = Script.global(), _9658 = Script.global(),
            _9653 = Script.global(), _9654 = Script.global(), _9655 = Script.global(), _9656 = Script.global(),
            _9652 = Script.global(), _9650 = Script.global(), _9649 = Script.global(), _9705 = Script.global(),
            _9708 = Script.global(), _9709 = Script.global(), _9711 = Script.global(), _9721 = Script.global(),
            _9722 = Script.global(), _9724 = Script.global(), _9725 = Script.global(), _9639 = Script.global(),
            _9640 = Script.global(), _9641 = Script.global(), _9661 = Script.global(), _9662 = Script.global(),
            _9663 = Script.global(), _9726 = Script.global(), _9727 = Script.global(), _9728 = Script.global(),
            _9730 = Script.global(), _9733 = Script.global(), _9732 = Script.global(), _9735 = Script.global(),
            _9736 = Script.global(), _9798 = Script.global(), _9799 = Script.global(), _676 = Script.global(),
            _9794 = Script.global(), _9795 = Script.global(), _9796 = Script.global(), _9731 = Script.global(),
            _9737 = Script.global(), _9751 = Script.global(), _2749 = Script.global(), _9803 = Script.global(),
            _9752 = Script.global(), _9788 = Script.global(), _9789 = Script.global(), _9790 = Script.global(),
            _9791 = Script.global(), _9792 = Script.global(), _9793 = Script.global(), _9750 = Script.global(),
            _9734 = Script.global(), _9738 = Script.global(), _9739 = Script.global(), _9744 = Script.global(),
            _9745 = Script.global(), _9746 = Script.global(), _9747 = Script.global(), _9748 = Script.global(),
            _9749 = Script.global(), _9797 = Script.global(), _9800 = Script.global(), _9801 = Script.global(),
            _9802 = Script.global(), _9804 = Script.global(), _9805 = Script.global(), _9729 = Script.global(),
            _9765 = Script.global(), _9766 = Script.global(), _9767 = Script.global(), _9768 = Script.global(),
            _9769 = Script.global(), _9770 = Script.global(), _9771 = Script.global(), _9772 = Script.global(),
            _9773 = Script.global(), _9774 = Script.global(), _9775 = Script.global(), _9776 = Script.global(),
            _9777 = Script.global(), _9778 = Script.global(), _9779 = Script.global(), _9780 = Script.global(),
            _9781 = Script.global(), _9782 = Script.global(), _9783 = Script.global(), _9784 = Script.global(),
            _9785 = Script.global(), _9786 = Script.global(), _9787 = Script.global(), _9753 = Script.global(),
            _9761 = Script.global(), _9762 = Script.global(), _9763 = Script.global(), _9764 = Script.global(),
            Food_Seller = Script.global(), _9758 = Script.global(), _9759 = Script.global(), _9760 = Script.global(),
            _10038 = Script.global(), _10034 = Script.global(), _10048 = Script.global(), _2563 = Script.global(),
            JFUD_Player_Health = Script.global(), JFUD_STAT_Fat = Script.global(), _10042 = Script.global(),
            _10036 = Script.global(), Food_Seller_Exists = Script.global(), Total_Food_Eaten = Script.global(),
            _10035 = Script.global(), _10045 = Script.global(), _10047 = Script.global(), _10052 = Script.global(),
            _10049 = Script.global(), _10050 = Script.global(), _10051 = Script.global(), _10041 = Script.global(),
            _10079 = Script.global(), _10080 = Script.global(), _10056 = Script.global(), _10055 = Script.global(),
            _10064 = Script.global(), _10075 = Script.global(), _10076 = Script.global(), _10077 = Script.global(),
            JFUD_LOW_Food_Model = Script.global(), JFUD_MED_Food_Model = Script.global(), JFUD_Stage = Script.global(),
            JFUD_HIGH_Food_Model = Script.global(), JFUD_HEALTHY_Food_Model = Script.global(), _10078 = Script.global(),
            _9982 = Script.global(), Shops_Player_Cash = Script.global(), flag_Player_Attack_Food_Seller = Script.global(),
            _2755 = Script.global(), _2756 = Script.global(), _2757 = Script.global(), _2516 = Script.global(),
            Mansion_Total_Passed_Missions = Script.global(), _9981 = Script.global(), _10081 = Script.global(),
            _2424 = Script.global(), _2420 = Script.global(), _2419 = Script.global(), _2423 = Script.global(),
            _9986 = Script.global(), _9983 = Script.global(), _2544 = Script.global(), _2513 = Script.global(),
            _9991 = Script.global(), _9990 = Script.global(), _9988 = Script.global(), _9987 = Script.global(),
            _9999 = Script.global(), _9998 = Script.global(), _9993 = Script.global(), _9992 = Script.global(),
            _10006 = Script.global(), _10005 = Script.global(), _10004 = Script.global(), _10000 = Script.global(),
            _10010 = Script.global(), _10009 = Script.global(), _10008 = Script.global(), _10007 = Script.global(),
            _10018 = Script.global(), _10014 = Script.global(), _10013 = Script.global(), _10012 = Script.global(),
            _10022 = Script.global(), _10021 = Script.global(), _10020 = Script.global(), _10019 = Script.global(),
            _10026 = Script.global(), _10025 = Script.global(), _10024 = Script.global(), _10023 = Script.global(),
            _10011 = Script.global(), Seller_Model = Script.global(), _10027 = Script.global(), _2751 = Script.global(),
            _10031 = Script.global(), _10030 = Script.global(), _10029 = Script.global(), _10028 = Script.global(),
            _10017 = Script.global(), _10016 = Script.global(), _10015 = Script.global(), _9476 = Script.global(),
            _9477 = Script.global(), _9478 = Script.global(), _9475 = Script.global(), _9474 = Script.global(),
            _1042 = Script.global(), _1047 = Script.global(), _1046 = Script.global(), _1045 = Script.global(),
            _1048 = Script.global(), _1036 = Script.global(), _1037 = Script.global(), _1038 = Script.global(),
            _1039 = Script.global(), _1040 = Script.global(), _1041 = Script.global(), _9535 = Script.global(),
            _9530 = Script.global(), _9531 = Script.global(), _9532 = Script.global(), _9537 = Script.global(),
            _9533 = Script.global(), _9534 = Script.global(), _1043 = Script.global(), _1044 = Script.global(),
            _9528 = Script.global(), _9527 = Script.global(), _9529 = Script.global(), _5298 = Script.global(),
            _9538 = Script.global(), _5297 = Script.global(), DANCE_SCORE = Script.global(), _390 = Script.global(),
            Medic_Uniform_Available = Script.global(), Pimp_Suit_Available = Script.global(), _1231 = Script.global(),
            Gimp_Suit_Available = Script.global(), Valet_Uniform_Available = Script.global(), _2554 = Script.global(),
            Croupier_Uniform_Available = Script.global(), Racing_Suit_Available = Script.global(), _9536 = Script.global(),
            Cop_Uniform_Available = Script.global(), Rural_Clothes_Available = Script.global(), _5295 = Script.global(),
            ShoppingItem_BodyPart = Script.global(), _2517 = Script.global(), _2549 = Script.global(),
            _2550 = Script.global(), _2551 = Script.global(), _2552 = Script.global(), _2553 = Script.global(),
            Selected_Menu_Item = Script.global(), ShoppingItem_ModelCRC = Script.global(), _2543 = Script.global(),
            _10002 = Script.global(), _10003 = Script.global(), _9896 = Script.global(), _2542 = Script.global(),
            _2417 = Script.global(), _2421 = Script.global(), _9811 = Script.global(), _10001 = Script.global(),
            _9871 = Script.global(), _9966 = Script.global(), _9969 = Script.global(), _9974 = Script.global(),
            _9976 = Script.global(), _9978 = Script.global(), _9869 = Script.global(), _9895 = Script.global(),
            _9971 = Script.global(), _9972 = Script.global(), _9973 = Script.global(), _9975 = Script.global(),
            _9951 = Script.global(), _9952 = Script.global(), _9968 = Script.global(), _9970 = Script.global(),
            _9947 = Script.global(), _9948 = Script.global(), _9949 = Script.global(), _9950 = Script.global(),
            _2546 = Script.global(), _2547 = Script.global(), _9945 = Script.global(), _9946 = Script.global(),
            _9809 = Script.global(), _2418 = Script.global(), _2422 = Script.global(), _2545 = Script.global(),
            _9815 = Script.global(), _9813 = Script.global(), _9814 = Script.global(), _9810 = Script.global(),
            _9892 = Script.global(), _9893 = Script.global(), _9894 = Script.global(), _9808 = Script.global(),
            _9888 = Script.global(), _9889 = Script.global(), _9890 = Script.global(), _9891 = Script.global(),
            _9884 = Script.global(), _9885 = Script.global(), _9886 = Script.global(), _9887 = Script.global(),
            _9880 = Script.global(), _9881 = Script.global(), _9882 = Script.global(), _9883 = Script.global(),
            _9875 = Script.global(), _9876 = Script.global(), _9877 = Script.global(), _9879 = Script.global(),
            _2425 = Script.global(), _2514 = Script.global(), _2515 = Script.global(), _9878 = Script.global(),
            _9965 = Script.global(), _9872 = Script.global(), _9873 = Script.global(), _9874 = Script.global(),
            _9967 = Script.global(), _9868 = Script.global(), _9812 = Script.global(), _9870 = Script.global(),
            Show_Shop_Sphere = Script.global(), _9977 = Script.global(), _1260 = Script.global(),
            _2881 = Script.global(), _9473 = Script.global(), _9526 = Script.global(), _1258 = Script.global(),
            _9470 = Script.global(), _9471 = Script.global(), FOOD_Player_Aggressive_Flag = Script.global(),
            _1250 = Script.global(), _1251 = Script.global(), _1261 = Script.global(), _9472 = Script.global(),
            Player_Wanted_Level = Script.global(), PLAYER_IN_INTERIOR = Script.global(), _675 = Script.global(),
            FreeFall_Stage = Script.global(), Parachute_Creation_Stage = Script.global(), _1498 = Script.global(),
            _1511 = Script.global(), _1512 = Script.global(), _1902 = Script.global(), _8270 = Script.global(),
            Current_Time_in_ms2 = Script.global(), _416 = Script.global(), _709 = Script.global(),
            _1521 = Script.global(), GYM_GymBike_Power = Script.global(), GYM_GymBike_Level = Script.global(),
            GYM_GymBike_Distance = Script.global(), ONMISSION_GYMFIGHT = Script.global(), _685 = Script.global(),
            Current_Month_Day = Script.global(), Current_Month = Script.global(), _5285 = Script.global(),
            GYM_Month_Day_When_Limit_Reached = Script.global(), Current_Language = Script.global(), _88 = Script.global(),
            GYM_STAT_Fat = Script.global(), GYM_Month_When_Limit = Script.global(), _4 = Script.global(),
            _6 = Script.global(), _1813 = Script.global(), _1814 = Script.global(), _1829 = Script.global(),
            _1830 = Script.global(), _8712 = Script.global(), _8713 = Script.global(), _8714 = Script.global(),
            _8715 = Script.global(), _8716 = Script.global(), _8720 = Script.global(), _8721 = Script.global(),
            _8722 = Script.global(), _8723 = Script.global(), _8724 = Script.global(), _8725 = Script.global(),
            _8726 = Script.global(), _8727 = Script.global(), _8728 = Script.global(), _8729 = Script.global(),
            _8730 = Script.global(), _8731 = Script.global(), _8732 = Script.global(), _8733 = Script.global(),
            GYM_Bench_Weight = Script.global(), GYM_STAT_Bench_Heaviest_Weight = Script.global(), _684 = Script.global(),
            Pickup_Parachute = Script.global(), _1506 = Script.global(), _1507 = Script.global(),
            _1508 = Script.global(), _1509 = Script.global(), _8268 = Script.global(), _3401 = Script.global(),
            _3402 = Script.global(), _3403 = Script.global(), _3404 = Script.global(), _3405 = Script.global(),
            _3406 = Script.global(), _8734 = Script.global(), _8735 = Script.global(), _8747 = Script.global(),
            _8737 = Script.global(), _8743 = Script.global(), _8744 = Script.global(), _8741 = Script.global(),
            _1824 = Script.global(), _1825 = Script.global(), _1826 = Script.global(), _1827 = Script.global(),
            _8738 = Script.global(), GYM_Month_When_Limit_Reached = Script.global(), _8736 = Script.global(),
            _1817 = Script.global(), _1816 = Script.global(), _1818 = Script.global(), _1823 = Script.global(),
            _8762 = Script.global(), _8745 = Script.global(), _1819 = Script.global(), _8746 = Script.global(),
            _1820 = Script.global(), _1821 = Script.global(), _1822 = Script.global(), _8756 = Script.global(),
            _8757 = Script.global(), _8755 = Script.global(), _8750 = Script.global(), _8751 = Script.global(),
            _8752 = Script.global(), _8753 = Script.global(), _8754 = Script.global(), _1831 = Script.global(),
            _1832 = Script.global(), _1833 = Script.global(), _1834 = Script.global(), _1835 = Script.global(),
            _1836 = Script.global(), _1837 = Script.global(), _1838 = Script.global(), _1839 = Script.global(),
            _1840 = Script.global(), _8748 = Script.global(), _1815 = Script.global(), _1828 = Script.global(),
            _9 = Script.global(), _7 = Script.global(), _8758 = Script.global(), _672 = Script.global(),
            GYM_Dumbbells_Panel_Selected_Index = Script.global(), GYM_Dumbbells_Panel = Script.global(),
            GYM_Dumbbells_Weight = Script.global(), GYM_STAT_Dumbbells_Heaviest_Weight = Script.global(),
            _8763 = Script.global(), _8769 = Script.global(), _8779 = Script.global(), _8772 = Script.global(),
            _8773 = Script.global(), _8774 = Script.global(), _8775 = Script.global(), _8776 = Script.global(),
            _8777 = Script.global(), _8778 = Script.global(), _8768 = Script.global(), _8761 = Script.global(),
            _8765 = Script.global(), _8766 = Script.global(), _8767 = Script.global(), _8780 = Script.global(),
            _8781 = Script.global(), GYM_Day_Limit = Script.global(), Active_Interior = Script.global(),
            _8152 = Script.global(), _8153 = Script.global(), _8154 = Script.global(), _8155 = Script.global(),
            _8156 = Script.global(), _8157 = Script.global(), _8158 = Script.global(), _28 = Script.global(),
            Gyms_Accessible_Flag = Script.global(), _1348 = Script.global(), GymFight_Interior = Script.global(),
            _1016 = Script.global(), _1923 = Script.global(), _1924 = Script.global(), _1921 = Script.global(),
            _1928 = Script.global(), _1930 = Script.global(), _1922 = Script.global(), _1929 = Script.global(),
            _8787 = Script.global(), _8791 = Script.global(), _1926 = Script.global(), _1927 = Script.global(),
            Move_Axis_X = Script.global(), Move_Axis_Y = Script.global(), Special_Axis_X = Script.global(),
            Special_Axis_Y = Script.global(), _1925 = Script.global(), _8782 = Script.global(), _169 = Script.global(),
            _8786 = Script.global(), _1903 = Script.global(), _8784 = Script.global(), _8788 = Script.global(),
            _8789 = Script.global(), _8790 = Script.global(), _8785 = Script.global(), _8792 = Script.global(),
            _8793 = Script.global(), _8794 = Script.global(), _8795 = Script.global(), _8796 = Script.global(),
            _8797 = Script.global(), _8808 = Script.global(), _8809 = Script.global(), _8810 = Script.global(),
            _8811 = Script.global(), _8812 = Script.global(), _8800 = Script.global(), _8801 = Script.global(),
            _8802 = Script.global(), _8805 = Script.global(), _8806 = Script.global(), _8803 = Script.global(),
            _8804 = Script.global(), _8783 = Script.global(), _8799 = Script.global(), _8807 = Script.global(),
            _8813 = Script.global(), _8814 = Script.global(), _8815 = Script.global(), _8816 = Script.global(),
            _8817 = Script.global(), _8818 = Script.global(), _8819 = Script.global(), _8798 = Script.global(),
            _8820 = Script.global(), _8821 = Script.global(), _8822 = Script.global(), _8823 = Script.global(),
            _8824 = Script.global(), _8825 = Script.global(), flag_Player_In_Crane = Script.global(),
            _1911 = Script.global(), _2745 = Script.global(), _2746 = Script.global(), _2747 = Script.global(),
            _10490 = Script.global(), _10493 = Script.global(), _10487 = Script.global(), _10488 = Script.global(),
            _10489 = Script.global(), _10494 = Script.global(), _10495 = Script.global(), _2735 = Script.global(),
            _2737 = Script.global(), _2738 = Script.global(), _1912 = Script.global(), _1919 = Script.global(),
            _2733 = Script.global(), _2734 = Script.global(), _2736 = Script.global(), _1918 = Script.global(),
            _1913 = Script.global(), _1915 = Script.global(), _10491 = Script.global(), _10503 = Script.global(),
            _10504 = Script.global(), _10509 = Script.global(), _10510 = Script.global(), _10511 = Script.global(),
            _10515 = Script.global(), _10500 = Script.global(), _10505 = Script.global(), _10506 = Script.global(),
            _10507 = Script.global(), _10512 = Script.global(), _10501 = Script.global(), _10513 = Script.global(),
            _10514 = Script.global(), _10502 = Script.global(), _10508 = Script.global(), _10497 = Script.global(),
            _10498 = Script.global(), _10499 = Script.global(), _10492 = Script.global(), _9723 = Script.global();

        #endregion

        #region Float

        internal static Float
            _2352 = Script.global(), _2353 = Script.global(), _2354 = Script.global(),
            _2343 = Script.global(), _2373 = Script.global(), _2374 = Script.global(), _2375 = Script.global(),
            _2346 = Script.global(), _2347 = Script.global(), _2348 = Script.global(), _2349 = Script.global(),
            _2350 = Script.global(), _2351 = Script.global(), _2355 = Script.global(), _2356 = Script.global(),
            _2357 = Script.global(), X_STUNT_Mission_BMX = Script.global(), Y_STUNT_Mission_BMX = Script.global(),
            Z_STUNT_Mission_BMX = Script.global(), X_STUNT_Mission_NRG500 = Script.global(), _2345 = Script.global(),
            Y_STUNT_Mission_NRG500 = Script.global(), Z_STUNT_Mission_NRG500 = Script.global(), _2344 = Script.global(),
            _2367 = Script.global(), _2368 = Script.global(), _2369 = Script.global(), _2371 = Script.global(),
            _666 = Script.global(), _667 = Script.global(), _668 = Script.global(), _2370 = Script.global(),
            _1742 = Script.global(), _1743 = Script.global(), _1744 = Script.global(), _8260 = Script.global(),
            _1745 = Script.global(), _1746 = Script.global(), _1747 = Script.global(), _8258 = Script.global(),
            _1748 = Script.global(), _1749 = Script.global(), _1750 = Script.global(), _8259 = Script.global(),
            _596 = Script.global(), _528 = Script.global(), _8257 = Script.global(), _2372 = Script.global(),
            X_Driving_School = Script.global(), Y_Driving_School = Script.global(), Z_Driving_School = Script.global(),
            _425 = Script.global(), _426 = Script.global(), _427 = Script.global(), _529 = Script.global(),
            X_Pershing_Square_LS = Script.global(), BURGLARY_Noise_f = Script.global(), _530 = Script.global(),
            Y_Pershing_Square_LS = Script.global(), Z_Pershing_Square_LS = Script.global(), _531 = Script.global(),
            BJACK_Bet1 = Script.global(), _431 = Script.global(), _432 = Script.global(), _433 = Script.global(),
            BJACK_Card_Height = Script.global(), BJACK_Card_Width = Script.global(), BJACK_Bet2 = Script.global(),
            POKER_Card_Width = Script.global(), POKER_Hold_Width = Script.global(), POKER_Deal_Width = Script.global(),
            POKER_Tile_Height = Script.global(), POKER_Table_Width = Script.global(), POKER_Tile_Width = Script.global(),
            POKER_Hold_Button_Offset = Script.global(), POKER_Button_Text_Offset = Script.global(), _176 = Script.global(),
            POKER_Border_Thickness = Script.global(), POKER_Table_Height = Script.global(), POKER_X_Deal = Script.global(),
            POKER_Bet_One_Height = Script.global(), POKER_Bet_One_Width = Script.global(), POKER_Table_X = Script.global(),
            AMMU_X_Offset = Script.global(), AMMU_Y_Offset = Script.global(), AMMU_Z_Offset = Script.global(),
            AMMU_X_Aim_Camera = Script.global(), AMMU_Player_Angle = Script.global(), POKER_X_Bet_One = Script.global(),
            AMMU_Y_Aim_Camera = Script.global(), AMMU_Z_Aim_Camera = Script.global(), POKER_Y_Bet_One = Script.global(),
            AMMU_Seller_Animation_Time = Script.global(), AMMU_Seller_Angle = Script.global(), _9216 = Script.global(),
            AMMU_X_Seller = Script.global(), AMMU_Y_Seller = Script.global(), AMMU_Z_Seller = Script.global(),
            X_Camera = Script.global(), Y_Camera = Script.global(), Z_Camera = Script.global(),
            X_Buy_Marker = Script.global(), Y_Buy_Marker = Script.global(), Z_Buy_Marker = Script.global(),
            JFUD_X_Food_Seller = Script.global(), JFUD_Y_Food_Seller = Script.global(), POKER_Table_Y = Script.global(),
            JFUD_Z_Food_Seller = Script.global(), JFUD_Food_Seller_Angle = Script.global(),
            X_Start_Anim_Food = Script.global(), Y_Start_Anim_Food = Script.global(), Z_Start_Anim_Food = Script.global(),
            JFUD_X_Camera = Script.global(), JFUD_Y_Camera = Script.global(), JFUD_Z_Camera = Script.global(),
            JFUD_X_Aim_Camera = Script.global(), JFUD_Y_Aim_Camera = Script.global(), JFUD_Z_Aim_Camera = Script.global(),
            JFUD_X_Offset = Script.global(), JFUD_Y_Offset = Script.global(), JFUD_Z_Offset = Script.global(),
            _1500 = Script.global(), _1501 = Script.global(), _1503 = Script.global(), POKER_Y_Deal = Script.global(),
            _1504 = Script.global(), _1505 = Script.global(), tempvar_Float_1 = Script.global(),
            tempvar_Float_2 = Script.global(), tempvar_Float_3 = Script.global(), tempvar_Angle = Script.global(),
            Distance_Between_Points = Script.global(), tempvar_X_coord = Script.global(),
            tempvar_Y_coord = Script.global(), tempvar_Z_coord = Script.global(), BJACK_Border_Width = Script.global();
        #endregion

        #region Object
        internal static Object
            Crane_Magnet = Script.global(), _2722 = Script.global(), JFUD_Selected_Food = Script.global(),
            _1195 = Script.global(), _1196 = Script.global(), _1197 = Script.global(), _1198 = Script.global(),
            _1199 = Script.global(), _1200 = Script.global(), _1201 = Script.global(), _1202 = Script.global(),
            _2724 = Script.global(), _2725 = Script.global(), _2726 = Script.global(), _2727 = Script.global(),
            _2728 = Script.global(), _2730 = Script.global(), _2731 = Script.global(), _2732 = Script.global(),
            _2739 = Script.global(), _2740 = Script.global(), _2741 = Script.global(), _2742 = Script.global(),
            _2743 = Script.global(), _2744 = Script.global(), _2723 = Script.global(), _9989 = Script.global();
        #endregion

        #region vString
        internal static vString
            AMMU_Seller_Animation = Script.global(),
            _9994 = Script.global(), _9554 = Script.global(), _9558 = Script.global(), _9566 = Script.global(),
            DANCE_ANIM = Script.global(), _5303 = Script.global(), _5311 = Script.global(), _9754 = Script.global(),
            _9864 = Script.global(), Active_Interior_Name = Script.global(), DANCE_ANIM_IFP = Script.global(),

            // maybe array start
            _9669 = Script.global(),
            _9673 = Script.global(), _9677 = Script.global(), _9681 = Script.global(), _9685 = Script.global(),
            _9689 = Script.global(), _9693 = Script.global(), _9697 = Script.global(), _9701 = Script.global();
        // maybe array end
        #endregion

        #region sString
        internal static sString
            _8225 = Script.global(), Import_Model_Name = Script.global(),
            _10434 = Script.global(), _10432 = Script.global(), _8216 = Script.global(),
            AMMU_Weapon_Name = Script.global(), Actor_Speech_GXT_Reference = Script.global(),
            AMMU_Interior_Name = Script.global(), _9549 = Script.global(), _8218 = Script.global(),
            _9740 = Script.global(), _9742 = Script.global(), _9647 = Script.global(), _9643 = Script.global(),
            _9979 = Script.global(), _10043 = Script.global(), _10039 = Script.global(), _2752 = Script.global(),
            _9806 = Script.global(), _9984 = Script.global(), Current_Shop_GXT_Name = Script.global(),
            // maybe array start
            _2518 = Script.global(), _2520 = Script.global(), _2522 = Script.global(), _2524 = Script.global(),
            _2526 = Script.global(), _2528 = Script.global(), _2530 = Script.global(), _2532 = Script.global(),
            _2534 = Script.global(), _2536 = Script.global(), _2538 = Script.global(), _2540 = Script.global();
        // maybe array end
        #endregion

        #region Array<Float>

        internal static Array<Float>
            _10634 = Script.global_array( 4 ), _10650 = Script.global_array( 4 ),
            _10618 = Script.global_array( 4 ), _10666 = Script.global_array( 4 ), _10606 = Script.global_array( 4 ),
            _10610 = Script.global_array( 4 ), _10614 = Script.global_array( 4 ), _10622 = Script.global_array( 4 ),
            _10626 = Script.global_array( 4 ), _10630 = Script.global_array( 4 ), _10638 = Script.global_array( 4 ),
            _10642 = Script.global_array( 4 ), _10646 = Script.global_array( 4 ), _10654 = Script.global_array( 4 ),
            _10658 = Script.global_array( 4 ), _10662 = Script.global_array( 4 ), _10912 = Script.global_array( 4 ),
            _10916 = Script.global_array( 4 ), _10920 = Script.global_array( 4 ), _10924 = Script.global_array( 4 ),
            _10832 = Script.global_array( 4 ), _10836 = Script.global_array( 4 ), _10840 = Script.global_array( 4 ),
            _10896 = Script.global_array( 4 ), _10900 = Script.global_array( 4 ), _10904 = Script.global_array( 4 ),
            _10908 = Script.global_array( 4 ), _10884 = Script.global_array( 4 ), _10888 = Script.global_array( 4 ),
            _10892 = Script.global_array( 4 ), _10864 = Script.global_array( 4 ), _10880 = Script.global_array( 4 ),
            _10868 = Script.global_array( 4 ), _10872 = Script.global_array( 4 ), _10876 = Script.global_array( 4 ),
            _10808 = Script.global_array( 4 ), _10816 = Script.global_array( 4 ), _10860 = Script.global_array( 4 ),
            _10824 = Script.global_array( 4 ), _10812 = Script.global_array( 4 ), _10820 = Script.global_array( 4 ),
            _10828 = Script.global_array( 4 ), _10792 = Script.global_array( 4 ), _10800 = Script.global_array( 4 ),
            _10796 = Script.global_array( 4 ), _10804 = Script.global_array( 4 ), _10844 = Script.global_array( 4 ),
            _10848 = Script.global_array( 4 ), _10852 = Script.global_array( 4 ), _10856 = Script.global_array( 4 ),
            _10765 = Script.global_array( 3 ), _10777 = Script.global_array( 3 ), _10789 = Script.global_array( 3 ),
            _10756 = Script.global_array( 3 ), _10759 = Script.global_array( 3 ), _10762 = Script.global_array( 3 ),
            _10780 = Script.global_array( 3 ), _10783 = Script.global_array( 3 ), _10786 = Script.global_array( 3 ),
            _10768 = Script.global_array( 3 ), _10771 = Script.global_array( 3 ), _10774 = Script.global_array( 3 ),
            _8038 = Script.global_array( 8 ), _8046 = Script.global_array( 8 ), _8054 = Script.global_array( 3 ),
            Shooting_X = Script.global_array( 4 ), Shooting_Y = Script.global_array( 4 ), Shooting_Z = Script.global_array( 4 ),
            _6328 = Script.global_array( 10 ), X_Race_Tournament_Point = Script.global_array( 4 ),
            Y_Race_Tournament_Point = Script.global_array( 4 ), Z_Race_Tournament_Point = Script.global_array( 4 ),
            _6338 = Script.global_array( 10 ), _6348 = Script.global_array( 10 ), _6368 = Script.global_array( 10 ),
            _6318 = Script.global_array( 10 ), _6378 = Script.global_array( 10 ), _6388 = Script.global_array( 10 ),
            _6071 = Script.global_array( 10 ), _6081 = Script.global_array( 10 ), _6358 = Script.global_array( 10 ),
            _6091 = Script.global_array( 10 ), _6101 = Script.global_array( 10 ), _6111 = Script.global_array( 10 ),
            _6121 = Script.global_array( 10 ), _6131 = Script.global_array( 10 ), _6141 = Script.global_array( 10 ),
            _5925 = Script.global_array( 16 ), _5893 = Script.global_array( 16 ), _5973 = Script.global_array( 8 ),
            _5837 = Script.global_array( 16 ), _5821 = Script.global_array( 16 ), _5805 = Script.global_array( 16 ),
            _5707 = Script.global_array( 16 ), _5691 = Script.global_array( 16 ), _5675 = Script.global_array( 16 ),
            _5773 = Script.global_array( 16 ), _5757 = Script.global_array( 16 ), _5741 = Script.global_array( 16 ),
            _3413 = Script.global_array( 18 ), _3431 = Script.global_array( 18 ), _3449 = Script.global_array( 18 ),
            _3820 = Script.global_array( 6 ), _3879 = Script.global_array( 6 ), _3867 = Script.global_array( 6 ),
            _3507 = Script.global_array( 151 ), _3658 = Script.global_array( 151 ), _8398 = Script.global_array( 151 ),
            _9339 = Script.global_array( 6 ), _3926 = Script.global_array( 6 ), _5877 = Script.global_array( 16 ),
            _9345 = Script.global_array( 6 ), _9351 = Script.global_array( 6 ), _9357 = Script.global_array( 6 ),
            _9363 = Script.global_array( 6 ), _9369 = Script.global_array( 6 ), _9375 = Script.global_array( 6 ),
            _9381 = Script.global_array( 6 ), _9388 = Script.global_array( 6 ), _9394 = Script.global_array( 6 ),
            _9400 = Script.global_array( 6 ), _9406 = Script.global_array( 6 ), _9412 = Script.global_array( 6 ),
            _9418 = Script.global_array( 6 ), _9424 = Script.global_array( 6 ), _9430 = Script.global_array( 6 ),
            _9103 = Script.global_array( 8 ), _9111 = Script.global_array( 8 ), _9119 = Script.global_array( 8 ),
            BJACK_X_Screenpos = Script.global_array( 27 ), BJACK_Y_Screenpos = Script.global_array( 27 ),
            BJACK_X_Chip_offset = Script.global_array( 8 ), _9127 = Script.global_array( 8 ),
            BJACK_Y_Chip_offset = Script.global_array( 8 ), BJACK_Z_Chip_offset = Script.global_array( 8 ),
            BJACK_X_Player_Sprite = Script.global_array( 8 ), BJACK_Y_Player_Sprite = Script.global_array( 8 ),
            _9049 = Script.global_array( 5 ), _9054 = Script.global_array( 5 ), _9059 = Script.global_array( 5 ),
            POKER_Y_Row = Script.global_array( 10 ), POKER_X_Col = Script.global_array( 6 ), _9044 = Script.global_array( 5 ),
            POKER_X_Line = Script.global_array( 9 ), POKER_Y_Line = Script.global_array( 9 ),
            POKER_X_Card = Script.global_array( 5 ), POKER_Y_Card = Script.global_array( 5 ),
            POKER_Y_screen = Script.global_array( 8 ), POKER_X_screen = Script.global_array( 8 ),
            POKER_Line_Height = Script.global_array( 9 ), POKER_Line_Width = Script.global_array( 9 ),
            POKER_X_Text_Scale = Script.global_array( 6 ), POKER_Y_Text_Scale = Script.global_array( 6 );
        #endregion

        #region Array<Int>
        internal static Array<Int>
            _1140 = Script.global_array( 6 ),
            Import_Cars_Model = Script.global_array( 6 ), _1130 = Script.global_array( 10 ),
            Import_Car_Handles = Script.global_array( 5 ), Export_Cars_Status = Script.global_array( 10 ),
            Unlocked_Import_Cars = Script.global_array( 42 ), Car_Models_To_Export = Script.global_array( 10 ),
            _10725 = Script.global_array( 4 ), WantedCrossOFF_Objects = Script.global_array( 10 ),
            _10516 = Script.global_array( 8 ), _10525 = Script.global_array( 8 ), _10533 = Script.global_array( 8 ),
            _10541 = Script.global_array( 8 ), _10549 = Script.global_array( 8 ), _10716 = Script.global_array( 8 ),
            _1878 = Script.global_array( 3 ), _1874 = Script.global_array( 3 ), _1892 = Script.global_array( 3 ),
            STUNT_Missions_BestTime = Script.global_array( 2 ), _1887 = Script.global_array( 3 ),
            Quarry_Stage = Script.global_array( 8 ), _8174 = Script.global_array( 7 ),
            _201 = Script.global_array( 46 ), Flight_School_Records = Script.global_array( 10 ),
            _8035 = Script.global_array( 3 ), _8066 = Script.global_array( 3 ), _8077 = Script.global_array( 3 ),
            _8094 = Script.global_array( 3 ), _8097 = Script.global_array( 24 ), _8057 = Script.global_array( 8 ),
            _8086 = Script.global_array( 3 ), _8028 = Script.global_array( 3 ), _8025 = Script.global_array( 3 ),
            _8032 = Script.global_array( 3 ), _8121 = Script.global_array( 3 ), _8071 = Script.global_array( 3 ),
            _8089 = Script.global_array( 3 ), Races_Won = Script.global_array( 30 ), _1807 = Script.global_array( 5 ),
            Races_New_Best_Time = Script.global_array( 30 ), Races_Best_Result = Script.global_array( 30 ),
            _2152 = Script.global_array( 10 ), Races_Current_Best_Time = Script.global_array( 30 ),
            _5981 = Script.global_array( 8 ), _5965 = Script.global_array( 8 ), _2142 = Script.global_array( 10 ),
            _5860 = Script.global_array( 16 ), _5613 = Script.global_array( 16 ), _5629 = Script.global_array( 16 ),
            _5659 = Script.global_array( 16 ), _5789 = Script.global_array( 16 ), _5597 = Script.global_array( 16 ),
            _2072 = Script.global_array( 10 ), _2062 = Script.global_array( 10 ), _5725 = Script.global_array( 16 ),
            _5355 = Script.global_array( 10 ), _5426 = Script.global_array( 10 ), _5436 = Script.global_array( 10 ),
            _10351 = Script.global_array( 12 ), _10387 = Script.global_array( 12 ), _10375 = Script.global_array( 12 ),
            _10315 = Script.global_array( 12 ), _10327 = Script.global_array( 12 ), _10339 = Script.global_array( 12 ),
            _10279 = Script.global_array( 12 ), _10291 = Script.global_array( 12 ), _10303 = Script.global_array( 12 ),
            _10243 = Script.global_array( 12 ), _10255 = Script.global_array( 12 ), _10267 = Script.global_array( 12 ),
            _10207 = Script.global_array( 12 ), _10219 = Script.global_array( 12 ), _10231 = Script.global_array( 12 ),
            _10449 = Script.global_array( 16 ), _10465 = Script.global_array( 16 ), _10399 = Script.global_array( 12 ),
            _3889 = Script.global_array( 37 ), _3814 = Script.global_array( 3 ), _3873 = Script.global_array( 3 ),
            _3811 = Script.global_array( 3 ), _3830 = Script.global_array( 37 ), _10363 = Script.global_array( 12 ),
            _3870 = Script.global_array( 3 ), _3826 = Script.global_array( 2 ), _3885 = Script.global_array( 2 ),
            _3876 = Script.global_array( 3 ), _3828 = Script.global_array( 2 ), _3887 = Script.global_array( 2 ),
            _9327 = Script.global_array( 6 ), ROULETE_Chips = Script.global_array( 151 ), _3817 = Script.global_array( 3 ),
            _9087 = Script.global_array( 8 ), _9095 = Script.global_array( 8 ), _9208 = Script.global_array( 8 ),
            _9141 = Script.global_array( 8 ), _9149 = Script.global_array( 8 ), _9157 = Script.global_array( 8 ),
            POKER_Text_Edge = Script.global_array( 6 ), _8856 = Script.global_array( 5 ), _8861 = Script.global_array( 5 ),
            POKER_Text_Edge_R = Script.global_array( 6 ), POKER_Text_Font = Script.global_array( 6 ),
            POKER_Text_Edge_G = Script.global_array( 6 ), POKER_Text_Edge_B = Script.global_array( 6 ),
            POKER_Text_Color_R = Script.global_array( 6 ), POKER_Text_Color_G = Script.global_array( 6 ),
            POKER_Text_Color_B = Script.global_array( 6 ), POKER_Text_Centre = Script.global_array( 6 ),
            _9633 = Script.global_array( 3 ), _9617 = Script.global_array( 3 ), _9620 = Script.global_array( 3 ),
            _9623 = Script.global_array( 2 ), _9625 = Script.global_array( 1 ), _9626 = Script.global_array( 2 ),
            _9628 = Script.global_array( 2 ), _9630 = Script.global_array( 2 ), _9632 = Script.global_array( 1 ),
            _9712 = Script.global_array( 9 ), _8827 = Script.global_array( 5 ), _8837 = Script.global_array( 5 ),
            _2486 = Script.global_array( 12 ), _2438 = Script.global_array( 12 ),
            _2474 = Script.global_array( 12 ), _9953 = Script.global_array( 12 ), _2498 = Script.global_array( 12 ),
            _5315 = Script.global_array( 5 ), _5320 = Script.global_array( 5 ), _5325 = Script.global_array( 5 ),
            _5330 = Script.global_array( 5 ), _5335 = Script.global_array( 5 ), _5340 = Script.global_array( 5 ),
            _2426 = Script.global_array( 12 ), _8832 = Script.global_array( 5 );
        #endregion

        #region Array<vString>
        internal static Array<vString> _9816 = Script.global_array( 12 );
        #endregion

        #region Array<sString>
        internal static Array<sString>
            Import_Car_Names = Script.global_array( 6 ), Import_Days = Script.global_array( 7 ),
            Burglary_Garages = Script.global_array( 3 ), PLANES_DayNames = Script.global_array( 8 ),
            _2082 = Script.global_array( 10 ), _2102 = Script.global_array( 10 ), _2122 = Script.global_array( 10 ),
            _2002 = Script.global_array( 10 ), _2042 = Script.global_array( 10 ), _6236 = Script.global_array( 37 ),
            _2022 = Script.global_array( 10 ), SHTR_characters = Script.global_array( 37 ),
            _5506 = Script.global_array( 10 ), _5526 = Script.global_array( 10 ), _5546 = Script.global_array( 10 ),
            _5446 = Script.global_array( 10 ), _5466 = Script.global_array( 10 ), _5486 = Script.global_array( 10 ),
            _5365 = Script.global_array( 10 ), _5385 = Script.global_array( 10 ), _5405 = Script.global_array( 10 ),
            _9897 = Script.global_array( 12 ), _9921 = Script.global_array( 12 ), _2450 = Script.global_array( 12 );
        #endregion

        #region DecisionMaker
        internal static DecisionMaker Interior_Decision_Maker_A = Script.global(), Interior_Decision_Maker_B = Script.global();
        #endregion

        #endregion

        // ---------------------------------------------------------------------------------------------------------------------------

        private static List<Original> originalScripts = new List<Original>();
        private static OriginalSetup originalSetup = null;
        private static bool isInit = false;

        // ---------------------------------------------------------------------------------------------------------------------------

        public static void Begin( HandlerOriginalSetup setup ) {
            if( isInit )
                throw new Exception( Localization.PluginMustBeOnce( nameof( Original ) ) );
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( Original ) ) );
            if( Script.Current.ScriptName != "MAIN" )
                throw new Exception( Localization.PluginMustCreatedInMainTrhead( nameof( Original ) ) );
            if( setup == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( Original ), nameof( HandlerOriginalSetup ) ) );
            originalSetup = new OriginalSetup();
            setup.Invoke( originalSetup );
            for( int i = 0; i < OriginalSetup.OriginalScriptAccess.Count; i++ ) {
                if( OriginalSetup.OriginalScriptAccess[ i ].state )
                    originalScripts.Add( ( Original ) Activator.CreateInstance( OriginalSetup.OriginalScriptAccess[ i ].type, true ) );
            }
            if( originalScripts.Count == 0 )
                return;
            var stateOfAutoDefine = Generator.tmpUseAutomaticVariableInitialization;
            Generator.tmpOriginalDefineObjects = true;
            Generator.tmpUseAutomaticVariableInitialization = false;
            if( OriginalSetup.OriginalScriptAccess[ 12 ].state )
                OriginalSetup.OriginalScriptAccess[ 0 ].state = true;
            if( OriginalSetup.OriginalScriptAccess[ 13 ].state || OriginalSetup.OriginalScriptAccess[ 18 ].state )
                OriginalSetup.OriginalScriptAccess[ 6 ].state = true;
            isInit = true;
            Script.wait( 1000 );
            Script.start_mission<INITIAL>();
            Script.release_weather();
            Generator.tmpUseAutomaticVariableInitialization = stateOfAutoDefine;
            if( OriginalSetup.action != null )
                OriginalSetup.action.Invoke();
            Generator.tmpUseAutomaticVariableInitialization = false;
            Script.Jump += UPDATE;
            Generator.tmpUseAutomaticVariableInitialization = stateOfAutoDefine;
        }

        private static void UPDATE( LabelJump label ) {
            Script.wait( 0 );
            Script.and( UPDATE, Script.PlayerChar.is_defined() );
            Script.get_active_interior( Active_Interior );
            Script.get_int_stat( 181, STAT_Unlocked_Cities_Number );
            Script.get_weekday( Weekday );
            Script.get_current_language( Current_Language );
            Script.PlayerChar.get_town_number( Current_Town_Number );

            foreach( var original in originalScripts ) {
                Script.Comment = $"ORIGINAL '{original.demoName}'";
                original.Update();
            }
            Script.jump( UPDATE );
            Script.AppendLine( @"
:LITCAS_268
0169: set_fade_color_RGB 0 0 0 
fade 0 500 

:LITCAS_283
if 
fading 
else_jump @LITCAS_307 
wait 0 
jump @LITCAS_283 

:LITCAS_307
0051: return" );
            Script.AppendLine( @"
:PSAVE1_4206
if 
   Player.Defined(" + Script.PlayerChar + @")
else_jump @PSAVE1_4315 
Player.CanMove(" + Script.PlayerChar + @") = False
02A3: enable_widescreen 1 
Camera.SetPosition(427.1954, 2527.643, 19.4052, 0.0, 0.0, 0.0)
Camera.PointAt(426.2472, 2527.956, 19.4635, 2)
0395: clear_area 1 at 426.2472 2527.956 19.4635 radius 2.0 
gosub @PSAVE1_1221 

:PSAVE1_4315
return

:PSAVE1_1221
0169: set_fade_color_RGB 0 0 0 
fade 0 500 

:PSAVE1_1236
if 
fading 
else_jump @PSAVE1_1264 
wait 0 
00BE: text_clear_all 
03E6: remove_text_box 
jump @PSAVE1_1236 

:PSAVE1_1264
if 
   Player.Defined(" + Script.PlayerChar + @")
else_jump @PSAVE1_1299 
fade 0 0 
Camera.Restore_WithJumpCut
0687: clear_actor " + Script.PlayerActor + @" task 
fade 0 0 

:PSAVE1_1299
return" );
        }

        internal static void print_gosub_LITCAS_268() { Script.AppendLine( "0050: gosub @LITCAS_268" ); }
        internal static void print_gosub_PSAVE1_4206() { Script.AppendLine( "0050: gosub @PSAVE1_4206" ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        private string demoName;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Original() { demoName = GetType().Name.Replace( "Original", "" ).ToUpper(); }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal abstract void Start();
        internal abstract void Update();

        // ---------------------------------------------------------------------------------------------------------------------------

        private class INITIAL : MissionCustom {

            public override void START( LabelJump label ) {
                OnMission.value = true;
                Mansion_Total_Passed_Missions.value = 4;
                Zero_Total_Passed_Missions.value = 3;
                Casino_Total_Passed_Missions.value = 9;
                Toreno_Total_Passed_Missions.value = 9;
                Syndicate_Total_Passed_Missions.value = 10;
                Wuzimu_Total_Passed_Missions.value = 5;
                Truth_Total_Passed_Missions.value = 2;
                All_Catalina_missions_passed.value = 1;
                OG_Loc_Total_Passed_Missions.value = 5;
                Smoke_Total_Passed_Missions.value = 4;
                Ryder_Total_Passed_Missions.value = 3;
                LS_FINAL_Total_Passed_Missions.value = 2;
                Mission_Cesar_Vialpando_Passed.value = 1;
                Garage_Total_Passed_Missions.value = 2;

                if( OriginalSetup.OriginalScriptAccess[ 8 ].state ) {
                    if( !OriginalSetup.OriginalScriptAccess[ 10 ].state ) {
                        Medic_Uniform_Available.value = 1;
                        Cop_Uniform_Available.value = 1;
                        Pimp_Suit_Available.value = 1;
                    }
                    if( !OriginalSetup.OriginalScriptAccess[ 11 ].state ) {
                        Racing_Suit_Available.value = 1;
                    }
                }

                Garage.change_type( "BODLAWN", 38 );
                Garage.change_type( "MODLAST", 36 );
                Garage.change_type( "MDSSFSE", 38 );
                Garage.change_type( "MDS1SFS", 37 );
                Garage.change_type( "VECMOD", 38 );

                Garage.change_type( "HBGDSFS", 19 );
                Garage.change_type( "GHOSTDR", 19 );

                set_visibility_of_closest_object( -2166.86, -236.5, 40.86, 40.0, 11012, 0 );
                set_visibility_of_closest_object( -2166.86, -236.5, 40.86, 40.0, 11088, 1 );
                set_visibility_of_closest_object( -2185.49, -215.55, 34.31, 40.0, 11270, 0 );
                set_visibility_of_closest_object( -2185.49, -215.55, 34.31, 40.0, 11282, 1 );

                Array<Object> obj = global_array( 38 );
                obj[ 0 ].init( 3084, 1903.383, 967.62, 11.438 ).set_z_angle( 0.0 ).remove_from_mission_cleanup_list();
                obj[ 1 ].init( 3059, 2522.008, -1272.93, 35.609 ).set_destructible( false ).keep_in_memory( true ).remove_from_mission_cleanup_list();
                obj[ 2 ].init( 3083, 2167.82, -1518.193, 20.237 ).set_z_angle( 0.0 ).remove_from_mission_cleanup_list();
                obj[ 3 ].init( 2947, 2322.845, 8.304, 25.483 ).set_destructible( false ).keep_in_memory( true );
                obj[ 4 ].init( 2947, 2316.233, 0.712, 25.742 ).set_z_angle( 270.0 ).set_destructible( false ).keep_in_memory( true );
                obj[ 5 ].init( 2946, 2304.257, -17.744, 25.742 ).set_destructible( false ).keep_in_memory( true );
                obj[ 6 ].init( 2946, 2304.257, -14.583, 25.742 ).set_z_angle( 180.0 ).set_destructible( false ).keep_in_memory( true );
                obj[ 7 ].init( 2938, 1055.629, 2087.67, 12.469 ).remove_from_mission_cleanup_list();
                obj[ 8 ].create( 3029, 2352.851, -1171.027, 26.9669 ).set_z_angle( 90.0 ).make_moveable( false ).set_destructible( false ).set_immunities( 1 ).remove_from_mission_cleanup_list();
                obj[ 9 ].init( 3036, -2179.353, 661.232, 50.214 ).set_destructible( false ).remove_from_mission_cleanup_list();
                obj[ 10 ].init( 2927, 215.941, 1874.571, 13.903 ).set_z_angle( 0.0 ).remove_from_mission_cleanup_list();
                obj[ 11 ].init( 2929, 211.842, 1874.571, 13.903 ).set_z_angle( 0.0 ).remove_from_mission_cleanup_list();
                obj[ 12 ].init( 2951, 297.766, 1842.618, 6.764 ).remove_from_mission_cleanup_list();
                obj[ 13 ].create( 3095, 268.664, 1884.06, 15.925 ).rotate( 90.0, 90.0, 0 ).remove_from_mission_cleanup_list();
                obj[ 14 ].create( 2944, -2468.141, 1547.938, 22.7 ).remove_from_mission_cleanup_list();
                obj[ 15 ].init( 3089, 2168.644, 1619.43, 1000.3 ).link_to_interior( 1 ).set_z_angle( 270.0 ).remove_from_mission_cleanup_list();
                obj[ 16 ].create( 3061, 1833.36, -1995.45, 12.5 ).set_z_angle( 90.0 ).remove_from_mission_cleanup_list();
                obj[ 17 ].create( 3061, 1819.81, -1994.66, 12.5 ).remove_from_mission_cleanup_list();
                obj[ 18 ].create( 3061, 1827.68, -1980.0, 12.5 ).set_z_angle( 270.0 ).remove_from_mission_cleanup_list();
                obj[ 19 ].create( 3061, 1851.84, -1990.67, 12.5 ).remove_from_mission_cleanup_list();
                obj[ 20 ].create( 3061, 1867.29, -1984.96, 12.5 ).set_z_angle( 270.0 ).remove_from_mission_cleanup_list();
                obj[ 21 ].create( 3061, 1866.52, -1998.53, 12.5 ).set_z_angle( 90.0 ).remove_from_mission_cleanup_list();
                obj[ 22 ].create( 3061, 1899.75, -1984.95, 12.5 ).set_z_angle( 270.0 ).remove_from_mission_cleanup_list();
                obj[ 23 ].create( 3061, 1914.39, -1992.82, 12.5 ).set_z_angle( 180.0 ).remove_from_mission_cleanup_list();
                obj[ 24 ].create( 3061, 1899.01, -1998.5, 12.5 ).set_z_angle( 90.0 ).remove_from_mission_cleanup_list();
                obj[ 25 ].create( 3061, 1900.89, -2020.11, 12.5 ).remove_from_mission_cleanup_list();
                obj[ 26 ].create( 3061, 1914.4, -2020.91, 12.5 ).set_z_angle( 180.0 ).remove_from_mission_cleanup_list();
                obj[ 27 ].create( 3061, 1906.54, -2035.52, 12.5 ).set_z_angle( 90.0 ).remove_from_mission_cleanup_list();
                obj[ 28 ].create( 3061, 1851.86, -2020.14, 12.5 ).remove_from_mission_cleanup_list();
                obj[ 29 ].create( 3061, 1865.42, -2020.89, 12.5 ).set_z_angle( 180.0 ).remove_from_mission_cleanup_list();
                obj[ 30 ].create( 3061, 1857.55, -2035.52, 12.5 ).set_z_angle( 90.0 ).remove_from_mission_cleanup_list();
                obj[ 31 ].init( 1498, 2401.75, -1714.477, 13.125 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );
                obj[ 32 ].init( 1505, -2574.495, 1153.023, 54.669 ).set_z_angle( -19.444 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );
                obj[ 33 ].init( 1496, -1800.706, 1201.041, 24.12 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );
                obj[ 34 ].init( 1501, -383.46, -1439.64, 25.33 ).set_z_angle( 90.0 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );
                obj[ 35 ].init( 1522, -1390.79, 2639.33, 54.973 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );
                obj[ 36 ].init( 1498, 2038.036, 2721.37, 10.53 ).set_z_angle( -180.0 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );
                obj[ 37 ].init( 3093, -371.4, -1429.42, 26.47 ).remove_from_mission_cleanup_list().set_destructible( false ).set_immunities( 1 );

                Float[] SPRAY_X = new Float[] { 2067.4, 488.0, 720.016, -1420.547, 1966.532, -2425.46, 1021.8, -1908.9, -103.6 };
                Float[] SPRAY_Y = new Float[] { -1831.2, -1734.0, -454.625, 2583.945, 2162.65, 1020.83, -1018.7, 292.3, 1112.4 };
                Float[] SPRAY_Z = new Float[] { 13.5, 34.4, 15.328, 58.031, 10.995, 49.39, 30.9, 40.0, 18.7 };
                Array<RadarMarker> sprayMarkers = global_array( ( ushort ) SPRAY_X.Length );
                for( ushort i = 0; i < SPRAY_X.Length; i++ )
                    sprayMarkers[ i ].create_short_range_for_mission( RadarIconID.PAY_N_SPRAY, SPRAY_X[ i ], SPRAY_Y[ i ], SPRAY_Z[ i ] ).set_radar_mode( 2 );

                AppendLine( @"07FB: set_interior 'FDREST1' access 0
07FB: set_interior 'REST2' access 0
07FB: set_interior 'DINER1' access 0
07FB: set_interior 'DINER2' access 0
07FB: set_interior 'TSDINER' access 0
07FB: set_interior 'PAPER' access 0
07FB: set_interior 'PDOMES' access 0
07FB: set_interior 'PDOMES2' access 0
07FB: set_interior 'JUMP1' access 0
07FB: set_interior 'JUMP2' access 0
07FB: set_interior 'DAMIN' access 0
07FB: set_interior 'DAMOUT' access 0
07FB: set_interior 'ABATOIR' access 0
07FB: set_interior 'MOTEL1' access 0
07FB: set_interior 'MOTEL2' access 0
07FB: set_interior 'BURHOUS' access 0
07FB: set_interior 'GANG' access 0
07FB: set_interior 'LACRAK' access 0
07FB: set_interior 'ATRIUME' access 0
07FB: set_interior 'ATRIUMX' access 0
07FB: set_interior 'GF1' access 0
07FB: set_interior 'GF2' access 0
07FB: set_interior 'GF3' access 0
07FB: set_interior 'GF4' access 0
07FB: set_interior 'GF5' access 0
07FB: set_interior 'GF6' access 0" );

                if( OriginalSetup.OriginalScriptAccess[ 7 ].state || OriginalSetup.OriginalScriptAccess[ 8 ].state ) {
                    Ignore = delegate {
                        create_thread<BDISPLY>();
                    };
                    Video_Game.value = -1;
                }

                foreach( var original in originalScripts ) {
                    Comment = $"ORIGINAL '{original.demoName}'";
                    original.Start();
                }
                if( !OriginalSetup.OriginalScriptAccess[ 4 ].state ) {
                    set_interior_access( "GYM1", 0 ); // ‚Є®¦o®ckњќ cЈop¦џaћ
                    set_interior_access( "GYM2", 0 ); // CЈop¦џaћ —oeўЁx њcckyc¦ў
                    set_interior_access( "GYM3", 0 ); // CЈop¦џaћ kњk—okcњ®™a
                }
                if( !OriginalSetup.OriginalScriptAccess[ 8 ].state ) {

                    set_interior_access( "CSCHP", 0 );
                    set_interior_access( "CSSPRT", 0 );
                    set_interior_access( "LACS1", 0 );
                    set_interior_access( "CLOTHGP", 0 );
                    set_interior_access( "CSDESGN", 0 );
                    set_interior_access( "CSEXL", 0 );

                    set_interior_access( "BARBERS", 0 );
                    set_interior_access( "BARBER2", 0 );
                    set_interior_access( "BARBER3", 0 );

                    set_interior_access( "FDPIZA", 0 );
                    set_interior_access( "FDCHICK", 0 );
                    set_interior_access( "FDBURG", 0 );

                    set_interior_access( "TATTOO", 0 );
                    set_interior_access( "TATTO2", 0 );
                    set_interior_access( "TATTO3", 0 );

                    set_interior_access( "AMMUN1", 0 );
                    set_interior_access( "AMMUN2", 0 );
                    set_interior_access( "AMMUN3", 0 );
                    set_interior_access( "AMMUN4", 0 );
                    set_interior_access( "AMMUN5", 0 );

                    set_interior_access( "RCPLAY", 0 );

                    set_interior_access( "CHANGER", 0 );

                    set_interior_access( "TRICAS", 0 );
                    set_interior_access( "MAFCAS", 0 );
                    set_interior_access( "CASINO2", 0 );

                    set_interior_access( "BAR1", 0 );
                    set_interior_access( "BAR2", 0 );
                    set_interior_access( "UFOBAR", 0 );

                    set_interior_access( "GENOTB", 0 );

                    set_interior_access( "LASTRIP", 0 );
                    set_interior_access( "STRIP2", 0 );

                }
                if( !OriginalSetup.OriginalScriptAccess[ 9 ].state ) {
                    Garage.deactivate( "BODLAWN" );
                    Garage.deactivate( "MODLAST" );
                    Garage.deactivate( "MDSSFSE" );
                    Garage.deactivate( "MDS1SFS" );
                    Garage.deactivate( "VECMOD" );
                }
                if( OriginalSetup.openAllMapZones ) {
                    Comment = $"ORIGINAL 'OpenAllMapZones'";
                    AppendLine( $"for 0@ = 354164 to 354188\r\n    &0(0@,1i) = 16843009\r\nend" );
                }
                if( OriginalSetup.disableCheats ) {
                    Comment = $"ORIGINAL 'DisableCheats'";
                    AppendLine( $"0A8C: write_memory 0x0053BFB8 size 4 value 0x90909090 virtual_protect 1\r\n0A8C: write_memory 0x0053BFBC size 1 value 0x90 virtual_protect 1" );

                }
                if( OriginalSetup.enableDefaultAcquaintance ) {
                    AppendLine( @"0746: set_acquaintance 1 of_actors_pedtype 8 to_actors_pedtype 0 
0746: set_acquaintance 4 of_actors_pedtype 8 to_actors_pedtype 7 
0746: set_acquaintance 3 of_actors_pedtype 8 to_actors_pedtype 9 
0746: set_acquaintance 3 of_actors_pedtype 8 to_actors_pedtype 14 
0746: set_acquaintance 4 of_actors_pedtype 7 to_actors_pedtype 0 
0746: set_acquaintance 4 of_actors_pedtype 7 to_actors_pedtype 8 
0746: set_acquaintance 3 of_actors_pedtype 7 to_actors_pedtype 9 
0746: set_acquaintance 3 of_actors_pedtype 7 to_actors_pedtype 14 
0746: set_acquaintance 3 of_actors_pedtype 9 to_actors_pedtype 0 
0746: set_acquaintance 3 of_actors_pedtype 9 to_actors_pedtype 8 
0746: set_acquaintance 3 of_actors_pedtype 9 to_actors_pedtype 7 
0746: set_acquaintance 4 of_actors_pedtype 9 to_actors_pedtype 14 
0746: set_acquaintance 1 of_actors_pedtype 14 to_actors_pedtype 0 
0746: set_acquaintance 3 of_actors_pedtype 14 to_actors_pedtype 8 
0746: set_acquaintance 3 of_actors_pedtype 14 to_actors_pedtype 7 
0746: set_acquaintance 4 of_actors_pedtype 14 to_actors_pedtype 9 
0746: set_acquaintance 3 of_actors_pedtype 10 to_actors_pedtype 11 
0746: set_acquaintance 3 of_actors_pedtype 10 to_actors_pedtype 13 
0746: set_acquaintance 3 of_actors_pedtype 11 to_actors_pedtype 10 
0746: set_acquaintance 3 of_actors_pedtype 13 to_actors_pedtype 10 
0746: set_acquaintance 4 of_actors_pedtype 13 to_actors_pedtype 11 
0746: set_acquaintance 4 of_actors_pedtype 11 to_actors_pedtype 13 " );
                }
                if( OriginalSetup.enableDefaultZones ) {
                    Comment = $"ORIGINAL 'EnableDefaultZoneTypes'";
                    AppendLine( @"08CA: reset_zones_info 
0767: set_zone 'MARKST' popcycle_group_for_peds_and_cars_to 14  
0767: set_zone 'UNITY' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'LAIR1' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'LAIR2A' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'LAIR2B' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'LBAG1' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'LBAG2' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'LBAG3' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'BLUF1A' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'BLUF2' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'SUN1' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'SUN1' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'SUN3A' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'SUN3B' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'SUN3C' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'SUN4' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'COM1A' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'COM1B' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'COM2' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'COM3' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'COM4' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'PER1' popcycle_group_for_peds_and_cars_to 9  
0767: set_zone 'CHC1A' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'CHC1B' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'CHC2A' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'CHC2B' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'CHC3' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'CHC4A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'CHC4B' popcycle_group_for_peds_and_cars_to 7 
0874: set_zone 'CHC1A' popcycle_group_for_peds_to 9 
0874: set_zone 'CHC1B' popcycle_group_for_peds_to 9 
0874: set_zone 'CHC2A' popcycle_group_for_peds_to 9 
0874: set_zone 'CHC2B' popcycle_group_for_peds_to 9 
0874: set_zone 'CHC3' popcycle_group_for_peds_to 9 
0874: set_zone 'CHC4A' popcycle_group_for_peds_to 9 
0874: set_zone 'CHC4B' popcycle_group_for_peds_to 9 
0767: set_zone 'CONF1A' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'CONF1B' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'THALL1' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDOC1A' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDOC1B' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDOC2' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDOC3A' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDOC3B' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDOC3C' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDOC4' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LDT1A' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDT1B' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDT1C' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDT3' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDT4' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'LDT5' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDT6' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'LDT7' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'EBE1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'EBE2A' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'EBE2B' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'EBE3C' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'ELCO1' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'ELCO2' popcycle_group_for_peds_and_cars_to 7 
0874: set_zone 'ELCO1' popcycle_group_for_peds_to 9 
0874: set_zone 'ELCO2' popcycle_group_for_peds_to 9 
0767: set_zone 'GAN1' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'GAN2' popcycle_group_for_peds_and_cars_to 7 
0874: set_zone 'GAN1' popcycle_group_for_peds_to 1 
0874: set_zone 'GAN2' popcycle_group_for_peds_to 1 
09B7: set_zone 'GAN1' disable_footcops 1 
0767: set_zone 'GLN1' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'GLN2A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'LIND1A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'LIND1B' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LIND2A' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LIND2B' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LIND3' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'IWD1' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'IWD2' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'IWD3A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'IWD3B' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'IWD4' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'IWD5' popcycle_group_for_peds_and_cars_to 7 
0874: set_zone 'IWD1' popcycle_group_for_peds_to 1 
0874: set_zone 'IWD2' popcycle_group_for_peds_to 1 
0874: set_zone 'IWD3A' popcycle_group_for_peds_to 1 
0874: set_zone 'IWD3B' popcycle_group_for_peds_to 1 
0874: set_zone 'IWD4' popcycle_group_for_peds_to 1 
0874: set_zone 'IWD5' popcycle_group_for_peds_to 1 
0767: set_zone 'JEF1A' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JEF1B' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JEF2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JEF3A' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JEF3B' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JEF3C' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'LFL1A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'LFL1B' popcycle_group_for_peds_and_cars_to 7 
0874: set_zone 'LFL1A' popcycle_group_for_peds_to 9 
0874: set_zone 'LFL1B' popcycle_group_for_peds_to 9 
0767: set_zone 'LMEX1A' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'LMEX1B' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'ELS1A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'ELS1B' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'ELS2' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'ELS3A' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'ELS3B' popcycle_group_for_peds_and_cars_to 7 
0767: set_zone 'ELS4' popcycle_group_for_peds_and_cars_to 7 
0874: set_zone 'ELS1A' popcycle_group_for_peds_to 10 
0874: set_zone 'ELS1B' popcycle_group_for_peds_to 10 
0874: set_zone 'ELS2' popcycle_group_for_peds_to 10 
0874: set_zone 'ELS3A' popcycle_group_for_peds_to 10 
0874: set_zone 'ELS3B' popcycle_group_for_peds_to 10 
0874: set_zone 'ELS4' popcycle_group_for_peds_to 10 
0767: set_zone 'MAR1' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'MAR2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'MAR3' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'MKT1' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'MKT2' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'MKT3' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'MKT4' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'MUL1A' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL1B' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL1C' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL2A' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'MUL2B' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'MUL3' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'MUL4' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL5A' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL5B' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL5C' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL6' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL7A' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'MUL7B' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'PLS' popcycle_group_for_peds_and_cars_to 8  
0767: set_zone 'RIH1A' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'RIH1B' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'RIH2' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'RIH3A' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'RIH3B' popcycle_group_for_peds_and_cars_to 15 
0767: set_zone 'RIH4' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'RIH5A' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'RIH6B' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'RIH5A' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'RIH6B' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'ROD1A' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD1B' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD1C' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD2A' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD2B' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD3A' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD3B' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD4A' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD4B' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD4C' popcycle_group_for_peds_and_cars_to 14 
0767: set_zone 'ROD5A' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'ROD5B' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'SMB1' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'SMB2' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'VIN2' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'VIN3' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'VIN1A' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'VIN1B' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'VERO1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'VERO2' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'VERO3' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'VERO4A' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'VERO4B' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'CRANB' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'CALT' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'SUNMA' popcycle_group_for_peds_and_cars_to 4  
0767: set_zone 'SUNNN' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'BATTP' popcycle_group_for_peds_and_cars_to 2  
0767: set_zone 'ESPN1' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'ESPN2' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'ESPN3' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'BAYV' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'PARA' popcycle_group_for_peds_and_cars_to 4  
0767: set_zone 'JUNIHO' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'JUNIHI' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'CIVI' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'CHINA' popcycle_group_for_peds_and_cars_to 9  
0874: set_zone 'CHINA' popcycle_group_for_peds_to 6  
0767: set_zone 'SFDWT1' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SFDWT2' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SFDWT3' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SFDWT4' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'SFDWT5' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'SFDWT6' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'FINA' popcycle_group_for_peds_and_cars_to 0  
0767: set_zone 'CITYS' popcycle_group_for_peds_and_cars_to 0  
0767: set_zone 'WESTP1' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'WESTP2' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'WESTP3' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'THEA1' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'THEA2' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'THEA3' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'GARC' popcycle_group_for_peds_and_cars_to 7  
0767: set_zone 'HASH' popcycle_group_for_peds_and_cars_to 6  
0767: set_zone 'OCEAF1' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'OCEAF2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'OCEAF3' popcycle_group_for_peds_and_cars_to 8 
0767: set_zone 'DOH1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'DOH2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'CUNTC1' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'CUNTC2' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'CUNTC3' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'SFGLF1' popcycle_group_for_peds_and_cars_to 17 
0767: set_zone 'SFGLF2' popcycle_group_for_peds_and_cars_to 17 
0767: set_zone 'SFGLF3' popcycle_group_for_peds_and_cars_to 17 
0767: set_zone 'SFGLF4' popcycle_group_for_peds_and_cars_to 17 
0767: set_zone 'HILLP' popcycle_group_for_peds_and_cars_to 10  
0767: set_zone 'SILLY1' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SILLY2' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SILLY3' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SILLY4' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'SFAIR1' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'SFAIR2' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'SFAIR3' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'SFAIR4' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'SFAIR5' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'SFBAG1' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'SFBAG2' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'SFBAG3' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'EASB1' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'EASB2' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'ESPE1' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'ESPE2' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'ESPE3' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'LINDEN' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'YELLOW' popcycle_group_for_peds_and_cars_to 4  
0767: set_zone 'BFC1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'BFC2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'RIE' popcycle_group_for_peds_and_cars_to 0  
0767: set_zone 'LDM' popcycle_group_for_peds_and_cars_to 6  
0767: set_zone 'RSW1' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'RSW2' popcycle_group_for_peds_and_cars_to 6 
0767: set_zone 'RSE' popcycle_group_for_peds_and_cars_to 6  
0767: set_zone 'LDS' popcycle_group_for_peds_and_cars_to 11  
0767: set_zone 'SRY' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'JTS1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTS2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'LVA1' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LVA2' popcycle_group_for_peds_and_cars_to 18 
0767: set_zone 'LVA3' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'LVA4' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'VAIR1' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'VAIR2' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'VAIR3' popcycle_group_for_peds_and_cars_to 16 
0767: set_zone 'LVBAG' popcycle_group_for_peds_and_cars_to 19 
0767: set_zone 'GGC1' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'GGC2' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'BFLD1' popcycle_group_for_peds_and_cars_to 10 
0767: set_zone 'BFLD2' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'WWE' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'WWE1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'PINT' popcycle_group_for_peds_and_cars_to 5  
0767: set_zone 'YBELL2' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'YBELL1' popcycle_group_for_peds_and_cars_to 17 
0767: set_zone 'JTW1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTW2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN3' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN4' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN5' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN6' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN7' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTN8' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTE1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTE2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTE3' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'JTE4' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'HGP' popcycle_group_for_peds_and_cars_to 4  
0767: set_zone 'SPIN' popcycle_group_for_peds_and_cars_to 11  
0767: set_zone 'BINT1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'BINT2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'BINT3' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'BINT4' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'PRP1' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'PRP2' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'PRP3' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'PRP4' popcycle_group_for_peds_and_cars_to 4 
0767: set_zone 'REDE1' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'REDE2' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'REDE3' popcycle_group_for_peds_and_cars_to 2 
0767: set_zone 'REDW1' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'REDW2' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'REDW3' popcycle_group_for_peds_and_cars_to 11 
0767: set_zone 'REDW4' popcycle_group_for_peds_and_cars_to 5 
0767: set_zone 'ROCE1' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'ROCE2' popcycle_group_for_peds_and_cars_to 0 
0767: set_zone 'OVS' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'CREE' popcycle_group_for_peds_and_cars_to 9  
0767: set_zone 'STRIP1' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'STRIP2' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'STRIP3' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'STRIP4' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'PILL1' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'PILL2' popcycle_group_for_peds_and_cars_to 9 
0767: set_zone 'RING' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'ISLE' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'STAR1' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'STAR2' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'ROY' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'CAM' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'LOT' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'PIRA' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'VISA1' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'VISA2' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'CALI1' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'CALI2' popcycle_group_for_peds_and_cars_to 12 
0767: set_zone 'DRAG' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'PINK' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'HIGH' popcycle_group_for_peds_and_cars_to 12  
0767: set_zone 'CONST1' popcycle_group_for_peds_and_cars_to 18 
0767: set_zone 'ANGPI' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'SHACA' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'BACKO' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'BEACO' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'FARM' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'PALO' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'MONT' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'MONT1' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'MTCHI1' popcycle_group_for_peds_and_cars_to 3 
0767: set_zone 'MTCHI2' popcycle_group_for_peds_and_cars_to 3 
0767: set_zone 'MTCHI3' popcycle_group_for_peds_and_cars_to 3 
0767: set_zone 'MTCHI4' popcycle_group_for_peds_and_cars_to 3 
0767: set_zone 'HBARNS' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'DILLI' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'TOPFA' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'BLUEB' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'BLUEB1' popcycle_group_for_peds_and_cars_to 3 
0767: set_zone 'PANOP' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'BLUAC' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'CREEK' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'CREEK1' popcycle_group_for_peds_and_cars_to 3 
0767: set_zone 'MAKO' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'TOPFA' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'FERN' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'NROCK' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'HANKY' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'LEAFY' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'RED' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'FLINTC' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'WHET' popcycle_group_for_peds_and_cars_to 3  
0767: set_zone 'BIGE' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'ELQUE' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'BARRA' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'CARSO' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'PAYAS' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'PROBE' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'ELCA' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'FLINTR' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'ARCO' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'VALLE' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'FLINTI' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'MONINT' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'ROBINT' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'TOM' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'ALDEA' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'BRUJA' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'ROBAD' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'BONE' popcycle_group_for_peds_and_cars_to 1  
0767: set_zone 'HAUL' popcycle_group_for_peds_and_cars_to 18  
0767: set_zone 'QUARY' popcycle_group_for_peds_and_cars_to 18  
0767: set_zone 'OCTAN' popcycle_group_for_peds_and_cars_to 18  
0767: set_zone 'PALMS' popcycle_group_for_peds_and_cars_to 18  
0767: set_zone 'EBAY' popcycle_group_for_peds_and_cars_to 18  
0767: set_zone 'EBAY2' popcycle_group_for_peds_and_cars_to 18 
0767: set_zone 'DAM' popcycle_group_for_peds_and_cars_to 18" );
                }
                if( OriginalSetup.enableDefaultGangZones ) {
                    AppendLine( @"0237: set_gang 1 weapons_to 22 32 0 
076C: set_zone 'SUN1' gang 1 density_to 30 
076C: set_zone 'SUN3A' gang 1 density_to 30 
076C: set_zone 'SUN3B' gang 1 density_to 30 
076C: set_zone 'SUN3C' gang 1 density_to 30 
076C: set_zone 'SUN4' gang 1 density_to 30 
076C: set_zone 'CHC1A' gang 2 density_to 40 
076C: set_zone 'CHC1B' gang 2 density_to 40 
076C: set_zone 'CHC2A' gang 2 density_to 40 
076C: set_zone 'CHC2B' gang 2 density_to 40 
076C: set_zone 'CHC3' gang 2 density_to 40 
076C: set_zone 'CHC4A' gang 2 density_to 40 
076C: set_zone 'CHC4B' gang 2 density_to 40 
076C: set_zone 'EBE1' gang 2 density_to 30 
076C: set_zone 'EBE2A' gang 2 density_to 30 
076C: set_zone 'EBE2B' gang 2 density_to 30 
076C: set_zone 'EBE3C' gang 2 density_to 30 
076C: set_zone 'ELCO1' gang 7 density_to 40 
076C: set_zone 'ELCO2' gang 7 density_to 40 
076C: set_zone 'GAN1' gang 1 density_to 40 
076C: set_zone 'GAN2' gang 1 density_to 40 
076C: set_zone 'GLN1' gang 0 density_to 40 
076C: set_zone 'GLN2A' gang 0 density_to 40 
076C: set_zone 'LIND1A' gang 0 density_to 20 
076C: set_zone 'LIND1B' gang 0 density_to 20 
076C: set_zone 'LIND2A' gang 0 density_to 20 
076C: set_zone 'LIND2B' gang 0 density_to 20 
076C: set_zone 'LIND3' gang 0 density_to 20 
076C: set_zone 'IWD1' gang 0 density_to 20 
076C: set_zone 'IWD2' gang 0 density_to 20 
076C: set_zone 'IWD3A' gang 0 density_to 20 
076C: set_zone 'IWD3B' gang 0 density_to 20 
076C: set_zone 'IWD4' gang 0 density_to 10 
076C: set_zone 'IWD5' gang 0 density_to 20
076C: set_zone 'JEF1A' gang 0 density_to 40 
076C: set_zone 'JEF1B' gang 0 density_to 40 
076C: set_zone 'JEF2' gang 0 density_to 40 
076C: set_zone 'JEF3B' gang 0 density_to 40 
076C: set_zone 'JEF3C' gang 0 density_to 40 
076C: set_zone 'LMEX1A' gang 7 density_to 30 
076C: set_zone 'LMEX1B' gang 7 density_to 30 
076C: set_zone 'ELS1A' gang 0 density_to 30 
076C: set_zone 'ELS1B' gang 0 density_to 30 
076C: set_zone 'ELS2' gang 0 density_to 30 
076C: set_zone 'ELS3A' gang 0 density_to 30 
076C: set_zone 'ELS3B' gang 0 density_to 30 
076C: set_zone 'ELS4' gang 0 density_to 30 
076C: set_zone 'PLS' gang 1 density_to 10
076C: set_zone 'SMB1' gang 1 density_to 10 
076C: set_zone 'SMB2' gang 1 density_to 10 
076C: set_zone 'VIN2' gang 1 density_to 10 
076C: set_zone 'VERO1' gang 0 density_to 10 
076C: set_zone 'VERO2' gang 0 density_to 10 
076C: set_zone 'VERO3' gang 0 density_to 10 
076C: set_zone 'VERO4A' gang 0 density_to 10 
076C: set_zone 'VERO4B' gang 0 density_to 10 
076C: set_zone 'CALT' gang 6 density_to 10
076C: set_zone 'BATTP' gang 3 density_to 25
076C: set_zone 'ESPN1' gang 4 density_to 10 
076C: set_zone 'ESPN2' gang 4 density_to 10 
076C: set_zone 'ESPN3' gang 4 density_to 10 
076C: set_zone 'CHINA' gang 6 density_to 40
076C: set_zone 'THEA1' gang 6 density_to 10 
076C: set_zone 'THEA3' gang 3 density_to 10 
076C: set_zone 'GARC' gang 3 density_to 40
076C: set_zone 'DOH2' gang 3 density_to 10
076C: set_zone 'EASB1' gang 4 density_to 40 
076C: set_zone 'EASB2' gang 4 density_to 40" );
                }
                if( OriginalSetup.enableDefaultDealerDensity ) {
                    AppendLine( @"076A: set_zone 'CHC1A' dealer_density_to 4
076A: set_zone 'CHC1B' dealer_density_to 4
076A: set_zone 'CHC2A' dealer_density_to 4
076A: set_zone 'CHC2B' dealer_density_to 4
076A: set_zone 'CHC3' dealer_density_to 4
076A: set_zone 'CHC4A' dealer_density_to 4
076A: set_zone 'CHC4B' dealer_density_to 4
076A: set_zone 'EBE1' dealer_density_to 2
076A: set_zone 'EBE2A' dealer_density_to 2
076A: set_zone 'EBE2B' dealer_density_to 2
076A: set_zone 'EBE3C' dealer_density_to 2
076A: set_zone 'GLN1' dealer_density_to 6
076A: set_zone 'GLN2A' dealer_density_to 2
076A: set_zone 'IWD1' dealer_density_to 2
076A: set_zone 'IWD2' dealer_density_to 2
076A: set_zone 'IWD3A' dealer_density_to 2
076A: set_zone 'IWD3B' dealer_density_to 2
076A: set_zone 'IWD4' dealer_density_to 2
076A: set_zone 'IWD5' dealer_density_to 2
076A: set_zone 'JEF1A' dealer_density_to 6
076A: set_zone 'JEF1B' dealer_density_to 6
076A: set_zone 'JEF2' dealer_density_to 6
076A: set_zone 'JEF3B' dealer_density_to 6
076A: set_zone 'JEF3C' dealer_density_to 6
076A: set_zone 'LFL1A' dealer_density_to 4
076A: set_zone 'LFL1B' dealer_density_to 4
076A: set_zone 'ELS1A' dealer_density_to 2
076A: set_zone 'ELS1B' dealer_density_to 2
076A: set_zone 'ELS2' dealer_density_to 2
076A: set_zone 'ELS3A' dealer_density_to 2
076A: set_zone 'ELS3B' dealer_density_to 2
076A: set_zone 'ELS4' dealer_density_to 2
076A: set_zone 'VERO1' dealer_density_to 2
076A: set_zone 'VERO2' dealer_density_to 2
076A: set_zone 'VERO3' dealer_density_to 2
076A: set_zone 'VERO4A' dealer_density_to 2
076A: set_zone 'VERO4B' dealer_density_to 2" );
                }
                if( OriginalSetup.enableDefaultPoliceTriggers ) {
                    AppendLine( @"04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2435.2 -1741.0 2454.9 -1723.4 spawn_policeA_at 2481.0 -1707.0 headed_towards 2480.0 -1732.0 2481.0 -1707.0 headed_towards 2480.0 -1732.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2680.6 -1665.8 2702.2 -1647.8 spawn_policeA_at 2724.7 -1610.1 headed_towards 2727.2 -1656.9 2724.0 -1610.0 headed_towards 2727.0 -1656.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 2878.4 -1972.5 2869.7 -1954.9 spawn_policeA_at 2890.0 -1912.0 headed_towards 2877.0 -1962.0 2893.0 -2007.0 headed_towards 2881.0 -1970.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 2807.0 -1152.0 2822.0 -1135.0 spawn_policeA_at 2872.0 -1105.0 headed_towards 2874.0 -1133.0 2866.0 -1111.0 headed_towards 2864.0 -1138.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2261.0 -1263.0 2249.0 -1258.0 spawn_policeA_at 2173.0 -1232.0 headed_towards 2170.0 -1257.0 2184.0 -1258.0 headed_towards 2202.0 -1260.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2157.0 -1500.0 2173.0 -1495.0 spawn_policeA_at 2131.0 -1461.0 headed_towards 2131.0 -1495.0 2130.0 -1460.0 headed_towards 2131.0 -1494.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 2295.0 -1772.0 2302.0 -1761.0 spawn_policeA_at 2263.0 -1780.0 headed_towards 2263.0 -1809.0 2327.0 -1821.0 headed_towards 2303.0 -1817.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1518.0 -1700.0 1538.0 -1683.0 spawn_policeA_at 1564.0 -1730.0 headed_towards 1527.0 -1730.0 1565.0 -1731.0 headed_towards 1527.1 -1732.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2531.0 -1861.0 2547.0 -1839.0 spawn_policeA_at 2581.0 -1911.0 headed_towards 2578.0 -1865.0 2560.0 -1896.0 headed_towards 2561.0 -1848.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 1833.0 -1617.0 1854.0 -1608.0 spawn_policeA_at 1820.0 -1590.0 headed_towards 1818.0 -1605.0 1824.0 -1641.0 headed_towards 1824.0 -1619.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 1694.0 -1518.0 1706.0 -1505.0 spawn_policeA_at 1720.0 -1476.0 headed_towards 1709.0 -1487.0 1718.0 -1473.0 headed_towards 1709.0 -1474.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1707.0 -1467.0 1711.0 -1457.0 spawn_policeA_at 1689.0 -1443.0 headed_towards 1709.0 -1444.0 1688.0 -1443.0 headed_towards -1709.0 -1444.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 1815.0 -1406.0 1829.0 -1388.0 spawn_policeA_at 1840.0 -1410.0 headed_towards 1835.0 -1402.0 1841.0 -1411.0 headed_towards 1836.0 -1403.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 1804.0 -1353.0 1807.0 -1342.0 spawn_policeA_at 1781.0 -1366.0 headed_towards 1784.0 -1352.0 1781.0 -1366.0 headed_towards 1784.0 -1352.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1710.0 -1339.0 1724.0 -1319.0 spawn_policeA_at 1684.0 -1305.0 headed_towards 1712.0 -1305.0 1684.0 -1305.0 headed_towards 1712.0 -1305.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1711.0 -1204.0 1720.0 -1194.0 spawn_policeA_at 1747.0 -1160.0 headed_towards 1712.0 -1159.0 1747.0 -1160.0 headed_towards 1712.0 -1159.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2389.0 -1479.0 2404.0 -1469.0 spawn_policeA_at 2429.0 -1457.0 headed_towards 2429.0 -1479.0 2428.0 -1456.0 headed_towards 2430.0 -1480.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2443.0 -1221.0 2457.0 -1209.0 spawn_policeA_at 2474.0 -1253.0 headed_towards 2447.0 -1255.0 2475.0 -1254.0 headed_towards 2448.0 -1256.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 2627.0 -1134.0 2632.0 -1132.0 spawn_policeA_at 2649.0 -1150.0 headed_towards 2642.0 -1139.0 2650.0 -1151.0 headed_towards 2643.0 -1140.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2677.0 -1095.0 2697.0 -1060.0 spawn_policeA_at 2645.0 -1106.0 headed_towards 2646.0 -1077.0 2646.0 -1107.0 headed_towards 2647.0 -1078.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1947.0 -1055.0 1955.0 -1038.0 spawn_policeA_at 1989.0 -1025.0 headed_towards 1978.0 -1057.0 1990.0 -1026.0 headed_towards 1979.0 -1058.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1858.0 -1123.0 1876.0 -1113.0 spawn_policeA_at 1895.0 -1133.0 headed_towards 1865.0 -1133.0 1896.0 -1134.0 headed_towards 1866.0 -1134.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1977.0 -1416.0 1996.0 -1411.0 spawn_policeA_at 1966.0 -1467.0 headed_towards 1988.0 -1465.0 1967.0 -1468.0 headed_towards 1989.0 -1466.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2191.0 -1345.0 2202.0 -1338.0 spawn_policeA_at 2216.0 -1355.0 headed_towards 2216.0 -1343.0 2217.0 -1356.0 headed_towards 2217.0 -1344.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2339.0 -1161.0 2345.0 -1148.0 spawn_policeA_at 2372.0 -1182.0 headed_towards 2373.0 -1157.0 2373.0 -1183.0 headed_towards 2374.0 -1158.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2034.0 -1271.0 2049.0 -1251.0 spawn_policeA_at 2072.0 -1281.0 headed_towards 2070.0 -1261.0 2073.0 -1282.0 headed_towards 2070.0 -2074.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 1410.0 -1250.0 1427.0 -1233.0 spawn_policeA_at 1457.0 -1263.0 headed_towards 1456.0 -1243.0 1452.0 -1211.0 headed_towards 1453.0 -1238.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1427.0 -1334.0 1433.0 -1323.0 spawn_policeA_at 1419.0 -1270.0 headed_towards 1419.0 -1286.0 1420.0 -1253.0 headed_towards 1419.0 -1257.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1520.0 -1655.0 1538.0 -1642.0 spawn_policeA_at 1561.0 -1626.0 headed_towards 1530.0 -1627.0 1562.0 -1620.0 headed_towards 1531.0 -1622.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1129.0 -1669.0 1140.0 -1663.0 spawn_policeA_at 1095.0 -1665.0 headed_towards 1130.0 -1665.0 1117.0 -1714.0 headed_towards 1138.0 -1715.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1167.0 -1782.0 1190.0 -1769.0 spawn_policeA_at 1148.0 -1744.0 headed_towards 1176.0 -1743.0 1141.0 -1739.0 headed_towards 1175.0 -1737.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1207.0 -1214.0 1216.0 -1193.0 spawn_policeA_at 1175.0 -1210.0 headed_towards 1194.0 -1209.0 1179.0 -1204.0 headed_towards 1197.0 -1204.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 1261.0 -1721.0 1271.0 -1707.0 spawn_policeA_at 1295.0 -1680.0 headed_towards 1295.0 -1717.0 1300.0 -1670.0 headed_towards 1300.0 -1704.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1237.0 -1290.0 1257.0 -1271.0 spawn_policeA_at 1214.0 -1253.0 headed_towards 1215.0 -1281.0 1215.0 -1215.0 headed_towards -1215.0 -1281.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1013.0 -1158.0 1030.0 -1132.0 spawn_policeA_at 1060.0 -1174.0 headed_towards 1060.0 -1148.0 1060.0 -1174.0 headed_towards 1060.0 -1148.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1089.0 -1212.0 1076.0 -1204.0 spawn_policeA_at 1061.0 -1223.0 headed_towards 1064.0 -1205.0 1061.0 -1223.0 headed_towards 1064.0 -1205.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 953.0 -1108.0 945.0 -1097.0 spawn_policeA_at 928.0 -1084.0 headed_towards 937.0 -1099.0 928.0 -1084.0 headed_towards 937.0 -1099.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 829.0 -1066.0 830.0 -1057.0 spawn_policeA_at 837.0 -1049.0 headed_towards 828.0 -1055.0 837.0 -1049.0 headed_towards 828.0 -1055.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 816.0 -1048.0 840.0 -1030.0 spawn_policeA_at 793.0 -1015.0 headed_towards 791.0 -1055.0 793.0 -1015.0 headed_towards 791.0 -1055.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 642.0 -1197.0 676.0 -1187.0 spawn_policeA_at 597.0 -1183.0 headed_towards 616.0 -1211.0 597.0 -1193.0 headed_towards 616.0 -1211.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 618.0 -1287.0 647.0 -1272.0 spawn_policeA_at 665.0 -1317.0 headed_towards 632.0 -1317.0 662.0 -1317.0 headed_towards 632.0 -1317.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 457.0 -1364.0 487.0 -1357.0 spawn_policeA_at 493.0 -1323.0 headed_towards 501.0 -1340.0 498.0 -1317.0 headed_towards 513.0 -1350.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 523.0 -1456.0 555.0 -1442.0 spawn_policeA_at 569.0 -1404.0 headed_towards 532.0 -1413.0 567.0 -1399.0 headed_towards 525.0 -1407.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 478.0 -1488.0 496.0 -1472.0 spawn_policeA_at 491.0 -1518.0 headed_towards 490.0 -1501.0 490.0 -1521.0 headed_towards 487.0 -1497.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 470.0 -1604.0 490.0 -1573.0 spawn_policeA_at 540.0 -1626.0 headed_towards 540.0 -1583.0 540.0 -1626.0 headed_towards 540.0 -1583.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 519.0 -1687.0 544.0 -1676.0 spawn_policeA_at 486.0 -1727.0 headed_towards 534.0 -1734.0 486.0 -1727.0 headed_towards 534.0 -1734.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 380.0 -1803.0 394.0 -1798.0 spawn_policeA_at 363.0 -1833.0 headed_towards 373.0 -1819.0 385.0 -1831.0 headed_towards 373.0 -1819.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 2134.0 -1904.0 2156.0 -1885.0 spawn_policeA_at 2105.0 -1919.0 headed_towards 2105.0 -1899.0 2079.0 -1871.0 headed_towards 2080.0 -1898.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1953.0 -1988.0 1971.0 -1966.0 spawn_policeA_at 1985.0 -1930.0 headed_towards 1967.0 -1929.0 1927.0 -1935.0 headed_towards 1953.0 -1935.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 2015.0 -2064.0 2026.0 -2052.0 spawn_policeA_at 2009.0 -2010.0 headed_towards 2007.0 -2033.0 1970.0 -2059.0 headed_towards 1988.0 -2058.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1997.0 -2077.0 2009.0 -2065.0 spawn_policeA_at 2041.0 -2056.0 headed_towards 2016.0 -2058.0 2027.0 -2084.0 headed_towards 2005.0 -2084.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1924.0 -2108.0 1935.0 -2096.0 spawn_policeA_at 1917.0 -2074.0 headed_towards 1917.0 -2094.0 1917.0 -2138.0 headed_towards 1917.0 -2116.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1847.0 -2108.0 1860.0 -2097.0 spawn_policeA_at 1821.0 -2089.0 headed_towards 1820.0 -2101.0 1903.0 -2101.0 headed_towards 1883.0 -2101.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle 1861.0 -2010.0 1870.0 -2005.0 spawn_policeA_at 1885.0 -2041.0 headed_towards 1886.0 -2021.0 1880.0 -2044.0 headed_towards 1878.0 -2016.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1751.0 -2388.0 1781.0 -2369.0 spawn_policeA_at 1799.0 -2345.0 headed_towards 1798.0 -2377.0 1799.0 -2345.0 headed_towards 1798.0 -2377.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1314.0 -2423.0 1325.0 -2410.0 spawn_policeA_at 1339.0 -2446.0 headed_towards 1317.0 -2446.0 1339.0 -2446.0 headed_towards 1317.0 -2446.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1551.0 -1636.0 1562.0 -1618.0 spawn_policeA_at 1531.0 -1660.0 headed_towards 1532.0 -1632.0 1531.0 -1660.0 headed_towards 1532.0 -1632.0 
04F8: define_police_trigger_type 8 if_player_with_wanted_level_in_rectangle 1225.0 -1880.0 1237.0 -1866.0 spawn_policeA_at 1180.0 -1884.0 headed_towards 1213.0 -1885.0 1169.0 -1887.0 headed_towards 1194.0 -1888.0 
04F8: define_police_trigger_type 8 if_player_with_wanted_level_in_rectangle 1076.0 -1890.0 1097.0 -1881.0 spawn_policeA_at 1161.0 -1880.0 headed_towards 1108.0 -1883.0 1050.0 -1894.0 headed_towards 1084.0 -1887.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1059.0 -1721.0 1090.0 -1703.0 spawn_policeA_at 1034.0 -1674.0 headed_towards 1039.0 -1713.0 1034.0 -1674.0 headed_towards 1039.0 -1713.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1028.0 -1690.0 1048.0 -1657.0 spawn_policeA_at 1079.0 -1710.0 headed_towards 1037.0 -1709.0 1079.0 -1710.0 headed_towards 1037.0 -1709.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 982.0 -1913.0 953.0 -1858.0 spawn_policeA_at 980.0 -1852.0 headed_towards 966.0 -1860.0 946.0 -1846.0 headed_towards 956.0 -1857.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 849.0 -1899.0 823.0 -1937.0 spawn_policeA_at 836.0 -2017.0 headed_towards 839.0 -1993.0 848.0 -2020.0 headed_towards 842.0 -1990.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 820.0 -1844.0 848.0 -1819.0 spawn_policeA_at 789.0 -1786.0 headed_towards 827.0 -1786.0 881.0 -1772.0 headed_towards 827.0 -1772.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 788.0 -1816.0 780.0 -1800.0 spawn_policeA_at 786.0 -1835.0 headed_towards 781.0 -1820.0 786.0 -1835.0 headed_towards 781.0 -1820.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 740.0 -1815.0 759.0 -1808.0 spawn_policeA_at 738.0 -1790.0 headed_towards 737.0 -1806.0 744.0 -1836.0 headed_towards 746.0 -1819.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 717.0 -1819.0 727.0 -1805.0 spawn_policeA_at 745.0 -1827.0 headed_towards 746.0 -1815.0 735.0 -1792.0 headed_towards 728.0 -1813.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 624.0 -1786.0 641.0 -1778.0 spawn_policeA_at 644.0 -1799.0 headed_towards 647.0 -1789.0 651.0 -1767.0 headed_towards 649.0 -1783.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 606.0 -1786.0 622.0 -1770.0 spawn_policeA_at 656.0 -1759.0 headed_towards 649.0 -1787.0 656.0 -1759.0 headed_towards 649.0 -1787.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 586.0 -1868.0 612.0 -1835.0 spawn_policeA_at 648.0 -1818.0 headed_towards 643.0 -1856.0 648.0 -1818.0 headed_towards 643.0 -1856.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 541.0 -1778.0 562.0 -1762.0 spawn_policeA_at 593.0 -1775.0 headed_towards 573.0 -1772.0 593.0 -1772.0 headed_towards 573.0 -1772.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 511.0 -1777.0 478.0 -1762.0 spawn_policeA_at 455.0 -1737.0 headed_towards 458.0 -1769.0 455.0 -1737.0 headed_towards 458.0 -1769.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 381.0 -1806.0 398.0 -1790.0 spawn_policeA_at 385.0 -1825.0 headed_towards 383.0 -1806.0 364.0 -1831.0 headed_towards 377.0 -1810.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 361.0 -1689.0 379.0 -1667.0 spawn_policeA_at 401.0 -1650.0 headed_towards 372.0 -1646.0 334.0 -1646.0 headed_towards 365.0 -1649.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 289.0 -1647.0 314.0 -1631.0 spawn_policeA_at 321.0 -1597.0 headed_towards 321.0 -1642.0 321.0 -1597.0 headed_towards 321.0 -1642.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 225.0 -1610.0 252.0 -1590.0 spawn_policeA_at 274.0 -1576.0 headed_towards 242.0 -1566.0 274.0 -1576.0 headed_towards 242.0 -1566.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 301.0 -1472.0 336.0 -1467.0 spawn_policeA_at 269.0 -1476.0 headed_towards 291.0 -1497.0 269.0 -1476.0 headed_towards 291.0 -1497.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 196.0 -1528.0 223.0 -1508.0 spawn_policeA_at 193.0 -1489.0 headed_towards 179.0 -1512.0 174.0 -1579.0 headed_towards 147.0 -1554.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 221.0 -1367.0 226.0 -1337.0 spawn_policeA_at 228.0 -1310.0 headed_towards 246.0 -1336.0 228.0 -1310.0 headed_towards 246.0 -1336.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 427.0 -1238.0 450.0 -1229.0 spawn_policeA_at 391.0 -1225.0 headed_towards 402.0 -1252.0 391.0 -1225.0 headed_towards 402.0 -1252.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 478.0 -1257.0 478.0 -1227.0 spawn_policeA_at 489.0 -1281.0 headed_towards 508.0 -1265.0 489.0 -1281.0 headed_towards 508.0 -1265.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 337.0 -1176.0 371.0 -1170.0 spawn_policeA_at 395.0 -1169.0 headed_towards 362.0 -1141.0 344.0 -1131.0 headed_towards 381.0 -1167.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1798.0 796.0 1816.0 823.0 spawn_policeA_at 1760.0 832.0 headed_towards 1809.0 834.0 1760.0 832.0 headed_towards 1809.0 834.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2032.0 892.0 2056.0 919.0 spawn_policeA_at 2086.0 856.0 headed_towards 2047.0 856.0 2086.0 856.0 headed_towards 2047.0 856.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2034.0 985.0 2053.0 1024.0 spawn_policeA_at 2074.0 975.0 headed_towards 2044.0 974.0 2074.0 975.0 headed_towards 2044.0 974.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2035.0 1228.0 2056.0 1254.0 spawn_policeA_at 2021.0 1275.0 headed_towards 2051.0 1277.0 2021.0 1275.0 headed_towards 2051.0 1277.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2114.0 2071.0 2136.0 2096.0 spawn_policeA_at 2098.0 2020.0 headed_towards 2131.0 2020.0 2098.0 2020.0 headed_towards 2131.0 2020.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1937.0 2104.0 1954.0 2122.0 spawn_policeA_at 1925.0 2139.0 headed_towards 1926.0 2110.0 1925.0 2139.0 headed_towards 1926.0 2110.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1836.0 2044.0 1858.0 2059.0 spawn_policeA_at 1815.0 2080.0 headed_towards 1821.0 2051.0 1815.0 2080.0 headed_towards 1821.0 2051.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1721.0 2044.0 1739.0 2063.0 spawn_policeA_at 1710.0 2023.0 headed_towards 1709.0 2051.0 1710.0 2023.0 headed_towards 1709.0 2051.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 1699.0 2134.0 1717.0 2152.0 spawn_policeA_at 1734.0 2172.0 headed_towards 1709.0 2171.0 1729.0 2175.0 headed_towards 1694.0 2175.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 1581.0 2164.0 1600.0 2182.0 spawn_policeA_at 1616.0 2143.0 headed_towards 1615.0 2170.0 1621.0 2146.0 headed_towards 1622.0 2182.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 1522.0 2044.0 1538.0 2060.0 spawn_policeA_at 1529.0 2083.0 headed_towards 1532.0 2055.0 1525.0 2087.0 headed_towards 1525.0 2056.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 1466.0 1989.0 1490.0 2003.0 spawn_policeA_at 1457.0 2024.0 headed_towards 1476.0 2009.0 1499.0 2027.0 headed_towards 1483.0 2006.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 1429.0 2617.0 1439.0 2624.0 spawn_policeA_at 1422.0 2615.0 headed_towards 1433.0 2619.0 1446.0 2615.0 headed_towards 1434.0 2622.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1469.0 2545.0 1487.0 2568.0 spawn_policeA_at 1500.0 2592.0 headed_towards 1474.0 2591.0 1500.0 2592.0 headed_towards 1474.0 2591.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1300.0 2580.0 1325.0 2599.0 spawn_policeA_at 1291.0 2568.0 headed_towards 1291.0 2597.0 1291.0 2568.0 headed_towards 1291.0 2597.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2240.0 2460.0 2246.0 2449.0 spawn_policeA_at 2230.0 2433.0 headed_towards 2231.0 2451.0 2229.0 2476.0 headed_towards 2231.0 2456.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1238.0 2671.0 1257.0 2690.0 spawn_policeA_at 1276.0 2716.0 headed_towards 1244.0 2713.0 1276.0 2716.0 headed_towards 1244.0 2713.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 1493.0 2580.0 1512.0 2599.0 spawn_policeA_at 1479.0 2562.0 headed_towards 1480.0 2588.0 1476.0 2555.0 headed_towards 1475.0 2585.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1469.0 2433.0 1486.0 2447.0 spawn_policeA_at 1449.0 2390.0 headed_towards 1478.0 2391.0 1449.0 2390.0 headed_towards 1478.0 2391.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1558.0 2283.0 1577.0 2305.0 spawn_policeA_at 1529.0 2311.0 headed_towards 1565.0 2310.0 1529.0 2311.0 headed_towards 1565.0 2310.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1397.0 2303.0 1419.0 2323.0 spawn_policeA_at 1385.0 2331.0 headed_towards 1389.0 2313.0 1385.0 2331.0 headed_towards 1389.0 2313.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 1568.0 2114.0 1578.0 2140.0 spawn_policeA_at 1573.0 2078.0 headed_towards 1573.0 2118.0 1571.0 2088.0 headed_towards 1571.0 2106.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1660.0 2002.0 1685.0 2021.0 spawn_policeA_at 1710.0 1985.0 headed_towards 1709.0 2015.0 1710.0 1985.0 headed_towards 1709.0 2015.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1765.0 2044.0 1788.0 2063.0 spawn_policeA_at 1810.0 2083.0 headed_towards 1827.0 2056.0 1810.0 2083.0 headed_towards 1827.0 2056.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1948.0 2274.0 1971.0 2293.0 spawn_policeA_at 1930.0 2259.0 headed_towards 1930.0 2283.0 1930.0 2259.0 headed_towards 1930.0 2283.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 1918.0 2309.0 1938.0 2328.0 spawn_policeA_at 1951.0 2338.0 headed_towards 1929.0 2338.0 1895.0 2333.0 headed_towards 1926.0 2337.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 1986.0 2384.0 2006.0 2403.0 spawn_policeA_at 2031.0 2367.0 headed_towards 2024.0 2392.0 2026.0 2433.0 headed_towards 2025.0 2395.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2011.0 2334.0 2017.0 2352.0 spawn_policeA_at 1995.0 2286.0 headed_towards 2014.0 2288.0 1995.0 2286.0 headed_towards 2014.0 2288.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2063.0 2274.0 2090.0 2293.0 spawn_policeA_at 2068.0 2313.0 headed_towards 2096.0 2292.0 2119.0 2260.0 headed_towards 2104.0 2282.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2171.0 2356.0 2185.0 2356.0 spawn_policeA_at 2214.0 2328.0 headed_towards 2196.0 2336.0 2217.0 2370.0 headed_towards 2204.0 2348.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2177.0 2302.0 2185.0 2325.0 spawn_policeA_at 2198.0 2286.0 headed_towards 2161.0 2288.0 2198.0 2286.0 headed_towards 2161.0 2288.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2256.0 2274.0 2294.0 2293.0 spawn_policeA_at 2288.0 2260.0 headed_towards 2287.0 2283.0 2288.0 2260.0 headed_towards 2287.0 2283.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2379.0 2404.0 2395.0 2423.0 spawn_policeA_at 2342.0 2436.0 headed_towards 2353.0 2415.0 2342.0 2436.0 headed_towards 2353.0 2415.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2218.0 2422.0 2239.0 2438.0 spawn_policeA_at 2257.0 2455.0 headed_towards 2227.0 2452.0 2257.0 2455.0 headed_towards 2227.0 2452.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2337.0 2504.0 2354.0 2522.0 spawn_policeA_at 2370.0 2482.0 headed_towards 2370.0 2513.0 2370.0 2482.0 headed_towards 2370.0 2513.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2490.0 2403.0 2511.0 2423.0 spawn_policeA_at 2524.0 2438.0 headed_towards 2525.0 2411.0 2524.0 2438.0 headed_towards 2525.0 2411.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2518.0 2255.0 2537.0 2274.0 spawn_policeA_at 2555.0 2236.0 headed_towards 2528.0 2237.0 2555.0 2236.0 headed_towards 2528.0 2237.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2518.0 2189.0 2539.0 2210.0 spawn_policeA_at 2558.0 2235.0 headed_towards 2518.0 2236.0 2498.0 2231.0 headed_towards 2537.0 2231.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2544.0 2222.0 2566.0 2243.0 spawn_policeA_at 2524.0 2265.0 headed_towards 2525.0 2234.0 2530.0 2271.0 headed_towards 2531.0 2226.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2363.0 2224.0 2395.0 2248.0 spawn_policeA_at 2352.0 2205.0 headed_towards 2353.0 2236.0 2346.0 2197.0 headed_towards 2344.0 2231.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2333.0 2173.0 2369.0 2190.0 spawn_policeA_at 2313.0 2138.0 headed_towards 2349.0 2140.0 2313.0 2138.0 headed_towards 2349.0 2140.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2380.0 2124.0 2404.0 2163.0 spawn_policeA_at 2346.0 2178.0 headed_towards 2350.0 2149.0 2346.0 2178.0 headed_towards 2350.0 2149.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 2484.0 2124.0 2513.0 2163.0 spawn_policeA_at 2525.0 2179.0 headed_towards 2525.0 2151.0 2530.0 2184.0 headed_towards 2530.0 2136.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 2713.0 2104.0 2737.0 2122.0 spawn_policeA_at 2793.0 2086.0 headed_towards 2796.0 2110.0 2796.0 2079.0 headed_towards 2801.0 2110.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle 2838.0 2127.0 2857.0 2159.0 spawn_policeA_at 2824.0 2111.0 headed_towards 2846.0 2111.0 2803.0 2111.0 headed_towards 2845.0 2112.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2789.0 1945.0 2803.0 1985.0 spawn_policeA_at 2745.0 1956.0 headed_towards 2779.0 1956.0 2739.0 1952.0 headed_towards 2786.0 1951.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2640.0 1944.0 2660.0 1965.0 spawn_policeA_at 2605.0 1982.0 headed_towards 2605.0 1953.0 2605.0 1982.0 headed_towards 2605.0 1953.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 2498.0 1921.0 2517.0 1938.0 spawn_policeA_at 2537.0 1955.0 headed_towards 2507.0 1956.0 2537.0 1955.0 headed_towards 2507.0 1956.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 2408.0 2021.0 2429.0 2042.0 spawn_policeA_at 2398.0 2045.0 headed_towards 2412.0 2044.0 2398.0 2045.0 headed_towards 2412.0 2044.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 2188.0 1826.0 2205.0 1851.0 spawn_policeA_at 2234.0 1867.0 headed_towards 2212.0 1851.0 2234.0 1867.0 headed_towards 2212.0 1851.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 2067.0 1863.0 2082.0 1894.0 spawn_policeA_at 2083.0 1843.0 headed_towards 2095.0 1865.0 2083.0 1843.0 headed_towards 2095.0 1865.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 2033.0 1894.0 2048.0 1936.0 spawn_policeA_at 2060.0 1951.0 headed_towards 2041.0 1943.0 2069.0 1865.0 headed_towards 2063.0 1878.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2069.0 1785.0 2139.0 1806.0 spawn_policeA_at 2147.0 1776.0 headed_towards 2095.0 1776.0 1975.0 1711.0 headed_towards 2060.0 1710.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 2094.0 1649.0 2165.0 1737.0 spawn_policeA_at 2177.0 1666.0 headed_towards 2129.0 1655.0 2151.0 1723.0 headed_towards 2134.0 1717.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle 2006.0 1541.0 2021.0 1550.0 spawn_policeA_at 2001.0 1564.0 headed_towards 2004.0 1553.0 2001.0 1564.0 headed_towards 2004.0 1553.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1931.0 1444.0 1964.0 1466.0 spawn_policeA_at 1989.0 1415.0 headed_towards 1991.0 1454.0 1989.0 1415.0 headed_towards 1991.0 1454.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1935.0 1299.0 1958.0 1322.0 spawn_policeA_at 1974.0 1276.0 headed_towards 1949.0 1277.0 1974.0 1276.0 headed_towards 1949.0 1277.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle 1756.0 1264.0 1786.0 1282.0 spawn_policeA_at 1730.0 1302.0 headed_towards 1722.0 1273.0 1730.0 1302.0 headed_towards 1722.0 1273.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle 1723.0 1182.0 1736.0 1205.0 spawn_policeA_at 1714.0 1234.0 headed_towards 1714.0 1217.0 1703.0 1229.0 headed_towards 1709.0 1219.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1583.0 1124.0 1606.0 1142.0 spawn_policeA_at 1570.0 1098.0 headed_towards 1569.0 1138.0 1570.0 1098.0 headed_towards 1569.0 1138.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle 1716.0 1585.0 1744.0 1605.0 spawn_policeA_at 1726.0 1663.0 headed_towards 1745.0 1637.0 1726.0 1663.0 headed_towards 1745.0 1637.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2349.0 2381.0 -2327.0 2377.0 spawn_policeA_at -2349.0 2402.0 headed_towards -2328.0 2388.0 -2349.0 2402.0 headed_towards -2328.0 2388.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2475.0 2299.0 -2456.0 2315.0 spawn_policeA_at -2435.0 2337.0 headed_towards -2466.0 2334.0 -2435.0 2337.0 headed_towards -2466.0 2334.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle -1591.0 656.0 -1574.0 667.0 spawn_policeA_at -1561.0 690.0 headed_towards -1562.0 663.0 -1557.0 692.0 headed_towards -1556.0 665.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1752.0 1317.0 -1726.0 1323.0 spawn_policeA_at -1749.0 1269.0 headed_towards -1714.0 1299.0 -1749.0 1269.0 headed_towards -1714.0 1299.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1715.0 1309.0 -1711.0 1343.0 spawn_policeA_at -1710.0 1377.0 headed_towards -1736.0 1350.0 -1710.0 1377.0 headed_towards -1736.0 1350.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle -1673.0 1386.0 -1637.0 1391.0 spawn_policeA_at -1624.0 1380.0 headed_towards -1626.0 1393.0 -1662.0 1430.0 headed_towards -1642.0 1427.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2002.0 1273.0 -1967.0 1299.0 spawn_policeA_at -1943.0 1258.0 headed_towards -1944.0 1293.0 -1943.0 1258.0 headed_towards -1944.0 1293.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle -1946.0 1233.0 -1939.0 1245.0 spawn_policeA_at -1943.0 1195.0 headed_towards -1943.0 1221.0 -2021.0 1227.0 headed_towards -1983.0 1227.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle -1917.0 1253.0 -1904.0 1259.0 spawn_policeA_at -1900.0 1242.0 headed_towards -1900.0 1256.0 -1900.0 1242.0 headed_towards -1900.0 1256.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2041.0 1223.0 -2022.0 1232.0 spawn_policeA_at -2010.0 1208.0 headed_towards -2010.0 1228.0 -2010.0 1208.0 headed_towards -2010.0 1228.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -1862.0 1166.0 -1836.0 1191.0 spawn_policeA_at -1789.0 1147.0 headed_towards -1790.0 1187.0 -1794.0 1148.0 headed_towards -1794.0 1186.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1728.0 1134.0 -1702.0 1154.0 spawn_policeA_at -1747.0 1182.0 headed_towards -1710.0 1184.0 -1747.0 1182.0 headed_towards -1710.0 1184.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1685.0 1173.0 -1663.0 1201.0 spawn_policeA_at -1708.0 1151.0 headed_towards -1712.0 1186.0 -1708.0 1151.0 headed_towards -1712.0 1186.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -1678.0 1174.0 -1647.0 1206.0 spawn_policeA_at -1644.0 1222.0 headed_towards -1618.0 1192.0 -1606.0 1151.0 headed_towards -1618.0 1192.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -1760.0 1083.0 -1736.0 1115.0 spawn_policeA_at -1718.0 1068.0 headed_towards -1718.0 1105.0 -1718.0 1068.0 headed_towards -1718.0 1105.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -1726.0 1005.0 -1701.0 986.0 spawn_policeA_at -1673.0 932.0 headed_towards -1716.0 933.0 -1673.0 932.0 headed_towards -1716.0 933.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1769.0 963.0 -1749.0 901.0 spawn_policeA_at -1710.0 886.0 headed_towards -1711.0 923.0 -1710.0 886.0 headed_towards -1711.0 923.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -1684.0 903.0 -1658.0 944.0 spawn_policeA_at -1711.0 833.0 headed_towards -1710.0 912.0 -1718.0 975.0 headed_towards -1719.0 926.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -1806.0 954.0 -1782.0 981.0 spawn_policeA_at -1753.0 935.0 headed_towards -1795.0 934.0 -1842.0 916.0 headed_towards -1793.0 916.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -1806.0 891.0 -1781.0 867.0 spawn_policeA_at -1838.0 914.0 headed_towards -1794.0 915.0 -1838.0 914.0 headed_towards -1794.0 915.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle -1614.0 943.0 -1589.0 904.0 spawn_policeA_at -1563.0 880.0 headed_towards -1561.0 922.0 -1563.0 966.0 headed_towards -1556.0 929.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1871.0 827.0 -1843.0 864.0 spawn_policeA_at -1902.0 885.0 headed_towards -1903.0 837.0 -1902.0 885.0 headed_towards -1903.0 837.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -1912.0 954.0 -1880.0 977.0 spawn_policeA_at -1936.0 934.0 headed_towards -1896.0 935.0 -1936.0 934.0 headed_towards -1896.0 935.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -1882.0 906.0 -1855.0 943.0 spawn_policeA_at -1896.0 889.0 headed_towards -1896.0 924.0 -1896.0 889.0 headed_towards -1896.0 924.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -1983.0 906.0 -1954.0 943.0 spawn_policeA_at -1998.0 883.0 headed_towards -1999.0 924.0 -1998.0 883.0 headed_towards -1999.0 924.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle -2044.0 901.0 -2030.0 907.0 spawn_policeA_at -2045.0 922.0 headed_towards -2049.0 907.0 -2058.0 935.0 headed_towards -2050.0 912.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle -2113.0 952.0 -2098.0 961.0 spawn_policeA_at -2078.0 953.0 headed_towards -2094.0 954.0 -2086.0 931.0 headed_towards -2097.0 948.0 
04F8: define_police_trigger_type 8 if_player_with_wanted_level_in_rectangle -2034.0 957.0 -2019.0 951.0 spawn_policeA_at -2010.0 981.0 headed_towards -2010.0 952.0 -1965.0 933.0 headed_towards -2000.0 935.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2018.0 1017.0 -1992.0 1038.0 spawn_policeA_at -1959.0 1053.0 headed_towards -2002.0 1052.0 -1959.0 1053.0 headed_towards -2002.0 1052.0 
04F8: define_police_trigger_type 4 if_player_with_wanted_level_in_rectangle -2077.0 1038.0 -2072.0 1045.0 spawn_policeA_at -2080.0 1078.0 headed_towards -2079.0 1053.0 -2080.0 1078.0 headed_towards -2079.0 1053.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2301.0 1043.0 -2253.0 1089.0 spawn_policeA_at -2350.0 1117.0 headed_towards -2360.0 1088.0 -2350.0 1117.0 headed_towards -2360.0 1088.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2381.0 1030.0 -2375.0 1061.0 spawn_policeA_at -2320.0 1074.0 headed_towards -2356.0 1085.0 -2320.0 1074.0 headed_towards -2356.0 1085.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2399.0 965.0 -2374.0 992.0 spawn_policeA_at -2344.0 961.0 headed_towards -2385.0 961.0 -2344.0 961.0 headed_towards -2385.0 961.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2294.0 949.0 -2281.0 969.0 spawn_policeA_at -2254.0 956.0 headed_towards -2265.0 960.0 -2254.0 956.0 headed_towards -2265.0 960.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2282.0 992.0 -2239.0 1017.0 spawn_policeA_at -2298.0 957.0 headed_towards -2258.0 955.0 -2298.0 957.0 headed_towards -2258.0 955.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2206.0 903.0 -2171.0 934.0 spawn_policeA_at -2254.0 943.0 headed_towards -2253.0 917.0 -2254.0 943.0 headed_towards -2253.0 917.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2160.0 927.0 -2129.0 954.0 spawn_policeA_at -2177.0 916.0 headed_towards -2128.0 916.0 -2177.0 916.0 headed_towards -2128.0 916.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle -2104.0 853.0 -2088.0 859.0 spawn_policeA_at -2082.0 816.0 headed_towards -2082.0 838.0 -2101.0 806.0 headed_towards -2079.0 806.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2099.0 696.0 -2079.0 710.0 spawn_policeA_at -2114.0 729.0 headed_towards -2089.0 729.0 -2114.0 729.0 headed_towards -2089.0 729.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -2045.0 720.0 -2028.0 746.0 spawn_policeA_at -2008.0 758.0 headed_towards -2009.0 730.0 -2001.0 773.0 headed_towards -2001.0 732.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -1989.0 719.0 -1965.0 744.0 spawn_policeA_at -2000.0 691.0 headed_towards -2001.0 731.0 -2007.0 765.0 headed_towards -2008.0 732.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2017.0 632.0 -1992.0 657.0 spawn_policeA_at -1982.0 611.0 headed_towards -2014.0 611.0 -1982.0 611.0 headed_towards -2014.0 611.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1979.0 596.0 -1955.0 620.0 spawn_policeA_at -2015.0 643.0 headed_towards -2013.0 615.0 -2015.0 643.0 headed_towards -2013.0 615.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2056.0 455.0 -2027.0 477.0 spawn_policeA_at -2008.0 438.0 headed_towards -2008.0 457.0 -2008.0 438.0 headed_towards -2008.0 457.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2136.0 347.0 -2130.0 368.0 spawn_policeA_at -2117.0 386.0 headed_towards -2135.0 386.0 -2117.0 386.0 headed_towards -2135.0 386.0 
04F8: define_police_trigger_type 1 if_player_with_wanted_level_in_rectangle -2196.0 363.0 -2174.0 369.0 spawn_policeA_at -2148.0 356.0 headed_towards -2149.0 374.0 -2145.0 388.0 headed_towards -2145.0 367.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2176.0 451.0 -2164.0 456.0 spawn_policeA_at -2148.0 469.0 headed_towards -2149.0 452.0 -2148.0 469.0 headed_towards -2149.0 452.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2203.0 451.0 -2190.0 456.0 spawn_policeA_at -2233.0 463.0 headed_towards -2224.0 462.0 -2233.0 463.0 headed_towards -2224.0 462.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2280.0 590.0 -2243.0 621.0 spawn_policeA_at -2221.0 568.0 headed_towards -2260.0 568.0 -2221.0 568.0 headed_towards -2260.0 568.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2235.0 537.0 -2217.0 552.0 spawn_policeA_at -2196.0 569.0 headed_towards -2233.0 569.0 -2196.0 569.0 headed_towards -2233.0 569.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2327.0 391.0 -2326.0 417.0 spawn_policeA_at -2332.0 439.0 headed_towards -2310.0 416.0 -2332.0 439.0 headed_towards -2310.0 416.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2442.0 421.0 -2419.0 424.0 spawn_policeA_at -2468.0 420.0 headed_towards -2450.0 403.0 -2468.0 420.0 headed_towards -2450.0 403.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2488.0 427.0 -2458.0 429.0 spawn_policeA_at -2517.0 434.0 headed_towards -2496.0 450.0 -2517.0 434.0 headed_towards -2496.0 450.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2549.0 307.0 -2528.0 329.0 spawn_policeA_at -2558.0 339.0 headed_towards -2540.0 339.0 -2558.0 339.0 headed_towards -2540.0 339.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2592.0 379.0 -2577.0 390.0 spawn_policeA_at -2610.0 407.0 headed_towards -2608.0 381.0 -2610.0 407.0 headed_towards -2608.0 381.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -2636.0 279.0 -2618.0 307.0 spawn_policeA_at -2639.0 331.0 headed_towards -2608.0 324.0 -2566.0 345.0 headed_towards -2605.0 351.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -2651.0 326.0 -2630.0 341.0 spawn_policeA_at -2661.0 359.0 headed_towards -2660.0 336.0 -2665.0 362.0 headed_towards -2665.0 330.0 
04F8: define_police_trigger_type 5 if_player_with_wanted_level_in_rectangle -2741.0 361.0 -2697.0 390.0 spawn_policeA_at -2714.0 342.0 headed_towards -2708.0 344.0 -2711.0 347.0 headed_towards -2706.0 360.0 
04F8: define_police_trigger_type 6 if_player_with_wanted_level_in_rectangle -2616.0 392.0 -2597.0 416.0 spawn_policeA_at -2578.0 388.0 headed_towards -2606.0 386.0 -2570.0 346.0 headed_towards -2606.0 350.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2653.0 326.0 -2634.0 346.0 spawn_policeA_at -2609.0 359.0 headed_towards -2609.0 327.0 -2609.0 359.0 headed_towards -2609.0 327.0 
04F8: define_police_trigger_type 3 if_player_with_wanted_level_in_rectangle -2779.0 279.0 -2777.0 303.0 spawn_policeA_at -2806.0 256.0 headed_towards -2807.0 289.0 -2806.0 256.0 headed_towards -2807.0 289.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2829.0 -375.0 -2806.0 -347.0 spawn_policeA_at -2789.0 -328.0 headed_towards -2816.0 -327.0 -2789.0 -328.0 headed_towards -2816.0 -327.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -2823.0 -305.0 -2802.0 -283.0 spawn_policeA_at -2782.0 -328.0 headed_towards -2814.0 -327.0 -2782.0 -328.0 headed_towards -2814.0 -327.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1555.0 2574.0 -1536.0 2588.0 spawn_policeA_at -1524.0 2604.0 headed_towards -1549.0 2604.0 -1524.0 2604.0 headed_towards -1549.0 2604.0 
04F8: define_police_trigger_type 2 if_player_with_wanted_level_in_rectangle -1506.0 2616.0 -1486.0 2625.0 spawn_policeA_at -1470.0 2604.0 headed_towards -1496.0 2604.0 -1470.0 2604.0 headed_towards -1496.0 2604.0 
04F8: define_police_trigger_type 7 if_player_with_wanted_level_in_rectangle 2573.0 35.0 2603.0 49.0 spawn_policeA_at 2534.0 90.0 headed_towards 2534.0 46.0 2533.0 1.0 headed_towards 2534.0 40.0" );
                }
                if( OriginalSetup.enableDefaultUniqueJumps ) {
                    AppendLine( @"0814: define_unique_jump_start 1939.136 -1968.052 17.6649 radius 2.5 2.728 3.17 in_air_goal 1989.958 -1971.951 28.7249 radius 11.134 5.398 7.23 camera 1960.545 -1963.571 25.3229 reward 500 
0814: define_unique_jump_start 2209.275 -1843.686 19.0964 radius 2.5 4.28 3.83 in_air_goal 2215.124 -1889.359 17.7864 radius 15.36 7.01 11.05 camera 2203.34 -1861.524 21.8367 reward 500 
0814: define_unique_jump_start 1177.215 -1696.761 21.368 radius 2.22 2.5 5.1 in_air_goal 1177.972 -1626.719 32.8079 radius 18.2 7.23 12.36 camera 1182.92 -1659.431 29.1115 reward 500 
0814: define_unique_jump_start 2278.29 -1357.857 31.3255 radius 2.5 2.5 3.96 in_air_goal 2275.299 -1310.756 30.9555 radius 10.69 2.5 9.36 camera 2271.681 -1331.282 32.6621 reward 500 
0814: define_unique_jump_start 2335.351 -2163.947 18.5147 radius 3.52 2.5 3.44 in_air_goal 2344.419 -2178.703 24.2546 radius 15.64 3.05 11.96 camera 2336.89 -2190.321 22.4292 reward 500 
0814: define_unique_jump_start 2825.933 -1582.66 18.126 radius 2.5 4.22 4.92 in_air_goal 2787.504 -1569.318 27.776 radius 2.704 19.16 14.15 camera 2805.121 -1579.892 20.7985 reward 500 
0814: define_unique_jump_start 2460.177 -2567.911 18.8162 radius 2.5 2.5 3.65 in_air_goal 2464.206 -2597.455 25.8862 radius 8.89 0.82 6.26 camera 2454.878 -2593.787 23.9707 reward 500 
0814: define_unique_jump_start 1832.453 -2386.805 17.9247 radius 2.5 2.5 3.01 in_air_goal 1833.612 -2372.385 17.9247 radius 6.57 0.5 6.65 camera 1840.288 -2367.095 19.4731 reward 500 
0814: define_unique_jump_start 1839.745 -2514.477 16.1769 radius 2.5 2.34 2.77 in_air_goal 1921.679 -2517.896 20.6069 radius 2.512 6.42 8.6999 camera 1879.752 -2529.894 22.7841 reward 500 
0814: define_unique_jump_start 2634.397 -2107.984 17.0887 radius 4.172 2.5 5.06 in_air_goal 2595.646 -2109.055 25.7387 radius 9.592 4.178 6.1 camera 2608.7 -2117.174 21.6272 reward 500 
0814: define_unique_jump_start 2352.3 -1259.068 28.9962 radius 2.5 2.5 2.76 in_air_goal 2298.204 -1257.677 28.7062 radius 2.62 20.04 9.96 camera 2312.838 -1265.614 37.7793 reward 500 
0814: define_unique_jump_start 1013.163 -1270.362 24.4456 radius 2.0 2.0 4.05 in_air_goal 1045.359 -1273.475 32.9636 radius 2.0 14.304 13.14 camera 1037.356 -1264.502 25.3721 reward 500 
0814: define_unique_jump_start -973.357 -223.2307 53.3717 radius 5.35 29.1299 15.98 in_air_goal -1116.028 -211.0103 30.6016 radius 49.9398 32.2599 27.0399 camera -1038.667 -187.1254 54.0 reward 500 
0814: define_unique_jump_start -2637.069 780.3949 50.0166 radius 6.76 2.52 9.29 in_air_goal -2639.577 733.2753 44.1565 radius 9.91 2.52 9.29 camera -2633.359 757.9172 52.0809 reward 500 
0814: define_unique_jump_start -2520.199 1169.203 59.5525 radius 6.54 3.09 5.97 in_air_goal -2520.199 1202.12 53.4025 radius 33.5399 6.21 17.66 camera -2513.778 1193.925 57.4115 reward 500 
0814: define_unique_jump_start -1794.982 1211.612 35.6794 radius 3.02 2.58 4.75 in_air_goal -1795.802 1258.197 32.5394 radius 19.51 5.13 19.69 camera -1797.49 1238.395 37.9679 reward 500 
0814: define_unique_jump_start -2659.551 1533.67 53.2004 radius 2.5 2.62 4.73 in_air_goal -2659.551 1551.645 45.5003 radius 7.26 11.79 18.54 camera -2658.426 1531.631 60.6476 reward 500 
0814: define_unique_jump_start -1690.662 1110.392 57.2776 radius 2.3 2.98 5.08 in_air_goal -1662.512 1110.392 57.2776 radius 2.3 18.12 12.26 camera -1649.676 1114.14 50.8559 reward 500 
0814: define_unique_jump_start -2145.461 -112.0259 44.3452 radius 7.24 3.3 5.49 in_air_goal -2146.82 -89.4659 54.3752 radius 4.36 3.3 14.28 camera -2141.051 -89.1471 45.6462 reward 500 
0814: define_unique_jump_start -267.7739 2662.036 68.7405 radius 3.53 4.02 6.0 in_air_goal -237.1135 2661.936 79.7505 radius 7.28 12.06 8.14 camera -253.199 2654.016 72.7989 reward 500 
0814: define_unique_jump_start -249.6904 2590.805 66.1194 radius 3.68 2.96 3.96 in_air_goal -249.6904 2575.325 66.1194 radius 12.66 5.21 9.68 camera -256.2141 2555.207 64.5246 reward 500 
0814: define_unique_jump_start -871.5031 2308.79 164.5739 radius 3.39 2.87 4.86 in_air_goal -981.079 2300.913 111.7538 radius 18.77 40.02 69.5898 camera -905.3314 2315.064 163.7206 reward 500 
0814: define_unique_jump_start 2073.713 2366.653 50.8534 radius 5.54 3.45 2.18 in_air_goal 2050.73 2313.709 31.8133 radius 29.69 11.19 26.09 camera 2077.486 2318.872 26.9287 reward 500 
0814: define_unique_jump_start 2170.947 2402.609 62.2905 radius 2.78 3.59 3.62 in_air_goal 2183.67 2402.609 62.2905 radius 4.92 9.2 9.8 camera 2232.11 2387.587 50.9115 reward 500 
0814: define_unique_jump_start 2418.056 1353.234 12.3641 radius 2.2 5.014 3.98 in_air_goal 2481.923 1346.354 25.664 radius 5.01 19.984 11.63 camera 2462.313 1362.702 19.7672 reward 500 
0814: define_unique_jump_start 2407.308 1364.379 14.5734 radius 5.16 2.72 6.0 in_air_goal 2399.12 1386.524 25.4934 radius 18.57 4.61 11.62 camera 2412.772 1392.431 22.3043 reward 500 
0814: define_unique_jump_start 2784.763 2208.72 15.1934 radius 3.05 1.76 4.33 in_air_goal 2738.984 2208.72 21.8434 radius 3.24 24.23 16.15 camera 2758.656 2201.665 18.3639 reward 500 
0814: define_unique_jump_start 1482.383 2037.004 17.0576 radius 2.09 2.69 5.58 in_air_goal 1482.875 2077.978 23.8776 radius 3.284 4.09 7.07 camera 1489.125 2065.024 20.6514 reward 500 
0814: define_unique_jump_start 1976.397 2593.686 17.2126 radius 3.67 2.0 5.44 in_air_goal 2041.191 2593.686 30.4425 radius 5.05 32.8 20.5 camera 2007.676 2596.314 28.1338 reward 500 
0814: define_unique_jump_start 1636.264 2399.712 15.8903 radius 2.5 2.5 5.08 in_air_goal 1636.264 2449.071 15.8903 radius 21.33 2.0 13.95 camera 1642.17 2440.29 18.5118 reward 500 
0814: define_unique_jump_start 2119.23 2385.213 33.7094 radius 2.1 3.36 2.6 in_air_goal 2151.891 2385.601 30.8958 radius 3.51 13.42 9.04 camera 2128.102 2392.048 32.2357 reward 500 
0814: define_unique_jump_start -2082.529 -2498.932 33.9682 radius 2.34 2.4 3.55 in_air_goal -2110.031 -2479.709 40.8882 radius 4.42 4.08 5.94 camera -2101.418 -2496.468 37.1704 reward 500 
0814: define_unique_jump_start 2112.408 97.9 39.993 radius 5.64 10.28 8.05 in_air_goal 2152.117 91.33 39.993 radius 14.95 26.95 16.22 camera 2149.933 76.6566 44.9509 reward 500 
0814: define_unique_jump_start -2100.413 -1743.595 199.7312 radius 2.94 4.27 4.96 in_air_goal -2082.491 -1718.923 199.7312 radius 10.8 9.39 17.62 camera -2096.167 -1714.572 201.0246 reward 500 
0814: define_unique_jump_start -2287.671 -2800.779 22.0541 radius 5.81 13.66 5.57 in_air_goal -2255.133 -2800.779 22.0541 radius 12.56 28.68 14.69 camera -2253.319 -2814.645 22.8247 reward 500 
0814: define_unique_jump_start 110.8902 2428.049 23.7936 radius 3.58 3.15 4.2 in_air_goal 132.64 2445.781 32.7336 radius 4.38 16.62 15.35 camera 119.7758 2449.64 27.7167 reward 500 
0814: define_unique_jump_start -894.4963 2693.199 44.7303 radius 3.58 2.63 2.44 in_air_goal -941.4026 2662.939 55.7302 radius 29.14 16.02 19.74 camera -931.5991 2647.995 51.4501 reward 500 
0814: define_unique_jump_start 89.9936 -243.2046 7.5581 radius 3.96 4.46 4.48 in_air_goal 101.5435 -255.4345 7.5581 radius 7.39 11.31 14.99 camera 87.0604 -266.0403 9.8153 reward 500 
0814: define_unique_jump_start 160.7991 -160.2479 6.1453 radius 2.12 1.452 2.23 in_air_goal 171.8147 -162.405 12.321 radius 2.0 7.2 7.18 camera 183.2545 -151.314 13.5961 reward 500 
0814: define_unique_jump_start -72.3 17.7 8.4132 radius 2.81 2.4 4.48 in_air_goal -65.1154 35.7188 16.6432 radius 7.71 2.0 7.27 camera -70.4781 55.8289 15.0868 reward 500 
0814: define_unique_jump_start -39.7989 53.3007 6.9223 radius 3.15 2.76 2.35 in_air_goal -36.4289 76.6106 6.9223 radius 12.51 4.48 9.67 camera -42.5507 77.3671 7.8899 reward 500 
0814: define_unique_jump_start 638.7504 -520.0714 18.8519 radius 2.0 2.15 2.34 in_air_goal 639.8602 -545.0903 22.7619 radius 10.97 3.01 8.26 camera 629.1661 -542.9603 24.9594 reward 500 
0814: define_unique_jump_start 1749.723 779.6028 13.4757 radius 1.68 2.616 2.164 in_air_goal 1749.723 825.0914 14.2657 radius 10.718 2.616 5.824 camera 1744.046 799.4149 12.6554 reward 500 
0814: define_unique_jump_start 110.2446 -257.9929 6.2739 radius 3.36 3.32 2.93 in_air_goal 92.4846 -245.6928 11.0439 radius 8.43 6.92 3.99 camera 92.9552 -254.6195 10.1539 reward 500 
0814: define_unique_jump_start 2125.642 95.2542 37.3959 radius 3.83 4.09 2.57 in_air_goal 2098.51 99.5841 35.8559 radius 3.83 8.46 5.72 camera 2116.393 88.0306 40.2113 reward 500 
0814: define_unique_jump_start -344.6466 -9.8812 44.9609 radius 14.26 3.45 3.8 in_air_goal -336.1166 28.7688 37.7609 radius 16.09 4.55 6.29 camera -358.2565 15.6353 41.7241 reward 500 
0814: define_unique_jump_start -2589.18 1164.37 59.8256 radius 2.84 2.77 2.23 in_air_goal -2567.125 1231.183 47.0362 radius 18.9 9.04 6.05 camera -2576.06 1209.225 53.549 reward 500 
0814: define_unique_jump_start -2292.044 1097.71 84.7347 radius 2.082 2.074 2.02 in_air_goal -2350.591 1101.928 64.1846 radius 4.522 14.204 9.03 camera -2323.731 1106.665 77.177 reward 500 
0814: define_unique_jump_start -2408.285 723.2977 38.6835 radius 2.62 2.5 1.69 in_air_goal -2408.285 723.2977 38.6835 radius 22.41 2.58 4.06 camera -2407.981 716.5809 38.4334 reward 500 
0814: define_unique_jump_start -2116.356 925.6832 87.819 radius 2.68 1.99 2.48 in_air_goal -2069.565 925.433 76.689 radius 2.68 15.26 14.46 camera -2085.629 935.5674 85.4677 reward 500 
0814: define_unique_jump_start -1903.192 223.3468 37.7965 radius 1.75 1.84 1.7 in_air_goal -1874.382 223.3467 42.4064 radius 1.75 8.13 4.67 camera -1897.039 219.1329 39.911 reward 500 
0814: define_unique_jump_start -1687.323 -162.201 17.8603 radius 2.68 3.19 2.2 in_air_goal -1722.537 -126.391 14.9903 radius 9.09 7.13 13.07 camera -1716.878 -142.6182 14.6114 reward 500 
0814: define_unique_jump_start -1729.924 -364.5276 18.2246 radius 2.268 2.51 2.148 in_air_goal -1777.487 -364.2776 17.9446 radius 2.268 15.33 7.068 camera -1745.84 -355.4089 14.2197 reward 500 
0814: define_unique_jump_start -1972.099 -543.0899 38.9862 radius 1.96 2.01 1.77 in_air_goal -1912.318 -543.0899 45.3462 radius 7.58 14.78 8.69 camera -1942.915 -539.1157 40.2453 reward 500 
0814: define_unique_jump_start 2770.214 -1177.477 70.7527 radius 2.344 1.99 2.172 in_air_goal 2814.468 -1182.996 55.7938 radius 5.94 17.38 31.52 camera 2766.031 -1184.692 74.9193 reward 500 
0814: define_unique_jump_start 2248.838 -2463.258 15.1049 radius 5.18 2.26 2.59 in_air_goal 2247.468 -2432.427 21.8068 radius 12.44 2.26 9.32 camera 2240.757 -2446.201 16.8109 reward 500 
0814: define_unique_jump_start 2248.832 -2627.623 15.1806 radius 4.862 2.144 2.556 in_air_goal 2248.832 -2655.498 21.2585 radius 8.68 2.144 8.498 camera 2237.695 -2650.768 16.3791 reward 500 
0814: define_unique_jump_start 2326.122 -1508.751 27.0066 radius 2.242 1.728 2.08 in_air_goal 2286.813 -1508.732 30.3748 radius 3.86 9.38 8.99 camera 2299.404 -1514.596 29.8683 reward 500 
0814: define_unique_jump_start 1623.574 -1110.956 61.8178 radius 1.656 2.014 1.836 in_air_goal 1623.574 -1079.265 61.8178 radius 17.246 2.014 22.1459 camera 1615.633 -1093.8 64.8724 reward 500 
0814: define_unique_jump_start 1679.646 -962.2209 65.6737 radius 1.694 2.49 1.94 in_air_goal 1679.646 -988.7401 65.6737 radius 13.124 2.49 16.74 camera 1683.881 -977.1464 65.7485 reward 500 
0814: define_unique_jump_start 1667.167 -992.8579 32.7591 radius 6.32 3.768 2.48 in_air_goal 1675.805 -1008.297 32.7591 radius 18.7479 2.438 9.79 camera 1689.156 -1013.63 35.6715 reward 500 
0814: define_unique_jump_start 347.0 -1662.299 35.8218 radius 3.12 2.65 2.61 in_air_goal 351.6596 -1700.264 35.8218 radius 19.91 4.13 29.76 camera 337.9746 -1676.993 36.7335 reward 500 
0814: define_unique_jump_start 743.1525 -1132.819 25.7991 radius 1.834 3.606 2.35 in_air_goal 710.0014 -1132.989 25.7991 radius 1.834 11.096 10.0 camera 717.1129 -1136.549 25.5161 reward 500 
0814: define_unique_jump_start 1395.562 -1460.566 12.3906 radius 1.672 1.97 1.75 in_air_goal 1402.96 -1447.466 17.7266 radius 10.062 1.97 5.15 camera 1395.023 -1450.836 17.1621 reward 500 
0814: define_unique_jump_start 1586.489 312.8876 23.9965 radius 2.15 6.38 1.99 in_air_goal 1540.208 325.3573 28.9665 radius 2.15 32.8899 11.37 camera 1562.912 331.3251 23.6496 reward 500 
0814: define_unique_jump_start 2058.1 -2677.517 15.4946 radius 3.1 2.48 2.6 in_air_goal 2009.261 -2677.517 20.8946 radius 1.93 16.5499 11.26 camera 2036.566 -2685.281 13.2053 reward 500 
0814: define_unique_jump_start 586.0102 -1773.769 15.2312 radius 2.0 2.27 1.78 in_air_goal 627.7189 -1781.119 22.6912 radius 2.0 7.06 9.94 camera 598.5319 -1778.481 17.0529 reward 500 
0814: define_unique_jump_start 2172.078 2430.507 61.747 radius 2.12 3.3 2.35 in_air_goal 2191.592 2436.304 53.057 radius 2.5 12.57 25.22 camera 2227.234 2436.885 37.788 reward 500 
0814: define_unique_jump_start 2176.133 2268.196 13.4683 radius 2.286 1.934 1.938 in_air_goal 2137.272 2268.246 16.7183 radius 2.286 10.554 6.458 camera 2148.601 2264.892 13.6634 reward 500 
0814: define_unique_jump_start -2213.773 -311.0786 38.5339 radius 1.15 3.04 2.59 in_air_goal -2213.773 -327.8282 44.6738 radius 10.374 3.04 5.93 camera -2215.977 -325.7729 42.5119 reward 500 " );
                }
                if( OriginalSetup.enableDefaultRestartPoints ) {
                    AppendLine( @"016C: restart_if_wasted_at 2027.77 -1420.52 15.99 angle 137.0 town_number 0 
016C: restart_if_wasted_at 1180.85 -1325.57 12.58 angle 271.4 town_number 0 
016D: restart_if_busted_at 1550.68 -1675.49 14.51 angle 90.0 town_number 0 
016C: restart_if_wasted_at 1244.437 331.2261 18.5547 angle 7.5465 town_number 1 
016D: restart_if_busted_at 632.2344 -571.7104 15.3515 angle 267.2 town_number 1 
016C: restart_if_wasted_at -2199.719 -2308.075 29.6181 angle 322.8928 town_number 1 
016D: restart_if_busted_at -2163.829 -2387.817 29.625 angle 134.2066 town_number 1 
016C: restart_if_wasted_at -2670.285 616.4364 13.4531 angle 183.1042 town_number 1 
016D: restart_if_busted_at -1605.792 716.8598 11.0241 angle 355.2978 town_number 1 
016C: restart_if_wasted_at -316.3832 1056.045 18.7344 angle 1.6017 town_number 2 
016D: restart_if_busted_at -212.1889 979.4168 18.3219 angle 278.0478 town_number 2 
016C: restart_if_wasted_at -1514.823 2527.119 54.7443 angle 2.3546 town_number 2 
016D: restart_if_busted_at -1393.072 2633.116 54.9491 angle 86.0424 town_number 2 
016C: restart_if_wasted_at 1578.446 1770.682 9.8358 angle 99.7567 town_number 2 
016D: restart_if_busted_at 2337.083 2453.802 13.9765 angle 90.7643 town_number 2" );
                }
                if( OriginalSetup.enableEmmetsGun ) {
                    RadarMarker emmetsGunMarker = Script.global();
                    Pickup emmetsGunPickup = Script.global();
                    emmetsGunMarker.create_short_range( RadarIconID.EMMET, 2447.364, -1974.496, 12.5469 ).set_radar_mode( 2 );
                    emmetsGunPickup.create_with_ammo( WeaponModel.COLT45, 15, 16, 2447.773, -1975.663, 13.0 );
                }
                ushort totalDefaultPickups = 0;
                if( OriginalSetup.enableDefaultArmourPickups )
                    totalDefaultPickups += 47;
                if( OriginalSetup.enableDefaultBribePickups )
                    totalDefaultPickups += 49;
                if( OriginalSetup.enableDefaultMeleeWeaponPickups )
                    totalDefaultPickups += 117;
                if( OriginalSetup.enableDefaultWeaponPickups )
                    totalDefaultPickups += 132;
                if( totalDefaultPickups > 0 ) {
                    ushort counterPickups = 0;
                    Array<Pickup> arrayPickups = global_array( totalDefaultPickups );
                    Int tmp_arrayPickups = global( arrayPickups.startIndex );
                    if( OriginalSetup.enableDefaultArmourPickups ) {
                        AppendLine( @"" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2097.0, 2154.0, 14.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2435.0, 1663.0, 16.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2500.0, 925.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2106.0, 1004.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1531.0, 925.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1433.0, 1852.0, 10.8)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1000.0, 1068.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1269.0, 1352.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2294.0, 547.0, 1.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2543.0, -1625.0, 12.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2339.0, -1944.0, 13.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2767.0, -1192.0, 69.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2112.0, -1990.0, 14.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2544.0, -1120.0, 62.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1562.0, -1888.0, 14.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1086.0, -1806.0, 17.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 253.0, 80.0, 1004.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1759.0, -2242.0, 1.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2650.0, -198.0, 4.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2285.0, -24.0, 35.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -1863.0, 112.0, 15.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -1574.0, 1268.0, 1.27)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2916.0, 992.0, 8.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2513.0, 770.0, 35.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -1394.0, -373.0, 6.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2303.0, -1606.0, 484.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2092.0, -2330.0, 31.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -2260.0, 2568.0, 6.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -902.0, 2689.0, 42.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -317.0, 2651.0, 67.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1325.0, 190.0, 19.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2487.0, 139.0, 27.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 761.0, 380.0, 23.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, -51.0, -232.0, 7.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 252.0, 2616.0, 17.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 212.0, 1807.0, 22.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1291.76, -803.4566, 1089.93)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 1715.12, -1673.51, 20.22)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 943.012, -939.8284, 57.7345)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 275.169, 1859.699, 9.81)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 3, 1268.34, -804.33, 1084.01)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 263.52, 83.14, 1001.039)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 264.2632, 117.0737, 1008.813)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 245.0618, 195.9429, 1008.172)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 215.8489, 126.0831, 1003.226)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2125.493, -2275.037, 20.5202)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BODYARMOUR, 15, 2230.45, -2286.004, 14.3751)" );
                    }
                    if( OriginalSetup.enableDefaultBribePickups ) {
                        AppendLine( @"" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2743.0, 1316.0, 8.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2168.66, 2267.96, 15.34)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2408.0, 1389.0, 22.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2034.0, 842.0, 10.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2096.0, 1287.0, 10.8)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1987.0, 1543.0, 16.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1854.0, 912.0, 10.8)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2540.38, 2527.85, 10.39)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1548.02, 1024.47, 10.39)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1592.91, 2053.83, 10.26)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1971.29, 2330.26, 10.41)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1700.74, 1792.7, 10.41)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2581.0, -1491.0, 24.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2296.0, -1696.0, 14.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2273.0, -1099.0, 38.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2716.0, -1048.0, 66.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2614.0, -2496.0, 33.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1183.85, -1250.68, 14.7)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1970.0, -1158.0, 21.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 734.0, -1137.0, 18.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 2553.76, -2464.31, 13.62)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1204.06, -1613.89, 13.28)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 611.21, -1459.63, 14.01)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1116.67, -719.91, 100.17)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -1903.1, -466.44, 25.18)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2657.0, -144.0, 4.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2454.0, -166.0, 35.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2009.0, 1227.0, 32.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2120.0, 96.39, 39.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2411.0, -334.0, 37.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -1690.0, 450.0, 13.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -1991.26, -1144.13, 29.69)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2636.13, -492.83, 70.09)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2022.68, 345.98, 35.17)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2683.2, 784.13, 49.98)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -1820.67, -154.12, 9.4)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -736.0, 66.0, 24.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 262.33, -149.12, 1.58)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 1643.0, 264.0, 20.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 601.98, 2150.38, 39.41)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -1407.0, -2039.0, 1.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2156.0, -2371.0, 31.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -419.25, 1362.36, 12.21)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 629.04, 2842.83, 25.21)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 690.49, -209.59, 25.6)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 88.82, -125.1, 0.85)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, 215.69, 1089.1, 16.4)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -2305.24, 2310.11, 4.98)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRIBE, 15, -213.61, 2717.44, 62.68)" );
                    }
                    if( OriginalSetup.enableDefaultMeleeWeaponPickups ) {
                        AppendLine( @"" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#POOLCUE, 15, 2854.0, 944.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#POOLCUE, 15, -2135.0, 197.0, 35.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#POOLCUE, 15, 294.0, -188.0, 2.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, 2241.0, 2425.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, 259.0, 80.0, 1004.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, -2222.0, -302.0, 43.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, 223.8347, 120.4458, 1010.212)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, 247.4536, 192.3085, 1008.172)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, 188.9769, 158.218, 1003.031)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#NITESTICK, 15, 911.6486, -1235.39, 17.6802)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GOLFCLUB, 15, 1418.0, 2774.0, 15.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GOLFCLUB, 15, 1457.0, -792.0, 90.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GOLFCLUB, 15, -2715.0, -314.0, 7.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GOLFCLUB, 15, -2227.0, -2401.0, 31.4)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 637.0, 832.0, -43.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 1393.0, 2174.0, 10.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 2459.0, -1708.0, 13.6)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 1997.0, 1658.0, 12.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, -2796.416, 123.686, 6.844)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, -532.0, -106.0, 63.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, -1809.0, -1662.0, 24.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 2240.0, -83.0, 27.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 842.9783, -17.3791, 64.2)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#SHOVEL, 15, 1888.27, 2877.262, 10.1621)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, 1061.0, 2074.0, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, 2371.0, -2543.0, 3.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, 2192.243, -1988.751, 13.4185)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, -2083.0, 298.0, 42.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, -2359.0, -82.0, 35.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, -761.0, -126.0, 66.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, 680.0, 826.0, -39.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, 752.0, 260.0, 27.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#CHNSAW, 15, -2752.243, -272.2891, 6.5956)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, 2057.0, 2434.0, 166.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, 1528.222, -1357.985, 330.0371)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, -2350.0, -1586.0, 485.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, -1542.857, 698.4825, 139.2658)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, -225.6758, 1394.256, 172.0143)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, -773.0379, 2423.499, 157.0856)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, -2679.0, 1933.0, 217.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_PARA, 15, -1753.418, 885.3446, 295.5166)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, 2000.0, 1526.0, 15.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, 1862.0, -1862.0, 14.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, -2208.0, 696.0, 50.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, -2535.631, 51.7034, 8.6512)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, -1568.0, 2718.0, 56.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, 2631.263, 1722.395, 11.0312)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KATANA, 15, 2002.263, 981.3947, 10.5)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KNIFECUR, 15, 1124.0, -1335.0, 13.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KNIFECUR, 15, -1871.0, 351.0, 26.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KNIFECUR, 15, -23.0, 2322.0, 24.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#KNIFECUR, 15, 777.8668, 1948.123, 5.3634)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRASSKNUCKLE, 15, 1339.0, -1765.0, 14.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRASSKNUCKLE, 15, -2206.0, 961.0, 80.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRASSKNUCKLE, 15, -246.0, 2725.0, 63.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BRASSKNUCKLE, 15, 2428.499, -1679.27, 13.1633) 
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BAT, 15, -2306.0, 93.0, 35.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BAT, 15, 1308.466, 2111.289, 10.7221)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#BAT, 15, 1081.133, 1603.697, 5.6)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2677.726, -192.3469, 6.8518)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2617.473, -97.0801, 4.003)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2777.192, -25.2984, 6.8721)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2774.113, 87.8845, 6.7987)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2770.624, 389.0772, 4.2818)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2530.958, -34.1009, 25.2855)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -1691.649, 946.7679, 24.8084)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -2664.518, 636.5673, 14.2474)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -377.2184, -1048.053, 58.9125)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, -45.5928, -1148.529, 1.3953)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 1296.155, -1081.892, 26.1502)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 1390.611, -800.4332, 81.7795)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 2183.116, 2396.827, 10.7722)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 1420.945, 2519.882, 10.6199)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 1372.996, 2605.758, 10.8776)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 2490.497, 1522.47, 10.576)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_CANE, 15, 455.4583, -1485.896, 30.9717)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1928.68, -1774.21, 13.54)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1875.91, -1917.18, 15.03)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2019.6, -1214.15, 21.47)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2209.77, -1001.69, 63.71)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1000.34, -1858.58, 12.3)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 911.11, -1120.31, 24.03)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 929.0, -750.0, 105.82)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1129.09, -2052.82, 69.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -92.74, -1425.46, 12.75)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -77.65, -1167.18, 2.16)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 34.0, -2649.0, 40.73)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -739.0, -1262.0, 68.12)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2177.0, -2423.0, 30.63)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -615.0, -861.0, 105.72)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2051.0, 948.0, 55.4)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2658.0, -187.0, 4.18)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2649.0, 734.97, 27.96)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -1791.0, 481.0, 25.68)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2797.0, 1182.0, 20.28)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2589.623, -16.165, 3.9662)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2865.0, 690.0, 23.43)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2339.0, -453.0, 80.24)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -1955.0, -748.0, 36.22)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2420.03, 987.59, 45.3)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -326.56, 2215.37, 43.57)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -1319.0, 2705.0, 50.27)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -2474.94, 2443.52, 16.03)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -1670.64, 2590.49, 81.37)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, -892.98, 1971.66, 60.61)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1576.86, 2837.14, 10.83)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1492.72, 2773.76, 10.81)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2642.03, 1125.74, 11.03)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2025.24, 661.6, 10.93)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2181.82, 1484.97, 11.36)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2197.02, 2476.33, 11.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2212.0, 2526.0, 10.81)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2715.79, 1109.47, 6.7)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 2489.25, 918.28, 11.02)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#FLOWERA, 15, 1472.08, 1890.09, 10.81)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_DILDO2, 15, -2401.0, 2360.0, 5.0)
" + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = Pickup.Create(#GUN_DILDO1, 15, 261.0, 71.0, 1003.0)" );
                    }
                    if( OriginalSetup.enableDefaultWeaponPickups ) {
                        AppendLine( @"032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2677.102 234.9912 4.1048 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2706.692 375.8728 5.0525 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2550.106 657.286 14.7319 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2791.248 771.5468 51.0904 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1770.815 903.2556 25.3894 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1713.006 1368.239 7.2664 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1851.317 1302.291 60.7553 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1635.026 604.4713 40.6377 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1976.483 670.5043 46.6039 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2038.409 1111.406 53.7928 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2048.803 899.5274 53.8866 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -2292.47 722.5441 49.4265 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1977.916 113.8457 27.1096 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1528.144 160.0232 3.5142 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at -1771.261 -597.5884 16.6287 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CAMERA type 15 ammo 50 at 2495.807 -1700.637 1017.837 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FIRE_EX type 15 ammo 3000 at 2148.0 2721.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FIRE_EX type 15 ammo 3000 at -1700.0 415.0 7.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FIRE_EX type 15 ammo 3000 at -1627.0 -2692.0 49.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FIRE_EX type 15 ammo 3000 at -742.0 2752.0 47.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at 2538.0 -1630.0 14.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at 338.0 -1875.0 4.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at -2206.0 -23.0 35.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at -639.0 1181.0 13.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at 255.0493 84.0615 1002.453 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at 263.2531 109.7859 1004.625 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at 242.613 196.3202 1008.172 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #COLT45 type 15 ammo 35 at 2423.892 -1117.452 41.2464 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SILENCED type 15 ammo 30 at 1098.0 1681.0 7.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SILENCED type 15 ammo 30 at 1214.0 -1816.0 17.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #DESERT_EAGLE type 15 ammo 30 at 2766.0 -2182.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #DESERT_EAGLE type 15 ammo 30 at -2212.0 109.0 35.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #DESERT_EAGLE type 15 ammo 30 at -1870.0 -1625.0 22.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #DESERT_EAGLE type 15 ammo 30 at 36.0 1372.0 9.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #DESERT_EAGLE type 15 ammo 30 at -2352.0 2456.0 6.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MICRO_UZI type 15 ammo 60 at 1446.35 1900.03 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MICRO_UZI type 15 ammo 60 at 2551.33 -1740.0 6.49 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MICRO_UZI type 15 ammo 60 at -1679.0 1410.0 7.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MICRO_UZI type 15 ammo 60 at -2038.0 -2562.0 31.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MICRO_UZI type 15 ammo 60 at 119.0 2409.0 17.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MICRO_UZI type 15 ammo 60 at 2790.343 -1427.489 39.6258 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at 1761.0 591.0 10.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at 899.8012 -792.078 102.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at 1408.0 -2380.0 14.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at -2665.0 1452.0 7.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at -2092.0 1121.0 54.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at 262.0 38.0 2.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at 2574.065 -1134.201 64.6535 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEC9 type 15 ammo 50 at 2529.724 -1678.563 19.4225 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at 2243.0 1132.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at 1764.0 -1930.0 14.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at 2266.0 -1028.0 59.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at -2678.0 -128.0 4.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at 1296.0 392.0 20.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at -1474.0 2577.0 56.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 130 at 2198.11 -1170.22 33.5
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MP5LNG type 15 ammo 70 at 2293.686 1982.286 31.4335 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 25 at 1569.0 2150.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 25 at 924.0 2138.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 25 at 2428.0 -1214.0 36.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 25 at 2366.0 23.0 28.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 25 at 1706.352 1242.019 34.2952 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 15 at 2254.378 -2261.689 14.3751 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SAWNOFF type 15 ammo 40 at 832.603 -1273.861 14.4833
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at 1345.0 2367.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at -1841.106 -74.2171 14.7606 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at 24.0 969.0 20.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at -932.02 2649.92 42.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at 217.8 76.4 1005.047 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at 228.3176 114.433 999.0215 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CHROMEGUN type 15 ammo 30 at 240.7765 196.1124 1008.172 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SHOTGSPA type 15 ammo 50 at 1407.0 1098.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CUNTGUN type 15 ammo 30 at 1102.0 -661.0 114.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CUNTGUN type 15 ammo 30 at -2094.0 -488.0 36.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #CUNTGUN type 15 ammo 30 at -1035.0 -2258.0 70.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at 733.4333 -1356.47 23.5229 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at 2225.0 2530.0 17.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at 2337.0 1806.0 72.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at 2047.0 -1406.0 68.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at -1629.0 1167.0 24.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at 935.744 -926.0453 57.7642 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SNIPER type 15 ammo 20 at 2015.744 1004.045 39.1 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 2832.0 2405.0 18.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 1781.0 2072.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 2478.0 1182.0 22.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 886.0 -966.0 37.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 2426.0 -1416.0 24.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 2197.0 -2475.0 14.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at 2255.0 -74.0 32.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MOLOTOV type 15 ammo 10 at -170.0 1025.0 20.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #GRENADE type 15 ammo 20 at 2809.0 864.0 21.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #GRENADE type 15 ammo 20 at 2142.0 -1804.0 16.0  
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #GRENADE type 15 ammo 20 at 397.0 -1924.0 8.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #GRENADE type 15 ammo 20 at 2441.0 -1013.0 54.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #GRENADE type 15 ammo 20 at -2520.0 2293.0 5.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #GRENADE type 15 ammo 20 at 2820.013 -1426.519 23.805 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SATCHEL type 15 ammo 15 at -2754.0 -400.0 7.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SATCHEL type 15 ammo 15 at -2542.262 922.2401 67.1221  
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #SATCHEL type 15 ammo 15 at 1284.894 278.5705 19.5547 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEARGAS type 15 ammo 10 at 2725.0 2727.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEARGAS type 15 ammo 10 at 1319.0 1636.0 10.6 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEARGAS type 15 ammo 10 at 2213.0 -2283.0 15.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEARGAS type 15 ammo 10 at 1463.0 -1013.0 27.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #TEARGAS type 15 ammo 10 at -1386.0 509.0 4.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at 1625.0 1944.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at 1923.0 1011.0 22.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at 1308.97 -874.4 40.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at -1968.0 -923.0 32.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at -121.0 -232.0 1.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at -585.0 2714.0 72.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at 2129.4 -2280.71 14.42 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #AK47 type 15 ammo 60 at 825.921 -1165.813 17.8936
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #M4 type 15 ammo 70 at 2575.0 1562.0 16.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #M4 type 15 ammo 70 at 1379.0 -2547.0 14.0
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #M4 type 15 ammo 70 at -2903.0 784.0 35.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #M4 type 15 ammo 70 at 113.0 1811.0 18.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FLAME type 15 ammo 2000 at 2649.0 2733.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FLAME type 15 ammo 2000 at -1579.0 29.45 17.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FLAME type 15 ammo 2000 at -2132.52 189.2507 35.5379 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FLAME type 15 ammo 2000 at -1358.0 -2115.0 30.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #FLAME type 15 ammo 2000 at -601.4012 -1068.6 23.6667 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #ROCKETLA type 15 ammo 10 at 2072.0 2370.0 61.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #ROCKETLA type 15 ammo 10 at 1646.0 1349.0 11.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #ROCKETLA type 15 ammo 10 at 1740.0 -1231.0 92.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #ROCKETLA type 15 ammo 10 at 2055.355 2435.356 40.3684 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #HEATSEEK type 15 ammo 10 at 1155.0 2341.0 17.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #HEATSEEK type 15 ammo 10 at -1126.69 -150.82 14.61 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #HEATSEEK type 15 ammo 10 at -1317.0 2509.0 87.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MINIGUN type 15 ammo 200 at 2676.0 836.0 22.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MINIGUN type 15 ammo 200 at -1496.0 591.0 42.0 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MINIGUN type 15 ammo 200 at 2492.051 2398.377 4.5293 
032B: " + tmp_arrayPickups + @"[" + ( counterPickups++ ) + @"] = create_weapon_pickup #MINIGUN type 15 ammo 200 at 244.98 1859.185 14.08" );
                    }  
                }
                if( OriginalSetup.enableDefaultParkingCars ) {
                    Array<Car> arrayCarPark = global_array( 124 );
                    Int tmp_parked_car = global( arrayCarPark.startIndex );
                    AppendLine( @"09E2: " + tmp_parked_car + @"[0] = parked_car_generator_w_numberplate #GREENWOO colors 59 34 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""GROVE4L_"" at " + tmp_parked_car + @" " + tmp_parked_car + @" " + tmp_parked_car + @" angle " + tmp_parked_car + @" 
09E2: " + tmp_parked_car + @"[1] = parked_car_generator_w_numberplate #PICADOR colors 84 84 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""_SHERM__"" at " + tmp_parked_car + @" " + tmp_parked_car + @" " + tmp_parked_car + @" angle " + tmp_parked_car + @" 
014B: " + tmp_parked_car + @"[2] = init_car_generator #URANUS color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1956.3 297.7 34.3 angle 64.8 
014B: " + tmp_parked_car + @"[3] = init_car_generator #ELEGY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1952.6 265.7 39.9 angle 292.8 
014B: " + tmp_parked_car + @"[4] = init_car_generator #SULTAN color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1957.7 277.0 34.3 angle 133.4 
014B: " + tmp_parked_car + @"[5] = init_car_generator #SAVANNA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1952.8 258.8 39.9 angle 259.1 
014B: " + tmp_parked_car + @"[6] = init_car_generator #STRATUM color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1950.5 259.7 34.3 angle 53.8 
09E2: " + tmp_parked_car + @"[7] = parked_car_generator_w_numberplate #HUSTLER colors 83 1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""HOMEGIRL"" at 2408.156 -1719.463 13.6665 angle 0.5881 
09E2: " + tmp_parked_car + @"[8] = parked_car_generator_w_numberplate #COPCARRU colors -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""_CUFFS__"" at -1399.717 2628.59 55.7823 angle 271.7941 
09E2: " + tmp_parked_car + @"[9] = parked_car_generator_w_numberplate #BANDITO colors -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""FULLAUTO"" at -379.5 -1443.115 25.7266 angle 88.9244 
09E2: " + tmp_parked_car + @"[10] = parked_car_generator_w_numberplate #ROMERO colors 1 1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""_TRAUMA_"" at -2572.04 1148.564 55.7333 angle 337.8434 
09E2: " + tmp_parked_car + @"[11] = parked_car_generator_w_numberplate #CLUB colors 126 1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""_SPANK__"" at 2028.446 2731.102 10.53 angle 268.994 
014B: " + tmp_parked_car + @"[12] = init_car_generator #BMX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2412.52 -1326.49 23.74 angle 177.92 
014B: " + tmp_parked_car + @"[13] = init_car_generator #FORKLIFT color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1969.806 -2443.908 29.767 angle -19.0 
014B: " + tmp_parked_car + @"[14] = init_car_generator #CLOVER color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2445.5 -1340.8 23.5 angle 180.0 
014B: " + tmp_parked_car + @"[15] = init_car_generator #BMX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2499.18 -1648.26 13.0 angle 158.61 
014B: " + tmp_parked_car + @"[16] = init_car_generator #SAVANNA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2685.981 -2016.21 12.5501 angle 0.337 
014B: " + tmp_parked_car + @"[17] = init_car_generator #BLADE color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1772.096 -2125.103 13.0469 angle 0.3441 
014B: " + tmp_parked_car + @"[18] = init_car_generator #SANCHEZ color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2048.856 -2521.276 31.125 angle 171.0232 
014B: " + tmp_parked_car + @"[19] = init_car_generator #SANCHEZ color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 623.3402 887.0944 -43.5625 angle 347.2967 
014B: " + tmp_parked_car + @"[20] = init_car_generator #SANCHEZ color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2486.046 59.184 24.8284 angle 180.0 
014B: " + tmp_parked_car + @"[21] = init_car_generator #SADLER color 51 4 force_spawn 0 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1563.768 2690.873 54.6985 angle 180.0 
014B: " + tmp_parked_car + @"[22] = init_car_generator #GREENWOO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2216.902 -1160.403 24.7265 angle 270.8013 
014B: " + tmp_parked_car + @"[23] = init_car_generator #GREENWOO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2216.902 -1160.403 24.7265 angle 270.8013 
014B: " + tmp_parked_car + @"[24] = init_car_generator #BMX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2229.001 -1173.798 24.7331 angle 90.5569 
014B: " + tmp_parked_car + @"[25] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -540.0441 -1396.147 15.0 angle 0.0 
014B: " + tmp_parked_car + @"[26] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -289.5517 -1389.627 10.0 angle 0.0 
014B: " + tmp_parked_car + @"[27] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -192.9 -1331.307 21.5 angle 0.0 
014B: " + tmp_parked_car + @"[28] = init_car_generator #TRACTOR color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -273.9629 -1507.596 5.0 angle 0.0 
014B: " + tmp_parked_car + @"[29] = init_car_generator #TRACTOR color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -395.1952 -1293.19 30.8 angle 0.0 
014B: " + tmp_parked_car + @"[30] = init_car_generator #TRACTOR color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -186.6494 -1339.215 6.0 angle 0.0 
014B: " + tmp_parked_car + @"[31] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1030.249 -1050.188 129.0 angle 0.0 
014B: " + tmp_parked_car + @"[32] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1169.425 -989.6309 129.0 angle 0.0 
014B: " + tmp_parked_car + @"[33] = init_car_generator #TRACTOR color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1110.79 -947.7925 129.0 angle 0.0 
014B: " + tmp_parked_car + @"[34] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at 16.8768 49.991 3.0 angle 0.0 
014B: " + tmp_parked_car + @"[35] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at 81.051 3.3203 1.5 angle 0.0 
014B: " + tmp_parked_car + @"[36] = init_car_generator #COMBINE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -15.2986 -84.6533 3.0 angle 0.0 
014B: " + tmp_parked_car + @"[37] = init_car_generator #TRACTOR color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at 81.0533 3.3234 1.5 angle 0.0 
09E2: " + tmp_parked_car + @"[38] = parked_car_generator_w_numberplate #BANSHEE colors 79 0 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""__DBP___"" at -2273.2 -130.8 33.9 angle 270.4 
09E2: " + tmp_parked_car + @"[39] = parked_car_generator_w_numberplate #BULLET colors 24 40 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 plate ""_CHUNKY_"" at -2354.6 983.0 49.3 angle 189.4 
014B: " + tmp_parked_car + @"[40] = init_car_generator #MAVERICK color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1544.0 -1352.0 329.0 angle 95.0 
014B: " + tmp_parked_car + @"[41] = init_car_generator #SPARROW color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1963.0 628.0 151.0 angle 182.0 
014B: " + tmp_parked_car + @"[42] = init_car_generator #MAVERICK color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1681.0 705.0 31.0 angle 90.0 
014B: " + tmp_parked_car + @"[43] = init_car_generator #MAVERICK color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2630.0 684.0 72.0 angle 180.0 
014B: " + tmp_parked_car + @"[44] = init_car_generator #RAINDANC color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2726.0 682.0 72.0 angle 90.0 
014B: " + tmp_parked_car + @"[45] = init_car_generator #SEASPAR color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2227.0 2329.0 8.0 angle 180.0 
014B: " + tmp_parked_car + @"[46] = init_car_generator #CARGOBOB color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2619.0 2721.0 37.0 angle 90.0 
014B: " + tmp_parked_car + @"[47] = init_car_generator #MAVERICK color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2092.0 2415.0 75.0 angle 260.0 
014B: " + tmp_parked_car + @"[48] = init_car_generator #DFT30 color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1969.806 -2437.939 29.767 angle -82.5 
014B: " + tmp_parked_car + @"[49] = init_car_generator #HYDRA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1286.0 501.5 18.0 angle 270.0 
014B: " + tmp_parked_car + @"[50] = init_car_generator #SKIMMER color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -959.0813 2629.206 43.229 angle 110.0 
014B: " + tmp_parked_car + @"[51] = init_car_generator #RAINDANC color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 273.0045 -1876.038 5.2935 angle 271.51 
014B: " + tmp_parked_car + @"[52] = init_car_generator #POLMAV color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1561.865 -1701.953 27.948 angle 0.0015 
014B: " + tmp_parked_car + @"[53] = init_car_generator #SKIMMER color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -637.1 1811.953 1.7 angle 180.0015 
014B: " + tmp_parked_car + @"[54] = init_car_generator #DODO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1443.081 -523.2058 13.9929 angle 267.0 
014B: " + tmp_parked_car + @"[55] = init_car_generator #DODO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1363.005 -484.0377 13.9 angle 200.51 
014B: " + tmp_parked_car + @"[56] = init_car_generator #NEVADA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1180.865 -351.9529 13.948 angle 0.0015 
014B: " + tmp_parked_car + @"[57] = init_car_generator #SHAMAL color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1289.1 -353.9529 13.9 angle 219.0015 
014B: " + tmp_parked_car + @"[58] = init_car_generator #SHAMAL color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1253.1 -347.9529 13.9 angle 219.0015 
014B: " + tmp_parked_car + @"[59] = init_car_generator #NEVADA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1387.1 -227.9529 13.9 angle 312.0015 
014B: " + tmp_parked_car + @"[60] = init_car_generator #SHAMAL color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1220.1 -150.9529 13.9 angle 519.0015 
014B: " + tmp_parked_car + @"[61] = init_car_generator #MAVERICK color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1244.674 -599.1741 13.9 angle 48.6377 
014B: " + tmp_parked_car + @"[62] = init_car_generator #LEVIATHN color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1215.1 -6.14 13.9 angle 95.0015 
014B: " + tmp_parked_car + @"[63] = init_car_generator #RAINDANC color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1190.1 22.14 13.9 angle 45.0015 
014B: " + tmp_parked_car + @"[64] = init_car_generator #RUSTLER color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1374.1 -503.14 13.9 angle 249.0015 
014B: " + tmp_parked_car + @"[65] = init_car_generator #HUNTER color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1608.724 286.14 6.22 angle 55.0015 
014B: " + tmp_parked_car + @"[66] = init_car_generator #AT400 color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1586.941 1190.642 10.863 angle 180.0 
014B: " + tmp_parked_car + @"[67] = init_car_generator #BEAGLE color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1285.073 1324.641 11.392 angle 269.5248 
014B: " + tmp_parked_car + @"[68] = init_car_generator #RHINO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 277.55 1989.35 17.21 angle 270.0 
014B: " + tmp_parked_car + @"[69] = init_car_generator #RHINO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 281.23 2022.33 17.21 angle 270.0 
014B: " + tmp_parked_car + @"[70] = init_car_generator #HYDRA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 307.35 1990.25 17.21 angle 320.0 
014B: " + tmp_parked_car + @"[71] = init_car_generator #HYDRA color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 307.35 2031.36 17.21 angle 320.0 
014B: " + tmp_parked_car + @"[72] = init_car_generator #DODO color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1443.081 -523.2058 13.9929 angle 267.0 
014B: " + tmp_parked_car + @"[73] = init_car_generator #DODO color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1363.005 -484.0377 13.9 angle 200.51 
014B: " + tmp_parked_car + @"[74] = init_car_generator #NEVADA color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1180.865 -351.9529 13.948 angle 0.0015 
014B: " + tmp_parked_car + @"[75] = init_car_generator #SHAMAL color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1289.1 -353.9529 13.9 angle 219.0015 
014B: " + tmp_parked_car + @"[76] = init_car_generator #SHAMAL color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1253.1 -347.9529 13.9 angle 219.0015 
014B: " + tmp_parked_car + @"[77] = init_car_generator #NEVADA color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1387.1 -227.9529 13.9 angle 312.0015 
014B: " + tmp_parked_car + @"[78] = init_car_generator #SHAMAL color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1220.1 -150.9529 13.9 angle 519.0015 
014B: " + tmp_parked_car + @"[79] = init_car_generator #MAVERICK color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 100 max_delay 10000 at -1244.674 -599.1741 13.9 angle 48.6377 
014B: " + tmp_parked_car + @"[80] = init_car_generator #LEVIATHN color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1215.1 -6.14 13.9 angle 95.0015 
014B: " + tmp_parked_car + @"[81] = init_car_generator #RAINDANC color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1190.1 22.14 13.9 angle 45.0015 
014B: " + tmp_parked_car + @"[82] = init_car_generator #RUSTLER color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1374.1 -503.14 13.9 angle 249.0015 
014B: " + tmp_parked_car + @"[83] = init_car_generator #BEAGLE color -1 -1 force_spawn 1 alarm 0 door_lock 100 min_delay 0 max_delay 10000 at -1629.28 -236.14 13.9 angle 129.0015 
014B: " + tmp_parked_car + @"[84] = init_car_generator #CADDY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 927.7213 -1185.042 16.5 angle 123.3055 
014B: " + tmp_parked_car + @"[85] = init_car_generator #CADDY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 927.5233 -1182.365 16.5 angle 123.3055 
014B: " + tmp_parked_car + @"[86] = init_car_generator #CADDY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 926.9179 -1178.95 16.5 angle 123.3055 
014B: " + tmp_parked_car + @"[87] = init_car_generator #CADDY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 861.3535 -1240.759 14.5 angle 180.1308 
014B: " + tmp_parked_car + @"[88] = init_car_generator #JOURNEY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 837.7494 -1206.574 16.5 angle 153.2632 
014B: " + tmp_parked_car + @"[89] = init_car_generator #JOURNEY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 897.5168 -1207.991 16.5 angle 86.5989 
014B: " + tmp_parked_car + @"[90] = init_car_generator #JOURNEY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 736.2398 -1334.195 13.5411 angle 267.8109 
014B: " + tmp_parked_car + @"[91] = init_car_generator #JOURNEY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 736.9623 -1343.907 13.5197 angle 273.7721 
014B: " + tmp_parked_car + @"[92] = init_car_generator #SANCHEZ color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2408.511 -2186.024 32.89 angle 321.692 
014B: " + tmp_parked_car + @"[93] = init_car_generator #MTBIKE color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2407.606 -2177.092 32.89 angle 321.692 
014B: " + tmp_parked_car + @"[94] = init_car_generator #JOURNEY color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2338.565 -1593.833 482.9451 angle 20.751 
014B: " + tmp_parked_car + @"[95] = init_car_generator #CAMPER color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2343.37 -1613.943 482.9757 angle 105.53 
014B: " + tmp_parked_car + @"[96] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2213.556 112.7671 34.9203 angle 88.472 
014B: " + tmp_parked_car + @"[97] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2693.386 -139.4564 3.93359 angle 90.0856 
014B: " + tmp_parked_car + @"[98] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2796.468 -94.1788 6.9875 angle 42.6945 
014B: " + tmp_parked_car + @"[99] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2206.051 701.2161 48.9453 angle 183.4174 
014B: " + tmp_parked_car + @"[100] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -810.5599 2430.363 156.9649 angle 336.533 
014B: " + tmp_parked_car + @"[101] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1693.441 432.2852 6.9914 angle 300.903 
014B: " + tmp_parked_car + @"[102] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2116.138 924.8068 85.9791 angle 94.9293 
014B: " + tmp_parked_car + @"[103] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1483.69 2614.835 58.2812 angle 337.9383 
014B: " + tmp_parked_car + @"[104] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1419.698 1947.996 10.9531 angle 6.9689 
014B: " + tmp_parked_car + @"[105] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1567.389 2691.118 10.265 angle 279.9875 
014B: " + tmp_parked_car + @"[106] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2087.367 -2519.016 29.925 angle 90.9178 
014B: " + tmp_parked_car + @"[107] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2615.317 1939.701 10.129 angle 148.1757 
014B: " + tmp_parked_car + @"[108] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1074.964 1395.418 5.303 angle 36.7673 
014B: " + tmp_parked_car + @"[109] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 2615.239 -1731.225 5.9486 angle 140.8213 
014B: " + tmp_parked_car + @"[110] = init_car_generator #KART color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1305.176 -796.6955 83.9477 angle 185.9911 
014B: " + tmp_parked_car + @"[111] = init_car_generator #VORTEX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2294.926 2546.978 5.9175 angle 290.9339 
014B: " + tmp_parked_car + @"[112] = init_car_generator #VORTEX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 714.3436 -1488.273 0.9343 angle 270.0 
014B: " + tmp_parked_car + @"[113] = init_car_generator #VORTEX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -1426.412 506.8391 2.9463 angle 144.61 
014B: " + tmp_parked_car + @"[114] = init_car_generator #VORTEX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1971.92 1560.665 10.9635 angle 262.615 
014B: " + tmp_parked_car + @"[115] = init_car_generator #VORTEX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -535.4126 -60.8884 63.5922 angle 276.9756 
014B: " + tmp_parked_car + @"[116] = init_car_generator #VORTEX color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -910.27 2699.06 42.8 angle 110.8738 
014B: " + tmp_parked_car + @"[117] = init_car_generator #SPARROW color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1291.5 -787.5 95.4555 angle 180.0 
014B: " + tmp_parked_car + @"[118] = init_car_generator #RDTRAIN color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2000.242 -2415.509 29.767 angle -132.0 
014B: " + tmp_parked_car + @"[119] = init_car_generator #DUNERIDE color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1091.89 1612.63 13.0 angle 206.7583 
014B: " + tmp_parked_car + @"[120] = init_car_generator #VOODOO color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at 1772.66 -2096.59 13.99 angle 182.7583 
014B: " + tmp_parked_car + @"[121] = init_car_generator #WILLARD color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2151.303 -2440.136 29.822 angle 324.7583 
014B: " + tmp_parked_car + @"[122] = init_car_generator #WILLARD color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2147.038 -2443.752 29.822 angle 324.7583 
014B: " + tmp_parked_car + @"[123] = init_car_generator #WILLARD color -1 -1 force_spawn 1 alarm 0 door_lock 0 min_delay 0 max_delay 10000 at -2140.979 -2448.733 29.822 angle 144.7583 
014C: set_parked_car_generator " + tmp_parked_car + @"[0] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[1] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[2] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[3] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[4] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[5] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[6] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[7] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[8] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[9] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[10] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[11] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[12] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[13] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[14] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[15] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[16] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[17] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[18] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[19] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[20] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[21] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[22] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[23] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[24] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[25] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[26] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[27] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[28] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[29] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[30] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[31] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[32] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[33] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[34] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[35] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[36] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[37] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[38] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[39] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[40] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[41] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[42] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[43] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[44] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[45] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[46] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[47] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[48] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[49] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[50] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[51] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[52] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[53] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[54] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[55] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[56] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[57] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[58] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[59] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[60] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[61] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[62] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[63] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[64] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[65] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[66] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[67] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[68] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[69] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[70] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[71] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[72] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[73] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[74] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[75] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[76] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[77] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[78] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[79] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[80] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[81] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[82] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[83] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[84] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[85] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[86] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[87] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[88] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[89] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[90] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[91] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[92] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[93] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[94] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[95] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[96] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[97] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[98] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[99] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[100] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[101] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[102] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[103] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[104] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[105] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[106] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[107] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[108] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[109] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[110] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[111] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[112] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[113] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[114] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[115] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[116] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[117] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[118] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[119] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[120] cars_to_generate_to 101
014C: set_parked_car_generator " + tmp_parked_car + @"[121] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[122] cars_to_generate_to 101 
014C: set_parked_car_generator " + tmp_parked_car + @"[123] cars_to_generate_to 101 
0A17: set_parked_car_generator " + tmp_parked_car + @"[0] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[1] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[2] to_player_owned 1 
0A17: set_parked_car_generator " + tmp_parked_car + @"[3] to_player_owned 1 
0A17: set_parked_car_generator " + tmp_parked_car + @"[4] to_player_owned 1 
0A17: set_parked_car_generator " + tmp_parked_car + @"[5] to_player_owned 1 
0A17: set_parked_car_generator " + tmp_parked_car + @"[6] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[7] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[8] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[9] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[10] to_player_owned 1
0A17: set_parked_car_generator " + tmp_parked_car + @"[11] to_player_owned 1" );
                }
                if( OriginalSetup.enableWangCarsMoney ) {
                    AssetMoneyPickup wangCarsMoney = Script.global();
                    wangCarsMoney.create( -1969.463, 289.5335, 34.6719, 8000, 8000 );
                }
                OnMission.value = false;
                end_thread();
            }

        }

        internal class BDISPLY : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"if 
  " + _1048 + @" == 0 
jf @BDISPLY_43 
" + _1048 + @" = 1 
" + _1044 + @" = 0 

:BDISPLY_43
03F0: enable_text_draw 1 
0390: load_txd_dictionary 'LD_BEAT' 
038F: load_texture ""DOWN"" as 1 
038F: load_texture ""LEFT"" as 2 
038F: load_texture ""UP"" as 3 
038F: load_texture ""RIGHT"" as 4 
038F: load_texture ""UP"" as 13 
038F: load_texture ""DOWN"" as 14 
038F: load_texture ""RIGHT"" as 10 
038F: load_texture ""LEFT"" as 9 
038F: load_texture ""UPR"" as 11 
038F: load_texture ""DOWNR"" as 16 
038F: load_texture ""DOWNL"" as 12 
038F: load_texture ""UPL"" as 15 
038F: load_texture ""CRING"" as 17 
038F: load_texture ""CHIT"" as 18 
" + _1036 + @" = 4500 
" + _1037 + @" = 800 
" + _1038 + @" = 265.0 
" + _1039 + @" = 390.0 
" + _1040 + @" = 355.0 
" + _1041 + @" = 32.0 
" + _1042 + @" = 32.0 
19@ = 64.0 
20@ = 64.0 
22@ = 64.0 
21@ = 64.0 
01BD: 16@ = current_time_in_ms 
wait 1000 

:BDISPLY_313
wait 0 
if 
09FA:   is_menu_closed 
jf @BDISPLY_344 
" + _1043 + @" = 0 
23@ = 0 

:BDISPLY_344
0953: get_soundtrack_status_to 0@ 
if 
04A4:   0@ == 3 
jf @BDISPLY_1198 
01BD: 15@ = current_time_in_ms 
0085: 17@ = 15@ 
0062: 17@ -= 16@ 
0085: 16@ = 15@ 
008B: 0@ = " + _1037 + @" 
005C: 0@ += " + _1036 + @" 
0093: 5@ = integer 0@ to_float 
008F: 6@ = integer " + _1037 + @" to_float 
0073: 6@ /= 5@ 
006F: 6@ *= " + _1040 + @" 
0086: " + tempvar_Float_1 + @" = " + _1038 + @" 
005F: " + tempvar_Float_1 + @" += 6@ 
0086: " + tempvar_Float_2 + @" = " + _1039 + @" 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 17 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 20@ 19@ RGBA 128 128 128 255 
01BD: " + _1047 + @" = current_time_in_ms 
0060: " + _1047 + @" -= " + _1046 + @" 
0@ = 1 

:BDISPLY_520
if 
  11 > 0@ 
jf @BDISPLY_846 
07B1: unknown_get_dance_track 0@ store_to 8@ 10@ 12@ 
if 
   not 10@ == 0 
jf @BDISPLY_832 
if 
001E:   " + _1036 + @" > 8@ 
jf @BDISPLY_832 
gosub @BDISPLY_1266 
008B: 3@ = " + _1037 + @" 
005C: 3@ += " + _1036 + @" 
0085: 4@ = 8@ 
005C: 4@ += " + _1037 + @" 
0093: 5@ = integer 4@ to_float 
0093: 6@ = integer 3@ to_float 
0073: 5@ /= 6@ 
006F: 5@ *= " + _1040 + @" 
0086: " + tempvar_Float_1 + @" = " + _1038 + @" 
005F: " + tempvar_Float_1 + @" += 5@ 
0086: " + tempvar_Float_2 + @" = " + _1039 + @" 
0093: 5@ = integer 8@ to_float 
008F: 6@ = integer " + _1036 + @" to_float 
0073: 5@ /= 6@ 
5@ *= -1.0 
5@ += 1.0 
if 
  0 > 8@ 
jf @BDISPLY_756 
5@ = 1.0 

:BDISPLY_756
5@ *= 255.0 
0092: 4@ = float 5@ to_integer 
if 
   not 18@ == 0 
jf @BDISPLY_832 
gosub @BDISPLY_1575 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 18@ position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _1042 + @" " + _1041 + @" RGBA 128 128 128 4@ 

:BDISPLY_832
0@ += 1 
jump @BDISPLY_520 

:BDISPLY_846
if 
  " + _1045 + @" == 0 
jf @BDISPLY_1191 
0@ = -1 

:BDISPLY_871
if 
  0@ > -11 
jf @BDISPLY_1191 
07B1: unknown_get_dance_track 0@ store_to 8@ 10@ 12@ 
8@ *= -1 
if 
   not 10@ == 0 
jf @BDISPLY_1177 
if 
001E:   " + _1037 + @" > 8@ 
jf @BDISPLY_1177 
gosub @BDISPLY_1266 
0085: 4@ = 8@ 
4@ *= -1 
005C: 4@ += " + _1037 + @" 
008B: 3@ = " + _1037 + @" 
005C: 3@ += " + _1036 + @" 
0093: 5@ = integer 4@ to_float 
0093: 6@ = integer 3@ to_float 
0073: 5@ /= 6@ 
006F: 5@ *= " + _1040 + @" 
0086: " + tempvar_Float_1 + @" = " + _1038 + @" 
005F: " + tempvar_Float_1 + @" += 5@ 
0086: " + tempvar_Float_2 + @" = " + _1039 + @" 
0093: 5@ = integer 4@ to_float 
008F: 6@ = integer " + _1037 + @" to_float 
0073: 5@ /= 6@ 
if 
  0 > 8@ 
jf @BDISPLY_1101 
5@ = 1.0 

:BDISPLY_1101
5@ *= 255.0 
0092: 4@ = float 5@ to_integer 
if 
   not 18@ == 0 
jf @BDISPLY_1177 
gosub @BDISPLY_1575 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 18@ position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size " + _1042 + @" " + _1041 + @" RGBA 128 128 128 4@ 

:BDISPLY_1177
0@ -= 1 
jump @BDISPLY_871 

:BDISPLY_1191
jump @BDISPLY_1205 

:BDISPLY_1198
jump @BDISPLY_1244 

:BDISPLY_1205
if 
  " + _1044 + @" == 0 
jf @BDISPLY_1237 
jump @BDISPLY_313 
jump @BDISPLY_1244 

:BDISPLY_1237
jump @BDISPLY_1244 

:BDISPLY_1244
" + _1044 + @" = 0 
" + _1048 + @" = 0 
03F0: enable_text_draw 0 
0391: release_textures 
end_thread 

:BDISPLY_1266
18@ = 0 
if 
  10@ == 1 
jf @BDISPLY_1298 
18@ = 1 

:BDISPLY_1298
if 
  10@ == 2 
jf @BDISPLY_1323 
18@ = 2 

:BDISPLY_1323
if 
  10@ == 3 
jf @BDISPLY_1348 
18@ = 3 

:BDISPLY_1348
if 
  10@ == 4 
jf @BDISPLY_1373 
18@ = 4 

:BDISPLY_1373
if 
  10@ == 9 
jf @BDISPLY_1398 
18@ = 9 

:BDISPLY_1398
if 
  10@ == 10 
jf @BDISPLY_1423 
18@ = 10 

:BDISPLY_1423
if 
  10@ == 11 
jf @BDISPLY_1448 
18@ = 11 

:BDISPLY_1448
if 
  10@ == 12 
jf @BDISPLY_1473 
18@ = 12 

:BDISPLY_1473
if 
  10@ == 13 
jf @BDISPLY_1498 
18@ = 13 

:BDISPLY_1498
if 
  10@ == 14 
jf @BDISPLY_1523 
18@ = 14 

:BDISPLY_1523
if 
  10@ == 15 
jf @BDISPLY_1548 
18@ = 15 

:BDISPLY_1548
if 
  10@ == 16 
jf @BDISPLY_1573 
18@ = 16 

:BDISPLY_1573
return 

:BDISPLY_1575
if and
  " + _1043 + @" > 0 
  23@ == 0 
jf @BDISPLY_1627 
07B1: unknown_get_dance_track 0 store_to 1@ 1@ 25@ 
25@ += 1 
23@ = 1 

:BDISPLY_1627
0085: 13@ = 12@ 
005A: 13@ += 0@ 
if 
  0 > 0@ 
jf @BDISPLY_1675 
8@ *= -1 
13@ += 1 

:BDISPLY_1675
if 
003B:   13@ == 25@ 
jf @BDISPLY_1756 
if and
  3000 >= 8@ 
  8@ > -400 
jf @BDISPLY_1735 
gosub @BDISPLY_1765 
jump @BDISPLY_1749 

:BDISPLY_1735
23@ = 0 
" + _1043 + @" = 0 

:BDISPLY_1749
jump @BDISPLY_1763 

:BDISPLY_1756
" + _1043 + @" = 0 

:BDISPLY_1763
return 

:BDISPLY_1765
0871: init_jump_table 23@ total_jumps 3 default_jump 0 @BDISPLY_2214 jumps 1 @BDISPLY_1828 2 @BDISPLY_2001 3 @BDISPLY_2105 -1 @BDISPLY_2214 -1 @BDISPLY_2214 -1 @BDISPLY_2214 -1 @BDISPLY_2214 

:BDISPLY_1828
if 
  " + _1043 + @" == 1 
jf @BDISPLY_1867 
26@ = 90 
27@ = 100 
jump @BDISPLY_1940 

:BDISPLY_1867
if 
  " + _1043 + @" == 2 
jf @BDISPLY_1907 
26@ = 190 
27@ = 80 
jump @BDISPLY_1940 

:BDISPLY_1907
if 
  " + _1043 + @" == 3 
jf @BDISPLY_1940 
26@ = 255 
27@ = 25 

:BDISPLY_1940
0085: 24@ = 26@ 
TIMERB = 0 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 18 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 21@ 22@ RGBA 128 128 128 24@ 
23@ += 1 
jump @BDISPLY_2214 

:BDISPLY_2001
if 
001D:   27@ > TIMERB 
jf @BDISPLY_2059 
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 18 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 21@ 22@ RGBA 128 128 128 24@ 
jump @BDISPLY_2098 

:BDISPLY_2059
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 18 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 21@ 22@ RGBA 128 128 128 24@ 
23@ += 1 

:BDISPLY_2098
jump @BDISPLY_2214 

:BDISPLY_2105
0085: 1@ = 26@ 
0072: 1@ /= 17@ 
1@ *= 4 
0062: 24@ -= 1@ 
if 
  0 >= 24@ 
jf @BDISPLY_2175 
24@ = 0 
23@ = 0 
" + _1043 + @" = 0 

:BDISPLY_2175
03E3: set_texture_to_be_drawn_antialiased 1 
038D: draw_texture 18 position " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" size 21@ 22@ RGBA 128 128 128 24@ 
jump @BDISPLY_2214 

:BDISPLY_2214
return" );
            }

        }

        internal class AUDIOL : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"8@ = 0 
if 
  8@ == -1 
jf @AUDIOL_60 
0@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)

:AUDIOL_60
if 
   not " + Audio_Line_Is_Active + @" == 0 
jf @AUDIOL_169 
if 
  2@ == 1 
jf @AUDIOL_162 
040D: unload_wav 3@ 

:AUDIOL_101
if 
   not " + Audio_Line_Is_Active + @" == 0 
jf @AUDIOL_155 
if 
  " + _1035 + @" == 1 
jf @AUDIOL_144 
jump @AUDIOL_737 

:AUDIOL_144
wait 0 
jump @AUDIOL_101 

:AUDIOL_155
jump @AUDIOL_169 

:AUDIOL_162
jump @AUDIOL_737 

:AUDIOL_169
05AA: 5@s = " + Actor_Speech_GXT_Reference + @" 
008B: 7@ = " + Actor_Speech_WAV_File + @" 
" + Audio_Line_Is_Active + @" = 1 

:AUDIOL_192
if 
  " + _1035 + @" == 1 
jf @AUDIOL_217 
jump @AUDIOL_662 

:AUDIOL_217
0871: init_jump_table 8@ total_jumps 4 default_jump 0 @AUDIOL_651 jumps 0 @AUDIOL_280 1 @AUDIOL_362 2 @AUDIOL_531 3 @AUDIOL_637 -1 @AUDIOL_651 -1 @AUDIOL_651 -1 @AUDIOL_651 

:AUDIOL_280
if 
  4@ == 0 
jf @AUDIOL_311 
040D: unload_wav 3@ 
03CF: load_wav 7@ as 3@ 

:AUDIOL_311
if 
   not Actor.Dead(0@)
jf @AUDIOL_341 
094E: set_actor 0@ mute_pain_audio 1 
0A09: set_actor 0@ muted 1 

:AUDIOL_341
TIMERA = 0 
8@ += 1 
jump @AUDIOL_651 

:AUDIOL_362
if 
03D0:   wav 3@ loaded 
jf @AUDIOL_498 
if 
   not Actor.Dead(0@)
jf @AUDIOL_444 
if 
894D:   not actor 0@ mutally_active 
jf @AUDIOL_436 
if 
  1@ == 1 
jf @AUDIOL_436 
0949: link_wav 3@ to_actor 0@ 

:AUDIOL_436
0967: actor 0@ move_mouth 10000 ms 

:AUDIOL_444
03D1: play_wav 3@ 
if 
85AE:   not  5@s == 'DUMMY' 
jf @AUDIOL_484 
00BC: show_text_highpriority GXT 5@s time 10000 flag 1 

:AUDIOL_484
8@ += 1 
jump @AUDIOL_524 

:AUDIOL_498
if 
  TIMERA > 5000 
jf @AUDIOL_524 
8@ += 1 

:AUDIOL_524
jump @AUDIOL_651 

:AUDIOL_531
if 
03D0:   wav 3@ loaded 
jf @AUDIOL_623 
if 
03D2:   wav 3@ ended 
jf @AUDIOL_577 
8@ += 1 
jump @AUDIOL_616 

:AUDIOL_577
if 
056D:   actor 0@ defined 
jf @AUDIOL_616 
if 
   Actor.Dead(0@)
jf @AUDIOL_616 
8@ += 1 

:AUDIOL_616
jump @AUDIOL_630 

:AUDIOL_623
8@ += 1 

:AUDIOL_630
jump @AUDIOL_651 

:AUDIOL_637
jump @AUDIOL_662 
jump @AUDIOL_651 

:AUDIOL_651
wait 0 
jump @AUDIOL_192 

:AUDIOL_662
if 
   not Actor.Dead(0@)
jf @AUDIOL_695 
094F: enable_actor 0@ pain_audio 
0A09: set_actor 0@ muted 0 
0968: actor 0@ stop_mouth 

:AUDIOL_695
040D: unload_wav 3@ 
if 
85AE:   not  5@s == 'DUMMY' 
jf @AUDIOL_730 
03D5: remove_text 5@s 

:AUDIOL_730
" + Audio_Line_Is_Active + @" = 0 

:AUDIOL_737
end_thread" );
            }

        }

        internal class CASHWIN : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
  1@ == 0 
jf @CASHWIN_57 
008B: 3@ = " + Current_Time_in_ms2 + @" 
3@ += 3000 
jump @CASHWIN_73 

:CASHWIN_57
008B: 3@ = " + Current_Time_in_ms2 + @" 
005A: 3@ += 1@ 

:CASHWIN_73
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
jf @CASHWIN_95 
end_thread 

:CASHWIN_95
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
001E:   " + Current_Time_in_ms2 + @" > 3@ 
jf @CASHWIN_121 
end_thread 

:CASHWIN_121
if 
  0@ == 0 
jf @CASHWIN_234 
gosub @sub_Set_Cashwin_TextStyle 
0340: set_text_draw_RGBA 180 180 180 255 
if 
  2@ == 69 
jf @CASHWIN_206 
033E: set_draw_text_position 320.0 180.333 GXT 'BJ_PUSH'  
jump @CASHWIN_227 

:CASHWIN_206
033E: set_draw_text_position 320.0 180.333 GXT 'NOWIN'  

:CASHWIN_227
jump @CASHWIN_569 

:CASHWIN_234
if 
  0@ > 0 
jf @CASHWIN_422 
gosub @sub_Set_Cashwin_TextStyle 
0871: init_jump_table 2@ total_jumps 2 default_jump 1 @CASHWIN_384 jumps 45 @CASHWIN_322 80 @CASHWIN_353 -1 @CASHWIN_415 -1 @CASHWIN_415 -1 @CASHWIN_415 -1 @CASHWIN_415 -1 @CASHWIN_415 

:CASHWIN_322
045A: draw_text_1number 320.0 155.333 GXT 'ALLRACE' number 0@  
jump @CASHWIN_415 

:CASHWIN_353
045A: draw_text_1number 320.0 155.333 GXT 'PL_07' number 0@  
jump @CASHWIN_415 

:CASHWIN_384
045A: draw_text_1number 320.0 155.333 GXT 'WINNER' number 0@  
jump @CASHWIN_415 

:CASHWIN_415
jump @CASHWIN_569 

:CASHWIN_422
008A: " + _3396 + @" = 0@ 
" + _3396 + @" *= -1 
gosub @sub_Set_Cashwin_TextStyle 
0871: init_jump_table 2@ total_jumps 1 default_jump 1 @CASHWIN_538 jumps 80 @CASHWIN_507 -1 @CASHWIN_569 -1 @CASHWIN_569 -1 @CASHWIN_569 -1 @CASHWIN_569 -1 @CASHWIN_569 -1 @CASHWIN_569 

:CASHWIN_507
045A: draw_text_1number 320.0 155.333 GXT 'PL_10' number " + _3396 + @"  
jump @CASHWIN_569 

:CASHWIN_538
045A: draw_text_1number 320.0 155.333 GXT 'LOSER' number " + _3396 + @"  
jump @CASHWIN_569 

:CASHWIN_569
jump @CASHWIN_73 

:sub_Set_Cashwin_TextStyle
03E4: set_text_draw_align_right 0 
0341: set_text_draw_align_justify 0 
0343: set_text_draw_linewidth 640.0 
0348: enable_text_draw_proportional 1 
0345: enable_text_draw_background 0 
033F: set_text_draw_letter_size 1.3 3.36 
0342: set_text_draw_centered 1 
081C: draw_text_outline 2 RGBA 0 0 0 255 
0349: set_text_draw_font 3 
0904: get_interface 6 color_RGBA_to " + Color_Red + @" " + Color_Green + @" " + Gambles_CashWin + @" " + _3400 + @" 
0340: set_text_draw_RGBA " + Color_Red + @" " + Color_Green + @" " + Gambles_CashWin + @" 255 
return" );
            }

        }

    }

}