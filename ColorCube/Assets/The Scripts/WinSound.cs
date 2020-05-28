using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{  

    // Start is called before the first frame update
    void Update()
    {
        StartCoroutine(PlaySound(1));

        

    }
    
    
  
    private bool isCoroutineExecuting = false;

    IEnumerator PlaySound(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);
         FindObjectOfType<AudioManager>().Play("Tada");

       
        
    }
}
