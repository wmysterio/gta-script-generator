namespace GTA.Core {

    public abstract class DM<T> : Handle<T> where T : DM<T> {

        internal DM( VariableContext context, ushort index ) : base( context, index ) { }

        // ---------------------------------------------------------------------------------------------------------------------------

        public abstract T clear_event_response( Int eventID );
        public abstract T add_event_response( Int eventID, Int taskID, Float respectPercentage, Float hatePercentage, Float likePercentage, Float dislikePercentage, Int inCar_bool, Int onFoot_bool );
        public T release() {  Script.AppendLine( Opcodes._065C, this ); return ( T ) this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Condition exists() { return new Condition( Opcodes._09F2, this ); }

    }

}