﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScenesManager : MonoBehaviour
{
 public Button Retry;
 public Button Next;
 public Button Settings;
 public Button Shop;
 public Button Leaderboard;
 public Button Challenges;
 

 public Button Play;


 public Sprite NotPressed;
 public Sprite Pressed ;
 public Sprite NotPressedSettings;
 public Sprite PressedSettings ;
 public Sprite NotPressedShop;
 public Sprite PressedShop ;
 public Sprite NotPressedLeaderboard_Ch;
 public Sprite PressedLeaderboard_Ch;
 public Sprite NotPressedMenu;
 public Sprite PressedMenu;
 
public static int mn;
public static int IsMuted=0;

public static int IsMutedSFX=0;
 Scene currentScene;
 string sceneName;
 

   
 
 
 //Old method
 /*Application.LoadLevel(ColTester2.sceneIndex);
        public static int sceneIndex;  
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(DestroyByBoundary.sceneIndex); */
       

    void Awake() {

    			DontDestroyOnLoad(gameObject);

                 }


     void Start() {
      
       currentScene = SceneManager.GetActiveScene ();
        sceneName = currentScene.name;
    
     
     
     
      
     }
     
//Changing the buttons sprites on press---------------------------------------------------------------------------------------------------------
    public void ChangeButtonNext(){

     if (Next.image.sprite == NotPressed )
     {
         FindObjectOfType<AudioManager>().Play("RectClick");
         FindObjectOfType<AudioManager>().Play("Playing");
         Next.image.sprite = Pressed;}

     else 

         Next.image.sprite = NotPressed;
     
    }

    public void ChangeButtonRetry(){

     if (Retry.image.sprite == NotPressed)
       {  FindObjectOfType<AudioManager>().Play("RectClick");
       FindObjectOfType<AudioManager>().Play("Playing");
         Retry.image.sprite = Pressed;}

     else

         Retry.image.sprite = NotPressed;
     
    }

    //_Switching scenes on press----------------------------------------------------------------------------------------------------------------
public void ChangeButtonSettings(){

     if (Settings.image.sprite == NotPressedSettings)
{        FindObjectOfType<AudioManager>().Play("RoundClick");
         Settings.image.sprite = PressedSettings;
         SceneManager.LoadScene("Settings");
}

     else

         Settings.image.sprite = NotPressedSettings;
     
    }

    public void ChangeButtonShop(){

     if (Shop.image.sprite == NotPressedShop)
{        FindObjectOfType<AudioManager>().Play("RoundClick");
         Shop.image.sprite = PressedShop;
         SceneManager.LoadScene("Shop");
}

     else

         Shop.image.sprite = NotPressedShop;
     
    }

    public void ChangeButtonLeaderboard(){

     if (Leaderboard.image.sprite == NotPressedLeaderboard_Ch)
{        FindObjectOfType<AudioManager>().Play("RoundClick");
         Leaderboard.image.sprite = PressedLeaderboard_Ch;
         SceneManager.LoadScene("Leaderboards");
}

     else

         Leaderboard.image.sprite = NotPressedLeaderboard_Ch;
     
    }

    public void ChangeButtonChallenges(){

     if (Challenges.image.sprite == NotPressedLeaderboard_Ch)
{        FindObjectOfType<AudioManager>().Play("RoundClick");
         Challenges.image.sprite = PressedLeaderboard_Ch;
         SceneManager.LoadScene("Challenges 2.0");

} 
     else

         Challenges.image.sprite = NotPressedLeaderboard_Ch;
     
    }

  
    public void ChangeButtonMenu(){

       GameObject Menu2 = GameObject.FindWithTag("Menu");
       Button Menu = Menu2.GetComponent<Button>(); 
         FindObjectOfType<AudioManager>().Play("RoundClick");
         FindObjectOfType<AudioManager>().Stop("Playing");                       
         SceneManager.LoadScene("Menu");
         FindObjectOfType<AudioManager>().Play("MainMenu");
     
    }

     public void ChangeButtonTimer(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("TimerM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
         SceneManager.LoadScene("TimerChallenge");
     
    }

    public void ChangeButtonLaser(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("LaserM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RoundClick");
         SceneManager.LoadScene("LaserChallenge");
    }

     public void ChangeButtonFireBall(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("FireBallM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
         
         FindObjectOfType<AudioManager>().Play("RoundClick");
         SceneManager.LoadScene("FireBallChallenge");
    }

     public void ChangeButtonSlow(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("SlowM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RoundClick");
         SceneManager.LoadScene("SlowMoChallenge");
    }
//Beta level selection---------------------------------------------------------------------------------------------------------------------
      public void SelectLevel(int i){
        
        if(LevelSpawner.B>=i)
       {FindObjectOfType<AudioManager>().Play("RoundClick");
     FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.B=i;
         SceneManager.LoadScene("Beta");}}
//Fireball level selection---------------------------------------------------------------------------------------------------------------------
          public void SelectLevelFire(int i){
            if(LevelSpawner.FI>=i){
        
       FindObjectOfType<AudioManager>().Play("RoundClick");
     FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
        LevelSpawner.FI=i;
         SceneManager.LoadScene("Fireball");}}
 
      
 //Laser level selection---------------------------------------------------------------------------------------------------------------------
      public void SelectLevelLaser(int i){
         if(LevelSpawner.L>=i){
       FindObjectOfType<AudioManager>().Play("RoundClick");
     FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
          LevelSpawner.L=i;
         SceneManager.LoadScene("Laser");}}
  //Slowmotion level selection--------------------------------------------------------------------------------------------------------------------- 
  public void SelectLevelSlow(int i){
     if(LevelSpawner.S>=i){
    FindObjectOfType<AudioManager>().Play("RoundClick");
     FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
                LevelSpawner.S=i;
         SceneManager.LoadScene("SlowMode");}}
//Timer level selection---------------------------------------------------------------------------------------------------------------------
   public void SelectLevelTimer(int i){

      if(LevelSpawner.T>=i){
         FindObjectOfType<AudioManager>().Play("RoundClick");
     FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
         LevelSpawner.T=i;
         SceneManager.LoadScene("Timer"); }}
        
   
      
/*--------------------------------------------------------------------------------------
    

 //FireBall level selection---------------------------------------------------------------------------------------------------------------------
    public void SelectF1(){

       GameObject SelectF1 = GameObject.FindWithTag("F1");
       Button Selected = SelectF1.GetComponent<Button>();
     FindObjectOfType<AudioManager>().Play("RoundClick");
     FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.FI=0;
         SceneManager.LoadScene("FireBall");
    }

public void SelectF2(){

       GameObject SelectF2 = GameObject.FindWithTag("F2");
       Button Selected = SelectF2.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.FI=1;
         SceneManager.LoadScene("FireBall");
    }

    public void SelectF3(){

       GameObject SelectF3 = GameObject.FindWithTag("F3");
       Button Selected = SelectF3.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.FI=2;
         SceneManager.LoadScene("FireBall");
    }

    public void SelectF4(){

       GameObject SelectF4 = GameObject.FindWithTag("F4");
       Button Selected = SelectF4.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.FI=3;
         SceneManager.LoadScene("FireBall");
    }

     public void SelectF5(){

       GameObject SelectF5 = GameObject.FindWithTag("F5");
       Button Selected = SelectF5.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.FI=4;
         SceneManager.LoadScene("FireBall");
    }
     //Laser level selection--------------------------------------------------------------------------------------------------------------------

      public void SelectL1(){

       GameObject SelectL1 = GameObject.FindWithTag("L1");
       Button Selected = SelectL1.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.L=0;
         SceneManager.LoadScene("Laser");
    }

public void SelectL2(){

       GameObject SelectL2 = GameObject.FindWithTag("L2");
       Button Selected = SelectL2.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.L=1;
         SceneManager.LoadScene("Laser");
    }

    public void SelectL3(){

       GameObject SelectL3 = GameObject.FindWithTag("L3");
       Button Selected = SelectL3.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.L=2;
         SceneManager.LoadScene("Laser");
    }

    public void SelectL4(){

       GameObject SelectL4 = GameObject.FindWithTag("L4");
       Button Selected = SelectL4.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.L=3;
         SceneManager.LoadScene("Laser");
    }

     public void SelectL5(){

       GameObject SelectL5 = GameObject.FindWithTag("L5");
       Button Selected = SelectL5.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.L=4;
         SceneManager.LoadScene("Laser");
    }
    //Slow levels selection------------------------------------------------------------------------------------------------------------------

    public void SelectS1(){

       GameObject SelectS1 = GameObject.FindWithTag("S1");
       Button Selected = SelectS1.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.S=0;
         SceneManager.LoadScene("SlowMode");
    }

public void SelectS2(){

       GameObject SelectS2 = GameObject.FindWithTag("S2");
       Button Selected = SelectS2.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.S=1;
         SceneManager.LoadScene("SlowMode");
    }

    public void SelectS3(){

       GameObject SelectS3 = GameObject.FindWithTag("S3");
       Button Selected = SelectS3.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.S=2;
         SceneManager.LoadScene("SlowMode");
    }

    public void SelectS4(){

       GameObject SelectS4 = GameObject.FindWithTag("S4");
       Button Selected = SelectS4.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.S=3;
         SceneManager.LoadScene("SlowMode");
    }

     public void SelectS5(){

       GameObject SelectS5 = GameObject.FindWithTag("S5");
       Button Selected = SelectS5.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.S=4;
         SceneManager.LoadScene("SlowMode");
    }
    //Timer levels selection---------------------------------------------------------------------------------------------------------------

    public void SelectT1(){

       GameObject SelectT1 = GameObject.FindWithTag("T1");
       Button Selected = SelectT1.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.T=0;
         SceneManager.LoadScene("Timer");
    }

public void SelectT2(){

       GameObject SelecTS2 = GameObject.FindWithTag("T2");
       Button Selected = SelecTS2.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.T=1;
         SceneManager.LoadScene("Timer");
    }

    public void SelectT3(){

       GameObject SelectT3 = GameObject.FindWithTag("T3");
       Button Selected = SelectT3.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.T=2;
         SceneManager.LoadScene("Timer");
    }

    public void SelectT4(){

       GameObject SelectT4 = GameObject.FindWithTag("T4");
       Button Selected = SelectT4.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.T=3;
         SceneManager.LoadScene("Timer");
    }

     public void SelectT5(){

       GameObject SelectT5 = GameObject.FindWithTag("T5");
       Button Selected = SelectT5.GetComponent<Button>();
       FindObjectOfType<AudioManager>().Play("RoundClick");
       FindObjectOfType<AudioManager>().Play("Playing");
       FindObjectOfType<AudioManager>().Stop("MainMenu");
       LevelSpawner.T=4;
         SceneManager.LoadScene("Timer");
    }
--------------------------------------------------------------------------------------*/

//Backs---------------------------------------------------------------------------------------------------------------------------------------
    public void ChangeButtonChallengesBack(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("BackCh");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();

     if (ChallengesBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         ChallengesBack.image.sprite = Pressed;
         SceneManager.LoadScene("Menu");
         

} 
     else

         ChallengesBack.image.sprite = NotPressed;
     
    }

public void ChangeButtonSettingsBack(){

       GameObject SettingsBack2 = GameObject.FindWithTag("BackSe");
       Button SettingsBack = SettingsBack2.GetComponent<Button>();

     if (SettingsBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         SettingsBack.image.sprite = Pressed;
         SceneManager.LoadScene("Menu");
         

} 
     else

         SettingsBack.image.sprite = NotPressed;
     
    }

    public void ChangeButtonShopBack(){

       GameObject ShopBack2 = GameObject.FindWithTag("BackSh");
       Button ShopBack = ShopBack2.GetComponent<Button>();

     if (ShopBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         ShopBack.image.sprite = Pressed;
         SceneManager.LoadScene("Menu");
         

} 
     else

         ShopBack.image.sprite = NotPressed;
     
    }

     public void ChangeButtonLeaderBoardBack(){

       GameObject LeaderBoardBack2 = GameObject.FindWithTag("BackLe");
       Button LeaderBoardBack = LeaderBoardBack2.GetComponent<Button>();

     if (LeaderBoardBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         LeaderBoardBack.image.sprite = Pressed;
         SceneManager.LoadScene("Menu");
         

} 
     else

         LeaderBoardBack.image.sprite = NotPressed;
     
    }

     public void ChangeButtonThemeBack(){

       GameObject ThemeBack2 = GameObject.FindWithTag("BackTh");
       Button ThemeBack = ThemeBack2.GetComponent<Button>();

     if (ThemeBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         ThemeBack.image.sprite = Pressed;
         SceneManager.LoadScene("Shop");
         

} 
     else

         ThemeBack.image.sprite = NotPressed;
     
    }

    public void ChangeButtonCharactersBack(){

       GameObject CharactersBack2 = GameObject.FindWithTag("BackChar");
       Button CharactersBack = CharactersBack2.GetComponent<Button>();

     if (CharactersBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         CharactersBack.image.sprite = Pressed;
         SceneManager.LoadScene("Shop");
         

} 
     else

         CharactersBack.image.sprite = NotPressed;
     
    }

     public void ChangeButtonBackInChallenges(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("BackInCh");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();

     if (ChallengesBack.image.sprite == NotPressed)
{        FindObjectOfType<AudioManager>().Play("RectClick");
         ChallengesBack.image.sprite = Pressed;
         SceneManager.LoadScene("Challenges 2.0");
         

} 
     else

         ChallengesBack.image.sprite = NotPressed;
     
    }

     public void ReturnCh(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RectClick");
         FindObjectOfType<AudioManager>().Stop("Playing");
       FindObjectOfType<AudioManager>().Play("MainMenu");
         SceneManager.LoadScene("FireBallChallenge");
         SaveManager.Load();
    }

    public void ReturnCh_L(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh_L");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RectClick");
         FindObjectOfType<AudioManager>().Stop("Playing");
       FindObjectOfType<AudioManager>().Play("MainMenu");
         SceneManager.LoadScene("LaserChallenge");
         SaveManager.Load();
    }

    public void ReturnCh_S(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh_S");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RectClick");
         FindObjectOfType<AudioManager>().Stop("Playing");
       FindObjectOfType<AudioManager>().Play("MainMenu");
         SceneManager.LoadScene("SlowMoChallenge");
         SaveManager.Load();
    }

    public void ReturnCh_T(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh_T");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RectClick");
        FindObjectOfType<AudioManager>().Stop("Playing");
       FindObjectOfType<AudioManager>().Play("MainMenu");
         SceneManager.LoadScene("TimerChallenge");
         SaveManager.Load();
    }

    //2shops--------------------------------------------------------------------------------------------------------------------------------
 public void ChangeButtonThemes(){

       GameObject Themes2 = GameObject.FindWithTag("Themes");
       Button Themes = Themes2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RectClick");
         SceneManager.LoadScene("ThemeShopScene"); 
        
    }

    public void ChangeButtonCharacters(){

       GameObject Characters2 = GameObject.FindWithTag("Characters");
       Button Characters = Characters2.GetComponent<Button>();
         FindObjectOfType<AudioManager>().Play("RectClick");
         SceneManager.LoadScene("ModelShopScene");
        
    }

