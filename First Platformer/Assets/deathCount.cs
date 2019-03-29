using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathCount : MonoBehaviour
{
    public static int deaths = 0;
    public static Text deathText;
    
    public static void UpdateDeathCount()
    {
        deaths++;
        deathText.text = "Death Count" + " " + " " + " " + " " + " " + deaths.ToString();
    }
}
