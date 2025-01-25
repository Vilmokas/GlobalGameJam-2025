using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float ttl = 3f;
    public float damage = 0;
    public Vector3 direction;

    private void Start()
    {
        Destroy(gameObject, ttl);
    }

    private void FixedUpdate()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }
}
