namespace GTA.Core {

    public sealed class GlobalArray : GlobalVariable {

        internal readonly ushort count;

        // ---------------------------------------------------------------------------------------------------------------------------

        internal GlobalArray( ushort count ) : base() { this.count = count; }
        internal GlobalArray( ushort startIndex, ushort count ) : base( startIndex ) { this.count = count; }

    }

}