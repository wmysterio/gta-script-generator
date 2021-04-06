using System;

namespace GTA.Plugins.Common {

    public sealed class PropertiesActionSetup {

        internal ushort id;
        internal int price;
        internal bool isCameraPositionExist, isCameraPointExist;
        internal double cameraX, cameraY, cameraZ, cameraPointX, cameraPointY, cameraPointZ, posX, posY, posZ;
        internal Action beforeCreate, afterBuying;

        // ---------------------------------------------------------------------------------------------------------------------------

        public ushort ID { get { return id; } }
        public int Price { get { return price; } }
        public double X { get { return posX; } }
        public double Y { get { return posY; } }
        public double Z { get { return posZ; } }
        public Action BeforeCreate { set { beforeCreate = value; } }
        public Action AfterBuying { set { afterBuying = value; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        private PropertiesActionSetup() { }
        internal PropertiesActionSetup( ushort id, double posX, double posY, double posZ, int price ) {
            this.id = id;
            this.posX = posX;
            this.posY = posY;
            this.posZ = posZ;
            this.price = price;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public PropertiesActionSetup set_camera_position( double x, double y, double z ) {
            isCameraPositionExist = true;
            cameraX = x;
            cameraY = y;
            cameraZ = z;
            return this;
        }
        public PropertiesActionSetup set_camera_point( double x, double y, double z ) {
            isCameraPointExist = true;
            cameraPointX = x;
            cameraPointY = y;
            cameraPointZ = z;
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