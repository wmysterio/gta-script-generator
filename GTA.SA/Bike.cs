using GTA.Core;

namespace GTA {

    public class Bike : Vehicle<Bike>, IArrayItem, IVariable {

        private static Bike any = null;
        static Bike() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Bike empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Bike( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Bike( LocalVariable val ) { return new Bike( VariableContext.LOCAL, val.index ); }
        public static implicit operator Bike( GlobalVariable val ) { return new Bike( VariableContext.GLOBAL, val.index ); }

    }

}