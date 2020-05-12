using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserCollision : MonoBehaviour
{
   
    void OnCollisionEnter(Collision col) {
     if (col.gameObject.tag == "RedL")
     {
     Destroy(gameObject);
     SceneManager.LoadScene("You Lose");
     }
    
}
}
