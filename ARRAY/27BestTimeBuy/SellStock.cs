public class Solution {
    public int MaxProfit(int[] prices) {
        int MinPrice = int.MaxValue;
        int MaxProfit = 0;
        int Profit=0;
        foreach(int i in prices)
        {
            if(i<MinPrice)
                MinPrice=i;
            else
                Profit=i-MinPrice;
                MaxProfit=Math.Max(MaxProfit,Profit);
        }
        return MaxProfit;
    }
}