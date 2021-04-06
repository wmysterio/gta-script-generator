using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public sealed class Calculator {

        public static Calculator execute( Out<Int> result, string expression ) {
            if( string.IsNullOrEmpty( expression ) )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            expression = doFilterExecute( expression );
            if( 1 > expression.Length )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            var split = expression.Split( ' ' );
            if( 3 > split.Length || split.Length > functionsArgsLimit )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            for( int i = 1; i < split.Length; i += 2 ) {
                var item = split[ i ];
                var symbol = item[ 0 ];
                if( !operationChars.ContainsKey( symbol ) )
                    throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            }
            if( operationChars.ContainsKey( split[ split.Length - 1 ][ 0 ] ) )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            StringBuilder stringBuilder = new StringBuilder();
            ushort valVariableNumber = 0, valIndexNumber = 0, valSizeNumber = 0;
            int valNumber = 0;
            MatchCollection matches = null;
            for( int i = 0, j = -1; i < split.Length; i++, j *= -1 ) {
                var item = split[ i ];
                if( j == 1 ) {
                    stringBuilder.AppendFormat( " {0}", operationChars[ item[ 0 ] ] );
                    continue;
                }
                if( int.TryParse( item, out valNumber ) ) {
                    stringBuilder.AppendFormat( " {0}", valNumber );
                    continue;
                }
                if( Regex.IsMatch( item, @"^\d+@$", RegexOptions.Compiled | RegexOptions.Singleline ) ) {
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                if( Regex.IsMatch( item, @"^\$\d+$", RegexOptions.Compiled | RegexOptions.Singleline ) ) {
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                #region CHECK ARRAY'S, SA ONLY
                matches = Regex.Matches( item, @"^(\d+)@\((\d+)@,(\d+)i\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Int> arr = Script.local_array( valVariableNumber, valSizeNumber );
                        Int index = Script.local( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                matches = Regex.Matches( item, @"^(\d+)@\(\$(\d+),(\d+)i\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Int> arr = Script.local_array( valVariableNumber, valSizeNumber );
                        Int index = Script.global( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                matches = Regex.Matches( item, @"^\$(\d+)\((\d+)@,(\d+)i\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Int> arr = Script.global_array( valVariableNumber, valSizeNumber );
                        Int index = Script.local( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                matches = Regex.Matches( item, @"^\$(\d+)\(\$(\d+),(\d+)i\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Int> arr = Script.global_array( valVariableNumber, valSizeNumber );
                        Int index = Script.global( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                #endregion
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            }
            var blankCommandCount = functionsArgsLimit - split.Length;
            if( blankCommandCount > 0 ) {
                for( int i = 0; i < blankCommandCount; i++ )
                    stringBuilder.Append( " 0" );
            }
            Script.Ignore = delegate { Script.call_scm_function<FUNCTION_CALCULATOR_EXECUTE_INT>( 0 ); };
            Script.AppendLine( $@"0AB1: call_scm_func @{nameof( FUNCTION_CALCULATOR_EXECUTE_INT )} {functionsArgsLimit} expression{stringBuilder.ToString()} result_to {result}" );
            return instance;
        }
        public static Calculator execute( Out<Float> result, string expression ) {
            if( string.IsNullOrEmpty( expression ) )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            expression = doFilterExecute( expression );
            if( 1 > expression.Length )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            var split = expression.Split( ' ' );
            if( 3 > split.Length || split.Length > functionsArgsLimit )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            for( int i = 1; i < split.Length; i += 2 ) {
                var item = split[ i ];
                var symbol = item[ 0 ];
                if( !operationChars.ContainsKey( symbol ) )
                    throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            }
            if( operationChars.ContainsKey( split[ split.Length - 1 ][ 0 ] ) )
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            StringBuilder stringBuilder = new StringBuilder();
            ushort valVariableNumber = 0, valIndexNumber = 0, valSizeNumber = 0;
            double valNumber = 0;
            string dblName = "";
            MatchCollection matches = null;
            for( int i = 0, j = -1; i < split.Length; i++, j *= -1 ) {
                var item = split[ i ];
                if( j == 1 ) {
                    stringBuilder.AppendFormat( " {0}", operationChars[ item[ 0 ] ] );
                    continue;
                }
                if( double.TryParse( item, out valNumber ) ) {
                    dblName = double.Parse( item.Replace( ",", "." ) ).ToString();
                    if( !dblName.Contains( "." ) )
                        dblName += ".0";
                    stringBuilder.AppendFormat( " {0}", dblName );
                    continue;
                }
                if( Regex.IsMatch( item, @"^\d+@$", RegexOptions.Compiled | RegexOptions.Singleline ) ) {
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                if( Regex.IsMatch( item, @"^\$\d+$", RegexOptions.Compiled | RegexOptions.Singleline ) ) {
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                #region CHECK ARRAY'S, SA ONLY
                matches = Regex.Matches( item, @"^(\d+)@\((\d+)@,(\d+)f\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Float> arr = Script.local_array( valVariableNumber, valSizeNumber );
                        Int index = Script.local( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                matches = Regex.Matches( item, @"^(\d+)@\(\$(\d+),(\d+)f\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Float> arr = Script.local_array( valVariableNumber, valSizeNumber );
                        Int index = Script.global( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                matches = Regex.Matches( item, @"^\$(\d+)\((\d+)@,(\d+)f\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Float> arr = Script.global_array( valVariableNumber, valSizeNumber );
                        Int index = Script.local( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                matches = Regex.Matches( item, @"^\$(\d+)\(\$(\d+),(\d+)f\)$", RegexOptions.Compiled | RegexOptions.Singleline );
                if( matches.Count > 0 ) {
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 1 ].Value, out valVariableNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 2 ].Value, out valIndexNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    if( !ushort.TryParse( matches[ 0 ].Groups[ 3 ].Value, out valSizeNumber ) )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    var hasError = false;
                    try {
                        Array<Float> arr = Script.global_array( valVariableNumber, valSizeNumber );
                        Int index = Script.global( valIndexNumber );
                    } catch { hasError = true; }
                    if( hasError )
                        throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
                    stringBuilder.AppendFormat( " {0}", item );
                    continue;
                }
                #endregion
                throw new Exception( Localization.PluginCalculatorHasIncorrectExpression( nameof( Calculator ), nameof( execute ) ) );
            }
            var blankCommandCount = functionsArgsLimit - split.Length;
            if( blankCommandCount > 0 ) {
                for( int i = 0, j = -1; i < blankCommandCount; i++, j *= -1 )
                    stringBuilder.Append( j == -1 ? " 0" : " 0.0" );
            }
            Script.Ignore = delegate { Script.call_scm_function<FUNCTION_CALCULATOR_EXECUTE_FLOAT>( 0 ); };
            Script.AppendLine( $@"0AB1: call_scm_func @{nameof( FUNCTION_CALCULATOR_EXECUTE_FLOAT )} {functionsArgsLimit} expression{stringBuilder.ToString()} result_to {result}" );
            return instance;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Calculator instance = new Calculator();

        // ---------------------------------------------------------------------------------------------------------------------------

        private static ushort functionsArgsLimit = ( ushort ) ( Parameter.LIMIT - 3 );
        private static Dictionary<char, byte> validChars = new Dictionary<char, byte> {
            { '@', 0 },
            { '$', 0 },
            { '+', 0 },
            { '-', 0 },
            { '*', 0 },
            { '/', 0 },
            { '.', 0 }, // FOR FLOAT VALUES
            { '(', 0 }, // FOR ARRAY, DONT USE IN GTA III AND VC
            { ')', 0 }, // FOR ARRAY, DONT USE IN GTA III AND VC
            { ',', 0 }, // FOR ARRAY, DONT USE IN GTA III AND VC
            { 'i', 0 }, // FOR ARRAY, DONT USE IN GTA III AND VC
            { 'f', 0 }  // FOR ARRAY, DONT USE IN GTA III AND VC
        };
        private static Dictionary<char, byte> operationChars = new Dictionary<char, byte> {
            { '+', ( byte ) TypeOfCalulatorOperations.PLUS  },
            { '-', ( byte ) TypeOfCalulatorOperations.MINUS },
            { '*', ( byte ) TypeOfCalulatorOperations.MUL   },
            { '/', ( byte ) TypeOfCalulatorOperations.DIV   }
        };
        private static string doFilterExecute( string expression ) {
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < expression.Length; i++ ) {
                var item = expression[ i ];
                if( char.IsDigit( item ) || item == ' ' )
                    stringBuilder.Append( item );
                if( validChars.ContainsKey( item ) )
                    stringBuilder.Append( item );
            }
            return Regex.Replace( stringBuilder.ToString().Trim(), " {1,}", " ", RegexOptions.Compiled | RegexOptions.Singleline );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private class FUNCTION_CALCULATOR_DO_OPERATION : Function, ICustomFunction {

            Int type = local( 0 ), operation = local( 1 ), leftInt = local( 2 ), rigthInt = local( 3 );
            Float leftFloat = local( 2 ), rigthFloat = local( 3 );

            public override void START( LabelJump label ) {
                and( type == 0, delegate {
                    Gosub += DO_OPERATION_INT;
                }, delegate {
                    Gosub += DO_OPERATION_FLOAT;
                } );
                ret( leftInt );
            }

            private void DO_OPERATION_INT( LabelGosub label ) {
                and( operation == 1, delegate { leftInt += rigthInt; } );
                and( operation == 2, delegate { leftInt -= rigthInt; } );
                and( operation == 3, delegate { leftInt *= rigthInt; } );
                and( operation == 4, delegate { leftInt /= rigthInt; } );
            }

            private void DO_OPERATION_FLOAT( LabelGosub label ) {
                and( operation == 1, delegate { leftFloat += rigthFloat; } );
                and( operation == 2, delegate { leftFloat -= rigthFloat; } );
                and( operation == 3, delegate { leftFloat *= rigthFloat; } );
                and( operation == 4, delegate { leftFloat /= rigthFloat; } );
            }

        }
        private class FUNCTION_CALCULATOR_EXECUTE_FLOAT : Function, ICustomFunction {

            Array<Float> parameters = local_array( 0, functionsArgsLimit );
            Array<Int> operations = local_array( 0, functionsArgsLimit );
            Int index1 = local( 27 );
            Int index2 = local( 28 );
            Float leftVal = local( 29 );
            Float rigthVal = local( 30 );
            Float result = local( 31 );
            Int offset = local( 29 );
            Float nextValue = local( 31 );

            public override void START( LabelJump label ) {
                to( index1, 1, operations.count - 1, h => {
                    and( operations[ index1 ] == TypeOfCalulatorOperations.NONE, h.@break );
                    or(
                        operations[ index1 ] == TypeOfCalulatorOperations.MUL,
                        operations[ index1 ] == TypeOfCalulatorOperations.DIV
                    , delegate {
                        index2.add( index1, 1 );
                        rigthVal.value = parameters[ index2 ];
                        index2.sub( index1, 1 );
                        leftVal.value = parameters[ index2 ];
                        call_scm_function<FUNCTION_CALCULATOR_DO_OPERATION>( 4, TypeOfDataType.FLOAT, operations[ index1 ], leftVal, rigthVal, result );
                        parameters[ index2 ].value = result;
                        to( index2, index1, operations.count - 1, delegate {
                            offset.add( index2, 2 );
                            operations[ index2 ].value = operations[ offset ];
                            offset.add( index2, 3 );
                            nextValue.value = parameters[ offset ];
                            offset.add( index2, 1 );
                            parameters[ offset ].value = nextValue;
                        }, 2 );
                        operations[ ( ushort ) ( operations.count - 2 ) ].value = TypeOfCalulatorOperations.NONE;
                        parameters[ ( ushort ) ( parameters.count - 1 ) ].value = 0.0;
                        index1 -= 2;
                        h.@continue();
                    } );
                }, 2 );
                result.value = parameters[ 0 ];
                to( index1, 1, operations.count - 1, h => {
                    and( operations[ index1 ] == TypeOfCalulatorOperations.NONE, h.@break );
                    index2.sub( index1, 1 );
                    leftVal.value = parameters[ index2 ];
                    index2.add( index1, 1 );
                    rigthVal.value = parameters[ index2 ];
                    call_scm_function<FUNCTION_CALCULATOR_DO_OPERATION>( 4, TypeOfDataType.FLOAT, operations[ index1 ], leftVal, rigthVal, result );
                    parameters[ index2 ].value = result;
                }, 2 );
                ret( result );
            }

        }
        private class FUNCTION_CALCULATOR_EXECUTE_INT : Function, ICustomFunction {

            Array<Int> parameters = local_array( 0, functionsArgsLimit );
            Array<Int> operations = local_array( 0, functionsArgsLimit );
            Int index1 = local( 27 );
            Int index2 = local( 28 );
            Int leftVal = local( 29 );
            Int rigthVal = local( 30 );
            Int result = local( 31 );
            Int offset = local( 29 );
            Int nextValue = local( 31 );

            public override void START( LabelJump label ) {
                to( index1, 1, operations.count - 1, h => {
                    and( operations[ index1 ] == TypeOfCalulatorOperations.NONE, h.@break );
                    or(
                        operations[ index1 ] == TypeOfCalulatorOperations.MUL,
                        operations[ index1 ] == TypeOfCalulatorOperations.DIV
                    , delegate {
                        index2.add( index1, 1 );
                        rigthVal.value = parameters[ index2 ];
                        index2.sub( index1, 1 );
                        leftVal.value = parameters[ index2 ];
                        call_scm_function<FUNCTION_CALCULATOR_DO_OPERATION>( 4, TypeOfDataType.INT, operations[ index1 ], leftVal, rigthVal, result );
                        parameters[ index2 ].value = result;
                        to( index2, index1, operations.count - 1, delegate {
                            offset.add( index2, 2 );
                            operations[ index2 ].value = operations[ offset ];
                            offset.add( index2, 3 );
                            nextValue.value = parameters[ offset ];
                            offset.add( index2, 1 );
                            parameters[ offset ].value = nextValue;
                        }, 2 );
                        operations[ ( ushort ) ( operations.count - 2 ) ].value = TypeOfCalulatorOperations.NONE;
                        parameters[ ( ushort ) ( parameters.count - 1 ) ].value = 0;
                        index1 -= 2;
                        h.@continue();
                    } );
                }, 2 );
                result.value = parameters[ 0 ];
                to( index1, 1, operations.count - 1, h => {
                    and( operations[ index1 ] == TypeOfCalulatorOperations.NONE, h.@break );
                    index2.sub( index1, 1 );
                    leftVal.value = parameters[ index2 ];
                    index2.add( index1, 1 );
                    rigthVal.value = parameters[ index2 ];
                    call_scm_function<FUNCTION_CALCULATOR_DO_OPERATION>( 4, TypeOfDataType.INT, operations[ index1 ], leftVal, rigthVal, result );
                    parameters[ index2 ].value = result;
                }, 2 );
                ret( result );
            }

        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private Calculator() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

        // ---------------------------------------------------------------------------------------------------------------------------

        private enum TypeOfDataType { INT, FLOAT }
        private enum TypeOfCalulatorOperations : int { NONE, PLUS, MINUS, MUL, DIV }

    }

}