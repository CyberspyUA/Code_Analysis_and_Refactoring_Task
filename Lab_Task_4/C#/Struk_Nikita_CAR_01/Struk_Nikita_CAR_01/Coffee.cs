namespace Product
{

    internal interface ICoffee
    {
        void ShowCoffeeFacts();
        string GetDrinkName();
        int GetCupSize();
        int GetSugarTeaSpoonQuantity();
        void SugarAdding();
        void Brewing();
        void OrderShow();
    }

    internal class Coffee : IDrink, ICoffee
    {
        protected string drinkName; //Назва напою
        protected int cupSize; // Розмiр стаканчика
        protected int sugarTeaSpoonQuantity; //Кiлькiсть чайних ложок цукру.
        public Coffee(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_)
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

        public virtual void Brewing()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Грiємо молоко та воду.");
            Thread.Sleep(3000);
            Console.WriteLine("Мелимо кавовi зерна.");
            Thread.Sleep(3000);
            Console.WriteLine("Готуємо стакан.");
            Thread.Sleep(3000);
            Console.WriteLine("Наливаємо каву у стакан.");
            SugarAdding();
            Console.WriteLine("Ваш " + GetDrinkName() + " готовий! Смачного!");
            Console.WriteLine("-----------------------------------------------------------");
        }

        public void ShowCoffeeFacts()
        {
            Console.WriteLine("Цікаві факти про каву:");
            Console.WriteLine("1) Це 2-й за обсягом торгівлі товар у світі.  На першому місці - сира нафта.");
            Console.WriteLine("2) Кажуть, що каву відкрив пастух кіз в Ефіопії в 1500-х роках.  Він побачив, як його кози їдять кавову вишню.");
            Console.WriteLine("3) Вчені перетворюють олію з відходів меленої кави на біодизель, тож одного дня кава може заправляти ваш автомобіль.");
        }

        public void OrderShow()
        {
            Console.WriteLine(GetDrinkName());
            Console.WriteLine("Об'єм стакану: " + GetCupSize());
            Console.WriteLine("Додано: " + GetSugarTeaSpoonQuantity() + "ложок цукру.");
        }
    }
}
