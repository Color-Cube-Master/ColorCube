using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    private static Image image;
     
  Scene m_Scene;
  string sceneName;
    void Start()
    {
      image = GetComponent<Image> ();
      
         m_Scene = SceneManager.GetActiveScene();
         sceneName = m_Scene.name;
     
    }


    void Update()
    {
      if (sceneName == "SlowMode") 
      {

if ( ColTester2.P == true ){
         image.fillAmount += (0.7872f / LevelSpawner.h) * Time.deltaTime ;
      }
      else if ( ColTester2.P == false ) {
      image.fillAmount -= (0.772f / LevelSpawner.h) * Time.deltaTime ;}   

      } 
      else {
      if ( ColTester2.P == true ){
         image.fillAmount += (1.93f / LevelSpawner.h) * Time.deltaTime ;
      }
      else if ( ColTester2.P == false ) {
      image.fillAmount -= (1.93f / LevelSpawner.h) * Time.deltaTime ;}   
    }}
}
