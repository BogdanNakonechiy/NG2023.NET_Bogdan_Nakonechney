using AundeficatorApp.data;

namespace AundeficatorApp.program
{
    internal class Interface
    {
        static void Main(string[] args)
        {
            service.reg("Admin", "123456"); // test user
            Console.Clear();

            string username;
            string password;
            string action;
            
            while (true)
            {
                Console.WriteLine("--- Enter data ---");
                Console.Write("Username > ");
                username = Console.ReadLine();
                Console.Write("Password > ");
                password = Console.ReadLine();

                if(Account.Aundeficator(username, password))
                {
                    Console.WriteLine("--- You've logged into the account ---");

                    
                }
                else
                {
                    Console.WriteLine("\nIncorrect password or login.\n" +
                                      "Press enter to retry...");
                    Console.ReadLine();
                    Console.Clear();

                }
            }

        }
    }
}
