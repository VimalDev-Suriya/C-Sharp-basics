public abstract class Shape
{
    public abstract double Area();

    public void Print() => Console.WriteLine($"{Area()}");
}

public class Square : Shape
{
    public int Sides {get; set;}

    public override double Area() => Sides * Sides;
}

public class Reactangle: Shape
{
    public int Length {get; set;}
    public int Width {get; set;}

    public override double Area() => Length * Width;
}