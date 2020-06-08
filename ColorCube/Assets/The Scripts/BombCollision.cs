using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BombCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col) {
     if (col.gameObject.tag == "Player")
     {
      FindObjectOfType<AudioManager>().Play("Boom");
      Destroy(col.gameObject);
      FindObjectOfType<AudioManager>().Stop("Playing");
     SceneManager.LoadScene("You Lose");
     }
}
}
