using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public delegate void MydelAccount();
   public class BankBalance
    {
        public event MydelAccount Insufficient;
        public event MydelAccount Zaro;
        private double Abalance;

        public BankBalance(double Abalance)
        {
            this.Abalance = Abalance;
        }
        public void Debit(double amount)
        {
            if(Abalance<amount)
            {
                Insufficient();
            }
            else
            {
                Abalance -= amount;
                if(Abalance==0)
                {
                    Zaro();
                }
            }
        }
        public void Credit(double amount)
        {
            Abalance += amount;
        }
        public override string ToString()
        {
            return $"Cureent Balance is {Abalance}";
        }
        public static class Message
        {
            public static void InsufficientBalance()
            {
                Console.WriteLine("Insufficient Balance to withdrow");
            }
            public static void ZeroBalance()
            {
                Console.WriteLine("Current Account balance is zero");
            }

        }
        public class Transactions
        {
            static void Main(string[] args)
            {
                BankBalance b = new BankBalance(5000);
                b.Insufficient += new MydelAccount(Message.InsufficientBalance);
                b.Zaro += new MydelAccount(Message.ZeroBalance);
                Console.WriteLine("Credit.1000");
                b.Credit(1000);
                Console.WriteLine(b);
                Console.WriteLine("Debit Amount is 15000");
                b.Debit(15000);
                Console.WriteLine(b);
                Console.WriteLine("Debit 6000");
                b.Debit(6000);
                Console.WriteLine(b);
            }
        }

    }
}
