using UI;
namespace Struk_Nikita_CAR_01;

internal static class Program
{
    private static void Main()
    {
        //Початкова точка роботи програми.
        var res = false;
        while (!res)
        {
            DisplayInfo.ShowOptionsToChooseFrom();
            var choice = Convert.ToInt32(Console.ReadLine());
            res = MainMenu.ShowMainMenu(choice);
        }
        Console.Clear();
        Console.WriteLine("Дякуємо, що придiлили нам свiй час! Бажаємо вам чудового дня!");
    }
}