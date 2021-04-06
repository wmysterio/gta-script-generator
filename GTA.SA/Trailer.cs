using GTA.Core;

namespace GTA {

    public class Trailer : Vehicle<Trailer>, IArrayItem, IVariable {

        private static Trailer any = null;
        static Trailer() {
            any = Script.global( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Trailer empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Trailer( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Trailer attach_to_cab( Cab hCab ) { Script.AppendLine( Opcodes._0893, this, hCab ); return this; }
        public Trailer detach_from_cab( Cab hCab ) { Script.AppendLine( Opcodes._07AC, this, hCab ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_attached_to_cab( Cab hCab ) { return new Condition( Opcodes._07AB, this, hCab ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Trailer( LocalVariable val ) { return new Trailer( VariableContext.LOCAL, val.index ); }
        public static implicit operator Trailer( GlobalVariable val ) { return new Trailer( VariableContext.GLOBAL, val.index ); }

    }

}