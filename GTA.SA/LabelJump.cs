using GTA.Core;

namespace GTA {

    public sealed class LabelJump : BaseLabel {

        internal LabelJump( Script script, uint offset, bool isSkipped = false ) : base( script, offset, "LABEL", isSkipped ) { }

    }

}