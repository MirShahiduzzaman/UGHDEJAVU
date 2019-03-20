using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private static float secondsCount;
    private static int minuteCount;
    private static int hourCount;
    void FixedUpdate()
    {
        secondsCount += Time.deltaTime;
        timerText.text = "Time" + " " + " " + " " + " " + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
       // UpdateTimerUI();
    } 
    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
    }

    public static void resetTimer()
    {
        secondsCount = 0;
        minuteCount = 0;
        hourCount = 0;
    }

}
