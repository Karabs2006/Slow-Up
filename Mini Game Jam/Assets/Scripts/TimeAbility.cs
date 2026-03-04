using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeAbility : MonoBehaviour
{
    public Slider slider; 
    public FPController fPController;
    bool testing = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.value = 5;
    }

    // Update is called once per frame
    void Update()
    {   
        if(fPController.isTimeSlowed)
        {
            StartCoroutine(SlowDown());
        }
        
    }

    IEnumerator SlowDown()
    {
        for(int i = 5; i >= 0; i--)
        {   
            slider.value = i;
            yield return new WaitForSeconds(1f);
            if(slider.value == 0)
            {
                testing = true;
            }
        }
        
    }
}
