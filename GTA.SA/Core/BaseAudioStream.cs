namespace GTA.Core {

    public abstract class BaseAudioStream<T> : Handle<T> where T : BaseAudioStream<T> {

        internal BaseAudioStream( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public T get_length( Out<Int> length ) { Script.AppendLine( Opcodes._0AAF, length, this ); return ( T ) this; }
        public T get_volume( Out<Float> volume ) { Script.AppendLine( Opcodes._0ABB, volume, this ); return ( T ) this; }
        public T get_state( Out<Int> state ) { Script.AppendLine( Opcodes._0AB9, this, state ); return ( T ) this; }
        public T release() { Script.AppendLine( Opcodes._0AAE, this ); return ( T ) this; }
        public T set_loop( Int state_bool ) { Script.AppendLine( Opcodes._0AC0, this, state_bool ); return ( T ) this; }
        public T set_volume( Float volume ) { Script.AppendLine( Opcodes._0ABC, this, volume ); return ( T ) this; }
        public T perform_action( Int audioStreamAction_byte ) { Script.AppendLine( Opcodes._0AAD, this, audioStreamAction_byte ); return ( T ) this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public virtual Condition load( vString path ) { return new Condition( Opcodes._0AAC, this, path ); }

    }

}
