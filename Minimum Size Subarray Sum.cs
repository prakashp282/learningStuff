209. Minimum Size Subarray Sum : https://leetcode.com/problems/minimum-size-subarray-sum/?envType=study-plan-v2&envId=top-interview-150
Given an array of positive integers nums and a positive integer target, return the minimal length of a
subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

//Approach : sliding window.
//Another approach : prefix sum then used binary search tree format.

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int i=0, j=0, n=nums.Length, len = n+1;
        for(;j<n;j++){
            target -= nums[j];
            while(target <= 0){
                len = Math.Min(len,(j-i+1));
                target += nums[i++];
            }
        }

        return len % (n+1);
    }
}
