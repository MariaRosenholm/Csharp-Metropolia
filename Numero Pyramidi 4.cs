using System;

	class Numerot
	{	
		static int Main (string[] args)
		{	
			int i = 1;
			while(i <= 8)
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
		return 0;
		}
	}