using ConsoleMetodosAbstratos.Entities.Enum;

namespace ConsoleMetodosAbstratos.Entidades
{
    class Rectangle(Double width, double height, Color color) : Shape(color)
    {
        public double Width { get; set; } = width;
        public double Height { get; set; } = height;

        public override double Area()=> Width * Height;
    }
}
