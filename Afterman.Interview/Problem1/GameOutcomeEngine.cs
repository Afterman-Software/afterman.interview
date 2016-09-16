using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afterman.Interview.Problem1
{
   public class GameOutcomeEngine
    {
        bool IsGameOver(List<string> stateOfBoard)
        {
            var firstColumn = new List<string>();
            var secondcolumn = new List<string>();
            var thirdColumn = new List<string>();
            var diagonal = new List<string>();
            var row = 1;
            foreach (var item in stateOfBoard)
            {
                var stringItems = item.Split(',').ToList();
                firstColumn.Add(stringItems[0]);
                secondcolumn.Add(stringItems[1]);
                thirdColumn.Add(stringItems[3]);
                if(row ==1)
                    diagonal.Add(stringItems[0]);
                if(row == 2)
                    diagonal.Add(stringItems[1]);
                if (row == 3)
                    diagonal.Add(stringItems[2]);
                if (IsSame(stringItems))
                    return true;
                row++;
            }
            if (IsSame(firstColumn))
              return  true;
            if (IsSame(secondcolumn))
                return true;
            if (IsSame(thirdColumn))
                return true;
            if (IsSame(diagonal))
                return true;
         
            return false;
        }
        private bool IsSame(List<string> items)
        {
            
            return items.Distinct().Skip(1).Any();
        }
    }
     
}
