using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCoins : MonoBehaviour
{
    public Text CoinsText;
    public static int coincount2;
    public static int FireBallCoin;
    public static int LaserCoin;
    public static int SlowModeCoin;
    public static int TimerCoin;
    public static int BetaCoin;

     Scene currentScene;
        string sceneName;
    // Start is called before the first frame update
    void Start()
    { SaveManager.Load();
    
     currentScene= SceneManager.GetActiveScene ();
      sceneName= currentScene.name;
      CoinsText.text = coincount2.ToString();
      
    }
    public void GetCoins(int j)
    {       if (sceneName == "BetaSelection")
            BetaCoin=j;
            if (sceneName == "FireBallChallenge")
            FireBallCoin=j;
            if (sceneName == "LaserChallenge")
            LaserCoin=j;
            if (sceneName == "SlowMoChallenge")
            SlowModeCoin=j;
             if (sceneName == "TimerChallenge")
             TimerCoin=j;
        
    }

  
}
