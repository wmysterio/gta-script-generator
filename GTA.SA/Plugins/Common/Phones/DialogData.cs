using System;

namespace GTA.Plugins.Common {

    public sealed class DialogData {

        internal static DialogData instance = new DialogData();

        // ---------------------------------------------------------------------------------------------------------------------------

        public int DialogID { get; internal set; }
        public int TotalReplicas { get; internal set; }

        // ---------------------------------------------------------------------------------------------------------------------------

        private DialogData() { }

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