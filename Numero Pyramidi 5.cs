using System;

	class Numerot
	{	
		static void Main (string[] args)
		{	
			int i =0;
			do
			{
				int numero = 1;
				i++;
				
					if(numero < i)
						Console.WriteLine();
				
							while(numero <= i)
							{
								Console.Write(numero);
								numero++;
							}
			}
			while(i <= Int32.Parse(args[0])-1);
		}
	}	
		