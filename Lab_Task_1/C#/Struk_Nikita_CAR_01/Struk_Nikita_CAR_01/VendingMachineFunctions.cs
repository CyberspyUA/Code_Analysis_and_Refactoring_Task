using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Struk_Nikita_CAR_01
{
    internal class VendingMachineFunctions
    {
        public static VendingMachineFunctions CreateInstance()
        {
            return new VendingMachineFunctions();
        }
        //Метод, який питає користувача про необхідність цукру у напої.
        public static bool FuncIsSugarNeeded()
        {
            Console.WriteLine("Вам потрібен цукор?");
            Console.WriteLine("1 - Так; 0 - Ні");
            var isSugarNeededConfirmation = Convert.ToInt32(Console.ReadLine());
            return isSugarNeededConfirmation != 0;
        }
        /**
         * Метод, що викликається у разі, якщо користувач бажає цукру.
         * Додає певну кількість ложок цукру
         */
        public static int FuncSugarSpoonsQuantity()
        {
            var teaSpoon = 1;
            var isThatEnough = false;
            while (!isThatEnough)
            {
                Console.WriteLine("До напою додано " + teaSpoon + " чайних ложок цукру.");
                Console.WriteLine("Більше цукру?");
                Console.WriteLine("1 - Так; 0 - Ні");
                var moreSugarChoice = Convert.ToBoolean(Console.ReadLine());
                if (moreSugarChoice)
                {
                    teaSpoon++;
                }
                else
                {
                    isThatEnough = true;
                }
            }

            return teaSpoon;
        }
        /**
         * Метод, що викликає основне меню.
         * Є відправною точкою у взаємодії між користувачем та автоматом.
         */
        public static bool FuncMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                {
                    FuncDrinkChoice();
                    return false;
                }
                case 2:
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    FuncCoffeeShow();
                    Console.WriteLine("-----------------------------------------------------------------");
                    FuncTeaShow();
                    Console.WriteLine("-----------------------------------------------------------------");
                    FuncCacaoShow();
                    Console.WriteLine("-----------------------------------------------------------------");
                    return false;
                }
                
                case 3:
                {
                    FuncInstructionsShow();
                    return false;
                }
                case 4:
                {

                    Console.WriteLine("Ви впевнені в тому, що бажаєте завершити роботу застосунку? \n 1 - Так; 0 - Ні \n");
                    Console.WriteLine("Введіть варіант відповіді:");
                    var quitChoice = Convert.ToInt32(Console.ReadLine());
                    switch (quitChoice)
                    {
                        case 0:
                            return false;
                        case 1:
                            return true;
                        default:
                            Console.WriteLine("Вибачте, ця варіант є недоступним. Спробуйте ще раз.");
                            return false;
                    }
                }
                default:
                {
                    Console.WriteLine("Вибачте, але цей вибір є недійсним, спробуйте ще раз.");
                    return false;
                }
            }
        }
        /**
         * Метод, що показує доступні варіанти взаємодії між користувачем та автоматом.
         */
        public static void FuncOptionsShow()
        {
            Console.WriteLine("\t Будь ласка, введіть з клавіатури число від 1 до 4.");
            Console.WriteLine("\t Доступні варіанти:");
            Console.WriteLine("1) Оберіть напій");
            Console.WriteLine("2) Показати всі напої");
            Console.WriteLine("3) Показати меню довідки");
            Console.WriteLine("4) Завершити роботу застосунку");
        }
        /**
         * Метод, що демонструє доступний вибір серед кавових напоїв.
         */
        public static void FuncCoffeeShow()
        {
            Console.WriteLine("Кава:");
            Console.WriteLine("\t1. Еспрессо");
            Console.WriteLine("\t2. Американо");
            Console.WriteLine("\t3. Капучіно");
        }
        /**
         * Метод, що демонструє доступний вибір серед чайних напоїв.
         */
        public static void FuncTeaShow()
        {
            Console.WriteLine("Чай: ");
            Console.WriteLine("\t1. Чорний чай");
            Console.WriteLine("\t2. Зелений чай");
            Console.WriteLine("\t3. Червоний чай");
        }
        /**
         * Метод, що демонструє доступний вибір серед какао напоїв.
         */
        public static void FuncCacaoShow()
        {
            Console.WriteLine("3) Какао: ");
            Console.WriteLine("\t1. Звичайне какао");
            Console.WriteLine("\t2. Пряне какао");
            Console.WriteLine("\t3. Гарячий шоколад");
        }

        /**
         * Метод, що описує роботу автомата.
         */
        public static void FuncInstructionsShow()
        {
            Console.WriteLine("\t\tВітаємо вас! ");
            Console.WriteLine("\t Це помічник торгового автомата Struk.corp.");
            Console.WriteLine("\t По-перше, ми надамо вам меню напоїв. Ви можете вибрати один з них або відмовитися.");
            Console.WriteLine("\t Коли обрете напій, нам необхідно трохи часу, щоб приготувати його.");
            Console.WriteLine("\t Це займає від 10 до 15 секунд.");
            Console.WriteLine("\t Додатково, ми пропонуємо цукор до замовлення.");
            Console.WriteLine("\t Якщо у вас залишилися питання, введіть 5 для повторного виведення цієї довідки.");
        }
        /**
         * Метод, що демонструє доступний вибір розміру стаканів.
         */
        public static void FuncCupSizeShow()
        {
            Console.WriteLine("Оберіть серед запропонованих:");
            Console.WriteLine("1) 100 мл");
            Console.WriteLine("2) 200 мл");
            Console.WriteLine("3) 300 мл");
        }
        /**
         * Метод, що перевіряє підтвердження користувачем його введеного вибору.
         */
        public static bool FuncAreYouSure()
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
        public static bool FuncDrinkChoice()
        {
            Console.WriteLine("Оберіть бажаний напій. На зараз, ми можемо запропонувати такі напої:");
            FuncCoffeeShow();
            FuncTeaShow();
            FuncCacaoShow();
            Console.WriteLine("1 - Кава, 2 - Чай, 3 - Какао");
            var drinkChoice = Convert.ToInt32(Console.ReadLine());
            switch (drinkChoice)
            {
                case 1:
                {
                    Console.WriteLine("Ви обрали каву. Яку каву ви бажаєте?");
                    FuncCoffeeShow();
                    var coffeeChoiceConfirmation = false;
                    while(!coffeeChoiceConfirmation)
                      coffeeChoiceConfirmation = FuncDrinkSubtypeChoice(drinkChoice);
                    return true;
                }
                case 2:
                {
                    Console.WriteLine("Ви обрали чай. Який чай ви бажаєте?");
                    FuncTeaShow();
                        var teaChoiceConfirmation = false;
                        while (!teaChoiceConfirmation)
                            teaChoiceConfirmation = FuncDrinkSubtypeChoice(drinkChoice);
                    return true;
                }
                case 3:
                {
                    Console.WriteLine("Ви обрали какао. Яке какао ви бажаєте?");
                    FuncCacaoShow();
                    var cacaoChoiceConfirmation = false;
                    while (!cacaoChoiceConfirmation)
                            cacaoChoiceConfirmation = FuncDrinkSubtypeChoice(drinkChoice);
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
        public static bool FuncDrinkSubtypeChoice(int drinkTypeChoice)
        {
            int drinkSubtypeChoice = Convert.ToInt32(Console.ReadLine());
            var confirmation = FuncAreYouSure();
            if (confirmation)
            {
                FuncCupSizeShow();
                int cupSize;
                while (true)
                {
                    cupSize = FuncCupSizeChoice();
                    if (cupSize is 100 or 200 or 300)
                    {
                        break;
                    }
                }
                var isSugarNeeded = FuncIsSugarNeeded();
                var sugarSpoons = 0;
                if (isSugarNeeded)
                {
                    sugarSpoons = FuncSugarSpoonsQuantity();
                }

                string drinkName;
                if (drinkTypeChoice == 1 && drinkSubtypeChoice == 1)
                {
                        drinkName = "Еспрессо";
                        DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 1 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Американо";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 1 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Капучіно";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Чорний чай";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Зелений чай";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Червоний чай";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Звичайне какао";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Пряне какао";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Гарячий шоколад";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                
                return true;
            }
            Console.WriteLine("Повторіть свій вибір.");
            return false;
        } 
        /**
         * Метод, що пропонує обрати розмір стаканчика серед запропонованих варіантів.
         */
        public static int FuncCupSizeChoice()
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
        /**
         * Метод, що виводить деталі замовлення користувача та розпочинає процес приготування.
         */
        public static void DrinkBrewing(int drinkTypeChoice, string drinkName, int cupSize, int sugarSpoons)
        {
            if(drinkTypeChoice == 1)
            {
                var coffee = new Coffee(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Ваше замовлення");
                Console.WriteLine("-----------------------------------------------------------------");
                coffee.OrderShow();
                Console.WriteLine("Очікуйте на завершення приготування напою");
                coffee.Brewing();
            }
            else if(drinkTypeChoice == 2)
            {
                var tea = new Tea(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                tea.OrderShow();
                Console.WriteLine("Очікуйте на завершення приготування чаю");
                tea.Brewing();
            }
            else if(drinkTypeChoice == 3)
            {
                var cacao = new Cacao(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                cacao.OrderShow();
                Console.WriteLine("Очікуйте на завершення приготування какао");
                cacao.Brewing();
            }
        }

    }
}
