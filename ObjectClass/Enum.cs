

namespace ObjectClass.Enum
{
    public enum Days
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
    }

    class EnumExercise
    {
        public static void Run()
        {
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine((int)Days.Monday);
        }
    }
}
