using GTA.Core;

namespace GTA {

    public class RadarMarker : BaseMarker<RadarMarker>, IArrayItem, IVariable {

        internal RadarMarker( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public RadarMarker set_radar_mode( Int radarMode ) { Script.AppendLine( Opcodes._018B, this, radarMode ); return this; }
        public RadarMarker create_long_range( Int iconID, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._02A7, check_OUT_Variable( this ), iconID, x, y, z ); return this; }
        public RadarMarker create_long_range_for_mission( Int iconID, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._02A8, check_OUT_Variable( this ), iconID, x, y, z ); return this; }
        public RadarMarker create_short_range_for_mission( Int spriteIconMarker, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._04CE, this, spriteIconMarker, x, y, z, "" ); return this; }
        public RadarMarker create_short_range( Int spriteIconMarker, Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0570, this, spriteIconMarker, x, y, z, "" ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_enabled() { return new Condition( Opcodes._075C, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator RadarMarker( LocalVariable val ) { return new RadarMarker( VariableContext.LOCAL, val.index ); }
        public static implicit operator RadarMarker( GlobalVariable val ) { return new RadarMarker( VariableContext.GLOBAL, val.index ); }

    }

}