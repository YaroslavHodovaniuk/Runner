using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyPriceDisplay : MonoBehaviour
{
    [SerializeField] private Shop _shop;
    [SerializeField] private TMP_Text _moneyPriceDisplay;

    private void OnEnable()
    {
        _shop.MoneyPriceChanged += OnMoneyPriceChanged;
    }

    private void OnDisable()
    {
        _shop.MoneyPriceChanged -= OnMoneyPriceChanged;
    }

    private void OnMoneyPriceChanged(int money)
    {
        _moneyPriceDisplay.text = money.ToString();
    }
}
