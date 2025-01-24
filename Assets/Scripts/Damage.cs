using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided with " + other.gameObject.name);
        if (other.gameObject.TryGetComponent(out Health target))
        {
            target.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
