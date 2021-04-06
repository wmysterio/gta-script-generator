using GTA.Core;

namespace GTA {

    public class SearchFile : Handle<SearchFile>, IArrayItem, IVariable {

        internal SearchFile( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public SearchFile close() { Script.AppendLine( Opcodes._0AE8, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition find_next( Out<vString> fileName ) { return new Condition( Opcodes._0AE7, fileName, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator SearchFile( LocalVariable val ) { return new SearchFile( VariableContext.LOCAL, val.index ); }
        public static implicit operator SearchFile( GlobalVariable val ) { return new SearchFile( VariableContext.GLOBAL, val.index ); }

    }

}