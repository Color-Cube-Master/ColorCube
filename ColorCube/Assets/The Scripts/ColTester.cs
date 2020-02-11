using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTester : MonoBehaviour
{
    public Material Green;
    public Material Red;
    int Counter;
    Renderer rend;
    void Start ()
    {
        rend = GetComponent<Renderer>();
    }
    void OnCollisionEnter(Collision col)
    {
        if ((col.gameObject.tag == "Player") && (Counter%2==0))
        {
            rend.material = Red;
            Counter++;
        }
        else
        {
            rend.material = Green;
            Counter++;
        }
        
    }
}
