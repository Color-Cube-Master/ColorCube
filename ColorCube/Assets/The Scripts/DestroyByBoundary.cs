using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyByBoundary : MonoBehaviour
{
   void OnTriggerExit(Collider other) {
       Destroy(other.gameObject);
   SceneManager.LoadScene("You Lose");

    }
}
