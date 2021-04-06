using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GTA.Core.Languages;

namespace GTA.Core {

    public enum Language { RU, EN }

    public static class Generator {

        internal const string MESSAGE_EXTERNAL_SCRIPT_NOT_FOUND = @"//===== EXTERNAL SCRIPT NOT FOUND =====\\";
        internal const string MESSAGE_FUNCTION_NOT_FOUND = @"//===== FUNCTION NOT FOUND =====\\";
        internal const string MESSAGE_COMMENT_IGNORE_ELEMENTS = "SCRIPT IGNORE THIS:";

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Language Language { internal get; set; } = Language.EN;
        public static ushort DefaultWaitTime { internal get; set; } = 250;
        public static ushort UnknownThreadsMemory { internal get; set; } = 574;
        public static bool NotToCompileExternalScripts { internal get; set; } = false;
        public static bool OriginalDefineObjects { internal get; set; } = false;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal static bool tmpNotToCompileExternalScripts,
                             tmpUseAutomaticVariableInitialization,
                             tmpOriginalDefineObjects;

        // ---------------------------------------------------------------------------------------------------------------------------

        private static List<string> savedFXTFileNames = new List<string>();
        private static string tmpSBFolder = "", tmpSBExe = "", tmpMainFolder = "", tmpMainName = "", tmpFXTFolder = "";
        private static bool hasError = false, compilingMode = false, isLanguageExist = false;
        private static StringBuilder scriptStringBuilder = new StringBuilder();
        private static StringBuilder headerStringBuilder = new StringBuilder();

        // ---------------------------------------------------------------------------------------------------------------------------

