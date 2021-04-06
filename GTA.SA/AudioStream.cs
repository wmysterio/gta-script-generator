using GTA.Core;

namespace GTA {

    public class AudioStream : BaseAudioStream<AudioStream>, IArrayItem, IVariable {

        internal AudioStream( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator AudioStream( LocalVariable val ) { return new AudioStream( VariableContext.LOCAL, val.index ); }
        public static implicit operator AudioStream( GlobalVariable val ) { return new AudioStream( VariableContext.GLOBAL, val.index ); }

    }

}
