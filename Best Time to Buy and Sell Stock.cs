//122. Best Time to Buy and Sell Stock II
//You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
//On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.
//Find and return the maximum profit you can achieve.

//Solution
public class Solution {
    public int MaxProfit(int[] prices) {
        int sum = 0, l=0, r=1, maxProfit = 0;
        while(r < prices.Length){
            if(prices[r] < prices[r-1]){
                sum += prices[r-1]-prices[l] > maxProfit ? prices[r-1]-prices[l] : maxProfit;
                maxProfit=0;
                l=r;
            } else if(prices[r]-prices[l] > maxProfit){
                maxProfit = prices[r]-prices[l];
            }
            r++;
        }

        return sum+maxProfit;
    }
}
