using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float nextPointThreshold = 0.1f;
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
}
