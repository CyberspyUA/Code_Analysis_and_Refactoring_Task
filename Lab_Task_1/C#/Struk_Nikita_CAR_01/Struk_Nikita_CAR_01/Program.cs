using Struk_Nikita_CAR_01;

internal class Program
{
    private static void Main()
    {

        var res = false;
        while (!res)
        {
            VendingMachineFunctions.FuncOptionsShow();
            var choice = Convert.ToInt32(Console.ReadLine());
            res = VendingMachineFunctions.FuncMenu(choice);
        }
        Console.Clear();
        Console.WriteLine("Thank you for investing your time! We wish you a great day!");
    }
}