using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMessage : MonoBehaviour
{
    public Text winText;
    public GameObject winMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Player.getDone())
        {
            winMenuUI.SetActive(true);
            Time.timeScale = 0f;
            PauseMenu.GameIsPaused = true;
        }
    }
}
