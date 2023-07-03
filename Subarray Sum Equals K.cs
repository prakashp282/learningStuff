//560. Subarray Sum Equals K
//Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
//A subarray is a contiguous non-empty sequence of elements within an array.


//Solution  n^2 solution 
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        for(int i=0;i<nums.Length; i++){
            int sum=0;
            for(int j=i;j<nums.Length;j++){
                //if(sum > k) break; // Only if all elements arepositive
                sum= sum+nums[j];
                if(sum == k) count++;
            }
        }

        return count;
    }
}


// Solution n 
