using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise005 : MonoBehaviour
{
    //si es mayor o menor basico con else
    public int age;
    void Start()
    {
        if (age > 17)
        {
            Debug.Log(message: $"Hello, you are {age} years old, so you are of legal age");
        }
        else
        {
            Debug.Log(message: $"Hello, you are {age} years old, so you are NOT of legal age");
        }
    }
}

