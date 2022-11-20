using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise002 : MonoBehaviour
{
    //Segun el resultado que queda del modulo por 12 es un animal distinto
    //ejemplo la division = (1999 / 12 = 166)(resultado) y el modulo (1999 % 12 = 8)(resto)<<interesa
    public int year;
    void Start()
    {
        if(year % 12 == 0)
        {Debug.Log(message: $"{year} is the year of MONKEY");}
        if (year % 12 == 1)
        {Debug.Log(message: $"{year} is the year of ROOSTER");}
        if (year % 12 == 2)
        {Debug.Log(message: $"{year} is the year of DOG");}
        if (year % 12 == 3)
        {Debug.Log(message: $"{year} is the year of PORK");}
        if (year % 12 == 4)
        {Debug.Log(message: $"{year} is the year of RAT");}
        if (year % 12 == 5)
        {Debug.Log(message: $"{year} is the year of OX");}
        if (year % 12 == 6)
        {Debug.Log(message: $"{year} is the year of TIGER");}
        if (year % 12 == 7)
        {Debug.Log(message: $"{year} is the year of RABBIT");}
        if (year % 12 == 8)
        {Debug.Log(message: $"{year} is the year of DRAGON");}
        if (year % 12 == 9)
        {Debug.Log(message: $"{year} is the year of SNAKE");}
        if (year % 12 == 10)
        {Debug.Log(message: $"{year} is the year of HORSE");}
        if (year % 12 == 11)
        {Debug.Log(message: $"{year} is the year of GOAT");}
    }
}
