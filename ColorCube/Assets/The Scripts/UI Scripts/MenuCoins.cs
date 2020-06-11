using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCoins : MonoBehaviour
{
    public Text CoinsText;
    public static int coincount2;
    // Start is called before the first frame update
    void Start()
    { coincount2= 500;
      CoinsText.text = coincount2.ToString();
    }

  
}
