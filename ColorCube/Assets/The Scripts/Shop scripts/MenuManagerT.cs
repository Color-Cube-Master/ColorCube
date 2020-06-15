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
    private void Awake()
    {   

        _instance2 = this;
         

      
       // InitAllItems2(); 

    }
    private void Start()
    {
         
        coincount=MenuCoins.coincount2;
        ScoreText.text = coincount.ToString();
        CreateShop2();
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
