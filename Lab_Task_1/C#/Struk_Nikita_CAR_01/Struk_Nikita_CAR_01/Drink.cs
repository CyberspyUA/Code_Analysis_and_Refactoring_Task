using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    public abstract class Drink
    {
        protected string drinkName;
        protected int cupSize;
        protected int sugarTeaSpoonQuantity;

        protected Drink(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_)
        {
            drinkName = drinkName_;
            cupSize = cupSize_;
            sugarTeaSpoonQuantity = sugarTeaSpoonQuantity_;
        }

        public abstract void OrderShow();
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

        public void SetDrinkName(string newDrinkName)
        {
            drinkName = newDrinkName;
        }

        public void SetCupSize(int newCupSize)
        {
            cupSize = newCupSize;
        }

        public void SetSugarTeaSpoonQuantity(int newSugarSpoonQuantity)
        {
            sugarTeaSpoonQuantity = newSugarSpoonQuantity;
        }

    }
}
