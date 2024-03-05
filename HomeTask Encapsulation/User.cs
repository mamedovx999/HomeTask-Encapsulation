using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Encapsulation
{
    internal class User
    {
        public string Username { get; set; }
        private string _password;
        private int _age;
        public int Age {
            get
            {               
              return _age;      
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("menfi olmaz");
                    return;
                }  
                _age = value;

            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("bos olmaz");
                    return;
                }
                if (value.Length < 8)
                {
                    Console.WriteLine("Uzunluğu 8-dən kiçik ola bilməz");
                    return;
                }
                if (CheckCapitalLetter(value))
                {
                    Console.WriteLine("İçində ən az bir böyük hərf olmalıdır");
                    return;
                }
                if (!CheckNumber(value))
                {
                    Console.WriteLine("İçində ən az bir rəqəm olmalıdır");
                    return;

                }
                _password = value;



            }
        }
        public User (string username, string password)
        {
           Username = username;
           Password = password;
        }
        public User(string username, string password, int age)
        {
            Username = username;
            Password = password;
            Age = age;
        }

        private bool CheckCapitalLetter(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsUpper(c) && char.IsLetter(c))
                    return true;
            }
            return false;
        }

        private bool CheckNumber(string password)
        {
            foreach(char c in password)
            {
                if(!char.IsDigit(c))
                    return true;
            }
            return false;
        }

    }
}
