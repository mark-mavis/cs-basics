using System;
using Patterns;
using Shapes;

namespace StructuralPatternMatching;
class Program{
    public static void Main(){
        BasicPatterns.ConstantPattern_NullCheck(null);
        BasicPatterns.ConstantPattern_NullCheck("This is a message");

        BasicPatterns.ConstantPattern_TypeCheck(25);
        BasicPatterns.ConstantPattern_TypeCheck("50");
        BasicPatterns.ConstantPattern_TypeCheck(20.5);

        BasicPatterns.DeclarationPattern_TypeCheck(25);
        BasicPatterns.DeclarationPattern_TypeCheck("50");
        BasicPatterns.DeclarationPattern_TypeCheck(20.5);

        Console.WriteLine(BasicPatterns.PropertyPattern_DateCheck(new DateTime(DateTime.Now.Year, 1, 13)));
        Console.WriteLine(BasicPatterns.PropertyPattern_DateCheck(new DateTime(DateTime.Now.Year, 3, 14)));
        Console.WriteLine(BasicPatterns.PropertyPattern_DateCheck(new DateTime(DateTime.Now.Year, 3, 15)));
        Console.WriteLine(BasicPatterns.PropertyPattern_DateCheck(new DateTime(DateTime.Now.Year, 3, 16)));

        Console.WriteLine(SwitchPattern.SwitchExpression(new Circle(20)));
        Console.WriteLine(SwitchPattern.SwitchExpression(new Circle(10)));
        Console.WriteLine(SwitchPattern.SwitchExpression(new Square(10, 10)));
        Console.WriteLine(SwitchPattern.SwitchExpression(new Square(5, 10)));
        Console.WriteLine(SwitchPattern.SwitchExpression(new Triangle(14, 10)));
        Console.WriteLine(SwitchPattern.SwitchExpression(new Triangle(8, 10)));
    }
}