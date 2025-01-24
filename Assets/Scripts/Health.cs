using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(gameObject.name + " taking damage");

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
