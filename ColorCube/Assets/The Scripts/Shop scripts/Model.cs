﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class Model : MonoBehaviour
{       
    public static string Name;
    public static string Name2;
    public Image Icon;
    public Image[] ImageState;
    public Text priceText;
    private int price;
    private ShopItem shopItem;
    Scene m_Scene;
  string sceneName;
    void Start()
    {
         m_Scene = SceneManager.GetActiveScene();
         sceneName = m_Scene.name;
        
    }
    private void OnEnable()
    {
        MenuManager.Instance.itemusit += VerifItem;
    }
    private void OnDisable()
    {
        MenuManager.Instance.itemusit -= VerifItem;


    }

    public void SetItem(ShopItem _shopItem)
    {
        shopItem = _shopItem;
        Setup();
    }

    void Setup()
    {
        foreach (var item in ImageState)
        {
            item.gameObject.SetActive(false);
        }
        ImageState[(int)shopItem.state].gameObject.SetActive(true);
        Icon.sprite = shopItem.icon;
        price = shopItem.Price;
        priceText.text = price.ToString();

    }

    public void ChangeState()
    {
        switch (shopItem.state)
        {
            case State.Lockit:
                if (price<=MenuManager.Instance.coincount)
                {
                    shopItem.state = State.Unlock;
                    MenuManager.Instance.UseCoin(price);
                    Setup();
                }
                break;
            case State.Unlock:
                shopItem.state = State.UseIt;
                MenuManager.Instance.ItemUseitChange(shopItem);
            if (sceneName == "ThemeShopScene")
                Name = shopItem.name;
                if (sceneName == "ModelShopScene")
                Name2 = shopItem.name;
                
                Setup();


                break;
            case State.UseIt:


                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VerifItem(ShopItem _shopitem)
    {
        if (_shopitem!=shopItem && shopItem.state!=State.Lockit)
        {
            shopItem.state = State.Unlock;
            Setup();
        }
    }
}
