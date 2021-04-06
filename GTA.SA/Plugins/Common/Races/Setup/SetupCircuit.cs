namespace GTA.Plugins.Common {

    public sealed class SetupCircuit : SetupBase<SetupCircuit, PointTypeCircuit> {

        internal ushort TOTAL_LAPS = 2;

        public SetupCircuit() { }

        public void set_laps( ushort laps ) {
            TOTAL_LAPS = laps;
        }

    }

}