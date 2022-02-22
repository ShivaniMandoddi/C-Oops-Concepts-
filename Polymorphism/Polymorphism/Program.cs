using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        /*Assessment: Implement a basic Banking Application by implementing account class along with two derived classes savingsaccount and currentaccount.
         * Deposit method and Withdrawl method. Print Balance amount in the account.
         */
        static void Main(string[] args)
        {
            Account account = new Account("Shivani",12000); // Creating Account object
            SavingsAccount savings = new SavingsAccount("Pallavi", 15000); // Creating Savings Account object
            CurrentAccount currentAccount = new CurrentAccount("Seeta", 19800); // Creating currentAccount object
            // Calling the methods of Account class
            account.Deposit(3000);
            account.Withdrawl(250);

            // Calling the methods of Savings Account Class
            savings.Deposit(1000);
            savings.Withdrawl(3000);

            //Calling the methods of Current Account CLass
            currentAccount.Deposit(550);
            currentAccount.Withdrawl(4000);

            Console.ReadLine();
        }
    }
    class Account   /* Account is a base class where the amount and username properties are declared.
                    Deposit,Withdrawl and Balance methods are declared in this class. Methods are declared using virtual keyword. */
    {
        // Variable declaration
        public int amount;
        public string userName;
       // Property declaration
        public int Amount { get { return (amount); } set { amount = value; } } 
        public string UserName { get { return (userName); } set { userName = value; } }
        public Account(string userName, int amount)
        {
            this.userName = userName;
            this.amount = amount;
        }
        public virtual void Deposit(int amountValue)
        {
            amount = amount + amountValue; // Adding the amount to the account balance
            Console.WriteLine("Hey {0}! Deposting {1} Rs has done successfully\n", userName,amountValue);
            Balance();
        }
        public virtual void Withdrawl(int amountValue)
        {

            if (amountValue > amount) //Checking amount is sufficient in account or not
                Console.WriteLine("Amount is not sufficient in account");
            else
            {
                amount = amount - amountValue;// Taking the amount from the account balance
                Console.WriteLine("Hey {0}! Withdrawing {1} Rs has done successfully\n", userName, amountValue);
            }
            Balance();
        }
        public virtual void Balance() // Balance method is to display the remaining amount in particular account
        {
            Console.WriteLine("Remaining Balance in {0}'s Account: {1}\n",userName,amount);
        }
    }
    class SavingsAccount : Account /*Savings Account is a derived class from Account class. Properties and methods are inherited from base class.*/
    {
        public SavingsAccount(string userName,int amount): base(userName,amount) 
        {
            this.userName = userName;
            this.amount = amount;
        }
        public override void Deposit(int amountValue) // Methods are inherited from base class.So, override keyword is used in declaring the method.
        {
            amount = amount + amountValue;// Adding the amount to the Savings account balance
            Console.WriteLine("Hey {0}! Deposting {1} Rs from Savings Account has done successfully\n", userName, amountValue);
            base.Balance();
        }
        public override void Withdrawl(int amountValue)
        {
            if (amountValue > amount)
                Console.WriteLine("Amount is not sufficient in account");
            else
            {
                amount = amount - amountValue; // Taking the amount from the Current account balance
                Console.WriteLine("Hey {0}! Withdrawing {1} Rs from Savings Account has done successfully\n", userName, amountValue);
                
            }
            base.Balance();
        }
    }
    class CurrentAccount : Account/*Current Account is a derived class from Account class. Properties and methods are inherited from base class.*/
    {
        public CurrentAccount(string userName, int amount): base(userName,amount)
        {
            this.userName = userName;
            this.amount = amount;
        }
        public override void Deposit(int amountValue)
        {
            amount = amount + amountValue; // Adding the amount to the Current account balance
            Console.WriteLine("Hey {0}! Deposting {1} Rs from CurrentAccount has done successfully\n", userName,amountValue);
            base.Balance();
        }
        public override void Withdrawl(int amountValue)
        {
            if (amountValue > amount)
                Console.WriteLine("Amount is not sufficient in account");
            else
            {
                amount = amount - amountValue; // Taking the amount from the Current account balance
                Console.WriteLine("Hey {0}! Withdrawing {1} Rs from CurrentAccount has done successfully\n", userName, amountValue);
                
            }
            base.Balance();
        }

    }

}
