using System;
using System.Text;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public class File : Handle<File>, IArrayItem, IVariable {

        internal File( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public File get_size( Out<Int> size ) { Script.AppendLine( Opcodes._0A9C, size, this ); return this; }
        public File read( Int size, Out<Int> to ) { Script.AppendLine( Opcodes._0A9D, this, size, to ); return this; }
        public File close() { Script.AppendLine( Opcodes._0A9B, this ); return this; }
        public File write( Int size, Int from ) { Script.AppendLine( Opcodes._0A9E, this, size, from ); return this; }
        public File write_formatt( vString textFormat, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( write_formatt ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            Script.AppendLine( Opcodes._0AD9, this, textFormat, this, stringBuilder.ToString() );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------
        
        public Condition read_string( Int size, Out<vString> str ) { return new Condition( Opcodes._0AD7, this, str, size ); }
        public Condition read_formatt( Out<Int> result, vString format, params Out<Variable>[] args_out ) {
            StringBuilder sBuilder = new StringBuilder();
            if( args_out.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( read_formatt ), Parameter.LIMIT ) );
            for( int i = 0; i < args_out.Length; i++ ) {
                if( args_out[ i ].instance.Size != 1 )
                    throw new Exception( Localization.VariableIsNonParametr( args_out[ i ].ToString() ) );
            }
            return new Condition( Opcodes._0ADA, result, format, check_OUT_Variable( this ), sBuilder.ToString() );
        }
        public Condition open( vString path, vString openMode ) { return new Condition( Opcodes._0A9A, check_OUT_Variable( this ), path, openMode ); }
        public Condition is_reached_to_end() { return new Condition( Opcodes._0AD6, this ); }
        public Condition set_seek( Int seek, Int seekMode_byte ) { return new Condition( Opcodes._0AD5, this, seek, seekMode_byte ); }
        public Condition write_string( vString str ) { return new Condition( Opcodes._0AD8, this, str ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator File( LocalVariable val ) { return new File( VariableContext.LOCAL, val.index ); }
        public static implicit operator File( GlobalVariable val ) { return new File( VariableContext.GLOBAL, val.index ); }

    }

}