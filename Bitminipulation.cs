//Bitminipulation


//Solution

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 5,count = 0;
      while(n>0){
      if(((n&1)==1))count++;
      n = n>>1;
      }
      
      Console.WriteLine(count);
    }
  }
}
