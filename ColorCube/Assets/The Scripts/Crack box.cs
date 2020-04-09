using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crackbox : MonoBehaviour
{
   public GameObject DestroyedBox;
    
    void Crack(){
     if (Input.GetKeyDown(KeyCode.D))
      {
        
        Instantiate(DestroyedBox, transform.position, transform.rotation);
    Destroy(gameObject);
      }

                }
}