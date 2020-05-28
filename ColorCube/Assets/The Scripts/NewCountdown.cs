using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewCountdown : MonoBehaviour
{
    Image fillImg;
    public float timeAmt=50;
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
       else

            SceneManager.LoadScene("You Lose");
        
    }
}
