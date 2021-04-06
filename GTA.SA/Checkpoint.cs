using GTA.Core;

namespace GTA {

    public class Checkpoint : BaseMarker<Checkpoint>, IArrayItem, IVariable {

        internal Checkpoint( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Checkpoint create( Float x, Float y, Float z ) {  Script.AppendLine( Opcodes._018A, this, x, y, z ); return this; }
        public Checkpoint set_appearance( Int checkpointType_byte ) { Script.AppendLine( Opcodes._08FB, this, checkpointType_byte ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_enabled() { return new Condition( Opcodes._075C, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Checkpoint( LocalVariable val ) { return new Checkpoint( VariableContext.LOCAL, val.index ); }
        public static implicit operator Checkpoint( GlobalVariable val ) { return new Checkpoint( VariableContext.GLOBAL, val.index ); }

    }

}