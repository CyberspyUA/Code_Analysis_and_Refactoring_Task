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

        public static bool FuncIsSugarNeeded()
        {
            Console.WriteLine("Do you need sugar?");
            Console.WriteLine("1 - Yes; 0 - No");
            var isSugarNeededConfirmation = Convert.ToInt32(Console.ReadLine());
            return isSugarNeededConfirmation != 0;
        }

        public static int FuncSugarSpoonsQuantity()
        {
            var teaSpoon = 1;
            var isThatEnough = false;
            while (!isThatEnough)
            {
                Console.WriteLine("You have " + teaSpoon + " tea spoons of sugar.");
                Console.WriteLine("Do you need more sugar?");
                Console.WriteLine("1 - Yes; 0 - No");
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

                    Console.WriteLine("Are you sure you want to quit? \n 1 - Yes; 0 - No \n");
                    Console.WriteLine("Enter quit choice:");
                    var quitChoice = Convert.ToInt32(Console.ReadLine());
                    switch (quitChoice)
                    {
                        case 0:
                            return false;
                        case 1:
                            return true;
                        default:
                            Console.WriteLine("Sorry, that option is not available. Try again.");
                            return false;
                    }
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.");
                    return false;
                }
            }
        }

        public static void FuncOptionsShow()
        {
            Console.WriteLine("\t Please, input number from 1 to 4 by keyboard.");
            Console.WriteLine("\t Available options:");
            Console.WriteLine("1) Choose a drink");
            Console.WriteLine("2) Show all drinks");
            Console.WriteLine("3) Show help menu");
            Console.WriteLine("4) Quit vending machine.");
        }

        public static void FuncCoffeeShow()
        {
            Console.WriteLine("Coffee:");
            Console.WriteLine("\t1. Espresso");
            Console.WriteLine("\t2. Americano");
            Console.WriteLine("\t3. Cappuccino");
        }

        public static void FuncTeaShow()
        {
            Console.WriteLine("Tea: ");
            Console.WriteLine("\t1. Black tea");
            Console.WriteLine("\t2. Green tea");
            Console.WriteLine("\t3. Red tea");
        }

        public static void FuncCacaoShow()
        {
            Console.WriteLine("3) Cacao: ");
            Console.WriteLine("\t1. Original cacao");
            Console.WriteLine("\t2. Spiced cacao");
            Console.WriteLine("\t3. Hot chocolate");
        }


        public static void FuncInstructionsShow()
        {
            Console.WriteLine("\t\tGreetings customer! ");
            Console.WriteLine("\t This is a Struk.corp vending machine assistant.");
            Console.WriteLine("\t Firstly, I provide you with drinks menu. You can either choose one or quit.");
            Console.WriteLine("\t When drink is chosen. I should have some time to make you a drink.");
            Console.WriteLine("\t It takes from 10 up to 15 seconds.");
            Console.WriteLine("\t In addition for some drinks, I can serve you with sugar or other sweets.");
            Console.WriteLine("\t If any questions left, you can replay this message by entering 5");
        }

        public static void FuncCupSizeShow()
        {
            Console.WriteLine("Choose one cup among these:");
            Console.WriteLine("1) 100 ml");
            Console.WriteLine("2) 200 ml");
            Console.WriteLine("3) 300 ml");
        }

        public static bool FuncAreYouSure()
        {
            Console.WriteLine("Are you sure?");
            Console.WriteLine("1 - Yes, 0 - No");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice == 1;
        }

        public static bool FuncDrinkChoice()
        {
            Console.WriteLine("Now, choose a preferable drink. Here what we are serving at the moment.");
            FuncCoffeeShow();
            FuncTeaShow();
            FuncCacaoShow();
            Console.WriteLine("1 - Coffee, 2 - Tea, 3 - Cacao");
            var drinkChoice = Convert.ToInt32(Console.ReadLine());
            switch (drinkChoice)
            {
                case 1:
                {
                    Console.WriteLine("You chose coffee. What coffee drink do you want?");
                    FuncCoffeeShow();
                    var coffeeChoiceConfirmation = false;
                    while(!coffeeChoiceConfirmation)
                      coffeeChoiceConfirmation = FuncDrinkSubtypeChoice(drinkChoice);
                    return true;
                }
                case 2:
                {
                    Console.WriteLine("You chose tea. What tea drink do you want?");
                    FuncTeaShow();
                        var teaChoiceConfirmation = false;
                        while (!teaChoiceConfirmation)
                            teaChoiceConfirmation = FuncDrinkSubtypeChoice(drinkChoice);
                    return true;
                }
                case 3:
                {
                    Console.WriteLine("You chose cacao. What cacao drink do you want?");
                    FuncCacaoShow();
                    var cacaoChoiceConfirmation = false;
                    while (!cacaoChoiceConfirmation)
                            cacaoChoiceConfirmation = FuncDrinkSubtypeChoice(drinkChoice);
                    return true;
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.\n");
                    return false;
                }
            }
        }
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
                        drinkName = "Espresso";
                        DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 1 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Americano";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 1 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Cappuccino";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Black tea";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Green tea";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 2 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Red tea";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 1)
                {
                    drinkName = "Original cacao";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 2)
                {
                    drinkName = "Spiced cacao";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                else if (drinkTypeChoice == 3 && drinkSubtypeChoice == 3)
                {
                    drinkName = "Hot chocolate";
                    DrinkBrewing(drinkTypeChoice, drinkName, cupSize, sugarSpoons);
                }
                
                return true;
            }
            Console.WriteLine("Retype your choices.");
            return false;
        } 
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
                        Console.WriteLine("Sorry, but this choice is invalid, try again.");
                        return 0;
                    }
            }
        }
        public static void DrinkBrewing(int drinkTypeChoice, string drinkName, int cupSize, int sugarSpoons)
        {
            if(drinkTypeChoice == 1)
            {
                var coffee = new Coffee(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                coffee.OrderShow();
                Console.WriteLine("Now, wait for a coffee to get ready.");
                coffee.Brewing();
            }
            else if(drinkTypeChoice == 2)
            {
                var tea = new Tea(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                tea.OrderShow();
                Console.WriteLine("Now, wait for a tea to get ready.");
                tea.Brewing();
            }
            else if(drinkTypeChoice == 3)
            {
                var cacao = new Cacao(drinkName, cupSize, sugarSpoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                cacao.OrderShow();
                Console.WriteLine("Now, wait for a tea to get ready.");
                cacao.Brewing();
            }
        }

    }
}
