namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount();

            ATM.UserInterface(userAccount);
           
        }
    }
}
