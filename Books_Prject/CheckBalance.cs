using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public delegate void MyDel();
    class CheckBalance
    {
        public event MyDel Insufficient;
        public event MyDel Zero;

        private double balance;
        public CheckBalance(double balance)
        {
            this.balance = balance;
        }
        public void Debit(double amount)
        {
           if(amount > balance)
            {
                Insufficient();
            }
            else
            {
                balance -= amount;
                if(balance==0)
                {
                    Zero();
                }
            }
        }
        public  void Credit(double amount)
        {
            balance += amount;
        }
        public override string ToString()
        {
            return $"Current balance is {balance}";
        }
    }
    public static class Message
    {
        public static void Insufficientbalance()
        {
            Console.WriteLine("Balance is not sufficient to withdrow");
        }
        public static void ZeroBalance()
        {
            Console.WriteLine("Current account balance is zero");
        }
    }
    public class Transaction
    {
        static void Main(string[] args)
        {
            CheckBalance c = new CheckBalance(5000);
            c.Insufficient += new MyDel(Message.Insufficientbalance);
            c.Zero += new MyDel(Message.ZeroBalance);

            Console.WriteLine("Credit 1000");
            c.Credit(1000);
            Console.WriteLine(c);

            Console.WriteLine("Debit 15000");
            c.Debit(15000);
            Console.WriteLine(c);

            Console.WriteLine("debit 6000");
            c.Debit(6000);
            Console.WriteLine(c);

            Console.WriteLine("Credit 15000");
            c.Credit(15000);
            Console.WriteLine(c);

            Console.WriteLine("Credit 5000");
            c.Credit(5000);
            Console.WriteLine(c);

            Console.WriteLine("Debit 20000");
            c.Debit(20000);
            Console.WriteLine(c);
        }
    }
}
