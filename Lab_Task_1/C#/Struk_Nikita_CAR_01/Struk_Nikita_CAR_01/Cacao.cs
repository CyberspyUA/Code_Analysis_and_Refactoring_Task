using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    using System;

    class Cacao : Drink
    {
        public Cacao(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
        }

        ~Cacao() { }

        public override void OrderShow()
        {
            Console.WriteLine(GetDrinkName());
            Console.WriteLine("Size of cup: " + GetCupSize());
            Console.WriteLine("Sugar full spoons: " + GetSugarTeaSpoonQuantity());
        }
        public void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Heating milk.");
            Thread.Sleep(4000);
            Console.WriteLine("Putting a cup.");
            Thread.Sleep(2000);
            Console.WriteLine("Pouring cacao in the cup");
            SugarAdding();
            Console.WriteLine("Your " + GetDrinkName() + " is ready! Enjoy!");
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void SugarAdding()
        {
            var sugarSpoons = GetSugarTeaSpoonQuantity();
            if (sugarSpoons == 0) return;
            Console.WriteLine("Adding " + sugarSpoons + " tea spoons of sugar");
            Thread.Sleep(1000);
        }
    }
}
