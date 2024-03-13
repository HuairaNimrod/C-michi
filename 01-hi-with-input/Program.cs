using System;

namespace hi_with_input {

    class Program{

        static void Main(string[] args){
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi "+ name);
        }
    }
}