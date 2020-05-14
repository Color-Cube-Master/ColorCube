using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reciever : MonoBehaviour
{

    public float speed = 1f;
    Vector3 starpos;
    Vector3 endpos;
    private float startTime;
    private float journeyLength;
    private float fractionOfJourney;
    public float time;
     Scene m_Scene;
  string sceneName;
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
         sceneName = m_Scene.name;
    }

    void OnEnable() {
        Sender.ButtonPressedInfo += ButtonPressedListener;
    }
    void OnDisable() {
        Sender.ButtonPressedInfo -= ButtonPressedListener;
    }
    void ButtonPressedListener()
    {
        if (canmoved==true)
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
            
            StartCoroutine(WaitJump());
        }
       

        //transform.position += move;
      

    }
  public  bool canmoved ;
    public IEnumerator WaitJump()
    {
        canmoved = false;
        if (sceneName == "SlowMode"){
            yield return new WaitForSeconds(1.1f);
        }
        else{
        yield return new WaitForSeconds(time);}
        canmoved = true;
    }
    private void Update()
    {
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        if(journeyLength!=0)
        {
         fractionOfJourney = distCovered / journeyLength;
        }

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(starpos, endpos, fractionOfJourney*10);
        
    }


}
