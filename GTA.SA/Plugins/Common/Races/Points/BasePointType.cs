using System;
using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public abstract class BasePointType<T> where T : BasePointType<T>, new() {

        internal Dictionary<int, double> pointX, pointY, pointZ;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal int PoolCount { get; private set; } = 0;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal BasePointType() {
            pointX = new Dictionary<int, double>();
            pointY = new Dictionary<int, double>();
            pointZ = new Dictionary<int, double>();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected T add( double x, double y, double z ) {
            pointX.Add( PoolCount, x );
            pointY.Add( PoolCount, y );
            pointZ.Add( PoolCount, z );
            PoolCount += 1;
            return ( T ) this;
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