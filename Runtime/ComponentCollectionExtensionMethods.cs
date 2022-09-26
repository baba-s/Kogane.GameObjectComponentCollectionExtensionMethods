using System.Collections.Generic;
using UnityEngine;

namespace Kogane
{
    public static class ComponentCollectionExtensionMethods
    {
        public static void DestroyAll<T>( this T[] self ) where T : Component
        {
            for ( var i = 0; i < self.Length; i++ )
            {
                Object.Destroy( self[ i ].gameObject );
                self[ i ] = null;
            }
        }

        public static void DestroyImmediateAll<T>( this T[] self ) where T : Component
        {
            for ( var i = 0; i < self.Length; i++ )
            {
                Object.DestroyImmediate( self[ i ].gameObject );
                self[ i ] = null;
            }
        }

        public static void DestroyAll<T>( this List<T> self ) where T : Component
        {
            for ( var i = 0; i < self.Count; i++ )
            {
                Object.Destroy( self[ i ].gameObject );
                self[ i ] = null;
            }

            self.Clear();
        }

        public static void DestroyImmediateAll<T>( this List<T> self ) where T : Component
        {
            for ( var i = 0; i < self.Count; i++ )
            {
                Object.DestroyImmediate( self[ i ].gameObject );
                self[ i ] = null;
            }

            self.Clear();
        }
    }
}