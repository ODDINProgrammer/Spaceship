using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float Distance { set { _distance = value; } get { return _distance; } }
   
    public bool IsGameOver { get { return _isGameOver; } }
    public bool GameStarted { get { return _gameStarted; } }

    private float _distance;

    private static bool _isGameOver = false;
    private static bool _gameStarted = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;

        }
        Destroy(this.gameObject);
    }

    public void RestartGame()
    {
        _isGameOver = false;
        _gameStarted = true;
        _distance = 0f;
    }

    public void ChangePauseState(bool _isPaused)
    {
        if(_isPaused)
        {
            Time.timeScale = 0f;
            return;
        }
        
        Time.timeScale = 1f;
    }   
    
    public void StartGame(bool _flag)
    {
        _gameStarted = _flag;
    }

    public void GameOver()
    {
        _isGameOver = true;
    }
}
