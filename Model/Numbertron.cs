using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public event NewNomderDelegate NewNumber;

        public delegate void NewNomderDelegate(int number);

        public void Generate()
        {
            Random rnd = new Random();

            int number = rnd.Next(-100, 100);

            NewNumber?.Invoke(number);

        }

    }

}