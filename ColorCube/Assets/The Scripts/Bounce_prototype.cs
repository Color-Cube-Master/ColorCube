using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class Bounce_prototype : MonoBehaviour
{
    float y;
    public Reciever reciever;
    // Start is called before the first frame update
   
     Scene m_Scene;
  string sceneName;
  private void Start()
     {
         m_Scene = SceneManager.GetActiveScene();
         sceneName = m_Scene.name;
     }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bounceit();

    }
    void Bounceit()
    {
       if (sceneName == "SlowMode")
      {y = transform.position.y;
        if (y <= 0.801f)
        {
         
            LeanTween.moveY(gameObject, 2.2f, 0.5f);
            
        }
            
        if (y == 2.2f)
        {
           
            LeanTween.moveY(gameObject, 0.800f, 0.75f);
        }
      }  
      else 
       {y = transform.position.y;
        if (y <= 0.801f)
        {
         
            LeanTween.moveY(gameObject, 2.2f, 0.2f);
            
        }
            
        if (y == 2.2f)
        {
           
            LeanTween.moveY(gameObject, 0.800f, 0.3f);
        }
       }  
    }
}
