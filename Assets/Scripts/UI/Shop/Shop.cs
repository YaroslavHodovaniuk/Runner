using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shop : MonoBehaviour
{
    [SerializeField] private int _priceUpMoney;
    [SerializeField] private int _priceUpHealth;
    [SerializeField] private Player _player;
    [SerializeField] private ObjectPool _objectPool;

    public event UnityAction<int> HealthPriceChanged;
    public event UnityAction<int> MoneyPriceChanged;

    private void Start()
    {
        _objectPool.SetCapacity(PlayerPrefs.GetInt("Capacity"));
        _priceUpHealth = PlayerPrefs.GetInt("HealthPrice");
        _priceUpMoney = PlayerPrefs.GetInt("MoneyPrice");
        HealthPriceChanged?.Invoke(_priceUpHealth);
        MoneyPriceChanged?.Invoke(_priceUpMoney);
    }

    public void TryBuyHealth()
    {
        if (_priceUpHealth <= _player.Coins && _player.Health < 100)
        {
            _player.SubstractCoin(_priceUpHealth);

            _player.AddHealth(1);
            PlayerPrefs.SetInt("Health", _player.Health);
            _priceUpHealth += 25;
            PlayerPrefs.SetInt("HealthPrice", _priceUpHealth);
            HealthPriceChanged?.Invoke(_priceUpHealth);
        }
    }

    public void TryBuyMoney()
    {
        if (_priceUpMoney <= _player.Coins && _objectPool.Capacity < 7)
        {
            _player.SubstractCoin(_priceUpMoney);

            _objectPool.AddCapacity(1);
            PlayerPrefs.SetInt("Capacity", _objectPool.Capacity);
            _priceUpMoney += 100;
            PlayerPrefs.SetInt("MoneyPrice", _priceUpMoney);
            MoneyPriceChanged?.Invoke(_priceUpMoney);
        }
    }
}
