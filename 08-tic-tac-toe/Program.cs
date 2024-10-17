// author: Nim Huaira
// Tic-tac-toe is a game in which two gamers try to complete a row, column, or diagonal in a matrix of 3x3

using System;
using System.Collections.Generic;

namespace TicTacToe{

    class Program(){

        public static void Main(){

            Program tictactoe = new Program();

            List<string> matrix = new List<string>(){"1","2","3","4","5","6","7","8","9"};
            
            bool gameEnded = false;
            tictactoe.showMatrix(matrix);
            string SymbolPosition ="";
            string currentSymbol = "O";

            do{
                Console.Write("Choose a number to enter '"+currentSymbol+  "' :");
                SymbolPosition = Console.ReadLine(); 

                
                tictactoe.enterSymbol(currentSymbol, SymbolPosition, matrix);
                              
                if(currentSymbol=="O"){
                    currentSymbol="X";
                }
                else{
                    currentSymbol="O";
                }

                Console.Clear(); // Clean console
                Console.WriteLine("\x1b[3J"); // Clear scrollbar buffer

                tictactoe.showMatrix(matrix);

                gameEnded = tictactoe.isGameOver(matrix);


            }while(!gameEnded);
            


        }
        //display 3x3 matrix, show numbers in each grid of the matrix
        public void showMatrix(List<string> matrix){
            int i=1;
            foreach( var number in matrix){

                 Console.Write("|"+ number);

                if(i%3==0){
                        Console.Write("| \n" );
                }
                               
                i++;
                
            }

        }

        public void enterSymbol(string currentSymbol, string symbolPosition, List<string> matrix){
            var index = -1;
            foreach(var number in matrix){
                if(number==symbolPosition){
                    index = Int32.Parse(number)-1;
                }
            }
            if(index!=-1){
                matrix[index]=currentSymbol;
            }

        }

        public bool isGameOver(List<string> matrix){
            
            int i = 0;
            //ties 
            foreach(var symbol in matrix){
                if(symbol=="O"|| symbol=="X"){
                    i++;    
                }    
            }
            // Console.WriteLine("symbols: "+i); // check if i is counting

            if(i==9){
                Console.WriteLine("Game Over: Ties!!!!!");
                return true;
            }

            // one player win
            // 012
            // 345
            // 678

            if(i>=5){
                // row
                if(matrix[0]==matrix[1] && matrix[1]==matrix[2]){
                    Console.WriteLine(" '"+matrix[0]+"'"+" Win!");
                    return true;
                }
                else if(matrix[3]==matrix[4] && matrix[4]==matrix[5]){
                    Console.WriteLine(" '"+matrix[3]+"'"+" Win!");
                    return true;
                }
                else if(matrix[6]==matrix[7] && matrix[7]==matrix[8]){
                    Console.WriteLine(" '"+matrix[6]+"'"+" Win!");
                    return true;
                }
                // column
                if(matrix[0]==matrix[3] && matrix[3]==matrix[6]){
                    Console.WriteLine(" '"+matrix[0]+"'"+" Win!");
                    return true;
                }
                else if(matrix[1]==matrix[4] && matrix[4]==matrix[7]){
                    Console.WriteLine(" '"+matrix[1]+"'"+" Win!");
                    return true;
                }
                else if(matrix[2]==matrix[5] && matrix[5]==matrix[8]){
                    Console.WriteLine(" '"+matrix[2]+"'"+" Win!");
                    return true;
                }
                // diagonal 
                if(matrix[0]==matrix[4] && matrix[4]==matrix[8]){
                    Console.WriteLine(" '"+matrix[0]+"'"+" Win!");
                    return true;
                }
                if(matrix[2]==matrix[4] && matrix[4]==matrix[6]){
                    Console.WriteLine(" '"+matrix[2]+"'"+" Win!");
                    return true;
                }

            }

            return false;
        }

    }

    
    
}