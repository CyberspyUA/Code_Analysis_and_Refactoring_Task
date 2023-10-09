namespace Product
{
    using System;

    internal class Coffee : Drink
    {
        protected int coffeePowderWeightinGramms; //Вага меленої кави у грамах.

        public Coffee(string drinkName_, int cupSize_, int sugarTeaSpoonQuantity_) 
            : base(drinkName_, cupSize_, sugarTeaSpoonQuantity_)
        {
            drinkName = drinkName_;
            cupSize = cupSize_;
            sugarTeaSpoonQuantity = sugarTeaSpoonQuantity_;
        }
        
        /**
         * Метод, що готує каву.
         */
        public override void Brewing()
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
        /**
         * Метод, що виводить цікаві факти про каву.
         */
        protected static void ShowCoffeeFacts()
        {
            Console.WriteLine("Цікаві факти про каву:");
            Console.WriteLine("1) Це 2-й за обсягом торгівлі товар у світі.  На першому місці - сира нафта.");
            Console.WriteLine("2) Кажуть, що каву відкрив пастух кіз в Ефіопії в 1500-х роках.  Він побачив, як його кози їдять кавову вишню.");
            Console.WriteLine("3) Вчені перетворюють олію з відходів меленої кави на біодизель, тож одного дня кава може заправляти ваш автомобіль.");
        }
    }
}
