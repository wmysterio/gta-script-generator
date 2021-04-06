using System;
using GTA.Core;
using GTA.Core.Languages;

namespace GTA {

    public partial class Memory : Int {

        // ---------------------------------------------------------------------------------------------------------------------------

        internal Memory( VariableContext context, ushort index ) : base( context, index ) { }
        internal Memory( int address ) : this( VariableContext.LOCAL, 0 ) { SetName( address.ToString() ); }

        // ---------------------------------------------------------------------------------------------------------------------------

        public event HandlerJump Label {
            add { label = value; }
            remove { }
        }
        public HandlerJump label {
            set {
                labelType = TypeOfLabel.JUMP;
                if( value == null )
                    throw new Exception( Localization.LabelNotExist( nameof( label ) ) );
                if( !Script.Current.jumps.ContainsKey( value ) ) {
                    Script.Current.jumps.Add( value, new LabelJump( Script.Current, Script.Current.jumpsCounter ) );
                    Script.Current.jumpsCounter += 1;
                }
                labelName = $"@{Script.Current.jumps[ value ]}";
                Script.AppendLine( Context == VariableContext.GLOBAL ? Opcodes._0004 : Opcodes._0006, check_OUT_Variable( this ), labelName );
            }
        }

        // ---------------------------------------------------------------------------------------------------------------------------

        public Memory free() { Script.AppendLine( Opcodes._0AC9, check_OUT_Variable( this ) ); return this; }
        public Memory get_variable_offset( Variable hVariable ) { Script.AppendLine( Opcodes._0AC7, check_OUT_Variable( this ), hVariable ); return this; }
        public Memory allocate( Int size ) { Script.AppendLine( Opcodes._0AC8, check_OUT_Variable( this ), size ); return this; }
        public Memory get_label_offset( HandlerJump label ) {
            if( label == null )
                throw new Exception( Localization.LabelNotExist( nameof( get_label_offset ) ) );
            if( !Script.Current.jumps.ContainsKey( label ) ) {
                Script.Current.jumps.Add( label, new LabelJump( Script.Current, Script.Current.jumpsCounter ) );
                Script.Current.jumpsCounter += 1;
            }
            Script.AppendLine( Opcodes._0AC6, check_OUT_Variable( this ), Script.Current.jumps[ label ] );
            return this;
        }
        public Memory get_actor_struct( Actor hActor ) { Script.AppendLine( Opcodes._0AEA, hActor, check_OUT_Variable( this ) ); return this; }
        public Memory get_vehicle_struct<T>( T hVehicle ) where T : Vehicle<T> { Script.AppendLine( Opcodes._0AEB, hVehicle, check_OUT_Variable( this ) ); return this; }
        public Memory get_object_struct( Object hObject ) { Script.AppendLine( Opcodes._0AEC, hObject, check_OUT_Variable( this ) ); return this; }
        public Memory pop_float() { Script.AppendLine( Opcodes._0AE9, check_OUT_Variable( this ) ); return this; }
        public Memory get_current_thread_pointer() { Script.AppendLine( Opcodes._0A9F, check_OUT_Variable( this ) ); return this; }

        // ---------------------------------------------------------------------------------------------------------------------------

        public static implicit operator Memory( LocalVariable val ) { return new Memory( VariableContext.LOCAL, val.index ); }
        public static implicit operator Memory( GlobalVariable val ) { return new Memory( VariableContext.GLOBAL, val.index ); }
        public static implicit operator Memory( int address ) { return new Memory( address ); }

        public static Memory operator ++( Memory i1 ) { return i1 += 1; }
        public static Memory operator --( Memory i1 ) { return i1 -= 1; }

        public static Memory operator %( Memory i1, Int i2 ) { i1.mod( i1, i2 ); return i1; }
        public static Memory operator ^( Memory i1, Int i2 ) { i1.xor( i1, i2 ); return i1; }
        public static Memory operator &( Memory i1, Int i2 ) { i1.and( i1, i2 ); return i1; }
        public static Memory operator |( Memory i1, Int i2 ) { i1.or( i1, i2 ); return i1; }
        public static Memory operator +( Memory i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0058 : Opcodes._005E, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._005C : Opcodes._005A, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0008 : Opcodes._000A, i1, i2 ); }
            return i1;
        }
        public static Memory operator -( Memory i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0060 : Opcodes._0066, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0064 : Opcodes._0062, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._000C : Opcodes._000E, i1, i2 ); }
            return i1;
        }
        public static Memory operator *( Memory i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0068 : Opcodes._006C, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._006E : Opcodes._006A, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0010 : Opcodes._0012, i1, i2 ); }
            return i1;
        }
        public static Memory operator /( Memory i1, Int i2 ) {
            check_OUT_Variable( i1 );
            if( i2.IsDefined ) {
                if( i1.Context == VariableContext.GLOBAL ) {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0070 : Opcodes._0074, i1, i2 );
                } else {
                    Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0076 : Opcodes._0072, i1, i2 );
                }
            } else { Script.AppendLine( i1.Context == VariableContext.GLOBAL ? Opcodes._0014 : Opcodes._0016, i1, i2 ); }
            return i1;
        }

        public static Condition operator ==( Memory i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._0038 : Opcodes._0039, i2, i1 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._003A : Opcodes._003C, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._07D6 : Opcodes._003B, i1, i2 );
        }
        public static Condition operator >( Memory i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0018 : Opcodes._0019, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002A : Opcodes._002B, i1, i2 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001C : Opcodes._001E, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._001F : Opcodes._001D, i1, i2 );
        }
        public static Condition operator >=( Memory i1, Int i2 ) {
            if( !i1.IsDefined && !i2.IsDefined )
                throw new Exception( Localization.VariablesWithoutContext( i1.Name, i2.Name ) );
            if( i1.IsDefined && !i2.IsDefined )
                return new Condition( i1.Context == VariableContext.GLOBAL ? Opcodes._0028 : Opcodes._0029, i1, i2 );
            if( i2.IsDefined && !i1.IsDefined )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002A : Opcodes._002B, i1, i2 );
            if( i1.Context == VariableContext.GLOBAL )
                return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002C : Opcodes._002E, i1, i2 );
            return new Condition( i2.Context == VariableContext.GLOBAL ? Opcodes._002F : Opcodes._002D, i1, i2 );
        }
        public static Condition operator !=( Memory i1, Int i2 ) { return !( i1 == i2 ); }
        public static Condition operator <( Memory i1, Int i2 ) { return i2 >= i1; }
        public static Condition operator <=( Memory i1, Int i2 ) { return i2 > i1; }

        // ---------------------------------------------------------------------------------------------------------------------------

        [Obsolete()]
        public override int GetHashCode() { return base.GetHashCode(); }
        [Obsolete()]
        public override bool Equals( object obj ) { return base.Equals( obj ); }

    }

}