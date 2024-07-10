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

            string userInputThoughtPassword = password.GetUserValueByPassword("Create a unique password to use the program!!!\n" +
                                                                              "Your password is: ");
            Console.WriteLine("Password created.........");

            Console.Clear();
            Console.WriteLine("\nWelcome to TarteebBank!!!");
            Console.WriteLine("You've been awarded 10,000 for being accepted into the Tarteeb team!\n" +
                              "Now you can spend it!!!\n");

            Console.WriteLine("Enter your password to use the program!!!");
                        
            string userInputPassword;

            string yesOrNo;
            do
            {
                do
                {  
                    userInputPassword = password.GetUserValueByPassword("Enter password: ");

                } while (userInputPassword != userInputThoughtPassword);
                { 
                    if (userInputPassword == userInputThoughtPassword) 
                    {
                        decimal startBalance = 10000.00m;

                        menu.ShowMenu();

                        Console.Write("Enter your choice: ");
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
                                Console.WriteLine("Exit the program....");
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
