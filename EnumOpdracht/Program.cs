using System;

namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Colors myMainThemeColor = Colors.Blue;

            if (myMainThemeColor == Colors.Blue) 
            { 
                Console.WriteLine("Dat is mijn kleur"); 
            }
        }
    }
}
