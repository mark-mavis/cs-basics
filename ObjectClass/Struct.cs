namespace ObjectClass.Struct
{
    struct Rectangle
    {
        public int width, height;
    }

    public static class StructExercise
    {
        public static void Run()
        {
            Rectangle rec = new Rectangle();
            rec.width = 4;
            rec.height = 10;
            Console.WriteLine($"Area of Rectange is: {rec.width * rec.height}");

        }
    }

}
