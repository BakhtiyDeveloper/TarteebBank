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