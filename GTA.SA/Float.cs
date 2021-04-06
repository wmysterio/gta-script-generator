using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class Float : Variable, IArrayItem, IVariable {

        public static readonly double MAX = 3.40282347E+38D;
        public static readonly double MIN = -3.40282347E+38D;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Float( VariableContext context, ushort index ) : base( context, index ) { Type = VariableType.FLOAT; }
        internal Float( double val ) : base() {
            IsDefined = false;
            Name = val.ToString();
            if( !Name.Contains( "." ) )
                Name += ".0";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Float value {
            private get { return null; }
            set {
                check_OUT_Variable( this );
                if( value.IsDefined ) {
                    if( Context == VariableContext.GLOBAL ) {
                        Script.AppendLine( value.Context == VariableContext.GLOBAL ? Opcodes._0086 : Opcodes._0088, this, value );
                    } else {
                        Script.AppendLine( value.Context == VariableContext.GLOBAL ? Opcodes._0089 : Opcodes._0087, this, value );
                    }
                } else { Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._0005 : Opcodes._0007, this, value ); }
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Float add_delta_time( Float multiplier ) {
            check_OUT_Variable( this );
            if( multiplier.IsDefined ) {
                if( Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( multiplier.Context == VariableContext.GLOBAL ? Opcodes._007A : Opcodes._007D, this, multiplier );
                } else {
                    Script.AppendLine( multiplier.Context == VariableContext.GLOBAL ? Opcodes._007C : Opcodes._007B, this, multiplier );
                }
            } else { Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._0078 : Opcodes._0079, this, multiplier ); }
            return this;
        }
        public Float sub_delta_time( Float multiplier ) {
            check_OUT_Variable( this );
            if( multiplier.IsDefined ) {
                if( Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( multiplier.Context == VariableContext.GLOBAL ? Opcodes._0080 : Opcodes._0083, this, multiplier );
                } else {
                    Script.AppendLine( multiplier.Context == VariableContext.GLOBAL ? Opcodes._0082 : Opcodes._0081, this, multiplier );
                }
            } else { Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._007E : Opcodes._007F, this, multiplier ); }
            return this;
        }
        public Float to_integer( Out<Int> value ) {
            check_OUT_Variable( this );
            if( Context == VariableContext.GLOBAL ) {
                Script.AppendLine( value.instance.Context == VariableContext.GLOBAL ? Opcodes._008C : Opcodes._008E, value, this );
            } else {
                Script.AppendLine( value.instance.Context == VariableContext.GLOBAL ? Opcodes._0090 : Opcodes._0092, value, this );
            }
            return this;
        }
        public Float random() { Script.AppendLine( Opcodes._0098, check_OUT_Variable( this ) ); return this; }
        public Float random( Float min, Float max ) { Script.AppendLine( Opcodes._0208, check_OUT_Variable( this ), min, max ); return this; }
        public Float square_root( Float val ) { Script.AppendLine( Opcodes._01FB, check_OUT_Variable( this ), val ); return this; }
        public Float sine( Float val ) { Script.AppendLine( Opcodes._02F6, check_OUT_Variable( this ), val ); return this; }
        public Float cosine( Float val ) { Script.AppendLine( Opcodes._02F7, check_OUT_Variable( this ), val ); return this; }
        public Float exp( Float left, Float exp ) { Script.AppendLine( Opcodes._0AEE, check_OUT_Variable( this ), left, exp ); return this; }
        public Float log( Float log, Float baseValue ) { Script.AppendLine( Opcodes._0AEF, check_OUT_Variable( this ), log, baseValue ); return this; }
        public Float to_string_format( vString format, Out<vString> str ) { Script.AppendLine( Opcodes._0AED, str, Variable.check_OUT_Variable( this ), format ); return this; }
        public Float limit( Float val ) { Script.AppendLine( Opcodes._0656, val, Variable.check_OUT_Variable( this ) ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Float( LocalVariable val ) { return new Float( VariableContext.LOCAL, val.index ); }
        public static implicit operator Float( GlobalVariable val ) { return new Float( VariableContext.GLOBAL, val.index ); }
        public static implicit operator Float( double val ) { return new Float( val ); }

        public static Float operator ++( Float f1 ) { return f1 += 1.0; }
        public static Float operator --( Float f1 ) { return f1 -= 1.0; }

        public static Float operator +( Float f1, Float f2 ) {
            check_OUT_Variable( f1 );
            if( f2.IsDefined ) {
                if( f1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0059 : Opcodes._005F, f1, f2 );
                } else {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._005D : Opcodes._005B, f1, f2 );
                }
            } else { Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0009 : Opcodes._000B, f1, f2 ); }
            return f1;
        }
        public static Float operator -( Float f1, Float f2 ) {
            check_OUT_Variable( f1 );
            if( f2.IsDefined ) {
                if( f1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0061 : Opcodes._0067, f1, f2 );
                } else {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0065 : Opcodes._0063, f1, f2 );
                }
            } else { Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._000D : Opcodes._000F, f1, f2 ); }
            return f1;
        }
        public static Float operator *( Float f1, Float f2 ) {
            check_OUT_Variable( f1 );
            if( f2.IsDefined ) {
                if( f1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0069 : Opcodes._006D, f1, f2 );
                } else {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._006F : Opcodes._006B, f1, f2 );
                }
            } else { Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0011 : Opcodes._0013, f1, f2 ); }
            return f1;
        }
        public static Float operator /( Float f1, Float f2 ) {
            check_OUT_Variable( f1 );
            if( f2.IsDefined ) {
                if( f1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0071 : Opcodes._0075, f1, f2 );
                } else {
                    Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0077 : Opcodes._0073, f1, f2 );
                }
            } else { Script.AppendLine( f1.Context == VariableContext.GLOBAL ? Opcodes._0015 : Opcodes._0017, f1, f2 ); }
            return f1;
        }

        public static Condition operator ==( Float f1, Float f2 ) {
            if( !f1.IsDefined && !f2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( f1.Name, f2.Name ) );
            if( f1.IsDefined && !f2.IsDefined )
                return new Condition( f1.Context == VariableContext.GLOBAL ? Opcodes._0042 : Opcodes._0043, f1, f2 );
            if( f2.IsDefined && !f1.IsDefined )
                return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0042 : Opcodes._0043, f2, f1 );
            if( f1.Context == VariableContext.GLOBAL )
                return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0044 : Opcodes._0046, f1, f2 );
            return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._07D7 : Opcodes._0045, f1, f2 );
        }
        public static Condition operator >( Float f1, Float f2 ) {
            if( !f1.IsDefined && !f2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( f1.Name, f2.Name ) );
            if( f1.IsDefined && !f2.IsDefined )
                return new Condition( f1.Context == VariableContext.GLOBAL ? Opcodes._0020 : Opcodes._0021, f1, f2 );
            if( f2.IsDefined && !f1.IsDefined )
                return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0022 : Opcodes._0023, f1, f2 );
            if( f1.Context == VariableContext.GLOBAL )
                return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0024 : Opcodes._0026, f1, f2 );
            return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0027 : Opcodes._0025, f1, f2 );
        }
        public static Condition operator >=( Float f1, Float f2 ) {
            if( !f1.IsDefined && !f2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( f1.Name, f2.Name ) );
            if( f1.IsDefined && !f2.IsDefined )
                return new Condition( f1.Context == VariableContext.GLOBAL ? Opcodes._0030 : Opcodes._0031, f1, f2 );
            if( f2.IsDefined && !f1.IsDefined )
                return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0032 : Opcodes._0033, f1, f2 );
            if( f1.Context == VariableContext.GLOBAL )
                return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0034 : Opcodes._0036, f1, f2 );
            return new Condition( f2.Context == VariableContext.GLOBAL ? Opcodes._0037 : Opcodes._0035, f1, f2 );
        }
        public static Condition operator !=( Float f1, Float f2 ) { return !( f1 == f2 ); }
        public static Condition operator <( Float f1, Float f2 ) { return f2 >= f1; }
        public static Condition operator <=( Float f1, Float f2 ) { return f2 > f1; }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}