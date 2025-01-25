using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float nextPointThreshold = 0.1f;
    [SerializeField] int pointsToGiveOnDeath = 1;
    public Transform[] pathPoints;
    int currentPathPoint = 0;

    private void FixedUpdate()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        transform.Translate((pathPoints[currentPathPoint].position - transform.position).normalized * moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, pathPoints[currentPathPoint].position) <= nextPointThreshold) currentPathPoint++;
    }

    public void DestroyEnemy()
    {
        GameObject.Find("TurretSpawner").GetComponent<TurretSpawner>().AddCurrency(pointsToGiveOnDeath);
        Destroy(gameObject, 0.175f);
    }
}
