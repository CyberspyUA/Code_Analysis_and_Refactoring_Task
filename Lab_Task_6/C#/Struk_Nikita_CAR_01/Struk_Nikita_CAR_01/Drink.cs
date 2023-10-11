namespace Product
{
    internal abstract class Drink
    {
        protected Drink(string drinkName, int cupSize, int sugarTeaSpoonQuantity)
        {
            DrinkName = drinkName;
            CupSize = cupSize;
            SugarTeaSpoonsQuantity = sugarTeaSpoonQuantity;
        }

        public string DrinkName { get; set; }

        public int CupSize { get; set; }

        public int SugarTeaSpoonsQuantity { get; set; }

        protected int GetSugarTeaSpoonQuantity()
        {
            var copySugarTeaSpoonQuantity = SugarTeaSpoonsQuantity;
            return copySugarTeaSpoonQuantity;
        }
        /**
         * Метод, що додає ложки цукру до напою.
         */
        protected void SugarAdding()
        {
            var sugarSpoons = GetSugarTeaSpoonQuantity();
            if (sugarSpoons == 0) return;
            Console.WriteLine("Додаємо " + sugarSpoons + " чайних ложок цукру");
            Thread.Sleep(1000);
        }
        /**
         * Метод, що виводить деталi замовлення.
         */

        public void OrderShow()
        {
            Console.WriteLine(DrinkName);
            Console.WriteLine("Об'єм стакану: " + CupSize);
            Console.WriteLine("Додано: " + GetSugarTeaSpoonQuantity() + " ложок цукру.");
        }
        /**
         * Метод, що готує напiй за введеними даними.
         */
        public abstract void Brewing();
    }
}
