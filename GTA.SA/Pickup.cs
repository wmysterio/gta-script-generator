using GTA.Core;

namespace GTA {

    public class Pickup : BasePickup<Pickup>, IArrayItem, IVariable {

        internal Pickup( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Pickup create( Int pickupModelID, Int pickupType, Float x, Float y, Float z ) {  Script.AppendLine( Opcodes._0213, check_OUT_Variable( this ), pickupModelID, pickupType, x, y, z ); return this; }
        public Pickup create_with_ammo( Int pickupModelID, Int pickupType, Int ammo, Float x, Float y, Float z ) {  Script.AppendLine( Opcodes._032B, check_OUT_Variable( this ), pickupModelID, pickupType, ammo, x, y, z ); return this; }
        public Pickup create_photo( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0958, this, x, y, z ); return this; }
        public Pickup create_horseshoe( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0959, this, x, y, z ); return this; }
        public Pickup create_oyster( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._095A, this, x, y, z ); return this; }
        public Pickup create_locked_property( sString gxtTitle, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0517, this, gxtTitle, x, y, z ); return this; }
        public Pickup create_forsale_property( sString gxtTitle, Float x, Float y, Float z, Int price ) { Script.AppendLine( Opcodes._0518, this, gxtTitle, x, y, z, price ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_exist() { return new Condition( Opcodes._09D1, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Pickup( LocalVariable val ) { return new Pickup( VariableContext.LOCAL, val.index ); }
        public static implicit operator Pickup( GlobalVariable val ) { return new Pickup( VariableContext.GLOBAL, val.index ); }

    }

}