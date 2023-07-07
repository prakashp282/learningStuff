// 274. H-Index : https://leetcode.com/problems/h-index/description/
// Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.
// According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.

// Example 1:
// Input: citations = [3,0,6,1,5]
// Output: 3
// Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had received 3, 0, 6, 1, 5 citations respectively.
// Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.

// Example 2:
// Input: citations = [1,3,1]
// Output: 1

//Solutions
//Approach : if citations[i]>len-i, elements after citations[i] would also be all at least len-i, it fits the statment that "len-i of his/her N papers have at lesast len-i", citations[i]==len-i and citations[i]>len-i are both ok. so we use citations[i]>=len-i.
public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        int len =citations.Length;
        for(int i=0;i<len;i++){
            if(citations[i]>=len-i) return len-i;
        }
        return 0;
    }
}
