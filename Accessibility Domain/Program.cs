using System;


namespace UserTypes;
public class T1
{

    public static int publicInt;
    public static int internalInt;
    private static int privateInt = 0;

    static T1()     //Constructor
    {
        M1.publicInt = 11;      // T1 accessing M1.publicInt
        M1.internalInt = 12;    // T1 accessing M1.internalInt
        M2.publicInt = 21;      // T1 accessing M2.publicInt
        M2.internalInt = 22;    // T1 accessing M2.internalInt
    }

    public class M1     //ACCESSABLE to T1
    {
        public static int publicInt;            //ACCESSABLE by T1
        internal static int internalInt;        //ACCESSABLE by T1
        private static int privateInt = 0;      //NOT accessable outside M1

    }

    private class M2    //ACCESSABLE to T1
    {
        public static int publicInt = 0;        //ACCESSABLE by T1
        internal static int internalInt = 0;    //ACCESSABLE by T1
        private static int privateInt = 0;      //NOT ACCESSABLE outside M2
    }
}



class Program {
    public static void Main()
    {
        // Calling T1's public and internal variables;
        Console.WriteLine(T1.publicInt = 50);
        // Calling T1's public and internal variables;
        Console.WriteLine(T1.internalInt = 51);

        // T1 can call M1's publicInt variable
        Console.WriteLine(T1.M1.publicInt = 100);
        // T1 can call M1's internalInt variable
        Console.WriteLine(T1.M1.internalInt = 101);

    }
}

