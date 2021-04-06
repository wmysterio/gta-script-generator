using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class LOWRCON : External {

            Actor _local0 = local( 0 );

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == -1 
jf @LOWRCON_83 
0@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
4@ = Car.Create(#PONY, 0.0, 0.0, 0.0)

:LOWRCON_83
2@ = 0 

:LOWRCON_90
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @LOWRCON_1747 
if or
  " + OnMission + @" == 0 
  2@ == 1 
jf @LOWRCON_1733 
if 
00EC:   actor " + PlayerActor + @" sphere 0 near_point 1812.369 -1929.922 radius 100.0 100.0 
jf @LOWRCON_1719 
if 
056D:   actor 0@ defined 
jf @LOWRCON_212 
if 
   Actor.Dead(0@)
jf @LOWRCON_212 
jump @LOWRCON_1761 

:LOWRCON_212
0871: init_jump_table 1@ total_jumps 10 default_jump 0 @LOWRCON_1712 jumps 0 @LOWRCON_340 1 @LOWRCON_480 2 @LOWRCON_726 3 @LOWRCON_787 4 @LOWRCON_902 5 @LOWRCON_1123 6 @LOWRCON_1219 
0872: jump_table_jumps 7 @LOWRCON_1334 8 @LOWRCON_1500 9 @LOWRCON_1640 -1 @LOWRCON_1712 -1 @LOWRCON_1712 -1 @LOWRCON_1712 -1 @LOWRCON_1712 -1 @LOWRCON_1712 -1 @LOWRCON_1712 

:LOWRCON_340
Model.Load(#WMYMECH)

:LOWRCON_344
if 
   not Model.Available(#WMYMECH)
jf @LOWRCON_370 
wait 0 
jump @LOWRCON_344 

:LOWRCON_370
07E5: copy_decision_maker 65542 to 3@ 
0@ = Actor.Create(Mission1, #WMYMECH, 1812.369, -1929.922, 12.5486)
Actor.Angle(0@) = 270.0
02A9: set_actor 0@ immune_to_nonplayer 1 
060B: set_actor 0@ decision_maker_to 3@ 
if 
   Player.Defined(" + PlayerChar + @")
jf @LOWRCON_455 
05BF: AS_actor 0@ look_at_actor " + PlayerActor + @" -2 ms 

:LOWRCON_455
Model.Destroy(#WMYMECH)
Actor.LockInCurrentPosition(0@) = True
1@ += 1 
jump @LOWRCON_1712 

:LOWRCON_480
if 
   not Actor.Dead(0@)
jf @LOWRCON_719 
if 
00FF:   actor 0@ sphere 0 in_sphere 1813.369 -1929.922 12.5486 radius 1.2 1.2 2.0 on_foot 
jf @LOWRCON_719 
if 
   not Actor.Dead(0@)
jf @LOWRCON_589 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor 0@ with_offset 0.0 1.0 0.0 

:LOWRCON_589
if 
   not Actor.Dead(0@)
jf @LOWRCON_639 
if 
051A:   actor 0@ damaged_by_actor " + PlayerActor + @" 
jf @LOWRCON_639 
05E2: AS_actor 0@ kill_actor " + PlayerActor + @" 
jump @LOWRCON_1761 

:LOWRCON_639
if 
0102:   actor " + PlayerActor + @" in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.7 0.7 1.2 sphere 1 stopped_on_foot 
jf @LOWRCON_719 
Player.CanMove(" + PlayerChar + @") = False
if 
   not Actor.Dead(0@)
jf @LOWRCON_712 
0639: AS_actor " + PlayerActor + @" rotate_to_actor 0@ 

:LOWRCON_712
1@ += 1 

:LOWRCON_719
jump @LOWRCON_1712 

:LOWRCON_726
if 
   not Actor.Dead(0@)
jf @LOWRCON_780 
if 
   Player.Defined(" + PlayerChar + @")
jf @LOWRCON_768 
05BF: AS_actor 0@ look_at_actor " + PlayerActor + @" -2 ms 

:LOWRCON_768
0687: clear_actor 0@ task 
1@ += 1 

:LOWRCON_780
jump @LOWRCON_1712 

:LOWRCON_787
if 
   not Actor.Dead(0@)
jf @LOWRCON_840 
0605: actor 0@ perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time 2000 

:LOWRCON_840
05A9: " + Actor_Speech_GXT_Reference + @" = 'MEC_HI' 
04AE: " + Actor_Speech_WAV_File + @" = 26007" );
                create_thread<AUDIOL>( _local0, 0, 1, 1, 0 );
                AppendLine( @"TIMERA = 0 
1@ += 1 
jump @LOWRCON_1712 

:LOWRCON_902
if 
  TIMERA > 1000 
jf @LOWRCON_1116 
if 
  " + Audio_Line_Is_Active + @" == 0 
jf @LOWRCON_1116 
0512: show_permanent_text_box 'TALK_1'  
if 
00E1:   player 0 pressed_key 11 
jf @LOWRCON_1040 
05A9: " + Actor_Speech_GXT_Reference + @" = 'SYN2_LO' 
04AE: " + Actor_Speech_WAV_File + @" = 39072" );
                create_thread<AUDIOL>( PlayerActor, 0, 1, 1, 0 );
                AppendLine( @"03E6: remove_text_box 
TIMERA = 0 
2@ = 1 
1@ += 1 
jump @LOWRCON_1116 

:LOWRCON_1040
if 
00E1:   player 0 pressed_key 10 
jf @LOWRCON_1116 
05A9: " + Actor_Speech_GXT_Reference + @" = 'VOFFE1N' 
04AE: " + Actor_Speech_WAV_File + @" = 21444" );
                create_thread<AUDIOL>( PlayerActor, 0, 1, 1, 0 );
                AppendLine( @"03E6: remove_text_box 
TIMERA = 0 
Camera.Restore
1@ += 2 

:LOWRCON_1116
jump @LOWRCON_1712 

:LOWRCON_1123
if 
  TIMERA > 1000 
jf @LOWRCON_1212 
if 
  " + Audio_Line_Is_Active + @" == 0 
jf @LOWRCON_1212 
fade 0 150 

:LOWRCON_1167
if 
fading 
jf @LOWRCON_1191 
wait 0 
jump @LOWRCON_1167 

:LOWRCON_1191
" + _1906 + @" = 0 
" + Video_Game + @" = 6 
1@ += 2 

:LOWRCON_1212
jump @LOWRCON_1712 

:LOWRCON_1219
if 
  TIMERA > 1000 
jf @LOWRCON_1327 
if 
  " + Audio_Line_Is_Active + @" == 0 
jf @LOWRCON_1327 
if 
   Player.Defined(" + PlayerChar + @")
jf @LOWRCON_1279 
Player.CanMove(" + PlayerChar + @") = True

:LOWRCON_1279
05A9: " + Actor_Speech_GXT_Reference + @" = 'MEC_N' 
04AE: " + Actor_Speech_WAV_File + @" = 26008" );
                create_thread<AUDIOL>( _local0, 1, 1, 1, 0 );
                AppendLine( @"jump @LOWRCON_1761 

:LOWRCON_1327
jump @LOWRCON_1712 

:LOWRCON_1334
if 
  " + _1906 + @" == 1 
jf @LOWRCON_1493 
Camera.SetPosition(1815.894, -1932.708, 15.2576, 0.0, 0.0, 0.0)
Camera.PointAt(1815.094, -1932.212, 14.9195, 2)
02A3: enable_widescreen 1 
fade 1 150 

:LOWRCON_1414
if 
fading 
jf @LOWRCON_1438 
wait 0 
jump @LOWRCON_1414 

:LOWRCON_1438
05A9: " + Actor_Speech_GXT_Reference + @" = 'MEC_Y' 
04AE: " + Actor_Speech_WAV_File + @" = 26009" );
                create_thread<AUDIOL>( _local0, 0, 1, 1, 0 );
                AppendLine( @"TIMERA = 0 
1@ += 1 

:LOWRCON_1493
jump @LOWRCON_1712 

:LOWRCON_1500
if 
  TIMERA > 1000 
jf @LOWRCON_1633 
if 
   Player.Defined(" + PlayerChar + @")
jf @LOWRCON_1633 
0925: restore_camera_to_user_defined 
0936: set_camera 1815.894 -1932.708 15.2576 position_to 1813.444 -1932.063 18.552 time 3000 smooth_transition 1 
0920: point_camera 1815.094 -1932.212 14.9195 transverse_to 1812.689 -1931.438 18.3523 time 3000 smooth_transition 1 
092F: lock_camera_target_point 1 
0930: lock_camera_position 1 
TIMERA = 0 
1@ += 1 

:LOWRCON_1633
jump @LOWRCON_1712 

:LOWRCON_1640
if or
  TIMERA > 5000 
00E1:   player 0 pressed_key 16 
jf @LOWRCON_1705 
if 
   Player.Defined(" + PlayerChar + @")
jf @LOWRCON_1705 
0925: restore_camera_to_user_defined 
02A3: enable_widescreen 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
Player.CanMove(" + PlayerChar + @") = True
jump @LOWRCON_1761 

:LOWRCON_1705
jump @LOWRCON_1712 

:LOWRCON_1712
jump @LOWRCON_1726 

:LOWRCON_1719
jump @LOWRCON_1761 

:LOWRCON_1726
jump @LOWRCON_1740 

:LOWRCON_1733
jump @LOWRCON_1761 

:LOWRCON_1740
jump @LOWRCON_1754 

:LOWRCON_1747
jump @LOWRCON_1761 

:LOWRCON_1754
jump @LOWRCON_90 

:LOWRCON_1761
if 
   not Actor.Dead(0@)
jf @LOWRCON_1794 
Actor.LockInCurrentPosition(0@) = False
0647: AS_actor 0@ clear_look_task 
05DE: AS_actor 0@ walk_around_ped_path 

:LOWRCON_1794
Actor.RemoveReferences(0@)
Car.RemoveReferences(4@)
04EF: release_animation ""GANGS"" 
Model.Destroy(#WMYMECH)
2@ = 0 
065C: release_decision_maker 3@ 
end_thread 
end_thread" );
            }

        }

    }

}