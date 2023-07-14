//given string check palindrom


using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string A = "aabbcce";
      Console.WriteLine(func(A));      
    }
    
    static int func(string A){
    	char[] input = A.ToCharArray();
      
      int[] arr = new int[26];
      for(int i=0;i<input.Length;i++){
      	int index = input[i]-'a';
      	arr[index] += 1;  	
      }
      
      bool count = false;
      for(int i=0;i<26;i++){
        if(arr[i] %2 != 0) {
          if(!count && input.Length % 2 != 0) {
          // handling ODD  order palindrome 
            count =true;
            continue;
          }
          return 0;   
        }
      }
      
      return 1;
      
    }
  }
}


// find first repeating character

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string A = "cg";
      Console.WriteLine(func(A));      
    }
    
    static char func(string A){
      char[] input = A.ToCharArray();
      
      int[] arr = new int[26];
      for(int i=0;i<input.Length;i++){
      	int index = input[i]-'a';
      	arr[index] += 1;  
        if(arr[index] >= 2) return  input[i];
      }
      
      return ' ';
 
    }
  }
}
