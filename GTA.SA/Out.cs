using System;
using GTA.Core;

namespace GTA {

    public sealed class Out<T> : OutParameter where T : Variable {

        internal T instance;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override Variable GetInstance() { return instance; }

        // ---------------------------------------------------------------------------------------------------------------------------

        private Out() { }
        internal Out( T instance ) {
            Variable.check_OUT_Variable( instance );
            this.instance = instance;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Out<T>( T val ) { return new Out<T>( val ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return instance.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}