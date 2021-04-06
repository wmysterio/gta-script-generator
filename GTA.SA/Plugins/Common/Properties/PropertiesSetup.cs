using System;
using System.Collections.Generic;
using GTA.Core.Languages;

namespace GTA.Plugins.Common {

    public sealed class PropertiesSetup {

        internal const ushort LIMIT = 32;

        // ---------------------------------------------------------------------------------------------------------------------------

        private byte counter;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Dictionary<ushort, PropertiesData> properties = new Dictionary<ushort, PropertiesData>();

        // ---------------------------------------------------------------------------------------------------------------------------

        internal PropertiesSetup() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public PropertiesSetup add_property( double x, double y, double z, int price, HandlerPropertyActionSetup action, BuyPropertyMessage message = BuyPropertyMessage.PROPERTY ) {
            if( counter > LIMIT )
                throw new Exception( Localization.PluginOverflowCountOfPropertiesOrZero( nameof( Properties ), LIMIT ) );
            if( action == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( Properties ), nameof( HandlerPropertyActionSetup ) ) );
            if( 1 > price )
                throw new Exception( Localization.PluginPriceOfPropertiesMustBeGreatZero( nameof( Properties ) ) );
            ushort id = counter;
            counter += 1;
            var propertyActionSetup = new PropertiesActionSetup( id, x, y, z, price );
            action.Invoke( propertyActionSetup );
            properties.Add( id, new PropertiesData() { setup = propertyActionSetup, message = message } );
            return this;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return base.ToString(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}
namespace GTA.Plugins {

    public delegate void HandlerProperty( Common.PropertiesSetup property );
    public delegate void HandlerPropertyActionSetup( Common.PropertiesActionSetup action );

    
}