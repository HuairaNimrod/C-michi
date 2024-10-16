// create a program that have two functions, one to add words and other to find the translation 
// of a word from english to spanish
// if the translation is not found return ????. asume one word is linked to a translation.

using System;
using System.Collections.Generic;

namespace Translator{

    class Program
    {
        private static void Main (){

            Program translator = new Program();

            var duolingo = new Dictionary<string, string>();

            translator.addwords("hi", "hola", duolingo);
            translator.addwords("five", "cinco", duolingo);
            translator.addwords("red", "rojo", duolingo);
            translator.addwords("fall", "otoño", duolingo);
            
            // Console.Write(string.Join(",", duolingo)); check if words were added;
            Console.Write("Enter the word: ");
            string word = Console.ReadLine();
            translator.checkIfContained(word, duolingo);
            

        }    

        public void addwords(string word, string meaning, Dictionary<string, string> duolingo){

            duolingo.Add(word, meaning);

        }

        public void checkIfContained(string word, Dictionary<string, string> duolingo){

            if(!duolingo.ContainsKey(word)){
                Console.WriteLine("????");
            }
            else{
                Console.WriteLine(duolingo[word]);
            }

        }
    
    }
}