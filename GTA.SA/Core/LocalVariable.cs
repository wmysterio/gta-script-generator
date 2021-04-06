using System;

namespace GTA.Core {

    public class LocalVariable {

        internal static ushort LIMIT = 0;
        internal static ushort AUTO_INDEX = 0;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal readonly bool isAuto;
        internal readonly ushort index;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal LocalVariable() { isAuto = true; index = AUTO_INDEX++; }
        internal LocalVariable( ushort index ) { this.index = index; }

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