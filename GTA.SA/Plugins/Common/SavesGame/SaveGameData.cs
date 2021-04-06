using System;

namespace GTA.Plugins.Common {

    internal sealed class SaveGameData {

        internal double x, y, z, playerPositionX, playerPositionY, playerPositionZ, playerZAngle;
        internal Action action;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal SaveGameData() { }

    }

}