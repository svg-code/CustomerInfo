using System;

namespace CustomerInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount customer1 = new CustomerAccount("Akinro Nelson", 2345657642, 10000.23, 2476879109);
            Console.WriteLine(customer1.GetAccountBalance());
            Console.WriteLine(customer1.DebitAccount(500));
            Console.WriteLine(customer1.CreditAccount(1000));
        }
    }

    class CustomerAccount
    {
        public string CustomerName { get; set; }
        public long AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public long BankVerificationNumber { get; set; }

        public CustomerAccount(string aCustomerName, long aAccountNumber, double aAccountBalance, long aBankVerificationNumber)
        {
            CustomerName = aCustomerName;
            AccountNumber = aAccountNumber;
            AccountBalance = aAccountBalance;
            BankVerificationNumber = aBankVerificationNumber;
        }

        public double GetAccountBalance()
        {
            return AccountBalance;
        }

        public double DebitAccount(double amount)
        {
            return AccountBalance -= amount;
        }

        public double CreditAccount(double amount)
        {
            return AccountBalance += amount;
        }
    }
}



