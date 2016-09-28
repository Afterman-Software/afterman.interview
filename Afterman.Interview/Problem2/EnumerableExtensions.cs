using System.Collections.Generic;

namespace Afterman.Interview.Problem2
{
    public static class EnumerableExtensions
    {
        // from http://stackoverflow.com/a/5391313/1755417
        // determine if an enumerable of T contains only unique values
        public static bool GetIsUnique<T>( this List<T> values )
        {
            var set = new HashSet<T>();

            foreach ( T item in values )
            {
                if ( !set.Add( item ) )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
