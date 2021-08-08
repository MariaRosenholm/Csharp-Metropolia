using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorakkaJalkaYdinase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torakka-Jalka-Ydinase. Valitse 1-4.");
            Console.WriteLine("1) Torakka 2)Jalka 3)Ydinase 4)Poistu");
            int valinta = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int computer;

            switch (valinta)
            {
                case 1:
                    Console.WriteLine("1 Torakka!");
                    computer = random.Next(1, 4);

                    if (computer == 1)
                    {
                        Console.Write("Tietokone valitsi: Torakka. Tasapeli!");
                    }

                    if (computer == 2)
                    {
                        Console.Write("Tietokone valitsi: Jalka. Tietokone voitti!");
                    }

                    if (computer == 3)
                    {
                        Console.Write("Tietokone valitsi: Ydinase. Sinä voitit!");
                    }
                    break;

                case 2:
                    Console.WriteLine("2 Jalka!");
                    computer = random.Next(1, 4);

                    if (computer == 1)
                    {
                        Console.Write("Tietokone valitsi: Torakka. Sinä voitit!");
                    }

                    if (computer == 2)
                    {
                        Console.Write("Tietokone valitsi: Jalka. Tasapeli!");
                    }

                    if (computer == 3)
                    {
                        Console.Write("Tietokone valitsi: Ydinase. Tietokone voitti!");
                    }
                    break;

                case 3:
                    Console.WriteLine("3 Ydinase!");
                    computer = random.Next(1, 4);

                    if (computer == 1)
                    {
                        Console.Write("Tietokone valitsi: Torakka. Tietokone voitti!");
                    }

                    if (computer == 2)
                    {
                        Console.Write("Tietokone valitsi: Jalka. Sinä voitit!");
                    }

                    if (computer == 3)
                    {
                        Console.Write("Tietokone valitsi: Ydinase. Tasapeli!");
                    }
                    break;

                case 4:
                    break;

            }
        }
    }
}