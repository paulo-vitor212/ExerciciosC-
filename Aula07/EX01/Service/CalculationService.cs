using System;
using System.Collections.Generic;

namespace EX01.Service
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T: IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("Lista vazia");
            }

            T max = list[0];

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
