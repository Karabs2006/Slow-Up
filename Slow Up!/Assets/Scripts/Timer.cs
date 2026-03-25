using UnityEngine;
using System.Collections;
using TMPro;
using NUnit.Framework;

public class Timer : MonoBehaviour
{   
    public PlayerFall playerFall;
    public TMP_Text timeText;
    public int timeInt;
   
    void Start()
    {   
        StartCoroutine(Countdown());
        timeText.text = $"{timeInt}";
    }

    IEnumerator Countdown()
    {
       for(int i = timeInt; i >= 0; i--)
        {   
            timeText.text = $"{i}";
            if(i == 0)
            {
                playerFall.GameLoss();
            }
            
            yield return new WaitForSecondsRealtime(1f);
        }
    }
}
