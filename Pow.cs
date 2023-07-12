// 50. Pow(x, n)
// Implement pow(x, n), which calculates x raised to the power n (i.e., xn).


public class Solution {
    public double MyPow(double x, int n) {
        if(n==0) return 1;
            
        //Half power with recursion
        double hp = MyPow(x, n/2);
        //Handling negative cases
        if(n<0) {
            x = 1/x;
        }

        //odd even case
        return n%2 == 0 ? hp*hp : x*hp*hp;
    }
}
