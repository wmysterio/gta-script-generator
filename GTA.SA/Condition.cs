using GTA.Core;

namespace GTA {

    public sealed class Condition {

        private static string reveseCondition( string opcode ) {
            var opc_number = opcode.Substring( 1, 3 );
            var opc_text = string.Empty;
            if( opcode[ 0 ] == '0' ) {
                opc_text = opcode.Substring( 5, opcode.Length - 5 ).Trim();
                return string.Format( "8{0}: not {1}", opc_number, opc_text );
            }
            opc_text = opcode.Substring( 9, opcode.Length - 9 ).Trim();
            return string.Format( "0{0}:     {1}", opc_number, opc_text );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private string opcode = string.Empty;

        // ---------------------------------------------------------------------------------------------------------------------------

        private Condition() { }
        internal Condition( string opcodeText ) { opcode = opcodeText; }
        internal Condition( string format, params object[] args ) { opcode = string.Format( format, args ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public void write() { Script.AppendLine( opcode ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Condition operator !( Condition c ) { return new Condition( reveseCondition( c.opcode ) ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [System.Obsolete()]
        public override string ToString() { return opcode; }
        [System.Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [System.Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [System.Obsolete()]
        public new System.Type GetType() { return base.GetType(); }

    }

}