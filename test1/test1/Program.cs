using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("╔═══════════╗");


            Console.WriteLine("║  請輸入身高:         ║");
            double height = int.Parse(Console.ReadLine());

            Console.WriteLine("║  請輸入體重:         ║");
            double weight = int.Parse(Console.ReadLine());

            
            double BMI = weight / ((height / 100) * (height /100));
            Console.WriteLine("║  BMI為:{0:0}            ║", BMI);

            if (BMI < 18.5)
                Console.WriteLine("║    你的體重過輕噢    ║");

            if (18.5 <= BMI && BMI < 24)
                Console.WriteLine("║     你的體重正常。   ║");

            if (BMI >= 24)
                Console.WriteLine("║    你的體重過重了！  ║");

            if (BMI < 16.5)
                Console.WriteLine("║         免役         ║");

            if (16.5 <= BMI && BMI < 31.5)
                Console.WriteLine("║     你需要服兵役     ║");

            if (BMI >= 31.5)
                Console.WriteLine("║         免役         ║");

            Console.WriteLine("╚═══════════╝");

            Console.ReadLine();
        }
    }
}
