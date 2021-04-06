using GTA.Core;

namespace GTA {

    public class EntranceMarker : BaseMarker<EntranceMarker>, IArrayItem, IVariable {

        internal EntranceMarker( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public EntranceMarker create( Float x, Float y, Float z, Int color ) { Script.AppendLine( Opcodes._0A40, this, x, y, z, color ); return this; }
        public override EntranceMarker disable() { Script.AppendLine( Opcodes._0A41, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator EntranceMarker( LocalVariable val ) { return new EntranceMarker( VariableContext.LOCAL, val.index ); }
        public static implicit operator EntranceMarker( GlobalVariable val ) { return new EntranceMarker( VariableContext.GLOBAL, val.index ); }

    }

}