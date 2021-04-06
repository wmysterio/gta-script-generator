using System;
using System.Linq;
using GTA.Core;
using GTA.Core.Languages;
using GTA.Plugins.Common;

namespace GTA.Plugins {

    public sealed class StarterAdvanced {

        private Float x = Script.global(),
                      y = Script.global(),
                      z = Script.global();

        private Int counter = Script.global(),
                    stage = Script.global(),
                    radarIconID = Script.global(),
                    isCreated = Script.global();

        private RadarMarker radarMarker = Script.global();

        private string name;
        private int lastMission;
        private StarterSetup starterSetup;

        // ---------------------------------------------------------------------------------------------------------------------------

        public sString CurrentGXT {
            get {
                if( lastMission > starterSetup.missionList.Count )
                    return sString.DUMMY;
                if( ReferenceEquals( starterSetup.missionList[ lastMission ].gxtName, null ) )
                    return sString.DUMMY;
                return starterSetup.missionList[ lastMission ].gxtName;
            }
            set {
                if( lastMission > starterSetup.missionList.Count )
                    return;
                starterSetup.missionList[ lastMission ].gxtName = value;
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        private StarterAdvanced() { }
        public StarterAdvanced( HandlerStarter setup ) {
            if( Script.Current.ScriptType != TypeOfScript.THREAD )
                throw new Exception( Localization.PluginCreatedInNonThread( nameof( StarterAdvanced ) ) );
            if( Script.Current.ScriptName == "MAIN" )
                throw new Exception( Localization.PluginCreatedInMainTrhead( nameof( StarterAdvanced ) ) );
            if( setup == null )
                throw new Exception( Localization.PluginIncorrectHandler( nameof( StarterAdvanced ), nameof( HandlerStarter ) ) );

            name = Script.Current.ScriptName;
            starterSetup = new StarterSetup();
            setup.Invoke( starterSetup );
            if( starterSetup.missionList.Count == 0 )
                throw new Exception( Localization.PluginNotHaveMissions( nameof( StarterAdvanced ) ) );
            Script.and( isCreated == 0, delegate {
                change_position( starterSetup.x, starterSetup.y, starterSetup.z );
                change_icon( starterSetup.iconID );
                isCreated.value = 1;
            } );
            Script.and( counter >= starterSetup.missionList.Count, delegate {
                Script.Jump += END_SCRIPT;
            } );
            radarMarker.create_long_range( radarIconID, x, y, z );
            Script.Jump += STARTER_LOOP;
        }

        private void STARTER_LOOP( LabelJump label ) {
            Script.wait( Script.DefaultWaitTime );
            Script.jf( label,
                Script.PlayerChar.is_defined(),
                Script.PlayerChar.is_controllable()
            );

            Script.and( label,
                Script.OnMission == 0,
                !Script.PlayerActor.is_dead(),
                !Script.PlayerActor.is_busted(),
                Script.PlayerActor.is_near_point_3d( 0, x, y, z, starterSetup.radius, starterSetup.radius, starterSetup.radius )
            );

            Script.jump_table( counter, jt => {
                for( int i = 0; i < starterSetup.missionList.Count; i++ ) {
                    var element = starterSetup.missionList.ElementAt( i );
                    jt.label( ( uint ) i, delegate {
                        if( element.conditionsArray.Length > 0 )
                            Script.jf( STARTER_LOOP, element.conditionsArray );
                        if( starterSetup.disablePlayerControl ) {
                            Script.PlayerActor.set_immunities( true );
                            Script.PlayerChar.can_move( false );
                        }
                        if( !ReferenceEquals( element.gxtName, null ) )
                            Script.show_text_styled( element.gxtName, 5000, 1 );
                        if( starterSetup.enableFadeMode )
                            Script.fade( FadeType.OUT, starterSetup.fadeTime );
                        element.missionAction.Invoke();
                        Script.jump( END_SCRIPT_AND_REMOVE_MARKER );
                    } );
                }
            } );

            Script.jump( label );
        }

        private void END_SCRIPT_AND_REMOVE_MARKER( LabelJump label ) {
            radarMarker.disable();
            Script.jump( END_SCRIPT );
        }

        private void END_SCRIPT( LabelJump label ) {
            Script.end_thread();
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public int get_fade_time() { return starterSetup.fadeTime; }
        public StarterAdvanced change_position( Float x, Float y, Float z ) { this.x.value = x; this.y.value = y; this.z.value = z; return this; }
        public StarterAdvanced change_icon( Int radarIconID ) { this.radarIconID.value = radarIconID; return this; }
        public Int get_counter() { return counter; }
        public Int get_stage() { return stage; }
        public void recreate( bool incrementCounter = false, bool incrementStage = false ) {
            if( incrementCounter ) {
                lastMission += 1;
                counter += 1;
            }
            if( incrementStage )
                stage += 1;
            Script.AppendLine( Opcodes._004F, name, "" );
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