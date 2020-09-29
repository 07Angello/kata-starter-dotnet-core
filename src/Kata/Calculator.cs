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

            List<string> numbers = number.Split(",").ToList();
            int result = 0;
            
            foreach (string num in numbers)
            {
                int currentNumber = int.Parse(num);
                result += currentNumber;
            }

            return result;
        }
    }
}