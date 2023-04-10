using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float Distance { get { return _distance; } }
    public bool IsGameOver { get { return _isGameOver; } }

    private float _distance;
    private bool _isGameOver = false;

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

    private void Update()
    {
        RecordDistance();
    }

    private void RecordDistance()
    {
        _distance += Time.deltaTime;
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
    
    public void GameOver(bool _flag)
    {
        _isGameOver = _flag;
    }
}
