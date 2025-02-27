using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    /*
     * Using a loop go through the disorder array and print out true or false if the numbers are in rising order
     * It should be false, as 2 is smaller than 5. In order would be 0,2,5.
    */
    void Start()
    {
        int[] disorder = new int[3]{0,5,2};
        bool isInOrder;

        for(int count = 1; count<2; count++)
        {
            isInOrder = disorder[count] < disorder[count+1];
            print("2 -> " + isInOrder);
        }
    }
}
