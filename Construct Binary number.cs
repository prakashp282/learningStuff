//Construct Binary number.
//Where A is the count of 1's and B is count of zeros 
//solution 
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
     int A=0,B=1,sum=0;
     int n= A+B;
     while(n-->0 && A-->0){
     	sum +=  Convert.ToInt32(Math.Pow(2,n));
     }
     
      Console.WriteLine(sum);    
    }
  }
}
