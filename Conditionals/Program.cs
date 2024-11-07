using System;
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var isMember = true;
            float price = (isMember) ? 20.9f : 30.5f;
            Console.WriteLine(price);

            var season = Season.spring;
            switch (season)
            {
                case Season.spring:
                    Console.WriteLine("this is spring and it's a beautiful season");
                    break;
                case Season.winter:
                    Console.WriteLine("This is winter");
                    break;
                case Season.summer:
                    Console.WriteLine("This is summer");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }

            for (var i = 1; i <= 10; i++) {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (var i = 10; i >= 1; i--) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
            var name = "John smith";
            foreach(var character in name){
                Console.WriteLine(character);
            }
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var number in numbers) {
                Console.WriteLine(number);
            }
            while (true)
            {
                Console.WriteLine("Type your name:");
                var input= Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))  break;
                Console.WriteLine(input);
            }
        }
    }
}
