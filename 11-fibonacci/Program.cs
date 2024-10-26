//print the fibonacci number for n being n a number, where 0< n < 100 Consider using a dictionary and recursion 
// 1,1,2,3,5,8,13,21,34,55 ...

using System;
using System.Collections.Generic;

namespace fibonacci {

    class Program {

        static void Main(){

            Program Fibo = new Program();
            var memory =  new Dictionary<int, long>();    
            Console.WriteLine(Fibo.GetFibo(1, memory));  //1
            Console.WriteLine(Fibo.GetFibo(3, memory));  //2
            Console.WriteLine(Fibo.GetFibo(10, memory)); //55
            //test memory
            Console.WriteLine(Fibo.GetFibo(50, memory));  //12586269025
            Console.WriteLine(Fibo.GetFibo(90, memory));  //2880067194370816120
        }

        public long GetFibo(int number, Dictionary<int, long> memory){

            if(number<=2)
                return 1;

            if(memory.ContainsKey(number))
                return memory[number];
            
            var result =  GetFibo(number-1, memory)+ GetFibo(number-2, memory);

            memory[number]= result;
            
            return result;
            
            
        }
    }
}


