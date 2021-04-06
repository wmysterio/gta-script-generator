using GTA.Core;

namespace GTA {

    public class Group : Handle<Group>, IArrayItem, IVariable {

        internal Group( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Group get_size( Out<Int> numberOfLeaders, Out<Int> numberOfMembers ) { Script.AppendLine( Opcodes._07F6, this, numberOfLeaders, numberOfMembers ); return this; }
        public Group get_member( Int memberIndex_byte, Out<Actor> hActor ) { Script.AppendLine( Opcodes._092B, this, memberIndex_byte, hActor ); return this; }
        public Group create( Int groupType_byte ) { Script.AppendLine( Opcodes._062F, this, groupType_byte ); return this; }
        public Group set_separation_range( Float range ) { Script.AppendLine( Opcodes._06F0, this, range ); return this; }
        public Group set_follow_status( Int state_bool ) { Script.AppendLine( Opcodes._0940, this, state_bool ); return this; }
        public Group give_command( Int command ) { Script.AppendLine( Opcodes._07B3, this, command ); return this; }
        public Group release() { Script.AppendLine( Opcodes._0632, this ); return this; }
        public Group assign_to_AS_pack( ASPack hASPack ) { Script.AppendLine( Opcodes._087D, this, hASPack ); return this; }
        public Group set_group_decision_maker( GroupDecisionMaker hGroupDecisionMaker ) { Script.AppendLine( Opcodes._06AD, this, hGroupDecisionMaker ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition exist() { return new Condition( Opcodes._07FD, this ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Group( LocalVariable val ) { return new Group( VariableContext.LOCAL, val.index ); }
        public static implicit operator Group( GlobalVariable val ) { return new Group( VariableContext.GLOBAL, val.index ); }

    }

}