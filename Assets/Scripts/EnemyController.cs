using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    public Transform target;

    private void FixedUpdate()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        transform.Translate((target.position - transform.position).normalized * moveSpeed * Time.deltaTime);
    }
}
