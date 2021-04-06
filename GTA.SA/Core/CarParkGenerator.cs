using System;
using System.Reflection;
using GTA.Core.Languages;

namespace GTA.Core {

    public sealed class CarParkGenerator {

        internal static ushort MaxCount = 500, Count = 0;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal static readonly CarParkGenerator instance = new CarParkGenerator();

        // ---------------------------------------------------------------------------------------------------------------------------

        private CarParkGenerator() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public CarParkGenerator init<T>( T hVehicle, Float x, Float y, Float z, Float angle, Int vehicleModel, Int carColor1 = null, Int carColor2 = null, Int forceSpawn_bool = null, Int alarm_byte = null, Int doorLock_byte = null, Int minDelay = null, Int maxDelay = null ) where T : Vehicle<T> {
            Variable.check_OUT_Variable( hVehicle );
            if( hVehicle.Context != VariableContext.GLOBAL ) // GTAException
                throw new Exception( Localization.UseVariableAsStaticOnly( hVehicle.Name ) );
            Count++;
            if( Count > MaxCount )
                throw new Exception( Localization.CarParkMaxCountOverflow( MaxCount ) );
            if( ReferenceEquals( forceSpawn_bool, null ) )
                forceSpawn_bool = false;
            if( ReferenceEquals( alarm_byte, null ) )
                alarm_byte = 0;
            if( ReferenceEquals( doorLock_byte, null ) )
                doorLock_byte = 0;
            if( ReferenceEquals( carColor1, null ) )
                carColor1 = -1;
            if( ReferenceEquals( carColor2, null ) )
                carColor2 = -1;
            if( ReferenceEquals( minDelay, null ) )
                minDelay = 0;
            if( ReferenceEquals( maxDelay, null ) )
                maxDelay = 10000;
            Script.AppendLine( Opcodes._014B, hVehicle, vehicleModel, carColor1, carColor2, forceSpawn_bool, alarm_byte, doorLock_byte, minDelay, maxDelay, x, y, z, angle );
            return this;
        }
        public CarParkGenerator init_with_number_plate<T>( T hVehicle, Float x, Float y, Float z, Float angle, Int vehicleModel, vString plate, Int carColor1 = null, Int carColor2 = null, Int forceSpawn_bool = null, Int alarm_byte = null, Int doorLock_byte = null, Int minDelay = null, Int maxDelay = null ) where T : Vehicle<T> {
            Variable.check_OUT_Variable( hVehicle );
            if( hVehicle.Context != VariableContext.GLOBAL )
                throw new Exception( Localization.UseVariableAsStaticOnly( hVehicle.Name ) );
            Count++;
            if( Count > MaxCount )
                throw new Exception( Localization.CarParkMaxCountOverflow( MaxCount ) );
            if( ReferenceEquals( forceSpawn_bool, null ) )
                forceSpawn_bool = false;
            if( ReferenceEquals( alarm_byte, null ) )
                alarm_byte = 0;
            if( ReferenceEquals( doorLock_byte, null ) )
                doorLock_byte = 0;
            if( ReferenceEquals( carColor1, null ) )
                carColor1 = -1;
            if( ReferenceEquals( carColor2, null ) )
                carColor2 = -1;
            if( ReferenceEquals( minDelay, null ) )
                minDelay = 0;
            if( ReferenceEquals( maxDelay, null ) )
                maxDelay = 10000;
            Script.AppendLine( Opcodes._09E2, hVehicle, vehicleModel, carColor1, carColor2, forceSpawn_bool, alarm_byte, doorLock_byte, minDelay, maxDelay, plate, x, y, z, angle );
            return this;
        }
        public CarParkGenerator set_chance_to_generate<T>( T hVehicle, Int chanceToCreate_byte ) where T : Vehicle<T> {
            Variable.check_OUT_Variable( hVehicle );
            if( hVehicle.Context != VariableContext.GLOBAL )
                throw new Exception( Localization.UseVariableAsStaticOnly( hVehicle.Name ) );
            Script.AppendLine( Opcodes._014C, hVehicle, chanceToCreate_byte );
            return this;
        }
        public CarParkGenerator set_to_player_owned<T>( T hVehicle, Int state_bool ) where T : Vehicle<T> {
            Variable.check_OUT_Variable( hVehicle );
            if( hVehicle.Context != VariableContext.GLOBAL )
                throw new Exception( Localization.UseVariableAsStaticOnly( hVehicle.Name ) );
            Script.AppendLine( Opcodes._0A17, hVehicle, state_bool );
            return this;
        }
        
        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public new string ToString() { return base.ToString(); }
        [Obsolete()]
        public new bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public new int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}