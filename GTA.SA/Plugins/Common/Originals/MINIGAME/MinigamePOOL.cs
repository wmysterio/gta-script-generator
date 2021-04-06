using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalMinigame {

        private sealed class POOL : External {

            public override void START( LabelJump label ) {
                AppendLine( @"if 
  " + _9462 + @" == 0 
else_jump @POOL_84 
if 
  " + OnMission + @" == 0 
else_jump @POOL_75 
" + _9462 + @" = 1 
" + _9457 + @" = 0 
" + _9458 + @" = 0 
jump @POOL_77 

:POOL_75
end_thread 

:POOL_77
jump @POOL_86 

:POOL_84
end_thread 

:POOL_86
3@ = 0 

:POOL_93
wait 0 
if 
  3@ == -1 
else_jump @POOL_251 
0@ = Object.Create(#K_POOLTABLESM, 0.0, 0.0, 0.0)
1@ = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
2@ = Object.Create(#K_POOLTABLESM, 0.0, 0.0, 0.0)
" + _9458 + @" = Actor.Create(CivMale, #MALE01, 0.0, 0.0, 0.0)
" + _9457 + @" = Object.Create(#K_POOLTABLESM, 0.0, 0.0, 0.0)
" + _9459 + @" = Object.Create(#K_POOLTABLESM, 0.0, 0.0, 0.0)

:POOL_251
if 
  3@ == 0 
else_jump @POOL_474 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_467 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @POOL_453 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @POOL_439 
0209: 5@ = random_int_in_ranges 0 2 
if 
  5@ == 0 
else_jump @POOL_360 
04AF: 7@ = 66 
jump @POOL_367 

:POOL_360
04AF: 7@ = 67 

:POOL_367
Model.Load(7@)
04ED: load_animation ""POOL"" 
Model.Load(#POOLCUE)

:POOL_385
if or
   not Model.Available(7@)
84EE:   not animation ""POOL"" loaded 
   not Model.Available(#POOLCUE)
else_jump @POOL_425 
wait 0 
jump @POOL_385 

:POOL_425
3@ += 1 
jump @POOL_446 

:POOL_439
gosub @POOL_2110 

:POOL_446
jump @POOL_460 

:POOL_453
gosub @POOL_2110 

:POOL_460
jump @POOL_474 

:POOL_467
gosub @POOL_2110 

:POOL_474
if 
  3@ == 1 
else_jump @POOL_1183 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_1176 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @POOL_1162 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @POOL_1148 
if 
03CA:   object 0@ exists 
else_jump @POOL_1134 
0400: store_coords_to " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" from_object 0@ with_offset 0.0219 -1.1236 0.5363 
02CE: " + tempvar_Float_3 + @" = ground_z_at " + tempvar_Float_1 + @" " + tempvar_Float_2 + @" " + tempvar_Float_3 + @" 
if 
856D:   not actor 1@ defined 
else_jump @POOL_804 
if 
856D:   not actor " + _9458 + @" defined 
else_jump @POOL_688 
1@ = Actor.Create(CivMale, 7@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
060B: set_actor 1@ decision_maker_to " + Interior_Decision_Maker_A + @" 
Model.Destroy(7@)
" + tempvar_Angle + @" = Object.Angle(0@)
Actor.Angle(1@) = " + tempvar_Angle + @"
jump @POOL_797 

:POOL_688
if 
   not Actor.Dead(" + _9458 + @")
else_jump @POOL_749 
008B: 1@ = " + _9458 + @" 
Actor.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(0@)
Actor.Angle(1@) = " + tempvar_Angle + @"
jump @POOL_797 

:POOL_749
1@ = Actor.Create(CivMale, 7@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
060B: set_actor 1@ decision_maker_to " + Interior_Decision_Maker_A + @" 
Model.Destroy(7@)
" + tempvar_Angle + @" = Object.Angle(0@)
Actor.Angle(1@) = " + tempvar_Angle + @"

:POOL_797
jump @POOL_850 

:POOL_804
if 
   not Actor.Dead(1@)
else_jump @POOL_850 
Actor.PutAt(1@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
" + tempvar_Angle + @" = Object.Angle(0@)
Actor.Angle(1@) = " + tempvar_Angle + @"

:POOL_850
if 
83CA:   not object 2@ exists 
else_jump @POOL_888 
2@ = Object.Create(#K_POOLQ, 0.0, 0.0, 0.0)

:POOL_888
if 
   not Actor.Dead(1@)
else_jump @POOL_964 
if 
8737:   not actor 1@ lifting_object 2@ 
else_jump @POOL_964 
070A: AS_actor 1@ attach_to_object 2@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 1 

:POOL_964
0615: define_AS_pack_begin 6@ 
0812: AS_actor -1 perform_animation ""POOL_CHALKCUE"" IFP ""POOL"" framedelta 4.0 loopA 0 lockX 0 lockY 0 lockF 1 time -1 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_1035 
05BF: AS_actor -1 look_at_actor " + PlayerActor + @" 9000 ms 

:POOL_1035
0812: AS_actor -1 perform_animation ""POOL_IDLE_STANCE"" IFP ""POOL"" framedelta 4.0 loopA 0 lockX 1 lockY 1 lockF 0 time 10000 
0643: set_AS_pack 6@ loop 1 
0616: define_AS_pack_end 6@ 
if 
   not Actor.Dead(1@)
else_jump @POOL_1115 
0618: assign_actor 1@ to_AS_pack 6@ 

:POOL_1115
061B: remove_references_to_AS_pack 6@ 
3@ += 1 
jump @POOL_1141 

:POOL_1134
gosub @POOL_2110 

:POOL_1141
jump @POOL_1155 

:POOL_1148
gosub @POOL_2110 

:POOL_1155
jump @POOL_1169 

:POOL_1162
gosub @POOL_2110 

:POOL_1169
jump @POOL_1183 

:POOL_1176
gosub @POOL_2110 

:POOL_1183
if 
  3@ == 2 
else_jump @POOL_1721 
if 
  " + OnMission + @" == 0 
else_jump @POOL_1693 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_1679 
if 
  " + _9470 + @" == 0 
else_jump @POOL_1644 
if 
03CA:   object 0@ exists 
else_jump @POOL_1630 
if 
   not Actor.Dead(1@)
else_jump @POOL_1616 
if 
051A:   actor 1@ damaged_by_actor " + PlayerActor + @" 
else_jump @POOL_1364 
0687: clear_actor 1@ task 
070B: set_actor 1@ onbone_attached_object_operation 0 
Object.Destroy(2@)
Actor.GiveWeaponAndAmmo(1@, PoolCue, 99999)
05E2: AS_actor 1@ kill_actor " + PlayerActor + @" 
03E6: remove_text_box 
4@ = 0 
jump @POOL_2001 
jump @POOL_1609 

:POOL_1364
if 
0105:   actor 1@ near_actor " + PlayerActor + @" radius 1.5 1.5 1.5 sphere 0 on_foot 
else_jump @POOL_1582 
if 
00E1:   player 0 pressed_key 15 
else_jump @POOL_1539 
5@ = Player.Money(" + PlayerChar + @")
if 
  50 > 5@ 
else_jump @POOL_1466 
00BC: show_text_highpriority GXT 'NOCASH' time 3000 flag 1  
jump @POOL_1532 

:POOL_1466
if 
  4@ == 1 
else_jump @POOL_1494 
03E6: remove_text_box 
008B: 4@ = " + OnMission + @" 

:POOL_1494
008A: " + _9457 + @" = 0@ 
008A: " + _9458 + @" = 1@ 
008A: " + _9459 + @" = 2@ 
" + Video_Game + @" = 5 
3@ += 1 

:POOL_1532
jump @POOL_1575 

:POOL_1539
if 
  4@ == 0 
else_jump @POOL_1575 
0512: show_permanent_text_box 'POOL_A'  
4@ = 1 

:POOL_1575
jump @POOL_1609 

:POOL_1582
if 
  4@ == 1 
else_jump @POOL_1609 
03E6: remove_text_box 
4@ = 0 

:POOL_1609
jump @POOL_1623 

:POOL_1616
jump @POOL_2001 

:POOL_1623
jump @POOL_1637 

:POOL_1630
jump @POOL_2001 

:POOL_1637
jump @POOL_1672 

:POOL_1644
if 
   not Actor.Dead(1@)
else_jump @POOL_1665 
0687: clear_actor 1@ task 

:POOL_1665
jump @POOL_2001 

:POOL_1672
jump @POOL_1686 

:POOL_1679
jump @POOL_2001 

:POOL_1686
jump @POOL_1721 

:POOL_1693
if 
   not Actor.Dead(1@)
else_jump @POOL_1714 
0687: clear_actor 1@ task 

:POOL_1714
jump @POOL_2001 

:POOL_1721
if 
  3@ == 3 
else_jump @POOL_1764 
if 
  " + OnMission + @" == 1 
else_jump @POOL_1764 
3@ += 1 

:POOL_1764
if 
  3@ == 4 
else_jump @POOL_1896 
if 
  " + OnMission + @" == 0 
else_jump @POOL_1896 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_1896 
if 
   Player.Controllable(" + PlayerChar + @")
else_jump @POOL_1896 
if 
88B4:   not test " + _390 + @" bit 1 
else_jump @POOL_1896 
if 
03CA:   object 0@ exists 
else_jump @POOL_1896 
if 
   not Actor.Dead(1@)
else_jump @POOL_1896 
3@ = 1 
jump @POOL_474 

:POOL_1896
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_1987 
if 
03CA:   object 0@ exists 
else_jump @POOL_1973 
if 
8471:   not actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 80.0 80.0 sphere 0 
else_jump @POOL_1966 
jump @POOL_2001 

:POOL_1966
jump @POOL_1980 

:POOL_1973
jump @POOL_2001 

:POOL_1980
jump @POOL_1994 

:POOL_1987
jump @POOL_2001 

:POOL_1994
jump @POOL_93 

:POOL_2001
if 
   Player.Defined(" + PlayerChar + @")
else_jump @POOL_2092 
if 
03CA:   object 0@ exists 
else_jump @POOL_2078 
if 
8471:   not actor " + PlayerActor + @" near_object_in_rectangle 0@ radius 80.0 80.0 sphere 0 
else_jump @POOL_2071 
gosub @POOL_2110 

:POOL_2071
jump @POOL_2085 

:POOL_2078
gosub @POOL_2110 

:POOL_2085
jump @POOL_2099 

:POOL_2092
gosub @POOL_2110 

:POOL_2099
wait 0 
jump @POOL_2001 

:POOL_2110
if 
  4@ == 1 
else_jump @POOL_2130 
03E6: remove_text_box 

:POOL_2130
03D5: remove_text 'NOCASH'  
Actor.RemoveReferences(1@)
Object.Destroy(2@)
Model.Destroy(7@)
04EF: release_animation ""POOL"" 
Model.Destroy(#POOLCUE)
" + _9462 + @" = 0 
" + _9457 + @" = 0 
" + _9458 + @" = 0 
end_thread 
return 
end_thread" );
            }

        }

    }

}