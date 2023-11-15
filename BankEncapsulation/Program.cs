namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much cash money money dolla bills woul you like to drop?");
            int userInput;
            bool isUserInputInt = int.TryParse(Console.ReadLine(), out userInput);

            if (isUserInputInt )
            {
                Console.WriteLine($"You are wanting to deposit: {userInput}.  One moment.");
                Console.Clear();
                BankAccount account = new BankAccount();
                account.Balance(userInput);
                account.GetBalance();
            }
            else
            {
                Console.WriteLine("Invalid input, try again with with an actual number you silly goose.");
            }

        }
    }
}
