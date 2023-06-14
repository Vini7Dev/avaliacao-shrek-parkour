using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrophyController : MonoBehaviour
{
    public TextMeshProUGUI tropheusText;
    public TextMeshProUGUI finishMessage1;
    public TextMeshProUGUI finishMessage2;
    public TextMeshProUGUI finishMessage3;
    public GameObject finishCamera;
    public GameObject shrekDancing;
    public GameObject shrekDisapointed;
    public GameObject sceneLight;
    public GameObject mainCamera;

    public int totalOfTrophy = 3;
    private int trophyCount = 0;

    private string successMessage1 = "\"Somos poucos mas somos loucos\"";
    private string successMessage2 = "~ Chorão";
    private string successMessage3 = "Você salvou a copa com os troféus do brasileirão. Agora Neymar poderá dar aula!";

    private string loseMessage1 = "\"Eu odeio gente chique eu não uso sapato\"";
    private string loseMessage2 = "~ Chorão";
    private string loseMessage3 = "Você não foi capaz de salvar a copa coletando os troféus do brasileirão!";

    private void VerifyIfHasAllTrophy()
    {
        if (totalOfTrophy == trophyCount)
        {
            shrekDancing.SetActive(true);
            finishMessage1.text = successMessage1;
            finishMessage2.text = successMessage2;
            finishMessage3.text = successMessage3;
        }
        else
        {
            shrekDisapointed.SetActive(true);
            finishMessage1.text = loseMessage1;
            finishMessage2.text = loseMessage2;
            finishMessage3.text = loseMessage3;
        }

        sceneLight.SetActive(false);
        mainCamera.SetActive(false);
        finishCamera.SetActive(true);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            trophyCount++;

            if (trophyCount > totalOfTrophy)
            {
                trophyCount = 3;
            }

            tropheusText.text = "Troféus: " + trophyCount + "/" + totalOfTrophy;
        }
        else if (other.CompareTag("FinishCollider"))
        {
            VerifyIfHasAllTrophy();
        }
    }
}
