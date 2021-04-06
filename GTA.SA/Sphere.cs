using GTA.Core;

namespace GTA {

    public class Sphere : Handle<Sphere>, IArrayItem, IVariable {

        internal Sphere( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Sphere create( Float x, Float y, Float z, Float radius ) { Script.AppendLine( Opcodes._03BC, check_OUT_Variable( this ), x, y, z, radius ); return this; }
        public Sphere destroy() { Script.AppendLine( Opcodes._03BD, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Sphere( LocalVariable val ) { return new Sphere( VariableContext.LOCAL, val.index ); }
        public static implicit operator Sphere( GlobalVariable val ) { return new Sphere( VariableContext.GLOBAL, val.index ); }

    }

}