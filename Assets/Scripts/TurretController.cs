using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurretController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform shootPosition;
    [SerializeField] float damage = 1f;
    [SerializeField] float shootDelay = 1f;
    float lastShotTime = 0f;
    bool isPlaced = false;
    [SerializeField] List<GameObject> targets;

    void Update()
    {
        FollowCursor();
        ShootEnemy();
    }

    void FollowCursor()
    {
        if (isPlaced) return;

        Vector3 screenPoint = Input.mousePosition;
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(screenPoint);
        newPosition.z = 0f;
        transform.position = newPosition;

        if (Input.GetKeyDown(KeyCode.Mouse0)) isPlaced = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        targets.Add(other.gameObject);
    }

    void ShootEnemy()
    {
        if (!isPlaced) return;
        if (Time.time < lastShotTime) return;
        if (targets.Count == 0) return;
        while (targets.Count > 0)
        {
            if (!targets[0]) targets.RemoveAt(0);
            else break;
        }
        if (targets.Count == 0) return;

        lastShotTime = Time.time + shootDelay;
        GameObject projectile = Instantiate(projectilePrefab, shootPosition.position, Quaternion.identity);
        projectile.GetComponent<ProjectileController>().direction = (targets[0].transform.position - shootPosition.position).normalized;
        projectile.GetComponent<Damage>().damage = damage;
    }
}
