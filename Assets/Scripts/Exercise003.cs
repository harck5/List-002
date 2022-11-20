using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise003 : MonoBehaviour
{
    //Un modulo para saber si es divisible por 5
    public int x;
    void Start()
    {
        if (x % 5 == 0)
        {
            Debug.Log(message: $"{x} is divisible by 5");
        }
        else
        {
            Debug.Log(message: $"{x} not is divisible by 5");
        }
    }

}
