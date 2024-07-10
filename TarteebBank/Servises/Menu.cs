using System;

namespace TarteebBank.Servises
{
    internal class Menu
    {
        internal void ShowMenu() 
        {
            PrintMassege("\nChoose one below!!!");
            PrintMassege("1 - Balance check.");
            PrintMassege("2 - Withdraw money from the balance.");
            PrintMassege("3 - Topping up the balance.");
            PrintMassege("4 - Spending");
            PrintMassege("5 - Exit the program");            
        }

        private void PrintMassege(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
