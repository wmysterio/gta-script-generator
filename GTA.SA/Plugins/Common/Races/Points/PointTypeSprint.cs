using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class PointTypeSprint : BasePointType<PointTypeSprint> {

        internal Dictionary<int, double> pointS;

        // ---------------------------------------------------------------------------------------------------------------------------

        public PointTypeSprint() : base() { pointS = new Dictionary<int, double>(); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public PointTypeSprint add( double x, double y, double z, double speed ) {
            pointS.Add( PoolCount, speed );
            add( x, y, z );
            return this;
        }

    }

}