Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

// Solution 
public class Solution {
    public int MySqrt(int x) {
        if(x <= 0) return 0;
        int i = 1;
        for(i = 1 ; i <= x/i ; i++){
            if( i * i == x ){
                return i;
            } 
        }
        return i-1;
    }
}

////faster Solution 
public class Solution {
    public int MySqrt(int x) {
        int r = x ;
        while(r*r > x)
            r = (r + x/r)/2;

        return (int)r | 0;
    }
}
