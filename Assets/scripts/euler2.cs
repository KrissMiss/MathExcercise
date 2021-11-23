using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class euler2 : MonoBehaviour
{
    int[] fibo = new int[45];
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < fibo.Length; i++)
        {
            fibo[i] = i + 1; 
            if (i >= 2)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            if (fibo[i] % 2 == 0 && fibo[i] <= 4000000)
            {
                count += fibo[i];
            }
            else
            {
                continue;
            }
        }
        print("Euler 2 (The sum of all even Fibbonacci numbers not exceeding 4,000,000): " + count);
    }
}
