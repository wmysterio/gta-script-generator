using GTA.Core;

namespace GTA {

    public class Carriage : Handle<Carriage>, IArrayItem, IVariable {

        internal Carriage( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Carriage( LocalVariable val ) { return new Carriage( VariableContext.LOCAL, val.index ); }
        public static implicit operator Carriage( GlobalVariable val ) { return new Carriage( VariableContext.GLOBAL, val.index ); }
        public static implicit operator Car( Carriage train ) { return new Car( train.Context, train.Index ); }

    }

}