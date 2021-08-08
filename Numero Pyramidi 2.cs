using System;

	class Numerot
	{	
		static void Main (string[] args)
		{	
			int a = Int32.Parse(args[0]);
			
			for(int i = 1; i <= a; i++)
			{	
				for(int Number = 1; Number <= i; Number++)
					Console.Write(Number);
				Console.WriteLine();
			}
		}
	}
				
