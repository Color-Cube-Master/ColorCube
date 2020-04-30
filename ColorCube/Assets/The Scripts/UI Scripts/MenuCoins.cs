using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCoins : MonoBehaviour
{
    public Text CoinsText;
    // Start is called before the first frame update
    void Start()
    {
      CoinsText.text = MenuManager.coincount2.ToString();
    }

  
}
