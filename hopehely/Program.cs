namespace hopehely
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> hoElemNev = new List<string>();
			List<int> hoElemSzam = new List<int>();
			bool fut = true;
			string nev = "";
			int szam = 0;
			while (fut)
			{
				try {
					Console.WriteLine("Kérem adja meg a hógömbhöz elemet: ");
					 nev = Console.ReadLine();
					if (nev == null)
					{
						throw new Exception("Nem jó bemenet");
					}
					if (nev == "")
					{
						throw new Exception("Nem jó bemenet");
					}
					Console.WriteLine("Kérem adja meg a hogy hány darabot tegyünk bele: ");
					szam = Convert.ToInt32(Console.ReadLine());

				}
				catch(OverflowException) { Console.WriteLine("Hiba"); }
				catch (FormatException) { Console.WriteLine("Hiba"); }
				
				catch(Exception ex) { Console.WriteLine($"{ex.Message}"); }
				hoElemNev.Add(nev);
				hoElemSzam.Add(szam);

				
				

			}
		}
	}
}
