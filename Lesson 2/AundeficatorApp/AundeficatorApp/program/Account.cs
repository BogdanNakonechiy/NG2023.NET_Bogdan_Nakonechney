using AundeficatorApp.data;

namespace AundeficatorApp.program
{
    internal class Account
    {
        public static bool Aundeficator(string username, string password)
        {
            foreach(var person in db.userArray)
            {
                if(person != null && person.GetUsername() == username && person.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Delete(string username, string password)
        {
            int count = 0;
            foreach (var person in db.userArray)
            {
                if (person.GetUsername() == username && person.GetPassword() == password)
                {
                    db.userArray[count] = null;
                    return true;
                }
                count++;
            }
            return false;
        }
    }
}
