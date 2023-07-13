// 49. Group Anagrams : https://leetcode.com/problems/group-anagrams/description
// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

// Example 
// Input: strs = ["eat","tea","tan","ate","nat","bat"]
// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]


//APPROACH : Sort the individual string and use a hashmap with sorted string as key and string as value. Anagrams will have the same key.

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        for(int i=0;i<strs.Length;i++){
            var keyArr = strs[i].ToCharArray(); //to array
            Array.Sort(keyArr);//sort
            var key = new string(keyArr);//back to string

            if(map.ContainsKey(key)) (map[key]).Add(strs[i]);
            else map[key] = new List<string>() {strs[i]};
        }
        IList<IList<string>> list = new List<IList<string>>();
        ((List<IList<string>>)list).AddRange(map.Values);
        return list;
    }
}
