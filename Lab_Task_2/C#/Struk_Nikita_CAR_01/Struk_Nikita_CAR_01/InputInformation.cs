namespace Struk_Nikita_CAR_01
{
    internal class InputInformation
    {
        public static bool AreYouSure()  
        {
            Console.WriteLine("Ви впевнені у цьому?");
            Console.WriteLine("1 - Так, 0 - Ні");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice == 1;
        }
        /**
         * Метод, що дає змогу обрати своє замовлення.
         * Обравши необхідний вид напою, потрібно вказати підвид.
         */
        public static bool ChooseDrink()
        {
            Console.WriteLine("Оберіть бажаний напій. На зараз, ми можемо запропонувати такі напої:");
            DisplayInformation.ShowCoffeeOptions();
            DisplayInformation.ShowTeaOptions();
            DisplayInformation.ShowCacaoOptions();
            Console.WriteLine("1 - Кава, 2 - Чай, 3 - Какао");
            var drinkChoice = Convert.ToInt32(Console.ReadLine());
            switch (drinkChoice)
            {
                case 1:
                    {
                        Console.WriteLine("Ви обрали каву. Яку каву ви бажаєте?");
                        DisplayInformation.ShowCoffeeOptions();
                        var coffeeChoiceConfirmation = false;
                        while (!coffeeChoiceConfirmation)
                            coffeeChoiceConfirmation = ChooseDrinkSubtype(drinkChoice);
                        return true;
                    }
                case 2:
                    {
                        Console.WriteLine("Ви обрали чай. Який чай ви бажаєте?");
                        DisplayInformation.ShowTeaOptions();
                        var teaChoiceConfirmation = false;
                        while (!teaChoiceConfirmation)
                            teaChoiceConfirmation = ChooseDrinkSubtype(drinkChoice);
                        return true;
                    }
                case 3:
                    {
                        Console.WriteLine("Ви обрали какао. Яке какао ви бажаєте?");
                        DisplayInformation.ShowCacaoOptions();
                        var cacaoChoiceConfirmation = false;
                        while (!cacaoChoiceConfirmation)
                            cacaoChoiceConfirmation = ChooseDrinkSubtype(drinkChoice);
                        return true;
                    }
                default:
                    {
                        Console.WriteLine("Вибачте, але цей вибір є недійсним, спробуйте ще раз.\n");
                        return false;
                    }
            }
        }
        /**
         * Метод, що дає змогу обрати підвид напою.
         * Обравши необхідний підвид напою, йде його приготування
         */
        public static bool ChooseDrinkSubtype(int drinkTypeChoice)
        {
            int drinkSubtypeChoice = Convert.ToInt32(Console.ReadLine());
            var confirmation = AreYouSure();
            if (confirmation)
            {
                DisplayInformation.ShowCupSizeOptions();
                int cupSize;
                while (true)
                {
                    cupSize = ChooseCupSize();
                    if (cupSize is 100 or 200 or 300)
                    {
                        break;
                    }
                }
                var isSugarNeeded = SugarSuggestion.IsSugarNeeded();
                var sugarSpoons = 0;
                if (isSugarNeeded)
                {
                    sugarSpoons = SugarSuggestion.CalculateSugarSpoonsQuantity();
                }

                string drinkName;
                if (drinkTypeChoice == 1 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Еспрессо";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 1 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Американо";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 1 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Капучіно";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Чорний чай";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Зелений чай";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Червоний чай";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Звичайне какао";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Пряне какао";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Гарячий шоколад";
                    DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }

                return true;
            }
            Console.WriteLine("Повторіть свій вибір.");
            return false;
        }
        /**
         * Метод, що пропонує обрати розмір стаканчика серед запропонованих варіантів.
         */
        public static int ChooseCupSize()
        {
            var cupChoice = Convert.ToInt32(Console.ReadLine());
            switch (cupChoice)
            {
                case 1:
                    {
                        return 100;
                    }
                case 2:
                    {
                        return 200;
                    }
                case 3:
                    {
                        return 300;
                    }
                default:
                    {
                        Console.WriteLine("Вибачте, цей вибір є недійсним.");
                        return 0;
                    }
            }
        }
    }
}
