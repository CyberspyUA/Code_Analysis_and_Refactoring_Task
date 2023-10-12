using System.ComponentModel.DataAnnotations;

namespace Product
{
    public class DrinkData
    {
        protected string drinkName;
        protected int cupSize;
        protected int sugarTeaSpoonQuantity;
        public string DrinkName
        {
            get => drinkName;
            set => drinkName = value;
        }

        public int CupSize
        {
            get => cupSize;
            set => cupSize = value;
        }

        public int SugarTeaSpoonsQuantity
        {
            get => sugarTeaSpoonQuantity;
            set => sugarTeaSpoonQuantity = value;
        }
    }

    internal abstract class Drink
    {
        private DrinkData data; // Массив даних про напій, виокремлений у клас.
        protected decimal priceOfIngredients; //Фіксована ціна інгредіентів за 1 напій.
        protected decimal priceOfCup; //Фіксована ціна стаканчику за 1 напій.
        protected decimal priceOfSugar; //Фіксована ціна цукру за 1 напій.
        protected decimal taxForIngredients; //Фіксований податок на інгредіенти за 1 напій.
        protected decimal taxForCup; //Фіксований податок на стаканчик за 1 напій.
        protected decimal taxForSugar; //Фіксований податок на цукор за 1 напій.

        protected Drink(DrinkData data)
        {
            this.data = data;
        }

        public string GetDrinkName()
        {
            return data.DrinkName;
        }

        public int GetCupSize ()
        {
            return data.CupSize;
        }

        public int GetSugarTeaSpoonsQuantity()
        {
           return data.SugarTeaSpoonsQuantity;
        }

        public void SetDrinkName(string drinkName)
        {
            data.DrinkName = drinkName;
        }

        public void SetCupSize(int cupSize)
        {
            data.CupSize = cupSize;
        }

        public void SetSugarTeaSpoonsQuantity(int sugarTeaSpoonsQuantity)
        {
            data.SugarTeaSpoonsQuantity = sugarTeaSpoonsQuantity;
        }

        /**
         * Метод, що додає ложки цукру до напою.
         */
        protected void SugarAdding()
        {
            var sugarSpoons = GetSugarTeaSpoonsQuantity();
            if (sugarSpoons == 0) return;
            Console.WriteLine("Додаємо " + sugarSpoons + " чайних ложок цукру");
            Thread.Sleep(1000);
        }
        /**
         * Метод, що виводить деталi замовлення.
         */

        public void OrderShow()
        {
            Console.WriteLine(GetDrinkName());
            Console.WriteLine("Об'єм стакану: " + GetCupSize());
            Console.WriteLine("Додано: " + GetSugarTeaSpoonsQuantity() + " ложок цукру.");
        }
        /**
         * Метод, що готує напiй за введеними даними.
         */
        public abstract void Brewing();

        public abstract void CountPriceOfDrink();
    }
}
