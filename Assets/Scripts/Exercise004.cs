using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise004 : MonoBehaviour
{
    //Calculo de area de un triangulo
    //Con restriccion de numeros negativos
    public float Base;
    public float Height;
    
    void Start()
    {
        if (Base > -1 && Height > -1)
        {
            if (Base * Height / 2 > 0)
            {
                Debug.Log(message: $"The area of ​​the triangle with {Base} base and {Height} height is {Base * Height / 2}");
            }
        }
        else
        {
            Debug.Log(message: $"Variable is less than 0, it is not possible to calculate");
        }
    }
}
