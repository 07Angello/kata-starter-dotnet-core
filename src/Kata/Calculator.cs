using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if(string.IsNullOrEmpty(number))
                return 0;

            var numbers = number.Split(",").Select(int.Parse);
            return numbers.Sum();
        }
    }
}