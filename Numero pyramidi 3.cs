using System;

	class Numerot
	{	
		static void Main (string[] args)
		{	
			int i =1;
			while(i <= Int32.Parse(args[0]))
			{
				int numero = 1;
					while(numero <= i)
					{
						Console.Write(numero);
						numero++;
					}
				i++;
				Console.WriteLine();
			}
		}
	}