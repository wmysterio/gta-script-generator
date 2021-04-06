using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class PCUSTOM : External {

            Actor _local0 = local( 0 ); // 0@

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @PCUSTOM_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:PCUSTOM_60
04ED: load_animation ""INT_SHOP"" 

:PCUSTOM_72
if 
84EE:   not animation ""INT_SHOP"" loaded 
jf @PCUSTOM_106 
wait 0 
jump @PCUSTOM_72 

:PCUSTOM_106
3@ = 1 
4@ = 0 
5@ = 0 
11@ = 0 

:PCUSTOM_134
wait 0 
if and
   not Actor.Dead(0@)
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PCUSTOM_237 
if 
09C5:   unknown_actor 0@ 
jf @PCUSTOM_223 
if 
  " + FOOD_Player_Aggressive_Flag + @" == 0 
jf @PCUSTOM_209 
gosub @PCUSTOM_251 
jump @PCUSTOM_216 

:PCUSTOM_209
jump @PCUSTOM_804 

:PCUSTOM_216
jump @PCUSTOM_230 

:PCUSTOM_223
gosub @PCUSTOM_727 

:PCUSTOM_230
jump @PCUSTOM_244 

:PCUSTOM_237
gosub @PCUSTOM_727 

:PCUSTOM_244
jump @PCUSTOM_134 

:PCUSTOM_251
0871: init_jump_table 3@ total_jumps 1 default_jump 0 @PCUSTOM_328 jumps 1 @PCUSTOM_314 -1 @PCUSTOM_328 -1 @PCUSTOM_328 -1 @PCUSTOM_328 -1 @PCUSTOM_328 -1 @PCUSTOM_328 -1 @PCUSTOM_328 

:PCUSTOM_314
gosub @PCUSTOM_330 
jump @PCUSTOM_328 

:PCUSTOM_328
return 

:PCUSTOM_330
0871: init_jump_table 4@ total_jumps 4 default_jump 0 @PCUSTOM_725 jumps 0 @PCUSTOM_393 1 @PCUSTOM_451 2 @PCUSTOM_534 3 @PCUSTOM_711 -1 @PCUSTOM_725 -1 @PCUSTOM_725 -1 @PCUSTOM_725 

:PCUSTOM_393
5@ = 1 
0605: actor 0@ perform_animation ""IDLE_CHAT"" IFP ""PED"" framedelta 4.0 loop 1 lockX 0 lockY 0 lockF 0 time 5000 
4@ += 1 
jump @PCUSTOM_725 

:PCUSTOM_451
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @PCUSTOM_527 
0605: actor 0@ perform_animation ""SHOP_PAY"" IFP ""INT_SHOP"" framedelta 1000.0 loop 0 lockX 0 lockY 0 lockF 0 time 0 
4@ += 1 

:PCUSTOM_527
jump @PCUSTOM_725 

:PCUSTOM_534
062E: get_actor 0@ task 1541 status_store_to 10@ 
if 
04A4:   10@ == 7 
jf @PCUSTOM_704 
04C4: store_coords_to 7@ 8@ 9@ from_actor 0@ with_offset 0.0 0.1 1.0 
if 
05AD:   " + Current_Shop_GXT_Name + @" == 'FDPIZA' 
jf @PCUSTOM_640 
12@ = Object.Create(#CJ_PIZZA_2, 7@, 8@, 9@)
jump @PCUSTOM_656 

:PCUSTOM_640
12@ = Object.Create(#CJ_BURG_2, 7@, 8@, 9@)

:PCUSTOM_656
070A: AS_actor 0@ attach_to_object 12@ offset 0.0 0.0 0.0 on_bone 6 16 perform_animation ""NULL"" IFP_file ""NULL"" time 0 
4@ += 1 

:PCUSTOM_704
jump @PCUSTOM_725 

:PCUSTOM_711
gosub @PCUSTOM_727 
jump @PCUSTOM_725 

:PCUSTOM_725
return 

:PCUSTOM_727
04EF: release_animation ""INT_SHOP"" 
Object.RemoveReferences(12@)
if 
   not Actor.Dead(0@)
jf @PCUSTOM_800 
0792: disembark_instantly_actor 0@" );
                _local0.task.use_closest_map_attractor<PCHAIR>( ( double ) 20.0, NULL, ( double ) 0.0, ( double ) 0.0, ( double ) 0.0 );
AppendLine( @"
:PCUSTOM_800
end_thread 
return 

:PCUSTOM_804
wait 0 
if and
8844:   not string " + Current_Shop_GXT_Name + @" empty 
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @PCUSTOM_890 
if 
   not Actor.Dead(0@)
jf @PCUSTOM_883 
062E: get_actor 0@ task 1477 status_store_to 11@ 
if 
04A4:   11@ == 7 
jf @PCUSTOM_883 
05C5: AS_actor 0@ cower -2 ms 

:PCUSTOM_883
jump @PCUSTOM_897 

:PCUSTOM_890
gosub @PCUSTOM_727 

:PCUSTOM_897
jump @PCUSTOM_804 
0663: printint ""PEDSTATE"" 3@ 
0663: printint ""SUBSTATESTATUS"" 4@ 
0663: printint ""LOOP_TIMER"" TIMERB 
0663: printint ""SCRIPT_TIMER"" TIMERA 
return 
end_thread" );
            }

        }

    }

}