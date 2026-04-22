using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public class BankAccount
    {
        private double balnce;

        public double Balnce { 
            get { return balnce; } 
        }
        //ايداع
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balnce += amount;
                Console.WriteLine($"Successfully deposited: ${amount}. New balance: ${balnce}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        //سحب
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount > balnce)
            {
                Console.WriteLine($"Insufficient funds! You tried to withdraw ${amount} but your balance is only ${balnce}.");
            }
            else
            {
                balnce -= amount;
                Console.WriteLine($"Successfully withdrew: ${amount}. Remaining balance: ${balnce}");
            }
        }
    }
}
