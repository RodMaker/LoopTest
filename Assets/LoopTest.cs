using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            sum += i * i;
        }
        Debug.Log($"sum = {sum}");

        int numsquares = 1000;
        sum = numsquares * (numsquares + 1) * (2 * numsquares + 1) / 6;
        Debug.Log($"sum from formula = {sum}");

        for (int j = 7; j > 3; j--) Debug.Log($"j = {j}");

        int k = 0;
        for (; ; )
        {
            Debug.Log($"k = {k}");
            k++;
            if (k > 4) break;
        }

        int a, b;
        for (a = 0, b = 4; a < 3; a++, b--) Debug.Log($"a,b = {a} {b}");

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                Debug.Log($"i,j = {i} {j}");
            }

        /*
        int power = 2;
        while (power < 100)
        {
            Debug.Log($"power = {power}");
            power *= 2;
        }
        */

        int power = 2;
        do
        {
            Debug.Log($"power = {power}");
            power *= 2;
        } while (power < 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
