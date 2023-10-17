namespace Product
{
    internal abstract class Drink
    {
        protected string drinkName; //Назва напою
        protected int cupSize; // Розмiр стаканчика
        protected int sugarTeaSpoonQuantity; //Кiлькiсть чайних ложок цукру.
        protected Drink(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_)
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
        /**
         * Метод, що додає ложки цукру до напою.
         */
        protected void SugarAdding()
        {
            if (GetSugarTeaSpoonQuantity() == 0) return;
            Console.WriteLine("Додаємо " + GetSugarTeaSpoonQuantity() + " чайних ложок цукру");
            Thread.Sleep(1000);
        }
        /**
         * Метод, що виводить деталi замовлення.
         */

        public void OrderShow()
        {
            Console.WriteLine(GetDrinkName());
            Console.WriteLine("Об'єм стакану: " + GetCupSize());
            Console.WriteLine("Додано: " + GetSugarTeaSpoonQuantity() + "ложок цукру.");
        }
        /**
         * Метод, що готує напiй за введеними даними.
         */
        public abstract void Brewing();
    }
}
