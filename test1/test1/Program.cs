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
            // 設定背景與文字顏色
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            // 外框
            Console.WriteLine("╔═══════════╗");

            // 設定身高變數並讀取輸入值
            Console.WriteLine("║  請輸入身高:         ║");
            double height = int.Parse(Console.ReadLine());

            // 設定體重變數並讀取輸入值
            Console.WriteLine("║  請輸入體重:         ║");
            double weight = int.Parse(Console.ReadLine());

            // 計算BMI
            double BMI = weight / ((height / 100) * (height /100));

            // 顯示BMI
            Console.WriteLine("║  BMI為:{0:0}            ║", BMI);

            // 判斷數值範圍
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

            // 外框
            Console.WriteLine("╚═══════════╝");

            // 防治視窗自動關閉
            Console.ReadLine();
        }
    }
}
