using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public delegate void ButtonPressed();
    public static event ButtonPressed ButtonPressedInfo;

    void Update()
    {
        if (Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
        {
            ExEvent();
        }
    }
    void ExEvent()
    {
        
            if (ButtonPressedInfo!= null)
            {
                ButtonPressedInfo();
            }
       

    }
}
