
using System;

namespace NullOperator;
class Program{
    public static void Main(){
        string? str = null;
        OldSchoolStringCheck(str);
        NullCoalescingOperator(str);
        //ThrowableExceptionNullCoalesingOperator(str);
        NullAssignmentCoalescingOperator();
    }

    public static void OldSchoolStringCheck(string? theString){
        if(theString == null){
            Console.WriteLine("No string given");
        }else{
            Console.WriteLine(theString);
        }
    }

    public static void NullCoalescingOperator(string? theString){
        // Null Coalescing Operator chooses the value on the left if NOT null and the value on the right if the left value is null
        Console.WriteLine(theString ?? "No string given");
    }
    public static void ThrowableExceptionNullCoalesingOperator(string? theString){
        Console.WriteLine(theString ?? throw new ArgumentNullException(theString, "Can not be null!"));
    }

    public static void NullAssignmentCoalescingOperator(string? theString){
        
        theString ??= "Default Value";
        Console.WriteLine(theString);
    }
}