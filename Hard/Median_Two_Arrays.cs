using System;
using System.Linq;
public class Median_Two_Arrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] numsMerged = nums1.Concat(nums2).ToArray();
        double median = 0.0;

        int temp = 0;
        for (int i = 0; i <= numsMerged.Length - 1; i++) // Bubble sort performed on merged array
        {
            for (int j = i + 1; j <= numsMerged.Length - 1; j++)
            {
                if (numsMerged[i] > numsMerged[j])
                {
                    temp = numsMerged[i];
                    numsMerged[i] = numsMerged[j];
                    numsMerged[j] = temp;
                }
            }

        }

        if ((numsMerged.Length % 2) == 0) // Array of even length
        {
            int x = numsMerged[numsMerged.Length / 2];
            int y = numsMerged[(numsMerged.Length / 2) - 1];

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());

            median = (double)(x + y) / 2; // Midpoint of central elements
        }

        else // Array of odd length
        {
            median = numsMerged[numsMerged.Length / 2]; // Central element
        }

        return median;

    }
}




