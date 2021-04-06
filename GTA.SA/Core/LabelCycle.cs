namespace GTA.Core {

    public sealed class LabelCycle : BaseLabel {

        internal LabelCycle( Script script, uint offset ) : base( script, offset, "CYCLE" ) { }

    }

}