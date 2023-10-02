namespace Product
{
    using System;

    internal class Cacao : Drink
    {
        public Cacao(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
            drinkName = drinkName_;
            cupSize = cupSize_;
            sugarTeaSpoonQuantity = sugarTeaSpoonQuantity_;
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
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
