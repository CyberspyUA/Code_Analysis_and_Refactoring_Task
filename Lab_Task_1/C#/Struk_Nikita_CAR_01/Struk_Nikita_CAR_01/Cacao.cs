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
        private string drink_name;
        private int cup_size;
        private int sugar_tea_spoon_quantity;

        public Cacao()
        {
        }

        public Cacao(string cacao_name, int cacao_cup_size, int sugar_spoon_quantity)
        {
            drink_name = cacao_name;
            cup_size = cacao_cup_size;
            sugar_tea_spoon_quantity = sugar_spoon_quantity;
        }

        ~Cacao() { }

        public string get_drink_name()
        {
            string copy_drink_name = drink_name;
            return copy_drink_name;
        }

        public int get_cup_size()
        {
            int copy_cup_size = cup_size;
            return copy_cup_size;
        }

        public int get_sugar_tea_spoon_quantity()
        {
            int copy_sugar_tea_spoon_quantity = sugar_tea_spoon_quantity;
            return copy_sugar_tea_spoon_quantity;
        }

        public void SetDrinkName(string new_drink_name)
        {
            drink_name = new_drink_name;
        }

        public void SetCupSize(int new_cup_size)
        {
            cup_size = new_cup_size;
        }

        public void SetSugarTeaSpoonQuantity(int new_sugar_spoon_quantity)
        {
            sugar_tea_spoon_quantity = new_sugar_spoon_quantity;
        }
        public override void order_show()
        {
        }
    }
}
