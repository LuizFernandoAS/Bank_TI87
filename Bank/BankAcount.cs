using System;

namespace Bank
{
    public class BankAcount
    {
        private readonly string m_customerName;
        private double m_balance;
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        public BankAcount() { }

        public BankAcount(string customerName, double balance)
        {
            this.m_customerName = customerName;
            this.m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }
            
         
        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount) 
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount;
        }
        
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
             m_balance += amount;
        }

        public static void Main()
        {
            BankAcount ba = new BankAcount("Luiz Fernando", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);

        }   

     }

}




