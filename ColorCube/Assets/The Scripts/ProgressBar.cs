using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private static Image image;
     
  
    void Start()
    {
      image = GetComponent<Image> ();
    }


    void Update()
    {
      if ( ColTester2.P == true ){
         image.fillAmount += (1.1f / LevelSpawner.h) * Time.deltaTime ;
      }
      else if ( ColTester2.P == false ) {
      image.fillAmount -= (1.1f / LevelSpawner.h) * Time.deltaTime ;}   
    }
}
