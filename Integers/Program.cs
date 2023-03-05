public class IntegersExerciseController
{

    static IntegersExerciseController()
    {
        BasicsOfIntegers.IntegerPrecisionFunction();
    }

    public class BasicsOfIntegers
    {
        public static void IntegerPrecisionFunction()
        {

            /*  byte	8-bit unsigned integer	    0 to 255	
                sbyte	8-bit signed integer	    -128 to 127	
                short	16-bit signed integer	    -32,768 to 32,767	
                ushort	16-bit unsigned integer	    0 to 65,535	
                int	    32-bit signed integer	    -2,147,483,648 to 2,147,483,647	
                uint	32-bit unsigned integer	    0 to 4,294,967,295	u
                long	64-bit signed integer	    -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	l
                ulong	64-bit unsigned integer	    0 to 18,446,744,073,709,551,615	ul
                float	32-bit Single-precision floating point type	    -3.402823e38 to 3.402823e38	f
                double	64-bit double-precision floating point type	    -1.79769313486232e308 to 1.79769313486232e308	d
                decimal	128-bit decimal type for financial and monetary calculations	(+ or -)1.0 x 10e-28 to 7.9 x 10e28	m
                char	16-bit single Unicode character	Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)	
                bool	8-bit logical true/false value	    True or False
             */

            int a = 7;
            int b = 4;
            int c = 3;
            Console.WriteLine((a + b) / c);    // Integer answer is truncated

            /* Data Type Suffix Labels
             * 
             *      L or l for long (l in small letters should be avoided as it confuses you with digit 1)
             *      D or d for double
             *      F or f for float
             *      M or m for decimal (D is already taken for double, so M is best representation for decimal)
             *      U or u for unsigned integer
             *      UL or ul for unsigned long
             */

            Console.WriteLine($"Signed Int16 Range = {Int16.MinValue} - {Int16.MaxValue}\n");

            Console.WriteLine($"Unsigned Int16 Range = {UInt16.MinValue} - {UInt16.MaxValue}\n");

            Console.WriteLine($"Signed Int32 Range = {Int32.MinValue} - {Int32.MaxValue}\n");

            Console.WriteLine($"Unsigned Int32 Range = {UInt32.MinValue} - {UInt32.MaxValue}\n");

            Console.WriteLine($"Signed Int64 Range = {Int64.MinValue} - {Int64.MaxValue}\n");

            Console.WriteLine($"Unsigned Int64 Range = {UInt64.MinValue} - {UInt64.MaxValue}\n");

            Console.WriteLine($"Float Range = {float.MinValue} - {float.MaxValue}");
            
            Console.WriteLine($"Double Ramge = {double.MinValue} - {double.MaxValue}");
            Console.WriteLine($"1.0 / 3.0 = {(double)1.0/3.0}\n");

            Console.WriteLine($"Decimal Ramge = {decimal.MinValue} - {decimal.MaxValue}");     //Greater precision then double
            Console.WriteLine($"5.0M / 3.0M = {5.0M / 3.0M}\n");

            Console.WriteLine($"Long Range = {long.MinValue} - {long.MaxValue}");
            Console.WriteLine($"{long.MinValue}L/{long.MaxValue}L = {long.MinValue/long.MaxValue}\n");

            Console.WriteLine($"Unsigned Long Range = {ulong.MinValue} - {ulong.MaxValue}\n");
        }
    }
}

class Program
{
    public static void Main()
    {
            // Discard variable (_)
            _ = new IntegersExerciseController();

    }
}
