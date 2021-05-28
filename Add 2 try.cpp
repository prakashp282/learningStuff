//https://leetcode.com/problems/two-sum/
/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/



class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        //sort code 
        vector<int> left;
        vector<int> right;
        int flag=-1;
        for(int i=0;i<nums.length;i++)
            if(nums[i]<target/2){
                left.add(nums[i]);
            }else if(nums[i]>target/2){
                right.add(nums[i]);
            }else{
                //when its equals to target by 2 
                if(flag!=-1){
                    //we got the answer
                    return [flag,i];
                }
                flag=i;
                left.add(nums[i]);
            }
        
        
        }
        
    int findIndex(vector<int>& nums, int target){
        for(int i=0;i<nums.length;i++){
            if(nums[i]==target)
                return(i);
        }
    }
    
    }
};