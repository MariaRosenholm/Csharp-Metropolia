using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aanioikeus
{
    class Program
    {
        static void Main()
        {
            int ika;

            Console.WriteLine("Syötä ikäsi, ole hyvä:");
            ika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikäsi on " + ika);
            if (ika > 17)
                Console.WriteLine("Voit äänestää!");
            else
                Console.WriteLine("Et voi äänestää.");
        }
    }
}