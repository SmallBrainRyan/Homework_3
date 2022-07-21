using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    /* Create a List of numbers that are odd and are divisible by the number 7 between 1 and 144.
     * You should have a list that looks like this 7, 21, 35, 49, 63, 77, 91, 105, 119, 133
     * Declare an array that's half the size of the list and save every other number from the list into the array 
     * You should have a array that looks like this 7, 35, 63, 91, 119
    */
    void Start()
    {
        List<int> nums = new List<int>();
        for (int odd = 1; odd<=144; odd++)
        {
            if (odd % 7 == 0 && odd % 2 != 0)
            {
                nums.Add(odd);
            }
        }
        int[] array = new int[5] { nums[0], nums[2], nums[4], nums[6], nums[8] };
        foreach(int var in array)
        {
            print(var);
        }
    }
}
