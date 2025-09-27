using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace __Scripts.data
{
    public class Data
    {
        /**
         * Genarate random number from 'min' to 'max' range with quality 'size'.
         */
        public static List<int> GenerateIntValueList(int min, int max, int size)
        {
            var result = new List<int>();

            for (int i = 0; i < size; i++)
            {
                int value = Random.Range(min, max);
                result.Add(value);
            }
            return result;
        }
    }
}