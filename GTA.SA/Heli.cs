using GTA.Core;

namespace GTA {

    public class Heli : Vehicle<Heli>, IArrayItem, IVariable {

        private static Heli any = null;
        static Heli() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Heli empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Heli( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Heli grab_entity_on_magnet<T>( T hVehicle, Out<Actor> hActor, Out<Object> hObject ) where T : Vehicle<T> { Script.AppendLine( Opcodes._078B, check_OUT_Variable( hVehicle ), this, hActor, hObject ); return this; }
        public Heli hover_above_entity<T>( Actor hActor, T hVehicle, Float altitudeMin, Float altitudeMax ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0780, this, hVehicle, hActor, altitudeMin, altitudeMax ); return this; }
        public Heli disable_audio( Int state_bool ) { Script.AppendLine( Opcodes._0A1C, this, state_bool ); return this; }
        public Heli set_reached_target_distance( Int flag ) { Script.AppendLine( Opcodes._0853, this, flag ); return this; }
        public Heli select_weapons( Int state_bool ) { Script.AppendLine( Opcodes._0841, this, state_bool ); return this; }
        public Heli set_blades_full_speed() { Script.AppendLine( Opcodes._0825, this ); return this; }
        public Heli activate_speed_cheat( Int power ) { Script.AppendLine( Opcodes._07BB, this, power ); return this; }
        public Heli release_entity_from_magnet() { Script.AppendLine( Opcodes._0789, this ); return this; }
        public Heli enable_magnet( Int state_bool ) { Script.AppendLine( Opcodes._0788, this, state_bool ); return this; }
        public Heli fly_to( Float x, Float y, Float z, Float altitudeMin, Float altitudeMax ) { Script.AppendLine( Opcodes._04A2, this, x, y, z, altitudeMin, altitudeMax ); return this; }
        public Heli set_orientation( Float lookingAngle ) { Script.AppendLine( Opcodes._04D0, this, lookingAngle ); return this; }
        public Heli clear_orientation() { Script.AppendLine( Opcodes._04D1, this ); return this; }
        public Heli set_stabiliser( Int state_bool ) { Script.AppendLine( Opcodes._04DF, this, state_bool ); return this; }
        public Heli simulate_crash_landing() { Script.AppendLine( Opcodes._0564, this ); return this; }
        public Heli land_at_point( Float x, Float y, Float z, Float altitudeMin, Float altitudeMax ) { Script.AppendLine( Opcodes._0743, this, x, y, z, altitudeMin, altitudeMax ); return this; }
        public Heli attack_player( Player hPlayer, Float radius ) { Script.AppendLine( Opcodes._0724, this, hPlayer, radius ); return this; }
        public Heli follow_entity<T>( Actor hActorIfNeed, T hVehicleIfNeed, Float radius ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0726, this, hActorIfNeed, hVehicleIfNeed, radius ); return this; }
        public Heli chase_entity<T>( Actor hActorIfNeed, T hVehicleIfNeed, Float radius ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0727, this, hActorIfNeed, hVehicleIfNeed, radius ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Heli( LocalVariable val ) { return new Heli( VariableContext.LOCAL, val.index ); }
        public static implicit operator Heli( GlobalVariable val ) { return new Heli( VariableContext.GLOBAL, val.index ); }

    }

}