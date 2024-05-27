using System;

public class Knapsack
{
    public static int MaximumValue(int maximumWeight, (int weight, int value)[] items)
    {
        int numberOfItems = items.Length;
        int[,] dp = new int[numberOfItems + 1, maximumWeight + 1];

        for (int i = 1; i <= numberOfItems; i++)
        {
            int itemWeight = items[i - 1].weight;
            int itemValue = items[i - 1].value;

            for (int w = 0; w <= maximumWeight; w++)
            {
                if (itemWeight <= w)
                {
                    dp[i, w] = Math.Max(dp[i - 1, w], dp[i - 1, w - itemWeight] + itemValue);
                }
                else
                {
                    dp[i, w] = dp[i - 1, w];
                }
            }
        }

        return dp[numberOfItems, maximumWeight];
    }
}
