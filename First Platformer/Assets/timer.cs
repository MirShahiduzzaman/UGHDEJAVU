using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private static float secondsCount;
    void FixedUpdate()
    {
        secondsCount += Time.deltaTime;
        timerText.text = "Time" + " " + " " + " " + " " + (int)secondsCount + "s";
    } 

    public static void resetTimer()
    {
        secondsCount = 0;
    }

    public static int getSec()
    {
        return((int)secondsCount);
    }

}
