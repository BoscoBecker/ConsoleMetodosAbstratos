using ConsoleMetodosAbstratos.Entidades;
using ConsoleMetodosAbstratos.Entities.Enum;
using System.Collections;
using System.Globalization;

namespace ConsoleMetodosAbstratos
{
    class Program
    {
        static void Main()
        {
            List<Shape> list = [];
            Console.WriteLine("Enter number of the shapes:");
            int numShapes = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numShapes -1; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle(r) ou circle(c) (r/c) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color BLACK/BLUE/RED, informe uma dessas cores:");
                Color color  = Enum.Parse<Color>(Console.ReadLine());
                if (ch.Equals('r'))
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, heigth, color));
                }
                else {
                    Console.WriteLine("Radius:");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));                
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shapes areas Found: ");
            foreach (Shape shape in list) {
                Console.WriteLine( shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine("Rectangles ares found: ");
            foreach (Rectangle rectangle in list)
            {
                Console.WriteLine(
                        rectangle.Area().ToString("F2", CultureInfo.InvariantCulture);
            }
            
        }

    }

}