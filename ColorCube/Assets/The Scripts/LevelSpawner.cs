using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSpawner : MonoBehaviour
{
    //Table of Maps(Matrixs)
    public Map[] level;
    public static int k;
    public static int r;
    GameObject Sphere;
    public static int h;

    void Start()
    {
       
            
        
        SpawnLevel();
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("New level editor");
        }
        
    }



    void SpawnLevel()
    {

        

        Map grid = level[k];
        
        int xlength= grid.xprefabs.Length;




        for (int i = 0; i < grid.x; i++)
        {
            
            for (int j = 0; j < grid.Z; j++)
            {
               
                /*Instantiate(Resources.Load("Cube", typeof(GameObject))) as GameObject;*/
                 GameObject sandouk = Instantiate(grid.prefab) as GameObject;
                sandouk.transform.position = new Vector3(j * 1f,  0 , i * -1f);
                h++;

                {
                 
                    DespawnSandouk(sandouk , grid, ref r, xlength, k);
                    
                }
            }

        }
        if (k+1 < level.Length)
            k++;
        else
        { k = 0; }    
   
    }


     void DespawnSandouk(GameObject sndk , Map grd , ref int counter , int l, int elk)
        {
        
            while ((sndk.transform.position.x == grd.xprefabs[counter].cordx &
            sndk.transform.position.z == grd.xprefabs[counter].cordZ))

            {
                //Debug.Log("this is from matrice number  " + elk + " sandouk with the cord x =  " + grd.xprefabs[counter].cordx + " et cord Z = " + grd.xprefabs[counter].cordZ);
                Destroy(sndk);
            h--;
               // Debug.Log("Counter=" + counter);
               // Debug.Log("r=" + r);

            // <l-1 because counter starts from 0 and l starts from 1 
            if (counter < l-1)
                counter++;
                else
                    counter = 0;

            }
        
        }  
}