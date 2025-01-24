using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    private int currentRound = 0;
    [SerializeField] int[] roundEnemyCount = { 10, 2 };

    public void StartRound()
    {
        for (int i = 0; i < roundEnemyCount[currentRound]; i++)
        {
            GameObject.Instantiate(enemyPrefab);
        }
        currentRound++;
    }
}
