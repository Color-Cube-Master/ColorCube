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
      if ( ColTester.P == true ){
         image.fillAmount += 0.2575f * Time.deltaTime;
      }
      else if ( ColTester.P == false ) {
      image.fillAmount -= 0.2575f * Time.deltaTime;}   
    }
}
