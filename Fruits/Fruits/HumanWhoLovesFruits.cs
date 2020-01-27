using System;
using System.Collections.Generic;
using System.Text;

namespace Fruits
{
    public class HumanWhoLovesFruits : Human
    {
        public HumanWhoLovesFruits(string favoriteFruit)
        {
            FavoriteFruit = favoriteFruit;
        }
        public string Name;
        public string FavoriteFruit;

        public override void TryToEat(object food)
        {

            if (food is Fruit)
            {
                Console.WriteLine($"Mmmm... What a delicious {food.GetType().Name}.. I really love all the fruits!");
            }
            else if (food is Vegetable)
            {
                Console.WriteLine($"Oh no, I hate vegetables ! Take this {food.GetType().Name} away from me !");
            }
            else
            {
                Console.WriteLine($"I will not eat it because it is a {food.GetType().Name}");
            }
              
        }
    }
}
