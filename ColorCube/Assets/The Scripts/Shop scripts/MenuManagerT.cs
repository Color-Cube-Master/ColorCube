using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public  class MenuManagerT : MonoBehaviour
{

    
    public  static MenuManagerT _instance2;
    public  static MenuManagerT Instance2 { 
        get
    {
           if (_instance2 == null)
            {
                GameObject _MenuManagerT = new GameObject();
                _MenuManagerT.AddComponent<MenuManagerT>();

            }
            return _instance2;
    }
}

    public List<ShopItemT> shopItemsT;

    public GameObject Prefab2;
    public Transform content2;

    public Text ScoreText;
    public int coincount;
//the second coincount we'll be using in the menu
public static int coincount2;
    public delegate void ItemUseIt2(ShopItemT shopItemT);
    public event ItemUseIt2 itemusit2;
    public static int ModelNumber;
    public string ModelName;
      
    private void Awake()
    {   

        _instance2 = this;
        DontDestroyOnLoad(_instance2);
         

      
       // InitAllItems2(); 

    }
    private void Start()
    {
         ModelNumber=0;
        coincount=MenuCoins.coincount2;
        ScoreText.text = coincount.ToString();
        CreateShop2();
       LoadStateT();
             // PlayerPrefs.DeleteKey("StoredThemes");

    }
   
    public void SaveStatT(){
    
        /*foreach (var item2 in shopItemsT)
        {
           if (item2.state2 == TheState.Unlock2) 
            { 
            PlayerPrefs.SetString( "StoredThemes", item2.state2.ToString() );
            Debug.Log("state saved");}
        }*/
       
     
              PlayerPrefs.SetString( "StoredThemes0", shopItemsT[0].state2.ToString() );
         PlayerPrefs.SetString( "StoredThemes1", shopItemsT[1].state2.ToString() );
          PlayerPrefs.SetString( "StoredThemes2", shopItemsT[2].state2.ToString() );
           PlayerPrefs.SetString( "StoredThemes3", shopItemsT[3].state2.ToString() );
            PlayerPrefs.SetString( "StoredThemes4", shopItemsT[4].state2.ToString() );
             PlayerPrefs.SetString( "StoredThemes5", shopItemsT[5].state2.ToString() );
              PlayerPrefs.SetString( "StoredThemes6", shopItemsT[6].state2.ToString() );
               PlayerPrefs.SetString( "StoredThemes7", shopItemsT[7].state2.ToString() );
                PlayerPrefs.SetString( "StoredThemes8", shopItemsT[8].state2.ToString() );
                 PlayerPrefs.SetString( "StoredThemes9", shopItemsT[9].state2.ToString() );
   }
   void LoadStateT(){
       shopItemsT[0].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes0") );
    shopItemsT[1].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes1") );
    shopItemsT[2].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes2") );
    shopItemsT[3].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes3") );
    shopItemsT[4].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes4") );
    shopItemsT[5].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes5") );
    shopItemsT[6].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes6") );
    shopItemsT[7].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes7") );
    shopItemsT[8].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes8") );
    shopItemsT[9].state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes9") );
     /* foreach (var item2 in shopItemsT)
        {
           
           
            // PlayerPrefs.GetString("ModelState",Model.State1);
            item2.state2 = (TheState)System.Enum.Parse( typeof(TheState), PlayerPrefs.GetString("StoredThemes") );
            Debug.Log("state Loaded");
           
        }*/
     }
    /*void InitAllItems2()
    {
        foreach (var item2 in shopItemsT)
        {
           item2.initItem2();
 
        }
    }*/
    void CreateShop2()
    {
        StartCoroutine(createShop2());
    }
   
    public void UseCoin2(int c)
    {
        //coincount -= c;
        //ScoreText.text = coincount.ToString();
        StartCoroutine(CoinAnimation2(c));
    }

    IEnumerator CoinAnimation2(int c)
    {
        for (int i = 0; i < c/100; i++)
        {
            yield return new WaitForSeconds(0.0000001f);
            coincount -= 100;
            MenuCoins.coincount2=coincount ;
            ScoreText.text = coincount.ToString();
            //  SaveStatT();
        }
        

    }

    IEnumerator createShop2()
    {                                


        foreach (var item2 in shopItemsT)
        {
           
            coincount =MenuCoins.coincount2;
            yield return new WaitForSeconds(0.2f);
            GameObject modelT = Instantiate(Prefab2, content2);
            modelT.GetComponent<ModelT>().SetItem2(item2);
           /* GameObject BoughtT = GameObject.FindWithTag("BoughtT");
             SaveManager.LoadStatsT(BoughtT); */           
          

        }
     
    }
    public void ItemUseitChange2(ShopItemT _shopitemT)
    {
        if (itemusit2!=null)
        {
            itemusit2(_shopitemT);
                
        }
    }
}
