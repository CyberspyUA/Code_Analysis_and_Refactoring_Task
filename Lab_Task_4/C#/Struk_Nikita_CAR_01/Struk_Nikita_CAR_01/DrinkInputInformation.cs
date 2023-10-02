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
            var drinkSubtypeChoice = Convert.ToInt32(Console.ReadLine());
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
                switch (drinkTypeChoice)
                {
                    case 1:
                        switch (drinkSubtypeChoice)
                        {
                            case 1:
                                drinkName = "Еспрессо";
                                break;
                            case 2:
                                drinkName = "Американо";
                                break;
                            case 3:
                                drinkName = "Капучiно";
                                break;
                            default:
                                throw new ArgumentException("Некоректний вибір напою.");
                        }
                        break;
                    case 2:
                        switch (drinkSubtypeChoice)
                        {
                            case 1:
                                drinkName = "Чорний чай";
                                break;
                            case 2:
                                drinkName = "Зелений чай";
                                break;
                            case 3:
                                drinkName = "Червоний чай";
                                break;
                            default:
                                throw new ArgumentException("Некоректний вибір напою.");
                        }
                        break;
                    case 3:
                        switch (drinkSubtypeChoice)
                        {
                            case 1:
                                drinkName = "Звичайне какао";
                                break;
                            case 2:
                                drinkName = "Пряне какао";
                                break;
                            case 3:
                                drinkName = "Гарячий шоколад";
                                break;
                            default:
                                throw new ArgumentException("Некоректний вибір напою.");
                        }
                        break;
                    default:
                        throw new ArgumentException("Некоректний вибір напою.");
                }
                DrinkOrder.DisplayOrderAndBrewDrink(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                return true;
            }
            Console.WriteLine("Повторiть свiй вибiр.");
            return false;
        }
        /**
         * Метод, що перевіряє правильність введеного розміру стакану.
         */
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
