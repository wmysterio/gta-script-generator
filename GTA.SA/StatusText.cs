using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class StatusText : Int, INotLocal {

        internal StatusText( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public StatusText create( Int stausTextType, sString gxt ) { Script.AppendLine( Opcodes._03C4, check_OUT_Variable( this ), stausTextType, gxt ); return this; }
        public StatusText remove() { Script.AppendLine( Opcodes._0151, this ); return this; }
        public StatusText enable_flashing( Int state_bool ) { Script.AppendLine( Opcodes._059C, this, state_bool ); return this; }
        public StatusText create( Int type_bool, Int line, sString gxt ) { Script.AppendLine( Opcodes._04F7, this, type_bool, line, gxt ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator StatusText( GlobalVariable val ) { return new StatusText( VariableContext.GLOBAL, val.index ); }

        public static StatusText operator ++( StatusText i1 ) { return i1 += 1; }
        public static StatusText operator --( StatusText i1 ) { return i1 -= 1; }

        public static StatusText operator %( StatusText i1, Int i2 ) { i1.mod( i1, i2 ); return i1; }
        public static StatusText operator ^( StatusText i1, Int i2 ) { i1.xor( i1, i2 ); return i1; }
        public static StatusText operator &( StatusText i1, Int i2 ) { i1.and( i1, i2 ); return i1; }
        public static StatusText operator |( StatusText i1, Int i2 ) { i1.or( i1, i2 ); return i1; }
        public static StatusText operator +( StatusText i1, Int i2 ) {
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
        public static StatusText operator -( StatusText i1, Int i2 ) {
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
        public static StatusText operator *( StatusText i1, Int i2 ) {
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
        public static StatusText operator /( StatusText i1, Int i2 ) {
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

        public static Condition operator ==( StatusText i1, Int i2 ) {
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
        public static Condition operator >( StatusText i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0018 : Opcodes._0019, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002A : Opcodes._002B, i1, i2 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001C : Opcodes._001E, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001F : Opcodes._001D, i1, i2 );
        }
        public static Condition operator >=( StatusText i1, Int i2 ) {
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
        public static Condition operator !=( StatusText i1, Int i2 ) { return !( i1 == i2 ); }
        public static Condition operator <( StatusText i1, Int i2 ) { return i2 >= i1; }
        public static Condition operator <=( StatusText i1, Int i2 ) { return i2 > i1; }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}