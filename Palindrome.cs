
using System;

class Palindrome
{
    public static bool IsPalindrome(int number)
	{

		int temp;
		int sum = 0;

		temp = number;

		while ( number > 0 )
		{
			sum = sum*10 + number % 10;

			number = number / 10;

		}

        return temp == sum;

     }

     public static bool recurisvePalindrome (int number)
     {
     	int sum = 0;
     	if (number < 100)
     	{
     		return IsPalindrome(number);
     	}

     	else 
     	{
			while (number > 0) {
			    int lastTwoDigits = number % 100;
			    
			    sum += lastTwoDigits;
			    
			    number /= 100;
			}

			return recurisvePalindrome(number);
     	}
     }

  }
