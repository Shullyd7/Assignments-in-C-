using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        int AccountNumber;
        int AccountName;
        int balance = 0;

        public void createAccount()
        {
            Console.WriteLine("What is your name:\n");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your email address:\n");
            var email = Console.ReadLine();
            Console.WriteLine("Enter your FOUR digit pin:\n");
            var password = Console.ReadLine();
            string s1 = String.Format("Name is {0}", name);
            string s2 = String.Format("E-mail Address is {0}", email);
            string s3 = String.Format("Pin is {0}", password);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine("Your Account has Successfully been created");

        }

        public void checkBalance(){

            Console.WriteLine("You have {0} ",balance + " Naira");
        }

        public void depositMoney(){
   
                Console.WriteLine("How much do you want to deposit?\n");
                var amount = Convert.ToInt32(Console.ReadLine());
                 balance = balance + amount;
                Console.WriteLine("Succesful Deposit\n Balance is now {0}", balance + " Naira");
        }

        public void withdrawMoney()
        {
            Console.WriteLine("How much do you want to withdraw?\n");
            var amount1 = Convert.ToInt32(Console.ReadLine());
            balance = balance - amount1;
            Console.WriteLine("Succesful Withdrawal\n Balance is now {0}", balance + " Naira");
        }
        
        public void exit()
        {
            Console.WriteLine("Goodbye. Visit Us Again");
        }
    }   
}
