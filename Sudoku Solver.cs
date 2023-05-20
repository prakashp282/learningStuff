// Problem statement : https://leetcode.com/problems/sudoku-solver/description/
37. Sudoku Solver
Hard

Write a program to solve a Sudoku puzzle by filling the empty cells.

A sudoku solution must satisfy all of the following rules:

    Each of the digits 1-9 must occur exactly once in each row.
    Each of the digits 1-9 must occur exactly once in each column.
    Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.

The '.' character indicates empty cells.

 

Example 1:

Input: board = [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]
Output: [["5","3","4","6","7","8","9","1","2"],["6","7","2","1","9","5","3","4","8"],["1","9","8","3","4","2","5","6","7"],["8","5","9","7","6","1","4","2","3"],["4","2","6","8","5","3","7","9","1"],["7","1","3","9","2","4","8","5","6"],["9","6","1","5","3","7","2","8","4"],["2","8","7","4","1","9","6","3","5"],["3","4","5","2","8","6","1","7","9"]]
Explanation: The input board is shown above and the only valid solution is shown below:


 

Constraints:

    board.length == 9
    board[i].length == 9
    board[i][j] is a digit or '.'.
    It is guaranteed that the input board has only one solution.


/////////// Solution. /////////////

using System;

namespace HelloWorld
{
  class Program
  {
  
    public static void SolveSudoku(char[][] board) {
      if(board == null | board.Length == 0) return;
      solveSudoku(board, 0, 0); //itterative solution.
    }
    public static bool solveSudoku(char[][] board, int i, int j){  
        if(i == 9) return true;
        else if(j == 9) return solveSudoku(board, i+1, 0);
        else if(board[i][j] != '.') return solveSudoku(board, i, j+1);
        else {
          for(char value = '1'; value <='9'; value++){
            if(isValid(board, i, j, value)){
              board[i][j] = value; // hit and trial method set the value.
              if(solveSudoku(board,i,j+1)){
               //Console.WriteLine("LOOP setting for :" +i+ " " + j +" :"+ value);
               return true; //check correctness itteratively.
              }
              
              board[i][j] = '.'; //reset value if not solveable.
            }
          }
          return false;
        }
      }
    public static bool isValid(char[][] board,int i,int j,char value){
      for(int x=0; x<9; x++){        
        //check if the value already exists in row
        if(board[i][x] != '.' && board[i][x] == value) return false;
        //check if the value already exists in column 
        if(board[x][j] != '.' && board[x][j] == value) return false; 
        //check if the value already exists in cube
        int k= (i /3) *3 + x/3;
        int l= (j /3) *3 + x%3;
        if(board[k][l] != '.' && board[k][l] == value) return false; 
      }
      return true;
    }

    static void Main(string[] args)
    {
    char[][] inputBoard = {
    new char[] {'5','3','.','.','7','.','.','.','.'},
    new char[] {'6','.','.','1','9','5','.','.','.'},
    new char[] {'.','9','8','.','.','.','.','6','.'},
    new char[] {'8','.','.','.','6','.','.','.','3'},
    new char[] {'4','.','.','8','.','3','.','.','1'},
    new char[] {'7','.','.','.','2','.','.','.','6'},
    new char[] {'.','6','.','.','.','.','2','8','.'},
    new char[] {'.','.','.','4','1','9','.','.','5'},
    new char[] {'.','.','.','.','8','.','.','7','9'}};
       
     SolveSudoku(inputBoard);
     
     
     //Solution : 
     
     for(int i = 0; i <9;i++){
        	for(int j =0; j<9; j++){
              Console.Write(inputBoard[i][j] + "  ");
            }
            Console.WriteLine();
      }
     
     
    }
  }
}

//////////////////////checking all possible valid values///////////
using System;
using System.Collections.Generic;

namespace HelloWorld
{
  class Program
  {
  
  
  	public static void validValues(char[][] board){
    
    	for(int i = 0; i <9;i++){
        	for(int j =0; j<9; j++){
            if(board[i][j] != '.') {continue;}
            
            List<char> result = new List<char>();
            	       
            for(char value = '1'; value <='9'; value++){
             	 if(isValid(board, i, j, value)){
                 	result.Add(value);
                 }
            }
             Console.WriteLine("for "+ i + " " +j+ "value  :" + string.Join(", ", result));
            }
        }
    
    }
    
    public static bool isValid(char[][] board,int i,int j,char value){
      for(int x=0; x<9; x++){        
        //check if the value already exists in row
        if(board[i][x] != '.' && board[i][x] == value) return false;
        //check if the value already exists in column 
        if(board[j][x] != '.' && board[x][j] == value) return false; 
        //check if the value already exists in cube
        int k= (i /3) *3 + x/3;
        int l= (j /3) *3 + x%3;
           

        if(board[k][l] != '.' && board[k][l] == value){ 
        
        //Console.WriteLine("cube reject value for "+ i + " " +j+ "value  :" + value + " as " + k +" " + l +" has this value");

        return false;
        }
      }
      return true;
    }

  
    static void Main(string[] args)
    {
      char[][] inputBoard = {
    new char[] {'5','3','.','.','7','.','.','.','.'},
    new char[] {'6','.','.','1','9','5','.','.','.'},
    new char[] {'.','9','8','.','.','.','.','6','.'},
    new char[] {'8','.','.','.','6','.','.','.','3'},
    new char[] {'4','.','.','8','.','3','.','.','1'},
    new char[] {'7','.','.','.','2','.','.','.','6'},
    new char[] {'.','6','.','.','.','.','2','8','.'},
    new char[] {'.','.','.','4','1','9','.','.','5'},
    new char[] {'.','.','.','.','8','.','.','7','9'}};
       
     validValues(inputBoard);
    }
  }
}


