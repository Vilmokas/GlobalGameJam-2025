using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] EnemySpawner enemyManager;
    [SerializeField] float buildRoundTime = 10f;
    [SerializeField] float defendRoundTime = 10f;
    [SerializeField] TextMeshProUGUI roundTimerText;
    [SerializeField] GameObject turretShopWindow;
    [SerializeField] TextMeshProUGUI modeText;
    [SerializeField] GameObject endGameWindow;
    bool isGameRunning = true;
    bool isBuildMode = true;
    float timeRemaining = 0;

    void Start()
    {
        Time.timeScale = 1.0f;
        StartCoroutine(StartGame());
    }

    private void Update()
    {
        roundTimerText.text = (timeRemaining - Time.time).ToString("0");
        modeText.text = isBuildMode ? "build" : "defend";
    }

    public void EndGame()
    {
        endGameWindow.SetActive(true);
        isGameRunning = false;
        StopCoroutine(StartGame());
        Time.timeScale = 0.0f;
    }

    IEnumerator StartGame()
    {
        while (isGameRunning)
        {
            timeRemaining = Time.time + buildRoundTime;
            turretShopWindow.SetActive(true);
            isBuildMode = true;
            yield return new WaitForSeconds(buildRoundTime);
            turretShopWindow.SetActive(false);
            isBuildMode = false;
            enemyManager.StartRound();
            timeRemaining = Time.time + defendRoundTime;
            yield return new WaitForSeconds(defendRoundTime);
        }
    }


}
