using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise010 : MonoBehaviour
{
    public int year;
    void Start()
        //Si año es divisible por 4 y no divisible por 100 pero divisible por 400 es Bisiesto
    {
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Debug.Log(message: $"Year {year} is a leap year");
        }
        else
        {
            Debug.Log(message: $"Year {year} is NOT a leap year");
        }
    }
}
