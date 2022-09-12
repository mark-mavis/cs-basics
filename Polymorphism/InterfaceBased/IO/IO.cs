namespace Polymorphism.InterfaceBased
{
    public static class IO
    {
        public static int GetUserInput()
        {
            Console.WriteLine("Please enter Communication mode (1 = voice mode, 2 = textMode)");
            return int.Parse(Console.ReadLine());
        }
    }
}
