using System;
using System.Text;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class vString : Variable, IArrayItem, IVariable {

        public static Int[] GetParameters( Out<vString> str ) {
            var index = ( ushort ) ( str.instance.Index + 1 );
            var index2 = ( ushort ) ( str.instance.Index + 2 );
            var index3 = ( ushort ) ( str.instance.Index + 3 );
            return new Int[ 4 ] {
                new Int( str.instance.Context, str.instance.Index ),
                new Int( str.instance.Context, index ),
                new Int( str.instance.Context, index2 ),
                new Int( str.instance.Context, index3 )
            };
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public const string NULL = "NULL";

        // ---------------------------------------------------------------------------------------------------------------------------

        internal vString( VariableContext context, ushort index, bool isAuto = false ) : base( context, index ) {
            Type = VariableType.VSTRING;
            if( isAuto ) {
                if( context == VariableContext.GLOBAL )
                    GlobalVariable.AUTO_INDEX += 3;
                if( context == VariableContext.LOCAL )
                    LocalVariable.AUTO_INDEX += 3;
            }
        }
        internal vString( string val ) : base() {
            IsDefined = false;
            Name = $"\"{val}\"";
        }
        internal vString( Enum val ) : base() {
            IsDefined = false;
            Name = $"\"{val.ToString()}\"";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal override void SetSizeAndSuffix() {
            Size = 4;
            Suffix = "v";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public vString value {
            private get { return null; }
            set {
                check_OUT_Variable( this );
                Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._06D1 : Opcodes._06D2, this, value );
            }
        }
        public vString format( vString textFormat, params Parameter[] args ) {
            check_OUT_Variable( this );
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( format ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            Script.AppendLine( Opcodes._0AD3, this, textFormat, stringBuilder.ToString() );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator vString( LocalVariable val ) { return new vString( VariableContext.LOCAL, val.index, val.isAuto ); }
        public static implicit operator vString( GlobalVariable val ) { return new vString( VariableContext.GLOBAL, val.index, val.isAuto ); }
        public static implicit operator vString( string val ) { return new vString( val ); }
        public static implicit operator vString( Enum val ) { return new vString( val ); }

        public static Condition operator ==( vString s1, vString s2 ) {
            if( !s1.IsDefined && !s2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( s1.Name, s2.Name ) );
            if( s1.IsDefined )
                return new Condition( s1.Context == VariableContext.GLOBAL ? Opcodes._08F9 : Opcodes._08FA, s1, s2 );
            return new Condition( s2.Context == VariableContext.GLOBAL ? Opcodes._08F9 : Opcodes._08FA, s2, s1 );
        }
        public static Condition operator !=( vString s1, vString s2 ) { return !( s1 == s2 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}