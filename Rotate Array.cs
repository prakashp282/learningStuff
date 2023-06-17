//189. Rotate Array
//Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.


public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        reverseArray(nums,0,nums.Length-1);
        reverseArray(nums,0,k-1);
        reverseArray(nums,k,nums.Length-1);       
    }

    public void reverseArray(int[] nums, int startIndex, int endIndex){
        while(startIndex < endIndex){
           int temp = nums[endIndex];
           nums[endIndex] = nums[startIndex];
           nums[startIndex]= temp;
           endIndex--;
           startIndex++;
        }
    }
}
