using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class ARCADE : External {

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == -1 
else_jump @ARCADE_58 
0@ = Object.Create(#CJ_COIN_OP_2, 0.0, 0.0, 0.0)

:ARCADE_58
wait 0 
if 
03CA:   object 0@ exists 
else_jump @ARCADE_749 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
else_jump @ARCADE_713 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @ARCADE_679 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 1.0 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
else_jump @ARCADE_645 
if 
00E1:   player 0 pressed_key 15 
else_jump @ARCADE_602 
if 
  1@ == 1 
else_jump @ARCADE_595 
03E6: remove_text_box 
1@ = 0 
if 
  " + OnMission + @" == 0 
else_jump @ARCADE_563 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @ARCADE_524 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @ARCADE_517 
Player.CanMove(" + PlayerChar + @") = False
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
fade 0 500 

:ARCADE_298
if 
fading 
else_jump @ARCADE_322 
wait 0 
jump @ARCADE_298 

:ARCADE_322
if 
   Object.Model(0@) == #CJ_COIN_OP_2
else_jump @ARCADE_354 
" + Video_Game + @" = 1 
jump @ARCADE_464 

:ARCADE_354
if or
   Object.Model(0@) == #CJ_COIN_OP_3
   Object.Model(0@) == #SWANK_CONSOLE
else_jump @ARCADE_393 
" + Video_Game + @" = 0 
jump @ARCADE_464 

:ARCADE_393
if or
   Object.Model(0@) == #CJ_COIN_OP_1
   Object.Model(0@) == #SNESISH
else_jump @ARCADE_432 
" + Video_Game + @" = 3 
jump @ARCADE_464 

:ARCADE_432
if or
   Object.Model(0@) == #CJ_COIN_OP
   Object.Model(0@) == #LOW_CONSOLE
else_jump @ARCADE_464 
" + Video_Game + @" = 2 

:ARCADE_464
wait 0 
wait 0 
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @ARCADE_517 
if 
  " + OnMission + @" == 0 
else_jump @ARCADE_517 
Player.CanMove(" + PlayerChar + @") = True

:ARCADE_517
jump @ARCADE_556 

:ARCADE_524
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @ARCADE_556 
00BC: show_text_highpriority GXT 'BUSY' time 3000 flag 1  

:ARCADE_556
jump @ARCADE_595 

:ARCADE_563
if 
09E7:   player " + PlayerChar + @" not_frozen 
else_jump @ARCADE_595 
00BC: show_text_highpriority GXT 'BUSY' time 3000 flag 1  

:ARCADE_595
jump @ARCADE_638 

:ARCADE_602
if 
  1@ == 0 
else_jump @ARCADE_638 
0512: show_permanent_text_box 'DUAL_A'  
1@ = 1 

:ARCADE_638
jump @ARCADE_672 

:ARCADE_645
if 
  1@ == 1 
else_jump @ARCADE_672 
03E6: remove_text_box 
1@ = 0 

:ARCADE_672
jump @ARCADE_706 

:ARCADE_679
if 
  1@ == 1 
else_jump @ARCADE_706 
03E6: remove_text_box 
1@ = 0 

:ARCADE_706
jump @ARCADE_742 

:ARCADE_713
if 
  1@ == 1 
else_jump @ARCADE_740 
03E6: remove_text_box 
1@ = 0 

:ARCADE_740
end_thread 

:ARCADE_742
jump @ARCADE_778 

:ARCADE_749
if 
  1@ == 1 
else_jump @ARCADE_776 
03E6: remove_text_box 
1@ = 0 

:ARCADE_776
end_thread 

:ARCADE_778
jump @ARCADE_58 
end_thread" );
            }

        }

    }

}