//Action on press---------------------------------------------------------------------------------------------------------------------------
    public void GoNext (string sceneName) {
       
        if (Next.image.sprite = Pressed)
        {
        FindObjectOfType<AudioManager>().Play("RectClick");
        //SceneManager.LoadScene("Timer");
        //SceneManager.LoadScene (sceneIndex - 1);
        
        SceneManager.LoadScene(LevelSpawner.sceneName);
        
        }
    }


    public void GoBack (string sceneName) {
       
       // if (Retry.image.sprite = Pressed)
        
             SceneManager.LoadScene(LevelSpawner.sceneName);     
    }

 public void ClickPause(){

       FindObjectOfType<AudioManager>().Play("RoundClick");
    }

//Plays--------------------------------------------------------------------------------------------------------------------------------------
public void StartGame() {
    FindObjectOfType<AudioManager>().Play("RectClick");
     
    SceneManager.LoadScene("BetaSelection");
}

//Toggles-------------------------------------------------------------------------------------------------------------------------------------
  public void MuteMusic() {
    
   GameObject m_Toggle2 = GameObject.FindWithTag("ToggleS");
   Toggle m_Toggle  = m_Toggle2.GetComponent<Toggle>();

   if (!m_Toggle.isOn)
   {
    m_Toggle.isOn=false;  
     IsMuted=1;  
      SaveManager.Save();  
   }
   else
   {
      m_Toggle.isOn=true; 
       IsMuted=0;
       SaveManager.Save();   }
  }

public void MuteSfx() {
   GameObject sfx_Toggle2 = GameObject.FindWithTag("ToggleSfx");
   Toggle sfx_Toggle  = sfx_Toggle2.GetComponent<Toggle>();

   if (!sfx_Toggle.isOn)
   {
      sfx_Toggle.isOn=false;  
     IsMutedSFX=1; 
     
     
     SaveManager.Save(); 

   }
   else
   {
    sfx_Toggle.isOn=true;  
     IsMutedSFX=0;  
        
      SaveManager.Save();  }
  }
  

  



}
