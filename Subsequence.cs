// 392. Is Subsequence : https://leetcode.com/problems/is-subsequence/description/
// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) return true;
        //int ni=0;
        for(int i=0,j=0;i<t.Length;i++){
            if(s[j] == t[i]){
                //if(j==0) ni=i+1;
                j++;
                if(j == s.Length) return true;
            }
        }

        return false;
    }
}
