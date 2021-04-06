using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class Timer : Int, INotLocal {

        internal Timer( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Timer enable_sound_when_reach( Int seconds ) { Script.AppendLine( Opcodes._0890, this, seconds ); return this; }
        public Timer stop() { Script.AppendLine( Opcodes._014F, this ); return this; }
        public Timer start( Int timerType ) { Script.AppendLine( Opcodes._014E, check_OUT_Variable( this ), timerType ); return this; }
        public Timer start( Int timerType, sString gxt ) { Script.AppendLine( Opcodes._03C3, check_OUT_Variable( this ), timerType, gxt ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Timer( GlobalVariable val ) { return new Timer( VariableContext.GLOBAL, val.index ); }

        public static Timer operator ++( Timer i1 ) { return i1 += 1; }
        public static Timer operator --( Timer i1 ) { return i1 -= 1; }

        public static Timer operator %( Timer i1, Int i2 ) { i1.mod( i1, i2 ); return i1; }
        public static Timer operator ^( Timer i1, Int i2 ) { i1.xor( i1, i2 ); return i1; }
        public static Timer operator &( Timer i1, Int i2 ) { i1.and( i1, i2 ); return i1; }
        public static Timer operator |( Timer i1, Int i2 ) { i1.or( i1, i2 ); return i1; }
        public static Timer operator +( Timer i1, Int i2 ) {
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
        public static Timer operator -( Timer i1, Int i2 ) {
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
        public static Timer operator *( Timer i1, Int i2 ) {
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
        public static Timer operator /( Timer i1, Int i2 ) {
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

        public static Condition operator ==( Timer i1, Int i2 ) {
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
        public static Condition operator >( Timer i1, Int i2 ) {
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
        public static Condition operator >=( Timer i1, Int i2 ) {
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
        public static Condition operator !=( Timer i1, Int i2 ) { return !( i1 == i2 ); }
        public static Condition operator <( Timer i1, Int i2 ) { return i2 >= i1; }
        public static Condition operator <=( Timer i1, Int i2 ) { return i2 > i1; }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}