using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColTester : MonoBehaviour
{
    public Material Green;
    public Material Red;
    int Counter;
    int HitsMAX;
    int RG=5;


    Renderer rend;
    void Start ()
    {
        rend = GetComponent<Renderer>();
        HitsMAX = UnityEngine.Random.Range(1,9);
        //show the number of hits needed for the cube to get destroyed
        //Debug.Log(HitsMAX);
    }
    // This function is for destroying the cube 
    void Destroy()
    {
        if (Counter == HitsMAX-1)
        { Destroy(gameObject); }
    }
    // this function is for the collision and the color changing 
    void OnCollisionEnter(Collision col)
    {   
        if ((col.gameObject.tag == "Player") && (Counter % 2 == 0))
        {

            //Destroy();



            rend.material = Red;
            Counter++;
            RG--;

        }
        else
        {
            //Destroy();

            {
                rend.material = Green;
                Counter++;
                RG++;
            }


        }
    }
}
