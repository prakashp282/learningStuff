Test codes 
/////////// check in code sample /////////////
using System;

namespace HelloWorld
{
  class Program
  {
  
    public static void SolveSudoku(char[][] board) {
      if(board == null || board.Length == 0 || board[0].Length == 0) return;
      solve(board, 0, 0); //itterative solution.
    }
    
    
    public static bool solve(char[][] board, int i, int j){

        if(i == 9) {return true;}
        else if(j == 9) {return solve(board, i+1, 0);}
        else if(board[i][j] != '.') {return solve(board, i, j+1);}
        
       	else {
          for(char value = '1'; value <='9'; value++){

            if(isValid(board, i, j, value)){
               Console.WriteLine("LOOP setting for :" +i+ " " + j +" :"+ value);

              board[i][j] = value; // hit and trial method set the value.
              if(solve(board,i,j+1)) {return true;} //check correctness itteratively.
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
        if(board[j][x] != '.' && board[x][j] == value) return false; 
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


