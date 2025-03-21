using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Shape
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Shape rectangle = new Rectangle(false, "red", 1,2);

			Shape[] shapes =
			{
				rectangle,
				new Square(true, "blue", 1,1),
				new Circle("black", 5),
				new Circle("red", 8),
				new Square(false, "green" ,5,10),
				new Rectangle(true, "purple", 7,2)
			};

            Console.WriteLine("Az oldalhosszak alapján létrehozás: " + Oldalhossz(5,11).ToString());
            Console.WriteLine();
            MaxTer(shapes);
            Console.WriteLine();
            Console.WriteLine();
            KiLyuk(shapes);


			//Square square = new Square(false, "red", 5, 5);

			//Rectangle rectangle1 = square;
			//Shape shape3 = square;
		}

		public static void KiLyuk(Shape[] shapes)
		{
			for (int i = 0; i < shapes.Length; i++)
			{
				if (shapes[i].Area() > shapes[i].Perimeter())
				{
					shapes[i].MakeHoley();
                    Console.WriteLine("Lyukas lett a: " + shapes[i].ToString());
                }
			}
		}

		public static Shape Oldalhossz(double height, double width)
		{
			if (height == width)
			{
				return new Square(false, "blue", 7, 8);
			
			}
			return new Rectangle(true, "pink", 2, 11);
		}

		public static void MaxTer(Shape[] shapes)
		{

			Shape shape = shapes[0];
			for (int i = 1; i < shapes.Length; i++)
			{
				if (shapes[i].Area() > shape.Area())
				{
					shape = shapes[i];
				}
			}
            Console.WriteLine("Max terület: " + shape.ToString());
        }
	}
}
