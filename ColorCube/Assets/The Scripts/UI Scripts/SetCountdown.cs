using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;


public class SetCountdown : MonoBehaviour
{
    private GameManagerS GMS;
    public void ChangeCountdown()
    {
        
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerS>();
        GMS.CountDownState++;  


    }
}
