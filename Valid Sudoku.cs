Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

    Each row must contain the digits 1-9 without repetition.
    Each column must contain the digits 1-9 without repetition.
    Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

Note:

    A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    Only the filled cells need to be validated according to the mentioned rules.

 
Example 1:

Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true

Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.



///////////////////Cube itteration logic ///////////
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    	int i = 1;
      for(int j=0;j<9;j++){
            	if(j%3 == 0) {Console.WriteLine();}

    	int x= i % 3 *3 + j/3 ;
        int y= j % 3 + i/3 * 3;
      Console.Write(x +" "+y + "    ");
      }
    }
  }
}

///Solution////


public class Solution {
    public bool IsValidSudoku(char[][] board) {
            HashSet<char> row = new HashSet<char>();
            HashSet<char> col = new HashSet<char>();
            HashSet<char> cube = new HashSet<char>();
                        
            for(int i = 0; i < 9; i++){
              //reset all values as we compare for i th value in each itteration
              row.Clear();
              col.Clear();
              cube.Clear();

               for(int j = 0 ;j < 9; j++){
                  //lets compare for row
                  if(board[i][j] != '.' && !row.Add(board[i][j]))	{
                    return false;
                  }
                  //Comparing for column
                  if(board[j][i] != '.' && !col.Add(board[j][i]))	{
                    return false;
                  }

                  //lets compare for cube. and get cube coordinates
                  int x= i % 3 * 3 + j/3;
                  int y= j % 3 + i/3 * 3;
                  if(board[x][y] != '.' && !cube.Add(board[x][y]))	{
                    return false;
                  }
            	}
            }    
            return true; 
    }
}
