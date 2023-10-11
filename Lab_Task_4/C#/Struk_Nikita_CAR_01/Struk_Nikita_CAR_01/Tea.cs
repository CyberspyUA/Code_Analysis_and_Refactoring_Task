namespace Product
{
    using System;
    internal interface ITea
    {
        void ShowTeaFacts();
        string GetDrinkName();
        int GetCupSize();
        int GetSugarTeaSpoonQuantity();
        void SugarAdding();
        void Brewing();
        void OrderShow();
    }
    internal class Tea : Drink, ITea
    {
        
        public Tea(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
            drinkName = drinkName_;
            cupSize = cupSize_;
            sugarTeaSpoonQuantity = sugarTeaSpoonQuantity_;
        }
        public string GetDrinkName()
        {
            var copyDrinkName = drinkName;
            return copyDrinkName;
        }

        public int GetCupSize()
        {
            var copyCupSize = cupSize;
            return copyCupSize;
        }

        public int GetSugarTeaSpoonQuantity()
        {
            var copySugarTeaSpoonQuantity = sugarTeaSpoonQuantity;
            return copySugarTeaSpoonQuantity;
        }

        public void SugarAdding()
        {
            var sugarSpoons = GetSugarTeaSpoonQuantity();
            if (sugarSpoons == 0) return;
            Console.WriteLine("Додаємо " + sugarSpoons + " чайних ложок цукру");
            Thread.Sleep(1000);
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
        public void ShowTeaFacts()
        {
            Console.WriteLine("Цікаві факти про чай:");
            Console.WriteLine("1) Для приготування одного фунта чаю потрібно 2000 чайних листків.");
            Console.WriteLine("2) Чайні дерева можуть виростати до 52 футів (6.7 метрів)");
            Console.WriteLine("3) Португальці та голландці вперше завезли чай до Європи в 1610 році.");
        }
    }
}
