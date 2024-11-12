using ConsoleMetodosAbstratos.Entities.Enum;
namespace ConsoleMetodosAbstratos.Entidades
{
    abstract class Shape(Color color)
    {
        public Color Color { get; set; } = color;

        public abstract double Area();       
    }
}
