// 167. Two Sum II - Input Array Is Sorted

// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 < numbers.length.

// Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

// The tests are generated such that there is exactly one solution. You may not use the same element twice.

// Your solution must use only constant extra space.

//2 pointer solution.

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        // for(int i=0;i<numbers.Length;i++){
        //     int j = i+1;
        //     while(j<numbers.Length  && numbers[i] + numbers[j] <= target){
        //         if(numbers[i] + numbers[j] == target) return new int[]{i+1,j+1};
        //         j++;
        //     }
        // }

        int l=0, r=numbers.Length-1, sum=0;
        while(l<r){
            sum=numbers[l]+numbers[r];
            if(sum < target) l++;
            if(sum > target) r--;
            if(sum == target) return new int[]{l+1,r+1};
        }
                
        return new int[2];

    }
}
