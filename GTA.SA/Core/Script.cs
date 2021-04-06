using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using GTA.Core.Languages;
using System.Reflection;

namespace GTA.Core {

    public abstract class Script {

        internal static List<string> errors = new List<string>();

        #region SPECIAL COMMANDS
        public static string Comment {
            set {
                AppendLine( $"// {value.Replace( "/", "" ).Replace( "*", "" ).Replace( "\r", "" ).Replace( "\t", "" ).Replace( "\n", "" )}" );
            }
        }
        public static Action Ignore {
            set {
                AppendLine( $"/* {Generator.MESSAGE_COMMENT_IGNORE_ELEMENTS} " );
                if( value != null )
                    value.Invoke();
                AppendLine( "*/" );
            }
        }
        public static LocalVariable local() { return new LocalVariable(); }
        public static LocalVariable local( ushort index ) { return new LocalVariable( index ); }
        public static GlobalVariable global() { return new GlobalVariable(); }
        public static GlobalVariable global( ushort index ) { return new GlobalVariable( index ); }
        public static LocalArray local_array( ushort count ) { return new LocalArray( count ); }
        public static LocalArray local_array( ushort startIndex, ushort count ) { return new LocalArray( startIndex, count ); }
        public static GlobalArray global_array( ushort count ) { return new GlobalArray( count ); }
        public static GlobalArray global_array( ushort startIndex, ushort count ) { return new GlobalArray( startIndex, count ); }
        public static void unsafe_code( string code, params object[] args ) {
            if( string.IsNullOrEmpty( code ) )
                return;
            AppendLine( code, args );
        }
        #endregion

        #region VARIABLES
        public static Int OnMission { get; internal set; }
        public static Int DefaultWaitTime { get; internal set; }
        public static Actor PlayerActor { get; internal set; }
        public static Player PlayerChar { get; internal set; }
        public static Group PlayerGroup { get; internal set; }

        public Int LocalTimer1 { get; internal set; }
        public Int LocalTimer2 { get; internal set; }
        #endregion

        #region PSEUDO SINGLETONS
        public static CarParkGenerator CAR_PARK { get { return CarParkGenerator.instance; } }
        public static GXT FXT { get { return GXT.instance; } }
        public static Drawing DRAW { get { return Drawing.instance; } }
        public static Camera CAMERA { get { return Camera.instance; } }
        #endregion

        #region CONSTANTS
        public const int NULL = 0;
        #endregion

        #region MODELS
        public const int LANDSTAL = 400;
        public const int BRAVURA = 401;
        public const int BUFFALO = 402;
        public const int LINERUN = 403;
        public const int PEREN = 404;
        public const int SENTINEL = 405;
        public const int DUMPER = 406;
        public const int FIRETRUK = 407;
        public const int TRASH = 408;
        public const int STRETCH = 409;
        public const int MANANA = 410;
        public const int INFERNUS = 411;
        public const int VOODOO = 412;
        public const int PONY = 413;
        public const int MULE = 414;
        public const int CHEETAH = 415;
        public const int AMBULAN = 416;
        public const int LEVIATHN = 417;
        public const int MOONBEAM = 418;
        public const int ESPERANT = 419;
        public const int TAXI = 420;
        public const int WASHING = 421;
        public const int BOBCAT = 422;
        public const int MRWHOOP = 423;
        public const int BFINJECT = 424;
        public const int HUNTER = 425;
        public const int PREMIER = 426;
        public const int ENFORCER = 427;
        public const int SECURICA = 428;
        public const int BANSHEE = 429;
        public const int PREDATOR = 430;
        public const int BUS = 431;
        public const int RHINO = 432;
        public const int BARRACKS = 433;
        public const int HOTKNIFE = 434;
        public const int ARTICT1 = 435;
        public const int PREVION = 436;
        public const int COACH = 437;
        public const int CABBIE = 438;
        public const int STALLION = 439;
        public const int RUMPO = 440;
        public const int RCBANDIT = 441;
        public const int ROMERO = 442;
        public const int PACKER = 443;
        public const int MONSTER = 444;
        public const int ADMIRAL = 445;
        public const int SQUALO = 446;
        public const int SEASPAR = 447;
        public const int PIZZABOY = 448;
        public const int TRAM = 449;
        public const int ARTICT2 = 450;
        public const int TURISMO = 451;
        public const int SPEEDER = 452;
        public const int REEFER = 453;
        public const int TROPIC = 454;
        public const int FLATBED = 455;
        public const int YANKEE = 456;
        public const int CADDY = 457;
        public const int SOLAIR = 458;
        public const int TOPFUN = 459;
        public const int SKIMMER = 460;
        public const int PCJ600 = 461;
        public const int FAGGIO = 462;
        public const int FREEWAY = 463;
        public const int RCBARON = 464;
        public const int RCRAIDER = 465;
        public const int GLENDALE = 466;
        public const int OCEANIC = 467;
        public const int SANCHEZ = 468;
        public const int SPARROW = 469;
        public const int PATRIOT = 470;
        public const int QUAD = 471;
        public const int COASTG = 472;
        public const int DINGHY = 473;
        public const int HERMES = 474;
        public const int SABRE = 475;
        public const int RUSTLER = 476;
        public const int ZR350 = 477;
        public const int WALTON = 478;
        public const int REGINA = 479;
        public const int COMET = 480;
        public const int BMX = 481;
        public const int BURRITO = 482;
        public const int CAMPER = 483;
        public const int MARQUIS = 484;
        public const int BAGGAGE = 485;
        public const int DOZER = 486;
        public const int MAVERICK = 487;
        public const int VCNMAV = 488;
        public const int RANCHER = 489;
        public const int FBIRANCH = 490;
        public const int VIRGO = 491;
        public const int GREENWOO = 492;
        public const int JETMAX = 493;
        public const int HOTRING = 494;
        public const int SANDKING = 495;
        public const int BLISTAC = 496;
        public const int POLMAV = 497;
        public const int BOXVILLE = 498;
        public const int BENSON = 499;
        public const int MESA = 500;
        public const int RCGOBLIN = 501;
        public const int HOTRINA = 502;
        public const int HOTRINB = 503;
        public const int BLOODRA = 504;
        public const int RNCHLURE = 505;
        public const int SUPERGT = 506;
        public const int ELEGANT = 507;
        public const int JOURNEY = 508;
        public const int BIKE = 509;
        public const int MTBIKE = 510;
        public const int BEAGLE = 511;
        public const int CROPDUST = 512;
        public const int STUNT = 513;
        public const int PETRO = 514;
        public const int RDTRAIN = 515;
        public const int NEBULA = 516;
        public const int MAJESTIC = 517;
        public const int BUCCANEE = 518;
        public const int SHAMAL = 519;
        public const int HYDRA = 520;
        public const int FCR900 = 521;
        public const int NRG500 = 522;
        public const int COPBIKE = 523;
        public const int CEMENT = 524;
        public const int TOWTRUCK = 525;
        public const int FORTUNE = 526;
        public const int CADRONA = 527;
        public const int FBITRUCK = 528;
        public const int WILLARD = 529;
        public const int FORKLIFT = 530;
        public const int TRACTOR = 531;
        public const int COMBINE = 532;
        public const int FELTZER = 533;
        public const int REMINGTN = 534;
        public const int SLAMVAN = 535;
        public const int BLADE = 536;
        public const int FREIGHT = 537;
        public const int STREAK = 538;
        public const int VORTEX = 539;
        public const int VINCENT = 540;
        public const int BULLET = 541;
        public const int CLOVER = 542;
        public const int SADLER = 543;
        public const int FIRELA = 544;
        public const int HUSTLER = 545;
        public const int INTRUDER = 546;
        public const int PRIMO = 547;
        public const int CARGOBOB = 548;
        public const int TAMPA = 549;
        public const int SUNRISE = 550;
        public const int MERIT = 551;
        public const int UTILITY = 552;
        public const int NEVADA = 553;
        public const int YOSEMITE = 554;
        public const int WINDSOR = 555;
        public const int MONSTERA = 556;
        public const int MONSTERB = 557;
        public const int URANUS = 558;
        public const int JESTER = 559;
        public const int SULTAN = 560;
        public const int STRATUM = 561;
        public const int ELEGY = 562;
        public const int RAINDANC = 563;
        public const int RCTIGER = 564;
        public const int FLASH = 565;
        public const int TAHOMA = 566;
        public const int SAVANNA = 567;
        public const int BANDITO = 568;
        public const int FREIFLAT = 569;
        public const int STREAKC = 570;
        public const int KART = 571;
        public const int MOWER = 572;
        public const int DUNERIDE = 573;
        public const int SWEEPER = 574;
        public const int BROADWAY = 575;
        public const int TORNADO = 576;
        public const int AT400 = 577;
        public const int DFT30 = 578;
        public const int HUNTLEY = 579;
        public const int STAFFORD = 580;
        public const int BF400 = 581;
        public const int NEWSVAN = 582;
        public const int TUG = 583;
        public const int PETROTR = 584;
        public const int EMPEROR = 585;
        public const int WAYFARER = 586;
        public const int EUROS = 587;
        public const int HOTDOG = 588;
        public const int CLUB = 589;
        public const int FREIBOX = 590;
        public const int ARTICT3 = 591;
        public const int ANDROM = 592;
        public const int DODO = 593;
        public const int RCCAM = 594;
        public const int LAUNCH = 595;
        public const int COPCARLA = 596;
        public const int COPCARSF = 597;
        public const int COPCARVG = 598;
        public const int COPCARRU = 599;
        public const int PICADOR = 600;
        public const int SWATVAN = 601;
        public const int ALPHA = 602;
        public const int PHOENIX = 603;
        public const int GLENSHIT = 604;
        public const int SADLSHIT = 605;
        public const int BAGBOXA = 606;
        public const int BAGBOXB = 607;
        public const int TUGSTAIR = 608;
        public const int BOXBURG = 609;
        public const int FARMTR1 = 610;
        public const int UTILTR1 = 611;

        public const int MALE01 = 7;
        public const int BFORI = 9;
        public const int BFOST = 10;
        public const int VBFYCRP = 11;
        public const int BFYRI = 12;
        public const int BFYST = 13;
        public const int BMORI = 14;
        public const int BMOST = 15;
        public const int BMYAP = 16;
        public const int BMYBU = 17;
        public const int BMYBE = 18;
        public const int BMYDJ = 19;
        public const int BMYRI = 20;
        public const int BMYCR = 21;
        public const int BMYST = 22;
        public const int WMYBMX = 23;
        public const int WBDYG1 = 24;
        public const int WBDYG2 = 25;
        public const int WMYBP = 26;
        public const int WMYCON = 27;
        public const int BMYDRUG = 28;
        public const int WMYDRUG = 29;
        public const int HMYDRUG = 30;
        public const int DWFOLC = 31;
        public const int DWMOLC1 = 32;
        public const int DWMOLC2 = 33;
        public const int DWMYLC1 = 34;
        public const int HMOGAR = 35;
        public const int WMYGOL1 = 36;
        public const int WMYGOL2 = 37;
        public const int HFORI = 38;
        public const int HFOST = 39;
        public const int HFYRI = 40;
        public const int HFYST = 41;
        public const int HMORI = 43;
        public const int HMOST = 44;
        public const int HMYBE = 45;
        public const int HMYRI = 46;
        public const int HMYCR = 47;
        public const int HMYST = 48;
        public const int OMOKUNG = 49;
        public const int WMYMECH = 50;
        public const int BMYMOUN = 51;
        public const int WMYMOUN = 52;
        public const int OFORI = 53;
        public const int OFOST = 54;
        public const int OFYRI = 55;
        public const int OFYST = 56;
        public const int OMORI = 57;
        public const int OMOST = 58;
        public const int OMYRI = 59;
        public const int OMYST = 60;
        public const int WMYPLT = 61;
        public const int WMOPJ = 62;
        public const int BFYPRO = 63;
        public const int HFYPRO = 64;
        public const int BMYPOL1 = 66;
        public const int BMYPOL2 = 67;
        public const int WMOPREA = 68;
        public const int SBFYST = 69;
        public const int WMOSCI = 70;
        public const int WMYSGRD = 71;
        public const int SWMYHP1 = 72;
        public const int SWMYHP2 = 73;
        public const int SWFOPRO = 75;
        public const int WFYSTEW = 76;
        public const int SWMOTR1 = 77;
        public const int WMOTR1 = 78;
        public const int BMOTR1 = 79;
        public const int VBMYBOX = 80;
        public const int VWMYBOX = 81;
        public const int VHMYELV = 82;
        public const int VBMYELV = 83;
        public const int VIMYELV = 84;
        public const int VWFYPRO = 85;
        public const int VWFYST1 = 87;
        public const int WFORI = 88;
        public const int WFOST = 89;
        public const int WFYJG = 90;
        public const int WFYRI = 91;
        public const int WFYRO = 92;
        public const int WFYST = 93;
        public const int WMORI = 94;
        public const int WMOST = 95;
        public const int WMYJG = 96;
        public const int WMYLG = 97;
        public const int WMYRI = 98;
        public const int WMYRO = 99;
        public const int WMYCR = 100;
        public const int WMYST = 101;
        public const int BALLAS1 = 102;
        public const int BALLAS2 = 103;
        public const int BALLAS3 = 104;
        public const int FAM1 = 105;
        public const int FAM2 = 106;
        public const int FAM3 = 107;
        public const int LSV1 = 108;
        public const int LSV2 = 109;
        public const int LSV3 = 110;
        public const int MAFFA = 111;
        public const int MAFFB = 112;
        public const int MAFBOSS = 113;
        public const int VLA1 = 114;
        public const int VLA2 = 115;
        public const int VLA3 = 116;
        public const int TRIADA = 117;
        public const int TRIADB = 118;
        public const int TRIBOSS = 120;
        public const int DNB1 = 121;
        public const int DNB2 = 122;
        public const int DNB3 = 123;
        public const int VMAFF1 = 124;
        public const int VMAFF2 = 125;
        public const int VMAFF3 = 126;
        public const int VMAFF4 = 127;
        public const int DNMYLC = 128;
        public const int DNFOLC1 = 129;
        public const int DNFOLC2 = 130;
        public const int DNFYLC = 131;
        public const int DNMOLC1 = 132;
        public const int DNMOLC2 = 133;
        public const int SBMOTR2 = 134;
        public const int SWMOTR2 = 135;
        public const int SBMYTR3 = 136;
        public const int SWMOTR3 = 137;
        public const int WFYBE = 138;
        public const int BFYBE = 139;
        public const int HFYBE = 140;
        public const int SOFYBU = 141;
        public const int SBMYST = 142;
        public const int SBMYCR = 143;
        public const int BMYCG = 144;
        public const int WFYCRK = 145;
        public const int HMYCM = 146;
        public const int WMYBU = 147;
        public const int BFYBU = 148;
        public const int WFYBU = 150;
        public const int DWFYLC1 = 151;
        public const int WFYPRO = 152;
        public const int WMYCONB = 153;
        public const int WMYBE = 154;
        public const int WMYPIZZ = 155;
        public const int BMOBAR = 156;
        public const int CWFYHB = 157;
        public const int CWMOFR = 158;
        public const int CWMOHB1 = 159;
        public const int CWMOHB2 = 160;
        public const int CWMYFR = 161;
        public const int CWMYHB1 = 162;
        public const int BMYBOUN = 163;
        public const int WMYBOUN = 164;
        public const int WMOMIB = 165;
        public const int BMYMIB = 166;
        public const int WMYBELL = 167;
        public const int BMOCHIL = 168;
        public const int SOFYRI = 169;
        public const int SOMYST = 170;
        public const int VWMYBJD = 171;
        public const int VWFYCRP = 172;
        public const int SFR1 = 173;
        public const int SFR2 = 174;
        public const int SFR3 = 175;
        public const int BMYBAR = 176;
        public const int WMYBAR = 177;
        public const int WFYSEX = 178;
        public const int WMYAMMO = 179;
        public const int BMYTATT = 180;
        public const int VWMYCR = 181;
        public const int VBMOCD = 182;
        public const int VBMYCR = 183;
        public const int VHMYCR = 184;
        public const int SBMYRI = 185;
        public const int SOMYRI = 186;
        public const int SOMYBU = 187;
        public const int SWMYST = 188;
        public const int WMYVA = 189;
        public const int COPGRL3 = 190;
        public const int GUNGRL3 = 191;
        public const int MECGRL3 = 192;
        public const int NURGRL3 = 193;
        public const int CROGRL3 = 194;
        public const int GANGRL3 = 195;
        public const int CWFOFR = 196;
        public const int CWFOHB = 197;
        public const int CWFYFR1 = 198;
        public const int CWFYFR2 = 199;
        public const int CWMYHB2 = 200;
        public const int DWFYLC2 = 201;
        public const int DWMYLC2 = 202;
        public const int OMYKARA = 203;
        public const int WMYKARA = 204;
        public const int WFYBURG = 205;
        public const int VWMYCD = 206;
        public const int VHFYPRO = 207;
        public const int OMONOOD = 209;
        public const int OMOBOAT = 210;
        public const int WFYCLOT = 211;
        public const int VWMOTR1 = 212;
        public const int VWMOTR2 = 213;
        public const int VWFYWAI = 214;
        public const int SBFORI = 215;
        public const int SWFYRI = 216;
        public const int WMYCLOT = 217;
        public const int SBFOST = 218;
        public const int SBFYRI = 219;
        public const int SBMOCD = 220;
        public const int SBMORI = 221;
        public const int SBMOST = 222;
        public const int SHMYCR = 223;
        public const int SOFORI = 224;
        public const int SOFOST = 225;
        public const int SOFYST = 226;
        public const int SOMOBU = 227;
        public const int SOMORI = 228;
        public const int SOMOST = 229;
        public const int SWMOTR5 = 230;
        public const int SWFORI = 231;
        public const int SWFOST = 232;
        public const int SWFYST = 233;
        public const int SWMOCD = 234;
        public const int SWMORI = 235;
        public const int SWMOST = 236;
        public const int SHFYPRO = 237;
        public const int SBFYPRO = 238;
        public const int SWMOTR4 = 239;
        public const int SWMYRI = 240;
        public const int SMYST = 241;
        public const int SMYST2 = 242;
        public const int SFYPRO = 243;
        public const int VBFYST2 = 244;
        public const int VBFYPRO = 245;
        public const int VHFYST3 = 246;
        public const int BIKERA = 247;
        public const int BIKERB = 248;
        public const int BMYPIMP = 249;
        public const int SWMYCR = 250;
        public const int WFYLG = 251;
        public const int WMYVA2 = 252;
        public const int BMOSEC = 253;
        public const int BIKDRUG = 254;
        public const int WMYCH = 255;
        public const int SBFYSTR = 256;
        public const int SWFYSTR = 257;
        public const int HECK1 = 258;
        public const int HECK2 = 259;
        public const int BMYCON = 260;
        public const int WMYCD1 = 261;
        public const int BMOCD = 262;
        public const int VWFYWA2 = 263;
        public const int WMOICE = 264;
        public const int LAEMT1 = 274;
        public const int LVEMT1 = 275;
        public const int SFEMT1 = 276;
        public const int LAFD1 = 277;
        public const int LVFD1 = 278;
        public const int SFFD1 = 279;
        public const int LAPD1 = 280;
        public const int SFPD1 = 281;
        public const int LVPD1 = 282;
        public const int CSHER = 283;
        public const int LAPDM1 = 284;
        public const int SWAT = 285;
        public const int FBI = 286;
        public const int ARMY = 287;
        public const int DSHER = 288;
        public const int SPECIAL01 = 290;
        public const int SPECIAL02 = 291;
        public const int SPECIAL03 = 292;
        public const int SPECIAL04 = 293;
        public const int SPECIAL05 = 294;
        public const int SPECIAL06 = 295;
        public const int SPECIAL07 = 296;
        public const int SPECIAL08 = 297;
        public const int SPECIAL09 = 298;
        public const int SPECIAL10 = 299;

