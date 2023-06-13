
Find positivy number in lenth in sequence.
//Solution
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine(func());
    }
    
    
    static int func(){
    
    int[] A = new int[]{2,-1,4,5,-99,99,99,9,9,9,9,9,0,9,-1,0,0,0};
    
        int[] len = new int[A.Length];
        for(int i = A.Length  -1 ; i>=0 ; i--){
        	if(i == A.Length  -1 ){
             len[i] = A[i] > 0 ? 1 : 0;  
            }
            else {
             len[i] =  A[i] >= 0 ? len[i+1] + 1 : 0;	
            }
        }
        
        int max = -1;
        for(int i= 0; i< len.Length ; i++){
        	if(len[i] == len.Length  ) return len[i];
            if(len[i] > max ) max = len[i];
        }
        
        return max;}
    
  }
}
