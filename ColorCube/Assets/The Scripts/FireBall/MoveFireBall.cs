using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.AI;


public class MoveFireBall : MonoBehaviour
{
     public float movSpeed = 10f;
    public float RotSpeed = 10f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;


	

    //Finite state machine
    void Update()
    {
       

        if (isWandering == false)
        {
              StartCoroutine("Wander");
        }
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * RotSpeed);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -RotSpeed);
        }
        if (isWalking == true )
        {
            transform.position += transform.forward * movSpeed * Time.deltaTime;
        }
         /*while (isWalking == true & transform.position.z <= 7  )
        {
            transform.Rotate(transform.up * 90 *  Time.deltaTime * -RotSpeed);
            transform.position += transform.forward * movSpeed * Time.deltaTime;

        }*/
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 2); //the rotation time
        int rotateWait = Random.Range(1, 2); //the time between rotations

        int rotLorR = Random.Range(0, 3); //rotate left or right

        int walkWait = Random.Range(1, 2); //the time between walks
        int walkTime = Random.Range(1, 2); //the walk time 

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;

        yield return new WaitForSeconds(walkTime);
        
        //isWalking = false;
        

        yield return new WaitForSeconds(rotateWait);

        if (rotLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }

        if (rotLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }

        isWandering = false;

    }
}

