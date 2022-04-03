using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = Convert.ToInt32(Console.ReadLine());
            int cislo2 = Convert.ToInt32(Console.ReadLine());
            int[] pole = { cislo1, cislo2 };


            if (cislo1 == cislo2)
               {
                Console.WriteLine("Čísla jsou si rovná.");
                Console.ReadLine();
               }

            else
                {
                int mensi_cislo = pole.Min();
                int vetsi_cislo = pole.Max();
                Console.WriteLine(mensi_cislo + ", " + vetsi_cislo);
                Console.ReadLine();
                }
        }
    }
}
