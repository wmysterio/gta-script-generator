using GTA.Core;

namespace GTA {

    public class Boat : Vehicle<Boat>, IArrayItem, IVariable {

        private static Boat any = null;
        static Boat() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Boat empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Boat( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Boat sail_to( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._02D3, this, x, y, z ); return this; }
        public Boat stop() { Script.AppendLine( Opcodes._02D4, this ); return this; }
        public Boat set_anchor( Int state_bool ) { Script.AppendLine( Opcodes._0323, this, state_bool ); return this; }
        public Boat set_cruise_speed( Float speed ) { Script.AppendLine( Opcodes._02DB, this, speed ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Boat( LocalVariable val ) { return new Boat( VariableContext.LOCAL, val.index ); }
        public static implicit operator Boat( GlobalVariable val ) { return new Boat( VariableContext.GLOBAL, val.index ); }

    }

}