using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2main : MonoBehaviour
{
    int[] multitable = new int[10];
    int num;
    void Start()
    {
        for (int i = 0; i < multitable.Length; i++)
        {
            multitable[i] = i + 1;
            for (int j = 1; j < 11; j++)
            {
                print(multitable[i] * j);
            }

        }
    }
}
