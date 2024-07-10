using System;

namespace TarteebBank.Servises
{
    internal class Balance
    {
        internal void ShowBalance(decimal startBalance) 
        {
            Console.Clear();
            Console.WriteLine($"Hozirda sizning balansingiz: {startBalance}$");
        }

        internal decimal WithdrawBalance(decimal startBalance)
        {
            Console.Clear();
            Console.WriteLine("Balansingizdan qancha miqdorda pul yechmoqchisiz?");
            Console.Write("Qiymatini kiriting: ");
            string userInputValueWithdrawBalance = Console.ReadLine();
            decimal withdrawValue = Convert.ToDecimal(userInputValueWithdrawBalance);

            if (withdrawValue > 0 && withdrawValue <= startBalance)
            {
                startBalance -= withdrawValue;
                Console.WriteLine($"Hisobingizdan {withdrawValue}$ yechdingiz. Hozirda hisobingizda balans: {startBalance}$ bor.");
                
            }
            else
            {
                Console.WriteLine($"Yechiladigan miqdor {startBalance} oshmasligi kerak.");
            }

            return startBalance;
        }   

        internal decimal TopUpBalance(decimal startBalance)
        {
            Console.Clear();
            Console.WriteLine("Balansni qancha miqdorda to'ldirmoqchisiz?");
            Console.WriteLine("Qiymatini kiriting: ");
            string userInputValueTopUpBalance = Console.ReadLine();
            decimal topUpValue = Convert.ToDecimal(userInputValueTopUpBalance);

            if (topUpValue > 0)
            {
                startBalance += topUpValue;
                Console.WriteLine($"Hisobingizni {topUpValue}$ ga to'ldirdingiz. Hozirda hisobingizda: {startBalance}$ bor");
            }
            else
            {
                Console.WriteLine("To'ldiriladigan miqdor 0 dan katta bo'lishi kerak.");
            }

            return startBalance;
        }

        internal decimal GetExpenceBalance (decimal startBalance) 
        {
            Console.Clear ();
            PrintMassege("Harajat qilish uchun mahsulotlar!!!");
            PrintMassege("1 - Kompyuter PC. Narhi = $2000");
            PrintMassege("2 - Noutbuk ACER. Narhi = $1800");
            PrintMassege("3 - MacBook Pro m5. Narhi = $3000");
            PrintMassege("4 - Monitor ACER. Narhi = $1000");
            PrintMassege("5 - Shaxsiy harajatlar uchun. $2000");

            Console.Write("Tanlovingizni kiriting: ");
            string userInputChooceExpence = Console.ReadLine();
            int chooceExpence = Convert.ToInt32(userInputChooceExpence);

            decimal expenceBalance = 0;

            switch (chooceExpence)
            {
                case 1:
                    expenceBalance = 2000;
                    PrintMassege("Harid muvaffaqiyatli amalga oshirildi");
                    break;
                case 2:
                    expenceBalance = 1800;
                    PrintMassege("Harid muvaffaqiyatli amalga oshirildi");
                    break;
                case 3:
                    expenceBalance = 3000;
                    PrintMassege("Harid muvaffaqiyatli amalga oshirildi");
                    break;
                case 4:
                    expenceBalance = 1000;
                    PrintMassege("Harid muvaffaqiyatli amalga oshirildi");
                    break;
                case 5:
                    expenceBalance = 2000;
                    PrintMassege("Harid muvaffaqiyatli amalga oshirildi");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri tanlov. Dasturni qayta ishlating!!!");
                    return startBalance;  
            }

            if (chooceExpence > startBalance) 
            {
                Console.WriteLine("Balansingizda yetarli mablag' mavjud emas!!!");
            }
            else 
            {
                startBalance -= expenceBalance;
                Console.WriteLine($"Siz ${expenceBalance} sarfladingiz. Hozirda hisobingizda ${startBalance} bor.");
            }

            return startBalance;
        }

        private void PrintMassege(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
