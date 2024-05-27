using System;
using System.Security.Cryptography;

class Random
{
    static int GetRandomNumberWithinRange(int minValue, int maxValue)
    {
        if (minValue >= maxValue)
            throw new ArgumentOutOfRangeException(nameof(minValue), "minValue must be less than maxValue");

        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            byte[] fourBytes = new byte[4];
            rng.GetBytes(fourBytes);
            int scale = BitConverter.ToInt32(fourBytes, 0);

            scale = Math.Abs(scale);

            return minValue + (scale % (maxValue - minValue));
        }
    }
}
