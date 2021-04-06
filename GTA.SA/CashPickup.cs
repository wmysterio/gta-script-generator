using GTA.Core;

namespace GTA {

    public class CashPickup : BasePickup<CashPickup>, IArrayItem, IVariable {

        internal CashPickup( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public CashPickup create( Int amount, Float x, Float y, Float z, Int permanence_bool ) { Script.AppendLine( Opcodes._02E1, this, amount, x, y, z, "permanence_flag " + permanence_bool ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator CashPickup( LocalVariable val ) { return new CashPickup( VariableContext.LOCAL, val.index ); }
        public static implicit operator CashPickup( GlobalVariable val ) { return new CashPickup( VariableContext.GLOBAL, val.index ); }

    }

}