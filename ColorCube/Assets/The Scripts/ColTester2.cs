using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColTester2 : MonoBehaviour
{
    
    public Material Green;
    public Material Red;
    int Counter;
    int HitsMAX;
    public static int GameOver=0;
    public static bool P;
    


    
    


    Renderer rend;
    void Start ()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        rend = GetComponent<Renderer>();
        HitsMAX = UnityEngine.Random.Range(1,9);
        rend.material = Red;
        GameOver=0;
        
        //show the number of hits needed for the cube to get destroyed
        //Debug.Log(HitsMAX);
    }
    // This function is for destroying the cube 
    void Destroy()
    {
        if (Counter == HitsMAX-1)
        { Destroy(gameObject); }
    }
   
    // this function is for the collision and the color changing 
    
            

    void OnCollisionEnter(Collision col )
    {   
        if ((col.gameObject.tag == "Player") && (Counter % 2 != 0))
        //if green
        {

            //Destroy();

            FindObjectOfType<AudioManager>().Play("BounceNew");
            rend.material = Red;
            Counter++;
            GameOver--;
            P = false ;
            //Debug.Log(GameOver);
           
        }

        else

        //else if red
        {
            //Destroy();

            {
                FindObjectOfType<AudioManager>().Play("BounceNew");
                rend.material = Green;
                Counter++;
                GameOver++;
                P = true ;
                
                //Debug.Log(GameOver);
                if(GameOver==LevelSpawner.h)
            {
        
                     

                     if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Beta"))
                       {
                            FindObjectOfType<AudioManager>().Stop("Playing");
                            SceneManager.LoadScene("You Win");
                        if (LevelSpawner.B + 1 <  LevelSpawner.f)
                        {LevelSpawner.B ++;
                        MenuCoins.coincount2+=MenuCoins.BetaCoin;
                        MenuCoins.BetaCoin+=100;} //Add 100$ with each win
                        else
                        {LevelSpawner.B =0;
                        MenuCoins.coincount2+=MenuCoins.BetaCoin;
                        MenuCoins.BetaCoin=50;}
                        SaveManager.Save();
                        }
                        
                    /*else if( SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Prototype Level Complex"))
                     {
                               FindObjectOfType<AudioManager>().Stop("Playing");
                            SceneManager.LoadScene("You Win");

                            
                          }*/
                          
                    else if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Laser"))
                    {
                            FindObjectOfType<AudioManager>().Stop("Playing");
                         SceneManager.LoadScene("You Win");
                        if (LevelSpawner.L + 1 <  LevelSpawner.f)
                        {LevelSpawner.L ++;
                        MenuCoins.coincount2+=MenuCoins.LaserCoin;
                        MenuCoins.LaserCoin+=500;} //Add 500$ with each win
                         else
                            {LevelSpawner.L =0;
                            MenuCoins.coincount2+=MenuCoins.LaserCoin;
                            MenuCoins.LaserCoin=100;}
                            SaveManager.Save();
                        }
                      else if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("FireBall"))
                      {
                           FindObjectOfType<AudioManager>().Stop("Playing");
                         SceneManager.LoadScene("You Win");
                         if (LevelSpawner.FI + 1 <  LevelSpawner.f)
                         {LevelSpawner.FI ++;
                         MenuCoins.coincount2+=MenuCoins.FireBallCoin;
                         MenuCoins.FireBallCoin+=500;} 
                         else
                        {LevelSpawner.FI =0;
                        MenuCoins.coincount2+=MenuCoins.FireBallCoin;
                        MenuCoins.FireBallCoin+=100;}
                        SaveManager.Save();
                      }
                      else if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("SlowMode"))
                      {
                           FindObjectOfType<AudioManager>().Stop("Playing");
                         SceneManager.LoadScene("You Win");
                           if (LevelSpawner.S + 1 <  LevelSpawner.f)
                          {LevelSpawner.S ++;
                          MenuCoins.coincount2+=MenuCoins.SlowModeCoin;
                          MenuCoins.SlowModeCoin+=400;} //Add 400$ with each win
                          else
                         {  LevelSpawner.S =0;
                         MenuCoins.coincount2+=MenuCoins.SlowModeCoin;
                         MenuCoins.SlowModeCoin=100;}
                          SaveManager.Save();
                      }
                      else if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Timer") )
                      {
                           FindObjectOfType<AudioManager>().Stop("Playing");
                         SceneManager.LoadScene("You Win");
                         if (LevelSpawner.T + 1 <  LevelSpawner.f)
                        {LevelSpawner.T ++;
                        MenuCoins.coincount2+=MenuCoins.TimerCoin;
                        MenuCoins.TimerCoin+=400;}
                        else
                        {LevelSpawner.T =0;
                        MenuCoins.coincount2+=MenuCoins.TimerCoin;
                        MenuCoins.TimerCoin=100;}
                        SaveManager.Save();
                      }
                         
                          
                 
            
            }


            }
        }
     
        
    }
}
/*update*/