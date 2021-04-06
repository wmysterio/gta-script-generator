using System;

namespace GTA.Core {

    public sealed class TaskManager {

        internal static readonly TaskManager instance = new TaskManager();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Actor asActor = null;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal TaskManager() { asActor = new GlobalVariable( 0 ); asActor.Name = "-1"; asActor.Context = VariableContext.NONE; asActor.IsDefined = false; }
        internal TaskManager( Actor target ) { asActor = target; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Actor GetActor() { return asActor; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public TaskManager use_closest_map_attractor<T>( Float radius, Int modelID, Float offsetX, Float offsetY, Float offsetZ ) where T : External, new() {
            var script = Script.CreateExternalIfNotExist<T>();
            Script.AppendLine( Opcodes._08A0, asActor, radius, modelID, offsetX, offsetY, offsetZ, script.ScriptName ); return this;
        }
        public TaskManager explode_head() { Script.AppendLine( Opcodes._0321, asActor ); return this; }
        public TaskManager follow_path_nodes_to_point_with_radius( Float x, Float y, Float z, Int mode, Float stopRadius ) { Script.AppendLine( Opcodes._0A2E, asActor, x, y, z, mode, stopRadius ); return this; }
        public TaskManager hand_gesture( Actor target ) { Script.AppendLine( Opcodes._0A1D, asActor, target ); return this; }
        public TaskManager perform_animation_secondary( vString animationName, vString IFP, Float framedelta, Int loopA_bool, Int lockX_bool, Int lockY_bool, Int lockF_bool, Int time ) { Script.AppendLine( Opcodes._0A1A, asActor, animationName, IFP, framedelta, loopA_bool, lockX_bool, lockY_bool, lockF_bool, time ); return this; }
        public TaskManager set_ignore_weapon_range( Int state_bool ) { Script.AppendLine( Opcodes._099F, asActor, state_bool ); return this; }
        public TaskManager drop_second_object( Int state_bool ) { Script.AppendLine( Opcodes._09A1, asActor, state_bool ); return this; }
        public TaskManager pick_up_second_object( Object hObject, Float offsetX, Float offsetY, Float offsetZ, Int bone1, Int bone2, vString animationName, vString IFP, Int time ) { Script.AppendLine( Opcodes._09A0, asActor, hObject, offsetX, offsetY, offsetZ, bone1, bone2, animationName, IFP, time ); return this; }
        public TaskManager drop_object( Int state_bool ) { Script.AppendLine( Opcodes._070B, asActor, state_bool ); return this; }
        public TaskManager pick_up_object( Object hObject, Float offsetX, Float offsetY, Float offsetZ, Int bone1, Int bone2, vString animationName, vString IFP, Int time ) { Script.AppendLine( Opcodes._070A, asActor, hObject, offsetX, offsetY, offsetZ, bone1, bone2, animationName, IFP, time ); return this; }
        public TaskManager perform_animation_with_flags( vString animationName, vString IFP, Float framedelta, Int loopA_bool, Int lockX_bool, Int lockY_bool, Int lockF_bool, Int time, Int disableForce_bool, Int disableLockZ_bool ) { Script.AppendLine( Opcodes._088A, asActor, animationName, IFP, framedelta, loopA_bool, lockX_bool, lockY_bool, lockF_bool, time, disableForce_bool, disableLockZ_bool ); return this; }
        public TaskManager kinda_stay_in_same_place( Int state_bool ) { Script.AppendLine( Opcodes._085B, asActor, state_bool ); return this; }
        public TaskManager walk_alongside_actor( Actor target ) { Script.AppendLine( Opcodes._0859, asActor, target ); return this; }
        public TaskManager follow_actor_footsteps( Actor target ) { Script.AppendLine( Opcodes._0850, asActor, target ); return this; }
        public TaskManager perform_animation_and_dies( vString animationName, vString IFP, Float framedelta, Int time ) { Script.AppendLine( Opcodes._082A, asActor, animationName, IFP, framedelta, time ); return this; }
        public TaskManager greet_partner_actor( Actor target, Float flag1, Int flag2 ) { Script.AppendLine( Opcodes._0823, asActor, target, flag1, flag2 ); return this; }
        public TaskManager follow_patrol_route( Int walkMode, Int routeMode ) { Script.AppendLine( Opcodes._0817, asActor, walkMode, routeMode ); return this; }
        public TaskManager perform_animation_non_interruptable( vString animationName, vString IFP, Float framedelta, Int loopA_bool, Int lockX_bool, Int lockY_bool, Int lockF_bool, Int time ) { Script.AppendLine( Opcodes._0812, asActor, animationName, IFP, framedelta, loopA_bool, lockX_bool, lockY_bool, lockF_bool, time ); return this; }
        public TaskManager walk_to_point_and_perform_animation( Float x, Float y, Float z, Float angle, Float radius, vString animationName, vString IFP, Float framedelta, Int loopA_bool, Int lockX_bool, Int lockY_bool, Int lockF_bool, Int time ) { Script.AppendLine( Opcodes._0804, asActor, x, y, z, angle, radius, animationName, IFP, framedelta, loopA_bool, lockX_bool, lockY_bool, lockF_bool, time ); return this; }
        public TaskManager drive_point_route_advanced<T>( T hVehicle, Float speed, Int flag1, Int flag2, Int flag3 ) where T : Vehicle<T> { Script.AppendLine( Opcodes._07E7, asActor, hVehicle, speed, flag1, flag2, flag3 ); return this; }
        public TaskManager swim_to_point( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._07E1, asActor, x, y, z ); return this; }
        public TaskManager walk_to_point( Float x, Float y, Float z, Float stopAngle, Float radius ) { Script.AppendLine( Opcodes._07CD, asActor, x, y, z, stopAngle, radius ); return this; }
        public TaskManager walk_to_object_and_pick_up_his( Object hObject ) { Script.AppendLine( Opcodes._07C9, asActor, hObject ); return this; }
        public TaskManager set_decision_maker( DecisionMaker hDecisionMaker ) { Script.AppendLine( Opcodes._07BC, asActor, hDecisionMaker ); return this; }
        public TaskManager kill_actor_on_foot_timed( Actor target, Int time ) { Script.AppendLine( Opcodes._07A5, asActor, target, time ); return this; }
        public TaskManager run_to_and_follow_actor_aiming( Actor target, Float waitFrom, Float waitTo ) { Script.AppendLine( Opcodes._07A3, asActor, target, waitFrom, waitTo ); return this; }
        public TaskManager climb( Int state_bool ) { Script.AppendLine( Opcodes._078F, asActor, state_bool ); return this; }
        public TaskManager run_to_car<T>( T hVehicle, Int time, Float stopAtDistance ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0772, asActor, hVehicle, time, stopAtDistance ); return this; }
        public TaskManager dead() { Script.AppendLine( Opcodes._0762, asActor ); return this; }
        public TaskManager crouch( Int state_bool ) { Script.AppendLine( Opcodes._04EB, asActor, state_bool ); return this; }
        public TaskManager stay_idle( Int time ) { Script.AppendLine( Opcodes._05B9, asActor, time ); return this; }
        public TaskManager stand_still( Int time ) { Script.AppendLine( Opcodes._05BA, asActor, time ); return this; }
        public TaskManager tired( Int time ) { Script.AppendLine( Opcodes._05BD, asActor, time ); return this; }
        public TaskManager hands_up( Int time ) { Script.AppendLine( Opcodes._05C4, asActor, time ); return this; }
        public TaskManager cower( Int time ) { Script.AppendLine( Opcodes._05C5, asActor, time ); return this; }
        public TaskManager on_guard( Int time ) { Script.AppendLine( Opcodes._05C9, asActor, time ); return this; }
        public TaskManager rotate_angle( Float angle ) { Script.AppendLine( Opcodes._05D4, asActor, angle ); return this; }
        public TaskManager die() { Script.AppendLine( Opcodes._05BE, asActor ); return this; }
        public TaskManager shake_fist() { Script.AppendLine( Opcodes._05C2, asActor ); return this; }
        public TaskManager cower() { Script.AppendLine( Opcodes._05C3, asActor ); return this; }
        public TaskManager use_atm() { Script.AppendLine( Opcodes._05C7, asActor ); return this; }
        public TaskManager look_around() { Script.AppendLine( Opcodes._05C8, asActor ); return this; } // scratch_head
        public TaskManager jump( Int state_bool ) { Script.AppendLine( Opcodes._05BC, asActor, state_bool ); return this; }
        public TaskManager fall_and_get_up( Int fallDown_bool, Int time ) { Script.AppendLine( Opcodes._05BB, asActor, fallDown_bool, time ); return this; }
        public TaskManager speak_from_audio_table( Int tableID ) { Script.AppendLine( Opcodes._05C1, asActor, tableID ); return this; }
        public TaskManager look_at_actor( Actor hActor, Int time ) { Script.AppendLine( Opcodes._05BF, asActor, hActor, time ); return this; }
        public TaskManager look_at_car<T>( T hVehicle, Int time ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05C0, asActor, hVehicle, time ); return this; }
        public TaskManager enter_car_as_passenger<T>( T hVehicle, Int seat, Int time ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05C0, asActor, hVehicle, seat, time ); return this; }
        public TaskManager enter_car_as_driver<T>( T hVehicle, Int time ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05C0, asActor, hVehicle, time ); return this; }
        public TaskManager exit_vehicle<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05CD, asActor, hVehicle ); return this; }
        public TaskManager exit_vehicle_and_flee<T>( T hVehicle, Float x, Float y, Float z ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05CF, asActor, hVehicle, x, y, z ); return this; }
        public TaskManager drive_car_to_point<T>( T hVehicle, Float x, Float y, Float z, Float speed, Int param1, Int vehicleModelID, Int param3 ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05D1, asActor, hVehicle, x, y, z, speed, param1, vehicleModelID, param3 ); return this; }
        public TaskManager drive_car_wander<T>( T hVehicle, Float maxSearchRadius, Int trafficBehavior ) where T : Vehicle<T> { Script.AppendLine( Opcodes._05D2, asActor, hVehicle, maxSearchRadius, trafficBehavior ); return this; }
        public TaskManager walk_straight_to_point( Float x, Float y, Float z, Int mode, Int time ) { Script.AppendLine( Opcodes._05D3, asActor, x, y, z, mode, time ); return this; }
        public TaskManager walk_around_ped_path() { Script.AppendLine( Opcodes._05DE, asActor ); return this; }
        public TaskManager kill_actor_on_foot( Actor target ) { Script.AppendLine( Opcodes._05E2, asActor, target ); return this; }
        public TaskManager flee_point( Float x, Float y, Float z, Float radius, Int time ) { Script.AppendLine( Opcodes._05D3, asActor, x, y, z, radius, time ); return this; }
        public TaskManager smart_flee_point( Float x, Float y, Float z, Float radius, Int time ) { Script.AppendLine( Opcodes._05D3, asActor, x, y, z, radius, time ); return this; }
        public TaskManager flee_from_actor( Actor target, Float radius, Int time ) { Script.AppendLine( Opcodes._05DB, asActor, target, radius, time ); return this; }
        public TaskManager smart_flee_from_actor( Actor target, Float radius, Int time ) { Script.AppendLine( Opcodes._05DD, asActor, target, radius, time ); return this; }
        public TaskManager run_to_actor( Actor target, Int time, Float radius ) { Script.AppendLine( Opcodes._05D9, asActor, target, time, radius ); return this; }
        public TaskManager assign_to_scmpath( Int speedMaybe, Int param2 ) { Script.AppendLine( Opcodes._05D8, asActor, speedMaybe, param2 ); return this; }
        public TaskManager follow_path_nodes_to_point( Float x, Float y, Float z, Int mode, Int time ) { Script.AppendLine( Opcodes._05F5, asActor, x, y, z, mode, time ); return this; }
        public TaskManager perform_animation( vString animationName, vString IFP, Float framedelta, Int loopA_bool, Int lockX_bool, Int lockY_bool, Int lockF_bool, Int time ) { Script.AppendLine( Opcodes._0605, asActor, animationName, IFP, framedelta, loopA_bool, lockX_bool, lockY_bool, lockF_bool, time ); return this; }
        public TaskManager goto_point_any_means<T>( Float x, Float y, Float z, Int mode, T hVehicleIfNeed ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0603, asActor, x, y, z, mode, hVehicleIfNeed ); return this; }
        public TaskManager exit_vehicle_immediately<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0622, asActor, hVehicle ); return this; }
        public TaskManager use_attractor( Attractor hAttractor ) { Script.AppendLine( Opcodes._074C, asActor, hAttractor ); return this; }
        public TaskManager exit_vehicle() { Script.AppendLine( Opcodes._0633, asActor ); return this; }
        public TaskManager clear_look_at() { Script.AppendLine( Opcodes._0647, asActor ); return this; }
        public TaskManager stay_put( Int state_bool ) { Script.AppendLine( Opcodes._0638, asActor, state_bool ); return this; }
        public TaskManager rotate_to_actor( Actor target ) { Script.AppendLine( Opcodes._0639, asActor, target ); return this; }
        public TaskManager aim_at_actor( Actor target, Int time ) { Script.AppendLine( Opcodes._0635, asActor, target, time ); return this; }
        public TaskManager kill_actor_on_foot_while_crouch( Actor target, Int flag, Int performActionsAfterTime, Int chanceOfAction ) { Script.AppendLine( Opcodes._0634, asActor, target, flag, performActionsAfterTime, chanceOfAction ); return this; }
        public TaskManager goto_point_while_shooting( Actor hLookedActor, Int mode, Float turnRadius, Float stopRadius ) { Script.AppendLine( Opcodes._0637, asActor, mode, turnRadius, stopRadius, hLookedActor ); return this; }
        public TaskManager look_at_object( Object hObject, Int time ) { Script.AppendLine( Opcodes._0655, asActor, hObject, time ); return this; }
        public TaskManager aim_at( Float x, Float y, Float z, Int time ) { Script.AppendLine( Opcodes._0667, asActor, x, y, z, time ); return this; }
        public TaskManager shoot_at( Float x, Float y, Float z, Int time ) { Script.AppendLine( Opcodes._0668, asActor, x, y, z, time ); return this; }
        public TaskManager kill_car<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0672, asActor, hVehicle ); return this; }
        public TaskManager dive_and_get_up( Float offsetX, Float offsetY, Int timeOnGround ) { Script.AppendLine( Opcodes._0673, asActor, offsetX, offsetY, timeOnGround ); return this; }
        public TaskManager shuffle_to_next_car_seat<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0676, asActor, hVehicle ); return this; }
        public TaskManager chat_with_actor( Actor target, Int leadSpeaker_bool, Int flag ) { Script.AppendLine( Opcodes._0677, asActor, target, leadSpeaker_bool, flag ); return this; }
        public TaskManager flee_to_actor_any_means( Actor target, Float runDistance, Int time, Int changeCourse_bool, Int unknownTime1, Int unknownTime2, Float awayRadius ) { Script.AppendLine( Opcodes._0751, asActor, target, runDistance, time, changeCourse_bool, unknownTime1, unknownTime2, awayRadius ); return this; }
        public TaskManager goto_point_while_aiming( Float x, Float y, Float z, Int mode, Float turnRadius, Float stopRadius, Actor target, Float offsetX, Float offsetY, Float offsetZ ) { Script.AppendLine( Opcodes._06C2, asActor, x, y, z, mode, turnRadius, stopRadius, target, offsetX, offsetY, offsetZ ); return this; }
        public TaskManager turn_to_point( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._06BA, asActor, x, y, z ); return this; }
        public TaskManager look_at_point( Float x, Float y, Float z, Int time ) { Script.AppendLine( Opcodes._06A9, asActor, x, y, z, time ); return this; }
        public TaskManager toggle_ped_threat_scanner( Int param1_bool, Int param2_bool, Int param3_bool ) { Script.AppendLine( Opcodes._0688, asActor, param1_bool, param2_bool, param3_bool ); return this; }
        public TaskManager hold_cellphone( Int state_bool ) { Script.AppendLine( Opcodes._0729, asActor, state_bool ); return this; }
        public TaskManager weapon_roll( Int state_bool ) { Script.AppendLine( Opcodes._06E3, asActor, state_bool ); return this; }
        public TaskManager dive_from_attachment_and_get_up( Int time ) { Script.AppendLine( Opcodes._06A5, asActor, time ); return this; }
        public TaskManager sit_down( Int time ) { Script.AppendLine( Opcodes._06B0, asActor, time ); return this; }
        public TaskManager goto_actor_offset( Actor hActor, Int timelimit, Float approachDistance, Float approachAngle ) { Script.AppendLine( Opcodes._06A8, asActor, hActor, timelimit, approachDistance, approachAngle ); return this; }
        public TaskManager shoot_at_actor( Actor hActor, Int timelimit ) { Script.AppendLine( Opcodes._074D, asActor, hActor, timelimit ); return this; }
        public TaskManager arrest_actor( Actor target ) { Script.AppendLine( Opcodes._06E4, asActor, target ); return this; }
        public TaskManager car_temp_action<T>( T hVehicle, Int action, Int timelimit ) where T : Vehicle<T> { Script.AppendLine( Opcodes._06C7, asActor, hVehicle, action, timelimit ); return this; }
        public TaskManager goto_object( Object hObject, Int timelimit, Float stopWithinRadius ) { Script.AppendLine( Opcodes._06E2, asActor, hObject, timelimit, stopWithinRadius ); return this; }
        public TaskManager car_mission<T, K>( T usingVehicle, K targetVehicle, Int missionID, Float maxSpeed, Int trafficFlag ) where T : Vehicle<T> where K : Vehicle<K> { Script.AppendLine( Opcodes._06E1, asActor, usingVehicle, targetVehicle, missionID, maxSpeed, trafficFlag ); return this; }
        public TaskManager drive_to_scmpath_point<T>( T hVehicle, Float speed ) where T : Vehicle<T> { Script.AppendLine( Opcodes._06BB, asActor, hVehicle, speed ); return this; }
        public TaskManager drive_by<T>( Actor hActorIfNeed, T hVehicleIfNeed, Float x, Float y, Float z, Float radius, Int style, Int fromRhs_bool, Int firingRate ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0713, asActor, hActorIfNeed, hVehicleIfNeed, x, y, z, radius, style, fromRhs_bool, firingRate ); return this; }

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
