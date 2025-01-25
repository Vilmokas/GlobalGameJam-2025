using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] float enemySpawnDelay;
    [SerializeField] Transform[] enemyPathPoints;

    public int currentRound = 0;
    public int[] roundEnemyCountNormal = { 10, 20, 30 };
    public int[] roundEnemyCountStrong = { 0, 10, 15 };
    public int[] roundEnemyCountElite = { 0, 0, 5 };

    public void StartRound()
    {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < roundEnemyCountNormal[currentRound]; i++)
        {
            GameObject enemy = Instantiate(enemyPrefabs[0], transform.position, Quaternion.identity);
            enemy.GetComponent<EnemyController>().pathPoints = enemyPathPoints;
            yield return new WaitForSeconds(enemySpawnDelay);
        }
        for (int i = 0; i < roundEnemyCountStrong[currentRound]; i++)
        {
            GameObject enemy = Instantiate(enemyPrefabs[1], transform.position, Quaternion.identity);
            enemy.GetComponent<EnemyController>().pathPoints = enemyPathPoints;
            yield return new WaitForSeconds(enemySpawnDelay);
        }
        for (int i = 0; i < roundEnemyCountElite[currentRound]; i++)
        {
            GameObject enemy = Instantiate(enemyPrefabs[2], transform.position, Quaternion.identity);
            enemy.GetComponent<EnemyController>().pathPoints = enemyPathPoints;
            yield return new WaitForSeconds(enemySpawnDelay);
        }
        currentRound++;
    }
}
