using GTA.Core;

namespace GTA.Plugins.Common {

    internal class OriginalTCASH : Original {

        internal OriginalTCASH() : base() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void Start() {
            Script.create_thread<TCASH>();
        }
        internal override void Update() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sealed class TCASH : Thread {

            Int GS_Gang_Cash = global(),
                GS_Gang_Money_Pickup = global(),
                GS_Gang_Turf_Controlled = global();

            public override void START( LabelJump label ) {
                AppendLine( @"04A6: " + GS_Gang_Money_Pickup + @" = create_asset_money_pickup_at 2502.1 -1686.38 13.0 money 10000 " + GS_Gang_Cash + @" 
" + GS_Gang_Cash + @" = 1 

:TCASH_37
wait 20000 
08E2: " + GS_Gang_Turf_Controlled + @" = territories_controlled_percentage 
if 
  " + STAT_Unlocked_Cities_Number + @" > 1 
else_jump @TCASH_119 
0084: " + GS_Gang_Cash + @" = " + GS_Gang_Turf_Controlled + @" 
" + GS_Gang_Cash + @" *= 100 
jump @TCASH_134 

:TCASH_119
0084: " + GS_Gang_Cash + @" = " + GS_Gang_Turf_Controlled + @"
" + GS_Gang_Cash + @" *= 50 

:TCASH_134
094A: set_money_pickup " + GS_Gang_Money_Pickup + @" cash_to " + GS_Gang_Cash + @" 
jump @TCASH_37" );

            }

        }

    }

}