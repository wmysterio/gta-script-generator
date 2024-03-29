﻿using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalODDVEH {

        private sealed class TRUCK : MissionCustom {

            public override void START( LabelJump label ) {
                AppendLine( @"gosub @TRUCK_47 
if 
wasted_or_busted 
else_jump @TRUCK_38 
gosub @TRUCK_16344 

:TRUCK_38
gosub @TRUCK_16749 
end_thread 

:TRUCK_47
if 
  " + Mission_Trucking_Passed + @" == 0 
else_jump @TRUCK_67 
increment_mission_attempts 

:TRUCK_67
" + OnMission + @" = 1 
" + _411 + @" = 1 
34@ = 0 
35@ = 0 
36@ = 0 
37@ = 0 
38@ = 0 
39@ = 0 
40@ = 0 
41@ = 0 
42@ = 0 
47@ = 0 
48@ = 0 
32@ = 0 
33@ = 0 
105@ = 0 
106@ = 0 
114@ = 0 
if 
  36@ == -99 
else_jump @TRUCK_324 
0662: printstring ""SHOULD_NEVER_BE_IN_FAKE_ENTITY_CREATION"" 
74@ = Car.Create(#PETRO, 0.0, 0.0, 0.0)
75@ = Car.Create(#PETROTR, 0.0, 0.0, 0.0)
78@ = Marker.CreateAboveCar(74@)
77@ = Marker.CreateAboveCar(74@)
79@ = Marker.CreateAboveCar(75@)

:TRUCK_324
054C: use_GXT_table 'TRUCK' 
if 
  " + Trucking_Total_Passed_Missions + @" >= 6 
else_jump @TRUCK_468 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  2 > " + STAT_Unlocked_Cities_Number + @" 
else_jump @TRUCK_468 
00BC: show_text_highpriority GXT 'TRK_H17' time 5000 flag 1  
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRUCK_450 
Actor.PutAt(" + PlayerActor + @", -76.9664, -1134.639, 0.0781)
Actor.Angle(" + PlayerActor + @") = 14.7291
Camera.SetBehindPlayer
Player.CanMove(" + PlayerChar + @") = True

:TRUCK_450
fade 1 500 
wait 5000 
0A2D: hide_styled_text_while_fading 1 
return 

:TRUCK_468
if 
  " + Trucking_Total_Passed_Missions + @" >= 4 
else_jump @TRUCK_601 
0652: " + STAT_Unlocked_Cities_Number + @" = integer_stat 181 
if 
  1 > " + STAT_Unlocked_Cities_Number + @" 
else_jump @TRUCK_601 
00BC: show_text_highpriority GXT 'TRK_H18' time 5000 flag 1  
if 
   not Actor.Dead(" + PlayerActor + @")
else_jump @TRUCK_583 
Actor.PutAt(" + PlayerActor + @", -76.9664, -1134.639, 0.0781)
Actor.Angle(" + PlayerActor + @") = 14.7291
Camera.SetBehindPlayer
Player.CanMove(" + PlayerChar + @") = True

:TRUCK_583
fade 1 500 
wait 5000 
0A2D: hide_styled_text_while_fading 1 
return 

:TRUCK_601
gosub @TRUCK_15391 
gosub @TRUCK_15393 
wait 100 

:TRUCK_619
wait 0 
gosub @TRUCK_12403 
gosub @TRUCK_12776 
if or
  40@ == 1 
  41@ == 1 
else_jump @TRUCK_669 
jump @TRUCK_896 

:TRUCK_669
gosub @TRUCK_15288 
gosub @TRUCK_15322 
if 
   Actor.Dead(" + PlayerActor + @")
else_jump @TRUCK_713 
39@ = 1 
jump @TRUCK_896 

:TRUCK_713
if 
  36@ == 0 
else_jump @TRUCK_771 
0662: printstring ""STAGE_SHOULD_NEVER_BE_0_IN_MAIN_LOOP"" 

:TRUCK_771
if 
  36@ == 1 
else_jump @TRUCK_796 
gosub @TRUCK_1097 

:TRUCK_796
if 
  36@ == 2 
else_jump @TRUCK_821 
gosub @TRUCK_1312 

:TRUCK_821
if 
  36@ == 3 
else_jump @TRUCK_846 
38@ = 1 

:TRUCK_846
if 
  36@ == 50 
else_jump @TRUCK_871 
gosub @TRUCK_2470 

:TRUCK_871
if 
  36@ == 51 
else_jump @TRUCK_896 
40@ = 1 

:TRUCK_896
if 
  40@ == 0 
else_jump @TRUCK_1049 
if 
  39@ == 0 
else_jump @TRUCK_1033 
if 
  38@ == 0 
else_jump @TRUCK_964 
jump @TRUCK_619 
jump @TRUCK_1026 

:TRUCK_964
gosub @TRUCK_16742 
if 
  114@ == 1 
else_jump @TRUCK_1024 
38@ = 0 
36@ = 50 
37@ = 0 
114@ = 0 
jump @TRUCK_619 

:TRUCK_1024
return 

:TRUCK_1026
jump @TRUCK_1042 

:TRUCK_1033
gosub @TRUCK_16344 
return 

:TRUCK_1042
jump @TRUCK_1051 

:TRUCK_1049
return 

:TRUCK_1051
0662: printstring ""SHOULD_NEVER_BE_HERE_IN_END_OF_MAIN_LOOP"" 
return 

:TRUCK_1097
if or
   Car.Wrecked(75@)
   Car.Wrecked(74@)
else_jump @TRUCK_1134 
39@ = 1 
89@ = 3 
return 

:TRUCK_1134
if 
  37@ == 0 
else_jump @TRUCK_1236 
04F7: status_text " + _8160 + @" type 0 line 1 GXT 'TRK_CSH' 
008A: " + _8160 + @" = 91@ 
0085: 83@ = 91@ 
gosub @TRUCK_3418 
gosub @TRUCK_3636 
gosub @TRUCK_5170 
77@ = Marker.CreateAboveCar(74@)
07E0: set_marker 77@ type_to 1 
113@ = 0 
37@ += 1 

:TRUCK_1236
if 
  37@ == 1 
else_jump @TRUCK_1285 
if 
   Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_1285 
Marker.Disable(77@)
37@ = 99 

:TRUCK_1285
if 
  37@ == 99 
else_jump @TRUCK_1310 
gosub @TRUCK_15361 

:TRUCK_1310
return 

:TRUCK_1312
if or
   Car.Wrecked(74@)
   Car.Wrecked(75@)
else_jump @TRUCK_1349 
39@ = 1 
89@ = 3 
return 

:TRUCK_1349
if 
  113@ == 0 
else_jump @TRUCK_1394 
gosub @TRUCK_5187 
if 
  39@ == 1 
else_jump @TRUCK_1394 
return 

:TRUCK_1394
if 
  37@ == 0 
else_jump @TRUCK_1679 
018A: 76@ = create_checkpoint_at 102@ 103@ 104@ 
Marker.SetIconSize(76@, 4)
106@ = 0 
gosub @TRUCK_5875 
0871: init_jump_table 88@ total_jumps 6 default_jump 1 @TRUCK_1648 jumps 1 @TRUCK_1510 2 @TRUCK_1533 3 @TRUCK_1556 4 @TRUCK_1579 5 @TRUCK_1602 6 @TRUCK_1625 -1 @TRUCK_1672 

:TRUCK_1510
00BC: show_text_highpriority GXT 'TRK_H6' time 15000 flag 1  
jump @TRUCK_1672 

:TRUCK_1533
00BC: show_text_highpriority GXT 'TRK_H7' time 15000 flag 1  
jump @TRUCK_1672 

:TRUCK_1556
00BC: show_text_highpriority GXT 'TRK_H12' time 15000 flag 1  
jump @TRUCK_1672 

:TRUCK_1579
00BC: show_text_highpriority GXT 'TRK_H9' time 15000 flag 1  
jump @TRUCK_1672 

:TRUCK_1602
00BC: show_text_highpriority GXT 'TRK_H11' time 15000 flag 1  
jump @TRUCK_1672 

:TRUCK_1625
00BC: show_text_highpriority GXT 'TRK_H10' time 15000 flag 1  
jump @TRUCK_1672 

:TRUCK_1648
0662: printstring ""UNKNOWN_MISSION_TYPE"" 

:TRUCK_1672
37@ += 1 

:TRUCK_1679
if 
  37@ == 1 
else_jump @TRUCK_1922 
0087: 63@ = 102@ 
63@ -= 4.0 
0087: 64@ = 103@ 
64@ -= 4.0 
0087: 65@ = 104@ 
65@ -= 4.0 
0087: 66@ = 102@ 
66@ += 4.0 
0087: 67@ = 103@ 
67@ += 4.0 
0087: 68@ = 104@ 
68@ += 4.0 
if or
00B1:   car 75@ sphere 1 in_cube_cornerA 63@ 64@ 65@ cornerB 66@ 67@ 68@ 
00B1:   car 74@ sphere 0 in_cube_cornerA 63@ 64@ 65@ cornerB 66@ 67@ 68@ 
else_jump @TRUCK_1922 
if and
   Actor.InCar(" + PlayerActor + @", 74@)
07AB:   car 75@ has_attached_trailer 74@ 
else_jump @TRUCK_1922 
Player.CanMove(" + PlayerChar + @") = False
113@ = 1 
81@ += 15000 
37@ += 1 

:TRUCK_1922
if 
  37@ == 2 
else_jump @TRUCK_1990 
if and
01C1:   car 75@ stopped 
01C1:   car 74@ stopped 
else_jump @TRUCK_1990 
Car.LockInCurrentPosition(74@) = True
05CD: AS_actor " + PlayerActor + @" exit_car 74@ 
gosub @TRUCK_16540 
37@ += 1 

:TRUCK_1990
if 
  37@ == 3 
else_jump @TRUCK_2053 
if 
   not Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_2053 
0508: car 74@ close_all_doors 
Car.DoorStatus(74@) = 2
Player.CanMove(" + PlayerChar + @") = True
37@ = 99 

:TRUCK_2053
gosub @TRUCK_7116 
gosub @TRUCK_7271 
gosub @TRUCK_7500 
if 
  106@ == 1 
else_jump @TRUCK_2099 
gosub @TRUCK_7694 

:TRUCK_2099
if 
  106@ == 0 
else_jump @TRUCK_2284 
59@ = -76.1692 
60@ = -1128.963 
61@ = 0.0781 
if and
01AF:   car 75@ sphere 0 in_sphere 59@ 60@ 61@ radius 40.0 40.0 40.0 
81AF:   not car 75@ sphere 0 in_sphere 59@ 60@ 61@ radius 20.0 20.0 20.0 
else_jump @TRUCK_2284 
01EB: set_traffic_density_multiplier_to 1.0 
if 
  88@ == 4 
else_jump @TRUCK_2252 
Player.SetMinWantedLevel(" + PlayerChar + @", 3)

:TRUCK_2252
if 
  88@ == 6 
else_jump @TRUCK_2277 
Player.SetMinWantedLevel(" + PlayerChar + @", 4)

:TRUCK_2277
106@ = 1 

:TRUCK_2284
if 
  105@ == 0 
else_jump @TRUCK_2384 
if 
  110@ == 1 
else_jump @TRUCK_2343 
00BC: show_text_highpriority GXT 'TRK_H14' time 6000 flag 1  
110@ = 0 

:TRUCK_2343
if 
  111@ == 1 
else_jump @TRUCK_2384 
00BC: show_text_highpriority GXT 'TRK_H15' time 6000 flag 1  
111@ = 0 

:TRUCK_2384
if 
  105@ == 0 
else_jump @TRUCK_2443 
if 
  112@ == 1 
else_jump @TRUCK_2443 
00BC: show_text_highpriority GXT 'TRK_H16' time 7000 flag 1  
112@ = 0 

:TRUCK_2443
if 
  37@ == 99 
else_jump @TRUCK_2468 
gosub @TRUCK_15361 

:TRUCK_2468
return 

:TRUCK_2470
if 
  37@ == 0 
else_jump @TRUCK_2545 
Player.CanMove(" + PlayerChar + @") = False
0085: 82@ = 47@ 
82@ += 5000 
Actor.StorePos(" + PlayerActor + @", 59@, 60@, 61@)
62@ = Actor.Angle(" + PlayerActor + @")
0151: remove_status_text " + _8160 + @" 
37@ += 1 

:TRUCK_2545
if 
  37@ == 1 
else_jump @TRUCK_2612 
if 
001D:   47@ > 82@ 
else_jump @TRUCK_2612 
fade 0 500 
0085: 82@ = 47@ 
82@ += 500 
37@ += 1 

:TRUCK_2612
if 
  37@ == 2 
else_jump @TRUCK_2861 
if and
001D:   47@ > 82@ 
   not fading 
else_jump @TRUCK_2861" );
_1933.create( -82.2693, -1135.526, 0.5847, 2000, 2000 );
AppendLine( @"02A3: enable_widescreen 1 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @TRUCK_2724 
0362: remove_actor " + PlayerActor + @" from_car_and_place_at -47.0873 -1122.146 0.4453 
jump @TRUCK_2744 

:TRUCK_2724
Actor.PutAt(" + PlayerActor + @", -47.0873, -1122.146, 0.4453)

:TRUCK_2744
Car.RemoveReferences(74@)
Car.RemoveReferences(75@)
03BF: set_player " + PlayerChar + @" ignored_by_everyone 1 
03F4: set_all_cars_apply_damage_rules 0 
0A0B: set_rendering_origin_at_3D_coord -96.3779 -1125.262 0.093 angle 261.7115 
Camera.SetPosition(-109.2539, -1122.353, 15.1451, 0.0, 0.0, 0.0)
Camera.PointAt(-108.3806, -1122.439, 14.6655, 2)
0085: 82@ = 47@ 
82@ += 2000 
37@ += 1 

:TRUCK_2861
if 
  37@ == 3 
else_jump @TRUCK_2944 
if 
001D:   47@ > 82@ 
else_jump @TRUCK_2944 
fade 1 500 
00BA: show_text_styled GXT 'ASS_ACQ' time 5000 style 6  
0085: 82@ = 47@ 
82@ += 5000 
37@ += 1 

:TRUCK_2944
if 
  37@ == 4 
else_jump @TRUCK_3074 
if 
001D:   47@ > 82@ 
else_jump @TRUCK_3074 
Camera.SetPosition(-83.7387, -1133.793, 0.9871, 0.0, 0.0, 0.0)
Camera.PointAt(-82.9525, -1134.41, 0.9592, 2)
01E5: show_text_1number_highpriority GXT 'ASS_LUV' number 2000 time 6000 flag 1  
0085: 82@ = 47@ 
82@ += 6000 
37@ += 1 

:TRUCK_3074
if 
  37@ == 5 
else_jump @TRUCK_3141 
if 
001D:   47@ > 82@ 
else_jump @TRUCK_3141 
fade 0 500 
0085: 82@ = 47@ 
82@ += 500 
37@ += 1 

:TRUCK_3141
if 
  37@ == 6 
else_jump @TRUCK_3244 
if and
001D:   47@ > 82@ 
   not fading 
else_jump @TRUCK_3244 
Actor.PutAt(" + PlayerActor + @", 59@, 60@, 61@)
Actor.Angle(" + PlayerActor + @") = 62@
Camera.SetAtPos(59@, 60@, 61@)
02A3: enable_widescreen 0 
Camera.SetBehindPlayer
Camera.Restore_WithJumpCut
0085: 82@ = 47@ 
82@ += 2000 
37@ += 1 

:TRUCK_3244
if 
  37@ == 7 
else_jump @TRUCK_3327 
if 
001D:   47@ > 82@ 
else_jump @TRUCK_3327 
00BC: show_text_highpriority GXT 'TRK_P2' time 10000 flag 1  
fade 1 500 
0085: 82@ = 47@ 
82@ += 500 
37@ += 1 

:TRUCK_3327
if 
  37@ == 8 
else_jump @TRUCK_3391 
if and
001D:   47@ > 82@ 
   not fading 
else_jump @TRUCK_3391 
03BF: set_player " + PlayerChar + @" ignored_by_everyone 0 
03F4: set_all_cars_apply_damage_rules 1 
Player.CanMove(" + PlayerChar + @") = True
37@ = 99 

:TRUCK_3391
if 
  37@ == 99 
else_jump @TRUCK_3416 
gosub @TRUCK_15361 

:TRUCK_3416
return 

:TRUCK_3418
0871: init_jump_table 88@ total_jumps 6 default_jump 1 @TRUCK_3607 jumps 1 @TRUCK_3481 2 @TRUCK_3502 3 @TRUCK_3523 4 @TRUCK_3544 5 @TRUCK_3565 6 @TRUCK_3586 -1 @TRUCK_3634 

:TRUCK_3481
05AA: 98@s = 'TRK_MND' 
jump @TRUCK_3634 

:TRUCK_3502
05AA: 98@s = 'TRK_MNT' 
jump @TRUCK_3634 

:TRUCK_3523
05AA: 98@s = 'TRK_MFD' 
jump @TRUCK_3634 

:TRUCK_3544
05AA: 98@s = 'TRK_MI' 
jump @TRUCK_3634 

:TRUCK_3565
05AA: 98@s = 'TRK_MTD' 
jump @TRUCK_3634 

:TRUCK_3586
05AA: 98@s = 'TRK_MHI' 
jump @TRUCK_3634 

:TRUCK_3607
0662: printstring ""UNKNOWN_MISSION_TYPE_ID"" 

:TRUCK_3634
return 

:TRUCK_3636
if 
  86@ == 1 
else_jump @TRUCK_3801 
0871: init_jump_table 87@ total_jumps 4 default_jump 0 @TRUCK_3801 jumps 0 @TRUCK_3717 1 @TRUCK_3738 2 @TRUCK_3759 3 @TRUCK_3780 -1 @TRUCK_3801 -1 @TRUCK_3801 -1 @TRUCK_3801 

:TRUCK_3717
05AA: 100@s = 'TRK_CE0' 
jump @TRUCK_3801 

:TRUCK_3738
05AA: 100@s = 'TRK_CE1' 
jump @TRUCK_3801 

:TRUCK_3759
05AA: 100@s = 'TRK_CE2' 
jump @TRUCK_3801 

:TRUCK_3780
05AA: 100@s = 'TRK_CE3' 
jump @TRUCK_3801 

:TRUCK_3801
if 
  86@ == 2 
else_jump @TRUCK_3924 
0871: init_jump_table 87@ total_jumps 2 default_jump 0 @TRUCK_3924 jumps 0 @TRUCK_3882 1 @TRUCK_3903 -1 @TRUCK_3924 -1 @TRUCK_3924 -1 @TRUCK_3924 -1 @TRUCK_3924 -1 @TRUCK_3924 

:TRUCK_3882
05AA: 100@s = 'TRK_CE4' 
jump @TRUCK_3924 

:TRUCK_3903
05AA: 100@s = 'TRK_CE5' 
jump @TRUCK_3924 

:TRUCK_3924
if 
  86@ == 3 
else_jump @TRUCK_4089 
0871: init_jump_table 87@ total_jumps 4 default_jump 0 @TRUCK_4089 jumps 0 @TRUCK_4005 1 @TRUCK_4026 2 @TRUCK_4047 3 @TRUCK_4068 -1 @TRUCK_4089 -1 @TRUCK_4089 -1 @TRUCK_4089 

:TRUCK_4005
05AA: 100@s = 'TRK_LS0' 
jump @TRUCK_4089 

:TRUCK_4026
05AA: 100@s = 'TRK_LS1' 
jump @TRUCK_4089 

:TRUCK_4047
05AA: 100@s = 'TRK_LS2' 
jump @TRUCK_4089 

:TRUCK_4068
05AA: 100@s = 'TRK_LS3' 
jump @TRUCK_4089 

:TRUCK_4089
if 
  86@ == 8 
else_jump @TRUCK_4529 
0871: init_jump_table 87@ total_jumps 14 default_jump 0 @TRUCK_4529 jumps 0 @TRUCK_4235 1 @TRUCK_4256 2 @TRUCK_4277 3 @TRUCK_4298 4 @TRUCK_4319 5 @TRUCK_4340 6 @TRUCK_4361 
0872: jump_table_jumps 7 @TRUCK_4382 8 @TRUCK_4403 9 @TRUCK_4424 10 @TRUCK_4445 11 @TRUCK_4466 12 @TRUCK_4487 13 @TRUCK_4508 -1 @TRUCK_4529 -1 @TRUCK_4529 

:TRUCK_4235
05AA: 100@s = 'TRK_V0' 
jump @TRUCK_4529 

:TRUCK_4256
05AA: 100@s = 'TRK_V1' 
jump @TRUCK_4529 

:TRUCK_4277
05AA: 100@s = 'TRK_V2' 
jump @TRUCK_4529 

:TRUCK_4298
05AA: 100@s = 'TRK_V3' 
jump @TRUCK_4529 

:TRUCK_4319
05AA: 100@s = 'TRK_V4' 
jump @TRUCK_4529 

:TRUCK_4340
05AA: 100@s = 'TRK_V5' 
jump @TRUCK_4529 

:TRUCK_4361
05AA: 100@s = 'TRK_V6' 
jump @TRUCK_4529 

:TRUCK_4382
05AA: 100@s = 'TRK_V7' 
jump @TRUCK_4529 

:TRUCK_4403
05AA: 100@s = 'TRK_V8' 
jump @TRUCK_4529 

:TRUCK_4424
05AA: 100@s = 'TRK_V9' 
jump @TRUCK_4529 

:TRUCK_4445
05AA: 100@s = 'TRK_V10' 
jump @TRUCK_4529 

:TRUCK_4466
05AA: 100@s = 'TRK_V11' 
jump @TRUCK_4529 

:TRUCK_4487
05AA: 100@s = 'TRK_V12' 
jump @TRUCK_4529 

:TRUCK_4508
05AA: 100@s = 'TRK_V13' 
jump @TRUCK_4529 

:TRUCK_4529
if 
  86@ == 7 
else_jump @TRUCK_4715 
0871: init_jump_table 87@ total_jumps 5 default_jump 0 @TRUCK_4715 jumps 0 @TRUCK_4610 1 @TRUCK_4631 2 @TRUCK_4652 3 @TRUCK_4673 4 @TRUCK_4694 -1 @TRUCK_4715 -1 @TRUCK_4715 

:TRUCK_4610
05AA: 100@s = 'TRK_NC0' 
jump @TRUCK_4715 

:TRUCK_4631
05AA: 100@s = 'TRK_NC1' 
jump @TRUCK_4715 

:TRUCK_4652
05AA: 100@s = 'TRK_NC2' 
jump @TRUCK_4715 

:TRUCK_4673
05AA: 100@s = 'TRK_NC3' 
jump @TRUCK_4715 

:TRUCK_4694
05AA: 100@s = 'TRK_NC4' 
jump @TRUCK_4715 

:TRUCK_4715
if 
  86@ == 4 
else_jump @TRUCK_4859 
0871: init_jump_table 87@ total_jumps 3 default_jump 0 @TRUCK_4859 jumps 0 @TRUCK_4796 1 @TRUCK_4817 2 @TRUCK_4838 -1 @TRUCK_4859 -1 @TRUCK_4859 -1 @TRUCK_4859 -1 @TRUCK_4859 

:TRUCK_4796
05AA: 100@s = 'TRK_CS0' 
jump @TRUCK_4859 

:TRUCK_4817
05AA: 100@s = 'TRK_CS1' 
jump @TRUCK_4859 

:TRUCK_4838
05AA: 100@s = 'TRK_CS2' 
jump @TRUCK_4859 

:TRUCK_4859
if 
  86@ == 5 
else_jump @TRUCK_5024 
0871: init_jump_table 87@ total_jumps 4 default_jump 0 @TRUCK_5024 jumps 0 @TRUCK_4940 1 @TRUCK_4961 2 @TRUCK_4982 3 @TRUCK_5003 -1 @TRUCK_5024 -1 @TRUCK_5024 -1 @TRUCK_5024 

:TRUCK_4940
05AA: 100@s = 'TRK_SF0' 
jump @TRUCK_5024 

:TRUCK_4961
05AA: 100@s = 'TRK_SF1' 
jump @TRUCK_5024 

:TRUCK_4982
05AA: 100@s = 'TRK_SF2' 
jump @TRUCK_5024 

:TRUCK_5003
05AA: 100@s = 'TRK_SF3' 
jump @TRUCK_5024 

:TRUCK_5024
if 
  86@ == 6 
else_jump @TRUCK_5168 
0871: init_jump_table 87@ total_jumps 3 default_jump 0 @TRUCK_5168 jumps 0 @TRUCK_5105 1 @TRUCK_5126 2 @TRUCK_5147 -1 @TRUCK_5168 -1 @TRUCK_5168 -1 @TRUCK_5168 -1 @TRUCK_5168 

:TRUCK_5105
05AA: 100@s = 'TRK_CN0' 
jump @TRUCK_5168 

:TRUCK_5126
05AA: 100@s = 'TRK_CN1' 
jump @TRUCK_5168 

:TRUCK_5147
05AA: 100@s = 'TRK_CN2' 
jump @TRUCK_5168 

:TRUCK_5168
return 

:TRUCK_5170
03EB: clear_small_messages_only 
0384: show_text_1string GXT 98@s string 100@s time 15000 1 
return 

:TRUCK_5187
if 
  105@ == 1 
else_jump @TRUCK_5743 
if and
07AB:   car 75@ has_attached_trailer 74@ 
   Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_5281 
84@ = 0 
105@ = 0 
Marker.Disable(78@)
Marker.Disable(79@)
018A: 76@ = create_checkpoint_at 102@ 103@ 104@ 
Marker.SetIconSize(76@, 4)
03EB: clear_small_messages_only 
return 

:TRUCK_5281
50@ = Car.Health(74@)
if 
  250 > 50@ 
else_jump @TRUCK_5320 
03EB: clear_small_messages_only 
Marker.Disable(78@)
Marker.Disable(79@)

:TRUCK_5320
if 
001D:   47@ > 80@ 
else_jump @TRUCK_5362 
84@ -= 1 
0085: 80@ = 47@ 
80@ += 1000 

:TRUCK_5362
if 
  0 > 84@ 
else_jump @TRUCK_5474 
39@ = 1 
03EB: clear_small_messages_only 
Marker.Disable(78@)
Marker.Disable(79@)
72@ = 0 
if 
   not Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_5439 
72@ = 1 
89@ = 4 

:TRUCK_5439
if and
87AB:   not car 75@ has_attached_trailer 74@ 
  72@ == 0 
else_jump @TRUCK_5472 
89@ = 5 

:TRUCK_5472
return 

:TRUCK_5474
00BE: text_clear_all 
09C1: add_next_text_to_brief_history 0 
if 
   not Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_5621 
if 
  84@ == 1 
else_jump @TRUCK_5543 
01E4: show_text_1number_lowpriority GXT 'TRK_H5B' number 84@ time 1000 flag 1  
jump @TRUCK_5562 

:TRUCK_5543
01E4: show_text_1number_lowpriority GXT 'TRK_H5' number 84@ time 1000 flag 1  

:TRUCK_5562
if 
075C:   marker 79@ enabled 
else_jump @TRUCK_5583 
Marker.Disable(79@)

:TRUCK_5583
if 
875C:   not marker 78@ enabled 
else_jump @TRUCK_5614 
78@ = Marker.CreateAboveCar(74@)
07E0: set_marker 78@ type_to 1 

:TRUCK_5614
jump @TRUCK_5736 

:TRUCK_5621
if 
  84@ == 1 
else_jump @TRUCK_5665 
01E4: show_text_1number_lowpriority GXT 'TRK_H4B' number 84@ time 1000 flag 1  
jump @TRUCK_5684 

:TRUCK_5665
01E4: show_text_1number_lowpriority GXT 'TRK_H4' number 84@ time 1000 flag 1  

:TRUCK_5684
if 
875C:   not marker 79@ enabled 
else_jump @TRUCK_5715 
79@ = Marker.CreateAboveCar(75@)
07E0: set_marker 79@ type_to 1 

:TRUCK_5715
if 
075C:   marker 78@ enabled 
else_jump @TRUCK_5736 
Marker.Disable(78@)

:TRUCK_5736
jump @TRUCK_5873 

:TRUCK_5743
if or
87AB:   not car 75@ has_attached_trailer 74@ 
   not Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_5873 
84@ = 60 
0085: 80@ = 47@ 
80@ += 1000 
105@ = 1 
Marker.Disable(76@)
09C1: add_next_text_to_brief_history 0 
if 
   not Actor.InCar(" + PlayerActor + @", 74@)
else_jump @TRUCK_5854 
01E5: show_text_1number_highpriority GXT 'TRK_H5' number 84@ time 1000 flag 1  
jump @TRUCK_5873 

:TRUCK_5854
01E5: show_text_1number_highpriority GXT 'TRK_H4' number 84@ time 1000 flag 1  

:TRUCK_5873
return 

:TRUCK_5875
90@ = 750 
if or
  88@ == 1 
  88@ == 5 
else_jump @TRUCK_5916 
90@ = 500 

:TRUCK_5916
if 
  88@ == 3 
else_jump @TRUCK_5942 
90@ = 250 

:TRUCK_5942
0085: 50@ = 90@ 
50@ += 250 
Car.Health(75@) = 50@
Car.Health(74@) = 50@
92@ = 0 
gosub @TRUCK_6155 
if or
  88@ == 1 
  88@ == 3 
else_jump @TRUCK_6031 
04F7: status_text " + _8161 + @" type 1 line 2 GXT 'TRK_DMG' 

:TRUCK_6031
if 
  88@ == 2 
else_jump @TRUCK_6076 
gosub @TRUCK_6559 
03C3: set_timer_to " + _8162 + @" type 0 GXT 'TRK_TIM' 
0396: pause_timer 1 

:TRUCK_6076
if 
  88@ == 5 
else_jump @TRUCK_6139 
gosub @TRUCK_6559 
03C3: set_timer_to " + _8162 + @" type 0 GXT 'TRK_TIM' 
04F7: status_text " + _8161 + @" type 1 line 2 GXT 'TRK_DMG' 
0396: pause_timer 1 

:TRUCK_6139
110@ = 0 
111@ = 0 
return 

:TRUCK_6155
0871: init_jump_table 92@ total_jumps 5 default_jump 0 @TRUCK_6365 jumps 0 @TRUCK_6218 1 @TRUCK_6256 2 @TRUCK_6293 3 @TRUCK_6330 4 @TRUCK_6351 -1 @TRUCK_6365 -1 @TRUCK_6365 

:TRUCK_6218
0085: 81@ = 93@ 
81@ *= 140 
005A: 81@ += 47@ 
92@ = 1 
jump @TRUCK_6365 

:TRUCK_6256
0085: 81@ = 93@ 
81@ *= 84 
005A: 81@ += 47@ 
92@ = 2 
jump @TRUCK_6365 

:TRUCK_6293
0085: 81@ = 93@ 
81@ *= 84 
005A: 81@ += 47@ 
92@ = 3 
jump @TRUCK_6365 

:TRUCK_6330
gosub @TRUCK_6367 
92@ = 4 
jump @TRUCK_6365 

:TRUCK_6351
92@ = 5 
jump @TRUCK_6365 

:TRUCK_6365
return 

:TRUCK_6367
50@ = 2 
50@ *= 60 
50@ += 0 
50@ *= 1000 
0085: 81@ = 47@ 
005A: 81@ += 50@ 
00BF: 50@ = current_time_hours, 51@ = current_time_minutes 
51@ += 0 
if 
  51@ >= 60 
else_jump @TRUCK_6459 
51@ -= 60 
50@ += 1 

:TRUCK_6459
50@ += 2 
if 
  50@ >= 24 
else_jump @TRUCK_6491 
50@ -= 24 

:TRUCK_6491
0085: 52@ = 50@ 
52@ *= 60 
005A: 52@ += 51@ 
52@ *= 1000 
008A: " + _8162 + @" = 52@ 
03C3: set_timer_to " + _8162 + @" type 0 GXT 'TRK_DLN' 
0396: pause_timer 1 
112@ = 1 
return 

:TRUCK_6559
0085: 50@ = 93@ 
50@ *= 140 
50@ /= 1000 
0085: 51@ = 50@ 
51@ /= 60 
0085: 52@ = 51@ 
52@ *= 60 
0062: 50@ -= 52@ 
00BF: 94@ = current_time_hours, 95@ = current_time_minutes 
005A: 95@ += 50@ 
if 
  95@ >= 60 
else_jump @TRUCK_6669 
94@ += 1 
95@ -= 60 

:TRUCK_6669
005A: 94@ += 51@ 

:TRUCK_6677
if 
  94@ >= 24 
else_jump @TRUCK_6709 
94@ -= 24 
jump @TRUCK_6677 

:TRUCK_6709
72@ = 0 
if 
  95@ > 45 
else_jump @TRUCK_6811 
50@ = 60 
0062: 50@ -= 95@ 
95@ = 0 
94@ += 1 
if 
  94@ == 24 
else_jump @TRUCK_6788 
94@ = 0 

:TRUCK_6788
50@ *= 1000 
005A: 81@ += 50@ 
72@ = 1 

:TRUCK_6811
if 
  72@ == 0 
else_jump @TRUCK_6899 
if and
  95@ > 30 
  45 > 95@ 
else_jump @TRUCK_6899 
50@ = 45 
0062: 50@ -= 95@ 
95@ = 45 
50@ *= 1000 
005A: 81@ += 50@ 
72@ = 1 

:TRUCK_6899
if 
  72@ == 0 
else_jump @TRUCK_6987 
if and
  95@ > 15 
  30 > 95@ 
else_jump @TRUCK_6987 
50@ = 30 
0062: 50@ -= 95@ 
95@ = 30 
50@ *= 1000 
005A: 81@ += 50@ 
72@ = 1 

:TRUCK_6987
if 
  72@ == 0 
else_jump @TRUCK_7075 
if and
  95@ > 0 
  15 > 95@ 
else_jump @TRUCK_7075 
50@ = 15 
0062: 50@ -= 95@ 
95@ = 15 
50@ *= 1000 
005A: 81@ += 50@ 
72@ = 1 

:TRUCK_7075
0085: 50@ = 94@ 
50@ *= 60 
005A: 50@ += 95@ 
50@ *= 1000 
008A: " + _8162 + @" = 50@ 
return 

:TRUCK_7116
50@ = Car.Health(75@)
51@ = Car.Health(74@)
if 
001D:   50@ > 51@ 
else_jump @TRUCK_7159 
0085: 50@ = 51@ 

:TRUCK_7159
if 
  50@ > 1 
else_jump @TRUCK_7193 
Car.Health(74@) = 50@
Car.Health(75@) = 50@

:TRUCK_7193
if 
  108@ == 0 
else_jump @TRUCK_7213 
return 

:TRUCK_7213
50@ -= 250 
50@ *= 100 
0072: 50@ /= 90@ 
if 
  0 > 50@ 
else_jump @TRUCK_7261 
50@ = 0 

:TRUCK_7261
008A: " + _8161 + @" = 50@ 
return 

:TRUCK_7271
if 
001D:   47@ > 81@ 
else_jump @TRUCK_7498 
gosub @TRUCK_6155 
if 
  92@ == 5 
else_jump @TRUCK_7345 
39@ = 1 
81@ = 0 
83@ = 0 
89@ = 2 
return 

:TRUCK_7345
if 
  107@ == 1 
else_jump @TRUCK_7498 
if or
  92@ == 2 
  92@ == 3 
  92@ == 4 
else_jump @TRUCK_7498 
91@ /= 2 
0151: remove_status_text " + _8160 + @" 
04F7: status_text " + _8160 + @" type 0 line 1 GXT 'TRK_CSH' 
if 
  92@ == 2 
else_jump @TRUCK_7448 
014F: stop_timer " + _8162 + @" 

:TRUCK_7448
if 
  92@ == 2 
else_jump @TRUCK_7473 
110@ = 1 

:TRUCK_7473
if 
  92@ == 3 
else_jump @TRUCK_7498 
111@ = 1 

:TRUCK_7498
return 

:TRUCK_7500
0085: 83@ = 91@ 
if 
  108@ == 1 
else_jump @TRUCK_7643 
if 
   Car.Wrecked(74@)
else_jump @TRUCK_7556 
83@ = 0 
jump @TRUCK_7643 

:TRUCK_7556
50@ = Car.Health(74@)
if 
  250 > 50@ 
else_jump @TRUCK_7597 
83@ = 0 
jump @TRUCK_7643 

:TRUCK_7597
50@ -= 250 
0085: 51@ = 50@ 
51@ *= 100 
0072: 51@ /= 90@ 
006A: 83@ *= 51@ 
83@ /= 100 

:TRUCK_7643
if 
  109@ == 1 
else_jump @TRUCK_7684 
if 
   Car.Wrecked(74@)
else_jump @TRUCK_7684 
83@ = 0 

:TRUCK_7684
008A: " + _8160 + @" = 83@ 
return 

:TRUCK_7694
if 
  109@ == 0 
else_jump @TRUCK_7714 
return 

:TRUCK_7714
if 
  88@ == 4 
else_jump @TRUCK_7759 
if 
   not Player.WantedLevel(" + PlayerChar + @") > 2
else_jump @TRUCK_7757 
Player.SetMinWantedLevel(" + PlayerChar + @", 3)

:TRUCK_7757
return 

:TRUCK_7759
if 
  88@ == 6 
else_jump @TRUCK_7804 
if 
   not Player.WantedLevel(" + PlayerChar + @") > 3
else_jump @TRUCK_7802 
Player.SetMinWantedLevel(" + PlayerChar + @", 4)

:TRUCK_7802
return 

:TRUCK_7804
return 

:TRUCK_7806
86@ = -1 
87@ = -1 
88@ = 0 
gosub @TRUCK_7871 
gosub @TRUCK_8323 
gosub @TRUCK_9841 
gosub @TRUCK_8986 
gosub @TRUCK_9326 
gosub @TRUCK_9431 
return 

:TRUCK_7871
59@ = -76.1692 
60@ = -1128.963 
61@ = 0.0781 
62@ = 69.9957 
0395: clear_area 0 at 59@ 60@ 61@ radius 30.0 
0871: init_jump_table 97@ total_jumps 3 default_jump 1 @TRUCK_8064 jumps 1 @TRUCK_7992 2 @TRUCK_8016 3 @TRUCK_8040 -1 @TRUCK_8079 -1 @TRUCK_8079 -1 @TRUCK_8079 -1 @TRUCK_8079 

:TRUCK_7992
74@ = Car.Create(#PETRO, 59@, 60@, 61@)
jump @TRUCK_8079 

:TRUCK_8016
74@ = Car.Create(#LINERUN, 59@, 60@, 61@)
jump @TRUCK_8079 

:TRUCK_8040
74@ = Car.Create(#RDTRAIN, 59@, 60@, 61@)
jump @TRUCK_8079 

:TRUCK_8064
0662: printstring ""UNKNOWN_CAB"" 

:TRUCK_8079
Car.Angle(74@) = 62@
59@ = -60.6033 
60@ = -1136.899 
61@ = 0.0781 
0395: clear_area 0 at 59@ 60@ 61@ radius 50.0 
0871: init_jump_table 96@ total_jumps 4 default_jump 1 @TRUCK_8294 jumps 1 @TRUCK_8198 2 @TRUCK_8222 3 @TRUCK_8246 4 @TRUCK_8270 -1 @TRUCK_8313 -1 @TRUCK_8313 -1 @TRUCK_8313 

:TRUCK_8198
75@ = Car.Create(#PETROTR, 59@, 60@, 61@)
jump @TRUCK_8313 

:TRUCK_8222
75@ = Car.Create(#ARTICT1, 59@, 60@, 61@)
jump @TRUCK_8313 

:TRUCK_8246
75@ = Car.Create(#ARTICT2, 59@, 60@, 61@)
jump @TRUCK_8313 

:TRUCK_8270
75@ = Car.Create(#ARTICT3, 59@, 60@, 61@)
jump @TRUCK_8313 

:TRUCK_8294
0662: printstring ""UNKNOWN_TRAILER"" 

:TRUCK_8313
0893: put_trailer 75@ on_cab 74@ 
return 

:TRUCK_8323
0871: init_jump_table " + Trucking_Total_Passed_Missions + @" total_jumps 8 default_jump 1 @TRUCK_8597 jumps 0 @TRUCK_8451 1 @TRUCK_8465 2 @TRUCK_8479 3 @TRUCK_8493 4 @TRUCK_8507 5 @TRUCK_8521 6 @TRUCK_8552 
0872: jump_table_jumps 7 @TRUCK_8583 -1 @TRUCK_8628 -1 @TRUCK_8628 -1 @TRUCK_8628 -1 @TRUCK_8628 -1 @TRUCK_8628 -1 @TRUCK_8628 -1 @TRUCK_8628 -1 @TRUCK_8628 

:TRUCK_8451
86@ = 1 
jump @TRUCK_8628 

:TRUCK_8465
86@ = 2 
jump @TRUCK_8628 

:TRUCK_8479
86@ = 3 
jump @TRUCK_8628 

:TRUCK_8493
86@ = 4 
jump @TRUCK_8628 

:TRUCK_8507
86@ = 5 
jump @TRUCK_8628 

:TRUCK_8521
51@ = 5 
51@ += 1 
0209: 86@ = random_int_in_ranges 4 51@ 
jump @TRUCK_8628 

:TRUCK_8552
51@ = 7 
51@ += 1 
0209: 86@ = random_int_in_ranges 6 51@ 
jump @TRUCK_8628 

:TRUCK_8583
86@ = 8 
jump @TRUCK_8628 

:TRUCK_8597
51@ = 8 
51@ += 1 
0209: 86@ = random_int_in_ranges 2 51@ 
jump @TRUCK_8628 

:TRUCK_8628
0871: init_jump_table 86@ total_jumps 8 default_jump 1 @TRUCK_8868 jumps 1 @TRUCK_8756 2 @TRUCK_8770 3 @TRUCK_8784 4 @TRUCK_8826 5 @TRUCK_8840 6 @TRUCK_8854 7 @TRUCK_8812 
0872: jump_table_jumps 8 @TRUCK_8798 -1 @TRUCK_8896 -1 @TRUCK_8896 -1 @TRUCK_8896 -1 @TRUCK_8896 -1 @TRUCK_8896 -1 @TRUCK_8896 -1 @TRUCK_8896 -1 @TRUCK_8896 

:TRUCK_8756
gosub @TRUCK_8898 
jump @TRUCK_8896 

:TRUCK_8770
gosub @TRUCK_8909 
jump @TRUCK_8896 

:TRUCK_8784
gosub @TRUCK_8931 
jump @TRUCK_8896 

:TRUCK_8798
gosub @TRUCK_8920 
jump @TRUCK_8896 

:TRUCK_8812
gosub @TRUCK_8975 
jump @TRUCK_8896 

:TRUCK_8826
gosub @TRUCK_8953 
jump @TRUCK_8896 

:TRUCK_8840
gosub @TRUCK_8942 
jump @TRUCK_8896 

:TRUCK_8854
gosub @TRUCK_8964 
jump @TRUCK_8896 

:TRUCK_8868
0662: printstring ""UNKNOWN_DESTINATION_AREA"" 

:TRUCK_8896
return 

:TRUCK_8898
0209: 87@ = random_int_in_ranges 0 4 
return 

:TRUCK_8909
0209: 87@ = random_int_in_ranges 0 2 
return 

:TRUCK_8920
0209: 87@ = random_int_in_ranges 0 14 
return 

:TRUCK_8931
0209: 87@ = random_int_in_ranges 0 4 
return 

:TRUCK_8942
0209: 87@ = random_int_in_ranges 0 4 
return 

:TRUCK_8953
0209: 87@ = random_int_in_ranges 0 3 
return 

:TRUCK_8964
0209: 87@ = random_int_in_ranges 0 3 
return 

:TRUCK_8975
0209: 87@ = random_int_in_ranges 0 5 
return 

:TRUCK_8986
0871: init_jump_table " + Trucking_Total_Passed_Missions + @" total_jumps 8 default_jump 1 @TRUCK_9198 jumps 0 @TRUCK_9114 1 @TRUCK_9128 2 @TRUCK_9156 3 @TRUCK_9114 4 @TRUCK_9142 5 @TRUCK_9156 6 @TRUCK_9170 
0872: jump_table_jumps 7 @TRUCK_9184 -1 @TRUCK_9221 -1 @TRUCK_9221 -1 @TRUCK_9221 -1 @TRUCK_9221 -1 @TRUCK_9221 -1 @TRUCK_9221 -1 @TRUCK_9221 -1 @TRUCK_9221 

:TRUCK_9114
88@ = 2 
jump @TRUCK_9221 

:TRUCK_9128
88@ = 1 
jump @TRUCK_9221 

:TRUCK_9142
88@ = 3 
jump @TRUCK_9221 

:TRUCK_9156
88@ = 4 
jump @TRUCK_9221 

:TRUCK_9170
88@ = 5 
jump @TRUCK_9221 

:TRUCK_9184
88@ = 6 
jump @TRUCK_9221 

:TRUCK_9198
0209: 88@ = random_int_in_ranges 0 6 
88@ += 1 
jump @TRUCK_9221 

:TRUCK_9221
if or
  88@ == 1 
  88@ == 3 
  88@ == 5 
else_jump @TRUCK_9260 
108@ = 1 

:TRUCK_9260
if or
  88@ == 2 
  88@ == 5 
else_jump @TRUCK_9292 
107@ = 1 

:TRUCK_9292
if or
  88@ == 4 
  88@ == 6 
else_jump @TRUCK_9324 
109@ = 1 

:TRUCK_9324
return 

:TRUCK_9326
0087: 63@ = 102@ 
0065: 63@ -= " + _2373 + @" 
0087: 64@ = 103@ 
0065: 64@ -= " + _2374 + @" 
0087: 66@ = 63@ 
006B: 66@ *= 63@ 
0087: 67@ = 64@ 
006B: 67@ *= 64@ 
0087: 69@ = 66@ 
005B: 69@ += 67@ 
01FB: 70@ = square_root 69@ 
0092: 93@ = float 70@ to_integer 
49@ += 1 
return 

:TRUCK_9431
0871: init_jump_table 86@ total_jumps 8 default_jump 1 @TRUCK_9604 jumps 1 @TRUCK_9559 2 @TRUCK_9559 3 @TRUCK_9559 4 @TRUCK_9574 5 @TRUCK_9574 6 @TRUCK_9589 7 @TRUCK_9589 
0872: jump_table_jumps 8 @TRUCK_9589 -1 @TRUCK_9643 -1 @TRUCK_9643 -1 @TRUCK_9643 -1 @TRUCK_9643 -1 @TRUCK_9643 -1 @TRUCK_9643 -1 @TRUCK_9643 -1 @TRUCK_9643 

:TRUCK_9559
91@ = 1000 
jump @TRUCK_9643 

:TRUCK_9574
91@ = 3000 
jump @TRUCK_9643 

:TRUCK_9589
91@ = 4000 
jump @TRUCK_9643 

:TRUCK_9604
0662: printstring ""INITIALISE_CASH_UNKNOWN_DESTINATION"" 

:TRUCK_9643
0871: init_jump_table 88@ total_jumps 6 default_jump 1 @TRUCK_9773 jumps 1 @TRUCK_9713 2 @TRUCK_9706 3 @TRUCK_9728 4 @TRUCK_9728 5 @TRUCK_9743 6 @TRUCK_9758 -1 @TRUCK_9813 

:TRUCK_9706
jump @TRUCK_9813 

:TRUCK_9713
91@ += 500 
jump @TRUCK_9813 

:TRUCK_9728
91@ += 1000 
jump @TRUCK_9813 

:TRUCK_9743
91@ += 3000 
jump @TRUCK_9813 

:TRUCK_9758
91@ += 6000 
jump @TRUCK_9813 

:TRUCK_9773
0662: printstring ""INITIALISE_CASH_UNKNOWN_MISSION_TYPE"" 

:TRUCK_9813
if 
  " + Trucking_Total_Passed_Missions + @" == 5 
else_jump @TRUCK_9839 
91@ += 1000 

:TRUCK_9839
return 

:TRUCK_9841
0871: init_jump_table 86@ total_jumps 8 default_jump 1 @TRUCK_10081 jumps 1 @TRUCK_9969 2 @TRUCK_9983 3 @TRUCK_9997 4 @TRUCK_10039 5 @TRUCK_10053 6 @TRUCK_10067 7 @TRUCK_10025 
0872: jump_table_jumps 8 @TRUCK_10011 -1 @TRUCK_10109 -1 @TRUCK_10109 -1 @TRUCK_10109 -1 @TRUCK_10109 -1 @TRUCK_10109 -1 @TRUCK_10109 -1 @TRUCK_10109 -1 @TRUCK_10109 

:TRUCK_9969
gosub @TRUCK_10111 
jump @TRUCK_10109 

:TRUCK_9983
gosub @TRUCK_10360 
jump @TRUCK_10109 

:TRUCK_9997
gosub @TRUCK_11214 
jump @TRUCK_10109 

:TRUCK_10011
gosub @TRUCK_10534 
jump @TRUCK_10109 

:TRUCK_10025
gosub @TRUCK_11875 
jump @TRUCK_10109 

:TRUCK_10039
gosub @TRUCK_11457 
jump @TRUCK_10109 

:TRUCK_10053
gosub @TRUCK_12159 
jump @TRUCK_10109 

:TRUCK_10067
gosub @TRUCK_11666 
jump @TRUCK_10109 

:TRUCK_10081
0662: printstring ""UNKNOWN_DESTINATION_AREA"" 

:TRUCK_10109
return 

:TRUCK_10111
0871: init_jump_table 87@ total_jumps 4 default_jump 1 @TRUCK_10322 jumps 0 @TRUCK_10174 1 @TRUCK_10211 2 @TRUCK_10248 3 @TRUCK_10285 -1 @TRUCK_10358 -1 @TRUCK_10358 -1 @TRUCK_10358 

:TRUCK_10174
102@ = -187.4041 
103@ = -277.0196 
104@ = 0.4219 
jump @TRUCK_10358 

:TRUCK_10211
102@ = 58.0364 
103@ = -256.7285 
104@ = 0.5781 
jump @TRUCK_10358 

:TRUCK_10248
102@ = 95.8675 
103@ = -154.3627 
104@ = 1.5751 
jump @TRUCK_10358 

:TRUCK_10285
102@ = 809.7556 
103@ = -598.0007 
104@ = 15.1875 
jump @TRUCK_10358 

:TRUCK_10322
0662: printstring ""UNKNOWN_COUNTRYEASTNEAR_LOCATION"" 

:TRUCK_10358
return 

:TRUCK_10360
0871: init_jump_table 87@ total_jumps 2 default_jump 1 @TRUCK_10497 jumps 0 @TRUCK_10423 1 @TRUCK_10460 -1 @TRUCK_10532 -1 @TRUCK_10532 -1 @TRUCK_10532 -1 @TRUCK_10532 -1 @TRUCK_10532 

:TRUCK_10423
102@ = 1403.833 
103@ = 399.4294 
104@ = 18.75 
jump @TRUCK_10532 

:TRUCK_10460
102@ = 1338.289 
103@ = 348.9004 
104@ = 18.4062 
jump @TRUCK_10532 

:TRUCK_10497
0662: printstring ""UNKNOWN_COUNTRYEASTFAR_LOCATION"" 

:TRUCK_10532
return 

:TRUCK_10534
0871: init_jump_table 87@ total_jumps 14 default_jump 1 @TRUCK_11180 jumps 0 @TRUCK_10662 1 @TRUCK_10699 2 @TRUCK_10736 3 @TRUCK_10773 4 @TRUCK_10810 5 @TRUCK_10847 6 @TRUCK_10884 
0872: jump_table_jumps 7 @TRUCK_10921 8 @TRUCK_10958 9 @TRUCK_10995 10 @TRUCK_11032 11 @TRUCK_11069 12 @TRUCK_11106 13 @TRUCK_11143 -1 @TRUCK_11212 -1 @TRUCK_11212 

:TRUCK_10662
102@ = 1449.715 
103@ = 2358.852 
104@ = 9.8203 
jump @TRUCK_11212 

:TRUCK_10699
102@ = 1037.475 
103@ = 2131.344 
104@ = 9.8203 
jump @TRUCK_11212 

:TRUCK_10736
102@ = 987.9741 
103@ = 2080.389 
104@ = 9.8203 
jump @TRUCK_11212 

:TRUCK_10773
102@ = 1288.671 
103@ = 1195.232 
104@ = 9.8656 
jump @TRUCK_11212 

:TRUCK_10810
102@ = 2467.902 
103@ = 1950.061 
104@ = 9.2381 
jump @TRUCK_11212 

:TRUCK_10847
102@ = 2792.744 
103@ = 2578.336 
104@ = 9.8203 
jump @TRUCK_11212 

:TRUCK_10884
102@ = 2271.477 
103@ = 2791.739 
104@ = 9.8203 
jump @TRUCK_11212 

:TRUCK_10921
102@ = 2596.519 
103@ = 1738.582 
104@ = 9.8281 
jump @TRUCK_11212 

:TRUCK_10958
102@ = 2818.84 
103@ = 912.5091 
104@ = 9.75 
jump @TRUCK_11212 

:TRUCK_10995
102@ = 2706.505 
103@ = 827.3236 
104@ = 9.2145 
jump @TRUCK_11212 

:TRUCK_11032
102@ = 1627.723 
103@ = 688.4043 
104@ = 9.8281 
jump @TRUCK_11212 

:TRUCK_11069
102@ = 1504.492 
103@ = 981.141 
104@ = 9.7187 
jump @TRUCK_11212 

:TRUCK_11106
102@ = 1724.012 
103@ = 1590.128 
104@ = 9.2578 
jump @TRUCK_11212 

:TRUCK_11143
102@ = 1727.833 
103@ = 2338.017 
104@ = 9.813 
jump @TRUCK_11212 

:TRUCK_11180
0662: printstring ""UNKNOWN_LASVENTURAS_LOCATION"" 

:TRUCK_11212
return 

:TRUCK_11214
0871: init_jump_table 87@ total_jumps 4 default_jump 1 @TRUCK_11425 jumps 0 @TRUCK_11277 1 @TRUCK_11314 2 @TRUCK_11351 3 @TRUCK_11388 -1 @TRUCK_11455 -1 @TRUCK_11455 -1 @TRUCK_11455 

:TRUCK_11277
102@ = 2413.683 
103@ = -2113.674 
104@ = 12.3881 
jump @TRUCK_11455 

:TRUCK_11314
102@ = 2784.973 
103@ = -2455.441 
104@ = 12.625 
jump @TRUCK_11455 

:TRUCK_11351
102@ = 2112.662 
103@ = -2070.376 
104@ = 12.5547 
jump @TRUCK_11455 

:TRUCK_11388
102@ = 1763.641 
103@ = -2070.371 
104@ = 12.6195 
jump @TRUCK_11455 

:TRUCK_11425
0662: printstring ""UNKNOWN_LOSSANTOS_LOCATION"" 

:TRUCK_11455
return 

:TRUCK_11457
0871: init_jump_table 87@ total_jumps 3 default_jump 1 @TRUCK_11631 jumps 0 @TRUCK_11520 1 @TRUCK_11557 2 @TRUCK_11594 -1 @TRUCK_11664 -1 @TRUCK_11664 -1 @TRUCK_11664 -1 @TRUCK_11664 

:TRUCK_11520
102@ = -1888.621 
103@ = -1711.836 
104@ = 20.7656 
jump @TRUCK_11664 

:TRUCK_11557
102@ = -2117.227 
103@ = -2380.507 
104@ = 29.4688 
jump @TRUCK_11664 

:TRUCK_11594
102@ = -1545.439 
103@ = -2747.032 
104@ = 47.5314 
jump @TRUCK_11664 

:TRUCK_11631
0662: printstring ""UNKNOWN_COUNTRYSOUTH_LOCATION"" 

:TRUCK_11664
return 

:TRUCK_11666
0871: init_jump_table 87@ total_jumps 3 default_jump 1 @TRUCK_11840 jumps 0 @TRUCK_11729 1 @TRUCK_11766 2 @TRUCK_11803 -1 @TRUCK_11873 -1 @TRUCK_11873 -1 @TRUCK_11873 -1 @TRUCK_11873 

:TRUCK_11729
102@ = -1407.375 
103@ = 2645.957 
104@ = 54.7031 
jump @TRUCK_11873 

:TRUCK_11766
102@ = -2245.581 
103@ = 2371.693 
104@ = 3.9919 
jump @TRUCK_11873 

:TRUCK_11803
102@ = -1360.633 
103@ = 2068.094 
104@ = 51.4589 
jump @TRUCK_11873 

:TRUCK_11840
0662: printstring ""UNKNOWN_COUNTRYNORTH_LOCATION"" 

:TRUCK_11873
return 

:TRUCK_11875
0871: init_jump_table 87@ total_jumps 5 default_jump 1 @TRUCK_12123 jumps 0 @TRUCK_11938 1 @TRUCK_11975 2 @TRUCK_12012 3 @TRUCK_12049 4 @TRUCK_12086 -1 @TRUCK_12157 -1 @TRUCK_12157 

:TRUCK_11938
102@ = 274.2705 
103@ = 1382.781 
104@ = 9.6016 
jump @TRUCK_12157 

:TRUCK_11975
102@ = 628.8638 
103@ = 1714.891 
104@ = 5.9922 
jump @TRUCK_12157 

:TRUCK_12012
102@ = 635.0028 
103@ = 1213.777 
104@ = 10.7188 
jump @TRUCK_12157 

:TRUCK_12049
102@ = -914.953 
103@ = 2012.138 
104@ = 59.9283 
jump @TRUCK_12157 

:TRUCK_12086
102@ = 385.8214 
103@ = 2595.55 
104@ = 15.4843 
jump @TRUCK_12157 

:TRUCK_12123
0662: printstring ""UNKNOWN_COUNTRYNORTH2_LOCATION"" 

:TRUCK_12157
return 

:TRUCK_12159
0871: init_jump_table 87@ total_jumps 4 default_jump 1 @TRUCK_12370 jumps 0 @TRUCK_12222 1 @TRUCK_12259 2 @TRUCK_12296 3 @TRUCK_12333 -1 @TRUCK_12401 -1 @TRUCK_12401 -1 @TRUCK_12401 

:TRUCK_12222
102@ = -1556.977 
103@ = -441.3493 
104@ = 5.0 
jump @TRUCK_12401 

:TRUCK_12259
102@ = -2659.631 
103@ = 1380.642 
104@ = 6.1643 
jump @TRUCK_12401 

:TRUCK_12296
102@ = -1650.928 
103@ = 437.5679 
104@ = 6.1797 
jump @TRUCK_12401 

:TRUCK_12333
102@ = -1745.116 
103@ = 37.8752 
104@ = 2.5408 
jump @TRUCK_12401 

:TRUCK_12370
0662: printstring ""UNKNOWN_SAN_FIERRO_LOCATION"" 

:TRUCK_12401
return 

:TRUCK_12403
if 
0736:   is_keyboard_key_just_pressed 32 
else_jump @TRUCK_12452 
48@ += 1 
if 
  48@ > 2 
else_jump @TRUCK_12450 
48@ = 0 

:TRUCK_12450
086A: NOP 

:TRUCK_12452
if 
  48@ == 1 
else_jump @TRUCK_12646 
008A: " + _8163 + @" = 36@ 
008A: " + _8164 + @" = 37@ 
008A: " + _8165 + @" = 47@ 
008A: " + _8166 + @" = 81@ 
0066: " + _8166 + @" -= 47@ 
008A: " + _8167 + @" = 92@ 
008A: " + _8168 + @" = 93@ 
" + _8169 + @" = 0 
" + _8170 + @" = 0 
065D: NOP " + _8163 + @" ""M_STAGE"" 
065D: NOP " + _8164 + @" ""M_GOALS"" 
065D: NOP " + _8165 + @" ""M_MISSION_TIMER"" 
065D: NOP " + _8166 + @" ""TIME_BOUNDARY_HIT"" 
065D: NOP " + _8167 + @" ""TIME_STAGE"" 
065D: NOP " + _8168 + @" ""DISTANCE"" 

:TRUCK_12646
if 
  48@ == 2 
else_jump @TRUCK_12664 

:TRUCK_12664
if 
0736:   is_keyboard_key_just_pressed 98 
else_jump @TRUCK_12686 
40@ = 1 

:TRUCK_12686
if 
0736:   is_keyboard_key_just_pressed 80 
else_jump @TRUCK_12774 
if 
  41@ == 0 
else_jump @TRUCK_12749 
41@ = 1 
0662: printstring ""LEVEL_PAUSED"" 
jump @TRUCK_12774 

:TRUCK_12749
41@ = 0 
0662: printstring ""LEVEL_UNPAUSED"" 

:TRUCK_12774
return 

:TRUCK_12776
if or
  36@ == 50 
  36@ == 51 
else_jump @TRUCK_12803 
return 

:TRUCK_12803
if 
0736:   is_keyboard_key_just_pressed 83 
else_jump @TRUCK_12834 
gosub @TRUCK_16540 
38@ = 1 
return 

:TRUCK_12834
if 
0736:   is_keyboard_key_just_pressed 77 
else_jump @TRUCK_12880 
" + Trucking_Total_Passed_Missions + @" += 1 
0663: printint ""MISSIONS_PASSED"" " + Trucking_Total_Passed_Missions + @" 
return 

:TRUCK_12880
72@ = 0 
if 
0736:   is_keyboard_key_just_pressed 65 
else_jump @TRUCK_12909 
72@ = 1 

:TRUCK_12909
73@ = 0 
if 
0736:   is_keyboard_key_just_pressed 68 
else_jump @TRUCK_12938 
73@ = 1 

:TRUCK_12938
50@ = 0 
if 
0736:   is_keyboard_key_just_pressed 74 
else_jump @TRUCK_12967 
50@ = 1 

:TRUCK_12967
if and
   not 72@ == 1 
   not 73@ == 1 
   not 50@ == 1 
else_jump @TRUCK_13001 
return 

:TRUCK_13001
if 
  72@ == 1 
else_jump @TRUCK_13071 
34@ += 1 
if 
  34@ == 6 
else_jump @TRUCK_13051 
34@ = 0 

:TRUCK_13051
35@ = 0 
0663: printint ""AREA"" 34@ 
return 

:TRUCK_13071
if 
  73@ == 1 
else_jump @TRUCK_13116 
35@ += 1 
0663: printint ""DESTINATION"" 35@ 
return 

:TRUCK_13116
if 
  34@ == 0 
else_jump @TRUCK_13426 
0871: init_jump_table 35@ total_jumps 6 default_jump 1 @TRUCK_13382 jumps 0 @TRUCK_13382 1 @TRUCK_13197 2 @TRUCK_13234 3 @TRUCK_13271 4 @TRUCK_13308 5 @TRUCK_13345 -1 @TRUCK_13426 

:TRUCK_13197
102@ = 56.744 
103@ = -268.404 
104@ = 0.579 
jump @TRUCK_13426 

:TRUCK_13234
102@ = 100.397 
103@ = -155.05 
104@ = 1.583 
jump @TRUCK_13426 

:TRUCK_13271
102@ = 815.046 
103@ = -605.128 
104@ = 15.336 
jump @TRUCK_13426 

:TRUCK_13308
102@ = 1401.109 
103@ = 398.763 
104@ = 18.756 
jump @TRUCK_13426 

:TRUCK_13345
102@ = 1343.125 
103@ = 345.667 
104@ = 18.556 
jump @TRUCK_13426 

:TRUCK_13382
102@ = -189.23 
103@ = -273.013 
104@ = 0.429 
35@ = 0 
jump @TRUCK_13426 

:TRUCK_13426
if 
  34@ == 2 
else_jump @TRUCK_14097 
0871: init_jump_table 35@ total_jumps 14 default_jump 1 @TRUCK_14053 jumps 0 @TRUCK_14053 1 @TRUCK_13572 2 @TRUCK_13609 3 @TRUCK_13646 4 @TRUCK_13683 5 @TRUCK_13720 6 @TRUCK_13757 
0872: jump_table_jumps 7 @TRUCK_13794 8 @TRUCK_13831 9 @TRUCK_13868 10 @TRUCK_13905 11 @TRUCK_13942 12 @TRUCK_13979 13 @TRUCK_14016 -1 @TRUCK_14097 -1 @TRUCK_14097 

:TRUCK_13572
102@ = 1042.15 
103@ = 2130.46 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13609
102@ = 983.11 
103@ = 2076.38 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13646
102@ = 1288.671 
103@ = 1195.232 
104@ = 9.8656 
jump @TRUCK_14097 

:TRUCK_13683
102@ = 2469.57 
103@ = 1949.52 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13720
102@ = 2807.83 
103@ = 2609.94 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13757
102@ = 2248.71 
103@ = 2775.12 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13794
102@ = 2603.22 
103@ = 1730.48 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13831
102@ = 2818.84 
103@ = 912.19 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13868
102@ = 2710.36 
103@ = 850.12 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13905
102@ = 1588.9 
103@ = 715.31 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13942
102@ = 1446.26 
103@ = 1000.51 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_13979
102@ = 1724.012 
103@ = 1590.128 
104@ = 9.2578 
jump @TRUCK_14097 

:TRUCK_14016
102@ = 1713.79 
103@ = 2329.05 
104@ = 101.0 
jump @TRUCK_14097 

:TRUCK_14053
102@ = 1450.8 
103@ = 2360.69 
104@ = 101.0 
35@ = 0 
jump @TRUCK_14097 

:TRUCK_14097
if 
  34@ == 1 
else_jump @TRUCK_14333 
0871: init_jump_table 35@ total_jumps 4 default_jump 1 @TRUCK_14289 jumps 0 @TRUCK_14289 1 @TRUCK_14178 2 @TRUCK_14215 3 @TRUCK_14252 -1 @TRUCK_14333 -1 @TRUCK_14333 -1 @TRUCK_14333 

:TRUCK_14178
102@ = 2759.0 
103@ = -2446.0 
104@ = 101.0 
jump @TRUCK_14333 

:TRUCK_14215
102@ = 2104.0 
103@ = -2089.0 
104@ = 101.0 
jump @TRUCK_14333 

:TRUCK_14252
102@ = 1751.0 
103@ = -2067.0 
104@ = 101.0 
jump @TRUCK_14333 

:TRUCK_14289
102@ = 2412.0 
103@ = -2106.0 
104@ = 101.0 
35@ = 0 
jump @TRUCK_14333 

:TRUCK_14333
if 
  34@ == 4 
else_jump @TRUCK_14532 
0871: init_jump_table 35@ total_jumps 3 default_jump 1 @TRUCK_14488 jumps 0 @TRUCK_14488 1 @TRUCK_14414 2 @TRUCK_14451 -1 @TRUCK_14532 -1 @TRUCK_14532 -1 @TRUCK_14532 -1 @TRUCK_14532 

:TRUCK_14414
102@ = -2001.03 
103@ = -2388.08 
104@ = 101.0 
jump @TRUCK_14532 

:TRUCK_14451
102@ = -1560.67 
103@ = -2728.39 
104@ = 101.0 
jump @TRUCK_14532 

:TRUCK_14488
102@ = -1835.0 
103@ = -1647.68 
104@ = 101.0 
35@ = 0 
jump @TRUCK_14532 

:TRUCK_14532
if 
  34@ == 6 
else_jump @TRUCK_14731 
0871: init_jump_table 35@ total_jumps 3 default_jump 1 @TRUCK_14687 jumps 0 @TRUCK_14687 1 @TRUCK_14613 2 @TRUCK_14650 -1 @TRUCK_14731 -1 @TRUCK_14731 -1 @TRUCK_14731 -1 @TRUCK_14731 

:TRUCK_14613
102@ = -1945.89 
103@ = 2377.9 
104@ = 101.0 
jump @TRUCK_14731 

:TRUCK_14650
102@ = -1471.49 
103@ = 1864.85 
104@ = 101.0 
jump @TRUCK_14731 

:TRUCK_14687
102@ = -1286.73 
103@ = 2695.92 
104@ = 101.0 
35@ = 0 
jump @TRUCK_14731 

:TRUCK_14731
if 
  34@ == 3 
else_jump @TRUCK_15004 
0871: init_jump_table 35@ total_jumps 5 default_jump 1 @TRUCK_14960 jumps 0 @TRUCK_14960 1 @TRUCK_14812 2 @TRUCK_14849 3 @TRUCK_14886 4 @TRUCK_14923 -1 @TRUCK_15004 -1 @TRUCK_15004 

:TRUCK_14812
102@ = 613.75 
103@ = 1692.39 
104@ = 101.0 
jump @TRUCK_15004 

:TRUCK_14849
102@ = 620.35 
103@ = 1249.328 
104@ = 101.0 
jump @TRUCK_15004 

:TRUCK_14886
102@ = -533.24 
103@ = 1995.917 
104@ = 101.0 
jump @TRUCK_15004 

:TRUCK_14923
102@ = 325.05 
103@ = 2543.29 
104@ = 101.0 
jump @TRUCK_15004 

:TRUCK_14960
102@ = 246.56 
103@ = 1435.19 
104@ = 101.0 
35@ = 0 
jump @TRUCK_15004 

:TRUCK_15004
if 
  34@ == 5 
else_jump @TRUCK_15240 
0871: init_jump_table 35@ total_jumps 4 default_jump 1 @TRUCK_15196 jumps 0 @TRUCK_15196 1 @TRUCK_15085 2 @TRUCK_15122 3 @TRUCK_15159 -1 @TRUCK_15240 -1 @TRUCK_15240 -1 @TRUCK_15240 

:TRUCK_15085
102@ = -2629.091 
103@ = 1387.42 
104@ = 101.0 
jump @TRUCK_15240 

:TRUCK_15122
102@ = -1530.776 
103@ = 487.201 
104@ = 101.0 
jump @TRUCK_15240 

:TRUCK_15159
102@ = -1745.08 
103@ = 27.759 
104@ = 101.0 
jump @TRUCK_15240 

:TRUCK_15196
102@ = -1549.859 
103@ = -434.86 
104@ = 101.0068 
35@ = 0 
jump @TRUCK_15240 

:TRUCK_15240
0395: clear_area 0 at 102@ 103@ 104@ radius 0.5 
Actor.Angle(" + PlayerActor + @") = 0.0
Actor.PutAt(" + PlayerActor + @", 102@, 103@, -101.0)
Camera.SetBehindPlayer
return 

:TRUCK_15288
43@ += 1 
if 
  43@ > 9 
else_jump @TRUCK_15320 
43@ = 0 

:TRUCK_15320
return 

:TRUCK_15322
01BD: 44@ = current_time_in_ms 
0085: 46@ = 44@ 
0062: 46@ -= 45@ 
0085: 45@ = 44@ 
005A: 47@ += 46@ 
return 

:TRUCK_15361
36@ += 1 
37@ = 0 
32@ = 0 
33@ = 0 
return 

:TRUCK_15391
return 

:TRUCK_15393
if 
   not Player.Defined(" + PlayerChar + @")
else_jump @TRUCK_15420 
wait 0 
jump @TRUCK_15393 

:TRUCK_15420
Player.CanMove(" + PlayerChar + @") = False
wait 1000 
fade 0 1000 

:TRUCK_15439
if 
fading 
else_jump @TRUCK_15463 
wait 0 
jump @TRUCK_15439 

:TRUCK_15463
gosub @TRUCK_15630 
gosub @TRUCK_15696 
gosub @TRUCK_16342 
0395: clear_area 1 at " + _2373 + @" " + _2374 + @" " + _2375 + @" radius 100.0 
Camera.SetAtPos(" + _2373 + @", " + _2374 + @", " + _2375 + @")
Actor.PutAt(" + PlayerActor + @", -76.9664, -1134.639, 0.0781)
Actor.Angle(" + PlayerActor + @") = 14.7291
Camera.SetBehindPlayer
01EB: set_traffic_density_multiplier_to 0.0 
gosub @TRUCK_7806 
wait 2000 
0A2D: hide_styled_text_while_fading 1 
0169: set_fade_color_RGB 0 0 0 
fade 1 1000 

:TRUCK_15583
if 
fading 
else_jump @TRUCK_15607 
wait 0 
jump @TRUCK_15583 

:TRUCK_15607
Player.CanMove(" + PlayerChar + @") = True
89@ = 0 
gosub @TRUCK_15361 
return 

:TRUCK_15630
0209: 97@ = random_int_in_ranges 0 3 
97@ += 1 
if 
  97@ == 1 
else_jump @TRUCK_15678 
96@ = 1 
jump @TRUCK_15694 

:TRUCK_15678
0209: 96@ = random_int_in_ranges 1 4 
96@ += 1 

:TRUCK_15694
return 

:TRUCK_15696
0871: init_jump_table 97@ total_jumps 3 default_jump 1 @TRUCK_15795 jumps 1 @TRUCK_15759 2 @TRUCK_15771 3 @TRUCK_15783 -1 @TRUCK_15810 -1 @TRUCK_15810 -1 @TRUCK_15810 -1 @TRUCK_15810 

:TRUCK_15759
Model.Load(#PETRO)
jump @TRUCK_15810 

:TRUCK_15771
Model.Load(#LINERUN)
jump @TRUCK_15810 

:TRUCK_15783
Model.Load(#RDTRAIN)
jump @TRUCK_15810 

:TRUCK_15795
0662: printstring ""UNKNOWN_CAB"" 

:TRUCK_15810
0871: init_jump_table 96@ total_jumps 4 default_jump 1 @TRUCK_15921 jumps 1 @TRUCK_15873 2 @TRUCK_15885 3 @TRUCK_15897 4 @TRUCK_15909 -1 @TRUCK_15940 -1 @TRUCK_15940 -1 @TRUCK_15940 

:TRUCK_15873
Model.Load(#PETROTR)
jump @TRUCK_15940 

:TRUCK_15885
Model.Load(#ARTICT1)
jump @TRUCK_15940 

:TRUCK_15897
Model.Load(#ARTICT2)
jump @TRUCK_15940 

:TRUCK_15909
Model.Load(#ARTICT3)
jump @TRUCK_15940 

:TRUCK_15921
0662: printstring ""UNKNOWN_TRAILER"" 

:TRUCK_15940
038B: load_requested_models 
0871: init_jump_table 97@ total_jumps 3 default_jump 1 @TRUCK_16107 jumps 1 @TRUCK_16005 2 @TRUCK_16039 3 @TRUCK_16073 -1 @TRUCK_16122 -1 @TRUCK_16122 -1 @TRUCK_16122 -1 @TRUCK_16122 

:TRUCK_16005
if 
   not Model.Available(#PETRO)
else_jump @TRUCK_16032 
wait 0 
jump @TRUCK_16005 

:TRUCK_16032
jump @TRUCK_16122 

:TRUCK_16039
if 
   not Model.Available(#LINERUN)
else_jump @TRUCK_16066 
wait 0 
jump @TRUCK_16039 

:TRUCK_16066
jump @TRUCK_16122 

:TRUCK_16073
if 
   not Model.Available(#RDTRAIN)
else_jump @TRUCK_16100 
wait 0 
jump @TRUCK_16073 

:TRUCK_16100
jump @TRUCK_16122 

:TRUCK_16107
0662: printstring ""UNKNOWN_CAB"" 

:TRUCK_16122
0871: init_jump_table 96@ total_jumps 4 default_jump 1 @TRUCK_16321 jumps 1 @TRUCK_16185 2 @TRUCK_16219 3 @TRUCK_16253 4 @TRUCK_16287 -1 @TRUCK_16340 -1 @TRUCK_16340 -1 @TRUCK_16340 

:TRUCK_16185
if 
   not Model.Available(#PETROTR)
else_jump @TRUCK_16212 
wait 0 
jump @TRUCK_16185 

:TRUCK_16212
jump @TRUCK_16340 

:TRUCK_16219
if 
   not Model.Available(#ARTICT1)
else_jump @TRUCK_16246 
wait 0 
jump @TRUCK_16219 

:TRUCK_16246
jump @TRUCK_16340 

:TRUCK_16253
if 
   not Model.Available(#ARTICT2)
else_jump @TRUCK_16280 
wait 0 
jump @TRUCK_16253 

:TRUCK_16280
jump @TRUCK_16340 

:TRUCK_16287
if 
   not Model.Available(#ARTICT3)
else_jump @TRUCK_16314 
wait 0 
jump @TRUCK_16287 

:TRUCK_16314
jump @TRUCK_16340 

:TRUCK_16321
0662: printstring ""UNKNOWN_TRAILER"" 

:TRUCK_16340
return 

:TRUCK_16342
return 

:TRUCK_16344
00BA: show_text_styled GXT 'M_FAIL' time 5000 style 1  
0871: init_jump_table 89@ total_jumps 5 default_jump 0 @TRUCK_16538 jumps 1 @TRUCK_16423 2 @TRUCK_16446 3 @TRUCK_16469 4 @TRUCK_16492 5 @TRUCK_16515 -1 @TRUCK_16538 -1 @TRUCK_16538 

:TRUCK_16423
00BC: show_text_highpriority GXT 'TRK_F1' time 5000 flag 1  
jump @TRUCK_16538 

:TRUCK_16446
00BC: show_text_highpriority GXT 'TRK_F2' time 5000 flag 1  
jump @TRUCK_16538 

:TRUCK_16469
00BC: show_text_highpriority GXT 'TRK_F3' time 5000 flag 1  
jump @TRUCK_16538 

:TRUCK_16492
00BC: show_text_highpriority GXT 'TRK_F4' time 5000 flag 1  
jump @TRUCK_16538 

:TRUCK_16515
00BC: show_text_highpriority GXT 'TRK_F5' time 5000 flag 1  
jump @TRUCK_16538 

:TRUCK_16538
return 

:TRUCK_16540
gosub @TRUCK_7500 
01E3: show_text_1number_styled GXT 'M_PASS' number 83@ time 5000 style 1  
Player.Money(" + PlayerChar + @") += 83@
0151: remove_status_text " + _8160 + @" 
" + Trucking_Total_Passed_Missions + @" += 1 
if 
  " + Trucking_Total_Passed_Missions + @" == 1 
else_jump @TRUCK_16627 
00BC: show_text_highpriority GXT 'TRK_P1' time 5000 flag 1  
jump @TRUCK_16725 

:TRUCK_16627
if 
  " + Trucking_Total_Passed_Missions + @" == 8 
else_jump @TRUCK_16706 
if 
  " + Mission_Trucking_Passed + @" == 0 
else_jump @TRUCK_16683 
0595: mission_complete 
0394: play_music 2 
" + Mission_Trucking_Passed + @" = 1 
114@ = 1 

:TRUCK_16683
00BA: show_text_styled GXT 'TRK_P4' time 5000 style 4  
jump @TRUCK_16725 

:TRUCK_16706
01E5: show_text_1number_highpriority GXT 'TRK_P3' number " + Trucking_Total_Passed_Missions + @" time 5000 flag 1  

:TRUCK_16725
0A10: increase_integer_stat 161 by 1 
0A10: increase_integer_stat 162 by 83@ 
return 

:TRUCK_16742
Player.ClearWantedLevel(" + PlayerChar + @")
return 

:TRUCK_16749
Car.RemoveReferences(74@)
Car.RemoveReferences(75@)
Marker.Disable(77@)
Marker.Disable(76@)
Marker.Disable(78@)
Marker.Disable(79@)
0151: remove_status_text " + _8160 + @" 
0151: remove_status_text " + _8161 + @" 
014F: stop_timer " + _8162 + @" 
Model.Destroy(#PETRO)
Model.Destroy(#LINERUN)
Model.Destroy(#RDTRAIN)
Model.Destroy(#PETROTR)
Model.Destroy(#ARTICT1)
Model.Destroy(#ARTICT2)
Model.Destroy(#ARTICT3)
03DE: set_pedestrians_density_multiplier_to 1.0 
01EB: set_traffic_density_multiplier_to 1.0 
06D0: enable_emergency_traffic 1 
01BD: " + Current_Time_in_ms + @" = current_time_in_ms 
0A2D: hide_styled_text_while_fading 1 
" + _411 + @" = 0 
" + OnMission + @" = 0 
mission_cleanup 
return" );
            }

        }

    }

}