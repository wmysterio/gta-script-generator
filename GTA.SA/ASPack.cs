using GTA.Core;

namespace GTA {

    public class ASPack : Handle<ASPack>, IArrayItem, IVariable {

        public delegate void ASHandler( TaskManager task );

        // ---------------------------------------------------------------------------------------------------------------------------

        internal ASPack( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public ASPack define( ASHandler action, bool loop = false ) {
             Script.AppendLine( Opcodes._0615, this );
            if( action != null )
                action.Invoke( TaskManager.instance );
            if( loop )
                 Script.AppendLine( Opcodes._0643, this, loop );
             Script.AppendLine( Opcodes._0616, this );
            return this;
        }
        public ASPack clear() {  Script.AppendLine( Opcodes._061B, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator ASPack( LocalVariable val ) { return new ASPack( VariableContext.LOCAL, val.index ); }
        public static implicit operator ASPack( GlobalVariable val ) { return new ASPack( VariableContext.GLOBAL, val.index ); }

    }

}