using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise006 : MonoBehaviour
{
    //Distancia a recorrer
    public float Total;
    public float Travel;

    void Start()
    {
        if (Total == Travel)
        {
            Debug.Log(message: "Congratulations! You have completed the total distance.");
        }
        else
        {
            Debug.Log(message: $"Oh… You still have {Total - Travel} meters left to complete the total distance.");
        }
    }
}
