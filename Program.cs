using System;


namespace Lab4_1
{




	class Book
    {

		public string AuthFirstName;
		public string AuthLastName;
		public string ID;
		public string Publisher;
		public int CopiesSold;


		public void Sell(int BooksSold)
        {
			CopiesSold =  CopiesSold + BooksSold;
			
        }


		public void Print()
        {


			Console.WriteLine($"Author Name: {AuthFirstName} {AuthLastName}");
			Console.WriteLine($"ISBN: {ID}");
			Console.WriteLine($"Publisher: {Publisher}");
			Console.WriteLine($"Number of Copies Sold: {CopiesSold}");

		}
    }






	class Parallelogram
	{
		public double Length;
		public double Width;
		
		
		public double GetArea()
		{

			return Length * Width;
			
		}


		public double GetPerimeter()
        {
			return (Length * 2)+ (Width * 2);
        }

		public void Print()
        {
			Console.WriteLine("Here is your Parallelogram!");
			Console.WriteLine($"Area: {GetArea()}");
			Console.WriteLine($"Perimeter: {GetPerimeter()}");

        }


		public void Resize (double newLength, double newWidth)
        {

			if (newLength < 0 | newWidth < 0)
            {
				return;
            }




			Length = newLength;
			Width = newWidth;
        }



	}

	class Program
	{
		static bool Continue()
		{
			while (true)
			{
				Console.WriteLine("Would you like to continue? (y/n)");
				string response = Console.ReadLine();
				response = response.ToLower();


				if (response == "y" || response == "yes")
				{
					return true;
				}
				else if (response == "n" || response == "no")
				{
					return false;
				}
				else
				{
					Console.WriteLine("Please enter y or n");
				}

			}
		}


		static void Main(string[] args)
		{
			do
			{


				Parallelogram p1 = new Parallelogram() { Length = 5, Width = 6 };
				p1.Print();
				Console.WriteLine();

				Parallelogram p2 = new Parallelogram() { Length = 25, Width = 60 };
				p2.Print();
				Console.WriteLine();

				p1.Resize(5, 10);
				p1.Print();
				Console.WriteLine();

				Console.WriteLine("Book 1: ");
				Book book1 = new Book() { AuthFirstName = "Jane", AuthLastName = "Smith", CopiesSold = 600, ID = "asdj259789", Publisher = "Smith Publishing Co." };
				book1.Print();
				Console.WriteLine();





				Console.WriteLine("Book 2: ");
				Book book2 = new Book() { AuthFirstName = "John", AuthLastName = "Simmons", CopiesSold = 825, ID = "gdksg2e482t5", Publisher = "Sunny publishing" };
				book2.Print();
				Console.WriteLine();

				Console.WriteLine(" Book 1 updated copies sold: ");

				book1.Sell(5);
				book1.Print();
				Console.WriteLine();

				Console.WriteLine(" Book 2 updated copies sold: ");

				book1.Sell(10);
				book1.Print();
				Console.WriteLine();
			} while (Continue());
		}
	}



}
