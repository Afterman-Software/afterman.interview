using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterman.Interview.Problem2
{
    public class DuplicateFinder
    {
        // Given an arbitrarily long list of integers, find the most efficient way to determine if there are any duplicates
        // ================================================================================================================
        // size of the storage of ~4294967295 4byte ints is 16GB (neg and pos), but can be reduced to 0.5GB by
        // storing their existence as 32 bit int.   But this is worst case, if we have all possible ints in the given list.
        // To avoid having to always allocate the entire worst case space, we can just add them to a dictionary, as needed.
        // This could be reduced further by using 64bit ints to store the data.
        private Dictionary<Int32, Int32> ElementStorage = new Dictionary<int, int>();

        // but we can't negate zero, so numbers at the -zero loc would be equal to the +zero loc
        private Int32 NegativeZero = 0;

        public DuplicateFinder()
        {
            // EMPTY
        }

        public bool HasDuplicates = false;

        public bool CheckElement(int test)
        {
            // find the location in the dictionary (can be negative)
            int loc = (int) Math.Truncate(test / 32.0);
            // use the remainder to find the bit-shift at that location, removing negatives
            double shift = (Math.Abs(test / 32.0) - Math.Abs(loc)) * 32.0;
            if (loc == 0 && test < 0) // special case for negative numbers less than 32
            {
                bool exists = 0 != (NegativeZero & (1 << (int)shift));
                NegativeZero |= (1 << (int)shift);
                if (exists)
                {
                    // here, if required, we could store a list of the duplicates
                    // for now, we will just mark the class as having found duplicates, with the public property
                    HasDuplicates = true;
                    return true;
                }
            }
            else
            // save evaluation time, if the key has not been created yet
            if (ElementStorage.ContainsKey(loc))
            {
                bool exists = 0 != (ElementStorage[loc] & (1 << (int) shift));
                ElementStorage[loc] |= (1 << (int)shift);
                if (exists)
                {
                    // here, if required, we could store a list of the duplicates
                    // for now, we will just mark the class as having found duplicates, with the public property
                    HasDuplicates = true;
                    return true;
                }
            }
            else
            {
                ElementStorage[loc] = (1 << (int)shift);
            }
            return false;
        }
    }
}
