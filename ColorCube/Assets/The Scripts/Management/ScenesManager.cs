using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
 public Button Retry;
 public Button Next;
 public Sprite NotPressed;
 public Sprite Pressed ;
 
 //Old method
 /*Application.LoadLevel(ColTester2.sceneIndex);
        public static int sceneIndex;  
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(DestroyByBoundary.sceneIndex); */
 
    void Awake() {

    			DontDestroyOnLoad(gameObject);

                 }

    

    public void ChangeButtonNext(){

     if (Next.image.sprite == NotPressed)

         Next.image.sprite = Pressed;

     else 

         Next.image.sprite = NotPressed;
     
    }

    public void ChangeButtonRetry(){

     if (Retry.image.sprite == NotPressed)

         Retry.image.sprite = Pressed;

     else

         Retry.image.sprite = NotPressed;
     
    }


    public void GoNext (string sceneName) {
       
        if (Next.image.sprite = Pressed)
        {
        //SceneManager.LoadScene("Timer");
        //SceneManager.LoadScene (sceneIndex - 1);
        if (LevelSpawner.k + 1 <  LevelSpawner.f)
        LevelSpawner.k ++;
        else
        LevelSpawner.k =0;
        SceneManager.LoadScene(LevelSpawner.sceneName);
        
        }
    }


    public void GoBack (string sceneName) {
       
        if (Retry.image.sprite = Pressed)
            
             SceneManager.LoadScene(LevelSpawner.sceneName);        
    }

      
}
