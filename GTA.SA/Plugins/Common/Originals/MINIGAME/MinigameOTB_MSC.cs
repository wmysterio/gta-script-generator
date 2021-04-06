using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class OTB_MSC : External {

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == -1 
else_jump @OTB_MSC_58 
0@ = Object.Create(#OTB_MACHINE, 0.0, 0.0, 0.0)

:OTB_MSC_58
wait 0 
if 
03CA:   object 0@ exists 
else_jump @OTB_MSC_625 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
else_jump @OTB_MSC_589 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @OTB_MSC_555 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -1.0 0.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
else_jump @OTB_MSC_521 
if 
00E1:   player 0 pressed_key 15 
else_jump @OTB_MSC_478 
if 
  1@ == 1 
else_jump @OTB_MSC_471 
03E6: remove_text_box 
1@ = 0 
if 
  " + OnMission + @" == 0 
else_jump @OTB_MSC_455 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @OTB_MSC_432 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @OTB_MSC_425 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
fade 0 500 

:OTB_MSC_298
if 
fading 
else_jump @OTB_MSC_322 
wait 0 
jump @OTB_MSC_298 

:OTB_MSC_322
" + Video_Game + @" = 4 
wait 0 
wait 0 
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @OTB_MSC_425 
if 
  " + OnMission + @" == 0 
else_jump @OTB_MSC_382 
Player.CanMove(" + PlayerChar + @") = True

:OTB_MSC_382
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -2.0 0.0 -1.0 
Actor.PutAt(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:OTB_MSC_425
jump @OTB_MSC_448 

:OTB_MSC_432
00BC: show_text_highpriority GXT 'BUSY' time 3000 flag 1  

:OTB_MSC_448
jump @OTB_MSC_471 

:OTB_MSC_455
00BC: show_text_highpriority GXT 'BUSY' time 3000 flag 1  

:OTB_MSC_471
jump @OTB_MSC_514 

:OTB_MSC_478
if 
  1@ == 0 
else_jump @OTB_MSC_514 
0512: show_permanent_text_box 'OTB_A'  
1@ = 1 

:OTB_MSC_514
jump @OTB_MSC_548 

:OTB_MSC_521
if 
  1@ == 1 
else_jump @OTB_MSC_548 
03E6: remove_text_box 
1@ = 0 

:OTB_MSC_548
jump @OTB_MSC_582 

:OTB_MSC_555
if 
  1@ == 1 
else_jump @OTB_MSC_582 
03E6: remove_text_box 
1@ = 0 

:OTB_MSC_582
jump @OTB_MSC_618 

:OTB_MSC_589
if 
  1@ == 1 
else_jump @OTB_MSC_616 
03E6: remove_text_box 
1@ = 0 

:OTB_MSC_616
end_thread 

:OTB_MSC_618
jump @OTB_MSC_654 

:OTB_MSC_625
if 
  1@ == 1 
else_jump @OTB_MSC_652 
03E6: remove_text_box 
1@ = 0 

:OTB_MSC_652
end_thread 

:OTB_MSC_654
jump @OTB_MSC_58 
end_thread" );
            }

        }

    }

}