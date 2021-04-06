using System;
using System.Text;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public abstract class Function : Script {

        internal static uint Counter = 0;

        // ---------------------------------------------------------------------------------------------------------------------------

        public Function() : base( TypeOfScript.FUNCTION ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        protected static void ret( params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( ret ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AB2, args.Length, stringBuilder.ToString() );
        }
        protected static void ret_true() { ( PlayerActor == PlayerActor ).write(); }
        protected static void ret_false() { ( PlayerActor != PlayerActor ).write(); }
        protected static void ret_true_with_args( params Parameter[] args ) { ret_true(); ret( args ); }
        protected static void ret_false_with_args( params Parameter[] args ) { ret_true(); ret( args ); }
        protected static void ret_true_without_args() { ret_true_with_args(); }
        protected static void ret_false_without_args() { ret_false_with_args(); }

    }

}