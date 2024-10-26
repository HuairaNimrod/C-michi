// the words in a string can be reorganized mathematically n!, using recursing display each posible combination
// string ABC = ABC ACB BAC BCA CAB CBA
//

using System;

namespace Permutation{

    class Program{

        static void Main(){

            Program permute = new Program();
            string letters = "ABC";
            string word = "";
            permute.Permutation(letters, word);
        }

        public void Permutation(string letters, string word){
            
            if(letters.Length==0){
                Console.WriteLine(word);
            }
            else{
                for(int i = 0; i<letters.Length; i++){
                    var lettersLeft = letters.Remove(i, 1);
                    Permutation(lettersLeft, word + letters[i]);
                    
                    
                }
            }

        }
    }
}