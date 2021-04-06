using GTA.Core;

namespace GTA {

    public class Marker : BaseMarker<Marker>, IArrayItem, IVariable {

        internal Marker( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Marker set_radar_mode( Int radarMode ) { Script.AppendLine( Opcodes._018B, this, radarMode ); return this; }
        public Marker create_above_vehicle<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0186, check_OUT_Variable( this ), hVehicle ); return this; }
        public Marker create_above_actor( Actor hActor ) { Script.AppendLine( Opcodes._0187, check_OUT_Variable( this ), hActor ); return this; }
        public Marker create_above_object( Object hObject ) { Script.AppendLine( Opcodes._0188, check_OUT_Variable( this ), hObject ); return this; }
        public Marker create_above_pickup<T>( T hPickup ) where T : BasePickup<T> { Script.AppendLine( Opcodes._03DC, check_OUT_Variable( this ), hPickup ); return this; }
        public Marker set_color( Int markerColor ) { Script.AppendLine( Opcodes._0165, this, markerColor ); return this; }
        public Marker set_size( Int size ) { Script.AppendLine( Opcodes._0168, this, size ); return this; }
        public Marker create_above_dead_actor( Actor hActor ) { Script.AppendLine( Opcodes._0888, hActor, this ); return this; }
        public Marker create_above_searchlight( Searchlight hSearchlight ) { Script.AppendLine( Opcodes._06C4, hSearchlight, this ); return this; }
        public Marker set_type( Int friendly_bool ) { Script.AppendLine( Opcodes._07E0, this, friendly_bool ); return this; }
        public Marker always_display_on_zoomed_radar( Int state_bool ) { Script.AppendLine( Opcodes._07BF, this, state_bool ); return this; }
        
        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_enabled() { return new Condition( Opcodes._075C, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Marker( LocalVariable val ) { return new Marker( VariableContext.LOCAL, val.index ); }
        public static implicit operator Marker( GlobalVariable val ) { return new Marker( VariableContext.GLOBAL, val.index ); }

    }

}