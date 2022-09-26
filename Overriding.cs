namespace PolymorphismDemo;
abstract class Shape
{
    public abstract double GetArea();
}
class Square : Shape
{
    public double Length { get; set; }
    public override double GetArea()
    {
        // Calculate Length x Width
        return Length * Length;
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea()
    {
        // Calculate Pi * r ^2
        return Radius * Radius * 3.14f;
    }
}
class Program2
{
    static void TestFunction(Shape shape)
    {
        Console.WriteLine("Area :" + shape.GetArea());
    }
}