using System.Collections.Generic;

namespace __Scripts.Utils
{
    public class PositiveValueCounter
    {
        public int Calculate(List<int> numbers)
        {
            int result = 0;
            
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            
            return result;
        }
    }
}