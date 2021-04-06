using GTA.Core;

namespace GTA {

    public class Fire : Handle<Fire>, IArrayItem, IVariable {

        internal Fire( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Fire create( Actor hActor ) { Script.AppendLine( Opcodes._0326, check_OUT_Variable( this ), hActor ); return this; }
        public Fire create<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0325, check_OUT_Variable( this ), hVehicle ); return this; }
        public Fire remove() { Script.AppendLine( Opcodes._02D1, this ); return this; }
        public Fire create( Float x, Float y, Float z, Int propagation, Int size ) { Script.AppendLine( Opcodes._02CF, this, x, y, z, "propagation " + propagation, "size " + size ); return this; }
        public Fire get_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._06F5, x, y, z, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_exists() { return new Condition( Opcodes._0973, this ); }
        public Condition is_extinguished() { return new Condition( Opcodes._02D0, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Fire( LocalVariable val ) { return new Fire( VariableContext.LOCAL, val.index ); }
        public static implicit operator Fire( GlobalVariable val ) { return new Fire( VariableContext.GLOBAL, val.index ); }

    }

}