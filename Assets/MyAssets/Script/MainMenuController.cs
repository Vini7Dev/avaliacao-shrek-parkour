using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject menuUI;
    public GameObject gameUI;
    public GameObject shrek;

    private float tempoAtual = 10f;
    private bool cronometroAtivo = true;

    private void Update()
    {
        if (cronometroAtivo)
        {
            timerText.text = "Começa em " + Mathf.RoundToInt(tempoAtual);

            tempoAtual -= Time.deltaTime;
            if (tempoAtual <= 0f)
            {
                CronometroCompleto();
            }
        }
    }

    private void CronometroCompleto()
    {
        cronometroAtivo = false;
        shrek.SetActive(true);
        gameUI.SetActive(true);
        menuUI.SetActive(false);
    }
}
