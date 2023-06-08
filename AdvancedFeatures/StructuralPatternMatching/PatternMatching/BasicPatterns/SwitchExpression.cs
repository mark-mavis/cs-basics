
using Shapes;
namespace Patterns;

class SwitchPattern{

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
            case Square:
                return $"Square Area: {shape.Area()}";
            case Triangle:
                return $"Triangle Area: {shape.Area()}";
            default:
                return "Unknown";
        }
    }

    public static string SwitchExpression(Shape shape) => (shape) switch {
        Circle => $"Circle Area: {shape.Area()}",
        Square => $"Square Area: {shape.Area()}",
        Triangle => $"Triangle Area: {shape.Area()}",
        _ => "Unknown"
    };
    


}