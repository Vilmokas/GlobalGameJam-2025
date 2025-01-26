using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] UnityEvent deathEvent;
    [SerializeField] UnityEvent reduceHealthEvent;
    [SerializeField] float health;

    public void TakeDamage(float damage)
    {
        health -= damage;
        reduceHealthEvent?.Invoke();

        if (health <= 0)
        {
            deathEvent?.Invoke();
        }
    }
}
