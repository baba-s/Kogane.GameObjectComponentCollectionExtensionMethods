using System.Collections.Generic;
using UnityEngine;

namespace Kogane
{
    public static class GameObjectCollectionExtensionMethods
    {
        public static void DestroyAll( this GameObject[] self )
        {
            if ( self == null ) return;

            for ( var i = 0; i < self.Length; i++ )
            {
                Object.Destroy( self[ i ] );
                self[ i ] = null;
            }
        }

        public static void DestroyImmediateAll( this GameObject[] self )
        {
            if ( self == null ) return;

            for ( var i = 0; i < self.Length; i++ )
            {
                Object.DestroyImmediate( self[ i ] );
                self[ i ] = null;
            }
        }

        public static void DestroyAll( this List<GameObject> self )
        {
            if ( self == null ) return;

            for ( var i = 0; i < self.Count; i++ )
            {
                Object.Destroy( self[ i ] );
                self[ i ] = null;
            }

            self.Clear();
        }

        public static void DestroyImmediateAll( this List<GameObject> self )
        {
            if ( self == null ) return;

            for ( var i = 0; i < self.Count; i++ )
            {
                Object.DestroyImmediate( self[ i ] );
                self[ i ] = null;
            }

            self.Clear();
        }

        public static void SetActiveAll( this IReadOnlyList<GameObject> self, bool value )
        {
            foreach ( var x in self )
            {
                x.SetActive( value );
            }
        }
    }
}