using System;

namespace TarteebBank.Servises
{
    internal class Menu
    {
        internal void ShowMenu() 
        {
            PrintMassege("\nQuyidagilardan birini tanlang!!!");
            PrintMassege("1 - Balansni tekshirish");
            PrintMassege("2 - Balansdan pul yechish");
            PrintMassege("3 - Balansni to'ldirish");
            PrintMassege("4 - Xarajat qilish");
            PrintMassege("5 - Dasturdan chiqish");
            Console.Write("Tanlovingizni kiriting: ");
        }

        private void PrintMassege(string massage)
        {
            Console.WriteLine(massage);

        }
    }
}
