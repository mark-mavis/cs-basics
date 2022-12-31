

namespace Interfaces
{
    class IShootableTest
    {
        public static void Run()
        {
            Gun pist = new Gun();
            pist.Label();
            pist.Shoot();

            if (pist is IShootable && pist is Weapon)
            {
                Console.WriteLine("Yes, it is my parents.");
            }
        }
    }
}
