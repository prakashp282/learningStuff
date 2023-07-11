// 15. 3Sum : https://leetcode.com/problems/3sum/description/
// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

// Notice that the solution set must not contain duplicate triplets.


public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        int i=0;
        while(i<nums.Length-2){
            int target = -nums[i];

            int l=i+1, r= nums.Length-1;
            while(l<r){
                int sum = nums[l] + nums[r];
                if(sum == target) { 
                    result.Add(new List<int>(){nums[i],nums[l],nums[r]});
                    int x=r;
                    do{r--;}while(r>l && nums[x] == nums[r]);
                    x=l;
                    do{l++;}while(l<r && nums[x] == nums[l]);   
                } 
                else if(sum > target) r--;
                else l++;
            }
            int y=i;
            do{i++;}while(i<nums.Length-2 && nums[y] == nums[i]);
        }
        return result;
    }
}
