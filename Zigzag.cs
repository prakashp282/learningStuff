// 6. Zigzag Conversion
// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
// P   A   H   N
// A P L S I I G
// Y   I   R
// And then read line by line: "PAHNAPLSIIGYIR"

//this is going up down pattern and pattern is formed like 1,2,3,4,,n-2,n-1n,n-1,n-2,,3,2,1,2,3,,n-2,n-1,n,n-2,n-1 ...... on repeat


public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows <=1 ) return s;

        string[] arr = new string[numRows];
        bool dir = true; //1 is increasing 0 is decreasing
        int j=0; //Array index to put value in  
        for(int i=0; i<s.Length; i++){
            arr[j] += s[i];
            j = dir ? j+1:j-1; 
            if(j==numRows-1 || j==0) dir = !dir;
        }
        return string.Join("",arr);
    }
}
