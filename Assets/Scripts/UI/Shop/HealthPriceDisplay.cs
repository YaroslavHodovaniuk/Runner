using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPriceDisplay : MonoBehaviour
{
    [SerializeField] private Shop _shop;
    [SerializeField] private TMP_Text _healthPriceDisplay;

    private void OnEnable()
    {
        _shop.HealthPriceChanged += OnHealthPriceChanged;
    }

    private void OnDisable()
    {
        _shop.HealthPriceChanged -= OnHealthPriceChanged;
    }

    private void OnHealthPriceChanged(int health)
    {
        _healthPriceDisplay.text = health.ToString();
    }
}
