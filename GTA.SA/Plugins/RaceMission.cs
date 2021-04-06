using GTA.Plugins.Common;

namespace GTA.Plugins {

    public static class RaceMission {

        public static RaceSprint Sprint() { return new RaceSprint(); }
        public static Common.RaceCheckpoint Checkpoint() { return new Common.RaceCheckpoint(); }
        public static RaceCircuit Circuit() { return new RaceCircuit(); }

    }

}