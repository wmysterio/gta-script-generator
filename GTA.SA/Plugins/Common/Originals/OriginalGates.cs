using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalGates : Original {

        internal OriginalGates() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.init_external_script_trigger_with_object_model<GATEOS>( 986, 100, 80.0, -1 );
            Script.init_external_script_trigger_with_object_model<GATEOS>( 985, 100, 80.0, -1 );
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class GATEOS : External {

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == 1 
jf @GATEOS_80 
0@ = Object.Init(#GATE_AUTOL, 0.0, 0.0, 0.0)
0@ = Object.Init(#GATE_AUTOR, 0.0, 0.0, 0.0)

:GATEOS_80
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
03CA:   object 0@ exists 
jf @GATEOS_997 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @GATEOS_988 
if 
  1@ == 0 
jf @GATEOS_502 
if 
   Player.Defined(" + PlayerChar + @")
jf @GATEOS_502 
9@ = Object.Model(0@)
if 
   Model.Available(9@)
jf @GATEOS_502 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 12.0 12.0 sphere 0 
jf @GATEOS_477 
if or
   Actor.DrivingVehicleType(" + PlayerActor + @", #BARRACKS)
   Actor.DrivingVehicleType(" + PlayerActor + @", #PATRIOT)
   Actor.DrivingVehicleType(" + PlayerActor + @", #RHINO)
jf @GATEOS_366 
080A: get_object 0@ spoot 5 store_to " + _3401 + @" " + _3402 + @" " + _3403 + @" 
080A: get_object 0@ spoot 6 store_to " + _3404 + @" " + _3405 + @" " + _3406 + @" 
080A: get_object 0@ spoot 7 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0509: " + tempvar_Float_3 + @" = distance_between_XY " + _3404 + @" " + _3405 + @" and_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
" + tempvar_Float_3 + @" *= -1.0 
if 
05FC:   actor " + PlayerActor + @" in_cube_fll_corner_at " + _3401 + @" " + _3402 + @" " + _3403 + @" fur_corner_at " + _3404 + @" " + _3405 + @" " + _3406 + @" angle " + tempvar_Float_3 + @" sphere 0 
jf @GATEOS_366 
1@ = 1 

:GATEOS_366
080A: get_object 0@ spoot 1 store_to " + _3401 + @" " + _3402 + @" " + _3403 + @" 
080A: get_object 0@ spoot 2 store_to " + _3404 + @" " + _3405 + @" " + _3406 + @" 
080A: get_object 0@ spoot 3 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0509: " + tempvar_Float_3 + @" = distance_between_XY " + _3404 + @" " + _3405 + @" and_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
if 
05FC:   actor " + PlayerActor + @" in_cube_fll_corner_at " + _3401 + @" " + _3402 + @" " + _3403 + @" fur_corner_at " + _3404 + @" " + _3405 + @" " + _3406 + @" angle " + tempvar_Float_3 + @" sphere 0 
jf @GATEOS_477 
1@ = 1 

:GATEOS_477
if 
  " + _709 + @" == 1 
jf @GATEOS_502 
1@ = 1 

:GATEOS_502
if 
  1@ == 1 
jf @GATEOS_589 
9@ = Object.Model(0@)
if 
   Model.Available(9@)
jf @GATEOS_589 
080A: get_object 0@ spoot 0 store_to 2@ 3@ 4@ 
Object.StorePos(0@, 5@, 6@, 7@)
097B: play_audio_at_object 0@ event 1100 
1@ += 1 

:GATEOS_589
if 
  1@ == 2 
jf @GATEOS_727 
if 
034E: move_object 0@ to 2@ 3@ 4@ speed 0.1 0.1 0.1 collision_check 1 
jf @GATEOS_727 
if 
04E6:   object 0@ near_point 2@ 3@ 4@ radius 0.1 0.1 0.1 flag 0 
jf @GATEOS_727 
Object.PutAt(0@, 2@, 3@, 4@)
097B: play_audio_at_object 0@ event 1101 
" + _709 + @" += 1 
1@ += 1 

:GATEOS_727
if 
  1@ == 3 
jf @GATEOS_770 
if 
  " + _1521 + @" == 0 
jf @GATEOS_770 
1@ += 1 

:GATEOS_770
if 
  1@ == 4 
jf @GATEOS_850 
if 
   Player.Defined(" + PlayerChar + @")
jf @GATEOS_850 
if 
8471:   not actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 20.0 20.0 sphere 0 
jf @GATEOS_850 
097B: play_audio_at_object 0@ event 1100 
1@ += 1 

:GATEOS_850
if 
  1@ == 5 
jf @GATEOS_981 
if 
034E: move_object 0@ to 5@ 6@ 7@ speed 0.1 0.1 0.1 collision_check 1 
jf @GATEOS_981 
if 
04E6:   object 0@ near_point 5@ 6@ 7@ radius 0.1 0.1 0.1 flag 0 
jf @GATEOS_981 
Object.PutAt(0@, 5@, 6@, 7@)
097B: play_audio_at_object 0@ event 1101 
1@ = 0 

:GATEOS_981
jump @GATEOS_990 

:GATEOS_988
end_thread 

:GATEOS_990
jump @GATEOS_999 

:GATEOS_997
end_thread 

:GATEOS_999
jump @GATEOS_80 
end_thread
" );

            }

        }

    }

}