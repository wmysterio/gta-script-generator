using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalVending : Original {

        internal OriginalVending() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.init_external_script_trigger_with_object_model<VENDING>( 1302, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<VENDING>( 1209, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<VENDING>( 1977, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<VENDING>( 1775, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<VENDING>( 1776, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<VENDING>( 956, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<VENDING>( 955, 100, 6.0, -1 );
            Script.init_external_script_trigger_with_object_model<FVENDOR>( 1341, 100, 70.0, -1 );
            Script.init_external_script_trigger_with_object_model<FVENDOR>( 1340, 100, 70.0, -1 );
            Script.init_external_script_trigger_with_object_model<FVENDOR>( 1342, 100, 70.0, -1 );
            Script.init_external_script_trigger_with_actor_model<HOTDOGV>( 168, 100 );
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class VENDING : External {

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == 1 
jf @VENDING_80 
0@ = Object.Init(#VENDMACHFD, 0.0, 0.0, 0.0)
3@ = Object.Init(#KB_BEER, 0.0, 0.0, 0.0)

:VENDING_80
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
03CA:   object 0@ exists 
jf @VENDING_1579 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @VENDING_1484 
if 
   Player.Defined(" + PlayerChar + @")
jf @VENDING_1391 
if 
  1@ == 0 
jf @VENDING_173 
04ED: load_animation ""VENDING"" 
1@ += 1 

:VENDING_173
if 
  1@ == 1 
jf @VENDING_395 
if 
04EE:   animation ""VENDING"" loaded 
jf @VENDING_384 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 0.5 
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @VENDING_377 
if or
   Object.Model(0@) == #VENDIN3
   Object.Model(0@) == #CJ_CANDYVENDOR
   Object.Model(0@) == #CJ_EXT_CANDY
jf @VENDING_343 
03CF: load_wav 42601 as 4 
0512: show_permanent_text_box 'SLOT_04'  // ~k~~VEHICLE_ENTER_EXIT~ - kyЈњ¦© ¤њЈcЁ: $1
jump @VENDING_363 

:VENDING_343
03CF: load_wav 42600 as 4 
0512: show_permanent_text_box 'SLOT_05'  // ~k~~VEHICLE_ENTER_EXIT~ - kyЈњ¦© ®aЈњ¦ok: $1

:VENDING_363
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 0 
1@ += 1 

:VENDING_377
jump @VENDING_395 

:VENDING_384
04ED: load_animation ""VENDING"" 

:VENDING_395
if 
  1@ == 2 
jf @VENDING_1210 
if 
04EE:   animation ""VENDING"" loaded 
jf @VENDING_1199 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -1.0 0.5 
if or
   Object.Model(0@) == #VENDIN3
   Object.Model(0@) == #CJ_CANDYVENDOR
   Object.Model(0@) == #CJ_EXT_CANDY
jf @VENDING_512 
03CF: load_wav 42601 as 4 
jump @VENDING_521 

:VENDING_512
03CF: load_wav 42600 as 4 

:VENDING_521
if 
00FF:   actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @VENDING_1176 
if 
00E1:   player 0 pressed_key 15 
jf @VENDING_1169 
if 
   Player.Controllable(" + PlayerChar + @")
jf @VENDING_1169 
if 
   Player.Money(" + PlayerChar + @") > 0
jf @VENDING_1141 
if 
03D0:   wav 4 loaded 
jf @VENDING_1134 
6@ = Object.Angle(0@)
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 -0.2 0.6 
3@ = Object.Init(#CJ_JUICE_CAN, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
6@ = Object.Angle(0@)
0615: define_AS_pack_begin 4@ 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.2 -1.0 0.0 
0804: AS_actor -1 walk_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" angle 6@ radius 0.4 animation ""VEND_USE"" IFP_file ""VENDING"" 4.0 LA 0 LX 0 LY 0 LF 1 LT 0 
if or
   Object.Model(0@) == #VENDIN3
   Object.Model(0@) == #CJ_CANDYVENDOR
   Object.Model(0@) == #CJ_EXT_CANDY
jf @VENDING_859 
0A1A: actor -1 perform_walk_animation ""VEND_EAT_P"" IFP ""VENDING"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 -1 ms // versionC 
jump @VENDING_1001 

:VENDING_859
07E4: get_model #CJ_JUICE_CAN dimensions_cornerA_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" dimensions_cornerB_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_2 + @" /= 2.0 
" + tempvar_Float_2 + @" += 0.027 
070A: AS_actor -1 attach_to_object 3@ offset 0.062 " + tempvar_Float_2 + @" 0.0 on_bone 5 16 perform_animation ""VEND_USE_PT2"" IFP_file ""VENDING"" time 0 
070A: AS_actor -1 attach_to_object 3@ offset 0.062 " + tempvar_Float_2 + @" 0.0 on_bone 5 16 perform_animation ""VEND_DRINK2_P"" IFP_file ""VENDING"" time 0 

:VENDING_1001
0616: define_AS_pack_end 4@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 4@ 
061B: remove_references_to_AS_pack 4@ 
Player.Money(" + PlayerChar + @") += -1
03E6: remove_text_box 
if or
   Object.Model(0@) == #VENDIN3
   Object.Model(0@) == #CJ_CANDYVENDOR
   Object.Model(0@) == #CJ_EXT_CANDY
jf @VENDING_1076 
03CF: load_wav 42601 as 4 
jump @VENDING_1085 

:VENDING_1076
03CF: load_wav 42600 as 4 

:VENDING_1085
if 
03D0:   wav 4 loaded 
jf @VENDING_1111 
0949: link_wav 4 to_actor " + PlayerActor + @" 
03D1: play_wav 4 

:VENDING_1111
008B: 2@ = " + Current_Time_in_ms2 + @" // (int) 
2@ += 3000 
1@ += 1 

:VENDING_1134
jump @VENDING_1169 

:VENDING_1141
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
018C: play_sound 1053 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 

:VENDING_1169
jump @VENDING_1192 

:VENDING_1176
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
1@ = 1 

:VENDING_1192
jump @VENDING_1210 

:VENDING_1199
04ED: load_animation ""VENDING"" 

:VENDING_1210
if 
  1@ == 3 
jf @VENDING_1324 
062E: get_actor " + PlayerActor + @" task 1560 status_store_to " + _416 + @" // ret 7 if not found 
if 
04A3:   " + _416 + @" == 7 // == constant 
jf @VENDING_1324 
0623: add 5 to_integer_stat 245 
5@ = Actor.Health(" + PlayerActor + @")
5@ += 30 
Actor.Health(" + PlayerActor + @") = 5@
Object.RemoveReferences(3@)
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
008B: 2@ = " + Current_Time_in_ms2 + @" // (int) 
2@ += 1500 
1@ += 1 

:VENDING_1324
if 
  1@ == 4 
jf @VENDING_1384 
if 
001E:   " + Current_Time_in_ms2 + @" > 2@ // (int) 
jf @VENDING_1384 
0687: clear_actor " + PlayerActor + @" task 
04EF: release_animation ""VENDING"" 
1@ = 0 

:VENDING_1384
jump @VENDING_1477 

:VENDING_1391
if 
  1@ > 0 
jf @VENDING_1477 
if 
  1@ > 1 
jf @VENDING_1436 
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:VENDING_1436
if 
  1@ > 2 
jf @VENDING_1459 
Object.RemoveReferences(3@)

:VENDING_1459
04EF: release_animation ""VENDING"" 
1@ = 0 

:VENDING_1477
jump @VENDING_1572 

:VENDING_1484
if 
  1@ > 0 
jf @VENDING_1570 
if 
  1@ > 1 
jf @VENDING_1529 
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:VENDING_1529
if 
  1@ > 2 
jf @VENDING_1552 
Object.RemoveReferences(3@)

:VENDING_1552
04EF: release_animation ""VENDING"" 
1@ = 0 

:VENDING_1570
end_thread 

:VENDING_1572
jump @VENDING_1667 

:VENDING_1579
if 
  1@ > 0 
jf @VENDING_1665 
if 
  1@ > 1 
jf @VENDING_1624 
03E6: remove_text_box 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:VENDING_1624
if 
  1@ > 2 
jf @VENDING_1647 
Object.RemoveReferences(3@)

:VENDING_1647
04EF: release_animation ""VENDING"" 
1@ = 0 

:VENDING_1665
end_thread 

:VENDING_1667
jump @VENDING_80 
end_thread
" );

            }

        }

        private sealed class FVENDOR : External {

            public override void START( LabelJump label ) {
                AppendLine( @"1@ = 0 
if 
  1@ == 1 
jf @FODVEND_58 
0@ = Object.Init(#ICESCART_PROP, 0.0, 0.0, 0.0)

:FODVEND_58
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
03CA:   object 0@ exists 
jf @FODVEND_1130 
if 
0977:   player_in_radius_of_object 0@ external_script_trigger 
jf @FODVEND_1075 
if 
   Player.Defined(" + PlayerChar + @")
jf @FODVEND_1022 
if 
895B:   not is_object_moveable 0@ 
jf @FODVEND_924 
if 
  1@ == 0 
jf @FODVEND_469 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset -1.0 0.0 -1.0 
0086: " + _3404 + @" = " + tempvar_Float_1 + @" // (float) 
" + _3404 + @" -= 0.5 
0086: " + _3405 + @" = " + tempvar_Float_2 + @" // (float) 
" + _3405 + @" -= 0.5 
0086: " + _3406 + @" = " + tempvar_Float_3 + @" // (float) 
0086: " + _3401 + @" = " + tempvar_Float_1 + @" // (float) 
" + _3401 + @" += 0.5 
0086: " + _3402 + @" = " + tempvar_Float_2 + @" // (float) 
" + _3402 + @" += 0.5 
0086: " + _3403 + @" = " + tempvar_Float_3 + @" // (float) 
" + _3403 + @" += 2.0 
if 
8339:   not anything_in_cube_cornerA " + _3404 + @" " + _3405 + @" " + _3406 + @" cornerB " + _3401 + @" " + _3402 + @" " + _3403 + @" solid 0 car 0 actor 1 object 0 particle 0 
jf @FODVEND_462 
if 
80C2:   not sphere_onscreen " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 1.0 
jf @FODVEND_455 
Model.Load(#BMOCHIL)
if 
   Model.Available(#BMOCHIL)
jf @FODVEND_455 
2@ = Actor.Create(CivMale, #BMOCHIL, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to " + _3404 + @" " + _3405 + @" " + _3406 + @" from_object 0@ with_offset 1.0 0.0 0.0 
0061: " + _3404 + @" -= " + tempvar_Float_1 + @" // (float) 
0061: " + _3405 + @" -= " + tempvar_Float_2 + @" // (float) 
0604: get_Z_angle_for_point " + _3404 + @" " + _3405 + @" store_to 5@ 
Actor.Angle(2@) = 5@
1@ += 1 

:FODVEND_455
jump @FODVEND_469 

:FODVEND_462
Model.Destroy(#BMOCHIL)
end_thread 

:FODVEND_469
if 
  1@ == 1 
jf @FODVEND_742 
if 
0472:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 8.0 8.0 sphere 0 on_foot 
jf @FODVEND_742 
04ED: load_animation ""VENDING"" 
if 
04EE:   animation ""VENDING"" loaded 
jf @FODVEND_742 
if 
   Player.Money(" + PlayerChar + @") > 0
jf @FODVEND_742 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 1.0 0.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @FODVEND_742 
4@ = Actor.Health(" + PlayerActor + @")
4@ += 50 
Actor.Health(" + PlayerActor + @") = 4@
0A1A: actor " + PlayerActor + @" perform_walk_animation ""VEND_EAT1_P"" IFP ""VENDING"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 -1 ms // versionC 
0623: add 10 to_integer_stat 245 
008B: 3@ = " + Current_Time_in_ms2 + @" // (int) 
3@ += 3000 
Player.Money(" + PlayerChar + @") += -1
1@ += 1 

:FODVEND_742
if 
  1@ == 2 
jf @FODVEND_802 
if 
001E:   " + Current_Time_in_ms2 + @" > 3@ // (int) 
jf @FODVEND_802 
008B: 3@ = " + Current_Time_in_ms2 + @" // (int) 
3@ += 27000 
1@ += 1 

:FODVEND_802
if 
  1@ == 3 
jf @FODVEND_917 
if 
001E:   " + Current_Time_in_ms2 + @" > 3@ // (int) 
jf @FODVEND_917 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 1.0 0.0 0.0 
if 
80FF:   not actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @FODVEND_917 
1@ = 1 

:FODVEND_917
jump @FODVEND_1015 

:FODVEND_924
if 
  1@ > 0 
jf @FODVEND_1008 
Actor.RemoveReferences(2@)
if 
   Player.Defined(" + PlayerChar + @")
jf @FODVEND_990 
if 
   not Actor.Dead(2@)
jf @FODVEND_990 
07A5: AS_actor 2@ attack_actor " + PlayerActor + @" time 10000 

:FODVEND_990
04EF: release_animation ""VENDING"" 
1@ = 0 

:FODVEND_1008
Model.Destroy(#BMOCHIL)
end_thread 

:FODVEND_1015
jump @FODVEND_1068 

:FODVEND_1022
if 
  1@ > 0 
jf @FODVEND_1063 
Actor.RemoveReferences(2@)
04EF: release_animation ""VENDING"" 
1@ = 0 

:FODVEND_1063
Model.Destroy(#BMOCHIL)

:FODVEND_1068
jump @FODVEND_1123 

:FODVEND_1075
if 
  1@ > 0 
jf @FODVEND_1116 
Actor.RemoveReferences(2@)
04EF: release_animation ""VENDING"" 
1@ = 0 

:FODVEND_1116
Model.Destroy(#BMOCHIL)
end_thread 

:FODVEND_1123
jump @FODVEND_1178 

:FODVEND_1130
if 
  1@ > 0 
jf @FODVEND_1171 
Actor.RemoveReferences(2@)
04EF: release_animation ""VENDING"" 
1@ = 0 

:FODVEND_1171
Model.Destroy(#BMOCHIL)
end_thread 

:FODVEND_1178
jump @FODVEND_58 
end_thread
" );

            }

        }

        private sealed class HOTDOGV : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @HOTDOGV_77 
0@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
1@ = Car.Create(#HOTDOG, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:HOTDOGV_77
wait 0 
01BD: " + Current_Time_in_ms2 + @" = current_time_in_ms 
if 
   not Actor.Dead(0@)
jf @HOTDOGV_698 
if 
   Player.Defined(" + PlayerChar + @")
jf @HOTDOGV_673 
if 
0A32:   actor 0@ on_turret_of_car 
jf @HOTDOGV_648 
0A33: get_car_ped_is_attached_to 0@ store_to 1@ 
if 
   not Actor.InCar(" + PlayerActor + @", 1@)
jf @HOTDOGV_616 
if 
  2@ == 0 
jf @HOTDOGV_434 
if 
0203:   actor " + PlayerActor + @" near_car 1@ radius 12.0 12.0 flag 0 on_foot 
jf @HOTDOGV_434 
04ED: load_animation ""VENDING"" 
if 
04EE:   animation ""VENDING"" loaded 
jf @HOTDOGV_434 
if 
   Player.Money(" + PlayerChar + @") > 0
jf @HOTDOGV_434 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 1@ with_offset 2.0 0.0 0.0 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @HOTDOGV_434 
4@ = Actor.Health(" + PlayerActor + @")
4@ += 50 
Actor.Health(" + PlayerActor + @") = 4@
0A1A: actor " + PlayerActor + @" perform_walk_animation ""VEND_EAT1_P"" IFP ""VENDING"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 0 -1 ms // versionC 
0623: add 10 to_integer_stat 245 
008B: 3@ = " + Current_Time_in_ms2 + @" // (int) 
3@ += 3000 
Player.Money(" + PlayerChar + @") += -1
2@ += 1 

:HOTDOGV_434
if 
  2@ == 1 
jf @HOTDOGV_494 
if 
001E:   " + Current_Time_in_ms2 + @" > 3@ // (int) 
jf @HOTDOGV_494 
008B: 3@ = " + Current_Time_in_ms2 + @" // (int) 
3@ += 27000 
2@ += 1 

:HOTDOGV_494
if 
  2@ == 2 
jf @HOTDOGV_609 
if 
001E:   " + Current_Time_in_ms2 + @" > 3@ // (int) 
jf @HOTDOGV_609 
0407: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_car 1@ with_offset 1.0 0.0 0.0 
if 
80FF:   not actor " + PlayerActor + @" sphere 0 in_sphere " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.6 0.6 1.0 on_foot 
jf @HOTDOGV_609 
2@ = 0 

:HOTDOGV_609
jump @HOTDOGV_641 

:HOTDOGV_616
Actor.RemoveReferences(0@)
05C5: AS_actor 0@ cower -2 ms 
04EF: release_animation ""VENDING"" 
end_thread 

:HOTDOGV_641
jump @HOTDOGV_666 

:HOTDOGV_648
Actor.RemoveReferences(0@)
04EF: release_animation ""VENDING"" 
end_thread 

:HOTDOGV_666
jump @HOTDOGV_691 

:HOTDOGV_673
Actor.RemoveReferences(0@)
04EF: release_animation ""VENDING"" 
end_thread 

:HOTDOGV_691
jump @HOTDOGV_716 

:HOTDOGV_698
Actor.RemoveReferences(0@)
04EF: release_animation ""VENDING"" 
end_thread 

:HOTDOGV_716
jump @HOTDOGV_77 
end_thread 
" );

            }

        }

    }

}