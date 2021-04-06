using GTA.Core;

namespace GTA {

    public class Cab : Vehicle<Cab>, IArrayItem, IVariable {

        private static Cab any = null;
        static Cab() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Cab empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Cab( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Cab( LocalVariable val ) { return new Cab( VariableContext.LOCAL, val.index ); }
        public static implicit operator Cab( GlobalVariable val ) { return new Cab( VariableContext.GLOBAL, val.index ); }

    }

}