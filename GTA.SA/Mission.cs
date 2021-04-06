using System;

namespace GTA {

    public abstract class Mission : MissionCustom {

        public Action OnPassed { internal get; set; }
        public Action OnFailed { internal get; set; }
        public Action OnClear { internal get; set; }

        //----------------------------------------------------------------------------------------------------

        public static void gosub_clear() { gosub_custom( "CLEAR" ); }
        public static void jump_passed() { jump_custom( "PASSED" ); }
        public static void jump_failed() { jump_custom( "FAILED" ); }

        //----------------------------------------------------------------------------------------------------

        public Mission() : base() { IsCustom = false; }

        //----------------------------------------------------------------------------------------------------

        internal override void AfterStart() {
            PrintMissionCodeAfter( this );
            base.AfterStart();
        }

    }

}