using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    public abstract class Drink
    {
        public Drink() { }

        ~Drink() { }

        public abstract void order_show();
    }
}
