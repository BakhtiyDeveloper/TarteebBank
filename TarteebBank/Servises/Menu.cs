﻿using System;

namespace TarteebBank.Servises
{
    internal class Menu
    {
        internal void ShowMenu() 
        {
            PrintMassege("1 - Balansni tekshirish");
            PrintMassege("2 - Balansdan pul yechish");
            PrintMassege("3 - Balansni to'ldirish");
            PrintMassege("4 - Xarajat qilish");
            PrintMassege("5 - Dasturdan chiqish");
            Console.Write("Tanlovingizni kiriting: ");
        }

        public void PrintMassege(string massage)
        {
            Console.WriteLine(massage);

        }
    }
}
