using System;

namespace Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            var pineapple = new Pineapple(4);
            var apple = new Apple(5);
            var stone = new Stone();
            var tomato = new Tomato(6);
            var humanWhoLovesFruits = new HumanWhoLovesFruits("Apple");
            var human = new Human();

            Console.WriteLine("Human who loves fruits tries to eat: apple, pineapple, tomato and stone");
            humanWhoLovesFruits.TryToEat(apple);
            humanWhoLovesFruits.TryToEat(pineapple);
            humanWhoLovesFruits.TryToEat(tomato);
            humanWhoLovesFruits.TryToEat(stone);
            Console.WriteLine("\n");

            Console.WriteLine("Normal human tries to eat: apple, pineapple, tomato and stone");

            human.TryToEat(apple);
            human.TryToEat(pineapple);
            human.TryToEat(tomato);
            human.TryToEat(stone);

            System.Threading.Thread.Sleep(100000);
        }
    }
}
