using System;
using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class OriginalSetup {

        internal static bool enableDefaultZones = false;
        internal static bool enableDefaultPoliceTriggers = false;
        internal static bool openAllMapZones = false;
        internal static bool disableCheats = false;
        internal static bool enableDefaultUniqueJumps = false;
        internal static bool enableDefaultRestartPoints = false;
        internal static bool enableDefaultWeaponPickups = false;
        internal static bool enableDefaultParkingCars = false;
        internal static bool enableDefaultGangZones = false;
        internal static bool enableDefaultAcquaintance = false;
        internal static bool enableDefaultDealerDensity = false;
        internal static bool enableWangCarsMoney = false;
        internal static bool enableDefaultArmourPickups = false;
        internal static bool enableDefaultBribePickups = false;
        internal static bool enableDefaultMeleeWeaponPickups = false;
        internal static bool enableEmmetsGun = false;

        internal static Action action = null;

        internal static List<OriginalData> OriginalScriptAccess = new List<OriginalData>() {
            new OriginalData() { type = typeof( OriginalParachute ), state = false },           // 0
            new OriginalData() { type = typeof( OriginalVending ), state = false },             // 1
            new OriginalData() { type = typeof( OriginalDealer ), state = false },              // 2
            new OriginalData() { type = typeof( OriginalGates ), state = false },               // 3
            new OriginalData() { type = typeof( OriginalGyms ), state = false },                // 4
            new OriginalData() { type = typeof( OriginalBasketball ), state = false },          // 5
            new OriginalData() { type = typeof( OriginalCranes ), state = false },              // 6
            new OriginalData() { type = typeof( OriginalMinigame ), state = false },            // 7
            new OriginalData() { type = typeof( OriginalIntman ), state = false },              // 8
            new OriginalData() { type = typeof( OriginalCarmod ), state = false },              // 9
            new OriginalData() { type = typeof( OriginalVehicleMissions ), state = false },     // 10
            new OriginalData() { type = typeof( OriginalRases ), state = false },               // 11
            new OriginalData() { type = typeof( OriginalSkools ), state = false },              // 12
            new OriginalData() { type = typeof( OriginalODDVEH ), state = false },              // 13
            new OriginalData() { type = typeof( OriginalTRAINSL ), state = false },             // 14
            new OriginalData() { type = typeof( OriginalADPLANE ), state = false },             // 15
            new OriginalData() { type = typeof( OriginalHJ ), state = false },                  // 16
            new OriginalData() { type = typeof( OriginalIMPND_L ), state = false },             // 17
            new OriginalData() { type = typeof( OriginalImportExport ), state = false },        // 18
            new OriginalData() { type = typeof( OriginalCARPARK ), state = false },             // 19
            new OriginalData() { type = typeof( OriginalBonuses ), state = false },             // 20
            new OriginalData() { type = typeof( OriginalTCASH ), state = false },               // 21
        };

        // ---------------------------------------------------------------------------------------------------------------------------

        public Action After { set { action = value; } }

        public bool EnableParachute { set { OriginalScriptAccess[ 0 ].state = value; } }
        public bool EnableVending { set { OriginalScriptAccess[ 1 ].state = value; } }
        public bool EnableDealer { set { OriginalScriptAccess[ 2 ].state = value; } }
        public bool EnableGSMGates { set { OriginalScriptAccess[ 3 ].state = value; } }
        public bool EnableGyms { set { OriginalScriptAccess[ 4 ].state = value; } }
        public bool EnableBasketball { set { OriginalScriptAccess[ 5 ].state = value; } }
        public bool EnableCranes { set { OriginalScriptAccess[ 6 ].state = value; } }
        public bool EnableMinigames { set { OriginalScriptAccess[ 7 ].state = value; } }
        public bool EnableAmbience { set { OriginalScriptAccess[ 8 ].state = value; } }
        public bool EnableCarmods { set { OriginalScriptAccess[ 9 ].state = value; } }
        public bool EnableVehicleMissions { set { OriginalScriptAccess[ 10 ].state = value; } }
        public bool EnableRaces { set { OriginalScriptAccess[ 11 ].state = value; } }
        public bool EnableSchools { set { OriginalScriptAccess[ 12 ].state = value; } }
        public bool EnableBusinessMissions { set { OriginalScriptAccess[ 13 ].state = value; } }
        public bool EnableTrains { set { OriginalScriptAccess[ 14 ].state = value; } }
        public bool EnablePlanes { set { OriginalScriptAccess[ 15 ].state = value; } }
        public bool EnableCrazyTricks { set { OriginalScriptAccess[ 16 ].state = value; } }
        public bool EnableImpoundScript { set { OriginalScriptAccess[ 17 ].state = value; } }
        public bool EnableImportExport { set { OriginalScriptAccess[ 18 ].state = value; } }
        public bool EnableCarparkGenerator { set { OriginalScriptAccess[ 19 ].state = value; } }
        public bool EnableBonuses { set { OriginalScriptAccess[ 20 ].state = value; } }
        public bool EnablePlayerGangMoney { set { OriginalScriptAccess[ 21 ].state = value; } }
        public bool EnableWangCarsMoney { set { enableWangCarsMoney = value; } }
        public bool EnableDefaultAcquaintance { set { enableDefaultAcquaintance = value; } }
        public bool EnableDefaultZoneTypes { set { enableDefaultZones = value; } }
        public bool OpenAllMapZones { set { openAllMapZones = value; } }
        public bool DisableCheats { set { disableCheats = value; } }
        public bool EnableDefaultPoliceTriggers { set { enableDefaultPoliceTriggers = value; } }
        public bool EnableDefaultUniqueJumps { set { enableDefaultUniqueJumps = value; } }
        public bool EnableDefaultRestartPoints { set { enableDefaultRestartPoints = value; } }
        public bool EnableDefaultParkingCars { set { enableDefaultParkingCars = value; } }
        public bool EnableDefaultGangZones { set { enableDefaultGangZones = value; } }
        public bool EnableDefaultDealerDensity { set { enableDefaultDealerDensity = value; } }
        public bool EnableDefaultArmourPickups { set { enableDefaultArmourPickups = value; } }
        public bool EnableDefaultBribePickups { set { enableDefaultBribePickups = value; } }
        public bool EnableDefaultMeleeWeaponPickups { set { enableDefaultMeleeWeaponPickups = value; } }
        public bool EnableDefaultWeaponPickups { set { enableDefaultWeaponPickups = value; } }
        public bool EnableEmmetsGun { set { enableEmmetsGun = value; } }

        public bool EnableAll {
            set {
                for( int i = 0; i < OriginalScriptAccess.Count; i++ )
                    OriginalScriptAccess[ i ].state = value;
                enableDefaultZones = value;
                enableDefaultPoliceTriggers = value;
                enableDefaultUniqueJumps = value;
                enableDefaultRestartPoints = value;
                enableDefaultParkingCars = value;
                enableDefaultGangZones = value;
                enableDefaultAcquaintance = value;
                enableWangCarsMoney = value;
                enableDefaultDealerDensity = value;
                enableDefaultArmourPickups = value;
                enableDefaultBribePickups = value;
                enableDefaultMeleeWeaponPickups = value;
                enableDefaultWeaponPickups = value;
                enableEmmetsGun = value;
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal OriginalSetup() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}
namespace GTA.Plugins {

    public delegate void HandlerOriginalSetup( Common.OriginalSetup setup );

}