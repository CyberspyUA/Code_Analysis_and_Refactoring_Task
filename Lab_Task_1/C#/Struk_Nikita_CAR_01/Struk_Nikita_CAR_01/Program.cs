namespace Struk_Nikita_CAR_01;

internal static class Program
{
    private static void Main()
    {
        //
        var res = false;
        while (!res)
        {
            VendingMachineFunctions.FuncOptionsShow();
            var choice = Convert.ToInt32(Console.ReadLine());
            res = VendingMachineFunctions.FuncMenu(choice);
        }
        Console.Clear();
        Console.WriteLine("Дякуємо, що приділили нам свій час! Бажаємо вам чудового дня!");
    }
}