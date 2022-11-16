using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise001 : MonoBehaviour
{
    public float x;
    void Start()
    {
        if (x >= 0)
        {
            Debug.Log(message: $"{x} is greater than or equal to 0");
        }
        else
        {
            Debug.Log(message: $"{x} is less than 0");
        }
    }

}
