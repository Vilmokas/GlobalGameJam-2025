using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TurretSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] turretPrefabs;
    [SerializeField] int[] turretCosts;
    [SerializeField] int currency = 0;
    [SerializeField] TextMeshProUGUI currencyText;
    [SerializeField] UnityEvent turretBoughtEvent;
    [SerializeField] UnityEvent turretDeniedEvent;

    private void Start()
    {
        currencyText.text = currency.ToString();
    }

    public void SpawnTurret(int turretId)
    {
        if (turretCosts[turretId] > currency)
        {
            turretDeniedEvent?.Invoke();
            return;
        }
        currency -= turretCosts[turretId];
        currencyText.text = currency.ToString();
        Instantiate(turretPrefabs[turretId]);
        turretBoughtEvent?.Invoke();
    }

    public void AddCurrency(int newCurrency)
    {
        currency += newCurrency;
        currencyText.text = currency.ToString();
    }
}
