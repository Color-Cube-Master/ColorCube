using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class ModelT : MonoBehaviour
{
    public static string Name;
    public static string Name2;
    public static string State1;
    public static string State2;
    public Image Icon2;
    public Image[] ImageState2;
    public Text priceText2;
    private int price2;
    private ShopItemT shopItemT;
    Scene m_Scene;
  string sceneName;
    void Start()
    {
          

         m_Scene = SceneManager.GetActiveScene();
         sceneName = m_Scene.name;
        
    }
    private void OnEnable()
    {
        MenuManagerT.Instance2.itemusit2 += VerifItem2;
    }
    private void OnDisable()
    {
        MenuManagerT.Instance2.itemusit2 -= VerifItem2;


    }

    public void SetItem2(ShopItemT _shopItemT)
    {
        shopItemT = _shopItemT;
        Setup2();
    }

    void Setup2()
    {
        foreach (var item2 in ImageState2)
        {
            item2.gameObject.SetActive(false);
        }
        ImageState2[(int)shopItemT.state2].gameObject.SetActive(true);
        Icon2.sprite = shopItemT.icon2;
        price2 = shopItemT.Price2;
        priceText2.text = price2.ToString();

    }

    public void ChangeState2()
    {

        switch (shopItemT.state2)
        {
            case TheState.Lockit2:
            
                if (price2<=MenuManagerT.Instance2.coincount)
                {
                    shopItemT.state2 = TheState.Unlock2;
                    MenuManagerT.Instance2.UseCoin2(price2);
                    Setup2();
                    GameObject BoughtT = GameObject.FindWithTag("BoughtT");
                    if(BoughtT.activeSelf)
                        {Debug.Log("Ahowa theme");
                      // SaveManager.SaveStatsT(BoughtT);
                        }
                }
                break;
            case TheState.Unlock2:
            
                shopItemT.state2 = TheState.UseIt2;
                MenuManagerT.Instance2.ItemUseitChange2(shopItemT);
            if (sceneName == "ThemeShopScene")
                Name = shopItemT.name;
                Debug.Log(Name);
                
                Setup2();
                SaveManager.Save();


                break;
            case TheState.UseIt2:


                break;
            default:
                break;
        }
    }



    public void VerifItem2(ShopItemT _shopitemT)
    {
        if (_shopitemT!=shopItemT && shopItemT.state2!=TheState.Lockit2)
        {
            shopItemT.state2 = TheState.Unlock2;
            Setup2();
        }
    }
}
