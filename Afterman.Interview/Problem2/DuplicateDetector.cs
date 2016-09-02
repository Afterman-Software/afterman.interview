using System.Collections.Generic;

namespace Afterman.Interview.Problem2
{
    public class DuplicateDetector
    {
        public static bool HasDuplicates(int[] values)
        {
            HashSet<int> hs = new HashSet<int>();

            for(int i = 0; i < values.Length; i++)
            {
                if (!hs.Add(values[i]))
                    return true;
            }
            return false;
        }        
    }
}
