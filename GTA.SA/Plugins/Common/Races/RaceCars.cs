using System;
using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class RaceCars {

        public delegate void CarSetupHandler( Car setup );

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Dictionary<int, int> CarModels, DriverModels;
        internal Dictionary<int, double> X, Y, Z, Angles;
        internal Dictionary<int, CarSetupHandler> carSetups = new Dictionary<int, CarSetupHandler>();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal int PoolCount { get; private set; }
        internal int PlayerIndexInPool { get; private set; }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal RaceCars() {
            PoolCount = 0;
            PlayerIndexInPool = -1;
            CarModels = new Dictionary<int, int>();
            DriverModels = new Dictionary<int, int>();
            X = new Dictionary<int, double>();
            Y = new Dictionary<int, double>();
            Z = new Dictionary<int, double>();
            Angles = new Dictionary<int, double>();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public RaceCars add_player_car( CarModel carModel, double x, double y, double z, double angle, CarSetupHandler carSetup = null ) {
            PlayerIndexInPool = PoolCount;
            CarModels.Add( PoolCount, ( int ) carModel );
            DriverModels.Add( PoolCount, -1 );
            carSetups.Add( PoolCount, carSetup );
            X.Add( PoolCount, x );
            Y.Add( PoolCount, y );
            Z.Add( PoolCount, z );
            Angles.Add( PoolCount, angle );
            PoolCount += 1;
            return this;
        }
        public RaceCars add( CarModel carModel, double x, double y, double z, double angle, CarSetupHandler carSetup = null ) {
            CarModels.Add( PoolCount, ( int ) carModel );
            DriverModels.Add( PoolCount, -1 );
            carSetups.Add( PoolCount, carSetup );
            X.Add( PoolCount, x );
            Y.Add( PoolCount, y );
            Z.Add( PoolCount, z );
            Angles.Add( PoolCount, angle );
            PoolCount += 1;
            return this;
        }
        public RaceCars add( CarModel carModel, ActorModel driverModel, double x, double y, double z, double angle, CarSetupHandler carSetup = null ) {
            CarModels.Add( PoolCount, ( int ) carModel );
            DriverModels.Add( PoolCount, ( int ) driverModel );
            carSetups.Add( PoolCount, carSetup );
            X.Add( PoolCount, x );
            Y.Add( PoolCount, y );
            Z.Add( PoolCount, z );
            Angles.Add( PoolCount, angle );
            PoolCount += 1;
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