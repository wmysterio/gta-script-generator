using System;
using System.Text;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class Panel : Handle<Panel>, IArrayItem, IVariable {

        internal Panel( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        private StringBuilder sBuilder = new StringBuilder();

        // ---------------------------------------------------------------------------------------------------------------------------

        public Panel get_active_row( Out<Int> row ) { Script.AppendLine( Opcodes._08D7, row, this ); return this; }
        public Panel get_selected_row( Out<Int> row ) { Script.AppendLine( Opcodes._08D8, row, this ); return this; }
        public Panel remove() { Script.AppendLine( Opcodes._08DA, this ); return this; }
        public Panel set_active_row( Int row ) { Script.AppendLine( Opcodes._090E, this, row ); return this; }
        public Panel highlight_row( Int row, Int state_bool ) { Script.AppendLine( Opcodes._0A23, this, row, state_bool ); return this; }
        public Panel set_enable_row( Int row, Int state_bool ) { Script.AppendLine( Opcodes._08D9, this, row, state_bool ); return this; }
        public Panel set_column_alignment( Int column, Int panelAlignment ) { Script.AppendLine( Opcodes._08D6, this, column, panelAlignment ); return this; }
        public Panel create( sString gxtHeader, Float x, Float y, Float width, Int columns, Int interactive_bool, Int background_bool, Int panelAlignment ) { Script.AppendLine( Opcodes._08D4, this, gxtHeader, x, y, width, columns, interactive_bool, background_bool, panelAlignment ); return this; }
        public Panel set_column_width( Int column, Int width ) { Script.AppendLine( Opcodes._09DB, this, column, width ); return this; }
        public Panel set_text_1number( Int column, Int row, sString gxtTitle, Int number ) { Script.AppendLine( Opcodes._08EE, this, column, row, gxtTitle, number ); return this; }
        public Panel set_text_2numbers( Int column, Int row, sString gxtTitle, Int number1, Int number2 ) { Script.AppendLine( Opcodes._08EF, this, column, row, gxtTitle, number1, number2 ); return this; }
        public Panel set_column_data( Int column, sString gxtHeader, params sString[] gxtRows ) {
            if( gxtRows == null || gxtRows.Length == 0 || gxtRows.Length > 12 )
                throw new Exception( Localization.PanelIncorrectRowsCount( Name ) );
            sBuilder.Clear();
            for( int i = 0; i < gxtRows.Length; i++ )
                sBuilder.AppendFormat( $"{gxtRows[ i ].Name} " );
            for( int i = 0; i < 12 - gxtRows.Length; i++ )
                sBuilder.AppendFormat( $"'{sString.DUMMY}' " );
            Script.AppendLine( Opcodes._08DB, this, column, gxtHeader, sBuilder.ToString() );
            return this;
        }
        public Panel create( sString gxtHeader, Float x, Float y, Float width, Int interactive_bool, Int background_bool, Int panelAlignment, string[,] data ) {
            if( data.Rank != 2 )
                throw new Exception( Localization.PanelArrayDimenstionNot2( nameof( data ) ) );
            var rows = data.GetLength( 0 );
            var columns = data.GetLength( 1 );
            if( 2 > rows )
                throw new Exception( Localization.PanelRowsLow1( nameof( data ) ) );
            if( rows > 13 )
                throw new Exception( Localization.PanelRowsGreat12( nameof( data ) ) );
            create( gxtHeader, x, y, width, columns, interactive_bool, background_bool, panelAlignment );
            for( byte i = 0; i < columns; i++ )
                set_column_data( i, data[ 0, i ], getColumn( data, rows, i ) );
            return this;
        }
        public Panel set_column_data<T>( Int column, sString gxtHeader, Array<T> array ) where T : sString {
            sBuilder.Clear();
            if( array == null )
                throw new Exception( Localization.PanelNeedArray() );
            if( array.count == 0 || array.count > 12 )
                throw new Exception( Localization.PanelElementCountMustBeFrom1To12( Name ) );
            for( ushort i = 0; i < array.count; i++ )
                sBuilder.AppendFormat( "{0} ", array[ i ] );
            for( int i = 0; i < 12 - array.count; i++ )
                sBuilder.AppendFormat( "{0} ", $"'{sString.DUMMY}'" );
            Script.AppendLine( Opcodes._08DB, this, column, gxtHeader, sBuilder.ToString() );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private sString[] getColumn( string[,] data, int max_lenght, int current_column ) {
            sString[] arr = new sString[ 12 ];
            int j = 0;
            for( int i = 1; i < max_lenght; i++, j++ )
                arr[ j ] = data[ i, current_column ];
            for( int i = j; i < 12; i++ )
                if( ReferenceEquals( arr[ i ], null ) )
                    arr[ i ] = sString.DUMMY;
            return arr;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Panel( LocalVariable val ) { return new Panel( VariableContext.LOCAL, val.index ); }
        public static implicit operator Panel( GlobalVariable val ) { return new Panel( VariableContext.GLOBAL, val.index ); }

    }

}