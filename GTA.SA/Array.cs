using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public sealed class Array<T> : IArray where T : Variable, IArrayItem {

        public delegate void ArrayHandler( T instance );

        // ---------------------------------------------------------------------------------------------------------------------------

        bool IArray.IsAutoDefined { get => isAutoDefined; }
        ushort IArray.AutoDefineSize { get => autoDefineSize; }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal int elementSize = 1;
        internal ushort startIndex = 0;

        // ---------------------------------------------------------------------------------------------------------------------------

        private bool isAutoDefined = false;
        private ushort autoDefineSize = 0;
        private StringBuilder stringBuilder = new StringBuilder();
        private int maxStartIndex = 0;
        private string elementSufix = string.Empty, arraySuffix = "i", eachNameFormat = string.Empty, arrayName = string.Empty;
        private T currentVariable = null, eachVariable = null;
        private VariableContext context = VariableContext.NONE;

        // ---------------------------------------------------------------------------------------------------------------------------

        public int count { get; private set; }
        public T this[ ushort index ] {
            get {
                if( index >= count )
                    throw new Exception( Localization.MaxIndexOfArrayOverflow( count - 1 ) );
                if( typeof( T ) == typeof( Actor ) ) {
                    Actor a = new Actor( context, 0 );
                    a.Index = ( ushort ) ( startIndex + index );
                    a.SetName();
                    a.task.asActor.Index = a.Index;
                    a.task.asActor.SetName();
                    return ( T ) ( IArrayItem ) a;
                }
                currentVariable.Index = ( ushort ) ( eachVariable.Index + ( index * eachVariable.Size ) );
                currentVariable.SetName();
                return ( T ) currentVariable.GetClone();
            }
        }
        public T this[ Out<Int> index ] {
            get {
                if( index.instance.IsArrayElement )
                    throw new Exception( Localization.DontUseArrayElementAsArrayIndex( index.instance.Name ) );
                var element = ( T ) eachVariable.GetClone();
                element.SetName( string.Format( eachNameFormat, index ) );
                if( element is Actor )
                    ( ( Actor ) ( IArrayItem ) element ).task.asActor.SetName( element.Name );
                return element;
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private Array() { }
        internal Array( VariableContext variableContext, ushort start, ushort total, bool isAuto = false ) {
            if( total == 0 ) {
                if( Script.Current.isInit )
                    throw new Exception( Localization.MinIndexOfArrayMustBe() );
                Script.errors.Add( Localization.MinIndexOfArrayMustBe() );
            }
            context = variableContext;
            startIndex = start;
            count = total;
            if( typeof( T ) == typeof( vString ) || typeof( T ) == typeof( sString ) ) {
                eachVariable = ( T ) Activator.CreateInstance( typeof( T ), BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { variableContext, start, isAuto }, null, null );
            } else {
                eachVariable = ( T ) Activator.CreateInstance( typeof( T ), BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { variableContext, start }, null, null );
            }
            eachVariable.IsArrayElement = true;
            arrayName = eachVariable.Name;
            if( variableContext == VariableContext.LOCAL ) {
                if( typeof( T ).GetTypeInfo().GetInterface( typeof( INotLocal ).FullName ) != null ) {
                    if( Script.Current.isInit )
                        throw new Exception( Localization.ArrayElementMustBeGlobalWithType( arrayName, typeof( T ).Name ) );
                    Script.errors.Add( Localization.ArrayElementMustBeGlobalWithType( arrayName, typeof( T ).Name ) );
                }
            }
            elementSufix = eachVariable.Suffix;
            elementSize = eachVariable.Size;
            switch( eachVariable.Type ) {
                case VariableType.FLOAT:
                arraySuffix = "f";
                break;
                case VariableType.SSTRING:
                arraySuffix = "s";
                break;
                case VariableType.VSTRING:
                arraySuffix = "v";
                break;
            }
            maxStartIndex = ( context == VariableContext.GLOBAL ? GlobalVariable.LIMIT : LocalVariable.LIMIT ) - elementSize * total;
            if( 0 > maxStartIndex || startIndex > maxStartIndex ) {
                if( Script.Current.isInit )
                    throw new Exception( Localization.ArrayElementCountOverflow() );
                Script.errors.Add( Localization.ArrayElementCountOverflow() );
            }
            ushort fullSize = ( ushort ) ( elementSize * total - 1 );
            if( context == VariableContext.LOCAL && 34 > startIndex ) {
                ushort lastIndex = ( ushort ) ( startIndex + fullSize );
                if( lastIndex > 31 ) {
                    if( Script.Current.isInit )
                        throw new Exception( Localization.ArrayIndexesHave32And33() );
                    Script.errors.Add( Localization.ArrayIndexesHave32And33() );
                }
            }
            if( isAuto ) {
                switch( context ) {
                    case VariableContext.GLOBAL:
                    GlobalVariable.AUTO_INDEX += fullSize;
                    break;
                    case VariableContext.LOCAL:
                    LocalVariable.AUTO_INDEX += fullSize;
                    break;
                }
            }
            currentVariable = ( T ) eachVariable.GetClone();
            currentVariable.IsArrayElement = true;
            eachNameFormat = string.Format( eachVariable.Context == VariableContext.GLOBAL ? "${0}({1},{2}{3})" : "{0}@({1},{2}{3})", eachVariable.Index, "{0}", count, arraySuffix );
        }
        internal Array( ushort total ) {
            if( Generator.tmpUseAutomaticVariableInitialization ) {
                var tracer = new StackTrace();
                var frames = tracer.GetFrames();
                if( frames.Length > 2 ) {
                    var method = frames[ 2 ].GetMethod();
                    if( method.MemberType == MemberTypes.Constructor ) {
                        isAutoDefined = true;
                        autoDefineSize = total;
                        return;
                    }
                }
            }
            if( Script.Current.isInit )
                throw new Exception( Localization.ArrayElementCreatedOnlyInAutoinitialize() );
            Script.errors.Add( Localization.ArrayElementCreatedOnlyInAutoinitialize() );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public void each( Out<Int> index, ArrayHandler action ) {
            if( action == null )
                return;
            if( count == 1 ) {
                currentVariable.Index = startIndex;
                currentVariable.SetName();
                action.Invoke( currentVariable );
                return;
            }
            var oldName = eachVariable.Name;
            eachVariable.SetName( string.Format( eachNameFormat, index ) );
            Script.AppendLine( "\nint {0}\nfor {0} = 0 to {1}", index, count - 1 );
            action.Invoke( eachVariable );
            Script.AppendLine( "end\n" );
            eachVariable.SetName( oldName );
        }
        public void do_if_index_in_range( Int index, Action action ) {
            Variable.check_OUT_Variable( index );
            Script.and( index > -1, count > index, action );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal string ToLine() {
            var format = context == VariableContext.GLOBAL ? " ${0}" : " {0}@";
            if( count == 1 )
                return string.Format( format, startIndex );
            stringBuilder.Clear();
            for( int i = 0, k = startIndex; i < count; i++ )
                for( int j = 0; j < elementSize; j++, k++ )
                    stringBuilder.AppendFormat( format, k );
            return stringBuilder.ToString();
        }
        internal string ToElements() {
            var format = context == VariableContext.GLOBAL ? " {1}${0}" : " {0}@{1}";
            if( count == 1 )
                return string.Format( format, startIndex, elementSufix );
            stringBuilder.Clear();
            for( int i = 0, k = startIndex; i < count; i++, k += elementSize )
                stringBuilder.AppendFormat( format, k, elementSufix );
            return stringBuilder.ToString();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Array<T>( LocalArray val ) { return new Array<T>( VariableContext.LOCAL, val.index, val.count, val.isAuto ); }
        public static implicit operator Array<T>( GlobalArray val ) { return new Array<T>( VariableContext.GLOBAL, val.index, val.count, val.isAuto ); }
        public static implicit operator Array<T>( ushort total ) { return new Array<T>( total ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return arrayName; }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}