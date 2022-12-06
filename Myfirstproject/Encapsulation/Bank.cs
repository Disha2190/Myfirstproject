using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class Bank
    {
        int balance;
       
        public void WithDraw(int amt)
        {
            balance = balance - amt;
        }
        public void Deposit(int amt)
        {
            balance = balance + amt;
        }
        public int GetBalance()
        {
            return balance;
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Deposit(50000);
            Console.WriteLine("After Deposit: "+b.GetBalance());
            b.WithDraw(3000);
            Console.WriteLine("After Withdrawal: "+b.GetBalance());
            b.Deposit(4000);
            Console.WriteLine("After Deposit: "+b.GetBalance());
        }
    }
}
