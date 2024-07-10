using System;

namespace TarteebBank.Servises
{
    internal class Balance
    {
        internal void ShowBalance(decimal startBalance) 
        {
            Console.Clear();
            PrintMassegeBalance($"Your current balance is: ${startBalance}");
        }

        internal decimal WithdrawBalance(decimal startBalance)
        {
            Console.Clear();
            PrintMassegeBalance("How much money you want to withdraw from your balance?");
            Console.Write("Enter the value: ");
            string userInputValueWithdrawBalance = Console.ReadLine();
            decimal withdrawValue = Convert.ToDecimal(userInputValueWithdrawBalance);

            if (withdrawValue > 0 && withdrawValue <= startBalance)
            {
                startBalance -= withdrawValue;
                PrintMassegeBalance($"You have withdrawn ${withdrawValue} from your balance. Your current balance: ${startBalance}.");                
            }
            else
            {
                PrintMassegeBalance($"The withdrawal amount cannot exceed ${startBalance}.");
            }

            return startBalance;
        }   

        internal decimal TopUpBalance(decimal startBalance)
        {
            Console.Clear();
            PrintMassegeBalance("How much do you want to top up the balance?");
            Console.Write("Enter the value: ");
            string userInputValueTopUpBalance = Console.ReadLine();
            decimal topUpValue = Convert.ToDecimal(userInputValueTopUpBalance);

            if (topUpValue > 0)
            {
                startBalance += topUpValue;
                PrintMassegeBalance($"You have topped up your balance by ${topUpValue}. Your current balance: ${startBalance}.");
            }
            else
            {
                PrintMassegeBalance("The amount to be filled must be a positive number.");
            }

            return startBalance;
        }

        internal decimal GetExpenceBalance (decimal startBalance) 
        {
            Console.Clear ();
            PrintMassegeBalance("Products to spend!!!");
            PrintMassegeBalance("1 - Computer PC. Price = $2000");
            PrintMassegeBalance("2 - Laptop ACER. Price = $1800");
            PrintMassegeBalance("3 - MacBook Pro m5. Price = $3000");
            PrintMassegeBalance("4 - Monitor ACER. Price = $1000");
            PrintMassegeBalance("5 - For personal expenses. $2000");

            Console.Write("Enter your choice: ");
            string userInputChooceExpence = Console.ReadLine();
            int chooceExpence = Convert.ToInt32(userInputChooceExpence);

            decimal expenceBalance = 0;

            switch (chooceExpence)
            {
                case 1:
                    expenceBalance = 2000;
                    PrintPurchaseMade();

                    break;
                case 2:
                    expenceBalance = 1800;
                    PrintPurchaseMade();
                    break;
                case 3:
                    expenceBalance = 3000;
                    PrintPurchaseMade();
                    break;
                case 4:
                    expenceBalance = 1000;
                    PrintPurchaseMade();
                    break;
                case 5:
                    expenceBalance = 2000;
                    PrintPurchaseMade();
                    break;
                default:
                    PrintMassegeBalance("Wrong choice. Run the program again!!!");
                    return startBalance;  
            }

            if (chooceExpence > startBalance) 
            {
                PrintMassegeBalance("You don't have enough funds in your balance!!!");
            }
            else 
            {
                startBalance -= expenceBalance;
                PrintMassegeBalance($"You spent ${expenceBalance}. Your current balance: ${startBalance}.");
            }

            return startBalance;
        }

        private void PrintMassegeBalance(string massage)
        {
            Console.WriteLine(massage);
        }

        private void PrintPurchaseMade()
        {
            Console.WriteLine("The purchase was made successfully");
        }
    }
}
