using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] turretPrefabs;
    [SerializeField] int[] turretCosts;
    [SerializeField] int currency = 0;

    public void SpawnTurret(int turretId)
    {
        if (turretCosts[turretId] > currency) return;
        currency -= turretCosts[turretId];
        Instantiate(turretPrefabs[turretId]);
    }
}
