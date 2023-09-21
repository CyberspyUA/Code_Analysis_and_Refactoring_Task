using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    using System;

    class Cacao : Drink
    {
        public Cacao(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
        }
        /**
         * Метод, що готує какао.
         */
        public override void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Розігріваємо молоко...");
            Thread.Sleep(4000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(2000);
            Console.WriteLine("Наливаємо какао у стакан.");
            SugarAdding();
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
