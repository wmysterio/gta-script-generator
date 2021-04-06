using GTA.Core.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTA.Core {

    public sealed class JumpTable {

        private Int caseValue;
        private Script script;
        private uint switchCounter, indexCounter;
        private StringBuilder stringBuilder;
        private Dictionary<uint, HandlerCase> cases;

        // ---------------------------------------------------------------------------------------------------------------------------

        public LabelCase EndLabel { get; private set; }

        public event HandlerCase Auto {
            add {
                var index = indexCounter;
                indexCounter++;
                cases.Add( index, value );
            }
            remove { }
        }
        
        // ---------------------------------------------------------------------------------------------------------------------------

        private JumpTable() { }
        internal JumpTable( Out<Int> caseValue ) {
            this.caseValue = caseValue.instance;
            script = Script.Current;
            switchCounter = script.switchCounter;
            script.switchCounter += 1;
            stringBuilder = new StringBuilder();
            EndLabel = new LabelCase( script, switchCounter );
            EndLabel.EndJumpTable = EndLabel;
            cases = new Dictionary<uint, HandlerCase>();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public JumpTable label( uint value, HandlerCase label ) {
            if( cases.ContainsKey( value ) )
                throw new Exception( Localization.SwitchExistCaseValue( value ) );
            cases.Add( value, label );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal void write() {
            if( cases.Count == 0 )
                throw new Exception( Localization.JumpTableNoneCases() );
            if( cases.Count > 75 )
                throw new Exception( Localization.JumpTableOverflowCases() );
            LabelCase[] labels = new LabelCase[ cases.Count ];
            for( int i = 0; i < labels.Length; i++ )
                labels[ i ] = new LabelCase( script, switchCounter, cases.ElementAt( i ).Key );
            if( 8 > cases.Count ) {
                var total_unused_label = 7 - cases.Count;
                for( int i = 0; i < cases.Count; i++ ) {
                    var element = cases.ElementAt( i );
                    stringBuilder.Append( $" {element.Key} @{labels[ i ]}" );
                }
                for( int i = 0; i < total_unused_label; i++ )
                    stringBuilder.Append( $" -1 @{EndLabel}" );
                Script.AppendLine( Opcodes._0871, caseValue, cases.Count.ToString(), EndLabel, stringBuilder.ToString() );
            } else {
                var rightCasesLenght = cases.Count;
                for( int i = 0; i < 7; i++ ) {
                    var element = cases.ElementAt( i );
                    stringBuilder.Append( $" {element.Key} @{labels[ i ]}" );
                }
                Script.AppendLine( Opcodes._0871, caseValue, cases.Count.ToString(), EndLabel, stringBuilder.ToString() );
                rightCasesLenght -= 7;
                void write0872( int startIndex ) {
                    if( startIndex > cases.Count )
                        return;
                    stringBuilder.Clear();
                    var total_unused_label = 9 - rightCasesLenght;
                    if( 10 > rightCasesLenght ) {
                        for( int i = startIndex; i < cases.Count; i++ ) {
                            var element = cases.ElementAt( i );
                            stringBuilder.Append( $" {element.Key} @{labels[ i ]}" );
                        }
                        for( int i = 0; i < total_unused_label; i++ )
                            stringBuilder.Append( $" -1 @{EndLabel}" );
                        Script.AppendLine( Opcodes._0872, stringBuilder.ToString() );
                        return;
                    }
                    for( int i = startIndex; i < ( startIndex + 9 ); i++ ) {
                        var element = cases.ElementAt( i );
                        stringBuilder.Append( $" {element.Key} @{labels[ i ]}" );
                    }
                    Script.AppendLine( Opcodes._0872, stringBuilder.ToString() );
                    startIndex += 9;
                    rightCasesLenght -= 9;
                    write0872( startIndex );
                }
                write0872( 7 );
            }
            for( int i = 0; i < labels.Length; i++ ) {
                var @case = cases.ElementAt( i );
                Script.label( labels[ i ] );
                labels[ i ].EndJumpTable = EndLabel;
                @case.Value.Invoke( labels[ i ] );
            }
            Script.label( EndLabel );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}