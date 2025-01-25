using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float enemySpawnDelay;
    [SerializeField] Transform[] enemyPathPoints;

    private int currentRound = 0;
    [SerializeField] int[] roundEnemyCount = { 10, 2 };

    public void StartRound()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < roundEnemyCount[currentRound]; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemy.GetComponent<EnemyController>().pathPoints = enemyPathPoints;
            yield return new WaitForSeconds(enemySpawnDelay);
        }
        currentRound++;
    }
}
