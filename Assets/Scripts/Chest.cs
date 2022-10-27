using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private int _needWatch;
    [SerializeField] private TMP_Text _watchedText;
    [SerializeField] private Player _player;
    [SerializeField] private int _reward;
    [SerializeField] private TMP_Text _rewardText;

    private int _currentWatch;

    private void Start()
    {
        _watchedText.text = _currentWatch.ToString() + "/" + _needWatch;
        _rewardText.text = _reward.ToString();
    }

    public void Watch()
    {
        _currentWatch++;
        if( _currentWatch == _needWatch)
        {
            _watchedText.text = _currentWatch.ToString() + "/" + _needWatch;
            _currentWatch = 0;
            _player.AddCoin(_reward);
            _rewardText.text = _reward.ToString();
        }
            _watchedText.text = _currentWatch.ToString() + "/" + _needWatch;

    }
}
