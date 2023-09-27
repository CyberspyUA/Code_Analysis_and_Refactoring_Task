using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    using System;

    class Coffee : Drink
    {

        public Coffee(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
        }
        
        /**
         * Метод, що готує каву.
         */
        public override void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Гріємо молоко та воду.");
            Thread.Sleep(3000);
            Console.WriteLine("Мелимо кавові зерна.");
            Thread.Sleep(3000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(3000);
            Console.WriteLine("Наливаємо каву у стакан.");
            SugarAdding();
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }
        

        
    }
}
