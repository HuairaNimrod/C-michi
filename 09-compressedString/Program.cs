// a compressed string is composed of a number linked to a string, example 3[a]
//  to descompressed the string the compressed string needs to be repeteaed N times being N the number linked to the compressed string
// 3[a]2[c] = aaacc | 2[ab]d = ababd

using System;
using System.Collections.Generic;

namespace CompressedString{

    class Program{

        static void Main(){

            Program uncompress = new Program();
            var stringDicitonary = new Dictionary<string, int>();
            string compressedString = "2[2[a]b]";

            // find values
            uncompress.uncompressString(compressedString, stringDicitonary);
            // build string
            Console.WriteLine(uncompress.buildString(stringDicitonary));

        }

        public void uncompressString(string compressedString, Dictionary<string, int> stringDictionary){
            
            string[] stringArray = compressedString.Split("]");
            foreach(var newString in stringArray){
                string[] valuePair = newString.Split("[");
                // valuePair[] = [2,ac] | [d]
                if(valuePair.Length==1){
                    stringDictionary[valuePair[0]] = 1;
                }
                else{
                    stringDictionary[valuePair[1]] = Convert.ToInt32(valuePair[0]);
                }
            }
            
            // Console.WriteLine(string.Join(",", stringDictionary));

        }
        private string buildString(Dictionary<string, int> stringDictionary){
            string finalString = "";


            foreach (var item in stringDictionary)
            {
                var largeString = "";
                string currString = item.Key;
                for(int i=0; i<item.Value; i++ ){
                    largeString+= currString;
                }

                finalString+=largeString;
            }

            return finalString;
        }


    }
}