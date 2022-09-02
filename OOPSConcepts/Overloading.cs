using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts
{
    public class Overloading
    {
        public int Sum(int x, int y)
        {
            int value = x + y;
            return value;
        }
        public int Sum(int x, int y, int z)
        {
            int value = x + y + z;
            return value;
        }

    }
}
