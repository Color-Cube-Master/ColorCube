using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciever : MonoBehaviour
{

    public float speed = 0.1f;
    Vector3 starpos;
    Vector3 endpos;
    private float startTime;
    private float journeyLength;

    void Start()
    {
        
    }

    void OnEnable() {
        Sender.ButtonPressedInfo += ButtonPressedListener;
    }
    void OnDisable() {
        Sender.ButtonPressedInfo -= ButtonPressedListener;
    }
    void ButtonPressedListener()
    {
        Vector3 move = new Vector3();
        
        if (Input.GetKey(KeyCode.UpArrow))
            move.z += speed;
        if (Input.GetKey(KeyCode.DownArrow))
            move.z -= speed;
        if (Input.GetKey(KeyCode.RightArrow))
            move.x += speed;
        if (Input.GetKey(KeyCode.LeftArrow))
            move.x -= speed;
        startTime = Time.time;

        // Calculate the journey length.
       
        starpos = transform.position;
        endpos = transform.position + move;
        journeyLength = Vector3.Distance(starpos, endpos);

        //transform.position += move;


    }
    private void Update()
    {
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(starpos, endpos, fractionOfJourney*10);
        
    }


}
