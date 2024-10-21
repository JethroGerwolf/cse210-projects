using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        //shapes in a list
        List<Shape> shapes = new List<Shape>();


        Square square1 = new Square("blue", 5);
        shapes.Add(square1);

        Rectangle rec1 = new Rectangle("pink", 3, 6);
        shapes.Add(rec1);

        Circle cir1 = new Circle("red", 4);
        shapes.Add(cir1);
        
        foreach (Shape i in shapes)
        {

            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}