        public static void SetSannyBuidlerFolder( string path, string exeName = "sanny" ) { tmpSBFolder = path; tmpSBExe = exeName; }
        public static void SetMainSCMFolder( string path, string mainSCMName = "main" ) { tmpMainFolder = path; tmpMainName = mainSCMName; }
        public static void SetFXTFolder( string path ) { tmpFXTFolder = path; }
        public static void Start<T>( bool openFile = true, string other = null ) where T : Script, new() {
            Console.Title = Debug.COMPILLER_NAME;
            Console.Clear();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo( "en-US" );
            tmpNotToCompileExternalScripts = NotToCompileExternalScripts;
            tmpOriginalDefineObjects = OriginalDefineObjects;
            tmpUseAutomaticVariableInitialization = true;
            if( !isLanguageExist ) {
                switch( Language ) {
                    case Language.RU:
                    new Locale_RU();
                    break;
                    case Language.EN:
                    new Locale_EN();
                    break;
                }
            }
            Localization.PrintStartGenerator();
            var finish_time = DateTime.Now;
            var start_time = DateTime.Now;
            try {
                SetupGlobalVariables();
                SetupLocalVariablesLimits( TypeOfScript.THREAD );
                Script.errors.Clear();
                Script.allScripts.Clear();
                T script = new T();
                if( script.ScriptType != TypeOfScript.THREAD )
                    throw new Exception( Localization.ThreadMAINNotFound() );
                if( script.ScriptName != "MAIN" )
                    throw new Exception( Localization.ThreadMAINNotFound() );
                Script.AddAndPrintScript( script );
                var threads = Script.allScripts.Where( t => t.Key.ScriptType == TypeOfScript.THREAD ).ToArray();
                var missions = Script.allScripts.Where( t => t.Key.ScriptType == TypeOfScript.MISSION ).ToArray();
                var externals = Script.allScripts.Where( t => t.Key.ScriptType == TypeOfScript.EXTERNAL ).ToArray();
                var scmFuncs = Script.allScripts.Where( t => t.Key.ScriptType == TypeOfScript.FUNCTION ).ToArray();
                for( int i = 0; i < threads.Length; i++ )
                    scriptStringBuilder.Append( threads[ i ].Key.BuilderString.ToString() );
                headerStringBuilder.AppendLine( $"\nDEFINE MISSIONS {Script.MissionCounter}" );
                headerStringBuilder.Append( Script.MissionHeader.ToString() );
                for( int i = 0; i < missions.Length; i++ )
                    scriptStringBuilder.Append( missions[ i ].Key.BuilderString.ToString() );
                if( Script.ExternalCounter > 0 )
                    tmpNotToCompileExternalScripts = false;
                headerStringBuilder.AppendLine( $"\nDEFINE EXTERNAL_SCRIPTS {( tmpNotToCompileExternalScripts ? -1 : Script.ExternalCounter )} // Use -1 in order not to compile AAA script" );
                headerStringBuilder.AppendLine( Script.ExternalHeader.ToString() );
                for( int i = 0; i < externals.Length; i++ )
                    scriptStringBuilder.Append( externals[ i ].Key.BuilderString.ToString() );
                headerStringBuilder.AppendLine( $"DEFINE UNKNOWN_EMPTY_SEGMENT 0\n\nDEFINE UNKNOWN_THREADS_MEMORY {UnknownThreadsMemory}" );
                var scriptText = scriptStringBuilder.ToString();
                if( externals.Length > 0 ) {
                    StringBuilder regExtScript = new StringBuilder();
                    for( int extr = 0; extr < externals.Length; extr++ )
                        regExtScript.AppendFormat( Opcodes._0914, extr ).Append( '\n' );
                    scriptText = scriptText.Replace( MESSAGE_EXTERNAL_SCRIPT_NOT_FOUND, regExtScript.ToString().TrimEnd() );
                }
                if( scmFuncs.Length > 0 ) {
                    StringBuilder regFunScript = new StringBuilder();
                    for( int i = 0; i < scmFuncs.Length; i++ )
                        regFunScript.Append( scmFuncs[ i ].Key.BuilderString.ToString() );
                    scriptText = scriptText.Replace( MESSAGE_FUNCTION_NOT_FOUND, regFunScript.ToString().TrimEnd() );
                }
                headerStringBuilder.Append( scriptText );
                saveFXT();
                Localization.PrintSaveScriptCode();
                var result = $"{getDefinedObjectText()}\r\n{headerStringBuilder.ToString()}";
                if( !compilingMode && other != "main.txt" )
                    other = "main.txt";
                System.IO.File.WriteAllText( other, result, System.Text.Encoding.ASCII );
                if( openFile && System.IO.File.Exists( other ) )
                    System.Diagnostics.Process.Start( other );
            } catch( Exception e ) {
                hasError = true;
                Debug.Error( e.Message );
                var frames = new System.Diagnostics.StackTrace( e, true ).GetFrames();
                foreach( var frame in frames ) {
                    if( frame.GetMethod().ReflectedType.Assembly == System.Reflection.Assembly.GetEntryAssembly() )
                        Localization.PrintThrowInfo( frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber() );
                }
                return;
            }
            finish_time = DateTime.Now;
            Localization.PrintGeneratorDone( ( finish_time - start_time ).TotalSeconds );
        }
        public static void Compile<T>( bool restartSannyBuilder = false ) where T : Script, new() {
            compilingMode = true;
            var fileErrorLog = "compile.log";
            var fileScriptIMG = "script.img";
            var fileMainTxt = $"{tmpMainName}.txt";
            var fileMainScm = $"{tmpMainName}.scm";
            var fileSannyExe = $"{tmpSBExe}.exe";
            var pathErrorLog = $@"{Application.StartupPath}\{fileErrorLog}";
            var pathScriptIMG = $@"{Application.StartupPath}\{fileScriptIMG}";
            var pathMainTxt = $@"{Application.StartupPath}\{fileMainTxt}";
            var pathMainScm = $@"{Application.StartupPath}\{fileMainScm}";
            var pathSanny = $@"{tmpSBFolder}\{fileSannyExe}";
            var pathFXT = $@"{tmpFXTFolder}";
            switch( Language ) {
                case Language.RU:
                new Locale_RU();
                break;
                case Language.EN:
                new Locale_EN();
                break;
            }
            isLanguageExist = true;
            try {
                if( System.IO.File.Exists( pathMainTxt ) ) {
                    System.IO.File.Delete( pathMainTxt );
                    Localization.PrintTempFileDeleted( fileMainTxt );
                }
                if( System.IO.File.Exists( pathErrorLog ) ) {
                    System.IO.File.Delete( pathErrorLog );
                    Localization.PrintTempFileDeleted( fileErrorLog );
                }
                if( System.IO.File.Exists( pathMainScm ) ) {
                    System.IO.File.Delete( pathMainScm );
                    Localization.PrintTempFileDeleted( fileMainScm );
                }
                if( System.IO.File.Exists( pathScriptIMG ) ) {
                    System.IO.File.Delete( pathScriptIMG );
                    Localization.PrintTempFileDeleted( fileScriptIMG );
                }
                if( !Directory.Exists( tmpMainFolder ) ) {
                    Localization.PrintFolderNotFound( tmpMainFolder );
                    return;
                }
            } catch( Exception e ) {
                Debug.Error( e.Message );
                return;
            }
            if( !System.IO.File.Exists( pathSanny ) ) {
                Localization.PrintFolderAndSANNYNotFound( fileSannyExe );
                return;
            }
            Start<T>( false, fileMainTxt );
            if( hasError )
                return;
            Console.WriteLine();
            Localization.PrintStartCompile();
            try {
                var mode = "sa";
                var compileParams = $"-m {mode} --no-splash -c \"{pathMainTxt}\" \"{pathMainScm}\"";
                Localization.PrintStartSannyBuilder();
                killAllSBProcesses( pathSanny );
                startSB( pathSanny, compileParams ).WaitForExit();
                if( System.IO.File.Exists( pathErrorLog ) ) {
                    killAllSBProcesses( pathSanny );
                    var text = $"{Localization.SannyCompileError( fileErrorLog )}\r\n";
                    text += System.IO.File.ReadAllText( pathErrorLog, System.Text.Encoding.Default );
                    throw new Exception( text );
                }
                killAllSBProcesses( pathSanny );
                if( !System.IO.File.Exists( pathMainScm ) )
                    throw new Exception( Localization.FileNotFound( pathMainScm ) );
                if( !System.IO.File.Exists( pathScriptIMG ) && !tmpNotToCompileExternalScripts )
                    throw new Exception( Localization.FileNotFound( pathScriptIMG ) );
                var out_scm = $"{tmpMainFolder}\\{fileMainScm}";
                moveFile( pathMainScm, out_scm );
                if( !tmpNotToCompileExternalScripts ) {
                    var out_img = $"{tmpMainFolder}\\{fileScriptIMG}";
                    try {
                        moveFile( pathScriptIMG, out_img );
                    } catch( Exception e ) { Localization.PrintScriptIMGNotReplaced(); }
                }
                if( Directory.Exists( pathFXT ) && savedFXTFileNames.Count > 0 ) {
                    foreach( var fileName in savedFXTFileNames ) {
                        var in_fxt = $@"{Application.StartupPath}\{fileName}";
                        var out_fxt = $@"{pathFXT}\{fileName}";
                        moveFile( in_fxt, out_fxt );
                    }
                }
                Localization.PrintCompilengDone();
                if( restartSannyBuilder )
                    startSB( pathSanny, $"-m {mode} --no-splash" );
            } catch( Exception e ) {
                Debug.Error( e.Message );
                return;
            }
            savedFXTFileNames.Clear();
            compilingMode = false;
            isLanguageExist = false;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal static void SetupGlobalVariables() {
            Script.OnMission = Script.global( 409 );
            Script.DefaultWaitTime = Script.global( 14 );
            Script.PlayerActor = Script.global( 3 );
            Script.PlayerChar = Script.global( 2 );
            Script.PlayerGroup = Script.global( 11 );
        }
        internal static void SetupLocalVariablesLimits( TypeOfScript scriptType ) { LocalVariable.LIMIT = ( ushort ) ( scriptType == TypeOfScript.MISSION ? 1024 : 32 ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        private static void moveFile( string inputPath, string targetPath ) {
            var bytes = System.IO.File.ReadAllBytes( inputPath );
            System.IO.File.WriteAllBytes( targetPath, bytes );
        }
        private static void saveFXT() {
            var files = GXT.instance.Export();
            if( files.Count == 0 )
                return;
            Localization.PrintSaveFXT();
            foreach( var file in files ) {
                var fileName = $"{file.Key}.fxt";
                System.IO.File.WriteAllText( fileName, file.Value, System.Text.Encoding.Default );
                savedFXTFileNames.Add( fileName );
            }
        }
        private static System.Diagnostics.Process startSB( string pathToSB, string compileParams ) {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.CreateNoWindow = false;
            proc.StartInfo.FileName = pathToSB;
            proc.StartInfo.Arguments = compileParams;
            proc.Start();
            return proc;
        }
        private static void killAllSBProcesses( string pathToSB ) {
            var processes = System.Diagnostics.Process.GetProcessesByName( tmpSBExe );
            for( int i = processes.Length - 1; i >= 0; i-- ) {
                if( processes[ i ].MainModule.FileName == pathToSB )
                    processes[ i ].Kill();
            }
        }
        private static string getDefinedObjectText() {
            if( tmpOriginalDefineObjects ) {
                return @"DEFINE OBJECTS 389
DEFINE OBJECT (noname)                
DEFINE OBJECT INFO                     // Object number -1
DEFINE OBJECT KEYCARD                  // Object number -2
DEFINE OBJECT AD_FLATDOOR              // Object number -3
DEFINE OBJECT KB_BANDIT_U              // Object number -4
DEFINE OBJECT ROULETTE_TBL             // Object number -5
DEFINE OBJECT OTB_MACHINE              // Object number -6
DEFINE OBJECT CJ_COIN_OP_3             // Object number -7
DEFINE OBJECT CJ_COIN_OP_2             // Object number -8
DEFINE OBJECT CJ_COIN_OP_1             // Object number -9
DEFINE OBJECT CJ_COIN_OP               // Object number -10
DEFINE OBJECT SWANK_CONSOLE            // Object number -11
DEFINE OBJECT SNESISH                  // Object number -12
DEFINE OBJECT LOW_CONSOLE              // Object number -13
DEFINE OBJECT VENDMACHFD               // Object number -14
DEFINE OBJECT VENDMACH                 // Object number -15
DEFINE OBJECT VENDIN3                  // Object number -16
DEFINE OBJECT CJ_SPRUNK1               // Object number -17
DEFINE OBJECT CJ_CANDYVENDOR           // Object number -18
DEFINE OBJECT CJ_EXT_CANDY             // Object number -19
DEFINE OBJECT CJ_EXT_SPRUNK            // Object number -20
DEFINE OBJECT ICESCART_PROP            // Object number -21
DEFINE OBJECT CHILLIDOGCART            // Object number -22
DEFINE OBJECT NOODLECART_PROP          // Object number -23
DEFINE OBJECT GATE_AUTOL               // Object number -24
DEFINE OBJECT GATE_AUTOR               // Object number -25
DEFINE OBJECT GYM_BIKE                 // Object number -26
DEFINE OBJECT GYM_BENCH1               // Object number -27
DEFINE OBJECT GYM_TREADMILL            // Object number -28
DEFINE OBJECT GYM_MAT1                 // Object number -29
DEFINE OBJECT BSKBALL_LAX              // Object number -30
DEFINE OBJECT BSKBALLHUB_LAX01         // Object number -31
DEFINE OBJECT VGSXREFBBALLNET          // Object number -32
DEFINE OBJECT VGSXREFBBALLNET2         // Object number -33
DEFINE OBJECT K_POOLTABLESM            // Object number -34
DEFINE OBJECT NEIL_SLOT                // Object number -35
DEFINE OBJECT CJ_SLOT_BANK             // Object number -36
DEFINE OBJECT BLCK_JACK                // Object number -37
DEFINE OBJECT WHEEL_O_FORTUNE          // Object number -38
DEFINE OBJECT CRACKFACT_SFS            // Object number -39
DEFINE OBJECT CF_EXT_DEM_SFS           // Object number -40
DEFINE OBJECT LODCRACKFACT_SFS         // Object number -41
DEFINE OBJECT LODEXT_DEM_SFS           // Object number -42
DEFINE OBJECT PICKUPSAVE               // Object number -43
DEFINE OBJECT WOODENBOX                // Object number -44
DEFINE OBJECT NF_BLACKBOARD            // Object number -45
DEFINE OBJECT NF_LIST_1                // Object number -46
DEFINE OBJECT NF_LIST_2                // Object number -47
DEFINE OBJECT NF_LIST_3                // Object number -48
DEFINE OBJECT WANTED_CROSS_OFF         // Object number -49
DEFINE OBJECT WS_APGATE                // Object number -50
DEFINE OBJECT GEN_DOOREXT03            // Object number -51
DEFINE OBJECT GEN_DOOREXT07            // Object number -52
DEFINE OBJECT GEN_DOORSHOP02           // Object number -53
DEFINE OBJECT GEN_DOOREXT04            // Object number -54
DEFINE OBJECT GEN_DOORSHOP3            // Object number -55
DEFINE OBJECT CUNTGIRLDOOR             // Object number -56
DEFINE OBJECT PIZZAHIGH                // Object number -57
DEFINE OBJECT CJ_PIZZA_1               // Object number -58
DEFINE OBJECT CJ_PIZZA_2               // Object number -59
DEFINE OBJECT BURGERHIGH               // Object number -60
DEFINE OBJECT CJ_BURG_1                // Object number -61
DEFINE OBJECT CJ_BURG_2                // Object number -62
DEFINE OBJECT CIGAR                    // Object number -63
DEFINE OBJECT TRDCSGRGDOOR_LVS         // Object number -64
DEFINE OBJECT MD_POSTER                // Object number -65
DEFINE OBJECT CR_DOOR_01               // Object number -66
DEFINE OBJECT CR_DOOR_03               // Object number -67
DEFINE OBJECT SHUTTER_VEGAS            // Object number -68
DEFINE OBJECT CR1_DOOR                 // Object number -69
DEFINE OBJECT CT_GATEXR                // Object number -70
DEFINE OBJECT A51_BLASTDOORR           // Object number -71
DEFINE OBJECT A51_BLASTDOORL           // Object number -72
DEFINE OBJECT A51_LABDOOR              // Object number -73
DEFINE OBJECT A51_JETDOOR              // Object number -74
DEFINE OBJECT PORTAKABIN               // Object number -75
DEFINE OBJECT FREIGHT_SFW_DOOR         // Object number -76
DEFINE OBJECT AB_CASDORLOK             // Object number -77
DEFINE OBJECT IMY_SHASH_WALL           // Object number -78
DEFINE OBJECT TWRCRANE_M_04            // Object number -79
DEFINE OBJECT TWRCRANE_M_01            // Object number -80
DEFINE OBJECT TWRCRANE_M_02            // Object number -81
DEFINE OBJECT LODCRANE_M_04            // Object number -82
DEFINE OBJECT LODCRANE_M_01            // Object number -83
DEFINE OBJECT MAGNOCRANE_01            // Object number -84
DEFINE OBJECT MAGNOCRANE_02            // Object number -85
DEFINE OBJECT MAGNOCRANE_03            // Object number -86
DEFINE OBJECT LODNOCRANE_01            // Object number -87
DEFINE OBJECT LODNOCRANE_02            // Object number -88
DEFINE OBJECT LODNOCRANE_03            // Object number -89
DEFINE OBJECT QUARRY_CRANEBASE         // Object number -90
DEFINE OBJECT QUARRY_CRANE             // Object number -91
DEFINE OBJECT QUARRY_CRANEARM          // Object number -92
DEFINE OBJECT BODYARMOUR               // Object number -93
DEFINE OBJECT BRIBE                    // Object number -94
DEFINE OBJECT A51_VENTCOVERB           // Object number -95
DEFINE OBJECT CARRIER_DOOR_SFSE        // Object number -96
DEFINE OBJECT CARRIER_LIFT2_SFSE       // Object number -97
DEFINE OBJECT CARRIER_LIFT1_SFSE       // Object number -98
DEFINE OBJECT GWFORUM1_LAE             // Object number -99
DEFINE OBJECT GANGSHOPS4_LAE2          // Object number -100
DEFINE OBJECT CE_HILLSEAST06           // Object number -101
DEFINE OBJECT CUNTEGROUND23            // Object number -102
DEFINE OBJECT HILLSEAST05_LAE          // Object number -103
DEFINE OBJECT K_POOLQ                  // Object number -104
DEFINE OBJECT K_POOLBALLCUE            // Object number -105
DEFINE OBJECT K_POOLBALLSPT01          // Object number -106
DEFINE OBJECT K_POOLBALLSPT02          // Object number -107
DEFINE OBJECT K_POOLBALLSPT03          // Object number -108
DEFINE OBJECT K_POOLBALLSPT04          // Object number -109
DEFINE OBJECT K_POOLBALLSPT05          // Object number -110
DEFINE OBJECT K_POOLBALLSPT06          // Object number -111
DEFINE OBJECT K_POOLBALLSPT07          // Object number -112
DEFINE OBJECT K_POOLBALL8              // Object number -113
DEFINE OBJECT K_POOLBALLSTP01          // Object number -114
DEFINE OBJECT K_POOLBALLSTP02          // Object number -115
DEFINE OBJECT K_POOLBALLSTP03          // Object number -116
DEFINE OBJECT K_POOLBALLSTP04          // Object number -117
DEFINE OBJECT K_POOLBALLSTP05          // Object number -118
DEFINE OBJECT K_POOLBALLSTP06          // Object number -119
DEFINE OBJECT K_POOLBALLSTP07          // Object number -120
DEFINE OBJECT K_POOLQ2                 // Object number -121
DEFINE OBJECT CIGAR_GLOW               // Object number -122
DEFINE OBJECT DYN_WINE_BIG             // Object number -123
DEFINE OBJECT KB_BEER                  // Object number -124
DEFINE OBJECT LAEROAD30                // Object number -125
DEFINE OBJECT CASKET_LAW               // Object number -126
DEFINE OBJECT LAEJEFFERSALPHA          // Object number -127
DEFINE OBJECT LAELODPARK02             // Object number -128
DEFINE OBJECT LAEMACPARK02             // Object number -129
DEFINE OBJECT BD_WINDOW                // Object number -130
DEFINE OBJECT BREAK_WALL_1B            // Object number -131
DEFINE OBJECT BREAK_WALL_2B            // Object number -132
DEFINE OBJECT BREAK_WALL_3B            // Object number -133
DEFINE OBJECT BD_FIRE1_O               // Object number -134
DEFINE OBJECT CR_AMMOBOX               // Object number -135
DEFINE OBJECT BREAK_WALL_1A            // Object number -136
DEFINE OBJECT BREAK_WALL_2A            // Object number -137
DEFINE OBJECT BREAK_WALL_3A            // Object number -138
DEFINE OBJECT BD_WINDOW_SHATTER        // Object number -139
DEFINE OBJECT SEC_KEYPAD               // Object number -140
DEFINE OBJECT KMB_RAMP                 // Object number -141
DEFINE OBJECT IMCMPTRKDRL_LAS          // Object number -142
DEFINE OBJECT IMCMPTRKDRR_LAS          // Object number -143
DEFINE OBJECT IMCOMPMOVEDR1_LAS        // Object number -144
DEFINE OBJECT BARREL4                  // Object number -145
DEFINE OBJECT HEALTH                   // Object number -146
DEFINE OBJECT IMY_BBOX                 // Object number -147
DEFINE OBJECT IMY_LA_DOOR              // Object number -148
DEFINE OBJECT DB_AMMO                  // Object number -149
DEFINE OBJECT MED_BED_8                // Object number -150
DEFINE OBJECT CR_GUNCRATE              // Object number -151
DEFINE OBJECT GUNBOX                   // Object number -152
DEFINE OBJECT TMP_BIN                  // Object number -153
DEFINE OBJECT AMMOTRN_OBJ              // Object number -154
DEFINE OBJECT KMB_FRONTGATE            // Object number -155
DEFINE OBJECT WAREHOUSE_DOOR2B         // Object number -156
DEFINE OBJECT WAREHOUSE_DOOR1          // Object number -157
DEFINE OBJECT CJ_CARDBRD_PICKUP        // Object number -158
DEFINE OBJECT NF_PED_COLL              // Object number -159
DEFINE OBJECT CM_BOX                   // Object number -160
DEFINE OBJECT FAKE_MULE_COL            // Object number -161
DEFINE OBJECT CARDBOARDBOX2            // Object number -162
DEFINE OBJECT LAE_SMOKECUTSCENE        // Object number -163
DEFINE OBJECT IMMMCRAN                 // Object number -164
DEFINE OBJECT TRNTRK8_LAS              // Object number -165
DEFINE OBJECT IMY_TRACK_BARRIER        // Object number -166
DEFINE OBJECT KMB_SKIP                 // Object number -167
DEFINE OBJECT STORM_DRAIN_COVER        // Object number -168
DEFINE OBJECT WHEEL_OR1                // Object number -169
DEFINE OBJECT DYN_WOODPILE2            // Object number -170
DEFINE OBJECT KMB_RHYMESBOOK           // Object number -171
DEFINE OBJECT CJ_JUICE_CAN             // Object number -172
DEFINE OBJECT DYN_ROADBARRIER_2        // Object number -173
DEFINE OBJECT KMB_GOFLAG               // Object number -174
DEFINE OBJECT IMY_SKYLIGHT             // Object number -175
DEFINE OBJECT KMB_TROLLEY              // Object number -176
DEFINE OBJECT LXR_MOTEL_DOORSIM        // Object number -177
DEFINE OBJECT LXR_MOTELVENT            // Object number -178
DEFINE OBJECT DYN_SCAFFOLD_4B          // Object number -179
DEFINE OBJECT MUNCH_DONUT              // Object number -180
DEFINE OBJECT CHOPCOP_ARMR             // Object number -181
DEFINE OBJECT CHOPCOP_LEGR             // Object number -182
DEFINE OBJECT CHOPCOP_HEAD             // Object number -183
DEFINE OBJECT CHOPCOP_TORSO            // Object number -184
DEFINE OBJECT WD_FENCE_ANIM            // Object number -185
DEFINE OBJECT CHOPCOP_ARML             // Object number -186
DEFINE OBJECT CHOPCOP_LEGL             // Object number -187
DEFINE OBJECT DYN_SCAFFOLD_3B          // Object number -188
DEFINE OBJECT ROADWORKBARRIER1         // Object number -189
DEFINE OBJECT BRIEFCASE                // Object number -190
DEFINE OBJECT KMB_ATM1                 // Object number -191
DEFINE OBJECT KMB_ATM2                 // Object number -192
DEFINE OBJECT KMB_ATM3                 // Object number -193
DEFINE OBJECT MTSAFE                   // Object number -194
DEFINE OBJECT CAT2_SAFE_COL            // Object number -195
DEFINE OBJECT MAN_SAFENEW              // Object number -196
DEFINE OBJECT KEV_SAFE                 // Object number -197
DEFINE OBJECT RIDER1_DOOR              // Object number -198
DEFINE OBJECT KMB_MARIJUANA            // Object number -199
DEFINE OBJECT SW_HAYBREAK02            // Object number -200
DEFINE OBJECT GRASSPLANT               // Object number -201
DEFINE OBJECT PARKBENCH1               // Object number -202
DEFINE OBJECT PORTALOO                 // Object number -203
DEFINE OBJECT HUBHOLE1_SFSE            // Object number -204
DEFINE OBJECT HUBHOLE2_SFSE            // Object number -205
DEFINE OBJECT HUBHOLE3_SFSE            // Object number -206
DEFINE OBJECT HUBHOLE4_SFSE            // Object number -207
DEFINE OBJECT CLOTHESP                 // Object number -208
DEFINE OBJECT LAMPPOST3                // Object number -209
DEFINE OBJECT CT_STALL1                // Object number -210
DEFINE OBJECT CT_TABLE                 // Object number -211
DEFINE OBJECT CHINATGARAGEDOOR         // Object number -212
DEFINE OBJECT CHINA_TOWN_GATEB         // Object number -213
DEFINE OBJECT A51_SPOTBASE             // Object number -214
DEFINE OBJECT A51_SPOTHOUSING          // Object number -215
DEFINE OBJECT A51_SPOTBULB             // Object number -216
DEFINE OBJECT KMB_CONTAINER_RED        // Object number -217
DEFINE OBJECT CJ_CHRIS_CRATE           // Object number -218
DEFINE OBJECT CJ_CHRIS_CRATE_LD        // Object number -219
DEFINE OBJECT CJ_CHRIS_CRATE_RD        // Object number -220
DEFINE OBJECT CJ_PADLOCK               // Object number -221
DEFINE OBJECT KATANA_ANIM              // Object number -222
DEFINE OBJECT KATANA_LHAND             // Object number -223
DEFINE OBJECT MOBILE1993B              // Object number -224
DEFINE OBJECT WONGS_GATE               // Object number -225
DEFINE OBJECT DYN_RAMP                 // Object number -226
DEFINE OBJECT SNIPER_ANIM              // Object number -227
DEFINE OBJECT KMB_PACKET               // Object number -228
DEFINE OBJECT NTO_B_S                  // Object number -229
DEFINE OBJECT CARDBOARDBOX             // Object number -230
DEFINE OBJECT DYN_ROADBARRIER_3        // Object number -231
DEFINE OBJECT DYN_ROADBARRIER_4        // Object number -232
DEFINE OBJECT DYN_DUMPSTER             // Object number -233
DEFINE OBJECT KMB_CONTAINER_BLUE       // Object number -234
DEFINE OBJECT KMB_CONTAINER_YEL        // Object number -235
DEFINE OBJECT KMB_CONTAINER_OPEN       // Object number -236
DEFINE OBJECT TEMP_STINGER2            // Object number -237
DEFINE OBJECT TRAFFICCONE              // Object number -238
DEFINE OBJECT AD_JUMP                  // Object number -239
DEFINE OBJECT GARYS_LUV_RAMP           // Object number -240
DEFINE OBJECT AD_ROADMARK1             // Object number -241
DEFINE OBJECT AD_ROADMARK2             // Object number -242
DEFINE OBJECT AD_FINISH                // Object number -243
DEFINE OBJECT MINIGUN_BASE             // Object number -244
DEFINE OBJECT WONGS_ERECTION           // Object number -245
DEFINE OBJECT WONGS_ERECTION2          // Object number -246
DEFINE OBJECT RCBOMB                   // Object number -247
DEFINE OBJECT BARREL2                  // Object number -248
DEFINE OBJECT MINI_MAGNET              // Object number -249
DEFINE OBJECT KMB_PLANK                // Object number -250
DEFINE OBJECT KMB_HOLDALL              // Object number -251
DEFINE OBJECT KMB_PARACHUTE            // Object number -252
DEFINE OBJECT AMMO_CAPSULE             // Object number -253
DEFINE OBJECT BARREL1                  // Object number -254
DEFINE OBJECT KB_BARREL                // Object number -255
DEFINE OBJECT CR_CRATESTACK            // Object number -256
DEFINE OBJECT D9_RUNWAY                // Object number -257
DEFINE OBJECT CARGO_TEST               // Object number -258
DEFINE OBJECT CARGO_STUFF              // Object number -259
DEFINE OBJECT CARGO_STORE              // Object number -260
DEFINE OBJECT KMILITARY_CRATE          // Object number -261
DEFINE OBJECT KMILITARY_BASE           // Object number -262
DEFINE OBJECT BLOCKPALLET              // Object number -263
DEFINE OBJECT TEMP_CRATE1              // Object number -264
DEFINE OBJECT K_SMASHBOXES             // Object number -265
DEFINE OBJECT K_CARGO1                 // Object number -266
DEFINE OBJECT K_CARGO4                 // Object number -267
DEFINE OBJECT GREEN_GLOOP              // Object number -268
DEFINE OBJECT BASEJUMP_TARGET          // Object number -269
DEFINE OBJECT DES_QUARRYGATE2          // Object number -270
DEFINE OBJECT DES_QUARRYGATE           // Object number -271
DEFINE OBJECT CJ_DYN_PLUNGE_1          // Object number -272
DEFINE OBJECT DYNAMITE                 // Object number -273
DEFINE OBJECT DYNO_BOX_A               // Object number -274
DEFINE OBJECT DYNO_BOX_B               // Object number -275
DEFINE OBJECT PRIVATESIGN3             // Object number -276
DEFINE OBJECT PRIVATESIGN1             // Object number -277
DEFINE OBJECT BARRIER_4ANDY            // Object number -278
DEFINE OBJECT CJ_CHIP_MAKER_BITS       // Object number -279
DEFINE OBJECT CJ_CHIP_MAKER            // Object number -280
DEFINE OBJECT CJ_WHEELCHAIR1           // Object number -281
DEFINE OBJECT AB_CARCASS               // Object number -282
DEFINE OBJECT AB_HOOK                  // Object number -283
DEFINE OBJECT FREEZER_DOOR             // Object number -284
DEFINE OBJECT CJ_MEAT_BAG_1            // Object number -285
DEFINE OBJECT CJ_MEAT_1                // Object number -286
DEFINE OBJECT CJ_MEAT_2                // Object number -287
DEFINE OBJECT JET_BAGGAGE_DOOR         // Object number -288
DEFINE OBJECT JET_INTERIOR             // Object number -289
DEFINE OBJECT SMLPLANE_DOOR            // Object number -290
DEFINE OBJECT JET_DOOR                 // Object number -291
DEFINE OBJECT SMASH_BOX_STAY           // Object number -292
DEFINE OBJECT SMASH_BOX_BRK            // Object number -293
DEFINE OBJECT SMASHBOXPILE             // Object number -294
DEFINE OBJECT ST_ARCH_PLAN             // Object number -295
DEFINE OBJECT GEN_DOORINT01            // Object number -296
DEFINE OBJECT KMB_LOCKEDDOOR           // Object number -297
DEFINE OBJECT DYN_AIRCON               // Object number -298
DEFINE OBJECT SW_BIT_09                // Object number -299
DEFINE OBJECT GENERATOR_BIG            // Object number -300
DEFINE OBJECT AB_VAULTDOOR             // Object number -301
DEFINE OBJECT GENERATOR_BIG_D          // Object number -302
DEFINE OBJECT CJ_MONEY_BAG             // Object number -303
DEFINE OBJECT PARA_PACK                // Object number -304
DEFINE OBJECT CARGO_REAR               // Object number -305
DEFINE OBJECT D9_RAMP                  // Object number -306
DEFINE OBJECT PARACHUTE                // Object number -307
DEFINE OBJECT OPMANS01_CUNTE           // Object number -308
DEFINE OBJECT CEHOLLYHIL06             // Object number -309
DEFINE OBJECT SUNSET22_LAWN            // Object number -310
DEFINE OBJECT DRG_NU_EXT               // Object number -311
DEFINE OBJECT MISSILE_07_SFXR          // Object number -312
DEFINE OBJECT KMB_KEYPAD               // Object number -313
DEFINE OBJECT WATERJUMPX2              // Object number -314
DEFINE OBJECT BBALL_INGAME             // Object number -315
DEFINE OBJECT CJ_WIN_POP2              // Object number -316
DEFINE OBJECT LA_FUCKCAR1              // Object number -317
DEFINE OBJECT LA_FUCKCAR2              // Object number -318
DEFINE OBJECT TARGET_FRAME             // Object number -319
DEFINE OBJECT TARGET_LLEG              // Object number -320
DEFINE OBJECT TARGET_RLEG              // Object number -321
DEFINE OBJECT TARGET_LTORSO            // Object number -322
DEFINE OBJECT TARGET_RTORSO            // Object number -323
DEFINE OBJECT TARGET_LARM              // Object number -324
DEFINE OBJECT TARGET_RARM              // Object number -325
DEFINE OBJECT TARGET_HEAD              // Object number -326
DEFINE OBJECT DEAD_TIED_COP            // Object number -327
DEFINE OBJECT DYN_QUARRYROCK03         // Object number -328
DEFINE OBJECT BLACKBAG2                // Object number -329
DEFINE OBJECT DYN_WOODPILE             // Object number -330
DEFINE OBJECT DYN_QUARRYROCK02         // Object number -331
DEFINE OBJECT BOUY                     // Object number -332
DEFINE OBJECT WATERJUMP1               // Object number -333
DEFINE OBJECT LANDJUMP2                // Object number -334
DEFINE OBJECT BB_PICKUP                // Object number -335
DEFINE OBJECT PARA_COLLISION           // Object number -336
DEFINE OBJECT CJ_WHEEL_1               // Object number -337
DEFINE OBJECT CJ_WHEEL_02              // Object number -338
DEFINE OBJECT CJ_WHEEL_03              // Object number -339
DEFINE OBJECT CHIP_STACK07             // Object number -340
DEFINE OBJECT CHIP_STACK08             // Object number -341
DEFINE OBJECT CHIP_STACK12             // Object number -342
DEFINE OBJECT CHIP_STACK09             // Object number -343
DEFINE OBJECT CHIP_STACK11             // Object number -344
DEFINE OBJECT WHEEL_WEE                // Object number -345
DEFINE OBJECT ROULETTE_MARKER          // Object number -346
DEFINE OBJECT PEDALS                   // Object number -347
DEFINE OBJECT BEACHTOWEL01             // Object number -348
DEFINE OBJECT KMB_BPRESS               // Object number -349
DEFINE OBJECT BEACHTOWEL03             // Object number -350
DEFINE OBJECT BEACHTOWEL04             // Object number -351
DEFINE OBJECT KMB_DUMBBELL_R           // Object number -352
DEFINE OBJECT KMB_DUMBBELL_L           // Object number -353
DEFINE OBJECT BBALL_COL                // Object number -354
DEFINE OBJECT KMB_ROCK                 // Object number -355
DEFINE OBJECT CHIP_STACK10             // Object number -356
DEFINE OBJECT CHIP_STACK13             // Object number -357
DEFINE OBJECT CHIP_STACK14             // Object number -358
DEFINE OBJECT WHEEL_SUPPORT            // Object number -359
DEFINE OBJECT WHEEL_TABLE              // Object number -360
DEFINE OBJECT CLICKER                  // Object number -361
DEFINE OBJECT MONEY                    // Object number -362
DEFINE OBJECT CJ_FF_TILL_QUE           // Object number -363
DEFINE OBJECT CJ_BURG_CHAIR            // Object number -364
DEFINE OBJECT CJ_PIZZA_CHAIR           // Object number -365
DEFINE OBJECT CJ_PIZZA_CHAIR2          // Object number -366
DEFINE OBJECT CJ_PIZZA_CHAIR3          // Object number -367
DEFINE OBJECT TATTOO_KIT               // Object number -368
DEFINE OBJECT CJ_BARSTOOL              // Object number -369
DEFINE OBJECT CJ_BINCO_DOOR            // Object number -370
DEFINE OBJECT CJ_SUBURB_DOOR_2         // Object number -371
DEFINE OBJECT CJ_PRO_DOOR_01           // Object number -372
DEFINE OBJECT CJ_GAP_DOOR_             // Object number -373
DEFINE OBJECT CJ_VICTIM_DOOR           // Object number -374
DEFINE OBJECT CJ_DS_DOOR               // Object number -375
DEFINE OBJECT PIZZALOW                 // Object number -376
DEFINE OBJECT PIZZAMED                 // Object number -377
DEFINE OBJECT PIZZA_HEALTHY            // Object number -378
DEFINE OBJECT CLUCKLOW                 // Object number -379
DEFINE OBJECT CLUCKMED                 // Object number -380
DEFINE OBJECT CLUCKHIGH                // Object number -381
DEFINE OBJECT CLUCK_HEALTHY            // Object number -382
DEFINE OBJECT BURGERLOW                // Object number -383
DEFINE OBJECT BURGERMED                // Object number -384
DEFINE OBJECT BURGER_HEALTHY           // Object number -385
DEFINE OBJECT POLICE_BARRIER           // Object number -386
DEFINE OBJECT KMB_SHUTTER              // Object number -387
DEFINE OBJECT SFCOPDR                  // Object number -388";
            }
            return "DEFINE OBJECTS 0";
        }

    }

}