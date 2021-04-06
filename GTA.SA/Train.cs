using GTA.Core;

namespace GTA {

    public class Train : Handle<Train>, IArrayItem, IVariable {

        public static Int[] GetModelsByType( TrainType type ) {
            if( type == TrainType.TRAM || type == TrainType.TRAM2 )
                return new Int[ 1 ] { 449 }; // TRAM
            if( type == TrainType.STREAK )
                return new Int[ 1 ] { 538 }; // STREAK
            if( type == TrainType.STREAK_STREAKC2 || type == TrainType.STREAK_STREAKC3 )
                return new Int[ 2 ] { 538, 570 }; // STREAK, STREAKC
            return new Int[ 2 ] { 537, 569 }; // FREIGHT, FREIFLAT
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Train( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Train get_carriage( Int carriageNumber, Out<Carriage> hCarriage ) { Script.AppendLine( Opcodes._078A, hCarriage, this, carriageNumber ); return this; }
        public Train get_caboose( Out<Carriage> hCarriage ) { Script.AppendLine( Opcodes._06DE, hCarriage, this ); return this; }
        public Train create( Float x, Float y, Float z, Int trainType, Int direction_bool ) { Script.AppendLine( Opcodes._06D8, this, x, y, z, trainType, direction_bool ); return this; }
        public Train put_at_next_station() { Script.AppendLine( Opcodes._0A07, this ); return this; }
        public Train set_forced_to_slow_down( Int state_bool ) { Script.AppendLine( Opcodes._09CF, this, state_bool ); return this; }
        public Train set_position( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._07C7, this, x, y, z ); return this; }
        public Train destroy() { Script.AppendLine( Opcodes._07BD, this ); return this; }
        public Train remove_references() { Script.AppendLine( Opcodes._07BE, this ); return this; }
        public Train set_speed( Float accelerate ) { Script.AppendLine( Opcodes._06DC, this, accelerate ); return this; }
        public Train set_cruise_speed( Float speed ) { Script.AppendLine( Opcodes._06DD, this, speed ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_derailed() { return new Condition( Opcodes._0981, this ); }
        public Condition is_traveling_clockwise() { return new Condition( Opcodes._09E3, this ); }
        public Condition is_next_station_unlocked() { return new Condition( Opcodes._0A06, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Train( LocalVariable val ) { return new Train( VariableContext.LOCAL, val.index ); }
        public static implicit operator Train( GlobalVariable val ) { return new Train( VariableContext.GLOBAL, val.index ); }
        public static implicit operator Car( Train train ) { return new Car( train.Context, train.Index ); }

    }

}