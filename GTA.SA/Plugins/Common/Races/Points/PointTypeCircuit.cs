using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class PointTypeCircuit : BasePointType<PointTypeCircuit> {

        internal Dictionary<int, double> pointS;

        // ---------------------------------------------------------------------------------------------------------------------------

        public PointTypeCircuit() : base() { pointS = new Dictionary<int, double>(); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public PointTypeCircuit add( double x, double y, double z, double speed ) {
            pointS.Add( PoolCount, speed );
            add( x, y, z );
            return this;
        }

    }

}