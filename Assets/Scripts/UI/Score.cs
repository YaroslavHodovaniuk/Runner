using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentScore;
    [SerializeField] private TMP_Text _endScore;
    [SerializeField] private Player _player;

    private int _score;
    private int _maxScore;
    private float _elapsedTime;
    private void OnEnable()
    {
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }

    private void Start()
    {
        _maxScore = PlayerPrefs.GetInt("MaxScore");
    }
    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        _score = (int)(_elapsedTime * 100);
        _currentScore.text = "Score: \n" + _score.ToString();
    }
    private void OnDied()
    {
        if(_score > _maxScore)
        {
            _maxScore = _score;
            _endScore.text = "New Max Score: \n" + _score.ToString();
            PlayerPrefs.SetInt("MaxScore", _maxScore);
        }
        else
            _endScore.text = "Score: \n" + _score.ToString() +"\nMax Score: " + _maxScore.ToString();
    }
}
