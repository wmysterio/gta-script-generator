using GTA.Core;

namespace GTA {

    public class Actor : Handle<Actor>, IArrayItem, IVariable {

        private static Actor any = null;
        static Actor() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Actor empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        public readonly TaskManager task = null;

        internal Actor( VariableContext context, ushort index ) : base( context, index ) { task = new TaskManager( this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Actor get_mission_vehicle<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._00D9, check_OUT_Variable( hVehicle ), this ); return this; }
        public Actor get_current_vehicle<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._03C0, check_OUT_Variable( hVehicle ), this ); return this; }
        public Actor get_armor( Out<Int> armor ) { Script.AppendLine( Opcodes._04DD, armor, this ); return this; }
        public Actor get_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._00A0, this, x, y, z ); return this; }
        public Actor get_z_angle( Out<Float> angle ) { Script.AppendLine( Opcodes._0172, angle, this ); return this; }
        public Actor get_health( Out<Int> health ) { Script.AppendLine( Opcodes._0226, health, this ); return this; }
        public Actor store_coords( Out<Float> x, Out<Float> y, Out<Float> z, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._04C4, x, y, z, this, offsetX, offsetY, offsetZ ); return this; }
        public Actor put_into_vehicle<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._036A, this, hVehicle ); return this; }
        public Actor create( Int actorType, Int actorModel, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._009A, check_OUT_Variable( this ), actorType, actorModel, x, y, z ); return this; }
        public Actor create_in_vehicle_driverseat<T>( Int actorType, Int actorModel, Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0129, check_OUT_Variable( this ), actorType, actorModel, hVehicle ); return this; }
        public Actor create_in_vehicle_passenger_seat<T>( Int actorType, Int actorModel, Vehicle<T> hVehicle, Int passengerSeat ) where T : Vehicle<T> { Script.AppendLine( Opcodes._01C8, check_OUT_Variable( this ), actorType, actorModel, hVehicle, passengerSeat ); return this; }
        public Actor create_random( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0376, check_OUT_Variable( this ), x, y, z ); return this; }
        public Actor set_only_damaged_by_player( Int state_bool ) { Script.AppendLine( Opcodes._02A9, this, state_bool ); return this; }
        public Actor set_position( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._00A1, this, x, y, z ); return this; }
        public Actor give_weapon( Int weaponNumber, Int ammoCount ) { Script.AppendLine( Opcodes._01B2, this, weaponNumber, ammoCount ); return this; }
        public Actor set_armed_weapon( Int weaponNumber ) { Script.AppendLine( Opcodes._01B9, this, weaponNumber ); return this; }
        public Actor remove_references() { Script.AppendLine( Opcodes._01C2, this ); return this; }
        public Actor destroy() { Script.AppendLine( Opcodes._009B, this ); return this; }
        public Actor set_z_angle( Float angle ) { Script.AppendLine( Opcodes._0173, this, angle ); return this; }
        public Actor add_ammo( Int weaponNumber, Int ammoCount ) { Script.AppendLine( Opcodes._0114, this, weaponNumber, ammoCount ); return this; }
        public Actor set_ammo( Int weaponNumber, Int ammoCount ) { Script.AppendLine( Opcodes._017B, this, weaponNumber, ammoCount ); return this; }
        public Actor remove_from_mission_cleanup_list() { Script.AppendLine( Opcodes._01C5, this ); return this; }
        public Actor set_health( Int health ) { Script.AppendLine( Opcodes._0223, this, health ); return this; }
        public Actor set_immunities( Int BP_bool, Int FP_bool, Int EP_bool, Int CP_bool, Int MP_bool ) { Script.AppendLine( Opcodes._02AB, this, BP_bool, FP_bool, EP_bool, CP_bool, MP_bool ); return this; }
        public Actor set_immunities( Int all_bool ) { Script.AppendLine( Opcodes._02AB, this, all_bool, all_bool, all_bool, all_bool, all_bool ); return this; }
        public Actor set_weapon_accuracy( Int accuracy ) { Script.AppendLine( Opcodes._02E2, this, accuracy ); return this; }
        public Actor set_bleeding( Int state_bool ) { Script.AppendLine( Opcodes._0332, this, state_bool ); return this; }
        public Actor set_visible( Int state_bool ) { Script.AppendLine( Opcodes._0337, this, state_bool ); return this; }
        public Actor destroy_with_fade() { Script.AppendLine( Opcodes._034F, this ); return this; }
        public Actor set_stay_in_same_place( Int state_bool ) { Script.AppendLine( Opcodes._0350, this, state_bool ); return this; }
        public Actor add_armor( Int amount ) { Script.AppendLine( Opcodes._035F, this, amount ); return this; }
        public Actor remove_from_vehicle_and_place_at( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0362, this, x, y, z ); return this; }
        public Actor set_cant_be_dragged_out( Int state_bool ) { Script.AppendLine( Opcodes._039E, this, state_bool ); return this; }
        public Actor set_is_chris_criminal( Int state_bool ) { Script.AppendLine( Opcodes._0433, this, state_bool ); return this; }
        public Actor get_closest_vehicle_and_actor<T>( Vehicle<T> hVehicle, Out<Actor> hActor ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0AB5, this, hVehicle, hActor ); return this; }
        public Actor get_vehicle_is_using<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0811, check_OUT_Variable( hVehicle ), this ); return this; }
        public Actor store_vehicle_if_attached<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0A33, this, check_OUT_Variable( hVehicle ) ); return this; }
        /// <summary>
        /// Возвращает 7, если не найдено!<br/><br/>
        /// Return 7 if not found!
        /// </summary>
        public Actor get_task_status( Int taskID, Out<Int> status ) { Script.AppendLine( Opcodes._062E, this, taskID, status ); return this; }
        public Actor get_struct( Out<Memory> memory ) { Script.AppendLine( Opcodes._0A96, memory, this ); return this; }
        public Actor get_pedtype( Out<Int> actorType ) { Script.AppendLine( Opcodes._089F, this, actorType ); return this; }
        public Actor get_active_interior_name( Out<vString> name ) { Script.AppendLine( Opcodes._094B, name, this ); return this; }
        public Actor get_active_interior( Out<Int> interiorID ) { Script.AppendLine( Opcodes._09E8, interiorID, this ); return this; }
        public Actor get_swimming_state( Out<Int> status ) { Script.AppendLine( Opcodes._0966, this, status ); return this; }
        public Actor get_distance_from_ground( Out<Float> distance ) { Script.AppendLine( Opcodes._0819, distance, this ); return this; }
        public Actor get_ped_event( Out<Int> eventID ) { Script.AppendLine( Opcodes._080E, this, eventID ); return this; }
        public Actor get_number_of_followers( Out<Int> count ) { Script.AppendLine( Opcodes._046D, count, this ); return this; }
        public Actor get_current_weapon( Out<Int> weaponNumber ) { Script.AppendLine( Opcodes._0470, weaponNumber, this ); return this; }
        public Actor get_model( Out<Int> modelID ) { Script.AppendLine( Opcodes._0665, this, modelID ); return this; }
        public Actor get_speed( Out<Float> speed ) { Script.AppendLine( Opcodes._06AC, speed, this ); return this; }
        public Actor get_ammo_in_weapon( Int weaponNumber, Out<Int> ammoCount ) { Script.AppendLine( Opcodes._041A, ammoCount, this, weaponNumber ); return this; }
        public Actor get_position_of_used_entry_exit( Out<Float> x, Out<Float> y, Out<Float> z, Out<Float> zAngle ) { Script.AppendLine( Opcodes._094C, this, x, y, z, zAngle ); return this; }
        public Actor get_deadman_position( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._0889, this, x, y, z ); return this; }
        public Actor get_velocity( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._083D, this, x, y, z ); return this; }
        public Actor get_pickup_position_when_dead( Out<Float> x, Out<Float> y, Out<Float> z ) { Script.AppendLine( Opcodes._04A5, this, x, y, z ); return this; }
        public Actor get_as_pack_progress_recursive( Out<Int> flag1, Out<Int> flag2 ) { Script.AppendLine( Opcodes._07A4, this, flag1, flag2 ); return this; }
        public Actor get_weapon_data( Int weaponSlot, Out<Int> weaponNumber, Out<Int> weaponAmmo, Out<Int> weaponModel ) { Script.AppendLine( Opcodes._04B8, this, weaponSlot, weaponNumber, weaponAmmo, weaponModel ); return this; }
        public Actor get_animation_progress( vString animName, Out<Float> progress ) { Script.AppendLine( Opcodes._0613, progress, this, animName ); return this; }
        public Actor get_animation_total_time( vString animName, Out<Int> time ) { Script.AppendLine( Opcodes._061A, this, animName, time ); return this; }
        public Actor get_as_pack_progress( Out<Int> progress ) { Script.AppendLine( Opcodes._0646, this, progress ); return this; }
        public Actor get_say_context_important( Int audioTableMaybe, Int flag1_bool, Int flag2_bool, Int flag3_bool, Out<Int> result ) { Script.AppendLine( Opcodes._09D5, this, audioTableMaybe, flag1_bool, flag2_bool, flag3_bool, result ); return this; }
        public Actor get_random_in_zone( sString zoneGXT, Int civilian_bool, Int gang_bool, Int criminal_prostitute_bool ) { Script.AppendLine( Opcodes._02DD, check_OUT_Variable( this ), zoneGXT, $"with_pedtype_civilian {civilian_bool} gang {gang_bool} criminal/prostitute {criminal_prostitute_bool}" ); return this; }
        public Actor get_random_in_area_3d_offset_no_save( Float x, Float y, Float z, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._0A3E, x, y, z, offsetX, offsetY, offsetZ, check_OUT_Variable( this ) ); return this; }
        public Actor get_random_no_brain( Float x, Float y, Float z, Float radius ) { Script.AppendLine( Opcodes._08E5, x, y, z, radius, check_OUT_Variable( this ) ); return this; }
        public Actor get_random_only_drugs_buyers( Float x, Float y, Float z, Float radius ) { Script.AppendLine( Opcodes._089E, x, y, z, radius, check_OUT_Variable( this ) ); return this; }
        public Actor get_random_in_point_3d( Float x, Float y, Float z, Float radius, Int civilian_bool, Int gang_bool, Int criminal_prostitute_bool ) { Script.AppendLine( Opcodes._073F, x, y, z, radius, civilian_bool, gang_bool, criminal_prostitute_bool, check_OUT_Variable( this ) ); return this; }
        public Actor set_money( Int amount ) { Script.AppendLine( Opcodes._03FE, this, amount ); return this; }
        public Actor put_in_group_as_leader( Group hGroup ) { Script.AppendLine( Opcodes._0630, this, hGroup ); return this; }
        public Actor put_in_group( Group hGroup ) { Script.AppendLine( Opcodes._0631, this, hGroup ); return this; }
        public Actor set_walk_style( vString walkStyle ) { Script.AppendLine( Opcodes._0245, this, walkStyle ); return this; }
        public Actor set_animation_speed( vString animName, Float speed ) { Script.AppendLine( Opcodes._0393, this, animName, speed ); return this; }
        public Actor put_in_jetpack() { Script.AppendLine( Opcodes._07A7, this ); return this; }
        public Actor set_swimming_speed( Float speed ) { Script.AppendLine( Opcodes._0A28, this, speed ); return this; }
        public Actor set_death_weapons_persist( Int state_bool ) { Script.AppendLine( Opcodes._0A27, this, state_bool ); return this; }
        public Actor shut_up_for_scripted_speech( Int state_bool ) { Script.AppendLine( Opcodes._0A09, this, state_bool ); return this; }
        public Actor set_get_out_upside_down_vehicle( Int state_bool ) { Script.AppendLine( Opcodes._09F6, this, state_bool ); return this; }
        public Actor ignore_height_difference_following_nodes( Int state_bool ) { Script.AppendLine( Opcodes._09F4, this, state_bool ); return this; }
        public Actor play_audio_event( Int eventID ) { Script.AppendLine( Opcodes._09F1, this, eventID ); return this; }
        public Actor remove_from_vehicle_maintain_position<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._09C9, this, hVehicle ); return this; }
        public Actor set_position_dont_warp_gang_no_offset( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._09BC, this, x, y, z ); return this; }
        public Actor set_signal_after_kill( Int state_bool ) { Script.AppendLine( Opcodes._09B5, this, state_bool ); return this; }
        public Actor set_wanted_by_police( Int state_bool ) { Script.AppendLine( Opcodes._09B6, this, state_bool ); return this; }
        public Actor set_drugged_up( Int state_bool ) { Script.AppendLine( Opcodes._09A7, this, state_bool ); return this; }
        public Actor add_blood( Float x, Float y, Float z, Float offsetX, Float offsetY, Float offsetZ, Int density ) { Script.AppendLine( Opcodes._09B8, x, y, z, offsetX, offsetY, offsetZ, density, this ); return this; }
        public Actor set_uses_collision_closest_object_of_type( Float x, Float y, Float z, Float radius, Int model, Int solid_bool ) { Script.AppendLine( Opcodes._0985, x, y, z, radius, model, solid_bool, this ); return this; }
        public Actor set_force_die_in_vehicle( Int state_bool ) { Script.AppendLine( Opcodes._0982, this, state_bool ); return this; }
        public Actor set_position_no_offset( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0972, this, x, y, z ); return this; }
        public Actor start_facial_talk( Int time ) { Script.AppendLine( Opcodes._0967, this, time ); return this; }
        public Actor stop_facial_talk() { Script.AppendLine( Opcodes._0968, this ); return this; }
        public Actor set_keep_task( Int state_bool ) { Script.AppendLine( Opcodes._0961, this, state_bool ); return this; }
        public Actor disable_speech( Int state_bool ) { Script.AppendLine( Opcodes._094E, this, state_bool ); return this; }
        public Actor enable_speech() { Script.AppendLine( Opcodes._094F, this ); return this; }
        public Actor set_uses_upperbody_damage_anims_only( Int state_bool ) { Script.AppendLine( Opcodes._0946, this, state_bool ); return this; }
        public Actor speak_from_audio_table( Int audioTableID, Int phraseId ) { Script.AppendLine( Opcodes._0947, this, audioTableID, phraseId ); return this; }
        public Actor set_camera_in_front() { Script.AppendLine( Opcodes._0944, this ); return this; }
        public Actor set_fire_damage_multiplier( Float multiplier ) { Script.AppendLine( Opcodes._093E, this, multiplier ); return this; }
        public Actor set_bulletproof_vest( Int state_bool ) { Script.AppendLine( Opcodes._093B, this, state_bool ); return this; }
        public Actor clear_conversation() { Script.AppendLine( Opcodes._08ED, this ); return this; }
        public Actor set_position_dont_warp_gang( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._08C7, this, x, y, z ); return this; }
        public Actor set_can_be_knocked_off_bike( Int state_bool ) { Script.AppendLine( Opcodes._08C6, this, state_bool ); return this; }
        public Actor set_max_health( Int max ) { Script.AppendLine( Opcodes._08AF, this, max ); return this; }
        public Actor set_has_used_entry_exit( Float x, Float y, Float radius ) { Script.AppendLine( Opcodes._08AD, this, x, y, radius ); return this; }
        public Actor enable_conversation( Int state_bool ) { Script.AppendLine( Opcodes._089C, this, state_bool ); return this; }
        public Actor set_drops_weapons_when_dead( Int state_bool ) { Script.AppendLine( Opcodes._087E, this, state_bool ); return this; }
        public Actor set_never_leaves_group( Int state_bool ) { Script.AppendLine( Opcodes._087F, this, state_bool ); return this; }
        public Actor link_to_interior( Int interiorID ) { Script.AppendLine( Opcodes._0860, this, interiorID ); return this; }
        public Actor allow_crouch( Int state_bool ) { Script.AppendLine( Opcodes._0856, this, state_bool ); return this; }
        public Actor add_damage( Int health, Int armor ) { Script.AppendLine( Opcodes._0851, this, health, armor ); return this; }
        public Actor set_velocity( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._083C, this, x, y, z ); return this; }
        public Actor set_rotation( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._083E, this, x, y, z ); return this; }
        public Actor set_weapon_skill( Int weaponSkill_byte ) { Script.AppendLine( Opcodes._081A, this, weaponSkill_byte ); return this; }
        public Actor set_kinda_stay_in_same_place( Int state_bool ) { Script.AppendLine( Opcodes._0816, this, state_bool ); return this; }
        public Actor set_fighting_style( Int fightingStyle_byte, Int fightingMoveStyle_byte ) { Script.AppendLine( Opcodes._07FE, this, fightingStyle_byte, fightingMoveStyle_byte ); return this; }
        public Actor set_turret_mode( Int orientation, Float angleLimit ) { Script.AppendLine( Opcodes._0887, this, orientation, angleLimit ); return this; }
        public Actor set_weapon_attack_rate( Int rate ) { Script.AppendLine( Opcodes._07DD, this, rate ); return this; }
        public Actor set_listen_group_commands( Int state_bool ) { Script.AppendLine( Opcodes._07CB, this, state_bool ); return this; }
        public Actor perform_as_pack_from_progress( ASPack hASPack, Int flag1, Int flag2 ) { Script.AppendLine( Opcodes._07A0, this, hASPack, flag1, flag2 ); return this; }
        public Actor clear_tasks_immediately() { Script.AppendLine( Opcodes._0792, this ); return this; }
        public Actor set_acquaintance( Int acquaintanceType_byte, Int actorType ) { Script.AppendLine( Opcodes._077A, this, acquaintanceType_byte, actorType ); return this; }
        public Actor clear_acquaintance( Int acquaintanceType_byte, Int actorType ) { Script.AppendLine( Opcodes._077B, this, acquaintanceType_byte, actorType ); return this; }
        public Actor clear_acquaintance_to_all_pedtypes( Int acquaintanceType_byte ) { Script.AppendLine( Opcodes._077C, this, acquaintanceType_byte ); return this; }
        public Actor set_is_target_priority( Int state_bool ) { Script.AppendLine( Opcodes._0770, this, state_bool ); return this; }
        public Actor put_into_vehicle_as_passenger<T>( Vehicle<T> hVehicle, Int passengerSeat ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0430, this, hVehicle, passengerSeat ); return this; }
        public Actor set_suffers_critical_hits( Int state_bool ) { Script.AppendLine( Opcodes._0446, this, state_bool ); return this; }
        public Actor attach_to_vehicle<T>( T hVehicle, Float offsetX, Float offsetY, Float offsetZ, Int position, Float angleLimit, Int weaponNumber ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0464, this, hVehicle, offsetX, offsetY, offsetZ, position, angleLimit, weaponNumber ); return this; }
        public Actor detach_from_vehicle() { Script.AppendLine( Opcodes._0465, this ); return this; }
        public Actor clear_last_weapon_damage() { Script.AppendLine( Opcodes._0467, this ); return this; }
        public Actor can_see_dead_actor( Int actorType ) { Script.AppendLine( Opcodes._0480, this, actorType ); return this; }
        public Actor set_muted( Int state_bool ) { Script.AppendLine( Opcodes._0489, this, state_bool ); return this; }
        public Actor remove_all_weapons() { Script.AppendLine( Opcodes._048F, this ); return this; }
        public Actor lock_position( Int state_bool ) { Script.AppendLine( Opcodes._04D7, this, state_bool ); return this; }
        public Actor set_drowns_in_water( Int state_bool ) { Script.AppendLine( Opcodes._04D8, this, state_bool ); return this; }
        public Actor attach_to_object( Object hObject, Float offsetX, Float offsetY, Float offsetZ, Int position, Float angleLimit, Int weaponNumber ) { Script.AppendLine( Opcodes._04F4, this, hObject, offsetX, offsetY, offsetZ, position, angleLimit, weaponNumber ); return this; }
        public Actor create_on_rope( Int actorType, Int actorModel, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0503, actorType, actorModel, x, y, z, check_OUT_Variable( this ) ); return this; }
        public Actor set_stay_in_vehicle_when_jacked( Int state_bool ) { Script.AppendLine( Opcodes._0526, this, state_bool ); return this; }
        public Actor set_can_be_shot_in_vehicle( Int state_bool ) { Script.AppendLine( Opcodes._054A, this, state_bool ); return this; }
        public Actor clear_last_damage() { Script.AppendLine( Opcodes._054E, this ); return this; }
        public Actor remove_weapon( Int weaponNumber ) { Script.AppendLine( Opcodes._0555, weaponNumber, this ); return this; }
        public Actor create_random_in_vehicle_as_driver<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0560, hVehicle, check_OUT_Variable( this ) ); return this; }
        public Actor create_random_in_vehicle_as_passenger<T>( T hVehicle, Int seatNumber ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0561, check_OUT_Variable( this ), hVehicle, seatNumber ); return this; }
        public Actor set_untargetable( Int state_bool ) { Script.AppendLine( Opcodes._0568, this, state_bool ); return this; }
        public Actor freeze_position_and_dont_load_collision( Int state_bool ) { Script.AppendLine( Opcodes._0575, this, state_bool ); return this; }
        public Actor enable_validate_position( Int state_bool ) { Script.AppendLine( Opcodes._0588, this, state_bool ); return this; }
        public Actor set_decision_maker( Int decisionMaker ) { Script.AppendLine( Opcodes._060B, this, decisionMaker ); return this; }
        public Actor set_decision_maker( DecisionMaker decisionMaker ) { Script.AppendLine( Opcodes._060B, this, decisionMaker ); return this; }
        public Actor set_melee_accuracy( Float percentage ) { Script.AppendLine( Opcodes._060F, this, percentage ); return this; }
        public Actor set_animation_playing_flag( vString animName, Int pause_bool ) { Script.AppendLine( Opcodes._0612, this, animName, pause_bool ); return this; }
        public Actor set_animation_progress( vString animName, Float progress ) { Script.AppendLine( Opcodes._0614, this, animName, progress ); return this; }
        public Actor enable_collision_detection( Int state_bool ) { Script.AppendLine( Opcodes._0619, this, state_bool ); return this; }
        public Actor assign_to_AS_pack( ASPack hASPack ) { Script.AppendLine( Opcodes._0618, this, hASPack ); return this; }
        public Actor create_at_attractor( Int actorType, Int actorModelID, Attractor hAttractor, Int taskID ) { Script.AppendLine( Opcodes._0621, actorType, actorModelID, hAttractor, taskID, check_OUT_Variable( this ) ); return this; }
        public Actor set_follow_node_threshold_distance( Float distance ) { Script.AppendLine( Opcodes._0648, this, distance ); return this; }
        public Actor clear_tasks() { Script.AppendLine( Opcodes._0687, this ); return this; }
        public Actor attach_to_bike( Bike hBike, Float offsetX, Float offsetY, Float offsetZ, Int position, Float angleLimitX, Float angleLimitY, Int weaponNumber ) { Script.AppendLine( Opcodes._06A7, this, hBike, offsetX, offsetY, offsetZ, position, angleLimitX, angleLimitY, weaponNumber ); return this; }
        public Actor hide_weapons_in_scene( Int state_bool ) { Script.AppendLine( Opcodes._06AB, this, state_bool ); return this; }
        public Actor remove_from_group() { Script.AppendLine( Opcodes._06C9, this ); return this; }
        public Actor start_setting_up_conversation() { Script.AppendLine( Opcodes._0717, this ); return this; }
        public Actor put_into_vehicle_as_driver<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._072A, this, hVehicle ); return this; }
        public Actor put_into_vehicle_as_passenger<T>( T hVehicle, Int seatNumber ) where T : Vehicle<T> { Script.AppendLine( Opcodes._072B, this, hVehicle, seatNumber ); return this; }
        public Actor set_inform_respected_friends( Float radius, Int actorsToScan ) { Script.AppendLine( Opcodes._074E, radius, actorsToScan, this ); return this; }
        public Actor set_actor_say( Int soundID, Int flag1_bool, Int flag2_bool, Int flag3_bool ) { Script.AppendLine( Opcodes._09D6, this, soundID, flag1_bool, flag2_bool, flag3_bool ); return this; }
        public Actor get_of_closest_map_attractor<T>( Float x_float, Float y_float, Float z_float, Float radius_float, Int objectModel_int ) where T : External, new() {
            var script = Script.CreateExternalIfNotExist<T>();
            Script.AppendLine( Opcodes._091C, x_float, y_float, z_float, radius_float, objectModel_int, script.ScriptName, check_OUT_Variable( this ) );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_lifting_object( Object hObject ) { return new Condition( Opcodes._0737, this, hObject ); }
        public Condition is_busted() { return new Condition( Opcodes._0741, this ); }
        public Condition is_group_member( Group hGroup ) { return new Condition( Opcodes._06EE, this, hGroup ); }
        public Condition is_group_leader( Group hGroup ) { return new Condition( Opcodes._06EF, this, hGroup ); }
        public Condition is_in_searchlight( Searchlight hSearchlight ) { return new Condition( Opcodes._06C0, hSearchlight, this ); }
        public Condition is_at_attractor( Attractor hAttractor ) { return new Condition( Opcodes._0642, this, hAttractor ); }
        public Condition is_crouching() { return new Condition( Opcodes._0597, this ); }
        public Condition is_in_any_police_vehicle() { return new Condition( Opcodes._056C, this ); }
        public Condition is_defined() { return new Condition( Opcodes._056D, this ); }
        public Condition is_colliding_with_vehicle<T>( T hVehicle ) where T : Vehicle<T> { return new Condition( Opcodes._0547, this, hVehicle ); }
        public Condition is_damaged_by_actor( Actor target ) { return new Condition( Opcodes._051A, this, target ); }
        public Condition is_damaged_by_vehicle<T>( T hVehicle ) where T : Vehicle<T> { return new Condition( Opcodes._051B, this, hVehicle ); }
        public Condition is_waiting_for_world_collision() { return new Condition( Opcodes._04F0, this ); }
        public Condition is_in_any_flying_vehicle() { return new Condition( Opcodes._04C8, this ); }
        public Condition is_photographed() { return new Condition( Opcodes._04C5, this ); }
        public Condition is_in_any_heli() { return new Condition( Opcodes._04A9, this ); }
        public Condition is_in_any_plane() { return new Condition( Opcodes._04AB, this ); }
        public Condition is_in_water() { return new Condition( Opcodes._04AD, this ); }
        public Condition is_in_any_boat() { return new Condition( Opcodes._04A7, this ); }
        public Condition is_in_any_bike() { return new Condition( Opcodes._047A, this ); }
        public Condition is_in_any_searchlight( Searchlight hSearchlighfIfFound ) { return new Condition( Opcodes._07A9, this, hSearchlighfIfFound ); }
        public Condition is_in_air() { return new Condition( Opcodes._0818, this ); }
        public Condition is_in_position_for_conversation() { return new Condition( Opcodes._089B, this ); }
        public Condition is_talking() { return new Condition( Opcodes._094D, this ); }
        public Condition is_stuck_under_vehicle() { return new Condition( Opcodes._095D, this ); }
        public Condition is_swimming() { return new Condition( Opcodes._0965, this ); }
        public Condition is_head_missing() { return new Condition( Opcodes._09A8, this ); }
        public Condition is_in_any_train() { return new Condition( Opcodes._09C5, this ); }
        public Condition is_entering_vehicle() { return new Condition( Opcodes._09DE, this ); }
        public Condition is_spotted_actor_in_front( Actor target ) { return new Condition( Opcodes._09ED, this, target ); }
        public Condition is_colliding_with_actor( Actor target ) { return new Condition( Opcodes._0A1B, this, target ); }
        public Condition is_attached_to_any_vehicle() { return new Condition( Opcodes._0A32, this ); }
        public Condition is_in_any_taxi() { return new Condition( Opcodes._0602, this ); }
        public Condition is_spotted_actor( Actor target ) { return new Condition( Opcodes._0364, this, target ); }
        public Condition is_responding_to_event( Int eventID ) { return new Condition( Opcodes._074F, this, eventID ); }
        public Condition is_current_dialogue_text( sString gxtName ) { return new Condition( Opcodes._071A, this, gxtName ); }
        public Condition is_near_any_actor( Float radius ) { return new Condition( Opcodes._06FF, this, radius ); }
        public Condition is_performing_animation( vString animName ) { return new Condition( Opcodes._0611, this, animName ); }
        public Condition is_has_weapon( Int weaponNumber ) { return new Condition( Opcodes._0491, this, weaponNumber ); }
        public Condition is_near_object_2d( Object hObject, Float radiusX, Float radiusY, Int shpere_bool ) { return new Condition( Opcodes._0471, this, hObject, radiusX, radiusY, shpere_bool ); }
        public Condition is_near_object_2d_on_foot( Object hObject, Float radiusX, Float radiusY, Int shpere_bool ) { return new Condition( Opcodes._0472, this, hObject, radiusX, radiusY, shpere_bool ); }
        public Condition is_near_object_2d_in_vehicle( Object hObject, Float radiusX, Float radiusY, Int shpere_bool ) { return new Condition( Opcodes._0473, this, hObject, radiusX, radiusY, shpere_bool ); }
        public Condition is_near_object_3d( Object hObject, Float radiusX, Float radiusY, Float radiusZ, Int shpere_bool ) { return new Condition( Opcodes._0474, this, hObject, radiusX, radiusY, radiusZ, shpere_bool ); }
        public Condition is_near_object_3d_on_foot( Object hObject, Float radiusX, Float radiusY, Float radiusZ, Int shpere_bool ) { return new Condition( Opcodes._0475, this, hObject, radiusX, radiusY, radiusZ, shpere_bool ); }
        public Condition is_near_object_3d_in_vehicle( Object hObject, Float radiusX, Float radiusY, Float radiusZ, Int shpere_bool ) { return new Condition( Opcodes._0476, this, hObject, radiusX, radiusY, radiusZ, shpere_bool ); }
        public Condition is_shooting_in_area_2d( Int fireType, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._02D6, this, fireType, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_angled_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05FC, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_in_angled_area_3d_on_foot( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05FD, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_in_angled_area_3d_in_vehicle( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05FE, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_in_angled_area_3d_stopped( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05FF, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_in_angled_area_3d_stopped_on_foot( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._0600, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_in_angled_area_3d_stopped_in_vehicle( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Float angle, Int shpere_bool ) { return new Condition( Opcodes._0601, this, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, angle, shpere_bool ); }
        public Condition is_in_angled_area_2d( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05F6, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, shpere_bool ); }
        public Condition is_in_angled_area_2d_on_foot( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05F7, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, shpere_bool ); }
        public Condition is_in_angled_area_2d_in_vehicle( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05F8, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, shpere_bool ); }
        public Condition is_in_angled_area_2d_stopped( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05F9, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, shpere_bool ); }
        public Condition is_in_angled_area_2d_stopped_on_foot( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05FA, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, shpere_bool ); }
        public Condition is_in_angled_area_2d_stopped_in_vehicle( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Float angle, Int shpere_bool ) { return new Condition( Opcodes._05FB, this, cornerA_x, cornerA_y, cornerB_x, cornerB_y, angle, shpere_bool ); }
        public Condition find( Float x, Float y, Float z, Float radius, Int passDeads_bool, Int findNext_bool ) { return new Condition( Opcodes._0AE1, check_OUT_Variable( this ), x, y, z, radius, findNext_bool, passDeads_bool ); }
        public Condition is_in_vehicle<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { return new Condition( Opcodes._00DB, this, hVehicle ); }
        public Condition is_in_car( Car hCar ) { return new Condition( Opcodes._0448, this, hCar ); }
        public Condition is_in_vehicle_with_model( Int vehicleModel ) { return new Condition( Opcodes._00DD, this, vehicleModel ); }
        public Condition is_in_any_car() { return new Condition( Opcodes._0449, this ); }
        public Condition is_in_any_vehicle() { return new Condition( Opcodes._00DF, this ); }
        public Condition is_on_foot() { return new Condition( Opcodes._044B, this ); }
        public Condition is_male() { return new Condition( Opcodes._03A3, this ); }
        public Condition is_damaged_by_weapon( Int damageType ) { return new Condition( Opcodes._031D, this, damageType ); }
        public Condition is_model( Int actorModel ) { return new Condition( Opcodes._02F2, this, actorModel ); }
        public Condition is_firing_weapon() { return new Condition( Opcodes._02E0, this ); }
        public Condition is_current_weapon( Int weaponNumber ) { return new Condition( Opcodes._02D8, this, weaponNumber ); }
        public Condition is_on_screen() { return new Condition( Opcodes._02CB, this ); }
        public Condition is_stopped() { return new Condition( Opcodes._02A0, this ); }
        public Condition is_colliding_with_object_on_foot( Object hObject ) { return new Condition( Opcodes._023B, this, hObject ); }
        public Condition is_health_greater( Int health ) { return new Condition( Opcodes._0184, this, health ); }
        public Condition is_colliding_with_object( Object hObject ) { return new Condition( Opcodes._0179, this, hObject ); }
        public Condition is_dead() { return new Condition( Opcodes._0118, this ); }
        public Condition is_in_zone( sString zoneNameGXT ) { return new Condition( Opcodes._0154, this, zoneNameGXT ); }
        public Condition is_near_point_3d( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._00FE, this, sphere_bool, x, y, z, radius_x, radius_y, radius_z ); }
        public Condition is_near_point_3d_on_foot( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._00FF, this, sphere_bool, x, y, z, radius_x, radius_y, radius_z ); }
        public Condition is_near_point_3d_in_vehicle( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._0100, this, x, y, z, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_point_3d_stopped( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._0101, this, x, y, z, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_point_3d_stopped_on_foot( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._0102, this, x, y, z, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_point_3d_stopped_in_vehicle( Int sphere_bool, Float x, Float y, Float z, Float radius_x, Float radius_y, Float radius_z ) { return new Condition( Opcodes._0103, this, x, y, z, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_actor_3d( Int sphere_bool, Actor hActor, Float radius_x, Float radius_z, Float radius_y ) { return new Condition( Opcodes._0104, this, hActor, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_actor_3d_on_foot( Int sphere_bool, Actor hActor, Float radius_x, Float radius_z, Float radius_y ) { return new Condition( Opcodes._0105, this, hActor, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_actor_3d_in_vehicle( Int sphere_bool, Actor hActor, Float radius_x, Float radius_z, Float radius_y ) { return new Condition( Opcodes._0106, this, hActor, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_in_area_3d( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._00A4, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_in_area_3d_on_foot( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._01A6, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_in_area_3d_in_vehicle( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._01A7, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_near_vehicle_3d<T>( Int sphere_bool, T hVehicle, Float radius_x, Float radius_z, Float radius_y ) where T : Vehicle<T> { return new Condition( Opcodes._0205, this, hVehicle, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_vehicle_3d_on_foot<T>( Int sphere_bool, T hVehicle, Float radius_x, Float radius_z, Float radius_y ) where T : Vehicle<T> { return new Condition( Opcodes._0206, this, hVehicle, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_near_vehicle_3d_in_vehicle<T>( Int sphere_bool, T hVehicle, Float radius_x, Float radius_z, Float radius_y ) where T : Vehicle<T> { return new Condition( Opcodes._0207, this, hVehicle, radius_x, radius_y, radius_z, sphere_bool ); }
        public Condition is_in_area_3d_stopped( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._01A8, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_in_area_3d_stopped_on_foot( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._01A9, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_in_area_3d_stopped_in_vehicle( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._01AA, this, sphere_bool, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public Condition is_near_point_2d( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00EC, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_point_2d_on_foot( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00ED, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_point_2d_in_vehicle( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00EE, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_point_2d_stopped( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00EF, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_point_2d_stopped_on_foot( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00F0, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_point_2d_stopped_in_vehicle( Int sphere_bool, Float x, Float y, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00F1, this, sphere_bool, x, y, radius_x, radius_y ); }
        public Condition is_near_actor_2d( Int sphere_bool, Actor hActor, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00F2, this, hActor, radius_x, radius_y, sphere_bool ); }
        public Condition is_near_actor_2d_on_foot( Int sphere_bool, Actor hActor, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00F3, this, hActor, radius_x, radius_y, sphere_bool ); }
        public Condition is_near_actor_2d_in_vehicle( Int sphere_bool, Actor hActor, Float radius_x, Float radius_y ) { return new Condition( Opcodes._00F4, this, hActor, radius_x, radius_y, sphere_bool ); }
        public Condition is_near_vehicle_2d<T>( Int sphere_bool, T hVehicle, Float radius_x, Float radius_y ) where T : Vehicle<T> { return new Condition( Opcodes._0202, this, hVehicle, radius_x, radius_y, sphere_bool ); }
        public Condition is_near_vehicle_2d_on_foot<T>( Int sphere_bool, T hVehicle, Float radius_x, Float radius_y ) where T : Vehicle<T> { return new Condition( Opcodes._0203, this, hVehicle, radius_x, radius_y, sphere_bool ); }
        public Condition is_near_vehicle_2d_in_vehicle<T>( Int sphere_bool, T hVehicle, Float radius_x, Float radius_y ) where T : Vehicle<T> { return new Condition( Opcodes._0204, this, hVehicle, radius_x, radius_y, sphere_bool ); }
        public Condition is_in_area_2d( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._00A3, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_area_2d_on_foot( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._01A1, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_area_2d_in_vehicle( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._01A2, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_area_2d_stopped( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._01A3, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_area_2d_stopped_on_foot( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._01A4, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public Condition is_in_area_2d_stopped_in_vehicle( Int sphere_bool, Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y ) { return new Condition( Opcodes._01A5, this, sphere_bool, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Actor( LocalVariable val ) { return new Actor( VariableContext.LOCAL, val.index ); }
        public static implicit operator Actor( GlobalVariable val ) { return new Actor( VariableContext.GLOBAL, val.index ); }

    }

}