using System;
using System.Collections.Generic;

namespace Bubble {

        class Program
        {

            private static void Main (string[] args){

                Program progri = new Program(); // class object

                var numbers = new List<int> {22,4,31,10,5};

                progri.orderList(numbers);
                progri.printArray(numbers);
            }

            private void printArray(List<int> numbers){

                Console.WriteLine();    
                Console.WriteLine("List of numbers");
                foreach (var number in numbers)
                {
                    Console.Write(number+ " ");
                }
            }

            private void orderList(List<int> numbers){
            
            int aux; 

            for(int j = 0; j< numbers.Count-1; j++){ 
                for(int i = 0; i<numbers.Count-1; i++){
                        if(numbers[i]>numbers[i+1]){
                            aux = numbers[i];
                            numbers[i]= numbers[i+1];
                            numbers[i+1]= aux;
                            Console.WriteLine("");
                        }     
                }
            }
                

            }
        
        }
}

    