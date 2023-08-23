namespace AundeficatorApp.data
{
    internal class db
    {
        public static void addUser(string username, string password)
        {
            int count = 0;
            foreach (var user in db.userArray)
            {
                if (user == null)
                {
                    db.userArray[count] = new User(username, password);
                    break;
                }
                else
                {
                    count++;
                }

            }
        }
        public static User[] userArray = new User[10];
    }
    internal class User
    {
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        
        private string username;
        private string password;

        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
