using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GameManagerS : MonoBehaviour
{
    [HideInInspector]
    public int CountDownState = 0;
    

    void Update()
    {

        InvokeRepeating("PlaySound", 0.7f, 1f);
    }
    void PlaySound()
    {
        
        if(CountDownState==0)
        {
            FindObjectOfType<AudioManager>().Play("Three");
            

        }
        if (CountDownState == 1)
        {
            FindObjectOfType<AudioManager>().Play("Two");
            

        }
        if (CountDownState == 2)
        {
            FindObjectOfType<AudioManager>().Play("One");
            

        }
        if (CountDownState == 3)
        {
            FindObjectOfType<AudioManager>().Play("Let's go");


        }
        if (CountDownState == 4 )
        {
            SceneManager.LoadScene("Prototype Level Complicated");
        }
    }
}
