


public class A{
    public A(){}
}

public class B : A{
    public B() : base() {}
}

public class C : B{
    public C() : base() {}
}

public class CastingTest{

    public static void Run(){
        B obj = new B();

        //Keyword "is" performs and returns boolean test
        System.Console.WriteLine(obj is B);
        System.Console.WriteLine(obj is A);
        System.Console.WriteLine(obj is C);

        A obj2 = obj as A;      //Returns obj as A obj
        C? obj3 = obj as C;     //returns null because B can not be cast to
                                // to a derived class. Only super class


    }
    
}