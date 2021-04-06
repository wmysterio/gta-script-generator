using GTA.Core;

namespace GTA {

    public class AssetMoneyPickup : BasePickup<AssetMoneyPickup>, IArrayItem, IVariable {

        internal AssetMoneyPickup( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public AssetMoneyPickup create( Float x, Float y, Float z, Int unk1, Int moneyPerDay ) { Script.AppendLine( Opcodes._04A6, this, x, y, z, unk1, moneyPerDay ); return this; }
        public AssetMoneyPickup set_cash_per_day( Int moneyPerDay ) { Script.AppendLine( Opcodes._094A, this, moneyPerDay ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator AssetMoneyPickup( LocalVariable val ) { return new AssetMoneyPickup( VariableContext.LOCAL, val.index ); }
        public static implicit operator AssetMoneyPickup( GlobalVariable val ) { return new AssetMoneyPickup( VariableContext.GLOBAL, val.index ); }

    }

}