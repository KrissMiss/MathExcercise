using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class euler1 : MonoBehaviour
{
    int count = 0;
    
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                count += i;
            }
            else
            {
                continue;
            }
        }
        print("Euler 1: " + count);
    }

}
