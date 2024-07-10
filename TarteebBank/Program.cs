using System;
using TarteebBank.Servises;

namespace TarteebBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var menu = new Menu();
            var password = new Password();
            var balance = new Balance();

            string userInputThoughtPassword = password.GetUserValueByPassword("Dasturdan foydalanish uchun avval o'zingizga unikal parol o'ylang!!!\n" +
                                                                              "O'ylagan parolingiz: ");
            
            Console.WriteLine("\nTarteebBank ga hush kelibsiz!!!");
            Console.WriteLine("Tarteeb jamoasiga qa'bul qilinganiz uchun sizga \n" +
                              "10 000$ taqdim etildi! Endi uni sarf qilishingiz mumkin!!!\n");

            Console.WriteLine("Dasturdan foydalanish uchun parolingizni kiriting!!!");
                        
            string userInputPassword;

            string yesOrNo;
            do
            {
                do
                {  
                    userInputPassword = password.GetUserValueByPassword("Parolni kiriting: ");

                } while (userInputPassword != userInputThoughtPassword);
                { 
                    if (userInputPassword == userInputThoughtPassword) 
                    {
                        decimal startBalance = 10000.00m;

                        menu.ShowMenu();

                        Console.Write("Tanlovingizni kiriting: ");
                        string userInputValue = Console.ReadLine();
                        int userInput = Convert.ToInt32(userInputValue);

                        switch (userInput)
                        {
                            case 1:

                                balance.ShowBalance(startBalance);
                                break;

                            case 2:
                                balance.WithdrawBalance(startBalance);
                                break;

                            case 3:
                                balance.TopUpBalance(startBalance);
                                break;

                            case 4:
                                balance.GetExpenceBalance(startBalance);
                                break;

                            case 5:
                                Console.WriteLine("Dasturdan chiqish....");
                                Console.WriteLine("Thank you for using our program");
                                return;

                            default:
                                Console.WriteLine("Noto'g'ri tanlov. Qayta urinib ko'ring.");
                                break;
                        }
                    }
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
