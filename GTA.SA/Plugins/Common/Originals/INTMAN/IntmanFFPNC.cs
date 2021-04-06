using GTA.Core;

namespace GTA.Plugins.Common {

    partial class OriginalIntman {

        private sealed class FFPNC : External {

            public override void START( LabelJump label ) {
                AppendLine( @"2@ = 0 
if 
  2@ == 1 
jf @FFPNC_60 
0@ = Actor.Create(CivFemale, #NULL, 0.0, 0.0, 0.0)

:FFPNC_60
if 
   not Actor.Dead(0@)
jf @FFPNC_84 
060B: set_actor 0@ decision_maker_to " + Interior_Decision_Maker_A + @" 

:FFPNC_84
wait 0 
if and
   Player.Defined(" + PlayerChar + @")
  " + PLAYER_IN_INTERIOR + @" == 0 
jf @FFPNC_308 
09E8: " + _1250 + @" = actor " + PlayerActor + @" active_interior 
if or
  " + _1250 + @" == 0 
  " + PLAYER_IN_INTERIOR + @" == 1 
jf @FFPNC_151 
gosub @FFPNC_322 

:FFPNC_151
if 
   not Actor.Dead(0@)
jf @FFPNC_294 
0085: 2@ = 1@ 
2@ /= 2 
2@ *= 2 
if 
001D:   1@ > 2@ 
jf @FFPNC_251 
062E: get_actor 0@ task 1477 status_store_to 3@ 
if 
04A4:   3@ == 7 
jf @FFPNC_244 
05C5: AS_actor 0@ cower -2 ms 

:FFPNC_244
jump @FFPNC_287 

:FFPNC_251
062E: get_actor 0@ task 1476 status_store_to 3@ 
if 
04A4:   3@ == 7 
jf @FFPNC_287 
05C4: AS_actor 0@ hands_up -2 ms 

:FFPNC_287
jump @FFPNC_301 

:FFPNC_294
gosub @FFPNC_322 

:FFPNC_301
jump @FFPNC_315 

:FFPNC_308
gosub @FFPNC_322 

:FFPNC_315
jump @FFPNC_84 

:FFPNC_322
Actor.RemoveReferences(0@)" );
                remove_references_external_script<FFPNC>();
AppendLine( @"end_thread 
return 
end_thread" );
            }

        }

    }

}