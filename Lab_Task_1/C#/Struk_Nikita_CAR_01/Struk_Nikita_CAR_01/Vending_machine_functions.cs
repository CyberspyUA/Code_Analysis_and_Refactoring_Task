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

        bool func_menu(int choice)
        {
            switch (choice)
            {
                case 1:
                {
                    func_drink_choice();
                    return false;
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
                }
                
                case 3:
                {
                    func_instructions_show();
                    return false;
                }
                case 4:
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
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.");
                    return false;
                }
            }
        }

        static void func_options_show()
        {
            Console.WriteLine("\t Please, input number from 1 to 4 by keyboard.");
            Console.WriteLine("\t Available options:");
            Console.WriteLine("1) Choose a drink");
            Console.WriteLine("2) Show all drinks");
            Console.WriteLine("3) Show help menu");
            Console.WriteLine("4) Quit vending machine.");
        }

        static void func_coffee_show()
        {
            Console.WriteLine("Coffee:");
            Console.WriteLine("\t1. Esspresso");
            Console.WriteLine("\t2. Americano");
            Console.WriteLine("\t3. Cappuccino");
        }

        static void func_tea_show()
        {
            Console.WriteLine("Tea: ");
            Console.WriteLine("\t1. Black tea");
            Console.WriteLine("\t2. Green tea");
            Console.WriteLine("\t3. Red tea");
        }

        static void func_cacao_show()
        {
            Console.WriteLine("3) Cacao: ");
            Console.WriteLine("\t1. Original cacao");
            Console.WriteLine("\t2. Spiced cacao");
            Console.WriteLine("\t3. Hot chocolate");
        }


        static void func_instructions_show()
        {
            Console.WriteLine("\t\tGreetings customer! ");
            Console.WriteLine("\t This is a Struk.corp vending machine assistant.");
            Console.WriteLine("\t Firstly, I provide you with drinks menu. You can either choose one or quit.");
            Console.WriteLine("\t When drink is chosen. I should have some time to make you a drink.");
            Console.WriteLine("\t It takes from 10 up to 15 seconds.");
            Console.WriteLine("\t In addition for some drinks, I can serve you with sugar or other sweets.");
            Console.WriteLine("\t If any questions left, you can replay this message by entering 5");
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
                    bool coffee_choice_confirmation = false;
                    while(!coffee_choice_confirmation)
                      coffee_choice_confirmation = func_drink_subtype_choice(drink_choice);
                    return true;
                }
                case 2:
                {
                    Console.WriteLine("You chose tea. What tea drink do you want?");
                    func_tea_show();
                        bool tea_choice_confirmation = false;
                        while (!tea_choice_confirmation)
                            tea_choice_confirmation = func_drink_subtype_choice(drink_choice);
                    return true;
                }
                case 3:
                {
                    Console.WriteLine("You chose cacao. What cacao drink do you want?");
                    func_cacao_show();
                    bool cacao_choice_confirmation = false;
                        while (!cacao_choice_confirmation)
                            cacao_choice_confirmation = func_drink_subtype_choice(drink_choice);
                    return true;
                }
                default:
                {
                    Console.WriteLine("Sorry, but this choice is invalid, try again.\n");
                    return false;
                }
            }
        }
        bool func_drink_subtype_choice(int drink_type_choice)
        {
            int drink_subtype_choice = 0;
            drink_subtype_choice = Convert.ToInt32(Console.ReadLine());
            bool confirmation = func_are_you_sure();
            if (confirmation)
            {
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
                return true;
            }
            else
            {
                Console.WriteLine("Retype your choices.");
                return false;
            }
        }
    int func_cup_size_choice()
    {
        int cup_choice = Convert.ToInt32(Console.ReadLine());
        switch (cup_choice)
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
                    break;
                }
        }
    }
     void drink_brewing(int drink_type_choice, string drink_name, int cup_size, int sugar_spoons)
        {
            if(drink_type_choice == 1)
            {
                Coffee coffee = new Coffee(drink_name, cup_size, sugar_spoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                coffee.order_show();
                Console.WriteLine("Now, wait for a coffee to get ready.");
                coffee.brewing();
            }
            else if(drink_type_choice == 2)
            {
                Tea tea = new Tea(drink_name, cup_size, sugar_spoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                tea.order_show();
                Console.WriteLine("Now, wait for a tea to get ready.");
                tea.brewing();
            }
            else if(drink_type_choice == 3)
            {
                Cacao cacao = new Cacao(drink_name, cup_size, sugar_spoons);
                Console.WriteLine("Your order");
                Console.WriteLine("-----------------------------------------------------------------");
                cacao.order_show();
                Console.WriteLine("Now, wait for a tea to get ready.");
                cacao.brewing();
            }
        }

    }
}
