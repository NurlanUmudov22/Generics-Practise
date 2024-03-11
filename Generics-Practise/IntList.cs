using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practise
{
    internal class IntList
    {
        private int[] intArray;

        public IntList()
        {
            intArray = Array.Empty<int>();               //new int[0];
        }


        public void Add(int number)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = number;
        }

        public int[] GetAll()
        {
            return intArray;
        }
    }
}
