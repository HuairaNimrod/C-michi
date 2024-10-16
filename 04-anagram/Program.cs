// an anagram is word created by re-arranged the letters of a word to form a new one, 
// determine if two given words are anagrams.

using System;
using System.Collections.Generic;

namespace Anagram
{
    
    class Program{

        public static void Main (string[] args){

            Program anagram = new Program();

            string word1 = "hydroxydeoxycorticosterones";
            string word2 = "hydroxydesoxycorticosterone";

            bool isAna = anagram.isAnagram(word1, word2);
            Console.WriteLine(isAna);

        }

        private bool isAnagram(string word1, string word2){

            // create dictionaries

            var dictionary1 = new Dictionary<char, int>();
            foreach (var letter in word1)
            {
                if(!dictionary1.ContainsKey(letter)){
                    dictionary1[letter]= 1;
                }
                else{
                    dictionary1[letter]+= 1;
                }
            }
            // look up if elements from dictionary one is included on other dictionary

            // Console.WriteLine(string.Join(", ", dictionary1)); //string.join is used to print an array or dictionary in pairs

            var dictionary2 = new Dictionary<char, int>();
            foreach (var letter in word2)
            {
                if(!dictionary2.ContainsKey(letter)){
                    dictionary2[letter]= 1;
                }
                else{
                    dictionary2[letter]+= 1;
                }
            }
            
            
            foreach (var item in dictionary1)
            {
                if(dictionary2.ContainsKey(item.Key))
                {
                    if(dictionary2[item.Key]!=item.Value){
                        return false;
                    }
                }
                else{
                    return false;
                }

            }

                return true;

        }

    }
}