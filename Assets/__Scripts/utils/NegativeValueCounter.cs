using System.Collections.Generic;

namespace __Scripts.Utils
{
    public class NegativeValueCounter
    {
        public int Calculate(List<int> numbers)
        {
            int result = 0;
            
            foreach (var number in numbers)
            {
                // Debug.Log($"number:  {number}.");
                
                if (number < 0)
                {
                    result++;
                }
            }
            
            return result;
        }
    }
}