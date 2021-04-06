using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalHJ : Original {

        internal OriginalHJ() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.create_thread_wb<HJ>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class HJ : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"set_wb_check_to 0 

:HJ_15
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @HJ_42 
jump @HJ_15 

:HJ_42
if 
0445:   are_car_cheats_used 
else_jump @HJ_62 
jump @HJ_15 

:HJ_62
if 
09AE:   actor " + PlayerActor + @" driving_train 
else_jump @HJ_85 
jump @HJ_15 

:HJ_85
if 
04C8:   actor " + PlayerActor + @" driving_flying_vehicle 
else_jump @HJ_108 
jump @HJ_15 

:HJ_108
if 
04A7:   actor " + PlayerActor + @" driving_boat 
else_jump @HJ_131 
jump @HJ_15 

:HJ_131
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #VORTEX)
else_jump @HJ_157 
jump @HJ_15 

:HJ_157
if 
89E7:   not player " + PlayerChar + @" not_frozen 
else_jump @HJ_180 
jump @HJ_15 

:HJ_180
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @HJ_1668 
" + HJ_Player_Car + @" = Actor.CurrentCar(" + PlayerActor + @")
04FC: store_player_stunt_data " + PlayerChar + @" two_wheels: " + HJ_TwoWheels_Time + @" " + HJ_TwoWheels_Distance_Float + @" wheelie: " + HJ_Wheelie_Time + @" " + HJ_Wheelie_Distance_Float + @" stoppie: " + HJ_Stoppie_Time + @" " + HJ_Stoppie_Distance_Float + @" 
if 
  " + HJ_TwoWheels_Distance_Float + @" > 0.0 
else_jump @HJ_426 
" + HJ_TwoWheels_Time + @" /= 1000 
008C: " + HJ_TwoWheels_Distance_Meters_Int + @" = float " + HJ_TwoWheels_Distance_Float + @" to_integer 
008D: " + HJ_TwoWheels_Distance_Meters_Float + @" = integer " + HJ_TwoWheels_Distance_Meters_Int + @" to_float 
0086: " + HJ_Temp_Float + @" = " + HJ_TwoWheels_Distance_Float + @" 
0061: " + HJ_Temp_Float + @" -= " + HJ_TwoWheels_Distance_Meters_Float + @" 
" + HJ_Temp_Float + @" *= 100.0 
008C: " + HJ_TwoWheels_Distance_Meters_Rem + @" = float " + HJ_Temp_Float + @" to_integer 
0084: " + HJ_Bonus + @" = " + HJ_TwoWheels_Time + @" 
0058: " + HJ_Bonus + @" += " + HJ_TwoWheels_Distance_Meters_Int + @" 
" + HJ_Bonus + @" /= 2 
Player.Money(" + PlayerChar + @") += " + HJ_Bonus + @"
if 
0424:   is_system_metric 
else_jump @HJ_385 
0302: show_text_4numbers GXT 'WHEEL01' numbers " + HJ_Bonus + @" " + HJ_TwoWheels_Distance_Meters_Int + @" " + HJ_TwoWheels_Distance_Meters_Rem + @" " + HJ_TwoWheels_Time + @" time 3000 flag 1  
jump @HJ_426 

:HJ_385
0425: " + HJ_TwoWheels_Distance_Feet_Float + @" = meters " + HJ_TwoWheels_Distance_Float + @" to_feet 
008C: " + HJ_TwoWheels_Distance_Feet + @" = float " + HJ_TwoWheels_Distance_Feet_Float + @" to_integer 
02FF: show_text_3numbers GXT 'WHEEL02' numbers " + HJ_Bonus + @" " + HJ_TwoWheels_Distance_Feet + @" " + HJ_TwoWheels_Time + @" time 3000 flag 1  

:HJ_426
if 
  " + HJ_Wheelie_Distance_Float + @" > 0.0 
else_jump @HJ_631 
" + HJ_Wheelie_Time + @" /= 1000 
008C: " + HJ_Wheelie_Distance_Meters_Int + @" = float " + HJ_Wheelie_Distance_Float + @" to_integer 
008D: " + HJ_Wheelie_Distance_Meters_Float + @" = integer " + HJ_Wheelie_Distance_Meters_Int + @" to_float 
0086: " + HJ_Temp_Float + @" = " + HJ_Wheelie_Distance_Float + @" 
0061: " + HJ_Temp_Float + @" -= " + HJ_Wheelie_Distance_Meters_Float + @" 
" + HJ_Temp_Float + @" *= 100.0 
008C: " + HJ_Wheelie_Distance_Meters_Rem + @" = float " + HJ_Temp_Float + @" to_integer 
0084: " + HJ_Bonus + @" = " + HJ_Wheelie_Distance_Meters_Int + @" 
" + HJ_Bonus + @" *= 2 
" + HJ_Bonus + @" /= 5 
" + HJ_Bonus + @" /= 2 
Player.Money(" + PlayerChar + @") += " + HJ_Bonus + @"
if 
0424:   is_system_metric 
else_jump @HJ_590 
0302: show_text_4numbers GXT 'WHEEL06' numbers " + HJ_Bonus + @" " + HJ_Wheelie_Distance_Meters_Int + @" " + HJ_Wheelie_Distance_Meters_Rem + @" " + HJ_Wheelie_Time + @" time 3000 flag 1  
jump @HJ_631 

:HJ_590
0425: " + HJ_Wheelie_Distance_Feet_Float + @" = meters " + HJ_Wheelie_Distance_Float + @" to_feet 
008C: " + HJ_Wheelie_Distance_Feet + @" = float " + HJ_Wheelie_Distance_Feet_Float + @" to_integer 
02FF: show_text_3numbers GXT 'WHEEL07' numbers " + HJ_Bonus + @" " + HJ_Wheelie_Distance_Feet + @" " + HJ_Wheelie_Time + @" time 3000 flag 1  

:HJ_631
if 
  " + HJ_Stoppie_Distance_Float + @" > 0.0 
else_jump @HJ_822 
" + HJ_Stoppie_Time + @" /= 1000 
008C: " + HJ_Stoppie_Distance_Meters_Int + @" = float " + HJ_Stoppie_Distance_Float + @" to_integer 
008D: " + HJ_Stoppie_Distance_Meters_Float + @" = integer " + HJ_Stoppie_Distance_Meters_Int + @" to_float 
0086: " + HJ_Temp_Float + @" = " + HJ_Stoppie_Distance_Float + @" 
0061: " + HJ_Temp_Float + @" -= " + HJ_Stoppie_Distance_Meters_Float + @" 
" + HJ_Temp_Float + @" *= 100.0 
008C: " + HJ_Stoppie_Distance_Meters_Rem + @" = float " + HJ_Temp_Float + @" to_integer 
0084: " + HJ_Bonus + @" = " + HJ_Stoppie_Distance_Meters_Int + @" 
" + HJ_Bonus + @" /= 2 
Player.Money(" + PlayerChar + @") += " + HJ_Bonus + @"
if 
0424:   is_system_metric 
else_jump @HJ_781 
0302: show_text_4numbers GXT 'WHEEL11' numbers " + HJ_Bonus + @" " + HJ_Stoppie_Distance_Meters_Int + @" " + HJ_Stoppie_Distance_Meters_Rem + @" " + HJ_Stoppie_Time + @" time 3000 flag 1  
jump @HJ_822 

:HJ_781
0425: " + HJ_Stoppie_Distance_Feet_Float + @" = meters " + HJ_Stoppie_Distance_Float + @" to_feet 
008C: " + HJ_Stoppie_Distance_Feet + @" = float " + HJ_Stoppie_Distance_Feet_Float + @" to_integer 
02FF: show_text_3numbers GXT 'WHEEL12' numbers " + HJ_Bonus + @" " + HJ_Stoppie_Distance_Feet + @" " + HJ_Stoppie_Time + @" time 3000 flag 1  

:HJ_822
if 
01F3:   car " + HJ_Player_Car + @" in_air 
else_jump @HJ_1654 
" + HJ_Stunt_Rotation_Int + @" = 0 
" + HJ_Car_Angle_Begin_Stunt + @" = 0.0 
" + _1293 + @" = 0 
" + HJ_Stunt_Flips + @" = 0 
" + HJ_Stunt_Flipping_Flag + @" = 0 
" + HJ_Stunt_Bonus_Mult + @" = 0 
" + HJ_Begin_Stunt_Flag + @" = 0 
" + HJ_Stunt_Height + @" = 0 
" + HJ_Car_Z_Max + @" = -100.0 
" + HJ_Car_X + @" = 0.0 
" + HJ_Car_Y + @" = 0.0 
" + HJ_Car_Z + @" = 0.0 
" + HJ_Car_X_Begin_Stunt + @" = 0.0 
" + HJ_Car_Y_Begin_Stunt + @" = 0.0 
" + HJ_Car_Z_Begin_Stunt + @" = 0.0 
" + HJ_Car_X_End_Stunt + @" = 0.0 
" + HJ_Car_Y_End_Stunt + @" = 0.0 
" + HJ_Stunt_Distance_Max_Float + @" = 0.0 
" + HJ_Stunt_Distance_Max_Int + @" = 0 
" + HJ_Stunt_Distance_Max_Rem + @" = 0 
" + HJ_Stunt_Height_Rem + @" = 0 
" + HJ_Temp_Float + @" = 0.0 
" + _1316 + @" = 0.0 
" + HJ_Stunt_Rotation_Float + @" = 0.0 
" + _1317 + @" = 0.0 
" + HJ_Car_Angle + @" = 0.0 
" + _1301 + @" = 0 
" + _1340 + @" = 0 

:HJ_1082
if or
01F3:   car " + HJ_Player_Car + @" in_air 
  10 > " + _1301 + @" 
else_jump @HJ_1647 
" + _1301 + @" += 1 
Car.StorePos(" + HJ_Player_Car + @", " + HJ_Car_X + @", " + HJ_Car_Y + @", " + HJ_Car_Z + @")
0086: " + HJ_Car_Angle + @" = " + HJ_Car_Angle_Begin_Stunt + @" 
if 
  " + HJ_Begin_Stunt_Flag + @" == 0 
else_jump @HJ_1191 
" + HJ_Car_Angle + @" = Car.Angle(" + HJ_Player_Car + @")
0086: " + HJ_Car_X_Begin_Stunt + @" = " + HJ_Car_X + @" 
0086: " + HJ_Car_Y_Begin_Stunt + @" = " + HJ_Car_Y + @" 
0086: " + HJ_Car_Z_Begin_Stunt + @" = " + HJ_Car_Z + @" 
" + HJ_Begin_Stunt_Flag + @" = 1 

:HJ_1191
wait 0 
if 
   Car.Wrecked(" + HJ_Player_Car + @")
else_jump @HJ_1218 
jump @HJ_15 

:HJ_1218
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @HJ_1241 
jump @HJ_15 

:HJ_1241
if 
   not Actor.Driving(" + PlayerActor + @")
else_jump @HJ_1264 
jump @HJ_15 

:HJ_1264
if and
820D:   not car " + HJ_Player_Car + @" flipped 
  " + HJ_Stunt_Flipping_Flag + @" == 0 
else_jump @HJ_1294 
" + HJ_Stunt_Flipping_Flag + @" = 1 

:HJ_1294
if and
020D:   car " + HJ_Player_Car + @" flipped 
  " + HJ_Stunt_Flipping_Flag + @" == 1 
else_jump @HJ_1331 
" + HJ_Stunt_Flips + @" += 1 
" + HJ_Stunt_Flipping_Flag + @" = 0 

:HJ_1331
" + HJ_Car_Angle_Begin_Stunt + @" = Car.Angle(" + HJ_Player_Car + @")
0086: " + _1316 + @" = " + HJ_Car_Angle_Begin_Stunt + @" 
0061: " + _1316 + @" -= " + HJ_Car_Angle + @" 
if 
  " + _1316 + @" > 180.0 
else_jump @HJ_1409 
0086: " + _1317 + @" = " + _1316 + @" 
" + _1316 + @" = 360.0 
0061: " + _1316 + @" -= " + _1317 + @" 
jump @HJ_1456 

:HJ_1409
if 
  -180.0 > " + _1316 + @" 
else_jump @HJ_1456 
0086: " + _1317 + @" = " + _1316 + @" 
" + _1316 + @" = 360.0 
0059: " + _1316 + @" += " + _1317 + @" 

:HJ_1456
if 
  0.0 > " + _1316 + @" 
else_jump @HJ_1503 
0086: " + _1317 + @" = " + _1316 + @" 
" + _1316 + @" = 0.0 
0061: " + _1316 + @" -= " + _1317 + @" 

:HJ_1503
0059: " + HJ_Stunt_Rotation_Float + @" += " + _1316 + @" 
008C: " + HJ_Stunt_Rotation_Int + @" = float " + HJ_Stunt_Rotation_Float + @" to_integer 
if 
0024:   " + HJ_Car_Z + @" > " + HJ_Car_Z_Max + @" 
else_jump @HJ_1546 
0086: " + HJ_Car_Z_Max + @" = " + HJ_Car_Z + @" 

:HJ_1546
" + HJ_Car_Z + @" = 0.0 
if 
  " + _1340 + @" == 0 
else_jump @HJ_1640 
Car.StorePos(" + HJ_Player_Car + @", " + HJ_Car_X_End_Stunt + @", " + HJ_Car_Y_End_Stunt + @", " + HJ_Temp_Float + @")
0509: " + HJ_Temp_Float + @" = distance_between_XY " + HJ_Car_X_Begin_Stunt + @" " + HJ_Car_Y_Begin_Stunt + @" and_XY " + HJ_Car_X_End_Stunt + @" " + HJ_Car_Y_End_Stunt + @" 
if 
  " + HJ_Temp_Float + @" > 20.0 
else_jump @HJ_1640 
09AB: set_passengers_in_car " + HJ_Player_Car + @" speak_from_audio_table 37 
" + _1340 + @" = 1 

:HJ_1640
jump @HJ_1082 

:HJ_1647
jump @HJ_1661 

:HJ_1654
jump @HJ_15 

:HJ_1661
jump @HJ_1675 

:HJ_1668
jump @HJ_15 

:HJ_1675
if 
  " + HJ_Begin_Stunt_Flag + @" == 1 
else_jump @HJ_1864 
Car.StorePos(" + HJ_Player_Car + @", " + HJ_Car_X_End_Stunt + @", " + HJ_Car_Y_End_Stunt + @", " + HJ_Temp_Float + @")
0509: " + HJ_Stunt_Distance_Max_Float + @" = distance_between_XY " + HJ_Car_X_Begin_Stunt + @" " + HJ_Car_Y_Begin_Stunt + @" and_XY " + HJ_Car_X_End_Stunt + @" " + HJ_Car_Y_End_Stunt + @" 
0628: update_float_stat_to " + HJ_Stunt_Distance_Max_Float + @" stat_id 139 
008C: " + HJ_Stunt_Distance_Max_Int + @" = float " + HJ_Stunt_Distance_Max_Float + @" to_integer 
0061: " + HJ_Car_Z_Max + @" -= " + HJ_Car_Z_Begin_Stunt + @" 
0628: update_float_stat_to " + HJ_Car_Z_Max + @" stat_id 140 
008C: " + HJ_Stunt_Height + @" = float " + HJ_Car_Z_Max + @" to_integer 
008D: " + HJ_Temp_Float + @" = integer " + HJ_Stunt_Distance_Max_Int + @" to_float 
0061: " + HJ_Stunt_Distance_Max_Float + @" -= " + HJ_Temp_Float + @" 
0086: " + HJ_Temp_Float + @" = " + HJ_Stunt_Distance_Max_Float + @" 
" + HJ_Temp_Float + @" *= 100.0 
008C: " + HJ_Stunt_Distance_Max_Rem + @" = float " + HJ_Temp_Float + @" to_integer 
008D: " + HJ_Temp_Float + @" = integer " + HJ_Stunt_Height + @" to_float 
0061: " + HJ_Car_Z_Max + @" -= " + HJ_Temp_Float + @" 
0086: " + HJ_Temp_Float + @" = " + HJ_Car_Z_Max + @" 
" + HJ_Temp_Float + @" *= 100.0 
008C: " + HJ_Stunt_Height_Rem + @" = float " + HJ_Temp_Float + @" to_integer 
0627: update_integer_stat 141 to " + HJ_Stunt_Flips + @" 
0627: update_integer_stat 142 to " + HJ_Stunt_Rotation_Int + @" 

:HJ_1864
if 
  " + HJ_Car_Z_Max + @" > 4.0 
else_jump @HJ_1892 
" + HJ_Stunt_Bonus_Mult + @" += 1 

:HJ_1892
if 
  " + HJ_Stunt_Distance_Max_Int + @" > 40 
else_jump @HJ_1917 
" + HJ_Stunt_Bonus_Mult + @" += 1 

:HJ_1917
if 
  " + HJ_Stunt_Flips + @" > 1 
else_jump @HJ_1942 
" + HJ_Stunt_Bonus_Mult + @" += 1 

:HJ_1942
if 
  " + HJ_Stunt_Rotation_Int + @" > 360 
else_jump @HJ_1968 
" + HJ_Stunt_Bonus_Mult + @" += 1 

:HJ_1968
if 
  " + HJ_Stunt_Bonus_Mult + @" > 0 
else_jump @HJ_2385 
0084: " + HJ_Stunt_Bonus + @" = " + HJ_Stunt_Flips + @" 
" + HJ_Stunt_Bonus + @" *= 180 
0058: " + HJ_Stunt_Bonus + @" += " + HJ_Stunt_Rotation_Int + @" 
0084: " + HJ_Stunt_Bonus_Temp + @" = " + HJ_Stunt_Distance_Max_Int + @" 
" + HJ_Stunt_Bonus_Temp + @" *= 6 
0058: " + HJ_Stunt_Bonus + @" += " + HJ_Stunt_Bonus_Temp + @" 
0084: " + HJ_Stunt_Bonus_Temp + @" = " + HJ_Stunt_Height + @" 
" + HJ_Stunt_Bonus_Temp + @" *= 45 
0058: " + HJ_Stunt_Bonus + @" += " + HJ_Stunt_Bonus_Temp + @" 
if 
  " + _1293 + @" == 1 
else_jump @HJ_2081 
" + HJ_Stunt_Bonus + @" *= 2 

:HJ_2081
0068: " + HJ_Stunt_Bonus + @" *= " + HJ_Stunt_Bonus_Mult + @" 
" + HJ_Stunt_Bonus + @" /= 3 
" + HJ_Stunt_Bonus + @" /= 5 
Player.Money(" + PlayerChar + @") += " + HJ_Stunt_Bonus + @"
if 
  " + HJ_Stunt_Bonus_Mult + @" == 1 
else_jump @HJ_2155 
01E4: show_text_1number_lowpriority GXT 'HJ_IS' number " + HJ_Stunt_Bonus + @" time 2000 flag 1  
0627: update_integer_stat 143 to 1 

:HJ_2155
if 
  " + HJ_Stunt_Bonus_Mult + @" == 2 
else_jump @HJ_2199 
01E4: show_text_1number_lowpriority GXT 'HJ_DIS' number " + HJ_Stunt_Bonus + @" time 2000 flag 1  
0627: update_integer_stat 143 to 3 

:HJ_2199
if 
  " + HJ_Stunt_Bonus_Mult + @" == 3 
else_jump @HJ_2243 
01E4: show_text_1number_lowpriority GXT 'HJ_TIS' number " + HJ_Stunt_Bonus + @" time 2000 flag 1  
0627: update_integer_stat 143 to 5 

:HJ_2243
if 
  " + HJ_Stunt_Bonus_Mult + @" == 4 
else_jump @HJ_2287 
01E4: show_text_1number_lowpriority GXT 'HJ_QIS' number " + HJ_Stunt_Bonus + @" time 2000 flag 1  
0627: update_integer_stat 143 to 7 

:HJ_2287
if 
0424:   is_system_metric 
else_jump @HJ_2341 
0308: show_text_6numbers GXT 'HJSTAT' numbers " + HJ_Stunt_Distance_Max_Int + @" " + HJ_Stunt_Distance_Max_Rem + @" " + HJ_Stunt_Height + @" " + HJ_Stunt_Height_Rem + @" " + HJ_Stunt_Flips + @" " + HJ_Stunt_Rotation_Int + @" time 5000 flag 5  
jump @HJ_2385 

:HJ_2341
042D: " + HJ_Stunt_Distance_Max_Int + @" = metric " + HJ_Stunt_Distance_Max_Int + @" to_imperial 
042D: " + HJ_Stunt_Height + @" = metric " + HJ_Stunt_Height + @" to_imperial 
0302: show_text_4numbers GXT 'HJSTATF' numbers " + HJ_Stunt_Distance_Max_Int + @" " + HJ_Stunt_Height + @" " + HJ_Stunt_Flips + @" " + HJ_Stunt_Rotation_Int + @" time 5000 flag 5  

:HJ_2385
jump @HJ_15 
end_thread" );

            }

        }

    }

}