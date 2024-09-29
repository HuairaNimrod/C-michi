using System;
using System.Collections.Generic;

namespace Divisors {

    class Program{

        static void Main(string[] args){
            Console.WriteLine("Programs that prints the divisors of a number, except the number, in an Dynamic Array ");
            Console.Write("number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            List<int> numi = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if(number%i==0){
                    numi.Add(i);
                }                
            }

            foreach(var num in numi)
            {
                Console.Write(num+ " ");
            }
        }
    }
}