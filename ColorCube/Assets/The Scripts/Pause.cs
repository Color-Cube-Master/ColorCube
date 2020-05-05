using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
     bool IsPaused = false ; 
     public Sprite Playing;
     public Sprite Paused ;
     public Image PauseI;
     public Sprite NotPressed;
     public Sprite Pressed ;
     public Button PauseB;

    public void PauseGame () {
        //Time svale controls the speed of the game
        if (IsPaused)
        {
         Time.timeScale = 1;
         IsPaused = false;
        }

        else
        {
        Time.timeScale=0;
        IsPaused = true;
        }

    }
    //Change the button sprite 
    public void ChangeButton(){

     if (PauseB.image.sprite == NotPressed)

         PauseB.image.sprite = Pressed;

     else 
         PauseB.image.sprite = NotPressed;
    }

    //Change the pause icon
    public void ChangeIcon(){

     if (PauseI.sprite == Playing)

         PauseI.sprite = Paused;

     else 
         PauseI.sprite = Playing;
    }

}
