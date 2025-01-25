using TMPro;
using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] turretPrefabs;
    [SerializeField] int[] turretCosts;
    [SerializeField] int currency = 0;
    [SerializeField] TextMeshProUGUI currencyText;

    private void Start()
    {
        currencyText.text = currency.ToString();
    }

    public void SpawnTurret(int turretId)
    {
        if (turretCosts[turretId] > currency) return;
        currency -= turretCosts[turretId];
        currencyText.text = currency.ToString();
        Instantiate(turretPrefabs[turretId]);
    }

    public void AddCurrency(int newCurrency)
    {
        currency += newCurrency;
        currencyText.text = currency.ToString();
    }
}
