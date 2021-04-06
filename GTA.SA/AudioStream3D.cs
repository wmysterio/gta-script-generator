using GTA.Core;

namespace GTA {

    public class AudioStream3D : BaseAudioStream<AudioStream3D>, IArrayItem, IVariable {

        internal AudioStream3D( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public AudioStream3D link_to_position( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0AC2, this, x, y, z ); return this; }
        public AudioStream3D link_to_object( Object hObject ) { Script.AppendLine( Opcodes._0AC3, this, hObject ); return this; }
        public AudioStream3D link_to_actor( Actor hActor ) { Script.AppendLine( Opcodes._0AC4, this, hActor ); return this; }
        public AudioStream3D link_to_vehicle<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0AC5, this, hVehicle ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public override Condition load( vString path ) { return new Condition( Opcodes._0AC1, this, path ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator AudioStream3D( LocalVariable val ) { return new AudioStream3D( VariableContext.LOCAL, val.index ); }
        public static implicit operator AudioStream3D( GlobalVariable val ) { return new AudioStream3D( VariableContext.GLOBAL, val.index ); }

    }

}