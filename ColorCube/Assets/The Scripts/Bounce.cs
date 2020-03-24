using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bounceit();

    }
    void Bounceit()
    {
        y = transform.position.y;
        if (y <= 0.801f)
            LeanTween.moveY(gameObject, 2.2f, 0.45f);
        if (y == 2.2f)
            LeanTween.moveY(gameObject, 0.800f, 0.45f);

    }
}
