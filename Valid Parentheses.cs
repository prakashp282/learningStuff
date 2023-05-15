Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.

 

Example 1:

Input: s = "()"
Output: true

Example 2:

Input: s = "()[]{}"
Output: true

Example 3:

Input: s = "(]"
Output: false

 

Constraints:

    1 <= s.length <= 104
    s consists of parentheses only '()[]{}'.


Solution :

using System;
using System.Collections.Generic;


namespace HelloWorld
{
  class Program
  {
  
  	public static  bool resultsFun(){
    string s = "{}}";
    
        if(s.Length % 2 != 0){
            return false;
        }
        var myStack = new Stack<char>();
        var myDic = new Dictionary<char, char>(){{'(',')'},{'{','}'},{'[',']'}};
        

        //Lets itterate on the string
        for(int i=0;i< s.Length; i++){
			
          if(s[i] == ')' || s[i] == ']' || s[i] == '}'){
          	if(i == 0 || myStack.Count == 0 || s[i] != myStack.Pop()){
            	return false;
            }
          }	else{
          //if its not a closing tag keep pushing.
              myStack.Push(myDic[s[i]]);
           }
        }
		
        if(myStack.Count !=0 ){
        	return false;
        }
        
        return true;
    }
    static void Main(string[] args)
    {
             Console.WriteLine(resultsFun());    
    }
  }
}



