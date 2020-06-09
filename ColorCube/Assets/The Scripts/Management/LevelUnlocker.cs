using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelUnlocker : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] Levels;
        void Start()

    {
         Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if(sceneName=="BetaSelection"){
       for(int i=0;i<Levels.Length;i++)
       {
if(i>LevelSpawner.B)
{
    Levels[i].interactable = false;
}
}
       } 
        if(sceneName=="FireBallChallenge"){
       for(int i=0;i<Levels.Length;i++)
       {
if(i>LevelSpawner.FI)
{
    Levels[i].interactable = false;
}
}
       } 
        if(sceneName=="LaserChallenge"){
       for(int i=0;i<Levels.Length;i++)
       {
if(i>LevelSpawner.L)
{
    Levels[i].interactable = false;
}
}
       } 
        if(sceneName=="SlowMoChallenge"){
       for(int i=0;i<Levels.Length;i++)
       {
if(i>LevelSpawner.S)
{
    Levels[i].interactable = false;
}
}
       } 
        if(sceneName=="TimerChallenge"){
       for(int i=0;i<Levels.Length;i++)
       {
if(i>LevelSpawner.T)
{
    Levels[i].interactable = false;
}
}
       } 
    }

    // Update is called once per frame
    void Update()
    {
        

       }  
    
}
