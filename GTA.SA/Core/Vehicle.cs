using System;
using GTA.Core.Languages;

namespace GTA.Core {

    public abstract class Vehicle<T> : Handle<T> where T : Vehicle<T> {

        internal Vehicle( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public T get_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._00AA, this, x, y, z ); return ( T ) this; }
        public T get_z_angle( Out<Float> angle ) { Script.AppendLine( Opcodes._0174, angle, this ); return ( T ) this; }
        public T get_speed( Out<Float> speed ) { Script.AppendLine( Opcodes._02E3, speed, this ); return ( T ) this; }
        public T get_number_of_passengers( Out<Int> number ) { Script.AppendLine( Opcodes._01E9, number, this ); return ( T ) this; }
        public T get_maximum_number_of_passengers( Out<Int> number ) { Script.AppendLine( Opcodes._01EA, number, this ); return ( T ) this; }
        public T get_health( Out<Int> health ) { Script.AppendLine( Opcodes._0227, health, this ); return ( T ) this; }
        public T get_forward_x( Out<Float> x ) { Script.AppendLine( Opcodes._02F8, this, x ); return ( T ) this; }
        public T get_forward_y( Out<Float> y ) { Script.AppendLine( Opcodes._02F9, this, y ); return ( T ) this; }
        public T get_colors( Out<Int> primaryColor, Out<Int> secondaryColor ) { Script.AppendLine( Opcodes._03F3, this, primaryColor, secondaryColor ); return ( T ) this; }
        public T create( Int vehicleModel, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._00A5, check_OUT_Variable( this ), vehicleModel, x, y, z ); return ( T ) this; }
        public T get_random_in_area_2d( Int vehicleModel, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { Script.AppendLine( Opcodes._0327, check_OUT_Variable( this ), vehicleModel, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); return ( T ) this; }
        public T set_position( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._00AB, this, x, y, z ); return ( T ) this; }
        public T set_z_angle( Float angle ) { Script.AppendLine( Opcodes._0175, this, angle ); return ( T ) this; }
        public T destroy() { Script.AppendLine( Opcodes._00A6, this ); return ( T ) this; }
        public T set_to_psycho_driver() { Script.AppendLine( Opcodes._00A8, this ); return ( T ) this; }
        public T set_to_normal_driver() { Script.AppendLine( Opcodes._00A9, this ); return ( T ) this; }
        public T set_traffic_behavior( Int trafficBehavior ) { Script.AppendLine( Opcodes._00AE, this, trafficBehavior ); return ( T ) this; }
        public T set_driver_behavior( Int carMission ) { Script.AppendLine( Opcodes._00AF, this, carMission ); return ( T ) this; }
        public T add_upsidedown_check() { Script.AppendLine( Opcodes._0190, this ); return ( T ) this; }
        public T remove_upsidedown_check() { Script.AppendLine( Opcodes._0191, this ); return ( T ) this; }
        public T remove_references() { Script.AppendLine( Opcodes._01C3, this ); return ( T ) this; }
        public T make_very_heavy( Int state_bool ) { Script.AppendLine( Opcodes._01EC, this, state_bool ); return ( T ) this; }
        public T explode() { Script.AppendLine( Opcodes._020B, this ); return ( T ) this; }
        public T set_door_status( Int doorStatus ) { Script.AppendLine( Opcodes._020A, this, doorStatus ); return ( T ) this; }
        public T set_health( Int health ) { Script.AppendLine( Opcodes._0224, this, health ); return ( T ) this; }
        public T set_colors( Int colorsVehiclePrimary, Int colorsVehicleSecondary ) { Script.AppendLine( Opcodes._0229, this, colorsVehiclePrimary, colorsVehicleSecondary ); return ( T ) this; }
        public T set_sprayable( Int state_bool ) { Script.AppendLine( Opcodes._0294, this, state_bool ); return ( T ) this; }
        public T set_only_damaged_by_player( Int state_bool ) { Script.AppendLine( Opcodes._02AA, this, state_bool ); return ( T ) this; }
        public T set_immunities( Int BP_bool, Int FP_bool, Int EP_bool, Int CP_bool, Int MP_bool ) { Script.AppendLine( Opcodes._02AC, this, BP_bool, FP_bool, EP_bool, CP_bool, MP_bool ); return ( T ) this; }
        public T set_immunities( Int all_bool ) { Script.AppendLine( Opcodes._02AC, this, all_bool, all_bool, all_bool, all_bool, all_bool ); return ( T ) this; }
        public T enable_siren( Int state_bool ) { Script.AppendLine( Opcodes._0397, this, state_bool ); return ( T ) this; }
        public T set_watertight( Int state_bool ) { Script.AppendLine( Opcodes._039C, this, state_bool ); return ( T ) this; }
        public T turn_to_face_coord( Float x, Float y ) { Script.AppendLine( Opcodes._039F, this, x, y ); return ( T ) this; }
        public T set_action( Int action ) { Script.AppendLine( Opcodes._03A2, this, action ); return ( T ) this; }
        public T set_strong( Int state_bool ) { Script.AppendLine( Opcodes._03AB, this, state_bool ); return ( T ) this; }
        public T remove_stuck_check() { Script.AppendLine( Opcodes._03CD, this ); return ( T ) this; }
        public T add_stuck_check( Float distance, Int time ) { Script.AppendLine( Opcodes._03CC, this, distance, time ); return ( T ) this; }
        public T not_damaged_when_flipped( Int state_bool ) { Script.AppendLine( Opcodes._03ED, this, state_bool ); return ( T ) this; }
        public T set_can_be_damaged( Int state_bool ) { Script.AppendLine( Opcodes._03F5, this, state_bool ); return ( T ) this; }
        public T set_improved_handling( Int traction ) { Script.AppendLine( Opcodes._0423, this, traction ); return ( T ) this; }
        public T set_avoid_level_transitions( Int state_bool ) { Script.AppendLine( Opcodes._0428, this, state_bool ); return ( T ) this; }
        /// <summary>
        /// Возвращает -1, если не найдено<br/><br/>
        /// Returns -1 if not found
        /// </summary>
        public T get_available_components( Int componentPoolIndex, Out<Int> modelIDMaybe ) { Script.AppendLine( Opcodes._06E5, this, componentPoolIndex, modelIDMaybe ); return ( T ) this; }
        public T get_struct( Out<Memory> memory ) { Script.AppendLine( Opcodes._0A97, memory, this ); return ( T ) this; }
        public T get_blocking_vehicle<K>( Out<Vehicle<K>> hTarget ) where K : Vehicle<K> { Script.AppendLine( Opcodes._0987, this, hTarget ); return ( T ) this; }
        public T get_driver( Out<Actor> hActor ) { Script.AppendLine( Opcodes._046C, hActor, this ); return ( T ) this; }
        public T get_actor_in_passenger_seat( Int passengerSeat, Out<Actor> hActor ) { Script.AppendLine( Opcodes._0432, hActor, this, passengerSeat ); return ( T ) this; }
        public T get_number_of_gears( Out<Int> gears ) { Script.AppendLine( Opcodes._0AB7, this, gears ); return ( T ) this; }
        public T get_current_gear( Out<Int> gear ) { Script.AppendLine( Opcodes._0AB8, this, gear ); return ( T ) this; }
        public T get_extra_colors( Out<Int> tertiaryColor, Out<Int> quaternaryColor ) { Script.AppendLine( Opcodes._0A12, this, tertiaryColor, quaternaryColor ); return ( T ) this; }
        public T get_door_lock_status( Out<Int> status ) { Script.AppendLine( Opcodes._09B3, this, status ); return ( T ) this; }
        public T get_extra_parts_angle( Out<Float> angle ) { Script.AppendLine( Opcodes._098D, this, angle ); return ( T ) this; }
        public T get_door_angle_ratio( Int doorNumber, Out<Float> angle ) { Script.AppendLine( Opcodes._095F, this, doorNumber, angle ); return ( T ) this; }
        public T get_class( Out<Int> vehicleClass ) { Script.AppendLine( Opcodes._08EC, vehicleClass, this ); return ( T ) this; }
        public T get_upright_value( Out<Float> val ) { Script.AppendLine( Opcodes._083F, this, val ); return ( T ) this; }
        public T get_quaternion( Out<Float> x, Out<Float> y, Out<Float> z, Out<Float> w ) { Script.AppendLine( Opcodes._07C5, this, x, y, z, w ); return ( T ) this; }
        public T get_pitch( Out<Float> angle ) { Script.AppendLine( Opcodes._077D, angle, this ); return ( T ) this; }
        public T get_model( Out<Int> vehicleModelID ) { Script.AppendLine( Opcodes._0441, vehicleModelID, this ); return ( T ) this; }
        public T get_speed_vector( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._06A2, this, x, y, z ); return ( T ) this; }
        public T get_mass( Out<Float> mass ) { Script.AppendLine( Opcodes._06A3, this, mass ); return ( T ) this; }
        public T get_roll( Out<Float> y ) { Script.AppendLine( Opcodes._06BE, this, y ); return ( T ) this; }
        public T store_coords( Out<Float> x, Out<Float> y, Out<Float> z, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._0407, x, y, z, this, offsetX, offsetY, offsetZ ); return ( T ) this; }
        public T add_reference() {
            if( Script.Current.ScriptType != TypeOfScript.MISSION )
                throw new Exception( Localization.MethodUsedInMissionOnly( nameof( add_reference ) ) );
            Script.AppendLine( Opcodes._0763, this );
            return ( T ) this;
        }
        public T get_random_of_type_in_angled_area_2d_no_save( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Actor hActorIfNeed ) { Script.AppendLine( Opcodes._09C0, Variable.check_OUT_Variable( this ), cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, hActorIfNeed ); return ( T ) this; }
        public T get_random_of_type_in_area_2d_no_save( Actor hActorIfNeed, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { Script.AppendLine( Opcodes._053E, Variable.check_OUT_Variable( this ), hActorIfNeed, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); return ( T ) this; }
        public T get_random_in_point_3d_no_save( Float x, Float y, Float z, Float radius, Int vehicleModel ) { Script.AppendLine( Opcodes._073E, x, y, z, radius, vehicleModel, Variable.check_OUT_Variable( this ) ); return ( T ) this; }
        public T set_visible( Int state_bool ) { Script.AppendLine( Opcodes._0338, this, state_bool ); return ( T ) this; }
        public T enable_engine( Int state_bool ) { Script.AppendLine( Opcodes._0ABF, this, state_bool ); return ( T ) this; }
        public T set_extra_colors( Int colorVehicleTertiary, Int colorVehicleQuaternary ) { Script.AppendLine( Opcodes._0A11, this, colorVehicleTertiary, colorVehicleQuaternary ); return ( T ) this; }
        public T repair() { Script.AppendLine( Opcodes._0A30, this ); return ( T ) this; }
        public T improve_by_cheating( Int state_bool ) { Script.AppendLine( Opcodes._0A21, this, state_bool ); return ( T ) this; }
        public T play_audio_event( Int eventID ) { Script.AppendLine( Opcodes._09F7, this, eventID ); return ( T ) this; }
        public T random_passenger_say( Int audioTable ) { Script.AppendLine( Opcodes._09AB, this, audioTable ); return ( T ) this; }
        public T set_is_considered_by_player( Int state_bool ) { Script.AppendLine( Opcodes._09B0, this, state_bool ); return ( T ) this; }
        public T change_path_to_use_ai() { Script.AppendLine( Opcodes._099B, this ); return ( T ) this; }
        public T set_collision_detection( Int state_bool ) { Script.AppendLine( Opcodes._099A, this, state_bool ); return ( T ) this; }
        public T set_extra_parts_angle( Float angle ) { Script.AppendLine( Opcodes._08A4, this, angle ); return ( T ) this; }
        public T set_control_door( Int doorNumber, Int unlatch, Float angle ) { Script.AppendLine( Opcodes._095E, this, doorNumber, unlatch, angle ); return ( T ) this; }
        public T set_provides_cover_from_gunfire( Int state_bool ) { Script.AppendLine( Opcodes._0957, this, state_bool ); return ( T ) this; }
        public T attach_to_object( Object hObject, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) { Script.AppendLine( Opcodes._0939, this, hObject, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ ); return ( T ) this; }
        public T set_engine_on( Int state_bool ) { Script.AppendLine( Opcodes._0918, this, state_bool ); return ( T ) this; }
        public T set_lights_on( Int state_bool ) { Script.AppendLine( Opcodes._0919, this, state_bool ); return ( T ) this; }
        public T set_freebies( Int state_bool ) { Script.AppendLine( Opcodes._08F3, this, state_bool ); return ( T ) this; }
        public T set_targettable_by_heatseeker( Int state_bool ) { Script.AppendLine( Opcodes._08F2, this, state_bool ); return ( T ) this; }
        public T explode_in_cutscene_shake_and_bits( Int shake_bool, Int effect_bool, Int sound_bool ) { Script.AppendLine( Opcodes._08CB, this, shake_bool, effect_bool, sound_bool ); return ( T ) this; }
        public T open_door_a_bit( Int doorNumber, Float angle ) { Script.AppendLine( Opcodes._08A6, this, doorNumber, angle ); return ( T ) this; }
        public T set_attractive_to_magnet( Int state_bool ) { Script.AppendLine( Opcodes._08A5, this, state_bool ); return ( T ) this; }
        public T set_position_no_offset( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._088C, this, x, y, z ); return ( T ) this; }
        public T set_air_resistance_multiplier( Float multiplier ) { Script.AppendLine( Opcodes._088B, this, multiplier ); return ( T ) this; }
        public T set_dirt_level( Float level ) { Script.AppendLine( Opcodes._0878, this, level ); return ( T ) this; }
        public T start_looped_path( Int pathNumber ) { Script.AppendLine( Opcodes._085E, this, pathNumber ); return ( T ) this; }
        public T set_can_be_visibly_damaged( Int state_bool ) { Script.AppendLine( Opcodes._0852, this, state_bool ); return ( T ) this; }
        public T set_can_be_targetted( Int state_bool ) { Script.AppendLine( Opcodes._084E, this, state_bool ); return ( T ) this; }
        public T link_to_interior( Int interiorID ) { Script.AppendLine( Opcodes._0840, this, interiorID ); return ( T ) this; }
        public T set_engine_broken( Int state_bool ) { Script.AppendLine( Opcodes._081D, this, state_bool ); return ( T ) this; }
        public T follow_vehicle<K>( Vehicle<K> hTarget, Float radius ) where K : Vehicle<K> { Script.AppendLine( Opcodes._07F8, this, hTarget, radius ); return ( T ) this; }
        public T set_always_create_skids( Int state_bool ) { Script.AppendLine( Opcodes._07EE, this, state_bool ); return ( T ) this; }
        public T add_to_rotation_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._07DA, this, x, y, z ); return ( T ) this; }
        public T set_rotation_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._07DB, this, x, y, z ); return ( T ) this; }
        public T apply_force( Float x, Float y, Float z, Float velocityX, Float velocitY, Float unknown ) { Script.AppendLine( Opcodes._07D5, this, x, y, z, velocityX, velocitY, unknown ); return ( T ) this; }
        public T set_quaternion( Float x, Float y, Float z, Float w ) { Script.AppendLine( Opcodes._07C6, this, x, y, z, w ); return ( T ) this; }
        public T enable_gas_tank_explosion( Int state_bool ) { Script.AppendLine( Opcodes._09C4, this, state_bool ); return ( T ) this; }
        public T stop_recording() { Script.AppendLine( Opcodes._0752, this ); return ( T ) this; }
        public T set_stay_in_fast_lane( Int state_bool ) { Script.AppendLine( Opcodes._0466, this, state_bool ); return ( T ) this; }
        public T clear_last_weapon_damage() { Script.AppendLine( Opcodes._0468, this ); return ( T ) this; }
        public T set_random_route_seed( Float routeSeed ) { Script.AppendLine( Opcodes._048B, this, routeSeed ); return ( T ) this; }
        public T set_is_part_of_convoy( Int state_bool ) { Script.AppendLine( Opcodes._04BD, this, state_bool ); return ( T ) this; }
        public T set_forward_speed( Float seed ) { Script.AppendLine( Opcodes._04BA, this, seed ); return ( T ) this; }
        public T pop_boot() { Script.AppendLine( Opcodes._04E1, this ); return ( T ) this; }
        public T set_straight_line_distance( Int totalOccupants ) { Script.AppendLine( Opcodes._04E0, this, totalOccupants ); return ( T ) this; }
        public T deflate_tire( Int tireID ) { Script.AppendLine( Opcodes._04FE, tireID, this ); return ( T ) this; }
        public T close_all_doors() { Script.AppendLine( Opcodes._0508, this ); return ( T ) this; }
        public T lock_position( Int state_bool ) { Script.AppendLine( Opcodes._0519, this, state_bool ); return ( T ) this; }
        public T set_tires_vulnerable( Int state_bool ) { Script.AppendLine( Opcodes._053F, this, state_bool ); return ( T ) this; }
        public T enable_guns_sound( Int state_bool ) { Script.AppendLine( Opcodes._0541, this, state_bool ); return ( T ) this; }
        public T clear_last_damage() { Script.AppendLine( Opcodes._054F, this ); return ( T ) this; }
        public T freeze_position_and_dont_load_collision( Int state_bool ) { Script.AppendLine( Opcodes._0574, this, state_bool ); return ( T ) this; }
        public T set_to_fade_in( Int alpha_byte ) { Script.AppendLine( Opcodes._0594, this, alpha_byte ); return ( T ) this; }
        public T enable_validate_position( Int state_bool ) { Script.AppendLine( Opcodes._0587, this, state_bool ); return ( T ) this; }
        public T start_path( Int pathNumber ) { Script.AppendLine( Opcodes._05EB, this, pathNumber ); return ( T ) this; }
        public T stop_path() { Script.AppendLine( Opcodes._05EC, this ); return ( T ) this; }
        public T pause_path() { Script.AppendLine( Opcodes._05ED, this ); return ( T ) this; }
        public T continue_path() { Script.AppendLine( Opcodes._05EE, this ); return ( T ) this; }
        public T set_escort_vehicle_left<K>( Vehicle<K> hTarget ) where K : Vehicle<K> { Script.AppendLine( Opcodes._05F1, this, hTarget ); return ( T ) this; }
        public T set_escort_vehicle_right<K>( Vehicle<K> hTarget ) where K : Vehicle<K> { Script.AppendLine( Opcodes._05F2, this, hTarget ); return ( T ) this; }
        public T set_escort_vehicle_rear<K>( Vehicle<K> hTarget ) where K : Vehicle<K> { Script.AppendLine( Opcodes._05F3, this, hTarget ); return ( T ) this; }
        public T set_escort_vehicle_front<K>( Vehicle<K> hTarget ) where K : Vehicle<K> { Script.AppendLine( Opcodes._05F4, this, hTarget ); return ( T ) this; }
        public T open_door( Int doorNumber ) { Script.AppendLine( Opcodes._0657, this, doorNumber ); return ( T ) this; }
        public T force_lights( Int vehicleLightType ) { Script.AppendLine( Opcodes._067F, this, vehicleLightType ); return ( T ) this; }
        public T attach_to_vehicle<K>( K hTarget, Float offsetX, Float offsetY, Float offsetZ, Float rotationX, Float rotationY, Float rotationZ ) where K : Vehicle<K> { Script.AppendLine( Opcodes._0683, this, hTarget, offsetX, offsetY, offsetZ, rotationX, rotationY, rotationZ ); return ( T ) this; }
        public T detach( Float x, Float y, Float z, Int collisionDetection_bool ) { Script.AppendLine( Opcodes._0684, this, x, y, z, collisionDetection_bool ); return ( T ) this; }
        public T start_path_using_ai( Int pathNumber ) { Script.AppendLine( Opcodes._0705, this, pathNumber ); return ( T ) this; }
        public T skip_in_path( Float maxPathTime ) { Script.AppendLine( Opcodes._0706, this, maxPathTime ); return ( T ) this; }
        public T skip_to_end_and_stop_path() { Script.AppendLine( Opcodes._06C5, this ); return ( T ) this; }
        public T remove_door( Int doorNumber, Int visibleEffect_bool ) { Script.AppendLine( Opcodes._0689, this, doorNumber, visibleEffect_bool ); return ( T ) this; }
        public T repair_door( Int doorNumber ) { Script.AppendLine( Opcodes._068A, this, doorNumber ); return ( T ) this; }
        public T all_passengers_disembark() { Script.AppendLine( Opcodes._068B, this ); return ( T ) this; }
        public T remove_panel( Int panelNumber, Int visibleEffect_bool ) { Script.AppendLine( Opcodes._0697, this, panelNumber, visibleEffect_bool ); return ( T ) this; }
        public T repair_panel( Int panelNumber ) { Script.AppendLine( Opcodes._0698, this, panelNumber ); return ( T ) this; }
        public T repair_tire( Int tireNumber ) { Script.AppendLine( Opcodes._0699, this, tireNumber ); return ( T ) this; }
        public T set_path_speed( Float speed ) { Script.AppendLine( Opcodes._06FD, this, speed ); return ( T ) this; }
        public T explode_in_cutscene() { Script.AppendLine( Opcodes._070C, this ); return ( T ) this; }
        public T set_stay_in_slow_lane( Int state_bool ) { Script.AppendLine( Opcodes._0714, this, state_bool ); return ( T ) this; }
        public T add_stuck_check_with_warp( Float distance, Int time, Int stuck_bool, Int flipped_bool, Int unknown_bool, Int pathNumberIfNeed ) { Script.AppendLine( Opcodes._072F, this, distance, time, stuck_bool, flipped_bool, unknown_bool, pathNumberIfNeed ); return ( T ) this; }
        public T damage_panel( Int panelNumber ) { Script.AppendLine( Opcodes._0730, this, panelNumber ); return ( T ) this; }
        public T set_roll( Float y ) { Script.AppendLine( Opcodes._0731, this, y ); return ( T ) this; }
        public T set_can_go_against_traffic( Int state_bool ) { Script.AppendLine( Opcodes._073B, this, state_bool ); return ( T ) this; }
        public T damage_door( Int doorNumber ) { Script.AppendLine( Opcodes._073C, this, doorNumber ); return ( T ) this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_colliding_with_vehicle<K>( Vehicle<K> hTarget ) where K : Vehicle<K> { return new Condition( Opcodes._09CB, this, hTarget ); }
        public Condition is_on_all_wheels() { return new Condition( Opcodes._09D0, this ); }
        public Condition is_has_been_resprayed() { return new Condition( Opcodes._0A15, this ); }
        public Condition is_siren_on() { return new Condition( Opcodes._0ABD, this ); }
        public Condition is_engine_on() { return new Condition( Opcodes._0ABE, this ); }
        public Condition is_visibly_damaged() { return new Condition( Opcodes._03C9, this ); }
        public Condition is_have_stuck_check() { return new Condition( Opcodes._06FC, this ); }
        public Condition is_in_searchlight( Searchlight hSearchlight ) { return new Condition( Opcodes._06C0, hSearchlight, this ); }
        public Condition is_recording_going_on() { return new Condition( Opcodes._06AA, this ); }
        public Condition is_attached() { return new Condition( Opcodes._0686, this ); }
        public Condition is_assigned_to_path() { return new Condition( Opcodes._060E, this ); }
        public Condition is_defined() { return new Condition( Opcodes._056E, this ); }
        public Condition is_damaged_by_actor( Actor hActor ) { return new Condition( Opcodes._051C, this, hActor ); }
        public Condition is_damaged_by_vehicle<K>( K target ) where K : Vehicle<K> { return new Condition( Opcodes._051D, this, target ); }
        public Condition is_waiting_for_world_collision() { return new Condition( Opcodes._04F1, this ); }
        public Condition is_burning() { return new Condition( Opcodes._0495, this ); }
        public Condition is_have_hydraulics() { return new Condition( Opcodes._0803, this ); }
        public Condition is_colliding_with_object( Object hObject ) { return new Condition( Opcodes._0897, this, hObject ); }
        public Condition is_big() { return new Condition( Opcodes._0969, this ); }
        public Condition is_low_rider() { return new Condition( Opcodes._096E, this ); }
        public Condition is_street_racer() { return new Condition( Opcodes._096F, this ); }
        public Condition is_emergency_services() { return new Condition( Opcodes._0975, this ); }
        public Condition is_tire_deflated( Int tireNumber_int ) { return new Condition( Opcodes._0496, tireNumber_int, this ); }
        public Condition is_door_fully_open( Int doorNumber_int ) { return new Condition( Opcodes._08A7, this, doorNumber_int ); }
        public Condition is_door_damaged( Int doorID_int ) { return new Condition( Opcodes._09BB, this, doorID_int ); }
        public Condition find( Float x_float, Float y_float, Float z_float, Float radius_float, Int passWrecked_bool, Int findNext_bool ) { return new Condition( Opcodes._0AE2, check_OUT_Variable( this ), x_float, y_float, z_float, radius_float, findNext_bool, passWrecked_bool ); }
        public Condition is_passenger_seat_free( Int passengerSeat ) { return new Condition( Opcodes._0431, this, passengerSeat ); }
        public Condition is_stuck() { return new Condition( Opcodes._03CE, this ); }
        public Condition is_damaged_by_weapon( Int damageType ) { return new Condition( Opcodes._031E, this, damageType ); }
        public Condition is_on_screen() { return new Condition( Opcodes._02CA, this ); }
        public Condition is_in_water() { return new Condition( Opcodes._02BF, this ); }
        public Condition is_upright() { return new Condition( Opcodes._020D, this ); }
        public Condition is_in_air() { return new Condition( Opcodes._01F3, this ); }
        public Condition is_flipped() { return new Condition( Opcodes._01F4, this ); }
        public Condition is_stuck_on_roof() { return new Condition( Opcodes._018F, this ); }
        public Condition is_health_greater( Int health ) { return new Condition( Opcodes._0185, this, health ); }
        public Condition is_current_model( Int vehicleModelId ) { return new Condition( Opcodes._0137, this, vehicleModelId ); }
        public Condition is_wrecked() { return new Condition( Opcodes._0119, this ); }
        public Condition is_stopped() { return new Condition( Opcodes._01C1, this ); }
        public Condition is_near_point_3d( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._01AF, this, sphere_bool, x, y, z, radius_x, radius_y, radius_z ); }
        public Condition is_near_point_3d_stopped( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._01B0, this, sphere_bool, x, y, z, radius_x, radius_y, radius_z ); }
        public Condition is_in_area_3d( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._00B1, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_in_area_3d_stopped( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._01AC, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_near_point_2d( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._01AD, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_point_2d_stopped( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._01AE, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_in_area_2d( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._00B0, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_area_2d_stopped( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._01AB, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }

    }

}