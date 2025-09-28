using System.Collections.Generic;

namespace __Scripts.Utils.sorts
{
    public class ShellSort
    {
        public void Sort(List<int> list)
        {
            var nElements = list.Count;
            var h = 1;
            int temp;
            
            // calculate interval sequence: 'sequence Knout'
            while (h < nElements / 3)
            {
                h = h * 3 + 1;
            }

            while (h > 0)
            {
                for (int outer = h, inner; outer < nElements; outer++)
                {
                    temp = list[outer];
                    inner = outer;
                    
                    while (inner > h - 1 && list[inner - h] >= temp) 
                    {
                        int value = list[inner-h];
                        list.RemoveAt(inner);
                        list.Insert(inner, value);
                        inner -= h;
                    }
                    list.RemoveAt(inner);
                    list.Insert(inner, temp);
                }
                h = (h - 1) / 3;
            }
        }
    }
}