namespace Product
{
    using System;

    internal class Coffee : Drink
    {

        public Coffee(DrinkData drinkData) 
            : base(drinkData)
        {
            priceOfIngredients = 17;
            priceOfCup = 2;
            priceOfSugar = 1;
            taxForIngredients = 5;
            taxForCup = 2;
            taxForSugar = 1;
        }
        
        /**
         * Метод, що готує каву.
         */
        public override void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Грiємо молоко та воду.");
            Thread.Sleep(3000);
            Console.WriteLine("Мелимо кавовi зерна.");
            Thread.Sleep(3000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(3000);
            Console.WriteLine("Наливаємо каву у стакан.");
            SugarAdding();
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
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
