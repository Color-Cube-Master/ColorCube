using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FireBallCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col) {
     if (col.gameObject.tag == "FireBall")
     {
     Destroy(gameObject);
     SceneManager.LoadScene("You Lose");
     }
}
}
