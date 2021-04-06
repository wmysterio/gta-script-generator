using GTA.Core;

namespace GTA {

    public class Attractor : Handle<Attractor>, IArrayItem, IVariable {

        internal Attractor( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------
        
        public Attractor create( Float x, Float y, Float z, Float angle, Float radius, ASPack hASPack ) { Script.AppendLine( Opcodes._061D, x, y, z, angle, radius, hASPack, this ); return this; }
        public Attractor clear() { Script.AppendLine( Opcodes._061E, this ); return this; }
        public Attractor add_pedtype_as_user( Int actorType ) { Script.AppendLine( Opcodes._0680, this, actorType ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Attractor( LocalVariable val ) { return new Attractor( VariableContext.LOCAL, val.index ); }
        public static implicit operator Attractor( GlobalVariable val ) { return new Attractor( VariableContext.GLOBAL, val.index ); }

    }

}