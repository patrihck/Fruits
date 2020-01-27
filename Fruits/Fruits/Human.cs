using System;
using System.Collections.Generic;
using System.Text;

namespace Fruits
{
    public class Human
    {
        public virtual void TryToEat(object item)
        {
            if (item is Food food)
            {
                Console.WriteLine($"Thank you for that food. I am going to eat it right now. It weights {food.Weight} kg");
            }
            else
            {
                Console.WriteLine("This is probably not a food. I will not eat it.");
            }
            
        }
    }
}
