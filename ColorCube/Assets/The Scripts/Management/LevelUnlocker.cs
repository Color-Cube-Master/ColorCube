using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] Levels;
        void Start()
    {
       for(int i=0;i<Levels.Length;i++)
       {
if(i>LevelSpawner.B)
{
    Levels[i].interactable = false;
}

       } 
    }

    // Update is called once per frame
    void Update()
    {
        

       }  
    
}
