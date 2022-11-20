using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise007 : MonoBehaviour
{
    //string con varios valores y operaciones normales
    public string operation = "sum" + "subtraction" + "product" + "division";
    public float x;
    public float y;
    void Start()
    {
        if (operation == "sum")
        {
            Debug.Log(message: $"{x} + {y} = {x + y}");
        }
        if (operation == "subtraction")
        {
            Debug.Log(message: $"{x} - {y} = {x - y}");
        }
        if (operation == "product")
        {
            Debug.Log(message: $"{x} * {y} = {x * y}");
        }
        if (operation == "division")
        {
            Debug.Log(message: $"{x} / {y} = {x / y}");
        }
    }
}
