using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    public abstract class Drink
    {
        protected string drinkName; //Назва напою
        protected int cupSize; // Розмір стаканчика
        protected int sugarTeaSpoonQuantity; //Кількість чайних ложок цукру.

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
        public void SugarAdding()
        {
            var sugarSpoons = GetSugarTeaSpoonQuantity();
            if (sugarSpoons == 0) return;
            Console.WriteLine("Додаємо " + sugarSpoons + " чайних ложок цукру");
            Thread.Sleep(1000);
        }
        /**
         * Метод, що виводить деталі замовлення.
         */

        public void OrderShow()
        {
            Console.WriteLine(GetDrinkName());
            Console.WriteLine("Об'єм стакану: " + GetCupSize());
            Console.WriteLine("Додано: " + GetSugarTeaSpoonQuantity() + "ложок цукру.");
        }
        /**
         * Метод, що готує напій за введеними даними.
         */
        public abstract void Brewing();
    }
}
