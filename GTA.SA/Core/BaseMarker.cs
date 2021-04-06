namespace GTA.Core {

    public abstract class BaseMarker<T> : Handle<T> where T : BaseMarker<T> {

        internal BaseMarker( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public virtual T disable() {  Script.AppendLine( Opcodes._0164, this ); return ( T ) this; }

    }

}