using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        GameObject player = GameObject.FindWithTag("Player");
        GameObject menuCanvas = GameObject.FindWithTag("MenuCanvas");
        GameObject inGameCanvas = GameObject.FindWithTag("InGameCanvas");

        player.SetActive(true);
        menuCanvas.SetActive(false);
        inGameCanvas.SetActive(true);
    }
}
