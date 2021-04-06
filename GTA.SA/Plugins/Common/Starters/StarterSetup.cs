using System;
using System.Collections.Generic;
using GTA.Core;

namespace GTA.Plugins.Common {

    public sealed class StarterSetup {

        internal List<StarterData> missionList = new List<StarterData>();

        internal double x = 0.0,
                        y = 0.0,
                        z = 0.0,
                        radius = 1.0;

        internal bool disablePlayerControl = true,
                      enableFadeMode = true;

        internal int fadeTime = 250;
        internal RadarIconID iconID = RadarIconID.CJ;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal StarterSetup() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public StarterSetup disable_player_controll( bool state ) { disablePlayerControl = state; return this; }
        public StarterSetup enable_fade_mode( bool state ) { enableFadeMode = state; return this; }
        public StarterSetup set_fade_time( ushort fadeTime ) { this.fadeTime = fadeTime; return this; }
        public StarterSetup set_radar_icon( RadarIconID iconID ) { this.iconID = iconID; return this; }
        public StarterSetup set_start_position( double x, double y, double z ) { this.x = x; this.y = y; this.z = z; return this; }
        public StarterSetup set_radius( double radius ) { this.radius = radius; return this; }
        public StarterSetup add_mission<T>( sString gxtName = null, params Condition[] conditions ) where T : MissionCustom, new() { missionList.Add( new StarterData() { conditionsArray = conditions, gxtName = gxtName, missionAction = delegate { Script.start_mission<T>(); } } ); return this; }

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

    public delegate void HandlerStarter( Common.StarterSetup setup );

}