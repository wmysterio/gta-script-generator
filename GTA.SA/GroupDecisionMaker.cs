using GTA.Core;

namespace GTA {

    public class GroupDecisionMaker : DM<GroupDecisionMaker>, IArrayItem, IVariable {

        internal GroupDecisionMaker( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public override GroupDecisionMaker clear_event_response( Int eventID ) { Script.AppendLine( Opcodes._0749, eventID, this ); return this; }
        public GroupDecisionMaker copy_from( Int mask ) { Script.AppendLine( Opcodes._07E6, mask, this ); return this; }
        public GroupDecisionMaker load( Int number ) { Script.AppendLine( Opcodes._06AE, number, this ); return this; }
        public override GroupDecisionMaker add_event_response( Int eventID, Int taskID, Float respectPercentage, Float hatePercentage, Float likePercentage, Float dislikePercentage, Int inCar_bool, Int onFoot_bool ) { Script.AppendLine( Opcodes._074A, this, eventID, taskID, respectPercentage, hatePercentage, likePercentage, dislikePercentage, inCar_bool, onFoot_bool ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator GroupDecisionMaker( LocalVariable val ) { return new GroupDecisionMaker( VariableContext.LOCAL, val.index ); }
        public static implicit operator GroupDecisionMaker( GlobalVariable val ) { return new GroupDecisionMaker( VariableContext.GLOBAL, val.index ); }

    }

}