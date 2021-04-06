using System;

namespace GTA.Core {

    public sealed class Drawing {

        internal static readonly Drawing instance = new Drawing();

        /// <summary>
        /// 640.0
        /// </summary>
        public double WIDTH { get; } = 640.0;
        /// <summary>
        /// 448.0
        /// </summary>
        public double HEIGHT { get; } = 448.0;

        private Drawing() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Drawing set_letter_scale( Float width, Float height ) { Script.AppendLine( Opcodes._033F, width, height ); return this; }
        public Drawing set_color( Int r_byte, Int g_byte, Int b_byte, Int a_byte ) { Script.AppendLine( Opcodes._0340, r_byte, g_byte, b_byte, a_byte ); return this; }
        public Drawing set_align_justify( Int state_bool ) { Script.AppendLine( Opcodes._0341, state_bool ); return this; }
        public Drawing set_align_centered( Int state_bool ) { Script.AppendLine( Opcodes._0342, state_bool ); return this; }
        public Drawing set_background( Int state_bool ) { Script.AppendLine( Opcodes._0345, state_bool ); return this; }
        public Drawing set_proportional( Int state_bool ) { Script.AppendLine( Opcodes._0348, state_bool ); return this; }
        public Drawing set_linewidth( Float width ) { Script.AppendLine( Opcodes._0343, width ); return this; }
        public Drawing set_linewidth_centered( Float width ) { Script.AppendLine( Opcodes._0344, width ); return this; }
        public Drawing set_font( Int font_byte ) { Script.AppendLine( Opcodes._0349, font_byte ); return this; }
        public Drawing set_text_draw_before_fade( Int state_bool ) { Script.AppendLine( Opcodes._03E0, state_bool ); return this; }
        public Drawing set_texture_draw_before_fade( Int state_bool ) { Script.AppendLine( Opcodes._03E3, state_bool ); return this; }
        public Drawing set_align_right( Int state_bool ) { Script.AppendLine( Opcodes._03E4, state_bool ); return this; }
        public Drawing enable( Int state_bool ) { Script.AppendLine( Opcodes._03F0, state_bool ); return this; }
        public Drawing display_text( Float x, Float y, sString gxt ) { Script.AppendLine( Opcodes._033E, x, y, gxt ); return this; }
        public Drawing display_texture( Int textureNumber, Float x, Float y, Float sizeX, Float sizeY, Int r_byte, Int g_byte, Int b_byte, Int a_byte ) { Script.AppendLine( Opcodes._038D, textureNumber, x, y, sizeX, sizeY, r_byte, g_byte, b_byte, a_byte ); return this; }
        public Drawing display_rectangle( Float x, Float y, Float sizeX, Float sizeY, Int r_byte, Int g_byte, Int b_byte, Int a_byte ) { Script.AppendLine( Opcodes._038E, x, y, sizeX, sizeY, r_byte, g_byte, b_byte, a_byte ); return this; }
        public Drawing display_box( Float cornerA_X, Float cornerA_Y, Float cornerB_X, Float cornerB_Y, sString titleGXT, Int style_byte ) { Script.AppendLine( Opcodes._0937, cornerA_X, cornerA_Y, cornerB_X, cornerB_Y, titleGXT, style_byte ); return this; }
        public Drawing display_text_with_float( Float x, Float y, sString gxt, Float number, Int amountAfterAComa_byte ) { Script.AppendLine( Opcodes._07FC, x, y, gxt, number, amountAfterAComa_byte ); return this; }
        public Drawing set_outline( Int size, Int r_byte, Int g_byte, Int b_byte, Int a_byte ) { Script.AppendLine( Opcodes._081C, size, r_byte, g_byte, b_byte, a_byte ); return this; }
        public Drawing display_text_with_1number( Float x, Float y, sString gxt, Int number ) { Script.AppendLine( Opcodes._045A, x, y, gxt, number ); return this; }
        public Drawing display_text_with_2numbers( Float x, Float y, sString gxt, Int number1, Int number2 ) { Script.AppendLine( Opcodes._045B, x, y, gxt, number1, number2 ); return this; }
        public Drawing set_text_shadow( Int size, Int r_byte, Int g_byte, Int b_byte, Int a_byte ) { Script.AppendLine( Opcodes._060D, size, r_byte, g_byte, b_byte, a_byte ); return this; }
        public Drawing display_texture_with_rotation( Int textureNumber, Float x, Float y, Float sizeX, Float sizeY, Float angle, Int r_byte, Int g_byte, Int b_byte, Int a_byte ) { Script.AppendLine( Opcodes._074B, textureNumber, x, y, sizeX, sizeY, angle, r_byte, g_byte, b_byte, a_byte ); return this; }

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