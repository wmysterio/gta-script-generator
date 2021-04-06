using System.Collections.Generic;

namespace GTA.Core {

    internal sealed class GXTFile {

        internal Dictionary<string, string> texts = new Dictionary<string, string>();
        internal GXTEncoding encoding = GXTEncoding.None;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal GXTFile() { }

    }

}