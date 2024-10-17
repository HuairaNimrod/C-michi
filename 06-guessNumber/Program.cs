// generate a number randomly and then ask the user to guess the number,
// hints will be provided, higher or lower, until the number is guessed.

using System;

namespace guessNumber{

    class Program(){

        static void Main (){

            Program guessNumber = new Program();

            // generate the random number
            Random randomGenerator = new Random();
            int random = randomGenerator.Next(1,10);

            Console.WriteLine(random);

            bool guessed = false;
            

            // if number guessed print message and end program

            
            do{
                // ask the user to input a number
                Console.Write("Enter a number: ");
                int number = Int32.Parse(Console.ReadLine());
                guessed = guessNumber.wasGuessed(random, number);
            }while (!guessed);

            

            
        }

        public bool wasGuessed(int random, int number){

            if(random == number){
                Console.WriteLine("Guessed!");
                return true;
            }
            else{
                // if number is higher print message "lower" and request a new input
                if(random < number){
                    Console.WriteLine("lower! v");
                }
                
                // if number is lower print message "higher" and request a new input
                if(random > number){
                    Console.WriteLine("higher! ^");
                }
                return false;
            }

        }
    }
}


