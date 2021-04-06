using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public abstract class External : Script {

        public External() : base( TypeOfScript.EXTERNAL ) {
            if( ExternalCounter > 82 )
                throw new Exception( Localization.OverflowExternalsCount() );
        }

    }

}