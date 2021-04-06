namespace GTA.Core {

    public sealed class LocalArray : LocalVariable {

        internal readonly ushort count;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal LocalArray( ushort count ) : base() { this.count = count; }
        internal LocalArray( ushort startIndex, ushort count ) : base( startIndex ) { this.count = count; }

    }

}