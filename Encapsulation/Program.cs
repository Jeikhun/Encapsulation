﻿using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istifadechi adi: ");
            string name = Console.ReadLine();
            Password:
            Console.WriteLine("Shifre: ");
            string password = Console.ReadLine();
            User newuser = new User(name, password);
            Console.WriteLine(newuser.Password);

        }
    }
}
