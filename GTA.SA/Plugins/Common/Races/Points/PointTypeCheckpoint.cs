using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class PointTypeCheckpoint : BasePointType<PointTypeCheckpoint> {

        internal Dictionary<int, int> pointT;

        // ---------------------------------------------------------------------------------------------------------------------------

        public PointTypeCheckpoint() : base() { pointT = new Dictionary<int, int>(); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public PointTypeCheckpoint add( double x, double y, double z, uint timeLimit ) {
            pointT.Add( PoolCount, ( int ) timeLimit );
            add( x, y, z );
            return this;
        }

    }

}