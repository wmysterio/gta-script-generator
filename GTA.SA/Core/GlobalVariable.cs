using System;

namespace GTA.Core {

    public class GlobalVariable {

        internal static ushort LIMIT = ushort.MaxValue - 4;
        internal static ushort AUTO_INDEX = 410;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal readonly ushort index;
        internal readonly bool isAuto;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal GlobalVariable() { isAuto = true; index = AUTO_INDEX++; }
        internal GlobalVariable( ushort index ) { this.index = index; }

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