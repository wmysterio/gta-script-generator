using GTA.Core;

namespace GTA {

    public sealed class LabelCase : BaseLabel {

        public LabelCase EndJumpTable { get; internal set; }

        internal LabelCase( Script script, uint offset ) : base( script, offset, "SWITCH" ) { name += "_CASE_END"; }
        internal LabelCase( Script script, uint offset, uint caseIndex ) : base( script, offset, "SWITCH" ) { name += $"_CASE_{caseIndex}"; }

    }

}