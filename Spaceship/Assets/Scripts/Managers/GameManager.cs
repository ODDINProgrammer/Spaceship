using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
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
}
