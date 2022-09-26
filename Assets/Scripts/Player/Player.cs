using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public void ApllyDamege(int damage)
    {
        _health -= damage;
        if(_health <= 0)
            Die();
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
