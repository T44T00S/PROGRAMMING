using System;
using System.Collections.Generic;

namespace _14_Login_with_simple_database
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User("admin", "1234");
            User usr2 = new User("josef", "1234");
            User usr3 = new User("karel", "1234");

            Console.WriteLine(usr1.username);

            usr1.username = "";

            User.Login(Console.ReadLine(), Console.ReadLine());
        }
    }

    class User
    {
        public string username { set; private get; }
        public string password;
        public static List<User> db = new List<User>();

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

            //Console.WriteLine(username + " byl vytvořen.");

            db.Add(this);
        }

        bool Check(string username)
        {
            foreach (var item in collection)
            {

            }
        }
        public static void Login(string username, string password)
        {
            if (db.Exists(m => m.username == username)) ;
            {
                User current = db.Find(m => m.username == username);

                if (current.password == password)
                {
                    Console.WriteLine("Úspěšně přihlášen.");
                }
            } else
            {
                Console.WriteLine("Takový uživatel neexistuje.");
            }
        }
    }
}
