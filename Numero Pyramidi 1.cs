using System;

	class Numerot
	{	
		static void Main (string[] args)
		{	
			for(int i = 1; i <= Int32.Parse(args[0]); i++)
			{	
				for(int Number = 1; Number <= i; Number++)
					Console.Write(Number);
				Console.WriteLine();
			}
		}
	}
	