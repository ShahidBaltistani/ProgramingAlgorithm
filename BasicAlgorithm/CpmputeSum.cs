using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
   public class CpmputeSum
    {
       public int CalculateSum(int number1, int number2)
        {
            
            if (number1 == number2)
            {
                return (number1 + number2) * 3;
                
            }
            return number1 + number2;
        }
    }
}
