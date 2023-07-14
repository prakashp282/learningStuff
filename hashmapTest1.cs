//given string check palindrom


using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string A = "acebb";
      Console.WriteLine(func(A));      
    }
    
    static int func(string A){
    	char[] input = A.ToCharArray();
      
      int[] arr = new int[26];
      for(int i=0;i<input.Length;i++){
      	int index = input[i]-'a';
      	arr[index] += 1;  	
      }
      
      for(int i=0;i<26;i++){
      	if(arr[i] %2 != 0) return 0;
      }
      
      return 1;
      
    }
  }
}
