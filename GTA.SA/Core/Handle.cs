using System;
using GTA.Core.Languages;

namespace GTA.Core {

    public abstract class Handle<T> : Variable where T : Handle<T> {

        public virtual T value {
            private get { return null; }
            set {
                check_OUT_Variable( this );
                if( value.IsDefined ) {
                    if( Context == VariableContext.GLOBAL ) {
                        Script.AppendLine( value.Context == VariableContext.GLOBAL ? Opcodes._0084 : Opcodes._008A, this, value );
                    } else {
                        Script.AppendLine( value.Context == VariableContext.GLOBAL ? Opcodes._008B : Opcodes._0085, this, value );
                    }
                } else { Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._0004 : Opcodes._0006, this, value ); }
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Handle() : base() { }
        internal Handle( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Condition operator ==( Handle<T> v1, int i1 ) {
            check_OUT_Variable( v1 );
            if( v1.Type != VariableType.INT )
                throw new Exception( Localization.VariableUnsupportType( v1.Name ) );
            return new Condition( v1.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, v1, i1 );
        }
        public static Condition operator ==( int i1, Handle<T> v1 ) {
            check_OUT_Variable( v1 );
            if( v1.Type != VariableType.INT )
                throw new Exception( Localization.VariableUnsupportType( v1.Name ) );
            return new Condition( v1.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, v1, i1 );
        }
        public static Condition operator ==( Handle<T> v1, Handle<T> v2 ) {
            if( !v1.IsDefined && !v2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( v1.Name, v2.Name ) );
            if( v1.IsDefined && !v2.IsDefined )
                return new Condition( v1.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, v1, v2 );
            if( v2.IsDefined && !v1.IsDefined )
                return new Condition( v2.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, v2, v1 );
            if( v1.Context == VariableContext.GLOBAL )
                return new Condition( v2.Context == VariableContext.GLOBAL ? Opcodes._003A : Opcodes._003C, v1, v2 );
            return new Condition( v2.Context == VariableContext.GLOBAL ? Opcodes._07D6 : Opcodes._003B, v1, v2 );
        }
        public static Condition operator !=( Handle<T> v1, int i1 ) { return !( v1 == i1 ); }
        public static Condition operator !=( int i1, Handle<T> v1 ) { return !( v1 == i1 ); }
        public static Condition operator !=( Handle<T> v1, Handle<T> v2 ) { return !( v1 == v2 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}