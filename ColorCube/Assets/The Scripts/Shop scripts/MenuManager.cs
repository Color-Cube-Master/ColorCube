using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    

    public static MenuManager _instance;
    public static MenuManager Instance { 
        get
    {
            if (_instance==null)
            {
                GameObject _MenuManager = new GameObject();
                _MenuManager.AddComponent<MenuManager>();

            }
            return _instance;
    }
}

    public List<ShopItem> shopItems;

    public GameObject Prefab;
    public Transform content;
private ShopItem item;
    public Text ScoreText;
    public int coincount;
//the second coincount we'll be using in the menu
public static int coincount2;
    public delegate void ItemUseIt(ShopItem shopItem);
    public event ItemUseIt itemusit;
public bool unlocked = false;

    private void Awake()
    {   
        //   SaveManager.LoadStats(Model.ImageState[(int)State.Unlock].gameObject);

        _instance = this;
        DontDestroyOnLoad(_instance);
        
       
    }

    private void Start()
    {

        coincount=MenuCoins.coincount2;
        ScoreText.text = coincount.ToString();
        CreateShop();
       LoadState();
        // PlayerPrefs.DeleteKey("StoredCharacters");

        
    }
 
    public void SaveState(){
    
       /* foreach (var item in shopItems)
        {   if(item.state == State.Unlock)
               {  
            PlayerPrefs.SetString( "StoredCharacters", item.state.ToString() );
            Debug.Log("state saved");
               }
        }*/
        
           PlayerPrefs.SetString( "StoredCharacters0", shopItems[0].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters1", shopItems[1].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters2", shopItems[2].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters3", shopItems[3].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters4", shopItems[4].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters5", shopItems[5].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters6", shopItems[6].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters7", shopItems[7].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters8", shopItems[8].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters9", shopItems[9].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters10", shopItems[10].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters11", shopItems[11].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters12", shopItems[12].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters13", shopItems[13].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters14", shopItems[14].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters15", shopItems[15].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters16", shopItems[16].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters17", shopItems[17].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters18", shopItems[18].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters19", shopItems[19].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters20", shopItems[20].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters21", shopItems[21].state.ToString() );
           PlayerPrefs.SetString( "StoredCharacters22", shopItems[22].state.ToString() );
   }

   void LoadState(){
    
      /*foreach (var item in shopItems) 
           
           { 
            // PlayerPrefs.GetString("ModelState",Model.State1);
            item.state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters") );
            Debug.Log("state Loaded");
           }*/
    shopItems[0].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters0") );
    shopItems[1].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters1") );
    shopItems[2].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters2") );
    shopItems[3].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters3") );
    shopItems[4].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters4") );
    shopItems[5].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters5") );
    shopItems[6].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters6") );
    shopItems[7].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters7") );
    shopItems[8].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters8") );
    shopItems[9].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters9") );
    shopItems[10].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters10") );
    shopItems[11].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters11") );
    shopItems[12].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters12") );
    shopItems[13].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters13") );
    shopItems[14].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters14") );
    shopItems[15].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters15") );
    shopItems[16].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters16") );
    shopItems[17].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters17") );
    shopItems[18].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters18") );
    shopItems[19].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters19") );
    shopItems[20].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters20") );
    shopItems[21].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters21") );
    shopItems[22].state = (State)System.Enum.Parse( typeof(State), PlayerPrefs.GetString("StoredCharacters22") );
       
     }
           
        
    void InitAllItems()
    {
        foreach (var item in shopItems)
        {
           item.initItem();
 
        }
    }
    void CreateShop()
    {
        StartCoroutine(createShop());

    }
   
    public void UseCoin(int c)
    {
        //coincount -= c;
        //ScoreText.text = coincount.ToString();
        StartCoroutine(CoinAnimation(c));
    }

    IEnumerator CoinAnimation(int c)
    {
        for (int i = 0; i < c/100; i++)
        {
            yield return new WaitForSeconds(0.0000001f);
            coincount -= 100;
            MenuCoins.coincount2=coincount ;
            ScoreText.text = coincount.ToString();
            //SaveState(); 
  

        }
        

    }

    IEnumerator createShop()
    {            

        foreach (var item in shopItems)
        {

            coincount =MenuCoins.coincount2;
            yield return new WaitForSeconds(0.2f);
            GameObject model = Instantiate(Prefab, content);
            model.GetComponent<Model>().SetItem(item);

 
        }
     
    }
    public void ItemUseitChange(ShopItem _shopitem)
    {
        if (itemusit!=null)
        {

            itemusit(_shopitem);
        }
    }
    
  
}
