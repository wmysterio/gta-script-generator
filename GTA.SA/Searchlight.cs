using GTA.Core;

namespace GTA {

    public class Searchlight : Handle<Searchlight>, IArrayItem, IVariable {

        internal Searchlight( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Searchlight create( Float x, Float y, Float z, Float radius, Float targetX, Float targetY, Float targetZ, Float targetRadius ) { Script.AppendLine( Opcodes._06B1, this, x, y, z, radius, targetX, targetY, targetZ, targetRadius ); return this; }
        public Searchlight create_on_vehicle<T>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ, Float radius, Float targetX, Float targetY, Float targetZ, Float targetRadius ) where T : Vehicle<T> { Script.AppendLine( Opcodes._06C1, this, hVehicle, offsetX, offsetY, offsetZ, radius, targetX, targetY, targetZ, targetRadius ); return this; }
        public Searchlight attach_to_searchlight_object( Object tower, Object housing, Object bulb, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._06CA, this, tower, housing, bulb, offsetX, offsetY, offsetZ ); return this; }
        public Searchlight set_clip_if_colliding( Int state_bool ) { Script.AppendLine( Opcodes._0941, this, state_bool ); return this; }
        public Searchlight switch_on_ground( Int state_bool ) { Script.AppendLine( Opcodes._0A02, this, state_bool ); return this; }
        public Searchlight destroy() { Script.AppendLine( Opcodes._06B2, this ); return this; }
        public Searchlight follow_actor( Actor hActor, Float speed ) { Script.AppendLine( Opcodes._06B6, this, hActor, speed ); return this; }
        public Searchlight follow_vehicle<T>( T hVehicle, Float speed ) where T : Vehicle<T> { Script.AppendLine( Opcodes._06BF, this, hVehicle, speed ); return this; }
        public Searchlight travel_to_point( Float x, Float y, Float z, Float speed ) { Script.AppendLine( Opcodes._06B5, this, x, y, z, speed ); return this; }
        public Searchlight move( Float fromX, Float fromY, Float fromZ, Float toX, Float toY, Float toZ, Float speed ) { Script.AppendLine( Opcodes._06B4, this, fromX, fromY, fromZ, toX, toY, toZ, speed ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_spotted_vehicle<T>( T hVehicle ) where T : Vehicle<T> { return new Condition( Opcodes._06C0, this, hVehicle ); }
        public Condition is_spotted_actor( Actor hActor ) { return new Condition( Opcodes._06B7, this, hActor ); }
        public Condition is_active() { return new Condition( Opcodes._06B3, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Searchlight( LocalVariable val ) { return new Searchlight( VariableContext.LOCAL, val.index ); }
        public static implicit operator Searchlight( GlobalVariable val ) { return new Searchlight( VariableContext.GLOBAL, val.index ); }

    }

}