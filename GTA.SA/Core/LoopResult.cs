namespace GTA.Core {

    public sealed class LoopResult {

        internal static readonly LoopResult instance = new LoopResult();

        // ---------------------------------------------------------------------------------------------------------------------------

        private LoopResult() { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public void @break() { Script.AppendLine( "break" ); }
        public void @continue() { Script.AppendLine( "continue" ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        [System.Obsolete()]
        public override string ToString() { return base.ToString(); }
        [System.Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [System.Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [System.Obsolete()]
        public new System.Type GetType() { return base.GetType(); }

    }

}