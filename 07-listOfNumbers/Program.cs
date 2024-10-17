//request a series of numbers from the user until 0 is enter
// compute the sum of the numbers, the average, and find the max number or largest in the list

using System;
using System.Collections.Generic;

namespace listOfNumbers{

    class Program(){

        static void Main(){

           Program listOfNumbers = new Program(); //instance of Program

           List<int> numbers = new List<int>(); //declare the list of numbers

           // request a number to the user
            int number = 0;
           // while number != 0 add the number to the list
            do{

            Console.Write("Enter a number: ");
            number = Int32.Parse(Console.ReadLine());
            if(number!=0){
                listOfNumbers.append(number, numbers);
            }

            } while(number!=0);
           //when number == 0  loop through the list and sum the numbers, find the average and find the max number
            Console.WriteLine(listOfNumbers.getSum(numbers));
            Console.WriteLine(listOfNumbers.getAverage(numbers));
            Console.WriteLine(listOfNumbers.findMax(numbers));

        }

        public void append(int number, List<int> numbers){
            numbers.Add(number);
        }
        public int getSum( List<int> numbers){
        
            int sum = 0;
            foreach( var number in numbers ){
                sum = sum + number;
            }
       
            return sum;
        }
        public double getAverage( List<int> numbers){
            
            int sum = 0;
            foreach(var number in numbers ){
                sum = sum + number;
            }
            if(sum==0){
                return 0;
            }
            
            double average = (double)sum/(numbers.Count);
            return Math.Round(average, 2);
        }
        public int findMax( List<int> numbers){
            int maxNumber = -1;
            foreach(var number in numbers){
                if (number>maxNumber){
                    maxNumber = number;
                }
            }

            return maxNumber;
        }
    }
}