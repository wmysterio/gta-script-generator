using GTA.Core;

namespace GTA {

    public class ColorPanel : Handle<ColorPanel>, IArrayItem, IVariable {

        internal ColorPanel( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public ColorPanel create( sString gxtHeader, Float x, Float y, Float width, Int columns_byte, Int interactive_bool, Int background_bool, Int alignment_byte ) { Script.AppendLine( Opcodes._0964, gxtHeader, x, y, width, columns_byte, interactive_bool, background_bool, alignment_byte, this ); return this; }
        public ColorPanel change_vehicle_color<T>( T hVehicle, Int colorSlot, Int activeRow ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0A22, this, hVehicle, colorSlot, activeRow ); return this; }
        public ColorPanel get_active_row( Out<Int> row ) { Script.AppendLine( Opcodes._08D7, row, this ); return this; }
        public ColorPanel remove() { Script.AppendLine( Opcodes._08DA, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator ColorPanel( LocalVariable val ) { return new ColorPanel( VariableContext.LOCAL, val.index ); }
        public static implicit operator ColorPanel( GlobalVariable val ) { return new ColorPanel( VariableContext.GLOBAL, val.index ); }

    }

}