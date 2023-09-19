using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struk_Nikita_CAR_01
{
    internal class Vending_machine_functions
    {
        static bool func_is_sugar_needed()
        {
            bool is_sugar_needed_confirmation = false;
            Console.WriteLine("Do you need sugar?");
            Console.WriteLine("1 - Yes; 0 - No");
            is_sugar_needed_confirmation = Convert.ToBoolean(Console.ReadLine());
            return is_sugar_needed_confirmation;
        }

        static int func_sugar_spoons_quantity()
        {
            int tea_spoon = 1;
            bool is_that_enough = false;
            while (!is_that_enough)
            {
                bool more_sugar_choice = true;
                Console.WriteLine("You have " + tea_spoon + " tea spoons of sugar.");
                Console.WriteLine("Do you need more sugar?");
                Console.WriteLine("1 - Yes; 0 - No");
                more_sugar_choice = Convert.ToBoolean(Console.ReadLine());
                if (more_sugar_choice)
                {
                    tea_spoon++;
                }
                else
                {
                    is_that_enough = true;
                }
            }

            return tea_spoon;
        }

        static bool func_is_dopping_needed()
        {
            bool is_dopping_needed_confirmation = false;
            Console.WriteLine("Do you need doping?");
            Console.WriteLine("1 - Yes; 0 - No");
            is_dopping_needed_confirmation = Convert.ToBoolean(Console.ReadLine());
            return is_dopping_needed_confirmation;
        }

        string func_dopping_choice()
        {
            int dopping_choice = 0;
            func_dopings_show();
            dopping_choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (dopping_choice)
            {
                case 1:
                {
                    return "Chocolate doping\n";
                }
                case 2:
                {
                    return "Caramel doping\n";
                }
                case 3:
                {
                    return "Strawberry doping\n";
                }
                case 4:
                {
                    return "Huckleberry doping\n";
                }
                case 5:
                {
                    return "Raspberry doping\n";
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.\n");
                    return "";
                }
            }
        }

        bool func_are_sweets_needed()
        {
            bool is_dopping_needed_confirmation = false;
            Console.WriteLine("Do you need sweets?");
            Console.WriteLine("1 - Yes; 0 - No");
            is_dopping_needed_confirmation = Convert.ToBoolean(Console.ReadLine());
            return is_dopping_needed_confirmation;
        }

        string func_sweets_choice()
        {
            int sweets_choice = 0;
            func_sweets_show();
            sweets_choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (sweets_choice)
            {
                case 1:
                {
                    return "Original cacao\n";
                }
                case 2:
                {
                    return "Spiced cacao\n";
                }
                case 3:
                {
                    return "Hot chocolate\n";
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.\n");
                    return "";
                }
            }
        }

        bool func_menu(int choice)
        {
            switch (choice)
            {
                case 1:
                {
                    func_drink_choice();
                    return false;
                    break;
                }
                case 2:
                {
                    func_coffee_show();
                    Console.WriteLine("-----------------------------------------------------------------");
                    func_tea_show();
                    Console.WriteLine("-----------------------------------------------------------------");
                    func_cacao_show();
                    Console.WriteLine("-----------------------------------------------------------------");
                    return false;
                    break;
                }
                case 3:
                {
                    func_sweets_show();
                    return false;
                    break;
                }
                case 4:
                {
                    func_dopings_show();
                    return false;
                    break;
                }
                case 5:
                {
                    func_instructions_show();
                    return false;
                    break;
                }
                case 6:
                {
                    func_location_show();
                    return false;
                    break;
                }
                case 7:
                {

                    Console.WriteLine("Are you sure you want to quit? \n 1 - Yes; 0 - No \n");
                    input_quit_option_again:
                    int quit_choice = 0;
                    Console.WriteLine("Enter quit choice:");
                    quit_choice = Convert.ToInt32(Console.ReadLine());
                    if (quit_choice == 0)
                    {
                        return false;
                    }
                    else if (quit_choice == 1)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that option is not available. Try again.");
                        goto input_quit_option_again;
                    }

                    break;
                    return false;
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.");
                    return false;
                    break;
                }
            }
        }

        static void func_options_show()
        {
            Console.WriteLine("\t Please, input number from 1 to 7 by keyboard.");
            Console.WriteLine("\t Available options:");
            Console.WriteLine("1) Choose a drink");
            Console.WriteLine("2) Show all drinks");
            Console.WriteLine("3) Show all sweets");
            Console.WriteLine("4) Show all dopings");
            Console.WriteLine("5) Show help menu");
            Console.WriteLine("6) Locations of other vending machines");
            Console.WriteLine("7) Quit vending machine.");
        }

        static void func_coffee_show()
        {
            Console.WriteLine("Coffee:");
            Console.WriteLine("\t1. Esspresso");
            Console.WriteLine("\t2. Americano");
            Console.WriteLine("\t3. Cappuccino");
            Console.WriteLine("\t4. Makoto");
            Console.WriteLine("\t5. Doppio");
            Console.WriteLine("\t6. Latte");
            Console.WriteLine("\t7. Irish Whiskey");
            Console.WriteLine("\t8. Machiato");
            Console.WriteLine("\t9. Moccachino");
        }

        static void func_tea_show()
        {
            Console.WriteLine("Tea: ");
            Console.WriteLine("\t1. Black tea");
            Console.WriteLine("\t2. Green tea");
            Console.WriteLine("\t3. Red tea");
            Console.WriteLine("\t4. Yellow tea");
            Console.WriteLine("\t5. Fruit tea");
        }

        static void func_cacao_show()
        {
            Console.WriteLine("3) Cacao: ");
            Console.WriteLine("\t1. Original cacao");
            Console.WriteLine("\t2. Spiced cacao");
            Console.WriteLine("\t3. Hot chocolate");
        }

        static void func_sweets_show()
        {
            Console.WriteLine("Sweets:");
            Console.WriteLine("\t1 Marshmallow");
            Console.WriteLine("\t2 Chocolate chips");
            Console.WriteLine("\t3 M&M`s sweets");
        }

        static void func_instructions_show()
        {
            Console.WriteLine("\t\tGreetings customer! ");
            Console.WriteLine("\t This is a Struk.corp vending machine assistant.");
            Console.WriteLine("\t Firstly, I provide you with drinks menu. You can either choose one or quit.");
            Console.WriteLine("\t When drink is chosen. I should have some time to make you a drink.");
            Console.WriteLine("\t It takes from 60 up to 90 seconds.");
            Console.WriteLine("\t In addition for some drinks, I can serve you with sugar or other sweets.");
            Console.WriteLine("\t If any questions left, you can replay this message by entering 5");
        }

        static void func_location_show()
        {
            Console.WriteLine("You can find other vending machines at following addresses:");
            Console.WriteLine("*Green Street 82. Oklahoma");
            Console.WriteLine("*Blue Street 14. Oklahoma");
            Console.WriteLine("*Red Street 2. New Jersey");
            Console.WriteLine("*Yellow Street 7. Kentucky");
            Console.WriteLine("*Brown Street 67. Dallas");
            Console.WriteLine("*Pink Street 1. Chicago");
        }

        static void func_cup_size_show()
        {
            Console.WriteLine("Choose one cup among these:");
            Console.WriteLine("1) 100 ml");
            Console.WriteLine("2) 200 ml");
            Console.WriteLine("3) 300 ml");
        }

        static bool func_are_you_sure()
        {
            bool choice = false;
            Console.WriteLine("Are you sure?");
            Console.WriteLine("1 - Yes, 0 - No");
            choice = Convert.ToBoolean(Console.ReadLine());
            return choice;
        }

        bool func_drink_choice()
        {
            Console.WriteLine("Now, choose a preferable drink. Here what we are serving at the moment.");
            func_coffee_show();
            func_tea_show();
            func_cacao_show();
            int drink_choice = 0;
            Console.WriteLine("1 - Coffee, 2 - Tea, 3 - Cacao");
            drink_choice = Convert.ToInt32(Console.ReadLine());
            switch (drink_choice)
            {
                case 1:
                {
                    Console.WriteLine("You chose coffee. What coffee drink do you want?");
                    func_coffee_show();
                    bool coffee_choice_confirmation = func_coffee_choice();
                    return true;
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You chose tea. What tea drink do you want?");
                    func_tea_show();
                    bool tea_choice_confirmation = func_tea_choice();
                    return true;
                    break;
                }
                case 3:
                {
                    Console.WriteLine("You chose cacao. What cacao drink do you want?");
                    func_cacao_show();
                    bool cacao_choice_confirmation = func_cacao_choice();
                    return true;
                    break;
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.\n");
                    return false;
                    break;
                }
            }
        }
        bool func_coffee_choice()
        {
            int coffee_choice = 0;
            coffee_choice = Convert.ToInt32(Console.ReadLine());
            switch (coffee_choice)
            {
                case 1:
                {
                    Console.WriteLine("Espresso is chosen. \n");
                    bool confirmation = func_are_you_sure();
                    if (confirmation)
                    {
                        string coffee_name = "Espresso";
                        func_cup_size_show();
                        int cup_size = 0;
                        while (true)
                        {
                            cup_size = func_cup_size_choice();
                            if (cup_size == 100 || cup_size == 200 || cup_size == 300)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        bool is_sugar_needed = func_is_sugar_needed();
                        int sugar_spoons = 0;
                        if (is_sugar_needed)
                        {
                            sugar_spoons = func_sugar_spoons_quantity();
                        }
                        bool is_dopping_needed = func_is_dopping_needed();
                        string dopp_name = "";
                        if (is_dopping_needed)
                        {
                            while (!string.IsNullOrEmpty(dopp_name))
                            {
                                dopp_name = func_dopping_choice();
                            }
                        }
                        Coffee coffee = new Coffee(coffee_name, cup_size, sugar_spoons, dopp_name, is_dopping_needed);
                        Console.WriteLine("Your order\n");
                        Console.WriteLine("-------------------------------------------------------");
                    }
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Americano is chosen. \n");
                    bool confirmation = func_are_you_sure();
                    if (confirmation)
                    {
                        string coffee_name = "Americano";
                        func_cup_size_show();
                        int cup_size = 0;
                        while (true)
                        {
                            cup_size = func_cup_size_choice();
                            if (cup_size == 100 || cup_size == 200 || cup_size == 300)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        bool is_sugar_needed = func_is_sugar_needed();
                        int sugar_spoons = 0;
                        if (is_sugar_needed)
                        {
                            sugar_spoons = func_sugar_spoons_quantity();
                        }
                        bool is_dopping_needed = func_is_dopping_needed();
                        string dopp_name = "";
                        if (is_dopping_needed)
                        {
                            while (!string.IsNullOrEmpty(dopp_name))
                            {
                                dopp_name = func_dopping_choice();
                            }
                        }
                        Coffee coffee = new Coffee(coffee_name, cup_size, sugar_spoons, dopp_name, is_dopping_needed);
                        Console.WriteLine("Your order\n");
                        Console.WriteLine("-----------------------------------------------------------------");
                    }
                    break;
                }

                //Continue from case 3
            }

        }
    }
}
