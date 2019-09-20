using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            int szam = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Adjon meg egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                l.Add(szam);
            }

            int max = l.Max();
            Console.WriteLine("Legnagyobb szám: " + max);


            Console.ReadKey();
        }
    }
}
