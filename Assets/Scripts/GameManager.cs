using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] EnemySpawner enemyManager;
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        enemyManager.StartRound();
    }
}
