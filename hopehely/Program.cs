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
			do
			{
				try
				{
					Console.WriteLine("Kérem adja meg a hógömbhöz elemet: ");
					nev = Console.ReadLine();
					//throw new ArgumentException("Nem lehet üres"); 
					//string.IsNullOrWhiteSpace
					if (nev == null)
					{
						throw new Exception("Nem jó bemenet");
					}
					if (nev == "")
					{
						throw new Exception("Nem jó bemenet");
					}
				}
				catch (OverflowException) { Console.WriteLine("Hiba"); }
				catch (FormatException) { Console.WriteLine("Hiba"); }
				catch (Exception ex) { Console.WriteLine($"{ex.Message}"); }

				try
				{
					Console.WriteLine("Kérem adja meg a hogy hány darabot tegyünk bele: ");
					szam = Convert.ToInt32(Console.ReadLine());
					//int count = int.Parse(Console.ReadLine());
					//throw new ArgumentException("Nem lehet üres"); 
					if (szam < 1)
					{
						throw new Exception("Nagyobb mint 0");
					}
				}
				catch (OverflowException) { Console.WriteLine("Hiba"); }
				catch (FormatException) { Console.WriteLine("Hiba"); }
				catch (Exception ex) { Console.WriteLine($"{ex.Message}"); }
				hoElemNev.Add(nev);
				hoElemSzam.Add(szam);

				Console.WriteLine("Hógömb megtekintés:");
				for (int i = 0; i < szam; i++)
				{
					Console.WriteLine($"{i + 1}. {hoElemNev[i]} -- {hoElemSzam[i]}");

				}

				int count = 0;

				try
				{
					Console.WriteLine("Kérem adja meg hanyadik elemet távolitsuk el: ");
					count = int.Parse(Console.ReadLine());
					if (count < 1 && count > hoElemNev.Count())
					{ throw new Exception("Túl kicsi vagy túl nagy"); }

					throw new ArgumentException("hiba");

				}
				catch (OverflowException) { Console.WriteLine("Hiba"); }
				catch (FormatException) { Console.WriteLine("Hiba"); }
				catch (Exception ex) { Console.WriteLine($"{ex.Message}"); }
				count -= 1;
				hoElemNev.RemoveAt(count);
				hoElemSzam.RemoveAt(count);
				string bekeres = "";
				Console.WriteLine("Ki akar lépni?  i/y");
				try
				{
					Console.WriteLine("Kérem adja meg a hógömbhöz elemet: ");
					bekeres = Console.ReadLine();

					if (String.IsNullOrEmpty(bekeres)) { throw new Exception("hiba"); }
					if (bekeres != "i" && bekeres != "y") { throw new Exception("hiba"); }


					throw new ArgumentException("Nem lehet üres");





				}
				catch (OverflowException) { Console.WriteLine("Hiba"); }
				catch (FormatException) { Console.WriteLine("Hiba"); }
				catch (Exception ex) { Console.WriteLine($"{ex.Message}"); }
				if (bekeres == "y") { fut = false; }
			} while (fut);
		}
	} }
