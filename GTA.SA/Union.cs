using System;
using GTA.Core;

namespace GTA {

    public abstract class Union : IUnion {

        public Union() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        void IUnion.Init( bool isGlobal ) {
            if( isGlobal ) {
                OnGlobalAutoInit();
            } else { OnLocalAutoInit(); }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected abstract void OnLocalAutoInit();
        protected abstract void OnGlobalAutoInit();

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