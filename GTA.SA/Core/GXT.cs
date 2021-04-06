using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using GTA.Core.Languages;

namespace GTA.Core {

    public sealed class GXT {

        private const string KEY_REGULAR_EXPRESSION = "^[A-Z_@0-9]{1,7}$";
        private const string FILE_REGULAR_EXPRESSION = "^[a-z_0-9]{1,32}$";

        // ---------------------------------------------------------------------------------------------------------------------------

        internal static readonly GXT instance = new GXT();

        // ---------------------------------------------------------------------------------------------------------------------------

        public readonly string DEFAULT_FILE = "text";

        // ---------------------------------------------------------------------------------------------------------------------------

        private Dictionary<string, GXTFile> files = new Dictionary<string, GXTFile>();
        private string currentFile = string.Empty;

        // ---------------------------------------------------------------------------------------------------------------------------

        private GXT() { set_file( DEFAULT_FILE ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public GXT set_file( string fileName ) {
            currentFile = fileName.ToLower();
            if( !Regex.IsMatch( currentFile, FILE_REGULAR_EXPRESSION, RegexOptions.Compiled | RegexOptions.Singleline ) )
                throw new Exception( Localization.GXTIncorrectFXTFileName( fileName ) );
            if( files.ContainsKey( currentFile ) )
                return this;
            files.Add( currentFile, new GXTFile() );
            return this;
        }
        public GXT set_encoding( GXTEncoding encoding ) {
            if( encoding == null )
                throw new Exception( Localization.GXTNonEncoding() );
            files[ currentFile ].encoding = encoding;
            return this;
        }
        public GXT add( string key, string format, params object[] args ) {
            key = key.ToUpper();
            if( !Regex.IsMatch( key, KEY_REGULAR_EXPRESSION, RegexOptions.Compiled | RegexOptions.Singleline ) )
                throw new Exception( Localization.GXTBadKeyName( key ) );
            if( files[ currentFile ].texts.ContainsKey( key ) )
                throw new Exception( Localization.GXTExistKey( key ) );
            files[ currentFile ].texts.Add( key, string.Format( format, args ) );
            Localization.PrintGXTAddedKey( key );
            return this;
        }
        public GXT copy( string fromFileName ) {
            if( !files.ContainsKey( fromFileName ) )
                throw new Exception( Localization.GXTIncorrectFXTFileName( fromFileName ) );
            files[ currentFile ].texts.Clear();
            foreach( var line in files[ fromFileName ].texts )
                files[ currentFile ].texts.Add( line.Key, line.Value );
            return this;
        }
        public string convert( string format, params object[] args ) { return files[ currentFile ].encoding.convert( string.Format( format, args ) ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Dictionary<string, string> Export() {
            var result = new Dictionary<string, string>();
            var stringBuilder = new StringBuilder();
            foreach( var file in files ) {
                var gxtFile = file.Value;
                if( file.Value.texts.Count == 0 )
                    continue;
                stringBuilder.Clear();
                foreach( var text in gxtFile.texts )
                    stringBuilder.AppendFormat( $"{text.Key} {gxtFile.encoding.convert( text.Value )}\r\n" );
                result.Add( file.Key, stringBuilder.ToString() );
            }
            return result;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new System.Type GetType() { return base.GetType(); }

    }

}