        public const int CELLPHONE = 330;
        public const int BRIEFCASE = 1210;
        public const int BARREL1 = 1218;
        public const int BARREL4 = 1225;
        public const int INFO = 1239;
        public const int HEALTH = 1240;
        public const int BODYARMOR = 1242;
        public const int BRIBE = 1247;
        public const int PICKUPSAVE = 1277;
        public const int KEYCARD = 1581;
        public const int CIGAR = 3044;

        public const int GUN_DILDO1 = 321;
        public const int GUN_DILDO2 = 322;
        public const int GUN_VIBE1 = 323;
        public const int GUN_VIBE2 = 324;
        public const int FLOWERA = 325;
        public const int GUN_CANE = 326;
        public const int GUN_BOXWEE = 327;
        public const int GUN_BOXBIG = 328;
        public const int BRASSKNUCKLE = 331;
        public const int GOLFCLUB = 333;
        public const int NITESTICK = 334;
        public const int KNIFECUR = 335;
        public const int BAT = 336;
        public const int SHOVEL = 337;
        public const int POOLCUE = 338;
        public const int KATANA = 339;
        public const int CHNSAW = 341;
        public const int GRENADE = 342;
        public const int TEARGAS = 343;
        public const int MOLOTOV = 344;
        public const int MISSILE = 345;
        public const int COLT45 = 346;
        public const int SILENCED = 347;
        public const int DESERT_EAGLE = 348;
        public const int CHROMEGUN = 349;
        public const int SAWNOFF = 350;
        public const int SHOTGSPA = 351;
        public const int MICRO_UZI = 352;
        public const int MP5LNG = 353;
        public const int FLARE = 354;
        public const int AK47 = 355;
        public const int M4 = 356;
        public const int CUNTGUN = 357;
        public const int SNIPER = 358;
        public const int ROCKETLA = 359;
        public const int HEATSEEK = 360;
        public const int FLAME = 361;
        public const int MINIGUN = 362;
        public const int SATCHEL = 363;
        public const int BOMB = 364;
        public const int SPRAYCAN = 365;
        public const int FIRE_EX = 366;
        public const int GUN_CAMERA = 367;
        public const int NVGOGGLES = 368;
        public const int IRGOGGLES = 369;
        public const int JETPACK = 370;
        public const int GUN_PARA = 371;
        public const int TEC9 = 372;
        #endregion

        //----------------------------------------------------------------------------------------------------

        #region PSEUDO OPCODES
        internal static void gosub_custom() { AppendLine( Opcodes._0050, Current.ScriptName ); }
        internal static void gosub_custom( string custom ) { AppendLine( Opcodes._0050, $"{Current.ScriptName}_{custom}" ); }
        internal static void jump_custom( string custom ) { AppendLine( Opcodes._0002, $"{Current.ScriptName}_{custom}" ); }
        internal static void jump_custom( BaseLabel label ) { AppendLine( Opcodes._0002, label ); }
        internal static void label( string name ) { AppendLine( "\n:{0}", name ); }
        internal static void label( BaseLabel label ) { AppendLine( "\n:{0}", label ); }
        internal static void set_on_mission_flag() { AppendLine( Opcodes._0180, OnMission ); }
        internal static void end_scene_skip() { AppendLine( Opcodes._0701 ); }
        #endregion

        //----------------------------------------------------------------------------------------------------

        #region THREADING NAVIGATION

        public static event HandlerJump Jump {
            add {
                if( !Current.jumps.ContainsKey( value ) ) {
                    Current.jumps.Add( value, new LabelJump( Current, Current.jumpsCounter ) );
                    Current.jumpsCounter += 1;
                }
                AppendLine( Opcodes._0002, Current.jumps[ value ] );
            }
            remove { }
        }
        public static event HandlerGosub Gosub {
            add {
                if( !Current.gosubs.ContainsKey( value ) ) {
                    Current.gosubs.Add( value, new LabelGosub( Current, Current.gosubsCounter ) );
                    Current.gosubsCounter += 1;
                }
                AppendLine( Opcodes._0050, Current.gosubs[ value ] );
            }
            remove { }
        }
        public static event Action Cycle {
            add {
                var label = new LabelCycle( Current, Current.cycleCounter );
                Current.cycleCounter += 1;
                Script.label( label );
                if( value != null )
                    value.Invoke();
                jump_custom( label );
            }
            remove { }
        }
        public static event HandlerScene Scene {
            add {
                var script = Current;
                var label = new LabelScene( script, script.scenesCounter );
                script.scenesCounter += 1;
                AppendLine( Opcodes._0707, label );
                if( value != null )
                    value.Invoke( label );
                Script.label( label );
                end_scene_skip();
            }
            remove { }
        }

