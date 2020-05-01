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

    public Text ScoreText;
    public int coincount;
//the second coincount we'll be using in the menu
public static int coincount2;
    public delegate void ItemUseIt(ShopItem shopItem);
    public event ItemUseIt itemusit;
    private void Awake()
    {   

        _instance = this;
        InitAllItems();

    }
    private void Start()
    {
        
        ScoreText.text = coincount.ToString();
        CreateShop();
    }
    void Update()
    {
        //Press enter to move to the next level
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Menu");
        }
        
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
        for (int i = 0; i < c/10; i++)
        {
            yield return new WaitForSeconds(0.02f);
            coincount -= 10;
            MenuCoins.coincount2=coincount ;
            ScoreText.text = coincount.ToString();
            
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
