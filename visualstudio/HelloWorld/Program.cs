﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";

            Console.WriteLine(message);

            message = "10";
            Console.WriteLine(message);

            Console.WriteLine("Hello World!");
            Console.ReadLine(); // Polls for input
        }
    }
}
