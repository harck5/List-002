using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise008 : MonoBehaviour
{
    public int Points;
    void Start()
    {
        if (Points > 100)
        {
            Debug.Log(message: $"You have more than 100 points");
        }
        if (Points <= 100 && Points > 75)
        {
            Debug.Log(message: "You have more than 75 points, but less than or equal to 100");
        }
        if (Points <= 75 && Points > 50)
        {
            Debug.Log(message: "You have more than 50 points, but less than or equal to 75");
        }
        if (Points <= 50 && Points > 25)
        {
            Debug.Log(message: "You have more than 25 points, but less than or equal to 50");
        }
        if (Points <= 25 && Points > 0)
        {
            Debug.Log(message: "You have less than or equal to 25");
        }
        if (Points == 0)
        {
            Debug.Log(message: "You have 0");
        }
        if (Points <= -1)
        {
            Debug.Log(message: "It is not possible to enter NEGATIVE numbers");
        }
    }
}
