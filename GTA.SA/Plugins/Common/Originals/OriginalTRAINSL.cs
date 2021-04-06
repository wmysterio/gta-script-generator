using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalTRAINSL : Original {

        internal OriginalTRAINSL() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.create_thread<TRAINSL>();
        }

        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class TRAINSL : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":TRAINSL_11
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRAINSL_115 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @TRAINSL_115 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAKC)
else_jump @TRAINSL_115" );
get_external_script_status<TRAINS>( ScriptStatus );
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @TRAINSL_115" );
load_external_script<TRAINS>();
AppendLine( @"if" );
is_external_script_loaded<TRAINS>().write();
AppendLine( @"else_jump @TRAINSL_115" );
start_new_external_script<TRAINS>();
AppendLine( @"
:TRAINSL_115
jump @TRAINSL_11" );
            }

        }

        private sealed class TRAINS : External {

            public override void START( LabelJump label ) {
                AppendLine( @"" + TRAINS_Train_Speed + @" = 0.0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_44 
jump @TRAINS_768 

:TRAINS_44
set_wb_check_to 0 

:TRAINS_48
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_754 
if 
0449:   actor " + PlayerActor + @" in_a_car 
else_jump @TRAINS_740 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAKC)
else_jump @TRAINS_726 
" + TRAINS_Train_Handle + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
  " + TRAINS_Text_Shown + @" == 0 
else_jump @TRAINS_181 
02E3: " + TRAINS_Train_Speed + @" = car " + TRAINS_Train_Handle + @" speed 
if 
  " + TRAINS_Train_Speed + @" > 0.0 
else_jump @TRAINS_181 
00BC: show_text_highpriority GXT 'TRAINS' time 20000 flag 1  
" + TRAINS_Text_Shown + @" = 1 

:TRAINS_181
if 
  " + TRAINS_Text_Shown + @" == 1 
else_jump @TRAINS_619 
if 
0A06:   train " + TRAINS_Train_Handle + @" next_station_unlocked 
else_jump @TRAINS_429 
if 
00E1:   player 0 pressed_key 16 
else_jump @TRAINS_422 
fade 0 1000 

:TRAINS_239
if 
fading 
else_jump @TRAINS_286 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_279 
jump @TRAINS_768 

:TRAINS_279
jump @TRAINS_239 

:TRAINS_286
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_361 
if 
0449:   actor " + PlayerActor + @" in_a_car 
else_jump @TRAINS_361 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAKC)
else_jump @TRAINS_361 
" + TRAINS_Train_Handle + @" = Actor.CurrentCar(" + PlayerActor + @")
0A07: put_train " + TRAINS_Train_Handle + @" at_next_station 
03D5: remove_text 'TRAINS'  

:TRAINS_361
fade 1 1000 

:TRAINS_368
if 
fading 
else_jump @TRAINS_415 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_408 
jump @TRAINS_768 

:TRAINS_408
jump @TRAINS_368 

:TRAINS_415
" + TRAINS_Text_Shown + @" = 2 

:TRAINS_422
jump @TRAINS_619 

:TRAINS_429
fade 0 1000 

:TRAINS_436
if 
fading 
else_jump @TRAINS_483 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_476 
jump @TRAINS_768 

:TRAINS_476
jump @TRAINS_436 

:TRAINS_483
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_558 
if 
0449:   actor " + PlayerActor + @" in_a_car 
else_jump @TRAINS_558 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAKC)
else_jump @TRAINS_558 
" + TRAINS_Train_Handle + @" = Actor.CurrentCar(" + PlayerActor + @")
0A07: put_train " + TRAINS_Train_Handle + @" at_next_station 
03D5: remove_text 'TRAINS'  

:TRAINS_558
fade 1 1000 

:TRAINS_565
if 
fading 
else_jump @TRAINS_612 
wait 0 
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_605 
jump @TRAINS_768 

:TRAINS_605
jump @TRAINS_565 

:TRAINS_612
" + TRAINS_Text_Shown + @" = 2 

:TRAINS_619
if 
  " + TRAINS_Text_Shown + @" == 2 
else_jump @TRAINS_719 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @TRAINS_719 
if 
0449:   actor " + PlayerActor + @" in_a_car 
else_jump @TRAINS_719 
if 
   Actor.DrivingVehicleType(" + PlayerActor + @", #STREAKC)
else_jump @TRAINS_719 
" + TRAINS_Train_Handle + @" = Actor.CurrentCar(" + PlayerActor + @")
if 
01C1:   car " + TRAINS_Train_Handle + @" stopped 
else_jump @TRAINS_719 
" + TRAINS_Text_Shown + @" = 0 

:TRAINS_719
jump @TRAINS_733 

:TRAINS_726
jump @TRAINS_768 

:TRAINS_733
jump @TRAINS_747 

:TRAINS_740
jump @TRAINS_768 

:TRAINS_747
jump @TRAINS_761 

:TRAINS_754
jump @TRAINS_768 

:TRAINS_761
jump @TRAINS_48 

:TRAINS_768
" + TRAINS_Text_Shown + @" = 0 
03D5: remove_text 'TRAINS'  
end_thread" );
            }

        }

    }

}