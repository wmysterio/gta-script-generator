using GTA.Core;

namespace GTA {

    public class DecisionMaker : DM<DecisionMaker>, IArrayItem, IVariable {

        internal DecisionMaker( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public override DecisionMaker clear_event_response( Int eventID ) {  Script.AppendLine( Opcodes._0708, eventID, this ); return this; }
        public DecisionMaker copy_from( Int mask ) {  Script.AppendLine( Opcodes._07E5, mask, this ); return this; }
        public DecisionMaker copy_shared_from( Int mask ) {  Script.AppendLine( Opcodes._0978, mask, this ); return this; }
        public DecisionMaker load( Int number ) {  Script.AppendLine( Opcodes._060A, number, this ); return this; }
        public override DecisionMaker add_event_response( Int eventID, Int taskID, Float respectPercentage, Float hatePercentage, Float likePercentage, Float dislikePercentage, Int inCar_bool, Int onFoot_bool ) {  Script.AppendLine( Opcodes._0709, this, eventID, taskID, respectPercentage, hatePercentage, likePercentage, dislikePercentage, inCar_bool, onFoot_bool ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator DecisionMaker( LocalVariable val ) { return new DecisionMaker( VariableContext.LOCAL, val.index ); }
        public static implicit operator DecisionMaker( GlobalVariable val ) { return new DecisionMaker( VariableContext.GLOBAL, val.index ); }

    }

}