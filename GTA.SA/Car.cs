using GTA.Core;

namespace GTA {

    public class Car : Vehicle<Car>, IArrayItem, IVariable {

        private static Car any = null;
        static Car() {
            any = new GlobalVariable( 0 );
            any.Context = VariableContext.NONE;
            any.Name = "-1";
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Car empty { get { return any; } }

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Car( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Car drive_to( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._00A7, this, x, y, z ); return this; }
        public Car drive_accurate_to( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._02C2, this, x, y, z ); return this; }
        public Car set_cruise_speed( Float speed ) { Script.AppendLine( Opcodes._00AD, this, speed ); return this; }
        public Car set_taxi_light( Int state_bool ) { Script.AppendLine( Opcodes._0216, this, state_bool ); return this; }
        public Car play_animation( Int carAnimation, Int time ) { Script.AppendLine( Opcodes._0477, this, carAnimation, time ); return this; }
        public Car get_current_paintjob( Out<Int> paintjobNumber ) { Script.AppendLine( Opcodes._0988, this, paintjobNumber ); return this; }
        public Car get_number_of_paintjobs( Out<Int> count ) { Script.AppendLine( Opcodes._097D, this, count ); return this; }
        public Car get_component( Int slotID, Out<CarComponent> hComponent ) { Script.AppendLine( Opcodes._096D, this, slotID, hComponent ); return this; }
        public Car get_number_of_available_paintjobs( Out<Int> count ) { Script.AppendLine( Opcodes._06EC, this, count ); return this; }
        public Car add_single_nitro() { Script.AppendLine( Opcodes._09E9, this ); return this; }
        public Car reset_hydraulics() { Script.AppendLine( Opcodes._09FE, this ); return this; }
        public Car drive_racing_to( Float x, Float y, Float z ) { Script.AppendLine( Opcodes._0704, this, x, y, z ); return this; }
        public Car set_hydraulics( Int state_bool ) { Script.AppendLine( Opcodes._07FF, this, state_bool ); return this; }
        public Car control_hydraulics( Float LFWeel, Float RFWeel, Float LBWeel, Float RBWeel ) { Script.AppendLine( Opcodes._07F5, this, LFWeel, RFWeel, LBWeel, RBWeel ); return this; }
        public Car remove_component( Int slotID ) { Script.AppendLine( Opcodes._06E8, this, slotID ); return this; }
        public Car add_component( Int carComponentModel, CarComponent hComponent ) { Script.AppendLine( Opcodes._06E7, hComponent, carComponentModel, this ); return this; }
        public Car set_current_paintjob( Int paintjobIndex ) { Script.AppendLine( Opcodes._06ED, this, paintjobIndex ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Car( LocalVariable val ) { return new Car( VariableContext.LOCAL, val.index ); }
        public static implicit operator Car( GlobalVariable val ) { return new Car( VariableContext.GLOBAL, val.index ); }

    }

}