using System;

namespace GTA.Core {

    public abstract class BaseLabel {

        protected readonly Script script;
        protected readonly uint offset;

        // ---------------------------------------------------------------------------------------------------------------------------

        protected string name;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal bool isSkipped;

        // ---------------------------------------------------------------------------------------------------------------------------

        private BaseLabel() { }
        internal BaseLabel( Script script, uint offset, string name, bool isSkipped = false ) {
            this.script = script;
            this.offset = offset;
            this.name = isSkipped ? script.ScriptName : $"{script.ScriptName}_{name}_{offset}";
            this.isSkipped = isSkipped;
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override string ToString() { return name; }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }
        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public new Type GetType() { return base.GetType(); }

    }

}