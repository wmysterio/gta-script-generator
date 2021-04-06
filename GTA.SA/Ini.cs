using GTA.Core;

namespace GTA {

    public static class Ini {

        public static void WriteInt( vString path, vString section, vString key, Int val ) { Script.ini_write_int( val, path, section, key ).write(); }
        public static void WriteFloat( vString path, vString section, vString key, Float val ) { Script.ini_write_float( val, path, section, key ).write(); }
        public static void WriteString( vString path, vString section, vString key, vString val ) { Script.ini_write_string( val, path, section, key ).write(); }
        public static void ReadInt( vString path, vString section, vString key, Out<Int> result ) { Script.ini_read_int( result, path, section, key ).write(); }
        public static void ReadFloat( vString path, vString section, vString key, Out<Float> result ) { Script.ini_read_float( result, path, section, key ).write(); }
        public static void ReadString( vString path, vString section, vString key, Out<vString> result ) { Script.ini_read_string( result, path, section, key ).write(); }

    }

}