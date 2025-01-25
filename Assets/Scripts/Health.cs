using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] UnityEvent deathEvent;
    [SerializeField] float health;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(gameObject.name + " taking damage");

        if (health <= 0)
        {
            deathEvent?.Invoke();
        }
    }
}
