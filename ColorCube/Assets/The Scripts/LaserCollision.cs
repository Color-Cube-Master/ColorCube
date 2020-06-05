using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision col) {
     if (col.gameObject.tag == "RedL")
     {
         FindObjectOfType<AudioManager>().Play("Out");
     Destroy(gameObject);
      
      FindObjectOfType<AudioManager>().Stop("Playing");
     SceneManager.LoadScene("You Lose");
     }
    
}
}
