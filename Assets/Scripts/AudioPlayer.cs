using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _coin;
    [SerializeField] private AudioSource _hit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coin>())
        {
            _coin?.Play();
        }
        if (collision.GetComponent<Enemy>())
        {
            _hit?.Play();
            Handheld.Vibrate();
        }
    }
}
