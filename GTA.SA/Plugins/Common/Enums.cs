namespace GTA.Plugins.Common {

    internal enum PhoneStage : int { CHECK_CONDITION, LOAD_RESOURSES, UNLOAD_RESOURSE, PLAY_RING, WAIT_HOLD, DO_DIALOG, CANCEL }

    internal enum AudioPluginState : int { STOP, LOAD, READY, PLAY, UNLOAD, LOOP }

}