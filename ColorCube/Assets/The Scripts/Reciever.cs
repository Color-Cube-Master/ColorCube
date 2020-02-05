using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reciever : MonoBehaviour
{

    public float speed = 0.1f;

    

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
        

        transform.position += move;

    }


}
