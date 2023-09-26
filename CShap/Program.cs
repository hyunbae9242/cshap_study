using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string -> int

            //string input = Console.ReadLine();
            //int number = int.Parse(input);
            //Console.WriteLine(input);

            // int -> string
            int maxHp = 200;
            int hp = 100;

            // 당신의 hp는 ?? 입니다.

            string message = string.Format("당신의 HP는 {0}/{1}입니다.", hp, maxHp);
            Console.WriteLine(message);
        }
    }
}