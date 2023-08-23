using AundeficatorApp.data;

namespace AundeficatorApp.program
{
    internal static class service
    {
        public static void reg(string username, string password)
        {
            db.addUser(username, password);
            Console.WriteLine("Successful registration!");
        }
    }
}
