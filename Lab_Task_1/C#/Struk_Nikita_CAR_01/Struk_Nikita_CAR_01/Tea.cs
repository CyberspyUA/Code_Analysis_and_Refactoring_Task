using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    using System;

    public class Tea : Drink
    {
        private string drinkName;
        private int cupSize;
        private int sugarTeaSpoonQuantity;

        public Tea()
        {
        }

        public Tea(string teaName, int teaCupSize, int sugarSpoonQuantity)
        {
            drinkName = teaName;
            cupSize = teaCupSize;
            sugarTeaSpoonQuantity = sugarSpoonQuantity;
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

        public override void OrderShow()
        {
            Console.WriteLine(GetDrinkName());
            Console.WriteLine("Size of cup: " + GetCupSize());
            Console.WriteLine("Sugar full spoons: " + GetSugarTeaSpoonQuantity());
        }

        public void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Heating water.");
            Thread.Sleep(3000);
            Console.WriteLine("Shrinking tea leafs.");
            Thread.Sleep(3000);
            Console.WriteLine("Putting a cup.");
            Thread.Sleep(3000);
            Console.WriteLine("Pouring tea in the cup");
            SugarAdding();
            Console.WriteLine("Your " + GetDrinkName() + " is ready! Enjoy!");
            Console.WriteLine("-----------------------------------------------------------");
        }

        public void SugarAdding()
        {
            var sugar_spoons = GetSugarTeaSpoonQuantity();
            if (sugar_spoons == 0) return;
            Console.WriteLine("Adding " + sugar_spoons + " tea spoons of sugar");
            Thread.Sleep(1000);
        }
    }
}
