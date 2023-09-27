using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    using System;

    public class Tea : Drink
    {

        public Tea(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
        }
        /**
         * Метод, що готує чай.
         */
        public override void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Гріємо воду.");
            Thread.Sleep(3000);
            Console.WriteLine("Мелимо чайне листя.");
            Thread.Sleep(3000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(3000);
            Console.WriteLine("Наливаємо чай у стакан.");
            SugarAdding();
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }

        
    }
}
