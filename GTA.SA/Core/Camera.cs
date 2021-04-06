using System;

namespace GTA.Core {

    public sealed class Camera {

        internal static readonly Camera instance = new Camera();

        private Camera() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Camera refresh( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._03CB, x, y, z ); return this; }
        public Camera set_position( Float x, Float y, Float z, Float rotation_x = null, Float rotation_y = null, Float rotation_z = null ) {
            if( ReferenceEquals( rotation_x, null ) )
                rotation_x = 0.0;
            if( ReferenceEquals( rotation_y, null ) )
                rotation_y = 0.0;
            if( ReferenceEquals( rotation_z, null ) )
                rotation_z = 0.0;
            Script.AppendLine( Opcodes._015F, x, y, z, rotation_x, rotation_y, rotation_z );
            return this;
        }
        public Camera set_point_at( Float x, Float y, Float z, Int switchStyle ) { Script.AppendLine( Opcodes._0160, x, y, z, switchStyle ); return this; }
        public Camera set_behind_player() { Script.AppendLine( Opcodes._0373 ); return this; }
        public Camera restore() { Script.AppendLine( Opcodes._015A ); return this; }
        public Camera shake( Int power ) { Script.AppendLine( Opcodes._0003, power ); return this; }
        public Camera restore_with_jumpcut() { Script.AppendLine( Opcodes._02EB ); return this; }
        public Camera set_mode_on_foot( Int zoom ) { Script.AppendLine( Opcodes._032A, zoom ); return this; }
        public Camera set_in_front_of_player() { Script.AppendLine( Opcodes._03C8 ); return this; }
        public Camera set_near_clip( Float val ) { Script.AppendLine( Opcodes._041D, val ); return this; }
        public Camera set_point_on_vehicle<T>( T hVehicle, Int mode, Int switchStyle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0158, hVehicle, mode, switchStyle ); return this; }
        public Camera set_point_on_actor( Actor hActor, Int mode, Int switchStyle ) { Script.AppendLine( Opcodes._0159, hActor, mode, switchStyle ); return this; }
        public Camera get_mode_on_vehicle( Out<Int> mode ) { Script.AppendLine( Opcodes._0A39, mode ); return this; }
        public Camera get_zoom( Out<Float> zoom ) { Script.AppendLine( Opcodes._0801, zoom ); return this; }
        public Camera get_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._068D, x, y, z ); return this; }
        public Camera get_point( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._068E, x, y, z ); return this; }
        public Camera reset_new_scriptables() { Script.AppendLine( Opcodes._0925 ); return this; }
        public Camera set_position_unfixed( Float x, Float z ) { Script.AppendLine( Opcodes._0A25, x, z ); return this; }
        public Camera set_shake_simulation_simple( Int type, Float timelimit, Float intensity ) { Script.AppendLine( Opcodes._099C, type, timelimit, intensity ); return this; }
        public Camera set_persist_point( Int state_bool ) { Script.AppendLine( Opcodes._092F, state_bool ); return this; }
        public Camera set_persist_position( Int state_bool ) { Script.AppendLine( Opcodes._0930, state_bool ); return this; }
        public Camera set_persist_zoom( Int state_bool ) { Script.AppendLine( Opcodes._0931, state_bool ); return this; }
        public Camera transverse_point( Float fromX, Float fromY, Float fromZ, Float toX, Float toY, Float toZ, Int time, Int transitionType_byte ) { Script.AppendLine( Opcodes._0920, fromX, fromY, fromZ, toX, toY, toZ, time, transitionType_byte ); return this; }
        public Camera transverse_position( Float fromX, Float fromY, Float fromZ, Float toX, Float toY, Float toZ, Int time, Int transitionType_byte ) { Script.AppendLine( Opcodes._0936, fromX, fromY, fromZ, toX, toY, toZ, time, transitionType_byte ); return this; }
        public Camera transverse_zoom( Float from, Float to, Int time, Int transitionType_byte ) { Script.AppendLine( Opcodes._0922, from, to, time, transitionType_byte ); return this; }
        public Camera attach_to_vehicle<T>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ, Float tilt, Int switchStyle_byte ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0679, hVehicle, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ, tilt, switchStyle_byte ); return this; }
        public Camera attach_to_ator( Actor hActor, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ, Float tilt, Int switchStyle_byte ) { Script.AppendLine( Opcodes._067C, hActor, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ, tilt, switchStyle_byte ); return this; }
        public Camera attach_to_vehicle_look_at_vehicle<T, K>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ, K hTarget, Float tilt, Int switchStyle_byte ) where T : Vehicle<T> where K : Vehicle<K> { Script.AppendLine( Opcodes._067A, hVehicle, offsetX, offsetY, offsetZ, hTarget, tilt, switchStyle_byte ); return this; }
        public Camera attach_to_vehicle_look_at_actor<T>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ, Actor hTarget, Float tilt, Int switchStyle_byte ) where T : Vehicle<T> { Script.AppendLine( Opcodes._067B, hVehicle, offsetX, offsetY, offsetZ, hTarget, tilt, switchStyle_byte ); return this; }
        public Camera attach_to_actor_look_at_actor( Actor hActor, Float offsetX, Float offsetY, Float offsetZ, Actor hTarget, Float tilt, Int switchStyle_byte ) { Script.AppendLine( Opcodes._067E, hActor, offsetX, offsetY, offsetZ, hTarget, tilt, switchStyle_byte ); return this; }
        public Camera set_photo_effect( Int state_bool ) { Script.AppendLine( Opcodes._0A2F, state_bool ); return this; }
        public Camera set_mode_cinema( Int state_bool ) { Script.AppendLine( Opcodes._093D, state_bool ); return this; }
        public Camera do_bump( Float rotationZ, Float rotationY ) { Script.AppendLine( Opcodes._0834, rotationZ, rotationY ); return this; }
        public Camera set_mode_two_player( Int state_bool ) { Script.AppendLine( Opcodes._06E0, state_bool ); return this; }
        public Camera set_mode_first_person_in_vehicle( Int state_bool ) { Script.AppendLine( Opcodes._0822, state_bool ); return this; }
        public Camera set_mode_on_vehicle( Int mode ) { Script.AppendLine( Opcodes._09AD, mode ); return this; }
        public Camera set_tweak_for_vehicle( Int vehicleModel, Float distance, Float altitudeMultiplier, Float angleX ) { Script.AppendLine( Opcodes._09EF, vehicleModel, distance, altitudeMultiplier, angleX ); return this; }
        public Camera reset_tweak_for_vehicle() { Script.AppendLine( Opcodes._09F0 ); return this; }
        public Camera allow_collision_fixed( Int state_bool ) { Script.AppendLine( Opcodes._09EC, state_bool ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_transversed_position() { return new Condition( Opcodes._0933 ); }
        public Condition is_transversed_point() { return new Condition( Opcodes._0934 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}