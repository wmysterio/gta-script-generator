using System;
using System.Linq;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public sealed class SaveGame {

        internal const int POINTS_LIMIT = 20;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal static bool isOverrided13point = false;
        internal static double px, py, pz, ax, ay, az, aa;

        private static SaveGame instance = null;

        // ---------------------------------------------------------------------------------------------------------------------------

        public static void OverrideAngelPainPosition( double x, double y, double z, double playerPositionX, double playerPositionY, double playerPositionZ, double playerZAngle ) {
            px = x;
            py = y;
            pz = z;
            ax = playerPositionX;
            ay = playerPositionY;
            az = playerPositionZ;
            aa = playerZAngle;
            isOverrided13point = true;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal bool isDefault;

        private SaveGameSetup saveGameSetup = new SaveGameSetup();

        // ---------------------------------------------------------------------------------------------------------------------------

        private Player p = Script.PlayerChar;
        private Actor a = Script.PlayerActor;

        // ---------------------------------------------------------------------------------------------------------------------------

        private Array<Pickup> pickups;

        private Int index = Script.local(); // 0@

        // ---------------------------------------------------------------------------------------------------------------------------

        public SaveGame() : this( setup => {
            setup.add_point( 2495.53, -1711.88, 1014.24, 2495.9, -1707.45, 1013.26, 0.0 ) // 0
                 .add_point( 1263.05, -773.67, 1091.39, 1263.76, -776.59, 1090.89, 183.23 ) // 1
                 .add_point( 416.9548, 2538.813, 9.5077, 418.0759, 2536.771, 9.0077, 269.2893 ) // 2
                 .add_point( 2367.192, -1121.518, 1050.382, 2367.072, -1123.715, 1049.875, 183.259 ) // 3
                 .add_point( 2320.103, -1009.116, 1049.718, 2320.103, -1013.375, 1049.211, 181.7957 ) // 4
                 .add_point( 2342.873, -1063.939, 1048.523, 2339.254, -1063.86, 1048.023, 90.7733 ) // 5
                 .add_point( 2186.014, -1203.834, 1048.523, 2189.818, -1203.83, 1048.031, 268.6874 ) // 6
                 .add_point( 2313.369, -1208.744, 1048.523, 2310.853, -1210.975, 1048.023, 130.1776 ) // 7
                 .add_point( 2249.397, -1209.449, 1048.523, 2252.7, -1209.388, 1048.023, 270.3929 ) // 8
                 .add_point( 2244.533, -1077.663, 1048.523, 2241.069, -1077.736, 1048.031, 88.0268 ) // 9
                 .add_point( 2205.382, -1074.59, 1049.977, 2207.852, -1075.324, 1049.477, 261.7253 ) // 10
                 .add_point( 2233.024, -1105.717, 1050.39, 2233.231, -1107.852, 1049.89, 182.2496 ) // 11
                 .add_point( 2278.139, -1139.583, 1050.398, 2281.524, -1139.37, 1049.898, 273.5033 ); // 12
            if( isOverrided13point ) {
                setup.add_point( px, py, pz, ax, ay, az, aa ); // 13
            } else {
                setup.add_point( -2037.89, -2526.96, 30.13, -2039.78, -2529.1, 29.63, 21.23 ); // 13
            }
            setup.add_point( 877.81, -26.91, 62.69, 877.04, -30.16, 62.19, 66.85 ) // 14
                 .add_point( -2026.481, 156.8028, 28.5391, -2021.036, 156.0674, 27.6521, 272.5815 ) // 15
                 .add_point( -693.3776, 957.824, 11.7829, -700.3663, 966.0852, 11.3575, 90.0 ) // 16
                 .add_point( 2024.564, 996.4728, 10.3203, 2027.043, 996.0585, 9.9203, 275.516 ); // 17
        } ) { isDefault = true; }
        public SaveGame( HandlerSaveGame setup ) {
            if( instance != null )
                throw new Exception( Localization.PluginMustBeOnce( nameof( SaveGame ) ) );
            instance = this;
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( SaveGame ) ) );
            if( Script.Current.ScriptName == "MAIN" )
                throw new Exception( Localization.PluginCreatedInMainTrhead( nameof( SaveGame ) ) );
            if( setup == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( SaveGame ), nameof( HandlerSaveGame ) ) );

            setup.Invoke( saveGameSetup );

            if( saveGameSetup.count > POINTS_LIMIT || 1 > saveGameSetup.count )
                throw new Exception( Localization.PluginOverflowCountOfSavePointsOrZero( nameof( SaveGame ), POINTS_LIMIT ) );

            pickups = Script.global_array( saveGameSetup.count );

            Script.wait( Script.DefaultWaitTime );
            Script.and( Script.OnMission == false, p.is_defined() );
            for( ushort i = 0; i < saveGameSetup.count; i++ ) {
                var element = saveGameSetup.data.ElementAt( i ).Value;
                if( element.action != null )
                    element.action.Invoke();
            }
            Script.Gosub += CREATE_PICKUPS;
            Script.Jump += MAIN_LOOP;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void MAIN_LOOP( LabelJump label ) {
            Script.wait( 0 );
            Script.and( Script.OnMission == true, delegate {
                Script.Gosub += DELETE_PICKUPS;
                Script.Jump += WAIT_MISSION_END;
            } );
            Script.and( MAIN_LOOP, p.is_defined() );
            index.value = 0;
            Script.Gosub += CHECK_PICKUP;
            Script.jump( MAIN_LOOP );
        }

        private void WAIT_MISSION_END( LabelJump label ) {
            Script.wait( Script.DefaultWaitTime );
            Script.and( WAIT_MISSION_END, Script.OnMission == false );
            Script.Gosub += CREATE_PICKUPS;
            Script.jump( MAIN_LOOP );
        }

        private void CHECK_PICKUP( LabelGosub label ) {
            Script.wait( 0 );
            Script.and( index >= saveGameSetup.count, Script.@return );
            Script.and( pickups[ index ].is_picked_up(), delegate {
                Script.Gosub += SHOW_SAVE_SCREEN;
                Script.and( p.is_defined(), delegate {
                    pickups[ index ].destroy();
                    Script.jump_table( index, table => {
                        for( ushort i = 0; i < saveGameSetup.count; i++ ) {
                            var element = saveGameSetup.data.ElementAt( i ).Value;
                            var index = saveGameSetup.data.ElementAt( i ).Key;
                            table.label( i, l => {
                                Script.clear_area( true, element.playerPositionX, element.playerPositionY, element.playerPositionZ, 1.0 );
                                a.set_position( element.playerPositionX, element.playerPositionY, element.playerPositionZ ).set_z_angle( element.playerZAngle );
                                pickups[ index ].create( ObjectModel.PICKUPSAVE, PickupType.ONCE, element.x, element.y, element.z );
                                Script.jump( table.EndLabel );
                            } );
                        }
                    } );
                    Script.wait( 0 );
                    Script.fade( FadeType.IN, 1000 );
                    Script.Gosub += RESTORE_CONTROL;
                } );
            } );
            index += 1;
            Script.jump( label );
        }

        private void SHOW_SAVE_SCREEN( LabelGosub label ) {
            Script.OnMission.value = true;
            p.can_move( false );
            Script.show_save_screen();

            Script.wait( Script.is_save_done() ); // !

            Script.set_fade_color_rgb( 0, 0, 0 );
            Script.fade( FadeType.OUT, 1000 );
            Script.and( p.is_defined(), delegate { p.can_move( false ); } );
        }

        private void RESTORE_CONTROL( LabelGosub label ) {
            Script.and( p.is_defined(), delegate {
                Script.CAMERA.restore_with_jumpcut().set_behind_player();
            } );
            Script.wait( 500 );
            Script.and( p.is_defined(), delegate { p.can_move( true ); } );
            Script.OnMission.value = false;
        }

        private void DELETE_PICKUPS( LabelGosub label ) {
            for( ushort i = 0; i < saveGameSetup.count; i++ )
                pickups[ i ].destroy();
        }

        private void CREATE_PICKUPS( LabelGosub label ) {
            for( ushort i = 0; i < saveGameSetup.count; i++ ) {
                var element = saveGameSetup.data.ElementAt( i ).Value;
                pickups[ i ].create( ObjectModel.PICKUPSAVE, PickupType.ONCE, element.x, element.y, element.z );
            }
        }

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