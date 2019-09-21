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
			try
			{
				int db = 0;
				Console.WriteLine("Adja meg, hogy mennyi számot akar: ");
				db = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < db; i++)
				{
					Console.Write("Adjon meg egy számot: ");
					szam = Convert.ToInt32(Console.ReadLine());
					l.Add(szam);
				}

				int max = l.Max();
				Console.WriteLine("Legnagyobb szám: " + max);
				int min = l.Min();
				Console.WriteLine("Legkisebb szám: " + min);

			}
			
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
            Console.ReadKey();
        }
    }
}