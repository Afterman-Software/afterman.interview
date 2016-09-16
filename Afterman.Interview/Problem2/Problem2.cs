using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterman.Interview.Problem2
{
   public class Problem2
    {
        public bool HasDuplicates(int[] arrayList)
        {
            var currentValues = new List<int>();
            foreach (var item in arrayList)
            {
                if (currentValues.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
