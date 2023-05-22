using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    class Object
    {
        public int Value { get; set; }
        public string Color { get; set; }

        public Object()
        {
            Value = 0;
            Color = "Blue";
        }
        public Object(int value, string color)
        {
            Value = value;
            Color = color;
        }
    }

    public class Color
    {
        public Byte Red { get; set; } = 0;
        public Byte Green { get; set; } = 0;
        public Byte Blue { get; set; } = 0;
        public Color()
        {
        }
    }
    class AddObjects
    {
        public static Color AddColors(Color color1, Color color2)
        {
            color1.Red += color2.Red;
            color1.Green += color2.Green;
            color1.Blue += color2.Blue;
            return color1;
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
    internal class ColorAdder
    {
    }
}
