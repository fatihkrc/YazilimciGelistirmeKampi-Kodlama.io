﻿using System;

namespace P07GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Fatih");
            
            Console.WriteLine("Hello World!");
        }
    }
}