using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class User
    {
        private string _password;
        private string _username;
        public string Username {
            get
            {
                return _username;
            }
            set
            {
                if(value == null || value.Length<3 || value.Length>15 || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Duzgun Username daxil edin");
                }
                else
                {
                    _username = value;
                }
            } 
        }
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if (SetPass(value) == true)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Shifre duzgun deyil");
                }

            }
        }
        public User(string username, string password)
        {

            if (CheckPass(password) == true)
            {
                Username = username;
                Password = password;
            }
        }
        public bool CheckPass(string pass)
        {
            if (pass.Length < 8)
            {
                Console.WriteLine("Password minimal 8 simvoldan ibaret olmalidir");
                return false;
            }
            else if (!pass.Any(char.IsDigit))
            {
                Console.WriteLine("Password-da minimal 1 reqem olmalidir");
                return false;
            }
            else if (!pass.Any(char.IsUpper))
            {
                Console.WriteLine("Password-da minimal 1 boyuk herf olmalidir");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool SetPass(string pass)
        {
            if (pass.Length < 8)
            {
                Console.WriteLine("Password minimal 8 simvoldan ibaret olmalidir");
                return false;
            }
            else if (!pass.Any(char.IsDigit))
            {
                Console.WriteLine("Password-da minimal 1 reqem olmalidir");
                return false;
            }
            else if (!pass.Any(char.IsUpper))
            {
                Console.WriteLine("Password-da minimal 1 boyuk herf olmalidir");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
