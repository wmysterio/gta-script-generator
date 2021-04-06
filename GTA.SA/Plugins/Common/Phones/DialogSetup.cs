using System;
using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class DialogSetup {

        internal List<Replica> Replicas = new List<Replica>();

        // ---------------------------------------------------------------------------------------------------------------------------

        public Action OnComplete;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal DialogSetup() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public DialogSetup add_replica( string gxt, int time, bool isPlayer = false ) {
            if( string.IsNullOrEmpty( gxt ) )
                gxt = sString.DUMMY;
            Replicas.Add( new Replica { gxt = gxt, time = time, isPlayer = isPlayer } );
            return this;
        }

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