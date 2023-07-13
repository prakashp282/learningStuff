// 242. Valid Anagram : https://leetcode.com/problems/valid-anagram/
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

// Input: s = "anagram", t = "nagaram"
// Output: true
 
// SOlution

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] cha = new int[26];
        for(int i=0;i<s.Length;i++){
            int x = s[i]-'a';
            int y = t[i]-'a';
            cha[x]++;
            cha[y]--;
        }

        for(int i=0;i<26;i++){
            if(cha[i] != 0) return false;
        }

        return true;
    }
}
