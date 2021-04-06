using System;
using GTA.Core.Languages;

namespace GTA.Core {

    public sealed class Parameter {

        internal static ushort LIMIT = 30;

        private string name = string.Empty;

        private Parameter() { }
        internal Parameter( Variable val ) {
            if( val.Type == VariableType.SSTRING || val.Type == VariableType.VSTRING )
                throw new Exception( Localization.VariableIsNonParametr( val.Name ) );
            name = val.Name;
        }
        internal Parameter( int val ) : base() { name = val.ToString(); }
        internal Parameter( bool val ) : base() { name = $"{( val ? "1" : "0" )}"; }
        internal Parameter( Enum val ) : base() { name = $"{( int ) ( object ) val}"; }
        internal Parameter( double val ) : base() {
            name = val.ToString();
            if( !name.Contains( "." ) )
                name += ".0";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public override string ToString() { return name; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Parameter( Variable val ) { return new Parameter( val ); }
        public static implicit operator Parameter( int val ) { return new Parameter( val ); }
        public static implicit operator Parameter( bool val ) { return new Parameter( val ); }
        public static implicit operator Parameter( Enum val ) { return new Parameter( val ); }
        public static implicit operator Parameter( double val ) { return new Parameter( val ); }
        public static implicit operator Parameter( OutParameter val ) { return new Parameter( val.GetInstance() ); }
        
    }

}