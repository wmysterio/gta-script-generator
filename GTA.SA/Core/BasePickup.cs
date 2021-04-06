namespace GTA.Core {

    public abstract class BasePickup<T> : Handle<T> where T : BasePickup<T> {

        internal BasePickup( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public T destroy() { Script.AppendLine( Opcodes._0215, this ); return ( T ) this; }
        public T get_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._065B, this, x, y, z ); return ( T ) this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_picked_up() { return new Condition( Opcodes._0214, this ); }

    }

}
