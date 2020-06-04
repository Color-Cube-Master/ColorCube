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

 public AudioClip MenuMusic ;


   
 
 
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
 //FireBall level selection
    public void SelectF1(){

       GameObject SelectF1 = GameObject.FindWithTag("F1");
       Button Selected = SelectF1.GetComponent<Button>();
       LevelSpawner.k=0;
         SceneManager.LoadScene("FireBall");
    }

public void SelectF2(){

       GameObject SelectF2 = GameObject.FindWithTag("F2");
       Button Selected = SelectF2.GetComponent<Button>();
       LevelSpawner.k=1;
         SceneManager.LoadScene("FireBall");
    }

    public void SelectF3(){

       GameObject SelectF3 = GameObject.FindWithTag("F3");
       Button Selected = SelectF3.GetComponent<Button>();
       LevelSpawner.k=2;
         SceneManager.LoadScene("FireBall");
    }

    public void SelectF4(){

       GameObject SelectF4 = GameObject.FindWithTag("F4");
       Button Selected = SelectF4.GetComponent<Button>();
       LevelSpawner.k=3;
         SceneManager.LoadScene("FireBall");
    }

     public void SelectF5(){

       GameObject SelectF5 = GameObject.FindWithTag("F5");
       Button Selected = SelectF5.GetComponent<Button>();
       LevelSpawner.k=4;
         SceneManager.LoadScene("FireBall");
    }
     //Laser level selection

      public void SelectL1(){

       GameObject SelectL1 = GameObject.FindWithTag("L1");
       Button Selected = SelectL1.GetComponent<Button>();
       LevelSpawner.k=0;
         SceneManager.LoadScene("Laser");
    }

public void SelectL2(){

       GameObject SelectL2 = GameObject.FindWithTag("L2");
       Button Selected = SelectL2.GetComponent<Button>();
       LevelSpawner.k=1;
         SceneManager.LoadScene("Laser");
    }

    public void SelectL3(){

       GameObject SelectL3 = GameObject.FindWithTag("L3");
       Button Selected = SelectL3.GetComponent<Button>();
       LevelSpawner.k=2;
         SceneManager.LoadScene("Laser");
    }

    public void SelectL4(){

       GameObject SelectL4 = GameObject.FindWithTag("L4");
       Button Selected = SelectL4.GetComponent<Button>();
       LevelSpawner.k=3;
         SceneManager.LoadScene("Laser");
    }

     public void SelectL5(){

       GameObject SelectL5 = GameObject.FindWithTag("L5");
       Button Selected = SelectL5.GetComponent<Button>();
       LevelSpawner.k=4;
         SceneManager.LoadScene("Laser");
    }
    //Slow levels selection

    public void SelectS1(){

       GameObject SelectS1 = GameObject.FindWithTag("S1");
       Button Selected = SelectS1.GetComponent<Button>();
       LevelSpawner.k=0;
         SceneManager.LoadScene("SlowMode");
    }

public void SelectS2(){

       GameObject SelectS2 = GameObject.FindWithTag("S2");
       Button Selected = SelectS2.GetComponent<Button>();
       LevelSpawner.k=1;
         SceneManager.LoadScene("SlowMode");
    }

    public void SelectS3(){

       GameObject SelectS3 = GameObject.FindWithTag("S3");
       Button Selected = SelectS3.GetComponent<Button>();
       LevelSpawner.k=2;
         SceneManager.LoadScene("SlowMode");
    }

    public void SelectS4(){

       GameObject SelectS4 = GameObject.FindWithTag("S4");
       Button Selected = SelectS4.GetComponent<Button>();
       LevelSpawner.k=3;
         SceneManager.LoadScene("SlowMode");
    }

     public void SelectS5(){

       GameObject SelectS5 = GameObject.FindWithTag("S5");
       Button Selected = SelectS5.GetComponent<Button>();
       LevelSpawner.k=4;
         SceneManager.LoadScene("SlowMode");
    }
    //Timer levels selection

    public void SelectT1(){

       GameObject SelectT1 = GameObject.FindWithTag("T1");
       Button Selected = SelectT1.GetComponent<Button>();
       LevelSpawner.k=0;
         SceneManager.LoadScene("Timer");
    }

public void SelectT2(){

       GameObject SelecTS2 = GameObject.FindWithTag("T2");
       Button Selected = SelecTS2.GetComponent<Button>();
       LevelSpawner.k=1;
         SceneManager.LoadScene("Timer");
    }

    public void SelectT3(){

       GameObject SelectT3 = GameObject.FindWithTag("T3");
       Button Selected = SelectT3.GetComponent<Button>();
       LevelSpawner.k=2;
         SceneManager.LoadScene("Timer");
    }

    public void SelectT4(){

       GameObject SelectT4 = GameObject.FindWithTag("T4");
       Button Selected = SelectT4.GetComponent<Button>();
       LevelSpawner.k=3;
         SceneManager.LoadScene("Timer");
    }

     public void SelectT5(){

       GameObject SelectT5 = GameObject.FindWithTag("T5");
       Button Selected = SelectT5.GetComponent<Button>();
       LevelSpawner.k=4;
         SceneManager.LoadScene("Timer");
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

     public void ReturnCh(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
       
         SceneManager.LoadScene("FireBallChallenge");
    }

    public void ReturnCh_L(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh_L");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
       
         SceneManager.LoadScene("LaserChallenge");
    }

    public void ReturnCh_S(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh_S");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
       
         SceneManager.LoadScene("SlowMoChallenge");
    }

    public void ReturnCh_T(){

       GameObject ReturnCh2 = GameObject.FindWithTag("ReturnCh_T");
       Button ReturnCh = ReturnCh2.GetComponent<Button>();
       
         SceneManager.LoadScene("TimerChallenge");
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

                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = MenuMusic;
                audio.Play();
}
      
}
