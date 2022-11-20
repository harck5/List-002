using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise009 : MonoBehaviour
{
    //bool clasico con else
    public bool VegetarianOption;
    void Start()
    {
        if (VegetarianOption = false)
        {
            Debug.Log(message: "Non-vegetarian option coming soon");
        }
        else
        {
            Debug.Log(message: "Vegetarian option coming soon");
        }
    }
}
