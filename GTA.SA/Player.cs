using GTA.Core;

namespace GTA {

    public class Player : Handle<Player>, IVariable {

        internal Player( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Player get_actor( Out<Actor> hActor ) { Script.AppendLine( Opcodes._01F5, hActor, this ); return this; }
        public Player get_money( Out<Int> money ) { Script.AppendLine( Opcodes._010B, money, this ); return this; }
        public Player get_wanted_level( Out<Int> wantedLevel ) { Script.AppendLine( Opcodes._01C0, wantedLevel, this ); return this; }
        public Player create( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0053, check_OUT_Variable( this ), x, y, z ); return this; }
        public Player can_move( Int state_bool ) { Script.AppendLine( Opcodes._01B4, this, state_bool ); return this; }
        public Player add_money( Int amount ) { Script.AppendLine( Opcodes._0109, this, amount ); return this; }
        public Player set_wanted_level( Int wantedLevel_byte ) { Script.AppendLine( Opcodes._010D, this, wantedLevel_byte ); return this; }
        public Player set_minimum_wanted_level( Int wantedLevel_byte ) { Script.AppendLine( Opcodes._010E, this, wantedLevel_byte ); return this; }
        public Player clear_wanted_level() { Script.AppendLine( Opcodes._0110, this ); return this; }
        public Player make_safe() { Script.AppendLine( Opcodes._03EF, this ); return this; }
        public Player ignored_by_cops( Int state_bool ) { Script.AppendLine( Opcodes._01F7, this, state_bool ); return this; }
        public Player ignored_by_everyone( Int state_bool ) { Script.AppendLine( Opcodes._03BF, this, state_bool ); return this; }
        public Player apply_brakes_to_vehicle( Int state_bool ) { Script.AppendLine( Opcodes._0221, this, state_bool ); return this; }
        public Player set_infinite_run( Int state_bool ) { Script.AppendLine( Opcodes._0330, this, state_bool ); return this; }
        public Player set_fast_reload( Int state_bool ) { Script.AppendLine( Opcodes._0331, this, state_bool ); return this; }
        public Player set_free_health_care( Int state_bool ) { Script.AppendLine( Opcodes._0414, this, state_bool ); return this; }
        public Player get_current_rc_vehicle<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0484, check_OUT_Variable( hVehicle ), this ); return this; }
        public Player get_group( Out<Group> hGroup ) { Script.AppendLine( Opcodes._07AF, hGroup, this ); return this; }
        public Player get_destroyed_model_quantity( Int modelId, Out<Int> quantity ) { Script.AppendLine( Opcodes._0298, this, modelId, quantity ); return this; }
        public Player get_town_number( Out<Int> townNumber ) { Script.AppendLine( Opcodes._0842, townNumber, this ); return this; }
        public Player get_max_armor( Out<Int> armor ) { Script.AppendLine( Opcodes._0945, this, armor ); return this; }
        public Player get_clothes_CRC( Int bodypart, Out<Int> textureCRC, Out<Int> modelCRC ) { Script.AppendLine( Opcodes._08F7, this, bodypart, textureCRC, modelCRC ); return this; }
        public Player get_kills_from_last_checkpoint( Out<Int> total ) { Script.AppendLine( Opcodes._0806, this, total ); return this; }
        public Player get_wheelie_stats( Out<Float> twoWheelsTime, Out<Float> twoWheelsDistance, Out<Float> wheelieTime, Out<Float> wheelieDistance, Out<Float> stoppieTime, Out<Float> stoppieDistance ) { Script.AppendLine( Opcodes._04FC, this, twoWheelsTime, twoWheelsDistance, wheelieTime, wheelieDistance, stoppieTime, stoppieDistance ); return this; }
        public Player destroy() { Script.AppendLine( Opcodes._06DF, this ); return this; }
        public Player rebuild() { Script.AppendLine( Opcodes._070D, this ); return this; }
        public Player reset_destroyed_model_counters() { Script.AppendLine( Opcodes._0297, this ); return this; }
        public Player clear_last_model_shot() { Script.AppendLine( Opcodes._0A3B, this ); return this; }
        public Player shut_up( Int state_bool ) { Script.AppendLine( Opcodes._04E2, this, state_bool ); return this; }
        public Player set_handling_responsiveness( Int state ) { Script.AppendLine( Opcodes._03FD, this, state ); return this; }
        public Player make_fireproof( Int state_bool ) { Script.AppendLine( Opcodes._055D, this, state_bool ); return this; }
        public Player set_group_to_follow_never( Int state_bool ) { Script.AppendLine( Opcodes._0A31, this, state_bool ); return this; }
        public Player set_group_to_follow_always( Int state_bool ) { Script.AppendLine( Opcodes._0A20, this, state_bool ); return this; }
        public Player take_off_goggles( Int state_bool ) { Script.AppendLine( Opcodes._09EB, this, state_bool ); return this; }
        public Player force_interior_lighting( Int state_bool ) { Script.AppendLine( Opcodes._09D7, this, state_bool ); return this; }
        public Player change_model( Int actorModel ) { Script.AppendLine( Opcodes._09C7, this, actorModel ); return this; }
        public Player enable_weapons_scrollable_key( Int state_bool ) { Script.AppendLine( Opcodes._0992, this, state_bool ); return this; }
        public Player enable_stats_key( Int state_bool ) { Script.AppendLine( Opcodes._0960, this, state_bool ); return this; }
        public Player enable_jump_key( Int state_bool ) { Script.AppendLine( Opcodes._0901, this, state_bool ); return this; }
        public Player enable_fire_key( Int state_bool ) { Script.AppendLine( Opcodes._0881, this, state_bool ); return this; }
        public Player set_heading_for_attached( Float horizonToAngle, Float speed ) { Script.AppendLine( Opcodes._0858, this, horizonToAngle, speed ); return this; }
        public Player enable_crouch_key( Int state_bool ) { Script.AppendLine( Opcodes._082A, this, state_bool ); return this; }
        public Player enable_enter_vehicle_key( Int state_bool ) { Script.AppendLine( Opcodes._07CC, this, state_bool ); return this; }
        public Player enable_group_recruitment( Int state_bool ) { Script.AppendLine( Opcodes._07B4, this, state_bool ); return this; }
        public Player set_clothes( vString textureName, vString modelName, Int bodypart ) { Script.AppendLine( Opcodes._087B, this, textureName, modelName, bodypart ); return this; }
        public Player set_clothes_crc( Int textureCRC, Int modelCRC, Int bodypart ) { Script.AppendLine( Opcodes._0784, this, textureCRC, modelCRC, bodypart ); return this; }
        public Player give_rc_model( Float x, Float y, Float z, Float angle, Int vehicleRCModel ) { Script.AppendLine( Opcodes._046E, this, x, y, z, angle, vehicleRCModel ); return this; }
        public Player set_mood( Int moodType, Int time ) { Script.AppendLine( Opcodes._04E3, this, moodType, time ); return this; }
        public Player enabled_drive_by_mode( Int state_bool ) { Script.AppendLine( Opcodes._0501, this, state_bool ); return this; }
        public Player set_drunk_visuals( Int power ) { Script.AppendLine( Opcodes._052C, this, power ); return this; }
        public Player increase_max_health( Int val ) { Script.AppendLine( Opcodes._055E, this, val ); return this; }
        public Player increase_max_armor( Int val ) { Script.AppendLine( Opcodes._055F, this, val ); return this; }
        public Player ensure_has_drive_by_weapon( Int ammo ) { Script.AppendLine( Opcodes._0563, this, ammo ); return this; }
        public Player disable_sprint( Int state_bool ) { Script.AppendLine( Opcodes._06AF, this, state_bool ); return this; }
        public Player take_rc_of_vehicle<T>( Vehicle<T> hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0715, this, hVehicle ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        //public Condition is_in_shortcut_taxi() { return new Condition( Opcodes._0596, this ); }
        public Condition is_in_info_zone( sString zoneGXT ) { return new Condition( Opcodes._0583, this, zoneGXT ); }
        public Condition is_wearing_skin( vString clotheName, Int bodyPart ) { return new Condition( Opcodes._0500, this, clotheName, bodyPart ); }
        public Condition is_last_model_shot( Int modelId_int ) { return new Condition( Opcodes._0A3A, this, modelId_int ); }
        public Condition is_attached_heading_achieved() { return new Condition( Opcodes._0861, this ); }
        public Condition get_targeted_actor( Actor hActor ) { return new Condition( Opcodes._0AD2, hActor, this ); }
        public Condition is_aiming_at_object( Object hObject ) { return new Condition( Opcodes._0458, this, hObject ); }
        public Condition is_aiming_at_actor( Actor hActor ) { return new Condition( Opcodes._0457, this, hActor ); }
        public Condition is_on_jetpack() { return new Condition( Opcodes._0A0C, this ); }
        public Condition is_climbing() { return new Condition( Opcodes._0A29, this ); }
        public Condition is_autoaiming() { return new Condition( Opcodes._068C, this ); }
        public Condition is_performing_wheelie() { return new Condition( Opcodes._07F1, this ); }
        public Condition is_performing_stoppie() { return new Condition( Opcodes._07F2, this ); }
        public Condition is_not_frozen() { return new Condition( Opcodes._09E7, this ); }
        public Condition is_money_greater( Int amount ) { return new Condition( Opcodes._010A, this, amount ); }
        public Condition is_wanted_level_greater( Int wantedLevel_byte ) { return new Condition( Opcodes._010F, this, wantedLevel_byte ); }
        public Condition is_defined() { return new Condition( Opcodes._0256, this ); }
        public Condition is_wasted() { return new Condition( Opcodes._0117, this ); }
        public Condition is_pressing_horn() { return new Condition( Opcodes._0122, this ); }
        public Condition is_controllable() { return new Condition( Opcodes._03EE, this ); }
        public Condition is_in_rc_mode() { return new Condition( Opcodes._0241, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Player( GlobalVariable val ) { return new Player( VariableContext.GLOBAL, val.index ); }

    }

}
