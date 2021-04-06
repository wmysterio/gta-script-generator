using System;
using GTA.Core.Languages;

namespace GTA.Core {

    internal static class Debug {

        internal const string COMPILLER_NAME = "JESSY";

        internal static void White( string message ) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( $"[FXT] {message}" );
        }
        internal static void Yellow( string message ) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( message );
        }
        internal static void Green( string message ) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( $"[{COMPILLER_NAME}] {message}" );
        }
        internal static void Error( string message ) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( $"[{COMPILLER_NAME}] {Localization.WordError}:\n\n{message}" );
        }
        internal static void Blue( string message ) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( $"[{COMPILLER_NAME}] {message}" );
        }
    
    }

}