        public static void call_scm_function<T>( byte inputCount, params Parameter[] args ) where T : Function, new() {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( call_scm_function ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            var script = CreateFunctionIfNotExist<T>();
            AppendLine( Opcodes._0AB1, $"{script.ScriptName}", inputCount, stringBuilder.ToString() );
        }
        public static Condition is_call_scm_function<T>( byte inputCount, params Parameter[] args ) where T : Function, new() {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( is_call_scm_function ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            var script = CreateFunctionIfNotExist<T>();
            return new Condition( Opcodes._0AB1v, $"{script.ScriptName}", inputCount, stringBuilder.ToString() );
        }

        public static void start_new_external_script<T>( params Parameter[] args ) where T : External, new() {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( start_new_external_script ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._0913, GetExternalFullName( script ), stringBuilder.ToString() );
        }

        public static void start_mission<T>() where T : MissionCustom, new() {
            var script = CreateMissionIfNotExist<T>();
            AppendLine( Opcodes._0417, allScripts[ script ] );
        }

        public static void create_thread_wb<T>() where T : Thread, new() {
            var script = CreateThreadIfNotExist<T>();
            AppendLine( Opcodes._00D7, script.ScriptName );
        }
        public static void create_thread<T>() where T : Thread, new() {
            var script = CreateThreadIfNotExist<T>();
            AppendLine( Opcodes._004F, script.ScriptName, "" );
        }
        public static void create_thread<T>( params Parameter[] args ) where T : Thread, new() {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( create_thread ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            var script = CreateThreadIfNotExist<T>();
            AppendLine( Opcodes._004F, script.ScriptName, stringBuilder.ToString() );
        }
        public static void create_thread<K, T>( Array<T> array ) where K : Thread, new() where T : Variable, IArrayItem {
            if( array.count * array.elementSize > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( create_thread ), Parameter.LIMIT ) );
            var script = CreateThreadIfNotExist<K>();
            AppendLine( Opcodes._004F, script.ScriptName, array.ToLine() );
        }

        public static void end_thread_named( sString name ) { AppendLine( Opcodes._0459, name ); }
        public static void end_thread_named<T>() where T : Thread, new() {
            var script = CreateThreadIfNotExist<T>();
            AppendLine( Opcodes._0459, script.ScriptName );
        }

        public static void init_external_script_trigger_with_object_model<T>( Int objectModelID, Int priorityPercent, Float radius, Int triggerType ) where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._0929, GetExternalFullName( script ), objectModelID, priorityPercent, radius, triggerType );
        }
        public static void init_external_script_trigger_with_actor_model<T>( Int actorModelID, Int priorityPercent ) where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._0928, GetExternalFullName( script ), actorModelID, priorityPercent );
        }
        public static void init_external_script_brain<T>() where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._07D3, script.ScriptName, GetExternalFullName( script ) );
        }
        public static void init_external_script_attractor<T>() where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._0884, script.ScriptName, GetExternalFullName( script ) );
        }
        public static void get_external_script_status<T>( Out<Int> status ) where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._0926, status, GetExternalFullName( script ) );
        }
        public static void load_external_script<T>() where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._08A9, GetExternalFullName( script ) );
        }
        public static void remove_references_external_script<T>() where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._090F, GetExternalFullName( script ) );
        }
        public static void release_external_script<T>() where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._0910, GetExternalFullName( script ) );
        }

        public static void jump_table( Out<Int> value, HandlerSwitch table ) {
            if( table == null )
                throw new Exception( Localization.JumpTableNotHandler() );
            var jt = new JumpTable( value );
            table.Invoke( jt );
            jt.write();
        }
        public static void loop( HandlerLoop action ) {
            AppendLine( "\nwhile true" );
            action.Invoke( LoopResult.instance );
            AppendLine( "end\n" );
        }
        public static void loop( Condition condition, HandlerLoop action ) {
            AppendLine( $"\nwhile {condition}" );
            action.Invoke( LoopResult.instance );
            AppendLine( "end\n" );
        }
        public static void loop( HandlerLoop action, Condition condition ) {
            AppendLine( "\nrepeat" );
            action.Invoke( LoopResult.instance );
            AppendLine( $"until {condition}\n" );
        }
        public static void end_thread() { AppendLine( Opcodes._004E ); }
        internal static void jump() { AppendLine( Opcodes._0002, Current.ScriptName ); }

        public static void jump( Memory label ) {
            if( label.labelType != TypeOfLabel.JUMP ) {
                Debug.Blue( Localization.LabelMemoryNotFound( label.labelName ) );
                //throw new Exception(  );
            }
            AppendLine( Opcodes._0002v, label );
        }
        public static void jump( BaseLabel label ) { AppendLine( Opcodes._0002, label ); }
        public static void jump( HandlerJump label ) { Jump += label; }
        public static void gosub( HandlerGosub label ) { Gosub += label; }
        public static void @return() { AppendLine( Opcodes._0051 ); }
        #endregion

        //----------------------------------------------------------------------------------------------------

        #region IF AND LOOPS

        internal static void or( Condition[] conditions ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "or" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1 ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2, Condition condition3 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }

        internal static void and( Condition[] conditions ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "and" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1 ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2, Condition condition3 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }
        internal static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
        }

        internal static void jf( Condition[] conditions ) {
            if( conditions.Length == 0 )
                throw new Exception( Localization.ConditionsCountIsZero() );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, Current.ScriptName );
            }
        }
        internal static void jf( Condition conditions1, params Condition[] conditions ) {
            AppendLine( Opcodes._00D6 );
            conditions1.write();
            AppendLine( Opcodes._004D, Current.ScriptName );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, Current.ScriptName );
            }
        }


        public static void or( BaseLabel label, Condition[] conditions ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "or" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1 ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2, Condition condition3 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void or( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            AppendLine( Opcodes._004D, label );
        }

        public static void or( HandlerJump label, Condition[] conditions ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "or" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1 ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2, Condition condition3 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void or( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8 ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }

        public static void or( Condition[] conditions, Action thenBlock, Action elseBlock = null ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "or" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Condition condition3, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void or( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "or" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }

        public static void and( BaseLabel label, Condition[] conditions ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "and" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1 ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2, Condition condition3 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            AppendLine( Opcodes._004D, label );
        }
        public static void and( BaseLabel label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            AppendLine( Opcodes._004D, label );
        }

        public static void and( HandlerJump label, Condition[] conditions ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "and" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1 ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2, Condition condition3 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }
        public static void and( HandlerJump label, Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8 ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
        }

        public static void and( Condition[] conditions, Action thenBlock, Action elseBlock = null ) {
            if( conditions.Length == 0 || conditions.Length > 8 )
                throw new Exception( Localization.ConditionsOverflowCount() );
            if( conditions.Length == 1 ) {
                AppendLine( Opcodes._00D6 );
            } else {
                AppendLine( Opcodes._00D6w, "and" );
            }
            for( int i = 0; i < conditions.Length; i++ )
                conditions[ i ].write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6 );
            condition1.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Condition condition3, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }
        public static void and( Condition condition1, Condition condition2, Condition condition3, Condition condition4, Condition condition5, Condition condition6, Condition condition7, Condition condition8, Action thenBlock, Action elseBlock = null ) {
            AppendLine( Opcodes._00D6w, "and" );
            condition1.write();
            condition2.write();
            condition3.write();
            condition4.write();
            condition5.write();
            condition6.write();
            condition7.write();
            condition8.write();
            AppendLine( "then" );
            thenBlock.Invoke();
            if( elseBlock != null ) {
                AppendLine( "else" );
                elseBlock.Invoke();
            }
            AppendLine( "end" );
        }

        public static void to( Out<Int> index, Int fromValue, Int toValue, HandlerLoop action, Int loopStep = null ) {
            var step = string.Empty;
            if( !ReferenceEquals( loopStep, null ) && !loopStep.IsDefined ) {
                if( 0 >= int.Parse( loopStep.Name ) )
                    throw new Exception( Localization.LoopForLowStep() );
                step = $" step {loopStep}";
            }
            if( !fromValue.IsDefined && !toValue.IsDefined ) {
                if( int.Parse( fromValue.Name ) > int.Parse( toValue.Name ) )
                    throw new Exception( Localization.LoopForParameterMustBeGreat( toValue.ToString(), fromValue.ToString() ) );
            }
            AppendLine( $"\nint {index}" );
            AppendLine( $"for {index} = {fromValue} to {toValue}{step}" );
            action.Invoke( LoopResult.instance );
            AppendLine( "end\n" );
        }
        public static void to( Out<Float> index, Float fromValue, Float toValue, HandlerLoop action, Float loopStep = null ) {
            var step = string.Empty;
            if( !ReferenceEquals( loopStep, null ) && !loopStep.IsDefined ) {
                if( 0 >= double.Parse( loopStep.Name ) )
                    throw new Exception( Localization.LoopForLowStep() );
                step = $" step {loopStep}";
            }
            if( !fromValue.IsDefined && !toValue.IsDefined ) {
                if( double.Parse( fromValue.Name ) > double.Parse( toValue.Name ) )
                    throw new Exception( Localization.LoopForParameterMustBeGreat( toValue.ToString(), fromValue.ToString() ) );
            }
            AppendLine( $"\nfloat {index}" );
            AppendLine( $"for {index} = {fromValue} to {toValue}{step}" );
            action.Invoke( LoopResult.instance );
            AppendLine( "end\n" );
        }

        public static void downto( Out<Int> index, Int fromValue, Int toValue, HandlerLoop action, Int loopStep = null ) {
            var step = string.Empty;
            if( !ReferenceEquals( loopStep, null ) && !loopStep.IsDefined ) {
                if( 0 >= int.Parse( loopStep.Name ) )
                    throw new Exception( Localization.LoopForLowStep() );
                step = $" step {loopStep}";
            }
            if( !fromValue.IsDefined && !toValue.IsDefined ) {
                if( int.Parse( toValue.Name ) > int.Parse( fromValue.Name ) )
                    throw new Exception( Localization.LoopForParameterMustBeGreat( fromValue.ToString(), toValue.ToString() ) );
            }
            AppendLine( $"\nint {index}" );
            AppendLine( $"for {index} = {fromValue} downto {toValue}{step}" );
            action.Invoke( LoopResult.instance );
            AppendLine( "end\n" );
        }
        public static void downto( Out<Float> index, Float fromValue, Float toValue, HandlerLoop action, Float loopStep = null ) {
            var step = string.Empty;
            if( !ReferenceEquals( loopStep, null ) && !loopStep.IsDefined ) {
                if( 0.0 >= double.Parse( loopStep.Name ) )
                    throw new Exception( Localization.LoopForLowStep() );
                step = $" step {loopStep}";
            }
            if( !fromValue.IsDefined && !toValue.IsDefined ) {
                if( double.Parse( toValue.Name ) > double.Parse( fromValue.Name ) )
                    throw new Exception( Localization.LoopForParameterMustBeGreat( fromValue.ToString(), toValue.ToString() ) );
            }
            AppendLine( $"\nfloat {index}" );
            AppendLine( $"for {index} = {fromValue} downto {toValue}{step}" );
            action.Invoke( LoopResult.instance );
            AppendLine( "end\n" );
        }

        public static void jf( BaseLabel label, Condition[] conditions ) {
            if( conditions.Length == 0 )
                throw new Exception( Localization.ConditionsCountIsZero() );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, label );
            }
        }
        public static void jf( HandlerJump label, Condition[] conditions ) {
            if( conditions.Length == 0 )
                throw new Exception( Localization.ConditionsCountIsZero() );
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, Current.jumps[ label ] );
            }
        }

        public static void jf( BaseLabel label, Condition conditions1, params Condition[] conditions ) {
            AppendLine( Opcodes._00D6 );
            conditions1.write();
            AppendLine( Opcodes._004D, label );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, label );
            }
        }
        public static void jf( HandlerJump label, Condition conditions1, params Condition[] conditions ) {
            AppendLine( Opcodes._00D6 );
            conditions1.write();
            if( !Current.jumps.ContainsKey( label ) ) {
                Current.jumps.Add( label, new LabelJump( Current, Current.jumpsCounter ) );
                Current.jumpsCounter += 1;
            }
            AppendLine( Opcodes._004D, Current.jumps[ label ] );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, Current.jumps[ label ] );
            }
        }

        #endregion

        //----------------------------------------------------------------------------------------------------

        #region OPCODES FOR GTA SA
        public static void hex( string code ) { AppendLine( "hex\n{0}\nend", code ); }
        public static void hex( uint sizeInBytes ) {
            StringBuilder stringBuilder = new StringBuilder();
            var totalColumn = 0;
            for( uint i = 0; i < sizeInBytes; i++ ) {
                totalColumn += 1;
                if( totalColumn > 16 ) {
                    totalColumn = 0;
                    stringBuilder.AppendLine();
                }
                stringBuilder.AppendFormat( "00 " );
            }
            AppendLine( "hex\n{0}\nend", stringBuilder.ToString() );
        }
        public static void hex( uint columnCount, uint rowCount ) {
            StringBuilder stringBuilder = new StringBuilder();
            for( uint i = 0; i < rowCount; i++ ) {
                stringBuilder.AppendLine();
                for( uint j = 0; j < columnCount; j++ )
                    stringBuilder.AppendFormat( "00 " );
            }
            AppendLine( "hex{0}\nend", stringBuilder.ToString() );
        }
        public static void wait( Int time ) { AppendLine( Opcodes._0001, time ); }
        public static void wait( Int time, Condition[] conditions ) {
            if( conditions.Length == 0 )
                throw new Exception( Localization.ConditionsCountIsZero() );
            var label = new LabelJF( Current, Current.jfCounter );
            Current.jfCounter += 1;
            Script.label( label );
            wait( time );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, label );
            }
        }
        public static void wait( Int time, Condition conditions1, params Condition[] conditions ) {
            var label = new LabelJF( Current, Current.jfCounter );
            Current.jfCounter += 1;
            Script.label( label );
            wait( time );
            AppendLine( Opcodes._00D6 );
            conditions1.write();
            AppendLine( Opcodes._004D, label );
            for( int i = 0; i < conditions.Length; i++ ) {
                AppendLine( Opcodes._00D6 );
                conditions[ i ].write();
                AppendLine( Opcodes._004D, label );
            }
        }
        public static void wait( Condition[] conditions ) { wait( 0, conditions ); }
        public static void wait( Condition conditions1, params Condition[] conditions ) { wait( 0, conditions1, conditions ); }
        public static void show_save_screen() { AppendLine( Opcodes._03D8 ); }
        public static void fade( Int fadeType_bool, Int time ) { AppendLine( Opcodes._016A, fadeType_bool, time ); }
        public static void set_fade_color_rgb( Int r_byte, Int g_byte, Int b_byte ) { AppendLine( Opcodes._0169, r_byte, g_byte, b_byte ); }
        public static void text_clear_all() { AppendLine( Opcodes._00BE ); }
        public static void set_current_time( Int hours, Int minutes ) { AppendLine( Opcodes._00C0, hours, minutes ); }
        public static void get_current_time( Out<Int> hours, Out<Int> minutes ) { AppendLine( Opcodes._00BF, hours, minutes ); }
        public static void set_gamespeed( Float speed ) { AppendLine( Opcodes._015D, speed ); }
        public static void release_weather() { AppendLine( Opcodes._01B7 ); }
        public static void set_vehicle_traffic_density_multiplier( Float multiplier ) { AppendLine( Opcodes._01EB, multiplier ); }
        public static void set_max_wanted_level( Int level ) { AppendLine( Opcodes._01F0, level ); }
        public static void enable_widescreen( Int state_bool ) { AppendLine( Opcodes._02A3, state_bool ); }
        public static void cancel_override_restart() { AppendLine( Opcodes._01F6 ); }
        public static void get_controller_mode( Out<Int> mode ) { AppendLine( Opcodes._0293, mode ); }
        public static void load_requested_models() { AppendLine( Opcodes._038B ); }
        public static void load_requested_models( Int[] models ) {
            for( int i = 0; i < models.Length; i++ )
                load_model( models[ i ] );
            AppendLine( Opcodes._038B );
        }
        public static void load_requested_models( Int model, params Int[] models ) {
            load_model( model );
            for( int i = 0; i < models.Length; i++ )
                load_model( models[ i ] );
            AppendLine( Opcodes._038B );
        }
        public static void remove_text_box() { AppendLine( Opcodes._03E6 ); }
        public static void show_credits() { AppendLine( Opcodes._0434 ); }
        public static void end_credits() { AppendLine( Opcodes._0435 ); }
        public static void store_current_time() { AppendLine( Opcodes._0253 ); }
        public static void restore_current_time() { AppendLine( Opcodes._0254 ); }
        public static void remove_all_fires() { AppendLine( Opcodes._031A ); }
        public static void get_current_time_in_ms( Out<Int> time ) { AppendLine( Opcodes._01BD, time ); }
        public static void pause_timer( Int state_bool ) { AppendLine( Opcodes._0396, state_bool ); }
        public static void get_minutes_to_time_of_day( Int hours_byte, Int minutes_byte, Out<Int> timeOfDay ) { AppendLine( Opcodes._00C1, hours_byte, minutes_byte, timeOfDay ); }
        public static void set_wasted_busted_check( Int state_bool ) { AppendLine( Opcodes._0111, state_bool ); }
        public static void override_next_restart( Float x, Float y, Float z, Float angle ) { AppendLine( Opcodes._016E, x, y, z, angle ); }
        public static void play_sound( Int soundID, Float x, Float y, Float z ) { AppendLine( Opcodes._018C, soundID, x, y, z ); }
        public static void get_rampage_status( Out<Int> status ) { AppendLine( Opcodes._01FA, status ); }
        public static void switch_roads_on( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._01E7, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void switch_roads_off( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._01E8, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void switch_ped_roads_on( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._022A, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void switch_ped_roads_off( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._022B, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void start_cutscene() { AppendLine( Opcodes._02E7 ); }
        public static void get_cutscene_time( Out<Int> time ) { AppendLine( Opcodes._02E8, time ); }
        public static void end_cutscene() { AppendLine( Opcodes._02EA ); }
        public static void store_path_coords_closest_to_ped( Out<Float> toX, Out<Float> toY, Out<Float> toZ, Float x, Float y, Float z ) { AppendLine( Opcodes._02C0, toX, toY, toZ, x, y, z ); }
        public static void store_path_coords_closest_to_vehicle( Out<Float> toX, Out<Float> toY, Out<Float> toZ, Float x, Float y, Float z ) { AppendLine( Opcodes._02C1, toX, toY, toZ, x, y, z ); }
        public static void create_random_vehicle_for_car_park( Float x, Float y, Float z, Float angle ) { AppendLine( Opcodes._03C5, x, y, z, angle ); }
        public static void set_free_respray( Int state_bool ) { AppendLine( Opcodes._0335, state_bool ); }
        public static void clear_small_messages_only() { AppendLine( Opcodes._03EB ); }
        public static void set_ped_traffic_density_multiplier( Float multiplier ) { AppendLine( Opcodes._03DE, multiplier ); }
        public static void unload_special_actor( Int number ) { AppendLine( Opcodes._0296, number ); }
        public static void unload_special_actor( Int[] numbers ) {
            for( int i = 0; i < numbers.Length; i++ )
                AppendLine( Opcodes._0296, numbers[ i ] );
        }
        public static void unload_special_actor( Int number, params Int[] numbers ) {
            AppendLine( Opcodes._0296, number );
            for( int i = 0; i < numbers.Length; i++ )
                AppendLine( Opcodes._0296, numbers[ i ] );
        }
        public static void set_made_progress() { AppendLine( Opcodes._030C, "1" ); }
        public static void set_max_progress( Int number ) { AppendLine( Opcodes._030D, number ); }
        public static void set_sensitivity_to_crime( Float multiplier ) { AppendLine( Opcodes._03C7, multiplier ); }
        public static void play_music( Int musicID ) { AppendLine( Opcodes._0394, musicID ); }
        public static void switch_rubbish( Int state_bool ) { AppendLine( Opcodes._03AD, state_bool ); }
        public static void switch_streaming( Int state_bool ) { AppendLine( Opcodes._03AF, state_bool ); }
        public static void play_wav( Int number ) { AppendLine( Opcodes._03D1, number ); }
        public static void disable_sounds_after_fade( Int state_bool ) { AppendLine( Opcodes._043C, state_bool ); }
        public static void clear_area( Int clearParticles_bool, Float x, Float y, Float z, Float radius ) { AppendLine( Opcodes._0395, clearParticles_bool, x, y, z, radius ); }
        public static void set_cutscene_position( Float x, Float y, Float z ) { AppendLine( Opcodes._0244, x, y, z ); }
        public static void get_ground_z( Float x, Float y, Float z, Out<Float> toZ ) { AppendLine( Opcodes._02CE, toZ, x, y, z ); }
        public static void register_fastest_time( Int statID, Int val ) { AppendLine( Opcodes._042E, statID, val ); }
        //public static void register_highest_score( Int statID, Int val ) { AppendLine( Opcodes._042F, statID, val ); }
        public static void switch_world_processing( Int state_bool ) { AppendLine( Opcodes._03B7, state_bool ); }
        public static void flash_hud_component( Int hudComponentID ) { AppendLine( Opcodes._03E7, hudComponentID ); }
        public static void set_total_missions( Int count ) { AppendLine( Opcodes._042C, count ); }
        public static void metres_to_feet_int( Int metres, Out<Int> feet ) { AppendLine( Opcodes._042D, feet, metres ); }
        public static void set_all_vehicles_can_be_damaged( Int state_bool ) { AppendLine( Opcodes._03F4, state_bool ); }
        public static void swap_nearest_building_model( Float x, Float y, Float z, Float radius, Int fromObjectModel, Int toObjectModel ) { AppendLine( Opcodes._03B6, x, y, z, radius, fromObjectModel, toObjectModel ); }
        public static void get_nearest_vehicle_path_coords_with_angle( Float x, Float y, Float z, Out<Float> toX, Out<Float> toY, Out<Float> toZ, Out<Float> toAngle ) { AppendLine( Opcodes._03D3, x, y, z, toX, toY, toZ, toAngle ); }
        public static void create_explosion( Int explosionType, Float x, Float y, Float z ) { AppendLine( Opcodes._020C, explosionType, x, y, z ); }
        public static void clear_area_of_vehicles( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._03BA, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void clear_area_of_actors( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._042B, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void set_visibility_of_closest_object( Float x, Float y, Float z, Float radius, Int objectModel, Int visibility_bool ) { AppendLine( Opcodes._0363, x, y, z, radius, objectModel, visibility_bool ); }
        public static void draw_corona( Float radius, Int coronaType, Int lensflares_byte, Int r_byte, Int g_byte, Int b_byte, Float x, Float y, Float z ) { AppendLine( Opcodes._024F, radius, coronaType, lensflares_byte, r_byte, g_byte, b_byte, x, y, z ); }
        public static void show_formatted_text_box( vString textFormat, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( show_formatted_text_box ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0ACE, textFormat, stringBuilder.ToString() );
        }
        public static void show_formatted_text_styled( vString textFormat, Int time, Int textStyle, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( show_formatted_text_styled ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0ACF, textFormat, time, textStyle, stringBuilder.ToString() );
        }
        public static void show_formatted_text_lowpriority( vString textFormat, Int time, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( show_formatted_text_lowpriority ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AD0, textFormat, time, stringBuilder.ToString() );
        }
        public static void show_formatted_text_highpriority( vString textFormat, Int time, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( show_formatted_text_highpriority ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AD1, textFormat, time, stringBuilder.ToString() );
        }
        public static void spawn_vehicle_with_model_like_a_cheat( Int vehicleModelId ) { AppendLine( Opcodes._0ADD, vehicleModelId ); }
        public static void call( Memory address, Int pop, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( call ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AA5, address, args.Length, pop, stringBuilder.ToString() );
        }
        public static void call_method( Memory methodAddress, Memory hStruct, Int pop, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( call_method ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AA6, methodAddress, hStruct, args.Length, pop, stringBuilder.ToString() );
        }
        public static void call_function( Memory address, Int pop, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                if( args.Length > Parameter.LIMIT )
                    throw new Exception( Localization.ParametersOverflowCount( nameof( call_function ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AA7, address, args.Length, pop, stringBuilder.ToString() );
        }
        public static void call_function_method( Memory methodAddress, Memory hStruct, Int pop, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( call_function_method ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            AppendLine( Opcodes._0AA8, methodAddress, hStruct, args.Length, pop, stringBuilder.ToString() );
        }
        public static void show_text_lowpriority( Int address, Int time ) { AppendLine( Opcodes._0ACC, address, time ); }
        public static void show_text_highpriority( Int address, Int time ) { AppendLine( Opcodes._0ACD, address, time ); }
        public static void write_memory( Memory address, Int size, Parameter value, Int virtualProtect_bool ) { AppendLine( Opcodes._0A8C, address, size, value, virtualProtect_bool ); }
        public static void read_memory<T>( Out<T> result, Memory address, Int size, Int virtualProtect_bool ) where T : Variable {
            if( result.instance.Size > 1 )
                throw new Exception( Localization.VariableIsNonParametr( result.instance.Name ) );
            AppendLine( Opcodes._0A8D, result, address, size, virtualProtect_bool );
        }
        public static void add_dynamic_GXT_entry( vString customGXTKey, vString text ) { AppendLine( Opcodes._0ADF, customGXTKey, text ); }
        public static void remove_dynamic_GXT_entry( vString customGXTKey ) { AppendLine( Opcodes._0AE0, customGXTKey ); }
        public static void load_model( Int modelID ) { AppendLine( Opcodes._0247, modelID ); }
        public static void load_model( Int[] modelsID ) {
            for( int i = 0; i < modelsID.Length; i++ )
                AppendLine( Opcodes._0247, modelsID[ i ] );
        }
        public static void load_model( Int modelID, params Int[] modelsID ) {
            AppendLine( Opcodes._0247, modelID );
            for( int i = 0; i < modelsID.Length; i++ )
                AppendLine( Opcodes._0247, modelsID[ i ] );
        }
        public static void destroy_model( Int modelID ) { AppendLine( Opcodes._0249, modelID ); }
        public static void destroy_model( Int[] modelsID ) {
            for( int i = 0; i < modelsID.Length; i++ )
                AppendLine( Opcodes._0249, modelsID[ i ] );
        }
        public static void destroy_model( Int modelID, params Int[] modelsID ) {
            AppendLine( Opcodes._0249, modelID );
            for( int i = 0; i < modelsID.Length; i++ )
                AppendLine( Opcodes._0249, modelsID[ i ] );
        }
        public static void show_text_styled( sString gxt, Int time, Int textStyle ) { AppendLine( Opcodes._00BA, gxt, time, textStyle ); }
        public static void show_text_lowpriority( sString gxt, Int time, Int textStyle ) { AppendLine( Opcodes._00BB, gxt, time, textStyle ); }
        public static void show_text_highpriority( sString gxt, Int time, Int textStyle ) { AppendLine( Opcodes._00BC, gxt, time, textStyle ); }
        public static void show_text_1number_styled( sString gxt, Int number, Int time, Int textStyle ) { AppendLine( Opcodes._01E3, gxt, number, time, textStyle ); }
        public static void show_text_1number_lowpriority( sString gxt, Int number, Int time, Int textStyle ) { AppendLine( Opcodes._01E4, gxt, number, time, textStyle ); }
        public static void show_text_1number_highpriority( sString gxt, Int number, Int time, Int textStyle ) { AppendLine( Opcodes._01E5, gxt, number, time, textStyle ); }
        public static void load_cutscene( sString name ) { AppendLine( Opcodes._02E4, name ); }
        public static void remove_text( sString gxt ) { AppendLine( Opcodes._03D5, gxt ); }
        public static void remove_text_styled( sString gxt ) { AppendLine( Opcodes._03D6, gxt ); }
        public static void show_text_box( sString gxt ) { AppendLine( Opcodes._03E5, gxt ); }
        public static void set_latest_mission_passed( sString gxt ) { AppendLine( Opcodes._0318, gxt ); }
        public static void print_big_q( sString gxt, Int time, Int textStyle ) { AppendLine( Opcodes._0217, gxt, time, textStyle ); }
        public static void show_text_1string_highpriority( sString gxt, sString @string, Int time, Int textStyle ) { AppendLine( Opcodes._0384, gxt, @string, time, textStyle ); }
        public static void show_text_2numbers_styled( sString gxt, Int number1, Int number2, Int time, Int textStyle ) { AppendLine( Opcodes._036D, gxt, number1, number2, time, textStyle ); }
        /// <summary>
        /// The models can be set to -1 for any ped and -2 for any vehicle.
        /// </summary>
        public static void start_rampage( sString gxt, Int weaponNumber, Int timeLimit, Int totalTargets, Int model1, Int model2, Int model3, Int model4, Int completed_bool ) { AppendLine( Opcodes._01F9, gxt, weaponNumber, timeLimit, totalTargets, model1, model2, model3, model4, completed_bool ); }
        public static void show_text_2numbers_highpriority( sString gxt, Int number1, Int number2, Int time, Int textStyle ) { AppendLine( Opcodes._02FD, gxt, number1, number2, time, textStyle ); }
        public static void show_text_3numbers_lowpriority( sString gxt, Int number1, Int number2, Int number3, Int time, Int textStyle ) { AppendLine( Opcodes._02FF, gxt, number1, number2, number3, time, textStyle ); }
        public static void show_text_4numbers_lowpriority( sString gxt, Int number1, Int number2, Int number3, Int number4, Int time, Int textStyle ) { AppendLine( Opcodes._0302, gxt, number1, number2, number3, number4, time, textStyle ); }
        public static void show_text_6numbers_lowpriority( sString gxt, Int number1, Int number2, Int number3, Int number4, Int number5, Int number6, Int time, Int textStyle ) { AppendLine( Opcodes._0308, gxt, number1, number2, number3, number4, number5, number6, time, textStyle ); }
        public static void chdir( Int mode ) { AppendLine( Opcodes._0A99, mode ); }
        public static void chdir( vString path ) { AppendLine( Opcodes._0A99, path ); }
        public static void get_key_state( Int key, Out<Int> state ) { AppendLine( Opcodes._00E2, key, state ); }
        public static void get_active_interior( Out<Int> interiorID ) { AppendLine( Opcodes._077E, interiorID ); }
        public static void get_weekday( Out<Int> dayID ) { AppendLine( Opcodes._07D0, dayID ); }
        public static void get_total_tags_sprayed( Out<Int> count ) { AppendLine( Opcodes._08E1, count ); }
        public static void get_territories_controlled_percentage( Out<Int> percent ) { AppendLine( Opcodes._08E2, percent ); }
        public static void get_respect( Out<Int> count ) { AppendLine( Opcodes._0956, count ); }
        public static void get_current_language( Out<Int> langID ) { AppendLine( Opcodes._09FB, langID ); }
        public static void get_vehicle_model_price( Int vehicleModel, Out<Int> price ) { AppendLine( Opcodes._09E1, vehicleModel, price ); }
        public static void get_hash_key( vString str, Out<Int> hash ) { AppendLine( Opcodes._09A9, str, hash ); }
        public static void get_random_vehicle_model_in_memory( Int state_bool, Out<Int> modelID, Out<Int> vehicleClass ) { AppendLine( Opcodes._09B2, state_bool, modelID, vehicleClass ); }
        public static void get_soundtrack_status( Out<Int> status ) { AppendLine( Opcodes._0953, status ); }
        public static void get_hud_color( Int hudId_byte, Out<Int> r, Out<Int> g, Out<Int> b, Out<Int> alpha ) { AppendLine( Opcodes._0904, hudId_byte, r, g, b, alpha ); }
        public static void get_current_zone_type( Out<Int> zoneType ) { AppendLine( Opcodes._08D3, zoneType ); }
        public static void get_current_date( Out<Int> monthDay, Out<Int> month ) { AppendLine( Opcodes._0835, monthDay, month ); }
        public static void get_town_number_from_coords( Float x, Float y, Float z, Out<Int> townNumber ) { AppendLine( Opcodes._07EF, x, y, z, townNumber ); }
        public static void get_model_dimensions( Int modelID, Out<Float> cornerA_x, Out<Float> cornerA_y, Out<Float> cornerA_z, Out<Float> cornerB_x, Out<Float> cornerB_y, Out<Float> cornerB_z ) { AppendLine( Opcodes._07E4, modelID, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void get_active_shop_name( Out<sString> nameGXT ) { AppendLine( Opcodes._07B0, nameGXT ); }
        public static void get_dance_track_proximity( Int trackID, Out<Int> flag1, Out<Int> flag2, Out<Int> flag3 ) { AppendLine( Opcodes._07B1, trackID, flag1, flag2, flag3 ); }
        public static void get_crane_magnet_attached_entities<T>( Object hMagnetObject, T hVehicle, Actor hActor, Object hObject ) where T : Vehicle<T> { AppendLine( Opcodes._0798, hMagnetObject, hVehicle, hActor, hObject ); }
        public static void get_number_of_fires_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Out<Int> total ) { AppendLine( Opcodes._0786, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, total ); }
        public static void get_weapon_model( Int weaponNumber, Out<Int> weaponModel ) { AppendLine( Opcodes._0781, weaponNumber, weaponModel ); }
        public static void get_weapon_group( Int weaponNumber, Out<Int> weaponSlot ) { AppendLine( Opcodes._0782, weaponNumber, weaponSlot ); }
        public static void get_vehicle_model_name( Int vehicleModelId, Out<vString> name ) { AppendLine( Opcodes._0ADB, name, vehicleModelId ); }
        public static void get_mouse_movement( Out<Float> x, Out<Float> y ) { AppendLine( Opcodes._0A4A, x, y ); }
        public static void get_water_height( Float x, Float y, Int ignoreWaves_bool, Out<Float> height ) { AppendLine( Opcodes._092E, x, y, ignoreWaves_bool, height ); }
        public static void get_info_zone_name( Float x, Float y, Float z, Out<sString> nameGXT ) { AppendLine( Opcodes._08F1, x, y, z, nameGXT ); }
        public static void get_cutscene_offset( Out<Float> x, Out<Float> y, Out<Float> z ) { AppendLine( Opcodes._08D1, x, y, z ); }
        public static void get_noise_level( Actor hActorIfNeed, Float x, Float y, Float z, Out<Float> level ) { AppendLine( Opcodes._0855, hActorIfNeed, x, y, z, level ); }
        public static void get_zone_name( Float x, Float y, Float z, Out<sString> nameGXT ) { AppendLine( Opcodes._0843, x, y, z, nameGXT ); }
        public static void get_car_park_position_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Out<Float> x, Out<Float> y, Out<Float> z ) { AppendLine( Opcodes._0810, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, x, y, z ); }
        public static void get_nearest_tag_position( Float x, Float y, Float z, Out<Float> toX, Out<Float> toY, Out<Float> toZ ) { AppendLine( Opcodes._07A6, x, y, z, toX, toY, toZ ); }
        public static void get_crane_magnet_rope_height( Object hMagnetObject, Out<Float> laneLength ) { AppendLine( Opcodes._0796, hMagnetObject, laneLength ); }
        public static void get_zone_dealer_density( sString zoneGXT, Out<Int> density ) { AppendLine( Opcodes._076B, zoneGXT, density ); }
        public static void get_joystick_data_position( Out<Float> moveAxisX, Out<Float> moveAxisY, Out<Float> specialAxisX, Out<Float> specialAxisY ) { AppendLine( Opcodes._0494, 0, moveAxisX, moveAxisY, specialAxisX, specialAxisY ); }
        public static void get_closest_straight_road( Float x, Float y, Float z, Float minHeight, Float maxHeight, Out<Float> param1, Out<Float> param2, Out<Float> param3, Out<Float> param4, Out<Float> param5, Out<Float> param6, Out<Float> param7 ) { AppendLine( Opcodes._04B9, x, y, z, minHeight, maxHeight, param1, param2, param3, param4, param5, param6, param7 ); }
        public static void get_nearest_vehicle_path_coords( Float x, Float y, Float z, Int nth, Out<Float> toX, Out<Float> toY, Out<Float> toZ ) { AppendLine( Opcodes._04D3, x, y, z, nth, toX, toY, toZ ); }
        public static void get_distance_2d( Float fromX, Float fromY, Float toX, Float toY, Out<Float> distance ) { AppendLine( Opcodes._0509, distance, fromX, fromY, toX, toY ); }
        public static void get_distance_3d( Float fromX, Float fromY, Float fromZ, Float toX, Float toY, Float toZ, Out<Float> distance ) { AppendLine( Opcodes._050A, distance, fromX, fromY, fromZ, toX, toY, toZ ); }
        public static void get_max_wanted_level( Out<Int> level ) { AppendLine( Opcodes._050F, level ); }
        public static void get_current_radio_station( Out<Int> radioStationID ) { AppendLine( Opcodes._051E, radioStationID ); }
        public static void get_progress_percentage( Out<Float> percentage ) { AppendLine( Opcodes._058C, percentage ); }
        public static void get_angle_between_2d_vectors( Float x1, Float y1, Float x2, Float y2, Out<Float> angle ) { AppendLine( Opcodes._05A4, x1, y1, x2, y2, angle ); }
        public static void get_angle_from_point_2d( Float x, Float y, Out<Float> angle ) { AppendLine( Opcodes._0604, x, y, angle ); }
        public static void get_int_stat( Int statID, Out<Int> val ) { AppendLine( Opcodes._0652, val, statID ); }
        public static void get_float_stat( Int statID, Out<Float> val ) { AppendLine( Opcodes._0653, val, statID ); }
        public static void get_tag_status( Float cornerA_x, Float cornerA_y, Float cornerB_x, Float cornerB_y, Out<Int> status ) { AppendLine( Opcodes._0702, status, cornerA_x, cornerA_y, cornerB_x, cornerB_y ); }
        public static void get_number_of_fires_in_point_3d( Float x, Float y, Float z, Float radius, Out<Int> total ) { AppendLine( Opcodes._06C3, x, y, z, radius, total ); }
        public static void get_closest_vehicle_node_with_angle( Float x, Float y, Float z, Int direction, Out<Float> toX, Out<Float> toY, Out<Float> toZ, Out<Float> z_angle ) { AppendLine( Opcodes._06F8, x, y, z, direction, toX, toY, toZ, z_angle ); }
        public static void get_price_of_item( Int menuItemID, Out<Int> price ) { AppendLine( Opcodes._0761, menuItemID, price ); }
        public static void get_shopping_extra_info( Int menuItemID, Int statNumber, Out<Int> statValue ) { AppendLine( Opcodes._0783, menuItemID, statNumber, statValue ); }
        public static void get_name_of_item( Int menuItemID, Out<sString> name ) { AppendLine( Opcodes._078C, menuItemID, name ); }
        public static void get_number_of_items_in_shop( Out<Int> total ) { AppendLine( Opcodes._075F, total ); }
        public static void get_item_in_shop( Int currentShopID, Out<Int> item ) { AppendLine( Opcodes._0760, currentShopID, item ); }
        public static void get_vehicle_mod_type( Int carComponentID, Out<Int> type ) { AppendLine( Opcodes._06E6, carComponentID, type ); }
        public static void get_zone_gang_density( sString zoneGXT, Int gangType, Out<Int> density ) { AppendLine( Opcodes._076D, zoneGXT, gangType, density ); }
        public static void metres_to_feet( Float meters, Out<Float> feet ) { AppendLine( Opcodes._0925, feet, meters ); }
        public static void get_rid_of_player_prostitute() { AppendLine( Opcodes._0A43 ); }
        public static void release_textures() { AppendLine( Opcodes._0391 ); }
        public static void player_entered_dock_crane() { AppendLine( Opcodes._079D ); }
        public static void player_entered_buildingsite_crane() { AppendLine( Opcodes._079E ); }
        public static void player_entered_quarry_crane() { AppendLine( Opcodes._07F9 ); }
        public static void player_entered_las_vegas_crane() { AppendLine( Opcodes._07FA ); }
        public static void player_left_crane() { AppendLine( Opcodes._079F ); }
        public static void save_player_clothes() { AppendLine( Opcodes._0793 ); }
        public static void restore_player_clothes() { AppendLine( Opcodes._0794 ); }
        public static void reset_random_models_for_car_park() { AppendLine( Opcodes._0734 ); }
        public static void set_next_day() { AppendLine( Opcodes._088E ); }
        public static void take_photo() { AppendLine( Opcodes._0A1E, true ); }
        public static void set_radio_to_favorite_station() { AppendLine( Opcodes._0A26 ); }
        public static void finish_setting_up_conversation_no_subtitles() { AppendLine( Opcodes._0A47 ); }
        public static void manage_all_population() { AppendLine( Opcodes._0A13 ); }
        public static void detonate_all_satchel_charges() { AppendLine( Opcodes._09D9 ); }
        public static void suspend_wanted_level() { AppendLine( Opcodes._09D4 ); }
        public static void fail_rampage() { AppendLine( Opcodes._09C2 ); }
        public static void unmark_all_road_nodes_as_dont_wander() { AppendLine( Opcodes._0995 ); }
        public static void remove_references_to_all_fires() { AppendLine( Opcodes._0986 ); }
        public static void emulated_wasted_busted() { AppendLine( Opcodes._0974 ); }
        public static void sync_water() { AppendLine( Opcodes._0971 ); }
        public static void teleport_to_next_restart() { AppendLine( Opcodes._0970 ); }
        public static void store_car_mod_state() { AppendLine( Opcodes._096B ); }
        public static void restore_car_mod_state() { AppendLine( Opcodes._096C ); }
        public static void play_soundtrack() { AppendLine( Opcodes._0954 ); }
        public static void stop_soundtrack() { AppendLine( Opcodes._0955 ); }
        public static void clear_skip() { AppendLine( Opcodes._0951 ); }
        public static void set_weather_to_appropriate_type_now() { AppendLine( Opcodes._0915 ); }
        public static void clear_specific_zones_to_trigger_gang_war() { AppendLine( Opcodes._090D ); }
        public static void make_player_group_disappear() { AppendLine( Opcodes._08F5 ); }
        public static void make_player_group_reappear() { AppendLine( Opcodes._08F6 ); }
        public static void init_zone_population_settings() { AppendLine( Opcodes._08CA ); }
        public static void define_new_animation_path() { AppendLine( Opcodes._0754 ); }
        public static void fail_current_mission() { AppendLine( Opcodes._045C ); }
        public static void clear_all_roadblocks() { AppendLine( Opcodes._04C1 ); }
        public static void remove_rc_buggy() { AppendLine( Opcodes._04DB ); }
        public static void register_oddjob_mission_passed() { AppendLine( Opcodes._0595 ); }
        public static void clear_scmpath() { AppendLine( Opcodes._05D6 ); }
        public static void release_path_nodes() { AppendLine( Opcodes._0607 ); }
        public static void remove_references_all_trains() { AppendLine( Opcodes._06DA ); }
        public static void destroy_defined_trains() { AppendLine( Opcodes._06D9 ); }
        public static void destroy_all_trains() { AppendLine( Opcodes._06DB ); }
        public static void finish_setting_up_conversation() { AppendLine( Opcodes._0719 ); }
        public static void release_two_player_distance() { AppendLine( Opcodes._06F2 ); }
        public static void clear_loaded_shop() { AppendLine( Opcodes._087C ); }
        public static void force_weather( Int weather ) { AppendLine( Opcodes._01B5, weather ); }
        public static void set_weather( Int weather ) { AppendLine( Opcodes._01B6, weather ); }
        public static void load_txd_dictionary( sString txdName ) { AppendLine( Opcodes._0390, txdName ); }
        public static void load_texture( vString textureName, Int number ) { AppendLine( Opcodes._038F, textureName, number ); }
        public static void set_status_text_stay_on_screen( Int state_bool ) { AppendLine( Opcodes._09EE, state_bool ); }
        public static void request_ipl( vString IPL ) { AppendLine( Opcodes._0776, IPL ); }
        public static void remove_ipl( vString IPL ) { AppendLine( Opcodes._0777, IPL ); }
        public static void remove_ipl_discreetly( vString IPL ) { AppendLine( Opcodes._0778, IPL ); }
        public static void shake_player_controller( Int time, Int intensity ) { AppendLine( Opcodes._015B, time, intensity ); }
        public static void disable_entrance_markers( Int state_bool ) { AppendLine( Opcodes._08E7, state_bool ); }
        public static void restart_if_wasted( Float x, Float y, Float z, Float angle, Int townNumber ) { AppendLine( Opcodes._016C, x, y, z, angle, townNumber ); }
        public static void restart_if_busted( Float x, Float y, Float z, Float angle, Int townNumber ) { AppendLine( Opcodes._016D, x, y, z, angle, townNumber ); }
        public static void draw_shadow( Int shadowType_byte, Float x, Float y, Float z, Float angle, Float size, Int intensity_byte, Int r_byte, Int g_byte, Int b_byte ) { AppendLine( Opcodes._016F, shadowType_byte, x, y, z, angle, size, intensity_byte, r_byte, g_byte, b_byte ); }
        public static void disable_random_model_for_car_park( Int vehicleModel ) { AppendLine( Opcodes._0732, vehicleModel ); }
        public static void enable_random_model_for_car_park( Int vehicleModel ) { AppendLine( Opcodes._0733, vehicleModel ); }
        public static void set_gang_weapons( Int gangId, Int weaponNumber1, Int weaponNumber2, Int weaponNumber3 ) { AppendLine( Opcodes._0237, gangId, weaponNumber1, weaponNumber2, weaponNumber3 ); }
        public static void load_special_actor( sString name, Int number ) { AppendLine( Opcodes._023C, name, number ); }
        public static void show_text_4numbers_highpriority( sString gxt, Int number1, Int number2, Int number3, Int number4, Int time, Int style ) { AppendLine( Opcodes._0303, gxt, number1, number2, number3, number4, time, style ); }
        public static void draw_sphere( Float x, Float y, Float z, Float radius ) { AppendLine( Opcodes._03A1, x, y, z, radius ); }
        public static void load_wav( Int ID, Int toNumber ) { AppendLine( Opcodes._03CF, ID, toNumber ); }
        public static void set_wav_location( Int number, Float x, Float y, Float z ) { AppendLine( Opcodes._03D7, number, x, y, z ); }
        public static void unload_wav( Int number ) { AppendLine( Opcodes._040D, number ); }
        public static void load_path( Int pathID ) { AppendLine( Opcodes._07C0, pathID ); }
        public static void enable_hud( Int state_bool ) { AppendLine( Opcodes._0826, state_bool ); }
        public static void release_path( Int pathID ) { AppendLine( Opcodes._0873, pathID ); }
        public static void enable_night_vision( Int state_bool ) { AppendLine( Opcodes._08B1, state_bool ); }
        public static void enable_thermal_vision( Int state_bool ) { AppendLine( Opcodes._08B2, state_bool ); }
        public static void show_entered_vehicle_name( Int state_bool ) { AppendLine( Opcodes._09B9, state_bool ); }
        public static void show_entered_zone_name( Int state_bool ) { AppendLine( Opcodes._09BA, state_bool ); }
        public static void enable_menu_access_in_widescreen_mode( Int state_bool ) { AppendLine( Opcodes._0A48, state_bool ); }
        public static void enable_prostitutes_pay_you( Int state_bool ) { AppendLine( Opcodes._0A3D, state_bool ); }
        public static void disable_all_vehicle_lights( Int state_bool ) { AppendLine( Opcodes._0A37, state_bool ); }
        public static void show_highpriority_text_before_fade( Int state_bool ) { AppendLine( Opcodes._0A2C, state_bool ); }
        public static void show_styled_text_before_fade( Int state_bool ) { AppendLine( Opcodes._0A2D, state_bool ); }
        public static void set_up_conversation_end_node_with_scripted_speech( sString gxtName, Int dialogID ) { AppendLine( Opcodes._0A3C, gxtName, dialogID ); }
        public static void set_script_coop_game( Int state_bool ) { AppendLine( Opcodes._0A3F, state_bool ); }
        public static void disable_military_zones( Int state_bool ) { AppendLine( Opcodes._0A24, state_bool ); }
        public static void increment_float_stat_no_message( Int statID, Float value ) { AppendLine( Opcodes._0A1F, statID, value ); }
        public static void set_up_skip_for_vehicle_finished_by_script<T>( Float x, Float y, Float z, Float angle, T hVehicle ) where T : Vehicle<T> { AppendLine( Opcodes._0A35, x, y, z, angle, hVehicle ); }
        public static void display_non_minigame_help_messages( Int state_bool ) { AppendLine( Opcodes._0A44, state_bool ); }
        public static void set_railtrack_resistance_mult( Float friction ) { AppendLine( Opcodes._0A45, friction ); }
        public static void switch_external_scripts_triggers_type( Int scriptType, Int state_bool ) { AppendLine( Opcodes._0A46, scriptType, state_bool ); }
        public static void display_zone_text( vString gxtName ) { AppendLine( Opcodes._0A19, gxtName ); }
        public static void set_up_conversation_node_with_scripted_speech( sString questionGXT, sString answerYesGXT, sString answerNoGXT, Int questionDialogID, Int answerYesDialogID, Int answerNoDialogID ) { AppendLine( Opcodes._0A18, questionGXT, answerYesGXT, answerNoGXT, questionDialogID, answerYesDialogID, answerNoDialogID ); }
        public static void link_wav_to_vehicle<T>( Int number, T hVehicle ) where T : Vehicle<T> { AppendLine( Opcodes._0A16, number, hVehicle ); }
        public static void increment_int_stat_no_message( Int statID, Int value ) { AppendLine( Opcodes._0A10, statID, value ); }
        public static void clear_text_with_style( Int state_bool ) { AppendLine( Opcodes._0A0E, state_bool ); }
        public static void set_rendering_origin_at_3d_coord( Float x, Float y, Float z, Float angle ) { AppendLine( Opcodes._0A0B, x, y, z, angle ); }
        public static void set_respawn_point_for_duration_of_mission( Float x, Float y, Float z ) { AppendLine( Opcodes._09FF, x, y, z ); }
        public static void shut_all_actors_up( Int state_bool ) { AppendLine( Opcodes._09F5, state_bool ); }
        public static void enable_burglary_houses( Int state_bool ) { AppendLine( Opcodes._09E6, state_bool ); }
        public static void draw_flash_light_at( Float x, Float y, Float z, Int R_byte, Int G_byte, Int B_byte, Float radius ) { AppendLine( Opcodes._09E5, x, y, z, R_byte, G_byte, B_byte, radius ); }
        public static void set_aircraft_carrier_sam_site( Int state_bool ) { AppendLine( Opcodes._09E4, state_bool ); }
        public static void set_up_skip_for_specific_vehicle<T>( Float x, Float y, Float z, Float angle, T hVehicle ) where T : Vehicle<T> { AppendLine( Opcodes._09E0, x, y, z, angle, hVehicle ); }
        public static void make_interior_in_player_group_for_mission_peds( Int state_bool ) { AppendLine( Opcodes._09DD, state_bool ); }
        public static void disable_2nd_pad_for_debug( Int state_bool ) { AppendLine( Opcodes._09D8, state_bool ); }
        public static void set_cops_chase_criminals( Int state_bool ) { AppendLine( Opcodes._09D2, state_bool ); }
        public static void add_next_message_to_previous_briefs( Int state_bool ) { AppendLine( Opcodes._09C1, state_bool ); }
        public static void set_random_traffic_spawn_to_model( Int vehicleModel ) { AppendLine( Opcodes._09BF, vehicleModel ); }
        public static void set_minigame_in_progress( Int state_bool ) { AppendLine( Opcodes._09BD, state_bool ); }
        public static void hide_map_icons( Int state_bool ) { AppendLine( Opcodes._09AC, state_bool ); }
        public static void set_up_conversation_end_node_with_speech( sString gxtName, Int dialogID ) { AppendLine( Opcodes._09AA, gxtName, dialogID ); }
        public static void show_markers_on_all_interiors( Int state_bool ) { AppendLine( Opcodes._09A6, state_bool ); }
        public static void set_up_conversation_node_with_speech( sString questionGXT, sString answerYesGXT, sString answerNoGXT, Int questionDialogID, Int answerYesDialogID, Int answerNoDialogID ) { AppendLine( Opcodes._09A4, questionGXT, answerYesGXT, answerNoGXT, questionDialogID, answerYesDialogID, answerNoDialogID ); }
        public static void draw_crosshair( Int state_bool ) { AppendLine( Opcodes._09A3, state_bool ); }
        public static void disable_cops_in_zone( sString zoneGXT, Int state_bool ) { AppendLine( Opcodes._09B7, zoneGXT, state_bool ); }
        public static void set_up_skip_after_mission( Float x, Float y, Float z, Float angle ) { AppendLine( Opcodes._09AF, x, y, z, angle ); }
        public static void set_closest_entry_exit_flag( Float x, Float y, Float radius, Int bitmask16384, Int state_bool ) { AppendLine( Opcodes._09B4, x, y, radius, bitmask16384, state_bool ); }
        public static void set_create_random_cops( Int state_bool ) { AppendLine( Opcodes._099E, state_bool ); }
        public static void set_total_respect_points( Int maxValue ) { AppendLine( Opcodes._0997, maxValue ); }
        public static void add_respect( Int value ) { AppendLine( Opcodes._0998, value ); }
        public static void mark_road_node_as_dont_wander( Float x, Float y, Float z ) { AppendLine( Opcodes._0994, x, y, z ); }
        public static void set_gunshot_sense_range_for_riot2( Int state_bool ) { AppendLine( Opcodes._098A, state_bool ); }
        public static void set_interior_bitmask( sString interiorName, Int bitMask512, Int state_bool ) { AppendLine( Opcodes._098E, interiorName, bitMask512, state_bool ); }
        public static void set_text_boxes_width( Int width ) { AppendLine( Opcodes._0989, width ); }
        public static void set_only_create_gang_members( Int state_bool ) { AppendLine( Opcodes._0983, state_bool ); }
        public static void extinguish_fire_at_point( Float x, Float y, Float z, Float radius ) { AppendLine( Opcodes._0980, x, y, z, radius ); }
        public static void link_wav_to_object( Int number, Object hObject ) { AppendLine( Opcodes._097C, number, hObject ); }
        public static void play_audio_event_at_position( Float x, Float y, Float z, Int eventID ) { AppendLine( Opcodes._097A, x, y, z, eventID ); }
        public static void play_audio_event_at_object( Object hObject, Int eventID ) { AppendLine( Opcodes._097B, hObject, eventID ); }
        public static void enable_police_helis( Int state_bool ) { AppendLine( Opcodes._096A, state_bool ); }
        public static void draw_smoke( Float x, Float y, Float z, Float velocityX, Float velocityY, Float velocityZ, Float R, Float G, Float B, Float A, Float size, Float lastFactor ) { AppendLine( Opcodes._095C, x, y, z, velocityX, velocityY, velocityZ, R, G, B, A, size, lastFactor ); }
        public static void load_soundtrack( Int trackID ) { AppendLine( Opcodes._0952, trackID ); }
        public static void pause_soundtrack( Int state_bool ) { AppendLine( Opcodes._0991, state_bool ); }
        public static void set_up_skip( Float x, Float y, Float z, Float angle ) { AppendLine( Opcodes._0950, x, y, z, angle ); }
        public static void link_wav_to_actor( Int number, Actor hActor ) { AppendLine( Opcodes._0949, number, hActor ); }
        public static void create_explosion_variable_shake( Int type, Float x, Float y, Float z, Float cameraShake ) { AppendLine( Opcodes._0948, x, y, z, type, cameraShake ); }
        public static void set_darkness_effect( Int enable_bool, Int alpha ) { AppendLine( Opcodes._0924, enable_bool, alpha ); }
        public static void enable_planes_traffic( Int state_bool ) { AppendLine( Opcodes._0923, state_bool ); }
        public static void switch_roads_back_to_original( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._091D, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void switch_ped_roads_back_to_original( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._091E, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void enable_audio_zone( sString zoneGXT, Int state_bool ) { AppendLine( Opcodes._0917, zoneGXT, state_bool ); }
        public static void set_specific_zone_to_trigger_gang_war( sString zoneGXT ) { AppendLine( Opcodes._090C, zoneGXT ); }
        public static void display_stat_update_box( Int state_bool ) { AppendLine( Opcodes._08F8, state_bool ); }
        public static void set_heathaze_effect( Int state_bool ) { AppendLine( Opcodes._08FD, state_bool ); }
        public static void set_max_group_members( Int size_byte ) { AppendLine( Opcodes._08F4, size_byte ); }
        public static void append_model_to_next_cutscene( sString modelName, sString textureName ) { AppendLine( Opcodes._08F0, modelName, textureName ); }
        public static void add_sparks( Float x, Float y, Float z, Float velocityInDirection_X, Float velocityInDirection_Y, Float velocityInDirection_Z, Int density ) { AppendLine( Opcodes._08EB, x, y, z, velocityInDirection_X, velocityInDirection_Y, velocityInDirection_Z, density ); }
        public static void set_create_random_gang_members( Int state_bool ) { AppendLine( Opcodes._08EA, state_bool ); }
        public static void attach_anims_to_model<T>( Int actorModel ) where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            AppendLine( Opcodes._08E8, script.ScriptName, actorModel );
        }
        public static void lose_stuff_after_wasted( Int state_bool ) { AppendLine( Opcodes._08DD, state_bool ); }
        public static void lose_stuff_after_busted( Int state_bool ) { AppendLine( Opcodes._08DE, state_bool ); }
        public static void set_extra_hospital_restart_point( Float x, Float y, Float z, Float radius, Float angle ) { AppendLine( Opcodes._08DF, x, y, z, radius, angle ); }
        public static void set_extra_police_station_restart_point( Float x, Float y, Float z, Float radius, Float angle ) { AppendLine( Opcodes._08E0, x, y, z, radius, angle ); }
        public static void set_text_formatting( Int flag_bool, Int leftMargin, Int maxWidth ) { AppendLine( Opcodes._0912, flag_bool, leftMargin, maxWidth ); }
        public static void set_zone_for_gang_wars_training( sString zoneGXT ) { AppendLine( Opcodes._08B3, zoneGXT ); }
        public static void set_gang_wars_training_mission( Int state_bool ) { AppendLine( Opcodes._08AC, state_bool ); }
        public static void set_always_draw_3d_markers( Int state_bool ) { AppendLine( Opcodes._08A8, state_bool ); }
        public static void can_trigger_gang_war_when_on_a_mission( Int state_bool ) { AppendLine( Opcodes._08A3, state_bool ); }
        public static void enable_crane_controls( Int up_bool, Int down_bool, Int release_bool ) { AppendLine( Opcodes._0898, up_bool, down_bool, release_bool ); }
        public static void set_uses_collision_of_closest_object_of_type( Float x, Float y, Float z, Float radius, Int objectModelID, Int collisionDetection_bool ) { AppendLine( Opcodes._088D, x, y, z, radius, objectModelID, collisionDetection_bool ); }
        public static void enable_gang_wars( Int state_bool ) { AppendLine( Opcodes._0879, state_bool ); }
        public static void create_birds_in_area_3d( Float cornerA_X, Float cornerA_Y, Float cornerA_Z, Float cornerB_X, Float cornerB_Y, Float cornerB_Z, Int flag1, Int flag2 ) { AppendLine( Opcodes._0876, cornerA_X, cornerA_Y, cornerA_Z, cornerB_X, cornerB_Y, cornerB_Z, flag1, flag2 ); }
        public static void set_zone_popcycle_group_for_peds( sString zoneGXT, Int actorGroup ) { AppendLine( Opcodes._0874, zoneGXT, actorGroup ); }
        public static void set_interior_player_group_warping( Float x, Float y, Float radius, Int access_bool ) { AppendLine( Opcodes._0864, x, y, radius, access_bool ); }
        public static void create_emergency_services_vehicle( Int emergencyCarModelID, Float x, Float y, Float z ) { AppendLine( Opcodes._085A, emergencyCarModelID, x, y, z ); }
        public static void activate_interior_actors( Int state_bool ) { AppendLine( Opcodes._084D, state_bool ); }
        public static void set_pool_table_coords( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._0830, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void set_max_fire_generations( Int count ) { AppendLine( Opcodes._0828, count ); }
        public static void add_unique_jump( Float startX, Float startY, Float startZ, Float radiusX, Float radiusY, Float radiusZ, Float landX, Float landY, Float landZ, Float cameraX, Float cameraY, Float cameraZ, Int reward ) { AppendLine( Opcodes._0814, startX, startY, startZ, radiusX, radiusY, radiusZ, landX, landY, landZ, cameraX, cameraY, cameraZ, reward ); }
        public static void remove_oil_puddles_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { AppendLine( Opcodes._07DF, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static void set_interior_access( sString interiorNameGXT, Int state_bool ) { AppendLine( Opcodes._07FB, interiorNameGXT, state_bool ); }
        public static void set_area51_sam_site( Int state_bool ) { AppendLine( Opcodes._07A8, state_bool ); }
        public static void set_next_desired_move_state( Int state ) { AppendLine( Opcodes._07A1, state ); }
        public static void lock_door_object( Object hDoorObject, Int state_bool ) { AppendLine( Opcodes._0905, hDoorObject, state_bool ); }
        public static void set_crane_magnet_rope_height( Object hMagnetObject, Float laneLength ) { AppendLine( Opcodes._0797, hMagnetObject, laneLength ); }
        public static void release_entity_from_magnet( Object hMagnetObject ) { AppendLine( Opcodes._0799, hMagnetObject ); }
        public static void set_next_vehicle_model_numplate_town( Int vehicleModel, Int townTexture ) { AppendLine( Opcodes._0771, vehicleModel, townTexture ); }
        public static void set_zone_popcycle_group_for_peds_and_vehicles( sString zoneGXT, Int zoneType ) { AppendLine( Opcodes._0767, zoneGXT, zoneType ); }
        public static void set_zone_dealer_density( sString zoneGXT, Int density ) { AppendLine( Opcodes._076A, zoneGXT, density ); }
        public static void set_zone_gang_density( sString zoneGXT, Int gangType, Int density ) { AppendLine( Opcodes._076C, zoneGXT, gangType, density ); }
        public static void set_radar_zoom( Int zoom ) { AppendLine( Opcodes._075B, zoom ); }
        public static void add_path_node_with_animation( Float x, Float y, Float z, vString animationName, vString IFP ) { AppendLine( Opcodes._0755, x, y, z, animationName, IFP ); }
        public static void set_radio_station( Int radioStation ) { AppendLine( Opcodes._041E, radioStation, "" ); }
        public static void set_interpolation_parameters( Float delay, Int time ) { AppendLine( Opcodes._0460, delay, time ); }
        public static void enable_rc_detonation( Int state_bool ) { AppendLine( Opcodes._048A, state_bool ); }
        public static void enable_rc_detonation_on_contact( Int state_bool ) { AppendLine( Opcodes._04D6, state_bool ); }
        public static void select_interior( Int interiorID ) { AppendLine( Opcodes._04BB, interiorID ); }
        public static void create_roadblock( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Int type ) { AppendLine( Opcodes._04C0, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, type ); }
        public static void draw_weaponshop_corona( Float x, Float y, Float z, Float radius, Int type_byte, Int lensflares_byte, Int r_byte, Int g_byte, Int b_byte ) { AppendLine( Opcodes._04D5, x, y, z, radius, type_byte, lensflares_byte, r_byte, g_byte, b_byte ); }
        public static void refresh_game_renderer( Float x, Float y ) { AppendLine( Opcodes._04E4, x, y ); }
        public static void set_extra_colors( Int color, Int fade_bool ) { AppendLine( Opcodes._04F9, color, fade_bool ); }
        public static void clear_extra_colors( Int fade_bool ) { AppendLine( Opcodes._04FA, fade_bool ); }
        public static void add_police_trigger_in_area_2d( Int minWantedLevel_byte, Float cornerA_X, Float cornerA_Y, Float cornerB_X, Float cornerB_Y, Float spawn1X, Float spawn1Y, Float headedTowards1_X, Float headedTowards1_Y, Float spawn2X, Float spawn2Y, Float headedTowards2_X, Float headedTowards2_Y ) { AppendLine( Opcodes._04F8, minWantedLevel_byte, cornerA_X, cornerA_Y, cornerB_X, cornerB_Y, spawn1X, spawn1Y, headedTowards1_X, headedTowards1_Y, spawn2X, spawn2Y, headedTowards2_X, headedTowards2_Y ); }
        public static void set_next_vehicle_model_variation( Int vehicleModel, Int variation ) { AppendLine( Opcodes._0506, vehicleModel, variation, variation ); }
        public static void show_permanent_text_box( sString gxtName ) { AppendLine( Opcodes._0512, gxtName ); }
        public static void show_permanent_text_box_1number( sString gxtName, Int number ) { AppendLine( Opcodes._0513, gxtName, number ); }
        public static void use_gxt_table( sString gxtTableName ) { AppendLine( Opcodes._054C, gxtTableName ); }
        public static void create_explosion_no_sound( Int type, Float x, Float y, Float z ) { AppendLine( Opcodes._0565, x, y, z, type ); }
        public static void set_radar_grey( Int state_bool ) { AppendLine( Opcodes._057E, state_bool ); }
        public static void enable_radar( Int state_bool ) { AppendLine( Opcodes._0581, state_bool ); }
        public static void enable_taxi_nitros( Int state_bool ) { AppendLine( Opcodes._0572, state_bool ); }
        public static void register_best_position( Int statID, Int value ) { AppendLine( Opcodes._0582, statID, value ); }
        public static void add_gun_flash( Float fromX, Float fromY, Float fromZ, Float toX, Float toY, Float toZ ) { AppendLine( Opcodes._058A, fromX, fromY, fromZ, toX, toY, toZ ); }
        public static void shuffle_card_decks( Int count ) { AppendLine( Opcodes._059D, count ); }
        public static void fetch_next_card( Int card ) { AppendLine( Opcodes._059E, card ); }
        public static void add_point_to_scmpath( Float x, Float y, Float z ) { AppendLine( Opcodes._05D7, x, y, z ); }
        public static void load_path_nodes_in_area_2d( Float cornerA_X, Float cornerA_Y, Float cornerB_X, Float cornerB_Y ) { AppendLine( Opcodes._0606, cornerA_X, cornerA_Y, cornerB_X, cornerB_Y ); }
        public static void increment_int_stat( Int statID, Int value ) { AppendLine( Opcodes._0623, value, statID ); }
        public static void increment_float_stat( Int statID, Float value ) { AppendLine( Opcodes._0624, value, statID ); }
        public static void decrement_int_stat( Int statID, Int value ) { AppendLine( Opcodes._0625, statID, value ); }
        public static void decrement_float_stat( Int statID, Float value ) { AppendLine( Opcodes._0626, statID, value ); }
        public static void register_int_stat( Int statID, Int value ) { AppendLine( Opcodes._0627, value, statID ); }
        public static void register_float_stat( Int statID, Float value ) { AppendLine( Opcodes._0628, value, statID ); }
        public static void set_int_stat( Int statID, Int value ) { AppendLine( Opcodes._0629, statID, value ); }
        public static void set_float_stat( Int statID, Float value ) { AppendLine( Opcodes._062A, statID, value ); }
        public static void enable_train_traffic( Int state_bool ) { AppendLine( Opcodes._06D7, state_bool ); }
        public static void set_next_vehicle_model_numplate_text( Int vehicleModel, vString text ) { AppendLine( Opcodes._0674, vehicleModel, text ); }
        public static void display_timer_bars( Int state_bool ) { AppendLine( Opcodes._06CF, state_bool ); }
        public static void enable_police_bikes( Int state_bool ) { AppendLine( Opcodes._072C, state_bool ); }
        public static void enable_riot( Int state_bool ) { AppendLine( Opcodes._06C8, state_bool ); }
        public static void enable_emergency_traffic( Int state_bool ) { AppendLine( Opcodes._06D0, state_bool ); }
        public static void set_players_can_be_in_separate_vehicles( Int state_bool ) { AppendLine( Opcodes._06FA, state_bool ); }
        public static void set_players_can_target_eachother( Int state_bool ) { AppendLine( Opcodes._06F3, state_bool ); }
        public static void set_2_player_distance_limit( Float distanceLimit ) { AppendLine( Opcodes._06F1, distanceLimit ); }
        public static void set_tags_status_in_area( Float cornerA_X, Float cornerA_Y, Float cornerB_X, Float cornerB_Y, Int percent ) { AppendLine( Opcodes._0703, cornerA_X, cornerA_Y, cornerB_X, cornerB_Y, percent ); }
        public static void fire_single_bullet( Float fromX, Float fromY, Float fromZ, Float toX, Float toY, Float toZ, Int damageEnergy ) { AppendLine( Opcodes._06BC, fromX, fromY, fromZ, toX, toY, toZ, damageEnergy ); }
        public static void set_acquaintance( Int acquaintanceType_byte, Int ofActorType, Int toActorType ) { AppendLine( Opcodes._0746, acquaintanceType_byte, ofActorType, toActorType ); }
        public static void clear_acquaintance( Int acquaintanceType_byte, Int ofActorType, Int toActorType ) { AppendLine( Opcodes._0747, acquaintanceType_byte, ofActorType, toActorType ); }
        public static void load_prices( vString name ) { AppendLine( Opcodes._075D, name ); }
        public static void load_shop( vString name ) { AppendLine( Opcodes._075E, name ); }
        public static void add_price_modifier( Int menuItemID, Int price ) { AppendLine( Opcodes._08C8, menuItemID, price ); }
        public static void remove_price_modifier( Int menuItemID ) { AppendLine( Opcodes._08C9, menuItemID ); }
        public static void buy_item( Int menuItemID ) { AppendLine( Opcodes._0790, menuItemID ); }
        public static void get_text_by_GXT_entry( Out<Memory> entry, vString customGXTKey ) { AppendLine( Opcodes._0ADE, entry, customGXTKey ); }
        public static void show_custom_text_box( vString text ) { AppendLine( Opcodes._0ACA, text ); }
        public static void show_custom_text_styled( vString text, Int time, Int textStyle ) { AppendLine( Opcodes._0ACB, text, time, textStyle ); }
        public static void load_car_component( Int carComponentModelID ) { AppendLine( Opcodes._06E9, carComponentModelID ); }
        public static void load_car_component( Int[] carComponentModelsID ) {
            for( int i = 0; i < carComponentModelsID.Length; i++ )
                AppendLine( Opcodes._06E9, carComponentModelsID[ i ] );
        }
        public static void load_car_component( Int carComponentModelID, params Int[] carComponentModelsID ) {
            AppendLine( Opcodes._06E9, carComponentModelID );
            for( int i = 0; i < carComponentModelsID.Length; i++ )
                AppendLine( Opcodes._06E9, carComponentModelsID[ i ] );
        }
        public static void release_car_component( Int carComponentModelID ) { AppendLine( Opcodes._06EB, carComponentModelID ); }
        public static void release_car_component( Int[] carComponentModelsID ) {
            for( int i = 0; i < carComponentModelsID.Length; i++ )
                AppendLine( Opcodes._06EB, carComponentModelsID[ i ] );
        }
        public static void release_car_component( Int carComponentModelID, params Int[] carComponentModelsID ) {
            AppendLine( Opcodes._06EB, carComponentModelID );
            for( int i = 0; i < carComponentModelsID.Length; i++ )
                AppendLine( Opcodes._06EB, carComponentModelsID[ i ] );
        }
        public static void load_animation( vString IFPName ) { AppendLine( Opcodes._04ED, IFPName ); }
        public static void load_animation( vString[] IFPNames ) {
            for( int i = 0; i < IFPNames.Length; i++ )
                AppendLine( Opcodes._04ED, IFPNames[ i ] );
        }
        public static void load_animation( vString IFPName, params vString[] IFPNames ) {
            AppendLine( Opcodes._04ED, IFPName );
            for( int i = 0; i < IFPNames.Length; i++ )
                AppendLine( Opcodes._04ED, IFPNames[ i ] );
        }
        public static void release_animation( vString IFPName ) { AppendLine( Opcodes._04EF, IFPName ); }
        public static void release_animation( vString[] IFPNames ) {
            for( int i = 0; i < IFPNames.Length; i++ )
                AppendLine( Opcodes._04EF, IFPNames[ i ] );
        }
        public static void release_animation( vString IFPName, params vString[] IFPNames ) {
            AppendLine( Opcodes._04EF, IFPName );
            for( int i = 0; i < IFPNames.Length; i++ )
                AppendLine( Opcodes._04EF, IFPNames[ i ] );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Condition is_scan_string_format( Out<Int> count, vString str, vString textFormat, params Parameter[] args ) {
            if( args.Length > Parameter.LIMIT )
                throw new Exception( Localization.ParametersOverflowCount( nameof( is_scan_string_format ), Parameter.LIMIT ) );
            StringBuilder stringBuilder = new StringBuilder();
            for( int i = 0; i < args.Length; i++ )
                stringBuilder.AppendFormat( " {0}", args[ i ] );
            return new Condition( Opcodes._0AD4, count, str, textFormat, stringBuilder.ToString() );
        }
        public static Condition is_car_component_available( Int carComponentModelID ) { return new Condition( Opcodes._06EA, carComponentModelID ); }
        public static Condition[] is_car_component_available( Int[] carComponentModelsID ) {
            if( carComponentModelsID.Length == 0 )
                throw new Exception( Localization.ParametersCountIsZero( nameof( is_car_component_available ) ) );
            var cd = new Condition[ carComponentModelsID.Length ];
            for( int i = 0; i < carComponentModelsID.Length; i++ )
                cd[ i ] = new Condition( Opcodes._06EA, carComponentModelsID[ i ] );
            return cd;
        }
        public static Condition[] is_car_component_available( Int carComponentModelID, params Int[] carComponentModelsID ) {
            if( carComponentModelsID.Length == 0 )
                return new[] { new Condition( Opcodes._06EA, carComponentModelID ) };
            var cd = new Condition[ carComponentModelsID.Length ];
            for( int i = 0; i < carComponentModelsID.Length; i++ )
                cd[ i ] = new Condition( Opcodes._06EA, carComponentModelsID[ i ] );
            Array.Resize( ref cd, cd.Length + 1 );
            cd[ cd.Length - 1 ] = new Condition( Opcodes._06EA, carComponentModelID );
            return cd;
        }
        public static Condition is_animation_loaded( vString IFPName ) { return new Condition( Opcodes._04EE, IFPName ); }
        public static Condition[] is_animation_loaded( vString[] IFPNames ) {
            if( IFPNames.Length == 0 )
                throw new Exception( Localization.ParametersCountIsZero( nameof( is_animation_loaded ) ) );
            var cd = new Condition[ IFPNames.Length ];
            for( int i = 0; i < IFPNames.Length; i++ )
                cd[ i ] = new Condition( Opcodes._04EE, IFPNames[ i ] );
            return cd;
        }
        public static Condition[] is_animation_loaded( vString IFPName, params vString[] IFPNames ) {
            if( IFPNames.Length == 0 )
                return new[] { new Condition( Opcodes._04EE, IFPName ) };
            var cd = new Condition[ IFPNames.Length ];
            for( int i = 0; i < IFPNames.Length; i++ )
                cd[ i ] = new Condition( Opcodes._04EE, IFPNames[ i ] );
            Array.Resize( ref cd, cd.Length + 1 );
            cd[ cd.Length - 1 ] = new Condition( Opcodes._04EE, IFPName );
            return cd;
        }
        public static Condition is_australian_game_version() { return new Condition( Opcodes._059A ); }
        public static Condition is_cutscene_skipped() { return new Condition( Opcodes._056A ); }
        public static Condition is_cutscene_loaded() { return new Condition( Opcodes._06B9 ); }
        public static Condition is_pc_version() { return new Condition( Opcodes._0485 ); }
        public static Condition is_text_priority_displayed() { return new Condition( Opcodes._076F ); }
        public static Condition is_two_players_game_going_on() { return new Condition( Opcodes._0800 ); }
        public static Condition is_gang_war_going_on() { return new Condition( Opcodes._087A ); }
        public static Condition is_skip_cutscene_button_pressed() { return new Condition( Opcodes._08D0 ); }
        public static Condition is_text_box_displayed() { return new Condition( Opcodes._08FE ); }
        public static Condition is_night_vision_active() { return new Condition( Opcodes._099D ); }
        public static Condition is_minigame_in_progress() { return new Condition( Opcodes._09BE ); }
        public static Condition is_subtitles_switched_on() { return new Condition( Opcodes._09C8 ); }
        public static Condition is_gang_war_fighting_going_on() { return new Condition( Opcodes._0A03 ); }
        public static Condition is_skip_waiting_for_script_to_fade_in() { return new Condition( Opcodes._0A36 ); }
        public static Condition is_widescreen_on_in_options() { return new Condition( Opcodes._0A2B ); }
        public static Condition is_pc_using_joypad() { return new Condition( Opcodes._0A4B ); }
        public static Condition is_mouse_using_vertical_inversion() { return new Condition( Opcodes._0A4C ); }
        public static Condition is_game_just_returned_from_frontend() { return new Condition( Opcodes._09FA ); }
        public static Condition is_language_changed() { return new Condition( Opcodes._0A0F ); }
        public static Condition get_2d_lines_intersect_point( Float param1, Float param2, Float param3, Float param4, Float param5, Float param6, Float param7, Float param8, Out<Float> param9, Out<Float> param10 ) { return new Condition( Opcodes._05B0, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10 ); }
        public static Condition store_target_marker_coords( Out<Float> x, Out<Float> y, Out<Float> z ) { return new Condition( Opcodes._0AB6, x, y, z ); }
        public static Condition find_file( SearchFile hSearchFile, vString mask, Out<vString> fileName ) { return new Condition( Opcodes._0AE6, hSearchFile, mask, fileName ); }
        public static Condition is_player_bought_item( Int menuItemID ) { return new Condition( Opcodes._0942, menuItemID ); }
        public static Condition is_closest_object_of_type_smashed_or_damaged( Int objectModelID_int, Float x_float, Float y_float, Float z_float, Float radius_float, Int smashed_bool, Int damaged_bool ) { return new Condition( Opcodes._0716, objectModelID_int, x_float, y_float, z_float, radius_float, smashed_bool, damaged_bool ); }
        public static Condition is_no_obstacles( Float fromX_float, Float fromY_float, Float fromZ_float, Float toX_float, Float toY_float, Float toZ_float, Int solid_bool, Int vehicle_bool, Int actor_bool, Int object_bool, Int particle_bool ) { return new Condition( Opcodes._06BD, fromX_float, fromY_float, fromZ_float, toX_float, toY_float, toZ_float, solid_bool, vehicle_bool, actor_bool, object_bool, particle_bool ); }
        public static Condition is_police_vehicle_in_area_3d_no_save( Float cornerA_X_float, Float cornerA_Y_float, Float cornerA_Z_float, Float cornerB_X_float, Float cornerB_Y_float, Float cornerB_Z ) { return new Condition( Opcodes._09C3, cornerA_X_float, cornerA_Y_float, cornerA_Z_float, cornerB_X_float, cornerB_Y_float, cornerB_Z ); }
        public static Condition do_2d_rectangles_collide( Float centerX_float, Float centerY_float, Float centerScaleX_float, Float centerScaleY_float, Float overlapingCenterX_float, Float overlapingCenterY_float, Float overlapingScaleX_float, Float overlapingScaleY ) { return new Condition( Opcodes._05A5, centerX_float, centerY_float, centerScaleX_float, centerScaleY_float, overlapingCenterX_float, overlapingCenterY_float, overlapingScaleX_float, overlapingScaleY ); }
        public static Condition is_any_pickup_near_point_3d( Float x_float, Float y_float, Float z ) { return new Condition( Opcodes._048C, x_float, y_float, z ); }
        public static Condition is_flame_in_angled_area_2d( Float cornerA_x_float, Float cornerA_y_float, Float cornerB_x_float, Float cornerB_y_float, Float angle_float, Int shpere_bool ) { return new Condition( Opcodes._072D, cornerA_x_float, cornerA_y_float, cornerB_x_float, cornerB_y_float, angle_float, shpere_bool ); }
        public static Condition is_flame_in_angled_area_3d( Float cornerA_x_float, Float cornerA_y_float, Float cornerA_z_float, Float cornerB_x_float, Float cornerB_y_float, Float cornerB_z_float, Float angle_float, Int shpere_bool ) { return new Condition( Opcodes._072E, cornerA_x_float, cornerA_y_float, cornerA_z_float, cornerB_x_float, cornerB_y_float, cornerB_z_float, angle_float, shpere_bool ); }
        public static Condition is_acquaintance_set( Int acquaintance_int, Int actorType_int, Int byActorType ) { return new Condition( Opcodes._07E8, acquaintance_int, actorType_int, byActorType ); }
        public static Condition is_has_object_of_type_been_smashed( Float x_float, Float y_float, Float z_float, Float radius_float, Int objectModelID ) { return new Condition( Opcodes._07F0, x_float, y_float, z_float, radius_float, objectModelID ); }
        public static Condition is_procedural_interior_active( Int interiorIDMaybe ) { return new Condition( Opcodes._0867, interiorIDMaybe ); }
        public static Condition is_money_pickup_at_coords( Float x_float, Float y_float, Float z ) { return new Condition( Opcodes._09DA, x_float, y_float, z ); }
        public static Condition is_text_box_displayed( sString gxtName ) { return new Condition( Opcodes._0A2A, gxtName ); }
        public static Condition is_path_available( Int pathID ) { return new Condition( Opcodes._07C1, pathID ); }
        public static Condition is_model_car( Int modelID ) { return new Condition( Opcodes._0A01, modelID ); }
        public static Condition is_model_boat( Int modelID ) { return new Condition( Opcodes._081E, modelID ); }
        public static Condition is_model_plane( Int modelID ) { return new Condition( Opcodes._081F, modelID ); }
        public static Condition is_model_heli( Int modelID ) { return new Condition( Opcodes._0820, modelID ); }
        public static Condition is_sphere_onscreen( Float x_float, Float y_float, Float z_float, Float radius ) { return new Condition( Opcodes._00C2, x_float, y_float, z_float, radius ); }
        public static Condition is_external_script_loaded<T>() where T : External, new() {
            var script = CreateExternalIfNotExist<T>();
            return new Condition( Opcodes._08AB, GetExternalFullName( script ) );
        }
        public static Condition directory_exists( vString path ) { return new Condition( Opcodes._0AE4, path ); }
        public static Condition ini_read_string( Out<vString> result, vString path, vString section, vString key ) { return new Condition( Opcodes._0AF4, result, path, section, key ); }
        public static Condition is_model_exists( Int modelID ) { return new Condition( Opcodes._0488, modelID ); }
        public static Condition is_model_available( Int modelID ) { return new Condition( Opcodes._0248, modelID ); }
        public static Condition[] is_model_available( Int[] modelsID ) {
            if( modelsID.Length == 0 )
                throw new Exception( Localization.ParametersCountIsZero( nameof( is_model_available ) ) );
            var cd = new Condition[ modelsID.Length ];
            for( int i = 0; i < modelsID.Length; i++ )
                cd[ i ] = new Condition( Opcodes._0248, modelsID[ i ] );
            return cd;
        }
        public static Condition[] is_model_available( Int modelID, params Int[] modelsID ) {
            if( modelsID.Length == 0 )
                return new[] { new Condition( Opcodes._0248, modelID ) };
            var cd = new Condition[ modelsID.Length ];
            for( int i = 0; i < modelsID.Length; i++ )
                cd[ i ] = new Condition( Opcodes._0248, modelsID[ i ] );
            Array.Resize( ref cd, cd.Length + 1 );
            cd[ cd.Length - 1 ] = new Condition( Opcodes._0248, modelID );
            return cd;
        }
        public static Condition is_test_cheat( vString str ) { return new Condition( Opcodes._0ADC, str ); }
        public static Condition is_original_game_version() { return new Condition( Opcodes._0AA9 ); }
        public static Condition is_key_pressed( Int VKey ) { return new Condition( Opcodes._0AB0, VKey ); }
        public static Condition is_game_key_pressed( Int gameKey ) { return new Condition( Opcodes._00E1, gameKey ); }
        public static Condition is_any_vehicle_cheats_activated() { return new Condition( Opcodes._0445 ); }
        public static Condition is_credits_finished() { return new Condition( Opcodes._0436 ); }
        public static Condition is_system_metric() { return new Condition( Opcodes._0A4D ); }
        public static Condition is_japanese_game_version() { return new Condition( Opcodes._0424 ); }
        public static Condition is_french_game_version() { return new Condition( Opcodes._040B ); }
        public static Condition is_german_game_version() { return new Condition( Opcodes._040C ); }
        public static Condition is_save_done() { return new Condition( Opcodes._03D9 ); }
        public static Condition is_wav_loaded( Int wavNumber ) { return new Condition( Opcodes._03D0, wavNumber ); }
        public static Condition is_wav_ended( Int wavNumber ) { return new Condition( Opcodes._03D2, wavNumber ); }
        public static Condition is_any_entity_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._038A, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        //public static Condition is_sniper_bullet_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._037E, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static Condition is_explosion_in_area_3d( Int explosionType, Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._0356, explosionType, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static Condition is_anything_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z, Int solid_bool, Int car_bool, Int actor_bool, Int object_bool, Int particle_bool ) { return new Condition( Opcodes._0339, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z, solid_bool, car_bool, actor_bool, object_bool, particle_bool ); }
        public static Condition is_projectile_in_area_3d( Float cornerA_x, Float cornerA_y, Float cornerA_z, Float cornerB_x, Float cornerB_y, Float cornerB_z ) { return new Condition( Opcodes._02EE, cornerA_x, cornerA_y, cornerA_z, cornerB_x, cornerB_y, cornerB_z ); }
        public static Condition is_special_actor_loaded( Int actorNumber ) { return new Condition( Opcodes._023D, actorNumber ); }
        public static Condition[] is_special_actor_loaded( Int[] modelsID ) {
            if( modelsID.Length == 0 )
                throw new Exception( Localization.ParametersCountIsZero( nameof( is_special_actor_loaded ) ) );
            var cd = new Condition[ modelsID.Length ];
            for( int i = 0; i < modelsID.Length; i++ )
                cd[ i ] = new Condition( Opcodes._023D, modelsID[ i ] );
            return cd;
        }
        public static Condition[] is_special_actor_loaded( Int actorNumber, params Int[] actorNumbers ) {
            if( actorNumbers.Length == 0 )
                return new[] { new Condition( Opcodes._023D, actorNumber ) };
            var cd = new Condition[ actorNumbers.Length ];
            for( int i = 0; i < actorNumbers.Length; i++ )
                cd[ i ] = new Condition( Opcodes._023D, actorNumbers[ i ] );
            Array.Resize( ref cd, cd.Length + 1 );
            cd[ cd.Length - 1 ] = new Condition( Opcodes._023D, actorNumber );
            return cd;
        }
        public static Condition is_cutscene_reached_end() { return new Condition( Opcodes._02E9 ); }
        public static Condition is_fading() { return new Condition( Opcodes._016B ); }
        public static Condition is_file_exists( vString path ) { return new Condition( Opcodes._0AAB, path ); }
        public static Condition delete_file( vString path ) { return new Condition( Opcodes._0B00, path ); }
        public static Condition delete_directory( vString path, Int includeSubdirs_bool ) { return new Condition( Opcodes._0B01, path, includeSubdirs_bool ); }
        public static Condition move_file( vString pathFrom, vString pathTo ) { return new Condition( Opcodes._0B02, pathFrom, pathTo ); }
        public static Condition move_directory( vString pathFrom, vString pathTo ) { return new Condition( Opcodes._0B03, pathFrom, pathTo ); }
        public static Condition copy_file( vString pathFrom, vString pathTo ) { return new Condition( Opcodes._0B04, pathFrom, pathTo ); }
        public static Condition copy_directory( vString pathFrom, vString pathTo ) { return new Condition( Opcodes._0B05, pathFrom, pathTo ); }
        public static Condition ini_read_int( Out<Int> result, vString path, vString section, vString key ) { return new Condition( Opcodes._0AF0, result, path, section, key ); }
        public static Condition ini_read_float( Out<Float> result, vString path, vString section, vString key ) { return new Condition( Opcodes._0AF2, result, path, section, key ); }
        public static Condition ini_write_int( Int val, vString path, vString section, vString key ) { return new Condition( Opcodes._0AF1, val, path, section, key ); }
        public static Condition ini_write_float( Float val, vString path, vString section, vString key ) { return new Condition( Opcodes._0AF3, val, path, section, key ); }
        public static Condition ini_write_string( vString val, vString path, vString section, vString key ) { return new Condition( Opcodes._0AF5, val, path, section, key ); }
        #endregion

        //----------------------------------------------------------------------------------------------------

        #region BUILDER HELPERS
        internal static Thread CreateThreadIfNotExist<T>() where T : Thread, new() {
            Script thisScript = Current;
            ushort localAutoIndex = LocalVariable.AUTO_INDEX;
            ushort localAutoIndexLimit = LocalVariable.LIMIT;
            LocalVariable.AUTO_INDEX = 0;
            Generator.SetupLocalVariablesLimits( TypeOfScript.THREAD );
            errors.Clear();
            thisScript.isInit = false;
            T script = new T();
            thisScript.isInit = true;
            if( script.ScriptName == "MAIN" )
                throw new Exception( Localization.ThreadMAINNotFound() );
            AddAndPrintScript( script );
            Current = thisScript;
            LocalVariable.AUTO_INDEX = localAutoIndex;
            LocalVariable.LIMIT = localAutoIndexLimit;
            return script;
        }
        internal static MissionCustom CreateMissionIfNotExist<T>() where T : MissionCustom, new() {
            Script thisScript = Current;
            ushort localAutoIndex = LocalVariable.AUTO_INDEX;
            ushort localAutoIndexLimit = LocalVariable.LIMIT;
            LocalVariable.AUTO_INDEX = 34;
            Generator.SetupLocalVariablesLimits( TypeOfScript.MISSION );
            errors.Clear();
            thisScript.isInit = false;
            T script = new T();
            thisScript.isInit = true;
            AddAndPrintScript( script );
            Current = thisScript;
            LocalVariable.AUTO_INDEX = localAutoIndex;
            LocalVariable.LIMIT = localAutoIndexLimit;
            return script;
        }
        internal static External CreateExternalIfNotExist<T>() where T : External, new() {
            Script thisScript = Current;
            ushort localAutoIndex = LocalVariable.AUTO_INDEX;
            ushort localAutoIndexLimit = LocalVariable.LIMIT;
            LocalVariable.AUTO_INDEX = 0;
            Generator.SetupLocalVariablesLimits( TypeOfScript.EXTERNAL );
            errors.Clear();
            thisScript.isInit = false;
            T script = new T();
            thisScript.isInit = true;
            AddAndPrintScript( script );
            Current = thisScript;
            LocalVariable.AUTO_INDEX = localAutoIndex;
            LocalVariable.LIMIT = localAutoIndexLimit;
            return script;
        }
        internal static Function CreateFunctionIfNotExist<T>() where T : Function, new() {
            Script thisScript = Current;
            ushort localAutoIndex = LocalVariable.AUTO_INDEX;
            ushort localAutoIndexLimit = LocalVariable.LIMIT;
            LocalVariable.AUTO_INDEX = 0;
            Generator.SetupLocalVariablesLimits( TypeOfScript.FUNCTION );
            errors.Clear();
            thisScript.isInit = false;
            T script = new T();
            thisScript.isInit = true;
            if( script.ScriptName == "MAIN" )
                throw new Exception( Localization.ThreadMAINNotFound() );
            AddAndPrintScript( script );
            Current = thisScript;
            LocalVariable.AUTO_INDEX = localAutoIndex;
            LocalVariable.LIMIT = localAutoIndexLimit;
            return script;
        }
        internal static string GetExternalFullName( External external ) { return $"{allScripts[ external ]} ({external.ScriptName})"; }

        internal static void AddAndPrintScript( Script script ) {
            if( !allScripts.ContainsKey( script ) ) {
                int tmp = -1;
                switch( script.ScriptType ) {
                    case TypeOfScript.MISSION:
                    MissionHeader.AppendLine( $"DEFINE MISSION {MissionCounter} AT @{script.ScriptName}_ERROR_SKIP\t\t\t// {MissionCounter}" );
                    tmp = MissionCounter;
                    MissionCounter += 1;
                    break;
                    case TypeOfScript.EXTERNAL:
                    ExternalHeader.AppendLine( $"DEFINE SCRIPT {script.ScriptName} AT @{script.ScriptName}_ERROR_SKIP\t\t\t// {ExternalCounter}" );
                    tmp = ExternalCounter;
                    ExternalCounter += 1;
                    break;
                }
                Localization.PrintScriptStart( script.ScriptName );
                allScripts.Add( script, tmp );
                script.BeforeStart();
                var startLabel = new LabelJump( script, 0, true );
                script.jumps.Add( script.START, startLabel );
                script.START( startLabel );
                script.AfterStart();
                Localization.PrintScriptEnd( script.ScriptName );
            }
        }

        internal static void PrintMissionCodeBefore( MissionCustom script ) {
            MissionCustom.increment_mission_attempts();
            OnMission.value = true;
            gosub_custom();
            AppendLine( @"00D6: if
0112:     wasted_or_busted // mission only
004D: jump_if_false @{0}_{1}", script.ScriptName, "END" );
            gosub_custom( "FAILED" );
            label( $"{script.ScriptName}_END" );
            OnMission.value = false;
            MissionCustom.mission_cleanup();
            end_thread();
        }
        internal static void PrintMissionCodeAfter( Mission mission ) {
            label( $"{mission.ScriptName}_PASSED" );
            Mission.gosub_clear();
            if( mission.OnPassed != null )
                mission.OnPassed.Invoke();
            @return();

            label( $"{mission.ScriptName}_FAILED" );
            Mission.gosub_clear();
            if( mission.OnFailed != null )
                mission.OnFailed.Invoke();
            @return();

            label( $"{mission.ScriptName}_CLEAR" );
            if( mission.OnClear != null )
                mission.OnClear.Invoke();
            @return();
        }
        #endregion

        #region SCRIPT PROPERTY
        internal static int MissionCounter = 0;
        internal static int ExternalCounter = 0;

        internal static Script Current { get; set; }
        internal static void AppendLine( string format, params object[] args ) { Current.BuilderString.AppendFormat( $"{format}\n", args ); }
        internal static Dictionary<Script, int> allScripts = new Dictionary<Script, int>();
        internal static StringBuilder MissionHeader = new StringBuilder();
        internal static StringBuilder ExternalHeader = new StringBuilder();
        #endregion

        //----------------------------------------------------------------------------------------------------

        internal bool isInit = false;
        internal uint gosubsCounter = 0;
        internal uint cycleCounter = 0;
        internal uint jfCounter = 0;
        internal uint jumpsCounter = 0;
        internal uint scenesCounter = 0;
        internal uint switchCounter = 0;

        //----------------------------------------------------------------------------------------------------

        internal StringBuilder BuilderString;
        internal Dictionary<HandlerJump, LabelJump> jumps;
        internal Dictionary<HandlerGosub, LabelGosub> gosubs;
        internal TypeOfScript ScriptType { get; private set; }
        internal string ScriptName { get; private set; }

        //----------------------------------------------------------------------------------------------------

        public Script( TypeOfScript scriptType ) {
            Current = this;
            ScriptType = scriptType;
            jumps = new Dictionary<HandlerJump, LabelJump>();
            gosubs = new Dictionary<HandlerGosub, LabelGosub>();
            BuilderString = new StringBuilder();
            ScriptName = GetType().Name;
            if( scriptType == TypeOfScript.FUNCTION ) {
                if( this is ICustomFunction ) {
                    ScriptName = ScriptName.ToUpper();
                } else {
                    ScriptName = $"FUNCTION_{Function.Counter++}_{ScriptName.ToUpper()}";
                    if( !Regex.IsMatch( ScriptName, "^[A-Z_0-9]{1,}$", RegexOptions.Singleline | RegexOptions.Compiled ) )
                        throw new Exception( Localization.BadFunctionName( ScriptName ) );
                }
            } else {
                if( ScriptName.Length == 0 || ScriptName.Length > 7 )
                    throw new Exception( Localization.BadThreadNameLenght( ScriptName ) );
                if( ScriptName != ScriptName.ToUpper() )
                    throw new Exception( Localization.BadThreadName( ScriptName ) );
                if( !Regex.IsMatch( ScriptName, "^[A-Z_0-9]{1,7}$", RegexOptions.Singleline | RegexOptions.Compiled ) )
                    throw new Exception( Localization.BadThreadName( ScriptName ) );
            }
            LocalTimer1 = local( 0 );
            LocalTimer2 = local( 0 );
            LocalTimer1.Index = LocalVariable.LIMIT;
            LocalTimer2.Index = ( ushort ) ( LocalVariable.LIMIT + 1 );
            if( ScriptType == TypeOfScript.MISSION ) {
                LocalTimer1.Index = 32;
                LocalTimer2.Index = 33;
            }
            LocalTimer1.SetName();
            LocalTimer2.SetName();
            if( Generator.tmpUseAutomaticVariableInitialization )
                autoDefinedVariables();
        }

        private void autoDefinedVariables() {
            var fields = GetType().GetRuntimeFields().ToArray();
            for( int i = 0; i < fields.Length; i++ ) {
                var reflectedType = fields[ i ].FieldType;
                if( !reflectedType.IsClass )
                    continue;
                var defaultValue = fields[ i ].GetValue( this );
                if( !ReferenceEquals( defaultValue, null ) ) {
                    if( reflectedType.GetInterface( typeof( IArray ).FullName ) != null ) {
                        var array = ( IArray ) fields[ i ].GetValue( this );
                        if( array.IsAutoDefined ) {
                            var arrayConstructor = reflectedType.GetConstructor( BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof( VariableContext ), typeof( ushort ), typeof( ushort ), typeof( bool ) }, null );
                            object arrayInstance = null;
                            if( fields[ i ].IsStatic ) {
                                arrayInstance = arrayConstructor.Invoke( BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { VariableContext.GLOBAL, global().index, array.AutoDefineSize, true }, null );
                            } else {
                                arrayInstance = arrayConstructor.Invoke( BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { VariableContext.LOCAL, local().index, array.AutoDefineSize, true }, null );
                            }
                            fields[ i ].SetValue( this, arrayInstance );
                        }
                    }
                    if( reflectedType.GetInterface( typeof( IUnion ).FullName ) != null )
                        ( ( IUnion ) fields[ i ].GetValue( this ) ).Init( fields[ i ].IsStatic );
                    continue;
                }
                object instance = null;
                ConstructorInfo constructor = null;
                if( reflectedType.GetInterface( typeof( IUnion ).FullName ) != null ) {
                    instance = Activator.CreateInstance( reflectedType );
                    ( ( IUnion ) instance ).Init( fields[ i ].IsStatic );
                    fields[ i ].SetValue( this, instance );
                    continue;
                }
                if( reflectedType.GetInterface( typeof( IVariable ).FullName ) == null )
                    continue;
                if( reflectedType == typeof( sString ) || reflectedType == typeof( vString ) ) {
                    constructor = reflectedType.GetConstructor( BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof( VariableContext ), typeof( ushort ), typeof( bool ) }, null );
                    if( fields[ i ].IsStatic ) {
                        instance = constructor.Invoke( BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { VariableContext.GLOBAL, global().index, true }, null );
                    } else {
                        instance = constructor.Invoke( BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { VariableContext.LOCAL, local().index, true }, null );
                    }
                } else {
                    constructor = reflectedType.GetConstructor( BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof( VariableContext ), typeof( ushort ) }, null );
                    if( fields[ i ].IsStatic ) {
                        instance = constructor.Invoke( BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { VariableContext.GLOBAL, global().index }, null );
                    } else {
                        if( reflectedType.GetInterface( typeof( INotLocal ).FullName ) != null ) {
                            errors.Add( Localization.UseVariableAsStaticOnly( fields[ i ].Name ) );
                            return;
                        }
                        instance = constructor.Invoke( BindingFlags.NonPublic | BindingFlags.Instance, null, new object[] { VariableContext.LOCAL, local().index }, null );
                    }
                }
                fields[ i ].SetValue( this, instance );
            }
        }

        //----------------------------------------------------------------------------------------------------

        public abstract void START( LabelJump label );

        //----------------------------------------------------------------------------------------------------

        internal virtual void BeforeStart() {
            printError();
            switch( ScriptType ) {
                case TypeOfScript.THREAD:
                BuilderString.Append( $"\n//------------- THREAD {ScriptName} ---------------" );
                label( Current.ScriptName );
                AppendLine( Opcodes._03A4, $"'{ScriptName}'" );
                if( ScriptName == "MAIN" ) {
                    set_on_mission_flag();
                    set_wasted_busted_check( false );
                    DefaultWaitTime.value = Generator.DefaultWaitTime;
                    AppendLine( Opcodes._0002, $"{ScriptName}_SKIP_SCM_FUNC" );
                    AppendLine( Generator.MESSAGE_FUNCTION_NOT_FOUND );
                    label( $"{ScriptName}_SKIP_SCM_FUNC" );
                    AppendLine( Generator.MESSAGE_EXTERNAL_SCRIPT_NOT_FOUND );
                }
                break;
                case TypeOfScript.EXTERNAL:
                BuilderString.Append( $"\n//------------- EXTERNAL SCRIPT: {allScripts[ this ]} ({ScriptName}) ---------------" );
                label( $"{ScriptName}_ERROR_SKIP" );
                AppendLine( Opcodes._03A4, $"'{ScriptName}'" );
                label( Current.ScriptName );
                break;
                case TypeOfScript.FUNCTION:
                label( $"{Current.ScriptName}" );
                break;
            }
        }
        internal virtual void AfterStart() {
            var startJumpIndex = 0;
            var lastJumpIndex = jumps.Count;
            var startGosubIndex = 0;
            var lastGosubIndex = gosubs.Count;

            print_labels:
            for( int i = startGosubIndex; i < lastGosubIndex; i++ ) {
                var gos = gosubs.ElementAt( i );
                label( gos.Value );
                gos.Key.Invoke( gos.Value );
                @return();
            }
            for( int i = startJumpIndex; i < lastJumpIndex; i++ ) {
                var jump = jumps.ElementAt( i );
                if( jump.Value.isSkipped )
                    continue;
                label( jump.Value );
                jump.Key.Invoke( jump.Value );
            }
            if( jumps.Count > lastJumpIndex || gosubs.Count > lastGosubIndex ) {
                startJumpIndex = lastJumpIndex;
                lastJumpIndex = jumps.Count;
                startGosubIndex = lastGosubIndex;
                lastGosubIndex = gosubs.Count;
                goto print_labels;
            }
        }
        internal void printError() {
            isInit = true;
            if( errors.Count > 0 )
                throw new Exception( errors[ 0 ] );
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return ScriptName; }
        [Obsolete()]
        public override bool Equals( object obj ) { return ScriptName == ( ( Script ) obj ).ScriptName; }
        [Obsolete()]
        public override int GetHashCode() { return ScriptName.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

    //----------------------------------------------------------------------------------------------------

    public delegate void HandlerCase( LabelCase l );
    public delegate void HandlerScene( LabelScene end_label );
    public delegate void HandlerSwitch( JumpTable table );

    //----------------------------------------------------------------------------------------------------

    public enum TypeOfScript { THREAD, MISSION, EXTERNAL, FUNCTION }

}