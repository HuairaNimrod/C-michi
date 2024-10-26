// Determine if  given string contains unique letters or not, use sets to get an O(n) performance
// abcd = true, abceedfg = false

using System;
using System.Collections.Generic;

class Program{

    static void Main(){

        Program unique = new Program();
        string phrase1 = "abcd";                //true
        string phrase2 = "abceedfg";            //false
        string phrase3 = "abcdd";               //false
        string phrase4 = "abcedfgijlkmm";       //false
        string phrase5 = "abcdefghijklmnwxyz";  //true
        string phrase6 = "ee";                  //false 

        Console.WriteLine(unique.IsUnique(phrase1));
        Console.WriteLine(unique.IsUnique(phrase2));
        Console.WriteLine(unique.IsUnique(phrase3));
        Console.WriteLine(unique.IsUnique(phrase4));
        Console.WriteLine(unique.IsUnique(phrase5));
        Console.WriteLine(unique.IsUnique(phrase6));

    }

    public bool IsUnique(string phrase){
        
        var wordSet = new HashSet<char>();

        foreach(var word in phrase){
            if(wordSet.Contains(word)){
                return false;
            }
            wordSet.Add(word);
        }

        return true; 
    }
}