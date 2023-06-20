//Interview bit : https://www.interviewbit.com/problems/noble-integer/
Given an integer array A, find if an integer p exists in the array such that the number of integers greater than p in the array equals to p.


Problem Constraints
1 <= |A| <= 106
-109 <= Ai <= 109

//Solution :
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine(myFun());
    }
    
    public static int myFun(){
    int[] num = new int[]{3,2,1,3};
        //int[] B =A.ToArray();
        Array.Sort(B);
        //Console.WriteLine(String.Join(',', B));
        for(int i =0;i<B.Length; i++){
        	if(B[i] == B.Length - i -1 && (i+1 < B.Length ?  B[i] != B[i+1] : true) ) return 1;
        }
        return -1;
      }
  }
}
