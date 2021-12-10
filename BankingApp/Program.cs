using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account k = new Account();
            int num;

            Console.WriteLine(" WELCOME TO CSC BANK \n");
            Console.WriteLine("\nPress 1 to Create Account. \nPress 2 to Check Balance. \nPress 3 to Deposit Money. \nPress 4 to Withdraw Money. \nPress 5 to quit. ");
            Console.WriteLine("---------------------------------------------------");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    k.createAccount();
                    return;
                case 2:
                    k.checkBalance();
                    return;
                case 3:
                    k.depositMoney();
                    return;
                case 4:
                    k.withdrawMoney();
                    return;
                case 5:
                    k.exit();
                    return;
            }

        }
    }
}
