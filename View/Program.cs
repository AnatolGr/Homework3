using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            while (true)
            {
                string str;
                Console.WriteLine("Введите целое положительное число:");
                str = Console.ReadLine();
                if (Int32.TryParse(str, out num))
                {
                    if (num>0)
                        break;
                }
                Console.WriteLine("Неверное значение");
            }


            var numbertron = new Numbertron();
            var jay = new Jay();
            var silentBob = new SilentBob();


            var handlerJay = new Numbertron.NewNomderDelegate(jay.FetchNewNumber);

            var handlerBob = new Numbertron.NewNomderDelegate(silentBob.FetchNewNumber);

           numbertron.NewNumber += handlerJay;
           numbertron.NewNumber += handlerBob;

            for (int i = 0; i < num; i++)
            {
                numbertron.Generate();
            }

            if (jay.Score > silentBob.Score)
                Console.WriteLine(jay.Name);
            if (jay.Score < silentBob.Score)
                Console.WriteLine(silentBob.Name);
            if (jay.Score == silentBob.Score)
                Console.WriteLine("DRAW");

            Console.ReadKey();
        }
    }
}
