namespace ConsoleMonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            static void TestConsoleMonFunctions()
            {
                Console.WriteLine("TestConsoleMonFunctions");
                ConsoleMon mon = new ConsoleMon();
                mon.damage(100);
                mon.DepleteEnergy(20);

                Console.WriteLine(mon.health == -100);

                Console.WriteLine(mon.energy == -20);
            }

        }
    }
}
