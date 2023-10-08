namespace Product
{
    using System;

    internal class Cacao : Drink
    {
        protected int cacaoPowderWeightinGramms; //Вага какао порошку у грамах.
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
        /**
        * Метод, що виводить цікаві факти про какао.
        */
        protected static void ShowCocoaFacts()
        {
            Console.WriteLine("Цікаві факти про какао: ");
            Console.WriteLine("1) Какао-дереву потрібно п'ять років, щоб дати перші какао-боби (стручки).");
            Console.WriteLine("2) Квітки какао можуть цвісти на какао-деревах цілий рік, однак, якщо їх не запилити, вони загинуть протягом 24 годин.");
            Console.WriteLine("3) Какао-боби називають \"Cocoa\", а не \"Cacao\" через орфографічну помилку, допущену англійськими імпортерами у 18 столітті, коли шоколад став популярним.");
        }
    }
}
