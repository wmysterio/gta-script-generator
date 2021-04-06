using GTA.Core;

namespace GTA {

    public class CarComponent : Handle<CarComponent>, IArrayItem, IVariable {

        internal CarComponent( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator CarComponent( LocalVariable val ) { return new CarComponent( VariableContext.LOCAL, val.index ); }
        public static implicit operator CarComponent( GlobalVariable val ) { return new CarComponent( VariableContext.GLOBAL, val.index ); }
        public static implicit operator Int( CarComponent hCarComponent ) { return new Int( hCarComponent.Context, hCarComponent.Index ); }

    }

}