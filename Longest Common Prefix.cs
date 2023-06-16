//14. Longest Common Prefix
//Write a function to find the longest common prefix string amongst an array of strings.
//If there is no common prefix, return an empty string "".

//Solution 
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //Array.Sort(strs);
        string prefix = strs[0];
        for(int i = 1; i<strs.Length ; i++){
            for(int j =0; j<prefix.Length; j++){
                if(strs[i].Length > j && strs[i][j] != prefix[j] || strs[i].Length <= j){
                    prefix = j > 0 ? prefix.Substring(0,j) :"";
                }
            }
        }
        return prefix;
    }
}
