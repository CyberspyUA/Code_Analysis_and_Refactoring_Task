internal class Program
{
    private static void Main()
    {
        Vending_machine_functions.func_instructions_show();
        bool res = false;
        while (res == false)
        {
            Vending_machine_functions.func_options_show();
            int choice = Convert.ToInt32(Console.ReadLine());
            res = Vending_machine_functions.func_menu(choice);
            Console.WriteLine("**************************************************************************");
        }
    }
}