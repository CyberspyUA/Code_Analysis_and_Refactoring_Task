using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    internal class DrinkBrawery
    {
        public static void BrewDrink(int drinkTypeChoice, string drinkName, int cupSize, int sugarSpoons)
        {
            if (drinkTypeChoice == 1)
            {
                var coffee = new Coffee(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Ваше замовлення");
                Console.WriteLine("-----------------------------------------------------------------");
                coffee.OrderShow();
                Console.WriteLine("Очікуйте на завершення приготування напою");
                coffee.Brewing();
            }
            else if (drinkTypeChoice == 2)
            {
                var tea = new Tea(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                tea.OrderShow();
                Console.WriteLine("Очікуйте на завершення приготування чаю");
                tea.Brewing();
            }
            else if (drinkTypeChoice == 3)
            {
                var cacao = new Cacao(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                cacao.OrderShow();
                Console.WriteLine("Очікуйте на завершення приготування какао");
                cacao.Brewing();
            }
        }
    }
}
