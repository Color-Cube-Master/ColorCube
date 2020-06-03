using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
 public Sprite NotPressed1;
 public Sprite Pressed1 ;



   
 
 
 //Old method
 /*Application.LoadLevel(ColTester2.sceneIndex);
        public static int sceneIndex;  
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(DestroyByBoundary.sceneIndex); */
 
    void Awake() {

    			DontDestroyOnLoad(gameObject);

                 }
   
//Changing the buttons sprites on press-------------------------------------------------------------------------------------------------------
    public void ChangeButtonNext(){

     if (Next.image.sprite == NotPressed )

         Next.image.sprite = Pressed;

     else 

         Next.image.sprite = NotPressed;
     
    }

    public void ChangeButtonRetry(){

     if (Retry.image.sprite == NotPressed)

         Retry.image.sprite = Pressed;

     else

         Retry.image.sprite = NotPressed;
     
    }

    //_Switching scenes on press-----------------------------------------------------------------------------------------------------------
public void ChangeButtonSettings(){

     if (Settings.image.sprite == NotPressedSettings)
{
         Settings.image.sprite = PressedSettings;
         SceneManager.LoadScene("Settings");
}

     else

         Settings.image.sprite = NotPressedSettings;
     
    }

    public void ChangeButtonShop(){

     if (Shop.image.sprite == NotPressedShop)
{
         Shop.image.sprite = PressedShop;
         SceneManager.LoadScene("Shop");
}

     else

         Shop.image.sprite = NotPressedShop;
     
    }

    public void ChangeButtonLeaderboard(){

     if (Leaderboard.image.sprite == NotPressedLeaderboard_Ch)
{
         Leaderboard.image.sprite = PressedLeaderboard_Ch;
         SceneManager.LoadScene("Leaderboards");
}

     else

         Leaderboard.image.sprite = NotPressedLeaderboard_Ch;
     
    }

    public void ChangeButtonChallenges(){

     if (Challenges.image.sprite == NotPressedLeaderboard_Ch)
{
         Challenges.image.sprite = PressedLeaderboard_Ch;
         SceneManager.LoadScene("Challenges 2.0");

} 
     else

         Challenges.image.sprite = NotPressedLeaderboard_Ch;
     
    }

    public void ChangeButtonMenu(){

       GameObject Menu2 = GameObject.FindWithTag("Menu");
       Button Menu = Menu2.GetComponent<Button>();

     /*if (Menu.image.sprite == NotPressedMenu)
    {
         Menu.image.sprite = PressedMenu;*/
         SceneManager.LoadScene("Menu");
         

/*} 
     else

         Menu.image.sprite = NotPressedMenu;*/
     
    }

     public void ChangeButtonTimer(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("TimerM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();

     /*if (ChallengesBack.image.sprite == NotPressed1)
{
         ChallengesBack.image.sprite = Pressed1; */
         SceneManager.LoadScene("TimerChallenge");
       

/*} 
     else

         ChallengesBack.image.sprite = NotPressed1;*/
     
    }

    public void ChangeButtonLaser(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("LaserM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
         SceneManager.LoadScene("LaserChallenge");
    }

     public void ChangeButtonFireBall(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("FireBallM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
         SceneManager.LoadScene("FireBallChallenge");
    }

     public void ChangeButtonSlow(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("SlowM");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();
         SceneManager.LoadScene("SlowMoChallenge");
    }

//Backs---------------------------------------------------------------------------------------------------------------------------------------
    public void ChangeButtonChallengesBack(){

       GameObject ChallengesBack2 = GameObject.FindWithTag("BackCh");
       Button ChallengesBack = ChallengesBack2.GetComponent<Button>();

     if (ChallengesBack.image.sprite == NotPressed)
{
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
{
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
{
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
{
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
{
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
{
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
{
         ChallengesBack.image.sprite = Pressed;
         SceneManager.LoadScene("Challenges 2.0");
         

} 
     else

         ChallengesBack.image.sprite = NotPressed;
     
    }

    //2shops--------------------------------------------------------------------------------------------------------------------------------
 public void ChangeButtonThemes(){

       GameObject Themes2 = GameObject.FindWithTag("Themes");
       Button Themes = Themes2.GetComponent<Button>();

         SceneManager.LoadScene("ThemeShopScene");
        
    }

    public void ChangeButtonCharacters(){

       GameObject Characters2 = GameObject.FindWithTag("Characters");
       Button Characters = Characters2.GetComponent<Button>();

         SceneManager.LoadScene("ModelShopScene");
        
    }

//Action on press---------------------------------------------------------------------------------------------------------------------------
    public void GoNext (string sceneName) {
       
        if (Next.image.sprite = Pressed)
        {
        //SceneManager.LoadScene("Timer");
        //SceneManager.LoadScene (sceneIndex - 1);
        if (LevelSpawner.k + 1 <  LevelSpawner.f)
        LevelSpawner.k ++;
        else
        LevelSpawner.k =0;
        SceneManager.LoadScene(LevelSpawner.sceneName);
        
        }
    }


    public void GoBack (string sceneName) {
       
        if (Retry.image.sprite = Pressed)
            
             SceneManager.LoadScene(LevelSpawner.sceneName);        
    }

//Plays--------------------------------------------------------------------------------------------------------------------------------------
public void StartGame() {
    SceneManager.LoadScene("Beta");
}
      
}
