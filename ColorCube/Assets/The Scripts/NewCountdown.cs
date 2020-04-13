using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewCountdown : MonoBehaviour
{
    Image fillImg;
    public float timeAmt = 10;
    float time;
    public Text timeText;

    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
            timeText.text =  time.ToString("0");
        }
    }
}
