using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise004 : MonoBehaviour
{
    public float Base;
    public float Height;
    
    void Start()
    {

        if (Base * Height / 2 > 0)
        {
            Debug.Log(message $"Result is less than 0");
            Debug.Log(message $"The area of ​​the triangle with {Base} base and {Height} height is {Base * Height / 2}";
        }
    }
}
