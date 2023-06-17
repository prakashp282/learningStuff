//Magic number : 
Give A  a number find Ath magic number 
Given sequence 5, 25,30,125,130,150,155 .....

//Logic for a^1,a^2,a^2+a^1, a^3+a^1,a^3+a^2,a^3+a^2+a^1 ....
give base is 5 ,a=5.....

its a binnary representation of the number.



//Solution 

using System;

public class Test
{
	public static void Main()
	{
      int n = 1, sum = 0, i=1;
      while(n>0){
        sum +=((n&1) * (int)Math.Pow(5.0, i));
        n = n>>1;
        i++;
      }
      Console.WriteLine();
    }
}
		
