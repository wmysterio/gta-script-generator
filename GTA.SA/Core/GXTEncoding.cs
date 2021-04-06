using System;
using GTA.Core.Languages;

namespace GTA.Core {

    public sealed class GXTEncoding {

        public static readonly GXTEncoding None = new GXTEncoding();
        public static readonly GXTEncoding RU_SmartLoc = new GXTEncoding(
            new char[] { 'А', 'а', 'Б', 'б', 'В', 'в', 'Г', 'г', 'Д', 'д', 'Е', 'е', 'Ё', 'ё', 'Ж', 'ж', 'З', 'з', 'И', 'и', 'Й', 'й', 'К', 'к', 'Л', 'л', 'М', 'м', 'Н', 'н', 'О', 'о', 'П', 'п', 'Р', 'р', 'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц', 'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ', 'Ъ', 'ъ', 'Ы', 'ы', 'Ь', 'ь', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' },
            new char[] { 'A', 'a', 'Ђ', '—', '‹', 'ў', '‚', '™', 'ѓ', 'љ', 'E', 'e', 'E', 'e', '„', '›', '€', 'џ', '…', 'њ', '†', 'ќ', 'K', 'k', '‡', 'ћ', '–', 'Ї', '­', '®', 'O', 'o', 'Њ', 'Ј', 'P', 'p', 'C', 'c', 'Џ', '¦', 'Y', 'y', 'Ѓ', '', 'X', 'x', '‰', ' ', 'Ќ', '¤', 'Ћ', 'Ґ', 'Љ', 'Ў', 'ђ', '§', '‘', 'Ё', '’', '©', '“', 'Є', '”', '«', '•', '¬' }
        );
        public static readonly GXTEncoding RU_Fargus = new GXTEncoding(
            new char[] { 'А', 'а', 'Б', 'б', 'В', 'в', 'Г', 'г', 'Д', 'д', 'Е', 'е', 'Ё', 'ё', 'Ж', 'ж', 'З', 'з', 'И', 'и', 'Й', 'й', 'К', 'к', 'Л', 'л', 'М', 'м', 'Н', 'н', 'О', 'о', 'П', 'п', 'Р', 'р', 'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц', 'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ', 'Ъ', 'ъ', 'Ы', 'ы', 'Ь', 'ь', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' },
            new char[] { 'A', 'A', '…', '…', 'Џ', 'Џ', '†', '†', 'Ђ', 'Ђ', 'E', 'E', '‰', '‰', '„', '„', '‡', '‡', 'Ѓ', 'Ѓ', 'Љ', 'Љ', 'K', 'K', '‚', '‚', 'Ќ', 'Ќ', '‹', '‹', 'O', 'O', '’', '’', 'P', 'P', 'C', 'C', 'T', 'T', '“', '“', 'Ћ', 'Ћ', 'X', 'X', '”', '”', '–', '–', 'ђ', 'ђ', 'ђ', 'ђ', 'b', 'I', 'b', 'I', '€', '€', '“', '“', '‘', '‘', '•', '•' }, true
        );
        public static readonly GXTEncoding RU_BadMan = new GXTEncoding(
            new char[] { 'А', 'а', 'Б', 'б', 'В', 'в', 'Г', 'г', 'Д', 'д', 'Е', 'е', 'Ё', 'ё', 'Ж', 'ж', 'З', 'з', 'И', 'и', 'Й', 'й', 'К', 'к', 'Л', 'л', 'М', 'м', 'Н', 'н', 'О', 'о', 'П', 'п', 'Р', 'р', 'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц', 'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ', 'Ъ', 'ъ', 'Ы', 'ы', 'Ь', 'ь', 'Э', 'э', 'Ю', 'ю', 'Я', 'я' },
            new char[] { 'A', 'A', '6', '6', 'B', 'B', 'F', 'F', 'D', 'D', 'E', 'E', 'E', 'E', 'G', 'G', '3', '3', 'N', 'N', 'N', 'N', 'K', 'K', 'L', 'L', 'M', 'M', 'H', 'H', 'O', 'O', 'Z', 'Z', 'P', 'P', 'C', 'C', 'T', 'T', 'Y', 'Y', 'V', 'V', 'X', 'X', 'Q', 'Q', '4', '4', 'W', 'W', 'W', 'W', 'J', 'J', 'S', 'S', 'J', 'J', '3', '3', 'U', 'U', 'R', 'R' }, true
        );

        // ---------------------------------------------------------------------------------------------------------------------------

        internal bool hasEncoding, hasUppercase;
        internal char[,] charList;

        // ---------------------------------------------------------------------------------------------------------------------------

        private GXTEncoding() { hasEncoding = false; hasUppercase = false; }
        public GXTEncoding( char[] origin, char[] symbols, bool upperCase = false ) {
            if( origin == null || symbols == null )
                throw new Exception( Localization.GXTEncodingNotChars( nameof( GXTEncoding ) ) );
            if( origin.Length == 0 || symbols.Length == 0 )
                throw new Exception( Localization.GXTEncodingNotChars( nameof( GXTEncoding ) ) );
            if( origin.Length != symbols.Length )
                throw new Exception( Localization.GXTEncodingNonEqualsLength( nameof( GXTEncoding ) ) );
            charList = new char[ 2, origin.Length ];
            for( int i = 0; i < origin.Length; i++ ) {
                charList[ 0, i ] = origin[ i ];
                charList[ 1, i ] = symbols[ i ];
            }
            hasEncoding = true;
            hasUppercase = upperCase;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal string convert( string val ) {
            if( hasEncoding ) {
                for( int i = 0; i < charList.GetLength( 1 ); i++ ) {
                    if( hasUppercase )
                        val = val.ToUpper();
                    val = val.Replace( charList[ 0, i ], charList[ 1, i ] );
                }
            }
            return val;
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