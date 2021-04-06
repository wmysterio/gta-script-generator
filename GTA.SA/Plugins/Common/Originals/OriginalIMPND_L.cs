using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalIMPND_L : Original {

        internal OriginalIMPND_L() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.create_thread<IMPND_L>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class IMPND_L : Thread {

            public override void START( LabelJump label ) {
                AppendLine( @":IMPND_L_11
wait 100 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPND_L_706 
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @IMPND_L_189" );
get_external_script_status<IMPND>( ScriptStatus );
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @IMPND_L_189 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 1579.425 -1636.463 14.5812 radius 120.0 120.0 80.0 
else_jump @IMPND_L_160 
" + IMPOUND_Town_Number + @" = 1" );
load_external_script<IMPND>();
AppendLine( @"if" );
is_external_script_loaded<IMPND>().write(); 
AppendLine( @"else_jump @IMPND_L_153" );
start_new_external_script<IMPND>();  
AppendLine( @"
:IMPND_L_153
jump @IMPND_L_189 

:IMPND_L_160
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_L_189" );
remove_references_external_script<IMPND>(); 
AppendLine( @"" + IMPOUND_Town_Number + @" = 0 

:IMPND_L_189
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @IMPND_L_390" );
get_external_script_status<IMPND>( ScriptStatus ); 
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @IMPND_L_390 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere -1624.771 679.6637 8.569 radius 120.0 120.0 80.0 
else_jump @IMPND_L_336 
if 
  " + _1522 + @" == 0 
else_jump @IMPND_L_329 
" + IMPOUND_Town_Number + @" = 2" );
load_external_script<IMPND>();
AppendLine( @"if" );
is_external_script_loaded<IMPND>().write(); 
AppendLine( @"else_jump @IMPND_L_329" );
start_new_external_script<IMPND>();  
AppendLine( @"
:IMPND_L_329
jump @IMPND_L_390 

:IMPND_L_336
if 
  " + _1522 + @" == 2 
else_jump @IMPND_L_361 
" + _1522 + @" = 0 

:IMPND_L_361
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_L_390" );
remove_references_external_script<IMPND>(); 
AppendLine( @"" + IMPOUND_Town_Number + @" = 0 

:IMPND_L_390
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @IMPND_L_548" );
get_external_script_status<IMPND>( ScriptStatus ); 
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @IMPND_L_548 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere -1624.771 679.6637 8.569 radius 120.0 120.0 80.0 
else_jump @IMPND_L_519 
" + IMPOUND_Town_Number + @" = 2" );
load_external_script<IMPND>();
AppendLine( @"if" );
is_external_script_loaded<IMPND>().write(); 
AppendLine( @"else_jump @IMPND_L_512" );
start_new_external_script<IMPND>();  
AppendLine( @"
:IMPND_L_512
jump @IMPND_L_548 

:IMPND_L_519
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_L_548" );
remove_references_external_script<IMPND>(); 
AppendLine( @"" + IMPOUND_Town_Number + @" = 0 

:IMPND_L_548
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @IMPND_L_706" );
get_external_script_status<IMPND>( ScriptStatus ); 
AppendLine( @"if 
  " + ScriptStatus + @" == 0 
else_jump @IMPND_L_706 
if 
00FE:   actor " + PlayerActor + @" sphere 0 in_sphere 2284.592 2466.838 12.2306 radius 120.0 120.0 80.0 
else_jump @IMPND_L_677 
" + IMPOUND_Town_Number + @" = 3" );
load_external_script<IMPND>();
AppendLine( @"if" );
is_external_script_loaded<IMPND>().write(); 
AppendLine( @"else_jump @IMPND_L_670" );
start_new_external_script<IMPND>();  
AppendLine( @"
:IMPND_L_670
jump @IMPND_L_706 

:IMPND_L_677
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_L_706" );
remove_references_external_script<IMPND>(); 
AppendLine( @"" + IMPOUND_Town_Number + @" = 0 

:IMPND_L_706
jump @IMPND_L_11" );

            }

        }

        private sealed class IMPND : External {

            Int tmp_10666 = global( _10666.startIndex ),
                tmp_10606 = global( _10606.startIndex ),
                tmp_10610 = global( _10610.startIndex ),
                tmp_10614 = global( _10614.startIndex ),
                tmp_10622 = global( _10622.startIndex ),
                tmp_10626 = global( _10626.startIndex ),
                tmp_10630 = global( _10630.startIndex ),
                tmp_10638 = global( _10638.startIndex ),
                tmp_10642 = global( _10642.startIndex ),
                tmp_10646 = global( _10646.startIndex ),
                tmp_10654 = global( _10654.startIndex ),
                tmp_10658 = global( _10658.startIndex ),
                tmp_10662 = global( _10662.startIndex ),
                tmp_10516 = global( _10516.startIndex ),
                tmp_10525 = global( _10525.startIndex ),
                tmp_10533 = global( _10533.startIndex ),
                tmp_10541 = global( _10541.startIndex ),
                tmp_10549 = global( _10549.startIndex ),
                tmp_10716 = global( _10716.startIndex ),
                tmp_10650 = global( _10650.startIndex ),
                tmp_10618 = global( _10618.startIndex ),
                tmp_10634 = global( _10634.startIndex ),
                tmp_10725 = global( _10725.startIndex );

            public override void START( LabelJump label ) {
                AppendLine( @"" + _10559 + @" = 1540.632 
" + _10563 + @" = -1603.163 
" + _10567 + @" = 17.6564 
" + _10571 + @" = 1607.27 
" + _10575 + @" = -1637.528 
" + _10579 + @" = 12.774 
" + _10583 + @" = 1613.319 
" + _10587 + @" = -1633.612 
" + _10591 + @" = 12.077 
" + _10595 + @" = 1522.73 
" + _10599 + @" = -1721.398 
" + _10603 + @" = 4.2191 
" + _10560 + @" = -1572.807 
" + _10564 + @" = 646.8937 
" + _10568 + @" = 10.5019 
" + _10572 + @" = -1641.409 
" + _10576 + @" = 687.6273 
" + _10580 + @" = 4.8704 
" + _10584 + @" = -1700.933 
" + _10588 + @" = 680.025 
" + _10592 + @" = 27.7313 
" + _10596 + @" = -1638.982 
" + _10600 + @" = 699.3646 
" + _10604 + @" = 5.0489 
" + _10561 + @" = 2238.01 
" + _10565 + @" = 2430.891 
" + _10569 + @" = 11.764 
" + _10573 + @" = 2304.289 
" + _10577 + @" = 2502.322 
" + _10581 + @" = -9.0538 
" + _10585 + @" = 2238.01 
" + _10589 + @" = 2430.891 
" + _10593 + @" = 11.764 
" + _10597 + @" = 2304.289 
" + _10601 + @" = 2502.322 
" + _10605 + @" = -9.0538 
" + _10730 + @" = 0 
" + _10731 + @" = 0 
" + _10732 + @" = 0 
" + _10733 + @" = 0 
" + tmp_10549 + @"[0] = 0 
" + tmp_10549 + @"[1] = 0 
" + tmp_10549 + @"[2] = 0 
" + tmp_10549 + @"[3] = 0 
" + tmp_10549 + @"[4] = 0 
" + tmp_10549 + @"[5] = 0 
" + tmp_10549 + @"[6] = 0 
" + tmp_10549 + @"[7] = 0 
" + tmp_10606 + @"[1] = 1544.691 
" + tmp_10610 + @"[1] = -1630.75 
" + tmp_10614 + @"[1] = 13.043 
" + tmp_10618 + @"[1] = 0.0 
" + tmp_10622 + @"[1] = 0.0 
" + tmp_10626 + @"[1] = 0.0 
" + tmp_10630 + @"[1] = 0.0 
" + tmp_10634 + @"[1] = 0.0 
" + tmp_10606 + @"[2] = -1572.203 
" + tmp_10610 + @"[2] = 658.7618 
" + tmp_10614 + @"[2] = 6.8916 
" + tmp_10618 + @"[2] = 0.0 
" + tmp_10622 + @"[2] = -1701.43 
" + tmp_10626 + @"[2] = 687.7184 
" + tmp_10630 + @"[2] = 24.6525 
" + tmp_10634 + @"[2] = 180.0 
" + tmp_10606 + @"[3] = 2238.199 
" + tmp_10610 + @"[3] = 2450.339 
" + tmp_10614 + @"[3] = 10.5829 
" + tmp_10618 + @"[3] = 0.0 
" + tmp_10622 + @"[3] = 0.0 
" + tmp_10626 + @"[3] = 0.0 
" + tmp_10630 + @"[3] = 0.0 
" + tmp_10634 + @"[3] = 0.0 
" + tmp_10638 + @"[1] = 1588.503 
" + tmp_10642 + @"[1] = -1637.872 
" + tmp_10646 + @"[1] = 14.5641 
" + tmp_10650 + @"[1] = 0.0 
" + tmp_10654 + @"[1] = 0.0 
" + tmp_10658 + @"[1] = 0.0 
" + tmp_10662 + @"[1] = 0.0 
" + tmp_10666 + @"[1] = 0.0 
" + tmp_10638 + @"[2] = -1631.767 
" + tmp_10642 + @"[2] = 688.4075 
" + tmp_10646 + @"[2] = 8.5436 
" + tmp_10650 + @"[2] = 90.0 
" + tmp_10654 + @"[2] = 0.0 
" + tmp_10658 + @"[2] = 0.0 
" + tmp_10662 + @"[2] = 0.0 
" + tmp_10666 + @"[2] = 0.0 
" + tmp_10638 + @"[3] = 2293.83 
" + tmp_10642 + @"[3] = 2498.804 
" + tmp_10646 + @"[3] = 4.4414 
" + tmp_10650 + @"[3] = 90.0 
" + tmp_10654 + @"[3] = 2335.178 
" + tmp_10658 + @"[3] = 2443.621 
" + tmp_10662 + @"[3] = 6.9743 
" + tmp_10666 + @"[3] = 59.9993 
if 
  8@ == 90 
else_jump @IMPND_1039 
9@ = Object.Create(#POLICE_BARRIER, 0.0, 0.0, 0.0)
6@ = Object.Create(#KMB_SHUTTER, 0.0, 0.0, 0.0)
0376: 24@ = create_random_actor_at 0.0 0.0 0.0 
0376: 19@ = create_random_actor_at 0.0 0.0 0.0 

:IMPND_1039
wait 0 
if 
   Player.Defined(" + PlayerChar + @")
else_jump @IMPND_4118 
if 
  0@ == 0 
else_jump @IMPND_2453 
if 
  1@ == 0 
else_jump @IMPND_1289 
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @IMPND_1144 
Model.Load(#LAPD1)
Model.Load(#COLT45)
Model.Load(#COPCARLA)
04AE: " + _10710 + @" = 280 
04AE: " + _10711 + @" = 596 

:IMPND_1144
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @IMPND_1193 
Model.Load(#SFPD1)
Model.Load(#COLT45)
Model.Load(#COPCARSF)
04AE: " + _10710 + @" = 281 
04AE: " + _10711 + @" = 597 

:IMPND_1193
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @IMPND_1242 
Model.Load(#LVPD1)
Model.Load(#COLT45)
Model.Load(#COPCARVG)
04AE: " + _10710 + @" = 282 
04AE: " + _10711 + @" = 598 

:IMPND_1242
if 
  " + OnMission + @" == 0 
else_jump @IMPND_1282 
22@ = 1 
Model.Load(#POLICE_BARRIER)
Model.Load(#SFCOPDR)
Model.Load(#KMB_SHUTTER)

:IMPND_1282
1@ = 2 

:IMPND_1289
if 
  1@ == 2 
else_jump @IMPND_2453 
if and
   Model.Available(" + _10710 + @")
   Model.Available(#COLT45)
   Model.Available(" + _10711 + @")
else_jump @IMPND_2453 
1@ = 0 
if 
   not " + OnMission + @" == 1 
else_jump @IMPND_1358 

:IMPND_1358
07E5: copy_decision_maker 65542 to 2@ 
0709: set_decision_maker 2@ on_event 15 taskID 300 respect 100.0 hate 100.0 like 100.0 dislike 0.0 in_car 0 on_foot 1 
9@ = Object.Init(#POLICE_BARRIER, " + tmp_10606 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10610 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10614 + @"(" + IMPOUND_Town_Number + @",4f))
0453: set_object 9@ XYZ_rotation -90.0 0.0 " + tmp_10618 + @"(" + IMPOUND_Town_Number + @",4f) 
if 
   not " + tmp_10622 + @"(" + IMPOUND_Town_Number + @",4f) == 0.0 
else_jump @IMPND_1529 
10@ = Object.Init(#POLICE_BARRIER, " + tmp_10622 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10626 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10630 + @"(" + IMPOUND_Town_Number + @",4f))
0453: set_object 10@ XYZ_rotation -90.0 0.0 " + tmp_10634 + @"(" + IMPOUND_Town_Number + @",4f) 

:IMPND_1529
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_1562 
11@ = -388 
jump @IMPND_1570 

:IMPND_1562
11@ = -387 

:IMPND_1570
6@ = Object.Init(11@, " + tmp_10638 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10642 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10646 + @"(" + IMPOUND_Town_Number + @",4f))
0453: set_object 6@ XYZ_rotation 0.0 0.0 " + tmp_10650 + @"(" + IMPOUND_Town_Number + @",4f) 
if 
   not " + tmp_10654 + @"(" + IMPOUND_Town_Number + @",4f) == 0.0 
else_jump @IMPND_1697 
7@ = Object.Init(11@, " + tmp_10654 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10658 + @"(" + IMPOUND_Town_Number + @",4f), " + tmp_10662 + @"(" + IMPOUND_Town_Number + @",4f))
0453: set_object 7@ XYZ_rotation 0.0 0.0 " + tmp_10666 + @"(" + IMPOUND_Town_Number + @",4f) 

:IMPND_1697
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_1885 
" + tmp_10516 + @"[0] = Actor.Create(Mission1, " + _10710 + @", 1544.383, -1631.849, 12.3905)
Actor.Angle(" + tmp_10516 + @"[0]) = 45.0
" + tmp_10516 + @"[2] = Actor.Create(Mission1, " + _10710 + @", 1578.957, -1634.127, 12.5547)
Actor.Angle(" + tmp_10516 + @"[2]) = 0.0
" + _10670 + @" = 1544.383 
" + _10680 + @" = -1631.849 
" + _10690 + @" = 12.3905 
" + _10700 + @" = 45.0 
" + _10672 + @" = 1544.383 
" + _10682 + @" = 1578.957 
" + _10692 + @" = -1634.127 
" + _10702 + @" = 12.554 
" + _10734 + @" = -90.0 
" + _10736 + @" = 0.0 

:IMPND_1885
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_2158 
" + tmp_10516 + @"[1] = Actor.Create(Mission1, " + _10710 + @", -1700.839, 688.9841, 23.9032)
Actor.Angle(" + tmp_10516 + @"[1]) = 134.0
" + tmp_10516 + @"[0] = Actor.Create(Mission1, " + _10710 + @", -1572.705, 657.5745, 6.2446)
Actor.Angle(" + tmp_10516 + @"[0]) = 304.0
" + tmp_10516 + @"[2] = Actor.Create(Mission1, " + _10710 + @", -1616.822, 679.9485, 6.1901)
Actor.Angle(" + tmp_10516 + @"[2]) = 188.0
" + _10670 + @" = -1572.705 
" + _10680 + @" = 657.5745 
" + _10690 + @" = 6.2446 
" + _10700 + @" = 304.0 
" + _10671 + @" = -1700.839 
" + _10681 + @" = 688.9841 
" + _10691 + @" = 23.9032 
" + _10701 + @" = 134.0 
" + _10672 + @" = -1616.822 
" + _10682 + @" = 679.9485 
" + _10692 + @" = 6.1901 
" + _10702 + @" = 188.0 
" + _10734 + @" = -90.0 
" + _10735 + @" = -90.0 
" + _10736 + @" = 0.0 

:IMPND_2158
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_2326 
" + tmp_10516 + @"[0] = Actor.Create(Mission1, " + _10710 + @", 2238.569, 2449.417, 10.0372)
Actor.Angle(" + tmp_10516 + @"[0]) = 90.0
" + tmp_10516 + @"[2] = Actor.Create(Mission1, " + _10710 + @", 2250.277, 2489.333, 9.8203)
Actor.Angle(" + tmp_10516 + @"[2]) = 90.0
" + _10670 + @" = 2238.569 
" + _10680 + @" = 2449.417 
" + _10690 + @" = 10.0372 
" + _10700 + @" = 90.0 
" + _10672 + @" = 2250.277 
" + _10682 + @" = 2489.333 
" + _10692 + @" = 9.8203 
" + _10702 + @" = 90.0 

:IMPND_2326
12@ = 0 

:IMPND_2333
if 
  3 > 12@ 
else_jump @IMPND_2446 
if 
   not Actor.Dead(" + tmp_10516 + @"(12@,8i))
else_jump @IMPND_2432 
060B: set_actor " + tmp_10516 + @"(12@,8i) decision_maker_to 2@ 
Actor.GiveWeaponAndAmmo(" + tmp_10516 + @"(12@,8i), Pistol, 9999)
077A: set_actor " + tmp_10516 + @"(12@,8i) acquaintance 3 to_actors_pedtype 0 
" + tmp_10533 + @"(12@,8i) = 0 
" + tmp_10525 + @"(12@,8i) = 5 

:IMPND_2432
12@ += 1 
jump @IMPND_2333 

:IMPND_2446
0@ = 2 

:IMPND_2453
if 
  0@ == 2 
else_jump @IMPND_4111 
Actor.StorePos(" + PlayerActor + @", " + tempvar_X_coord + @", " + tempvar_Y_coord + @", " + tempvar_Z_coord + @")
gosub @IMPND_5547 
if 
001D:   32@ > 4@ 
else_jump @IMPND_2583 
0085: 4@ = 32@ 
4@ += 90 
gosub @IMPND_21068 
if 
  " + _10729 + @" == 0 
else_jump @IMPND_2583 
if 
  " + _10713 + @" == 1 
else_jump @IMPND_2583 
" + _10729 + @" = 1 
gosub @IMPND_4150 

:IMPND_2583
if 
  " + OnMission + @" == 1 
else_jump @IMPND_2641 
if 
  22@ == 1 
else_jump @IMPND_2641 
22@ = 0 
Model.Destroy(#POLICE_BARRIER)
Model.Destroy(#SFCOPDR)
Model.Destroy(#KMB_SHUTTER)

:IMPND_2641
if 
  20@ == 1 
else_jump @IMPND_2754 
040D: unload_wav 4 
0209: 8@ = random_int_in_ranges 0 4 
if 
  8@ == 0 
else_jump @IMPND_2697 
03CF: load_wav 10204 as 4 

:IMPND_2697
if 
  8@ == 1 
else_jump @IMPND_2722 
03CF: load_wav 10205 as 4 

:IMPND_2722
if 
  8@ == 2 
else_jump @IMPND_2747 
03CF: load_wav 10206 as 4 

:IMPND_2747
20@ = 2 

:IMPND_2754
if 
  20@ == 2 
else_jump @IMPND_2851 
if 
03D0:   wav 4 loaded 
else_jump @IMPND_2851 
if 
   not Actor.Dead(19@)
else_jump @IMPND_2851 
0949: link_wav 4 to_actor 19@ 
0489: set_actor 19@ muted 1 
094E: set_actor 19@ mute_pain_audio 1 
03D1: play_wav 4 
20@ = 3 
0085: 21@ = 32@ 
21@ += 10000 

:IMPND_2851
if 
  20@ == 3 
else_jump @IMPND_2925 
if 
001D:   32@ > 21@ 
else_jump @IMPND_2925 
20@ = 0 
if 
   not Actor.Dead(19@)
else_jump @IMPND_2925 
0489: set_actor 19@ muted 0 
094E: set_actor 19@ mute_pain_audio 0 

:IMPND_2925
if 
  20@ == 4 
else_jump @IMPND_3038 
040D: unload_wav 4 
0209: 8@ = random_int_in_ranges 0 4 
if 
  8@ == 0 
else_jump @IMPND_2981 
03CF: load_wav 10200 as 4 

:IMPND_2981
if 
  8@ == 1 
else_jump @IMPND_3006 
03CF: load_wav 10201 as 4 

:IMPND_3006
if 
  8@ == 2 
else_jump @IMPND_3031 
03CF: load_wav 10202 as 4 

:IMPND_3031
20@ = 2 

:IMPND_3038
if 
  20@ == 5 
else_jump @IMPND_3076 
040D: unload_wav 4 
03CF: load_wav 36000 as 4 
20@ = 2 

:IMPND_3076
if 
  " + _10524 + @" == 1 
else_jump @IMPND_3407 
if 
03D2:   wav 4 ended 
else_jump @IMPND_3407 
if 
03D0:   wav 4 loaded 
else_jump @IMPND_3407 
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_3199 
097C: attach_wav 4 to_object 6@ 
03D1: play_wav 4 
03D7: set_wav 4 location 1589.06 -1694.729 10.4887 
03D1: play_wav 4 
03D7: set_wav 4 location 1541.513 -1685.943 10.1571 
03D1: play_wav 4 

:IMPND_3199
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_3297 
097C: attach_wav 4 to_object 6@ 
03D1: play_wav 4 
03D7: set_wav 4 location -1619.873 742.786 -2.1389 
03D1: play_wav 4 
03D7: set_wav 4 location -1594.096 716.011 -3.1454 
03D1: play_wav 4 
03D7: set_wav 4 location -1605.518 672.6205 -3.2395 
03D1: play_wav 4 

:IMPND_3297
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_3407 
03D7: set_wav 4 location 2296.433 2444.295 7.0111 
03D1: play_wav 4 
03D7: set_wav 4 location 2255.404 2446.676 5.6601 
03D1: play_wav 4 
03D7: set_wav 4 location 2243.107 2498.225 8.5154 
03D1: play_wav 4 
03D7: set_wav 4 location 2296.927 2492.902 0.2841 
03D1: play_wav 4 

:IMPND_3407
16@ = 0 

:IMPND_3414
if 
  8 > 16@ 
else_jump @IMPND_3682 
if 
   not Actor.Dead(" + tmp_10516 + @"(16@,8i))
else_jump @IMPND_3668 
if 
   not 0 > " + tmp_10716 + @"(16@,8i) 
else_jump @IMPND_3668 
080E: get_actor " + tmp_10516 + @"(16@,8i) ped_event_to " + tmp_10716 + @"(16@,8i) 
if 
   not " + tmp_10716 + @"(16@,8i) == 0 
else_jump @IMPND_3668 
if or
04A3:   " + tmp_10716 + @"(16@,8i) == 15 
04A3:   " + tmp_10716 + @"(16@,8i) == 49 
04A3:   " + tmp_10716 + @"(16@,8i) == 9 
else_jump @IMPND_3581 
" + tmp_10716 + @"(16@,8i) = -2 
Actor.StorePos(" + PlayerActor + @", " + _10743 + @", " + _10744 + @", " + _10745 + @")

:IMPND_3581
if 
04A3:   " + tmp_10716 + @"(16@,8i) == 62 
else_jump @IMPND_3668 
if 
0104:   actor " + tmp_10516 + @"(16@,8i) near_actor " + PlayerActor + @" radius 5.0 5.0 3.0 sphere 0 
else_jump @IMPND_3668 
" + tmp_10716 + @"(16@,8i) = -1 
Actor.StorePos(" + PlayerActor + @", " + _10743 + @", " + _10744 + @", " + _10745 + @")

:IMPND_3668
16@ += 1 
jump @IMPND_3414 

:IMPND_3682
if 
001D:   32@ > 3@ 
else_jump @IMPND_3892 
0085: 3@ = 32@ 
3@ += 100 
if 
   not Actor.Dead(" + tmp_10516 + @"(12@,8i))
else_jump @IMPND_3794 
" + _10714 + @" = 0 
23@ = 0 
008B: 13@ = " + tmp_10525 + @"(12@,8i) 
gosub @IMPND_21725 
gosub @IMPND_10480 
" + tmp_10716 + @"(12@,8i) = 0 
jump @IMPND_3860 

:IMPND_3794
if 
07D6:   19@ == " + tmp_10516 + @"(12@,8i) 
else_jump @IMPND_3860 
if and
   not 20@ == 0 
  " + _10524 + @" == 0 
else_jump @IMPND_3846 
040D: unload_wav 4 

:IMPND_3846
20@ = 0 
19@ = 0 

:IMPND_3860
12@ += 1 
if 
  12@ > 7 
else_jump @IMPND_3892 
12@ = 0 

:IMPND_3892
if 
04A3:   " + Current_Town_Number + @" == 1 
else_jump @IMPND_3965 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 1579.425 -1636.463 14.5812 radius 120.0 120.0 80.0 
else_jump @IMPND_3965 
gosub @IMPND_22003 

:IMPND_3965
if 
04A3:   " + Current_Town_Number + @" == 2 
else_jump @IMPND_4038 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere -1624.771 679.6637 8.569 radius 120.0 120.0 80.0 
else_jump @IMPND_4038 
gosub @IMPND_22003 

:IMPND_4038
if 
04A3:   " + Current_Town_Number + @" == 3 
else_jump @IMPND_4111 
if 
80FE:   not actor " + PlayerActor + @" sphere 0 in_sphere 2284.592 2466.838 12.2306 radius 120.0 120.0 80.0 
else_jump @IMPND_4111 
gosub @IMPND_22003 

:IMPND_4111
jump @IMPND_4143 

:IMPND_4118
if 
  0@ == 2 
else_jump @IMPND_4143 
gosub @IMPND_22003 

:IMPND_4143
jump @IMPND_1039 

:IMPND_4150
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_4580 
" + tmp_10725 + @"[0] = Car.Create(" + _10711 + @", 2285.502, 2473.748, 2.266)
" + tmp_10725 + @"[1] = Car.Create(" + _10711 + @", 2314.358, 2475.845, 2.266)
" + tmp_10725 + @"[2] = Car.Create(" + _10711 + @", 2240.971, 2476.485, -8.4476)
" + tmp_10725 + @"[3] = Car.Create(" + _10711 + @", 2303.053, 2431.712, -8.4531)
Car.Angle(" + tmp_10725 + @"[0]) = 179.4722
Car.Angle(" + tmp_10725 + @"[1]) = 268.529
Car.Angle(" + tmp_10725 + @"[2]) = 92.5631
Car.Angle(" + tmp_10725 + @"[3]) = 180.0971
Car.DoorStatus(" + tmp_10725 + @"[0]) = 3
Car.DoorStatus(" + tmp_10725 + @"[1]) = 1
Car.DoorStatus(" + tmp_10725 + @"[2]) = 3
Car.DoorStatus(" + tmp_10725 + @"[3]) = 1
" + tmp_10516 + @"[3] = Actor.CreateAsDriver(Mission2, " + _10710 + @", " + tmp_10725 + @"[0])
" + tmp_10516 + @"[4] = Actor.CreateAsPassenger(Mission2, " + _10710 + @", " + tmp_10725 + @"[0], 0)
" + tmp_10516 + @"[5] = Actor.Create(Mission1, " + _10710 + @", 2278.1, 2425.453, 2.4766)
" + tmp_10516 + @"[6] = Actor.Create(Mission1, " + _10710 + @", 2268.906, 2449.246, -8.1953)
Actor.Angle(" + tmp_10516 + @"[5]) = 187.5721
Actor.Angle(" + tmp_10516 + @"[6]) = 228.3262
" + tmp_10525 + @"[3] = 5 
" + tmp_10525 + @"[4] = 5 
" + tmp_10525 + @"[5] = 5 
" + tmp_10525 + @"[6] = 5 
" + tmp_10533 + @"[3] = 0 
" + tmp_10533 + @"[4] = 0 
" + tmp_10533 + @"[5] = 0 
" + tmp_10533 + @"[6] = 0 
12@ = 3 

:IMPND_4489
if 
  7 > 12@ 
else_jump @IMPND_4580 
if 
   not Actor.Dead(" + tmp_10516 + @"(12@,8i))
else_jump @IMPND_4566 
060B: set_actor " + tmp_10516 + @"(12@,8i) decision_maker_to 2@ 
Actor.GiveWeaponAndAmmo(" + tmp_10516 + @"(12@,8i), Pistol, 9999)
077A: set_actor " + tmp_10516 + @"(12@,8i) acquaintance 3 to_actors_pedtype 0 

:IMPND_4566
12@ += 1 
jump @IMPND_4489 

:IMPND_4580
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_5017 
" + tmp_10725 + @"[0] = Car.Create(" + _10711 + @", -1600.142, 748.2594, -6.2344)
" + tmp_10725 + @"[1] = Car.Create(" + _10711 + @", -1616.233, 691.9449, -6.2422)
" + tmp_10725 + @"[2] = Car.Create(" + _10711 + @", -1574.061, 717.9744, -6.2344)
" + tmp_10725 + @"[3] = Car.Create(" + _10711 + @", -1574.305, 726.8611, -6.2344)
Car.Angle(" + tmp_10725 + @"[0]) = 359.8067
Car.Angle(" + tmp_10725 + @"[1]) = 358.8804
Car.Angle(" + tmp_10725 + @"[2]) = 268.0333
Car.Angle(" + tmp_10725 + @"[3]) = 268.3534
Car.DoorStatus(" + tmp_10725 + @"[0]) = 3
Car.DoorStatus(" + tmp_10725 + @"[1]) = 1
Car.DoorStatus(" + tmp_10725 + @"[2]) = 3
Car.DoorStatus(" + tmp_10725 + @"[3]) = 1
" + tmp_10516 + @"[3] = Actor.CreateAsDriver(Mission2, " + _10710 + @", " + tmp_10725 + @"[0])
" + tmp_10516 + @"[4] = Actor.CreateAsPassenger(Mission2, " + _10710 + @", " + tmp_10725 + @"[0], 0)
" + tmp_10516 + @"[5] = Actor.Create(Mission1, " + _10710 + @", -1606.067, 701.3859, -5.9062)
" + tmp_10516 + @"[6] = Actor.Create(Mission1, " + _10710 + @", -1615.934, 695.0814, -6.2422)
Actor.Angle(" + tmp_10516 + @"[5]) = 270.5721
Actor.Angle(" + tmp_10516 + @"[6]) = 180.3262
" + tmp_10525 + @"[3] = 5 
" + tmp_10525 + @"[4] = 5 
" + tmp_10525 + @"[5] = 5 
" + tmp_10525 + @"[6] = 5 
" + tmp_10533 + @"[3] = 0 
" + tmp_10533 + @"[4] = 0 
" + tmp_10533 + @"[5] = 0 
" + tmp_10533 + @"[6] = 0 
12@ = 3 

:IMPND_4919
if 
  8 > 12@ 
else_jump @IMPND_5010 
if 
   not Actor.Dead(" + tmp_10516 + @"(12@,8i))
else_jump @IMPND_4996 
060B: set_actor " + tmp_10516 + @"(12@,8i) decision_maker_to 2@ 
Actor.GiveWeaponAndAmmo(" + tmp_10516 + @"(12@,8i), Pistol, 9999)
077A: set_actor " + tmp_10516 + @"(12@,8i) acquaintance 3 to_actors_pedtype 0 

:IMPND_4996
12@ += 1 
jump @IMPND_4919 

:IMPND_5010
12@ = 0 

:IMPND_5017
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_5545 
" + tmp_10725 + @"[0] = Car.Create(" + _10711 + @", 1586.254, -1671.732, 4.8916)
" + tmp_10725 + @"[1] = Car.Create(" + _10711 + @", 1601.52, -1699.925, 4.8984)
" + tmp_10725 + @"[2] = Car.Create(" + _10711 + @", 1565.429, -1710.81, 4.8984)
" + tmp_10725 + @"[3] = Car.Create(" + _10711 + @", 1529.675, -1688.105, 4.897)
Car.Angle(" + tmp_10725 + @"[0]) = 90.8726
Car.Angle(" + tmp_10725 + @"[1]) = 268.6337
Car.Angle(" + tmp_10725 + @"[2]) = 177.2788
Car.Angle(" + tmp_10725 + @"[3]) = 270.141
Car.DoorStatus(" + tmp_10725 + @"[0]) = 3
Car.DoorStatus(" + tmp_10725 + @"[1]) = 1
Car.DoorStatus(" + tmp_10725 + @"[2]) = 3
Car.DoorStatus(" + tmp_10725 + @"[3]) = 1
" + tmp_10516 + @"[3] = Actor.CreateAsDriver(Mission2, " + _10710 + @", " + tmp_10725 + @"[0])
" + tmp_10516 + @"[4] = Actor.CreateAsPassenger(Mission2, " + _10710 + @", " + tmp_10725 + @"[0], 0)
" + tmp_10516 + @"[5] = Actor.Create(Mission1, " + _10710 + @", 1527.145, -1675.299, 4.8984)
" + tmp_10516 + @"[6] = Actor.Create(Mission1, " + _10710 + @", 1603.711, -1714.294, 5.2187)
" + tmp_10516 + @"[1] = Actor.Create(Mission1, " + _10710 + @", 1608.285, -1715.779, 5.2187)
" + tmp_10516 + @"[7] = Actor.Create(Mission1, " + _10710 + @", 1532.631, -1688.01, 4.8984)
Actor.Angle(" + tmp_10516 + @"[5]) = 90.5721
Actor.Angle(" + tmp_10516 + @"[6]) = 242.3262
Actor.Angle(" + tmp_10516 + @"[1]) = 225.3262
Actor.Angle(" + tmp_10516 + @"[7]) = 90.3262
" + tmp_10525 + @"[1] = 5 
" + tmp_10525 + @"[3] = 5 
" + tmp_10525 + @"[4] = 5 
" + tmp_10525 + @"[5] = 5 
" + tmp_10525 + @"[6] = 5 
" + tmp_10525 + @"[7] = 5 
" + tmp_10533 + @"[3] = 0 
" + tmp_10533 + @"[4] = 0 
" + tmp_10533 + @"[5] = 0 
" + tmp_10533 + @"[6] = 0 
" + tmp_10533 + @"[7] = 0 
12@ = 0 

:IMPND_5447
if 
  8 > 12@ 
else_jump @IMPND_5538 
if 
   not Actor.Dead(" + tmp_10516 + @"(12@,8i))
else_jump @IMPND_5524 
060B: set_actor " + tmp_10516 + @"(12@,8i) decision_maker_to 2@ 
Actor.GiveWeaponAndAmmo(" + tmp_10516 + @"(12@,8i), Pistol, 9999)
077A: set_actor " + tmp_10516 + @"(12@,8i) acquaintance 3 to_actors_pedtype 0 

:IMPND_5524
12@ += 1 
jump @IMPND_5447 

:IMPND_5538
12@ = 0 

:IMPND_5545
return 

:IMPND_5547
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_6873 
0871: init_jump_table " + _10730 + @" total_jumps 4 default_jump 0 @IMPND_6147 jumps 0 @IMPND_5628 1 @IMPND_5887 2 @IMPND_5950 3 @IMPND_6017 -1 @IMPND_6147 -1 @IMPND_6147 -1 @IMPND_6147 

:IMPND_5628
if 
  " + tmp_10549 + @"[0] == 0 
else_jump @IMPND_5801 
if 
09C3:   police_car_in_rectangle_cornerA 1554.32 -1632.669 13.9475 cornerB 1535.271 -1620.762 11.8805 
else_jump @IMPND_5801 
if 
   not Actor.Dead(" + tmp_10516 + @"[0])
else_jump @IMPND_5801 
if 
00A3:   actor " + tmp_10516 + @"[0] sphere 0 in_rectangle_cornerA 1543.595 -1631.279 cornerB 1545.022 -1632.704 
else_jump @IMPND_5801 
" + _10730 + @" = 1 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_5801 
if 
  20@ == 0 
else_jump @IMPND_5801 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[0] 

:IMPND_5801
if 
  " + _10557 + @" == 1 
else_jump @IMPND_5880 
if 
   not Car.Wrecked(" + tmp_10725 + @"[1])
else_jump @IMPND_5880 
if 
00B0:   car " + tmp_10725 + @"[1] sphere 0 in_rectangle_cornerA 1544.988 -1622.29 cornerB 1556.178 -1632.62 
else_jump @IMPND_5880 
" + _10730 + @" = 1 

:IMPND_5880
jump @IMPND_6147 

:IMPND_5887
" + _10734 + @" += 0.5 
0453: set_object 9@ XYZ_rotation " + _10734 + @" 0.0 0.0 
if 
  " + _10734 + @" >= 0.0 
else_jump @IMPND_5943 
" + _10730 + @" = 2 

:IMPND_5943
jump @IMPND_6147 

:IMPND_5950
if 
8339:   not anything_in_cube_cornerA 1554.32 -1632.669 13.9475 cornerB 1535.271 -1620.762 11.8805 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_6010 
" + _10730 + @" = 3 

:IMPND_6010
jump @IMPND_6147 

:IMPND_6017
if 
0339:   anything_in_cube_cornerA 1540.938 -1623.681 14.3551 cornerB 1550.887 -1631.648 12.1949 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_6084 
" + _10730 + @" = 1 
jump @IMPND_6140 

:IMPND_6084
" + _10734 + @" -= 0.5 
0453: set_object 9@ XYZ_rotation " + _10734 + @" 0.0 0.0 
if 
  -90.0 >= " + _10734 + @" 
else_jump @IMPND_6140 
" + _10730 + @" = 0 

:IMPND_6140
jump @IMPND_6147 

:IMPND_6147
0871: init_jump_table " + _10732 + @" total_jumps 4 default_jump 0 @IMPND_6873 jumps 0 @IMPND_6210 1 @IMPND_6484 2 @IMPND_6611 3 @IMPND_6686 -1 @IMPND_6873 -1 @IMPND_6873 -1 @IMPND_6873 

:IMPND_6210
if 
  " + _10713 + @" == 1 
else_jump @IMPND_6409 
if 
09C3:   police_car_in_rectangle_cornerA 1592.251 -1637.59 17.1898 cornerB 1578.344 -1624.273 11.9866 
else_jump @IMPND_6409 
if 
  " + tmp_10549 + @"[2] == 0 
else_jump @IMPND_6409 
if 
   not Actor.Dead(" + tmp_10516 + @"[2])
else_jump @IMPND_6409 
if 
00A3:   actor " + tmp_10516 + @"[2] sphere 0 in_rectangle_cornerA 1582.153 -1637.67 cornerB 1577.585 -1633.235 
else_jump @IMPND_6409 
" + _10732 + @" = 1 
097B: play_audio_at_object 6@ event 1153 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_6409 
if 
  20@ == 0 
else_jump @IMPND_6409 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[2] 

:IMPND_6409
if 
0339:   anything_in_cube_cornerA 1581.732 -1639.463 16.4817 cornerB 1599.936 -1652.072 7.8825 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_6477 
" + _10732 + @" = 1 
097B: play_audio_at_object 6@ event 1153 

:IMPND_6477
jump @IMPND_6873 

:IMPND_6484
Object.StorePos(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
" + _10740 + @" += 0.0173 
" + _10736 + @" += 0.9 
if 
  " + _10740 + @" >= 16.425 
else_jump @IMPND_6574 
" + _10732 + @" = 2 
" + _10740 + @" = 16.425 
" + _10736 + @" = 90.0 
097B: play_audio_at_object 6@ event 1154 

:IMPND_6574
Object.PutAt(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
0453: set_object 6@ XYZ_rotation " + _10736 + @" 0.0 " + tmp_10650 + @"[1] 
jump @IMPND_6873 

:IMPND_6611
if 
8339:   not anything_in_cube_cornerA 1602.079 -1655.913 6.5685 cornerB 1582.779 -1631.262 17.1606 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_6679 
" + _10732 + @" = 3 
097B: play_audio_at_object 6@ event 1153 

:IMPND_6679
jump @IMPND_6873 

:IMPND_6686
Object.StorePos(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
" + _10740 + @" -= 0.0155 
" + _10736 + @" -= 0.9 
if 
  14.5641 >= " + _10740 + @" 
else_jump @IMPND_6776 
097B: play_audio_at_object 6@ event 1154 
" + _10732 + @" = 0 
" + _10736 + @" = 0.0 
" + _10740 + @" = 14.5641 

:IMPND_6776
Object.PutAt(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
0453: set_object 6@ XYZ_rotation " + _10736 + @" 0.0 " + tmp_10650 + @"[1] 
if 
0339:   anything_in_cube_cornerA 1602.079 -1655.913 6.5685 cornerB 1582.779 -1631.262 17.1606 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_6866 
" + _10732 + @" = 1 

:IMPND_6866
jump @IMPND_6873 

:IMPND_6873
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_8639 
0871: init_jump_table " + _10730 + @" total_jumps 4 default_jump 0 @IMPND_7394 jumps 0 @IMPND_6954 1 @IMPND_7134 2 @IMPND_7197 3 @IMPND_7264 -1 @IMPND_7394 -1 @IMPND_7394 -1 @IMPND_7394 

:IMPND_6954
if 
  " + tmp_10549 + @"[0] == 0 
else_jump @IMPND_7127 
if 
09C3:   police_car_in_rectangle_cornerA -1566.137 666.7503 5.775 cornerB -1577.602 658.2418 9.2455 
else_jump @IMPND_7127 
if 
   not Actor.Dead(" + tmp_10516 + @"[0])
else_jump @IMPND_7127 
if 
00A3:   actor " + tmp_10516 + @"[0] sphere 0 in_rectangle_cornerA -1573.406 656.8607 cornerB -1572.033 658.196 
else_jump @IMPND_7076 
" + _10730 + @" = 1 

:IMPND_7076
if 
  " + _10524 + @" == 0 
else_jump @IMPND_7127 
if 
  20@ == 0 
else_jump @IMPND_7127 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[0] 

:IMPND_7127
jump @IMPND_7394 

:IMPND_7134
" + _10734 + @" += 0.5 
0453: set_object 9@ XYZ_rotation " + _10734 + @" 0.0 0.0 
if 
  " + _10734 + @" >= 0.0 
else_jump @IMPND_7190 
" + _10730 + @" = 2 

:IMPND_7190
jump @IMPND_7394 

:IMPND_7197
if 
8339:   not anything_in_cube_cornerA -1566.137 666.7503 5.775 cornerB -1577.602 658.2418 9.2455 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_7257 
" + _10730 + @" = 3 

:IMPND_7257
jump @IMPND_7394 

:IMPND_7264
if 
0339:   anything_in_cube_cornerA -1566.137 666.7503 5.775 cornerB -1577.602 658.2418 9.2455 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_7331 
" + _10730 + @" = 1 
jump @IMPND_7387 

:IMPND_7331
" + _10734 + @" -= 0.5 
0453: set_object 9@ XYZ_rotation " + _10734 + @" 0.0 0.0 
if 
  -90.0 >= " + _10734 + @" 
else_jump @IMPND_7387 
" + _10730 + @" = 0 

:IMPND_7387
jump @IMPND_7394 

:IMPND_7394
0871: init_jump_table " + _10731 + @" total_jumps 4 default_jump 0 @IMPND_7897 jumps 0 @IMPND_7457 1 @IMPND_7637 2 @IMPND_7700 3 @IMPND_7767 -1 @IMPND_7897 -1 @IMPND_7897 -1 @IMPND_7897 

:IMPND_7457
if 
  " + tmp_10549 + @"[1] == 0 
else_jump @IMPND_7630 
if 
09C3:   police_car_in_rectangle_cornerA -1688.231 679.8141 20.5924 cornerB -1710.483 687.937 28.4141 
else_jump @IMPND_7630 
if 
   not Actor.Dead(" + tmp_10516 + @"[1])
else_jump @IMPND_7630 
if 
00A3:   actor " + tmp_10516 + @"[1] sphere 0 in_rectangle_cornerA -1701.648 689.5652 cornerB -1700.086 688.274 
else_jump @IMPND_7579 
" + _10731 + @" = 1 

:IMPND_7579
if 
  " + _10524 + @" == 0 
else_jump @IMPND_7630 
if 
  20@ == 0 
else_jump @IMPND_7630 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[1] 

:IMPND_7630
jump @IMPND_7897 

:IMPND_7637
" + _10735 + @" += 0.5 
0453: set_object 10@ XYZ_rotation " + _10735 + @" 0.0 180.0 
if 
  " + _10735 + @" >= 0.0 
else_jump @IMPND_7693 
" + _10731 + @" = 2 

:IMPND_7693
jump @IMPND_7897 

:IMPND_7700
if 
8339:   not anything_in_cube_cornerA -1688.231 679.8141 20.5924 cornerB -1710.483 687.937 28.4141 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_7760 
" + _10731 + @" = 3 

:IMPND_7760
jump @IMPND_7897 

:IMPND_7767
if 
0339:   anything_in_cube_cornerA -1688.231 679.8141 20.5924 cornerB -1710.483 687.937 28.4141 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_7834 
" + _10731 + @" = 1 
jump @IMPND_7890 

:IMPND_7834
" + _10735 + @" -= 0.5 
0453: set_object 10@ XYZ_rotation " + _10735 + @" 0.0 180.0 
if 
  -90.0 >= " + _10735 + @" 
else_jump @IMPND_7890 
" + _10731 + @" = 0 

:IMPND_7890
jump @IMPND_7897 

:IMPND_7897
0871: init_jump_table " + _10732 + @" total_jumps 4 default_jump 0 @IMPND_8639 jumps 0 @IMPND_7960 1 @IMPND_8312 2 @IMPND_8403 3 @IMPND_8478 -1 @IMPND_8639 -1 @IMPND_8639 -1 @IMPND_8639 

:IMPND_7960
if 
  " + _10713 + @" == 1 
else_jump @IMPND_8159 
if 
09C3:   police_car_in_rectangle_cornerA -1639.599 674.9066 10.3898 cornerB -1622.298 710.0969 0.8401 
else_jump @IMPND_8159 
if 
  " + tmp_10549 + @"[2] == 0 
else_jump @IMPND_8159 
if 
   not Actor.Dead(" + tmp_10516 + @"[2])
else_jump @IMPND_8159 
if 
00A3:   actor " + tmp_10516 + @"[2] sphere 0 in_rectangle_cornerA -1613.253 679.4489 cornerB -1618.76 688.0851 
else_jump @IMPND_8159 
" + _10732 + @" = 1 
097B: play_audio_at_object 6@ event 1153 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_8159 
if 
  20@ == 0 
else_jump @IMPND_8159 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[2] 

:IMPND_8159
if 
  " + _10557 + @" == 1 
else_jump @IMPND_8245 
if 
0339:   anything_in_cube_cornerA -1639.599 674.9066 10.3898 cornerB -1622.298 710.0969 0.8401 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_8245 
" + _10732 + @" = 1 
097B: play_audio_at_object 6@ event 1153 

:IMPND_8245
if 
0339:   anything_in_cube_cornerA -1620.061 715.371 -4.554 cornerB -1640.881 691.9899 11.1863 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_8305 
" + _10732 + @" = 1 

:IMPND_8305
jump @IMPND_8639 

:IMPND_8312
Object.StorePos(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
" + _10740 + @" += 0.0155 
if 
  " + _10740 + @" >= 13.2513 
else_jump @IMPND_8382 
" + _10732 + @" = 2 
" + _10740 + @" = 13.2513 
097B: play_audio_at_object 6@ event 1154 

:IMPND_8382
Object.PutAt(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
jump @IMPND_8639 

:IMPND_8403
if 
8339:   not anything_in_cube_cornerA -1639.599 674.9066 10.3898 cornerB -1622.298 710.0969 0.8401 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_8471 
" + _10732 + @" = 3 
097B: play_audio_at_object 6@ event 1153 

:IMPND_8471
jump @IMPND_8639 

:IMPND_8478
Object.StorePos(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
" + _10740 + @" -= 0.0155 
if 
  8.5436 >= " + _10740 + @" 
else_jump @IMPND_8558 
" + _10732 + @" = 0 
" + _10736 + @" = 0.0 
" + _10740 + @" = 8.5436 
097B: play_audio_at_object 6@ event 1154 

:IMPND_8558
Object.PutAt(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
if 
0339:   anything_in_cube_cornerA -1639.599 674.9066 10.3898 cornerB -1622.298 710.0969 0.8401 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_8632 
" + _10732 + @" = 1 

:IMPND_8632
jump @IMPND_8639 

:IMPND_8639
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_10478 
0871: init_jump_table " + _10730 + @" total_jumps 4 default_jump 0 @IMPND_9276 jumps 0 @IMPND_8720 1 @IMPND_9016 2 @IMPND_9079 3 @IMPND_9146 -1 @IMPND_9276 -1 @IMPND_9276 -1 @IMPND_9276 

:IMPND_8720
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @IMPND_8930 
if 
   Actor.DrivingPoliceVehicle(" + PlayerActor + @")
else_jump @IMPND_8930 
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2250.323 2449.556 8.4616 cornerB 2230.411 2461.791 17.8394 
else_jump @IMPND_8930 
if 
  " + tmp_10549 + @"[0] == 0 
else_jump @IMPND_8930 
if 
   not Actor.Dead(" + tmp_10516 + @"[0])
else_jump @IMPND_8930 
if 
00A3:   actor " + tmp_10516 + @"[0] sphere 0 in_rectangle_cornerA 2237.854 2448.608 cornerB 2239.385 2450.014 
else_jump @IMPND_8930 
" + _10730 + @" = 1 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_8930 
if 
  20@ == 0 
else_jump @IMPND_8930 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[0] 

:IMPND_8930
if 
  " + _10557 + @" == 1 
else_jump @IMPND_9009 
if 
   not Car.Wrecked(" + tmp_10725 + @"[0])
else_jump @IMPND_9009 
if 
00B0:   car " + tmp_10725 + @"[0] sphere 0 in_rectangle_cornerA 2222.316 2432.012 cornerB 2246.956 2467.653 
else_jump @IMPND_9009 
" + _10730 + @" = 1 

:IMPND_9009
jump @IMPND_9276 

:IMPND_9016
" + _10734 + @" += 0.5 
0453: set_object 9@ XYZ_rotation " + _10734 + @" 0.0 0.0 
if 
  " + _10734 + @" >= 0.0 
else_jump @IMPND_9072 
" + _10730 + @" = 2 

:IMPND_9072
jump @IMPND_9276 

:IMPND_9079
if 
8339:   not anything_in_cube_cornerA 2250.323 2449.556 8.4616 cornerB 2230.411 2461.791 17.8394 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_9139 
" + _10730 + @" = 3 

:IMPND_9139
jump @IMPND_9276 

:IMPND_9146
if 
0339:   anything_in_cube_cornerA 2250.323 2449.556 8.4616 cornerB 2230.411 2461.791 17.8394 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_9213 
" + _10730 + @" = 1 
jump @IMPND_9269 

:IMPND_9213
" + _10734 + @" -= 0.5 
0453: set_object 9@ XYZ_rotation " + _10734 + @" 0.0 0.0 
if 
  -90.0 >= " + _10734 + @" 
else_jump @IMPND_9269 
" + _10730 + @" = 0 

:IMPND_9269
jump @IMPND_9276 

:IMPND_9276
0871: init_jump_table " + _10732 + @" total_jumps 4 default_jump 0 @IMPND_9995 jumps 0 @IMPND_9339 1 @IMPND_9668 2 @IMPND_9759 3 @IMPND_9834 -1 @IMPND_9995 -1 @IMPND_9995 -1 @IMPND_9995 

:IMPND_9339
if 
  " + _10713 + @" == 1 
else_jump @IMPND_9575 
if 
   Actor.Driving(" + PlayerActor + @")
else_jump @IMPND_9575 
if 
   Actor.DrivingPoliceVehicle(" + PlayerActor + @")
else_jump @IMPND_9575 
if 
00A4:   actor " + PlayerActor + @" sphere 0 in_cube_cornerA 2237.808 2486.764 12.7579 cornerB 2280.211 2502.595 6.2211 
else_jump @IMPND_9575 
if 
  " + tmp_10549 + @"[2] == 0 
else_jump @IMPND_9575 
if 
   not Actor.Dead(" + tmp_10516 + @"[2])
else_jump @IMPND_9575 
if 
00A3:   actor " + tmp_10516 + @"[2] sphere 0 in_rectangle_cornerA 2253.515 2485.275 cornerB 2248.9 2492.416 
else_jump @IMPND_9575 
" + _10732 + @" = 1 
097B: play_audio_at_object 6@ event 1153 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_9575 
if 
  20@ == 0 
else_jump @IMPND_9575 
20@ = 1 
008B: 19@ = " + tmp_10516 + @"[2] 

:IMPND_9575
if 
  " + _10557 + @" == 1 
else_jump @IMPND_9661 
if 
0339:   anything_in_cube_cornerA 2294.371 2493.447 6.6617 cornerB 2305.78 2504.33 2.1808 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_9661 
" + _10732 + @" = 1 
097B: play_audio_at_object 6@ event 1153 

:IMPND_9661
jump @IMPND_9995 

:IMPND_9668
Object.StorePos(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
" + _10740 + @" += 0.0155 
if 
  " + _10740 + @" >= 8.8513 
else_jump @IMPND_9738 
" + _10732 + @" = 2 
" + _10740 + @" = 8.8513 
097B: play_audio_at_object 6@ event 1154 

:IMPND_9738
Object.PutAt(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
jump @IMPND_9995 

:IMPND_9759
if 
8339:   not anything_in_cube_cornerA 2286.148 2503.084 7.8689 cornerB 2302.432 2491.353 1.8459 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_9827 
" + _10732 + @" = 3 
097B: play_audio_at_object 6@ event 1153 

:IMPND_9827
jump @IMPND_9995 

:IMPND_9834
Object.StorePos(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
" + _10740 + @" -= 0.0155 
if 
  4.4414 >= " + _10740 + @" 
else_jump @IMPND_9914 
" + _10732 + @" = 0 
" + _10736 + @" = 0.0 
" + _10740 + @" = 4.4414 
097B: play_audio_at_object 6@ event 1154 

:IMPND_9914
Object.PutAt(6@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10740 + @")
if 
0339:   anything_in_cube_cornerA 2286.148 2503.084 7.8689 cornerB 2302.432 2491.353 1.8459 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_9988 
" + _10732 + @" = 1 

:IMPND_9988
jump @IMPND_9995 

:IMPND_9995
0871: init_jump_table " + _10733 + @" total_jumps 4 default_jump 0 @IMPND_10478 jumps 0 @IMPND_10058 1 @IMPND_10151 2 @IMPND_10242 3 @IMPND_10317 -1 @IMPND_10478 -1 @IMPND_10478 -1 @IMPND_10478 

:IMPND_10058
if 
  " + _10713 + @" == 1 
else_jump @IMPND_10144 
if 
0339:   anything_in_cube_cornerA 2333.481 2439.576 8.8878 cornerB 2319.688 2452.0 2.1724 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_10144 
" + _10733 + @" = 1 
097B: play_audio_at_object 7@ event 1153 

:IMPND_10144
jump @IMPND_10478 

:IMPND_10151
Object.StorePos(7@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10741 + @")
" + _10741 + @" += 0.0155 
if 
  " + _10741 + @" >= 11.6441 
else_jump @IMPND_10221 
" + _10733 + @" = 2 
" + _10741 + @" = 11.6441 
097B: play_audio_at_object 7@ event 1154 

:IMPND_10221
Object.PutAt(7@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10741 + @")
jump @IMPND_10478 

:IMPND_10242
if 
8339:   not anything_in_cube_cornerA 2338.707 2434.458 11.8518 cornerB 2330.938 2452.455 3.5886 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_10310 
" + _10733 + @" = 3 
097B: play_audio_at_object 7@ event 1153 

:IMPND_10310
jump @IMPND_10478 

:IMPND_10317
Object.StorePos(7@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10741 + @")
" + _10741 + @" -= 0.0155 
if 
  6.9743 >= " + _10741 + @" 
else_jump @IMPND_10397 
" + _10733 + @" = 0 
" + _10737 + @" = 0.0 
" + _10741 + @" = 6.9743 
097B: play_audio_at_object 6@ event 1154 

:IMPND_10397
Object.PutAt(7@, " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + _10741 + @")
if 
0339:   anything_in_cube_cornerA 2338.707 2434.458 11.8518 cornerB 2330.938 2452.455 3.5886 solid 0 car 1 actor 0 object 0 particle 0 
else_jump @IMPND_10471 
" + _10733 + @" = 1 

:IMPND_10471
jump @IMPND_10478 

:IMPND_10478
return 

:IMPND_10480
0871: init_jump_table 13@ total_jumps 7 default_jump 0 @IMPND_12863 jumps 1 @IMPND_12316 2 @IMPND_10853 3 @IMPND_11228 4 @IMPND_11920 5 @IMPND_10543 6 @IMPND_12714 9 @IMPND_11530 

:IMPND_10543
gosub @IMPND_12865 
if and
  " + _10714 + @" == 1 
  " + _10713 + @" == 1 
else_jump @IMPND_10597 
" + tmp_10525 + @"(12@,8i) = 2 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_10597
if 
  " + tmp_10716 + @"(12@,8i) == -2 
else_jump @IMPND_10707 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0086: " + _10712 + @" = " + tempvar_Z_coord + @" 
0061: " + _10712 + @" -= " + tempvar_Float_3 + @" 
if 
  3.0 > " + _10712 + @" 
else_jump @IMPND_10707 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_10707
if 
  " + tmp_10716 + @"(12@,8i) == -1 
else_jump @IMPND_10806 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
0086: " + _10712 + @" = " + tempvar_Z_coord + @" 
0061: " + _10712 + @" -= " + tempvar_Float_3 + @" 
if 
  3.0 > " + _10712 + @" 
else_jump @IMPND_10806 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_10806
if 
  " + _10524 + @" == 1 
else_jump @IMPND_10846 
" + tmp_10525 + @"(12@,8i) = 6 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_10846
jump @IMPND_12863 

:IMPND_10853
gosub @IMPND_19919 
if 
  23@ == 0 
else_jump @IMPND_11166 
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_11012 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_10955 
if 
  20@ == 0 
else_jump @IMPND_10955 
008B: 19@ = " + tmp_10516 + @"(12@,8i) 
20@ = 4 

:IMPND_10955
07A3: AS_actor " + tmp_10516 + @"(12@,8i) run_to_and_follow_actor " + PlayerActor + @" wait_radius_between 5.0 and 10.0 
008A: " + tmp_10541 + @"(12@,8i) = 32@ 
" + tmp_10541 + @"(12@,8i) += 6000 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_11012
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_11166 
if 
001F:   32@ > " + tmp_10541 + @"(12@,8i) 
else_jump @IMPND_11166 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_11133 
if 
  20@ == 0 
else_jump @IMPND_11126 
" + tmp_10525 + @"(12@,8i) = 1 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11126
jump @IMPND_11166 

:IMPND_11133
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11166
if 
  " + tmp_10716 + @"(12@,8i) == -2 
else_jump @IMPND_11221 
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11221
jump @IMPND_12863 

:IMPND_11228
gosub @IMPND_19919 
if 
  23@ == 0 
else_jump @IMPND_11476 
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_11322 
008A: " + tmp_10541 + @"(12@,8i) = 32@ 
" + tmp_10541 + @"(12@,8i) += 7000 
05E2: AS_actor " + tmp_10516 + @"(12@,8i) kill_actor " + PlayerActor + @" 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_11322
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_11476 
if 
001F:   32@ > " + tmp_10541 + @"(12@,8i) 
else_jump @IMPND_11476 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_11443 
if 
  20@ == 0 
else_jump @IMPND_11436 
" + tmp_10525 + @"(12@,8i) = 1 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11436
jump @IMPND_11476 

:IMPND_11443
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11476
if 
  " + _10714 + @" == 0 
else_jump @IMPND_11523 
" + _10724 + @" += 1 
" + tmp_10525 + @"(12@,8i) = 4 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11523
jump @IMPND_12863 

:IMPND_11530
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_11617 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_11617 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at " + _10743 + @" " + _10744 + @" " + _10745 + @" 5000 ms 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_11617
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_11760 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_11760 
if 
  " + tmp_10549 + @"(12@,8i) == 0 
else_jump @IMPND_11716 
" + tmp_10525 + @"(12@,8i) = 8 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11716
if 
  " + tmp_10549 + @"(12@,8i) == 1 
else_jump @IMPND_11760 
" + tmp_10525 + @"(12@,8i) = 6 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11760
if and
  " + _10714 + @" == 1 
  " + _10713 + @" == 1 
else_jump @IMPND_11858 
if 
  " + tmp_10549 + @"(12@,8i) == 0 
else_jump @IMPND_11836 
" + tmp_10525 + @"(12@,8i) = 2 
" + tmp_10533 + @"(12@,8i) = 0 
jump @IMPND_11858 

:IMPND_11836
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11858
if 
  " + tmp_10716 + @"(12@,8i) == -2 
else_jump @IMPND_11913 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10549 + @"(12@,8i) = 1 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_11913
jump @IMPND_12863 

:IMPND_11920
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_12019 
gosub @IMPND_19919 
if 
  23@ == 0 
else_jump @IMPND_12008 
06C2: AS_actor " + tmp_10516 + @"(12@,8i) goto " + _10743 + @" " + _10744 + @" " + _10745 + @" mode 6 turn_radius 1.0 stop_radius 5.0 actor -1 with_offset " + _10743 + @" " + _10744 + @" " + _10745 + @" 

:IMPND_12008
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_12019
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_12097 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1730 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_12097 
05B9: AS_actor " + tmp_10516 + @"(12@,8i) stay_idle 2000 ms 
" + tmp_10533 + @"(12@,8i) = 2 

:IMPND_12097
if 
  " + tmp_10533 + @"(12@,8i) == 2 
else_jump @IMPND_12174 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1465 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_12174 
" + tmp_10525 + @"(12@,8i) = 6 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12174
if and
  " + _10714 + @" == 1 
  " + _10713 + @" == 1 
else_jump @IMPND_12221 
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12221
if 
  " + tmp_10716 + @"(12@,8i) == -2 
else_jump @IMPND_12265 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12265
if 
  " + tmp_10716 + @"(12@,8i) == -1 
else_jump @IMPND_12309 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12309
jump @IMPND_12863 

:IMPND_12316
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_12437 
if 
  20@ == 0 
else_jump @IMPND_12437 
0792: disembark_instantly_actor " + tmp_10516 + @"(12@,8i) 
0812: AS_actor " + tmp_10516 + @"(12@,8i) perform_animation ""PHONE_TALK"" IFP ""PED"" framedelta 4.0 loopA 1 lockX 0 lockY 0 lockF 0 time 4000 
20@ = 5 
008B: 19@ = " + tmp_10516 + @"(12@,8i) 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_12437
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_12707 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 2066 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_12707 
if 
  " + _10524 + @" == 0 
else_jump @IMPND_12685 
" + _10524 + @" = 1 
if 
   not Actor.Dead(24@)
else_jump @IMPND_12545 
Actor.LockInCurrentPosition(24@) = False
05C3: AS_actor 24@ hands_cower 

:IMPND_12545
040D: unload_wav 4 
03CF: load_wav 41800 as 4 
" + tmp_10549 + @"[0] = 1 
" + tmp_10549 + @"[1] = 1 
" + tmp_10549 + @"[2] = 1 
" + tmp_10549 + @"[3] = 1 
" + tmp_10549 + @"[4] = 1 
" + tmp_10549 + @"[5] = 1 
" + tmp_10549 + @"[6] = 1 
" + tmp_10549 + @"[7] = 1 
if 
   not Actor.Dead(" + tmp_10516 + @"[1])
else_jump @IMPND_12637 
01B9: set_actor " + tmp_10516 + @"[1] armed_weapon_to 22 

:IMPND_12637
if 
   not Actor.Dead(" + tmp_10516 + @"[6])
else_jump @IMPND_12660 
01B9: set_actor " + tmp_10516 + @"[6] armed_weapon_to 22 

:IMPND_12660
if 
  " + OnMission + @" == 0 
else_jump @IMPND_12685 
Player.SetMinWantedLevel(" + PlayerChar + @", 3)

:IMPND_12685
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12707
jump @IMPND_12863 

:IMPND_12714
gosub @IMPND_15737 
if and
  " + _10714 + @" == 1 
  " + _10713 + @" == 1 
else_jump @IMPND_12768 
" + tmp_10525 + @"(12@,8i) = 3 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12768
if 
  " + tmp_10716 + @"(12@,8i) == -2 
else_jump @IMPND_12812 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12812
if 
  " + tmp_10716 + @"(12@,8i) == -1 
else_jump @IMPND_12856 
" + tmp_10525 + @"(12@,8i) = 9 
" + tmp_10533 + @"(12@,8i) = 0 

:IMPND_12856
jump @IMPND_12863 

:IMPND_12863
return 

:IMPND_12865
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_13978 
if 
  " + _10713 + @" == 1 
else_jump @IMPND_13630 
if 
  " + _10729 + @" == 1 
else_jump @IMPND_13630 
if 
  12.0 > " + tempvar_Z_coord + @" 
else_jump @IMPND_13630 
" + _10557 + @" = 1 
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_13630 
if 
  12@ == 3 
else_jump @IMPND_13102 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 1583.321 -1691.575 5.2252 
05D7: add_point_to_scmpath 1555.105 -1692.137 5.2252 
05D7: add_point_to_scmpath 1526.534 -1676.968 4.8984 
0615: define_AS_pack_begin " + _10715 + @" 
05B9: AS_actor -1 stay_idle 3500 ms 
0633: AS_actor -1 exit_car 
05B9: AS_actor -1 stay_idle 700 ms 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
05D4: AS_actor -1 rotate_angle 63.3988 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 

:IMPND_13102
if 
  12@ == 4 
else_jump @IMPND_13238 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 1582.722 -1669.56 4.8942 
05D7: add_point_to_scmpath 1581.765 -1690.743 5.2187 
05D7: add_point_to_scmpath 1556.016 -1690.699 5.2252 
05D7: add_point_to_scmpath 1525.97 -1674.655 4.8984 
0615: define_AS_pack_begin " + _10715 + @" 
0633: AS_actor -1 exit_car 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
05D4: AS_actor -1 rotate_angle 92.6125 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 

:IMPND_13238
if 
  12@ == 5 
else_jump @IMPND_13493 
0615: define_AS_pack_begin " + _10742 + @" 
if 
   not Car.Wrecked(" + tmp_10725 + @"[2])
else_jump @IMPND_13350 
05D1: AS_actor -1 drive_car " + tmp_10725 + @"[2] to 1589.878 -1644.143 11.2316 speed 10.0 1 model #NULL 0 
05B9: AS_actor -1 stay_idle 2000 ms 
05D1: AS_actor -1 drive_car " + tmp_10725 + @"[2] to 1549.443 -1627.994 12.3905 speed 10.0 1 model #NULL 0 

:IMPND_13350
0616: define_AS_pack_end " + _10742 + @" 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 1567.392 -1706.847 4.8984 
05D7: add_point_to_scmpath 1566.885 -1710.162 4.8984 
0615: define_AS_pack_begin " + _10715 + @" 
05B9: AS_actor -1 stay_idle 10000 ms 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
if 
   not Car.Wrecked(" + tmp_10725 + @"[2])
else_jump @IMPND_13455 
05CB: AS_actor -1 enter_car " + tmp_10725 + @"[2] as_driver -1 ms 
06C7: AS_actor -1 driver_of_car " + tmp_10725 + @"[2] perform_action 14 timelimit 1000 
0618: assign_actor -1 to_AS_pack " + _10742 + @" 

:IMPND_13455
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10742 + @" 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_13493
if 
  12@ == 6 
else_jump @IMPND_13578 
0376: 24@ = create_random_actor_at 1610.446 -1720.474 5.2252 
Actor.Angle(24@) = 45.0
05C4: AS_actor 24@ hands_up -2 ms 
Actor.LockInCurrentPosition(24@) = True
01B9: set_actor " + tmp_10516 + @"(12@,8i) armed_weapon_to 0 
05E2: AS_actor " + tmp_10516 + @"(12@,8i) kill_actor 24@ 

:IMPND_13578
if 
  12@ == 7 
else_jump @IMPND_13619 
if 
   not Car.Wrecked(" + tmp_10725 + @"[3])
else_jump @IMPND_13619 
0657: car " + tmp_10725 + @"[3] open_door 0 

:IMPND_13619
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_13630
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_13978 
if 
  12@ == 5 
else_jump @IMPND_13853 
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_13853 
if 
   not Actor.Dead(" + tmp_10516 + @"[5])
else_jump @IMPND_13853 
062E: get_actor " + tmp_10516 + @"(12@,8i) task -1 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_13853 
if 
0100:   actor " + tmp_10516 + @"(12@,8i) in_sphere 2242.173 2461.965 9.8203 radius 4.0 4.0 4.0 sphere 0 in_car 
else_jump @IMPND_13853 
Actor.RemoveReferences(" + tmp_10516 + @"[5])
Car.RemoveReferences(" + tmp_10725 + @"[1])
if 
  " + _10734 + @" > -25.0 
else_jump @IMPND_13853 
05D2: AS_actor " + tmp_10516 + @"(12@,8i) run_to_and_hijack_car " + tmp_10725 + @"[1] max_search_radius 20.0 traffic_behavior 0 
" + tmp_10533 + @"(12@,8i) = 2 

:IMPND_13853
if 
  12@ == 6 
else_jump @IMPND_13978 
if 
   not Actor.Dead(24@)
else_jump @IMPND_13978 
Actor.Health(24@) = 100
062E: get_actor 24@ task 1476 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_13978 
05C4: AS_actor 24@ hands_up -2 ms 
if 
   not Actor.Dead(" + tmp_10516 + @"[1])
else_jump @IMPND_13978 
0605: actor " + tmp_10516 + @"[1] perform_animation ""FUCKU"" IFP ""PED"" framedelta 4.0 loop 0 lockX 0 lockY 0 lockF 0 time -2 

:IMPND_13978
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_14838 
if 
  " + _10729 + @" == 1 
else_jump @IMPND_14838 
if 
  -0.7114 > " + tempvar_Z_coord + @" 
else_jump @IMPND_14633 
" + _10557 + @" = 1 
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_14633 
if 
  12@ == 3 
else_jump @IMPND_14190 
05D6: clear_scmpath 
05D7: add_point_to_scmpath -1601.988 744.1652 -6.2422 
05D7: add_point_to_scmpath -1593.343 729.7554 -5.9062 
05D7: add_point_to_scmpath -1593.44 718.5184 -6.2344 
0615: define_AS_pack_begin " + _10715 + @" 
05B9: AS_actor -1 stay_idle 1000 ms 
0633: AS_actor -1 exit_car 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
05D4: AS_actor -1 rotate_angle 146.3988 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 

:IMPND_14190
if 
  12@ == 4 
else_jump @IMPND_14292 
05D6: clear_scmpath 
05D7: add_point_to_scmpath -1592.119 729.1914 -5.9062 
05D7: add_point_to_scmpath -1592.753 715.295 -6.2344 
0615: define_AS_pack_begin " + _10715 + @" 
0633: AS_actor -1 exit_car 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
05D4: AS_actor -1 rotate_angle 103.6125 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 

:IMPND_14292
if 
  12@ == 5 
else_jump @IMPND_14581 
0615: define_AS_pack_begin " + _10742 + @" 
if 
   not Car.Wrecked(" + tmp_10725 + @"[3])
else_jump @IMPND_14404 
05D1: AS_actor -1 drive_car " + tmp_10725 + @"[3] to -1629.925 694.9102 5.8578 speed 10.0 1 model #NULL 0 
05B9: AS_actor -1 stay_idle 8000 ms 
05D1: AS_actor -1 drive_car " + tmp_10725 + @"[3] to -1578.795 662.8546 6.1874 speed 10.0 1 model #NULL 0 

:IMPND_14404
0616: define_AS_pack_end " + _10742 + @" 
05D6: clear_scmpath 
05D7: add_point_to_scmpath -1595.711 698.4703 -5.9062 
05D7: add_point_to_scmpath -1587.208 701.9536 -5.914 
05D7: add_point_to_scmpath -1577.201 720.1028 -6.2344 
05D7: add_point_to_scmpath -1574.414 720.1995 -6.2344 
0615: define_AS_pack_begin " + _10715 + @" 
05B9: AS_actor -1 stay_idle 10000 ms 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
if 
   not Car.Wrecked(" + tmp_10725 + @"[3])
else_jump @IMPND_14543 
05CB: AS_actor -1 enter_car " + tmp_10725 + @"[3] as_driver -1 ms 
06C7: AS_actor -1 driver_of_car " + tmp_10725 + @"[3] perform_action 14 timelimit 1000 
0618: assign_actor -1 to_AS_pack " + _10742 + @" 

:IMPND_14543
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10742 + @" 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_14581
if 
  12@ == 6 
else_jump @IMPND_14622 
if 
   not Car.Wrecked(" + tmp_10725 + @"[1])
else_jump @IMPND_14622 
0657: car " + tmp_10725 + @"[1] open_door 0 

:IMPND_14622
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_14633
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_14838 
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_14827 
if 
   not Actor.Dead(" + tmp_10516 + @"[5])
else_jump @IMPND_14827 
062E: get_actor " + tmp_10516 + @"(12@,8i) task -1 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_14827 
if 
0100:   actor " + tmp_10516 + @"(12@,8i) in_sphere 2242.173 2461.965 9.8203 radius 4.0 4.0 4.0 sphere 0 in_car 
else_jump @IMPND_14827 
Actor.RemoveReferences(" + tmp_10516 + @"[5])
Car.RemoveReferences(" + tmp_10725 + @"[1])
if 
  " + _10734 + @" > -25.0 
else_jump @IMPND_14827 
05D2: AS_actor " + tmp_10516 + @"(12@,8i) run_to_and_hijack_car " + tmp_10725 + @"[1] max_search_radius 20.0 traffic_behavior 0 

:IMPND_14827
" + tmp_10533 + @"(12@,8i) = 2 

:IMPND_14838
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_15735 
if 
  " + _10729 + @" == 1 
else_jump @IMPND_15735 
if and
  4.3 > " + tempvar_Z_coord + @" 
  " + tempvar_X_coord + @" > 2292.0 
else_jump @IMPND_15530 
" + _10557 + @" = 1 
if 
  " + tmp_10533 + @"(12@,8i) == 0 
else_jump @IMPND_15530 
if 
  12@ == 3 
else_jump @IMPND_15094 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 2292.413 2466.859 2.5313 
05D7: add_point_to_scmpath 2292.549 2448.623 2.5313 
05D7: add_point_to_scmpath 2290.439 2446.945 2.5313 
05D7: add_point_to_scmpath 2271.247 2446.799 2.5313 
05D7: add_point_to_scmpath 2266.618 2449.154 2.5313 
0615: define_AS_pack_begin " + _10715 + @" 
05B9: AS_actor -1 stay_idle 1000 ms 
0633: AS_actor -1 exit_car 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
05D4: AS_actor -1 rotate_angle 337.3988 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 

:IMPND_15094
if 
  12@ == 4 
else_jump @IMPND_15230 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 2283.378 2469.562 2.5313 
05D7: add_point_to_scmpath 2290.223 2466.888 2.5313 
05D7: add_point_to_scmpath 2290.487 2449.401 2.5313 
05D7: add_point_to_scmpath 2269.623 2448.8 2.5313 
0615: define_AS_pack_begin " + _10715 + @" 
0633: AS_actor -1 exit_car 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
05D4: AS_actor -1 rotate_angle 25.6125 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 

:IMPND_15230
if 
  12@ == 5 
else_jump @IMPND_15519 
0615: define_AS_pack_begin " + _10742 + @" 
if 
   not Car.Wrecked(" + tmp_10725 + @"[1])
else_jump @IMPND_15342 
05D1: AS_actor -1 drive_car " + tmp_10725 + @"[1] to 2300.103 2494.479 2.266 speed 10.0 1 model #NULL 0 
05B9: AS_actor -1 stay_idle 8000 ms 
05D1: AS_actor -1 drive_car " + tmp_10725 + @"[1] to 2242.173 2461.965 9.8203 speed 10.0 1 model #NULL 0 

:IMPND_15342
0616: define_AS_pack_end " + _10742 + @" 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 2258.914 2447.821 2.5313 
05D7: add_point_to_scmpath 2258.346 2467.58 2.5313 
05D7: add_point_to_scmpath 2298.069 2467.792 2.266 
05D7: add_point_to_scmpath 2313.553 2474.045 2.266 
0615: define_AS_pack_begin " + _10715 + @" 
05B9: AS_actor -1 stay_idle 10000 ms 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
if 
   not Car.Wrecked(" + tmp_10725 + @"[1])
else_jump @IMPND_15481 
05CB: AS_actor -1 enter_car " + tmp_10725 + @"[1] as_driver -1 ms 
06C7: AS_actor -1 driver_of_car " + tmp_10725 + @"[1] perform_action 14 timelimit 1000 
0618: assign_actor -1 to_AS_pack " + _10742 + @" 

:IMPND_15481
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10742 + @" 
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_15519
" + tmp_10533 + @"(12@,8i) = 1 

:IMPND_15530
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_15735 
if 
  " + tmp_10533 + @"(12@,8i) == 1 
else_jump @IMPND_15724 
if 
   not Actor.Dead(" + tmp_10516 + @"[5])
else_jump @IMPND_15724 
062E: get_actor " + tmp_10516 + @"(12@,8i) task -1 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_15724 
if 
0100:   actor " + tmp_10516 + @"(12@,8i) in_sphere 2242.173 2461.965 9.8203 radius 4.0 4.0 4.0 sphere 0 in_car 
else_jump @IMPND_15724 
Actor.RemoveReferences(" + tmp_10516 + @"[5])
Car.RemoveReferences(" + tmp_10725 + @"[1])
if 
  " + _10734 + @" > -25.0 
else_jump @IMPND_15724 
05D2: AS_actor " + tmp_10516 + @"(12@,8i) run_to_and_hijack_car " + tmp_10725 + @"[1] max_search_radius 20.0 traffic_behavior 0 

:IMPND_15724
" + tmp_10533 + @"(12@,8i) = 2 

:IMPND_15735
return 

:IMPND_15737
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_16699 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
  " + tempvar_Float_3 + @" > 16.3914 
else_jump @IMPND_16011 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 1553.0 -1627.837 12.3905 radius 5.0 5.0 5.0 
else_jump @IMPND_15923 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_15916 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 1553.0 -1627.837 12.3905 mode 6 time -2 ms 

:IMPND_15916
jump @IMPND_16004 

:IMPND_15923
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16004 
if 
  " + _10745 + @" > 15.0 
else_jump @IMPND_16004 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 1566.329 -1628.917 13.7858 8000 ms 

:IMPND_16004
jump @IMPND_16699 

:IMPND_16011
if and
  " + tempvar_Float_1 + @" > 1580.82 
  " + tempvar_Float_2 + @" > -1678.518 
else_jump @IMPND_16293 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 1596.388 -1665.798 4.8604 radius 5.0 5.0 5.0 
else_jump @IMPND_16171 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16164 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 1596.388 -1665.798 4.8604 mode 6 time -2 ms 

:IMPND_16164
jump @IMPND_16286 

:IMPND_16171
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16286 
if 
  " + _10745 + @" > 10.5 
else_jump @IMPND_16259 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 1588.92 -1643.827 13.2958 8000 ms 
jump @IMPND_16286 

:IMPND_16259
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 1551.462 -1625.453 12.3905 8000 ms 

:IMPND_16286
jump @IMPND_16699 

:IMPND_16293
if 
  " + tempvar_Float_1 + @" > 1565.101 
else_jump @IMPND_16510 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 1593.21 -1702.36 4.897 radius 5.0 5.0 5.0 
else_jump @IMPND_16443 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16436 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 1593.21 -1702.36 4.897 mode 6 time -2 ms 

:IMPND_16436
jump @IMPND_16503 

:IMPND_16443
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16503 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 1589.466 -1699.136 5.6059 8000 ms 

:IMPND_16503
jump @IMPND_16699 

:IMPND_16510
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 1542.683 -1706.747 4.8984 radius 5.0 5.0 5.0 
else_jump @IMPND_16639 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16632 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 1542.683 -1706.747 4.8984 mode 6 time -2 ms 

:IMPND_16632
jump @IMPND_16699 

:IMPND_16639
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16699 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 1550.058 -1696.444 6.4232 8000 ms 

:IMPND_16699
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_18601 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
  " + tempvar_Float_3 + @" > 1.6789 
else_jump @IMPND_17702 
if 
  -1667.059 > " + tempvar_Float_1 + @" 
else_jump @IMPND_17056 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere -1697.185 684.1302 23.01 radius 5.0 5.0 5.0 
else_jump @IMPND_16906 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_16899 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point -1697.185 684.1302 23.01 mode 6 time -2 ms 

:IMPND_16899
jump @IMPND_17049 

:IMPND_16906
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_17049 
0209: 16@ = random_int_in_ranges 0 2 
if 
  16@ == 0 
else_jump @IMPND_17011 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1706.253 683.8111 25.3122 16@ ms 
jump @IMPND_17049 

:IMPND_17011
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1685.691 683.6411 20.7149 16@ ms 

:IMPND_17049
jump @IMPND_17695 

:IMPND_17056
if 
  " + tempvar_Float_1 + @" > -1604.599 
else_jump @IMPND_17356 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere -1576.953 661.7159 6.1901 radius 5.0 5.0 5.0 
else_jump @IMPND_17206 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_17199 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point -1576.953 661.7159 6.1901 mode 6 time -2 ms 

:IMPND_17199
jump @IMPND_17349 

:IMPND_17206
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_17349 
0209: 16@ = random_int_in_ranges 0 2 
if 
  16@ == 0 
else_jump @IMPND_17311 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1584.874 663.152 7.414 16@ ms 
jump @IMPND_17349 

:IMPND_17311
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1566.207 664.1497 8.621 16@ ms 

:IMPND_17349
jump @IMPND_17695 

:IMPND_17356
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere -1629.609 683.5222 6.1901 radius 5.0 5.0 5.0 
else_jump @IMPND_17485 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_17478 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point -1629.609 683.5222 6.1901 mode 6 time -2 ms 

:IMPND_17478
jump @IMPND_17695 

:IMPND_17485
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_17695 
0209: 16@ = random_int_in_ranges 0 3 
if 
  16@ == 0 
else_jump @IMPND_17583 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1629.298 694.5806 6.6079 16@ ms 

:IMPND_17583
if 
  16@ == 1 
else_jump @IMPND_17639 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1617.505 677.6022 7.9235 16@ ms 

:IMPND_17639
if 
  16@ == 2 
else_jump @IMPND_17695 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1648.488 682.1654 10.8535 16@ ms 

:IMPND_17695
jump @IMPND_18601 

:IMPND_17702
if and
  -1598.681 > " + tempvar_Float_1 + @" 
  " + tempvar_Float_2 + @" > 707.923 
else_jump @IMPND_18005 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere -1618.067 742.9348 -6.2344 radius 5.0 5.0 5.0 
else_jump @IMPND_17862 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_17855 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point -1618.067 742.9348 -6.2344 mode 6 time -2 ms 

:IMPND_17855
jump @IMPND_18005 

:IMPND_17862
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18005 
0209: 16@ = random_int_in_ranges 0 2 
if 
  16@ == 0 
else_jump @IMPND_17967 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1627.667 738.323 -5.0193 16@ ms 
jump @IMPND_18005 

:IMPND_17967
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1601.436 739.188 -4.696 16@ ms 

:IMPND_18005
if and
  " + tempvar_Float_1 + @" > -1598.681 
  " + tempvar_Float_2 + @" > 707.923 
else_jump @IMPND_18308 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere -1581.888 738.4942 -6.2422 radius 5.0 5.0 5.0 
else_jump @IMPND_18165 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18158 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point -1581.888 738.4942 -6.2422 mode 6 time -2 ms 

:IMPND_18158
jump @IMPND_18308 

:IMPND_18165
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18308 
0209: 16@ = random_int_in_ranges 0 2 
if 
  16@ == 0 
else_jump @IMPND_18270 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1594.033 741.5932 -4.9811 16@ ms 
jump @IMPND_18308 

:IMPND_18270
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1583.25 724.5026 -5.0768 16@ ms 

:IMPND_18308
if 
  707.923 > " + tempvar_Float_2 + @" 
else_jump @IMPND_18601 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere -1591.093 688.555 -6.2422 radius 5.0 5.0 5.0 
else_jump @IMPND_18458 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18451 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point -1591.093 688.555 -6.2422 mode 6 time -2 ms 

:IMPND_18451
jump @IMPND_18601 

:IMPND_18458
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18601 
0209: 16@ = random_int_in_ranges 0 2 
if 
  16@ == 0 
else_jump @IMPND_18563 
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1602.085 687.7857 -4.6028 16@ ms 
jump @IMPND_18601 

:IMPND_18563
0209: 16@ = random_int_in_ranges 5000 8000 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at -1582.961 717.1259 -4.2141 16@ ms 

:IMPND_18601
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_19852 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
if 
  " + tempvar_Float_3 + @" > 8.9783 
else_jump @IMPND_19229 
if 
  2484.598 > " + tempvar_Float_2 + @" 
else_jump @IMPND_18932 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 2241.879 2453.603 9.82 radius 5.0 5.0 5.0 
else_jump @IMPND_18808 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18801 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2241.879 2453.603 9.82 mode 6 time -2 ms 

:IMPND_18801
jump @IMPND_18925 

:IMPND_18808
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_18925 
0209: 16@ = random_int_in_ranges 5000 8000 
if 
  13@ == 6 
else_jump @IMPND_18904 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 2242.116 2478.98 10.8203 8000 ms 
jump @IMPND_18925 

:IMPND_18904
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at " + _10743 + @" " + _10744 + @" " + _10745 + @" 8000 ms 

:IMPND_18925
jump @IMPND_19222 

:IMPND_18932
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 2243.24 2495.099 9.8203 radius 5.0 5.0 5.0 
else_jump @IMPND_19061 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19054 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2243.24 2495.099 9.8203 mode 6 time -2 ms 

:IMPND_19054
jump @IMPND_19222 

:IMPND_19061
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19222 
if 
  13@ == 6 
else_jump @IMPND_19201 
if 
  " + _10745 + @" > 5.0 
else_jump @IMPND_19167 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 2242.453 2487.06 11.7533 8000 ms 
jump @IMPND_19194 

:IMPND_19167
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 2268.113 2498.456 7.7616 8000 ms 

:IMPND_19194
jump @IMPND_19222 

:IMPND_19201
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at " + _10743 + @" " + _10744 + @" " + _10745 + @" 8000 ms 

:IMPND_19222
jump @IMPND_19852 

:IMPND_19229
if 
  " + tempvar_Float_3 + @" > 2.1249 
else_jump @IMPND_19663 
if 
  " + tempvar_Float_2 + @" > 2458.327 
else_jump @IMPND_19467 
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 2306.376 2495.541 2.266 radius 5.0 5.0 5.0 
else_jump @IMPND_19400 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19393 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2306.376 2495.541 2.266 mode 6 time -2 ms 

:IMPND_19393
jump @IMPND_19460 

:IMPND_19400
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19460 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 2295.177 2471.76 3.955 8000 ms 

:IMPND_19460
jump @IMPND_19656 

:IMPND_19467
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 2316.06 2446.912 2.266 radius 5.0 5.0 5.0 
else_jump @IMPND_19596 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19589 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2316.06 2446.912 2.266 mode 6 time -2 ms 

:IMPND_19589
jump @IMPND_19656 

:IMPND_19596
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19656 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 2295.216 2451.088 4.3783 8000 ms 

:IMPND_19656
jump @IMPND_19852 

:IMPND_19663
if 
80FE:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_sphere 2238.753 2457.831 -8.4531 radius 5.0 5.0 5.0 
else_jump @IMPND_19792 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19785 
0687: clear_actor " + tmp_10516 + @"(12@,8i) task 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2238.753 2457.831 -8.4531 mode 6 time -2 ms 

:IMPND_19785
jump @IMPND_19852 

:IMPND_19792
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1639 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19852 
0667: AS_actor " + tmp_10516 + @"(12@,8i) aim_at 2251.799 2465.236 -7.2173 8000 ms 

:IMPND_19852
return 
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_19917 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1506 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_19917 
05E2: AS_actor " + tmp_10516 + @"(12@,8i) kill_actor " + PlayerActor + @" 

:IMPND_19917
return 

:IMPND_19919
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_20411 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_20411 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1560 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_20411 
if 
  " + tempvar_Float_3 + @" > 8.9783 
else_jump @IMPND_20411 
if 
  2481.796 > " + tempvar_Float_2 + @" 
else_jump @IMPND_20178 
if 
00A3:   actor " + tmp_10516 + @"(12@,8i) sphere 0 in_rectangle_cornerA 2237.854 2448.608 cornerB 2239.385 2450.014 
else_jump @IMPND_20178 
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 2239.573 2448.616 cornerB 2242.363 2449.851 
else_jump @IMPND_20178 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2240.034 2449.418 9.8203 mode 4 time -2 ms 
23@ = 1 

:IMPND_20178
if 
  " + tempvar_Float_2 + @" >= 2481.796 
else_jump @IMPND_20411 
if 
00A3:   actor " + tmp_10516 + @"(12@,8i) sphere 0 in_rectangle_cornerA 2253.515 2485.275 cornerB 2248.9 2492.416 
else_jump @IMPND_20411 
if and
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 2253.515 2485.275 cornerB 2248.9 2492.416 
8104:   not actor " + tmp_10516 + @"(12@,8i) near_actor " + PlayerActor + @" radius 1.5 1.5 2.0 sphere 0 
else_jump @IMPND_20411 
0615: define_AS_pack_begin " + _10715 + @" 
05D3: AS_actor -1 goto_point 2250.155 2486.405 9.8203 mode 4 time -2 ms 
05D3: AS_actor -1 goto_point 2247.823 2487.056 9.8203 mode 4 time -2 ms 
05D3: AS_actor -1 goto_point 2246.22 2488.32 9.8203 mode 4 time -2 ms 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 
23@ = 1 

:IMPND_20411
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_20881 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1491 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_20881 
062E: get_actor " + tmp_10516 + @"(12@,8i) task 1560 status_store_to 14@ 
if 
04A4:   14@ == 7 
else_jump @IMPND_20881 
if 
  " + tempvar_Float_3 + @" > 12.0 
else_jump @IMPND_20881 
if 
  1569.0 > " + tempvar_Float_1 + @" 
else_jump @IMPND_20677 
if 
00A3:   actor " + tmp_10516 + @"(12@,8i) sphere 0 in_rectangle_cornerA 1543.749 -1632.588 cornerB 1544.821 -1631.425 
else_jump @IMPND_20670 
if 
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 1544.966 -1632.88 cornerB 1546.495 -1630.646 
else_jump @IMPND_20670 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 1545.881 -1631.918 12.3905 mode 4 time -2 ms 
23@ = 1 

:IMPND_20670
jump @IMPND_20881 

:IMPND_20677
if 
00A3:   actor " + tmp_10516 + @"(12@,8i) sphere 0 in_rectangle_cornerA 1581.953 -1637.569 cornerB 1577.376 -1632.992 
else_jump @IMPND_20881 
if and
80A3:   not actor " + PlayerActor + @" sphere 0 in_rectangle_cornerA 1581.953 -1637.569 cornerB 1577.376 -1632.992 
8104:   not actor " + tmp_10516 + @"(12@,8i) near_actor " + PlayerActor + @" radius 1.5 1.5 2.0 sphere 0 
else_jump @IMPND_20881 
05D6: clear_scmpath 
05D7: add_point_to_scmpath 1578.517 -1636.495 12.5545 
05D7: add_point_to_scmpath 1576.366 -1636.395 12.5539 
05D7: add_point_to_scmpath 1573.981 -1632.764 12.3905 
0615: define_AS_pack_begin " + _10715 + @" 
05D8: AS_assign_scmpath to_actor -1 flags 4 0 
0616: define_AS_pack_end " + _10715 + @" 
0618: assign_actor " + tmp_10516 + @"(12@,8i) to_AS_pack " + _10715 + @" 
061B: remove_references_to_AS_pack " + _10715 + @" 
23@ = 1 

:IMPND_20881
return 
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_21066 
if 
  12@ == 0 
else_jump @IMPND_21066 
if 
80A3:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_rectangle_cornerA 2237.854 2448.608 cornerB 2239.385 2450.014 
else_jump @IMPND_21066 
if 
80A3:   not actor " + tmp_10516 + @"(12@,8i) sphere 0 in_rectangle_cornerA 2239.573 2448.616 cornerB 2242.363 2449.851 
else_jump @IMPND_21038 
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2240.034 2449.418 9.8203 mode 4 time -2 ms 
jump @IMPND_21066 

:IMPND_21038
05D3: AS_actor " + tmp_10516 + @"(12@,8i) goto_point 2238.569 2449.417 10.0372 mode 4 time -2 ms 

:IMPND_21066
return 

:IMPND_21068
" + _10713 + @" = 0 
if 
  " + IMPOUND_Town_Number + @" == 3 
else_jump @IMPND_21221 
if and
  " + tempvar_Z_coord + @" > 3.9517 
  14.0 > " + tempvar_Z_coord + @" 
else_jump @IMPND_21193 
if and
  " + tempvar_X_coord + @" > 2238.0 
  2299.0 > " + tempvar_X_coord + @" 
else_jump @IMPND_21193 
if and
  " + tempvar_Y_coord + @" > 2430.916 
  2502.681 > " + tempvar_Y_coord + @" 
else_jump @IMPND_21193 
" + _10713 + @" = 1 

:IMPND_21193
if 
  3.9517 >= " + tempvar_Z_coord + @" 
else_jump @IMPND_21221 
" + _10713 + @" = 1 

:IMPND_21221
if 
  " + IMPOUND_Town_Number + @" == 2 
else_jump @IMPND_21439 
if and
  " + tempvar_X_coord + @" > -1645.533 
  -1572.785 > " + tempvar_X_coord + @" 
else_jump @IMPND_21339 
if and
  " + tempvar_Y_coord + @" > 646.8482 
  761.5287 > " + tempvar_Y_coord + @" 
else_jump @IMPND_21339 
if and
  11.4577 > " + tempvar_Z_coord + @" 
  " + tempvar_Z_coord + @" > -7.3486 
else_jump @IMPND_21339 
" + _10713 + @" = 1 

:IMPND_21339
if and
  " + tempvar_X_coord + @" > -1701.013 
  -1640.991 > " + tempvar_X_coord + @" 
else_jump @IMPND_21439 
if and
  " + tempvar_Y_coord + @" > 674.5198 
  697.4974 > " + tempvar_Y_coord + @" 
else_jump @IMPND_21439 
if and
  " + tempvar_Z_coord + @" > 6.096 
  26.5941 > " + tempvar_Z_coord + @" 
else_jump @IMPND_21439 
" + _10713 + @" = 1 

:IMPND_21439
if 
  " + IMPOUND_Town_Number + @" == 1 
else_jump @IMPND_21723 
if 
  11.7746 > " + tempvar_Z_coord + @" 
else_jump @IMPND_21554 
if and
  " + tempvar_X_coord + @" > 1524.017 
  1612.404 > " + tempvar_X_coord + @" 
else_jump @IMPND_21547 
if and
  -1633.573 > " + tempvar_Y_coord + @" 
  " + tempvar_Y_coord + @" > -1722.036 
else_jump @IMPND_21547 
" + _10713 + @" = 1 

:IMPND_21547
jump @IMPND_21623 

:IMPND_21554
if and
  " + tempvar_X_coord + @" > 1544.427 
  1607.588 > " + tempvar_X_coord + @" 
else_jump @IMPND_21623 
if and
  -1603.015 > " + tempvar_Y_coord + @" 
  " + tempvar_Y_coord + @" > -1637.697 
else_jump @IMPND_21623 
" + _10713 + @" = 1 

:IMPND_21623
if and
  " + tempvar_X_coord + @" > 1581.407 
  1605.203 > " + tempvar_X_coord + @" 
else_jump @IMPND_21723 
if and
  " + tempvar_Y_coord + @" > -1666.734 
  -1637.67 > " + tempvar_Y_coord + @" 
else_jump @IMPND_21723 
if and
  " + tempvar_Z_coord + @" > 4.8451 
  13.6917 > " + tempvar_Z_coord + @" 
else_jump @IMPND_21723 
" + _10713 + @" = 1 

:IMPND_21723
return 

:IMPND_21725
if or
   not Actor.DrivingPoliceVehicle(" + PlayerActor + @")
  " + tmp_10549 + @"(12@,8i) == 1 
else_jump @IMPND_22001 
if 
0364:   actor " + tmp_10516 + @"(12@,8i) spotted_actor " + PlayerActor + @" 
else_jump @IMPND_22001 
Actor.StorePos(" + tmp_10516 + @"(12@,8i), " + tempvar_Float_1 + @", " + tempvar_Float_2 + @", " + tempvar_Float_3 + @")
28@ = Actor.Angle(" + tmp_10516 + @"(12@,8i))
0089: 25@ = " + tempvar_X_coord + @" 
0065: 25@ -= " + tempvar_Float_1 + @" 
0089: 26@ = " + tempvar_Y_coord + @" 
0065: 26@ -= " + tempvar_Float_2 + @" 
0604: get_Z_angle_for_point 25@ 26@ store_to 27@ 
0063: 28@ -= 27@ 
if 
  -180.0 > 28@ 
else_jump @IMPND_21887 
28@ += 360.0 

:IMPND_21887
0097: make 28@ absolute_float 
if 
  5@ == 0 
else_jump @IMPND_21959 
if 
  90.0 > 28@ 
else_jump @IMPND_21952 
Actor.StorePos(" + PlayerActor + @", " + _10743 + @", " + _10744 + @", " + _10745 + @")
" + _10714 + @" = 1 

:IMPND_21952
jump @IMPND_22001 

:IMPND_21959
if 
  120.0 > 28@ 
else_jump @IMPND_22001 
Actor.StorePos(" + PlayerActor + @", " + _10743 + @", " + _10744 + @", " + _10745 + @")
" + _10714 + @" = 1 

:IMPND_22001
return 

:IMPND_22003
" + _10729 + @" = 0 
" + _10713 + @" = 0 
" + _10557 + @" = 0 
" + tmp_10549 + @"[0] = 0 
" + tmp_10549 + @"[1] = 0 
" + tmp_10549 + @"[2] = 0 
" + tmp_10549 + @"[3] = 0 
" + tmp_10549 + @"[4] = 0 
" + tmp_10549 + @"[5] = 0 
" + tmp_10549 + @"[6] = 0 
" + tmp_10549 + @"[7] = 0 
0@ = 0 
1@ = 0 
040D: unload_wav 4 
Model.Destroy(" + _10710 + @")
Model.Destroy(" + _10711 + @")
Model.Destroy(#COLT45)
Model.Destroy(#POLICE_BARRIER)
Model.Destroy(#SFCOPDR)
Model.Destroy(#KMB_SHUTTER)
065C: release_decision_maker 2@ 
Object.Destroy(9@)
Object.Destroy(10@)
Object.Destroy(6@)
Object.Destroy(7@)
16@ = 0 

:IMPND_22160
if 
  8 > 16@ 
else_jump @IMPND_22243 
if 
056D:   actor " + tmp_10516 + @"(16@,8i) defined 
else_jump @IMPND_22207 
Actor.DestroyInstantly(" + tmp_10516 + @"(16@,8i))

:IMPND_22207
" + tmp_10716 + @"(16@,8i) = 0 
" + tmp_10525 + @"(16@,8i) = 0 
16@ += 1 
jump @IMPND_22160 

:IMPND_22243
16@ = 0 

:IMPND_22250
if 
  4 > 16@ 
else_jump @IMPND_22311 
if 
   not Car.Wrecked(" + tmp_10725 + @"(16@,4i))
else_jump @IMPND_22297 
Car.RemoveReferences(" + tmp_10725 + @"(16@,4i))

:IMPND_22297
16@ += 1 
jump @IMPND_22250 

:IMPND_22311
Actor.RemoveReferences(24@)
" + _10730 + @" = 0 
" + _10731 + @" = 0 
" + _10732 + @" = 0 
" + _10733 + @" = 0 
" + _10524 + @" = 0 
end_thread 
return" );
            }
        }

    }

}