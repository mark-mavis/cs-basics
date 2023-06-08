
using Shapes;

namespace Patterns;

class SwitchPattern{

    public static Shape[] Shapes = new Shape[]{
        new Circle(20),
        new Circle(10),
        new Rectangle(10, 4),
        new Rectangle(5, 5),
        new Triangle(14, 10),
        new Triangle(8, 20)
    };
    public static string SwitchOnValue(int num){
        switch(num){
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            default:
                return "Unknown";
        }
    }

    public static string SwitchOnType(Shape shape){
        switch(shape){
            case Circle:
                return $"Circle Area: {shape.Area()}";
            case Rectangle:
                return $"Square Area: {shape.Area()}";
            case Triangle:
                return $"Triangle Area: {shape.Area()}";
            default:
                return "Unknown";
        }
    }

    public static string SwitchExpression(Shape shape) => (shape) switch {
        Circle => $"Circle Area: {shape.Area()}",
        Rectangle => $"Square Area: {shape.Area()}",
        Triangle => $"Triangle Area: {shape.Area()}",
        _ => "Unknown"
    };

    public static string SwitchExpressionWithCriteria(Shape shape) => (shape) switch{
        // Additional Case features in switch expressions....
        /*
            When a case isn't expressive enough to handle conditions by themselves, 
            We can add Case Gaurds (Conditions) to the case by using the "when" keyword
        */
        Circle {Radius: int r} when r > 10 => $"Big Circle... Area: {shape.Area()}",
        Circle {Radius: int r} when r <= 10 => $"Little Circle... Area: {shape.Area()}",
        Rectangle {Height: int h, Width: int w} when h > 5 && w < 5 => $"Skinny Rectangle... Area: {shape.Area()}",
        Rectangle {Height: int h, Width: int w} when h == w => $"Square Area: {shape.Area()}",
        Triangle {BaseWidth: int bw} when bw > 5 => $"Wide Base... Area {shape.Area()}",
        Triangle {Height: int h} when h > 10 => $"Tall Triangle... Area {shape.Area()}",
        _ => "Unknown"
    };

    public static void Controller(){
        foreach(Shape s in Shapes){
            Console.WriteLine(SwitchOnType(s));
        }
        
        foreach(Shape s in Shapes){
            Console.WriteLine(SwitchExpression(s));
        }

        foreach(Shape s in Shapes){
            Console.WriteLine(SwitchExpressionWithCriteria(s));
        }
    }
    


}