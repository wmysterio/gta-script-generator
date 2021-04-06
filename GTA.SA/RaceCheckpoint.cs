using GTA.Core;

namespace GTA {

    public class RaceCheckpoint : BaseMarker<RaceCheckpoint>, IArrayItem, IVariable {

        internal RaceCheckpoint( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public RaceCheckpoint create( Float x, Float y, Float z, Float point_x, Float point_y, Float point_z, Int finish_bool, Float radius ) { Script.AppendLine( Opcodes._06D5, this, x, y, z, point_x, point_y, point_z, finish_bool, radius ); return this; }
        public RaceCheckpoint set_position( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._07F3, this, x, y, z ); return this; }
        public RaceCheckpoint set_z_angle( Float angle ) { Script.AppendLine( Opcodes._0996, this, angle ); return this; }
        public override RaceCheckpoint disable() { Script.AppendLine( Opcodes._06D6, this ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator RaceCheckpoint( LocalVariable val ) { return new RaceCheckpoint( VariableContext.LOCAL, val.index ); }
        public static implicit operator RaceCheckpoint( GlobalVariable val ) { return new RaceCheckpoint( VariableContext.GLOBAL, val.index ); }

    }

}