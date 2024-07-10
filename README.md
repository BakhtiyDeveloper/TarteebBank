> # Welcome to project TarteebBank

## About the Project and Overview

### TarteebBank is a balance management application designed for users to log in with a password and have the ability to view their balance, add funds, withdraw funds, and view expenses.

### User Instructions

#### 1. Create Password:

    * When the program starts, the user is prompted to think of a unique password.

```cs
'''
string userInputThoughtPassword = password.GetUserValueByPassword("Create a unique password to use the program!!!\n" +
                                                                  "Your password is: ");

PrintMassege("Password created.........");
'''
```
#### 2. Login:

    * To use the program, the user must enter their password.

    * If the password is incorrect, they will be asked to re-enter it.

```cs
'''
PrintMassege("\nWelcome to TarteebBank!!!");
PrintMassege("You've been awarded 10,000 for being accepted into the Tarteeb team!\n" +
             "Now you can spend it!!!\n");

PrintMassege("Enter your password to use the program!!!");

'''
```
#### 3. Menu: 

 * Once the password is correctly entered, the user is presented with the following menu:

    1. View balance.
    2. Withdraw balance. 
    3. Top up balance. 
    4. View expenses. 
    5. Exit 

```cs
'''
PrintMassege("\nChoose one below!!!");
PrintMassege("1 - Balance check.");
PrintMassege("2 - Withdraw money from the balance.");
PrintMassege("3 - Topping up the balance.");
PrintMassege("4 - Spending");
PrintMassege("5 - Exit the program"); 


private void PrintMassege(string massage)
{
    Console.WriteLine(massage);
}    

'''
```
#### 4. View Balance:

* The user selects option 1 to view their balance.

```cs 
'''
internal void ShowBalance(decimal startBalance) 
{
    Console.Clear();
    PrintMassege($"Your current balance is: ${startBalance}");
}

'''
```
#### 5. Withdraw Balance:

* The user selects option 2 to withdraw funds.
* They will be asked to enter the amount to withdraw. 

```cs
'''
internal decimal WithdrawBalance(decimal startBalance)
{
    Console.Clear();
    PrintMassege("How much money you want to withdraw from your balance?");
    Console.Write("Enter the value: ");
    string userInputValueWithdrawBalance = Console.ReadLine();
    decimal withdrawValue = Convert.ToDecimal(userInputValueWithdrawBalance);

    if (withdrawValue > 0 && withdrawValue <= startBalance)
    {
        startBalance -= withdrawValue;
        PrintMassege($"You have withdrawn ${withdrawValue} from your balance. Your current balance: ${startBalance}.");                
    }
    else
    {
        PrintMassege($"The withdrawal amount cannot exceed ${startBalance}.");
    }

    return startBalance;
}   

'''
```
#### 6. Top Up Balance:

* The user selects option 3 to add funds.
* They will be asked to enter the amount to add.

```cs 
'''
internal decimal TopUpBalance(decimal startBalance)
{
    Console.Clear();
    PrintMassege("How much do you want to top up the balance?");
    Console.Write("Enter the value: ");
    string userInputValueTopUpBalance = Console.ReadLine();
    decimal topUpValue = Convert.ToDecimal(userInputValueTopUpBalance);

    if (topUpValue > 0)
    {
        startBalance += topUpValue;
        PrintMassege($"You have topped up your balance by ${topUpValue}. Your current balance: ${startBalance}.");
    }
    else
    {
        PrintMassege("The amount to be filled must be a positive number.");
    }

    return startBalance;
}

'''
```

#### 7.View Expenses:

* The user selects option 4 to view their expenses.

```cs
'''
internal decimal GetExpenceBalance (decimal startBalance) 
{
    Console.Clear ();
    PrintMassege("Products to spend!!!");
    PrintMassege("1 - Computer PC. Price = $2000");
    PrintMassege("2 - Laptop ACER. Price = $1800");
    PrintMassege("3 - MacBook Pro m5. Price = $3000");
    PrintMassege("4 - Monitor ACER. Price = $1000");
    PrintMassege("5 - For personal expenses. $2000");

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
            PrintMassege("Wrong choice. Run the program again!!!");
            return startBalance;  
    }

    if (chooceExpence > startBalance) 
    {
        PrintMassege("You don't have enough funds in your balance!!!");
    }
    else 
    {
        startBalance -= expenceBalance;
        PrintMassege($"You spent ${expenceBalance}. Your current balance: ${startBalance}.");
    }

    return startBalance;
}

'''
```

#### 8. Exit:

* The user selects option 5 to exit the program.
* The program will display an exit message and terminate.

#### 9. Continue:

* After each transaction, the program asks the user whether they want to continue or exit.

```cs 
'''
Console.WriteLine("\nDo you want to continue? (yes / no)");
yesOrNo = Console.ReadLine();

while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");
{
    Console.WriteLine("Thank you for using our program");
}

'''
```

### Result to GIF

![Result to GIF](/resultGif/result%20gif.gif)

Download the program [TarteebBank](https://drive.google.com/file/d/14KxVGaipxwsVoqS3ygpxB3KGUii3Ux8P/view?usp=sharing).

># I'm glad you are using the program.