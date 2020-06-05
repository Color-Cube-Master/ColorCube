using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyByBoundary : MonoBehaviour
{    


   void OnTriggerExit(Collider other) {
    FindObjectOfType<AudioManager>().Play("Out");
    Destroy(other.gameObject);
    FindObjectOfType<AudioManager>().Stop("Playing");
   SceneManager.LoadScene("You Lose");

    }
}
