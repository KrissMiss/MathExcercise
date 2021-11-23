using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1main : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                print(i);
            }
            else
            {
                continue;
            }
        }
    }
}
