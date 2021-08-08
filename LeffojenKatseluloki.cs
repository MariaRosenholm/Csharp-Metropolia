using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace LeffojenKatseluloki
{
	[Serializable]
	public class Leffa
	{
		public string Nimi { get; set; }
		public int Kesto { get; set; }
		public string Vuosi { get; set; }

		public Leffa() { }
		public Leffa(string nimi, int kesto, string vuosi)
		{
			this.Nimi = nimi;
			this.Kesto = kesto;
			this.Vuosi = vuosi;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<Leffa> leffat = new List<Leffa>() { };
				XmlSerializer serialisoija = new XmlSerializer(typeof(List<Leffa>));
				int input, kesto1, sum;
				sum = 0;
				string nimi1, vuosi1;

			Alku:
				Console.WriteLine("\n\r" + "\n\r" + "Leffojen Katseluloki");
				Console.WriteLine("====================");
				Console.WriteLine("1) Lisää Leffa");
				Console.WriteLine("2) Poista Leffa");
				Console.WriteLine("3) Näytä Raportti");
				Console.WriteLine("4) Lataa Tietokanta");
				Console.WriteLine("5) Tallenna Tietokanta");
				Console.WriteLine("6) Lopeta");
				Console.Write("Syöte: ");
				input = Convert.ToInt32(Console.ReadLine());
				
				switch (input)
				{
					case 1:
						Console.Write("\n\r");
						Console.WriteLine("Lisää Leffa:");
						Console.Write("Nimi:");
						nimi1 = Console.ReadLine();
						Console.Write("Kesto (min):");
						kesto1 = Convert.ToInt32(Console.ReadLine());
						Console.Write("Vuosi:");
						vuosi1 = Console.ReadLine();

						leffat.Add(new Leffa(nimi1, kesto1, vuosi1));
						goto Alku;
					case 2:
						Console.Write("\n\r");
						Console.WriteLine("Poista Leffa:");
						int b = 0;
						foreach (var leffa in leffat)
						{
							b++;
							Console.WriteLine(b + ") " + leffa.Nimi + " (" + leffa.Vuosi + "), " + leffa.Kesto + " minuuttia.  ");
						}
						Console.Write("Syöte: ");
						int input1 = Convert.ToInt32(Console.ReadLine());

						switch (input1)
						{
							case 1:
								leffat.RemoveAt(0);
								break;
							case 2:
								leffat.RemoveAt(1);
								break;
							case 3:
								leffat.RemoveAt(2);
								break;
							case 4:
								leffat.RemoveAt(3);
								break;
							case 5:
								leffat.RemoveAt(4);
								break;
							case 6:
								leffat.RemoveAt(5);
								break;
							case 7:
								leffat.RemoveAt(6);
								break;
							case 8:
								leffat.RemoveAt(7);
								break;
							case 9:
								leffat.RemoveAt(8);
								break;
							case 10:
								leffat.RemoveAt(9);
								break;
							case 11:
								leffat.RemoveAt(10);
								break;
						}
						goto Alku;
					case 3:
						Console.Write("\n\r");
						foreach (var leffa in leffat)
						{
							Console.WriteLine(leffa.Nimi + " (" + leffa.Vuosi + "), " + leffa.Kesto + " minuuttia.  ");
						}
						int i = 0;
						int yhteiskesto = 0;
						int koko = leffat.Count;
						
						while(i < koko)
						{
						int kesto_1 = leffat[i].Kesto;
						yhteiskesto = yhteiskesto + kesto_1;
						i++;
						}
						if(koko >= 0)
						{
							Console.WriteLine("\n\r" + "Leffoja katsottu yhteensä " + leffat.Count + ", yhteiskesto " + yhteiskesto + " minuuttia.");
						}
						goto Alku;
					case 4:
						Console.Write("\n\r");
						Console.WriteLine("Tietokanta ladattu.");
						if (File.Exists("tietokanta.xml"))
						{
							using (FileStream stream = File.OpenRead("tietokanta.xml"))
							{
							List<Leffa> dezerializedList = (List<Leffa>)serialisoija.Deserialize(stream);
							leffat = dezerializedList;
							}
						}
						else
						{
							Console.WriteLine("Tietokantaa ei saatavilla");
						}
						goto Alku;
					case 5:
						Console.Write("\n\r");
						Console.WriteLine("Tietokanta tallennettu.");

						try
						{
							using (StreamWriter sw = new StreamWriter("tietokanta.xml"))
							{
								serialisoija.Serialize(sw, leffat);
								sw.Close();
							}
						}
						catch
						{
							Console.Write("Tietokannan tallentaminen ei onnistunut!");
						}
						goto Alku;
					case 6:
						Console.Write("\n\r");
						System.Environment.Exit(0);
						break;
					default:
						Console.Write("\n\r");
						Console.WriteLine("Tuntematon komento");
						break;
				}
			}
			catch
			{
				Console.WriteLine("Ohjelma ei toimi");
			}
		}
	}
}