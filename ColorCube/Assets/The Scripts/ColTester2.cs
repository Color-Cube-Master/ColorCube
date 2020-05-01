using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColTester2 : MonoBehaviour
{
    
    public Material Green;
    public Material Red;
    int Counter;
    int HitsMAX;
    public static int GameOver=0;
    public static bool P;
    
    


    Renderer rend;
    void Start ()
    {
        rend = GetComponent<Renderer>();
        HitsMAX = UnityEngine.Random.Range(1,9);
        rend.material = Red;
        
        //show the number of hits needed for the cube to get destroyed
        //Debug.Log(HitsMAX);
    }
    // This function is for destroying the cube 
    void Destroy()
    {
        if (Counter == HitsMAX-1)
        { Destroy(gameObject); }
    }
   
    // this function is for the collision and the color changing 
    
            

    void OnCollisionEnter(Collision col )
    {   
        if ((col.gameObject.tag == "Player") && (Counter % 2 != 0))
        //if green
        {

            //Destroy();

           // FindObjectOfType<AudioManager>().Play("Bounce");

            rend.material = Red;
            Counter++;
            GameOver--;
            P = false ;
            Debug.Log(GameOver);
           
        }

        else

        //else if red
        {
            //Destroy();

            {
                // FindObjectOfType<AudioManager>().Play("Bounce");
                rend.material = Green;
                Counter++;
                GameOver++;
                P = true ;
                
                Debug.Log(GameOver);
                if(GameOver==LevelSpawner.h)
            {
                    
                    SceneManager.LoadScene("You Win");
                    

                    //UnityEditor.EditorApplication.isPlaying = false;}
 
            }


            }
        }
     
        
    }
}
/*update*/