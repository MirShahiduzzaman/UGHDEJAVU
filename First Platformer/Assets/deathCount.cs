using UnityEngine;
using UnityEngine.UI;

public class deathCount : MonoBehaviour
{
    public static int deaths = 21;
    public static Text deathText;
    
    public static void UpdateDeathCount()
    {
        Debug.Log("Died ");
        deaths++;
        deathText.text = "Death Count" + " " + " " + " " + " " + " " + deaths;
    }
}
