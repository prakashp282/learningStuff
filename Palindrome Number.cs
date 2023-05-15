Given an integer x, return true if x is a
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

 

Constraints:

    -231 <= x <= 231 - 1
 
Solution 1: 

using System;
using System.Collections.Generic;


namespace HelloWorld
{
  class Program
  {
  
  	public static  bool resultsFun(){
       
        int x = 101;
        string s = x.ToString();
        
        //Based on the length we decide how much to itterate on array.
        //var length = s.Length % 2 == 0 ? s.Length/2 : (s.Length -1)/2 ; 
        
        for(int i = 0; i < (s.Length % 2 == 0 ? s.Length/2 : (s.Length -1)/2) ; i++){
        	if(s[i] != s[s.Length-i-1]){
            return false;
            }
        }
        
       
        return true;
   
   
    }
    static void Main(string[] args)
    {
             Console.WriteLine(resultsFun());    
    }
  }
}


Follow up: Could you solve it without converting the integer to a string?

Solution 2:
using System;
using System.Collections.Generic;


namespace HelloWorld
{
  class Program
  {
  
  	public static  bool resultsFun(){
       
        int x = 10;
        //Taking care of negative numbers and checking if last digit is 0 only possible case in 0.
        if( x < 0 || ( x != 0 && x % 10 == 0) ){ return false;}
   		
        var rev = 0;
        //We will tacking this the same way as string just with 10 module and division 10 to itterate.
        while( x > rev){
        	rev = rev*10 + x % 10;
        	x = x/10;
        }
        
        //either the numbers would be equal OR there would odd number of digits
   		return (x == rev ) || ( x == rev/10);
    }
    static void Main(string[] args)
    {
             Console.WriteLine(resultsFun());    
    }
  }
}





