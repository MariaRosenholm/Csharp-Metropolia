using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuurinNumero
{
    class Program
    {
        static void Main()
        {
        int eka, toka;

        Console.WriteLine("Syötä ensimmäinen numero: ");
        eka = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Syötä toinen numero: ");
        toka = Convert.ToInt32(Console.ReadLine());

          if (eka > toka)
            Console.WriteLine("Ensimmäinen syöttmäsi numero on suurempi kuin toinen syöttämäsi numero");
        else if (toka > eka)
            Console.WriteLine("Toisena syöttämäsi numero on suurempi kuin ensimmäinen syöttämäsi numero");
        else
            Console.WriteLine("Numerot ovat yhtä suuret.");
      }
    }
}