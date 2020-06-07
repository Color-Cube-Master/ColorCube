using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    Scene m_Scene;
    public static string sceneName;


 void Awake() {

    			DontDestroyOnLoad(gameObject);

                 }
public void Start(){
     m_Scene = SceneManager.GetActiveScene();

          sceneName = m_Scene.name;
          Load();
}
     public static void Save()
     {
      
      PlayerPrefs.SetInt("LevelBetaNumber", LevelSpawner.B);
       
        PlayerPrefs.SetInt("LevelFireBallNumber", LevelSpawner.FI);
        
        PlayerPrefs.SetInt("LevelLaserNumber", LevelSpawner.L);
       
        PlayerPrefs.SetInt("LevelSlowModeNumber", LevelSpawner.S);
        PlayerPrefs.SetInt("LevelTimerNumber", LevelSpawner.T);

        PlayerPrefs.SetInt("Goldamount",MenuCoins.coincount2);
        PlayerPrefs.SetString("ThemeName",Model.Name);  
        PlayerPrefs.SetString("PlayerName",Model.Name2);    
       
    }
    public static void Load()
    {
    LevelSpawner.B = PlayerPrefs.GetInt("LevelBetaNumber");
    LevelSpawner.FI = PlayerPrefs.GetInt("LevelFireBallNumber");
    LevelSpawner.L = PlayerPrefs.GetInt("LevelLaserNumber");

    LevelSpawner.S = PlayerPrefs.GetInt("LevelSlowModeNumber");

    LevelSpawner.T = PlayerPrefs.GetInt("LevelTimerNumber");

    MenuCoins.coincount2= PlayerPrefs.GetInt("Goldamount");
    Model.Name=  PlayerPrefs.GetString("ThemeName");    
    
    Model.Name2 =PlayerPrefs.GetString("PlayerName");
    




    }
}
