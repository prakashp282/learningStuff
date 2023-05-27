You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps

Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step

 

Constraints:    1 <= n <= 45

Series Found by logic 
1- 1
2- 2
3- 3
4- 5
5- 8
6- 13
....


//Simple soultion using Fabbonaci series 

public class Solution {
    public int ClimbStairs(int n) {
        return fb(n);
    }
    
    public int fb(int n){
        if(n<=2) return n;
        return fb(n-1) + fb(n-2);
    }
} 

BUT this exceeds time. So we do iterative Fabbnaci series 

public class Solution {
    public int ClimbStairs(int n) {
        if(n<=3) return n;
        int cV = 1, pV =0;
        for(int i=0;i<n;i++){
            int temp = pV;
            pV = cV;
            cV= pV + temp;
        }
        return cV;
    }
}
