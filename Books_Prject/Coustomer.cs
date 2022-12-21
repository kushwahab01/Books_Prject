using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    public enum AccountType { Saving, Current}
    public class Coustomer
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public AccountType AccountType;
        public List<Loan> loans = new List<Loan>();
    }
    public class Loan
    {
        public int Id { set; get; }
        public string LoanName { set; get; }
    }
    public class Bank
    {
        static void Main(string[] args)
        {
            List<Coustomer> c = new List<Coustomer>()
            {
                new Coustomer
                {
                    AccountNumber = 12345,
                    Name = "brijesh",
                    AccountType = AccountType.Saving,
                    loans =
                {
                    new Loan{ Id=1,LoanName="Car"},
                    new Loan{ Id=2,LoanName="Personal"},
                    new Loan{ Id=3,LoanName="Home"},

                }


                },
                new Coustomer
                {
                    AccountNumber=626435,
                    Name="Sanjeev",
                    AccountType=AccountType.Current,
                    loans=
                    {
                        new Loan{Id=4, LoanName="Business"}
                    }

                }

           };
            foreach (Coustomer item in c)
            {
                Console.WriteLine($"{item.Name}, {item.AccountType}");
                foreach (Loan l in item.loans)
                {
                    Console.WriteLine("\t"+l.LoanName);
                }
            }
            
        }
    }
}
