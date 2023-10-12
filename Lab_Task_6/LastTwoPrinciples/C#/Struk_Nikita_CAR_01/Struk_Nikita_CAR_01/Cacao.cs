﻿namespace Product
{
    using System;

    internal class Cacao : Drink
    {
        public Cacao(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
            taxForIngredients = 6;
            taxForCup = 2;
            taxForSugar = 1;
        }
        /**
         * Метод, що готує какао.
         */
        public override void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Розiгрiваємо молоко...");
            Thread.Sleep(4000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(2000);
            Console.WriteLine("Наливаємо какао у стакан.");
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
