using System;
using TarteebBank.Servises;

namespace TarteebBank
{
    internal class Program
    {
        private static object userInputPassword;

        private static void Main(string[] args)
        {
            var menu = new Menu();
            var password = new Password();

            string userInputThoughtPassword = password.GetUserValueByPassword("Dasturdan foydalanish uchun avval o'zingizga unikal parol o'ylang!!!\n" +
                                                                              "O'ylagan parolingiz: ");
            
            Console.WriteLine("\nTarteebBank ga hush kelibsiz!!!");
            Console.WriteLine("Tarteeb jamoasiga qa'bul qilinganiz uchun sizga \n" +
                              "10 000$ taqdim etildi! Endi uni sarf qilishingiz mumkin!!!\n");

            string userInputPassword = password.GetUserValueByPassword("Dasturdan foydalanish uchun parolingizni kiriting: ");

            string yesOrNo;
            do
            {

                if (userInputPassword == userInputThoughtPassword)
                {
                    menu.ShowMenu();
                }
                else if (userInputPassword != userInputThoughtPassword) 
                {
                    userInputPassword = password.GetUserValueByPassword("No'tog'ri parol kiritdingiz!!!\nParolni kiriting: ");
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? (yes / no)");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");
            {
                Console.WriteLine("Thank you for using our program");
            }

            
        }
    }
}
