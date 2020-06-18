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



  //Mobile variables---------------------------------------------------------------------------------------------------------------------
  private Vector3 startTouchPosition, endTouchPosition;
    private Vector3 startRocketPosition, endRocketPosition;
    private float MoveTime;
    private float MoveDuration = 0.1f;


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


        //Mobile Controls--------------------------------------------------------------------------------------------------------------
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -1f)
                StartCoroutine(Move("left"));

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < 1f)
                StartCoroutine(Move("right"));

            if ((endTouchPosition.z < startTouchPosition.z) && transform.position.z > -1f)
                StartCoroutine(Move("Down"));

            if ((endTouchPosition.z > startTouchPosition.z) && transform.position.z < 1f)
                StartCoroutine(Move("Up"));
        }
        
    }

//Mobile move sets---------------------------------------------------------------------------------------------------------
private IEnumerator Move(string WhereToMove)
    {
        switch (WhereToMove)
        {
            case "left":
                MoveTime = 0f;
                startRocketPosition = transform.position;
                endRocketPosition = new Vector3
                    (startRocketPosition.x - 1f, transform.position.y, transform.position.z);

                while (MoveTime < MoveDuration)
                {
                    MoveTime += Time.deltaTime;
                    transform.position = Vector3.Lerp
                        (startRocketPosition, endRocketPosition, MoveTime / MoveDuration);
                    yield return null;
                }
                break;

            case "right":
                MoveTime = 0f;
                startRocketPosition = transform.position;
                endRocketPosition = new Vector3
                    (startRocketPosition.x + 1f, transform.position.y, transform.position.z);

                while (MoveTime < MoveDuration)
                {
                    MoveTime += Time.deltaTime;
                    transform.position = Vector3.Lerp
                        (startRocketPosition, endRocketPosition, MoveTime / MoveDuration);
                    yield return null;
                }
                break;
                 case "Down":
                MoveTime = 0f;
                startRocketPosition = transform.position;
                endRocketPosition = new Vector3
                    (startRocketPosition.x , transform.position.y, transform.position.z- 1f);

                while (MoveTime < MoveDuration)
                {
                    MoveTime += Time.deltaTime;
                    transform.position = Vector3.Lerp
                        (startRocketPosition, endRocketPosition, MoveTime / MoveDuration);
                    yield return null;
                }
                break;

            case "Up":
                MoveTime = 0f;
                startRocketPosition = transform.position;
                endRocketPosition = new Vector3
                    (startRocketPosition.x , transform.position.y, transform.position.z+ 1f);

                while (MoveTime < MoveDuration)
                {
                    MoveTime += Time.deltaTime;
                    transform.position = Vector3.Lerp
                        (startRocketPosition, endRocketPosition, MoveTime / MoveDuration);
                    yield return null;
                }
                break;
        }

    }
}
