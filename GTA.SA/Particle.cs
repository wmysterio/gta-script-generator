using GTA.Core;

namespace GTA {

    public class Particle : Handle<Particle>, IArrayItem, IVariable {

        internal Particle( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Particle create( vString particleName, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._064B, this, particleName, x, y, z, "1" ); return this; }
        public Particle play() { Script.AppendLine( Opcodes._064C, this ); return this; }
        public Particle stop() { Script.AppendLine( Opcodes._064E, this ); return this; }
        public Particle play_and_destroy() { Script.AppendLine( Opcodes._064F, this ); return this; }
        public Particle destroy() { Script.AppendLine( Opcodes._0650, this ); return this; }
        public Particle destroy_now() { Script.AppendLine( Opcodes._0976, this ); return this; }
        public Particle attach_to_actor_bone( Actor hActor, Int boneID ) { Script.AppendLine( Opcodes._0883, this, hActor, boneID ); return this; }
        public Particle create_on_actor( Actor hActor, vString particleName, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._0669, this, particleName, hActor, offsetX, offsetY, offsetZ, "1" ); return this; }
        public Particle create_on_actor_with_direction( Actor hActor, vString particleName, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) { Script.AppendLine( Opcodes._066A, this, particleName, hActor, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ, "1" ); return this; }
        public Particle create_on_vehicle<T>( T hVehicle, vString particleName, Float offsetX, Float offsetY, Float offsetZ ) where T : Vehicle<T> { Script.AppendLine( Opcodes._066B, this, particleName, hVehicle, offsetX, offsetY, offsetZ, "1" ); return this; }
        public Particle create_on_vehicle_with_direction<T>( T hVehicle, vString particleName, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) where T : Vehicle<T> { Script.AppendLine( Opcodes._066C, this, particleName, hVehicle, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ, "1" ); return this; }
        public Particle create_on_object( Object hObject, vString particleName, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._066D, this, particleName, hObject, offsetX, offsetY, offsetZ, "1" ); return this; }
        public Particle create_on_object_with_direction( Object hObject, vString particleName, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) { Script.AppendLine( Opcodes._066E, particleName, hObject, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ, "1", this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Particle( LocalVariable val ) { return new Particle( VariableContext.LOCAL, val.index ); }
        public static implicit operator Particle( GlobalVariable val ) { return new Particle( VariableContext.GLOBAL, val.index ); }

    }

}