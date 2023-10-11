namespace Product
{
    using System;

    internal class Tea : Drink
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
            Console.WriteLine("Грiємо воду.");
            Thread.Sleep(3000);
            Console.WriteLine("Мелимо чайне листя.");
            Thread.Sleep(3000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(3000);
            Console.WriteLine("Наливаємо чай у стакан.");
            SugarAdding();
            Console.WriteLine("Ваш " + DrinkName + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }

        
    }
}
