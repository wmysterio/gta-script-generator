using System;
using System.Text;
using GTA.Core.Languages;

namespace GTA.Core {

    internal enum VariableType { INT, FLOAT, SSTRING, VSTRING }
    internal enum VariableContext { NONE, LOCAL, GLOBAL }

    public abstract class Variable {

        public static ushort IndexOf<T>( Handle<T> variable ) where T : Handle<T> { check_OUT_Variable( variable ); return variable.Index; }
        public static ushort IndexOf<T>( Array<T> array ) where T : Variable, IArrayItem { return array.startIndex; }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal static object check_OUT_Variable( Variable var ) {
            if( !var.IsDefined )
                throw new Exception( Localization.VariableWithoutContext( var.ToString() ) );
            return var;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private StringBuilder stringBuilder = new StringBuilder();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal bool IsArrayElement = false;
        internal bool IsDefined = true;
        internal ushort Index = 0;
        internal ushort Size = 1;
        internal string Name = string.Empty;
        internal string Suffix = string.Empty;
        internal VariableType Type = VariableType.INT;
        internal VariableContext Context = VariableContext.NONE;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Variable() { }
        internal Variable( VariableContext context, ushort index ) {
            Index = index;
            Context = context;
            SetSizeAndSuffix();
            SetName();
            checkSize();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void checkSize() {
            if( Context == VariableContext.NONE )
                return;
            var right = ( Context == VariableContext.GLOBAL ? GlobalVariable.LIMIT : LocalVariable.LIMIT ) - Size;
            if( Index > right ) {
                if( Script.Current.isInit )
                    throw new Exception( Localization.VariableOverflowSize( Name ) );
                Script.errors.Add( Localization.VariableOverflowSize( Name ) );
                return;
            }
            if( Context == VariableContext.GLOBAL )
                return;
            if( Type == VariableType.SSTRING ) {
                if( 31 > Index || Index > 34 )
                    return;
                goto show_incorrect_index_message;
            }
            if( Type == VariableType.VSTRING ) {
                if( 29 > Index || Index > 33 )
                    return;
                goto show_incorrect_index_message;
            }
            if( 32 > Index || Index > 33 )
                return;
            show_incorrect_index_message:
            if( Script.Current.isInit )
                throw new Exception( Localization.StringIncorrectIndex( Name, Index.ToString() ) );
            Script.errors.Add( Localization.StringIncorrectIndex( Name, Index.ToString() ) );
        }

        internal object GetClone() { return MemberwiseClone(); }

        internal virtual void SetSizeAndSuffix() {
            Size = 1;
            Suffix = string.Empty;
        }
        internal void SetName() { Name = Context == VariableContext.GLOBAL ? $"{Suffix}${Index}" : $"{Index}@{Suffix}"; }
        internal void SetName( string custom ) { Name = custom; }
        internal string ToLine() {
            check_OUT_Variable( this );
            var format = Context == VariableContext.GLOBAL ? " ${0}" : " {0}@";
            if( Size == 1 )
                return string.Format( format, Index );
            stringBuilder.Clear();
            for( int i = 0, j = Index; i < Size; i++, j++ )
                stringBuilder.AppendFormat( format, j );
            return stringBuilder.ToString();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return Name; }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}