﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSpawner : MonoBehaviour
{
    //Table of Maps(Matrixs)
    public Map[] level;
    public float spawnSpeed = 0;
    public static int k;
    public static int r;
    //public static int eh;

    void Start()
    {
        
        StartCoroutine(SpawnLevel());
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("New level editor");
            StartCoroutine(SpawnLevel());



        }

    }



    IEnumerator SpawnLevel()
    {



        Map grid = level[k];


        int cordx = grid.xprefabs[r].cordx;
        int cordY = grid.xprefabs[r].cordY;
        int xlength= grid.xprefabs.Length;
       /* int cordx1 = grid.xprefabs[1].cordx;
        int cordY1 = grid.xprefabs[1].cordY;*/






        for (int i = 0; i < grid.x; i++)
        {
            yield return new WaitForSeconds(spawnSpeed);
            for (int j = 0; j < grid.Y; j++)
            {
                yield return new WaitForSeconds(spawnSpeed);
                /*Instantiate(Resources.Load("Cube", typeof(GameObject))) as GameObject;*/
                 GameObject sandouk = Instantiate(grid.prefab) as GameObject;
                sandouk.transform.position = new Vector3(j * 1f, i * -1f, 0);

                {
                   /* if (sandouk.transform.position.x == cordx & sandouk.transform.position.y == cordY)
                    {
                        Debug.Log("this is from matrice number  " + k + " sandouk with the cord x =  " + cordx + " et cord y = " + cordY);
                        Destroy(sandouk);
                        
                    }*/
                    
                    DespawnSandouk(sandouk , cordx , cordY, r, xlength, k);

                    /*if (sandouk.transform.position.x == cordx1 & sandouk.transform.position.y == cordY1)
                    {
                        Debug.Log("this is from matrice number  " + k + " sandouk with the cord x =  " + cordx1 + " et cord y = " + cordY1);
                        Destroy(sandouk);
                    }*/

                }
            }

        }
        if (k+1 < level.Length)
            k++;
        else
        { k = 0; }
       /* if (eh < xlength)
            r++;
        else
        { eh = 0; }*/
       
       
        
    }
     void DespawnSandouk(GameObject sndk ,int crdx , int crdy ,int counter , int l, int elk)
        {
            while ((sndk.transform.position.x == crdx & sndk.transform.position.y == crdy) & (counter<l))
                    {
                        Debug.Log("this is from matrice number  " + elk + " sandouk with the cord x =  " + crdx + " et cord y = " + crdy);
                        Destroy(sndk);

                        counter++;
                        
                        
                    }
        }  
   
}
                
            

        

       
    



         


 






