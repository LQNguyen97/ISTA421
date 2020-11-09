using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Exercise09_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintUI.printUI();
        }
    }
    class PrintUI
    {
        public static void printUI()
        {
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"PASSWORD AUTHENTICATION SYSTEM");
            Console.WriteLine($"\n");
            Console.WriteLine($"Please select one option:");
            Console.WriteLine($"\n");
            Console.WriteLine($"1. Establish an account");
            Console.WriteLine($"2. Authenticate a user");
            Console.WriteLine($"3. Print users");
            Console.WriteLine($"\n");
            Console.WriteLine($"[Enter 0 to exit the system]");
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"\n");
            Console.Write($"Enter selection: ");
            string response = Console.ReadLine();
            UserResponse choice = new UserResponse();
            choice.userResponse(response);
        }
    }
    class UserResponse : PrintUI
    {

        public void userResponse(string response)
        {
            while (response != "0")
            {
                if (response == "1")
                {
                    GetNewUser now = new GetNewUser();
                    now.getNewUser();
                    printUI();
                }
                else if (response == "2")
                {
                    GetUser last = new GetUser();
                    last.getUser();
                    printUI();
                }
                else if (response == "3")
                {
                    PrintUsers all = new PrintUsers();
                    all.printUsers();
                    printUI();
                }
                else
                {
                    Console.WriteLine($"Please enter a valid number selection!");
                    printUI();
                }
            }
            Environment.Exit(0);
        }
        class PrintUsers : UsersDB
        {
            public void printUsers()
            {
                foreach (var pair in daTa)
                {
                    Console.WriteLine($"NAME: {pair.Key}");
                    Console.WriteLine($"PASSWORD: {pair.Value}");
                }
            }
        }
        class UsersDB
        {
            public static Dictionary<string, string> daTa = new Dictionary<string, string>();
        }
        class GetNewUser : UsersDB
        {
            public void getNewUser()
            {
                Console.Write($"Enter your name: ");
                string name = Console.ReadLine();
                Console.Write($"Enter your password: ");
                Crypto hash = new Crypto();
                string pw = hash.getCrypto(Console.ReadLine());
                daTa.Add(name, pw);
            }
        }
        class Crypto
        {
            public string getCrypto(string pass)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }
        class GetUser : UsersDB
        {
            public void getUser()
            {
                Console.Write($"Authenticate your name: ");
                string name = Console.ReadLine();
                Console.Write($"Authenticate your password: ");
                Crypto hash = new Crypto();
                string pw = hash.getCrypto(Console.ReadLine());
                foreach (var pair in daTa)
                    if (daTa.ContainsKey(name) && daTa.ContainsValue(pw))
                    {
                        Console.WriteLine($"****User Authenticated****");
                    }
                    else
                        Console.WriteLine($"****Invalid Username/Password****");
            }
        }
    }
}
