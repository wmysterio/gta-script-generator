using GTA.Core;

namespace GTA {

    public static class Garage {

        public static void activate( sString garageName ) { Script.AppendLine( Opcodes._0299, garageName ); }
        public static void deactivate( sString garageName ) { Script.AppendLine( Opcodes._02B9, garageName ); }
        public static void change_type( sString garageName, Int type ) { Script.AppendLine( Opcodes._02FA, garageName, type ); }
        public static void open( sString garageName ) { Script.AppendLine( Opcodes._0360, garageName ); }
        public static void close( sString garageName ) { Script.AppendLine( Opcodes._0361, garageName ); }
        public static void set_to_accept_vehicle( sString garageName, Int vehicleModel ) { Script.AppendLine( Opcodes._021B, garageName, vehicleModel ); }
        public static void disable_resprays( Int state_bool ) { Script.AppendLine( Opcodes._0A14, state_bool ); }
        public static void set_respray_free( sString garageName, Int state_bool ) { Script.AppendLine( Opcodes._093A, garageName, state_bool ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Condition is_open( sString garageName ) { return new Condition( Opcodes._03B0, garageName ); }
        public static Condition is_closed( sString garageName ) { return new Condition( Opcodes._03B1, garageName ); }

    }

}