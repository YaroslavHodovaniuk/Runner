using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    public int Health { get => _health; } //saved
    [SerializeField] private int _coins;
    public int Coins { get => _coins; } //saved

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
    public void AddHealth(int health)
    {
        _health += health;
        PlayerPrefs.SetInt("Health", _health);
        HealthChanged?.Invoke(_health);
    }
    public void SubstractCoin(int coins)
    {
        _coins -= coins;
        PlayerPrefs.SetInt("Coins", _coins);
        CoinsChanged?.Invoke(_coins);
    }
    public void Die()
    {
        Died?.Invoke();
    }
}
