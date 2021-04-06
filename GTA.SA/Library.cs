using GTA.Core;

namespace GTA {

    public class Library : Handle<Library>, IArrayItem, IVariable {

        internal Library( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Library free() {  Script.AppendLine( Opcodes._0AA3, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition get_proc( Out<Memory> address, vString name ) { return new Condition( Opcodes._0AA4, address, name, this ); }
        public Condition load( vString fileName ) { return new Condition( Opcodes._0AA2, check_OUT_Variable( this ), fileName ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Library( LocalVariable val ) { return new Library( VariableContext.LOCAL, val.index ); }
        public static implicit operator Library( GlobalVariable val ) { return new Library( VariableContext.GLOBAL, val.index ); }

    }

}