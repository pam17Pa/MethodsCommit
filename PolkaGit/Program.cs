using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolkaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some exercise...");
            SumNumbers();
            SayHi();
            Stan();
        }
        static void SayHi()
        {
            Console.WriteLine("Hi, lollies <3");
        }
        static void SumNumbers()
        {
            int num1 = 4, num2 = 7;
            Console.WriteLine($"The sum of num1 and num2  is {num1+num2}");
        }
        static void Stan()
        {
            Console.WriteLine("Stan Ateez!!!!!");
        }
        static void BuyMeAnAlbum()
        {
            Console.WriteLine("Please buy me an album *puppy eyes*");
        }
    }
}
