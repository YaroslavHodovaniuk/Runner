using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health; //save
    [SerializeField] private int _coins; //save

    public event UnityAction<int> HealthChanged;
    public event UnityAction<int> CoinsChanged;
    public event UnityAction Died;

    private void Start()
    {
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
    public void AddHealth()
    {
        int price = 10;
        if(price <= _coins)
        {
            _coins -= price;
            PlayerPrefs.SetInt("Coins", _coins);
            _health++;
            PlayerPrefs.SetInt("Health", _health);
            HealthChanged?.Invoke(_health);
            CoinsChanged?.Invoke(_coins);
        }
    }
    public void Die()
    {
        Died?.Invoke();
    }
}
