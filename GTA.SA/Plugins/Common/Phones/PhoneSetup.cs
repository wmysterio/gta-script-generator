using System;
using System.Collections.Generic;
using GTA.Core.Languages;

namespace GTA.Plugins.Common {

    public sealed class PhoneSetup {

        internal ushort MaxCallDelay = 60000;
        internal ushort TimeToResponse = 20000;
        internal ushort RingtoneID = 23000;
        internal Dictionary<ushort, DialogSetup> Dialogs = new Dictionary<ushort, DialogSetup>();

        // ---------------------------------------------------------------------------------------------------------------------------

        public HandlerDialogData OnLoadData;
        public Action OnUnloadData, OnReplicaChanged;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal PhoneSetup() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public PhoneSetup set_max_time_between_calls( ushort timeInMS ) { MaxCallDelay = timeInMS; return this; }
        public PhoneSetup set_max_response_time( ushort timeInMS ) { TimeToResponse = timeInMS; return this; }
        public PhoneSetup set_ringtone( ushort wavID ) { RingtoneID = wavID; return this; }
        public PhoneSetup add_dialog( ushort id, HandlerDialogSetup dialog ) {
            if( dialog == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( Phone ), nameof( HandlerDialogSetup ) ) );
            if( Dialogs.ContainsKey( id ) )
                throw new Exception( Localization.PluginHaveRingID( nameof( Phone ), id ) );

            var dialogSetup = new DialogSetup();
            dialog.Invoke( dialogSetup );

            if( 1 > dialogSetup.Replicas.Count || dialogSetup.Replicas.Count > Phone.REPLICAS_LIMIT )
                throw new Exception( Localization.PluginCellphoneReplicasOverflow( nameof( Phone ), id, Phone.REPLICAS_LIMIT ) );

            Dialogs.Add( id, dialogSetup );
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