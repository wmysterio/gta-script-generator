using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalBasketball : Original {

        internal OriginalBasketball() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            
            Script.Ignore = delegate {
                Script.create_thread<BBCHAL>();
                Script.create_thread<PROJECT>();
            };

            _1903.value = true;
            Script.init_external_script_trigger_with_object_model<BBALL>( 946, 100, 70.0, -1 );
            Script.init_external_script_trigger_with_object_model<BBALL>( 947, 100, 70.0, -1 );
            Script.init_external_script_trigger_with_object_model<BBALL>( 3496, 100, 70.0, -1 );
            Script.init_external_script_trigger_with_object_model<BBALL>( 3497, 100, 70.0, -1 );
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class BBALL : External {

            Int _local0 = local( 0 ), // 0@
                _local1 = local( 1 ), // 1@
                _local2 = local( 2 ), // 2@
                _local3 = local( 3 ), // 3@
                _local4 = local( 4 ), // 4@
                _local8 = local( 8 ); // 8@

            public override void START( LabelJump label ) {
                AppendLine( @"if 
   not " + _1928 + @" == 0 
jf @BBALL_31 
end_thread 

:BBALL_31
16@ = 0 
17@ = 0 
18@ = 0 
20@ = 0 
22@ = 0 
" + _8786 + @" = 0 
19@ = 0 
21@ = 0 
" + _1925 + @" = 0 
if 
  16@ == -1 
jf @BBALL_178 
0@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
1@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
" + _8782 + @" = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)

:BBALL_178
24@ = 0 
if 
   not " + _1903 + @" == 0 
jf @BBALL_451 
if 
03CA:   object 0@ exists 
jf @BBALL_451 
if and
   Player.Defined(" + PlayerChar + @")
  " + OnMission + @" == 0 
jf @BBALL_451 
if 
   Object.Model(0@) == #BSKBALL_LAX
jf @BBALL_296 
if 
   Model.Available(#BSKBALL_LAX)
jf @BBALL_289 
23@ = -30 
24@ = 1 

:BBALL_289
jump @BBALL_451 

:BBALL_296
if 
   Object.Model(0@) == #BSKBALLHUB_LAX01
jf @BBALL_350 
if 
   Model.Available(#BSKBALLHUB_LAX01)
jf @BBALL_343 
23@ = -31 
24@ = 1 

:BBALL_343
jump @BBALL_451 

:BBALL_350
if 
   Object.Model(0@) == #VGSXREFBBALLNET
jf @BBALL_404 
if 
   Model.Available(#VGSXREFBBALLNET)
jf @BBALL_397 
23@ = -32 
24@ = 1 

:BBALL_397
jump @BBALL_451 

:BBALL_404
if 
   Object.Model(0@) == #VGSXREFBBALLNET2
jf @BBALL_451 
if 
   Model.Available(#VGSXREFBBALLNET2)
jf @BBALL_451 
23@ = -33 
24@ = 1 

:BBALL_451
if 
  24@ == 1 
jf @BBALL_2377 
0871: init_jump_table 16@ total_jumps 4 default_jump 0 @BBALL_2370 jumps 0 @BBALL_532 1 @BBALL_777 2 @BBALL_1293 3 @BBALL_1866 -1 @BBALL_2370 -1 @BBALL_2370 -1 @BBALL_2370 

:BBALL_532
if 
  " + _1928 + @" == 0 
jf @BBALL_763 
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 50.0 50.0 sphere 0 
jf @BBALL_756 
if 
83CA:   not object 1@ exists 
jf @BBALL_756 
if 
   Model.Available(23@)
jf @BBALL_756 
080A: get_object 0@ spoot 1 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
80C2:   not sphere_onscreen " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 2.0 
jf @BBALL_756 
" + tempvar_Float_3 + @" += 1.0 
0395: clear_area 0 at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" radius 0.5 
1@ = Object.Init(#BBALL_COL, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
19@ = 1 
Object.ToggleInMovingList(1@) = True
Object.CollisionDetection(1@) = True
Object.Throw(1@, 0.0, 0.0, -0.1)
" + _1928 + @" = 1 
16@ += 1 

:BBALL_756
jump @BBALL_770 

:BBALL_763
gosub @BBALL_2402 

:BBALL_770
jump @BBALL_2370 

:BBALL_777
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 50.0 50.0 sphere 0 
jf @BBALL_1267 
if 
03CA:   object 1@ exists 
jf @BBALL_1260 
if 
0475:   actor " + PlayerActor + @" near_object_in_cube 1@ radius 1.0 1.0 2.0 sphere 0 on_foot 
jf @BBALL_1260 
if 
   Model.Available(23@)
jf @BBALL_1260 
080A: get_object 0@ spoot 2 store_to 2@ 3@ 4@ 
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 
if 
04EA:   object 1@ in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ flag 0 
jf @BBALL_1220 
if 
0475:   actor " + PlayerActor + @" near_object_in_cube 1@ radius 0.7 0.7 2.0 sphere 0 on_foot 
jf @BBALL_1213 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0089: 2@ = " + tempvar_Float_1 + @" // (float) 
2@ -= 0.71 
0089: 3@ = " + tempvar_Float_2 + @" // (float) 
3@ -= 0.71 
0089: 4@ = " + tempvar_Float_3 + @" // (float) 
4@ -= 0.71 
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
5@ += 0.71 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
6@ += 0.71 
0089: 7@ = " + tempvar_Float_3 + @" // (float) 
7@ += 2.0 
if 
8339:   not anything_in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ solid 0 car 1 actor 0 object 0 particle 0 
jf @BBALL_1213 
if 
8A0C:   not player " + PlayerChar + @" on_jetpack 
jf @BBALL_1213 
062E: get_actor " + PlayerActor + @" task 1833 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_1213 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 0 
0512: show_permanent_text_box 'BB_01'  // ~k~~VEHICLE_ENTER_EXIT~ - cЁ™pa¦© ў —acke¦—oћ.
16@ += 1 

:BBALL_1213
jump @BBALL_1260 

:BBALL_1220
080A: get_object 0@ spoot 1 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += 1.0 
Object.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BBALL_1260
jump @BBALL_1286 

:BBALL_1267
Object.RemoveReferences(1@)
16@ = 0 
" + _1928 + @" = 0 

:BBALL_1286
jump @BBALL_2370 

:BBALL_1293
if 
0471:   actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 50.0 50.0 sphere 0 
jf @BBALL_1833 
if 
03CA:   object 1@ exists 
jf @BBALL_1826 
if 
8A0C:   not player " + PlayerChar + @" on_jetpack 
jf @BBALL_1826 
062E: get_actor " + PlayerActor + @" task 1833 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_1826 
if 
   Model.Available(23@)
jf @BBALL_1826 
080A: get_object 0@ spoot 2 store_to 2@ 3@ 4@ 
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 
if 
04EA:   object 1@ in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ flag 0 
jf @BBALL_1810 
if 
0475:   actor " + PlayerActor + @" near_object_in_cube 1@ radius 0.7 0.7 2.0 sphere 0 on_foot 
jf @BBALL_1787 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0089: 2@ = " + tempvar_Float_1 + @" // (float) 
2@ -= 0.71 
0089: 3@ = " + tempvar_Float_2 + @" // (float) 
3@ -= 0.71 
0089: 4@ = " + tempvar_Float_3 + @" // (float) 
4@ -= 0.71 
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
5@ += 0.71 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
6@ += 0.71 
0089: 7@ = " + tempvar_Float_3 + @" // (float) 
7@ += 2.0 
if 
8339:   not anything_in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ solid 0 car 1 actor 0 object 0 particle 0 
jf @BBALL_1764 
if 
  20@ == 0 
jf @BBALL_1733 
if 
00E1:   player 0 pressed_key 15 
jf @BBALL_1726 
20@ = 1 
03E6: remove_text_box 
gosub @BBALL_3690 
16@ += 1 

:BBALL_1726
jump @BBALL_1757 

:BBALL_1733
if 
80E1:   not player 0 pressed_key 15 
jf @BBALL_1757 
20@ = 0 

:BBALL_1757
jump @BBALL_1780 

:BBALL_1764
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
03E6: remove_text_box 
16@ += -1 

:BBALL_1780
jump @BBALL_1803 

:BBALL_1787
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
03E6: remove_text_box 
16@ += -1 

:BBALL_1803
jump @BBALL_1826 

:BBALL_1810
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
03E6: remove_text_box 
16@ += -1 

:BBALL_1826
jump @BBALL_1859 

:BBALL_1833
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
Object.RemoveReferences(1@)
" + _1928 + @" = 0 
16@ = 0 

:BBALL_1859
jump @BBALL_2370 

:BBALL_1866
if 
   Model.Available(23@)
jf @BBALL_2363 
080A: get_object 0@ spoot 2 store_to 2@ 3@ 4@ 
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 
if 
80A4:   not actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ 
jf @BBALL_2049 
if 
  6000 > TIMERB 
jf @BBALL_2028 
if and
  TIMERB > 0 
  1000 > TIMERB 
jf @BBALL_2014 
0512: show_permanent_text_box 'BB_03'  // ЏЁ љoћ›e® ўep®y¦©c¬ ®a ЈћoЎaљky, ¤¦o—Ё Јpoљoћ›њ¦© њ™py, ћњ—o ®a›a¦© ~k~~VEHICLE_ENTER_EXIT~, ¤¦o—Ё џako®¤њ¦© њ™py.
TIMERB = 1000 

:BBALL_2014
gosub @BBALL_4421 
jump @BBALL_2042 

:BBALL_2028
gosub @BBALL_5022 
16@ = 1 

:BBALL_2042
jump @BBALL_2084 

:BBALL_2049
if 
  TIMERB > 1000 
jf @BBALL_2070 
03E6: remove_text_box 

:BBALL_2070
gosub @BBALL_4421 
TIMERB = 0 

:BBALL_2084
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_2132 
if 
031D:   actor " + PlayerActor + @" hit_by_weapon 57 
jf @BBALL_2132 
gosub @BBALL_5022 
16@ = 1 

:BBALL_2132
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_2178 
if 
0A0C:   player " + PlayerChar + @" on_jetpack 
jf @BBALL_2178 
gosub @BBALL_5022 
16@ = 1 

:BBALL_2178
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_2237 
062E: get_actor " + PlayerActor + @" task 1833 status_store_to 24@ // ret 7 if not found 
if 
84A4:   not  24@ == 7 // == constant 
jf @BBALL_2237 
gosub @BBALL_5022 
16@ = 1 

:BBALL_2237
if and
   not 17@ == 10 
   not 17@ == 16 
   not 17@ == 17 
   not 17@ == 4 
jf @BBALL_2363 
if 
  20@ == 0 
jf @BBALL_2339 
if 
00E1:   player 0 pressed_key 15 
jf @BBALL_2332 
20@ = 1 
gosub @BBALL_5022 
16@ = 1 

:BBALL_2332
jump @BBALL_2363 

:BBALL_2339
if 
80E1:   not player 0 pressed_key 15 
jf @BBALL_2363 
20@ = 0 

:BBALL_2363
jump @BBALL_2370 

:BBALL_2370
jump @BBALL_2391 

:BBALL_2377
" + _1928 + @" = 0 
gosub @BBALL_2402 

:BBALL_2391
wait 0 
jump @BBALL_178 

:BBALL_2402
Object.RemoveReferences(1@)
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_2448 
if 
  " + OnMission + @" == 0 
jf @BBALL_2448 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 

:BBALL_2448
end_thread 
return 
if 
0736:   is_keyboard_key_just_pressed 131 
jf @BBALL_2478 
" + _8784 + @" += 0.01 

:BBALL_2478
if 
0736:   is_keyboard_key_just_pressed 130 
jf @BBALL_2504 
" + _8784 + @" += -0.01 

:BBALL_2504
return 

:BBALL_2506
if 
03CA:   object 1@ exists 
jf @BBALL_2860 
if 
0685:   object 1@ attached 
jf @BBALL_2729 
if 
  19@ == 1 
jf @BBALL_2722 
0682: detach_object 1@ 0.0 0.0 0.0 collision_detection 0 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
059F: get_object 1@ velocity_in_direction 2@ 3@ 4@ 
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.Destroy(1@)
1@ = Object.Init(#BBALL_INGAME, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
069B: attach_object 1@ to_actor " + PlayerActor + @" with_offset 0.0 0.5 -1.0 rotation 0.0 0.0 0.0 
Object.Throw(1@, 2@, 3@, 4@)
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.CollisionDetection(1@) = True
19@ = 0 

:BBALL_2722
jump @BBALL_2860 

:BBALL_2729
if 
  19@ == 0 
jf @BBALL_2860 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
059F: get_object 1@ velocity_in_direction 2@ 3@ 4@ 
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.Destroy(1@)
1@ = Object.Init(#BBALL_COL, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.ToggleInMovingList(1@) = True
Object.CollisionDetection(1@) = True
Object.Throw(1@, 2@, 3@, 4@)
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
19@ = 1 

:BBALL_2860
return 

:BBALL_2862
if 
03CA:   object 1@ exists 
jf @BBALL_3688 
if 
0685:   object 1@ attached 
jf @BBALL_3085 
if 
  19@ == 1 
jf @BBALL_3078 
0682: detach_object 1@ 0.0 0.0 0.0 collision_detection 0 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
059F: get_object 1@ velocity_in_direction 2@ 3@ 4@ 
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.Destroy(1@)
1@ = Object.Init(#BBALL_INGAME, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
069B: attach_object 1@ to_actor " + PlayerActor + @" with_offset 0.0 0.5 -1.0 rotation 0.0 0.0 0.0 
Object.Throw(1@, 2@, 3@, 4@)
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.CollisionDetection(1@) = True
19@ = 0 

:BBALL_3078
jump @BBALL_3688 

:BBALL_3085
if 
  19@ == 0 
jf @BBALL_3688 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor " + PlayerActor + @" with_offset 0.0 0.5 0.0 
0089: 2@ = " + tempvar_Float_1 + @" // (float) 
2@ -= 0.1 
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
5@ += 0.1 
0089: 3@ = " + tempvar_Float_2 + @" // (float) 
3@ -= 0.1 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
6@ += 0.1 
0089: 4@ = " + tempvar_Float_3 + @" // (float) 
4@ -= 0.5 
0089: 7@ = " + tempvar_Float_3 + @" // (float) 
7@ += 1.0 
if 
8339:   not anything_in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ solid 0 car 1 actor 0 object 0 particle 0 
jf @BBALL_3393 
059F: get_object 1@ velocity_in_direction 2@ 3@ 4@ 
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.Destroy(1@)
1@ = Object.Init(#BBALL_COL, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.ToggleInMovingList(1@) = True
Object.CollisionDetection(1@) = True
Object.Throw(1@, 0.0, 0.0, -0.1)
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
19@ = 1 
jump @BBALL_3688 

:BBALL_3393
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor " + PlayerActor + @" with_offset 0.0 -2.0 -0.3 
0089: 2@ = " + tempvar_Float_1 + @" // (float) 
2@ -= 0.1 
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
5@ += 0.1 
0089: 3@ = " + tempvar_Float_2 + @" // (float) 
3@ -= 0.1 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
6@ += 0.1 
0089: 4@ = " + tempvar_Float_3 + @" // (float) 
4@ -= 0.5 
0089: 7@ = " + tempvar_Float_3 + @" // (float) 
7@ += 1.0 
if 
8339:   not anything_in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ solid 0 car 1 actor 0 object 0 particle 0 
jf @BBALL_3683 
059F: get_object 1@ velocity_in_direction 2@ 3@ 4@ 
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
Object.Destroy(1@)
1@ = Object.Init(#BBALL_COL, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.ToggleInMovingList(1@) = True
Object.CollisionDetection(1@) = True
Object.Throw(1@, 0.0, 0.0, -0.1)
05A6: get_object 1@ rotation_velocity_about_an_axis_X 5@ axis_Y 6@ axis_Z 7@ through_center_of_body 
19@ = 1 
jump @BBALL_3688 

:BBALL_3683
Object.Destroy(1@)

:BBALL_3688
return 

:BBALL_3690
09BD: allow_other_threads_to_display_text_boxes 1 
0A44: override_text_block 1 
" + _8784 + @" = 0.4 
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 0 
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_3863 
Player.CanMove(" + PlayerChar + @") = False
0687: clear_actor " + PlayerActor + @" task 
Actor.SetImmunities(" + PlayerActor + @", 0, 0, 0, 0, 0)
0467: clear_actor " + PlayerActor + @" last_weapon_damage 
0470: " + _8788 + @" = actor " + PlayerActor + @" current_weapon 
if 
   Actor.HasWeapon(" + PlayerActor + @", 1)
jf @BBALL_3842 
0555: remove_weapon 1 from_actor " + PlayerActor + @" 
" + _8789 + @" = 1 
Model.Load(#BRASSKNUCKLE)

:BBALL_3808
if 
   not Model.Available(#BRASSKNUCKLE)
jf @BBALL_3835 
wait 0 
jump @BBALL_3808 

:BBALL_3835
jump @BBALL_3849 

:BBALL_3842
" + _8789 + @" = 0 

:BBALL_3849
01B9: set_actor " + PlayerActor + @" armed_weapon_to 0 
0992: set_player " + PlayerChar + @" weapons_scrollable 0 

:BBALL_3863
if 
03CA:   object 1@ exists 
jf @BBALL_3886 
Object.KeepInMemory(1@) = True

:BBALL_3886
04ED: load_animation ""BSKTBALL"" 
Model.Load(#BBALL_INGAME)
Model.Load(#BBALL_COL)
03CF: load_wav 1811 as 4 

:BBALL_3915
if or
84EE:   not animation ""BSKTBALL"" loaded 
   not Model.Available(#BBALL_INGAME)
   not Model.Available(#BBALL_COL)
83D0:   not wav 4 loaded 
jf @BBALL_3963 
wait 0 
jump @BBALL_3915 

:BBALL_3963
068D: get_camera_position_to 10@ 11@ 12@ 
068E: get_camera_target_point_to 13@ 14@ 15@ 
0088: " + tempvar_Float_1 + @" = 13@ // (float) 
0067: " + tempvar_Float_1 + @" -= 10@ // (float) 
0088: " + tempvar_Float_2 + @" = 14@ // (float) 
0067: " + tempvar_Float_2 + @" -= 11@ // (float) 
0088: " + tempvar_Float_3 + @" = 15@ // (float) 
0067: " + tempvar_Float_3 + @" -= 12@ // (float) 
050A: " + Distance_Between_Points + @" = distance_between_XYZ 13@ 14@ 15@ and_XYZ 10@ 11@ 12@ 
0071: " + tempvar_Float_1 + @" /= " + Distance_Between_Points + @" // (float) 
0071: " + tempvar_Float_2 + @" /= " + Distance_Between_Points + @" // (float) 
0071: " + tempvar_Float_3 + @" /= " + Distance_Between_Points + @" // (float) 
" + tempvar_Float_1 + @" *= 10.0 
" + tempvar_Float_2 + @" *= 10.0 
" + tempvar_Float_3 + @" *= 10.0 
0087: 13@ = 10@ // (float) 
005D: 13@ += " + tempvar_Float_1 + @" // (float) 
0087: 14@ = 11@ // (float) 
005D: 14@ += " + tempvar_Float_2 + @" // (float) 
0087: 15@ = 12@ // (float) 
005D: 15@ += " + tempvar_Float_3 + @" // (float) 
TIMERA = 0 
" + _1925 + @" = 0 
17@ = 10 
" + _8786 + @" = 1 
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_4238 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0086: " + _8790 + @" = " + tempvar_Float_3 + @" // (float) 

:BBALL_4238
8@ = Object.Angle(0@)
if or
  10.0 > 8@ 
  8@ > 350.0 
jf @BBALL_4284 
" + _8791 + @" = 1 

:BBALL_4284
if and
  8@ > 80.0 
  100.0 > 8@ 
jf @BBALL_4322 
" + _8791 + @" = 2 

:BBALL_4322
if and
  8@ > 170.0 
  190.0 > 8@ 
jf @BBALL_4360 
" + _8791 + @" = 3 

:BBALL_4360
if and
  8@ > 260.0 
  280.0 > 8@ 
jf @BBALL_4398 
" + _8791 + @" = 4 

:BBALL_4398
03DE: set_pedestrians_density_multiplier_to 0.2 
01EB: set_traffic_density_multiplier_to 0.2 
" + _8787 + @" = 1 
return 

:BBALL_4421
" + _8785 + @" += 1 
if 
  " + _8785 + @" >= 30 
jf @BBALL_4453 
" + _8785 + @" = 0 

:BBALL_4453
gosub @BBALL_16392 
gosub @BBALL_17991 
gosub @BBALL_5427 
gosub @BBALL_12253 
if 
0736:   is_keyboard_key_just_pressed 67 
jf @BBALL_4503 
gosub @BBALL_20949 

:BBALL_4503
if 
  3 > " + _1925 + @" 
jf @BBALL_4746 
if 
  " + _1925 + @" == 0 
jf @BBALL_4582 
if 
  " + _1921 + @" == 0 
jf @BBALL_4568 
03E5: show_text_box 'BB_02'  // €a›Їњ ~k~~PED_SPRINT~, ¤¦o—Ё —pocњ¦© Ї¬¤. O¦Јyc¦њ ~k~~PED_SPRINT~ ў ¦o¦ ЇoЇe®¦, ko™љa ¦Ё ®axoљњҐ©c¬ ў caЇoќ ўepx®eќ ¦o¤ke cўoe™o ЈpЁ›ka, ¤¦o—Ё ЈoЈaљa®њe —Ёћo —oћee ¦o¤®ЁЇ.

:BBALL_4568
" + _1925 + @" += 1 
TIMERA = 0 

:BBALL_4582
if and
  " + _1925 + @" == 1 
  TIMERA > 10000 
jf @BBALL_4651 
if 
  " + _1921 + @" == 0 
jf @BBALL_4637 
03E5: show_text_box 'BB_07'  // Њoљoќљњ k Ї¬¤y, њ CJ aў¦oЇa¦њ¤eckњ Јoљ—epe¦ e™o.~N~~k~~VEHICLE_ENTER_EXIT~ - џako®¤њ¦© њ™py.

:BBALL_4637
TIMERA = 0 
" + _1925 + @" += 1 

:BBALL_4651
if and
  " + _1925 + @" == 2 
  TIMERA > 5000 
jf @BBALL_4746 
if or
   Object.Model(0@) == #BSKBALL_LAX
   Object.Model(0@) == #VGSXREFBBALLNET
jf @BBALL_4731 
if 
  " + _1921 + @" == 0 
jf @BBALL_4731 
03E5: show_text_box 'BB_09'  // ~k~~PED_LOOKBEHIND~ - ®a¤a¦© pe›њЇ copeў®oўa®њ¬.

:BBALL_4731
TIMERA = 12000 
" + _1925 + @" += 1 

:BBALL_4746
if or
   Object.Model(0@) == #BSKBALL_LAX
   Object.Model(0@) == #VGSXREFBBALLNET
jf @BBALL_4873 
if 
  " + _1921 + @" == 0 
jf @BBALL_4873 
if 
  " + _1016 + @" == 0 
jf @BBALL_4849 
if 
00E1:   player 0 pressed_key 19 
jf @BBALL_4842 
" + _1016 + @" = 1" );
                create_thread<BBCHAL>( _local0 );
AppendLine( @"
:BBALL_4842
jump @BBALL_4873 

:BBALL_4849
if 
80E1:   not player 0 pressed_key 19 
jf @BBALL_4873 
" + _1016 + @" = 0 

:BBALL_4873
if 
  " + _8785 + @" == 0 
jf @BBALL_5020 
if 
03CA:   object 1@ exists 
jf @BBALL_5020 
if 
8685:   not object 1@ attached 
jf @BBALL_5020 
if 
   Model.Available(23@)
jf @BBALL_5020 
080A: get_object 0@ spoot 1 store_to 2@ 3@ 4@ 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0087: 8@ = 4@ // (float) 
8@ -= 0.7 
if 
0027:   8@ > " + tempvar_Float_3 + @" // (float) 
jf @BBALL_5020 
Object.PutAt(1@, 2@, 3@, 4@)

:BBALL_5020
return 

:BBALL_5022
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_5425 
if 
  " + _8789 + @" == 1 
jf @BBALL_5077 
Actor.GiveWeaponAndAmmo(" + PlayerActor + @", BrassKnuckles, 1)
" + _8789 + @" = 0 
Model.Destroy(#BRASSKNUCKLE)

:BBALL_5077
01B9: set_actor " + PlayerActor + @" armed_weapon_to " + _8788 + @" 
0992: set_player " + PlayerChar + @" weapons_scrollable 1 
0687: clear_actor " + PlayerActor + @" task 
Player.CanMove(" + PlayerChar + @") = True
07CC: set_player " + PlayerChar + @" can_enter_exit_vehicles 1 
if 
03CA:   object 1@ exists 
jf @BBALL_5172 
if 
0685:   object 1@ attached 
jf @BBALL_5172 
0682: detach_object 1@ 0.0 0.0 0.0 collision_detection 1 
gosub @BBALL_2862 

:BBALL_5172
if 
03CA:   object 1@ exists 
jf @BBALL_5312 
if 
   Model.Available(23@)
jf @BBALL_5252 
080A: get_object 0@ spoot 1 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
080A: get_object 0@ spoot 2 store_to 2@ 3@ 4@ 
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 

:BBALL_5252
if 
84EA:   not object 1@ in_cube_cornerA 2@ 3@ 4@ cornerB 5@ 6@ 7@ flag 0 
jf @BBALL_5312 
" + tempvar_Float_3 + @" += 1.0 
Object.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:BBALL_5312
if 
03CA:   object " + _8782 + @" exists 
jf @BBALL_5363 
if 
  22@ == 1 
jf @BBALL_5358 
0465: remove_actor " + PlayerActor + @" from_turret_mode 
22@ = 0 

:BBALL_5358
Object.Destroy(" + _8782 + @")

:BBALL_5363
Camera.Restore
" + _8786 + @" = 0 
04EF: release_animation ""BSKTBALL"" 
Model.Destroy(#BBALL_INGAME)
Model.Destroy(#BBALL_COL)
040D: unload_wav 4 
03E6: remove_text_box 
" + _8787 + @" = 0 
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
09BD: allow_other_threads_to_display_text_boxes 0 

:BBALL_5425
return 

:BBALL_5427
if and
   Player.Defined(" + PlayerChar + @")
   Model.Available(23@)
jf @BBALL_12243 
0871: init_jump_table 17@ total_jumps 17 default_jump 1 @BBALL_12243 jumps 1 @BBALL_6511 2 @BBALL_7044 3 @BBALL_7454 4 @BBALL_8450 5 @BBALL_8941 6 @BBALL_9115 7 @BBALL_11357 
0872: jump_table_jumps 8 @BBALL_11547 9 @BBALL_11747 10 @BBALL_11761 11 @BBALL_8260 12 @BBALL_11754 13 @BBALL_9065 14 @BBALL_5641 15 @BBALL_6075 16 @BBALL_9667 
0872: jump_table_jumps 17 @BBALL_10656 -1 @BBALL_12243 -1 @BBALL_12243 -1 @BBALL_12243 -1 @BBALL_12243 -1 @BBALL_12243 -1 @BBALL_12243 -1 @BBALL_12243 -1 @BBALL_12243 

:BBALL_5641
if 
   not 18@ == 14 
jf @BBALL_5905 
24@ = 0 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_5757 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_IDLELOOP"" time 
if 
  8@ > 0.9 
jf @BBALL_5757 
24@ = 1 
" + _8792 + @" = 0 

:BBALL_5757
if 
  24@ == 1 
jf @BBALL_5891 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_IDLE"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
jump @BBALL_5898 

:BBALL_5891
jump @BBALL_12251 

:BBALL_5898
jump @BBALL_6068 

:BBALL_5905
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_5955 
17@ = 11 
jump @BBALL_5427 
jump @BBALL_6068 

:BBALL_5955
if 
  " + _8792 + @" == 0 
jf @BBALL_6015 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLE""
jf @BBALL_6008 
" + _8792 + @" += 1 

:BBALL_6008
jump @BBALL_6068 

:BBALL_6015
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_6068 
17@ = 11 
" + _8792 + @" = 0 
jump @BBALL_5427 

:BBALL_6068
jump @BBALL_12243 

:BBALL_6075
if 
   not 18@ == 15 
jf @BBALL_6340 
24@ = 0 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_6191 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_IDLELOOP"" time 
if 
  8@ > 0.9 
jf @BBALL_6191 
" + _8793 + @" = 0 
24@ = 1 

:BBALL_6191
if 
  24@ == 1 
jf @BBALL_6326 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_IDLE2"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
jump @BBALL_6333 

:BBALL_6326
jump @BBALL_12251 

:BBALL_6333
jump @BBALL_6504 

:BBALL_6340
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_6390 
17@ = 11 
jump @BBALL_5427 
jump @BBALL_6504 

:BBALL_6390
if 
  " + _8793 + @" == 0 
jf @BBALL_6451 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLE2""
jf @BBALL_6444 
" + _8793 + @" += 1 

:BBALL_6444
jump @BBALL_6504 

:BBALL_6451
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_6504 
17@ = 11 
" + _8793 + @" = 0 
jump @BBALL_5427 

:BBALL_6504
jump @BBALL_12243 

:BBALL_6511
if or
  18@ == 11 
  18@ == 2 
  18@ == 3 
  18@ == 10 
jf @BBALL_6944 
if and
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_PICKUP""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_L""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_R""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_WALKSTOP_L""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_WALKSTOP_R""
jf @BBALL_6930 
" + _8794 + @" = 0 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_6725 
0613: " + _8795 + @" = actor " + PlayerActor + @" animation ""BBALL_RUN"" time 

:BBALL_6725
0615: define_AS_pack_begin 26@ 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_6864 
0812: AS_actor -1 perform_animation ""BBALL_WALK_START"" IFP ""BSKTBALL"" framedelta 8.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_WALK"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 1 lockX 1 lockY 1 lockF 0 time -1 // versionB 
" + _8794 + @" = 1 
jump @BBALL_6905 

:BBALL_6864
0812: AS_actor -1 perform_animation ""BBALL_WALK"" IFP ""BSKTBALL"" framedelta 8.0 loopA 1 lockX 1 lockY 1 lockF 0 time -1 // versionB 

:BBALL_6905
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
jump @BBALL_6937 

:BBALL_6930
jump @BBALL_12251 

:BBALL_6937
jump @BBALL_7037 

:BBALL_6944
if 
  " + _8794 + @" == 0 
jf @BBALL_7037 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK""
jf @BBALL_7037 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_WALK"" time 
0614: set_actor " + PlayerActor + @" animation ""BBALL_WALK"" progress_to " + _8795 + @" // 0.0 to 1.0 
" + _8794 + @" += 1 

:BBALL_7037
jump @BBALL_12243 

:BBALL_7044
if or
  18@ == 11 
  18@ == 1 
  18@ == 3 
  18@ == 10 
jf @BBALL_7376 
if 
  18@ == 11 
jf @BBALL_7115 
17@ = 1 
jump @BBALL_5427 

:BBALL_7115
if and
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_PICKUP""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_L""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_R""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_WALKSTOP_L""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_WALKSTOP_R""
jf @BBALL_7362 
" + _8796 + @" = 0 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK""
jf @BBALL_7292 
0613: " + _8797 + @" = actor " + PlayerActor + @" animation ""BBALL_WALK"" time 

:BBALL_7292
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_RUN"" IFP ""BSKTBALL"" framedelta 8.0 loopA 1 lockX 1 lockY 1 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
jump @BBALL_7369 

:BBALL_7362
jump @BBALL_12251 

:BBALL_7369
jump @BBALL_7447 

:BBALL_7376
if 
  " + _8796 + @" == 0 
jf @BBALL_7447 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_7447 
0614: set_actor " + PlayerActor + @" animation ""BBALL_RUN"" progress_to " + _8797 + @" // 0.0 to 1.0 
" + _8796 + @" += 1 

:BBALL_7447
jump @BBALL_12243 

:BBALL_7454
if 
   not 18@ == 3 
jf @BBALL_8157 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_7735 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_RUN"" time 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_7735 
0615: define_AS_pack_begin 26@ 
if 
  0.5 > 8@ 
jf @BBALL_7625 
0812: AS_actor -1 perform_animation ""BBALL_SKIDSTOP_R"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 
jump @BBALL_7672 

:BBALL_7625
0812: AS_actor -1 perform_animation ""BBALL_SKIDSTOP_L"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 

:BBALL_7672
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_7735
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK""
jf @BBALL_8001 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_WALK"" time 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK""
jf @BBALL_8001 
0615: define_AS_pack_begin 26@ 
if 
  0.5 > 8@ 
jf @BBALL_7891 
0812: AS_actor -1 perform_animation ""BBALL_WALKSTOP_R"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 
jump @BBALL_7938 

:BBALL_7891
0812: AS_actor -1 perform_animation ""BBALL_WALKSTOP_L"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 

:BBALL_7938
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_8001
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK_START""
jf @BBALL_8150 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_WALKSTOP_L"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_8150
jump @BBALL_8253 

:BBALL_8157
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_8207 
17@ = 11 
jump @BBALL_12251 
jump @BBALL_8253 

:BBALL_8207
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_8253 
17@ = 11 
jump @BBALL_12251 

:BBALL_8253
jump @BBALL_12243 

:BBALL_8260
if 
   not 18@ == 11 
jf @BBALL_8346 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_8346
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_8443 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_8443
jump @BBALL_12243 

:BBALL_8450
if 
   not 18@ == 4 
jf @BBALL_8843 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
080A: get_object 0@ spoot 0 store_to 2@ 3@ 4@ 
0087: 5@ = 2@ // (float) 
0065: 5@ -= " + tempvar_Float_1 + @" // (float) 
0087: 6@ = 3@ // (float) 
0065: 6@ -= " + tempvar_Float_2 + @" // (float) 
0604: get_Z_angle_for_point 5@ 6@ store_to " + tempvar_Angle + @" 
0086: " + _8808 + @" = " + tempvar_Angle + @" // (float) 
0615: define_AS_pack_begin 26@ 
080A: get_object 0@ spoot 0 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
06A9: AS_actor -1 look_at_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 2000 ms 
if 
  18@ == 2 
jf @BBALL_8772 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_8650 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_RUN"" time 

:BBALL_8650
if 
  0.5 > 8@ 
jf @BBALL_8725 
0812: AS_actor -1 perform_animation ""BBALL_SKIDSTOP_L"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 
jump @BBALL_8772 

:BBALL_8725
0812: AS_actor -1 perform_animation ""BBALL_SKIDSTOP_R"" IFP ""BSKTBALL"" framedelta 6.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 

:BBALL_8772
0812: AS_actor -1 perform_animation ""BBALL_JUMP_SHOT"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
jump @BBALL_8934 

:BBALL_8843
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_SHOT""
jf @BBALL_8934 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_JUMP_SHOT"" time 
if 
0027:   8@ > " + _8784 + @" // (float) 
jf @BBALL_8934 
17@ = 6 
jump @BBALL_12251 

:BBALL_8934
jump @BBALL_12243 

:BBALL_8941
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_END""
jf @BBALL_9058 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_JUMP_CANCEL"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
17@ = 13 
jump @BBALL_12251 

:BBALL_9058
jump @BBALL_12243 

:BBALL_9065
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_9108 
17@ = 11 
jump @BBALL_12251 

:BBALL_9108
jump @BBALL_12243 

:BBALL_9115
if 
   not 18@ == 6 
jf @BBALL_9577 
if 
0685:   object 1@ attached 
jf @BBALL_9570 
0682: detach_object 1@ 0.0 0.0 0.0 collision_detection 0 
gosub @BBALL_2506 
04C4: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_actor " + PlayerActor + @" with_offset 0.04 0.694 1.75 
Object.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
080A: get_object 0@ spoot 0 store_to 2@ 3@ 4@ 
0509: 8@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2@ 3@ 
0090: " + _1926 + @" = float 8@ to_integer 
0089: 7@ = " + tempvar_Float_3 + @" // (float) 
008F: 7@ = integer " + _1926 + @" to_float 
0087: 9@ = 8@ // (float) 
0063: 9@ -= 7@ // (float) 
9@ *= 10.0 
0090: " + _1927 + @" = float 9@ to_integer 
if 
  8@ > 20.0 
jf @BBALL_9343 
8@ = 20.0 

:BBALL_9343
8@ /= 20.0 
8@ *= 5.0 
0509: 9@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2@ 3@ 
if 
  9@ > 15.0 
jf @BBALL_9411 
9@ = 15.0 

:BBALL_9411
006D: " + _8783 + @" *= 9@ // (float) 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0653: 9@ = float_stat 23 
9@ /= 1000.0 
9@ += 1.0 
9@ *= 0.15 
if 
0027:   9@ > " + _8783 + @" // (float) 
jf @BBALL_9533 " );
                create_thread<PROJECT>( _local1, tempvar_Float_1, tempvar_Float_2, tempvar_Float_3, _local2, _local3, _local4, _local8, 0, _local0 );
                AppendLine( @"jump @BBALL_9570 

:BBALL_9533" );
                create_thread<PROJECT>( _local1, tempvar_Float_1, tempvar_Float_2, tempvar_Float_3, _local2, _local3, _local4, _local8, 1, _local0 );
                AppendLine( @":BBALL_9570
jump @BBALL_9660 

:BBALL_9577
if 
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_SHOT""
jf @BBALL_9660 
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_9660 
Player.CanMove(" + PlayerChar + @") = True
17@ = 12 
jump @BBALL_12251 

:BBALL_9660
jump @BBALL_12243 

:BBALL_9667
if 
   not 18@ == 16 
jf @BBALL_10147 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
080A: get_object 0@ spoot 0 store_to 2@ 3@ 4@ 
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
0063: 5@ -= 2@ // (float) 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
0063: 6@ -= 3@ // (float) 
0509: 8@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2@ 3@ 
if 
  8@ > 0.01 
jf @BBALL_9801 
0073: 5@ /= 8@ // (float) 
0073: 6@ /= 8@ // (float) 

:BBALL_9801
5@ *= 0.01 
6@ *= 0.01 
0088: " + tempvar_Float_1 + @" = 2@ // (float) 
005F: " + tempvar_Float_1 + @" += 5@ // (float) 
0088: " + tempvar_Float_2 + @" = 3@ // (float) 
005F: " + tempvar_Float_2 + @" += 6@ // (float) 
0088: " + tempvar_Float_3 + @" = 4@ // (float) 
" + tempvar_Float_3 + @" -= 1.9 
0086: " + _8809 + @" = " + tempvar_Float_1 + @" // (float) 
0086: " + _8810 + @" = " + tempvar_Float_2 + @" // (float) 
0086: " + _8811 + @" = " + tempvar_Float_3 + @" // (float) 
5@ *= -1.0 
6@ *= -1.0 
0604: get_Z_angle_for_point 5@ 6@ store_to " + tempvar_Angle + @" 
0086: " + _8808 + @" = " + tempvar_Angle + @" // (float) 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_DNK_LNCH"" IFP ""BSKTBALL"" framedelta 4.0 loopA 0 lockX 1 lockY 1 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_DNK_GLI"" IFP ""BSKTBALL"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_DNK"" IFP ""BSKTBALL"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_DNK_LND"" IFP ""BSKTBALL"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
" + _8812 + @" = 0.0 
jump @BBALL_10649 

:BBALL_10147
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
jf @BBALL_10344 
if 
83CA:   not object " + _8782 + @" exists 
jf @BBALL_10344 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
080A: get_object 0@ spoot 0 store_to 2@ 3@ 4@ 
0509: " + _8798 + @" = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2@ 3@ 
" + _8812 + @" = 0.0 
" + tempvar_Angle + @" = Actor.Angle(" + PlayerActor + @")
" + _8782 + @" = Object.Init(#BBALL_INGAME, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.Angle(" + _8782 + @") = " + tempvar_Angle + @"
Object.CollisionDetection(" + _8782 + @") = False
0750: set_object " + _8782 + @" visibility 0 
Object.KeepInMemory(" + _8782 + @") = True
04F4: put_actor " + PlayerActor + @" into_turret_on_object " + _8782 + @" offset_from_object_origin 0.0 0.0 0.0 orientation 0 both_side_angle_limit 360.0 lock_weapon 0 
22@ = 1 

:BBALL_10344
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK""
jf @BBALL_10392 
17@ = 17 
jump @BBALL_12251 
jump @BBALL_10469 

:BBALL_10392
if 
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
jf @BBALL_10469 
if 
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_LNCH""
jf @BBALL_10469 
17@ = 17 
jump @BBALL_12251 

:BBALL_10469
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
jf @BBALL_10649 
if 
03CA:   object " + _8782 + @" exists 
jf @BBALL_10649 
if 
  " + _8812 + @" > 1.0 
jf @BBALL_10649 
0792: disembark_instantly_actor " + PlayerActor + @" 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_DNK"" IFP ""BSKTBALL"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0812: AS_actor -1 perform_animation ""BBALL_DNK_LND"" IFP ""BSKTBALL"" framedelta 1000.0 loopA 0 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_10649
jump @BBALL_12243 

:BBALL_10656
if 
   not 18@ == 17 
jf @BBALL_11064 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK""
jf @BBALL_11043 
if 
0685:   object 1@ attached 
jf @BBALL_11036 
if 
0837:   object 1@ animation == ""BBALL_DNK_O"" 
jf @BBALL_10926 
0839: get_object 1@ animation ""BBALL_DNK_O"" progress_to 8@ 
if 
  8@ > 0.9 
jf @BBALL_10905 
0682: detach_object 1@ 0.0 0.0 0.0 collision_detection 0 
gosub @BBALL_2506 
080A: get_object 0@ spoot 0 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += -0.5 
Object.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.KeepInMemory(1@) = False
Object.CollisionDetection(1@) = True
Object.ToggleInMovingList(1@) = True
Object.Throw(1@, 0.0, 0.0, -0.1)
jump @BBALL_10919 

:BBALL_10905
18@ = 0 
jump @BBALL_12251 

:BBALL_10919
jump @BBALL_11036 

:BBALL_10926
0682: detach_object 1@ 0.0 0.0 0.0 collision_detection 0 
gosub @BBALL_2506 
080A: get_object 0@ spoot 0 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += -0.5 
Object.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.KeepInMemory(1@) = False
Object.CollisionDetection(1@) = True
Object.ToggleInMovingList(1@) = True
Object.Throw(1@, 0.0, 0.0, -0.1)

:BBALL_11036
jump @BBALL_11057 

:BBALL_11043
02CE: " + _8811 + @" = ground_z_at " + _8809 + @" " + _8810 + @" " + _8811 + @" 

:BBALL_11057
jump @BBALL_11350 

:BBALL_11064
if and
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_LNCH""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_LND""
jf @BBALL_11242 
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_11235 
if 
03CA:   object " + _8782 + @" exists 
jf @BBALL_11214 
0465: remove_actor " + PlayerActor + @" from_turret_mode 
Object.Destroy(" + _8782 + @")
22@ = 0 

:BBALL_11214
Player.CanMove(" + PlayerChar + @") = True
17@ = 12 
jump @BBALL_12251 

:BBALL_11235
jump @BBALL_11350 

:BBALL_11242
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_LND""
jf @BBALL_11350 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0 1.0 0.0 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
" + tempvar_Float_3 + @" += 1.0 
0086: " + _8809 + @" = " + tempvar_Float_1 + @" // (float) 
0086: " + _8810 + @" = " + tempvar_Float_2 + @" // (float) 
0086: " + _8811 + @" = " + tempvar_Float_3 + @" // (float) 

:BBALL_11350
jump @BBALL_12243 

:BBALL_11357
if 
   not 18@ == 7 
jf @BBALL_11443 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_DEF_LOOP"" IFP ""BSKTBALL"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_11443
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_11540 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_DEF_LOOP"" IFP ""BSKTBALL"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_11540
jump @BBALL_12243 

:BBALL_11547
if 
   not 18@ == 8 
jf @BBALL_11638 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_DEF_JUMP_SHOT"" IFP ""BSKTBALL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_11638
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_11740 
0615: define_AS_pack_begin 26@ 
0812: AS_actor -1 perform_animation ""BBALL_DEF_JUMP_SHOT"" IFP ""BSKTBALL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 

:BBALL_11740
jump @BBALL_12243 

:BBALL_11747
jump @BBALL_12243 

:BBALL_11754
jump @BBALL_12243 

:BBALL_11761
if 
   not 18@ == 10 
jf @BBALL_12140 
Player.CanMove(" + PlayerChar + @") = False
Actor.SetImmunities(" + PlayerActor + @", 0, 0, 0, 0, 0)
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
03CA:   object 1@ exists 
jf @BBALL_11845 
Object.StorePos(1@, 2@, 3@, 4@)

:BBALL_11845
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
0063: 5@ -= 2@ // (float) 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
0063: 6@ -= 3@ // (float) 
0509: 8@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2@ 3@ 
0073: 5@ /= 8@ // (float) 
0073: 6@ /= 8@ // (float) 
5@ *= 0.5 
6@ *= 0.5 
0088: " + tempvar_Float_1 + @" = 2@ // (float) 
005F: " + tempvar_Float_1 + @" += 5@ // (float) 
0088: " + tempvar_Float_2 + @" = 3@ // (float) 
005F: " + tempvar_Float_2 + @" += 6@ // (float) 
0087: 5@ = 2@ // (float) 
0065: 5@ -= " + tempvar_Float_1 + @" // (float) 
0087: 6@ = 3@ // (float) 
0065: 6@ -= " + tempvar_Float_2 + @" // (float) 
0604: get_Z_angle_for_point 5@ 6@ store_to " + tempvar_Angle + @" 
0615: define_AS_pack_begin 26@ 
0804: AS_actor -1 walk_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" angle " + tempvar_Angle + @" radius -1.0 animation ""BBALL_PICKUP"" IFP_file ""BSKTBALL"" 4.0 LA 0 LX 0 LY 0 LF 1 LT -1 
0812: AS_actor -1 perform_animation ""BBALL_IDLELOOP"" IFP ""BSKTBALL"" framedelta 10000.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 // versionB 
0616: define_AS_pack_end 26@ 
0618: assign_actor " + PlayerActor + @" to_AS_pack 26@ 
061B: remove_references_to_AS_pack 26@ 
jump @BBALL_12236 

:BBALL_12140
062E: get_actor " + PlayerActor + @" task 1560 status_store_to 24@ // ret 7 if not found 
if 
04A4:   24@ == 7 // == constant 
jf @BBALL_12190 
17@ = 11 
jump @BBALL_12251 
jump @BBALL_12236 

:BBALL_12190
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_12236 
17@ = 11 
jump @BBALL_12251 

:BBALL_12236
jump @BBALL_12243 

:BBALL_12243
0085: 18@ = 17@ // (int) 

:BBALL_12251
return 

:BBALL_12253
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_16390 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLELOOP""
jf @BBALL_12603 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_IDLELOOP"" time 
if 
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_12438 
if 
  8@ > 0.45 
jf @BBALL_12413 
if 
   not 27@ == 1 
jf @BBALL_12406 
097B: play_audio_at_object 1@ event 1010 
27@ = 1 

:BBALL_12406
jump @BBALL_12438 

:BBALL_12413
if 
  27@ == 1 
jf @BBALL_12438 
27@ = 0 

:BBALL_12438
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_12603 
if 
0837:   object 1@ animation == ""BBALL_IDLELOOP_O"" 
jf @BBALL_12524 
083A: set_object 1@ animation ""BBALL_IDLELOOP_O"" progress_to 8@ 
jump @BBALL_12603 

:BBALL_12524
if 
075A: set_object 1@ animation ""BBALL_IDLELOOP_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 1 loop 0 // IF AND SET 
jf @BBALL_12603 
083A: set_object 1@ animation ""BBALL_IDLELOOP_O"" progress_to 8@ 

:BBALL_12603
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLE""
jf @BBALL_12886 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_IDLE"" time 
if 
  8@ > 0.87671 
jf @BBALL_12712 
if 
   not 27@ == 2 
jf @BBALL_12705 
097B: play_audio_at_object 1@ event 1010 
27@ = 2 

:BBALL_12705
jump @BBALL_12737 

:BBALL_12712
if 
  27@ == 2 
jf @BBALL_12737 
27@ = 0 

:BBALL_12737
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_12886 
if 
0837:   object 1@ animation == ""BBALL_IDLE_O"" 
jf @BBALL_12815 
083A: set_object 1@ animation ""BBALL_IDLE_O"" progress_to 8@ 
jump @BBALL_12886 

:BBALL_12815
if 
075A: set_object 1@ animation ""BBALL_IDLE_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_12886 
083A: set_object 1@ animation ""BBALL_IDLE_O"" progress_to 8@ 

:BBALL_12886
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_IDLE2""
jf @BBALL_13089 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_IDLE2"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_13089 
if 
0837:   object 1@ animation == ""BBALL_IDLE2_O"" 
jf @BBALL_13016 
083A: set_object 1@ animation ""BBALL_IDLE2_O"" progress_to 8@ 
jump @BBALL_13089 

:BBALL_13016
if 
075A: set_object 1@ animation ""BBALL_IDLE2_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_13089 
083A: set_object 1@ animation ""BBALL_IDLE2_O"" progress_to 8@ 

:BBALL_13089
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_SHOT""
jf @BBALL_13278 
if 
0685:   object 1@ attached 
jf @BBALL_13278 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_JUMP_SHOT"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_13278 
if 
0837:   object 1@ animation == ""BBALL_JUMP_SHOT_O"" 
jf @BBALL_13224 
jump @BBALL_13278 

:BBALL_13224
if 
075A: set_object 1@ animation ""BBALL_JUMP_SHOT_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_13278 

:BBALL_13278
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_CANCEL""
jf @BBALL_13517 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_JUMP_CANCEL"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_13517 
if 
0837:   object 1@ animation == ""BBALL_JUMP_CANCEL_O"" 
jf @BBALL_13432 
083A: set_object 1@ animation ""BBALL_JUMP_CANCEL_O"" progress_to 8@ 
jump @BBALL_13517 

:BBALL_13432
if 
075A: set_object 1@ animation ""BBALL_JUMP_CANCEL_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_13517 
083A: set_object 1@ animation ""BBALL_JUMP_CANCEL_O"" progress_to 8@ 

:BBALL_13517
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_PICKUP""
jf @BBALL_13880 
if 
8685:   not object 1@ attached 
jf @BBALL_13615 
069B: attach_object 1@ to_actor " + PlayerActor + @" with_offset 0.0 0.5 -1.0 rotation 0.0 0.0 0.0 
gosub @BBALL_2506 
jump @BBALL_13880 

:BBALL_13615
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_PICKUP"" time 
if 
  8@ > 0.836 
jf @BBALL_13698 
if 
   not 27@ == 3 
jf @BBALL_13691 
097B: play_audio_at_object 1@ event 1010 
27@ = 3 

:BBALL_13691
jump @BBALL_13723 

:BBALL_13698
if 
  27@ == 3 
jf @BBALL_13723 
27@ = 0 

:BBALL_13723
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_13880 
if 
0837:   object 1@ animation == ""BBALL_PICKUP_O"" 
jf @BBALL_13805 
083A: set_object 1@ animation ""BBALL_PICKUP_O"" progress_to 8@ 
jump @BBALL_13880 

:BBALL_13805
if 
075A: set_object 1@ animation ""BBALL_PICKUP_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_13880 
083A: set_object 1@ animation ""BBALL_PICKUP_O"" progress_to 8@ 

:BBALL_13880
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_14225 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_RUN"" time 
if 
  8@ > 0.222 
jf @BBALL_14048 
if 
  0.74 > 8@ 
jf @BBALL_14008 
if 
   not 27@ == 4 
jf @BBALL_14001 
097B: play_audio_at_object 1@ event 1010 
27@ = 4 

:BBALL_14001
jump @BBALL_14041 

:BBALL_14008
if 
   not 27@ == 5 
jf @BBALL_14041 
097B: play_audio_at_object 1@ event 1010 
27@ = 5 

:BBALL_14041
jump @BBALL_14080 

:BBALL_14048
if or
  27@ == 4 
  27@ == 5 
jf @BBALL_14080 
27@ = 0 

:BBALL_14080
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_14225 
if 
0837:   object 1@ animation == ""BBALL_RUN_O"" 
jf @BBALL_14156 
083A: set_object 1@ animation ""BBALL_RUN_O"" progress_to 8@ 
jump @BBALL_14225 

:BBALL_14156
if 
075A: set_object 1@ animation ""BBALL_RUN_O"" IFP_file ""BSKTBALL"" 8.0 lockF 1 loop 0 // IF AND SET 
jf @BBALL_14225 
083A: set_object 1@ animation ""BBALL_RUN_O"" progress_to 8@ 

:BBALL_14225
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_L""
jf @BBALL_14458 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_SKIDSTOP_L"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_14458 
if 
0837:   object 1@ animation == ""BBALL_SKIDSTOP_L_O"" 
jf @BBALL_14375 
083A: set_object 1@ animation ""BBALL_SKIDSTOP_L_O"" progress_to 8@ 
jump @BBALL_14458 

:BBALL_14375
if 
075A: set_object 1@ animation ""BBALL_SKIDSTOP_L_O"" IFP_file ""BSKTBALL"" 6.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_14458 
083A: set_object 1@ animation ""BBALL_SKIDSTOP_L_O"" progress_to 8@ 

:BBALL_14458
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_R""
jf @BBALL_14691 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_SKIDSTOP_R"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_14691 
if 
0837:   object 1@ animation == ""BBALL_SKIDSTOP_R_O"" 
jf @BBALL_14608 
083A: set_object 1@ animation ""BBALL_SKIDSTOP_R_O"" progress_to 8@ 
jump @BBALL_14691 

:BBALL_14608
if 
075A: set_object 1@ animation ""BBALL_SKIDSTOP_R_O"" IFP_file ""BSKTBALL"" 6.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_14691 
083A: set_object 1@ animation ""BBALL_SKIDSTOP_R_O"" progress_to 8@ 

:BBALL_14691
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALKSTOP_L""
jf @BBALL_14924 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_WALKSTOP_L"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_14924 
if 
0837:   object 1@ animation == ""BBALL_WALKSTOP_L_O"" 
jf @BBALL_14841 
083A: set_object 1@ animation ""BBALL_WALKSTOP_L_O"" progress_to 8@ 
jump @BBALL_14924 

:BBALL_14841
if 
075A: set_object 1@ animation ""BBALL_WALKSTOP_L_O"" IFP_file ""BSKTBALL"" 6.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_14924 
083A: set_object 1@ animation ""BBALL_WALKSTOP_L_O"" progress_to 8@ 

:BBALL_14924
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALKSTOP_R""
jf @BBALL_15157 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_WALKSTOP_R"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_15157 
if 
0837:   object 1@ animation == ""BBALL_WALKSTOP_R_O"" 
jf @BBALL_15074 
083A: set_object 1@ animation ""BBALL_WALKSTOP_R_O"" progress_to 8@ 
jump @BBALL_15157 

:BBALL_15074
if 
075A: set_object 1@ animation ""BBALL_WALKSTOP_R_O"" IFP_file ""BSKTBALL"" 6.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_15157 
083A: set_object 1@ animation ""BBALL_WALKSTOP_R_O"" progress_to 8@ 

:BBALL_15157
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK""
jf @BBALL_15535 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_WALK"" time 
if 
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_RUN""
jf @BBALL_15386 
if 
  8@ > 0.218 
jf @BBALL_15354 
if 
  0.718 > 8@ 
jf @BBALL_15314 
if 
   not 27@ == 6 
jf @BBALL_15307 
097B: play_audio_at_object 1@ event 1010 
27@ = 6 

:BBALL_15307
jump @BBALL_15347 

:BBALL_15314
if 
   not 27@ == 7 
jf @BBALL_15347 
097B: play_audio_at_object 1@ event 1010 
27@ = 7 

:BBALL_15347
jump @BBALL_15386 

:BBALL_15354
if or
  27@ == 6 
  27@ == 7 
jf @BBALL_15386 
27@ = 0 

:BBALL_15386
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_15535 
if 
0837:   object 1@ animation == ""BBALL_WALK_O"" 
jf @BBALL_15464 
083A: set_object 1@ animation ""BBALL_WALK_O"" progress_to 8@ 
jump @BBALL_15535 

:BBALL_15464
if 
075A: set_object 1@ animation ""BBALL_WALK_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 1 loop 0 // IF AND SET 
jf @BBALL_15535 
083A: set_object 1@ animation ""BBALL_WALK_O"" progress_to 8@ 

:BBALL_15535
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_WALK_START""
jf @BBALL_15768 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_WALK_START"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_15768 
if 
0837:   object 1@ animation == ""BBALL_WALK_START_O"" 
jf @BBALL_15685 
083A: set_object 1@ animation ""BBALL_WALK_START_O"" progress_to 8@ 
jump @BBALL_15768 

:BBALL_15685
if 
075A: set_object 1@ animation ""BBALL_WALK_START_O"" IFP_file ""BSKTBALL"" 8.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_15768 
083A: set_object 1@ animation ""BBALL_WALK_START_O"" progress_to 8@ 

:BBALL_15768
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_LNCH""
jf @BBALL_15989 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_DNK_LNCH"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_15989 
if 
0837:   object 1@ animation == ""BBALL_DNK_LNCH_O"" 
jf @BBALL_15910 
083A: set_object 1@ animation ""BBALL_DNK_LNCH_O"" progress_to 8@ 
jump @BBALL_15989 

:BBALL_15910
if 
075A: set_object 1@ animation ""BBALL_DNK_LNCH_O"" IFP_file ""BSKTBALL"" 4.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_15989 
083A: set_object 1@ animation ""BBALL_DNK_LNCH_O"" progress_to 8@ 

:BBALL_15989
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
jf @BBALL_16204 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_DNK_GLI"" time 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_16204 
if 
0837:   object 1@ animation == ""BBALL_DNK_GLI_O"" 
jf @BBALL_16127 
083A: set_object 1@ animation ""BBALL_DNK_GLI_O"" progress_to 8@ 
jump @BBALL_16204 

:BBALL_16127
if 
075A: set_object 1@ animation ""BBALL_DNK_GLI_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_16204 
083A: set_object 1@ animation ""BBALL_DNK_GLI_O"" progress_to 8@ 

:BBALL_16204
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK""
jf @BBALL_16390 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_DNK"" time 
if 
  0.2 > 8@ 
jf @BBALL_16390 
if 
   Object.Model(1@) == #BBALL_INGAME
jf @BBALL_16390 
if 
0685:   object 1@ attached 
jf @BBALL_16390 
if 
0837:   object 1@ animation == ""BBALL_DNK_O"" 
jf @BBALL_16342 
jump @BBALL_16390 

:BBALL_16342
if 
075A: set_object 1@ animation ""BBALL_DNK_O"" IFP_file ""BSKTBALL"" 1000.0 lockF 0 loop 1 // IF AND SET 
jf @BBALL_16390 

:BBALL_16390
return 

:BBALL_16392
if and
   Player.Defined(" + PlayerChar + @")
   Model.Available(23@)
jf @BBALL_17989 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.StorePos(0@, 2@, 3@, 4@)
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 
080A: get_object 0@ spoot 0 store_to 8@ 8@ " + _8804 + @" 
" + _8804 + @" += -1.0 
0871: init_jump_table " + _8791 + @" total_jumps 4 default_jump 0 @BBALL_17326 jumps 1 @BBALL_16546 2 @BBALL_16741 3 @BBALL_16936 4 @BBALL_17131 -1 @BBALL_17326 -1 @BBALL_17326 -1 @BBALL_17326 

:BBALL_16546
0088: " + _8802 + @" = 2@ // (float) 
" + _8802 + @" += 0.2 
0086: " + _8803 + @" = " + tempvar_Float_2 + @" // (float) 
" + _8803 + @" += 5.0 
6@ += 5.0 
if 
0026:   " + _8803 + @" > 6@ // (float) 
jf @BBALL_16619 
0088: " + _8803 + @" = 6@ // (float) 

:BBALL_16619
0087: 8@ = 3@ // (float) 
8@ += 5.0 
if 
0027:   8@ > " + _8803 + @" // (float) 
jf @BBALL_16664 
0088: " + _8803 + @" = 8@ // (float) 

:BBALL_16664
0087: 8@ = 6@ // (float) 
0063: 8@ -= 3@ // (float) 
8@ += -5.0 
0087: 9@ = 6@ // (float) 
0065: 9@ -= " + _8803 + @" // (float) 
0073: 9@ /= 8@ // (float) 
9@ *= 0.29 
9@ += 0.34 
jump @BBALL_17326 

:BBALL_16741
0086: " + _8802 + @" = " + tempvar_Float_1 + @" // (float) 
" + _8802 + @" -= 5.0 
0088: " + _8803 + @" = 3@ // (float) 
" + _8803 + @" += 0.2 
5@ += -5.0 
if 
0027:   5@ > " + _8802 + @" // (float) 
jf @BBALL_16814 
0088: " + _8802 + @" = 5@ // (float) 

:BBALL_16814
0087: 8@ = 2@ // (float) 
8@ -= 5.0 
if 
0026:   " + _8802 + @" > 8@ // (float) 
jf @BBALL_16859 
0088: " + _8802 + @" = 8@ // (float) 

:BBALL_16859
0087: 8@ = 2@ // (float) 
0063: 8@ -= 5@ // (float) 
8@ += -5.0 
0089: 9@ = " + _8802 + @" // (float) 
0063: 9@ -= 5@ // (float) 
0073: 9@ /= 8@ // (float) 
9@ *= 0.29 
9@ += 0.34 
jump @BBALL_17326 

:BBALL_16936
0088: " + _8802 + @" = 2@ // (float) 
" + _8802 + @" -= 0.2 
0086: " + _8803 + @" = " + tempvar_Float_2 + @" // (float) 
" + _8803 + @" -= 5.0 
6@ += -5.0 
if 
0027:   6@ > " + _8803 + @" // (float) 
jf @BBALL_17009 
0088: " + _8803 + @" = 6@ // (float) 

:BBALL_17009
0087: 8@ = 3@ // (float) 
8@ -= 5.0 
if 
0026:   " + _8803 + @" > 8@ // (float) 
jf @BBALL_17054 
0088: " + _8803 + @" = 8@ // (float) 

:BBALL_17054
0087: 8@ = 3@ // (float) 
0063: 8@ -= 6@ // (float) 
8@ += -5.0 
0089: 9@ = " + _8803 + @" // (float) 
0063: 9@ -= 6@ // (float) 
0073: 9@ /= 8@ // (float) 
9@ *= 0.29 
9@ += 0.34 
jump @BBALL_17326 

:BBALL_17131
0086: " + _8802 + @" = " + tempvar_Float_1 + @" // (float) 
" + _8802 + @" += 5.0 
0088: " + _8803 + @" = 3@ // (float) 
" + _8803 + @" -= 0.2 
5@ += 5.0 
if 
0026:   " + _8802 + @" > 5@ // (float) 
jf @BBALL_17204 
0088: " + _8802 + @" = 5@ // (float) 

:BBALL_17204
0087: 8@ = 2@ // (float) 
8@ += 5.0 
if 
0027:   8@ > " + _8802 + @" // (float) 
jf @BBALL_17249 
0088: " + _8802 + @" = 8@ // (float) 

:BBALL_17249
0087: 8@ = 5@ // (float) 
0063: 8@ -= 2@ // (float) 
8@ += -5.0 
0087: 9@ = 5@ // (float) 
0065: 9@ -= " + _8802 + @" // (float) 
0073: 9@ /= 8@ // (float) 
9@ *= 0.29 
9@ += 0.34 
jump @BBALL_17326 

:BBALL_17326
0088: " + _8799 + @" = 2@ // (float) 
0061: " + _8799 + @" -= " + tempvar_Float_1 + @" // (float) 
0088: " + _8800 + @" = 3@ // (float) 
0061: " + _8800 + @" -= " + tempvar_Float_2 + @" // (float) 
0088: " + _8801 + @" = 4@ // (float) 
0061: " + _8801 + @" -= " + tempvar_Float_3 + @" // (float) 
006D: " + _8799 + @" *= 9@ // (float) 
006D: " + _8800 + @" *= 9@ // (float) 
006D: " + _8801 + @" *= 9@ // (float) 
0086: " + _8805 + @" = " + tempvar_Float_1 + @" // (float) 
0059: " + _8805 + @" += " + _8799 + @" // (float) 
0086: " + _8806 + @" = " + tempvar_Float_2 + @" // (float) 
0059: " + _8806 + @" += " + _8800 + @" // (float) 
0086: " + _8807 + @" = " + tempvar_Float_3 + @" // (float) 
0059: " + _8807 + @" += " + _8801 + @" // (float) 
080A: get_object 0@ spoot 2 store_to 2@ 3@ 4@ 
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 
if 
0025:   2@ > 5@ // (float) 
jf @BBALL_17558 
if 
0026:   " + _8805 + @" > 2@ // (float) 
jf @BBALL_17524 
0088: " + _8805 + @" = 2@ // (float) 

:BBALL_17524
if 
0027:   5@ > " + _8805 + @" // (float) 
jf @BBALL_17551 
0088: " + _8805 + @" = 5@ // (float) 

:BBALL_17551
jump @BBALL_17612 

:BBALL_17558
if 
0026:   " + _8805 + @" > 5@ // (float) 
jf @BBALL_17585 
0088: " + _8805 + @" = 5@ // (float) 

:BBALL_17585
if 
0027:   2@ > " + _8805 + @" // (float) 
jf @BBALL_17612 
0088: " + _8805 + @" = 2@ // (float) 

:BBALL_17612
if 
0025:   3@ > 6@ // (float) 
jf @BBALL_17692 
if 
0026:   " + _8806 + @" > 3@ // (float) 
jf @BBALL_17658 
0088: " + _8806 + @" = 3@ // (float) 

:BBALL_17658
if 
0027:   6@ > " + _8806 + @" // (float) 
jf @BBALL_17685 
0088: " + _8806 + @" = 6@ // (float) 

:BBALL_17685
jump @BBALL_17746 

:BBALL_17692
if 
0026:   " + _8806 + @" > 6@ // (float) 
jf @BBALL_17719 
0088: " + _8806 + @" = 6@ // (float) 

:BBALL_17719
if 
0027:   3@ > " + _8806 + @" // (float) 
jf @BBALL_17746 
0088: " + _8806 + @" = 3@ // (float) 

:BBALL_17746
0086: " + _8799 + @" = " + _8802 + @" // (float) 
0067: " + _8799 + @" -= 10@ // (float) 
0086: " + _8800 + @" = " + _8803 + @" // (float) 
0067: " + _8800 + @" -= 11@ // (float) 
0086: " + _8801 + @" = " + _8804 + @" // (float) 
0067: " + _8801 + @" -= 12@ // (float) 
" + _8799 + @" *= 0.25 
" + _8800 + @" *= 0.25 
" + _8801 + @" *= 0.25 
005D: 10@ += " + _8799 + @" // (float) 
005D: 11@ += " + _8800 + @" // (float) 
005D: 12@ += " + _8801 + @" // (float) 
0086: " + _8799 + @" = " + _8805 + @" // (float) 
0067: " + _8799 + @" -= 13@ // (float) 
0086: " + _8800 + @" = " + _8806 + @" // (float) 
0067: " + _8800 + @" -= 14@ // (float) 
0086: " + _8801 + @" = " + _8807 + @" // (float) 
0067: " + _8801 + @" -= 15@ // (float) 
" + _8799 + @" *= 0.1 
" + _8800 + @" *= 0.1 
" + _8801 + @" *= 0.1 
005D: 13@ += " + _8799 + @" // (float) 
005D: 14@ += " + _8800 + @" // (float) 
005D: 15@ += " + _8801 + @" // (float) 
Camera.SetPosition(10@, 11@, 12@, 0.0, 0.0, 0.0)
Camera.PointAt(13@, 14@, 15@, 2)

:BBALL_17989
return 

:BBALL_17991
if and
0685:   object 1@ attached 
   Model.Available(23@)
jf @BBALL_19704 
24@ = 1 
if or
  17@ == 10 
  17@ == 4 
  17@ == 6 
  17@ == 16 
  17@ == 17 
jf @BBALL_18072 
24@ = 0 

:BBALL_18072
if or
  17@ == 14 
  17@ == 15 
jf @BBALL_18104 
24@ = 0 

:BBALL_18104
if 
  24@ == 1 
jf @BBALL_19330 
if or
00E1:   player 0 pressed_key 0 
00E1:   player 0 pressed_key 1 
jf @BBALL_18532 
0494: get_joystick 0 direction_offset_to " + Move_Axis_X + @" " + Move_Axis_Y + @" " + Special_Axis_X + @" " + Special_Axis_Y + @" 
008D: " + tempvar_Float_1 + @" = integer " + Move_Axis_X + @" to_float 
008D: " + tempvar_Float_2 + @" = integer " + Move_Axis_Y + @" to_float 
" + tempvar_Float_1 + @" /= 128.0 
" + tempvar_Float_2 + @" /= -128.0 
0089: 8@ = " + tempvar_Float_1 + @" // (float) 
006F: 8@ *= " + tempvar_Float_1 + @" // (float) 
0089: 9@ = " + tempvar_Float_2 + @" // (float) 
006F: 9@ *= " + tempvar_Float_2 + @" // (float) 
005B: 8@ += 9@ // (float) 
01FB: 8@ = square_root 8@ 
0604: get_Z_angle_for_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" store_to " + _8808 + @" 
if 
  " + _8786 + @" == 1 
jf @BBALL_18313 
0088: " + tempvar_Float_1 + @" = 13@ // (float) 
0067: " + tempvar_Float_1 + @" -= 10@ // (float) 
0088: " + tempvar_Float_2 + @" = 14@ // (float) 
0067: " + tempvar_Float_2 + @" -= 11@ // (float) 
jump @BBALL_18383 

:BBALL_18313
068D: get_camera_position_to 2@ 3@ 4@ 
068E: get_camera_target_point_to 5@ 6@ 7@ 
0088: " + tempvar_Float_1 + @" = 5@ // (float) 
0067: " + tempvar_Float_1 + @" -= 2@ // (float) 
0088: " + tempvar_Float_2 + @" = 6@ // (float) 
0067: " + tempvar_Float_2 + @" -= 3@ // (float) 
0088: " + tempvar_Float_3 + @" = 7@ // (float) 
0067: " + tempvar_Float_3 + @" -= 4@ // (float) 

:BBALL_18383
0604: get_Z_angle_for_point " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" store_to 9@ 
005F: " + _8808 + @" += 9@ // (float) 
if 
  8@ > 0.3 
jf @BBALL_18472 
if 
  0.8 > 8@ 
jf @BBALL_18458 
17@ = 1 
jump @BBALL_18465 

:BBALL_18458
17@ = 2 

:BBALL_18465
jump @BBALL_18525 

:BBALL_18472
if or
  18@ == 2 
  18@ == 1 
  17@ == 2 
  17@ == 1 
jf @BBALL_18525 
17@ = 3 
18@ = 0 

:BBALL_18525
jump @BBALL_18585 

:BBALL_18532
if or
  18@ == 2 
  18@ == 1 
  17@ == 2 
  17@ == 1 
jf @BBALL_18585 
17@ = 3 
18@ = 0 

:BBALL_18585
if 
  21@ == 0 
jf @BBALL_19225 
if 
00E1:   player 0 pressed_key 16 
jf @BBALL_19186 
if 
   not 18@ == 6 
jf @BBALL_19179 
080A: get_object 0@ spoot 0 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
   Player.Defined(" + PlayerChar + @")
jf @BBALL_18684 
Actor.StorePos(" + PlayerActor + @", 2@, 3@, 4@)

:BBALL_18684
0089: 5@ = " + tempvar_Float_1 + @" // (float) 
0063: 5@ -= 2@ // (float) 
0089: 6@ = " + tempvar_Float_2 + @" // (float) 
0063: 6@ -= 3@ // (float) 
Object.StorePos(0@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0400: store_coords_to 2@ 3@ 4@ from_object 0@ with_offset 0.0 -1.0 0.0 
0087: 8@ = 2@ // (float) 
0065: 8@ -= " + tempvar_Float_1 + @" // (float) 
0087: 9@ = 3@ // (float) 
0065: 9@ -= " + tempvar_Float_2 + @" // (float) 
0087: 2@ = 8@ // (float) 
0087: 3@ = 9@ // (float) 
05A4: get_angle_between_vectors_origin_to 5@ 6@ and_origin_to 2@ 3@ store_to 8@ 
24@ = 0 
if 
  90.0 > 8@ 
jf @BBALL_19179 
24@ = 0 
if 
  18@ == 2 
jf @BBALL_19133 
0653: 8@ = float_stat 21 
if 
  400.0 > 8@ 
jf @BBALL_19133 
Actor.StorePos(" + PlayerActor + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
Object.StorePos(0@, 2@, 3@, 4@)
04C4: store_coords_to 5@ 6@ 7@ from_actor " + PlayerActor + @" with_offset 0.0 1.0 0.0 
0509: 8@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 2@ 3@ 
if and
  8@ > 2.4 
  3.5 > 8@ 
jf @BBALL_19133 
0088: " + _8799 + @" = 5@ // (float) 
0061: " + _8799 + @" -= " + tempvar_Float_1 + @" // (float) 
0088: " + _8800 + @" = 6@ // (float) 
0061: " + _8800 + @" -= " + tempvar_Float_2 + @" // (float) 
0087: 8@ = 2@ // (float) 
0065: 8@ -= " + tempvar_Float_1 + @" // (float) 
0087: 9@ = 3@ // (float) 
0065: 9@ -= " + tempvar_Float_2 + @" // (float) 
05A4: get_angle_between_vectors_origin_to " + _8799 + @" " + _8800 + @" and_origin_to 8@ 9@ store_to " + tempvar_Float_3 + @" 
if 
  90.0 > " + tempvar_Float_3 + @" 
jf @BBALL_19126 
24@ = 1 
jump @BBALL_19133 

:BBALL_19126
24@ = 0 

:BBALL_19133
if 
  24@ == 1 
jf @BBALL_19165 
17@ = 16 
jump @BBALL_19172 

:BBALL_19165
17@ = 4 

:BBALL_19172
21@ = 1 

:BBALL_19179
jump @BBALL_19218 

:BBALL_19186
if and
  18@ == 4 
   not 17@ == 6 
jf @BBALL_19218 
21@ = 1 

:BBALL_19218
jump @BBALL_19225 

:BBALL_19225
if and
  17@ == 11 
  18@ == 11 
jf @BBALL_19274 
if 
00E1:   player 0 pressed_key 14 
jf @BBALL_19274 
17@ = 14 

:BBALL_19274
if and
  17@ == 11 
  18@ == 11 
jf @BBALL_19323 
if 
00E1:   player 0 pressed_key 17 
jf @BBALL_19323 
17@ = 15 

:BBALL_19323
jump @BBALL_19697 

:BBALL_19330
if 
  21@ == 1 
jf @BBALL_19697 
if or
  17@ == 4 
  17@ == 6 
jf @BBALL_19673 
if 
80E1:   not player 0 pressed_key 16 
jf @BBALL_19537 
21@ = 0 
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_SHOT""
jf @BBALL_19520 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_JUMP_SHOT"" time 
if 
0027:   8@ > " + _8784 + @" // (float) 
jf @BBALL_19497 
0088: " + _8783 + @" = 8@ // (float) 
0061: " + _8783 + @" -= " + _8784 + @" // (float) 
jump @BBALL_19513 

:BBALL_19497
0086: " + _8783 + @" = " + _8784 + @" // (float) 
0067: " + _8783 + @" -= 8@ // (float) 

:BBALL_19513
jump @BBALL_19530 

:BBALL_19520
" + _8783 + @" = 1.0 

:BBALL_19530
jump @BBALL_19666 

:BBALL_19537
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_JUMP_SHOT""
jf @BBALL_19656 
0613: 8@ = actor " + PlayerActor + @" animation ""BBALL_JUMP_SHOT"" time 
0089: 9@ = " + _8784 + @" // (float) 
9@ += 0.1 
if 
0025:   8@ > 9@ // (float) 
jf @BBALL_19649 
" + _8783 + @" = 1.0 
21@ = 0 

:BBALL_19649
jump @BBALL_19666 

:BBALL_19656
" + _8783 + @" = 1.0 

:BBALL_19666
jump @BBALL_19697 

:BBALL_19673
if 
80E1:   not player 0 pressed_key 16 
jf @BBALL_19697 
21@ = 0 

:BBALL_19697
jump @BBALL_19844 

:BBALL_19704
if 
  18@ == 12 
jf @BBALL_19844 
if 
  21@ == 0 
jf @BBALL_19820 
if 
03CA:   object 1@ exists 
jf @BBALL_19813 
Object.StorePos(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
0475:   actor " + PlayerActor + @" near_object_in_cube 1@ radius 0.7 0.7 2.0 sphere 0 on_foot 
jf @BBALL_19813 
17@ = 10 

:BBALL_19813
jump @BBALL_19844 

:BBALL_19820
if 
80E1:   not player 0 pressed_key 16 
jf @BBALL_19844 
21@ = 0 

:BBALL_19844
24@ = 0 
if or
  17@ == 1 
  17@ == 2 
  17@ == 8 
  17@ == 4 
  17@ == 6 
jf @BBALL_19904 
24@ = 1 

:BBALL_19904
if or
  17@ == 16 
  17@ == 17 
jf @BBALL_19936 
24@ = 1 

:BBALL_19936
if 
  24@ == 1 
jf @BBALL_20231 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @BBALL_19978 
29@ = Actor.Angle(" + PlayerActor + @")

:BBALL_19978
if 
  " + _8808 + @" > 360.0 
jf @BBALL_20016 
" + _8808 + @" += -360.0 
jump @BBALL_19978 

:BBALL_20016
if 
  -360.0 > " + _8808 + @" 
jf @BBALL_20054 
" + _8808 + @" += 360.0 
jump @BBALL_20016 

:BBALL_20054
0089: 30@ = " + _8808 + @" // (float) 
0063: 30@ -= 29@ // (float) 
if 
  30@ > 180.0 
jf @BBALL_20101 
30@ += -360.0 

:BBALL_20101
if 
  -180.0 > 30@ 
jf @BBALL_20132 
30@ += 360.0 

:BBALL_20132
30@ /= 10.0 
007B: 29@ += frame_delta_time * 30@ // (float) 
if 
   not Actor.Dead(" + PlayerActor + @")
jf @BBALL_20231 
if and
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_L""
   not Actor.Animation(" + PlayerActor + @") == ""BBALL_SKIDSTOP_R""
jf @BBALL_20231 
Actor.Angle(" + PlayerActor + @") = 29@

:BBALL_20231
if or
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK""
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_LND""
jf @BBALL_20849 
if 
03CA:   object " + _8782 + @" exists 
jf @BBALL_20849 
Object.StorePos(" + _8782 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
050A: 8@ = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ " + _8809 + @" " + _8810 + @" " + _8811 + @" 
if 
  1.0 >= " + _8812 + @" 
jf @BBALL_20818 
if 
  8@ > 0.07 
jf @BBALL_20651 
0089: 2@ = " + _8809 + @" // (float) 
0065: 2@ -= " + tempvar_Float_1 + @" // (float) 
0089: 3@ = " + _8810 + @" // (float) 
0065: 3@ -= " + tempvar_Float_2 + @" // (float) 
0089: 4@ = " + _8811 + @" // (float) 
0065: 4@ -= " + tempvar_Float_3 + @" // (float) 
0073: 2@ /= 8@ // (float) 
0073: 3@ /= 8@ // (float) 
0073: 4@ /= 8@ // (float) 
if 
  8@ > 0.065 
jf @BBALL_20620 
2@ *= 0.065 
3@ *= 0.065 
4@ *= 0.065 
007D: " + tempvar_Float_1 + @" += frame_delta_time * 2@ // (float) 
007D: " + tempvar_Float_2 + @" += frame_delta_time * 3@ // (float) 
007D: " + tempvar_Float_3 + @" += frame_delta_time * 4@ // (float) 
Object.PutAt(" + _8782 + @", " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
050A: 8@ = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ " + _8809 + @" " + _8810 + @" " + _8811 + @" 
0088: " + _8812 + @" = 8@ // (float) 
0071: " + _8812 + @" /= " + _8798 + @" // (float) 
" + _8812 + @" += -1.0 
" + _8812 + @" *= -1.0 
jump @BBALL_20644 

:BBALL_20620
Object.PutAt(" + _8782 + @", " + _8809 + @", " + _8810 + @", " + _8811 + @")
" + _8812 + @" = 1.0 

:BBALL_20644
jump @BBALL_20675 

:BBALL_20651
Object.PutAt(" + _8782 + @", " + _8809 + @", " + _8810 + @", " + _8811 + @")
" + _8812 + @" = 1.0 

:BBALL_20675
if 
   Actor.Animation(" + PlayerActor + @") == ""BBALL_DNK_GLI""
jf @BBALL_20818 
if and
  " + _8812 + @" >= 0.0 
  1.0 >= " + _8812 + @" 
jf @BBALL_20818 
0614: set_actor " + PlayerActor + @" animation ""BBALL_DNK_GLI"" progress_to " + _8812 + @" // 0.0 to 1.0 
if 
0837:   object 1@ animation == ""BBALL_DNK_GLI_O"" 
jf @BBALL_20818 
083A: set_object 1@ animation ""BBALL_DNK_GLI_O"" progress_to " + _8812 + @" 

:BBALL_20818
if 
  " + _8812 + @" == 1.0 
jf @BBALL_20849 
" + _8812 + @" = 1.01 

:BBALL_20849
return 
0086: " + tempvar_Float_1 + @" = " + _8813 + @" // (float) 
0061: " + tempvar_Float_1 + @" -= " + _8816 + @" // (float) 
0086: " + tempvar_Float_2 + @" = " + _8814 + @" // (float) 
0061: " + tempvar_Float_2 + @" -= " + _8817 + @" // (float) 
0086: " + tempvar_Float_3 + @" = " + _8815 + @" // (float) 
0061: " + tempvar_Float_3 + @" -= " + _8818 + @" // (float) 
0069: " + tempvar_Float_1 + @" *= " + _8819 + @" // (float) 
0069: " + tempvar_Float_2 + @" *= " + _8819 + @" // (float) 
0069: " + tempvar_Float_3 + @" *= " + _8819 + @" // (float) 
0059: " + _8816 + @" += " + tempvar_Float_1 + @" // (float) 
0059: " + _8817 + @" += " + tempvar_Float_2 + @" // (float) 
0059: " + _8818 + @" += " + tempvar_Float_3 + @" // (float) 
return 

:BBALL_20949
0454: store_debug_camera_position_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
03CA:   object 0@ exists 
jf @BBALL_20998 
Object.StorePos(0@, 2@, 3@, 4@)
" + tempvar_Angle + @" = Object.Angle(0@)

:BBALL_20998
" + tempvar_Angle + @" *= -1.0 
02F7: 8@ = cosine " + tempvar_Angle + @" // (float) 
02F6: 9@ = sine " + tempvar_Angle + @" // (float) 
0086: " + _8820 + @" = " + tempvar_Float_1 + @" // (float) 
0067: " + _8820 + @" -= 2@ // (float) 
0086: " + _8821 + @" = " + tempvar_Float_2 + @" // (float) 
0067: " + _8821 + @" -= 3@ // (float) 
0086: " + _8822 + @" = " + tempvar_Float_3 + @" // (float) 
0067: " + _8822 + @" -= 4@ // (float) 
0086: " + _8823 + @" = " + _8820 + @" // (float) 
006D: " + _8823 + @" *= 8@ // (float) 
0086: " + _8825 + @" = " + _8821 + @" // (float) 
006D: " + _8825 + @" *= 9@ // (float) 
0061: " + _8823 + @" -= " + _8825 + @" // (float) 
0086: " + _8824 + @" = " + _8820 + @" // (float) 
006D: " + _8824 + @" *= 9@ // (float) 
0086: " + _8825 + @" = " + _8821 + @" // (float) 
006D: " + _8825 + @" *= 8@ // (float) 
0059: " + _8824 + @" += " + _8825 + @" // (float) 
03A9: save_newline_to_debug_file 
05B6: 110 // FIXED_CAMERA_POSITION - OFFSET FROM BBHOOP = 
03A8: save_float_to_debug_file " + _8823 + @" 
03A8: save_float_to_debug_file " + _8824 + @" 
03A8: save_float_to_debug_file " + _8822 + @" 
0463: store_debug_camera_target_point_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0086: " + _8820 + @" = " + tempvar_Float_1 + @" // (float) 
0067: " + _8820 + @" -= 2@ // (float) 
0086: " + _8821 + @" = " + tempvar_Float_2 + @" // (float) 
0067: " + _8821 + @" -= 3@ // (float) 
0086: " + _8822 + @" = " + tempvar_Float_3 + @" // (float) 
0067: " + _8822 + @" -= 4@ // (float) 
0086: " + _8823 + @" = " + _8820 + @" // (float) 
006D: " + _8823 + @" *= 8@ // (float) 
0086: " + _8825 + @" = " + _8821 + @" // (float) 
006D: " + _8825 + @" *= 9@ // (float) 
0061: " + _8823 + @" -= " + _8825 + @" // (float) 
0086: " + _8824 + @" = " + _8820 + @" // (float) 
006D: " + _8824 + @" *= 9@ // (float) 
0086: " + _8825 + @" = " + _8821 + @" // (float) 
006D: " + _8825 + @" *= 8@ // (float) 
0059: " + _8824 + @" += " + _8825 + @" // (float) 
03A9: save_newline_to_debug_file 
05B6: 111 // CAMERA_POINT_AT -       OFFSET FROM BBHOOP = 
03A8: save_float_to_debug_file " + _8823 + @" 
03A8: save_float_to_debug_file " + _8824 + @" 
03A8: save_float_to_debug_file " + _8822 + @" 
return 
end_thread" );
            }

        }

        private sealed class BBCHAL : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"19@ = 0 
20@ = 0 
21@ = 0 
" + _1923 + @" = 60500 
" + _1924 + @" = 0 
26@ = 0 
27@ = 0 
28@ = 0 
29@ = 3000 
30@ = 4.0 
TIMERA = 0 
TIMERB = 0 
" + _1921 + @" = 1 
if 
  19@ == -1 
jf @BBCHAL_149 
0@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)

:BBCHAL_149
wait 0 
0871: init_jump_table 19@ total_jumps 2 default_jump 0 @BBCHAL_244 jumps 0 @BBCHAL_216 1 @BBCHAL_230 -1 @BBCHAL_244 -1 @BBCHAL_244 -1 @BBCHAL_244 -1 @BBCHAL_244 -1 @BBCHAL_244 

:BBCHAL_216
gosub @BBCHAL_580 
jump @BBCHAL_244 

:BBCHAL_230
gosub @BBCHAL_916 
jump @BBCHAL_244 

:BBCHAL_244
if and
  " + _1928 + @" == 0 
  " + _1930 + @" == 0 
jf @BBCHAL_276 
gosub @BBCHAL_2538 

:BBCHAL_276
gosub @BBCHAL_395 
if 
  " + _8787 + @" == 0 
jf @BBCHAL_308 
gosub @BBCHAL_2538 

:BBCHAL_308
if 
  " + _1016 + @" == 0 
jf @BBCHAL_364 
if 
00E1:   player 0 pressed_key 19 
jf @BBCHAL_357 
" + _1016 + @" = 1 
gosub @BBCHAL_2538 

:BBCHAL_357
jump @BBCHAL_388 

:BBCHAL_364
if 
80E1:   not player 0 pressed_key 19 
jf @BBCHAL_388 
" + _1016 + @" = 0 

:BBCHAL_388
jump @BBCHAL_149 

:BBCHAL_395
0871: init_jump_table 21@ total_jumps 3 default_jump 0 @BBCHAL_578 jumps 0 @BBCHAL_458 1 @BBCHAL_498 2 @BBCHAL_538 -1 @BBCHAL_578 -1 @BBCHAL_578 -1 @BBCHAL_578 -1 @BBCHAL_578 

:BBCHAL_458
if and
88FE:   not text_box_displayed 
876F:   not text_priority_displayed 
jf @BBCHAL_491 
03E5: show_text_box 'BB_11'  
21@ += 1 

:BBCHAL_491
jump @BBCHAL_578 

:BBCHAL_498
if and
88FE:   not text_box_displayed 
876F:   not text_priority_displayed 
jf @BBCHAL_531 
03E5: show_text_box 'BB_12'  
21@ += 1 

:BBCHAL_531
jump @BBCHAL_578 

:BBCHAL_538
if and
88FE:   not text_box_displayed 
876F:   not text_priority_displayed 
jf @BBCHAL_571 
03E5: show_text_box 'BB_10'  
21@ += 1 

:BBCHAL_571
jump @BBCHAL_578 

:BBCHAL_578
return 

:BBCHAL_580
if 
  20@ == 0 
jf @BBCHAL_628 
00BC: show_text_highpriority GXT 'BB_13' time 5000 flag 1  
TIMERA = 0 
20@ += 1 

:BBCHAL_628
if 
  20@ == 1 
jf @BBCHAL_653 
20@ += 1 

:BBCHAL_653
if 
  20@ == 2 
jf @BBCHAL_751 
03C3: set_timer_to " + _1923 + @" type 1 GXT 'BB_19' 
04F7: status_text " + _1924 + @" type 0 line 1 GXT 'BB_18' 
04F7: status_text " + _1922 + @" type 0 line 2 GXT 'BB_14' 
gosub @BBCHAL_2396 
018A: 1@ = create_checkpoint_at 14@ 15@ 16@ 
20@ += 1 

:BBCHAL_751
if 
  20@ == 3 
jf @BBCHAL_914 
if 
   Player.Defined(" + PlayerChar + @")
jf @BBCHAL_914 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 14@ 15@ 16@ radius 1.5 1.5 2.0 on_foot 
jf @BBCHAL_904 
if 
  " + _1930 + @" == 1 
jf @BBCHAL_887 
if 
075C:   marker 1@ enabled 
jf @BBCHAL_866 
Marker.Disable(1@)

:BBCHAL_866
20@ = 1 
19@ += 1 
jump @BBCHAL_897 

:BBCHAL_887
" + _1923 + @" = 60500 

:BBCHAL_897
jump @BBCHAL_914 

:BBCHAL_904
" + _1923 + @" = 60500 

:BBCHAL_914
return 

:BBCHAL_916
if 
  20@ == 0 
jf @BBCHAL_1135 
if 
   not " + _1929 + @" == 0 
jf @BBCHAL_1135 
if 
  " + _1929 + @" > 0 
jf @BBCHAL_1052 
0058: " + _1924 + @" += " + _1929 + @" 
005E: " + _1923 + @" += 25@ 
30@ += 0.5 
gosub @BBCHAL_2396 
if 
075C:   marker 1@ enabled 
jf @BBCHAL_1024 
Marker.Disable(1@)

:BBCHAL_1024
018A: 1@ = create_checkpoint_at 14@ 15@ 16@ 
20@ += 1 
jump @BBCHAL_1135 

:BBCHAL_1052
if 
075C:   marker 1@ enabled 
jf @BBCHAL_1073 
Marker.Disable(1@)

:BBCHAL_1073
018A: 1@ = create_checkpoint_at 14@ 15@ 16@ 
if 
  27@ == 0 
jf @BBCHAL_1128 
00BC: show_text_highpriority GXT 'BB_20' time 5000 flag 1  
27@ += 1 

:BBCHAL_1128
20@ += 1 

:BBCHAL_1135
if 
  20@ == 1 
jf @BBCHAL_1380 
if 
   Player.Defined(" + PlayerChar + @")
jf @BBCHAL_1200 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 14@ 15@ 16@ radius 1.5 1.5 2.0 on_foot 

:BBCHAL_1200
if 
  " + _1930 + @" == 1 
jf @BBCHAL_1373 
if 
   Player.Defined(" + PlayerChar + @")
jf @BBCHAL_1366 
if 
00FF:   actor " + PlayerActor + @" sphere 1 in_sphere 14@ 15@ 16@ radius 1.5 1.5 2.0 on_foot 
jf @BBCHAL_1318 
if 
075C:   marker 1@ enabled 
jf @BBCHAL_1297 
Marker.Disable(1@)

:BBCHAL_1297
20@ = 0 
" + _1930 + @" = 0 
jump @BBCHAL_1366 

:BBCHAL_1318
if 
  28@ == 0 
jf @BBCHAL_1359 
00BC: show_text_highpriority GXT 'BB_16' time 5000 flag 1  
28@ += 1 

:BBCHAL_1359
" + _1930 + @" = 0 

:BBCHAL_1366
jump @BBCHAL_1380 

:BBCHAL_1373
28@ = 0 

:BBCHAL_1380
if 
  20@ == 3 
jf @BBCHAL_1424 
if 
  TIMERA > 5000 
jf @BBCHAL_1424 
gosub @BBCHAL_2538 

:BBCHAL_1424
if 
  26@ == 0 
jf @BBCHAL_1483 
if 
001C:   " + _1924 + @" > " + _1922 + @" 
jf @BBCHAL_1476 
0084: " + _1922 + @" = " + _1924 + @" 
26@ += 1 

:BBCHAL_1476
jump @BBCHAL_1510 

:BBCHAL_1483
if 
001C:   " + _1924 + @" > " + _1922 + @" 
jf @BBCHAL_1510 
0084: " + _1922 + @" = " + _1924 + @" 

:BBCHAL_1510
if 
  0 >= " + _1923 + @" 
jf @BBCHAL_1576 
if 
  3 > 20@ 
jf @BBCHAL_1569 
00BC: show_text_highpriority GXT 'BB_17' time 5000 flag 1  
TIMERA = 0 

:BBCHAL_1569
20@ = 3 

:BBCHAL_1576
return 

:BBCHAL_1578
if 
03CA:   object 0@ exists 
jf @BBCHAL_2394 
080A: get_object 0@ spoot 2 store_to 2@ 3@ 4@ 
080A: get_object 0@ spoot 3 store_to 5@ 6@ 7@ 
080A: get_object 0@ spoot 0 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
0871: init_jump_table " + _8791 + @" total_jumps 4 default_jump 0 @BBCHAL_1893 jumps 1 @BBCHAL_1705 2 @BBCHAL_1752 3 @BBCHAL_1799 4 @BBCHAL_1846 -1 @BBCHAL_1893 -1 @BBCHAL_1893 -1 @BBCHAL_1893 

:BBCHAL_1705
2@ += -1.5 
3@ += 1.5 
5@ += 1.5 
6@ += -1.5 
jump @BBCHAL_1893 

:BBCHAL_1752
2@ += -1.5 
3@ += -1.5 
5@ += 1.5 
6@ += 1.5 
jump @BBCHAL_1893 

:BBCHAL_1799
2@ += 1.5 
3@ += -1.5 
5@ += -1.5 
6@ += 1.5 
jump @BBCHAL_1893 

:BBCHAL_1846
2@ += 1.5 
3@ += 1.5 
5@ += -1.5 
6@ += -1.5 
jump @BBCHAL_1893 

:BBCHAL_1893
4@ += 5.0 
02CE: 16@ = ground_z_at 2@ 3@ 4@ 
if 
0025:   5@ > 2@ 
jf @BBCHAL_1954 
0208: 14@ = random_float_in_ranges 2@ 5@ 
jump @BBCHAL_1965 

:BBCHAL_1954
0208: 14@ = random_float_in_ranges 5@ 2@ 

:BBCHAL_1965
if 
0025:   6@ > 3@ 
jf @BBCHAL_2002 
0208: 15@ = random_float_in_ranges 3@ 6@ 
jump @BBCHAL_2013 

:BBCHAL_2002
0208: 15@ = random_float_in_ranges 3@ 6@ 

:BBCHAL_2013
0087: 8@ = 14@ 
0065: 8@ -= " + tempvar_Float_1 + @" 
0087: 9@ = 15@ 
0065: 9@ -= " + tempvar_Float_2 + @" 
0509: 17@ = distance_between_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" and_XY 14@ 15@ 
0073: 8@ /= 17@ 
0073: 9@ /= 17@ 
006B: 8@ *= 30@ 
006B: 9@ *= 30@ 
0089: 14@ = " + tempvar_Float_1 + @" 
005B: 14@ += 8@ 
0089: 15@ = " + tempvar_Float_2 + @" 
005B: 15@ += 9@ 
if 
0025:   5@ > 2@ 
jf @BBCHAL_2206 
if 
0025:   2@ > 14@ 
jf @BBCHAL_2172 
0087: 14@ = 2@ 

:BBCHAL_2172
if 
0025:   14@ > 5@ 
jf @BBCHAL_2199 
0087: 14@ = 5@ 

:BBCHAL_2199
jump @BBCHAL_2260 

:BBCHAL_2206
if 
0025:   14@ > 2@ 
jf @BBCHAL_2233 
0087: 14@ = 2@ 

:BBCHAL_2233
if 
0025:   5@ > 14@ 
jf @BBCHAL_2260 
0087: 14@ = 5@ 

:BBCHAL_2260
if 
0025:   6@ > 3@ 
jf @BBCHAL_2340 
if 
0025:   3@ > 15@ 
jf @BBCHAL_2306 
0087: 15@ = 3@ 

:BBCHAL_2306
if 
0025:   15@ > 6@ 
jf @BBCHAL_2333 
0087: 15@ = 6@ 

:BBCHAL_2333
jump @BBCHAL_2394 

:BBCHAL_2340
if 
0025:   15@ > 3@ 
jf @BBCHAL_2367 
0087: 15@ = 3@ 

:BBCHAL_2367
if 
0025:   6@ > 15@ 
jf @BBCHAL_2394 
0087: 15@ = 6@ 

:BBCHAL_2394
return 

:BBCHAL_2396
gosub @BBCHAL_1578 
if 
03CA:   object 0@ exists 
jf @BBCHAL_2435 
080A: get_object 0@ spoot 0 store_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 

:BBCHAL_2435
0509: " + Distance_Between_Points + @" = distance_between_XY 14@ 15@ and_XY " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" 
008E: 25@ = float " + Distance_Between_Points + @" to_integer 
006A: 25@ *= 29@ 
0093: 17@ = integer 29@ to_float 
17@ *= 0.1 
0092: 22@ = float 17@ to_integer 
22@ *= -1 
005A: 29@ += 22@ 
if 
  500 > 29@ 
jf @BBCHAL_2536 
29@ = 500 

:BBCHAL_2536
return 

:BBCHAL_2538
00BE: text_clear_all 
if 
   not 26@ == 0 
jf @BBCHAL_2589 
01E3: show_text_1number_styled GXT 'BB_15' number " + _1922 + @" time 5000 style 1  
0627: update_integer_stat 215 to " + _1922 + @" 
0394: play_music 1 

:BBCHAL_2589
if 
075C:   marker 1@ enabled 
jf @BBCHAL_2610 
Marker.Disable(1@)

:BBCHAL_2610
0151: remove_status_text " + _1924 + @" 
0151: remove_status_text " + _1922 + @" 
014F: stop_timer " + _1923 + @" 
" + _1921 + @" = 0 
end_thread 
return" );
            }

        }

        private sealed class PROJECT : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @"10@ = 0 
" + _1929 + @" = 0 
" + _1930 + @" = 1 
if 
  10@ == -1 
jf @PROJECT_94 
0@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)
9@ = Object.Create(#WOODENBOX, 0.0, 0.0, 0.0)

:PROJECT_94
wait 0 
if 
  10@ == 0 
jf @PROJECT_637 
if 
  8@ == 1 
jf @PROJECT_180 
0208: 17@ = random_float_in_ranges -0.2 0.2 
005B: 4@ += 17@ // (float) 
0208: 17@ = random_float_in_ranges -0.2 0.2 
005B: 5@ += 17@ // (float) 

:PROJECT_180
6@ += 0.1 
if 
0025:   3@ > 6@ // (float) 
jf @PROJECT_247 
if 
  0.0 > 7@ 
jf @PROJECT_240 
7@ = 0.0 

:PROJECT_240
jump @PROJECT_334 

:PROJECT_247
0087: 17@ = 3@ // (float) 
005B: 17@ += 7@ // (float) 
0087: 18@ = 17@ // (float) 
0063: 18@ -= 6@ // (float) 
if 
  0.5 > 18@ 
jf @PROJECT_334 
0087: 17@ = 6@ // (float) 
17@ += 0.5 
0087: 7@ = 17@ // (float) 
0063: 7@ -= 3@ // (float) 

:PROJECT_334
17@ = 0.5 
17@ *= 9.8 
0087: 18@ = 7@ // (float) 
0073: 18@ /= 17@ // (float) 
01FB: 28@ = square_root 18@ 
0087: 17@ = 3@ // (float) 
005B: 17@ += 7@ // (float) 
0063: 17@ -= 6@ // (float) 
18@ = 0.5 
18@ *= 9.8 
0087: 19@ = 17@ // (float) 
0073: 19@ /= 18@ // (float) 
01FB: 17@ = square_root 19@ 
0087: 16@ = 28@ // (float) 
005B: 16@ += 17@ // (float) 
17@ = 0.0 
0063: 17@ -= 7@ // (float) 
0087: 18@ = 28@ // (float) 
006B: 18@ *= 28@ // (float) 
0087: 29@ = 17@ // (float) 
0073: 29@ /= 18@ // (float) 
0087: 17@ = 28@ // (float) 
006B: 17@ *= 29@ // (float) 
0087: 30@ = 17@ // (float) 
30@ *= -2.0 
31@ = 0.0 
0087: 26@ = 4@ // (float) 
0063: 26@ -= 1@ // (float) 
0087: 27@ = 5@ // (float) 
0063: 27@ -= 2@ // (float) 
01BD: 11@ = current_time_in_ms 
if 
03CA:   object 0@ exists 
jf @PROJECT_630 
04D9: object 0@ set_scripted_collision_check 1 
Object.CollisionDetection(0@) = True
Object.KeepInMemory(0@) = True

:PROJECT_630
10@ += 1 

:PROJECT_637
if 
  10@ == 1 
jf @PROJECT_1032 
if 
03CA:   object 0@ exists 
jf @PROJECT_1032 
if 
84DA:   not has_object 0@ collided 
jf @PROJECT_954 
01BD: 12@ = current_time_in_ms 
0085: 13@ = 12@ // (int) 
0062: 13@ -= 11@ // (int) 
0093: 14@ = integer 13@ to_float 
14@ /= 1000.0 
if 
0025:   16@ > 14@ // (float) 
jf @PROJECT_926 
0087: 17@ = 14@ // (float) 
006B: 17@ *= 14@ // (float) 
006B: 17@ *= 29@ // (float) 
0087: 18@ = 30@ // (float) 
006B: 18@ *= 14@ // (float) 
0088: " + tempvar_Float_3 + @" = 17@ // (float) 
005F: " + tempvar_Float_3 + @" += 18@ // (float) 
005F: " + tempvar_Float_3 + @" += 31@ // (float) 
0087: 17@ = 14@ // (float) 
0073: 17@ /= 16@ // (float) 
0088: " + tempvar_Float_1 + @" = 26@ // (float) 
006D: " + tempvar_Float_1 + @" *= 17@ // (float) 
0088: " + tempvar_Float_2 + @" = 27@ // (float) 
006D: " + tempvar_Float_2 + @" *= 17@ // (float) 
0087: 20@ = 1@ // (float) 
005D: 20@ += " + tempvar_Float_1 + @" // (float) 
0087: 21@ = 2@ // (float) 
005D: 21@ += " + tempvar_Float_2 + @" // (float) 
0087: 22@ = 3@ // (float) 
005D: 22@ += " + tempvar_Float_3 + @" // (float) 
0815: put_object 0@ at 20@ 21@ 22@ and_keep_rotation 
jump @PROJECT_947 

:PROJECT_926
0815: put_object 0@ at 4@ 5@ 6@ and_keep_rotation 
10@ += 1 

:PROJECT_947
jump @PROJECT_1032 

:PROJECT_954
gosub @PROJECT_1685 
Object.KeepInMemory(0@) = False
Object.ToggleInMovingList(0@) = True
Object.CollisionDetection(0@) = True
Object.Throw(0@, 23@, 24@, 25@)
if 
876F:   not text_priority_displayed 
jf @PROJECT_1025 
00BC: show_text_highpriority GXT 'BB_06' time 4000 flag 1  // ~r~ЊpoЇax

:PROJECT_1025
10@ = 99 

:PROJECT_1032
if 
  10@ == 2 
jf @PROJECT_1396 
if 
  8@ == 1 
jf @PROJECT_1208 
if 
03CA:   object 9@ exists 
jf @PROJECT_1179 
15@ = Object.Model(9@)
if 
   Model.Available(15@)
jf @PROJECT_1179 
gosub @PROJECT_1685 
Object.KeepInMemory(0@) = False
Object.ToggleInMovingList(0@) = True
Object.CollisionDetection(0@) = True
Object.Throw(0@, 23@, 24@, 25@)
if 
876F:   not text_priority_displayed 
jf @PROJECT_1179 
00BC: show_text_highpriority GXT 'BB_06' time 4000 flag 1  // ~r~ЊpoЇax

:PROJECT_1179
097B: play_audio_at_object 0@ event 1011 
" + _1929 + @" = -1 
10@ = 99 
jump @PROJECT_1396 

:PROJECT_1208
6@ += -0.5 
if 
  6 > " + _1926 + @" 
jf @PROJECT_1285 
if 
876F:   not text_priority_displayed 
jf @PROJECT_1271 
02FD: show_text_2numbers_lowpriority GXT 'BB_05' numbers " + _1926 + @" " + _1927 + @" time 5000 flag 1  // ~b~1-o¤koўoe ЈoЈaљa®њe!~s~ Pacc¦o¬®њe ~1~.~1~Ї.

:PROJECT_1271
" + _1929 + @" = 1 
jump @PROJECT_1327 

:PROJECT_1285
if 
876F:   not text_priority_displayed 
jf @PROJECT_1320 
02FD: show_text_2numbers_lowpriority GXT 'BB_04' numbers " + _1926 + @" " + _1927 + @" time 5000 flag 1  // ~b~2-o¤koўoe ЈoЈaљa®њe!!~s~ Pacc¦o¬®њe ~1~.~1~Ї.

:PROJECT_1320
" + _1929 + @" = 2 

:PROJECT_1327
008F: 17@ = integer " + _1926 + @" to_float 
008F: 18@ = integer " + _1927 + @" to_float 
18@ *= 0.1 
005B: 17@ += 18@ // (float) 
if 
8424:   not is_system_metric 
jf @PROJECT_1382 
0425: 17@ = meters 17@ to_feet 

:PROJECT_1382
0628: update_float_stat_to 17@ stat_id 2 
10@ += 1 

:PROJECT_1396
if 
  10@ == 3 
jf @PROJECT_1651 
Object.StorePos(0@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
050A: 17@ = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ 4@ 5@ 6@ 
097B: play_audio_at_object 0@ event 1012 
if 
  0.1 > 17@ 
jf @PROJECT_1535 
Object.KeepInMemory(0@) = False
Object.CollisionDetection(0@) = True
Object.ToggleInMovingList(0@) = True
Object.Throw(0@, 0.0, 0.0, -0.1)
10@ = 99 
jump @PROJECT_1651 

:PROJECT_1535
0087: 20@ = 4@ // (float) 
0065: 20@ -= " + tempvar_Float_1 + @" // (float) 
0087: 21@ = 5@ // (float) 
0065: 21@ -= " + tempvar_Float_2 + @" // (float) 
0087: 22@ = 6@ // (float) 
0065: 22@ -= " + tempvar_Float_3 + @" // (float) 
20@ *= 0.3 
21@ *= 0.3 
22@ *= 0.3 
005F: " + tempvar_Float_1 + @" += 20@ // (float) 
005F: " + tempvar_Float_2 + @" += 21@ // (float) 
005F: " + tempvar_Float_3 + @" += 22@ // (float) 
Object.PutAt(0@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")

:PROJECT_1651
if 
  10@ == 99 
jf @PROJECT_1678 
" + _1930 + @" = 0 
end_thread 

:PROJECT_1678
jump @PROJECT_94 

:PROJECT_1685
Object.StorePos(9@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0208: 17@ = random_float_in_ranges -1.0 1.0 
0208: 18@ = random_float_in_ranges 0.2 1.0 
0208: 19@ = random_float_in_ranges 1.2 2.2 
0400: store_coords_to 20@ 21@ 22@ from_object 9@ with_offset 17@ 18@ 19@ 
0087: 23@ = 20@ // (float) 
0065: 23@ -= " + tempvar_Float_1 + @" // (float) 
0087: 24@ = 21@ // (float) 
0065: 24@ -= " + tempvar_Float_2 + @" // (float) 
0087: 25@ = 22@ // (float) 
0065: 25@ -= " + tempvar_Float_3 + @" // (float) 
050A: 17@ = distance_between_XYZ " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" and_XYZ 20@ 21@ 22@ 
0073: 23@ /= 17@ // (float) 
0073: 24@ /= 17@ // (float) 
0073: 25@ /= 17@ // (float) 
0087: 17@ = 16@ // (float) 
17@ *= 5.0 
006B: 23@ *= 17@ // (float) 
006B: 24@ *= 17@ // (float) 
006B: 25@ *= 17@ // (float) 
return" );
            }

        }

    }

}