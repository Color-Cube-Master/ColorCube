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
    public GameObject Boarder2 ;
    public GameObject Boarder1 ;
    public GameObject Player;
    public Transform SpawnPosition;


    void Start()
    {
       
            SpawnPlayer();
       //DontDestroyOnLoad(Player);
        SpawnLevel();
        
    }

     void SpawnPlayer() {
     Instantiate(Player,new Vector3(SpawnPosition.position.x, SpawnPosition.position.y, SpawnPosition.position.z) ,Quaternion.identity /*SpawnPosition.position*/);
     }
    void Update()
    {
        //Press enter to move to the next level
        if (Input.GetKey(KeyCode.Return))
        {
            //SceneManager.LoadScene("Beta");
        }
        
    }



    void SpawnLevel()
    {

        

        Map grid = level[k];
        
        int xlength= grid.xprefabs.Length;

//BlockedBox BB = grid.Props.Blocked_box;


        for (int i = 0; i < grid.x; i++)
        {
            
            for (int j = 0; j < grid.Z; j++)
            {
               
                /*Instantiate(Resources.Load("Cube", typeof(GameObject))) as GameObject;*/
                 GameObject sandouk = Instantiate(grid.prefab) as GameObject;
                sandouk.transform.position = new Vector3(i * 1f,  0 , j * -1f);
                
                h++;

                
                    SpawnBoarder_Up(grid,i,j);
                    SpawnBoarder_Left(grid,i,j);
                    SpawnBoarder_Right(grid,i,j);
                    SpawnBoarder_Down(grid,i,j);
                    DespawnSandouk(sandouk , grid, ref r, xlength, k);
                    
                    
                    
                   
                    
                    
                
            }

        } 
                    //Disabling and enabling props
                    DisableBlockedBox_OR_ActivateBlockedBox(grid);
                    DisableCrackedBox_OR_ActivateCrackedBox(grid);
                    DisableBOMB_OR_ActivateBOMB(grid);
                    DisableLAZER_OR_ActivateLAZER(grid);
                    DisableFireBall_OR_ActivateFireBall(grid);
        
                    //Spawn BlockedBox
                    GameObject Blocked_bxX = Instantiate(grid.Props.Blocked_box.Blocked_bx) as GameObject;
                    Blocked_bxX.transform.position = new Vector3(grid.Props.Blocked_box.posX ,  0 , grid.Props.Blocked_box.posZ );

                    //Spawn CrackedBox
                    GameObject Cracked_bxX = Instantiate(grid.Props.Cracked_box.Cracked_bx) as GameObject;
                    Cracked_bxX.transform.position = new Vector3(grid.Props.Cracked_box.posX ,  0 , grid.Props.Cracked_box.posZ );

                    //Spawn Bomb
                    GameObject TheBomb = Instantiate(grid.Props.Bomb0.Bomb_) as GameObject;
                    TheBomb.transform.position = new Vector3(grid.Props.Bomb0.posX ,  0 , grid.Props.Bomb0.posZ );

                    //Spawn Laser
                    GameObject TheLaser = Instantiate(grid.Props.Laser.Laser_) as GameObject;
                    TheLaser.transform.position = new Vector3(grid.Props.Laser.posX ,  grid.Props.Laser.posY , grid.Props.Laser.posZ );
                     
                    //Spawn FireBall
                     GameObject TheFireBall = Instantiate(grid.Props.FireBall0.FireBall_) as GameObject;
                    TheFireBall.transform.position = new Vector3(grid.Props.FireBall0.posX , 10f , grid.Props.FireBall0.posZ );






        if (k+1 < level.Length)
            k++;
        else
        { k = 0; }    
   
    }

     //Take boxes off
     void DespawnSandouk(GameObject sndk , Map grd , ref int counter , int l, int elk)
        {
        
            while ((sndk.transform.position.x == grd.xprefabs[counter].cordx &
            sndk.transform.position.z == grd.xprefabs[counter].cordZ))

            {
                //Debug.Log("this is from matrice number  " + elk + " sandouk with the cord x =  " + grd.xprefabs[counter].cordx + " et cord Z = " + grd.xprefabs[counter].cordZ);
                Destroy(sndk);
                Instantiate(Boarder2,new Vector3(sndk.transform.position.x, 0, sndk.transform.position.z),  Quaternion.identity);
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

        //Spawn up boarder
        void SpawnBoarder_Up(Map grd, int x , int z )
        {
            if ( x < grd.x  &  z == 0)
            {
            Instantiate(Boarder1,new Vector3(x, 0, z+1),  Quaternion.identity);
            }

        }
        //Spawn left boarder
        void SpawnBoarder_Left(Map grd, int x , int z )
        {
            if ( z < grd.Z  &  x == 0)
            {
            Instantiate(Boarder1,new Vector3(x-1, 0, -z),  Quaternion.identity);
            }

        }

        //Spawn right boarder

        void SpawnBoarder_Right(Map grd, int x , int z )
        {
            if ( z < grd.Z  &  x == grd.x-1)
            {
            Instantiate(Boarder1,new Vector3(x+1, 0, -z),  Quaternion.identity);

            }

        }
        //Spawn down boarder
        void SpawnBoarder_Down(Map grd, int x , int z )
        {
            if (  x < grd.x  & z == grd.Z-1 )
            {
            Instantiate(Boarder1,new Vector3(x, 0, -z-1),  Quaternion.identity);
            
            }

        }











        //Prefabs Toggle
        void DisableBlockedBox_OR_ActivateBlockedBox(Map grd)
           {

            if (grd.Props.Blocked_box.Enable == false)
            {
                
                     grd.Props.Blocked_box.Blocked_bx.SetActive(false);
            }
            if (grd.Props.Blocked_box.Enable == true)
            {
                
                     grd.Props.Blocked_box.Blocked_bx.SetActive(true);
            }     
            }

            void DisableCrackedBox_OR_ActivateCrackedBox(Map grd)
           {

            if (grd.Props.Cracked_box.Enable == false)
            {
                
                     grd.Props.Cracked_box.Cracked_bx.SetActive(false);
            }
            if (grd.Props.Cracked_box.Enable == true)
            {
                
                     grd.Props.Cracked_box.Cracked_bx.SetActive(true);
            }     
            }

            void DisableBOMB_OR_ActivateBOMB(Map grd)
           {

            if (grd.Props.Bomb0.Enable == false)
            {
                
                     grd.Props.Bomb0.Bomb_.SetActive(false);
            }
            if (grd.Props.Bomb0.Enable == true)
            {
                
                     grd.Props.Bomb0.Bomb_.SetActive(true);
            }     
            }

             void DisableLAZER_OR_ActivateLAZER(Map grd)
           {

            if (grd.Props.Laser.Enable == false)
            {
                
                     grd.Props.Laser.Laser_.SetActive(false);
            }
            if (grd.Props.Laser.Enable == true)
            {
                
                     grd.Props.Laser.Laser_.SetActive(true);
            }     
            }

            void DisableFireBall_OR_ActivateFireBall(Map grd)
           {

            if (grd.Props.FireBall0.Enable == false)
            {
                
                     grd.Props.FireBall0.FireBall_.SetActive(false);
            }
            if (grd.Props.FireBall0.Enable == true)
            {
                
                     grd.Props.FireBall0.FireBall_.SetActive(true);
            }     
            }
          
}