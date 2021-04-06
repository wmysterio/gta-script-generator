using GTA.Core;

namespace GTA {

    public static class Model {

        public static void load( Int modelID ) { Script.load_model( modelID ); }
        public static void load( Int[] modelsID ) { Script.load_model( modelsID ); }
        public static void load( Int modelID, params Int[] modelsID ) { Script.load_model( modelID, modelsID ); }
        public static void destroy( Int modelID ) { Script.destroy_model( modelID ); }
        public static void destroy( Int[] modelsID ) { Script.destroy_model( modelsID ); }
        public static void destroy( Int modelID, params Int[] modelsID ) { Script.destroy_model( modelID, modelsID ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static Condition is_available( Int modelID ) { return Script.is_model_available( modelID ); }
        public static Condition[] is_available( Int[] modelsID ) { return Script.is_model_available( modelsID ); }
        public static Condition[] is_available( Int modelID, params Int[] modelsID ) { return Script.is_model_available( modelID, modelsID ); }

    }

}