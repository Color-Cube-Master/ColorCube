using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack_box : MonoBehaviour
{ public GameObject Cracked_box;
     
      void OnMouseDown() {
        
        Instantiate(Cracked_box, transform.position, transform.rotation);
        Destroy(gameObject);
                         }
               
}



