using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class sString : Variable, IArrayItem, IVariable {

        public static Int[] GetParameters( Out<sString> str ) {
            var index = ( ushort ) ( str.instance.Index + 1 );
            return new Int[ 2 ] {
                new Int( str.instance.Context, str.instance.Index ),
                new Int( str.instance.Context, index )
            };
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// ""
        /// </summary>
        public const string DUMMY = "DUMMY";
        /// <summary>
        /// $~1~
        /// </summary>
        public const string DOLLAR = "DOLLAR";
        public const string LOCKED_PROPERTY = "PROP_4";
        public const string FORSALE_PROPERTY = "PROP_3";
        /// <summary>
        /// PASSED + MONEY
        /// </summary>
        public const string M_PASS = "M_PASS";
        /// <summary>
        /// PASSED
        /// </summary>
        public const string M_PASSD = "M_PASSD";
        /// <summary>
        /// FAILED
        /// </summary>
        public const string M_FAIL = "M_FAIL";
        /// <summary>
        /// PASSED + RESPECT
        /// </summary>
        public const string M_PASSR = "M_PASSR";
        /// <summary>
        /// PASSED + MONEY + RESPECT
        /// </summary>
        public const string M_PASSS = "M_PASSS";

        // ---------------------------------------------------------------------------------------------------------------------------

        internal sString( VariableContext context, ushort index, bool isAuto = false ) : base( context, index ) {
            Type = VariableType.SSTRING;
            if( isAuto ) {
                if( context == VariableContext.GLOBAL )
                    GlobalVariable.AUTO_INDEX += 1;
                if( context == VariableContext.LOCAL )
                    LocalVariable.AUTO_INDEX += 1;
            }
        }
        internal sString( string val ) : base() {
            IsDefined = false;
            Name = $"'{val}'";
            checkLenght( val );
        }
        internal sString( Enum val ) : base() {
            IsDefined = false;
            Name = $"'{val.ToString()}'";
            checkLenght( val.ToString() );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void checkLenght( string val ) {
            if( val.Length > 7 )
                throw new Exception( Localization.IncorrectSStringLenght( val ) );
        }
        internal override void SetSizeAndSuffix() {
            Size = 2;
            Suffix = "s";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public sString value {
            private get { return null; }
            set {
                check_OUT_Variable( this );
                Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._05A9 : Opcodes._05AA, this, value );
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public sString get_width( Out<Int> width ) {
            check_OUT_Variable( this );
            Script.AppendLine( Opcodes._09FD, this, width );
            return this;
        }
        public sString get_width_with_number( Int number, Out<Int> width ) {
            check_OUT_Variable( this );
            Script.AppendLine( Opcodes._0A08, this, number, width );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_empty() {
            check_OUT_Variable( this );
            return new Condition( Context == VariableContext.GLOBAL ? Opcodes._0844 : Opcodes._0845, this );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator sString( LocalVariable val ) { return new sString( VariableContext.LOCAL, val.index, val.isAuto ); }
        public static implicit operator sString( GlobalVariable val ) { return new sString( VariableContext.GLOBAL, val.index, val.isAuto ); }
        public static implicit operator sString( string val ) { return new sString( val ); }
        public static implicit operator sString( Enum val ) { return new sString( val ); }

        public static Condition operator ==( sString s1, sString s2 ) {
            if( !s1.IsDefined && !s2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( s1.Name, s2.Name ) );
            if( s1.IsDefined )
                return new Condition( s1.Context == VariableContext.GLOBAL ? Opcodes._05AD : Opcodes._05AE, s1, s2 );
            return new Condition( s2.Context == VariableContext.GLOBAL ? Opcodes._05AD : Opcodes._05AE, s2, s1 );
        }
        public static Condition operator !=( sString s1, sString s2 ) { return !( s1 == s2 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}