using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Struk_Nikita_CAR_01;

namespace Struk_Nikita_CAR_01
{
    internal static class DrinkOrder
    {
        public static void DisplayOrderAndBrewDrink(int drinkTypeChoice, string drinkName, int cupSize, int sugarSpoons)
        {
            Drink drink;

            switch (drinkTypeChoice)
            {
                case 1:
                    drink = new Coffee(drinkName, cupSize, sugarSpoons);
                    break;
                case 2:
                    drink = new Tea(drinkName, cupSize, sugarSpoons);
                    break;
                case 3:
                    drink = new Cacao(drinkName, cupSize, sugarSpoons);
                    break;
                default:
                    Console.WriteLine("Вибачте, ця варіант є недоступним. Спробуйте ще раз.");
                    return;
            }

            Console.WriteLine("Ваше замовлення");
            Console.WriteLine("-----------------------------------------------------------------");
            drink.OrderShow();
            Console.WriteLine("Очікуйте на завершення приготування " + drinkName);
            drink.Brewing();
        }
    }
}
