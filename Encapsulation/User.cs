﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class User
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
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
    }
}