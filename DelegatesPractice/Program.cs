using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public delegate 
    public static void Main()
    {
        Object obj1 = new Object(21, "Red");
        Object obj2 = new Object(13, "Blue");

        

    }
}

class Object
{
    public int Value { get; set; }
    public string Color { get; set; }

    public Object() {
        Value = 0;
        Color = "Blue";
    }
    public Object(int value, string color)
    {
        Value = value;
        Color = color;
    }
}
class Calculate
{
    public static int Sum(Object obj1, Object obj2)
    {
        return obj1.Value + obj2.Value;
    }

    public static string SumColor(Object obj1, Object obj2)
    {
        return String.Concat(obj1.Color + obj2.Color);
    }
}