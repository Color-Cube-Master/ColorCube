using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    //Table of Maps(Matrixs)
    public Map[] level;
    public float spawnSpeed = 0;

void Start() {
    StartCoroutine(SpawnLevel());
    
}



IEnumerator SpawnLevel(){



Map grid = level[level.Length-1];


 int cordx =grid.xprefabs[0].cordx;
 int cordY =grid.xprefabs[0].cordY;
 int cordx1 =grid.xprefabs[1].cordx;
 int cordY1 =grid.xprefabs[1].cordY;
 

    



     for (int i = 0; i < grid.x ; i++)
         {yield return new WaitForSeconds(spawnSpeed);
             for (int j = 0; j < grid.Y; j++)
             {yield return new WaitForSeconds(spawnSpeed);
                 /*Instantiate(Resources.Load("Cube", typeof(GameObject))) as GameObject;*/
                  GameObject sandouk = Instantiate(grid.prefab) as GameObject;
                 sandouk.transform.position = new Vector3(j * 1f  , i * -1f, 0);
                 
                 {
                    if(sandouk.transform.position.x==cordx & sandouk.transform.position.y==cordY)
                         {Debug.Log("gotcha");
                            Destroy(sandouk);}
                             if(sandouk.transform.position.x==cordx1 & sandouk.transform.position.y==cordY1)
                         {Debug.Log("gotcha2");
                            Destroy(sandouk);}
                           
                 }
            }
                     
         }
        
        } 
   
    
}
         


 






