namespace Product
{
    using System;

    internal class Tea : Drink
    {
        protected int teaLeafsWeightinGramms; //Вага листів чаю у грамах.
        public Tea(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
            drinkName = drinkName_;
            cupSize = cupSize_;
            sugarTeaSpoonQuantity = sugarTeaSpoonQuantity_;
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
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }
        /**
         * Метод, що виводить цікаві факти про чай.
         */
        protected static void ShowTeaFacts()
        {
            Console.WriteLine("Цікаві факти про чай:");
            Console.WriteLine("1) Для приготування одного фунта чаю потрібно 2000 чайних листків.");
            Console.WriteLine("2) Чайні дерева можуть виростати до 52 футів (6.7 метрів)");
            Console.WriteLine("3) Португальці та голландці вперше завезли чай до Європи в 1610 році.");
        }
    }
}
