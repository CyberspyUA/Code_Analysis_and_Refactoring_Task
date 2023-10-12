namespace Product
{
    using System;

    internal class Tea : Drink
    {

        public Tea(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
            taxForIngredients = 7;
            taxForCup = 2;
            taxForSugar = 1;
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

        public override void CountPriceOfDrink()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Вартість напою із урахуванням податків:");
            Console.WriteLine("Кофе: ", priceOfIngredients + taxForIngredients);
            Console.WriteLine("Стакан: ", priceOfCup + taxForCup);
            Console.WriteLine("Цукор: ", priceOfSugar + taxForSugar);
            Console.WriteLine("-----------------------------------------------------------");
        }
        
    }
}
