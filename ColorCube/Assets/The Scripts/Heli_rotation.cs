using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli_rotation : MonoBehaviour
{ public float rotation_speed ; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
{
    transform.Rotate (0,0,-rotation_speed*Time.deltaTime); //rotates (rotation_speed) degrees per second around z axis
}
}
