using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    internal enum TypeOfLabel { NONE, JUMP, GOSUB }

    public class Int : Handle<Int>, IArrayItem, IVariable {

        public static readonly int MAX = 2147483647;
        public static readonly int MIN = -2147483648;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal TypeOfLabel labelType = TypeOfLabel.NONE;
        internal string labelName = string.Empty;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Int( VariableContext context, ushort index ) : base( context, index ) { }
        internal Int( int val ) : base() { IsDefined = false; Name = val.ToString(); }
        internal Int( bool val ) : base() { IsDefined = false; Name = $"{( val ? "1" : "0" )}"; }
        internal Int( Enum val ) : base() { IsDefined = false; Name = $"{( int ) ( object ) val}"; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public override Int value { 
            set {
                base.value = value;
                labelType = TypeOfLabel.NONE;
                labelName = string.Empty;
            }
        }
        public bool this[ Int index ] {
            set {
                if( value ) {
                    this.set_bit( index );
                } else {
                    this.clear_bit( index );
                }
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Int add( Int left, Int right ) { Script.AppendLine( Opcodes._0A8E, check_OUT_Variable( this ), left, right ); return this; }
        public Int sub( Int left, Int right ) { Script.AppendLine( Opcodes._0A8F, check_OUT_Variable( this ), left, right ); return this; }
        public Int mul( Int left, Int right ) { Script.AppendLine( Opcodes._0A90, check_OUT_Variable( this ), left, right ); return this; }
        public Int div( Int left, Int right ) { Script.AppendLine( Opcodes._0A91, check_OUT_Variable( this ), left, right ); return this; }
        public Int make_absolute() { Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._0094 : Opcodes._0095, check_OUT_Variable( this ) ); return this; }
        public Int to_float( Out<Float> value ) {
            check_OUT_Variable( this );
            if( Context == VariableContext.GLOBAL ) {
                Script.AppendLine( value.instance.Context == VariableContext.GLOBAL ? Opcodes._008D : Opcodes._008F, value, this );
            } else {
                Script.AppendLine( value.instance.Context == VariableContext.GLOBAL ? Opcodes._0091 : Opcodes._0093, value, this );
            }
            return this;
        }
        public Int random() { Script.AppendLine( Opcodes._0099, check_OUT_Variable( this ) ); return this; }
        public Int random( Int min, Int max ) { Script.AppendLine( Opcodes._0209, check_OUT_Variable( this ), min, max ); return this; }
        public Int and( Int left, Int right ) { Script.AppendLine( Opcodes._0B10, check_OUT_Variable( this ), left, right ); return this; }
        public Int or( Int left, Int right ) { Script.AppendLine( Opcodes._0B11, check_OUT_Variable( this ), left, right ); return this; }
        public Int xor( Int left, Int right ) { Script.AppendLine( Opcodes._0B12, check_OUT_Variable( this ), left, right ); return this; }
        public Int not( Int left ) { Script.AppendLine( Opcodes._0B13, check_OUT_Variable( this ), left ); return this; }
        public Int mod( Int left, Int right ) { Script.AppendLine( Opcodes._0B14, check_OUT_Variable( this ), left, right ); return this; }
        public Int shr( Int left, Int right ) { Script.AppendLine( Opcodes._0B15, check_OUT_Variable( this ), left, right ); return this; }
        public Int shl( Int left, Int right ) { Script.AppendLine( Opcodes._0B16, check_OUT_Variable( this ), left, right ); return this; }
        public Int set_bit( Int bitNumber_byte ) {
            check_OUT_Variable( this );
            if( !bitNumber_byte.IsDefined ) {
                int bit = int.Parse( bitNumber_byte.Name );
                if( 0 > bit || bit > 31 )
                    throw new Exception( Localization.BadBit() );
                Script.AppendLine( this.Context == VariableContext.GLOBAL ? Opcodes._08BA : Opcodes._08BD, this, bitNumber_byte );
                return this;
            }
            if( this.Context == VariableContext.GLOBAL ) {
                Script.AppendLine( bitNumber_byte.Context == VariableContext.GLOBAL ? Opcodes._08BB : Opcodes._08BC, this, bitNumber_byte );
                return this;
            }
            Script.AppendLine( bitNumber_byte.Context == VariableContext.GLOBAL ? Opcodes._08BE : Opcodes._08BF, this, bitNumber_byte );
            return this;
        }
        public Int clear_bit( Int bitNumber_byte ) {
            check_OUT_Variable( this );
            if( !bitNumber_byte.IsDefined ) {
                int bit = int.Parse( bitNumber_byte.Name );
                if( 0 > bit || bit > 31 )
                    throw new Exception( Localization.BadBit() );
                Script.AppendLine( this.Context == VariableContext.GLOBAL ? Opcodes._08C0 : Opcodes._08C3, this, bitNumber_byte );
                return this;
            }
            if( this.Context == VariableContext.GLOBAL ) {
                Script.AppendLine( bitNumber_byte.Context == VariableContext.GLOBAL ? Opcodes._08C1 : Opcodes._08C2, this, bitNumber_byte );
                return this;
            }
            Script.AppendLine( bitNumber_byte.Context == VariableContext.GLOBAL ? Opcodes._08C4 : Opcodes._08C5, this, bitNumber_byte );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_bit_set( Int bitNumber_byte ) {
            check_OUT_Variable( this );
            if( !bitNumber_byte.IsDefined ) {
                int bit = int.Parse( bitNumber_byte.Name );
                if( 0 > bit || bit > 31 )
                    throw new Exception( Localization.BadBit() );
                return new Condition( this.Context == VariableContext.GLOBAL ? Opcodes._08B4 : Opcodes._08B7, this, bitNumber_byte );
            }
            if( Context == VariableContext.GLOBAL )
                return new Condition( bitNumber_byte.Context == VariableContext.GLOBAL ? Opcodes._08B5 : Opcodes._08B6, this, bitNumber_byte );
            return new Condition( bitNumber_byte.Context == VariableContext.GLOBAL ? Opcodes._08B8 : Opcodes._08B9, this, bitNumber_byte );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Int( LocalVariable val ) { return new Int( VariableContext.LOCAL, val.index ); }
        public static implicit operator Int( GlobalVariable val ) { return new Int( VariableContext.GLOBAL, val.index ); }
        public static implicit operator Int( int val ) { return new Int( val ); }
        public static implicit operator Int( bool val ) { return new Int( val ); }
        public static implicit operator Int( Enum val ) { return new Int( val ); }

        public static Int operator ++( Int i1 ) { return i1 += 1; }
        public static Int operator --( Int i1 ) { return i1 -= 1; }

        public static Int operator %( Int i1, Int i2 ) { i1.mod( i1, i2 ); return i1; }
        public static Int operator ^( Int i1, Int i2 ) { i1.xor( i1, i2 ); return i1; }
        public static Int operator &( Int i1, Int i2 ) { i1.and( i1, i2 ); return i1; }
        public static Int operator |( Int i1, Int i2 ) { i1.or( i1, i2 ); return i1; }
        public static Int operator +( Int i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0058 : Opcodes._005E, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._005C : Opcodes._005A, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0008 : Opcodes._000A, i1, i2 ); }
            return i1;
        }
        public static Int operator -( Int i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0060 : Opcodes._0066, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0064 : Opcodes._0062, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._000C : Opcodes._000E, i1, i2 ); }
            return i1;
        }
        public static Int operator *( Int i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0068 : Opcodes._006C, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._006E : Opcodes._006A, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0010 : Opcodes._0012, i1, i2 ); }
            return i1;
        }
        public static Int operator /( Int i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0070 : Opcodes._0074, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0076 : Opcodes._0072, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0014 : Opcodes._0016, i1, i2 ); }
            return i1;
        }

        public static Condition operator ==( Int i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, i2, i1 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._003A : Opcodes._003C, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._07D6 : Opcodes._003B, i1, i2 );
        }
        public static Condition operator >( Int i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0018 : Opcodes._0019, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001A : Opcodes._001B, i1, i2 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001C : Opcodes._001E, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001F : Opcodes._001D, i1, i2 );
        }
        public static Condition operator >=( Int i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0028 : Opcodes._0029, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002A : Opcodes._002B, i1, i2 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002C : Opcodes._002E, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002F : Opcodes._002D, i1, i2 );
        }
        public static Condition operator !=( Int i1, Int i2 ) { return !( i1 == i2 ); }
        public static Condition operator <( Int i1, Int i2 ) { return i2 >= i1; }
        public static Condition operator <=( Int i1, Int i2 ) { return i2 > i1; }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}