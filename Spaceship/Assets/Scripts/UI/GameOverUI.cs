using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private UnityEvent _onGameOver;

    private void OnEnable()
    {
        _onGameOver.Invoke();
    }

    public void SetText()
    {
        float _distance = Mathf.RoundToInt(GameManager.Instance.Distance);
        _text.text = $"You have flown {_distance} km!";
    }
}
