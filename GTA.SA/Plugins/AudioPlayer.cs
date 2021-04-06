using System;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public sealed class AudioPlayer {

        internal const int LIMIT = 24;
        internal const int NONE = 0;

        // ---------------------------------------------------------------------------------------------------------------------------

        private static AudioPlayer instance = null;

        // ---------------------------------------------------------------------------------------------------------------------------

        private static Int StateOfAP = Script.global(),
                           CountOfAP = Script.global(),
                           CurrentIDOfAP = Script.global(),
                           CurrentLength = Script.global();

        // ---------------------------------------------------------------------------------------------------------------------------

        private Array<AudioStream> audio = Script.local_array( LIMIT ); // 0-23@
        private Array<Int> tmpAudio = Script.local_array( 0, LIMIT );   // 0-23@
        private vString path = Script.local();        // 24-27@
        private Int isExistAnything = Script.local(), // 28@
                    temp = Script.local(),            // 29@
                    lastID = Script.local(),          // 30@
                    index = Script.local();           // 31@


        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition is_ready { get => StateOfAP == AudioPluginState.READY; }
        public Condition is_stopped { get => StateOfAP == AudioPluginState.STOP; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public AudioPlayer() {
            if( instance != null )
                throw new Exception( Localization.PluginMustBeOnce( nameof( AudioPlayer ) ) );
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( AudioPlayer ) ) );
            if( Script.Current.ScriptName == "MAIN" )
                throw new Exception( Localization.PluginCreatedInMainTrhead( nameof( AudioPlayer ) ) );
            instance = this;
            Script.wait( Script.DefaultWaitTime );
            Script.jf( StateOfAP != AudioPluginState.STOP );
            Script.Gosub += RESET_AUDIO;
            isExistAnything.value = false;
            Script.Jump += UPDATE;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public AudioPlayer get_current_length_in_ms( Out<Int> length ) { length.instance.value = CurrentLength; return this; }
        public AudioPlayer load( Int newCount ) {
            CountOfAP.value = newCount;
            StateOfAP.value = AudioPluginState.LOAD;
            return this;
        }
        public AudioPlayer unload() { StateOfAP.value = AudioPluginState.UNLOAD; return this; }
        public AudioPlayer play() { CurrentIDOfAP += 1; StateOfAP.value = AudioPluginState.PLAY; return this; }
        public AudioPlayer play( Int id ) { CurrentIDOfAP.value = id; StateOfAP.value = AudioPluginState.PLAY; return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        private void UPDATE( LabelJump label ) {
            Script.wait( 0 );
            Script.jump_table( StateOfAP, jt => {
                jt.Auto += l => { Script.jump(); };              // 0
                jt.Auto += LOAD;                                 // 1
                jt.Auto += l => { Script.jump( jt.EndLabel ); }; // 2
                jt.Auto += PLAY;                                 // 3
                jt.Auto += UNLOAD;                               // 4

                void LOAD( LabelCase l ) {
                    Script.or( CountOfAP >= LIMIT, 0 >= CountOfAP, delegate {
                        Script.Gosub += MAKE_READY_STATE;
                        Script.jump( jt.EndLabel );
                    } );
                    Script.and( CountOfAP == 1, delegate {
                        path.value = "0.mp3";
                        Script.and( Script.is_file_exists( path ), delegate {
                            Script.and( audio[ 0 ].load( path ), delegate {
                                isExistAnything.value = true;
                            }, delegate { tmpAudio[ 0 ].value = NONE; } );
                        } );
                        Script.chdir( 0 );
                        Script.Gosub += MAKE_READY_STATE;
                        Script.jump( jt.EndLabel );
                    } );
                    temp.sub( CountOfAP, 1 );
                    Script.to( index, 0, temp, delegate {
                        path.format( "%d.mp3", index );
                        Script.and( Script.is_file_exists( path ), delegate {
                            Script.and( audio[ index ].load( path ), delegate {
                                isExistAnything.value = true;
                            }, delegate { tmpAudio[ index ].value = NONE; } );
                        } );
                    } );
                    Script.chdir( 0 );
                    Script.Gosub += MAKE_READY_STATE;
                    Script.jump( jt.EndLabel );
                }

                void PLAY( LabelCase l ) {
                    Script.and( isExistAnything == true, delegate {
                        tmpAudio.do_if_index_in_range( lastID, delegate {
                            Script.and( tmpAudio[ lastID ] != NONE, delegate {
                                CurrentLength.value = 0;
                                audio[ lastID ].perform_action( AudioStreamAction.STOP );
                            } );
                        } );
                        lastID.value = CurrentIDOfAP;
                        tmpAudio.do_if_index_in_range( lastID, delegate {
                            Script.and( tmpAudio[ lastID ] != NONE, delegate {
                                audio[ lastID ].perform_action( AudioStreamAction.START );
                                audio[ lastID ].get_length( CurrentLength );
                                CurrentLength.add( CurrentLength, 2 ); // 1
                                CurrentLength *= 1000;
                            } );
                        } );
                    } );
                    StateOfAP.value = AudioPluginState.READY;
                    Script.jump( jt.EndLabel );
                }

                void UNLOAD( LabelCase l ) {
                    tmpAudio.each( index, elem => {
                        Script.and( elem != NONE, delegate {
                            audio[ index ].perform_action( AudioStreamAction.STOP ).release();
                        } );
                    } );
                    CurrentLength.value = 0;
                    StateOfAP.value = AudioPluginState.STOP;
                    Script.jump();
                }

            } );
            Script.jump( UPDATE );
        }
        private void MAKE_READY_STATE( LabelGosub label ) {
            CurrentIDOfAP.value = -1;
            lastID.value = -1;
            StateOfAP.value = AudioPluginState.READY;
        }
        private void RESET_AUDIO( LabelGosub label ) { tmpAudio.each( index, i => { i.value = NONE; } ); }

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