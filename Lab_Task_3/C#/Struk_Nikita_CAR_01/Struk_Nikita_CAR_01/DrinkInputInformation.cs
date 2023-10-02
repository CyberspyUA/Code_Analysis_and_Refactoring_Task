namespace UI
{
    internal static class DrinkInputInformation
    {
        public static bool AreYouSure()
        {
            Console.WriteLine("Ви впевненi у цьому?");
            Console.WriteLine("1 - Так, 0 - Нi");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice == 1;
        }
        /**
         * Метод, що дає змогу обрати своє замовлення.
         * Обравши необхiдний вид напою, потрiбно вказати пiдвид.
         */
        public static bool ChooseDrink()
        {
            Console.WriteLine("Оберiть бажаний напiй. На зараз, ми можемо запропонувати такi напої:");
            DisplayOptions.ShowCoffeeOptions();
            DisplayOptions.ShowTeaOptions();
            DisplayOptions.ShowCacaoOptions();
            Console.WriteLine("1 - Кава, 2 - Чай, 3 - Какао");
            var drinkChoice = Convert.ToInt32(Console.ReadLine());
            switch (drinkChoice)
            {
                case 1:
                    {
                        Console.WriteLine("Ви обрали каву. Яку каву ви бажаєте?");
                        DisplayOptions.ShowCoffeeOptions();
                        var coffeeChoiceConfirmation = false;
                        while (!coffeeChoiceConfirmation)
                            coffeeChoiceConfirmation = ChooseDrinkSubtype(drinkChoice);
                        return true;
                    }
                case 2:
                    {
                        Console.WriteLine("Ви обрали чай. Який чай ви бажаєте?");
                        DisplayOptions.ShowTeaOptions();
                        var teaChoiceConfirmation = false;
                        while (!teaChoiceConfirmation)
                            teaChoiceConfirmation = ChooseDrinkSubtype(drinkChoice);
                        return true;
                    }
                case 3:
                    {
                        Console.WriteLine("Ви обрали какао. Яке какао ви бажаєте?");
                        DisplayOptions.ShowCacaoOptions();
                        var cacaoChoiceConfirmation = false;
                        while (!cacaoChoiceConfirmation)
                            cacaoChoiceConfirmation = ChooseDrinkSubtype(drinkChoice);
                        return true;
                    }
                default:
                    {
                        Console.WriteLine("Вибачте, але цей вибiр є недiйсним, спробуйте ще раз.\n");
                        return false;
                    }
            }
        }
        /**
         * Метод, що дає змогу обрати пiдвид напою.
         * Обравши необхiдний пiдвид напою, йде його приготування
         */
        public static bool ChooseDrinkSubtype(int drinkTypeChoice)
        {
            int drinkSubtypeChoice = Convert.ToInt32(Console.ReadLine());
            var confirmation = AreYouSure();
            if (confirmation)
            {
                DisplayOptions.ShowCupSizeOptions();
                int cupSize;
                while (true)
                {
                    cupSize = ChooseCupSize();
                    if (IsCupSizeValid(cupSize))
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
                    drinkName = "Капучiно";
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
            Console.WriteLine("Повторiть свiй вибiр.");
            return false;
        }

        public static bool IsCupSizeValid(int cupSize)
        {
            return cupSize is 100 or 200 or 300;
        }

        /**
         * Метод, що пропонує обрати розмiр стаканчика серед запропонованих варiантiв.
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
                        Console.WriteLine("Вибачте, цей вибiр є недiйсним.");
                        return 0;
                    }
            }
        }
    }
}
