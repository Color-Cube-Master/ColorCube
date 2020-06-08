using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crack_box : MonoBehaviour
{ public GameObject Cracked_box;
     
     IEnumerator WaitAndLose()
    {
      yield return new WaitForSeconds(5);
      FindObjectOfType<AudioManager>().Stop("Playing");
      SceneManager.LoadScene("You Lose");   
       }
      

   void OnCollisionEnter(Collision col) {
     if (col.gameObject.tag == "Player")
     {
      Destroy(gameObject);
      Instantiate(Cracked_box, transform.position, transform.rotation);
      StartCoroutine(WaitAndLose());
      FindObjectOfType<AudioManager>().Play("Wood");
      Destroy(col.gameObject);
     
     }


     /*void OnMouseDown() {
        
        Instantiate(Cracked_box, transform.position, transform.rotation);
        Destroy(gameObject);
      }*/
                         
               
}
}



