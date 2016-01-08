using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class IntExtantion
    {
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
                return true;
            else
            {
                return false;
            }

        }
    }
}
