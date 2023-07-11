// 11. Container With Most Water

// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

// Find two lines that together with the x-axis form a container, such that the container contains the most water.

// Return the maximum amount of water a container can store.

// Notice that you may not slant the container.


public class Solution {
    public int MaxArea(int[] height) {
        int max =0, l=0, r=height.Length-1;
        while(l<r){
            int product = (r-l)* (height[l] <= height[r] ? height[l] : height[r]);
            if(product > max) max= product;
            if(height[l] == height[r]) { l++; r--;}
            else if(height[l] > height[r]) r--;
            else l++;
        }
        return max;
    }

}
