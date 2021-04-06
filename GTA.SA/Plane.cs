using GTA.Core;

namespace GTA {

    public class Plane : Vehicle<Plane>, IArrayItem, IVariable {

        private static Plane any = null;
        static Plane() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Plane empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Plane( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Plane get_undercarriage_position( Out<Float> position ) { Script.AppendLine( Opcodes._091F, this, position ); return this; }
        public Plane set_undercarriage_up( Int state_bool ) { Script.AppendLine( Opcodes._08E6, this, state_bool ); return this; }
        public Plane attack_player_using_dog_fight( Player hPlayer, Float radius ) { Script.AppendLine( Opcodes._08A2, this, hPlayer, radius ); return this; }
        public Plane fly_to( Float x, Float y, Float z, Float altitudeMin, Float altitudeMax ) { Script.AppendLine( Opcodes._04D2, this, x, y, z, altitudeMin, altitudeMax ); return this; }
        public Plane fly_in_direction( Float direction, Float altitudeMin, Float altitudeMax ) { Script.AppendLine( Opcodes._070F, this, direction, altitudeMin, altitudeMax ); return this; }
        public Plane attack_player( Player hPlayer, Float radius ) { Script.AppendLine( Opcodes._070E, this, hPlayer, radius ); return this; }
        public Plane follow_entity<T>( Actor hActorIfNeed, T hVehicleIfNeed, Float radius ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0710, this, hActorIfNeed, hVehicleIfNeed, radius ); return this; }
        public Plane set_throttle( Float val ) { Script.AppendLine( Opcodes._0742, this, val ); return this; }
        public Plane starts_in_air() { Script.AppendLine( Opcodes._0745, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Plane( LocalVariable val ) { return new Plane( VariableContext.LOCAL, val.index ); }
        public static implicit operator Plane( GlobalVariable val ) { return new Plane( VariableContext.GLOBAL, val.index ); }

    }

}