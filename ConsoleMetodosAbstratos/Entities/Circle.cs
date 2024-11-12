using ConsoleMetodosAbstratos.Entities.Enum;

namespace ConsoleMetodosAbstratos.Entidades
{
    class Circle(Double radius, Color color) : Shape(color)
    {
        public double Radius { get; set; } = radius;

        public override double Area() => Math.PI * (Radius * Radius);
    }
}
