// given an array of numbers look for pair values whose sum will be equal to a number given,
// print the pair value avoiding repetition 
// if your list is [1,2,3,4,5,6,7,8,9] and your sum is 10 you can display 1-9, 2-8, 3-7, 4-6 and not 9-1 or other similar values

using System;
using System.Collections.Generic;

namespace DisplaySum {

    class Program {

        static void Main(){
            
            var arrayNumbers = new []{1,2,3,4,5,6,7,8,9};
            int givenNumber = 10;

            Console.WriteLine(string.Join(", ", getPairs(arrayNumbers, givenNumber)));

        }

        public static List<string> getPairs( int[] numbers, int givenNumber){

            var mySet = new HashSet<int>();
            var pairList  = new List<string>();
            
            foreach(var number in numbers){
                int pairNumber = givenNumber-number;
                if(mySet.Contains(pairNumber)){
                    pairList.Add(number+"-"+pairNumber);
                }
                mySet.Add(number);
            }
            
            return pairList;
        }
    }
}