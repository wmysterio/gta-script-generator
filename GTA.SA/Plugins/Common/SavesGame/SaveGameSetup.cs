using System;
using System.Collections.Generic;

namespace GTA.Plugins.Common {

    public sealed class SaveGameSetup {

        // ---------------------------------------------------------------------------------------------------------------------------

        internal ushort count = 0;
        internal Dictionary<ushort, SaveGameData> data = new Dictionary<ushort, SaveGameData>();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal SaveGameSetup() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public SaveGameSetup add_point( double x, double y, double z, double playerPositionX, double playerPositionY, double playerPositionZ, double playerZAngle, Action action = null ) {
            data.Add( count, new SaveGameData() { x = x, y = y, z = z, playerPositionX = playerPositionX, playerPositionY = playerPositionY, playerPositionZ = playerPositionZ, playerZAngle = playerZAngle, action = action } );
            count += 1;
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
namespace GTA.Plugins {

    public delegate void HandlerSaveGame( Common.SaveGameSetup setup );

}