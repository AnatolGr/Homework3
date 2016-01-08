using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {

        public readonly string Name;

        public int Score { get; protected set; }

        public abstract void FetchNewNumber(int number);

        public Gambler(string name)
        {
            Name = name;
        }



    }
}
