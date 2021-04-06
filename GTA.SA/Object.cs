using GTA.Core;

namespace GTA {

    public class Object : Handle<Object>, IArrayItem, IVariable {

        private static Object any = null;
        static Object() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Object empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Object( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Object get_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._01BB, this, x, y, z ); return this; }
        public Object get_z_angle( Out<Float> angle ) { Script.AppendLine( Opcodes._0176, angle, this ); return this; }
        public Object destroy() { Script.AppendLine( Opcodes._0108, this ); return this; }
        public Object remove_references() { Script.AppendLine( Opcodes._01C4, this ); return this; }
        public Object remove_from_mission_cleanup_list() { Script.AppendLine( Opcodes._01C7, this ); return this; }
        public Object place_relative_to_car<T>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ ) where T : Vehicle<T> { Script.AppendLine( Opcodes._035C, this, hVehicle, offsetX, offsetY, offsetZ ); return this; }
        public Object create( Int objectModel, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0107, check_OUT_Variable( this ), objectModel, x, y, z ); return this; }
        public Object init( Int objectModel, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._029B, check_OUT_Variable( this ), objectModel, x, y, z ); return this; }
        public Object set_position( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._01BC, this, x, y, z ); return this; }
        public Object set_z_angle( Float angle ) { Script.AppendLine( Opcodes._0177, this, angle ); return this; }
        public Object rotate( Float fromAngle, Float toAngle, Int flag_bool ) { Script.AppendLine( Opcodes._034D, this, fromAngle, toAngle, flag_bool ); return this; }
        public Object set_targetable( Int state_bool ) { Script.AppendLine( Opcodes._035D, this, state_bool ); return this; }
        public Object set_collision_detection( Int state_bool ) { Script.AppendLine( Opcodes._0382, this, state_bool ); return this; }
        public Object make_moveable( Int state_bool ) { Script.AppendLine( Opcodes._0392, this, state_bool ); return this; }
        public Object set_draw_last( Int state_bool ) { Script.AppendLine( Opcodes._0418, this, state_bool ); return this; }
        public Object set_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0381, this, x, y, z ); return this; }
        public Object add_to_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._038C, this, x, y, z ); return this; }
        public Object set_rotation( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0453, this, x, y, z ); return this; }
        public Object sort_out_collision_with_vehicle<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._050E, this, hVehicle ); return this; }
        public Object assign_to_lod_object( Object hLODObject ) { Script.AppendLine( Opcodes._0827, this, hLODObject ); return this; }
        public Object destroy_with_fade() { Script.AppendLine( Opcodes._09A2, this ); return this; }
        public Object clear_last_weapon_damage() { Script.AppendLine( Opcodes._0900, this ); return this; }
        public Object get_struct( Out<Memory> memory ) { Script.AppendLine( Opcodes._0A98, memory, this ); return this; }
        public Object get_quaternion( Out<Float> x, Out<Float> y, Out<Float> z, Out<Float> w ) { Script.AppendLine( Opcodes._07C3, this, x, y, z, w ); return this; }
        public Object get_mass( Out<Float> mass ) { Script.AppendLine( Opcodes._0907, this, mass ); return this; }
        public Object get_turn_mass( Out<Float> turnMass ) { Script.AppendLine( Opcodes._0909, this, turnMass ); return this; }
        public Object get_speed( Out<Float> speed ) { Script.AppendLine( Opcodes._05A8, this, speed ); return this; }
        public Object get_velocity( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._059F, this, x, y, z ); return this; }
        public Object get_rotation_velocity( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._05A6, this, x, y, z ); return this; }
        public Object get_health( Out<Int> health ) { Script.AppendLine( Opcodes._071E, this, health ); return this; }
        public Object get_level_design_coords( Int spoot, Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._080A, this, spoot, x, y, z ); return this; }
        public Object get_model( Out<Int> model ) { Script.AppendLine( Opcodes._0984, model, this ); return this; }
        public Object get_animation_progress( vString animationName, Out<Float> progress ) { Script.AppendLine( Opcodes._0839, this, animationName, progress ); return this; }
        public Object store_coords( Out<Float> x, Out<Float> y, Out<Float> z, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._0400, x, y, z, this, offsetX, offsetY, offsetZ ); return this; }
        public Object get_closest_stealable( Float x, Float y, Float z, Float radius ) { Script.AppendLine( Opcodes._0866, x, y, z, radius, Variable.check_OUT_Variable( this ) ); return this; }
        public Object set_quaternion( Float x, Float y, Float z, Float w ) { Script.AppendLine( Opcodes._07C4, this, x, y, z, w ); return this; }
        public Object attach<T>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0681, this, hVehicle, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ ); return this; }
        public Object attach( Object hObject2, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) { Script.AppendLine( Opcodes._069A, this, hObject2, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ ); return this; }
        public Object attach( Actor hActor, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) { Script.AppendLine( Opcodes._069B, this, hActor, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ ); return this; }
        public Object detach( Float x, Float y, Float z, Int collisionDetection_bool ) { Script.AppendLine( Opcodes._0682, this, x, y, z, collisionDetection_bool ); return this; }
        public Object set_mass( Float mass ) { Script.AppendLine( Opcodes._0906, this, mass ); return this; }
        public Object set_turn_mass( Float turnMass ) { Script.AppendLine( Opcodes._0908, this, turnMass ); return this; }
        public Object set_position_and_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0815, this, x, y, z ); return this; }
        public Object set_move_collisions( Int state_bool ) { Script.AppendLine( Opcodes._04D9, this, state_bool ); return this; }
        public Object keep_in_memory( Int state_bool ) { Script.AppendLine( Opcodes._0550, this, state_bool ); return this; }
        public Object set_rotation_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._05A2, this, x, y, z ); return this; }
        public Object add_to_rotation_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._05A1, this, x, y, z ); return this; }
        public Object add_relative_to_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._05A7, this, x, y, z ); return this; }
        public Object link_to_interior( Int interior_byte ) { Script.AppendLine( Opcodes._0566, this, interior_byte ); return this; }
        public Object make_fireproof( Int state_bool ) { Script.AppendLine( Opcodes._0654, this, state_bool ); return this; }
        public Object set_visibility( Int state_bool ) { Script.AppendLine( Opcodes._0750, this, state_bool ); return this; }
        public Object set_destructible( Int state_bool ) { Script.AppendLine( Opcodes._07F7, this, state_bool ); return this; }
        public Object set_immune_to_nonplayer( Int state_bool ) { Script.AppendLine( Opcodes._0875, this, state_bool ); return this; }
        public Object break_intensity( Int state_bool ) { Script.AppendLine( Opcodes._0723, this, state_bool ); return this; }
        public Object set_health( Int health ) { Script.AppendLine( Opcodes._071F, this, health ); return this; }
        public Object set_liftable( Int state_bool ) { Script.AppendLine( Opcodes._08E9, this, state_bool ); return this; }
        public Object set_attractive_to_magnet( Int state_bool ) { Script.AppendLine( Opcodes._0916, this, state_bool ); return this; }
        public Object set_scale_model( Float scale ) { Script.AppendLine( Opcodes._08D2, this, scale ); return this; }
        public Object enable_disabled_attractors( Int state_bool ) { Script.AppendLine( Opcodes._0A0A, this, state_bool ); return this; }
        public Object set_animation_progress( vString animationName, Float progress ) { Script.AppendLine( Opcodes._083A, this, animationName, progress ); return this; }
        public Object set_animation_speed( vString animationName, Float speed ) { Script.AppendLine( Opcodes._0836, this, animationName, speed ); return this; }
        public Object set_immunities( Int BP_bool, Int FP_bool, Int EP_bool, Int CP_bool, Int MP_bool ) { Script.AppendLine( Opcodes._09CA, this, BP_bool, FP_bool, EP_bool, CP_bool, MP_bool ); return this; }
        public Object set_immunities( Int all_bool ) { Script.AppendLine( Opcodes._09CA, this, all_bool, all_bool, all_bool, all_bool, all_bool ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_in_water() { return new Condition( Opcodes._04E7, this ); }
        public Condition is_stopped() { return new Condition( Opcodes._05A3, this ); }
        public Condition is_attached() { return new Condition( Opcodes._0685, this ); }
        public Condition is_moveable() { return new Condition( Opcodes._095B, this ); }
        public Condition is_photographed() { return new Condition( Opcodes._0833, this ); }
        public Condition is_intersecting_world() { return new Condition( Opcodes._09FC, this ); }
        public Condition is_within_brain_activation_range() { return new Condition( Opcodes._0977, this ); }
        public Condition is_collided_with_anything() { return new Condition( Opcodes._04DA, this ); }
        public Condition is_near_point_2d( Float x, Float y, Float radiusX, Float radiusY, Int shpere_bool ) { return new Condition( Opcodes._04E5, this, x, y, radiusX, radiusY, shpere_bool ); }
        public Condition is_near_point_3d( Float x, Float y, Float z, Float radiusX, Float radiusY, Float radiusZ, Int shpere_bool ) { return new Condition( Opcodes._04E6, this, x, y, z, radiusX, radiusY, radiusZ, shpere_bool ); }
        public Condition is_in_area_2d( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Int shpere_bool ) { return new Condition( Opcodes._04E9, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, shpere_bool ); }
        public Condition is_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Int shpere_bool ) { return new Condition( Opcodes._04EA, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, shpere_bool ); }
        public Condition is_in_angled_area_2d( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._08E3, this, shpere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle ); }
        public Condition is_in_angled_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._08E4, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_playing_animation( vString animationName ) { return new Condition( Opcodes._0837, this, animationName ); }
        public Condition is_damaged_by_weapon( Int damageType ) { return new Condition( Opcodes._08FF, this, damageType ); }
        public Condition is_have_model( Int objectModelID ) { return new Condition( Opcodes._09CC, this, objectModelID ); }
        public Condition play_animation( vString animationName, vString IFP_name, Float rate, Int lockF_bool, Int loop_bool ) { return new Condition( Opcodes._075A, this, animationName, IFP_name, rate, lockF_bool, loop_bool ); }
        public Condition find( Float x, Float y, Float z, Float radius, Int findNext_bool ) { return new Condition( Opcodes._0AE3, check_OUT_Variable( this ), x, y, z, radius, findNext_bool ); }
        public Condition is_damaged() { return new Condition( Opcodes._0366, this ); }
        public Condition is_on_screen() { return new Condition( Opcodes._02CC, this ); }
        public Condition is_exists() { return new Condition( Opcodes._03CA, this ); }
        public Condition move( Float x, Float y, Float z, Float speedX, Float speedY, Float speedZ, Float collisionCheck_bool ) { return new Condition( Opcodes._034E, this, x, y, z, speedX, speedY, speedZ, collisionCheck_bool ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Object( LocalVariable val ) { return new Object( VariableContext.LOCAL, val.index ); }
        public static implicit operator Object( GlobalVariable val ) { return new Object( VariableContext.GLOBAL, val.index ); }

    }

}