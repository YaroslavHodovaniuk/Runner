using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _coinDisplay;

    private void OnEnable()
    {
        _player.CoinsChanged += OnCoinChanged;
    }

    private void OnDisable()
    {
        _player.CoinsChanged -= OnCoinChanged;
    }

    public void OnCoinChanged(int coin)
    {
        _coinDisplay.text = coin.ToString();
    }
}