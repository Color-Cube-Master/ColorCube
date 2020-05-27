using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
 
 public Button Back;
 public Sprite NotPressed;
 public Sprite Pressed ;
 static int sceneIndex;
 
 
    /*void Awake() {

    			DontDestroyOnLoad(gameObject);
                


    }

     void Start () {
     sceneIndex = SceneManager.GetActiveScene().buildIndex;	
	}*/

    public void ChangeButton(){

     if (Back.image.sprite == NotPressed)

         Back.image.sprite = Pressed;

     else

         Back.image.sprite = NotPressed;
     
    }


    public void GoBack () {
        //Time svale controls the speed of the game
        if (Back.image.sprite = Pressed)
        {
         SceneManager.LoadScene("Timer");
        //SceneManager.LoadScene (sceneIndex - 1);
        }
    }

       
}
