namespace SOLID.SingleResponsibilityPrinciple
{
    public class BankAccount : IBankAccount
    {
        public BankAccount()
        {
        }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal CalculateInterest()
        {
            //Code to calculate Interest

            return 0;
        }

    }
}
