using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public abstract class MissionCustom : Script {

        public static void mission_cleanup() { AppendLine( Opcodes._00D8 ); }
        public static void increment_mission_attempts() { AppendLine( Opcodes._0317 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Condition is_wasted_or_busted() { return new Condition( Opcodes._0112 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal bool IsCustom;

        // ---------------------------------------------------------------------------------------------------------------------------

        public MissionCustom() : base( TypeOfScript.MISSION ) {
            IsCustom = true;
            if( MissionCounter > 200 )
                throw new Exception( Localization.OverflowMissionsCount() );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void BeforeStart() {
            printError();
            BuilderString.Append( $"\n//------------- MISSION: {allScripts[ this ]} ---------------" );
            label( $"{ScriptName}_ERROR_SKIP" );
            AppendLine( Opcodes._03A4, $"'{ScriptName}'" );
            if( !IsCustom )
                PrintMissionCodeBefore( this );
            label( Current.ScriptName );
        }

    }

}