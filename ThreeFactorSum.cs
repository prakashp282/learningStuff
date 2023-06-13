//THree factor sum tofig out if it has 3 or more factors and get sum of range of the Array.

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine(  String.Join(",", func()));
    }
    
    
    static int[] func(){
    
    int[] A = new int[]{1,8,12,15,5};
    
    int[][] range = new int[][]{
    	new int[]{1,3},
        new int[]{2,5},
        new int[]{4,4}
        };
    
    
        int[] TF = new int[A.Length]; //TF- three factor
        
        
        for(int i =0 ; i < A.Length ; i++){
         	bool isTF = false;
        	for(int j=2;j*j <= A[i]; j++){
            	if(A[i]% j == 0) {
                 isTF = true;
                 break;
                }
            }
            
            TF[i] = (i == 0 ? 0 : TF[i-1]) + (isTF? 1 : 0) ;
        }
        
        int[] ans = new int[range.Length];
        
        for(int i= 0; i< range.Length ; i++){
                  
        	ans[i] = (range[i][1] >= A.Length ? TF[A.Length -1] : (range[i][1] == 0 ? 0 : TF[range[i][1]- 1]))
                   - (range[i][0] >= A.Length ? TF[A.Length -1] : (range[i][0] == 1 ? 0 : TF[range[i][0]- 2]));
        }
        
        return ans;
        
        }
    
  }
}
