using System;
using TarteebBank.Servises;

namespace TarteebBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var menu = new Menu();

            string password = "";

            Console.WriteLine("TarteebBank ga hush kelibsiz!!!");
            Console.WriteLine("Tarteeb jamoasiga qa'bul qilinganiz uchun sizga \n" +
                              "10 000$ taqdim etildi! Endi uni sarf qilishingiz mumkin!!!\n");

            Console.WriteLine("Dasturdan foydalanish uchun avval o'zingizga parol tanlang!!!");
            Console.Write("Tanlagan parolingiz: ");

            string userInputPassword = Console.ReadLine();
            userInputPassword = password;

            Console.WriteLine();
            
            if (userInputPassword == password)
            {
                menu.ShowMenu();

            }
        }
    }
}
