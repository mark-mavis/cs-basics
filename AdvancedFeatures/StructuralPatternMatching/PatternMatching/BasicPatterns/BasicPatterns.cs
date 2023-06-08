using System;
namespace Patterns;

public class BasicPatterns{

    public static void OriginalWay(){
        // Conpare and expression to a known constant, for example...
        // checking if a string is null

        string? str = "This is a string";

        if(str is not null){
            Console.WriteLine($"Value of str is {str}");
        }else{
            Console.WriteLine($"str is null");
        }
    

    }
    
    // CONSTANT PATTERN
    // Comparing an Expression to a known constant value
    /* 
        - Null check
            if(str == null)
            if(string.IsNullOrWhiteSpace(str))
        - Type check
            if(obj.GetType() == typeof(Object Class))
            if(typeof(obj) == typeof(Object Class))   
    */
    public static void ConstantPattern_NullCheck(string? str){       
        if(str is not null){
            Console.WriteLine($"The value of str is '{str}");
        }else{
            Console.WriteLine($"str is null");
        }
    }

    public static void ConstantPattern_TypeCheck(Object o){
        int l = 0;
        if(o.GetType() == typeof(int)){
            l = (int)o;
        }

        string s;
        if(o.GetType() == typeof(string)){
            s = (string)o;
            if(!int.TryParse(s, out l)){
                l = 0;
            }
        }
        LineBuilderHelper('-', l);
    }
    public static void DeclarationPattern_TypeCheck(Object o){
        // if (o is of type int, assign to l) or (if o is string and can parse to int)
        if(o is int l || (o is string s && int.TryParse(s, out l))){
            LineBuilderHelper('-', l);     
        }
    }

    public static bool PropertyPattern_DateCheck(DateTime dt){

        return (dt is {Month: 3, Day: 14 or 15});
    }

    private static void LineBuilderHelper(char c, int n){
        if(n > 0){
            Console.WriteLine(new string(c, n));
        }
    }
}
