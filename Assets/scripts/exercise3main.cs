using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exercise3main : MonoBehaviour
{
    [SerializeField] InputField input;
    [SerializeField] Text output;
    int n = 0;

    public void VvodNum ()
    {
        n = System.Convert.ToInt32(input.text);
        int result = 1;
        for (int i = 2; i < n + 1; i++)
        {
            result *= i;
        }
        if (n > 0)
        {
            output.text = System.Convert.ToString($"Факториал {n}: {result}");
        }
        else if (n == 0)
        {
            output.text = System.Convert.ToString($"Факториал {n}: 1");
        }
        else
        {
            output.text = "Ошибка! \nНельзя вычислить факториал от отрицательного числа!";
        }
    }
}
