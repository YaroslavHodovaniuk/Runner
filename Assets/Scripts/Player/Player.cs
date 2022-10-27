using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _coins;

    private int _firstStart = 0;

    public int Health { get => _health; } //saved
    public int Coins { get => _coins; } //saved

    public event UnityAction<int> HealthChanged;
    public event UnityAction<int> CoinsChanged;
    public event UnityAction Died;

    private void Start()
    {
        _firstStart = PlayerPrefs.GetInt("FirstStart");
        if (_firstStart == 0)
        {
            PlayerPrefs.SetInt("Health",3);
            PlayerPrefs.SetInt("Coins", 0);
            PlayerPrefs.SetInt("HealthPrice", 25);
            PlayerPrefs.SetInt("MoneyPrice", 100);
            PlayerPrefs.SetInt("Capacity", 1);
            PlayerPrefs.SetInt("FirstStart", 1);
        }

        _health = PlayerPrefs.GetInt("Health");
        _coins = PlayerPrefs.GetInt("Coins");
        HealthChanged?.Invoke(_health);
        CoinsChanged?.Invoke(_coins);
    }

    public void ApllyDamege(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);

        if(_health <= 0)
            Die();
    }
    public void AddCoin(int coins)
    {
        _coins += coins;
        PlayerPrefs.SetInt("Coins", _coins);
        CoinsChanged?.Invoke(_coins);
    }
    public void SubstractCoin(int coins)
    {
        _coins -= coins;
        PlayerPrefs.SetInt("Coins", _coins);
        CoinsChanged?.Invoke(_coins);
    }

    public void AddHealth(int health)
    {
        _health += health;
        PlayerPrefs.SetInt("Health", _health);
        HealthChanged?.Invoke(_health);
    }
    public void Revive(int health)
    {
        _health = health;
        HealthChanged?.Invoke(_health);
    }
    public void Die()
    {
        Died?.Invoke();
    }
}
