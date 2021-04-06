using System;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public sealed class AudioBackground {

        private static AudioBackground instance = null;

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Int StateOfAB = Script.global(),
                           TrackOfAB = Script.global(),
                           LoopedOfAB = Script.global();
        private static Float VolumeOfAB = Script.global();

        // ---------------------------------------------------------------------------------------------------------------------------

        private vString path = Script.local();      // 25-28@
        private Int isExist = Script.local();       // 29@
        private AudioStream audio = Script.local(); // 30@
        private Float lastVolume  = Script.local(); // 31@

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_stopped { get => StateOfAB == AudioPluginState.STOP; }
        public Condition is_ready { get => StateOfAB == AudioPluginState.READY; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public AudioBackground() {
            if( instance != null )
                throw new Exception( Localization.PluginMustBeOnce( nameof( AudioBackground ) ) );
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( AudioBackground ) ) );
            if( Script.Current.ScriptName == "MAIN" )
                throw new Exception( Localization.PluginCreatedInMainTrhead( nameof( AudioBackground ) ) );
            instance = this;
            Script.wait( Script.DefaultWaitTime );
            Script.jf( StateOfAB != AudioPluginState.STOP );
            isExist.value = false;
            VolumeOfAB.value = 1.0;
            Script.Jump += UPDATE;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public AudioBackground set_volume( Float newVolume ) { VolumeOfAB.value = newVolume; return this; }
        public AudioBackground load( Int newTrackID, bool isLooped = false ) {
            TrackOfAB.value = newTrackID;
            LoopedOfAB.value = isLooped;
            StateOfAB.value = AudioPluginState.LOAD;
            return this;
        }
        public AudioBackground play() { StateOfAB.value = AudioPluginState.PLAY; return this; }
        public AudioBackground unload() { StateOfAB.value = AudioPluginState.UNLOAD; return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void UPDATE( LabelJump label ) {
            Script.wait( 0 );
            Script.jump_table( StateOfAB, jt => {
                jt.Auto += l => { Script.jump(); };              // 0
                jt.Auto += LOAD;                                 // 1
                jt.Auto += l => { Script.jump( jt.EndLabel ); }; // 2
                jt.Auto += PLAY;                                 // 3
                jt.Auto += UNLOAD;                               // 4
                jt.Auto += LOOP;                                 // 5

                void LOAD( LabelCase l ) {
                    path.format( "%d.mp3", TrackOfAB );
                    Script.and( Script.is_file_exists( path ),delegate {
                        Script.and( audio.load( path ), delegate {
                            isExist.value = true;
                            audio.set_loop( LoopedOfAB );
                        } );
                    } );
                    Script.chdir( 0 );
                    StateOfAB.value = AudioPluginState.READY;
                    Script.jump( jt.EndLabel );
                }

                void PLAY( LabelCase l ) {
                    Script.and( isExist == true, delegate {
                        clampVolume();
                        lastVolume.value = VolumeOfAB;
                        audio.set_volume( VolumeOfAB ).perform_action( AudioStreamAction.START );
                    } );
                    StateOfAB.value = AudioPluginState.LOOP;
                    Script.jump( jt.EndLabel );
                }

                void UNLOAD( LabelCase l ) {
                    Script.and( isExist == true, delegate {
                        audio.perform_action( AudioStreamAction.STOP ).release();
                    } );
                    StateOfAB.value = AudioPluginState.STOP;
                    Script.jump();
                }

                void LOOP( LabelCase l ) {
                    Script.and( isExist == true, delegate {
                        Script.and( lastVolume != VolumeOfAB, delegate {
                            clampVolume();
                            lastVolume.value = VolumeOfAB;
                            audio.set_volume( VolumeOfAB );
                        } );
                    } );
                    Script.jump( jt.EndLabel );
                }

            } );
            Script.jump( UPDATE );
        }
        private void clampVolume() {
            Script.and( 0.0 > VolumeOfAB, delegate { VolumeOfAB.value = 0.0; } );
            Script.and( VolumeOfAB > 1.0, delegate { VolumeOfAB.value = 1.0; } );
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