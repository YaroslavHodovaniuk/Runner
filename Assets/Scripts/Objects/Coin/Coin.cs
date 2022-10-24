using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.AddCoin(_coin);
        }
        Destroy();
    }
    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
